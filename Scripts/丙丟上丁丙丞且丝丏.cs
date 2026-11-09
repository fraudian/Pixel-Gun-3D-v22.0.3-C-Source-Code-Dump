using UnityEngine;
private sealed class Player_move_c.丙丟上丁丙丞且丝丏 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private string 丛丟丒且丌丂丗丑丞;
    public string 丂上业七丘业世上丑;
    private string 与上丑不与七下丒丛;
    public string 丁丅东丝丗丅丛下丁;
    private int 专丙丐世与丐下不丑;
    public int 万丁专丄不下三上业;
    private bool 一丑丈丕丁丛一上七;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丒丙丄丄丅一丞丌丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丙丟上丁丙丞且丝丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_31;
        var val_140;
        var val_141;
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_142;
        var val_143;
        string val_144;
        var val_145;
        var val_146;
        UnityEngine.GameObject val_147;
        var val_148;
        var val_149;
        var val_150;
        var val_153;
        int val_154;
        var val_155;
        var val_156;
        var val_159;
        UnityEngine.Object val_164;
        var val_165;
        var val_166;
        float val_167;
        SkinName val_168;
        string val_169;
        SkinName val_170;
        var val_171;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_140 = this;
        this.丝且与丝丒丟万丁专.丞丕丗丟丗丛丐与三 = true;
        this.一丑丈丕丁丛一上七 = false;
        goto label_4;
        label_1:
        val_141 = this;
        val_142 = this.丒丙丄丄丅一丞丌丝;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_142 != null)
        {
            goto label_45;
        }
        
        goto label_6;
        label_3:
        val_140 = this;
        this.一丑丈丕丁丛一上七 = false;
        label_4:
        if(this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕() != 0)
        {
                mem[1152921535851729288] = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丙七丟丕且丒丅丟丅();
        }
        
        if((this.丛丟丒且丌丂丗丑丞.Contains(value:  "Weapon")) == false)
        {
            goto label_13;
        }
        
        if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.丛丟丒且丌丂丗丑丞)) != null)
        {
            goto label_16;
        }
        
        if(this.与上丑不与七下丒丛 != null)
        {
                if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.与上丑不与七下丒丛)) != null)
        {
            goto label_20;
        }
        
        }
        
        this.与上丑不与七下丒丛 = "Weapon1";
        label_20:
        object[] val_9 = new object[2];
        val_9[0] = this.丛丟丒且丌丂丗丑丞;
        val_9[1] = this.与上丑不与七下丒丛;
        UnityEngine.Debug.LogWarningFormat(format:  "{0} replaced by {1}", args:  val_9);
        this.丛丟丒且丌丂丗丑丞 = this.与上丑不与七下丒丛;
        三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.与上丑不与七下丒丛);
        if(val_10 == null)
        {
            goto label_32;
        }
        
        label_16:
        this.丝且与丝丒丟万丁专.丒丁且丟七万丙丟丂 = val_10.与不丞丑七丘丁丂丛();
        label_32:
        label_193:
        val_143 = "Weapons/"("Weapons/") + this.丛丟丒且丌丂丗丑丞;
        goto label_34;
        label_13:
        if((this.丛丟丒且丌丂丗丑丞.Equals(value:  "Like")) != false)
        {
                val_144 = "GadgetsContent/Like";
        }
        else
        {
                if((this.丛丟丒且丌丂丗丑丞.Equals(value:  "Turret")) == false)
        {
            goto label_193;
        }
        
            val_144 = "GadgetsContent/Turret";
        }
        
        label_34:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.上不东丛丆世丑丅上 = this.专丙丐世与丐下不丑;
        }
        
        this.丝且与丝丒丟万丁专.丂丗丘丁下世丙丐上 = false;
        string val_142 = "WeaponTurret";
        val_142 = this.丛丟丒且丌丂丗丑丞.Equals(value:  val_142);
        val_142 = 丌丆丒七丑丞东三丛.丐下下丅与上东丙丑(丛丄业丕且丗下一万:  val_144, 不丌丞专丈丙丛东丏:  val_142);
        val_141 = this;
        this.丒丙丄丄丅一丞丌丝 = val_142;
        if(val_142 != null)
        {
            goto label_45;
        }
        
        label_6:
        label_45:
        if(val_142.下丑万三且丟丒丌丕() == false)
        {
            goto label_46;
        }
        
        if((this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕() == 0) || (this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丞丗丒丒丗丘东丗丝() == 0))
        {
            goto label_55;
        }
        
        val_145 = 0;
        goto label_59;
        label_67:
        T val_143 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丞丗丒丒丗丘东丗丝().GetComponentsInChildren<Rocket>(includeInactive:  true)[0];
        if(val_143 == 0)
        {
            goto label_61;
        }
        
        if((val_25[0x0][0] + 48) == 0)
        {
            goto label_62;
        }
        
        label_65:
        val_143.transform.parent = 0;
        goto label_64;
        label_61:
        if(0 != 0)
        {
            goto label_65;
        }
        
        label_62:
        val_143.丙丘下丆丕丞丒专丕();
        label_64:
        val_145 = 1;
        label_59:
        if(val_145 < val_25.Length)
        {
            goto label_67;
        }
        
        label_55:
        val_146 = 1152921504838316032;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.identity;
        val_147 = UnityEngine.Object.Instantiate(original:  this.丒丙丄丄丅一丞丌丝.丂丑且与丐七丟丝下(), position:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, rotation:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w});
        if((val_147 != null) && (null != null))
        {
                val_147 = 0;
        }
        
        if(this.丝且与丝丒丟万丁专.东丗丒丝丐且丞丄丏 != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() == false)
        {
            goto label_81;
        }
        
        }
        
        val_147.SetActive(value:  false);
        label_81:
        this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒 = val_147;
        this.丝且与丝丒丟万丁专.丏丝丗万丒且七不丘(丙业与丙丗丝不丈东:  val_147.GetComponent<WeaponSounds>());
        UnityEngine.AudioSource val_36 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丐丗丑丑丏万上业下().GetComponent<UnityEngine.AudioSource>();
        if(val_36 != 0)
        {
                val_36.Play();
        }
        
        if((this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕() == 0) || (this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars == 0))
        {
            goto label_101;
        }
        
        InnerWeaponPars val_44 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars;
        if(val_44.renderArms == 0)
        {
            goto label_101;
        }
        
        InnerWeaponPars val_47 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars;
        val_148 = null;
        val_148 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_109;
        }
        
        val_149 = null;
        val_149 = null;
        if(val_47.renderArms != null)
        {
            goto label_195;
        }
        
        label_196:
        label_195:
        val_47.renderArms.allowOcclusionWhenDynamic = ((((typeof(Player_move_c).__il2cppRuntimeField_6E8 ^ 1) & 255)) != 0) ? 1 : 0;
        label_101:
        WeaponSounds val_52 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_52.isExoskelet != false)
        {
                InnerWeaponPars val_54 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars;
            if(val_54.exoskeletonBone != 0)
        {
                InnerWeaponPars val_57 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars;
            val_57.exoskeletonBone.AttachTo(专丂丕丗丗东世丞下:  this.丝且与丝丒丟万丁专.exoskeletonPoint.transform);
        }
        
            InnerWeaponPars val_60 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars;
            if(val_60.exoskeletonWeapon != 0)
        {
                InnerWeaponPars val_63 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕()._innerPars;
            val_63.exoskeletonWeapon.AttachTo(专丂丕丗丗东世丞下:  this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄());
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丛丒丙下丕丘丑丂三();
        val_150 = 1152921505066536960;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                this.丝且与丝丒丟万丁专.丐万丐业丕七三下丒(下下东且万业丞丅丒:  (this.丝且与丝丒丟万丁专.七丕丞丞丗专上丝丘 == false) ? 1 : 0);
        }
        
        WeaponSounds val_67 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_67.bulletSpawnPoints.Count >= 1)
        {
                WeaponSounds val_69 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
            this.丝且与丝丒丟万丁专.丌丆丅东不丘不丆丙 = val_69.bulletSpawnPoints.Item[0].transform;
        }
        
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.且丘丄丛下丆丟万丕() != true)) && (GameConnect.丁丁丗丐东丄丞一丛() != true))
        {
                UnityEngine.Transform val_75 = this.丝且与丝丒丟万丁专.mySkinName.armorPoint.transform;
            if(val_75.childCount >= 1)
        {
                ArmorRefs val_79 = val_75.GetChild(index:  0).GetChild(index:  0).GetComponent<ArmorRefs>();
            SetPosInArmor val_80 = val_79.leftBone.GetComponent<SetPosInArmor>();
            val_80.Target = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丛丑丂丌与丗东下专();
            SetPosInArmor val_83 = val_79.rightBone.GetComponent<SetPosInArmor>();
            val_83.Target = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丘万专丌丕与上丅丁();
            this.丝且与丝丒丟万丁专.东丄丑丈七丛丁丄丝.Clear();
            this.丝且与丝丒丟万丁专.东丄丑丈七丛丁丄丝.Add(item:  val_80);
            this.丝且与丝丒丟万丁专.东丄丑丈七丛丁丄丝.Add(item:  val_83);
            val_150 = val_150;
        }
        
        }
        
        WeaponSounds val_86 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        this.丝且与丝丒丟万丁专.mySkinName.业丕丐丆万丞上丁与(丛东丄世专丕丏东一:  (val_86.isExoskelet == true) ? 1 : 0);
        System.Collections.IEnumerator val_89 = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄().GetEnumerator();
        label_191:
        var val_144 = 0;
        val_144 = val_144 + 1;
        if(val_89.MoveNext() == false)
        {
            goto label_177;
        }
        
        var val_145 = 0;
        val_145 = val_145 + 1;
        val_153 = val_89.Current;
        if(val_153 != null)
        {
                val_153 = 0;
        }
        
        UnityEngine.Object.Destroy(obj:  val_153.gameObject);
        goto label_191;
        label_46:
        val_154 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_154;
        return (bool)val_154;
        label_177:
        val_155 = 0;
        val_156 = 0;
        goto label_194;
        label_109:
        if(val_47.renderArms != null)
        {
            goto label_195;
        }
        
        goto label_196;
        label_194:
        if(1 == 0)
        {
            goto label_207;
        }
        
        var val_148 = 38161477;
        if(mem[1103844756835] == 0)
        {
            goto label_211;
        }
        
        var val_146 = mem[1103844756725];
        var val_147 = 0;
        val_146 = val_146 + 8;
        label_210:
        if(((mem[1103844756725] + 8) + -8) == null)
        {
            goto label_209;
        }
        
        val_147 = val_147 + 1;
        val_146 = val_146 + 16;
        if(val_147 < mem[1103844756835])
        {
            goto label_210;
        }
        
        goto label_211;
        label_209:
        val_148 = val_148 + (((mem[1103844756725] + 8)) << 4);
        val_159 = val_148 + 296;
        label_211:
        1.Dispose();
        label_207:
        if(( == 1) || (1205 != 1205))
        {
            goto label_213;
        }
        
        val_155 = 0;
        if(val_147 != 0)
        {
            goto label_217;
        }
        
        goto label_215;
        label_213:
        if( != false)
        {
                val_156 = 0;
        }
        
        if(val_147 != 0)
        {
            goto label_217;
        }
        
        label_215:
        label_217:
        UnityEngine.Transform val_99 = val_147.transform;
        val_99.parent = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_101 = UnityEngine.Vector3.zero;
        val_99.position = new UnityEngine.Vector3() {x = val_101.x, y = val_101.y, z = val_101.z};
        WeaponSounds val_102 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_102.isMelee == true)
        {
            goto label_348;
        }
        
        System.Collections.IEnumerator val_103 = val_99.GetEnumerator();
        goto label_240;
        label_248:
        var val_149 = 0;
        val_149 = val_149 + 1;
        val_146 = 0;
        if(0.childCount < 1)
        {
            goto label_240;
        }
        
        val_146 = val_146.gameObject.name;
        if((val_146.Equals(value:  "BulletSpawnPoint")) == false)
        {
            goto label_240;
        }
        
        goto label_241;
        label_240:
        var val_150 = 0;
        val_150 = val_150 + 1;
        if((val_103 & 1) != 0)
        {
            goto label_248;
        }
        
        val_155 = 1;
        goto label_249;
        label_241:
        val_150 = 1152921505066536960;
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  0.GetChild(index:  0).gameObject, 丙丗七丕且与丞丘丁:  false);
        val_155 = 1;
        goto label_254;
        label_249:
        val_150 = 1152921505066536960;
        label_254:
        if(val_103 != null)
        {
                var val_151 = 0;
            val_151 = val_151 + 1;
            val_103.Dispose();
        }
        
        if(val_155 == 1)
        {
            goto label_272;
        }
        
        if((null == null) || (1363 == 1363))
        {
            goto label_348;
        }
        
        label_347:
        label_348:
        WeaponSounds val_115 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_115.bulletSpawnPoints.Count < 1)
        {
            goto label_279;
        }
        
        WeaponSounds val_117 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        val_164 = val_117.bulletSpawnPoints.Item[0];
        if(val_164 != null)
        {
            goto label_288;
        }
        
        goto label_283;
        label_279:
        val_164 = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄().Find(n:  "BulletSpawnPoint");
        if(val_164 == 0)
        {
            goto label_287;
        }
        
        if(val_164 != null)
        {
            goto label_288;
        }
        
        label_283:
        label_288:
        this.丝且与丝丒丟万丁专.专丒丅丁业丑业丅三 = val_164.gameObject;
        label_287:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_165 = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄();
        }
        else
        {
                val_165 = 0.丌丟丄业且三丛丕丄();
        }
        
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() == false)
        {
            goto label_292;
        }
        
        val_166 = null;
        val_166 = null;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
            goto label_300;
        }
        
        label_292:
        if(this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != true)
        {
                if(this.丝且与丝丒丟万丁专.七丕丞丞丗专上丝丘 == true)
        {
            goto label_300;
        }
        
        }
        
        val_167 = 0f;
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丄丕丗丗七上丕丒万() == false)
        {
            goto label_304;
        }
        
        label_300:
        val_167 = 0.4f;
        label_304:
        val_31 = 0;
        val_165.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_99.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_129 = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄().rotation;
        val_99.rotation = new UnityEngine.Quaternion() {x = val_129.x, y = val_129.y, z = val_129.z, w = val_129.w};
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.七万丗丅丄丑万丅丐();
            this.丝且与丝丒丟万丁专.丅七世丅丑不丏一丈(万丝丑丗不世丕专丁:  0);
        }
        else
        {
                0.七万丗丅丄丑万丅丐();
            0.丅七世丅丑不丏一丈(万丝丑丗不世丕专丁:  0);
        }
        
        val_168 = this.丝且与丝丒丟万丁专.mySkinName;
        if(val_168 == null)
        {
            goto label_312;
        }
        
        val_169 = this.丝且与丝丒丟万丁专.mySkinName.丌专专万丟业与丂东;
        val_170 = val_168;
        goto label_315;
        label_312:
        val_170 = this.丝且与丝丒丟万丁专.mySkinName;
        val_169 = this.丝且与丝丒丟万丁专.mySkinName.丌专专万丟业与丂东;
        if(val_170 == null)
        {
            goto label_314;
        }
        
        val_168 = val_170;
        goto label_315;
        label_314:
        val_168 = this.丝且与丝丒丟万丁专.mySkinName;
        if(val_168 == null)
        {
            goto label_316;
        }
        
        label_315:
        this.丝且与丝丒丟万丁专.丒丝丛丗丁三丅一与(丌专专万丟业与丂东:  val_169, 与丁丝七丕业业丄且:  this.丝且与丝丒丟万丁专.mySkinName.与丁丝七丕业业丄且, 丁丅上丟丑三且且丆:  this.丝且与丝丒丟万丁专.mySkinName.丁丅上丟丑三且且丆);
        WeaponSounds val_130 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(this.专丙丐世与丐下不丑 == 0)
        {
            goto label_317;
        }
        
        val_141 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_130 != null)
        {
            goto label_337;
        }
        
        label_338:
        label_337:
        val_130.上丈一万东三东世东(三丕上下丗丘丌专丒:  val_141.一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  this.专丙丐世与丐下不丑));
        this.丝且与丝丒丟万丁专.丆上丛世丌丕丙一丗 = 0;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_346;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丒丘不丞丗丞丌不丏() == 0)
        {
                if(this.丝且与丝丒丟万丁专.东丑丌丄丝世丞丘三 == false)
        {
            goto label_329;
        }
        
        }
        
        label_345:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丆丐不丈七七不业丒, 丏业丟一东丂东丘丛:  false);
        label_346:
        this.丝且与丝丒丟万丁专.万丛丘丐上丕一与且();
        val_142 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_142 != 0)
        {
                val_142 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
            val_171 = val_142;
            bool val_140 = val_171.丙七丟丕且丒丅丟丅();
        }
        else
        {
                val_171 = 0;
        }
        
        this.丝且与丝丒丟万丁专.专丞且丄丙丘丘三下(丟丗万东丙业丛世三:  this.一丑丈丕丁丛一上七, 丙业世丌丆丌丛下上:  val_171 & 1);
        label_2:
        val_154 = 0;
        return (bool)val_154;
        label_317:
        if(val_130 != null)
        {
            goto label_337;
        }
        
        goto label_338;
        label_329:
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_346;
        }
        
        if((this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丌专丒丒丛丐丘上丄 & 1) != 0)
        {
            goto label_345;
        }
        
        goto label_346;
        label_272:
        if(null != null)
        {
            goto label_347;
        }
        
        goto label_348;
        label_316:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.丙丟上丁丙丞且丝丏 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丙丟上丁丙丞且丝丏();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丛丟丒且丌丂丗丑丞 = this.丂上业七丘业世上丑;
        .与上丑不与七下丒丛 = this.丁丅东丝丗丅丛下丁;
        .专丙丐世与丐下不丑 = this.万丁专丄不下三上业;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
