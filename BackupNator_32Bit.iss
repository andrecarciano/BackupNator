; Script Inno Setup para instalar BackupNatorApp

[Setup]
AppName=BackupNator_x86
AppVersion=1.0.1.0
DefaultDirName={pf32}\BackupNator_x86
DefaultGroupName=BackupNator_x86
OutputBaseFilename=BackupNatorSetup_x86_1.0.1.0
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin
SetupIconFile=C:\Users\Andrezinho\Documents\GitHub\BackupNator\BackupNatorApp\Image\icon.ico

[InstallDelete]
Type: filesandordirs; Name: "{app}"

[Files]
; Copia todos os arquivos da pasta publish 
Source: "C:\Users\Andrezinho\Documents\GitHub\BackupNator\BackupNatorApp\bin\Release\net8.0-windows\publish\win-x86\*"; DestDir: "{app}"; Flags: recursesubdirs createallsubdirs

[Icons]
; Atalho no menu Iniciar
Name: "{group}\BackupNator_x86"; Filename: "{app}\BackupNatorApp_x86.exe"
; Atalho na área de trabalho
Name: "{userdesktop}\BackupNator_x86"; Filename: "{app}\BackupNatorApp_x86.exe"; Tasks: desktopicon

[Tasks]
Name: desktopicon; Description: "Criar atalho na área de trabalho"; GroupDescription: "Tarefas adicionais"; Flags: unchecked
