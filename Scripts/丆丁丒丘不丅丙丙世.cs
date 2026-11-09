using UnityEngine;
private sealed class SimpleTween.丆丁丒丘不丅丙丙世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SimpleTween 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SimpleTween.丆丁丒丘不丅丙丙世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SimpleTween val_7;
        float val_8;
        float val_9;
        var val_10;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
                return false;
        }
        
        val_7 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丘丄丆不丛丗上三上 != false)
        {
                if(this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世 <= this.丝且与丝丒丟万丁专._duration)
        {
            goto label_4;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.animationCurve == null)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专.丕丛丂丞世丁丐丌专 == false)
        {
            goto label_6;
        }
        
        label_13:
        val_8 = 0f;
        goto label_7;
        label_4:
        if(this.丝且与丝丒丟万丁专._duration <= 0f)
        {
            goto label_10;
        }
        
        val_9 = (UnityEngine.Mathf.Min(a:  this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世, b:  this.丝且与丝丒丟万丁专._duration)) / this.丝且与丝丒丟万丁专._duration;
        val_10 = 1f - val_9;
        goto label_12;
        label_5:
        if(this.丝且与丝丒丟万丁专.丕丛丂丞世丁丐丌专 == true)
        {
            goto label_13;
        }
        
        label_6:
        val_8 = 1f;
        label_7:
        float val_3 = this.丝且与丝丒丟万丁专.animationCurve.Evaluate(time:  this.丝且与丝丒丟万丁专.animationCurve.Evaluate(time:  val_8));
        val_7.万丏丛东下丝下丟丕();
        return false;
        label_10:
        val_9 = 1f;
        val_10 = 0f;
        label_12:
        float val_5 = this.丝且与丝丒丟万丁专.animationCurve.Evaluate(time:  (this.丝且与丝丒丟万丁专.丕丛丂丞世丁丐丌专 == true) ? (val_10) : (val_9));
        float val_6 = UnityEngine.Time.unscaledDeltaTime;
        val_6 = this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世 + val_6;
        this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世 = val_6;
        if((this.丝且与丝丒丟万丁专.loop != false) && (val_6 > this.丝且与丝丒丟万丁专._duration))
        {
                this.丝且与丝丒丟万丁专.丏一上东丗丘三丂世 = 0f;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
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
