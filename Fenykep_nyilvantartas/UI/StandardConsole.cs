using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.UI
{
    class StandardConsole : UI.ConsoleUI
    {
        public StandardConsole()
        {
        }

        protected override void WriteImages()
        {
            var img = Logic.ImageManager.GetImages();
            foreach (var i in img)
            {
                Console.WriteLine(i.name + "; " + i.width + "; " + i.height);
            }
        }
    }
}
