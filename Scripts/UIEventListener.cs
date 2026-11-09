using UnityEngine;
public class UIEventListener : MonoBehaviour
{
    // Fields
    public object parameter;
    public UIEventListener.丅三丝丙丝万上丝业 onSubmit;
    public UIEventListener.丅三丝丙丝万上丝业 onClick;
    public UIEventListener.丅三丝丙丝万上丝业 onDoubleClick;
    public UIEventListener.下丈业丑世丟丘丅下 onHover;
    public UIEventListener.下丈业丑世丟丘丅下 onPress;
    public UIEventListener.下丈业丑世丟丘丅下 onSelect;
    public UIEventListener.丗万七丒东与与专七 onScroll;
    public UIEventListener.丅三丝丙丝万上丝业 onDragStart;
    public UIEventListener.一丑下丄丝不丆三三 onDrag;
    public UIEventListener.一丑下丄丝不丆三三 onMovedThumb;
    public UIEventListener.丅三丝丙丝万上丝业 onDragOver;
    public UIEventListener.丅三丝丙丝万上丝业 onDragOut;
    public UIEventListener.丅三丝丙丝万上丝业 onDragEnd;
    public UIEventListener.丁丏丒不丛丝丞丒业 onDrop;
    public UIEventListener.丏丆丈丄丑丛丄业丅 onKey;
    public UIEventListener.下丈业丑世丟丘丅下 onTooltip;
    
    // Properties
    private bool 东世三丕三业七丑三 { get; }
    
    // Methods
    private bool 一丙业三世东丛丐上()
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        if(val_1 != 0)
        {
                if(val_1 != null)
        {
                return val_1.enabled;
        }
        
            return val_1.enabled;
        }
        
        UnityEngine.Collider2D val_3 = this.GetComponent<UnityEngine.Collider2D>();
        if(val_3 == 0)
        {
                return false;
        }
        
        if(val_3 != null)
        {
                return val_3.enabled;
        }
        
        return val_3.enabled;
    }
    private void OnSubmit()
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onSubmit == null)
        {
                return;
        }
        
        this.onSubmit.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnClick()
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onClick == null)
        {
                return;
        }
        
        this.onClick.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnDoubleClick()
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onDoubleClick == null)
        {
                return;
        }
        
        this.onDoubleClick.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnHover(bool isOver)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onHover == null)
        {
                return;
        }
        
        this.onHover.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  isOver);
    }
    private void OnPress(bool isPressed)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onPress == null)
        {
                return;
        }
        
        this.onPress.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  isPressed);
    }
    private void OnSelect(bool selected)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onSelect == null)
        {
                return;
        }
        
        this.onSelect.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  selected);
    }
    private void OnScroll(float delta)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onScroll == null)
        {
                return;
        }
        
        this.onScroll.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丞且丅三三东不丄且:  delta);
    }
    private void OnDragStart()
    {
        if(this.onDragStart == null)
        {
                return;
        }
        
        this.onDragStart.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnDrag(UnityEngine.Vector2 delta)
    {
        if(this.onDrag == null)
        {
                return;
        }
        
        this.onDrag.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = delta.x, y = delta.y});
    }
    private void OnMovedThumb(UnityEngine.Vector2 delta)
    {
        if(this.onMovedThumb == null)
        {
                return;
        }
        
        this.onMovedThumb.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = delta.x, y = delta.y});
    }
    private void OnDragOver()
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onDragOver == null)
        {
                return;
        }
        
        this.onDragOver.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnDragOut()
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onDragOut == null)
        {
                return;
        }
        
        this.onDragOut.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnDragEnd()
    {
        if(this.onDragEnd == null)
        {
                return;
        }
        
        this.onDragEnd.Invoke(丝三丁东丈丒世丅业:  this.gameObject);
    }
    private void OnDrop(UnityEngine.GameObject go)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onDrop == null)
        {
                return;
        }
        
        this.onDrop.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 万且万且丑丗且丌丆:  go);
    }
    private void OnKey(UnityEngine.KeyCode key)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onKey == null)
        {
                return;
        }
        
        this.onKey.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 下上丐丆丝丟丝丒不:  key);
    }
    private void OnTooltip(bool show)
    {
        if(this.一丙业三世东丛丐上() == false)
        {
                return;
        }
        
        if(this.onTooltip == null)
        {
                return;
        }
        
        this.onTooltip.Invoke(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  show);
    }
    public static UIEventListener Get(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UIEventListener val_1 = 丝三丁东丈丒世丅业.GetComponent<UIEventListener>();
        if(val_1 != 0)
        {
                return val_1;
        }
        
        if(丝三丁东丈丒世丅业 != null)
        {
                return 丝三丁东丈丒世丅业.AddComponent<UIEventListener>();
        }
        
        return 丝三丁东丈丒世丅业.AddComponent<UIEventListener>();
    }
    public UIEventListener()
    {
    
    }

}
