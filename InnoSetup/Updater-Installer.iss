#define GameName "Your Game"
#define CompanyName "Your Company"
#define UpdaterFileName "YourUpdater"

[Setup]
AppName={#GameName}
AppPublisher={#CompanyName}
AppVersion=2.6.2
WizardStyle=modern
DefaultDirName="{localappdata}\{#GameName}"
DefaultGroupName={#GameName}
UninstallDisplayIcon="{app}\{#UpdaterFileName}.exe"
PrivilegesRequired=lowest
Compression=lzma2
SolidCompression=yes
OutputDir="Output\Production"
OutputBaseFilename="{#UpdaterFileName}-prod-v1.0"
CreateUninstallRegKey=no

[Files]
Source: "Updater\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Dirs]
Name: "{app}\Logs"    
Name: "{app}\Game"

[Icons]
Name: "{group}\{#GameName}"; Filename: "{app}\{#UpdaterFileName}.exe"
Name: "{userdesktop}\{#GameName}"; Filename: "{app}\{#UpdaterFileName}.exe"

[Run]
Filename: "{app}\{#UpdaterFileName}.exe";

[UninstallDelete]
Type: filesandordirs; Name: "{app}\Logs";
Type: filesandordirs; Name: "{app}\Game";