namespace Painter
{
    partial class SaveTable
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
            this.btnScrnShot = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScrnShot
            // 
            this.btnScrnShot.Location = new System.Drawing.Point(13, 13);
            this.btnScrnShot.Name = "btnScrnShot";
            this.btnScrnShot.Size = new System.Drawing.Size(32, 32);
            this.btnScrnShot.TabIndex = 0;
            this.btnScrnShot.UseVisualStyleBackColor = true;
            this.btnScrnShot.Click += new System.EventHandler(this.btnScrnShot_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1046, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SaveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1090, 57);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnScrnShot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScrnShot;
        private System.Windows.Forms.Button btnClose;
    }
}