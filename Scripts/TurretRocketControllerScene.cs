using UnityEngine;
public class TurretRocketControllerScene : MonoBehaviour
{
    // Fields
    private bool rotateToMoveDirection;
    private float 与七丙一不上丏万丆;
    private UnityEngine.Rigidbody 丛三万上丌丈丟丛丑;
    public float splashRadius;
    internal bool 且丝业丙丁丂万丞与;
    internal bool 丅七上一丈丕上丒丞;
    internal FortEquipObject 丌不且专丘丆丞丂丟;
    public bool usePointDamage;
    public bool useExplosionEffect;
    private string explosionName;
    public string fortObjectName;
    public UnityEngine.GameObject objectAfterDestroy;
    public float objectAfterDestroyLifetime;
    public WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    internal Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐;
    public float poisonDamageMultipier;
    public int poisonHitsCount;
    public float poisonHitsDelay;
    internal Rilisoft.丏丏专丙世丝万丅且 丈丒丌丄丗不东万丛;
    public float poisonAreaDamageMultipier;
    public float poisonAreaHitsDelay;
    private AutoAimTurretRocket 上丁不世丞丗丄世丞;
    private UnityEngine.Transform 丛丌丕丐世丑丂七丂;
    private float 丝与业丑七下下丝丙;
    private float 一与东丑丄丁丏七丘;
    
    // Properties
    private float 丞丈专下丈专业三丞 { get; }
    
    // Methods
    private float 下与丗丒丐三丕丘丈()
    {
        if(this.丌不且专丘丆丞丂丟 == 0)
        {
                return 1f;
        }
        
        if(this.丌不且专丘丆丞丂丟 != null)
        {
                return this.丌不且专丘丆丞丂丟.下与丗丒丐三丕丘丈();
        }
        
        return this.丌不且专丘丆丞丂丟.下与丗丒丐三丕丘丈();
    }
    private void Awake()
    {
        this.丛三万上丌丈丟丛丑 = this.GetComponent<UnityEngine.Rigidbody>();
        this.上丁不世丞丗丄世丞 = this.GetComponent<UnityEngine.Rigidbody>();
    }
    internal void SetTarget(UnityEngine.Transform 丞下万上三丘上与专)
    {
        this.丛丌丕丐世丑丂七丂 = 丞下万上三丘上与专;
        if(this.上丁不世丞丗丄世丞 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(AutoAimTurretRocket).__il2cppRuntimeField_168;
    }
    internal void 丝丏丗丘丞丄丘丅且(float 丟丞一专丕三东丗一)
    {
        this.丝与业丑七下下丝丙 = 丟丞一专丕三东丗一;
        if(this.上丁不世丞丗丄世丞 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(AutoAimTurretRocket).__il2cppRuntimeField_1B8;
    }
    private void Update()
    {
        if(this.rotateToMoveDirection != false)
        {
                if(this.丛三万上丌丈丟丛丑 != 0)
        {
                UnityEngine.Vector3 val_3 = this.丛三万上丌丈丟丛丑.velocity;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.与七丙一不上丏万丆 - val_5;
        this.与七丙一不上丏万丆 = val_5;
        if(val_5 > 0f)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    internal virtual bool 丕丛丆丞下丅且丆丂(Player_move_c 专丞上七七且丝七丗)
    {
        var val_5;
        var val_6;
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_3;
        }
        
        label_12:
        val_5 = 0;
        return (bool)val_5;
        label_3:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_7;
        }
        
        val_6 = null;
        val_6 = null;
        if(SiegeController.三三万丆下一丗万丛.attackTeam != 专丞上七七且丝七丗.丘丑丅三丆丑丌且丝())
        {
            goto label_12;
        }
        
        label_7:
        val_5 = 1;
        return (bool)val_5;
    }
    private void OnCollisionEnter(UnityEngine.Collision 三丑丈且丏业丐丝丗)
    {
        丅丙上七上一丐不下 val_67;
        float val_68;
        float val_69;
        float val_70;
        float val_71;
        丅丙上七上一丐不下 val_72;
        var val_75;
        int val_78;
        var val_80;
        val_67 = 三丑丈且丏业丐丝丗.transform.root;
        if((val_67.CompareTag(tag:  "Rocket")) == true)
        {
                return;
        }
        
        val_68 = this.splashRadius;
        val_69 = 0.1f;
        if(val_68 < 0)
        {
                this.usePointDamage = true;
        }
        
        if(this.useExplosionEffect != false)
        {
                UnityEngine.GameObject val_7 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.explosionName)) != true) ? (this.explosionName) : "Explosion47"));
            if(val_7 != 0)
        {
                UnityEngine.Vector3 val_11 = this.transform.position;
            val_70 = val_11.x;
            val_71 = val_11.z;
            val_68 = val_70;
            val_69 = val_11.y;
            val_7.transform.position = new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_71};
        }
        
        }
        
        if(this.usePointDamage == false)
        {
            goto label_18;
        }
        
        val_67 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  三丑丈且丏业丐丝丗.collider);
        if(((val_67 == null) || (this.丌不且专丘丆丞丂丟 == 0)) || ((this.丌不且专丘丆丞丂丟.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_67)) == false))
        {
            goto label_148;
        }
        
        if(this.丌不且专丘丆丞丂丟 == null)
        {
            goto label_26;
        }
        
        var val_16 = (((FortEquipObject.__il2cppRuntimeField_typeHierarchy + (TurretControllerScene.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? this.丌不且专丘丆丞丂丟 : 0;
        goto label_28;
        label_18:
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_18 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  this.且丝业丙丁丂万丞与, 丅七上一丈丕上丒丞:  this.丅七上一丈丕上丒丞).世且一丄且上丄不一();
        val_70 = 2f;
        label_86:
        var val_69 = 0;
        val_69 = val_69 + 1;
        if(val_18.MoveNext() == false)
        {
            goto label_35;
        }
        
        var val_70 = 0;
        val_70 = val_70 + 1;
        T val_22 = val_18.Current;
        UnityEngine.Vector3 val_23 = val_22.position;
        UnityEngine.Vector3 val_25 = this.transform.position;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        float val_71 = this.splashRadius;
        val_71 = val_71 * val_71;
        if(val_26.x >= 0)
        {
            goto label_86;
        }
        
        丅丙上七上一丐不下 val_27 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_22);
        if(((val_27 == null) || (this.丌不且专丘丆丞丂丟 == 0)) || ((this.丌不且专丘丆丞丂丟.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_27)) == false))
        {
            goto label_86;
        }
        
        if(this.丌不且专丘丆丞丂丟 != null)
        {
                val_75 = 0;
        }
        else
        {
                val_75 = 0;
        }
        
        if((this.丌不且专丘丆丞丂丟.丘丂不业一丆且上丂 == 0) || (this.丌不且专丘丆丞丂丟.丘丂不业一丆且上丂.photonView == 0))
        {
            goto label_65;
        }
        
        float val_33 = this.下与丗丒丐三丕丘丈();
        UnityEngine.Vector3 val_35 = this.transform.position;
        UnityEngine.Vector3 val_37 = this.transform.forward;
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  val_70);
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
        var val_72 = 0;
        val_72 = val_72 + 1;
        goto label_76;
        label_65:
        float val_41 = this.下与丗丒丐三丕丘丈();
        UnityEngine.Vector3 val_43 = this.transform.position;
        UnityEngine.Vector3 val_45 = this.transform.forward;
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  val_70);
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, b:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z});
        var val_73 = 0;
        val_73 = val_73 + 1;
        float val_49 = this.splashRadius * this.splashRadius;
        val_49 = val_41 / val_49;
        val_49 = 1f - val_49;
        val_49 = val_41 * val_49;
        val_27.ApplyDamage(丞丈专下丈专业三丞:  val_49, 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  this.fortObjectName, 丒丈丐丐丗丐专丈丏:  0);
        goto label_85;
        label_76:
        float val_51 = this.splashRadius * this.splashRadius;
        val_51 = val_33 / val_51;
        val_51 = 1f - val_51;
        val_51 = val_33 * val_51;
        val_27.ApplyDamage(丞丈专下丈专业三丞:  val_51, 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  this.fortObjectName, 丒丈丐丐丗丐专丈丏:  this.丌不且专丘丆丞丂丟.丘丂不业一丆且上丂.photonView.viewID);
        label_85:
        this.丈丒丟丕丗丒丕一丛(丂丈丙且丈丗三丆丕:  val_27);
        goto label_86;
        label_26:
        val_72 = 0;
        label_28:
        if(this.丌不且专丘丆丞丂丟.photonView == 0)
        {
                val_78 = 0;
        }
        else
        {
                val_78 = this.丌不且专丘丆丞丂丟.photonView.viewID;
        }
        
        val_70 = this.下与丗丒丐三丕丘丈();
        UnityEngine.Collider val_57 = 三丑丈且丏业丐丝丗.collider;
        UnityEngine.Vector3 val_59 = this.transform.position;
        UnityEngine.Vector3 val_61 = this.transform.forward;
        UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, d:  2f);
        UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, b:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z});
        val_71 = val_63.y;
        var val_74 = 0;
        val_74 = val_74 + 1;
        goto label_101;
        label_35:
        val_80 = 0;
        val_67 = 0;
        if(val_18 != null)
        {
            goto label_102;
        }
        
        goto label_142;
        label_101:
        val_67.ApplyDamage(丞丈专下丈专业三丞:  val_70, 丛世一丟丞丁业丘丒:  val_72, 专不丑且不丏东丟丅:  val_57, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_63.x, y = val_71, z = val_63.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  this.fortObjectName, 丒丈丐丐丗丐专丈丏:  val_78);
        this.丈丒丟丕丗丒丕一丛(丂丈丙且丈丗三丆丕:  val_67);
        goto label_148;
        label_102:
        var val_75 = 0;
        val_75 = val_75 + 1;
        val_57.Dispose();
        label_142:
        label_148:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        UnityEngine.Vector3 val_68 = this.transform.position;
        this.丞丌丏丂丟东丕丞不(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z});
    }
    private void 丈丒丟丕丗丒丕一丛(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        丅丙上七上一丐不下 val_7;
        if(this.三一丝且丝丛不丄丐 == 0)
        {
                return;
        }
        
        float val_2 = this.下与丗丒丐三丕丘丈();
        val_2 = val_2 * this.poisonDamageMultipier;
        this.丌不且专丘丆丞丂丟.下丏万七东丐世业丆().丅世丏七丅东丄万一(三一丝且丝丛不丄丐:  this.三一丝且丝丛不丄丐, 丞丈专下丈专业三丞:  val_2, 丂丐丈丕丞下丁下丘:  this.poisonHitsDelay, 丂上上不一丐业一丕:  this.poisonHitsCount, 东丏业丞丞业下丄世:  this.typeDead, 丈丁丄丘丛世七丙丝:  this.fortObjectName, 丌丛丑三丆丘万丘丛:  false);
        if(this.丌不且专丘丆丞丂丟 != null)
        {
                var val_3 = (((FortEquipObject.__il2cppRuntimeField_typeHierarchy + (TurretControllerScene.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? this.丌不且专丘丆丞丂丟 : 0;
        }
        else
        {
                val_7 = 0;
        }
        
        UnityEngine.Vector3 val_6 = this.transform.position;
        this.丌不且专丘丆丞丂丟.下丏万七东丐世业丆().丝丙丂丅丘丄丙丂三(世万丘丟丐上世不上:  val_7, 丂丈丙且丈丗三丆丕:  丂丈丙且丈丗三丆丕, 专不丑且不丏东丟丅:  0, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
    }
    private void 丞丌丏丂丟东丕丞不(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_19;
        float val_20;
        var val_24;
        var val_25;
        val_19 = 业丒丝丗与丐丛丟丏.z;
        val_20 = 业丒丝丗与丐丛丟丏.x;
        if(this.objectAfterDestroy == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.objectAfterDestroy);
        val_2.transform.position = new UnityEngine.Vector3() {x = val_20, y = 业丒丝丗与丐丛丟丏.y, z = val_19};
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        val_20 = val_5.z;
        val_2.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_20, w = val_5.w};
        DamageInRadiusEffect val_6 = val_2.GetComponent<DamageInRadiusEffect>();
        if(val_6 == 0)
        {
            goto label_13;
        }
        
        float val_8 = this.下与丗丒丐三丕丘丈();
        if(this.丈丒丌丄丗不东万丛 != 0)
        {
                val_20 = this.下与丗丒丐三丕丘丈();
            val_6.丕丙丝丞丐丐三丄丝(三一丝且丝丛不丄丐:  this.丈丒丌丄丗不东万丛, 丂丐丈丕丞下丁下丘:  1f, 丒丙丘丕且一丞丕丑:  val_8 * this.poisonAreaDamageMultipier, 丂上上不一丐业一丕:  this.poisonHitsCount, 丒下世丝丂万丑丏下:  val_20 * this.poisonAreaDamageMultipier, 万丗丛丐丅丄七不丅:  this.splashRadius, 丂三丟丂丈丐丆丗丟:  1f, 丝三丛且丘不丌丙下:  this.fortObjectName, 东丏业丞丞业下丄世:  this.typeDead, 丅业下不东丗丄与三:  20, 丌丛丑三丆丘万丘丛:  false);
        }
        else
        {
                val_20 = this.poisonDamageMultipier;
            val_8 = val_8 * val_20;
            val_6.丆丌且丙丝不万丂丆(丒下世丝丂万丑丏下:  val_8, 万丗丛丐丅丄七不丅:  this.splashRadius, 丂三丟丂丈丐丆丗丟:  1f, 丝三丛且丘不丌丙下:  this.fortObjectName, 东丏业丞丞业下丄世:  this.typeDead, 丅业下不东丗丄与三:  20);
        }
        
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_14 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  this.且丝业丙丁丂万丞与, 丅七上一丈丕上丒丞:  this.丅七上一丈丕上丒丞).世且一丄且上丄不一();
        label_31:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_24;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        new System.Collections.Generic.List<UnityEngine.Transform>().Add(item:  val_14.Current);
        goto label_31;
        label_24:
        val_24 = 0;
        val_25 = 0;
        if(val_14 == null)
        {
            
        }
        else
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_14.Dispose();
        }
        
        val_6.下丞与与三上丟丙与(专丒丗与东丗与丙业:  true, 世一丅丌专丕东丑丗:  (this.且丝业丙丁丂万丞与 == true) ? 1 : 0);
        label_13:
        val_19 = this.objectAfterDestroyLifetime;
        if(val_19 <= 0f)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2, t:  val_19);
    }
    internal void 丕不丙丈与丅上丂业(Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, float 丒丂且不丅丞三丒世)
    {
        this.丈丒丌丄丗不东万丛 = 三一丝且丝丛不丄丐;
        this.poisonAreaDamageMultipier = 丒丂且不丅丞三丒世;
    }
    internal void 下专与三丗丂丒不丑(float 丂业丑丅与且三丐与)
    {
        this.一与东丑丄丁丏七丘 = 丂业丑丅与且三丐与;
    }
    public TurretRocketControllerScene()
    {
        this.与七丙一不上丏万丆 = 7f;
        this.splashRadius = 6f;
        this.useExplosionEffect = true;
        this.objectAfterDestroyLifetime = -1f;
        this.poisonAreaHitsDelay = -1f;
        this.fortObjectName = "";
    }

}
