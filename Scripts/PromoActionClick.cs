using UnityEngine;
public class PromoActionClick : MonoBehaviour
{
    // Fields
    private static System.Action<string> 一万东丛且不丌丁丈;
    
    // Methods
    internal static void 丘下一丟万专丙丑万(System.Action<string> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PromoActionClick.一万东丛且不丌丁丈, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丆丝且一丆丏丐专丌(System.Action<string> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PromoActionClick.一万东丛且不丌丁丈, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void OnPress(bool 丙与丈丛丑丘丞三七)
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_18 = 丙与丈丛丑丘丞三七;
        val_19 = this;
        val_20 = 1152921535989060672;
        val_21 = this.transform.parent.GetComponent<PromoActionPreview>();
        if(val_21 == null)
        {
            goto label_3;
        }
        
        if(val_18 == false)
        {
            goto label_4;
        }
        
        label_15:
        if(val_3.pressed == 0)
        {
                return;
        }
        
        PromoActionPreview val_7 = this.transform.parent.GetComponent<PromoActionPreview>();
        PromoActionPreview val_10 = this.transform.parent.GetComponent<PromoActionPreview>();
        if(val_7.icon != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        val_18 = ???;
        val_19 = ???;
        val_20 = ???;
        val_21 = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
        label_3:
        if((val_18 & 1) != 0)
        {
            goto label_15;
        }
        
        label_4:
        if((val_21 + 104) == 0)
        {
                return;
        }
        
        UnityEngine.Renderer val_17 = val_19.transform.parent.GetComponent<UnityEngine.Renderer>();
        if((val_19.transform.parent.GetComponent<UnityEngine.Renderer>()) != null)
        {
            goto label_25;
        }
        
        goto label_26;
    }
    private void OnClick()
    {
        if(PromoActionClick.一万东丛且不丌丁丈 != null)
        {
                PromoActionPreview val_3 = this.transform.parent.GetComponent<PromoActionPreview>();
            PromoActionClick.一万东丛且不丌丁丈.Invoke(obj:  val_3.tg);
        }
        
        UnityEngine.Debug.Log(message:  "Click");
    }
    public PromoActionClick()
    {
    
    }

}
