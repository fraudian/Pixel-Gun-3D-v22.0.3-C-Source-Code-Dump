using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventItemContainerData
    {
        // Fields
        public int ContainerId;
        public Rilisoft.GameEventItemContainerContentType ContentType;
        public Rilisoft.丒丙丂丛丙且且不丕 DropCategory;
        public float DropChance;
        public Rilisoft.GameEventContainerDropType DropType;
        public System.Collections.Generic.List<Rilisoft.GameEventItemData> Items;
        
        // Methods
        public GameEventItemContainerData()
        {
            this.Items = new System.Collections.Generic.List<Rilisoft.GameEventItemData>();
        }
    
    }

}
