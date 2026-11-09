using UnityEngine;
public class SquadController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private static System.Action<Rilisoft.七丕丟丏三丈一丄世, object[]> 丛业丒世丕丙丈丌丁;
    internal const int 丞上丛丘丘丛丄与丄 = 30;
    internal const int 三丄丄丛丄丅丂丂东 = 5;
    internal const int 万不世丕下丐丗丅丂 = 4;
    private const int 丐丁世丘丁丄丏丞丙 = 3;
    internal static SquadController 丄丘七三上丕世丞业;
    internal static System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 丐专丛业丌丘与专丙;
    private GamePauseController 三丂丘丈丏丑丝下丕;
    private bool 丛丆丒且丛丘丙丞丞;
    private bool 不丒丒丏丞丏丛业丌;
    private 丛丗丐世下丛丄丞丟 丏东丕与丂丞七业丗;
    internal static 丛丗丐世下丛丄丞丟 上丂七上丘且丕且丈;
    private System.Action 丛丝与丂世丌丌丝丂;
    private System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 丛一丆专世丝丄丒与;
    private System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 丛丒丟且丒且万丛世;
    private System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 且丞丂丟丆丕丂世丕;
    private SquadController.万丅世丈丕丕丌丅丗 东丒世丂丒丌丆丑丛;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private Rilisoft.七丕丟丏三丈一丄世 三世一丁丑专与丙丅;
    private Rilisoft.七丕丟丏三丈一丄世 丝不丟丁丘丐丛一不;
    private SquadController.丛且丏丑丕丘丒丞且 世丄万丂七上丄丆业;
    private SquadController.丛且丏丑丕丘丒丞且 丑业业业丒丏丈丞下;
    private SquadController.丛且丏丑丕丘丒丞且 丗下丕丏丗丘丂丆业;
    private bool 上业丁丛丙丐丗丏丙;
    private bool 丞与丙丑丗万上丕丘;
    private int 丒丌下专专丁业丗丈;
    private SquadController.丛且丏丑丕丘丒丞且 上丂东丗丝丈业万丅;
    private bool 丁丄万丙专丒七丅不;
    private string 专丒不丈下东丝丝上;
    private int 丕丕三世世世一与丄;
    private SquadController.与业丁丈与东丏万丗 一三七丏丑丞且与丗;
    public string squadRoomName;
    internal static int 丘丘丙丗东丟丑业丟;
    private bool 丕丅丒丆丏丄丑丌业;
    private bool 丐一下专丒丂丕丕丙;
    private int 丝丁万且丞丗丞丗丙;
    private bool 下一丅丄丅与专万丘;
    private float 与三世丂丕丅一丄丄;
    private bool 丌丞丅下下丟世丙丌;
    private bool 三丑七丙丌丁三丈下;
    private bool 丞丕东上丆丏丆三七;
    private int 世丗万丏下丆专丁丏;
    internal static string 七丆丆丘业丝与丄业;
    internal static string 万一丘丗三三丈丗丛;
    internal static string 丕丙三丗丘丁丂丁丌;
    internal static bool 一丝一丄丛丙丁东专;
    internal static bool 丘业不丅万不丐东丝;
    internal static bool 丁丛专丂业丞丑丐专;
    internal static int 丏丛丈上丄丂丐上丒;
    internal static int 世与丄且三下不与丕;
    private static int 三且丟丑业万且且丄;
    internal static int 丄丟丐丁丑丏丂丅不;
    private bool 万且不丒不下丙丟与;
    private int 丛丂与丐东丕丟一一;
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> idToMessages;
    private bool 一世丘不丑丞东上丟;
    private PGCompany.丁下丒丕丆下丂丆丌 丐丌丞东上万万丈丂;
    private PGCompany.丟与丞丗丌丂万丕丝 丐丘丌三丏与丙且东;
    private PGCompany.丄丞丛丙丐东丅不丌 丏丂且七丅丄丗丅东;
    private string 下一世丛七丁且丂丆;
    internal static string 且丘三丈世丌丒万七;
    internal static string 丈丄下丛丅丗丛丐东;
    internal static Rilisoft.七丕丟丏三丈一丄世 万与丈世丝丙万丕一;
    private string[] 专丆专上丘丟丑丘东;
    private string[] 丙丂万专丄丙丏东丛;
    private static object[] 丅丐丝下丞下下下上;
    private string 丘下丄丗丕业专丟丘;
    public SquadPanelGUI squadUI;
    private int 不丒丗丒丝丟丁丒丗;
    private bool 且丏与丅七丁上且不;
    private Rilisoft.七丕丟丏三丈一丄世 丗丅丞上七丌且丝世;
    private bool 丄丌三丘丟丈且丛下;
    private System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 东丏东上七一万丆丌;
    private bool 丁丏丅丞东且丒下世;
    private bool 丁丈丆丟专丛且丐丘;
    private bool 丟一丁丐三丄丟丒丝;
    private bool 一且丑世丛三且下世;
    private bool 丞丙一世不丌专丏一;
    private int 专且万万丝丅上世丟;
    private int 丒丂万丕丐丑丏丈万;
    private float 丟世不丂且丌丈丟世;
    private bool 丆丏丐丐七丐万东丛;
    private int 下且东丄丒丘丁丌东;
    private System.Collections.Generic.List<string> 丅东丈丒丏丟万东丘;
    private System.Collections.Generic.List<string> 丁丑一丈丆丁丒丘丕;
    private System.Collections.Generic.List<int> 丏丝东丂万下七专丄;
    private float 丕万东丘丐丅上与七;
    private float 丒不丁丏丐丗丆丐三;
    private float 世万丏丏业不东丂一;
    private System.Action 下丐丂丟世世与东万;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> 与丂丞丅丂一下丈与;
    private System.Collections.Generic.HashSet<string> 专与丅丗丆丅上三一;
    private System.Collections.Generic.List<string> 丅万丘丒万不丄丅丁;
    
    // Properties
    public int 丐丌不丟三丄下丕丑 { get; }
    private bool 丁七万丟丆丟不万丗 { get; }
    public bool 专下一专丂与丗丁丗 { get; }
    public bool 丒且丁丏丒与丅专丈 { get; }
    public bool 丁世且丂不丕且下与 { get; }
    private SquadController.万丅世丈丕丕丌丅丗 丑丘丒丌丙丄世业丟 { get; }
    internal int 丈丄与丟丐业丗丛丕 { get; }
    internal Rilisoft.七丕丟丏三丈一丄世 七丆下丅丌丌丟与丄 { get; }
    internal static int 丟东丙东丅丝丕丐丌 { get; set; }
    internal PGCompany.丁下丒丕丆下丂丆丌 世东上万不丒且万万 { get; }
    internal PGCompany.丟与丞丗丌丂万丕丝 丄丗丝丟丕三丘丒七 { get; }
    internal PGCompany.丄丞丛丙丐东丅不丌 一一丝丐丌世丞丞世 { get; }
    public bool 丂丛丄丆丐东且一世 { get; }
    public bool 丙专七丘与丒丛丅丆 { get; }
    public bool 与不下丒丘上丒丗丟 { get; }
    public bool 丅业丞上丅丁与丞万 { get; }
    public bool 丈下丒且下丈丌丒丂 { get; }
    public bool 丐丏丕丆丘丞丘丝丆 { get; }
    private string 丘且丝万丙丕丙丁丙 { get; }
    private string 丅丝东丘丐丁丌丈丗 { get; }
    
    // Methods
    internal static void 丒丙世丕丌丞丙丁丗(System.Action<Rilisoft.七丕丟丏三丈一丄世, object[]> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  SquadController.丐丁世丘丁丄丏丞丙, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 东丕丛一丞丞丁丅丒(System.Action<Rilisoft.七丕丟丏三丈一丄世, object[]> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  SquadController.丐丁世丘丁丄丏丞丙, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public int get_PlayerCountForStart()
    {
        if(this.丏东丕与丂丞七业丗 == 2)
        {
                return 1;
        }
        
        if((this.丏东丕与丂丞七业丗 != 1) || (this.丝不丟丁丘丐丛一不 != 17))
        {
                return (int)(this.丏东丕与丂丞七业丗 != 3) ? (1 + 1) : 1;
        }
        
        return 1;
    }
    private bool 业专丗且丏丘丘三丐()
    {
        丛丗丐世下丛丄丞丟 val_1 = this.丏东丕与丂丞七业丗;
        val_1 = val_1 - 1;
        if(val_1 > 2)
        {
                return (bool)this.丛丆丒且丛丘丙丞丞;
        }
        
        return 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
    }
    public bool get_IsClanSquad()
    {
        丛丗丐世下丛丄丞丟 val_2 = this.丏东丕与丂丞七业丗;
        if(val_2 == 1)
        {
                return true;
        }
        
        val_2 = val_2 | 1;
        return (bool)(val_2 == 3) ? 1 : 0;
    }
    public bool get_IsClanWarSquad()
    {
        return (bool)(this.丏东丕与丂丞七业丗 == 2) ? 1 : 0;
    }
    public bool get_IsTestingSquad()
    {
        return (bool)(this.丏东丕与丂丞七业丗 == 3) ? 1 : 0;
    }
    private SquadController.万丅世丈丕丕丌丅丗 三丕丗丆丝下丝丘丈()
    {
        var val_4;
        List.Enumerator<T> val_1 = this.丛一丆专世丝丄丒与.GetEnumerator();
        label_4:
        if((1376944760 & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = 0.丐丏七丌丕丗业且上();
        if(val_4.业专丗且丏丘丘三丐() == false)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_4 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (万丅世丈丕丕丌丅丗);
    }
    internal int 丛丟万丅与丐万东丆()
    {
        if(this.丛一丆专世丝丄丒与 == null)
        {
                return (int)this.丛一丆专世丝丄丒与;
        }
        
        return this.丛一丆专世丝丄丒与.Count;
    }
    internal Rilisoft.七丕丟丏三丈一丄世 东丏丒且丁丆丄上丐()
    {
        return (Rilisoft.七丕丟丏三丈一丄世)this.丝不丟丁丘丐丛一不;
    }
    internal static int 丅丙丂丞丘东东丄丆()
    {
        null = null;
        return (int)SquadController.三且丟丑业万且且丄;
    }
    internal static void 丞丂不不业三一专丐(int 丙业与丙丗丝不丈东)
    {
        null = null;
        SquadController.三且丟丑业万且且丄 = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.丁下丒丕丆下丂丆丌 不丕且丌丝专万三下()
    {
        return (PGCompany.丁下丒丕丆下丂丆丌)this.丐丌丞东上万万丈丂;
    }
    internal PGCompany.丟与丞丗丌丂万丕丝 一东丏且七丙丗丛丄()
    {
        return (PGCompany.丟与丞丗丌丂万丕丝)this.丐丘丌三丏与丙且东;
    }
    internal PGCompany.丄丞丛丙丐东丅不丌 丝与丆不丙丌丂不一()
    {
        return (PGCompany.丄丞丛丙丐东丅不丌)this.丏丂且七丅丄丗丅东;
    }
    public bool get_isReady()
    {
        if(this.东丒世丂丒丌丆丑丛 == null)
        {
                return false;
        }
        
        return (bool)(this.东丒世丂丒丌丆丑丛.丂丛丄丆丐东且一世 == true) ? 1 : 0;
    }
    public bool get_inSquad()
    {
        SquadPanelGUI val_3;
        var val_4;
        val_3 = this;
        if(this.squadUI != 0)
        {
                val_3 = this.squadUI;
            var val_2 = (this.squadUI.isActive == true) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public bool get_isSquadLeader()
    {
        return this.业专丗且丏丘丘三丐();
    }
    public bool get_BlockGameModeSelect()
    {
        return (bool)this.下一丅丄丅与专万丘;
    }
    public bool get_CanKickPlayer()
    {
        var val_3;
        if(this.业专丗且丏丘丘三丐() != false)
        {
                var val_2 = (this.下一丅丄丅与专万丘 == false) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public bool get_HasWaitingPlayers()
    {
        return (bool)(this.丛丒丟且丒且万丛世.Count > 0) ? 1 : 0;
    }
    internal void 七丙一丘丛丒丟丝丗(System.Action 丛丝与丂世丌丌丝丂, PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘, bool 丟与丏丈丁东丅下丕 = False, string 丗不下业上下丆丑丑 = "")
    {
        object val_21;
        PGCompany.丁下丒丕丆下丂丆丌 val_22;
        var val_23;
        val_21 = 丗不下业上下丆丑丑;
        val_22 = 丌丝万上丅丒一丈丘;
        if((val_22 == null) || (val_22.下三下东业丘且丟业() == null))
        {
            goto label_2;
        }
        
        this.丐丌丞东上万万丈丂 = val_22;
        this.丏丂且七丅丄丗丅东 = 1;
        PGCompany.GameTaskActionSettings val_4 = val_22.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_4.GameMode != 22)
        {
            goto label_6;
        }
        
        val_23 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丙丆不上丂万丝丕();
        goto label_8;
        label_2:
        val_21 = mem[val_22 != null ? "Task is NULL" : "Cell"];
        val_21 = (val_22 != 0) ? "Task is NULL" : "Cell";
        UnityEngine.Debug.LogError(message:  val_21);
        return;
        label_6:
        val_23 = 0;
        label_8:
        PGCompany.GameTaskActionSettings val_10 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_10.GameMode == 27)
        {
                string val_11 = this.丐丌丞东上万万丈丂.下丁丙一丄丈不不丁();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_11)) != false)
        {
                PGCompany.一丝丐丕丒丛专七丄.丗丑丅下丘世丆三丄(丟丙丈丄丈丈丙丆三:  val_11);
        }
        
        }
        
        PGCompany.GameTaskActionSettings val_15 = val_22.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_22 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        this.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 上且丗一丏丏万丅丌:  val_18.GameMode, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  2, 丟与丏丈丁东丅下丕:  丟与丏丈丁东丅下丕, 丗不下业上下丆丑丑:  val_21, 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
    }
    internal void 不丂七上丁丙丗业丁(System.Action 丛丝与丂世丌丌丝丂, PGCompany.丟与丞丗丌丂万丕丝 且世上丙与丐一丛业, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, bool 丟与丏丈丁东丅下丕 = False, string 丗不下业上下丆丑丑 = "")
    {
        PGCompany.丟与丞丗丌丂万丕丝 val_7;
        var val_8;
        val_7 = 且世上丙与丐一丛业;
        this.丐丘丌三丏与丙且东 = val_7;
        this.丏丂且七丅丄丗丅东 = 2;
        val_8 = null;
        val_8 = null;
        AllScenesForMode val_1 = SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  上且丗一丏丏万丅丌);
        string val_3 = val_1.avaliableScenes.Item[0].丙且上丒不下丑下丞();
        this.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  2, 丟与丏丈丁东丅下丕:  丟与丏丈丁东丅下丕, 丗不下业上下丆丑丑:  丗不下业上下丆丑丑, 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
        if(上且丗一丏丏万丅丌 != 27)
        {
                return;
        }
        
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_7 = 0;
        goto label_10;
        label_9:
        val_7 = val_7.专东丏与万下丑丂丅();
        label_10:
        PGCompany.一丝丐丕丒丛专七丄.丗丑丅下丘世丆三丄(丟丙丈丄丈丈丙丆三:  PGCompany.丂丘丞丂丏七丁丄不.丒不世丌业不一丆丏(丄丝丏上丄丛丘丟丆:  val_7));
    }
    internal void 三丟丌下丅丝与丌丛(System.Action 丛丝与丂世丌丌丝丂, PGCompany.GameModeHub.丕业丞七丄七丒万东 一丐丛丏与丗七丂丐, bool 丌与一丌且一不七丆 = False, 丛丗丐世下丛丄丞丟 三丛业业专丄丟丄丅 = 0, bool 丟与丏丈丁东丅下丕 = False, string 丗不下业上下丆丑丑 = "", SquadController.丛且丏丑丕丘丒丞且 丞丁丑丏丄丏七丂不)
    {
        string val_6 = 丗不下业上下丆丑丑;
        Rilisoft.七丕丟丏三丈一丄世 val_2 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if((System.Enum.TryParse<Rilisoft.七丕丟丏三丈一丄世>(value:  一丐丛丏与丗七丂丐.ToString(), ignoreCase:  true, result: out  val_2)) != false)
        {
                丟与丏丈丁东丅下丕 = 丟与丏丈丁东丅下丕;
            this.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 上且丗一丏丏万丅丌:  val_2, 丌与一丌且一不七丆:  丌与一丌且一不七丆, 三丛业业专丄丟丄丅:  三丛业业专丄丟丄丅, 丟与丏丈丁东丅下丕:  丟与丏丈丁东丅下丕, 丗不下业上下丆丑丑:  val_6 = 丗不下业上下丆丑丑, 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅 = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅, 与丝丒万且丘丂丟三 = 丞丁丑丏丄丏七丂不.与丝丒万且丘丂丟三, 丑丐丗三丒世丏东丅 = val_2});
            return;
        }
        
        val_6 = System.String.Format(format:  "=== не удалось привести режим к GameMode типу: {0}", arg0:  null);
        UnityEngine.Debug.Log(message:  val_6);
    }
    internal void 丛丒万丟专且世且丟(System.Action 丛丝与丂世丌丌丝丂, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, bool 丌与一丌且一不七丆 = False, 丛丗丐世下丛丄丞丟 三丛业业专丄丟丄丅 = 0, bool 丟与丏丈丁东丅下丕 = False, string 丗不下业上下丆丑丑 = "", SquadController.丛且丏丑丕丘丒丞且 丞丁丑丏丄丏七丂不)
    {
        var val_19;
        var val_20;
        var val_21;
        MainMenuController val_22;
        var val_23;
        Rilisoft.七丕丟丏三丈一丄世 val_24;
        var val_25;
        var val_26;
        val_19 = 1152921540346079808;
        if(((上且丗一丏丏万丅丌 & 4294967294) == 26) && (this.丏东丕与丂丞七业丗 == 2))
        {
                if(this.丐丘丌三丏与丙且东 != null)
        {
                if((this.丐丘丌三丏与丙且东 & 1) != 0)
        {
            goto label_4;
        }
        
        }
        
            this.ExitFromSquadPanel();
        }
        
        label_4:
        val_20 = null;
        val_20 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_21 = null;
            val_21 = null;
            val_22 = MainMenuController.丄丞丁丈与业上丞丟;
            val_22.LoadSquadPanel();
        }
        
        if(丟与丏丈丁东丅下丕 == false)
        {
            goto label_13;
        }
        
        val_23 = null;
        val_23 = null;
        val_22 = this.丏丂且七丅丄丗丅东;
        label_61:
        this.三世一丁丑专与丙丅 = SquadController.万与丈世丝丙万丕一;
        if(((三丛业业专丄丟丄丅 != 2) || (val_22 != 2)) || (this.丗丅丞上七丌且丝世 == 100))
        {
            goto label_24;
        }
        
        this.丘一丕丘丌上丌丂上(丅一丞万丑专丅丅与:  this.一丗与丈丄丁东丄与());
        val_24 = this.丗丅丞上七丌且丝世;
        goto label_19;
        label_13:
        if(三丛业业专丄丟丄丅 < 2)
        {
            goto label_23;
        }
        
        if(三丛业业专丄丟丄丅 == 2)
        {
            goto label_21;
        }
        
        if(三丛业业专丄丟丄丅 != 3)
        {
            goto label_24;
        }
        
        if(上且丗一丏丏万丅丌 != 100)
        {
            goto label_23;
        }
        
        val_24 = this.丝不丟丁丘丐丛一不;
        label_19:
        this.三世一丁丑专与丙丅 = val_24;
        goto label_24;
        label_23:
        this.三世一丁丑专与丙丅 = 上且丗一丏丏万丅丌;
        label_24:
        this.上业丁丛丙丐丗丏丙 = true;
        丌与一丌且一不七丆 = 丌与一丌且一不七丆;
        this.下一世丛七丁且丂丆 = 丗不下业上下丆丑丑;
        this.一世丘不丑丞东上丟 = 丟与丏丈丁东丅下丕;
        this.丁上不且丐丙丂丐上(丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 丁七万丟丆丟不万丗:  (~丟与丏丈丁东丅下丕) & 1, 丌与一丌且一不七丆:  丌与一丌且一不七丆, 丏东丕与丂丞七业丗:  三丛业业专丄丟丄丅);
        val_25 = null;
        val_26 = 1152921504848912384;
        与丂丏丛丞丞丒丟丄.丘且丝万丙丕丙丁丙 = System.String.alignConst;
        if(三丛业业专丄丟丄丅 > 3)
        {
            goto label_28;
        }
        
        var val_19 = 106014280 + (三丛业业专丄丟丄丅) << 2;
        val_19 = val_19 + 106014280;
        goto (106014280 + (三丛业业专丄丟丄丅) << 2 + 106014280);
        label_28:
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (丌与一丌且一不七丆 != true) ? "Key_3487" : "Key_3478"), 丞丁上丛与丌一一丐:  true, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
        if(丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅 != 0)
        {
                this.丞与丙丑丗万上丕丘 = true;
            mem[1152921540346031584] = 丞丁丑丏丄丏七丂不.与丝丒万且丘丂丟三;
            this.丗下丕丏丗丘丂丆业 = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅;
        }
        
        Rilisoft.七丕丟丏三丈一丄世 val_20 = this.三世一丁丑专与丙丅;
        val_20 = val_20 & 4294967294;
        if(val_20 != 26)
        {
                return;
        }
        
        万专丙丌丌丐上丟三.不下丑丆丐且丆下与();
        return;
        label_21:
        if((this.丏丂且七丅丄丗丅东 != 1) || (this.丐丌丞东上万万丈丂 == null))
        {
            goto label_61;
        }
        
        PGCompany.GameTaskActionSettings val_18 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if((this == null) || (this.丏丂且七丅丄丗丅东 != 1))
        {
            goto label_60;
        }
        
        goto label_61;
        label_60:
    }
    public void JoinSquad(System.Action 丛丝与丂世丌丌丝丂, string 丐一三丞丝丌不丏丑)
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_9 = null;
            val_9 = null;
            MainMenuController.丄丞丁丈与业上丞丟.LoadSquadPanel();
        }
        
        this.一世丘不丑丞东上丟 = false;
        this.丁上不且丐丙丂丐上(丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 丁七万丟丆丟不万丗:  false, 丌与一丌且一不七丆:  false, 丏东丕与丂丞七业丗:  0);
        this.squadRoomName = 丐一三丞丝丌不丏丑;
        bool val_2 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  丐一三丞丝丌不丏丑);
        if(this.丏东丕与丂丞七业丗 == 2)
        {
                this.丘一丕丘丌上丌丂上(丅一丞万丑专丅丅与:  this.squadRoomName);
        }
        
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3479"), 丞丁上丛与丌一一丐:  true, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
        丛丗丐世下丛丄丞丟 val_8 = this.丏东丕与丂丞七业丗;
        val_8 = val_8 | 1;
        Rilisoft.一丟专且三万丞丁丂.东丐上丘丝丘丂丂丛(丙世不不一丏业三且:  ((val_8 == 1) ? 1 : 0) | ((val_8 == 3) ? 1 : 0));
    }
    public void SendChatMessage(string 丕丗丘丑丛与丑业丒, string 丛丐丌丙丈七丛丛东)
    {
        string val_16;
        ClanChatController val_17;
        System.Object[] val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        var val_23;
        var val_24;
        var val_25;
        val_16 = 丛丐丌丙丈七丛丛东;
        val_17 = this;
        if(丕丗丘丑丛与丑业丒.Length > 50)
        {
                return;
        }
        
        val_18 = 1152921505312063488;
        string val_2 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  丕丗丘丑丛与丑业丒);
        val_19 = val_2;
        if((System.String.IsNullOrEmpty(value:  val_2)) != false)
        {
                if((System.String.IsNullOrEmpty(value:  val_16)) == true)
        {
                return;
        }
        
        }
        
        val_20 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  ProfileController.丆三丂丂丆上丆丕专());
        if(val_20.Length >= 21)
        {
                val_20 = val_20.Substring(startIndex:  0, length:  20);
        }
        
        string val_9 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != false)
        {
                val_16 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "SendChatMessage deviceId.IsNullOrEmpty()", args:  val_16);
            return;
        }
        
        object[] val_12 = new object[5];
        val_18 = val_12;
        if(val_20 == null)
        {
            goto label_20;
        }
        
        if(val_18 != null)
        {
            goto label_23;
        }
        
        goto label_22;
        label_20:
        val_20 = System.String.alignConst;
        if(val_18 != null)
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        val_18[0] = val_20;
        val_21 = val_19;
        if(val_19 != null)
        {
            goto label_27;
        }
        
        val_21 = System.String.alignConst;
        if(val_21 == 0)
        {
            goto label_29;
        }
        
        label_27:
        label_29:
        val_18[1] = val_21;
        val_22 = val_16;
        if(val_16 != null)
        {
            goto label_31;
        }
        
        val_22 = System.String.alignConst;
        if(val_22 == 0)
        {
            goto label_33;
        }
        
        label_31:
        label_33:
        val_18[2] = val_22;
        val_18[3] = val_9;
        val_18[4] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  55, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
        丛丗丐世下丛丄丞丟 val_16 = this.丏东丕与丂丞七业丗;
        val_16 = val_16 - 1;
        if(val_16 >= 3)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        val_17 = ClanChatController.丄丞丁丈与业上丞丟;
        if(val_17 == 0)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        val_17 = ClanChatController.丄丞丁丈与业上丞丟;
        if(val_19 == null)
        {
                val_19 = System.String.alignConst;
        }
        
        val_25 = null;
        val_25 = null;
        val_16 = 与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄 + val_16;
        val_17.SendChatMessage(丕丗丘丑丛与丑业丒:  val_19, 丛丐丌丙丈七丛丛东:  val_16);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_16;
        int val_17;
        var val_23;
        var val_24;
        var val_25;
        string val_26;
        var val_27;
        int val_28;
        var val_29;
        与丅丕丈丘东丝世丟 val_30;
        var val_31;
        var val_32;
        var val_33;
        bool val_34;
        var val_44;
        val_16 = 丞世不丒下上上丝丑;
        byte val_1 = val_16 & 255;
        if(val_1 > 110)
        {
            goto label_1;
        }
        
        if(val_1 == 55)
        {
            goto label_2;
        }
        
        if(val_1 != 110)
        {
            goto label_40;
        }
        
        val_17 = 专丒丌丆下丐丞丟丞.Length;
        if(val_17 == 0)
        {
                val_17 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_16 = 专丒丌丆下丐丞丟丞[0];
        if(val_16 != null)
        {
                val_16 = 0;
        }
        
        this.不一丒丛丁东下七丌(不丟丗丏丛丕不丁丌:  val_16, 世下丂且专丝丝下世:  专丒丌丆下丐丞丟丞[1]);
        goto label_123;
        label_1:
        if((val_1 - 129) > 8)
        {
            goto label_11;
        }
        
        var val_17 = 106014296;
        val_17 = (106014296 + (((丞世不丒下上上丝丑 & 255) - 129)) << 2) + val_17;
        goto (106014296 + (((丞世不丒下上上丝丑 & 255) - 129)) << 2 + 106014296);
        label_2:
        val_16 = 专丒丌丆下丐丞丟丞[0];
        if(专丒丌丆下丐丞丟丞.Length <= 1)
        {
                val_23 = 0;
        }
        
        if(专丒丌丆下丐丞丟丞.Length <= 2)
        {
                val_24 = 0;
        }
        
        val_26 = 专丒丌丆下丐丞丟丞[2];
        if(专丒丌丆下丐丞丟丞.Length <= 3)
        {
                val_25 = 0;
        }
        
        if(专丒丌丆下丐丞丟丞.Length <= 4)
        {
                val_27 = 0;
        }
        
        this.万业丏丟上上万世下(不丆业丏上丐与丌业:  val_16, 丕丗丘丑丛与丑业丒:  专丒丌丆下丐丞丟丞[1], 丗丐丕万丏不下世丕:  val_26, 与业丒东丛世三丞世:  专丒丌丆下丐丞丟丞[3], 丞丅上丏丂且下丅与:  专丒丌丆下丐丞丟丞[4]);
        goto label_123;
        label_11:
        if(val_1 != 161)
        {
            goto label_40;
        }
        
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_41;
        }
        
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_124;
        }
        
        label_125:
        label_124:
        val_16 = 专丒丌丆下丐丞丟丞[0];
        object val_29 = 专丒丌丆下丐丞丟丞[1];
        val_26 = 专丒丌丆下丐丞丟丞[2];
        object val_30 = 专丒丌丆下丐丞丟丞[3];
        if(专丒丌丆下丐丞丟丞.Length >= 5)
        {
            goto label_49;
        }
        
        if(val_16 != null)
        {
                val_16 = 0;
        }
        
        val_28 = 1152921504622075904;
        val_30 = val_16;
        val_31 = 1152921504628731904;
        val_32 = 1152921504628731904;
        val_33 = 0;
        goto label_53;
        label_40:
        val_34 = 0;
        return (bool)val_34;
        label_49:
        val_44 = mem[专丒丌丆下丐丞丟丞 + 24];
        val_44 = 专丒丌丆下丐丞丟丞 + 24;
        if(val_44 <= 4)
        {
                val_44 = mem[专丒丌丆下丐丞丟丞 + 24];
            val_44 = 专丒丌丆下丐丞丟丞 + 24;
        }
        
        object val_34 = 专丒丌丆下丐丞丟丞[4];
        object val_35 = 专丒丌丆下丐丞丟丞[5];
        if(val_16 != null)
        {
                val_16 = 0;
        }
        
        val_30 = val_16;
        val_31 = 1152921504628731904;
        val_32 = 1152921504628731904;
        val_29 = 1152921504628731904;
        val_33 = 1152921504628731904;
        label_53:
        this.上丛丂丏丗丏三丅丁(不丟丗丏丛丕不丁丌:  val_30, 业万上丆丐丞且丒七:  21884928, 丂丛丑东不丅丈一东:  21884928, 丞丁丑丏丄丏七丂不:  21884928, 专世专丟丝丌与丘上:  21884928, 丗丘丆丄丝与东下上:  3.782474E-38f);
        goto label_123;
        label_41:
        if(28563616 != 0)
        {
            goto label_124;
        }
        
        goto label_125;
        label_123:
        val_34 = 1;
        return (bool)val_34;
    }
    private void 丄丘丒万不丄东丝七(UnityEngine.Vector2 丙丗丄万丒丏丟丈三)
    {
        DiscreteVector2 val_2 = new DiscreteVector2(丘丑丛丕下丈世下丂:  new UnityEngine.Vector2() {x = 丙丗丄万丒丏丟丈三.x, y = 丙丗丄万丒丏丟丈三.y});
        PGCompany.丁下丒丕丆下丂丆丌 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(专丘丏丅且丆万东丈:  new DiscreteVector2() {_x = val_2._x, _y = val_2._x});
        if(val_3 != null)
        {
                this.丐丌丞东上万万丈丂 = val_3;
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  val_3);
            PGCompany.GameTaskActionSettings val_7 = val_3.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            mem[1152921540347143696] = 0;
            this.丞与丙丑丗万上丕丘 = true;
            this.丗下丕丏丗丘丂丆业 = 0;
            return;
        }
        
        this = "Cell with coords " + 丙丗丄万丒丏丟丈三.x + " is NULL";
        UnityEngine.Debug.LogError(message:  this);
    }
    private void 万专东丙三丞丝丅一(int 丞丅上丏丂且下丅与)
    {
        object val_15;
        var val_16;
        SquadController.丆丕丒不丕不丘丞丒 val_1 = null;
        val_15 = val_1;
        val_1 = new SquadController.丆丕丒不丕不丘丞丒();
        .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        PGCompany.丟与丞丗丌丂万丕丝 val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丟与丞丗丌丂万丕丝>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丟丛上丅七丂七丛下(), predicate:  new System.Func<PGCompany.丟与丞丗丌丂万丕丝, System.Boolean>(object:  val_1, method:  System.Boolean SquadController.丆丕丒不丕不丘丞丒::与丄与一丂丁一下专(PGCompany.丟与丞丗丌丂万丕丝 三丟东丕丄丄下下丑)));
        if(val_5 != null)
        {
                this.丐丘丌三丏与丙且东 = val_5;
            PGCompany.丂不上丗与丌与丐丌 val_6 = val_5.不业丙丒丂丞下丆丙();
            Rilisoft.七丕丟丏三丈一丄世 val_8 = (val_6 == 1) ? 26 : ((val_6 == 2) ? 27 : 100);
            this.丗丅丞上七丌且丝世 = val_8;
            if(val_8 == 100)
        {
                return;
        }
        
            val_16 = null;
            val_16 = null;
            val_15 = SceneInfoController.丄丘七三上丕世丞业;
            AllScenesForMode val_9 = val_15.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_8);
            string val_11 = val_9.avaliableScenes.Item[0].丙且上丒不下丑下丞();
            mem[1152921540347340896] = 0;
            this.丞与丙丑丗万上丕丘 = true;
            this.丗下丕丏丗丘丂丆业 = 0;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Event with ID " + .丞丅上丏丂且下丅与.ToString() + " is NULL or Not Active");
        this.丗丅丞上七丌且丝世 = 100;
    }
    internal void 专万且业丕专丐丗一(string 丅一丞万丑专丅丅与)
    {
        string val_8 = 丅一丞万丑专丅丅与;
        丛丗丐世下丛丄丞丟 val_4 = 0;
        string[] val_1 = new string[1];
        val_1[0] = "_";
        System.String[] val_2 = val_8.Split(separator:  val_1, options:  1);
        if(val_2.Length != 0)
        {
                var val_8 = -4294967296;
            val_8 = val_8 + ((val_2.Length) << 32);
            if((((System.Enum.TryParse<丛丗丐世下丛丄丞丟>(value:  val_2[val_8 >> 32], result: out  val_4)) != false) && (0 == 3)) && (val_2.Length == 3))
        {
                if(((System.Int32.TryParse(s:  val_2[1], result: out  val_4)) != false) && (0 == 26))
        {
                this.丝不丟丁丘丐丛一不 = 0;
            return;
        }
        
        }
        
        }
        
        val_8 = "Malformed Room Name " + val_8 + " for Clan War Test Mode Squad";
        UnityEngine.Debug.LogError(message:  val_8);
    }
    internal void 丘一丕丘丌上丌丂上(string 丅一丞万丑专丅丅与)
    {
        this.丘一丕丘丌上丌丂上(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与, 丂七丒丈且东七丅丅:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void SquadController::丄丘丒万不丄东丝七(UnityEngine.Vector2 丙丗丄万丒丏丟丈三)), 丗业万丌三且丙丅上:  new System.Action<System.Int32>(object:  this, method:  System.Void SquadController::万专东丙三丞丝丅一(int 丞丅上丏丂且下丅与)));
    }
    internal void 丘一丕丘丌上丌丂上(string 丅一丞万丑专丅丅与, System.Action<UnityEngine.Vector2> 丂七丒丈且东七丅丅, System.Action<int> 丗业万丌三且丙丅上)
    {
        object val_15;
        var val_17;
        val_15 = this;
        PGCompany.丄丞丛丙丐东丅不丌 val_4 = 0;
        int val_8 = 0;
        string[] val_1 = new string[1];
        val_1[0] = "_";
        System.String[] val_2 = 丅一丞万丑专丅丅与.Split(separator:  val_1, options:  1);
        if(val_2.Length == 0)
        {
            goto label_7;
        }
        
        var val_15 = -4294967296;
        val_15 = val_15 + ((val_2.Length) << 32);
        string val_16 = val_2[val_15 >> 32];
        if((System.Enum.TryParse<PGCompany.丄丞丛丙丐东丅不丌>(value:  val_16, result: out  val_4)) == false)
        {
            goto label_11;
        }
        
        if(val_4 == 2)
        {
            goto label_12;
        }
        
        if(val_4 != 1)
        {
            goto label_13;
        }
        
        if(val_2.Length != 4)
        {
            goto label_27;
        }
        
        if(((System.Int32.TryParse(s:  val_2[1], result: out  0)) == false) || ((System.Int32.TryParse(s:  val_2[2], result: out  val_8)) == false))
        {
            goto label_17;
        }
        
        if(丂七丒丈且东七丅丅 == null)
        {
            goto label_27;
        }
        
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0f, y:  0f);
        丂七丒丈且东七丅丅.Invoke(obj:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        goto label_27;
        label_7:
        string val_11 = "Malformed Room Name " + 丅一丞万丑专丅丅与 + " for Clan War Squad";
        goto label_20;
        label_11:
        label_31:
        label_20:
        val_15 = "Wrong ClanWarSquadDataType " + val_16;
        UnityEngine.Debug.LogError(message:  val_15);
        return;
        label_12:
        if(val_2.Length != 3)
        {
            goto label_27;
        }
        
        if((System.Int32.TryParse(s:  val_2[1], result: out  val_8)) == false)
        {
            goto label_25;
        }
        
        if(丗业万丌三且丙丅上 == null)
        {
            goto label_27;
        }
        
        丗业万丌三且丙丅上.Invoke(obj:  0);
        goto label_27;
        label_13:
        UnityEngine.Debug.LogError(message:  "Wrong ClanWarSquadDataType " + val_16);
        label_27:
        this.丏丂且七丅丄丗丅东 = val_4;
        return;
        label_17:
        val_17 = "Wrong cell coords in Room Name ";
        goto label_31;
        label_25:
        val_17 = "Wrong event id in Room Name ";
        goto label_31;
    }
    private void 万业丏丟上上万世下(string 不丆业丏上丐与丌业, string 丕丗丘丑丛与丑业丒, string 丗丐丕万丏不下世丕, string 与业丒东丛世三丞世, string 丞丅上丏丂且下丅与)
    {
        string val_6;
        var val_7;
        if(this.squadUI == 0)
        {
                return;
        }
        
        val_6 = 丕丗丘丑丛与丑业丒;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丗丘丑丛与丑业丒)) != false)
        {
                val_7 = null;
            val_7 = null;
            val_6 = 与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄 + 丗丐丕万丏不下世丕;
        }
        
        this.世专万丕且丛丁丘丐(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丌一一七丗丗七下七:  val_6);
        与业丒东丛世三丞世 = System.String.op_Equality(a:  与业丒东丛世三丞世, b:  UnityEngine.SystemInfo.deviceUniqueIdentifier);
        this.squadUI.AddChatMessage(不丆业丏上丐与丌业:  不丆业丏上丐与丌业, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丛丐丌丙丈七丛丛东:  丗丐丕万丏不下世丕, 七业丘丁丄且丂七专:  与业丒东丛世三丞世);
    }
    private void 世专万丕且丛丁丘丐(string 丞丅上丏丂且下丅与, string 丌一一七丗丗七下七)
    {
        if((this.idToMessages.ContainsKey(key:  丞丅上丏丂且下丅与)) != true)
        {
                this.idToMessages.Add(key:  丞丅上丏丂且下丅与, value:  new System.Collections.Generic.List<System.String>());
        }
        
        this.idToMessages.Item[丞丅上丏丂且下丅与].Add(item:  丌一一七丗丗七下七);
    }
    private void 丁上不且丐丙丂丐上(System.Action 丛丝与丂世丌丌丝丂, bool 丁七万丟丆丟不万丗, bool 丌与一丌且一不七丆, 丛丗丐世下丛丄丞丟 丏东丕与丂丞七业丗)
    {
        var val_7;
        this.丄丌三丘丟丈且丛下 = false;
        this.三丑七丙丌丁三丈下 = false;
        this.万且不丒不下丙丟与 = false;
        mem[1152921540348535928] = 0;
        this.丝丁万且丞丗丞丗丙 = 0;
        this.丑业业业丒丏丈丞下 = 0;
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  true);
        this.不丒丒丏丞丏丛业丌 = 丌与一丌且一不七丆;
        this.丏东丕与丂丞七业丗 = 丏东丕与丂丞七业丗;
        this.squadRoomName = "";
        val_7 = null;
        val_7 = null;
        SquadController.上丂七上丘且丕且丈 = 丏东丕与丂丞七业丗;
        this.丛丆丒且丛丘丙丞丞 = 丁七万丟丆丟不万丗;
        this.丁丄万丙专丒七丅不 = false;
        this.丐一下专丒丂丕丕丙 = false;
        this.丌丞丅下下丟世丙丌 = false;
        this.下一丅丄丅与专万丘 = false;
        this.与三世丂丕丅一丄丄 = 0f;
        this.丒丌下专专丁业丗丈 = 0;
        SquadController.丄丟丐丁丑丏丂丅不 = 0;
        this.丛一丆专世丝丄丒与 = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>(capacity:  5);
        this.丛丒丟且丒且万丛世 = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>(capacity:  5);
        this.且丞丂丟丆丕丂世丕 = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>(capacity:  5);
        this.专与丅丗丆丅上三一.Clear();
        this.东丒世丂丒丌丆丑丛 = 0;
        this.丞丕东上丆丏丆三七 = false;
        this.丛丝与丂世丌丌丝丂 = 丛丝与丂世丌丌丝丂;
        this.OnEnterSquad();
        if(this.squadUI != 0)
        {
                this.squadUI.ClearChat();
        }
        
        this.丏专丘上世东丆丅丏();
    }
    private void 与上东丑丞丈丗丑一()
    {
        this.丈万丛丈丏丝丐丙下(业丄丒丑一丙丛丆丕:  0);
    }
    private void 丈万丛丈丏丝丐丙下(与丅丕丈丘东丝世丟 业丄丒丑一丙丛丆丕)
    {
        object val_31;
        object[] val_1 = new object[9];
        if(业丄丒丑一丙丛丆丕 != null)
        {
                val_1[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            val_1[1] = this.业专丗且丏丘丘三丐();
            val_1[2] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            val_1[3] = ProfileController.丆三丂丂丆上丆丕专();
            val_1[4] = ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂();
            val_1[5] = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
            val_1[6] = UnityEngine.Mathf.Min(a:  BankController.丈丐业丈丄丕丕三世(), b:  100);
            val_1[7] = 业丂丏与世一丏业不.丑七不且上丗丁一世().三世丑三万丄丌丕丌();
            val_31 = ExperienceController.丂丂下丑且下丌丝东();
            val_1[8] = val_31;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  129, 万丌万丅专丞业丈万:  业丄丒丑一丙丛丆丕, 丗丟上上丒丐丗丞丙:  val_1);
            this.业不与下与上丞丒世(业丄丒丑一丙丛丆丕:  业丄丒丑一丙丛丆丕);
            return;
        }
        
        val_1[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_1[1] = this.业专丗且丏丘丘三丐();
        val_1[2] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_1[3] = ProfileController.丆三丂丂丆上丆丕专();
        val_31 = 1152921504622075904;
        val_1[4] = ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂();
        val_1[5] = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        val_1[6] = UnityEngine.Mathf.Min(a:  BankController.丈丐业丈丄丕丕三世(), b:  100);
        val_1[7] = 业丂丏与世一丏业不.丑七不且上丗丁一世().三世丑三万丄丌丕丌();
        val_1[8] = ExperienceController.丂丂下丑且下丌丝东();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  129, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
        this.业不与下与上丞丒世(业丄丒丑一丙丛丆丕:  0);
        this.丛丂与丐东丕丟一一 = BankController.丈丐业丈丄丕丕三世();
    }
    private void 业不与下与上丞丒世(与丅丕丈丘东丝世丟 业丄丒丑一丙丛丆丕)
    {
        object[] val_1 = new object[2];
        if(业丄丒丑一丙丛丆丕 != null)
        {
                val_1[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            val_1[1] = DungeonWindowUI.丑丄且业丕丌丈且专();
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  110, 万丌万丅专丞业丈万:  业丄丒丑一丙丛丆丕, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        val_1[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_1[1] = DungeonWindowUI.丑丄且业丕丌丈且专();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  110, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丄丘丘丞万且丅一丈()
    {
        this.丏专丘上世东丆丅丏();
        this.业不与下与上丞丒世(业丄丒丑一丙丛丆丕:  0);
    }
    private void 丕世丛业丌丗丗丕丁()
    {
        ShopNGUIController val_13;
        var val_14;
        ShopNGUIController val_15;
        var val_16;
        if((BankController.丑七不且上丗丁一世() != 0) && (BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false))
        {
                if(BankController.丑七不且上丗丁一世().丅丘专丅丏丏丆业三() != 0)
        {
                AbstractBankView val_9 = BankController.丑七不且上丗丁一世().丅丘专丅丏丏丆业三();
            val_9.backButton.DoClick();
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        }
        
        }
        
        val_13 = 1152921505261211648;
        val_14 = null;
        val_14 = null;
        val_15 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_15 == 0)
        {
                return;
        }
        
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_16 = null;
        val_13 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_16 = null;
        val_15 = SquadController.<>c.<>9__134_0;
        if(val_15 == null)
        {
            goto label_31;
        }
        
        label_36:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = val_15;
        return;
        label_31:
        SquadController.<>c.<>9__134_0 = new System.Action(object:  SquadController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SquadController.<>c::东且七丌丑丟丘且不());
        if(val_13 != null)
        {
            goto label_36;
        }
        
        goto label_36;
    }
    private void 万丄东七丒专丕丒丛(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, bool 下世与丈丐一丆丒万, string 丆世丘丒丒丏上且丗, string 丛三三与丁丘丄丑下, int 专世专丟丝丌与丘上, int 丈丐世下丞与丂专丏, int 下专世下且丂东东丁, string 丂丒丘丅专丗丂世丛, int 上丕丈丞丌丘丅不与)
    {
        var val_14;
        System.Collections.Generic.List<万丅世丈丕丕丌丅丗> val_15;
        丛丗丐世下丛丄丞丟 val_14 = this.丏东丕与丂丞七业丗;
        val_14 = val_14 | 1;
        SquadController.万丅世丈丕丕丌丅丗 val_5 = new SquadController.万丅世丈丕丕丌丅丗(专丞上七七且丝七丗:  专丞上七七且丝七丗, 不丒丈丅丟丑丟丒业:  ((val_14 == 1) ? 1 : 0) | ((val_14 == 3) ? 1 : 0), 丁三上丂丅丏丏丁丕:  下世与丈丐一丆丒万, 丆世丘丒丒丏上且丗:  丆世丘丒丒丏上且丗, 丛三三与丁丘丄丑下:  丛三三与丁丘丄丑下, 专世专丟丝丌与丘上:  专世专丟丝丌与丘上, 丈丐世下丞与丂专丏:  丈丐世下丞与丂专丏, 丂丒丘丅专丗丂世丛:  丂丒丘丅专丗丂世丛, 万丛与丒丑丈七东丐:  System.String.alignConst, 上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与);
        与丅丕丈丘东丝世丟 val_6 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if((val_6.Equals(丘丛丏丘丝七世七丅:  专丞上七七且丝七丗)) != false)
        {
                this.东丒世丂丒丌丆丑丛 = val_5;
        }
        
        if(val_5.业专丗且丏丘丘三丐() != false)
        {
                this.不与丞上丛丂丂丞丑();
        }
        
        if(this.丛一丆专世丝丄丒与.Count >= 5)
        {
                UnityEngine.Debug.LogError(message:  "Max players in squad reached");
        }
        
        val_14 = 0;
        goto label_11;
        label_16:
        val_15 = val_6.Item[0];
        if((System.String.op_Equality(a:  val_10.丆世丘丒丒丏上且丗, b:  丆世丘丒丒丏上且丗)) == true)
        {
            goto label_13;
        }
        
        val_14 = 1;
        label_11:
        val_15 = this.丛一丆专世丝丄丒与;
        if(val_14 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_16;
        }
        
        val_15.Add(item:  val_5);
        goto label_17;
        label_13:
        this.丛一丆专世丝丄丒与.set_Item(index:  0, value:  val_5);
        label_17:
        if(this.业专丗且丏丘丘三丐() != false)
        {
                this.丗上丝丂业丑丕丗丛();
        }
        
        this.丄丕丛万丝三丌专丕();
    }
    private void 丂丂丗丛丑一丂万上(int 上且丗一丏丏万丅丌)
    {
        int val_9;
        int val_10;
        var val_11;
        this.丝不丟丁丘丐丛一不 = 上且丗一丏丏万丅丌;
        bool val_1 = System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  GameConnect.丘丗世专不丅与丗丒, value:  上且丗一丏丏万丅丌);
        bool val_2 = val_1;
        this.不丒丒丏丞丏丛业丌 = val_2;
        this.squadUI.SetViewMiniGameGUI(丅丛丝下丙且上七万:  val_2);
        this.三丂业丞丞丐丒世丁();
        this.squadUI.世上万不丐丄丂且万(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不);
        if(this.丝不丟丁丘丐丛一不 != 上且丗一丏丏万丅丌)
        {
                if(this.丑业业业丒丏丈丞下 != 0)
        {
                this.squadUI.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丑业业业丒丏丈丞下, 丐且丘丑与万丞丑丅 = this.丑业业业丒丏丈丞下, 与丝丒万且丘丂丟三 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished});
        }
        
        }
        
        if(val_1 == false)
        {
            goto label_10;
        }
        
        if((BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  this.丝不丟丁丘丐丛一不)) == null)
        {
            goto label_13;
        }
        
        val_9 = val_4.丏上专丐三丛丁丗丆;
        goto label_14;
        label_10:
        val_10 = 0;
        val_11 = 0;
        this.丒丌下专专丁业丗丈 = 0;
        goto label_15;
        label_13:
        val_9 = 0;
        label_14:
        this.丒丌下专专丁业丗丈 = val_9;
        val_10 = this.丒丌下专专丁业丗丈;
        label_15:
        this.squadUI.SetMiniGamesPriceActive(丅丛丝下丙且上七万:  val_1, 下专世下且丂东东丁:  val_10, 丅丙丗下丑不丞与丄:  (BankController.丈丐业丈丄丕丕三世() < val_10) ? 1 : 0);
        this.丏专丘上世东丆丅丏();
        this.丌与丛丟丏丕万丁七();
        this.丄一丁三万丅丅丕丄(丝三丗丁七丄丘丌丒:  0);
    }
    private void 三丞丕且万一业丕专(int 丛且丞与丕业下丏丞, int 万丏丑下三丗万丙三, int 与丝丒万且丘丂丟三)
    {
        丛且丏丑丕丘丒丞且 val_4;
        object val_5;
        val_4 = 与丝丒万且丘丂丟三;
        val_5 = this;
        if(丛且丞与丕业下丏丞 == 1)
        {
            goto label_1;
        }
        
        this.丑业业业丒丏丈丞下 = 0;
        mem[1152921540350149192] = 0;
        val_4 = this.丑业业业丒丏丈丞下;
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        val_5 = "Error finding scene with index: "("Error finding scene with index: ") + 丛且丞与丕业下丏丞;
        UnityEngine.Debug.LogError(message:  val_5);
        return;
        label_1:
        mem[1152921540350149192] = 0;
        this.丑业业业丒丏丈丞下 = 0;
        this.squadUI.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
        return;
        label_4:
        this.squadUI.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丑业业业丒丏丈丞下.丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅 = this.丑业业业丒丏丈丞下.丏丈丗世丙万丆丐丅, 与丝丒万且丘丂丟三 = this.丑业业业丒丏丈丞下.与丝丒万且丘丂丟三});
        this.丏专丘上世东丆丅丏();
        this.丌与丛丟丏丕万丁七();
        this.丄一丁三万丅丅丕丄(丝三丗丁七丄丘丌丒:  0);
    }
    private void 丄一丁三万丅丅丕丄(与丅丕丈丘东丝世丟 丝三丗丁七丄丘丌丒)
    {
        object val_19;
        PhotonView val_20;
        System.Object[] val_21;
        丛且丏丑丕丘丒丞且 val_22;
        var val_23;
        var val_24;
        object val_25;
        object val_26;
        val_19 = this;
        if(this.丏东丕与丂丞七业丗 != 2)
        {
            goto label_1;
        }
        
        if(this.丗下丕丏丗丘丂丆业 == 0)
        {
                return;
        }
        
        val_20 = this.丄丈丑丐丆丞丘与丗;
        val_21 = new object[4];
        if(丝三丗丁七丄丘丌丒 == null)
        {
            goto label_5;
        }
        
        val_21[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_22 = 1152921504622075904;
        val_21[1] = this.丛丗丟丛丙丟一专丆();
        val_21[2] = this.丝不丟丁丘丐丛一不;
        val_19 = mem[this.丗下丕丏丗丘丂丆业 + 56];
        val_21[3] = val_19;
        if(val_20 != null)
        {
            goto label_82;
        }
        
        goto label_23;
        label_1:
        int val_5 = this.丟丂丝丑丟丒世丘丞();
        丐丟丙不丗万三丈丆 val_6 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_26;
        }
        
        val_23 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_6 != null)
        {
            goto label_30;
        }
        
        goto label_29;
        label_26:
        val_23 = 0;
        if(val_6 != null)
        {
            goto label_30;
        }
        
        label_29:
        label_30:
        int val_8 = val_6.丏业世丄丒一丙专丟(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丛且丞与丕业下丏丞:  0);
        丐丟丙不丗万三丈丆 val_9 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_33;
        }
        
        val_24 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_9 != null)
        {
            goto label_37;
        }
        
        goto label_36;
        label_33:
        val_24 = 0;
        if(val_9 != null)
        {
            goto label_37;
        }
        
        label_36:
        label_37:
        float val_11 = val_9.丒丈与丟与上世丕一(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丛且丞与丕业下丏丞:  0);
        val_20 = this.丄丈丑丐丆丞丘与丗;
        object[] val_12 = new object[6];
        val_21 = val_12;
        if(丝三丗丁七丄丘丌丒 == null)
        {
            goto label_38;
        }
        
        val_21[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_21[1] = val_5;
        val_21[2] = this.丝不丟丁丘丐丛一不;
        val_22 = this.丑业业业丒丏丈丞下;
        if(val_22 == 0)
        {
            goto label_53;
        }
        
        val_25 = mem[this.丑业业业丒丏丈丞下 + 56];
        goto label_55;
        label_38:
        val_21[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_21[1] = val_5;
        val_21[2] = this.丝不丟丁丘丐丛一不;
        val_22 = this.丑业业业丒丏丈丞下;
        if(val_22 == 0)
        {
            goto label_70;
        }
        
        val_26 = mem[this.丑业业业丒丏丈丞下 + 56];
        goto label_72;
        label_53:
        val_25 = 0;
        label_55:
        val_21[3] = val_25;
        val_21[4] = val_8;
        val_19 = val_11;
        val_21[5] = val_19;
        if(val_20 != null)
        {
            goto label_82;
        }
        
        label_23:
        label_82:
        val_20.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  161, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
        return;
        label_5:
        val_21[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_22 = 1152921504622075904;
        val_21[1] = this.丛丗丟丛丙丟一专丆();
        val_21[2] = this.丝不丟丁丘丐丛一不;
        val_19 = mem[this.丗下丕丏丗丘丂丆业 + 56];
        val_21[3] = val_19;
        if(val_20 != null)
        {
            goto label_111;
        }
        
        goto label_101;
        label_70:
        val_26 = 0;
        label_72:
        val_21[3] = val_26;
        val_21[4] = val_8;
        val_19 = val_11;
        val_21[5] = val_19;
        if(val_20 != null)
        {
            goto label_111;
        }
        
        label_101:
        label_111:
        val_20.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  161, 万丌万丅专丞业丈万:  0, 丗丟上上丒丐丗丞丙:  val_12);
    }
    internal void 丏专丘上世东丆丅丏()
    {
        bool val_14;
        var val_15;
        System.Collections.Generic.Dictionary<System.Int32, 万丗且专万丟丌丂丐> val_16;
        var val_17;
        var val_18;
        val_14 = this.一业世丅丁七下丈不(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丑业业业丒丏丈丞下, 丐且丘丑与万丞丑丅 = this.丑业业业丒丏丈丞下, 与丝丒万且丘丂丟三 = true}, 上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东());
        System.Int32[] val_13 = DungeonWindowUI.丑丄且业丕丌丈且专();
        bool val_4 = this.丂丛丁一七七丟丂丟(不东与万丁与丁丅与:  val_13);
        this.且丏与丅七丁上且不 = val_14 & val_4;
        val_13 = val_4;
        this.squadUI.SetDungeonAvaliableByModules(世丆丞一业三一丅与:  val_13);
        bool val_7 = UnityEngine.Object.op_Inequality(x:  this.丑业业业丒丏丈丞下, y:  0);
        if(val_7 == false)
        {
            goto label_13;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = DungeonWindowUI.dungeonsInfo;
        if((val_16.ContainsKey(key:  this.丑业业业丒丏丈丞下.丏丈丗世丙万丆丐丅.indexMap)) == false)
        {
            goto label_13;
        }
        
        val_17 = null;
        val_17 = null;
        val_16 = DungeonWindowUI.dungeonsInfo;
        val_14 = val_14 & val_7;
        万丗且专万丟丌丂丐 val_9 = val_16.Item[this.丑业业业丒丏丈丞下.丏丈丗世丙万丆丐丅.indexMap];
        val_18;
        if(this.squadUI != null)
        {
            goto label_20;
        }
        
        goto label_19;
        label_13:
        val_18 = 0;
        if(this.squadUI != null)
        {
            goto label_20;
        }
        
        label_19:
        label_20:
        this.squadUI.SetDungeonAvaliableByProgress(世丆丞一业三一丅与:  val_14, 上丕丈丞丌丘丅不与:  0);
    }
    internal bool 丘丌丄丝丆丑丌丞丏()
    {
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_2 == null)
        {
            goto label_14;
        }
        
        System.Collections.Generic.List<ClanTankEquipInfo> val_3 = val_2.丒丗不丙业丟丄丏丂();
        if(val_3 != null)
        {
                int val_4 = val_3.Count;
            val_25 = 0;
        }
        else
        {
                val_25 = 0;
        }
        
        val_26 = 0;
        if((val_25.丙东专丂世丈丏丁丂() < 1) || ((1384514504 & 1) == 0))
        {
            goto label_40;
        }
        
        丞丂丘丒丟丞丑下丄 val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_7 == null)
        {
            goto label_14;
        }
        
        System.Collections.Generic.List<FortFieldItemInfo> val_8 = val_7.丟与且丙七丙丞下丏();
        if(val_8 != null)
        {
                int val_9 = val_8.Count;
            val_27 = 0;
        }
        else
        {
                val_27 = 0;
        }
        
        val_26 = 0;
        if((val_27.丙东专丂世丈丏丁丂() < 1) || ((1384514504 & 1) == 0))
        {
            goto label_40;
        }
        
        丞丂丘丒丟丞丑下丄 val_12 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_12 == null)
        {
            goto label_14;
        }
        
        System.Collections.Generic.List<SquareFieldCellData> val_13 = val_12.丌丂专不丁七一丙丗();
        if(val_13 == null)
        {
            goto label_15;
        }
        
        int val_14 = val_13.Count;
        val_28 = 0;
        goto label_16;
        label_14:
        val_26 = 0;
        label_40:
        val_26 = val_26 & 31;
        if(this.丝不丟丁丘丐丛一不 != 27)
        {
            goto label_17;
        }
        
        if(val_26 == 16)
        {
            goto label_20;
        }
        
        goto label_35;
        label_17:
        if(val_26 != 16)
        {
                if(this.丝不丟丁丘丐丛一不 == 26)
        {
            goto label_35;
        }
        
        }
        
        label_20:
        if((this.丏东丕与丂丞七业丗 == 2) && (this.丝不丟丁丘丐丛一不 == 27))
        {
                if(PGCompany.一丝丐丕丒丛专七丄.丌不与丂七不丆丏且() == null)
        {
                return (bool)val_29;
        }
        
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_27;
        }
        
        if(this.丏东丕与丂丞七业丗 != 2)
        {
                if((this.丏东丕与丂丞七业丗 != 1) || (this.丝不丟丁丘丐丛一不 != 17))
        {
            goto label_33;
        }
        
        }
        
        val_30 = 1;
        goto label_34;
        label_33:
        label_34:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().三不万不丕丑一上与() < ((this.丏东丕与丂丞七业丗 != 3) ? (1 + 1) : 1))
        {
            goto label_35;
        }
        
        label_27:
        if(this.HasWaitingPlayers == false)
        {
            goto label_36;
        }
        
        label_35:
        val_29 = 0;
        return (bool)val_29;
        label_36:
        if(this.丝不丟丁丘丐丛一不 != 22)
        {
                return (bool)val_29;
        }
        
        var val_21 = (this.且丏与丅七丁上且不 == true) ? 1 : 0;
        return (bool)val_29;
        label_15:
        val_28 = 0;
        label_16:
        var val_24 = (((val_28.丙东专丂世丈丏丁丂() > 0) ? 1 : 0) != 1384514504) ? 16 : 0;
        goto label_40;
    }
    internal bool 丅丝丗丙丝业业丟业()
    {
        if((this.东丒世丂丒丌丆丑丛 != null) && (this.东丒世丂丒丌丆丑丛.丂丛丄丆丐东且一世 != false))
        {
                return false;
        }
        
        if(this.丝不丟丁丘丐丛一不 != 22)
        {
                return true;
        }
        
        return (bool)(this.且丏与丅七丁上且不 == true) ? 1 : 0;
    }
    private void 丅丞丛丑丗下丌丐下(int 上且丗一丏丏万丅丌, int 丛且丞与丕业下丏丞, int 万丏丑下三丗万丙三, int 与丝丒万且丘丂丟三, string 丞丙丆丟七且丏业专, int 丟丄不三丄且丙丘丏, bool 丒丙三丏丟业丕丟丘, object[] 丑不丁丅一丐丌且下, string 不东丐丙丒丅丟丛下)
    {
        var val_1;
        string val_2;
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        string val_10;
        int val_11;
        var val_12;
        val_1 = this;
        val_2 = 丞丙丆丟七且丏业专;
        val_3 = 万丏丑下三丗万丙三;
        val_4 = 丛且丞与丕业下丏丞;
        val_5 = 上且丗一丏丏万丅丌;
        val_1 = val_1;
        val_6 = val_5;
        val_7 = val_4;
        val_8 = val_3;
        val_9 = 与丝丒万且丘丂丟三;
        val_10 = val_2;
        val_11 = 丟丄不三丄且丙丘丏;
        val_12 = null;
        val_2 = val_10;
        val_3 = val_8;
        val_4 = val_7;
        val_5 = val_6;
        val_11 = val_11;
        val_12 = null;
        val_1 = val_1;
        val_6 = val_5;
        val_7 = val_4;
        val_8 = val_3;
        val_9 = val_9;
        val_10 = val_2;
        丒丙三丏丟业丕丟丘 = 丒丙三丏丟业丕丟丘;
        SquadController.七丆丆丘业丝与丄业 = 不东丐丙丒丅丟丛下;
        this.丅丞丛丑丗下丌丐下(上且丗一丏丏万丅丌:  val_6, 丛且丞与丕业下丏丞:  val_7, 万丏丑下三丗万丙三:  val_8, 与丝丒万且丘丂丟三:  val_9, 丞丙丆丟七且丏业专:  val_10, 丟丄不三丄且丙丘丏:  val_11, 丒丙三丏丟业丕丟丘:  丒丙三丏丟业丕丟丘, 丑不丁丅一丐丌且下:  丑不丁丅一丐丌且下);
    }
    private void 丅丞丛丑丗下丌丐下(int 上且丗一丏丏万丅丌, int 丛且丞与丕业下丏丞, int 万丏丑下三丗万丙三, int 与丝丒万且丘丂丟三, string 丞丙丆丟七且丏业专, int 丟丄不三丄且丙丘丏, bool 丒丙三丏丟业丕丟丘, object[] 丑不丁丅一丐丌且下)
    {
        System.Object[] val_9;
        bool val_10;
        Rilisoft.七丕丟丏三丈一丄世 val_11;
        不丆万上丏丒丕丝万 val_12;
        var val_13;
        var val_14;
        var val_15;
        val_9 = 丑不丁丅一丐丌且下;
        val_10 = 丒丙三丏丟业丕丟丘;
        val_11 = 上且丗一丏丏万丅丌;
        if(this.丌丞丅下下丟世丙丌 == false)
        {
                return;
        }
        
        if(this.三丑七丙丌丁三丈下 == true)
        {
                return;
        }
        
        if(丛且丞与丕业下丏丞 != 1)
        {
                val_12 = 1;
        }
        else
        {
                val_12 = 2;
        }
        
        GameConnect.丘丕丈丄丛业东丈丝(丙业与丙丗丝不丈东:  val_12);
        this.丕世丛业丌丗丗丕丁();
        val_13 = null;
        val_13 = null;
        SquadController.丅丐丝下丞下下下上 = val_9;
        this.丁丏丅丞东且丒下世 = val_10;
        this.丝不丟丁丘丐丛一不 = val_11;
        val_10 = 1152921505066536960;
        val_14 = null;
        val_14 = null;
        val_11 = this.丝不丟丁丘丐丛一不;
        this.不丒丒丏丞丏丛业丌 = System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  GameConnect.丘丗世专不丅与丗丒, value:  val_11);
        SquadController.且丘三丈世丌丒万七 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        SquadController.万与丈世丝丙万丕一 = this.丝不丟丁丘丐丛一不;
        if(SquadController.丐丁世丘丁丄丏丞丙 != 0)
        {
                SquadController.丐丁世丘丁丄丏丞丙.Invoke(arg1:  this.丝不丟丁丘丐丛一不, arg2:  val_9);
        }
        
        if(this.不丒丒丏丞丏丛业丌 != false)
        {
                丌丑丕丏丝丆上东丄 val_6 = BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  this.丝不丟丁丘丐丛一不);
            val_9 = val_6.丏上专丐三丛丁丗丆;
            if(val_9 > BankController.丈丐业丈丄丕丕三世())
        {
                this.世上丈丄世丐丕丐东();
            return;
        }
        
        }
        
        mem[1152921540351698976] = 0;
        this.上丂东丗丝丈业万丅 = 0;
        if(0 >= 1)
        {
                if(0 == 0)
        {
            goto label_27;
        }
        
        }
        
        this.丁丄万丙专丒七丅不 = true;
        val_15 = null;
        val_15 = null;
        SquadController.万一丘丗三三丈丗丛 = 丞丙丆丟七且丏业专;
        this.丕丕三世世世一与丄 = 丟丄不三丄且丙丘丏;
        GameConnect.下与业丒丝丕丙丘丙();
        return;
        label_27:
        this.世上丈丄世丐丕丐东();
    }
    private void 且丟专丁一且上不东()
    {
        if(this.三丑七丙丌丁三丈下 != false)
        {
                return;
        }
        
        this.下一丅丄丅与专万丘 = true;
        this.与三世丂丕丅一丄丄 = 15f;
    }
    private void 专七丁丆上不下上丞()
    {
        if(this.三丑七丙丌丁三丈下 != false)
        {
                return;
        }
        
        this.丕世丛业丌丗丗丕丁();
        this.丌丞丅下下丟世丙丌 = true;
        this.世与七东世不业丒专(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.不丒丒丏丞丏丛业丌 == true) ? "Key_3489" : "Key_3480"));
    }
    private void 丄丘不丌丝一丈世丘(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌)
    {
        int val_10;
        var val_11;
        var val_12;
        var val_13;
        if((this.丐丒丈与丈丒丐七丅(专丞上七七且丝七丗:  不丟丗丏丛丕不丁丌)) == null)
        {
                return;
        }
        
        val_1.丂丛丄丆丐东且一世 = true;
        this.丄丕丛万丝三丌专丕();
        if(this.业专丗且丏丘丘三丐() == false)
        {
                return;
        }
        
        if(this.下一丅丄丅与专万丘 == false)
        {
                return;
        }
        
        val_11 = 0;
        val_12 = 1;
        goto label_4;
        label_16:
        if((val_12 & 1) == 0)
        {
            goto label_5;
        }
        
        万丅世丈丕丕丌丅丗 val_3 = this.丛一丆专世丝丄丒与.Item[0];
        if(val_3.丂丛丄丆丐东且一世 == false)
        {
            goto label_8;
        }
        
        val_13 = 1;
        goto label_10;
        label_5:
        val_13 = 0;
        goto label_10;
        label_8:
        val_13 = this.丛一丆专世丝丄丒与.Item[0].业专丗且丏丘丘三丐();
        label_10:
        val_11 = 1;
        label_4:
        val_10 = this.世丗万丏下丆专丁丏;
        if(val_11 < (UnityEngine.Mathf.Min(a:  this.丛一丆专世丝丄丒与.Count, b:  val_10)))
        {
            goto label_16;
        }
        
        if((((val_13 == true) ? 1 : 0) & 1) == 0)
        {
                return;
        }
        
        this.与三世丂丕丅一丄丄 = 0f;
    }
    private void 上丛丂丏丗丏三丅丁(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌, int 业万上丆丐丞且丒七, int 丂丛丑东不丅丈一东, int 丞丁丑丏丄丏七丂不, int 专世专丟丝丌与丘上, float 丗丘丆丄丝与东下上)
    {
        if((this.丐丒丈与丈丒丐七丅(专丞上七七且丝七丗:  不丟丗丏丛丕不丁丌)) == null)
        {
                return;
        }
        
        mem2[0] = 0;
        val_1.业万上丆丐丞且丒七 = 0;
    }
    private void 不一丒丛丁东下七丌(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌, int[] 世下丂且专丝丝下世)
    {
        if((this.丐丒丈与丈丒丐七丅(专丞上七七且丝七丗:  不丟丗丏丛丕不丁丌)) != null)
        {
                val_1.不东与万丁与丁丅与 = 世下丂且专丝丝下世;
        }
        
        this.丌与丛丟丏丕万丁七();
    }
    private void 一丟世丐世万丂与丁(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌)
    {
        与丅丕丈丘东丝世丟 val_7;
        var val_8;
        val_7 = 不丟丗丏丛丕不丁丌;
        val_8 = 0;
        goto label_1;
        label_7:
        万丅世丈丕丕丌丅丗 val_1 = this.丛一丆专世丝丄丒与.Item[0];
        if((val_1.专丞上七七且丝七丗.Equals(丘丛丏丘丝七世七丅:  val_7)) == true)
        {
            goto label_5;
        }
        
        val_8 = 1;
        label_1:
        if(val_8 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_7;
        }
        
        return;
        label_5:
        val_7 = this.丛一丆专世丝丄丒与.Item[0];
        val_4.丆不丐一丙丐丏丗上 = true;
        val_8 = this.丛一丆专世丝丄丒与.Item[0];
        val_5.三丘万业丁一丞丒丏 = UnityEngine.Time.time;
    }
    private void 且万丐丄丈丘一业丑()
    {
        var val_5;
        if(this.业专丗且丏丘丘三丐() != false)
        {
                return;
        }
        
        if(this.三丕丗丆丝下丝丘丈() != null)
        {
                万丅世丈丕丕丌丅丗 val_4 = this.三丕丗丆丝下丝丘丈();
            val_5 = null;
            val_5 = null;
            丄上三丛丛上一业三.丑七不且上丗丁一世().丁丅丏世业丆万东专(三丂七与丂丝丐丆丂:  val_4.丆世丘丒丒丏上且丗, 丅一丞万丑专丅丅与:  this.squadRoomName, 丄东七丄一丄万丕丟:  SquadController.丘丘丙丗东丟丑业丟);
        }
        
        this.世上丈丄世丐丕丐东();
    }
    private SquadController.万丅世丈丕丕丌丅丗 丐丒丈与丈丒丐七丅(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        与丅丕丈丘东丝世丟 val_5;
        var val_6;
        var val_7;
        val_5 = 专丞上七七且丝七丗;
        val_6 = 0;
        goto label_1;
        label_7:
        万丅世丈丕丕丌丅丗 val_1 = this.丛一丆专世丝丄丒与.Item[0];
        if((val_1.专丞上七七且丝七丗.Equals(丘丛丏丘丝七世七丅:  val_5)) == true)
        {
            goto label_5;
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_7;
        }
        
        val_7 = 0;
        return (万丅世丈丕丕丌丅丗)val_5.Item[0];
        label_5:
        val_5 = this.丛一丆专世丝丄丒与;
        return (万丅世丈丕丕丌丅丗)val_5.Item[0];
    }
    public bool IsPlayerInSquad(string 丄丒且丙三丆丟与丏)
    {
        .丄丒且丙三丆丟与丏 = 丄丒且丙三丆丟与丏;
        if(this.丛一丆专世丝丄丒与 == null)
        {
                return false;
        }
        
        return System.Linq.Enumerable.Any<万丅世丈丕丕丌丅丗>(source:  this.丛一丆专世丝丄丒与, predicate:  new System.Func<万丅世丈丕丕丌丅丗, System.Boolean>(object:  new SquadController.丟东丗丒丝丕丅丆东(), method:  System.Boolean SquadController.丟东丗丒丝丕丅丆东::不丕丁丟上丗丙丅丅(SquadController.万丅世丈丕丕丌丅丗 三丟东丕丄丄下下丑)));
    }
    private int 丛丂且丆不不万丛丐(SquadController.万丅世丈丕丕丌丅丗 三丟东丕丄丄下下丑, SquadController.万丅世丈丕丕丌丅丗 丒丒丄丁且丄丆丂丌)
    {
        var val_6;
        var val_7;
        val_6 = 丒丒丄丁且丄丆丂丌;
        if(丒丒丄丁且丄丆丂丌.专丞上七七且丝七丗 == null)
        {
            goto label_1;
        }
        
        if(三丟东丕丄丄下下丑.专丞上七七且丝七丗 == null)
        {
            goto label_3;
        }
        
        if(三丟东丕丄丄下下丑.专丞上七七且丝七丗.业丐丐三丕一丗丛丁() >= 丒丒丄丁且丄丆丂丌.专丞上七七且丝七丗.业丐丐三丕一丗丛丁())
        {
            goto label_5;
        }
        
        label_1:
        val_7 = 0;
        return (int)(val_6 > 丒丒丄丁且丄丆丂丌.专丞上七七且丝七丗.业丐丐三丕一丗丛丁()) ? 1 : 0;
        label_3:
        val_7 = 1;
        return (int)(val_6 > 丒丒丄丁且丄丆丂丌.专丞上七七且丝七丗.业丐丐三丕一丗丛丁()) ? 1 : 0;
        label_5:
        val_6 = 三丟东丕丄丄下下丑.专丞上七七且丝七丗.业丐丐三丕一丗丛丁();
        return (int)(val_6 > 丒丒丄丁且丄丆丂丌.专丞上七七且丝七丗.业丐丐三丕一丗丛丁()) ? 1 : 0;
    }
    private void 丄丕丛万丝三丌专丕()
    {
        this.东丏东上七一万丆丌.Clear();
        this.东丏东上七一万丆丌.AddRange(collection:  this.丛一丆专世丝丄丒与);
        bool val_2 = this.东丏东上七一万丆丌.Remove(item:  this.三丕丗丆丝下丝丘丈());
        this.东丏东上七一万丆丌.AddRange(collection:  this.且丞丂丟丆丕丂世丕);
        this.东丏东上七一万丆丌.Sort(comparison:  new System.Comparison<万丅世丈丕丕丌丅丗>(object:  this, method:  System.Int32 SquadController::丛丂且丆不不万丛丐(SquadController.万丅世丈丕丕丌丅丗 三丟东丕丄丄下下丑, SquadController.万丅世丈丕丕丌丅丗 丒丒丄丁且丄丆丂丌)));
        this.squadUI.UpdateSquadInfo(丁三上丂丅丏丏丁丕:  this.三丕丗丆丝下丝丘丈(), 丛一丆专世丝丄丒与:  this.东丏东上七一万丆丌);
        this.丌与丛丟丏丕万丁七();
    }
    private int 丏丄丈上东丙丞专丒()
    {
        丛且丏丑丕丘丒丞且 val_8;
        int val_9;
        丛且丏丑丕丘丒丞且 val_10;
        val_8 = this.丑业业业丒丏丈丞下;
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丏丈丗世丙万丆丐丅:  val_8)) != false)
        {
                val_9 = 0;
            return (int)val_9;
        }
        
        val_9 = this.丟丂丝丑丟丒世丘丞();
        val_8 = 0;
        goto label_5;
        label_19:
        if(this.丛一丆专世丝丄丒与.Item[0].丟丌下三七丁与丟丑() != true)
        {
                val_10 = this.丑业业业丒丏丈丞下;
            if(val_10 != 0)
        {
                if(val_10 != (mem[this.丑业业业丒丏丈丞下 + 56]))
        {
            goto label_15;
        }
        
        }
        
            val_9 = UnityEngine.Mathf.Max(a:  val_9, b:  val_3.业万上丆丐丞且丒七);
        }
        
        label_15:
        val_8 = 1;
        label_5:
        if(val_8 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_19;
        }
        
        return (int)val_9;
    }
    private SquadController.与业丁丈与东丏万丗 丆不丈专万丕丂丁世()
    {
        int val_15;
        var val_16;
        float val_17;
        var val_18;
        var val_19;
        丛且丏丑丕丘丒丞且 val_20;
        int val_1 = this.业丟与丘丝丟丁万丂();
        val_15 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不);
        丐丟丙不丗万三丈丆 val_4 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_4;
        }
        
        val_16 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_4 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_4:
        val_16 = 0;
        if(val_4 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        float val_6 = val_4.丒丈与丟与上世丕一(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丛且丞与丕业下丏丞:  0);
        val_17 = val_6;
        val_18 = 0;
        val_19 = 1;
        goto label_9;
        label_27:
        万丅世丈丕丕丌丅丗 val_7 = this.丛一丆专世丝丄丒与.Item[0];
        if((val_7.丟丌下三七丁与丟丑() == true) || (null != this.丝不丟丁丘丐丛一不))
        {
            goto label_23;
        }
        
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_17;
        }
        
        val_20 = this.丑业业业丒丏丈丞下;
        if(this.丑业业业丒丏丈丞下 != (mem[this.丑业业业丒丏丈丞下 + 56]))
        {
            goto label_23;
        }
        
        label_17:
        val_20 = val_7.专世专丟丝丌与丘上;
        int val_11 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丙丂丏丛丌丏下丝不:  val_20);
        val_19 = 2;
        val_17 = val_17 + val_6;
        if(val_11 > val_15)
        {
                val_15 = val_11;
        }
        
        label_23:
        val_18 = 1;
        label_9:
        if(val_18 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_27;
        }
        
        val_17 = val_17 / 2f;
        return (与业丁丈与东丏万丗)new SquadController.与业丁丈与东丏万丗(业万上丆丐丞且丒七:  val_15, 专世专丟丝丌与丘上:  UnityEngine.Mathf.Max(a:  mem[this.丑业业业丒丏丈丞下 + 56], b:  val_7), 丗丘丆丄丝与东下上:  val_17);
    }
    private int 丟丂丝丑丟丒世丘丞()
    {
        var val_14;
        int val_15;
        丛且丏丑丕丘丒丞且 val_16;
        var val_17;
        var val_18;
        丛丗丐世下丛丄丞丟 val_13 = this.丏东丕与丂丞七业丗;
        val_13 = val_13 - 1;
        var val_1 = (val_13 < 3) ? 1 : 0;
        val_1 = val_1 & ((this.丝不丟丁丘丐丛一不 == 17) ? 1 : 0);
        if(((val_1 & 1) != 0) || (this.丝不丟丁丘丐丛一不 == 20))
        {
            goto label_2;
        }
        
        if((丐丟丙不丗万三丈丆.东丁不业丟世丂三世(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不)) == false)
        {
            goto label_3;
        }
        
        return GameConnect.丅下世万业业丘专丄();
        label_2:
        val_14 = null;
        val_14 = null;
        val_15 = ExpController.LevelsForTiers.Length - 1;
        return val_15;
        label_3:
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不)) == false)
        {
            goto label_11;
        }
        
        val_16 = this.丑业业业丒丏丈丞下;
        goto label_12;
        label_11:
        丐丟丙不丗万三丈丆 val_6 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        val_16 = this;
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_15;
        }
        
        val_17 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_6 != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_15:
        val_17 = 0;
        if(val_6 != null)
        {
            goto label_19;
        }
        
        label_18:
        label_19:
        if((val_6.一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丞丁丑丏丄丏七丂不:  0)) == false)
        {
                return GameConnect.丅下世万业业丘专丄();
        }
        
        label_12:
        丐丟丙不丗万三丈丆 val_9 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_23;
        }
        
        val_18 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_9 != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_23:
        val_18 = 0;
        if(val_9 != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        val_15 = val_9.丝上一七丝下丅丑丈(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丛且丞与丕业下丏丞:  0);
        UnityEngine.Debug.Log(message:  "Tier Matchmaking: Selected tier "("Tier Matchmaking: Selected tier ") + val_15);
        return val_15;
    }
    private int 业丟与丘丝丟丁万丂()
    {
        int val_11;
        丛且丏丑丕丘丒丞且 val_12;
        var val_13;
        var val_14;
        if((丐丟丙不丗万三丈丆.东丁不业丟世丂三世(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不)) == false)
        {
            goto label_1;
        }
        
        label_13:
        val_11 = 0;
        return val_11;
        label_1:
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不)) == false)
        {
            goto label_4;
        }
        
        val_12 = this.丑业业业丒丏丈丞下;
        goto label_5;
        label_4:
        丐丟丙不丗万三丈丆 val_4 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        val_12 = this;
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_8;
        }
        
        val_13 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_4 != null)
        {
            goto label_12;
        }
        
        goto label_11;
        label_8:
        val_13 = 0;
        if(val_4 != null)
        {
            goto label_12;
        }
        
        label_11:
        label_12:
        if((val_4.一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丞丁丑丏丄丏七丂不:  0)) == false)
        {
            goto label_13;
        }
        
        label_5:
        丐丟丙不丗万三丈丆 val_7 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(this.丑业业业丒丏丈丞下 == 0)
        {
            goto label_16;
        }
        
        val_14 = mem[this.丑业业业丒丏丈丞下 + 56];
        if(val_7 != null)
        {
            goto label_20;
        }
        
        goto label_19;
        label_16:
        val_14 = 0;
        if(val_7 != null)
        {
            goto label_20;
        }
        
        label_19:
        label_20:
        val_11 = val_7.丏业世丄丒一丙专丟(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丛且丞与丕业下丏丞:  0);
        UnityEngine.Debug.Log(message:  "Tier Matchmaking: Selected rank "("Tier Matchmaking: Selected rank ") + val_11);
        return val_11;
    }
    private int 丛丗丟丛丙丟一专丆()
    {
        var val_14;
        int val_15;
        丛且丏丑丕丘丒丞且 val_16;
        var val_17;
        var val_18;
        丛丗丐世下丛丄丞丟 val_13 = this.丏东丕与丂丞七业丗;
        val_13 = val_13 - 1;
        var val_1 = (val_13 < 3) ? 1 : 0;
        val_1 = val_1 & ((this.丝不丟丁丘丐丛一不 == 17) ? 1 : 0);
        if(((val_1 & 1) != 0) || (this.丝不丟丁丘丐丛一不 == 20))
        {
            goto label_2;
        }
        
        if((丐丟丙不丗万三丈丆.东丁不业丟世丂三世(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不)) == false)
        {
            goto label_3;
        }
        
        return GameConnect.丅下世万业业丘专丄();
        label_2:
        val_14 = null;
        val_14 = null;
        val_15 = ExpController.LevelsForTiers.Length - 1;
        return val_15;
        label_3:
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不)) == false)
        {
            goto label_11;
        }
        
        val_16 = this.丗下丕丏丗丘丂丆业;
        goto label_12;
        label_11:
        丐丟丙不丗万三丈丆 val_6 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        val_16 = this;
        if(this.丗下丕丏丗丘丂丆业 == 0)
        {
            goto label_15;
        }
        
        val_17 = mem[this.丗下丕丏丗丘丂丆业 + 56];
        if(val_6 != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_15:
        val_17 = 0;
        if(val_6 != null)
        {
            goto label_19;
        }
        
        label_18:
        label_19:
        if((val_6.一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丞丁丑丏丄丏七丂不:  0)) == false)
        {
                return GameConnect.丅下世万业业丘专丄();
        }
        
        label_12:
        丐丟丙不丗万三丈丆 val_9 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if(this.丗下丕丏丗丘丂丆业 == 0)
        {
            goto label_23;
        }
        
        val_18 = mem[this.丗下丕丏丗丘丂丆业 + 56];
        if(val_9 != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_23:
        val_18 = 0;
        if(val_9 != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        val_15 = val_9.丝上一七丝下丅丑丈(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丛且丞与丕业下丏丞:  0);
        UnityEngine.Debug.Log(message:  "Tier Matchmaking: Selected tier "("Tier Matchmaking: Selected tier ") + val_15);
        return val_15;
    }
    private bool 东万一丛下丂丆七丙()
    {
        SquadController val_7;
        var val_8;
        val_7 = this;
        if((this.不丒丒丏丞丏丛业丌 == false) || (this.丒丌下专专丁业丗丈 <= BankController.丈丐业丈丄丕丕三世()))
        {
            goto label_4;
        }
        
        SquadController.丗丄万丞世丒丑三丌 val_2 = new SquadController.丗丄万丞世丒丑三丌();
        if(val_2 == null)
        {
            goto label_5;
        }
        
        .丝且与丝丒丟万丁专 = val_7;
        goto label_6;
        label_4:
        val_8 = 1;
        return (bool)val_8;
        label_5:
        mem[24] = val_7;
        label_6:
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_2, method:  System.Void SquadController.丗丄万丞世丒丑三丌::丈丄丛丗且一丙丌丞(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (SquadController.丗丄万丞世丒丑三丌)[1152921540354620352].丑丘丐丂不丐丒丟且);
        this.gameObject.SetActive(value:  false);
        val_7 = BankController.丑七不且上丗丁一世();
        val_7.丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "TicketsCurrency", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        val_8 = 0;
        return (bool)val_8;
    }
    public void StartGame()
    {
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        int val_31;
        var val_32;
        if(this.下一丅丄丅与专万丘 != false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(this.东万一丛下丂丆七丙() == false)
        {
                return;
        }
        
        丛丗丐世下丛丄丞丟 val_25 = this.丏东丕与丂丞七业丗;
        if(val_25 != 2)
        {
                if((val_25 != 1) || (this.丝不丟丁丘丐丛一不 != 17))
        {
            goto label_11;
        }
        
        }
        
        val_26 = 1;
        goto label_12;
        label_11:
        label_12:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() < ((val_25 != 3) ? (1 + 1) : 1))
        {
                return;
        }
        
        val_25 = val_25 - 1;
        if(val_25 >= 3)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        this.下一丅丄丅与专万丘 = true;
        int val_8 = UnityEngine.Mathf.Min(a:  this.丛一丆专世丝丄丒与.Count, b:  this.世丗万丏下丆专丁丏);
        if(val_8 < 1)
        {
            goto label_21;
        }
        
        val_27 = 1152921540349734000;
        var val_26 = 0;
        label_30:
        if((1 & 1) == 0)
        {
            goto label_22;
        }
        
        万丅世丈丕丕丌丅丗 val_9 = this.丛一丆专世丝丄丒与.Item[0];
        if(val_9.丂丛丄丆丐东且一世 == false)
        {
            goto label_25;
        }
        
        val_28 = 1;
        goto label_27;
        label_22:
        val_28 = 0;
        goto label_27;
        label_25:
        val_28 = this.丛一丆专世丝丄丒与.Item[0].业专丗且丏丘丘三丐();
        label_27:
        val_26 = val_26 + 1;
        var val_12 = (val_28 == true) ? 1 : 0;
        if(val_8 != val_26)
        {
            goto label_30;
        }
        
        goto label_31;
        label_21:
        val_29 = 1;
        label_31:
        丛丗丐世下丛丄丞丟 val_27 = this.丏东丕与丂丞七业丗;
        val_27 = val_27 - 1;
        if(val_27 < 3)
        {
            goto label_32;
        }
        
        if(this.丝不丟丁丘丐丛一不 != 22)
        {
            goto label_33;
        }
        
        val_30 = 0;
        goto label_34;
        label_39:
        if((this.世专三丒丙丗丘丆万(专丞上七七且丝七丗:  this.丛一丆专世丝丄丒与.Item[0])) != true)
        {
                this.KickPlayer(专丞上七七且丝七丗:  this.丛一丆专世丝丄丒与.Item[0], 三不与丐下丕丅世丙:  false);
        }
        
        val_30 = 1;
        label_34:
        if(val_30 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_39;
        }
        
        label_33:
        val_31 = this.世丗万丏下丆专丁丏;
        val_27 = 1152921540349734000;
        goto label_40;
        label_43:
        this.KickPlayer(专丞上七七且丝七丗:  this.丛一丆专世丝丄丒与.Item[val_31], 三不与丐下丕丅世丙:  false);
        val_31 = val_31 + 1;
        label_40:
        if(val_31 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_43;
        }
        
        label_32:
        val_32 = null;
        val_32 = null;
        FriendInviteInfoContainer.一且丕丙丆丟丙七丒.Clear();
        if(val_29 != 0)
        {
                this.与三世丂丕丅一丄丄 = 0f;
            return;
        }
        
        丛丗丐世下丛丄丞丟 val_28 = this.丏东丕与丂丞七业丗;
        this.与三世丂丕丅一丄丄 = 15f;
        val_28 = val_28 - 1;
        if(val_28 < 3)
        {
                this.东丏东上七一万丆丌.Clear();
            this.东丏东上七一万丆丌.AddRange(collection:  this.丛一丆专世丝丄丒与);
            this.东丏东上七一万丆丌.Sort(comparison:  new System.Comparison<万丅世丈丕丕丌丅丗>(object:  this, method:  System.Int32 SquadController::丛丂且丆不不万丛丐(SquadController.万丅世丈丕丕丌丅丗 三丟东丕丄丄下下丑, SquadController.万丅世丈丕丕丌丅丗 丒丒丄丁且丄丆丂丌)));
            if(val_8 < 1)
        {
                return;
        }
        
            var val_29 = 0;
            do
        {
            if((this.世专三丒丙丗丘丆万(专丞上七七且丝七丗:  this.东丏东上七一万丆丌.Item[0])) != false)
        {
                万丅世丈丕丕丌丅丗 val_22 = this.东丏东上七一万丆丌.Item[0];
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  136, 万丌万丅专丞业丈万:  val_22.专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
            val_29 = val_29 + 1;
        }
        while(val_8 != val_29);
        
            return;
        }
        
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  136, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    internal bool 世专三丒丙丗丘丆万(SquadController.万丅世丈丕丕丌丅丗 专丞上七七且丝七丗)
    {
        var val_4;
        var val_5;
        val_4 = this;
        if(this.丝不丟丁丘丐丛一不 == 22)
        {
                val_5 = (this.一业世丅丁七下丈不(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丑业业业丒丏丈丞下, 丐且丘丑与万丞丑丅 = this.丑业业业丒丏丈丞下, 与丝丒万且丘丂丟三 = this.丝不丟丁丘丐丛一不}, 上丕丈丞丌丘丅不与:  专丞上七七且丝七丗.上丕丈丞丌丘丅不与)) & (this.丂丛丁一七七丟丂丟(不东与万丁与丁丅与:  专丞上七七且丝七丗.不东与万丁与丁丅与));
            return (bool)val_5 & 1;
        }
        
        val_5 = 1;
        return (bool)val_5 & 1;
    }
    internal bool 丂丛丁一七七丟丂丟(int[] 不东与万丁与丁丅与)
    {
        丛且丏丑丕丘丒丞且 val_9;
        var val_10;
        var val_11;
        var val_12;
        val_10 = 1;
        if((不东与万丁与丁丅与 == null) || (this.丏东丕与丂丞七业丗 == 2))
        {
            goto label_15;
        }
        
        val_9 = this.丑业业业丒丏丈丞下;
        if(val_9 == 0)
        {
            goto label_10;
        }
        
        val_11 = null;
        val_11 = null;
        val_9 = DungeonWindowUI.dungeonsInfo;
        if((val_9.ContainsKey(key:  mem[this.丑业业业丒丏丈丞下 + 56])) == false)
        {
            goto label_10;
        }
        
        val_12 = null;
        val_12 = null;
        val_9 = DungeonWindowUI.dungeonsInfo;
        万丗且专万丟丌丂丐 val_3 = val_9.Item[mem[this.丑业业业丒丏丈丞下 + 56]];
        goto label_15;
        label_10:
        val_10 = 1;
        label_15:
        val_10 = val_10 & 1;
        return (bool)val_10;
    }
    internal bool 一业世丅丁七下丈不(SquadController.丛且丏丑丕丘丒丞且 丞丁丑丏丄丏七丂不, int 上丕丈丞丌丘丅不与)
    {
        var val_6;
        SceneInfo val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = this;
        if(this.丏东丕与丂丞七业丗 == 2)
        {
            goto label_9;
        }
        
        val_10 = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅;
        if(丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅 == 0)
        {
            goto label_9;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = DungeonWindowUI.dungeonsInfo;
        if((val_10.ContainsKey(key:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.indexMap)) == false)
        {
            goto label_9;
        }
        
        val_12 = null;
        val_12 = null;
        val_10 = DungeonWindowUI.dungeonsInfo;
        万丗且专万丟丌丂丐 val_3 = val_10.Item[丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.indexMap];
        bool val_8 = val_6.丒万丂七丅不丆不丄(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与, 丒万丟丅丌丝丟下下:  1389388128);
        goto label_14;
        label_9:
        val_13 = 1;
        label_14:
        val_13 = val_13 & 1;
        return (bool)val_13;
    }
    private System.Collections.IEnumerator 丄一丆下丗七丁丑丏()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SquadController.丄世丞丄不丛丅丏七(丗丏丅丕丆世丁专丟:  0);
    }
    private string 丁丅丑不丗一丂上丆()
    {
        string val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业() + 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄().ToString();
        System.Security.Cryptography.MD5 val_6 = System.Security.Cryptography.MD5.Create();
        if(val_6 != null)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            val_6.Dispose();
        }
        
        if(0 != 1)
        {
                return (string)System.Convert.ToBase64String(inArray:  val_6.ComputeHash(buffer:  System.Text.Encoding.UTF8));
        }
        
        if(0 == 0)
        {
                return (string)System.Convert.ToBase64String(inArray:  val_6.ComputeHash(buffer:  System.Text.Encoding.UTF8));
        }
        
        return (string)System.Convert.ToBase64String(inArray:  val_6.ComputeHash(buffer:  System.Text.Encoding.UTF8));
    }
    private int 丌专七七东丐三丒万()
    {
        var val_4;
        int val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_1;
        label_5:
        万丅世丈丕丕丌丅丗 val_1 = this.丛一丆专世丝丄丒与.Item[0];
        val_4 = 1;
        val_5 = val_1.丈丐世下丞与丂专丏 + val_5;
        label_1:
        if(val_4 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_5;
        }
        
        UnityEngine.Debug.Log(message:  "Squad rating: "("Squad rating: ") + val_5);
        return val_5;
    }
    public void SendReady()
    {
        if(this.东丒世丂丒丌丆丑丛 != null)
        {
                if(this.东丒世丂丒丌丆丑丛.丂丛丄丆丐东且一世 == true)
        {
                return;
        }
        
        }
        
        if(this.东万一丛下丂丆七丙() == false)
        {
                return;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  133, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void MoveToGameConnection()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        if(this.丝不丟丁丘丐丛一不 == 20)
        {
                val_5 = null;
            GameConnect.丙丙东七丙丞专丛不 = true;
        }
        
        val_5 = null;
        GameConnect.与丝丒万且丘丂丟三 = 137101312;
        if(this.丝不丟丁丘丐丛一不 == 22)
        {
                val_5 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            GameConnect.与丝丒万且丘丂丟三 = null;
            UnityEngine.Debug.LogError(message:  "Dungeon difficulty: "("Dungeon difficulty: ") + GameConnect.与丝丒万且丘丂丟三.ToString());
        }
        
        if(((this.丏东丕与丂丞七业丗 == 2) && (this.丝不丟丁丘丐丛一不 == 22)) && (this.丝不丟丁丘丐丛一不 == 0))
        {
                val_6 = null;
            val_6 = null;
            GameConnect.与丝丒万且丘丂丟三 = 1;
        }
        
        val_7 = null;
        val_7 = null;
        GameConnect.丘下丄丗丕业专丟丘 = this.丘下丄丗丕业专丟丘;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  this.丝不丟丁丘丐丛一不);
        bool val_4 = GameConnect.丆下丅丟下丂一不丙(业万上丆丐丞且丒七:  this.丕丕三世世世一与丄, 丛丈丑丏与上丄丝丌:  false, 丐且丘丑与万丞丑丅:  (GameConnect.__il2cppRuntimeField_static_fields != 0) ? 1 : 0);
    }
    private void OnDisconnectedFromPhoton()
    {
        var val_1;
        if(this.丁丄万丙专丒七丅不 == false)
        {
            goto label_1;
        }
        
        if(this.万且不丒不下丙丟与 == false)
        {
            goto label_2;
        }
        
        this.世丁丙下万与且丁丅();
        val_1 = null;
        val_1 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HideConnectionToMap();
        this.万且不丒不下丙丟与 = false;
        return;
        label_1:
        丛丗丐世下丛丄丞丟 val_1 = this.丏东丕与丂丞七业丗;
        val_1 = val_1 - 1;
        if(val_1 <= 2)
        {
                this.下一丅丄丅与专万丘 = false;
            this.丌丞丅下下丟世丙丌 = false;
            this.不与丞上丛丂丂丞丑();
        }
        
        this.Invoke(methodName:  "ReconnectToPhotonSquad", time:  2f);
        return;
        label_2:
        this.万且不丒不下丙丟与 = true;
        this.MoveToGameConnection();
    }
    private void OnFailedToConnect(int 世丁丙世丄一万丆三)
    {
        string val_1;
        int val_1 = this.丝丁万且丞丗丞丗丙;
        if(val_1 >= 3)
        {
                this.世丁丙下万与且丁丅();
            return;
        }
        
        val_1 = val_1 + 1;
        this.丝丁万且丞丗丞丗丙 = val_1;
        if(this.丁丄万丙专丒七丅不 != false)
        {
                val_1 = "MoveToGameConnection";
        }
        else
        {
                val_1 = "ReconnectToPhotonSquad";
        }
        
        this.Invoke(methodName:  val_1, time:  2f);
    }
    private void ReconnectToPhotonSquad()
    {
        丛丗丐世下丛丄丞丟 val_5 = this.丏东丕与丂丞七业丗;
        val_5 = val_5 | 1;
        bool val_4 = GameConnect.丛三七七丆丄丂丕丈(丐丝丛丂与专下丝丙:  ((val_5 == 1) ? 1 : 0) | ((val_5 == 3) ? 1 : 0), 丛丈丑丏与上丄丝丌:  false);
    }
    private void OnConnectedToMaster()
    {
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_33;
        var val_34;
        int val_35;
        var val_36;
        与业丁丈与东丏万丗 val_40;
        int val_41;
        与业丁丈与东丏万丗 val_42;
        val_33 = this;
        this.丝丁万且丞丗丞丗丙 = 0;
        if(this.丁丄万丙专丒七丅不 == false)
        {
            goto label_1;
        }
        
        val_34 = null;
        val_34 = null;
        if((System.String.op_Equality(a:  SquadController.万一丘丗三三丈丗丛, b:  this.丘下丄丗丕业专丟丘)) == false)
        {
            goto label_4;
        }
        
        if(this.丏东丕与丂丞七业丗 != 3)
        {
            goto label_5;
        }
        
        val_35 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不);
        GameConnect.万丐丑上丟丞丞丏丑(丅一丞万丑专丅丅与:  0, 丞与一东丈世且丐丕:  val_35, 丛且丞与丕业下丏丞:  mem[this.上丂东丗丝丈业万丅 + 56], 丗一丁丅与专丐一世:  GameConnect.丏丝一丁丛丕且丐丈(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不), 专业丛丆丟丆丛业丆:  "test", 上且丗一丏丏万丅丌:  this.丝不丟丁丘丐丛一不, 丟丑业丌丙丙丑下丑:  false, 下下东且万业丞丅丒:  true, 丙丘东丏三丆丄丁丟:  this.丙丂万专丄丙丏东丛, 丐且丘丑与万丞丑丅:  0, 七专丙丏丘丌丌下与:  0, 丕丑专丗万丕与专丐:  1);
        return;
        label_1:
        if((this.业专丗且丏丘丘三丐() == true) || ((this.丏东丕与丂丞七业丗 - 1) <= 2))
        {
            goto label_11;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.squadRoomName)) == true)
        {
                return;
        }
        
        bool val_7 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  this.squadRoomName);
        return;
        label_4:
        val_36 = null;
        val_36 = null;
        if((System.String.IsNullOrEmpty(value:  SquadController.万一丘丗三三丈丗丛)) == true)
        {
                return;
        }
        
        this.专且万万丝丅上世丟 = 0;
        this.丁丈丆丟专丛且丐丘 = true;
        丅丒丗丑丒丙丛不丆.不且业丏丄丒丈丆丘(丙业与丙丗丝不丈东:  0);
        return;
        label_11:
        if(this.丏东丕与丂丞七业丗 > 3)
        {
                return;
        }
        
        var val_32 = 106014332 + (this.丏东丕与丂丞七业丗) << 2;
        val_32 = val_32 + 106014332;
        goto (106014332 + (this.丏东丕与丂丞七业丗) << 2 + 106014332);
        label_5:
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丏丈丗世丙万丆丐丅:  this.上丂东丗丝丈业万丅)) == false)
        {
            goto label_26;
        }
        
        if(this.一三七丏丑丞且与丗 == null)
        {
            goto label_27;
        }
        
        val_40 = this.一三七丏丑丞且与丗;
        val_35 = this.上丂东丗丝丈业万丅;
        if(val_40 == null)
        {
            goto label_30;
        }
        
        val_41 = this.一三七丏丑丞且与丗.业万上丆丐丞且丒七;
        val_42 = val_40;
        goto label_46;
        label_26:
        GameConnect.与一丅丝不丈业与丙().JoinToRandomRoom(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丏丈丗世丙万丆丐丅:  this.上丂东丗丝丈业万丅, 丙丘东丏三丆丄丁丟:  this.丙丂万专丄丙丏东丛, 丕丞一丘丄丑丄一三:  GameConnect.丗丁丟丑三丟万丕丌(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不), 丐且丘丑与万丞丑丅:  this);
        return;
        label_27:
        this.世丁丙下万与且丁丅();
        return;
        label_30:
        val_42 = this.一三七丏丑丞且与丗;
        val_41 = this.一三七丏丑丞且与丗.业万上丆丐丞且丒七;
        if(val_42 == null)
        {
            goto label_45;
        }
        
        val_40 = val_42;
        goto label_46;
        label_45:
        val_40 = this.一三七丏丑丞且与丗;
        if(val_40 == null)
        {
            goto label_47;
        }
        
        label_46:
        val_33 = this.丙丂万专丄丙丏东丛;
        bool val_31 = MatchmakingConnect.instance.丑丝专丌一丒丂丅丛(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丏丈丗世丙万丆丐丅:  val_35, 业万上丆丐丞且丒七:  val_41, 专世专丟丝丌与丘上:  this.一三七丏丑丞且与丗.专世专丟丝丌与丘上, 万丝丑丂丆业丞丈七:  this.一三七丏丑丞且与丗.丗丘丆丄丝与东下上, 丐且丘丑与万丞丑丅:  val_40, 东丏与三丄丙三下丈:  this.专丆专上丘丟丑丘东, 东丆世丘丁丗专丆东:  val_33);
        return;
        label_47:
    }
    private string 一丗与丈丄丁东丄与()
    {
        int val_10 = System.String.alignConst;
        if(this.丏丂且七丅丄丗丅东 == 1)
        {
            goto label_1;
        }
        
        if((this.丏丂且七丅丄丗丅东 != 2) || (this.丐丘丌三丏与丙且东 == null))
        {
            goto label_6;
        }
        
        string val_2 = this.丐丘丌三丏与丙且东.业上丙丞丐丄丆丅七().ToString();
        goto label_4;
        label_1:
        if(this.丐丌丞东上万万丈丂 == null)
        {
            goto label_6;
        }
        
        label_4:
        val_10 = this.丐丌丞东上万万丈丂.专七东万不下丗丙世();
        if(val_10 == null)
        {
                val_10 = System.String.alignConst;
        }
        
        label_6:
        string[] val_4 = new string[5];
        val_4[0] = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
        val_4[1] = "_";
        val_4[2] = val_10;
        val_4[3] = "_";
        val_4[4] = this.丏丂且七丅丄丗丅东.ToString();
        return (string)+val_4;
    }
    private string 与东万丄丛丘业丏下()
    {
        string[] val_1 = new string[5];
        string val_4 = Rilisoft.Singleton<TournamentController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_4 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_4 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_4;
        val_1[1] = "_";
        val_1[2] = this.三世一丁丑专与丙丅.ToString();
        val_1[3] = "_";
        val_1[4] = this.丏东丕与丂丞七业丗.ToString();
        return (string)+val_1;
    }
    private void 丝丛丅专上业与丞七(bool 丒七丛丟丅丝丛丟万)
    {
        var val_2;
        if(丒七丛丟丅丝丛丟万 != false)
        {
                return;
        }
        
        if(this.丁丄万丙专丒七丅不 != false)
        {
                val_2 = null;
            val_2 = null;
            if((System.String.op_Equality(a:  SquadController.万一丘丗三三丈丗丛, b:  this.丘下丄丗丕业专丟丘)) != false)
        {
                this.OnConnectedToMaster();
            return;
        }
        
            int val_2 = this.丒丂万丕丐丑丏丈万;
            if(val_2 <= 4)
        {
                val_2 = val_2 + 1;
            this.丆丏丐丐七丐万东丛 = true;
            this.丟世不丂且丌丈丟世 = 1f;
            this.丒丂万丕丐丑丏丈万 = val_2;
            return;
        }
        
        }
        
        this.丕丙丈丘丆东丒下丝();
    }
    private void 丕丙丈丘丆东丒下丝()
    {
        this.OnExitSquad();
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3482"), 丞丁上丛与丌一一丐:  false, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
    }
    private void 世丁丙下万与且丁丅()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HideConnectionToMap();
        this.OnExitSquad();
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3483"), 丞丁上丛与丌一一丐:  false, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
    }
    private void OnJoinedRoom()
    {
        object val_88;
        var val_89;
        var val_90;
        var val_91;
        int val_92;
        var val_93;
        string val_94;
        var val_95;
        var val_96;
        var val_97;
        bool val_98;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        var val_105;
        var val_106;
        var val_107;
        var val_108;
        var val_109;
        int val_110;
        var val_111;
        var val_112;
        System.Collections.Generic.IEnumerable<T> val_113;
        var val_114;
        var val_115;
        var val_116;
        string val_117;
        string val_118;
        var val_119;
        var val_120;
        val_88 = this;
        if(this.业专丗且丏丘丘三丐() != false)
        {
                this.不与丞上丛丂丂丞丑();
        }
        
        if(this.丁丄万丙专丒七丅不 == false)
        {
            goto label_2;
        }
        
        val_89 = null;
        val_89 = null;
        val_90 = 1152921504833470464;
        UnityEngine.Debug.Log(message:  "On Joined Room " + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]);
        if(this.丏东丕与丂丞七业丗 != 3)
        {
            goto label_12;
        }
        
        val_91 = null;
        val_92 = System.String.alignConst;
        goto label_15;
        label_2:
        丛丗丐世下丛丄丞丟 val_88 = this.丏东丕与丂丞七业丗;
        val_88 = val_88 - 1;
        if(val_88 >= 3)
        {
                val_93 = null;
            val_93 = null;
            val_94 = GameConnect.丞且丌丅丙丞丆丘丏;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_94)) != false)
        {
                val_95 = null;
            val_95 = null;
            val_94 = GameConnect.丐丂丘丂丆丆世业丁;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_94)) != false)
        {
                val_96 = null;
            val_96 = null;
            object val_14 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丞且丌丅丙丞丆丘丏];
            val_94 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丐丂丘丂丆丆世业丁];
            val_97 = 0;
        }
        
        }
        
        }
        
        if(this.丐一下专丒丂丕丕丙 == true)
        {
            goto label_61;
        }
        
        val_100 = null;
        val_100 = null;
        val_94 = GameConnect.丟丞丏丝与丙丁丛与;
        object val_24 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_94];
        if(null != 1)
        {
            goto label_61;
        }
        
        this.OnExitSquad();
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3482"), 丞丁上丛与丌一一丐:  false, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
        return;
        label_12:
        val_92 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
        val_91 = null;
        label_15:
        SquadController.丕丙三丗丘丁丂丁丌 = val_92;
        val_101 = null;
        val_101 = null;
        val_102 = 0;
        SquadController.丈丄下丛丅丗丛丐东 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        丛丗丐世下丛丄丞丟 val_89 = this.丏东丕与丂丞七业丗;
        val_89 = val_89 | 1;
        bool val_32 = (val_89 == 3) ? 1 : 0;
        val_32 = ((val_89 == 1) ? 1 : 0) | val_32;
        SquadController.丘业不丅万不丐东丝 = val_32;
        SquadController.丁丛专丂业丞丑丐专 = this.不丒丒丏丞丏丛业丌;
        goto label_74;
        label_86:
        val_103 = null;
        val_103 = null;
        mem2[0] = SquadController.丈丄下丛丅丗丛丐东;
        val_101 = null;
        val_102 = 1;
        label_74:
        val_101 = null;
        if(val_102 < SquadController.丅丐丝下丞下下下上.Length)
        {
            goto label_86;
        }
        
        val_104 = null;
        val_104 = null;
        SquadController.一丝一丄丛丙丁东专 = this.丁丏丅丞东且丒下世;
        if(this.不丒丒丏丞丏丛业丌 != false)
        {
                val_105 = null;
            val_105 = null;
            MainMenuController.丂不三丈丕丑丌业下 = 0;
        }
        
        val_98 = this.不丒丒丏丞丏丛业丌;
        UnityEngine.Coroutine val_41 = this.StartCoroutine(routine:  MainMenuController.丝业丗上上丘丐与丗(丛丑丂丛丙一上专丆:  ((val_98 != true) ? 1 : 0) & (((this.丏东丕与丂丞七业丗 - 1) > 2) ? 1 : 0), 世不丛业丟丝与丆丙:  false, 丑丐丗三丒世丏东丅:  "", 丒不丙万万不丕丞与:  (val_98 == false) ? 1 : 0, 丌与一丌且一不七丆:  (val_98 == true) ? 1 : 0, 丝丅与业且一丛丒一:  false, 丁丟丑丆三丆业一丅:  (this.丏东丕与丂丞七业丗 == 3) ? 1 : 0, 丅与丏与丙东世丌世:  100));
        val_106 = null;
        val_106 = null;
        val_107 = null;
        val_107 = null;
        val_97 = 1152921540343642464;
        Rilisoft.一丟专且三万丞丁丂.三丗丛业世上丑一东(下丘下丝丂丄丝三东:  this.丛一丆专世丝丄丒与.Count, 丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丞丁丑丏丄丏七丂不:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆])).丙且上丒不下丑下丞());
        if(this.业专丗且丏丘丘三丐() != true)
        {
                丛丗丐世下丛丄丞丟 val_90 = this.丏东丕与丂丞七业丗;
            val_90 = val_90 | 1;
            Rilisoft.一丟专且三万丞丁丂.与丙专与丁东丟丝丂(业丂下丒丌且丄丞一:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0, 丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丙世不不一丏业三且:  ((val_90 == 1) ? 1 : 0) | ((val_90 == 3) ? 1 : 0));
        }
        
        val_94 = this.不丒丒丏丞丏丛业丌;
        val_88 = this.业专丗且丏丘丘三丐();
        Rilisoft.一丟专且三万丞丁丂.丘丈丟且不世东下丘(业丂下丒丌且丄丞一:  (val_94 == true) ? 1 : 0, 丝丛丛丟不与丒丗丄:  this.丛一丆专世丝丄丒与.Count, 且丗丌世与丄与专业:  (~val_88) & 1);
        return;
        label_61:
        val_90 = 1152921505107111936;
        string val_59 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        this.squadRoomName = val_59;
        val_108 = null;
        val_108 = null;
        SquadController.七丆丆丘业丝与丄业 = val_59;
        this.丘下丄丗丕业专丟丘 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丞丈业东专丅丆与七();
        this.丐一下专丒丂丕丕丙 = true;
        if(this.一世丘不丑丞东上丟 != false)
        {
                丛丗丐世下丛丄丞丟 val_91 = this.丏东丕与丂丞七业丗;
            val_91 = val_91 - 1;
            if(val_91 >= 3)
        {
                if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                this.丛丆丒且丛丘丙丞丞 = true;
            this.OnEnterSquad();
        }
        
        }
        
        }
        
        this.丈万丛丈丏丝丐丙下(业丄丒丑一丙丛丆丕:  0);
        if(this.业专丗且丏丘丘三丐() == false)
        {
            goto label_126;
        }
        
        this.上丞东三三丌业丂丙(专丞上七七且丝七丗:  0);
        object[] val_64 = new object[1];
        val_94 = val_64;
        val_94[0] = this.丝不丟丁丘丐丛一不;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  130, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_64);
        bool val_66 = 丅丒丗丑丒丙丛不丆.丌下丆丒丄丞七下与(专丄丘丌丌丂丒丗丄:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        if((System.String.IsNullOrEmpty(value:  this.下一世丛七丁且丂丆)) == true)
        {
            goto label_144;
        }
        
        this.SendInviteToPlayer(丆世丘丒丒丏上且丗:  this.下一世丛七丁且丂丆);
        val_109 = null;
        val_109 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_139;
        }
        
        val_110 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        goto label_143;
        label_126:
        this.上业丁丛丙丐丗丏丙 = false;
        goto label_144;
        label_139:
        val_110 = System.String.alignConst;
        label_143:
        val_94 = this.下一世丛七丁且丂丆 + val_110;
        FriendInviteInfoContainer.一且丕丙丆丟丙七丒.Add(item:  val_94);
        this.下一世丛七丁且丂丆 = System.String.alignConst;
        label_144:
        this.丄一丁三万丅丅丕丄(丝三丗丁七丄丘丌丒:  0);
        if(this.一世丘不丑丞东上丟 == false)
        {
                return;
        }
        
        val_111 = null;
        val_111 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丞且丌丅丙丞丆丘丏)) != false)
        {
                val_112 = null;
            val_112 = null;
            val_113 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丞且丌丅丙丞丆丘丏];
        }
        else
        {
                val_113 = 0;
        }
        
        System.Collections.Generic.List<System.Object> val_78 = new System.Collections.Generic.List<System.Object>();
        if(val_113 != 0)
        {
                val_78.AddRange(collection:  val_113);
        }
        
        val_114 = null;
        val_114 = null;
        if(SquadController.丅丐丝下丞下下下上 == null)
        {
            goto label_165;
        }
        
        val_98 = 1152921505719563712;
        val_90 = 1152921523884262800;
        val_97 = 1152921504624312320;
        val_115 = 0;
        goto label_166;
        label_188:
        val_116 = null;
        val_116 = null;
        var val_92 = 0;
        label_183:
        if(val_78 == null)
        {
            goto label_171;
        }
        
        if(val_92 < val_78.Count)
        {
            goto label_172;
        }
        
        goto label_174;
        label_171:
        if(val_92 >= val_78.Count)
        {
            goto label_174;
        }
        
        label_172:
        object val_81 = val_78.Item[0];
        if(val_81 == null)
        {
            goto label_179;
        }
        
        var val_82 = (null == null) ? (val_81) : 0;
        if((SquadController.丅丐丝下丞下下下上.Length + 32 + 32) == 0)
        {
            goto label_180;
        }
        
        label_182:
        var val_83 = ((SquadController.丅丐丝下丞下下下上.Length + 32 + 32) == null) ? (SquadController.丅丐丝下丞下下下上.Length + 32 + 32) : 0;
        goto label_181;
        label_179:
        val_117 = 0;
        if((SquadController.丅丐丝下丞下下下上.Length + 32 + 32) != 0)
        {
            goto label_182;
        }
        
        label_180:
        val_118 = 0;
        label_181:
        val_92 = val_92 + 1;
        if((System.String.op_Equality(a:  val_117, b:  val_118)) == false)
        {
            goto label_183;
        }
        
        goto label_184;
        label_174:
        val_78.Add(item:  SquadController.丅丐丝下丞下下下上.Length + 32);
        label_184:
        val_114 = null;
        val_115 = 1;
        label_166:
        val_114 = null;
        if(val_115 < SquadController.丅丐丝下丞下下下上.Length)
        {
            goto label_188;
        }
        
        label_165:
        ExitGames.Client.Photon.Hashtable val_85 = new ExitGames.Client.Photon.Hashtable();
        val_119 = null;
        val_120 = 1152921505107111936;
        val_94 = GameConnect.丞且丌丅丙丞丆丘丏;
        val_85.set_Item(key:  val_94, value:  val_78.ToArray());
        val_88 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_88.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_85, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void OnLeftRoom()
    {
    
    }
    private void 丛三丐丘丂丈专丏专(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        与丅丕丈丘东丝世丟 val_4;
        var val_5;
        val_4 = 专丞上七七且丝七丗;
        val_5 = 0;
        goto label_1;
        label_7:
        万丅世丈丕丕丌丅丗 val_1 = this.丛一丆专世丝丄丒与.Item[0];
        if((val_1.专丞上七七且丝七丗.Equals(丘丛丏丘丝七世七丅:  val_4)) == true)
        {
            goto label_5;
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < this.丛一丆专世丝丄丒与.Count)
        {
            goto label_7;
        }
        
        goto label_8;
        label_5:
        val_4 = this.丛一丆专世丝丄丒与;
        val_4.RemoveAt(index:  0);
        label_8:
        this.丄丕丛万丝三丌专丕();
    }
    internal void 丗丆丄专上七丛丕上(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, bool 丁丅丟丒丙丐丅与丂 = False)
    {
        SquadPanelGUI val_12;
        var val_13;
        SceneInfoController val_14;
        var val_15;
        int val_16;
        int val_17;
        var val_18;
        val_12 = this;
        if(丁丅丟丒丙丐丅与丂 == false)
        {
            goto label_1;
        }
        
        label_26:
        this.丝不丟丁丘丐丛一不 = 丂丛丑东不丅丈一东;
        if(this.丏东丕与丂丞七业丗 != 2)
        {
                this.squadUI.七丘业丟丝三丝专丟(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
            this.squadUI.丗丒下丛丏丛丆丅东(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
            object[] val_1 = new object[1];
            val_1[0] = this.丝不丟丁丘丐丛一不;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  130, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        }
        
        if(this.不丒丒丏丞丏丛业丌 == false)
        {
            goto label_10;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = SceneInfoController.丄丘七三上丕世丞业;
        if(val_14 == 0)
        {
            goto label_19;
        }
        
        val_15 = null;
        val_15 = null;
        val_14 = SceneInfoController.丄丘七三上丕世丞业;
        if((val_14.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  丂丛丑东不丅丈一东)) == null)
        {
            goto label_19;
        }
        
        if(val_3.avaliableScenes.Count < 1)
        {
            goto label_21;
        }
        
        SceneInfo val_5 = val_3.avaliableScenes.Item[0];
        goto label_23;
        label_1:
        if((this.业专丗且丏丘丘三丐() != false) && (this.下一丅丄丅与专万丘 != true))
        {
                if(this.丝不丟丁丘丐丛一不 != 丂丛丑东不丅丈一东)
        {
            goto label_26;
        }
        
        }
        
        this.丌与丛丟丏丕万丁七();
        return;
        label_19:
        UnityEngine.Debug.LogError(message:  "modeInfo == null");
        return;
        label_21:
        label_23:
        this.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
        label_10:
        this.丌与丛丟丏丕万丁七();
        this.三丂业丞丞丐丒世丁();
        if(this.不丒丒丏丞丏丛业丌 == false)
        {
            goto label_30;
        }
        
        if((BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  this.丝不丟丁丘丐丛一不)) == null)
        {
            goto label_33;
        }
        
        val_16 = val_7.丏上专丐三丛丁丗丆;
        goto label_34;
        label_30:
        val_17 = 0;
        val_18 = 0;
        val_14 = 0;
        this.丒丌下专专丁业丗丈 = 0;
        goto label_35;
        label_33:
        val_16 = 0;
        label_34:
        this.丒丌下专专丁业丗丈 = val_16;
        val_17 = this.丒丌下专专丁业丗丈;
        label_35:
        val_12 = this.squadUI;
        val_12.SetMiniGamesPriceActive(丅丛丝下丙且上七万:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0, 下专世下且丂东东丁:  val_17, 丅丙丗下丑不丞与丄:  (BankController.丈丐业丈丄丕丕三世() < val_17) ? 1 : 0);
    }
    private void 丌与丛丟丏丕万丁七()
    {
        Rilisoft.七丕丟丏三丈一丄世 val_6;
        int val_7;
        val_6 = this.丝不丟丁丘丐丛一不;
        val_7 = UnityEngine.Mathf.Min(a:  GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不), b:  5);
        this.世丗万丏下丆专丁丏 = val_7;
        if(val_6 == 16)
        {
                val_6 = this.丝不丟丁丘丐丛一不;
            val_7 = UnityEngine.Mathf.Min(a:  3, b:  5);
            this.世丗万丏下丆专丁丏 = val_7;
        }
        
        if(val_6 == 20)
        {
                val_6 = this.丝不丟丁丘丐丛一不;
            val_7 = UnityEngine.Mathf.Min(a:  4, b:  5);
            this.世丗万丏下丆专丁丏 = val_7;
        }
        
        if(val_6 == 31)
        {
                val_7 = UnityEngine.Mathf.Min(a:  4, b:  5);
            this.世丗万丏下丆专丁丏 = val_7;
        }
        
        this.squadUI.SetAvaliableSlots(丒丆丛上东丝三丟世:  val_7);
    }
    internal void 万专丂东与万丈与丘(SquadController.丛且丏丑丕丘丒丞且 丞丁丑丏丄丏七丂不)
    {
        if(this.业专丗且丏丘丘三丐() == false)
        {
                return;
        }
        
        if(this.下一丅丄丅与专万丘 != false)
        {
                return;
        }
        
        bool val_2 = UnityEngine.Object.op_Equality(x:  this.丑业业业丒丏丈丞下, y:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅);
        mem[1152921540360129032] = 丞丁丑丏丄丏七丂不.与丝丒万且丘丂丟三;
        this.丑业业业丒丏丈丞下 = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅;
        this.上丞东三三丌业丂丙(专丞上七七且丝七丗:  0);
        this.丏专丘上世东丆丅丏();
        this.丌与丛丟丏丕万丁七();
    }
    private void 上丞东三三丌业丂丙(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_6;
        object val_7;
        object val_8;
        object val_9;
        object[] val_1 = new object[3];
        if(专丞上七七且丝七丗 == null)
        {
            goto label_1;
        }
        
        if(this.丑业业业丒丏丈丞下 != 0)
        {
            goto label_4;
        }
        
        val_6 = 0;
        goto label_5;
        label_1:
        if(this.丑业业业丒丏丈丞下 != 0)
        {
            goto label_8;
        }
        
        val_7 = 0;
        goto label_9;
        label_4:
        val_6 = mem[this.丑业业业丒丏丈丞下 + 56];
        label_5:
        val_1[0] = val_6;
        val_8 = val_6.业上丙丞丐丄丆丅七();
        val_1[1] = val_8;
        val_9 = val_1.Length;
        val_1[2] = val_9;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  131, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
        return;
        label_8:
        val_7 = mem[this.丑业业业丒丏丈丞下 + 56];
        label_9:
        val_8 = 1152921504622075904;
        val_1[0] = val_7;
        val_1[1] = val_7.业上丙丞丐丄丆丅七();
        val_9 = val_1.Length;
        val_1[2] = val_9;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  131, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void OnEnterSquad()
    {
        var val_6;
        var val_7;
        var val_8;
        if(this.squadUI != 0)
        {
                this.squadUI.DeactivatePanel();
        }
        
        丛丗丐世下丛丄丞丟 val_6 = this.丏东丕与丂丞七业丗;
        val_6 = null;
        val_6 = val_6 - 1;
        if(val_6 > 2)
        {
            goto label_5;
        }
        
        val_7 = null;
        if(null != 0)
        {
            goto label_14;
        }
        
        goto label_10;
        label_5:
        val_8 = null;
        if(null != 0)
        {
            goto label_14;
        }
        
        label_10:
        label_14:
        SquadPanelGUI val_2 = 0.GetComponent<SquadPanelGUI>();
        this.squadUI = val_2;
        val_2.ActivatePanel(丅丛丝下丙且上七万:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0, 丁七万丟丆丟不万丗:  this.业专丗且丏丘丘三丐(), 丏东丕与丂丞七业丗:  this.丏东丕与丂丞七业丗);
        this.squadUI.SetAvaliableSlots(丒丆丛上东丝三丟世:  5);
        this.丞丙一世不丌专丏一 = true;
        this.丄丕丛万丝三丌专丕();
        this.业丘丐丗丘丐丌与不();
    }
    private void LateUpdate()
    {
        var val_9;
        Rilisoft.七丕丟丏三丈一丄世 val_10;
        丛且丏丑丕丘丒丞且 val_11;
        val_9 = this;
        if(this.丞丙一世不丌专丏一 == false)
        {
            goto label_1;
        }
        
        val_10 = this.三世一丁丑专与丙丅;
        this.squadUI.丏丛不丘丆丙丄三丛(丂丛丑东不丅丈一东:  val_10);
        if(this.不丒丒丏丞丏丛业丌 == true)
        {
            goto label_15;
        }
        
        this.丗丆丄专上七丛丕上(丂丛丑东不丅丈一东:  this.三世一丁丑专与丙丅, 丁丅丟丒丙丐丅与丂:  true);
        if(this.丏东丕与丂丞七业丗 == 3)
        {
            goto label_4;
        }
        
        if(this.丏东丕与丂丞七业丗 != 2)
        {
            goto label_5;
        }
        
        this.与七丂且七丙业丁不();
        goto label_11;
        label_4:
        this.丒丐丑三且丝丅丒丆();
        goto label_11;
        label_5:
        this.squadUI.ResetSelectedMapList();
        if(this.丗下丕丏丗丘丂丆业 != 0)
        {
                this.squadUI.三东七丄丆丞丌上丗(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丗下丕丏丗丘丂丆业, 丐且丘丑与万丞丑丅 = this.丗下丕丏丗丘丂丆业, 与丝丒万且丘丂丟三 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished});
        }
        
        label_11:
        val_10 = val_9;
        if(this.丗下丕丏丗丘丂丆业 != 0)
        {
                this.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丗下丕丏丗丘丂丆业, 丐且丘丑与万丞丑丅 = this.丗下丕丏丗丘丂丆业, 与丝丒万且丘丂丟三 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished});
        }
        
        label_15:
        this.丞丙一世不丌专丏一 = false;
        label_1:
        if(this.一且丑世丛三且下世 == false)
        {
            goto label_23;
        }
        
        this.一且丑世丛三且下世 = false;
        if(this.丏东丕与丂丞七业丗 == 3)
        {
            goto label_17;
        }
        
        if(this.丏东丕与丂丞七业丗 != 2)
        {
            goto label_18;
        }
        
        val_10 = val_9;
        if(this.丗下丕丏丗丘丂丆业 != 0)
        {
                this.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丗下丕丏丗丘丂丆业, 丐且丘丑与万丞丑丅 = this.丗下丕丏丗丘丂丆业, 与丝丒万且丘丂丟三 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished});
        }
        
        this.与七丂且七丙业丁不();
        goto label_23;
        label_17:
        this.丒丐丑三且丝丅丒丆();
        goto label_23;
        label_18:
        this.squadUI.丏丛不丘丆丙丄三丛(丂丛丑东不丅丈一东:  this.三世一丁丑专与丙丅);
        this.丗丆丄专上七丛丕上(丂丛丑东不丅丈一东:  this.三世一丁丑专与丙丅, 丁丅丟丒丙丐丅与丂:  true);
        if(this.丗下丕丏丗丘丂丆业 == 0)
        {
            
        }
        
        val_11 = this.世丄万丂七上丄丆业;
        mem[1152921540360662656] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
        this.世丄万丂七上丄丆业 = this.丗下丕丏丗丘丂丆业;
        if(this.三世一丁丑专与丙丅 == 22)
        {
                if((this.一业世丅丁七下丈不(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.世丄万丂七上丄丆业.丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅 = this.世丄万丂七上丄丆业.丏丈丗世丙万丆丐丅, 与丝丒万且丘丂丟三 = this.世丄万丂七上丄丆业.与丝丒万且丘丂丟三}, 上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东())) != true)
        {
                与丝丒万且丘丂丟三 = 0;
            mem2[0] = 0;
        }
        
        }
        
        this.squadUI.三东七丄丆丞丌上丗(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.世丄万丂七上丄丆业.丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅 = this.世丄万丂七上丄丆业.丏丈丗世丙万丆丐丅, 与丝丒万且丘丂丟三 = this.世丄万丂七上丄丆业.与丝丒万且丘丂丟三});
        this.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.世丄万丂七上丄丆业.丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅 = this.世丄万丂七上丄丆业.丏丈丗世丙万丆丐丅, 与丝丒万且丘丂丟三 = this.世丄万丂七上丄丆业.与丝丒万且丘丂丟三});
        label_23:
        if(this.丞与丙丑丗万上丕丘 == false)
        {
                return;
        }
        
        if(this.squadUI == 0)
        {
                return;
        }
        
        this.squadUI.三东七丄丆丞丌上丗(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丗下丕丏丗丘丂丆业, 丐且丘丑与万丞丑丅 = this.丗下丕丏丗丘丂丆业, 与丝丒万且丘丂丟三 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished});
        this.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.丗下丕丏丗丘丂丆业.丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅 = this.丗下丕丏丗丘丂丆业.丏丈丗世丙万丆丐丅, 与丝丒万且丘丂丟三 = this.丗下丕丏丗丘丂丆业.与丝丒万且丘丂丟三});
        this.丞与丙丑丗万上丕丘 = false;
    }
    private void 与七丂且七丙业丁不()
    {
        PGCompany.丟与丞丗丌丂万丕丝 val_1;
        if(this.丏丂且七丅丄丗丅东 != 1)
        {
                if(this.丏丂且七丅丄丗丅东 != 2)
        {
                return;
        }
        
            val_1 = this.丐丘丌三丏与丙且东;
            if(val_1 == null)
        {
                return;
        }
        
            this.squadUI.丄专丂丙丑一世丞不(且世上丙与丐一丛业:  val_1);
            return;
        }
        
        val_1 = this.丐丌丞东上万万丈丂;
        if(val_1 == null)
        {
                return;
        }
        
        this.squadUI.丒下丒丏丂丌丞东丝(丌丝万上丅丒一丈丘:  val_1);
    }
    private void 丒丐丑三且丝丅丒丆()
    {
        if(this.三世一丁丑专与丙丅 != 26)
        {
                if(this.三世一丁丑专与丙丅 != 27)
        {
                return;
        }
        
            this.squadUI.丐丂上丑丛不丞丞丄();
            return;
        }
        
        this.squadUI.且东丂东丗且不七下();
    }
    public void OnExitSquad()
    {
        var val_7;
        this.丐一下专丒丂丕丕丙 = false;
        this.丏东丕与丂丞七业丗 = 0;
        val_7 = null;
        val_7 = null;
        SquadController.上丂七上丘且丕且丈 = 0;
        mem[1152921540361137960] = 0;
        mem[1152921540361137968] = 0;
        this.丗下丕丏丗丘丂丆业 = 0;
        this.丞与丙丑丗万上丕丘 = false;
        this.丛丌丕东不丙与丅丞();
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().三不万不丕丑一上与() >= 2)
        {
                UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.DisconnectWithRPC());
            return;
        }
        
        }
        
        GameConnect.下与业丒丝丕丙丘丙();
    }
    public System.Collections.IEnumerator DisconnectWithRPC()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SquadController.丈万丒东丂且丂万丞(丗丏丅丕丆世丁专丟:  0);
    }
    public void ExitFromSquadPanel()
    {
        var val_2;
        if((this.丁丄万丙专丒七丅不 != false) && (this.万且不丒不下丙丟与 != false))
        {
                if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
        }
        
            GameConnect.下与业丒丝丕丙丘丙();
            return;
        }
        
        val_2 = null;
        val_2 = null;
        与丂丏丛丞丞丒丟丄.丘且丝万丙丕丙丁丙 = System.String.alignConst;
        this.OnExitSquad();
        this.squadUI.DeactivatePanel();
        if(this.丛丝与丂世丌丌丝丂 != null)
        {
                this.丛丝与丂世丌丌丝丂.Invoke();
        }
        
        this.squadUI = 0;
    }
    private void 丟丟丟丟丄专丕丆丝()
    {
        this.OnExitSquad();
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.不丒丒丏丞丏丛业丌 == true) ? "Key_3493" : "Key_3484"), 丞丁上丛与丌一一丐:  false, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
    }
    private void 世上丈丄世丐丕丐东()
    {
        this.三丑七丙丌丁三丈下 = true;
        this.OnExitSquad();
        this.东丒丘丁丆丒丝丈丘(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.不丒丒丏丞丏丛业丌 == true) ? "Key_3490" : "Key_3481"), 丞丁上丛与丌一一丐:  false, 丈业丙万世不业世不:  new System.Action(object:  this, method:  public System.Void SquadController::ExitFromSquadPanel()));
    }
    public void KickPlayer(SquadController.万丅世丈丕丕丌丅丗 专丞上七七且丝七丗, bool 三不与丐下丕丅世丙 = False)
    {
        bool val_5 = 三不与丐下丕丅世丙;
        if(this.业专丗且丏丘丘三丐() == false)
        {
                return;
        }
        
        if(val_5 != false)
        {
                if(this.业专丗且丏丘丘三丐() == false)
        {
                return;
        }
        
            if(this.下一丅丄丅与专万丘 == true)
        {
                return;
        }
        
        }
        
        val_5 = 专丞上七七且丝七丗.专丞上七七且丝七丗;
        if(val_5 != null)
        {
                this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  137, 万丌万丅专丞业丈万:  val_5, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            bool val_4 = 丅丒丗丑丒丙丛不丆.丑丌七丗丐丌丆丏万(与丐丞丒上丈业丐丄:  专丞上七七且丝七丗.专丞上七七且丝七丗);
            this.一丟世丐世万丂与丁(不丟丗丏丛丕不丁丌:  专丞上七七且丝七丗.专丞上七七且丝七丗);
            return;
        }
        
        专丞上七七且丝七丗.丆不丐一丙丐丏丗上 = true;
    }
    private void 业丘丐丗丘丐丌与不()
    {
        object val_18;
        var val_19;
        System.Action<与丅丕丈丘东丝世丟> val_20;
        var val_21;
        var val_22;
        System.Action<与丅丕丈丘东丝世丟> val_23;
        var val_24;
        System.Action val_25;
        var val_26;
        var val_27;
        System.Action val_28;
        var val_29;
        var val_30;
        System.Action val_31;
        var val_32;
        System.Action<System.Boolean> val_33;
        var val_34;
        丑丕与三丟且三丈丌 val_35;
        var val_36;
        System.Action val_37;
        val_18 = this;
        if(this.丕丅丒丆丏丄丑丌业 == true)
        {
                return;
        }
        
        this.丕丅丒丆丏丄丑丌业 = true;
        val_19 = null;
        val_19 = null;
        val_21 = null;
        val_22 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SquadController::丗丑与丂且三东丛东(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != val_22))
        {
                val_21 = null;
            val_22 = null;
            val_20 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_20;
        val_24 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丅三业三丙专丏丟丐, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SquadController::上丘三丞专一丂丕丕(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_24 = null;
            val_23 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_23;
        val_26 = null;
        val_27 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void SquadController::OnDisconnectedFromPhoton()))) != null) && (null != val_27))
        {
                val_26 = null;
            val_27 = null;
            val_25 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_25;
        val_29 = null;
        val_30 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  System.Void SquadController::OnConnectedToMaster()))) != null) && (null != val_30))
        {
                val_29 = null;
            val_30 = null;
            val_28 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_28;
        val_32 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void SquadController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_32 = null;
            val_31 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_31;
        val_34 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void SquadController::丝丛丅专上业与丞七(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_34 = null;
            val_33 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_33;
        val_36 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadController::OnFailedToConnect(int 世丁丙世丄一万丆三)))) != null) && (null != null))
        {
                val_36 = null;
            val_35 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_35;
        if(((System.Delegate.Combine(a:  GameConnect.丄丛丐不丒下三丟丂, b:  new System.Action(object:  this, method:  System.Void SquadController::OnLeftRoom()))) != null) && (null != null))
        {
                val_37 = 0;
        }
        
        GameConnect.丄丛丐不丒下三丟丂 = val_37;
    }
    private void 丛丌丕东不丙与丅丞()
    {
        object val_18;
        var val_19;
        System.Action<与丅丕丈丘东丝世丟> val_20;
        var val_21;
        var val_22;
        System.Action<与丅丕丈丘东丝世丟> val_23;
        var val_24;
        System.Action val_25;
        var val_26;
        var val_27;
        System.Action val_28;
        var val_29;
        var val_30;
        System.Action val_31;
        var val_32;
        System.Action<System.Boolean> val_33;
        var val_34;
        丑丕与三丟且三丈丌 val_35;
        var val_36;
        System.Action val_37;
        val_18 = this;
        if(this.丕丅丒丆丏丄丑丌业 == false)
        {
                return;
        }
        
        this.丕丅丒丆丏丄丑丌业 = false;
        val_19 = null;
        val_19 = null;
        val_21 = null;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SquadController::丗丑与丂且三东丛东(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != val_22))
        {
                val_21 = null;
            val_22 = null;
            val_20 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_20;
        val_24 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丅三业三丙专丏丟丐, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SquadController::上丘三丞专一丂丕丕(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_24 = null;
            val_23 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_23;
        val_26 = null;
        val_27 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void SquadController::OnDisconnectedFromPhoton()))) != null) && (null != val_27))
        {
                val_26 = null;
            val_27 = null;
            val_25 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_25;
        val_29 = null;
        val_30 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  System.Void SquadController::OnConnectedToMaster()))) != null) && (null != val_30))
        {
                val_29 = null;
            val_30 = null;
            val_28 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_28;
        val_32 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void SquadController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_32 = null;
            val_31 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_31;
        val_34 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void SquadController::丝丛丅专上业与丞七(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_34 = null;
            val_33 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_33;
        val_36 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadController::OnFailedToConnect(int 世丁丙世丄一万丆三)))) != null) && (null != null))
        {
                val_36 = null;
            val_35 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_35;
        if(((System.Delegate.Remove(source:  GameConnect.丄丛丐不丒下三丟丂, value:  new System.Action(object:  this, method:  System.Void SquadController::OnLeftRoom()))) != null) && (null != null))
        {
                val_37 = 0;
        }
        
        GameConnect.丄丛丐不丒下三丟丂 = val_37;
    }
    private void OnDestroy()
    {
        var val_2;
        if(this.丛一丆专世丝丄丒与 != null)
        {
                val_2 = null;
            val_2 = null;
            SquadController.丐专丛业丌丘与专丙 = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>(collection:  this.丛一丆专世丝丄丒与);
        }
        
        this.丛丌丕东不丙与丅丞();
    }
    private void OnDisable()
    {
    
    }
    private void Awake()
    {
        null = null;
        SquadController.丄丘七三上丕世丞业 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        GamePauseController val_3 = this.gameObject.AddComponent<GamePauseController>();
        this.三丂丘丈丏丑丝下丕 = val_3;
        val_3.专世丈丛丛丕丝世专(丑丅丛丌丄下万世丏:  false);
    }
    private void 丏丏丆丕不万丝丄丙()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>> val_64;
        var val_65;
        string val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_79;
        var val_80;
        string val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_87;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_64 = 1152921505066536960;
        val_65 = null;
        val_65 = null;
        val_66 = GameConnect.丞且丌丅丙丞丆丘丏;
        val_67 = 1152921525484599408;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_66)) == false)
        {
                return;
        }
        
        val_68 = null;
        val_68 = null;
        object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丞且丌丅丙丞丆丘丏];
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丐丂丘丂丆丆世业丁)) != false)
        {
                val_69 = null;
            val_69 = null;
            object val_13 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丐丂丘丂丆丆世业丁];
        }
        
        this.且丞丂丟丆丕丂世丕.Clear();
        this.丅东丈丒丏丟万东丘.Clear();
        this.丁丑一丈丆丁丒丘丕.Clear();
        this.丏丝东丂万下七专丄.Clear();
        val_70 = 0;
        goto label_31;
        label_119:
        var val_14 = ((System.Object.__il2cppRuntimeField_byval_arg + 32) == null) ? (System.Object.__il2cppRuntimeField_byval_arg + 32) : 0;
        var val_15 = ((System.Object.__il2cppRuntimeField_byval_arg + 40) == null) ? (System.Object.__il2cppRuntimeField_byval_arg + 40) : 0;
        val_73 = 0;
        if((val_73 == 0) || (val_70 >= 28563616))
        {
            goto label_43;
        }
        
        if(val_70 >= 28563616)
        {
                val_73 = 0;
        }
        
        var val_16 = val_73 + 0;
        val_64 = mem[(val_73 + 0) + 32];
        val_64 = (val_73 + 0) + 32;
        if(val_64 <= 0)
        {
            goto label_43;
        }
        
        if(val_70 >= 28563616)
        {
                val_64 = mem[(val_73 + 0) + 32];
            val_64 = (val_73 + 0) + 32;
        }
        
        val_74 = 1152921516995548064;
        val_75 = val_64;
        goto label_46;
        label_43:
        val_76 = 0;
        goto label_47;
        label_52:
        val_76 = 1;
        label_47:
        if(val_76 >= this.丛丒丟且丒且万丛世.Count)
        {
            goto label_55;
        }
        
        万丅世丈丕丕丌丅丗 val_18 = this.丛丒丟且丒且万丛世.Item[1];
        if((System.String.op_Equality(a:  val_18.万丛与丒丑丈七东丐, b:  null)) == false)
        {
            goto label_52;
        }
        
        val_64 = this.丛丒丟且丒且万丛世.Item[1];
        if(val_20.丆不丐一丙丐丏丗上 == false)
        {
            goto label_55;
        }
        
        val_77 = 2;
        goto label_56;
        label_55:
        val_64 = 0;
        label_68:
        if(val_64 >= this.丛一丆专世丝丄丒与.Count)
        {
            goto label_58;
        }
        
        万丅世丈丕丕丌丅丗 val_22 = this.丛一丆专世丝丄丒与.Item[0];
        if(val_22.专丞上七七且丝七丗 == null)
        {
            goto label_61;
        }
        
        万丅世丈丕丕丌丅丗 val_23 = this.丛一丆专世丝丄丒与.Item[0];
        if((System.String.op_Equality(a:  val_23.专丞上七七且丝七丗.丞丈业东专丅丆与七(), b:  null)) == true)
        {
            goto label_76;
        }
        
        label_61:
        万丅世丈丕丕丌丅丗 val_26 = this.丛一丆专世丝丄丒与.Item[0];
        val_64 = val_64 + 1;
        if((System.String.op_Equality(a:  val_26.丆世丘丒丒丏上且丗, b:  null)) == false)
        {
            goto label_68;
        }
        
        goto label_76;
        label_58:
        if((this.专与丅丗丆丅上三一.Contains(item:  null)) == false)
        {
            goto label_83;
        }
        
        val_64 = this.与丂丞丅丂一下丈与;
        if((val_64.ContainsKey(key:  null)) == false)
        {
            goto label_76;
        }
        
        val_64 = this.与丂丞丅丂一下丈与.Item[null];
        if((val_64.ContainsKey(key:  "room_name")) == false)
        {
            goto label_76;
        }
        
        val_64 = this.与丂丞丅丂一下丈与;
        var val_34 = ((System.Object.__il2cppRuntimeField_byval_arg + 72) == null) ? (System.Object.__il2cppRuntimeField_byval_arg + 72) : 0;
        if((System.String.op_Inequality(a:  val_64.Item[null].Item["room_name"], b:  null)) == false)
        {
            goto label_83;
        }
        
        label_76:
        val_77 = 1;
        label_56:
        this.丏丝东丂万下七专丄.Add(item:  1);
        goto label_85;
        label_83:
        val_79 = 0;
        goto label_86;
        label_91:
        val_79 = 1;
        label_86:
        if(val_79 >= this.丛丒丟且丒且万丛世.Count)
        {
            goto label_88;
        }
        
        万丅世丈丕丕丌丅丗 val_37 = this.丛丒丟且丒且万丛世.Item[1];
        if((System.String.op_Equality(a:  val_37.万丛与丒丑丈七东丐, b:  null)) == false)
        {
            goto label_91;
        }
        
        val_64 = 1152921516107659296;
        this.且丞丂丟丆丕丂世丕.Add(item:  this.丛丒丟且丒且万丛世.Item[1]);
        万丅世丈丕丕丌丅丗 val_40 = this.丛丒丟且丒且万丛世.Item[1];
        this.丅东丈丒丏丟万东丘.Add(item:  val_40.丆世丘丒丒丏上且丗);
        万丅世丈丕丕丌丅丗 val_41 = this.丛丒丟且丒且万丛世.Item[1];
        val_80 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
        val_81 = val_41.万丛与丒丑丈七东丐;
        goto label_100;
        label_88:
        val_82 = mem[System.Object.__il2cppRuntimeField_byval_arg + 24];
        val_82 = System.Object.__il2cppRuntimeField_byval_arg + 24;
        if(val_82 <= 1)
        {
                val_82 = mem[System.Object.__il2cppRuntimeField_byval_arg + 24];
            val_82 = System.Object.__il2cppRuntimeField_byval_arg + 24;
        }
        
        val_83 = mem[System.Object.__il2cppRuntimeField_byval_arg + 40];
        val_83 = System.Object.__il2cppRuntimeField_byval_arg + 40;
        if(val_82 <= 2)
        {
                val_82 = mem[System.Object.__il2cppRuntimeField_byval_arg + 24];
            val_82 = System.Object.__il2cppRuntimeField_byval_arg + 24;
        }
        
        val_84 = mem[System.Object.__il2cppRuntimeField_byval_arg + 48];
        val_84 = System.Object.__il2cppRuntimeField_byval_arg + 48;
        if(val_82 <= 4)
        {
                val_82 = mem[System.Object.__il2cppRuntimeField_byval_arg + 24];
            val_82 = System.Object.__il2cppRuntimeField_byval_arg + 24;
        }
        
        if(val_82 <= 3)
        {
                val_82 = mem[System.Object.__il2cppRuntimeField_byval_arg + 24];
            val_82 = System.Object.__il2cppRuntimeField_byval_arg + 24;
        }
        
        var val_44 = ((System.Object.__il2cppRuntimeField_byval_arg + 56) == null) ? (System.Object.__il2cppRuntimeField_byval_arg + 56) : 0;
        var val_45 = ((System.Object.__il2cppRuntimeField_byval_arg + 32) == null) ? (System.Object.__il2cppRuntimeField_byval_arg + 32) : 0;
        new SquadController.万丅世丈丕丕丌丅丗() = new SquadController.万丅世丈丕丕丌丅丗(专丞上七七且丝七丗:  0, 不丒丈丅丟丑丟丒业:  false, 丁三上丂丅丏丏丁丕:  false, 丆世丘丒丒丏上且丗:  (val_83 == null) ? (val_83) : 0, 丛三三与丁丘丄丑下:  (val_84 == null) ? (val_84) : 0, 专世专丟丝丌与丘上:  System.Object.__il2cppRuntimeField_byval_arg + 64, 丈丐世下丞与丂专丏:  0, 丂丒丘丅专丗丂世丛:  null, 万丛与丒丑丈七东丐:  null, 上丕丈丞丌丘丅不与:  0);
        this.且丞丂丟丆丕丂世丕.Add(item:  new SquadController.万丅世丈丕丕丌丅丗());
        val_64 = 1152921516107659296;
        this.丅东丈丒丏丟万东丘.Add(item:  (SquadController.万丅世丈丕丕丌丅丗)[1152921540363604368].丆世丘丒丒丏上且丗);
        val_80 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
        val_81 = (SquadController.万丅世丈丕丕丌丅丗)[1152921540363604368].万丛与丒丑丈七东丐;
        label_100:
        this.丁丑一丈丆丁丒丘丕.Add(item:  val_81);
        val_74 = 1152921516995548064;
        val_75 = 0;
        label_46:
        this.丏丝东丂万下七专丄.Add(item:  0);
        label_85:
        val_70 = 1;
        label_31:
        if(val_70 < val_74)
        {
            goto label_119;
        }
        
        this.丛丒丟且丒且万丛世.Clear();
        val_66 = this.且丞丂丟丆丕丂世丕;
        val_67 = 1152921505107111936;
        this.丛丒丟且丒且万丛世.AddRange(collection:  val_66);
        if(this.丛丒丟且丒且万丛世.Count != this.下且东丄丒丘丁丌东)
        {
                this.下且东丄丒丘丁丌东 = this.丛丒丟且丒且万丛世.Count;
            this.丄丕丛万丝三丌专丕();
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_140;
        }
        
        float val_50 = UnityEngine.Time.deltaTime;
        val_50 = this.丒不丁丏丐丗丆丐三 - val_50;
        var val_51 = (val_50 >= 0) ? 1 : 0;
        val_51 = 1 | val_51;
        this.丒不丁丏丐丗丆丐三 = val_50;
        if((val_51 & 1) != 0)
        {
            goto label_133;
        }
        
        丛丗丐世下丛丄丞丟 val_65 = this.丏东丕与丂丞七业丗;
        val_65 = val_65 - 1;
        if((val_65 < 3) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丆丁丑丟且丅世丝业() == null))
        {
            goto label_133;
        }
        
        System.String[] val_55 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丆丁丑丟且丅世丝业();
        val_66 = this.丛丒丟且丒且万丛世;
        if(val_66.Count != val_55.Length)
        {
            goto label_139;
        }
        
        label_133:
        if((1 & 1) == 0)
        {
            goto label_140;
        }
        
        label_156:
        丛丗丐世下丛丄丞丟 val_66 = this.丏东丕与丂丞七业丗;
        val_66 = val_66 - 1;
        if(val_66 >= 3)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丟丘丂丝丈丐业业丝(丙丘东丏三丆丄丁丟:  this.丁丑一丈丆丁丒丘丕.ToArray());
        }
        
        ExitGames.Client.Photon.Hashtable val_59 = new ExitGames.Client.Photon.Hashtable();
        val_87 = null;
        val_87 = null;
        val_59.set_Item(key:  GameConnect.丐丂丘丂丆丆世业丁, value:  this.丏丝东丂万下七专丄.ToArray());
        val_66 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_66.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_59, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        label_140:
        float val_62 = UnityEngine.Time.time;
        if(this.丕万东丘丐丅上与七 >= 0)
        {
                return;
        }
        
        if(this.丅东丈丒丏丟万东丘.Count < 1)
        {
                return;
        }
        
        this.且不丘下且丝丙丟一(世丅丈东丘丐丕丟丐:  this.丅东丈丒丏丟万东丘);
        float val_64 = UnityEngine.Time.time;
        val_64 = val_64 + 10f;
        this.丕万东丘丐丅上与七 = val_64;
        return;
        label_139:
        this.丒不丁丏丐丗丆丐三 = 1f;
        goto label_156;
    }
    private void Update()
    {
        var val_61;
        float val_62;
        var val_64;
        var val_65;
        var val_66;
        System.Collections.Generic.List<万丅世丈丕丕丌丅丗> val_67;
        val_61 = this;
        if(this.squadUI == 0)
        {
                return;
        }
        
        this.丏丏丆丕不万丝丄丙();
        if(this.丁丈丆丟专丛且丐丘 != false)
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_10;
        }
        
        }
        
        }
        
        label_66:
        if(this.丆丏丐丐七丐万东丛 != false)
        {
                val_62 = this.丟世不丂且丌丈丟世;
            if(val_62 > 0f)
        {
                float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_62 - val_4;
            this.丟世不丂且丌丈丟世 = val_4;
        }
        else
        {
                this.丆丏丐丐七丐万东丛 = false;
            bool val_5 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  this.专丒不丈下东丝丝上);
        }
        
        }
        
        丛丗丐世下丛丄丞丟 val_61 = this.丏东丕与丂丞七业丗;
        val_61 = val_61 - 1;
        if(val_61 > 2)
        {
            goto label_70;
        }
        
        if(this.squadUI.isActive == false)
        {
            goto label_67;
        }
        
        bool val_62 = this.丟一丁丐三丄丟丒丝;
        val_62 = ((val_62 == true) ? 1 : 0) ^ this.业专丗且丏丘丘三丐();
        if((val_62 == false) || (this.万且不丒不下丙丟与 == true))
        {
            goto label_67;
        }
        
        if(this.上业丁丛丙丐丗丏丙 != true)
        {
                this.三世一丁丑专与丙丅 = this.丝不丟丁丘丐丛一不;
            mem[1152921540364149504] = ???;
            this.世丄万丂七上丄丆业 = this.丑业业业丒丏丈丞下;
        }
        
        this.丟一丁丐三丄丟丒丝 = this.业专丗且丏丘丘三丐();
        this.squadUI.ActivatePanel(丅丛丝下丙且上七万:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0, 丁七万丟丆丟不万丗:  this.业专丗且丏丘丘三丐(), 丏东丕与丂丞七业丗:  this.丏东丕与丂丞七业丗);
        this.丄丕丛万丝三丌专丕();
        bool val_13 = this.业专丗且丏丘丘三丐();
        if(this.上业丁丛丙丐丗丏丙 == false)
        {
            goto label_23;
        }
        
        if(val_13 != false)
        {
                this.丞丙一世不丌专丏一 = true;
        }
        
        this.上业丁丛丙丐丗丏丙 = false;
        goto label_67;
        label_10:
        if(((丅丒丗丑丒丙丛不丆.专下一丙东七丄三上() == null) || (丅丒丗丑丒丙丛不丆.专下一丙东七丄三上().Count < 1)) || (丅丒丗丑丒丙丛不丆.专下一丙东七丄三上().Item[0].丄丈丟丅丁丝丅丘业() == false))
        {
            goto label_37;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Joining to room " + 丅丒丗丑丒丙丛不丆.专下一丙东七丄三上().Item[0].且丁丙丑丄丁丄与丑());
        }
        
        string val_27 = 丅丒丗丑丒丙丛不丆.专下一丙东七丄三上().Item[0].且丁丙丑丄丁丄与丑();
        this.专丒不丈下东丝丝上 = val_27;
        this.丒丂万丕丐丑丏丈万 = 0;
        bool val_28 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  val_27);
        this.丁丈丆丟专丛且丐丘 = false;
        goto label_66;
        label_37:
        if(this.世万丏丏业不东丂一 <= 0f)
        {
            goto label_52;
        }
        
        float val_29 = UnityEngine.Time.deltaTime;
        val_29 = this.世万丏丏业不东丂一 - val_29;
        this.世万丏丏业不东丂一 = val_29;
        goto label_66;
        label_52:
        int val_63 = this.专且万万丝丅上世丟;
        if(val_63 <= 6)
        {
            goto label_54;
        }
        
        this.丁丈丆丟专丛且丐丘 = false;
        GameConnect.下与业丒丝丕丙丘丙();
        goto label_66;
        label_54:
        val_63 = val_63 + 1;
        this.专且万万丝丅上世丟 = val_63;
        string[] val_30 = new string[1];
        val_64 = null;
        val_64 = null;
        val_30[0] = SquadController.万一丘丗三三丈丗丛;
        bool val_31 = 丅丒丗丑丒丙丛不丆.丙且丟丂丒东丏丐丘(丁丈丈丗与丑丌丄专:  val_30);
        this.世万丏丏业不东丂一 = 1f;
        goto label_66;
        label_23:
        if(val_13 != false)
        {
                this.一且丑世丛三且下世 = true;
        }
        
        label_67:
        if(丅丒丗丑丒丙丛不丆.一丐丒丒一业丁丂丁() != null)
        {
                this.不丒丗丒丝丟丁丒丗 = 丅丒丗丑丒丙丛不丆.一丐丒丒一业丁丂丁().业丐丐三丕一丗丛丁();
        }
        
        label_70:
        if(this.下一丅丄丅与专万丘 != false)
        {
                val_62 = UnityEngine.Mathf.Max(a:  0f, b:  this.与三世丂丕丅一丄丄 - UnityEngine.Time.deltaTime);
            this.与三世丂丕丅一丄丄 = val_62;
            val_65 = 1;
        }
        else
        {
                val_65 = 0;
        }
        
        this.squadUI.UpdateStartTimer(丛与丙丒丒下丌丟且:  false, 丙业与丙丗丝不丈东:  0f);
        if(((this.三丕丗丆丝下丝丘丈() == null) || (this.丛一丆专世丝丄丒与 == null)) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_84;
        }
        
        val_66 = 0;
        goto label_85;
        label_102:
        万丅世丈丕丕丌丅丗 val_40 = this.丛一丆专世丝丄丒与.Item[0];
        if(val_40.丆不丐一丙丐丏丗上 != true)
        {
                万丅世丈丕丕丌丅丗 val_41 = this.丛一丆专世丝丄丒与.Item[0];
            if((与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  val_41.专丞上七七且丝七丗.业丐丐三丕一丗丛丁())) == null)
        {
                万丅世丈丕丕丌丅丗 val_44 = this.丛一丆专世丝丄丒与.Item[0];
            val_44.丄丐丗专丆一东不丘(东一丁世丑丞业丄丐:  val_44);
            this.丄丕丛万丝三丌专丕();
        }
        
        }
        
        万丅世丈丕丕丌丅丗 val_45 = this.丛一丆专世丝丄丒与.Item[0];
        if(val_45.丆不丐一丙丐丏丗上 == false)
        {
            goto label_96;
        }
        
        万丅世丈丕丕丌丅丗 val_46 = this.丛一丆专世丝丄丒与.Item[0];
        val_62 = val_46.三丘万业丁一丞丒丏;
        float val_47 = UnityEngine.Time.time;
        if(val_62 < 0)
        {
            goto label_100;
        }
        
        丛丗丐世下丛丄丞丟 val_64 = this.丏东丕与丂丞七业丗;
        val_64 = val_64 - 1;
        if(val_64 <= 2)
        {
            goto label_100;
        }
        
        label_96:
        val_66 = 1;
        label_85:
        val_67 = this.丛一丆专世丝丄丒与;
        if(val_66 < val_67.Count)
        {
            goto label_102;
        }
        
        goto label_111;
        label_84:
        this.squadUI.UpdateStartTimer(丛与丙丒丒下丌丟且:  false, 丙业与丙丗丝不丈东:  0f);
        return;
        label_100:
        if(this.丛一丆专世丝丄丒与.Item[0].业专丗且丏丘丘三丐() != false)
        {
                丛丗丐世下丛丄丞丟 val_65 = this.丏东丕与丂丞七业丗;
            val_65 = val_65 - 1;
            if(val_65 >= 3)
        {
                this.丟丟丟丟丄专丕丆丝();
        }
        
        }
        
        万丅世丈丕丕丌丅丗 val_51 = this.丛一丆专世丝丄丒与.Item[0];
        val_51.丘丆三丘丘丛丌丄世(东一丁世丑丞业丄丐:  val_51);
        val_67 = this.丛一丆专世丝丄丒与;
        val_67.RemoveAt(index:  0);
        this.丄丕丛万丝三丌专丕();
        if(this.业专丗且丏丘丘三丐() != false)
        {
                this.丗上丝丂业丑丕丗丛();
        }
        
        label_111:
        if(this.下一丅丄丅与专万丘 != false)
        {
                if((((this.业专丗且丏丘丘三丐() != false) && (this.丁丄万丙专丒七丅不 != true)) && (this.丌丞丅下下丟世丙丌 != true)) && (this.与三世丂丕丅一丄丄 <= 0f))
        {
                this.丌丞丅下下丟世丙丌 = true;
            UnityEngine.Coroutine val_55 = this.StartCoroutine(routine:  this.丄一丆下丗七丁丑丏());
        }
        
        }
        
        if(this.不丒丒丏丞丏丛业丌 != false)
        {
                int val_56 = BankController.丈丐业丈丄丕丕三世();
            if(val_56 != this.丛丂与丐东丕丟一一)
        {
                val_67 = this.squadUI;
            val_67.SetMiniGamesPriceActive(丅丛丝下丙且上七万:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0, 下专世下且丂东东丁:  this.丒丌下专专丁业丗丈, 丅丙丗下丑不丞与丄:  (val_56 < this.丒丌下专专丁业丗丈) ? 1 : 0);
            this.丛丂与丐东丕丟一一 = val_56;
        }
        
        }
        
        丛丗丐世下丛丄丞丟 val_66 = this.丏东丕与丂丞七业丗;
        val_66 = val_66 - 1;
        if(val_66 > 2)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                return;
        }
        
        this.ExitFromSquadPanel();
    }
    private void 丐丆下不与丈东一丄()
    {
        this.东丏东上七一万丆丌.Clear();
        this.东丏东上七一万丆丌.AddRange(collection:  this.丛一丆专世丝丄丒与);
        bool val_2 = this.东丏东上七一万丆丌.Remove(item:  this.三丕丗丆丝下丝丘丈());
        this.东丏东上七一万丆丌.Sort(comparison:  new System.Comparison<万丅世丈丕丕丌丅丗>(object:  this, method:  System.Int32 SquadController::丛丂且丆不不万丛丐(SquadController.万丅世丈丕丕丌丅丗 三丟东丕丄丄下下丑, SquadController.万丅世丈丕丕丌丅丗 丒丒丄丁且丄丆丂丌)));
        this.squadUI.UpdateSquadTicketsInfo(丛一丆专世丝丄丒与:  this.东丏东上七一万丆丌, 丒丈上丄不丁与与一:  this.丒丌下专专丁业丗丈);
    }
    private void 三丂业丞丞丐丒世丁()
    {
        this.丞丕东上丆丏丆三七 = false;
        this.squadUI.SetFullStatus(丄丒丆丘丘丂丈世丅:  false);
    }
    private void 丗丑与丂且三东丛东(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        this.丈万丛丈丏丝丐丙下(业丄丒丑一丙丛丆丕:  专丞上七七且丝七丗);
        if(this.业专丗且丏丘丘三丐() == false)
        {
            goto label_1;
        }
        
        if(this.丏东丕与丂丞七业丗 != 2)
        {
                this.上丞东三三丌业丂丙(专丞上七七且丝七丗:  专丞上七七且丝七丗);
            object[] val_2 = new object[1];
            val_2[0] = this.丝不丟丁丘丐丛一不;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  130, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        }
        
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null) || ((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().三不万不丕丑一上与() != 5) || (this.丄丌三丘丟丈且丛下 == true)))
        {
            goto label_18;
        }
        
        this.丄丌三丘丟丈且丛下 = true;
        丛丗丐世下丛丄丞丟 val_15 = this.丏东丕与丂丞七业丗;
        val_15 = val_15 | 1;
        Rilisoft.一丟专且三万丞丁丂.业东丏一丑丘丄万丙(丙世不不一丏业三且:  ((val_15 == 1) ? 1 : 0) | ((val_15 == 3) ? 1 : 0));
        goto label_18;
        label_1:
        if((this.东丒世丂丒丌丆丑丛 != null) && (this.东丒世丂丒丌丆丑丛.丂丛丄丆丐东且一世 != false))
        {
                object[] val_9 = new object[1];
            val_9[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  133, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_9);
        }
        
        this.丄一丁三万丅丅丕丄(丝三丗丁七丄丘丌丒:  专丞上七七且丝七丗);
        label_18:
        if((this.squadUI != 0) && (this.squadUI.playerJoinedSound != 0))
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_14 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.squadUI.playerJoinedSound);
        }
        
        }
        
        this.三丂业丞丞丐丒世丁();
    }
    private void 丗上丝丂业丑丕丗丛()
    {
        ExitGames.Client.Photon.Hashtable val_9;
        var val_10;
        val_9 = this;
        if(this.业专丗且丏丘丘三丐() == false)
        {
                return;
        }
        
        丛丗丐世下丛丄丞丟 val_9 = this.丏东丕与丂丞七业丗;
        val_9 = val_9 - 1;
        if(val_9 < 3)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_6 = null;
        val_9 = val_6;
        val_6 = new ExitGames.Client.Photon.Hashtable();
        val_10 = null;
        val_10 = null;
        val_6.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  ((UnityEngine.Mathf.Max(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().三不万不丕丑一上与(), b:  this.丛一丆专世丝丄丒与.Count)) > 4) ? 1 : 0);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_6, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 上丘三丞专一丂丕丕(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        万丅世丈丕丕丌丅丗 val_1 = this.丐丒丈与丈丒丐七丅(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if(val_1 != null)
        {
                val_1.丄丐丗专丆一东不丘(东一丁世丑丞业丄丐:  val_1);
            this.丄丕丛万丝三丌专丕();
            this.丘丆三丘丘丛丌丄世(东一丁世丑丞业丄丐:  val_1);
        }
        
        丛丗丐世下丛丄丞丟 val_7 = this.丏东丕与丂丞七业丗;
        val_7 = val_7 - 1;
        if(val_7 <= 2)
        {
                if(this.不丒丗丒丝丟丁丒丗 == 专丞上七七且丝七丗.业丐丐三丕一丗丛丁())
        {
                this.下一丅丄丅与专万丘 = false;
            this.丌丞丅下下丟世丙丌 = false;
            this.不与丞上丛丂丂丞丑();
        }
        
        }
        
        if((this.squadUI != 0) && (this.squadUI.playerQuitSound != 0))
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.squadUI.playerQuitSound);
        }
        
        }
        
        this.三丂业丞丞丐丒世丁();
    }
    private void 丘丆三丘丘丛丌丄世(SquadController.万丅世丈丕丕丌丅丗 东一丁世丑丞业丄丐)
    {
        var val_6;
        int val_7;
        if(东一丁世丑丞业丄丐 == null)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        }
        else
        {
                val_7 = System.String.alignConst;
        }
        
        bool val_5 = FriendInviteInfoContainer.一且丕丙丆丟丙七丒.Remove(item:  东一丁世丑丞业丄丐.丆世丘丒丒丏上且丗 + val_7);
    }
    private void 丄丐丗专丆一东不丘(SquadController.万丅世丈丕丕丌丅丗 东一丁世丑丞业丄丐)
    {
        if(东一丁世丑丞业丄丐.丆不丐一丙丐丏丗上 == true)
        {
                return;
        }
        
        东一丁世丑丞业丄丐.丂丛丄丆丐东且一世 = true;
        东一丁世丑丞业丄丐.丆不丐一丙丐丏丗上 = true;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + 30f;
        东一丁世丑丞业丄丐.三丘万业丁一丞丒丏 = val_1;
    }
    public void OpenInvitePanel()
    {
        this.squadUI.gameObject.SetActive(value:  false);
        SquadInviteGUI.丄丘七三上丕世丞业.ActivatePanel();
    }
    public void BackFromInvitePanel()
    {
        if(this.squadUI.isActive != false)
        {
                this.squadUI.gameObject.SetActive(value:  true);
        }
        
        SquadInviteGUI.丄丘七三上丕世丞业.DectivatePanel();
        丛丗丐世下丛丄丞丟 val_2 = this.丏东丕与丂丞七业丗;
        val_2 = val_2 - 1;
        if(val_2 > 2)
        {
                return;
        }
        
        this = this.squadUI;
        this.squadUI.updatePlayersGrid = true;
    }
    public void SendInviteToPlayer(string 丆世丘丒丒丏上且丗)
    {
        丄上三丛丛上一业三 val_1 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_1.丙与丗世丏丅丈丞万(丝三丗丁七丄丘丌丒:  丆世丘丒丒丏上且丗, 丐专丕丒业与丘丏丙:  this.squadRoomName, 丙世不不一丏业三且:  false);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.下丕丙丅不丅世丕丙(丑三丅丒丕丗三丏丁:  丆世丘丒丒丏上且丗, 丐下丘丈丁丄丌专丕:  this.squadRoomName, 丙世不不一丏业三且:  false));
        Rilisoft.一丟专且三万丞丁丂.丒上丄丙东与丛丆世(业丂下丒丌且丄丞一:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0);
        丛丗丐世下丛丄丞丟 val_8 = this.丏东丕与丂丞七业丗;
        val_8 = val_8 | 1;
        Rilisoft.一丟专且三万丞丁丂.丏且丆一一丝专丙丐(业丂下丒丌且丄丞一:  this.不丒丒丏丞丏丛业丌, 丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丙世不不一丏业三且:  ((val_8 == 1) ? 1 : 0) | ((val_8 == 3) ? 1 : 0));
    }
    public void SendInviteToPlayerInClan(string 丆世丘丒丒丏上且丗, string 丅一丞万丑专丅丅与)
    {
        丄上三丛丛上一业三 val_1 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_1.丙与丗世丏丅丈丞万(丝三丗丁七丄丘丌丒:  丆世丘丒丒丏上且丗, 丐专丕丒业与丘丏丙:  丅一丞万丑专丅丅与, 丙世不不一丏业三且:  true);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.下丕丙丅不丅世丕丙(丑三丅丒丕丗三丏丁:  丆世丘丒丒丏上且丗, 丐下丘丈丁丄丌专丕:  丅一丞万丑专丅丅与, 丙世不不一丏业三且:  true));
        Rilisoft.一丟专且三万丞丁丂.丒上丄丙东与丛丆世(业丂下丒丌且丄丞一:  (this.不丒丒丏丞丏丛业丌 == true) ? 1 : 0);
        丛丗丐世下丛丄丞丟 val_8 = this.丏东丕与丂丞七业丗;
        val_8 = val_8 | 1;
        Rilisoft.一丟专且三万丞丁丂.丏且丆一一丝专丙丐(业丂下丒丌且丄丞一:  this.不丒丒丏丞丏丛业丌, 丂丛丑东不丅丈一东:  this.丝不丟丁丘丐丛一不, 丙世不不一丏业三且:  ((val_8 == 1) ? 1 : 0) | ((val_8 == 3) ? 1 : 0));
    }
    public void SendCallInSquad(string 丑三丅丒丕丗三丏丁, string 丐下丘丈丁丄丌专丕, bool 丙世不不一丏业三且)
    {
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.下丕丙丅不丅世丕丙(丑三丅丒丕丗三丏丁:  丑三丅丒丕丗三丏丁, 丐下丘丈丁丄丌专丕:  丐下丘丈丁丄丌专丕, 丙世不不一丏业三且:  丙世不不一丏业三且));
    }
    private System.Collections.IEnumerator 下丕丙丅不丅世丕丙(string 丑三丅丒丕丗三丏丁, string 丐下丘丈丁丄丌专丕, bool 丙世不不一丏业三且)
    {
        SquadController.丝丆万东且丗丆丝世 val_1 = new SquadController.丝丆万东且丗丆丝世(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丐下丘丈丁丄丌专丕 = 丐下丘丈丁丄丌专丕;
            .丑三丅丒丕丗三丏丁 = 丑三丅丒丕丗三丏丁;
        }
        else
        {
                mem[48] = 丑三丅丒丕丗三丏丁;
            mem[40] = 丐下丘丈丁丄丌专丕;
        }
        
        .丙世不不一丏业三且 = 丙世不不一丏业三且;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static bool 丈丟丒七与丂丙下丄(string 丞丅上丏丂且下丅与)
    {
        string val_8;
        var val_9;
        val_8 = 丞丅上丏丂且下丅与;
        if((System.String.IsNullOrEmpty(value:  val_8)) == true)
        {
            goto label_21;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下();
        if(val_3 == null)
        {
            goto label_5;
        }
        
        UnityEngine.AndroidJavaObject val_5 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
        if(val_5 == null)
        {
            goto label_6;
        }
        
        object[] val_6 = new object[2];
        val_6[0] = val_8;
        val_8 = 0;
        val_6[1] = val_8;
        if((val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_6)) == null)
        {
            goto label_14;
        }
        
        val_9 = 1;
        return (bool)val_9;
        label_5:
        UnityEngine.Debug.LogWarning(message:  "activity == null");
        goto label_21;
        label_6:
        UnityEngine.Debug.LogWarning(message:  "manager == null");
        goto label_21;
        label_14:
        UnityEngine.Debug.LogWarning(message:  "packageInfo == null");
        label_21:
        val_9 = 0;
        return (bool)val_9;
    }
    public void MessagePanelButtonClick()
    {
        this.squadUI.HideMessagePanel();
        if(this.下丐丂丟世世与东万 == null)
        {
                return;
        }
        
        this.下丐丂丟世世与东万.Invoke();
        this.下丐丂丟世世与东万 = 0;
    }
    private void 东丒丘丁丆丒丝丈丘(string 丕丗丘丑丛与丑业丒, bool 丞丁上丛与丌一一丐, System.Action 丈业丙万世不业世不)
    {
        this.下丐丂丟世世与东万 = 丈业丙万世不业世不;
        this.squadUI.ShowMessagePanel(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丄丂丑丆丞丗业专丗:  true, 丝丕且世下一东与业:  丞丁上丛与丌一一丐);
    }
    private void 世与七东世不业丒专(string 丕丗丘丑丛与丑业丒)
    {
        this.squadUI.ShowMessagePanel(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丄丂丑丆丞丗业专丗:  false, 丝丕且世下一东与业:  false);
    }
    private void 不与丞上丛丂丂丞丑()
    {
        this.squadUI.HideMessagePanel();
    }
    private void 且不丘下且丝丙丟一(System.Collections.Generic.List<string> 世丅丈东丘丐丕丟丐)
    {
        System.Collections.Generic.List<System.String> val_8;
        var val_9;
        if(世丅丈东丘丐丕丟丐.Count == 0)
        {
                return;
        }
        
        this.丅万丘丒万不丄丅丁.Clear();
        val_8 = this.丅万丘丒万不丄丅丁;
        val_8.AddRange(collection:  世丅丈东丘丐丕丟丐);
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_4.Add(key:  "ids", value:  this.丅万丘丒万不丄丅丁);
        val_9 = null;
        val_9 = null;
        int val_7 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丕丘丒丂且业与一丑, 一丐丗丁丞丆丅丟丄:  val_4, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadController::丘丝丏三上七丝丕丄(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 丘丝丏三上七丝丕丄(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_8;
        var val_26;
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        var val_33;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) == true)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "data", 丙业与丙丗丝不丈东: out  0)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_6 = val_2.Keys.GetEnumerator();
        val_28 = 0;
        val_29 = 0;
        label_32:
        if((1401015696 & 1) == 0)
        {
            goto label_33;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        object val_10 = val_2.Item[val_9];
        System.Collections.Generic.Dictionary<System.String, System.String> val_11 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_10 != null)
        {
                val_30 = null;
        }
        
        if(val_10 != null)
        {
                val_30 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_13 = GetEnumerator();
        label_20:
        if((1401015648 & 1) == 0)
        {
            goto label_21;
        }
        
        ConfiguredValueTaskAwaiter val_15 = val_8.GetAwaiter();
        if(val_15._value._obj != 0)
        {
                var val_17 = (val_15._value._obj == null) ? () : 0;
        }
        else
        {
                val_31 = 0;
        }
        
        null.Add(key:  val_15._value._obj.丐丏七丌丕丗业且上(), value:  val_31);
        goto label_20;
        label_21:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 != 1) && (146 == 146))
        {
            
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_4.Add(key:  val_9, value:  null);
        goto label_32;
        label_33:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((2 != 1) && (180 == 180))
        {
            
        }
        else
        {
                if( != 0)
        {
                val_26 = 0;
        }
        
        }
        
        val_33 = 0;
        goto label_44;
        label_51:
        if((this.专与丅丗丆丅上三一.Contains(item:  this.丅万丘丒万不丄丅丁.Item[0])) != true)
        {
                bool val_21 = this.专与丅丗丆丅上三一.Add(item:  this.丅万丘丒万不丄丅丁.Item[0]);
        }
        
        val_33 = 1;
        label_44:
        if(val_33 < this.丅万丘丒万不丄丅丁.Count)
        {
            goto label_51;
        }
        
        this.与丂丞丅丂一下丈与.Clear();
        Dictionary.Enumerator<TKey, TValue> val_23 = val_4.GetEnumerator();
        label_56:
        if((1401015592 & 1) == 0)
        {
            goto label_57;
        }
        
        ConfiguredValueTaskAwaiter val_24 = 0.GetAwaiter();
        this.与丂丞丅丂一下丈与.set_Item(key:  val_24._value._obj.丐丏七丌丕丗业且上(), value:  val_24._value._obj);
        goto label_56;
        label_57:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(3 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(337 == 337)
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
    public SquadController()
    {
        this.专丒不丈下东丝丝上 = "";
        this.squadRoomName = "";
        this.idToMessages = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
        this.不丒丗丒丝丟丁丒丗 = 0;
        this.丗丅丞上七丌且丝世 = 100;
        this.下一世丛七丁且丂丆 = System.String.alignConst;
        this.东丏东上七一万丆丌 = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>();
        this.丅东丈丒丏丟万东丘 = new System.Collections.Generic.List<System.String>();
        this.丁丑一丈丆丁丒丘丕 = new System.Collections.Generic.List<System.String>();
        this.丏丝东丂万下七专丄 = new System.Collections.Generic.List<System.Int32>();
        this.与丂丞丅丂一下丈与 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
        this.专与丅丗丆丅上三一 = new System.Collections.Generic.HashSet<System.String>();
        this.丅万丘丒万不丄丅丁 = new System.Collections.Generic.List<System.String>();
    }
    private static SquadController()
    {
        SquadController.丄丘七三上丕世丞业 = 0;
        SquadController.上丂七上丘且丕且丈 = 0;
        SquadController.丘丘丙丗东丟丑业丟 = 0;
        SquadController.七丆丆丘业丝与丄业 = "";
        SquadController.万一丘丗三三丈丗丛 = "";
        SquadController.丕丙三丗丘丁丂丁丌 = "";
        SquadController.丘业不丅万不丐东丝 = false;
        SquadController.丁丛专丂业丞丑丐专 = false;
        SquadController.丏丛丈上丄丂丐上丒 = 10;
        SquadController.世与丄且三下不与丕 = 60;
        SquadController.三且丟丑业万且且丄 = 1;
        SquadController.丄丟丐丁丑丏丂丅不 = 0;
        SquadController.万与丈世丝丙万丕一 = 0;
    }

}
