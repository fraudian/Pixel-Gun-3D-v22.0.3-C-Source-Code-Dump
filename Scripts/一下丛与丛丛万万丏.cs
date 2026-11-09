using UnityEngine;
internal sealed class 一下丛与丛丛万万丏
{
    // Fields
    internal const string 丟丒世东丒丝丅丞下 = "ClanChest";
    private const string 丐业不一丌万万丗且 = "InappBonuessController.REMEMBERED_BONUSES_STORAGE_KEY";
    private static 一下丛与丛丛万万丏 世丒丞七专三与万丕;
    private static System.Action<InappRememberedBonus> 丅不丒丛业世专丙下;
    private static int 且丑丑丟丄丘世一丐;
    private static readonly string 三丒丐丕丕丘丈丐东;
    
    // Properties
    internal static 一下丛与丛丛万万丏 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    private 一下丛与丛丛万万丏()
    {
    
    }
    internal static 一下丛与丛丛万万丏 丑七不且上丗丁一世()
    {
        一下丛与丛丛万万丏 val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(一下丛与丛丛万万丏.世丒丞七专三与万丕 == null)
        {
                一下丛与丛丛万万丏 val_1 = null;
            val_2 = val_1;
            val_1 = new 一下丛与丛丛万万丏();
            val_4 = null;
            val_4 = null;
            一下丛与丛丛万万丏.世丒丞七专三与万丕 = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (一下丛与丛丛万万丏)一下丛与丛丛万万丏.世丒丞七专三与万丕;
    }
    internal static void 丙且丝丕丙丟丁下丑(System.Action<InappRememberedBonus> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  一下丛与丛丛万万丏.丅不丒丛业世专丙下, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(一下丛与丛丛万万丏.丅不丒丛业世专丙下 != 1152921505214304264);
    
    }
    internal static void 丁丘世丁丝七且一丁(System.Action<InappRememberedBonus> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  一下丛与丛丛万万丏.丅不丒丛业世专丙下, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(一下丛与丛丛万万丏.丅不丒丛业世专丙下 != 1152921505214304264);
    
    }
    public bool 世丅丁丅世上上丘七(System.Collections.Generic.Dictionary<string, object> 丂丈丗丄不丅丅丙丒)
    {
        string val_5;
        var val_6;
        val_5 = 丂丈丗丄不丅丅丙丒;
        if(val_5 != null)
        {
                object val_1 = val_5.Item["Key"];
            if(val_1 != null)
        {
                val_5 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_5 = 0;
        }
        
            val_6 = BalanceController.丆世丙丘丐丈丗丟与();
            bool val_3 = val_6.Contains(item:  val_5);
        }
        else
        {
                val_6 = 0;
        }
        
        val_6 = val_6 & 1;
        return (bool)val_6;
    }
    internal static System.Collections.Generic.Dictionary<string, object> 万专东丘丅丗不且丒(System.Collections.Generic.Dictionary<string, object> 丒且丑业丑丈不丌丗, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丟丁丈丌上丟东丘丆)
    {
        string val_50;
        string val_51;
        string val_53;
        var val_55;
        var val_56;
        System.Func<System.String, System.String> val_58;
        var val_59;
        System.Func<System.String, System.String> val_61;
        var val_62;
        var val_63;
        System.Func<System.String, System.String> val_65;
        var val_66;
        System.Func<System.String, System.String> val_68;
        var val_69;
        var val_70;
        System.Func<System.String, System.String> val_72;
        var val_73;
        System.Func<System.String, System.String> val_75;
        object val_13 = 0;
        object val_6 = 0;
        object val_28 = 0;
        object val_19 = 0;
        object val_37 = 0;
        if(丒且丑业丑丈不丌丗 == null)
        {
                return 0;
        }
        
        if(丟丁丈丌上丟东丘丆 == null)
        {
            goto label_2;
        }
        
        new 一下丛与丛丛万万丏.丒丛丁与丅东丒不七() = new System.Object();
        object val_2 = 丒且丑业丑丈不丌丗.Item["Key"];
        if(val_2 == null)
        {
            goto label_4;
        }
        
        var val_3 = (null == null) ? (val_2) : 0;
        goto label_5;
        label_2:
        UnityEngine.Debug.LogWarning(message:  "FindInappBonusInBonuses: whereToFind = null");
        return 0;
        label_4:
        val_50 = 0;
        label_5:
        .丟丛一丐丗专专七且 = val_50;
        System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_4 = new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean>(object:  new 一下丛与丛丛万万丏.丒丛丁与丅东丒不七(), method:  System.Boolean 一下丛与丛丛万万丏.丒丛丁与丅东丒不七::三万丒丈丒下一专丐(System.Collections.Generic.Dictionary<string, object> 丂丈丗丄不丅丅丙丒));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  丟丁丈丌上丟东丘丆, predicate:  null);
        if(val_5 == null)
        {
                return 0;
        }
        
        if((丒且丑业丑丈不丌丗.TryGetValue(key:  "Weapon", value: out  val_6)) != false)
        {
                if(val_6 != 0)
        {
                var val_8 = (1179403647 == null) ? (val_6) : 0;
        }
        else
        {
                val_51 = 0;
        }
        
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_51)) != true)
        {
                object val_10 = val_5.Item["Weapon"];
            if((System.String.op_Inequality(a:  (null == null) ? (val_10) : 0, b:  val_51)) == true)
        {
                return 0;
        }
        
        }
        
        }
        
        if((丒且丑业丑丈不丌丗.TryGetValue(key:  "DetailsItemId", value: out  val_13)) != false)
        {
                if(val_13 != 0)
        {
                var val_15 = (1179403647 == null) ? (val_13) : 0;
        }
        else
        {
                val_53 = 0;
        }
        
            if((System.String.op_Inequality(a:  (null == null) ? val_5.Item["DetailsItemId"] : 0, b:  val_53)) == true)
        {
                return 0;
        }
        
        }
        
        if(((丒且丑业丑丈不丌丗.TryGetValue(key:  "Gadgets", value: out  val_19)) != false) && (val_19 != 0))
        {
                object val_21 = val_5.Item["Gadgets"];
            val_55 = 0;
            val_56 = null;
            val_56 = null;
            val_58 = 一下丛与丛丛万万丏.<>c.<>9__12_1;
            if(val_58 == null)
        {
                val_58 = null;
            val_58 = new System.Func<System.String, System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一下丛与丛丛万万丏.<>c::丆世丙丁与丆业丟与(string 三丟东丕丄丄下下丑));
            一下丛与丛丛万万丏.<>c.<>9__12_1 = val_58;
        }
        
            val_59 = null;
            val_59 = null;
            val_61 = 一下丛与丛丛万万丏.<>c.<>9__12_2;
            if(val_61 == null)
        {
                val_61 = null;
            val_61 = new System.Func<System.String, System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一下丛与丛丛万万丏.<>c::三丟万丞丝丈丂丕下(string 三丟东丕丄丄下下丑));
            一下丛与丛丛万万丏.<>c.<>9__12_2 = val_61;
        }
        
            if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  val_19, keySelector:  null), second:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  null, keySelector:  null))) == false)
        {
                return 0;
        }
        
        }
        
        if(((丒且丑业丑丈不丌丗.TryGetValue(key:  "Wears", value: out  val_28)) != false) && (val_28 != 0))
        {
                object val_30 = val_5.Item["Wears"];
            val_62 = 0;
            val_63 = null;
            val_63 = null;
            val_65 = 一下丛与丛丛万万丏.<>c.<>9__12_3;
            if(val_65 == null)
        {
                val_65 = null;
            val_65 = new System.Func<System.String, System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一下丛与丛丛万万丏.<>c::三世上丕世下丁丑上(string 三丟东丕丄丄下下丑));
            一下丛与丛丛万万丏.<>c.<>9__12_3 = val_65;
        }
        
            val_66 = null;
            val_66 = null;
            val_68 = 一下丛与丛丛万万丏.<>c.<>9__12_4;
            if(val_68 == null)
        {
                val_68 = null;
            val_68 = new System.Func<System.String, System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一下丛与丛丛万万丏.<>c::丅丁丐丁丄丆专且丑(string 三丟东丕丄丄下下丑));
            一下丛与丛丛万万丏.<>c.<>9__12_4 = val_68;
        }
        
            if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  val_28, keySelector:  null), second:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  null, keySelector:  null))) == false)
        {
                return 0;
        }
        
        }
        
        if(((丒且丑业丑丈不丌丗.TryGetValue(key:  "LobbyItems", value: out  val_37)) != false) && (((val_5.ContainsKey(key:  "LobbyItems")) != false) && (val_37 != 0)))
        {
                object val_40 = val_5.Item["LobbyItems"];
            val_69 = 0;
            val_70 = null;
            val_70 = null;
            val_72 = 一下丛与丛丛万万丏.<>c.<>9__12_5;
            if(val_72 == null)
        {
                val_72 = null;
            val_72 = new System.Func<System.String, System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一下丛与丛丛万万丏.<>c::业且丑丟丞世与丒丗(string 三丟东丕丄丄下下丑));
            一下丛与丛丛万万丏.<>c.<>9__12_5 = val_72;
        }
        
            val_73 = null;
            val_73 = null;
            val_75 = 一下丛与丛丛万万丏.<>c.<>9__12_6;
            if(val_75 == null)
        {
                val_75 = null;
            val_75 = new System.Func<System.String, System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.String 一下丛与丛丛万万丏.<>c::丁丌丏丅丌丗不丝业(string 三丟东丕丄丄下下丑));
            一下丛与丛丛万万丏.<>c.<>9__12_6 = val_75;
        }
        
            if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  val_37, keySelector:  null), second:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  null, keySelector:  null))) == false)
        {
                return 0;
        }
        
        }
        
        if((丒且丑业丑丈不丌丗.ContainsKey(key:  "EventCurrency")) == false)
        {
                return 0;
        }
        
        if((val_5.ContainsKey(key:  "EventCurrency")) == false)
        {
                return 0;
        }
        
        return 0;
    }
    internal static bool 丘丐丁丑丂业丒丟丘(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丈丂丕下丏丈丞丗业, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丂丌丌丛丆丆丙丌丈)
    {
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_8;
        var val_9;
        val_8 = 丂丌丌丛丆丆丙丌丈;
        var val_2 = ((丈丂丕下丏丈丞丗业 | val_8) == 0) ? 1 : 0;
        if(丈丂丕下丏丈丞丗业 == null)
        {
                return (bool);
        }
        
        if(val_8 == null)
        {
                return (bool);
        }
        
        if(丈丂丕下丏丈丞丗业.Count != val_8.Count)
        {
            goto label_3;
        }
        
        List.Enumerator<T> val_5 = 丈丂丕下丏丈丞丗业.GetEnumerator();
        label_7:
        if(((-948811064) & 1) == 0)
        {
            goto label_4;
        }
        
        if((一下丛与丛丛万万丏.万专东丘丅丗不且丒(丒且丑业丑丈不丌丗:  0.丐丏七丌丕丗业且上(), 丟丁丈丌上丟东丘丆:  val_8)) != null)
        {
            goto label_7;
        }
        
        val_9 = 0;
        goto label_8;
        label_3:
        val_9 = 0;
        return (bool);
        label_4:
        val_9 = 1;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    public void 丆世丑丙万七东丏丝(string 丘专丈与三专丈丈专, System.Collections.Generic.Dictionary<string, object> 下丌丐且三下丆丙且)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_24;
        string val_25;
        InappRememberedBonus val_26;
        string val_27;
        var val_28;
        var val_29;
        System.Predicate<InappRememberedBonus> val_30;
        var val_31;
        var val_32;
        val_24 = 下丌丐且三下丆丙且;
        val_25 = 丘专丈与三专丈丈专;
        val_26 = this;
        一下丛与丛丛万万丏.丌丟丘丏丕丅七万丕 val_1 = new 一下丛与丛丛万万丏.丌丟丘丏丕丅七万丕();
        if(val_1 != null)
        {
                val_27 = val_1;
            .丘专丈与三专丈丈专 = val_25;
        }
        else
        {
                val_27 = 16;
            mem[16] = val_25;
            val_25 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_25)) != false)
        {
                val_28 = null;
            val_28 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.七丑七专丈丙上丐且, 丙三丅丛万七丒丏丙:  0, 下下丂三下丘三丞一:  0);
            UnityEngine.Debug.LogErrorFormat(format:  "RememberCurrentBonusForInapp: inappId.IsNullOrEmpty()", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        一丅丌丁丙丈丙上丙 val_5 = AbstractBankView.一丄丂丛业丘东丌东(丄丒丌上丁丂不万东:  val_27);
        if(val_24 == null)
        {
            goto label_17;
        }
        
        if(val_5 < 2)
        {
            goto label_21;
        }
        
        if(val_24.Count <= 0)
        {
            goto label_19;
        }
        
        goto label_21;
        label_17:
        if(val_5 < 2)
        {
            goto label_21;
        }
        
        label_19:
        val_29 = null;
        val_29 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.丟下丈上丈丒丄不专, 丙三丅丛万七丒丏丙:  mem[16], 下下丂三下丘三丞一:  0);
        label_21:
        val_30 = null;
        val_30 = new System.Predicate<InappRememberedBonus>(object:  val_1, method:  System.Boolean 一下丛与丛丛万万丏.丌丟丘丏丕丅七万丕::丟丂丐七且丝丏丛丟(InappRememberedBonus 丆不七丙丈丁与丁专));
        int val_11 = val_9.Bonuses.RemoveAll(match:  null);
        if(val_24 == null)
        {
            goto label_60;
        }
        
        val_30 = "ID";
        if((System.String.op_Equality(a:  System.Convert.ToString(value:  val_24.Item["ID"]), b:  mem[16])) == false)
        {
            goto label_37;
        }
        
        val_26 = this.三丌丑丏一丏丙一丒(丄上下丟与不丈丏丄:  val_24);
        if(val_26 == null)
        {
            goto label_38;
        }
        
        val_24 = val_9.Bonuses;
        val_24.Add(item:  val_26);
        goto label_60;
        label_37:
        val_31 = null;
        val_31 = null;
        val_30 = System.Convert.ToString(value:  val_24.Item["ID"]);
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.专万丘万丞丁丝万丙, 丙三丅丛万七丒丏丙:  val_30, 下下丂三下丘三丞一:  mem[16]);
        object[] val_19 = new object[2];
        val_26 = val_19;
        val_26[0] = mem[16];
        val_24 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_24);
        val_26[1] = val_24;
        UnityEngine.Debug.LogErrorFormat(format:  "RememberCurrentBonusForInapp Convert.ToString( currentInAppBonus[ \"ID\" ] ) != inappId, inappId = {0}, currentInAppBonus = {1}", args:  val_19);
        goto label_60;
        label_38:
        val_32 = null;
        val_32 = null;
        val_30 = mem[16];
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.下不丅丞丘丏丆丈丒, 丙三丅丛万七丒丏丙:  val_30, 下下丂三下丘三丞一:  0);
        object[] val_22 = new object[2];
        val_26 = val_22;
        val_26[0] = mem[16];
        val_24 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_24);
        val_26[1] = val_24;
        UnityEngine.Debug.LogErrorFormat(format:  "RememberCurrentBonusForInapp: bonusForThisInapp == null inappId = {0}, currentInAppBonus = {1}", args:  val_22);
        label_60:
        一下丛与丛丛万万丏.丙上丛丄丒下丑三丑(丑上与且丏专万丝专:  一下丛与丛丛万万丏.丌丐丝业丘东丙丘丐(), 万东与丆不丕世丅丐:  (val_5 > 1) ? 1 : 0);
    }
    internal static void 丏丗丅丁丞丂丗不丄(string 丆三丑专丂且一三业)
    {
        var val_4;
        System.Action<System.String> val_6;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆三丑专丂且一三业)) != false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = 一下丛与丛丛万万丏.<>c.<>9__15_0;
        if(val_6 == null)
        {
                System.Action<System.String> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action<System.String>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 一下丛与丛丛万万丏.<>c::丙丞世丛丆丒与上世(string 下丅丙一丂丗丅丝七));
            一下丛与丛丛万万丏.<>c.<>9__15_0 = val_6;
        }
        
        丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丆三丑专丂且一三业), 丞一丁业丄一一业且:  丆三丑专丂且一三业, 七丝下七下丗三且丟:  val_3, 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  0, 不丐丅丁丂七丐丘丛:  0);
        ShopNGUIController.丕上万丑七丗丕一丈();
        PersConfigurator.与与丑丂丛上七上丗();
    }
    internal static void 丏一丙丏丟丌上丐丘(string 万专万世丂丌丌下万)
    {
        string val_14 = 万专万世丂丌丌下万;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14 = 万专万世丂丌丌下万)) == true)
        {
                return;
        }
        
        val_14 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_14);
        if(val_14 == null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  val_14)) == true)
        {
                return;
        }
        
        bool val_7 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_14, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
        val_14 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丝一丗丄与丛丏丘丛(丞丅上丏丂且下丅与:  val_14.业上丙丞丐丄丆丅七());
        if(val_14 == null)
        {
                return;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        Rilisoft.一丟专且三万丞丁丂.万丁七业丈上丛且丛(丘专丈与三专丈丈专:  val_14.MarketProduct.业上丙丞丐丄丆丅七(), 且丛丏丄丟丐丝三一:  val_14.Id);
    }
    internal static void 丁丁丐丙丙世万七丂(string 丈丁丄丘丛世七丙丝, bool 丝丗不东丙不三丄专, bool 三万东丏一丛丐丛与)
    {
        object val_22;
        三丅丁丗丗丝丂万且 val_23;
        三丅丁丗丗丝丂万且 val_24;
        丕丑丙丑丙东丌丘丕 val_25;
        var val_26;
        WeaponManager val_27;
        var val_28;
        var val_29;
        var val_30;
        三丅丁丗丗丝丂万且 val_31;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丈丁丄丘丛世七丙丝)) != false)
        {
                return;
        }
        
        一下丛与丛丛万万丏.三丅丞丒丕丅专一丅 val_2 = null;
        val_22 = val_2;
        val_2 = new 一下丛与丛丛万万丏.三丅丞丒丕丅专一丅();
        val_23 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丈丁丄丘丛世七丙丝);
        if(val_22 == null)
        {
            goto label_6;
        }
        
        .丆丐七世世且丏丐业 = val_23;
        if(val_23 == null)
        {
            goto label_7;
        }
        
        label_56:
        if(val_22 == null)
        {
                val_24 = .丆丐七世世且丏丐业;
        }
        
        val_25 = 0;
        val_24 = val_24.万上丄下业丛丌不丈() - 1;
        if(三万东丏一丛丐丛与 != false)
        {
                val_25 = WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  .丆丐七世世且丏丐业);
        }
        
        丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  val_24, 丞一丁业丄一一业且:  丈丁丄丘丛世七丙丝, 七丝下七下丗三且丟:  new System.Action<System.String>(object:  val_2, method:  System.Void 一下丛与丛丛万万丏.三丅丞丒丕丅专一丅::丟专七丌丛丐丐下专(string 下丅丙一丂丗丅丝七)), 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  丝丗不东丙不三丄专, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  val_25, 不丐丅丁丂七丐丘丛:  21);
        val_26 = null;
        val_26 = null;
        val_27 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_27 != 0)
        {
                val_27 = 1152921505066536960;
            if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_25;
        }
        
        }
        
            if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
                label_25:
            if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() != true)
        {
                val_28 = null;
            val_28 = null;
            val_27 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
            val_22 = ShopNGUIController.丛世丛与丌不丈丐丐();
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  val_22, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
            WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  val_27);
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_27 = ShopNGUIController.丛丐丛专丟丞万三七();
            val_29 = null;
            val_29 = null;
            if(val_27 != WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐())
        {
                val_30 = null;
            val_30 = null;
            val_27 = WeaponManager.丟丗丄业丘丗业丗七;
            val_27.下东与丌丁丝丁丘专(专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
        }
        
        }
        
        }
        
        }
        
        }
        
        ShopNGUIController.丕上万丑七丗丕一丈();
        return;
        label_6:
        mem[16] = val_23;
        val_31 = mem[16];
        if(val_31 != 0)
        {
            goto label_56;
        }
        
        label_7:
        object[] val_21 = new object[1];
        val_21[0] = 丈丁丄丘丛世七丙丝;
        UnityEngine.Debug.LogErrorFormat(format:  "rec == null, weaponId = {0}", args:  val_21);
    }
    internal static void 丗丄丝万丄万丆丟丘(int 三丘丑丏不万丟与丘, string 丏丂不专上丘丂不丅, int 丝三丟丈与丛丂七丑)
    {
        Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.SetLeprechaunt(不与万丕一丌世丛一:  三丘丑丏不万丟与丘 * 86400, 丘东丈不与专专且丗:  丏丂不专上丘丂不丅, 丄东世不与不丐不专:  丝三丟丈与丛丂七丑, 丕万且丞丘丕丄丗世:  86400);
    }
    internal static void 丌丆丆万东丑丙丅业(string 世丐丗专丅三丝丑丆, int 丟丄丈丁丄丆七丙丙)
    {
        string val_17;
        var val_19;
        val_17 = 世丐丗专丅三丝丑丆;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_17)) == true)
        {
                return;
        }
        
        if(丟丄丈丁丄丆七丙丙 <= 0)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "GiveBonusForInapp: giving pet, quantity <= 0", args:  System.Array.Empty<System.Object>());
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丏专丟丒万丑丐不丞(世丐丗专丅三丝丑丆:  val_17, 丒七且一东丂丐丛丒:  丟丄丈丁丄丆七丙丙)) != false)
        {
                ShopNGUIController.丈丅丌丙丝丘一丝且(世丐丗专丅三丝丑丆:  val_17);
        }
        else
        {
                val_17 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "GiveBonusForInapp petUpdateInfo == null", args:  val_17);
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌与专丗丂丄丌上不();
        if(PetInfoController.Instance != 0)
        {
                PetInfoController.Instance.UpdateState();
        }
        
        if(Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() != 0)
        {
                bool val_14 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().UpdateView();
        }
        
        val_17 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_17 == 0)
        {
                return;
        }
        
        val_17 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_17.丞丏世丆丄上丆一七();
    }
    private static bool 丝业丒丆丏丈丗与丅()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        return UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
    }
    internal static void 丒丞丟丌丞专丙业不(System.Collections.Generic.List<string> 业丐丟七丘丘三业三)
    {
        var val_13;
        var val_14;
        GadgetCategory val_15;
        string val_16;
        val_13 = null;
        val_14 = 0;
        goto label_3;
        label_20:
        val_15 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[业丐丟七丘丘三业三.Item[0]];
        丁下万丟且丟丛下业.丅丕丆丒丒业丑世东(丗丑丐丕丟丝且下丕:  业丐丟七丘丘三业三.Item[0], 丈丘丝一丗下丈丐不:  val_15.专丂丏世且丗丏丌丝());
        if(一下丛与丛丛万万丏.丝业丒丆丏丈丗与丅() != true)
        {
                if(业丐丟七丘丘三业三 != null)
        {
                val_16 = 业丐丟七丘丘三业三.Item[0];
        }
        else
        {
                val_16 = 业丐丟七丘丘三业三.Item[0];
        }
        
            val_15 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  业丐丟七丘丘三业三.Item[0]);
            丆丟七丌丞东丆丕丌.丏下丕丏丘丅与丂丐(丗丑丐丕丟丝且下丕:  val_16, 七丆丒与丗丌丄且丂:  val_15, 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七(), 且丙丄且丐上与丈丆:  false);
        }
        
        val_14 = 1;
        label_3:
        if(val_14 < 业丐丟七丘丘三业三.Count)
        {
            goto label_20;
        }
        
        ShopNGUIController.丕上万丑七丗丕一丈();
    }
    internal static 一下丛与丛丛万万丏.丛丑丙丗下专东丝三 丘一丛丑丈丁丑丅三(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        var val_5;
        string val_49;
        PGCompany.专丟专世丅丂丁且专 val_50;
        var val_51;
        bool val_52;
        string val_53;
        bool val_54;
        var val_55;
        var val_58;
        var val_59;
        var val_61;
        var val_63;
        val_49 = 丂丈丗丄不丅丅丙丒;
        if(val_49 == null)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        if((丂丈丗丄不丅丅丙丒.ItemsParamsForAnalytics == null) || (丂丈丗丄不丅丅丙丒.ItemsParamsForAnalytics.Count < 1))
        {
            goto label_17;
        }
        
        List.Enumerator<T> val_3 = 丂丈丗丄不丅丅丙丒.ItemsParamsForAnalytics.GetEnumerator();
        label_10:
        if(((-946915456) & 1) == 0)
        {
            goto label_5;
        }
        
        Rilisoft.OfferItem val_7 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_5.丐丏七丌丕丗业且上());
        if(val_7 == null)
        {
            goto label_10;
        }
        
        val_1.Add(item:  val_7.ItemParams);
        goto label_10;
        label_1:
        val_50 = 0;
        val_51 = 0;
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_17:
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.Gifts)) != false)
        {
                val_52 = 丂丈丗丄不丅丅丙丒.IsClanGift;
        }
        else
        {
                val_52 = 0;
        }
        
        val_53 = 丂丈丗丄不丅丅丙丒.Gifts;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_53)) == false)
        {
            goto label_24;
        }
        
        val_54 = 丂丈丗丄不丅丅丙丒.IsFriendGift;
        if(val_1 != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_24:
        val_54 = 0;
        if(val_1 != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        if(val_1.Count < 1)
        {
            goto label_33;
        }
        
        val_55 = null;
        val_55 = null;
        val_53 = 一下丛与丛丛万万丏.<>c.<>9__22_0;
        if(val_53 == null)
        {
            goto label_31;
        }
        
        label_50:
        if((val_1.Exists(match:  val_53)) == false)
        {
            goto label_33;
        }
        
        string val_14 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_1).业上丙丞丐丄丆丅七();
        val_49 = val_14;
        if((System.String.op_Equality(a:  val_14, b:  "cw_tribute_auto")) == false)
        {
            goto label_35;
        }
        
        var val_16 = (val_54 != 0) ? 37 : 29;
        val_58 = 33;
        goto label_56;
        label_33:
        if(丂丈丗丄不丅丅丙丒.IsClanSilver == false)
        {
            goto label_37;
        }
        
        label_155:
        val_50 = 0;
        val_51 = 23;
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_37:
        val_53 = 丂丈丗丄不丅丅丙丒.PromotionId;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_53)) == false)
        {
            goto label_44;
        }
        
        val_53 = 丂丈丗丄不丅丅丙丒.Gifts;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_53)) == false)
        {
            goto label_44;
        }
        
        if((System.String.IsNullOrEmpty(value:  丂丈丗丄不丅丅丙丒.PromotionId)) == false)
        {
            goto label_45;
        }
        
        goto label_69;
        label_31:
        一下丛与丛丛万万丏.<>c.<>9__22_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一下丛与丛丛万万丏.<>c::下丘丏一丌丆丙丒且(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
        if(val_1 != null)
        {
            goto label_50;
        }
        
        goto label_50;
        label_44:
        if(val_52 == 0)
        {
            goto label_51;
        }
        
        val_50 = 0;
        val_51 = 25;
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_35:
        if((System.String.op_Equality(a:  val_49, b:  "clan_silver_buff")) == false)
        {
            goto label_53;
        }
        
        var val_22 = (val_54 != 0) ? 38 : 30;
        val_58 = 34;
        goto label_56;
        label_53:
        if((System.String.op_Equality(a:  val_49, b:  "clan_lootbox_point_buff")) == false)
        {
            goto label_55;
        }
        
        var val_24 = (val_54 != 0) ? 39 : 31;
        val_58 = 35;
        goto label_56;
        label_51:
        if(val_54 == 0)
        {
            goto label_57;
        }
        
        if(val_1.Count < 1)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        val_59 = null;
        val_59 = null;
        val_49 = 一下丛与丛丛万万丏.<>c.<>9__22_1;
        if(val_49 == null)
        {
                System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_26 = null;
            val_49 = val_26;
            val_26 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一下丛与丛丛万万丏.<>c::下丄丛丟东丟丄上丒(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
            一下丛与丛丛万万丏.<>c.<>9__22_1 = val_49;
        }
        
        if((val_1.Exists(match:  val_26)) == false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        val_50 = 0;
        val_51 = 50;
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_55:
        val_58 = 32;
        label_56:
        val_50 = 0;
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_45:
        bool val_32 = PGCompany.丂丑业与上丄丂且下.丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  丂丈丗丄不丅丅丙丒.PromotionId, 丗不丁丐下世上丙专: out  0, 一丗与一专丙丙丅丄: out  0);
        label_69:
        val_61 = 0;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.Promotion)) == false)
        {
            goto label_88;
        }
        
        DataSystem.丈且丈上不下且丝丒 val_34 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_48 = 0;
        val_48 = val_48 + 1;
        goto label_80;
        label_57:
        val_63 = null;
        val_63 = null;
        if((System.String.op_Equality(a:  丂丈丗丄不丅丅丙丒.Action, b:  与丂丏丛丞丞丒丟丄.丐上丆三丛不业丌丆)) != false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if((System.String.op_Equality(a:  丂丈丗丄不丅丅丙丒.Action, b:  "multiplier")) == false)
        {
            goto label_86;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_80:
        if(val_34 != null)
        {
                PGCompany.专丟专世丅丂丁且专 val_38 = val_34.七丈丒丒下下且万与();
            val_61 = val_34.不业丙丒丂丞下丆丙();
        }
        
        label_88:
        if((val_61 - 13) > 14)
        {
            goto label_89;
        }
        
        var val_49 = 106020792 + ((val_39 - 13)) << 2;
        val_49 = val_49 + 106020792;
        goto (106020792 + ((val_39 - 13)) << 2 + 106020792);
        label_89:
        if(val_61 != 2)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_86:
        if(丂丈丗丄不丅丅丙丒.IsVipBonus != false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.IsEventCurrencyBonus != false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.OfferId)) == false)
        {
            goto label_109;
        }
        
        if(丂丈丗丄不丅丅丙丒.ClanCurrency <= 0)
        {
            goto label_110;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_109:
        if(丂丈丗丄不丅丅丙丒.OfferModule <= 79)
        {
            goto label_112;
        }
        
        if(丂丈丗丄不丅丅丙丒.OfferModule > 119)
        {
            goto label_113;
        }
        
        if(丂丈丗丄不丅丅丙丒.OfferModule == 80)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.OfferModule != 100)
        {
            goto label_124;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_112:
        if(丂丈丗丄不丅丅丙丒.OfferModule == 40)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.OfferModule == 60)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.OfferModule != 70)
        {
            goto label_124;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_110:
        if(丂丈丗丄不丅丅丙丒.FromBattlePass == false)
        {
            goto label_121;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_113:
        if(丂丈丗丄不丅丅丙丒.OfferModule == 120)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.OfferModule != 130)
        {
            goto label_124;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_121:
        if((丂丈丗丄不丅丅丙丒.ClanChestId & 2147483648) != 0)
        {
            goto label_126;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_124:
        var val_42 = (丂丈丗丄不丅丅丙丒.OfferModule == 140) ? 41 : (0 + 1);
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        label_126:
        if(丂丈丗丄不丅丅丙丒.WeaponDetails > 0)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.FortItemDetails > 0)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.LobbyItemsIds != null)
        {
                if(丂丈丗丄不丅丅丙丒.LobbyItemsIds.Count >= 1)
        {
                if(丂丈丗丄不丅丅丙丒.LobbyItemsIds.Count != 1)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丒丟丝丑丏丒丅丞一(丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.LobbyItemsIds.Item[0])) == false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
            return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        }
        
        if(丂丈丗丄不丅丅丙丒.RoyaleDetails > 0)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.IsPetCardsDirect != false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.IsCraftCurrency != false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.IsModuleChest != false)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.Character > 0)
        {
                return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
        }
        
        if(丂丈丗丄不丅丅丙丒.IsClanSilver == true)
        {
            goto label_155;
        }
        
        return new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = (val_52 != 0) ? (val_58) : ((val_54 != 0) ? 36 : 28), 丙丁丑丙丆丐丂业丈 = val_50};
    }
    internal static string 三万丑不上丏上丁上(一下丛与丛丛万万丏.丛丑丙丗下专东丝三 丐丌三一且丒且丘东)
    {
        int val_2;
        PGCompany.丙一丟与且丞丏丈一 val_7;
        string val_9;
        int val_10;
        val_7 = 丐丌三一且丒且丘东.丙丁丑丙丆丐丂业丈;
        if(丐丌三一且丒且丘东.丗业丛业丂丆丕丈一 != 51)
        {
                if(丐丌三一且丒且丘东.丗业丛业丂丆丕丈一 != 48)
        {
                return 一下丛与丛丛万万丏.三万丑不上丏上丁上(不丌一丄东丝丏且丗:  丐丌三一且丒且丘东.丗业丛业丂丆丕丈一);
        }
        
            if(val_7 != null)
        {
                val_7 = 0;
        }
        
            val_2 = PGCompany.七丏上丘一万丈丈丛.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_7);
            val_9 = "{0}go_";
        }
        else
        {
                val_10 = System.String.alignConst;
            int val_4 = Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_7);
            Subscription20.丒丗业丑丛东上下一 val_5 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  val_7);
            if(val_5 != 3)
        {
                if(val_5 != 1)
        {
                return (string)val_10;
        }
        
            val_2 = val_4;
            val_9 = "{0}sub_";
        }
        else
        {
                val_2 = val_4;
            val_9 = "{0}resub_";
        }
        
        }
        
        val_10 = System.String.Format(format:  val_9, arg0:  val_2);
        return (string)val_10;
    }
    internal static string 三万丑不上丏上丁上(一下丛与丛丛万万丏.上万丆丙丂丕万丒丑 不丌一丄东丝丏且丗)
    {
        var val_1;
        if(不丌一丄东丝丏且丗 >= 51)
        {
                return (string)val_1;
        }
        
        上万丆丙丂丕万丒丑 val_1 = 不丌一丄东丝丏且丗;
        val_1 = 1688849860263968 >> val_1;
        if((val_1 & 1) == 0)
        {
                return (string)val_1;
        }
        
        val_1 = mem[130688256 + (不丌一丄东丝丏且丗) << 3];
        val_1 = 130688256 + (不丌一丄东丝丏且丗) << 3;
        return (string)val_1;
    }
    internal static bool 上且丅专丟丄且丅上(string 丟丟丄专上丟丁丐丝, int 丌丒丝东丌下丕丁丅)
    {
        string val_16;
        var val_17;
        System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_19;
        var val_21;
        System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_23;
        var val_24;
        val_16 = 丟丟丄专上丟丁丐丝;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != true)
        {
                if((System.String.op_Equality(a:  val_16, b:  "EventCurrency")) == false)
        {
            goto label_25;
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = 一下丛与丛丛万万丏.<>c.<>9__26_0;
        if(val_19 == null)
        {
                System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_5 = null;
            val_19 = val_5;
            val_5 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一下丛与丛丛万万丏.<>c::丒丛丑专东专与七三(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
            一下丛与丛丛万万丏.<>c.<>9__26_0 = val_19;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  val_5);
        if(val_6 != null)
        {
                val_16 = val_6.业上丙丞丐丄丆丅七();
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != false)
        {
                val_21 = null;
            val_21 = null;
            val_23 = 一下丛与丛丛万万丏.<>c.<>9__26_1;
            if(val_23 == null)
        {
                System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_11 = null;
            val_23 = val_11;
            val_11 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一下丛与丛丛万万丏.<>c::丑丈丗丅且万万丞且(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
            一下丛与丛丛万万丏.<>c.<>9__26_1 = val_23;
        }
        
            Rilisoft.丛且世丐丆上七业丁 val_12 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  val_11);
            if(val_12 != null)
        {
                val_16 = val_12.业上丙丞丐丄丆丅七();
        }
        
        }
        
        label_25:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != false)
        {
                UnityEngine.Debug.LogError(message:  "game event not found");
            val_24 = 0;
            return (bool)val_24;
        }
        
        val_24 = 1;
        bool val_15 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  val_16);
        return (bool)val_24;
    }
    public InappRememberedBonus 三丌丑丏一丏丙一丒(System.Collections.Generic.Dictionary<string, object> 丄上下丟与不丈丏丄)
    {
        var val_15;
        var val_16;
        InappRememberedBonus val_1 = this.一丗下一丘丟丐丕丛(丄上下丟与不丈丏丄:  丄上下丟与不丈丏丄, 丒业丌七丈丂东东丈:  0);
        if(val_1 == null)
        {
                val_15 = null;
            val_15 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.世业上丗丐丐世万与, 丙三丅丛万七丒丏丙:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄上下丟与不丈丏丄), 下下丂三下丘三丞一:  0);
        }
        
        if((丄上下丟与不丈丏丄.ContainsKey(key:  "bonuses")) != false)
        {
                object val_5 = 丄上下丟与不丈丏丄.Item["bonuses"];
        }
        
        label_47:
        val_16 = null;
        val_16 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.丕丑丞丐丑丘丅丑丑, 丙三丅丛万七丒丏丙:  (val_1 != 0) ? 1 : 0.ToString(), 下下丂三下丘三丞一:  0);
        return val_1;
        label_22:
        label_21:
        if(((-946147128) & 1) == 0)
        {
            goto label_20;
        }
        
        string val_10 = 0.丐丏七丌丕丗业且上();
        if(val_10 == null)
        {
            goto label_21;
        }
        
        InappRememberedBonus val_11 = val_10.一丗下一丘丟丐丕丛(丄上下丟与不丈丏丄:  val_10, 丒业丌七丈丂东东丈:  val_1);
        goto label_22;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_47;
    }
    private InappRememberedBonus 一丗下一丘丟丐丕丛(System.Collections.Generic.Dictionary<string, object> 丄上下丟与不丈丏丄, InappRememberedBonus 丒业丌七丈丂东东丈)
    {
        InappRememberedBonus val_304;
        System.Object[] val_305;
        int val_306;
        var val_307;
        int val_308;
        int val_309;
        var val_310;
        var val_311;
        var val_312;
        var val_313;
        int val_314;
        TierContextType val_317;
        OfferModule val_318;
        AdaptiveModuleType val_319;
        TierContextType val_320;
        int val_321;
        int val_322;
        int val_323;
        int val_324;
        int val_325;
        int val_326;
        var val_327;
        var val_328;
        var val_329;
        var val_330;
        var val_331;
        var val_332;
        var val_333;
        var val_334;
        int val_335;
        var val_336;
        var val_337;
        var val_338;
        int val_339;
        int val_340;
        var val_341;
        string val_342;
        var val_343;
        string val_344;
        string val_345;
        var val_346;
        var val_347;
        val_304 = 丒业丌七丈丂东东丈;
        val_305 = 丄上下丟与不丈丏丄;
        object val_101 = 0;
        object val_96 = 0;
        object val_111 = 0;
        object val_106 = 0;
        object val_119 = 0;
        object val_116 = 0;
        object val_125 = 0;
        object val_122 = 0;
        string val_8 = 0;
        object val_238 = 0;
        object val_12 = 0;
        object val_16 = 0;
        object val_104 = 0;
        object val_99 = 0;
        object val_114 = 0;
        object val_109 = 0;
        object val_130 = 0;
        object val_128 = 0;
        object val_136 = 0;
        object val_133 = 0;
        object val_171 = 0;
        object val_168 = 0;
        object val_174 = 0;
        object val_193 = 0;
        object val_191 = 0;
        object val_197 = 0;
        object val_195 = 0;
        object val_205 = 0;
        object val_209 = 0;
        object val_207 = 0;
        object val_215 = 0;
        object val_212 = 0;
        object val_221 = 0;
        object val_218 = 0;
        object val_224 = 0;
        object val_250 = 0;
        object val_256 = 0;
        object val_253 = 0;
        object val_259 = 0;
        new 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆() = new System.Object();
        if(val_305 == null)
        {
            goto label_1;
        }
        
        if(val_304 != null)
        {
            goto label_2;
        }
        
        val_306 = System.String.alignConst;
        if((val_305.ContainsKey(key:  "action")) != false)
        {
                val_306 = val_305.Item["action"];
        }
        
        if((val_305.ContainsKey(key:  "multiplier")) == false)
        {
            goto label_5;
        }
        
        val_307 = System.Convert.ToInt32(value:  val_305.Item["multiplier"]);
        goto label_9;
        label_1:
        val_305 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "GetActualBonusSizeForInappBonus: inappBonus == null", args:  val_305);
        val_304 = 0;
        return val_304;
        label_5:
        val_307 = 0;
        label_9:
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_305, 下上丐丆丝丟丝丒不:  "Key", 丙业与丙丗丝不丈东: out  val_8)) == false)
        {
            goto label_15;
        }
        
        val_308 = val_8;
        if(val_308 != 0)
        {
            goto label_16;
        }
        
        label_15:
        val_308 = System.String.alignConst;
        label_16:
        string val_10 = 0;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_305, 下上丐丆丝丟丝丒不:  "bonus-key", 丙业与丙丗丝不丈东: out  val_10)) == false)
        {
            goto label_19;
        }
        
        val_309 = val_10;
        if(val_309 != 0)
        {
            goto label_20;
        }
        
        label_19:
        val_309 = System.String.alignConst;
        label_20:
        val_310 = null;
        val_310 = null;
        if((val_305.TryGetValue(key:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, value: out  val_12)) != false)
        {
                if(val_12 != 0)
        {
                if(1179403647 == null)
        {
            goto label_287;
        }
        
        }
        
            int val_14 = System.Convert.ToInt32(value:  val_12);
            UnityEngine.Debug.LogErrorFormat(format:  "coins is int in app remembered bonus", args:  System.Array.Empty<System.Object>());
        }
        
        label_287:
        val_311 = null;
        val_311 = null;
        val_312 = 1152921504624312320;
        if((val_305.TryGetValue(key:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, value: out  val_16)) != false)
        {
                if(val_16 != 0)
        {
                if(1179403647 == null)
        {
            goto label_35;
        }
        
        }
        
            val_313 = System.Convert.ToInt32(value:  val_16);
            UnityEngine.Debug.LogErrorFormat(format:  "gems is int in app remembered bonus", args:  System.Array.Empty<System.Object>());
        }
        else
        {
                val_313 = 0;
        }
        
        label_288:
        val_314 = System.String.alignConst;
        if(((val_305.ContainsKey(key:  "action")) != false) && ((val_305.ContainsKey(key:  "offer-id")) != false))
        {
                if((System.String.op_Equality(a:  (null == null) ? val_305.Item["action"] : 0, b:  "offer")) != true)
        {
                if((System.String.op_Equality(a:  (null == null) ? val_305.Item["action"] : 0, b:  "promotion")) == false)
        {
            goto label_46;
        }
        
        }
        
            val_314 = val_305.Item["offer-id"];
        }
        
        label_46:
        if((val_305.ContainsKey(key:  "offer-context-type")) != false)
        {
                object val_30 = val_305.Item["offer-context-type"];
            val_312 = 1152921504624312320;
        }
        else
        {
                val_317 = 0;
        }
        
        if((val_305.ContainsKey(key:  "offer-module")) != false)
        {
                object val_32 = val_305.Item["offer-module"];
        }
        else
        {
                val_318 = 0;
        }
        
        if((val_305.ContainsKey(key:  "offer-submodule")) != false)
        {
                object val_34 = val_305.Item["offer-submodule"];
            val_320 = val_317;
            val_312 = 1152921504624312320;
        }
        else
        {
                val_320 = val_317;
            val_319 = 0;
        }
        
        bool val_37 = false;
        if((val_305.ContainsKey(key:  "IsEventCurrencyBonus")) != false)
        {
                bool val_38 = System.Boolean.TryParse(value:  val_305.Item["IsEventCurrencyBonus"], result: out  val_37);
        }
        
        if((val_305.ContainsKey(key:  "PetCardsDirect")) != false)
        {
                bool val_42 = System.Boolean.TryParse(value:  val_305.Item["PetCardsDirect"], result: out  false);
        }
        
        bool val_45 = false;
        if((val_305.ContainsKey(key:  "IsCraftCurrency")) != false)
        {
                bool val_46 = System.Boolean.TryParse(value:  val_305.Item["IsCraftCurrency"], result: out  val_45);
        }
        
        if((val_305.ContainsKey(key:  "IsClanSilver")) != false)
        {
                bool val_50 = System.Boolean.TryParse(value:  val_305.Item["IsClanSilver"], result: out  false);
        }
        
        bool val_53 = false;
        if((val_305.ContainsKey(key:  "IsClanGift")) != false)
        {
                bool val_54 = System.Boolean.TryParse(value:  val_305.Item["IsClanGift"], result: out  val_53);
        }
        
        if((val_305.ContainsKey(key:  "IsFriendGift")) != false)
        {
                bool val_58 = System.Boolean.TryParse(value:  val_305.Item["IsFriendGift"], result: out  false);
        }
        
        if((val_305.ContainsKey(key:  "IsModuleChest")) != false)
        {
                bool val_62 = System.Boolean.TryParse(value:  val_305.Item["IsModuleChest"], result: out  false);
        }
        
        bool val_65 = false;
        if((val_305.ContainsKey(key:  "fromBattlePass")) != false)
        {
                bool val_66 = System.Boolean.TryParse(value:  val_305.Item["fromBattlePass"], result: out  val_65);
        }
        
        if((val_305.ContainsKey(key:  "IsVipBonus")) != false)
        {
                bool val_70 = System.Boolean.TryParse(value:  val_305.Item["IsVipBonus"], result: out  false);
        }
        
        if((val_305.ContainsKey(key:  "Count")) != false)
        {
                bool val_74 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["Count"], 丙业与丙丗丝不丈东: out  0);
        }
        
        if((val_305.ContainsKey(key:  "Character")) != false)
        {
                bool val_78 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["Character"], 丙业与丙丗丝不丈东: out  0);
        }
        
        if((val_305.ContainsKey(key:  "AddCurrencyCause")) != false)
        {
                bool val_82 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["AddCurrencyCause"], 丙业与丙丗丝不丈东: out  0);
        }
        
        int val_85 = 0;
        if((val_305.ContainsKey(key:  "ObtainWeaponCause")) != false)
        {
                bool val_86 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["ObtainWeaponCause"], 丙业与丙丗丝不丈东: out  val_85);
        }
        
        if((val_305.ContainsKey(key:  "ObtainSourceType")) != false)
        {
                bool val_90 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["ObtainSourceType"], 丙业与丙丗丝不丈东: out  0);
        }
        
        if((val_305.ContainsKey(key:  "ObtainSourceId")) != false)
        {
                val_306 = val_305.Item["ObtainSourceId"];
        }
        
        val_304 = new InappRememberedBonus();
        val_304 = new InappRememberedBonus();
        string val_95 = System.Convert.ToString(value:  val_305.Item["ID"]);
        if(val_304 != null)
        {
                .InappId = val_95;
            .Action = val_306;
            .Multiplier = 0;
            .Coins = 0;
            .Gems = 0;
            .OfferId = val_314;
            .ActionStartTime = val_308;
            .IsEventCurrencyBonus = false;
            .IsPetCardsDirect = false;
            .FromBattlePass = false;
            .OfferContextType = val_320;
            .Count = 0;
            .OfferModule = val_318;
            .OfferSubModule = val_319;
            .IsCraftCurrency = false;
            .IsModuleChest = false;
            .Character = 0;
            .IsClanSilver = false;
            .IsClanGift = false;
            .IsFriendGift = false;
            .AddCurrencyCause = 0;
            .BonusKey = val_309;
            .ObtainWeaponCause = 0;
            .ObtainSourceType = 0;
        }
        else
        {
                mem[192] = val_95;
            mem[16] = val_306;
            mem[24] = val_307;
            mem[96] = 0;
            mem[168] = val_313;
            mem[32] = val_308;
            mem[64] = val_314;
            mem[200] = val_37;
            .IsPetCardsDirect = false;
            mem[152] = val_65;
            .Count = 0;
            .OfferModule = val_318;
            mem[72] = val_320;
            mem[80] = val_319;
            mem[352] = val_45;
            .IsModuleChest = false;
            .Character = 0;
            .IsClanSilver = false;
            mem[416] = val_53;
            .IsFriendGift = false;
            .AddCurrencyCause = 0;
            mem[424] = val_309;
            mem[432] = val_85;
            .ObtainSourceType = 0;
        }
        
        .ObtainSourceId = System.String.alignConst;
        label_2:
        if((val_305.TryGetValue(key:  "DetailsCount", value: out  val_96)) != false)
        {
                .DetailsCount = System.Convert.ToInt32(value:  val_96);
        }
        
        if((val_305.TryGetValue(key:  "DetailsItemId", value: out  val_99)) == false)
        {
            goto label_973;
        }
        
        val_321 = val_99;
        if(val_321 != 0)
        {
                if(1179403647 == null)
        {
            goto label_121;
        }
        
        }
        
        val_321 = System.String.alignConst;
        label_121:
        .DetailsItemId = val_321;
        label_973:
        if((val_305.TryGetValue(key:  "WeaponDetails", value: out  val_101)) != false)
        {
                .WeaponDetails = System.Convert.ToInt32(value:  val_101);
        }
        
        if((val_305.TryGetValue(key:  "WeaponDetailsTag", value: out  val_104)) == false)
        {
            goto label_960;
        }
        
        val_322 = val_104;
        if(val_322 != 0)
        {
                if(1179403647 == null)
        {
            goto label_127;
        }
        
        }
        
        val_322 = System.String.alignConst;
        label_127:
        .WeaponDetailsWeaponTag = val_322;
        label_960:
        if((val_305.TryGetValue(key:  "FortItemDetails", value: out  val_106)) != false)
        {
                .FortItemDetails = System.Convert.ToInt32(value:  val_106);
        }
        
        if((val_305.TryGetValue(key:  "FortItemDetailsTag", value: out  val_109)) == false)
        {
            goto label_947;
        }
        
        val_323 = val_109;
        if(val_323 != 0)
        {
                if(1179403647 == null)
        {
            goto label_133;
        }
        
        }
        
        val_323 = System.String.alignConst;
        label_133:
        .FortItemDetailsTag = val_323;
        label_947:
        if((val_305.TryGetValue(key:  "RoyaleDetails", value: out  val_111)) != false)
        {
                .RoyaleDetails = System.Convert.ToInt32(value:  val_111);
        }
        
        if((val_305.TryGetValue(key:  "RoyaleDetailsTag", value: out  val_114)) == false)
        {
            goto label_934;
        }
        
        val_324 = val_114;
        if(val_324 != 0)
        {
                if(1179403647 == null)
        {
            goto label_139;
        }
        
        }
        
        val_324 = System.String.alignConst;
        label_139:
        .RoyaleDetailsTag = val_324;
        label_934:
        if((val_305.TryGetValue(key:  "ClanCurrency", value: out  val_116)) != false)
        {
                .ClanCurrency = System.Convert.ToInt32(value:  val_116);
        }
        
        if((val_305.TryGetValue(key:  "BattlePassCurrency", value: out  val_119)) != false)
        {
                .BattlePassCurrency = System.Convert.ToInt32(value:  val_119);
        }
        
        if((val_305.TryGetValue(key:  "ClanChestId", value: out  val_122)) != false)
        {
                .ClanChestId = System.Convert.ToInt32(value:  val_122);
        }
        
        if((val_305.TryGetValue(key:  "ClanSeason", value: out  val_125)) != false)
        {
                .ClanSeason = System.Convert.ToInt32(value:  val_125);
        }
        
        if((val_305.TryGetValue(key:  "Pet", value: out  val_128)) == false)
        {
            goto label_918;
        }
        
        val_325 = val_128;
        if(val_325 != 0)
        {
                if(1179403647 == null)
        {
            goto label_154;
        }
        
        }
        
        val_325 = System.String.alignConst;
        label_154:
        .PetId = val_325;
        label_918:
        if((val_305.TryGetValue(key:  "Quantity", value: out  val_130)) != false)
        {
                .Quantity = System.Convert.ToInt32(value:  val_130);
        }
        
        if((val_305.TryGetValue(key:  "Real", value: out  val_133)) != false)
        {
                .Real = System.Convert.ToInt32(value:  val_133);
        }
        
        if((val_305.TryGetValue(key:  "Weapon", value: out  val_136)) == false)
        {
            goto label_882;
        }
        
        val_326 = val_136;
        if(val_326 != 0)
        {
                if(1179403647 == null)
        {
            goto label_163;
        }
        
        }
        
        val_326 = System.String.alignConst;
        label_163:
        .WeaponId = val_326;
        label_882:
        if((val_305.TryGetValue(key:  "Gadgets", value: out  0)) != false)
        {
                val_327 = 0;
            .GadgetIds = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "Weapons", value: out  0)) != false)
        {
                val_328 = 0;
            .WeaponsIds = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "Wears", value: out  0)) != false)
        {
                val_329 = 0;
            .WearIds = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "OfferItems", value: out  0)) != false)
        {
                val_330 = 0;
            .OfferItems = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "ItemsParams", value: out  0)) != false)
        {
                val_331 = 0;
            .ItemParams = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "ItemsParamsForAnalytics", value: out  0)) != false)
        {
                val_332 = 0;
            .ItemsParamsForAnalytics = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "Gifts", value: out  val_168)) != false)
        {
                val_333 = val_168;
            .Gifts = (1179403647 == null) ? (val_333) : 0;
        }
        
        if((val_305.TryGetValue(key:  "promotionId", value: out  val_171)) != false)
        {
                val_334 = val_171;
            .PromotionId = (1179403647 == null) ? (val_334) : 0;
        }
        
        if((val_305.TryGetValue(key:  "promotion", value: out  val_174)) == false)
        {
            goto label_774;
        }
        
        val_335 = val_174;
        if(val_335 != 0)
        {
                if(1179403647 == null)
        {
            goto label_194;
        }
        
        }
        
        val_335 = System.String.alignConst;
        label_194:
        .Promotion = val_335;
        label_774:
        if((val_305.TryGetValue(key:  "offer-items-list", value: out  0)) != false)
        {
                val_336 = 0;
            .OfferItemsInfo = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "Pets", value: out  0)) != false)
        {
                val_337 = 0;
            .PetsIds = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "LobbyItems", value: out  0)) != false)
        {
                val_338 = 0;
            .LobbyItemsIds = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "WeaponUpgrade", value: out  val_191)) != false)
        {
                .WeaponUpgrade = val_191;
        }
        
        if((val_305.TryGetValue(key:  "WeaponLevelUpgrade", value: out  val_193)) != false)
        {
                .WeaponUpgrade = val_193;
        }
        
        if((val_305.TryGetValue(key:  "WeaponQualityUpgrade", value: out  val_195)) != false)
        {
                .WeaponQualityUpgrade = val_195;
        }
        
        if((val_305.TryGetValue(key:  "GachaFreeSpins", value: out  val_197)) != false)
        {
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_197, 丙业与丙丗丝不丈东: out  0)) != false)
        {
                .GachaFreeSpins = 0;
        }
        
        }
        
        if((val_305.ContainsKey(key:  "ArmorUpgrade")) != false)
        {
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["ArmorUpgrade"], 丙业与丙丗丝不丈东: out  0)) != false)
        {
                .ArmorUpgrade = 0;
        }
        
        }
        
        if((val_305.TryGetValue(key:  "ArmorId", value: out  val_205)) == false)
        {
            goto label_677;
        }
        
        val_339 = val_205;
        if(val_339 != 0)
        {
                if(1179403647 == null)
        {
            goto label_225;
        }
        
        }
        
        val_339 = System.String.alignConst;
        label_225:
        .ArmorId = val_339;
        label_677:
        if((val_305.TryGetValue(key:  "CurrencyLeprechaun", value: out  val_207)) == false)
        {
            goto label_665;
        }
        
        val_340 = val_207;
        if(val_340 != 0)
        {
                if(1179403647 == null)
        {
            goto label_228;
        }
        
        }
        
        val_340 = System.String.alignConst;
        label_228:
        .CurrencyLeprechaun = val_340;
        label_665:
        if((val_305.TryGetValue(key:  "DaysLeprechaun", value: out  val_209)) != false)
        {
                .DaysLeprechaun = System.Convert.ToInt32(value:  val_209);
        }
        
        if((val_305.TryGetValue(key:  "PerDayLeprechaun", value: out  val_212)) != false)
        {
                .PerDayLeprechaun = System.Convert.ToInt32(value:  val_212);
        }
        
        if((val_305.TryGetValue(key:  "AddCurrencyCause", value: out  val_215)) != false)
        {
                .AddCurrencyCause = System.Convert.ToInt32(value:  val_215);
        }
        
        if((val_305.TryGetValue(key:  "ObtainWeaponCause", value: out  val_218)) != false)
        {
                .ObtainWeaponCause = System.Convert.ToInt32(value:  val_218);
        }
        
        if((val_305.TryGetValue(key:  "ObtainSourceType", value: out  val_221)) != false)
        {
                .ObtainSourceType = System.Convert.ToInt32(value:  val_221);
        }
        
        if((val_305.TryGetValue(key:  "ObtainSourceId", value: out  val_224)) != false)
        {
                val_341 = val_224;
            .ObtainSourceId = (1179403647 == null) ? (val_341) : 0;
        }
        
        if((val_305.ContainsKey(key:  "VIPseconds")) != false)
        {
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_305.Item["VIPseconds"], 丙业与丙丗丝不丈东: out  0)) != false)
        {
                .VipSeconds = 0;
        }
        
        }
        
        if((val_305.ContainsKey(key:  "EventId")) == false)
        {
            goto label_251;
        }
        
        val_342 = val_305.Item["EventId"];
        if(new 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆() == null)
        {
            goto label_253;
        }
        
        label_255:
        val_343 = new 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆();
        .丟丟丄专上丟丁丐丝 = val_342;
        goto label_254;
        label_251:
        val_344 = 0;
        if(new 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆() != null)
        {
            goto label_255;
        }
        
        label_253:
        val_343 = new 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆();
        .丟丟丄专上丟丁丐丝 = val_344;
        val_345 = .丟丟丄专上丟丁丐丝;
        label_254:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_345)) != false)
        {
                val_319 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            Rilisoft.丛且世丐丆上七业丁 val_236 = val_319.丌丐东业专丑丘丑丗(丁丅丈丌丟世丗丗丟:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<Rilisoft.GameEventType>(丈丗与丞一上且上上:  val_305, 丂丐丄丁丆与丈丂上:  "EventType"));
            if(val_236 != null)
        {
                mem[1152921538021209968] = val_236.业上丙丞丐丄丆丅七();
        }
        
        }
        
        if((val_305.TryGetValue(key:  "EventCurrency", value: out  val_238)) != false)
        {
                int val_240 = System.Convert.ToInt32(value:  val_238);
            val_319 = (InappRememberedBonus)[1152921538021418848].EventCurrencies;
            if(val_319 == null)
        {
                val_319 = null;
            val_319 = new System.Collections.Generic.List<EventCurrency>();
            .EventCurrencies = val_319;
        }
        
            System.Func<EventCurrency, System.Boolean> val_242 = new System.Func<EventCurrency, System.Boolean>(object:  new 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆(), method:  System.Boolean 一下丛与丛丛万万丏.丐丐七丈丅丐三且丆::不丂丒丟丂专七上丕(InappRememberedBonus.EventCurrency 丌丗丏丏丛东专丁且));
            if((System.Linq.Enumerable.FirstOrDefault<EventCurrency>(source:  null, predicate:  null)) != null)
        {
                val_243.Count = val_240;
        }
        else
        {
                new InappRememberedBonus.EventCurrency() = new InappRememberedBonus.EventCurrency();
            val_319 = mem[1152921538021209968];
            if(new InappRememberedBonus.EventCurrency() != null)
        {
                .EventId = val_319;
        }
        else
        {
                mem[24] = val_319;
        }
        
            .Count = val_240;
            (InappRememberedBonus)[1152921538021418848].EventCurrencies.Add(item:  new InappRememberedBonus.EventCurrency());
        }
        
        }
        
        if((val_305.TryGetValue(key:  "Royale", value: out  0)) != false)
        {
                val_346 = 0;
            .RoyaleIds = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        }
        
        if((val_305.TryGetValue(key:  "GroupIdx", value: out  val_250)) != false)
        {
                .GroupIndex = System.Convert.ToInt32(value:  val_250);
        }
        
        if((val_305.TryGetValue(key:  "SubGroupIdx", value: out  val_253)) != false)
        {
                .SubGroupIndex = System.Convert.ToInt32(value:  val_253);
        }
        
        if((val_305.TryGetValue(key:  "GroupActionUniqueKey", value: out  val_256)) != false)
        {
                val_347 = val_256;
            .GroupActionUniqueKey = (1179403647 == null) ? (val_347) : 0;
        }
        
        if((val_305.TryGetValue(key:  "ServerTime", value: out  val_259)) == false)
        {
                return val_304;
        }
        
        val_305 = val_259;
        .ServerTime = System.Convert.ToInt64(value:  val_305);
        return val_304;
        label_35:
        goto label_288;
    }
    private static void 丁七丌万丝丙丘丂丏(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        var val_3;
        string val_4;
        int val_5;
        val_3 = 丄上专丄七丘丕万东;
        if(val_3 != null)
        {
                val_4 = 丄上专丄七丘丕万东.PetId;
        }
        else
        {
                val_4 = 8;
        }
        
        val_5 = 丄上专丄七丘丕万东.Quantity;
        一下丛与丛丛万万丏.丌丆丆万东丑丙丅业(世丐丗专丅三丝丑丆:  val_4, 丟丄丈丁丄丆七丙丙:  val_5);
        if(丄上专丄七丘丕万东.PetsIds == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 丄上专丄七丘丕万东.PetsIds.GetEnumerator();
        val_5 = 1152921519126359200;
        label_9:
        if(((-944757960) & 1) == 0)
        {
            goto label_6;
        }
        
        一下丛与丛丛万万丏.丌丆丆万东丑丙丅业(世丐丗专丅三丝丑丆:  0.丐丏七丌丕丗业且上(), 丟丄丈丁丄丆七丙丙:  1);
        goto label_9;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private static void 丙丗丄丗丒不万万东(InappRememberedBonus 丄上专丄七丘丕万东, bool 下丐丐丂丗丁丂丈丝, string 丞一丁业丄一一业且)
    {
        string val_6;
        var val_7;
        var val_8;
        var val_9;
        System.String[] val_10;
        var val_11;
        int val_12;
        var val_13;
        val_6 = 丞一丁业丄一一业且;
        val_7 = 下丐丐丂丗丁丂丈丝;
        if(丄上专丄七丘丕万东 == null)
        {
                return;
        }
        
        if(val_7 == false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
        {
                return;
        }
        
        val_8 = 0;
        goto label_6;
        label_15:
        val_9 = null;
        val_9 = null;
        val_10 = 0;
        if((System.String.op_Equality(a:  StoreKitEventListener.业万专三一丟且丘业.Length + 32, b:  丄上专丄七丘丕万东.InappId)) == true)
        {
            goto label_11;
        }
        
        val_8 = 1;
        label_6:
        val_11 = null;
        val_11 = null;
        val_10 = StoreKitEventListener.业万专三一丟且丘业;
        if(val_8 < StoreKitEventListener.业万专三一丟且丘业.Length)
        {
            goto label_15;
        }
        
        val_12 = 1;
        goto label_16;
        label_11:
        val_13 = null;
        val_13 = null;
        val_12 = mem[丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32];
        val_12 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32;
        label_16:
        val_7 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_6);
        val_6 = 丏丄丑上丛不丈且万.丄丌丙丞丛丞专丞丈(丞一丁业丄一一业且:  val_6, 丛丐且下丂丏丁专丌:  val_6, 七丆丒与丗丌丄且丂:  val_7.丒万丕七专不丏丞丌(), 专专丗丙丁七世丛业:  0);
        Rilisoft.一丟专且三万丞丁丂.东与万东丟丄丄丄且(丘丅丆丒世丑三下丌:  val_6, 丒世丘丘上丆丝东丞:  val_12);
    }
    private static void 且与丝丕丏丒丟上丒(InappRememberedBonus 丄上专丄七丘丕万东, bool 丝丗不东丙不三丄专, bool 下丐丐丂丗丁丂丈丝)
    {
        object val_5;
        bool val_11;
        var val_12;
        var val_13;
        val_11 = 下丐丐丂丗丁丂丈丝;
        val_12 = 1;
        if(((丄上专丄七丘丕万东.OfferModule != 10) && (丄上专丄七丘丕万东.OfferModule != 60)) && (丄上专丄七丘丕万东.OfferModule != 90))
        {
                bool val_1 = (丄上专丄七丘丕万东.OfferModule == 100) ? 1 : 0;
        }
        
        丝丗不东丙不三丄专 = 丝丗不东丙不三丄专;
        一下丛与丛丛万万丏.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  丄上专丄七丘丕万东.WeaponId, 丝丗不东丙不三丄专:  丝丗不东丙不三丄专, 三万东丏一丛丐丛与:  val_1);
        一下丛与丛丛万万丏.丙丗丄丗丒不万万东(丄上专丄七丘丕万东:  丄上专丄七丘丕万东, 下丐丐丂丗丁丂丈丝:  val_11, 丞一丁业丄一一业且:  丄上专丄七丘丕万东.WeaponId);
        if(丄上专丄七丘丕万东.WeaponsIds == null)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = 丄上专丄七丘丕万东.WeaponsIds.GetEnumerator();
        label_11:
        if(((-944439616) & 1) == 0)
        {
            goto label_8;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        一下丛与丛丛万万丏.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  val_6, 丝丗不东丙不三丄专:  丝丗不东丙不三丄专, 三万东丏一丛丐丛与:  val_1);
        一下丛与丛丛万万丏.丙丗丄丗丒不万万东(丄上专丄七丘丕万东:  丄上专丄七丘丕万东, 下丐丐丂丗丁丂丈丝:  val_11, 丞一丁业丄一一业且:  val_6);
        goto label_11;
        label_8:
        val_13 = 0;
        val_11 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(141 != 141)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    private static void 丏丑丛丂一与且不与(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        object val_3;
        object val_7;
        var val_8;
        val_7 = 丄上专丄七丘丕万东;
        if(丄上专丄七丘丕万东.WearIds == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 丄上专丄七丘丕万东.WearIds.GetEnumerator();
        label_6:
        if(((-944282320) & 1) == 0)
        {
            goto label_3;
        }
        
        一下丛与丛丛万万丏.丏丗丅丁丞丂丗不丄(丆三丑专丂且一三业:  val_3.丐丏七丌丕丗业且上());
        goto label_6;
        label_3:
        val_8 = 0;
        val_7 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(59 != 59)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    private static void 丏专丆丛三七下丞一(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        object val_3;
        object val_7;
        var val_8;
        val_7 = 丄上专丄七丘丕万东;
        if(丄上专丄七丘丕万东.LobbyItemsIds == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 丄上专丄七丘丕万东.LobbyItemsIds.GetEnumerator();
        label_6:
        if(((-944137344) & 1) == 0)
        {
            goto label_3;
        }
        
        一下丛与丛丛万万丏.丏一丙丏丟丌上丐丘(万专万世丂丌丌下万:  val_3.丐丏七丌丕丗业且上());
        goto label_6;
        label_3:
        val_8 = 0;
        val_7 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(59 != 59)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    private static void 一丂丕丅丑丘世丕丙(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        int val_3;
        var val_4;
        var val_5;
        val_3 = 丄上专丄七丘丕万东;
        if(val_3 == null)
        {
                return;
        }
        
        if(丄上专丄七丘丕万东.DaysLeprechaun < 1)
        {
                return;
        }
        
        if(丄上专丄七丘丕万东.PerDayLeprechaun < 1)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if((System.String.op_Equality(a:  丄上专丄七丘丕万东.CurrencyLeprechaun, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true)
        {
                val_5 = null;
            val_5 = null;
            if((System.String.op_Equality(a:  丄上专丄七丘丕万东.CurrencyLeprechaun, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
                return;
        }
        
        }
        
        val_3 = 丄上专丄七丘丕万东.PerDayLeprechaun;
        一下丛与丛丛万万丏.丗丄丝万丄万丆丟丘(三丘丑丏不万丟与丘:  丄上专丄七丘丕万东.DaysLeprechaun, 丏丂不专上丘丂不丅:  丄上专丄七丘丕万东.CurrencyLeprechaun, 丝三丟丈与丛丂七丑:  val_3);
    }
    private static void 七三丘丐一丘丁丗丙(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        InappRememberedBonus val_2 = 丄上专丄七丘丕万东;
        if(val_2 == null)
        {
                return;
        }
        
        if(丄上专丄七丘丕万东.GadgetIds == null)
        {
                return;
        }
        
        if(丄上专丄七丘丕万东.GadgetIds.Count < 1)
        {
                return;
        }
        
        val_2 = 丄上专丄七丘丕万东.GadgetIds;
        一下丛与丛丛万万丏.丒丞丟丌丞专丙业不(业丐丟七丘丘三业三:  val_2);
    }
    private static void 丂丑万与上下一不丈(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        if(丄上专丄七丘丕万东 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.WeaponUpgrade)) == true)
        {
                return;
        }
        
        System.Nullable<T> val_2 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.WeaponUpgrade, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
        if(((-943715256) & 1) == 0)
        {
                return;
        }
        
        if(丄上专丄七丘丕万东.Quantity < 1)
        {
                return;
        }
    
    }
    internal static void 万丏且丒下三三三丄(CategoryNames 七丆丒与丗丌丄且丂, int 丌丒丝东丌下丕丁丅)
    {
    
    }
    private static void 专丁万丟丘丝丑世丛(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        InappRememberedBonus val_1 = 丄上专丄七丘丕万东;
        if(val_1 == null)
        {
                return;
        }
        
        val_1 = 丄上专丄七丘丕万东.GachaFreeSpins;
        if(val_1 < 1)
        {
                return;
        }
        
        GiftController.丅丆丆丏万丅丑丝世(丌丒丝东丌下丕丁丅:  val_1);
    }
    private static void 丈丛专上不三丐丙丝(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_5;
        if(丄上专丄七丘丕万东.DetailsCount < 1)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丄上专丄七丘丕万东.DetailsItemId)) == false)
        {
                return;
        }
        
        if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  丄上专丄七丘丕万东.DetailsItemId)) != false)
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            null.Add(key:  丄上专丄七丘丕万东.DetailsItemId, value:  丄上专丄七丘丕万东.DetailsCount);
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丗且且丘丐三丙丆丁(丌丄万上丙万丄丒七:  null);
        }
        else
        {
                val_5 = 丄上专丄七丘丕万东.DetailsCount;
            Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  丄上专丄七丘丕万东.DetailsItemId, 丌丒丝东丌下丕丁丅:  val_5, 与丘万三东一丄丄丙:  true);
        }
        
        Rilisoft.一丟专且三万丞丁丂.丈丛一一丛一丆一丐(丘专丈与三专丈丈专:  丄上专丄七丘丕万东.InappId, 丕丁下丌不万丅丞丛:  丄上专丄七丘丕万东.DetailsItemId);
    }
    private static void 丟丈丗七不下丁上丈(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        object val_4;
        object val_11;
        var val_12;
        val_11 = 丄上专丄七丘丕万东;
        if(丄上专丄七丘丕万东.RoyaleIds == null)
        {
                return;
        }
        
        if(丄上专丄七丘丕万东.RoyaleIds.Count < 1)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = 丄上专丄七丘丕万东.RoyaleIds.GetEnumerator();
        label_18:
        if(((-943140176) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if((丛且丗丌丏下七下丈.丞丈丐丈丂丕丐丌丂(丞一丁业丄一一业且:  val_5)) == true)
        {
            goto label_18;
        }
        
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_5)) == false)
        {
            goto label_12;
        }
        
        丛且丗丌丏下七下丈.丂七丗丒丅世丒丌下(丞一丁业丄一一业且:  val_5, 丌业丈丙丙丈且丕丞:  true);
        goto label_18;
        label_12:
        一下丛与丛丛万万丏.丁丁丐丙丙世万七丂(丈丁丄丘丛世七丙丝:  val_5, 丝丗不东丙不三丄专:  false, 三万东丏一丛丐丛与:  false);
        goto label_18;
        label_5:
        val_12 = 0;
        val_11 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(107 != 107)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    private static void 丟丁业丄丅下七世且(InappRememberedBonus 丂丈丗丄不丅丅丙丒, bool 下丐丐丂丗丁丂丈丝)
    {
        InappRememberedBonus val_25;
        int val_26;
        var val_27;
        string val_28;
        val_25 = 丂丈丗丄不丅丅丙丒;
        val_26 = 丂丈丗丄不丅丅丙丒.WeaponDetails;
        if(val_26 < 1)
        {
                return;
        }
        
        Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag, 丌丒丝东丌下丕丁丅:  val_26, 与丘万三东一丄丄丙:  true);
        一下丛与丛丛万万丏.丙丗丄丗丒不万万东(丄上专丄七丘丕万东:  val_25, 下丐丐丂丗丁丂丈丝:  下丐丐丂丗丁丂丈丝, 丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag);
        if(下丐丐丂丗丁丂丈丝 != false)
        {
                WeaponManager.专丗丏三丘上一丒丈(丒东业不丐丑丕丄丆:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag);
        }
        
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        val_2.Add(item:  System.String.Format(format:  "{0}:{1}:{2}", arg0:  1070, arg1:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag, arg2:  丂丈丗丄不丅丅丙丒.WeaponDetails));
        System.DateTime val_5 = System.DateTime.UtcNow;
        val_27 = null;
        val_27 = null;
        PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丅丅丙丝丆丏丐与丞(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_5.dateData}, 世丈三丐丞一丒丛不:  一下丛与丛丛万万丏.且丑丑丟丄丘世一丐, 丈丕三丆丟且丆一上:  val_2);
        一下丛与丛丛万万丏.上丑丗丂且丘丒丙万();
        if((Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() != 0) && (Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject.activeInHierarchy != false))
        {
                一下丛与丛丛万万丏.三不东上丞丙丕丐专();
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) != true) && ((System.String.op_Equality(a:  Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().ItemTag, b:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) != false))
        {
                val_28 = 丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag;
            三丅丁丗丗丝丂万且 val_15 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_28);
            if(val_15 != null)
        {
                val_28 = val_15.三与丛丑且丐丈业丌();
        }
        
            if((Rilisoft.丕七东丗丁丐丂三下.丏丐下丌东不上丂丑(上与丕专世专上万三:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag, 东丒不专丞丙三丘丄:  val_28)) != false)
        {
                Rilisoft.BuyCraftDetailsWindow val_18 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
        }
        
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_21 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/Buy"));
        }
        
        val_26 = 1152921505491988480;
        if(Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世() != 0)
        {
                Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().万且丂丑丂丏丘丒七();
        }
        
        val_25 = 丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag;
        一下丛与丛丛万万丏.不丙丑世丕且丈丗三(丞一丁业丄一一业且:  val_25);
    }
    private static void 不丙丑世丕且丈丗三(string 丞一丁业丄一一业且)
    {
        string val_10 = 丞一丁业丄一一业且;
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三() == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10 = 丞一丁业丄一一业且)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三().业上丙丞丐丄丆丅七(), b:  val_10)) == false)
        {
                return;
        }
        
        val_10 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_10.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_10.丈丒丛东上丘丅世三(), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    private static void 丂七丟丗下丘丒丞不(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        string val_17;
        string val_18;
        if(丂丈丗丄不丅丅丙丒.RoyaleDetails < 1)
        {
                return;
        }
        
        val_17 = 丂丈丗丄不丅丅丙丒.RoyaleDetailsTag;
        Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  val_17, 丌丒丝东丌下丕丁丅:  丂丈丗丄不丅丅丙丒.RoyaleDetails, 与丘万三东一丄丄丙:  true);
        一下丛与丛丛万万丏.上丑丗丂且丘丒丙万();
        if((Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟() != 0) && (Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject.activeInHierarchy != false))
        {
                一下丛与丛丛万万丏.三不东上丞丙丕丐专();
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) != true) && ((System.String.op_Equality(a:  Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().ItemTag, b:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) != false))
        {
                val_18 = 丂丈丗丄不丅丅丙丒.RoyaleDetailsTag;
            三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_18);
            if(val_10 != null)
        {
                val_18 = val_10.三与丛丑且丐丈业丌();
        }
        
            val_17 = 丂丈丗丄不丅丅丙丒.RoyaleDetailsTag;
            if((Rilisoft.丕七东丗丁丐丂三下.丏丐下丌东不上丂丑(上与丕专世专上万三:  val_17, 东丒不专丞丙三丘丄:  val_18)) != false)
        {
                Rilisoft.BuyCraftDetailsWindow val_13 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
        }
        
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_16 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/Buy"));
        }
        
        一下丛与丛丛万万丏.不丙丑世丕且丈丗三(丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag);
    }
    private static void 万且丏丂丙丅丝丛东(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        var val_14;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_15;
        val_14 = 丂丈丗丄不丅丅丙丒;
        if(丂丈丗丄不丅丅丙丒.FortItemDetails < 1)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = null;
        val_15 = val_2;
        val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        val_2.Add(key:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag, value:  丂丈丗丄不丅丅丙丒.FortItemDetails);
        Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丗且且丘丐三丙丆丁(丌丄万上丙万丄丒七:  val_2);
        一下丛与丛丛万万丏.三不东上丞丙丕丐专();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().ItemTag, b:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag)) == false)
        {
                return;
        }
        
        val_14 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag);
        val_15 = val_14.三丐丟丒业丞东三丕();
        if(val_14.丗三三丐丁东丘丌一() < (val_14.丄且丞且且且世丂丅() * val_15))
        {
                return;
        }
        
        val_14 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
    }
    private static void 丙上丛丄丒下丑三丑(一下丛与丛丛万万丏.InappRememberedBonuses 丑上与且丏专万丝专, bool 万东与丆不丕世丅丐 = False)
    {
        string val_5;
        var val_6;
        var val_7;
        if(丑上与且丏专万丝专 != null)
        {
                string val_1 = UnityEngine.JsonUtility.ToJson(obj:  丑上与且丏专万丝专);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "InappBonuessController.REMEMBERED_BONUSES_STORAGE_KEY", 下下丏一丙不丘丌丞:  val_1);
            if(万东与丆不丕世丅丐 == false)
        {
                return;
        }
        
            val_6 = null;
            val_6 = null;
            val_5 = PGCompany.Analytics.下一丘丞一与东丗丁.丝丕业丁七丄且业丆;
            PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  val_5, 丙三丅丛万七丒丏丙:  val_1, 下下丂三下丘三丞一:  0);
            return;
        }
        
        val_7 = null;
        val_7 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.丙丟丄丆与上东丗业, 丙三丅丛万七丒丏丙:  0, 下下丂三下丘三丞一:  0);
        UnityEngine.Debug.LogErrorFormat(format:  "SaveBonusesToDisk: bonuses == null", args:  System.Array.Empty<System.Object>());
    }
    public static void 丛丞丐丏丈万丕丙丈(InappRememberedBonus 丄上专丄七丘丕万东)
    {
        null = null;
        if(一下丛与丛丛万万丏.丅不丒丛业世专丙下 == null)
        {
                return;
        }
        
        一下丛与丛丛万万丏.丅不丒丛业世专丙下.Invoke(obj:  丄上专丄七丘丕万东);
    }
    public static InappRememberedBonus 丌七丑世世丛丑丛丕(string 丘专丈与三专丈丈专)
    {
        string val_11;
        System.Object[] val_12;
        var val_13;
        var val_14;
        var val_15;
        System.Func<TSource, System.Boolean> val_16;
        var val_17;
        var val_18;
        val_11 = 丘专丈与三专丈丈专;
        一下丛与丛丛万万丏.丕丘丅三丛丘专世一 val_1 = null;
        val_12 = val_1;
        val_1 = new 一下丛与丛丛万万丏.丕丘丅三丛丘专世一();
        if(val_12 != null)
        {
                val_13 = val_12;
            .丘专丈与三专丈丈专 = val_11;
        }
        else
        {
                val_13 = 16;
            mem[16] = val_11;
            val_11 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == false)
        {
            goto label_5;
        }
        
        val_12 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "ProvideBonus: inappId.IsNullOrEmpty()", args:  val_12);
        goto label_8;
        label_5:
        if(一下丛与丛丛万万丏.丌丐丝业丘东丙丘丐() == null)
        {
            goto label_11;
        }
        
        if(val_4.Bonuses != null)
        {
            goto label_19;
        }
        
        val_14 = null;
        val_14 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.七丐专丘且上且下丞, 丙三丅丛万七丒丏丙:  0, 下下丂三下丘三丞一:  0);
        goto label_19;
        label_11:
        val_15 = null;
        val_15 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.丄丌且丏世下三丑丑, 丙三丅丛万七丒丏丙:  0, 下下丂三下丘三丞一:  0);
        label_19:
        System.Func<InappRememberedBonus, System.Boolean> val_7 = null;
        val_16 = val_7;
        val_7 = new System.Func<InappRememberedBonus, System.Boolean>(object:  val_1, method:  System.Boolean 一下丛与丛丛万万丏.丕丘丅三丛丘专世一::丘丅世丝东丌七丒丗(InappRememberedBonus 丂丈丗丄不丅丅丙丒));
        if((System.Linq.Enumerable.FirstOrDefault<InappRememberedBonus>(source:  val_4.Bonuses, predicate:  val_7)) != null)
        {
                return (InappRememberedBonus)val_17;
        }
        
        val_18 = null;
        val_18 = null;
        val_16 = PGCompany.Analytics.下一丘丞一与东丗丁.丝丄丈丗与丈下丂丞;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  val_16, 丙三丅丛万七丒丏丙:  (val_13 == null) ? "" : (val_13), 下下丂三下丘三丞一:  0);
        label_8:
        val_17 = 0;
        return (InappRememberedBonus)val_17;
    }
    private static 一下丛与丛丛万万丏.InappRememberedBonuses 丌丐丝业丘东丙丘丐()
    {
        string val_13;
        var val_14;
        string val_15;
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_16;
        string val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "InappBonuessController.REMEMBERED_BONUSES_STORAGE_KEY")) != true)
        {
                .Bonuses = new System.Collections.Generic.List<InappRememberedBonus>();
            一下丛与丛丛万万丏.丙上丛丄丒下丑三丑(丑上与且丏专万丝专:  new 一下丛与丛丛万万丏.InappRememberedBonuses(), 万东与丆不丕世丅丐:  false);
        }
        
        val_13 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "InappBonuessController.REMEMBERED_BONUSES_STORAGE_KEY");
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) != false)
        {
                val_14 = null;
            val_14 = null;
            val_15 = PGCompany.Analytics.下一丘丞一与东丗丁.不丙丙丘七丂丞世丞;
            val_16 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_17 = val_15;
            val_18 = 0;
        }
        else
        {
                val_19 = null;
            val_19 = null;
            val_15 = PGCompany.Analytics.下一丘丞一与东丗丁.丗与一丗与丙专丟专;
            val_16 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_17 = val_15;
            val_18 = val_13;
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  val_16, 丟丕丐不丙七万丛三:  val_17, 丙三丅丛万七丒丏丙:  val_18, 下下丂三下丘三丞一:  0);
        val_20 = UnityEngine.JsonUtility.FromJson<InappRememberedBonuses>(json:  val_13);
        if(val_20 != null)
        {
                if(val_8.Bonuses != null)
        {
                return (InappRememberedBonuses)val_20;
        }
        
        }
        
        val_15 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        val_21 = null;
        val_21 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  val_15, 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.专丏丐丐上丄丛世且, 丙三丅丛万七丒丏丙:  (val_13 == null) ? "null" : (val_13), 下下丂三下丘三丞一:  0);
        if(val_20 != null)
        {
                return (InappRememberedBonuses)val_20;
        }
        
        一下丛与丛丛万万丏.InappRememberedBonuses val_11 = null;
        val_20 = val_11;
        val_11 = new 一下丛与丛丛万万丏.InappRememberedBonuses();
        System.Collections.Generic.List<InappRememberedBonus> val_12 = null;
        val_13 = val_12;
        val_12 = new System.Collections.Generic.List<InappRememberedBonus>();
        .Bonuses = val_13;
        return (InappRememberedBonuses)val_20;
    }
    internal static void 万上丝丕不丟丑丑专(string 丅丞丂丟丟且丅丆丅, InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        var val_18;
        var val_19;
        var val_20;
        object val_21;
        var val_23;
        object val_24;
        InappRememberedBonus val_25;
        var val_26;
        var val_28;
        var val_29;
        System.Collections.Generic.Dictionary<System.String, InappRememberedBonus> val_1 = null;
        val_18 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, InappRememberedBonus>();
        val_19 = null;
        val_19 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  一下丛与丛丛万万丏.三丒丐丕丕丘丈丐东)) != false)
        {
                val_20 = null;
            val_20 = null;
            string val_3 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  一下丛与丛丛万万丏.三丒丐丕丕丘丈丐东);
            val_21 = "Savappembeedus j+so_n: "("Savappembeedus j+so_n: ") + val_3;
            UnityEngine.Debug.Log(message:  val_21);
            if((System.String.IsNullOrEmpty(value:  val_3)) != true)
        {
                if((val_3.Equals(value:  "0")) != true)
        {
                val_21 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_23 = val_21;
        }
        
        }
        
        }
        
        if(val_23 == null)
        {
                System.Collections.Generic.Dictionary<System.String, InappRememberedBonus> val_9 = null;
            val_24 = val_9;
            val_9 = new System.Collections.Generic.Dictionary<System.String, InappRememberedBonus>();
        }
        
        if(丂丈丗丄不丅丅丙丒 != null)
        {
                val_25 = 丂丈丗丄不丅丅丙丒;
            val_9.set_Item(key:  丅丞丂丟丟且丅丆丅, value:  val_25);
        }
        else
        {
                bool val_10 = val_9.Remove(key:  丅丞丂丟丟且丅丆丅);
            val_26 = null;
            val_26 = null;
            val_25 = 0;
            PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.世丈丛丙下丄丗七丄, 丙三丅丛万七丒丏丙:  val_25, 下下丂三下丘三丞一:  0);
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_25 = 0;
        string val_14 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_9);
        val_28 = null;
        val_28 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.专业东丞丒丞丛丝下, 丙三丅丛万七丒丏丙:  0, 下下丂三下丘三丞一:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14)) != true) ? "null" : (val_14));
        UnityEngine.Debug.Log(message:  "Savappembeedus r_wDi+t: "("Savappembeedus r_wDi+t: ") + val_14);
        val_29 = null;
        val_29 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  一下丛与丛丛万万丏.三丒丐丕丕丘丈丐东, 下下丏一丙不丘丌丞:  val_14);
    }
    internal static InappRememberedBonus 专丟丙下丌丆七丄专(string 丅丞丂丟丟且丅丆丅)
    {
        var val_12;
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_13;
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_20;
        var val_21;
        if(丅丞丂丟丟且丅丆丅 == null)
        {
                val_12 = null;
            val_12 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.世丈丂业与三丈三丈, 丙三丅丛万七丒丏丙:  0, 下下丂三下丘三丞一:  0);
        }
        
        val_13 = 1152921505214300160;
        val_14 = null;
        val_14 = null;
        val_15 = 一下丛与丛丛万万丏.三丒丐丕丕丘丈丐东;
        val_16 = 0;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_15)) == false)
        {
                return (InappRememberedBonus)val_16;
        }
        
        val_17 = null;
        val_17 = null;
        val_15 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  一下丛与丛丛万万丏.三丒丐丕丕丘丈丐东);
        val_18 = null;
        val_18 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.专丈丐丟丄丙丅丈万, 丙三丅丛万七丒丏丙:  val_15, 下下丂三下丘三丞一:  0);
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_13 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_13 != null)
        {
                if(val_13.Count > 0)
        {
            goto label_38;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.专丏丐丐上丄丛世且, 丙三丅丛万七丒丏丙:  丅丞丂丟丟且丅丆丅, 下下丂三下丘三丞一:  val_15);
        label_38:
        if((val_13.ContainsKey(key:  丅丞丂丟丟且丅丆丅)) != false)
        {
                InappRememberedBonus val_10 = val_13.Item[丅丞丂丟丟且丅丆丅];
            return (InappRememberedBonus)val_16;
        }
        
        val_13 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        val_21 = null;
        val_21 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丆七业丐丝丘东业丈(丆丛丑世下一丐且丕:  val_13, 丟丕丐不丙七万丛三:  PGCompany.Analytics.下一丘丞一与东丗丁.与业丒东三丁一上七, 丙三丅丛万七丒丏丙:  丅丞丂丟丟且丅丆丅, 下下丂三下丘三丞一:  val_15);
        val_16 = 0;
        return (InappRememberedBonus)val_16;
    }
    private static void 上丑丗丂且丘丒丙万()
    {
        ShopNGUIController val_4;
        var val_5;
        if(上丑三丁丄丛丁万丑.丆丒丘丙丒丝丙丗丈() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_4.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_4.丗丛丐丑丛丅丞七且(), 与丝丕与丙不与丗丆:  ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑(), 七丑业业丒七一丂丆:  false);
    }
    private static void 三不东上丞丙丕丐专()
    {
        UnityEngine.Object val_9;
        var val_10;
        System.Action<Rilisoft.CraftDetailsView> val_12;
        val_9 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟();
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().gameObject;
        if(val_9.activeInHierarchy == false)
        {
                return;
        }
        
        val_9 = Rilisoft.BuyCraftDetailsWindow.万丕丞丝七东不丟丟().Views;
        val_10 = null;
        val_10 = null;
        val_12 = 一下丛与丛丛万万丏.<>c.<>9__53_0;
        if(val_12 == null)
        {
            goto label_16;
        }
        
        if(val_9 != null)
        {
            goto label_21;
        }
        
        goto label_18;
        label_16:
        val_12 = null;
        val_12 = new System.Action<Rilisoft.CraftDetailsView>(object:  一下丛与丛丛万万丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 一下丛与丛丛万万丏.<>c::七万不丂丁丅丞丞且(Rilisoft.CraftDetailsView 丁世丛业丟下丕三丟));
        一下丛与丛丛万万丏.<>c.<>9__53_0 = val_12;
        if(val_9 != null)
        {
            goto label_21;
        }
        
        label_18:
        label_21:
        val_9.ForEach(action:  null);
    }
    private static 一下丛与丛丛万万丏()
    {
        一下丛与丛丛万万丏.丅不丒丛业世专丙下 = 0;
        一下丛与丛丛万万丏.且丑丑丟丄丘世一丐 = 0;
        一下丛与丛丛万万丏.三丒丐丕丕丘丈丐东 = "BOES_ANALICS_EY_wwe";
    }

}
