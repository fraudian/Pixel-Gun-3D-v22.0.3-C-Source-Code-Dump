using UnityEngine;
internal class TurretControllerScene : FortEquipObject, 丅丙上七上一丐不下, 万丝丅丗且丒丝丌丟
{
    // Fields
    protected float ignoreTargetRadius;
    protected bool isMainGun;
    protected WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    protected float poisonDamageMultipier;
    protected int poisonHitsCount;
    protected float poisonHitsDelay;
    private bool _slowTarget;
    private float _percentSlow;
    public UnityEngine.AudioClip turretActivSound;
    public UnityEngine.AudioClip turretDeadSound;
    public UnityEngine.AudioClip turretDeactivationSound;
    public UnityEngine.AudioClip hitSound;
    public bool useIdleAnimation;
    public UnityEngine.Renderer turretRenderer;
    public UnityEngine.GameObject explosionAnimObj;
    public UnityEngine.GameObject isEnemySprite;
    public UnityEngine.Transform healthBar;
    public UnityEngine.TextMesh nickLabel;
    public UnityEngine.Material inactiveMaterial;
    public UnityEngine.Animation animation;
    public bool setMaterialsForEnemy;
    public UnityEngine.Material[] enemyMaterials;
    public UnityEngine.GameObject workingSound;
    public UnityEngine.GameObject workingParticle;
    protected bool 丂丛丄丆丐东且一世;
    public bool isEnemyTurret;
    protected float 丈与与丅丌丁丌丙丒;
    protected float 丑一丅丒不丗丂丒丟;
    private int 丕丄丕丑丗东丆与丘;
    private int 丄万丁丛一丘七丁丟;
    private int 丘世丕丟丈丆下三丟;
    private int 丆东丗丁丅专三丗不;
    private int 丞丏七丁不丂不丞与;
    private bool 丒丘且东与世万下丑;
    private UnityEngine.BoxCollider 且丟丅专丕丄丙世丄;
    private bool 丝且三丐丈下丐丂丆;
    public float destroyTurretTime;
    protected string 丆丈丅上丙业丌且丅;
    private bool 丐下丁与一丑丟丛世;
    protected UnityEngine.AudioSource 丞下上且一上丙不丏;
    private string 丐丁世不丘业丙丅丛;
    private int <专业丞不丟专专丐与>k__BackingField;
    protected System.Collections.Generic.Dictionary<丅丙上七上一丐不下, float> 丗七丅东丑下丄七丕;
    private UnityEngine.Material _material;
    private UnityEngine.Material 丛一丂丞丘丂且丙丞;
    private System.Collections.Generic.List<UnityEngine.Renderer> _renderers;
    
    // Properties
    public UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
    public UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
    public UnityEngine.Collider 丝且不七丂世丗下七 { get; }
    public UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
    public bool 丈丐丁不丙东世七丕 { get; }
    public UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
    protected float 丄丗丘丞丄丄丟丑丟 { get; }
    protected float 丝三丂东丌丌世东专 { get; }
    protected float 一丝丏丕丑专丅丞世 { get; }
    public float 丌丆东丘丝丌丆丗世 { get; }
    public float 丒丒一东丘东东丟丄 { get; }
    public float 丙三丅丙丆丏下丐丝 { get; }
    private float 丙丅业丐世世丄丏丑 { get; }
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
        if(this == 0)
        {
                return true;
        }
        
        if(this.isActive == false)
        {
                return true;
        }
        
        if(this.丐下丁与一丑丟丛世 != false)
        {
                return true;
        }
        
        var val_3 = (this.isEnemyTurret == false) ? 1 : 0;
        return true;
    }
    public UnityEngine.Vector3 get_currentTargetVelocity()
    {
        return UnityEngine.Vector3.zero;
    }
    protected float 丌丆万丛万丞丙下三()
    {
        var val_6;
        float val_7;
        val_6 = this;
        val_7 = 80f;
        if(true == 0)
        {
                return (float)val_7;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(137125888 == 0)
        {
                return (float)val_7;
        }
        
        }
        
        bool val_3 = GameConnect.七丂万专且丏丘一丙();
        if(==0)
        {
            goto label_10;
        }
        
        if(val_3 == false)
        {
            goto label_11;
        }
        
        label_13:
        float val_4 = 专丅东丂丘下世业丁();
        goto label_12;
        label_10:
        if(val_3 == true)
        {
            goto label_13;
        }
        
        label_11:
        label_12:
        val_7 = 不七不丈丐万丂丌下() * 不七不丈丐万丂丌下();
        return (float)val_7;
    }
    protected float 丝丟丆上业丒丕上丂()
    {
        return this.丌丆万丛万丞丙下三();
    }
    protected float 丐丕世丂上丐丑东丂()
    {
        if(this == null)
        {
                return 0.15f;
        }
        
        return this.丟一丞丗业三丁上东();
    }
    public float get_SplashRadius()
    {
        if(this == null)
        {
                return 0f;
        }
        
        return this.七与万且专丁丝丘丈();
    }
    public float get_TimeEffect()
    {
        if(this == null)
        {
                return 0f;
        }
        
        if(this.丕丗业丝万上丂且丝() == (-1f))
        {
                return 0f;
        }
        
        if(this != null)
        {
                return this.丕丗业丝万上丂且丝();
        }
        
        return this.丕丗业丝万上丂且丝();
    }
    public float get_IgnoreRadius()
    {
        if(this == null)
        {
                return (float)this.ignoreTargetRadius;
        }
        
        return this.丌不丙与业一丌丞丁();
    }
    private float 不丞丟专丁丆专七七()
    {
        return this.TimeEffect;
    }
    protected virtual void Awake()
    {
        this.且丟丅专丕丄丙世丄 = this.GetComponent<UnityEngine.BoxCollider>();
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
        this.丝丑丑业不丝丗丕丄();
    }
    protected virtual void Start()
    {
        float val_2 = this.丌丆万丛万丞丙下三();
        val_2 = this.丌丆万丛万丞丙下三() * val_2;
        this.丈与与丅丌丁丌丙丒 = val_2;
        this.丑一丅丒不丗丂丒丟 = this.ignoreTargetRadius * this.ignoreTargetRadius;
        if(this.turretRenderer == 0)
        {
                UnityEngine.Debug.LogError(message:  "ERROR turretRenderer is NULL!");
            return;
        }
        
        this.turretRenderer.material.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        丘丛丞且一丅丁丏丐.丙丅丅丆丂一上业丐(不丂丅丁且丆东东丂:  this.transform, 丞下万上三丘上与专:  this);
    }
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        string val_14;
        string val_15;
        Rilisoft.丏丏专丙世丝万丅且 val_16;
        string val_17;
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
        this.丐丁世不丘业丙丅丛 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  丒专丈丛下丒一丒丛).SubategoryLocalizeName(丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  丒专丈丛下丒一丒丛).SubategoryLocalizeName) + " " + System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  136855705)(System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  136855705)) + " ";
        this._slowTarget = false;
        string val_6 = 丆丘丒东且丂与丂丑();
        uint val_7 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_6);
        if(val_7 > (-2045259804))
        {
            goto label_7;
        }
        
        if(val_7 == (-2128831035))
        {
            goto label_8;
        }
        
        if(val_7 == (-2045259804))
        {
            goto label_9;
        }
        
        if(val_7 != 248996601)
        {
                return;
        }
        
        val_14 = "Fire";
        goto label_11;
        label_7:
        if(val_7 > (-1136762671))
        {
            goto label_12;
        }
        
        if(val_7 == (-1889891395))
        {
            goto label_13;
        }
        
        if(val_7 != (-1136762671))
        {
                return;
        }
        
        val_15 = "Poison";
        goto label_15;
        label_12:
        if(val_7 == (-787829914))
        {
            goto label_16;
        }
        
        if(val_7 != (-311913234))
        {
                return;
        }
        
        val_15 = "Poison Area";
        label_15:
        if((System.String.op_Equality(a:  val_6, b:  val_15)) == false)
        {
                return;
        }
        
        val_16 = 1;
        goto label_19;
        label_8:
        if(val_6 == null)
        {
                return;
        }
        
        if(val_6.Length != 0)
        {
                return;
        }
        
        this.poisonType = 0;
        this._slowTarget = false;
        this._percentSlow = 0f;
        return;
        label_9:
        val_17 = "SlowDown";
        goto label_23;
        label_13:
        val_17 = "SlowDown Area";
        label_23:
        if((System.String.op_Equality(a:  val_6, b:  val_17)) == false)
        {
                return;
        }
        
        this._slowTarget = true;
        this._percentSlow = this.三丟丅不丅丅业丛丁();
        return;
        label_16:
        val_14 = "Fire Area";
        label_11:
        if((System.String.op_Equality(a:  val_6, b:  val_14)) == false)
        {
                return;
        }
        
        val_16 = 2;
        label_19:
        this.poisonType = val_16;
        this.poisonDamageMultipier = this.三丟丅不丅丅业丛丁();
    }
    private void OnDisable()
    {
        if(this.animation == 0)
        {
                return;
        }
        
        this.animation.Stop();
    }
    protected virtual void 丗丅世且丛丑业世丑()
    {
    
    }
    protected virtual void 丗丈丘丑丂丆丐业丂()
    {
    
    }
    private void 世万业丐与丏丂丐丏()
    {
        float val_8;
        float val_9;
        int val_10;
        var val_11;
        string val_12;
        if(this.nickLabel == 0)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_6;
        }
        
        label_19:
        if(this.丞丏七丁不丂不丞与 == 1)
        {
            goto label_20;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.blue;
        val_8 = val_3.r;
        val_9 = val_3.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_8, g = val_3.g, b = val_9, a = val_3.a};
        val_10 = 1;
        goto label_9;
        label_6:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_15;
        }
        
        val_11 = null;
        val_11 = null;
        if(SiegeController.三三万丆下一丗万丛.inAttackTeam == false)
        {
            goto label_19;
        }
        
        label_15:
        if(this.丞丏七丁不丂不丞与 == 2)
        {
            goto label_20;
        }
        
        UnityEngine.Color val_6 = UnityEngine.Color.red;
        val_8 = val_6.r;
        val_9 = val_6.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_8, g = val_6.g, b = val_9, a = val_6.a};
        val_10 = 2;
        label_9:
        this.丞丏七丁不丂不丞与 = val_10;
        label_20:
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
            
        }
        else
        {
                val_12 = this.丐丁世不丘业丙丅丛;
        }
        
        this.nickLabel.text = mem[this.丐丁世不丘业丙丅丛];
    }
    protected virtual void 丕丕丞不丆业东下丒()
    {
    
    }
    protected virtual void 丈丞一丈丑丝丈丂丂()
    {
        if(this.useIdleAnimation == false)
        {
                return;
        }
        
        if((UnityEngine.TrackedReference.op_Inequality(x:  this.animation.Item["turret_idle"], y:  0)) == false)
        {
                return;
        }
        
        if((this.animation.IsPlaying(name:  "turret_idle")) != false)
        {
                return;
        }
        
        bool val_4 = this.animation.Play(animation:  "turret_idle");
    }
    protected virtual void 丟丞丆上上丁丅下丐()
    {
    
    }
    protected virtual void Update()
    {
        if((this.setMaterialsForEnemy != false) && (((this.isEnemyTurret == true) ? 1 : 0) != ((this.丝且三丐丈下丐丂丆 == true) ? 1 : 0)))
        {
                this.丝且三丐丈下丐丂丆 = this.isEnemyTurret;
        }
    
    }
    protected virtual void LateUpdate()
    {
    
    }
    protected virtual void 下专专专丄世丗且丐()
    {
        System.Collections.Generic.Dictionary<丅丙上七上一丐不下, System.Single> val_27;
        float val_28;
        bool val_29;
        var val_30;
        var val_31;
        bool val_32;
        val_27 = this;
        if(this.丒丘且东与世万下丑 != true)
        {
                this.丒丘且东与世万下丑 = true;
        }
        
        this.世万业丐与丏丂丐丏();
        if((this.isActive != false) && (this.healthBar != 0))
        {
                if(S8 > 0f)
        {
                float val_3 = this.下丄丝七丑业一专一();
            val_3 = S8 / val_3;
        }
        
            val_28 = 0f;
            this.healthBar.localScale = new UnityEngine.Vector3() {x = val_28, y = 0f, z = 0f};
        }
        
        this.下丌不丑一不万丟万();
        if(this.isEnemySprite != 0)
        {
                val_29 = this.isEnemyTurret;
            var val_6 = (val_29 == true) ? 1 : 0;
            val_6 = this.isEnemySprite.activeSelf ^ val_6;
            if(val_6 != false)
        {
                this.isEnemySprite.SetActive(value:  (val_29 == true) ? 1 : 0);
        }
        
        }
        
        if(val_6 != false)
        {
                if(null != 0)
        {
            goto label_17;
        }
        
        }
        else
        {
                val_30 = 1;
        }
        
        label_17:
        if(this.丐下丁与一丑丟丛世 != false)
        {
                val_31 = 0;
        }
        else
        {
                val_31 = this.isActive;
        }
        
        val_32 = val_31;
        if(val_32 != false)
        {
                if(this.animation == 0)
        {
                val_32 = 1;
        }
        else
        {
                val_32 = (~(this.animation.IsPlaying(name:  "turret_start"))) & 1;
        }
        
        }
        
        this.丂丛丄丆丐东且一世 = val_32;
        if(W9 != 0)
        {
                if(TankController.丄丘七三上丕世丞业.不丝丁丞万丈丆丏万() != false)
        {
                this.丂丛丄丆丐东且一世 = false;
            return;
        }
        
            val_32 = this.丂丛丄丆丐东且一世;
        }
        
        if(val_32 == false)
        {
                return;
        }
        
        丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  TankController.丄丘七三上丕世丞业);
        if(val_29 == 0)
        {
            goto label_65;
        }
        
        if(val_13 == null)
        {
            goto label_64;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        if(val_13.IsDead() == true)
        {
            goto label_64;
        }
        
        UnityEngine.Vector3 val_17 = val_13.position;
        val_28 = -500f;
        if(val_17.y >= 0)
        {
            goto label_43;
        }
        
        label_64:
        mem[1152921540609838560] = 0;
        label_65:
        if(val_13 == 0)
        {
            
        }
        
        double val_19 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_19 = val_19 / (double)this.丘世丕丟丈丆下三丟;
        if(this.丕丄丕丑丗东丆与丘 < (int)val_19)
        {
                this.丕丄丕丑丗东丆与丘 = (int)val_19;
        }
        
        double val_20 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_20 = val_20 / (double)this.丆东丗丁丅专三丗不;
        if(this.丄万丁丛一丘七丁丟 >= (int)val_20)
        {
                return;
        }
        
        this.丄万丁丛一丘七丁丟 = (int)val_20;
        val_27 = this.丗七丅东丑下丄七丕;
        val_27.Clear();
        return;
        label_43:
        if((val_13.CompareTag(tag:  "Player")) == false)
        {
            goto label_65;
        }
        
        SkinName val_22 = val_13.GetComponent<SkinName>();
        if(val_22 == 0)
        {
            goto label_65;
        }
        
        SkinName val_24 = val_22.GetComponent<SkinName>();
        if(val_24.playerMoveC.万万一与丝业七专下 == true)
        {
            goto label_64;
        }
        
        goto label_65;
    }
    private void 下丌不丑一不万丟万()
    {
        var val_3;
        var val_4;
        bool val_5;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_6;
        }
        
        val_4 = null;
        val_4 = null;
        if((this & 1) == 0)
        {
            goto label_14;
        }
        
        val_5 = 1;
        goto label_15;
        label_6:
        label_14:
        val_5 = false;
        label_15:
        this.isEnemyTurret = val_5;
    }
    public override void AttackTargetRPC()
    {
        var val_13 = this;
        if(137125888 == 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        if(this.animation == 0)
        {
                return;
        }
        
        if((UnityEngine.TrackedReference.op_Inequality(x:  this.animation.Item["turret_shoot"], y:  0)) == false)
        {
                return;
        }
        
        bool val_5 = this.animation.Play(animation:  "turret_shoot");
    }
    protected virtual void 丅丙业不丏丟丄丕丝()
    {
    
    }
    protected void 丟丌丞丗丛丘丑不丅(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        var val_12;
        object val_13;
        var val_15;
        var val_19;
        var val_22;
        var val_23;
        WeaponManager val_24;
        val_13 = this;
        if(this._slowTarget == false)
        {
                return;
        }
        
        val_12 = 1152921505066536960;
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_4;
        }
        
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        val_12 = 1152921505352957952;
        float val_12 = this._percentSlow;
        val_12 = 1f - val_12;
        val_15 = null;
        val_13 = val_12;
        val_15 = null;
        goto label_11;
        label_4:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        val_19 = null;
        val_22 = null;
        val_22 = null;
        if(丂丈丙且丈丗三丆丕 != typeof(Player_move_c).__il2cppRuntimeField_600)
        {
            goto label_24;
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_27;
        }
        
        val_24 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_24 == null)
        {
            goto label_28;
        }
        
        label_27:
        与东丁业丁与且丌丕(丞下万上三丘上与专:  typeof(Player_move_c).__il2cppRuntimeField_628.gameObject, 七丏上不丒万丐东丄:  this.TimeEffect, 三上丅丈丄不丌万丙:  1f - this._percentSlow);
        return;
        label_11:
        ApplyDebuffByMode(丁丅丈丌丟世丗丗丟:  0, 丘七丛丂专丅丛业丑:  this.TimeEffect, 业与丑丑丁丝丏丗世:  val_12);
        return;
        label_24:
        val_19 = null;
        var val_9 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_19) ? 丂丈丙且丈丗三丆丕 : 0;
        if(((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_19 ? 丂丈丙且丈丗三丆丕 : 0 + 24.一丝丌丏万丐丌丆东()) == false)
        {
                return;
        }
        
        float val_13 = 1f;
        val_13 = val_13 - this._percentSlow;
        (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_19 ? 丂丈丙且丈丗三丆丕 : 0 + 24.丘一世丘丞丒东丄下(丐丌一丈丒一丕丐丙:  val_13, 丂三丟丂丈丐丆丗丟:  this.TimeEffect);
        return;
        label_28:
    }
    protected bool 三且丆丙丂丘丗丕丙(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        WeaponSounds.丏专丐且丘丌丛不丁 val_16;
        float val_17;
        float val_18;
        var val_20;
        if(丂丈丙且丈丗三丆丕 != null)
        {
                val_17 = this.下与丗丒丐三丕丘丈();
            if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(一丝丌丏万丐丌丆东() != false)
        {
                val_17 = val_17 * FortDefenceLinkController.丄丘七三上丕世丞业.damageBotFromTurretsCoeff;
        }
        
        }
        
            this.丟丌丞丗丛丘丑不丅(丂丈丙且丈丗三丆丕:  丂丈丙且丈丗三丆丕);
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_16 = this.typeDead;
            val_18 = val_5.y;
            var val_16 = 0;
            val_16 = val_16 + 1;
        }
        else
        {
                val_20 = 0;
            return (bool)val_20;
        }
        
        丂丈丙且丈丗三丆丕.ApplyDamage(丞丈专下丈专业三丞:  val_17, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_5.x, y = val_18, z = val_5.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  val_16, 丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), 丒丈丐丐丗丐专丈丏:  0);
        if(this.poisonType != 0)
        {
                float val_10 = this.下与丗丒丐三丕丘丈();
            val_10 = val_10 * this.poisonDamageMultipier;
            this.下丏万七东丐世业丆().丅世丏七丅东丄万一(三一丝且丝丛不丄丐:  this.poisonType, 丞丈专下丈专业三丞:  val_10, 丂丐丈丕丞下丁下丘:  this.poisonHitsDelay, 丂上上不一丐业一丕:  this.poisonHitsCount, 东丏业丞丞业下丄世:  this.typeDead, 丈丁丄丘丛世七丙丝:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), 丌丛丑三丆丘万丘丛:  false);
            val_16 = this.下丏万七东丐世业丆();
            UnityEngine.Vector3 val_15 = this.transform.position;
            val_17 = val_15.x;
            val_18 = val_15.z;
            val_16.丝丙丂丅丘丄丙丂三(世万丘丟丐上世不上:  this, 丂丈丙且丈丗三丆丕:  丂丈丙且丈丗三丆丕, 专不丑且不丏东丟丅:  0, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_17, y = val_15.y, z = val_18});
        }
        
        val_20 = 1;
        return (bool)val_20;
    }
    public void SynchHealth(float 丝三不七丑丏一业丑)
    {
        if(S1 <= 丝三不七丑丏一业丑)
        {
                return;
        }
        
        mem[1152921540610723680] = 丝三不七丑丏一业丑;
    }
    protected System.Collections.IEnumerator 与丅丟三丂丞丟丐丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretControllerScene.丁一丂东丕丕万丗丟();
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
        return this.下丄丝七丑业一专一();
    }
    public virtual void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.丗丘七上丏丌丒七丂();
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  丞丈专下丈专业三丞, 丞丗且下世丐业丌丙:  丒丈丐丐丗丐专丈丏, 丐丟丘世丁三丕专专:  0);
    }
    public virtual bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        var val_7;
        var val_8;
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_3;
        }
        
        label_17:
        val_7 = 0;
        return (bool)val_7;
        label_3:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_7;
        }
        
        val_8 = null;
        val_8 = null;
        if(SiegeController.三三万丆下一丗万丛.attackTeam != 专丞上七七且丝七丗.丘丑丅三丆丑丌且丝())
        {
            goto label_17;
        }
        
        label_7:
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(专丞上七七且丝七丗.一丝丌丏万丐丌丆东() == true)
        {
            goto label_17;
        }
        
        }
        
        val_7 = 1;
        return (bool)val_7;
    }
    public bool IsDead()
    {
        var val_3;
        if(this.isActive != false)
        {
                var val_2 = (this.丐下丁与一丑丟丛世 == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    internal override void 万不丄下丂三丕丒不(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙 = 0, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0)
    {
        UnityEngine.Object val_20;
        int val_21;
        float val_22;
        UnityEngine.Object val_23;
        float val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        val_21 = 丞丗且下世丐业丌丙;
        if(true != 0)
        {
                return;
        }
        
        bool val_20 = this.丐下丁与一丑丟丛世;
        val_20 = val_20 + 3;
        var val_21 = ~val_20;
        val_21 = val_21 & 3;
        if(val_21 != 0)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != val_21)
        {
                this.丗丘七上丏丌丒七丂();
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丞下上且一上丙不丏 != 0)
        {
                this.丞下上且一上丙不丏.PlayOneShot(clip:  this.hitSound);
        }
        
        }
        
        val_22 = 丛业专丘丂丅丗丝丛 - 丛业专丘丂丅丗丝丛;
        mem[1152921540612083680] = val_22;
        val_20 = PhotonView.Find(世上丕丐丈世上不丏:  val_21);
        if(val_20 != 0)
        {
                if((val_20.GetComponent<TankController>()) != 0)
        {
                val_20 = val_7.丆世丙丈一丕丆丞丆;
        }
        else
        {
                val_20 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_20.transform);
        }
        
            if(val_20 != null)
        {
                val_23 = val_20;
        }
        
            val_23 = 0;
            if(val_23 != 0)
        {
                if((this.丗七丅东丑下丄七丕.ContainsKey(key:  val_20)) != true)
        {
                val_22 = 0f;
            this.丗七丅东丑下丄七丕.Add(key:  val_20, value:  val_22);
        }
        
            if(this.丗七丅东丑下丄七丕 != null)
        {
                val_25 = this.丗七丅东丑下丄七丕.Item[val_20];
        }
        else
        {
                float val_16 = 0.Item[val_20];
            val_25 = val_16;
        }
        
            val_16 = val_25 + 丛业专丘丂丅丗丝丛;
            this.丗七丅东丑下丄七丕.set_Item(key:  val_20, value:  val_16);
        }
        
        }
        
        if(val_16 >= 0)
        {
                return;
        }
        
        mem[1152921540612083680] = 0;
        val_26 = 0;
        val_20 = 1152921505286238208;
        val_27 = null;
        val_27 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_690.viewID != val_21)
        {
                return;
        }
        
        val_29 = null;
        val_30 = null;
        val_21 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_21 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        丄一三丄七丞丞丏丒();
    }
    public void MeKillRPC(int 丞丗且下世丐业丌丙)
    {
        var val_3;
        WeaponManager val_8;
        var val_9;
        var val_10;
        val_8 = 丞丗且下世丐业丌丙;
        val_9 = null;
        val_9 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_12:
        if((1645655472 & 1) == 0)
        {
            goto label_4;
        }
        
        if(((X21 + 504) == 0) || ((X21 + 504 + 504.viewID) != val_8))
        {
            goto label_12;
        }
        
        int val_7 = val_3.丐丏七丌丕丗业且上().丘丑丅三丆丑丌且丝();
        val_10 = null;
        val_10 = null;
        val_8 = WeaponManager.丟丗丄业丘丗业丗七;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void MeKill(string 丆丆丂业丒丈丙丒丅, int 与丁丟东丞丙丗丌丈)
    {
    
    }
    public virtual void StartDeactivate(bool 一丆丌丝专丂丛丙上)
    {
        UnityEngine.Animation val_10;
        string val_11;
        if(this.丐下丁与一丑丟丛世 != false)
        {
                return;
        }
        
        this.丐下丁与一丑丟丛世 = true;
        this.丐丐丗丒丂上下万且();
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false) || (this.丞下上且一上丙不丏 == 0))
        {
            goto label_7;
        }
        
        if(一丆丌丝专丂丛丙上 == false)
        {
            goto label_8;
        }
        
        this.丞下上且一上丙不丏.PlayOneShot(clip:  this.turretDeadSound);
        goto label_10;
        label_7:
        if(一丆丌丝专丂丛丙上 == false)
        {
            goto label_11;
        }
        
        label_10:
        if(this.explosionAnimObj != 0)
        {
                this.explosionAnimObj.SetActive(value:  true);
        }
        
        if(this.animation == 0)
        {
            goto label_24;
        }
        
        val_10 = this.animation;
        val_11 = "turret_dead";
        goto label_20;
        label_8:
        this.丞下上且一上丙不丏.PlayOneShot(clip:  this.turretDeactivationSound);
        label_11:
        if(this.animation == 0)
        {
            goto label_24;
        }
        
        val_10 = this.animation;
        val_11 = "turret_stop";
        label_20:
        bool val_6 = val_10.Play(animation:  val_11);
        label_24:
        var val_11 = 0;
        val_11 = val_11 + 1;
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.丙丆丆丞七丁丑丆世(丕丕世且下一与丝与:  this.destroyTurretTime).GetEnumerator());
    }
    public void DeactivateDelayed()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丙丆丆丞七丁丑丆世(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    private System.Collections.IEnumerable 丙丆丆丞七丁丑丆世(float 丕丕世且下一与丝与)
    {
        TurretControllerScene.万丅上丗丕丙七丑与 val_1 = new TurretControllerScene.万丅上丗丕丙七丑与();
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
    public override void Activate()
    {
        int val_19;
        this.Activate();
        this.丐下丁与一丑丟丛世 = false;
        if(this.explosionAnimObj != 0)
        {
                this.explosionAnimObj.SetActive(value:  false);
        }
        
        if(this.nickLabel != 0)
        {
                this.nickLabel.gameObject.SetActive(value:  (W21 == 0) ? 1 : 0);
        }
        
        if(this.且丟丅专丕丄丙世丄 != 0)
        {
                this.且丟丅专丕丄丙世丄.enabled = true;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丞下上且一上丙不丏 != 0)
        {
                this.丞下上且一上丙不丏.PlayOneShot(clip:  this.turretActivSound);
        }
        
        }
        
        val_19 = UnityEngine.LayerMask.NameToLayer(layerName:  "Default");
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.gameObject, 不东丛三丂丌丑专丆:  val_19);
        if(null != 0)
        {
                val_19 = UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider");
            this.gameObject.layer = val_19;
        }
        
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
        
        if(this.animation == 0)
        {
                return;
        }
        
        val_19 = "turret_start";
        if((UnityEngine.TrackedReference.op_Inequality(x:  this.animation.Item["turret_start"], y:  0)) == false)
        {
                return;
        }
        
        bool val_18 = this.animation.Play(animation:  "turret_start");
    }
    public override void Deactivate()
    {
        this.isActive = false;
        mem[1152921540613260960] = 0;
        double val_8 = (double)this.丌七丞七专丘丞世丒();
        val_8 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_8;
        mem[1152921540613260968] = val_8;
        this.丐丐丗丒丂上下万且();
        if(this.animation == 0)
        {
                return;
        }
        
        this.animation.Stop();
        this.animation.Item["turret_dead"].time = this.animation.Item["turret_dead"].length;
        bool val_7 = this.animation.Play(animation:  "turret_dead");
    }
    private void 丐丐丗丒丂上下万且()
    {
        var val_9;
        if(this.丛一丂丞丘丂且丙丞 == 0)
        {
            goto label_3;
        }
        
        this.丛一丂丞丘丂且丙丞.SetFloat(name:  "_Power", value:  0.8f);
        val_9 = 0;
        goto label_5;
        label_9:
        this._renderers.Item[0].sharedMaterial = this.丛一丂丞丘丂且丙丞;
        val_9 = 1;
        label_5:
        if(val_9 < this._renderers.Count)
        {
            goto label_9;
        }
        
        label_3:
        if(this.nickLabel != 0)
        {
                this.nickLabel.gameObject.SetActive(value:  false);
        }
        
        if(this.且丟丅专丕丄丙世丄 != 0)
        {
                this.且丟丅专丕丄丙世丄.enabled = false;
        }
        
        if(this.workingSound != 0)
        {
                this.workingSound.SetActive(value:  false);
        }
        
        if(this.workingParticle == 0)
        {
                return;
        }
        
        this.workingParticle.SetActive(value:  false);
    }
    private void 丗丒丁万丝丙丏丕丙()
    {
    
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        丘丛丞且一丅丁丏丐.丏丄丄东丒世专丌丁(不丂丅丁且丆东东丂:  this.丌丟丄业且三丛丕丄());
    }
    private void 丝丑丑业不丝丗丕丄()
    {
        System.Collections.Generic.List<UnityEngine.Renderer> val_6;
        var val_7;
        val_6 = 1152921504848912384;
        if(this._material == 0)
        {
                return;
        }
        
        UnityEngine.Material val_2 = UnityEngine.Object.Instantiate<UnityEngine.Material>(original:  this._material);
        this.丛一丂丞丘丂且丙丞 = val_2;
        if(val_2 != 0)
        {
                this.丛一丂丞丘丂且丙丞.SetFloat(name:  "_Power", value:  0f);
        }
        
        val_7 = 0;
        goto label_8;
        label_12:
        this._renderers.Item[0].sharedMaterial = this.丛一丂丞丘丂且丙丞;
        val_7 = 1;
        label_8:
        val_6 = this._renderers;
        if(val_7 < val_6.Count)
        {
            goto label_12;
        }
    
    }
    public TurretControllerScene()
    {
        this.poisonDamageMultipier = 0.03f;
        this.poisonHitsCount = 3;
        this.poisonHitsDelay = 1f;
        mem2[0] = ;
        this.destroyTurretTime = 2f;
        this.丗七丅东丑下丄七丕 = new System.Collections.Generic.Dictionary<丅丙上七上一丐不下, System.Single>();
        this._renderers = new System.Collections.Generic.List<UnityEngine.Renderer>();
    }

}
