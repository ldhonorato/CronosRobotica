namespace CronometroWindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxInitTimer = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddOneMinute = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Courier New", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(159, 476);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(690, 215);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerInterruption);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddOneMinute);
            this.panel1.Controls.Add(this.textBoxInitTimer);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Location = new System.Drawing.Point(12, 674);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 43);
            this.panel1.TabIndex = 3;
            // 
            // textBoxInitTimer
            // 
            this.textBoxInitTimer.Location = new System.Drawing.Point(7, 9);
            this.textBoxInitTimer.Name = "textBoxInitTimer";
            this.textBoxInitTimer.Size = new System.Drawing.Size(99, 20);
            this.textBoxInitTimer.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(110, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Iniciar";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modalidade: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Resgate Controlado via Internet",
            "Resgate Controlado Localmente",
            "Segue Faixa"});
            this.comboBox1.Location = new System.Drawing.Point(171, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(822, 37);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Equipe: ";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bandeira e a Nuvem",
            "Brabo Robot Team",
            "Cabedelo\'s_BOT",
            "Cajaíba",
            "Calango",
            "Camaleão",
            "Canguru",
            "Equipe RoBode",
            "Galo de Campina",
            "GPCAR",
            "J.A.R.V.I.S",
            "Mercury Bots",
            "Syndrome de Dhalsin",
            "Tatu",
            "Triplo Pegasus"});
            this.comboBox2.Location = new System.Drawing.Point(171, 448);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(822, 37);
            this.comboBox2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CronometroWindowsForm.Properties.Resources.Robotica_20162;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(977, 340);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddOneMinute
            // 
            this.buttonAddOneMinute.Location = new System.Drawing.Point(231, 9);
            this.buttonAddOneMinute.Name = "buttonAddOneMinute";
            this.buttonAddOneMinute.Size = new System.Drawing.Size(84, 21);
            this.buttonAddOneMinute.TabIndex = 4;
            this.buttonAddOneMinute.Text = "+ 1 Minuto";
            this.buttonAddOneMinute.UseVisualStyleBackColor = true;
            this.buttonAddOneMinute.Click += new System.EventHandler(this.buttonAddOneMinute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cronometro de Prova";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxInitTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonAddOneMinute;
    }
}

