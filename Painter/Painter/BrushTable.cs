using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    public partial class BrushTable : Form
    {
        public BrushTable()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 535, Screen.PrimaryScreen.Bounds.Height / 2 - 321);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public int getBrushSize()
        {
            return sizeBar.Value;
        }

        private void sizeBar_Scroll(object sender, EventArgs e)
        {
            lblSize.Text = "Brush Size: " + sizeBar.Value;
        }
    }
}
