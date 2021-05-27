using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbie
{
    public partial class Poslednjiprozor : Form
    {
        public Poslednjiprozor()
        {
            InitializeComponent();
        }
        Drug[] d = new Drug[3];

        private void Poslednjiprozor_Load(object sender, EventArgs e)
        {
            Image dana = Image.FromFile(@"C:\Users\Pc\source\repos\Barbie\Barbie\Barbi c#\modeli\prijatelj5.png");
            Image lena = Image.FromFile(@"C:\Users\Pc\source\repos\Barbie\Barbie\Barbi c#\modeli\prijatelj4.png");
            Image neda = Image.FromFile(@"C:\Users\Pc\source\repos\Barbie\Barbie\Barbi c#\modeli\prijatelj2.png");
            d[0] = new Drug1(100, 5, dana);
            d[1] = new Drug2(300, 5, lena);
            d[2] = new Drug3(500, 5, neda);





        }

        private void Poslednjiprozor_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 3; i++) d[i].Crtaj(e.Graphics);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            textBox2.Text = "My name is Lena!";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Cao, moje ime je Dana!";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " Zdravo, ja sam Neda!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d[0].Govor();
            d[1].Govor();
            d[2].Govor();
            Sing pevaj = new Sing();
            pevaj.Singandplay();
        }
    }
}






    

