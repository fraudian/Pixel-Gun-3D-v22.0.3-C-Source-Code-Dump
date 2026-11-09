using UnityEngine;
public class MainMenuAudioListenerController : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform camToFollow;
    
    // Methods
    private void Update()
    {
        if(this.camToFollow == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.camToFollow.position;
        this.gameObject.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Quaternion val_7 = this.camToFollow.rotation;
        this.gameObject.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    public MainMenuAudioListenerController()
    {
    
    }

}
