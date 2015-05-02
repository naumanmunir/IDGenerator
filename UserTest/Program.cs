using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{   

    delegate void mydelegate();

    class Program : Math
    {

        public static void UserIDGenerater()
        {
            string num = "0123456789";
            string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder builder = new StringBuilder();
            Random ran = new Random();
            char ch;
            char let;
            for (int i = 0; i < 6; i++)
            {
                ch = num[ran.Next(0, num.Length)];
                builder.Append(ch);
            }

            for (int i = 0; i < 1; i++)
            {
                let = letter[ran.Next(0, letter.Length)];
                builder.Append(let);
            }
            
            string n = builder.ToString();

            Console.WriteLine(n);
        }

        

        public static char firstletter()
        {
            char id;
            id = 'U';

            return id;
        }

        

        static void Main(string[] args)
        {

            IEnumerable<int> result = lessthanfive(new[] { 2, 9, 3, 4, 3, 6, 7, 8, 12, 10, 1 });
            foreach (int n in result)
                Console.WriteLine(n);

            //mydelegate del = new mydelegate(UserEvent_getID);
            //del();

            //Pointtomethod dell = new Pointtomethod(add);
            //Console.WriteLine(dell(3, 2));
            //UserEvent.assignID += UserEvent_assignID;
            //UserEvent.getID += UserEvent_getID;

            //UserIDGenerater();

        }

        static IEnumerable<int> lessthanfive(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number < 5)
                    yield return number;
            }
        }

        public static int add(int x, int y)
        {
            int results = x + y;

            return results;
        }

        static void UserEvent_getID()
        {
            Console.WriteLine("Hi");
        }

        static void UserEvent_assignID()
        {
            
        }
    }
}
