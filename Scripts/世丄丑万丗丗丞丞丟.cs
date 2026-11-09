using UnityEngine;
private sealed class Switcher.世丄丑万丗丗丞丞丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Switcher 丝且与丝丒丟万丁专;
    private string 丏万不丘丟丘丏丅丌;
    private string 丆丁世丂业丈上丂丏;
    private byte[] 东与丌丁丝丌丏丛三;
    private byte[] 三一丗三丟专下丝上;
    private string[] 丑丅丞不不丏上丄丅;
    private int 丑不专丒丆丛七不业;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Switcher.世丄丑万丗丗丞丞丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_48;
        int val_49;
        int val_53;
        var val_58;
        var val_61;
        var val_66;
        var val_67;
        val_48 = this;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_1;
        }
        
        var val_46 = 106015604 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_46 = val_46 + 106015604;
        goto (106015604 + (this.丗丏丅丕丆世丁专丟) << 2 + 106015604);
        label_1:
        val_49 = 0;
        return (bool)val_49;
        label_129:
        if(((X22 + 176 + 8) + -8) == null)
        {
            goto label_128;
        }
        
         =  + 1;
         =  + 16;
        if( < (X22 + 286))
        {
            goto label_129;
        }
        
        goto label_130;
        label_128:
         =  + (((X22 + 176 + 8)) << 4);
        val_66 =  + 296;
        label_130:
        X22.Dispose();
        if(( != 1) && (724 == 724))
        {
                val_61 = 0;
        }
        else
        {
                if(null != null)
        {
                val_53 = 0;
        }
        
        }
        
        val_67 = 0 + 1;
        mem2[0] = 738;
        if(new System.InvalidOperationException() != null)
        {
            goto label_135;
        }
        
        goto label_139;
        label_135:
        System.InvalidOperationException val_56 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_143;
        }
        
        var val_54 = mem[null + 176];
        var val_55 = 0;
        val_54 = val_54 + 8;
        label_142:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_141;
        }
        
        val_55 = val_55 + 1;
        val_54 = val_54 + 16;
        if(val_55 < (mem[null + 286]))
        {
            goto label_142;
        }
        
        goto label_143;
        label_141:
        val_56 = val_56 + (((mem[null + 176] + 8)) << 4);
        label_143:
        1152921504622235648.Dispose();
        label_139:
        if( == 1)
        {
            goto label_144;
        }
        
        if(null == null)
        {
            goto label_160;
        }
        
        if(724 != 738)
        {
            goto label_146;
        }
        
        goto label_160;
        label_144:
        if(null == null)
        {
            goto label_160;
        }
        
        label_146:
        label_160:
        mem[1152921540459786104] = 0;
        val_58 = 3;
        mem[1152921540459786096] = val_58;
        val_49 = 1;
        return (bool)val_49;
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
