using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Circle : Ellipse
    {
        public Circle(int x, int y, int w) : base(x, y, w, w)
        {
        }
    }
}
