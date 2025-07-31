using Microsoft.Win32;
using System.Data;
using System.Text.Json;
using TaskScheduler;

namespace BackupNatorApp
{
    public partial class frmConfigurar : Form
    {
        public BackupConfig _config = new BackupConfig();
        private bool appLoad = true;
        public frmConfigurar()
        {
            InitializeComponent();
            CarregarConfiguracao();
        }

        private void frmConfigurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                menuStrip1.Visible = !menuStrip1.Visible;
            }
        }

        private void btnSelectOrigem(object sender, EventArgs e)
        {
            SelecionaNovoPath(listBoxOrigens);
        }

        private void btnSelectDestino(object sender, EventArgs e)
        {
            SelecionaNovoPath(listBoxDestinos);
        }

        private void CarregarConfiguracao(string nomeArquivoConfig = "appsettings.json")
        {

            //RegistryKey? chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            //chkIniciaWindows.Checked = chave?.GetValueNames().Contains("BackupNatorApp") ?? false;
            chkIniciaWindows.Checked = VerificarTarefaExiste("BackupNatorApp");

            string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                            "BackupNator",
                                            nomeArquivoConfig
                                          );

            listBoxOrigens.Items.Clear();
            listBoxDestinos.Items.Clear();
            DateTime? ultimoBackup = _config.UltimoBackup;


            if (File.Exists(caminho))
            {
                string json = File.ReadAllText(caminho);
                _config = JsonSerializer.Deserialize<BackupConfig>(json) ?? new BackupConfig();

                if (nomeArquivoConfig != "appsettings.json")
                    _config.UltimoBackup = ultimoBackup;
            }

            foreach (var origem in _config.Origens)
                listBoxOrigens.Items.Add(origem);

            foreach (var destino in _config.Destinos)
                listBoxDestinos.Items.Add(destino);

            //salva o estado da configuração antes de atribuir aos controles,
            //por conta dos gatilhos que sao acionados ao altera-los
            decimal intervalo = _config.IntervaloBackup;
            string? pastBackup = _config.NomePastaBackup;
            bool bkpAoIniciar = _config.BackupAoIniciar;

            numericUpDown1.Value = intervalo;
            txtNomePadraoPasta.Text = pastBackup;
            chkBackupAoLigar.Checked = bkpAoIniciar;
            panel1.Update();
            appLoad = false;
        }

        public void SalvarConfiguracao(string nomeArquivoConfig = "appsettings.json")
        {
            _config.Origens = listBoxOrigens.Items.Cast<string>().ToList();
            _config.Destinos = listBoxDestinos.Items.Cast<string>().ToList();
            _config.NomePastaBackup = txtNomePadraoPasta.Text;
            _config.IntervaloBackup = numericUpDown1.Value;
            _config.BackupAoIniciar = chkBackupAoLigar.Checked;

            string caminhoPastaDados = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                            "BackupNator"
                                          );

            string caminhoDados = Path.Combine(caminhoPastaDados,
                                                nomeArquivoConfig);

            if (!Directory.Exists(caminhoPastaDados))
                Directory.CreateDirectory(caminhoPastaDados);

            string json = JsonSerializer.Serialize(_config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoDados, json);
        }

        private void SelecionaNovoPath(ListBox listPath)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!listPath.Items.Contains(dialog.SelectedPath))
                    {
                        if (ValidaCaminhoSelecionado(dialog.SelectedPath, listPath))
                        {
                            listPath.Items.Add(dialog.SelectedPath);
                            SalvarConfiguracao();
                        }
                    }
                }
            }
        }

        private bool ValidaCaminhoSelecionado(string SelectedPath, ListBox lista)
        {
            bool jaExiste = lista.Items
                            .Cast<string>()
                            .Any(x => x.Equals(SelectedPath, StringComparison.OrdinalIgnoreCase));

            bool retorno = true;

            if (jaExiste)
            {
                MessageBox.Show($"Voce já adicionou esse caminho:\n\n{SelectedPath}",
                                        "Item Duplicados",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return false;
            }

            if (_config.Origens.Contains(SelectedPath) || _config.Destinos.Contains(SelectedPath))
            {
                MessageBox.Show($"Voce não pode selecionar um mesmo caminho como origem e destino ao mesmo tempo:\n\n{SelectedPath}",
                                        "Itens Duplicados",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return false;
            }

            // Verifica se o destino está dentro da origem para evitar loop
            if (lista.Name == listBoxDestinos.Name)
            {
                foreach (var origem in _config.Origens)
                {
                    if (SelectedPath.StartsWith(origem, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($@"Este diretório de destino está dentro de um dos diretórios de origem. Isso pode causar um loop infinito. {origem}",
                                        "Itens Duplicados",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        retorno = false;
                        continue;
                    }
                }
            }
            else
            {
                foreach (var destino in _config.Destinos)
                {
                    if (destino.StartsWith(SelectedPath, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($@"Um dos diretórios de destino está dentro deste diretório de origem. Isso pode causar um loop infinito. {destino}",
                                        "Itens Duplicados",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        retorno = false;
                        continue;
                    }
                }
            }

            return retorno;
        }

        private void salvarOpcoesComoPadraoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as configuraçoes como novo padrao ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SalvarConfiguracao("appsettingspadrao.json");
            }
        }

        private void restaurarPadraoSalvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja restaurar as configuraçoes salvas como padrao ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CarregarConfiguracao("appsettingspadrao.json");
                SalvarConfiguracao();
            }
        }

        private void txtNomePadraoPasta_TextChanged(object sender, EventArgs e)
        {
            SalvarConfiguracao();
        }

        private void btnDelItemOrigem_Click(object sender, EventArgs e)
        {
            DeletaItensSelecionados(listBoxOrigens);
            SalvarConfiguracao();
        }

        private void btnDelItemDestino_Click(object sender, EventArgs e)
        {
            DeletaItensSelecionados(listBoxDestinos);
            SalvarConfiguracao();
        }

        protected void DeletaItensSelecionados(ListBox lista)
        {
            var itensSelecionados = lista.SelectedItems.Cast<string>().ToList();
            foreach (var item in itensSelecionados)
            {
                lista.Items.Remove(item);
            }
        }

        private void listBoxOrigens_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelItemOrigem.Enabled = listBoxOrigens.SelectedItems.Count > 0;
        }

        private void listBoxDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelItemDestino.Enabled = listBoxDestinos.SelectedItems.Count > 0;
        }

        private void chkIniciaWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (!appLoad)
            {
                string nomeApp = "BackupNatorApp";
                string caminhoExe = Application.ExecutablePath;

                if (chkIniciaWindows.Checked)
                {
                    CriarTarefaAgendada(nomeApp, caminhoExe);
                    MessageBox.Show("App configurado para iniciar com o Windows.");
                }
                else
                    RemoverTarefaAgendada(nomeApp);

                SalvarConfiguracao();
            }
        }

        private void chkBackupAoLigar_CheckedChanged(object sender, EventArgs e)
        {
            SalvarConfiguracao();
        }

        private void CriarTarefaAgendada(string nomeTarefa, string caminhoExe)
        {
            TaskScheduler.TaskScheduler ts = new TaskScheduler.TaskScheduler();
            ts.Connect();

            ITaskFolder pastaRaiz = ts.GetFolder("\\");
            try { pastaRaiz.DeleteTask(nomeTarefa, 0); } catch { }

            ITaskDefinition td = ts.NewTask(0);
            td.RegistrationInfo.Description = "Inicia o BackupNator com privilégios elevados.";

            ITrigger trigger = td.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
            trigger.Enabled = true;

            IExecAction acao = (IExecAction)td.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            acao.Path = caminhoExe;

            td.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
            td.Principal.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            td.Principal.LogonType = _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN;

            pastaRaiz.RegisterTaskDefinition(
                nomeTarefa,
                td,
                (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE,
                null, null,
                _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                null
            );
        }

        private void RemoverTarefaAgendada(string nomeTarefa)
        {
            TaskScheduler.TaskScheduler ts = new TaskScheduler.TaskScheduler();
            ts.Connect();

            ITaskFolder pastaRaiz = ts.GetFolder("\\");
            try
            {
                pastaRaiz.DeleteTask(nomeTarefa, 0);
            }
            catch
            {
                // Silenciar erro se a tarefa não existir
            }
        }

        public bool VerificarTarefaExiste(string nomeTarefa)
        {
            try
            {
                TaskScheduler.TaskScheduler ts = new TaskScheduler.TaskScheduler();
                ts.Connect();

                ITaskFolder pastaRaiz = ts.GetFolder("\\");
                IRegisteredTask tarefa = pastaRaiz.GetTask(nomeTarefa);

                return tarefa != null;
            }
            catch (System.IO.FileNotFoundException)
            {
                // A tarefa não existe
                return false;
            }
            catch (Exception ex)
            {
                // Outro erro inesperado
                MessageBox.Show($"Erro ao verificar a tarefa: {ex.Message}");
                return false;
            }
        }

        private void numericUpDown1_Change(object sender, EventArgs e)
        {
            SalvarConfiguracao();
        }

        private void frmConfigurar_Shown(object sender, EventArgs e)
        {
            appLoad = true;
            CarregarConfiguracao();
        }
    }
}
