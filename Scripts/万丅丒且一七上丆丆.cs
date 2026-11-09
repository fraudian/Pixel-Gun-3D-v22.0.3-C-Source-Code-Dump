using UnityEngine;
private sealed class UIMapBase.万丅丒且一七上丆丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NJG.UIMapBase 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIMapBase.万丅丒且一七上丆丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_7;
        int val_8;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        if(this.丝且与丝丒丟万丁专.三上下丁丅丅下上丑 != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.三上下丁丅丅下上丑.Item[this.丝且与丝丒丟万丁专.三上下丁丅丅下上丑.clip.name].length);
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = this.丝且与丝丒丟万丁专.丙专万丙丏业下丛丛;
        丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_7.gameObject, 丏业丟一东丂东丘丛:  false);
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        if(380 != 0)
        {
            goto label_11;
        }
        
        goto label_12;
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
