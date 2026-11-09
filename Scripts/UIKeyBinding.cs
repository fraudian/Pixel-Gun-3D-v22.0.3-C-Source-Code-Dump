using UnityEngine;
public class UIKeyBinding : MonoBehaviour
{
    // Fields
    private static System.Collections.Generic.List<UIKeyBinding> 丟丂与东业专三丕丏;
    public UnityEngine.KeyCode keyCode;
    public UIKeyBinding.丗丏业丁丞专丌丅丘 modifier;
    public UIKeyBinding.丞丐丗丞丑丁丅丘七 action;
    private bool 丌丒万业三且丟丁丟;
    private bool 丝丂丌专丄下不丐专;
    private bool 一丗丐丙下上七上丏;
    
    // Methods
    public static bool IsBound(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        int val_1 = UIKeyBinding.丟丂与东业专三丕丏.Count;
        if(val_1 >= 1)
        {
                val_5 = 0;
            do
        {
            val_6 = null;
            val_6 = null;
            if(UIKeyBinding.丟丂与东业专三丕丏.Item[0] != 0)
        {
                if(val_2.keyCode == 下上丐丆丝丟丝丒不)
        {
            goto label_12;
        }
        
        }
        
            val_5 = val_5 + 1;
        }
        while(val_5 < val_1);
        
        }
        
        val_7 = 0;
        return (bool)val_7;
        label_12:
        val_7 = 1;
        return (bool)val_7;
    }
    protected virtual void OnEnable()
    {
        null = null;
        UIKeyBinding.丟丂与东业专三丕丏.Add(item:  this);
    }
    protected virtual void OnDisable()
    {
        null = null;
        bool val_1 = UIKeyBinding.丟丂与东业专三丕丏.Remove(item:  this);
    }
    protected virtual void Start()
    {
        UIInput val_1 = this.GetComponent<UIInput>();
        this.丝丂丌专丄下不丐专 = UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
        if(val_1 == 0)
        {
                return;
        }
        
        EventDelegate val_6 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_1.onSubmit, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(UIKeyBinding).__il2cppRuntimeField_1A0));
    }
    protected virtual void OnSubmit()
    {
        if(UICamera.currentKey != this.keyCode)
        {
                return;
        }
        
        if((this & 1) == 0)
        {
                return;
        }
        
        this.丌丒万业三且丟丁丟 = true;
    }
    protected virtual bool 丟丟丘丏专丘且七业()
    {
        丘丒三丐丌丑丑丘世 val_12;
        var val_20;
        val_12 = this;
        if(this.modifier <= 4)
        {
                var val_13 = 106029828;
            val_13 = (106029828 + (this.modifier) << 2) + val_13;
        }
        else
        {
                val_20 = 0;
            return (bool)val_20 & 1;
        }
    
    }
    protected virtual void Update()
    {
        var val_10;
        UnityEngine.KeyCode val_11;
        var val_12;
        丞丐丗丞丑丁丅丘七 val_13;
        if(UICamera.inputHasFocus == true)
        {
                return;
        }
        
        if(this.keyCode == 0)
        {
                return;
        }
        
        if((this & 1) == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  this.keyCode);
        val_12 = 0;
        bool val_3 = UICamera.GetKeyUp.Invoke(下上丐丆丝丟丝丒不:  this.keyCode);
        if(val_11 != false)
        {
                this.一丗丐丙下上七上丏 = true;
        }
        
        val_13 = this.action;
        if((val_13 | 2) == 2)
        {
                if(val_11 != false)
        {
                val_11 = this.keyCode;
            UICamera.currentKey = val_11;
        }
        
            var val_5 = (this.一丗丐丙下上七上丏 == true) ? 1 : 0;
            val_5 = val_3 & val_5;
            if(val_5 == true)
        {
                val_11 = this.keyCode;
            UICamera.currentKey = val_11;
        }
        
            val_13 = this.action;
        }
        
        if(val_13 != 1)
        {
            goto label_18;
        }
        
        if(val_3 == true)
        {
            goto label_19;
        }
        
        return;
        label_18:
        if((val_13 != 2) || (val_3 ^ 1 == true))
        {
            goto label_33;
        }
        
        label_19:
        if(this.丝丂丌专丄下不丐专 == false)
        {
            goto label_23;
        }
        
        if(this.丌丒万业三且丟丁丟 != true)
        {
                if((UICamera.inputHasFocus != true) && (this.一丗丐丙下上七上丏 != false))
        {
                val_11 = this.gameObject;
            UICamera.selectedObject = val_11;
        }
        
        }
        
        this.丌丒万业三且丟丁丟 = false;
        if(val_3 == true)
        {
            goto label_31;
        }
        
        return;
        label_23:
        if(this.一丗丐丙下上七上丏 != false)
        {
                val_11 = this.gameObject;
            UICamera.hoveredObject = val_11;
        }
        
        label_33:
        if(val_3 == false)
        {
                return;
        }
        
        label_31:
        this.一丗丐丙下上七上丏 = false;
    }
    protected virtual void 丘丐丂丕丘丝丛一上(bool 万东丂丒且丅丛丑丕)
    {
        UICamera.Notify(丝三丁东丈丒世丅业:  this.gameObject, 且丁三丙丄一世不七:  "OnPress", 万且万且丑丗且丌丆:  万东丂丒且丅丛丑丕);
    }
    protected virtual void 丟丟业丑东丛且三万()
    {
        UICamera.Notify(丝三丁东丈丒世丅业:  this.gameObject, 且丁三丙丄一世不七:  "OnClick", 万且万且丑丗且丌丆:  0);
    }
    public UIKeyBinding()
    {
    
    }
    private static UIKeyBinding()
    {
        UIKeyBinding.丟丂与东业专三丕丏 = new System.Collections.Generic.List<UIKeyBinding>();
    }

}
