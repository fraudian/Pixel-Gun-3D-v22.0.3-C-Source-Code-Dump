using UnityEngine;
public class UIDragDropContainer : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform reparentTarget;
    
    // Methods
    protected virtual void Start()
    {
        if(this.reparentTarget != 0)
        {
                return;
        }
        
        this.reparentTarget = this.transform;
    }
    public UIDragDropContainer()
    {
    
    }

}
