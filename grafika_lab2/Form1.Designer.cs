namespace grafika_lab2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawCircle = new System.Windows.Forms.Button();
            this.DrawSpiral = new System.Windows.Forms.Button();
            this.DrawSpirale = new System.Windows.Forms.Button();
            this.Draw4Sprial = new System.Windows.Forms.Button();
            this.Draw16 = new System.Windows.Forms.Button();
            this.Draw19 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(767, 599);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(787, 12);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(180, 39);
            this.DrawCircle.TabIndex = 1;
            this.DrawCircle.Text = "Koło";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // DrawSpiral
            // 
            this.DrawSpiral.Location = new System.Drawing.Point(787, 57);
            this.DrawSpiral.Name = "DrawSpiral";
            this.DrawSpiral.Size = new System.Drawing.Size(180, 39);
            this.DrawSpiral.TabIndex = 2;
            this.DrawSpiral.Text = "Elipsax2";
            this.DrawSpiral.UseVisualStyleBackColor = true;
            this.DrawSpiral.Click += new System.EventHandler(this.DrawSpiral_Click);
            // 
            // DrawSpirale
            // 
            this.DrawSpirale.Location = new System.Drawing.Point(787, 102);
            this.DrawSpirale.Name = "DrawSpirale";
            this.DrawSpirale.Size = new System.Drawing.Size(180, 39);
            this.DrawSpirale.TabIndex = 3;
            this.DrawSpirale.Text = "Spirala";
            this.DrawSpirale.UseVisualStyleBackColor = true;
            this.DrawSpirale.Click += new System.EventHandler(this.DrawSpirale_Click);
            // 
            // Draw4Sprial
            // 
            this.Draw4Sprial.Location = new System.Drawing.Point(787, 147);
            this.Draw4Sprial.Name = "Draw4Sprial";
            this.Draw4Sprial.Size = new System.Drawing.Size(180, 39);
            this.Draw4Sprial.TabIndex = 4;
            this.Draw4Sprial.Text = "4Spirale";
            this.Draw4Sprial.UseVisualStyleBackColor = true;
            this.Draw4Sprial.Click += new System.EventHandler(this.Draw4Sprial_Click);
            // 
            // Draw16
            // 
            this.Draw16.Location = new System.Drawing.Point(787, 192);
            this.Draw16.Name = "Draw16";
            this.Draw16.Size = new System.Drawing.Size(180, 39);
            this.Draw16.TabIndex = 5;
            this.Draw16.Text = "1.6";
            this.Draw16.UseVisualStyleBackColor = true;
            this.Draw16.Click += new System.EventHandler(this.Draw16_Click);
            // 
            // Draw19
            // 
            this.Draw19.Location = new System.Drawing.Point(787, 237);
            this.Draw19.Name = "Draw19";
            this.Draw19.Size = new System.Drawing.Size(180, 39);
            this.Draw19.TabIndex = 6;
            this.Draw19.Text = "1.9";
            this.Draw19.UseVisualStyleBackColor = true;
            this.Draw19.Click += new System.EventHandler(this.Draw19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(979, 602);
            this.Controls.Add(this.Draw19);
            this.Controls.Add(this.Draw16);
            this.Controls.Add(this.Draw4Sprial);
            this.Controls.Add(this.DrawSpirale);
            this.Controls.Add(this.DrawSpiral);
            this.Controls.Add(this.DrawCircle);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.Button DrawSpiral;
        private System.Windows.Forms.Button DrawSpirale;
        private System.Windows.Forms.Button Draw4Sprial;
        private System.Windows.Forms.Button Draw16;
        private System.Windows.Forms.Button Draw19;
    }
}

