using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.Data
{
    //interfész az adatok elérésére Strategy mintával
    public interface IDataRepository
    {
        void NewImage(string name, int width, int height);
        void DeleteImageByName(string name);
        List<Model.Image> GetImages();
    }
}
