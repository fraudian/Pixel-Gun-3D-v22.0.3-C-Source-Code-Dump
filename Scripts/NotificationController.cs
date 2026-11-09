using UnityEngine;
internal sealed class NotificationController : MonoBehaviour
{
    // Fields
    private const string 三丐丅丟丘丒丐丘丐 = "Scheduled Notifications";
    internal static bool 丐世丘丆丂专丕专丝;
    internal static float 专东丒丗下丞专丘丛;
    internal static NotificationController 丄丘七三上丕世丞业;
    private static bool 丏丒丆丝万与丁丁丟;
    private readonly System.Collections.Generic.List<int> 丆与与与丈丕丈不丂;
    public bool cnextPanelShowed;
    public bool customPanelShowed;
    public bool pauserTemp;
    private float 丅丁丙丁万上丂七丈;
    private float 一与丘业丑业与丏丂;
    public float savedPlayTime;
    public float savedPlayTimeInMatch;
    public float startPlay;
    public float startPlayn;
    
    // Properties
    public float 丘与丒丑且与丁丂丙 { get; }
    public float 丑上丙丘三业上丆丐 { get; }
    internal static bool 一丘三丟丗东万业丕 { get; }
    
    // Methods
    public float get_currentPlayTimeMatch()
    {
        float val_1 = this.savedPlayTimeInMatch;
        val_1 = val_1 + this.一与丘业丑业与丏丂;
        return (float)val_1;
    }
    public float get_currentPlayTime()
    {
        float val_1 = this.savedPlayTime;
        val_1 = val_1 + this.丅丁丙丁万上丂七丈;
        return (float)val_1;
    }
    internal static bool 丌世三丏专丘不丘丌()
    {
        null = null;
        return (bool)NotificationController.丏丒丆丝万与丁丁丟;
    }
    private void Start()
    {
        var val_26;
        Rilisoft.LocalNotificationController val_2 = this.gameObject.AddComponent<Rilisoft.LocalNotificationController>();
        bool val_3 = Load.丗七与业丄万丗不丌(丒丘丏上丙丟丑丕丈:  "bilZapuskKey");
        if(val_3 != false)
        {
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  val_3.丏丂丈丌丘一丐丌七());
        }
        else
        {
                Save.丌丂一丗丌世丞世下(丒丘丏上丙丟丑丕丈:  "bilZapuskKey", 三丂丏不三上上丏丝:  true);
        }
        
        val_26 = null;
        val_26 = null;
        NotificationController.丄丘七三上丕世丞业 = this;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "PlayTime")) != false)
        {
                if((丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "PlayTime"), 丙业与丙丗丝不丈东: out  float val_8 = -4.968566E+19f)) != false)
        {
                this.savedPlayTime = 0f;
        }
        
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "PlayTimeInMatch")) != false)
        {
                if((丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "PlayTimeInMatch"), 丙业与丙丗丝不丈东: out  float val_12 = -4.968565E+19f)) != false)
        {
                this.savedPlayTimeInMatch = 0f;
        }
        
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "StartPlayeTime")) == false)
        {
            goto label_24;
        }
        
        if(((丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "StartPlayeTime").Equals(value:  "-1")) == true) || ((丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "StartPlayeTime"), 丙业与丙丗丝不丈东: out  float val_18 = -4.968563E+19f)) == false))
        {
            goto label_34;
        }
        
        this.customPanelShowed = true;
        this.startPlay = 0f;
        goto label_34;
        label_24:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "StartPlayeTime", 下下丏一丙不丘丌丞:  "-1");
        label_34:
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "StartPlaynTime")) != false)
        {
                if((丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "StartPlaynTime").Equals(value:  "-1")) == true)
        {
                return;
        }
        
            if((丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "StartPlaynTime"), 丙业与丙丗丝不丈东: out  0f)) == false)
        {
                return;
        }
        
            this.cnextPanelShowed = true;
            this.startPlayn = 0f;
            return;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "StartPlaynTime", 下下丏一丙不丘丌丞:  "-1");
    }
    public void SetTime(bool 丌丝丌丁下丐丞丆一 = False)
    {
        float val_4;
        if(this.customPanelShowed == true)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "TableViewKey", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        val_4 = 0f;
        if(丌丝丌丁下丐丞丆一 != true)
        {
                val_4 = (float)UnityEngine.Random.Range(min:  132, max:  176);
        }
        
        val_4 = (this.savedPlayTime + this.丅丁丙丁万上丂七丈) + val_4;
        this.startPlay = val_4;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "StartPlayeTime", 下下丏一丙不丘丌丞:  this.startPlay.ToString());
        this.customPanelShowed = true;
    }
    private void Update()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        float val_21;
        float val_22;
        val_17 = this;
        if(this.pauserTemp != false)
        {
                this.pauserTemp = false;
            val_18 = null;
            val_18 = null;
            NotificationController.丏丒丆丝万与丁丁丟 = true;
            GameConnect.下与业丒丝丕丙丘丙();
        }
        
        val_19 = null;
        val_19 = null;
        if(FriendsController.丄丞丁丈与业上丞丟.idle == true)
        {
            goto label_37;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丅丁丙丁万上丂七丈 + val_1;
        this.丅丁丙丁万上丂七丈 = val_1;
        if(Initializer.丑七不且上丗丁一世() == 0)
        {
            goto label_37;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_17;
        }
        
        val_20 = null;
        val_20 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七] & 1) == 0)
        {
            goto label_37;
        }
        
        label_17:
        if(((GameConnect.东且三丆丑世世丘丟() != true) && (GameConnect.世丐丄三三上丅七三() != true)) && (GameConnect.丙丘不世专且万丄丐() != true))
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() != true)
        {
                float val_12 = UnityEngine.Time.deltaTime;
            val_12 = this.一与丘业丑业与丏丂 + val_12;
            this.一与丘业丑业与丏丂 = val_12;
        }
        
        }
        
        label_37:
        if(三丁丒丞丐丂丗不东.丞丄丂丘丌一丒丙上() != null)
        {
                if(val_13.丝丞丁丁丗丑七专万 != false)
        {
                val_21 = val_13.丈丁七东丁业丌与三;
        }
        else
        {
                val_21 = (float)val_13.丈七丕丟丈丐万下不;
        }
        
            if(val_13.丝丞丁丁丗丑七专万 != false)
        {
                val_22 = val_13.丞东丕丗丅丌世七与;
        }
        else
        {
                val_22 = (float)val_13.丅丐上丐且丂一专世;
        }
        
            CustomHungerBase.下与丞三丅丛丄七丕(下业七不丑丂丏丟东:  System.String.Format(format:  "Memory hack detection: Original value: {0} Changed: {1}", arg0:  val_21, arg1:  val_22));
        }
        
        if(this.customPanelShowed != false)
        {
                float val_17 = this.savedPlayTime;
            val_17 = val_17 + this.丅丁丙丁万上丂七丈;
            if(this.startPlay < 0)
        {
                this.customPanelShowed = false;
            CustomHungerBase.下与丞三丅丛丄七丕(下业七不丑丂丏丟东:  "Detection");
        }
        
        }
        
        if(this.cnextPanelShowed == false)
        {
                return;
        }
        
        float val_18 = this.savedPlayTime;
        val_18 = val_18 + this.丅丁丙丁万上丂七丈;
        if(this.startPlayn >= 0)
        {
                return;
        }
        
        this.cnextPanelShowed = false;
        val_17 = "gfts";
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "gfts", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) | 2, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void SaveTimeValues()
    {
        string val_13;
        Rilisoft.TechnicalCloudInfo val_14;
        val_13 = this;
        Rilisoft.InGameTimeKeeper.丑七不且上丗丁一世().丂且不业丂专丛丆东();
        float val_13 = this.丅丁丙丁万上丂七丈;
        if(val_13 > 0f)
        {
                val_13 = val_13 + this.savedPlayTime;
            this.savedPlayTime = val_13;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "PlayTime saved: {0} (+{1})", arg0:  val_13, arg1:  val_13));
            this.丅丁丙丁万上丂七丈 = 0f;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "PlayTime", 下下丏一丙不丘丌丞:  this.savedPlayTime.ToString());
            val_14 = UnityEngine.JsonUtility.FromJson<Rilisoft.TechnicalCloudInfo>(json:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY"));
            if(val_14 == null)
        {
                val_14 = new Rilisoft.TechnicalCloudInfo();
            val_14 = new Rilisoft.TechnicalCloudInfo();
        }
        
            float val_8 = System.Math.Max(val1:  new Rilisoft.TechnicalCloudInfo().InGameSeconds, val2:  this.savedPlayTime);
            if(new Rilisoft.TechnicalCloudInfo().InGameSeconds != val_8)
        {
                new Rilisoft.TechnicalCloudInfo().InGameSeconds = val_8;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  new Rilisoft.TechnicalCloudInfo()));
        }
        
        }
        
        float val_14 = this.一与丘业丑业与丏丂;
        if(val_14 <= 0f)
        {
                return;
        }
        
        val_14 = val_14 + this.savedPlayTimeInMatch;
        this.savedPlayTimeInMatch = val_14;
        val_14 = System.String.Format(format:  "PlayTimeInMatch saved: {0} (+{1})", arg0:  val_14, arg1:  val_14);
        UnityEngine.Debug.Log(message:  val_14);
        this.一与丘业丑业与丏丂 = 0f;
        val_13 = this.savedPlayTimeInMatch.ToString();
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "PlayTimeInMatch", 下下丏一丙不丘丌丞:  val_13);
    }
    internal static void 下世东丘且丏丙丐与()
    {
        null = null;
        NotificationController.丏丒丆丝万与丁丁丟 = false;
    }
    private void 丏丂且一丅世丏与不()
    {
        var val_17;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                bool val_4 = BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂();
        }
        
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                val_17 = null;
            val_17 = null;
            NotificationController.丏丒丆丝万与丁丁丟 = true;
        }
        
        System.DateTime val_6 = System.DateTime.Now;
        int val_7 = val_6.dateData.Hour;
        System.DateTime val_8 = System.DateTime.Now;
        System.TimeSpan val_9 = System.TimeSpan.FromHours(value:  23);
        System.DateTime val_10 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_8.dateData}, t:  new System.TimeSpan() {_ticks = val_9._ticks});
        System.DateTime val_12 = val_10.dateData.Date;
        if(val_10.dateData.Hour < 16)
        {
            
        }
        
        System.DateTime val_13 = val_12.dateData.AddHours(value:  40);
        System.TimeSpan val_14 = System.TimeSpan.FromDays(value:  1);
        string val_15 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丆与与与丈丕丈不丂);
        UnityEngine.Debug.Log(message:  "Notifications to save: "("Notifications to save: ") + val_15);
        UnityEngine.PlayerPrefs.SetString(key:  "Scheduled Notifications", value:  val_15);
        UnityEngine.PlayerPrefs.Save();
    }
    private System.Collections.IEnumerator 丏丂丈丌丘一丐丌七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new NotificationController.丝丝丏丅丗丘丗丑丅();
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        NotificationController.丒一上丂业专下丝丕 val_1 = new NotificationController.丒一上丂业专下丝丕();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .东丗七丕丄不丐专丒 = 东丗七丕丄不丐专丒;
        return (System.Collections.IEnumerator)val_1;
    }
    public NotificationController()
    {
        this.丆与与与丈丕丈不丂 = new System.Collections.Generic.List<System.Int32>();
        this.startPlay = -1f;
        this.startPlayn = -1f;
    }
    private static NotificationController()
    {
    
    }

}
