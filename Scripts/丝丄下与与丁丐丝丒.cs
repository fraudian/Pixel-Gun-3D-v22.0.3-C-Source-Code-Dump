using UnityEngine;
private sealed class EggIncubatorManager.丝丄下与与丁丐丝丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public EggIncubatorManager 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<EggIncubatorController> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EggIncubatorManager.丝丄下与与丁丐丝丒(int 丗丏丅丕丆世丁专丟)
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
        var val_3;
        var val_6;
        List.Enumerator<EggIncubatorController> val_7;
        List.Enumerator<EggIncubatorController> val_18;
        System.Collections.Generic.List<EggIncubatorController> val_19;
        var val_20;
        var val_21;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_64;
        }
        
        val_18 = this.与业丕业业业丌丟丐;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = this.丝且与丝丒丟万丁专.eggIncuatorList;
        if(val_19 == null)
        {
                return (bool)val_19;
        }
        
        List.Enumerator<T> val_1 = val_19.GetEnumerator();
        label_10:
        if(((-517590688) & 1) == 0)
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        List.Enumerator<T> val_5 = this.丝且与丝丒丟万丁专.eggIncuatorList.GetEnumerator();
        val_18 = this.与业丕业业业丌丟丐;
        mem[1152921538449006808] = val_6;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_7;
        label_4:
        if((val_18 & 1) != 0)
        {
                string val_8 = val_18.丐丏七丌丕丗业且上();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
            val_8.ShowCreate();
            new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.23f);
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
            this.丗丏丅丕丆世丁专丟 = 2;
            val_19 = 1;
            return (bool)val_19;
        }
        
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        EggIncubatorController val_10 = this.丝且与丝丒丟万丁专.eggIncuatorList.Item[0];
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 0)
        {
                if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 1)
        {
                if(NurseryTrainingController.丁丏丒专一丄丏丙七() != 2)
        {
            goto label_64;
        }
        
        }
        
        }
        
        NurseryGuiController val_14 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_14.trainingController.UpdateTrainingStep(丒且丆丘丞丑业丅不:  1);
        NurseryGuiController.且丕丈丙丛不业丂丗().不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  0, 丕丝丟下丗丛一丕业:  true);
        label_64:
        val_19 = 0;
        return (bool)val_19;
        label_7:
        val_20 = 0;
        val_21 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_52;
        }
        
        if( == 0)
        {
            goto label_56;
        }
        
        if(109 != 109)
        {
            goto label_54;
        }
        
        goto label_56;
        label_52:
        if( == 0)
        {
            goto label_56;
        }
        
        label_54:
        label_56:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_19;
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
