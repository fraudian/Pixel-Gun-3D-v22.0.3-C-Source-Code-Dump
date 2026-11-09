using UnityEngine;
public class UIEventTrigger : MonoBehaviour
{
    // Fields
    public static UIEventTrigger current;
    public System.Collections.Generic.List<EventDelegate> onHoverOver;
    public System.Collections.Generic.List<EventDelegate> onHoverOut;
    public System.Collections.Generic.List<EventDelegate> onPress;
    public System.Collections.Generic.List<EventDelegate> onRelease;
    public System.Collections.Generic.List<EventDelegate> onSelect;
    public System.Collections.Generic.List<EventDelegate> onDeselect;
    public System.Collections.Generic.List<EventDelegate> onClick;
    public System.Collections.Generic.List<EventDelegate> onDoubleClick;
    public System.Collections.Generic.List<EventDelegate> onDragStart;
    public System.Collections.Generic.List<EventDelegate> onDragEnd;
    public System.Collections.Generic.List<EventDelegate> onDragOver;
    public System.Collections.Generic.List<EventDelegate> onDragOut;
    public System.Collections.Generic.List<EventDelegate> onDrag;
    
    // Properties
    public bool 东世三丕三业七丑三 { get; }
    
    // Methods
    public bool get_isColliderEnabled()
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
    private void OnHover(bool isOver)
    {
        UIEventTrigger val_3;
        var val_4;
        val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        if(isOver != false)
        {
                val_4 = null;
            val_3 = this.onHoverOver;
        }
        else
        {
                val_4 = null;
            val_3 = this.onHoverOut;
        }
        
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnPress(bool pressed)
    {
        UIEventTrigger val_3;
        var val_4;
        val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        if(pressed != false)
        {
                val_4 = null;
            val_3 = this.onPress;
        }
        else
        {
                val_4 = null;
            val_3 = this.onRelease;
        }
        
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnSelect(bool selected)
    {
        UIEventTrigger val_3;
        var val_4;
        val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        if(selected != false)
        {
                val_4 = null;
            val_3 = this.onSelect;
        }
        else
        {
                val_4 = null;
            val_3 = this.onDeselect;
        }
        
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnClick()
    {
        UIEventTrigger val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        val_3 = this.onClick;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnDoubleClick()
    {
        UIEventTrigger val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        val_3 = this.onDoubleClick;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnDragStart()
    {
        UIEventTrigger val_2 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        UIEventTrigger.current = val_2;
        val_2 = this.onDragStart;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_2);
        UIEventTrigger.current = 0;
    }
    private void OnDragEnd()
    {
        UIEventTrigger val_2 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        UIEventTrigger.current = val_2;
        val_2 = this.onDragEnd;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_2);
        UIEventTrigger.current = 0;
    }
    private void OnDragOver(UnityEngine.GameObject go)
    {
        UIEventTrigger val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        val_3 = this.onDragOver;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnDragOut(UnityEngine.GameObject go)
    {
        UIEventTrigger val_3 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        UIEventTrigger.current = val_3;
        val_3 = this.onDragOut;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIEventTrigger.current = 0;
    }
    private void OnDrag(UnityEngine.Vector2 delta)
    {
        UIEventTrigger val_2 = this;
        if(UIEventTrigger.current != 0)
        {
                return;
        }
        
        UIEventTrigger.current = val_2;
        val_2 = this.onDrag;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_2);
        UIEventTrigger.current = 0;
    }
    public UIEventTrigger()
    {
        this.onHoverOver = new System.Collections.Generic.List<EventDelegate>();
        this.onHoverOut = new System.Collections.Generic.List<EventDelegate>();
        this.onPress = new System.Collections.Generic.List<EventDelegate>();
        this.onRelease = new System.Collections.Generic.List<EventDelegate>();
        this.onSelect = new System.Collections.Generic.List<EventDelegate>();
        this.onDeselect = new System.Collections.Generic.List<EventDelegate>();
        this.onClick = new System.Collections.Generic.List<EventDelegate>();
        this.onDoubleClick = new System.Collections.Generic.List<EventDelegate>();
        this.onDragStart = new System.Collections.Generic.List<EventDelegate>();
        this.onDragEnd = new System.Collections.Generic.List<EventDelegate>();
        this.onDragOver = new System.Collections.Generic.List<EventDelegate>();
        this.onDragOut = new System.Collections.Generic.List<EventDelegate>();
        this.onDrag = new System.Collections.Generic.List<EventDelegate>();
    }

}
