using UnityEngine;
internal class TurretController : VTableHolder, 丅丙上七上一丐不下, 东丁丆一业丈万丆丐, 万丝丅丗且丒丝丌丟
{
    // Fields
    internal 万丝丅丗且丒丝丌丟 丙万丅下丂业东丄丒;
    public float damageMulty;
    public float healthSurvival;
    public float maxRadiusScanTarget;
    public UnityEngine.AudioClip turretActivSound;
    public UnityEngine.AudioClip turretDeadSound;
    public UnityEngine.AudioClip turretDeactivationSound;
    public UnityEngine.AudioClip hitSound;
    public TurretController.与东上世丈丙且丏世 turretType;
    public UnityEngine.Renderer turretRenderer;
    public UnityEngine.GameObject explosionAnimObj;
    public UnityEngine.GameObject isEnemySprite;
    public UnityEngine.Transform healthBar;
    public UnityEngine.Transform spherePoint;
    public UnityEngine.Transform rayGroundPoint;
    public UnityEngine.TextMesh nickLabel;
    public UnityEngine.Material inactiveMaterial;
    public UnityEngine.Animation animation;
    public bool solidWithEnemiesOnly;
    public bool setMaterialsForEnemy;
    public UnityEngine.Material[] enemyMaterials;
    public UnityEngine.GameObject workingSound;
    public UnityEngine.GameObject workingParticle;
    public bool isRun;
    protected bool 丂丛丄丆丐东且一世;
    private bool 丌与丅丂东丞丘东且;
    public bool isKilled;
    public int gadgetLevel;
    public float health;
    public float healthInit;
    public UnityEngine.GameObject myPlayer;
    public Player_move_c myPlayerMoveC;
    public PhotonView photonView;
    public bool isEnemyTurret;
    protected float 丈与与丅丌丁丌丙丒;
    protected bool 丌且下丕下下丌万丞;
    protected bool 丆丕丛丞丑丞丄丟三;
    protected float maxTimerShot;
    protected UnityEngine.Transform 丞下万上三丘上与专;
    protected float 丕丄丕丑丗东丆与丘;
    protected float 丘世丕丟丈丆下三丟;
    private UnityEngine.Rigidbody 丗上丄丌上七丕丄三;
    private UnityEngine.Vector3 上丐与业丞丈丏丐三;
    private int 丞丏七丁不丂不丞与;
    private bool 丒丘且东与世万下丑;
    private bool 丞三丞丙丗丞七一丝;
    protected UnityEngine.BoxCollider 且丟丅专丕丄丙世丄;
    private UnityEngine.Material[] 丝万丛丝一丑丛丒丄;
    private bool 丝且三丐丈下丐丂丆;
    public System.Action GadgetOnKill;
    public bool validatePlaceWithSphere;
    public float destroyTurretTime;
    protected string 丆丈丅上丙业丌且丅;
    protected 丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
    public UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
    public UnityEngine.Collider 丝且不七丂世丗下七 { get; }
    public UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
    public bool 丈丐丁不丙东世七丕 { get; }
    public UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    public UnityEngine.Collider get_aimCollider()
    {
        return (UnityEngine.Collider)this.且丟丅专丕丄丙世丄;
    }
    public UnityEngine.Collider get_bodyAimCollider()
    {
        return (UnityEngine.Collider)this.且丟丅专丕丄丙世丄;
    }
    public UnityEngine.Collider get_headAimCollider()
    {
        return (UnityEngine.Collider)this.且丟丅专丕丄丙世丄;
    }
    public UnityEngine.Transform get_targetTransform()
    {
        return this.transform;
    }
    public bool get_isTargetDead()
    {
        var val_3;
        if(this != 0)
        {
                return (bool)(this.isKilled == true) ? 1 : 0;
        }
        
        val_3 = 1;
        return (bool)(this.isKilled == true) ? 1 : 0;
    }
    public UnityEngine.Vector3 get_currentTargetVelocity()
    {
        return UnityEngine.Vector3.zero;
    }
    private void Awake()
    {
        var val_12;
        UnityEngine.Material[] val_1 = this.turretRenderer.materials;
        val_12 = 0;
        this.丝万丛丝一丑丛丒丄 = new UnityEngine.Material[0];
        goto label_3;
        label_15:
        UnityEngine.Material val_12 = this.turretRenderer.sharedMaterials[0];
        if(this.丝万丛丝一丑丛丒丄 == null)
        {
            goto label_7;
        }
        
        if(val_12 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_12 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_12 = 1;
        this.丝万丛丝一丑丛丒丄[0] = val_12;
        label_3:
        UnityEngine.Material[] val_4 = this.turretRenderer.sharedMaterials;
        if(val_12 < val_4.Length)
        {
            goto label_15;
        }
        
        this.photonView = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        this.且丟丅专丕丄丙世丄 = this.GetComponent<UnityEngine.BoxCollider>();
        if((UnityEngine.Object.op_Implicit(exists:  this.photonView)) != false)
        {
                if(this.photonView.isMine != false)
        {
                PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        }
        
        }
        
        float val_13 = this.maxRadiusScanTarget;
        val_13 = val_13 * val_13;
        this.丈与与丅丌丁丌丙丒 = val_13;
        this.丗上丄丌上七丕丄三 = this.transform.GetComponent<UnityEngine.Rigidbody>();
        if(this.nickLabel == 0)
        {
                return;
        }
        
        this.nickLabel.richText = false;
    }
    internal TurretController()
    {
        this.damageMulty = 1f;
        this.healthSurvival = 0f;
        this.maxRadiusScanTarget = 30f;
        this.health = 1E+07f;
        this.healthInit = 5.398923E-41f;
        this.maxTimerShot = 0.1f;
        this.丕丄丕丑丗东丆与丘 = -1f;
        this.丘世丕丟丈丆下三丟 = 0.5f;
        this.validatePlaceWithSphere = true;
        this.上丐与业丞丈丏丐三 = 0;
        mem[1152921540587164856] = 0;
        this.destroyTurretTime = 2f;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void TurretController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void OnCollisionEnter(UnityEngine.Collision 丆丛丂丝丄世且丛丕)
    {
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丆丛丂丝丄世且丛丕.gameObject.name, b:  "DeadCollider")) == false)
        {
                return;
        }
        
        this.MinusLive(丛业专丘丂丅丗丝丛:  1000f, 一丆丌丝专丂丛丙上:  false, 丞丗且下世丐业丌丙:  0);
        this.丗上丄丌上七丕丄三.isKinematic = true;
    }
    private void Start()
    {
        var val_32;
        int val_34;
        UnityEngine.GameObject val_35;
        var val_37;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        UnityEngine.GameObject val_43;
        var val_44;
        var val_45;
        int val_46;
        int val_47;
        object val_48;
        var val_49;
        var val_50;
        this.turretRenderer.material.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        this.丗丒丁万丝丙丏丕丙();
        val_32 = null;
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_32 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                this.丌且下丕下下丌万丞 = this.photonView.isMine;
            val_32 = null;
        }
        
        }
        
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_40;
        }
        
        }
        
        this.gadgetLevel = 0;
        string val_5 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                if((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  val_5, 丝丒上丑一三丑丐丛:  true)) != false)
        {
                丕丈丏丝丗下丟丅丂 val_9 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_5];
            val_34 = val_9.业东丅东丌上丗丑不();
            int val_12 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_34);
            this.gadgetLevel = val_12;
            if(val_12 <= 0)
        {
                this.gadgetLevel = BalanceController.世丅丄丗丄丌三世且(丞世不丒下上上丝丑:  val_9.业东丅东丌上丗丑不());
        }
        
        }
        
            val_35 = this.gameObject;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_35, 不东丛三丂丌丑专丆:  9);
        }
        
        val_32 = null;
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_32 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                val_37 = 1152921505719563712;
            object[] val_16 = new object[1];
            val_34 = 1;
            val_16[0] = val_34;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  166, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_16);
            object[] val_18 = new object[1];
            val_35 = val_18;
            val_35[0] = BalanceController.与丟丆不丐丌丞丄一(丆万一不丌且东丐丐:  val_5, 丈丘丝一丗下丈丐不:  this.gadgetLevel);
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  110, 丞下万上三丘上与专:  4, 丗丟上上丒丐丗丞丙:  val_18);
            val_32 = null;
        }
        
        }
        
        label_40:
        val_32 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false))
        {
            goto label_58;
        }
        
        val_34 = 1152921505189965824;
        val_37 = 1152921525487174064;
        val_39 = 0;
        goto label_59;
        label_71:
        val_40 = null;
        val_40 = null;
        Player_move_c val_19 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(this.photonView.ownerId == val_19.mySkinName.丄丈丑丐丆丞丘与丗.ownerId)
        {
            goto label_67;
        }
        
        val_39 = 1;
        label_59:
        val_41 = null;
        val_41 = null;
        val_35 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_39 < val_35.Count)
        {
            goto label_71;
        }
        
        goto label_72;
        label_58:
        val_42 = null;
        val_42 = null;
        val_43 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_43 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        this.myPlayer = val_43;
        if(null != 0)
        {
            goto label_83;
        }
        
        goto label_77;
        label_67:
        val_44 = null;
        val_44 = null;
        val_35 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        Player_move_c val_21 = val_35.Item[0];
        val_43 = val_21.mySkinName.gameObject;
        this.myPlayer = val_43;
        if(val_43 != null)
        {
            goto label_83;
        }
        
        label_77:
        label_83:
        SkinName val_23 = val_43.GetComponent<SkinName>();
        this.myPlayerMoveC = val_23.playerMoveC;
        label_72:
        this.丁丄丁丐丒丏不丕丝();
        val_45 = null;
        val_45 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_87;
        }
        
        if(this.photonView.instantiationData == null)
        {
            goto label_92;
        }
        
        System.Object[] val_25 = this.photonView.instantiationData;
        if(val_25.Length < 2)
        {
            goto label_92;
        }
        
        object val_32 = this.photonView.instantiationData[0];
        val_35 = this.photonView.instantiationData[1];
        goto label_99;
        label_87:
        val_46 = this.gadgetLevel;
        val_47 = ExperienceController.丞丞丘业东丙丏七丌();
        label_99:
        this.不业丝丛专七上丂丕(丈丘丝一丗下丈丐不:  val_46, 丙丂丏丛丌丏下丝不:  val_47);
        label_92:
        if(null != null)
        {
                val_48 = this.gameObject;
            val_49 = 1;
        }
        else
        {
                val_50 = null;
            val_50 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_109;
        }
        
        }
        
            val_48 = this.gameObject;
            val_49 = 5;
        }
        
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  val_48, 专丐丛丆与专世丆丂:  5);
        label_109:
        丘丛丞且一丅丁丏丐.丙丅丅丆丂一上业丐(不丂丅丁且丆东东丂:  this.transform, 丞下万上三丘上与专:  this);
    }
    protected void 丁丄丁丐丒丏不丕丝()
    {
        if(this.isRun == true)
        {
                return;
        }
        
        if(this.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(this.丞三丞丙丗丞七一丝 != false)
        {
                return;
        }
        
        this.丞三丞丙丗丞七一丝 = true;
        this.transform.parent = this.myPlayerMoveC.turretPoint.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    protected virtual System.Collections.IEnumerator 丗丅世且丛丑业世丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new TurretController.且专且世丒世丄丞专();
    }
    private void 世万业丐与丏丂丐丏()
    {
        var val_40;
        var val_41;
        PhotonView val_42;
        var val_43;
        var val_44;
        float val_45;
        float val_46;
        var val_47;
        var val_48;
        int val_49;
        float val_50;
        float val_51;
        float val_52;
        float val_53;
        var val_54;
        var val_55;
        int val_56;
        int val_57;
        int val_58;
        var val_59;
        var val_60;
        int val_61;
        var val_62;
        if(this.nickLabel == 0)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_6;
        }
        
        val_40 = null;
        val_40 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) || (this.myPlayerMoveC == 0))
        {
            goto label_44;
        }
        
        val_41 = null;
        val_41 = null;
        val_42 = this.myPlayerMoveC.photonView;
        if(typeof(Player_move_c).__il2cppRuntimeField_3B8.viewID == val_42.viewID)
        {
            goto label_92;
        }
        
        val_43 = null;
        val_43 = null;
        if(this.myPlayerMoveC.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
            goto label_92;
        }
        
        this.nickLabel.text = System.String.alignConst;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.isEnemySprite, 丏业丟一东丂东丘丛:  true);
        return;
        label_6:
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_38;
        }
        
        val_44 = null;
        val_44 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                if(this.myPlayerMoveC != 0)
        {
            goto label_47;
        }
        
        }
        
        label_44:
        if(this.丞丏七丁不丂不丞与 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_10 = UnityEngine.Color.white;
        val_45 = val_10.r;
        val_46 = val_10.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_45, g = val_10.g, b = val_46, a = val_10.a};
        this.丞丏七丁不丂不丞与 = 0;
        return;
        label_38:
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_53;
        }
        
        val_42 = 1152921505286238208;
        val_47 = null;
        val_47 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) || (this.myPlayerMoveC == 0))
        {
            goto label_62;
        }
        
        val_48 = null;
        val_48 = null;
        val_42 = this.myPlayerMoveC;
        val_49 = this.丞丏七丁不丂不丞与;
        if(丘丑丅三丆丑丌且丝() == val_42.丘丑丅三丆丑丌且丝())
        {
            goto label_68;
        }
        
        goto label_69;
        label_53:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_72;
        }
        
        label_62:
        if(this.丞丏七丁不丂不丞与 == 0)
        {
            goto label_124;
        }
        
        UnityEngine.Color val_17 = UnityEngine.Color.white;
        val_45 = val_17.r;
        val_46 = val_17.b;
        val_50 = val_45;
        val_51 = val_17.g;
        val_52 = val_46;
        val_53 = val_17.a;
        this.nickLabel.color = new UnityEngine.Color() {r = val_50, g = val_51, b = val_52, a = val_53};
        this.丞丏七丁不丂不丞与 = 0;
        goto label_124;
        label_47:
        val_54 = null;
        val_54 = null;
        val_42 = this.myPlayerMoveC.photonView;
        if(typeof(Player_move_c).__il2cppRuntimeField_3B8.viewID == val_42.viewID)
        {
            goto label_92;
        }
        
        val_55 = null;
        val_55 = null;
        if(this.myPlayerMoveC.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
            goto label_92;
        }
        
        if(this.丞丏七丁不丂不丞与 == 2)
        {
                return;
        }
        
        UnityEngine.Color val_20 = UnityEngine.Color.red;
        val_45 = val_20.r;
        val_46 = val_20.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_45, g = val_20.g, b = val_46, a = val_20.a};
        val_56 = 2;
        goto label_95;
        label_72:
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
            goto label_98;
        }
        
        label_123:
        val_57 = this.丞丏七丁不丂不丞与;
        label_68:
        if(val_57 == 1)
        {
            goto label_124;
        }
        
        UnityEngine.Color val_22 = UnityEngine.Color.blue;
        val_45 = val_22.r;
        val_46 = val_22.b;
        val_50 = val_45;
        val_51 = val_22.g;
        val_52 = val_46;
        val_53 = val_22.a;
        this.nickLabel.color = new UnityEngine.Color() {r = val_50, g = val_51, b = val_52, a = val_53};
        val_58 = 1;
        goto label_101;
        label_98:
        if(this.myPlayerMoveC == 0)
        {
            goto label_104;
        }
        
        val_59 = null;
        val_59 = null;
        val_42 = this.myPlayerMoveC;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == val_42)
        {
            goto label_123;
        }
        
        label_104:
        if((GameConnect.丄丏丒丏上东业丒一() == false) || (this.myPlayerMoveC == 0))
        {
            goto label_116;
        }
        
        val_60 = null;
        val_60 = null;
        val_42 = this.myPlayerMoveC.丟三丏丅世一丟丟上;
        if(且世专不丄丏七下万() ^ val_42.且世专不丄丏七下万() == false)
        {
            goto label_123;
        }
        
        label_116:
        val_61 = this.丞丏七丁不丂不丞与;
        label_69:
        if(val_61 == 2)
        {
            goto label_124;
        }
        
        UnityEngine.Color val_30 = UnityEngine.Color.red;
        val_45 = val_30.r;
        val_46 = val_30.b;
        val_50 = val_45;
        val_51 = val_30.g;
        val_52 = val_46;
        val_53 = val_30.a;
        this.nickLabel.color = new UnityEngine.Color() {r = val_50, g = val_51, b = val_52, a = val_53};
        if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_131;
        }
        
        }
        
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.down;
        val_53 = 10000f;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  val_53);
        val_45 = val_35.x;
        val_46 = val_35.z;
        val_50 = val_45;
        val_51 = val_35.y;
        val_52 = val_46;
        this.nickLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_50, y = val_51, z = val_52};
        label_131:
        val_58 = 2;
        label_101:
        this.丞丏七丁不丂不丞与 = val_58;
        label_124:
        if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
                return;
        }
        
        }
        
        val_62 = null;
        val_62 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        label_92:
        if(this.丞丏七丁不丂不丞与 == 1)
        {
                return;
        }
        
        UnityEngine.Color val_39 = UnityEngine.Color.blue;
        val_45 = val_39.r;
        val_46 = val_39.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_45, g = val_39.g, b = val_46, a = val_39.a};
        val_56 = 1;
        label_95:
        this.丞丏七丁不丂不丞与 = val_56;
    }
    protected virtual void 丕丕丞不丆业东下丒()
    {
    
    }
    protected virtual void 丈丞一丈丑丝丈丂丂()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丕丄丕丑丗东丆与丘 - val_1;
        this.丕丄丕丑丗东丆与丘 = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.丕丄丕丑丗东丆与丘 = this.丘世丕丟丈丆下三丟;
        if(this.丆丕丛丞丑丞丄丟三 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this);
    }
    protected virtual void 丟丞丆上上丁丅下丐()
    {
    
    }
    private void Update()
    {
        if((this.isRun != true) && (this.丞三丞丙丗丞七一丝 != true))
        {
                this.丁丄丁丐丒丏不丕丝();
        }
        
        if((this.setMaterialsForEnemy != false) && (((this.isEnemyTurret == true) ? 1 : 0) != ((this.丝且三丐丈下丐丂丆 == true) ? 1 : 0)))
        {
                this.丗丒丁万丝丙丏丕丙();
            this.丝且三丐丈下丐丂丆 = this.isEnemyTurret;
        }
    
    }
    protected virtual void 下专专专丄世丗且丐()
    {
        var val_25;
        string val_26;
        float val_27;
        bool val_28;
        var val_29;
        var val_30;
        if((this.myPlayerMoveC == 0) || (this.丒丘且东与世万下丑 == true))
        {
            goto label_7;
        }
        
        this.丒丘且东与世万下丑 = true;
        if(this.nickLabel == 0)
        {
            goto label_7;
        }
        
        val_25 = null;
        val_25 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_10;
        }
        
        val_26 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  this.myPlayerMoveC.mySkinName.不与丏上丐七丄专且);
        if(this.nickLabel != null)
        {
            goto label_61;
        }
        
        label_62:
        label_61:
        this.nickLabel.text = val_26;
        label_7:
        this.世万业丐与丏丂丐丏();
        if((this.isRun != false) && (this.healthBar != 0))
        {
                if(this.health > 0f)
        {
                float val_25 = this.healthInit;
            val_25 = this.health / val_25;
        }
        
            val_27 = 0f;
            this.healthBar.localScale = new UnityEngine.Vector3() {x = val_27, y = 0f, z = 0f};
        }
        
        this.下丌不丑一不万丟万();
        if(this.isEnemySprite != 0)
        {
                val_26 = this.isEnemyTurret;
            var val_7 = (val_26 == true) ? 1 : 0;
            val_7 = this.isEnemySprite.activeSelf ^ val_7;
            if(val_7 != false)
        {
                this.isEnemySprite.SetActive(value:  (val_26 == true) ? 1 : 0);
        }
        
        }
        
        val_28 = this.isRun;
        if(val_28 != false)
        {
                if(this.isKilled != false)
        {
                val_28 = 0;
        }
        else
        {
                if(this.animation == 0)
        {
                val_28 = 1;
        }
        else
        {
                val_28 = (~(this.animation.IsPlaying(name:  "turret_start"))) & 1;
        }
        
        }
        
        }
        
        this.丂丛丄丆丐东且一世 = val_28;
        val_29 = null;
        val_29 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_30 = null;
            val_30 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                this.丑万丗丟不下丕丁丁();
            return;
        }
        
        }
        
        if(this.isRun == false)
        {
                return;
        }
        
        if(this.isKilled != false)
        {
                return;
        }
        
        if(this.丂丛丄丆丐东且一世 == false)
        {
                return;
        }
        
        if(this.丞下万上三丘上与专 == 0)
        {
            goto label_67;
        }
        
        UnityEngine.Vector3 val_13 = this.丞下万上三丘上与专.position;
        val_27 = -500f;
        if(val_13.y >= 0)
        {
            goto label_59;
        }
        
        label_71:
        this.丞下万上三丘上与专 = 0;
        goto label_67;
        label_10:
        if(this.nickLabel != null)
        {
            goto label_61;
        }
        
        goto label_62;
        label_59:
        if((GameConnect.东且三丆丑世世丘丟() == true) || ((this.丞下万上三丘上与专.CompareTag(tag:  "Player")) == false))
        {
            goto label_67;
        }
        
        SkinName val_16 = this.丞下万上三丘上与专.GetComponent<SkinName>();
        if(val_16.playerMoveC.万万一与丝业七专下 == true)
        {
            goto label_71;
        }
        
        label_67:
        if(this.丞下万上三丘上与专 == 0)
        {
                return;
        }
        
        float val_18 = UnityEngine.Time.deltaTime;
        val_18 = this.丕丄丕丑丗东丆与丘 - val_18;
        this.丕丄丕丑丗东丆与丘 = val_18;
        if(val_18 < 0)
        {
                this.丕丄丕丑丗东丆与丘 = this.丘世丕丟丈丆下三丟;
            if(this.丆丕丛丞丑丞丄丟三 != true)
        {
                UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  this);
        }
        
        }
        
        if(this.丗上丄丌上七丕丄三.isKinematic == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_22 = this.transform.position;
        UnityEngine.Transform val_23 = this.transform;
        if(val_22.y < 0)
        {
                UnityEngine.Vector3 val_24 = val_23.position;
            this.上丐与业丞丈丏丐三 = val_24;
            mem[1152921540589296724] = val_24.y;
            mem[1152921540589296728] = val_24.z;
            return;
        }
        
        val_23.position = new UnityEngine.Vector3() {x = this.上丐与业丞丈丏丐三, y = V9.16B, z = V10.16B};
    }
    protected virtual void 东丅下世丏专丝东丝()
    {
        float val_26;
        var val_27;
        float val_30;
        float val_31;
        UnityEngine.Object val_33;
        InGameGUI val_34;
        var val_35;
        UnityEngine.Vector3 val_1 = this.rayGroundPoint.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        val_26 = val_1.y;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) == false)
        {
            goto label_5;
        }
        
        val_26 = 0.05f;
        if(0.targetValue <= val_26)
        {
            goto label_5;
        }
        
        val_26 = 0.7f;
        var val_7 = (0.targetValue < 0) ? 1 : 0;
        goto label_6;
        label_5:
        val_27 = 0;
        label_6:
        if(this.validatePlaceWithSphere != false)
        {
                UnityEngine.Vector3 val_8 = this.spherePoint.position;
            val_30 = val_8.x;
            val_31 = val_8.z;
            val_33 = 0;
            bool val_12 = UnityEngine.Physics.CheckSphere(position:  new UnityEngine.Vector3() {x = val_30, y = val_8.y, z = val_31}, radius:  this.spherePoint.GetComponent<UnityEngine.SphereCollider>().radius, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆());
        }
        else
        {
                UnityEngine.Vector3 val_14 = this.myPlayerMoveC.myTransform.position;
            val_30 = val_14.x;
            val_31 = val_14.z;
            UnityEngine.Vector3 val_15 = this.spherePoint.position;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_30, y = val_14.y, z = val_31}, end:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) != false)
        {
                val_33 = 0.transform.root;
            bool val_21 = UnityEngine.Object.op_Inequality(x:  val_33, y:  this.transform);
        }
        else
        {
                val_33 = 0;
        }
        
        }
        
        if((val_27 != 0) && ((val_33 & 1) == 0))
        {
                this.inactiveMaterial.SetColor(name:  "_TintColor", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            val_34 = InGameGUI.丙丞专丌丁丞与不丐;
            val_35 = 0;
            if(val_34 == 0)
        {
                return;
        }
        
            val_34 = GetComponent<UIButton>();
            if(val_34 != null)
        {
                return;
        }
        
            return;
        }
        
        this.inactiveMaterial.SetColor(name:  "_TintColor", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_34 = InGameGUI.丙丞专丌丁丞与不丐;
        val_35 = 0;
        if(val_34 == 0)
        {
                return;
        }
        
        val_34 = GetComponent<UIButton>();
    }
    public virtual bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_6;
        var val_7;
        var val_8;
        var val_9;
        int val_10;
        val_6 = 丞世不丒下上上丝丑;
        byte val_1 = val_6 & 255;
        if(val_1 > 92)
        {
            goto label_1;
        }
        
        if(val_1 > 32)
        {
            goto label_2;
        }
        
        byte val_2 = val_6 & 255;
        if(val_2 == 24)
        {
            goto label_3;
        }
        
        if(val_2 != 32)
        {
            goto label_19;
        }
        
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_6;
        }
        
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        goto label_8;
        label_1:
        if(val_1 > 110)
        {
            goto label_9;
        }
        
        byte val_3 = val_6 & 255;
        if(val_3 == 104)
        {
            goto label_10;
        }
        
        if(val_3 != 110)
        {
            goto label_19;
        }
        
        object val_7 = 专丒丌丆下丐丞丟丞[0];
        this.且不专丙业下丝一下(丒七上丘不丝丁丘与:  21884928);
        goto label_50;
        label_2:
        byte val_4 = val_6 & 255;
        if(val_4 == 37)
        {
            goto label_15;
        }
        
        if(val_4 != 92)
        {
            goto label_19;
        }
        
        goto label_50;
        label_9:
        byte val_5 = val_6 & 255;
        if(val_5 == 119)
        {
            goto label_18;
        }
        
        if(val_5 != 166)
        {
            goto label_19;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[0];
        goto label_50;
        label_19:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_24;
        }
        
        val_9 = 专丒丌丆下丐丞丟丞;
        val_10 = 专丒丌丆下丐丞丟丞.Length;
        if(val_10 != 2)
        {
            goto label_25;
        }
        
        label_42:
        val_6 = 专丒丌丆下丐丞丟丞[0];
        object val_9 = 专丒丌丆下丐丞丟丞[1];
        val_8 = 1;
        this.MinusLiveReal(丛业专丘丂丅丗丝丛:  3.782474E-38f, 一丆丌丝专丂丛丙上:  true, 丞丗且下世丐业丌丙:  21884928);
        return (bool)val_8;
        label_10:
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_31;
        }
        
        if(专丒丌丆下丐丞丟丞.Length != 1)
        {
            goto label_50;
        }
        
        object val_10 = 专丒丌丆下丐丞丟丞[0];
        goto label_50;
        label_15:
        object val_11 = 专丒丌丆下丐丞丟丞[0];
        this.万东专下丆丝丒丙世(丞丗且下世丐业丌丙:  21884928);
        goto label_50;
        label_18:
        object val_12 = 专丒丌丆下丐丞丟丞[0];
        if(this.health <= null)
        {
            goto label_50;
        }
        
        this.health = null;
        goto label_50;
        label_6:
        val_7 = 0;
        label_8:
        this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  false);
        goto label_50;
        label_24:
        val_9 = 24;
        val_6 = 28563616;
        val_10 = 28563616;
        if(val_6 == 2)
        {
            goto label_42;
        }
        
        label_25:
        if(val_10 != 3)
        {
            goto label_50;
        }
        
        object val_13 = 专丒丌丆下丐丞丟丞[0];
        object val_14 = 专丒丌丆下丐丞丟丞[1];
        object val_15 = 专丒丌丆下丐丞丟丞[2];
        this.MinusLiveReal(丛业专丘丂丅丗丝丛:  3.782474E-38f, 一丆丌丝专丂丛丙上:  false, 丞丗且下世丐业丌丙:  21884928);
        goto label_50;
        label_31:
        this.丏且上丌丘丈世丂世();
        label_50:
        val_8 = 1;
        return (bool)val_8;
    }
    protected virtual void 丏且上丌丘丈世丂世(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
    
    }
    internal void 且不专丙业下丝一下(int 丒七上丘不丝丁丘与)
    {
        int val_12 = 丒七上丘不丝丁丘与;
        if(this.丌与丅丂东丞丘东且 == true)
        {
                return;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        string val_4 = this.gameObject.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  val_4)) == false)
        {
                return;
        }
        
        int val_7 = BalanceController.丟丏一丒丁世丄一丗(丆万一不丌且东丐丐:  val_4, 丞丌东丟且丒丐丑丂:  val_12 = 丒七上丘不丝丁丘与);
        this.gadgetLevel = val_7;
        UnityEngine.Debug.Log(message:  "SynchNumUpdateRPC: Set gadget level "("SynchNumUpdateRPC: Set gadget level ") + val_7);
        if(this.myPlayerMoveC != 0)
        {
                val_12 = this.myPlayerMoveC.丟三丏丅世一丟丟上.下东且丐丆丅丁世丟;
        }
        else
        {
                val_12 = 0;
        }
        
        丕丈丏丝丗下丟丅丂 val_11 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_4];
    }
    internal void 不业丝丛专七上丂丕(int 丈丘丝一丗下丈丐不, int 丙丂丏丛丌丏下丝不)
    {
        int val_10 = 丈丘丝一丗下丈丐不;
        this.丌与丅丂东丞丘东且 = true;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        string val_4 = this.gameObject.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  val_4)) == false)
        {
                return;
        }
        
        this.gadgetLevel = val_10;
        UnityEngine.Debug.Log(message:  "SetGadgetLevel: Set gadget level "("SetGadgetLevel: Set gadget level ") + val_10);
        val_10 = 丁下万丟且丟丛下业.一三专丞丒丅上业上();
        丕丈丏丝丗下丟丅丂 val_9 = val_10.Item[val_4];
    }
    internal void 且业丆七丌丙且万丌(int 丒七上丘不丝丁丘与)
    {
    
    }
    protected virtual void 一丕万东丟丏丄业丅(丕丈丏丝丗下丟丅丂 东一丁世丑丞业丄丐, int 丈丘丝一丗下丈丐不, int 东丄丗丂且丞不东丈)
    {
        var val_5;
        float val_2 = BalanceController.丘不万与下丗一丑丙(丗丑丐丕丟丝且下丕:  东一丁世丑丞业丄丐.业上丙丞丐丄丆丅七(), 丂丄丆丁丘丝丞丐不:  丈丘丝一丗下丈丐不, 丙丂丏丛丌丏下丝不:  东丄丗丂且丞不东丈);
        this.health = val_2;
        this.healthInit = val_2;
        this.damageMulty = 东一丁世丑丞业丄丐.丁丒丝丈丈丒丞丘下(丅丏三七丁丑丞丄丏:  this.photonView);
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
        this.丆丈丅上丙业丌且丅 = 东一丁世丑丞业丄丐.业上丙丞丐丄丆丅七();
        this.丁且丌丁丆丝丙丘丝 = 东一丁世丑丞业丄丐;
    }
    private void 下丌不丑一不万丟万()
    {
        Player_move_c val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        this.isEnemyTurret = false;
        val_24 = 1152921505066536960;
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_3;
        }
        
        if(this.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_24 = 1152921505286238208;
        val_25 = null;
        val_25 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_24 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_24 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(this.myPlayerMoveC.丘丑丅三丆丑丌且丝() != 丘丑丅三丆丑丌且丝())
        {
            goto label_18;
        }
        
        return;
        label_3:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_27;
        }
        
        BattleRoyaleController val_7 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_7.squadInfo.Count < 1)
        {
            goto label_27;
        }
        
        bool val_24 = this.丌且下丕下下丌万丞;
        val_24 = val_24 ^ 1;
        this.isEnemyTurret = val_24;
        val_27 = 0;
        goto label_28;
        label_42:
        BattleRoyaleController val_9 = BattleRoyaleController.丑七不且上丗丁一世();
        万丅世丈丕丕丌丅丗 val_10 = val_9.squadInfo.Item[0];
        if(val_10.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 == this.myPlayerMoveC)
        {
                this.isEnemyTurret = false;
        }
        
        val_27 = 1;
        label_28:
        BattleRoyaleController val_12 = BattleRoyaleController.丑七不且上丗丁一世();
        val_24 = val_12.squadInfo;
        if(val_27 < val_24.Count)
        {
            goto label_42;
        }
        
        return;
        label_27:
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_46;
        }
        
        this.isEnemyTurret = this.丌且下丕下下丌万丞 ^ 1;
        if(this.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        val_24 = GameController.onlineMode;
        if(val_24 == null)
        {
            goto label_50;
        }
        
        var val_16 = (null == null) ? (val_24) : 0;
        goto label_52;
        label_46:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_55;
        }
        
        bool val_25 = this.丌且下丕下下丌万丞;
        val_25 = val_25 ^ 1;
        this.isEnemyTurret = val_25;
        if(this.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_24 = 1152921505286238208;
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        if(this.myPlayerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万() ^ typeof(Player_move_c).__il2cppRuntimeField_618.且世专不丄丏七下万() == false)
        {
            goto label_72;
        }
        
        return;
        label_55:
        val_32 = null;
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        label_18:
        this.isEnemyTurret = true;
        return;
        label_50:
        val_29 = 0;
        label_52:
        if((val_29.与丒与丐丂丘丂丒丕(专丞上七七且丝七丗:  this.myPlayerMoveC)) == false)
        {
                return;
        }
        
        label_72:
        this.isEnemyTurret = false;
    }
    protected void 世且丂丕丐丝丐丐且()
    {
        goto typeof(TurretController).__il2cppRuntimeField_2F8;
    }
    protected virtual void 丅丙业不丏丟丄丕丝()
    {
    
    }
    protected void 三且丆丙丂丘丗丕丙(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        var val_6;
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.position;
        val_6 = null;
        val_6 = null;
        var val_6 = 0;
        val_6 = val_6 + 1;
        丂丈丙且丈丗三丆丕.ApplyDamage(丞丈专下丈专业三丞:  this.damageMulty, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丐丟丘世丁三丕专专:  8, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  this.丆丈丅上丙业丌且丅, 丒丈丐丐丗丐专丈丏:  GetComponent<PixelView>().viewID);
    }
    public virtual void StartTurret()
    {
        var val_5 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (this.丌且下丕下下丌万丞 == false))
        {
            goto label_4;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_21;
        }
        
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  104, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        goto label_21;
        label_4:
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                this.丏且上丌丘丈世丂世();
        }
        
        label_21:
        this.且丟丅专丕丄丙世丄.enabled = true;
        this.丗上丄丌上七丕丄三.isKinematic = false;
        this.丗上丄丌上七丕丄三.useGravity = true;
        var val_6 = 0;
        val_6 = val_6 + 1;
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.专丄丝丈丆丟东丙东(丕丕世且下一与丝与:  5f).GetEnumerator());
    }
    private System.Collections.IEnumerable 专丄丝丈丆丟东丙东(float 丕丕世且下一与丝与)
    {
        TurretController.一七丈丑下三丁不万 val_1 = new TurretController.一七丈丑下三丁不万();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        goto typeof(TurretController).__il2cppRuntimeField_318;
    }
    protected virtual void 丐三丌丒丄丁丑不丌(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.health != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.health == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.health;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丙东丟丌丂丝丝七万(float 丝三不七丑丏一业丑)
    {
        if(this.health <= 丝三不七丑丏一业丑)
        {
                return;
        }
        
        this.health = 丝三不七丑丏一业丑;
    }
    protected System.Collections.IEnumerator 与丅丟三丂丞丟丐丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController.丒丗丘丂丟丟七丌专();
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Transform get_transform()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.transform;
        }
        
        return val_1.transform;
    }
    public float get_maxHealth()
    {
        return (float)this.healthInit;
    }
    public float GetGamePlayForBaseGamePlay(int 业丆丈丟世一业一丙, int 业万上丆丐丞且丒七)
    {
        return (float)(float)业丆丈丟世一业一丙;
    }
    public virtual void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.MinusLive(丛业专丘丂丅丗丝丛:  丞丈专下丈专业三丞, 一丆丌丝专丂丛丙上:  false, 丞丗且下世丐业丌丙:  丒丈丐丐丗丐专丈丏);
    }
    public virtual bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        Player_move_c val_24;
        var val_25;
        var val_26;
        var val_27;
        val_24 = 1152921505171275776;
        val_25 = null;
        val_25 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return false;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == true)
        {
                return false;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == true)
        {
                return false;
        }
        
        if(GameConnect.丙丘不世专且万丄丐() == true)
        {
                return false;
        }
        
        val_24 = this.myPlayerMoveC;
        if(val_24 == 0)
        {
                return false;
        }
        
        if(专丞上七七且丝七丗 == 0)
        {
                return false;
        }
        
        val_24 = this.myPlayerMoveC;
        if((val_24.Equals(other:  专丞上七七且丝七丗)) != false)
        {
                return false;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() != false)
        {
                if(this.myPlayerMoveC.丘丑丅三丆丑丌且丝() == 专丞上七七且丝七丗.丘丑丅三丆丑丌且丝())
        {
                return false;
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_34;
        }
        
        var val_24 = 0;
        label_43:
        BattleRoyaleController val_11 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_24 >= val_11.squadInfo.Count)
        {
            goto label_34;
        }
        
        BattleRoyaleController val_13 = BattleRoyaleController.丑七不且上丗丁一世();
        万丅世丈丕丕丌丅丗 val_14 = val_13.squadInfo.Item[0];
        val_24 = val_24 + 1;
        if(val_14.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 != this.myPlayerMoveC)
        {
            goto label_43;
        }
        
        return false;
        label_34:
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                val_26 = null;
            val_26 = null;
            if(GameController.onlineMode != null)
        {
                var val_17 = (null == null) ? GameController.onlineMode : 0;
        }
        else
        {
                val_27 = 0;
        }
        
            if((val_27.与丒与丐丂丘丂丒丕(专丞上七七且丝七丗:  this.myPlayerMoveC)) == true)
        {
                return false;
        }
        
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return false;
        }
        
        if(this.myPlayerMoveC == 0)
        {
                return false;
        }
        
        if(this.myPlayerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万() ^ 专丞上七七且丝七丗.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
        {
                return false;
        }
        
        return false;
    }
    public bool IsDead()
    {
        return (bool)this.isKilled;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public void MinusLive(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙 = 0)
    {
        this.MinusLive(丛业专丘丂丅丗丝丛:  丛业专丘丂丅丗丝丛, 一丆丌丝专丂丛丙上:  false, 丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙);
    }
    public void MinusLive(float 丛业专丘丂丅丗丝丛, bool 一丆丌丝专丂丛丙上, int 丞丗且下世丐业丌丙 = 0)
    {
        System.Object[] val_3;
        int val_4;
        float val_5;
        var val_6;
        val_4 = 丞丗且下世丐业丌丙;
        val_5 = 丛业专丘丂丅丗丝丛;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(this.isRun == false)
        {
                return;
        }
        
        val_3 = 1152921505171275776;
        val_6 = null;
        val_6 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                float val_3 = this.health;
            val_3 = val_3 - val_5;
            this.health = val_3;
            if(val_3 < 0)
        {
                this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  true);
            val_6 = null;
            val_5 = 10000f;
        }
        
            val_6 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            object[] val_2 = new object[3];
            val_3 = val_2;
            val_3[0] = val_5;
            val_3[1] = true;
            val_4 = val_4;
            val_3[2] = val_4;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        this.MinusLiveReal(丛业专丘丂丅丗丝丛:  val_5, 一丆丌丝专丂丛丙上:  true, 丞丗且下世丐业丌丙:  0);
    }
    internal void 丟丄丌万丙丘丑丆丘(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙)
    {
        this.MinusLiveReal(丛业专丘丂丅丗丝丛:  丛业专丘丂丅丗丝丛, 一丆丌丝专丂丛丙上:  true, 丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙);
    }
    private void 丟丄丌万丙丘丑丆丘(float 丛业专丘丂丅丗丝丛, bool 一丆丌丝专丂丛丙上, int 丞丗且下世丐业丌丙)
    {
        this.MinusLiveReal(丛业专丘丂丅丗丝丛:  丛业专丘丂丅丗丝丛, 一丆丌丝专丂丛丙上:  一丆丌丝专丂丛丙上, 丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙);
    }
    public void MinusLiveReal(float 丛业专丘丂丅丗丝丛, bool 一丆丌丝专丂丛丙上, int 丞丗且下世丐业丌丙 = 0)
    {
        var val_11;
        var val_13;
        this.StopCoroutine(routine:  this.与丅丟三丂丞丟丐丌());
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.与丅丟三丂丞丟丐丌());
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (一丆丌丝专丂丛丙上 != false))
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.hitSound);
        }
        
        if(this.isKilled != false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
        float val_11 = this.health;
        val_11 = val_11 - 丛业专丘丂丅丗丝丛;
        this.health = val_11;
        val_11 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                object[] val_6 = new object[1];
            val_6[0] = this.health;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_6);
        }
        
        if(this.health >= 0)
        {
                return;
        }
        
        this.health = 0f;
        val_13 = null;
        val_13 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            object[] val_8 = new object[1];
            val_8[0] = 一丆丌丝专丂丛丙上;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  32, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_8);
            object[] val_9 = new object[1];
            val_9[0] = 丞丗且下世丐业丌丙;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  37, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_9);
            return;
        }
        
        this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  一丆丌丝专丂丛丙上);
    }
    internal void 万东专下丆丝丒丙世(int 丞丗且下世丐业丌丙)
    {
        var val_3;
        var val_8;
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        val_8 = null;
        val_9 = System.String.alignConst;
        val_8 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_12:
        if((1627670400 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(((X23 + 504) == 0) || ((X23 + 504 + 504.viewID) != 丞丗且下世丐业丌丙))
        {
            goto label_12;
        }
        
        val_9 = mem[丞丗且下世丐业丌丙 + 480];
        val_9 = 丞丗且下世丐业丌丙 + 480;
        val_10 = val_4.丘丑丅三丆丑丌且丝();
        val_11 = null;
        val_11 = null;
        if(((val_4 & 1) == 0) || (this.turretType != 1))
        {
            goto label_24;
        }
        
        val_12 = null;
        val_12 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  76, 专上丝且丂世丛丝丒:  1f);
        goto label_24;
        label_4:
        val_10 = 0;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.MeKill(丆丆丂业丒丈丙丒丅:  val_9, 与丁丟东丞丙丗丌丈:  0);
    }
    public void MeKill(string 丆丆丂业丒丈丙丒丅, int 与丁丟东丞丙丗丌丈)
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(this.myPlayer == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        SkinName val_3 = this.myPlayer.GetComponent<SkinName>();
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        丗丄万丟专丈丌丙丈(万七且丕丟世且丌不:  丆丆丂业丒丈丙丒丅, 丕上丗万丏丁不下丏:  与丁丟东丞丙丗丌丈, 丗东丏与上丆丌不且:  9, 丝丅丏丞丐丈丞三丞:  val_3.不与丏上丐七丄专且, 丕丏七丅丕万丗与一:  this.myPlayerMoveC.丘丑丅三丆丑丌且丝(), 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a}, 下一下丁丟丛丑不丁:  0);
    }
    public void SendImKilledRPC()
    {
        var val_2 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  32, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            return;
        }
        
        this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  false);
    }
    internal void 丐丕与丟七与三丂业()
    {
        this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  false);
    }
    internal void 丑丕一一丄丘万丗丆(bool 一丆丌丝专丂丛丙上)
    {
        UnityEngine.Rigidbody val_15;
        if(this.isKilled != false)
        {
                return;
        }
        
        this.isKilled = true;
        if(this.nickLabel != 0)
        {
                this.nickLabel.gameObject.SetActive(value:  false);
        }
        
        this.且丟丅专丕丄丙世丄.enabled = false;
        val_15 = this.丗上丄丌上七丕丄三;
        val_15.isKinematic = true;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_11;
        }
        
        val_15 = this.GetComponent<UnityEngine.AudioSource>();
        if(一丆丌丝专丂丛丙上 == false)
        {
            goto label_12;
        }
        
        val_15.PlayOneShot(clip:  this.turretDeadSound);
        goto label_14;
        label_11:
        if(一丆丌丝专丂丛丙上 == false)
        {
            goto label_15;
        }
        
        label_14:
        if(this.explosionAnimObj != 0)
        {
                this.explosionAnimObj.SetActive(value:  true);
        }
        
        if(this.animation != 0)
        {
                bool val_7 = this.animation.Play(animation:  "turret_dead");
        }
        
        if(this.GadgetOnKill == null)
        {
            goto label_29;
        }
        
        this.GadgetOnKill.Invoke();
        goto label_29;
        label_12:
        val_15.PlayOneShot(clip:  this.turretDeactivationSound);
        label_15:
        if(this.animation != 0)
        {
                bool val_9 = this.animation.Play(animation:  "turret_stop");
        }
        
        label_29:
        if(this.workingSound != 0)
        {
                this.workingSound.SetActive(value:  false);
        }
        
        if(this.workingParticle != 0)
        {
                this.workingParticle.SetActive(value:  false);
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.丑万丗丟不下丕丁丁(丕丕世且下一与丝与:  this.destroyTurretTime).GetEnumerator());
    }
    protected virtual void 丐丐丗丒丂上下万且()
    {
    
    }
    protected virtual void 丐一丒丝与三上丅七()
    {
    
    }
    private void 丑万丗丟不下丕丁丁()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丑万丗丟不下丕丁丁(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    private System.Collections.IEnumerable 丑万丗丟不下丕丁丁(float 丕丕世且下一与丝与)
    {
        TurretController.丟下业万丌丁丒专与 val_1 = new TurretController.丟下业万丌丁丒专与();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    internal void 丏且上丌丘丈世丂世()
    {
        int val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        if(this.nickLabel != 0)
        {
                this.nickLabel.gameObject.SetActive(value:  true);
        }
        
        this.且丟丅专丕丄丙世丄.enabled = true;
        this.transform.parent = 0;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.turretActivSound);
        }
        
        val_21 = UnityEngine.LayerMask.NameToLayer(layerName:  "Default");
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.gameObject, 不东丛三丂丌丑专丆:  val_21);
        val_22 = null;
        val_22 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                if(this.photonView == null)
        {
                val_22 = null;
        }
        
            this.photonView.synchronization = 3;
        }
        
        this.isRun = true;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.workingSound != 0)
        {
                this.workingSound.SetActive(value:  true);
        }
        
        }
        
        if(this.workingParticle != 0)
        {
                this.workingParticle.SetActive(value:  true);
        }
        
        if(this.animation != 0)
        {
                bool val_12 = this.animation.Play(animation:  "turret_start");
        }
        
        this.丗丒丁万丝丙丏丕丙();
        if(this.solidWithEnemiesOnly == false)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (this.丌且下丕下下丌万丞 != true))
        {
                if(GameConnect.丙丘不世专且万丄丐() == false)
        {
            goto label_40;
        }
        
        }
        
        label_59:
        this.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "IgnoreRocketsAndBullets");
        return;
        label_40:
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
                return;
        }
        
        if(this.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_21 = 1152921505286238208;
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_21 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_21 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(this.myPlayerMoveC.丘丑丅三丆丑丌且丝() == 丘丑丅三丆丑丌且丝())
        {
            goto label_59;
        }
    
    }
    protected virtual void 丒与上专丕丐一丝丕()
    {
    
    }
    private void 丗丒丁万丝丙丏丕丙()
    {
        UnityEngine.Material[] val_2;
        var val_3;
        UnityEngine.Renderer val_4;
        UnityEngine.Material[] val_5;
        if(this.isRun == false)
        {
            goto label_1;
        }
        
        if((this.setMaterialsForEnemy == false) || (this.isEnemyTurret == false))
        {
            goto label_3;
        }
        
        val_2 = this.enemyMaterials;
        goto label_4;
        label_1:
        UnityEngine.Material[] val_1 = new UnityEngine.Material[0];
        val_3 = 0;
        goto label_6;
        label_11:
        val_3 = 1;
        val_1[0] = this.inactiveMaterial;
        label_6:
        if(val_3 < val_1.Length)
        {
            goto label_11;
        }
        
        val_4 = this.turretRenderer;
        val_5 = val_1;
        goto label_13;
        label_3:
        val_2 = this.丝万丛丝一丑丛丒丄;
        label_4:
        val_4 = mem[this.丝万丛丝一丑丛丒丄];
        val_5 = val_4;
        label_13:
        this.turretRenderer.sharedMaterials = val_5;
    }
    private void OnDestroy()
    {
        var val_4;
        var val_5;
        var val_6;
        object val_7;
        var val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_4;
        }
        
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        PotionsController.丄丞丁丈与业上丞丟.丁下丙世丛不上丞丝(丕且丙丙且下丛丟丒:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐, 七丏丄丅丌业与且丙:  0, 一世且专业丒丆业丟:  false);
        label_4:
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        if(null != null)
        {
                val_7 = this.gameObject;
            val_8 = 1;
        }
        else
        {
                val_9 = null;
            val_9 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_19;
        }
        
        }
        
            val_7 = this.gameObject;
            val_8 = 5;
        }
        
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  val_7, 专丐丛丆与专世丆丂:  5);
        label_19:
        丘丛丞且一丅丁丏丐.丏丄丄东丒世专丌丁(不丂丅丁且丆东东丂:  this.transform);
    }
    public UnityEngine.Vector3 GetHeadPoint()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = this.且丟丅专丕丄丙世丄.size;
        float val_4 = -0.5f;
        val_4 = val_3.y + val_4;
        val_3.y = val_2.y + val_4;
        return new UnityEngine.Vector3() {x = val_2.x, y = val_3.y, z = val_2.z};
    }

}
