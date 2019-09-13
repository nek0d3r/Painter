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
    public partial class ToolTable : Form
    {
        Tool tool = Tool.Pencil;

        public ToolTable()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 535, Screen.PrimaryScreen.Bounds.Height / 2 - 254);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            btnPencil.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/pencil.png"));
            btnPencil.BackgroundImageLayout = ImageLayout.Stretch;

            btnEraser.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/eraser.png"));
            btnEraser.BackgroundImageLayout = ImageLayout.Stretch;

            btnLine.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/line.png"));
            btnLine.BackgroundImageLayout = ImageLayout.Stretch;

            btnUndo.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/undo.png"));
            btnUndo.BackgroundImageLayout = ImageLayout.Stretch;

            btnCircle.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/circle.png"));
            btnCircle.BackgroundImageLayout = ImageLayout.Stretch;

            btnBox.BackgroundImage = Image.FromFile(Path.GetFullPath("../../../../PainterContent/Graphics/Tools/box.png"));
            btnBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            tool = Tool.Pencil;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            tool = Tool.Eraser;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            tool = Tool.Line;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            tool = Tool.Undo;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            tool = Tool.Circle;
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            tool = Tool.Box;
        }

        public Tool getTool()
        {
            return tool;
        }
    }
}
