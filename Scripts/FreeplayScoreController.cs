using UnityEngine;
internal sealed class FreeplayScoreController : PhotonEventBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private const string 东上一丆丕丗业世上 = "bstPlrNm";
    internal static float 丅上七丈丄丐不丆丛;
    private FreePlayModeController 丂丛丑东不丅丈一东;
    internal bool 不丞丝不与且丕丕丕;
    
    // Properties
    internal double 下丞丝丘丗业丁丅万 { get; set; }
    internal float 丝丙一丝丈丂不丙一 { get; }
    internal bool 丕丏下丌丆丝丛万丘 { get; }
    
    // Methods
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        if((丞世不丒下上上丝丑 & 255) != 0)
        {
                return false;
        }
        
        this.丌三丌丑七业上丕不();
        return true;
    }
    internal double 丕丟丛丑丕万丛丟不()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_9 = 0;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 1.28822976017949E-231;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.上丛一丟丄丂专丙丞)) == false)
        {
                return 1.28822976017949E-231;
        }
        
        val_11 = null;
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_11 = null;
        object val_7 = val_8.Item[GameConnect.上丛一丟丄丂专丙丞];
        return 1.28822976017949E-231;
    }
    internal void 下丘且丌丛且丈丁丕(double 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.上丛一丟丄丂专丙丞, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal float 东下七上专丞一七万()
    {
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = this.丕丟丛丑丕万丛丟不() - val_2;
        return UnityEngine.Mathf.Max(a:  (float)val_2, b:  0f);
    }
    internal bool 丌与业丒丒丄丑丑丝()
    {
        var val_4;
        NetworkStartTable val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_5 != 0)
        {
                val_6 = null;
            val_6 = null;
            val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_5 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            var val_3 = (业七业丅丅丝万丕丝() == 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private void Start()
    {
        var val_2;
        OnlineModeController val_3;
        val_2 = null;
        val_2 = null;
        val_3 = GameController.onlineMode;
        this.丂丛丑东不丅丈一东 = (null == null) ? (val_3) : 0;
    }
    private void Update()
    {
        float val_12;
        var val_13;
        var val_14;
        bool val_1 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_1 == false)
        {
                return;
        }
        
        val_12 = val_1.丕丟丛丑丕万丛丟不();
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_12 >= 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        int val_4 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
        if(val_4 < 1)
        {
                return;
        }
        
        val_12 = val_4.丕丟丛丑丕万丛丟不();
        val_14 = null;
        val_14 = null;
        double val_12 = (double)FreeplayScoreController.丅上七丈丄丐不丆丛;
        val_12 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_12;
        下丘且丌丛且丈丁丕(丙业与丙丗丝不丈东:  val_12);
        if(val_12 == 0f)
        {
                return;
        }
        
        NetworkStartTable val_8 = System.Linq.Enumerable.First<NetworkStartTable>(source:  NetworkStartTable.下上丞丞丏丅丕丏世());
        ExitGames.Client.Photon.Hashtable val_9 = new ExitGames.Client.Photon.Hashtable();
        val_9.Add(key:  "bstPlrNm", value:  val_8.丂丈丐不丏万三七丐);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  0, 丕业丑万一丞丞东三:  false, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        this.丌三丌丑七业上丕不();
    }
    private void 丌三丌丑七业上丕不()
    {
        null = null;
        this.下丕世且不丄丂且丏(且丒丛与丞世丙丕丌:  业七业丅丅丝万丕丝(), 万且丒下丕丝专丟上:  this.丂丛丑东不丅丈一东.丞丏丕丑丞丑丏丏丄());
        if(this.丂丛丑东不丅丈一东 == null)
        {
            
        }
    
    }
    private void 下丕世且不丄丂且丏(int 且丒丛与丞世丙丕丌, int 万且丒下丕丝专丟上)
    {
        float val_38;
        InGameGUIPart_Freeplay val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        UnityEngine.Object val_65;
        var val_66;
        float val_67;
        double val_68;
        int val_70;
        var val_71;
        var val_72;
        val_57 = this;
        val_58 = null;
        val_58 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_59 = null;
        val_59 = null;
        FriendsController.丄丞丁丈与业上丞丟.SyncRatingAndRoundWon(丞业一专不七三丁丘:  (且丒丛与丞世丙丕丌 == 0) ? 1 : 0);
        if(且丒丛与丞世丙丕丌 == 0)
        {
                val_60 = null;
            val_60 = null;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.万丑专万丅丛且万丗, 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.万丑专万丅丛且万丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        bool val_8 = true;
        if(NetworkStartTable.与一专丒东丏丘专丕() != true)
        {
                上丑丝丌七不丙丗丅 val_9 = 专上丈丌丒丁丒丆三.丁三丈丏丐业丘丏业(丒七世丈丌丑丏丄丏:  GameConnect.丑丌丛丈丅丅与不业(), 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌, 万且丒下丕丝专丟上:  万且丒下丕丝专丟上, 丂丌丙丝且东丗丙万:  0, 业东丞丏丒业万丏丘:  (且丒丛与丞世丙丕丌 == 0) ? 1 : 0, 丌丁业丅丕丁丈丌丅: out  val_8);
        }
        
        val_61 = 0;
        if((且丒丛与丞世丙丕丌 == 0) && ((Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业())) != false))
        {
                int val_15 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丑丆丗丞丈不丘丞丝(丅丈专上丄丅丛丈业:  GameConnect.丑丌丛丈丅丅与不业());
            int val_16 = 1152921537549522664 * val_15;
            int val_18 = 丆丒丘丐下丞丛上丈() * val_15;
            val_61 = 1;
        }
        
        if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) != false)
        {
                int val_22 = Rilisoft.VIPController.专丌丞丌丕丕丞丅丆() * ;
            int val_25 = Rilisoft.VIPController.专丌丞丌丕丕丞丅丆() * 丆丒丘丐下丞丛上丈();
        }
        
        this.三丛丁丆东世丁丏三(三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false}, 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
        if(val_61 != 0)
        {
                System.Nullable<System.DateTime> val_28 = FriendsController.业丈丏丏丞丘丛丈丛();
            Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丄丈丅丄七业丁上丐(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 不丗万丘丆丗上丗丏:  new System.Nullable<System.DateTime>() {HasValue = val_28.HasValue});
        }
        
        val_62 = null;
        val_62 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_56;
        }
        
        val_63 = null;
        val_63 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_56;
        }
        
        val_64 = null;
        val_64 = null;
        if(null != 0)
        {
            goto label_61;
        }
        
        goto label_61;
        label_56:
        val_65 = 0;
        label_61:
        if(val_65 == 0)
        {
            goto label_92;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.SceneManagement.Scene val_35 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_66 = null;
        val_66 = null;
        double val_37 = GameController.mode.不东业丒丛丙丗上丝();
        if(val_37 >= 0f)
        {
            goto label_76;
        }
        
        if(val_37 != (-0.5))
        {
            goto label_77;
        }
        
        val_67 = val_38;
        val_68 = -1;
        goto label_78;
        label_76:
        if(val_37 != 0.5)
        {
            goto label_79;
        }
        
        val_67 = val_38;
        val_68 = 1;
        label_78:
        val_68 = val_67 + val_68;
        var val_39 = (((long)val_67 & 1) != 0) ? (val_67) : (val_68);
        if(val_65 == 0)
        {
            goto label_83;
        }
        
        label_84:
        val_70 = val_65.丝丈丅一丆丗丝丝丘();
        goto label_81;
        label_77:
        double val_41 = val_37 + (-0.5);
        if(val_65 != 0)
        {
            goto label_84;
        }
        
        goto label_83;
        label_79:
        double val_42 = val_37 + 0.5;
        if(val_65 != 0)
        {
            goto label_84;
        }
        
        label_83:
        val_70 = val_65.丝丈丅一丆丗丝丝丘();
        label_81:
        val_38 = 0;
        PGCompany.Analytics.一业丗丆世世上丁且.丘丒丑业一丗丞丁丛(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业().ToString(), 丏丈丗世丙万丆丐丅:  val_35.m_Handle.name, 丌三丒丌丆东万丆一:  false, 专世专丟丝丌与丘上:  0, 与丈业丛丝丒丙一丏:  val_37, 丝丐丐丟丙丆一丄丗:  0, 下丝丘丁专丐丅丛丝:  val_70, 丞丗丄七专丈丕丕业:  val_65.丑丛丆三丆丄七丐万(), 丕丈一丐丛世丆上万:  new RatingSystem.丁上且上一丆丘与业(), 万三丟世三一不专丛:  4);
        PGCompany.Analytics.一业丗丆世世上丁且.丝丟且丟三丘丟丛丗(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丙七七丈丐且一丟业: ref  new System.Nullable<丟与丁丑丗下丐丛一>() {HasValue = false});
        val_71 = null;
        val_71 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_72 = null;
            val_72 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丘丑一东下下东丂七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 一丏丌丆东丟丗不与:  业且丌下丕上丕七丛());
            七专丞东一丅下丈与();
        }
        
        label_92:
        PGCompany.Analytics.一业丗丆世世上丁且.世专丆与丝丁东三丌(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丛丁三世世丆七不业:  -1417062680, 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌, 丏丂不专上丘丂不丅:  "coins");
        int val_50 = ExperienceController.丞丞丘业东丙丏七丌();
        val_57 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_57 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        ShowReward(且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌, 丕业丘丐且丒专丂不:  -1417062680, 丂丁丏丏万丛丈丐丆:  丆丒丘丐下丞丛上丈(), 与丟且丝丞一丘七丑:  -1417062680, 下丟与丙丁三丕丏下:  Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐(), 丏丙七丑与丐东丈丅:  true, 上丌丛不业与世丑丏:  (val_8 != 0) ? 1 : 0);
    }
    private void 三丛丁丆东世丁丏三(专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 三丂丞丒一与且丈丆, int 且丒丛与丞世丙丕丌)
    {
        var val_16;
        int val_1 = ExperienceController.丞丞丘业东丙丏七丌();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  140);
        if(三丂丞丒一与且丈丆.下丅丌丌丆不东专丁.丆丒丘丐下丞丛上丈() >= 1)
        {
                val_16 = null;
            val_16 = null;
            int val_4 = 三丂丞丒一与且丈丆.下丅丌丌丆不东专丁.丆丒丘丐下丞丛上丈();
            ExperienceController.sharedController.丗丒丂丕丟东丟丙不(业不七丗东丛下一东:  val_4, 世丁丙世丄一万丆三:  4, 与丌丛丈丕丁丅丄丗:  val_4.一业丟东下丏世专丘(且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌));
        }
        
        if(1152921537549822304 >= 1)
        {
                BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  -1416763040, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  38, 丟世且丕丂丁万丒万:  0);
        }
        
        if(1152921537549822304 >= 1)
        {
                bool val_6 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  -1416763040, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  0);
            Rilisoft.一丟专且三万丞丁丂.上丆丞万专与丛丕丈(且丘丞丕丐丗丅丅丂:  -1416763040);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if((ProgressRoad.丁丒丛丆与七丟丗丙.丑七不且上丗丁一世().丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东() - 三丂丞丒一与且丈丆.下丅丌丌丆不东专丁.丆丒丘丐下丞丛上丈())) == (ProgressRoad.丁丒丛丆与七丟丗丙.丑七不且上丗丁一世().丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东())))
        {
                return;
        }
        
        this.不丞丝不与且丕丕丕 = true;
    }
    private System.Collections.Generic.Dictionary<string, object> 一业丟东下丏世专丘(int 且丒丛与丞世丙丕丌)
    {
        var val_5;
        var val_6;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_5 = null;
        val_5 = null;
        世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_2 == null)
        {
            goto label_6;
        }
        
        string val_3 = val_2.东丙上东业丆不丟丘();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        label_16:
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.一丌业三七丝丁丆丁, value:  val_3);
        val_6 = null;
        val_6 = null;
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.七丒丘专丆丏丝专东, value:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.专且丄业业世丟上不, value:  31);
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.世丏七三丘丁丙东三, value:  且丒丛与丞世丙丕丌);
        return val_1;
        label_6:
        if(val_1 != null)
        {
            goto label_16;
        }
        
        goto label_16;
    }
    public FreeplayScoreController()
    {
    
    }
    private static FreeplayScoreController()
    {
        FreeplayScoreController.丅上七丈丄丐不丆丛 = 300f;
    }

}
