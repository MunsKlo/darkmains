using System.Reflection.Metadata.Ecma335;

namespace DarkMains.Models.Interfaces
{
    public interface IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Effect Effect { get; set; }
    }
}