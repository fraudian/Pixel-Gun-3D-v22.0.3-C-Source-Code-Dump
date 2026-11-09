using UnityEngine;
public class ActiveAnimation : MonoBehaviour
{
    // Fields
    public static ActiveAnimation current;
    public System.Collections.Generic.List<EventDelegate> onFinished;
    public UnityEngine.GameObject eventReceiver;
    public string callWhenFinished;
    private UnityEngine.Animation 三上下丁丅丅下上丑;
    private AnimationOrTween.丟世丆丕丌且七下丂 丝丛丒丝丝且丕丙专;
    private AnimationOrTween.丟世丆丕丌且七下丂 丁上丙丆专丗且丁丗;
    private bool 一丈万与丈丐丒三丞;
    private UnityEngine.Animator 丒丂不丞丁丝不专丝;
    private string 丝丞丈上丟丐下丞不;
    
    // Properties
    private float 专七丗上丐丆丟丆丑 { get; }
    public bool 下丐丈丄丗丞丕业丆 { get; }
    
    // Methods
    private float 世丆丏丆与丁丒七丆()
    {
        float val_3;
        UnityEngine.AnimatorStateInfo val_1 = this.丒丂不丞丁丝不专丝.GetCurrentAnimatorStateInfo(layerIndex:  0);
        return (float)UnityEngine.Mathf.Clamp01(value:  val_3);
    }
    public bool get_isPlaying()
    {
        UnityEngine.Animator val_14;
        var val_17;
        UnityEngine.Animation val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if(this.三上下丁丅丅下上丑 != 0)
        {
            goto label_3;
        }
        
        val_14 = this.丒丂不丞丁丝不专丝;
        if(val_14 == 0)
        {
            goto label_59;
        }
        
        val_14 = this.丝丛丒丝丝且丕丙专;
        float val_3 = this.世丆丏丆与丁丒七丆();
        if(val_14 == 1)
        {
            goto label_7;
        }
        
        if(val_3 != 1f)
        {
            goto label_8;
        }
        
        goto label_59;
        label_3:
        System.Collections.IEnumerator val_4 = this.三上下丁丅丅下上丑.GetEnumerator();
        label_34:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_17 = val_4.Current;
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        val_18 = this.三上下丁丅丅下上丑;
        val_17 = 0;
        val_19 = 1;
        goto label_24;
        label_23:
        val_18 = this.三上下丁丅丅下上丑;
        val_19 = 0;
        label_24:
        if((val_18.IsPlaying(name:  val_17.name)) == false)
        {
            goto label_34;
        }
        
        if(this.丝丛丒丝丝且丕丙专 == 1)
        {
            goto label_27;
        }
        
        if(this.丝丛丒丝丝且丕丙专 != 1)
        {
            goto label_32;
        }
        
        float val_13 = val_17.length;
        if(val_17.time >= 0)
        {
            goto label_34;
        }
        
        goto label_32;
        label_27:
        if(val_17.time <= 0f)
        {
            goto label_34;
        }
        
        label_32:
        val_20 = 0;
        val_21 = 0;
        val_22 = 1;
        goto label_38;
        label_7:
        if(val_3 == 0f)
        {
            goto label_59;
        }
        
        label_8:
        val_22 = 1;
        return (bool)val_22;
        label_16:
        val_20 = 0;
        val_21 = 0;
        val_22 = 0;
        label_38:
        val_14 = val_4;
        if(val_14 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_14.Dispose();
        }
        
        if( == 1)
        {
            goto label_54;
        }
        
        if(200 == 202)
        {
                return (bool)val_22;
        }
        
        val_22 = 0;
        if( == false)
        {
                return (bool)val_22;
        }
        
        if(200 != 200)
        {
            goto label_57;
        }
        
        return (bool)val_22;
        label_54:
        if( == false)
        {
            goto label_59;
        }
        
        label_57:
        label_59:
        val_22 = 0;
        return (bool)val_22;
    }
    public void Finish()
    {
        UnityEngine.Animation val_10;
        var val_11;
        var val_14;
        var val_15;
        val_10 = this;
        val_11 = 1152921504848912384;
        if(this.三上下丁丅丅下上丑 == 0)
        {
            goto label_3;
        }
        
        System.Collections.IEnumerator val_2 = this.三上下丁丅丅下上丑.GetEnumerator();
        label_24:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_10;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = val_2.Current;
        if((val_14 != null) && (null != null))
        {
                val_14 = 0;
        }
        
        if(this.丝丛丒丝丝且丕丙专 == 1)
        {
            goto label_18;
        }
        
        if(this.丝丛丒丝丝且丕丙专 != 1)
        {
            goto label_24;
        }
        
        val_14.time = val_14.length;
        goto label_24;
        label_18:
        val_14.time = 0f;
        goto label_24;
        label_3:
        if(this.丒丂不丞丁丝不专丝 == 0)
        {
                return;
        }
        
        this.丒丂不丞丁丝不专丝.Play(stateName:  this.丝丞丈上丟丐下丞不, layer:  0, normalizedTime:  (this.丝丛丒丝丝且丕丙专 == 1) ? 1f : 0f);
        return;
        label_10:
        val_15 = 0;
        val_11 = 0;
        if(val_2 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_2.Dispose();
        }
        
        val_10 = this.三上下丁丅丅下上丑;
        val_10.Sample();
    }
    public void Reset()
    {
        string val_10;
        var val_13;
        var val_14;
        var val_15;
        val_10 = this;
        if(this.三上下丁丅丅下上丑 == 0)
        {
            goto label_40;
        }
        
        System.Collections.IEnumerator val_2 = this.三上下丁丅丅下上丑.GetEnumerator();
        label_24:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_10;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = val_2.Current;
        if((val_13 != null) && (null != null))
        {
                val_13 = 0;
        }
        
        if(this.丝丛丒丝丝且丕丙专 == 1)
        {
            goto label_18;
        }
        
        if(this.丝丛丒丝丝且丕丙专 != 1)
        {
            goto label_24;
        }
        
        val_13.time = 0f;
        goto label_24;
        label_18:
        val_13.time = val_13.length;
        goto label_24;
        label_10:
        val_14 = 0;
        val_15 = 0;
        if(val_2 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        label_40:
        if(this.丒丂不丞丁丝不专丝 == 0)
        {
                return;
        }
        
        val_10 = this.丝丞丈上丟丐下丞不;
        this.丒丂不丞丁丝不专丝.Play(stateName:  val_10, layer:  0, normalizedTime:  (this.丝丛丒丝丝且丕丙专 == 1) ? 1f : 0f);
    }
    private void Start()
    {
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
        mem[1152921531143982184] = 0;
    }
    private void Update()
    {
        UnityEngine.GameObject val_36;
        float val_37;
        var val_38;
        var val_40;
        UnityEngine.Animation val_41;
        var val_42;
        var val_44;
        string val_45;
        var val_48;
        val_36 = this;
        val_37 = RealTime.deltaTime;
        if(val_37 == 0f)
        {
                return;
        }
        
        if(this.丒丂不丞丁丝不专丝 == 0)
        {
            goto label_4;
        }
        
        val_37 = (this.丝丛丒丝丝且丕丙专 == 1) ? (-val_37) : (val_37);
        this.丒丂不丞丁丝不专丝.Update(deltaTime:  val_37);
        if(this.isPlaying == true)
        {
                return;
        }
        
        this.丒丂不丞丁丝不专丝.enabled = false;
        goto label_8;
        label_4:
        if(this.三上下丁丅丅下上丑 == 0)
        {
            goto label_11;
        }
        
        System.Collections.IEnumerator val_5 = this.三上下丁丅丅下上丑.GetEnumerator();
        val_38 = 0;
        goto label_37;
        label_43:
        var val_38 = 0;
        val_38 = val_38 + 1;
        val_40 = val_5.Current;
        if(val_40 != null)
        {
                if(null == null)
        {
            goto label_20;
        }
        
        }
        
        val_41 = this.三上下丁丅丅下上丑;
        val_40 = 0;
        val_42 = 1;
        goto label_21;
        label_20:
        val_41 = this.三上下丁丅丅下上丑;
        val_42 = 0;
        label_21:
        if((val_41.IsPlaying(name:  val_40.name)) == false)
        {
            goto label_37;
        }
        
        float val_39 = val_40.speed;
        float val_12 = val_40.time;
        val_39 = val_37 * val_39;
        val_12 = val_39 + val_12;
        val_40.time = val_12;
        if(val_39 >= 0)
        {
            goto label_27;
        }
        
        if(val_40.time > 0f)
        {
            goto label_34;
        }
        
        val_40.time = 0f;
        goto label_37;
        label_27:
        float val_15 = val_40.length;
        if(val_40.time < 0)
        {
            goto label_34;
        }
        
        val_40.time = val_40.length;
        goto label_37;
        label_34:
        val_38 = 1;
        label_37:
        var val_40 = 0;
        val_40 = val_40 + 1;
        if(val_5.MoveNext() == true)
        {
            goto label_43;
        }
        
        val_44 = 0;
        val_45 = 0;
        goto label_44;
        label_11:
        this.enabled = false;
        return;
        label_44:
        if((???) == 0)
        {
            goto label_61;
        }
        
        var val_43 = ???;
        if((??? + 286) == 0)
        {
            goto label_65;
        }
        
        var val_41 = ??? + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_64:
        if(((??? + 176 + 8) + -8) == null)
        {
            goto label_63;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < (??? + 286))
        {
            goto label_64;
        }
        
        goto label_65;
        label_63:
        val_43 = val_43 + (((??? + 176 + 8)) << 4);
        val_48 = val_43 + 296;
        label_65:
        ???.Dispose();
        label_61:
        ??? + 48.Sample();
        if(((???) & 1) != 0)
        {
                return;
        }
        
        label_8:
        ???.enabled = false;
        if((??? + 64) == 0)
        {
                return;
        }
        
        mem2[0] = 0;
        if(ActiveAnimation.current == 0)
        {
                ActiveAnimation.current = ???;
            EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  ??? + 24);
            if((??? + 32) != 0)
        {
                if((System.String.IsNullOrEmpty(value:  ??? + 40)) != true)
        {
                val_45 = mem[??? + 32 + 8];
            val_45 = ??? + 32 + 8;
            ??? + 32.SendMessage(methodName:  val_45, options:  1);
        }
        
        }
        
            ActiveAnimation.current = 0;
        }
        
        if((??? + 60) == 0)
        {
                return;
        }
        
        if((??? + 56) != (??? + 60))
        {
                return;
        }
        
        val_36 = ???.gameObject;
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  false);
    }
    private void 三且世三丂七丐一丟(string 七不丐下丟专业万丅, AnimationOrTween.丟世丆丕丌且七下丂 世一丑丝丈一上三丕)
    {
        var val_26;
        string val_27;
        var val_28;
        var val_31;
        var val_32;
        val_26 = 世一丑丝丈一上三丕;
        val_27 = 七不丐下丟专业万丅;
        if(val_26 == 0)
        {
                AnimationOrTween.丟世丆丕丌且七下丂 val_1 = (this.丝丛丒丝丝且丕丙专 != 1) ? (-0) : 0;
        }
        
        val_28 = 1152921504848912384;
        if(this.三上下丁丅丅下上丑 == 0)
        {
            goto label_4;
        }
        
        this.enabled = true;
        this.三上下丁丅丅下上丑.enabled = false;
        bool val_3 = System.String.IsNullOrEmpty(value:  val_27);
        if(this.三上下丁丅丅下上丑 == null)
        {
            goto label_6;
        }
        
        if(val_3 == false)
        {
            goto label_7;
        }
        
        label_19:
        if(this.三上下丁丅丅下上丑.isPlaying == true)
        {
            goto label_20;
        }
        
        bool val_5 = this.三上下丁丅丅下上丑.Play();
        goto label_20;
        label_4:
        if(this.丒丂不丞丁丝不专丝 == 0)
        {
                return;
        }
        
        if((this.enabled != false) && (this.isPlaying != false))
        {
                if((System.String.op_Equality(a:  this.丝丞丈上丟丐下丞不, b:  val_27)) != false)
        {
                this.丝丛丒丝丝且丕丙专 = val_1;
            return;
        }
        
        }
        
        this.enabled = true;
        this.一丈万与丈丐丒三丞 = true;
        this.丝丛丒丝丝且丕丙专 = val_1;
        this.丝丞丈上丟丐下丞不 = val_27;
        this.丒丂不丞丁丝不专丝.Play(stateName:  val_27, layer:  0, normalizedTime:  (val_1 == 1) ? 0f : 1f);
        return;
        label_6:
        if(val_3 == true)
        {
            goto label_19;
        }
        
        label_7:
        if((this.三上下丁丅丅下上丑.IsPlaying(name:  val_27)) != true)
        {
                bool val_12 = this.三上下丁丅丅下上丑.Play(animation:  val_27);
        }
        
        label_20:
        System.Collections.IEnumerator val_13 = this.三上下丁丅丅下上丑.GetEnumerator();
        label_54:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_13.MoveNext() == false)
        {
            goto label_28;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_31 = val_13.Current;
        if((val_31 != null) && (null != null))
        {
                val_31 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_27)) != true)
        {
                if((System.String.op_Equality(a:  val_31.name, b:  val_27)) == false)
        {
            goto label_54;
        }
        
        }
        
        float val_30 = System.Math.Abs(val_31.speed);
        val_30 = val_30 * (float)val_1;
        val_31.speed = val_30;
        if(val_1 == 1)
        {
            goto label_43;
        }
        
        if((val_1 != 1) || (val_31.time != val_31.length))
        {
            goto label_54;
        }
        
        val_31.time = 0f;
        goto label_54;
        label_43:
        if(val_31.time != 0f)
        {
            goto label_54;
        }
        
        val_31.time = val_31.length;
        goto label_54;
        label_28:
        val_28 = 0;
        val_32 = 0;
        if(val_13 != null)
        {
                var val_31 = 0;
            val_31 = val_31 + 1;
            val_13.Dispose();
        }
        
        val_27 = this.三上下丁丅丅下上丑;
        this.丝丛丒丝丝且丕丙专 = val_1;
        this.一丈万与丈丐丒三丞 = true;
        val_27.Sample();
    }
    public static ActiveAnimation Play(UnityEngine.Animation 丐丐七专三且世三七, string 七不丐下丟专业万丅, AnimationOrTween.丟世丆丕丌且七下丂 世一丑丝丈一上三丕, AnimationOrTween.三世业世丟丈丕世且 专丝丂世上丌丞世三, AnimationOrTween.且丁丝丄三世且丐一 上丈丅丌丅丒丗上丒)
    {
        AnimationOrTween.且丁丝丄三世且丐一 val_13;
        AnimationOrTween.丟世丆丕丌且七下丂 val_14;
        UnityEngine.Object val_15;
        int val_16;
        var val_17;
        UnityEngine.Object val_18;
        val_13 = 上丈丅丌丅丒丗上丒;
        val_14 = 世一丑丝丈一上三丕;
        UnityEngine.GameObject val_1 = 丐丐七专三且世三七.gameObject;
        val_15 = 1152921505093320704;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_1)) == true)
        {
            goto label_12;
        }
        
        if(专丝丂世上丌丞世三 != 1)
        {
            goto label_5;
        }
        
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丐丐七专三且世三七.gameObject, 丏业丟一东丂东丘丛:  true);
        if(val_5.Length < 1)
        {
            goto label_12;
        }
        
        val_16 = val_5.Length & 4294967295;
        val_17 = 0;
        goto label_13;
        label_16:
        val_16 = val_5.Length;
        val_17 = 1;
        label_13:
        val_1.Refresh();
        if((val_16 - 1) != val_17)
        {
            goto label_16;
        }
        
        label_12:
        val_18 = 丐丐七专三且世三七.GetComponent<ActiveAnimation>();
        if(val_18 == 0)
        {
                val_18 = 丐丐七专三且世三七.gameObject.AddComponent<ActiveAnimation>();
        }
        
        if(val_18 != null)
        {
                val_15 = val_18;
            val_10.三上下丁丅丅下上丑 = 丐丐七专三且世三七;
            mem2[0] = val_13;
        }
        else
        {
                val_15 = 48;
            mem[48] = 丐丐七专三且世三七;
            val_10.丁上丙丆专丗且丁丗 = val_13;
        }
        
        val_13 = val_10.onFinished;
        val_13.Clear();
        val_18.三且世三丂七丐一丟(七不丐下丟专业万丅:  七不丐下丟专业万丅, 世一丑丝丈一上三丕:  val_14);
        if(val_15 != 0)
        {
                val_14 = mem[48];
            val_14.Sample();
            return (ActiveAnimation)val_18;
        }
        
        val_14 = val_10.丒丂不丞丁丝不专丝;
        if(val_14 == 0)
        {
                return (ActiveAnimation)val_18;
        }
        
        val_14 = val_10.丒丂不丞丁丝不专丝;
        val_14.Update(deltaTime:  0f);
        return (ActiveAnimation)val_18;
        label_5:
        val_18 = 0;
        return (ActiveAnimation)val_18;
    }
    public static ActiveAnimation Play(UnityEngine.Animation 丐丐七专三且世三七, string 七不丐下丟专业万丅, AnimationOrTween.丟世丆丕丌且七下丂 世一丑丝丈一上三丕)
    {
        return ActiveAnimation.Play(丐丐七专三且世三七:  丐丐七专三且世三七, 七不丐下丟专业万丅:  七不丐下丟专业万丅, 世一丑丝丈一上三丕:  世一丑丝丈一上三丕, 专丝丂世上丌丞世三:  0, 上丈丅丌丅丒丗上丒:  0);
    }
    public static ActiveAnimation Play(UnityEngine.Animation 丐丐七专三且世三七, AnimationOrTween.丟世丆丕丌且七下丂 世一丑丝丈一上三丕)
    {
        return ActiveAnimation.Play(丐丐七专三且世三七:  丐丐七专三且世三七, 七不丐下丟专业万丅:  0, 世一丑丝丈一上三丕:  世一丑丝丈一上三丕, 专丝丂世上丌丞世三:  0, 上丈丅丌丅丒丗上丒:  0);
    }
    public static ActiveAnimation Play(UnityEngine.Animator 丐丐七专三且世三七, string 七不丐下丟专业万丅, AnimationOrTween.丟世丆丕丌且七下丂 世一丑丝丈一上三丕, AnimationOrTween.三世业世丟丈丕世且 专丝丂世上丌丞世三, AnimationOrTween.且丁丝丄三世且丐一 上丈丅丌丅丒丗上丒)
    {
        AnimationOrTween.且丁丝丄三世且丐一 val_13;
        AnimationOrTween.丟世丆丕丌且七下丂 val_14;
        var val_15;
        int val_16;
        var val_17;
        UnityEngine.Object val_18;
        val_13 = 上丈丅丌丅丒丗上丒;
        val_14 = 世一丑丝丈一上三丕;
        if(专丝丂世上丌丞世三 == 2)
        {
            goto label_13;
        }
        
        UnityEngine.GameObject val_1 = 丐丐七专三且世三七.gameObject;
        val_15 = 1152921505093320704;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_1)) == true)
        {
            goto label_13;
        }
        
        if(专丝丂世上丌丞世三 != 1)
        {
            goto label_6;
        }
        
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丐丐七专三且世三七.gameObject, 丏业丟一东丂东丘丛:  true);
        if(val_5.Length < 1)
        {
            goto label_13;
        }
        
        val_16 = val_5.Length & 4294967295;
        val_17 = 0;
        goto label_14;
        label_17:
        val_16 = val_5.Length;
        val_17 = 1;
        label_14:
        val_1.Refresh();
        if((val_16 - 1) != val_17)
        {
            goto label_17;
        }
        
        label_13:
        val_18 = 丐丐七专三且世三七.GetComponent<ActiveAnimation>();
        if(val_18 == 0)
        {
                val_18 = 丐丐七专三且世三七.gameObject.AddComponent<ActiveAnimation>();
        }
        
        if(val_18 != null)
        {
                val_15 = val_18;
            val_10.丒丂不丞丁丝不专丝 = 丐丐七专三且世三七;
            mem2[0] = val_13;
        }
        else
        {
                val_15 = 72;
            mem[72] = 丐丐七专三且世三七;
            val_10.丁上丙丆专丗且丁丗 = val_13;
        }
        
        val_13 = val_10.onFinished;
        val_13.Clear();
        val_18.三且世三丂七丐一丟(七不丐下丟专业万丅:  七不丐下丟专业万丅, 世一丑丝丈一上三丕:  val_14);
        if(val_10.三上下丁丅丅下上丑 != 0)
        {
                val_14 = val_10.三上下丁丅丅下上丑;
            val_14.Sample();
            return (ActiveAnimation)val_18;
        }
        
        val_14 = mem[72];
        if(val_14 == 0)
        {
                return (ActiveAnimation)val_18;
        }
        
        val_14 = mem[72];
        val_14.Update(deltaTime:  0f);
        return (ActiveAnimation)val_18;
        label_6:
        val_18 = 0;
        return (ActiveAnimation)val_18;
    }
    public ActiveAnimation()
    {
        this.onFinished = new System.Collections.Generic.List<EventDelegate>();
        this.丝丞丈上丟丐下丞不 = "";
    }

}
