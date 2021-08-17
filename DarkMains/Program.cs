using System;
using System.Text;
using DarkMains.Models;
using DarkMains.Models.Hanlders;

namespace DarkMains
{
    class Program
    {
        private static Menu currentMenu;

        private static OptionHandler optionHandler = new OptionHandler();
        
        private static void Main(string[] args)
        {
            var mainMenu = new Menu("MainMenu", "New Game", "Test", "Exit");
            currentMenu = mainMenu;
            var menu = CreateMenu(mainMenu);
            PrintMenu(menu);
            var option = ReturnNumberOption(Console.ReadLine());

            var test = optionHandler.HandleOption(currentMenu.Options[option - 1]);

            if (test == optionHandler.Dummy)
            {
                test();
            }
            else
            {
                test();
            }

            Console.ReadLine();

        }

        private static int ReturnNumberOption(string option)
        {
            int.TryParse(option, out int numb);
            return numb;
        }

        private static string CreateMenu(Menu menu)
        {
            var printingMenu = new StringBuilder();

            printingMenu.AppendLine(menu.Name);
            printingMenu.AppendLine();
            
            for (var i = 0; i < menu.Options.Length; i++)
            {
                printingMenu.AppendLine($"{i + 1}. {menu.Options[i].Name}");
            }

            return printingMenu.ToString();
        }

        private static void PrintMenu(string menu)
        {
            Console.WriteLine(menu);
        }
    }
}