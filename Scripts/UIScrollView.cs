using UnityEngine;
public class UIScrollView : MonoBehaviour
{
    // Fields
    private System.Action<bool> 丈丏丂丗丕丞丑上丑;
    internal System.Action<bool> 七丐专与丗与不丂与;
    public static 丒丞丕丕七丁丗丟丛<UIScrollView> list;
    public UIScrollView.丘丌东丌丐丛丄丅丗 movement;
    public UIScrollView.丏丛丙一丘丞丅丞丑 dragEffect;
    public bool restrictWithinPanel;
    public bool disableDragIfFits;
    public bool smoothDragStart;
    public bool iOSDragEmulation;
    public float scrollWheelFactor;
    public float momentumAmount;
    public float dampenStrength;
    public UIProgressBar horizontalScrollBar;
    public UIProgressBar verticalScrollBar;
    public UIScrollView.一丘丆丘世业与上与 showScrollBars;
    public UnityEngine.Vector2 customMovement;
    public UIWidget.七丐与七丌不丂丞且 contentPivot;
    public UIScrollView.七丁丌丒万丄专三三 onDragStarted;
    public UIScrollView.七丁丌丒万丄专三三 onDragFinished;
    public UIScrollView.七丁丌丒万丄专三三 onMomentumMove;
    public UIScrollView.七丁丌丒万丄专三三 onStoppedMoving;
    public UIScrollView.七丁丌丒万丄专三三 ScrollbarUpdating;
    private UnityEngine.Vector3 scale;
    private UnityEngine.Vector2 relativePositionOnReset;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected UIPanel 与业丌丄且丁丛与丁;
    protected UnityEngine.Plane 丑丞丗专丁丕丂丁丅;
    protected UnityEngine.Vector3 专丟丆丛丁七下三丝;
    protected bool 且丙万丞东丗下丝丅;
    protected UnityEngine.Vector3 七丐丁丆上丒丄丏三;
    protected float 丈世丙业业七丟不丒;
    protected UnityEngine.Bounds 业丛丟三丌丈下不丄;
    protected bool 且丒不一丒下三丂专;
    protected bool 上丁丁丝丄丅丞丌下;
    protected bool 丌丐丒丐三丈丟且丝;
    protected int 丑丏专丕丄丝一丒不;
    protected UnityEngine.Vector2 且与下七丐东不丛丐;
    protected bool 东丌丈业丙丆丄世丑;
    public float moveRelativeValue;
    public bool constrained;
    public bool isExtended;
    private bool <下下丌下丌丕东丆丗>k__BackingField;
    private bool 不世丌丝且三上丏丌;
    public UICenterOnChild centerOnChild;
    
    // Properties
    public UIPanel 丛丘下丗业丂一且业 { get; }
    public bool 丒丅丛一业丘世不且 { get; }
    public virtual UnityEngine.Bounds 业东丛丂丏下丗丘且 { get; }
    public bool 一万一丘丕丏一下丞 { get; }
    public bool 丄丌下世丟且丅万且 { get; }
    public virtual bool 且不丏世三丛上世丌 { get; }
    public virtual bool 丟丂与丄丁丙一且世 { get; }
    public virtual bool 不丗一专丈丛丒专丁 { get; }
    public virtual bool 七东丙丄丗上丆丌与 { get; set; }
    public UnityEngine.Vector3 东世丈不丗丏上丐丂 { get; set; }
    
    // Methods
    internal void 丌丐丐丏万丐七丛上(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丏丂丗丕丞丑上丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丏丂丗丕丞丑上丑 != 1152921531125049160);
    
    }
    internal void 丄丘世丈丅东上业上(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丏丂丗丕丞丑上丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丏丂丗丕丞丑上丑 != 1152921531125185736);
    
    }
    public UIPanel get_panel()
    {
        return (UIPanel)this.与业丌丄且丁丛与丁;
    }
    public bool get_isDragging()
    {
        if(this.且丙万丞东丗下丝丅 == false)
        {
                return false;
        }
        
        return (bool)(this.东丌丈业丙丆丄世丑 == true) ? 1 : 0;
    }
    public virtual void LogBounds()
    {
        string val_2;
        UnityEngine.Debug.LogError(message:  "Bounds = "("Bounds = ") + val_2);
    }
    public void Move()
    {
    
    }
    private void 丞与一丙业业七丏丁()
    {
        float val_3;
        if(this.与业丌丄且丁丛与丁 == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B});
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = V2.16B});
        if(this.movement != 1)
        {
                if(this.movement != 0)
        {
            goto label_8;
        }
        
        }
        
        label_8:
        this.constrained = (val_4.x <= 0.01f) ? 1 : 0;
    }
    public static UnityEngine.Vector3 SpringDampen(ref UnityEngine.Vector3 丏丄业丆业丅且丏丗, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        float val_12 = 丛上丟丌丄丗丁世与;
        float val_11 = -0.001f;
        val_11 = val_12 * val_11;
        val_12 = val_11 + 1f;
        float val_13 = 1000f;
        val_13 = 丑丗丘与丈不七东丛 * val_13;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_13);
        float val_14 = -1f;
        val_14 = val_12 + val_14;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y, z = 丏丄业丆业丅且丏丗.z}, d:  val_14 / val_12);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y, z = 丏丄业丆业丅且丏丗.z}, d:  val_12);
        丏丄业丆业丅且丏丗.x = val_4.x;
        丏丄业丆业丅且丏丗.y = val_4.y;
        丏丄业丆业丅且丏丗.z = val_4.z;
        float val_6 = UnityEngine.Mathf.Clamp(value:  val_3.x * 0.06f, min:  -0.22f, max:  0.22f);
        float val_8 = UnityEngine.Mathf.Clamp(value:  val_3.y * 0.06f, min:  -0.22f, max:  0.22f);
        float val_10 = UnityEngine.Mathf.Clamp(value:  val_3.z * 0.06f, min:  -0.22f, max:  0.22f);
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public virtual UnityEngine.Bounds get_bounds()
    {
        var val_3;
        UnityEngine.Bounds val_4;
        UnityEngine.Bounds val_6;
        UnityEngine.Bounds val_0;
        if(this.且丒不一丒下三丂专 != false)
        {
                val_6 = this.业丛丟三丌丈下不丄;
        }
        else
        {
                this.且丒不一丒下三丂专 = true;
            UnityEngine.Transform val_1 = this.transform;
            this.丐一丗丛丕世丘东丁 = val_1;
            UnityEngine.Bounds val_2 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  val_1, 三丏丑不业丏不丂丈:  val_1);
            mem[1152921531126043552] = val_3;
            val_6 = this.业丛丟三丌丈下不丄;
            this.业丛丟三丌丈下不丄 = val_4;
        }
        
        val_0.m_Extents.y = mem[this.业丛丟三丌丈下不丄 + 16];
        val_0.m_Center.x = this.业丛丟三丌丈下不丄.m_Center;
        return val_0;
    }
    public bool get_canMoveHorizontally()
    {
        if(this.movement == 0)
        {
                return (bool)1;
        }
        
        if(this.movement == 2)
        {
                return (bool)1;
        }
        
        if(this.movement == 3)
        {
                return (bool)(this.customMovement != 0f) ? 1 : 0;
        }
        
        1 = 0;
        return (bool)1;
    }
    public bool get_canMoveVertically()
    {
        if((this.movement - 1) < 2)
        {
                return true;
        }
        
        if(this.movement != 3)
        {
                return false;
        }
        
        return (bool)(S0 != 0f) ? 1 : 0;
    }
    public virtual bool get_shouldMoveHorizontally()
    {
        float val_2;
        float val_8 = val_2;
        if(this.与业丌丄且丁丛与丁.clipping == 3)
        {
                UnityEngine.Vector2 val_4 = this.与业丌丄且丁丛与丁.clipSoftness;
            val_4.x = val_4.x + val_4.x;
            val_8 = val_8 + val_4.x;
        }
        
        float val_5 = this.与业丌丄且丁丛与丁.width;
        val_5 = val_8 - val_5;
        return (bool)((UnityEngine.Mathf.RoundToInt(f:  val_5)) > 0) ? 1 : 0;
    }
    public virtual bool get_shouldMoveVertically()
    {
        float val_9 = V1.16B;
        if(this.与业丌丄且丁丛与丁.clipping == 3)
        {
                UnityEngine.Vector2 val_4 = this.与业丌丄且丁丛与丁.clipSoftness;
            val_9 = val_9 + (val_4.y + val_4.y);
        }
        
        float val_6 = this.与业丌丄且丁丛与丁.height;
        val_6 = val_9 - val_6;
        return (bool)((UnityEngine.Mathf.RoundToInt(f:  val_6)) > 0) ? 1 : 0;
    }
    public virtual bool get_shouldMove()
    {
        var val_14;
        UIPanel val_15;
        float val_16;
        float val_17;
        float val_18;
        丘丌东丌丐丛丄丅丗 val_19;
        if((this & 1) == 0)
        {
            goto label_1;
        }
        
        label_24:
        val_14 = 0;
        return (bool)val_14;
        label_1:
        if(this.disableDragIfFits == false)
        {
            goto label_23;
        }
        
        if(this.与业丌丄且丁丛与丁 != 0)
        {
            goto label_6;
        }
        
        val_15 = this.GetComponent<UIPanel>();
        this.与业丌丄且丁丛与丁 = val_15;
        if(val_15 != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_6:
        val_15 = this.与业丌丄且丁丛与丁;
        if(val_15 != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        UnityEngine.Vector4 val_3 = val_15.finalClipRegion;
        if(val_3.z == 0f)
        {
                val_16 = (float)UnityEngine.Screen.width;
        }
        else
        {
                val_17 = 0.5f;
            val_16 = val_3.z * val_17;
        }
        
        if(val_3.w == 0f)
        {
                val_18 = (float)UnityEngine.Screen.height;
        }
        else
        {
                val_17 = 0.5f;
            val_18 = val_3.w * val_17;
        }
        
        val_19 = this.movement;
        if((val_19 == 0) || (val_19 == 2))
        {
            goto label_15;
        }
        
        if(val_19 != 3)
        {
            goto label_16;
        }
        
        val_17 = this.customMovement;
        if(val_17 == 0f)
        {
            goto label_17;
        }
        
        label_15:
        float val_8 = val_3.x - val_16;
        if(val_17 < 0)
        {
            goto label_23;
        }
        
        float val_9 = val_3.x + val_16;
        if(val_17 > val_9)
        {
            goto label_23;
        }
        
        val_19 = this.movement;
        label_16:
        if((val_19 - 1) < 2)
        {
            goto label_20;
        }
        
        if(val_19 != 3)
        {
            goto label_24;
        }
        
        label_17:
        if(val_17 == 0f)
        {
            goto label_24;
        }
        
        label_20:
        float val_11 = val_3.y - val_18;
        if(val_9 >= 0)
        {
                if(val_9 <= (val_3.y + val_18))
        {
            goto label_24;
        }
        
        }
        
        label_23:
        val_14 = 1;
        return (bool)val_14;
    }
    public virtual bool get_disableMoving()
    {
        return (bool)this.<下下丌下丌丕东丆丗>k__BackingField;
    }
    public virtual void set_disableMoving(bool 丙业与丙丗丝不丈东)
    {
        this.<下下丌下丌丕东丆丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Vector3 get_currentMomentum()
    {
        return new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三};
    }
    public void set_currentMomentum(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.七丐丁丆上丒丄丏三 = 丙业与丙丗丝不丈东;
        mem[1152921531127186564] = 丙业与丙丗丝不丈东.y;
        mem[1152921531127186568] = 丙业与丙丗丝不丈东.z;
        this.上丁丁丝丄丅丞丌下 = true;
    }
    private void Awake()
    {
        float val_10;
        var val_12;
        this.丐一丗丛丕世丘东丁 = this.transform;
        UIPanel val_2 = this.GetComponent<UIPanel>();
        this.与业丌丄且丁丛与丁 = val_2;
        if(val_2.clipping == 0)
        {
                this.与业丌丄且丁丛与丁.clipping = 4;
        }
        
        if(this.movement == 3)
        {
            goto label_5;
        }
        
        val_10 = 0.001f;
        if(S0 <= val_10)
        {
            goto label_5;
        }
        
        val_10 = 1f;
        if((this.scale.x != val_10) || (S2 != 0f))
        {
            goto label_7;
        }
        
        this.movement = 0;
        goto label_14;
        label_7:
        if((this.scale.x != 0f) || (S2 != val_10))
        {
            goto label_10;
        }
        
        this.movement = 1;
        goto label_14;
        label_10:
        if(this.scale.x != val_10)
        {
            goto label_15;
        }
        
        if(S2 != val_10)
        {
            goto label_13;
        }
        
        this.movement = 2;
        goto label_14;
        label_13:
        val_12 = S2;
        label_15:
        this.customMovement = this.scale.x;
        this.movement = 3;
        mem[1152921531127327112] = val_12;
        label_14:
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.scale = val_4;
        mem[1152921531127327164] = val_4.y;
        mem[1152921531127327168] = val_4.z;
        label_5:
        if(this.contentPivot != 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        float val_10 = V8.16B;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.relativePositionOnReset, y = val_10}, rhs:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) == false)
        {
                return;
        }
        
        val_10 = 1f - val_10;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  this.relativePositionOnReset, y:  val_10);
        this.contentPivot = 万丗丅且丄丑世专与.业上丟丟三丄丌丘丝(丛上丙丄丄七丈且丅:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        this.relativePositionOnReset = val_9;
        mem[1152921531127327176] = val_9.y;
    }
    private void OnEnable()
    {
        null = null;
        UIScrollView.list.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this.东专且丏且丒东与丌();
    }
    private void Start()
    {
        this.isExtended = UnityEngine.Object.op_Inequality(x:  this.GetComponent<ScrollExtention>(), y:  0);
        this.不世丌丝且三上丏丌 = true;
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this.东专且丏且丒东与丌();
    }
    private void 东专且丏且丒东与丌()
    {
        float val_7;
        float val_8;
        if(this.horizontalScrollBar == 0)
        {
            goto label_3;
        }
        
        EventDelegate val_3 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.horizontalScrollBar.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void UIScrollView::OnScrollBar()));
        this.horizontalScrollBar.BroadcastMessage(methodName:  "CacheDefaultColor", options:  1);
        if(this.showScrollBars == 0)
        {
            goto label_8;
        }
        
        val_7 = 0f;
        if((this & 1) == 0)
        {
            goto label_9;
        }
        
        label_8:
        val_7 = 1f;
        label_9:
        this.horizontalScrollBar.alpha = val_7;
        label_3:
        if(this.verticalScrollBar == 0)
        {
                return;
        }
        
        EventDelegate val_6 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.verticalScrollBar.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void UIScrollView::OnScrollBar()));
        this.verticalScrollBar.BroadcastMessage(methodName:  "CacheDefaultColor", options:  1);
        if(this.showScrollBars == 0)
        {
            goto label_18;
        }
        
        val_8 = 0f;
        if((this & 1) == 0)
        {
            goto label_19;
        }
        
        label_18:
        val_8 = 1f;
        label_19:
        this.verticalScrollBar.alpha = val_8;
    }
    private void OnDisable()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        bool val_1 = UIScrollView.list.Remove(下丅丙一丂丗丅丝七:  this);
        val_5 = null;
        val_5 = null;
        bool val_3 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    public void Restrict()
    {
        bool val_1 = this.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  true, 与丐丌万丁丒不业丕:  true, 丌丝三丌丗丄丌丈且:  true);
    }
    public bool RestrictWithinBounds(bool 丌丝丌丁下丐丞丆一)
    {
        return this.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  丌丝丌丁下丐丞丆一, 与丐丌万丁丒不业丕:  true, 丌丝三丌丗丄丌丈且:  true);
    }
    public bool RestrictWithinBounds(bool 丌丝丌丁下丐丞丆一, bool 与丐丌万丁丒不业丕, bool 丌丝三丌丗丄丌丈且)
    {
        float val_3;
        var val_14;
        float val_15;
        float val_16;
        var val_17;
        float val_18;
        var val_19;
        var val_21;
        float val_22;
        val_14 = this;
        if(this.与业丌丄且丁丛与丁 == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B});
        val_15 = val_4.x;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = V2.16B});
        val_16 = val_5.x;
        if(val_15 <= 0.1f)
        {
            goto label_9;
        }
        
        if(this.constrained != false)
        {
                if(this.isExtended == true)
        {
            goto label_13;
        }
        
        }
        
        if((丌丝丌丁下丐丞丆一 == true) || (this.dragEffect != 2))
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_6 = this.丐一丗丛丕世丘东丁.localPosition;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_16});
        val_15 = val_7.z;
        if(val_7.x >= 0f)
        {
            goto label_19;
        }
        
        if((double)val_7.x != (-0.5))
        {
            goto label_20;
        }
        
        val_17 = val_3;
        val_18 = -1f;
        goto label_21;
        label_9:
        val_19 = 0;
        return (bool)val_19;
        label_13:
        val_15 = 0.01f;
        if(System.Math.Abs(0f) > val_15)
        {
                this.七丐丁丆上丒丄丏三 = 0;
        }
        
        if(System.Math.Abs(0f) > val_15)
        {
                mem[1152921531128324340] = 0;
        }
        
        if(System.Math.Abs(val_16) > val_15)
        {
                mem[1152921531128324344] = 0;
        }
        
        this.丈世丙业业七丟不丒 = 0f;
        goto label_32;
        label_19:
        if((double)val_7.x != 0.5)
        {
            goto label_33;
        }
        
        val_17 = val_3;
        val_18 = 1f;
        label_21:
        val_18 = (float)val_17 + val_18;
        var val_8 = (((long)val_17 & 1) != 0) ? ((float)val_17) : (val_18);
        goto label_35;
        label_20:
        float val_16 = -0.5f;
        val_16 = val_7.x + val_16;
        goto label_35;
        label_33:
        float val_17 = 0.5f;
        val_17 = val_7.x + val_17;
        label_35:
        if(val_7.y >= 0f)
        {
            goto label_36;
        }
        
        if((double)val_7.y != (-0.5))
        {
            goto label_37;
        }
        
        val_21 = val_3;
        val_22 = -1f;
        goto label_38;
        label_36:
        if((double)val_7.y != 0.5)
        {
            goto label_39;
        }
        
        val_21 = val_3;
        val_22 = 1f;
        label_38:
        val_22 = (float)val_21 + val_22;
        var val_9 = (((long)val_21 & 1) != 0) ? ((float)val_21) : (val_22);
        goto label_41;
        label_37:
        float val_18 = -0.5f;
        val_18 = val_7.y + val_18;
        goto label_41;
        label_39:
        float val_19 = 0.5f;
        val_19 = val_7.y + val_19;
        label_41:
        UnityEngine.GameObject val_10 = this.与业丌丄且丁丛与丁.gameObject;
        if(this.isExtended != false)
        {
                SpringPanel val_11 = SpringPanel.BeginExtended(丝三丁东丈丒世丅业:  val_10, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_15}, 丛上丟丌丄丗丁世与:  13f);
        }
        
        val_14 = SpringPanel.Begin(丝三丁东丈丒世丅业:  val_10, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_15}, 丛上丟丌丄丗丁世与:  13f);
        val_12.strength = 8f;
        label_32:
        val_19 = 1;
        return (bool)val_19;
    }
    public void DisableSpring()
    {
        SpringPanel val_1 = this.GetComponent<SpringPanel>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.enabled = false;
    }
    public void UpdateScrollbars()
    {
        goto typeof(UIScrollView).__il2cppRuntimeField_1D8;
    }
    public virtual void UpdateScrollbars(bool 丙丈丗三世丁丑不专)
    {
        float val_5;
        UIPanel val_30;
        UnityEngine.Object val_31;
        UnityEngine.Object val_32;
        float val_34;
        float val_35;
        float val_38;
        var val_39;
        float val_40;
        float val_41;
        float val_42;
        double val_45;
        var val_46;
        float val_47;
        float val_48;
        val_30 = this.与业丌丄且丁丛与丁;
        if(val_30 == 0)
        {
                return;
        }
        
        val_30 = this.horizontalScrollBar;
        val_31 = 0;
        if(val_30 != val_31)
        {
            goto label_6;
        }
        
        val_30 = this.verticalScrollBar;
        val_32 = 0;
        if(val_30 == val_32)
        {
            goto label_9;
        }
        
        label_6:
        if(丙丈丗三世丁丑不专 != false)
        {
                this.且丒不一丒下三丂专 = false;
            this.上丁丁丝丄丅丞丌下 = 0;
        }
        
        val_34 = V1.16B;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5, y = val_34, z = V2.16B});
        val_35 = val_6.x;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = V2.16B});
        if((val_7.x <= val_35) || (this.horizontalScrollBar == 0))
        {
            goto label_16;
        }
        
        UnityEngine.Vector4 val_9 = this.与业丌丄且丁丛与丁.finalClipRegion;
        val_38 = val_9.x;
        float val_29 = val_9.z;
        int val_28 = UnityEngine.Mathf.RoundToInt(f:  val_29);
        val_28 = val_28 - (val_28 & 1);
        val_29 = (float)val_28 * 0.5f;
        if(val_29 >= 0f)
        {
            goto label_22;
        }
        
        if((double)val_29 != (-0.5))
        {
            goto label_23;
        }
        
        val_39 = val_5;
        val_40 = -1f;
        goto label_24;
        label_9:
        if(丙丈丗三世丁丑不专 == false)
        {
            goto label_36;
        }
        
        this.且丒不一丒下三丂专 = false;
        goto label_36;
        label_22:
        if((double)val_29 != 0.5)
        {
            goto label_27;
        }
        
        val_39 = val_5;
        val_40 = 1f;
        label_24:
        val_41 = (float)val_39;
        val_40 = val_41 + val_40;
        var val_12 = (((long)val_39 & 1) != 0) ? (val_41) : (val_40);
        goto label_29;
        label_23:
        val_41 = val_29 + (-0.5f);
        goto label_29;
        label_27:
        val_41 = val_29 + 0.5f;
        label_29:
        if(this.与业丌丄且丁丛与丁.clipping == 3)
        {
                UnityEngine.Vector2 val_14 = this.与业丌丄且丁丛与丁.clipSoftness;
            val_42 = val_29 - val_14.x;
        }
        
        val_14.x = val_38 - val_42;
        val_14.x = val_14.x - val_35;
        val_34 = val_7.x - (val_38 + val_42);
        this.丄丅丝丆丑丘丂丞不(丆且丞丟丛丗万一世:  this.horizontalScrollBar, 业专丐丝丛七丈丄且:  val_14.x, 丕丙丄一东丁丂丄丗:  val_34, 丞专上丕丅丑丁一丈:  val_7.x - val_35, 世丂不业业丄世丂丘:  val_42 + val_42, 丏丈丒丙丅与丞业丂:  false);
        label_16:
        if((val_7.y <= val_6.y) || (this.verticalScrollBar == 0))
        {
            goto label_36;
        }
        
        UnityEngine.Vector4 val_19 = this.与业丌丄且丁丛与丁.finalClipRegion;
        val_35 = val_19.y;
        float val_31 = val_19.w;
        int val_30 = UnityEngine.Mathf.RoundToInt(f:  val_31);
        val_30 = val_30 - (val_30 & 1);
        val_38 = 0.5f;
        val_31 = (float)val_30 * val_38;
        if(val_31 >= 0f)
        {
            goto label_42;
        }
        
        val_45 = -0.5;
        if((double)val_31 != val_45)
        {
            goto label_43;
        }
        
        val_46 = val_5;
        val_47 = -1f;
        goto label_44;
        label_42:
        val_45 = 0.5;
        if((double)val_31 != val_45)
        {
            goto label_45;
        }
        
        val_46 = val_5;
        val_47 = 1f;
        label_44:
        val_45 = (float)val_46 + val_47;
        var val_22 = (((long)val_46 & 1) != 0) ? ((float)val_46) : (val_45);
        goto label_47;
        label_43:
        float val_32 = -0.5f;
        val_32 = val_31 + val_32;
        goto label_47;
        label_45:
        float val_23 = val_31 + val_38;
        label_47:
        if(this.与业丌丄且丁丛与丁.clipping == 3)
        {
                UnityEngine.Vector2 val_25 = this.与业丌丄且丁丛与丁.clipSoftness;
            val_48 = val_31 - val_25.y;
        }
        
        float val_26 = val_35 - val_48;
        val_25.y = val_35 + val_48;
        val_19.w = val_48 + val_48;
        val_26 = val_26 - val_6.y;
        val_25.y = val_7.y - val_25.y;
        this.丄丅丝丆丑丘丂丞不(丆且丞丟丛丗万一世:  this.verticalScrollBar, 业专丐丝丛七丈丄且:  val_26, 丕丙丄一东丁丂丄丗:  val_25.y, 丞专上丕丅丑丁一丈:  val_7.y - val_6.y, 世丂不业业丄世丂丘:  val_19.w, 丏丈丒丙丅与丞业丂:  true);
        label_36:
        if(this.ScrollbarUpdating == null)
        {
                return;
        }
        
        this.ScrollbarUpdating.Invoke();
    }
    protected void 丄丅丝丆丑丘丂丞不(UIProgressBar 丆且丞丟丛丗万一世, float 业专丐丝丛七丈丄且, float 丕丙丄一东丁丂丄丗, float 丞专上丕丅丑丁一丈, float 世丂不业业丄世丂丘, bool 丏丈丒丙丅与丞业丂)
    {
        float val_21;
        float val_22;
        UnityEngine.Object val_23;
        float val_25;
        float val_26;
        val_21 = 丞专上丕丅丑丁一丈;
        val_22 = 业专丐丝丛七丈丄且;
        val_23 = 丆且丞丟丛丗万一世;
        if(val_23 == 0)
        {
                return;
        }
        
        this.丌丐丒丐三丈丟且丝 = true;
        if(世丂不业业丄世丂丘 >= 0)
        {
            goto label_4;
        }
        
        业专丐丝丛七丈丄且 = val_22 / val_21;
        val_22 = UnityEngine.Mathf.Clamp01(value:  业专丐丝丛七丈丄且);
        val_25 = val_22 + (UnityEngine.Mathf.Clamp01(value:  丕丙丄一东丁丂丄丗 / val_21));
        if(丏丈丒丙丅与丞业丂 == false)
        {
            goto label_7;
        }
        
        val_21 = 0f;
        if(val_25 > 0.001f)
        {
                val_21 = 1f - (val_22 / val_25);
        }
        
        if(val_23 != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        val_23.value = val_21;
        if(val_23 != null)
        {
            goto label_10;
        }
        
        goto label_22;
        label_4:
        float val_16 = -val_22;
        val_16 = val_16 / val_21;
        val_22 = UnityEngine.Mathf.Clamp01(value:  val_16);
        float val_17 = -丕丙丄一东丁丂丄丗;
        val_17 = val_17 / val_21;
        float val_7 = UnityEngine.Mathf.Clamp01(value:  val_17);
        val_25 = val_22 + val_7;
        if(丏丈丒丙丅与丞业丂 == false)
        {
            goto label_14;
        }
        
        val_26 = 0f;
        if(val_25 > 0.001f)
        {
                val_26 = 1f - (val_22 / val_25);
        }
        
        if(val_23 != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        val_23.value = val_26;
        if(val_21 > 0f)
        {
                val_22 = UnityEngine.Mathf.Clamp01(value:  val_22 / val_21);
            val_25 = val_22 + (UnityEngine.Mathf.Clamp01(value:  val_7 / val_21));
        }
        
        if(val_23 == null)
        {
            goto label_22;
        }
        
        label_10:
        val_23 = 0;
        label_22:
        if( != 0)
        {
                float val_18 = 1f;
            val_18 = val_18 - val_25;
            barSize = val_18;
        }
        
        this.丌丐丒丐三丈丟且丝 = false;
        return;
        label_7:
        if(val_25 <= 0.001f)
        {
            goto label_27;
        }
        
        val_21 = val_22 / val_25;
        if(val_23 != null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_14:
        if(val_25 <= 0.001f)
        {
            goto label_30;
        }
        
        float val_15 = val_22 / val_25;
        if(val_23 != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_27:
        if(val_23 != null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_30:
        if(val_23 != null)
        {
            goto label_35;
        }
        
        goto label_36;
    }
    public virtual void SetDragAmount(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, bool 丝丐与丕丙丗丄丞东)
    {
        float val_4;
        float val_24;
        UIPanel val_25;
        UnityEngine.Object val_26;
        float val_27;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        丘丌东丌丐丛丄丅丗 val_37;
        float val_38;
        val_24 = 三丟东丕丄丄下下丑;
        val_25 = this.与业丌丄且丁丛与丁;
        val_26 = 0;
        if(val_25 == val_26)
        {
                val_26 = public UIPanel UnityEngine.Component::GetComponent<UIPanel>();
            this.与业丌丄且丁丛与丁 = this.GetComponent<UIPanel>();
        }
        
        this.DisableSpring();
        val_27 = val_4;
        if(val_27 == val_4)
        {
                return;
        }
        
        val_27 = 丒丒丄丁且丄丆丂丌;
        if(val_27 == 丒丒丄丁且丄丆丂丌)
        {
                return;
        }
        
        UnityEngine.Vector4 val_5 = this.与业丌丄且丁丛与丁.finalClipRegion;
        float val_6 = val_5.z * 0.5f;
        float val_7 = val_5.w * 0.5f;
        val_30 = 0.5f + val_6;
        val_31 = 0.5f - val_6;
        val_32 = val_7 + val_5.y;
        val_33 = val_5.y - val_7;
        if(this.与业丌丄且丁丛与丁.clipping == 3)
        {
                UnityEngine.Vector2 val_9 = this.与业丌丄且丁丛与丁.clipSoftness;
            UnityEngine.Vector2 val_10 = this.与业丌丄且丁丛与丁.clipSoftness;
            UnityEngine.Vector2 val_11 = this.与业丌丄且丁丛与丁.clipSoftness;
            val_30 = val_30 - val_9.x;
            val_31 = val_31 + val_10.x;
            val_32 = val_32 - val_11.y;
            UnityEngine.Vector2 val_12 = this.与业丌丄且丁丛与丁.clipSoftness;
            val_33 = val_33 + val_12.y;
        }
        
        val_27 = val_5.x;
        val_34 = val_5.y;
        float val_13 = UnityEngine.Mathf.Lerp(a:  val_30, b:  val_31, t:  val_24);
        val_35 = val_33;
        val_36 = val_32;
        val_24 = UnityEngine.Mathf.Lerp(a:  val_35, b:  val_36, t:  丒丒丄丁且丄丆丂丌);
        if(丝丐与丕丙丗丄丞东 == false)
        {
            goto label_15;
        }
        
        val_37 = this.movement;
        goto label_16;
        label_15:
        UnityEngine.Vector3 val_15 = this.丐一丗丛丕世丘东丁.localPosition;
        val_37 = this;
        val_32 = val_15.x;
        val_38 = val_15.y;
        val_31 = val_15.z;
        if((this.movement == 0) || (this.movement == 2))
        {
            goto label_19;
        }
        
        if(this.movement != 3)
        {
            goto label_20;
        }
        
        if(this.customMovement == 0f)
        {
            goto label_21;
        }
        
        label_19:
        float val_16 = val_27 - val_13;
        val_32 = val_16 + val_32;
        label_20:
        if((this.movement - 1) < 2)
        {
            goto label_22;
        }
        
        if(this.movement != 3)
        {
            goto label_24;
        }
        
        label_21:
        if(val_16 == 0f)
        {
            goto label_24;
        }
        
        label_22:
        val_38 = (val_34 - val_24) + val_38;
        label_24:
        val_35 = val_32;
        val_36 = val_38;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_31};
        label_16:
        if((this.movement == 0) || (this.movement == 2))
        {
            goto label_27;
        }
        
        if(this.movement != 3)
        {
            goto label_28;
        }
        
        val_35 = this.customMovement;
        if(val_35 == 0f)
        {
            goto label_29;
        }
        
        label_27:
        val_27 = val_13;
        label_28:
        if((this.movement - 1) < 2)
        {
            goto label_30;
        }
        
        if(this.movement != 3)
        {
            goto label_32;
        }
        
        label_29:
        if(val_35 == 0f)
        {
            goto label_32;
        }
        
        label_30:
        val_34 = val_24;
        label_32:
        UnityEngine.Vector4 val_20 = this.与业丌丄且丁丛与丁.baseClipRegion;
        val_25 = this.与业丌丄且丁丛与丁;
        val_20.x = val_27 - val_20.x;
        val_20.y = val_34 - val_20.y;
        val_4 = 0;
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_20.x, y:  val_20.y);
        val_25.clipOffset = new UnityEngine.Vector2() {x = val_21.x, y = val_21.y};
        if(丝丐与丕丙丗丄丞东 == false)
        {
                return;
        }
        
        var val_22 = (this.丑丏专丕丄丝一丒不 == 10) ? 1 : 0;
    }
    public void InvalidateBounds()
    {
        this.且丒不一丒下三丂专 = false;
    }
    public void ResetPosition()
    {
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.且丒不一丒下三丂专 = false;
        UnityEngine.Vector2 val_2 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.contentPivot);
        float val_3 = 1f - val_2.y;
        this = ???;
        goto typeof(UIScrollView).__il2cppRuntimeField_1E8;
    }
    public void UpdatePosition()
    {
        var val_8;
        if(this.丌丐丒丐三丈丟且丝 == true)
        {
                return;
        }
        
        if(this.horizontalScrollBar == 0)
        {
                if(this.verticalScrollBar == 0)
        {
                return;
        }
        
        }
        
        this.丌丐丒丐三丈丟且丝 = true;
        this.且丒不一丒下三丂专 = false;
        UnityEngine.Vector2 val_3 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  this.contentPivot);
        val_8 = val_3.x;
        if(this.horizontalScrollBar != 0)
        {
                val_8 = this.horizontalScrollBar.value;
        }
        
        if(this.verticalScrollBar != 0)
        {
                float val_7 = this.verticalScrollBar.value;
        }
        else
        {
                val_3.y = 1f - val_3.y;
        }
        
        this.丌丐丒丐三丈丟且丝 = false;
    }
    public void OnScrollBar()
    {
        var val_5;
        if(this.丌丐丒丐三丈丟且丝 == true)
        {
                return;
        }
        
        this.丌丐丒丐三丈丟且丝 = true;
        val_5 = 0f;
        if(this.horizontalScrollBar != 0)
        {
                val_5 = this.horizontalScrollBar.value;
        }
        
        if(this.verticalScrollBar != 0)
        {
                float val_4 = this.verticalScrollBar.value;
        }
        
        this.丌丐丒丐三丈丟且丝 = false;
    }
    public virtual void MoveRelative(UnityEngine.Vector3 丄丂丙丘丄丛上丐丒)
    {
        float val_5 = 丄丂丙丘丄丛上丐丒.y;
        float val_4 = 丄丂丙丘丄丛上丐丒.x;
        UnityEngine.Vector3 val_1 = this.丐一丗丛丕世丘东丁.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = 丄丂丙丘丄丛上丐丒.z});
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector2 val_3 = this.与业丌丄且丁丛与丁.clipOffset;
        val_4 = val_3.x - val_4;
        val_5 = val_3.y - val_5;
        this.与业丌丄且丁丛与丁.clipOffset = new UnityEngine.Vector2() {x = val_4, y = val_5};
        goto typeof(UIScrollView).__il2cppRuntimeField_1D8;
    }
    public void MoveAbsolute(UnityEngine.Vector3 业丘丕万七专丑丂一)
    {
        UnityEngine.Vector3 val_1 = this.丐一丗丛丕世丘东丁.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 业丘丕万七专丑丂一.x, y = 业丘丕万七专丑丂一.y, z = 业丘丕万七专丑丂一.z});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_3 = this.丐一丗丛丕世丘东丁.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        goto typeof(UIScrollView).__il2cppRuntimeField_1F8;
    }
    public void Press(bool 万东丂丒且丅丛丑丕)
    {
        var val_12;
        UnityEngine.GameObject val_32;
        var val_33;
        var val_34;
        var val_35;
        float val_36;
        var val_38;
        var val_40;
        float val_41;
        var val_43;
        float val_44;
        var val_46;
        float val_47;
        var val_49;
        var val_50;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        if((this.smoothDragStart != false) && (万东丂丒且丅丛丑丕 != false))
        {
                this.东丌丈业丙丆丄世丑 = false;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.且与下七丐东不丛丐 = val_2;
            mem[1152921531130184484] = val_2.y;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        val_32 = this.gameObject;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_32)) == false)
        {
                return;
        }
        
        if(万东丂丒且丅丛丑丕 != true)
        {
                val_33 = null;
            val_32 = this.丑丏专丕丄丝一丒不;
            val_33 = null;
            if(val_32 == UICamera.currentTouchID)
        {
                this.丑丏专丕丄丝一丒不 = 9;
        }
        
        }
        
        this.且丒不一丒下三丂专 = false;
        this.上丁丁丝丄丅丞丌下 = 0;
        if((this & 1) == 0)
        {
                return;
        }
        
        this.且丙万丞东丗下丝丅 = 万东丂丒且丅丛丑丕;
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_17;
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.七丐丁丆上丒丄丏三 = val_7;
        mem[1152921531130184436] = val_7.y;
        mem[1152921531130184440] = val_7.z;
        this.丈世丙业业七丟不丒 = 0f;
        this.DisableSpring();
        val_34 = null;
        val_34 = null;
        this.专丟丆丛丁七下三丝 = UICamera.lastWorldPosition;
        mem[1152921531130184424] = UICamera.丅丒世丆业丑丏丁丈.__il2cppRuntimeField_5C;
        UnityEngine.Quaternion val_8 = this.丐一丗丛丕世丘东丁.rotation;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.back;
        UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        this.丑丞丗专丁丕丂丁丅 = 0;
        mem[1152921531130184404] = 0;
        mem[1152921531130184412] = 0;
        UnityEngine.Vector2 val_11 = this.与业丌丄且丁丛与丁.clipOffset;
        if(val_11.x >= 0f)
        {
            goto label_28;
        }
        
        if((double)val_11.x != (-0.5))
        {
            goto label_29;
        }
        
        val_35 = val_12;
        val_36 = -1f;
        goto label_30;
        label_17:
        if((UnityEngine.Object.op_Implicit(exists:  this.centerOnChild)) == false)
        {
            goto label_33;
        }
        
        this.centerOnChild.Recenter();
        goto label_78;
        label_28:
        if((double)val_11.x != 0.5)
        {
            goto label_36;
        }
        
        val_35 = val_12;
        val_36 = 1f;
        label_30:
        val_36 = (float)val_35 + val_36;
        var val_14 = (((long)val_35 & 1) != 0) ? ((float)val_35) : (val_36);
        goto label_45;
        label_33:
        if((this.restrictWithinPanel == false) || (this.与业丌丄且丁丛与丁.clipping == 0))
        {
            goto label_40;
        }
        
        丘丌东丌丐丛丄丅丗 val_40 = this.movement;
        val_38 = 1;
        if((val_40 == 0) || (val_40 == 2))
        {
            goto label_42;
        }
        
        if(val_40 != 3)
        {
            goto label_43;
        }
        
        var val_16 = (this.customMovement != 0f) ? 1 : 0;
        var val_17 = (val_2.y != 0f) ? 1 : 0;
        goto label_44;
        label_29:
        float val_32 = -0.5f;
        val_32 = val_11.x + val_32;
        goto label_45;
        label_36:
        float val_33 = 0.5f;
        val_33 = val_11.x + val_33;
        label_45:
        if(val_11.y >= 0f)
        {
            goto label_46;
        }
        
        if((double)val_11.y != (-0.5))
        {
            goto label_47;
        }
        
        val_40 = val_12;
        val_41 = -1f;
        goto label_48;
        label_46:
        if((double)val_11.y != 0.5)
        {
            goto label_49;
        }
        
        val_40 = val_12;
        val_41 = 1f;
        label_48:
        val_41 = (float)val_40 + val_41;
        var val_18 = (((long)val_40 & 1) != 0) ? ((float)val_40) : (val_41);
        goto label_51;
        label_47:
        float val_34 = -0.5f;
        val_34 = val_11.y + val_34;
        goto label_51;
        label_49:
        float val_35 = 0.5f;
        val_35 = val_11.y + val_35;
        label_51:
        this.与业丌丄且丁丛与丁.clipOffset = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
        UnityEngine.Vector3 val_19 = this.丐一丗丛丕世丘东丁.localPosition;
        if(val_19.x >= 0f)
        {
            goto label_54;
        }
        
        if((double)val_19.x != (-0.5))
        {
            goto label_55;
        }
        
        val_43 = val_12;
        val_44 = -1f;
        goto label_56;
        label_54:
        if((double)val_19.x != 0.5)
        {
            goto label_57;
        }
        
        val_43 = val_12;
        val_44 = 1f;
        label_56:
        val_44 = (float)val_43 + val_44;
        var val_20 = (((long)val_43 & 1) != 0) ? ((float)val_43) : (val_44);
        goto label_59;
        label_55:
        float val_36 = -0.5f;
        val_36 = val_19.x + val_36;
        goto label_59;
        label_57:
        float val_37 = 0.5f;
        val_37 = val_19.x + val_37;
        label_59:
        if(val_19.y >= 0f)
        {
            goto label_60;
        }
        
        if((double)val_19.y != (-0.5))
        {
            goto label_61;
        }
        
        val_46 = val_12;
        val_47 = -1f;
        goto label_62;
        label_60:
        if((double)val_19.y != 0.5)
        {
            goto label_63;
        }
        
        val_46 = val_12;
        val_47 = 1f;
        label_62:
        val_47 = (float)val_46 + val_47;
        var val_21 = (((long)val_46 & 1) != 0) ? ((float)val_46) : (val_47);
        goto label_65;
        label_61:
        float val_38 = -0.5f;
        val_38 = val_19.y + val_38;
        goto label_65;
        label_63:
        float val_39 = 0.5f;
        val_39 = val_19.y + val_39;
        label_65:
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        if(this.smoothDragStart != true)
        {
                this.东丌丈业丙丆丄世丑 = true;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.zero;
            this.且与下七丐东不丛丐 = val_22;
            mem[1152921531130184484] = val_22.y;
            if(this.onDragStarted != null)
        {
                this.onDragStarted.Invoke();
        }
        
        }
        
        val_49 = null;
        val_49 = null;
        val_32 = UICamera.丅丒世丆业丑丏丁丈;
        bool val_24 = val_32.Add(item:  this.gameObject);
        goto label_74;
        label_43:
        val_38 = 0;
        label_42:
        val_40 = val_40 - 1;
        label_44:
        bool val_27 = this.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  (this.dragEffect == 0) ? 1 : 0, 与丐丌万丁丒不业丕:  false, 丌丝三丌丗丄丌丈且:  (val_40 < 2) ? 1 : 0);
        label_40:
        if((this.东丌丈业丙丆丄世丑 != false) && (this.onDragFinished != null))
        {
                this.onDragFinished.Invoke();
        }
        
        if((this.上丁丁丝丄丅丞丌下 != true) && (this.onStoppedMoving != null))
        {
                this.onStoppedMoving.Invoke();
        }
        
        label_78:
        val_50 = null;
        val_50 = null;
        val_32 = UICamera.丅丒世丆业丑丏丁丈;
        bool val_29 = val_32.Remove(item:  this.gameObject);
        label_74:
        if(this.丈丏丂丗丕丞丑上丑 != null)
        {
                this.丈丏丂丗丕丞丑上丑.Invoke(obj:  万东丂丒且丅丛丑丕);
        }
        
        if(this.七丐专与丗与不丂与 == null)
        {
                return;
        }
        
        this.七丐专与丗与不丂与.Invoke(obj:  万东丂丒且丅丛丑丕);
    }
    public void Drag()
    {
        float val_8;
        float val_21;
        丞上且下专丞东专世 val_31;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        UnityEngine.Camera val_37;
        float val_38;
        float val_39;
        var val_40;
        float val_41;
        float val_42;
        var val_43;
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_51;
        float val_55;
        float val_56;
        float val_57;
        float val_61;
        var val_62;
        val_31 = 1152921505096622080;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(this.上丁丁丝丄丅丞丌下 == false)
        {
                return;
        }
        
        val_33 = null;
        if(this.丑丏专丕丄丝一丒不 == 10)
        {
                val_33 = null;
            this.丑丏专丕丄丝一丒不 = UICamera.currentTouchID;
        }
        
        val_33 = null;
        UICamera.currentTouch.丌下丐上丛丘丗万丅 = 2;
        if(this.smoothDragStart == false)
        {
            goto label_15;
        }
        
        if(this.东丌丈业丙丆丄世丑 != true)
        {
                this.东丌丈业丙丆丄世丑 = true;
            val_34 = null;
            val_34 = null;
            this.且与下七丐东不丛丐 = UICamera.currentTouch.东丞不不丙丁丄下且;
            mem[1152921531130435716] = UICamera.currentTouch + 44 + 4;
            if(this.onDragStarted != null)
        {
                this.onDragStarted.Invoke();
        }
        
        }
        
        val_35 = null;
        if(this.smoothDragStart == false)
        {
            goto label_21;
        }
        
        val_36 = null;
        val_31 = UICamera.currentTouch;
        val_37 = UICamera.currentCamera;
        val_38 = UICamera.currentTouch.下业丕七东丌丝下且;
        val_39 = UICamera.currentTouch + 20 + 4;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_38, y = val_39}, b:  new UnityEngine.Vector2() {x = this.且与下七丐东不丛丐, y = V9.16B});
        goto label_27;
        label_15:
        val_40 = null;
        goto label_31;
        label_21:
        val_40 = null;
        label_31:
        val_31 = UICamera.currentTouch;
        val_37 = UICamera.currentCamera;
        val_38 = UICamera.currentTouch.下业丕七东丌丝下且;
        val_39 = UICamera.currentTouch + 20 + 4;
        label_27:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_38, y = val_39});
        val_41 = val_6.x;
        val_42 = val_6.z;
        UnityEngine.Ray val_7 = val_37.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_41, y = val_6.y, z = val_42});
        if((this.丑丞丗专丁丕丂丁丅 & 1) == 0)
        {
                return;
        }
        
        val_43 = 0;
        val_31 = 1152921504838316032;
        val_44 = val_8;
        val_45 = 0f;
        val_46 = val_44;
        val_47 = val_42;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = val_46, z = val_47}, b:  new UnityEngine.Vector3() {x = this.专丟丆丛丁七下三丝, y = val_6.y, z = val_41});
        val_42 = val_10.x;
        val_51 = val_10.y;
        val_41 = val_10.z;
        this.专丟丆丛丁七下三丝 = 0f;
        mem[1152921531130435652] = val_44;
        mem[1152921531130435656] = val_42;
        if((val_42 == 0f) && (val_51 == 0f))
        {
                if(val_41 == 0f)
        {
            goto label_41;
        }
        
        }
        
        UnityEngine.Vector3 val_11 = this.丐一丗丛丕世丘东丁.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_42, y = val_51, z = val_41});
        val_55 = val_11.x;
        val_56 = val_11.y;
        if(this.movement == 2)
        {
            goto label_43;
        }
        
        if(this.movement == 1)
        {
            goto label_44;
        }
        
        if(this.movement != 0)
        {
            goto label_45;
        }
        
        val_57 = 0f;
        val_56 = 0f;
        goto label_48;
        label_43:
        val_57 = 0f;
        goto label_48;
        label_44:
        val_57 = 0f;
        val_55 = 0f;
        goto label_48;
        label_45:
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.customMovement, y = val_55});
        val_55 = 0f;
        val_56 = 0f;
        val_57 = 0f;
        label_48:
        val_45 = val_55;
        val_46 = val_56;
        val_47 = val_57;
        val_43 = 0;
        UnityEngine.Vector3 val_13 = this.丐一丗丛丕世丘东丁.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_55, y = val_56, z = val_57});
        val_42 = val_13.x;
        val_51 = val_13.y;
        val_41 = val_13.z;
        label_41:
        if(this.dragEffect != 0)
        {
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_42, y = val_51, z = val_41}, d:  this.momentumAmount * 0.01f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = val_44, z = 0f}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_45 = this.七丐丁丆上丒丄丏三;
            val_46 = val_44;
            val_47 = 0f;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = 0f}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, t:  0.67f);
        }
        else
        {
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        }
        
        this.七丐丁丆上丒丄丏三 = val_18;
        mem[1152921531130435668] = val_18.y;
        mem[1152921531130435672] = val_18.z;
        if((this.iOSDragEmulation == false) || (this.dragEffect != 2))
        {
            goto label_59;
        }
        
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = val_18.y, z = val_18.z});
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21, y = val_19.y, z = val_18.z});
        val_42 = val_42;
        val_41 = val_41;
        if(val_19.x <= 1f)
        {
            goto label_75;
        }
        
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_42, y = val_51, z = val_41}, d:  0.5f);
        this.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = val_23.y, z = val_23.z}, d:  0.5f);
        this.七丐丁丆上丒丄丏三 = val_24;
        mem[1152921531130435668] = val_24.y;
        mem[1152921531130435672] = val_24.z;
        goto label_66;
        label_59:
        val_61 = val_51;
        label_75:
        this.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_42, y = val_61, z = val_41});
        label_66:
        if(this.restrictWithinPanel == false)
        {
                return;
        }
        
        if(this.与业丌丄且丁丛与丁.clipping == 0)
        {
                return;
        }
        
        if(this.dragEffect == 2)
        {
                return;
        }
        
        丘丌东丌丐丛丄丅丗 val_30 = this.movement;
        val_62 = 1;
        if((val_30 == 0) || (val_30 == 2))
        {
            goto label_72;
        }
        
        if(val_30 != 3)
        {
            goto label_73;
        }
        
        var val_26 = (this.customMovement != 0f) ? 1 : 0;
        var val_27 = (val_61 != 0f) ? 1 : 0;
        goto label_74;
        label_73:
        val_62 = 0;
        label_72:
        val_30 = val_30 - 1;
        label_74:
        bool val_29 = this.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  true, 与丐丌万丁丒不业丕:  false, 丌丝三丌丗丄丌丈且:  (val_30 < 2) ? 1 : 0);
    }
    public void Scroll(float 丞且丅三三东不丄且)
    {
        float val_8;
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(this.scrollWheelFactor == 0f)
        {
                return;
        }
        
        this.DisableSpring();
        UIScrollView val_5 = ((this.上丁丁丝丄丅丞丌下 == true) ? 1 : 0) | this;
        val_5 = val_5 & 1;
        this.上丁丁丝丄丅丞丌下 = val_5;
        if((UnityEngine.Mathf.Sign(f:  this.丈世丙业业七丟不丒)) != (UnityEngine.Mathf.Sign(f:  丞且丅三三东不丄且)))
        {
                val_8 = 0f;
            this.丈世丙业业七丟不丒 = 0f;
        }
        else
        {
                val_8 = this.丈世丙业业七丟不丒;
        }
        
        float val_8 = this.scrollWheelFactor;
        val_8 = val_8 * 丞且丅三三东不丄且;
        val_8 = val_8 + val_8;
        this.丈世丙业业七丟不丒 = val_8;
    }
    private void LateUpdate()
    {
        var val_39;
        float val_40;
        float val_41;
        UIProgressBar val_42;
        UnityEngine.Vector3 val_43;
        var val_44;
        UnityEngine.Vector3 val_45;
        float val_46;
        float val_47;
        var val_48;
        float val_49;
        var val_53;
        if(this.isExtended != false)
        {
                this.丞与一丙业业七丏丁();
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        float val_2 = RealTime.deltaTime;
        if(this.showScrollBars == 0)
        {
            goto label_29;
        }
        
        val_39 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.verticalScrollBar)) == true)
        {
            goto label_6;
        }
        
        val_39 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.horizontalScrollBar)) == false)
        {
            goto label_29;
        }
        
        label_6:
        if((this.showScrollBars == 2) && (this.丑丏专丕丄丝一丒不 == 10))
        {
                val_39 = 0;
            if(val_2 <= 0.01f)
        {
            goto label_55;
        }
        
        }
        
        label_55:
        if((UnityEngine.Object.op_Implicit(exists:  this.verticalScrollBar)) != false)
        {
                val_40 = 6f;
            float val_7 = (this != 1) ? (val_40) : -3f;
            val_7 = val_2 * val_7;
            val_41 = val_7 + this.verticalScrollBar.alpha;
            float val_9 = UnityEngine.Mathf.Clamp01(value:  val_41);
            if(this.verticalScrollBar.alpha != val_9)
        {
                val_41 = val_9;
            this.verticalScrollBar.alpha = val_41;
        }
        
        }
        
        val_42 = this.horizontalScrollBar;
        if((UnityEngine.Object.op_Implicit(exists:  val_42)) != false)
        {
                val_42 = this.horizontalScrollBar;
            val_40 = 6f;
            float val_13 = (this != 1) ? (val_40) : -3f;
            val_13 = val_2 * val_13;
            val_41 = val_13 + val_42.alpha;
            float val_15 = UnityEngine.Mathf.Clamp01(value:  val_41);
            if(this.horizontalScrollBar.alpha != val_15)
        {
                val_41 = val_15;
            this.horizontalScrollBar.alpha = val_41;
        }
        
        }
        
        label_29:
        if(this.上丁丁丝丄丅丞丌下 == false)
        {
                return;
        }
        
        if(this.且丙万丞东丗下丝丅 == false)
        {
            goto label_32;
        }
        
        if(this.isExtended == false)
        {
            goto label_33;
        }
        
        if((this.GetComponent<SpringPanel>()) != 0)
        {
                val_17.lerpFactor = 0f;
        }
        
        val_43 = this.七丐丁丆上丒丄丏三;
        this.丈世丙业业七丟不丒 = 0f;
        if(this.isExtended == false)
        {
            goto label_38;
        }
        
        goto label_39;
        label_32:
        if(val_41 <= 0.0001f)
        {
                val_40 = 1E-05f;
            if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  this.丈世丙业业七丟不丒, 丒丈丙丐丏丕丆万丗:  0f, 丌丕丗七丒丛万丒东:  val_40)) != false)
        {
                this.丈世丙业业七丟不丒 = 0f;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            this.七丐丁丆上丒丄丏三 = val_20;
            mem[1152921531130823476] = val_20.y;
            mem[1152921531130823480] = val_20.z;
            SpringPanel val_21 = this.GetComponent<SpringPanel>();
            if(val_21 != 0)
        {
                if(val_21.enabled == true)
        {
                return;
        }
        
        }
        
            this.上丁丁丝丄丅丞丌下 = false;
            if(this.onStoppedMoving == null)
        {
                return;
        }
        
            this.onStoppedMoving.Invoke();
            return;
        }
        
        }
        
        if(this.movement == 1)
        {
            goto label_52;
        }
        
        if(this.movement != 0)
        {
            goto label_53;
        }
        
        val_44 = this;
        float val_37 = this.丈世丙业业七丟不丒;
        val_45 = this.七丐丁丆上丒丄丏三;
        val_46 = mem[1152921531130823476];
        val_47 = mem[1152921531130823480];
        val_42 = this.丐一丗丛丕世丘东丁;
        val_37 = val_37 * 0.05f;
        val_48 = 0f;
        goto label_56;
        label_33:
        val_43 = this.七丐丁丆上丒丄丏三;
        this.丈世丙业业七丟不丒 = 0f;
        label_38:
        label_39:
        UnityEngine.Vector3 val_24 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = val_43, y = val_43, z = val_43}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  val_2);
        return;
        label_52:
        val_44 = this;
        val_45 = this.七丐丁丆上丒丄丏三;
        val_46 = mem[1152921531130823476];
        val_47 = mem[1152921531130823480];
        val_42 = val_42;
        val_48 = this.丈世丙业业七丟不丒 * 0.05f;
        goto label_56;
        label_53:
        val_44 = this;
        float val_38 = this.丈世丙业业七丟不丒;
        val_45 = this.七丐丁丆上丒丄丏三;
        val_46 = mem[1152921531130823476];
        val_47 = mem[1152921531130823480];
        val_42 = val_42;
        if(this.movement != 2)
        {
            goto label_57;
        }
        
        val_38 = val_38 * 0.05f;
        val_48 = val_38;
        goto label_58;
        label_57:
        UnityEngine.Vector2 val_39 = this.customMovement;
        val_39 = val_38 * val_39;
        val_40 = val_38 * val_40;
        val_38 = val_39 * 0.05f;
        val_48 = val_40 * 0.05f;
        label_56:
        label_58:
        UnityEngine.Vector3 val_25 = val_42.TransformDirection(direction:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_47}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        this.七丐丁丆上丒丄丏三 = val_26;
        mem[1152921531130823476] = val_26.y;
        mem[1152921531130823480] = val_26.z;
        this.丈世丙业业七丟不丒 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  this.丈世丙业业七丟不丒, 专丂丕丗丗东世丞下:  0f, 丛上丟丌丄丗丁世与:  20f, 丑丗丘与丈不七东丛:  val_2);
        if(this.isExtended != false)
        {
                val_49 = val_2;
            UnityEngine.Vector3 val_28 = UIScrollView.SpringDampen(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = this.七丐丁丆上丒丄丏三, z = this.七丐丁丆上丒丄丏三}, 丛上丟丌丄丗丁世与:  2f, 丑丗丘与丈不七东丛:  val_49);
        }
        else
        {
                val_49 = val_2;
            UnityEngine.Vector3 val_29 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = this.七丐丁丆上丒丄丏三, y = this.七丐丁丆上丒丄丏三, z = this.七丐丁丆上丒丄丏三}, 丛上丟丌丄丗丁世与:  this.dampenStrength, 丑丗丘与丈不七东丛:  val_49);
        }
        
        this.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        if((this.restrictWithinPanel == false) || (this.与业丌丄且丁丛与丁.clipping == 0))
        {
            goto label_82;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this.centerOnChild)) == false)
        {
            goto label_71;
        }
        
        if(this.centerOnChild.nextPageThreshold != 0f)
        {
            goto label_73;
        }
        
        this.centerOnChild.Recenter();
        goto label_82;
        label_71:
        丘丌东丌丐丛丄丅丗 val_40 = this.movement;
        val_53 = 1;
        if((val_40 == 0) || (val_40 == 2))
        {
            goto label_77;
        }
        
        if(val_40 != 3)
        {
            goto label_78;
        }
        
        var val_32 = (this.customMovement != 0f) ? 1 : 0;
        var val_33 = (val_29.y != 0f) ? 1 : 0;
        goto label_79;
        label_73:
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
        this.七丐丁丆上丒丄丏三 = val_34;
        mem[1152921531130823476] = val_34.y;
        mem[1152921531130823480] = val_34.z;
        this.丈世丙业业七丟不丒 = 0f;
        goto label_82;
        label_78:
        val_53 = 0;
        label_77:
        val_40 = val_40 - 1;
        label_79:
        bool val_36 = this.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  false, 与丐丌万丁丒不业丕:  false, 丌丝三丌丗丄丌丈且:  (val_40 < 2) ? 1 : 0);
        label_82:
        if(this.onMomentumMove == null)
        {
                return;
        }
        
        this.onMomentumMove.Invoke();
    }
    public void StopMomentumForce()
    {
        this.丈世丙业业七丟不丒 = 0f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.七丐丁丆上丒丄丏三 = val_1;
        mem[1152921531131037876] = val_1.y;
        mem[1152921531131037880] = val_1.z;
        this.DisableSpring();
        this.上丁丁丝丄丅丞丌下 = false;
        if(this.onStoppedMoving == null)
        {
                return;
        }
        
        this.onStoppedMoving.Invoke();
    }
    public void OnPan(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.horizontalScrollBar, y:  0);
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.verticalScrollBar, y:  0);
        if(this.horizontalScrollBar != 0)
        {
                return;
        }
        
        if(this.verticalScrollBar != 0)
        {
                return;
        }
        
        if(this.scale != 0f)
        {
            
        }
        else
        {
                if(this.scale == 0f)
        {
                return;
        }
        
        }
        
        this.Scroll(丞且丅三三东不丄且:  丞且丅三三东不丄且.y);
    }
    public UIScrollView()
    {
        this.dragEffect = 2;
        this.restrictWithinPanel = true;
        this.smoothDragStart = true;
        this.iOSDragEmulation = true;
        this.scrollWheelFactor = 0.25f;
        this.momentumAmount = 35f;
        this.dampenStrength = 9f;
        this.showScrollBars = true;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  1f, y:  0f);
        this.customMovement = val_1.x;
        mem[1152921531131315000] = val_1.y;
        this.scale = 0;
        mem[1152921531131315056] = 0;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.relativePositionOnReset = val_2;
        mem[1152921531131315064] = val_2.y;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.七丐丁丆上丒丄丏三 = val_3;
        mem[1152921531131315124] = val_3.y;
        mem[1152921531131315128] = val_3.z;
        this.丑丏专丕丄丝一丒不 = 9;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.且与下七丐东不丛丐 = val_4;
        mem[1152921531131315172] = val_4.y;
        this.moveRelativeValue = 1f;
    }
    private static UIScrollView()
    {
        UIScrollView.list = new 丒丞丕丕七丁丗丟丛<UIScrollView>();
    }

}
