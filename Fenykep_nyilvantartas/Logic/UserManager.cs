using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.Logic
{
    //Felhasználó id-jának lekérése Singleton mintával
    class UserManager
    {
        private static UserManager instance = null;

        public static UserManager GetInstance()
        {
            if (instance == null)
                instance = new UserManager();
            return instance;
        }
        protected UserManager() { }
        public string Getid()
        {
            return "testid";
        }
    }
}
