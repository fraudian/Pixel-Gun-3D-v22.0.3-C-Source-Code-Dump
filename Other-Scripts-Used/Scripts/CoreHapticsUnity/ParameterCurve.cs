using UnityEngine;

namespace CoreHapticsUnity
{
    public class ParameterCurve
    {
        // Fields
        public string ParameterID;
        public float Time;
        public CoreHapticsUnity.ParameterCurveControlPoint[] ParameterCurveControlPoints;
        
        // Methods
        public ParameterCurve(float time, CoreHapticsUnity.ParameterIDType id, CoreHapticsUnity.ParameterCurveControlPoint[] points)
        {
            this.Time = time;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.ParameterID = id.ToString();
            this.ParameterCurveControlPoints = points;
        }
    
    }

}
