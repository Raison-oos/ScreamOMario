using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ScreamOMario
{
    internal class Platform
    {
        public int positionX;
        public int positionY;
        public Image platformImage;
        //public int Width = 25;
        //public int Height = 10;
        public Platform()
        {
            platformImage = Properties.Resources.platform1;
            //platformImage = Properties.Resources.platform_01;
        }
    }
}
