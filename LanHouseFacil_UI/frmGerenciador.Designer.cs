namespace LanHouseFacil
{
    partial class frmGerenciador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTempoRestante = new System.Windows.Forms.MaskedTextBox();
            this.btnTravarMicro = new System.Windows.Forms.Button();
            this.btnReiniciarMicro = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblMicroSelecionado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTempoPendente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskINICIO = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mskTempoInsert = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Micro1 = new System.Windows.Forms.ToolStripLabel();
            this.Micro2 = new System.Windows.Forms.ToolStripLabel();
            this.Micro3 = new System.Windows.Forms.ToolStripLabel();
            this.Micro4 = new System.Windows.Forms.ToolStripLabel();
            this.Micro5 = new System.Windows.Forms.ToolStripLabel();
            this.Micro6 = new System.Windows.Forms.ToolStripLabel();
            this.Micro7 = new System.Windows.Forms.ToolStripLabel();
            this.Micro8 = new System.Windows.Forms.ToolStripLabel();
            this.Micro9 = new System.Windows.Forms.ToolStripLabel();
            this.Micro10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Micro11 = new System.Windows.Forms.ToolStripLabel();
            this.Micro12 = new System.Windows.Forms.ToolStripLabel();
            this.Micro13 = new System.Windows.Forms.ToolStripLabel();
            this.Micro14 = new System.Windows.Forms.ToolStripLabel();
            this.Micro15 = new System.Windows.Forms.ToolStripLabel();
            this.Micro16 = new System.Windows.Forms.ToolStripLabel();
            this.Micro17 = new System.Windows.Forms.ToolStripLabel();
            this.Micro18 = new System.Windows.Forms.ToolStripLabel();
            this.Micro19 = new System.Windows.Forms.ToolStripLabel();
            this.Micro20 = new System.Windows.Forms.ToolStripLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pctSocket = new System.Windows.Forms.PictureBox();
            this.microOFF = new System.Windows.Forms.Button();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnAcessoLivre = new System.Windows.Forms.Button();
            this.timerShutdownOFF = new System.Windows.Forms.Timer(this.components);
            this.timerThread = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mskTempoRestante);
            this.panel1.Controls.Add(this.btnTravarMicro);
            this.panel1.Controls.Add(this.btnReiniciarMicro);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.btnLigar);
            this.panel1.Controls.Add(this.lblMicroSelecionado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mskTempoPendente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mskINICIO);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mskTempoInsert);
            this.panel1.Location = new System.Drawing.Point(1, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 275);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TEMPO RESTANTE";
            // 
            // mskTempoRestante
            // 
            this.mskTempoRestante.BackColor = System.Drawing.Color.Black;
            this.mskTempoRestante.Enabled = false;
            this.mskTempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTempoRestante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mskTempoRestante.Location = new System.Drawing.Point(126, 127);
            this.mskTempoRestante.Name = "mskTempoRestante";
            this.mskTempoRestante.Size = new System.Drawing.Size(153, 29);
            this.mskTempoRestante.TabIndex = 12;
            this.mskTempoRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTravarMicro
            // 
            this.btnTravarMicro.BackColor = System.Drawing.Color.Red;
            this.btnTravarMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravarMicro.ForeColor = System.Drawing.Color.White;
            this.btnTravarMicro.Location = new System.Drawing.Point(87, 162);
            this.btnTravarMicro.Name = "btnTravarMicro";
            this.btnTravarMicro.Size = new System.Drawing.Size(74, 35);
            this.btnTravarMicro.TabIndex = 3;
            this.btnTravarMicro.Text = "Travar";
            this.btnTravarMicro.UseVisualStyleBackColor = false;
            this.btnTravarMicro.Click += new System.EventHandler(this.btnTravarMicro_Click);
            // 
            // btnReiniciarMicro
            // 
            this.btnReiniciarMicro.BackColor = System.Drawing.Color.Red;
            this.btnReiniciarMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarMicro.ForeColor = System.Drawing.Color.White;
            this.btnReiniciarMicro.Location = new System.Drawing.Point(205, 163);
            this.btnReiniciarMicro.Name = "btnReiniciarMicro";
            this.btnReiniciarMicro.Size = new System.Drawing.Size(74, 35);
            this.btnReiniciarMicro.TabIndex = 4;
            this.btnReiniciarMicro.Text = "Reiniciar";
            this.btnReiniciarMicro.UseVisualStyleBackColor = false;
            this.btnReiniciarMicro.Click += new System.EventHandler(this.btnReiniciarMicro_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(3, 251);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 13);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "xxxxxx";
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.Green;
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.Color.White;
            this.btnLigar.Location = new System.Drawing.Point(11, 203);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(75, 35);
            this.btnLigar.TabIndex = 2;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblMicroSelecionado
            // 
            this.lblMicroSelecionado.AutoSize = true;
            this.lblMicroSelecionado.BackColor = System.Drawing.Color.Red;
            this.lblMicroSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicroSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblMicroSelecionado.Location = new System.Drawing.Point(-1, 0);
            this.lblMicroSelecionado.Name = "lblMicroSelecionado";
            this.lblMicroSelecionado.Size = new System.Drawing.Size(0, 25);
            this.lblMicroSelecionado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ACESSO FIM:";
            // 
            // mskTempoPendente
            // 
            this.mskTempoPendente.BackColor = System.Drawing.Color.Black;
            this.mskTempoPendente.Enabled = false;
            this.mskTempoPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTempoPendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mskTempoPendente.Location = new System.Drawing.Point(126, 92);
            this.mskTempoPendente.Name = "mskTempoPendente";
            this.mskTempoPendente.Size = new System.Drawing.Size(153, 29);
            this.mskTempoPendente.TabIndex = 6;
            this.mskTempoPendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TEMPO SOLICITADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ACESSO INÍCIO";
            // 
            // mskINICIO
            // 
            this.mskINICIO.BackColor = System.Drawing.Color.Black;
            this.mskINICIO.Enabled = false;
            this.mskINICIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskINICIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mskINICIO.Location = new System.Drawing.Point(126, 57);
            this.mskINICIO.Name = "mskINICIO";
            this.mskINICIO.Size = new System.Drawing.Size(153, 29);
            this.mskINICIO.TabIndex = 3;
            this.mskINICIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(205, 203);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Desligar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Tempo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskTempoInsert
            // 
            this.mskTempoInsert.BackColor = System.Drawing.Color.Black;
            this.mskTempoInsert.Enabled = false;
            this.mskTempoInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTempoInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mskTempoInsert.Location = new System.Drawing.Point(126, 22);
            this.mskTempoInsert.Name = "mskTempoInsert";
            this.mskTempoInsert.Size = new System.Drawing.Size(153, 29);
            this.mskTempoInsert.TabIndex = 0;
            this.mskTempoInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Wallpaper";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Task ON/OFF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(592, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Botão Iniciar ON/OFF";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(511, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "CTRL+ALT+DEL";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Micro1,
            this.Micro2,
            this.Micro3,
            this.Micro4,
            this.Micro5,
            this.Micro6,
            this.Micro7,
            this.Micro8,
            this.Micro9,
            this.Micro10});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 59);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Micro1
            // 
            this.Micro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Micro1.DoubleClickEnabled = true;
            this.Micro1.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro1.Name = "Micro1";
            this.Micro1.RightToLeftAutoMirrorImage = true;
            this.Micro1.Size = new System.Drawing.Size(65, 56);
            this.Micro1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro1.ToolTipText = "1";
            this.Micro1.Click += new System.EventHandler(this.Micro1_Click_1);
            // 
            // Micro2
            // 
            this.Micro2.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro2.Name = "Micro2";
            this.Micro2.RightToLeftAutoMirrorImage = true;
            this.Micro2.Size = new System.Drawing.Size(65, 56);
            this.Micro2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro2.ToolTipText = "2";
            this.Micro2.Click += new System.EventHandler(this.Micro2_Click);
            // 
            // Micro3
            // 
            this.Micro3.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro3.Name = "Micro3";
            this.Micro3.RightToLeftAutoMirrorImage = true;
            this.Micro3.Size = new System.Drawing.Size(65, 56);
            this.Micro3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro3.ToolTipText = "3";
            this.Micro3.Click += new System.EventHandler(this.Micro3_Click);
            // 
            // Micro4
            // 
            this.Micro4.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro4.Name = "Micro4";
            this.Micro4.RightToLeftAutoMirrorImage = true;
            this.Micro4.Size = new System.Drawing.Size(65, 56);
            this.Micro4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro4.ToolTipText = "4";
            this.Micro4.Click += new System.EventHandler(this.Micro4_Click);
            // 
            // Micro5
            // 
            this.Micro5.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro5.Name = "Micro5";
            this.Micro5.RightToLeftAutoMirrorImage = true;
            this.Micro5.Size = new System.Drawing.Size(65, 56);
            this.Micro5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro5.ToolTipText = "5";
            this.Micro5.Click += new System.EventHandler(this.Micro5_Click);
            // 
            // Micro6
            // 
            this.Micro6.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro6.Name = "Micro6";
            this.Micro6.RightToLeftAutoMirrorImage = true;
            this.Micro6.Size = new System.Drawing.Size(65, 56);
            this.Micro6.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro6.ToolTipText = "6";
            this.Micro6.Click += new System.EventHandler(this.Micro6_Click);
            // 
            // Micro7
            // 
            this.Micro7.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro7.Name = "Micro7";
            this.Micro7.RightToLeftAutoMirrorImage = true;
            this.Micro7.Size = new System.Drawing.Size(65, 56);
            this.Micro7.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro7.ToolTipText = "7";
            this.Micro7.Click += new System.EventHandler(this.Micro7_Click);
            // 
            // Micro8
            // 
            this.Micro8.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro8.Name = "Micro8";
            this.Micro8.RightToLeftAutoMirrorImage = true;
            this.Micro8.Size = new System.Drawing.Size(65, 56);
            this.Micro8.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro8.ToolTipText = "8";
            this.Micro8.Click += new System.EventHandler(this.Micro8_Click);
            // 
            // Micro9
            // 
            this.Micro9.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro9.Name = "Micro9";
            this.Micro9.RightToLeftAutoMirrorImage = true;
            this.Micro9.Size = new System.Drawing.Size(65, 56);
            this.Micro9.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro9.ToolTipText = "9";
            this.Micro9.Click += new System.EventHandler(this.Micro9_Click);
            // 
            // Micro10
            // 
            this.Micro10.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro10.Name = "Micro10";
            this.Micro10.RightToLeftAutoMirrorImage = true;
            this.Micro10.Size = new System.Drawing.Size(65, 56);
            this.Micro10.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro10.ToolTipText = "10";
            this.Micro10.Click += new System.EventHandler(this.Micro10_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Micro11,
            this.Micro12,
            this.Micro13,
            this.Micro14,
            this.Micro15,
            this.Micro16,
            this.Micro17,
            this.Micro18,
            this.Micro19,
            this.Micro20});
            this.toolStrip2.Location = new System.Drawing.Point(0, 59);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(795, 59);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Micro11
            // 
            this.Micro11.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro11.Name = "Micro11";
            this.Micro11.RightToLeftAutoMirrorImage = true;
            this.Micro11.Size = new System.Drawing.Size(65, 56);
            this.Micro11.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro11.ToolTipText = "11";
            this.Micro11.Click += new System.EventHandler(this.Micro11_Click);
            // 
            // Micro12
            // 
            this.Micro12.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro12.Name = "Micro12";
            this.Micro12.RightToLeftAutoMirrorImage = true;
            this.Micro12.Size = new System.Drawing.Size(65, 56);
            this.Micro12.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro12.ToolTipText = "12";
            this.Micro12.Click += new System.EventHandler(this.Micro12_Click_1);
            // 
            // Micro13
            // 
            this.Micro13.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro13.Name = "Micro13";
            this.Micro13.RightToLeftAutoMirrorImage = true;
            this.Micro13.Size = new System.Drawing.Size(65, 56);
            this.Micro13.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro13.ToolTipText = "13";
            this.Micro13.Click += new System.EventHandler(this.Micro13_Click);
            // 
            // Micro14
            // 
            this.Micro14.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro14.Name = "Micro14";
            this.Micro14.RightToLeftAutoMirrorImage = true;
            this.Micro14.Size = new System.Drawing.Size(65, 56);
            this.Micro14.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro14.ToolTipText = "14";
            this.Micro14.Click += new System.EventHandler(this.Micro14_Click);
            // 
            // Micro15
            // 
            this.Micro15.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro15.Name = "Micro15";
            this.Micro15.RightToLeftAutoMirrorImage = true;
            this.Micro15.Size = new System.Drawing.Size(65, 56);
            this.Micro15.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro15.ToolTipText = "15";
            this.Micro15.Click += new System.EventHandler(this.Micro15_Click);
            // 
            // Micro16
            // 
            this.Micro16.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro16.Name = "Micro16";
            this.Micro16.RightToLeftAutoMirrorImage = true;
            this.Micro16.Size = new System.Drawing.Size(65, 56);
            this.Micro16.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro16.ToolTipText = "16";
            this.Micro16.Click += new System.EventHandler(this.Micro16_Click);
            // 
            // Micro17
            // 
            this.Micro17.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro17.Name = "Micro17";
            this.Micro17.RightToLeftAutoMirrorImage = true;
            this.Micro17.Size = new System.Drawing.Size(65, 56);
            this.Micro17.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro17.ToolTipText = "17";
            this.Micro17.Click += new System.EventHandler(this.Micro17_Click);
            // 
            // Micro18
            // 
            this.Micro18.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro18.Name = "Micro18";
            this.Micro18.RightToLeftAutoMirrorImage = true;
            this.Micro18.Size = new System.Drawing.Size(65, 56);
            this.Micro18.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro18.ToolTipText = "16";
            this.Micro18.Click += new System.EventHandler(this.Micro18_Click);
            // 
            // Micro19
            // 
            this.Micro19.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro19.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro19.Name = "Micro19";
            this.Micro19.RightToLeftAutoMirrorImage = true;
            this.Micro19.Size = new System.Drawing.Size(65, 56);
            this.Micro19.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro19.ToolTipText = "19";
            this.Micro19.Click += new System.EventHandler(this.Micro19_Click);
            // 
            // Micro20
            // 
            this.Micro20.Image = global::LanHouseFacil.Properties.Resources.pc1;
            this.Micro20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Micro20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Micro20.Name = "Micro20";
            this.Micro20.RightToLeftAutoMirrorImage = true;
            this.Micro20.Size = new System.Drawing.Size(65, 56);
            this.Micro20.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Micro20.ToolTipText = "20";
            this.Micro20.Click += new System.EventHandler(this.Micro20_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 264);
            this.listBox1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 8600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pctSocket
            // 
            this.pctSocket.Image = global::LanHouseFacil.Properties.Resources.ajax_loader;
            this.pctSocket.Location = new System.Drawing.Point(1, 438);
            this.pctSocket.Name = "pctSocket";
            this.pctSocket.Size = new System.Drawing.Size(30, 31);
            this.pctSocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSocket.TabIndex = 9;
            this.pctSocket.TabStop = false;
            // 
            // microOFF
            // 
            this.microOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.microOFF.Image = ((System.Drawing.Image)(resources.GetObject("microOFF.Image")));
            this.microOFF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.microOFF.Location = new System.Drawing.Point(727, 59);
            this.microOFF.Name = "microOFF";
            this.microOFF.Size = new System.Drawing.Size(63, 59);
            this.microOFF.TabIndex = 8;
            this.microOFF.Text = "&Sair";
            this.microOFF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.microOFF.UseVisualStyleBackColor = true;
            this.microOFF.Click += new System.EventHandler(this.microOFF_Click);
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.Red;
            this.lblVersao.Location = new System.Drawing.Point(-3, 472);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(172, 26);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "V1.3  \r\nhttps://github.com/alexsandersalinas";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAcessoLivre
            // 
            this.btnAcessoLivre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcessoLivre.Image = global::LanHouseFacil.Properties.Resources.pc3;
            this.btnAcessoLivre.Location = new System.Drawing.Point(726, -1);
            this.btnAcessoLivre.Name = "btnAcessoLivre";
            this.btnAcessoLivre.Size = new System.Drawing.Size(63, 60);
            this.btnAcessoLivre.TabIndex = 15;
            this.btnAcessoLivre.Text = "&Acesso Livre";
            this.btnAcessoLivre.UseVisualStyleBackColor = true;
            this.btnAcessoLivre.Click += new System.EventHandler(this.btnAcessoLivre_Click);
            // 
            // timerShutdownOFF
            // 
            this.timerShutdownOFF.Interval = 1800;
            // 
            // timerThread
            // 
            this.timerThread.Interval = 10000;
            // 
            // frmGerenciador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(795, 497);
            this.Controls.Add(this.btnAcessoLivre);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pctSocket);
            this.Controls.Add(this.microOFF);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gerenciador de Maquinas  - Centro de Estudos São Camilo";
            this.Load += new System.EventHandler(this.button3_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskTempoInsert;
        private System.Windows.Forms.MaskedTextBox mskINICIO;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTempoPendente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Micro2;
        private System.Windows.Forms.ToolStripLabel Micro3;
        private System.Windows.Forms.ToolStripLabel Micro4;
        private System.Windows.Forms.ToolStripLabel Micro5;
        private System.Windows.Forms.ToolStripLabel Micro6;
        private System.Windows.Forms.ToolStripLabel Micro7;
        private System.Windows.Forms.ToolStripLabel Micro8;
        private System.Windows.Forms.ToolStripLabel Micro10;
        private System.Windows.Forms.ToolStripLabel Micro9;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel Micro11;
        private System.Windows.Forms.ToolStripLabel Micro12;
        private System.Windows.Forms.ToolStripLabel Micro13;
        private System.Windows.Forms.ToolStripLabel Micro14;
        private System.Windows.Forms.ToolStripLabel Micro15;
        private System.Windows.Forms.ToolStripLabel Micro16;
        private System.Windows.Forms.ToolStripLabel Micro17;
        private System.Windows.Forms.ToolStripLabel Micro18;
        private System.Windows.Forms.ToolStripLabel Micro19;
        private System.Windows.Forms.ToolStripLabel Micro20;
        private System.Windows.Forms.Button microOFF;
        private System.Windows.Forms.PictureBox pctSocket;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblMicroSelecionado;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnReiniciarMicro;
        private System.Windows.Forms.Button btnTravarMicro;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnAcessoLivre;
        private System.Windows.Forms.ToolStripLabel Micro1;
        private System.Windows.Forms.Timer timerShutdownOFF;
        private System.Windows.Forms.MaskedTextBox mskTempoRestante;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Timer timerHora;
        public System.Windows.Forms.Timer timerThread;
    }
}