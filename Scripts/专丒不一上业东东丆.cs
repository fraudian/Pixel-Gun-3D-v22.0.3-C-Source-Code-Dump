using UnityEngine;
private sealed class TurretController_HologramProjector.专丒不一上业东东丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretController_HologramProjector 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController_HologramProjector.专丒不一上业东东丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14 = 0;
        if(this.丗丏丅丕丆世丁专丟 > 4)
        {
                return (bool);
        }
        
        var val_13 = 106037712;
        val_13 = (106037712 + (this.丗丏丅丕丆世丁专丟) << 2) + val_13;
        goto (106037712 + (this.丗丏丅丕丆世丁专丟) << 2 + 106037712);
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
