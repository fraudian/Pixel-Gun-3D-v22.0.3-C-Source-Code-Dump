using UnityEngine;

namespace CoreHapticsUnity
{
    public class ParameterCurveControlPoint
    {
        // Fields
        public float Time;
        public float ParameterValue;
        
        // Methods
        public ParameterCurveControlPoint(float time, float value)
        {
            this.Time = time;
            this.ParameterValue = value;
        }
    
    }

}
