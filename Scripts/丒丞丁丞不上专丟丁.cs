using UnityEngine;
private sealed class TestFontsPanel.丒丞丁丞不上专丟丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TestFontsPanel 丝且与丝丒丟万丁专;
    private System.Collections.Generic.Dictionary.Enumerator<int, I2.Loc.LanguageSource> 与业丕业业业丌丟丐;
    private System.Collections.Generic.KeyValuePair<int, I2.Loc.LanguageSource> 丝上一丑丑专世丗丅;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TestFontsPanel.丒丞丁丞不上专丟丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        Dictionary.Enumerator<System.Int32, I2.Loc.LanguageSource> val_4;
        int val_18;
        var val_19;
        Dictionary.Enumerator<System.Int32, I2.Loc.LanguageSource> val_20;
        var val_21;
        int val_22;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_67;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        int val_17 = this.丝且与丝丒丟万丁专.labels.Length;
        val_17 = this.丟丗丒丟丝丘丞丝丏 + val_17;
        val_18 = val_17 - 1;
        this.丟丗丒丟丝丘丞丝丏 = val_18;
        goto label_37;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = null;
        val_19 = null;
        Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.丗丈下丕丟丟丙七丞.下且丛丐丕丘丐丑丒.GetEnumerator();
        val_20 = this.与业丕业业业丌丟丐;
        mem[1152921540523709224] = val_2;
        mem[1152921540523709208] = val_3;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_4;
        goto label_9;
        label_37:
        if(val_18 >= this.丝且与丝丒丟万丁专.丑丟丁丈丞三丟丄上.Count)
        {
            goto label_14;
        }
        
        val_4 = this.丝上一丑丑专世丗丅.丙东专丂世丈丏丁丂();
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0} - {1}", arg0:  val_4, arg1:  val_7.Language));
        val_21 = 0;
        goto label_19;
        label_28:
        if((val_21 + this.丟丗丒丟丝丘丞丝丏) < this.丝且与丝丒丟万丁专.丑丟丁丈丞三丟丄上.Count)
        {
                I2.Loc.TermData val_12 = this.丝且与丝丒丟万丁专.丑丟丁丈丞三丟丄上.Item[val_21 + this.丟丗丒丟丝丘丞丝丏];
            this.丝且与丝丒丟万丁专.labels[(long)this.丝且与丝丒丟万丁专.丑丟丁丈丞三丟丄上.Item[this.丟丗丒丟丝丘丞丝丏]].text = val_12.Language;
        }
        
        val_21 = 1;
        label_19:
        if((val_21 + 1) < this.丝且与丝丒丟万丁专.labels.Length)
        {
            goto label_28;
        }
        
        float val_20 = 100f;
        val_20 = (float)this.丟丗丒丟丝丘丞丝丏 * val_20;
        val_20 = val_20 / (float)this.丝且与丝丒丟万丁专.丑丟丁丈丞三丟丄上.Count;
        val_4 = val_20;
        val_18 = System.String.Format(format:  "{0} %", arg0:  val_4);
        this.丝且与丝丒丟万丁专.labels[0].text = val_18;
        val_22 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_22;
        return (bool)val_22;
        label_14:
        mem2[0] = 0;
        mem2[0] = 0;
        val_20 = this.与业丕业业业丌丟丐;
        label_9:
        if((val_20 & 1) == 0)
        {
            goto label_34;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_20.GetAwaiter();
        this.丝上一丑丑专世丗丅 = val_16._value._obj;
        mem[1152921540523709240] = val_16._value._token;
        mem[1152921540523709242] = val_16._value._continueOnCapturedContext;
        this.丝且与丝丒丟万丁专.丑丟丁丈丞三丟丄上 = 1152921540523709232;
        this.丟丗丒丟丝丘丞丝丏 = 0;
        goto label_37;
        label_34:
        this.一世丕丕业且且丅丌();
        val_22 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_22;
        label_67:
        val_22 = 0;
        return (bool)val_22;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
