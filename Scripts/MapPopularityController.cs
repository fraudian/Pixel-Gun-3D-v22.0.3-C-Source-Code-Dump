using UnityEngine;
internal sealed class MapPopularityController : PGBehaviour
{
    // Fields
    internal static MapPopularityController 丆丕丝丒不丙且丐丗;
    private static System.Action 丛东东专业丟丞上一;
    private System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 东且丏且丘业下丙丈;
    internal float 丅丏丌一三不丑丑丗;
    internal static System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, int>>> 下世丄丏不上丁丘丅;
    internal static System.Collections.Generic.Dictionary<int, float> 七丗丒一丆不与丙丌;
    
    // Methods
    internal static void 丅丄不丌丑世且丒七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  MapPopularityController.丛东东专业丟丞上一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MapPopularityController.丛东东专业丟丞上一 != 1152921505229799432);
    
    }
    internal static void 东丝丑专七丑丆丒上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  MapPopularityController.丛东东专业丟丞上一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MapPopularityController.丛东东专业丟丞上一 != 1152921505229799432);
    
    }
    internal static int 丁万一丛三下专丟丂(int 丅丈世丕业世丄丏丟)
    {
        if((丅丈世丕业世丄丏丟 & 2147483648) != 0)
        {
                return 0;
        }
        
        if(丅丈世丕业世丄丏丟 < 3)
        {
                return 1;
        }
        
        if(丅丈世丕业世丄丏丟 < 6)
        {
                return 2;
        }
        
        if(丅丈世丕业世丄丏丟 < 11)
        {
                return 3;
        }
        
        if(丅丈世丕业世丄丏丟 < 16)
        {
                return 4;
        }
        
        return 5;
    }
    internal void 世丞丄丝专上丐丗丂(System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 业丐世丆不上丏丏业)
    {
        int val_4;
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_69;
        MapPopularityController val_70;
        var val_71;
        var val_73;
        int val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_83;
        string val_84;
        SceneInfo val_85;
        string val_89;
        var val_90;
        int val_91;
        System.Collections.Generic.List<T> val_92;
        string val_93;
        System.Collections.Generic.List<T> val_94;
        System.Collections.Generic.List<T> val_95;
        System.Collections.Generic.List<T> val_96;
        var val_97;
        Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_99;
        var val_100;
        val_69 = 业丐世丆不上丏丏业;
        val_70 = this;
        if(val_69 == null)
        {
                val_69 = this.东且丏且丘业下丙丈;
        }
        
        val_71 = 1152921504689381376;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        List.Enumerator<T> val_2 = val_69.GetEnumerator();
        val_73 = 1152921505229795328;
        val_74 = 0;
        val_75 = 0;
        goto label_23;
        label_172:
        val_69 = val_4.丙东专丂世丈丏丁丂();
        val_76 = null;
        val_76 = null;
        if((MapPopularityController.七丗丒一丆不与丙丌.TryGetValue(key:  val_69, value: out  float val_6 = -1.633687E+15f)) == false)
        {
            goto label_7;
        }
        
        float val_8 = UnityEngine.Time.realtimeSinceStartup;
        val_8 = val_8 - 0f;
        if(val_8 < 0)
        {
            goto label_23;
        }
        
        label_7:
        val_77 = null;
        val_77 = null;
        MapPopularityController.七丗丒一丆不与丙丌.set_Item(key:  val_69, value:  UnityEngine.Time.realtimeSinceStartup);
        string val_10 = 丟丌丁且且世丈丈丟.不丛丁且丘丑上丕七(丂丛丑东不丅丈一东:  val_69);
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>> val_11 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>>();
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_12 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>();
        null.set_Item(key:  val_10, value:  null);
        val_78 = null;
        val_78 = null;
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_23;
        }
        
        val_79 = null;
        val_79 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_69)) == null)
        {
            goto label_23;
        }
        
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_16 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  val_69, 丞丁丑丏丄丏七丂不:  0);
        System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_17 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
        if(val_16 == null)
        {
            goto label_74;
        }
        
        var val_72 = 0;
        val_72 = val_72 + 1;
        System.Collections.Generic.IEnumerator<T> val_19 = val_16.GetEnumerator();
        label_52:
        var val_73 = 0;
        val_73 = val_73 + 1;
        if(val_19.MoveNext() == false)
        {
            goto label_36;
        }
        
        var val_74 = 0;
        val_74 = val_74 + 1;
        T val_23 = val_19.Current;
        if((val_23 == 0) || ((System.String.IsNullOrEmpty(value:  val_23.丕丆丞丂业东与上丅())) == true))
        {
            goto label_52;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_26 = val_23.丌不丅不丞东万专专();
        if(((-658916776) & 1) == 0)
        {
            goto label_52;
        }
        
        val_83 = null;
        val_83 = null;
        val_84 = val_23.丕丆丞丂业东与上丅();
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
                val_84 = val_84;
        }
        
        val_85 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_84);
        val_85 = val_85;
        if(val_85 == 0)
        {
            goto label_52;
        }
        
        val_17.Add(item:  val_23);
        goto label_52;
        label_36:
        var val_75 = 0;
        val_75 = val_75 + 1;
        mem2[0] = 292;
        if(val_19 != null)
        {
                var val_76 = 0;
            val_76 = val_76 + 1;
            val_19.Dispose();
        }
        
        var val_78 = val_75;
        if((val_78 == 1) || ((-658916976 + ((0 + 1)) << 2) != 292))
        {
            goto label_71;
        }
        
        var val_77 = 0;
        val_77 = val_77 ^ (val_78 >> 31);
        val_78 = val_78 + val_77;
        goto label_72;
        label_71:
        if( == false)
        {
            goto label_73;
        }
        
        val_74 = 0;
        val_75 = 0;
        goto label_74;
        label_73:
        val_74 = 0;
        label_72:
        label_74:
        List.Enumerator<T> val_31 = val_17.GetEnumerator();
        label_100:
        if(((-658916800) & 1) == 0)
        {
            goto label_76;
        }
        
        val_89 = val_4.丐丏七丌丕丗业且上();
        val_90 = null;
        val_89 = val_89;
        val_90 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_89.丕丆丞丂业东与上丅())) == 0)
        {
            goto label_100;
        }
        
        丐丟丙不丗万三丈丆 val_36 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        val_91 = val_34.indexMap;
        if(val_36 == null)
        {
                val_91 = val_91;
        }
        
        int val_37 = val_36.丞上上三丞东丁丝世(丂丛丑东不丅丈一东:  val_69, 丞丁丑丏丄丏七丂不:  val_91);
        if((null.Item[val_10].TryGetValue(key:  val_37, value: out  0)) != true)
        {
                System.Collections.Generic.List<System.String> val_41 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_42 = null.Item[val_10];
            val_92 = null;
            if(val_42 == null)
        {
                val_92 = val_92;
        }
        
            val_42.set_Item(key:  val_37, value:  null);
        }
        
        val_4 = val_34.indexMap;
        val_93 = val_89;
        if(val_93 == 0)
        {
                val_93 = val_89;
        }
        
        int val_43 = val_93.业上丙丞丐丄丆丅七();
        string val_44 = System.String.Format(format:  "{0}_{1}", arg0:  val_4, arg1:  val_43);
        null.Add(item:  val_44);
        if(val_69 != 20)
        {
            goto label_100;
        }
        
        int val_46 = val_37 + 100;
        if((null.Item[val_10].TryGetValue(key:  val_46, value: out  0)) != true)
        {
                System.Collections.Generic.List<System.String> val_49 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_50 = null.Item[val_10];
            val_94 = null;
            if(val_50 == null)
        {
                val_94 = val_94;
        }
        
            val_50.set_Item(key:  val_46, value:  null);
        }
        
        null.Add(item:  val_44);
        goto label_100;
        label_76:
        var val_79 = val_78;
        val_79 = val_79 + 1;
        mem2[0] = 550;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_81 = val_79;
        if((val_81 != 1) && ((-658916976 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 550))
        {
                var val_80 = 0;
            val_80 = val_80 ^ (val_81 >> 31);
            val_81 = val_81 + val_80;
        }
        else
        {
                if( != 0)
        {
                val_74 = 0;
            val_75 = 0;
        }
        else
        {
                val_74 = 0;
        }
        
        }
        
        List.Enumerator<T> val_51 = val_14.avaliableScenes.GetEnumerator();
        label_147:
        if(((-658916848) & 1) == 0)
        {
            goto label_131;
        }
        
        string val_53 = val_43.丐丏七丌丕丗业且上();
        int val_82 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丞上上三丞东丁丝世(丂丛丑东不丅丈一东:  val_69, 丞丁丑丏丄丏七丂不:  -658904624);
        if((null.Item[val_10].TryGetValue(key:  val_82, value: out  0)) != true)
        {
                System.Collections.Generic.List<System.String> val_59 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_60 = null.Item[val_10];
            val_95 = null;
            if(val_60 == null)
        {
                val_95 = val_95;
        }
        
            val_60.set_Item(key:  val_82, value:  null);
        }
        
        string val_61 = val_53 + 56.ToString();
        null.Add(item:  val_61);
        if(val_69 != 20)
        {
            goto label_147;
        }
        
        val_82 = val_82 + 100;
        if((null.Item[val_10].TryGetValue(key:  val_82, value: out  0)) != true)
        {
                System.Collections.Generic.List<System.String> val_65 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_66 = null.Item[val_10];
            val_96 = null;
            if(val_66 == null)
        {
                val_96 = val_96;
        }
        
            val_66.set_Item(key:  val_82, value:  null);
        }
        
        null.Add(item:  val_61);
        goto label_147;
        label_131:
        var val_83 = val_81;
        val_83 = val_83 + 1;
        mem2[0] = 759;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_97 = val_83;
        if((val_97 != 1) && ((-658916976 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 759))
        {
                val_71 = 1152921504689381376;
            var val_84 = 0;
            val_84 = val_84 ^ (val_97 >> 31);
            val_97 = val_97 + val_84;
        }
        else
        {
                val_71 = 1152921504689381376;
            if( != 0)
        {
                val_74 = 0;
            val_75 = 0;
        }
        else
        {
                val_74 = 0;
        }
        
        }
        
        val_4 = val_69;
        val_69 = val_4;
        val_70 = val_70;
        val_1.set_Item(key:  val_4, value:  null);
        label_23:
        if(((-658916768) & 1) != 0)
        {
            goto label_172;
        }
        
        val_99 = val_97 + 1;
        mem2[0] = 802;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_199;
        }
        
        if(( == 0) || ((-658916976 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 802))
        {
            goto label_209;
        }
        
        label_208:
        label_209:
        if(val_1.Count < 1)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_68 = null;
        val_69 = val_68;
        val_68 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_68.set_Item(key:  "params", value:  val_1);
        val_73 = 1152921505499283456;
        val_100 = null;
        val_100 = null;
        Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_70 = null;
        val_99 = val_70;
        val_70 = new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MapPopularityController::丒万业丛丏东专世丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不));
        int val_71 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丗丞东丝丕三丛丐丑, 一丐丗丁丞丆丅丟丄:  val_68, 业丏丈世世世丞丒世:  val_70);
        return;
        label_199:
        if( != 0)
        {
            goto label_208;
        }
        
        goto label_209;
    }
    private void 丒万业丛丏东专世丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_10;
        var val_22;
        object val_28;
        var val_32;
        object val_33;
        int val_34;
        var val_38;
        var val_39;
        var val_40;
        var val_42;
        System.Action val_43;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
            val_28 = System.String.Format(format:  "GetMapPopularity fail {0}", arg0:  丑与丂丌世丕丆一丗.Item["err_code"]);
        }
        else
        {
                object val_5 = 丑与丂丌世丕丆一丗.Item["data"];
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
            val_28 = "MapPopularity error get maps";
        }
        
        UnityEngine.Debug.LogError(message:  val_28);
        return;
        label_70:
        if(((-658584288) & 1) == 0)
        {
            goto label_19;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_10.GetAwaiter();
        int val_13 = System.Convert.ToInt32(value:  val_11._value._obj.丐丏七丌丕丗业且上());
        if(val_11._value._obj == 0)
        {
            goto label_70;
        }
        
        val_32 = null;
        val_32 = null;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_14 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
        MapPopularityController.下世丄丏不上丁丘丅.set_Item(key:  val_13, value:  null);
        Dictionary.Enumerator<TKey, TValue> val_15 = val_11._value._obj.GetEnumerator();
        label_54:
        if(((-658584352) & 1) == 0)
        {
            goto label_28;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_10.GetAwaiter();
        if(val_16._value._obj == 0)
        {
            goto label_54;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_19 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        Dictionary.Enumerator<TKey, TValue> val_20 = val_16._value._obj.GetEnumerator();
        label_38:
        if(((-658584416) & 1) == 0)
        {
            goto label_34;
        }
        
        ConfiguredValueTaskAwaiter val_24 = val_22.GetAwaiter();
        val_33 = val_24._value._obj;
        val_34 = System.Convert.ToInt32(value:  val_33);
        if(null == 0)
        {
                val_34 = val_34;
        }
        
        null.set_Item(key:  val_24._value._obj.丐丏七丌丕丗业且上(), value:  val_34);
        goto label_38;
        label_34:
        var val_28 = 0;
        val_28 = val_28 + 1;
        mem2[0] = 288;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_28 != 1) && ((1152921538308000784 + ((0 + 1)) << 2) == 288))
        {
                var val_30 = val_28;
            var val_29 = 0;
            val_29 = val_29 ^ (val_30 >> 31);
            val_30 = val_30 + val_29;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        MapPopularityController.下世丄丏不上丁丘丅.Item[val_13].set_Item(key:  System.Convert.ToInt32(value:  val_16._value._obj.丐丏七丌丕丗业且上()), value:  null);
        goto label_54;
        label_28:
        var val_31 = val_30;
        val_39 = ;
        val_31 = val_31 + 1;
        mem2[0] = 336;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_33 = val_31;
        if((val_33 == 1) || ((1152921538308000784 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) != 336))
        {
            goto label_67;
        }
        
        var val_32 = 0;
        val_32 = val_32 ^ (val_33 >> 31);
        val_33 = val_33 + val_32;
        goto label_70;
        label_67:
        if( == 0)
        {
            goto label_70;
        }
        
        goto label_70;
        label_19:
        val_40 = val_33 + 1;
        mem2[0] = 364;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_81;
        }
        
        if(( == 0) || ((1152921538308000784 + (((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + (0 ^ ((int)(((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) >> 31))) << 2) == 364))
        {
            goto label_92;
        }
        
        label_91:
        label_92:
        val_42 = null;
        val_43 = MapPopularityController.丛东东专业丟丞上一;
        if(val_43 == null)
        {
                return;
        }
        
        val_43 = MapPopularityController.丛东东专业丟丞上一;
        if(val_43 == null)
        {
                val_43 = 0;
        }
        
        val_43.Invoke();
        return;
        label_81:
        if( != 0)
        {
            goto label_91;
        }
        
        goto label_92;
    }
    private void Start()
    {
        null = null;
        MapPopularityController.丆丕丝丒不丙且丐丗 = this;
        this.世丞丄丝专上丐丗丂(业丐世丆不上丏丏业:  0);
    }
    private void OnDestroy()
    {
        null = null;
        MapPopularityController.丆丕丝丒不丙且丐丗 = 0;
    }
    public MapPopularityController()
    {
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_1 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
        if(val_1 != null)
        {
                val_1.Add(item:  2);
            val_1.Add(item:  0);
            val_1.Add(item:  20);
            val_1.Add(item:  31);
            val_1.Add(item:  5);
            val_1.Add(item:  4);
            val_1.Add(item:  2);
            val_1.Add(item:  8);
            val_1.Add(item:  17);
            val_1.Add(item:  22);
            val_1.Add(item:  16);
        }
        else
        {
                val_1.Add(item:  2);
            val_1.Add(item:  0);
            val_1.Add(item:  20);
            val_1.Add(item:  31);
            val_1.Add(item:  5);
            val_1.Add(item:  4);
            val_1.Add(item:  2);
            val_1.Add(item:  8);
            val_1.Add(item:  17);
            val_1.Add(item:  22);
            val_1.Add(item:  16);
        }
        
        val_1.Add(item:  32);
        this.东且丏且丘业下丙丈 = val_1;
        this.丅丏丌一三不丑丑丗 = 120f;
    }
    private static MapPopularityController()
    {
        MapPopularityController.丆丕丝丒不丙且丐丗 = 0;
        MapPopularityController.丛东东专业丟丞上一 = 0;
        MapPopularityController.下世丄丏不上丁丘丅 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>>();
        MapPopularityController.七丗丒一丆不与丙丌 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
    }

}
