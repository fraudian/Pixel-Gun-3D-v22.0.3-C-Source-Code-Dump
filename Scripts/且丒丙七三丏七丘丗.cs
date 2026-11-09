using UnityEngine;
private sealed class RemotePushNotificationController.且丒丙七三丏七丘丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 不丒三业下丑不丞业;
    public RemotePushNotificationController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemotePushNotificationController.且丒丙七三丏七丘丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_38;
        int val_39;
        val_38 = this;
        PGCompany.Messaging.上丙且丙丂上丁丕下 val_12 = 0;
        string val_17 = 0;
        if(this.丗丏丅丕丆世丁专丟 <= 5)
        {
                var val_38 = 106016576 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_38 = val_38 + 106016576;
        }
        else
        {
                val_39 = 0;
            return (bool);
        }
    
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
