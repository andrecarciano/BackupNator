namespace BackupNatorApp
{
    partial class frmConfigurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurar));
            btnDelItemDestino = new Button();
            btnDelItemOrigem = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            listBoxOrigens = new ListBox();
            button1 = new Button();
            listBoxDestinos = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtNomePadraoPasta = new TextBox();
            menuStrip1 = new MenuStrip();
            opçoesToolStripMenuItem = new ToolStripMenuItem();
            salvarOpçoesComoPadraoToolStripMenuItem = new ToolStripMenuItem();
            restaurarPadraoSalvoToolStripMenuItem = new ToolStripMenuItem();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            chkIniciaWindows = new CheckBox();
            panel1 = new Panel();
            chkBackupAoLigar = new CheckBox();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelItemDestino
            // 
            btnDelItemDestino.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelItemDestino.Cursor = Cursors.Hand;
            btnDelItemDestino.Enabled = false;
            btnDelItemDestino.Image = Properties.Resources.EXCLUDEICON;
            btnDelItemDestino.Location = new Point(446, 265);
            btnDelItemDestino.Name = "btnDelItemDestino";
            btnDelItemDestino.Size = new Size(100, 41);
            btnDelItemDestino.TabIndex = 20;
            btnDelItemDestino.Text = "Excluir";
            btnDelItemDestino.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelItemDestino.UseVisualStyleBackColor = true;
            btnDelItemDestino.Click += btnDelItemDestino_Click;
            // 
            // btnDelItemOrigem
            // 
            btnDelItemOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelItemOrigem.Cursor = Cursors.Hand;
            btnDelItemOrigem.Enabled = false;
            btnDelItemOrigem.FlatAppearance.BorderSize = 0;
            btnDelItemOrigem.Image = Properties.Resources.EXCLUDEICON;
            btnDelItemOrigem.Location = new Point(446, 109);
            btnDelItemOrigem.Name = "btnDelItemOrigem";
            btnDelItemOrigem.Size = new Size(100, 41);
            btnDelItemOrigem.TabIndex = 19;
            btnDelItemOrigem.Text = "Excluir";
            btnDelItemOrigem.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelItemOrigem.UseVisualStyleBackColor = true;
            btnDelItemOrigem.Click += btnDelItemOrigem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(13, 164);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 18;
            label2.Text = "Destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 17;
            label1.Text = "Origem";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.Image = Properties.Resources.ADDICON;
            button2.Location = new Point(446, 182);
            button2.Name = "button2";
            button2.Size = new Size(100, 41);
            button2.TabIndex = 16;
            button2.Text = "Adicionar Destino";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSelectDestino;
            // 
            // listBoxOrigens
            // 
            listBoxOrigens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrigens.FormattingEnabled = true;
            listBoxOrigens.ItemHeight = 15;
            listBoxOrigens.Location = new Point(13, 26);
            listBoxOrigens.Name = "listBoxOrigens";
            listBoxOrigens.SelectionMode = SelectionMode.MultiSimple;
            listBoxOrigens.Size = new Size(427, 124);
            listBoxOrigens.TabIndex = 13;
            listBoxOrigens.SelectedIndexChanged += listBoxOrigens_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Image = Properties.Resources.ADDICON;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(446, 26);
            button1.Name = "button1";
            button1.Size = new Size(100, 41);
            button1.TabIndex = 15;
            button1.Text = "Adicionar Origem";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelectOrigem;
            // 
            // listBoxDestinos
            // 
            listBoxDestinos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxDestinos.FormattingEnabled = true;
            listBoxDestinos.ItemHeight = 15;
            listBoxDestinos.Location = new Point(13, 182);
            listBoxDestinos.Name = "listBoxDestinos";
            listBoxDestinos.SelectionMode = SelectionMode.MultiSimple;
            listBoxDestinos.Size = new Size(427, 124);
            listBoxDestinos.TabIndex = 14;
            listBoxDestinos.SelectedIndexChanged += listBoxDestinos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 4);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 21;
            label3.Text = "Configurações";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(13, 42);
            label4.Name = "label4";
            label4.Size = new Size(191, 15);
            label4.TabIndex = 23;
            label4.Text = "Nome Padrao da pasta de Backup";
            // 
            // txtNomePadraoPasta
            // 
            txtNomePadraoPasta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtNomePadraoPasta.Location = new Point(13, 60);
            txtNomePadraoPasta.Name = "txtNomePadraoPasta";
            txtNomePadraoPasta.Size = new Size(188, 23);
            txtNomePadraoPasta.TabIndex = 22;
            txtNomePadraoPasta.TextChanged += txtNomePadraoPasta_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçoesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.TextDirection = ToolStripTextDirection.Vertical270;
            menuStrip1.UseWaitCursor = true;
            menuStrip1.Visible = false;
            // 
            // opçoesToolStripMenuItem
            // 
            opçoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvarOpçoesComoPadraoToolStripMenuItem, restaurarPadraoSalvoToolStripMenuItem });
            opçoesToolStripMenuItem.Name = "opçoesToolStripMenuItem";
            opçoesToolStripMenuItem.Size = new Size(59, 20);
            opçoesToolStripMenuItem.Text = "Opçoes";
            opçoesToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // salvarOpçoesComoPadraoToolStripMenuItem
            // 
            salvarOpçoesComoPadraoToolStripMenuItem.Name = "salvarOpçoesComoPadraoToolStripMenuItem";
            salvarOpçoesComoPadraoToolStripMenuItem.Size = new Size(257, 22);
            salvarOpçoesComoPadraoToolStripMenuItem.Text = "Salvar configurações como padrao";
            salvarOpçoesComoPadraoToolStripMenuItem.Click += salvarOpcoesComoPadraoToolStripMenuItem_Click;
            // 
            // restaurarPadraoSalvoToolStripMenuItem
            // 
            restaurarPadraoSalvoToolStripMenuItem.Name = "restaurarPadraoSalvoToolStripMenuItem";
            restaurarPadraoSalvoToolStripMenuItem.Size = new Size(257, 22);
            restaurarPadraoSalvoToolStripMenuItem.Text = "Restaurar Config Padrao Salvo";
            restaurarPadraoSalvoToolStripMenuItem.Click += restaurarPadraoSalvoToolStripMenuItem_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(212, 62);
            numericUpDown1.Maximum = new decimal(new int[] { 480, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = RightToLeft.Yes;
            numericUpDown1.Size = new Size(87, 23);
            numericUpDown1.TabIndex = 26;
            numericUpDown1.ValueChanged += numericUpDown1_Change;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(210, 42);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 27;
            label5.Text = "Intervalo de Backup Automatico";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(316, 64);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 28;
            label6.Text = "Minutos";
            // 
            // chkIniciaWindows
            // 
            chkIniciaWindows.AutoSize = true;
            chkIniciaWindows.Location = new Point(416, 42);
            chkIniciaWindows.Name = "chkIniciaWindows";
            chkIniciaWindows.Size = new Size(147, 19);
            chkIniciaWindows.TabIndex = 29;
            chkIniciaWindows.Text = "Iniciar com o Windows";
            chkIniciaWindows.UseVisualStyleBackColor = true;
            chkIniciaWindows.CheckedChanged += chkIniciaWindows_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkBackupAoLigar);
            panel1.Controls.Add(txtNomePadraoPasta);
            panel1.Controls.Add(chkIniciaWindows);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericUpDown1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 98);
            panel1.TabIndex = 30;
            // 
            // chkBackupAoLigar
            // 
            chkBackupAoLigar.AutoSize = true;
            chkBackupAoLigar.Location = new Point(416, 66);
            chkBackupAoLigar.Name = "chkBackupAoLigar";
            chkBackupAoLigar.Size = new Size(110, 19);
            chkBackupAoLigar.TabIndex = 30;
            chkBackupAoLigar.Text = "Backup ao Ligar";
            chkBackupAoLigar.UseVisualStyleBackColor = true;
            chkBackupAoLigar.CheckedChanged += chkBackupAoLigar_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelItemDestino);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnDelItemOrigem);
            panel2.Controls.Add(listBoxDestinos);
            panel2.Controls.Add(listBoxOrigens);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 343);
            panel2.TabIndex = 31;
            // 
            // frmConfigurar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 441);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfigurar";
            Text = "Backupnator - Configurações";
            Shown += frmConfigurar_Shown;
            KeyDown += frmConfigurar_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelItemDestino;
        private Button btnDelItemOrigem;
        private Label label2;
        private Label label1;
        private Button button2;
        private ListBox listBoxOrigens;
        private Button button1;
        private ListBox listBoxDestinos;
        private Label label3;
        private Label label4;
        private TextBox txtNomePadraoPasta;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçoesToolStripMenuItem;
        private ToolStripMenuItem salvarOpçoesComoPadraoToolStripMenuItem;
        private ToolStripMenuItem restaurarPadraoSalvoToolStripMenuItem;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private CheckBox chkIniciaWindows;
        private Panel panel1;
        private Panel panel2;
        private CheckBox chkBackupAoLigar;
    }
}