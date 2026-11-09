using UnityEngine;
private sealed class 丒丁丙丛上下丌丙丟.上且丙丏丒一七且业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丒丁丙丛上下丌丙丟 丝且与丝丒丟万丁专;
    private Player_move_c 下丟丞专丗世七丁丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒丁丙丛上下丌丙丟.上且丙丏丒一七且业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.世丑丐丅丆丂丘不丁() == true)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        this.下丟丞专丗世七丁丈 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if(this.丝且与丝丒丟万丁专.丒与万丝丁一一丙下 == true)
        {
                return false;
        }
        
        bool val_2 = UnityEngine.Object.op_Equality(x:  this.下丟丞专丗世七丁丈, y:  0);
        if(val_2 != false)
        {
                return false;
        }
        
        if(val_2.丌丌丕丁万丂业丆一() != false)
        {
                if(this.下丟丞专丗世七丁丈.丑丅三丗丌丞三丘丂 >= (float)this.丝且与丝丒丟万丁专.丒下世且业丗万丕不())
        {
                int val_6 = this.丝且与丝丒丟万丁专.上与丐丐丐丌一丗三(丏万丒丁丅七一丂丂:  UnityEngine.Mathf.RoundToInt(f:  this.下丟丞专丗世七丁丈.丑丅三丗丌丞三丘丂));
            if((val_6 & 2147483648) == 0)
        {
                this.丝且与丝丒丟万丁专.上不丕丌丄世丆丘丘(且下丆丕丝丄丑三三:  this.丝且与丝丒丟万丁专.与丂业上丅丟专丗丕(与上专万下丝东丗丛:  val_6));
        }
        
            if(this.丝且与丝丒丟万丁专.世丑丐丅丆丂丘不丁() == true)
        {
                return false;
        }
        
        }
        
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 1;
            return false;
        }
        
        this.丝且与丝丒丟万丁专.丒与万丝丁一一丙下 = true;
        return false;
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
