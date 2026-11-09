using UnityEngine;
public class LookAtScript : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform t_target;
    
    // Methods
    private void Update()
    {
        this.transform.LookAt(target:  this.t_target);
    }
    public LookAtScript()
    {
    
    }

}
