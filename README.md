# InstantRepair Mod for The Long Dark

## Описание
Этот мод добавляет консольную команду для мгновенной починки всех предметов в инвентаре игрока. Совместим с модом DeveloperConsole.

## Возможности
- Мгновенная починка всех поврежденных предметов в инвентаре
- Две команды: `repair_all` или `repairall` 
- Визуальные и звуковые уведомления о результате
- Детальная информация о починенных предметах в консоли

## Требования
- The Long Dark (версия 2.35 или новее)
- MelonLoader (версия 0.6.6 или новее)
- DeveloperConsole мод от FINDarkside

## Установка

### 1. Установка MelonLoader
1. Скачайте [MelonLoader.Installer.exe](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe)
2. Запустите установщик
3. Выберите The Long Dark из списка игр
4. Нажмите Install

### 2. Установка DeveloperConsole
1. Скачайте последнюю версию [DeveloperConsole.dll](https://github.com/FINDarkside/TLD-Developer-Console/releases)
2. Поместите файл в папку `Mods` в директории игры

### 3. Установка InstantRepair
1. Скачайте `InstantRepair.dll` из релизов
2. Поместите файл в папку `Mods` в директории игры

## Использование
1. Запустите игру
2. Загрузите сохранение
3. Нажмите F1 для открытия консоли разработчика
4. Введите команду `repair_all` или `repairall`
5. Нажмите Enter

Для компиляции мода InstantRepair вам нужно добавить следующие зависимости:

## 1. **MelonLoader зависимости** (из папки `\MelonLoader\net6\`):
- `MelonLoader.dll`
- `0Harmony.dll` 
- `Il2CppInterop.Runtime.dll`
- `Il2CppInterop.Common.dll`

## 2. **Il2Cpp игровые сборки** (из папки `\MelonLoader\Il2CppAssemblies\`):
- `Assembly-CSharp.dll` - основная сборка игры
- `Il2Cppmscorlib.dll` - базовые типы
- `Il2CppSystem.dll` - системные типы для коллекций
- `UnityEngine.dll` - базовый Unity
- `UnityEngine.CoreModule.dll` - ядро Unity

## 3. **Дополнительные зависимости** (могут понадобиться):
Если при компиляции будут ошибки, добавьте также:
- `UnityEngine.AudioModule.dll` - для звуков
- `UnityEngine.UI.dll` - для UI элементов
- `Il2CppSystem.Core.dll` - дополнительные системные типы

## Известные проблемы
- Команда работает только в режиме выживания (Survival)
- Не работает с предметами вне инвентаря (в контейнерах)

## Лицензия
Этот мод является бесплатным и может быть использован и модифицирован любым желающим.

## Благодарности
- FINDarkside за мод DeveloperConsole
- Сообществу The Long Dark Modding за документацию
- Разработчикам MelonLoader
