using UnityEngine;
public class 不世丌丒丑东丝一丝
{
    // Fields
    internal float 丄丂丝丌丗不丗丞一;
    private System.Collections.Generic.Dictionary<string, 万世丗一丝丕丁丛丟> 一丞丈丅万丛世丛丐;
    private System.Collections.Generic.Dictionary<string, 万世丗一丝丕丁丛丟> 上丟七丏丕丌丏丒丌;
    private Rilisoft.丒且丐三丁丅丕一业 丏世丟世丑丟丕丟丗;
    private string 丗丌丞丄丗下丈丕丏;
    private Rilisoft.丒且丐三丁丅丕一业 丁丌东上丗下上与丑;
    private System.Collections.Generic.List<万世丗一丝丕丁丛丟> 丆丙丆丝丆世丟丛丂;
    private bool 丑业丆丛且丁丑丏东;
    private string 七丐丕丄与丝丟丟丝;
    private float 专且丕丌丙丙丝万丏;
    private Rilisoft.丒且丐三丁丅丕一业 丗丕丟上丛下丟与不;
    private Rilisoft.丒且丐三丁丅丕一业 一丞丁丟丙丄丘与下;
    private System.Collections.Generic.List<CategoryNames> 万三一七且三丒万丒;
    internal System.Collections.Generic.Dictionary<int, float> 三世丗丆丕万丐且三;
    private float 不丙丛丙丞丁丒丛丈;
    private float <丐万不丝丐业下专丑>k__BackingField;
    private float 丌业东丈且下丟丒丂;
    private bool <与三与三丂世丗丅丟>k__BackingField;
    
    // Properties
    private float 丄丒专且专上专丆丂 { get; }
    private float 世东东丑专丝上丈下 { get; set; }
    public float 丆三且丅东丕丘世丗 { get; }
    private float 丌丙世丙世丛丕丞一 { get; set; }
    public float 东丌一不丘丑丛丏丕 { get; }
    public float 业世丙且丑世丄丂上 { get; set; }
    private float 丛与七丌丏丙丌东丏 { get; set; }
    private float 丕专万丗丛丄丄上丑 { get; set; }
    public bool 丅专丗丑丘且丁丑丑 { get; set; }
    private int 下丑丟万业不一丞丌 { get; }
    private int 丕下业上东不丆丒丐 { get; }
    
    // Methods
    private float 丏丌与丐丟丕且三三()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(DungeonsController.丄丘七三上丕世丞业 == 0)
        {
                return val_4;
        }
        
        if(this.不丙丛丙丞丁丒丛丈 >= 0)
        {
                return val_4;
        }
        
        val_6 = null;
        val_6 = null;
        float val_4 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丌丁丁丗丙不不丄一();
        val_4 = DungeonsController.丄丘七三上丕世丞业.mobPlayerResistMultiplier / val_4;
        this.不丙丛丙丞丁丒丛丈 = val_4;
        return val_4;
    }
    internal float 丝世不丑丒丏丄丑专(RilisoftBot.七一丙世丏下丐丕世 丂上不世业丒三世丕)
    {
        var val_19;
        var val_20;
        var val_21;
        DungeonsController val_22;
        float val_23;
        float val_24;
        var val_25;
        float val_27;
        val_19 = this;
        val_20 = 1152921505058603008;
        val_21 = null;
        val_21 = null;
        val_22 = DungeonsController.丄丘七三上丕世丞业;
        val_23 = 0f;
        if(val_22 != 0)
        {
                val_24 = 0f;
            if((this.三世丗丆丕万丐且三.ContainsKey(key:  万世专丘且万世七丒.一丞上丙丏丛丕丑丒(东丙丑丁且上上专丕:  丂上不世业丒三世丕))) != false)
        {
                val_24 = (this.三世丗丆丕万丐且三.Item[万世专丘且万世七丒.一丞上丙丏丛丕丑丒(东丙丑丁且上上专丕:  丂上不世业丒三世丕)]) * this.丏丌与丐丟丕且三三();
        }
        
            val_25 = null;
            val_25 = null;
            val_22 = DungeonsController.丄丘七三上丕世丞业;
            val_23 = UnityEngine.Mathf.Clamp(value:  val_24, min:  0f, max:  val_22.mobPlayerResistMultiplier);
        }
        
        if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                val_20 = 1152921505232723968;
            val_22 = this.三世丗丆丕万丐且三;
            val_27 = 0f;
            if((val_22.ContainsKey(key:  万世专丘且万世七丒.一丞上丙丏丛丕丑丒(东丙丑丁且上上专丕:  丂上不世业丒三世丕))) != false)
        {
                val_22 = this.三世丗丆丕万丐且三;
            val_27 = (val_22.Item[万世专丘且万世七丒.一丞上丙丏丛丕丑丒(东丙丑丁且上上专丕:  丂上不世业丒三世丕)]) * this.丏丌与丐丟丕且三三();
        }
        
            val_19 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().世三不且一丆丕丂上();
            val_23 = UnityEngine.Mathf.Clamp(value:  val_27, min:  0f, max:  val_19.丐三丑丂丏专丌东丁());
        }
        
        float val_19 = 1f;
        val_19 = val_19 - val_23;
        return (float)val_19;
    }
    public 不世丌丒丑东丝一丝()
    {
        this.丄丂丝丌丗不丗丞一 = 1f;
        this.一丞丈丅万丛世丛丐 = new System.Collections.Generic.Dictionary<System.String, 万世丗一丝丕丁丛丟>();
        this.上丟七丏丕丌丏丒丌 = new System.Collections.Generic.Dictionary<System.String, 万世丗一丝丕丁丛丟>();
        this.丏世丟世丑丟丕丟丗 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.丗丌丞丄丗下丈丕丏 = "";
        this.丁丌东上丗下上与丑 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.丆丙丆丝丆世丟丛丂 = new System.Collections.Generic.List<万世丗一丝丕丁丛丟>();
        this.七丐丕丄与丝丟丟丝 = "";
        this.丗丕丟上丛下丟与不 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.一丞丁丟丙丄丘与下 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.万三一七且三丒万丒 = new System.Collections.Generic.List<CategoryNames>();
        this.三世丗丆丕万丐且三 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        this.不丙丛丙丞丁丒丛丈 = -1f;
    }
    private float 三一丆丕丛丑下丆丒()
    {
        if(this.丁丌东上丗下上与丑 != null)
        {
                return this.丁丌东上丗下上与丑.丝丙丐且丟丅三丛七();
        }
        
        return this.丁丌东上丗下上与丑.丝丙丐且丟丅三丛七();
    }
    private void 丗东丕丘丏不丁且上(float 丙业与丙丗丝不丈东)
    {
        this.丁丌东上丗下上与丑.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public float 丈下丏丟丑丐丆三不()
    {
        if(this.丁丌东上丗下上与丑 != null)
        {
                return this.丁丌东上丗下上与丑.丝丙丐且丟丅三丛七();
        }
        
        return this.丁丌东上丗下上与丑.丝丙丐且丟丅三丛七();
    }
    private float 丕与下丞丐丁世丌业()
    {
        if(this.一丞丁丟丙丄丘与下 != null)
        {
                return this.一丞丁丟丙丄丘与下.丝丙丐且丟丅三丛七();
        }
        
        return this.一丞丁丟丙丄丘与下.丝丙丐且丟丅三丛七();
    }
    private void 丂东丅丅世丄丒丗丐(float 丙业与丙丗丝不丈东)
    {
        this.一丞丁丟丙丄丘与下.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public float 七丁丙丅丂上丒丞丙()
    {
        if(this.一丞丁丟丙丄丘与下 != null)
        {
                return this.一丞丁丟丙丄丘与下.丝丙丐且丟丅三丛七();
        }
        
        return this.一丞丁丟丙丄丘与下.丝丙丐且丟丅三丛七();
    }
    public float 丁丐七世业三丒丆丙()
    {
        return (float)this.<丐万不丝丐业下专丑>k__BackingField;
    }
    private void 丂丗丛丙丕三丕丘丈(float 丙业与丙丗丝不丈东)
    {
        this.<丐万不丝丐业下专丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private float 丏丄专丑丛丂上丛丈()
    {
        if(不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() != false)
        {
                return 0f;
        }
        
        if(this.丗丕丟上丛下丟与不 != null)
        {
                return this.丗丕丟上丛下丟与不.丝丙丐且丟丅三丛七();
        }
        
        return this.丗丕丟上丛下丟与不.丝丙丐且丟丅三丛七();
    }
    private void 与丛丙丌七丑万丒丌(float 丙业与丙丗丝不丈东)
    {
        if(不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() != false)
        {
                return;
        }
        
        this.丗丕丟上丛下丟与不.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private float 丄下丁上不世与世上()
    {
        if(不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() != false)
        {
                return 0f;
        }
        
        if(this.丏世丟世丑丟丕丟丗 != null)
        {
                return this.丏世丟世丑丟丕丟丗.丝丙丐且丟丅三丛七();
        }
        
        return this.丏世丟世丑丟丕丟丗.丝丙丐且丟丅三丛七();
    }
    private void 丑丄专上三丁丘丕丂(float 丙业与丙丗丝不丈东)
    {
        if(不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() != false)
        {
                return;
        }
        
        this.丏世丟世丑丟丕丟丗.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public bool 万七丏专东丐丂丏丑()
    {
        return (bool)this.<与三与三丂世丗丅丟>k__BackingField;
    }
    private void 丅业丏不丅丂丞丙丈(bool 丙业与丙丗丝不丈东)
    {
        this.<与三与三丂世丗丅丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private int 七与业丟丞丘不丟下()
    {
        var val_21;
        var val_22;
        int val_23;
        int val_24;
        int val_25;
        int val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        var val_32;
        var val_33;
        val_21 = 1152921505066536960;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_22 = null;
            val_22 = null;
            val_21 = ???;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                val_23 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  "Armor_Army_1");
            val_24 = 1;
            val_25 = 1;
            val_26 = val_23;
            return BalanceController.丑丈与不丄丈丘三丟(丞世不丒下上上丝丑:  val_26 = val_23, 下丑丞不一且业丆不:  val_24 = val_33.丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  val_23 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_31 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7))), 丙丂丏丛丌丏下丝不:  val_25 = ExperienceController.丞丞丘业东丙丏七丌());
        }
        
        val_27 = null;
        val_27 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_28 = null;
            val_28 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_29 = null;
            val_29 = null;
            val_30 = null;
            val_30 = null;
            val_32 = mem[typeof(Player_move_c).__il2cppRuntimeField_AB0 + 32];
            val_32 = typeof(Player_move_c).__il2cppRuntimeField_AB0 + 32;
            return (int)val_32;
        }
        
        }
        
        if((System.String.op_Equality(a:  val_31, b:  "__no_armor_NEW")) != false)
        {
                val_32 = 0;
            return (int)val_32;
        }
        
        if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_23)) > 0)
        {
                val_33 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
            int val_17 = val_33.三三三东丑丁且与万(丞世不丒下上上丝丑:  val_23);
        }
        else
        {
                val_33 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
        }
        
        return BalanceController.丑丈与不丄丈丘三丟(丞世不丒下上上丝丑:  val_26, 下丑丞不一且业丆不:  val_24, 丙丂丏丛丌丏下丝不:  val_25);
    }
    internal static bool 丑丘不丑不丝丞世丝()
    {
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  22);
        if(val_1 == null)
        {
                return (bool)val_1;
        }
        
        return val_1.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool");
    }
    private int 丗丈业丕丏与七丘业()
    {
        var val_6;
        var val_7;
        if(不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() != false)
        {
                val_6 = 0;
            return 100;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_7 = null;
            val_7 = null;
        }
        
        val_6 = 100;
        return 100;
    }
    public void Destroy()
    {
        this.丌丂一丆丅一业丗与(下丝丘丁专丐丅丛丝:  0f, 丙丅世丒丝且丙专专:  this.<与三与三丂世丗丅丟>k__BackingField);
    }
    public void 丌丂一丆丅一业丗与(float 下丝丘丁专丐丅丛丝, bool 丙丅世丒丝且丙专专)
    {
        this.<与三与三丂世丗丅丟>k__BackingField = 丙丅世丒丝且丙专专;
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        this.世丙上丅与丛不万一();
        float val_3 = this.三一丆丕丛丑下丆丒();
        if(this.三一丆丕丛丑下丆丒() < 0)
        {
                val_3 = 下丝丘丁专丐丅丛丝 - val_3;
            this.七一不世丅丒丅丟丕(下丝丘丁专丐丅丛丝:  val_3);
            return;
        }
        
        val_3 = val_3 - 下丝丘丁专丐丅丛丝;
        float val_4 = this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  val_3);
    }
    private void 丁丄丗下业丐丈万丌()
    {
        var val_25;
        var val_26;
        var val_27;
        WeaponManager val_28;
        var val_29;
        var val_30;
        var val_31;
        this.与丛丙丌七丑万丒丌(丙业与丙丗丝不丈东:  0f);
        if(this.丑业丆丛且丁丑丏东 != true)
        {
                if((this.<与三与三丂世丗丅丟>k__BackingField) == false)
        {
                return;
        }
        
        }
        
        int val_2 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7));
        if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_2)) > 0)
        {
                val_25 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
            int val_6 = val_25.三三三东丑丁且与万(丞世不丒下上上丝丑:  val_2);
        }
        else
        {
                val_25 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
        }
        
        val_26 = BalanceController.丑丈与不丄丈丘三丟(丞世不丒下上上丝丑:  val_2, 下丑丞不一且业丆不:  val_25.丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  val_2), 丙丂丏丛丌丏下丝不:  ExperienceController.丞丞丘业东丙丏七丌());
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                val_26 = BalanceController.丑丈与不丄丈丘三丟(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  "Armor_Army_1"), 下丑丞不一且业丆不:  1, 丙丂丏丛丌丏下丝不:  1);
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_28 != 0)
        {
                val_29 = null;
            val_29 = null;
            val_28 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_28 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_28 != 0)
        {
                val_30 = null;
            val_30 = null;
            val_28 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_28 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_31 = null;
            val_31 = null;
            val_26 = mem[typeof(Player_move_c).__il2cppRuntimeField_AB0 + 32];
            val_26 = typeof(Player_move_c).__il2cppRuntimeField_AB0 + 32;
        }
        
        }
        
        this.与丛丙丌七丑万丒丌(丙业与丙丗丝不丈东:  (GameConnect.万不丒丌丙万丗东不() != true) ? 0f : ((float)val_26));
        float val_19 = (GameConnect.万不丒丌丙万丗东不() != true) ? 0f : 100f;
        this.丌业东丈且下丟丒丂 = val_19;
        float val_20 = this.丏丄专丑丛丂上丛丈();
        val_20 = val_19 / val_20;
        this.丄丂丝丌丗不丗丞一 = val_20;
        if((this.<与三与三丂世丗丅丟>k__BackingField) == false)
        {
                return;
        }
        
        if(this.丏丄专丑丛丂上丛丈() >= 0)
        {
                return;
        }
        
        this.与丛丙丌七丑万丒丌(丙业与丙丗丝不丈东:  (float)this.七与业丟丞丘不丟下());
        this.丌业东丈且下丟丒丂 = (float)this.丗丈业丕丏与七丘业();
        float val_24 = this.丏丄专丑丛丂上丛丈();
        val_24 = (float)this.丗丈业丕丏与七丘业() / val_24;
        this.丄丂丝丌丗不丗丞一 = val_24;
    }
    private void 丐丛丑东丌丆丙上丘()
    {
        float val_6;
        this.丂东丅丅世丄丒丗丐(丙业与丙丗丝不丈东:  0f);
        int val_1 = this.七与业丟丞丘不丟下();
        val_6 = (float)val_1;
        this.<丐万不丝丐业下专丑>k__BackingField = val_6;
        if(this.丑业丆丛且丁丑丏东 != true)
        {
                if((this.<与三与三丂世丗丅丟>k__BackingField) == false)
        {
                return;
        }
        
        }
        
        this.丂东丅丅世丄丒丗丐(丙业与丙丗丝不丈东:  this.丏丄专丑丛丂上丛丈());
        float val_4 = this.丏丄专丑丛丂上丛丈();
        if((this.<丐万不丝丐业下专丑>k__BackingField) < 0)
        {
                this.<丐万不丝丐业下专丑>k__BackingField = this.丏丄专丑丛丂上丛丈();
        }
        else
        {
                val_6 = this.<丐万不丝丐业下专丑>k__BackingField;
        }
        
        val_6 = (float)val_1.丗丈业丕丏与七丘业() / val_6;
        this.丄丂丝丌丗不丗丞一 = val_6;
    }
    private void 世丙上丅与丛不万一()
    {
        this.丗东丕丘丏不丁且上(丙业与丙丗丝不丈东:  this.丄下丁上不世与世上());
        if(this.丑业丆丛且丁丑丏东 != true)
        {
                if((this.<与三与三丂世丗丅丟>k__BackingField) == false)
        {
                return;
        }
        
        }
        
        List.Enumerator<T> val_2 = this.丆丙丆丝丆世丟丛丂.GetEnumerator();
        label_6:
        if(((-324437736) & 1) == 0)
        {
            goto label_4;
        }
        
        float val_5 = 0.丐丏七丌丕丗业且上().丐丅丒世丄且丁丙丛();
        val_5 = this.三一丆丕丛丑下丆丒() + val_5;
        this.丗东丕丘丏不丁且上(丙业与丙丗丝不丈东:  val_5);
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 七三丅东东丈丁且万()
    {
        if(((((((((((System.String.op_Inequality(a:  this.丗丌丞丄丗下丈丕丏, b:  "__no_armor_NEW")) != false) && (GameConnect.丑丌丛丈丅丅与不业() != 3)) && (GameConnect.丑丌丛丈丅丅与不业() != 20)) && (GameConnect.丆丕丒与丂七与下上() != true)) && (GameConnect.一业上七丟业且业丙() != true)) && (GameConnect.丛专丌且丕不专丈下() != true)) && (GameConnect.东且三丆丑世世丘丟() != true)) && (GameConnect.与丈丘丈上丌丝丝丛() != true)) && (GameConnect.丁丁丗丐东丄丞一丛() != true)) && (GameConnect.且丘丄丛下丆丟万丕() != true))
        {
                if(GameConnect.万七丄丛丈丟专一丑() != true)
        {
                if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_37;
        }
        
        }
        
        }
        
        label_38:
        this.丑业丆丛且丁丑丏东 = false;
        return;
        label_37:
        var val_14 = ~不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝();
        val_14 = val_14 & 1;
        goto label_38;
    }
    private void 一丅丑不丏丝丌丛丞()
    {
    
    }
    private void 东七上万丑丏且三丞()
    {
    
    }
    private void 七丌不丈丙万世东下()
    {
    
    }
    public void 且七丙丄丘一丄上不()
    {
        this.丗丌丞丄丗下丈丕丏 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
        this.七三丅东东丈丁且万();
        this.<与三与三丂世丗丅丟>k__BackingField = false;
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  this.丏丄专丑丛丂上丛丈());
        this.丗东丕丘丏不丁且上(丙业与丙丗丝不丈东:  this.丕与下丞丐丁世丌业());
        this.七丐丕丄与丝丟丟丝 = "";
    }
    private void 七一不世丅丒丅丟丕(float 下丝丘丁专丐丅丛丝)
    {
        float val_27;
        float val_28;
        float val_29;
        if(不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() != false)
        {
                return;
        }
        
        float val_2 = this.丄下丁上不世与世上();
        val_2 = val_2 + 下丝丘丁专丐丅丛丝;
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  val_2);
        val_27 = this.丄下丁上不世与世上();
        val_28 = 0f;
        if(val_27 > this.丏丄专丑丛丂上丛丈())
        {
                val_27 = this.丄下丁上不世与世上();
            val_28 = val_27 - this.丏丄专丑丛丂上丛丈();
            this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  this.丏丄专丑丛丂上丛丈());
        }
        
        int val_24 = this.丆丙丆丝丆世丟丛丂.Count;
        goto label_11;
        label_15:
        万世丗一丝丕丁丛丟 val_9 = this.丆丙丆丝丆世丟丛丂.Item[val_24];
        if(val_9 != null)
        {
                val_27 = val_9.丐丅丒世丄且丁丙丛();
        }
        else
        {
                val_27 = val_9.丐丅丒世丄且丁丙丛();
        }
        
        float val_12 = val_9.丁丂七三丅三丘丆不();
        if(val_27 < 0)
        {
                if(val_9 != null)
        {
                val_29 = val_28 + val_9.丐丅丒世丄且丁丙丛();
            val_9.丙丏专业世世三丟丞(丙业与丙丗丝不丈东:  val_29);
            val_27 = val_9.丐丅丒世丄且丁丙丛();
        }
        else
        {
                val_29 = val_28 + val_9.丐丅丒世丄且丁丙丛();
            val_9.丙丏专业世世三丟丞(丙业与丙丗丝不丈东:  val_29);
            val_27 = val_9.丐丅丒世丄且丁丙丛();
        }
        
            val_28 = 0f;
            if(val_27 > val_9.丁丂七三丅三丘丆不())
        {
                if(val_9 != null)
        {
                val_28 = val_9.丐丅丒世丄且丁丙丛() - val_9.丁丂七三丅三丘丆不();
            val_27 = val_9.丁丂七三丅三丘丆不();
        }
        else
        {
                val_28 = val_9.丐丅丒世丄且丁丙丛() - val_9.丁丂七三丅三丘丆不();
            val_27 = val_9.丁丂七三丅三丘丆不();
        }
        
            val_9.丙丏专业世世三丟丞(丙业与丙丗丝不丈东:  val_27);
        }
        
        }
        
        label_11:
        val_24 = val_24 - 1;
        if((val_24 & 2147483648) == 0)
        {
                if(val_28 > 0f)
        {
            goto label_15;
        }
        
        }
        
        this.世丙上丅与丛不万一();
    }
    public void 下东丞丆专丟丙丝丒(float 下丝丘丁专丐丅丛丝)
    {
        if(this.丑业丆丛且丁丑丏东 == false)
        {
                return;
        }
        
        this.七一不世丅丒丅丟丕(下丝丘丁专丐丅丛丝:  下丝丘丁专丐丅丛丝);
    }
    public float 丝不丈丝世专东万丒(Rilisoft.专与丏丞三与不不丆 丆丙丅丝七丒丐丙万)
    {
        float val_11;
        float val_12;
        float val_14;
        this.<与三与三丂世丗丅丟>k__BackingField = true;
        val_11 = (float)this.七与业丟丞丘不丟下();
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_3;
        }
        
        if(丆丙丅丝七丒丐丙万 == 15)
        {
            goto label_4;
        }
        
        if(丆丙丅丝七丒丐丙万 != 14)
        {
            goto label_5;
        }
        
        val_12 = 0.25f;
        goto label_6;
        label_3:
        if(this.丏丄专丑丛丂上丛丈() >= 0)
        {
            goto label_7;
        }
        
        val_14 = val_11;
        goto label_8;
        label_7:
        float val_5 = this.丏丄专丑丛丂上丛丈();
        goto label_9;
        label_4:
        val_12 = 0.5f;
        label_6:
        val_11 = val_11 * val_12;
        label_5:
        float val_6 = this.丄下丁上不世与世上();
        val_6 = val_11 + val_6;
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  val_6);
        int val_8 = this.七与业丟丞丘不丟下();
        val_14 = (float)val_8;
        if(this.丄下丁上不世与世上() <= val_14)
        {
            goto label_10;
        }
        
        val_14 = (float)val_8.七与业丟丞丘不丟下();
        label_9:
        label_8:
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  val_14);
        label_10:
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        this.世丙上丅与丛不万一();
        float val_10 = this.丈下丏丟丑丐丆三不();
        val_10 = val_10 - this.丈下丏丟丑丐丆三不();
        return (float)val_10;
    }
    public float 下业丛丄世丆丌丟丑(Rilisoft.专与丏丞三与不不丆 丆丙丅丝七丒丐丙万, float 丗与丘不且万丟丙丑)
    {
        float val_8;
        float val_8 = 丗与丘不且万丟丙丑;
        this.<与三与三丂世丗丅丟>k__BackingField = true;
        val_8 = (float)this.七与业丟丞丘不丟下() * val_8;
        float val_3 = this.丄下丁上不世与世上();
        val_3 = val_8 + val_3;
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  val_3);
        int val_5 = this.七与业丟丞丘不丟下();
        val_8 = (float)val_5;
        if(this.丄下丁上不世与世上() > val_8)
        {
                val_8 = (float)val_5.七与业丟丞丘不丟下();
            this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  val_8);
        }
        
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        this.世丙上丅与丛不万一();
        float val_7 = this.丈下丏丟丑丐丆三不();
        val_7 = val_7 - this.丈下丏丟丑丐丆三不();
        return (float)val_7;
    }
    private void 丑丂七丂丞丈丟与且(ref float 下丝丘丁专丐丅丛丝, ref float 丞丈专下丈专业三丞)
    {
        float val_1 = 下丝丘丁专丐丅丛丝;
        val_1 = val_1 - 丞丈专下丈专业三丞;
        下丝丘丁专丐丅丛丝 = val_1;
        if(val_1 < 0)
        {
                val_1 = 0f - val_1;
            丞丈专下丈专业三丞 = val_1;
        }
        
        丞丈专下丈专业三丞 = 0f;
    }
    public float 业丂丛丟上且丂东丂(float 丞丈专下丈专业三丞)
    {
        float val_7;
        float val_8;
        val_7 = 丞丈专下丈专业三丞;
        val_8 = this.三一丆丕丛丑下丆丒() - val_7;
        this.丗东丕丘丏不丁且上(丙业与丙丗丝不丈东:  val_8);
        if(this.三一丆丕丛丑下丆丒() < 0)
        {
                val_8 = 0f;
            this.丗东丕丘丏不丁且上(丙业与丙丗丝不丈东:  val_8);
        }
        
        if(this.丑业丆丛且丁丑丏东 != true)
        {
                if((this.<与三与三丂世丗丅丟>k__BackingField) == false)
        {
            goto label_15;
        }
        
        }
        
        List.Enumerator<T> val_3 = this.丆丙丆丝丆世丟丛丂.GetEnumerator();
        label_10:
        if(((-323097520) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        float val_5 = val_4.丐丅丒世丄且丁丙丛();
        val_5 = val_5 - val_7;
        if(val_5 < 0)
        {
                val_5 = 0f - val_5;
        }
        
        val_8 = val_5;
        val_4.丙丏专业世世三丟丞(丙业与丙丗丝不丈东:  val_8);
        val_7 = 0f;
        if(val_7 > 0f)
        {
            goto label_10;
        }
        
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_15:
        float val_6 = this.丄下丁上不世与世上();
        val_6 = val_6 - 0f;
        if(val_6 < 0)
        {
                val_6 = 0f - val_6;
        }
        
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  val_6);
        return 0f;
    }
    public float 丞丂万丟丗七丂丁上()
    {
        this.丗丌丞丄丗下丈丕丏 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
        this.七三丅东东丈丁且万();
        if(this.丑业丆丛且丁丑丏东 == false)
        {
            goto label_3;
        }
        
        this.<与三与三丂世丗丅丟>k__BackingField = false;
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        if(this.丄下丁上不世与世上() <= this.丏丄专丑丛丂上丛丈())
        {
            goto label_4;
        }
        
        float val_5 = this.丏丄专丑丛丂上丛丈();
        goto label_5;
        label_3:
        if(this.丑业丆丛且丁丑丏东 == false)
        {
            goto label_6;
        }
        
        this.<与三与三丂世丗丅丟>k__BackingField = false;
        this.七丐丕丄与丝丟丟丝 = this.丗丌丞丄丗下丈丕丏;
        this.专且丕丌丙丙丝万丏 = this.丄下丁上不世与世上();
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        label_5:
        this.丑丄专上三丁丘丕丂(丙业与丙丗丝不丈东:  0f);
        label_4:
        this.世丙上丅与丛不万一();
        label_6:
        float val_7 = this.丈下丏丟丑丐丆三不();
        val_7 = val_7 - this.丈下丏丟丑丐丆三不();
        return (float)val_7;
    }
    public float 丐丒丌丝且丂万且丁()
    {
        this.丁丄丗下业丐丈万丌();
        this.丐丛丑东丌丆丙上丘();
        this.世丙上丅与丛不万一();
        float val_2 = this.丈下丏丟丑丐丆三不();
        val_2 = val_2 - this.丈下丏丟丑丐丆三不();
        return (float)val_2;
    }

}
