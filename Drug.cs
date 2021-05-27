using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbie
{
     abstract class Drug
    {
        protected int x, y;
        protected Image img;

        protected Drug(int x, int y, Image img)
        {
            this.x = x;
            this.y = y;
            this.img = img;
        }


        public abstract void Crtaj(Graphics g);
        

        public abstract void Govor();
    }
}
