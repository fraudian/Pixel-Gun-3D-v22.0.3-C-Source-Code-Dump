using UnityEngine;
public class ButtonSwitch : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject enabledGo;
    private UnityEngine.GameObject disbledGo;
    private bool noSound;
    private bool isAutomatic;
    private UITweener tweenOn;
    private UITweener tweenOff;
    private System.EventHandler 丅丕丌丛万丂丈七与;
    
    // Properties
    private UnityEngine.Collider 且丙与丏下丅丐世丑 { get; }
    public bool 丝上丙丌上丏丅丅丏 { get; }
    private bool 丞七丛与丝下一一丆 { get; set; }
    
    // Methods
    private UnityEngine.Collider 业丑丈七丕丝丏丂丏()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.GetComponent<UnityEngine.Collider>();
        }
        
        return val_1.GetComponent<UnityEngine.Collider>();
    }
    public bool get_HasClickedHandlers()
    {
        return (bool)(this.丅丕丌丛万丂丈七与 != 0) ? 1 : 0;
    }
    public void add_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921525567409600);
    
    }
    public void remove_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921525567546176);
    
    }
    private bool 丈丘丂丙不丛业丟三()
    {
        if(this.业丑丈七丕丝丏丂丏() == 0)
        {
                return false;
        }
        
        UnityEngine.Collider val_3 = this.业丑丈七丕丝丏丂丏();
        if(val_3 != null)
        {
                return val_3.enabled;
        }
        
        return val_3.enabled;
    }
    private void 东丈业东丛丗七丘不(bool 丙业与丙丗丝不丈东)
    {
        if(this.业丑丈七丕丝丏丂丏() == 0)
        {
                return;
        }
        
        this.业丑丈七丕丝丏丂丏().enabled = 丙业与丙丗丝不丈东;
    }
    private void OnClick()
    {
        var val_3;
        if(this.isAutomatic == false)
        {
                return;
        }
        
        if(this.丈丘丂丙不丛业丟三() == false)
        {
                return;
        }
        
        if((ButtonClickSound.丆丕丝丒不丙且丐丗 != 0) && (this.noSound != true))
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.Switch(丆丛丆丞下丅丂且丝:  false);
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  System.EventArgs.Empty);
    }
    public void DoClick()
    {
        if(this.丈丘丂丙不丛业丟三() == false)
        {
                return;
        }
        
        this.OnClick();
    }
    public void Switch(bool 丆丛丆丞下丅丂且丝)
    {
        bool val_4 = 丆丛丆丞下丅丂且丝;
        bool val_1 = val_4;
        this.enabledGo.SetActive(value:  val_1);
        val_4 = (~val_4) & 1;
        this.disbledGo.SetActive(value:  val_4);
        this.东丈业东丛丗七丘不(丙业与丙丗丝不丈东:  val_1);
        if((val_4 & 1) != 0)
        {
            goto label_3;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.tweenOn)) == false)
        {
                return;
        }
        
        this.tweenOn.ResetToBeginning();
        if(this.tweenOn != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.tweenOn.PlayForward();
        return;
        label_3:
        if((UnityEngine.Object.op_Implicit(exists:  this.tweenOff)) == false)
        {
                return;
        }
        
        this.tweenOff.ResetToBeginning();
        if(this.tweenOff != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    public ButtonSwitch()
    {
        this.isAutomatic = true;
    }

}
