using UnityEngine;
public class 业丗丕丟三丝丘三丗
{
    // Fields
    private ScopeViewGameEventGuiItem 不一丟丛丁且丒丐丑;
    private UnityEngine.Vector3 丂七上七万丈丁丅丅;
    private int 丛且丐丙一七丕万专;
    private UnityEngine.Color 丑丞丈丗丄丙丟万丄;
    private int 上东丒丒七丒且丕丕;
    public bool 下丌丘七专丂七三丆;
    public ScopeViewGameEventSettings 丑丗专丆一上世业丗;
    private UnityEngine.Transform 业不不丞专丗丟世丈;
    private UnityEngine.Coroutine 七丄丐丘东丏不专丁;
    private float 丐丞丅丁丛且丘与且;
    private UnityEngine.Coroutine 丙丒丕丅丏上丛且一;
    private float 丂下一业七丁丑专丄;
    private float 丘东丏丆丑丐与丆丝;
    private float <下三丌下丒与丁三上>k__BackingField;
    private float 且七丅丒不丂与丐丙;
    
    // Properties
    private UnityEngine.Vector3 上不一丗下世丂丞与 { get; }
    public ScopeViewGameEventGuiItem 丟丟万丆丒下丗业丏 { get; set; }
    public float 与丕丌丒丗丄丘丙东 { get; set; }
    internal float 下丛丙丈丏丙上一丌 { get; }
    
    // Methods
    public 业丗丕丟三丝丘三丗(ScopeViewGameEventSettings 丑不丛三丞丅且丑丕, UnityEngine.Transform 丛丌丕丐世丑丂七丂, UnityEngine.Color 丂丄一丗业丗丐万丏, float 丑丘丛丆丝上丂丙丗, float 丐丟丕丌与丞丅下万)
    {
        this.丛且丐丙一七丕万专 = 0;
        this.上东丒丒七丒且丕丕 = 0;
        this.丂下一业七丁丑专丄 = 1f;
        this.丑丗专丆一上世业丗 = 丑不丛三丞丅且丑丕;
        this.业不不丞专丗丟世丈 = 丛丌丕丐世丑丂七丂;
        this.丑丞丈丗丄丙丟万丄 = 丂丄一丗业丗丐万丏;
        mem[1152921538899537452] = 丂丄一丗业丗丐万丏.g;
        mem[1152921538899537456] = 丂丄一丗业丗丐万丏.b;
        mem[1152921538899537460] = 丂丄一丗业丗丐万丏.a;
        this.丘东丏丆丑丐与丆丝 = 丑丘丛丆丝上丂丙丗;
        float val_2 = 丑不丛三丞丅且丑丕.maxTargetDistance;
        val_2 = val_2 * 丐丟丕丌与丞丅下万;
        this.丐丞丅丁丛且丘与且 = val_2;
        this.<下三丌下丒与丁三上>k__BackingField = UnityEngine.Time.realtimeSinceStartup;
    }
    private UnityEngine.Vector3 丝丏丅七且三业丞三()
    {
        if(this.丑丗专丆一上世业丗.followTargetPosition != false)
        {
                if(this.丛且丐丙一七丕万专 != UnityEngine.Time.frameCount)
        {
            goto label_3;
        }
        
        }
        
        if(this.丛且丐丙一七丕万专 != 1)
        {
                return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_3.y, z = val_3.z};
        }
        
        label_3:
        if(this.业不不丞专丗丟世丈 == 0)
        {
                return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_3.y, z = val_3.z};
        }
        
        UnityEngine.Vector3 val_3 = this.业不不丞专丗丟世丈.position;
        this.丂七上七万丈丁丅丅 = val_3;
        mem[1152921538899669916] = val_3.y;
        mem[1152921538899669920] = val_3.z;
        this.丛且丐丙一七丕万专 = UnityEngine.Time.frameCount;
        return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_3.y, z = val_3.z};
    }
    public ScopeViewGameEventGuiItem 上世不丆丌丄世下且()
    {
        return (ScopeViewGameEventGuiItem)this.不一丟丛丁且丒丐丑;
    }
    public void 三丌丆与东万丌丞专(ScopeViewGameEventGuiItem 丙业与丙丗丝不丈东)
    {
        this.不一丟丛丁且丒丐丑 = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == 0)
        {
                return;
        }
        
        this.不一丟丛丁且丒丐丑.SetTarget(丞下万上三丘上与专:  this.业不不丞专丗丟世丈);
        this.不一丟丛丁且丒丐丑.SetColor(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丑丞丈丗丄丙丟万丄, g = V9.16B, b = V10.16B, a = V11.16B});
    }
    public float 丁丑不丄上丙专丝丞()
    {
        return (float)this.<下三丌下丒与丁三上>k__BackingField;
    }
    private void 丘丁一丆专业东丛丙(float 丙业与丙丗丝不丈东)
    {
        this.<下三丌下丒与丁三上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private bool 一丟丛丒三丘丛世丝(UnityEngine.Vector3 丕丙上丘丁丒丘丙丂)
    {
        float val_9;
        float val_10;
        ScopeViewGameEventGuiItem val_11;
        var val_12;
        val_9 = 丕丙上丘丁丒丘丙丂.z;
        val_10 = 丕丙上丘丁丒丘丙丂.x;
        val_11 = this;
        if(ScopeViewGameEventsController.丏丈万丅与丌不东丄() == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_4 = ScopeViewGameEventsController.丏丈万丅与丌不东丄().position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10, y = 丕丙上丘丁丒丘丙丂.y, z = val_9}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_9 = val_5.x;
        val_10 = val_5.y;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) == false)
        {
            goto label_11;
        }
        
        label_5:
        val_12 = 0;
        return (bool)val_12;
        label_11:
        float val_8 = val_5.z / val_9;
        val_8 = val_8 * 180f;
        float val_9 = 90f;
        val_8 = val_8 / 3.141593f;
        val_11 = this.不一丟丛丁且丒丐丑;
        val_9 = val_9 - val_8;
        val_8 = (val_9 > 0f) ? (val_9) : (val_8);
        val_9 = 270f - val_8;
        val_9 = (val_9 < 0) ? (val_9) : (val_8);
        val_11.SetRotation(一不丅与丟丌丏丟东:  -val_9);
        val_12 = 1;
        return (bool)val_12;
    }
    public bool 丑丕丈丈不不且丑且(bool 丌世丟丆丄丞丞业丈)
    {
        ScopeViewGameEventSettings val_6;
        var val_7;
        if(丌世丟丆丄丞丞业丈 == false)
        {
            goto label_13;
        }
        
        val_6 = this.丑丗专丆一上世业丗;
        if(val_6 == null)
        {
            goto label_2;
        }
        
        if(this.丑丗专丆一上世业丗.showType == 0)
        {
            goto label_3;
        }
        
        label_8:
        if(this.丑丗专丆一上世业丗.showType != 1)
        {
            goto label_13;
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.业不不丞专丗丟世丈, y:  0);
        label_2:
        if(this.丑丗专丆一上世业丗 == null)
        {
            goto label_7;
        }
        
        val_6 = this.丑丗专丆一上世业丗;
        if(this.丑丗专丆一上世业丗.showType != 0)
        {
            goto label_8;
        }
        
        label_3:
        if(this.丑丗专丆一上世业丗.followTargetPosition != false)
        {
                if(this.业不不丞专丗丟世丈 == 0)
        {
            goto label_13;
        }
        
        }
        
        float val_6 = this.丐丞丅丁丛且丘与且;
        val_6 = val_6 * val_6;
        if(this.丘丗专不丌且丏不丐() < 0)
        {
                var val_5 = ((UnityEngine.Time.realtimeSinceStartup - (this.<下三丌下丒与丁三上>k__BackingField)) < 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        label_13:
        val_7 = 0;
        return (bool)val_7;
        label_7:
    }
    public bool 丕世一与业丅万专丑()
    {
        var val_3;
        if(this.丑丗专丆一上世业丗.showType == 0)
        {
            goto label_1;
        }
        
        if(this.丑丗专丆一上世业丗.showType != 1)
        {
            goto label_3;
        }
        
        float val_3 = this.丐丞丅丁丛且丘与且;
        val_3 = val_3 * val_3;
        var val_2 = (this.丘丗专不丌且丏不丐() < 0) ? 1 : 0;
        return (bool)val_3;
        label_1:
        val_3 = 1;
        return (bool)val_3;
        label_3:
        val_3 = 0;
        return (bool)val_3;
    }
    public void 上专丄丑专丑丘业丌()
    {
        ScopeViewGameEventGuiItem val_9;
        if(this.不一丟丛丁且丒丐丑 == 0)
        {
                return;
        }
        
        float val_2 = this.丘丗专不丌且丏不丐();
        float val_8 = this.丐丞丅丁丛且丘与且;
        val_8 = val_8 * val_8;
        if(val_2 < 0)
        {
                UnityEngine.Vector3 val_3 = this.丝丏丅七且三业丞三();
            bool val_4 = this.一丟丛丒三丘丛世丝(丕丙上丘丁丒丘丙丂:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        
        if(val_2 <= 0f)
        {
            goto label_6;
        }
        
        float val_9 = this.丐丞丅丁丛且丘与且;
        val_9 = val_9 * val_9;
        if(val_2 >= 0)
        {
            goto label_6;
        }
        
        if(this.丑丗专丆一上世业丗.showType == 0)
        {
            goto label_8;
        }
        
        if(this.丑丗专丆一上世业丗.showType != 1)
        {
                return;
        }
        
        val_9 = this.不一丟丛丁且丒丐丑;
        float val_5 = this.丐丞丅丁丛且丘与且 * this.丐丞丅丁丛且丘与且;
        val_5 = val_2 / val_5;
        val_5 = 1f - val_5;
        val_5 = this.丂下一业七丁丑专丄 * val_5;
        goto label_15;
        label_6:
        label_15:
        this.不一丟丛丁且丒丐丑.SetAlpha(与专丌丅丙上丌一丄:  0f);
        return;
        label_8:
        val_9 = this.不一丟丛丁且丒丐丑;
        float val_6 = UnityEngine.Time.realtimeSinceStartup;
        val_6 = val_6 - (this.<下三丌下丒与丁三上>k__BackingField);
        float val_7 = this.丐丞丅丁丛且丘与且 * this.丐丞丅丁丛且丘与且;
        float val_10 = 1f;
        val_6 = val_6 / this.丘东丏丆丑丐与丆丝;
        val_7 = val_2 / val_7;
        val_6 = val_10 - val_6;
        val_10 = val_10 - val_7;
        val_6 = val_6 * val_10;
        goto label_15;
    }
    public void 且七丙丄丘一丄上不()
    {
        this.丂下一业七丁丑专丄 = 0f;
        if(this.丙丒丕丅丏上丛且一 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丙丒丕丅丏上丛且一);
            this.丙丒丕丅丏上丛且一 = 0;
        }
        
        if(this.七丄丐丘东丏不专丁 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.七丄丐丘东丏不专丁);
        this.七丄丐丘东丏不专丁 = 0;
    }
    public void 下与丞三丅丛丄七丕()
    {
        if(this.丙丒丕丅丏上丛且一 != null)
        {
                return;
        }
        
        if(this.七丄丐丘东丏不专丁 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.七丄丐丘东丏不专丁);
            this.七丄丐丘东丏不专丁 = 0;
        }
        
        this.丙丒丕丅丏上丛且一 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丏丏专万丟一上东丂());
    }
    private System.Collections.IEnumerator 丏丏专万丟一上东丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 业丗丕丟三丝丘三丗.丗丟丗专三丙下丕一();
    }
    public void 丆世与丑丆丅丐万且(业丗丕丟三丝丘三丗.丏东丂专丗不丟一与 且七丂丆丅不丏丂丗)
    {
        var val_5;
        if(this.七丄丐丘东丏不专丁 != null)
        {
                return;
        }
        
        if(this.丙丒丕丅丏上丛且一 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丙丒丕丅丏上丛且一);
            this.丙丒丕丅丏上丛且一 = 0;
        }
        
        val_5 = CoroutineRunner.Instance;
        this.七丄丐丘东丏不专丁 = val_5.StartCoroutine(routine:  this.丟丑东丗丞不东一丘(且七丂丆丅不丏丂丗:  且七丂丆丅不丏丂丗));
    }
    private System.Collections.IEnumerator 丟丑东丗丞不东一丘(业丗丕丟三丝丘三丗.丏东丂专丗不丟一与 且七丂丆丅不丏丂丗)
    {
        业丗丕丟三丝丘三丗.不丗丕丅丘丁下不下 val_1 = new 业丗丕丟三丝丘三丗.不丗丕丅丘丁下不下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .且七丂丆丅不丏丂丗 = 且七丂丆丅不丏丂丗;
        return (System.Collections.IEnumerator)val_1;
    }
    internal float 丘丗专不丌且丏不丐()
    {
        float val_4;
        if((this.上东丒丒七丒且丕丕 == UnityEngine.Time.frameCount) && (this.上东丒丒七丒且丕丕 != 1))
        {
                val_4 = this.且七丅丒不丂与丐丙;
            return val_4;
        }
        
        val_4 = this.且七丅丒不丂与丐丙;
        this.且七丅丒不丂与丐丙 = this.且丘丞丞三丐丒丅丙();
        this.上东丒丒七丒且丕丕 = UnityEngine.Time.frameCount;
        return val_4;
    }
    public float 且丘丞丞三丐丒丅丙()
    {
        UnityEngine.Vector3 val_1 = this.丝丏丅七且三业丞三();
        UnityEngine.Vector3 val_3 = ScopeViewGameEventsController.丏丈万丅与丌不东丄().position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }

}
