using UnityEngine;
public class IPX : MonoBehaviour
{
    // Fields
    public bool needRecalculate;
    
    // Methods
    private void Awake()
    {
        if(this.needRecalculate == false)
        {
                return;
        }
        
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        this = this.GetComponent<UnityEngine.Camera>();
        if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
        {
                return;
        }
        
        IphoneXCameraScaler.丅丟与三且丌丐万丙(与业丞东丙丕且丏丈:  this);
    }
    public IPX()
    {
    
    }

}
