namespace Wuerfelspiel
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
            this.uc_Wuerfel5 = new Wuerfelspiel.Uc_Wuerfel();
            this.uc_Wuerfel4 = new Wuerfelspiel.Uc_Wuerfel();
            this.uc_Wuerfel3 = new Wuerfelspiel.Uc_Wuerfel();
            this.uc_Wuerfel2 = new Wuerfelspiel.Uc_Wuerfel();
            this.uc_Wuerfel1 = new Wuerfelspiel.Uc_Wuerfel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uc_Wuerfel5
            // 
            this.uc_Wuerfel5.Location = new System.Drawing.Point(854, 14);
            this.uc_Wuerfel5.Margin = new System.Windows.Forms.Padding(5);
            this.uc_Wuerfel5.Name = "uc_Wuerfel5";
            this.uc_Wuerfel5.Size = new System.Drawing.Size(200, 204);
            this.uc_Wuerfel5.TabIndex = 4;
            // 
            // uc_Wuerfel4
            // 
            this.uc_Wuerfel4.Location = new System.Drawing.Point(644, 14);
            this.uc_Wuerfel4.Margin = new System.Windows.Forms.Padding(5);
            this.uc_Wuerfel4.Name = "uc_Wuerfel4";
            this.uc_Wuerfel4.Size = new System.Drawing.Size(200, 204);
            this.uc_Wuerfel4.TabIndex = 3;
            // 
            // uc_Wuerfel3
            // 
            this.uc_Wuerfel3.Location = new System.Drawing.Point(434, 14);
            this.uc_Wuerfel3.Margin = new System.Windows.Forms.Padding(5);
            this.uc_Wuerfel3.Name = "uc_Wuerfel3";
            this.uc_Wuerfel3.Size = new System.Drawing.Size(200, 204);
            this.uc_Wuerfel3.TabIndex = 2;
            // 
            // uc_Wuerfel2
            // 
            this.uc_Wuerfel2.Location = new System.Drawing.Point(224, 15);
            this.uc_Wuerfel2.Margin = new System.Windows.Forms.Padding(5);
            this.uc_Wuerfel2.Name = "uc_Wuerfel2";
            this.uc_Wuerfel2.Size = new System.Drawing.Size(200, 204);
            this.uc_Wuerfel2.TabIndex = 1;
            // 
            // uc_Wuerfel1
            // 
            this.uc_Wuerfel1.Location = new System.Drawing.Point(16, 15);
            this.uc_Wuerfel1.Margin = new System.Windows.Forms.Padding(5);
            this.uc_Wuerfel1.Name = "uc_Wuerfel1";
            this.uc_Wuerfel1.Size = new System.Drawing.Size(200, 204);
            this.uc_Wuerfel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(453, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 141);
            this.button1.TabIndex = 5;
            this.button1.Text = "LETS GO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(684, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Was hab ich?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uc_Wuerfel5);
            this.Controls.Add(this.uc_Wuerfel4);
            this.Controls.Add(this.uc_Wuerfel3);
            this.Controls.Add(this.uc_Wuerfel2);
            this.Controls.Add(this.uc_Wuerfel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_Wuerfel uc_Wuerfel1;
        private Uc_Wuerfel uc_Wuerfel2;
        private Uc_Wuerfel uc_Wuerfel3;
        private Uc_Wuerfel uc_Wuerfel4;
        private Uc_Wuerfel uc_Wuerfel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

