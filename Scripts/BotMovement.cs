using UnityEngine;
public sealed class BotMovement : PGBehaviour
{
    // Fields
    internal static bool 东丐三与丑丄丞丒丏;
    public ZombieCreator _gameController;
    private UnityEngine.GameObject 丐丒丅丗丏上一丏丅;
    private UnityEngine.BoxCollider 丒丘业万丂业丌丝一;
    private UnityEngine.AI.NavMeshAgent 丅丞丅丛丄丄丏丆丗;
    private Sounds 丁一世丈下上与丅七;
    private bool 丄丛丌与下丁不丝丝;
    private float 丄丁丐专上丛丞丞丟;
    private bool 丙下丒与丗不一与丒;
    private bool 丛业业不上丅丒与丄;
    private Player_move_c 东丌七丘丂丄丘丈万;
    private string 三丞丁丗七丈万业丄;
    private string 下不丈丟下丁丁丌专;
    private string 一丞丏世丐下专丂与;
    private string 世业专东丗丁丟不与;
    private string 丈丒丂丄丈丞上世丑;
    private string 丕丐丝丅业下丂丌专;
    private string 丑与丌丒世万丄一丑;
    private string 与不丑世万丒丑丘丄;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    private UnityEngine.GameObject 专丞上七七且丝七丗;
    private UnityEngine.Transform 丞下万上三丘上与专;
    private float 丑上一丏东丕丗丘丄;
    
    // Methods
    private System.Collections.IEnumerator 丆七下丌世下三上丄(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new BotMovement.七上丂七丝三丏丘丁();
    }
    public bool RequestPlayDeath(float 七且丆丞丌丘下世丑)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(BotMovement.东丐三与丑丄丞丒丏 != false)
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
        var val_12;
        var val_13;
        if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                this.enabled = false;
            return;
        }
        
        System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_10;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        goto label_15;
        label_10:
        val_12 = 0;
        val_13 = 0;
        goto label_16;
        label_15:
        object val_7 = val_3.Current;
        val_12 = 0;
        val_13 = 0;
        this.丐丒丅丗丏上一丏丅 = 0.gameObject;
        label_16:
        if(val_3 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_3.Dispose();
        }
        
        if(val_12 != 1)
        {
                if(val_13 == 0)
        {
                return;
        }
        
            if(82 == 82)
        {
                return;
        }
        
            return;
        }
        
        if(val_13 != 0)
        {
                return;
        }
    
    }
    private void Start()
    {
        var val_27;
        Sounds val_28;
        float val_29;
        System.Single[] val_30;
        Sounds val_31;
        float val_32;
        float val_33;
        float val_34;
        this.万东万丆专丌丕丐丗 = this.transform;
        this.丅丞丅丛丄丄丏丆丗 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.丒丘业万丂业丌丝一 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.BoxCollider>();
        this.与不丑世万丒丑丘丄 = this.世业专东丗丁丟不与;
        this.东丌七丘丂丄丘丈万 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PlayerGun").GetComponent<Player_move_c>();
        this.专丞上七七且丝七丗 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
        ZombieCreator val_8 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "GameController").GetComponent<ZombieCreator>();
        this._gameController = val_8;
        if(val_8 != null)
        {
                val_27 = val_8.且世三丘丕丞丏万万();
        }
        else
        {
                val_27 = val_8.且世三丘丕丞丏万万();
        }
        
        val_8.专东丒世且丞丝下丞(丙业与丙丗丝不丈东:  val_27 + 1);
        this.丁一世丈下上与丅七 = this.丐丒丅丗丏上一丏丅.GetComponent<Sounds>();
        this.丞下万上三丘上与专 = 0;
        this.丑上一丏东丕丗丘丄 = val_12.timeToHit;
        this.丄丁丐专上丛丞丞丟 = val_12.timeToHit;
        this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>().Stop();
        this.Walk();
        val_28 = this.丁一世丈下上与丅七;
        if(this.丁一世丈下上与丅七 != null)
        {
            goto label_10;
        }
        
        val_28 = this.丁一世丈下上与丅七;
        if(val_28 == null)
        {
            goto label_11;
        }
        
        label_10:
        val_29 = this.丁一世丈下上与丅七.attackingSpeed;
        val_30 = this.丁一世丈下上与丅七.attackingSpeedRandomRange;
        float val_14 = UnityEngine.Random.Range(min:  -this.丁一世丈下上与丅七.attackingSpeedRandomRange[0], max:  val_30[1]);
        val_14 = val_29 + val_14;
        this.丁一世丈下上与丅七.attackingSpeed = val_14;
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                float val_16 = 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
            val_16 = this.丁一世丈下上与丅七.attackingSpeed * val_16;
            this.丁一世丈下上与丅七.attackingSpeed = val_16;
            val_31 = this.丁一世丈下上与丅七;
            if(val_31 != null)
        {
                val_32 = this.丁一世丈下上与丅七.health;
            val_33 = 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
        }
        else
        {
                val_31 = 64;
            val_32 = 1.401298E-45f;
            float val_18 = 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
            val_33 = val_18;
        }
        
            val_18 = val_33 * val_32;
            mem[64] = val_18;
            val_30 = this.丁一世丈下上与丅七;
            if(val_30 != null)
        {
                val_34 = this.丁一世丈下上与丅七.notAttackingSpeed;
            val_29 = 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
        }
        else
        {
                val_30 = 56;
            val_34 = 5.877482E-39f;
            float val_20 = 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
            val_29 = val_20;
        }
        
            val_20 = val_29 * val_34;
            mem[56] = val_20;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == true)
        {
                return;
        }
        
        if((this.gameObject.name.Contains(value:  "Boss")) == true)
        {
                return;
        }
        
        ZombieCreator.东上不丝丌丗丂下丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BotMovement::丟丏三丞丂丏上三且()));
        if(this._gameController.丌万与丝丒世丅三丆() == false)
        {
                return;
        }
        
        this.丟丏三丞丂丏上三且();
        return;
        label_11:
    }
    private void 丟丏三丞丂丏上三且()
    {
        Sounds val_1 = this.丐丒丅丗丏上一丏丅.GetComponent<Sounds>();
        val_1.attackingSpeed = UnityEngine.Mathf.Max(a:  val_1.attackingSpeed, b:  3f);
        val_1.detectRadius = 150f;
    }
    internal static float 东东丂七专丁丆丛丁(UnityEngine.Vector3 一不丝丟世业丑丙一, UnityEngine.Vector3 丘丑丛丕下丈世下丂, UnityEngine.Vector3 丏丟万且丝丒丝丅东)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 一不丝丟世业丑丙一.x, y = 一不丝丟世业丑丙一.y, z = 一不丝丟世业丑丙一.z}, rhs:  new UnityEngine.Vector3() {x = 丘丑丛丕下丈世下丂.x, y = 丘丑丛丕下丈世下丂.y, z = 丘丑丛丕下丈世下丂.z});
        float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 一不丝丟世业丑丙一.x, y = 一不丝丟世业丑丙一.y, z = 一不丝丟世业丑丙一.z}, rhs:  new UnityEngine.Vector3() {x = 丘丑丛丕下丈世下丂.x, y = 丘丑丛丕下丈世下丂.y, z = 丘丑丛丕下丈世下丂.z});
        float val_5 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丏丟万且丝丒丝丅东.x, y = val_1, z = 丏丟万且丝丒丝丅东.y}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_5 = val_5 * 57.29578f;
        return (float)val_5;
    }
    public void Slowdown(float 丐丌一丈丒一丕丐丙)
    {
    
    }
    private void Update()
    {
        UnityEngine.Transform val_27;
        float val_28;
        float val_29;
        Sounds val_30;
        val_27 = this;
        if(this.丙下丒与丗不一与丒 != false)
        {
                if(this.丛业业不上丅丒与丄 == false)
        {
                return;
        }
        
            UnityEngine.Vector3 val_1 = this.万东万丆专丌丕丐丗.position;
            val_28 = val_1.x;
            UnityEngine.Vector3 val_2 = this.万东万丆专丌丕丐丗.position;
            val_27 = this.万东万丆专丌丕丐丗;
            val_29 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_4 = val_27.position;
            float val_27 = -7f;
            val_27 = val_29 * val_27;
            float val_5 = val_2.y + val_27;
            this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
        }
        
        if(this.丞下万上三丘上与专 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.丞下万上三丘上与专.position;
        UnityEngine.Vector3 val_8 = this.万东万丆专丌丕丐丗.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_11 = this.丞下万上三丘上与专.position;
        UnityEngine.Vector3 val_12 = this.万东万丆专丌丕丐丗.position;
        UnityEngine.Vector3 val_13 = this.丞下万上三丘上与专.position;
        val_30 = this.丁一世丈下上与丅七;
        if(this.丁一世丈下上与丅七 != null)
        {
            goto label_18;
        }
        
        val_30 = this.丁一世丈下上与丅七;
        if(val_30 == null)
        {
            goto label_19;
        }
        
        label_18:
        float val_28 = this.丁一世丈下上与丅七.attackDistance;
        val_28 = val_28 * this.丁一世丈下上与丅七.attackDistance;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) >= val_28)
        {
            goto label_20;
        }
        
        if(this.丅丞丅丛丄丄丏丆丗.path != null)
        {
                this.丅丞丅丛丄丄丏丆丗.ResetPath();
        }
        
        float val_15 = UnityEngine.Time.deltaTime;
        val_15 = this.丄丁丐专上丛丞丞丟 - val_15;
        this.丄丁丐专上丛丞丞丟 = val_15;
        val_28 = 0f;
        val_29 = 0f;
        this.万东万丆专丌丕丐丗.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_28, y = 0f, z = val_29});
        if(this.丄丁丐专上丛丞丞丟 <= 0f)
        {
                bool val_16 = this.丞下万上三丘上与专.CompareTag(tag:  "Player");
            if((this.丞下万上三丘上与专.CompareTag(tag:  "Turret")) != false)
        {
                this.丞下万上三丘上与专.GetComponent<TurretController>().MinusLive(丛业专丘丂丅丗丝丛:  (float)this.丁一世丈下上与丅七.damagePerHit, 丞丗且下世丐业丌丙:  0);
        }
        
            this.丄丁丐专上丛丞丞丟 = this.丑上一丏东丕丗丘丄;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.丁一世丈下上与丅七.bite);
        }
        
        }
        
        UnityEngine.Animation val_21 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_21.Item[this.丑与丌丒世万丄一丑])) == false)
        {
            goto label_39;
        }
        
        val_27 = this.丑与丌丒世万丄一丑;
        if(val_21 != null)
        {
            goto label_47;
        }
        
        label_48:
        label_47:
        val_21.CrossFade(animation:  val_27);
        return;
        label_20:
        val_29 = 0f;
        bool val_24 = this.丅丞丅丛丄丄丏丆丗.SetDestination(target:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_29});
        val_28 = this.丁一世丈下上与丅七.attackingSpeed;
        this.丅丞丅丛丄丄丏丆丗.speed = val_28;
        this.丄丁丐专上丛丞丞丟 = this.丑上一丏东丕丗丘丄;
        this.PlayZombieRun();
        return;
        label_39:
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_21.Item[this.与不丑世万丒丑丘丄])) == false)
        {
                return;
        }
        
        if(val_21 != null)
        {
            goto label_47;
        }
        
        goto label_48;
        label_19:
    }
    public void PlayZombieRun()
    {
        UnityEngine.Animation val_1 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_1.Item[this.一丞丏世丐下专丂与])) == false)
        {
                return;
        }
        
        val_1.CrossFade(animation:  this.一丞丏世丐下专丂与);
    }
    public void SetTarget(UnityEngine.Transform 丛丌丕丐世丑丂七丂, bool 不专丁丌丌丌与丝世)
    {
        bool val_10;
        UnityEngine.Transform val_11;
        val_10 = 不专丁丌丌丌与丝世;
        this.丄丛丌与下丁不丝丝 = val_10;
        if((UnityEngine.Object.op_Implicit(exists:  丛丌丕丐世丑丂七丂)) == false)
        {
            goto label_6;
        }
        
        val_11 = this;
        val_10 = this.丞下万上三丘上与专;
        if(val_10 == 丛丌丕丐世丑丂七丂)
        {
            goto label_6;
        }
        
        val_10 = this.丅丞丅丛丄丄丏丆丗;
        val_10.ResetPath();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_10 = this.GetComponent<UnityEngine.AudioSource>();
            val_10.PlayOneShot(clip:  this.丁一世丈下上与丅七.voice);
        }
        
        this.PlayZombieRun();
        goto label_19;
        label_6:
        val_11 = this.丞下万上三丘上与专;
        if((UnityEngine.Object.op_Implicit(exists:  丛丌丕丐世丑丂七丂)) != true)
        {
                val_10 = mem[this.丞下万上三丘上与专];
            if(val_10 != 丛丌丕丐世丑丂七丂)
        {
                val_10 = this.丅丞丅丛丄丄丏丆丗;
            val_10.ResetPath();
            this.Walk();
        }
        
        }
        
        label_19:
        mem2[0] = 丛丌丕丐世丑丂七丂;
        UnityEngine.Object val_10 = 0;
        val_10 = UnityEngine.Object.op_Equality(x:  丛丌丕丐世丑丂七丂, y:  val_10);
        this.GetComponent<SpawnMonster>().ShouldMove = val_10;
    }
    private void 丄丄丛万丁丐丐与丏()
    {
    
    }
    private void 丌丄丏下七丁专丂世()
    {
    
    }
    private void 丙丝丞一丏专丘丐丄()
    {
    
    }
    private void Death()
    {
        float val_27;
        var val_28;
        string val_29;
        string val_30;
        var val_31;
        ZombieCreator.丟丙丅业丞丂上且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BotMovement::丟丏三丞丂丏上三且()));
        this.丅丞丅丛丄丄丏丆丗.enabled = false;
        if((this.RequestPlayDeath(七且丆丞丌丘下世丑:  this.丁一世丈下上与丅七.death.length)) != false)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.丁一世丈下上与丅七.death);
        }
        
        }
        
        val_27 = this.丁一世丈下上与丅七.death.length;
        UnityEngine.Animation val_7 = this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.Animation>();
        if(val_7 != null)
        {
                val_7.Stop();
            val_28 = this;
            val_29 = this.丈丒丂丄丈丞上世丑;
        }
        else
        {
                val_7.Stop();
            val_28 = this;
            val_29 = this.丈丒丂丄丈丞上世丑;
        }
        
        if((UnityEngine.TrackedReference.op_Implicit(exists:  val_7.Item[val_29])) == false)
        {
            goto label_17;
        }
        
        if(val_7 == null)
        {
            goto label_18;
        }
        
        bool val_10 = val_7.Play(animation:  val_29);
        val_30 = val_29;
        goto label_19;
        label_17:
        this.丛业业不上丅丒与丄 = true;
        goto label_20;
        label_18:
        bool val_11 = val_7.Play(animation:  val_29);
        val_30 = val_29;
        label_19:
        val_29 = val_29;
        val_27 = UnityEngine.Mathf.Max(a:  val_27, b:  val_7.Item[val_30].length);
        float val_26 = 1.25f;
        val_26 = val_7.Item[val_29].length * val_26;
        mem[1152921536440446064] = this;
        mem[1152921536440446072] = System.Void BotMovement::丏丅东丙丝丛与丁丏();
        mem[1152921536440446048] = System.Void BotMovement::丏丅东丙丝丛与丁丏();
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  new BotMovement.丈丆丅丝业丟上不丘().丛丐丄丑丞丌下丝上(丂三丟丂丈丐丆丗丟:  val_26, 业丏丈世世世丞丒世:  new BotMovement.丈丆丅丝业丟上不丘()));
        label_20:
        mem[1152921536440458352] = this;
        mem[1152921536440458360] = System.Void BotMovement::东丁业丂丏丑且一东();
        mem[1152921536440458336] = System.Void BotMovement::东丁业丂丏丑且一东();
        UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  new BotMovement.丈丆丅丝业丟上不丘().丛丐丄丑丞丌下丝上(丂三丟丂丈丐丆丗丟:  val_27, 业丏丈世世世丞丒世:  new BotMovement.丈丆丅丝业丟上不丘()));
        this.丐丒丅丗丏上一丏丅.GetComponent<UnityEngine.BoxCollider>().enabled = false;
        this.丙下丒与丗不一与丒 = true;
        this.GetComponent<SpawnMonster>().ShouldMove = false;
        if(this._gameController != null)
        {
                val_31 = this._gameController.丌丟且丛丄丒万丈丑();
        }
        else
        {
                val_31 = 0.丌丟且丛丄丒万丈丑();
        }
        
        this._gameController.丂丟丑丂丁丝下与丒(丙业与丙丗丝不丈东:  val_31 + 1);
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
    private void FixedUpdate()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.七上不且且丑丂丟东())) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.七上不且且丑丂丟东().velocity = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.七上不且且丑丂丟东().angularVelocity = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public void CodeAfterDelay(float 丕丕世且下一与丝与, BotMovement.丈丆丅丝业丟上不丘 业丏丈世世世丞丒世)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丛丐丄丑丞丌下丝上(丂三丟丂丈丐丆丗丟:  丕丕世且下一与丝与, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世));
    }
    private System.Collections.IEnumerator 丛丐丄丑丞丌下丝上(float 丂三丟丂丈丐丆丗丟, BotMovement.丈丆丅丝业丟上不丘 业丏丈世世世丞丒世)
    {
        BotMovement.业万丆一丞与三丒专 val_1 = new BotMovement.业万丆一丞与三丒专();
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
    private void OnDestroy()
    {
        ZombieCreator.丟丙丅业丞丂上且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BotMovement::丟丏三丞丂丏上三且()));
    }
    public BotMovement()
    {
        this.三丞丁丗七丈万业丄 = "Idle";
        this.下不丈丟下丁丁丌专 = "Norm_Walk";
        this.一丞丏世丐下专丂与 = "Zombie_Walk";
        this.世业专东丗丁丟不与 = "Zombie_Off";
        this.丈丒丂丄丈丞上世丑 = "Zombie_Dead";
        this.丕丐丝丅业下丂丌专 = "Zombie_On";
        this.丑与丌丒世万丄一丑 = "Zombie_Attack";
    }
    private static BotMovement()
    {
    
    }

}
