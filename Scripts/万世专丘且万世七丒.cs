using UnityEngine;
public static class 万世专丘且万世七丒
{
    // Fields
    private static int[] 丕不七丑丐丅丒丌丕;
    
    // Properties
    internal static bool 与丟丂丅丝丝丂丕东 { get; }
    
    // Methods
    private static float 三丅东世丛一丞丒丏(WeaponSounds 丌丝下丄业一丄不三, 丅丙上七上一丐不下 丞下万上三丘上与专, out int 丛丗丏丏三下丟与万)
    {
        var val_10;
        float val_13;
        System.Int32[] val_57;
        var val_58;
        float val_59;
        UnityEngine.Object val_60;
        var val_61;
        var val_62;
        UnityEngine.Object val_63;
        var val_64;
        float val_65;
        var val_66;
        var val_67;
        var val_69;
        float val_71;
        var val_73;
        var val_75;
        int val_76;
        var val_77;
        var val_78;
        val_57 = 丞下万上三丘上与专;
        丛丗丏丏三下丟与万 = 0;
        val_58 = null;
        val_59 = 0f;
        if(val_57 == null)
        {
                return (float)val_59;
        }
        
        if(万世专丘且万世七丒.丅丌丏下丏丞下丆丂() == false)
        {
                return (float)val_59;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == true)
        {
            goto label_7;
        }
        
        val_60 = 0;
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_12;
        }
        
        label_7:
        val_60 = 0;
        label_12:
        val_61 = 1152921504848912384;
        if( != 0)
        {
                if(丙丕丁丅丁与丗丑丘() != 0)
        {
            goto label_17;
        }
        
        }
        
        val_60 = 0;
        label_17:
        val_62 = 0;
        if( == 0)
        {
            goto label_22;
        }
        
        if(丌丝下丄业一丄不三 != null)
        {
            goto label_29;
        }
        
        goto label_28;
        label_22:
        val_63 = 0;
        if(丌丝下丄业一丄不三 != null)
        {
            goto label_29;
        }
        
        label_28:
        label_29:
        Dictionary.Enumerator<TKey, TValue> val_12 = 丌丝下丄业一丄不三.三世丗丆丕万丐且三.GetEnumerator();
        val_57 = 1152921538371884016;
        val_64 = 0;
        val_59 = 0f;
        goto label_34;
        label_94:
        string val_14 = val_10.丐丏七丌丕丗业且上();
        if((val_14.丙东专丂世丈丏丁丂() - 1) > 2)
        {
            goto label_34;
        }
        
        val_65 = val_13;
        val_66 = 1152921505066536960;
        if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                if(((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null) && (世丐丟三丑一万丌一.丑七不且上丗丁一世().丈丘丒下专丅丟业丑().Count > 0))
        {
                val_67 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().丈丘丒下专丅丟业丑().Item[UnityEngine.Mathf.Min(a:  世丐丟三丑一万丌一.丑七不且上丗丁一世().丈丘丒下专丅丟业丑().Count - 1, b:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丑与丏丈丕七丙丂())];
            val_61 = 1152921504848912384;
            val_66 = 1152921505066536960;
        }
        else
        {
                val_67 = 2147483647;
        }
        
            val_65 = UnityEngine.Mathf.Min(a:  val_65, b:  2.147484E+09f);
        }
        
        if(val_60 == 0)
        {
            goto label_56;
        }
        
        if(val_60.丙丕丁丅丁与丗丑丘() != val_14.丙东专丂世丈丏丁丂())
        {
            goto label_60;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_63;
        }
        
        val_69 = null;
        val_69 = null;
        float val_39 = DungeonsController.丄丘七三上丕世丞业.mobModuleDPSMultiplier;
        goto label_67;
        label_56:
        if(val_63 == 0)
        {
            goto label_93;
        }
        
        val_71 = 0f;
        if((914882560.ContainsKey(key:  val_14.丙东专丂世丈丏丁丂())) != false)
        {
                val_71 = 914882560.Item[val_14.丙东专丂世丈丏丁丂()];
        }
        
        float val_56 = 0f;
        float val_45 = UnityEngine.Mathf.Clamp(value:  val_71, min:  val_56, max:  val_65);
        float val_46 = 丌丝下丄业一丄不三.丙下业七一一下世万();
        val_56 = val_65 - val_45;
        val_46 = val_45 / val_46;
        if(val_46 > 0.2f)
        {
            goto label_80;
        }
        
        goto label_93;
        label_60:
        val_65 = 0f;
        if(val_59 != 0f)
        {
            goto label_93;
        }
        
        label_80:
        val_73 = null;
        val_73 = null;
        var val_57 = 0;
        val_57 = val_57 + 1;
        mem[32] = val_14.丙东专丂世丈丏丁丂();
        goto label_93;
        label_63:
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_90;
        }
        
        label_67:
        val_65 = val_65 * 世丐丟三丑一万丌一.丑七不且上丗丁一世().世三不且一丆丕丂上().东世丆下丒丘丙丗丐();
        goto label_93;
        label_90:
        label_93:
        val_59 = val_59 + val_65;
        val_64 = 1;
        label_34:
        if(((-594631136) & 1) != 0)
        {
            goto label_94;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( | (~(UnityEngine.Object.op_Inequality(x:  val_60, y:  0)))) == false)
        {
            goto label_142;
        }
        
        val_75 = 0;
        if(val_75 >= 1)
        {
            goto label_143;
        }
        
        val_76 = 0;
        goto label_144;
        label_142:
        val_77 = null;
        val_77 = null;
        万世专丘且万世七丒.丕不七丑丐丅丒丌丕.__unknownFiledOffset_20 = 0;
        val_75 = 1;
        label_143:
        val_78 = null;
        val_78 = null;
        val_57 = 万世专丘且万世七丒.丕不七丑丐丅丒丌丕;
        int val_54 = UnityEngine.Random.Range(min:  0, max:  1);
        System.Int32[] val_55 = val_57 + (((long)(int)(val_54)) << 2);
        val_76 = mem[(万世专丘且万世七丒.丕不七丑丐丅丒丌丕 + ((long)(int)(val_54)) << 2) + 32];
        val_76 = (万世专丘且万世七丒.丕不七丑丐丅丒丌丕 + ((long)(int)(val_54)) << 2) + 32;
        label_144:
        丛丗丏丏三下丟与万 = val_76;
        return (float)val_59;
    }
    internal static float 丝丛丈丟丅一上世丞(WeaponSounds 丌丝下丄业一丄不三, UnityEngine.Transform 丞下万上三丘上与专)
    {
        var val_23;
        float val_25;
        var val_26;
        var val_27;
        int val_29;
        int val_5 = 0;
        val_23 = null;
        if(万世专丘且万世七丒.丅丌丏下丏丞下丆丂() == false)
        {
                return (float)丌丝下丄业一丄不三.业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  1f, 丆专三丈丛丗丑且东:  0f, 业一一七丂丞丁丝丝:  false);
        }
        
        if(丞下万上三丘上与专 == 0)
        {
                return (float)丌丝下丄业一丄不三.业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  1f, 丆专三丈丛丗丑且东:  0f, 业一一七丂丞丁丝丝:  false);
        }
        
        丅丙上七上一丐不下 val_4 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丞下万上三丘上与专);
        val_25 = 1f;
        if(val_4 == null)
        {
            goto label_24;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_17;
        }
        
        val_26 = null;
        val_26 = null;
        float val_8 = DungeonsController.丄丘七三上丕世丞业.丅丗丞七与丝一与丈();
        goto label_21;
        label_17:
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_24;
        }
        
        label_21:
        val_25 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().世三不且一丆丕丂上().丞丒东丗丒丒专下丒();
        label_24:
        val_27 = 0;
        float val_13 = 丌丝下丄业一丄不三.业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  val_25, 丆专三丈丛丗丑且东:  万世专丘且万世七丒.三丅东世丛一丞丒丏(丌丝下丄业一丄不三:  丌丝下丄业一丄不三, 丞下万上三丘上与专:  val_4, 丛丗丏丏三下丟与万: out  val_5), 业一一七丂丞丁丝丝:  false);
        if((val_5 & 2147483648) != 0)
        {
                return (float)丌丝下丄业一丄不三.业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  1f, 丆专三丈丛丗丑且东:  0f, 业一一七丂丞丁丝丝:  false);
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_27 = 6;
        if(val_4.moduleResistShownFrame == UnityEngine.Time.frameCount)
        {
                return (float)丌丝下丄业一丄不三.业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  1f, 丆专三丈丛丗丑且东:  0f, 业一一七丂丞丁丝丝:  false);
        }
        
        丌丝下丄业一丄不三.丙且丕丝三丞下丞丌 = 0f;
        val_29 = UnityEngine.Time.frameCount;
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_27 = 7;
        val_4.moduleResistShownFrame = ;
        万世专丘且万世七丒.丛丝丞丛丒丁丌丞丐(丞下万上三丘上与专:  丞下万上三丘上与专, 丛丗丏丏三下丟与万:  0);
        return (float)丌丝下丄业一丄不三.业丂丛丟上且丂东丂(一上丞专业丝丟丘业:  1f, 丆专三丈丛丗丑且东:  0f, 业一一七丂丞丁丝丝:  false);
    }
    internal static float 丏下丐业丏万丄丁下(float 万丄丟业丅丄不东丒, System.Collections.Generic.Dictionary<int, float> 业业丈丗丅丘不上丙, UnityEngine.Transform 丞下万上三丘上与专)
    {
        var val_22;
        UnityEngine.Transform val_34;
        var val_35;
        float val_36;
        float val_37;
        var val_38;
        DungeonsController val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        val_34 = 丞下万上三丘上与专;
        val_35 = 业业丈丗丅丘不上丙;
        val_36 = 万丄丟业丅丄不东丒;
        val_37 = 0;
        val_38 = null;
        val_38 = null;
        val_39 = 1152921504848912384;
        if(DungeonsController.丄丘七三上丕世丞业 == 0)
        {
                return val_36;
        }
        
        丅丙上七上一丐不下 val_2 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_34);
        val_40 = 0;
        val_41 = 0;
        if( == 0)
        {
                return val_36;
        }
        
        val_42 = 1152921505066536960;
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_43 = null;
            val_43 = null;
            val_39 = DungeonsController.丄丘七三上丕世丞业;
            float val_6 = val_39.丅丗丞七与丝一与丈();
        }
        else
        {
                if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                val_39 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().世三不且一丆丕丂上();
            float val_10 = val_39.丞丒东丗丒丒专下丒();
        }
        else
        {
                val_37 = 1f;
        }
        
        }
        
        val_36 = val_37 * val_36;
        if(val_35 == null)
        {
            goto label_69;
        }
        
        if(丙丕丁丅丁与丗丑丘() == 0)
        {
            goto label_29;
        }
        
        val_39 = 1152921505232723968;
        val_41 = public System.Boolean System.Collections.Generic.Dictionary<System.Int32, System.Single>::ContainsKey(System.Int32 key);
        if((val_35.ContainsKey(key:  丙丕丁丅丁与丗丑丘())) == false)
        {
            goto label_33;
        }
        
        label_29:
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_45 = null;
            val_45 = null;
            val_34 = DungeonsController.丄丘七三上丕世丞业;
            float val_15 = val_34.mobModuleDPSMultiplier;
        }
        else
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
                return val_36;
        }
        
            val_34 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().世三不且一丆丕丂上();
            float val_19 = val_34.东世丆下丒丘丙丗丐();
        }
        
        val_19 = val_36 * val_19;
        val_36 = val_36 + val_19;
        return val_36;
        label_33:
        Dictionary.Enumerator<TKey, TValue> val_20 = val_35.GetEnumerator();
        val_42 = 1152921536415323312;
        val_46 = 0;
        goto label_50;
        label_55:
        string val_23 = val_22.丐丏七丌丕丗业且上();
        if((val_23.丙东专丂世丈丏丁丂() - 1) <= 2)
        {
                val_47 = null;
            val_47 = null;
            if(val_46 >= 万世专丘且万世七丒.丕不七丑丐丅丒丌丕.Length)
        {
                val_41 = 0;
        }
        
            val_46 = 1;
            mem[32] = val_23.丙东专丂世丈丏丁丂();
        }
        
        label_50:
        if(((-594247312) & 1) != 0)
        {
            goto label_55;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_46 < 1)
        {
            goto label_64;
        }
        
        val_48 = null;
        val_48 = null;
        val_41 = 0;
        if((UnityEngine.Random.Range(min:  0, max:  1)) >= 万世专丘且万世七丒.丕不七丑丐丅丒丌丕.Length)
        {
                val_41 = 0;
        }
        
        System.Int32[] val_28 = 万世专丘且万世七丒.丕不七丑丐丅丒丌丕 + (((long)(int)(val_27)) << 2);
        val_35 = mem[(万世专丘且万世七丒.丕不七丑丐丅丒丌丕 + ((long)(int)(val_27)) << 2) + 32];
        val_35 = (万世专丘且万世七丒.丕不七丑丐丅丒丌丕 + ((long)(int)(val_27)) << 2) + 32;
        if((val_35 & 2147483648) == 0)
        {
            goto label_69;
        }
        
        return val_36;
        label_64:
        val_35 = 0;
        label_69:
        val_39 = 1152921505240178688;
        var val_34 = 0;
        val_34 = val_34 + 1;
        val_41 = 6;
        if(val_2.moduleResistShownFrame == UnityEngine.Time.frameCount)
        {
                return val_36;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_41 = 7;
        val_2.moduleResistShownFrame = UnityEngine.Time.frameCount;
        万世专丘且万世七丒.丛丝丞丛丒丁丌丞丐(丞下万上三丘上与专:  val_34, 丛丗丏丏三下丟与万:  0);
        return val_36;
    }
    private static float 业丛丛万丄丒丗一丁(PGCompany.ModuleData.ModuleType 丗与丟上上丑专世丗, float 万丆与丒丟专丛丞下)
    {
        float val_3;
        float val_4;
        val_3 = 万丆与丒丟专丛丞下;
        if((丗与丟上上丑专世丗 - 1) < 3)
        {
                return (float)val_3;
        }
        
        val_4 = val_3 / 100f;
        if(丗与丟上上丑专世丗 <= 21)
        {
                var val_3 = 1;
            val_3 = val_3 << 丗与丟上上丑专世丗;
            if((val_3 & 2144) != 0)
        {
                return (float)val_3;
        }
        
            val_3 = val_3 & 2621696;
            if(val_3 != 0)
        {
                val_3 = 1f - val_4;
            return (float)val_3;
        }
        
            if(丗与丟上上丑专世丗 == 20)
        {
                val_4 = val_3 / 500f;
        }
        
        }
        
        val_3 = val_4 + 1f;
        return (float)val_3;
    }
    internal static void 七且丄丏丐丅且丐东()
    {
        var val_15;
        var val_16;
        val_15 = null;
        val_15 = null;
        WeaponSounds val_1 = 丙不丅丕三丂业东丕();
        if(val_1 == 0)
        {
                return;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                return;
        }
        
        PGCompany.丗丟丅七东丄丙丟上 val_7 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  val_1.丌上丗丕不七世丅丁().与不丞丑七丘丁丂丛());
        val_1.三世丗丆丕万丐且三.Clear();
        val_16 = null;
        val_16 = null;
        if(val_7 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_8 = val_7.丟且丘丗七且下三专();
        if(val_8 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_9 = val_8.GetEnumerator();
        label_29:
        if(((-593928040) & 1) == 0)
        {
            goto label_23;
        }
        
        string val_10 = 0.丐丏七丌丕丗业且上();
        if(val_10 == null)
        {
            goto label_29;
        }
        
        val_1.三世丗丆丕万丐且三.Add(key:  val_10.与丝丅丘且丐上丅世(), value:  万世专丘且万世七丒.业丛丛万丄丒丗一丁(丗与丟上上丑专世丗:  val_10.与丝丅丘且丐上丅世(), 万丆与丒丟专丛丞下:  val_10.丞万丆丑且丟丑专丟()));
        goto label_29;
        label_23:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static void 丑万业三丗业丛与七()
    {
        var val_13;
        var val_22;
        Player_move_c val_23;
        var val_24;
        val_22 = null;
        val_22 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(GameConnect.与不丗丏万丙丞丌丑() == true)
        {
                return;
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_DE0 + 120.Clear();
        val_24 = null;
        val_24 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_23 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7);
        if((System.String.op_Equality(a:  val_23, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == true)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_23)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_23, b:  与丂丏丛丞丞丒丟丄.丕丙丐丏七上丘丙一())) == true)
        {
                return;
        }
        
        val_23 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
        PGCompany.丗丟丅七东丄丙丟上 val_9 = val_23.下丗且丆七丛丕与丕();
        if(val_9 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_10 = val_9.丟且丘丗七且下三专();
        if(val_10 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_11 = val_10.GetEnumerator();
        label_36:
        if(((-593730048) & 1) == 0)
        {
            goto label_29;
        }
        
        string val_14 = val_13.丐丏七丌丕丗业且上();
        if((val_14 == null) || ((typeof(Player_move_c).__il2cppRuntimeField_DE0 + 120.ContainsKey(key:  val_14.与丝丅丘且丐上丅世())) == true))
        {
            goto label_36;
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_DE0 + 120.Add(key:  val_14.与丝丅丘且丐上丅世(), value:  万世专丘且万世七丒.业丛丛万丄丒丗一丁(丗与丟上上丑专世丗:  val_14.与丝丅丘且丐上丅世(), 万丆与丒丟专丛丞下:  val_14.丞万丆丑且丟丑专丟()));
        goto label_36;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
    }
    internal static void 专丞丈万丂万丘专一(System.Collections.Generic.Dictionary<int, float> 与上丌丅七丒丗丑丅, int[] 丛下不丛与万丏丒丕, float[] 丅丝丕丌丘丆丁丂业)
    {
        var val_1;
        与上丌丅七丒丗丑丅.Clear();
        val_1 = 0;
        goto label_2;
        label_8:
        与上丌丅七丒丗丑丅.Add(key:  丛下不丛与万丏丒丕[0], value:  丅丝丕丌丘丆丁丂业[0]);
        val_1 = 1;
        label_2:
        if(val_1 < 丛下不丛与万丏丒丕.Length)
        {
            goto label_8;
        }
    
    }
    internal static void 丆丞一丏专丐丕丂业(System.Collections.Generic.Dictionary<int, float> 与上丌丅七丒丗丑丅, out int[] 丛下不丛与万丏丒丕, out float[] 丅丝丕丌丘丆丁丂业)
    {
        var val_5;
        var val_6;
        var val_9;
        System.Single[] val_10;
        val_9 = 1152921538373353648;
        val_10 = 与上丌丅七丒丗丑丅;
        int val_1 = val_10.Count;
        丛下不丛与万丏丒丕 = new int[0];
        丅丝丕丌丘丆丁丂业 = new float[0];
        Dictionary.Enumerator<TKey, TValue> val_4 = val_10.GetEnumerator();
        goto label_3;
        label_8:
        mem2[0] = val_5.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂();
        val_10 = 丅丝丕丌丘丆丁丂业;
        mem2[0] = val_6;
        label_3:
        if(((-593283968) & 1) != 0)
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static void 丛丝丞丛丒丁丌丞丐(UnityEngine.Transform 丞下万上三丘上与专, int 丛丗丏丏三下丟与万)
    {
        var val_13;
        var val_14;
        if((丛丗丏丏三下丟与万 & 2147483648) != 0)
        {
                return;
        }
        
        val_13 = 1152921505171808256;
        val_14 = null;
        val_14 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                return;
        }
        
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丞下万上三丘上与专);
        HitParticle val_2 = GetCurrentParticle(丁丈丄不且专丘与世:  true);
        val_2.下七丙世上丄下丆丄(丗与丟上上丑专世丗:  丛丗丏丏三下丟与万);
        UnityEngine.Vector3 val_3 = 丞下万上三丘上与专.position;
        UnityEngine.Quaternion val_4 = 丞下万上三丘上与专.rotation;
        val_2.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, 丁丈丄不且专丘与世:  false);
    }
    internal static bool 丅丌丏下丏丞下丆丂()
    {
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  18);
        if(val_1 != null)
        {
                if((val_1.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool")) == false)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return (bool)0 & 1;
        }
        
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_28;
        }
        
        }
        
        return (bool)0 & 1;
        label_28:
        bool val_13 = GameConnect.丙丌丒丈东七丒上丌() ^ 1;
        return (bool)0 & 1;
    }
    internal static bool 一丑丛丂世丈丕丛丘(int 丗与丟上上丑专世丗)
    {
        return (bool)((丗与丟上上丑专世丗 - 1) < 3) ? 1 : 0;
    }
    internal static int 一丞上丙丏丛丕丑丒(RilisoftBot.七一丙世丏下丐丕世 东丙丑丁且上上专丕)
    {
        return (int)东丙丑丁且上上专丕;
    }
    internal static void 丞丗丝丛丙丏丛丛丗(UISprite 与丄丈丘丟丕丏丐丁, PGCompany.ModuleData.ModuleType 丗与丟上上丑专世丗)
    {
        string val_7;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_4 = System.String.Format(format:  "ModuleIcon_" + 丗与丟上上丑专世丗.ToString(), args:  System.Array.Empty<System.Object>());
        UISpriteData val_6 = 与丄丈丘丟丕丏丐丁.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_4);
        if(与丄丈丘丟丕丏丐丁 == null)
        {
            goto label_5;
        }
        
        if(val_6 == null)
        {
            goto label_6;
        }
        
        label_8:
        val_7 = val_4;
        goto label_7;
        label_5:
        if(val_6 != null)
        {
            goto label_8;
        }
        
        label_6:
        val_7 = "ModuleIcon_ModDefault";
        label_7:
        与丄丈丘丟丕丏丐丁.spriteName = val_7;
    }
    private static 万世专丘且万世七丒()
    {
        万世专丘且万世七丒.丕不七丑丐丅丒丌丕 = new int[3];
    }

}
