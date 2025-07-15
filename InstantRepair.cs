using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gear;
using MelonLoader;

namespace InstantRepair
{
    public class InstantRepairMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("InstantRepair mod initialized!");

            uConsole.RegisterCommand("repair_all", new System.Action(RepairAllItems));
            uConsole.RegisterCommand("repairall", new System.Action(RepairAllItems));

            MelonLogger.Msg("Console commands registered: repair_all, repairall");
        }

        private void RepairAllItems()
        {
            try
            {
                Inventory inventory = GameManager.GetInventoryComponent();

                if (inventory == null)
                {
                    MelonLogger.Warning("Cannot access inventory!");
                    uConsole.Log("ERROR: Cannot access player inventory");
                    return;
                }

                int repairedCount = 0;

                Il2CppSystem.Collections.Generic.List<GearItemObject> items = inventory.m_Items;

                for (int i = 0; i < items.Count; i++)
                {
                    GearItemObject gearItemObject = items[i];

                    if (gearItemObject != null)
                    {
                        GearItem gearItem = gearItemObject.m_GearItem;

                        if (gearItem != null && gearItem.CurrentHP < gearItem.GearItemData.m_MaxHP)
                        {
                            float oldCondition = gearItem.GetNormalizedCondition() * 100f;

                            gearItem.CurrentHP = gearItem.GearItemData.m_MaxHP;

                            gearItem.UpdateDamageShader();

                            string itemName = gearItem.DisplayName;
                            float newCondition = gearItem.GetNormalizedCondition() * 100f;

                            MelonLogger.Msg($"Repaired: {itemName} ({oldCondition:F0}% -> {newCondition:F0}%)");

                            repairedCount++;
                        }
                    }
                }

                if (repairedCount > 0)
                {
                    string message = $"Successfully repaired {repairedCount} item(s)!";
                    uConsole.Log(message);

                    HUDMessage.AddMessage(message, false, false);
                }
                else
                {
                    uConsole.Log("No items need repair");
                    HUDMessage.AddMessage("No items need repair", false, false);
                }
            }
            catch (System.Exception e)
            {
                MelonLogger.Error($"Error in RepairAllItems: {e.Message}");
                uConsole.Log($"ERROR: Failed to repair items - {e.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(uConsole), "Start")]
    public class ConsoleStartPatch
    {
        public static void Postfix()
        {
            MelonLogger.Msg("Developer Console loaded - InstantRepair commands available");
        }
    }
}