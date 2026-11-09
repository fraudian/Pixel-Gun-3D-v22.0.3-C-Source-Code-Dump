using UnityEngine;
public class CategoryButtonsController : MonoBehaviour
{
    // Fields
    public bool isConnectScene;
    public BtnCategory[] buttons;
    public float scaleMultypler;
    public float animTime;
    public UITable buttonsTable;
    public UITable buttonsTableSecond;
    public string currentBtnName;
    internal System.Action 丛万丈万丘丝丂业与;
    private System.Collections.Generic.List<System.Action<BtnCategory>> 丑丁业业丂丅专世上;
    
    // Properties
    public System.Collections.Generic.List<System.Action<BtnCategory>> 丗丟七与丝七丌丕丈 { get; }
    
    // Methods
    public System.Collections.Generic.List<System.Action<BtnCategory>> get_actions()
    {
        System.Collections.Generic.List<System.Action<BtnCategory>> val_2 = this.丑丁业业丂丅专世上;
        if(val_2 != null)
        {
                return val_2;
        }
        
        System.Collections.Generic.List<System.Action<BtnCategory>> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<System.Action<BtnCategory>>();
        this.丑丁业业丂丅专世上 = val_2;
        return val_2;
    }
    private void Start()
    {
        var val_2;
        if(this.isConnectScene != true)
        {
                bool val_1 = UnityEngine.Object.op_Inequality(x:  this.buttonsTableSecond, y:  0);
        }
        
        val_2 = 0;
        goto label_7;
        label_11:
        BtnCategory val_2 = this.buttons[0];
        val_2 = 1;
        this.buttons[0x0][0].animTime = this.animTime;
        label_7:
        if(val_2 < this.buttons.Length)
        {
            goto label_11;
        }
    
    }
    internal void 与丐且业丛丌不丄丑(string 丟专丛丏丝万丘丄丗)
    {
        goto label_0;
        label_5:
        BtnCategory val_5 = this.buttons[0];
        if(val_5 != null)
        {
                this.buttons[0x0][0].isDefault = System.String.op_Equality(a:  this.buttons[0x0][0].btnName, b:  丟专丛丏丝万丘丄丗);
        }
        else
        {
                mem[105] = System.String.op_Equality(a:  15996064, b:  丟专丛丏丝万丘丄丗);
        }
        
        val_5.一丟专一下丗丂丒丁();
        0 = 1;
        label_0:
        if(0 < this.buttons.Length)
        {
            goto label_5;
        }
    
    }
    public void BtnClicked(string 丟专丛丏丝万丘丄丗, bool 丌丝丌丁下丐丞丆一 = False)
    {
        var val_15;
        var val_16;
        .丟专丛丏丝万丘丄丗 = 丟专丛丏丝万丘丄丗;
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<BtnCategory>(丌丛丏业世丄丞三丌:  this.buttons, 七丐丅专且专七三丆:  new System.Action<BtnCategory>(object:  new CategoryButtonsController.世东丒与丞七不不东(), method:  System.Void CategoryButtonsController.世东丒与丞七不不东::丟丞丝丙丙丂下业不(BtnCategory 丌丗丏丏丛东专丁且)));
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_15 = 0;
        val_16 = 0;
        goto label_6;
        label_32:
        BtnCategory val_15 = this.buttons[0];
        bool val_5 = System.String.op_Equality(a:  this.buttons[0x0][0].btnName, b:  (CategoryButtonsController.世东丒与丞七不不东)[1152921525590130416].丟专丛丏丝万丘丄丗);
        if(this.buttons[0] == null)
        {
            goto label_12;
        }
        
        if(val_5 == false)
        {
            goto label_13;
        }
        
        label_23:
        this.buttons[0x0][0].isPressed = true;
        BtnCategory val_17 = this.buttons[0];
        this.buttons[0x0][0].wasPressed = true;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.buttons[0].SetButtonPressed(丆东丈丕上丏三丈上:  true, 丌丝丌丁下丐丞丆一:  丌丝丌丁下丐丞丆一));
        this.currentBtnName = (CategoryButtonsController.世东丒与丞七不不东)[1152921525590130416].丟专丛丏丝万丘丄丗;
        if(this.丛万丈万丘丝丂业与 == null)
        {
            goto label_22;
        }
        
        (this.丛万丈万丘丝丂业与 == 0) ? (val_15) : this.丛万丈万丘丝丂业与.Invoke();
        val_15 = this.丛万丈万丘丝丂业与;
        goto label_22;
        label_12:
        if(val_5 == true)
        {
            goto label_23;
        }
        
        label_13:
        this.buttons[0x0][0].isPressed = false;
        if(丌丝丌丁下丐丞丆一 != false)
        {
                BtnCategory val_19 = this.buttons[0];
            this.buttons[0x0][0].wasPressed = false;
        }
        
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.buttons[0].SetButtonPressed(丆东丈丕上丏三丈上:  false, 丌丝丌丁下丐丞丆一:  丌丝丌丁下丐丞丆一));
        label_22:
        val_16 = 1;
        label_6:
        if(val_16 < this.buttons.Length)
        {
            goto label_32;
        }
        
        UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.万上丑丁三上不业丝());
    }
    private System.Collections.IEnumerator 万上丑丁三上不业丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CategoryButtonsController.世不上丅丈丗丅业丟();
    }
    public CategoryButtonsController()
    {
        this.scaleMultypler = 1.1f;
        this.animTime = 1.836682E-41f;
    }
    private bool 世上东丕且丒丙万丑(BtnCategory 东丁丈且丌丄七专三)
    {
        if(东丁丈且丌丄七专三 != null)
        {
                return System.String.op_Equality(a:  东丁丈且丌丄七专三.btnName, b:  this.currentBtnName);
        }
        
        return System.String.op_Equality(a:  东丁丈且丌丄七专三.btnName, b:  this.currentBtnName);
    }

}
