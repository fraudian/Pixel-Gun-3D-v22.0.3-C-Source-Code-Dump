using UnityEngine;
private sealed class BonusBankViewItem.且丛丏丗三丒丝上三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BonusBankViewItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BonusBankViewItem.且丛丏丗三丒丝上三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丕世专丒丁不丁丅丁 val_1 = null;
        val_4 = val_1;
        val_1 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  0.2f);
        val_5 = 1;
        this.丒上七丌业七丟与丐 = val_4;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        val_4 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        val_4.专丆万丝丌丆一丅丅(丙业与丙丗丝不丈东:  false);
        if(val_4.丐丗世丄不业丐丆上() == false)
        {
            goto label_5;
        }
        
        label_7:
        val_4.世丛业七专万业不丕();
        goto label_6;
        label_4:
        0.专丆万丝丌丆一丅丅(丙业与丙丗丝不丈东:  false);
        if(0.丐丗世丄不业丐丆上() == true)
        {
            goto label_7;
        }
        
        label_5:
        val_4.丅丏丅丘丗世丘万丆();
        label_6:
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
