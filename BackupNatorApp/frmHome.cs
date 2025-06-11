using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Timers;

namespace BackupNatorApp
{
    public partial class frmHome : Form
    {
        frmConfigurar frmConfig;
        BackupConfig _config = new BackupConfig();
        HashSet<string> pastasVisitadas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private System.Timers.Timer timer = new System.Timers.Timer();

        public frmHome()
        {
            this.frmConfig = new frmConfigurar();
            frmConfig.FormClosing += FrmConfig_FormClosing;
            InitializeComponent();
            CarregarConfiguracao();
        }
        private void IniciarTimer()
        {
            if (_config.IntervaloBackup > 0)
            {
                timer = new System.Timers.Timer();
                timer.Interval = (double)_config.IntervaloBackup * 60 * 1000; //milissegundos
                timer.Elapsed += TimerHora_Elapsed;
                timer.AutoReset = true;
                timer.Enabled = true;
            }
        }

        private void TimerHora_Elapsed(object? sender, ElapsedEventArgs e)
        {
            ExecutarTarefa();
        }

        private void ExecutarTarefa()
        {
            Invoke(() =>
            {
                IniciaBackup(true);
            });

        }

        private void FrmConfig_FormClosing(object? sender, FormClosingEventArgs e)
        {
            CarregarConfiguracao();
        }

        private void btnExecutarBackup_Click(object sender, EventArgs e)
        {
            IniciaBackup();
        }

        private async void IniciaBackup(bool automatico = false)
        {
            notifyIcon1.ShowBalloonTip(1000, "BackupNator", "Realizando Backup em segundo plano...", ToolTipIcon.Info);
            pastasVisitadas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (automatico || MessageBox.Show("Deseja realizar o backup ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!(_config.Origens.Count > 0))
                {
                    MessageBox.Show($"Nenhuma origem de arquivos configurada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!(_config.Destinos.Count > 0))
                {
                    MessageBox.Show($"Nenhum destino para os arquivos configurado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rtxtPastasSalvas.AppendText($"Backup iniciado: {DateTime.Now} \n {string.Concat(Enumerable.Repeat("=", 30))}{Environment.NewLine}");
                try
                {
                    btnExecutarBackup.Enabled = false;
                    await Task.Run(() =>
                    {
                        foreach (var destino in _config.Destinos)
                        {
                            pastasVisitadas.Clear();

                            foreach (var origem in _config.Origens)
                            {
                                if (!Directory.Exists(origem))
                                {
                                    this.Invoke((Action)(() =>
                                    {
                                        MessageBox.Show($"Caminho de origem não encontrado: {origem}");
                                    }));
                                    continue;
                                }

                                string nomePastaOrigem = new DirectoryInfo(origem).Name;
                                string destinoCompleto = Path.Combine(destino, _config.NomePastaBackup, nomePastaOrigem);
                                this.Invoke((Action)(() =>
                                {
                                    lblStatus.Text = $@"Copiando: {origem} para: {destinoCompleto}";
                                    panel1.Update();
                                }));
                                CopiarDiretorio(origem, destinoCompleto);
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar arquivos: {ex.Message}");
                    return;
                }
                finally
                {
                    btnExecutarBackup.Enabled = true;
                }

                _config.UltimoBackup = DateTime.Now;
                frmConfig.SalvarConfiguracao();
                rtxtPastasSalvas.AppendText($@"Backup Concluído em: {_config.UltimoBackup}");
                lblStatus.Text = $@"Backup Concluído em: {_config.UltimoBackup}";
                lblUtimoBackup.Text = lblUtimoBackup.Text = $@"Ultimo Backup: {_config.UltimoBackup}";
                MessageBox.Show("Backup concluído com sucesso!");
                GeraLog();
            }
        }

        private List<string> mensagensPendentes = new List<string>();

        private void CopiarDiretorio(string origem, string destino)
        {
            if (pastasVisitadas.Contains(origem)) return;
            pastasVisitadas.Add(origem);

            Directory.CreateDirectory(destino);

            int contador = 0;
            foreach (string arquivo in Directory.GetFiles(origem))
            {
                File.Copy(arquivo, Path.Combine(destino, Path.GetFileName(arquivo)), true);

                mensagensPendentes.Add($"Copiado: {arquivo} para: {destino}{Environment.NewLine}");

                contador++;
                if (contador % 3 == 0)
                {
                    AtualizarLogUI();
                }
            }
            AtualizarLogUI();

            foreach (string dir in Directory.GetDirectories(origem))
                CopiarDiretorio(dir, Path.Combine(destino, Path.GetFileName(dir)));
        }

        private void AtualizarLogUI()
        {
            if (mensagensPendentes.Count == 0)
                return;

            var mensagens = string.Concat(mensagensPendentes);
            mensagensPendentes.Clear();

            this.Invoke(() =>
            {
                rtxtPastasSalvas.AppendText(mensagens);
                rtxtPastasSalvas.SelectionStart = rtxtPastasSalvas.Text.Length;
                rtxtPastasSalvas.ScrollToCaret();
            });
        }

        private void CarregarConfiguracao(string nomeArquivoConfig = "appsettings.json")
        {
            this._config = this.frmConfig._config;
            lblUtimoBackup.Text = $@"Ultimo Backup: {_config.UltimoBackup}";
            panel2.Update();
            IniciarTimer();
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                menuStrip1.Visible = !menuStrip1.Visible;
            }
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig.ShowDialog();
        }

        private void btnVerBackups_Click(object sender, EventArgs e)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _config.Destinos.ForEach(dest =>
                    Process.Start(new ProcessStartInfo("explorer.exe", dest) { UseShellExecute = true })
                );
            }
        }

        private void btnLimpaLog_Click(object sender, EventArgs e)
        {
            rtxtPastasSalvas.Clear();
        }

        private void GeraLog()
        {
            foreach (var destino in _config.Destinos)
            {
                string caminhoBase = Path.Combine(destino, _config.NomePastaBackup);
                var logsExistentes = Directory.GetFiles(caminhoBase)
                                .Where(arquivo => Path.GetFileName(arquivo).Contains("Log_Backup_"));

                if (logsExistentes.Count() == 3)
                    File.Delete(logsExistentes.First());

                string caminhoArquivo = Path.Combine(caminhoBase,
                                                    $"Log_Backup_{(DateTime.Now.ToString())
                                                                        .Replace(@"/", "-")
                                                                        .Replace(":", "_")}.txt");

                File.WriteAllText(caminhoArquivo, rtxtPastasSalvas.Text);
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o BackupNator ? Seus arquivos nao serão mais salvos.", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void tootStripAbrir_Click(object sender, EventArgs e)
        {
            RestauraApp();
        }

        private void toolStripConfigurar_Click(object sender, EventArgs e)
        {
            frmConfig.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestauraApp();
        }

        private void RestauraApp()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "BackupNator", "Rodando em segundo plano...", ToolTipIcon.Info);
            }
        }
    }
}
