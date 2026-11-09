using UnityEngine;

namespace CoreHapticsUnity
{
    public class HapticEvent : IEvent
    {
        // Fields
        public CoreHapticsUnity.Event Event;
        
        // Methods
        public HapticEvent(float time, CoreHapticsUnity.EventType eventType, CoreHapticsUnity.EventParameter[] parameters, float duration = 0)
        {
            this.Event = new CoreHapticsUnity.Event(time:  time, eventType:  eventType, parameters:  parameters, duration:  duration);
        }
    
    }

}
