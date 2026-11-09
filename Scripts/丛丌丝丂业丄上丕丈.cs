using UnityEngine;
private sealed class UIPopupList.丛丌丝丂业丄上丕丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UIPopupList 丝且与丝丒丟万丁专;
    private TweenPosition 不丄上丌丕上丙专丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIPopupList.丛丌丝丂业丄上丕丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UISprite val_6;
        var val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.丝且与丝丒丟万丁专.mHighlight;
        if(val_6 == 0)
        {
            goto label_21;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.mHighlightedLabel;
        if(val_6 == 0)
        {
            goto label_21;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.mHighlight.GetComponent<TweenPosition>();
        val_7 = this;
        this.不丄上丌丕上丙专丞 = val_6;
        goto label_11;
        label_1:
        val_7 = this;
        val_6 = this.不丄上丌丕上丙专丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_11:
        if(val_6 == 0)
        {
            goto label_16;
        }
        
        val_6 = this.不丄上丌丕上丙专丞;
        if(val_6.enabled == false)
        {
            goto label_16;
        }
        
        val_6 = this.不丄上丌丕上丙专丞;
        val_8 = 1;
        to = V0.16B;
        mem2[0] = V1.16B;
        mem2[0] = V2.16B;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_16:
        this.不丄上丌丕上丙专丞 = 0;
        label_21:
        val_8 = 0;
        this.丝且与丝丒丟万丁专.业丐不丞丝三万丂丈 = false;
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
