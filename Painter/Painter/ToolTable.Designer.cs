namespace Painter
{
    partial class ToolTable
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
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(21, 13);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(32, 32);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(59, 13);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(32, 32);
            this.btnEraser.TabIndex = 1;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(21, 51);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(32, 32);
            this.btnLine.TabIndex = 2;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(59, 51);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(32, 32);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(21, 89);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(32, 32);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnBox
            // 
            this.btnBox.Location = new System.Drawing.Point(59, 89);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(32, 32);
            this.btnBox.TabIndex = 5;
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // ToolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(116, 480);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnPencil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnBox;
    }
}