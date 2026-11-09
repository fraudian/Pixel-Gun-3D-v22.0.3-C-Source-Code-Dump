using UnityEngine;
private sealed class BuffController.丈丂丌上世与丆万丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BuffController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BuffController.丈丂丌上世与丆万丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_18;
        var val_19;
        var val_20;
        int val_21;
        val_18 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.Clear();
        List.Enumerator<T> val_3 = PGCompany.BuffController.丆丆丒下与世上一不().GetEnumerator();
        val_18 = 0;
        val_19 = 0;
        var val_17 = 0;
        label_38:
        if((2129223584 & 1) == 0)
        {
            goto label_8;
        }
        
        List.Enumerator<T> val_8 = val_5.丐丏七丌丕丗业且上().世丙万丞上与一丌丅().GetEnumerator();
        label_22:
        if((2129223552 & 1) == 0)
        {
            goto label_11;
        }
        
        string val_9 = val_5.丐丏七丌丕丗业且上();
        if((this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.ContainsKey(key:  val_9.业上丙丞丐丄丆丅七())) != true)
        {
                this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.set_Item(key:  val_9.业上丙丞丐丄丆丅七(), value:  0);
        }
        
        上七丑业丙丒丙东丏 val_13 = val_9.业上丙丞丐丄丆丅七();
        this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.set_Item(key:  val_13, value:  val_9.世三丞丅丑丌丈丈一() + this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.Item[val_13]);
        goto label_22;
        label_11:
        val_17 = val_17 + 1;
        mem2[0] = 227;
        val_20 = val_19;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_17 == 1) || ((1152921553980710736 + ((0 + 1)) << 2) != 227))
        {
            goto label_35;
        }
        
        var val_18 = 0;
        val_18 = val_18 ^ (val_17 >> 31);
        val_17 = val_17 + val_18;
        goto label_38;
        label_35:
        if( == 0)
        {
            goto label_38;
        }
        
        goto label_38;
        label_4:
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_8:
        val_17 = val_17 + 1;
        mem2[0] = 255;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_17 == 1)
        {
            goto label_45;
        }
        
        if(( == 0) || ((1152921553980710736 + ((0 + 1)) << 2) == 255))
        {
            goto label_50;
        }
        
        label_49:
        label_50:
        val_21 = PGCompany.BuffController.丞丑与丏丏丄丂且丘;
        if(val_21 == null)
        {
                return (bool)val_21;
        }
        
        val_21.Invoke();
        label_1:
        val_21 = 0;
        return (bool)val_21;
        label_45:
        if( != 0)
        {
            goto label_49;
        }
        
        goto label_50;
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
