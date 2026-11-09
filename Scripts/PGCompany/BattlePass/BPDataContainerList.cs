using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    internal class BPDataContainerList
    {
        // Fields
        public System.Collections.Generic.List<PGCompany.BattlePass.BPDataContainer> bpDataContainers;
        
        // Methods
        public BPDataContainerList()
        {
            this.bpDataContainers = new System.Collections.Generic.List<PGCompany.BattlePass.BPDataContainer>();
        }
    
    }

}
