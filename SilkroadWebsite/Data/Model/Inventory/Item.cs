using System.ComponentModel.DataAnnotations;

namespace SilkroadWebsite.Data.Model.Inventory
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Rarity { get; set; } = "Common"; // Common, Uncommon, Rare, Epic, Legendary
        public int Power { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int CriticalChance { get; set; }
        public int Durability { get; set; }
        public int LevelRequirement { get; set; }
        public string ItemType { get; set; } = string.Empty;
        public int MagicResistance { get; set; }
        public int HealthBonus { get; set; }
        public int ManaBonus { get; set; }
        // Magic options
        public int MagicPower { get; set; } // General magic strength
        public int BlueMagicDamage { get; set; } 
        public int MagicCooldownReduction { get; set; } // % reduction in spell cooldowns
    }
}
