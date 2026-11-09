using UnityEngine;
internal sealed class SettingsPoisonParams : PGBehaviour
{
    // Fields
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    internal float multiplayerDamage;
    internal float poisonTime;
    internal int poisonCount;
    internal WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    internal bool isIgnoreIgnoreDamage;
    private Player_move_c.丛上一丂不业丒丄丏 与三下丙丕丅不一七;
    public string weaponId;
    private 丅丙上七上一丐不下 丆丏丏七丒七丟丝丌;
    private System.Collections.Generic.List<SettingsPoisonParams.业万上丄东一上世丂> 丁丐万万丏与丂专丙;
    
    // Methods
    private void Awake()
    {
        this.下丅丐一一丌丐丙丒();
    }
    internal void 下丅丐一一丌丐丙丒()
    {
        mem[1152921539752216704] = 0;
        this.与三下丙丕丅不一七 = 0;
    }
    internal void 丟丞丝丝东丆七且且(丅丙上七上一丐不下 世万丘丟丐上世不上)
    {
        this.丆丏丏七丒七丟丝丌 = 世万丘丟丐上世不上;
    }
    private void Update()
    {
        this.丅不丟丒且丂与世丆();
    }
    internal void 一且专下丆业且万一(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕, Player_move_c.丛上一丂不业丒丄丏 万东丏丌不七东丘万)
    {
        var val_10;
        var val_11;
        val_10 = this;
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        val_11 = 0;
        goto label_2;
        label_11:
        业万上丄东一上世丂 val_1 = this.丁丐万万丏与丂专丙.Item[0];
        if((val_1.丞下万上三丘上与专 & 1) == 0)
        {
            goto label_6;
        }
        
        业万上丄东一上世丂 val_2 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_2.丂丐丄丁丆与丈丂上 == 786092400)
        {
            goto label_9;
        }
        
        label_6:
        val_11 = 1;
        label_2:
        if(val_11 < this.丁丐万万丏与丂专丙.Count)
        {
            goto label_11;
        }
        
        .丞下万上三丘上与专 = 丂丈丙且丈丗三丆丕;
        .丅且丐丟不世丁万丆 = 万东丏丌不七东丘万.丂丐丈丕丞下丁下丘 + 1;
        .丂丐丄丁丆与丈丂上 = 万东丏丌不七东丘万.三一丝且丝丛不丄丐;
        mem[1152921539752714648] = 万东丏丌不七东丘万.丈丒丄丝丐专丐丙丌;
        mem[1152921539752714652] = 万东丏丌不七东丘万.丂丐丈丕丞下丁下丘;
        mem[1152921539752714656] = 万东丏丌不七东丘万.丂上上不一丐业一丕;
        .且丝一丈丟下丞丅与 = UnityEngine.Time.time;
        this.丁丐万万丏与丂专丙.Add(item:  new SettingsPoisonParams.业万上丄东一上世丂());
        return;
        label_9:
        val_10 = this.丁丐万万丏与丂专丙.Item[0];
        val_7.丅且丐丟不世丁万丆 = 万东丏丌不七东丘万.丂丐丈丕丞下丁下丘 + 1;
        val_7.丂丐丄丁丆与丈丂上 = 万东丏丌不七东丘万.三一丝且丝丛不丄丐;
        mem2[0] = 万东丏丌不七东丘万.丈丒丄丝丐专丐丙丌;
        mem2[0] = 万东丏丌不七东丘万.丂丐丈丕丞下丁下丘;
        mem2[0] = 万东丏丌不七东丘万.丂上上不一丐业一丕;
    }
    private void 丅不丟丒且丂与世丆()
    {
        var val_36;
        var val_37;
        丅丙上七上一丐不下 val_39;
        var val_40;
        int val_41;
        var val_42;
        var val_43;
        float val_45;
        var val_46;
        var val_47;
        val_36 = 0;
        goto label_38;
        label_95:
        业万上丄东一上世丂 val_1 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_1.丞下万上三丘上与专 == null)
        {
            goto label_6;
        }
        
        业万上丄东一上世丂 val_2 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_2.丞下万上三丘上与专 != null)
        {
                val_37 = null;
        }
        
        val_37 = null;
        var val_3 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_37) ? val_2.丞下万上三丘上与专 : 0;
        if(((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_37 ? val_2.丞下万上三丘上与专 : 0 + 24.丘七业丒丐世丂丅丒()) <= 0f)
        {
            goto label_28;
        }
        
        label_6:
        业万上丄东一上世丂 val_5 = this.丁丐万万丏与丂专丙.Item[0];
        if((val_5.丞下万上三丘上与专 & 1) != 0)
        {
            goto label_28;
        }
        
        业万上丄东一上世丂 val_6 = this.丁丐万万丏与丂专丙.Item[0];
        var val_37 = 0;
        val_37 = val_37 + 1;
        if(val_6.丞下万上三丘上与专.IsDead() == true)
        {
            goto label_28;
        }
        
        业万上丄东一上世丂 val_9 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_9.丅且丐丟不世丁万丆 <= 0)
        {
            goto label_28;
        }
        
        业万上丄东一上世丂 val_10 = this.丁丐万万丏与丂专丙.Item[0];
        float val_11 = UnityEngine.Time.time;
        if(val_10.且丝一丈丟下丞丅与 >= 0)
        {
            goto label_90;
        }
        
        val_39 = this.丆丏丏七丒七丟丝丌;
        if(val_39 == null)
        {
            goto label_36;
        }
        
        val_39 = 0;
        goto label_36;
        label_28:
        this.丁丐万万丏与丂专丙.RemoveAt(index:  0);
        label_90:
        val_36 = 0;
        goto label_38;
        label_36:
        业万上丄东一上世丂 val_15 = this.丁丐万万丏与丂专丙.Item[0];
        业万上丄东一上世丂 val_16 = this.丁丐万万丏与丂专丙.Item[0];
        int val_38 = this.poisonCount;
        val_38 = val_38 + 1;
        float val_17 = (val_16.丅且丐丟不世丁万丆 == val_38) ? 0f : val_10.且丝一丈丟下丞丅与;
        if(this.丁丐万万丏与丂专丙.Item[0] != null)
        {
                val_41 = val_18.丅且丐丟不世丁万丆;
        }
        else
        {
                val_41 = 28563616;
            val_40 = 24;
        }
        
        mem[24] = 28563615;
        业万上丄东一上世丂 val_19 = this.丁丐万万丏与丂专丙.Item[0];
        if((( != 0) ? 1 : 0) == 0)
        {
            goto label_48;
        }
        
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        业万上丄东一上世丂 val_21 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_21.丂丐丄丁丆与丈丂上 != 2)
        {
            goto label_53;
        }
        
        val_42 = 1;
        goto label_54;
        label_48:
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        业万上丄东一上世丂 val_23 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_23.丂丐丄丁丆与丈丂上 != 1)
        {
            goto label_59;
        }
        
        val_43 = 12;
        goto label_71;
        label_53:
        label_54:
        var val_39 = 0;
        val_39 = val_39 + 1;
        goto label_67;
        label_59:
        业万上丄东一上世丂 val_25 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_25.丂丐丄丁丆与丈丂上 != 2)
        {
            goto label_70;
        }
        
        val_43 = 14;
        goto label_71;
        label_67:
        val_45 = val_17;
        val_19.丞下万上三丘上与专.ApplyDamage(丞丈专下丈专业三丞:  val_45, 丛世一丟丞丁业丘丒:  this.丆丏丏七丒七丟丝丌, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  this.丁丐万万丏与丂专丙.Item[0], 丝三丛且丘不丌丙下:  this.weaponId, 丒丈丐丐丗丐专丈丏:  0);
        goto label_72;
        label_70:
        业万上丄东一上世丂 val_27 = this.丁丐万万丏与丂专丙.Item[0];
        label_71:
        业万上丄东一上世丂 val_29 = this.丁丐万万丏与丂专丙.Item[0];
        if(val_29.丂丐丄丁丆与丈丂上 == 2)
        {
                val_46 = 0;
            val_47 = 1;
        }
        else
        {
                val_46 = 0;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        val_45 = val_17;
        val_19.丞下万上三丘上与专.ApplyDamage(丞丈专下丈专业三丞:  val_45, 丛世一丟丞丁业丘丒:  this.丆丏丏七丒七丟丝丌, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, 丐丟丘世丁三丕专专:  (val_27.丂丐丄丁丆与丈丂上 == 3) ? 17 : 0, 东丏业丞丞业下丄世:  this.丁丐万万丏与丂专丙.Item[0], 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        label_72:
        业万上丄东一上世丂 val_32 = this.丁丐万万丏与丂专丙.Item[0];
        float val_33 = UnityEngine.Time.time;
        业万上丄东一上世丂 val_34 = this.丁丐万万丏与丂专丙.Item[0];
        val_33 = val_33 + val_22.x;
        val_32.且丝一丈丟下丞丅与 = val_33;
        goto label_90;
        label_38:
        if(val_36 < this.丁丐万万丏与丂专丙.Count)
        {
            goto label_95;
        }
    
    }
    internal void 丈丞与与丕丕一丝世(丅丙上七上一丐不下 丕不丝丛丌丁万上万, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 丂且丑三且丌丘下丌)
    {
        this.丈丞与与丕丕一丝世(丕不丝丛丌丁万上万:  丕不丝丛丌丁万上万, 专不丑且不丏东丟丅:  专不丑且不丏东丟丅, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {三一丝且丝丛不丄丐 = this.与三下丙丕丅不一七, 丈丒丄丝丐专丐丙丌 = this.与三下丙丕丅不一七, 丂丐丈丕丞下丁下丘 = this.与三下丙丕丅不一七, 丂上上不一丐业一丕 = ???, 丝三丛且丘不丌丙下 = ???, 东丏业丞丞业下丄世 = ???, 丌丛丑三丆丘万丘丛 = ???});
    }
    private void 丈丞与与丕丕一丝世(丅丙上七上一丐不下 丕不丝丛丌丁万上万, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 丂且丑三且丌丘下丌, Player_move_c.丛上一丂不业丒丄丏 丂丐丄丁丆与丈丂上)
    {
        float val_55;
        var val_56;
        float val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_69;
        val_56 = 1152921539753617120;
        val_57 = 丂且丑三且丌丘下丌.z;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if((WeaponChargeShield.且专丌丝一东丐丑丛(丂丈丙且丈丗三丆丕:  丕不丝丛丌丁万上万, 专不丑且不丏东丟丅:  专不丑且不丏东丟丅, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = val_57}, 丞丈专下丈专业三丞:  0f, 丝三丛且丘不丌丙下:  "")) == true)
        {
                return;
        }
        
        if(丕不丝丛丌丁万上万 == null)
        {
            goto label_5;
        }
        
        val_55 = 1152921505318985728;
        val_58 = null;
        val_58 = null;
        if(PlayerEffectContainer.丗上与丈丕丁且七世 == false)
        {
            goto label_10;
        }
        
        label_85:
        if(8 == 0)
        {
            goto label_11;
        }
        
        label_106:
        if(((null != null) || (丕不丝丛丌丁万上万.VoodooTarget == null)) || (丕不丝丛丌丁万上万.VoodooTarget == null))
        {
            goto label_35;
        }
        
        丅丙上七上一丐不下 val_5 = 丕不丝丛丌丁万上万.VoodooTarget;
        if(val_5 != null)
        {
                val_59 = null;
        }
        
        val_59 = null;
        val_55 = 1152921505318985728;
        val_60 = null;
        var val_6 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_59) ? (val_5) : 0;
        val_60 = null;
        if(this.isIgnoreIgnoreDamage == true)
        {
            goto label_35;
        }
        
        val_61 = 787035888;
        if(val_61 == 2)
        {
                val_55 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_59 ? val_5 : 0 + 24.不丌丁丁与上丘丌丈();
            if((val_55.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  1)) == true)
        {
                return;
        }
        
            val_61 = 787035888;
        }
        
        if(val_61 == 3)
        {
                val_55 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_59 ? val_5 : 0 + 24.不丌丁丁与上丘丌丈();
            if((val_55.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  2)) == true)
        {
                return;
        }
        
            val_61 = 787035888;
        }
        
        if((val_61 != 1) || (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_59 ? val_5 : 0 + 24.不丌丁丁与上丘丌丈().丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  3)) == false))
        {
            goto label_35;
        }
        
        return;
        label_5:
        label_35:
        val_55 = 1152921505240178688;
        var val_63 = 0;
        val_63 = val_63 + 1;
        string val_15 = 丕不丝丛丌丁万上万.transform.tag;
        if((System.String.op_Equality(a:  val_15, b:  "Enemy")) == false)
        {
            goto label_42;
        }
        
        if(787035888 != 2)
        {
            goto label_168;
        }
        
        var val_64 = 0;
        val_64 = val_64 + 1;
        goto label_48;
        label_42:
        if((System.String.op_Equality(a:  val_15, b:  "Player")) == false)
        {
            goto label_49;
        }
        
        if(787035888 != 2)
        {
            goto label_54;
        }
        
        if(丕不丝丛丌丁万上万 == null)
        {
            goto label_51;
        }
        
        goto label_54;
        label_49:
        if((System.String.op_Equality(a:  val_15, b:  "Turret")) == false)
        {
            goto label_55;
        }
        
        var val_65 = 0;
        val_65 = val_65 + 1;
        goto label_60;
        label_55:
        if((System.String.op_Equality(a:  val_15, b:  "DamagedExplosion")) == false)
        {
            goto label_61;
        }
        
        if(787035888 != 2)
        {
                return;
        }
        
        goto label_168;
        label_48:
        AdvancedEffects val_23 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<AdvancedEffects>();
        if(val_23 == 0)
        {
            goto label_168;
        }
        
        val_57 = 丂丐丄丁丆与丈丂上.丈丒丄丝丐专丐丙丌;
        val_55 = 丂丐丄丁丆与丈丂上.丂丐丈丕丞下丁下丘;
        float val_66 = val_55;
        val_66 = val_57 * val_66;
        val_23.SendAdvancedEffect(三丛丄一东丑丁且业:  1, 丘万丟丕与专丁三丘:  val_66, 丆丅丅丂下丏丏丞丂:  0);
        goto label_168;
        label_61:
        if((System.String.op_Equality(a:  val_15, b:  "Pet")) == false)
        {
                return;
        }
        
        if(787035888 != 2)
        {
            goto label_133;
        }
        
        var val_67 = 0;
        val_67 = val_67 + 1;
        goto label_77;
        label_51:
        var val_68 = 0;
        val_68 = val_68 + 1;
        goto label_81;
        label_10:
        if(null != 0)
        {
                return;
        }
        
        goto label_85;
        label_60:
        TurretController val_29 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<TurretController>();
        if(val_29 == 0)
        {
            goto label_118;
        }
        
        if(787035888 != 2)
        {
            goto label_91;
        }
        
        if(val_29.isEnemyTurret == true)
        {
            goto label_93;
        }
        
        goto label_94;
        label_11:
        val_69 = 787035888;
        if(val_69 == 2)
        {
                val_55 = 专不丑且不丏东丟丅.不丌丁丁与上丘丌丈();
            if((val_55.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  1)) == true)
        {
                return;
        }
        
            val_69 = 787035888;
        }
        
        if(val_69 == 3)
        {
                val_55 = 专不丑且不丏东丟丅.不丌丁丁与上丘丌丈();
            if((val_55.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  2)) == true)
        {
                return;
        }
        
            val_69 = 787035888;
        }
        
        if((val_69 != 1) || ((专不丑且不丏东丟丅.不丌丁丁与上丘丌丈().丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  3)) == false))
        {
            goto label_106;
        }
        
        return;
        label_81:
        SkinName val_40 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<SkinName>();
        val_55 = val_40.playerMoveC.丙不丅丕三丂业东丕();
        if(val_41.fireImmunity != false)
        {
                if(8 == 0)
        {
                return;
        }
        
        }
        
        val_55 = 丂丐丄丁丆与丈丂上.丂上上不一丐业一丕;
        val_57 = 丂丐丄丁丆与丈丂上.丈丒丄丝丐专丐丙丌;
        float val_69 = (float)丂丐丄丁丆与丈丂上.丂丐丈丕丞下丁下丘;
        val_69 = val_57 * val_69;
        val_40.playerMoveC.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  val_55, 三丛丄一东丑丁且业:  1, 丘万丟丕与专丁三丘:  val_69, 丆丅丅丂下丏丏丞丂:  0);
        label_54:
        label_168:
        this.一且专下丆业且万一(丂丈丙且丈丗三丆丕:  丕不丝丛丌丁万上万, 万东丏丌不七东丘万:  new 丛上一丂不业丒丄丏() {三一丝且丝丛不丄丐 = 丂丐丄丁丆与丈丂上.三一丝且丝丛不丄丐, 丈丒丄丝丐专丐丙丌 = 1.060537E-10f, 丂丐丈丕丞下丁下丘 = 2.524357E-29f, 丂上上不一丐业一丕 = 丂丐丄丁丆与丈丂上.丂上上不一丐业一丕, 东丏业丞丞业下丄世 = 丂丐丄丁丆与丈丂上.三一丝且丝丛不丄丐, 丌丛丑三丆丘万丘丛 = true});
        return;
        label_91:
        if(val_29 == null)
        {
            goto label_118;
        }
        
        label_94:
        if(null != null)
        {
            goto label_118;
        }
        
        label_93:
        if(val_29.isRun == false)
        {
            goto label_118;
        }
        
        if(787035888 != 2)
        {
            goto label_140;
        }
        
        var val_70 = 0;
        val_70 = val_70 + 1;
        goto label_124;
        label_77:
        AdvancedEffects val_45 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<AdvancedEffects>();
        if(val_45 != 0)
        {
                float val_71 = (float)丂丐丄丁丆与丈丂上.丂丐丈丕丞下丁下丘;
            val_71 = 丂丐丄丁丆与丈丂上.丈丒丄丝丐专丐丙丌 * val_71;
            val_45.SendAdvancedEffect(三丛丄一东丑丁且业:  1, 丘万丟丕与专丁三丘:  val_71, 丆丅丅丂下丏丏丞丂:  0);
        }
        
        label_133:
        goto label_168;
        label_124:
        AdvancedEffects val_50 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<AdvancedEffects>();
        if(val_50 != 0)
        {
                float val_72 = (float)丂丐丄丁丆与丈丂上.丂丐丈丕丞下丁下丘;
            val_72 = 丂丐丄丁丆与丈丂上.丈丒丄丝丐专丐丙丌 * val_72;
            val_50.SendAdvancedEffect(三丛丄一东丑丁且业:  1, 丘万丟丕与专丁三丘:  val_72, 丆丅丅丂下丏丏丞丂:  0);
        }
        
        label_140:
        this.一且专下丆业且万一(丂丈丙且丈丗三丆丕:  丕不丝丛丌丁万上万, 万东丏丌不七东丘万:  new 丛上一丂不业丒丄丏() {三一丝且丝丛不丄丐 = 丂丐丄丁丆与丈丂上.三一丝且丝丛不丄丐, 丈丒丄丝丐专丐丙丌 = 1.060537E-10f, 丂丐丈丕丞下丁下丘 = 2.524357E-29f, 丂上上不一丐业一丕 = 丂丐丄丁丆与丈丂上.丂上上不一丐业一丕, 东丏业丞丞业下丄世 = 丂丐丄丁丆与丈丂上.三一丝且丝丛不丄丐, 丌丛丑三丆丘万丘丛 = true});
        label_118:
        var val_73 = 0;
        val_73 = val_73 + 1;
        TurretControllerScene val_55 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<TurretControllerScene>();
        if(val_55 == 0)
        {
                return;
        }
        
        if(val_56 != 2)
        {
                return;
        }
        
        if(val_55.isEnemyTurret == false)
        {
                return;
        }
        
        if(val_55.isActive == false)
        {
                return;
        }
        
        if(787035888 != 2)
        {
            goto label_168;
        }
        
        var val_74 = 0;
        val_74 = val_74 + 1;
        AdvancedEffects val_61 = 丕不丝丛丌丁万上万.transform.gameObject.GetComponent<AdvancedEffects>();
        if(val_61 == 0)
        {
            goto label_168;
        }
        
        float val_75 = (float)丂丐丄丁丆与丈丂上.丂丐丈丕丞下丁下丘;
        val_75 = 丂丐丄丁丆与丈丂上.丈丒丄丝丐专丐丙丌 * val_75;
        val_61.SendAdvancedEffect(三丛丄一东丑丁且业:  1, 丘万丟丕与专丁三丘:  val_75, 丆丅丅丂下丏丏丞丂:  0);
        goto label_168;
    }
    public SettingsPoisonParams()
    {
        this.weaponId = "";
        this.丁丐万万丏与丂专丙 = new System.Collections.Generic.List<业万上丄东一上世丂>();
    }

}
