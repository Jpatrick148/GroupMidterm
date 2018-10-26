using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroup
{
    class Menu
    {
        
        public static void MenuChoice()
        {

            Console.WriteLine("1) List all books");
            Console.WriteLine("2) Search by Author");
            Console.WriteLine("3) Search by Title");
            Console.WriteLine("4) Exit");
            string choice = Console.ReadLine();


            int pick = 0;
            Int32.TryParse(choice, out pick);


            {
                switch (pick)
                {


                    case 1:
                        //return
                        break;

                    case 2:
                        //return
                        break;

                    case 3:
                        //return
                        break;

                    case 4:
                        //return
                        break;


                    default:
                        //return
                        break;


                }
            }
        }

    }
}


    

