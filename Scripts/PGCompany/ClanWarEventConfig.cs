using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal struct ClanWarEventConfig
    {
        // Fields
        internal int Id;
        internal PGCompany.丂不上丗与丌与丐丌 Type;
        internal Rilisoft.丝丑丂丛万丐丈丘且 StartDay;
        internal string StartTime;
        internal Rilisoft.丝丑丂丛万丐丈丘且 EndDay;
        internal string EndTime;
        internal System.Collections.Generic.List<string> Templates;
        internal Rilisoft.丝丑丂丛万丐丈丘且 TaskNeededCount;
        internal string TaskDescription;
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> Rewards;
        internal System.Collections.Generic.Dictionary<int, int> SiegeEnemies;
        internal int RaidEnemies;
        
    
    }

}
