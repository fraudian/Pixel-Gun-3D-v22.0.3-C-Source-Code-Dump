using UnityEngine;
private sealed class FiringShotBot.丒丗不丕业丄丌丌业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.FiringShotBot 丝且与丝丒丟万丁专;
    public UnityEngine.GameObject 丏不丂丆且三丞丆丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FiringShotBot.丒丗不丕业丄丌丌业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丛业丗丏下丌丏丗丗 == false)
        {
            goto label_4;
        }
        
        label_2:
        val_2 = 0;
        return val_2;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丏不丂丆且三丞丆丏.SetActive(value:  false);
        val_2 = 0;
        this.丝且与丝丒丟万丁专.丛业丗丏下丌丏丗丗 = false;
        return val_2;
        label_4:
        val_2 = true;
        this.丝且与丝丒丟万丁专.丛业丗丏下丌丏丗丗 = val_2;
        this.丏不丂丆且三丞丆丏.SetActive(value:  true);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.timeShowFireEffect);
        this.丗丏丅丕丆世丁专丟 = val_2;
        return val_2;
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
