using UnityEngine;
private sealed class 七丈三丂且丗丈世一.且丄丂丏不丏丂丂世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.List<PGCompany.一三丛丅丌丒丙丆一> 丞专丙与三丑丑丆丗;
    public PGCompany.LootBoxSystem.七丈三丂且丗丈世一 丝且与丝丒丟万丁专;
    public 丈下专丂丑不丑丗丁 业七丄丄丘上丌不上;
    private System.Collections.Generic.List.Enumerator<PGCompany.一三丛丅丌丒丙丆一> 与业丕业业业丌丟丐;
    private PGCompany.一三丛丅丌丒丙丆一 上丞与下丟丟丄丛七;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 七丈三丂且丗丈世一.且丄丂丏不丏丂丂世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 97;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_9;
        List.Enumerator<PGCompany.一三丛丅丌丒丙丆一> val_10;
        List.Enumerator<PGCompany.一三丛丅丌丒丙丆一> val_21;
        int val_22;
        int val_23;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 3)
        {
            goto label_55;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        int val_1 = this.丟丗丒丟丝丘丞丝丏 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_1;
        goto label_39;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PixelTime.丝业丁丌丘东丏世与() != false)
        {
                val_21 = PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世();
            if((val_21.丄丙丙丑丝专世上丌() != false) && (ActivityIndicator.丙专三丙丌丝丏丌丅() != true))
        {
                if(UniversalRewardBanner.丈丐丞丐上丑且丕万() != true)
        {
                if(Rilisoft.GameEventOpenChestBase.丈丐丞丐上丑且丕万() == false)
        {
            goto label_16;
        }
        
        }
        
        }
        
        }
        
        val_22 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_22;
        return (bool)val_22;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_24;
        label_16:
        List.Enumerator<T> val_8 = this.丞专丙与三丑丑丆丗.GetEnumerator();
        val_21 = this.与业丕业业业丌丟丐;
        mem[1152921560427482680] = val_9;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_10;
        goto label_20;
        label_39:
        if(val_1 >= mem[this.上丞与下丟丟丄丛七])
        {
            goto label_24;
        }
        
        val_21 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  mem[this.上丞与下丟丟丄丛七].业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  1);
        this.丒上七丌业七丟与丐 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丝且与丝丒丟万丁专.丒丟丞丅丟丘丄丞丈(东丌一丟万丄丛且丗:  val_21, 业七丄丄丘上丌不上:  this.业七丄丄丘上丌不上));
        val_23 = 3;
        goto label_29;
        label_24:
        val_21 = this.与业丕业业业丌丟丐;
        this.上丞与下丟丟丄丛七 = 0;
        label_20:
        if((val_21 & 1) == 0)
        {
            goto label_30;
        }
        
        this.上丞与下丟丟丄丛七 = val_21.丐丏七丌丕丗业且上();
        this.丝且与丝丒丟万丁专.上下丙一丘下一丗丗 = 0;
        if(this.上丞与下丟丟丄丛七.世七不丆丘与与丁东() == false)
        {
            goto label_33;
        }
        
        val_21 = this.上丞与下丟丟丄丛七;
        val_23 = 2;
        this.丒上七丌业七丟与丐 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丝且与丝丒丟万丁专.丒丟丞丅丟丘丄丞丈(东丌一丟万丄丛且丗:  val_21.丑丐丙丄丅世世丑丒(), 业七丄丄丘上丌不上:  this.业七丄丄丘上丌不上));
        label_29:
        this.丗丏丅丕丆世丁专丟 = val_23;
        val_22 = 1;
        return (bool)val_22;
        label_30:
        this.一世丕丕业且且丅丌();
        val_22 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_22;
        label_33:
        this.丟丗丒丟丝丘丞丝丏 = 0;
        goto label_39;
        label_55:
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
