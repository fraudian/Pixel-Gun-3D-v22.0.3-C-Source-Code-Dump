using UnityEngine;
private sealed class RemotePushNotificationController.丟万丗上世丄与七丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丑丞东万丁丂丏万丙;
    public string 丄丒且丙三丆丟与丏;
    public string 不丒三业下丑不丞业;
    private RemotePushNotificationController.丛东丟丅丙丗世丗不 丄丌丂东丘丗一万且;
    public string 丞丞丐丝丝丏丐丛丞;
    public int 三世东丅丁世且专不;
    public System.DateTime 一丏一世丘丐丁丄丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemotePushNotificationController.丟万丗上世丄与七丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_43;
        int val_44;
        string val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        val_43 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_44 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_44;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new RemotePushNotificationController.丛东丟丅丙丗世丗不();
        .丑丞东万丁丂丏万丙 = this.丑丞东万丁丂丏万丙;
        val_45 = this.丄丒且丙三丆丟与丏;
        this.丄丌丂东丘丗一万且.丄丒且丙三丆丟与丏 = val_45;
        val_46 = null;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() != false)
        {
                string[] val_3 = new string[6];
            val_3[0] = "[RemotePushNotificationController.SendTokenIosCoroutine] playerId: ";
            val_3[1] = this.丄丌丂东丘丗一万且.丄丒且丙三丆丟与丏;
            val_3[2] = ", token: ";
            val_3[3] = this.不丒三业下丑不丞业;
            val_3[4] = ", callerName: ";
            val_45 = this.丄丌丂东丘丗一万且.丑丞东万丁丂丏万丙;
            val_3[5] = val_45;
            UnityEngine.Debug.Log(message:  +val_3);
        }
        
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == true)
        {
            goto label_34;
        }
        
        val_47 = null;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() == false)
        {
            goto label_45;
        }
        
        UnityEngine.Debug.Log(message:  "[RemotePushNotificationController.SendTokenIosCoroutine] Waiting for IsAuthorized... callerName: "("[RemotePushNotificationController.SendTokenIosCoroutine] Waiting for IsAuthorized... callerName: ") + this.丄丌丂东丘丗一万且.丑丞东万丁丂丏万丙);
        goto label_45;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
        {
            goto label_45;
        }
        
        label_34:
        val_48 = null;
        val_48 = null;
        string val_16 = UnityEngine.PlayerPrefs.GetString(key:  "Last Payment Time", defaultValue:  System.String.alignConst);
        PGCompany.七丑一上且三世丝三<K, V> val_17 = PGCompany.七丑一上且三世丝三<System.Object, System.Object>.万世丅七一专丕丞不();
        val_17.set_Item(key:  "player_id", value:  this.丄丌丂东丘丗一万且.丄丒且丙三丆丟与丏);
        val_17.set_Item(key:  "device_token", value:  this.不丒三业下丑不丞业);
        val_17.set_Item(key:  "is_paying", value:  与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专());
        val_17.set_Item(key:  "coins", value:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
        val_17.set_Item(key:  "gems", value:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
        val_17.set_Item(key:  "level", value:  ExperienceController.丞丞丘业东丙丏七丌());
        if(val_17 == null)
        {
            goto label_68;
        }
        
        val_17.set_Item(key:  "language", value:  this.丞丞丐丝丝丏丐丛丞);
        goto label_69;
        label_45:
        val_44 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_44;
        return (bool)val_44;
        label_68:
        0.set_Item(key:  "language", value:  this.丞丞丐丝丝丏丐丛丞);
        label_69:
        val_17.set_Item(key:  "app_version", value:  ProtocolListGetter.丅三专丐丗丅与丆丑().ToString(provider:  RemotePushNotificationController.丙专丝世不业下丂丈())(ProtocolListGetter.丅三专丐丗丅与丆丑().ToString(provider:  RemotePushNotificationController.丙专丝世不业下丂丈())) + ":"(":") + 丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        val_17.set_Item(key:  "os_version", value:  PGCompany.Messaging.专丕丟丕丐丌上且专.三丌下丄丈与七丙丙());
        val_17.set_Item(key:  "develop", value:  System.Convert.ToInt32(value:  与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘()));
        val_17.set_Item(key:  "allow_invites", value:  System.Convert.ToInt32(value:  与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝()));
        val_17.set_Item(key:  "utc_shift", value:  this.三世东丅丁世且专不);
        val_17.set_Item(key:  "unreliable_device_id", value:  UnityEngine.SystemInfo.deviceUniqueIdentifier);
        if((System.String.IsNullOrWhiteSpace(value:  val_16)) != true)
        {
                val_17.set_Item(key:  "last_payment_date", value:  val_16);
        }
        
        val_49 = null;
        val_49 = null;
        this.丄丌丂东丘丗一万且.丘专专三丒丝上且丄 = new PGCompany.Messaging.上丙且丙丂上丁丕下(丄丒且丙三丆丟与丏:  this.丄丌丂东丘丗一万且.丄丒且丙三丆丟与丏, 丌丈不丄丝七丕万专:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒, 一丏一世丘丐丁丄丟:  new System.DateTime() {dateData = this.一丏一世丘丐丁丄丟}, 丞丞丐丝丝丏丐丛丞:  this.丞丞丐丝丝丏丐丛丞, 三世东丅丁世且专不:  this.三世东丅丁世且专不, 不丒三业下丑不丞业:  this.不丒三业下丑不丞业);
        val_50 = null;
        bool val_34 = RemotePushNotificationController.世丈且业丆丑丏丐一();
        if(val_34 != false)
        {
                mem2[0] = "RemotePushNotificationController.SendTokenIosCoroutine";
            mem2[0] = this.丄丌丂东丘丗一万且.丘专专三丒丝上且丄;
            mem2[0] = "callerName";
            mem2[0] = this.丄丌丂东丘丗一万且.丑丞东万丁丂丏万丙;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] Sending token: {1}, {2}: {3}", args:  val_34));
        }
        
        val_45 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_51 = null;
        val_51 = null;
        val_52 = val_45;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() != false)
        {
                val_43 = "[RemotePushNotificationController.SendTokenIosCoroutine] responseCode: "("[RemotePushNotificationController.SendTokenIosCoroutine] responseCode: ") + val_52.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丐丒东东丆丌万丂下, 一丐丗丁丞丆丅丟丄:  val_17, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this.丄丌丂东丘丗一万且, 丛丌丙世专世东丕下:  System.Void RemotePushNotificationController.丛东丟丅丙丗世丗不::下丆丂丛丞东且万一(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不))).ToString(provider:  RemotePushNotificationController.丙专丝世不业下丂丈())(val_52.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丐丒东东丆丌万丂下, 一丐丗丁丞丆丅丟丄:  val_17, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this.丄丌丂东丘丗一万且, 丛丌丙世专世东丕下:  System.Void RemotePushNotificationController.丛东丟丅丙丗世丗不::下丆丂丛丞东且万一(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不))).ToString(provider:  RemotePushNotificationController.丙专丝世不业下丂丈())) + ", callerName: "(", callerName: ") + this.丄丌丂东丘丗一万且.丑丞东万丁丂丏万丙;
            UnityEngine.Debug.Log(message:  val_43);
        }
        
        val_44 = 0;
        return (bool)val_44;
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
