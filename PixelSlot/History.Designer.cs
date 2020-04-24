namespace PixelSlot
{
    partial class History
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.HLabel);
            this.panel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(157, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 487);
            this.panel1.TabIndex = 0;
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Font = new System.Drawing.Font("Linux Biolinum G", 14F, System.Drawing.FontStyle.Bold);
            this.HLabel.Location = new System.Drawing.Point(3, 0);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(63, 22);
            this.HLabel.TabIndex = 0;
            this.HLabel.Text = "label1";
            this.HLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PixelSlot.Properties.Resources.history;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PixelSlot - History";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HLabel;
    }
}