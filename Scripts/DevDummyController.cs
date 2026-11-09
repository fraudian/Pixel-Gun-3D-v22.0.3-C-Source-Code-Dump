using UnityEngine;
internal sealed class DevDummyController : MonoBehaviour, 丅丙上七上一丐不下, 万丝丅丗且丒丝丌丟
{
    // Fields
    public UnityEngine.Collider _aimCollider;
    public UnityEngine.Collider _bodyAimCollider;
    public UnityEngine.Collider _headAimCollider;
    public UnityEngine.Animation _animation;
    private UnityEngine.Collider 丟专丙丅东丂丛丗东;
    private float 丕丘与丝丄丒丟丄丕;
    private UnityEngine.SkinnedMeshRenderer 丗东专丄丙丟下丏专;
    private UnityEngine.Texture 三丌专世丑丒丙丁世;
    private float[] 丞丌丙丒三丘丙上丑;
    private int 丂上丆丞丙丆丌丕三;
    private UnityEngine.Texture hitTexture;
    private UnityEngine.Texture poisonHitTexture;
    private UnityEngine.TextMesh damagesTextMesh;
    private UnityEngine.Transform healthBar;
    private float healthOnRespawn;
    private float maxHitPoints;
    private int takenDamagesCapacity;
    internal UnityEngine.GameObject 丏丁丒丟下世丗丑丞;
    private readonly string 东丙丏一丝丒世丄丑;
    private float 不万丛丄不丒丈东丟;
    private string 三丑丆与丒丐丅丌丄;
    public bool isFriendly;
    private bool _isSniperDummy;
    private float _timeForHide;
    private float _currentTimeForHide;
    private bool 丕丞丘下世丟下丁万;
    private bool _respawnAtStartPoint;
    private MovingDummy _moveDummy;
    private bool DoNotTouchThis;
    private string _keyLocalizeName;
    private UnityEngine.Shader 丁世与一上丞三丌丏;
    private UnityEngine.Shader 丗与丆上专丆丏且丄;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
    public UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
    public UnityEngine.Collider 丝且不七丂世丗下七 { get; }
    public UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
    public bool 丈丐丁不丙东世七丕 { get; }
    public UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
    private bool 世丆专专丒世丛世丗 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    public UnityEngine.Collider get_aimCollider()
    {
        return (UnityEngine.Collider)this._aimCollider;
    }
    public UnityEngine.Collider get_bodyAimCollider()
    {
        return (UnityEngine.Collider)this._bodyAimCollider;
    }
    public UnityEngine.Collider get_headAimCollider()
    {
        return (UnityEngine.Collider)this._headAimCollider;
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
                return (bool)(this.不万丛丄不丒丈东丟 <= 0f) ? 1 : 0;
        }
        
        val_3 = 1;
        return (bool)(this.不万丛丄不丒丈东丟 <= 0f) ? 1 : 0;
    }
    public UnityEngine.Vector3 get_currentTargetVelocity()
    {
        return UnityEngine.Vector3.zero;
    }
    private bool 丐不丆丁三七不丌丟()
    {
        var val_4;
        if((this._animation.IsPlaying(name:  "Dummy_Up")) != true)
        {
                if((this._animation.IsPlaying(name:  "Dead")) == false)
        {
                return (bool)(this.丕丞丘下世丟下丁万 == false) ? 1 : 0;
        }
        
        }
        
        val_4 = 0;
        return (bool)(this.丕丞丘下世丟下丁万 == false) ? 1 : 0;
    }
    private void Awake()
    {
        float val_48;
        var val_49;
        float val_50;
        string val_51;
        val_48 = this.maxHitPoints;
        this.丞丌丙丒三丘丙上丑 = new float[0];
        if(val_48 < 0)
        {
                int val_3 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7));
            if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_3)) > 0)
        {
                val_49 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
            int val_7 = val_49.三三三东丑丁且与万(丞世不丒下上上丝丑:  val_3);
        }
        else
        {
                val_49 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
        }
        
            val_50 = (float)BalanceController.丑丈与不丄丈丘三丟(丞世不丒下上上丝丑:  val_3, 下丑丞不一且业丆不:  val_49.丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  val_3), 丙丂丏丛丌丏下丝不:  ExperienceController.丞丞丘业东丙丏七丌());
            val_48 = val_50 + (1.152922E+18f);
            this.maxHitPoints = val_48;
        }
        
        AdvancedEffects val_13 = this.gameObject.AddComponent<AdvancedEffects>();
        AdvancedEffects val_14 = this.GetComponent<AdvancedEffects>();
        val_14.dontSync = true;
        this._moveDummy = this.GetComponent<MovingDummy>();
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  2);
        丘丛丞且一丅丁丏丐.丙丅丅丆丂一上业丐(不丂丅丁且丆东东丂:  this.transform, 丞下万上三丘上与专:  this);
        UnityEngine.SkinnedMeshRenderer val_18 = this.GetComponentInChildren<UnityEngine.SkinnedMeshRenderer>();
        this.丗东专丄丙丟下丏专 = val_18;
        if((UnityEngine.Object.op_Implicit(exists:  val_18)) != false)
        {
                this.丗东专丄丙丟下丏专.sharedMaterial = new UnityEngine.Material(source:  this.丗东专丄丙丟下丏专.sharedMaterial);
            this.三丌专世丑丒丙丁世 = this.丗东专丄丙丟下丏专.sharedMaterial.mainTexture;
        }
        
        this.丁世与一上丞三丌丏 = this.丗东专丄丙丟下丏专.sharedMaterial.shader;
        this.丗与丆上专丆丏且丄 = UnityEngine.Shader.Find(name:  "Rilisoft/WallHackShader");
        UnityEngine.GameObject val_28 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.东丙丏一丝丒世丄丑));
        this.丏丁丒丟下世丗丑丞 = val_28;
        if(val_28 != 0)
        {
                this.丏丁丒丟下世丗丑丞.transform.SetParent(p:  this.healthBar.transform);
            UnityEngine.Vector3 val_34 = this.healthBar.transform.localPosition;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  0.2f);
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            this.丏丁丒丟下世丗丑丞.transform.localPosition = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
            UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.identity;
            val_50 = val_39.x;
            this.丏丁丒丟下世丗丑丞.transform.localRotation = new UnityEngine.Quaternion() {x = val_50, y = val_39.y, z = val_39.z, w = val_39.w};
            val_48 = 0f;
            this.丏丁丒丟下世丗丑丞.transform.localScale = new UnityEngine.Vector3() {x = val_48, y = 0f, z = 0f};
            this.丏丁丒丟下世丗丑丞.SetActive(value:  false);
        }
        
        if(this._animation == 0)
        {
                this._animation = this.GetComponent<UnityEngine.Animation>();
        }
        
        bool val_43 = System.String.IsNullOrEmpty(value:  this._keyLocalizeName);
        if(this.DoNotTouchThis == false)
        {
            goto label_56;
        }
        
        if(val_43 == false)
        {
            goto label_59;
        }
        
        val_51 = "Тимофей";
        goto label_58;
        label_56:
        if(val_43 == false)
        {
            goto label_59;
        }
        
        string val_44 = this.damagesTextMesh.text;
        goto label_61;
        label_59:
        label_61:
        val_51 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._keyLocalizeName);
        label_58:
        this.三丑丆与丒丐丅丌丄 = val_51;
        this.damagesTextMesh.text = val_51;
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
                return;
        }
        
        if((PolygonController.一下一万丄丅丘且丑 + 24) == 0)
        {
                return;
        }
        
        val_50 = this.maxHitPoints;
        float val_47 = PolygonController.一下一万丄丅丘且丑.丄七丐业丕丏丅丘丞();
        val_47 = val_50 * val_47;
        this.maxHitPoints = val_47;
    }
    private void OnEnable()
    {
        this._animation.CrossFade(animation:  "Dummy_Up");
        this.SetTexture(一丛丈业丏业丁下丛:  this.三丌专世丑丒丙丁世);
    }
    private void OnDisable()
    {
        if(this._moveDummy != 0)
        {
                this._moveDummy.ResetPath();
        }
        
        this.SetXRayShader(丛丅丘一丏丙且丌上:  false);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  2);
        丘丛丞且一丅丁丏丐.丏丄丄东丒世专丌丁(不丂丅丁且丆东东丂:  this.transform);
    }
    private void Update()
    {
        var val_9;
        float val_10;
        if(this.isFriendly == false)
        {
            goto label_1;
        }
        
        val_9 = this;
        if(this.不万丛丄不丒丈东丟 > 0f)
        {
                if(this.不万丛丄不丒丈东丟 != this.maxHitPoints)
        {
            goto label_25;
        }
        
        }
        
        if((this._animation.IsPlaying(name:  "Dead")) == true)
        {
            goto label_25;
        }
        
        this._animation.CrossFade(animation:  "Dummy_Up");
        this.不万丛丄不丒丈东丟 = this.healthOnRespawn;
        val_10 = this.healthOnRespawn;
        goto label_7;
        label_1:
        if(this._isSniperDummy == false)
        {
            goto label_15;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this._currentTimeForHide + val_2;
        this._currentTimeForHide = val_2;
        if(val_2 < this._timeForHide)
        {
            goto label_15;
        }
        
        if((this.丕丞丘下世丟下丁万 == true) || (this.不万丛丄不丒丈东丟 <= 0f))
        {
            goto label_11;
        }
        
        this._animation.CrossFade(animation:  "Dead");
        this.丕丞丘下世丟下丁万 = true;
        goto label_13;
        label_11:
        if((this.丕丞丘下世丟下丁万 == false) || (this.不万丛丄不丒丈东丟 <= 0f))
        {
            goto label_15;
        }
        
        this._animation.CrossFade(animation:  "Dummy_Up");
        this.丕丞丘下世丟下丁万 = false;
        label_13:
        this._currentTimeForHide = 0f;
        label_15:
        val_9 = this;
        if(this.不万丛丄不丒丈东丟 <= 0f)
        {
                if((this._animation.IsPlaying(name:  "Dead")) != true)
        {
                this._animation.CrossFade(animation:  "Dummy_Up");
            this.不万丛丄不丒丈东丟 = this.maxHitPoints;
        }
        
        }
        
        if((this._respawnAtStartPoint != false) && ((this._animation.IsPlaying(name:  "Dead")) != true))
        {
                if((this._animation.IsPlaying(name:  "Dummy_Damage")) != true)
        {
                this._animation.CrossFade(animation:  "Dummy_Idle");
        }
        
        }
        
        label_25:
        val_10 = this.不万丛丄不丒丈东丟;
        label_7:
        if(val_10 > 0f)
        {
                float val_9 = this.maxHitPoints;
            val_9 = val_10 / val_9;
        }
        
        this.healthBar.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.damagesTextMesh.gameObject.SetActive(value:  this.丐不丆丁三七不丌丟());
    }
    private System.Collections.IEnumerator 丆丆丞且丕丟丈专下(bool 丌丒丕丄丑丌世不丐)
    {
        DevDummyController.丆下世世业丛与专丌 val_1 = new DevDummyController.丆下世世业丛与专丌();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丌丒丕丄丑丌世不丐 = 丌丒丕丄丑丌世不丐;
        return (System.Collections.IEnumerator)val_1;
    }
    public void SetTexture(UnityEngine.Texture 一丛丈业丏业丁下丛)
    {
        if(this.丗东专丄丙丟下丏专 == 0)
        {
                return;
        }
        
        this.丗东专丄丙丟下丏专.sharedMaterial.mainTexture = 一丛丈业丏业丁下丛;
    }
    private void 下丅丝丏专东丕万一(Player_move_c.世不丟丂上丟与丌下 丗东丏与上丆丌不且)
    {
        UnityEngine.Object val_8;
        if(HeadShotStackController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(丗东丏与上丆丌不且 == 18)
        {
            goto label_4;
        }
        
        if(丗东丏与上丆丌不且 == 17)
        {
            goto label_5;
        }
        
        if(丗东丏与上丆丌不且 != 12)
        {
            goto label_6;
        }
        
        if(null != 0)
        {
            goto label_14;
        }
        
        goto label_12;
        label_4:
        if(null != 0)
        {
            goto label_14;
        }
        
        goto label_12;
        label_5:
        if(null != 0)
        {
            goto label_14;
        }
        
        label_12:
        label_14:
        val_8 = 0.GetCurrentParticle(丁丈丄不且专丘与世:  false);
        goto label_15;
        label_6:
        val_8 = 0;
        label_15:
        if(val_8 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Quaternion val_7 = this.transform.rotation;
        val_8.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, 丁丈丄不且专丘与世:  false);
    }
    public void SetXRayShader(bool 丛丅丘一丏丙且丌上)
    {
        if(this.丗东专丄丙丟下丏专 == 0)
        {
                return;
        }
        
        this.丗东专丄丙丟下丏专.sharedMaterial.shader = (丛丅丘一丏丙且丌上 != true) ? this.丗与丆上专丆丏且丄 : this.丁世与一上丞三丌丏;
        this.丗东专丄丙丟下丏专.allowOcclusionWhenDynamic = (~丛丅丘一丏丙且丌上) & 1;
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
        return (float)this.maxHitPoints;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        System.Single[] val_17;
        float val_18;
        System.Collections.Generic.List<Player_move_c> val_19;
        var val_20;
        string val_21;
        var val_22;
        int val_23;
        int val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_17 = 丛世一丟丞丁业丘丒;
        val_18 = 丞丈专下丈专业三丞;
        val_19 = this;
        if(this.丐不丆丁三七不丌丟() == false)
        {
                return;
        }
        
        if(val_17 != null)
        {
                float val_17 = 0.5f;
            val_17 = val_18 * val_17;
            val_18 = ((val_17.丅万丝丘三业世丆丞(丏不丂丆且三丞丆丏:  22)) != true) ? (val_17) : (val_18);
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_22 = null;
            val_22 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_690.viewID == 丒丈丐丐丗丐专丈丏)
        {
                UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丆丆丞且丕丟丈专下(丌丒丕丄丑丌世不丐:  (丐丟丘世丁三丕专专 == 12) ? 1 : 0));
        }
        
        }
        
        this.下丅丝丏专东丕万一(丗东丏与上丆丌不且:  丐丟丘世丁三丕专专);
        this._animation.Stop();
        bool val_8 = this._animation.Play(animation:  "Dummy_Damage");
        val_17 = this.丞丌丙丒三丘丙上丑;
        if(this.丂上丆丞丙丆丌丕三 > 2)
        {
                val_23 = this.丞丌丙丒三丘丙上丑.Length;
            if(val_23 <= 1)
        {
                val_23 = this.丞丌丙丒三丘丙上丑.Length;
        }
        
            val_17[0] = val_17[1];
            val_24 = this.丞丌丙丒三丘丙上丑.Length;
            if(val_24 <= 2)
        {
                val_24 = this.丞丌丙丒三丘丙上丑.Length;
        }
        
            this.丞丌丙丒三丘丙上丑[1] = this.丞丌丙丒三丘丙上丑[2];
            val_17 = this.丞丌丙丒三丘丙上丑;
            val_17[2] = val_18;
        }
        else
        {
                val_17[this.丂上丆丞丙丆丌丕三] = val_18;
            int val_20 = this.丂上丆丞丙丆丌丕三;
            val_20 = val_20 + 1;
            this.丂上丆丞丙丆丌丕三 = val_20;
        }
        
        float val_21 = this.不万丛丄不丒丈东丟;
        val_21 = val_21 - val_18;
        this.不万丛丄不丒丈东丟 = val_21;
        if(val_21 > 0f)
        {
            goto label_38;
        }
        
        if(this._respawnAtStartPoint == false)
        {
            goto label_33;
        }
        
        if(this._moveDummy == 0)
        {
            goto label_38;
        }
        
        this._moveDummy.ResetPath();
        goto label_38;
        label_33:
        this._animation.CrossFade(animation:  "Dead");
        val_25 = null;
        val_25 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_21 = ProfileController.丆三丂丂丆上丆丕专();
        UnityEngine.Color val_11 = UnityEngine.Color.white;
        val_18 = val_11.r;
        丗丄万丟专丈丌丙丈(万七且丕丟世且丌不:  val_21, 丕上丗万丏丁不下丏:  0, 丗东丏与上丆丌不且:  丐丟丘世丁三丕专专, 丝丅丏丞丐丈丞三丞:  this.三丑丆与丒丐丅丌丄, 丕丏七丅丕万丗与一:  0, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_18, g = val_11.g, b = val_11.b, a = val_11.a}, 下一下丁丟丛丑不丁:  丝三丛且丘不丌丙下);
        label_38:
        if(丐丟丘世丁三丕专专 == 15)
        {
                return;
        }
        
        if(this.不万丛丄不丒丈东丟 > 0f)
        {
                return;
        }
        
        val_17 = 1152921505189965824;
        val_21 = 1152921525490623376;
        val_26 = 0;
        goto label_48;
        label_61:
        val_27 = null;
        val_27 = null;
        Player_move_c val_12 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(val_12.丕七丆丂丅丐专不丞.viewID == 丒丈丐丐丗丐专丈丏)
        {
                WeaponSounds val_14 = val_12.丙不丅丕三丂业东丕();
            if(val_14.isInvisibleAfterKill != false)
        {
                WeaponSounds val_15 = val_12.丙不丅丕三丂业东丕();
            val_12.MakeInvisibleForSecondsRPC(丙丒七丄上与丏丙丙:  val_15.invisibleAfterKillTime);
        }
        
        }
        
        val_26 = 1;
        label_48:
        val_28 = null;
        val_28 = null;
        val_19 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_26 < val_19.Count)
        {
            goto label_61;
        }
    
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return (bool)(this.isFriendly == false) ? 1 : 0;
    }
    public bool IsDead()
    {
        return (bool)(this.不万丛丄不丒丈东丟 <= 0f) ? 1 : 0;
    }
    public bool get_isLivingTarget()
    {
        return true;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
        int val_8;
        int val_9;
        string val_10;
        string val_11;
        string val_12;
        if(this.不万丛丄不丒丈东丟 <= 0f)
        {
                return;
        }
        
        if(this.不万丛丄不丒丈东丟 == this.maxHitPoints)
        {
                return;
        }
        
        this._animation.Stop();
        bool val_1 = this._animation.Play(animation:  "Dummy_Damage");
        if(this.丂上丆丞丙丆丌丕三 > 2)
        {
                val_8 = this.丞丌丙丒三丘丙上丑.Length;
            if(val_8 <= 1)
        {
                val_8 = this.丞丌丙丒三丘丙上丑.Length;
        }
        
            this.丞丌丙丒三丘丙上丑[0] = this.丞丌丙丒三丘丙上丑[1];
            val_9 = this.丞丌丙丒三丘丙上丑.Length;
            if(val_9 <= 2)
        {
                val_9 = this.丞丌丙丒三丘丙上丑.Length;
        }
        
            this.丞丌丙丒三丘丙上丑[1] = this.丞丌丙丒三丘丙上丑[2];
            this.丞丌丙丒三丘丙上丑[2] = 上上丗丁丏丙丄丏七;
        }
        else
        {
                this.丞丌丙丒三丘丙上丑[this.丂上丆丞丙丆丌丕三] = 上上丗丁丏丙丄丏七;
            int val_10 = this.丂上丆丞丙丆丌丕三;
            val_10 = val_10 + 1;
            this.丂上丆丞丙丆丌丕三 = val_10;
        }
        
        val_10 = this.三丑丆与丒丐丅丌丄 + " ";
        if(this.丂上丆丞丙丆丌丕三 >= 1)
        {
                var val_11 = 0;
            do
        {
            if(val_11 >= 1)
        {
                val_11 = val_10 + " ";
        }
        
            val_11 = val_11 + 1;
            val_12 = val_11 + this.丞丌丙丒三丘丙上丑[0][32].ToString(format:  "0.00")(this.丞丌丙丒三丘丙上丑[0][32].ToString(format:  "0.00"));
        }
        while(val_11 < this.丂上丆丞丙丆丌丕三);
        
        }
        
        this.damagesTextMesh.text = val_12;
        this.不万丛丄不丒丈东丟 = UnityEngine.Mathf.Clamp(value:  this.不万丛丄不丒丈东丟 + 上上丗丁丏丙丄丏七, min:  0f, max:  this.maxHitPoints);
    }
    public DevDummyController()
    {
        this.丕丘与丝丄丒丟丄丕 = 1.75f;
        this.healthOnRespawn = 1f;
        this.maxHitPoints = -1f;
        this.takenDamagesCapacity = 3;
        this.东丙丏一丝丒世丄丑 = "IconCursedMob";
        this._timeForHide = 5f;
        this.三丑丆与丒丐丅丌丄 = System.String.alignConst;
        this._keyLocalizeName = "";
    }

}
