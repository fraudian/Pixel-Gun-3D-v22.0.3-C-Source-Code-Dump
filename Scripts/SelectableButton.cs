using UnityEngine;
public class SelectableButton : MonoBehaviour
{
    // Fields
    public SelectableButtonController selectableButtonController;
    private System.Action 丗不世丙丏丅丄丂下;
    public bool selected;
    protected UnityEngine.GameObject selectedBG;
    protected UnityEngine.GameObject notSelectedBG;
    protected UnityEngine.GameObject disabledBG;
    public UnityEngine.EventSystems.EventTrigger.TriggerEvent customCallback;
    public bool canInteract;
    
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
        while(this.丗不世丙丏丅丄丂下 != 1152921538911175824);
    
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
        while(this.丗不世丙丏丅丄丂下 != 1152921538911312400);
    
    }
    public virtual void OnClick()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.canInteract == false)
        {
                return;
        }
        
        goto typeof(SelectableButton).__il2cppRuntimeField_1C8;
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
    
    }
    public virtual void Enable()
    {
        if(this.canInteract == false)
        {
                return;
        }
        
        this.enabled = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectedBG, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notSelectedBG, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disabledBG, 丏业丟一东丂东丘丛:  false);
    }
    public virtual void Disable()
    {
        this.enabled = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectedBG, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notSelectedBG, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disabledBG, 丏业丟一东丂东丘丛:  true);
    }
    public virtual void Toggle(bool 丑丒业丘丑东丕世丅)
    {
        if(this.canInteract == false)
        {
                return;
        }
        
        if(丑丒业丘丑东丕世丅 != false)
        {
            
        }
    
    }
    public virtual void Select(bool 丛丁三七丅且丝丏丙)
    {
        bool val_11;
        if(this.canInteract == false)
        {
                return;
        }
        
        val_11 = 丛丁三七丅且丝丏丙;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectedBG, 丏业丟一东丂东丘丛:  val_11);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notSelectedBG, 丏业丟一东丂东丘丛:  (~丛丁三七丅且丝丏丙) & 1);
        var val_2 = (this.selected == true) ? 1 : 0;
        val_2 = val_2 ^ 丛丁三七丅且丝丏丙;
        if(val_2 == false)
        {
                return;
        }
        
        this.selected = val_11;
        if(丛丁三七丅且丝丏丙 != false)
        {
                this.InvokeCustomCallback();
        }
        
        if(this.丗不世丙丏丅丄丂下 != null)
        {
                this.丗不世丙丏丅丄丂下.Invoke();
        }
        
        if(this.selectableButtonController == 0)
        {
                return;
        }
        
        this = ???;
        val_11 = ???;
        goto typeof(SelectableButtonController).__il2cppRuntimeField_168;
    }
    public virtual void Reset()
    {
        this.canInteract = true;
        this.selected = false;
        this.enabled = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectedBG, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notSelectedBG, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disabledBG, 丏业丟一东丂东丘丛:  false);
    }
    public void InvokeCustomCallback()
    {
        if(this.canInteract == false)
        {
                return;
        }
        
        if(this.customCallback == null)
        {
                return;
        }
        
        this.customCallback.Invoke(arg0:  0);
    }
    public void U_OnClick()
    {
        goto typeof(SelectableButton).__il2cppRuntimeField_168;
    }
    public SelectableButton()
    {
        this.canInteract = true;
    }

}
