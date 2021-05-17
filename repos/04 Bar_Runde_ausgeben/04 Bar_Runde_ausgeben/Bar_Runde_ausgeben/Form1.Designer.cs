
namespace Bar_Runde_ausgeben
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B_anton = new System.Windows.Forms.Button();
            this.B_berta = new System.Windows.Forms.Button();
            this.B_eve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 367);
            this.textBox1.TabIndex = 0;
            // 
            // B_anton
            // 
            this.B_anton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_anton.Location = new System.Drawing.Point(12, 12);
            this.B_anton.Name = "B_anton";
            this.B_anton.Size = new System.Drawing.Size(105, 55);
            this.B_anton.TabIndex = 1;
            this.B_anton.Text = "Anton";
            this.B_anton.UseVisualStyleBackColor = true;
            this.B_anton.Click += new System.EventHandler(this.B_anton_Click);
            // 
            // B_berta
            // 
            this.B_berta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_berta.Location = new System.Drawing.Point(225, 12);
            this.B_berta.Name = "B_berta";
            this.B_berta.Size = new System.Drawing.Size(99, 55);
            this.B_berta.TabIndex = 2;
            this.B_berta.Text = "Berta";
            this.B_berta.UseVisualStyleBackColor = true;
            this.B_berta.Click += new System.EventHandler(this.B_berta_Click);
            // 
            // B_eve
            // 
            this.B_eve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_eve.Location = new System.Drawing.Point(123, 12);
            this.B_eve.Name = "B_eve";
            this.B_eve.Size = new System.Drawing.Size(96, 55);
            this.B_eve.TabIndex = 3;
            this.B_eve.Text = "Eve";
            this.B_eve.UseVisualStyleBackColor = true;
            this.B_eve.Click += new System.EventHandler(this.B_eve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.B_eve);
            this.Controls.Add(this.B_berta);
            this.Controls.Add(this.B_anton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Bar an der HS Esslingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button B_anton;
        private System.Windows.Forms.Button B_berta;
        private System.Windows.Forms.Button B_eve;
    }
}

