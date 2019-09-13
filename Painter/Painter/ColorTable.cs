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
    public partial class ColorTable : Form
    {
        private int color = 1;

        public ColorTable()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + 397, Screen.PrimaryScreen.Bounds.Height / 2 - 254);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public int getColor()
        {
            return color;
        }

        private void btnColorBlack_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Black";
            color = 1;
        }

        private void btnColorRed_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Red";
            color = 2;
        }

        private void btnColorOrange_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Orange";
            color = 3;
        }

        private void btnColorYellow_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Yellow";
            color = 4;
        }

        private void btnColorGreen_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Green";
            color = 5;
        }

        private void btnColorBlue_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Blue";
            color = 6;
        }

        private void lblColorPurple_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Purple";
            color = 7;
        }

        private void btnColorCustom_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Color: Custom";
            color = 0;
        }
    }
}
