using UnityEngine;
public class UiEvents : MonoBehaviour
{
    // Fields
    private System.Action<UnityEngine.Vector2> 丛不丈丄丙世丁丂丑;
    private System.Action<bool> 丈丏丂丗丕丞丑上丑;
    private System.Action 三专丌一且丄且丅丘;
    private System.Action 专与丒丅丄丄丏万万;
    
    // Methods
    public void add_onDrag(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛不丈丄丙世丁丂丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛不丈丄丙世丁丂丑 != 1152921539442082872);
    
    }
    public void remove_onDrag(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛不丈丄丙世丁丂丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛不丈丄丙世丁丂丑 != 1152921539442219448);
    
    }
    public void add_onPress(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丏丂丗丕丞丑上丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丏丂丗丕丞丑上丑 != 1152921539442356032);
    
    }
    public void remove_onPress(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丏丂丗丕丞丑上丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丏丂丗丕丞丑上丑 != 1152921539442492608);
    
    }
    public void add_onClick(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三专丌一且丄且丅丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三专丌一且丄且丅丘 != 1152921539442629192);
    
    }
    public void remove_onClick(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三专丌一且丄且丅丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三专丌一且丄且丅丘 != 1152921539442765768);
    
    }
    public void add_onDoubleClick(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专与丒丅丄丄丏万万, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专与丒丅丄丄丏万万 != 1152921539442902352);
    
    }
    public void remove_onDoubleClick(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专与丒丅丄丄丏万万, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专与丒丅丄丄丏万万 != 1152921539443038928);
    
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(this.丈丏丂丗丕丞丑上丑 == null)
        {
                return;
        }
        
        万东丂丒且丅丛丑丕 = 万东丂丒且丅丛丑丕;
        this.丈丏丂丗丕丞丑上丑.Invoke(obj:  万东丂丒且丅丛丑丕);
    }
    private void OnClick()
    {
        if(this.三专丌一且丄且丅丘 == null)
        {
                return;
        }
        
        this.三专丌一且丄且丅丘.Invoke();
    }
    private void OnDoubleClick()
    {
        if(this.专与丒丅丄丄丏万万 == null)
        {
                return;
        }
        
        this.专与丒丅丄丄丏万万.Invoke();
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.丛不丈丄丙世丁丂丑 == null)
        {
                return;
        }
        
        this.丛不丈丄丙世丁丂丑.Invoke(obj:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    public UiEvents()
    {
    
    }

}
