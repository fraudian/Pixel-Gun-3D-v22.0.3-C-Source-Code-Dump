using UnityEngine;
public class UIPlayTween : MonoBehaviour
{
    // Fields
    public static UIPlayTween current;
    public UnityEngine.GameObject tweenTarget;
    public int tweenGroup;
    public AnimationOrTween.丏三业丕丈丄丂丑东 trigger;
    public AnimationOrTween.丟世丆丕丌且七下丂 playDirection;
    public bool resetOnPlay;
    public bool resetIfDisabled;
    public AnimationOrTween.三世业世丟丈丕世且 ifDisabledOnPlay;
    public AnimationOrTween.且丁丝丄三世且丐一 disableWhenFinished;
    public bool includeChildren;
    public System.Collections.Generic.List<EventDelegate> onFinished;
    private UnityEngine.GameObject eventReceiver;
    private string callWhenFinished;
    private UITweener[] 丑七丘丘丁丏世东丂;
    private bool 不世丌丝且三上丏丌;
    private int 万丝业下下丏丆丏东;
    private bool 三丂与丘丁七丘东丞;
    private UIToggle 丁丗且丂与丕丙业丌;
    
    // Methods
    private void Awake()
    {
        if(this.eventReceiver != 0)
        {
                if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this.onFinished)) != false)
        {
                this.eventReceiver = 0;
            mem[1152921531106288480] = 0;
        }
        
        }
        
        this.丁丗且丂与丕丙业丌 = this.GetComponent<UIToggle>();
    }
    private void Start()
    {
        this.不世丌丝且三上丏丌 = true;
        if(this.tweenTarget != 0)
        {
                return;
        }
        
        this.tweenTarget = this.gameObject;
    }
    private void OnEnable()
    {
        var val_14;
        丞上且下专丞东专世 val_15;
        AnimationOrTween.丏三业丕丈丄丂丑东 val_16;
        UnityEngine.Object val_17;
        var val_18;
        if(this.不世丌丝且三上丏丌 != false)
        {
                this.OnHover(丟丆丕且丆丈丂丌丘:  UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject));
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = UICamera.currentTouch;
        if(val_15 == null)
        {
            goto label_14;
        }
        
        val_16 = this.trigger;
        if(val_16 != 5)
        {
                if(val_16 != 2)
        {
            goto label_8;
        }
        
        }
        
        val_15 = UICamera.currentTouch;
        if(val_15 == null)
        {
            goto label_11;
        }
        
        val_17 = this.gameObject;
        val_16 = this.trigger;
        this.三丂与丘丁七丘东丞 = UnityEngine.Object.op_Equality(x:  UICamera.currentTouch.万东丂丒且丅丛丑丕, y:  val_17);
        label_8:
        if((val_16 | 2) == 3)
        {
                val_18 = null;
            val_18 = null;
            val_17 = this.gameObject;
            this.三丂与丘丁七丘东丞 = UnityEngine.Object.op_Equality(x:  UICamera.currentTouch.上丞丕专丈业丁世专, y:  val_17);
        }
        
        label_14:
        if(this.丁丗且丂与丕丙业丌 == 0)
        {
                return;
        }
        
        EventDelegate val_13 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.丁丗且丂与丕丙业丌.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayTween::不下与丗世与丙万一()));
        return;
        label_11:
    }
    private void OnDisable()
    {
        if(this.丁丗且丂与丕丙业丌 == 0)
        {
                return;
        }
        
        bool val_3 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  this.丁丗且丂与丕丙业丌.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayTween::不下与丗世与丙万一()));
    }
    private void 专丌丟下上东丞不丙()
    {
        if(this.trigger != 1)
        {
                return;
        }
        
        this.OnHover(丟丆丕且丆丈丂丌丘:  true);
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        var val_2 = (this.trigger == 3) ? 1 : 0;
        if(this.trigger != 1)
        {
                val_2 = val_2 & 丟丆丕且丆丈丂丌丘;
            if(val_2 != true)
        {
                if(this.trigger != 4)
        {
                return;
        }
        
            if(丟丆丕且丆丈丂丌丘 == true)
        {
                return;
        }
        
        }
        
        }
        
        bool val_3 = (this.trigger == 1) ? 1 : 0;
        val_3 = val_3 & 丟丆丕且丆丈丂丌丘;
        this.三丂与丘丁七丘东丞 = val_3;
        this.Play(且丒且丐丌东专三丁:  丟丆丕且丆丈丂丌丘);
    }
    private void 世丆丕丌丒下丆万上()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.三丂与丘丁七丘东丞 == false)
        {
                return;
        }
        
        this.三丂与丘丁七丘东丞 = false;
        this.Play(且丒且丐丌东专三丁:  false);
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        var val_2 = (this.trigger == 5) ? 1 : 0;
        if(this.trigger != 2)
        {
                val_2 = val_2 & 丆丟专丑丁丒丁上丙;
            if(val_2 != true)
        {
                if(this.trigger != 6)
        {
                return;
        }
        
            if(丆丟专丑丁丒丁上丙 == true)
        {
                return;
        }
        
        }
        
        }
        
        bool val_3 = (this.trigger == 2) ? 1 : 0;
        val_3 = val_3 & 丆丟专丑丁丒丁上丙;
        this.三丂与丘丁七丘东丞 = val_3;
        this.Play(且丒且丐丌东专三丁:  丆丟专丑丁丒丁上丙);
    }
    private void OnClick()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 0)
        {
                return;
        }
        
        this.Play(且丒且丐丌东专三丁:  true);
    }
    private void OnDoubleClick()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 10)
        {
                return;
        }
        
        this.Play(且丒且丐丌东专三丁:  true);
    }
    private void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        var val_2 = (this.trigger == 12) ? 1 : 0;
        if(this.trigger != 11)
        {
                val_2 = val_2 & 丞丈丌且东丆丅丗万;
            if(val_2 != true)
        {
                if(this.trigger != 13)
        {
                return;
        }
        
            if(丞丈丌且东丆丅丗万 == true)
        {
                return;
        }
        
        }
        
        }
        
        bool val_3 = (this.trigger == 11) ? 1 : 0;
        val_3 = val_3 & 丞丈丌且东丆丅丗万;
        this.三丂与丘丁七丘东丞 = val_3;
        this.Play(且丒且丐丌东专三丁:  丞丈丌且东丆丅丗万);
    }
    private void 不下与丗世与丙万一()
    {
        var val_7;
        AnimationOrTween.丏三业丕丈丄丂丑东 val_8;
        var val_9;
        var val_10;
        var val_11;
        if(this.enabled == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(UIToggle.current == 0)
        {
                return;
        }
        
        val_8 = this.trigger;
        if(val_8 == 7)
        {
            goto label_12;
        }
        
        if(val_8 != 8)
        {
            goto label_8;
        }
        
        val_9 = null;
        val_9 = null;
        if(UIToggle.current.value == true)
        {
            goto label_12;
        }
        
        val_8 = this.trigger;
        label_8:
        if(val_8 != 9)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(UIToggle.current.value == true)
        {
                return;
        }
        
        label_12:
        val_11 = null;
        val_11 = null;
        this.Play(且丒且丐丌东专三丁:  UIToggle.current.value);
    }
    private void Update()
    {
        UITweener[] val_4;
        var val_5;
        var val_6;
        if(this.disableWhenFinished == 0)
        {
                return;
        }
        
        val_4 = this.丑七丘丘丁丏世东丂;
        if(val_4 == null)
        {
                return;
        }
        
        if(this.丑七丘丘丁丏世东丂.Length < 1)
        {
            goto label_3;
        }
        
        val_5 = 0;
        val_6 = 1;
        goto label_4;
        label_10:
        val_4 = this.丑七丘丘丁丏世东丂;
        label_4:
        UITweener val_4 = val_4[val_5];
        if(this.丑七丘丘丁丏世东丂[0x0][0].tweenGroup == this.tweenGroup)
        {
                if(val_4.enabled == true)
        {
                return;
        }
        
            val_6 = val_6 & ((val_4.direction == this.disableWhenFinished) ? 1 : 0);
        }
        
        val_5 = val_5 + 1;
        if(val_5 < (long)this.丑七丘丘丁丏世东丂.Length)
        {
            goto label_10;
        }
        
        if((val_6 & 1) == 0)
        {
            goto label_11;
        }
        
        label_3:
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.tweenTarget, 丏业丟一东丂东丘丛:  false);
        label_11:
        this.丑七丘丘丁丏世东丂 = 0;
    }
    public void Play(bool 且丒且丐丌东专三丁)
    {
        UITweener val_17;
        UnityEngine.GameObject val_18;
        UITweener[] val_20;
        val_17 = 且丒且丐丌东专三丁;
        this.万丝业下下丏丆丏东 = 0;
        if(this.tweenTarget == 0)
        {
                val_18 = this.gameObject;
        }
        else
        {
                val_18 = this.tweenTarget;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_18)) != true)
        {
                if(this.ifDisabledOnPlay != 1)
        {
                return;
        }
        
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  true);
        }
        
        if(val_18 == null)
        {
            goto label_11;
        }
        
        if(this.includeChildren == false)
        {
            goto label_12;
        }
        
        label_14:
        T[] val_4 = val_18.GetComponentsInChildren<UITweener>();
        goto label_13;
        label_11:
        if(this.includeChildren == true)
        {
            goto label_14;
        }
        
        label_12:
        label_13:
        this.丑七丘丘丁丏世东丂 = val_18.GetComponents<UITweener>();
        if(val_5.Length == 0)
        {
            goto label_16;
        }
        
        val_20 = this.丑七丘丘丁丏世东丂;
        if(this.丑七丘丘丁丏世东丂.Length < 1)
        {
                return;
        }
        
        var val_18 = 0;
        bool val_7 = ((this.playDirection == 1) ? 1 : 0) ^ val_17;
        goto label_42;
        label_36:
        if(this.resetIfDisabled == false)
        {
            goto label_22;
        }
        
        if(val_17.enabled == false)
        {
            goto label_21;
        }
        
        goto label_22;
        label_42:
        val_17 = this.丑七丘丘丁丏世东丂[val_18];
        if(this.丑七丘丘丁丏世东丂[0x0][0].tweenGroup != this.tweenGroup)
        {
            goto label_39;
        }
        
        if((0 & 1) != 0)
        {
            
        }
        else
        {
                if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_18)) != false)
        {
            
        }
        else
        {
                不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        int val_17 = this.万丝业下下丏丆丏东;
        val_17 = val_17 + 1;
        this.万丝业下下丏丆丏东 = val_17;
        if(this.playDirection == 0)
        {
            goto label_35;
        }
        
        if(this.resetOnPlay == false)
        {
            goto label_36;
        }
        
        label_21:
        val_17.Play(且丒且丐丌东专三丁:  val_7);
        val_17.ResetToBeginning();
        label_22:
        EventDelegate.丒万业丛丏东专世丟 val_12 = null;
        val_20 = val_12;
        val_12 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayTween::上丄丂丛专下丟万下());
        EventDelegate val_13 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.丑七丘丘丁丏世东丂[0x0][0].onFinished, 业丏丈世世世丞丒世:  val_12, 丕万三专丕不七专丐:  true);
        val_17.Play(且丒且丐丌东专三丁:  val_7);
        goto label_39;
        label_35:
        EventDelegate.丒万业丛丏东专世丟 val_15 = null;
        val_20 = val_15;
        val_15 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayTween::上丄丂丛专下丟万下());
        EventDelegate val_16 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.丑七丘丘丁丏世东丂[0x0][0].onFinished, 业丏丈世世世丞丒世:  val_15, 丕万三专丕不七专丐:  true);
        val_17.Toggle();
        label_39:
        val_18 = val_18 + 1;
        if((this.丑七丘丘丁丏世东丂.Length & 4294967295) != val_18)
        {
            goto label_42;
        }
        
        return;
        label_16:
        if(this.disableWhenFinished == 0)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.tweenTarget, 丏业丟一东丂东丘丛:  false);
    }
    private void 上丄丂丛专下丟万下()
    {
        string val_4;
        int val_4 = this.万丝业下下丏丆丏东;
        val_4 = val_4 - 1;
        this.万丝业下下丏丆丏东 = val_4;
        if(val_4 != 0)
        {
                return;
        }
        
        val_4 = 1152921504848912384;
        if(UIPlayTween.current != 0)
        {
                return;
        }
        
        UIPlayTween.current = this;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onFinished);
        if(this.eventReceiver != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.callWhenFinished)) != true)
        {
                val_4 = this.callWhenFinished;
            this.eventReceiver.SendMessage(methodName:  val_4, options:  1);
        }
        
        }
        
        this.eventReceiver = 0;
        UIPlayTween.current = 0;
    }
    public UIPlayTween()
    {
        this.playDirection = 1;
        this.onFinished = new System.Collections.Generic.List<EventDelegate>();
    }

}
