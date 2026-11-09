using UnityEngine;
private sealed class 专丗丗专丆与丑三业.丅丅万上丂丝丒世丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.专丗丗专丆与丑三业 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 专丗丗专丆与丑三业.丅丅万上丂丝丒世丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.专丗丗专丆与丑三业 val_7;
        var val_8;
        var val_9;
        var val_10;
        Player_move_c val_11;
        int val_12;
        int val_13;
        var val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = this.丝且与丝丒丟万丁专;
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_17;
        }
        
        val_9 = null;
        val_9 = null;
        if((UnityEngine.Object.op_Implicit(exists:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_17;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_12 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        val_12 = 0;
        return (bool)val_12;
        label_17:
        if(val_7 != null)
        {
                val_11 = val_7;
            val_13 = this.丝且与丝丒丟万丁专.丈丛与东且丒专丐一;
            mem2[0] = 0;
        }
        else
        {
                mem[52] = 0;
            val_11 = 48;
            val_13 = 0;
        }
        
        if(0 >= val_7.丒下世且业丗万丕不())
        {
                if(val_7 != null)
        {
            
        }
        else
        {
                val_14 = 0;
        }
        
            int val_4 = val_7.上与丐丐丐丌一丗三(丏万丒丁丅七一丂丂:  0);
            if((val_4 & 2147483648) == 0)
        {
                if(val_7 != null)
        {
                val_15 = val_7.与丂业上丅丟专丗丕(与上专万下丝东丗丛:  val_4);
        }
        else
        {
                val_15 = val_7.与丂业上丅丟专丗丕(与上专万下丝东丗丛:  val_4);
        }
        
            val_7.上不丕丌丄世丆丘丘(且下丆丕丝丄丑三三:  val_15);
        }
        
        }
        
        val_12 = 0;
        mem[48] = 0;
        return (bool)val_12;
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
