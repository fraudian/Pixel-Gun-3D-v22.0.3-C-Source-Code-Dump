using UnityEngine;
internal static class 东丟丟万下丛丆丛丟
{
    // Fields
    internal static 不丘丄丝丗丒丙一丌 专丅业三丑万不业丂;
    internal static 不丘丄丝丗丒丙一丌 丟丛丙七一与专上丆;
    internal static ModulesSetGadgetsStorage.ModuleGadgetRecord 万丑三丆东丒三丄丅;
    private static readonly System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌> 丘丆丁丛丁丗丅世东;
    private static bool 丐东丈不丌不下丕丝;
    internal static bool 丆丐丕丗与丘丟一不;
    private static System.Action<ModulesSetGadgetsStorage.ModuleGadgetRecord> 丟丐业丆丟上丛丈世;
    
    // Properties
    internal static System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌> 三丝不丒上且丄丆下 { get; }
    internal static bool 上东丏万丝上且与专 { get; }
    internal static bool 丁丒丟丏不下丗丕上 { get; }
    
    // Methods
    internal static void 丌丟七世丗万丒东丆(System.Action<ModulesSetGadgetsStorage.ModuleGadgetRecord> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世 != 1152921505217179688);
    
    }
    internal static void 丏丈丐业丘丏万东下(System.Action<ModulesSetGadgetsStorage.ModuleGadgetRecord> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世 != 1152921505217179688);
    
    }
    internal static System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌> 不丐丝七上丄丕丐丅()
    {
        var val_1 = null;
        if(东丟丟万下丛丆丛丟.丐东丈不丌不下丕丝 != true)
        {
                东丟丟万下丛丆丛丟.丘丞丏丈丝丟不丅丞();
            val_1 = null;
        }
        
        val_1 = null;
        return (System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌>)东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东;
    }
    internal static bool 丂七三世丘万丘丝丘()
    {
        var val_9;
        var val_10;
        GameModeController val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_9 = 1152921505189646336;
        val_10 = null;
        val_10 = null;
        val_11 = GameController.mode;
        if(val_11 == 0)
        {
            goto label_5;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = GameController.mode;
        if(GameController.mode.IsGadgetsPanelEnabled == true)
        {
            goto label_9;
        }
        
        label_5:
        val_13 = null;
        if(东丟丟万下丛丆丛丟.一丁丛丛丝万万丐丈() == false)
        {
                return false;
        }
        
        label_9:
        val_9 = 1152921505217175552;
        val_14 = null;
        if(东丟丟万下丛丆丛丟.丕丒专业丅业丆一丗() == true)
        {
                return false;
        }
        
        val_11 = 1152921505286238208;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 1)
        {
                return false;
        }
        
        val_16 = null;
        val_16 = null;
        val_11 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 2)
        {
                return false;
        }
        
        val_11 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_11.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
                return false;
        }
        
        val_17 = null;
        if(东丟丟万下丛丆丛丟.东万丈上丘丗丆丝业() != false)
        {
                return false;
        }
        
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
                return false;
        }
        
        var val_8 = ((PolygonController.一下一万丄丅丘且丑 + 121) != 0) ? 1 : 0;
        return false;
    }
    private static bool 一丁丛丛丝万万丐丈()
    {
        Player_move_c val_3;
        var val_4;
        var val_5;
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_3 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        if(null != 0)
        {
                return 丄丝丝下丟丘丄丒丈();
        }
        
        return 丄丝丝下丟丘丄丒丈();
    }
    private static bool 东万丈上丘丗丆丝业()
    {
        var val_2;
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
                return false;
        }
        
        val_2 = null;
        val_2 = null;
        return System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  "box4");
    }
    internal static bool 丕丒专业丅业丆一丗()
    {
        var val_7;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  4);
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_3;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_3 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  20);
        if(val_3 == null)
        {
            goto label_8;
        }
        
        val_7 = ((int)val_3.丛丅下丆丗丏三丁丕<System.Single>()) >> 31;
        return (bool)val_7 & 1;
        label_3:
        if(val_1 != null)
        {
                val_7 = (val_1.丛丅下丆丗丏三丁丕<System.Boolean>()) ^ 1;
            return (bool)val_7 & 1;
        }
        
        label_8:
        val_7 = 0;
        return (bool)val_7 & 1;
    }
    internal static void 丟丌一丒业且丒丂丘()
    {
        null = null;
        东丟丟万下丛丆丛丟.万丑三丆东丒三丄丅 = 0;
        东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 = 0;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Clear();
        东丟丟万下丛丆丛丟.丐东丈不丌不下丕丝 = false;
    }
    private static void 丘丕丗丒丄不丙丒丙()
    {
        var val_1;
        不丘丄丝丗丒丙一丌 val_3;
        val_1 = null;
        val_1 = null;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Clear();
        val_3 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  188, value:  val_3);
    }
    internal static void 三丞丂丞丗世世丂丁()
    {
        null = null;
        bool val_1 = 东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Remove(key:  188);
        东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 = 0;
        东丟丟万下丛丆丛丟.万丑三丆东丒三丄丅 = 0;
        if(东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世 == null)
        {
                return;
        }
        
        0.Invoke(obj:  0);
    }
    internal static void 且丞一丕东业三丑东(string 丞丅上丏丂且下丅与, ModulesSetGadgetsStorage.ModuleGadgetRecord 三丐三丞丘丕不丒专)
    {
        System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌> val_4;
        var val_5;
        不丘丄丝丗丒丙一丌 val_6;
        var val_7;
        不丘丄丝丗丒丙一丌 val_8;
        ModuleGadgetRecord val_9;
        var val_10;
        var val_11;
        System.Action<ModuleGadgetRecord> val_12;
        val_5 = null;
        val_5 = null;
        val_6 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_6 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        if(val_6 == null)
        {
            goto label_6;
        }
        
        label_3:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丅上丏丂且下丅与)) != false)
        {
                val_7 = null;
            val_7 = null;
            bool val_2 = 东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Remove(key:  188);
            val_8 = 0;
            val_9 = 0;
        }
        else
        {
                val_10 = null;
            val_8 = ModulesSetGadgetsStorage.丂丟七丝三七丄丈世(丐不丙万不世丛丛丐:  丞丅上丏丂且下丅与, 三丐三丞丘丕不丒专:  三丐三丞丘丕不丒专);
            val_10 = null;
            val_4 = 东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东;
            val_4.set_Item(key:  188, value:  val_8);
            val_9 = 三丐三丞丘丕不丒专;
        }
        
        val_11 = null;
        东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 = val_8;
        东丟丟万下丛丆丛丟.万丑三丆东丒三丄丅 = val_9;
        val_11 = null;
        val_12 = 东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世;
        if(val_12 == null)
        {
                return;
        }
        
        val_12 = 东丟丟万下丛丆丛丟.丟丐业丆丟上丛丈世;
        if(val_12 == null)
        {
                val_12 = 0;
        }
        
        val_12.Invoke(obj:  三丐三丞丘丕不丒专);
        return;
        label_6:
    }
    internal static 不丘丄丝丗丒丙一丌 专丆丝丆东世丄世丞(GadgetCategory 丙丑丕丂下丏一丁专)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.ContainsKey(key:  丙丑丕丂下丏一丁专)) != false)
        {
                val_4 = null;
            val_4 = null;
            不丘丄丝丗丒丙一丌 val_2 = 东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Item[丙丑丕丂下丏一丁专];
            return (不丘丄丝丗丒丙一丌)val_5;
        }
        
        val_5 = 0;
        return (不丘丄丝丗丒丙一丌)val_5;
    }
    internal static void 丟且丏业丈七七三与(string 丗丄万丄丌丕丈丈三)
    {
        var val_11;
        var val_12;
        var val_13;
        丕丈丏丝丗下丟丅丂 val_2 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丄万丄丌丕丈丈三];
        val_11 = null;
        val_11 = null;
        if((东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.ContainsKey(key:  val_2.丒万丕七专不丏丞丌())) == false)
        {
            goto label_8;
        }
        
        val_12 = null;
        val_12 = null;
        不丘丄丝丗丒丙一丌 val_7 = 不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  val_2);
        if(val_7 == null)
        {
            goto label_13;
        }
        
        val_7.上丙万上丆万丂丁世 = true;
        goto label_14;
        label_8:
        val_8.上丙万上丆万丂丁世 = true;
        val_13 = null;
        val_13 = null;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  val_2.丒万丕七专不丏丞丌(), value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  val_2));
        return;
        label_13:
        mem[48] = 1;
        label_14:
        val_7.丈世东丌丘丑不丙下(丙丗丕丟七丟上丈丌:  东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Item[val_2.丒万丕七专不丏丞丌()]);
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.set_Item(key:  val_2.丒万丕七专不丏丞丌(), value:  val_7);
    }
    internal static void 与丈丒丅丈丌世一丛(string[] 丗丄万丄丌丕丈丈三)
    {
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌> val_14;
        var val_15;
        不丘丄丝丗丒丙一丌[] val_1 = new 不丘丄丝丗丒丙一丌[0];
        丕丈丏丝丗下丟丅丂[] val_2 = new 丕丈丏丝丗下丟丅丂[0];
        val_10 = 0;
        goto label_3;
        label_23:
        val_12 = 丗丄万丄丌丕丈丈三[0];
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  val_12)) == false)
        {
            goto label_8;
        }
        
        丕丈丏丝丗下丟丅丂 val_6 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丄万丄丌丕丈丈三[0x0] + 32];
        val_12 = 不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  val_6);
        val_1[0] = val_12;
        if(val_2 == null)
        {
            goto label_16;
        }
        
        if(val_6 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(val_6 == null)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_2[0] = val_6;
        label_8:
        val_10 = 1;
        label_3:
        if(val_10 < val_1.Length)
        {
            goto label_23;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = 东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东;
        val_14.Clear();
        if(val_1.Length < 1)
        {
                return;
        }
        
        do
        {
            val_11 = 0;
            if(val_1[val_11] != null)
        {
                val_15 = null;
            val_15 = null;
            val_12 = mem[val_1[0x0] + 32];
            val_12 = val_1[0x0] + 32;
            东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  val_2[val_11].丒万丕七专不丏丞丌(), value:  val_12);
            val_14 = val_2[0x0] + 32.丒万丕七专不丏丞丌();
            丁下万丟且丟丛下业.丛丁七业东上世丅丛(丙业与丙丗丝不丈东:  val_14);
        }
        
        }
        while((val_11 + 1) < val_1.Length);
    
    }
    internal static void 丅丅丘七下丈上丄丛(GadgetCategory 七丆丒与丗丌丄且丂)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_19 = null;
        if(东丟丟万下丛丆丛丟.丂七三世丘万丘丝丘() == false)
        {
                return;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 19)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
                return;
        }
        
        if(GameConnect.东丒七专丂世丝丏丗() == true)
        {
                return;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 16)
        {
                return;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_9 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_9 != null)
        {
                if((val_9.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) == 100)
        {
                return;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        if((东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.ContainsKey(key:  七丆丒与丗丌丄且丂)) != false)
        {
                val_21 = null;
            val_21 = null;
            不丘丄丝丗丒丙一丌 val_12 = 东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Item[七丆丒与丗丌丄且丂];
        }
        
        val_22 = null;
        val_22 = null;
        不丘丄丝丗丒丙一丌 val_17 = 不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐())]);
        val_23 = null;
        val_23 = null;
        val_24 = null;
        if((东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.ContainsKey(key:  七丆丒与丗丌丄且丂)) != false)
        {
                val_25 = null;
            东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.set_Item(key:  七丆丒与丗丌丄且丂, value:  val_17);
            return;
        }
        
        val_26 = null;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  七丆丒与丗丌丄且丂, value:  val_17);
    }
    internal static void 丘丞丏丈丝丟不丅丞()
    {
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        string val_46;
        string val_47;
        var val_48;
        var val_49;
        int val_50;
        var val_51;
        string val_52;
        var val_53;
        var val_54;
        var val_55;
        int val_56;
        int val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        val_40 = null;
        val_40 = null;
        东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不 = false;
        if(东丟丟万下丛丆丛丟.丂七三世丘万丘丝丘() != false)
        {
                if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_9;
        }
        
        }
        
        }
        
        东丟丟万下丛丆丛丟.丘丕丗丒丄不丙丒丙();
        label_130:
        val_41 = null;
        val_41 = null;
        东丟丟万下丛丆丛丟.丐东丈不丌不下丕丝 = true;
        return;
        label_9:
        if(GameConnect.丑丌丛丈丅丅与不业() != 19)
        {
            goto label_16;
        }
        
        东丟丟万下丛丆丛丟.丘丕丗丒丄不丙丒丙();
        label_116:
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  200, value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_sniperrespawn", 业东丘与与业丏丛丈:  "#sniper_respawn", 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "#sniper_respawn_description", 丞世不丒下上上丝丑:  0, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65)));
        goto label_130;
        label_16:
        if(GameConnect.丑丌丛丈丅丅与不业() != 30)
        {
            goto label_23;
        }
        
        东丟丟万下丛丆丛丟.丘丕丗丒丄不丙丒丙();
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  212, value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_imposter_kill", 业东丘与与业丏丛丈:  "#imposter_kill", 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "#imposter_kill_description", 丞世不丒下上上丝丑:  0, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65)));
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  200, value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_imposter_report", 业东丘与与业丏丛丈:  "#imposter_report", 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "#imposter_report_description", 丞世不丒下上上丝丑:  0, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65)));
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  188, value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  188, 丞丅上丏丂且下丅与:  "gadget_imposter_teleport", 业东丘与与业丏丛丈:  "#imposter_teleport", 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "#imposter_teleport_description", 丞世不丒下上上丝丑:  0, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65)));
        goto label_130;
        label_23:
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_32;
        }
        
        东丟丟万下丛丆丛丟.丟丌一丒业且丒丂丘();
        if(MonsterHunterModeController.且业丞且丘丌丄丞丑() != false)
        {
                val_42 = null;
            val_42 = null;
            val_43 = null;
            val_43 = null;
            东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  212, value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  MonsterHunterModeController.丏下丒丒丄不丌专上, 业东丘与与业丏丛丈:  "#sniper_respawn", 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "#sniper_respawn_description", 丞世不丒下上上丝丑:  0, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65)));
        }
        
        if(MonsterHunterModeController.丝不且丛不丟丞丆与() == false)
        {
            goto label_130;
        }
        
        val_44 = null;
        val_44 = null;
        val_45 = 95;
        val_46 = "#sniper_respawn";
        val_47 = "#sniper_respawn_description";
        val_48 = 65;
        val_49 = 5;
        val_50 = 0;
        val_51 = 13000;
        val_52 = MonsterHunterModeController.丅丗丙东上丅丘东丕;
        goto label_48;
        label_32:
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_19 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_19 != null)
        {
                if((val_19.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) == 100)
        {
                val_53 = null;
            val_53 = null;
            东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不 = true;
        }
        
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
            goto label_57;
        }
        
        val_54 = null;
        val_54 = null;
        val_55 = new string[2];
        if(东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不 == true)
        {
            goto label_60;
        }
        
        val_55[0] = 丁下万丟且丟丛下业.丆丏丒丆万丄且丗丛(丗丑丐丕丟丝且下丕:  "gadget_fraggrenade");
        val_56 = System.String.alignConst;
        val_57 = val_22.Length;
        goto label_69;
        label_57:
        val_55 = new string[2];
        label_60:
        val_58 = null;
        val_58 = null;
        val_55[0] = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  212, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
        val_55[1] = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  200, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_86;
        }
        
        val_55[0] = System.String.alignConst;
        val_57 = val_24.Length;
        val_56 = "gadget_vehiclerecover";
        label_69:
        val_55[1] = val_56;
        label_86:
        东丟丟万下丛丆丛丟.丘丕丗丒丄不丙丒丙();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_55[0])) != true)
        {
                val_59 = null;
            val_59 = null;
            东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  212, value:  不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_55[0]]));
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_55[1])) == true)
        {
            goto label_130;
        }
        
        if((System.String.op_Equality(a:  val_55[1], b:  "gadget_vehiclerecover")) == false)
        {
            goto label_113;
        }
        
        val_52 = "gadget_vehiclerecover";
        val_45 = 95;
        val_50 = 0;
        val_46 = "#vehicle_recover";
        val_47 = "#vehicle_recover_description";
        val_48 = 65;
        val_49 = 5;
        val_51 = 13000;
        label_48:
        null = new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  val_52, 业东丘与与业丏丛丈:  val_46, 丗丈一丟丈万丅丞东:  0, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  val_47, 丞世不丒下上上丝丑:  val_50, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  0, 丌丞丌丌丈丁丏丅丟:  0, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  System.String.alignConst, 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65);
        val_60 = null;
        val_60 = null;
        goto label_116;
        label_113:
        不丘丄丝丗丒丙一丌 val_39 = 不丘丄丝丗丒丙一丌.东丝七业丄丑丒世七(丁且丌丁丆丝丙丘丝:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_55[1]]);
        val_61 = null;
        val_61 = null;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东.Add(key:  200, value:  val_39);
        if((val_39 == null) || (null != 3))
        {
            goto label_130;
        }
        
        val_62 = null;
        val_62 = null;
        东丟丟万下丛丆丛丟.专丅业三丑万不业丂 = val_39;
        goto label_130;
    }
    private static 东丟丟万下丛丆丛丟()
    {
        东丟丟万下丛丆丛丟.专丅业三丑万不业丂 = 0;
        东丟丟万下丛丆丛丟.丟丛丙七一与专上丆 = 0;
        东丟丟万下丛丆丛丟.万丑三丆东丒三丄丅 = 0;
        东丟丟万下丛丆丛丟.丘丆丁丛丁丗丅世东 = new System.Collections.Generic.Dictionary<GadgetCategory, 不丘丄丝丗丒丙一丌>(capacity:  3, comparer:  丘业丝世丐不丗丆东.丑七不且上丗丁一世());
        东丟丟万下丛丆丛丟.丐东丈不丌不下丕丝 = false;
        东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不 = false;
    }

}
