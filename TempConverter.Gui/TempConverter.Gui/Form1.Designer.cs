namespace TempConverter.Gui
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
            this.tempFrom = new System.Windows.Forms.ComboBox();
            this.tempTo = new System.Windows.Forms.ComboBox();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempFrom
            // 
            this.tempFrom.FormattingEnabled = true;
            this.tempFrom.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.tempFrom.Location = new System.Drawing.Point(136, 26);
            this.tempFrom.Name = "tempFrom";
            this.tempFrom.Size = new System.Drawing.Size(121, 21);
            this.tempFrom.TabIndex = 0;
            this.tempFrom.Text = "Celsius";
            this.tempFrom.SelectedIndexChanged += new System.EventHandler(this.tempFrom_SelectedIndexChanged);
            // 
            // tempTo
            // 
            this.tempTo.FormattingEnabled = true;
            this.tempTo.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.tempTo.Location = new System.Drawing.Point(136, 90);
            this.tempTo.Name = "tempTo";
            this.tempTo.Size = new System.Drawing.Size(121, 21);
            this.tempTo.TabIndex = 1;
            this.tempTo.Text = "Fahrenheit";
            this.tempTo.SelectedIndexChanged += new System.EventHandler(this.tempTo_SelectedIndexChanged);
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(13, 26);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(74, 20);
            this.textFrom.TabIndex = 2;
            this.textFrom.Text = "0";
            this.textFrom.TextChanged += new System.EventHandler(this.textFrom_TextChanged);
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(13, 91);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(74, 20);
            this.textTo.TabIndex = 3;
            this.textTo.TextChanged += new System.EventHandler(this.textTo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.tempTo);
            this.Controls.Add(this.tempFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Temp Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tempFrom;
        private System.Windows.Forms.ComboBox tempTo;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.Label label1;
    }
}

