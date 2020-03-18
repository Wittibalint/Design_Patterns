using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.Data.UserData
{
    //Felhasználó visszaadása implementációja
    public class MemUser : IUserRepository
    {
        public string GetUsername(string id)
        {
            return "Teszt Aladar";
        }
    }
}
