using UnityEngine;
public class TypewriterEffect : MonoBehaviour
{
    // Fields
    public static TypewriterEffect current;
    public int charsPerSecond;
    public float fadeInTime;
    public float delayOnPeriod;
    public float delayOnNewLine;
    public UIScrollView scrollView;
    public bool keepFullDimensions;
    public System.Collections.Generic.List<EventDelegate> onFinished;
    private UILabel 丞丛万三丑丂丗一丞;
    private string 且丝丑一丁丆一万七;
    private int 三不丏丘丘三丄三七;
    private float 丂丏丐丐丝丗专七丆;
    private bool 丑且丅丘丞丗丛丄丝;
    private bool 万丝业下下丏丆丏东;
    private 丒丞丕丕七丁丗丟丛<TypewriterEffect.丆下上丆丁业不丗丂> 丈丈丝丕与东丘丘且;
    
    // Properties
    public bool 东丅丞丁丗万且丁丗 { get; }
    
    // Methods
    public bool get_isActive()
    {
        return (bool)this.万丝业下下丏丆丏东;
    }
    public void ResetToBeginning()
    {
        this.Finish();
        this.丑且丅丘丞丗丛丄丝 = true;
        this.万丝业下下丏丆丏东 = true;
        this.三不丏丘丘三丄三七 = 0;
        this.丂丏丐丐丝丗专七丆 = 0f;
        this.Update();
    }
    public void Finish()
    {
        TypewriterEffect val_3 = this;
        if(this.万丝业下下丏丆丏东 == false)
        {
                return;
        }
        
        this.万丝业下下丏丆丏东 = false;
        if(this.丑且丅丘丞丗丛丄丝 != true)
        {
                this.三不丏丘丘三丄三七 = this.且丝丑一丁丆一万七.Length;
            this.丈丈丝丕与东丘丘且.世业丒万丘丆专丘丐();
            this.丞丛万三丑丂丗一丞.text = this.且丝丑一丁丆一万七;
        }
        
        if(this.keepFullDimensions != false)
        {
                if(this.scrollView != 0)
        {
                this.scrollView.UpdatePosition();
        }
        
        }
        
        TypewriterEffect.current = val_3;
        val_3 = this.onFinished;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        TypewriterEffect.current = 0;
    }
    private void OnEnable()
    {
        this.丑且丅丘丞丗丛丄丝 = true;
        this.万丝业下下丏丆丏东 = true;
    }
    private void OnDisable()
    {
        this.Finish();
    }
    private void Update()
    {
        UILabel val_55;
        string val_56;
        var val_57;
        var val_58;
        float val_59;
        int val_60;
        string val_61;
        丒丞丕丕七丁丗丟丛<丆下上丆丁业不丗丂> val_62;
        var val_63;
        var val_64;
        var val_65;
        丒丞丕丕七丁丗丟丛<丆下上丆丁业不丗丂> val_66;
        string val_67;
        var val_68;
        string val_69;
        val_55 = this;
        if(this.万丝业下下丏丆丏东 == false)
        {
                return;
        }
        
        if(this.丑且丅丘丞丗丛丄丝 == false)
        {
            goto label_2;
        }
        
        this.三不丏丘丘三丄三七 = 0;
        this.丑且丅丘丞丗丛丄丝 = false;
        UILabel val_1 = this.GetComponent<UILabel>();
        this.丞丛万三丑丂丗一丞 = val_1;
        val_56 = val_55;
        this.且丝丑一丁丆一万七 = val_1.processedText;
        this.丈丈丝丕与东丘丘且.世业丒万丘丆专丘丐();
        if((this.keepFullDimensions == false) || (this.scrollView == 0))
        {
            goto label_10;
        }
        
        this.scrollView.UpdatePosition();
        goto label_10;
        label_2:
        val_56 = this.且丝丑一丁丆一万七;
        label_10:
        if((System.String.IsNullOrEmpty(value:  mem[this.且丝丑一丁丆一万七])) == true)
        {
                return;
        }
        
        val_57 = 1152921504838422528;
        val_58 = 1152921531066899936;
        val_59 = 1f;
        goto label_54;
        label_57:
        if(this.丂丏丐丐丝丗专七丆 > RealTime.time)
        {
            goto label_22;
        }
        
        this.charsPerSecond = UnityEngine.Mathf.Max(a:  1, b:  this.charsPerSecond);
        if(this.丞丛万三丑丂丗一丞.supportEncoding != false)
        {
                do
        {
        
        }
        while((丐丄七丙丁丆丁专丏.世不万丗与下丁丛一(丕丗丘丑丛与丑业丒:  mem[this.且丝丑一丁丆一万七], 丞世不丒下上上丝丑: ref  this.三不丏丘丘三丄三七)) == true);
        
        }
        
        val_60 = this.三不丏丘丘三丄三七 + 1;
        mem2[0] = val_60;
        if(val_60 > mem[this.且丝丑一丁丆一万七].Length)
        {
            goto label_22;
        }
        
        float val_53 = (float)this.charsPerSecond;
        val_53 = val_59 / val_53;
        if(this.三不丏丘丘三丄三七 >= mem[this.且丝丑一丁丆一万七].Length)
        {
            goto label_24;
        }
        
        char val_12 = mem[this.且丝丑一丁丆一万七].Chars[this.三不丏丘丘三丄三七];
        if((val_12 & 65535) != '
        ')
        {
            goto label_26;
        }
        
        label_24:
        label_46:
        val_53 = val_53 + this.delayOnNewLine;
        label_38:
        if(this.丂丏丐丐丝丗专七丆 == 0f)
        {
                float val_14 = RealTime.time;
        }
        
        val_14 = val_53 + val_14;
        this.丂丏丐丐丝丗专七丆 = val_14;
        if(this.fadeInTime == 0f)
        {
            goto label_28;
        }
        
        val_60 = mem[this.且丝丑一丁丆一万七].Substring(startIndex:  this.三不丏丘丘三丄三七, length:  this.三不丏丘丘三丄三七 - this.三不丏丘丘三丄三七);
        this.丈丈丝丕与东丘丘且.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new 丆下上丆丁业不丗丂() {丞世不丒下上上丝丑 = 690408560, 丕丗丘丑丛与丑业丒 = public System.Void 丒丞丕丕七丁丗丟丛<丆下上丆丁业不丗丂>::业丏丗丐丂业东丂丗(丆下上丆丁业不丗丂 下丅丙一丂丗丅丝七), 与专丌丅丙上丌一丄 = 0f});
        goto label_54;
        label_26:
        int val_18 = this.三不丏丘丘三丄三七 + 1;
        if(val_18 != mem[this.且丝丑一丁丆一万七].Length)
        {
                if((mem[this.且丝丑一丁丆一万七].Chars[val_18] & 65535) > ' ')
        {
            goto label_38;
        }
        
        }
        
        char val_21 = val_12 & 65535;
        if((val_21 == ('!')) || (val_21 == ('?')))
        {
            goto label_46;
        }
        
        if(val_21 != '.')
        {
            goto label_38;
        }
        
        int val_23 = this.三不丏丘丘三丄三七 + 2;
        if(((val_23 >= mem[this.且丝丑一丁丆一万七].Length) || ((mem[this.且丝丑一丁丆一万七].Chars[val_18] & 65535) != '.')) || ((mem[this.且丝丑一丁丆一万七].Chars[val_23] & 65535) != '.'))
        {
            goto label_46;
        }
        
        float val_54 = this.delayOnPeriod;
        val_54 = val_54 * 3f;
        goto label_46;
        label_28:
        val_60 = this.三不丏丘丘三丄三七;
        val_61 = mem[this.且丝丑一丁丆一万七].Substring(startIndex:  0, length:  val_60);
        if(this.keepFullDimensions != false)
        {
                val_60 = mem[this.且丝丑一丁丆一万七];
            val_61 = val_61 + "[00]" + val_60.Substring(startIndex:  this.三不丏丘丘三丄三七)(val_60.Substring(startIndex:  this.三不丏丘丘三丄三七));
        }
        
        this.丞丛万三丑丂丗一丞.text = val_61;
        if(this.keepFullDimensions != true)
        {
                if(this.scrollView != 0)
        {
                this.scrollView.UpdatePosition();
        }
        
        }
        
        label_54:
        if(this.三不丏丘丘三丄三七 < mem[this.且丝丑一丁丆一万七].Length)
        {
            goto label_57;
        }
        
        label_22:
        if(this.三不丏丘丘三丄三七 >= mem[this.且丝丑一丁丆一万七].Length)
        {
            goto label_59;
        }
        
        val_62 = this.丈丈丝丕与东丘丘且;
        val_58 = 1152921531066942000;
        val_63 = 0;
        goto label_68;
        label_70:
        if(this.丈丈丝丕与东丘丘且 == null)
        {
            goto label_63;
        }
        
        val_64 = this.丈丈丝丕与东丘丘且;
        if(val_63 < (this.三不丏丘丘三丄三七 + 24))
        {
            goto label_71;
        }
        
        goto label_65;
        label_63:
        val_65 = 0;
        label_71:
        丆下上丆丁业不丗丂 val_34 = val_65.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        float val_55 = 0f;
        val_57 = 0;
        float val_35 = RealTime.deltaTime;
        val_35 = val_35 / this.fadeInTime;
        val_55 = val_55 + val_35;
        if(val_55 >= 0)
        {
                this.丈丈丝丕与东丘丘且.丄不丆丑丑丂丈丐丈(丞世不丒下上上丝丑:  0);
        }
        else
        {
                this.丈丈丝丕与东丘丘且.丘丕丈下东一丑上丗(七丞丙丒三丕且丌丟:  0, 丙业与丙丗丝不丈东:  new 丆下上丆丁业不丗丂() {丞世不丒下上上丝丑 = 690408560, 丕丗丘丑丛与丑业丒 = public System.Void 丒丞丕丕七丁丗丟丛<丆下上丆丁业不丗丂>::丘丕丈下东一丑上丗(int 七丞丙丒三丕且丌丟, 丆下上丆丁业不丗丂 丙业与丙丗丝不丈东)});
            val_63 = 1;
        }
        
        label_68:
        val_66 = this.丈丈丝丕与东丘丘且;
        if(val_66 == null)
        {
            goto label_70;
        }
        
        if(val_63 < 690408560)
        {
            goto label_71;
        }
        
        label_65:
        if(this.三不丏丘丘三丄三七 == 0)
        {
            goto label_72;
        }
        
        System.Text.StringBuilder val_36 = null;
        val_67 = 0;
        val_62 = val_36;
        val_36 = new System.Text.StringBuilder();
        val_68 = 0;
        val_60 = this.丈丈丝丕与东丘丘且;
        if(this.keepFullDimensions != false)
        {
                System.Text.StringBuilder val_47 = val_36.Append(value:  "[00]");
            val_67 = mem[this.且丝丑一丁丆一万七].Substring(startIndex:  this.三不丏丘丘三丄三七);
            System.Text.StringBuilder val_49 = val_36.Append(value:  val_67);
        }
        
        val_55 = this.丞丛万三丑丂丗一丞;
        val_69 = val_62;
        goto label_93;
        label_59:
        this.丞丛万三丑丂丗一丞.text = mem[this.且丝丑一丁丆一万七];
        val_62 = 1152921505088262144;
        TypewriterEffect.current = val_55;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onFinished);
        TypewriterEffect.current = 0;
        this.万丝业下下丏丆丏东 = false;
        return;
        label_72:
        val_60 = this.keepFullDimensions;
        val_62 = this.丞丛万三丑丂丗一丞;
        val_55 = mem[this.且丝丑一丁丆一万七].Substring(startIndex:  0, length:  this.三不丏丘丘三丄三七);
        if(val_60 != false)
        {
                val_55 = val_55 + "[00]" + mem[this.且丝丑一丁丆一万七].Substring(startIndex:  this.三不丏丘丘三丄三七)(mem[this.且丝丑一丁丆一万七].Substring(startIndex:  this.三不丏丘丘三丄三七));
        }
        
        val_69 = val_55;
        label_93:
        val_62.text = val_69;
    }
    public TypewriterEffect()
    {
        this.charsPerSecond = 20;
        this.onFinished = new System.Collections.Generic.List<EventDelegate>();
        this.丑且丅丘丞丗丛丄丝 = true;
        this.且丝丑一丁丆一万七 = "";
        this.丈丈丝丕与东丘丘且 = new 丒丞丕丕七丁丗丟丛<丆下上丆丁业不丗丂>();
    }

}
