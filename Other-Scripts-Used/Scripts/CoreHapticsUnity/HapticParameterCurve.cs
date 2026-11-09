using UnityEngine;

namespace CoreHapticsUnity
{
    public class HapticParameterCurve : IEvent
    {
        // Fields
        public CoreHapticsUnity.ParameterCurve ParameterCurve;
        
        // Methods
        public HapticParameterCurve(float time, CoreHapticsUnity.ParameterIDType id, CoreHapticsUnity.ParameterCurveControlPoint[] points)
        {
            this.ParameterCurve = new CoreHapticsUnity.ParameterCurve(time:  time, id:  id, points:  points);
        }
    
    }

}
