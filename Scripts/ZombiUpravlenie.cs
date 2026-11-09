using UnityEngine;
internal sealed class ZombiUpravlenie : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal static bool 东丐三与丑丄丞丒丏;
    private static SkinsManagerPixlGun 丛丅东丟丞下下丐丒;
    private bool 上丕丂一丗丁丗丞丄;
    private ZombiManager 丗丛东丁丟上丞丅且;
    private UnityEngine.GameObject 丐丒丅丗丏上一丏丅;
    private UnityEngine.BoxCollider 丒丘业万丂业丌丝一;
    private UnityEngine.AI.NavMeshAgent 丅丞丅丛丄丄丏丆丗;
    private UnityEngine.Texture 丑丄丅丟丙丛丒丑丅;
    private Sounds 丁一世丈下上与丅七;
    private float 丄丁丐专上丛丞丞丟;
    public bool deaded;
    private bool 丛业业不上丅丒与丄;
    public float health;
    private Player_move_c 东丌七丘丂丄丘丈万;
    public UnityEngine.Texture hitTexture;
    private string 三丞丁丗七丈万业丄;
    private string 下不丈丟下丁丁丌专;
    private string 一丞丏世丐下专丂与;
    private string 世业专东丗丁丟不与;
    private string 丈丒丂丄丈丞上世丑;
    private string 丕丐丝丅业下丂丌专;
    private string 丑与丌丒世万丄一丑;
    private string 与不丑世万丒丑丘丄;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private UnityEngine.GameObject 专丞上七七且丝七丗;
    public UnityEngine.GameObject playerKill;
    public UnityEngine.Transform target;
    public int tekAnim;
    private float 丑专丂上且与世不丗;
    private float 丄丟丗三丟丐丟万丄;
    private float 丂专与丐丈丐七东丘;
    public int typeZombInMas;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    
    // Properties
    private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    
    // Methods
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    private System.Collections.IEnumerator 丆七下丌世下三上丄(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new ZombiUpravlenie.丅丛下丝与七丘东丆();
    }
    public bool RequestPlayDeath(float 七且丆丞丌丘下世丑)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ZombiUpravlenie.东丐三与丑丄丞丒丏 != false)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  丆七下丌世下三上丄(七且丆丞丌丘下世丑:  七且丆丞丌丘下世丑));
        val_4 = 1;
        return (bool)val_4;
    }
    private void Awake()
    {
        var val_8;
        UnityEngine.GameObject val_3 = this.丌丟丄业且三丛丕丄().GetChild(index:  0).gameObject;
        this.丐丒丅丗丏上一丏丅 = val_3;
        Sounds val_4 = val_3.GetComponent<Sounds>();
        this.health = val_4.health;
        val_8 = null;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.丙丘不世专且万丄丐() != true)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        }
        
        if(GameConnect.丙丘不世专且万丄丐() == true)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void 下丛丝不七丙上世丘(float 丝三不七丑丏一业丑)
    {
        this.health = 丝三不七丑丏一业丑;
    }
    private void 丟丂世丅丙丘下万七()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.且丅丛丗专丑丕七丕());
    }
    private void 丁专丝业丕东丛万丄(float 丐丌一丈丒一丕丐丙)
    {
    
    }
    public void setHealth(float 丝三不七丑丏一业丑, bool 丌丗丈丕丆丁三丌丗)
    {
        if(丌丗丈丕丆丁三丌丗 == false)
        {
                return;
        }
        
        if(this.上丕丂一丗丁丗丞丄 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.且丅丛丗专丑丕七丕());
    }
    internal static UnityEngine.Texture 丈丈丕丆不丆丗东下(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        if((UnityEngine.Object.op_Implicit(exists:  ZombiUpravlenie.丛丅东丟丞下下丐丒)) != true)
        {
                val_8 = null;
            val_8 = null;
            ZombiUpravlenie.丛丅东丟丞下下丐丒 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SkinsManager").GetComponent<SkinsManagerPixlGun>();
        }
        
        val_9 = null;
        val_9 = null;
        System.Collections.Hashtable val_7 = val_3.专丗丕丐七丅下七丟;
        val_10 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  null)) != true)
        {
                UnityEngine.Debug.Log(message:  "No skin: "("No skin: ") + 丝三丁东丈丒世丅业.name);
        }
        
        BotHealth.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  丝三丁东丈丒世丅业, 丐丅丁丂丐下丘世丄:  null);
        return (UnityEngine.Texture);
    }
    internal static string 丅世丝丂丅丅丐世七(string 丆丗丗三丗丌丒丂不)
    {
        return (string)丆丗丗三丗丌丒丂不;
    }
    private System.Collections.IEnumerator 且丅丛丗专丑丕七丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ZombiUpravlenie.丐上丏下丞丈丐丝三();
    }
    private void Start()
    {
        Sounds val_12;
        var val_13;
        float val_14;
        this.丑丄丅丟丙丛丒丑丅 = ZombiUpravlenie.丈丈丕丆不丆丗东下(丝三丁东丈丒世丅业:  this.丐丒丅丗丏上一丏丅);
        this.丅丞丅丛丄丄丏丆丗 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.丒丘业万丂业丌丝一 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.BoxCollider>();
        this.与不丑世万丒丑丘丄 = this.世业专东丗丁丟不与;
        this.专丞上七七且丝七丗 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
        this.丗丛东丁丟上丞丅且 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "ZombiCreator").GetComponent<ZombiManager>();
        this.丁一世丈下上与丅七 = this.丐丒丅丗丏上一丏丅.GetComponent<Sounds>();
        this.target = 0;
        this.丄丁丐专上丛丞丞丟 = val_7.timeToHit;
        this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>().Stop();
        this.Walk();
        val_12 = this.丁一世丈下上与丅七;
        if(val_12 != null)
        {
                val_13 = val_12;
            val_14 = this.丁一世丈下上与丅七.attackingSpeed;
        }
        else
        {
                val_14 = this.丁一世丈下上与丅七.attackingSpeed;
            val_13 = this.丁一世丈下上与丅七 + 60;
            if(this.丁一世丈下上与丅七 != null)
        {
                val_12 = this.丁一世丈下上与丅七;
        }
        else
        {
                val_12 = 0;
        }
        
        }
        
        float val_9 = UnityEngine.Random.Range(min:  0f, max:  this.丁一世丈下上与丅七.attackingSpeedRandomRange[1]);
        val_9 = val_14 + val_9;
        mem2[0] = val_9;
        this.丄丈丑丐丆丞丘与丗 = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        this.丑丄丅丟丙丛丒丑丅 = ZombiUpravlenie.丈丈丕丆不丆丗东下(丝三丁东丈丒世丅业:  this.丐丒丅丗丏上一丏丅);
    }
    public void setId(int 丏世丑万世一七丟丞)
    {
    
    }
    private void 丏丟七丙业专丗丂丒(int 丏世丑万世一七丟丞)
    {
        this.GetComponent<PhotonView>().viewID = 丏世丑万世一七丟丞;
    }
    private void Update()
    {
        var val_45;
        UnityEngine.Object val_69;
        Sounds val_70;
        float val_71;
        float val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_78;
        val_69 = this;
        if(ZombiManager.丟丗丄业丘丗业丗七.startGame == false)
        {
            goto label_2;
        }
        
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        if(this.deaded == false)
        {
            goto label_5;
        }
        
        if(this.丛业业不上丅丒与丄 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
        val_69 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_9 = val_69.position;
        float val_69 = -7f;
        val_69 = UnityEngine.Time.deltaTime * val_69;
        float val_10 = val_6.y + val_69;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_2:
        val_69 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_69);
        return;
        label_5:
        if((this.target != 0) && ((this.target.CompareTag(tag:  "Player")) != false))
        {
                SkinName val_14 = this.target.GetComponent<SkinName>();
            if(val_14.playerMoveC.万万一与丝业七专下 != false)
        {
                this.target = 0;
        }
        
        }
        
        if((this.target == 0) || (this.丂专与丐丈丐七东丘 <= 0f))
        {
            goto label_26;
        }
        
        float val_16 = UnityEngine.Time.deltaTime;
        val_16 = this.丂专与丐丈丐七东丘 - val_16;
        this.丂专与丐丈丐七东丘 = val_16;
        UnityEngine.Vector3 val_17 = this.target.position;
        UnityEngine.Vector3 val_19 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Vector3 val_22 = this.target.position;
        UnityEngine.Vector3 val_24 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_25 = this.target.position;
        val_70 = this.丁一世丈下上与丅七;
        if(val_70 == null)
        {
            goto label_34;
        }
        
        val_71 = this.丁一世丈下上与丅七.attackDistance;
        goto label_69;
        label_26:
        val_72 = this.丑专丂上且与世不丗 - UnityEngine.Time.deltaTime;
        this.丑专丂上且与世不丗 = val_72;
        if(val_72 <= 0f)
        {
                this.丑专丂上且与世不丗 = 5f;
            this.丅丞丅丛丄丄丏丆丗.ResetPath();
            UnityEngine.Vector3 val_29 = this.丌丟丄业且三丛丕丄().position;
            int val_31 = (UnityEngine.Random.Range(min:  0, max:  40)) - 20;
            int val_32 = (UnityEngine.Random.Range(min:  0, max:  40)) - 20;
            this.丌丟丄业且三丛丕丄().LookAt(worldPosition:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            bool val_34 = this.丅丞丅丛丄丄丏丆丗.SetDestination(target:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_72 = this.丁一世丈下上与丅七.notAttackingSpeed;
            this.丅丞丅丛丄丄丏丆丗.speed = val_72;
        }
        
        UnityEngine.GameObject[] val_35 = UnityEngine.GameObject.FindGameObjectsWithTag(tag:  "Turret");
        val_73 = null;
        val_73 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count <= 0)
        {
                return;
        }
        
        this.丂专与丐丈丐七东丘 = 5f;
        UnityEngine.Vector3 val_38 = this.丌丟丄业且三丛丕丄().position;
        val_74 = null;
        val_74 = null;
        Player_move_c val_39 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        UnityEngine.Vector3 val_40 = val_39.myPlayerTransform.position;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
        float val_42 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
        Player_move_c val_43 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        this.target = val_43.myPlayerTransform;
        List.Enumerator<T> val_44 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        goto label_65;
        label_66:
        string val_46 = 0.丐丏七丌丕丗业且上();
        if(val_45 == 0)
        {
                UnityEngine.Vector3 val_48 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_49 = val_46.position;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, b:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z})) < 0)
        {
                this.target = val_46;
        }
        
        }
        
        label_65:
        if(((-1929203872) & 1) != 0)
        {
            goto label_66;
        }
        
        val_75 = 0;
        val_76 = 0;
        goto label_67;
        label_34:
        val_71 = this.丁一世丈下上与丅七.attackDistance;
        if(this.丁一世丈下上与丅七 != null)
        {
                val_70 = this.丁一世丈下上与丅七;
        }
        else
        {
                val_70 = 0;
        }
        
        label_69:
        float val_70 = 7.006492E-45f;
        val_70 = val_71 * val_70;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z})) < val_70)
        {
                if(this.丅丞丅丛丄丄丏丆丗.path != null)
        {
                this.丅丞丅丛丄丄丏丆丗.ResetPath();
        }
        
            float val_53 = UnityEngine.Time.deltaTime;
            val_53 = this.丄丁丐专上丛丞丞丟 - val_53;
            this.丄丁丐专上丛丞丞丟 = val_53;
            this.丌丟丄业且三丛丕丄().LookAt(worldPosition:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if(this.丄丁丐专上丛丞丞丟 <= 0f)
        {
                this.丄丁丐专上丛丞丞丟 = this.丁一世丈下上与丅七.timeToHit;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.丁一世丈下上与丅七.bite);
        }
        
            bool val_57 = this.target.CompareTag(tag:  "Player");
            if((this.target.CompareTag(tag:  "Turret")) != false)
        {
                this.target.GetComponent<TurretController>().MinusLive(丛业专丘丂丅丗丝丛:  (float)this.丁一世丈下上与丅七.damagePerHit, 丞丗且下世丐业丌丙:  0);
        }
        
        }
        
            this.PlayZombieAttack();
            return;
        }
        
        float val_60 = UnityEngine.Time.deltaTime;
        val_60 = this.丄丟丗三丟丐丟万丄 - val_60;
        this.丄丟丗三丟丐丟万丄 = val_60;
        if(val_60 < 0)
        {
                bool val_61 = this.丅丞丅丛丄丄丏丆丗.SetDestination(target:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.丅丞丅丛丄丄丏丆丗.speed = this.丁一世丈下上与丅七.attackingSpeed;
            this.丄丟丗三丟丐丟万丄 = 0.5f;
        }
        
        this.丄丁丐专上丛丞丞丟 = this.丁一世丈下上与丅七.timeToHit;
        this.PlayZombieRun();
        return;
        label_67:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_174;
        }
        
        if(null == null)
        {
            goto label_178;
        }
        
        if(937 != 937)
        {
            goto label_176;
        }
        
        goto label_178;
        label_174:
        if(null == null)
        {
            goto label_178;
        }
        
        label_176:
        label_178:
        val_78 = 0;
        goto label_179;
        label_191:
        TurretController val_62 = Sounds.__il2cppRuntimeField_byval_arg.GetComponent<TurretController>();
        if(val_62.isRun != false)
        {
                UnityEngine.Transform val_63 = Sounds.__il2cppRuntimeField_byval_arg.transform;
            UnityEngine.Vector3 val_65 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_66 = val_63.position;
            UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, b:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z})) < 0)
        {
                this.target = val_63;
        }
        
        }
        
        val_78 = 1;
        label_179:
        if(val_78 < this.丁一世丈下上与丅七.hurt)
        {
            goto label_191;
        }
    
    }
    private void Death()
    {
        float val_25;
        var val_27;
        string val_28;
        string val_29;
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        if(this.丅丞丅丛丄丄丏丆丗 != 0)
        {
                this.丅丞丅丛丄丄丏丆丗.enabled = false;
        }
        
        val_25 = 0.1f;
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (this.丁一世丈下上与丅七 != 0))
        {
                if((this.RequestPlayDeath(七且丆丞丌丘下世丑:  this.丁一世丈下上与丅七.death.length)) != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.丁一世丈下上与丅七.death);
        }
        
            val_25 = this.丁一世丈下上与丅七.death.length;
        }
        
        UnityEngine.Animation val_9 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if(val_9 != null)
        {
                val_9.Stop();
            val_27 = this;
            val_28 = this.丈丒丂丄丈丞上世丑;
        }
        else
        {
                val_9.Stop();
            val_27 = this;
            val_28 = this.丈丒丂丄丈丞上世丑;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_9.Item[val_28])) == false)
        {
            goto label_24;
        }
        
        if(val_9 == null)
        {
            goto label_25;
        }
        
        bool val_12 = val_9.Play(animation:  val_28);
        val_29 = val_28;
        goto label_26;
        label_24:
        this.丛业业不上丅丒与丄 = true;
        goto label_27;
        label_25:
        bool val_13 = val_9.Play(animation:  val_28);
        val_29 = val_28;
        label_26:
        val_28 = val_28;
        val_25 = UnityEngine.Mathf.Max(a:  val_25, b:  val_9.Item[val_29].length);
        float val_25 = 1.25f;
        val_25 = val_9.Item[val_28].length * val_25;
        mem[1152921537037969840] = this;
        mem[1152921537037969848] = System.Void ZombiUpravlenie::丏丅东丙丝丛与丁丏();
        mem[1152921537037969824] = System.Void ZombiUpravlenie::丏丅东丙丝丛与丁丏();
        UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  new ZombiUpravlenie.丈丆丅丝业丟上不丘().丛丐丄丑丞丌下丝上(丂三丟丂丈丐丆丗丟:  val_25, 业丏丈世世世丞丒世:  new ZombiUpravlenie.丈丆丅丝业丟上不丘()));
        label_27:
        mem[1152921537037982128] = this;
        mem[1152921537037982136] = System.Void ZombiUpravlenie::东丁业丂丏丑且一东();
        mem[1152921537037982112] = System.Void ZombiUpravlenie::东丁业丂丏丑且一东();
        UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  new ZombiUpravlenie.丈丆丅丝业丟上不丘().丛丐丄丑丞丌下丝上(丂三丟丂丈丐丆丗丟:  val_25, 业丏丈世世世丞丒世:  new ZombiUpravlenie.丈丆丅丝业丟上不丘()));
        this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.BoxCollider>().enabled = false;
        this.deaded = true;
        this.GetComponent<SpawnMonster>().ShouldMove = false;
    }
    private void 东丁业丂丏丑且一东()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 丏丅东丙丝丛与丁丏()
    {
        this.丛业业不上丅丒与丄 = true;
    }
    private void Walk()
    {
        var val_4;
        string val_5;
        UnityEngine.Animation val_1 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if(val_1 != null)
        {
                val_1.Stop();
            val_4 = this;
            val_5 = this.下不丈丟下丁丁丌专;
        }
        else
        {
                val_1.Stop();
            val_4 = this;
            val_5 = this.下不丈丟下丁丁丌专;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_1.Item[val_5])) == false)
        {
            goto label_4;
        }
        
        if(val_1 != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        val_1.CrossFade(animation:  val_5);
        return;
        label_4:
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    public void PlayZombieRun()
    {
        if((this.tekAnim != 1) && (GameConnect.丙丘不世专且万丄丐() != false))
        {
                UnityEngine.Animation val_2 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
            if((UnityEngine.TrackedReference.op_Implicit(exists:  val_2.Item[this.一丞丏世丐下专丂与])) != false)
        {
                val_2.CrossFade(animation:  this.一丞丏世丐下专丂与);
        }
        
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  44, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
        this.tekAnim = 1;
    }
    public void PlayZombieAttack()
    {
        if((this.tekAnim == 2) || (GameConnect.丙丘不世专且万丄丐() == false))
        {
            goto label_4;
        }
        
        UnityEngine.Animation val_2 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_2.Item[this.丑与丌丒世万丄一丑])) == false)
        {
            goto label_7;
        }
        
        if(val_2 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        val_2.CrossFade(animation:  this.丑与丌丒世万丄一丑);
        goto label_11;
        label_7:
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_2.Item[this.与不丑世万丒丑丘丄])) == false)
        {
            goto label_11;
        }
        
        if(val_2 != null)
        {
            goto label_12;
        }
        
        goto label_13;
        label_11:
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  43, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        label_4:
        this.tekAnim = 2;
    }
    private void 丞丘世丙丂丂专业专()
    {
        UnityEngine.Animation val_1 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_1.Item[this.一丞丏世丐下专丂与])) != false)
        {
                val_1.CrossFade(animation:  this.一丞丏世丐下专丂与);
        }
        
        this.tekAnim = 1;
    }
    private void 且专丐丅业丄上丟丈()
    {
        UnityEngine.Animation val_1 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_1.Item[this.丑与丌丒世万丄一丑])) == false)
        {
            goto label_3;
        }
        
        if(val_1 != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        val_1.CrossFade(animation:  this.丑与丌丒世万丄一丑);
        goto label_7;
        label_3:
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_1.Item[this.与不丑世万丒丑丘丄])) == false)
        {
            goto label_7;
        }
        
        if(val_1 != null)
        {
            goto label_8;
        }
        
        goto label_9;
        label_7:
        this.tekAnim = 2;
    }
    public void CodeAfterDelay(float 丕丕世且下一与丝与, ZombiUpravlenie.丈丆丅丝业丟上不丘 业丏丈世世世丞丒世)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丛丐丄丑丞丌下丝上(丂三丟丂丈丐丆丗丟:  丕丕世且下一与丝与, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世));
    }
    private System.Collections.IEnumerator 丛丐丄丑丞丌下丝上(float 丂三丟丂丈丐丆丗丟, ZombiUpravlenie.丈丆丅丝业丟上不丘 业丏丈世世世丞丒世)
    {
        ZombiUpravlenie.丂且丈丂七丆丂七东 val_1 = new ZombiUpravlenie.丂且丈丂七丆丂七东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        }
        else
        {
                mem[32] = 丂三丟丂丈丐丆丗丟;
        }
        
        .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
        return (System.Collections.IEnumerator)val_1;
    }
    private UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.专专丏下丐丂丂丅东 == 0)
        {
                this.专专丏下丐丂丂丅东 = this.transform;
            return val_3;
        }
        
        val_3 = this.专专丏下丐丂丂丅东;
        return val_3;
    }
    public ZombiUpravlenie()
    {
        this.三丞丁丗七丈万业丄 = "Idle";
        this.下不丈丟下丁丁丌专 = "Norm_Walk";
        this.一丞丏世丐下专丂与 = "Zombie_Walk";
        this.世业专东丗丁丟不与 = "Zombie_Off";
        this.丈丒丂丄丈丞上世丑 = "Zombie_Dead";
        this.丕丐丝丅业下丂丌专 = "Zombie_On";
        this.tekAnim = 0;
        this.丑与丌丒世万丄一丑 = "Zombie_Attack";
        this.丂专与丐丈丐七东丘 = 5f;
    }
    private static ZombiUpravlenie()
    {
    
    }

}
