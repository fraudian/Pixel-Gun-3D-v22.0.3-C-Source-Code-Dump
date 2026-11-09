using UnityEngine;
private sealed class LootBoxRewardsViewOneByOneSingle.丝世丏丑上丌丒与专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LootBoxRewardsViewOneByOneSingle 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LootBoxRewardsViewOneByOneSingle.丝世丏丑上丌丒与专(int 丗丏丅丕丆世丁专丟)
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
        int val_10;
        float val_12;
        int val_13;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_45;
        }
        
        var val_9 = 106046424 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_9 = val_9 + 106046424;
        goto (106046424 + (this.丗丏丅丕丆世丁专丟) << 2 + 106046424);
        label_45:
        val_10 = 0;
        return (bool)val_10;
        label_30:
        if((this.与业丕业业业丌丟丐 & 1) == 0)
        {
            goto label_22;
        }
        
        string val_6 = this.与业丕业业业丌丟丐.丐丏七丌丕丗业且上();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  X23, 丏业丟一东丂东丘丛:  true);
        X23.丈且东丑丂且万丒丅(丆丈丑丅东丙丘三且:  val_6);
        (丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished == 0) ? () : 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished.Invoke(obj:  val_6);
        mem[1152921537726239448] = 1152921537701606704;
        val_12 = 4.923437E-34f;
        if(val_12 > 0f)
        {
            goto label_29;
        }
        
        goto label_30;
        label_29:
        val_13 = 2;
        this.丒上七丌业七丟与丐 = 0;
        goto label_31;
        label_22:
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.startDelay);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        val_13 = 3;
        label_31:
        this.丗丏丅丕丆世丁专丟 = val_13;
        val_10 = 1;
        return (bool)val_10;
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
