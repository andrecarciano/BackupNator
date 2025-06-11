using System.Collections.Generic;

namespace BackupNatorApp
{
    public class BackupConfig
    {
        public BackupConfig()
        {
            Origens = new List<string>();

            Destinos = new List<string>();

            NomePastaBackup = "Pasta_Backup_Padrao";

            IntervaloBackup = 0;
        }

        public List<string> Origens { get; set; }
        public List<string> Destinos { get; set; }
        public string NomePastaBackup { get; set; }
        public DateTime? UltimoBackup { get; set; }
        public decimal IntervaloBackup { get; set; }
    }
}