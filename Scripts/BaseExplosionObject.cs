using UnityEngine;
internal class BaseExplosionObject : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private const string 与丕下丛丛下丆三专 = "Broken";
    private ExplosionObjectRespawnController 三下丗丂丟丈东丞丙;
    public float damagePercent;
    public UnityEngine.GameObject explosionEffect;
    public UnityEngine.GameObject explosionObject;
    protected bool 丁丏且与丗丄上丆丘;
    public bool isPoisoning;
    public bool isSlowdown;
    protected PhotonView 丄丈丑丐丆丞丘与丗;
    public int poisonCount;
    public float poisonDamageMultiplier;
    public float poisonTime;
    public bool isIgnoreIgnoreDamage;
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    public float radiusExplosion;
    public float radiusMaxExplosion;
    public float slowdownCoeff;
    public float slowdownTime;
    
    // Methods
    private void Start()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    protected virtual void 上不丒丘且丑专丞丕()
    {
        null = null;
        this.丁丏且与丗丄上丆丘 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        this.丄丈丑丐丆丞丘与丗 = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        this.丙下不丅七丂丞丐丒();
    }
    private void 丙下不丅七丂丞丐丒()
    {
        var val_22;
        var val_23;
        UnityEngine.Object val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        if(this.丁丏且与丗丄上丆丘 != false)
        {
                if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.transform.parent == 0)
        {
                return;
        }
        
        ExplosionObjectRespawnController val_7 = this.transform.parent.GetComponent<ExplosionObjectRespawnController>();
        goto label_37;
        label_4:
        val_23 = 0;
        val_24 = 0;
        goto label_12;
        label_34:
        val_25 = null;
        val_25 = null;
        if(ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈.Item[0] != 0)
        {
                val_26 = null;
            val_26 = null;
            UnityEngine.Vector3 val_12 = ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈.Item[0].transform.position;
            UnityEngine.Vector3 val_14 = this.transform.position;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            if(val_15.x < 0)
        {
                val_27 = null;
            val_27 = null;
            val_24 = ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈.Item[0];
        }
        
        }
        
        val_23 = 1;
        label_12:
        val_28 = null;
        val_28 = null;
        if(val_23 < ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈.Count)
        {
            goto label_34;
        }
        
        val_22 = 0;
        if(val_24 != 0)
        {
                val_23 = this.transform;
            val_23.parent = val_24.transform;
        }
        
        label_37:
        this.三下丗丂丟丈东丞丙 = val_24.GetComponent<ExplosionObjectRespawnController>();
    }
    private void 丗东业丒丂业上丂丏()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.explosionEffect, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        bool val_6 = this.GetComponent<UnityEngine.Animation>().Play(animation:  "Broken");
    }
    protected bool 业丅丙丏业且上丄丏(UnityEngine.Transform 丄三丟丗东丟丝下丝)
    {
        bool val_2 = 丄三丟丗东丟丝下丝.Equals(other:  this.transform);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
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
        丅丙上七上一丐不下 val_26;
        var val_27;
        float val_30;
        float val_31;
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
        
        if(this != null)
        {
                val_26 = this;
        }
        else
        {
                val_26 = 0;
        }
        
        if(val_20 != 0)
        {
                val_27 = this.transform;
            UnityEngine.Vector3 val_7 = val_27.position;
            if((WeaponChargeShield.且专丌丝一东丐丑丛(丂丈丙且丈丗三丆丕:  val_1, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丞丈专下丈专业三丞:  0f, 丝三丛且丘不丌丙下:  "")) != true)
        {
                if(this.isPoisoning != false)
        {
                val_19 = val_19.gameObject;
            val_27 = this.transform;
            UnityEngine.Vector3 val_11 = val_27.position;
            val_30 = val_11.y;
            val_25 = val_11.x;
            val_23 = val_30;
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
        val_31 = val_13.y;
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_1.ApplyDamage(丞丈专下丈专业三丞:  val_24, 丛世一丟丞丁业丘丒:  val_26, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_13.x, y = val_31, z = val_13.z}, 丐丟丘世丁三丕专专:  19, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  val_17);
    }
    private void 丘丄丘丐世七丝丝丘()
    {
        if(this.丁丏且与丗丄上丆丘 != false)
        {
                this.专丟丑丈丅丌丌丐下();
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  18, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        if(this.丁丏且与丗丄上丆丘 != false)
        {
                this.丛丏且业丈业丑丗万();
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  101, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            return;
        }
        
        if(this.三下丗丂丟丈东丞丙 == 0)
        {
                return;
        }
        
        this.三下丗丂丟丈东丞丙.StartProcessNewRespawn();
    }
    public void RunExplosion()
    {
        this.丕丅丏与丟丘东丂上(丆丝专专丟丟丈丏丐:  0);
    }
    internal void 丕丅丏与丟丘东丂上(丅丙上七上一丐不下 丆丝专专丟丟丈丏丐)
    {
        bool val_2 = this.丁丏且与丗丄上丆丘;
        this.丗东业丒丂业上丂丏();
        if(val_2 != false)
        {
                val_2 = this.丄丈丑丐丆丞丘与丗;
            val_2.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  39, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.丗丘丌丛七三丕上丛();
        this.丄丒丘七丒一丅与丐(丆丝专专丟丟丈丏丐:  丆丝专专丟丟丈丏丐);
        this.丘丄丘丐世七丝丝丘();
    }
    public virtual bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 == 101)
        {
            goto label_0;
        }
        
        if(val_1 == 39)
        {
            goto label_1;
        }
        
        if(val_1 != 18)
        {
            goto label_2;
        }
        
        this.专丟丑丈丅丌丌丐下();
        goto label_4;
        label_0:
        this.丛丏且业丈业丑丗万();
        goto label_4;
        label_1:
        this.丗东业丒丂业上丂丏();
        label_4:
        val_2 = 1;
        return (bool)val_2;
        label_2:
        val_2 = 0;
        return (bool)val_2;
    }
    internal void 专丟丑丈丅丌丌丐下()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
            return;
        }
        
        this.explosionObject.SetActive(value:  false);
    }
    internal void 丛丏且业丈业丑丗万()
    {
        if(this.三下丗丂丟丈东丞丙 == 0)
        {
                return;
        }
        
        this.三下丗丂丟丈东丞丙.StartProcessNewRespawn();
    }
    internal void 业丐丞万与七万丗与()
    {
        this.丗东业丒丂业上丂丏();
    }
    public BaseExplosionObject()
    {
        this.damagePercent = 10f;
        this.poisonCount = 3;
        this.poisonDamageMultiplier = 0.1f;
        this.poisonTime = 2f;
        this.poisonType = 1;
    }

}
