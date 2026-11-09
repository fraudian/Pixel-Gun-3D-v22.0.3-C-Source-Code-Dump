using UnityEngine;
internal class 不丘丄丝丗丒丙一丌
{
    // Fields
    private static System.Action<float, bool> 下三丕与丟丗世丂丁;
    internal Rilisoft.丒且丐三丁丅丕一业 一上下东丗丌丈一丞;
    internal Rilisoft.丒且丐三丁丅丕一业 下丁丘下丄丛业丑东;
    protected Rilisoft.丒且丐三丁丅丕一业 丝万一丑丛丕丒七丅;
    protected Rilisoft.丒且丐三丁丅丕一业 丒丐与丕丆丏丑且上;
    internal bool 上丙万上丆万丂丁世;
    protected float 一下丗丌丒丏不丘不;
    protected bool 丅丗丝丄丕丌丑丈与;
    private 丕丈丏丝丗下丟丅丂 <丒丘丁上丆丂一上业>k__BackingField;
    
    // Properties
    internal virtual string 一丄七丟丈丝丙丌丞 { get; }
    internal virtual bool 丁丟东丁丑三与且万 { get; }
    internal virtual bool 七七业丒丟丝丘不丞 { get; }
    internal bool 丑世七丈上不丒丛丂 { get; }
    internal virtual float 且丑世专丐丑不下丏 { get; }
    internal virtual float 丛七世丙丙与不丄丗 { get; }
    internal float 丁万业丕三丄不丅丞 { get; }
    internal float 专丄不丒丕业东丆丏 { get; }
    internal virtual 丕丈丏丝丗下丟丅丂 丁丏专且丙下丒丕不 { get; set; }
    
    // Methods
    internal static void 世丅丞一万丟丛东丏(System.Action<float, bool> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  不丘丄丝丗丒丙一丌.下三丕与丟丗世丂丁, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 万且不丛一业与丘丗(System.Action<float, bool> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  不丘丄丝丗丒丙一丌.下三丕与丟丗世丂丁, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal virtual string 下丑不七不万丛上一()
    {
        return (string)System.String.alignConst;
    }
    internal 不丘丄丝丗丒丙一丌(丕丈丏丝丗下丟丅丂 丟丟万一不业上丐丗)
    {
        this.一上下东丗丌丈一丞 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.下丁丘下丄丛业丑东 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        goto typeof(不丘丄丝丗丒丙一丌).__il2cppRuntimeField_1C8;
    }
    internal virtual bool 上丈丟七万且丞丌上()
    {
        Rilisoft.丒且丐三丁丅丕一业 val_4;
        var val_5;
        val_4 = this;
        if(this.一上下东丗丌丈一丞.丝丙丐且丟丅三丛七() == 0f)
        {
                val_4 = this.下丁丘下丄丛业丑东;
            var val_3 = (val_4.丝丙丐且丟丅三丛七() == 0f) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal virtual bool 丛丏不与丆丅业东丗()
    {
        return true;
    }
    internal bool 丄不与丁丗东专且丈()
    {
        return (bool)(this.下丁丘下丄丛业丑东.丝丙丐且丟丅三丛七() > 0f) ? 1 : 0;
    }
    internal virtual float 丙丈丗丌丘三丄业且()
    {
        if(this.丝万一丑丛丕丒七丅 != null)
        {
                return this.丝万一丑丛丕丒七丅.丝丙丐且丟丅三丛七();
        }
        
        if(this != null)
        {
                return this.丙丈丗丌丘三丄业且();
        }
        
        return this.丙丈丗丌丘三丄业且();
    }
    internal virtual float 丌丛丟丙丘丝丂一不()
    {
        if(this.丒丐与丕丆丏丑且上 != null)
        {
                return this.丒丐与丕丆丏丑且上.丝丙丐且丟丅三丛七();
        }
        
        if(this != null)
        {
                return this.丌丛丟丙丘丝丂一不();
        }
        
        return this.丌丛丟丙丘丝丂一不();
    }
    internal float 世丙丈丁丘七七丌丝()
    {
        if(V0.16B == 0f)
        {
                return 0f;
        }
        
        float val_1 = this.一上下东丗丌丈一丞.丝丙丐且丟丅三丛七();
        val_1 = val_1 / V0.16B;
        return 0f;
    }
    internal float 且丑丂丐不七丌丌丂()
    {
        if(V0.16B == 0f)
        {
                return 0f;
        }
        
        float val_1 = this.下丁丘下丄丛业丑东.丝丙丐且丟丅三丛七();
        val_1 = val_1 / V0.16B;
        return 0f;
    }
    internal virtual 丕丈丏丝丗下丟丅丂 丙丕丞且丕不丘丙丑()
    {
        return (丕丈丏丝丗下丟丅丂)this.<丒丘丁上丆丂一上业>k__BackingField;
    }
    internal virtual void 丆一丙丁上丁丞丄丒(丕丈丏丝丗下丟丅丂 丙业与丙丗丝不丈东)
    {
        this.<丒丘丁上丆丂一上业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 业丈一丒丒专上不丝(string 丆与丕丕丂下丟一丈)
    {
        bool val_1 = 丆与丕丕丂下丟一丈.Contains(value:  "Weapon");
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal static 不丘丄丝丗丒丙一丌 东丝七业丄丑丒世七(丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝)
    {
        丆丈且且一上业丛一 val_156;
        丕业丗丆丈万丅丗丈 val_157;
        不丘丄丝丗丒丙一丌 val_158;
        if(丁且丌丁丆丝丙丘丝 == null)
        {
            goto label_1;
        }
        
        val_156 = 0;
        if((System.String.IsNullOrEmpty(value:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) == true)
        {
                return (不丘丄丝丗丒丙一丌)val_156;
        }
        
        if((System.String.op_Equality(a:  "gadget_fraggrenade", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_3;
        }
        
        val_157 = new 丕业丗丆丈万丅丗丈();
        val_157 = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
        goto label_4;
        label_1:
        val_156 = 0;
        return (不丘丄丝丗丒丙一丌)val_156;
        label_3:
        val_157 = 0;
        label_4:
        if((System.String.op_Equality(a:  "gadget_molotov", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_phoenix_blood", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_mine", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_firework", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_fakebonus", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_singularity", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_nucleargrenade", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_nutcracker", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_Blizzard_generator", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_black_label", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_stickycandy", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丕业丗丆丈万丅丗丈() = new 丕业丗丆丈万丅丗丈(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_157 = new 丕业丗丆丈万丅丗丈();
        }
        
        if((System.String.op_Equality(a:  "gadget_combat_spinner", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 一上与一丞与万丙东() = new 一上与一丞与万丙东(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丑丑三丏丗丐丑丏丒:  1);
            val_157 = new 一上与一丞与万丙东();
        }
        
        if((System.String.op_Equality(a:  "gadget_cyber_bees", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丁上七且七丛丟世丕() = new 丁上七且七丛丟世丕(东一丁世丑丞业丄丐:  丁且丌丁丆丝丙丘丝, 丑丑三丏丗丐丑丏丒:  3);
            val_157 = new 丁上七且七丛丟世丕();
        }
        
        if((System.String.op_Equality(a:  "gadget_ninjashurickens", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 一上与一丞与万丙东() = new 一上与一丞与万丙东(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丑丑三丏丗丐丑丏丒:  3);
            val_157 = new 一上与一丞与万丙东();
        }
        
        if((System.String.op_Equality(a:  "gadget_pocket_harpoon", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                val_158 = new 不业下七丞丗一一丅();
            val_158 = new 不丘丄丝丗丒丙一丌(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
        }
        else
        {
                val_158 = val_157;
        }
        
        if((System.String.op_Equality(a:  "gadget_turret", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                val_156 = new 丆丈且且一上业丛一();
            val_156 = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
        }
        else
        {
                val_156 = val_158;
        }
        
        if((System.String.op_Equality(a:  "gadget_shield", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_armor_regeneration", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_medicalstation", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_snowman", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_christmastreeturret", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_sticky_turret", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_hologram_projector", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆丈且且一上业丛一() = new 丆丈且且一上业丛一(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丆丈且且一上业丛一();
        }
        
        if((System.String.op_Equality(a:  "gadget_stealth", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆万丗下丞丒丐丙丛() = new 丆万丗下丞丒丐丙丛(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  2);
            val_156 = new 丆万丗下丞丒丐丙丛();
        }
        
        if((System.String.op_Equality(a:  "gadget_jetpack", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆万丗下丞丒丐丙丛() = new 丆万丗下丞丒丐丙丛(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  3);
            val_156 = new 丆万丗下丞丒丐丙丛();
        }
        
        if((System.String.op_Equality(a:  "gadget_reflector", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆万丗下丞丒丐丙丛() = new 丆万丗下丞丒丐丙丛(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  0);
            val_156 = new 丆万丗下丞丒丐丙丛();
        }
        
        if((System.String.op_Equality(a:  "gadget_leaderdrum", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆万丗下丞丒丐丙丛() = new 丆万丗下丞丒丐丙丛(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  6);
            val_156 = new 丆万丗下丞丒丐丙丛();
        }
        
        if((System.String.op_Equality(a:  "gadget_astral", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丘丌世丕一丞丘丑丂() = new 丘丌世丕一丞丘丑丂(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丘丌世丕一丞丘丑丂();
        }
        
        if((System.String.op_Equality(a:  "gadget_super_magnet", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丆万丗下丞丒丐丙丛() = new 丆万丗下丞丒丐丙丛(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  14);
            val_156 = new 丆万丗下丞丒丐丙丛();
        }
        
        if((System.String.op_Equality(a:  "gadget_denied", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 且丗丝丒下丙丆丂东() = new 且丗丝丒下丙丆丂东(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 且丗丝丒下丙丆丂东();
        }
        
        if((System.String.op_Equality(a:  "gadget_petbooster", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丄且丌丙丗丈业丄业() = new 丄且丌丙丗丈业丄业(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丄且丌丙丗丈业丄业();
        }
        
        if((System.String.op_Equality(a:  "gadget_mech", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丁专丌东丄丂一三丌() = new 丁专丌东丄丂一三丌(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  1);
            val_156 = new 丁专丌东丄丂一三丌();
        }
        
        if((System.String.op_Equality(a:  "gadget_cybersamurai", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丁专丌东丄丂一三丌() = new 丁专丌东丄丂一三丌(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  9);
            val_156 = new 丁专丌东丄丂一三丌();
        }
        
        if((System.String.op_Equality(a:  "gadget_demon_stone", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丁专丌东丄丂一三丌() = new 丁专丌东丄丂一三丌(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  4);
            val_156 = new 丁专丌东丄丂一三丌();
        }
        
        if((System.String.op_Equality(a:  "gadget_rocket_mech", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丁专丌东丄丂一三丌() = new 丁专丌东丄丂一三丌(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝, 丏不丂丆且三丞丆丏:  15);
            val_156 = new 丁专丌东丄丂一三丌();
        }
        
        if((System.String.op_Equality(a:  "gadget_medkit", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 上丕丆丑丝万专世东() = new 上丕丆丑丝万专世东(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 上丕丆丑丝万专世东();
        }
        
        if((System.String.op_Equality(a:  "gadget_timewatch", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丙丐丞丕且丄丌丝丘() = new 丙丐丞丕且丄丌丝丘(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丙丐丞丕且丄丌丝丘();
        }
        
        if((System.String.op_Equality(a:  "gadget_disabler", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丞丒下丅下不丞丌专() = new 丞丒下丅下不丞丌专(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丞丒下丅下不丞丌专();
        }
        
        if((System.String.op_Equality(a:  "gadget_firemushroom", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 三不丏丝且丄七丁丏() = new 三不丏丝且丄七丁丏(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 三不丏丝且丄七丁丏();
        }
        
        if((System.String.op_Equality(a:  "gadget_firecrackers", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丗丟一业丂丞三丁七() = new 丗丟一业丂丞三丁七(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丗丟一业丂丞三丁七();
        }
        
        if((System.String.op_Equality(a:  "gadget_dragonwhistle", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 世丂丄专且下下专丝() = new 世丂丄专且下下专丝(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 世丂丄专且下下专丝();
        }
        
        if((System.String.op_Equality(a:  "gadget_pandorabox", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 世丙丂三与与与丈丘() = new 世丙丂三与与与丈丘(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 世丙丂三与与与丈丘();
        }
        
        string val_132 = 丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七();
        if((System.String.op_Equality(a:  val_132, b:  val_132)) != false)
        {
                new 世丕丝丂三丟东丄世() = new 世丕丝丂三丟东丄世(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 世丕丝丂三丟东丄世();
        }
        
        if((System.String.op_Equality(a:  "gadget_sniperrespawn", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丐上丌业丞丐丅东七() = new 丐上丌业丞丐丅东七(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丐上丌业丞丐丅东七();
        }
        
        if((System.String.op_Equality(a:  "gadget_vehiclerecover", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丁东丞上且丛丕世丘() = new 丁东丞上且丛丕世丘(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丁东丞上且丛丕世丘();
        }
        
        if((System.String.op_Equality(a:  "gadget_x-ray_glasses", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 七丐丘丅丂丑世丆丐() = new 七丐丘丅丂丑世丆丐(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 七丐丘丅丂丑世丆丐();
        }
        
        if((System.String.op_Equality(a:  "gadget_bionic_shield", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丄三万丙丙丒且丅丆() = new 丄三万丙丙丒且丅丆(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丄三万丙丙丒且丅丆();
        }
        
        if((System.String.op_Equality(a:  "gadget_imposter_kill", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 上上万不丘世丌东丁() = new 上上万不丘世丌东丁(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 上上万不丘世丌东丁();
        }
        
        if((System.String.op_Equality(a:  "gadget_imposter_report", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) != false)
        {
                new 丅丗丂丟丅丁丙丈专() = new 丅丗丂丟丅丁丙丈专(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
            val_156 = new 丅丗丂丟丅丁丙丈专();
        }
        
        if((System.String.op_Equality(a:  "gadget_imposter_teleport", b:  丁且丌丁丆丝丙丘丝.业上丙丞丐丄丆丅七())) == false)
        {
                return (不丘丄丝丗丒丙一丌)val_156;
        }
        
        new 丙东丆下一丌丐世丑() = new 丙东丆下一丌丐世丑(丟丟万一不业上丐丗:  丁且丌丁丆丝丙丘丝);
        val_156 = new 丙东丆下一丌丐世丑();
        return (不丘丄丝丗丒丙一丌)val_156;
    }
    internal void 丈世东丌丘丑不丙下(不丘丄丝丗丒丙一丌 丙丗丕丟七丟上丈丌)
    {
        Rilisoft.丒且丐三丁丅丕一业 val_4 = 丙丗丕丟七丟上丈丌.一上下东丗丌丈一丞;
        if(val_4.丝丙丐且丟丅三丛七() <= 0f)
        {
                return;
        }
        
        val_4 = this.一上下东丗丌丈一丞;
        float val_2 = 丙丗丕丟七丟上丈丌.一上下东丗丌丈一丞.丝丙丐且丟丅三丛七();
        val_4.与万万丆丆三不上世(丙业与丙丗丝不丈东:  val_2);
        this.丝万一丑丛丕丒七丅 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  val_2);
    }
    internal void 丌上丛丆三东下丅丙()
    {
        this.下丁丘下丄丛业丑东.与万万丆丆三不上世(丙业与丙丗丝不丈东:  0f);
        this.丒丐与丕丆丏丑且上 = 0;
    }
    internal void 三丆丘丙丄下万七三()
    {
        this.一上下东丗丌丈一丞.与万万丆丆三不上世(丙业与丙丗丝不丈东:  0f);
        this.丝万一丑丛丕丒七丅 = 0;
    }
    internal virtual void 丈七丁与丝上丕丝丕()
    {
        this.一下丗丌丒丏不丘不 = UnityEngine.Time.time;
        this.丅丗丝丄丕丌丑丈与 = true;
    }
    internal virtual void 丟丄不丄丝业专丅丙()
    {
        string val_2;
        var val_3;
        var val_4;
        if(this != null)
        {
                val_3 = null;
            val_3 = null;
            val_2 = this.业上丙丞丐丄丆丅七();
            不丄业丞且东丁东丈(丗丄万丄丌丕丈丈三:  val_2);
        }
        
        if(this.上丙万上丆万丂丁世 == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        丗丅与专一丘不不丅(东一丁世丑丞业丄丐:  this);
    }
    internal virtual void 丟东丙七丛且丈丂上()
    {
    
    }
    internal virtual void 上专丄丑专丑丘业丌()
    {
    
    }
    internal virtual void 丝丂与丒丟丕丙不丅()
    {
        this.一上下东丗丌丈一丞.与万万丆丆三不上世(丙业与丙丗丝不丈东:  V0.16B);
        this.丟丏丆丈东专丄丗下();
    }
    internal void 丒世丞丂专东东业与()
    {
        this.下丁丘下丄丛业丑东.与万万丆丆三不上世(丙业与丙丗丝不丈东:  0f);
        this.丒丐与丕丆丏丑且上 = 0;
        goto typeof(不丘丄丝丗丒丙一丌).__il2cppRuntimeField_218;
    }
    internal virtual void 丞丒丌世七丂丐万与()
    {
        this.下丁丘下丄丛业丑东.与万万丆丆三不上世(丙业与丙丗丝不丈东:  V0.16B);
    }
    internal virtual void 丙三丙丞丛丈专专丘(float 丂三丟丂丈丐丆丗丟)
    {
        var val_6;
        float val_8;
        val_6 = null;
        val_6 = null;
        if(东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不 != false)
        {
                if(this == null)
        {
                return;
        }
        
        }
        
        if(this.一上下东丗丌丈一丞.丝丙丐且丟丅三丛七() <= 0f)
        {
                return;
        }
        
        if(this.一上下东丗丌丈一丞 != null)
        {
                val_8 = this.一上下东丗丌丈一丞.丝丙丐且丟丅三丛七();
        }
        else
        {
                float val_4 = 0.丝丙丐且丟丅三丛七();
            val_8 = val_4;
        }
        
        val_4 = val_8 - 丂三丟丂丈丐丆丗丟;
        this.一上下东丗丌丈一丞.与万万丆丆三不上世(丙业与丙丗丝不丈东:  val_4);
        if(this.一上下东丗丌丈一丞.丝丙丐且丟丅三丛七() >= 0)
        {
                return;
        }
        
        this.三丆丘丙丄下万七三();
    }
    internal virtual void 一丘三丌万丄且七与(float 丂三丟丂丈丐丆丗丟)
    {
        float val_6;
        if(this.下丁丘下丄丛业丑东.丝丙丐且丟丅三丛七() <= 0f)
        {
                return;
        }
        
        if(this.下丁丘下丄丛业丑东 != null)
        {
                val_6 = this.下丁丘下丄丛业丑东.丝丙丐且丟丅三丛七();
        }
        else
        {
                float val_3 = 0.丝丙丐且丟丅三丛七();
            val_6 = val_3;
        }
        
        val_3 = val_6 - 丂三丟丂丈丐丆丗丟;
        this.下丁丘下丄丛业丑东.与万万丆丆三不上世(丙业与丙丗丝不丈东:  val_3);
        if(this.下丁丘下丄丛业丑东.丝丙丐且丟丅三丛七() >= 0)
        {
                return;
        }
        
        this.丌上丛丆三东下丅丙();
    }
    internal virtual void 丕丕丞不丆业东下丒(bool 丝丟业一丞丈丂丟丐)
    {
    
    }
    internal virtual void 下丏丂丄丗丈丂丆丛()
    {
    
    }
    internal virtual void 丛三丒丄且丘万丟丘()
    {
        this.丟丏丆丈东专丄丗下();
    }
    internal virtual void 丈上丒不与业丝丘上()
    {
        this.丟丏丆丈东专丄丗下();
    }
    internal void 丟丏丆丈东专丄丗下()
    {
        if(this.丅丗丝丄丕丌丑丈与 == false)
        {
                return;
        }
        
        this.丅丗丝丄丕丌丑丈与 = false;
        float val_1 = UnityEngine.Time.time;
        this = this.业上丙丞丐丄丆丅七();
        if(不丘丄丝丗丒丙一丌.下三丕与丟丗世丂丁 == null)
        {
                return;
        }
        
        val_1 = val_1 - this.一下丗丌丒丏不丘不;
        不丘丄丝丗丒丙一丌.下三丕与丟丗世丂丁.Invoke(arg1:  val_1, arg2:  丁下万丟且丟丛下业.丈丛下丗丆丐丞丟丟(丕丁下丌不万丅丞丛:  this));
    }

}
