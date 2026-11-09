using UnityEngine;
private sealed class VehicleController.且丆且一业丐一一丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VehicleController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VehicleController.且丆且一业丐一一丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.engine.isGrounded == false)
        {
            goto label_4;
        }
        
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.丈不万专世丒丆丗丆(丙业与丙丗丝不丈东:  false);
        TransportSyncBase val_1 = this.丝且与丝丒丟万丁专.GetComponent<TransportSyncBase>();
        label_5:
        val_2 = 0;
        return (bool)val_2;
        label_4:
        val_2 = 1;
        mem2[0] = val_2;
        this.丝且与丝丒丟万丁专.丈不万专世丒丆丗丆(丙业与丙丗丝不丈东:  true);
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
