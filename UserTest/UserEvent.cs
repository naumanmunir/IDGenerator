using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    class UserEvent
    {
        public delegate void UserID(string ID);
        public static event UserID assignID;
        public static event UserID getID;

        public static void ID(string ID)
        {
            assignID(ID);
        }
        public static void gID(string ID)
        {
            getID(ID);
        }
    }
}
