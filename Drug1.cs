using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbie
{
     class Drug1:Drug
    {
        private object g;

        public Drug1(int x, int y, Image img) : base(x, y, img)
        { }
        public override void Crtaj(Graphics g)
        {
            g.DrawImage(img, x, y);
        }

        public override void Govor()
        {
           MessageBox.Show("Cao, moje ime je Dana!");
        }
    }
}
