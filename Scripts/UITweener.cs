using UnityEngine;
public abstract class UITweener : MonoBehaviour
{
    // Fields
    public static UITweener current;
    public UITweener.丞丝不丐丘不丕丞不 method;
    public UITweener.丄丏东专与世三丂一 style;
    public UnityEngine.AnimationCurve animationCurve;
    public bool ignoreTimeScale;
    public float delay;
    public float duration;
    public bool steeperCurves;
    public int tweenGroup;
    public System.Collections.Generic.List<EventDelegate> onFinished;
    public UnityEngine.GameObject eventReceiver;
    public string callWhenFinished;
    private bool 不世丌丝且三上丏丌;
    private float 丟一三不丗一丑丄丒;
    private float 丁丟丝丙丏丙丐丑丈;
    private float 与业丂丗丟丗丁七丕;
    private float 丟业丏丒丘丂东一丙;
    private System.Collections.Generic.List<EventDelegate> 丑下丅三万下丌丈丒;
    
    // Properties
    public float 东专七丁丈且丌丁上 { get; }
    public float 丈东下丅丁丑上丅上 { get; set; }
    public AnimationOrTween.丟世丆丕丌且七下丂 丒丈丘业丛丁丏丙丘 { get; }
    
    // Methods
    public float get_amountPerDelta()
    {
        if(this.丁丟丝丙丏丙丐丑丈 == this.duration)
        {
                return val_2;
        }
        
        this.丁丟丝丙丏丙丐丑丈 = this.duration;
        float val_3 = 1f;
        val_3 = val_3 / this.duration;
        float val_2 = UnityEngine.Mathf.Sign(f:  this.与业丂丗丟丗丁七丕);
        val_2 = (System.Math.Abs((this.duration > 0f) ? (val_3) : 1000f)) * val_2;
        this.与业丂丗丟丗丁七丕 = val_2;
        return val_2;
    }
    public float get_tweenFactor()
    {
        return (float)this.丟业丏丒丘丂东一丙;
    }
    public void set_tweenFactor(float 丙业与丙丗丝不丈东)
    {
        this.丟业丏丒丘丂东一丙 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public AnimationOrTween.丟世丆丕丌且七下丂 get_direction()
    {
        return (AnimationOrTween.丟世丆丕丌且七下丂)(this.amountPerDelta < 0) ? 0 : (0 + 1);
    }
    private void Reset()
    {
        if(this.不世丌丝且三上丏丌 == false)
        {
            goto typeof(UITweener).__il2cppRuntimeField_198;
        }
    
    }
    protected virtual void Start()
    {
        this.Update();
    }
    private void Update()
    {
        float val_13;
        float val_14;
        丄丏东专与世三丂一 val_15;
        float val_16;
        var val_17;
        System.Collections.Generic.List<EventDelegate> val_18;
        if(this.ignoreTimeScale != false)
        {
                float val_1 = RealTime.deltaTime;
        }
        
        val_13 = UnityEngine.Time.deltaTime;
        if(this.ignoreTimeScale != false)
        {
                float val_3 = RealTime.time;
        }
        else
        {
                float val_4 = UnityEngine.Time.time;
        }
        
        if(this.不世丌丝且三上丏丌 != false)
        {
                val_14 = this.丟一三不丗一丑丄丒;
        }
        else
        {
                this.不世丌丝且三上丏丌 = true;
            val_14 = val_4 + this.delay;
            this.丟一三不丗一丑丄丒 = val_14;
        }
        
        if(val_4 < 0)
        {
                return;
        }
        
        float val_5 = this.amountPerDelta;
        val_15 = this.style;
        val_5 = val_13 * val_5;
        val_13 = this.丟业丏丒丘丂东一丙 + val_5;
        this.丟业丏丒丘丂东一丙 = val_13;
        if(val_15 == 2)
        {
            goto label_8;
        }
        
        if(val_15 != 1)
        {
            goto label_9;
        }
        
        if(val_13 <= 1f)
        {
            goto label_45;
        }
        
        val_13 = val_13 - 1f;
        this.丟业丏丒丘丂东一丙 = val_13;
        goto label_18;
        label_8:
        if(val_13 <= 1f)
        {
            goto label_14;
        }
        
        val_5 = val_13 - val_5;
        val_13 = 1f - val_5;
        this.丟业丏丒丘丂东一丙 = val_13;
        val_16 = -this.与业丂丗丟丗丁七丕;
        goto label_17;
        label_14:
        if(val_13 >= 0)
        {
            goto label_18;
        }
        
        this.丟业丏丒丘丂东一丙 = -val_13;
        val_13 = (-val_13) - val_14;
        this.丟业丏丒丘丂东一丙 = val_13;
        val_16 = -this.与业丂丗丟丗丁七丕;
        label_17:
        this.与业丂丗丟丗丁七丕 = val_16;
        label_18:
        val_15 = this.style;
        label_9:
        if(val_15 == 0)
        {
            goto label_21;
        }
        
        label_45:
        this.Sample(丞上与七且与七三丐:  val_13, 丄上且东丙丘丙丈丕:  false);
        return;
        label_21:
        if(this.duration != 0f)
        {
            goto label_22;
        }
        
        label_46:
        float val_6 = UnityEngine.Mathf.Clamp01(value:  val_13);
        this.丟业丏丒丘丂东一丙 = val_6;
        this.Sample(丞上与七且与七三丐:  val_6, 丄上且东丙丘丙丈丕:  true);
        this.enabled = false;
        if(UITweener.current == this)
        {
                return;
        }
        
        UITweener.current = this;
        if(this.onFinished == null)
        {
            goto label_28;
        }
        
        this.丑下丅三万下丌丈丒 = this.onFinished;
        this.onFinished = new System.Collections.Generic.List<EventDelegate>();
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.丑下丅三万下丌丈丒);
        val_17 = 0;
        goto label_31;
        label_38:
        EventDelegate val_9 = this.丑下丅三万下丌丈丒.Item[0];
        if((val_9 != null) && (val_9.oneShot != true))
        {
                EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.onFinished, 丙不不丒丁丄丄与丛:  val_9, 丕万三专丕不七专丐:  false);
        }
        
        val_17 = 1;
        label_31:
        val_18 = this.丑下丅三万下丌丈丒;
        if(val_17 < val_18.Count)
        {
            goto label_38;
        }
        
        this.丑下丅三万下丌丈丒 = 0;
        label_28:
        if(this.eventReceiver != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.callWhenFinished)) != true)
        {
                val_18 = this.callWhenFinished;
            this.eventReceiver.SendMessage(methodName:  val_18, value:  this, options:  1);
        }
        
        }
        
        UITweener.current = UITweener.current;
        return;
        label_22:
        if(val_13 > 1f)
        {
            goto label_46;
        }
        
        if(val_13 >= 0)
        {
            goto label_45;
        }
        
        goto label_46;
    }
    public void SetOnFinished(EventDelegate.丒万业丛丏东专世丟 世不与丐万万丕丆万)
    {
        EventDelegate val_1 = EventDelegate.丅专下万丕丑丆丅丝(丝丘丑业丛万丞丌丝:  this.onFinished, 业丏丈世世世丞丒世:  世不与丐万万丕丆万);
    }
    public void SetOnFinished(EventDelegate 世不与丐万万丕丆万)
    {
        EventDelegate.丅专下万丕丑丆丅丝(丝丘丑业丛万丞丌丝:  this.onFinished, 世不与丐万万丕丆万:  世不与丐万万丕丆万);
    }
    public void AddOnFinished(EventDelegate.丒万业丛丏东专世丟 世不与丐万万丕丆万)
    {
        EventDelegate val_1 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.onFinished, 业丏丈世世世丞丒世:  世不与丐万万丕丆万);
    }
    public void AddOnFinished(EventDelegate 世不与丐万万丕丆万)
    {
        EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.onFinished, 丙不不丒丁丄丄与丛:  世不与丐万万丕丆万);
    }
    public void RemoveOnFinished(EventDelegate 世不与丐万万丕丆万)
    {
        if(this.onFinished != null)
        {
                bool val_1 = this.onFinished.Remove(item:  世不与丐万万丕丆万);
        }
        
        if(this.丑下丅三万下丌丈丒 == null)
        {
                return;
        }
        
        bool val_2 = this.丑下丅三万下丌丈丒.Remove(item:  世不与丐万万丕丆万);
    }
    private void OnDisable()
    {
        this.不世丌丝且三上丏丌 = false;
    }
    public void Sample(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_9;
        丞丝不丐丘不丕丞不 val_8 = this.method;
        val_9 = UnityEngine.Mathf.Clamp01(value:  丞上与七且与七三丐);
        val_8 = val_8 - 1;
        if(val_8 <= 4)
        {
                var val_9 = 106054308 + ((this.method - 1)) << 2;
            val_9 = val_9 + 106054308;
        }
        else
        {
                if(this.animationCurve != null)
        {
                val_9 = this.animationCurve.Evaluate(time:  null);
        }
        
            bool val_7 = 丄上且东丙丘丙丈丕;
        }
    
    }
    private float 丗丕专丐丟七丘世下(float 下下丏一丙不丘丌丞)
    {
        if(下下丏一丙不丘丌丞 < 0)
        {
                float val_1 = 7.5685f;
            val_1 = 下下丏一丙不丘丌丞 * val_1;
            下下丏一丙不丘丌丞 = val_1 * 下下丏一丙不丘丌丞;
            return (float)下下丏一丙不丘丌丞;
        }
        
        if(下下丏一丙不丘丌丞 < 0)
        {
                float val_2 = -0.545454f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_2;
            val_2 = 下下丏一丙不丘丌丞 * 7.5625f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_2;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 0.75f;
            return (float)下下丏一丙不丘丌丞;
        }
        
        if(下下丏一丙不丘丌丞 < 0)
        {
                float val_3 = -0.818181f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_3;
            val_3 = 下下丏一丙不丘丌丞 * 7.5625f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_3;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 0.9375f;
            return (float)下下丏一丙不丘丌丞;
        }
        
        float val_4 = -0.9545454f;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_4;
        val_4 = 下下丏一丙不丘丌丞 * 7.5625f;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_4;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 0.984375f;
        return (float)下下丏一丙不丘丌丞;
    }
    public void Play()
    {
        this.Play(且丒且丐丌东专三丁:  true);
    }
    public void PlayForward()
    {
        this.不世丌丝且三上丏丌 = false;
        this.丟业丏丒丘丂东一丙 = 0f;
        this.Sample(丞上与七且与七三丐:  0f, 丄上且东丙丘丙丈丕:  false);
        this.Play(且丒且丐丌东专三丁:  true);
    }
    public void PlayReverse()
    {
        this.Play(且丒且丐丌东专三丁:  false);
    }
    public void Play(bool 且丒且丐丌东专三丁)
    {
        float val_2 = System.Math.Abs(this.amountPerDelta);
        val_2 = (且丒且丐丌东专三丁 != true) ? (val_2) : (-val_2);
        this.与业丂丗丟丗丁七丕 = val_2;
        this.enabled = true;
        this.Update();
    }
    public void ResetToBeginning()
    {
        this.不世丌丝且三上丏丌 = false;
        this.丟业丏丒丘丂东一丙 = 0f;
        this.Sample(丞上与七且与七三丐:  0f, 丄上且东丙丘丙丈丕:  false);
    }
    public void Toggle()
    {
        float val_2;
        float val_1 = this.amountPerDelta;
        if(this.丟业丏丒丘丂东一丙 > 0f)
        {
                val_2 = -val_1;
        }
        else
        {
                val_2 = System.Math.Abs(val_1);
        }
        
        this.与业丂丗丟丗丁七丕 = val_2;
        this.enabled = true;
    }
    protected abstract void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕); // 0
    public static T Begin<T>(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏)
    {
        UnityEngine.AnimationCurve val_13;
        UnityEngine.Object val_14;
        UnityEngine.Object val_15;
        var val_16;
        val_13 = __RuntimeMethodHiddenParam;
        val_14 = 丝三丁东丈丒世丅业;
        val_15 = val_14;
        if((val_15 == 0) || (null == 0))
        {
            goto label_16;
        }
        
        if((__RuntimeMethodHiddenParam + 48 + 16) < 1)
        {
            goto label_9;
        }
        
        val_16 = (__RuntimeMethodHiddenParam + 48 + 16) & 4294967295;
        var val_12 = 0;
        UnityEngine.GameObject val_2 = val_14 + 32;
        goto label_10;
        label_17:
        label_10:
        bool val_3 = UnityEngine.Object.op_Inequality(x:  1152921504834002944, y:  0);
        val_12 = val_12 + 1;
        if(val_12 < (long)val_16)
        {
            goto label_17;
        }
        
        label_9:
        val_15 = 0;
        label_16:
        if(val_15 == 0)
        {
                val_15 = val_14;
            if(val_15 == 0)
        {
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Unable to add {0} to {1}", arg0:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 32}), arg1:  不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  val_14)), context:  val_14);
            val_15 = 0;
            return (object)val_15;
        }
        
        }
        
        if(val_15 != 0)
        {
                mem[88] = 0;
            mem[48] = 与丈业丛丝丒丙一丏;
            mem[104] = 0;
        }
        else
        {
                mem[88] = 0;
            mem[48] = 与丈业丛丝丒丙一丏;
            mem[104] = 0;
        }
        
        float val_13 = System.Math.Abs(this.amountPerDelta);
        if(val_15 != 0)
        {
                mem[100] = val_13;
        }
        else
        {
                mem[100] = val_13;
        }
        
        mem[28] = 0;
        UnityEngine.Keyframe[] val_10 = new UnityEngine.Keyframe[2];
        val_14 = val_10;
        val_14[0] = 0;
        val_14[0] = 0;
        val_14[1] = 0;
        val_14[1] = 0;
        UnityEngine.AnimationCurve val_11 = null;
        val_13 = val_11;
        val_11 = new UnityEngine.AnimationCurve(keys:  val_10);
        mem[32] = val_13;
        mem[72] = 0;
        mem[80] = 0;
        val_15.enabled = true;
        return (object)val_15;
    }
    public virtual void SetStartToCurrentValue()
    {
    
    }
    public virtual void SetEndToCurrentValue()
    {
    
    }
    public virtual void ResetToStert()
    {
        this.enabled = false;
        this.不世丌丝且三上丏丌 = false;
        this.丟业丏丒丘丂东一丙 = 0f;
        this.Sample(丞上与七且与七三丐:  0f, 丄上且东丙丘丙丈丕:  false);
    }
    public virtual void ResetToEnd()
    {
        this.enabled = false;
        this.不世丌丝且三上丏丌 = false;
        this.丟业丏丒丘丂东一丙 = 1f;
        this.Sample(丞上与七且与七三丐:  1f, 丄上且东丙丘丙丈丕:  false);
    }
    protected UITweener()
    {
        UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[2];
        val_1[0] = 0;
        val_1[0] = 0;
        val_1[1] = 0;
        val_1[1] = 0;
        this.animationCurve = new UnityEngine.AnimationCurve(keys:  val_1);
        this.ignoreTimeScale = true;
        this.duration = 1f;
        this.onFinished = new System.Collections.Generic.List<EventDelegate>();
        this.与业丂丗丟丗丁七丕 = 1000f;
    }

}
