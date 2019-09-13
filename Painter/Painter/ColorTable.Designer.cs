namespace Painter
{
    partial class ColorTable
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
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColorBlack = new System.Windows.Forms.Button();
            this.btnColorRed = new System.Windows.Forms.Button();
            this.btnColorGreen = new System.Windows.Forms.Button();
            this.btnColorBlue = new System.Windows.Forms.Button();
            this.btnColorOrange = new System.Windows.Forms.Button();
            this.btnColorYellow = new System.Windows.Forms.Button();
            this.lblColorPurple = new System.Windows.Forms.Button();
            this.btnColorCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(9, 460);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(137, 23);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color: Black";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColorBlack
            // 
            this.btnColorBlack.BackColor = System.Drawing.Color.Black;
            this.btnColorBlack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorBlack.Location = new System.Drawing.Point(12, 13);
            this.btnColorBlack.Name = "btnColorBlack";
            this.btnColorBlack.Size = new System.Drawing.Size(134, 23);
            this.btnColorBlack.TabIndex = 6;
            this.btnColorBlack.Text = "Black";
            this.btnColorBlack.UseVisualStyleBackColor = false;
            this.btnColorBlack.Click += new System.EventHandler(this.btnColorBlack_Click);
            // 
            // btnColorRed
            // 
            this.btnColorRed.BackColor = System.Drawing.Color.Red;
            this.btnColorRed.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorRed.Location = new System.Drawing.Point(12, 42);
            this.btnColorRed.Name = "btnColorRed";
            this.btnColorRed.Size = new System.Drawing.Size(134, 23);
            this.btnColorRed.TabIndex = 7;
            this.btnColorRed.Text = "Red";
            this.btnColorRed.UseVisualStyleBackColor = false;
            this.btnColorRed.Click += new System.EventHandler(this.btnColorRed_Click);
            // 
            // btnColorGreen
            // 
            this.btnColorGreen.BackColor = System.Drawing.Color.Green;
            this.btnColorGreen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorGreen.Location = new System.Drawing.Point(12, 129);
            this.btnColorGreen.Name = "btnColorGreen";
            this.btnColorGreen.Size = new System.Drawing.Size(134, 23);
            this.btnColorGreen.TabIndex = 8;
            this.btnColorGreen.Text = "Green";
            this.btnColorGreen.UseVisualStyleBackColor = false;
            this.btnColorGreen.Click += new System.EventHandler(this.btnColorGreen_Click);
            // 
            // btnColorBlue
            // 
            this.btnColorBlue.BackColor = System.Drawing.Color.Blue;
            this.btnColorBlue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorBlue.Location = new System.Drawing.Point(12, 158);
            this.btnColorBlue.Name = "btnColorBlue";
            this.btnColorBlue.Size = new System.Drawing.Size(134, 23);
            this.btnColorBlue.TabIndex = 9;
            this.btnColorBlue.Text = "Blue";
            this.btnColorBlue.UseVisualStyleBackColor = false;
            this.btnColorBlue.Click += new System.EventHandler(this.btnColorBlue_Click);
            // 
            // btnColorOrange
            // 
            this.btnColorOrange.BackColor = System.Drawing.Color.Orange;
            this.btnColorOrange.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorOrange.Location = new System.Drawing.Point(12, 71);
            this.btnColorOrange.Name = "btnColorOrange";
            this.btnColorOrange.Size = new System.Drawing.Size(134, 23);
            this.btnColorOrange.TabIndex = 10;
            this.btnColorOrange.Text = "Orange";
            this.btnColorOrange.UseVisualStyleBackColor = false;
            this.btnColorOrange.Click += new System.EventHandler(this.btnColorOrange_Click);
            // 
            // btnColorYellow
            // 
            this.btnColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnColorYellow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnColorYellow.Location = new System.Drawing.Point(12, 100);
            this.btnColorYellow.Name = "btnColorYellow";
            this.btnColorYellow.Size = new System.Drawing.Size(134, 23);
            this.btnColorYellow.TabIndex = 11;
            this.btnColorYellow.Text = "Yellow";
            this.btnColorYellow.UseVisualStyleBackColor = false;
            this.btnColorYellow.Click += new System.EventHandler(this.btnColorYellow_Click);
            // 
            // lblColorPurple
            // 
            this.lblColorPurple.BackColor = System.Drawing.Color.Purple;
            this.lblColorPurple.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblColorPurple.Location = new System.Drawing.Point(12, 187);
            this.lblColorPurple.Name = "lblColorPurple";
            this.lblColorPurple.Size = new System.Drawing.Size(134, 23);
            this.lblColorPurple.TabIndex = 12;
            this.lblColorPurple.Text = "Purple";
            this.lblColorPurple.UseVisualStyleBackColor = false;
            this.lblColorPurple.Click += new System.EventHandler(this.lblColorPurple_Click);
            // 
            // btnColorCustom
            // 
            this.btnColorCustom.BackColor = System.Drawing.Color.Transparent;
            this.btnColorCustom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColorCustom.Location = new System.Drawing.Point(12, 434);
            this.btnColorCustom.Name = "btnColorCustom";
            this.btnColorCustom.Size = new System.Drawing.Size(134, 23);
            this.btnColorCustom.TabIndex = 13;
            this.btnColorCustom.Text = "Custom";
            this.btnColorCustom.UseVisualStyleBackColor = false;
            this.btnColorCustom.Visible = false;
            this.btnColorCustom.Click += new System.EventHandler(this.btnColorCustom_Click);
            // 
            // ColorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(158, 480);
            this.Controls.Add(this.btnColorCustom);
            this.Controls.Add(this.lblColorPurple);
            this.Controls.Add(this.btnColorYellow);
            this.Controls.Add(this.btnColorOrange);
            this.Controls.Add(this.btnColorBlue);
            this.Controls.Add(this.btnColorGreen);
            this.Controls.Add(this.btnColorRed);
            this.Controls.Add(this.btnColorBlack);
            this.Controls.Add(this.lblColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Colors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColorBlack;
        private System.Windows.Forms.Button btnColorRed;
        private System.Windows.Forms.Button btnColorGreen;
        private System.Windows.Forms.Button btnColorBlue;
        private System.Windows.Forms.Button btnColorOrange;
        private System.Windows.Forms.Button btnColorYellow;
        private System.Windows.Forms.Button lblColorPurple;
        private System.Windows.Forms.Button btnColorCustom;
    }
}