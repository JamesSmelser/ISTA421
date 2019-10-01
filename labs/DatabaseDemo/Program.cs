using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            string console = "";
            do
            {
                console = Util.GetConsole();
                Console.WriteLine(console);
                int.TryParse(Console.ReadLine(), out userChoice);
                if (userChoice == 0)
                    Util.ReconstituteDatabase();
                else if (userChoice == 1)
                    Util.EnterNewUser();
                else if (userChoice == 2)
                    Util.RunQuery("authenticate user");
                else if (userChoice == 3)
                    Util.RunQuery("change password");
                else if (userChoice == 4)
                    Util.RunQuery("delete user");
                else if (userChoice == 5)
                    Util.DisplayUsers();
                else if (userChoice == 9)
                    Environment.Exit(0);
                else
                    Console.WriteLine("Invalid choice, please try again.");
            }
            while (userChoice != 9);
        }
    }
}
