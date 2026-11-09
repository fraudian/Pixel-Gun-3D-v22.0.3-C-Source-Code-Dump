using UnityEngine;
internal static class 丄丈业一下万且丂丕
{
    // Fields
    private static System.Collections.Generic.List<PlaceableItemSettings> 丁与丁不丒专丙丄业;
    private static readonly System.Collections.Generic.HashSet<int> 丕丁丐丗东丑下丈丙;
    private static System.Collections.Generic.Dictionary<string, PlaceableItemSettings> 丏丅丁东丛丞丁丂丕;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PlaceableItemSettings>>>> 丏东丑上丘不世丟与;
    
    // Properties
    internal static System.Collections.Generic.List<PlaceableItemSettings> 且丟世丙丗丑丄丈丙 { get; }
    internal static System.Collections.Generic.Dictionary<string, PlaceableItemSettings> 上且上丏三丌丄业万 { get; }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PlaceableItemSettings>>>> 丏丒丘丅丑丗丙下丞 { get; }
    
    // Methods
    internal static System.Collections.Generic.List<PlaceableItemSettings> 世七与丈丂丙丏丂丁()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(丄丈业一下万且丂丕.丁与丁不丒专丙丄业.Count == 0)
        {
                丄丈业一下万且丂丕.丄世丕七丙丞业丙七();
        }
        
        val_3 = null;
        val_3 = null;
        return (System.Collections.Generic.List<PlaceableItemSettings>)丄丈业一下万且丂丕.丁与丁不丒专丙丄业;
    }
    internal static System.Collections.Generic.Dictionary<string, PlaceableItemSettings> 丝丁丘上一丄不丙丙()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(丄丈业一下万且丂丕.丏丅丁东丛丞丁丂丕.Count == 0)
        {
                丄丈业一下万且丂丕.丄世丕七丙丞业丙七();
        }
        
        val_3 = null;
        val_3 = null;
        return (System.Collections.Generic.Dictionary<System.String, PlaceableItemSettings>)丄丈业一下万且丂丕.丏丅丁东丛丞丁丂丕;
    }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PlaceableItemSettings>>>> 丘丐与丏与丒丟东丄()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(丄丈业一下万且丂丕.丏东丑上丘不世丟与.Count == 0)
        {
                丄丈业一下万且丂丕.丄世丕七丙丞业丙七();
        }
        
        val_3 = null;
        val_3 = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>>>)丄丈业一下万且丂丕.丏东丑上丘不世丟与;
    }
    internal static void 东丂丝七丈丟丈专与(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 76)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "PlaceableItemSettings --- Config Update ---");
        丄丈业一下万且丂丕.丄世丕七丙丞业丙七();
    }
    internal static bool 丞丟丑丆丁丟丁丒万(int 丆专且丕专丗与一丏)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(丄丈业一下万且丂丕.丁与丁不丒专丙丄业.Count == 0)
        {
                丄丈业一下万且丂丕.丄世丕七丙丞业丙七();
        }
        
        val_3 = null;
        val_3 = null;
        if(丄丈业一下万且丂丕.丕丁丐丗东丑下丈丙 != null)
        {
                return 丄丈业一下万且丂丕.丕丁丐丗东丑下丈丙.Contains(item:  丆专且丕专丗与一丏);
        }
        
        return 丄丈业一下万且丂丕.丕丁丐丗东丑下丈丙.Contains(item:  丆专且丕专丗与一丏);
    }
    internal static void 丄世丕七丙丞业丙七()
    {
        object val_14;
        var val_70;
        var val_71;
        var val_72;
        System.Collections.Generic.List<PlaceableItemSettings> val_73;
        var val_74;
        var val_75;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        System.Func<PlaceableItemSettings, System.String> val_83;
        var val_84;
        System.Func<PlaceableItemSettings, System.String> val_86;
        var val_87;
        System.Func<PlaceableItemSettings, System.String> val_89;
        var val_90;
        var val_91;
        System.Func<PlaceableItemSettings, System.Single> val_93;
        var val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        var val_101;
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  0, method:  static System.Void 丄丈业一下万且丂丕::东丂丝七丈丟丈专与(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  0, method:  static System.Void 丄丈业一下万且丂丕::东丂丝七丈丟丈专与(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        val_70 = null;
        val_70 = null;
        丄丈业一下万且丂丕.丏东丑上丘不世丟与.Clear();
        丄丈业一下万且丂丕.丁与丁不丒专丙丄业.Clear();
        丄丈业一下万且丂丕.丕丁丐丗东丑下丈丙.Clear();
        val_71 = null;
        val_71 = null;
        丄丈业一下万且丂丕.丁与丁不丒专丙丄业 = PGCompany.丌丂丐丕丑丐丅世丄.业丏丅与与东下丐三(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  76));
        val_72 = null;
        val_72 = null;
        val_73 = 丄丈业一下万且丂丕.丁与丁不丒专丙丄业;
        if(val_73 == null)
        {
            goto label_15;
        }
        
        val_73 = 丄丈业一下万且丂丕.丁与丁不丒专丙丄业;
        if(val_73 == null)
        {
                val_73 = 0;
        }
        
        if(val_73.Count != 0)
        {
            goto label_43;
        }
        
        label_15:
        System.Collections.Generic.List<PlaceableItemSettings> val_9 = new System.Collections.Generic.List<PlaceableItemSettings>();
        val_74 = null;
        val_74 = null;
        丄丈业一下万且丂丕.丁与丁不丒专丙丄业 = val_9;
        List.Enumerator<T> val_12 = System.Linq.Enumerable.ToList<PlaceableItemSettingsSO>(source:  UnityEngine.Resources.LoadAll<PlaceableItemSettingsSO>(path:  "Clans/PlaceableItemSettings_LOCAL")).GetEnumerator();
        label_28:
        if((2088560704 & 1) == 0)
        {
            goto label_23;
        }
        
        val_75 = null;
        val_75 = null;
        val_9.Add(item:  val_14.丐丏七丌丕丗业且上());
        goto label_28;
        label_23:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_43:
        System.Collections.Generic.List<PlaceableItemSettings> val_17 = new System.Collections.Generic.List<PlaceableItemSettings>();
        List.Enumerator<T> val_20 = System.Linq.Enumerable.ToList<PlaceableItemSettingsSO>(source:  UnityEngine.Resources.LoadAll<PlaceableItemSettingsSO>(path:  "Clans/PlaceableItemSettings_LOCAL")).GetEnumerator();
        label_48:
        if((2088560704 & 1) == 0)
        {
            goto label_45;
        }
        
        val_17.Add(item:  val_14.丐丏七丌丕丗业且上());
        goto label_48;
        label_45:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_22 = val_17.GetEnumerator();
        label_66:
        if((2088560672 & 1) == 0)
        {
            goto label_56;
        }
        
        val_77 = null;
        val_77 = null;
        bool val_27 = 丄丈业一下万且丂丕.丕丁丐丗东丑下丈丙.Add(item:  PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  216, 丞一丁业丄一一业且:  PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  val_14.丐丏七丌丕丗业且上())));
        goto label_66;
        label_56:
        val_78 = 0;
        val_79 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (386 == 386))
        {
                val_78 = 0;
        }
        else
        {
                if( != 0)
        {
                val_79 = 0;
        }
        
        }
        
        val_80 = null;
        val_80 = null;
        val_81 = null;
        val_81 = null;
        val_83 = 丄丈业一下万且丂丕.<>c.<>9__12_0;
        if(val_83 == null)
        {
                System.Func<PlaceableItemSettings, System.String> val_28 = null;
            val_83 = val_28;
            val_28 = new System.Func<PlaceableItemSettings, System.String>(object:  丄丈业一下万且丂丕.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丄丈业一下万且丂丕.<>c::丘丗上丆丙丐丆丝丆(PlaceableItemSettings 三丟东丕丄丄下下丑));
            丄丈业一下万且丂丕.<>c.<>9__12_0 = val_83;
        }
        
        val_84 = null;
        val_84 = null;
        val_86 = 丄丈业一下万且丂丕.<>c.<>9__12_1;
        if(val_86 == null)
        {
                System.Func<PlaceableItemSettings, System.String> val_30 = null;
            val_86 = val_30;
            val_30 = new System.Func<PlaceableItemSettings, System.String>(object:  丄丈业一下万且丂丕.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丄丈业一下万且丂丕.<>c::丗丕丅丗丝下丁下丙(PlaceableItemSettings 三丟东丕丄丄下下丑));
            丄丈业一下万且丂丕.<>c.<>9__12_1 = val_86;
        }
        
        val_87 = null;
        val_87 = null;
        val_89 = 丄丈业一下万且丂丕.<>c.<>9__12_2;
        if(val_89 == null)
        {
                System.Func<PlaceableItemSettings, System.String> val_32 = null;
            val_89 = val_32;
            val_32 = new System.Func<PlaceableItemSettings, System.String>(object:  丄丈业一下万且丂丕.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丄丈业一下万且丂丕.<>c::丗东丐丟万与专业且(PlaceableItemSettings 三丟东丕丄丄下下丑));
            丄丈业一下万且丂丕.<>c.<>9__12_2 = val_89;
        }
        
        val_90 = null;
        val_91 = 2088560608;
        val_93 = 丄丈业一下万且丂丕.<>c.<>9__12_3;
        if(val_93 == null)
        {
                System.Func<PlaceableItemSettings, System.Single> val_34 = null;
            val_93 = val_34;
            val_34 = new System.Func<PlaceableItemSettings, System.Single>(object:  丄丈业一下万且丂丕.<>c.__il2cppRuntimeField_static_fields, method:  System.Single 丄丈业一下万且丂丕.<>c::专下上上上丑丈东丁(PlaceableItemSettings 三丟东丕丄丄下下丑));
            丄丈业一下万且丂丕.<>c.<>9__12_3 = val_93;
        }
        
        val_94 = null;
        val_94 = null;
        丄丈业一下万且丂丕.丁与丁不丒专丙丄业 = System.Linq.Enumerable.ToList<PlaceableItemSettings>(source:  System.Linq.Enumerable.ThenBy<PlaceableItemSettings, System.Single>(source:  System.Linq.Enumerable.ThenBy<PlaceableItemSettings, System.String>(source:  System.Linq.Enumerable.ThenBy<PlaceableItemSettings, System.String>(source:  System.Linq.Enumerable.OrderBy<PlaceableItemSettings, System.String>(source:  val_9, keySelector:  val_28), keySelector:  val_30), keySelector:  val_32), keySelector:  val_34));
        List.Enumerator<T> val_37 = 丄丈业一下万且丂丕.丁与丁不丒专丙丄业.GetEnumerator();
        label_156:
        if((2088560672 & 1) == 0)
        {
            goto label_105;
        }
        
        string val_38 = val_14.丐丏七丌丕丗业且上();
        val_95 = null;
        val_95 = null;
        if((丄丈业一下万且丂丕.丏东丑上丘不世丟与.ContainsKey(key:  val_38.SupercategoryName)) != true)
        {
                val_96 = null;
            val_96 = null;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>> val_42 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>>();
            丄丈业一下万且丂丕.丏东丑上丘不世丟与.Add(key:  val_38.SupercategoryName, value:  null);
        }
        
        val_97 = null;
        val_97 = null;
        if((丄丈业一下万且丂丕.丏东丑上丘不世丟与.Item[val_38.SupercategoryName].ContainsKey(key:  val_38.CategoryName)) != true)
        {
                val_98 = null;
            val_98 = null;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>> val_50 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>();
            丄丈业一下万且丂丕.丏东丑上丘不世丟与.Item[val_38.SupercategoryName].Add(key:  val_38.CategoryName, value:  null);
        }
        
        val_99 = null;
        val_99 = null;
        if((丄丈业一下万且丂丕.丏东丑上丘不世丟与.Item[val_38.SupercategoryName].Item[val_38.CategoryName].ContainsKey(key:  val_38.SubcategoryName)) != true)
        {
                val_100 = null;
            val_100 = null;
            System.Collections.Generic.List<PlaceableItemSettings> val_62 = new System.Collections.Generic.List<PlaceableItemSettings>();
            丄丈业一下万且丂丕.丏东丑上丘不世丟与.Item[val_38.SupercategoryName].Item[val_38.CategoryName].Add(key:  val_38.SubcategoryName, value:  null);
        }
        
        val_101 = null;
        val_101 = null;
        string val_67 = val_38.SubcategoryName;
        丄丈业一下万且丂丕.丏东丑上丘不世丟与.Item[val_38.SupercategoryName].Item[val_38.CategoryName].Item[val_67].Add(item:  val_38);
        丄丈业一下万且丂丕.丏丅丁东丛丞丁丂丕.set_Item(key:  val_67, value:  val_38);
        goto label_156;
        label_105:
        mem2[0] = 861;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((0 + 1) != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((val_91 + ((0 + 1)) << 2) == 861)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal static bool 上丑丈丑丁丞丂丙世(string 且三丟七下丂专丈丈)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>>> val_1 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄();
        if(val_1 != null)
        {
                return val_1.ContainsKey(key:  且三丟七下丂专丈丈);
        }
        
        return val_1.ContainsKey(key:  且三丟七下丂专丈丈);
    }
    internal static bool 丑上丁业丁丑丂丑上(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂)
    {
        if((丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().ContainsKey(key:  且三丟七下丂专丈丈)) == false)
        {
                return false;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>> val_4 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[且三丟七下丂专丈丈];
        if(val_4 != null)
        {
                return val_4.ContainsKey(key:  七丆丒与丗丌丄且丂);
        }
        
        return val_4.ContainsKey(key:  七丆丒与丗丌丄且丂);
    }
    internal static bool 丆丝丂上丂世丘丟万(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        if((丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().ContainsKey(key:  且三丟七下丂专丈丈)) == false)
        {
                return false;
        }
        
        if((丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[且三丟七下丂专丈丈].ContainsKey(key:  七丆丒与丗丌丄且丂)) == false)
        {
                return false;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>> val_8 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[且三丟七下丂专丈丈].Item[七丆丒与丗丌丄且丂];
        if(val_8 != null)
        {
                return val_8.ContainsKey(key:  丒丑丞丁世丌专不丈);
        }
        
        return val_8.ContainsKey(key:  丒丑丞丁世丌专不丈);
    }
    internal static System.Collections.Generic.List<string> 丙与世丂一丝丂上丌()
    {
        return System.Linq.Enumerable.ToList<System.String>(source:  丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Keys);
    }
    internal static System.Collections.Generic.List<string> 丈世世三万丝一丕一(string 且三丟七下丂专丈丈)
    {
        string val_8;
        var val_9;
        val_8 = 且三丟七下丂专丈丈;
        System.Collections.Generic.List<System.String> val_1 = null;
        val_9 = val_1;
        val_1 = new System.Collections.Generic.List<System.String>();
        if((丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().ContainsKey(key:  val_8)) == false)
        {
                return (System.Collections.Generic.List<System.String>)val_9;
        }
        
        val_8 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[val_8];
        val_9 = System.Linq.Enumerable.ToList<System.String>(source:  val_8.Keys);
        return (System.Collections.Generic.List<System.String>)val_9;
    }
    internal static System.Collections.Generic.List<string> 丝且丕且丁世不东丒(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂)
    {
        string val_12;
        var val_13;
        val_12 = 七丆丒与丗丌丄且丂;
        System.Collections.Generic.List<System.String> val_1 = null;
        val_13 = val_1;
        val_1 = new System.Collections.Generic.List<System.String>();
        if((丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().ContainsKey(key:  且三丟七下丂专丈丈)) == false)
        {
                return (System.Collections.Generic.List<System.String>)val_13;
        }
        
        if((丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[且三丟七下丂专丈丈].ContainsKey(key:  val_12)) == false)
        {
                return (System.Collections.Generic.List<System.String>)val_13;
        }
        
        val_12 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[且三丟七下丂专丈丈].Item[val_12];
        val_13 = System.Linq.Enumerable.ToList<System.String>(source:  val_12.Keys);
        return (System.Collections.Generic.List<System.String>)val_13;
    }
    internal static System.Collections.Generic.List<PlaceableItemSettings> 丈丄上专丘丆专一不(string 且三丟七下丂专丈丈)
    {
        var val_5;
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.List<PlaceableItemSettings> val_1 = new System.Collections.Generic.List<PlaceableItemSettings>();
        List.Enumerator<T> val_3 = 丄丈业一下万且丂丕.丈世世三万丝一丕一(且三丟七下丂专丈丈:  且三丟七下丂专丈丈).GetEnumerator();
        val_11 = 0;
        val_12 = 0;
        var val_11 = 0;
        label_21:
        if((2089967296 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        List.Enumerator<T> val_8 = 丄丈业一下万且丂丕.丝且丕且丁世不东丒(且三丟七下丂专丈丈:  且三丟七下丂专丈丈, 七丆丒与丗丌丄且丂:  val_6).GetEnumerator();
        label_12:
        if((2089967264 & 1) == 0)
        {
            goto label_8;
        }
        
        val_1.AddRange(collection:  丄丈业一下万且丂丕.丕万上万丒丄丑丛万(且三丟七下丂专丈丈:  且三丟七下丂专丈丈, 七丆丒与丗丌丄且丂:  val_6, 丑三三上丞丄一丞三:  val_5.丐丏七丌丕丗业且上()));
        goto label_12;
        label_8:
        val_11 = val_11 + 1;
        val_13 = val_12;
        mem2[0] = 92;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_11 == 1) || ((2089967216 + ((0 + 1)) << 2) != 92))
        {
            goto label_18;
        }
        
        var val_12 = 0;
        val_12 = val_12 ^ (val_11 >> 31);
        val_11 = val_11 + val_12;
        goto label_21;
        label_18:
        if( == 0)
        {
            goto label_21;
        }
        
        goto label_21;
        label_4:
        val_11 = val_11 + 1;
        mem2[0] = 117;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_11 != 1)
        {
                if( == 0)
        {
                return val_1;
        }
        
            if((2089967216 + ((0 + 1)) << 2) == 117)
        {
                return val_1;
        }
        
            return val_1;
        }
        
        if( != 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    internal static System.Collections.Generic.List<PlaceableItemSettings> 丕万上万丒丄丑丛万(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂, string 丑三三上丞丄一丞三)
    {
        string val_16;
        var val_17;
        var val_18;
        val_16 = 且三丟七下丂专丈丈;
        System.Collections.Generic.List<PlaceableItemSettings> val_1 = null;
        val_17 = val_1;
        val_1 = new System.Collections.Generic.List<PlaceableItemSettings>();
        val_18 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄();
        if((val_18.ContainsKey(key:  val_16)) == false)
        {
                return (System.Collections.Generic.List<PlaceableItemSettings>)val_17;
        }
        
        val_18 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[val_16];
        if((val_18.ContainsKey(key:  七丆丒与丗丌丄且丂)) == false)
        {
                return (System.Collections.Generic.List<PlaceableItemSettings>)val_17;
        }
        
        val_18 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[val_16].Item[七丆丒与丗丌丄且丂];
        if((val_18.ContainsKey(key:  丑三三上丞丄一丞三)) == false)
        {
                return (System.Collections.Generic.List<PlaceableItemSettings>)val_17;
        }
        
        val_16 = 丄丈业一下万且丂丕.丘丐与丏与丒丟东丄().Item[val_16];
        val_17 = System.Linq.Enumerable.ToList<PlaceableItemSettings>(source:  val_16.Item[七丆丒与丗丌丄且丂].Item[丑三三上丞丄一丞三]);
        return (System.Collections.Generic.List<PlaceableItemSettings>)val_17;
    }
    internal static PlaceableItemSettings 丕万上万丒丄丑丛万(string 丞丅上丏丂且下丅与)
    {
        var val_5;
        if((丄丈业一下万且丂丕.丝丁丘上一丄不丙丙().ContainsKey(key:  丞丅上丏丂且下丅与)) != false)
        {
                PlaceableItemSettings val_4 = 丄丈业一下万且丂丕.丝丁丘上一丄不丙丙().Item[丞丅上丏丂且下丅与];
            return (PlaceableItemSettings)val_5;
        }
        
        val_5 = 0;
        return (PlaceableItemSettings)val_5;
    }
    internal static PlaceableItemSettings 丕万上万丒丄丑丛万(int 丞世不丒下上上丝丑)
    {
        .丞世不丒下上上丝丑 = 丞世不丒下上上丝丑;
        System.Collections.Generic.KeyValuePair<System.String, PlaceableItemSettings> val_4 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.String, PlaceableItemSettings>>(source:  丄丈业一下万且丂丕.丝丁丘上一丄不丙丙(), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, PlaceableItemSettings>, System.Boolean>(object:  new 丄丈业一下万且丂丕.丌丐丝丐下上三丛丌(), method:  System.Boolean 丄丈业一下万且丂丕.丌丐丝丐下上三丛丌::且丐丘丕丘专丛丏下(System.Collections.Generic.KeyValuePair<string, PlaceableItemSettings> 三丟东丕丄丄下下丑)));
        return (PlaceableItemSettings);
    }
    internal static string 丂丟丘下与且丐丗丛(string 丆下不丌丄丂与与丄)
    {
        var val_6;
        int val_1 = 丆下不丌丄丂与与丄.IndexOf(value:  "_");
        if((val_1 & 2147483648) != 0)
        {
                return (string)丆下不丌丄丂与与丄;
        }
        
        int val_2 = val_1 + 1;
        if(丆下不丌丄丂与与丄 != null)
        {
                val_6 = 丆下不丌丄丂与与丄.Length;
            return 丆下不丌丄丂与与丄.Substring(startIndex:  val_2, length:  val_6 - val_2);
        }
        
        val_6 = 0.Length;
        return 丆下不丌丄丂与与丄.Substring(startIndex:  val_2, length:  val_6 - val_2);
    }
    internal static int 东专丁丝与丆丗丄丈(PGCompany.三丙业丆上丏三丈丌 丌丐下丆七丒丒丑丕, int 东上业丐丄专七丑业)
    {
        return 丄丈业一下万且丂丕.东专丁丝与丆丗丄丈(与不丕丆丈不丙丟丛:  丌丐下丆七丒丒丑丕.丈丏专三世七丒丘丑(), 东上业丐丄专七丑业:  东上业丐丄专七丑业);
    }
    internal static int 东专丁丝与丆丗丄丈(PlaceableItemSettings 与不丕丆丈不丙丟丛, int 东上业丐丄专七丑业)
    {
        var val_5;
        var val_6;
        if(与不丕丆丈不丙丟丛.IsUpgradable == false)
        {
            goto label_1;
        }
        
        val_5 = 0;
        var val_5 = 1;
        label_5:
        if(val_5 > 与不丕丆丈不丙丟丛.MaxUpgrade)
        {
            goto label_3;
        }
        
        val_5 = (与不丕丆丈不丙丟丛.东上丆丄丘丙七丞丙(丞丌东丟且丒丐丑丂:  1)) + val_5;
        val_5 = val_5 + 1;
        if(val_5 <= 东上业丐丄专七丑业)
        {
            goto label_5;
        }
        
        label_3:
        var val_4 = (val_5 != 0) ? (val_5) : 0;
        return (int)val_6;
        label_1:
        val_6 = 0;
        return (int)val_6;
    }
    private static 丄丈业一下万且丂丕()
    {
        丄丈业一下万且丂丕.丁与丁不丒专丙丄业 = new System.Collections.Generic.List<PlaceableItemSettings>();
        丄丈业一下万且丂丕.丕丁丐丗东丑下丈丙 = new System.Collections.Generic.HashSet<System.Int32>();
        丄丈业一下万且丂丕.丏丅丁东丛丞丁丂丕 = new System.Collections.Generic.Dictionary<System.String, PlaceableItemSettings>();
        丄丈业一下万且丂丕.丏东丑上丘不世丟与 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PlaceableItemSettings>>>>();
    }

}
