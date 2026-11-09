using UnityEngine;
internal class TurretControllerScene_Artillery : TurretControllerScene
{
    // Fields
    private bool useAnotherTrajektory;
    protected float missileLaunchSpeed;
    private int shootSeriesCount;
    private float shootSeriesDelay;
    protected float minRadiusScanTarget;
    protected UnityEngine.Transform shotPoint;
    private UnityEngine.GameObject rocketPrefab;
    private UnityEngine.ParticleSystem gunFlash;
    private float shootDispersion;
    private UnityEngine.AudioClip shotClip;
    private bool 丆专七丒丙丁丄下丝;
    private UnityEngine.Coroutine 丟丞丟不丆一丞丙丄;
    protected float 丅丕丗与丏丗丅万丅;
    protected float 且丌业丙丆丅七世丟;
    private float 丆丞丏丙丛七丁丅且;
    private float 上世丟丕七丂丟丄丈;
    private float 与丈不一丈七丘丌丛;
    private float 不三业万丟下丟丙丑;
    private UnityEngine.Coroutine 丞丐不丏一丘丁丕丞;
    
    // Properties
    private float 丟上丝丞丄丞东丅与 { get; }
    protected bool 不下世丈丏丐专丝七 { get; }
    
    // Methods
    private float 丕专丁世丝丁丛与三()
    {
        return 0f;
    }
    protected bool 世一丒下丒丕丙丞东()
    {
        if(this.丆专七丒丙丁丄下丝 == false)
        {
                return (bool)(this.丟丞丟不丆一丞丙丄 != 0) ? 1 : 0;
        }
        
        return true;
    }
    internal static float 业丏丒丒不丌业丂丅(UnityEngine.Vector3 一三丏丛丄东一丆丐, UnityEngine.Vector3 上不一丗下世丂丞与)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 上不一丗下世丂丞与.x, y = 上不一丗下世丂丞与.y, z = 上不一丗下世丂丞与.z}, b:  new UnityEngine.Vector3() {x = 一三丏丛丄东一丆丐.x, y = 一三丏丛丄东一丆丐.y, z = 一三丏丛丄东一丆丐.z});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
        float val_3 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, to:  new UnityEngine.Vector3() {x = val_1.x, y = 0f, z = val_1.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = 0f, z = val_1.z});
        return (float)(val_5.y > 0f) ? (-val_3) : (val_3);
    }
    internal static float 丐丑丙丝丕一丌丅丝(UnityEngine.Vector3 一三丏丛丄东一丆丐, UnityEngine.Vector3 上不一丗下世丂丞与, float 丐丕丈丘丏东丝世丁, bool 丛丈上丙丘丘丞丒丏)
    {
        var val_11;
        float val_13;
        float val_14;
        float val_15;
        float val_13 = 一三丏丛丄东一丆丐.y;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 上不一丗下世丂丞与.x, y = 上不一丗下世丂丞与.y, z = 上不一丗下世丂丞与.z}, b:  new UnityEngine.Vector3() {x = 一三丏丛丄东一丆丐.x, y = val_13, z = 一三丏丛丄东一丆丐.z});
        UnityEngine.Vector3 val_2 = UnityEngine.Physics.gravity;
        val_11 = null;
        val_11 = null;
        float val_3 = 丐丕丈丘丏东丝世丁 + 丐丕丈丘丏东丝世丁;
        float val_4 = 上不一丗下世丂丞与.y - val_13;
        float val_12 = -2f;
        val_3 = val_3 * 丐丕丈丘丏东丝世丁;
        val_12 = 丐丕丈丘丏东丝世丁 * val_12;
        val_4 = val_4 * val_3;
        float val_5 = val_12 * 丐丕丈丘丏东丝世丁;
        float val_6 = System.Math.Abs(val_2.y) * 0f;
        val_13 = (val_4 / 0f) + val_6;
        if(丛丈上丙丘丘丞丒丏 != false)
        {
                float val_14 = -4f;
            val_14 = val_6 * val_14;
            float val_8 = val_5 * val_5;
            val_14 = val_14 * val_13;
            val_14 = val_8 + val_14;
            if(val_8 >= _TYPE_MAX_)
        {
                val_13 = val_14;
        }
        
            val_14 = (-val_5) - val_13;
        }
        else
        {
                float val_15 = -4f;
            val_15 = val_6 * val_15;
            float val_9 = val_5 * val_5;
            val_15 = val_15 * val_13;
            val_15 = val_9 + val_15;
            if(val_9 >= _TYPE_MAX_)
        {
                val_15 = val_15;
        }
        
            val_14 = val_15 - val_5;
        }
        
        val_14 = val_14 / (val_6 + val_6);
        val_14 = val_14 * 180f;
        val_14 = val_14 / 3.141593f;
        return (float)val_14;
    }
    protected float 丕丏丐丄与丘一丗丙(bool 一丂丂丈东丛东丅丐)
    {
        if(一丂丂丈东丛东丅丐 != true)
        {
                float val_3 = this.与丈不一丈七丘丌丛;
            val_3 = val_3 + this.不三业万丟下丟丙丑;
            if(UnityEngine.Time.time <= val_3)
        {
                return (float)this.上世丟丕七丂丟丄丈;
        }
        
        }
        
        this.上世丟丕七丂丟丄丈 = this.丕丏丐丄与丘一丗丙(丞下万上三丘上与专:  一丂丂丈东丛东丅丐);
        return (float)this.上世丟丕七丂丟丄丈;
    }
    protected float 丕丏丐丄与丘一丗丙(UnityEngine.Transform 丞下万上三丘上与专)
    {
        UnityEngine.Vector3 val_1 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  丞下万上三丘上与专);
        UnityEngine.Vector3 val_2 = this.shotPoint.position;
        return TurretControllerScene_Artillery.丐丑丙丝丕一丌丅丝(一三丏丛丄东一丆丐:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 上不一丗下世丂丞与:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 丐丕丈丘丏东丝世丁:  this.missileLaunchSpeed, 丛丈上丙丘丘丞丒丏:  this.useAnotherTrajektory);
    }
    protected float 丑丌不丞丆且丘专一()
    {
        UnityEngine.Vector3 val_1 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  137125888);
        UnityEngine.Vector3 val_2 = this.shotPoint.position;
        return TurretControllerScene_Artillery.业丏丒丒不丌业丂丅(一三丏丛丄东一丆丐:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 上不一丗下世丂丞与:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    protected override void Awake()
    {
        this.Awake();
        if(0 != 0)
        {
                float val_2 = 0.丟一丞丗业三丁上东();
        }
        else
        {
                float val_4 = 0.15f;
        }
        
        val_4 = UnityEngine.Time.time - val_4;
        this.且丌业丙丆丅七世丟 = val_4;
        this.丅丕丗与丏丗丅万丅 = this.minRadiusScanTarget * this.minRadiusScanTarget;
    }
    private System.Collections.IEnumerable 业且且丗丈东世丈不(float 丕丕世且下一与丝与)
    {
        TurretControllerScene_Artillery.世丁下丛万世丌丒世 val_1 = new TurretControllerScene_Artillery.世丁下丛万世丌丒世();
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
    private void 东业三丌业丌丕丒丑(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕, float 一丄且丒一丝丏丄与 = 0)
    {
        this.丟丞丟不丆一丞丙丄 = this.StartCoroutine(routine:  this.丒丑丒丁一丏丕丞且(丌丐丏丐丆丙丛丁丕:  丌丐丏丐丆丙丛丁丕, 一丄且丒一丝丏丄与:  一丄且丒一丝丏丄与));
    }
    private System.Collections.IEnumerator 丒丑丒丁一丏丕丞且(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕, float 一丄且丒一丝丏丄与 = 0)
    {
        TurretControllerScene_Artillery.丈丅丂丏丂丄丙丙东 val_1 = new TurretControllerScene_Artillery.丈丅丂丏丂丄丙丙东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丌丐丏丐丆丙丛丁丕 = 丌丐丏丐丆丙丛丁丕;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丌丐丏丐丆丙丛丁丕;
        }
        
        .一丄且丒一丝丏丄与 = 一丄且丒一丝丏丄与;
        return (System.Collections.IEnumerator)val_1;
    }
    protected virtual bool 丄业丟丌丏丁上丑丛()
    {
        float val_13;
        float val_14;
        float val_16;
        float val_17;
        var val_18;
        val_13 = UnityEngine.Time.time;
        if(0 != 0)
        {
                float val_2 = 0.丟一丞丗业三丁上东();
        }
        else
        {
                float val_13 = 0.15f;
        }
        
        val_13 = this.且丌业丙丆丅七世丟 + val_13;
        if(((val_13 < 0) || (this.丆专七丒丙丁丄下丝 == true)) || (this.丟丞丟不丆一丞丙丄 != null))
        {
                return false;
        }
        
        val_14 = this.丕丏丐丄与丘一丗丙(丞下万上三丘上与专:  null);
        this.上世丟丕七丂丟丄丈 = val_14;
        val_13 = this.丑丌不丞丆且丘专一();
        if((System.Single.IsNaN(f:  val_14)) != false)
        {
                UnityEngine.Vector3 val_6 = this.shotPoint.position;
            UnityEngine.Vector3 val_7 = this.shotPoint.position;
            val_14 = 45f;
            val_16 = 下且丏世下丝上丂丌.与下丌丘丗上丄丞与(与与丕丁且丐丘丆东:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丌丛丒与丝且丗万与:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 一不丅与丟丌丏丟东:  val_14);
        }
        else
        {
                val_16 = 0f;
        }
        
        val_17 = val_14;
        if((System.Single.IsNaN(f:  val_17)) != false)
        {
                float val_14 = this.且丌业丙丆丅七世丟;
            val_14 = val_14 + this.丆丞丏丙丛七丁丅且;
            this.且丌业丙丆丅七世丟 = val_14;
            UnityEngine.Debug.Log(message:  "Artillery cant shoot to target!");
            return false;
        }
        
        UnityEngine.Vector2[] val_10 = new UnityEngine.Vector2[0];
        val_18 = 0;
        goto label_13;
        label_17:
        val_10[0] = val_14;
        val_17 = val_13 + (UnityEngine.Random.Range(min:  -this.shootDispersion, max:  this.shootDispersion));
        val_18 = 1;
        val_10[0] = val_17;
        label_13:
        if(val_18 < val_10.Length)
        {
            goto label_17;
        }
        
        if(val_16 > 0f)
        {
                val_17 = val_16;
            val_18.SendShotArtilleryRPC(上世万世丐丄上丑丆:  this, 丌丐丏丐丆丙丛丁丕:  val_10, 丛上丟丌丄丗丁世与:  val_17);
        }
        else
        {
                val_18.SendShotArtilleryRPC(上世万世丐丄上丑丆:  this, 丌丐丏丐丆丙丛丁丕:  val_10);
        }
        
        float val_12 = UnityEngine.Time.time;
        int val_15 = this.shootSeriesCount;
        float val_16 = this.shootSeriesDelay;
        val_15 = val_15 - 1;
        val_16 = val_16 * (float)val_15;
        val_12 = val_12 + val_16;
        this.且丌业丙丆丅七世丟 = val_12;
        return false;
    }
    public override void ShotArtillery(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕)
    {
        this.ShotArtillery(丌丐丏丐丆丙丛丁丕:  丌丐丏丐丆丙丛丁丕);
        this.丆专七丒丙丁丄下丝 = false;
        this.丟丞丟不丆一丞丙丄 = this.StartCoroutine(routine:  this.丒丑丒丁一丏丕丞且(丌丐丏丐丆丙丛丁丕:  丌丐丏丐丆丙丛丁丕, 一丄且丒一丝丏丄与:  0f));
    }
    public override void ShotArtillery(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕, float 丛上丟丌丄丗丁世与)
    {
        this.ShotArtillery(丌丐丏丐丆丙丛丁丕:  丌丐丏丐丆丙丛丁丕);
        this.丆专七丒丙丁丄下丝 = false;
        this.丟丞丟不丆一丞丙丄 = this.StartCoroutine(routine:  this.丒丑丒丁一丏丕丞且(丌丐丏丐丆丙丛丁丕:  丌丐丏丐丆丙丛丁丕, 一丄且丒一丝丏丄与:  丛上丟丌丄丗丁世与));
    }
    private void 丟丑丙七丁三丞丕丁(float 丂丆丞丞丐丗丈上丂, float 丄丛丐专一丙下且丒, float 一丄且丒一丝丏丄与 = 0)
    {
        float val_46;
        float val_47;
        FortEquipObject val_48;
        float val_50;
        float val_52;
        float val_55;
        float val_56;
        var val_57;
        var val_58;
        var val_59;
        val_46 = 一丄且丒一丝丏丄与;
        val_47 = 丄丛丐专一丙下且丒;
        val_48 = this;
        if(this.rocketPrefab == 0)
        {
                return;
        }
        
        if(this.rocketPrefab != 0)
        {
                if((UnityEngine.TrackedReference.op_Inequality(x:  this.rocketPrefab.Item["turret_shoot"], y:  0)) != false)
        {
                bool val_5 = this.rocketPrefab.Play(animation:  "turret_shoot");
        }
        
        }
        
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (this.shotClip != 0))
        {
                if(this.shotClip != 0)
        {
                this.shotClip.PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        if(this.gunFlash != 0)
        {
                this.gunFlash.enableEmission = true;
            this.gunFlash.Play();
        }
        
        if(this.丞丐不丏一丘丁丕丞 != null)
        {
                this.StopCoroutine(routine:  this.丞丐不丏一丘丁丕丞);
            this.丞丐不丏一丘丁丕丞 = 0;
        }
        
        var val_47 = 0;
        val_47 = val_47 + 1;
        this.丞丐不丏一丘丁丕丞 = this.StartCoroutine(routine:  this.业且且丗丈东世丈不(丕丕世且下一与丝与:  0.1f).GetEnumerator());
        UnityEngine.Vector3 val_14 = this.shotPoint.position;
        UnityEngine.Quaternion val_16 = this.transform.rotation;
        val_50 = val_14.x;
        UnityEngine.GameObject val_17 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.rocketPrefab, position:  new UnityEngine.Vector3() {x = val_50, y = val_14.y, z = val_14.z}, rotation:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w});
        TurretRocketControllerScene val_18 = val_17.GetComponent<TurretRocketControllerScene>();
        if(val_18 != null)
        {
                val_18.且丝业丙丁丂万丞与 = ;
            val_18.丌不且专丘丆丞丂丟 = val_48;
            val_18.fortObjectName = 1152921526057697296;
        }
        else
        {
                val_18.且丝业丙丁丂万丞与 = ;
            mem[48] = val_48;
            mem[72] = ???;
        }
        
        val_52 = val_46;
        val_18.SetTarget(丞下万上三丘上与专:  X22);
        if((System.String.IsNullOrEmpty(value:  X22.丆丘丒东且丂与丂丑())) == true)
        {
            goto label_45;
        }
        
        string val_21 = X22.丆丘丒东且丂与丂丑();
        if((val_21.Equals(value:  "Nuclear Area")) == true)
        {
            goto label_45;
        }
        
        string val_23 = val_21.丆丘丒东且丂与丂丑();
        if((val_23.Contains(value:  "Area")) == false)
        {
            goto label_45;
        }
        
        string val_25 = val_23.丆丘丒东且丂与丂丑();
        if((System.String.op_Equality(a:  val_25, b:  "Poison Area")) != true)
        {
                if((System.String.op_Equality(a:  val_25, b:  "Fire Area")) == false)
        {
            goto label_48;
        }
        
        }
        
        val_18.poisonHitsCount = val_25;
        val_50 = this.三丟丅不丅丅业丛丁();
        val_18.丕不丙丈与丅上丂业(三一丝且丝丛不丄丐:  val_25, 丒丂且不丅丞三丒世:  val_50);
        goto label_91;
        label_45:
        if(val_18 != null)
        {
                val_18.typeDead = ;
            val_18.三一丝且丝丛不丄丐 = 72;
            val_18.poisonHitsCount = 72;
        }
        else
        {
                val_18.typeDead = ;
            mem[96] = ???;
            mem[104] = ???;
        }
        
        val_18.poisonHitsDelay = val_16.z;
        if((System.String.IsNullOrEmpty(value:  X22.丆丘丒东且丂与丂丑())) != false)
        {
                val_18.poisonDamageMultipier = 1.45735E-43f;
        }
        else
        {
                val_18.poisonDamageMultipier = this.三丟丅不丅丅业丛丁();
        }
        
        label_91:
        if(X22.丕丗业丝万上丂且丝() <= 0f)
        {
            goto label_58;
        }
        
        val_55 = X22.丕丗业丝万上丂且丝();
        if(val_18 != null)
        {
            goto label_63;
        }
        
        goto label_61;
        label_58:
        val_55 = val_18.objectAfterDestroyLifetime;
        if(val_18 != null)
        {
            goto label_63;
        }
        
        label_61:
        label_63:
        val_18.objectAfterDestroyLifetime = val_55;
        if(val_52 == 0f)
        {
                val_52 = this.missileLaunchSpeed;
        }
        
        val_56 = 0f;
        if(0 == 0)
        {
            goto label_67;
        }
        
        if(0.七与万且专丁丝丘丈() < 0f)
        {
            goto label_66;
        }
        
        if(0 != 0)
        {
                val_56 = 0.七与万且专丁丝丘丈();
        }
        
        label_67:
        val_18.splashRadius = val_56;
        label_66:
        UnityEngine.Quaternion val_37 = UnityEngine.Quaternion.Euler(x:  0f, y:  -val_47, z:  0f);
        UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  丂丆丞丞丐丗丈上丂);
        UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w}, rhs:  new UnityEngine.Quaternion() {x = val_38.x, y = val_38.y, z = val_38.z, w = val_38.w});
        UnityEngine.Vector3 val_40 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_39.x, y = val_39.y, z = val_39.z, w = val_39.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_46 = val_40.x;
        val_47 = val_40.z;
        val_17.GetComponent<UnityEngine.Rigidbody>().velocity = new UnityEngine.Vector3() {x = val_46, y = val_40.y, z = val_47};
        val_57 = null;
        val_57 = null;
        val_48 = FortWallsColliderController.丄丘七三上丕世丞业;
        if(val_48 == 0)
        {
                return;
        }
        
        val_58 = null;
        val_58 = null;
        val_48 = mem[FortWallsColliderController.丄丘七三上丕世丞业 + 24];
        val_48 = FortWallsColliderController.丄丘七三上丕世丞业.colliderObject;
        if(val_48 == 0)
        {
                return;
        }
        
        val_59 = null;
        val_59 = null;
        val_48 = mem[FortWallsColliderController.丄丘七三上丕世丞业 + 24];
        val_48 = FortWallsColliderController.丄丘七三上丕世丞业.colliderObject;
        UnityEngine.Physics.IgnoreCollision(collider1:  val_48, collider2:  val_17.GetComponent<UnityEngine.Collider>(), ignore:  true);
        return;
        label_48:
        if((System.String.op_Equality(a:  val_25, b:  "SlowDown Area")) == false)
        {
            goto label_87;
        }
        
        val_18.下专与三丗丂丒不丑(丂业丑丅与且三丐与:  this.三丟丅不丅丅业丛丁());
        goto label_91;
        label_87:
        if(val_25 == null)
        {
            goto label_91;
        }
        
        int val_46 = val_25.Length;
        goto label_91;
    }
    public TurretControllerScene_Artillery()
    {
        mem2[0] = 1101004800;
        mem2[0] = 1045220557;
        this.shootDispersion = 0.015f;
        this.丆丞丏丙丛七丁丅且 = 0.5f;
        this.不三业万丟下丟丙丑 = 1f;
    }

}
