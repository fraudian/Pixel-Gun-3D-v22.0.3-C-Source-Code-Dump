using UnityEngine;
internal class BreakableObject : PGBehaviour, 丅丙上七上一丐不下
{
    // Fields
    public UnityEngine.GameObject breakObject;
    public UnityEngine.GameObject breakEffect;
    public float healthInit;
    public float breakEffectTime;
    private bool isRespawnable;
    public float respawnTime;
    private float 丕丗丑七丁万不世丘;
    private bool damageExplosion;
    public float health;
    public short myIndex;
    public bool isKilled;
    public UnityEngine.GameObject explosionEffect;
    public UnityEngine.GameObject fireEffect;
    public float percentHealthForFireEffect;
    public float timeToDestroyByFire;
    public float damagePercent;
    public UnityEngine.GameObject explosionObject;
    protected bool 丁丏且与丗丄上丆丘;
    public bool isPoisoning;
    public bool isSlowdown;
    protected PhotonView 丄丈丑丐丆丞丘与丗;
    public int poisonCount;
    public bool isIgnoreIgnoreDamage;
    public float poisonDamageMultiplier;
    public float poisonTime;
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    public float radiusExplosion;
    public float radiusMaxExplosion;
    public float slowdownCoeff;
    public float slowdownTime;
    private float 下万且与上丝且七世;
    private bool 丞丅丐丂丞丁丅丒丝;
    private float 与七丙且丅丁丒丝且;
    private const string 与丕下丛丛下丆三专 = "Broken";
    private float 与丐丆且上丌丏丌丒;
    private bool 丗丗丙万丆丗东丒丙;
    private UnityEngine.Collider 且丙与丏下丅丐世丑;
    private 丅丙上七上一丐不下 不不业丑丞丑上丝丕;
    public string lastDamagerName;
    public int lastDamagerId;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public bool 与丐丗丁东丞万东丞 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    public bool get_isDamaged()
    {
        return (bool)(this.health < 0) ? 1 : 0;
    }
    private void 上丛万丄丕专丈丝丐(丅丙上七上一丐不下 丑丒丐丈丒下世丒丅)
    {
        this.不不业丑丞丑上丝丕 = 丑丒丐丈丒下世丒丅;
        if(丑丒丐丈丒下世丒丅 == null)
        {
                return;
        }
        
        this.lastDamagerName = mem[137123368] + 480;
        this.lastDamagerId = 丑丒丐丈丒下世丒丅.viewID;
    }
    private void Awake()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        this.且丙与丏下丅丐世丑 = this.GetComponent<UnityEngine.Collider>();
        this.isKilled = false;
        this.health = this.healthInit;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    public void ResetState()
    {
        this.isKilled = false;
        this.health = this.healthInit;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
    }
    private void Update()
    {
        float val_5;
        if(this.丗丗丙万丆丗东丒丙 != false)
        {
                val_5 = this.与丐丆且上丌丏丌丒 - UnityEngine.Time.deltaTime;
            this.与丐丆且上丌丏丌丒 = val_5;
            if(val_5 <= 0f)
        {
                this.丗丗丙万丆丗东丒丙 = false;
            if(this.breakEffect != 0)
        {
                this.breakEffect.SetActive(value:  false);
        }
        
        }
        
        }
        
        if(this.丕丗丑七丁万不世丘 > 0f)
        {
                val_5 = this.丕丗丑七丁万不世丘 - UnityEngine.Time.deltaTime;
            if(val_5 <= 0f)
        {
                this.isKilled = false;
            this.health = this.healthInit;
            this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
            val_5 = 0f;
        }
        
            this.丕丗丑七丁万不世丘 = val_5;
        }
        
        if(this.damageExplosion == false)
        {
                return;
        }
        
        if(this.丞丅丐丂丞丁丅丒丝 == false)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.与七丙且丅丁丒丝且 - val_4;
        this.与七丙且丅丁丒丝且 = val_4;
        if(val_4 > 0f)
        {
                return;
        }
        
        this.丞丅丐丂丞丁丅丒丝 = false;
        if(this.isKilled != false)
        {
                return;
        }
        
        this.丕丅丏与丟丘东丂上(丆丝专专丟丟丈丏丐:  this.不不业丑丞丑上丝丕);
    }
    private void 东丒万丘丆丐世丕丗(bool 下下东且万业丞丅丒)
    {
        UnityEngine.Collider val_6;
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        this.breakObject.SetActive(value:  下下东且万业丞丅丒);
        if(this.且丙与丏下丅丐世丑 == 0)
        {
                val_6 = this.GetComponent<UnityEngine.Collider>();
            this.且丙与丏下丅丐世丑 = val_6;
        }
        else
        {
                val_6 = this.且丙与丏下丅丐世丑;
        }
        
        if(val_6 != 0)
        {
                val_6 = this.且丙与丏下丅丐世丑;
            val_6.enabled = 下下东且万业丞丅丒;
        }
        
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        if(this.breakEffect != 0)
        {
                this.breakEffect.SetActive(value:  false);
        }
        
        this.丗丗丙万丆丗东丒丙 = false;
    }
    private void 丆下不丛三世丞且丝()
    {
        if(this.breakEffect != 0)
        {
                this.breakEffect.SetActive(value:  true);
        }
        
        this.丗丗丙万丆丗东丒丙 = true;
        this.与丐丆且上丌丏丌丒 = this.breakEffectTime;
    }
    private void 七丛丐与丑丈一万丁(bool 丌丝丌丁下丐丞丆一)
    {
        this.health = 0f;
        this.与七丙且丅丁丒丝且 = 0f;
        this.isKilled = true;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  false);
        if(丌丝丌丁下丐丞丆一 != true)
        {
                this.丆下不丛三世丞且丝();
        }
        
        if(this.isRespawnable == false)
        {
                return;
        }
        
        if(this.丕丗丑七丁万不世丘 != 0f)
        {
                return;
        }
        
        this.丕丗丑七丁万不世丘 = this.respawnTime;
    }
    private void 七丅丘七丁七丌丗丅()
    {
        this.isKilled = false;
        this.health = this.healthInit;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
        this.丕丗丑七丁万不世丘 = 0f;
    }
    public void PrepareObject(short 丞世不丒下上上丝丑)
    {
        this.myIndex = 丞世不丒下上上丝丑;
        this.transform.parent = 0;
    }
    public void GetDamageRPC(float 且丑丐丂与丐丟丒下)
    {
        if(this.isKilled == true)
        {
                return;
        }
        
        且丑丐丂与丐丟丒下 = this.health - 且丑丐丂与丐丟丒下;
        this.health = 且丑丐丂与丐丟丒下;
        if(且丑丐丂与丐丟丒下 > 0f)
        {
                return;
        }
        
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  false);
    }
    private void 业丂丛丟上且丂东丂(float 且丑丐丂与丐丟丒下, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒)
    {
        BreakableObjectsController val_2;
        if(this.isKilled != false)
        {
                return;
        }
        
        this.上丛万丄丕专丈丝丐(丑丒丐丈丒下世丒丅:  丛世一丟丞丁业丘丒);
        val_2 = BreakableObjectsController.丄丘七三上丕世丞业;
        val_2.SendDamage(丞世不丒下上上丝丑:  this.myIndex, 且丑丐丂与丐丟丒下:  且丑丐丂与丐丟丒下);
        if(this.damageExplosion != false)
        {
                float val_2 = this.health;
            val_2 = val_2 / this.healthInit;
            this.下万且与上丝且七世 = this.healthInit;
            val_2 = val_2 * 100f;
            if(val_2 <= this.percentHealthForFireEffect)
        {
                val_2 = this.fireEffect;
            if(val_2.activeSelf != true)
        {
                val_2 = true;
            this.丅丞丌丐丙三丈丄与(下下东且万业丞丅丒:  true);
            this.丞丅丐丂丞丁丅丒丝 = val_2;
            this.与七丙且丅丁丒丝且 = this.timeToDestroyByFire;
        }
        
        }
        
            float val_3 = this.health;
            val_3 = val_3 - 且丑丐丂与丐丟丒下;
            this.health = val_3;
            if(val_3 > 0f)
        {
                return;
        }
        
            this.health = 0f;
            this.丕丅丏与丟丘东丂上(丆丝专专丟丟丈丏丐:  丛世一丟丞丁业丘丒);
            return;
        }
        
        if(this.isKilled == true)
        {
                return;
        }
        
        float val_4 = this.health;
        val_4 = val_4 - 且丑丐丂与丐丟丒下;
        this.health = val_4;
        if(val_4 > 0f)
        {
                return;
        }
        
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  false);
    }
    private void 丅丞丌丐丙三丈丄与(bool 下下东且万业丞丅丒)
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                bool val_1 = 下下东且万业丞丅丒;
            this.丘丈上丅与丏丑丈业(下下东且万业丞丅丒:  val_1);
            BreakableObjectsController.丄丘七三上丕世丞业.SendVisibleFireEffect(丞世不丒下上上丝丑:  this.myIndex, 业下丌下三丕丙丌下:  val_1);
            return;
        }
        
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        this.fireEffect.SetActive(value:  下下东且万业丞丅丒);
    }
    private void 丕丅丏与丟丘东丂上(丅丙上七上一丐不下 丆丝专专丟丟丈丏丐)
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        this.丗东业丒丂业上丂丏();
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                BreakableObjectsController.丄丘七三上丕世丞业.SendPlayDestroyEffect(丞世不丒下上上丝丑:  this.myIndex);
        }
        
        val_2 = null;
        val_2 = null;
        Rilisoft.丞丛七上丕专丏丌丈.丗丘丌丛七三丕上丛();
        this.丄丒丘七丒一丅与丐(丆丝专专丟丟丈丏丐:  丆丝专专丟丟丈丏丐);
    }
    private void 丄丒丘七丒一丅与丐(丅丙上七上一丐不下 丆丝专专丟丟丈丏丐)
    {
        丅丙上七上一丐不下 val_28;
        var val_29;
        float val_30;
        float val_31;
        float val_32;
        var val_33;
        UnityEngine.Object val_34;
        var val_38;
        var val_39;
        val_28 = 丆丝专专丟丟丈丏丐;
        val_29 = 1152921505320529920;
        一三专丈世丑丆丑丐 val_1 = PlayerCoreSettingsStorager.dynamicSettings;
        val_30 = val_1.下丆业七丐一世丝下;
        if(val_30 != 0f)
        {
                一三专丈世丑丆丑丐 val_2 = PlayerCoreSettingsStorager.dynamicSettings;
            float val_31 = val_2.下丆业七丐一世丝下;
            val_31 = this.radiusExplosion * val_31;
            this.radiusExplosion = val_31;
            一三专丈世丑丆丑丐 val_3 = PlayerCoreSettingsStorager.dynamicSettings;
            val_30 = this.radiusMaxExplosion * val_3.下丆业七丐一世丝下;
            this.radiusMaxExplosion = val_30;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_31 = this.radiusExplosion;
        val_32 = val_5.x;
        if(val_7.Length == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<丅丙上七上一丐不下> val_8 = new System.Collections.Generic.List<丅丙上七上一丐不下>();
        val_29 = 1152921525534304336;
        val_33 = 0;
        val_32 = this.radiusExplosion * this.radiusExplosion;
        goto label_12;
        label_63:
        val_34 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_32, y = val_5.y, z = val_5.z}, radius:  val_31, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())[0].gameObject;
        if(val_34 != 0)
        {
                val_34 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_7[0x0] + 32);
            if(val_34 != null)
        {
                var val_33 = 0;
            val_33 = val_33 + 1;
            if((val_34.transform != 0) && ((val_8.Contains(item:  val_34)) != true))
        {
                var val_34 = 0;
            val_34 = val_34 + 1;
            if((this.业丅丙丏业且上丄丏(丄三丟丗东丟丝下丝:  val_34.transform)) != false)
        {
                var val_35 = 0;
            val_35 = val_35 + 1;
            UnityEngine.Vector3 val_22 = val_34.transform.position;
            UnityEngine.Vector3 val_24 = this.transform.position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_31 = val_25.x;
            if(val_31 <= val_32)
        {
                val_38 = 0;
            if( != 0)
        {
                val_39 = null;
            val_39 = null;
            val_28 = val_28;
            val_29 = 1152921525534304336;
            if(((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_12 : 0 + 24) == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
                FirstPersonControlSharp.丄丑不万丏一一丄万();
        }
        
        }
        
            var val_36 = 0;
            val_36 = val_36 + 1;
            this.丌丐万丛三上一与东(丞下万上三丘上与专:  val_34.transform, 三丁丄丄丐丕丞丆丗:  val_31, 丈丈丆丟东万不丟丈:  val_32, 丌丗丝上丂丕丐丐丁:  this.radiusMaxExplosion * this.radiusMaxExplosion, 丆丝专专丟丟丈丏丐:  val_28);
            val_8.Add(item:  val_34);
        }
        
        }
        
        }
        
        }
        
        }
        
        val_33 = 1;
        label_12:
        if(val_33 < val_7.Length)
        {
            goto label_63;
        }
    
    }
    private void 丌丐万丛三上一与东(UnityEngine.Transform 丞下万上三丘上与专, float 三丁丄丄丐丕丞丆丗, float 丈丈丆丟东万不丟丈, float 丌丗丝上丂丕丐丐丁, 丅丙上七上一丐不下 丆丝专专丟丟丈丏丐)
    {
        int val_17;
        float val_18;
        UnityEngine.Transform val_19;
        UnityEngine.Object val_20;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_28;
        float val_29;
        val_17 = 丆丝专专丟丟丈丏丐;
        val_18 = 丌丗丝上丂丕丐丐丁;
        val_19 = 丞下万上三丘上与专;
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_19);
        if(val_1 == null)
        {
                return;
        }
        
        if(val_17 != null)
        {
                val_20 = 0;
            val_17 = 0;
        }
        else
        {
                val_20 = 0;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_22 = 0.01f;
        val_23 = this.damagePercent * val_22;
        val_24 = val_1.maxHealth * val_23;
        if(三丁丄丄丐丕丞丆丗 > val_18)
        {
                float val_4 = 三丁丄丄丐丕丞丆丗 - val_18;
            val_4 = 丈丈丆丟东万不丟丈 - val_4;
            val_25 = val_4 / 丈丈丆丟东万不丟丈;
            val_24 = val_25 * val_24;
        }
        
        if(val_20 != 0)
        {
                UnityEngine.Vector3 val_7 = this.transform.position;
            if((WeaponChargeShield.且专丌丝一东丐丑丛(丂丈丙且丈丗三丆丕:  val_1, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丞丈专下丈专业三丞:  0f, 丝三丛且丘不丌丙下:  "")) != true)
        {
                if(this.isPoisoning != false)
        {
                val_19 = val_19.gameObject;
            UnityEngine.Vector3 val_11 = this.transform.position;
            val_28 = val_11.y;
            val_25 = val_11.x;
            val_23 = val_28;
            val_22 = val_11.z;
            val_20.丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_19, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_25, y = val_23, z = val_22}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
        }
        
            if(this.isSlowdown != false)
        {
                val_25 = this.slowdownTime;
            val_23 = this.slowdownCoeff;
            val_20.与东丁业丁与且丌丕(丂丈丙且丈丗三丆丕:  val_1, 七丏上不丒万丐东丄:  val_25, 三上丅丈丄不丌万丙:  val_23);
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_13 = this.transform.position;
        val_29 = val_13.y;
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_1.ApplyDamage(丞丈专下丈专业三丞:  val_24, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_13.x, y = val_29, z = val_13.z}, 丐丟丘世丁三丕专专:  19, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  val_17);
    }
    public void SetSyncHealth(byte 丌丞东上丝丆一专七)
    {
        float val_2 = 255f;
        val_2 = ((float)丌丞东上丝丆一专七 & 255) / val_2;
        val_2 = val_2 * this.healthInit;
        this.health = val_2;
        if(val_2 > 0f)
        {
                if(this.isKilled == false)
        {
                return;
        }
        
            this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
            this.isKilled = false;
            return;
        }
        
        if(this.isKilled != false)
        {
                return;
        }
        
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  true);
    }
    public byte GetSyncHealth()
    {
        if(this.isKilled != false)
        {
                return 0;
        }
        
        float val_1 = this.health;
        val_1 = val_1 / this.healthInit;
        val_1 = val_1 * 255f;
        return (byte)(int)val_1;
    }
    public void SetSyncTimeLeftToRespawn(byte 丁不丞丂丐丂丈丈丈)
    {
        float val_2 = 255f;
        val_2 = ((float)丁不丞丂丐丂丈丈丈 & 255) / val_2;
        val_2 = val_2 * this.respawnTime;
        this.丕丗丑七丁万不世丘 = val_2;
    }
    public byte GetSyncTimeLeftToRespawn()
    {
        float val_1 = this.respawnTime;
        val_1 = this.丕丗丑七丁万不世丘 / val_1;
        val_1 = val_1 * 255f;
        return (byte)(int)val_1;
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
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.业丂丛丟上且丂东丂(且丑丐丂与丐丟丒下:  丞丈专下丈专业三丞, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return true;
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
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 == 88)
        {
            goto label_1;
        }
        
        if(val_1 != 39)
        {
            goto label_2;
        }
        
        this.丗东业丒丂业上丂丏();
        goto label_3;
        label_1:
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        this.丘丈上丅与丏丑丈业(下下东且万业丞丅丒:  false);
        label_3:
        val_2 = 1;
        return (bool)val_2;
        label_2:
        val_2 = 0;
        return (bool)val_2;
    }
    internal void 丘丈上丅与丏丑丈业(bool 下下东且万业丞丅丒)
    {
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        this.fireEffect.SetActive(value:  下下东且万业丞丅丒);
    }
    internal void 业丐丞万与七万丗与()
    {
        this.丗东业丒丂业上丂丏();
    }
    private void 丗东业丒丂业上丂丏()
    {
        this.fireEffect.SetActive(value:  false);
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.explosionEffect, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.Animation>())) != false)
        {
                bool val_8 = this.GetComponent<UnityEngine.Animation>().Play(animation:  "Broken");
        }
        
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  false);
    }
    protected bool 业丅丙丏业且上丄丏(UnityEngine.Transform 丄三丟丗东丟丝下丝)
    {
        bool val_2 = 丄三丟丗东丟丝下丝.Equals(other:  this.transform);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    public BreakableObject()
    {
        this.healthInit = 1f;
        this.breakEffectTime = 0f;
        this.health = 100f;
        this.myIndex = 65535;
        this.percentHealthForFireEffect = 95f;
        this.timeToDestroyByFire = 5f;
        this.damagePercent = 10f;
        this.poisonCount = 3;
        this.poisonDamageMultiplier = 0.1f;
        this.poisonTime = 2f;
        this.poisonType = 1;
    }

}
