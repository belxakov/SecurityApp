using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class data
    {
        // data connection
        static public string connectionString = @"host=localhost;user=root;password=root;database=departament_security";
        // data user
        static public string uid;
        static public string uName;
        static public string uSurname;
        static public string uPatronymic;
        static public string uCard;
        static public string uRole;
        // default admin
        static public string login = "admin1";
        static public string password = "admin1";
    }
}
