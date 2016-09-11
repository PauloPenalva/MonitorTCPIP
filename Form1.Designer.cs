namespace MonitorSerialTCP
{
    partial class Form1
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
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectaSerial = new System.Windows.Forms.Button();
            this.btnDesconectaSerial = new System.Windows.Forms.Button();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciarMonitor = new System.Windows.Forms.Button();
            this.btnPararMonitor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTCP = new System.Windows.Forms.RadioButton();
            this.radArquivo = new System.Windows.Forms.RadioButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSerial
            // 
            this.cmbSerial.FormattingEnabled = true;
            this.cmbSerial.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.cmbSerial.Location = new System.Drawing.Point(12, 174);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(104, 21);
            this.cmbSerial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial : ";
            // 
            // btnConectaSerial
            // 
            this.btnConectaSerial.Location = new System.Drawing.Point(129, 165);
            this.btnConectaSerial.Name = "btnConectaSerial";
            this.btnConectaSerial.Size = new System.Drawing.Size(134, 30);
            this.btnConectaSerial.TabIndex = 4;
            this.btnConectaSerial.Text = "Conectar a Balanca";
            this.btnConectaSerial.UseVisualStyleBackColor = true;
            this.btnConectaSerial.Click += new System.EventHandler(this.btnConectaSerial_Click);
            // 
            // btnDesconectaSerial
            // 
            this.btnDesconectaSerial.Enabled = false;
            this.btnDesconectaSerial.Location = new System.Drawing.Point(315, 165);
            this.btnDesconectaSerial.Name = "btnDesconectaSerial";
            this.btnDesconectaSerial.Size = new System.Drawing.Size(134, 30);
            this.btnDesconectaSerial.TabIndex = 5;
            this.btnDesconectaSerial.Text = "Desconectar da Balanca";
            this.btnDesconectaSerial.UseVisualStyleBackColor = true;
            this.btnDesconectaSerial.Click += new System.EventHandler(this.btnDesconectaSerial_Click);
            // 
            // lnkLabel
            // 
            this.lnkLabel.AutoSize = true;
            this.lnkLabel.Location = new System.Drawing.Point(133, 266);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(206, 13);
            this.lnkLabel.TabIndex = 1;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "IDX Consultoria e Sistemas Ltda - (c) 2016";
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 13);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnIniciarMonitor
            // 
            this.btnIniciarMonitor.Enabled = false;
            this.btnIniciarMonitor.Location = new System.Drawing.Point(129, 216);
            this.btnIniciarMonitor.Name = "btnIniciarMonitor";
            this.btnIniciarMonitor.Size = new System.Drawing.Size(134, 30);
            this.btnIniciarMonitor.TabIndex = 7;
            this.btnIniciarMonitor.Text = "Iniciar Monitor";
            this.btnIniciarMonitor.UseVisualStyleBackColor = true;
            this.btnIniciarMonitor.Click += new System.EventHandler(this.btnIniciarMonitor_Click);
            // 
            // btnPararMonitor
            // 
            this.btnPararMonitor.Enabled = false;
            this.btnPararMonitor.Location = new System.Drawing.Point(315, 216);
            this.btnPararMonitor.Name = "btnPararMonitor";
            this.btnPararMonitor.Size = new System.Drawing.Size(134, 30);
            this.btnPararMonitor.TabIndex = 8;
            this.btnPararMonitor.Text = "Parar Monitor";
            this.btnPararMonitor.UseVisualStyleBackColor = true;
            this.btnPararMonitor.Click += new System.EventHandler(this.btnPararMonitor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(346, 266);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 13);
            this.lblTempo.TabIndex = 9;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Black;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.Red;
            this.txtPeso.Location = new System.Drawing.Point(16, 12);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(433, 109);
            this.txtPeso.TabIndex = 10;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTCP);
            this.groupBox2.Controls.Add(this.radArquivo);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface";
            // 
            // radTCP
            // 
            this.radTCP.AutoSize = true;
            this.radTCP.Enabled = false;
            this.radTCP.Location = new System.Drawing.Point(6, 44);
            this.radTCP.Name = "radTCP";
            this.radTCP.Size = new System.Drawing.Size(61, 17);
            this.radTCP.TabIndex = 13;
            this.radTCP.Text = "TCP/IP";
            this.radTCP.UseVisualStyleBackColor = true;
            // 
            // radArquivo
            // 
            this.radArquivo.AutoSize = true;
            this.radArquivo.Checked = true;
            this.radArquivo.Location = new System.Drawing.Point(6, 21);
            this.radArquivo.Name = "radArquivo";
            this.radArquivo.Size = new System.Drawing.Size(85, 17);
            this.radArquivo.TabIndex = 12;
            this.radArquivo.TabStop = true;
            this.radArquivo.Text = "Arquivo TXT";
            this.radArquivo.UseVisualStyleBackColor = true;
            this.radArquivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(352, 266);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(28, 13);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 285);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnPararMonitor);
            this.Controls.Add(this.btnIniciarMonitor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDesconectaSerial);
            this.Controls.Add(this.btnConectaSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSerial);
            this.Controls.Add(this.lnkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Serial TCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectaSerial;
        private System.Windows.Forms.Button btnDesconectaSerial;
        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIniciarMonitor;
        private System.Windows.Forms.Button btnPararMonitor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTCP;
        private System.Windows.Forms.RadioButton radArquivo;
        private System.Windows.Forms.Label lblHora;
    }
}

