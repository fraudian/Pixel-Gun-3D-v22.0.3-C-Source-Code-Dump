using UnityEngine;
internal class PlayerBotEffects : PGBehaviour
{
    // Fields
    private PlayerBotEntity myPlayerBotEntity;
    private UnityEngine.Vector2 一与东三世丘丞丙丐;
    private float 三上丅丈丄不丌万丙;
    private bool 专丐业丙专丝丆丘丟;
    
    // Properties
    internal float 丌一丘丕与丆与丙业 { get; set; }
    
    // Methods
    internal float 丁丈丑丈专丒丅丏丞(float 下丐世三丌丘丁东丟)
    {
        float val_78;
        Player_move_c val_79;
        var val_81;
        float val_82;
        var val_83;
        int val_85;
        float val_86;
        float val_87;
        float val_88;
        UnityEngine.Vector2 val_89;
        float val_90;
        float val_92;
        val_78 = 下丐世三丌丘丁东丟;
        val_79 = this;
        if(((this.myPlayerBotEntity != 0) && (this.myPlayerBotEntity.丕丁丘丆万丄世专丛 != 0)) && (this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕() != 0))
        {
                WeaponSounds val_5 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
            val_81 = val_5.categoryNabor - 1;
        }
        else
        {
                val_81 = 0;
        }
        
        int val_6 = ExperienceController.丞丞丘业东丙丏七丌();
        val_82 = 1f;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0f, y:  val_82);
        this.一与东三世丘丞丙丐 = val_7.x;
        mem[1152921538651563332] = val_7.y;
        val_83 = null;
        val_83 = null;
        float val_75 = FirstPersonControlSharp.三丏丅丐丏与下世丗;
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
            goto label_78;
        }
        
        val_75 = val_78 / val_75;
        if(this.一与东三世丘丞丙丐 <= 0f)
        {
            goto label_24;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_28;
        }
        
        if((PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_49;
        }
        
        float val_12 = PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        goto label_34;
        label_24:
        if(this.一与东三世丘丞丙丐 >= 0)
        {
            goto label_49;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_39;
        }
        
        if((PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_49;
        }
        
        float val_16 = PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        goto label_45;
        label_28:
        float val_18 = PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        label_34:
        val_18 = val_75 * val_18;
        val_18 = val_18 - val_78;
        val_18 = this.一与东三世丘丞丙丐 * val_18;
        val_78 = val_18 + val_78;
        goto label_49;
        label_39:
        float val_20 = PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        label_45:
        val_20 = val_75 * val_20;
        val_20 = val_20 - val_78;
        val_20 = this.一与东三世丘丞丙丐 * val_20;
        val_78 = val_78 - val_20;
        label_49:
        if(val_20 <= 0f)
        {
            goto label_53;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_57;
        }
        
        if((PGCompany.GamepadCoreController.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_78;
        }
        
        float val_24 = PGCompany.GamepadCoreController.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6);
        goto label_63;
        label_53:
        if(val_20 >= 0)
        {
            goto label_78;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_68;
        }
        
        if((PGCompany.GamepadCoreController.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_78;
        }
        
        float val_28 = PGCompany.GamepadCoreController.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6);
        goto label_74;
        label_57:
        float val_30 = PlayerCoreSettingsStorager.dynamicSettings.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6);
        label_63:
        val_30 = val_75 * val_30;
        val_30 = val_30 - val_78;
        val_30 = this.一与东三世丘丞丙丐 * val_30;
        val_78 = val_78 + val_30;
        goto label_78;
        label_68:
        float val_32 = PlayerCoreSettingsStorager.dynamicSettings.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6);
        label_74:
        val_32 = val_75 * val_32;
        val_32 = val_32 - val_78;
        val_32 = this.一与东三世丘丞丙丐 * val_32;
        val_78 = val_78 - val_32;
        label_78:
        float[] val_33 = new float[6];
        一三专丈世丑丆丑丐 val_34 = PlayerCoreSettingsStorager.dynamicSettings;
        val_33[0] = val_34.且丒七丝且丑丂东丞;
        一三专丈世丑丆丑丐 val_35 = PlayerCoreSettingsStorager.dynamicSettings;
        val_33[1] = val_35.丗丑丛丑丒丈丆三丑;
        一三专丈世丑丆丑丐 val_36 = PlayerCoreSettingsStorager.dynamicSettings;
        val_33[2] = val_36.且丑业且丘丟丝丙丐;
        一三专丈世丑丆丑丐 val_37 = PlayerCoreSettingsStorager.dynamicSettings;
        val_33[3] = val_37.且丙丄丏丆丅丞丙上;
        一三专丈世丑丆丑丐 val_38 = PlayerCoreSettingsStorager.dynamicSettings;
        val_33[4] = val_38.丑且丒丆丏丁丟丌丁;
        一三专丈世丑丆丑丐 val_39 = PlayerCoreSettingsStorager.dynamicSettings;
        val_85 = val_33.Length;
        if(val_85 <= 5)
        {
                val_85 = val_33.Length;
        }
        
        val_33[5] = val_39.世七丈丄丞与三丒业;
        if(((val_81 & 2147483648) == 0) && (val_81 < val_85))
        {
                val_86 = val_33[0];
            if(val_86 != 0f)
        {
                if(val_81 >= val_33.Length)
        {
                val_86 = mem[val_33[0x0] + 32];
            val_86 = val_33[0x0] + 32;
        }
        
            val_78 = val_78 * val_86;
        }
        
        }
        
        float[] val_40 = new float[6];
        一三专丈世丑丆丑丐 val_41 = PlayerCoreSettingsStorager.dynamicSettings;
        val_40[0] = val_41.且丕丝专专与丛丐不;
        一三专丈世丑丆丑丐 val_42 = PlayerCoreSettingsStorager.dynamicSettings;
        val_40[1] = val_42.丆不丘丛丝丞世上与;
        一三专丈世丑丆丑丐 val_43 = PlayerCoreSettingsStorager.dynamicSettings;
        val_40[2] = val_43.丙上上丆丑丒与上丂;
        一三专丈世丑丆丑丐 val_44 = PlayerCoreSettingsStorager.dynamicSettings;
        val_40[3] = val_44.丄丐丕专东丌丞丞世;
        一三专丈世丑丆丑丐 val_45 = PlayerCoreSettingsStorager.dynamicSettings;
        val_40[4] = val_45.丗丄丆丈丏丘下业丙;
        一三专丈世丑丆丑丐 val_46 = PlayerCoreSettingsStorager.dynamicSettings;
        val_40[5] = val_46.丕一丐丒丙丂丌下丙;
        float[] val_47 = new float[6];
        一三专丈世丑丆丑丐 val_48 = PlayerCoreSettingsStorager.dynamicSettings;
        val_47[0] = val_48.丏丆业东万上万不丟;
        一三专丈世丑丆丑丐 val_49 = PlayerCoreSettingsStorager.dynamicSettings;
        val_47[1] = val_49.丄丛丟丅三丄丟东专;
        一三专丈世丑丆丑丐 val_50 = PlayerCoreSettingsStorager.dynamicSettings;
        val_47[2] = val_50.丞上丈东一丘万不丐;
        一三专丈世丑丆丑丐 val_51 = PlayerCoreSettingsStorager.dynamicSettings;
        val_47[3] = val_51.丛丁丅丘丏丏丄上丏;
        一三专丈世丑丆丑丐 val_52 = PlayerCoreSettingsStorager.dynamicSettings;
        val_47[4] = val_52.丏业上丞丗丐丘下丐;
        一三专丈世丑丆丑丐 val_53 = PlayerCoreSettingsStorager.dynamicSettings;
        val_47[5] = val_53.下丘专专丅专丄东丘;
        if(((val_81 & 2147483648) == 0) && (val_81 < val_40.Length))
        {
                val_87 = val_40[0];
            if(val_87 != 0f)
        {
                if(val_81 >= val_40.Length)
        {
                val_87 = mem[val_40[0x0] + 32];
            val_87 = val_40[0x0] + 32;
        }
        
            if(val_78 < 0)
        {
                val_78 = val_87;
            if(val_81 >= val_40.Length)
        {
                val_78 = mem[val_40[0x0] + 32];
            val_78 = val_40[0x0] + 32;
        }
        
        }
        
        }
        
            val_88 = val_47[0];
            if(val_88 != 0f)
        {
                if(val_81 >= val_47.Length)
        {
                val_88 = mem[val_47[0x0] + 32];
            val_88 = val_47[0x0] + 32;
        }
        
            if(val_78 < 0)
        {
                val_78 = val_88;
            if(val_81 >= val_47.Length)
        {
                val_78 = mem[val_47[0x0] + 32];
            val_78 = val_47[0x0] + 32;
        }
        
        }
        
        }
        
        }
        
        一三专丈世丑丆丑丐 val_54 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_54.丁丝丁东七丘丟丐与 != 0f)
        {
                一三专丈世丑丆丑丐 val_55 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_78 < 0)
        {
                一三专丈世丑丆丑丐 val_56 = PlayerCoreSettingsStorager.dynamicSettings;
            val_78 = val_56.丁丝丁东七丘丟丐与;
        }
        
        }
        
        一三专丈世丑丆丑丐 val_57 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_57.丄丝丞专东丂丏业世 != 0f)
        {
                一三专丈世丑丆丑丐 val_58 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_78 > val_58.丄丝丞专东丂丏业世)
        {
                一三专丈世丑丆丑丐 val_59 = PlayerCoreSettingsStorager.dynamicSettings;
            val_78 = val_59.丄丝丞专东丂丏业世;
        }
        
        }
        
        val_89 = this.一与东三世丘丞丙丐;
        if(val_89 <= 0f)
        {
            goto label_164;
        }
        
        一三专丈世丑丆丑丐 val_60 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_60.丞上上七丟丌三丒上 != 0f)
        {
            goto label_168;
        }
        
        val_89 = this.一与东三世丘丞丙丐;
        label_164:
        val_90 = 1f;
        if(val_89 >= 0)
        {
            goto label_177;
        }
        
        一三专丈世丑丆丑丐 val_61 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_61.丁丈与万七丛东丛丂 == 0f)
        {
            goto label_177;
        }
        
        一三专丈世丑丆丑丐 val_62 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_76 = val_62.丁丈与万七丛东丛丂;
        val_76 = val_76 + (-1f);
        val_76 = this.一与东三世丘丞丙丐 * val_76;
        val_90 = 1f - val_76;
        goto label_177;
        label_168:
        一三专丈世丑丆丑丐 val_63 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_77 = val_63.丞上上七丟丌三丒上;
        val_77 = val_77 + (-1f);
        val_77 = val_77 * this.一与东三世丘丞丙丐;
        val_90 = val_77 + 1f;
        label_177:
        if(val_77 <= 0f)
        {
            goto label_181;
        }
        
        一三专丈世丑丆丑丐 val_64 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_64.丏东丐丑丙不万丏专 != 0f)
        {
            goto label_185;
        }
        
        label_181:
        if(val_64.丏东丐丑丙不万丏专 >= 0)
        {
            goto label_194;
        }
        
        一三专丈世丑丆丑丐 val_65 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_65.下世丙丘丑业丁丒丁 == 0f)
        {
            goto label_194;
        }
        
        一三专丈世丑丆丑丐 val_66 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_78 = val_66.下世丙丘丑业丁丒丁;
        val_78 = val_78 - val_90;
        val_78 = 1f * val_78;
        val_90 = val_90 - val_78;
        goto label_194;
        label_185:
        一三专丈世丑丆丑丐 val_67 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_79 = val_67.丏东丐丑丙不万丏专;
        val_79 = val_79 - val_90;
        val_79 = val_79 * 1f;
        val_90 = val_90 + val_79;
        label_194:
        if(((this.myPlayerBotEntity.丗三七丕丏万丘丐与 != 0) && (this.myPlayerBotEntity.丗三七丕丏万丘丐与.playerBotController != 0)) && (this.myPlayerBotEntity.丗三七丕丏万丘丐与.playerBotController.player != 0))
        {
                if(this.myPlayerBotEntity.丗三七丕丏万丘丐与.playerBotController.player.丕丁丘丆万丄世专丛 != 0)
        {
                val_82 = this.myPlayerBotEntity.丗三七丕丏万丘丐与.playerBotController.player.丕丁丘丆万丄世专丛.三上丅丈丄不丌万丙;
        }
        
        }
        
        val_78 = val_78 * val_90;
        val_92 = val_78 * val_82;
        if(this.myPlayerBotEntity == 0)
        {
                return (float)val_92;
        }
        
        if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛 == 0)
        {
                return (float)val_92;
        }
        
        if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丄丁丑丞丅一三丌丆 == false)
        {
                return (float)val_92;
        }
        
        val_79 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛;
        val_92 = val_92 * ((this.myPlayerBotEntity.丕丁丘丆万丄世专丛.七且不东世与且丒丛 == true) ? 0.8f : 0.5f);
        return (float)val_92;
    }
    internal float 业业与丈丈丝丞丟丑()
    {
        return (float)this.三上丅丈丄不丌万丙;
    }
    internal void 丒丏三七丌丁丏丞上(float 丙业与丙丗丝不丈东)
    {
        this.三上丅丈丄不丌万丙 = 丙业与丙丗丝不丈东;
    }
    internal float 上一且丝丂上丆丞万(int 七上丟东丂业丑丁丆)
    {
        下丐专一下不不上与 val_102;
        float val_103;
        var val_104;
        float val_107;
        System.Collections.Generic.Dictionary<CategoryNames, System.Single> val_108;
        var val_109;
        var val_110;
        float val_111;
        float val_112;
        float val_113;
        float val_114;
        float val_115;
        float val_116;
        float val_117;
        float val_118;
        float val_119;
        float val_120;
        float val_121;
        float val_122;
        float val_123;
        val_102 = this;
        if(GameConnect.丘不万丏万万丘丐专() != true)
        {
                if(this.专丐业丙专丝丆丘丟 == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛 != 0)
        {
                if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛.东丗丒丝丐且丞丄丏 == false)
        {
            goto label_11;
        }
        
        }
        
        if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛.业丁不丒丑丂丏三下() != 0)
        {
            goto label_16;
        }
        
        label_11:
        bool val_5 = GameConnect.万不丒丌丙万丗东不();
        WeaponSounds val_6 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
        if(val_6 == null)
        {
            goto label_21;
        }
        
        if(val_5 == false)
        {
            goto label_22;
        }
        
        label_43:
        var val_7 = (val_6.categoryNabor == 3) ? 1.15f : 1f;
        goto label_49;
        label_16:
        val_103 = 1f;
        goto label_49;
        label_4:
        if(((this.myPlayerBotEntity.丕丁丘丆万丄世专丛 == 0) || (this.myPlayerBotEntity.丕丁丘丆万丄世专丛.东丗丒丝丐且丞丄丏 == false)) || (this.myPlayerBotEntity.丕丁丘丆万丄世专丛.业丁不丒丑丂丏三下() == 0))
        {
            goto label_36;
        }
        
        val_104 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.业丁不丒丑丂丏三下().丌上丗丕不七世丅丁();
        WeaponSounds val_13 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.业丁不丒丑丂丏三下();
        goto label_42;
        label_21:
        if(val_5 == true)
        {
            goto label_43;
        }
        
        label_22:
        val_104 = val_6.丌上丗丕不七世丅丁();
        WeaponSounds val_15 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
        label_42:
        if(val_15 == null)
        {
            goto label_46;
        }
        
        if(val_104 == null)
        {
            goto label_47;
        }
        
        label_57:
        float val_17 = val_15.丌上丗丕不七世丅丁().丞世一丁丞东丐丄丐();
        goto label_49;
        label_36:
        丑丌且业丕七丞丗下 val_18 = 上三丅与与丐丆丏丙.丟业丑不丁不丌丙丟(丁丅丈丌丟世丗丗丟:  4);
        三丅丁丗丗丝丂万且 val_20 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕().丌上丗丕不七世丅丁();
        if(val_20 == null)
        {
            goto label_55;
        }
        
        float val_21 = val_20.丞世一丁丞东丐丄丐();
        goto label_56;
        label_46:
        if(val_104 != null)
        {
            goto label_57;
        }
        
        label_47:
        val_103 = val_15.speedModifier;
        label_49:
        val_107 = val_103 * this.三上丅丈丄不丌万丙;
        label_296:
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_22 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  2);
        if(val_22 != null)
        {
                float val_23 = val_22.丛丅下丆丗丏三丁丕<System.Single>();
            if(val_23 > 0f)
        {
                val_107 = val_107 * val_23;
        }
        
        }
        
        val_108 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  14);
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_25 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_25 == null)
        {
            goto label_64;
        }
        
        if((val_25.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) == 100)
        {
            goto label_65;
        }
        
        goto label_72;
        label_64:
        if((val_108 == null) || ((val_108.丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom")) != 1))
        {
            goto label_72;
        }
        
        label_65:
        val_109 = null;
        val_109 = null;
        val_108 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.下丁丏下丘丏丘丛下;
        if((val_108.ContainsKey(key:  七上丟东丂业丑丁丆)) != false)
        {
                val_110 = null;
            val_110 = null;
            val_108 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.下丁丏下丘丏丘丛下;
            val_107 = val_107 * val_108.Item[七上丟东丂业丑丁丆];
        }
        
        label_72:
        if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛 != 0)
        {
                val_108 = 1152921525483926768;
            if((this.myPlayerBotEntity.丕丁丘丆万丄世专丛.与丙丕丛一丌丛丆丈.三世丗丆丕万丐且三.ContainsKey(key:  4)) != false)
        {
                val_107 = val_107 * this.myPlayerBotEntity.丕丁丘丆万丄世专丛.与丙丕丛一丌丛丆丈.三世丗丆丕万丐且三.Item[4];
        }
        
            if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕() != 0)
        {
                WeaponSounds val_35 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
            if((val_35.三世丗丆丕万丐且三.ContainsKey(key:  13)) != false)
        {
                WeaponSounds val_37 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
            val_107 = val_107 * val_37.三世丗丆丕万丐且三.Item[13];
        }
        
        }
        
            if(this.myPlayerBotEntity.丕丁丘丆万丄世专丛.万丛丂且丙丁七万丝() != false)
        {
                val_107 = val_107 * this.myPlayerBotEntity.丕丁丘丆万丄世专丛.不丒丈上不万与丄丂();
        }
        
        }
        
        val_111 = UnityEngine.Mathf.Clamp(value:  val_107, min:  0.5f, max:  2f);
        if((this.myPlayerBotEntity.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一 != null) && (this.myPlayerBotEntity.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丅下万丏丘东丄丌万 != false))
        {
                val_102 = this.myPlayerBotEntity.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一;
            val_111 = val_111 * this.myPlayerBotEntity.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.且三丄上丗丅丗丈一.丝丗丏丟丈丕丐专七;
        }
        
        if(GameConnect.一业上七丟业且业丙() == false)
        {
                return (float)val_111;
        }
        
        val_102 = RedLightController.Instance;
        val_111 = val_111 * RedLightController.Instance.speedCoef;
        return (float)val_111;
        label_55:
        WeaponSounds val_43 = this.myPlayerBotEntity.丕丁丘丆万丄世专丛.丙不丅丕三丂业东丕();
        label_56:
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.hat.Equals(value:  "hat_KingsCrown")) != false)
        {
                val_112 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  0);
        }
        else
        {
                val_112 = 1f;
        }
        
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.hat.Equals(value:  "hat_Samurai")) != false)
        {
                val_113 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  0);
        }
        else
        {
                val_113 = 1f;
        }
        
        if((七丌丞万七万丁丐丙.一万丌东丄世上丕丟().Equals(value:  "cape_Custom")) != false)
        {
                val_114 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  0);
        }
        else
        {
                val_114 = 1f;
        }
        
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.hat.Equals(value:  "league6_hat_tiara")) != false)
        {
                val_115 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  2);
        }
        else
        {
                val_115 = 1f;
        }
        
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.hat.Equals(value:  "league3_hat_afro")) != false)
        {
                val_116 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  2);
        }
        else
        {
                val_116 = 1f;
        }
        
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.boots.Equals(value:  "boots_cyber_santa")) != false)
        {
                val_117 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  0);
        }
        else
        {
                val_117 = 1f;
        }
        
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.boots.Equals(value:  "boots_cyber_santa_Up1")) != false)
        {
                val_118 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  1);
        }
        else
        {
                val_118 = 1f;
        }
        
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.boots.Equals(value:  "boots_cyber_santa_Up2")) != false)
        {
                val_119 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  2);
        }
        else
        {
                val_119 = 1f;
        }
        
        val_120 = val_43.speedModifier;
        val_112 = val_120 * val_112;
        val_113 = val_112 * val_113;
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.boots.Equals(value:  "boots_piligrim")) != false)
        {
                val_121 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  0);
        }
        else
        {
                val_121 = 1f;
        }
        
        val_113 = val_113 * val_114;
        val_113 = val_113 * val_115;
        val_113 = val_113 * val_116;
        val_114 = val_113 * val_117;
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.boots.Equals(value:  "boots_piligrim_up1")) != false)
        {
                val_122 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  1);
        }
        else
        {
                val_122 = 1f;
        }
        
        val_114 = val_114 * val_118;
        val_119 = val_114 * val_119;
        val_119 = val_119 * val_121;
        val_119 = val_119 * val_122;
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.boots.Equals(value:  "boots_piligrim_up2")) != false)
        {
                float val_66 = val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  2);
        }
        else
        {
                val_120 = 1f;
        }
        
        val_119 = val_119 * val_120;
        val_123 = val_119 * this.三上丅丈丄不丌万丙;
        string val_67 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
        if((System.String.IsNullOrEmpty(value:  val_67)) != true)
        {
                if((System.String.op_Inequality(a:  val_67, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) != false)
        {
                val_123 = val_123 + (BalanceController.东丅专丘丏专丈丙且(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_67)));
        }
        
        }
        
        if(七上丟东丂业丑丁丆 > 5)
        {
            goto label_289;
        }
        
        var val_101 = 106039040 + (七上丟东丂业丑丁丆) << 2;
        val_101 = val_101 + 106039040;
        goto (106039040 + (七上丟东丂业丑丁丆) << 2 + 106039040);
        label_289:
        if((this.myPlayerBotEntity.一丞一丅丌丞丙丆丑.hat.Equals(value:  "hat_chest")) == false)
        {
            goto label_296;
        }
        
        val_123 = val_123 * (val_18.丑丕丌丒丑专丄世丒(丞丌东丟且丒丐丑丂:  0));
        goto label_296;
    }
    public PlayerBotEffects()
    {
        this.三上丅丈丄不丌万丙 = 1f;
    }

}
