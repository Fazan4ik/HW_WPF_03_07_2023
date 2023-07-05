using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_03_07_2023
{
    public class ColorMVVM
    {
        private int alpha;
        private int red;
        private int green;
        private int blue;

        public ColorMVVM(int alpha = 0, int red = 0, int green = 0, int blue = 0)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Alpha
        {
            get => alpha;
            set => alpha = value;
        }

        public int Red
        {
            get => red;
            set => red = value;
        }

        public int Green
        {
            get => green;
            set => green = value;
        }

        public int Blue
        {
            get => blue;
            set => blue = value;
        }
    }
}
