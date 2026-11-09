using UnityEngine;

namespace CoreHapticsUnity
{
    public class Event
    {
        // Fields
        public float Time;
        public string EventType;
        public float EventDuration;
        public CoreHapticsUnity.EventParameter[] EventParameters;
        
        // Methods
        public Event(float time, CoreHapticsUnity.EventType eventType, CoreHapticsUnity.EventParameter[] parameters, float duration = 0)
        {
            this.Time = time;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.EventType = eventType.ToString();
            this.EventDuration = duration;
            this.EventParameters = parameters;
        }
    
    }

}
