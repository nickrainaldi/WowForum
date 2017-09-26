using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WowForum.CharacterInfoSwitches
{
    public class LookupDictionaries
    {
        public Dictionary<string, string> GetCharacterClass()
        {
            Dictionary<string, string> classes = new Dictionary<string, string>()
            {
                {"1","Warrior" },
                {"2","Paladin" },
                {"3","Hunter" },
                {"4","Rogue" },
                {"5","Priest" },
                {"6","Death Knight" },
                {"7","Shaman" },
                {"8","Mage" },
                {"9","Warlock" },
                {"10","Monk" },
                {"11","Druid" },
                {"12","Demon Hunter" }

            };

            return classes;
        }

        public Dictionary<string, string> GetCharacterRace()
        {
            Dictionary<string, string> race = new Dictionary<string, string>()
            {
                {"1","Human" },
                {"2","Orc" },
                {"3","Dwarf" },
                {"4","Night Elf" },
                {"5","Undead" },
                {"6","Tauren" },
                {"7","Gnome" },
                {"8","Troll" },
                {"9","Goblin" },
                {"10","Blood Elf" },
                {"11","Draenei" },
                {"22","Worgen" },
                {"24","Pandaren" },
                {"25","Pandaren" },
                {"26","Pandaren" },


            };

            return race;
        }

        public Dictionary<string, string> GetCharacterGender()
        {
            Dictionary<string, string> gender = new Dictionary<string, string>()
            {
                {"0","Male" },
                {"1","Female" },


            };

            return gender;
        }

        public Dictionary<string, string> GetCharacterFaction()
        {
            Dictionary<string, string> faction = new Dictionary<string, string>()
            {
                {"0","Alliance" },
                {"1","Horde" },


            };

            return faction;
        }

    }
}