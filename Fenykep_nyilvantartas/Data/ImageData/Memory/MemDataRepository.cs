using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fenykep_nyilvantartas.Model;

namespace Fenykep_nyilvantartas.Data.Memory
{
    //Memóriában tárolt adatokra vonatkozó műveletek 
    public class MemDataRepository : IDataRepository
    {
        private List<Model.Image> img = new List<Model.Image>();
        public void NewImage(string name, int width, int height)
        {
            img.Add(new Model.Image(name, width, height));
        }
        public void DeleteImageByName(string name)
        {
            img.Remove(img.Where(x => x.name.Equals(name)).Single());
        }
        public List<Model.Image> GetImages()
        {
            return img;
        }
    }
}
