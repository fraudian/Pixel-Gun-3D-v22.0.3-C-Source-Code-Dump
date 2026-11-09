using UnityEngine;
public class SelectableButtonController : MonoBehaviour
{
    // Fields
    private System.Action 丗不世丙丏丅丄丂下;
    internal System.Action 丕上丆七丘丁丗七丅;
    public WidgetLayout widgetLayout;
    public UIGrid grid;
    public GridLayout gridLayout;
    public ConstrainedLayout constrainedLayout;
    public SelectableButton selectedButton;
    public System.Collections.Generic.List<SelectableButton> allButtons;
    
    // Methods
    public void add_onSelect(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗不世丙丏丅丄丂下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921538913552648);
    
    }
    public void remove_onSelect(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗不世丙丏丅丄丂下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921538913689224);
    
    }
    internal void 下丁万万丅丆东不不()
    {
        if(this.allButtons.Count == 0)
        {
                return;
        }
        
        SelectableButton val_2 = System.Linq.Enumerable.First<SelectableButton>(source:  this.allButtons);
        this = ???;
        goto typeof(SelectableButtonController).__il2cppRuntimeField_168;
    }
    internal void 丞与万丕丈丒丌丆世()
    {
        if(this.selectedButton == 0)
        {
                return;
        }
        
        this.selectedButton = 0;
    }
    public virtual bool SelectButton(SelectableButton 丕丐不丑三上万丝东)
    {
        SelectableButton val_5;
        var val_6;
        if(丕丐不丑三上万丝东 == 0)
        {
            goto label_3;
        }
        
        val_5 = this.selectedButton;
        if((丕丐不丑三上万丝东 == val_5) || (丕丐不丑三上万丝东.enabled == false))
        {
            goto label_8;
        }
        
        label_3:
        this.丞与万丕丈丒丌丆世();
        if(丕丐不丑三上万丝东 != 0)
        {
            goto label_11;
        }
        
        label_8:
        val_6 = 0;
        return (bool)val_6;
        label_11:
        this.selectedButton = 丕丐不丑三上万丝东;
        if(this.丕上丆七丘丁丗七丅 != null)
        {
                this.丕上丆七丘丁丗七丅.Invoke();
        }
        
        if(this.丗不世丙丏丅丄丂下 != null)
        {
                this.丗不世丙丏丅丄丂下.Invoke();
        }
        
        val_6 = 1;
        return (bool)val_6;
    }
    public virtual void DisableButton(SelectableButton 不丆万丛丗丑丁万丛)
    {
        if(不丆万丛丗丑丁万丛 == 0)
        {
                return;
        }
        
        if(不丆万丛丗丑丁万丛 == null)
        {
            
        }
    
    }
    public virtual void EnableButton(SelectableButton 丕丅丟丐三丄丐丒丌)
    {
        if(丕丅丟丐三丄丐丒丌 == 0)
        {
                return;
        }
        
        if(丕丅丟丐三丄丐丒丌 == null)
        {
            
        }
    
    }
    public virtual void ClearAllButtons()
    {
        goto label_1;
        label_7:
        UnityEngine.Object.Destroy(obj:  this.allButtons.Item[0].gameObject);
        0 = 1;
        label_1:
        if(0 < this.allButtons.Count)
        {
            goto label_7;
        }
        
        if(this.widgetLayout != 0)
        {
                this.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        if(this.constrainedLayout != null)
        {
                this.constrainedLayout.世业丒万丘丆专丘丐();
        }
        
        if(this.gridLayout != null)
        {
                this.gridLayout.Reposition();
        }
        
        this.allButtons.Clear();
    }
    public virtual void ClearLayout()
    {
        if(this.widgetLayout != 0)
        {
                this.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        if(this.constrainedLayout != null)
        {
                this.constrainedLayout.世业丒万丘丆专丘丐();
        }
        
        if(this.gridLayout != null)
        {
                this.gridLayout.Reposition();
        }
        
        this.allButtons.Clear();
    }
    public virtual void AddNewButton(SelectableButton 丟丂丄丕下业丗丛丂)
    {
        UIGrid val_3;
        丟丂丄丕下业丗丛丂.selectableButtonController = this;
        this.allButtons.Add(item:  丟丂丄丕下业丗丛丂);
        if(this.widgetLayout != 0)
        {
                this.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  丟丂丄丕下业丗丛丂);
        }
        
        val_3 = this.grid;
        if(val_3 != 0)
        {
                val_3 = this.grid;
            val_3.repositionNow = true;
        }
        
        if(this.constrainedLayout != null)
        {
                this.constrainedLayout.业丏丗丐丂业东丂丗(不丗上三丛丒上东丑:  丟丂丄丕下业丗丛丂);
        }
        
        if(this.gridLayout == null)
        {
                return;
        }
        
        this.gridLayout.Reposition();
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
    
    }
    public SelectableButtonController()
    {
        this.allButtons = new System.Collections.Generic.List<SelectableButton>();
    }

}
