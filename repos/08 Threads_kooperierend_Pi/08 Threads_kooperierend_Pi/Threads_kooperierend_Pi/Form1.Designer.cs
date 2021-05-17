namespace Threads_kooperierend_Pi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_1Thread = new System.Windows.Forms.Button();
            this.b_4Threads = new System.Windows.Forms.Button();
            this.b_8Threads = new System.Windows.Forms.Button();
            this.l_erg1 = new System.Windows.Forms.Label();
            this.l_erg4 = new System.Windows.Forms.Label();
            this.l_erg8 = new System.Windows.Forms.Label();
            this.l_zeit1 = new System.Windows.Forms.Label();
            this.l_zeit4 = new System.Windows.Forms.Label();
            this.l_zeit8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel1.Controls.Add(this.b_1Thread, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_8Threads, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_4Threads, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_erg1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.l_erg4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.l_erg8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.l_zeit1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l_zeit4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.l_zeit8, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 258);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // b_1Thread
            // 
            this.b_1Thread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_1Thread.Location = new System.Drawing.Point(3, 3);
            this.b_1Thread.Name = "b_1Thread";
            this.b_1Thread.Padding = new System.Windows.Forms.Padding(3);
            this.b_1Thread.Size = new System.Drawing.Size(282, 72);
            this.b_1Thread.TabIndex = 0;
            this.b_1Thread.Text = "ein Thread";
            this.b_1Thread.UseVisualStyleBackColor = true;
            this.b_1Thread.Click += new System.EventHandler(this.b_1Thread_Click);
            // 
            // b_4Threads
            // 
            this.b_4Threads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_4Threads.Location = new System.Drawing.Point(293, 3);
            this.b_4Threads.Name = "b_4Threads";
            this.b_4Threads.Padding = new System.Windows.Forms.Padding(3);
            this.b_4Threads.Size = new System.Drawing.Size(272, 72);
            this.b_4Threads.TabIndex = 1;
            this.b_4Threads.Text = "4 Threads";
            this.b_4Threads.UseVisualStyleBackColor = true;
            this.b_4Threads.Click += new System.EventHandler(this.b_4Threads_Click);
            // 
            // b_8Threads
            // 
            this.b_8Threads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_8Threads.Location = new System.Drawing.Point(583, 3);
            this.b_8Threads.Name = "b_8Threads";
            this.b_8Threads.Padding = new System.Windows.Forms.Padding(3);
            this.b_8Threads.Size = new System.Drawing.Size(294, 72);
            this.b_8Threads.TabIndex = 2;
            this.b_8Threads.Text = "8 Threads";
            this.b_8Threads.UseVisualStyleBackColor = true;
            this.b_8Threads.Click += new System.EventHandler(this.b_8Threads_Click);
            // 
            // l_erg1
            // 
            this.l_erg1.AutoSize = true;
            this.l_erg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_erg1.Location = new System.Drawing.Point(3, 104);
            this.l_erg1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.l_erg1.Name = "l_erg1";
            this.l_erg1.Size = new System.Drawing.Size(106, 24);
            this.l_erg1.TabIndex = 3;
            this.l_erg1.Text = "Ergebnis: ";
            // 
            // l_erg4
            // 
            this.l_erg4.AutoSize = true;
            this.l_erg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_erg4.Location = new System.Drawing.Point(293, 104);
            this.l_erg4.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.l_erg4.Name = "l_erg4";
            this.l_erg4.Size = new System.Drawing.Size(106, 24);
            this.l_erg4.TabIndex = 4;
            this.l_erg4.Text = "Ergebnis: ";
            // 
            // l_erg8
            // 
            this.l_erg8.AutoSize = true;
            this.l_erg8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_erg8.Location = new System.Drawing.Point(583, 104);
            this.l_erg8.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.l_erg8.Name = "l_erg8";
            this.l_erg8.Size = new System.Drawing.Size(106, 24);
            this.l_erg8.TabIndex = 5;
            this.l_erg8.Text = "Ergebnis: ";
            // 
            // l_zeit1
            // 
            this.l_zeit1.AutoSize = true;
            this.l_zeit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_zeit1.Location = new System.Drawing.Point(3, 188);
            this.l_zeit1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.l_zeit1.Name = "l_zeit1";
            this.l_zeit1.Size = new System.Drawing.Size(57, 24);
            this.l_zeit1.TabIndex = 6;
            this.l_zeit1.Text = "Zeit: ";
            this.l_zeit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_zeit4
            // 
            this.l_zeit4.AutoSize = true;
            this.l_zeit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_zeit4.Location = new System.Drawing.Point(293, 188);
            this.l_zeit4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.l_zeit4.Name = "l_zeit4";
            this.l_zeit4.Size = new System.Drawing.Size(57, 24);
            this.l_zeit4.TabIndex = 7;
            this.l_zeit4.Text = "Zeit: ";
            // 
            // l_zeit8
            // 
            this.l_zeit8.AutoSize = true;
            this.l_zeit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_zeit8.Location = new System.Drawing.Point(583, 188);
            this.l_zeit8.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.l_zeit8.Name = "l_zeit8";
            this.l_zeit8.Size = new System.Drawing.Size(57, 24);
            this.l_zeit8.TabIndex = 8;
            this.l_zeit8.Text = "Zeit: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Pi berechnen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b_1Thread;
        private System.Windows.Forms.Button b_4Threads;
        private System.Windows.Forms.Button b_8Threads;
        private System.Windows.Forms.Label l_erg1;
        private System.Windows.Forms.Label l_erg4;
        private System.Windows.Forms.Label l_erg8;
        private System.Windows.Forms.Label l_zeit1;
        private System.Windows.Forms.Label l_zeit4;
        private System.Windows.Forms.Label l_zeit8;
    }
}

