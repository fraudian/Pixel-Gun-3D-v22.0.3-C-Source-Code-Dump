using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPDataContainer
    {
        // Fields
        public PGCompany.BattlePass.BPData mainData;
        public System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> challengesData;
        
        // Methods
        public BPDataContainer()
        {
        
        }
    
    }

}
