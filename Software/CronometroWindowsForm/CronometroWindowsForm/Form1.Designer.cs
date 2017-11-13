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
            this.comboBoxCOMList = new System.Windows.Forms.ComboBox();
            this.buttonOpenCOM = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCOMList
            // 
            this.comboBoxCOMList.FormattingEnabled = true;
            this.comboBoxCOMList.Location = new System.Drawing.Point(18, 19);
            this.comboBoxCOMList.Name = "comboBoxCOMList";
            this.comboBoxCOMList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMList.TabIndex = 0;
            // 
            // buttonOpenCOM
            // 
            this.buttonOpenCOM.Location = new System.Drawing.Point(159, 19);
            this.buttonOpenCOM.Name = "buttonOpenCOM";
            this.buttonOpenCOM.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenCOM.TabIndex = 1;
            this.buttonOpenCOM.Text = "Abrir Porta";
            this.buttonOpenCOM.UseVisualStyleBackColor = true;
            this.buttonOpenCOM.Click += new System.EventHandler(this.COMPortButton);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Courier New", 219.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(36, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(1195, 332);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "00:000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerInterruption);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.comboBoxCOMList);
            this.panel1.Controls.Add(this.buttonOpenCOM);
            this.panel1.Location = new System.Drawing.Point(12, 907);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 66);
            this.panel1.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(240, 19);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(102, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Zerar Tempo";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CronometroWindowsForm.Properties.Resources.logo_IF;
            this.pictureBox2.Location = new System.Drawing.Point(478, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 109);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CronometroWindowsForm.Properties.Resources.Robotica_2016;
            this.pictureBox1.Location = new System.Drawing.Point(145, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 343);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOMList;
        private System.Windows.Forms.Button buttonOpenCOM;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

