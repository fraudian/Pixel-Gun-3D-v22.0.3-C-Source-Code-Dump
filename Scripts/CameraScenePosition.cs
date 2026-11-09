using UnityEngine;
public class CameraScenePosition : MonoBehaviour
{
    // Fields
    internal static CameraScenePosition 丄丘七三上丕世丞业;
    public float fieldOfView;
    
    // Methods
    private void Awake()
    {
        CameraScenePosition.丄丘七三上丕世丞业 = this;
    }
    public CameraScenePosition()
    {
        this.fieldOfView = 22.3f;
    }

}
