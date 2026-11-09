using UnityEngine;

namespace CoreHapticsUnity
{
    public class HapticsPattern
    {
        // Fields
        public System.Collections.Generic.List<CoreHapticsUnity.IEvent> Pattern;
        
        // Methods
        public HapticsPattern(System.Collections.Generic.IEnumerable<CoreHapticsUnity.IEvent> events)
        {
            this.Pattern = new System.Collections.Generic.List<CoreHapticsUnity.IEvent>(collection:  events);
        }
        public HapticsPattern(int capacity)
        {
            this.Pattern = new System.Collections.Generic.List<CoreHapticsUnity.IEvent>(capacity:  capacity);
        }
        public void AddEvent(CoreHapticsUnity.IEvent _event)
        {
            System.Collections.Generic.List<CoreHapticsUnity.IEvent> val_2 = this.Pattern;
            if(val_2 == null)
            {
                    System.Collections.Generic.List<CoreHapticsUnity.IEvent> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.List<CoreHapticsUnity.IEvent>();
                this.Pattern = val_2;
            }
            
            val_1.Add(item:  _event);
        }
    
    }

}
