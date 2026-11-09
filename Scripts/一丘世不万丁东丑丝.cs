using UnityEngine;
private sealed class VIPNotificationController.一丘世不万丁东丑丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VIPNotificationController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VIPNotificationController.一丘世不万丁东丑丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        System.Func<System.Boolean> val_6;
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = null;
        val_4 = null;
        val_6 = VIPNotificationController.<>c.<>9__11_0;
        if(val_6 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  VIPNotificationController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean VIPNotificationController.<>c::丅丒丁丂丑丘不丏丅());
            VIPNotificationController.<>c.<>9__11_0 = val_6;
        }
        
        val_7 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_1);
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        0.TryShowVipExpiredMessage();
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  0.5f);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_7 = 1;
        return (bool)val_7;
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
