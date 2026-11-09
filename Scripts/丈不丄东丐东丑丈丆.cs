using UnityEngine;
private sealed class RemotePushNotificationController.丈不丄东丐东丑丈丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RemotePushNotificationController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemotePushNotificationController.丈不丄东丐东丑丈丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_18;
        var val_19;
        int val_20;
        ulong val_21;
        var val_22;
        PGCompany.Messaging.上丙且丙丂上丁丕下 val_6 = 0;
        string val_8 = 0;
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
            goto label_25;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        string val_1 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
        val_18 = val_1;
        if((System.String.IsNullOrWhiteSpace(value:  val_1)) == false)
        {
            goto label_12;
        }
        
        val_19 = null;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() == false)
        {
            goto label_10;
        }
        
        UnityEngine.Debug.Log(message:  "[RemotePushNotificationController.RefreshMetadataThenSendTokenIosCoroutine] Waiting for playerId available...");
        goto label_10;
        label_1:
        val_20 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_20;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        string val_4 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
        val_18 = val_4;
        if((System.String.IsNullOrWhiteSpace(value:  val_4)) == false)
        {
            goto label_12;
        }
        
        label_10:
        val_20 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
        label_12:
        if((PGCompany.Messaging.上丒专丆世一丅丅一.丂东丐丁丅丙丐丙丛(丄丒且丙三丆丟与丏:  val_18, 丘专专三丒丝上且丄: out  val_6)) != false)
        {
                val_21 = val_6;
            if((val_21.丘下丛上丑丌丌丌丑(不丒三业下丑不丞业: out  val_8)) != false)
        {
                System.DateTimeOffset val_10 = System.DateTimeOffset.Now;
            System.DateTime val_11 = val_10.m_dateTime.dateData.ToUniversalTime();
            val_21 = val_11.dateData;
            this.丒上七丌业七丟与丐 = 0.丐丁丂七下丄东丏一(丄丒且丙三丆丟与丏:  val_18, 一丏一世丘丐丁丄丟:  new System.DateTime() {dateData = val_21}, 丞丞丐丝丝丏丐丛丞:  丟丏下丂七三下丗丕.万丙业下丅丐丕万与(), 三世东丅丁世且专不:  val_10.m_dateTime.dateData.Hours, 不丒三业下丑不丞业:  val_8, 丑丞东万丁丂丏万丙:  "RefreshMetadataThenSendTokenIosCoroutine");
            this.丗丏丅丕丆世丁专丟 = 2;
            val_20 = 1;
            return (bool)val_20;
        }
        
        }
        
        val_22 = null;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() != false)
        {
                object[] val_16 = new object[5];
            val_16[0] = "RemotePushNotificationController.RefreshMetadataThenSendTokenIosCoroutine";
            val_21 = "playerId";
            val_16[1] = val_21;
            val_16[2] = val_18;
            val_16[3] = val_6;
            val_16[4] = val_6;
            val_18 = System.String.Format(format:  "[{0}] Nothing to send. {1}: {2}, {3}: {4}", args:  val_16);
            UnityEngine.Debug.Log(message:  val_18);
        }
        
        label_25:
        val_20 = 0;
        return (bool)val_20;
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
