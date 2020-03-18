using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.UI
{
    //Konzolos UI implementációja
    abstract class ConsoleUI
    {
        public void ToDo()
        {
            Logic.ImageManager.NewImage("Test_Picture",500,500);
            WriteImages();
            Logic.ImageManager.NewImage(null, 500, 500);
            WriteImages();
            Logic.ImageManager.DeleteImageByName("Test_Picture");
            WriteImages();
        }

        protected abstract void WriteImages();
    }
}
