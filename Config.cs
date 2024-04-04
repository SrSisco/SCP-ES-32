using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SCP_ES_32
{
    public class Config : IConfig
    {
        // ----------------------- GENERAL -----------------------
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("Debug mode enabled?")]
        public bool Debug { get; set; } = false;
        
        
        // ----------------------- TIMES -----------------------
        [Description("Time between spawns.")]
        public float TimeBetweenSpawns { get; set; } = 20.0f;
        
        
        // ----------------------- RAGDOLL -----------------------
        [Description("Ragdoll spawn enabled?")]
        public bool RagdollSpawn { get; set; } = true;
        
        [Description("Ragdoll probability spawn (0 = 100% 100 = 0%")]
        public int RagdollProbability { get; set; } = 90;
                
        [Description("Ragdoll names.")]
        public List<string> RagdollNames = new List<string>()
        {
            "Juan","Miguel","Adolfo"
            , "Cristian","Laura","Lorena","Guillermo","Hernán","Álvaro"
            ,"Jose", "Jesús","Lorenzo","Alberto","????"
        };

        [Description("Ragdoll death reasons.")]
        public List<string> RagdollDeaths = new List<string>()
        {
            "Killed by an SCP", "Neck was snapped", "Just a green mess"
        };
        
        
        // ----------------------- ITEMS -----------------------
        
        [Description("Item spawn enabled?")]
        public bool ItemSpawn { get; set; } = true;
        
        [Description("Item spawn probability (0 = 100% 100 = 0%")]
        public int ItemProbability { get; set; } = 50;
        
        [Description("Items that can spawn.")]
        public List<ItemType> Spawnable_Items = new List<ItemType>()
        {
            ItemType.Adrenaline, ItemType.Ammo9x19, ItemType.Ammo12gauge, ItemType.Ammo44cal,
            ItemType.Ammo556x45, ItemType.Ammo762x39, ItemType.Coin, ItemType.Flashlight,
            ItemType.Jailbird, ItemType.Medkit, ItemType.ArmorCombat, ItemType.ArmorHeavy,
            ItemType.GunA7, ItemType.KeycardO5, ItemType.KeycardChaosInsurgency, ItemType.KeycardMTFOperative,
            ItemType.SCP244a, ItemType.SCP500, ItemType.SCP018,ItemType.SCP207,ItemType.SCP268,ItemType.SCP330,
            ItemType.SCP1576,ItemType.SCP2176,ItemType.AntiSCP207,ItemType.GunRevolver,ItemType.GunCrossvec,ItemType.GunRevolver,
            ItemType.GunCOM15,ItemType.GunCOM18,ItemType.GunE11SR,ItemType.GunFRMG0
        };

    }
}