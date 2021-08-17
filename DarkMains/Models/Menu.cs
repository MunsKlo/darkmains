using System.Collections.Generic;
using DarkMains.Models.Interfaces;

namespace DarkMains.Models
{
    public class Menu
    {
        public string Name { get; set; }
        public Option[] Options { get; set; }

        public Menu(string name, params string[] options)
        {
            Name = name;

            Options = new Option[options.Length];
            
            for (int i = 0; i < options.Length; i++)
            {
                Options[i] = new Option(options[i]);
            }
        }
    }
}