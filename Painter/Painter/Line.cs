using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Windows.Forms;

namespace Painter
{
    class Line
    {
        private float x1, y1, x2, y2;

        public Line(float xa, float ya, float xb, float yb)
        {
            x1 = xa;
            y1 = ya;
            x2 = xb;
            y2 = yb;
        }

        public int getLength()
        {
            int ans = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            return ans;
        }

        public double getAngle()
        {
            double ans = 0;
            
            // If the user draws from top left to bottom right
            if (x1 < x2 && y1 < y2)
            {
                ans = -(180 - MathHelper.ToDegrees((float)Math.Atan2(Math.Abs(y2 - y1), Math.Abs(x2 - x1))));
            }

            // If the user draws from bottom right to top left
            if (x1 > x2 && y1 > y2)
            {
                ans = -(360 - (90 - MathHelper.ToDegrees((float)Math.Atan2(Math.Abs(x2 - x1), Math.Abs(y2 - y1)))));
            }

            // If the user draws from bottom left to top right
            if (x1 < x2 && y1 > y2)
            {
                ans = -(180 + (90 - MathHelper.ToDegrees((float)Math.Atan2(Math.Abs(x2 - x1), Math.Abs(y2 - y1)))));
            }

            // If the user draws from top right to bottom left
            if (x1 > x2 && y1 < y2)
            {
                ans = -MathHelper.ToDegrees((float)Math.Atan2(Math.Abs(y2 - y1), Math.Abs(x2 - x1)));
            }

            // If the user draws downward
            if (x1 == x2 && y1 < y2)
            {
                ans = 270;
            }

            // If the user draws upward
            if (x1 == x2 && y1 > y2)
            {
                ans = 90;
            }

            // If the user draws left
            if (x1 > x2 && y1 == y2)
            {
                ans = 0;
            }

            // If the user draws right
            if (x1 < x2 && y1 == y2)
            {
                ans = 180;
            }
            
            return ans;
        }
    }
}
