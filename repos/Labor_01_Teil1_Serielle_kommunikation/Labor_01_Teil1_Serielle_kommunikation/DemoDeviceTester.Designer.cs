
namespace Labor_01_Teil1_Serielle_kommunikation
{
    partial class DemoDeviceTester
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ConectionStateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeviceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SerialNumberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.comUpDown = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.CounterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gerät = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.comUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ConectionStateLabel, this.DeviceLabel, this.SerialNumberLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 201);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(267, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // ConectionStateLabel
            // 
            this.ConectionStateLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            this.ConectionStateLabel.Name = "ConectionStateLabel";
            this.ConectionStateLabel.Size = new System.Drawing.Size(93, 17);
            this.ConectionStateLabel.Text = "Conection_State";
            this.ConectionStateLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(42, 17);
            this.DeviceLabel.Text = "Device";
            this.DeviceLabel.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(27, 17);
            this.SerialNumberLabel.Text = "S/N";
            this.SerialNumberLabel.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // comUpDown
            // 
            this.comUpDown.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comUpDown.Location = new System.Drawing.Point(54, 53);
            this.comUpDown.Name = "comUpDown";
            this.comUpDown.Size = new System.Drawing.Size(32, 20);
            this.comUpDown.TabIndex = 1;
            this.comUpDown.ValueChanged += new System.EventHandler(this.comUpDown_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.resetButton.Location = new System.Drawing.Point(151, 141);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.connectButton.Location = new System.Drawing.Point(151, 53);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Verbinden";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.plusButton.Location = new System.Drawing.Point(20, 112);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(114, 23);
            this.plusButton.TabIndex = 5;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.minusButton.Location = new System.Drawing.Point(20, 167);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(114, 23);
            this.minusButton.TabIndex = 6;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // CounterTextBox
            // 
            this.CounterTextBox.ForeColor = System.Drawing.Color.Red;
            this.CounterTextBox.Location = new System.Drawing.Point(20, 141);
            this.CounterTextBox.Name = "CounterTextBox";
            this.CounterTextBox.Size = new System.Drawing.Size(114, 20);
            this.CounterTextBox.TabIndex = 7;
            this.CounterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Schnittslelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "COM";
            // 
            // Gerät
            // 
            this.Gerät.AutoSize = true;
            this.Gerät.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.Gerät.Location = new System.Drawing.Point(17, 87);
            this.Gerät.Name = "Gerät";
            this.Gerät.Size = new System.Drawing.Size(33, 13);
            this.Gerät.TabIndex = 10;
            this.Gerät.Text = "Gerät";
            // 
            // DemoDeviceTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 223);
            this.Controls.Add(this.Gerät);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CounterTextBox);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.comUpDown);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "DemoDeviceTester";
            this.Text = "DemoDeviceTester";
            this.Load += new System.EventHandler(this.DemoDeviceTester_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.comUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox CounterTextBox;

        private System.Windows.Forms.ToolStripStatusLabel SerialNumberLabel;

        private System.Windows.Forms.ToolStripStatusLabel DeviceLabel;

        private System.Windows.Forms.ToolStripStatusLabel ConectionStateLabel;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NumericUpDown comUpDown;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Gerät;
    }
}