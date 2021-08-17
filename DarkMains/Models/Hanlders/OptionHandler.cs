using System;
using DarkMains.Models.Interfaces;

namespace DarkMains.Models.Hanlders
{
    public class OptionHandler
    {
        public delegate void delegateMethod();
        public delegateMethod HandleOption(Option option)
        {
            delegateMethod optionMethod = new delegateMethod(Dummy);
            if (option.Name == "Exit")
            {
                optionMethod = new delegateMethod(Exit);
            }

            return optionMethod;
        }

        public void Dummy()
        {
            Console.WriteLine("Dummy");
        }
        
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}