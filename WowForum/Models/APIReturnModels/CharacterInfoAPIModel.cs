using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WowForum.CharacterInfoSwitches;

namespace WowForum.Models.APIReturnModels
{
    public class CharacterInfoAPIModel
    {
        LookupDictionaries LD = new LookupDictionaries();
        Dictionary<string, string> LookupDict = new Dictionary<string, string>();


        public string lastModified { get; set; }
        public string name { get; set; }
        public string realm { get; set; }
        public string battlegroup { get; set; }
        public string Class { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public string level { get; set; }
        public string achievementPoints { get; set; }
        public string thumbnail { get; set; }
        public string calcClass { get; set; }
        public string faction { get; set; }
        public string totalHonorableKills { get; set; }


        public string recodedClass { get; set; }
        public string recodedRace { get; set; }
        public string recodedGender { get; set; }
        public string recodedFaction { get; set; }


        public void GetCharacterRecode()
        {
            GetClassRecode();
            GetRaceRecode();
            GetGenderRecode();
            GetFactionRecode();


        }

        public void GetClassRecode()
        {
            LookupDict = LD.GetCharacterClass();

            recodedClass = LookupDict[Class];


        }

        public void GetRaceRecode()
        {
            LookupDict = LD.GetCharacterRace();

            recodedRace = LookupDict[race];


        }

        public void GetGenderRecode()
        {
            LookupDict = LD.GetCharacterGender();

            recodedGender = LookupDict[gender];


        }

        public void GetFactionRecode()
        {
            LookupDict = LD.GetCharacterFaction();

            recodedFaction = LookupDict[faction];


        }
    }
}