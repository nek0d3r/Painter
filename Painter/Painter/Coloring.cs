using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Painter
{
    class Coloring
    {
        private int colorCode;
        private Color color;

        public Coloring()
        {
        }

        public void setColor(int i)
        {
            colorCode = i;

            color = getColorByCode(i);
        }

        public Color getColor()
        {
            return color;
        }

        private Color getColorByCode(int i)
        {
            Color j;

            switch (i)
            {
                case 1:
                    j = Color.Black;
                    break;
                case 2:
                    j = Color.Red;
                    break;
                case 3:
                    j = Color.Orange;
                    break;
                case 4:
                    j = Color.Yellow;
                    break;
                case 5:
                    j = Color.Green;
                    break;
                case 6:
                    j = Color.Blue;
                    break;
                case 7:
                    j = Color.Purple;
                    break;
                default:
                    j = Color.White;
                    break;
            }

            return j;
        }
    }
}
