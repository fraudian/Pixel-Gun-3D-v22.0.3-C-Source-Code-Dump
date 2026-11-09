using UnityEngine;
private sealed class PGTweener.一丐丙丐下上丙丂丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGTweener 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PGTweener.一丐丙丐下上丙丂丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGTweener val_6;
        System.Action val_7;
        float val_8;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.丝且与丝丒丟万丁专;
        if((val_6 == 0) || (this.丝且与丝丒丟万丁专.丘丄丆不丛丗上三上 == false))
        {
            goto label_6;
        }
        
        float val_6 = this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世;
        if(val_6 <= this.丝且与丝丒丟万丁专.duration)
        {
            goto label_7;
        }
        
        label_6:
        if(val_6 != 0)
        {
                if(val_6 != null)
        {
                this.丝且与丝丒丟万丁专.丘丄丆不丛丗上三上 = true;
        }
        else
        {
                mem[32] = 1;
        }
        
            val_7 = this.丝且与丝丒丟万丁专.丟丘丙丄丅万丏与丗;
            if(val_7 == null)
        {
                return (bool)val_7;
        }
        
            val_7.Invoke();
        }
        
        label_10:
        val_7 = 0;
        return (bool)val_7;
        label_7:
        val_6 = val_6 + UnityEngine.Time.deltaTime;
        this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世 = val_6;
        if(this.丝且与丝丒丟万丁专.duration > 0f)
        {
                val_8 = (UnityEngine.Mathf.Min(a:  val_6, b:  this.丝且与丝丒丟万丁专.duration)) / this.丝且与丝丒丟万丁专.duration;
        }
        else
        {
                val_8 = 1f;
        }
        
        float val_5 = this.丝且与丝丒丟万丁专.animationCurve.Evaluate(time:  val_8);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_7;
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
