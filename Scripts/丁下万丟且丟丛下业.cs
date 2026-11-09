using UnityEngine;
internal class 丁下万丟且丟丛下业
{
    // Fields
    private static GadgetCategory 世丗万丛上且世且七;
    private static System.Collections.Generic.Dictionary<string, 丕丈丏丝丗下丟丅丂> 丟丟万一不业上丐丗;
    private static System.Collections.Generic.Dictionary<GadgetCategory, System.Collections.Generic.Dictionary<string, 丕丈丏丝丗下丟丅丂>> 丗世丙专专丒上丁世;
    private static System.Action<string> 且七不丕丏与东丌丏;
    
    // Properties
    internal static string 丁丏且世万丙丗丌丄 { get; }
    internal static System.Collections.Generic.Dictionary<string, 丕丈丏丝丗下丟丅丂> 东一丁世丑丞业丄丐 { get; }
    internal static GadgetCategory 丟业丞且丅丞三一丏 { get; set; }
    
    // Methods
    internal static string 丅且不丕丒万丕丘且()
    {
        return "࿐";
    }
    internal static System.Collections.Generic.Dictionary<string, 丕丈丏丝丗下丟丅丂> 一三专丞丒丅上业上()
    {
        null = null;
        return (System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂>)丁下万丟且丟丛下业.丟丟万一不业上丐丗;
    }
    internal static 丆丘丞不丒七丆与不 万丟与与丆丟丗丏丗(string 丞一丁业丄一一业且)
    {
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        val_16 = 丞一丁业丄一一业且;
        丕丈丏丝丗下丟丅丂 val_3 = 0;
        PGCompany.丟丁且丝丁三丏丙且 val_9 = 0;
        if(val_16 == null)
        {
            goto label_18;
        }
        
        val_17 = null;
        val_17 = null;
        if((val_16.StartsWith(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) != false)
        {
                val_18 = 2;
            return (丆丘丞不丒七丆与不)val_18;
        }
        
        bool val_4 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  val_16, value: out  val_3);
        if(val_3 == 0)
        {
            goto label_18;
        }
        
        val_18 = 0;
        if((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  val_16, 丝丒上丑一三丑丐丛:  false)) == true)
        {
                return (丆丘丞不丒七丆与不)val_18;
        }
        
        val_16 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆();
        bool val_10 = val_16.TryGetValue(下上丐丆丝丟丝丒不:  val_3.业东丅东丌上丗丑不(), 丙业与丙丗丝不丈东: out  val_9);
        if(val_9 == 0)
        {
            goto label_18;
        }
        
        丞丂丘丒丟丞丑下丄 val_12 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_12 == null)
        {
            goto label_20;
        }
        
        val_19 = val_12.世丝丌一且丝专丑丛();
        goto label_21;
        label_18:
        val_18 = 0;
        return (丆丘丞不丒七丆与不)val_18;
        label_20:
        val_19 = 0;
        label_21:
        var val_15 = (val_19 < val_9.世丝丌一且丝专丑丛()) ? (1 + 1) : 1;
        return (丆丘丞不丒七丆与不)val_18;
    }
    internal static bool 丈丛下丗丆丐丞丟丟(string 丕丁下丌不万丅丞丛)
    {
        if(丕丁下丌不万丅丞丛 == null)
        {
                return false;
        }
        
        丕丈丏丝丗下丟丅丂 val_1 = 丁下万丟且丟丛下业.丛丝与一丕丆丌丟丏(丗丑丐丕丟丝且下丕:  丕丁下丌不万丅丞丛);
        if(val_1 == null)
        {
                return false;
        }
        
        PGCompany.且丟一七万东丁三上<PGCompany.丟丁且丝丁三丏丙且> val_4 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆();
        if(val_4 != null)
        {
                return val_4.ContainsKey(下上丐丆丝丟丝丒不:  val_1.业东丅东丌上丗丑不());
        }
        
        return val_4.ContainsKey(下上丐丆丝丟丝丒不:  val_1.业东丅东丌上丗丑不());
    }
    internal static bool 上丏丘不业丅七丝丂(string 丞一丁业丄一一业且)
    {
        丕丈丏丝丗下丟丅丂 val_3 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞一丁业丄一一业且)) != false)
        {
                return false;
        }
        
        if(val_3 == 0)
        {
                return false;
        }
        
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  丞一丁业丄一一业且, value: out  val_3)) == false)
        {
                return false;
        }
        
        if((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  丞一丁业丄一一业且, 丝丒上丑一三丑丐丛:  false)) == true)
        {
                return false;
        }
        
        var val_8 = (val_3.丈丒丟下丂丒东与丑() > ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
        return false;
    }
    internal static int 一丗上丄丆丞三东业(string 丞丅上丏丂且下丅与)
    {
        string val_7;
        var val_8;
        val_7 = 丞丅上丏丂且下丅与;
        丕丈丏丝丗下丟丅丂 val_3 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) != true)
        {
                bool val_4 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  val_7, value: out  val_3);
            val_8 = val_3;
            if(val_8 != 0)
        {
                int val_5 = val_8.业东丅东丌上丗丑不();
            return (int)val_8;
        }
        
            val_7 = "No gdget with id: "("No gdget with id: ") + val_7;
            UnityEngine.Debug.LogError(message:  val_7);
        }
        
        val_8 = 0;
        return (int)val_8;
    }
    internal static 丕丈丏丝丗下丟丅丂 丛丝与一丕丆丌丟丏(string 丗丑丐丕丟丝且下丕)
    {
        var val_5;
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  丗丑丐丕丟丝且下丕)) != false)
        {
                丕丈丏丝丗下丟丅丂 val_4 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丑丐丕丟丝且下丕];
            return (丕丈丏丝丗下丟丅丂)val_5;
        }
        
        val_5 = 0;
        return (丕丈丏丝丗下丟丅丂)val_5;
    }
    internal static 丕丈丏丝丗下丟丅丂 丝丏丁一不且三丏丙(string 丗丑丐丕丟丝且下丕)
    {
        .丗丑丐丕丟丝且下丕 = 丗丑丐丕丟丝且下丕;
        System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上(), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.Boolean>(object:  new 丁下万丟且丟丛下业.丒丛丁与丅东丒不七(), method:  System.Boolean 丁下万丟且丟丛下业.丒丛丁与丅东丒不七::丘世世一专下一东丙(System.Collections.Generic.KeyValuePair<string, 丕丈丏丝丗下丟丅丂> 三丟东丕丄丄下下丑)));
        return (丕丈丏丝丗下丟丅丂);
    }
    internal static string 丌丂丌丟丑丁丌与丟(int 丞世不丒下上上丝丑)
    {
        int val_8;
        var val_9;
        val_8 = 丞世不丒下上上丝丑;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Values.GetEnumerator();
        label_7:
        if(((-1569854040) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        if((val_4 == null) || (val_4.业东丅东丌上丗丑不() != val_8))
        {
            goto label_7;
        }
        
        val_9 = val_4.业上丙丞丐丄丆丅七();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (string)val_9;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_8 != 1)
        {
                val_8 = "No gadget with index: "("No gadget with index: ") + val_8;
            UnityEngine.Debug.LogError(message:  val_8);
        }
        
        val_9 = 0;
        return (string)val_9;
    }
    internal static GadgetCategory 下丁丗丁丅下丆丂丌()
    {
        GadgetCategory val_2;
        var val_3;
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_2 = 12500;
            return val_2;
        }
        
        val_3 = null;
        val_3 = null;
        val_2 = 丁下万丟且丟丛下业.世丗万丛上且世且七;
        return val_2;
    }
    internal static void 丛丁七业东上世丅丛(GadgetCategory 丙业与丙丗丝不丈东)
    {
        null = null;
        丁下万丟且丟丛下业.世丗万丛上且世且七 = 丙业与丙丗丝不丈东;
    }
    internal static void 丑丝上专丒丂丒丟丄(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  丁下万丟且丟丛下业.且七不丕丏与东丌丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(丁下万丟且丟丛下业.且七不丕丏与东丌丏 != 1152921505185071128);
    
    }
    internal static void 东上丐丆丌下上丟上(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  丁下万丟且丟丛下业.且七不丕丏与东丌丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(丁下万丟且丟丛下业.且七不丕丏与东丌丏 != 1152921505185071128);
    
    }
    internal static UnityEngine.GameObject 丟不与不丞丛丒丅万(string 丞丅上丏丂且下丅与)
    {
        UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "GadgetsContent/GadgetsArmoryInfoPreview/"("GadgetsContent/GadgetsArmoryInfoPreview/") + 丞丅上丏丂且下丅与);
        if(val_2 != 0)
        {
                return val_2;
        }
        
        return UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "GadgetsContent/GadgetsArmoryInfoPreview/empty");
    }
    internal static bool 东丞丄丌丙丟丘世丈(string 丗丑丐丕丟丝且下丕, bool 丝丒上丑一三丑丐丛 = True)
    {
        if(丗丑丐丕丟丝且下丕 != null)
        {
                Progress.下业丅丑丌丝丒丅丛 val_1 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒();
            if(val_1 != null)
        {
                return val_1.丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕);
        }
        
            return val_1.丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕);
        }
        
        UnityEngine.Debug.LogError(message:  "IsB_ought gadg_etId == null");
        return false;
    }
    internal static System.Collections.Generic.Dictionary<GadgetCategory, System.Collections.Generic.List<string>> 丂且丁丘丕丂丗丌不(System.Collections.Generic.List<string> 丑七不与丛丆一丂丞)
    {
        var val_11;
        System.Func<System.String, 丕丈丏丝丗下丟丅丂> val_13;
        var val_14;
        System.Func<丕丈丏丝丗下丟丅丂, GadgetCategory> val_16;
        var val_17;
        System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, GadgetCategory> val_19;
        System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, System.Collections.Generic.List<System.String>> val_21;
        val_11 = null;
        val_11 = null;
        val_13 = 丁下万丟且丟丛下业.<>c.<>9__22_0;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Func<System.String, 丕丈丏丝丗下丟丅丂>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  丕丈丏丝丗下丟丅丂 丁下万丟且丟丛下业.<>c::丘丙丗与且丑上丞不(string 丗丑丐丕丟丝且下丕));
            丁下万丟且丟丛下业.<>c.<>9__22_0 = val_13;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = 丁下万丟且丟丛下业.<>c.<>9__22_1;
        if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<丕丈丏丝丗下丟丅丂, GadgetCategory>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  GadgetCategory 丁下万丟且丟丛下业.<>c::丕丄丒丄与丂丘七丒(丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝));
            丁下万丟且丟丛下业.<>c.<>9__22_1 = val_16;
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = 丁下万丟且丟丛下业.<>c.<>9__22_2;
        if(val_19 == null)
        {
                val_19 = null;
            val_19 = new System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, GadgetCategory>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  GadgetCategory 丁下万丟且丟丛下业.<>c::上丕丗上丁丅丈三丐(System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂> 不一丅丛一丈且丕丆));
            val_17 = null;
            丁下万丟且丟丛下业.<>c.<>9__22_2 = val_19;
        }
        
        val_17 = null;
        val_21 = 丁下万丟且丟丛下业.<>c.<>9__22_3;
        if(val_21 != null)
        {
                return (System.Collections.Generic.Dictionary<GadgetCategory, System.Collections.Generic.List<System.String>>)System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, GadgetCategory, System.Collections.Generic.List<System.String>>(source:  System.Linq.Enumerable.GroupBy<丕丈丏丝丗下丟丅丂, GadgetCategory>(source:  System.Linq.Enumerable.Select<System.String, 丕丈丏丝丗下丟丅丂>(source:  System.Linq.Enumerable.Intersect<System.String>(first:  丑七不与丛丆一丂丞, second:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Keys), selector:  null), keySelector:  null), keySelector:  null, elementSelector:  null);
        }
        
        val_21 = null;
        val_21 = new System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, System.Collections.Generic.List<System.String>>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.List<System.String> 丁下万丟且丟丛下业.<>c::丁丕丏丗丌世丑丏丒(System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂> 不一丅丛一丈且丕丆));
        丁下万丟且丟丛下业.<>c.<>9__22_3 = val_21;
        return (System.Collections.Generic.Dictionary<GadgetCategory, System.Collections.Generic.List<System.String>>)System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, GadgetCategory, System.Collections.Generic.List<System.String>>(source:  System.Linq.Enumerable.GroupBy<丕丈丏丝丗下丟丅丂, GadgetCategory>(source:  System.Linq.Enumerable.Select<System.String, 丕丈丏丝丗下丟丅丂>(source:  System.Linq.Enumerable.Intersect<System.String>(first:  丑七不与丛丆一丂丞, second:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Keys), selector:  null), keySelector:  null), keySelector:  null, elementSelector:  null);
    }
    internal static System.Collections.Generic.List<string> 丑丐丝丕不丒丛丗丌(int 业万上丆丐丞且丒七)
    {
        System.Func<丕丈丏丝丗下丟丅丂, System.Boolean> val_9;
        var val_10;
        System.Func<丕丈丏丝丗下丟丅丂, System.String> val_12;
        .业万上丆丐丞且丒七 = 业万上丆丐丞且丒七;
        val_9 = null;
        val_9 = new System.Func<丕丈丏丝丗下丟丅丂, System.Boolean>(object:  new 丁下万丟且丟丛下业.上三且上丁业与与丑(), method:  System.Boolean 丁下万丟且丟丛下业.上三且上丁业与与丑::丑东丄丛上不世业与(丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝));
        val_10 = null;
        val_10 = null;
        val_12 = 丁下万丟且丟丛下业.<>c.<>9__23_1;
        if(val_12 != null)
        {
                return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丕丈丏丝丗下丟丅丂, System.String>(source:  System.Linq.Enumerable.Where<丕丈丏丝丗下丟丅丂>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Values, predicate:  null), selector:  null));
        }
        
        val_12 = null;
        val_12 = new System.Func<丕丈丏丝丗下丟丅丂, System.String>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丁下万丟且丟丛下业.<>c::丈丈东丞且丞三丙东(丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝));
        丁下万丟且丟丛下业.<>c.<>9__23_1 = val_12;
        return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丕丈丏丝丗下丟丅丂, System.String>(source:  System.Linq.Enumerable.Where<丕丈丏丝丗下丟丅丂>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Values, predicate:  null), selector:  null));
    }
    internal static System.Collections.Generic.Dictionary<string, 丕丈丏丝丗下丟丅丂> 丂上丙丞丂世且丘且(GadgetCategory 七丆丒与丗丌丄且丂)
    {
        var val_19;
        var val_20;
        GadgetCategory val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.String> val_29;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, 丕丈丏丝丗下丟丅丂> val_31;
        var val_32;
        var val_33;
        var val_35;
        val_19 = null;
        val_19 = null;
        if(丁下万丟且丟丛下业.丗世丙专专丒上丁世 != null)
        {
            goto label_65;
        }
        
        System.Collections.Generic.Dictionary<GadgetCategory, System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂>> val_2 = new System.Collections.Generic.Dictionary<GadgetCategory, System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂>>(comparer:  丘业丝世丐不丗丆东.丑七不且上丗丁一世());
        val_20 = null;
        val_20 = null;
        丁下万丟且丟丛下业.丗世丙专专丒上丁世 = val_2;
        var val_22 = 0;
        val_22 = val_22 + 1;
        System.Collections.Generic.IEnumerator<T> val_7 = System.Linq.Enumerable.OfType<GadgetCategory>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))).GetEnumerator();
        label_42:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_7.MoveNext() == false)
        {
            goto label_22;
        }
        
        new 丁下万丟且丟丛下业.丛东丟丅丙丗世丗不() = new System.Object();
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_24 = val_7.Current;
        .丗且世丆上丏专与丐 = val_24;
        val_25 = null;
        val_25 = null;
        val_24 = (丁下万丟且丟丛下业.丛东丟丅丙丗世丗不)[1152921537398152560].丗且世丆上丏专与丐;
        val_26 = public System.Void System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.Boolean>::.ctor(object object, IntPtr method);
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.Boolean> val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.Boolean>(object:  new 丁下万丟且丟丛下业.丛东丟丅丙丗世丗不(), method:  System.Boolean 丁下万丟且丟丛下业.丛东丟丅丙丗世丗不::丐不与三一丝东世丁(System.Collections.Generic.KeyValuePair<string, 丕丈丏丝丗下丟丅丂> 丈丏万丄丒业丅丒一));
        val_27 = null;
        val_27 = null;
        val_29 = 丁下万丟且丟丛下业.<>c.<>9__24_1;
        if(val_29 == null)
        {
                val_29 = null;
            val_26 = public System.Void System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.String>::.ctor(object object, IntPtr method);
            val_29 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, System.String>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丁下万丟且丟丛下业.<>c::丛七下丆丐下业丗丐(System.Collections.Generic.KeyValuePair<string, 丕丈丏丝丗下丟丅丂> 丈丏万丄丒业丅丒一));
            val_27 = null;
            丁下万丟且丟丛下业.<>c.<>9__24_1 = val_29;
        }
        
        val_27 = null;
        val_31 = 丁下万丟且丟丛下业.<>c.<>9__24_2;
        if(val_31 == null)
        {
                val_31 = null;
            val_26 = public System.Void System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, 丕丈丏丝丗下丟丅丂>::.ctor(object object, IntPtr method);
            val_31 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>, 丕丈丏丝丗下丟丅丂>(object:  丁下万丟且丟丛下业.<>c.__il2cppRuntimeField_static_fields, method:  丕丈丏丝丗下丟丅丂 丁下万丟且丟丛下业.<>c::且业七丙万东不丌万(System.Collections.Generic.KeyValuePair<string, 丕丈丏丝丗下丟丅丂> 丈丏万丄丒业丅丒一));
            丁下万丟且丟丛下业.<>c.<>9__24_2 = val_31;
        }
        
        val_2.set_Item(key:  val_24, value:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, 丕丈丏丝丗下丟丅丂>>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上(), predicate:  null));
        goto label_42;
        label_22:
        val_32 = 0;
        val_33 = 0;
        if(val_7 == null)
        {
            
        }
        else
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_7.Dispose();
        }
        
        label_65:
        val_35 = null;
        System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂> val_19 = 0;
        val_35 = null;
        return (System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂>)((val_2.TryGetValue(key:  七丆丒与丗丌丄且丂, value: out  val_19)) != true) ? (val_19) : 0;
    }
    internal static System.Collections.Generic.IEnumerable<string> 丁丐丄丝不丅丗丄与(int 丞丁丏且与丒丐业下)
    {
        .丞丁丏且与丒丐业下 = 丞丁丏且与丒丐业下;
        System.Func<System.String, System.Boolean> val_4 = new System.Func<System.String, System.Boolean>(object:  new 丁下万丟且丟丛下业.丄丆丌丌丕丈丆丆业(), method:  System.Boolean 丁下万丟且丟丛下业.丄丆丌丌丕丈丆丆业::丑万丒七丑丑万丂丒(string 三丟东丕丄丄下下丑));
        return (System.Collections.Generic.IEnumerable<System.String>)System.Linq.Enumerable.Where<System.String>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Keys, predicate:  null);
    }
    internal static void 丅丕丆丒丒业丑世东(string 丗丑丐丕丟丝且下丕, int 丈丘丝一丗下丈丐不)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  7);
        if(丗丑丐丕丟丝且下丕 == null)
        {
            goto label_4;
        }
        
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  丗丑丐丕丟丝且下丕, value: out  0)) == false)
        {
            goto label_8;
        }
        
        if((Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_3.业东丅东丌上丗丑不())) >= 丈丘丝一丗下丈丐不)
        {
            goto label_50;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().不万一业三丟七丏世(丞世不丒下上上丝丑:  val_3.业东丅东丌上丗丑不(), 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 世丁丙世丄一万丆三:  "");
        丁下万丟且丟丛下业.丘丑丅丁一丈丐下且(丞丅上丏丂且下丅与:  val_3.业上丙丞丐丄丆丅七());
        goto label_50;
        label_4:
        UnityEngine.Debug.LogError(message:  "Provid_eGadget gadget_Id == null");
        goto label_50;
        label_8:
        UnityEngine.Debug.LogError(message:  "Provid_eGadget !info.Conta_insKey(gadgetId)");
        label_50:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(142 == 142)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    internal static void 丘丑丅丁一丈丐下且(string 丞丅上丏丂且下丅与)
    {
        null = null;
        if(丁下万丟且丟丛下业.且七不丕丏与东丌丏 == null)
        {
                return;
        }
        
        丁下万丟且丟丛下业.且七不丕丏与东丌丏.Invoke(obj:  丞丅上丏丂且下丅与);
    }
    internal static string 与丞丑丙上丙丅丈丑(GadgetCategory 七丆丒与丗丌丄且丂, FilterMaps 专丆丌丛东一不丑丙)
    {
        Progress.丏丘丄丆丂丆丛丐丝 val_2 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
        if(val_2 != null)
        {
                return val_2.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  1, 下上丐丆丝丟丝丒不:  丐七不丄业丟丙丄一.丟丄三丛丆丏丗世丏(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙));
        }
        
        return val_2.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  1, 下上丐丆丝丟丝丒不:  丐七不丄业丟丙丄一.丟丄三丛丆丏丗世丏(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙));
    }
    internal static string 丆丏丒丆万丄且丗丛(string 丗丑丐丕丟丝且下丕)
    {
        var val_3;
        if(丗丑丐丕丟丝且下丕 != null)
        {
                var val_2 = ((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  丗丑丐丕丟丝且下丕, 丝丒上丑一三丑丐丛:  false)) != true) ? 丗丑丐丕丟丝且下丕 : 0;
            return (string)val_3;
        }
        
        UnityEngine.Debug.LogError(message:  "LastBou_ghtFor gadg_etId == null");
        val_3 = 0;
        return (string)val_3;
    }
    private static 丁下万丟且丟丛下业()
    {
        丁下万丟且丟丛下业.世丗万丛上且世且七 = 12500;
        丁下万丟且丟丛下业.丟丟万一不业上丐丗 = new System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂>();
        丁下万丟且丟丛下业.丗世丙专专丒上丁世 = 0;
        丁下万丟且丟丛下业.且七不丕丏与东丌丏 = 0;
        System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂> val_2 = new System.Collections.Generic.Dictionary<System.String, 丕丈丏丝丗下丟丅丂>();
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_3 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_3 != null)
        {
                val_3.Add(item:  16);
            val_3.Add(item:  4);
            val_3.Add(item:  3);
        }
        else
        {
                val_3.Add(item:  16);
            val_3.Add(item:  4);
            val_3.Add(item:  3);
        }
        
        val_3.Add(item:  1);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_4 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_4 != null)
        {
                val_4.Add(item:  52);
        }
        else
        {
                val_4.Add(item:  52);
        }
        
        val_4.Add(item:  41);
        val_2.Add(key:  "gadget_armor_regeneration", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_armor_regeneration", 业东丘与与业丏丛丈:  "Key_8868", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8880", 丞世不丒下上上丝丑:  36007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_3, 丌丞丌丌丈丁丏丅丟:  val_4, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_6 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_6 != null)
        {
                val_6.Add(item:  16);
            val_6.Add(item:  0);
            val_6.Add(item:  3);
        }
        else
        {
                val_6.Add(item:  16);
            val_6.Add(item:  0);
            val_6.Add(item:  3);
        }
        
        val_6.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_7 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_7 != null)
        {
                val_7.Add(item:  80);
        }
        else
        {
                val_7.Add(item:  80);
        }
        
        val_7.Add(item:  19);
        val_2.Add(key:  "gadget_astral", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_astral", 业东丘与与业丏丛丈:  "Key_8861", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8993", 丞世不丒下上上丝丑:  42007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_6, 丌丞丌丌丈丁丏丅丟:  val_7, 业万丅丆上丈一世丄:  78, 丏丟丛世丄七丌业三:  "Explosion54", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_9 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_9 != null)
        {
                val_9.Add(item:  16);
            val_9.Add(item:  1);
            val_9.Add(item:  3);
        }
        else
        {
                val_9.Add(item:  16);
            val_9.Add(item:  1);
            val_9.Add(item:  3);
        }
        
        val_9.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_10 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_10 != null)
        {
                val_10.Add(item:  23);
        }
        else
        {
                val_10.Add(item:  23);
        }
        
        val_10.Add(item:  41);
        val_2.Add(key:  "gadget_bionic_shield", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_bionic_shield", 业东丘与与业丏丛丈:  "Key_8871", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8883", 丞世不丒下上上丝丑:  47007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_9, 丌丞丌丌丈丁丏丅丟:  val_10, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion80", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  784, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_12 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_12 != null)
        {
                val_12.Add(item:  4);
        }
        else
        {
                val_12.Add(item:  4);
        }
        
        val_12.Add(item:  3);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_13 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_13 != null)
        {
                val_13.Add(item:  3);
        }
        else
        {
                val_13.Add(item:  3);
        }
        
        val_13.Add(item:  10);
        val_2.Add(key:  "gadget_black_label", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_black_label", 业东丘与与业丏丛丈:  "Key_2515", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2583", 丞世不丒下上上丝丑:  1007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_12, 丌丞丌丌丈丁丏丅丟:  val_13, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "black_label_explosion", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  72, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_15 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_15 != null)
        {
                val_15.Add(item:  0);
            val_15.Add(item:  3);
        }
        else
        {
                val_15.Add(item:  0);
            val_15.Add(item:  3);
        }
        
        val_15.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_16 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_16 != null)
        {
                val_16.Add(item:  10);
        }
        else
        {
                val_16.Add(item:  10);
        }
        
        val_16.Add(item:  19);
        val_2.Add(key:  "gadget_Blizzard_generator", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_Blizzard_generator", 业东丘与与业丏丛丈:  "Key_2512", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2581", 丞世不丒下上上丝丑:  2007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_15, 丌丞丌丌丈丁丏丅丟:  val_16, 业万丅丆上丈一世丄:  82, 丏丟丛世丄七丌业三:  "Weapon123", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  71, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_18 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_18 != null)
        {
                val_18.Add(item:  0);
            val_18.Add(item:  1);
            val_18.Add(item:  3);
        }
        else
        {
                val_18.Add(item:  0);
            val_18.Add(item:  1);
            val_18.Add(item:  3);
        }
        
        val_18.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_19 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_19 != null)
        {
                val_19.Add(item:  0);
        }
        else
        {
                val_19.Add(item:  0);
        }
        
        val_19.Add(item:  10);
        val_2.Add(key:  "gadget_christmastreeturret", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_christmastreeturret", 业东丘与与业丏丛丈:  "Key_2747", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2738", 丞世不丒下上上丝丑:  3007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_18, 丌丞丌丌丈丁丏丅丟:  val_19, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_21 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_21 != null)
        {
                val_21.Add(item:  16);
            val_21.Add(item:  0);
        }
        else
        {
                val_21.Add(item:  16);
            val_21.Add(item:  0);
        }
        
        val_21.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_22 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_22 != null)
        {
                val_22.Add(item:  10);
        }
        else
        {
                val_22.Add(item:  10);
        }
        
        val_22.Add(item:  42);
        val_2.Add(key:  "gadget_combat_spinner", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_combat_spinner", 业东丘与与业丏丛丈:  "Key_8862", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8874", 丞世不丒下上上丝丑:  43007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_21, 丌丞丌丌丈丁丏丅丟:  val_22, 业万丅丆上丈一世丄:  78, 丏丟丛世丄七丌业三:  "gadget_combat_spinner", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  140, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_24 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_24 != null)
        {
                val_24.Add(item:  16);
        }
        else
        {
                val_24.Add(item:  16);
        }
        
        val_24.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_25 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_25 != null)
        {
                val_25.Add(item:  25);
        }
        else
        {
                val_25.Add(item:  25);
        }
        
        val_25.Add(item:  10);
        val_2.Add(key:  "gadget_cyber_bees", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_cyber_bees", 业东丘与与业丏丛丈:  "Key_8865", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8877", 丞世不丒下上上丝丑:  40007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_24, 丌丞丌丌丈丁丏丅丟:  val_25, 业万丅丆上丈一世丄:  81, 丏丟丛世丄七丌业三:  "Explosion52", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  278, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  1.2f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_27 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_27 != null)
        {
                val_27.Add(item:  0);
            val_27.Add(item:  1);
            val_27.Add(item:  3);
        }
        else
        {
                val_27.Add(item:  0);
            val_27.Add(item:  1);
            val_27.Add(item:  3);
        }
        
        val_27.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_28 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_28 != null)
        {
                val_28.Add(item:  55);
        }
        else
        {
                val_28.Add(item:  55);
        }
        
        val_28.Add(item:  10);
        val_2.Add(key:  "gadget_cybersamurai", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_cybersamurai", 业东丘与与业丏丛丈:  "Key_5000", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_4983", 丞世不丒下上上丝丑:  4007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_27, 丌丞丌丌丈丁丏丅丟:  val_28, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_30 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_30 != null)
        {
                val_30.Add(item:  0);
            val_30.Add(item:  1);
            val_30.Add(item:  3);
        }
        else
        {
                val_30.Add(item:  0);
            val_30.Add(item:  1);
            val_30.Add(item:  3);
        }
        
        val_30.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_31 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_31 != null)
        {
                val_31.Add(item:  31);
        }
        else
        {
                val_31.Add(item:  31);
        }
        
        val_31.Add(item:  39);
        val_2.Add(key:  "gadget_demon_stone", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_demon_stone", 业东丘与与业丏丛丈:  "Key_2524", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2580", 丞世不丒下上上丝丑:  5007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_30, 丌丞丌丌丈丁丏丅丟:  val_31, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_33 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_33 != null)
        {
                val_33.Add(item:  16);
            val_33.Add(item:  3);
        }
        else
        {
                val_33.Add(item:  16);
            val_33.Add(item:  3);
        }
        
        val_33.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_34 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_34.Add(item:  79);
        val_2.Add(key:  "gadget_denied", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_denied", 业东丘与与业丏丛丈:  "Key_8864", 丗丈一丟丈万丅丞东:  6, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8876", 丞世不丒下上上丝丑:  46007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_33, 丌丞丌丌丈丁丏丅丟:  val_34, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion54", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_36 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_36 != null)
        {
                val_36.Add(item:  4);
        }
        else
        {
                val_36.Add(item:  4);
        }
        
        val_36.Add(item:  3);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_37 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_37 != null)
        {
                val_37.Add(item:  40);
        }
        else
        {
                val_37.Add(item:  40);
        }
        
        val_37.Add(item:  41);
        val_2.Add(key:  "gadget_disabler", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_disabler", 业东丘与与业丏丛丈:  "Key_2526", 丗丈一丟丈万丅丞东:  6, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2582", 丞世不丒下上上丝丑:  6007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_36, 丌丞丌丌丈丁丏丅丟:  val_37, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion47", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  1, 且丘丈丁丗万万不丙:  1, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_39 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_39 != null)
        {
                val_39.Add(item:  0);
            val_39.Add(item:  3);
        }
        else
        {
                val_39.Add(item:  0);
            val_39.Add(item:  3);
        }
        
        val_39.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_40 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_40 != null)
        {
                val_40.Add(item:  10);
        }
        else
        {
                val_40.Add(item:  10);
        }
        
        val_40.Add(item:  36);
        val_2.Add(key:  "gadget_dragonwhistle", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_dragonwhistle", 业东丘与与业丏丛丈:  "Key_2525", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2585", 丞世不丒下上上丝丑:  7007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_39, 丌丞丌丌丈丁丏丅丟:  val_40, 业万丅丆上丈一世丄:  85, 丏丟丛世丄七丌业三:  "Weapon75", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  69, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_42 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_42 != null)
        {
                val_42.Add(item:  4);
            val_42.Add(item:  3);
        }
        else
        {
                val_42.Add(item:  4);
            val_42.Add(item:  3);
        }
        
        val_42.Add(item:  0);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_43 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_43 != null)
        {
                val_43.Add(item:  13);
        }
        else
        {
                val_43.Add(item:  13);
        }
        
        val_43.Add(item:  10);
        val_2.Add(key:  "gadget_fakebonus", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_fakebonus", 业东丘与与业丏丛丈:  "Key_2527", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2567", 丞世不丒下上上丝丑:  8007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_42, 丌丞丌丌丈丁丏丅丟:  val_43, 业万丅丆上丈一世丄:  83, 丏丟丛世丄七丌业三:  "Explosion48", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  67, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_45 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_45 != null)
        {
                val_45.Add(item:  16);
            val_45.Add(item:  0);
            val_45.Add(item:  3);
        }
        else
        {
                val_45.Add(item:  16);
            val_45.Add(item:  0);
            val_45.Add(item:  3);
        }
        
        val_45.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_46 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_46 != null)
        {
                val_46.Add(item:  13);
        }
        else
        {
                val_46.Add(item:  13);
        }
        
        val_46.Add(item:  10);
        val_2.Add(key:  "gadget_firecrackers", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_firecrackers", 业东丘与与业丏丛丈:  "Key_2908", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2957", 丞世不丒下上上丝丑:  9007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_45, 丌丞丌丌丈丁丏丅丟:  val_46, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion_gadget_firework", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  80, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  1f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_48 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_48 != null)
        {
                val_48.Add(item:  0);
            val_48.Add(item:  3);
        }
        else
        {
                val_48.Add(item:  0);
            val_48.Add(item:  3);
        }
        
        val_48.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_49 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_49 != null)
        {
                val_49.Add(item:  10);
        }
        else
        {
                val_49.Add(item:  10);
        }
        
        val_49.Add(item:  36);
        val_2.Add(key:  "gadget_firemushroom", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_firemushroom", 业东丘与与业丏丛丈:  "Key_2514", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2586", 丞世不丒下上上丝丑:  10007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_48, 丌丞丌丌丈丁丏丅丟:  val_49, 业万丅丆上丈一世丄:  84, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_51 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_51 != null)
        {
                val_51.Add(item:  0);
            val_51.Add(item:  3);
        }
        else
        {
                val_51.Add(item:  0);
            val_51.Add(item:  3);
        }
        
        val_51.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_52 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_52 != null)
        {
                val_52.Add(item:  13);
        }
        else
        {
                val_52.Add(item:  13);
        }
        
        val_52.Add(item:  10);
        val_2.Add(key:  "gadget_firework", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_firework", 业东丘与与业丏丛丈:  "Key_2743", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2736", 丞世不丒下上上丝丑:  11007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_51, 丌丞丌丌丈丁丏丅丟:  val_52, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion_gadget_firework", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  74, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  1f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_54 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_54 != null)
        {
                val_54.Add(item:  0);
        }
        else
        {
                val_54.Add(item:  0);
        }
        
        val_54.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_55 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_55.Add(item:  10);
        val_2.Add(key:  "gadget_fraggrenade", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_fraggrenade", 业东丘与与业丏丛丈:  "Key_2480", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2538", 丞世不丒下上上丝丑:  12007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_54, 丌丞丌丌丈丁丏丅丟:  val_55, 业万丅丆上丈一世丄:  60, 丏丟丛世丄七丌业三:  "WeaponGrenade", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  10, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_57 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_57 != null)
        {
                val_57.Add(item:  16);
            val_57.Add(item:  0);
            val_57.Add(item:  3);
        }
        else
        {
                val_57.Add(item:  16);
            val_57.Add(item:  0);
            val_57.Add(item:  3);
        }
        
        val_57.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_58 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_58.Add(item:  4);
        val_2.Add(key:  "gadget_guardian", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_guardian", 业东丘与与业丏丛丈:  "Key_1277", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_4048", 丞世不丒下上上丝丑:  13007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_57, 丌丞丌丌丈丁丏丅丟:  val_58, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Weapon123", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  71, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_60 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_60 != null)
        {
                val_60.Add(item:  4);
            val_60.Add(item:  3);
        }
        else
        {
                val_60.Add(item:  4);
            val_60.Add(item:  3);
        }
        
        val_60.Add(item:  0);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_61 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_61.Add(item:  78);
        val_2.Add(key:  "gadget_hologram_projector", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_hologram_projector", 业东丘与与业丏丛丈:  "Key_8872", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8884", 丞世不丒下上上丝丑:  41007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_60, 丌丞丌丌丈丁丏丅丟:  val_61, 业万丅丆上丈一世丄:  81, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_63 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_63 != null)
        {
                val_63.Add(item:  3);
        }
        else
        {
                val_63.Add(item:  3);
        }
        
        val_63.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_64 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_64.Add(item:  31);
        val_2.Add(key:  "gadget_jetpack", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_jetpack", 业东丘与与业丏丛丈:  "Key_0772", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2572", 丞世不丒下上上丝丑:  14007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_63, 丌丞丌丌丈丁丏丅丟:  val_64, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_66 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_66 != null)
        {
                val_66.Add(item:  3);
        }
        else
        {
                val_66.Add(item:  3);
        }
        
        val_66.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_67 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_67 != null)
        {
                val_67.Add(item:  44);
        }
        else
        {
                val_67.Add(item:  44);
        }
        
        val_67.Add(item:  41);
        val_2.Add(key:  "gadget_leaderdrum", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_leaderdrum", 业东丘与与业丏丛丈:  "Key_2744", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2737", 丞世不丒下上上丝丑:  15007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_66, 丌丞丌丌丈丁丏丅丟:  val_67, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion47", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  1, 且丘丈丁丗万万不丙:  1, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_69 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_69 != null)
        {
                val_69.Add(item:  0);
            val_69.Add(item:  1);
            val_69.Add(item:  3);
        }
        else
        {
                val_69.Add(item:  0);
            val_69.Add(item:  1);
            val_69.Add(item:  3);
        }
        
        val_69.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_70 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_70.Add(item:  0);
        val_2.Add(key:  "gadget_mech", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_mech", 业东丘与与业丏丛丈:  "Key_0774", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2587", 丞世不丒下上上丝丑:  16007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_69, 丌丞丌丌丈丁丏丅丟:  val_70, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_72 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_72 != null)
        {
                val_72.Add(item:  4);
            val_72.Add(item:  3);
        }
        else
        {
                val_72.Add(item:  4);
            val_72.Add(item:  3);
        }
        
        val_72.Add(item:  1);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_73 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_73 != null)
        {
                val_73.Add(item:  30);
        }
        else
        {
                val_73.Add(item:  30);
        }
        
        val_73.Add(item:  41);
        val_2.Add(key:  "gadget_medicalstation", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_medicalstation", 业东丘与与业丏丛丈:  "Key_2513", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2540", 丞世不丒下上上丝丑:  17007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_72, 丌丞丌丌丈丁丏丅丟:  val_73, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  15));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_75 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_75 != null)
        {
                val_75.Add(item:  4);
        }
        else
        {
                val_75.Add(item:  4);
        }
        
        val_75.Add(item:  2);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_76 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_76.Add(item:  30);
        val_2.Add(key:  "gadget_medkit", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_medkit", 业东丘与与业丏丛丈:  "Key_2475", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2576", 丞世不丒下上上丝丑:  18007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_75, 丌丞丌丌丈丁丏丅丟:  val_76, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  30));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_78 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_78 != null)
        {
                val_78.Add(item:  0);
            val_78.Add(item:  1);
            val_78.Add(item:  3);
        }
        else
        {
                val_78.Add(item:  0);
            val_78.Add(item:  1);
            val_78.Add(item:  3);
        }
        
        val_78.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_79 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_79.Add(item:  0);
        val_2.Add(key:  "gadget_mh_mech1", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  112, 丞丅上丏丂且下丅与:  "gadget_mh_mech1", 业东丘与与业丏丛丈:  "Key_9684", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2587", 丞世不丒下上上丝丑:  52007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_78, 丌丞丌丌丈丁丏丅丟:  val_79, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  0, 且丗丟丟专一丈丙丝:  0, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_81 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_81 != null)
        {
                val_81.Add(item:  0);
            val_81.Add(item:  1);
            val_81.Add(item:  3);
        }
        else
        {
                val_81.Add(item:  0);
            val_81.Add(item:  1);
            val_81.Add(item:  3);
        }
        
        val_81.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_82 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_82.Add(item:  0);
        val_2.Add(key:  "gadget_mh_mech2", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  112, 丞丅上丏丂且下丅与:  "gadget_mh_mech2", 业东丘与与业丏丛丈:  "Key_9684", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2587", 丞世不丒下上上丝丑:  53007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_81, 丌丞丌丌丈丁丏丅丟:  val_82, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  0, 且丗丟丟专一丈丙丝:  0, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_84 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_84 != null)
        {
                val_84.Add(item:  0);
            val_84.Add(item:  1);
            val_84.Add(item:  3);
        }
        else
        {
                val_84.Add(item:  0);
            val_84.Add(item:  1);
            val_84.Add(item:  3);
        }
        
        val_84.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_85 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_85.Add(item:  0);
        val_2.Add(key:  "gadget_mh_mech3", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  112, 丞丅上丏丂且下丅与:  "gadget_mh_mech3", 业东丘与与业丏丛丈:  "Key_9684", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2587", 丞世不丒下上上丝丑:  54007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_84, 丌丞丌丌丈丁丏丅丟:  val_85, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  0, 且丗丟丟专一丈丙丝:  0, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_87 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_87 != null)
        {
                val_87.Add(item:  4);
            val_87.Add(item:  3);
        }
        else
        {
                val_87.Add(item:  4);
            val_87.Add(item:  3);
        }
        
        val_87.Add(item:  0);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_88 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_88 != null)
        {
                val_88.Add(item:  13);
        }
        else
        {
                val_88.Add(item:  13);
        }
        
        val_88.Add(item:  10);
        val_2.Add(key:  "gadget_mine", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_mine", 业东丘与与业丏丛丈:  "Key_2485", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2568", 丞世不丒下上上丝丑:  19007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_87, 丌丞丌丌丈丁丏丅丟:  val_88, 业万丅丆上丈一世丄:  81, 丏丟丛世丄七丌业三:  "Explosion47", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  64, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_90 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_90 != null)
        {
                val_90.Add(item:  0);
            val_90.Add(item:  3);
        }
        else
        {
                val_90.Add(item:  0);
            val_90.Add(item:  3);
        }
        
        val_90.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_91 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_91 != null)
        {
                val_91.Add(item:  10);
        }
        else
        {
                val_91.Add(item:  10);
        }
        
        val_91.Add(item:  36);
        val_2.Add(key:  "gadget_molotov", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_molotov", 业东丘与与业丏丛丈:  "Key_2484", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2569", 丞世不丒下上上丝丑:  20007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_90, 丌丞丌丌丈丁丏丅丟:  val_91, 业万丅丆上丈一世丄:  78, 丏丟丛世丄七丌业三:  "Explosion_gadget_molotov", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  62, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.8f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_93 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_93 != null)
        {
                val_93.Add(item:  0);
        }
        else
        {
                val_93.Add(item:  0);
        }
        
        val_93.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_94 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_94 != null)
        {
                val_94.Add(item:  12);
        }
        else
        {
                val_94.Add(item:  12);
        }
        
        val_94.Add(item:  42);
        val_2.Add(key:  "gadget_ninjashurickens", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_ninjashurickens", 业东丘与与业丏丛丈:  "Key_2878", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2895", 丞世不丒下上上丝丑:  21007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_93, 丌丞丌丌丈丁丏丅丟:  val_94, 业万丅丆上丈一世丄:  78, 丏丟丛世丄七丌业三:  "Explosion54", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  78, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_96 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_96 != null)
        {
                val_96.Add(item:  4);
            val_96.Add(item:  3);
        }
        else
        {
                val_96.Add(item:  4);
            val_96.Add(item:  3);
        }
        
        val_96.Add(item:  0);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_97 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_97 != null)
        {
                val_97.Add(item:  10);
        }
        else
        {
                val_97.Add(item:  10);
        }
        
        val_97.Add(item:  32);
        val_2.Add(key:  "gadget_nucleargrenade", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_nucleargrenade", 业东丘与与业丏丛丈:  "Key_2481", 丗丈一丟丈万丅丞东:  6, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2570", 丞世不丒下上上丝丑:  22007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_96, 丌丞丌丌丈丁丏丅丟:  val_97, 业万丅丆上丈一世丄:  80, 丏丟丛世丄七丌业三:  "A-bomb_mini", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  61, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_99 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_99 != null)
        {
                val_99.Add(item:  0);
            val_99.Add(item:  3);
        }
        else
        {
                val_99.Add(item:  0);
            val_99.Add(item:  3);
        }
        
        val_99.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_100 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_100 != null)
        {
                val_100.Add(item:  25);
        }
        else
        {
                val_100.Add(item:  25);
        }
        
        val_100.Add(item:  10);
        val_2.Add(key:  "gadget_nutcracker", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_nutcracker", 业东丘与与业丏丛丈:  "Key_2746", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2739", 丞世不丒下上上丝丑:  23007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_99, 丌丞丌丌丈丁丏丅丟:  val_100, 业万丅丆上丈一世丄:  81, 丏丟丛世丄七丌业三:  "Explosion52", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  75, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  1.2f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_102 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_102 != null)
        {
                val_102.Add(item:  0);
        }
        else
        {
                val_102.Add(item:  0);
        }
        
        val_102.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_103 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_103 != null)
        {
                val_103.Add(item:  16);
        }
        else
        {
                val_103.Add(item:  16);
        }
        
        val_103.Add(item:  10);
        val_2.Add(key:  "gadget_pandorabox", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_pandorabox", 业东丘与与业丏丛丈:  "Key_2563", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2584", 丞世不丒下上上丝丑:  24007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_102, 丌丞丌丌丈丁丏丅丟:  val_103, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "Explosion47", 与丁丐丈万丏丘丂下:  90f, 丑专丐丛丛丌丞东专:  64, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  2.2f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  true, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_105 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_105 != null)
        {
                val_105.Add(item:  3);
        }
        else
        {
                val_105.Add(item:  3);
        }
        
        val_105.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_106 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_106.Add(item:  44);
        val_2.Add(key:  "gadget_petbooster", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_petbooster", 业东丘与与业丏丛丈:  "Key_2745", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2741", 丞世不丒下上上丝丑:  25007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_105, 丌丞丌丌丈丁丏丅丟:  val_106, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_108 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_108 != null)
        {
                val_108.Add(item:  0);
            val_108.Add(item:  3);
        }
        else
        {
                val_108.Add(item:  0);
            val_108.Add(item:  3);
        }
        
        val_108.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_109 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_109 != null)
        {
                val_109.Add(item:  10);
        }
        else
        {
                val_109.Add(item:  10);
        }
        
        val_109.Add(item:  36);
        val_2.Add(key:  "gadget_phoenix_blood", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_phoenix_blood", 业东丘与与业丏丛丈:  "Key_10321", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_10322", 丞世不丒下上上丝丑:  55007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_108, 丌丞丌丌丈丁丏丅丟:  val_109, 业万丅丆上丈一世丄:  78, 丏丟丛世丄七丌业三:  "Explosion_gadget_phoenix_blood", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  143, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.8f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_111 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_111 != null)
        {
                val_111.Add(item:  16);
        }
        else
        {
                val_111.Add(item:  16);
        }
        
        val_111.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_112 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_112 != null)
        {
                val_112.Add(item:  1);
        }
        else
        {
                val_112.Add(item:  1);
        }
        
        val_112.Add(item:  58);
        val_2.Add(key:  "gadget_pocket_harpoon", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_pocket_harpoon", 业东丘与与业丏丛丈:  "Key_8867", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8879", 丞世不丒下上上丝丑:  44007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_111, 丌丞丌丌丈丁丏丅丟:  val_112, 业万丅丆上丈一世丄:  78, 丏丟丛世丄七丌业三:  "Weapon124", 与丁丐丈万丏丘丂下:  50f, 丑专丐丛丛丌丞东专:  783, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_114 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_114 != null)
        {
                val_114.Add(item:  4);
        }
        else
        {
                val_114.Add(item:  4);
        }
        
        val_114.Add(item:  3);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_115 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_115.Add(item:  33);
        val_2.Add(key:  "gadget_reflector", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_reflector", 业东丘与与业丏丛丈:  "Key_2482", 丗丈一丟丈万丅丞东:  5, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2577", 丞世不丒下上上丝丑:  26007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.3f, 丗丟上上丒丐丗丞丙:  val_114, 丌丞丌丌丈丁丏丅丟:  val_115, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_117 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_117 != null)
        {
                val_117.Add(item:  16);
            val_117.Add(item:  0);
            val_117.Add(item:  1);
            val_117.Add(item:  3);
        }
        else
        {
                val_117.Add(item:  16);
            val_117.Add(item:  0);
            val_117.Add(item:  1);
            val_117.Add(item:  3);
        }
        
        val_117.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_118 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_118 != null)
        {
                val_118.Add(item:  2);
        }
        else
        {
                val_118.Add(item:  2);
        }
        
        val_118.Add(item:  10);
        val_2.Add(key:  "gadget_rocket_mech", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_rocket_mech", 业东丘与与业丏丛丈:  "Key_8869", 丗丈一丟丈万丅丞东:  4, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8881", 丞世不丒下上上丝丑:  35007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.5f, 丗丟上上丒丐丗丞丙:  val_117, 丌丞丌丌丈丁丏丅丟:  val_118, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  5, 且丗丟丟专一丈丙丝:  5, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_120 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_120 != null)
        {
                val_120.Add(item:  4);
            val_120.Add(item:  3);
        }
        else
        {
                val_120.Add(item:  4);
            val_120.Add(item:  3);
        }
        
        val_120.Add(item:  1);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_121 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_121.Add(item:  23);
        val_2.Add(key:  "gadget_shield", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_shield", 业东丘与与业丏丛丈:  "Key_2478", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2573", 丞世不丒下上上丝丑:  27007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_120, 丌丞丌丌丈丁丏丅丟:  val_121, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_123 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_123 != null)
        {
                val_123.Add(item:  4);
        }
        else
        {
                val_123.Add(item:  4);
        }
        
        val_123.Add(item:  3);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_124 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_124 != null)
        {
                val_124.Add(item:  29);
        }
        else
        {
                val_124.Add(item:  29);
        }
        
        val_124.Add(item:  41);
        val_2.Add(key:  "gadget_singularity", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_singularity", 业东丘与与业丏丛丈:  "Key_2476", 丗丈一丟丈万丅丞东:  5, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2571", 丞世不丒下上上丝丑:  28007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_123, 丌丞丌丌丈丁丏丅丟:  val_124, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "WeaponSingularity", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  60, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_126 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_126 != null)
        {
                val_126.Add(item:  3);
        }
        else
        {
                val_126.Add(item:  3);
        }
        
        val_126.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_127 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_127.Add(item:  45);
        val_2.Add(key:  "gadget_snowman", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_snowman", 业东丘与与业丏丛丈:  "Key_2749", 丗丈一丟丈万丅丞东:  3, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2740", 丞世不丒下上上丝丑:  29007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.05f, 丗丟上上丒丐丗丞丙:  val_126, 丌丞丌丌丈丁丏丅丟:  val_127, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_129 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_129 != null)
        {
                val_129.Add(item:  4);
        }
        else
        {
                val_129.Add(item:  4);
        }
        
        val_129.Add(item:  3);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_130 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_130.Add(item:  34);
        val_2.Add(key:  "gadget_stealth", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_stealth", 业东丘与与业丏丛丈:  "Key_2483", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2574", 丞世不丒下上上丝丑:  30007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_129, 丌丞丌丌丈丁丏丅丟:  val_130, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_132 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_132 != null)
        {
                val_132.Add(item:  16);
            val_132.Add(item:  0);
            val_132.Add(item:  1);
            val_132.Add(item:  3);
        }
        else
        {
                val_132.Add(item:  16);
            val_132.Add(item:  0);
            val_132.Add(item:  1);
            val_132.Add(item:  3);
        }
        
        val_132.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_133 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_133 != null)
        {
                val_133.Add(item:  4);
        }
        else
        {
                val_133.Add(item:  4);
        }
        
        val_133.Add(item:  22);
        val_2.Add(key:  "gadget_sticky_turret", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_sticky_turret", 业东丘与与业丏丛丈:  "Key_8866", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8878", 丞世不丒下上上丝丑:  38007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_132, 丌丞丌丌丈丁丏丅丟:  val_133, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_135 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_135 != null)
        {
                val_135.Add(item:  3);
        }
        else
        {
                val_135.Add(item:  3);
        }
        
        val_135.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_136 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_136 != null)
        {
                val_136.Add(item:  19);
        }
        else
        {
                val_136.Add(item:  19);
        }
        
        val_136.Add(item:  46);
        val_2.Add(key:  "gadget_stickycandy", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  212, 丞丅上丏丂且下丅与:  "gadget_stickycandy", 业东丘与与业丏丛丈:  "Key_2748", 丗丈一丟丈万丅丞东:  2, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2742", 丞世不丒下上上丝丑:  31007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_135, 丌丞丌丌丈丁丏丅丟:  val_136, 业万丅丆上丈一世丄:  80, 丏丟丛世丄七丌业三:  "stickycandy_explosion", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  77, 且丘丈丁丗万万不丙:  true, 丄且丈丗七七下一丏:  0.4f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_138 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_138 != null)
        {
                val_138.Add(item:  16);
            val_138.Add(item:  3);
        }
        else
        {
                val_138.Add(item:  16);
            val_138.Add(item:  3);
        }
        
        val_138.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_139 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_139 != null)
        {
                val_139.Add(item:  29);
        }
        else
        {
                val_139.Add(item:  29);
        }
        
        val_139.Add(item:  41);
        val_2.Add(key:  "gadget_super_magnet", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_super_magnet", 业东丘与与业丏丛丈:  "Key_8863", 丗丈一丟丈万丅丞东:  5, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8875", 丞世不丒下上上丝丑:  45007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.3f, 丗丟上上丒丐丗丞丙:  val_138, 丌丞丌丌丈丁丏丅丟:  val_139, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_141 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        val_141.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_142 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_142.Add(item:  37);
        val_2.Add(key:  "gadget_timewatch", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_timewatch", 业东丘与与业丏丛丈:  "Key_2479", 丗丈一丟丈万丅丞东:  5, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2575", 丞世不丒下上上丝丑:  32007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  1f, 丗丟上上丒丐丗丞丙:  val_141, 丌丞丌丌丈丁丏丅丟:  val_142, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  3, 且丗丟丟专一丈丙丝:  9, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_144 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_144 != null)
        {
                val_144.Add(item:  0);
            val_144.Add(item:  1);
            val_144.Add(item:  3);
        }
        else
        {
                val_144.Add(item:  0);
            val_144.Add(item:  1);
            val_144.Add(item:  3);
        }
        
        val_144.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_145 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_145.Add(item:  0);
        val_2.Add(key:  "gadget_turret", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_turret", 业东丘与与业丏丛丈:  "Key_0773", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_2539", 丞世不丒下上上丝丑:  33007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_144, 丌丞丌丌丈丁丏丅丟:  val_145, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        System.Collections.Generic.List<一丁丒与丁丂丈七丆> val_147 = new System.Collections.Generic.List<一丁丒与丁丂丈七丆>();
        if(val_147 != null)
        {
                val_147.Add(item:  16);
            val_147.Add(item:  1);
            val_147.Add(item:  3);
        }
        else
        {
                val_147.Add(item:  16);
            val_147.Add(item:  1);
            val_147.Add(item:  3);
        }
        
        val_147.Add(item:  4);
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_148 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        val_148.Add(item:  53);
        val_2.Add(key:  "gadget_x-ray_glasses", value:  new 丕丈丏丝丗下丟丅丂(丙丑丕丂下丏一丁专:  200, 丞丅上丏丂且下丅与:  "gadget_x-ray_glasses", 业东丘与与业丏丛丈:  "Key_8870", 丗丈一丟丈万丅丞东:  1, 丙丆与丁七三丛丂世:  0, 丘专三丛丅与丆不万:  0, 丆丕下丄万丞丁世丛:  "Key_8882", 丞世不丒下上上丝丑:  37007, 丞丌东丟且丒丐丑丂:  0, 不丄丕且丄丕丝丛丆:  0.2f, 丗丟上上丒丐丗丞丙:  val_147, 丌丞丌丌丈丁丏丅丟:  val_148, 业万丅丆上丈一世丄:  95, 丏丟丛世丄七丌业三:  "", 与丁丐丈万丏丘丂下:  0f, 丑专丐丛丛丌丞东专:  0, 且丘丈丁丗万万不丙:  false, 丄且丈丗七七下一丏:  0f, 丆丑上丁丄业丞不丗:  false, 丄丑丏与丌丌丕丄丛:  1, 且丗丟丟专一丈丙丝:  3, 上丙丘丝丅丁丗丐万:  65));
        丁下万丟且丟丛下业.丟丟万一不业上丐丗 = val_2;
    }
    public 丁下万丟且丟丛下业()
    {
    
    }

}
