using UnityEngine;
public sealed class FriendsController : MonoBehaviour
{
    // Fields
    private static System.Action 丐与丟丒丁一丂丂三;
    private static bool <丞丛丗丟丈丁丙丟丌>k__BackingField;
    private static string 七丕丆丌丂与丟下三;
    private static System.Action 专一丞与丙东与丕丐;
    internal static System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>>> 下世丄丏不上丁丘丅;
    internal static bool 业丂一丙东与丅一丛;
    internal static FriendsController 丄丞丁丈与业上丞丟;
    private string 丐丐世七丒丏七丈不;
    private int 丕丟世上世一丅丞上;
    private bool 丛丕丒丕丏丒丙丒丅;
    private float 丐丘丟业下丄丂丝丗;
    private static bool 丈丘专万丅下丏丝丞;
    private static string 七万丒丘丐不丗丕丕;
    private static bool 丆丐丟丑世丌丅不丒;
    private static System.Action 且东丞丒丑上专丞丏;
    private static System.Action 一七丂丌丝丒一丕丒;
    private static System.Action 丛东东专业丟丞上一;
    private System.Action<int> 一丘丘丙世丆专上丐;
    private bool 七丛且丟不丒丟万丛;
    public int NumberOfFriendsRequests;
    public int NumberOfBestPlayersRequests;
    public int NumberOfClanInfoRequests;
    public int NumberOfCreateClanRequests;
    private float 丁专上且东专上丟丑;
    public bool idle;
    private System.Collections.Generic.List<int> 世丅丈东丘丐丕丟丐;
    public System.Collections.Generic.List<string> friendsDeletedLocal;
    public string JoinClanSent;
    internal readonly System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> 丞一下丟丞丈丗上丞;
    internal System.Collections.Generic.List<string> 世与万丐业丂与丑丗;
    internal System.Collections.Generic.List<string> 丄且上一丅万丕业丛;
    internal System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> 世丅下丄丌丂万丑一;
    internal readonly System.Collections.Generic.List<string> 丗丆丑世丕七专丝丒;
    internal readonly System.Collections.Generic.List<string> 丈丄丌丒业丐丒上万;
    internal readonly System.Collections.Generic.List<string> 一七丞与丁丆专丒丂;
    internal readonly System.Collections.Generic.List<string> 丆一丐下丐丞丑不丛;
    internal readonly System.Collections.Generic.List<string> 丝丟丄世丗且丕丈丝;
    public string alphaIvory;
    private static System.Security.Cryptography.HMAC 丄丟丒与丙丆丁与丒;
    public string id_fb;
    private const string 不丟三三丟且丗丟万 = "FriendsKey";
    private const string 七丄丒世一且丛不丁 = "ToUsKey";
    private const string 专三丟丛万丘不丌丆 = "FromUsKey";
    private const string 丂丂与丂丄丂丏上丝 = "PlayerInfoKey";
    private const string 丕一丝不丐三世丄丄 = "FriendsInfoKey";
    private const string 与丆丂丏丝上三丗世 = "PixelbookSettingsKey";
    private float 与丙丂丏一一丈丛丅;
    private Rilisoft.NewDayWatcher 丅与七丟上丏丑丅丒;
    private static System.Action 丙东丌丕丆丙丏与丗;
    private static System.Collections.Generic.Dictionary<string, object> 丛丘东丝丆业东上专;
    private static System.Action 丕丐丒下丑丈业丛丛;
    private static System.Action<int, int> 丞世丟丄与七丝东丞;
    private static System.Action<int, int, int, int> 东丞丑丙丗丆三丟七;
    private static System.Action<int, int, int, int> 丟丘丂丗丏万丐东丏;
    internal static bool 一丌一三丂丒丄丐丒;
    private System.Collections.Generic.Dictionary<Rilisoft.七下上丝三丛三上一, string> 丏丌丙丂世丌与一下;
    private static readonly string 万不丑丑且下丞丁七;
    private static System.Collections.Generic.Dictionary<string, string> 丞万专丁一且下丏万;
    private UnityEngine.Coroutine 业丕东一世丄丆七丁;
    private System.Collections.Generic.Dictionary<int, string> 下丒上丝丁业不且丘;
    internal static System.Action 且与丟丗且与业丈丗;
    internal static System.Action 下与世万丏丏丅一丏;
    private readonly System.Collections.Generic.Dictionary<int, System.ValueTuple<System.Action, System.Action>> 丗丄丆丒万且丐业东;
    private readonly System.Collections.Generic.List<string> <专丈丌丟不东丂三丅>k__BackingField;
    private bool <不丁丘且专丑丐业丈>k__BackingField;
    public System.Collections.Generic.Dictionary<string, string> clicksJoinByFriends;
    private static Rilisoft.丄丑丟丟业业丂丛不 丌丆七业丂丌丟丑丆;
    private UnityEngine.Coroutine 丕上丝丟下丏专丛丟;
    private static bool 丘丐丛业一丕丞万不;
    private static string 业丘万不万与不丏下;
    
    // Properties
    internal static bool 专丏且专上不丗丕丌 { get; set; }
    internal static string 专且下丟丘与下丑丝 { get; }
    internal static bool 丙丗丞业与丙业上丙 { get; }
    internal static string 下丈丐七三且且七且 { get; }
    internal static string 丝丏丈丕且丂丂世丑 { get; }
    internal static string 业且丆下丒丂丐丆丘 { get; }
    public int 与专丑上丝上业丆丐 { get; set; }
    public float 丁丐下丏专与丛丒丒 { get; set; }
    internal static bool 丐上丏丆专丒业业世 { get; }
    internal static bool 丕丗世丌丛丒丌业业 { get; set; }
    internal static int 且丌与丒丈丞一丐上 { get; }
    internal static long 丛与丘业三上丛下东 { get; }
    private Rilisoft.NewDayWatcher 丈七业且丝丗丏丏丆 { get; }
    internal static System.Collections.Generic.Dictionary<string, object> 丏丕丈专丘且丕专丘 { get; set; }
    public System.Collections.Generic.List<string> 丁丆丏丈丆三丏丑万 { get; }
    internal bool 丞丄上丟丗丄一丐丁 { get; set; }
    public bool 丟丗丘丗丅且丐丄丏 { get; }
    internal static string 丒三与与丆且丕丞丈 { get; set; }
    
    // Methods
    internal static void 丂丌丌丈一丅与丝丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  FriendsController.与丆丂丏丝上三丗世, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 上丄与且丒丈一且丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  FriendsController.与丆丂丏丝上三丗世, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static bool 丂丑丈丂丌丟丛丝世()
    {
        null = null;
        return (bool)FriendsController.<丞丛丗丟丈丁丙丟丌>k__BackingField;
    }
    private static void 丘世且丞丂一丒丙丕(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        FriendsController.<丞丛丗丟丈丁丙丟丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static string 上上丗且丗不丂下丞()
    {
        string val_3;
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(FriendsController.七丕丆丌丂与丟下三 == null)
        {
                val_5 = null;
            val_5 = null;
            val_4 = null;
            val_3 = System.String.Format(format:  "{0}:{1}", arg0:  ProtocolListGetter.丅三专丐丗丅与丆丑(), arg1:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
            val_4 = null;
            FriendsController.七丕丆丌丂与丟下三 = val_3;
        }
        
        val_4 = null;
        return (string)FriendsController.七丕丆丌丂与丟下三;
    }
    internal static void 专丙且丛丁丞一丞万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.专一丞与丙东与丕丐, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.专一丞与丙东与丕丐 != 1152921505065422872);
    
    }
    internal static void 不丄丐丏且丟专与东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.专一丞与丙东与丕丐, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.专一丞与丙东与丕丐 != 1152921505065422872);
    
    }
    internal static bool 丘丟专专丘东丈丒上()
    {
        return false;
    }
    internal static string 丈丈且丗丑与丕丈丅()
    {
        return "account.support@pixelgun3d.com";
    }
    internal static string 丞丘丛一丝丟与丅丞()
    {
        return (string)(StoreKitEventListener.丝丝一丟丈三丂丌丁() != true) ? "pm.support@pixelgun3d.com" : "ingamereport@pixelgun3d.com";
    }
    internal static int 丁万一丛三下专丟丂(int 丅丈世丕业世丄丏丟)
    {
        if(丅丈世丕业世丄丏丟 < 3)
        {
                return 1;
        }
        
        if(丅丈世丕业世丄丏丟 < 6)
        {
                return 2;
        }
        
        if(丅丈世丕业世丄丏丟 < 11)
        {
                return 3;
        }
        
        if(丅丈世丕业世丄丏丟 < 16)
        {
                return 4;
        }
        
        return 5;
    }
    internal static string 不丝丕丒丂丆丘丙丙()
    {
        return 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    public int get_currentCompetition()
    {
        int val_2 = this.丕丟世上世一丅丞上;
        if((val_2 & 2147483648) == 0)
        {
                return val_1;
        }
        
        val_2 = this.丐丐世七丒丏七丈不;
        int val_1 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_2, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        this.丕丟世上世一丅丞上 = val_1;
        return val_1;
    }
    internal void 丛丒与专丁丂上与丐(int 丙业与丙丗丝不丈东)
    {
        this.丕丟世上世一丅丞上 = 丙业与丙丗丝不丈东;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.丐丐世七丒丏七丈不, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public float get_expirationTimeCompetition()
    {
        var val_2 = null;
        if(FriendsController.丈丘专万丅下丏丝丞 != true)
        {
                int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  FriendsController.七万丒丘丐不丗丕丕, defaultValue:  0);
            val_2 = null;
        }
        
        val_2 = null;
        FriendsController.丈丘专万丅下丏丝丞 = true;
        return (float)this.丐丘丟业下丄丂丝丗;
    }
    private void 专丗三且万一丒丕丒(float 丙业与丙丗丝不丈东)
    {
        var val_3;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 + 丙业与丙丗丝不丈东;
        this.丐丘丟业下丄丂丝丗 = val_1;
        val_3 = null;
        val_3 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  FriendsController.七万丒丘丐不丗丕丕, value:  UnityEngine.Mathf.RoundToInt(f:  丙业与丙丗丝不丈东));
        FriendsController.丈丘专万丅下丏丝丞 = true;
    }
    internal static bool 丞丅丗三丗丙丟丆丝()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    internal static bool 上丐丁三且一丝三世()
    {
        null = null;
        return (bool)FriendsController.丆丐丟丑世丌丅不丒;
    }
    internal static void 丏且丛丈世丗下专丁(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        FriendsController.丆丐丟丑世丌丅不丒 = 丙业与丙丗丝不丈东;
    }
    internal static void 业丐丙丅丒丝丈丕丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.且东丞丒丑上专丞丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.且东丞丒丑上专丞丏 != 1152921505065422928);
    
    }
    internal static void 不丌丒丐丗丒丈万丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.且东丞丒丑上专丞丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.且东丞丒丑上专丞丏 != 1152921505065422928);
    
    }
    internal static void 东东万丑丄丘三丈上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.一七丂丌丝丒一丕丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.一七丂丌丝丒一丕丒 != 1152921505065422936);
    
    }
    internal static void 丈丘丗丈与丝丑丗丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.一七丂丌丝丒一丕丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.一七丂丌丝丒一丕丒 != 1152921505065422936);
    
    }
    internal static void 丅丄不丌丑世且丒七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.丛东东专业丟丞上一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丛东东专业丟丞上一 != 1152921505065422944);
    
    }
    internal static void 东丝丑专七丑丆丒上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.丛东东专业丟丞上一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丛东东专业丟丞上一 != 1152921505065422944);
    
    }
    public void add_ReturnNewIDClan(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.一丘丘丙世丆专上丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丘丘丙世丆专上丐 != 1152921526092901728);
    
    }
    public void remove_ReturnNewIDClan(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.一丘丘丙世丆专上丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丘丘丙世丆专上丐 != 1152921526093038304);
    
    }
    internal static int 丅三专丐丗丅与丆丑()
    {
        return ProtocolListGetter.丅三专丐丗丅与丆丑();
    }
    internal static long 丝丗专上三不丄丑丑()
    {
        return PixelTime.丝丗专上三不丄丑丑();
    }
    internal static System.Nullable<System.DateTime> 业丈丏丏丞丘丛丈丛()
    {
        long val_1 = FriendsController.丝丗专上三不丄丑丑();
        if(val_1 <= 0)
        {
                return 0;
        }
        
        System.DateTime val_2 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  val_1);
        return 0;
    }
    public void FastGetPixelbookSettings()
    {
        this.与丙丂丏一一丈丛丅 = -1f;
    }
    private Rilisoft.NewDayWatcher 万不业不丂丏三丕一()
    {
        Rilisoft.NewDayWatcher val_6;
        if(this.丅与七丟上丏丑丅丒 == 0)
        {
                this.丅与七丟上丏丑丅丒 = this.gameObject.AddComponent<Rilisoft.NewDayWatcher>();
            return val_6;
        }
        
        val_6 = this.丅与七丟上丏丑丅丒;
        return val_6;
    }
    private System.Collections.IEnumerator 业丄丙丄三丁丝丛丆(System.Threading.Tasks.Task 丏丗丏丝丌七三丅丗)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丏丗丏丝丌七三丅丗 = 丏丗丏丝丌七三丅丗;
        return (System.Collections.IEnumerator)new FriendsController.不丑三丄丒丘业丟丟();
    }
    internal static void 三丁丅世丙一东上世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.丙东丌丕丆丙丏与丗, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丙东丌丕丆丙丏与丗 != 1152921505065422960);
    
    }
    internal static void 业丒丛一丌丟业世丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.丙东丌丕丆丙丏与丗, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丙东丌丕丆丙丏与丗 != 1152921505065422960);
    
    }
    internal static System.Collections.Generic.Dictionary<string, object> 丄丐丗丒丒三丕万丞()
    {
        null = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)FriendsController.丛丘东丝丆业东上专;
    }
    private static void 丌与不丑丕丞专丟丈(System.Collections.Generic.Dictionary<string, object> 丙业与丙丗丝不丈东)
    {
        null = null;
        FriendsController.丛丘东丝丆业东上专 = 丙业与丙丗丝不丈东;
        if(FriendsController.丙东丌丕丆丙丏与丗 == null)
        {
                return;
        }
        
        FriendsController.丙东丌丕丆丙丏与丗.Invoke();
    }
    internal void 丐七丘丗丂丏丈丌丗()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = FriendsController.一七丂丌丝丒一丕丒;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = FriendsController.一七丂丌丝丒一丕丒;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal static void 一丂丝丝丂丕丑丄与()
    {
        object val_17;
        var val_19;
        var val_22;
        object val_23;
        if(FriendsController.丝丗专上三不丄丑丑() == 1)
        {
                return;
        }
        
        object val_3 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  13);
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_17 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().七不丈专丙世丅丕丝().GetEnumerator();
        val_19 = 0;
        goto label_18;
        label_32:
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_19 = val_19 | (Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丌丄丕丁丗丝且丞一(上且丗一丏丏万丅丌:  val_17.Current, 七丆世丌丆丟丙丆业: ref  new System.Collections.Generic.Dictionary<System.String, System.Object>()));
        label_18:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_17.MoveNext() == true)
        {
            goto label_32;
        }
        
        val_22 = 0;
        val_23 = 0;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_3.Dispose();
        }
        
        if( == 1)
        {
            goto label_51;
        }
        
        if( == null)
        {
            goto label_55;
        }
        
        if(111 != 111)
        {
            goto label_53;
        }
        
        goto label_55;
        label_51:
        if( == null)
        {
            goto label_55;
        }
        
        label_53:
        label_55:
        if((W23 & 1) == 0)
        {
                return;
        }
        
        val_17 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_17.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  13, 丙业与丙丗丝不丈东:  val_3);
    }
    internal static void 丁不业与东万丘丕三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.丕丐丒下丑丈业丛丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丕丐丒下丑丈业丛丛 != 1152921505065422976);
    
    }
    internal static void 丒业丟丛与丝丁丅丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.丕丐丒下丑丈业丛丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丕丐丒下丑丈业丛丛 != 1152921505065422976);
    
    }
    private System.Collections.IEnumerator 丙丞丝一丘丙丛专丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new FriendsController.上丝丝丈丂丆丝丘业();
    }
    internal static void 丙丐丟与不下与万丞(System.Action<int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.丞世丟丄与七丝东丞, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丞世丟丄与七丝东丞 != 1152921505065422984);
    
    }
    internal static void 业丌丈丁专丏丒下丒(System.Action<int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.丞世丟丄与七丝东丞, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丞世丟丄与七丝东丞 != 1152921505065422984);
    
    }
    internal static void 丟丆一专丈上丑下丆(System.Action<int, int, int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.东丞丑丙丗丆三丟七, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.东丞丑丙丗丆三丟七 != 1152921505065422992);
    
    }
    internal static void 丐丟丌丅三丕丑丈三(System.Action<int, int, int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.东丞丑丙丗丆三丟七, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.东丞丑丙丗丆三丟七 != 1152921505065422992);
    
    }
    internal static void 丙丙丁一下丁丄专丐(System.Action<int, int, int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendsController.丟丘丂丗丏万丐东丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丟丘丂丗丏万丐东丏 != 1152921505065423000);
    
    }
    internal static void 下丄丘丘丛丂丟三丐(System.Action<int, int, int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendsController.丟丘丂丗丏万丐东丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendsController.丟丘丂丗丏万丐东丏 != 1152921505065423000);
    
    }
    private static void 丕丑万丛丞业丆丄丗(string 下上丐丆丝丟丝丒不, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> 丝丘丑业丛万丞丌丝)
    {
        var val_15;
        string val_16;
        var val_22;
        var val_23;
        var val_24;
        val_16 = 下上丐丆丝丟丝丒不;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  val_16, defaultValue:  "[]"));
        if(val_2 == null)
        {
                return;
        }
        
        val_16 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        return;
        label_41:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        System.Collections.Generic.Dictionary<System.String, System.String> val_11 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        Dictionary.Enumerator<TKey, TValue> val_12 = Current.GetEnumerator();
        label_27:
        if((14173616 & 1) == 0)
        {
            goto label_23;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_15.GetAwaiter();
        if((val_16._value._obj == 0) || (val_16._value._obj != null))
        {
            goto label_27;
        }
        
        null.Add(key:  val_16._value._obj.丐丏七丌丕丗业且上(), value:  val_16._value._obj);
        goto label_27;
        label_23:
        var val_22 = 0;
        val_22 = ;
        val_22 = val_22 + 1;
        mem2[0] = 141;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_24 = val_22;
        if((val_24 == 1) || ((1152921526095856976 + ((0 + 1)) << 2) != 141))
        {
            goto label_34;
        }
        
        var val_23 = 0;
        val_23 = val_23 ^ (val_24 >> 31);
        val_24 = val_24 + val_23;
        if(丝丘丑业丛万丞丌丝 != null)
        {
            goto label_40;
        }
        
        goto label_39;
        label_34:
        if( == 0)
        {
            goto label_37;
        }
        
        if(丝丘丑业丛万丞丌丝 != null)
        {
            goto label_40;
        }
        
        goto label_39;
        label_37:
        if(丝丘丑业丛万丞丌丝 != null)
        {
            goto label_40;
        }
        
        label_39:
        label_40:
        丝丘丑业丛万丞丌丝.Add(item:  null);
        goto label_41;
        label_16:
        val_23 = val_24 + 1;
        mem2[0] = 168;
        if( == null)
        {
            
        }
        else
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_24 = ;
            Dispose();
            val_23 = ;
        }
        
        if(val_23 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921526095856976 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) != 168)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    internal string 丄东不七丙且丈丑专(Rilisoft.七下上丝三丛三上一 丑丈丌业下丂下丑丘)
    {
        Rilisoft.七下上丝三丛三上一 val_4;
        int val_5;
        val_4 = 丑丈丌业下丂下丑丘;
        int val_1 = System.String.alignConst;
        if((this.丏丌丙丂世丌与一下.TryGetValue(key:  val_4, value: out  val_1)) != false)
        {
                val_4 = val_1;
            string val_3 = I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  val_4);
            return (string)val_5;
        }
        
        val_5 = System.String.alignConst;
        return (string)val_5;
    }
    private static void 丄丄丏丝丄丌丙业世(string 下上丐丆丝丟丝丒不, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 万丝且丘不丑丝下丑)
    {
        var val_15;
        string val_20;
        var val_21;
        var val_22;
        var val_23;
        string val_25;
        var val_26;
        var val_27;
        var val_29;
        val_20 = 下上丐丆丝丟丝丒不;
        val_21 = 1152921505491668992;
        Rilisoft.丝丟丄丅与业世专丈 val_2 = new Rilisoft.丝丟丄丅与业世专丈(丕丗丘丑丛与丑业丒:  "Storager extracting " + val_20);
        val_22 = 0;
        val_23 = 0;
        if(val_2 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_2.Dispose();
        }
        
        if((val_22 != 1) && (47 == 47))
        {
                val_22 = 0;
        }
        else
        {
                if(val_23 != 0)
        {
                val_23 = 0;
        }
        
        }
        
        Rilisoft.丝丟丄丅与业世专丈 val_6 = null;
        val_25 = val_6;
        val_6 = new Rilisoft.丝丟丄丅与业世专丈(丕丗丘丑丛与丑业丒:  "Json decoding " + val_20);
        object val_7 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  val_20, defaultValue:  "{}"));
        val_26 = 0;
        val_27 = 0 + 1;
        mem2[0] = 90;
        if(val_25 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_6.Dispose();
        }
        
        if((val_27 != 1) && ((1152921526096184848 + ((0 + 1)) << 2) == 90))
        {
                var val_22 = 0;
            val_22 = val_22 ^ (val_27 >> 31);
            val_27 = val_27 + val_22;
            return;
        }
        
        if(val_23 != 0)
        {
                val_23 = 0;
        }
        
        if(Count < 1)
        {
                return;
        }
        
        val_25 = "Dictionary copying " + val_20;
        Rilisoft.丝丟丄丅与业世专丈 val_11 = null;
        val_20 = val_11;
        val_11 = new Rilisoft.丝丟丄丅与业世专丈(丕丗丘丑丛与丑业丒:  val_25);
        Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
        val_21 = 1152921516595684768;
        label_30:
        if((14501472 & 1) == 0)
        {
            goto label_25;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_15.GetAwaiter();
        if(val_16._value._obj == 0)
        {
            goto label_30;
        }
        
        万丝且丘不丑丝下丑.Add(key:  val_16._value._obj.丐丏七丌丕丗业且上(), value:  val_16._value._obj);
        goto label_30;
        label_25:
        val_29 = val_27 + 1;
        mem2[0] = 209;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(0 == 1)
        {
            goto label_43;
        }
        
        if( == 0)
        {
            goto label_46;
        }
        
        if(47 != 209)
        {
            goto label_45;
        }
        
        goto label_46;
        label_43:
        if( == 0)
        {
            goto label_47;
        }
        
        label_45:
        val_23 = 0;
        label_46:
        if(val_20 != null)
        {
            goto label_50;
        }
        
        goto label_54;
        label_47:
        val_29 = 0;
        if(val_20 != null)
        {
            goto label_50;
        }
        
        goto label_54;
        label_50:
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_11.Dispose();
        label_54:
        if(val_29 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921526096184848 + (((0 + 1) + 1)) << 2) == 209)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal static void 专与一丅丆万丏与下()
    {
    
    }
    private void Awake()
    {
        var val_9;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  FriendsController.万不丑丑且下丞丁七)) != true)
        {
                val_10 = null;
            val_10 = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  FriendsController.万不丑丑且下丞丁七, 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        val_11 = null;
        val_11 = null;
        this.id_fb = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  FriendsController.万不丑丑且下丞丁七);
        FriendsController.丄丞丁丈与业上丞丟 = this;
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsController::不丁丛丅上丝丑丅丗()));
        Rilisoft.丈丁丅丁东业丞业丑.丝丐世且丞丁丗丛丛(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void FriendsController::专与一丅丆万丏与下()));
        val_12 = this.alphaIvory;
        if(val_12 == null)
        {
                val_12 = System.String.alignConst;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_12)) != false)
        {
                UnityEngine.Debug.LogError(message:  "Secret is empty!");
        }
        
        val_13 = null;
        val_13 = null;
        FriendsController.丄丟丒与丙丆丁与丒 = new System.Security.Cryptography.HMACSHA1(key:  System.Text.Encoding.UTF8, useManagedSha1:  true);
        Progress.下丁下丂七丆丙七一.丈丞七上丑丛上丘不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsController::丒丅丅且万业三专东()));
    }
    private void 不丁丛丅上丝丑丅丗()
    {
        var val_43;
        var val_44;
        var val_45;
        object val_46;
        var val_47;
        var val_48;
        var val_49;
        Progress.下丁下丂七丆丙七一 val_1 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_1.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  143);
        val_1.丘丅丅丅东与丂丞七();
        val_1.与丟万丅七世不一业();
        val_1.丕丅丗丟丅丘丆丕七();
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  Rilisoft.丈丁丅丁东业丞业丑.丐丕丏丂不丅世丑丅())) != false)
        {
                if((System.String.IsNullOrEmpty(value:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  Rilisoft.丈丁丅丁东业丞业丑.丐丕丏丂不丅世丑丅()))) == false)
        {
            goto label_9;
        }
        
        }
        
        val_43 = null;
        val_43 = null;
        Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_7 = null;
        val_44 = 0;
        val_7 = new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsController::三丞丏专丝丗不七一(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丗丁丏丌世丈丒丐, 七丐丅专且专七三丆:  val_7);
        int val_9 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丗丁丏丌世丈丒丐);
        label_9:
        int val_10 = UnityEngine.PlayerPrefs.GetInt(key:  "SessionDayNumber");
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  52)) < val_10)
        {
                val_44 = 0;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  52, 丙业与丙丗丝不丈东:  val_10);
        }
        
        val_45 = null;
        val_45 = null;
        if((System.String.op_Inequality(a:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  54), b:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒)) != false)
        {
                if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  52)) != false)
        {
                val_46 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  52);
        }
        else
        {
                val_46 = 1;
        }
        
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  53, 丙业与丙丗丝不丈东:  val_46);
            ReviewController.专丙不与丗丕丈业丂(丙业与丙丗丝不丈东:  false);
            ReviewController.丗丆丟丑丟三丁丘上(丙业与丙丗丝不丈东:  false);
            ReviewController.七世丝东万不丂丈且();
            val_44 = 0;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  54, 丙业与丙丗丝不丈东:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.与丛丟且丕丒业一丘();
        val_47 = null;
        val_47 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_48 = null;
            val_48 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丐不专丗丞不不丑丏();
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ClanChestsChangedWindow-viewed")) != false)
        {
                val_44 = 0;
            if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "ClanChestsChangedWindow-viewed", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) >= 1)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  31);
        }
        
        }
        
        decimal val_28 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丌丅业专丑专专万丑();
        val_49 = null;
        val_49 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_28.flags, hi = val_28.hi, lo = val_28.lo, mid = val_28.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                Progress.下丁下丂七丆丙七一 val_30 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_30.世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  38);
        }
        
        val_30.丕一丗三丐七万丝三();
        PGCompany.丗丅与不丛专丏丙丗 val_32 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().下丕世且不丄丂且丏();
        if(专丈专业丆且且业下.丒丌专一丘丈专且且() != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  64);
        }
        
        if((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "send-1026-inhouse-"("send-1026-inhouse-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丞丌丑丛上丕丙丕下:  0)) != 0)
        {
                PGCompany.Analytics.一业丗丆世世上丁且.丙与不丞三丑丑业丏(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且丙七丂万丁丙丕一:  0, 世与丝丒业丗丈丅丟:  new System.Nullable<System.Int32>() {HasValue = false});
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "send-1026-inhouse-"("send-1026-inhouse-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() >= 3)
        {
                WeaponManager.丌丐不不下丏丝丏丒(不丐丅丁丂七丐丘丛:  10);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void 丕一丗三丐七万丝三()
    {
        var val_13;
        string val_23;
        string val_25;
        val_23 = Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三();
        System.Collections.Generic.List<System.Char> val_3 = new System.Collections.Generic.List<System.Char>();
        if(val_23 == null)
        {
                return;
        }
        
        if(val_23.Length >= 1)
        {
                var val_22 = 0;
            do
        {
            if((万三丟丞业万丕丐丌.丅丗丑一丁一丌丏丕(丕上丙丝丅丛丐丏丑:  val_23.Chars[0])) != true)
        {
                if((val_3.Contains(item:  val_23.Chars[0])) != true)
        {
                val_3.Add(item:  val_23.Chars[0]);
        }
        
        }
        
            val_22 = val_22 + 1;
        }
        while(val_22 < val_23.Length);
        
        }
        
        List.Enumerator<T> val_11 = val_3.GetEnumerator();
        label_14:
        if((15323776 & 1) == 0)
        {
            goto label_12;
        }
        
        string val_15 = val_23.Replace(oldValue:  val_13.EventId, newValue:  System.String.alignConst);
        goto label_14;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_16 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_23);
        val_25 = val_16;
        if((System.String.IsNullOrEmpty(value:  val_16)) != true)
        {
                if((System.String.op_Equality(a:  val_25.Trim(), b:  System.String.alignConst)) == false)
        {
            goto label_24;
        }
        
        }
        
        val_25 = ProfileController.丐与丄东丆上丟丑与();
        label_24:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丐万丑丏上专世专(丑与丕丐七丆三丟一:  val_25);
    }
    private void 丘丅丅丅东与丂丞七()
    {
        var val_9;
        var val_13;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  152);
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        val_13 = 0;
        goto label_4;
        label_12:
        int val_13 = new int[10] {19001, 908001, 909001, 910001, 911001, 912001, 913001, 936001, 937001, 938001}[0];
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_13)) == null)
        {
                val_3.Add(item:  val_13);
        }
        
        val_13 = 1;
        label_4:
        if(val_13 < val_2.Length)
        {
            goto label_12;
        }
        
        List.Enumerator<T> val_7 = val_3.GetEnumerator();
        label_18:
        if((15505616 & 1) == 0)
        {
            goto label_14;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三下丗万丆专丄且东(下且与丐上丟七丑丏:  val_9.丙东专丂世丈丏丁丂(), 丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  0), 世丙与专七丟丒丆世:  8, 世丁丙世丄一万丆三:  "GDW");
        goto label_18;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void 丕丅丗丟丅丘丆丕七()
    {
        string val_5;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_34;
        val_26 = 1152921505359773696;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  164);
        val_27 = null;
        val_27 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = WeaponManager.且专专丁丌丗丛且丙.GetEnumerator();
        label_47:
        if((15791776 & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        char[] val_9 = new char[1];
        val_9[0] = '#';
        System.String[] val_10 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  2, 下上丐丆丝丟丝丒不:  val_5).Split(separator:  val_9);
        val_28 = 0;
        val_29 = 0;
        goto label_15;
        label_41:
        if((System.String.IsNullOrEmpty(value:  val_10[0])) == true)
        {
            goto label_29;
        }
        
        三丅丁丗丗丝丂万且 val_12 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_10[0x0] + 32);
        if(val_12 == null)
        {
            goto label_21;
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_12.业东丅东丌上丗丑不())) != null)
        {
            goto label_29;
        }
        
        val_30 = null;
        val_30 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_12.与不丞丑七丘丁丂丛())) == true)
        {
            goto label_29;
        }
        
        label_21:
        char[] val_19 = new char[1];
        val_19[0] = '#';
        val_29 = 1;
        mem2[0] = val_5.Invoke().Split(separator:  val_19)[0];
        label_29:
        val_28 = 1;
        label_15:
        if(val_28 < val_10.Length)
        {
            goto label_41;
        }
        
        if((val_29 & 1) == 0)
        {
            goto label_47;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_5, 下下丏一丙不丘丌丞:  System.String.Join(separator:  "#", value:  val_10));
        goto label_47;
        label_7:
        val_31 = 0;
        val_32 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_80;
        }
        
        if( == 0)
        {
            goto label_84;
        }
        
        if(280 != 280)
        {
            goto label_82;
        }
        
        goto label_84;
        label_80:
        if( == 0)
        {
            goto label_84;
        }
        
        label_82:
        label_84:
        if((1 & 1) != 0)
        {
                val_34 = null;
            val_34 = null;
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  ShopNGUIController.丛世丛与丌不丈丐丐(), 专丆丌丛东一不丑丙:  0);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void 与丟万丅七世不一业()
    {
        var val_6;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "LA_ST_CHO_OS_ED_GA_ME_MOD_")) == true)
        {
                return;
        }
        
        val_6 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if((val_6.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  3)) == false)
        {
                return;
        }
        
        ConnectScene.RegimMulty = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  3);
    }
    private void 三丞丏专丝丗不七一(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_5;
        int val_6;
        val_5 = null;
        val_5 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.业丗丁丏丌世丈丒丐, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsController::三丞丏专丝丗不七一(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        if(丑与丂丌世丕丆一丗 == null)
        {
                return;
        }
        
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "version")) == false)
        {
                return;
        }
        
        val_6 = 丑与丂丌世丕丆一丗.Item["version"];
        if(val_6 != null)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        val_6 = System.String.alignConst;
        label_8:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  Rilisoft.丈丁丅丁东业丞业丑.丐丕丏丂不丅世丑丅(), 下下丏一丙不丘丌丞:  val_6);
    }
    private void 七丕丕一丕丁丆丛下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        FriendsController.一丂丝丝丂丕丑丄与();
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 62)
        {
                return;
        }
        
        FriendsController.丂丘七丌丂丆丒丞丝();
    }
    public System.Collections.Generic.IEnumerable<float> InitController()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.Generic.IEnumerable<System.Single>)new FriendsController.丟丒丒丝丏下与下丛();
    }
    private void 丆三丁丂三丙七丐一()
    {
        var val_10;
        if(专丈专业丆且且业下.丒丌专一丘丈专且且() != false)
        {
                丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Clear();
            丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丈世丈上不丗世丑丂().Clear();
            丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三().Clear();
            且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万().Clear();
            this.丝丟丄世丗且丕丈丝.Clear();
            this.七丝专世与不七丁丐();
            UnityEngine.PlayerPrefs.Save();
        }
        
        Switcher.丘丑丛丄丐丟不七丞(与不丕丆丈不丙丟丛:  MiscAppsMenu.丆丕丝丒不丙且丐丗.misc);
        val_10 = null;
        val_10 = null;
        FriendsController.业丂一丙东与丅一丛 = true;
    }
    private void 丕东世上业丑世丘东(string 丆七一丗丒丅与丌丌)
    {
        string val_4;
        var val_5;
        val_4 = 丆七一丗丒丅与丌丌;
        if(val_4 == null)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.id_fb)) != true)
        {
                if((val_4.Equals(value:  this.id_fb)) != false)
        {
                return;
        }
        
        }
        
        this.id_fb = val_4;
        val_5 = null;
        val_5 = null;
        val_4 = this.id_fb;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  FriendsController.万不丑丑且下丞丁七, 下下丏一丙不丘丌丞:  val_4);
        业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
    }
    public void UnbanUs(System.Action 七丒上且丝业业下七)
    {
    
    }
    internal static string 三且丞七丗东不丘丝(string 七丐丅专且专七三丆, string 不丒三业下丑不丞业)
    {
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = 不丒三业下丑不丞业;
        if(七丐丅专且专七三丆 == null)
        {
            goto label_1;
        }
        
        if(val_15 != null)
        {
            goto label_2;
        }
        
        val_15 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(val_15 == null)
        {
            goto label_20;
        }
        
        label_2:
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) >= 2)
        {
                return (string)System.String.alignConst;
        }
        
        string val_4 = 0;
        string val_3 = 七丐丅专且专七三丆 + "-"("-") + val_15;
        val_16 = null;
        val_16 = null;
        bool val_5 = FriendsController.丞万专丁一且下丏万.TryGetValue(key:  val_3, value: out  val_4);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == false)
        {
                return (string)System.String.alignConst;
        }
        
        if((七丐丅专且专七三丆.Equals(value:  "get_player_online")) == false)
        {
            goto label_13;
        }
        
        val_17 = "*:*.*.*";
        goto label_14;
        label_1:
        label_20:
        UnityEngine.Debug.LogWarning(message:  "Hash: action is null");
        return (string)System.String.alignConst;
        label_13:
        label_14:
        string val_9 = FriendsController.上上丗且丗不丂下丞() + val_15 + 七丐丅专且专七三丆;
        val_18 = null;
        val_18 = null;
        FriendsController.丞万专丁一且下丏万.Add(key:  val_3, value:  System.BitConverter.ToString(value:  FriendsController.丄丟丒与丙丆丁与丒.ComputeHash(buffer:  System.Text.Encoding.UTF8)).Replace(oldValue:  "-", newValue:  System.String.alignConst).ToLower());
        return (string)System.String.alignConst;
    }
    internal static string 三丕丝丘丘丕三丅且(byte[] 且专丝丙丝不丈七丑)
    {
        var val_5;
        System.Security.Cryptography.HMAC val_6;
        if(且专丝丙丝不丈七丑 == null)
        {
            goto label_1;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = FriendsController.丄丟丒与丙丆丁与丒;
        if(val_6 == null)
        {
            goto label_4;
        }
        
        val_6 = FriendsController.丄丟丒与丙丆丁与丒;
        if(val_6 == null)
        {
                val_6 = 0;
        }
        
        string val_3 = System.BitConverter.ToString(value:  val_6.ComputeHash(buffer:  且专丝丙丝不丈七丑)).Replace(oldValue:  "-", newValue:  System.String.alignConst);
        if(val_3 != null)
        {
                return val_3.ToLower();
        }
        
        return val_3.ToLower();
        label_1:
        UnityEngine.Debug.LogWarning(message:  "HashForPush: responceData is null");
        return (string)System.String.alignConst;
        label_4:
        System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  "Hmac is not initialized yet.");
    }
    public bool IsShowAdd(string 业丗丑丝丙业丝丏上)
    {
        var val_12;
        var val_13;
        var val_14;
        val_12 = 1152921505234001920;
        val_13 = null;
        val_13 = null;
        if(丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count >= 与丂丏丛丞丞丒丟丄.下丑丑万丛丆丏业世)
        {
                return (bool)0 & 1;
        }
        
        if((业丗丑丝丙业丝丏上.Equals(value:  "-1")) == true)
        {
                return (bool)0 & 1;
        }
        
        if((业丗丑丝丙业丝丏上.Equals(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
        {
                return (bool)0 & 1;
        }
        
        val_12 = 1152921516734113248;
        if((丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Contains(item:  业丗丑丝丙业丝丏上)) != false)
        {
                return (bool)0 & 1;
        }
        
        val_14 = null;
        val_14 = null;
        bool val_12 = (Contains(item:  业丗丑丝丙业丝丏上)) ^ 1;
        return (bool)0 & 1;
    }
    public void SendScoreInMiniGames(int 丂丛丑东不丅丈一东, int 业丌七业业七丞与丄)
    {
        var val_3;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_1.Add(key:  "mode", value:  丂丛丑东不丅丈一东);
        val_1.Add(key:  "scores", value:  业丌七业业七丞与丄);
        Rilisoft.WebSocket.丘七丝且东丙丁丅专 val_2 = new Rilisoft.WebSocket.丘七丝且东丙丁丅专(丝丏业丅丈东业丝丒:  "set_player_scores", 一丐丗丁丞丆丅丟丄:  val_1);
        if(val_2 != null)
        {
                val_2.三丏丐丐丌丘丌丏世(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_2.三丏丐丐丌丘丌丏世(丙业与丙丗丝不丈东:  true);
        }
        
        val_2.丈丂丑丒三一下丏七();
        val_3 = null;
        val_3 = null;
        if(FriendsController.专一丞与丙东与丕丐 == null)
        {
                return;
        }
        
        FriendsController.专一丞与丙东与丕丐.Invoke();
    }
    internal void 七丝专世与不七丁丐()
    {
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Boolean> val_34;
        var val_35;
        val_34 = 1152921505234001920;
        if(丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上() != null)
        {
                string val_5 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上());
            UnityEngine.PlayerPrefs.SetString(key:  "FriendsKey", value:  (val_5 == null) ? "[]" : (val_5));
        }
        
        if(且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万() != null)
        {
                string val_11 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万());
            UnityEngine.PlayerPrefs.SetString(key:  "ToUsKey", value:  (val_11 == null) ? "[]" : (val_11));
        }
        
        if(丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丈世丈上不丗世丑丂() != null)
        {
                string val_17 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丈世丈上不丗世丑丂());
            UnityEngine.PlayerPrefs.SetString(key:  "FromUsKey", value:  (val_17 == null) ? "[]" : (val_17));
        }
        
        if(丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三() != null)
        {
                val_35 = null;
            val_35 = null;
            val_34 = FriendsController.<>c.<>9__141_0;
            if(val_34 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Boolean> val_23 = null;
            val_34 = val_23;
            val_23 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Boolean>(object:  FriendsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FriendsController.<>c::丈下丘上一下世下丘(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 三丟东丕丄丄下下丑));
            FriendsController.<>c.<>9__141_0 = val_34;
        }
        
            string val_26 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>(source:  丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三(), predicate:  val_23)));
            UnityEngine.PlayerPrefs.SetString(key:  "PlayerInfoKey", value:  (val_26 == null) ? "{}" : (val_26));
        }
        
        if(丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄() != null)
        {
                string val_32 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄());
            UnityEngine.PlayerPrefs.SetString(key:  "FriendsInfoKey", value:  (val_32 == null) ? "{}" : (val_32));
        }
        
        this.专世丑丅丏一丂丄与();
    }
    private void 业业丑世丒一丂丒且()
    {
    
    }
    private void 东业专丕三丑丈丙下()
    {
        null = null;
        FriendsController.丞万专丁一且下丏万.Clear();
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        FriendsController.丐丏丅且丝丟上丌丒 val_1 = new FriendsController.丐丏丅且丝丟上丌丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丁与丟万丄丒丗专丌 = 丁与丟万丄丒丗专丌;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnDestroy()
    {
        Rilisoft.丈丁丅丁东业丞业丑.丂世丂丌丝七与丗丝(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void FriendsController::专与一丅丆万丏与下()));
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsController::不丁丛丅上丝丑丅丗()));
        Progress.下丁下丂七丆丙七一.丅丗东且丞三三丅丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendsController::丒丅丅且万业三专东()));
    }
    public void SyncRatingAndRoundWon(bool 丞业一专不七三丁丘)
    {
        var val_3 = 0;
        if(丞业一专不七三丁丘 != false)
        {
                世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            if(val_1 != null)
        {
                Rilisoft.七丕丟丏三丈一丄世 val_2 = GameConnect.丑丌丛丈丅丅与不业();
            val_3 = 0;
        }
        else
        {
                val_3 = 0;
        }
        
        }
        
        val_1.SynchRatingTiers(上且丗一丏丏万丅丌:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public void SynchRatingTiers(System.Nullable<int> 上且丗一丏丏万丅丌)
    {
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if((19031736 & 1) != 0)
        {
                val_1.set_Item(key:  "mode", value:  上且丗一丏丏万丅丌.HasValue);
        }
        
        val_1.set_Item(key:  "rating", value:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
        val_1.set_Item(key:  "league_id", value:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        if(GameConnect.丕上丐丄三上丝专万() == false)
        {
            goto label_11;
        }
        
        val_11 = null;
        val_11 = null;
        int val_11 = 与七丗三三丗一三丑.与丑丂专丁世不丑世;
        val_11 = val_11 - 1;
        与七丗三三丗一三丑.与丑丂专丁世不丑世 = val_11;
        if(与七丗三三丗一三丑.与丑丂专丁世不丑世 <= 0)
        {
            goto label_14;
        }
        
        与七丗三三丗一三丑.丂且不业丂专丛丆东();
        goto label_27;
        label_11:
        val_12 = null;
        val_12 = null;
        int val_12 = 丛业丆丝七不丌世丅.与丑丂专丁世不丑世;
        val_12 = val_12 - 1;
        丛业丆丝七不丌世丅.与丑丂专丁世不丑世 = val_12;
        if(丛业丆丝七不丌世丅.与丑丂专丁世不丑世 <= 0)
        {
            goto label_20;
        }
        
        丛业丆丝七不丌世丅.丂且不业丂专丛丆东();
        goto label_27;
        label_14:
        val_1.set_Item(key:  "kill_rate_mode_upgrade_v3_competion", value:  与七丗三三丗一三丑.丂丆丑世一不丘丏七());
        与七丗三三丗一三丑.且七丙丄丘一丄上不();
        goto label_27;
        label_20:
        val_1.set_Item(key:  "kill_rate_mode_upgrade_v3", value:  丛业丆丝七不丌世丅.丂丆丑世一不丘丏七());
        丛业丆丝七不丌世丅.且七丙丄丘一丄上不();
        label_27:
        val_13 = null;
        val_13 = null;
        Rilisoft.WebSocket.丘七丝且东丙丁丅专 val_9 = new Rilisoft.WebSocket.丘七丝且东丙丁丅专(丝丏业丅丈东业丝丒:  Rilisoft.WebSocket.业丛世业世不丄丐三.七丁丘丐丈七丝丒丆, 一丐丗丁丞丆丅丟丄:  val_1);
        if(val_9 != null)
        {
                val_9.三丏丐丐丌丘丌丏世(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_9.三丏丐丐丌丘丌丏世(丙业与丙丗丝不丈东:  true);
        }
        
        val_9.丈丂丑丒三一下丏七();
        业丂丏与世一丏业不.丑七不且上丗丁一世().丛丘丅下七万丁丟丗(一丐丗丁丞丆丅丟丄:  val_1);
    }
    private void 丒丅丅且万业三专东()
    {
        var val_11;
        var val_12;
        FriendsController.丘世且丞丂一丒丙丕(丙业与丙丗丝不丈东:  false);
        if(FriendsController.与丆丂丏丝上三丗世 != null)
        {
                FriendsController.与丆丂丏丝上三丗世.Invoke();
        }
        
        val_11 = null;
        val_11 = null;
        if(((Progress.下丁下丂七丆丙七一.丛专丞七丏专七丝东 != false) && (Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丌丗丟丏丑丟丁() != null)) && ((System.String.op_Inequality(a:  Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专一丌丗丟丏丑丟丁(), b:  UnityEngine.SystemInfo.deviceUniqueIdentifier)) != false))
        {
                val_12 = null;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  null)) != false)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "OldPurchased", 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "OldPurchased")) != false)
        {
                if((System.String.IsNullOrEmpty(value:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "OldPurchased"))) == false)
        {
            goto label_25;
        }
        
        }
        
        this.东丆丗丄丁丁三丞丒(且丆万丕丐丛三丙丟:  0f);
        return;
        label_25:
        FriendsController.丘世且丞丂一丒丙丕(丙业与丙丗丝不丈东:  true);
        if(FriendsController.与丆丂丏丝上三丗世 == null)
        {
                return;
        }
        
        FriendsController.与丆丂丏丝上三丗世.Invoke();
    }
    private void 东丆丗丄丁丁三丞丒(float 且丆万丕丐丛三丙丟)
    {
        if(this.业丕东一世丄丆七丁 != null)
        {
                this.StopCoroutine(routine:  this.业丕东一世丄丆七丁);
            this.业丕东一世丄丆七丁 = 0;
        }
        
        this.业丕东一世丄丆七丁 = this.StartCoroutine(routine:  this.丌业上不一上丅丁丁(且丆万丕丐丛三丙丟:  且丆万丕丐丛三丙丟));
    }
    private System.Collections.IEnumerator 丌业上不一上丅丁丁(float 且丆万丕丐丛三丙丟)
    {
        FriendsController.丏丏丆丗丁丝不丟丅 val_1 = new FriendsController.丏丏丆丗丁丝不丟丅();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .且丆万丕丐丛三丙丟 = 且丆万丕丐丛三丙丟;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丁丗东丌丐七且七丆(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_10;
        var val_11;
        var val_22;
        var val_23;
        var val_24;
        var val_26;
        val_23 = this;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 0;
        int val_15 = 0;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) == true)
        {
            goto label_5;
        }
        
        bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "data", 丙业与丙丗丝不丈东: out  val_2);
        if(val_2 == 0)
        {
            goto label_5;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_24 = 0;
        goto label_12;
        label_5:
        this.东丆丗丄丁丁三丞丒(且丆万丕丐丛三丙丟:  30f);
        return;
        label_12:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "OldPurchased", 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_2));
        PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丏丛不下一丝专丕丙();
        Dictionary.Enumerator<TKey, TValue> val_8 = val_2.GetEnumerator();
        val_22 = 1152921504691564544;
        label_43:
        if((19642832 & 1) == 0)
        {
            goto label_20;
        }
        
        ConfiguredValueTaskAwaiter val_12 = val_11.GetAwaiter();
        if(val_12._value._obj == 0)
        {
            goto label_43;
        }
        
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal>> val_13 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal>>();
        val_26 = 0;
        goto label_24;
        label_39:
        object val_14 = val_12._value._obj.Item[0];
        if((val_14 != null) && ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_14, 下上丐丆丝丟丝丒不:  "ctime", 丙业与丙丗丝不丈东: out  val_15)) != false))
        {
                if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_14, 下上丐丆丝丟丝丒不:  "inapp", 丙业与丙丗丝不丈东: out  val_15)) != false)
        {
                System.DateTime val_18 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  0);
            decimal val_19 = System.Decimal.op_Implicit(value:  0);
            val_10 = 0;
            val_11 = 0;
            null.Add(item:  new System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal>() {Value = new System.Decimal() {flags = 19642768, hi = 268435461, lo = 19625856, mid = 268435461}});
        }
        
        }
        
        val_26 = 1;
        label_24:
        if(val_26 < val_12._value._obj.Count)
        {
            goto label_39;
        }
        
        PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(丌业丗丛丄与与丄业:  null);
        goto label_43;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_23 = 1152921505065418752;
        FriendsController.丘世且丞丂一丒丙丕(丙业与丙丗丝不丈东:  true);
        if(FriendsController.与丆丂丏丝上三丗世 == null)
        {
                return;
        }
        
        FriendsController.与丆丂丏丝上三丗世.Invoke();
    }
    internal string 丟专丁万东丂丞且丆()
    {
        int val_31;
        string val_32;
        var val_33;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_3 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  9.ToString());
        if((System.String.op_Equality(a:  val_3, b:  "cape_Custom")) == false)
        {
            goto label_6;
        }
        
        string val_6 = Progress.七七世万专丕丁上业.丒丕丒下丂与丅丗丆().丛丝丕丄七丄七万不();
        val_31 = val_6;
        if((System.String.IsNullOrEmpty(value:  val_6)) == false)
        {
            goto label_13;
        }
        
        val_31 = SkinsController.StringFromTexture(三与丕丘丌丈一丆七:  UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "cape_CustomTexture"));
        goto label_13;
        label_6:
        val_31 = System.String.alignConst;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_32 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  7.ToString());
        System.Collections.Generic.Dictionary<System.String, System.String> val_22 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_22 != null)
        {
                val_22.Add(key:  "type", value:  "0");
        }
        else
        {
                val_22.Add(key:  "type", value:  "0");
        }
        
        val_22.Add(key:  "name", value:  val_3);
        val_22.Add(key:  "skin", value:  val_31);
        System.Collections.Generic.Dictionary<System.String, System.String> val_23 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_23 != null)
        {
                val_23.Add(key:  "type", value:  "1");
        }
        else
        {
                val_23.Add(key:  "type", value:  "1");
        }
        
        val_23.Add(key:  "name", value:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  6.ToString()));
        val_23.Add(key:  "skin", value:  System.String.alignConst);
        System.Collections.Generic.Dictionary<System.String, System.String> val_24 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_24 != null)
        {
                val_24.Add(key:  "type", value:  "2");
        }
        else
        {
                val_24.Add(key:  "type", value:  "2");
        }
        
        val_24.Add(key:  "name", value:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  10.ToString()));
        val_24.Add(key:  "skin", value:  System.String.alignConst);
        System.Collections.Generic.Dictionary<System.String, System.String> val_25 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_25.Add(key:  "type", value:  "3");
        PGCompany.丙丕丑丑丆丂丗丗丟 val_26 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_32);
        if(val_26 != null)
        {
                val_32 = val_26.业上丙丞丐丄丆丅七();
        }
        
        val_25.Add(key:  "name", value:  val_32);
        val_25.Add(key:  "skin", value:  System.String.alignConst);
        System.Collections.Generic.Dictionary<System.String, System.String> val_28 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_28 != null)
        {
                val_28.Add(key:  "type", value:  "4");
        }
        else
        {
                val_28.Add(key:  "type", value:  "4");
        }
        
        val_28.Add(key:  "name", value:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  12.ToString()));
        val_28.Add(key:  "skin", value:  System.String.alignConst);
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.String>> val_29 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.String>>();
        if(val_29 != null)
        {
                val_33 = 1152921525654215184;
            val_29.Add(item:  val_22);
            val_29.Add(item:  val_23);
            val_29.Add(item:  val_24);
            val_29.Add(item:  val_25);
        }
        else
        {
                val_33 = 1152921525654215184;
            val_29.Add(item:  val_22);
            val_29.Add(item:  val_23);
            val_29.Add(item:  val_24);
            val_29.Add(item:  val_25);
        }
        
        val_29.Add(item:  val_28);
        return (string)Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_29);
    }
    public void SendAccessories()
    {
        string val_10;
        var val_11;
        string val_3 = 0;
        val_10 = this.丟专丁万东丂丞且丆();
        bool val_4 = this.下丒上丝丁业不且丘.TryGetValue(key:  专丈专业丆且且业下.丈不丄丛丛丘东丁丙(), value: out  val_3);
        if((System.String.op_Equality(a:  val_3, b:  val_10)) == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_6.Add(key:  "accessories", value:  val_10);
        val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_11 = null;
        val_11 = null;
        int val_9 = val_10.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丏世一丄丙专丐丌丅, 一丐丗丁丞丆丅丟丄:  val_6, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsController::丒丌丑丗业丁三丑丙(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 丒丌丑丗业丁三丑丙(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        int val_6;
        System.Collections.Generic.Dictionary<System.Int32, System.String> val_7;
        val_6 = 丑与丂丌世丕丆一丗;
        val_7 = this;
        object val_2 = 0;
        if((val_6.ContainsKey(key:  "err_code")) == true)
        {
                return;
        }
        
        if((东丞丒丙世丏三下丟.TryGetValue(key:  "accessories", value: out  val_2)) == false)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        if(1179403647 != null)
        {
                return;
        }
        
        val_7 = this.下丒上丝丁业不且丘;
        val_6 = 专丈专业丆且且业下.丈不丄丛丛丘东丁丙();
        val_7.set_Item(key:  val_6, value:  (1179403647 == null) ? (val_2) : 0);
    }
    public System.Collections.IEnumerator MyWaitForSeconds(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new FriendsController.丏丒且三一一专世东();
    }
    internal void 三丟东丗丑丒丞东下()
    {
        null = null;
        if(FriendsController.且与丟丗且与业丈丗 == null)
        {
                return;
        }
        
        FriendsController.且与丟丗且与业丈丗.Invoke();
    }
    internal void 下下三丐专下一三丈()
    {
        null = null;
        if(FriendsController.下与世万丏丏丅一丏 == null)
        {
                return;
        }
        
        FriendsController.下与世万丏丏丅一丏.Invoke();
    }
    public System.Collections.Generic.List<string> get_SearchPlayersByStringResult()
    {
        return (System.Collections.Generic.List<System.String>)this.<专丈丌丟不东丂三丅>k__BackingField;
    }
    public void SearchPlayersByString(string 丂丐丄丁丆与丈丂上, System.Action 七丒上且丝业业下七, System.Action 七丛丟丕丐丆丆丝七)
    {
        object val_7;
        System.Collections.Generic.List<System.String> val_8;
        var val_9;
        val_7 = this;
        val_8 = this.<专丈丌丟不东丂三丅>k__BackingField;
        val_8.Clear();
        bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丐丄丁丆与丈丂上);
        if(val_1 == true)
        {
                return;
        }
        
        val_1.三丟东丗丑丒丞东下();
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = null;
        val_8 = val_2;
        val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_2.Add(key:  "param", value:  丂丐丄丁丆与丈丂上);
        val_9 = null;
        val_9 = null;
        int val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丘上东丝丕丕七丈丑, 一丐丗丁丞丆丅丟丄:  val_2, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsController::丌东三与丄丄丐不丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        if(val_5 != 1)
        {
                val_7 = this.丗丄丆丒万且丐业东;
            MoonSharp.Interpreter.TablePair val_6 = new MoonSharp.Interpreter.TablePair(key:  七丒上且丝业业下七, val:  七丛丟丕丐丆丆丝七);
            val_7.set_Item(key:  val_5, value:  new System.ValueTuple<System.Action, System.Action>() {Item2 = val_6.key});
            return;
        }
        
        val_5.下下三丐专下一三丈();
        if(七丛丟丕丐丆丆丝七 == null)
        {
                return;
        }
        
        七丛丟丕丐丆丆丝七.Invoke();
    }
    private void 丆与丂且丐与丝且丅()
    {
        var val_3;
        System.Action<System.Collections.Generic.KeyValuePair<System.Int32, System.ValueTuple<System.Action, System.Action>>> val_5;
        var val_6;
        bool val_1 = System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.Int32, System.ValueTuple<System.Action, System.Action>>>(source:  this.丗丄丆丒万且丐业东);
        if(val_1 != false)
        {
                val_1.下下三丐专下一三丈();
            val_3 = null;
            val_3 = null;
            val_5 = FriendsController.<>c.<>9__167_0;
            if(val_5 == null)
        {
                System.Action<System.Collections.Generic.KeyValuePair<System.Int32, System.ValueTuple<System.Action, System.Action>>> val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action<System.Collections.Generic.KeyValuePair<System.Int32, System.ValueTuple<System.Action, System.Action>>>(object:  FriendsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FriendsController.<>c::丗丒且业丁不万上丆(System.Collections.Generic.KeyValuePair<int, System.ValueTuple<System.Action, System.Action>> 三丟东丕丄丄下下丑));
            FriendsController.<>c.<>9__167_0 = val_5;
        }
        
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.Int32, System.ValueTuple<System.Action, System.Action>>>(丌丛丏业世丄丞三丌:  this.丗丄丆丒万且丐业东, 七丐丅专且专七三丆:  val_2);
            this.丗丄丆丒万且丐业东.Clear();
        }
        
        val_6 = null;
        val_6 = null;
        ReviewController.丂丄七专三世丙丌业 = false;
    }
    private void 丌东三与丄丄丐不丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_11;
        System.Collections.Generic.List<T> val_25;
        var val_26;
        System.Collections.Generic.List<System.Object> val_6 = 0;
        string val_14 = 0;
        this.下下三丐专下一三丈();
        bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "req_id", 丙业与丙丗丝不丈东: out  0);
        bool val_3 = this.丗丄丆丒万且丐业东.TryGetValue(key:  0, value: out  new System.ValueTuple<System.Action, System.Action>());
        bool val_4 = this.丗丄丆丒万且丐业东.Remove(key:  0);
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) == false)
        {
            goto label_6;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        label_44:
        0.Invoke();
        return;
        label_6:
        bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "players", 丙业与丙丗丝不丈东: out  val_6);
        val_25 = val_6;
        if(val_25 == 0)
        {
                System.Collections.Generic.List<System.Object> val_8 = null;
            val_25 = val_8;
            val_8 = new System.Collections.Generic.List<System.Object>();
        }
        
        List.Enumerator<T> val_9 = val_8.GetEnumerator();
        label_29:
        if((21337840 & 1) == 0)
        {
            goto label_12;
        }
        
        string val_12 = val_11.丐丏七丌丕丗业且上();
        val_26 = 0;
        bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_14);
        this.<专丈丌丟不东丂三丅>k__BackingField.Add(item:  val_14);
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_14)) == false)
        {
            goto label_21;
        }
        
        丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().Item[val_14].set_Item(key:  "player", value:  null);
        goto label_29;
        label_21:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_22 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        null.Add(key:  "player", value:  null);
        丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().set_Item(key:  val_14, value:  null);
        goto label_29;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(0 != 0)
        {
            goto label_44;
        }
    
    }
    private void Update()
    {
        var val_7;
        var val_8;
        bool val_9;
        if(((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 1) && (丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false))
        {
                val_7 = null;
            val_7 = null;
            if(PhotonHandler.丁丏一丟丕万丕三丄 != 0)
        {
                val_8 = null;
            val_8 = null;
            UnityEngine.Object.Destroy(obj:  PhotonHandler.丁丏一丟丕万丕三丄.gameObject);
        }
        
        }
        
        float val_6 = UnityEngine.Time.realtimeSinceStartup;
        if(UnityEngine.Input.touchCount >= 1)
        {
                val_6 = val_6 - this.丁专上且东专上丟丑;
            if(val_6 <= 30f)
        {
                return;
        }
        
            val_9 = 1;
        }
        else
        {
                val_9 = false;
            this.丁专上且东专上丟丑 = val_6;
        }
        
        this.idle = val_9;
    }
    internal static void 业上丑东丘丑丐且专()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = FriendsController.且东丞丒丑上专丞丏;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = FriendsController.且东丞丒丑上专丞丏;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal bool 东丈丒丏丒丈专专丑()
    {
        return (bool)this.<不丁丘且专丑丐业丈>k__BackingField;
    }
    internal void 且丟丕丛丕丄丁与三(bool 丙业与丙丗丝不丈东)
    {
        this.<不丁丘且专丑丐业丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void GetFriendsData(bool 一丌丐万丐丒丁丏丙 = False)
    {
        if(一丌丐万丐丒丁丏丙 == false)
        {
                return;
        }
        
        this.<不丁丘且专丑丐业丈>k__BackingField = true;
    }
    public void UpdateRecordByFriendsJoinClick(string 丑三丅丒丕丗三丏丁)
    {
        if((this.clicksJoinByFriends.ContainsKey(key:  丑三丅丒丕丗三丏丁)) != false)
        {
                System.DateTime val_2 = System.DateTime.UtcNow;
            this.clicksJoinByFriends.set_Item(key:  丑三丅丒丕丗三丏丁, value:  val_2.dateData);
            return;
        }
        
        System.DateTime val_3 = System.DateTime.UtcNow;
        this.clicksJoinByFriends.Add(key:  丑三丅丒丕丗三丏丁, value:  val_3.dateData);
    }
    public System.DateTime GetDateLastClickJoinFriend(string 丑三丅丒丕丗三丏丁)
    {
        string val_4;
        var val_5;
        var val_6;
        val_4 = 丑三丅丒丕丗三丏丁;
        if((this.clicksJoinByFriends.ContainsKey(key:  val_4)) != false)
        {
                val_4 = this.clicksJoinByFriends.Item[val_4];
            if((System.DateTime.TryParse(s:  val_4, result: out  new System.DateTime())) == false)
        {
                return (System.DateTime)val_5;
        }
        
            val_6 = null;
        }
        else
        {
                val_6 = null;
        }
        
        val_5 = 1152921504618618904;
        return (System.DateTime)val_5;
    }
    private void 丁与丙且丝丒丙丘丞()
    {
        this.clicksJoinByFriends.Clear();
        UnityEngine.PlayerPrefs.SetString(key:  "CachedFriendsJoinClickList", value:  System.String.alignConst);
    }
    private void 专世丑丅丏一丂丄与()
    {
        int val_3;
        if(this.clicksJoinByFriends.Count == 0)
        {
                return;
        }
        
        val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.clicksJoinByFriends);
        if(val_3 == null)
        {
                val_3 = System.String.alignConst;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "CachedFriendsJoinClickList", value:  val_3);
    }
    private void 不下丑丒丗万东丛不()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  "CachedFriendsJoinClickList", defaultValue:  System.String.alignConst);
        string val_8 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) == true)
        {
                return;
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_8);
        if(val_3 == null)
        {
                return;
        }
        
        val_8 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        Dictionary.Enumerator<TKey, TValue> val_4 = val_8.GetEnumerator();
        label_10:
        if((22642312 & 1) == 0)
        {
            goto label_6;
        }
        
        ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
        this.clicksJoinByFriends.Add(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToString(value:  val_5._value._obj));
        goto label_10;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞丐丞专东丄与专丏()
    {
        var val_9;
        System.Collections.Generic.Dictionary<System.String, System.String> val_21;
        System.Collections.Generic.Dictionary<System.String, System.String> val_22;
        var val_23;
        if(this.clicksJoinByFriends.Count == 0)
        {
                return;
        }
        
        if(丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count == 0)
        {
            goto label_7;
        }
        
        System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
        val_21 = this.clicksJoinByFriends;
        Dictionary.Enumerator<TKey, TValue> val_6 = val_21.GetEnumerator();
        val_22 = 1152921516597555328;
        val_23 = 1152921516597557376;
        label_14:
        if((22819840 & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_9.GetAwaiter();
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三().ContainsKey(key:  val_10._value._obj.丐丏七丌丕丗业且上())) == true)
        {
            goto label_14;
        }
        
        val_5.Add(item:  val_10._value._obj.丐丏七丌丕丗业且上());
        goto label_14;
        label_7:
        this.丁与丙且丝丒丙丘丞();
        return;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_5.Count == 0)
        {
                return;
        }
        
        val_23 = 1152921516223708000;
        val_21 = 0;
        goto label_28;
        label_32:
        val_22 = this.clicksJoinByFriends;
        bool val_18 = val_22.Remove(key:  val_5.Item[0]);
        val_21 = 1;
        label_28:
        if(val_21 < val_5.Count)
        {
            goto label_32;
        }
        
        this.专世丑丅丏一丂丄与();
    }
    internal static FriendsController.丆一丒上专万专下丞 丞丒东七丝且上不下(System.Collections.Generic.Dictionary<string, string> 丄且丆丘丆丏丄且东)
    {
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        val_11 = System.String.alignConst;
        if((丄且丆丘丆丏丄且东.ContainsKey(key:  "map")) != false)
        {
                val_11 = 丄且丆丘丆丏丄且东.Item["map"];
        }
        
        val_12 = System.String.alignConst;
        if((丄且丆丘丆丏丄且东.ContainsKey(key:  "eventMap")) != false)
        {
                val_12 = 丄且丆丘丆丏丄且东.Item["eventMap"];
        }
        
        val_13 = System.String.alignConst;
        if((丄且丆丘丆丏丄且东.ContainsKey(key:  "room_name")) != false)
        {
                val_13 = 丄且丆丘丆丏丄且东.Item["room_name"];
        }
        
        val_14 = System.String.alignConst;
        if((丄且丆丘丆丏丄且东.ContainsKey(key:  "rank")) == false)
        {
                return FriendsController.丞丒东七丝且上不下(七丏丐业上不丐丈丐:  丄且丆丘丆丏丄且东.Item["game_mode"], 丈丘丙丒世丑丆丘七:  丄且丆丘丆丏丄且东.Item["protocol"], 丛且丞与丕业下丏丞:  val_11, 专丗丑丐上下与丕丛:  val_13, 丄专不丅一下丕七丒:  val_12, 丕丆且三丐丗东丕业:  val_14 = 丄且丆丘丆丏丄且东.Item["rank"]);
        }
        
        return FriendsController.丞丒东七丝且上不下(七丏丐业上不丐丈丐:  丄且丆丘丆丏丄且东.Item["game_mode"], 丈丘丙丒世丑丆丘七:  丄且丆丘丆丏丄且东.Item["protocol"], 丛且丞与丕业下丏丞:  val_11, 专丗丑丐上下与丕丛:  val_13, 丄专不丅一下丕七丒:  val_12, 丕丆且三丐丗东丕业:  val_14);
    }
    internal static FriendsController.丁一丑丐丗下丄丟丐 丈丘万七丝东丏三丙(System.Collections.Generic.Dictionary<string, string> 丄且丆丘丆丏丄且东)
    {
        int val_5;
        int val_6;
        val_5 = System.String.alignConst;
        if((丄且丆丘丆丏丄且东.ContainsKey(key:  "game_mode")) != false)
        {
                val_5 = 丄且丆丘丆丏丄且东.Item["game_mode"];
        }
        
        val_6 = System.String.alignConst;
        if((丄且丆丘丆丏丄且东.ContainsKey(key:  "map")) == false)
        {
                return FriendsController.丈丘万七丝东丏三丙(七丏丐业上不丐丈丐:  val_5, 丛且丞与丕业下丏丞:  val_6 = 丄且丆丘丆丏丄且东.Item["map"]);
        }
        
        return FriendsController.丈丘万七丝东丏三丙(七丏丐业上不丐丈丐:  val_5, 丛且丞与丕业下丏丞:  val_6);
    }
    private static FriendsController.丁一丑丐丗下丄丟丐 丈丘万七丝东丏三丙(string 七丏丐业上不丐丈丐, string 丛且丞与丕业下丏丞)
    {
        FriendsController.丁一丑丐丗下丄丟丐 val_1 = new FriendsController.丁一丑丐丗下丄丟丐();
        if(val_1 != null)
        {
                .下丁上丟业一三丒东 = 七丏丐业上不丐丈丐;
        }
        else
        {
                mem[24] = 七丏丐业上不丐丈丐;
        }
        
        .丛且丞与丕业下丏丞 = 丛且丞与丕业下丏丞;
        return (丁一丑丐丗下丄丟丐)val_1;
    }
    private static FriendsController.丆一丒上专万专下丞 丞丒东七丝且上不下(string 七丏丐业上不丐丈丐, string 丈丘丙丒世丑丆丘七, string 丛且丞与丕业下丏丞, string 专丗丑丐上下与丕丛, string 丄专不丅一下丕七丒, string 丕丆且三丐丗东丕业)
    {
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_54;
        var val_55;
        Rilisoft.七丕丟丏三丈一丄世 val_56;
        var val_57;
        var val_58;
        var val_59;
        .丛且丞与丕业下丏丞 = 丛且丞与丕业下丏丞;
        int val_2 = System.Int32.Parse(s:  七丏丐业上不丐丈丐);
        val_48 = 0;
        if(val_2 >= 10000)
        {
                int val_3 = val_2 + 4294867296;
            val_3 = val_3 >> 44;
            val_48 = val_3 + (val_3 >> 63);
        }
        
        int val_5 = 0;
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  七丏丐业上不丐丈丐, 丙业与丙丗丝不丈东: out  val_5)) == false)
        {
            goto label_5;
        }
        
        if(val_5 < 10000)
        {
            goto label_7;
        }
        
        goto label_7;
        label_5:
        label_7:
        bool val_8 = System.Int32.TryParse(s:  丕丆且三丐丗东丕业, result: out  0);
        FriendsController.丆一丒上专万专下丞 val_9 = new FriendsController.丆一丒上专万专下丞();
        .丟上丅丛一丅丄不丙 = 专丗丑丐上下与丕丛;
        if(val_48 != 1)
        {
                val_49 = null;
            val_49 = null;
            var val_10 = (val_48 != GameConnect.丅丕专丗东东丏专世) ? 1 : 0;
        }
        else
        {
                val_50 = 1;
        }
        
        int val_11 = System.Convert.ToInt32(value:  七丏丐业上不丐丈丐);
        val_9.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  七丏丐业上不丐丈丐);
        .丛且丞与丕业下丏丞 = (FriendsController.丆一专丕丌且东丒世)[1152921526105253776].丛且丞与丕业下丏丞;
        val_51 = null;
        val_51 = null;
        SceneInfo val_14 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  (FriendsController.丆一专丕丌且东丒世)[1152921526105253776].丛且丞与丕业下丏丞));
        if(0 != 31)
        {
            goto label_21;
        }
        
        if(val_14 == 0)
        {
            goto label_24;
        }
        
        var val_18 = ((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().业丛东丕丘丁丗万世(丂丛丑东不丅丈一东:  31, 丛且丞与丕业下丏丞:  val_14.indexMap)) > 0) ? 1 : 0;
        goto label_27;
        label_21:
        var val_21 = (1 < (ExperienceController.丞丞丘业东丙丏七丌() - 5)) ? 1 : 0;
        goto label_30;
        label_24:
        val_52 = 0;
        label_27:
        label_30:
        if(val_14 != 0)
        {
                val_54 = val_14.七丗与三丝丑丈一专(世专丝一丙业丅丌上:  9);
        }
        else
        {
                val_54 = 0;
        }
        
        val_55 = null;
        val_55 = null;
        val_56 = val_9.丝丅丛不丂专一丞与();
        if(((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_56)) != null) && (val_26.avaliableScenes != null))
        {
                System.Predicate<SceneInfo> val_27 = null;
            val_56 = val_27;
            val_27 = new System.Predicate<SceneInfo>(object:  new FriendsController.丆一专丕丌且东丒世(), method:  System.Boolean FriendsController.丆一专丕丌且东丒世::下丏专东三七东丕丅(SceneInfo 三丟东丕丄丄下下丑));
            val_57 = val_26.avaliableScenes.Exists(match:  val_27);
        }
        else
        {
                val_57 = 1;
        }
        
        int val_29 = 0;
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  丄专不丅一下丕七丒, 丙业与丙丗丝不丈东: out  val_29)) == false)
        {
            goto label_44;
        }
        
        val_56 = val_29;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_32 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丘一一丛丏丕下丟丛(丞丅上丏丂且下丅与:  0);
        if((((val_32 == null) || ((val_57 ^ 1 & 1) != 0)) || (val_32.丐万且七专丒七丛丞() == false)) || (val_32.七丂丌丈丄专丄三世() == false))
        {
            goto label_50;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_36 = val_32.丌不丅不丞东万专专();
        if((23501624 & 1) == 0)
        {
            goto label_50;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_37 = val_32.丌不丅不丞东万专专();
        val_56 = 1152921526105172176;
        if(23501624 != 2)
        {
            goto label_51;
        }
        
        label_50:
        .世丏且丂丗丕三丞上 = false;
        val_59 = 4;
        goto label_61;
        label_51:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_38 = val_32.丌不丅不丞东万专专();
        val_58 = public PGCompany.GameModeEvents.丏丏丙丂下丈七上丈 System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>::get_Value();
        var val_39 = (23501624 != 4) ? 1 : 0;
        label_44:
        .世丏且丂丗丕三丞上 = val_39 & 1;
        val_59 = 4;
        if(((val_11 == 100006) || (0 == 17)) || ((val_39 & 1) == 0))
        {
            goto label_61;
        }
        
        var val_42 = ((val_50 & ((val_48 != 3) ? 1 : 0)) != 0) ? 1 : 0;
        val_42 = val_42 | val_54;
        if((val_42 & 1) == 0)
        {
            goto label_56;
        }
        
        var val_43 = (val_48 == 3) ? 1 : 0;
        val_43 = val_43 | (~((val_52 != 0) ? 1 : 0));
        val_43 = val_54 | val_43;
        if((val_43 & 1) == 0)
        {
            goto label_57;
        }
        
        if((System.String.op_Inequality(a:  丟丌丁且且世丈丈丟.不丛丁且丘丑上丕七(丂丛丑东不丅丈一东:  0), b:  丈丘丙丒世丑丆丘七)) == false)
        {
            goto label_58;
        }
        
        val_59 = 3;
        goto label_61;
        label_56:
        val_59 = 1;
        goto label_61;
        label_57:
        val_59 = 0;
        goto label_61;
        label_58:
        label_61:
        .丘丑丛下丘丗丙丞七 = (val_14 != 0) ? 2 : 5;
        .丑业不丅丄七丞万丅 = (val_11 == 100006) ? 1 : 0;
        return (丆一丒上专万专下丞)val_9;
    }
    private static void 丕七丒与丟丗上一不()
    {
        .专丂丕丗丗东世丞下 = System.String.alignConst;
        .丑丂东丆丆不丞专丌 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1565");
        .与与丁世丐东丒丑万 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1508"), arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        UnityEngine.Application.OpenURL(url:  new Rilisoft.不丛世下丄且一丒东().东丌丆丄丙丂不与专());
    }
    internal static void 三丙丏不丐丗一丕丌()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = FriendsController.<>c.<>9__191_0;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  FriendsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FriendsController.<>c::丒七丏丏专丑丘一丟());
            FriendsController.<>c.<>9__191_0 = val_4;
        }
        
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  val_1, 丆丒丅丁不且丛一业:  0);
    }
    internal static void 丅七丈丁丗丁与丐七()
    {
        FriendsController.三丆丄下丆丌丈东丒(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    internal static void 三丆丄下丆丌丈东丒(string 丄丒且丙三丆丟与丏)
    {
        丗丏丑世丌丝丝上下.丒下一丟丝丕丈不一(丕丗丘丑丛与丑业丒:  丄丒且丙三丆丟与丏);
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1618"));
    }
    internal static void 万与东丅七丁且丂下(string 丑三丅丒丕丗三丏丁)
    {
        var val_19;
        int val_20;
        var val_21;
        var val_22;
        val_19 = null;
        val_19 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().ContainsKey(key:  丑三丅丒丕丗三丏丁)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_7 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().Item[丑三丅丒丕丗三丏丁];
        bool val_10 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_7.Item["game_mode"], 丙业与丙丗丝不丈东: out  0);
        string val_12 = val_7.Item["map"];
        if((val_7.ContainsKey(key:  "eventMap")) != false)
        {
                val_20 = val_7.Item["eventMap"];
        }
        else
        {
                val_20 = System.String.alignConst;
        }
        
        val_21 = null;
        val_21 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  val_12))) == 0)
        {
                return;
        }
        
        if(JoinToFriendRoomController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        JoinToFriendRoomController.丆丕丝丒不丙且丐丗.一业丁丁丌万丄七专(丌丝不东上丅东丏丒:  0, 丁丛东丝丗丐丐万且:  val_7.Item["room_name"], 丞丁丑丏丄丏七丂不:  val_12, 丌业三世且丛丘丌丟:  val_20);
        val_22 = null;
        val_22 = null;
        FriendsController.丄丞丁丈与业上丞丟.UpdateRecordByFriendsJoinClick(丑三丅丒丕丗三丏丁:  丑三丅丒丕丗三丏丁);
    }
    internal static bool 专丁丟丛丆万丟万丆(string 丄丒且丙三丆丟与丏)
    {
        System.Collections.Generic.List<System.String> val_2 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上();
        if(val_2 != null)
        {
                return val_2.Contains(item:  丄丒且丙三丆丟与丏);
        }
        
        return val_2.Contains(item:  丄丒且丙三丆丟与丏);
    }
    internal static bool 丁丘万不丌丏丗丗且()
    {
        var val_5 = null;
        return (bool)(丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count >= 与丂丏丛丞丞丒丟丄.下丑丑万丛丆丏业世) ? 1 : 0;
    }
    internal static bool 上丄七丙东三上业丕()
    {
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 != 0)
        {
                if(丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count >= 1)
        {
                var val_8 = (丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().Count > 0) ? 1 : 0;
            return (bool)val_10;
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    internal static bool 丈世丝丐丝丂丙丌丘()
    {
        var val_5;
        var val_20;
        var val_21;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_20 = null;
        val_20 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = 下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.GetEnumerator();
        label_10:
        if((24879552 & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if(((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_6._value._obj.丐丏七丌丕丗业且上())) == false) || (24879536 != 1))
        {
            goto label_10;
        }
        
        val_1.Add(item:  val_6._value._obj.丐丏七丌丕丗业且上());
        goto label_10;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count < 1)
        {
                return (bool)(val_1.Count > 0) ? 1 : 0;
        }
        
        if(丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().Count <= 0)
        {
                return (bool)(val_1.Count > 0) ? 1 : 0;
        }
        
        val_21 = 1;
        return (bool)(val_1.Count > 0) ? 1 : 0;
    }
    internal static bool 丈与且丄一丗东丅丒()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if(下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.Count >= 1)
        {
                var val_5 = (丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().Count > 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    internal static bool 丄丌万世东丕丈丆万()
    {
        var val_10;
        if(且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万().Count >= 1)
        {
                if(丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().Count > 0)
        {
                val_10 = 1;
            return (bool)(val_7.业丈丞丐万丄不上丄.Count > 0) ? 1 : 0;
        }
        
        }
        
        丄上三丛丛上一业三 val_7 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        return (bool)(val_7.业丈丞丐万丄不上丄.Count > 0) ? 1 : 0;
    }
    internal static void 丗七万丝七下丅丞丏(string 丞丅上丏丂且下丅与, Rilisoft.万丑丆且世与丁下且 丁丅丈丌丟世丗丗丟, System.Action<bool> 丅丗专丕丑上丝下丕)
    {
        var val_2 = null;
        if(FriendsController.丌丆七业丂丌丟丑丆 == null)
        {
                Rilisoft.丄丑丟丟业业丂丛不 val_1 = new Rilisoft.丄丑丟丟业业丂丛不(丅丗专丕丑上丝下丕:  丅丗专丕丑上丝下丕);
            val_2 = null;
            val_2 = null;
            FriendsController.丌丆七业丂丌丟丑丆 = val_1;
        }
        
        val_2 = null;
        val_1.不丑丝且丘丑不专丟(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丅丗专丕丑上丝下丕:  丅丗专丕丑上丝下丕);
    }
    public bool get_ProfileInterfaceActive()
    {
        var val_3;
        Rilisoft.丄丑丟丟业业丂丛不 val_4;
        var val_5;
        System.Func<UnityEngine.GameObject, System.Boolean> val_7;
        val_3 = null;
        val_3 = null;
        val_4 = FriendsController.丌丆七业丂丌丟丑丆;
        if(val_4 == null)
        {
                return false;
        }
        
        val_4 = FriendsController.丌丆七业丂丌丟丑丆;
        if(val_4 == null)
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
        val_7 = FriendsController.<>c.<>9__204_0;
        if(val_7 != null)
        {
                return Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<UnityEngine.GameObject, System.Boolean>(丄三丅七丆丛与与上:  val_4.一丟与三丒且东上丏(), 东丑丈丅丌万东丅且:  System.Func<UnityEngine.GameObject, System.Boolean> val_2 = null);
        }
        
        val_7 = val_2;
        val_2 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  FriendsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FriendsController.<>c::丁丝三世丟上丘一丝(UnityEngine.GameObject 业七丐世专丝丂丟丈));
        FriendsController.<>c.<>9__204_0 = val_7;
        return Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<UnityEngine.GameObject, System.Boolean>(丄三丅七丆丛与与上:  val_4.一丟与三丒且东上丏(), 东丑丈丅丌万东丅且:  val_2);
    }
    internal static void 丌业丗丈业丑一丙与()
    {
        var val_1;
        Rilisoft.丄丑丟丟业业丂丛不 val_2;
        val_1 = null;
        val_1 = null;
        val_2 = FriendsController.丌丆七业丂丌丟丑丆;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = FriendsController.丌丆七业丂丌丟丑丆;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Dispose();
        FriendsController.丌丆七业丂丌丟丑丆 = 0;
    }
    internal static bool 与丞不且专七丛丁丛(string 丄丒且丙三丆丟与丏)
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return false;
        }
        
        if((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                return false;
        }
        
        string val_4 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(val_4 != null)
        {
                return val_4.Equals(value:  丄丒且丙三丆丟与丏);
        }
        
        return val_4.Equals(value:  丄丒且丙三丆丟与丏);
    }
    internal static 三丁丏一丄下三东一 东丁丘下丛丑上丝且(string 丄丒且丙三丆丟与丏)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return 0;
        }
        
        val_4 = null;
        val_4 = null;
        if((下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.ContainsKey(key:  丄丒且丙三丆丟与丏)) == false)
        {
                return 0;
        }
        
        val_5 = null;
        val_5 = null;
        if(下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆 != null)
        {
                return 下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.Item[丄丒且丙三丆丟与丏];
        }
        
        return 下丐丒丂丏一丝东丏.三丞丂丂丕丏世丄丆.Item[丄丒且丙三丆丟与丏];
    }
    internal void 丌丛下丂丂丒丁三丘()
    {
        if(this.丕上丝丟下丏专丛丟 != null)
        {
                this.StopCoroutine(routine:  this.丕上丝丟下丏专丛丟);
            this.丕上丝丟下丏专丛丟 = 0;
        }
        
        this.丕上丝丟下丏专丛丟 = this.StartCoroutine(routine:  this.专丒丗丝丛且丗丌丈());
    }
    private System.Collections.IEnumerator 专丒丗丝丛且丗丌丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FriendsController.与一丗业丆东丌丆丂();
    }
    public void SendReviewForPlayerWithID(int 丈丐世下丞与丂专丏, string 丄丝丁专丄丑丟三丆)
    {
        int val_9;
        var val_10;
        var val_12;
        var val_13;
        var val_14;
        val_9 = 丈丐世下丞与丂专丏;
        val_10 = null;
        val_10 = null;
        if(ReviewController.丂丄七专三世丙丌业 == true)
        {
                return;
        }
        
        ReviewController.丂丄七专三世丙丌业 = true;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != true)
        {
                System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_3.Add(key:  "text", value:  丄丝丁专丄丑丟三丆);
            val_3.Add(key:  "rating", value:  val_9);
            val_3.Add(key:  "device_model", value:  UnityEngine.SystemInfo.deviceModel);
            val_3.Add(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑());
            val_12 = null;
            val_12 = null;
            val_3.Add(key:  "version", value:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
            val_9 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
            val_13 = null;
            val_13 = null;
            if((val_9.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丑与与丑世与丄且业, 一丐丗丁丞丆丅丟丄:  val_3, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsController::丗丅丛一世丄丅业丈(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)))) != 1)
        {
                return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        ReviewController.丂丄七专三世丙丌业 = false;
    }
    private void 丗丅丛一世丄丅业丈(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        null = null;
        ReviewController.丂丄七专三世丙丌业 = false;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                return;
        }
        
        ReviewController.丗丆丟丑丟三丁丘上(丙业与丙丗丝不丈东:  false);
    }
    public bool HaveSquadInviteFromPlayer(string 丞丅上丏丂且下丅与)
    {
        if((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_4 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((val_4.业丈丞丐万丄不上丄.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return false;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_8 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().Item[丞丅上丏丂且下丅与];
        if(val_8 == null)
        {
                return false;
        }
        
        丆一丒上专万专下丞 val_9 = FriendsController.丞丒东七丝且上不下(丄且丆丘丆丏丄且东:  val_8);
        if(val_9 == null)
        {
                return false;
        }
        
        if(val_9.丝丅丛不丂专一丞与() != 15)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_11 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((val_11.业丈丞丐万丄不上丄.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_13 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        return System.String.op_Equality(a:  val_9.丟上丅丛一丅丄不丙, b:  val_13.业丈丞丐万丄不上丄.Item[丞丅上丏丂且下丅与]);
    }
    public bool HaveClanSiegeInviteFromPlayer(string 丞丅上丏丂且下丅与)
    {
        if((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_4 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((val_4.一丒丈丈专上丝丝丞.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return false;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_8 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆().Item[丞丅上丏丂且下丅与];
        if(val_8 == null)
        {
                return false;
        }
        
        丆一丒上专万专下丞 val_9 = FriendsController.丞丒东七丝且上不下(丄且丆丘丆丏丄且东:  val_8);
        if(val_9 == null)
        {
                return false;
        }
        
        if(val_9.丝丅丛不丂专一丞与() != 18)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_11 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((val_11.一丒丈丈专上丝丝丞.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_13 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        return System.String.op_Equality(a:  val_9.丟上丅丛一丅丄不丙, b:  val_13.一丒丈丈专上丝丝丞.Item[丞丅上丏丂且下丅与]);
    }
    internal static string 丏丏不丗丝丂万丆业()
    {
        string val_2;
        var val_3 = null;
        if(FriendsController.丘丐丛业一丕丞万不 != true)
        {
                val_3 = null;
            val_2 = UnityEngine.PlayerPrefs.GetString(key:  "CNAdvert", defaultValue:  "none");
            val_3 = null;
            FriendsController.业丘万不万与不丏下 = val_2;
            FriendsController.丘丐丛业一丕丞万不 = true;
        }
        
        val_3 = null;
        return (string)FriendsController.业丘万不万与不丏下;
    }
    internal static void 上丁三不丞业三不业(string 丙业与丙丗丝不丈东)
    {
        null = null;
        FriendsController.丘丐丛业一丕丞万不 = true;
        FriendsController.业丘万不万与不丏下 = 丙业与丙丗丝不丈东;
        UnityEngine.PlayerPrefs.SetString(key:  "CNAdvert", value:  FriendsController.业丘万不万与不丏下);
    }
    internal static void 丞丘丁业丙专且一世()
    {
        object val_4 = 0;
        PGCompany.丒丒丛丙不万专三丆 val_6 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_6.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  62));
        if(val_3 == null)
        {
                return;
        }
        
        val_6 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        if((val_6.TryGetValue(key:  "ConfigsGroups", value: out  val_4)) == false)
        {
                return;
        }
        
        FriendsController.丞丘丁业丙专且一世(丘丌丛七丌万一业丙:  val_4);
    }
    private static void 丞丘丁业丙专且一世(object 丘丌丛七丌万一业丙)
    {
        int val_6;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_21;
        System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> val_22;
        System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>>();
        System.Collections.Generic.List<System.Object> val_2 = new System.Collections.Generic.List<System.Object>();
        val_16 = 0;
        丘丌丛七丌万一业丙 = ( == 0) ? (val_2) : ();
        List.Enumerator<T> val_4 = 丘丌丛七丌万一业丙.GetEnumerator();
        val_17 = 0;
        val_18 = 0;
        var val_17 = 0;
        label_35:
        if((27435120 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        val_19 = 0;
        System.Collections.Generic.List<PGCompany.ConfigId> val_10 = new System.Collections.Generic.List<PGCompany.ConfigId>();
        List.Enumerator<T> val_11 = ( == 0) ? (val_2) : ().GetEnumerator();
        label_19:
        if((27435088 & 1) == 0)
        {
            goto label_10;
        }
        
        int val_13 = System.Convert.ToInt32(value:  val_6.丐丏七丌丕丗业且上());
        val_6 = val_13;
        if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_6)) == false)
        {
            goto label_19;
        }
        
        null.Add(item:  val_13);
        goto label_19;
        label_10:
        val_17 = val_17 + 1;
        mem2[0] = 134;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_17 == 1) || ((27435024 + ((0 + 1)) << 2) != 134))
        {
            goto label_28;
        }
        
        var val_18 = 0;
        val_18 = val_18 ^ (val_17 >> 31);
        val_17 = val_17 + val_18;
        val_21 = val_1;
        if(val_21 != null)
        {
            goto label_34;
        }
        
        goto label_33;
        label_28:
        val_21 = val_1;
        if( == 0)
        {
            goto label_31;
        }
        
        if(val_21 != null)
        {
            goto label_34;
        }
        
        goto label_33;
        label_31:
        if(val_21 != null)
        {
            goto label_34;
        }
        
        label_33:
        label_34:
        val_1.Add(item:  null);
        goto label_35;
        label_5:
        val_17 = val_17 + 1;
        val_22 = val_1;
        mem2[0] = 166;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_17 == 1)
        {
            goto label_41;
        }
        
        if(( == 0) || ((27435024 + ((0 + 1)) << 2) == 166))
        {
            goto label_45;
        }
        
        label_44:
        label_45:
        PGCompany.丒丒丛丙不万专三丆.丝丄丒丑上万丙且丝(丙业与丙丗丝不丈东:  val_1);
        return;
        label_41:
        if( != 0)
        {
            goto label_44;
        }
        
        goto label_45;
    }
    internal static void 丂丘七丌丂丆丒丞丝()
    {
        float val_134;
        var val_276;
        var val_297;
        var val_303;
        var val_312;
        var val_428;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_429;
        float val_430;
        System.Func<System.Object, System.String> val_431;
        object val_432;
        long val_434;
        var val_436;
        var val_437;
        var val_438;
        var val_439;
        var val_440;
        var val_441;
        var val_442;
        var val_443;
        var val_444;
        Rilisoft.WebSocket.WebSocketManager val_446;
        var val_447;
        var val_448;
        var val_449;
        var val_450;
        var val_451;
        var val_452;
        var val_453;
        var val_454;
        var val_455;
        var val_456;
        var val_457;
        var val_458;
        var val_459;
        var val_460;
        var val_461;
        var val_462;
        var val_463;
        var val_464;
        var val_465;
        System.Object[] val_466;
        var val_467;
        var val_468;
        var val_469;
        var val_470;
        var val_471;
        System.Version val_472;
        var val_473;
        var val_474;
        var val_475;
        val_428;
        val_430 = 0;
        object val_199 = 0;
        object val_379 = 0;
        object val_384 = 0;
        object val_388 = 0;
        object val_392 = 0;
        object val_419 = 0;
        object val_406 = 0;
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  62));
        if(val_3 == null)
        {
                return;
        }
        
        System.Collections.Generic.IDictionary<System.String, System.Object> val_4 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        if((val_4.ContainsKey(key:  "MsgPackTestDisabled")) != false)
        {
                var val_8 = ((System.Convert.ToInt32(value:  val_4.Item["MsgPackTestDisabled"])) > 0) ? 1 : 0;
        }
        else
        {
                val_432 = 0;
        }
        
        PGCompany.与丑丙东丁不丅三七.世七七且专丌上专丘(丙业与丙丗丝不丈东:  false);
        if((val_4.ContainsKey(key:  "Gamepad_sensativity")) != false)
        {
                val_432 = val_4.Item["Gamepad_sensativity"];
            PGCompany.GamepadCoreController.专丛丈上丛且丟丌丞 = System.Convert.ToSingle(value:  val_432);
        }
        
        if((val_4.ContainsKey(key:  "PlayerBacklight")) != false)
        {
                val_432 = System.Convert.ToBoolean(value:  val_4.Item["PlayerBacklight"]);
            CameraFacingBilloard.allowBacklighting = val_432;
        }
        
        val_434 = 1152921505594490880;
        PGCompany.GamepadCoreController.三丏丅丐丏与下世丗 = 0;
        PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东 = 0;
        PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏 = 0;
        System.Collections.Generic.IDictionary<System.String, System.Object> val_428 = val_4;
        if((val_4.ContainsKey(key:  "forwardSpeed")) != false)
        {
                val_432 = val_4.Item["forwardSpeed"];
            PGCompany.GamepadCoreController.三丏丅丐丏与下世丗 = PGCompany.GamepadCoreController.世丄且丁与丌专万丅(丏丂万业丙专丏丒丒:  null);
        }
        
        if((val_4.ContainsKey(key:  "backwardSpeed")) != false)
        {
                val_432 = val_4.Item["backwardSpeed"];
            PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东 = PGCompany.GamepadCoreController.世丄且丁与丌专万丅(丏丂万业丙专丏丒丒:  null);
        }
        
        if((val_4.ContainsKey(key:  "sidewaysSpeed")) != false)
        {
                val_432 = val_4.Item["sidewaysSpeed"];
            PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏 = PGCompany.GamepadCoreController.世丄且丁与丌专万丅(丏丂万业丙专丏丒丒:  null);
        }
        
        if((val_4.ContainsKey(key:  "AoERaycasts")) != false)
        {
                val_432 = System.Convert.ToBoolean(value:  val_4.Item["AoERaycasts"]);
            Rocket.丘丆丛且丟丆丝丞不 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "NotificationGlobalBlock")) != false)
        {
                val_432 = System.Convert.ToInt64(value:  val_4.Item["NotificationGlobalBlock"]);
            NotificationWindowController.丝丅七丗七丒下丒与 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "NotificationTypeBlock")) != false)
        {
                val_432 = System.Convert.ToInt64(value:  val_4.Item["NotificationTypeBlock"]);
            NotificationWindowController.世丞丝丆业丈一三三 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "Gamepad_Coursor_sensativity")) != false)
        {
                val_432 = val_4.Item["Gamepad_Coursor_sensativity"];
            PGCompany.GamepadCoreController.专丗丑世丅丂不丂丝 = System.Convert.ToSingle(value:  val_432);
        }
        
        if((val_4.ContainsKey(key:  "hapticStatus")) != false)
        {
                val_432 = System.Convert.ToBoolean(value:  val_4.Item["hapticStatus"]);
            FirstPersonControlSharp.丟丆丒三不且丐丕丑 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "MaxDelayDayShopVersion")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["MaxDelayDayShopVersion"]);
            VersionBlocker.丂东万下与三丄不世(丙业与丙丗丝不丈东:  val_432);
        }
        
        if((val_4.ContainsKey(key:  "MaxFriendCount")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["MaxFriendCount"]);
            与丂丏丛丞丞丒丟丄.下丑丑万丛丆丏业世 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "MaxMemberClanCount")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["MaxMemberClanCount"]);
            与丂丏丛丞丞丒丟丄.三丁丙三丆丞万丆丐 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "TimeUpdateFriendInfo")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["TimeUpdateFriendInfo"]);
            val_430 = (float)val_432;
            与丂丏丛丞丞丒丟丄.七丐丞一丕丆与三丗 = val_430;
        }
        
        if((val_4.ContainsKey(key:  "SendInfoByBlockParamsInHouse")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["SendInfoByBlockParamsInHouse"]);
            PGCompany.Analytics.InhouseAnalyticsController.丝丈七丏下丕专丐不 = (val_432 == 1) ? 1 : 0;
        }
        
        if((val_4.ContainsKey(key:  "ShowNewLabelIntervalInSeconds")) != false)
        {
                val_432 = System.Convert.ToInt64(value:  val_4.Item["ShowNewLabelIntervalInSeconds"]);
            BalanceController.下丈丞上丐丈专丁丆 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "TimeUpdateLeaderboardIfNullResponce")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["TimeUpdateLeaderboardIfNullResponce"]);
            val_430 = (float)val_432;
            与丂丏丛丞丞丒丟丄.丙丄丗专下丐丟七丞 = val_430;
        }
        
        if((val_4.ContainsKey(key:  "DuelBetsEnableV2")) != false)
        {
                val_432 = System.Convert.ToBoolean(value:  val_4.Item["DuelBetsEnableV2"]);
            与丂丏丛丞丞丒丟丄.上丆丘七丞且丄丘与 = val_432;
        }
        
        SupportAimController.丝丈世丑丄东丟丏丝 = 0f;
        if((val_4.ContainsKey(key:  "AimRotateSpeed")) != false)
        {
                val_432 = val_4.Item["AimRotateSpeed"];
            SupportAimController.丝丈世丑丄东丟丏丝 = System.Convert.ToSingle(value:  val_432);
        }
        
        SupportAimController.专丈专丁与不且丄丂 = 0f;
        if((val_4.ContainsKey(key:  "AimPlayerMult")) != false)
        {
                val_432 = val_4.Item["AimPlayerMult"];
            SupportAimController.专丈专丁与不且丄丂 = System.Convert.ToSingle(value:  val_432);
        }
        
        if((val_4.ContainsKey(key:  "DuelBetsTimer")) != false)
        {
                val_432 = val_4.Item["DuelBetsTimer"];
            DuelController.下世丗下一丆丐丝专 = System.Convert.ToSingle(value:  val_432);
        }
        
        if((val_4.ContainsKey(key:  "DuelDefaultTimer")) != false)
        {
                val_432 = val_4.Item["DuelDefaultTimer"];
            DuelController.丟上丝不丏丏万丁丘 = System.Convert.ToSingle(value:  val_432);
        }
        
        if((val_4.ContainsKey(key:  "Platform")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["Platform"]);
            GameConnect.丅丕专丗东东丏专世 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "Photon")) != false)
        {
                val_432 = FriendsController.丄丞丁丈与业上丞丟;
            if((val_432 != 0) && ((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != true))
        {
                object val_90 = val_4.Item["Photon"];
            val_432 = 0;
            if((ContainsKey(key:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                val_432 = Item[专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()];
            丅丒丗丑丒丙丛不丆.世七丌丗丛丘丐丗丕.ServerAddress = val_432;
        }
        
        }
        
        }
        
        if((val_4.ContainsKey(key:  "TimeBlockRefreshFriendDate")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["TimeBlockRefreshFriendDate"]);
            val_430 = (float)val_432;
            与丂丏丛丞丞丒丟丄.上丅且丂丈丂万丘世 = val_430;
        }
        
        if((val_4.ContainsKey(key:  "TimeToClearSiegeShowedInvites")) != false)
        {
                val_432 = val_4.Item["timeToClearSiegeShowedInvites"];
            val_430 = System.Convert.ToSingle(value:  val_432);
            BalanceController.万且业丐专与丄丂与(丙业与丙丗丝不丈东:  val_430);
        }
        
        if((val_4.ContainsKey(key:  "SocketEventTimeout")) != false)
        {
                val_432 = val_4.Item["SocketEventTimeout"];
            val_430 = System.Convert.ToSingle(value:  val_432);
            Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丌东丑丟丒丆丘丏(丙业与丙丗丝不丈东:  val_430);
        }
        
        if((val_4.ContainsKey(key:  "TimeWaitLoadPossibleFriends")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["TimeWaitLoadPossibleFriends"]);
            val_430 = (float)val_432;
            与丂丏丛丞丞丒丟丄.丛丙且万且丗丏业丞 = val_430;
        }
        
        if((val_4.ContainsKey(key:  "PauseUpdateLeaderboard")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["PauseUpdateLeaderboard"]);
            val_430 = (float)val_432;
            与丂丏丛丞丞丒丟丄.丕丏三世丑业丑丑丛 = val_430;
        }
        
        if((val_4.ContainsKey(key:  "HistoryPrivateMessageLength")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["HistoryPrivateMessageLength"]);
            与丂丏丛丞丞丒丟丄.上丞丐丁丙丂七下丌 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "TimesResendWeaponsKillrate")) != false)
        {
                val_432 = System.Convert.ToInt32(value:  val_4.Item["TimesResendWeaponsKillrate"]);
            与丂丏丛丞丞丒丟丄.世丆丞丂一不万丛丟 = val_432;
        }
        
        if((val_4.ContainsKey(key:  "OutgoingInviteTimeoutMinutes")) != false)
        {
                val_432 = Rilisoft.丈丑丟丏丏与丟丙且.丑七不且上丗丁一世();
            val_430 = (double)System.Convert.ToSingle(value:  val_4.Item["OutgoingInviteTimeoutMinutes"]);
            System.TimeSpan val_121 = System.TimeSpan.FromMinutes(value:  val_430);
            val_432.一丄丗一丕丏丛下丒(丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_121._ticks});
        }
        
        if((val_4.ContainsKey(key:  "TimerIntervalDelaysFirstsEggs")) == false)
        {
            goto label_263;
        }
        
        object val_123 = val_428.Item["TimerIntervalDelaysFirstsEggs"];
        val_432 = 0;
        val_431 = 1152921505443745792;
        Rilisoft.Nest.丆丏东丞丝一丈与上.Clear();
        goto label_271;
        label_279:
        val_434 = System.Convert.ToInt64(value:  Item[0]);
        Rilisoft.Nest.丆丏东丞丝一丈与上.Add(item:  val_434);
        label_271:
        if(1 < Count)
        {
            goto label_279;
        }
        
        label_263:
        val_436 = 1152921516630043280;
        if(((val_428.ContainsKey(key:  "EnableLogInhouseAnaliticsForIDs")) == false) || ((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true))
        {
            goto label_397;
        }
        
        val_432 = val_428.Item["EnableLogInhouseAnaliticsForIDs"];
        PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 = false;
        List.Enumerator<T> val_132 = GetEnumerator();
        val_434 = 1152921516789141600;
        label_294:
        if((28655984 & 1) == 0)
        {
            goto label_292;
        }
        
        val_432 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((System.String.op_Equality(a:  val_432, b:  val_134.丐丏七丌丕丗业且上())) == false)
        {
            goto label_294;
        }
        
        PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 = true;
        label_292:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1708 != 1708)
        {
            goto label_300;
        }
        
        goto label_299;
        label_397:
        label_300:
        PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 = false;
        label_299:
        if(((val_428.ContainsKey(key:  "EnableLogForIDs")) == false) || ((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true))
        {
            goto label_402;
        }
        
        val_432 = val_428.Item["EnableLogForIDs"];
        List.Enumerator<T> val_155 = GetEnumerator();
        do
        {
            if((28655984 & 1) == 0)
        {
            goto label_415;
        }
        
            val_432 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        }
        while((System.String.op_Equality(a:  val_432, b:  丐丏七丌丕丗业且上())) == false);
        
        Rilisoft.丅专丞丛丞丐丛世三.丗丘一与不世丘专丟();
        label_415:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 == 1) || (1818 != 1818))
        {
            goto label_423;
        }
        
        goto label_425;
        label_423:
        if(null == null)
        {
            goto label_426;
        }
        
        label_402:
        label_426:
        label_425:
        if(((val_428.ContainsKey(key:  "EnableFpsCounterIds")) == false) || ((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true))
        {
            goto label_429;
        }
        
        List.Enumerator<T> val_164 = GetEnumerator();
        val_432 = 1152921516789141600;
        val_431 = 1152921504618561536;
        label_441:
        if((28655984 & 1) == 0)
        {
            goto label_443;
        }
        
        val_434 = System.Convert.ToString(value:  丐丏七丌丕丗业且上());
        if((专丈专业丆且且业下.世丈丞丅丂丞丕丗丗().Equals(value:  val_434)) == false)
        {
            goto label_441;
        }
        
        label_443:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((2 != 1) && (1929 == 1929))
        {
            
        }
        
        FpsManager.东下丝世丛丙上丏七(丙业与丙丗丝不丈东:  false);
        label_429:
        if(((val_428.ContainsKey(key:  "EnableWebSocketLogForIDs")) == false) || ((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true))
        {
            goto label_457;
        }
        
        List.Enumerator<T> val_174 = GetEnumerator();
        val_432 = 1152921516789141600;
        do
        {
            if((28655984 & 1) == 0)
        {
            goto label_471;
        }
        
            val_434 = 丐丏七丌丕丗业且上();
        }
        while((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_434)) == false);
        
        LogController.DuplicateToConsole = true;
        label_471:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((4 == 1) || (2047 != 2047))
        {
            goto label_479;
        }
        
        goto label_481;
        label_479:
        label_457:
        label_481:
        if((val_428.ContainsKey(key:  "EnableTestServerForDeviceIDs")) == false)
        {
            goto label_484;
        }
        
        val_432 = 1152921504624312320;
        PGCompany.丄丝东丌丛业丂业丛.丗丏丁专丌东丅业丙(丙业与丙丗丝不丈东:  System.String.alignConst);
        object val_180 = val_428.Item["EnableTestServerForDeviceIDs"];
        val_431 = FriendsController.<>c.<>9__222_0;
        if(val_431 == null)
        {
                System.Func<System.Object, System.String> val_182 = null;
            val_431 = val_182;
            val_182 = new System.Func<System.Object, System.String>(object:  FriendsController.<>c.<>9, method:  System.String FriendsController.<>c::七丟一一丗丁丆专丝(object 三丟东丕丄丄下下丑));
            FriendsController.<>c.<>9__222_0 = val_431;
        }
        
        val_434 = System.Linq.Enumerable.Select<System.Object, System.String>(source:  new System.Collections.Generic.List<System.Object>(), selector:  val_182);
        label_510:
        if((val_434 & 1) == 0)
        {
            goto label_514;
        }
        
        val_431 = val_434;
        if((System.String.op_Inequality(a:  val_431, b:  UnityEngine.SystemInfo.deviceUniqueIdentifier)) == true)
        {
            goto label_510;
        }
        
        bool val_190 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_428, 下上丐丆丝丟丝丒不:  "TestServerUrlForDeviceIds", 丙业与丙丗丝不丈东: out  0);
        PGCompany.丄丝东丌丛业丂业丛.丗丏丁专丌东丅业丙(丙业与丙丗丝不丈东:  System.String.alignConst);
        if((System.String.op_Inequality(a:  PGCompany.丄丝东丌丛业丂业丛.丈丌与东丞丏丑丘丂(), b:  PGCompany.丄丝东丌丛业丂业丛.丈丌与东丞丏丑丘丂())) != false)
        {
                Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丗丟万丂丘丈专丄丂();
        }
        
        label_514:
        val_436 = 1152921516630043280;
        if(val_434 == null)
        {
            
        }
        else
        {
                val_432 = 1152921505499549696;
        }
        
        if((4 == 1) || (2047 != 2258))
        {
            goto label_533;
        }
        
        goto label_535;
        label_533:
        label_484:
        PGCompany.丄丝东丌丛业丂业丛.丗丏丁专丌东丅业丙(丙业与丙丗丝不丈东:  System.String.alignConst);
        label_535:
        if((val_428.ContainsKey(key:  "FacebookLimits")) != false)
        {
                val_434 = 1;
            object val_197 = 0.Item["GreenLimit"];
            val_432 = 1152921504622129152;
            object val_198 = 0.Item["RedLimit"];
            if(FriendsController.丞世丟丄与七丝东丞 != null)
        {
                FriendsController.丞世丟丄与七丝东丞.Invoke(arg1:  21884928, arg2:  21884928);
        }
        
        }
        
        if((val_428.TryGetValue(key:  "ConfigsGroups", value: out  val_199)) != false)
        {
                FriendsController.丞丘丁业丙专且一世(丘丌丛七丌万一业丙:  val_199);
        }
        
        if((val_428.ContainsKey(key:  "JoinBaseResponseOn")) == false)
        {
            goto label_575;
        }
        
        val_432 = 1152921516473664400;
        val_431 = 1152921523884262800;
        label_564:
        if(0 >= Count)
        {
            goto label_575;
        }
        
        val_434 = Item[0];
        if(val_434 != null)
        {
                var val_206 = (null == null) ? (val_434) : 0;
        }
        
        if((SquadController.丈丟丒七与丂丙下丄(丞丅上丏丂且下丅与:  0)) == false)
        {
            goto label_564;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "gfts", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) | 256, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "TableViewKey", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        if(NotificationController.丄丘七三上丕世丞业 != 0)
        {
                NotificationController.丄丘七三上丕世丞业.SetTime(丌丝丌丁下丐丞丆一:  false);
        }
        
        label_575:
        if(((val_428.ContainsKey(key:  "DayUpdateTimeLimiter")) == false) || ((System.Convert.ToInt32(value:  val_428.Item["DayUpdateTimeLimiter"])) != 1))
        {
            goto label_647;
        }
        
        val_437 = "";
        new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        if(new UnityEngine.AndroidJavaClass() == null)
        {
            goto label_606;
        }
        
        val_434 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        if(val_434 == null)
        {
            goto label_607;
        }
        
        val_432 = 1152921516267089008;
        UnityEngine.AndroidJavaObject val_217 = val_434.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
        if(val_217 == null)
        {
            goto label_608;
        }
        
        string val_220 = (val_217 == 0) ? 0 : (val_434).Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
        if((System.String.IsNullOrEmpty(value:  val_220)) == true)
        {
            goto label_610;
        }
        
        object[] val_222 = new object[2];
        val_434 = val_222;
        val_434[0] = val_220;
        val_134 = 128;
        val_431 = val_134;
        val_434[1] = val_431;
        UnityEngine.AndroidJavaObject val_223 = val_217.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_222);
        if(val_223 == null)
        {
            goto label_618;
        }
        
        UnityEngine.AndroidJavaObject val_224 = val_223.Get<UnityEngine.AndroidJavaObject>(fieldName:  "applicationInfo");
        if(val_224 == null)
        {
            goto label_619;
        }
        
        UnityEngine.AndroidJavaObject val_225 = val_224.Get<UnityEngine.AndroidJavaObject>(fieldName:  "dataDir");
        label_669:
        if((System.String.IsNullOrEmpty(value:  val_225)) == true)
        {
            goto label_647;
        }
        
        new System.IO.DirectoryInfo() = new System.IO.DirectoryInfo(path:  val_225);
        goto label_621;
        label_632:
        label_629:
        if(0 >= val_228.Length)
        {
            goto label_623;
        }
        
        System.IO.DirectoryInfo val_429 = new System.IO.DirectoryInfo().GetDirectories()[0];
        val_431 = val_429;
        if((val_431.Contains(value:  "lib")) == true)
        {
            goto label_630;
        }
        
        if((val_429.Contains(value:  "shared_prefs")) == false)
        {
            goto label_629;
        }
        
        goto label_630;
        label_623:
        val_436 = 1152921516630043280;
        label_621:
        if(new System.IO.DirectoryInfo().Parent != null)
        {
            goto label_632;
        }
        
        goto label_647;
        label_630:
        val_436 = 1152921516630043280;
        goto label_636;
        label_646:
        if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[0]) != 0)
        {
                UnityEngine.Object.Destroy(obj:  val_232[0x0] + 32.gameObject);
        }
        
        label_636:
        if(1 < val_232.Length)
        {
            goto label_646;
        }
        
        goto label_647;
        label_606:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  "unityPlayer == null");
        label_607:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  "_currentActivity == null");
        label_608:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  "packageManager == null");
        label_610:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  "string.IsNullOrEmpty(packageName)");
        label_618:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  "packageInfo == null");
        label_619:
        new System.InvalidOperationException() = new System.InvalidOperationException(message:  "applicationInfo == null");
        if(0 != 1)
        {
            goto label_1215;
        }
        
        if((null & 1) == 0)
        {
            goto label_668;
        }
        
        goto label_669;
        label_668:
        mem[8] = new System.InvalidOperationException();
        goto label_1198;
        label_647:
        if((val_428.ContainsKey(key:  "TwitterLimits")) != false)
        {
                object val_242 = val_428.Item["TwitterLimits"];
            object val_243 = 0.Item["GreenLimit"];
            object val_244 = 0.Item["RedLimit"];
            object val_245 = 0.Item["MultyWinLimit"];
            object val_246 = 0.Item["ArenaLimit"];
            val_436 = 1152921516630043280;
            if(FriendsController.东丞丑丙丗丆三丟七 != null)
        {
                FriendsController.东丞丑丙丗丆三丟七.Invoke(arg1:  21884928, arg2:  21884928, arg3:  21884928, arg4:  21884928);
        }
        
        }
        
        if((val_428.ContainsKey(key:  "BattleRoyaleV4")) == false)
        {
            goto label_694;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_250 = GetEnumerator();
        val_431 = 1152921505066536960;
        label_718:
        if((28655936 & 1) == 0)
        {
            goto label_702;
        }
        
        ConfiguredValueTaskAwaiter val_252 = val_134.GetAwaiter();
        int val_254 = System.Convert.ToInt32(value:  val_252._value._obj.丐丏七丌丕丗业且上());
        GameConnect.丕不丛丒丕世上专下.set_Item(key:  val_254, value:  System.Convert.ToInt32(value:  Item["maxCountPlayers"]));
        BattleRoyaleController.业不万业东三专与七.set_Item(key:  val_254, value:  System.Convert.ToInt32(value:  Item["minCountPlayers"]));
        BattleRoyaleController.下丞不七与丈丗专丈.set_Item(key:  val_254, value:  (float)System.Convert.ToInt32(value:  Item["startTimer"]));
        goto label_718;
        label_702:
        val_436 = 1152921516630043280;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((5 == 1) || (3316 != 3316))
        {
            goto label_757;
        }
        
        goto label_762;
        label_757:
        if( == 0)
        {
            goto label_762;
        }
        
        goto label_762;
        label_694:
        label_762:
        if((val_428.ContainsKey(key:  "CheaterDetectParameters")) != false)
        {
                object val_263 = val_428.Item["CheaterDetectParameters"];
            object val_266 = Item[与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄];
            object val_267 = Item[与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝];
            object val_268 = 0.Item["NonPaying"];
            object val_269 = 0.Item[与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄];
            object val_270 = 0.Item[与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝];
            val_436 = 1152921516630043280;
            if(FriendsController.丟丘丂丗丏万丐东丏 != null)
        {
                FriendsController.丟丘丂丗丏万丐东丏.Invoke(arg1:  21884928, arg2:  21884928, arg3:  21884928, arg4:  21884928);
        }
        
        }
        
        if((val_428.ContainsKey(key:  "RespawnDelayParameters_v2")) == false)
        {
            goto label_790;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_274 = GetEnumerator();
        val_431 = 1152921516595686816;
        label_811:
        if((28655936 & 1) == 0)
        {
            goto label_798;
        }
        
        ConfiguredValueTaskAwaiter val_278 = val_276.GetAwaiter();
        int val_280 = System.Convert.ToInt32(value:  val_278._value._obj.丐丏七丌丕丗业且上());
        bool val_282 = 丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  val_278._value._obj, 丙业与丙丗丝不丈东: out  float val_281 = 6.658233E-38f);
        val_438 = null;
        val_438 = null;
        if((与丂丏丛丞丞丒丟丄.上万丆丆专丒不万丂.ContainsKey(key:  val_280)) == true)
        {
            goto label_811;
        }
        
        val_439 = null;
        val_439 = null;
        与丂丏丛丞丞丒丟丄.上万丆丆专丒不万丂.Add(key:  val_280, value:  0f);
        goto label_811;
        label_798:
        var val_431 = 5;
        val_431 = val_431 + 1;
        mem2[0] = 3641;
        val_436 = 1152921516630043280;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_433 = val_431;
        if((val_433 == 1) || ((28655312 + ((5 + 1)) << 2) != 3641))
        {
            goto label_848;
        }
        
        var val_432 = 0;
        val_432 = val_432 ^ (val_433 >> 31);
        val_433 = val_433 + val_432;
        goto label_853;
        label_848:
        if( == 0)
        {
            goto label_853;
        }
        
        goto label_853;
        label_790:
        label_853:
        if((val_428.ContainsKey(key:  "RespawnDelayRealisticSetting")) != false)
        {
                val_440 = null;
            val_440 = null;
            与丂丏丛丞丞丒丟丄.丅上丑丗丘且丘丛丝 = System.Convert.ToInt32(value:  val_428.Item["RespawnDelayRealisticSetting"]);
        }
        
        if((val_428.ContainsKey(key:  "NurseryUnlockLevel")) != false)
        {
                val_441 = null;
            val_441 = null;
            与丂丏丛丞丞丒丟丄.世丕丒上丟丆专丌丅 = System.Convert.ToInt32(value:  val_428.Item["NurseryUnlockLevel"]);
        }
        
        if((val_428.ContainsKey(key:  "ZoneSettings")) != false)
        {
                if(val_428.Item["ZoneSettings"] != null)
        {
                val_442 = 0;
        }
        
            SafeZonesController.丟丈与丕三丐丒丐丑(丏丂万业丙专丏丒丒:  null);
        }
        
        if((val_428.ContainsKey(key:  "PlayerControlsDynamicFPS")) == false)
        {
            goto label_931;
        }
        
        val_443 = null;
        val_443 = null;
        Dictionary.Enumerator<TKey, TValue> val_294 = PlayerCoreSettingsStorager.dynamicSettingsGameModes.GetEnumerator();
        label_891:
        if((28655856 & 1) == 0)
        {
            goto label_884;
        }
        
        ConfiguredValueTaskAwaiter val_298 = val_297.GetAwaiter();
        if(val_298._value._obj.丙东专丂世丈丏丁丂() == 20)
        {
            goto label_891;
        }
        
        object val_300 = val_428.Item["PlayerControlsDynamicFPS"];
        val_444 = 0;
        val_298._value._obj.世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        goto label_891;
        label_884:
        var val_435 = val_433;
        val_435 = val_435 + 1;
        mem2[0] = 3856;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_437 = val_435;
        if((val_437 != 1) && ((28655312 + ((((5 + 1) + (0 ^ ((int)(5 + 1)) >> 31)) + 1)) << 2) == 3856))
        {
                var val_436 = 0;
            val_436 = val_436 ^ (val_437 >> 31);
            val_437 = val_437 + val_436;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_446 = null;
        if((((mem[val_446 + 295]) & 2) != 0) && ((mem[val_446 + 216]) == 0))
        {
                val_446 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_301 = mem[val_446 + 184] + 16.GetEnumerator();
        val_431 = 1152921526110157664;
        label_916:
        if((28655792 & 1) == 0)
        {
            goto label_909;
        }
        
        ConfiguredValueTaskAwaiter val_305 = val_303.GetAwaiter();
        string val_306 = val_428.Item[1179403647];
        val_447 = 0;
        val_305._value._obj.世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        val_305._value._obj.丈丟丒万与丅业一专(丕丁丙丝丅一丒丂丌:  val_305._value._obj.丙东专丂世丈丏丁丂());
        goto label_916;
        label_909:
        var val_439 = val_437;
        val_439 = val_439 + 1;
        mem2[0] = 3951;
        val_436 = 1152921516630043280;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_441 = val_439;
        if((val_441 == 1) || ((28655312 + ((((((5 + 1) + (0 ^ ((int)(5 + 1)) >> 31)) + 1) + (0 ^ ((int)(((5 + 1) + (0 ^ ((int)(5 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) != 3951))
        {
            goto label_927;
        }
        
        var val_440 = 0;
        val_440 = val_440 ^ (val_441 >> 31);
        val_441 = val_441 + val_440;
        goto label_929;
        label_927:
        if(val_303 != 0)
        {
            
        }
        
        label_931:
        label_929:
        if((val_428.ContainsKey(key:  "PlayerControlsDynamicBR")) == false)
        {
            goto label_958;
        }
        
        val_448 = null;
        val_448 = null;
        Dictionary.Enumerator<TKey, TValue> val_309 = PlayerCoreSettingsStorager.dynamicSettingsGameModes.GetEnumerator();
        val_431 = 1152921526110145376;
        label_945:
        if((28655856 & 1) == 0)
        {
            goto label_937;
        }
        
        ConfiguredValueTaskAwaiter val_313 = val_312.GetAwaiter();
        if(val_313._value._obj.丙东专丂世丈丏丁丂() != 20)
        {
                if(val_313._value._obj.丙东专丂世丈丏丁丂() != 31)
        {
            goto label_945;
        }
        
        }
        
        object val_316 = val_428.Item["PlayerControlsDynamicBR"];
        val_449 = 0;
        val_313._value._obj.世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        goto label_945;
        label_937:
        var val_443 = val_441;
        val_443 = val_443 + 1;
        mem2[0] = 4062;
        val_436 = 1152921516630043280;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_443 == 1)
        {
            goto label_954;
        }
        
        if(val_312 == 0)
        {
            goto label_958;
        }
        
        if((28655312 + ((((((((5 + 1) + (0 ^ ((int)(5 + 1)) >> 31)) + 1) + (0 ^ ((int)(((5 + 1) + (0 ^ ((int)(5 + 1)) >> 31)) + 1)) >> 31)) + 1) + (0 ^ ((int)(((((5 + 1) + (0 ^ ((int)(5 + 1)) >> 31)) + 1) + (0 ^ ((int)(((5 +) << 2) != 4062)
        {
            goto label_956;
        }
        
        goto label_958;
        label_954:
        if(val_312 == 0)
        {
            goto label_958;
        }
        
        label_956:
        label_958:
        if((val_428.ContainsKey(key:  "GameModePlayerSettingsDependence_v2")) != false)
        {
                object val_319 = val_428.Item["GameModePlayerSettingsDependence_v2"];
            val_450 = 0;
            PlayerCoreSettingsStorager.Instance.丏丑丕丁一三丄与丈(丞丅丛丞丟丘丗丌东:  null);
        }
        
        if((val_428.ContainsKey(key:  "MoveSchemePlayerSettingsDependence_v2")) != false)
        {
                object val_322 = val_428.Item["MoveSchemePlayerSettingsDependence_v2"];
            val_451 = 0;
            PlayerCoreSettingsStorager.Instance.三丕丞丟丟丘丑一万(丙丕丈下丙丆丞丝丝:  null);
        }
        
        if((val_428.ContainsKey(key:  "RecoilAndScopeSettings")) != false)
        {
                val_452 = null;
            val_452 = null;
            object val_325 = val_428.Item["RecoilAndScopeSettings"];
            val_453 = 0;
            PlayerCoreSettingsStorager.recoildAndScopeSettings.世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        }
        
        if((val_428.ContainsKey(key:  "AutoStartInMatchV2")) != false)
        {
                与丂丏丛丞丞丒丟丄.与东业丅丈且与丛东(丙业与丙丗丝不丈东:  ((System.Convert.ToInt32(value:  val_428.Item["AutoStartInMatchV2"])) == 1) ? 1 : 0);
        }
        
        if((val_428.ContainsKey(key:  "AutoStartNextMatchTimeV2")) != false)
        {
                val_454 = null;
            val_454 = null;
            与丂丏丛丞丞丒丟丄.下万丏丁丙不丅三丄 = System.Convert.ToSingle(value:  val_428.Item["AutoStartNextMatchTimeV2"]);
        }
        
        if((val_428.ContainsKey(key:  "AutoStartNextMatchTimeV2")) != false)
        {
                val_455 = null;
            val_455 = null;
            与丂丏丛丞丞丒丟丄.下万丏丁丙不丅三丄 = System.Convert.ToSingle(value:  val_428.Item["AutoStartNextMatchTimeV2"]);
        }
        
        if((val_428.ContainsKey(key:  "GadgetBRSetting")) != false)
        {
                val_456 = null;
            val_456 = null;
            ChestsBattleRoyaleController.与丗一丕下丞世丟上 = System.Convert.ToInt32(value:  val_428.Item["GadgetBRSetting"]);
        }
        
        if((val_428.ContainsKey(key:  "PlayerEffectContainer")) != false)
        {
                val_457 = null;
            val_457 = null;
            PlayerEffectContainer.丗上与丈丕丁且七世 = ((System.Convert.ToInt32(value:  val_428.Item["PlayerEffectContainer"])) == 1) ? 1 : 0;
        }
        
        if((val_428.ContainsKey(key:  "IndicateLeftEnemiesTeamDuel")) != false)
        {
                val_458 = null;
            val_458 = null;
            与丂丏丛丞丞丒丟丄.丑丕一且丛丞丌丌丐 = System.Convert.ToBoolean(value:  val_428.Item["IndicateLeftEnemiesTeamDuel"]);
        }
        
        if((val_428.ContainsKey(key:  "IndicateLeftEnemiesTeamDuelTime")) != false)
        {
                val_459 = null;
            val_459 = null;
            与丂丏丛丞丞丒丟丄.丌与丅丑与丈且丂丝 = System.Convert.ToInt32(value:  val_428.Item["IndicateLeftEnemiesTeamDuelTime"]);
        }
        
        if((val_428.ContainsKey(key:  "IndicateLeftEnemiesHunger")) != false)
        {
                val_460 = null;
            val_460 = null;
            与丂丏丛丞丞丒丟丄.丐丒丐万不丌丛丁丂 = System.Convert.ToBoolean(value:  val_428.Item["IndicateLeftEnemiesHunger"]);
        }
        
        if((val_428.ContainsKey(key:  "IndicateLeftEnemiesHungerTime")) != false)
        {
                val_461 = null;
            val_461 = null;
            与丂丏丛丞丞丒丟丄.丙丘丗丐丞万丑丐下 = System.Convert.ToInt32(value:  val_428.Item["IndicateLeftEnemiesHungerTime"]);
        }
        
        if((val_428.ContainsKey(key:  "MonsterHunter")) != false)
        {
                object val_358 = val_428.Item["MonsterHunter"];
            if((0.ContainsKey(key:  "CurrentMonsterHunterName")) != false)
        {
                val_462 = null;
            val_462 = null;
            MonsterHunterModeController.七丁丈丐丐丁丁上下 = 0.Item["CurrentMonsterHunterName"];
        }
        
            if((0.ContainsKey(key:  "CurrentMonsterHunterMechBody")) != false)
        {
                val_463 = null;
            val_463 = null;
            MonsterHunterModeController.业丘与且丟丄上丒丐 = 0.Item["CurrentMonsterHunterMechBody"];
        }
        
            if((0.ContainsKey(key:  "CurrentMonsterHunterGadgetTool")) != false)
        {
                val_464 = null;
            val_464 = null;
            MonsterHunterModeController.丅丗丙东上丅丘东丕 = 0.Item["CurrentMonsterHunterGadgetTool"];
        }
        
            if((0.ContainsKey(key:  "CurrentMonsterHunterGadgetThrowing")) != false)
        {
                val_465 = null;
            val_465 = null;
            MonsterHunterModeController.丏下丒丒丄不丌专上 = 0.Item["CurrentMonsterHunterGadgetThrowing"];
        }
        
        }
        
        val_466 = 1152921516595658096;
        if((val_428.ContainsKey(key:  "FreePlayMaxPlayers")) != false)
        {
                val_467 = null;
            val_467 = null;
            GameConnect.丅丝丑丏丛三世专丕 = System.Convert.ToInt32(value:  val_428.Item["FreePlayMaxPlayers"]);
        }
        
        if((val_428.ContainsKey(key:  "FreePlayMatchTime")) != false)
        {
                val_468 = null;
            val_468 = null;
            FreeplayScoreController.丅上七丈丄丐不丆丛 = System.Convert.ToSingle(value:  val_428.Item["FreePlayMatchTime"]);
        }
        
        if((val_428.ContainsKey(key:  "PlayerEquip")) != false)
        {
                object val_374 = val_428.Item["PlayerEquip"];
        }
        
        val_429 = 0;
        FriendsController.丌与不丑丕丞专丟丈(丙业与丙丗丝不丈东:  val_429);
        if((val_428.ContainsKey(key:  "ClanPromoteGemsCost")) != false)
        {
                Rilisoft.丝丑丂丛万丐丈丘且 val_378 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_428.Item["ClanPromoteGemsCost"]));
            val_429 = val_378.七丄不丐丗三丝丑一;
            val_469 = null;
            val_469 = null;
            PGCompany.Clans.Network.丁丌上丁丗丞丞且万.丆与丙上丂且上丗且 = val_429;
            PGCompany.Clans.Network.丁丌上丁丗丞丞且万.丆与丙上丂且上丗且.__il2cppRuntimeField_3 = val_378.丑丒丄下丁丐专丄丞;
            PGCompany.Clans.Network.丁丌上丁丗丞丞且万.丆与丙上丂且上丗且.__il2cppRuntimeField_8 = val_378.上万三丆专丏丒丗业;
        }
        
        if((val_428.TryGetValue(key:  "IdfaEnabled", value: out  val_379)) != false)
        {
                val_429 = PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世();
            val_381.业上万不上丂不世万 = System.Convert.ToBoolean(value:  val_379);
        }
        
        if((val_428.TryGetValue(key:  "IdfaMaxRejects", value: out  val_384)) != false)
        {
                val_429 = PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世();
            val_386.业三丁且丝下丈丈丗 = System.Convert.ToInt32(value:  val_384);
        }
        
        if((val_428.TryGetValue(key:  "IdfaCooldown", value: out  val_388)) != false)
        {
                val_429 = PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世();
            val_390.丗丒丂丐丟不世丄丄 = System.Convert.ToInt32(value:  val_388);
        }
        
        if((val_428.TryGetValue(key:  "IdfaMinVersion", value: out  val_392)) == false)
        {
            goto label_1141;
        }
        
        val_470 = val_392;
        if(val_470 != 0)
        {
                var val_394 = (1179403647 == null) ? (val_470) : 0;
        }
        
        string val_395 = (val_394 == 0) ? "" : (val_394);
        val_471 = PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世();
        if((System.String.op_Equality(a:  val_395, b:  "")) == false)
        {
            goto label_1145;
        }
        
        val_472 = 0;
        if(val_471 != null)
        {
            goto label_1152;
        }
        
        goto label_1147;
        label_1141:
        val_471 = PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世();
        if(val_471 == null)
        {
            goto label_1212;
        }
        
        label_1213:
        val_472 = 0;
        goto label_1152;
        label_1145:
        val_472 = new System.Version();
        val_472 = new System.Version(version:  val_395);
        if(val_471 != null)
        {
            goto label_1152;
        }
        
        label_1147:
        label_1152:
        val_396.丆丌专丟业丁专丟丌 = val_472;
        if((val_428.TryGetValue(key:  "BlockGameModeIOSModels", value: out  0)) != false)
        {
                val_429 = 0;
            PGCompany.GameModeLowDeviceWarningBanner.丐丞丞丂丐业业丅且 = new System.Collections.Generic.HashSet<System.String>(collection:  val_429);
        }
        
        if((val_428.TryGetValue(key:  "WarningGameModeIOSModels", value: out  0)) != false)
        {
                val_429 = 0;
            PGCompany.GameModeLowDeviceWarningBanner.上丈世丂丘丑丗且丛 = new System.Collections.Generic.HashSet<System.String>(collection:  val_429);
        }
        
        if((val_428.TryGetValue(key:  "LowDeviceBlockBannerEnable", value: out  val_406)) != false)
        {
                val_429 = val_406;
            PGCompany.GameModeLowDeviceWarningBanner.业上万不上丂不世万 = System.Convert.ToBoolean(value:  val_429);
        }
        
        if((val_428.ContainsKey(key:  "ShotgunV2")) != false)
        {
                val_429 = System.Convert.ToBoolean(value:  val_428.Item["ShotgunV2"]);
            BalanceController.丕业三丑丛专不丟丟(丙业与丙丗丝不丈东:  val_429);
        }
        
        if((val_428.ContainsKey(key:  "NewCarSync")) != false)
        {
                val_429 = System.Convert.ToBoolean(value:  val_428.Item["NewCarSync"]);
            val_473 = null;
            val_473 = null;
            TransportSyncBase.丆丆丞丗业三上下丈 = val_429;
        }
        
        if((val_428.ContainsKey(key:  "DisableDevAnalyticsInapp")) != false)
        {
                val_474 = null;
            val_474 = null;
            PGCompany.Analytics.上丒丞上丌丌丘丛一.万业与丕丂丆且东七 = false;
        }
        
        if((val_428.TryGetValue(key:  "luckyCloverCompensation", value: out  val_419)) == false)
        {
                return;
        }
        
        val_429 = 1152921505469198336;
        val_475 = null;
        val_475 = null;
        Rilisoft.LobbyItemsController.丂丏丁下七丌七丆丅 = System.Convert.ToBoolean(value:  val_419);
        return;
        label_1215:
        mem[8] = 1152921504691564544;
        label_1198:
        if(123444064 != 1)
        {
            goto label_1215;
        }
        
        val_466 = 8;
        if((null & 1) == 0)
        {
            goto label_1200;
        }
        
        object[] val_426 = new object[2];
        val_466 = val_426;
        val_466[0] = val_432;
        val_466[1] = mem[8];
        UnityEngine.Debug.LogErrorFormat(format:  "Exception in parsing min idfa version {0}: {1}", args:  val_426);
        if(PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世() == null)
        {
            goto label_1212;
        }
        
        goto label_1213;
        label_1212:
        label_1200:
        mem[8] = val_466;
        goto label_1198;
    }
    public FriendsController()
    {
        this.丕丟世上世一丅丞上 = 0;
        this.丐丘丟业下丄丂丝丗 = -1f;
        this.丐丐世七丒丏七丈不 = "currentCompetitionKey";
        this.世丅丈东丘丐丕丟丐 = new System.Collections.Generic.List<System.Int32>();
        this.friendsDeletedLocal = new System.Collections.Generic.List<System.String>();
        this.丞一下丟丞丈丗上丞 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.String>>();
        this.世与万丐业丂与丑丗 = new System.Collections.Generic.List<System.String>();
        this.丄且上一丅万丕业丛 = new System.Collections.Generic.List<System.String>();
        this.世丅下丄丌丂万丑一 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.String>>();
        this.丗丆丑世丕七专丝丒 = new System.Collections.Generic.List<System.String>();
        this.丈丄丌丒业丐丒上万 = new System.Collections.Generic.List<System.String>();
        this.一七丞与丁丆专丒丂 = new System.Collections.Generic.List<System.String>();
        this.丆一丐下丐丞丑不丛 = new System.Collections.Generic.List<System.String>();
        this.丝丟丄世丗且丕丈丝 = new System.Collections.Generic.List<System.String>();
        this.与丙丂丏一一丈丛丅 = 900f;
        System.Collections.Generic.Dictionary<Rilisoft.七下上丝三丛三上一, System.String> val_12 = new System.Collections.Generic.Dictionary<Rilisoft.七下上丝三丛三上一, System.String>();
        if(val_12 != null)
        {
                val_12.Add(key:  0, value:  "Key_0574");
        }
        else
        {
                val_12.Add(key:  0, value:  "Key_0574");
        }
        
        val_12.Add(key:  1, value:  "Key_0575");
        val_12.Add(key:  4, value:  "Key_0576");
        this.丏丌丙丂世丌与一下 = val_12;
        this.下丒上丝丁业不且丘 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
        this.丗丄丆丒万且丐业东 = new System.Collections.Generic.Dictionary<System.Int32, System.ValueTuple<System.Action, System.Action>>();
        this.<专丈丌丟不东丂三丅>k__BackingField = new System.Collections.Generic.List<System.String>();
        this.clicksJoinByFriends = new System.Collections.Generic.Dictionary<System.String, System.String>();
    }
    private static FriendsController()
    {
        FriendsController.下世丄丏不上丁丘丅 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>>();
        FriendsController.业丂一丙东与丅一丛 = false;
        FriendsController.丄丞丁丈与业上丞丟 = 0;
        FriendsController.丈丘专万丅下丏丝丞 = false;
        FriendsController.七万丒丘丐不丗丕丕 = "expirationTimeCompetitionKey";
        FriendsController.丆丐丟丑世丌丅不丒 = false;
        FriendsController.且东丞丒丑上专丞丏 = 0;
        FriendsController.一七丂丌丝丒一丕丒 = 0;
        FriendsController.丛东东专业丟丞上一 = 0;
        FriendsController.一丌一三丂丒丄丐丒 = false;
        FriendsController.万不丑丑且下丞丁七 = "FacebookIDKey";
        FriendsController.丞万专丁一且下丏万 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        FriendsController.业丘万不万与不丏下 = "none";
    }

}
