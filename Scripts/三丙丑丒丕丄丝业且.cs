using UnityEngine;
private sealed class Graffiti.三丙丑丒丕丄丝业且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Graffiti 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Graffiti.三丙丑丒丕丄丝业且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 = 0f;
        goto label_4;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 <= 1f)
        {
            goto label_5;
        }
        
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_5:
        float val_1 = UnityEngine.Time.deltaTime;
        val_2 = 1;
        val_1 = val_1 / (float)this.丝且与丝丒丟万丁专.丟丄丕丝丝上三一丒;
        val_1 = this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 + val_1;
        this.丝且与丝丒丟万丁专.丙一丑丏丁一且丒业 = val_1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
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
