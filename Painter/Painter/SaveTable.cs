using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Painter
{
    public partial class SaveTable : Form
    {
        private Bitmap screen;
        private Rectangle bounds;

        public SaveTable()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 535, Screen.PrimaryScreen.Bounds.Height / 2 + 226);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            btnScrnShot.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/screenshot.png"));
            btnScrnShot.BackgroundImageLayout = ImageLayout.Stretch;

            btnClose.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/close.png"));
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setWindowBounds(Rectangle windowBounds)
        {
            bounds = windowBounds;
        }

        private void btnScrnShot_Click(object sender, EventArgs e)
        {
            screen = new Bitmap(bounds.Width, bounds.Height);
            Graphics.FromImage(screen).CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, screen.Size);
            screen.Save("output.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
