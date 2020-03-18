using System;
using System.Collections.Generic;
using System.Text;

namespace Fenykep_nyilvantartas.Data.UserData
{
    //felhasználó lekérdezése Strategy mintával
    public interface IUserRepository
    {
        string GetUsername(string id);
    }
}
