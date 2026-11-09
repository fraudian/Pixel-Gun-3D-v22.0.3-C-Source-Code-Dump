using UnityEngine;
internal sealed class MatchmakingConnect : MonoBehaviour
{
    // Fields
    private static MatchmakingConnect 丝业丆丁业三丈丟东;
    private System.Threading.Tasks.Task<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> 丒丟丈丝丑与丄丗丒;
    private PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 丘丙业丕不上丙丏丄;
    internal static string 丒丐丐丙丘丂丂丗东;
    internal static string 丟丆东丑三丙丄丆不;
    internal static string 丗丅丙丕丛丁丂丄万;
    internal static string 丟丛丅丟世下丗丈专;
    internal static string 丕一业丌丄下丈丂专;
    internal static string 三不三三丆丅世丞三;
    internal static string 与业丞三一万上一丟;
    internal static string 丁丑丗丙丌七丞且丌;
    internal static string 下且丙业丐上丁丟专;
    internal static string 万专丘丝丄丆一丑丞;
    internal static string 下东三丐七丐一丛业;
    internal static string 丐丄一专丑丌世丞不;
    internal static string 万丛丄一专丌丄东丟;
    internal static string 东丒丒丅丙丆七上丄;
    internal static string 专一丈丑丆下东丕丙;
    internal static string 且丌专一丟一丄丁丏;
    internal static string 丁丛丂丕与丅丏不上;
    internal static string 丄万丞七三丕丅丌丕;
    internal static string 世世上万丗丞丕且丝;
    internal static string 丈丅三丗丅且丅丏丄;
    internal static string 丛丟丅丒丒一一丅业;
    internal static string 三丄丈丄世丏丞丝丌;
    internal static string 丐万丘七专上丅丛丅;
    internal static string 丕与丌丂万一三丘丂;
    internal static string 万丂丞丌丛丂丅丑万;
    
    // Properties
    public static MatchmakingConnect 丄丘七三上丕世丞业 { get; }
    public bool 丝丗七万丞丅丟丙丈 { get; }
    
    // Methods
    public static MatchmakingConnect get_instance()
    {
        var val_4;
        MatchmakingConnect val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = MatchmakingConnect.丝业丆丁业三丈丟东;
        if(val_5 == 0)
        {
                UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "MatchmakingConnect [Singleton]");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            val_6 = null;
            val_5 = val_2.AddComponent<MatchmakingConnect>();
            val_6 = null;
            MatchmakingConnect.丝业丆丁业三丈丟东 = val_5;
        }
        
        val_7 = null;
        val_7 = null;
        return (MatchmakingConnect)MatchmakingConnect.丝业丆丁业三丈丟东;
    }
    public bool get_InRequest()
    {
        return (bool)(this.丒丟丈丝丑与丄丗丒 != 0) ? 1 : 0;
    }
    internal static bool 丐万丗专丐丏丆丗丁()
    {
        var val_5;
        System.Nullable<System.Boolean> val_1 = PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.世丑三丆丒七丘丕丑();
        if(((-642383716) & 1) != 0)
        {
                System.Nullable<System.Boolean> val_2 = PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.世丑三丆丒七丘丕丑();
            if(((-642383716) & 1) != 0)
        {
                val_5 = 丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下() ^ 1;
            return (bool)val_5 & 1;
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5 & 1;
    }
    private void Awake()
    {
        System.Action<System.Int32> val_4;
        if(((System.Delegate.Combine(a:  PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.下世下丞世专丂东丟, b:  new System.Action<System.Int32>(object:  this, method:  System.Void MatchmakingConnect::丒不与丗万世丗丗东(int 丁丆不丑丛专丏世丐)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.下世下丞世专丂东丟 = val_4;
    }
    private void OnDestroy()
    {
        System.Action<System.Int32> val_4;
        if(((System.Delegate.Remove(source:  PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.下世下丞世专丂东丟, value:  new System.Action<System.Int32>(object:  this, method:  System.Void MatchmakingConnect::丒不与丗万世丗丗东(int 丁丆不丑丛专丏世丐)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.MatchmakingRequest.丛丘丆丟丐与万上丆.下世下丞世专丂东丟 = val_4;
    }
    internal void 丒不与丗万世丗丗东(int 丁丆不丑丛专丏世丐)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        世丌与丈专三丘万丑(丁丆不丑丛专丏世丐:  丁丆不丑丛专丏世丐);
    }
    internal bool 丑丝专丌一丒丂丅丛(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, SceneInfo 丏丈丗世丙万丆丐丅, int 业万上丆丐丞且丒七, int 专世专丟丝丌与丘上, float 万丝丑丂丆业丞丈七, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅, string[] 东丏与三丄丙三下丈, string[] 东丆世丘丁丗专丆东)
    {
        var val_13;
        System.Int32[] val_14;
        PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 val_15;
        if(this.丒丟丈丝丑与丄丗丒 != null)
        {
                UnityEngine.Debug.LogError(message:  "RequestRoom: already happening");
            val_13 = 0;
            return (bool)this.丑丝专丌一丒丂丅丛(东丞丒丙世丏三下丟:  val_15 = 丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        }
        
        if(丏丈丗世丙万丆丐丅 != 0)
        {
                val_14 = new int[1];
            val_14[0] = 丏丈丗世丙万丆丐丅.indexMap;
        }
        else
        {
                val_14 = GameConnect.丁业丈万丛丒专丅且(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东);
        }
        
        PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 val_4 = new PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙();
        if(val_4 != null)
        {
                .三专丞丄东丂丟七与 = 专世专丟丝丌与丘上 + 1;
            .丌丄丕丌丑东丆丏丆 = 业万上丆丐丞且丒七 + 1;
        }
        else
        {
                mem[16] = 专世专丟丝丌与丘上 + 1;
            .丌丄丕丌丑东丆丏丆 = 业万上丆丐丞且丒七 + 1;
        }
        
        .与丞丆丐丛万丆丄东 = (double)万丝丑丂丆业丞丈七;
        val_15 = 0;
        .丅丗丛丂丏业丅世丁 = 丟丌丁且且世丈丈丟.不丛丁且丘丑上丕七(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
        .一丗丟丛丈专丙三丌 = 丂丛丑东不丅丈一东;
        .丅丏丟且世丛丞丗丌 = val_14;
        .一丛世丘下不下不丅 = 东丏与三丄丙三下丈;
        .丅丛三世且下与东丁 = 东丆世丘丁丗专丆东;
        this.丘丙业丕不上丙丏丄 = val_4;
        if(丐且丘丑与万丞丑丅 != null)
        {
                .上专不七丐万丗与丒 = 0;
        }
        
        val_13 = this;
        return (bool)this.丑丝专丌一丒丂丅丛(东丞丒丙世丏三下丟:  val_15);
    }
    internal bool 丑丝专丌一丒丂丅丛(PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 东丞丒丙世丏三下丟)
    {
        var val_3;
        if(this.丒丟丈丝丑与丄丗丒 != null)
        {
                UnityEngine.Debug.LogError(message:  "RequestRoom: already happening");
            val_3 = 0;
            return (bool)val_3;
        }
        
        this.丒丟丈丝丑与丄丗丒 = PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丑七不且上丗丁一世().丑丝专丌一丒丂丅丛(丘丙业丕不上丙丏丄:  this.丘丙业丕不上丙丏丄);
        val_3 = 1;
        return (bool)val_3;
    }
    internal void 且丞七丕丕丕丄丆丅()
    {
        if(this.丒丟丈丝丑与丄丗丒 != null)
        {
                this.丒丟丈丝丑与丄丗丒 = 0;
            mem[1152921538325243344] = 0;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "AbortRequest: already stopped");
    }
    private void Update()
    {
        if(this.丒丟丈丝丑与丄丗丒 == null)
        {
                return;
        }
        
        if(this.丒丟丈丝丑与丄丗丒.IsCompleted != false)
        {
                PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不 val_2 = this.丒丟丈丝丑与丄丗丒.Result;
            val_2.丂上且丙丞万丄下丆(丂丐丄丁丆与丈丂上:  this.丘丙业丕不上丙丏丄, 丑与丂丌世丕丆一丗:  val_2);
            this.丒丟丈丝丑与丄丗丒 = 0;
            return;
        }
        
        if(this.丒丟丈丝丑与丄丗丒.IsFaulted != true)
        {
                if(this.丒丟丈丝丑与丄丗丒.IsCanceled == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "Room request failed. Requesting new room");
        this.丒丟丈丝丑与丄丗丒 = PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丑七不且上丗丁一世().丑丝专丌一丒丂丅丛(丘丙业丕不上丙丏丄:  this.丘丙业丕不上丙丏丄);
    }
    private void 丂上且丙丞万丄下丆(PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 丂丐丄丁丆与丈丂上, PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不 丑与丂丌世丕丆一丗)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_5;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_6;
        UnityEngine.Debug.Log(message:  "OnMatchmakingRoomFound " + 丑与丂丌世丕丆一丗.丅一丞万丑专丅丅与);
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
            goto label_6;
        }
        
        if(丂丐丄丁丆与丈丂上 == null)
        {
            goto label_7;
        }
        
        val_5 = 丂丐丄丁丆与丈丂上.一丗丟丛丈专丙三丌;
        goto label_8;
        label_6:
        UnityEngine.Debug.LogError(message:  "OnMatchmakingRoomFound: Not connected!");
        return;
        label_7:
        val_5 = 135970152;
        label_8:
        if((丂丐丄丁丆与丈丂上.上专不七丐万丗与丒 & 1) == 0)
        {
            goto label_11;
        }
        
        val_6 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丘一一丛丏丕下丟丛(丞丅上丏丂且下丅与:  丂丐丄丁丆与丈丂上.上专不七丐万丗与丒);
        if(丂丐丄丁丆与丈丂上 != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_11:
        val_6 = 0;
        if(丂丐丄丁丆与丈丂上 != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        GameConnect.万丐丑上丟丞丞丏丑(丅一丞万丑专丅丅与:  丑与丂丌世丕丆一丗.丅一丞万丑专丅丅与, 丛且丞与丕业下丏丞:  丑与丂丌世丕丆一丗.丛且丞与丕业下丏丞, 上且丗一丏丏万丅丌:  val_5, 丟丑业丌丙丙丑下丑:  true, 下下东且万业丞丅丒:  true, 七专丙丏丘丌丌下与:  0, 丐且丘丑与万丞丑丅:  val_6, 丙丘东丏三丆丄丁丟:  丂丐丄丁丆与丈丂上.丅丛三世且下与东丁, 丕丑专丗万丕与专丐:  1);
    }
    public MatchmakingConnect()
    {
    
    }
    private static MatchmakingConnect()
    {
        MatchmakingConnect.丒丐丐丙丘丂丂丗东 = "n";
        MatchmakingConnect.丟丆东丑三丙丄丆不 = "pid";
        MatchmakingConnect.丗丅丙丕丛丁丂丄万 = "sn";
        MatchmakingConnect.丟丛丅丟世下丗丈专 = "s";
        MatchmakingConnect.丕一业丌丄下丈丂专 = "av";
        MatchmakingConnect.三不三三丆丅世丞三 = "w";
        MatchmakingConnect.与业丞三一万上一丟 = "wa";
        MatchmakingConnect.丁丑丗丙丌七丞且丌 = "ws";
        MatchmakingConnect.下且丙业丐上丁丟专 = "AiStatLevel";
        MatchmakingConnect.万专丘丝丄丆一丑丞 = "AiDeltaChange";
        MatchmakingConnect.下东三丐七丐一丛业 = "team";
        MatchmakingConnect.丐丄一专丑丌世丞不 = "ph";
        MatchmakingConnect.万丛丄一专丌丄东丟 = "pc";
        MatchmakingConnect.东丒丒丅丙丆七上丄 = "pcc";
        MatchmakingConnect.专一丈丑丆下东丕丙 = "pm";
        MatchmakingConnect.且丌专一丟一丄丁丏 = "pb";
        MatchmakingConnect.丁丛丂丕与丅丏不上 = "sph";
        MatchmakingConnect.丄万丞七三丕丅丌丕 = "spc";
        MatchmakingConnect.世世上万丗丞丕且丝 = "spm";
        MatchmakingConnect.丈丅三丗丅且丅丏丄 = "spb";
        MatchmakingConnect.丛丟丅丒丒一一丅业 = "pa";
        MatchmakingConnect.三丄丈丄世丏丞丝丌 = "spa";
        MatchmakingConnect.丐万丘七专上丅丛丅 = "gg";
        MatchmakingConnect.丕与丌丂万一三丘丂 = "cl";
        MatchmakingConnect.万丂丞丌丛丂丅丑万 = "cn";
    }

}
