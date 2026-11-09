using UnityEngine;
public class UIToggle : UIWidgetContainer
{
    // Fields
    public static 丒丞丕丕七丁丗丟丛<UIToggle> list;
    public static UIToggle current;
    public int group;
    public UIWidget activeSprite;
    public UnityEngine.Animation activeAnimation;
    public UnityEngine.Animator animator;
    public UITweener tween;
    public bool startsActive;
    public bool instantTween;
    public bool optionCanBeNone;
    public System.Collections.Generic.List<EventDelegate> onChange;
    public UIToggle.丏且丕丄世丕不丕丙 validator;
    private UISprite checkSprite;
    private UnityEngine.Animation checkAnimation;
    private UnityEngine.GameObject eventReceiver;
    private string functionName;
    private bool startsChecked;
    private bool 丐不丝丁丙下七丗丐;
    private bool 不世丌丝且三上丏丌;
    
    // Properties
    public bool 丙业与丙丗丝不丈东 { get; set; }
    public bool 东世三丕三业七丑三 { get; }
    public bool 与专一业丏三丒万下 { get; set; }
    
    // Methods
    public bool get_value()
    {
        return (bool)(this.不世丌丝且三上丏丌 == false) ? this.startsActive : this.丐不丝丁丙下七丗丐;
    }
    public void set_value(bool 丙业与丙丗丝不丈东)
    {
        if(this.不世丌丝且三上丏丌 != false)
        {
                if((this.group != 0) && (丙业与丙丗丝不丈东 != true))
        {
                if(this.optionCanBeNone == false)
        {
                return;
        }
        
        }
        
            this.Set(丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
            return;
        }
        
        this.startsActive = 丙业与丙丗丝不丈东;
    }
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
    public bool get_isChecked()
    {
        return (bool)(this.不世丌丝且三上丏丌 == false) ? this.startsActive : this.丐不丝丁丙下七丗丐;
    }
    public void set_isChecked(bool 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public static UIToggle GetActiveToggle(int 不丝丄丒丌丐一一与)
    {
        var val_3;
        var val_4;
        UnityEngine.Object val_5;
        var val_6;
        val_3 = 0;
        goto label_1;
        label_14:
        val_4 = null;
        val_4 = null;
        val_5 = UIToggle.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        if((val_5 != 0) && (val_1.group == 不丝丄丒丌丐一一与))
        {
                if(val_1.丐不丝丁丙下七丗丐 == true)
        {
                return (UIToggle)val_5;
        }
        
        }
        
        val_3 = 1;
        label_1:
        val_6 = null;
        val_6 = null;
        if(val_3 < (UIToggle.list + 24))
        {
            goto label_14;
        }
        
        val_5 = 0;
        return (UIToggle)val_5;
    }
    private void OnEnable()
    {
        null = null;
        UIToggle.list.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
    }
    private void OnDisable()
    {
        null = null;
        bool val_1 = UIToggle.list.Remove(下丅丙一丂丗丅丝七:  this);
    }
    private void Start()
    {
        if(this.startsChecked != false)
        {
                this.startsChecked = false;
            this.startsActive = true;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                this.不世丌丝且三上丏丌 = true;
            this.丐不丝丁丙下七丗丐 = this.startsActive ^ 1;
            this.instantTween = true;
            this.Set(丏业丟一东丂东丘丛:  this.startsActive);
            this.instantTween = this.instantTween;
            return;
        }
        
        if(this.checkSprite != 0)
        {
                if(this.activeSprite == 0)
        {
                this.checkSprite = 0;
            this.activeSprite = this.checkSprite;
        }
        
        }
        
        if(this.checkAnimation != 0)
        {
                if(this.activeAnimation == 0)
        {
                this.checkAnimation = 0;
            this.activeAnimation = this.checkAnimation;
        }
        
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                if(this.activeSprite != 0)
        {
                var val_9 = (this.startsActive == true) ? 1f : 0f;
        }
        
        }
        
        if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this.onChange)) == false)
        {
                return;
        }
        
        this.eventReceiver = 0;
        this.functionName = 0;
    }
    private void OnClick()
    {
        var val_5;
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(UICamera.currentTouchID == 2)
        {
                return;
        }
        
        this.value = (((this.不世丌丝且三上丏丌 == false) ? this.startsActive : this.丐不丝丁丙下七丗丐) == 0) ? 1 : 0;
    }
    public void Set(bool 丏业丟一东丂东丘丛)
    {
        UIWidget val_51;
        bool val_52;
        UnityEngine.Object val_53;
        object val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        UnityEngine.Object val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        int val_67;
        val_52 = 丏业丟一东丂东丘丛;
        val_53 = this;
        if(this.validator != null)
        {
                丏业丟一东丂东丘丛 = val_52;
            if((this.validator.Invoke(丝丑丝丏丅一丗丝丝:  丏业丟一东丂东丘丛)) == false)
        {
                return;
        }
        
        }
        
        if(this.不世丌丝且三上丏丌 == false)
        {
            goto label_3;
        }
        
        var val_2 = (this.丐不丝丁丙下七丗丐 == true) ? 1 : 0;
        val_2 = val_2 ^ val_52;
        if(val_2 == false)
        {
                return;
        }
        
        if((this.group == 0) || (val_52 == false))
        {
            goto label_25;
        }
        
        val_54 = 1152921505091829760;
        val_55 = null;
        val_55 = null;
        if((UIToggle.list + 24) < 1)
        {
            goto label_25;
        }
        
        label_29:
        var val_51 = 0;
        label_24:
        val_56 = null;
        val_56 = null;
        bool val_4 = UnityEngine.Object.op_Inequality(x:  UIToggle.list.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0), y:  this);
        val_57 = null;
        val_57 = null;
        if((UIToggle.list + 24) != (UIToggle.list + 24))
        {
            goto label_23;
        }
        
        val_51 = val_51 + 1;
        if(val_51 < (UIToggle.list + 24))
        {
            goto label_24;
        }
        
        goto label_25;
        label_23:
        val_58 = null;
        val_58 = null;
        if((UIToggle.list + 24) > 0)
        {
            goto label_29;
        }
        
        label_25:
        this.丐不丝丁丙下七丗丐 = val_52;
        val_59 = 1152921504848912384;
        val_60 = 0;
        if(this.activeSprite == val_60)
        {
            goto label_38;
        }
        
        if(this.instantTween == true)
        {
            goto label_36;
        }
        
        val_60 = 0;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
            goto label_36;
        }
        
        TweenAlpha val_10 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this.activeSprite.gameObject, 与丈业丛丝丒丙一丏:  0.15f, 与专丌丅丙上丌一丄:  (this.丐不丝丁丙下七丗丐 == true) ? 1f : 0f);
        goto label_38;
        label_3:
        bool val_11 = val_52;
        this.丐不丝丁丙下七丗丐 = val_11;
        this.startsActive = val_11;
        val_51 = this.activeSprite;
        if(val_51 == 0)
        {
                return;
        }
        
        var val_13 = (val_52 != true) ? 1f : 0f;
        val_52 = ???;
        val_53 = ???;
        val_59 = ???;
        val_54 = ???;
        val_61 = ???;
        goto typeof(UIWidget).__il2cppRuntimeField_1A8;
        label_36:
        var val_14 = ((val_53 + 121) != 0) ? 1f : 0f;
        label_38:
        val_62 = 1152921505091829760;
        val_63 = null;
        val_63 = null;
        if(UIToggle.current == 0)
        {
                val_64 = null;
            val_64 = null;
            UIToggle.current = val_53;
            if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  val_53 + 72)) != false)
        {
                EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_53 + 72);
        }
        else
        {
                if((val_53 + 104) != 0)
        {
                if((System.String.IsNullOrEmpty(value:  val_53 + 112)) != true)
        {
                val_54 = val_53 + 121;
            val_53 + 104.SendMessage(methodName:  val_53 + 104 + 8, value:  val_53 + 121, options:  1);
        }
        
        }
        
        }
        
            val_65 = null;
            val_65 = null;
            UIToggle.current = UIToggle.current;
        }
        
        val_51 = mem[val_53 + 48];
        val_51 = val_53 + 48;
        if(val_51 == 0)
        {
            goto label_66;
        }
        
        ActiveAnimation val_21 = ActiveAnimation.Play(丐丐七专三且世三七:  val_53 + 48, 七不丐下丟专业万丅:  0, 世一丑丝丈一上三丕:  ((val_52 & 1) != 0) ? (-1) : 1, 专丝丂世上丌丞世三:  2, 上丈丅丌丅丒丗上丒:  0);
        goto label_67;
        label_66:
        val_51 = mem[val_53 + 40];
        val_51 = val_53 + 40;
        if(val_51 == 0)
        {
            goto label_70;
        }
        
        ActiveAnimation val_24 = ActiveAnimation.Play(丐丐七专三且世三七:  val_53 + 40, 七不丐下丟专业万丅:  0, 世一丑丝丈一上三丕:  ((val_52 & 1) != 0) ? (-1) : 1, 专丝丂世上丌丞世三:  2, 上丈丅丌丅丒丗上丒:  0);
        label_67:
        if(val_24 == 0)
        {
                return;
        }
        
        if((val_53 + 65) == 0)
        {
                if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  val_53)) == true)
        {
                return;
        }
        
        }
        
        val_24.Finish();
        return;
        label_70:
        val_51 = mem[val_53 + 56];
        val_51 = val_53 + 56;
        if(val_51 == 0)
        {
                return;
        }
        
        bool val_28 = 不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  val_53);
        val_51 = mem[val_53 + 56];
        val_51 = val_53 + 56;
        if(val_51 == 0)
        {
            goto label_85;
        }
        
        if((val_53 + 56 + 56) == 0)
        {
            goto label_103;
        }
        
        label_102:
        val_51 = val_51.GetComponentsInChildren<UITweener>();
        if(val_29.Length < 1)
        {
                return;
        }
        
        val_67 = val_29.Length & 4294967295;
        val_54 = 0;
        goto label_89;
        label_95:
        val_67 = val_29.Length;
        val_54 = 1;
        label_89:
        val_61 = mem[val_28 + 56];
        val_61 = val_28 + 56;
        if(val_61 == (val_53 + 56 + 56))
        {
                val_28.Play(且丒且丐丌东专三丁:  val_52 & 1);
            var val_34 = ((val_53 + 65) != 0) ? 1 : 0;
            val_34 = val_34 | val_28 ^ 1;
            if(val_34 != false)
        {
                val_28.tweenFactor = (val_52 != 1) ? 1f : 0f;
        }
        
        }
        
        if((val_67 - 1) != val_54)
        {
            goto label_95;
        }
        
        return;
        label_85:
        val_54 = mem[val_53 + 56 + 56];
        val_54 = val_53 + 56 + 56;
        if((val_53 + 56) == 0)
        {
            goto label_97;
        }
        
        val_51 = val_53 + 56;
        if(val_54 != 0)
        {
            goto label_102;
        }
        
        label_103:
        val_51.Play(且丒且丐丌东专三丁:  val_52 & 1);
        if((val_53 + 65) == 0)
        {
                if(val_28 ^ 1 == false)
        {
                return;
        }
        
        }
        
        val_53 = mem[val_53 + 56];
        val_53 = val_53 + 56;
        val_53.tweenFactor = (val_52 != 1) ? 1f : 0f;
        return;
        label_97:
        if(val_54 != 0)
        {
            goto label_102;
        }
        
        goto label_103;
    }
    public UIToggle()
    {
        this.onChange = new System.Collections.Generic.List<EventDelegate>();
        this.丐不丝丁丙下七丗丐 = true;
        this.functionName = "OnActivate";
        this = new UnityEngine.MonoBehaviour();
    }
    private static UIToggle()
    {
        UIToggle.list = new 丒丞丕丕七丁丗丟丛<UIToggle>();
    }

}
