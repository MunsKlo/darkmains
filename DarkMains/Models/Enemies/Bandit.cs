namespace DarkMains.Models.Enemies
{
    public class Bandit : Enemy
    {
        public Bandit(string name, int lvl)
        {
            Level = lvl;

            Name = name;
            
            var multi = lvl / 100;
            MaxHealthPoints = 50 + multi * 100;
            HealthPoints = MaxHealthPoints;

            MaxManaPoints = 0;
            ManaPoints = MaxManaPoints;

            if (multi > 0)
            {
                Armor = 3 + (1 / 3 * multi);
            }
            else
            {
                Armor = 3;
            }
        }
    }
}