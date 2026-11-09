using UnityEngine;
public class IMPath : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<IMBuildPathPoint> pathPoints;
    
    // Methods
    public IMPath()
    {
        this.pathPoints = new System.Collections.Generic.List<IMBuildPathPoint>();
    }

}
