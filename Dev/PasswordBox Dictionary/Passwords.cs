using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordBox_Dictionary
{
    public static class Passwords
    {
        public static string user;

        public static Dictionary<string, string> userLogins = new Dictionary<string, string>()
        {
            {"MiMe", "Migelle Mertens" },
            {"OlQu", "Oliver Queen" },
            {"BaAl", "Barry Allen" }
        };
    }
}
