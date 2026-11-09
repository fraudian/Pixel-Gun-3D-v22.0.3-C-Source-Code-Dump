using UnityEngine;
internal sealed class X10Manager : MonoBehaviour
{
    // Fields
    private const string 丛丂专丂丝丗世世丛 = "X10Manager.X10_Data_Key";
    private static X10Manager 世丒丞七专三与万丕;
    private X10Data 业丅丛丏且丑丄业丙;
    private bool 丙丐丄丛东七丑万丙;
    private float 丂万丒丁丏丛上丞丕;
    private static System.Action 东丕丅丆丝丙丂三专;
    
    // Properties
    internal long 丞丏三丆丞业与丟丁 { get; }
    internal X10Data 丂业丄丟丛丑不丌丙 { get; }
    internal string 世业三丙丒丌丒丗丏 { get; }
    internal bool 丅业东万丌丕上丌丄 { get; }
    internal static X10Manager 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal long 一不上专丌万七不一()
    {
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return 0;
        }
        
        if(this.业丅丛丏且丑丄业丙.IsRunning == false)
        {
                return 0;
        }
        
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
                long val_2 = FriendsController.丝丗专上三不丄丑丑();
            return System.Math.Max(val1:  0, val2:  this.业丅丛丏且丑丄业丙.DateEnd - 专七专下且专三一且.上且一丈丐三丄一丆());
        }
        
        return System.Math.Max(val1:  0, val2:  this.业丅丛丏且丑丄业丙.DateEnd - 专七专下且专三一且.上且一丈丐三丄一丆());
    }
    internal X10Data 丈万上丝丝东业不专()
    {
        this.丘上丐世丆丑且丞丒();
        return (X10Data)this.业丅丛丏且丑丄业丙;
    }
    internal string 与丑丏丅下丁丏丟丛()
    {
        this.丘上丐世丆丑且丞丒();
        return (string)(this.业丅丛丏且丑丄业丙 == 0) ? "basic" : this.业丅丛丏且丑丄业丙.GuiStyle;
    }
    internal bool 丈丐丞丐上丑且丕万()
    {
        System.Collections.Generic.List<System.Int32> val_5;
        var val_6;
        val_5 = this;
        this.丘上丐世丆丑且丞丒();
        if((this.业丅丛丏且丑丄业丙 != null) && (((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.业丅丛丏且丑丄业丙.Id)) != true) && (this.业丅丛丏且丑丄业丙.IsRunning != false)))
        {
                if(this.业丅丛丏且丑丄业丙.GemInappsNotBought != null)
        {
                if(this.业丅丛丏且丑丄业丙.GemInappsNotBought.Count > 0)
        {
                val_6 = 1;
            return (bool)val_6;
        }
        
        }
        
            if(this.业丅丛丏且丑丄业丙.CoinInappsNotBought != null)
        {
                val_5 = this.业丅丛丏且丑丄业丙.CoinInappsNotBought;
            var val_4 = (val_5.Count > 0) ? 1 : 0;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal static X10Manager 丑七不且上丗丁一世()
    {
        X10Manager val_4 = X10Manager.世丒丞七专三与万丕;
        if(val_4 != 0)
        {
                return (X10Manager)X10Manager.世丒丞七专三与万丕;
        }
        
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "X10Manager");
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        X10Manager.世丒丞七专三与万丕 = val_2.AddComponent<X10Manager>();
        val_4 = X10Manager.世丒丞七专三与万丕;
        val_4.丘上丐世丆丑且丞丒();
        return (X10Manager)X10Manager.世丒丞七专三与万丕;
    }
    internal static void 丄专丂专丑一丂丙丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  X10Manager.东丕丅丆丝丙丂三专, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(X10Manager.东丕丅丆丝丙丂三专 != 1152921505291886600);
    
    }
    internal static void 东丑三丐业业业丄业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  X10Manager.东丕丅丆丝丙丂三专, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(X10Manager.东丕丅丆丝丙丂三专 != 1152921505291886600);
    
    }
    internal void 丝三世丈丑丕业丈世(string 丏丂不专上丘丂不丅)
    {
        System.Object[] val_4;
        var val_5;
        val_4 = this;
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丏丂不专上丘丂不丅)) != false)
        {
                val_4 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "SetSaught currency.IsNullOrEmpty()", args:  val_4);
            return;
        }
        
        val_5 = null;
        val_5 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                if(this.业丅丛丏且丑丄业丙.SaughtGems == true)
        {
                return;
        }
        
            this.业丅丛丏且丑丄业丙.SaughtGems = true;
        }
        else
        {
                if(this.业丅丛丏且丑丄业丙.SaughtCoins == true)
        {
                return;
        }
        
            this.业丅丛丏且丑丄业丙.SaughtCoins = true;
        }
        
        this.业丗上丑丐丑不上且();
        this.丑丈丒与不七上丞丗();
    }
    internal bool 丛世丟世丅七万丄不(string 丏丂不专上丘丂不丅)
    {
        System.Object[] val_5;
        var val_6;
        var val_7;
        bool val_8;
        val_5 = this;
        if(this.业丅丛丏且丑丄业丙 == null)
        {
            goto label_1;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丏丂不专上丘丂不丅)) == false)
        {
            goto label_4;
        }
        
        val_5 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "IsSaught currency.IsNullOrEmpty()", args:  val_5);
        label_1:
        val_6 = 1;
        return (bool)(val_8 == true) ? 1 : 0;
        label_4:
        val_7 = null;
        val_7 = null;
        val_5 = this.业丅丛丏且丑丄业丙;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                val_8 = this.业丅丛丏且丑丄业丙.SaughtGems;
            return (bool)(val_8 == true) ? 1 : 0;
        }
        
        val_8 = this.业丅丛丏且丑丄业丙.SaughtCoins;
        return (bool)(val_8 == true) ? 1 : 0;
    }
    internal int 上丏丐下上专丄不丛()
    {
        System.Object[] val_2;
        int val_3;
        val_2 = this;
        if(this.业丅丛丏且丑丄业丙 != null)
        {
                val_3 = this.业丅丛丏且丑丄业丙.BoughtNum;
            return (int)val_3;
        }
        
        val_2 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "BoughtNum: _currentData == null", args:  val_2);
        val_3 = 0;
        return (int)val_3;
    }
    internal bool 丑丅丞丝丕丕丞丈专()
    {
        this.丘上丐世丆丑且丞丒();
        if(((this.业丅丛丏且丑丄业丙 == null) || (this.业丅丛丏且丑丄业丙.IsRunning == false)) || (this.业丅丛丏且丑丄业丙.CoinInappsNotBought == null))
        {
                return false;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.业丅丛丏且丑丄业丙.Id)) != false)
        {
                return false;
        }
        
        var val_3 = (this.业丅丛丏且丑丄业丙.CoinInappsNotBought.Count > 0) ? 1 : 0;
        return false;
    }
    internal bool 丗丘丌一丞丝丂丟丒()
    {
        this.丘上丐世丆丑且丞丒();
        if(((this.业丅丛丏且丑丄业丙 == null) || (this.业丅丛丏且丑丄业丙.IsRunning == false)) || (this.业丅丛丏且丑丄业丙.GemInappsNotBought == null))
        {
                return false;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.业丅丛丏且丑丄业丙.Id)) != false)
        {
                return false;
        }
        
        var val_3 = (this.业丅丛丏且丑丄业丙.GemInappsNotBought.Count > 0) ? 1 : 0;
        return false;
    }
    internal bool 一三丄一丄下丂不丞(int 世丈三丐丞一丒丛不)
    {
        this.丘上丐世丆丑且丞丒();
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return false;
        }
        
        if(this.业丅丛丏且丑丄业丙.IsRunning == false)
        {
                return false;
        }
        
        if(this.业丅丛丏且丑丄业丙.CoinInappsNotBought == null)
        {
                return false;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.业丅丛丏且丑丄业丙.Id)) != false)
        {
                return false;
        }
        
        if(this.业丅丛丏且丑丄业丙.CoinInappsNotBought != null)
        {
                return this.业丅丛丏且丑丄业丙.CoinInappsNotBought.Contains(item:  世丈三丐丞一丒丛不);
        }
        
        return this.业丅丛丏且丑丄业丙.CoinInappsNotBought.Contains(item:  世丈三丐丞一丒丛不);
    }
    internal bool 业丑丕丐一丒丙上丘(int 世丈三丐丞一丒丛不)
    {
        this.丘上丐世丆丑且丞丒();
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return false;
        }
        
        if(this.业丅丛丏且丑丄业丙.IsRunning == false)
        {
                return false;
        }
        
        if(this.业丅丛丏且丑丄业丙.GemInappsNotBought == null)
        {
                return false;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.业丅丛丏且丑丄业丙.Id)) != false)
        {
                return false;
        }
        
        if(this.业丅丛丏且丑丄业丙.GemInappsNotBought != null)
        {
                return this.业丅丛丏且丑丄业丙.GemInappsNotBought.Contains(item:  世丈三丐丞一丒丛不);
        }
        
        return this.业丅丛丏且丑丄业丙.GemInappsNotBought.Contains(item:  世丈三丐丞一丒丛不);
    }
    internal void 万一不丒上下丟丏一(int 世丈三丐丞一丒丛不)
    {
        X10Data val_2;
        int val_3;
        this.丘上丐世丆丑且丞丒();
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return;
        }
        
        if(this.业丅丛丏且丑丄业丙.CoinInappsNotBought == null)
        {
                return;
        }
        
        if((this.业丅丛丏且丑丄业丙.CoinInappsNotBought.Remove(item:  世丈三丐丞一丒丛不)) == false)
        {
                return;
        }
        
        val_2 = this.业丅丛丏且丑丄业丙;
        if(val_2 != null)
        {
                val_3 = this.业丅丛丏且丑丄业丙.BoughtNum;
        }
        else
        {
                val_2 = 16;
            val_3 = 11993091;
        }
        
        mem[16] = 11993092;
        this.业丗上丑丐丑不上且();
        this.丑丈丒与不七上丞丗();
    }
    internal void 上丟七丅丐与且丁东(int 世丈三丐丞一丒丛不)
    {
        X10Data val_2;
        int val_3;
        this.丘上丐世丆丑且丞丒();
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return;
        }
        
        if(this.业丅丛丏且丑丄业丙.GemInappsNotBought == null)
        {
                return;
        }
        
        if((this.业丅丛丏且丑丄业丙.GemInappsNotBought.Remove(item:  世丈三丐丞一丒丛不)) == false)
        {
                return;
        }
        
        val_2 = this.业丅丛丏且丑丄业丙;
        if(val_2 != null)
        {
                val_3 = this.业丅丛丏且丑丄业丙.BoughtNum;
        }
        else
        {
                val_2 = 16;
            val_3 = 11993091;
        }
        
        mem[16] = 11993092;
        this.业丗上丑丐丑不上且();
        this.丑丈丒与不七上丞丗();
    }
    internal void 丁丆丈丌三丏丐东丘(System.Collections.Generic.Dictionary<string, object> 丄下丌东丑丄丟丞丑)
    {
        bool val_18;
        var val_94;
        System.Object[] val_95;
        string val_96;
        string val_98;
        long val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        var val_105;
        object val_106;
        var val_107;
        var val_108;
        System.Collections.Generic.List<T> val_111;
        var val_112;
        System.Comparison<X10Rule> val_114;
        X10Rule val_115;
        var val_116;
        object val_117;
        var val_118;
        System.Collections.Generic.List<System.Int32> val_119;
        var val_120;
        System.Collections.Generic.List<System.Int32> val_121;
        object val_8 = 0;
        string val_2 = 0;
        object val_11 = 0;
        System.Collections.Generic.List<System.Object> val_31 = 0;
        int val_41 = 0;
        int val_45 = 0;
        val_94;
        if(丄下丌东丑丄丟丞丑 != null)
        {
                new X10Manager.丘丞三且东万丕丙丂() = new X10Manager.丘丞三且东万丕丙丂();
            this.丘上丐世丆丑且丞丒();
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  丄下丌东丑丄丟丞丑, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_2)) != false)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == false)
        {
            goto label_7;
        }
        
        }
        
            object[] val_5 = new object[1];
            val_95 = val_5;
            val_95[0] = (val_2 == 0) ? "null" : (val_2);
            UnityEngine.Debug.LogWarningFormat(format:  "SetAction actionConfig no id key || id.IsNullOrEmpty(), id = {0}", args:  val_5);
            return;
        }
        
        val_95 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "SetAction actionConfig == null", args:  val_95);
        return;
        label_7:
        bool val_10 = (val_8 != 0) ? 1 : 0;
        val_10 = (丄下丌东丑丄丟丞丑.TryGetValue(key:  "date_start", value: out  val_8)) & val_10;
        bool val_13 = (val_11 != 0) ? 1 : 0;
        if(val_10 != false)
        {
                val_96 = val_8;
            if((val_96 != 0) && (1179403647 != null))
        {
                val_96 = 0;
        }
        
            System.DateTime val_15 = 专七专下且专三一且.下上且七专丁丛与丄(业丄万丁丒上丛东丛:  val_96);
            System.TimeSpan val_16 = val_15.dateData.Subtract(value:  new System.DateTime());
            double val_17 = val_16._ticks.TotalSeconds;
        }
        
        val_13 = (丄下丌东丑丄丟丞丑.TryGetValue(key:  "date_end", value: out  val_11)) & val_13;
        if(val_13 != false)
        {
                val_98 = val_11;
            if((val_98 != 0) && (1179403647 != null))
        {
                val_98 = 0;
        }
        
            System.DateTime val_19 = 专七专下且专三一且.下上且七专丁丛与丄(业丄万丁丒上丛东丛:  val_98);
            System.TimeSpan val_20 = val_19.dateData.Subtract(value:  new System.DateTime());
            val_99 = (long)val_20._ticks.TotalSeconds;
        }
        else
        {
                val_99 = 0;
        }
        
        val_100 = "basic";
        if((丄下丌东丑丄丟丞丑.ContainsKey(key:  "gui")) != false)
        {
                object val_23 = 丄下丌东丑丄丟丞丑.Item["gui"];
            string val_25 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_23)) != true) ? (val_100) : (val_23);
        }
        
        if((this.业丅丛丏且丑丄业丙 == null) || ((System.String.op_Equality(a:  val_2, b:  this.业丅丛丏且丑丄业丙.Id)) == false))
        {
            goto label_34;
        }
        
        if((System.String.op_Inequality(a:  this.业丅丛丏且丑丄业丙.GuiStyle, b:  val_25)) == false)
        {
            goto label_36;
        }
        
        this.业丅丛丏且丑丄业丙.GuiStyle = val_25;
        val_101 = 1;
        if(val_10 == true)
        {
            goto label_38;
        }
        
        goto label_110;
        label_34:
        if(val_13 == false)
        {
            goto label_40;
        }
        
        if(val_10 == false)
        {
            goto label_41;
        }
        
        bool val_30 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丄下丌东丑丄丟丞丑, 下上丐丆丝丟丝丒不:  "period", 丙业与丙丗丝不丈东: out  0);
        if(val_30 == false)
        {
            goto label_44;
        }
        
        bool val_32 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  丄下丌东丑丄丟丞丑, 下上丐丆丝丟丝丒不:  "rules", 丙业与丙丗丝不丈东: out  val_31);
        if(((val_31 == 0) || (val_32 ^ 1 == true)) || (val_31.Count == 0))
        {
            goto label_49;
        }
        
        System.Collections.Generic.List<X10Rule> val_37 = new System.Collections.Generic.List<X10Rule>();
        List.Enumerator<T> val_38 = System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Cast<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_31)).GetEnumerator();
        label_88:
        if((739274432 & 1) == 0)
        {
            goto label_51;
        }
        
        string val_40 = 0.丐丏七丌丕丗业且上();
        if(val_40 == null)
        {
            goto label_52;
        }
        
        bool val_43 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_40, 下上丐丆丝丟丝丒不:  "dollars_spent", 丙业与丙丗丝不丈东: out  val_41);
        if(val_43 == false)
        {
            goto label_55;
        }
        
        val_102 = null;
        val_102 = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_40, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丙业与丙丗丝不丈东: out  val_41)) == false)
        {
            goto label_60;
        }
        
        val_103 = null;
        val_103 = null;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_40, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丙业与丙丗丝不丈东: out  val_45)) == false)
        {
            goto label_65;
        }
        
        new X10Rule() = new X10Rule();
        if(new X10Rule() == null)
        {
            goto label_66;
        }
        
        .DollarsSpent = 0;
        .GemsFirstInappCost = 0;
        val_104 = val_45;
        goto label_67;
        label_52:
        UnityEngine.Debug.LogErrorFormat(format:  "null value in rules", args:  System.Array.Empty<System.Object>());
        goto label_88;
        label_55:
        object[] val_49 = new object[2];
        val_18 = val_43;
        val_49[0] = val_18;
        val_49[1] = 0;
        UnityEngine.Debug.LogErrorFormat(format:  "no dollarsSpent or incorrect, dollarsSpentResult = {0}, dollarsSpent = {1}", args:  val_49);
        goto label_88;
        label_60:
        UnityEngine.Debug.LogErrorFormat(format:  "no gems", args:  System.Array.Empty<System.Object>());
        goto label_88;
        label_65:
        UnityEngine.Debug.LogErrorFormat(format:  "no coins", args:  System.Array.Empty<System.Object>());
        goto label_88;
        label_66:
        .DollarsSpent = 0;
        mem[24] = 0;
        val_104 = val_45;
        label_67:
        .CoinsFirstInappCost = 0;
        null.Add(item:  new X10Rule());
        goto label_88;
        label_40:
        object[] val_52 = new object[2];
        val_18 = val_13;
        val_52[0] = val_18;
        val_52[1] = val_99;
        UnityEngine.Debug.LogErrorFormat(format:  "SetAction x10: no dateEnd or incorrect dateEnd: result = {0} dateEnd = {1}", args:  val_52);
        return;
        label_41:
        object[] val_53 = new object[2];
        val_18 = val_10;
        val_53[0] = val_18;
        val_53[1] = 0;
        UnityEngine.Debug.LogErrorFormat(format:  "SetAction x10: no dateStart or incorrect dateStart: result = {0} dateStart = {1}", args:  val_53);
        return;
        label_36:
        val_101 = 0;
        if(val_10 == false)
        {
            goto label_110;
        }
        
        label_38:
        if(val_13 != false)
        {
                if((val_99 != this.业丅丛丏且丑丄业丙.DateEnd) || (0 != this.业丅丛丏且丑丄业丙.DateStart))
        {
            goto label_114;
        }
        
        }
        
        label_110:
        if(val_101 == 0)
        {
                return;
        }
        
        goto label_121;
        label_114:
        this.业丅丛丏且丑丄业丙.DateStart = 0;
        this.业丅丛丏且丑丄业丙.DateEnd = val_99;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_121;
        }
        
        if(this.业丅丛丏且丑丄业丙.DateStart <= FriendsController.丝丗专上三不丄丑丑())
        {
            goto label_125;
        }
        
        val_105 = 0;
        goto label_126;
        label_44:
        object[] val_56 = new object[2];
        val_18 = val_30;
        val_56[0] = val_18;
        val_56[1] = 0;
        UnityEngine.Debug.LogErrorFormat(format:  "SetAction x10: no period or incorrect period, result = {0} period = {1}", args:  val_56);
        return;
        label_49:
        object[] val_57 = new object[2];
        val_57[0] = val_32;
        if(val_31 == 0)
        {
            goto label_141;
        }
        
        val_106 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_31);
        goto label_142;
        label_125:
        label_126:
        this.业丅丛丏且丑丄业丙.IsRunning = (FriendsController.丝丗专上三不丄丑丑() < this.业丅丛丏且丑丄业丙.DateEnd) ? 1 : 0;
        label_121:
        this.业丗上丑丐丑不上且();
        this.丑丈丒与不七上丞丗();
        return;
        label_141:
        val_106 = "null";
        label_142:
        val_57[1] = val_106;
        UnityEngine.Debug.LogErrorFormat(format:  "SetAction x10 no rules, or empty rules, result = {0}, rules = {1}", args:  val_57);
        return;
        label_51:
        val_107 = 0;
        val_108 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_224;
        }
        
        val_111 = null;
        if( == false)
        {
            goto label_228;
        }
        
        if(1003 != 1003)
        {
            goto label_226;
        }
        
        goto label_228;
        label_224:
        val_111 = null;
        if( == false)
        {
            goto label_228;
        }
        
        label_226:
        label_228:
        if(null.Count == 0)
        {
            goto label_230;
        }
        
        val_112 = null;
        val_112 = null;
        val_114 = X10Manager.<>c.<>9__27_0;
        if(val_114 == null)
        {
                val_111 = null;
            val_114 = null;
            val_114 = new System.Comparison<X10Rule>(object:  X10Manager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 X10Manager.<>c::丟丘丆且丂东丝丐丁(X10Rule 下丄丛丘丕专丛丌上, X10Rule 丆丈丞丆丟下丌丛不));
            X10Manager.<>c.<>9__27_0 = val_114;
        }
        
        null.Sort(comparison:  null);
        System.DateTime val_64 = System.DateTime.UtcNow;
        System.TimeSpan val_65 = System.TimeSpan.FromDays(value:  0);
        System.DateTime val_66 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = val_64.dateData}, t:  new System.TimeSpan() {_ticks = val_65._ticks});
        decimal val_68 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丘丁丈万丗丑丈东七(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_66.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_64.dateData});
        mem2[0] = System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_68.flags, hi = val_68.hi, lo = val_68.lo, mid = val_68.mid});
        System.Func<X10Rule, System.Boolean> val_70 = new System.Func<X10Rule, System.Boolean>(object:  null, method:  System.Boolean X10Manager.丘丞三且东万丕丙丂::上丕丙世丌丅丐丂丘(X10Rule 丒专丑丒丁丞三丆业));
        val_115 = System.Linq.Enumerable.FirstOrDefault<X10Rule>(source:  null, predicate:  null);
        if(val_115 == null)
        {
            goto label_247;
        }
        
        val_116 = ;
        mem2[0] = val_115;
        goto label_253;
        label_230:
        object[] val_72 = new object[1];
        if(val_31 == 0)
        {
            goto label_249;
        }
        
        val_117 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_31);
        goto label_250;
        label_247:
        val_115 = null.Item[null.Count - 1];
        val_116 = ;
        mem2[0] = val_115;
        label_253:
        if(val_115.GemsEnabled != false)
        {
                val_118 = null;
            val_118 = null;
            System.Func<System.Int32, System.Boolean> val_78 = new System.Func<System.Int32, System.Boolean>(object:  null, method:  System.Boolean X10Manager.丘丞三且东万丕丙丂::丌世丒丝丁丗不丆丂(int 世丈三丐丞一丒丛不));
            val_119 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.SkipWhile<System.Int32>(source:  丏丄丑上丛不丈且万.丅丂上丞上专一丗丏, predicate:  null));
        }
        else
        {
                val_119 = null;
            val_119 = new System.Collections.Generic.List<System.Int32>();
        }
        
        if((X0 + 24.CoinsEnabled) != false)
        {
                val_120 = null;
            val_120 = null;
            System.Func<System.Int32, System.Boolean> val_83 = new System.Func<System.Int32, System.Boolean>(object:  null, method:  System.Boolean X10Manager.丘丞三且东万丕丙丂::丞丏丏丕丅一丌丂丂(int 世丈三丐丞一丒丛不));
            val_121 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.SkipWhile<System.Int32>(source:  丏丄丑上丛不丈且万.丟世下上不下丘丄丒, predicate:  null));
        }
        else
        {
                val_121 = null;
            val_121 = new System.Collections.Generic.List<System.Int32>();
        }
        
        long val_87 = FriendsController.丝丗专上三不丄丑丑();
        new X10Data() = new System.Object();
        if(new X10Data() != null)
        {
                .Id = val_2;
            .DateEnd = val_99;
            .DateStart = 0;
            .GemInappsNotBought = val_119;
            .Period = 0;
            .Rules = null;
        }
        else
        {
                mem[64] = val_2;
            .Period = 0;
            mem[40] = 0;
            mem[32] = val_99;
            mem[80] = null;
            mem[56] = val_119;
        }
        
        var val_89 = (val_87 > 0) ? 1 : 0;
        val_89 = ((0 <= val_87) ? 1 : 0) & val_89;
        bool val_92 = ((val_87 < val_99) ? 1 : 0) & val_89;
        .CoinInappsNotBought = val_121;
        if(new X10Data() != null)
        {
                .IsRunning = val_92;
            .BoughtNum = 0;
        }
        else
        {
                mem[72] = val_92;
            mem[16] = 0;
        }
        
        .GuiStyle = val_25;
        public System.Boolean List.Enumerator<System.Collections.Generic.Dictionary<System.String, System.Object>>::MoveNext().__il2cppRuntimeField_18 = new X10Data();
        业丗上丑丐丑不上且();
        丑丈丒与不七上丞丗();
        return;
        label_249:
        val_117 = "null";
        label_250:
        val_72[0] = val_117;
        UnityEngine.Debug.LogErrorFormat(format:  "x10Rules.Count == 0, rulesUncasted = {0}", args:  val_72);
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_5;
        if(this.丙丐丄丛东七丑万丙 == true)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "X10Manager.X10_Data_Key")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "X10Manager.X10_Data_Key", 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        string val_2 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "X10Manager.X10_Data_Key");
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) != false)
        {
                val_5 = 0;
        }
        
        this.业丅丛丏且丑丄业丙 = UnityEngine.JsonUtility.FromJson<X10Data>(json:  val_2);
        this.丙丐丄丛东七丑万丙 = true;
    }
    private void 业丗上丑丐丑不上且()
    {
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return;
        }
        
        this = UnityEngine.JsonUtility.ToJson(obj:  this.业丅丛丏且丑丄业丙);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "X10Manager.X10_Data_Key", 下下丏一丙不丘丌丞:  this);
    }
    private void 丑丈丒与不七上丞丗()
    {
        if(X10Manager.东丕丅丆丝丙丂三专 == null)
        {
                return;
        }
        
        X10Manager.东丕丅丆丝丙丂三专.Invoke();
    }
    private void Awake()
    {
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void X10Manager::专丈且丆丄专丒丁丅()));
    }
    private void Start()
    {
        PGCompany.丒丒丛丙不万专三丆 val_1 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        val_1.丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void X10Manager::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        val_1.丞七丁三万世丒下东();
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        PGCompany.ConfigId val_1 = 丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝();
        if(val_1 != 34)
        {
                return;
        }
        
        val_1.丞七丁三万世丒下东();
    }
    private void 丞七丁三万世丒下东()
    {
        string val_7;
        var val_8;
        string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  34);
        val_7 = val_2;
        if((System.String.IsNullOrEmpty(value:  val_2)) == true)
        {
                return;
        }
        
        object val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_7);
        val_8 = 0;
        if(val_7 == null)
        {
                return;
        }
        
        val_7 = X10Manager.丑七不且上丗丁一世();
        val_7.丁丆丈丌三丏丐东丘(丄下丌东丑丄丟丞丑:  null);
    }
    internal void 且且万东丆世且七丟()
    {
        this.丙丐丄丛东七丑万丙 = false;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "X10Manager.X10_Data_Key", 下下丏一丙不丘丌丞:  "");
        丞七丁三万世丒下东();
    }
    private void 专丈且丆丄专丒丁丅()
    {
        string val_5;
        X10Data val_6;
        var val_7;
        this.丘上丐世丆丑且丞丒();
        long val_1 = FriendsController.丝丗专上三不丄丑丑();
        if(this.业丅丛丏且丑丄业丙 == null)
        {
                return;
        }
        
        val_5 = this.业丅丛丏且丑丄业丙.Id;
        if((val_1 & 9223372036854775808) != 0)
        {
                return;
        }
        
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) ^ 1) == false)
        {
                return;
        }
        
        val_6 = this.业丅丛丏且丑丄业丙;
        if(val_6 != null)
        {
                val_5 = this.业丅丛丏且丑丄业丙.IsRunning;
        }
        else
        {
                val_5 = this.业丅丛丏且丑丄业丙.IsRunning;
            if(this.业丅丛丏且丑丄业丙 != null)
        {
                val_6 = this.业丅丛丏且丑丄业丙;
        }
        else
        {
                val_6 = 0;
        }
        
        }
        
        if(135970152 > val_1)
        {
                val_7 = 0;
        }
        else
        {
                bool val_4 = (val_1 < this.业丅丛丏且丑丄业丙.DateEnd) ? 1 : 0;
        }
        
        if(val_4 == val_5)
        {
                return;
        }
        
        val_5 = this.业丅丛丏且丑丄业丙;
        this.业丅丛丏且丑丄业丙.IsRunning = val_4;
        this.业丗上丑丐丑不上且();
        this.丑丈丒与不七上丞丗();
    }
    private void OnDestroy()
    {
        FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void X10Manager::专丈且丆丄专丒丁丅()));
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丂万丒丁丏丛上丞丕;
        if(val_1 < 1f)
        {
                return;
        }
        
        this.专丈且丆丄专丒丁丅();
        this.丂万丒丁丏丛上丞丕 = UnityEngine.Time.realtimeSinceStartup;
    }
    public X10Manager()
    {
        this.丂万丒丁丏丛上丞丕 = -3.402823E+38f;
    }

}
