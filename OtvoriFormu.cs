using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbie
{
    class OtvoriFormu
    {
        private Form novaForma;

        public OtvoriFormu(Form novaForma)
        {
            this.novaForma = novaForma;
        }

        public void Otvori()
        {
            novaForma.Show();
            novaForma.BackColor = Color.LightPink;
            novaForma.Size = new Size(800, 500);
            novaForma.Location = new Point(250, 250);
        }
    }
}
