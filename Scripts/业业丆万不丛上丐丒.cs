using UnityEngine;
private sealed class 丐不三丆丝丅丞丞与.业业丆万不丛上丐丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丆丐七丅丆丗丛上与;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    public PGCompany.MainStore.丐不三丆丝丅丞丞与 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐不三丆丝丅丞丞与.业业丆万不丛上丐丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_4;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丕世专丒丁不丁丅丁 val_1 = null;
        val_3 = val_1;
        val_1 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  this.丆丐七丅丆丗丛上与);
        val_4 = 1;
        this.丒上七丌业七丟与丐 = val_3;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        val_3 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.业丘丝业丛丆丄一上 & 1) == 0)
        {
                if(PGCompany.MainStore.丐不三丆丝丅丞丞与.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[AdvertStoreSectionContentProvider.WaitThenRefreshCoroutine] ChangePromotion");
        }
        
            val_3.丅丐丐丂丁丐上与丏();
        }
        
        label_4:
        val_4 = 0;
        return (bool)val_4;
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
