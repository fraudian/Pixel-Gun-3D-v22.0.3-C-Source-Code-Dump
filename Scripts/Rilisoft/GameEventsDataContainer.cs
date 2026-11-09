using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal class GameEventsDataContainer
    {
        // Fields
        internal System.Collections.Generic.List<Rilisoft.GameEventData> Events;
        internal Rilisoft.GameEventDropChanceData DropChanceData;
        
        // Methods
        public GameEventsDataContainer()
        {
            this.Events = new System.Collections.Generic.List<Rilisoft.GameEventData>();
            this.DropChanceData = new Rilisoft.GameEventDropChanceData();
        }
    
    }

}
