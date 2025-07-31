namespace BackupNatorApp
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            btnExecutarBackup = new Button();
            menuStrip1 = new MenuStrip();
            opçoesToolStripMenuItem = new ToolStripMenuItem();
            configurarToolStripMenuItem = new ToolStripMenuItem();
            lblStatus = new Label();
            panel1 = new Panel();
            lblUtimoBackup = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnLimpaLog = new Button();
            label1 = new Label();
            btnVerBackups = new Button();
            rtxtPastasSalvas = new RichTextBox();
            lblTitlePastasSalvas = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            tootStripAbrir = new ToolStripMenuItem();
            toolStripConfigurar = new ToolStripMenuItem();
            toolStripFechar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExecutarBackup
            // 
            btnExecutarBackup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExecutarBackup.Cursor = Cursors.Hand;
            btnExecutarBackup.Image = Properties.Resources.backupbtn;
            btnExecutarBackup.ImageAlign = ContentAlignment.MiddleLeft;
            btnExecutarBackup.Location = new Point(282, 223);
            btnExecutarBackup.Name = "btnExecutarBackup";
            btnExecutarBackup.Size = new Size(110, 45);
            btnExecutarBackup.TabIndex = 6;
            btnExecutarBackup.Text = "Realizar Backup";
            btnExecutarBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExecutarBackup.UseVisualStyleBackColor = true;
            btnExecutarBackup.Click += btnExecutarBackup_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçoesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(520, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.TextDirection = ToolStripTextDirection.Vertical270;
            menuStrip1.UseWaitCursor = true;
            menuStrip1.Visible = false;
            // 
            // opçoesToolStripMenuItem
            // 
            opçoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarToolStripMenuItem });
            opçoesToolStripMenuItem.Name = "opçoesToolStripMenuItem";
            opçoesToolStripMenuItem.Size = new Size(59, 20);
            opçoesToolStripMenuItem.Text = "Opçoes";
            opçoesToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // configurarToolStripMenuItem
            // 
            configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            configurarToolStripMenuItem.Size = new Size(151, 22);
            configurarToolStripMenuItem.Text = "Configurações";
            configurarToolStripMenuItem.Click += configurarToolStripMenuItem_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(13, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(73, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Aguardando";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUtimoBackup);
            panel1.Controls.Add(lblStatus);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 25);
            panel1.TabIndex = 13;
            // 
            // lblUtimoBackup
            // 
            lblUtimoBackup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUtimoBackup.AutoSize = true;
            lblUtimoBackup.ForeColor = Color.Green;
            lblUtimoBackup.Location = new Point(311, 4);
            lblUtimoBackup.Name = "lblUtimoBackup";
            lblUtimoBackup.Size = new Size(166, 15);
            lblUtimoBackup.TabIndex = 13;
            lblUtimoBackup.Text = "Ultimo Backup: Não Realizado";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 282);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLimpaLog);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnVerBackups);
            panel3.Controls.Add(btnExecutarBackup);
            panel3.Controls.Add(rtxtPastasSalvas);
            panel3.Controls.Add(lblTitlePastasSalvas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 282);
            panel3.TabIndex = 14;
            // 
            // btnLimpaLog
            // 
            btnLimpaLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpaLog.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpaLog.Cursor = Cursors.Hand;
            btnLimpaLog.Image = Properties.Resources.EXCLUDEICON;
            btnLimpaLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpaLog.Location = new Point(10, 223);
            btnLimpaLog.Name = "btnLimpaLog";
            btnLimpaLog.Size = new Size(110, 45);
            btnLimpaLog.TabIndex = 14;
            btnLimpaLog.Text = "Limpar Log";
            btnLimpaLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpaLog.UseVisualStyleBackColor = true;
            btnLimpaLog.Click += btnLimpaLog_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Green;
            label1.Location = new Point(631, 4);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 13;
            label1.Text = "Ultimo Backup: Não Realizado";
            // 
            // btnVerBackups
            // 
            btnVerBackups.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVerBackups.Cursor = Cursors.Hand;
            btnVerBackups.Image = Properties.Resources.view;
            btnVerBackups.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerBackups.Location = new Point(398, 223);
            btnVerBackups.Name = "btnVerBackups";
            btnVerBackups.Size = new Size(110, 45);
            btnVerBackups.TabIndex = 7;
            btnVerBackups.Text = "Ver Ultimos Backups";
            btnVerBackups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerBackups.UseVisualStyleBackColor = true;
            btnVerBackups.Click += btnVerBackups_Click;
            // 
            // rtxtPastasSalvas
            // 
            rtxtPastasSalvas.Location = new Point(10, 39);
            rtxtPastasSalvas.MaxLength = 2000000000;
            rtxtPastasSalvas.Name = "rtxtPastasSalvas";
            rtxtPastasSalvas.ReadOnly = true;
            rtxtPastasSalvas.Size = new Size(498, 150);
            rtxtPastasSalvas.TabIndex = 9;
            rtxtPastasSalvas.Text = "";
            // 
            // lblTitlePastasSalvas
            // 
            lblTitlePastasSalvas.AutoSize = true;
            lblTitlePastasSalvas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlePastasSalvas.Location = new Point(13, 9);
            lblTitlePastasSalvas.Name = "lblTitlePastasSalvas";
            lblTitlePastasSalvas.Size = new Size(143, 21);
            lblTitlePastasSalvas.TabIndex = 8;
            lblTitlePastasSalvas.Text = "Log de operações";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "BackupNator em Segundo Plano";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tootStripAbrir, toolStripConfigurar, toolStripFechar });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(132, 70);
            // 
            // tootStripAbrir
            // 
            tootStripAbrir.Name = "tootStripAbrir";
            tootStripAbrir.Size = new Size(131, 22);
            tootStripAbrir.Text = "Abrir";
            tootStripAbrir.Click += tootStripAbrir_Click;
            // 
            // toolStripConfigurar
            // 
            toolStripConfigurar.Name = "toolStripConfigurar";
            toolStripConfigurar.Size = new Size(131, 22);
            toolStripConfigurar.Text = "Configurar";
            toolStripConfigurar.ToolTipText = "Configurar";
            toolStripConfigurar.Click += toolStripConfigurar_Click;
            // 
            // toolStripFechar
            // 
            toolStripFechar.Name = "toolStripFechar";
            toolStripFechar.Size = new Size(131, 22);
            toolStripFechar.Text = "Fechar";
            toolStripFechar.Click += Fechar_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 307);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimumSize = new Size(200, 200);
            Name = "frmHome";
            ShowInTaskbar = false;
            Text = "BackupNator 1.0";
            WindowState = FormWindowState.Minimized;
            FormClosing += frmHome_FormClosing;
            Load += frmHome_Load;
            KeyDown += frmHome_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExecutarBackup;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçoesToolStripMenuItem;
        private Label lblStatus;
        private Panel panel1;
        private Panel panel2;
        private Label lblUtimoBackup;
        private ToolStripMenuItem configurarToolStripMenuItem;
        private Button btnVerBackups;
        private Label lblTitlePastasSalvas;
        private RichTextBox rtxtPastasSalvas;
        private Panel panel3;
        private Label label1;
        private Button btnLimpaLog;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripFechar;
        private ToolStripMenuItem tootStripAbrir;
        private ToolStripMenuItem toolStripConfigurar;
    }
}
