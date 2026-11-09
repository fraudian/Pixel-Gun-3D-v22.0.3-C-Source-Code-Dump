using UnityEngine;
public class HatchingEndedCallback : MonoBehaviour
{
    // Fields
    private static System.Action 一丞万三上上丐一丟;
    
    // Methods
    internal static void 丅丒丆丟丂丆丗丅丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  HatchingEndedCallback.一丞万三上上丐一丟, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丁丏不东一且上三丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  HatchingEndedCallback.一丞万三上上丐一丟, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public void HatchingCompleted()
    {
        null = null;
        if(HatchingEndedCallback.一丞万三上上丐一丟 == null)
        {
                return;
        }
        
        HatchingEndedCallback.一丞万三上上丐一丟.Invoke();
    }
    public HatchingEndedCallback()
    {
    
    }
    private static HatchingEndedCallback()
    {
    
    }

}
