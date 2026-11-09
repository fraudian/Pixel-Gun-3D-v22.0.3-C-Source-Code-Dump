using UnityEngine;
internal class PlayerDamageable : MonoBehaviour, 丅丙上七上一丐不下
{
    // Fields
    internal Player_move_c 丗丁丒三丐丞丏万下;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
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
        var val_4;
        Player_move_c val_5;
        val_4 = null;
        val_4 = null;
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.丗丁丒三丐丞丏万下, y:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
        val_5 = this.丗丁丒三丐丞丏万下;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        var val_2 = (this.丗丁丒三丐丞丏万下.东丗丒丝丐且丞丄丏 == false) ? 1 : 0;
        if(val_1 == true)
        {
            goto label_12;
        }
        
        goto label_10;
        label_6:
        val_5 = this.丗丁丒三丐丞丏万下;
        var val_3 = (this.丗丁丒三丐丞丏万下.东丗丒丝丐且丞丄丏 == false) ? 1 : 0;
        if(val_5 == null)
        {
            goto label_9;
        }
        
        if(val_1 == false)
        {
            goto label_10;
        }
        
        label_12:
        if(val_3 == 0)
        {
                return (float)this.丗丁丒三丐丞丏万下.丐一丕不丙东丄万万;
        }
        
        return val_5.专一丟丏且丆丕丝七();
        label_9:
        if(val_1 == true)
        {
            goto label_12;
        }
        
        label_10:
        if(val_3 == 0)
        {
                return (float)this.丗丁丒三丐丞丏万下.丐一丕不丙东丄万万;
        }
        
        return (float)this.丗丁丒三丐丞丏万下.丐一丕不丙东丄万万;
    }
    private void Awake()
    {
        SkinName val_1 = this.GetComponent<SkinName>();
        this.丗丁丒三丐丞丏万下 = val_1.playerMoveC;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        int val_80;
        string val_81;
        UnityEngine.Collider val_82;
        var val_83;
        float val_84;
        Player_move_c val_85;
        var val_86;
        float val_87;
        float val_88;
        float val_92;
        float val_93;
        float val_94;
        var val_95;
        var val_96;
        UnityEngine.Object val_97;
        float val_98;
        var val_99;
        var val_100;
        float val_101;
        float val_102;
        float val_103;
        var val_108;
        int val_112;
        var val_113;
        var val_114;
        var val_116;
        var val_117;
        val_80 = 丒丈丐丐丗丐专丈丏;
        val_81 = 丝三丛且丘不丌丙下;
        val_82 = 专不丑且不丏东丟丅;
        val_83 = 丛世一丟丞丁业丘丒;
        val_84 = 丞丈专下丈专业三丞;
        val_85 = 1152921505066536960;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
                return;
        }
        
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
                return;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                if(this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上 != 0)
        {
                if(this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
        {
            goto label_22;
        }
        
        }
        
        }
        
        label_42:
        val_86 = 1152921505117388800;
        val_87 = 且一丘丛丘丞丐丐业.y;
        val_88 = 且一丘丛丘丞丐丐业.z;
        if((WeaponChargeShield.且专丌丝一东丐丑丛(丂丈丙且丈丗三丆丕:  this, 专不丑且不丏东丟丅:  val_82, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = 且一丘丛丘丞丐丐业.x, y = val_87, z = val_88}, 丞丈专下丈专业三丞:  val_84, 丝三丛且丘不丌丙下:  val_81)) == true)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_32;
        }
        
        }
        
        val_82 = this.丗丁丒三丐丞丏万下;
        if(this.丗丁丒三丐丞丏万下.东丑丌丄丝世丞丘三 == true)
        {
                return;
        }
        
        label_32:
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        val_92 = val_11.x;
        val_93 = val_11.y;
        val_94 = val_11.z;
        if(val_83 == null)
        {
            goto label_156;
        }
        
        val_95 = 0;
        goto label_39;
        label_22:
        if((this != val_83) || (this.丗丁丒三丐丞丏万下.丟丌下三七丁与丟丑() == false))
        {
            goto label_42;
        }
        
        return;
        label_39:
        if((GameConnect.一与东丝万上三丆丏() != false) && ( == 0))
        {
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            val_92 = val_20.x;
            val_93 = val_20.y;
            val_94 = val_20.z;
        }
        else
        {
                UnityEngine.Vector3 val_22 = transform.position;
            val_92 = val_22.x;
            val_93 = val_22.y;
            val_94 = val_22.z;
            val_96 = val_86;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_66;
        }
        
        val_97 = 0;
        if( == 0)
        {
            goto label_69;
        }
        
        label_66:
        val_97 = GetComponent<AdvancedEffects>();
        label_69:
        if(val_97 == 0)
        {
            goto label_73;
        }
        
        if((val_97.东丑不丘丂丘丞七丁(丏不丂丆且三丞丆丏:  2, 不丟丗丏丛丕不丁丌:  this.丗丁丒三丐丞丏万下)) == true)
        {
            goto label_75;
        }
        
        goto label_77;
        label_73:
        if((0 & 1) == 0)
        {
            goto label_77;
        }
        
        label_75:
        val_98 = val_84 * 0.5f;
        label_77:
        val_80 = val_80;
        val_99 = 1152921505117388800;
        val_100 = ;
        float val_81 = 0.5f;
        val_81 = val_98 * val_81;
        float val_28 = (0 != 1) ? (val_81) : (val_98);
        if(丐丟丘世丁三丕专专 != 13)
        {
                if((val_100 | (~(this.丗丁丒三丐丞丏万下.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  0)))) != true)
        {
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
            val_102 = val_31.y;
            val_103 = val_28 * this.丗丁丒三丐丞丏万下.gadgetReflectorCoeff;
            var val_82 = 0;
            val_82 = val_82 + 1;
            val_108 = public System.Void 丅丙上七上一丐不下::ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, string 丝三丛且丘不丌丙下, int 丒丈丐丐丗丐专丈丏);
            val_87 = val_31.x;
            val_88 = val_102;
            val_83.ApplyDamage(丞丈专下丈专业三丞:  val_103, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_87, y = val_88, z = val_31.z}, 丐丟丘世丁三丕专专:  13, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丝三丛且丘不丌丙下:  val_81, 丒丈丐丐丗丐专丈丏:  this.丗丁丒三丐丞丏万下.丕七丆丂丅丐专不丞.viewID);
        }
        
        }
        
        if((this.丗丁丒三丐丞丏万下.不丌丁丁与上丘丌丈().丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  24)) != false)
        {
                var val_41 = (丐丟丘世丁三丕专专 == 26) ? 1 : 0;
            val_41 = val_41 | (val_81.Equals(value:  "exoskeletons"));
            val_41 = ((丐丟丘世丁三丕专专 == 13) ? 1 : 0) | val_41;
            val_41 = ((val_28 >= 0) ? 1 : 0) | val_41;
            val_41 = val_100 | val_41;
            if(val_41 != true)
        {
                if(UnityEngine.Random.value <= (this.丗丁丒三丐丞丏万下.不丌丁丁与上丘丌丈().七丐下东丂丅丝不丕(丂丑丑与与丘丁与丙:  24)))
        {
                UnityEngine.Vector3 val_48 = UnityEngine.Vector3.zero;
            val_102 = val_48.y;
            val_103 = val_28 * (this.丗丁丒三丐丞丏万下.不丌丁丁与上丘丌丈().丛万丟丕丗丒七不丄(丂丑丑与与丘丁与丙:  24));
            var val_83 = 0;
            val_83 = val_83 + 1;
            val_108 = public System.Void 丅丙上七上一丐不下::ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, string 丝三丛且丘不丌丙下, int 丒丈丐丐丗丐专丈丏);
            val_87 = val_48.x;
            val_88 = val_102;
            val_101 = val_28 - val_103;
            val_83.ApplyDamage(丞丈专下丈专业三丞:  val_103, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_87, y = val_88, z = val_48.z}, 丐丟丘世丁三丕专专:  26, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丝三丛且丘不丌丙下:  this.丗丁丒三丐丞丏万下.不丌丁丁与上丘丌丈().万丙丏丞一上丒丆一(丂丑丑与与丘丁与丙:  24), 丒丈丐丐丗丐专丈丏:  this.丗丁丒三丐丞丏万下.丕七丆丂丅丐专不丞.viewID);
            val_99 = val_99;
            val_100 = ;
        }
        
        }
        
        }
        
        float val_84 = 0.25f;
        val_84 = val_101 * val_84;
        float val_55 = ((val_100 | (~(this.丗丁丒三丐丞丏万下.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  8)))) != true) ? (val_101) : (val_84);
        if(丐丟丘世丁三丕专专 == 13)
        {
            goto label_156;
        }
        
        if(this.丗丁丒三丐丞丏万下.东丗丒丝丐且丞丄丏 != true)
        {
                WeaponSounds val_56 = this.丗丁丒三丐丞丏万下.丙不丅丕三丂业东丕();
            var val_57 = (val_56.isDamageReflection == false) ? 1 : 0;
            val_57 = val_100 | val_57;
            if((val_57 & 1) == 0)
        {
                WeaponSounds val_58 = this.丗丁丒三丐丞丏万下.丙不丅丕三丂业东丕();
            float val_85 = val_58.damageReflectionValue;
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.zero;
            val_102 = val_59.x;
            val_103 = val_59.z;
            val_85 = val_55 * val_85;
            var val_86 = 0;
            val_86 = val_86 + 1;
            val_83.ApplyDamage(丞丈专下丈专业三丞:  val_85, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_102, y = val_59.y, z = val_103}, 丐丟丘世丁三丕专专:  13, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丝三丛且丘不丌丙下:  val_81, 丒丈丐丐丗丐专丈丏:  this.丗丁丒三丐丞丏万下.丕七丆丂丅丐专不丞.viewID);
        }
        
        }
        
        if(this.丗丁丒三丐丞丏万下.东丗丒丝丐且丞丄丏 == false)
        {
            goto label_133;
        }
        
        label_156:
        if(val_83 == null)
        {
            goto label_160;
        }
        
        label_159:
        label_160:
        val_112 = val_99;
        val_113 = 0;
        val_114 = ;
        if((this.丗丁丒三丐丞丏万下.丟丌下三七丁与丟丑() == true) || ( == 0))
        {
            goto label_144;
        }
        
        val_114 = 1152921505117388800;
        if(((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_99 ? 丛世一丟丞丁业丘丒 : 0 + 24.丟丌下三七丁与丟丑()) == false)
        {
            goto label_144;
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.丆丆丟丑丞与上丐丗();
        val_112 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_81);
        if(val_112 == null)
        {
            goto label_149;
        }
        
        val_112 = val_112;
        Rilisoft.丞丛七上丕专丏丌丈.丁丒丈丁七丛丄丆万(丙丒丙丟丞丐丗与丄:  val_112.万上丄下业丛丌不丈(), 丈下丑丆上丏丗丈专:  val_112);
        val_80 = val_80;
        val_114 = 1152921505117388800;
        goto label_152;
        label_133:
        WeaponSounds val_68 = this.丗丁丒三丐丞丏万下.丙不丅丕三丂业东丕();
        if((val_68.isDamageAbsorption == false) || ((val_100 & 1) != 0))
        {
            goto label_156;
        }
        
        WeaponSounds val_69 = this.丗丁丒三丐丞丏万下.丙不丅丕三丂业东丕();
        float val_87 = val_69.damageReflectionValue;
        val_87 = val_55 * val_87;
        val_55 = val_55 - val_87;
        if(val_83 != null)
        {
            goto label_159;
        }
        
        goto label_160;
        label_149:
        Rilisoft.丞丛七上丕专丏丌丈.丁丒丈丁七丛丄丆万(丙丒丙丟丞丐丗与丄:  0, 丈下丑丆上丏丗丈专:  0);
        val_80 = val_80;
        label_152:
        val_113 = mem[(丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_99 ? 丛世一丟丞丁业丘丒 : 0 + 24];
        val_113 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_99 ? 丛世一丟丞丁业丘丒 : 0 + 24;
        val_113.丁丆丙丕丐丒业丏丌();
        label_144:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_166;
        }
        
        if(val_83 != null)
        {
            goto label_167;
        }
        
        goto label_174;
        label_166:
        if((val_83 == null) || (GameConnect.丅丟下专不丁一丈七() == false))
        {
            goto label_174;
        }
        
        label_167:
        var val_88 = 0;
        val_88 = val_88 + 1;
        val_81 = val_83.transform.name;
        label_174:
        if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                if(val_83 != null)
        {
                val_83 = 0;
        }
        
            if( != 0)
        {
                if(((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_114 ? 丛世一丟丞丁业丘丒 : 0 + 24.丄丝丝下丟丘丄丒丈()) != true)
        {
                val_116 = null;
            val_116 = null;
            val_113 = 1152921505196675072;
            val_117 = null;
            val_117 = null;
            val_102 = MonsterHunterModeController.丞万丌丙丟丘丁七丗;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  149, 专上丝且丂世丛丝丒:  (float)(int)val_55 * val_102);
            val_85 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_85 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            typeof(Player_move_c).__il2cppRuntimeField_618.世丄丝丏丘不丂丏丒();
        }
        
        }
        
        }
        
        this.丗丁丒三丐丞丏万下.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  val_55, 丗东丏与上丆丌不且:  丐丟丘世丁三丕专专, 与丘丂下丘丁丅与东:  东丏业丞丞业下丄世, 丞丂丂丁丝丄万一丞:  new UnityEngine.Vector3() {x = val_92, y = val_93, z = val_94}, 丝三丛且丘不丌丙下:  val_81, 丞丗且下世丐业丌丙:  val_80);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        Player_move_c val_29;
        var val_30;
        var val_31;
        var val_32;
        val_30 = 专丞上七七且丝七丗;
        if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                val_31 = ((this.丗丁丒三丐丞丏万下.东丗丒丝丐且丞丄丏 == true) ? 1 : 0) ^ ((专丞上七七且丝七丗.东丗丒丝丐且丞丄丏 == true) ? 1 : 0);
            return (bool)val_31;
        }
        
        val_29 = 1152921505171275776;
        val_32 = null;
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_68;
        }
        
        val_29 = this.丗丁丒三丐丞丏万下;
        if((val_30.Equals(other:  val_29)) == true)
        {
            goto label_64;
        }
        
        val_29 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if(val_29 == 0)
        {
            goto label_64;
        }
        
        val_29 = this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上;
        if(val_29 == 0)
        {
            goto label_64;
        }
        
        if((GameConnect.且丞丁东丝丗上丈业() == true) || (GameConnect.丙丘不世专且万丄丐() == true))
        {
            goto label_68;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_27;
        }
        
        val_29 = this.丗丁丒三丐丞丏万下.丘丑丅三丆丑丌且丝();
        if(val_29 == val_30.丘丑丅三丆丑丌且丝())
        {
            goto label_68;
        }
        
        label_27:
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_37;
        }
        
        }
        
        val_29 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == false)
        {
            goto label_37;
        }
        
        val_29 = this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上;
        if(this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
            goto label_68;
        }
        
        label_37:
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_46;
        }
        
        }
        
        val_29 = val_30.一丝丌丏万丐丌丆东();
        if(val_29 ^ this.丗丁丒三丐丞丏万下.一丝丌丏万丐丌丆东() == false)
        {
            goto label_68;
        }
        
        label_46:
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_51;
        }
        
        val_29 = this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上;
        if(val_29.丑丈上东丗丐丆世上() == false)
        {
            goto label_68;
        }
        
        val_29 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if(val_29.丑丈上东丗丐丆世上() == false)
        {
            goto label_68;
        }
        
        val_29 = this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上;
        if(val_29.丟东丘丏上世且上丕() == true)
        {
            goto label_68;
        }
        
        val_29 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if(val_29.丟东丘丏上世且上丕() == false)
        {
            goto label_68;
        }
        
        label_51:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_64;
        }
        
        val_30 = this.丗丁丒三丐丞丏万下.丟三丏丅世一丟丟上.且世专不丄丏七下万();
        if(val_30 ^ 专丞上七七且丝七丗.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
        {
            goto label_68;
        }
        
        label_64:
        val_31 = 1;
        return (bool)val_31;
        label_68:
        val_31 = 0;
        return (bool)val_31;
    }
    public bool IsDead()
    {
        if(this.丗丁丒三丐丞丏万下 != null)
        {
                return (bool)this.丗丁丒三丐丞丏万下.丙上丗丐万丏丑丘丟;
        }
        
        return (bool)this.丗丁丒三丐丞丏万下.丙上丗丐万丏丑丘丟;
    }
    public bool get_isLivingTarget()
    {
        return true;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
        Player_move_c val_2;
        var val_3;
        val_2 = this.丗丁丒三丐丞丏万下;
        if(this.丗丁丒三丐丞丏万下.丁丑丅丏丒不七上丁 != false)
        {
                val_2 = 1152921505171275776;
            val_3 = null;
            val_3 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                object[] val_1 = new object[2];
            val_1[0] = 上上丗丁丏丙丄丏七;
            val_1[1] = 丝三丛且丘不丌丙下;
            this.丗丁丒三丐丞丏万下.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  206, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        }
        
        this.丗丁丒三丐丞丏万下.一丒丝丅丂丒丕丕丕(七万丑三丐丏七丏丅:  上上丗丁丏丙丄丏七, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下);
    }
    public void AddAmmoFromWeaponOnline(float 丗与丘不且万丟丙丑)
    {
        var val_2;
        if(this.丗丁丒三丐丞丏万下.丁丑丅丏丒不七上丁 != false)
        {
                val_2 = null;
            val_2 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                object[] val_1 = new object[1];
            val_1[0] = 丗与丘不且万丟丙丑;
            this.丗丁丒三丐丞丏万下.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  220, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        }
        
        this.丗丁丒三丐丞丏万下.丑丕丛丏业丒丂丒世(丗与丘不且万丟丙丑:  丗与丘不且万丟丙丑);
    }
    public PlayerDamageable()
    {
    
    }

}
