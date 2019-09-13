namespace Painter
{
    partial class BrushTable
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
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.lblSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(13, 13);
            this.sizeBar.Maximum = 100;
            this.sizeBar.Minimum = 2;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(1065, 45);
            this.sizeBar.TabIndex = 0;
            this.sizeBar.TickFrequency = 2;
            this.sizeBar.Value = 16;
            this.sizeBar.Scroll += new System.EventHandler(this.sizeBar_Scroll);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(18, 46);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(75, 13);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Brush Size: 16";
            // 
            // BrushTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1090, 67);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.sizeBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrushTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Brush Size: 16";
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.Label lblSize;
    }
}