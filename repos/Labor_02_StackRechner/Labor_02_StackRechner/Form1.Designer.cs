using System.Threading;

namespace Labor_02_StackRechner
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStack1 = new System.Windows.Forms.TextBox();
            this.textBoxStack2 = new System.Windows.Forms.TextBox();
            this.textBoxStack3 = new System.Windows.Forms.TextBox();
            this.textBoxStack4 = new System.Windows.Forms.TextBox();
            this.eingabeZahl = new System.Windows.Forms.TextBox();
            this.buttonTeilen = new System.Windows.Forms.Button();
            this.buttonMultiplizieren = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.radioDual = new System.Windows.Forms.RadioButton();
            this.radioDezimal = new System.Windows.Forms.RadioButton();
            this.radioHex = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.textBoxStack1);
            this.GroupBox1.Controls.Add(this.textBoxStack2);
            this.GroupBox1.Controls.Add(this.textBoxStack3);
            this.GroupBox1.Controls.Add(this.textBoxStack4);
            this.GroupBox1.Location = new System.Drawing.Point(11, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(198, 130);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Stack";
            // 
            // textBoxStack1
            // 
            this.textBoxStack1.CausesValidation = false;
            this.textBoxStack1.Location = new System.Drawing.Point(6, 97);
            this.textBoxStack1.Name = "textBoxStack1";
            this.textBoxStack1.ReadOnly = true;
            this.textBoxStack1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStack1.Size = new System.Drawing.Size(175, 20);
            this.textBoxStack1.TabIndex = 3;
            this.textBoxStack1.TextChanged += new System.EventHandler(this.textBoxStack1_TextChanged);
            // 
            // textBoxStack2
            // 
            this.textBoxStack2.CausesValidation = false;
            this.textBoxStack2.Location = new System.Drawing.Point(6, 71);
            this.textBoxStack2.Name = "textBoxStack2";
            this.textBoxStack2.ReadOnly = true;
            this.textBoxStack2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStack2.Size = new System.Drawing.Size(176, 20);
            this.textBoxStack2.TabIndex = 2;
            this.textBoxStack2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxStack3
            // 
            this.textBoxStack3.CausesValidation = false;
            this.textBoxStack3.Location = new System.Drawing.Point(6, 45);
            this.textBoxStack3.Name = "textBoxStack3";
            this.textBoxStack3.ReadOnly = true;
            this.textBoxStack3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStack3.Size = new System.Drawing.Size(176, 20);
            this.textBoxStack3.TabIndex = 1;
            this.textBoxStack3.TextChanged += new System.EventHandler(this.textBoxStack3_TextChanged);
            // 
            // textBoxStack4
            // 
            this.textBoxStack4.CausesValidation = false;
            this.textBoxStack4.Location = new System.Drawing.Point(6, 19);
            this.textBoxStack4.Name = "textBoxStack4";
            this.textBoxStack4.ReadOnly = true;
            this.textBoxStack4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStack4.Size = new System.Drawing.Size(176, 20);
            this.textBoxStack4.TabIndex = 0;
            this.textBoxStack4.TextChanged += new System.EventHandler(this.textBoxStack4_TextChanged);
            // 
            // eingabeZahl
            // 
            this.eingabeZahl.Location = new System.Drawing.Point(17, 198);
            this.eingabeZahl.Name = "eingabeZahl";
            this.eingabeZahl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eingabeZahl.Size = new System.Drawing.Size(175, 20);
            this.eingabeZahl.TabIndex = 1;
            this.eingabeZahl.TextChanged += new System.EventHandler(this.eingabeZahl_TextChanged);
            // 
            // buttonTeilen
            // 
            this.buttonTeilen.Location = new System.Drawing.Point(230, 40);
            this.buttonTeilen.Name = "buttonTeilen";
            this.buttonTeilen.Size = new System.Drawing.Size(238, 25);
            this.buttonTeilen.TabIndex = 2;
            this.buttonTeilen.Text = "/";
            this.buttonTeilen.UseVisualStyleBackColor = true;
            this.buttonTeilen.Click += new System.EventHandler(this.buttonTeilen_Click);
            // 
            // buttonMultiplizieren
            // 
            this.buttonMultiplizieren.Location = new System.Drawing.Point(231, 71);
            this.buttonMultiplizieren.Name = "buttonMultiplizieren";
            this.buttonMultiplizieren.Size = new System.Drawing.Size(238, 25);
            this.buttonMultiplizieren.TabIndex = 3;
            this.buttonMultiplizieren.Text = "*";
            this.buttonMultiplizieren.UseVisualStyleBackColor = true;
            this.buttonMultiplizieren.Click += new System.EventHandler(this.buttonMultiplizieren_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(230, 102);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(238, 25);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(230, 133);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(238, 23);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(230, 162);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(76, 25);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(312, 162);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(76, 25);
            this.buttonSwap.TabIndex = 7;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(394, 162);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(74, 25);
            this.buttonDrop.TabIndex = 8;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(231, 193);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(237, 25);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // radioDual
            // 
            this.radioDual.Location = new System.Drawing.Point(11, 18);
            this.radioDual.Name = "radioDual";
            this.radioDual.Size = new System.Drawing.Size(48, 24);
            this.radioDual.TabIndex = 10;
            this.radioDual.TabStop = true;
            this.radioDual.Text = "Dual";
            this.radioDual.UseVisualStyleBackColor = true;
            // 
            // radioDezimal
            // 
            this.radioDezimal.Checked = true;
            this.radioDezimal.Location = new System.Drawing.Point(65, 18);
            this.radioDezimal.Name = "radioDezimal";
            this.radioDezimal.Size = new System.Drawing.Size(64, 24);
            this.radioDezimal.TabIndex = 11;
            this.radioDezimal.TabStop = true;
            this.radioDezimal.Text = "Dezimal";
            this.radioDezimal.UseVisualStyleBackColor = true;
            // 
            // radioHex
            // 
            this.radioHex.Location = new System.Drawing.Point(135, 18);
            this.radioHex.Name = "radioHex";
            this.radioHex.Size = new System.Drawing.Size(57, 24);
            this.radioHex.TabIndex = 12;
            this.radioHex.TabStop = true;
            this.radioHex.Text = "Hex";
            this.radioHex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 238);
            this.Controls.Add(this.radioHex);
            this.Controls.Add(this.radioDezimal);
            this.Controls.Add(this.radioDual);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiplizieren);
            this.Controls.Add(this.buttonTeilen);
            this.Controls.Add(this.eingabeZahl);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxStack1;

        private System.Windows.Forms.TextBox textBoxStack2;

        private System.Windows.Forms.TextBox textBoxStack3;

        private System.Windows.Forms.TextBox textBoxStack4;

        private System.Windows.Forms.Button buttonEnter;

        private System.Windows.Forms.Button buttonDrop;

        private System.Windows.Forms.Button buttonSwap;

        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Button buttonPlus;

        private System.Windows.Forms.Button buttonMinus;

        private System.Windows.Forms.Button buttonMultiplizieren;

        private System.Windows.Forms.Button buttonTeilen;

        private System.Windows.Forms.Button drop;
        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.RadioButton radioDual;
        private System.Windows.Forms.RadioButton radioDezimal;
        private System.Windows.Forms.RadioButton radioHex;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox GroupBox1;

        private System.Windows.Forms.Button plus;

        private System.Windows.Forms.Button minus;

        private System.Windows.Forms.Button teilen;
        private System.Windows.Forms.Button multiplizieren;

        private System.Windows.Forms.TextBox eingabeZahl;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.GroupBox Stack;

        #endregion
    }
}