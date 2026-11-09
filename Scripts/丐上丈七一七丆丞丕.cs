using UnityEngine;
private sealed class PreloadTexture.丐上丈七一七丆丞丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PreloadTexture 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PreloadTexture.丐上丈七一七丆丞丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        var val_5;
        var val_6;
        UITexture val_7;
        val_4 = 0;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_4;
        if((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.pathTexture)) == false)
        {
            goto label_3;
        }
        
        val_4 = 1;
        goto label_4;
        label_1:
        val_5 = 0;
        val_6 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_5;
        }
        
        return (bool)val_6;
        label_3:
        UnityEngine.Texture val_2 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.丝且与丝丒丟万丁专.pathTexture);
        val_7 = this.丝且与丝丒丟万丁专.一丕丅丕丂丕丘且丘;
        if(val_7 != 0)
        {
                val_7 = this.丝且与丝丒丟万丁专.一丕丅丕丂丕丘且丘;
        }
        
        val_4 = 2;
        label_4:
        val_5 = 1;
        this.丒上七丌业七丟与丐 = 0;
        label_5:
        val_6 = val_5;
        this.丗丏丅丕丆世丁专丟 = val_4;
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
