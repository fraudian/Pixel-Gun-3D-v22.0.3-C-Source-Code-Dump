using UnityEngine;
public class UIPlayAnimation : MonoBehaviour
{
    // Fields
    public static UIPlayAnimation current;
    public UnityEngine.Animation target;
    public UnityEngine.Animator animator;
    public string clipName;
    public AnimationOrTween.丏三业丕丈丄丂丑东 trigger;
    public AnimationOrTween.丟世丆丕丌且七下丂 playDirection;
    public bool resetOnPlay;
    public bool clearSelection;
    public AnimationOrTween.三世业世丟丈丕世且 ifDisabledOnPlay;
    public AnimationOrTween.且丁丝丄三世且丐一 disableWhenFinished;
    public System.Collections.Generic.List<EventDelegate> onFinished;
    private UnityEngine.GameObject eventReceiver;
    private string callWhenFinished;
    private bool 不世丌丝且三上丏丌;
    private bool 三丂与丘丁七丘东丞;
    private bool 丈丛不东丐专丈丆三;
    
    // Properties
    private bool 且丗丄丙丄丁丒东丝 { get; }
    
    // Methods
    private bool 丙丗丅丈不东丙丕一()
    {
        AnimationOrTween.丏三业丕丈丄丂丑东 val_2 = this.trigger;
        val_2 = val_2 - 1;
        return (bool)(val_2 < 2) ? 1 : 0;
    }
    private void Awake()
    {
        if((this.GetComponent<UIButton>()) != 0)
        {
                this.丈丛不东丐专丈丆三 = val_1.dragHighlight;
        }
        
        if(this.eventReceiver == 0)
        {
                return;
        }
        
        this = this.onFinished;
        if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this)) == false)
        {
                return;
        }
        
        this.eventReceiver = 0;
        mem[1152921531102299112] = 0;
    }
    private void Start()
    {
        UnityEngine.Animation val_10;
        this.不世丌丝且三上丏丌 = true;
        if(this.target == 0)
        {
                if(this.animator == 0)
        {
                this.animator = this.GetComponentInChildren<UnityEngine.Animator>();
        }
        
        }
        
        if(this.animator == 0)
        {
            goto label_9;
        }
        
        if(this.animator.enabled == false)
        {
                return;
        }
        
        if(this.animator != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        this.animator.enabled = false;
        return;
        label_9:
        if(this.target == 0)
        {
                val_10 = this.GetComponentInChildren<UnityEngine.Animation>();
            this.target = val_10;
        }
        else
        {
                val_10 = this.target;
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        if(this.target.enabled == false)
        {
                return;
        }
        
        if(this.target != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    private void OnEnable()
    {
        var val_15;
        丞上且下专丞东专世 val_16;
        AnimationOrTween.丏三业丕丈丄丂丑东 val_17;
        UnityEngine.Object val_18;
        var val_19;
        if(this.不世丌丝且三上丏丌 != false)
        {
                this.OnHover(丟丆丕且丆丈丂丌丘:  UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject));
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = UICamera.currentTouch;
        if(val_16 == null)
        {
            goto label_14;
        }
        
        val_17 = this.trigger;
        if(val_17 != 5)
        {
                if(val_17 != 2)
        {
            goto label_8;
        }
        
        }
        
        val_16 = UICamera.currentTouch;
        if(val_16 == null)
        {
            goto label_11;
        }
        
        val_18 = this.gameObject;
        val_17 = this.trigger;
        this.三丂与丘丁七丘东丞 = UnityEngine.Object.op_Equality(x:  UICamera.currentTouch.万东丂丒且丅丛丑丕, y:  val_18);
        label_8:
        if((val_17 | 2) == 3)
        {
                val_19 = null;
            val_19 = null;
            val_18 = this.gameObject;
            this.三丂与丘丁七丘东丞 = UnityEngine.Object.op_Equality(x:  UICamera.currentTouch.上丞丕专丈业丁世专, y:  val_18);
        }
        
        label_14:
        if((this.GetComponent<UIToggle>()) == 0)
        {
                return;
        }
        
        EventDelegate val_14 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_11.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayAnimation::不下与丗世与丙万一()));
        return;
        label_11:
    }
    private void OnDisable()
    {
        if((this.GetComponent<UIToggle>()) == 0)
        {
                return;
        }
        
        bool val_4 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  val_1.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayAnimation::不下与丗世与丙万一()));
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        AnimationOrTween.丏三业丕丈丄丂丑东 val_6 = this.trigger;
        var val_2 = (val_6 == 3) ? 1 : 0;
        var val_3 = (val_6 != 4) ? 1 : 0;
        val_3 = val_3 | 丟丆丕且丆丈丂丌丘;
        if((val_3 != false) && (val_6 != 1))
        {
                val_2 = val_2 & 丟丆丕且丆丈丂丌丘;
            if(val_2 != true)
        {
                return;
        }
        
        }
        
        val_6 = val_6 - 1;
        this.Play(且丒且丐丌东专三丁:  丟丆丕且丆丈丂丌丘, 东专与上上丗七丐业:  (val_6 < 2) ? 1 : 0);
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        var val_6;
        int val_7;
        if(this.enabled == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = UICamera.currentTouchID;
        if(val_7 == 2)
        {
                return;
        }
        
        val_7 = UICamera.currentTouchID;
        if(val_7 == 3)
        {
                return;
        }
        
        AnimationOrTween.丏三业丕丈丄丂丑东 val_6 = this.trigger;
        var val_2 = (val_6 == 5) ? 1 : 0;
        var val_3 = (val_6 != 6) ? 1 : 0;
        val_3 = val_3 | 丆丟专丑丁丒丁上丙;
        if((val_3 != false) && (val_6 != 2))
        {
                val_2 = val_2 & 丆丟专丑丁丒丁上丙;
            if(val_2 != true)
        {
                return;
        }
        
        }
        
        val_6 = val_6 - 1;
        this.Play(且丒且丐丌东专三丁:  丆丟专丑丁丒丁上丙, 东专与上上丗七丐业:  (val_6 < 2) ? 1 : 0);
    }
    private void OnClick()
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        val_3 = UICamera.currentTouchID;
        if(val_3 == 2)
        {
                return;
        }
        
        val_3 = UICamera.currentTouchID;
        if(val_3 == 3)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 0)
        {
                return;
        }
        
        this.Play(且丒且丐丌东专三丁:  true, 东专与上上丗七丐业:  false);
    }
    private void OnDoubleClick()
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        val_3 = UICamera.currentTouchID;
        if(val_3 == 2)
        {
                return;
        }
        
        val_3 = UICamera.currentTouchID;
        if(val_3 == 3)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 10)
        {
                return;
        }
        
        this.Play(且丒且丐丌东专三丁:  true, 东专与上上丗七丐业:  false);
    }
    private void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        AnimationOrTween.丏三业丕丈丄丂丑东 val_6 = this.trigger;
        var val_2 = (val_6 == 12) ? 1 : 0;
        var val_3 = (val_6 != 13) ? 1 : 0;
        val_3 = val_3 | 丞丈丌且东丆丅丗万;
        if((val_3 != false) && (val_6 != 11))
        {
                val_2 = val_2 & 丞丈丌且东丆丅丗万;
            if(val_2 != true)
        {
                return;
        }
        
        }
        
        val_6 = val_6 - 1;
        this.Play(且丒且丐丌东专三丁:  丞丈丌且东丆丅丗万, 东专与上上丗七丐业:  (val_6 < 2) ? 1 : 0);
    }
    private void 不下与丗世与丙万一()
    {
        var val_8;
        AnimationOrTween.丏三业丕丈丄丂丑东 val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this.enabled == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(UIToggle.current == 0)
        {
                return;
        }
        
        val_9 = this.trigger;
        if(val_9 == 7)
        {
            goto label_12;
        }
        
        if(val_9 != 8)
        {
            goto label_8;
        }
        
        val_10 = null;
        val_10 = null;
        if(UIToggle.current.value == true)
        {
            goto label_12;
        }
        
        val_9 = this.trigger;
        label_8:
        if(val_9 != 9)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(UIToggle.current.value == true)
        {
                return;
        }
        
        label_12:
        val_12 = null;
        val_12 = null;
        AnimationOrTween.丏三业丕丈丄丂丑东 val_8 = this.trigger;
        val_8 = val_8 - 1;
        this.Play(且丒且丐丌东专三丁:  UIToggle.current.value, 东专与上上丗七丐业:  (val_8 < 2) ? 1 : 0);
    }
    private void 专丌丟下上东丞不丙()
    {
        var val_4;
        if(this.enabled == false)
        {
                return;
        }
        
        AnimationOrTween.丏三业丕丈丄丂丑东 val_4 = this.trigger;
        val_4 = val_4 - 1;
        if(val_4 > 1)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(UICamera.currentTouch.丆丝东丞下丁丛丝与 != this.gameObject)
        {
                if(this.丈丛不东丐专丈丆三 == false)
        {
                return;
        }
        
            if(this.trigger != 2)
        {
                return;
        }
        
        }
        
        this.Play(且丒且丐丌东专三丁:  true, 东专与上上丗七丐业:  true);
    }
    private void 世丆丕丌丒下丆万上()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        AnimationOrTween.丏三业丕丈丄丂丑东 val_5 = this.trigger;
        val_5 = val_5 - 1;
        if(val_5 > 1)
        {
                return;
        }
        
        if(UICamera.hoveredObject == this.gameObject)
        {
                return;
        }
        
        this.Play(且丒且丐丌东专三丁:  false, 东专与上上丗七丐业:  true);
    }
    private void OnDrop(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_4;
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 2)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(UICamera.currentTouch.丆丝东丞下丁丛丝与 == this.gameObject)
        {
                return;
        }
        
        this.Play(且丒且丐丌东专三丁:  false, 东专与上上丗七丐业:  true);
    }
    public void Play(bool 且丒且丐丌东专三丁)
    {
        this.Play(且丒且丐丌东专三丁:  且丒且丐丌东专三丁, 东专与上上丗七丐业:  true);
    }
    public void Play(bool 且丒且丐丌东专三丁, bool 东专与上上丗七丐业)
    {
        UnityEngine.Animation val_16;
        var val_17;
        val_16 = 东专与上上丗七丐业;
        val_17 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  this.target)) != true)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.animator)) == false)
        {
                return;
        }
        
        }
        
        if(val_16 != false)
        {
                var val_3 = (this.三丂与丘丁七丘东丞 == true) ? 1 : 0;
            val_3 = val_3 ^ 且丒且丐丌东专三丁;
            if(val_3 == false)
        {
                return;
        }
        
            this.三丂与丘丁七丘东丞 = 且丒且丐丌东专三丁;
        }
        
        if(this.clearSelection != false)
        {
                if(UICamera.selectedObject == this.gameObject)
        {
                UICamera.selectedObject = 0;
        }
        
        }
        
        val_16 = this.target;
        AnimationOrTween.丟世丆丕丌且七下丂 val_8 = ((且丒且丐丌东专三丁 & true) != 0) ? (-this.playDirection) : this.playDirection;
        if((UnityEngine.Object.op_Implicit(exists:  val_16)) != false)
        {
                ActiveAnimation val_10 = ActiveAnimation.Play(丐丐七专三且世三七:  this.target, 七不丐下丟专业万丅:  this.clipName, 世一丑丝丈一上三丕:  val_8, 专丝丂世上丌丞世三:  this.ifDisabledOnPlay, 上丈丅丌丅丒丗上丒:  this.disableWhenFinished);
        }
        else
        {
                ActiveAnimation val_11 = ActiveAnimation.Play(丐丐七专三且世三七:  this.animator, 七不丐下丟专业万丅:  this.clipName, 世一丑丝丈一上三丕:  val_8, 专丝丂世上丌丞世三:  this.ifDisabledOnPlay, 上丈丅丌丅丒丗上丒:  this.disableWhenFinished);
        }
        
        if(val_11 == 0)
        {
                return;
        }
        
        if(this.resetOnPlay != false)
        {
                val_11.Reset();
        }
        
        val_17 = 0;
        goto label_26;
        label_31:
        EventDelegate val_14 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_11.onFinished, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIPlayAnimation::上丄丂丛专下丟万下()), 丕万三专丕不七专丐:  true);
        val_17 = 1;
        label_26:
        val_16 = this.onFinished;
        if(val_17 < val_16.Count)
        {
            goto label_31;
        }
    
    }
    public void PlayForward()
    {
        this.Play(且丒且丐丌东专三丁:  true, 东专与上上丗七丐业:  true);
    }
    public void PlayReverse()
    {
        this.Play(且丒且丐丌东专三丁:  false, 东专与上上丗七丐业:  true);
    }
    private void 上丄丂丛专下丟万下()
    {
        var val_4;
        string val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = 1152921504848912384;
        if(UIPlayAnimation.current != 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        UIPlayAnimation.current = this;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onFinished);
        if(this.eventReceiver != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.callWhenFinished)) != true)
        {
                val_5 = this.callWhenFinished;
            this.eventReceiver.SendMessage(methodName:  val_5, options:  1);
        }
        
        }
        
        this.eventReceiver = 0;
        val_7 = null;
        val_7 = null;
        UIPlayAnimation.current = 0;
    }
    public UIPlayAnimation()
    {
        this.playDirection = 1;
        this.onFinished = new System.Collections.Generic.List<EventDelegate>();
    }
    private static UIPlayAnimation()
    {
    
    }

}
