using UnityEngine;
private sealed class RemotePushNotificationController.丕万丒世且丂万丌丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RemotePushNotificationController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemotePushNotificationController.丕万丒世且丂万丌丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_11 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(UnityEngine.Application.platform != 8)
        {
            goto label_3;
        }
        
        System.Text.StringBuilder val_4 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  val_2.Length << 1);
        if(val_2.Length >= 1)
        {
                do
        {
            System.Text.StringBuilder val_6 = val_4.Append(value:  System.Array.Empty<System.Byte>()[0].ToString(format:  "X2"));
        }
        while((0 + 1) < val_2.Length);
        
        }
        
        string val_8 = PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_4);
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[RemotePushNotificationController.WaitForTokenThenSendIfNeededIosCoroutine] Received deviceToken: "("[RemotePushNotificationController.WaitForTokenThenSendIfNeededIosCoroutine] Received deviceToken: ") + val_8);
        }
        
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丂不丏丙丝丐丂丑丗(不丒三业下丑不丞业:  val_8);
        val_11 = 1;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        val_11 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_11;
        label_3:
        val_11 = 0;
        return (bool)val_11;
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
