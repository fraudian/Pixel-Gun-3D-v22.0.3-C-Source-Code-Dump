using UnityEngine;
public class UIForwardEvents : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject target;
    public bool onHover;
    public bool onPress;
    public bool onClick;
    public bool onDoubleClick;
    public bool onSelect;
    public bool onDrag;
    public bool onDrop;
    public bool onSubmit;
    public bool onScroll;
    
    // Methods
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        bool val_3 = 丟丆丕且丆丈丂丌丘;
        if(this.onHover == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        bool val_2 = val_3;
        val_3 = val_2;
        this.target.SendMessage(methodName:  "OnHover", value:  val_2, options:  1);
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        bool val_3 = 万东丂丒且丅丛丑丕;
        if(this.onPress == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        bool val_2 = val_3;
        val_3 = val_2;
        this.target.SendMessage(methodName:  "OnPress", value:  val_2, options:  1);
    }
    private void OnClick()
    {
        if(this.onClick == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this.target.SendMessage(methodName:  "OnClick", options:  1);
    }
    private void OnDoubleClick()
    {
        if(this.onDoubleClick == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this.target.SendMessage(methodName:  "OnDoubleClick", options:  1);
    }
    private void OnSelect(bool 丛丗七丅下丞丗且丐)
    {
        bool val_3 = 丛丗七丅下丞丗且丐;
        if(this.onSelect == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        bool val_2 = val_3;
        val_3 = val_2;
        this.target.SendMessage(methodName:  "OnSelect", value:  val_2, options:  1);
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.onDrag == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this = this.target;
        this.SendMessage(methodName:  "OnDrag", value:  丞且丅三三东不丄且, options:  1);
    }
    private void OnDrop(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(this.onDrop == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this.target.SendMessage(methodName:  "OnDrop", value:  丝三丁东丈丒世丅业, options:  1);
    }
    private void OnSubmit()
    {
        if(this.onSubmit == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this.target.SendMessage(methodName:  "OnSubmit", options:  1);
    }
    private void OnScroll(float 丞且丅三三东不丄且)
    {
        if(this.onScroll == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this = this.target;
        this.SendMessage(methodName:  "OnScroll", value:  丞且丅三三东不丄且, options:  1);
    }
    public UIForwardEvents()
    {
    
    }

}
