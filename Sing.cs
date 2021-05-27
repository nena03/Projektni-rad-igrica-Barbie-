using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbie
{
    class Sing:MyInterface
    {
        

         public void Singandplay()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\Pc\source\repos\Barbie\Barbie\bin\Debug\muzikabarbi.wav";
            player.Play();
        }
    }
}
