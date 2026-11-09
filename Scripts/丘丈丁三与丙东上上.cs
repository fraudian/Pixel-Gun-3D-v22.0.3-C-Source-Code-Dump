using UnityEngine;
private sealed class DeviceOrientationMonitor.丘丈丁三与丙东上上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private 丕世专丒丁不丁丅丁 与丈三世下东世且丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DeviceOrientationMonitor.丘丈丁三与丙东上上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        int val_12;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        DeviceOrientationMonitor.丑丌丄丘与一丗丒丟(丙业与丙丗丝不丈东:  UnityEngine.Input.deviceOrientation);
        this.与丈三世下东世且丝 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  DeviceOrientationMonitor.专丟丕丄丈丒丘丟丘);
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        UnityEngine.DeviceOrientation val_3 = UnityEngine.Input.deviceOrientation;
        if((val_3 - 3) < 2)
        {
            goto label_6;
        }
        
        if(((val_3 != 5) || (DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() == 3)) || (DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() == 4))
        {
            goto label_20;
        }
        
        DeviceOrientationMonitor.丑丌丄丘与一丗丒丟(丙业与丙丗丝不丈东:  3);
        val_11 = null;
        goto label_16;
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_6:
        if(DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅() == UnityEngine.Input.deviceOrientation)
        {
            goto label_20;
        }
        
        DeviceOrientationMonitor.丑丌丄丘与一丗丒丟(丙业与丙丗丝不丈东:  UnityEngine.Input.deviceOrientation);
        val_11 = null;
        label_16:
        DeviceOrientationMonitor.七丝丌七世丙丗丐上.Invoke(obj:  DeviceOrientationMonitor.丞丌七丞丕丄丗丝丅());
        label_20:
        val_12 = 1;
        this.丗丏丅丕丆世丁专丟 = val_12;
        this.丒上七丌业七丟与丐 = this.与丈三世下东世且丝;
        return (bool)val_12;
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
