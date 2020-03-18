using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.Model
{
    //Képek osztálya
    public class Image
    {
        public string name { get; }
        public int width { get; }
        public int height { get; }

        public Image(string name, int width, int height)
        {
            this.name = name;
            this.width = width;
            this.height = height;
        }
    }
}
