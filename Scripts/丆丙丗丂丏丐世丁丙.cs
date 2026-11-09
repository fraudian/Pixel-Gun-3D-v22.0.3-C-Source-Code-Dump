using UnityEngine;
private sealed class OnClickDestroy.丆丙丗丂丏丐世丁丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public OnClickDestroy 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OnClickDestroy.丆丙丗丂丏丐世丁丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.gameObject);
        this.丒上七丌业七丟与丐 = 0;
        val_5 = 1;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = this.丝且与丝丒丟万丁专.photonView.viewID;
        丅丒丗丑丒丙丛不丆.丈丙丕业丟东丟不下(世上丕丐丈世上不丏:  val_4);
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
