using DarkMains.Models.Interfaces;

namespace DarkMains.Models
{
    public class Character
    {
        public int Level { get; set; }
        public string Name { get; set; }
        
        public int HealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }

        public int ManaPoints { get; set; }
        public int MaxManaPoints { get; set; }

        public int Armor { get; set; }

        public IItem[] Inventory { get; set; }
    }
}