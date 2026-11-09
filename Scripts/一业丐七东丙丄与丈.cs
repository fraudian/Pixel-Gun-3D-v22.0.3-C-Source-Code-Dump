using UnityEngine;
private sealed class 丝丏丏丕丏丘丑丐丞.一业丐七东丙丄与丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ShopSystem.丝丏丏丕丏丘丑丐丞 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丝丏丏丕丏丘丑丐丞.一业丐七东丙丄与丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_0;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_1;
        }
        
        this.丝且与丝丒丟万丁专.且丛一三业丈丝丞丅();
        goto label_4;
        label_0:
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
                val_3 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_3;
            return (bool)val_3;
        }
        
        label_4:
        val_3 = 0;
        return (bool)val_3;
        label_1:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_3 = 1;
        return (bool)val_3;
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
