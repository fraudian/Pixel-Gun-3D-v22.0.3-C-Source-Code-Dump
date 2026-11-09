using UnityEngine;
public sealed class SettingsToggleButtons : MonoBehaviour
{
    // Fields
    private bool 丈丙丄丅丌丙丆丘不;
    private UIToggle 丞东专丟丙丏不丆七;
    public UIButton offButton;
    public UIButton onButton;
    public UIButton switchToggleButton;
    private System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> 丅丕丌丛万丂丈七与;
    
    // Properties
    public bool 业丟丑一丗丆业丛上 { get; set; }
    private UIToggle 三丅丌丘三上丟丕东 { get; }
    
    // Methods
    public bool get_IsChecked()
    {
        if(this.丕丏丌丟专不世与丁() == 0)
        {
                return (bool)this.丈丙丄丅丌丙丆丘不;
        }
        
        UIToggle val_3 = this.丕丏丌丟专不世与丁();
        if(val_3 != null)
        {
                return val_3.value;
        }
        
        return val_3.value;
    }
    public void set_IsChecked(bool 丙业与丙丗丝不丈东)
    {
        if(this.丕丏丌丟专不世与丁() != 0)
        {
                this.丕丏丌丟专不世与丁().Set(丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
            return;
        }
        
        this.丈丙丄丅丌丙丆丘不 = 丙业与丙丗丝不丈东;
        if(this.offButton != 0)
        {
                if(this.onButton != 0)
        {
            goto label_10;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "toggle not setted, GO: \'{0}\'", arg0:  this.gameObject.name));
        return;
        label_10:
        var val_11 = (this.丈丙丄丅丌丙丆丘不 == true) ? 1 : 0;
        var val_12 = (this.丈丙丄丅丌丙丆丘不 == false) ? 1 : 0;
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        Rilisoft.丛丘不丄丗丝丗七上 val_13 = new Rilisoft.丛丘不丄丗丝丗七上();
        val_13.专丐丆丝丑丄丑丄丈(丙业与丙丗丝不丈东:  (this.丈丙丄丅丌丙丆丘不 == true) ? 1 : 0);
        this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  val_13);
    }
    private UIToggle 丕丏丌丟专不世与丁()
    {
        if(this.丞东专丟丙丏不丆七 != 0)
        {
                return (UIToggle)this.丞东专丟丙丏不丆七;
        }
        
        UIToggle val_3 = this.gameObject.GetComponentInChildren<UIToggle>(includeInactive:  true);
        this.丞东专丟丙丏不丆七 = val_3;
        if(val_3 == 0)
        {
                return (UIToggle)this.丞东专丟丙丏不丆七;
        }
        
        EventDelegate val_6 = null;
        1152921504848912384 = val_6;
        val_6 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SettingsToggleButtons::丐三丕丕丝丛丑与丛()));
        this.丞东专丟丙丏不丆七.onChange.Add(item:  val_6);
        return (UIToggle)this.丞东专丟丙丏不丆七;
    }
    public void add_Clicked(System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> 丙业与丙丗丝不丈东)
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
        while(this.丅丕丌丛万丂丈七与 != 1152921538958370816);
    
    }
    public void remove_Clicked(System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> 丙业与丙丗丝不丈东)
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
        while(this.丅丕丌丛万丂丈七与 != 1152921538958507392);
    
    }
    private void 丐三丕丕丝丛丑与丛()
    {
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        Rilisoft.丛丘不丄丗丝丗七上 val_1 = new Rilisoft.丛丘不丄丗丝丗七上();
        val_1.专丐丆丝丑丄丑丄丈(丙业与丙丗丝不丈东:  this.丕丏丌丟专不世与丁().value);
        this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  val_1);
    }
    private void Start()
    {
        var val_9;
        IntPtr val_11;
        if(this.丕丏丌丟专不世与丁() == 0)
        {
                this.onButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsToggleButtons::一丞丏世丞丙丆丏丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_9 = this.offButton.GetComponent<Rilisoft.ButtonHandler>();
            val_11 = 1152921538958773888;
        }
        else
        {
                if(this.switchToggleButton == 0)
        {
                return;
        }
        
            val_9 = this.switchToggleButton.GetComponent<Rilisoft.ButtonHandler>();
            System.EventHandler val_8 = null;
            val_11 = 1152921538958791296;
        }
        
        val_8 = new System.EventHandler(object:  this, method:  val_11);
        val_9.add_Clicked(丙业与丙丗丝不丈东:  val_8);
    }
    internal void 丅丁丝丁丈丛丐且丑(bool 丆丛丆丞下丅丂且丝)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丕丏丌丟专不世与丁())) == false)
        {
                return;
        }
        
        this.丕丏丌丟专不世与丁().enabled = 丆丛丆丞下丅丂且丝;
        this.丕丏丌丟专不世与丁().GetComponent<UnityEngine.Collider>().enabled = 丆丛丆丞下丅丂且丝;
    }
    public SettingsToggleButtons()
    {
    
    }
    private void 一丞丏世丞丙丆丏丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.IsChecked = true;
    }
    private void 七丌且且丞下下丄丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.IsChecked = false;
    }
    private void 丈丙业一丘东丝丟丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.IsChecked = (~this.IsChecked) & 1;
    }

}
