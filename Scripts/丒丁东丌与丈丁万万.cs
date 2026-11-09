using UnityEngine;
private sealed class NurseryGuiController.丒丁东丌与丈丁万万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NurseryGuiController 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List<ArmoryCell> 丄且丈丒丟丗丑丄丕;
    private int 丈丌丝且业丏丈丂丁;
    private System.Collections.Generic.List.Enumerator<ArmoryCell> 丒与不丕东七丂上不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NurseryGuiController.丒丁东丌与丈丁万万(int 丗丏丅丕丆世丁专丟)
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
        var val_8;
        List.Enumerator<ArmoryCell> val_9;
        int val_15;
        List.Enumerator<ArmoryCell> val_16;
        var val_17;
        System.Func<ArmoryCell, System.String> val_19;
        System.Collections.Generic.List<ArmoryCell> val_20;
        int val_21;
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
            goto label_45;
        }
        
        val_15 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_15;
        label_2:
        val_16 = this.丒与不丕东七丂上不;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丟丆丕业丌丂丂且专 = true;
        }
        else
        {
                mem[200] = 1;
        }
        
        if((this.丝且与丝丒丟万丁专.listToSHowEffect == null) || (this.丝且与丝丒丟万丁专.listToSHowEffect.Count < 1))
        {
            goto label_9;
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = NurseryGuiController.<>c.<>9__65_0;
        if(val_19 == null)
        {
                val_19 = null;
            val_19 = new System.Func<ArmoryCell, System.String>(object:  NurseryGuiController.<>c.__il2cppRuntimeField_static_fields, method:  System.String NurseryGuiController.<>c::丟丞与丈一万下丌丘(ArmoryCell 丌丝万上丅丒一丈丘));
            NurseryGuiController.<>c.<>9__65_0 = val_19;
        }
        
        val_20 = System.Linq.Enumerable.ToList<ArmoryCell>(source:  System.Linq.Enumerable.OrderBy<ArmoryCell, System.String>(source:  this.丝且与丝丒丟万丁专.GetAllArmoryCellsInWrapContainer<ArmoryCell>(丟丝七七一丁丏丏丙:  true), keySelector:  null));
        if(val_20 == null)
        {
                val_20 = null;
            val_20 = new System.Collections.Generic.List<ArmoryCell>();
        }
        
        val_21 = 0;
        this.丄且丈丒丟丗丑丄丕 = val_20;
        this.丈丌丝且业丏丈丂丁 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_31;
        }
        
        goto label_17;
        label_33:
        List.Enumerator<T> val_7 = this.丄且丈丒丟丗丑丄丕.GetEnumerator();
        val_16 = this.丒与不丕东七丂上不;
        mem[1152921538468128584] = val_8;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丒与不丕东七丂上不 = val_9;
        label_5:
        if((val_16 & 1) != 0)
        {
                string val_10 = val_16.丐丏七丌丕丗业且上();
            new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            val_15 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
            this.丗丏丅丕丆世丁专丟 = val_15;
            return (bool)val_15;
        }
        
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_21 = this.丈丌丝且业丏丈丂丁 + 1;
        this.丈丌丝且业丏丈丂丁 = val_21;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_31;
        }
        
        label_17:
        label_31:
        if(val_21 < this.丝且与丝丒丟万丁专.listToSHowEffect.Count)
        {
            goto label_33;
        }
        
        val_16 = this.丝且与丝丒丟万丁专.listToSHowEffect;
        val_16.Clear();
        this.丄且丈丒丟丗丑丄丕 = 0;
        label_9:
        this.丝且与丝丒丟万丁专.丟丆丕业丌丂丂且专 = false;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_15 = 1;
        return (bool)val_15;
        label_45:
        val_15 = 0;
        return (bool)val_15;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.丒与不丕东七丂上不);
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
