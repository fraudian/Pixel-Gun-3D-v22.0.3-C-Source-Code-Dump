using UnityEngine;
public class OnlineModeController : GameModeController
{
    // Fields
    public InGameConnection connection;
    internal NetworkStartTable 丟三丏丅世一丟丟上;
    internal TeamController teamController;
    public UnityEngine.GameObject tempCam;
    public UnityEngine.GameObject tableNGUIPrefab;
    internal UnityEngine.GameObject 丘丏七丑世丏丝丝一;
    internal System.Collections.Generic.List<NetworkStartTable> 丌丏丒上丆丏下与世;
    internal System.Collections.Generic.Dictionary<string, int> 与丞丛丏且业七且业;
    internal System.Collections.Generic.Dictionary<string, int> 丐丌与丛丈丏丘且丁;
    internal bool 丅丅丌丞七东丂上丙;
    internal bool 丗三不丞丈业丑丘万;
    internal NetworkStartTableNGUIController 丆且东三丑丝丏丝丘;
    private static 丕丁丕上与丅不丙丄 一丙万丙丝与丌不万;
    internal 丕丁丕上与丅不丙丄 丞丑丕与万丂丝丂丅;
    private 丕丁丕上与丅不丙丄 七丘专七丈上世七下;
    private 丟丙三专丂丝丒丏丌 丒丅丘丕丗世不万丈;
    private 丘丛丌万一丅丑丙丄 上丗丙一丞上丌丑且;
    private 且下丙业丌与丕且丑 丘丁丒丌丐丘丕七与;
    protected PlayerBotsManager 且下丟一且下下丒丛;
    public PhotonEventAgent photonEvent;
    private 专与丁丏丄下东丏且 丈业丄丄丘丟专丈七;
    private System.Action 七丝丙丘丄丝丟丝专;
    private static System.Action 丁丂丝丄不三丂业丐;
    
    // Methods
    public override void Initialize()
    {
        var val_18;
        System.Action val_19;
        var val_20;
        System.Action<ExitGames.Client.Photon.Hashtable> val_21;
        var val_22;
        this.Initialize();
        if(this.丈业丄丄丘丟专丈七 != null)
        {
                this.丈业丄丄丘丟专丈七.东丏丒丑丗一丕东丞();
        }
        
        val_18 = null;
        val_18 = null;
        val_20 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  System.Void OnlineModeController::OnConnectedToMaster()))) != null) && (null != null))
        {
                val_20 = null;
            val_19 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_19;
        if(((System.Delegate.Combine(a:  GameConnect.世丄丄与丌业丑丕丈, b:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  typeof(OnlineModeController).__il2cppRuntimeField_340))) != null) && (null != null))
        {
                val_21 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_21;
        val_22 = null;
        val_22 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = false;
        this.丗三不丞丈业丑丘万 = false;
        this.七丘专七丈上世七下 = this;
        this.丒丅丘丕丗世不万丈 = new 丟丙三专丂丝丒丏丌();
        this.上丗丙一丞上丌丑且 = new 丘丛丌万一丅丑丙丄();
        this.丘丁丒丌丐丘丕七与 = new 且下丙业丌与丕且丑();
        this.丅丅丌丞七东丂上丙 = GameConnect.七专丝上丆丆丒丐万();
        if(this.teamController != 0)
        {
                return;
        }
        
        if((GameConnect.丗丁丟丑三丟万丕丌(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
                return;
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == true)
        {
                return;
        }
        
        this.teamController = this.gameObject.AddComponent<TeamController>();
    }
    internal void 丏七丝丄七丘下丕三()
    {
        if(this.丈业丄丄丘丟专丈七 == null)
        {
            goto label_0;
        }
        
        if(this.丈业丄丄丘丟专丈七.且丙丑丝三东东且不() != true)
        {
                this.丟三丏丅世一丟丟上.丗七业一丒七上不万();
        }
        
        if(this.丈业丄丄丘丟专丈七.丙丄丟丆丂丒丆下万() == false)
        {
            goto label_4;
        }
        
        label_0:
        this.丟丛专七不七丆三万();
        return;
        label_4:
        this.丆且东三丑丝丏丝丘.下上丅丗丁丕丗专上(丝丘丅丙业丏丞万丁:  this.丈业丄丄丘丟专丈七.且丙丑丝三东东且不(), 丁丂丁丄三丄且万丁:  this.丈业丄丄丘丟专丈七.世丂不丟东丁东丑丐(), 与业丄丂丂丆下上丞:  this.丈业丄丄丘丟专丈七.三且且东丌下丂丗专(), 丄专万丏丘上丑与一:  this.丈业丄丄丘丟专丈七.丘丒不不丌丘下丒一());
    }
    internal void 丏丈丌丂下三不世丙(int 丄丒且丙三丆丟与丏)
    {
        if(this.丈业丄丄丘丟专丈七 == null)
        {
                return;
        }
        
        this.丈业丄丄丘丟专丈七.专丏丘丌下丐业丗世(丑丒丞丘丙一万丙专:  丄丒且丙三丆丟与丏);
    }
    public override void AfterInitialization()
    {
        this.AfterInitialization();
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.丘丏七丑世丏丝丝一 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tempCam, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        if((GameConnect.丛上丆一丂业丕丈丐() != true) && (this.丅丅丌丞七东丂上丙 != true))
        {
                if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        }
        
        }
        
        this.且下丟一且下下丒丛 = this.gameObject.AddComponent<PlayerBotsManager>();
    }
    internal override void 丝丐不东一一丁丌七()
    {
        string val_56;
        var val_57;
        bool val_59;
        var val_60;
        var val_61;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_62;
        var val_63;
        var val_64;
        bool val_65;
        bool val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        bool val_71;
        var val_72;
        InGameConnection val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        this.丝丐不东一一丁丌七();
        this.丟三丏丅世一丟丟上.丏丛丞东丈丑丛丕一();
        if(this.丈业丄丄丘丟专丈七 != null)
        {
                this.丈业丄丄丘丟专丈七.丟丞且丈丙丌丅丟专();
        }
        
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "In game");
        var val_55 = 0;
        val_55 = val_55 + 1;
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Clear();
        丘丒丄丗丄丒丆不丄 val_5 = 丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙();
        val_56 = 1152921505066536960;
        if(((GameConnect.东且三丆丑世世丘丟() != true) && (GameConnect.世丐丄三三上丅七三() != true)) && (GameConnect.丙丘不世专且万丄丐() != true))
        {
                val_57 = null;
            val_57 = null;
            if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() == false)
        {
            goto label_29;
        }
        
        }
        
        }
        
        label_150:
        val_59 = 1152921504848912384;
        if(TimeGameController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_32;
        }
        
        var val_11 = (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 > 30) ? 1 : 0;
        if(val_5 != null)
        {
            goto label_36;
        }
        
        goto label_35;
        label_32:
        val_60 = 0;
        if(val_5 != null)
        {
            goto label_36;
        }
        
        label_35:
        label_36:
        val_5.不上丕不丞业一丗丂(与丕丈丅七七丙万七:  false, 专丗世丅专丗丁三七:  false);
        val_61 = null;
        val_61 = null;
        if(null != 0)
        {
            goto label_85;
        }
        
        Rilisoft.一丟专且三万丞丁丂.七七下东丘丒丟丛世();
        if((System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0))) != false)
        {
                val_62 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_62 != null)
        {
                val_62 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_62 == null)
        {
                val_62 = 0;
        }
        
            val_63 = val_62.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_63 = 0;
        }
        
            Rilisoft.一丟专且三万丞丁丂.丅专丒丄业且丗万丛(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丑丐丗三丒世丏东丅:  0);
        }
        
        if(Initializer.丑七不且上丗丁一世() != 0)
        {
                val_64 = null;
            val_64 = null;
            val_65 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_65 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_65 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_22 = BattleRoyaleController.丑七不且上丗丁一世();
            val_66 = val_22.squadMode;
        }
        else
        {
                val_66 = 0;
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if((TeamDuelController.丅丌丛丏丞上万丛丕 + 144) != 0)
        {
            goto label_85;
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_81;
        }
        
        val_67 = null;
        val_67 = null;
        if((SiegeController.三三万丆下一丗万丛 + 113) != 0)
        {
            goto label_85;
        }
        
        label_81:
        Rilisoft.丞丛七上丕专丏丌丈.万丅业下万三万丕上(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  UnityEngine.Application.loadedLevelName, 万丟丗丏专丆丌上三:  (val_65 != 0) ? 1 : 0, 万丄且丄丛丁丒丙丂:  (val_66 != 0) ? 1 : 0);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.SceneManagement.Scene val_32 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        PGCompany.Analytics.一业丗丆世世上丁且.丐丌与丐丙一不上丌(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业().ToString(), 丏丈丗世丙万丆丐丅:  val_32.m_Handle.name, 万丟丗丏专丆丌上三:  (val_65 != 0) ? 1 : 0, 下丁丝丗专丝世丒丂:  (val_66 != 0) ? 1 : 0);
        label_85:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_98;
        }
        
        val_68 = null;
        val_68 = null;
        if(SiegeController.三三万丆下一丗万丛 == 0)
        {
            goto label_170;
        }
        
        val_69 = null;
        val_69 = null;
        if(SiegeController.三三万丆下一丗万丛.roomStatusGlobal != 4)
        {
            goto label_170;
        }
        
        label_98:
        if(Initializer.丑七不且上丗丁一世() != 0)
        {
                val_70 = null;
            val_70 = null;
            val_71 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_71 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_71 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_43 = BattleRoyaleController.丑七不且上丗丁一世();
            val_59 = val_43.squadMode;
        }
        else
        {
                val_59 = 0;
        }
        
        val_56 = 与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙();
        Rilisoft.丞丛七上丕专丏丌丈.丕业丕丑丞万丟丐丛(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  UnityEngine.Application.loadedLevelName, 万丟丗丏专丆丌上三:  (val_71 != 0) ? 1 : 0, 万丄且丄丛丁丒丙丂:  (val_59 != 0) ? 1 : 0, 世东万一东丒丂一不:  (~(丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7).Equals(value:  val_56))) & 1);
        label_170:
        val_72 = null;
        val_72 = null;
        val_73 = GameController.丆丘丂丈世丏丟丑丏;
        val_74 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != false)
        {
                val_75 = null;
            int val_56 = SquadController.丄丟丐丁丑丏丂丅不;
            val_56 = val_56 + 1;
            SquadController.丄丟丐丁丑丏丂丅不 = val_56;
            val_73 = SquadController.丘业不丅万不丐东丝;
            Rilisoft.一丟专且三万丞丁丂.世丛丝东丑不丁专丛(万丅丙丁上丌不丕丄:  SquadController.丄丟丐丁丑丏丂丅不, 丙世不不一丏业三且:  (val_73 == true) ? 1 : 0);
        }
        else
        {
                val_76 = null;
            SquadController.丄丟丐丁丑丏丂丅不 = 0;
        }
        
        this.丆且东三丑丝丏丝丘.丒丆且丑业世丅三上();
        return;
        label_29:
        val_77 = null;
        val_77 = null;
        var val_53 = (WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 0) ? 1 : 0;
        goto label_150;
    }
    protected override void 丕丗东且一且且丘丂()
    {
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        float val_73;
        float val_74;
        float val_75;
        float val_76;
        var val_77;
        var val_78;
        var val_79;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  10000f, a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            val_59 = val_4.x;
            val_60 = val_4.y;
            val_61 = val_4.z;
            val_62 = val_4.w;
            val_63 = 0;
        }
        else
        {
                val_63 = this.丟三丏丅世一丟丟上.丑丆丘丗世不丌丅丒(丕丅不业专丑丁上丅:  true);
            UnityEngine.Vector3 val_6 = val_5.boxCollider.size;
            UnityEngine.Vector3 val_7 = val_5.万东万丆专丌丕丐丗.localScale;
            UnityEngine.Vector3 val_8 = val_5.boxCollider.size;
            UnityEngine.Vector3 val_9 = val_5.万东万丆专丌丕丐丗.localScale;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_6.x * val_7.x, y:  val_8.z * val_9.z);
            UnityEngine.Vector3 val_13 = val_5.万东万丆专丌丕丐丗.position;
            UnityEngine.Vector3 val_14 = val_5.万东万丆专丌丕丐丗.position;
            float val_54 = 0.5f;
            val_64 = val_13.x - (val_12.x * val_54);
            val_54 = val_12.y * val_54;
            val_65 = val_14.z - val_54;
            val_66 = val_12.x;
            if(GameConnect.世丐丄三三上丅七三() != false)
        {
                UnityEngine.Vector3 val_17 = val_5.万东万丆专丌丕丐丗.position;
        }
        else
        {
                float val_18 = 0.x;
            UnityEngine.Vector3 val_20 = val_5.万东万丆专丌丕丐丗.position;
            val_66 = val_20.x + (UnityEngine.Random.Range(min:  0f, max:  val_20.x));
            val_64 = val_18 + (UnityEngine.Random.Range(min:  0f, max:  val_18));
            val_65 = val_20.y;
        }
        
            UnityEngine.Quaternion val_23 = val_5.万东万丆专丌丕丐丗.rotation;
            val_59 = val_23.x;
            val_60 = val_23.y;
            val_61 = val_23.z;
            val_62 = val_23.w;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                val_67 = null;
            val_67 = null;
            if(null != 0)
        {
                val_68 = null;
            val_68 = null;
            if((GameConnect.一与东丝万上三丆丏() != true) && (GameConnect.丒丗丁丙丗丄丙不丐() != true))
        {
                if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_69 = null;
            val_69 = null;
            val_70 = null;
            val_70 = null;
        }
        
            val_71 = null;
            val_71 = null;
        }
        
        }
        
        }
        
        val_72 = null;
        val_72 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                val_74 = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_28;
            val_75 = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_28;
            val_76 = 丕丁丕上与丅不丙丄.__il2cppRuntimeField_this_arg;
            UnityEngine.GameObject val_30 = 丝丗丛丆下丟丑丟丆(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_74, y = val_75, z = val_76}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_59, y = val_60, z = val_61, w = val_62}).gameObject;
        }
        else
        {
                UnityEngine.GameObject val_33 = 丟丆丗丌下且丅丌丈(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()).gameObject;
            val_33.transform.position = new UnityEngine.Vector3() {x = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_28, y = typeof(丕丁丕上与丅不丙丄).__il2cppRuntimeField_28, z = 丕丁丕上与丅不丙丄.__il2cppRuntimeField_this_arg};
            val_74 = val_59;
            val_75 = val_60;
            val_76 = val_61;
            val_33.transform.rotation = new UnityEngine.Quaternion() {x = val_74, y = val_75, z = val_76, w = val_62};
        }
        
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                if(val_63.transform.childCount >= 1)
        {
                UnityEngine.Vector3 val_41 = val_63.transform.GetChild(index:  0).position;
            UnityEngine.Vector3 val_43 = val_63.transform.position;
            val_73 = val_43.y;
            val_74 = val_41.x;
            val_75 = val_41.y;
            val_76 = val_41.z;
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_74, y = val_75, z = val_76}, b:  new UnityEngine.Vector3() {x = val_43.x, y = val_73, z = val_43.z});
            val_59 = val_44.x;
            val_61 = val_44.z;
            mem2[0] = val_59;
            mem2[0] = val_44.y;
            mem2[0] = val_61;
        }
        
            if(val_5.万东万丆专丌丕丐丗.childCount >= 1)
        {
                UnityEngine.Vector3 val_47 = val_5.万东万丆专丌丕丐丗.GetChild(index:  0).position;
            UnityEngine.Vector3 val_48 = val_5.万东万丆专丌丕丐丗.position;
            val_73 = val_48.y;
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, b:  new UnityEngine.Vector3() {x = val_48.x, y = val_73, z = val_48.z});
            val_59 = val_49.x;
            val_61 = val_49.z;
            mem2[0] = val_59;
            mem2[0] = val_49.y;
            mem2[0] = val_61;
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_77 = null;
            val_77 = null;
            if(null != 0)
        {
                val_78 = null;
            val_78 = null;
        }
        
            FirstPersonControlSharp val_51 = GetComponent<FirstPersonControlSharp>();
            val_51.且丆丅丏丌丗丛丄丌 = true;
            PGCompany.GamepadCoreController val_52 = PGCompany.GamepadCoreController.Instance;
            val_52.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  6);
        }
        
        val_79 = null;
        val_79 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = val_52.camera;
        this.丑与世丙与丗丛且丆();
    }
    protected void 丁丄丂丐丘世丄丂丕()
    {
        UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tableNGUIPrefab);
        if(val_1 != null)
        {
                this.丆且东三丑丝丏丝丘 = val_1.GetComponent<NetworkStartTableNGUIController>();
        }
        else
        {
                this.丆且东三丑丝丏丝丘 = val_1.GetComponent<NetworkStartTableNGUIController>();
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  9000f);
        val_1.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    internal override void 三丟丏东且与丗世专(bool 丂丘下万丈丘丅一丄 = False)
    {
        this.三丟丏东且与丗世专(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        goto typeof(OnlineModeController).__il2cppRuntimeField_178;
    }
    internal System.Collections.IEnumerator 下丝七上万丂不专与(bool 丂丘下万丈丘丅一丄 = False)
    {
        OnlineModeController.世世丂丑丞丌世丕丈 val_1 = new OnlineModeController.世世丂丑丞丌世丕丈();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        return (System.Collections.IEnumerator)val_1;
    }
    internal override void 东丞丒丗专业且专丒()
    {
        this.东丞丒丗专业且专丒();
        this.与丞丛丏且业七且业.Clear();
        this.丐丌与丛丈丏丘且丁.Clear();
        if(this.teamController == 0)
        {
                return;
        }
        
        this.teamController.丟丞丗上丂世丄与丞();
    }
    internal virtual void 丟业丐丗丐丅丑丙丒()
    {
        this.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  0);
        if(this.丟三丏丅世一丟丟上 == 0)
        {
                return;
        }
        
        this.丟三丏丅世一丟丟上.东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  0);
        this.丟三丏丅世一丟丟上.世丄丝丏丘不丂丏丒();
    }
    internal virtual void 丞丌丁丟丁丆丏下丈(int 万且丒下丕丝专丟上)
    {
        this.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  this.丞丏丕丑丞丑丏丏丄() + 万且丒下丕丝专丟上);
        if(this.丟三丏丅世一丟丟上 == 0)
        {
                return;
        }
        
        this.丟三丏丅世一丟丟上.东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  this.丞丏丕丑丞丑丏丏丄());
        this.丟三丏丅世一丟丟上.世丄丝丏丘不丂丏丒();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        int val_6;
        var val_7;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_8;
        var val_9;
        var val_10;
        val_6 = this;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if(丂丘下万丈丘丅一丄 != false)
        {
                if(this.丞丑丕与万丂丝丂丅 != null)
        {
            goto label_4;
        }
        
        }
        
        this.丒丅丘丕丗世不万丈.丙丕丒丕一丕与丆世();
        if(this.丈业丄丄丘丟专丈七 != null)
        {
                this.丈业丄丄丘丟专丈七.丟丞且丈丙丌丅丟专();
        }
        
        label_4:
        val_7 = null;
        val_7 = null;
        val_8 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_8 == null)
        {
                return;
        }
        
        val_8 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_8 == null)
        {
                val_8 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_8.丌不丅不丞东万专专();
        val_6 = val_1.HasValue.丙东专丂世丈丏丁丂();
        if(val_6 != 3)
        {
                return;
        }
        
        if(((-1317390440) & 1) == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_6 = GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七();
        var val_6 = 7;
        val_6 = val_6 & (~((MapEventWindowRate.丙丘丛丟丈丁丒业丄(丑丐丗三丒世丏东丅:  val_6)) >> 31));
        if(val_6 != 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_6 = GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七();
        MapEventWindowRate.丁三丑业专丈一丛丆(丑丐丗三丒世丏东丅:  val_6, 丙业与丙丗丝不丈东:  0);
    }
    internal virtual bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
                return (bool)val_1;
        }
        
        return System.String.op_Equality(a:  丏业丟一东丂东丘丛.roomName, b:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘());
    }
    private void 丗东与不丂丄丘丆丙()
    {
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(this.丟三丏丅世一丟丟上 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(OnlineModeController).__il2cppRuntimeField_2F8;
    }
    internal virtual 丕丁丕上与丅不丙丄 丑世丛丟东万与丁丞()
    {
        return (丕丁丕上与丅不丙丄)new 丕丁丕上与丅不丙丄();
    }
    internal virtual void 下丕丂业业丐丗与丁(丕丁丕上与丅不丙丄 与丆丌丂丟丛丘丑且)
    {
        var val_37;
        NetworkStartTable val_38;
        var val_39;
        var val_40;
        var val_41;
        object val_42;
        var val_43;
        var val_44;
        var val_45;
        bool val_46;
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.丞丏丕丑丞丑丏丏丄());
        与丆丌丂丟丛丘丑且.score = val_2;
        mem2[0] = val_2.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.七丒丘丏业丟丌丄七());
        与丆丌丂丟丛丘丑且.killCount = val_4;
        mem2[0] = val_4.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.丘不丄一丒丆丒丅万());
        与丆丌丂丟丛丘丑且.deathCount = val_6;
        mem2[0] = val_6.上万三丆专丏丒丗业;
        与丆丌丂丟丛丘丑且.丛丞丄不丈丛丙且丟 = val_6.七丄不丐丗三丝丑一 + 32;
        bool val_37 = ~this.丟三丏丅世一丟丟上.丟业上丝七丐丈丅丁();
        val_37 = val_37 & 1;
        与丆丌丂丟丛丘丑且.inMatch = val_37;
        与丆丌丂丟丛丘丑且.myEnemyKills = this.与丞丛丏且业七且业;
        与丆丌丂丟丛丘丑且.deathByEnemy = this.丐丌与丛丈丏丘且丁;
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_8;
        }
        
        if(this.丟三丏丅世一丟丟上 != 0)
        {
            goto label_12;
        }
        
        val_37 = 1;
        goto label_13;
        label_8:
        val_38 = this.丟三丏丅世一丟丟上;
        与丆丌丂丟丛丘丑且.isDead = this.丟三丏丅世一丟丟上.与丛下丐丆丞万万下;
        goto label_15;
        label_12:
        label_13:
        与丆丌丂丟丛丘丑且.isDead = (UnityEngine.Object.__il2cppRuntimeField_cctor_finished != 0) ? 1 : 0;
        val_38 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        与丆丌丂丟丛丘丑且.rounds = val_38.丁丝三丝一丂丕丑一();
        label_15:
        与丆丌丂丟丛丘丑且.myTeam = this.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝();
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_39 = null;
            val_39 = null;
            与丆丌丂丟丛丘丑且.siegeRoomStatus = SiegeController.三三万丆下一丗万丛 + 36;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                与丆丌丂丟丛丘丑且.roomName = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
            val_40 = null;
            if(GameConnect.丑丌丛丈丅丅与不业() == 31)
        {
                val_41 = null;
            val_42 = 1152921505066541704;
        }
        else
        {
                val_43 = null;
            val_42 = 1152921505066541328;
        }
        
            与丆丌丂丟丛丘丑且.timeEndMatch = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_42]);
        }
        
        val_44 = null;
        val_44 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(BattleRoyaleController.丑七不且上丗丁一世() != null)
        {
            goto label_60;
        }
        
        }
        else
        {
                UnityEngine.Vector3 val_25 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        }
        
        label_60:
        与丆丌丂丟丛丘丑且.playerPosition = val_25;
        mem2[0] = val_25.y;
        mem2[0] = val_25.z;
        UnityEngine.Quaternion val_26 = typeof(Player_move_c).__il2cppRuntimeField_378.rotation;
        与丆丌丂丟丛丘丑且.playerRotation = val_26.y;
        val_45 = 0f;
        与丆丌丂丟丛丘丑且.playerHealth = 丘七业丒丐世丂丅丒();
        if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_70;
        }
        
        }
        
        val_45 = 0f;
        与丆丌丂丟丛丘丑且.playerHealth = 丘七业丒丐世丂丅丒();
        label_70:
        与丆丌丂丟丛丘丑且.isArmorBonusPickedUp = typeof(Player_move_c).__il2cppRuntimeField_DE0.万七丏专东丐丂丏丑();
        float val_33 = typeof(Player_move_c).__il2cppRuntimeField_DE0.丈下丏丟丑丐丆三不();
        与丆丌丂丟丛丘丑且.playerArmor = val_33;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_38 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_38 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_46 = 1;
        }
        else
        {
                val_46 = 0;
        }
        
        与丆丌丂丟丛丘丑且.inBRGlider = ;
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
                return;
        }
        
        val_38 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
        val_38 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
        if(val_38 == 0)
        {
                return;
        }
        
        与丆丌丂丟丛丘丑且.carHealth = val_33;
    }
    public static void add_onDisconnect(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  OnlineModeController.丁丂丝丄不三丂业丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(OnlineModeController.丁丂丝丄不三丂业丐 != 1152921505197318152);
    
    }
    public static void remove_onDisconnect(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  OnlineModeController.丁丂丝丄不三丂业丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(OnlineModeController.丁丂丝丄不三丂业丐 != 1152921505197318152);
    
    }
    internal void 东丘丆丂丞丏丛丂一(bool 丝丐不丛丗七七丞一)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        OnlineModeController.一丙万丙丝与丌不万 = this.七丘专七丈上世七下;
        this.丞丑丕与万丂丝丂丅 = 0;
        this.丘丏七丑世丏丝丝一.SetActive(value:  true);
        val_8 = null;
        val_8 = null;
        BankController.丂七上业下丆丄东丄 = true;
        val_9 = null;
        val_9 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = false;
        if(this.丟三丏丅世一丟丟上 != 0)
        {
                this.丟三丏丅世一丟丟上.丒七丙与丙七丅丐东();
        }
        
        val_10 = null;
        val_10 = null;
        if(BonusController.丄丞丁丈与业上丞丟 != 0)
        {
                val_11 = null;
            val_11 = null;
            BonusController.丄丞丁丈与业上丞丟.东丞与且一丏丆丒丈();
        }
        
        if((BonusController.丄丞丁丈与业上丞丟 + 24) != 0)
        {
                this.丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  false);
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                UnityEngine.Object.Destroy(obj:  InGameGUI.丙丞专丌丁丞与不丐.gameObject);
        }
        
        UnityEngine.GameObject val_6 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "ChatViewer");
        if(val_6 != 0)
        {
                UnityEngine.Object.Destroy(obj:  val_6);
        }
        
        if(OnlineModeController.丁丂丝丄不三丂业丐 == null)
        {
                return;
        }
        
        OnlineModeController.丁丂丝丄不三丂业丐.Invoke();
    }
    internal override void 丁三丅东三丅丄丘丙()
    {
        var val_1;
        this.丁三丅东三丅丄丘丙();
        val_1 = null;
        val_1 = null;
        与丂丏丛丞丞丒丟丄.丞丘东不一丑专丄丟 = false;
    }
    internal virtual bool 丄一下丒七丝与与万()
    {
        return false;
    }
    private void 丈一丗丟丅丈丕丒丐()
    {
        NetworkStartTable val_20;
        float val_21;
        float val_22;
        float val_23;
        WeaponManager val_24;
        var val_25;
        var val_26;
        val_20 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_21 = val_1.x;
        val_22 = val_1.z;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        val_23 = val_2.y;
        UnityEngine.GameObject val_3 = 丅丒丗丑丒丙丛不丆.业丕丝丝万丕丛下三(丟丈一下东业一丝丆:  "NetworkTable", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_21, y = val_1.y, z = val_22}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_23, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0);
        if(val_3 != 0)
        {
                this.丟三丏丅世一丟丟上 = val_3.GetComponent<NetworkStartTable>();
            val_24 = 1152921505286238208;
            val_25 = null;
            val_25 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                val_25 = null;
        }
        
            WeaponManager.丟丗丄业丘丗业丗七.myTable = val_3;
            val_20 = this.丟三丏丅世一丟丟上;
            WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable = val_20;
            return;
        }
        
        val_26 = null;
        val_26 = null;
        val_24 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_24 == null)
        {
                val_26 = null;
        }
        
        WeaponManager.丟丗丄业丘丗业丗七.myTable = 0;
        WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable = 0;
        UnityEngine.Debug.LogError(message:  "CreateMyNetworkStartTable: tableInstance == null");
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "Forced quit because there is no room for Team Strike");
        val_20 = ???;
        val_24 = ???;
        val_21 = ???;
        val_22 = ???;
        val_23 = ???;
        goto typeof(OnlineModeController).__il2cppRuntimeField_248;
    }
    private void 丑丙丏丂丕丌与丌丘()
    {
        var val_14;
        var val_15;
        var val_16;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_17;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(与丂丏丛丞丞丒丟丄.上丆丘七丞且丄丘与 != false)
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() != true)
        {
                if(this.connection.万丑丙丄业一丑丏丆 == false)
        {
            goto label_14;
        }
        
        }
        
        }
        
        label_35:
        ExitGames.Client.Photon.Hashtable val_4 = new ExitGames.Client.Photon.Hashtable();
        val_15 = null;
        val_15 = null;
        val_4.Add(key:  GameConnect.下丝下万三丟下丕不, value:  "");
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        return;
        label_14:
        val_16 = null;
        val_16 = null;
        val_17 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_17 != null)
        {
                val_17 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_17 == null)
        {
                val_17 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_6 = val_17.丌不丅不丞东万专专();
            if(val_6.HasValue.丙东专丂世丈丏丁丂() == 4)
        {
                if(((-1315822040) & 1) != 0)
        {
            goto label_35;
        }
        
        }
        
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_9 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_9 == null)
        {
            goto label_35;
        }
        
        System.Nullable<System.TimeSpan> val_10 = val_9.丙世丑丅丒丑业与不();
        if(((-1315822064) & 1) == 0)
        {
            goto label_35;
        }
        
        System.Nullable<System.TimeSpan> val_11 = val_9.丙世丑丅丒丑业与不();
        if(val_11.HasValue.TotalHours < 1)
        {
            goto label_35;
        }
        
        string val_13 = val_9.业上丙丞丐丄丆丅七();
        goto label_35;
    }
    protected virtual void 丛丁丈丐丗丄丐下丌()
    {
        var val_7;
        var val_8;
        var val_9;
        string val_10;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if(this.connection.万丑丙丄业一丑丏丆 != true)
        {
                val_7 = BattleRoyaleController.丑七不且上丗丁一世();
            if((System.String.IsNullOrEmpty(value:  val_2.mySquadID)) != false)
        {
                return;
        }
        
        }
        
        ExitGames.Client.Photon.Hashtable val_4 = new ExitGames.Client.Photon.Hashtable();
        val_8 = null;
        val_8 = null;
        if(this.connection.万丑丙丄业一丑丏丆 != false)
        {
                val_9 = null;
            val_9 = null;
            val_10 = 1152921505323888672;
        }
        else
        {
                BattleRoyaleController val_5 = BattleRoyaleController.丑七不且上丗丁一世();
            val_10 = val_5.mySquadID;
        }
        
        val_4.Add(key:  GameConnect.与丈业东丂丘丅三丙, value:  mem[val_5.mySquadID]);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    protected override void Destroy()
    {
        var val_6;
        System.Action val_7;
        var val_8;
        System.Action<ExitGames.Client.Photon.Hashtable> val_9;
        var val_10;
        this.Destroy();
        val_6 = null;
        val_6 = null;
        val_8 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  System.Void OnlineModeController::OnConnectedToMaster()))) != null) && (null != null))
        {
                val_8 = null;
            val_7 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_7;
        System.Action<ExitGames.Client.Photon.Hashtable> val_4 = new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  typeof(OnlineModeController).__il2cppRuntimeField_340);
        if(((System.Delegate.Remove(source:  GameConnect.世丄丄与丌业丑丕丈, value:  null)) != null) && (null != null))
        {
                val_9 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_9;
        val_10 = null;
        val_10 = null;
        与丂丏丛丞丞丒丟丄.丞丘东不一丑专丄丟 = false;
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
        if(this.丈业丄丄丘丟专丈七 == null)
        {
                return;
        }
        
        this.丈业丄丄丘丟专丈七.丝丈万一业丁三丙丛(丗丕且丏万三万东丈:  new System.Action(object:  this, method:  System.Void OnlineModeController::丟三七丒东丙丏七一()));
    }
    internal bool 丆丏丟专业丏且三一()
    {
        if(this.丈业丄丄丘丟专丈七 == null)
        {
                return false;
        }
        
        if(this.丈业丄丄丘丟专丈七.丈丛七丐丏丘丕下丕() == 0)
        {
                return false;
        }
        
        if(this.丈业丄丄丘丟专丈七 != null)
        {
                return this.丈业丄丄丘丟专丈七.且丙丑丝三东东且不();
        }
        
        return this.丈业丄丄丘丟专丈七.且丙丑丝三东东且不();
    }
    internal bool 丝丌丁丐万丌丛且丑(System.Action 三世且世丂一丅丞丌)
    {
        var val_3;
        this.七丝丙丘丄丝丟丝专 = 三世且世丂一丅丞丌;
        if(this.丈业丄丄丘丟专丈七 != null)
        {
                val_3 = this.丈业丄丄丘丟专丈七.丙丄丟丆丂丒丆下万() ^ 1;
            return (bool)val_3 & 1;
        }
        
        val_3 = 0;
        return (bool)val_3 & 1;
    }
    internal void 丅业且丁不丆业东丛()
    {
        this.七丝丙丘丄丝丟丝专 = 0;
    }
    private void 丟三七丒东丙丏七一()
    {
        if(this.七丝丙丘丄丝丟丝专 == null)
        {
                return;
        }
        
        this.七丝丙丘丄丝丟丝专.Invoke();
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        this.上丗丙一丞上丌丑且.上三丝下丅一下三三();
        this.丘丁丒丌丐丘丕七与.丞丝不丟丈丗丌东丘();
        this.丗东与不丂丄丘丆丙();
        if(this.teamController != 0)
        {
                this.teamController.丗丘丞丏下丝丐丛丛();
        }
        
        if(this.丟三丏丅世一丟丟上 != 0)
        {
                this.丒丅丘丕丗世不万丈.丗丘丞丏下丝丐丛丛();
        }
        
        if(this.丈业丄丄丘丟专丈七 == null)
        {
                return;
        }
        
        this.丈业丄丄丘丟专丈七.上专丄丑专丑丘业丌(丆且东三丑丝丏丝丘:  this.丆且东三丑丝丏丝丘);
    }
    internal virtual bool 世七丌丟丞且丛七且()
    {
        return true;
    }
    protected override void 丛丒丒七丈丈下七丌(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_5;
        var val_6;
        this.丛丒丒七丈丈下七丌(东且丁丆丛丁丏丘且:  东且丁丆丛丁丏丘且);
        if(this.丟三丏丅世一丟丟上 != 0)
        {
                this.丟三丏丅世一丟丟上.丕丌丁丗上下丈丂一 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 168.ToArray();
        }
        
        val_5 = null;
        val_5 = null;
        if(null == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丘丑一东下下东丂七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 一丏丌丆东丟丗不与:  业且丌下丕上丕七丛());
    }
    protected virtual void 世丄丄与丌业丑丕丈(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        且下丙业丌与丕且丑 val_3;
        var val_4;
        string val_5;
        var val_6;
        string val_7;
        val_3 = this.丘丁丒丌丐丘丕七与;
        if(this.丘丁丒丌丐丘丕七与.丑丟业丛丐丅三下与 == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = GameConnect.丛上世丏丑世不丕三;
        if((业上上东丑东丞丗不.ContainsKey(key:  val_5)) != true)
        {
                val_6 = null;
            val_6 = null;
            val_7 = GameConnect.丁丈丅丑丘丂丄丟世;
            if((业上上东丑东丞丗不.ContainsKey(key:  val_7)) == false)
        {
                return;
        }
        
        }
        
        this.丘丁丒丌丐丘丕七与.且丗上丗丗上三专丑();
    }
    private void OnConnectedToMaster()
    {
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        this.丑丙丏丂丕丌与丌丘();
    }
    public OnlineModeController()
    {
        this.丌丏丒上丆丏下与世 = new System.Collections.Generic.List<NetworkStartTable>();
        this.与丞丛丏且业七且业 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        this.丐丌与丛丈丏丘且丁 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        this.丈业丄丄丘丟专丈七 = new 专与丁丏丄下东丏且();
    }

}
