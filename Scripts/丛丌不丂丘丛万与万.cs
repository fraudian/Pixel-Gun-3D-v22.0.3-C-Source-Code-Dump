using UnityEngine;
private sealed class 世与丛一丕丄丗丈丅.丛丌不丂丘丛万与万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丞丈丁与丏丌丌丆丂;
    public Rilisoft.世与丛一丕丄丗丈丅 丝且与丝丒丟万丁专;
    public 丈下专丂丑不丑丗丁 业七丄丄丘上丌不上;
    private System.Collections.Generic.List.Enumerator<PGCompany.三东丏不丗世丅丌丄> 与业丕业业业丌丟丐;
    private PGCompany.三东丏不丗世丅丌丄 世一丑与丛丘世丏万;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 世与丛一丕丄丗丈丅.丛丌不丂丘丛万与万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 2)
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
        var val_10;
        List.Enumerator<PGCompany.三东丏不丗世丅丌丄> val_11;
        List.Enumerator<PGCompany.三东丏不丗世丅丌丄> val_22;
        PGCompany.三东丏不丗世丅丌丄 val_23;
        int val_24;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
            goto label_15;
        }
        
        val_22 = PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世();
        if((((val_22.丄丙丙丑丝专世上丌() == false) || (ActivityIndicator.丙专三丙丌丝丏丌丅() == true)) || (UniversalRewardBanner.丈丐丞丐上丑且丕万() == true)) || (LootBoxBanner.丈丐丞丐上丑且丕万() == true))
        {
            goto label_15;
        }
        
        val_22 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        if((val_22.丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  100)) == false)
        {
            goto label_15;
        }
        
        List.Enumerator<T> val_9 = this.丞丈丁与丏丌丌丆丂.GetEnumerator();
        val_22 = this.与业丕业业业丌丟丐;
        val_23 = this.世一丑与丛丘世丏万;
        mem[1152921542699922504] = val_10;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_11;
        goto label_17;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_47;
        }
        
        val_23 = this.世一丑与丛丘世丏万;
        this.丗丏丅丕丆世丁专丟 = -3;
        int val_12 = this.丟丗丒丟丝丘丞丝丏 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_12;
        label_30:
        if(val_12 >= mem[this.世一丑与丛丘世丏万].丂丁丏一丙丛业且丌())
        {
            goto label_20;
        }
        
        val_22 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  mem[this.世一丑与丛丘世丏万].业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  1);
        this.丒上七丌业七丟与丐 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丝且与丝丒丟万丁专.丒丟丞丅丟丘丄丞丈(丄业丏丙且丞业上东:  val_22, 业七丄丄丘上丌不上:  0));
        this.丗丏丅丕丆世丁专丟 = 2;
        val_24 = 1;
        return (bool)val_24;
        label_15:
        val_24 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_20:
        mem2[0] = 0;
        val_22 = this.与业丕业业业丌丟丐;
        label_17:
        label_29:
        if((val_22 & 1) == 0)
        {
            goto label_27;
        }
        
        mem2[0] = val_22.丐丏七丌丕丗业且上();
        val_10 = 0;
        val_11 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丁丁上丛丞东下业丆>(丈丄不七三万丄丁不:  mem[this.世一丑与丛丘世丏万], 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == null)
        {
            goto label_29;
        }
        
        this.丟丗丒丟丝丘丞丝丏 = 0;
        goto label_30;
        label_27:
        this.一世丕丕业且且丅丌();
        val_24 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_24;
        label_47:
        val_24 = 0;
        return (bool)val_24;
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
