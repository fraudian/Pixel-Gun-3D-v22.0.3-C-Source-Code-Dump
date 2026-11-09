using UnityEngine;
public sealed class GiftController : MonoBehaviour
{
    // Fields
    internal const string 丈专且丕且丁上丑世 = "freeSpinsCount";
    internal const string 上丌丁丄下七东一上 = "keyCountGiftNewPlayer";
    internal const string 丏丘且不丝丐丟丞且 = "gift2_config_version";
    internal const string 丌丌一下丛七丏三一 = "gift2_config_random_positions";
    internal const string 与丗丞且丆不丑一丙 = "gift2_current_index";
    private const string 丙丛丕丅丑七与东丘 = "gift3_spin_step";
    internal const string 丁丕丑丂且丝东丏丞 = "gatcha_state_data";
    private const string 丞丞一七丁业丛丑不 = "gift2_config-v5";
    private const string 三世且东三丑丅丅丅 = "SaveServerTime";
    private const string 丆丄丘下丌丝下丂业 = "keyIsGetArmorNewPlayer";
    private const string 上丒业丘一丄与丗丒 = "keyIsGetSkinNewPlayer";
    private const float 丏丙丅专丞丞七丗丝 = 0.3333;
    private readonly System.TimeSpan 丑丅七世丒丘业丈丙;
    private Rilisoft.丝丑丂丛万丐丈丘且 三业丂丑丈不丁丈丅;
    internal static GiftController 丆丕丝丒不丙且丐丗;
    private readonly System.Collections.Generic.List<GiftCategory> _categories;
    private readonly System.Collections.Generic.List<SlotInfo> _slots;
    private bool 业丁业世丐七丗丄丐;
    private bool 且下不上万业东丅丌;
    private bool 丌万丘且丙下不丙万;
    private Rilisoft.丝丑丂丛万丐丈丘且 万丆专下一丟不世与;
    private static System.Action 丄不丏七三丆万专丕;
    private Rilisoft.丝丑丂丛万丐丈丘且 丈不万丑丙丟丙丒丏;
    private System.Collections.IEnumerator 丝丅丟丕下不丑业丆;
    private bool 丛万一丈东三专丄丕;
    private bool 丘丟丄丈七丄丅丅丗;
    private bool 丗东丛七业丝丟专一;
    private int 万丁丑丛丐丗丌丗万;
    internal bool 丟专不专丑丆且丗丕;
    private bool 丈东下七丁七丈丅东;
    private Rilisoft.丒且丐三丁丅丕一业 丄丄丝丙丏丆丈业与;
    private Rilisoft.丝丑丂丛万丐丈丘且 七丄世丁专上丙丙丘;
    private 业丗丙东丄不万丁三 丕与万丒丞丙丞丗下;
    internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丈丛丝世三世丏业丛;
    internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丂且世七丏专专与上;
    private GiftRewardMultiplierType 丞万丘丂东三三万业;
    private PGCompany.DataObjects.业丏丈丞丘业丈丞一 丂业三丈与三丂丑丄;
    private string[] 丁上与丕与且且丘七;
    internal SlotInfo 丁不丐且丆丆三丗业;
    private GiftSettingType 丁东丑丏丐丗丝七一;
    private GiftSettingType 丐与丛丆世丌丌丑三;
    private UnityEngine.Coroutine 丌三不丞丏丂且丒丂;
    private int 丐丄丑且丏丂与上丁;
    private System.Collections.Generic.Dictionary<GiftCategoryType, System.Collections.Generic.List<GiftCategory>> 丈丑七丞万丕上业三;
    private System.Collections.Generic.Dictionary<GiftCategoryType, SlotInfo> 丏丝丂丅丅业三丛丒;
    private System.Collections.Generic.Dictionary<string, string> 丅丕下丒丁丟不三且;
    private System.Collections.Generic.Dictionary<string, PGCompany.DataObjects.七下上丁万东丑世业> 三丒世丙一三丝丕丟;
    private GiftController.丆三丄且下丏丐丒丝 <且与丄丘万丕下下丟>k__BackingField;
    private System.EventHandler 丕丏一丂丗三东丁丁;
    private static System.Action 丅丆上七丘丟丘万丕;
    private static System.Action<GiftSettingType, GiftSettingType> 丅丞丅三丂与丙与一;
    private static System.Action<SlotInfo> 万且万万丏丄丟丒七;
    private static System.Action<System.TimeSpan> 业业丌上不丄三丌上;
    private static System.Action 业丞丞丛丌且丌丄丆;
    private static System.Action 东业专世丟丝世世且;
    private static System.Action 丈下世丁丘丆丙丗丆;
    private static System.Action 丄丐丏丕丆专丂丌丕;
    private static System.Action<string> 一上世丏丞丞万丘丞;
    private bool 专丗丆丝丝上丞丒丘;
    private System.Collections.Generic.Queue<string> 七丄世丈东一且丞丒;
    
    // Properties
    public bool 丙专且丒丝丒上丘上 { get; set; }
    public bool 丑业丗丒丅丈丘丂丄 { get; set; }
    internal PGCompany.DataObjects.业丏丈丞丘业丈丞一 一七且丗不丑丝且三 { get; }
    internal System.Collections.Generic.Dictionary<string, string> 上丌专与丒丟不且丙 { get; set; }
    private Rilisoft.丝丑丂丛万丐丈丘且 丅丕丛专世丑业三丙 { get; }
    internal string[] 丕丙上丛丒丁且丛丛 { get; }
    internal GiftSettingType 丙专丌万丅丝业丅丘 { get; }
    internal GiftSettingType 万丐专万丆上丌丏且 { get; }
    internal Rilisoft.丝丑丂丛万丐丈丘且 业丏丌丌丝东丌世丑 { get; }
    internal int 丄与丗丒不专丞丑三 { get; set; }
    internal int 丝丏丝与丆专七丝业 { get; }
    private int 不丛三三专丛一万丝 { get; set; }
    internal bool 丞丝业丑世丐丌七三 { get; }
    private float 业丐专万丄丛丛七丅 { get; set; }
    public float 丌与丁不下丅丆丘丞 { get; }
    public System.Collections.Generic.List<SlotInfo> 丙丕世一丌丙丙丟丒 { get; }
    public bool 丘上丕万丗丈上一与 { get; }
    public bool 业专丙丈世丞上丏丄 { get; }
    public bool 丄丏七上上丒一业丅 { get; }
    internal bool 专不丈专丕丌世丈丘 { get; }
    public bool 丟丑三丗一且丗三上 { get; }
    public bool 三丑丐丆丕七东一丄 { get; }
    public int 丑上七丂丑不万且与 { get; set; }
    public bool 三丅丄丝三丄丞上与 { get; }
    public GiftController.丆三丄且下丏丐丒丝 丞丝丙丅丞丈且上一 { get; set; }
    private long 丞丄丁与且丗丙下丅 { get; set; }
    internal System.TimeSpan 丐丗一下业世与丗丅 { get; }
    public static int 与丄万丞丏下三丆且 { get; }
    
    // Methods
    internal static void 丄与一丏丆丏且丑万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.丄不丏七三丆万专丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丄不丏七三丆万专丕 != 1152921505205198856);
    
    }
    internal static void 上丛东丑东丛上且下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.丄不丏七三丆万专丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丄不丏七三丆万专丕 != 1152921505205198856);
    
    }
    private GiftController()
    {
        0.丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  0);
        this.丑丅七世丒丘业丈丙 = 0;
        this._categories = new System.Collections.Generic.List<GiftCategory>();
        this._slots = new System.Collections.Generic.List<SlotInfo>();
        this.万丆专下一丟不世与 = 0;
        mem[1152921537792902080] = 0;
        this.万丁丑丛丐丗丌丗万 = 0;
        this.丈不万丑丙丟丙丒丏 = 0;
        mem[1152921537792902096] = 0;
        this.丄丄丝丙丏丆丈业与 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  -1f);
        this.七丄世丁专上丙丙丘 = 0;
        mem[1152921537792902144] = 0;
        int[] val_4 = new int[1];
        val_4[0] = 1;
        this.丕与万丒丞丙丞丗下 = new 业丗丙东丄不万丁三(与且丙丘上丞丘丙业:  val_4);
        this.丈丛丝世三世丏业丛 = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
        this.丂且世七丏专专与上 = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
        this.丁上与丕与且且丘七 = new string[0];
        this.丁东丑丏丐丗丝七一 = 4294967297;
        this.丐丄丑且丏丂与上丁 = 0;
        this.丈丑七丞万丕上业三 = new System.Collections.Generic.Dictionary<GiftCategoryType, System.Collections.Generic.List<GiftCategory>>();
        this.丏丝丂丅丅业三丛丒 = new System.Collections.Generic.Dictionary<GiftCategoryType, SlotInfo>();
        this.七丄世丈东一且丞丒 = new System.Collections.Generic.Queue<System.String>();
        Rilisoft.丝丑丂丛万丐丈丘且 val_12 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  64);
        this.三业丂丑丈不丁丈丅 = val_12;
        mem[1152921537792902040] = val_12.上万三丆专丏丒丗业;
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void GiftController::丙与东丏丕丞丕丐东(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.LoadSceneMode 丛丆东与丑丞丅丝专)));
        Progress.丅丆不三丄不丝丒一.东业丌丛三丞丘与世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::丟丌丈丒三七丅丄丂()));
    }
    private void 丟丌丈丒三七丅丄丂()
    {
        this.丛万一丈东三专丄丕 = true;
    }
    private void 丙与东丏丕丞丕丐东(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.LoadSceneMode 丛丆东与丑丞丅丝专)
    {
        this.丛万一丈东三专丄丕 = false;
    }
    public bool get_GetFreeSpinGift()
    {
        return (bool)this.丘丟丄丈七丄丅丅丗;
    }
    public void set_GetFreeSpinGift(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                this.下丘丌丏与丅世丕专(丒且丆丘丞丑业丅不:  0);
        }
        
        this.丘丟丄丈七丄丅丅丗 = 丙业与丙丗丝不丈东;
    }
    public bool get_canGetTimerGift()
    {
        return (bool)this.业丁业世丐七丗丄丐;
    }
    public void set_canGetTimerGift(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                if(this.丅丒东丝上丌丗丒丞() != 0)
        {
                this.下丘丌丏与丅世丕专(丒且丆丘丞丑业丅不:  0);
        }
        
        }
        
        this.业丁业世丐七丗丄丐 = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.DataObjects.业丏丈丞丘业丈丞一 世丈丁业丛上丘丗丐()
    {
        return (PGCompany.DataObjects.业丏丈丞丘业丈丞一)this.丂业三丈与三丂丑丄;
    }
    internal System.Collections.Generic.Dictionary<string, string> 不不七与丏东专东丏()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.丅丕下丒丁丟不三且;
        if(val_2 != null)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.String>)val_2;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        return (System.Collections.Generic.Dictionary<System.String, System.String>)val_2;
    }
    internal void 丐丆丑丁丆且丝且丏(System.Collections.Generic.Dictionary<string, string> 丙业与丙丗丝不丈东)
    {
        this.丅丕下丒丁丟不三且 = 丙业与丙丗丝不丈东;
    }
    internal void 一丘丏七丁丕世丕下(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
    {
        bool val_2 = this.不不七与丏东专东丏().ContainsKey(key:  下上丐丆丝丟丝丒不);
        System.Collections.Generic.Dictionary<System.String, System.String> val_3 = this.不不七与丏东专东丏();
        if(val_3 == null)
        {
            goto label_2;
        }
        
        if(val_2 == false)
        {
            goto label_3;
        }
        
        label_6:
        if((System.String.op_Inequality(a:  val_3.Item[下上丐丆丝丟丝丒不], b:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
        this.不不七与丏东专东丏().set_Item(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
        return;
        label_2:
        if(val_2 == true)
        {
            goto label_6;
        }
        
        label_3:
        val_3.Add(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
    }
    private Rilisoft.丝丑丂丛万丐丈丘且 万业丞丙丅丗东丁七()
    {
        if(this.丅丒东丝上丌丗丒丞() >= this.丈丛丝世三世丏业丛.Count)
        {
                return Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        }
        
        if(this.丈丛丝世三世丏业丛 != null)
        {
                return this.丈丛丝世三世丏业丛.Item[this.丅丒东丝上丌丗丒丞()];
        }
        
        return this.丈丛丝世三世丏业丛.Item[this.丅丒东丝上丌丗丒丞()];
    }
    internal string[] 下上丈专丘丒丈上东()
    {
        return (System.String[])this.丁上与丕与且且丘七;
    }
    internal GiftSettingType 丌业丏丄与世三丁不()
    {
        return (GiftSettingType)this.丁东丑丏丐丗丝七一;
    }
    internal GiftSettingType 丗丕万专丄丗丐且丛()
    {
        return (GiftSettingType)this.丐与丛丆世丌丌丑三;
    }
    internal GiftSettingType 丆丈丞东丙丞丂丘丏(string 丞丅上丏丂且下丅与)
    {
        var val_10;
        string val_11;
        System.Collections.Generic.Dictionary<System.String, PGCompany.DataObjects.七下上丁万东丑世业> val_12;
        GiftSettingType val_13;
        val_11 = 丞丅上丏丂且下丅与;
        if((this.丂业三丈与三丂丑丄 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true))
        {
            goto label_19;
        }
        
        val_12 = this.三丒世丙一三丝丕丟;
        if(val_12 != null)
        {
            goto label_18;
        }
        
        System.Collections.Generic.Dictionary<System.String, PGCompany.DataObjects.七下上丁万东丑世业> val_3 = new System.Collections.Generic.Dictionary<System.String, PGCompany.DataObjects.七下上丁万东丑世业>(capacity:  this.丂业三丈与三丂丑丄.Data.Count);
        this.三丒世丙一三丝丕丟 = val_3;
        val_10 = 0;
        goto label_8;
        label_17:
        val_3.Add(key:  this.丂业三丈与三丂丑丄.Data.Item[0].丐丙世七丅丅丐下丙(), value:  this.丂业三丈与三丂丑丄.Data.Item[0]);
        val_10 = 1;
        label_8:
        val_12 = this.三丒世丙一三丝丕丟;
        if(val_10 < this.丂业三丈与三丂丑丄.Data.Count)
        {
            goto label_17;
        }
        
        label_18:
        if((val_12.ContainsKey(key:  val_11)) != false)
        {
                val_11 = this.三丒世丙一三丝丕丟.Item[val_11];
            val_13 = val_9.Setting;
            return (GiftSettingType)val_13;
        }
        
        label_19:
        val_13 = 0;
        return (GiftSettingType)val_13;
    }
    internal System.TimeSpan 三东丌与下丕丏丕且()
    {
        System.DateTime val_5;
        System.TimeSpan val_6;
        val_5 = this;
        System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((( & 1) != 0) && (this.丂业三丈与三丂丑丄 != null)) && ((this.丐丄丑且丏丂与上丁 & 2147483648) == 0))
        {
                PGCompany.DataObjects.丗丅丐丙丅业丟丒丒 val_3 = this.丂业三丈与三丂丑丄.Schedule.万且丏丙东丆东且不().Item[this.丐丄丑且丏丂与上丁];
            val_5 = val_3.丏不万且丑丗丄一丕;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_5}, d2:  new System.DateTime() {});
            return val_6;
        }
        
        val_6 = this.丑丅七世丒丘业丈丙;
        return val_6;
    }
    internal void 丒世且丄万丕三一丝()
    {
        var val_14;
        System.Nullable<System.DateTime> val_2 = FriendsController.业丈丏丏丞丘丛丈丛();
        .丒丁下丏万一不东世 = val_2;
        mem[1152921537795341848] = 0;
        if((this.且下不上万业东丅丌 == false) || ((ExperienceController.丞丞丘业东丙丏七丌() < 2) || ((1152921537795341840 & 1) == 0)))
        {
            goto label_8;
        }
        
        PGCompany.DataObjects.丗丅丐丙丅业丟丒丒 val_6 = System.Linq.Enumerable.SingleOrDefault<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒>(source:  this.丂业三丈与三丂丑丄.Schedule.万且丏丙东丆东且不(), predicate:  new System.Func<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒, System.Boolean>(object:  new GiftController.且丛丑丘丏丈七丑丝(), method:  System.Boolean GiftController.且丛丑丘丏丈七丑丝::下丞丆丅上丐一丏世(PGCompany.DataObjects.丗丅丐丙丅业丟丒丒 丏丛与丅丛丌万专丌)));
        if(val_6 == null)
        {
            goto label_11;
        }
        
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.丏不万且丑丗丄一丕}, d2:  new System.DateTime() {dateData = 1152921537795341840});
        System.Collections.Generic.List<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒> val_8 = this.丂业三丈与三丂丑丄.Schedule.万且丏丙东丆东且不();
        this.丁东丑丏丐丗丝七一 = val_6.与丗丕丕与丌世丅丛;
        int val_9 = val_8.IndexOf(item:  val_6);
        this.丐丄丑且丏丂与上丁 = val_9;
        if(val_9 >= (val_8.Count - 1))
        {
            goto label_20;
        }
        
        val_14 = this.丐丄丑且丏丂与上丁 + 1;
        if(val_8 != null)
        {
            goto label_24;
        }
        
        goto label_22;
        label_8:
        label_23:
        this.与且东丝丙丙世丏万(丌丆丙世丝丄且丏万:  this.丁东丑丏丐丗丝七一, 丂三丟丂丈丐丆丗丟:  new System.TimeSpan() {_ticks = this.丑丅七世丒丘业丈丙});
        return;
        label_11:
        this.丁东丑丏丐丗丝七一 = 1;
        goto label_23;
        label_20:
        val_14 = 0;
        if(val_8 != null)
        {
            goto label_24;
        }
        
        label_22:
        label_24:
        PGCompany.DataObjects.丗丅丐丙丅业丟丒丒 val_12 = val_8.Item[0];
        this.丐与丛丆世丌丌丑三 = val_12.与丗丕丕与丌世丅丛;
        this.与且东丝丙丙世丏万(丌丆丙世丝丄且丏万:  this.丁东丑丏丐丗丝七一, 丂三丟丂丈丐丆丗丟:  new System.TimeSpan() {_ticks = val_7._ticks});
        if(this.丌万丘且丙下不丙万 == true)
        {
                return;
        }
        
        this.丌万丘且丙下不丙万 = true;
    }
    private void 与且东丝丙丙世丏万(GiftSettingType 丌丆丙世丝丄且丏万, System.TimeSpan 丂三丟丂丈丐丆丗丟)
    {
        var val_4;
        System.TimeSpan val_5;
        var val_6;
        System.Action<System.TimeSpan> val_7;
        if(this.丁东丑丏丐丗丝七一 != 丌丆丙世丝丄且丏万)
        {
                val_4 = null;
            val_4 = null;
            if(GiftController.丅丞丅三丂与丙与一 != null)
        {
                GiftController.丅丞丅三丂与丙与一.Invoke(arg1:  this.丁东丑丏丐丗丝七一, arg2:  this.丐与丛丆世丌丌丑三);
        }
        
            if(this.丌万丘且丙下不丙万 != false)
        {
                GiftController.丙丅七丝丌不丛丏万(上不丙丌下丗丁不与:  false);
            this.ReCreateSlotsIfPossible();
        }
        
        }
        
        val_5 = this.丑丅七世丒丘业丈丙;
        if((System.TimeSpan.op_Inequality(t1:  new System.TimeSpan() {_ticks = 丂三丟丂丈丐丆丗丟._ticks}, t2:  new System.TimeSpan() {_ticks = val_5})) != false)
        {
                val_5 = 1152921505205194752;
            val_6 = null;
            val_6 = null;
            val_7 = GiftController.业业丌上不丄三丌上;
            if(val_7 != null)
        {
                val_7 = GiftController.业业丌上不丄三丌上;
            if(val_7 == null)
        {
                val_7 = 0;
        }
        
            val_7.Invoke(obj:  new System.TimeSpan() {_ticks = 丂三丟丂丈丐丆丗丟._ticks});
        }
        
        }
        
        if(this.丌三不丞丏丂且丒丂 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丌三不丞丏丂且丒丂);
        }
        
        this.丌三不丞丏丂且丒丂 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  0.3333f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void GiftController::丒世且丄万丕三一丝()));
    }
    internal Rilisoft.丝丑丂丛万丐丈丘且 丆一丘万丁上丒丏三()
    {
        return this.万业丞丙丅丗东丁七();
    }
    internal int 丅丒东丝上丌丗丒丞()
    {
        if(this.七丄世丁专上丙丙丘 != 1)
        {
                return (int)this.七丄世丁专上丙丙丘;
        }
        
        Progress.不丝三一丂丆丐三丈 val_1 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        int val_2 = UnityEngine.Mathf.Max(a:  val_1.与丕丘丐专与丛丂丝, b:  1);
        this.七丄世丁专上丙丙丘 = 0;
        mem[1152921537795780112] = 0;
        return (int)this.七丄世丁专上丙丙丘;
    }
    internal void 丅不业丄丗丁丌三丝(int 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丂丞丕业丝丛下东丙(专与与丗七专丁丌丑:  this.七丄世丁专上丙丙丘);
    }
    internal int 七七丁丄丌丗上专丕()
    {
        return this.丌三世丗一丙丂七丕();
    }
    private int 丌三世丗一丙丂七丕()
    {
        if(this.万丆专下一丟不世与 != 1)
        {
                return (int)this.万丆专下一丟不世与;
        }
        
        Progress.不丝三一丂丆丐三丈 val_1 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        this.万丆专下一丟不世与 = 0;
        mem[1152921537796132432] = 0;
        return (int)this.万丆专下一丟不世与;
    }
    private void 与丞与丆专一与万丑(int 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丏一丄与丟丛一丆(一世与业专丅丕万丁:  this.万丆专下一丟不世与);
    }
    internal bool 丐丘丕丆丞丑丝丆丟()
    {
        if(this.丕与万丒丞丙丞丗下 != null)
        {
                return this.丕与万丒丞丙丞丗下.丟不下下且业丛丄丏(丆一与丌丙丕丝且丏:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this.七丄世丁专上丙丙丘, 丑丒丄下丁丐专丄丞 = this.七丄世丁专上丙丙丘, 上万三丆专丏丒丗业 = X21});
        }
        
        return this.丕与万丒丞丙丞丗下.丟不下下且业丛丄丏(丆一与丌丙丕丝且丏:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this.七丄世丁专上丙丙丘, 丑丒丄下丁丐专丄丞 = this.七丄世丁专上丙丙丘, 上万三丆专丏丒丗业 = X21});
    }
    private float 丏丒上专下丏上丌丞()
    {
        if(this.丄丄丝丙丏丆丈业与 != null)
        {
                return this.丄丄丝丙丏丆丈业与.丝丙丐且丟丅三丛七();
        }
        
        return this.丄丄丝丙丏丆丈业与.丝丙丐且丟丅三丛七();
    }
    private void 丆且丐且一丞不上丈(float 丙业与丙丗丝不丈东)
    {
        this.丄丄丝丙丏丆丈业与.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public float get_TimeLeft()
    {
        return this.丏丒上专下丏上丌丞();
    }
    public System.Collections.Generic.List<SlotInfo> get_Slots()
    {
        return (System.Collections.Generic.List<SlotInfo>)this._slots;
    }
    public bool get_CanGetTimerGift()
    {
        var val_3;
        if(this.ActiveGift != false)
        {
                var val_2 = (this.业丁业世丐七丗丄丐 == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public bool get_CanGetFreeSpinGift()
    {
        var val_3;
        if(this.ActiveGift != false)
        {
                var val_2 = (this.丈不万丑丙丟丙丒丏 > 0) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public bool get_CanGetGift()
    {
        if(this.ActiveGift == false)
        {
                return this.CanGetFreeSpinGift;
        }
        
        if(this.业丁业世丐七丗丄丐 == false)
        {
                return this.CanGetFreeSpinGift;
        }
        
        return true;
    }
    internal bool 丑丈丑丘下丟丐与万()
    {
        var val_7;
        GiftBannerWindow val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        var val_11;
        var val_12;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if(MainStoreView.丈丐丞丐上丑且丕万() != false)
        {
                val_7 = null;
            val_7 = null;
            val_8 = GiftBannerWindow.丄丘七三上丕世丞业;
            if(val_8 == 0)
        {
                return false;
        }
        
            val_9 = null;
            val_9 = null;
            val_10 = mem[GiftBannerWindow.丄丘七三上丕世丞业 + 368];
            val_10 = GiftBannerWindow.丄丘七三上丕世丞业.bannerObj;
            if(null != 0)
        {
                return val_10.activeInHierarchy;
        }
        
            return val_10.activeInHierarchy;
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        val_8 = GiftBannerWindow.丄丘七三上丕世丞业;
        if(val_8 == 0)
        {
                return false;
        }
        
        val_12 = null;
        val_12 = null;
        val_10 = GiftBannerWindow.丄丘七三上丕世丞业.gameObject;
        if(val_10 != null)
        {
                return val_10.activeInHierarchy;
        }
        
        return val_10.activeInHierarchy;
    }
    public bool get_ActiveGift()
    {
        var val_12;
        if((((与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true) && (this.且下不上万业东丅丌 != false)) && (this.DataIsLoaded != false)) && (PixelTime.丝业丁丌丘东丏世与() != false))
        {
                if(Progress.七七世万专丕丁上业.丐丐上丟丑丆丐专丗().丘丐上丁丁业七丏丌() != false)
        {
                val_12 = 1;
            return (bool)val_12;
        }
        
            if(ExperienceController.丞丞丘业东丙丏七丌() >= BalanceController.专东东丄丘丗丗丁丂())
        {
                if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) != null)
        {
                if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
        {
            goto label_23;
        }
        
        }
        
            var val_11 = (this.丛万一丈东三专丄丕 == false) ? 1 : 0;
            return (bool)val_12;
        }
        
        }
        
        label_23:
        val_12 = 0;
        return (bool)val_12;
    }
    public bool get_DataIsLoaded()
    {
        if(this._slots == null)
        {
                return (bool)(this._slots.Count != 0) ? 1 : 0;
        }
        
        return (bool)(this._slots.Count != 0) ? 1 : 0;
    }
    public int get_FreeSpins()
    {
    
    }
    private void 下丒丙丐丐丅上且下(int 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 >= 1)
        {
                this.下丘丌丏与丅世丕专(丒且丆丘丞丑业丅不:  0);
        }
        
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丈不万丑丙丟丙丒丏 = 0;
        mem[1152921537797799776] = 0;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏专丒上丈丕丗世丙(三一东世丆丕丞丂丞:  -1168785576);
    }
    public bool get_UseFreeSpin()
    {
        var val_2;
        if(this.丈不万丑丙丟丙丒丏 <= 0)
        {
                return (bool)(this.丘丟丄丈七丄丅丅丗 == true) ? 1 : 0;
        }
        
        val_2 = 1;
        return (bool)(this.丘丟丄丈七丄丅丅丗 == true) ? 1 : 0;
    }
    public GiftController.丆三丄且下丏丐丒丝 get_LastDroppedGift()
    {
        return (丆三丄且下丏丐丒丝)this.<且与丄丘万丕下下丟>k__BackingField;
    }
    private void 丕丗东下丙丁丐万丕(GiftController.丆三丄且下丏丐丒丝 丙业与丙丗丝不丈东)
    {
        this.<且与丄丘万丕下下丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private long 丘丅业上丙丒七下与()
    {
        if(Progress.七七世万专丕丁上业.一且丄一与业丒东丂() != null)
        {
                return (long)val_1.万丒丘七丞与丛丑丞;
        }
        
        return (long)val_1.万丒丘七丞与丛丑丞;
    }
    private void 专丒丌丄丅三东丒丂(long 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟丆丆丆三丙丘丝(丂三丟丂丈丐丆丗丟:  丙业与丙丗丝不丈东);
    }
    internal System.TimeSpan 丐丌丗丟丆丞丘丄丘()
    {
        var val_9;
        double val_10;
        val_9 = this;
        long val_1 = FriendsController.丝丗专上三不丄丑丑();
        if(val_1 > 0)
        {
                if(val_1.丘丅业上丙丒七下与() == 0)
        {
                this.三业丂丑丈不丁丈丅.专丒丌丄丅三东丒丂(丙业与丙丗丝不丈东:  (FriendsController.丝丗专上三不丄丑丑() + 1) - (this.三业丂丑丈不丁丈丅 << ));
        }
        
            long val_6 = FriendsController.丝丗专上三不丄丑丑();
            val_9 = this.三业丂丑丈不丁丈丅;
            long val_8 = val_6.丘丅业上丙丒七下与() - val_6;
            val_8 = val_8 + (val_9 << );
            val_10 = (double)val_8;
            return System.TimeSpan.FromSeconds(value:  val_10 = -1);
        }
        
        return System.TimeSpan.FromSeconds(value:  val_10);
    }
    internal void 丌与业丒丅三不丌世(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕丏一丂丗三东丁丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丏一丂丗三东丁丁 != this.丕丏一丂丗三东丁丁);
    
    }
    internal void 世东一一丕丂丐且世(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕丏一丂丗三东丁丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丏一丂丗三东丁丁 != this.丕丏一丂丗三东丁丁);
    
    }
    private void 且丐丟丂丙丒一七丝()
    {
        var val_1;
        if(this.丕丏一丂丗三东丁丁 == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        this.丕丏一丂丗三东丁丁.Invoke(sender:  this, e:  System.EventArgs.Empty);
    }
    internal static void 不丂一三丈业一丁丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.丅丆上七丘丟丘万丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丅丆上七丘丟丘万丕 != 1152921505205198864);
    
    }
    internal static void 丟丆丏丕丞不上丞丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.丅丆上七丘丟丘万丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丅丆上七丘丟丘万丕 != 1152921505205198864);
    
    }
    internal static void 下丅丕丈丗丅上不一(System.Action<GiftSettingType, GiftSettingType> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.丅丞丅三丂与丙与一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丅丞丅三丂与丙与一 != 1152921505205198872);
    
    }
    internal static void 丘丏丂专业丙上丒丗(System.Action<GiftSettingType, GiftSettingType> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.丅丞丅三丂与丙与一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丅丞丅三丂与丙与一 != 1152921505205198872);
    
    }
    internal static void 丕丝丐丗不不世丌丂(System.Action<SlotInfo> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.万且万万丏丄丟丒七, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.万且万万丏丄丟丒七 != 1152921505205198880);
    
    }
    internal static void 丝丐丘东丈业万三丅(System.Action<SlotInfo> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.万且万万丏丄丟丒七, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.万且万万丏丄丟丒七 != 1152921505205198880);
    
    }
    internal static void 丐东丏丙丂丐丄万且(System.Action<System.TimeSpan> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.业业丌上不丄三丌上, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.业业丌上不丄三丌上 != 1152921505205198888);
    
    }
    internal static void 丟丌万下丗丟丑下一(System.Action<System.TimeSpan> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.业业丌上不丄三丌上, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.业业丌上不丄三丌上 != 1152921505205198888);
    
    }
    internal static void 三丘三上丄丗万丑上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.业丞丞丛丌且丌丄丆, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.业丞丞丛丌且丌丄丆 != 1152921505205198896);
    
    }
    internal static void 世不丘不丑丑丟上下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.业丞丞丛丌且丌丄丆, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.业丞丞丛丌且丌丄丆 != 1152921505205198896);
    
    }
    internal static void 丈三丗世丑丂七丛上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.东业专世丟丝世世且, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.东业专世丟丝世世且 != 1152921505205198904);
    
    }
    internal static void 东业丅丏与七上丄且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.东业专世丟丝世世且, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.东业专世丟丝世世且 != 1152921505205198904);
    
    }
    internal static void 丛丁丆丒业丆丌丛三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.丈下世丁丘丆丙丗丆, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丈下世丁丘丆丙丗丆 != 1152921505205198912);
    
    }
    internal static void 一且丑万业丛东丅丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.丈下世丁丘丆丙丗丆, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丈下世丁丘丆丙丗丆 != 1152921505205198912);
    
    }
    internal static void 世丌专上丟丄三上丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.丄丐丏丕丆专丂丌丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丄丐丏丕丆专丂丌丕 != 1152921505205198920);
    
    }
    internal static void 上上丂丙丒三丅丑与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.丄丐丏丕丆专丂丌丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.丄丐丏丕丆专丂丌丕 != 1152921505205198920);
    
    }
    internal static void 丝丝丑丄世丑专丞丝(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftController.一上世丏丞丞万丘丞, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.一上世丏丞丞万丘丞 != 1152921505205198928);
    
    }
    internal static void 丈专丟不上丆丁丑丝(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftController.一上世丏丞丞万丘丞, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftController.一上世丏丞丞万丘丞 != 1152921505205198928);
    
    }
    public int IncrementFreeSpins(int 丏业下一丑丄丐丘三)
    {
        int val_1 = 丏业下一丑丄丐丘三;
        val_1 = this.丈不万丑丙丟丙丒丏 + val_1;
        this.下丒丙丐丐丅上且下(丙业与丙丗丝不丈东:  val_1);
        this.且丐丟丂丙丒一七丝();
        return val_1;
    }
    internal SlotInfo 世上丞不三丐丅丐不(GiftCategoryType 丁丅丈丌丟世丗丗丟)
    {
        SlotInfo val_1 = 0;
        bool val_2 = this.丏丝丂丅丅业三丛丒.TryGetValue(key:  丁丅丈丌丟世丗丗丟, value: out  val_1);
        return val_1;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_14;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_16;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_18;
        Progress.不丝三一丂丆丐三丈 val_1 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        this.万丆专下一丟不世与 = 0;
        mem[1152921537801618512] = 0;
        Progress.不丝三一丂丆丐三丈 val_2 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        int val_3 = UnityEngine.Mathf.Max(a:  val_2.与丕丘丐专与丛丂丝, b:  1);
        this.七丄世丁专上丙丙丘 = 0;
        mem[1152921537801618576] = 0;
        Progress.不丝三一丂丆丐三丈 val_4 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  -1f);
        Progress.不丝三一丂丆丐三丈 val_5 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        val_14 = null;
        val_14 = null;
        val_16 = GiftController.<>c.<>9__155_0;
        if(val_16 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_6 = null;
            val_16 = val_6;
            val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.String GiftController.<>c::上丕丆三上丂丆丑与(System.Collections.Generic.KeyValuePair<string, string> 三丟东丕丄丄下下丑));
            val_14 = null;
            GiftController.<>c.<>9__155_0 = val_16;
        }
        
        val_14 = null;
        val_18 = GiftController.<>c.<>9__155_1;
        if(val_18 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_7 = null;
            val_18 = val_7;
            val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.String GiftController.<>c::三东业丄丟上丞丌丒(System.Collections.Generic.KeyValuePair<string, string> 三丟东丕丄丄下下丑));
            GiftController.<>c.<>9__155_1 = val_18;
        }
        
        this.丅丕下丒丁丟不三且 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String, System.String>(source:  val_5.丂丕下不与丄丞丁丙, keySelector:  val_6, elementSelector:  val_7);
        if(this.专丗丆丝丝上丞丒丘 != true)
        {
                this.专丗丆丝丝上丞丒丘 = true;
            UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.丅世丄上万丙专丈一());
            System.Collections.IEnumerator val_11 = this.不丒丛世且丏丄丞丘();
            this.丝丅丟丕下不丑业丆 = val_11;
            UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  val_11);
        }
        
        if(this.丈不万丑丙丟丙丒丏 >= 1)
        {
                this.下丘丌丏与丅世丕专(丒且丆丘丞丑业丅不:  0);
        }
        
        this.东业丌下丌丟万丞丑();
    }
    public static int get_randomSeconds()
    {
        return Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  88);
    }
    private void Awake()
    {
        null = null;
        GiftController.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丅世丄上万丙专丈一());
        System.Collections.IEnumerator val_5 = this.不丒丛世且丏丄丞丘();
        this.丝丅丟丕下不丑业丆 = val_5;
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  val_5);
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::东业丌下丌丟万丞丑()));
        ExperienceController.专丒专丒丛下丛丏丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void GiftController::丆丟丒丄丘不丗与七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::上丄丐丞丄与下丄丆()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::一丈专且与且丟下下()));
        专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::丝上七不丞下东丞丆()));
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::丘上丐世丆丑且丞丒()));
    }
    private void 丝上七不丞下东丞丆()
    {
        if(this.丂业三丈与三丂丑丄 == null)
        {
                return;
        }
        
        if(this.丂业三丈与三丂丑丄.Schedule == null)
        {
                return;
        }
        
        this.丂业三丈与三丂丑丄.Schedule.丂丗上丘业丒丕丘且();
    }
    private void 一丈专且与且丟下下()
    {
        var val_3;
        if(this.丑丈丑丘下丟丐与万() != false)
        {
                val_3 = null;
            val_3 = null;
            GiftBannerWindow.丄丘七三上丕世丞业.ForceCloseAll();
            return;
        }
        
        if(AnimationGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
    }
    internal static void 业丑一下丟与丒业丂(bool 东丙丗专丒丆与丕丒 = True)
    {
        GiftController val_6;
        var val_7;
        System.Action<SlotInfo> val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = 东丙丗专丒丆与丕丒;
        val_7 = null;
        val_7 = null;
        val_8 = GiftController.万且万万丏丄丟丒七;
        if(val_8 != null)
        {
                val_8 = GiftController.万且万万丏丄丟丒七;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
            val_8.Invoke(obj:  0);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丆不丒东丆不一丄万(丌丈不丄丝七丕万专:  0);
        val_9 = null;
        val_9 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if(val_6 != false)
        {
                val_10 = null;
            val_10 = null;
            val_6 = GiftController.丆丕丝丒不丙且丐丗;
            if(val_6 != null)
        {
                val_11 = val_6.CanGetGift;
        }
        else
        {
                val_11 = val_6.CanGetGift;
        }
        
            val_6.丅不业丄丗丁丌三丝(丙业与丙丗丝不丈东:  (~val_11) & 1);
        }
        
        GiftController.丙丅七丝丌不丛丏万(上不丙丌下丗丁不与:  false);
    }
    internal static void 丙丅七丝丌不丛丏万(bool 上不丙丌下丗丁不与 = False)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = 0;
        goto label_1;
        label_12:
        val_8 = null;
        val_8 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        GiftController.丆丕丝丒不丙且丐丗.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  new GiftCategoryType[178][0].ToString(), 丙业与丙丗丝不丈东:  System.String.alignConst);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        GiftController.丆丕丝丒不丙且丐丗.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  null.ToString() + "_shown", 丙业与丙丗丝不丈东:  System.String.alignConst);
        val_7 = 1;
        label_1:
        if(val_7 < val_1.Length)
        {
            goto label_12;
        }
        
        val_9 = null;
        val_9 = null;
        GiftController.丆丕丝丒不丙且丐丗.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  "gacha_types", 丙业与丙丗丝不丈东:  System.String.alignConst);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  GiftController.丆丕丝丒不丙且丐丗.不不七与丏东专东丏());
    }
    private void 丆丟丒丄丘不丗与七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.ReCreateSlotsIfPossible();
    }
    private void OnDestroy()
    {
        null = null;
        GiftController.丆丕丝丒不丙且丐丗 = 0;
        FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::东业丌下丌丟万丞丑()));
        ExperienceController.丏东丂丕丞上丒上万(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void GiftController::丆丟丒丄丘不丗与七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        专丈专业丆且且业下.丄与东丌丟下丑与丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftController::丝上七不丞下东丞丆()));
    }
    private void Update()
    {
        string val_13;
        float val_14;
        var val_15;
        var val_16;
        System.Action val_17;
        val_13 = this;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        if(this.丏丒上专下丏上丌丞() > 0f)
        {
                val_14 = this.丏丒上专下丏上丌丞() - UnityEngine.Time.deltaTime;
            this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  val_14);
            if(this.丏丒上专下丏上丌丞() < 0)
        {
                val_14 = 0f;
            this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  val_14);
        }
        
            this.业丁业世丐七丗丄丐 = false;
            if(this.万丁丑丛丐丗丌丗万 == (int)this.丏丒上专下丏上丌丞())
        {
                return;
        }
        
            this.万丁丑丛丐丗丌丗万 = (int)this.丏丒上专下丏上丌丞();
            val_15 = null;
            val_15 = null;
            if(GiftController.一上世丏丞丞万丘丞 == null)
        {
                return;
        }
        
            GiftController.一上世丏丞丞万丘丞.Invoke(obj:  this.GetStringTimer());
            return;
        }
        
        if(this.业丁业世丐七丗丄丐 == true)
        {
                return;
        }
        
        if((int)this.丏丒上专下丏上丌丞() != 0)
        {
                return;
        }
        
        this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  -1f);
        this.canGetTimerGift = true;
        val_16 = null;
        val_16 = null;
        if(GiftController.一上世丏丞丞万丘丞 != null)
        {
                val_13 = this.GetStringTimer();
            GiftController.一上世丏丞丞万丘丞.Invoke(obj:  val_13);
            val_16 = null;
        }
        
        val_16 = null;
        val_17 = GiftController.丄丐丏丕丆专丂丌丕;
        if(val_17 == null)
        {
                return;
        }
        
        val_17 = GiftController.丄丐丏丕丆专丂丌丕;
        if(val_17 == null)
        {
                val_17 = 0;
        }
        
        val_17.Invoke();
    }
    private void 下丘丌丏与丅世丕专(int 丒且丆丘丞丑业丅不 = 0)
    {
        var val_1;
        this.丅不业丄丗丁丌三丝(丙业与丙丗丝不丈东:  丒且丆丘丞丑业丅不);
        this.丟专不专丑丆且丗丕 = true;
        val_1 = null;
        val_1 = null;
        GiftController.东业专世丟丝世世且.Invoke();
        this.ReCreateSlotsIfPossible();
        GiftController.业丞丞丛丌且丌丄丆.Invoke();
    }
    public void SetTimer(int 下下丏一丙不丘丌丞)
    {
        var val_7;
        long val_8;
        val_7 = 下下丏一丙不丘丌丞;
        if(this.三业丂丑丈不丁丈丅 < val_7)
        {
                val_7 = this.三业丂丑丈不丁丈丅;
        }
        
        if(val_7 != 0)
        {
                val_8 = FriendsController.丝丗专上三不丄丑丑() - ((this.三业丂丑丈不丁丈丅 - val_7) << );
        }
        else
        {
                val_7 = FriendsController.丝丗专上三不丄丑丑();
            val_8 = (val_7 + 1) - (this.三业丂丑丈不丁丈丅 << );
        }
        
        this.三业丂丑丈不丁丈丅.专丒丌丄丅三东丒丂(丙业与丙丗丝不丈东:  val_8);
        this.东业丌下丌丟万丞丑();
    }
    public void SetGifts()
    {
        var val_8;
        System.Action val_9;
        if(this.且下不上万业东丅丌 != false)
        {
                if(this._categories != null)
        {
                if(this._categories.Count >= 1)
        {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丞丐上万丅丗不丑丆());
            return;
        }
        
        }
        
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  this.不不七与丏东专东丏());
            return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  this.不不七与丏东专东丏());
        this._categories.Clear();
        this._slots.Clear();
        val_8 = null;
        val_8 = null;
        val_9 = GiftController.丅丆上七丘丟丘万丕;
        if(val_9 == null)
        {
                return;
        }
        
        val_9 = GiftController.丅丆上七丘丟丘万丕;
        if(val_9 == null)
        {
                val_9 = 0;
        }
        
        val_9.Invoke();
    }
    private void 东丐丝世丟上与三下()
    {
        string val_14;
        long val_15;
        var val_16;
        var val_17;
        int val_18;
        long val_3 = 0;
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
                return;
        }
        
        if((System.Int64.TryParse(s:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "gatcha_new_reset_time", 丞丌丑丛上丕丙丕下:  System.String.alignConst), result: out  val_3)) == false)
        {
            goto label_6;
        }
        
        val_15 = val_3;
        if(FriendsController.丝丗专上三不丄丑丑() < 0)
        {
            goto label_14;
        }
        
        GiftController.丙丅七丝丌不丛丏万(上不丙丌下丗丁不与:  false);
        val_16 = null;
        val_16 = null;
        val_15 = 与丂丏丛丞丞丒丟丄.丙丑七丑丈丟三一丕 + val_3;
        goto label_14;
        label_6:
        System.TimeSpan val_7 = System.TimeSpan.FromSeconds(value:  (double)FriendsController.丝丗专上三不丄丑丑());
        long val_8 = val_7._ticks.System.IConvertible.ToInt64(provider:  0);
        System.DateTime val_9 = 0.ToUniversalTime();
        System.TimeSpan val_10 = val_9.dateData.TimeOfDay;
        val_17 = null;
        val_17 = null;
        long val_14 = (long)val_10._ticks.TotalSeconds;
        val_14 = FriendsController.丝丗专上三不丄丑丑() - val_14;
        val_15 = 与丂丏丛丞丞丒丟丄.丙丑七丑丈丟三一丕 + val_14;
        label_14:
        val_14 = "gatcha_new_reset_time";
        if((val_15 & 9223372036854775808) == 0)
        {
                val_18 = val_15.ToString();
        }
        else
        {
                val_18 = System.String.alignConst;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_14, 下下丏一丙不丘丌丞:  val_18);
    }
    private void 且丘丈七丕东丛七丈()
    {
        var val_14;
        System.Action val_28;
        System.Collections.Generic.Dictionary<K, V> val_29;
        var val_30;
        var val_31;
        var val_32;
        bool val_33;
        GiftController val_34;
        var val_35;
        System.Action<SlotInfo> val_36;
        if(this._categories == null)
        {
                return;
        }
        
        val_29 = this.不不七与丏东专东丏();
        string val_2 = 丞东丑专丛丆丄丝世.丂丏丞丘丗丒丕且丐<System.String, System.String>(丏丂万业丙专丏丒丒:  val_29, 下上丐丆丝丟丝丒不:  "gacha_types", 丝专且上丈专下上且:  System.String.alignConst);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == true)
        {
                return;
        }
        
        object val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_2);
        val_30 = 0;
        PGCompany.东丑丒丗一丞下丙丙<T> val_5 = PGCompany.东丑丒丗一丞下丙丙<GiftCategoryType>.万世丅七一专丕丞不();
        int val_6 = Count;
        val_32 = 0;
        goto label_22;
        label_34:
        val_33 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  Item[0], ignoreCase:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_33);
        val_31 = public System.Void System.Collections.Generic.List<GiftCategoryType>::Add(GiftCategoryType item);
        val_5.Add(item:  null);
        val_32 = 1;
        label_22:
        if(val_32 < Count)
        {
            goto label_34;
        }
        
        List.Enumerator<T> val_12 = val_5.GetEnumerator();
        val_34 = this;
        label_46:
        if(((-1162900384) & 1) == 0)
        {
            goto label_36;
        }
        
        new GiftController.丗丌丝且丌丞丑丛与() = new System.Object();
        .丙丑丕丂下丏一丁专 = val_14.丙东专丂世丈丏丁丂();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem[1152921537803761872] = null;
        string val_19 = 丞东丑专丛丆丄丝世.丂丏丞丘丗丒丕且丐<System.String, System.String>(丏丂万业丙专丏丒丒:  this.不不七与丏东专东丏(), 下上丐丆丝丟丝丒不:  .丙丑丕丂下丏一丁专.ToString(), 丝专且上丈专下上且:  System.String.alignConst);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_19)) == true)
        {
            goto label_46;
        }
        
        System.Func<GiftCategory, System.Boolean> val_21 = new System.Func<GiftCategory, System.Boolean>(object:  new GiftController.丗丌丝且丌丞丑丛与(), method:  System.Boolean GiftController.丗丌丝且丌丞丑丛与::丈且不丗世不业丒丑(GiftCategory 丁丂专业丁丅丅丈丙));
        GiftCategory val_22 = System.Linq.Enumerable.FirstOrDefault<GiftCategory>(source:  this._categories, predicate:  null);
        if((val_22 == null) || ((val_22.丝专丝丞与丟丝丗丞(丑丞业丗丒三丂且东:  val_19)) == true))
        {
            goto label_46;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem[1152921537803761872] = null;
        this.不不七与丏东专东丏().set_Item(key:  mem[1152921537803761872].ToString(), value:  System.String.alignConst);
        goto label_46;
        label_36:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_29 = PGCompany.东丑丒丗一丞下丙丙<GiftCategoryType>.万世丅七一专丕丞不();
        val_35 = null;
        val_35 = null;
        val_36 = GiftController.万且万万丏丄丟丒七;
        if(val_36 != null)
        {
                val_36 = GiftController.万且万万丏丄丟丒七;
            if(val_36 == null)
        {
                val_36 = 0;
        }
        
            val_36.Invoke(obj:  0);
            val_35 = null;
        }
        
        val_35 = null;
        val_28 = GiftController.丈下世丁丘丆丙丗丆;
        val_28.Invoke();
    }
    private void 丌丅丅下丗下专丌丏()
    {
        string val_53;
        var val_54;
        System.Func<TSource, System.Boolean> val_55;
        PGCompany.东丑丒丗一丞下丙丙<T> val_56;
        var val_57;
        System.Collections.Generic.Dictionary<System.Int32, GiftCategoryType> val_60;
        var val_61;
        var val_62;
        var val_63;
        bool val_64;
        var val_66;
        var val_67;
        var val_68;
        int val_69;
        var val_70;
        System.Action<SlotInfo> val_71;
        var val_72;
        System.Action val_73;
        System.Collections.Generic.List<GiftCategory> val_25 = 0;
        if((this.丗东丛七业丝丟专一 == true) || (this.且下不上万业东丅丌 == false))
        {
            goto label_2;
        }
        
        this.丗东丛七业丝丟专一 = true;
        this._slots.Clear();
        val_53 = System.String.alignConst;
        string val_2 = 丞东丑专丛丆丄丝世.丂丏丞丘丗丒丕且丐<System.String, System.String>(丏丂万业丙专丏丒丒:  this.不不七与丏东专东丏(), 下上丐丆丝丟丝丒不:  "gacha_types", 丝专且上丈专下上且:  val_53);
        if((System.String.IsNullOrEmpty(value:  val_2)) == false)
        {
            goto label_6;
        }
        
        System.Collections.Generic.HashSet<GiftCategoryType> val_4 = new System.Collections.Generic.HashSet<GiftCategoryType>();
        val_54 = 0;
        goto label_7;
        label_22:
        PGCompany.DataObjects.七下上丁万东丑世业 val_5 = this.丂业三丈与三丂丑丄.Data.Item[0];
        if(val_5.Setting == this.丁东丑丏丐丗丝七一)
        {
            goto label_11;
        }
        
        val_53 = public PGCompany.DataObjects.七下上丁万东丑世业 System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业>::get_Item(int index);
        PGCompany.DataObjects.七下上丁万东丑世业 val_6 = this.丂业三丈与三丂丑丄.Data.Item[0];
        if(val_6.Setting != 1)
        {
            goto label_15;
        }
        
        label_11:
        PGCompany.DataObjects.七下上丁万东丑世业 val_7 = this.丂业三丈与三丂丑丄.Data.Item[0];
        val_53 = public System.Boolean System.Collections.Generic.HashSet<GiftCategoryType>::Add(GiftCategoryType item);
        bool val_8 = val_4.Add(item:  val_7.ItemType);
        label_15:
        val_54 = 1;
        label_7:
        if(val_54 < this.丂业三丈与三丂丑丄.Data.Count)
        {
            goto label_22;
        }
        
        int val_11 = val_4.Count;
        val_55 = 1152921537803948928;
        val_56 = PGCompany.东丑丒丗一丞下丙丙<GiftCategoryType>.万世丅七一专丕丞不();
        val_57 = 0;
        goto label_35;
        label_46:
        if((val_4.Contains(item:  this.丂业三丈与三丂丑丄.GatchaSequence.Item[0])) != false)
        {
                GiftCategoryType val_14 = this.丂业三丈与三丂丑丄.GatchaSequence.Item[0];
            val_56.Add(item:  val_14);
        }
        
        val_57 = 1;
        label_35:
        val_60 = this.丂业三丈与三丂丑丄.GatchaSequence;
        if(val_57 < val_60.Count)
        {
            goto label_46;
        }
        
        goto label_47;
        label_6:
        object val_16 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_2);
        val_61 = 0;
        val_62 = Count;
        val_55 = 1152921504619360256;
        val_56 = PGCompany.东丑丒丗一丞下丙丙<GiftCategoryType>.万世丅七一专丕丞不();
        val_63 = 0;
        goto label_65;
        label_77:
        val_64 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  Item[0], ignoreCase:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_64);
        val_56.Add(item:  null);
        val_63 = 1;
        label_65:
        if(val_63 < Count)
        {
            goto label_77;
        }
        
        label_47:
        val_66 = 1152921537804004224;
        val_67 = 1152921537804005248;
        val_68 = 0;
        goto label_78;
        label_120:
        GiftCategoryType val_24 = val_56.Item[0];
        val_60 = this.丈丑七丞万丕上业三;
        if((val_60.TryGetValue(key:  val_24, value: out  val_25)) == false)
        {
            goto label_86;
        }
        
        System.Func<GiftCategory, System.Boolean> val_28 = null;
        val_55 = val_28;
        val_28 = new System.Func<GiftCategory, System.Boolean>(object:  this, method:  System.Boolean GiftController::丑丁业丗与丌一丙丂(GiftCategory 七丏丄丅丌业与且丙));
        val_69 = val_25.IndexOf(item:  System.Linq.Enumerable.FirstOrDefault<GiftCategory>(source:  this.丈丑七丞万丕上业三.Item[val_24], predicate:  val_28));
        if(val_69 != 1)
        {
            goto label_84;
        }
        
        val_60 = val_25;
        if(val_60.Count == 0)
        {
            goto label_86;
        }
        
        label_84:
        val_55 = this.丈丑七丞万丕上业三.Item[val_24].Item[val_69 & (~(val_69 >> 31))];
        SlotInfo val_35 = new SlotInfo();
        System.Collections.Generic.List<GiftCategory> val_36 = this.丈丑七丞万丕上业三.Item[val_24];
        if(val_35 != null)
        {
                val_60 = val_35;
            .gifts = val_36;
            val_35.业丐丘世丅丅三丁丅(丁丅丈丌丟世丗丗丟:  val_24);
        }
        else
        {
                mem[32] = val_36;
            val_35.业丐丘世丅丅三丁丅(丁丅丈丌丟世丗丗丟:  val_24);
            val_60 = 32;
        }
        
        if(val_69 == 1)
        {
            goto label_92;
        }
        
        val_66 = val_66;
        val_67 = val_67;
        val_56 = val_56;
        if(val_69 >= val_60.Count)
        {
            goto label_94;
        }
        
        if(val_35 != null)
        {
            goto label_96;
        }
        
        goto label_96;
        label_92:
        val_66 = val_66;
        val_67 = val_67;
        val_56 = val_56;
        val_69 = 0;
        label_96:
        .index = val_69;
        label_94:
        if(val_55.AvaliableGiftsCount > 0)
        {
                val_35.PositionInScroll = 0;
            .gift = val_55.丄丗三业东丕丙丈丄(专东丅一三丏三丐丟:  false);
        }
        else
        {
                if(val_35 != null)
        {
                .IsSlotAvailable = false;
        }
        else
        {
                .IsSlotAvailable = false;
        }
        
            val_35.且丂丈东三上丂业丆();
        }
        
        this._slots.Add(item:  val_35);
        if(((this.丁不丐且丆丆三丗业 != null) && (val_24 == this.丁不丐且丆丆三丗业.GiftCategoryType)) && (this.丁不丐且丆丆三丗业.PositionInScroll != val_35.PositionInScroll))
        {
                this.丁不丐且丆丆三丗业 = val_35;
            val_70 = null;
            val_70 = null;
            val_71 = GiftController.万且万万丏丄丟丒七;
            if(val_71 != null)
        {
                val_71 = GiftController.万且万万丏丄丟丒七;
            if(val_71 == null)
        {
                val_71 = 0;
        }
        
            val_71.Invoke(obj:  val_35);
        }
        
        }
        
        丞东丑专丛丆丄丝世.与丅丂万与丒专世三<GiftCategoryType, SlotInfo>(丏丂万业丙专丏丒丒:  this.丏丝丂丅丅业三丛丒, 下上丐丆丝丟丝丒不:  val_24, 丙业与丙丗丝不丈东:  val_35);
        label_86:
        val_68 = 1;
        label_78:
        if(val_68 < val_56.Count)
        {
            goto label_120;
        }
        
        if(PGCompany.丆丂丕丞丛丘丄丂且.丑七不且上丗丁一世().且丈丕丟丐上丐丞丛() != false)
        {
                SlotInfo val_47 = PGCompany.丆丂丕丞丛丘丄丂且.丑七不且上丗丁一世().丕丟丘且丕与丆东丅();
            val_47.PositionInScroll = 1;
            this._slots.Add(item:  val_47);
            val_60 = val_47.GiftCategoryType;
            丞东丑专丛丆丄丝世.与丅丂万与丒专世三<GiftCategoryType, SlotInfo>(丏丂万业丙专丏丒丒:  this.丏丝丂丅丅业三丛丒, 下上丐丆丝丟丝丒不:  val_60, 丙业与丙丗丝不丈东:  val_47);
        }
        
        this._slots.Sort(comparer:  new 丅与上丁丘丐丕丝丛());
        val_72 = null;
        val_72 = null;
        val_73 = GiftController.丅丆上七丘丟丘万丕;
        if(val_73 != null)
        {
                val_73 = GiftController.丅丆上七丘丟丘万丕;
            if(val_73 == null)
        {
                val_73 = 0;
        }
        
            val_73.Invoke();
        }
        
        this.东业丌下丌丟万丞丑();
        PGCompany.东丑丒丗一丞下丙丙<T> val_50 = PGCompany.东丑丒丗一丞下丙丙<GiftCategoryType>.万世丅七一专丕丞不();
        label_2:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  this.不不七与丏东专东丏());
    }
    public void CheckIfAllItemsGot(bool 东丙丗专丒丆与丕丒 = True)
    {
        if(this.丌三世丗一丙丂七丕() < (this._categories.Count - 1))
        {
                return;
        }
        
        GiftController.业丑一下丟与丒业丂(东丙丗专丒丆与丕丒:  东丙丗专丒丆与丕丒);
        this.丟丈上丛丙丕业丁丐(丂业三丈与三丂丑丄:  this.丂业三丈与三丂丑丄, 东丄且一丙上业丈丄:  (~东丙丗专丒丆与丕丒) & 1);
    }
    private System.Collections.IEnumerator 上丝丕丙丆三丞丐丕(GiftCategory 丙丑丕丂下丏一丁专, string 丞丅上丏丂且下丅与, bool 丕丝且丁下业丗丛丐 = False)
    {
        GiftController.丌丟丁丂东世丆且与 val_1 = new GiftController.丌丟丁丂东世丆且与();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丙丑丕丂下丏一丁专 = 丙丑丕丂下丏一丁专;
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        }
        else
        {
                mem[32] = 丙丑丕丂下丏一丁专;
            mem[48] = 丞丅上丏丂且下丅与;
        }
        
        .丕丝且丁下业丗丛丐 = 丕丝且丁下业丗丛丐;
        return (System.Collections.IEnumerator)val_1;
    }
    public void UpdateSlot(SlotInfo 专不丟丕丞丗三世丂)
    {
        GiftInfo val_6;
        var val_7;
        UnityEngine.Debug.LogError(message:  "Update gotcha gift slots");
        val_6 = 专不丟丕丞丗三世丂.category.丄丗三业东丕丙丈丄(专东丅一三丏三丐丟:  false);
        if(专不丟丕丞丗三世丂 == null)
        {
            goto label_5;
        }
        
        专不丟丕丞丗三世丂.gift = val_6;
        if(val_6 != null)
        {
                return;
        }
        
        label_10:
        if(专不丟丕丞丗三世丂 == null)
        {
            goto label_7;
        }
        
        专不丟丕丞丗三世丂.IsSlotAvailable = false;
        goto label_8;
        label_5:
        mem[40] = val_6;
        val_6 = mem[40];
        if(val_6 != 0)
        {
                return;
        }
        
        goto label_10;
        label_7:
        mem[52] = 0;
        label_8:
        专不丟丕丞丗三世丂.且丂丈东三上丂业丆();
        val_7 = 0;
        val_6 = 0;
        goto label_11;
        label_18:
        SlotInfo val_3 = this._slots.Item[0];
        if(val_3.IsSlotAvailable != false)
        {
                this._slots.Item[0].PositionInScroll = 0;
            val_6 = 1;
        }
        
        val_7 = 1;
        label_11:
        if(val_7 < this._slots.Count)
        {
            goto label_18;
        }
    
    }
    public void ReCreateSlotsIfPossible()
    {
        if(this.丈东下七丁七丈丅东 != false)
        {
                this.丈东下七丁七丈丅东 = false;
            this.与丞与丆专一与万丑(丙业与丙丗丝不丈东:  0);
        }
        
        this.丗东丛七业丝丟专一 = false;
        this.SetGifts();
    }
    private void 丐丂下丞丗丂专丟丅()
    {
        this.且丘丈七丕东丛七丈();
        this.TryGetData();
    }
    private System.Collections.IEnumerator 不丒丛世且丏丄丞丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftController.丝丑丟丄上三丆三丐();
    }
    private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 16)
        {
                return;
        }
        
        this.丛不丄与丅丘丙丁与();
    }
    private void 万丟万专七丕丙丆世()
    {
        string val_1 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "gift2_config-v5", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
        {
                return;
        }
        
        this.七丄世丈东一且丞丒.Enqueue(item:  val_1);
    }
    private void 丛不丄与丅丘丙丁与()
    {
        string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  16);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "gift2_config-v5", 下下丏一丙不丘丌丞:  val_2);
        this.七丄世丈东一且丞丒.Enqueue(item:  val_2);
    }
    private System.Collections.IEnumerator 丅世丄上万丙专丈一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftController.丘丏东世丆丈丝三下();
    }
    private void 一丈七丟七七三丂专(string 丌下业东与下丅丞七)
    {
        PGCompany.DataObjects.业丏丈丞丘业丈丞一 val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_16;
        var val_17;
        System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.String> val_18;
        var val_19;
        System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean> val_21;
        var val_22;
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_10 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        Progress.不丝三一丂丆丐三丈 val_3 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        val_11 = val_3.丌七丒丒丁丆业世丆;
        val_12 = 0;
        val_13 = 0;
        if((val_10 == null) || (this.丂业三丈与三丂丑丄 == null))
        {
            goto label_12;
        }
        
        if(135970152 == val_11)
        {
                return;
        }
        
        val_14 = this;
        this.丂业三丈与三丂丑丄 = val_10;
        goto label_15;
        label_12:
        if( != 0)
        {
                val_17 = 0;
        }
        else
        {
                this.丝世丐丞丞丟东丙专(一丐丗丁丞丆丅丟丄:  this.丂业三丈与三丂丑丄);
            val_17 = 1;
        }
        
        if((val_17 & 1) != 0)
        {
                return;
        }
        
        val_14 = this;
        this.丂业三丈与三丂丑丄 = ;
        if( == 0)
        {
            goto label_34;
        }
        
        label_15:
        val_18 = 135970152;
        this.且下不上万业东丅丌 = false;
        if(20 != 0)
        {
                val_11 = 1152921505205354496;
            val_19 = null;
            val_19 = null;
            val_21 = GiftController.<>c.<>9__183_0;
            if(val_21 == null)
        {
                System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean> val_4 = null;
            val_21 = val_4;
            val_4 = new System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GiftController.<>c::丄丐丈丈三世丛丏丞(PGCompany.DataObjects.七下上丁万东丑世业 业七丐世专丝丂丟丈));
            GiftController.<>c.<>9__183_0 = val_21;
        }
        
            val_22 = null;
            val_22 = null;
            val_18 = GiftController.<>c.<>9__183_1;
            if(val_18 == null)
        {
                System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.String> val_6 = null;
            val_18 = val_6;
            val_6 = new System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.String>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.String GiftController.<>c::万丝丂丞丟丅不专万(PGCompany.DataObjects.七下上丁万东丑世业 丐丆丂丒丁万丈丛丅));
            GiftController.<>c.<>9__183_1 = val_18;
        }
        
            this.丁上与丕与且且丘七 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<PGCompany.DataObjects.七下上丁万东丑世业, System.String>(source:  System.Linq.Enumerable.Where<PGCompany.DataObjects.七下上丁万东丑世业>(source:  28563616, predicate:  val_4), selector:  val_6));
            this.丟丈上丛丙丕业丁丐(丂业三丈与三丂丑丄:  this.丂业三丈与三丂丑丄, 东丄且一丙上业丈丄:  false);
        }
        
        this.SetGifts();
        return;
        label_34:
        val_16 = 0;
    }
    private void 丝世丐丞丞丟东丙专(string 一丐丗丁丞丆丅丟丄)
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            UnityEngine.Debug.LogError(message:  "Bad gatcha config: "("Bad gatcha config: ") + DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄)(DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄)));
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "gift2_config-v5", 下下丏一丙不丘丌丞:  System.String.alignConst);
    }
    private void 丟丈上丛丙丕业丁丐(PGCompany.DataObjects.业丏丈丞丘业丈丞一 丂业三丈与三丂丑丄, bool 东丄且一丙上业丈丄 = False)
    {
        bool val_31;
        var val_32;
        var val_33;
        var val_34;
        int val_35;
        var val_36;
        GiftCategory val_37;
        var val_38;
        GiftCategory val_39;
        var val_40;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        val_31 = 东丄且一丙上业丈丄;
        this.丈丛丝世三世丏业丛.Clear();
        this._categories.Clear();
        this.丂且世七丏专专与上.Clear();
        val_32 = 1152921516995559328;
        val_33 = 0;
        goto label_4;
        label_11:
        int val_1 = 丂业三丈与三丂丑丄.Settings.SpinPrice.Item[0];
        this.丈丛丝世三世丏业丛.Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且());
        val_33 = 1;
        label_4:
        if(val_33 < 丂业三丈与三丂丑丄.Settings.SpinPrice.Count)
        {
            goto label_11;
        }
        
        val_34 = 0;
        goto label_12;
        label_18:
        int val_3 = 丂业三丈与三丂丑丄.Settings.SpinCoinsCompensation.Item[0];
        this.丂且世七丏专专与上.Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且());
        val_34 = 1;
        label_12:
        if(val_34 < 丂业三丈与三丂丑丄.Settings.SpinCoinsCompensation.Count)
        {
            goto label_18;
        }
        
        List.Enumerator<T> val_5 = 丂业三丈与三丂丑丄.GatchaItems.GetEnumerator();
        val_35 = 1152921505205194752;
        val_36 = 0;
        label_70:
        label_22:
        if(((-1160177952) & 1) == 0)
        {
            goto label_20;
        }
        
        string val_7 = 0.丐丏七丌丕丗业且上();
        if((public PGCompany.DataObjects.丈专丕下丂丏三专且 List.Enumerator<PGCompany.DataObjects.丈专丕下丂丏三专且>::get_Current()) == 0)
        {
            goto label_22;
        }
        
        new GiftCategory() = new GiftCategory();
        val_37 = new GiftCategory();
        if(val_37 != null)
        {
                .Type = new GiftCategory();
        }
        else
        {
                mem[64] = new GiftCategory();
            val_37 = val_37;
        }
        
        GiftCategory val_9 = val_37 + 48;
        List.Enumerator<T> val_10 = 丂业三丈与三丂丑丄.Data.GetEnumerator();
        label_45:
        if(((-1160177984) & 1) == 0)
        {
            goto label_27;
        }
        
        string val_11 = 0.丐丏七丌丕丗业且上();
        if(((丂业三丈与三丂丑丄.Data == null) || (丂业三丈与三丂丑丄.Data != 1152921537806297216)) || (((System.String.IsNullOrEmpty(value:  val_11.丐丙世七丅丅丐下丙())) == true) || ((public PGCompany.DataObjects.七下上丁万东丑世业 List.Enumerator<PGCompany.DataObjects.七下上丁万东丑世业>::get_Current()) == 0)))
        {
            goto label_45;
        }
        
        new GiftInfo() = new GiftInfo();
        val_38 = 0;
        .Id = val_11.丐丙世七丅丅丐下丙();
        goto label_35;
        label_39:
        Rilisoft.丝丑丂丛万丐丈丘且 val_16 = val_7.m_stringLength.Item[0];
        mem[1152921537806533456].Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_16.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_16.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_16.上万三丆专丏丒丗业});
        val_38 = 1;
        label_35:
        if(val_38 < val_7.m_stringLength.Count)
        {
            goto label_39;
        }
        
        mem[1152921537806533464] = 1152921524297973472;
        mem[1152921537806533480] = GiftController.丁不丐丕专一丞业与(丁丅丈丌丟世丗丗丟:  new GiftCategory());
        mem[1152921537806533504] = GiftController.__il2cppRuntimeField_cctor_finished;
        new GiftCategory().不丕丕专不丅一三丁(东一丁世丑丞业丄丐:  new GiftInfo());
        goto label_45;
        label_27:
        val_39 = val_37;
        val_40 = 0 + 1;
        mem2[0] = 486;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_40 == 1) || ((-1160178080 + ((0 + 1)) << 2) != 486))
        {
            goto label_63;
        }
        
        var val_32 = 0;
        val_32 = val_32 ^ (val_40 >> 31);
        val_40 = val_40 + val_32;
        if( != 0)
        {
            goto label_67;
        }
        
        goto label_65;
        label_63:
        if( != 0)
        {
            goto label_67;
        }
        
        label_65:
        label_67:
        if(new GiftCategory().AnyGifts == false)
        {
            goto label_70;
        }
        
        this._categories.Add(item:  new GiftCategory());
        goto label_70;
        label_20:
        val_45 = 0;
        val_44 = 0;
        val_46 = 0 + 1;
        mem2[0] = 536;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_46 == 1)
        {
            goto label_84;
        }
        
        if(( == 0) || ((-1160178080 + ((0 + 1)) << 2) == 536))
        {
            goto label_123;
        }
        
        label_122:
        label_123:
        Progress.不丝三一丂丆丐三丈 val_20 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        if(val_20.丌七丒丒丁丆业世丆 == 1)
        {
            goto label_98;
        }
        
        Progress.不丝三一丂丆丐三丈 val_21 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        if((val_21.丏不业丈丛世万丟丞.Count == 0) || (丂业三丈与三丂丑丄.Settings.Version != val_20.丌七丒丒丁丆业世丆))
        {
            goto label_98;
        }
        
        Progress.不丝三一丂丆丐三丈 val_23 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        val_36 = 1152921537803272848;
        if(val_23.丏不业丈丛世万丟丞.Count != this._categories.Count)
        {
            goto label_104;
        }
        
        val_47 = 0;
        goto label_105;
        label_113:
        GiftCategory val_26 = this._categories.Item[0];
        Progress.不丝三一丂丆丐三丈 val_27 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        val_35 = val_27.丏不业丈丛世万丟丞.Item[0];
        val_47 = 1;
        val_26.ListPosition = val_35;
        label_105:
        if(val_47 < this._categories.Count)
        {
            goto label_113;
        }
        
        goto label_129;
        label_98:
        GiftController.业丑一下丟与丒业丂(东丙丗专丒丆与丕丒:  (~val_31) & 1);
        this.丟专不丄丄丞世丙丛(万丞丛东丑丑丅一业:  this._categories);
        val_47 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_47.丆不丒东丆不一丄万(丌丈不丄丝七丕万专:  丂业三丈与三丂丑丄.Settings.Version);
        label_129:
        this.上三万丞丛丞不专丑(丂业三丈与三丂丑丄:  丂业三丈与三丂丑丄, 万丞丛东丑丑丅一业:  this._categories);
        this.丒世且丄万丕三一丝();
        return;
        label_84:
        if( != 0)
        {
            goto label_122;
        }
        
        goto label_123;
        label_104:
        this.丟专不丄丄丞世丙丛(万丞丛东丑丑丅一业:  this._categories);
        goto label_129;
    }
    private void 上三万丞丛丞不专丑(PGCompany.DataObjects.业丏丈丞丘业丈丞一 丂业三丈与三丂丑丄, System.Collections.Generic.List<GiftCategory> 万丞丛东丑丑丅一业)
    {
        var val_4;
        System.Collections.Generic.Dictionary<GiftCategoryType, System.Collections.Generic.List<GiftCategory>> val_15;
        System.Collections.Generic.IEnumerable<T> val_16;
        var val_17;
        var val_18;
        System.Func<GiftCategory, System.Int32> val_20;
        this.丈丑七丞万丕上业三 = new System.Collections.Generic.Dictionary<GiftCategoryType, System.Collections.Generic.List<GiftCategory>>();
        List.Enumerator<T> val_2 = 丂业三丈与三丂丑丄.GatchaItems.GetEnumerator();
        val_15 = 1152921537806281856;
        val_16 = 1152921537806692864;
        label_9:
        if(((-1159780256) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if((val_5 == null) || ((this.丈丑七丞万丕上业三.ContainsKey(key:  val_5)) == true))
        {
            goto label_9;
        }
        
        this.丈丑七丞万丕上业三.Add(key:  val_5, value:  0);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_17 = 0;
        goto label_17;
        label_27:
        .丁丅丈丌丟世丗丗丟 = System.Linq.Enumerable.ToArray<GiftCategoryType>(source:  this.丈丑七丞万丕上业三.Keys)[0];
        val_18 = null;
        val_18 = null;
        val_20 = GiftController.<>c.<>9__186_1;
        if(val_20 == null)
        {
                System.Func<GiftCategory, System.Int32> val_12 = null;
            val_20 = val_12;
            val_12 = new System.Func<GiftCategory, System.Int32>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GiftController.<>c::丒丐丘丛丐丝上丂丂(GiftCategory 丁丂专业丁丅丅丈丙));
            GiftController.<>c.<>9__186_1 = val_20;
        }
        
        val_15 = this.丈丑七丞万丕上业三;
        val_16 = System.Linq.Enumerable.OrderBy<GiftCategory, System.Int32>(source:  System.Linq.Enumerable.Where<GiftCategory>(source:  万丞丛东丑丑丅一业, predicate:  new System.Func<GiftCategory, System.Boolean>(object:  new GiftController.丕上丑上业七丌丅丒(), method:  System.Boolean GiftController.丕上丑上业七丌丅丒::且不下丕丂丑一丟丁(GiftCategory 丁丂专业丁丅丅丈丙))), keySelector:  val_12);
        val_15.set_Item(key:  (GiftController.丕上丑上业七丌丅丒)[1152921537806922944].丁丅丈丌丟世丗丗丟, value:  new System.Collections.Generic.List<GiftCategory>(collection:  val_16));
        val_17 = 1;
        label_17:
        if(val_17 < val_8.Length)
        {
            goto label_27;
        }
    
    }
    internal static System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丘丝丁丂丅不不丐万(System.Collections.Generic.Dictionary<string, object> 丈丗与丞一上且上上, string 下上丐丆丝丟丝丒不)
    {
        var val_6;
        string val_11 = 下上丐丆丝丟丝丒不;
        System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> val_1 = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
        if((丈丗与丞一上且上上.ContainsKey(key:  val_11)) == false)
        {
                return val_1;
        }
        
        object val_3 = 丈丗与丞一上且上上.Item[val_11];
        if(val_3 == null)
        {
                return val_1;
        }
        
        val_11 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        List.Enumerator<T> val_4 = val_11.GetEnumerator();
        label_13:
        if(((-1159541264) & 1) == 0)
        {
            goto label_8;
        }
        
        bool val_9 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  0);
        int val_10 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        val_1.Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且());
        goto label_13;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private void 丟专不丄丄丞世丙丛(System.Collections.Generic.List<GiftCategory> 万丞丛东丑丑丅一业)
    {
        var val_23;
        System.Nullable<System.Int32> val_24;
        var val_25;
        var val_26;
        var val_28;
        var val_30;
        var val_31;
        System.Func<GiftCategory, System.Int32> val_33;
        int val_1 = 万丞丛东丑丑丅一业.Count;
        System.Nullable<System.Int32>[] val_2 = new System.Nullable<System.Int32>[0];
        val_23 = 0;
        goto label_2;
        label_6:
        val_24 = 0;
        val_23 = 1;
        val_2[0] = val_24;
        label_2:
        if(val_23 < 万丞丛东丑丑丅一业.Count)
        {
            goto label_6;
        }
        
        System.Collections.Generic.LinkedList<System.Nullable<System.Int32>> val_5 = new System.Collections.Generic.LinkedList<System.Nullable<System.Int32>>(collection:  丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<System.Nullable<System.Int32>>(丅东丗丒丄东丛业丄:  val_2, 丂丆且一丛丙丑七丒:  0));
        val_25 = 0;
        goto label_9;
        label_32:
        GiftCategory val_6 = 万丞丛东丑丑丅一业.Item[0];
        if(val_6.Parity != 2)
        {
            goto label_12;
        }
        
        val_26 = null;
        val_26 = null;
        val_24 = GiftController.<>c.<>9__188_1;
        if(val_24 != null)
        {
            goto label_24;
        }
        
        System.Func<System.Nullable<System.Int32>, System.Boolean> val_7 = null;
        val_24 = val_7;
        val_7 = new System.Func<System.Nullable<System.Int32>, System.Boolean>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GiftController.<>c::东丟丈下丙丐东与七(System.Nullable<int> 丏丟万且丝丒丝丅东));
        GiftController.<>c.<>9__188_1 = val_24;
        goto label_24;
        label_12:
        val_24 = 万丞丛东丑丑丅一业.Item[0];
        if(val_8.Parity != 1)
        {
            goto label_21;
        }
        
        val_28 = null;
        val_28 = null;
        val_24 = GiftController.<>c.<>9__188_2;
        if(val_24 == null)
        {
                System.Func<System.Nullable<System.Int32>, System.Boolean> val_9 = null;
            val_24 = val_9;
            val_9 = new System.Func<System.Nullable<System.Int32>, System.Boolean>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GiftController.<>c::七七与丟且丟东三丝(System.Nullable<int> 丏丟万且丝丒丝丅东));
            GiftController.<>c.<>9__188_2 = val_24;
        }
        
        label_24:
        System.Nullable<System.Int32> val_10 = System.Linq.Enumerable.FirstOrDefault<System.Nullable<System.Int32>>(source:  val_5, predicate:  val_9);
        label_21:
        if(((-1159300232) & 1) != 0)
        {
                GiftCategory val_11 = 万丞丛东丑丑丅一业.Item[0];
            val_11.ListPosition = ;
            val_24 = val_10.HasValue;
            bool val_12 = val_5.Remove(value:  new System.Nullable<System.Int32>() {HasValue = val_24});
        }
        
        val_25 = 1;
        label_9:
        if(val_25 < 万丞丛东丑丑丅一业.Count)
        {
            goto label_32;
        }
        
        val_30 = 0;
        goto label_33;
        label_41:
        val_24 = 万丞丛东丑丑丅一业.Item[0];
        if(val_14.ListPosition == 1)
        {
                System.Nullable<System.Int32> val_15 = System.Linq.Enumerable.First<System.Nullable<System.Int32>>(source:  val_5);
            GiftCategory val_16 = 万丞丛东丑丑丅一业.Item[0];
            val_16.ListPosition = ;
            val_24 = val_15.HasValue;
            bool val_17 = val_5.Remove(value:  new System.Nullable<System.Int32>() {HasValue = val_24});
        }
        
        val_30 = 1;
        label_33:
        if(val_30 < 万丞丛东丑丑丅一业.Count)
        {
            goto label_41;
        }
        
        val_31 = null;
        val_31 = null;
        val_33 = GiftController.<>c.<>9__188_0;
        if(val_33 == null)
        {
                System.Func<GiftCategory, System.Int32> val_19 = null;
            val_33 = val_19;
            val_19 = new System.Func<GiftCategory, System.Int32>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GiftController.<>c::丏丒丒丘丘七丒上且(GiftCategory 丙丑丕丂下丏一丁专));
            GiftController.<>c.<>9__188_0 = val_33;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丆丐东东丏丌丒丛(万丄丐丈上三丄丙丐:  System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<GiftCategory, System.Int32>(source:  万丞丛东丑丑丅一业, selector:  val_19)));
        mem[1152921537807297337] = 1;
    }
    private void 丆丕丄七丑丑丂丒丒()
    {
        this.SetGifts();
    }
    private void 上丄丐丞丄与下丄丆()
    {
        GiftController.丙丅七丝丌不丛丏万(上不丙丌下丗丁不与:  false);
        this.ReCreateSlotsIfPossible();
    }
    internal void 七丁万丈丛丈丝丁丐(string 丞丅上丏丂且下丅与)
    {
        string val_11;
        var val_12;
        string val_13;
        System.Func<TSource, System.Boolean> val_14;
        System.Nullable<GiftCategoryType> val_15;
        System.Nullable<GiftCategoryType> val_16;
        System.Nullable<GiftCategoryType> val_17;
        var val_18;
        var val_19;
        System.Action<SlotInfo> val_20;
        val_11 = 丞丅上丏丂且下丅与;
        val_12 = this;
        GiftController.丆丞丙不丌丘丆丟业 val_1 = new GiftController.丆丞丙不丌丘丆丟业();
        if(val_1 != null)
        {
                val_13 = val_1;
            .丞丅上丏丂且下丅与 = val_11;
        }
        else
        {
                val_13 = 16;
            mem[16] = val_11;
            val_11 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true)
        {
                return;
        }
        
        if(this.且下不上万业东丅丌 == false)
        {
                return;
        }
        
        if(this.丂业三丈与三丂丑丄 == null)
        {
                return;
        }
        
        GiftController.七一上丟丒丞丗七丆 val_3 = null;
        val_11 = val_3;
        val_3 = new GiftController.七一上丟丒丞丗七丆();
        System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean> val_4 = null;
        val_14 = val_4;
        val_4 = new System.Func<PGCompany.DataObjects.七下上丁万东丑世业, System.Boolean>(object:  val_1, method:  System.Boolean GiftController.丆丞丙不丌丘丆丟业::与丛三不丙与丄丐且(PGCompany.DataObjects.七下上丁万东丑世业 丆丐七世世且丏丐业));
        if((System.Linq.Enumerable.FirstOrDefault<PGCompany.DataObjects.七下上丁万东丑世业>(source:  this.丂业三丈与三丂丑丄.Data, predicate:  val_4)) == null)
        {
            goto label_9;
        }
        
        val_15 = 0;
        if(val_11 == null)
        {
            goto label_10;
        }
        
        label_12:
        .丙丑丕丂下丏一丁专 = val_15;
        goto label_11;
        label_9:
        val_16 = 0;
        if(val_11 != null)
        {
            goto label_12;
        }
        
        label_10:
        .丙丑丕丂下丏一丁专 = val_16;
        val_17 = (GiftController.七一上丟丒丞丗七丆)[1152921537807837248].丙丑丕丂下丏一丁专;
        label_11:
        if(val_17.丙东专丂世丈丏丁丂() == 0)
        {
                if(((-1158804456) & 1) != 0)
        {
                return;
        }
        
        }
        
        System.Func<SlotInfo, System.Boolean> val_7 = null;
        val_14 = val_7;
        val_7 = new System.Func<SlotInfo, System.Boolean>(object:  val_3, method:  System.Boolean GiftController.七一上丟丒丞丗七丆::不业丘与丑万与七丈(SlotInfo 丏丛与丅丛丌万专丌));
        val_11 = System.Linq.Enumerable.FirstOrDefault<SlotInfo>(source:  this._slots, predicate:  val_7);
        if(val_11 == null)
        {
                return;
        }
        
        val_8.gift = val_11.category.丗上丆丟丄丕丐丅业(丞丅上丏丂且下丅与:  val_13, 专东丅一三丏三丐丟:  true);
        val_18 = null;
        val_18 = null;
        if(GiftScroll.下上丐万丅丘丏不丂 != false)
        {
                this.丁不丐且丆丆三丗业 = 0;
            val_12 = 1152921505205194752;
            val_19 = null;
            val_19 = null;
            val_20 = GiftController.万且万万丏丄丟丒七;
            if(val_20 == null)
        {
                return;
        }
        
            val_20 = GiftController.万且万万丏丄丟丒七;
            if(val_20 == null)
        {
                val_20 = 0;
        }
        
            val_20.Invoke(obj:  val_11);
            return;
        }
        
        this.丁不丐且丆丆三丗业 = val_11;
    }
    public SlotInfo GetGift(bool 丑丘丈丆丅丟丛丘丑 = False)
    {
        var val_19;
        System.Func<SlotInfo, System.Boolean> val_21;
        var val_22;
        var val_23;
        System.Func<SlotInfo, System.Boolean> val_25;
        if(丑丘丈丆丅丟丛丘丑 != true)
        {
                if((this.ActiveGift != false) && (this.业丁业世丐七丗丄丐 != false))
        {
                this.业丁业世丐七丗丄丐 = false;
            this.下丘丌丏与丅世丕专(丒且丆丘丞丑业丅不:  0);
            this.丘丟丄丈七丄丅丅丗 = true;
            this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  -1f);
            this.ReSaveLastTimeSever();
        }
        else
        {
                if(this.丈不万丑丙丟丙丒丏 < 1)
        {
                return val_9;
        }
        
            this.下丒丙丐丐丅上且下(丙业与丙丗丝不丈东:  this.丈不万丑丙丟丙丒丏 - 1);
            this.下丘丌丏与丅世丕专(丒且丆丘丞丑业丅不:  0);
            this.丘丟丄丈七丄丅丅丗 = true;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "freeSpinsCount", 下下丏一丙不丘丌丞:  this.丈不万丑丙丟丙丒丏, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
            this.且丐丟丂丙丒一七丝();
        }
        
        bool val_4 = PGCompany.丆丂丕丞丛丘丄丂且.丑七不且上丗丁一世().且丈丕丟丐上丐丞丛();
        if(val_4 != false)
        {
                SlotInfo val_6 = PGCompany.丆丂丕丞丛丘丄丂且.丑七不且上丗丁一世().丕丟丘且丕与丆东丅();
        }
        
        SlotInfo val_9 = new SlotInfo(与丄不丌一世东丁丙:  System.Linq.Enumerable.SingleOrDefault<SlotInfo>(source:  this._slots, predicate:  new System.Func<SlotInfo, System.Boolean>(object:  this, method:  System.Boolean GiftController::丆丏丐东不万丏丈一(SlotInfo 丏丛与丅丛丌万专丌))));
        if((SlotInfo)[1152921537808093728].IsEmpty == false)
        {
            goto label_13;
        }
        
        val_19 = null;
        val_19 = null;
        val_21 = GiftController.<>c.<>9__192_2;
        if(val_21 == null)
        {
                System.Func<SlotInfo, System.Boolean> val_10 = null;
            val_21 = val_10;
            val_10 = new System.Func<SlotInfo, System.Boolean>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GiftController.<>c::一丟丈专丄丌三七丈(SlotInfo 丏丛与丅丛丌万专丌));
            GiftController.<>c.<>9__192_2 = val_21;
        }
        
        SlotInfo val_11 = System.Linq.Enumerable.Single<SlotInfo>(source:  this._slots, predicate:  val_10);
        val_9.且丂丈东三上丂业丆(万丏不下丕下丈丗丞:  val_11);
        if(val_11 != null)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        val_22 = val_11;
        goto label_20;
        label_13:
        if((SlotInfo)[1152921537808093728].IsSlotAvailable == true)
        {
            goto label_21;
        }
        
        val_21 = val_9.category;
        if(val_9.GiftCategoryType != val_13.Type)
        {
            goto label_23;
        }
        
        label_21:
        val_22 = val_9;
        label_20:
        .numInScroll = val_9.PositionInScroll;
        if(val_4 != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万不下丄丏丄丑丌三();
        }
        
        this.AddReward(专不丟丕丞丗三世丂:  val_9);
        return val_9;
        label_23:
        val_23 = null;
        val_23 = null;
        val_25 = GiftController.<>c.<>9__192_1;
        if(val_25 == null)
        {
                System.Func<SlotInfo, System.Boolean> val_16 = null;
            val_25 = val_16;
            val_16 = new System.Func<SlotInfo, System.Boolean>(object:  GiftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GiftController.<>c::丄三与下丁一丕丞与(SlotInfo 丏丛与丅丛丌万专丌));
            GiftController.<>c.<>9__192_1 = val_25;
        }
        
        if((System.Linq.Enumerable.Single<SlotInfo>(source:  this._slots, predicate:  val_16)) != null)
        {
            goto label_34;
        }
        
        goto label_35;
    }
    public void CheckAvaliableSlots()
    {
        var val_6;
        System.Collections.Generic.Dictionary<System.String, System.String> val_7;
        var val_8;
        System.Action val_9;
        System.Collections.Generic.List<SlotInfo> val_6 = this._slots;
        val_6 = 0;
        val_6 = val_6.Count - 1;
        if((val_6 & 2147483648) == 0)
        {
                do
        {
            val_6 = val_6 - 1;
            val_6 = val_6 | this._slots.Item[val_6].丛丑丏丐丒丅丂丄丄();
        }
        while((val_6 & 2147483648) == 0);
        
        }
        
        val_7 = this.不不七与丏东专东丏();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐上专丕丘丆丆下万(丂丕下不与丄丞丁丙:  val_7);
        if(val_6 == false)
        {
                return;
        }
        
        val_7 = 1152921505205194752;
        val_8 = null;
        val_8 = null;
        val_9 = GiftController.丅丆上七丘丟丘万丕;
        if(val_9 == null)
        {
                return;
        }
        
        val_9 = GiftController.丅丆上七丘丟丘万丕;
        if(val_9 == null)
        {
                val_9 = 0;
        }
        
        val_9.Invoke();
    }
    public void AddReward(SlotInfo 专不丟丕丞丗三世丂)
    {
        SlotInfo val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        PGCompany.三东丏不丗世丅丌丄 val_78;
        val_70 = 专不丟丕丞丗三世丂;
        if(val_70 == null)
        {
                return;
        }
        
        this.<且与丄丘万丕下下丟>k__BackingField = GiftController.丆三丄且下丏丐丒丝.东丝七业丄丑丒世七(与丄不丌一世东丁丙:  val_70, 下万丄且丄丕丌七丞:  false);
        if(this.丘丟丄丈七丄丅丅丗 != false)
        {
                val_71 = 0;
        }
        else
        {
                val_72 = null;
            val_72 = null;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = GiftController.丆丕丝丒不丙且丐丗.万业丞丙丅丗东丁七();
            val_71;
        }
        
        val_73 = null;
        val_73 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丏专上丗业丒丅丏丕(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 与丄不丌一世东丁丙:  this.<且与丄丘万丕下下丟>k__BackingField, 丏业丂七丈丆丛丏上:  -1157770240, 丁丅丈丌丟世丗丗丟:  GiftController.丆丕丝丒不丙且丐丗.丁东丑丏丐丗丝七一.ToString());
        NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  5);
        val_74 = null;
        val_74 = null;
        Rilisoft.与七且业丛丝丒丝三.丂七丘丅丐丁且业丟(且丒丛与丞世丙丕丌:  1, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  -1157770240);
        GiftCategory val_6 = val_70.category;
        if((val_6.Type - 1) <= 176)
        {
                var val_70 = 106035504 + ((val_6.Type - 1)) << 2;
            val_70 = val_70 + 106035504;
        }
        else
        {
                if(val_6.Type == 9999)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_50 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  专不丟丕丞丗三世丂.gift.itemParams, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            val_78 = 专不丟丕丞丗三世丂.gift.itemParams.与下不与丐丈丁丈万();
        }
        else
        {
                object[] val_52 = new object[1];
            GiftCategory val_53 = val_70.category;
            val_52[0] = val_53.Type;
            UnityEngine.Debug.LogErrorFormat(format:  "unknown gift type: \'{0}\'", args:  val_52);
            val_78 = 0;
        }
        
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_78)) != false)
        {
                PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().一丗丙丝丒丂丗三丁(丟不丄一丄丅一世丗:  6, 不且丐一丆丛丙丙丒:  val_78);
        }
        
            if(this.丈不万丑丙丟丙丒丏 == 0)
        {
                this.丅不业丄丗丁丌三丝(丙业与丙丗丝不丈东:  this.丅丒东丝上丌丗丒丞() + 1);
            this.丟专不专丑丆且丗丕 = false;
        }
        
            if(this.丅丒东丝上丌丗丒丞() >= this.丈丛丝世三世丏业丛.Count)
        {
                this.丅不业丄丗丁丌三丝(丙业与丙丗丝不丈东:  1);
            this.丟专不专丑丆且丗丕 = true;
        }
        
            if(this.丘丟丄丈七丄丅丅丗 != false)
        {
                this.丘丟丄丈七丄丅丅丗 = false;
        }
        
            this.与丞与丆专一与万丑(丙业与丙丗丝不丈东:  this.丌三世丗一丙丂七丕() + 1);
            GiftCategory val_66 = val_70.category;
            val_70 = val_66.Type;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            this.一丘丏七丁丕世丕下(下上丐丆丝丟丝丒不:  val_70.ToString(), 丙业与丙丗丝不丈东:  System.String.alignConst);
            this.CheckIfAllItemsGot(东丙丗专丒丆与丕丒:  false);
            if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(2182 == 2182)
        {
                return;
        }
        
            return;
        }
        
            if(0 != 0)
        {
                return;
        }
        
        }
    
    }
    internal static void 丅丆丆丏万丅丑丝世(int 丌丒丝东丌下丕丁丅)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_5;
        }
        
        val_7 = null;
        val_7 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == null)
        {
            goto label_8;
        }
        
        GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏
        val_8 = GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏;
        goto label_9;
        label_5:
        Progress.不丝三一丂丆丐三丈 val_2 = Progress.七七世万专丕丁上业.一且丄一与业丒东丂();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏专丒上丈丕丗世丙(三一东世丆丕丞丂丞:  val_2.且丞七丌丒丁三丙三 + 丌丒丝东丌下丕丁丅);
        return;
        label_8:
        val_8 = 88;
        label_9:
        GiftController.丆丕丝丒不丙且丐丗.下丒丙丐丐丅上且下(丙业与丙丗丝不丈东:  val_8 + 丌丒丝东丌下丕丁丅);
        GiftController.丆丕丝丒不丙且丐丗.且丐丟丂丙丒一七丝();
    }
    private System.Collections.IEnumerator 丞丐上万丅丗不丑丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftController.且丆丌七丈上丅丌丘();
    }
    public void ReSaveLastTimeSever()
    {
        long val_1 = FriendsController.丝丗专上三不丄丑丑();
        val_1.专丒丌丄丅三东丒丂(丙业与丙丗丝不丈东:  val_1);
        this.东业丌下丌丟万丞丑();
    }
    public string GetStringTimer()
    {
        return 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)this.丏丒上专下丏上丌丞(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
    }
    private void 东业丌下丌丟万丞丑()
    {
        var val_12;
        var val_13;
        val_12 = this;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        if(this._slots.Count == 0)
        {
                return;
        }
        
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
                return;
        }
        
        this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  -1f);
        this.业丁业世丐七丗丄丐 = false;
        if(this.丘丅业上丙丒七下与() == 0)
        {
                this.三业丂丑丈不丁丈丅.专丒丌丄丅三东丒丂(丙业与丙丗丝不丈东:  (FriendsController.丝丗专上三不丄丑丑() + 1) - (this.三业丂丑丈不丁丈丅 << ));
        }
        
        long val_8 = FriendsController.丝丗专上三不丄丑丑();
        long val_10 = val_8 - val_8.丘丅业上丙丒七下与();
        if(this.三业丂丑丈不丁丈丅 > val_10)
        {
                this.业丁业世丐七丗丄丐 = false;
            this.丆且丐且一丞不上丈(丙业与丙丗丝不丈东:  (float)this.三业丂丑丈不丁丈丅 - val_10);
            return;
        }
        
        this.canGetTimerGift = true;
        val_12 = 1152921505205194752;
        val_13 = null;
        val_13 = null;
        if(GiftController.丄丐丏丕丆专丂丌丕 == null)
        {
                return;
        }
        
        GiftController.丄丐丏丕丆专丂丌丕.Invoke();
    }
    public void TryGetData()
    {
        if(this.DataIsLoaded != false)
        {
                return;
        }
        
        if(this.丝丅丟丕下不丑业丆 != null)
        {
                this.StopCoroutine(routine:  this.丝丅丟丕下不丑业丆);
        }
        
        System.Collections.IEnumerator val_2 = this.不丒丛世且丏丄丞丘();
        this.丝丅丟丕下不丑业丆 = val_2;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_2);
    }
    internal static string 丁不丐丕专一丞业与(GiftCategoryType 丁丅丈丌丟世丗丗丟)
    {
        var val_2;
        if((丁丅丈丌丟世丗丗丟 - 1) > 176)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_2 = mem[130689520 + ((丁丅丈丌丟世丗丗丟 - 1)) << 3];
        val_2 = 130689520 + ((丁丅丈丌丟世丗丗丟 - 1)) << 3;
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    private static GiftController()
    {
        null = null;
        GiftController.丅丆上七丘丟丘万丕 = new System.Action(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丌且业丅丆三丙丛东());
        GiftController.丅丞丅三丂与丙与一 = new System.Action<GiftSettingType, GiftSettingType>(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丏业丝丕世且万丅丛(GiftSettingType 上丕与丆丙丆丈丄丁, GiftSettingType 丗丕下东丅丏丕上丏));
        GiftController.万且万万丏丄丟丒七 = new System.Action<SlotInfo>(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丕七丘丟丝且且丁七(SlotInfo 与丄不丌一世东丁丙));
        GiftController.业业丌上不丄三丌上 = new System.Action<System.TimeSpan>(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丐丁丘丂丒下丌丈丑(System.TimeSpan 丐丁丒三一丘不丞丙));
        GiftController.业丞丞丛丌且丌丄丆 = new System.Action(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丕丐一丂丝丅丕不丘());
        GiftController.东业专世丟丝世世且 = new System.Action(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丅丁丟丕三下上丕且());
        GiftController.丈下世丁丘丆丙丗丆 = new System.Action(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::丞丆与丄专丙上丙不());
        GiftController.丄丐丏丕丆专丂丌丕 = new System.Action(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::三丑万丏不丐业业丌());
        GiftController.一上世丏丞丞万丘丞 = new System.Action<System.String>(object:  GiftController.<>c.<>9, method:  System.Void GiftController.<>c::东上三丏丕且与丟丄(string 丏丛与丅丛丌万专丌));
    }
    private bool 丑丁业丗与丌一丙丂(GiftCategory 七丏丄丅丌业与且丙)
    {
        return (bool)(七丏丄丅丌业与且丙.ListPosition >= this.丌三世丗一丙丂七丕()) ? 1 : 0;
    }
    private bool 丆丏丐东不万丏丈一(SlotInfo 丏丛与丅丛丌万专丌)
    {
        GiftCategory val_1 = 丏丛与丅丛丌万专丌.category;
        return (bool)(val_1.ListPosition == this.丌三世丗一丙丂七丕()) ? 1 : 0;
    }

}
