using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroup
{
    class App
    {
        //edit to test
        PrintMenu();
        int menuPick; = ValidateInt();
        
        switch(menuPick)
        {
            case 1:
            DisplayBooks();
            break;
            case 2:
            PrintSearchMenu();
            int searchMenuPick = ValidateInt();
            switch(searchMenuPick)
                {
                    case 1:
                    SearchAuthor();
                    break;
                    case 2:
                    SearchTitle();
                    break;
                }

            break;
            
            case 3:
            CheckOutBook();
            break
            case 4:
            ReturnBook();
            break;
            case 5:
            Quit(); //Quit prints out the list using I/O
        }

    }
}
