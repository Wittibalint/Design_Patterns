using Fenykep_nyilvantartas.Data;
using Fenykep_nyilvantartas.Data.Memory;
using Fenykep_nyilvantartas.Data.UserData;
using System;
using System.Collections.Generic;

namespace Fenykep_nyilvantartas.Logic
{
    //Képekkel kapcsolatos logika az adat elérése Dependency injection-nel
    public static class ImageManager
    {
        private static readonly IDataRepository data = new MemDataRepository();
        private static readonly IUserRepository user = new MemUser();
        public static void NewImage(string name, int width, int height)
        {
            try
            {
                if (name.Equals(0) || name.Equals(null) || width <= 0 || width > 1000000
                    || height <= 0 || height > 1000000)
                {
                    throw new Exception();
                }
                data.NewImage(name, width, height);
                Logging("New image added");
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input error");
            }
        }
        public static void DeleteImageByName(string name)
        {
            data.DeleteImageByName(name);
            Logging("Image Deleted");
        }
        public static List<Model.Image> GetImages()
        {
            return data.GetImages();
        }
        private static void Logging(string action)
        {
            Console.WriteLine("action: " + action + "  "+ "user: " + user.GetUsername(UserManager.GetInstance().Getid()));
        }
    }
}
