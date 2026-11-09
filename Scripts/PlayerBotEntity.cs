using UnityEngine;
internal class PlayerBotEntity : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    public string scenarioAvatarID;
    public string[] scenarioWeaponSet;
    public float scenarioMaxHealth;
    public float scenarioDamageMultiplier;
    public float scenarioRespawnTime;
    internal UnityEngine.Transform eyesTransform;
    private bool 丝与丆丞东丘丈东丘;
    internal PlayerBotController 丒专丈丛下丒一丒丛;
    internal Player_move_c 丕丁丘丆万丄世专丛;
    internal PlayerBotEffects 业丐丞万东上下丒丘;
    internal PlayerBotWear 一丞一丅丌丞丙丆丑;
    internal PlayerBotMovement 丆七世丞丅下下三丏;
    internal PlayerBot.AIBotController 丗三七丕丏万丘丐与;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private string 丒丘上且专与业丂丄;
    private System.Action 业万丗专丕丆丕上丝;
    private int 丙丅丑丅一不丏与丒;
    internal bool 万丝一万丐且丌业丛;
    internal bool 丕丘丂业一专丗丝丙;
    internal float 丗丒丟丝丛业丌业丏;
    internal float 丘与丒丆丛丂专丌万;
    private float 丅丆丈一丟上丐丘东;
    private string currentWeaponNameDebug;
    private 丕丈丏丝丗下丟丅丂 丐专下三丙三世且万;
    public System.Collections.Generic.List<三丐七丞专丑一丟世> equippedWeapons;
    private 三丐七丞专丑一丟世 <丗丟上丙业丙上三丑>k__BackingField;
    private int 万七丙丙七三专且丈;
    private 三丐七丞专丑一丟世 <丈丏与丏丝业丒七丝>k__BackingField;
    private UnityEngine.Coroutine 世丐丗丑丌东与丈丞;
    private float 丐丛丏丁上丄丆世丘;
    private float 丛三丗丏不丌丐万丙;
    private float 丙丒丈丄丝丗丂下丛;
    private UnityEngine.Coroutine 丑丅不三丕七丂万丙;
    
    // Properties
    internal float 丕丟一东三丏丝丞丞 { get; }
    internal float 万三丒与三上业丆三 { get; }
    internal float 世丄丂专专丂丌丝丙 { get; }
    internal 三丐七丞专丑一丟世 三七丐丟万上与丁丆 { get; set; }
    internal WeaponSounds 不万丘业专不三丅与 { get; }
    internal 三丐七丞专丑一丟世 丟不丒不丙丞三丟下 { get; set; }
    internal bool 业丝丆丙东丙丕与七 { get; }
    internal bool 丕上丂丙上专丄专丗 { get; }
    internal bool 七不且专丈丑丕丅上 { get; }
    internal bool 且丂一丁丆丒与丁业 { get; }
    private bool 丄丁丙东万丅不一丄 { get; }
    internal float 不万丈丅一上七丒不 { get; }
    internal bool 七丝且三东丂丏不丌 { get; }
    internal bool 且丂丌七丌下丂丆丝 { get; }
    
    // Methods
    internal PlayerBotEntity()
    {
        this.scenarioMaxHealth = 0f;
        this.scenarioDamageMultiplier = 1f;
        this.scenarioRespawnTime = 3f;
        this.丗丒丟丝丛业丌业丏 = 3f;
        this.equippedWeapons = new System.Collections.Generic.List<三丐七丞专丑一丟世>();
        this.万七丙丙七三专且丈 = 1;
        this.丛三丗丏不丌丐万丙 = 0.1f;
        Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
        val_2.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PlayerBotEntity::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_3;
        if((丞世不丒下上上丝丑 & 255) == 89)
        {
                this.下丐丟丗丛三丛东丌(下且与丐上丟七丑丏:  System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]));
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal float 东万丝丞丄丐丕丌万()
    {
        if(this.丕丁丘丆万丄世专丛 == 0)
        {
                return 0f;
        }
        
        if(this.丕丁丘丆万丄世专丛.mySkinName.playerAnimation != null)
        {
                return this.丕丁丘丆万丄世专丛.mySkinName.playerAnimation.丕专丅东下丙丙丌万();
        }
        
        return this.丕丁丘丆万丄世专丛.mySkinName.playerAnimation.丕专丅东下丙丙丌万();
    }
    internal void 丏丆三丌丁丈丄万东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.业万丗专丕丆丕上丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业万丗专丕丆丕上丝 != 1152921538654313832);
    
    }
    internal void 丛下业丅丟东丁上七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.业万丗专丕丆丕上丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业万丗专丕丆丕上丝 != 1152921538654450408);
    
    }
    private void Awake()
    {
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        this.业丐丞万东上下丒丘 = this.GetComponent<PlayerBotEffects>();
        this.一丞一丅丌丞丙丆丑 = this.GetComponent<PlayerBotWear>();
        this.丆七世丞丅下下三丏 = this.GetComponent<PlayerBotMovement>();
        this.丗三七丕丏万丘丐与 = this.GetComponent<PlayerBot.AIBotController>();
    }
    internal void 丕丁丘丕与世丕专丈(string 丂上丕七丒东东且丙)
    {
        if((System.String.IsNullOrEmpty(value:  丂上丕七丒东东且丙)) == true)
        {
                return;
        }
        
        this.丒丘上且专与业丂丄 = 丂上丕七丒东东且丙;
        this.丐专下三丙三世且万 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.丒丘上且专与业丂丄];
    }
    private void Update()
    {
        if(this.丝与丆丞东丘丈东丘 == false)
        {
                return;
        }
        
        this.丞专万丒丆丙专丒丛();
        if(this.万丝一万丐且丌业丛 != false)
        {
                return;
        }
        
        this.且下丘丛下丅丗丗丞();
    }
    internal void 丙下且一丒丛丞丏丆(Player_move_c 丕丁丘丆万丄世专丛)
    {
        this.丕丁丘丆万丄世专丛 = 丕丁丘丆万丄世专丛;
        this.丞丑丕丐万丆丅三丂();
    }
    private void 丂丕下与丄业丘业且(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, PhotonTargets 丞下万上三丘上与专, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.丕丁丘丆万丄世专丛 == 0)
        {
                return;
        }
        
        this.丕丁丘丆万丄世专丛.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 丞下万上三丘上与专:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    private void 丂丕下与丄业丘业且(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, 与丅丕丈丘东丝世丟 丞下万上三丘上与专, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.丕丁丘丆万丄世专丛 == 0)
        {
                return;
        }
        
        this.丕丁丘丆万丄世专丛.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 万丌万丅专丞业丈万:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    public void Initialize()
    {
        var val_84;
        int val_85;
        var val_86;
        三丐七丞专丑一丟世 val_87;
        System.String[] val_88;
        var val_89;
        System.String[] val_90;
        System.String[] val_91;
        var val_92;
        var val_93;
        var val_94;
        var val_95;
        var val_96;
        this.丒专丈丛下丒一丒丛 = this.GetComponent<PlayerBotController>();
        if(val_1.丗丈东丕不丘三丞业.isScenarioBot == false)
        {
            goto label_3;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_6;
        }
        
        丗一丂丈丅三丌东丅 val_4 = 丄与东丕丑丗丌七上.丑七不且上丗丁一世().丐下下丅与上东丙丑(丈丟且丐上不世专丁:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅丑丗丙三丄丐丛丂);
        if((val_4.丆丑丛东丄丕丑专丗() == null) || (val_4.丆丑丛东丄丕丑专丗().Count < 1))
        {
            goto label_16;
        }
        
        if(val_4 == null)
        {
            goto label_17;
        }
        
        val_84 = val_4.丆丑丛东丄丕丑专丗();
        goto label_18;
        label_6:
        七不丆丘三与丛上业 val_13 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().丏丘下丞丘不丑万丏().Item[(GameConnect.丅丟下专不丁一丈七() != true) ? "FortDefence" : "FortAttack"];
        if(val_13 != null)
        {
                this.scenarioMaxHealth = val_13.三丏丟不丆丅丞不丛();
            this.scenarioDamageMultiplier = val_13.与丟丞丗丁丄丅业丄();
        }
        else
        {
                this.scenarioMaxHealth = val_13.三丏丟不丆丅丞不丛();
            this.scenarioDamageMultiplier = val_13.与丟丞丗丁丄丅业丄();
        }
        
        float val_18 = val_13.下丅丈东丆丄业世丝();
        goto label_25;
        label_17:
        val_84 = 0.丆丑丛东丄丕丑专丗();
        label_18:
        val_85 = UnityEngine.Mathf.Min(a:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅且丁与与丗丛七丆, b:  val_4.丆丑丛东丄丕丑专丗().Count);
        this.scenarioMaxHealth = val_84.Item[val_85];
        label_16:
        if((val_4.丁丙丅不丝丐丛丆丁() != null) && (val_4.丁丙丅不丝丐丛丆丁().Count >= 1))
        {
                if(val_4 != null)
        {
                val_86 = val_4.丁丙丅不丝丐丛丆丁();
        }
        else
        {
                val_86 = 0.丁丙丅不丝丐丛丆丁();
        }
        
            val_85 = val_4.丁丙丅不丝丐丛丆丁().Count;
            this.scenarioDamageMultiplier = val_86.Item[UnityEngine.Mathf.Min(a:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅且丁与与丗丛七丆, b:  val_85)];
        }
        
        label_25:
        this.scenarioRespawnTime = val_4.丙丈丗丌丘三丄业且();
        label_3:
        val_87 = 1152921505066536960;
        if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗丆东丗丕上丆上丂() != null)
        {
                this.scenarioAvatarID = val_35.avatarID;
            this.scenarioWeaponSet = val_35.weaponSet;
        }
        
        }
        
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.不与丌丛丌且三丞丝() != null)
        {
                this.scenarioAvatarID = val_37.avatarID;
            this.scenarioWeaponSet = val_37.weaponSet;
        }
        
        }
        
        if(GameConnect.业丗与丈丁东下一丛() == false)
        {
            goto label_58;
        }
        
        System.Collections.Generic.List<System.Int32> val_40 = PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丙世丁丘丘丆丗丅丐();
        if(val_40 == null)
        {
            goto label_58;
        }
        
        int val_41 = val_40.Count;
        val_88 = new string[0];
        this.scenarioWeaponSet = val_88;
        val_85 = 1152921516995559328;
        val_87 = 0;
        goto label_59;
        label_67:
        string val_44 = System.String.Format(format:  "Weapon{0}", arg0:  val_40.Item[0]);
        if(this.scenarioWeaponSet == null)
        {
            goto label_60;
        }
        
        if(val_44 != null)
        {
            goto label_61;
        }
        
        goto label_64;
        label_60:
        if(val_44 == null)
        {
            goto label_64;
        }
        
        label_61:
        label_64:
        val_89 = 0;
        this.scenarioWeaponSet[val_89] = val_44;
        val_88 = this.scenarioWeaponSet;
        val_87 = 1;
        label_59:
        if(val_87 < this.scenarioWeaponSet.Length)
        {
            goto label_67;
        }
        
        label_58:
        val_90 = this.scenarioWeaponSet;
        if((val_90 == null) || (this.scenarioWeaponSet.Length == 0))
        {
            goto label_69;
        }
        
        val_91 = 1152921538655866640;
        val_85 = 0;
        goto label_70;
        label_75:
        三丐七丞专丑一丟世 val_45 = null;
        val_87 = val_45;
        val_45 = new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  this.scenarioWeaponSet[0]);
        this.equippedWeapons.Add(item:  val_45);
        val_90 = this.scenarioWeaponSet;
        val_85 = 1;
        label_70:
        if(val_85 < this.scenarioWeaponSet.Length)
        {
            goto label_75;
        }
        
        goto label_92;
        label_69:
        System.Collections.Generic.List<System.String> val_48 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世().七丛丕三与丙丂丗丞(丑万世丂专丈丌业且:  this.丒专丈丛下丒一丒丛.丌丕下东七丗丛丞下.丄丛丄丟不世丙东丟());
        val_91 = 1152921516934571616;
        if(val_48.Count == 0)
        {
            goto label_83;
        }
        
        val_89 = 1152921505246568448;
        val_87 = 0;
        goto label_84;
        label_88:
        三丐七丞专丑一丟世 val_51 = null;
        val_85 = val_51;
        val_51 = new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  val_48.Item[0]);
        this.equippedWeapons.Add(item:  val_51);
        val_87 = 1;
        label_84:
        if(val_87 < val_48.Count)
        {
            goto label_88;
        }
        
        goto label_92;
        label_83:
        val_91 = 1152921504622075904;
        val_85 = 1152921505246568448;
        val_89 = 1152921538655866640;
        var val_85 = 6;
        do
        {
            三丐七丞专丑一丟世 val_55 = null;
            val_87 = val_55;
            val_55 = new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  "Weapon" + UnityEngine.Random.Range(min:  1, max:  232)(UnityEngine.Random.Range(min:  1, max:  232)));
            this.equippedWeapons.Add(item:  val_55);
            val_85 = val_85 - 1;
        }
        while(val_85 != 0);
        
        if((this.丁丛丏业东丗丘丕丛(七丆丒与丗丌丄且丂:  2)) == null)
        {
                三丐七丞专丑一丟世 val_57 = null;
            val_87 = val_57;
            val_57 = new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  "Weapon9");
            this.equippedWeapons.set_Item(index:  3, value:  val_57);
        }
        
        label_92:
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 == false)
        {
                return;
        }
        
        this.丒专丈丛下丒一丒丛.丌丕下东七丗丛丞下.丕丂丆且下丐丂丈专(丁丆丙丝一丗专一业:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().三三丐上丐上丐丐丅(), 丞丆丆丘世丁丌丘丗:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丞专丁丒三丄丁丈丁());
        this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丄与丒丏丘七上丕丒 = PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丑丗专丅丐丕丙世丕();
        this.丒专丈丛下丒一丒丛.丌丕下东七丗丛丞下.丗丑丒下丗业丏不不(不丏东三丕东且丒世:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().专丟一且丘东丟丘丛());
        val_85 = 1152921505245184000;
        val_92 = 0;
        goto label_109;
        label_126:
        if((丑东丘丙丝专万丟上.专丈丝丕丁下专丟丌(丞专东丏丈下丛丞且:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三[0])) == true)
        {
            goto label_117;
        }
        
        string val_67 = 丑东丘丙丝专万丟上.七丘不丘丛丐丗丏且(丞世不丒下上上丝丑:  0);
        if((System.String.IsNullOrEmpty(value:  val_67)) == true)
        {
            goto label_117;
        }
        
        val_91 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三;
        if(val_91 == null)
        {
            goto label_118;
        }
        
        if(val_67 != null)
        {
            goto label_119;
        }
        
        goto label_122;
        label_118:
        if(val_67 == null)
        {
            goto label_122;
        }
        
        label_119:
        label_122:
        val_91[0] = val_67;
        label_117:
        val_92 = 1;
        label_109:
        if(val_92 < this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三.Length)
        {
            goto label_126;
        }
        
        val_93 = 0;
        goto label_127;
        label_143:
        if((丑东丘丙丝专万丟上.专丈丝丕丁下专丟丌(丞专东丏丈下丛丞且:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东[0])) == true)
        {
            goto label_135;
        }
        
        string val_70 = 丑东丘丙丝专万丟上.七丘不丘丛丐丗丏且(丞世不丒下上上丝丑:  0);
        if((System.String.IsNullOrEmpty(value:  val_70)) == true)
        {
            goto label_135;
        }
        
        val_91 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东;
        if(val_91 == null)
        {
            goto label_136;
        }
        
        if(val_70 != null)
        {
            goto label_137;
        }
        
        goto label_140;
        label_136:
        if(val_70 == null)
        {
            goto label_140;
        }
        
        label_137:
        label_140:
        val_91[0] = val_70;
        label_135:
        val_93 = 1;
        label_127:
        val_87 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东;
        if(val_93 < this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东.Length)
        {
            goto label_143;
        }
        
        UnityEngine.SceneManagement.Scene val_72 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((val_72.m_Handle.name.Equals(value:  "knife2")) == false)
        {
            goto label_145;
        }
        
        val_94 = 0;
        goto label_146;
        label_153:
        val_85 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三;
        val_94 = 1;
        val_85[0] = val_85[2];
        label_146:
        if(val_94 < this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三.Length)
        {
            goto label_153;
        }
        
        val_87 = 0;
        goto label_154;
        label_161:
        val_85 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东;
        val_87 = 1;
        val_85[0] = val_85[2];
        label_154:
        if(val_87 < this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东.Length)
        {
            goto label_161;
        }
        
        label_145:
        UnityEngine.SceneManagement.Scene val_75 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_95 = 0;
        if((val_75.m_Handle.name.Equals(value:  "COLAPSED_CITY_sniper")) == true)
        {
            goto label_165;
        }
        
        UnityEngine.SceneManagement.Scene val_78 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_95 = 0;
        if((val_78.m_Handle.name.Equals(value:  "islands_sniper")) == true)
        {
            goto label_165;
        }
        
        UnityEngine.SceneManagement.Scene val_81 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_95 = 0;
        if((val_81.m_Handle.name.Equals(value:  "Sniper")) == false)
        {
            goto label_167;
        }
        
        label_165:
        val_96 = 0;
        goto label_168;
        label_175:
        val_85 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三;
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三.Length <= 4)
        {
                val_95 = 0;
        }
        
        string val_90 = val_85[4];
        if((val_90 != null) && (val_90 == null))
        {
                val_95 = 0;
        }
        
        if(val_96 >= this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三.Length)
        {
                val_95 = 0;
        }
        
        val_96 = 1;
        val_85[0] = val_90;
        label_168:
        if(val_96 < this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三.Length)
        {
            goto label_175;
        }
        
        val_87 = 0;
        goto label_176;
        label_183:
        val_85 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东;
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东.Length <= 4)
        {
                val_95 = 0;
        }
        
        string val_91 = val_85[4];
        if((val_91 != null) && (val_91 == null))
        {
                val_95 = 0;
        }
        
        if(val_87 >= this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东.Length)
        {
                val_95 = 0;
        }
        
        val_87 = 1;
        val_85[0] = val_91;
        label_176:
        if(val_87 < this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东.Length)
        {
            goto label_183;
        }
        
        label_167:
        this.丞上丄丄上丞丘下丁(丈丁丄丘丛世七丙丝:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丌丝下丄业一丄不三, 丙丟万世专丟丞丁丙:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世东丏三三丑丁且东);
        this.丕丁丘丕与世丕专丈(丂上丕七丒东东且丙:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丐专下三丙三世且万);
    }
    public void SetCharacterWeapons()
    {
        var val_12;
        var val_13;
        this.equippedWeapons.Clear();
        this.equippedWeapons = new System.Collections.Generic.List<三丐七丞专丑一丟世>();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.丛丈丒七丈丑丑丅丏())) != false)
        {
                string[] val_4 = new string[1];
            val_12 = this;
            this.scenarioWeaponSet = val_4;
            val_4[0] = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.世丏专不万丏世丌丞();
        }
        else
        {
                string[] val_6 = new string[2];
            val_12 = this;
            this.scenarioWeaponSet = val_6;
            val_6[0] = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.世丏专不万丏世丌丞();
            string val_8 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.丛丈丒七丈丑丑丅丏();
            if(val_8 != null)
        {
                string val_12 = val_6[4];
        }
        
            mem[1152921538658164648] = val_8;
        }
        
        val_13 = 0;
        goto label_24;
        label_29:
        val_8.Add(item:  new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  val_6.Length + 32));
        val_13 = 1;
        label_24:
        if(val_13 < val_6.Length)
        {
            goto label_29;
        }
        
        this.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  this.equippedWeapons.Item[0]);
        this.<丈丏与丏丝业丒七丝>k__BackingField = this.equippedWeapons.Item[0];
    }
    private void 丞丑丕丐万丆丅三丂()
    {
        int val_19;
        UnityEngine.GameObject val_20;
        if(this.丄丈丑丐丆丞丘与丗.isMine != false)
        {
                this.丁七东丂丟与且且丗(专丞上七七且丝七丗:  0);
            object[] val_2 = new object[2];
            val_2[0] = this.专一丟丏且丆丕丝七();
            val_2[1] = this.丗丗万丗丛不丒丁三();
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
            object[] val_5 = new object[1];
            val_5[0] = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丞丞下东且丗丄丒丏;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  81, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_5);
        }
        
        val_19 = 1152921538658294384;
        if(this.equippedWeapons.Count >= 1)
        {
                val_19 = UnityEngine.Random.Range(min:  0, max:  this.equippedWeapons.Count);
            this.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  this.equippedWeapons.Item[val_19]);
        }
        
        if(this.丄丈丑丐丆丞丘与丗.isMine != false)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != true)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 == false)
        {
            goto label_28;
        }
        
        }
        
            if((System.String.IsNullOrEmpty(value:  this.scenarioAvatarID)) != true)
        {
                object[] val_12 = new object[1];
            val_19 = this.scenarioAvatarID;
            val_12[0] = val_19;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  174, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
        }
        
        }
        
        label_28:
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != false)
        {
                UnityEngine.Object val_13 = UnityEngine.Resources.Load(path:  "Bots/ScenarioBots/BotHealthbar");
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.identity;
            if(val_13 != null)
        {
                var val_16 = (null == null) ? (val_13) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
            val_19 = this.丕丁丘丆万丄世专丛.myPlayerTransform;
            UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_20, position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, rotation:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w}).transform.SetParent(parent:  val_19, worldPositionStays:  false);
        }
        
        this.丝与丆丞东丘丈东丘 = true;
    }
    internal void 丐不专世丟七下丛丗(string 丐丒丈丌与丈丏不上)
    {
        this.scenarioAvatarID = 丐丒丈丌与丈丏不上;
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != true)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 == false)
        {
                return;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.scenarioAvatarID)) != false)
        {
                return;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = this.scenarioAvatarID;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  174, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void 丞上丄丄上丞丘下丁(string[] 丈丁丄丘丛世七丙丝, string[] 丙丟万世专丟丞丁丙)
    {
        object val_6;
        object val_7;
        var val_8;
        int val_9;
        System.Collections.Generic.List<三丐七丞专丑一丟世> val_10;
        val_6 = 丙丟万世专丟丞丁丙;
        val_7 = 丈丁丄丘丛世七丙丝;
        val_8 = 0;
        goto label_1;
        label_10:
        if(val_8 >= 丈丁丄丘丛世七丙丝.Length)
        {
            goto label_5;
        }
        
        val_9 = 丙丟万世专丟丞丁丙.Length;
        if(val_8 >= val_9)
        {
            goto label_5;
        }
        
        if(val_8 >= 丈丁丄丘丛世七丙丝.Length)
        {
                val_9 = 丙丟万世专丟丞丁丙.Length;
        }
        
        this.equippedWeapons.set_Item(index:  0, value:  this.一丆丙丐上丒与丒专(丈丁丄丘丛世七丙丝:  val_7[0], 丙丟万世专丟丞丁丙:  val_6[0]));
        val_8 = 1;
        label_1:
        val_10 = this.equippedWeapons;
        if(val_8 < val_10.Count)
        {
            goto label_10;
        }
        
        return;
        label_5:
        object[] val_3 = new object[6];
        val_3[0] = "Что то пошло не так эквипед ";
        val_10 = 1152921504622075904;
        val_3[1] = this.equippedWeapons.Count;
        val_3[2] = " weaponId ";
        val_3[3] = 丈丁丄丘丛世七丙丝.Length;
        val_7 = " weaponAltId ";
        val_3[4] = val_7;
        val_3[5] = 丙丟万世专丟丞丁丙.Length;
        val_6 = +val_3;
        UnityEngine.Debug.LogError(message:  val_6);
    }
    private 三丐七丞专丑一丟世 一丆丙丐上丒与丒专(string 丈丁丄丘丛世七丙丝, string 丙丟万世专丟丞丁丙)
    {
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丈丁丄丘丛世七丙丝 = 丈丁丄丘丛世七丙丝)) == false)
        {
                return (三丐七丞专丑一丟世)new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  (val_6 != true) ? 丙丟万世专丟丞丁丙 : (丈丁丄丘丛世七丙丝));
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丙丟万世专丟丞丁丙)) == false)
        {
                return (三丐七丞专丑一丟世)new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  (val_6 != true) ? 丙丟万世专丟丞丁丙 : (丈丁丄丘丛世七丙丝));
        }
        
        var val_6 = ((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丈丁丄丘丛世七丙丝)) == 0) ? 1 : 0;
        val_6 = val_6 | (WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丈丁丄丘丛世七丙丝));
        return (三丐七丞专丑一丟世)new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  (val_6 != true) ? 丙丟万世专丟丞丁丙 : (丈丁丄丘丛世七丙丝));
    }
    internal bool 七与丆一丏下丏七不(UnityEngine.Ray 不万专丐世丒丆丆下, out UnityEngine.RaycastHit 丂七丑世丏丐丅不丌, float 丏上万丅丏一不不丕, int 丄丏且业丏丟且丂丁)
    {
        Player_move_c val_13;
        var val_14;
        float val_12 = 丏上万丅丏一不不丕;
        val_13 = this.丕丁丘丆万丄世专丛;
        if(val_13 != 0)
        {
            goto label_3;
        }
        
        label_23:
        val_14 = 0;
        丂七丑世丏丐丅不丌.m_Collider = 0;
        丂七丑世丏丐丅不丌.m_UV.x = 0f;
        丂七丑世丏丐丅不丌.m_UV.y = 0f;
        丂七丑世丏丐丅不丌.m_Point.x = 0f;
        丂七丑世丏丐丅不丌.m_Point.y = 0f;
        丂七丑世丏丐丅不丌.m_Point.z = 0f;
        丂七丑世丏丐丅不丌.m_Normal.x = 0f;
        丂七丑世丏丐丅不丌.m_Normal.y = 0f;
        丂七丑世丏丐丅不丌.m_Normal.z = 0f;
        丂七丑世丏丐丅不丌.m_FaceID = 0;
        丂七丑世丏丐丅不丌.m_Distance = 0f;
        return (bool)val_14;
        label_3:
        var val_13 = 0;
        label_22:
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 不万专丐世丒丆丆下.m_Origin.x}, m_Direction = new UnityEngine.Vector3() {y = 不万专丐世丒丆丆下.m_Direction.y}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_12, layerMask:  丄丏且业丏丟且丂丁)) == false)
        {
            goto label_5;
        }
        
        丅丙上七上一丐不下 val_3 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(0 == 0)
        {
            goto label_8;
        }
        
        if((0.GetComponent<Rocket>()) != 0)
        {
            goto label_14;
        }
        
        label_8:
        val_13 = this.丕丁丘丆万丄世专丛;
        if(val_3 != this.丕丁丘丆万丄世专丛.丂七一业下丈业丕丒)
        {
                if((val_3 == null) || ((val_3.IsEnemyTo(专丞上七七且丝七丗:  this.丕丁丘丆万丄世专丛)) == true))
        {
            goto label_18;
        }
        
        }
        
        label_14:
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_12, y = V1.16B, z = V2.16B});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 不万专丐世丒丆丆下.m_Origin.x, y = ???, z = ???}, d:  0.01f);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if(val_13 > 3)
        {
            goto label_23;
        }
        
        val_12 = val_12 - (val_8.x + 0.01f);
        val_13 = val_13 + 1;
        if(val_12 > 0f)
        {
            goto label_22;
        }
        
        goto label_23;
        label_18:
        val_14 = 1;
        goto label_24;
        label_5:
        val_14 = 0;
        label_24:
        丂七丑世丏丐丅不丌.m_Distance = 0f;
        丂七丑世丏丐丅不丌.m_UV.x = 0f;
        丂七丑世丏丐丅不丌.m_UV.y = 0f;
        丂七丑世丏丐丅不丌.m_Collider = 0;
        丂七丑世丏丐丅不丌.m_Normal.y = 0f;
        丂七丑世丏丐丅不丌.m_Normal.z = 0f;
        丂七丑世丏丐丅不丌.m_FaceID = 0;
        丂七丑世丏丐丅不丌.m_Distance = 0f;
        丂七丑世丏丐丅不丌.m_Point.x = 0f;
        丂七丑世丏丐丅不丌.m_Point.y = 0f;
        丂七丑世丏丐丅不丌.m_Point.z = 0f;
        丂七丑世丏丐丅不丌.m_Normal.x = 0f;
        return (bool)val_14;
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        PhotonView val_13 = this.丄丈丑丐丆丞丘与丗;
        if(val_13.isMine == false)
        {
                return;
        }
        
        if((this.<丗丟上丙业丙上三丑>k__BackingField) != null)
        {
                object[] val_2 = new object[1];
            val_2[0] = this.equippedWeapons.IndexOf(item:  this.<丗丟上丙业丙上三丑>k__BackingField);
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  89, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
            object[] val_4 = new object[3];
            val_4[0] = this.<丗丟上丙业丙上三丑>k__BackingField.三与丛丑且丐丈业丌();
            val_4[1] = this.<丗丟上丙业丙上三丑>k__BackingField.丌上丗丕不七世丅丁().三丙且下一专上东与();
            val_4[2] = 0;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  89, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_4);
        }
        
        this.丁七东丂丟与且且丗(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        object[] val_8 = new object[2];
        val_8[0] = this.丕丁丘丆万丄世专丛.丘七业丒丐世丂丅丒();
        val_8[1] = this.丕丁丘丆万丄世专丛.三丕丘下业丑丞下丘;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_8);
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != true)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 == false)
        {
            goto label_38;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.scenarioAvatarID)) != true)
        {
                object[] val_11 = new object[1];
            val_11[0] = this.scenarioAvatarID;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  174, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_11);
        }
        
        label_38:
        object[] val_12 = new object[1];
        val_13 = val_12;
        val_13[0] = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丞丞下东且丗丄丒丏;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  81, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_12);
    }
    internal void 丒丕丒东七丛丑丄一(Rilisoft.专与丏丞三与不不丆 丁丅丈丌丟世丗丗丟)
    {
        System.Object[] val_12;
        var val_13;
        var val_14;
        if(this.丕丁丘丆万丄世专丛 == 0)
        {
                return;
        }
        
        if(丁丅丈丌丟世丗丗丟 > 16)
        {
                return;
        }
        
        var val_12 = 1;
        val_12 = val_12 << 丁丅丈丌丟世丗丗丟;
        if((val_12 & 14338) != 0)
        {
            goto label_5;
        }
        
        val_12 = val_12 & 114692;
        if(val_12 == 0)
        {
            goto label_6;
        }
        
        if(this.丕丁丘丆万丄世专丛.丘七业丒丐世丂丅丒() > 0f)
        {
                object[] val_4 = new object[2];
            val_4[0] = this.丗丗万丗丛不丒丁三();
            val_4[1] = 2;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  124, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
        }
        
        val_12 = new object[1];
        val_13 = null;
        goto label_16;
        label_5:
        if(this.丕丁丘丆万丄世专丛.丘七业丒丐世丂丅丒() > 0f)
        {
                object[] val_9 = new object[2];
            val_9[0] = this.专一丟丏且丆丕丝七();
            val_9[1] = 4;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  118, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_9);
        }
        
        val_14 = 1152921504622075904;
        val_12 = new object[1];
        goto label_26;
        label_6:
        if(丁丅丈丌丟世丗丗丟 != 0)
        {
                return;
        }
        
        object[] val_11 = new object[1];
        val_14 = 1152921504622075904;
        val_12 = val_11;
        label_26:
        label_16:
        val_12[0] = 0;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  93, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_11);
    }
    internal void 上下东丆丑丂丟丟一(Player_move_c 专丞上七七且丝七丗, string 丝三丛且丘不丌丙下, int 世丙丝万丌丅且七且)
    {
        PlayerBotInstance val_12;
        if(世丙丝万丌丅且七且 <= 3)
        {
            goto label_1;
        }
        
        int val_1 = 世丙丝万丌丅且七且 - 9;
        val_1 = val_1 >> 1;
        if(val_1 > 7)
        {
            goto label_2;
        }
        
        val_12 = mem[106021440 + (((世丙丝万丌丅且七且 - 9) >> 1)) << 2];
        val_12 = 106021440 + (((世丙丝万丌丅且七且 - 9) >> 1)) << 2;
        goto label_4;
        label_1:
        var val_3 = (世丙丝万丌丅且七且 == 2) ? 10 : ((世丙丝万丌丅且七且 == 3) ? 61 : 9);
        goto label_4;
        label_2:
        val_12 = 9;
        label_4:
        this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  9, 专上丝且丂世丛丝丒:  1f);
        if(GameConnect.丘丐丅丌上与丒丞万() == true)
        {
                return;
        }
        
        val_12 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业;
        val_12.一丆一专丆丛专丘丌();
        if(世丙丝万丌丅且七且 != 15)
        {
                this.业三丞下丙丄且下且();
        }
        
        if(GameConnect.丅业东业丞七上丞丑() != true)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() != true)
        {
                if(GameConnect.业丗与丈丁东下一丛() == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.丕丁丘丆万丄世专丛.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝() == 1)
        {
                object[] val_9 = new object[1];
            val_12 = 1;
            val_9[0] = val_12;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  45, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_9);
        }
        
        if(this.丕丁丘丆万丄世专丛.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝() != 2)
        {
                return;
        }
        
        object[] val_11 = new object[1];
        val_12 = 2;
        val_11[0] = val_12;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  45, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_11);
    }
    internal void 业三丞下丙丄且下且()
    {
        PlayerBotInstance val_5;
        var val_6;
        if(GameConnect.与丂丝丟丟三丑丝万() == true)
        {
                return;
        }
        
        int val_2 = this.丙丅丑丅一不丏与丒 + 1;
        this.丙丅丑丅一不丏与丒 = val_2;
        if(val_2 < 2)
        {
                return;
        }
        
        if((this.丙丅丑丅一不丏与丒 - 1) > 8)
        {
            goto label_5;
        }
        
        var val_5 = 106021300;
        val_5 = (106021300 + ((this.丙丅丑丅一不丏与丒 - 1)) << 2) + val_5;
        goto (106021300 + ((this.丙丅丑丅一不丏与丒 - 1)) << 2 + 106021300);
        label_5:
        if(this.丙丅丑丅一不丏与丒 == 19)
        {
            goto label_9;
        }
        
        if(this.丙丅丑丅一不丏与丒 != 49)
        {
            goto label_10;
        }
        
        val_5 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业;
        val_6 = 51;
        goto label_28;
        label_9:
        val_5 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业;
        val_6 = 50;
        label_28:
        val_5.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  50, 专上丝且丂世丛丝丒:  1f);
        label_10:
        object[] val_4 = new object[1];
        val_4[0] = this.丙丅丑丅一不丏与丒;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  95, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
    }
    internal float 专一丟丏且丆丕丝七()
    {
        下丐专一下不不上与 val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_3 = this;
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != false)
        {
                return 1.152922E+18f;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_3 = 1152921505111851008;
            val_4 = null;
            val_4 = null;
            val_5 = 1152921505111855608;
            return 1.152922E+18f;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_3 = 1152921505037303808;
            val_6 = null;
            val_6 = null;
            val_5 = 1152921505037308088;
            return 1.152922E+18f;
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅下万丏丘东丄丌万 != false)
        {
                val_3 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一;
            if(val_3 != null)
        {
                return 1.152922E+18f;
        }
        
            return 1.152922E+18f;
        }
        
        val_3 = 1152921505037303808;
        val_7 = null;
        val_7 = null;
        val_5 = 1152921505037308056;
        return 1.152922E+18f;
    }
    internal float 丗丗万丗丛不丒丁三()
    {
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot == true)
        {
                return (float)(float)BalanceController.丈一三七丟丐丘丘丗();
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅下万丏丘东丄丌万 != false)
        {
                this = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一;
            if(this != null)
        {
                return (float)(float)BalanceController.丈一三七丟丐丘丘丗();
        }
        
            return (float)(float)BalanceController.丈一三七丟丐丘丘丗();
        }
        
        return (float)(float)BalanceController.丈一三七丟丐丘丘丗();
    }
    private void 丞专万丒丆丙专丒丛()
    {
        float val_5;
        if(this.万丝一万丐且丌业丛 != false)
        {
                if(this.丕且丁丕业丌七且丘() != false)
        {
                val_5 = this.丅丆丈一丟上丐丘东;
            if((val_5 > 0f) && (this.丄丈丑丐丆丞丘与丗.isMine != false))
        {
                val_5 = this.丅丆丈一丟上丐丘东 - UnityEngine.Time.deltaTime;
            this.丅丆丈一丟上丐丘东 = val_5;
            if(val_5 <= 0f)
        {
                this.丅丆丈一丟上丐丘东 = 0f;
            this.丝丟丑丐专丁丁七丑();
        }
        
        }
        
        }
        
            if(this.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        }
        
        if(this.丘与丒丆丛丂专丌万 <= 0f)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.丘与丒丆丛丂专丌万 - val_4;
        this.丘与丒丆丛丂专丌万 = val_4;
        if(val_4 > 0f)
        {
                return;
        }
        
        this.丕丘丂业一专丗丝丙 = false;
    }
    private bool 丕且丁丕业丌七且丘()
    {
        PlayerBotInstance val_7;
        var val_8;
        var val_9;
        var val_12;
        val_7 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业;
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot == false)
        {
                return (bool)(GameConnect.丑丌丛丈丅丅与不业() != 16) ? 1 : 0;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
                return (bool)(GameConnect.丑丌丛丈丅丅与不业() != 16) ? 1 : 0;
        }
        
        val_8 = null;
        val_8 = null;
        if(GameController.mode != null)
        {
                val_9 = null;
        }
        
        val_9 = null;
        var val_3 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_9) ? GameController.mode : 0;
        val_7 = mem[(GameModeController.__il2cppRuntimeField_typeHierarchy + FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_9 ? GameController.mode : 0 + 512];
        val_7 = (GameModeController.__il2cppRuntimeField_typeHierarchy + FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_9 ? GameController.mode : 0 + 512;
        if(val_7.万上丌丙丌七丗丞丙() >= 11)
        {
                return (bool)(GameConnect.丑丌丛丈丅丅与不业() != 16) ? 1 : 0;
        }
        
        val_12 = 0;
        return (bool)(GameConnect.丑丌丛丈丅丅与不业() != 16) ? 1 : 0;
    }
    internal void 丆不下丞丕专丈世丏(Player_move_c.世不丟丂上丟与丌下 丗东丏与上丆丌不且, Player_move_c.丘丞与丆丄丐世丐丈 东东丝丄丂专世丏丛, Player_move_c.丒上专丐丐丅丄丟丌 丟丝与丛丝丕丛七不, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, string 丝三丛且丘不丌丙下, int 丆丝专专丟丟丈丏丐)
    {
        int val_13;
        BonusController val_14;
        PhotonView val_15;
        var val_16;
        float val_17;
        val_13 = 丆丝专专丟丟丈丏丐;
        if(this.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        this.万丝一万丐且丌业丛 = true;
        this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗下丞七丐一丐一丛();
        val_14 = 1152921505066536960;
        if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
            goto label_6;
        }
        
        this.丕丁丘丆万丄世专丛.丟三丏丅世一丟丟上.丒丝下丐万三丒三不();
        val_15 = this;
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
            goto label_14;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.丒专丈丛下丒一丒丛.gameObject);
        goto label_14;
        label_6:
        val_15 = this.丄丈丑丐丆丞丘与丗;
        label_14:
        if(mem[this.丄丈丑丐丆丞丘与丗].isMine == false)
        {
            goto label_39;
        }
        
        int val_5 = this.丕丁丘丆万丄世专丛.丕七丆丂丅丐专不丞.viewID;
        if((val_5 != val_13) && (this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != true))
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if((UnityEngine.Random.Range(min:  0, max:  100)) > 49)
        {
            goto label_26;
        }
        
        }
        
            val_16 = null;
            val_16 = null;
            val_14 = BonusController.丄丞丁丈与业上丞丟;
            UnityEngine.Vector3 val_8 = this.丕丁丘丆万丄世专丛.myPlayerTransform.position;
            UnityEngine.Vector3 val_9 = this.丕丁丘丆万丄世专丛.myPlayerTransform.position;
            UnityEngine.Vector3 val_10 = this.丕丁丘丆万丄世专丛.myPlayerTransform.position;
            float val_11 = val_9.y + (-1f);
            val_14.丄世丑丌丐万上东专(丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        
        label_26:
        if(val_5 == val_13)
        {
                this.一万丌丌丁三万丅丝(丛丟丒且丌丂丗丑丞:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丞丞下东且丗丄丒丏, 丐丟丘世丁三丕专专:  丗东丏与上丆丌不且);
        }
        else
        {
                object[] val_12 = new object[4];
            val_14 = 1152921504622075904;
            val_13 = val_13;
            val_12[0] = val_13;
            val_12[1] = 丗东丏与上丆丌不且;
            val_12[2] = 丝三丛且丘不丌丙下;
            val_12[3] = 东丏业丞丞业下丄世;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  34, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
        }
        
        label_39:
        this.丙丅丑丅一不丏与丒 = 0;
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != false)
        {
                val_17 = this.scenarioRespawnTime;
        }
        else
        {
                val_17 = 4f;
        }
        
        this.丅丆丈一丟上丐丘东 = val_17;
    }
    internal void 丝丟丑丐专丁丁七丑()
    {
        this.丘与丒丆丛丂专丌万 = this.丗丒丟丝丛业丌业丏;
        this.万丝一万丐且丌业丛 = true;
        this.丕丘丂业一专丗丝丙 = true;
        this.丁七东丂丟与且且丗(专丞上七七且丝七丗:  0);
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  25, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        object[] val_2 = new object[2];
        float val_3 = this.专一丟丏且丆丕丝七();
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_3 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_3 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_3;
        val_2[1] = this.丗丗万丗丛不丒丁三();
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        this.丕丛专丆丝丛丆丌丐();
        this.丒专丈丛下丒一丒丛.丌丕下东七丗丛丞下.与三丙丆丘万不丁丑();
    }
    internal void 业丟不丝专上不业丛()
    {
        this.万丝一万丐且丌业丛 = false;
    }
    internal void 丕丛专丆丝丛丆丌丐()
    {
        PlayerSpawnPoint val_1 = this.丕丁丘丆万丄世专丛.丟三丏丅世一丟丟上.丑丆丘丗世不丌丅丒(丕丅不业专丑丁上丅:  false);
        UnityEngine.Vector3 val_2 = val_1.boxCollider.size;
        UnityEngine.Vector3 val_3 = val_1.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector3 val_4 = val_1.boxCollider.size;
        UnityEngine.Vector3 val_5 = val_1.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_2.x * val_3.x, y:  val_4.z * val_5.z);
        UnityEngine.Vector3 val_9 = val_1.万东万丆专丌丕丐丗.position;
        UnityEngine.Vector3 val_10 = val_1.万东万丆专丌丕丐丗.position;
        float val_24 = 0.5f;
        float val_11 = val_8.x * val_24;
        val_11 = val_9.x - val_11;
        val_24 = val_8.y * val_24;
        val_24 = val_10.z - val_24;
        float val_12 = 0.x;
        UnityEngine.Vector3 val_14 = val_1.万东万丆专丌丕丐丗.position;
        float val_16 = val_12 + (UnityEngine.Random.Range(min:  0f, max:  val_12));
        float val_17 = val_14.x + (UnityEngine.Random.Range(min:  0f, max:  val_14.x));
        UnityEngine.Quaternion val_18 = val_1.万东万丆专丌丕丐丗.rotation;
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
        this.丒专丈丛下丒一丒丛.playerGameObject.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        PlayerBot.NavMeshAgentController val_22 = this.丒专丈丛下丒一丒丛.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        bool val_23 = val_22.agent.Warp(newPosition:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    internal void 一万丌丌丁三万丅丝(string 丛丟丒且丌丂丗丑丞, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专 = 1)
    {
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                object[] val_2 = new object[2];
            val_2[0] = 丛丟丒且丌丂丗丑丞;
            val_2[1] = 丐丟丘世丁三丕专专;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  31, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = 丛丟丒且丌丂丗丑丞;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  31, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 丁七东丂丟与且且丗(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        与丅丕丈丘东丝世丟 val_9 = 专丞上七七且丝七丗;
        object[] val_1 = new object[2];
        float val_2 = this.专一丟丏且丆丕丝七();
        if(val_9 != null)
        {
                val_1[0] = UnityEngine.Mathf.RoundToInt(f:  val_2);
            val_1[1] = UnityEngine.Mathf.RoundToInt(f:  this.丗丗万丗丛不丒丁三());
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  152, 丞下万上三丘上与专:  val_9 = 专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        val_1[0] = UnityEngine.Mathf.RoundToInt(f:  val_2);
        val_9 = UnityEngine.Mathf.RoundToInt(f:  this.丗丗万丗丛不丒丁三());
        val_1[1] = val_9;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  152, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 三丒且丟丂丈东丁丘()
    {
        this.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  new 三丐七丞专丑一丟世(丟丈一下东业一丝丆:  this.currentWeaponNameDebug));
    }
    internal void 丙上丆丁世丛万丕丂()
    {
        this.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  this.equippedWeapons.Item[UnityEngine.Random.Range(min:  0, max:  this.equippedWeapons.Count)]);
    }
    internal 三丐七丞专丑一丟世 丐丌丘丑丄丂万丟丑()
    {
        return (三丐七丞专丑一丟世)this.<丗丟上丙业丙上三丑>k__BackingField;
    }
    private void 且丄丐丛与丏不丞丆(三丐七丞专丑一丟世 丙业与丙丗丝不丈东)
    {
        this.<丗丟上丙业丙上三丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal WeaponSounds 丆东丛业丟丛丌丆丌()
    {
        if(this.丕丁丘丆万丄世专丛 == 0)
        {
                return 0;
        }
        
        if(this.丕丁丘丆万丄世专丛 != null)
        {
                return this.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
        }
        
        return this.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
    }
    internal 三丐七丞专丑一丟世 且丒世一丏丈丘丌专()
    {
        return (三丐七丞专丑一丟世)this.<丈丏与丏丝业丒七丝>k__BackingField;
    }
    private void 世上丞丕不业不丞丄(三丐七丞专丑一丟世 丙业与丙丗丝不丈东)
    {
        this.<丈丏与丏丝业丒七丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丙一世丞丏丌丑丟丘(三丐七丞专丑一丟世 丌丝下丄业一丄不三)
    {
        System.Object[] val_20;
        var val_21;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丌丝下丄业一丄不三 == null)
        {
                return;
        }
        
        if(this.丑丅不三丕七丂万丙 != null)
        {
                return;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = this.equippedWeapons.IndexOf(item:  丌丝下丄业一丄不三);
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  89, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
        object[] val_4 = new object[3];
        val_4[0] = 丌丝下丄业一丄不三.三与丛丑且丐丈业丌();
        val_4[1] = 丌丝下丄业一丄不三.丌上丗丕不七世丅丁().三丙且下一专上东与();
        val_4[2] = 0;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  89, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
        三丅丁丗丗丝丂万且 val_9 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丌丝下丄业一丄不三.三与丛丑且丐丈业丌());
        val_21 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_9.业东丅东丌上丗丑不());
        if(val_21 == null)
        {
                val_21 = val_9.丐七丐丝与丒七丈丐();
        }
        
        object[] val_14 = new object[2];
        val_20 = val_14;
        val_20[0] = UnityEngine.Mathf.Max(a:  0, b:  ExperienceController.丞丞丘业东丙丏七丌() - val_21.丈一下下丞世三丑丄());
        val_20[1] = val_21.七东与丄丕丁丛世三();
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  214, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_14);
        this.丂万与丘七丅不丕丈(丌丝下丄业一丄不三:  丌丝下丄业一丄不三);
    }
    internal void 下丐丟丗丛三丛东丌(int 下且与丐上丟七丑丏)
    {
        if((下且与丐上丟七丑丏 & 2147483648) != 0)
        {
                return;
        }
        
        if(this.equippedWeapons.Count <= 下且与丐上丟七丑丏)
        {
                return;
        }
        
        三丐七丞专丑一丟世 val_2 = this.equippedWeapons.Item[下且与丐上丟七丑丏];
        if(val_2 == null)
        {
                return;
        }
        
        this.丂万与丘七丅不丕丈(丌丝下丄业一丄不三:  val_2);
    }
    private void 丂万与丘七丅不丕丈(三丐七丞专丑一丟世 丌丝下丄业一丄不三)
    {
        this.<丈丏与丏丝业丒七丝>k__BackingField = this.<丗丟上丙业丙上三丑>k__BackingField;
        this.currentWeaponNameDebug = 丌丝下丄业一丄不三.三与丛丑且丐丈业丌();
        this.<丗丟上丙业丙上三丑>k__BackingField = 丌丝下丄业一丄不三;
        if(this.世丐丗丑丌东与丈丞 != null)
        {
                this.StopCoroutine(routine:  this.世丐丗丑丌东与丈丞);
            this.世丐丗丑丌东与丈丞 = 0;
        }
        
        this.万七丙丙七三专且丈 = 1;
        this.且下丘丛下丅丗丗丞();
    }
    internal 三丐七丞专丑一丟世 丁丛丏业东丗丘丕丛(CategoryNames 七丆丒与丗丌丄且丂)
    {
        var val_6;
        var val_7;
        var val_8;
        val_7 = 七丆丒与丗丌丄且丂;
        List.Enumerator<T> val_1 = this.equippedWeapons.GetEnumerator();
        label_7:
        if(((-302684360) & 1) == 0)
        {
            goto label_2;
        }
        
        val_8 = 0.丐丏七丌丕丗业且上();
        if(val_8.丌上丗丕不七世丅丁() == null)
        {
            goto label_7;
        }
        
        val_6 = val_8.丌上丗丕不七世丅丁();
        if(val_6.丒万丕七专不丏丞丌() != val_7)
        {
            goto label_7;
        }
        
        goto label_8;
        label_2:
        val_8 = 0;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (三丐七丞专丑一丟世)val_8;
    }
    internal bool 下且丟一丗万丞丗丙()
    {
        if(this.丆东丛业丟丛丌丆丌() == 0)
        {
                return false;
        }
        
        if((this.<丗丟上丙业丙上三丑>k__BackingField) == null)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  this.<丗丟上丙业丙上三丑>k__BackingField.三与丛丑且丐丈业丌(), b:  this.丆东丛业丟丛丌丆丌().三与丛丑且丐丈业丌());
    }
    private void 丐不万下丘丑丘万丈()
    {
        this.且下丘丛下丅丗丗丞();
    }
    internal bool 一丅丘与专丛丛万丕()
    {
        三丐七丞专丑一丟世 val_4;
        if((this.万丝一万丐且丌业丛 == true) || (this.丑丅不三丕七丂万丙 != null))
        {
                return false;
        }
        
        if(((this.下且丟一丗万丞丗丙() == false) || ((this.<丗丟上丙业丙上三丑>k__BackingField.专丆丛世丂丗丞一与) < 1)) || (this.世丐丗丑丌东与丈丞 != null))
        {
                return false;
        }
        
        if(this.丌上七丆丆丏丟丐世() != false)
        {
                return false;
        }
        
        val_4 = this.<丗丟上丙业丙上三丑>k__BackingField;
        if((this.<丗丟上丙业丙上三丑>k__BackingField) != null)
        {
            goto label_7;
        }
        
        val_4 = this.<丗丟上丙业丙上三丑>k__BackingField;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_7:
        var val_3 = ((this.<丗丟上丙业丙上三丑>k__BackingField.丅丕丟丙七下丘丏丁) < (this.<丗丟上丙业丙上三丑>k__BackingField.专丆丛世丂丗丞一与)) ? 1 : 0;
        return false;
        label_8:
    }
    internal bool 七丝上丈专东丑丑丈()
    {
        return (bool)(this.世丐丗丑丌东与丈丞 != 0) ? 1 : 0;
    }
    private void 且下丘丛下丅丗丗丞()
    {
        if(this.一丅丘与专丛丛万丕() == false)
        {
                return;
        }
        
        if((this.<丗丟上丙业丙上三丑>k__BackingField.丅丕丟丙七下丘丏丁) > 0)
        {
                return;
        }
        
        this.丆丁世一且丒丒世世();
    }
    private System.Collections.IEnumerator 丘丘不丅上丅与东世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerBotEntity.丐丕上上东丝丏下丅();
    }
    internal void 丆丁世一且丒丒世世()
    {
        if(this.一丅丘与专丛丛万丕() == false)
        {
                return;
        }
        
        if(this.业万丗专丕丆丕上丝 != null)
        {
                this.业万丗专丕丆丕上丝.Invoke();
        }
        
        if(this.一丅丘与专丛丛万丕() == false)
        {
                return;
        }
        
        this.世丐丗丑丌东与丈丞 = this.StartCoroutine(routine:  this.丘丘不丅上丅与东世());
    }
    internal bool 丞丕丝丑丛专丗丑丄()
    {
        if((this.万丝一万丐且丌业丛 == true) || (this.丑丅不三丕七丂万丙 != null))
        {
                return false;
        }
        
        if(this.下且丟一丗万丞丗丙() == false)
        {
                return false;
        }
        
        if(this.丌上七丆丆丏丟丐世() != false)
        {
                return false;
        }
        
        var val_3 = (this.世丐丗丑丌东与丈丞 == 0) ? 1 : 0;
        return false;
    }
    private bool 丌上七丆丆丏丟丐世()
    {
        return (bool)(((this.<丗丟上丙业丙上三丑>k__BackingField.丌丂丏且丛丌丞一丛) + this.丆东丛业丟丛丌丆丌().丈专世世丙丅东且一()) > UnityEngine.Time.realtimeSinceStartup) ? 1 : 0;
    }
    internal void 丟丑丙七丁三丞丕丁(bool 丙丌丏且丞丏丛丛丗 = True)
    {
        float val_30;
        float val_31;
        float val_36;
        float val_37;
        Player_move_c val_43;
        float val_44;
        三丐七丞专丑一丟世 val_45;
        int val_46;
        bool val_47;
        bool val_48;
        var val_49;
        var val_50;
        float val_51;
        var val_52;
        var val_53;
        this.且下丘丛下丅丗丗丞();
        if(this.丞丕丝丑丛专丗丑丄() == false)
        {
                return;
        }
        
        val_44 = UnityEngine.Time.realtimeSinceStartup;
        this.<丗丟上丙业丙上三丑>k__BackingField.丌丂丏且丛丌丞一丛 = val_44;
        if((this.<丗丟上丙业丙上三丑>k__BackingField.专丆丛世丂丗丞一与) >= 1)
        {
                val_45 = this.<丗丟上丙业丙上三丑>k__BackingField;
            if(val_45 != null)
        {
                val_46 = this.<丗丟上丙业丙上三丑>k__BackingField.丅丕丟丙七下丘丏丁;
        }
        else
        {
                val_45 = 24;
            val_46 = 28563616;
        }
        
            mem[24] = 28563615;
        }
        
        object[] val_3 = new object[2];
        WeaponSounds val_4 = this.丆东丛业丟丛丌丆丌();
        if(val_4.isMelee != false)
        {
                val_47 = 0;
        }
        else
        {
                WeaponSounds val_5 = this.丆东丛业丟丛丌丆丌();
            bool val_41 = val_5.isRoundMelee;
            val_41 = val_41 ^ 1;
            val_47 = val_41 & 255;
        }
        
        val_3[0] = val_47;
        WeaponSounds val_6 = this.丆东丛业丟丛丌丆丌();
        val_48 = val_6.isDoubleShot;
        if(val_48 != false)
        {
                val_48 = this.万七丙丙七三专且丈;
        }
        
        val_3[1] = val_48;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  151, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
        WeaponSounds val_7 = this.丆东丛业丟丛丌丆丌();
        if(val_7.isDoubleShot != false)
        {
                this.万七丙丙七三专且丈 = ((this.万七丙丙七三专且丈 + 1) >= 3) ? 1 : (this.万七丙丙七三专且丈 + 1);
        }
        
        val_43 = this.丆东丛业丟丛丌丆丌();
        if(val_10.bazooka == false)
        {
            goto label_23;
        }
        
        val_43 = this.丕丁丘丆万丄世专丛;
        if(this.丕丁丘丆万丄世专丛.丆不业专丑三万丞丂 == false)
        {
            goto label_25;
        }
        
        label_23:
        if(丙丌丏且丞丏丛丛丗 == false)
        {
                return;
        }
        
        WeaponSounds val_11 = this.丆东丛业丟丛丌丆丌();
        if(val_11.freezer != false)
        {
                val_49 = null;
            val_49 = null;
            UnityEngine.Vector2 val_14 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            float val_42 = val_14.x;
            UnityEngine.Vector2 val_16 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            val_50 = UnityEngine.Screen.height;
            UnityEngine.Vector2 val_21 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            float val_44 = val_21.y;
            float val_45 = 0.5f;
            val_42 = (float)UnityEngine.Screen.width - val_42;
            val_51 = 0f;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_50 = 1152921505074044928;
            val_52 = null;
            val_52 = null;
            float val_43 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_43 = 1f - val_43;
            val_43 = val_43 * (float)UnityEngine.Screen.height;
            val_51 = val_43 * val_45;
        }
        
            val_44 = (float)val_50 - val_44;
            val_42 = val_42 * val_45;
            val_45 = val_44 * val_45;
            val_42 = val_42 + ((float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.RoundToInt(f:  val_16.x)));
            UnityEngine.Vector2 val_25 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            float val_46 = (float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.RoundToInt(f:  val_25.y));
            val_46 = (val_45 + val_51) + val_46;
            UnityEngine.Ray val_29 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_43 = this.丆东丛业丟丛丌丆丌();
            丗丝丄丞丐与不丕丗 val_34 = this.丕丁丘丆万丄世专丛.丝丙丄与七丂不七丄(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_31, y = val_31, z = val_31}, m_Direction = new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_30}}, 丆丒不丗丅丂丅丞丅:  false, 不丅丛专丘丅专丘丕:  val_43.丕丟丕业丑三下专丑(), 一丛上丗丑丐丄丟与:  false);
            UnityEngine.Vector3 val_38 = this.丕丁丘丆万丄世专丛.丌丆丅东不丘不丆丙.position;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_48}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            val_44 = val_39.x;
            this.丕丁丘丆万丄世专丛.万东丅七丈丒东丂东(不丅丛专丘丅专丘丕:  val_44);
            val_53 = null;
            val_53 = null;
            if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                object[] val_40 = new object[1];
            val_43 = 0f;
            val_40[0] = val_43;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  3, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_40);
        }
        
        }
        
        this.业丛东丁万下丏不七();
        return;
        label_25:
        this.且丗丑丆下丑丘世丏();
    }
    internal float 三专丗七丂丈不与下()
    {
        if(this.下且丟一丗万丞丗丙() == false)
        {
                return (float)val_3.range;
        }
        
        WeaponSounds val_2 = this.丆东丛业丟丛丌丆丌();
        this = this.丆东丛业丟丛丌丆丌();
        if(this != null)
        {
                if(val_2.isMelee == false)
        {
                return this.丕丟丕业丑三下专丑();
        }
        
            return (float)val_3.range;
        }
        
        if(val_2.isMelee == true)
        {
                return (float)val_3.range;
        }
        
        return this.丕丟丕业丑三下专丑();
    }
    private void 业丛东丁万下丏不七()
    {
        float val_25;
        float val_26;
        float val_53;
        float val_54;
        var val_55;
        var val_56;
        var val_57;
        float val_58;
        float val_59;
        var val_60;
        float val_61;
        System.Collections.IEnumerator val_62;
        var val_63;
        float val_64;
        float val_65;
        float val_66;
        float val_67;
        int val_68;
        WeaponSounds val_1 = this.丆东丛业丟丛丌丆丌();
        val_53 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        if(this.丆东丛业丟丛丌丆丌().丌丆丈丈丌不丈丄丗() != false)
        {
                this.丞七丂丅丅丄丑丄丈();
            return;
        }
        
        val_54 = val_1.tekKoof * val_53;
        val_55 = 0;
        goto label_7;
        label_51:
        val_56 = null;
        val_56 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 != 0)
        {
                val_57 = null;
            val_57 = null;
            UnityEngine.Vector2 val_8 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            float val_50 = val_8.x;
            UnityEngine.Vector2 val_10 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            val_10.x = val_54 * val_10.x;
            UnityEngine.Vector2 val_15 = this.丆东丛业丟丛丌丆丌().世丆丈丐东东丁丁丗();
            float val_49 = val_15.y;
            val_58 = val_54 * val_50;
            float val_52 = (float)UnityEngine.Screen.height;
            val_49 = val_54 * val_49;
            val_50 = (float)UnityEngine.Screen.width - val_58;
            val_59 = 0f;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_60 = null;
            val_60 = null;
            val_58 = (float)UnityEngine.Screen.height;
            float val_51 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_51 = 1f - val_51;
            val_51 = val_51 * val_58;
            val_59 = val_51 * 0.5f;
        }
        
            val_49 = val_52 - val_49;
            val_50 = val_50 * 0.5f;
            val_61 = (float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.RoundToInt(f:  val_10.x));
            val_62 = this.丆东丛业丟丛丌丆丌();
            val_52 = val_49 * 0.5f;
            val_50 = val_50 + val_61;
            UnityEngine.Vector2 val_19 = val_62.世丆丈丐东东丁丁丗();
            float val_53 = (float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.RoundToInt(f:  val_54 * val_19.y));
            val_53 = (val_52 + val_59) + val_53;
            UnityEngine.Ray val_24 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_63 = null;
            val_63 = null;
            UnityEngine.Vector3 val_28 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_26, y = 0f, z = 0f});
            val_64 = val_28.z;
            val_65 = val_28.x;
            val_66 = val_28.y;
            val_67 = val_64;
            UnityEngine.Vector3 val_29 = this.eyesTransform.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_65, y = val_66, z = val_67});
            UnityEngine.Vector3 val_30 = this.eyesTransform.position;
        }
        else
        {
                UnityEngine.Vector3 val_31 = this.eyesTransform.position;
            val_64 = val_31.z;
            UnityEngine.Vector3 val_32 = this.eyesTransform.forward;
            val_65 = val_31.x;
            val_66 = val_31.y;
            val_67 = val_64;
        }
        
        val_25 = val_25;
        val_26 = val_26;
        val_53 = this.三专丗七丂丈不与下();
        if((this.七与丆一丏下丏七不(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_26, y = val_26, z = val_26}, m_Direction = new UnityEngine.Vector3() {x = val_26, y = val_25, z = val_25}}, 丂七丑世丏丐丅不丌: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丏上万丅丏一不不丕:  val_53, 丄丏且业丏丟且丂丁:  Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞())) == false)
        {
            goto label_46;
        }
        
        WeaponSounds val_36 = this.丆东丛业丟丛丌丆丌();
        if(val_36.bulletExplode == false)
        {
            goto label_40;
        }
        
        val_53 = val_53;
        val_64 = val_67;
        UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.identity;
        val_61 = val_38.y;
        Rocket val_41 = this.丞专一丙丁丒万三丏(丌丝下丄业一丄不三:  this.丆东丛业丟丛丌丆丌(), 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_53, y = val_66, z = val_64}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_38.x, y = val_61, z = val_38.z, w = val_38.w}, 丑三一万丆不丁万丏:  this.丈丗世丕且丐丕丒丝(丌丝下丄业一丄不三:  this.丆东丛业丟丛丌丆丌()), 丗丑丞丗七业丆丙丁:  1);
        if(val_41 == null)
        {
            goto label_43;
        }
        
        val_41.丐丅丟丟丞七丗三丙 = true;
        val_62 = val_41.丄丕万丄丐万七丅丈(且丙与丏下丅丐世丑:  0, 丕丕世且下一与丝与:  0f);
        goto label_44;
        label_40:
        this.丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0), 专世丂丆专业丌丈丈:  val_53);
        this.丆东丛业丟丛丌丆丌().丝丅业且丆东与丗不();
        goto label_46;
        label_43:
        mem[612] = 1;
        val_62 = 0.丄丕万丄丐万七丅丈(且丙与丏下丅丐世丑:  0, 丕丕世且下一与丝与:  0f);
        label_44:
        val_54 = val_54;
        UnityEngine.Coroutine val_46 = val_41.StartCoroutine(routine:  val_62);
        label_46:
        val_55 = 1;
        label_7:
        WeaponSounds val_47 = this.丆东丛业丟丛丌丆丌();
        if(val_47.isShotGun != false)
        {
                WeaponSounds val_48 = this.丆东丛业丟丛丌丆丌();
            val_68 = val_48.countShots;
        }
        else
        {
                val_68 = 1;
        }
        
        if(val_55 < val_68)
        {
            goto label_51;
        }
    
    }
    private void 丞七丂丅丅丄丑丄丈()
    {
        var val_25;
        var val_26;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  this.丕丁丘丆万丄世专丛, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
        label_28:
        var val_25 = 0;
        val_25 = val_25 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        T val_6 = val_2.Current;
        UnityEngine.Vector3 val_7 = this.eyesTransform.position;
        UnityEngine.Vector3 val_8 = val_6.position;
        UnityEngine.Vector3 val_9 = this.eyesTransform.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_11 = val_6.position;
        UnityEngine.Vector3 val_12 = this.丕丁丘丆万丄世专丛.myPlayerTransform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = this.丕丁丘丆万丄世专丛.myPlayerTransform.forward;
        WeaponSounds val_16 = this.丆东丛业丟丛丌丆丌();
        WeaponSounds val_17 = this.丆东丛业丟丛丌丆丌();
        float val_18 = val_16.shootDistance * val_17.shootDistance;
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, to:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) >= 0)
        {
            goto label_28;
        }
        
        WeaponSounds val_19 = this.丆东丛业丟丛丌丆丌();
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_19.shootDistance, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞())) == false)
        {
            goto label_28;
        }
        
        this.丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0), 专世丂丆专业丌丈丈:  val_19.shootDistance);
        goto label_28;
        label_7:
        val_25 = 0;
        val_26 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_27 = 0;
            val_27 = val_27 + 1;
            val_2.Dispose();
        }
        
        this.丆东丛业丟丛丌丆丌().丝丅业且丆东与丗不();
    }
    private float 丈丗世丕且丐丕丒丝(WeaponSounds 丌丝下丄业一丄不三)
    {
        float val_2;
        if(丌丝下丄业一丄不三.isCharging == false)
        {
            goto label_1;
        }
        
        val_2 = this.丛三丗丏不丌丐万丙;
        if(this.丐丛丏丁上丄丆世丘 <= val_2)
        {
            goto label_3;
        }
        
        val_2 = this.丐丛丏丁上丄丆世丘;
        goto label_3;
        label_1:
        val_2 = 1f;
        label_3:
        if(丌丝下丄业一丄不三.dotFlamethrower == false)
        {
                return (float)(丌丝下丄业一丄不三.dotFlameDamageIsDependedOnChargeTime == false) ? 1f : (val_2);
        }
        
        return (float)(丌丝下丄业一丄不三.dotFlameDamageIsDependedOnChargeTime == false) ? 1f : (val_2);
    }
    private void 且丗丑丆下丑丘世丏()
    {
        WeaponSounds val_2 = this.丆东丛业丟丛丌丆丌();
        UnityEngine.Vector3 val_5 = val_2.bulletSpawnPoints.Item[0].transform.position;
        WeaponSounds val_6 = this.丆东丛业丟丛丌丆丌();
        UnityEngine.Quaternion val_9 = val_6.bulletSpawnPoints.Item[0].transform.rotation;
        Rocket val_10 = this.丞专一丙丁丒万三丏(丌丝下丄业一丄不三:  this.丆东丛业丟丛丌丆丌(), 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, 丑三一万丆不丁万丏:  1f, 丗丑丞丗七业丆丙丁:  1);
        val_10.丐丅丟丟丞七丗三丙 = true;
    }
    internal Rocket 丞专一丙丁丒万三丏(WeaponSounds 丌丝下丄业一丄不三, UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, float 丑三一万丆不丁万丏 = 1, int 丗丑丞丗七业丆丙丁 = 1)
    {
        string val_8;
        UnityEngine.GameObject val_1 = RocketStack.丄丞丁丈与业上丞丟.丄丌丛丗世业丛丆丂();
        val_1.transform.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        val_1.transform.rotation = new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w};
        Rocket val_4 = val_1.GetComponent<Rocket>();
        if(丌丝下丄业一丄不三 != null)
        {
                val_8 = 丌丝下丄业一丄不三.三与丛丑且丐丈业丌();
        }
        else
        {
                val_8 = 0.三与丛丑且丐丈业丌();
        }
        
        float val_8 = 丌丝下丄业一丄不三.bazookaImpulseRadius;
        float val_7 = 丘丐丘万丌丟丞下丝.东上丄丗丗东万丑丟();
        val_7 = val_7 + 1f;
        val_8 = val_8 * val_7;
        val_4.三丄专上丞丛下万与(世万丘丟丐上世不上:  this.丕丁丘丆万丄世专丛, 丛丟三丘丛且业丈丏:  丌丝下丄业一丄不三, 丆与丕丕丂下丟一丈:  val_8, 且三丙丁丂且一丑世:  val_8, 丑三一万丆不丁万丏:  丑三一万丆不丁万丏, 东上丛七丑丅七业与:  丗丑丞丗七业丆丙丁, 丑丆专丕世丐丛上丒:  0, 丄丌不丞业丘世下七:  0);
        return val_4;
    }
    private void 丆七丆与丅丕丝丂丐(丅丙上七上一丐不下 丞下万上三丘上与专, float 专世丂丆专业丌丈丈 = 0)
    {
        Player_move_c val_37;
        var val_38;
        var val_39;
        float val_42;
        float val_43;
        float val_46;
        丏专丐且丘丌丛不丁 val_47;
        val_38 = 0;
        val_39 = 0;
        if( == 0)
        {
                return;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        val_39 = 5;
        if(丞下万上三丘上与专.IsDead() == true)
        {
                return;
        }
        
        val_37 = this.丕丁丘丆万丄世专丛;
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_39 = 4;
        if((丞下万上三丘上与专.IsEnemyTo(专丞上七七且丝七丗:  val_37)) == false)
        {
                return;
        }
        
        val_42 = 1f;
        val_43 = this.丆东丛业丟丛丌丆丌().业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  val_42, 丆专三丈丛丗丑且东:  0f, 业一一七丂丞丁丝丝:  true);
        if(this.丆东丛业丟丛丌丆丌().丌丆丈丈丌不丈丄丗() != false)
        {
                val_43 = val_43 * (this.且丐丟丝丗丌万丐丌(丞下万上三丘上与专:  丞下万上三丘上与专));
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != false)
        {
                val_42 = this.scenarioDamageMultiplier;
            val_43 = val_43 * val_42;
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅下万丏丘东丄丌万 == false)
        {
            goto label_45;
        }
        
        if((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.丆东丛业丟丛丌丆丌()), b:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.世丏专不万丏世丌丞())) == false)
        {
            goto label_35;
        }
        
        val_42 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.世丐丁丏丐与东一丙;
        goto label_39;
        label_35:
        if((System.String.op_Equality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.丆东丛业丟丛丌丆丌()), b:  this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.丛丈丒七丈丑丑丅丏())) == false)
        {
            goto label_45;
        }
        
        val_42 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.三丂三且丗万丑下丌;
        label_39:
        val_43 = val_43 * val_42;
        label_45:
        UnityEngine.Vector3 val_21 = this.transform.position;
        val_46 = val_21.y;
        WeaponSounds val_23 = this.丆东丛业丟丛丌丆丌();
        val_47 = val_23.typeDead;
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot != false)
        {
                string val_24 = this.万下丞世丝丂与东丅();
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot == false)
        {
            goto label_61;
        }
        
        if(丞下万上三丘上与专 != null)
        {
            goto label_69;
        }
        
        label_70:
        label_69:
        var val_42 = 0;
        val_42 = val_42 + 1;
        goto label_66;
        label_61:
        int val_27 = this.丕丁丘丆万丄世专丛.丕七丆丂丅丐专不丞.viewID;
        if(丞下万上三丘上与专 != null)
        {
            goto label_69;
        }
        
        goto label_70;
        label_66:
        丞下万上三丘上与专.ApplyDamage(丞丈专下丈专业三丞:  val_43, 丛世一丟丞丁业丘丒:  this.丕丁丘丆万丄世专丛.丂七一业下丈业丕丒, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_21.x, y = val_46, z = val_21.z}, 丐丟丘世丁三丕专专:  (this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot == true) ? 20 : 0, 东丏业丞丞业下丄世:  val_47, 丝三丛且丘不丌丙下:  this.丆东丛业丟丛丌丆丌().三与丛丑且丐丈业丌(), 丒丈丐丐丗丐专丈丏:  0);
        WeaponSounds val_29 = this.丆东丛业丟丛丌丆丌();
        if(val_29.isPoisoning != false)
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            UnityEngine.Vector3 val_34 = this.transform.position;
            val_46 = val_34.y;
            val_47 = this.丆东丛业丟丛丌丆丌();
            this.丕丁丘丆万丄世专丛.丈丞与与丕丕一丝世(丞下万上三丘上与专:  丞下万上三丘上与专.transform.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_34.x, y = val_46, z = val_34.z}, 丒下世丝丂万丑丏下:  val_43, 丌丝下丄业一丄不三:  val_47);
        }
        
        val_37 = this.丆东丛业丟丛丌丆丌();
        if(val_36.isSlowdown == false)
        {
                return;
        }
        
        if(丞下万上三丘上与专 == null)
        {
                return;
        }
        
        var val_37 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丞下万上三丘上与专 : 0;
    }
    private float 且丐丟丝丗丌万丐丌(丅丙上七上一丐不下 丞下万上三丘上与专)
    {
        if(this.丆东丛业丟丛丌丆丌().丌丆丈丈丌不丈丄丗() == false)
        {
                return 1f;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        UnityEngine.Vector3 val_6 = 丞下万上三丘上与专.transform.position;
        if(this.丕丁丘丆万丄世专丛 != null)
        {
                return this.丕丁丘丆万丄世专丛.丞丗丌与丒丞不丒丂(丌丝下丄业一丄不三:  this.丆东丛业丟丛丌丆丌(), 丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        }
        
        return this.丕丁丘丆万丄世专丛.丞丗丌与丒丞不丒丂(丌丝下丄业一丄不三:  this.丆东丛业丟丛丌丆丌(), 丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
    }
    internal string 万下丞世丝丂与东丅()
    {
        return "fort_bot_" + this.scenarioAvatarID;
    }
    internal bool 下丒丏与下一三丗且()
    {
        return (bool)(this.丑丅不三丕七丂万丙 != 0) ? 1 : 0;
    }
    internal bool 丒万不三丟与丐丈上()
    {
        if(this.丐专下三丙三世且万 == null)
        {
                return false;
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.isScenarioBot == true)
        {
                return false;
        }
        
        if(this.万丝一万丐且丌业丛 == true)
        {
                return false;
        }
        
        if(this.丑丅不三丕七丂万丙 != null)
        {
                return false;
        }
        
        if((UnityEngine.Time.time - this.丙丒丈丄丝丗丂下丛) <= this.丐专下三丙三世且万.丙丈丗丌丘三丄业且())
        {
                return false;
        }
        
        return 东丟丟万下丛丆丛丟.丂七三世丘万丘丝丘();
    }
    internal void 万丒一万丌丆丏丈不()
    {
        if(this.丒万不三丟与丐丈上() == false)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.丑丅不三丕七丂万丙 = this.StartCoroutine(routine:  this.丙丙七东下世丗丝丞().GetEnumerator());
    }
    private System.Collections.IEnumerable 丙丙七东下世丗丝丞()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new PlayerBotEntity.丙万丞丑不上不不东();
    }

}
