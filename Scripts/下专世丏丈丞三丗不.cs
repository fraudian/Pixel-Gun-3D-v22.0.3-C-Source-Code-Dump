using UnityEngine;
internal static class 下专世丏丈丞三丗不
{
    // Fields
    internal const int 上丆丅丝丛丈下丞丗 = 10;
    internal const int 丕丄业丗与丘不丒下 = 1000000;
    internal const int 丆丌下丛丈丙下专七 = 3;
    private static System.Collections.Generic.List<string> 丅不一丛七丘丛丄丝;
    internal static readonly string 丁七丌丞丞万丈三丆;
    internal static readonly string 丞丒与丝丈丈丛业丑;
    internal static readonly string 下丏一丕丁丄丏丛丕;
    internal static readonly string 丘丝丂丌万丅丝丟丗;
    internal static readonly string 东且丄一丕专丌丆丐;
    internal static readonly string 丁不丟丒丟丁下丈丆;
    internal static readonly string 丁丁三一七与丑丛专;
    internal static readonly string 丆丟丕不丏七且七万;
    internal static readonly string 丑丒三业丈丌丒丏丛;
    internal static readonly string 丅丈丗万业丘东一丘;
    internal static readonly string[] 东丆万专丈下一丑专;
    internal static readonly string[] 且丙东丄且一丐与万;
    private static System.Action 丌且丈与丆丝丏丞与;
    private static System.Collections.Generic.Dictionary<string, Progress.与丄东丄丘丐丙丅业> 丌丛丛一丙不丌东不;
    
    // Properties
    internal static System.Collections.Generic.List<string> 业丟丑丁业丝世丞丑 { get; }
    internal static int 丞丕丄丘丗与丈东上 { get; }
    internal static string 丛丟丟丗丒丂业丘不 { get; }
    internal static string 丐丁丂上丝丛专世上 { get; }
    
    // Methods
    internal static System.Collections.Generic.List<string> 丗一丁丙丂丅丑丟丆()
    {
        var val_3 = null;
        if(下专世丏丈丞三丗不.丅不一丛七丘丛丄丝 == null)
        {
                下专世丏丈丞三丗不.丅不一丛七丘丛丄丝 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  下专世丏丈丞三丗不.东丆万专丈下一丑专, second:  下专世丏丈丞三丗不.且丙东丄且一丐与万));
            val_3 = null;
        }
        
        val_3 = null;
        return (System.Collections.Generic.List<System.String>)下专世丏丈丞三丗不.丅不一丛七丘丛丄丝;
    }
    internal static int 丝丏与一丞万七一东()
    {
        null = null;
        return (int)ExpController.LevelsForTiers.Length - 1;
    }
    internal static string 上一丘丈丂丐丗下丛()
    {
        return "_OneItem_";
    }
    internal static string 丛丑丝万丐世丒丐丂()
    {
        return "_Up_";
    }
    internal static int 上丘丅丁丐丈上丞丛(string 丞丅上丏丂且下丅与)
    {
        var val_7;
        var val_8;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                return 0;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                val_7 = ExpController.丑七不且上丗丁一世().丆丝丁丞丙上万三一();
        }
        else
        {
                val_7 = 0;
        }
        
        val_8 = null;
        return UnityEngine.Mathf.Min(a:  0, b:  下专世丏丈丞三丗不.丝丏与一丞万七一东());
    }
    internal static string 丕三七丈丈丆七万丆(string 丞丅上丏丂且下丅与, int 七丞丙丒三丕且丌丟)
    {
        var val_2;
        if(丞丅上丏丂且下丅与 != null)
        {
                string val_1 = System.String.Format(format:  "{0}{1}{2}", arg0:  丞丅上丏丂且下丅与, arg1:  "_OneItem_", arg2:  七丞丙丒三丕且丌丟);
            return (string)val_2;
        }
        
        val_2 = 0;
        return (string)val_2;
    }
    internal static string 不丘与东丂与下丆丙(string 丞丅上丏丂且下丅与, int 七丞丙丒三丕且丌丟)
    {
        var val_2;
        if(丞丅上丏丂且下丅与 != null)
        {
                string val_1 = System.String.Format(format:  "{0}{1}{2}", arg0:  丞丅上丏丂且下丅与, arg1:  "_Up_", arg2:  七丞丙丒三丕且丌丟);
            return (string)val_2;
        }
        
        val_2 = 0;
        return (string)val_2;
    }
    internal static string 丐业不丗丞丘丌丘世(string 丞丅上丏丂且下丅与)
    {
        string val_5 = 丞丅上丏丂且下丅与;
        if(val_5 == null)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_2 = 下专世丏丈丞三丗不.丗一丁丙丂丅丑丟丆().GetEnumerator();
        label_8:
        if((1208671432 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if((下专世丏丈丞三丗不.丄丙丑丟下东业丄与(下丅丙一丂丗丅丝七:  val_5 = 丞丅上丏丂且下丅与, 七丞丕下三一丞丑丗:  val_3)) == false)
        {
            goto label_8;
        }
        
        val_5 = val_3;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (string)val_5;
        label_1:
        val_5 = "";
        return (string)val_5;
    }
    internal static int 丞丆丁丛下丅万不丞(string 丞丅上丏丂且下丅与)
    {
        var val_3;
        var val_4;
        if(丞丅上丏丂且下丅与 != null)
        {
                val_3 = null;
            val_3 = null;
            var val_2 = ((丞丅上丏丂且下丅与.Equals(value:  下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑)) != true) ? 5 : 3;
            return (int)val_4;
        }
        
        val_4 = 3;
        return (int)val_4;
    }
    internal static int 丘丌丙不丄上世丌万(string 丞丅上丏丂且下丅与)
    {
        var val_3;
        var val_4;
        if(丞丅上丏丂且下丅与 != null)
        {
                val_3 = null;
            val_3 = null;
            var val_2 = ((丞丅上丏丂且下丅与.Equals(value:  下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑)) != true) ? 10 : 1000000;
            return 1000000;
        }
        
        val_4 = 983040;
        val_4 = 15;
        return 1000000;
    }
    internal static string 一丄上丁丅丕丛丛三(string 下丅丙一丂丗丅丝七, int 丙丐一丕丗万丁下一)
    {
        return (string)System.String.Format(format:  "{0}{1}{2}", arg0:  下丅丙一丂丗丅丝七, arg1:  "_Up_", arg2:  丙丐一丕丗万丁下一);
    }
    private static bool 丄丙丑丟下东业丄与(string 下丅丙一丂丗丅丝七, string 七丞丕下三一丞丑丗)
    {
        string val_19;
        string val_20;
        string val_21;
        val_19 = 七丞丕下三一丞丑丗;
        val_20 = 下丅丙一丂丗丅丝七;
        val_21 = 0;
        int val_10 = 0;
        if((val_20 == null) || (val_19 == null))
        {
            goto label_22;
        }
        
        string val_1 = val_19 + "_Up_";
        string val_2 = val_19 + "_OneItem_";
        if((System.String.op_Equality(a:  val_20, b:  val_19)) == false)
        {
            goto label_7;
        }
        
        label_15:
        val_21 = 1;
        goto label_22;
        label_7:
        if((val_20.StartsWith(value:  val_1)) == false)
        {
            goto label_11;
        }
        
        val_19 = val_20.Length;
        if(val_19 <= val_1.Length)
        {
            goto label_11;
        }
        
        char val_8 = val_20.Chars[val_1.Length];
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  (1209189096 == 0) ? "" : 1209189096, 丙业与丙丗丝不丈东: out  val_10)) == true)
        {
            goto label_15;
        }
        
        label_11:
        if((val_20.StartsWith(value:  val_2)) == false)
        {
            goto label_18;
        }
        
        val_19 = val_20.Length;
        if(val_19 <= val_2.Length)
        {
            goto label_18;
        }
        
        char val_16 = val_20.Chars[val_2.Length];
        val_21 = (1209189096 == 0) ? "" : 1209189096;
        bool val_18 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_21, 丙业与丙丗丝不丈东: out  val_10);
        goto label_22;
        label_18:
        val_21 = 0;
        label_22:
        val_21 = val_21 & 1;
        return (bool)val_21;
    }
    internal static bool 专丞丏东一丗丟下东(string 丆万一不丌且东丐丐)
    {
        var val_6;
        var val_7;
        if(丆万一不丌且东丐丐 == null)
        {
            goto label_5;
        }
        
        var val_6 = 0;
        label_9:
        val_6 = 下专世丏丈丞三丗不.丗一丁丙丂丅丑丟丆();
        if(val_6 >= val_6.Count)
        {
            goto label_5;
        }
        
        val_6 = 下专世丏丈丞三丗不.丗一丁丙丂丅丑丟丆();
        val_6 = val_6 + 1;
        if((下专世丏丈丞三丗不.丄丙丑丟下东业丄与(下丅丙一丂丗丅丝七:  丆万一不丌且东丐丐, 七丞丕下三一丞丑丗:  val_6.Item[0])) == false)
        {
            goto label_9;
        }
        
        val_7 = 1;
        return (bool)val_7;
        label_5:
        val_7 = 0;
        return (bool)val_7;
    }
    internal static int 丏丕丅丆丆丌业万不(string 丞丅上丏丂且下丅与)
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if((下专世丏丈丞三丗不.丌丛丛一丙不丌东不.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return 0;
        }
        
        val_9 = null;
        val_9 = null;
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[丞丅上丏丂且下丅与])) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[丞丅上丏丂且下丅与]));
    }
    internal static void 上丂丟上三丛丄业一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  下专世丏丈丞三丗不.丌且丈与丆丝丏丞与, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(下专世丏丈丞三丗不.丌且丈与丆丝丏丞与 != 1152921505316540520);
    
    }
    internal static void 且丟不丙世上业一且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  下专世丏丈丞三丗不.丌且丈与丆丝丏丞与, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(下专世丏丈丞三丗不.丌且丈与丆丝丏丞与 != 1152921505316540520);
    
    }
    internal static void 丄丗一丑与丑丝万下(string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅)
    {
        int val_4;
        var val_5;
        System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业> val_6;
        var val_7;
        val_4 = 丌丒丝东丌下丕丁丅;
        val_5 = null;
        val_5 = null;
        val_6 = 下专世丏丈丞三丗不.丌丛丛一丙不丌东不;
        if((val_6.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return;
        }
        
        val_7 = null;
        val_6 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_7 = null;
        val_4 = val_4;
        val_6.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[丞丅上丏丂且下丅与], 丙业与丙丗丝不丈东:  val_4);
        if(下专世丏丈丞三丗不.丌且丈与丆丝丏丞与 == null)
        {
                return;
        }
        
        0.Invoke();
    }
    internal static void 丆丕丈丈丝丒丑上丁(string 丞丅上丏丂且下丅与, int 丌世丄七丐一上丒丂)
    {
        var val_11;
        var val_12;
        System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业> val_13;
        var val_14;
        var val_15;
        int val_16;
        var val_17;
        object val_18;
        val_11 = 丌世丄七丐一上丒丂;
        val_12 = null;
        val_12 = null;
        val_13 = 下专世丏丈丞三丗不.丌丛丛一丙不丌东不;
        if((val_13.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[丞丅上丏丂且下丅与])) != false)
        {
                val_15 = null;
            val_15 = null;
            val_16 = (System.Convert.ToInt32(value:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[丞丅上丏丂且下丅与]))) + val_11;
        }
        
        val_17 = null;
        val_13 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_17 = null;
        val_18 = val_16;
        val_13.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[丞丅上丏丂且下丅与], 丙业与丙丗丝不丈东:  val_16);
        if(下专世丏丈丞三丗不.丌且丈与丆丝丏丞与 == null)
        {
                return;
        }
        
        0.Invoke();
    }
    internal static void 丒专丕七丈上业与业(string 丞丅上丏丂且下丅与, int 丑上丏丙不丆丐丗丌)
    {
        string val_11;
        var val_12;
        System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业> val_13;
        var val_14;
        var val_15;
        var val_16;
        val_11 = 丞丅上丏丂且下丅与;
        val_12 = null;
        val_12 = null;
        val_13 = 下专世丏丈丞三丗不.丌丛丛一丙不丌东不;
        if((val_13.ContainsKey(key:  val_11)) == false)
        {
                return;
        }
        
        val_14 = null;
        val_13 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        val_14 = null;
        if((val_13.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[val_11])) == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        Progress.与丄东丄丘丐丙丅业 val_11 = 下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[val_11];
        val_13 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  val_11);
        val_11 = (System.Convert.ToInt32(value:  val_13)) - 丑上丏丙不丆丐丗丌;
        if((val_11 & 2147483648) != 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_11 = 下专世丏丈丞三丗不.丌丛丛一丙不丌东不.Item[val_11];
        val_13 = val_11;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  val_11, 丙业与丙丗丝不丈东:  val_11);
    }
    private static 下专世丏丈丞三丗不()
    {
        下专世丏丈丞三丗不.丁七丌丞丞万丈三丆 = "InvisibilityPotion";
        下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑 = "GrenadeID";
        下专世丏丈丞三丗不.下丏一丕丁丄丏丛丕 = "LikeID";
        下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 = "Jetpack";
        下专世丏丈丞三丗不.东且丄一丕专丌丆丐 = "Turret";
        下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 = "Mech";
        下专世丏丈丞三丗不.丁丁三一七与丑丛专 = "BigHeadPotion";
        下专世丏丈丞三丗不.丆丟丕不丏七且七万 = "Wings";
        下专世丏丈丞三丗不.丑丒三业丈丌丒丏丛 = "Bear";
        下专世丏丈丞三丗不.丅丈丗万业丘东一丘 = "MusicBox";
        string[] val_1 = new string[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if("GrenadeID" != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        label_2:
        label_5:
        val_1[0] = 下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑;
        val_1[1] = 下专世丏丈丞三丗不.丁七丌丞丞万丈三丆;
        val_1[2] = 下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗;
        val_1[3] = 下专世丏丈丞三丗不.东且丄一丕专丌丆丐;
        val_1[4] = 下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆;
        下专世丏丈丞三丗不.东丆万专丈下一丑专 = val_1;
        string[] val_2 = new string[4];
        if(val_2 == null)
        {
            goto label_19;
        }
        
        if("BigHeadPotion" != null)
        {
            goto label_20;
        }
        
        goto label_23;
        label_19:
        label_20:
        label_23:
        val_2[0] = 下专世丏丈丞三丗不.丁丁三一七与丑丛专;
        val_2[1] = 下专世丏丈丞三丗不.丆丟丕不丏七且七万;
        val_2[2] = 下专世丏丈丞三丗不.丅丈丗万业丘东一丘;
        val_2[3] = 下专世丏丈丞三丗不.丑丒三业丈丌丒丏丛;
        下专世丏丈丞三丗不.且丙东丄且一丐与万 = val_2;
        System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业> val_3 = new System.Collections.Generic.Dictionary<System.String, Progress.与丄东丄丘丐丙丅业>();
        val_3.Add(key:  下专世丏丈丞三丗不.丁丁三一七与丑丛专, value:  14);
        val_3.Add(key:  下专世丏丈丞三丗不.丆丟丕不丏七且七万, value:  15);
        val_3.Add(key:  下专世丏丈丞三丗不.丅丈丗万业丘东一丘, value:  17);
        val_3.Add(key:  下专世丏丈丞三丗不.丑丒三业丈丌丒丏丛, value:  16);
        val_3.Add(key:  下专世丏丈丞三丗不.下丏一丕丁丄丏丛丕, value:  18);
        下专世丏丈丞三丗不.丌丛丛一丙不丌东不 = val_3;
    }

}
