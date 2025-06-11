namespace BackupNatorApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmHome());
            //try
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new frmHome());
            //}
            //catch (Exception ex)
            //{
            //    File.WriteAllText("erro.log", ex.ToString()); // ou exibir uma MessageBox
            //}
        }
    }
}