using UnityEngine;
private sealed class VideoPlayerWindow.丙丛且丞世丛丂丅丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VideoPlayerWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VideoPlayerWindow.丙丛且丞世丛丂丅丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_5;
        int val_6;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.skipButton, 丏业丟一东丂东丘丛:  false);
        if((this.丝且与丝丒丟万丁专.丁丘丌丟丘七丁丑丟 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.丁丘丌丟丘七丁丑丟 = (int)UnityEngine.Mathf.Clamp(value:  (float)this.丝且与丝丒丟万丁专.丁丘丌丟丘七丁丑丟, min:  0f, max:  (float)this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.clip.length);
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  (float)(int)UnityEngine.Mathf.Clamp(value:  (float)this.丝且与丝丒丟万丁专.丁丘丌丟丘七丁丑丟, min:  0f, max:  (float)this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.clip.length));
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this.丝且与丝丒丟万丁专.skipButton;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  true);
        label_6:
        val_6 = 0;
        return (bool)val_6;
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
