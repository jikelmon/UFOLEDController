namespace LEDController
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOn1 = new System.Windows.Forms.Button();
            this.cmdOn2 = new System.Windows.Forms.Button();
            this.cmdOff1 = new System.Windows.Forms.Button();
            this.cmdOff2 = new System.Windows.Forms.Button();
            this.cmdOnAll = new System.Windows.Forms.Button();
            this.cmdOffAll = new System.Windows.Forms.Button();
            this.cmdRed = new System.Windows.Forms.Button();
            this.cmdGreen = new System.Windows.Forms.Button();
            this.cmdBlue = new System.Windows.Forms.Button();
            this.cmdTogglePWR1 = new System.Windows.Forms.Button();
            this.cmdTogglePWR2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdOn1
            // 
            this.cmdOn1.Location = new System.Drawing.Point(12, 12);
            this.cmdOn1.Name = "cmdOn1";
            this.cmdOn1.Size = new System.Drawing.Size(75, 23);
            this.cmdOn1.TabIndex = 0;
            this.cmdOn1.Text = "Bett On";
            this.cmdOn1.UseVisualStyleBackColor = true;
            this.cmdOn1.Click += new System.EventHandler(this.cmdOn1_Click);
            // 
            // cmdOn2
            // 
            this.cmdOn2.Location = new System.Drawing.Point(103, 12);
            this.cmdOn2.Name = "cmdOn2";
            this.cmdOn2.Size = new System.Drawing.Size(75, 23);
            this.cmdOn2.TabIndex = 1;
            this.cmdOn2.Text = "Regal On";
            this.cmdOn2.UseVisualStyleBackColor = true;
            this.cmdOn2.Click += new System.EventHandler(this.cmdOn2_Click);
            // 
            // cmdOff1
            // 
            this.cmdOff1.Location = new System.Drawing.Point(12, 41);
            this.cmdOff1.Name = "cmdOff1";
            this.cmdOff1.Size = new System.Drawing.Size(75, 23);
            this.cmdOff1.TabIndex = 2;
            this.cmdOff1.Text = "Bett Off";
            this.cmdOff1.UseVisualStyleBackColor = true;
            this.cmdOff1.Click += new System.EventHandler(this.cmdOff1_Click);
            // 
            // cmdOff2
            // 
            this.cmdOff2.Location = new System.Drawing.Point(103, 41);
            this.cmdOff2.Name = "cmdOff2";
            this.cmdOff2.Size = new System.Drawing.Size(75, 23);
            this.cmdOff2.TabIndex = 3;
            this.cmdOff2.Text = "Regal Off";
            this.cmdOff2.UseVisualStyleBackColor = true;
            this.cmdOff2.Click += new System.EventHandler(this.cmdOff2_Click);
            // 
            // cmdOnAll
            // 
            this.cmdOnAll.Location = new System.Drawing.Point(12, 106);
            this.cmdOnAll.Name = "cmdOnAll";
            this.cmdOnAll.Size = new System.Drawing.Size(75, 23);
            this.cmdOnAll.TabIndex = 4;
            this.cmdOnAll.Text = "On";
            this.cmdOnAll.UseVisualStyleBackColor = true;
            this.cmdOnAll.Click += new System.EventHandler(this.cmdOnAll_Click);
            // 
            // cmdOffAll
            // 
            this.cmdOffAll.Location = new System.Drawing.Point(103, 106);
            this.cmdOffAll.Name = "cmdOffAll";
            this.cmdOffAll.Size = new System.Drawing.Size(75, 23);
            this.cmdOffAll.TabIndex = 5;
            this.cmdOffAll.Text = "Off";
            this.cmdOffAll.UseVisualStyleBackColor = true;
            this.cmdOffAll.Click += new System.EventHandler(this.cmdOffAll_Click);
            // 
            // cmdRed
            // 
            this.cmdRed.Location = new System.Drawing.Point(12, 135);
            this.cmdRed.Name = "cmdRed";
            this.cmdRed.Size = new System.Drawing.Size(75, 23);
            this.cmdRed.TabIndex = 6;
            this.cmdRed.Text = "Rot";
            this.cmdRed.UseVisualStyleBackColor = true;
            this.cmdRed.Click += new System.EventHandler(this.cmdRGB_Click);
            // 
            // cmdGreen
            // 
            this.cmdGreen.Location = new System.Drawing.Point(93, 135);
            this.cmdGreen.Name = "cmdGreen";
            this.cmdGreen.Size = new System.Drawing.Size(75, 23);
            this.cmdGreen.TabIndex = 7;
            this.cmdGreen.Text = "Grün";
            this.cmdGreen.UseVisualStyleBackColor = true;
            this.cmdGreen.Click += new System.EventHandler(this.cmdGreen_Click);
            // 
            // cmdBlue
            // 
            this.cmdBlue.Location = new System.Drawing.Point(174, 135);
            this.cmdBlue.Name = "cmdBlue";
            this.cmdBlue.Size = new System.Drawing.Size(75, 23);
            this.cmdBlue.TabIndex = 8;
            this.cmdBlue.Text = "Blau";
            this.cmdBlue.UseVisualStyleBackColor = true;
            this.cmdBlue.Click += new System.EventHandler(this.cmdBlue_Click);
            // 
            // cmdTogglePWR1
            // 
            this.cmdTogglePWR1.Location = new System.Drawing.Point(12, 70);
            this.cmdTogglePWR1.Name = "cmdTogglePWR1";
            this.cmdTogglePWR1.Size = new System.Drawing.Size(94, 23);
            this.cmdTogglePWR1.TabIndex = 9;
            this.cmdTogglePWR1.Text = "Toggle PWR 1";
            this.cmdTogglePWR1.UseVisualStyleBackColor = true;
            this.cmdTogglePWR1.Click += new System.EventHandler(this.cmdTogglePWR1_Click);
            // 
            // cmdTogglePWR2
            // 
            this.cmdTogglePWR2.Location = new System.Drawing.Point(112, 70);
            this.cmdTogglePWR2.Name = "cmdTogglePWR2";
            this.cmdTogglePWR2.Size = new System.Drawing.Size(87, 23);
            this.cmdTogglePWR2.TabIndex = 10;
            this.cmdTogglePWR2.Text = "Toggle PWR 2";
            this.cmdTogglePWR2.UseVisualStyleBackColor = true;
            this.cmdTogglePWR2.Click += new System.EventHandler(this.cmdTogglePWR2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdTogglePWR2);
            this.Controls.Add(this.cmdTogglePWR1);
            this.Controls.Add(this.cmdBlue);
            this.Controls.Add(this.cmdGreen);
            this.Controls.Add(this.cmdRed);
            this.Controls.Add(this.cmdOffAll);
            this.Controls.Add(this.cmdOnAll);
            this.Controls.Add(this.cmdOff2);
            this.Controls.Add(this.cmdOff1);
            this.Controls.Add(this.cmdOn2);
            this.Controls.Add(this.cmdOn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOn1;
        private System.Windows.Forms.Button cmdOn2;
        private System.Windows.Forms.Button cmdOff1;
        private System.Windows.Forms.Button cmdOff2;
        private System.Windows.Forms.Button cmdOnAll;
        private System.Windows.Forms.Button cmdOffAll;
        private System.Windows.Forms.Button cmdRed;
        private System.Windows.Forms.Button cmdGreen;
        private System.Windows.Forms.Button cmdBlue;
        private System.Windows.Forms.Button cmdTogglePWR1;
        private System.Windows.Forms.Button cmdTogglePWR2;
    }
}

