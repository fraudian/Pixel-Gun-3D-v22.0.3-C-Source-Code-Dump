using UnityEngine;
public class RadioButton : MonoBehaviour
{
    // Fields
    private System.Action<RadioButton, bool> 丕丌丐丑丟万下丛丘;
    internal static System.Collections.Generic.List<RadioButton> 一丆丆与丝丙七世丏;
    public int group;
    public bool isDefault;
    public bool updateTable;
    private UITable 不且上一上丐三万丛;
    private System.Nullable<bool> 丈丙丝下且丑七丌专;
    private bool __selected;
    
    // Properties
    public bool 丏业丟一东丂东丘丛 { get; set; }
    
    // Methods
    public void add_OnSelectedStateChanged(System.Action<RadioButton, bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕丌丐丑丟万下丛丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丌丐丑丟万下丛丘 != 1152921536034174888);
    
    }
    public void remove_OnSelectedStateChanged(System.Action<RadioButton, bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕丌丐丑丟万下丛丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丌丐丑丟万下丛丘 != 1152921536034311464);
    
    }
    public bool get_state()
    {
        System.Nullable<System.Boolean> val_5 = this.丈丙丝下且丑七丌专;
        if((val_5 & 1) == 0)
        {
                return false;
        }
        
        val_5 = ???;
        return false;
    }
    public void set_state(bool 丙业与丙丗丝不丈东)
    {
        bool val_6 = 丙业与丙丗丝不丈东;
        if((this.丈丙丝下且丑七丌专 & 1) != 0)
        {
                if(this.丈丙丝下且丑七丌专.HasValue.GetValueOrDefault() ^ val_6 != true)
        {
                if((1362922748 & 1) != 0)
        {
                return;
        }
        
        }
        
        }
        
        this.__selected = val_6;
        this.丈丙丝下且丑七丌专 = 0;
        this.丄丑七丘丁且丞丙专(丛丅丘一丏丙且丌上:  this.丈丙丝下且丑七丌专 & 1);
        val_6 = this.丕丌丐丑丟万下丛丘;
        if(val_6 == null)
        {
                return;
        }
        
        val_6.Invoke(arg1:  this, arg2:  this.丈丙丝下且丑七丌专 & 1);
    }
    protected void 丄丑七丘丁且丞丙专(bool 丛丅丘一丏丙且丌上)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        UnityEngine.Object val_23;
        var val_24;
        System.Collections.Generic.List<RadioButton> val_25;
        UITable val_26;
        var val_28;
        var val_29;
        val_19 = this;
        if(丛丅丘一丏丙且丌上 == false)
        {
            goto label_1;
        }
        
        val_20 = 1152921505122340864;
        val_21 = 0;
        goto label_2;
        label_14:
        val_22 = null;
        val_22 = null;
        RadioButton val_1 = RadioButton.一丆丆与丝丙七世丏.Item[0];
        if(val_1.group == this.group)
        {
                val_23 = this.gameObject;
            if(val_1.gameObject != val_23)
        {
                val_1.state = false;
        }
        
        }
        
        val_21 = 1;
        label_2:
        val_24 = null;
        val_24 = null;
        val_25 = RadioButton.一丆丆与丝丙七世丏;
        if(val_21 < val_25.Count)
        {
            goto label_14;
        }
        
        if(this.updateTable == false)
        {
                return;
        }
        
        if(this.不且上一上丐三万丛 == 0)
        {
                return;
        }
        
        val_26 = this.不且上一上丐三万丛;
        if(val_26 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_1:
        label_20:
        val_28 = ???;
        val_29 = ???;
        val_23 = ???;
        val_20 = ???;
        goto typeof(RadioButton).__il2cppRuntimeField_168;
    }
    protected virtual void 丒三七丌丂丛丈七丗()
    {
    
    }
    protected virtual void Start()
    {
        if(this.updateTable != false)
        {
                this.不且上一上丐三万丛 = this.GetComponentInParent<UITable>();
        }
        
        if(this.isDefault == false)
        {
                return;
        }
        
        if((this.丈丙丝下且丑七丌专 & 1) != 0)
        {
                return;
        }
        
        this.state = true;
    }
    protected virtual void OnEnable()
    {
        null = null;
        RadioButton.一丆丆与丝丙七世丏.Add(item:  this);
    }
    protected virtual void OnDisable()
    {
        null = null;
        bool val_1 = RadioButton.一丆丆与丝丙七世丏.Remove(item:  this);
    }
    protected virtual void OnClick()
    {
        this.state = true;
    }
    internal static RadioButton 丂丏且东上丌丐且七(int 丌业不丕丐下业丒丘)
    {
        var val_7;
        var val_8;
        var val_9;
        System.Collections.Generic.List<RadioButton> val_10;
        var val_11;
        var val_12;
        var val_13;
        val_7 = 0;
        goto label_1;
        label_15:
        val_8 = null;
        val_8 = null;
        RadioButton val_1 = RadioButton.一丆丆与丝丙七世丏.Item[0];
        if(val_1.group != 丌业不丕丐下业丒丘)
        {
            goto label_6;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = RadioButton.一丆丆与丝丙七世丏.Item[0];
        if(val_10.state == true)
        {
            goto label_11;
        }
        
        label_6:
        val_7 = 1;
        label_1:
        val_11 = null;
        val_11 = null;
        val_10 = RadioButton.一丆丆与丝丙七世丏;
        if(val_7 < val_10.Count)
        {
            goto label_15;
        }
        
        UnityEngine.Debug.Log(message:  "No active buttons in group " + 丌业不丕丐下业丒丘);
        val_12 = 0;
        return (RadioButton)RadioButton.一丆丆与丝丙七世丏.Item[0];
        label_11:
        val_13 = null;
        val_13 = null;
        return (RadioButton)RadioButton.一丆丆与丝丙七世丏.Item[0];
    }
    protected void 世丗上丒业丛丝上丈()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 0;
        goto label_2;
        label_10:
        val_4 = null;
        val_4 = null;
        RadioButton val_1 = RadioButton.一丆丆与丝丙七世丏.Item[0];
        val_3 = 1;
        label_2:
        val_5 = null;
        val_5 = null;
        if(val_3 < RadioButton.一丆丆与丝丙七世丏.Count)
        {
            goto label_10;
        }
    
    }
    public RadioButton()
    {
    
    }
    private static RadioButton()
    {
        RadioButton.一丆丆与丝丙七世丏 = new System.Collections.Generic.List<RadioButton>();
    }

}
