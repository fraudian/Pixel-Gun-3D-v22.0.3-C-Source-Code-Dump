using UnityEngine;
public sealed class FacebookController : MonoBehaviour
{
    // Fields
    internal static FacebookController 丄丞丁丈与业上丞丟;
    private static System.Action<string> 丝丐下丒业丈丑丒丘;
    internal string 下三与丘七丄丗一万;
    internal System.Collections.Generic.List<丙上丈丒丁丌不丐丐> 万丄不丅业丌三丟丘;
    private const string 丆下丞丑丆且丘丅丞 = "Invite a Friend to Play!";
    private const string 上专上下丟一且丗丐 = "Join me in playing a new game!";
    internal const int 专丄丈丝丄丌丝丗丏 = 7;
    internal const int 业万专东上丝丛与丁 = 3;
    internal static readonly System.Collections.Generic.Dictionary<FacebookController.上丘丟丂万东丟下丂, int> 丗丄丐丆丆业丏上丌;
    private static bool <丞丂与丅丛丑丅专业>k__BackingField;
    private bool 丐丙不上丂专丙丈丈;
    
    // Properties
    internal static bool 丛丕业丆丞丙丁专丁 { get; }
    internal static bool 专东世丟丝丏上世丛 { get; set; }
    internal static bool 专万丕且世下丞丟丐 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    internal static bool 丞丙一三丝丝与丘丆 { get; set; }
    
    // Methods
    internal static bool 且丈丄一丁丞丒丑东()
    {
        return (bool)(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19) ? 1 : 0;
    }
    internal static bool 丌丛且丑丈丈丅丗七()
    {
        Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if(val_1 != null)
        {
                return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  5);
        }
        
        return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  5);
    }
    internal static void 丌一丘丌万丂丅东业(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  5);
            return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  5);
    }
    internal static void 丅丌丄七丌专丌丌丈(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FacebookController.丝丐下丒业丈丑丒丘, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FacebookController.丝丐下丒业丈丑丒丘 != 1152921505311481864);
    
    }
    internal static void 上丕丈丙丒世丙丗丁(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FacebookController.丝丐下丒业丈丑丒丘, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FacebookController.丝丐下丒业丈丑丒丘 != 1152921505311481864);
    
    }
    internal static bool 丘七下丂上一丅三丏()
    {
        return (bool)(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19) ? 1 : 0;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private void Start()
    {
        var val_3;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        val_3 = null;
        val_3 = null;
        FacebookController.业万专东上丝丛与丁 = this;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        this.丄丒丈丞东上三丟丐();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        bool val_2 = 丁与丟万丄丒丗专丌;
        if(val_2 == true)
        {
                return;
        }
        
        val_2 = 1152921504933097472;
        if(Facebook.Unity.FB.IsInitialized == false)
        {
                return;
        }
        
        Facebook.Unity.FB.ActivateApp();
    }
    private void Update()
    {
        FriendsController val_5;
        var val_6;
        var val_7;
        var val_8;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        if(Facebook.Unity.FB.IsLoggedIn == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_5 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_5 = FriendsController.丄丞丁丈与业上丞丟;
        if((System.String.IsNullOrEmpty(value:  FriendsController.丄丞丁丈与业上丞丟.id_fb)) == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(FacebookController.丝丐下丒业丈丑丒丘 == null)
        {
                return;
        }
        
        FacebookController.丝丐下丒业丈丑丒丘.Invoke(obj:  System.String.alignConst);
    }
    internal static void 丟丕且丏不丛东丛东(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, object> 丗丟上上丒丐丗丞丙)
    {
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        if(Facebook.Unity.FB.IsInitialized == false)
        {
                return;
        }
        
        Facebook.Unity.FB.LogAppEvent(logEvent:  丝丏业丅丈东业丝丒, valueToSum:  new System.Nullable<System.Single>() {HasValue = false}, parameters:  丗丟上上丒丐丗丞丙);
    }
    internal static void 七丒万丒丘东世丌上()
    {
        System.Uri val_21;
        string val_22;
        string val_23;
        string val_24;
        string val_25;
        string val_26;
        var val_27;
        val_21 = 1152921505311477760;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "PostFacebookCount", value:  (UnityEngine.PlayerPrefs.GetInt(key:  "PostFacebookCount", defaultValue:  0)) + 1);
        UnityEngine.PlayerPrefs.Save();
        if((((UnityEngine.PlayerPrefs.GetInt(key:  "Active_loyal_users_payed_send", defaultValue:  0)) == 0) && ((UnityEngine.PlayerPrefs.GetInt(key:  "PostFacebookCount", defaultValue:  0)) >= 3)) && (StoreKitEventListener.且丗丑万丞三丟东丅() >= 1))
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "PostVideo", defaultValue:  0)) >= 1)
        {
                FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Active_loyal_users_payed", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.PlayerPrefs.SetInt(key:  "Active_loyal_users_payed_send", value:  1);
        }
        
        }
        
        if(((UnityEngine.PlayerPrefs.GetInt(key:  "Active_loyal_users_send", defaultValue:  0)) == 0) && ((UnityEngine.PlayerPrefs.GetInt(key:  "PostFacebookCount", defaultValue:  0)) >= 3))
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "PostVideo", defaultValue:  0)) >= 1)
        {
                FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Active_loyal_users", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.PlayerPrefs.SetInt(key:  "Active_loyal_users_send", value:  1);
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        string val_12 = 丐丞丞丏丞业丄一丈.世丐丄丙丞丌丛万且();
        if(val_11 != null)
        {
                val_11.Add(key:  "link", value:  val_12);
        }
        else
        {
                val_11.Add(key:  "link", value:  val_12);
        }
        
        val_11.Add(key:  "name", value:  "Pixel Gun 3D");
        if(val_11 != null)
        {
                val_11.Add(key:  "picture", value:  "http://pixelgun3d.com/iconforpost.png");
        }
        else
        {
                val_11.Add(key:  "picture", value:  "http://pixelgun3d.com/iconforpost.png");
        }
        
        val_11.Add(key:  "caption", value:  "I\'ve just played the super battle in Pixel Gun 3D :)");
        if(val_11 != null)
        {
                val_11.Add(key:  "description", value:  "DOWNLOAD IT FOR FREE AND JOIN ME NOW!");
        }
        else
        {
                val_11.Add(key:  "description", value:  "DOWNLOAD IT FOR FREE AND JOIN ME NOW!");
        }
        
        val_22 = val_11.Item["link"];
        val_21 = new System.Uri();
        if((val_22 != null) && (null != null))
        {
                val_22 = 0;
        }
        
        val_21 = new System.Uri(uriString:  val_22);
        val_23 = val_11.Item["name"];
        val_24 = val_11.Item["picture"];
        if((val_24 != null) && (null != null))
        {
                val_24 = 0;
        }
        
        new System.Uri() = new System.Uri(uriString:  val_24);
        val_25 = val_11.Item["caption"];
        val_26 = val_11.Item["description"];
        val_27 = null;
        if((val_23 != null) && (null != val_27))
        {
                val_27 = null;
            val_23 = 0;
        }
        
        if((val_25 != null) && (null != val_27))
        {
                val_27 = null;
            val_25 = 0;
        }
        
        if((val_26 != null) && (null != val_27))
        {
                val_26 = 0;
        }
        
        Facebook.Unity.FB.FeedShare(toId:  "", link:  new System.Uri(), linkName:  val_23, linkCaption:  val_25, linkDescription:  val_26, picture:  new System.Uri(), mediaSource:  "", callback:  0);
    }
    private static void 丘东万丆东七万丆丒(Facebook.Unity.IResult 东且丁丆丛丁丏丘且)
    {
    
    }
    private static void 丞丄丕东万世丈丁丈(string 丞三丒丒且东与丑丙, System.Action<System.Collections.Generic.IDictionary<string, object>> 丌专业且丛丏丞丝且, System.Action<Facebook.Unity.IResult> 不万丒东万丛三丐丕)
    {
        var val_6;
        Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> val_7;
        var val_8;
        FacebookController.丐丐七丈丅丐三且丆 val_1 = new FacebookController.丐丐七丈丅丐三且丆();
        if(val_1 != null)
        {
                .丌专业且丛丏丞丝且 = 丌专业且丛丏丞丝且;
        }
        else
        {
                val_6 = 0;
            mem[16] = 丌专业且丛丏丞丝且;
        }
        
        .不万丒东万丛三丐丕 = 不万丒东万丛三丐丕;
        val_7 = 1152921505311477760;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        if(Facebook.Unity.FB.IsInitialized != false)
        {
                val_7 = null;
            val_7 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  val_1, method:  System.Void FacebookController.丐丐七丈丅丐三且丆::丝万丝丏丑丄世丙丂(Facebook.Unity.IGraphResult 东且丁丆丛丁丏丘且));
            Facebook.Unity.FB.API(query:  丞三丒丒且东与丑丙, method:  0, callback:  null, formData:  0);
            return;
        }
        
        val_8 = null;
        if(FacebookController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[FacebookController.FBGet] FB.IsInitialized: false");
    }
    internal static bool 万上业丈世丄专且且()
    {
        null = null;
        return (bool)FacebookController.<丞丂与丅丛丑丅专业>k__BackingField;
    }
    private static void 丅业丆世丈丅丟专丘(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        FacebookController.<丞丂与丅丛丑丅专业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 丟不丆丂且三丅世专(System.Action 七丒上且丝业业下七, System.Action 丝丏丗丄丗与丐丌三, string 与且专丈不万东一万 = "Unknown")
    {
        System.Action val_7;
        var val_8;
        val_7 = 七丒上且丝业业下七;
        FacebookController.丂丄丕业东丆丄三三 val_1 = new FacebookController.丂丄丕业东丆丄三三();
        if(val_1 != null)
        {
                .七丒上且丝业业下七 = val_7;
        }
        else
        {
                mem[16] = val_7;
        }
        
        .丝丏丗丄丗与丐丌三 = 丝丏丗丄丗与丐丌三;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        FacebookController.丅业丆世丈丅丟专丘(丙业与丙丗丝不丈东:  true);
        if(Facebook.Unity.FB.IsInitialized != false)
        {
                val_7 = null;
            val_7 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  val_1, method:  System.Void FacebookController.丂丄丕业东丆丄三三::丛丕东丌丙丛万丁丑(Facebook.Unity.ILoginResult 东且丁丆丛丁丏丘且));
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  System.Array.Empty<System.String>(), callback:  null);
            return;
        }
        
        val_8 = null;
        if(FacebookController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[FacebookController.Login] FB.IsInitialized: false");
    }
    private void 丄丒丈丞东上三丟丐()
    {
        Facebook.Unity.InitDelegate val_4;
        var val_5;
        Facebook.Unity.HideUnityDelegate val_7;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        val_4 = new Facebook.Unity.InitDelegate();
        val_4 = new Facebook.Unity.InitDelegate(object:  this, method:  System.Void FacebookController::专三专业丞丛丟丝丆());
        val_5 = null;
        val_5 = null;
        val_7 = FacebookController.<>c.<>9__34_1;
        if(val_7 == null)
        {
                val_7 = new Facebook.Unity.HideUnityDelegate();
            val_7 = new Facebook.Unity.HideUnityDelegate(object:  FacebookController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FacebookController.<>c::不丒丟丗丞丂且丄丕(bool 且丆丏丛东下上丄丟));
            FacebookController.<>c.<>9__34_1 = val_7;
        }
        
        Facebook.Unity.FB.Init(onInitComplete:  new Facebook.Unity.InitDelegate(), onHideUnity:  new Facebook.Unity.HideUnityDelegate(), authResponse:  0);
    }
    internal static void 丟下万东丅丅丁丑丞(System.Action 丒丘丛丐丌丏业不丒, string 业丑专丟丛不丁丁丈 = "", bool 丑下丐世丆且丝上丈 = False, System.Action 丘丛丆丆下丛东七世)
    {
        System.Action val_8;
        object val_9;
        var val_10;
        val_8 = 丘丛丆丆下丛东七世;
        FacebookController.丑丗东丞三且丂丄丒 val_1 = null;
        val_9 = val_1;
        val_1 = new FacebookController.丑丗东丞三且丂丄丒();
        if(val_9 != null)
        {
                val_10 = val_9;
            .丒丘丛丐丌丏业不丒 = 丒丘丛丐丌丏业不丒;
            mem[1152921540088642640] = 业丑专丟丛不丁丁丈;
        }
        else
        {
                mem[16] = 业丑专丟丛不丁丁丈;
            val_10 = 24;
            mem[24] = 丒丘丛丐丌丏业不丒;
        }
        
        .丘丛丆丆下丛东七世 = val_8;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                return;
        }
        
        if(丑下丐世丆且丝上丈 == false)
        {
            goto label_6;
        }
        
        if(Facebook.Unity.FB.IsLoggedIn == false)
        {
                return;
        }
        
        if(val_10 != 0)
        {
            goto label_10;
        }
        
        return;
        label_6:
        .丐不丐丗丘上丂与丞 = 0;
        .上一世丑万丟业上不 = 0;
        .与三上丆丝丛丗丝万 = new System.Action<System.Boolean>(object:  val_1, method:  System.Void FacebookController.丑丗东丞三且丂丄丒::丗下丅丆业业丕丗上(bool 且专上世万丈丐丙丑));
        val_8 = 1152921504615739392;
        .丐不丐丗丘上丂与丞 = new System.Action(object:  val_1, method:  System.Void FacebookController.丑丗东丞三且丂丄丒::不万不丙丞丁不丐丛());
        .上一世丑万丟业上不 = new System.Action(object:  val_1, method:  System.Void FacebookController.丑丗东丞三且丂丄丒::一丗下丆丛世丏丂丕());
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                (FacebookController.丑丗东丞三且丂丄丒)[1152921540088642624].与三上丆丝丛丗丝万.Invoke(obj:  true);
            return;
        }
        
        val_9 = (FacebookController.丑丗东丞三且丂丄丒)[1152921540088642624].丐不丐丗丘上丂与丞;
        label_10:
        val_9.Invoke();
    }
    internal void 不丑丘东与不丒万不(System.Action 七丒上且丝业业下七, bool 丑下丐世丆且丝上丈 = False)
    {
        if(new FacebookController.且且丛丌丝三丏丙丛() != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .七丒上且丝业业下七 = 七丒上且丝业业下七;
    }
    private System.Collections.IEnumerator 丘丄业丑丂丐丆丄丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new FacebookController.东丙丞世丛丄丂丌一();
    }
    public FacebookController()
    {
        this.下三与丘七丄丗一万 = System.String.alignConst;
        this.万丄不丅业丌三丟丘 = new System.Collections.Generic.List<丙上丈丒丁丌不丐丐>();
    }
    private static FacebookController()
    {
        System.Collections.Generic.Dictionary<上丘丟丂万东丟下丂, System.Int32> val_2 = new System.Collections.Generic.Dictionary<上丘丟丂万东丟下丂, System.Int32>(capacity:  2, comparer:  new FacebookController.业丁丂丏一丝上丞丕());
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  7);
        }
        else
        {
                val_2.Add(key:  0, value:  7);
        }
        
        val_2.Add(key:  1, value:  3);
        FacebookController.丗丄丐丆丆业丏上丌 = val_2;
    }
    private void 专三专业丞丛丟丝丆()
    {
        Facebook.Unity.FB.ActivateApp();
        bool val_1 = Facebook.Unity.FB.IsLoggedIn;
        if(val_1 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.丘丄业丑丂丐丆丄丛());
    }

}
