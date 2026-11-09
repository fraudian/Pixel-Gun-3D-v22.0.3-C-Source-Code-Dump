using UnityEngine;
public class 丛丙丆丌七丘丘且世
{
    // Fields
    public bool 丒世丅业丝东下与丗;
    public bool 七丙东丌丂丞丑万丅;
    public bool 丞丘丘丂丏万丗丛丄;
    public bool 与业丏丆丌下丟丞上;
    public bool 丝七专丟丁业丁丘丈;
    public float 丒丛七丈不丌丕世丏;
    public float 丕丕世且下一与丝与;
    public float 丂三丟丂丈丐丆丗丟;
    public float 丏三丟丈丕丂万不专;
    private uint 丏世丑万世一七丟丞;
    public int 世七业七一七丅丌丗;
    public uint 丘丛丆七与丒世下丛;
    public float 丒丈丘业丛丁丏丙丘;
    public bool 丙丁丐三业丏业丄与;
    public UnityEngine.Transform 丄上七丟不丗丕下丟;
    public LTRect 丝丛丁丏丑丞丈三一;
    public UnityEngine.Vector3 丈丗与丞一上且上上;
    public UnityEngine.Vector3 专丂丕丗丗东世丞下;
    public UnityEngine.Vector3 丕丙丘丂丙七丘丕丆;
    public UnityEngine.Vector3 丅专与丒丈丗丒丘丌;
    public UnityEngine.Vector3 世丐世丄不不丈丗丏;
    public UnityEngine.Vector3 丆丏丕不一三丐不丆;
    public 上三世丟丛丘东丌丕 丛丄业丕且丗下一万;
    public LTSpline 丆丂丈万丗丕丙丟上;
    public 不丞七业上七丘丑丒 丁丅丈丌丟世丗丗丟;
    public 丆丟上丝且三上丂丆 三丄丙业一三丛丄丂;
    public UnityEngine.AnimationCurve 丛丆丁业东上丁丆丘;
    public 丆丟上丝且三上丂丆 上丒一丂丞丅丏丅丂;
    public System.Action<float> 丟东七七丈丆七丗万;
    public System.Action<float, object> 且且不世丁丘上业丂;
    public System.Action<UnityEngine.Vector3> 丕丞丐三上丅下丈且;
    public System.Action<UnityEngine.Vector3, object> 丌三丏上丆丂丘与专;
    public System.Action 丟丘丙丄丅万丏与丗;
    public System.Action<object> 业世丁下丅与丘丞丁;
    public object 丗万丗一丞丘丆丘丛;
    public object 一丕世丄丅上不一丌;
    public System.Collections.Hashtable 丛丛丁丟上东丈丗上;
    private static uint 丄丕丁丁一丆丗不丙;
    
    // Properties
    public int 丙下不丏丅丅专丂丗 { get; }
    public int 丞丅上丏丂且下丅与 { get; }
    
    // Methods
    public override string ToString()
    {
        object val_9;
        object[] val_1 = new object[21];
        if(this.丄上七丟不丗丕下丟 == 0)
        {
            goto label_3;
        }
        
        val_9 = "gameObject:"("gameObject:") + this.丄上七丟不丗丕下丟.gameObject;
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_3:
        val_9 = "gameObject:null";
        if(val_1 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        val_1[0] = val_9;
        val_1[1] = " toggle:";
        val_1[2] = this.丒世丅业丝东下与丗.ToString();
        val_1[3] = " passed:";
        val_1[4] = this.丒丛七丈不丌丕世丏;
        val_1[5] = " time:";
        val_1[6] = this.丂三丟丂丈丐丆丗丟;
        val_1[7] = " delay:";
        val_1[8] = this.丕丕世且下一与丝与;
        val_1[9] = " from:";
        val_1[10] = this.丈丗与丞一上且上上;
        val_1[11] = " to:";
        val_1[12] = this.专丂丕丗丗东世丞下;
        val_1[13] = " type:";
        val_1[14] = this.丁丅丈丌丟世丗丗丟;
        val_1[15] = " useEstimatedTime:";
        val_1[16] = this.七丙东丌丂丞丑万丅.ToString();
        val_1[17] = " id:";
        uint val_9 = this.丏世丑万世一七丟丞;
        val_9 = val_9 | (this.丘丛丆七与丒世下丛 << 16);
        val_1[18] = val_9;
        val_1[19] = " hasInitiliazed:";
        val_1[20] = this.与业丏丆丌下丟丞上.ToString();
        return (string)+val_1;
    }
    public 丛丙丆丌七丘丘且世()
    {
    
    }
    public 丛丙丆丌七丘丘且世 一丞丏世丗专丕三丗()
    {
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  this.丏世丑万世一七丟丞);
        return (丛丙丆丌七丘丘且世)this;
    }
    public int 丛东丐丐东专丟丂丂()
    {
        return (int)this.丏世丑万世一七丟丞 | (this.丘丛丆七与丒世下丛 << 16);
    }
    public int 丞业丅万七万且丏丏()
    {
        return (int)this.丏世丑万世一七丟丞 | (this.丘丛丆七与丒世下丛 << 16);
    }
    public void 丞专丙万丕不丗丈丛()
    {
        var val_2;
        this.丒世丅业丝东下与丗 = true;
        this.七丙东丌丂丞丑万丅 = false;
        this.丞丘丘丂丏万丗丛丄 = false;
        this.与业丏丆丌下丟丞上 = false;
        this.三丄丙业一三丛丄丂 = true;
        this.丛丛丁丟上东丈丗上 = 0;
        this.丙丁丐三业丏业丄与 = false;
        this.丒丛七丈不丌丕世丏 = 0f;
        this.丕丕世且下一与丝与 = 0f;
        this.丛丆丁业东上丁丆丘 = 0;
        this.世七业七一七丅丌丗 = 0;
        this.丗万丗一丞丘丆丘丛 = 0;
        this.上丒一丂丞丅丏丅丂 = 35;
        this.丏三丟丈丕丂万不专 = 1f;
        this.丒丈丘业丛丁丏丙丘 = 1f;
        this.丕丞丐三上丅下丈且 = 0;
        this.丟丘丙丄丅万丏与丗 = 0;
        this.丟东七七丈丆七丗万 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丅专与丒丈丗丒丘丌 = val_1;
        mem[1152921535393895528] = val_1.y;
        mem[1152921535393895532] = val_1.z;
        val_2 = null;
        val_2 = null;
        uint val_2 = 丛丙丆丌七丘丘且世.丄丕丁丁一丆丗不丙;
        val_2 = val_2 + 1;
        丛丙丆丌七丘丘且世.丄丕丁丁一丆丗不丙 = val_2;
    }
    public 丛丙丆丌七丘丘且世 丁与丟万丄丒丗专丌()
    {
        if(this.丒丈丘业丛丁丏丙丘 == 0f)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.丏三丟丈丕丂万不专 = this.丒丈丘业丛丁丏丙丘;
        this.丒丈丘业丛丁丏丙丘 = 0f;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 不业下世三世七七丐()
    {
        this.丒丈丘业丛丁丏丙丘 = this.丏三丟丈丕丂万不专;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 与丕丈丛丐丌世丐丘(UnityEngine.Vector3 世丐世丄不不丈丗丏)
    {
        this.世丐世丄不不丈丗丏 = 世丐世丄不不丈丗丏;
        mem[1152921535394231540] = 世丐世丄不不丈丗丏.y;
        mem[1152921535394231544] = 世丐世丄不不丈丗丏.z;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丝上与业丏丆丒上丝(float 丕丕世且下一与丝与)
    {
        float val_2 = 丕丕世且下一与丝与;
        if(this.七丙东丌丂丞丑万丅 != true)
        {
                val_2 = UnityEngine.Time.timeScale * val_2;
        }
        
        this.丕丕世且下一与丝与 = val_2;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丞不丁丝丙上丗丈万(丆丟上丝且三上丂丆 丙与丕丒丕丈上丗丂)
    {
        this.三丄丙业一三丛丄丂 = 丙与丕丒丕丈上丗丂;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丞不丁丝丙上丗丈万(UnityEngine.AnimationCurve 业万丗丌七下丛丁丒)
    {
        this.丛丆丁业东上丁丆丘 = 业万丗丌七下丛丁丒;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 且丙丕丒丕丅世一丏(UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        this.专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
        mem[1152921535394695888] = 专丂丕丗丗东世丞下.y;
        mem[1152921535394695892] = 专丂丕丗丗东世丞下.z;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 下下丝丞丛万七丞丆(UnityEngine.Vector3 丈丗与丞一上且上上)
    {
        this.丈丗与丞一上且上上 = 丈丗与丞一上且上上;
        mem[1152921535394807876] = 丈丗与丞一上且上上.y;
        mem[1152921535394807880] = 丈丗与丞一上且上上.z;
        this.与业丏丆丌下丟丞上 = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.专丂丕丗丗东世丞下, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z});
        this.丕丙丘丂丙七丘丕丆 = val_1;
        mem[1152921535394807900] = val_1.y;
        mem[1152921535394807904] = val_1.z;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丐世下不一丁丟丅专(uint 丞丅上丏丂且下丅与)
    {
        var val_1;
        this.丏世丑万世一七丟丞 = 丞丅上丏丂且下丅与;
        val_1 = null;
        val_1 = null;
        this.丘丛丆七与丒世下丛 = 丛丙丆丌七丘丘且世.丄丕丁丁一丆丗不丙;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丌七丁丏下与且世丈(int 丈丞丛东丛与万丁且)
    {
        this.世七业七一七丅丌丗 = 丈丞丛东丛与万丁且;
        if(丈丞丛东丛与万丁且 < 2)
        {
                if((丈丞丛东丛与万丁且 & 2147483648) == 0)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        }
        
        if(this.上丒一丂丞丅丏丅丂 != 35)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.上丒一丂丞丅丏丅丂 = 36;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丂丆丈一丒丌业丙专(丆丟上丝且三上丂丆 上丒一丂丞丅丏丅丂)
    {
        this.上丒一丂丞丅丏丅丂 = 上丒一丂丞丅丏丅丂;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丁丈丛丏丂丅丘上丁(bool 七丙东丌丂丞丑万丅)
    {
        this.七丙东丌丂丞丑万丅 = 七丙东丌丂丞丑万丅;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丗且丕丞丁不下丘丈(bool 丞丘丘丂丏万丗丛丄)
    {
        this.丞丘丘丂丏万丗丛丄 = 丞丘丘丂丏万丗丛丄;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丗丛世一世万下上丝(int 世七业七一七丅丌丗)
    {
        this.世七业七一七丅丌丗 = 世七业七一七丅丌丗;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丁与丁丆世世丅丑丄()
    {
        this.上丒一丂丞丅丏丅丂 = 35;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 与丛丁三丘丏东丆丐()
    {
        this.上丒一丂丞丅丏丅丂 = 36;
        if(this.世七业七一七丅丌丗 != 0)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.世七业七一七丅丌丗 = 0;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丁三丅丕丏与丐丏一()
    {
        this.上丒一丂丞丅丏丅丂 = 37;
        if(this.世七业七一七丅丌丗 != 0)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.世七业七一七丅丌丗 = 0;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 且世下丁丈丐丘丆丟(System.Action 丟丘丙丄丅万丏与丗)
    {
        this.丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 且世下丁丈丐丘丆丟(System.Action<object> 丟丘丙丄丅万丏与丗)
    {
        this.业世丁下丅与丘丞丁 = 丟丘丙丄丅万丏与丗;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 且世下丁丈丐丘丆丟(System.Action<object> 丟丘丙丄丅万丏与丗, object 丗万丗一丞丘丆丘丛)
    {
        this.业世丁下丅与丘丞丁 = 丟丘丙丄丅万丏与丗;
        if(丗万丗一丞丘丆丘丛 == null)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.丗万丗一丞丘丆丘丛 = 丗万丗一丞丘丆丘丛;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丙丂三丌下万业丕丆(object 丗万丗一丞丘丆丘丛)
    {
        this.丗万丗一丞丘丆丘丛 = 丗万丗一丞丘丆丘丛;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 三七七丁丌丐丏丙丘(System.Action<float> 丄丙丞丁世上丄与与)
    {
        this.丟东七七丈丆七丗万 = 丄丙丞丁世上丄与与;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 下丗丙万东丂丙三业(System.Action<float, object> 丄丙丞丁世上丄与与)
    {
        this.且且不世丁丘上业丂 = 丄丙丞丁世上丄与与;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丝丏一丕丕与世专丈(System.Action<UnityEngine.Vector3> 丄丙丞丁世上丄与与)
    {
        this.丕丞丐三上丅下丈且 = 丄丙丞丁世上丄与与;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 三七七丁丌丐丏丙丘(System.Action<float, object> 丄丙丞丁世上丄与与, object 一丕世丄丅上不一丌)
    {
        this.且且不世丁丘上业丂 = 丄丙丞丁世上丄与与;
        if(一丕世丄丅上不一丌 == null)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.一丕世丄丅上不一丌 = 一丕世丄丅上不一丌;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 三七七丁丌丐丏丙丘(System.Action<UnityEngine.Vector3, object> 丄丙丞丁世上丄与与, object 一丕世丄丅上不一丌)
    {
        this.丌三丏上丆丂丘与专 = 丄丙丞丁世上丄与与;
        if(一丕世丄丅上不一丌 == null)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.一丕世丄丅上不一丌 = 一丕世丄丅上不一丌;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 三七七丁丌丐丏丙丘(System.Action<UnityEngine.Vector3> 丄丙丞丁世上丄与与, object 一丕世丄丅上不一丌)
    {
        this.丕丞丐三上丅下丈且 = 丄丙丞丁世上丄与与;
        if(一丕世丄丅上不一丌 == null)
        {
                return (丛丙丆丌七丘丘且世)this;
        }
        
        this.一丕世丄丅上不一丌 = 一丕世丄丅上不一丌;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丅丘东下丈丞丌丏万(object 一丕世丄丅上不一丌)
    {
        this.一丕世丄丅上不一丌 = 一丕世丄丅上不一丌;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丒丌东丗丆专丘世丁(bool 丁丆丈丛丑专七一丄)
    {
        上三世丟丛丘东丌丕 val_4;
        不丞七业上七丘丑丒 val_4 = this.丁丅丈丌丟世丗丗丟;
        val_4 = val_4 & 4294967294;
        if(val_4 != 6)
        {
            goto label_1;
        }
        
        val_4 = this.丛丄业丕且丗下一万;
        if(val_4 != null)
        {
            goto label_2;
        }
        
        上三世丟丛丘东丌丕 val_1 = null;
        val_4 = val_1;
        val_1 = new 上三世丟丛丘东丌丕();
        this.丛丄业丕且丗下一万 = val_4;
        if(val_4 == null)
        {
            goto label_3;
        }
        
        label_2:
        .丌业丞丌丛世不丞丑 = 丁丆丈丛丑专七一丄;
        return (丛丙丆丌七丘丘且世)this;
        label_1:
        this.丆丂丈万丗丕丙丟上.orientToPath = 丁丆丈丛丑专七一丄;
        return (丛丙丆丌七丘丘且世)this;
        label_3:
    }
    public 丛丙丆丌七丘丘且世 丑丁七与丛丄万丞东(LTRect 丝丆丏丕丕丕丗丛业)
    {
        this.丝丛丁丏丑丞丈三一 = 丝丆丏丕丕丕丗丛业;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丑丁七与丛丄万丞东(UnityEngine.Rect 丝丆丏丕丕丕丗丛业)
    {
        this.丝丛丁丏丑丞丈三一 = new LTRect(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = 丝丆丏丕丕丕丗丛业.m_YMin, m_Width = 丝丆丏丕丕丕丗丛业.m_Width, m_Height = 丝丆丏丕丕丕丗丛业.m_Height});
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丂丘丑东丒丟丄丐专(上三世丟丛丘东丌丕 丛丄业丕且丗下一万)
    {
        this.丛丄业丕且丗下一万 = 丛丄业丕且丗下一万;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丟丛一丕上丏丐丝世(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        this.丅专与丒丈丗丒丘丌 = 丅专与丒丈丗丒丘丌;
        mem[1152921535397804520] = 丅专与丒丈丗丒丘丌.y;
        mem[1152921535397804524] = 丅专与丒丈丗丒丘丌.z;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丕丅丆上丕丆世上与(bool 不丌丕三七专专丝丑)
    {
        this.丙丁丐三业丏业丄与 = 不丌丕三七专专丝丑;
        return (丛丙丆丌七丘丘且世)this;
    }
    public 丛丙丆丌七丘丘且世 丙丗丗东与万丕东七(object 丌丕丛丂一丈丙丟丏)
    {
        this.丗万丗一丞丘丆丘丛 = 丌丕丛丂一丈丙丟丏;
        return (丛丙丆丌七丘丘且世)this;
    }
    private static 丛丙丆丌七丘丘且世()
    {
    
    }

}
