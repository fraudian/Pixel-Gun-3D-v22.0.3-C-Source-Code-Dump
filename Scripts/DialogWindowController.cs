using UnityEngine;
public class DialogWindowController : MonoBehaviour
{
    // Fields
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private bool 下世七下上丝一七丅;
    protected UnityEngine.GameObject backCollider;
    protected UIButton cancelButton;
    private UnityEngine.GameObject loadingCircle;
    protected UILabel messageLabel;
    protected UIButton okButton;
    private System.Action 丒上丑七丗丛丘丗丝;
    private System.Action 上丁丄丅上不万丑丁;
    
    // Properties
    protected bool 丈丘丑丛且丝专丑七 { get; set; }
    
    // Methods
    protected bool 上上东下丞丌丝丌世()
    {
        return (bool)this.下世七下上丝一七丅;
    }
    protected void 丛丞七丝丛下丝丙三(bool 丙业与丙丗丝不丈东)
    {
        bool val_9 = 丙业与丙丗丝不丈东;
        this.下世七下上丝一七丅 = val_9;
        if(this.okButton == 0)
        {
                return;
        }
        
        val_9 = ???;
        var val_3 = (~val_9) & 1;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void add_OnOkAction(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒上丑七丗丛丘丗丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒上丑七丗丛丘丗丝 != 1152921536727227440);
    
    }
    public void remove_OnOkAction(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒上丑七丗丛丘丗丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒上丑七丗丛丘丗丝 != 1152921536727364016);
    
    }
    public void add_OnCancelAction(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上丁丄丅上不万丑丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丁丄丅上不万丑丁 != 1152921536727500600);
    
    }
    public void remove_OnCancelAction(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上丁丄丅上不万丑丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丁丄丅上不万丑丁 != 1152921536727637176);
    
    }
    private void OnEnable()
    {
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  typeof(DialogWindowController).__il2cppRuntimeField_1B0), 与且专丈不万东一万:  "DialogWindow");
        }
        
        if(this.backCollider != 0)
        {
                this.backCollider.SetActive(value:  true);
        }
        
        if(this.loadingCircle != 0)
        {
                this.loadingCircle.SetActive(value:  false);
        }
        
        this.丛丞七丝丛下丝丙三(丙业与丙丗丝不丈东:  false);
    }
    private void OnDisable()
    {
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    protected void 三丂与丟丌与与丌丟()
    {
        if(this.丒上丑七丗丛丘丗丝 == null)
        {
                return;
        }
        
        this.丒上丑七丗丛丘丗丝.Invoke();
    }
    protected void 丘丆丙专丈丏三业三()
    {
        if(this.上丁丄丅上不万丑丁 == null)
        {
                return;
        }
        
        this.上丁丄丅上不万丑丁.Invoke();
    }
    private void Awake()
    {
        System.EventHandler val_13;
        if(this.cancelButton != 0)
        {
                Rilisoft.ButtonHandler val_2 = this.cancelButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                System.EventHandler val_4 = null;
            val_13 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  typeof(DialogWindowController).__il2cppRuntimeField_180);
            val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        }
        
        if(this.okButton != 0)
        {
                Rilisoft.ButtonHandler val_6 = this.okButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_6 != 0)
        {
                System.EventHandler val_8 = null;
            val_13 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  typeof(DialogWindowController).__il2cppRuntimeField_190);
            val_6.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        }
        
        if(this.backCollider == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_10 = this.backCollider.GetComponent<Rilisoft.ButtonHandler>();
        if(val_10 == 0)
        {
                return;
        }
        
        val_10.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(DialogWindowController).__il2cppRuntimeField_1A0));
    }
    public virtual void TryShowDialog(string 丄丙下丝丛丒七丂丘)
    {
        if(this.messageLabel != 0)
        {
                this.messageLabel.text = 丄丙下丝丛丒七丂丘;
        }
        
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        this.gameObject.SetActive(value:  true);
    }
    protected virtual void 丐丝丄丅丞丘丄丕丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世七下上丝一七丅 != false)
        {
                return;
        }
        
        if(this.上丁丄丅上不万丑丁 != null)
        {
                this.上丁丄丅上不万丑丁.Invoke();
        }
        
        this.CloseWindow();
    }
    protected virtual void 丌丘业不丘一世不丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丛丞七丝丛下丝丙三(丙业与丙丗丝不丈东:  true);
        if(this.loadingCircle != 0)
        {
                this.loadingCircle.SetActive(value:  true);
        }
        
        if(this.丒上丑七丗丛丘丗丝 == null)
        {
                return;
        }
        
        this.丒上丑七丗丛丘丗丝.Invoke();
    }
    protected virtual void 丌上业丝万与东东七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下世七下上丝一七丅 != false)
        {
                return;
        }
        
        this.CloseWindow();
    }
    protected virtual void 东下丂与丄一丏丅三()
    {
        if(this.下世七下上丝一七丅 != false)
        {
                return;
        }
        
        this.CloseWindow();
    }
    public void CloseWindow()
    {
        if(this.backCollider != 0)
        {
                this.backCollider.SetActive(value:  false);
        }
        
        if(this != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丒上丑七丗丛丘丗丝 != null)
        {
                this.丒上丑七丗丛丘丗丝 = 0;
        }
        
        if(this.上丁丄丅上不万丑丁 == null)
        {
                return;
        }
        
        this.上丁丄丅上不万丑丁 = 0;
    }
    public DialogWindowController()
    {
    
    }

}
