using UnityEngine;
internal class FortGuardMob : FortEquipObject, 丅丙上七上一丐不下
{
    // Fields
    public float shotDelayForAnimation;
    public float freeWalkSpeed;
    public UnityEngine.AudioClip damageSound;
    public UnityEngine.AudioClip voiceMobSoud;
    public UnityEngine.AudioClip takeDamageSound;
    public UnityEngine.AudioClip deathSound;
    public UnityEngine.AudioClip stepSound;
    public UnityEngine.AudioClip runStepSound;
    private UnityEngine.BoxCollider 丏七东七丝丁丄丐一;
    private UnityEngine.SphereCollider 三丝丌丙丂世丈一丟;
    public UnityEngine.Transform healthBar;
    public UnityEngine.TextMesh nickLabel;
    public UnityEngine.GameObject isEnemySprite;
    private UnityEngine.Events.UnityEvent onRespawnEvent;
    private BotChangeDamageMaterial[] 丗下丛丅与丐与上丐;
    private int 丞丏七丁不丂不丞与;
    private bool 上丞丞丏丂丅专丝丆;
    protected UnityEngine.Animation 且丈丘三丆一丟丌丐;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private UnityEngine.Transform 丟丑丟上丌丒业丌业;
    protected FortGuardMob.丟丒下丙不丙上不丟 丛丏丄业丒与丂世丑;
    private FortGuardMob.丄丂一三丈一丏七且 丂东丌丄且下丁丙一;
    private float 丗丕丑下丒丄丁丘丌;
    private float 丐七不丘丅丁丝丂东;
    private UnityEngine.Coroutine 丂丏丄丈世三丝三下;
    private int <专业丞不丟专专丐与>k__BackingField;
    private bool 丟丗丁上丄丑万世丛;
    private bool 丟丄丒丒业丂东丟丈;
    private bool 三丘丞丛丑丄与丌一;
    public float maxMoveDistance;
    public float TimeStayAfterRespawn;
    public bool flyThrowWalls;
    private UnityEngine.Vector3 上丂丗丆丟丕丛丏且;
    public float flyAngularSpeed;
    private bool 东丄世下丄丁丞丏丕;
    public float flyHeightRandomRange;
    private float 与丌三丞丗世下东丒;
    private UnityEngine.AI.NavMeshAgent 丟丅三丝丄丈万丒三;
    protected FortGuardMob.丙丟与丐三丐万万丆 丏丗丈世丞丁丂不丂;
    private float 三丑丝丞丗丆丅丘丆;
    private float 丈丁丗丐七丅丒下一;
    private const float 丆东丛丑丐七丗丐丄 = 3;
    private float 丒丅与东万丞专丞丈;
    
    // Properties
    public float 三丂丐丙且丟七下丄 { get; }
    public float 丌丅丙丈与丆与丄丑 { get; }
    public float 丟丑东一且丗丘业丆 { get; }
    public float 世丏丝丘七上丐丌七 { get; }
    public float 业丅业下丅且与丕丞 { get; }
    public UnityEngine.Transform 不丘且丘专与丐丄丂 { get; }
    protected UnityEngine.Vector3 丅丟丙且丐三丑丒不 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    private float 专丗且丂万丆丙丟上 { get; set; }
    
    // Methods
    public float get_AttackRate()
    {
        return 0f;
    }
    public float get_runSpeed()
    {
        return BalanceController.丒丘三一与丆一一丙(丆万一不丌且东丐丐:  this);
    }
    public float get_attackRadius()
    {
        return BalanceController.丞丅三丁丄丅丌丌丐(丆万一不丌且东丐丐:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject));
    }
    public float get_detectRadius()
    {
        return BalanceController.不万丅不丆丞与丙七(丆万一不丌且东丐丐:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject));
    }
    public float get_chaseRadius()
    {
        float val_1 = this.detectRadius;
        val_1 = val_1 * 1.3f;
        return (float)val_1;
    }
    public UnityEngine.Transform get_CurrentTarget()
    {
        return (UnityEngine.Transform)this;
    }
    protected virtual void Awake()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  2);
        System.DateTime val_2 = System.DateTime.Now;
        long val_3 = val_2.dateData.Ticks;
        val_3 = val_3 & 65535;
        UnityEngine.Random.seed = val_3;
        this.丏七东七丝丁丄丐一 = this.GetComponentInChildren<UnityEngine.BoxCollider>(includeInactive:  true);
        this.三丝丌丙丂世丈一丟 = this.GetComponentInChildren<UnityEngine.SphereCollider>(includeInactive:  true);
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
        this.丛丏丄业丒与丂世丑 = new FortGuardMob.丟丒下丙不丙上不丟();
        UnityEngine.Animation val_8 = this.GetComponentInChildren<UnityEngine.Animation>();
        this.且丈丘三丆一丟丌丐 = val_8;
        val_8.Stop();
        this.丗下丛丅与丐与上丐 = this.GetComponentsInChildren<BotChangeDamageMaterial>();
        this.丟丑丟上丌丒业丌业 = this.transform.parent;
        if(this.shotDelayForAnimation > this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄].length)
        {
                this.shotDelayForAnimation = this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄].length;
        }
        
        this.世下丛丁专丞丆业上();
    }
    protected UnityEngine.Vector3 万丈且与七下上不专()
    {
        UnityEngine.BoxCollider val_10;
        float val_11;
        float val_12;
        float val_13;
        if(this.丏七东七丝丁丄丐一 != 0)
        {
                UnityEngine.Vector3 val_3 = this.丏七东七丝丁丄丐一.transform.position;
            val_10 = this.丏七东七丝丁丄丐一;
            val_11 = val_3.x;
            val_12 = val_3.y;
            val_13 = val_3.z;
            UnityEngine.Vector3 val_4 = val_10.center;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        
        if(this.三丝丌丙丂世丈一丟 != 0)
        {
                UnityEngine.Vector3 val_7 = this.三丝丌丙丂世丈一丟.transform.position;
            val_10 = this.三丝丌丙丂世丈一丟;
            val_11 = val_7.x;
            val_12 = val_7.y;
            val_13 = val_7.z;
            UnityEngine.Vector3 val_8 = val_10.center;
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        
        UnityEngine.Transform val_9 = this.transform;
        if(val_9 != null)
        {
                return val_9.position;
        }
        
        return val_9.position;
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  2);
    }
    protected virtual void Update()
    {
        float val_5;
        this.世万业丐与丏丂丐丏();
        if((true != 0) && (this.healthBar != 0))
        {
                if(S8 > 0f)
        {
                float val_2 = this.下丄丝七丑业一专一();
            val_2 = S8 / val_2;
        }
        
            val_5 = 0f;
            this.healthBar.localScale = new UnityEngine.Vector3() {x = val_5, y = 0f, z = 0f};
        }
        
        if(this.丗丕丑下丒丄丁丘丌 > 0f)
        {
                val_5 = this.丗丕丑下丒丄丁丘丌 - UnityEngine.Time.deltaTime;
            this.丗丕丑下丒丄丁丘丌 = val_5;
        }
        
        if(this.丐七不丘丅丁丝丂东 > 0f)
        {
                float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.丐七不丘丅丁丝丂东 - val_4;
            this.丐七不丘丅丁丝丂东 = val_4;
        }
        
        this.丝专专与丞丝丟丅不();
    }
    public override void Activate()
    {
        this.Activate();
        this.七丅丘七丁七丌丗丅();
        this.SetActiveNavMeshAgent(丛丅丘一丏丙且丌上:  false);
        this.SetActiveNavMeshAgent(丛丅丘一丏丙且丌上:  true);
    }
    private void 七丅丘七丁七丌丗丅()
    {
        if(this.onRespawnEvent != null)
        {
                this.onRespawnEvent.Invoke();
        }
        
        UnityEngine.Vector3 val_1 = this.丏且丕丞丗下丛丒丒();
        this.transform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        mem2[0] = 0;
        this.丏七东七丝丁丄丐一.enabled = true;
        this.三丝丌丙丂世丈一丟.enabled = true;
        this.丈丁丗丐七丅丒下一 = 0f;
        float val_5 = UnityEngine.Time.time;
        val_5 = this.TimeStayAfterRespawn + val_5;
        this.三丑丝丞丗丆丅丘丆 = val_5;
        this.丂东丌丄且下丁丙一 = 0;
        this.一丙东丟丅丄丕丆东();
    }
    private void 一丙东丟丅丄丕丆东()
    {
        EnemyPortal val_1 = EnemyPortalStackController.丄丞丁丈与业上丞丟.GetPortal();
        if(val_1 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.gameObject.transform.position;
        UnityEngine.Vector3 val_8 = this.gameObject.transform.up;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_1.Show(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
    }
    private UnityEngine.Vector3 丏且丕丞丗下丛丒丒()
    {
        if(this.丟丑丟上丌丒业丌业 != null)
        {
                return this.丟丑丟上丌丒业丌业.position;
        }
        
        return this.丟丑丟上丌丒业丌业.position;
    }
    internal override void 万不丄下丂三丕丒不(float 丞丈专下丈专业三丞, int 丞丗且下世丐业丌丙 = 0, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0)
    {
        Player_move_c val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丅业下不东丗丄与三;
        丞丈专下丈专业三丞 = 丞丈专下丈专业三丞 - 丞丈专下丈专业三丞;
        mem[1152921526043974944] = 丞丈专下丈专业三丞;
        if(val_6 != 21)
        {
                if(val_6 != 2)
        {
            goto label_4;
        }
        
        }
        
        this.StartCoroutine(routine:  this.上与丙丒丂丞丒丄丌(万东丏丌不七东丘万:  false)).丙业世丐丟丏丂丐一(丅丘丛丒丒丑丟三丛:  false);
        label_4:
        if(丞丈专下丈专业三丞 >= 0)
        {
            goto label_5;
        }
        
        this.PrepareDeath(业一丘不万丂七上丝:  false);
        val_7 = null;
        val_7 = null;
        val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_6 == 0)
        {
            goto label_23;
        }
        
        val_8 = null;
        val_8 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_690.viewID != 丞丗且下世丐业丌丙)
        {
            goto label_23;
        }
        
        val_9 = null;
        val_9 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  107, 专上丝且丂世丛丝丒:  1f);
        goto label_23;
        label_5:
        this.丌丅丐丄丆丞丄业丑(丕丗丗丂丕业与丄七:  丞丗且下世丐业丌丙);
        label_23:
        this.TryPlayDamageSound(丕丕世且下一与丝与:  this.damageSound.length);
    }
    private void 丙业世丐丟丏丂丐一(bool 丅丘丛丒丒丑丟三丛)
    {
    
    }
    public override void SetDestinationRPC(UnityEngine.Vector3 丁丆丈丂上丙丈丙万, float 东丗上东丘丄东丘世)
    {
        this.SetDestination(丙七丟丏丅丘丈丁丄:  new UnityEngine.Vector3() {x = 丁丆丈丂上丙丈丙万.x, y = 丁丆丈丂上丙丈丙万.y, z = 丁丆丈丂上丙丈丙万.z}, 东丗上东丘丄东丘世:  this.freeWalkSpeed, 丒丗丂丅丑丌丗丄三:  false);
    }
    public void PrepareDeath(bool 业一丘不万丂七上丝 = True)
    {
        float val_11;
        float val_1 = this.deathSound.length;
        val_11 = val_1;
        this.TryPlayDeathSound(丕丕世且下一与丝与:  val_1);
        if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁])) != false)
        {
                this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁);
            val_11 = UnityEngine.Mathf.Max(a:  val_11, b:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁].length);
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.七下下丗丕且万与丅(丕丕世且下一与丝与:  val_11));
        this.丏七东七丝丁丄丐一.enabled = false;
        if(this.三丝丌丙丂世丈一丟 == 0)
        {
                return;
        }
        
        this.三丝丌丙丂世丈一丟.enabled = false;
    }
    private System.Collections.IEnumerator 七下下丗丕且万与丅(float 丕丕世且下一与丝与)
    {
        FortGuardMob.世丘且丛丛丈丗上丗 val_1 = new FortGuardMob.世丘且丛丛丈丗上丗();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丟丘一丄一东且丐丗(bool 丞七丛与丝下一一丆, bool 丌丒丕丄丑丌世不丐 = False)
    {
        BotChangeDamageMaterial[] val_2;
        var val_3;
        val_2 = this.丗下丛丅与丐与上丐;
        if(val_2 == null)
        {
                return;
        }
        
        if(this.丗下丛丅与丐与上丐.Length == 0)
        {
                return;
        }
        
        val_3 = 0;
        goto label_2;
        label_10:
        BotChangeDamageMaterial val_2 = this.丗下丛丅与丐与上丐[0];
        if(val_2 == null)
        {
            goto label_5;
        }
        
        if(丞七丛与丝下一一丆 == false)
        {
            goto label_6;
        }
        
        label_8:
        val_2.ShowDamageEffect(万东丏丌不七东丘万:  丌丒丕丄丑丌世不丐, 丗与丟上上丑专世丗:  0);
        goto label_7;
        label_5:
        if(丞七丛与丝下一一丆 == true)
        {
            goto label_8;
        }
        
        label_6:
        val_2.ResetMainMaterial();
        label_7:
        val_2 = this.丗下丛丅与丐与上丐;
        val_3 = 1;
        label_2:
        if(val_3 < this.丗下丛丅与丐与上丐.Length)
        {
            goto label_10;
        }
    
    }
    private System.Collections.IEnumerator 上与丙丒丂丞丒丄丌(bool 万东丏丌不七东丘万)
    {
        FortGuardMob.丝业三丙丑丞丂三与 val_1 = new FortGuardMob.丝业三丙丑丞丂三与();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .万东丏丌不七东丘万 = 万东丏丌不七东丘万;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 世万业丐与丏丂丐丏()
    {
        int val_12;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        int val_17;
        var val_18;
        var val_19;
        val_12 = 1152921504848912384;
        if(this.nickLabel == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(SiegeController.三三万丆下一丗万丛 == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(SiegeController.三三万丆下一丗万丛.inAttackTeam == false)
        {
            goto label_12;
        }
        
        if(this.丞丏七丁不丂不丞与 == 2)
        {
            goto label_16;
        }
        
        UnityEngine.Color val_4 = UnityEngine.Color.red;
        val_15 = val_4.r;
        val_16 = val_4.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_15, g = val_4.g, b = val_16, a = val_4.a};
        val_17 = 2;
        goto label_15;
        label_12:
        if(this.丞丏七丁不丂不丞与 == 1)
        {
            goto label_16;
        }
        
        UnityEngine.Color val_5 = UnityEngine.Color.blue;
        val_15 = val_5.r;
        val_16 = val_5.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_15, g = val_5.g, b = val_16, a = val_5.a};
        val_17 = 1;
        label_15:
        this.丞丏七丁不丂不丞与 = val_17;
        label_16:
        if(this.isEnemySprite == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_12 = SiegeController.三三万丆下一丗万丛;
        if(this.isEnemySprite.activeSelf ^ val_12.inAttackTeam == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        this.isEnemySprite.SetActive(value:  SiegeController.三三万丆下一丗万丛.inAttackTeam);
    }
    public bool IsReadyToAttackByAnimation()
    {
        return (bool)(this.丗丕丑下丒丄丁丘丌 <= 0f) ? 1 : 0;
    }
    public bool IsReadyToAttackByRate()
    {
        return (bool)(this.丐七不丘丅丁丝丂东 <= 0f) ? 1 : 0;
    }
    protected bool 丘丌且丆丘丏丏与丛()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = val_1.position;
        UnityEngine.Vector3 val_3 = val_1.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        float val_6 = this.attackRadius;
        val_6 = val_6 * val_6;
        return (bool)((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) <= val_6) ? 1 : 0;
    }
    public virtual bool IsCanAttackCurrentTarget()
    {
        return false;
    }
    public void AttackCurrentTarget()
    {
        if(this.丂丏丄丈世三丝三下 != null)
        {
                return;
        }
        
        this.丐七不丘丅丁丝丂东 = 0f;
        this.丂丏丄丈世三丝三下 = this.StartCoroutine(routine:  this.丗丈业丝与丁世与丏());
    }
    private System.Collections.IEnumerator 丗丈业丝与丁世与丏()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortGuardMob.下不丁丐丞丑世万丄();
    }
    public virtual void Shot()
    {
    
    }
    public void OrientToTarget(UnityEngine.Vector3 丙丌丛丘丗与一专丁)
    {
        this.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = 丙丌丛丘丗与一专丁.x, y = 丙丌丛丘丗与一专丁.y, z = 丙丌丛丘丗与一专丁.z});
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
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  丞丈专下丈专业三丞, 丞丗且下世丐业丌丙:  丒丈丐丐丗丐专丈丏, 丐丟丘世丁三丕专专:  丐丟丘世丁三丕专专);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        null = null;
        return (bool)(SiegeController.三三万丆下一丗万丛.attackTeam == 专丞上七七且丝七丗.丘丑丅三丆丑丌且丝()) ? 1 : 0;
    }
    public bool IsDead()
    {
        return (bool)(S0 <= 0f) ? 1 : 0;
    }
    public bool get_isLivingTarget()
    {
        return true;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public void PlayAnimationIdle()
    {
        if(this.丂东丌丄且下丁丙一 == 6)
        {
                return;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丈丒丟上七丝且业丅])) != false)
        {
                this.丂东丌丄且下丁丙一 = 6;
            this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丈丒丟上七丝且业丅);
        }
        
        this.StopSteps();
    }
    public void PlayAnimationWalk()
    {
        if(this.丂东丌丄且下丁丙一 == 1)
        {
                return;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.业业丙下丕业东业丑])) != false)
        {
                this.丂东丌丄且下丁丙一 = 1;
            this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.业业丙下丕业东业丑);
        }
        
        this.PlayWalkStepSound();
    }
    public void PlayAnimationZombieRun()
    {
        if(this.丂东丌丄且下丁丙一 == 2)
        {
                return;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丄丄丛万丁丐丐与丏])) != false)
        {
                this.丂东丌丄且下丁丙一 = 2;
            this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丄丄丛万丁丐丐与丏);
        }
        
        this.PlayRunStepSound();
    }
    public void PlayAnimationZombieAttack()
    {
        this.丗丕丑下丒丄丁丘丌 = this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄].length;
        if(this.丂东丌丄且下丁丙一 == 5)
        {
                return;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄])) != false)
        {
                this.丂东丌丄且下丁丙一 = 5;
            this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄);
        }
        
        this.StopSteps();
    }
    public void ResetAnimationState()
    {
        this.丂东丌丄且下丁丙一 = 0;
    }
    public void TryPlayAudioClip(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
    {
        UnityEngine.AudioSource val_4;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_4 = this.丞下上且一上丙不丏;
        if(val_4 == 0)
        {
                return;
        }
        
        if(丆与丈丏丟七丁东丛 == 0)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.PlayOneShot(clip:  丆与丈丏丟七丁东丛);
    }
    public void PlayVoiceSound()
    {
        this.TryPlayAudioClip(丆与丈丏丟七丁东丛:  this.voiceMobSoud);
    }
    public void PlayWalkStepSound()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.stepSound == 0)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏.clip == this.stepSound)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.loop = true;
        this.丞下上且一上丙不丏.clip = this.stepSound;
        this.丞下上且一上丙不丏.Play();
    }
    public void PlayRunStepSound()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.runStepSound == 0)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏.clip == this.runStepSound)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.loop = true;
        this.丞下上且一上丙不丏.clip = this.runStepSound;
        this.丞下上且一上丙不丏.Play();
    }
    public void StopSteps()
    {
        UnityEngine.Object val_6;
        if(this.stepSound == 0)
        {
                return;
        }
        
        val_6 = this.丞下上且一上丙不丏.clip;
        if(val_6 != this.stepSound)
        {
                val_6 = this.丞下上且一上丙不丏.clip;
            if(val_6 != this.runStepSound)
        {
                return;
        }
        
        }
        
        this.丞下上且一上丙不丏.Pause();
        this.丞下上且一上丙不丏.clip = 0;
    }
    public void TryPlayDeathSound(float 丕丕世且下一与丝与)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏 == 0)
        {
                return;
        }
        
        if((this.万丏丝不三丘丄丅丞(丑丄一丝世业专丛不:  丕丕世且下一与丝与)) == false)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.PlayOneShot(clip:  this.deathSound);
    }
    public void TryPlayDamageSound(float 丕丕世且下一与丝与)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏 == 0)
        {
                return;
        }
        
        if(this.丟丄丒丒业丂东丟丈 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.不万世丁丟且丞丝不(丑丄一丝世业专丛不:  丕丕世且下一与丝与));
        this.丞下上且一上丙不丏.PlayOneShot(clip:  this.damageSound);
    }
    public void TryPlayHitSound(float 丕丕世且下一与丝与)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏 == 0)
        {
                return;
        }
        
        if(this.丟丗丁上丄丑万世丛 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.专丂丈与丞东丝丂丈(丑丄一丝世业专丛不:  丕丕世且下一与丝与));
        this.丞下上且一上丙不丏.PlayOneShot(clip:  this.takeDamageSound);
    }
    private System.Collections.IEnumerator 专丂丈与丞东丝丂丈(float 丑丄一丝世业专丛不)
    {
        FortGuardMob.三世丑丆丂丄丘丒丂 val_1 = new FortGuardMob.三世丑丆丂丄丘丒丂();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丑丄一丝世业专丛不 = 丑丄一丝世业专丛不;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 不万世丁丟且丞丝不(float 丑丄一丝世业专丛不)
    {
        FortGuardMob.一不丗业丘丐且丁专 val_1 = new FortGuardMob.一不丗业丘丐且丁专();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丑丄一丝世业专丛不 = 丑丄一丝世业专丛不;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丁万业丛丒三业七三(float 丑丄一丝世业专丛不)
    {
        FortGuardMob.丂上世三丕丆丞专丗 val_1 = new FortGuardMob.丂上世三丕丆丞专丗();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丑丄一丝世业专丛不 = 丑丄一丝世业专丛不;
        return (System.Collections.IEnumerator)val_1;
    }
    private bool 万丏丝不三丘丄丅丞(float 丑丄一丝世业专丛不)
    {
        var val_3;
        if(this.三丘丞丛丑丄与丌一 != false)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丁万业丛丒三业七三(丑丄一丝世业专丛不:  丑丄一丝世业专丛不));
        val_3 = 1;
        return (bool)val_3;
    }
    private void 丆与丄东丈丁不丌七(float 丙业与丙丗丝不丈东)
    {
        if(this.flyThrowWalls != false)
        {
                this.与丌三丞丗世下东丒 = 丙业与丙丗丝不丈东;
            return;
        }
        
        this.丟丅三丝丄丈万丒三.speed = 丙业与丙丗丝不丈东;
    }
    private float 丗丌世万丑专下丟丕()
    {
        if(this.flyThrowWalls != false)
        {
                return (float)this.与丌三丞丗世下东丒;
        }
        
        if(this.丟丅三丝丄丈万丒三 != null)
        {
                return this.丟丅三丝丄丈万丒三.speed;
        }
        
        return this.丟丅三丝丄丈万丒三.speed;
    }
    private void 丞丒专丕业丝与与丗()
    {
        float val_2 = this.runSpeed;
        if(this.丗丌世万丑专下丟丕() < 0)
        {
                this.PlayAnimationWalk();
            return;
        }
        
        this.PlayAnimationZombieRun();
    }
    private void 世下丛丁专丞丆业上()
    {
        this.丟丅三丝丄丈万丒三 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.丆与丄东丈丁不丌七(丙业与丙丗丝不丈东:  this.freeWalkSpeed);
        this.丏丗丈世丞丁丂不丂 = 0;
    }
    public void SetActiveNavMeshAgent(bool 丛丅丘一丏丙且丌上)
    {
        if(this.flyThrowWalls != false)
        {
                this.东丄世下丄丁丞丏丕 = 丛丅丘一丏丙且丌上;
            return;
        }
        
        if(this.丟丅三丝丄丈万丒三 == 0)
        {
                return;
        }
        
        this.丟丅三丝丄丈万丒三.enabled = 丛丅丘一丏丙且丌上;
    }
    public void ResetNavigation()
    {
        this.丈丁丗丐七丅丒下一 = 0f;
        float val_1 = UnityEngine.Time.time;
        val_1 = this.TimeStayAfterRespawn + val_1;
        this.三丑丝丞丗丆丅丘丆 = val_1;
    }
    public void Disable()
    {
        this.丏丗丈世丞丁丂不丂 = 0;
    }
    private void 丝专专与丞丝丟丅不()
    {
        if(this.flyThrowWalls == false)
        {
            goto label_1;
        }
        
        if(this.东丄世下丄丁丞丏丕 == true)
        {
            goto label_6;
        }
        
        goto label_10;
        label_1:
        if(this.丟丅三丝丄丈万丒三 != 0)
        {
                if((this.丟丅三丝丄丈万丒三.enabled == false) || (this.丟丅三丝丄丈万丒三.isOnNavMesh == false))
        {
            goto label_10;
        }
        
        }
        
        label_6:
        this.丞丟丌丏万丗丄上丕();
        this.丒丑丑丅丁丐业东丑();
        return;
        label_10:
        this.丏丗丈世丞丁丂不丂 = 0;
    }
    private void 丞丟丌丏万丗丄上丕()
    {
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        float val_34;
        float val_35;
        var val_36;
        丙丟与丐三丐万万丆 val_37;
        if(this.丗丕丑下丒丄丁丘丌 > 0f)
        {
                return;
        }
        
        if((this.丗丕丑下丒丄丁丘丌 <= 0f) || (true == 0))
        {
            goto label_9;
        }
        
        val_27 = null;
        val_27 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_9;
        }
        
        val_28 = null;
        val_28 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_618 != 0)
        {
            goto label_16;
        }
        
        label_9:
        this.丏丗丈世丞丁丂不丂 = 0;
        return;
        label_16:
        if(typeof(Player_move_c).__il2cppRuntimeField_618 == 0)
        {
            goto label_25;
        }
        
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_25;
        }
        
        val_30 = null;
        val_30 = null;
        val_31 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  typeof(Player_move_c).__il2cppRuntimeField_378);
        goto label_32;
        label_25:
        val_31 = 0;
        label_32:
        if(X21 == 0)
        {
            goto label_35;
        }
        
        val_32 = null;
        val_32 = null;
        if((FortEquipmentController.丝丘丞不丂丆不丘且 + 24.isMine) != false)
        {
                this.丈丁丗丐七丅丒下一 = 0f;
        }
        
        if(((FortEquipmentController.丝丘丞不丂丆不丘且 + 24.GetComponent<SkinName>()) == 0) || (val_8.playerMoveC.万丝一万丐且丌业丛 == false))
        {
            goto label_47;
        }
        
        float val_10 = this.丞与丂丂丏丏且丑丐(丞下万上三丘上与专:  0);
        label_86:
        if((val_31 & 1) == 0)
        {
            goto label_75;
        }
        
        float val_11 = UnityEngine.Time.time;
        if(this.丒丅与东万丞专丞丈 >= 0)
        {
            goto label_75;
        }
        
        val_33 = null;
        val_33 = null;
        val_31.SendRemoveTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  typeof(Player_move_c).__il2cppRuntimeField_628 + 496.viewID, 丏与丅下丞丗与七下:  0);
        float val_13 = UnityEngine.Time.time;
        val_13 = val_13 + 3f;
        this.丒丅与东万丞专丞丈 = val_13;
        goto label_75;
        label_35:
        float val_14 = this.丄丟丅专丘下丕不三();
        if(val_14 < 0)
        {
            goto label_66;
        }
        
        val_34 = this.attackRadius * this.attackRadius;
        if(val_14 > val_34)
        {
            goto label_61;
        }
        
        float val_16 = UnityEngine.Time.time;
        if(this.丒丅与东万丞专丞丈 < 0)
        {
            goto label_62;
        }
        
        label_61:
        val_35 = this.detectRadius * this.detectRadius;
        if(val_14 > val_35)
        {
            goto label_66;
        }
        
        float val_18 = UnityEngine.Time.time;
        if(this.丒丅与东万丞专丞丈 >= 0)
        {
            goto label_66;
        }
        
        label_62:
        val_36 = null;
        val_36 = null;
        SendSetTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  typeof(Player_move_c).__il2cppRuntimeField_628 + 496.viewID, 丏与丅下丞丗与七下:  0);
        float val_20 = UnityEngine.Time.time;
        val_20 = val_20 + 3f;
        this.丒丅与东万丞专丞丈 = val_20;
        return;
        label_66:
        float val_21 = UnityEngine.Time.time;
        if(this.三丑丝丞丗丆丅丘丆 >= 0)
        {
            goto label_75;
        }
        
        val_37 = 2;
        goto label_79;
        label_75:
        val_37 = 1;
        goto label_79;
        label_47:
        if((this & 1) == 0)
        {
            goto label_78;
        }
        
        val_37 = 4;
        goto label_79;
        label_78:
        float val_22 = this.丞与丂丂丏丏且丑丐(丞下万上三丘上与专:  typeof(FortGuardMob).__il2cppRuntimeField_2D0);
        float val_23 = this.detectRadius;
        val_23 = val_23 * val_23;
        if(val_22 <= val_23)
        {
            goto label_82;
        }
        
        if((this.丏丗丈世丞丁丂不丂 - 3) > 1)
        {
            goto label_86;
        }
        
        float val_26 = 1.3f;
        val_26 = this.detectRadius * val_26;
        val_26 = val_26 * val_26;
        if(val_22 > val_26)
        {
            goto label_86;
        }
        
        label_82:
        val_37 = 3;
        label_79:
        this.丏丗丈世丞丁丂不丂 = val_37;
    }
    private void 丒丑丑丅丁丐业东丑()
    {
        if(this.丏丗丈世丞丁丂不丂 > 4)
        {
                return;
        }
        
        var val_4 = 106037732 + (this.丏丗丈世丞丁丂不丂) << 2;
        val_4 = val_4 + 106037732;
        goto (106037732 + (this.丏丗丈世丞丁丂不丂) << 2 + 106037732);
    }
    private void 且丟世上丆丟丛丁丗()
    {
        float val_29;
        double val_30;
        double val_31;
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.上丂丗丆丟丕丛丏且, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_5 = this.transform.forward;
        float val_29 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_8 = this.transform.forward;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.上丂丗丆丟丕丛丏且, y = val_5.y, z = val_5.x}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, rhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_29 = (val_12.y < 0) ? (-val_29) : (val_29);
        float val_14 = UnityEngine.Mathf.Sign(f:  val_29);
        val_14 = (this.flyAngularSpeed * UnityEngine.Time.deltaTime) * val_14;
        val_29 = System.Math.Abs(val_29);
        float val_16 = (System.Math.Abs(val_14) > val_29) ? (val_29) : (val_14);
        val_30 = 0.1;
        val_31 = (double)System.Math.Abs(val_16);
        if(val_31 > val_30)
        {
                val_30 = 0f;
            val_29 = 0f;
            val_31 = val_16;
            this.transform.Rotate(xAngle:  val_30, yAngle:  val_31, zAngle:  val_29);
        }
        
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
        UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.AngleAxis(angle:  val_16 - val_29, axis:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Vector3 val_21 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Transform val_22 = this.transform;
        UnityEngine.Vector3 val_23 = val_22.position;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  this.丗丌世万丑专下丟丕());
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        val_22.position = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
    }
    private float 丄丟丅专丘下丕不三()
    {
        var val_10;
        var val_11;
        var val_12;
        float val_13;
        var val_14;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        val_12 = 1152921504848912384;
        val_13 = -1f;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return (float)val_13;
        }
        
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
                return (float)val_13;
        }
        
        if(typeof(Player_move_c).__il2cppRuntimeField_618 == 0)
        {
                return (float)val_13;
        }
        
        val_12 = typeof(Player_move_c).__il2cppRuntimeField_618.丘丑丅三丆丑丌且丝();
        val_14 = null;
        val_14 = null;
        if(val_12 != SiegeController.三三万丆下一丗万丛.attackTeam)
        {
                return (float)val_13;
        }
        
        UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_10 = this.transform;
        UnityEngine.Vector3 val_8 = val_10.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_13 = val_9.x;
        return (float)val_13;
    }
    private float 丞与丂丂丏丏且丑丐(UnityEngine.Transform 丞下万上三丘上与专)
    {
        if(丞下万上三丘上与专 == 0)
        {
                return (float)val_5.x;
        }
        
        UnityEngine.Vector3 val_2 = 丞下万上三丘上与专.position;
        this = this.transform;
        UnityEngine.Vector3 val_4 = this.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        return (float)val_5.x;
    }
    private void 一丐丁丙丝世丌丌丄()
    {
        var val_12;
        float val_13;
        float val_16;
        float val_18;
        val_12 = null;
        val_12 = null;
        if((FortEquipmentController.丝丘丞不丂丆不丘且 + 24.isMine) == false)
        {
                return;
        }
        
        val_13 = this.丈丁丗丐七丅丒下一;
        if(val_13 > UnityEngine.Time.time)
        {
                return;
        }
        
        this.专丙且七丝丏丞丌下();
        UnityEngine.Vector3 val_4 = this.transform.position;
        val_16 = val_4.z;
        float val_7 = val_4.x + (UnityEngine.Random.Range(min:  -this.maxMoveDistance, max:  this.maxMoveDistance));
        val_4.z = val_16 + (UnityEngine.Random.Range(min:  -this.maxMoveDistance, max:  this.maxMoveDistance));
        val_13 = 0f;
        val_18 = 0f;
        if(this.flyThrowWalls != false)
        {
                if((UnityEngine.AI.NavMesh.SamplePosition(sourcePosition:  new UnityEngine.Vector3() {x = val_13, y = 0f, z = val_18}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f}, maxDistance:  100f, areaMask:  0)) != false)
        {
            
        }
        else
        {
                UnityEngine.Vector3 val_10 = this.transform.position;
        }
        
            val_16 = val_10.y;
            float val_12 = this.flyHeightRandomRange;
            val_13 = val_10.x;
            val_18 = val_10.z;
            val_12 = val_16 + (UnityEngine.Random.Range(min:  0f, max:  val_12));
        }
        
        this.丑丐丒上丒丏丙与与(不七丕丐丟一丆上三:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_18}, 东丗上东丘丄东丘世:  this.freeWalkSpeed);
    }
    private void 丑丐丒上丒丏丙与与(UnityEngine.Vector3 不七丕丐丟一丆上三, float 东丗上东丘丄东丘世)
    {
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = val_2.position;
        float val_4 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 不七丕丐丟一丆上三.x, y = 不七丕丐丟一丆上三.y, z = 不七丕丐丟一丆上三.z});
        val_4 = val_4 / 东丗上东丘丄东丘世;
        val_4 = UnityEngine.Time.time + val_4;
        this.丈丁丗丐七丅丒下一 = val_4;
        val_2.SendSetDestinationRPC(上世万世丐丄上丑丆:  this, 丙七丟丏丅丘丈丁丄:  new UnityEngine.Vector3() {x = 不七丕丐丟一丆上三.x, y = 不七丕丐丟一丆上三.y, z = 不七丕丐丟一丆上三.z}, 东丗上东丘丄东丘世:  东丗上东丘丄东丘世);
    }
    public void SetDestination(UnityEngine.Vector3 丙七丟丏丅丘丈丁丄, float 东丗上东丘丄东丘世, bool 丒丗丂丅丑丌丗丄三 = False)
    {
        this.丆与丄东丈丁不丌七(丙业与丙丗丝不丈东:  东丗上东丘丄东丘世);
        if(this.flyThrowWalls == false)
        {
            goto label_0;
        }
        
        this.上丂丗丆丟丕丛丏且 = 丙七丟丏丅丘丈丁丄;
        mem[1152921526051805096] = 丙七丟丏丅丘丈丁丄.y;
        mem[1152921526051805100] = 丙七丟丏丅丘丈丁丄.z;
        if(丒丗丂丅丑丌丗丄三 == true)
        {
                return;
        }
        
        label_5:
        if((1 & 1) == 0)
        {
            goto label_2;
        }
        
        if(this.flyThrowWalls == true)
        {
                return;
        }
        
        this.OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = 丙七丟丏丅丘丈丁丄.x, y = 丙七丟丏丅丘丈丁丄.y, z = 丙七丟丏丅丘丈丁丄.z});
        return;
        label_0:
        bool val_1 = this.丟丅三丝丄丈万丒三.SetDestination(target:  new UnityEngine.Vector3() {x = 丙七丟丏丅丘丈丁丄.x, y = 丙七丟丏丅丘丈丁丄.y, z = 丙七丟丏丅丘丈丁丄.z});
        if(丒丗丂丅丑丌丗丄三 == false)
        {
            goto label_5;
        }
        
        return;
        label_2:
        this.丈丁丗丐七丅丒下一 = 0f;
    }
    private void 丂下专一万丗丗丙下()
    {
        if(137129984 == 0)
        {
                return;
        }
        
        if(this.flyThrowWalls != false)
        {
                UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = val_2.position;
            UnityEngine.Vector3 val_4 = val_2.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = val_2.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.9f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = 0f, z = val_5.z}, d:  this.attackRadius + (-0.1f));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        }
        else
        {
                UnityEngine.Vector3 val_14 = position;
        }
        
        this.SetDestination(丙七丟丏丅丘丈丁丄:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, 东丗上东丘丄东丘世:  this.runSpeed, 丒丗丂丅丑丌丗丄三:  true);
    }
    private void 专丙万专丅丕世上丘()
    {
        if(137129984 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_4 = this.transform.position;
        this.OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_2.x, y = val_4.y, z = val_2.z});
        if(this.丗丕丑下丒丄丁丘丌 > 0f)
        {
                return;
        }
        
        this.专丙且七丝丏丞丌下();
        if(this.丐七不丘丅丁丝丂东 > 0f)
        {
                this.PlayAnimationIdle();
            return;
        }
        
        this.PlayAnimationZombieAttack();
        this.AttackCurrentTarget();
    }
    private void 丌丅丐丄丆丞丄业丑(int 丕丗丗丂丕业与丄七)
    {
        var val_5;
        var val_15;
        var val_16;
        UnityEngine.Object val_17;
        var val_18;
        val_15 = this;
        val_16 = null;
        val_16 = null;
        val_17 = mem[FortEquipmentController.丝丘丞不丂丆不丘且 + 24];
        val_17 = FortEquipmentController.丝丘丞不丂丆不丘且 + 24;
        if(val_17.isMine == false)
        {
                return;
        }
        
        if(val_17 != 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_17 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        List.Enumerator<T> val_3 = val_17.GetEnumerator();
        label_20:
        if(((-29530288) & 1) == 0)
        {
            goto label_12;
        }
        
        val_17 = val_5.丐丏七丌丕丗业且上();
        if(((X22 + 504) == 0) || ((X22 + 504 + 504.viewID) != 丕丗丗丂丕业与丄七))
        {
            goto label_20;
        }
        
        UnityEngine.Vector3 val_9 = 丕丗丗丂丕业与丄七.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.9f);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        this.丑丐丒上丒丏丙与与(不七丕丐丟一丆上三:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 东丗上东丘丄东丘世:  this.runSpeed);
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 专丙且七丝丏丞丌下()
    {
        if(this.flyThrowWalls != false)
        {
                return;
        }
        
        if(this.丟丅三丝丄丈万丒三.path == null)
        {
                return;
        }
        
        if(this.丟丅三丝丄丈万丒三.isOnOffMeshLink == true)
        {
                return;
        }
        
        this.丟丅三丝丄丈万丒三.ResetPath();
    }
    public FortGuardMob()
    {
        this.shotDelayForAnimation = 1.2f;
        this.freeWalkSpeed = 1.5f;
        this.maxMoveDistance = 17f;
        this.flyAngularSpeed = 10f;
        this.flyHeightRandomRange = 2f;
    }

}
