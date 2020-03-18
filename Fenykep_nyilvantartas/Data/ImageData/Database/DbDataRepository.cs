using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fenykep_nyilvantartas.Model;

namespace Fenykep_nyilvantartas.Data.Database
{
    //Adatbázis műveletek osztálya
    public class DbDataRepository : IDataRepository
    {
        public void DeleteImageByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetImages()
        {
            throw new NotImplementedException();
        }

        public void NewImage(string name, int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
