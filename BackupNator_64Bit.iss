//Script Inno Setup para instalar BackupNatorApp

[Setup]
AppName=BackupNator
AppVersion=1.0.0.7
DefaultDirName={pf64}\BackupNator
DefaultGroupName=BackupNator
OutputBaseFilename=BackupNatorSetup_x64_1.0.0.7
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin
SetupIconFile=C:\Users\Andrezinho\Documents\GitHub\BackupNator\BackupNatorApp\Image\icon.ico

[InstallDelete]
Type: filesandordirs; Name: "{app}"

[Files]
// Copia todos os arquivos da pasta publish 
Source: "C:\Users\Andrezinho\Documents\GitHub\BackupNator\BackupNatorApp\bin\Release\net8.0-windows\publish\win-x64\*"; DestDir: "{app}"; Flags: recursesubdirs createallsubdirs

[Icons]
//Atalho no menu Iniciar
Name: "{group}\BackupNator"; Filename: "{app}\BackupNatorApp.exe"
// Atalho na área de trabalho
Name: "{userdesktop}\BackupNator"; Filename: "{app}\BackupNatorApp.exe"; Tasks: desktopicon

[Tasks]
Name: desktopicon; Description: "Criar atalho na área de trabalho"; GroupDescription: "Tarefas adicionais"; Flags: unchecked
