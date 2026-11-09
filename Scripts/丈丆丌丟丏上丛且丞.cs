using UnityEngine;
private sealed class PlayerAnimationWrapper.丈丆丌丟丏上丛且丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerAnimationWrapper 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerAnimationWrapper.丈丆丌丟丏上丛且丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_0;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_1;
        label_5:
        val_5 = this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丝且与丝丒丟万丁专.landingHeadMoveSpeed * val_1;
        val_1 = val_5 + val_1;
        this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌 = val_1;
        if(val_1 <= this.丝且与丝丒丟万丁专.maxLandingHeadMove)
        {
            goto label_2;
        }
        
        mem2[0] = this.丝且与丝丒丟万丁专.maxLandingHeadMove;
        label_1:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_6 = mem[this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌];
            val_6 = val_4;
        }
        else
        {
                val_6 = mem[this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌];
            val_6 = val_4;
        }
        
        if(val_6 < 0)
        {
            goto label_5;
        }
        
        goto label_8;
        label_0:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_7;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_8;
        label_14:
        mem2[0] = 0;
        label_8:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        val_5 = mem[this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌];
        val_5 = val_4;
        if(val_5 <= 0f)
        {
            goto label_13;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丝且与丝丒丟万丁专.landingHeadMoveSpeed * val_2;
        val_7 = val_5 - val_2;
        this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌 = val_7;
        goto label_12;
        label_10:
        val_5 = mem[this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌];
        val_5 = val_4;
        if(val_5 <= 0f)
        {
            goto label_13;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_5 = val_3;
        val_3 = this.丝且与丝丒丟万丁专.landingHeadMoveSpeed * val_5;
        val_3 = this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌 - val_3;
        this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌 = val_3;
        val_7 = this.丝且与丝丒丟万丁专.三丞丂丈世丂丅业丌;
        label_12:
        if(val_7 < 0)
        {
            goto label_14;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_8 = 1;
        return (bool)val_8;
        label_2:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_7:
        val_8 = 0;
        return (bool)val_8;
        label_13:
        val_8 = 0;
        this.丝且与丝丒丟万丁专.丛一丟下东与丐丗世 = 0;
        return (bool)val_8;
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
