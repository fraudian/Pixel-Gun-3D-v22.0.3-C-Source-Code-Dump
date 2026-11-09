using UnityEngine;
public class SimpleBunner : MonoBehaviour
{
    // Fields
    private System.Action 与业丑丅丁丌丛丑丒;
    private System.Action 丝上丂一不专丂丄不;
    private System.Action 七东业丅丗下一丄丘;
    private System.Action 且丆万丂世不丑丙世;
    private System.IDisposable 与丅世与丄丑丌丞东;
    
    // Properties
    public bool 丅业东万丌丕上丌丄 { get; }
    
    // Methods
    public void add_onShow(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.与业丑丅丁丌丛丑丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.与业丑丅丁丌丛丑丒 != 1152921536930806488);
    
    }
    public void remove_onShow(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.与业丑丅丁丌丛丑丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.与业丑丅丁丌丛丑丒 != 1152921536930943064);
    
    }
    public void add_onHide(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丝上丂一不专丂丄不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝上丂一不专丂丄不 != 1152921536931079648);
    
    }
    public void remove_onHide(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丝上丂一不专丂丄不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝上丂一不专丂丄不 != 1152921536931216224);
    
    }
    public void add_onEnable(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.七东业丅丗下一丄丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七东业丅丗下一丄丘 != 1152921536931352808);
    
    }
    public void remove_onEnable(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.七东业丅丗下一丄丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七东业丅丗下一丄丘 != 1152921536931489384);
    
    }
    public void add_onDisable(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.且丆万丂世不丑丙世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.且丆万丂世不丑丙世 != 1152921536931625968);
    
    }
    public void remove_onDisable(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.且丆万丂世不丑丙世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.且丆万丂世不丑丙世 != 1152921536931762544);
    
    }
    public bool get_IsActive()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    protected virtual void OnEnable()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(SimpleBunner).__il2cppRuntimeField_1A0);
        this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "SimpleBunner_" + this.gameObject.name);
        if(this.七东业丅丗下一丄丘 == null)
        {
                return;
        }
        
        this.七东业丅丗下一丄丘.Invoke();
    }
    protected virtual void OnDisable()
    {
        if(this.与丅世与丄丑丌丞东 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.与丅世与丄丑丌丞东.Dispose();
        }
        
        if(this.且丆万丂世不丑丙世 == null)
        {
                return;
        }
        
        this.且丆万丂世不丑丙世.Invoke();
    }
    public virtual void Show()
    {
        this.gameObject.SetActive(value:  true);
        if(this.与业丑丅丁丌丛丑丒 == null)
        {
                return;
        }
        
        this.与业丑丅丁丌丛丑丒.Invoke();
    }
    public virtual void Hide()
    {
        this.gameObject.SetActive(value:  false);
        if(this.丝上丂一不专丂丄不 == null)
        {
                return;
        }
        
        this.丝上丂一不专丂丄不.Invoke();
    }
    public virtual void Toggle()
    {
        if(this.IsActive != false)
        {
            
        }
    
    }
    public SimpleBunner()
    {
    
    }

}
