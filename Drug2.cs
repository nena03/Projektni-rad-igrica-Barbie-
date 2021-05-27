using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbie
{
    class Drug2:Drug
    {
        public Drug2(int x, int y, Image img) : base(x, y, img)
        { }
        public override void Crtaj(Graphics g)
        {
            g.DrawImage(img, x, y);
        }

       

        public override void Govor()
        {
           MessageBox.Show("My name is Lena!");
        }
    }
}
