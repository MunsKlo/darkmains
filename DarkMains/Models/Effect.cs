using System.Reflection.Metadata.Ecma335;

namespace DarkMains.Models
{
    public class Effect
    {
        public enum EffectType
        {
            Life, Buff, Debuff, Mana
        }
        public string Name { get; set; }
        public EffectType Type { get; set; }
        public DamageType DamageType { get; set; }
        public int Chance { get; set; }
        public int Duration { get; set; }
    }
}