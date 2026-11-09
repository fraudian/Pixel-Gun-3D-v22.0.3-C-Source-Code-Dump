using UnityEngine;
public class FlagPedestalController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject BluePedestal;
    public UnityEngine.GameObject RedPedestal;
    
    // Methods
    public void SetColor(int 丂丄一丗业丗丐万丏)
    {
        UnityEngine.GameObject val_1;
        var val_2;
        if(丂丄一丗业丗丐万丏 != 1)
        {
            goto label_0;
        }
        
        this.BluePedestal.SetActive(value:  true);
        val_1 = this.RedPedestal;
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_0:
        this.BluePedestal.SetActive(value:  false);
        val_1 = this.RedPedestal;
        if(丂丄一丗业丗丐万丏 != 2)
        {
            goto label_6;
        }
        
        val_2 = 1;
        goto label_7;
        label_6:
        val_2 = 0;
        label_7:
        val_1.SetActive(value:  false);
    }
    public FlagPedestalController()
    {
    
    }

}
