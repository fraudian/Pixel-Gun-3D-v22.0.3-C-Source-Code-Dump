using UnityEngine;
public class NotificationWindowController : BannerWindowWithBack
{
    // Fields
    private static NotificationWindowController <不丁丄七丛不丆丁丕>k__BackingField;
    internal static long 丝丅七丗七丒下丒与;
    internal static long 世丞丝丆业丈一三三;
    internal static string 丏专下丑与业一丆丈;
    internal static string 丙东丏丈丗丌丆丐丒;
    internal static string 丞丒丑丕三丟丙三丄;
    internal static System.Nullable<丝上丑丏与丟丗丄丒> 业业丅丕业丞业丗丗;
    private static bool 丗丕世丑丛不丌丁丈;
    public UITextureMasked texture;
    public UILabel label;
    public UnityEngine.GameObject settingsButton;
    public UnityEngine.GameObject nextButton;
    public UnityEngine.GameObject noThxButton;
    public System.Collections.Generic.List<NotificationBunnerContent> bunnerTypes;
    private bool 丛丒专丑不丗丌丙丏;
    
    // Properties
    internal static NotificationWindowController 丆丕丝丒不丙且丐丗 { get; set; }
    internal static System.TimeSpan 不三一丗丏且丄丗丐 { get; }
    internal static System.TimeSpan 世丗丂丂不不世上丕 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    internal static bool 丅业东万丌丕上丌丄 { get; }
    internal static bool 丕丆三丆丕不三业丒 { get; }
    internal static bool 万丁丈丈丅丞丒丏一 { get; }
    
    // Methods
    internal static NotificationWindowController 丑七不且上丗丁一世()
    {
        null = null;
        return (NotificationWindowController)NotificationWindowController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(NotificationWindowController 丙业与丙丗丝不丈东)
    {
        null = null;
        NotificationWindowController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static System.TimeSpan 丛丒丆不丙且丅丈丝()
    {
        null = null;
        return System.TimeSpan.FromSeconds(value:  (double)NotificationWindowController.丝丅七丗七丒下丒与);
    }
    internal static System.TimeSpan 丑上三丐丑丛不丗丄()
    {
        null = null;
        return System.TimeSpan.FromSeconds(value:  (double)NotificationWindowController.世丞丝丆业丈一三三);
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return PGCompany.下丅丌上上丈业不丐.东上丈丈世丝丆且丒();
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        if(NotificationWindowController.丑七不且上丗丁一世() == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_4 = NotificationWindowController.丑七不且上丗丁一世().gameObject;
        if(val_4 != null)
        {
                return val_4.activeInHierarchy;
        }
        
        return val_4.activeInHierarchy;
    }
    internal static bool 丂东下不丆专丌丈丆()
    {
        return (bool)NotificationWindowController.丝且下丄下丞三世丕(丏丞专丏业丗丝七丝: out  0);
    }
    protected override void Awake()
    {
        this.Awake();
        NotificationWindowController.丘专丕下上丌丐丐不();
    }
    internal static bool 丝且下丄下丞三世丕(out string 丏丞专丏业丗丝七丝)
    {
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_15 = null;
        val_15 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == null)
        {
            goto label_3;
        }
        
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
            goto label_6;
        }
        
        val_16 = "sharedController: null";
        return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16 = "isEnableRemoteInviteFromFriends: false", 丄丙下丝丛丒七丂丘: out  string val_11 = 丏丞专丏业丗丝七丝);
        label_3:
        val_16 = "MainMenuController";
        return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        label_6:
        if(MainMenuController.丄丞丁丈与业上丞丟.丂丙丈与世专上丒上() != false)
        {
                val_16 = "LeaderboardsIsOpening";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) != false)
        {
                val_16 = "settingsPanel";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        if(MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends != false)
        {
                val_16 = "IsOpeningFriends";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        if(MainStoreView.丈丐丞丐上丑且丕万() != false)
        {
                val_16 = "MainStoreView.IsActive";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        val_17 = null;
        if(NotificationWindowController.与七丟丑丌丙东万丛() != false)
        {
                val_16 = "IsLockedLocalNotifs";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        if((NotificationWindowController.丈与丄与丅与不丞丗(丌丙丝丟东世且丌丁:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = false})) != false)
        {
                val_16 = "IsLockedLocalTypeNotifByType";
            return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        if(与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝() == false)
        {
            goto label_28;
        }
        
        if((Rilisoft.LocalNotificationController.丁与丕一一丁丞不丕(专不三上丏专丄且丞:  (~Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝()) & 1, 丏丞专丏业丗丝七丝: out  val_11)) == false)
        {
            goto label_31;
        }
        
        val_18 = 0;
        return (bool)val_18;
        label_28:
        return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        label_31:
        val_19 = null;
        val_19 = null;
        if(activeInHierarchy != true)
        {
                val_20 = null;
            val_20 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
                return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
        }
        
        }
        
        val_18 = 1;
        return (bool)val_18;
    }
    internal static bool 与七丟丑丌丙东万丛()
    {
        var val_8;
        var val_9;
        NotificationWindowController.丘专丕下上丌丐丐不();
        if((UnityEngine.PlayerPrefs.HasKey(key:  NotificationWindowController.丙东丏丈丗丌丆丐丒)) != true)
        {
                val_8 = null;
            val_8 = null;
            UnityEngine.PlayerPrefs.SetString(key:  NotificationWindowController.丙东丏丈丗丌丆丐丒, value:  System.String.alignConst);
        }
        
        val_9 = null;
        val_9 = null;
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  NotificationWindowController.丙东丏丈丗丌丆丐丒);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) != false)
        {
                return false;
        }
        
        System.DateTime val_4 = System.DateTime.Parse(s:  val_2);
        System.DateTime val_5 = System.DateTime.Now;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_5.dateData}, d2:  new System.DateTime() {dateData = val_4.dateData});
        System.TimeSpan val_7 = NotificationWindowController.丛丒丆不丙且丅丈丝();
        return System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_6._ticks}, t2:  new System.TimeSpan() {_ticks = val_7._ticks});
    }
    internal static bool 丈与丄与丅与不丞丗(System.Nullable<丝上丑丏与丟丗丄丒> 丌丙丝丟东世且丌丁)
    {
        string val_13;
        var val_14;
        var val_15;
        int val_16;
        long val_17;
        val_13 = 1152921535455967072;
        if((784375320 & 1) == 0)
        {
                val_14 = null;
            val_14 = null;
        }
        
        if((784375320 & 1) == 0)
        {
            goto label_4;
        }
        
        val_15 = null;
        val_15 = null;
        string val_1 = System.String.Format(format:  NotificationWindowController.丏专下丑与业一丆丈, arg0:  NotificationWindowController.业业丅丕业丞业丗丗);
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_1)) != true)
        {
                if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_1)) != false)
        {
                val_16 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_1);
        }
        else
        {
                val_16 = System.String.alignConst;
        }
        
            UnityEngine.PlayerPrefs.SetString(key:  val_1, value:  val_16);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_1, 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        val_13 = UnityEngine.PlayerPrefs.GetString(key:  val_1);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) == false)
        {
            goto label_18;
        }
        
        label_4:
        val_17 = 0;
        return (bool)System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_17}, t2:  new System.TimeSpan() {_ticks = val_10._ticks});
        label_18:
        System.DateTime val_7 = System.DateTime.Parse(s:  val_13);
        System.DateTime val_8 = System.DateTime.Now;
        System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_8.dateData}, d2:  new System.DateTime() {dateData = val_7.dateData});
        val_13 = val_9._ticks;
        System.TimeSpan val_10 = NotificationWindowController.丑上三丐丑丛不丗丄();
        val_17 = val_13;
        return (bool)System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_17}, t2:  new System.TimeSpan() {_ticks = val_10._ticks});
    }
    private static void 丘专丕下上丌丐丐不()
    {
        string val_6;
        var val_7;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_7 = null;
        val_7 = null;
        if(NotificationWindowController.丗丕世丑丛不丌丁丈 == true)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  NotificationWindowController.丞丒丑丕三丟丙三丄)) != true)
        {
                val_9 = null;
            val_9 = null;
            UnityEngine.PlayerPrefs.SetInt(key:  NotificationWindowController.丞丒丑丕三丟丙三丄, value:  0);
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = null;
        if((UnityEngine.PlayerPrefs.GetInt(key:  NotificationWindowController.丞丒丑丕三丟丙三丄)) == 1)
        {
            
        }
        else
        {
                val_11 = null;
            if((UnityEngine.PlayerPrefs.HasKey(key:  NotificationWindowController.丙东丏丈丗丌丆丐丒)) != true)
        {
                val_12 = null;
            val_12 = null;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  NotificationWindowController.丙东丏丈丗丌丆丐丒)) != false)
        {
                val_13 = null;
            val_13 = null;
            UnityEngine.PlayerPrefs.SetString(key:  NotificationWindowController.丙东丏丈丗丌丆丐丒, value:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  NotificationWindowController.丙东丏丈丗丌丆丐丒));
        }
        
            val_14 = null;
            val_14 = null;
            val_6 = NotificationWindowController.丙东丏丈丗丌丆丐丒;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_6, 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
            val_15 = null;
            val_15 = null;
            UnityEngine.PlayerPrefs.SetInt(key:  NotificationWindowController.丞丒丑丕三丟丙三丄, value:  1);
        }
        
        NotificationWindowController.丗丕世丑丛不丌丁丈 = true;
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        Rilisoft.LocalNotificationController.业与专与丛丐丂丌下();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        Rilisoft.LocalNotificationController.业与专与丛丐丂丌下();
        if(NotificationWindowController.丑七不且上丗丁一世() != 0)
        {
                return;
        }
        
        NotificationWindowController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
    }
    protected override void OnDisable()
    {
        var val_4;
        this.OnDisable();
        val_4 = null;
        val_4 = null;
        System.DateTime val_1 = System.DateTime.Now;
        UnityEngine.PlayerPrefs.SetString(key:  NotificationWindowController.丙东丏丈丗丌丆丐丒, value:  val_1.dateData);
        System.DateTime val_3 = System.DateTime.Now;
        UnityEngine.PlayerPrefs.SetString(key:  System.String.Format(format:  NotificationWindowController.丏专下丑与业一丆丈, arg0:  1152921505102430256), value:  val_3.dateData);
        NotificationWindowController.业业丅丕业丞业丗丗 = 0;
    }
    public override void Hide()
    {
        this.Hide();
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(this.丛丒专丑不丗丌丙丏 == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "Notifications.FirstLaunch_WillShowNotificationPermissionAlert", value:  0);
        UnityEngine.PlayerPrefs.Save();
    }
    public override void Show()
    {
        var val_7;
        this.Show();
        this.丛丒专丑不丗丌丙丏 = ((UnityEngine.PlayerPrefs.GetInt(key:  "Notifications.FirstLaunch_WillShowNotificationPermissionAlert")) == 1) ? 1 : 0;
        if((ExperienceController.丞丞丘业东丙丏七丌() >= 8) && (this.丛丒专丑不丗丌丙丏 != false))
        {
                this.丛丒专丑不丗丌丙丏 = false;
            UnityEngine.PlayerPrefs.SetInt(key:  "Notifications.FirstLaunch_WillShowNotificationPermissionAlert", value:  0);
            UnityEngine.PlayerPrefs.Save();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nextButton, 丏业丟一东丂东丘丛:  (this.丛丒专丑不丗丌丙丏 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.settingsButton, 丏业丟一东丂东丘丛:  (this.丛丒专丑不丗丌丙丏 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noThxButton, 丏业丟一东丂东丘丛:  (this.丛丒专丑不丗丌丙丏 == false) ? 1 : 0);
        val_7 = null;
        val_7 = null;
        this.世且上丆丑东万丂下(丁丅丈丌丟世丗丗丟:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = NotificationWindowController.业业丅丕业丞业丗丗});
    }
    public override void Back()
    {
        this.Back();
        goto typeof(NotificationWindowController).__il2cppRuntimeField_208;
    }
    private void 世且上丆丑东万丂下(System.Nullable<丝上丑丏与丟丗丄丒> 丁丅丈丌丟世丗丗丟)
    {
        .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        if((this.bunnerTypes.Find(match:  new System.Predicate<NotificationBunnerContent>(object:  new NotificationWindowController.丄丁丒丄与丁七丆一(), method:  System.Boolean NotificationWindowController.丄丁丒丄与丁七丆一::业且与丏丆业丘丐丛(NotificationBunnerContent 三丟东丕丄丄下下丑)))) == null)
        {
                return;
        }
        
        this.label.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3.lKey);
        PGCompany.Analytics.一业丗丆世世上丁且.丛丌万丐丕丆三丏业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅上三丏万丛七丐东:  1, 业业丅丕业丞业丗丗:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = (NotificationWindowController.丄丁丒丄与丁七丆一)[1152921535457039072].丁丅丈丌丟世丗丗丟});
    }
    internal static void 世丛上丕专上且且三(丝上丑丏与丟丗丄丒 丁丅丈丌丟世丗丗丟)
    {
        var val_3;
        var val_4;
        val_3 = null;
        if(NotificationWindowController.与七丟丑丌丙东万丛() == true)
        {
                return;
        }
        
        if((NotificationWindowController.丈与丄与丅与不丞丗(丌丙丝丟东世且丌丁:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = false})) == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        NotificationWindowController.业业丅丕业丞业丗丗 = 0;
    }
    public void HandleYes()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = this;
        if(PGCompany.下丅丌上上丈业不丐.东上丈丈世丝丆且丒() != false)
        {
                UnityEngine.Debug.Log(message:  "[NotificationWindowController.HandleYes]");
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = 4;
        PGCompany.Analytics.一业丗丆世世上丁且.丛丌万丐丕丆三丏业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅上三丏万丛七丐东:  4, 业业丅丕业丞业丗丗:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = NotificationWindowController.业业丅丕业丞业丗丗});
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
            goto label_12;
        }
        
        if(PGCompany.丗业丐丕世业丘丆上.世下世丁且丅业丕万() != false)
        {
                PGCompany.Messaging.专丒七丌丟丘上业专.东丕丝世丑丈丞丄丁();
        }
        
        if(RemotePushNotificationController.丑七不且上丗丁一世() != 0)
        {
            goto label_18;
        }
        
        val_13 = 0;
        UnityEngine.Debug.LogError(message:  "[NotificationWindowController.HandleYes] RemotePushNotificationController: null");
        goto label_25;
        label_12:
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
            goto label_25;
        }
        
        NotificationWindowController.丙丐东丅丙三丒一丒();
        goto label_25;
        label_18:
        val_13 = 0;
        RemotePushNotificationController.丑七不且上丗丁一世().RegisterNotificationIos();
        label_25:
        val_14 = 0;
        val_15 = 0;
        if(val_14 == 1)
        {
            goto label_29;
        }
        
        if((val_15 == 0) || (121 == 121))
        {
            goto label_31;
        }
        
        label_32:
        val_10 = ???;
        val_15 = ???;
        val_11 = ???;
        val_14 = ???;
        label_29:
        if(val_15 != 0)
        {
            goto label_32;
        }
        
        label_31:
        var val_9 = val_10 - 48;
    }
    public void HandleNo()
    {
        var val_2 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丛丌万丐丕丆三丏业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅上三丏万丛七丐东:  3, 业业丅丕业丞业丗丗:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = NotificationWindowController.业业丅丕业丞业丗丗});
        goto typeof(NotificationWindowController).__il2cppRuntimeField_1D8;
    }
    private static void 丙丐东丅丙三丒一丒()
    {
        object val_11;
        string val_6 = 0;
        if(PGCompany.下丅丌上上丈业不丐.东上丈丈世丝丆且丒() != false)
        {
                UnityEngine.Debug.Log(message:  "[NotificationWindowController.OpenAndroidSettingsNoThrow]");
        }
        
        val_11 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世();
        if(val_11.且丄业丈丞丘丛业下() != null)
        {
                val_11 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世();
            if((PGCompany.丗丑三与专且丘丏世.且丐万丑万且丟丑丝(世丗丆丛丆且一世七:  val_11.且丄业丈丞丘丛业下(), 丏丞专丏业丗丝七丝: out  val_6)) == true)
        {
                return;
        }
        
            if(PGCompany.下丅丌上上丈业不丐.东上丈丈世丝丆且丒() == false)
        {
                return;
        }
        
            val_11 = "[NotificationWindowController.OpenAndroidSettingsNoThrow] TryOpenNotificationSettings: "("[NotificationWindowController.OpenAndroidSettingsNoThrow] TryOpenNotificationSettings: ") + val_6;
            UnityEngine.Debug.LogWarning(message:  val_11);
            return;
        }
        
        if(PGCompany.下丅丌上上丈业不丐.东上丈丈世丝丆且丒() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[NotificationWindowController.OpenAndroidSettingsNoThrow] CurrentActivity: null");
    }
    public void HandleSettings()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = this;
        if(PGCompany.下丅丌上上丈业不丐.东上丈丈世丝丆且丒() != false)
        {
                UnityEngine.Debug.Log(message:  "[NotificationWindowController.HandleSettings]");
        }
        
        val_11 = null;
        val_11 = null;
        val_12 = 2;
        PGCompany.Analytics.一业丗丆世世上丁且.丛丌万丐丕丆三丏业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅上三丏万丛七丐东:  2, 业业丅丕业丞业丗丗:  new System.Nullable<丝上丑丏与丟丗丄丒>() {HasValue = NotificationWindowController.业业丅丕业丞业丗丗});
        NotificationWindowController.丙丐东丅丙三丒一丒();
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                if(PGCompany.丗业丐丕世业丘丆上.世下世丁且丅业丕万() != false)
        {
                PGCompany.Messaging.专丒七丌丟丘上业专.东丕丝世丑丈丞丄丁();
        }
        
            if(RemotePushNotificationController.丑七不且上丗丁一世() == 0)
        {
                val_12 = 0;
            UnityEngine.Debug.LogError(message:  "[NotificationWindowController.HandleSettings] RemotePushNotificationController: null");
        }
        else
        {
                val_12 = 0;
            RemotePushNotificationController.丑七不且上丗丁一世().RegisterNotificationIos();
        }
        
        }
        
        val_13 = 0;
        val_14 = 0;
        if(val_13 == 1)
        {
            goto label_25;
        }
        
        if((val_14 == 0) || (110 == 110))
        {
            goto label_27;
        }
        
        label_28:
        val_9 = ???;
        val_14 = ???;
        val_10 = ???;
        val_13 = ???;
        label_25:
        if(val_14 != 0)
        {
            goto label_28;
        }
        
        label_27:
        var val_8 = val_9 - 32;
    }
    public NotificationWindowController()
    {
        this.bunnerTypes = new System.Collections.Generic.List<NotificationBunnerContent>();
    }
    private static NotificationWindowController()
    {
        NotificationWindowController.丝丅七丗七丒下丒与 = 86400;
        NotificationWindowController.世丞丝丆业丈一三三 = 604800;
        NotificationWindowController.丏专下丑与业一丆丈 = "notification_type_locked_{0}";
        NotificationWindowController.丙东丏丈丗丌丆丐丒 = "notification_local_locked";
        NotificationWindowController.丞丒丑丕三丟丙三丄 = "notification_data_is_migrated";
    }

}
