using UnityEngine;
private sealed class 丕丂上丕丌七丈丝丑.上三万三世一丑丈丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.丕丂上丕丌七丈丝丑 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丕丂上丕丌七丈丝丑.上三万三世一丑丈丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action<System.String> val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.且丗丏世上下丗丒丒 <= 0f)
        {
            goto label_4;
        }
        
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.且丗丏世上下丗丒丒);
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_2 = PGCompany.丕丂上丕丌七丈丝丑.三丛东下丒下业丟不;
        if(val_2 != null)
        {
                val_2.Invoke(obj:  this.丝且与丝丒丟万丁专.上丟丅三丑下丙万丐);
        }
        
        label_6:
        val_3 = 0;
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
