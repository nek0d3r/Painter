using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Painter
{
    class BrushSize
    {
        private int brushSize;

        public BrushSize()
        {
            brushSize = 16;
        }

        public void setSize(int i)
        {
            brushSize = i;
        }

        public int getSize()
        {
            return brushSize;
        }
    }
}
