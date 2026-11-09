using UnityEngine;
public class CustomLod : MonoBehaviour
{
    // Fields
    public UnityEngine.Renderer[] ren;
    private bool 丞丏万丄七一丌万丆;
    
    // Properties
    public bool 丛丅丘一丏丙且丌上 { get; set; }
    
    // Methods
    public bool get_active()
    {
        return (bool)this.丞丏万丄七一丌万丆;
    }
    public void set_active(bool 丙业与丙丗丝不丈东)
    {
        var val_4;
        var val_1 = (this.丞丏万丄七一丌万丆 == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        val_4 = 0;
        this.丞丏万丄七一丌万丆 = 丙业与丙丗丝不丈东;
        goto label_1;
        label_6:
        this.ren[0].enabled = (this.丞丏万丄七一丌万丆 == true) ? 1 : 0;
        val_4 = 1;
        label_1:
        if(val_4 < this.ren.Length)
        {
            goto label_6;
        }
    
    }
    public CustomLod()
    {
    
    }

}
