using UnityEngine;
public class LODsHolder : MonoBehaviour
{
    // Fields
    public float[] lowLodsLevels;
    public float lowLodsTargetSize;
    public UnityEngine.GameObject[] LowLODs;
    public float[] MidLodsLevels;
    public float MidLodsTargetSize;
    public UnityEngine.GameObject[] MidLODs;
    public float[] BigLodsLevels;
    public float BigLodsTargetSize;
    public UnityEngine.GameObject[] BigLODs;
    public UnityEngine.GameObject[] ALL_LODS;
    
    // Methods
    public LODsHolder()
    {
    
    }

}
