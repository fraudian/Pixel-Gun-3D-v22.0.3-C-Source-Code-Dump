using UnityEngine;
internal sealed class TurretControllerScene_BoomerangRocketLauncher : TurretControllerScene_Tower
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    private UnityEngine.GameObject rocketPrefab;
    private float rocketSpeed;
    private UnityEngine.GameObject currentRocket;
    internal float deltaY;
    private ShurikenMovementTurretRocket 不与丏丞下丅世世丞;
    private ShurikenAttackTurretRocket 丈业丈丙丏丄丛丒一;
    private UnityEngine.Vector3 上不一丗下世丂丞与;
    private TurretControllerScene_BoomerangRocketLauncher.丈业七且丂丒三丌丆 currentState;
    private bool 丕丝丕丛丗专丄丅丏;
    
    // Methods
    protected override void Start()
    {
        this.Start();
        this.丞专一丙丁丒万三丏();
        this.rocketSpeed = X20.丂且专丕丄丗丒丝业();
    }
    protected override void Update()
    {
        this.Update();
        if(this.丕丝丕丛丗专丄丅丏 == true)
        {
                return;
        }
        
        if(this.currentRocket != 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丐丈丗丐丟丗专专业());
    }
    protected override void 丈丞一丈丑丝丈丂丂()
    {
        if(this.currentState == 1)
        {
                return;
        }
        
        this.丈丞一丈丑丝丈丂丂();
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        丈业七且丂丒三丌丆 val_11;
        float val_12;
        丈业七且丂丒三丌丆 val_11 = this.currentState;
        val_11 = val_11 | 2;
        if(val_11 != 2)
        {
                return;
        }
        
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137125888);
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_1.IsDead() == true)
        {
                return;
        }
        
        PhotonView val_4 = this.丕专与下丁不丆世业(丂丈丙且丈丗三丆丕:  val_1);
        if(val_4 != 0)
        {
                bool val_6 = val_4.isMine;
        }
        
        if(val_4 == 0)
        {
                return;
        }
        
        this.丐丌丘与丝丗丌且下();
        float val_8 = this.业万丈专丘丛七丂东();
        if(System.Math.Abs(val_8) > 2f)
        {
                return;
        }
        
        val_11 = this.currentState;
        if(val_11 != 2)
        {
            goto label_20;
        }
        
        val_12 = val_8 - UnityEngine.Time.deltaTime;
        mem[1152921540142773784] = val_12;
        if(val_12 >= 0)
        {
            goto label_21;
        }
        
        this.currentState = 0;
        goto label_23;
        label_21:
        val_11 = this.currentState;
        label_20:
        if(val_11 != 0)
        {
                return;
        }
        
        label_23:
        if(0 != 0)
        {
                float val_10 = 0.丟一丞丗业三丁上东();
        }
        else
        {
                val_12 = 0.15f;
        }
        
        mem[1152921540142773784] = val_12;
        this.currentState = 1;
        val_4.SendShotRPC(上世万世丐丄上丑丆:  this);
    }
    private float 业万丈专丘丛七丂东()
    {
        UnityEngine.Vector3 val_1 = forward;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_3 = this.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.z);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4.x, y:  val_4.z);
        return (float)UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, to:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        if(137125888 == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(137125888 != 0)
        {
                PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        if(this.currentRocket == 0)
        {
                this.丞专一丙丁丒万三丏();
        }
        
        if(this.currentRocket == 0)
        {
                return;
        }
        
        this.currentRocket.transform.parent = 0;
        UnityEngine.Vector3 val_8 = this.shotClip.position;
        this.currentRocket.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        this.不与丏丞下丅世世丞.世业丄丐三丂丛丈世(丁下丘七丙世东丗丅:  this);
        float val_9 = this.shotClip.不七不丈丐万丂丌下();
        var val_10 = (1152921504848912384 != 0) ? 1 : 0;
        var val_11 = (this.shotClip != 0) ? 1 : 0;
        this.丈业丈丙丏丄丛丒一.丆丌丙万与丛万丝世();
    }
    private void 丞专一丙丁丒万三丏()
    {
        if(this.isActive == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.rocketPrefab, parent:  X21);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        this.currentRocket = val_2;
        this.不与丏丞下丅世世丞 = val_2.GetComponent<ShurikenMovementTurretRocket>();
        ShurikenAttackTurretRocket val_7 = this.currentRocket.GetComponent<ShurikenAttackTurretRocket>();
        this.丈业丈丙丏丄丛丒一 = val_7;
        if((public ShurikenAttackTurretRocket UnityEngine.GameObject::GetComponent<ShurikenAttackTurretRocket>()) == 0)
        {
            goto label_12;
        }
        
        if(val_7 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        val_7.丆丞丐一一丒业丏与(丟上丝丞丄丞东丅与:  七与万且专丁丝丘丈());
        return;
        label_12:
        if(val_7 != null)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    private void 丐丌丘与丝丗丌且下()
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_2 = position;
        this.上不一丗下世丂丞与 = val_2;
        mem[1152921540143391896] = val_2.z;
        float val_3 = val_2.y + this.deltaY;
        mem[1152921540143391892] = val_3;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_3, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.丌丆万丛万丞丙下三());
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.上不一丗下世丂丞与 = val_7;
        mem[1152921540143391892] = val_7.y;
        mem[1152921540143391896] = val_7.z;
    }
    internal void 丁丆丏上丂丒丒丏上()
    {
        if(this.currentRocket == 0)
        {
                return;
        }
        
        this.currentRocket.transform.parent = this.currentRocket;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.currentRocket.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.不与丏丞下丅世世丞.世丛丗丛丂丌丒丑专();
        this.丈业丈丙丏丄丛丒一.StopAttack();
        this.currentState = 2;
    }
    protected override void 丄一一丌丙丂丌东丟()
    {
        float val_23;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        if(true == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = forward;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.上不一丗下世丂丞与, y = V11.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.z);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.z);
        val_23 = val_5.x;
        float val_23 = val_5.y;
        float val_6 = UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, to:  new UnityEngine.Vector2() {x = val_23, y = val_23});
        val_25 = val_6;
        float val_22 = System.Math.Abs(val_25);
        if(val_22 > 0.01f)
        {
                val_25 = val_25 * val_6;
            val_27 = System.Math.Abs(val_25);
            if(val_27 > val_6)
        {
                val_26 = val_25;
            val_25 = (UnityEngine.Mathf.Sign(f:  val_26)) * val_27;
        }
        
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.forward;
            val_23 = -(val_25 * UnityEngine.Time.deltaTime);
            val_23 = val_8.z;
            Rotate(axis:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_23}, angle:  val_23);
            this.丑丄与下丑丅丘业丅();
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.right;
        val_28 = val_11.x;
        val_29 = val_11.z;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
        val_30 = UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, to:  new UnityEngine.Vector3() {x = val_28, y = val_11.y, z = val_29}, axis:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.z, z = val_3.z});
        if(137125888 == 0)
        {
                return;
        }
        
        if(val_22 >= 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_1.y, y:  val_1.z);
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_3.y, y:  val_3.z);
        float val_25 = val_16.y;
        val_28 = ((val_30 > 0f) ? -1f : 1f) * (UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, to:  new UnityEngine.Vector2() {x = val_16.x, y = val_25}));
        float val_24 = System.Math.Abs(val_28);
        if(val_24 <= 0.01f)
        {
                return;
        }
        
        val_28 = val_28 * val_24;
        val_32 = System.Math.Abs(val_28);
        if(val_32 > val_24)
        {
                val_31 = val_28;
            val_28 = (UnityEngine.Mathf.Sign(f:  val_31)) * val_32;
        }
        
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.right;
        val_29 = val_20.y;
        val_30 = UnityEngine.Time.deltaTime;
        val_25 = val_28 * val_30;
        Rotate(axis:  new UnityEngine.Vector3() {x = val_20.x, y = val_29, z = val_20.z}, angle:  val_25, relativeTo:  1);
        this.三专丐丝且丗丟丆丒();
    }
    internal void 且丌万七丞丏丂丑上()
    {
        if(this.currentState != 1)
        {
                return;
        }
        
        this.currentState = 2;
    }
    private System.Collections.IEnumerator 丐丈丗丐丟丗专专业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretControllerScene_BoomerangRocketLauncher.丆万丁丗上丟丘东万();
    }
    public override void StartDeactivate(bool 一丆丌丝专丂丛丙上)
    {
        一丆丌丝专丂丛丙上 = 一丆丌丝专丂丛丙上;
        this.StartDeactivate(一丆丌丝专丂丛丙上:  一丆丌丝专丂丛丙上);
        this.丁丆丏上丂丒丒丏上();
        if(this.currentRocket == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.currentRocket);
    }
    public TurretControllerScene_BoomerangRocketLauncher()
    {
        this.deltaY = 1.5f;
    }

}
