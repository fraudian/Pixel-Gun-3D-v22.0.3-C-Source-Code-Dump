using UnityEngine;
internal static class 与业丁丙丒下丕丄东
{
    // Fields
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丁丁丒丆不丒下丟三, int>> 丙丟丛丘丅一上丕丕;
    
    // Methods
    internal static int 丟丏丕上丅丆与七丝(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, 丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if((与业丁丙丒下丕丄东.丙丟丛丘丅一上丕丕.ContainsKey(key:  上且丗一丏丏万丅丌)) != false)
        {
                val_7 = null;
            val_7 = null;
            System.Func<丁丁丒丆不丒下丟三, System.Int32> val_2 = 与业丁丙丒下丕丄东.丙丟丛丘丅一上丕丕.Item[上且丗一丏丏万丅丌];
            if(val_2 != null)
        {
                return val_2.Invoke(arg:  丟业丁且丏万不丗七);
        }
        
            return val_2.Invoke(arg:  丟业丁且丏万不丗七);
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.Log(message:  "для этого режима нету определения победы EndRoundConfigMyPlace используется Default имя режима " + 上且丗一丏丏万丅丌.ToString());
        return (int)与业丁丙丒下丕丄东.与丘业丘丅一下丛三(丞丙下万丗丝丄七丝:  丟业丁且丏万不丗七);
    }
    internal static void 丈与丏丅三丅丒专丁(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_8;
        NetworkStartTable val_9;
        int val_10;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_11;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_12;
        丞丙下万丗丝丄七丝.与丁丅业一丁下丑丕 = new System.Collections.Generic.List<丈万且丗丂丝丙一东>();
        丞丙下万丗丝丄七丝.丝丁上东丞七丐丑万 = new System.Collections.Generic.List<丈万且丗丂丝丙一东>();
        val_8 = 0;
        goto label_3;
        label_18:
        丈万且丗丂丝丙一东 val_3 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0];
        val_9 = val_3.不且上一上丐三万丛;
        val_10 = val_9;
        if(val_10.丘丑丅三丆丑丌且丝() == 1)
        {
                丈万且丗丂丝丙一东 val_5 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0];
            val_9 = val_5.不且上一上丐三万丛;
            val_10 = val_5.不且上一上丐三万丛.丝专不七不丏业世上;
        }
        
        if(val_10 == 2)
        {
            goto label_11;
        }
        
        if(val_10 != 1)
        {
            goto label_12;
        }
        
        val_11 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌;
        val_12 = 丞丙下万丗丝丄七丝.丝丁上东丞七丐丑万;
        if(val_11 != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_11:
        val_11 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌;
        val_12 = 丞丙下万丗丝丄七丝.与丁丅业一丁下丑丕;
        if(val_11 != null)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        val_12.Add(item:  val_11.Item[0]);
        label_12:
        val_8 = 1;
        label_3:
        if(val_8 < 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Count)
        {
            goto label_18;
        }
    
    }
    internal static void 世丒世上业丟丏丝丟(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_6;
        丞丙下万丗丝丄七丝.与丁丅业一丁下丑丕 = new System.Collections.Generic.List<丈万且丗丂丝丙一东>();
        丞丙下万丗丝丄七丝.丝丁上东丞七丐丑万 = new System.Collections.Generic.List<丈万且丗丂丝丙一东>();
        val_6 = 0;
        goto label_9;
        label_13:
        丈万且丗丂丝丙一东 val_3 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0];
        if(val_3.专丛下不丄且丌丛丕 == false)
        {
            goto label_6;
        }
        
        if(丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌 != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        丞丙下万丗丝丄七丝.与丁丅业一丁下丑丕.Add(item:  丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0]);
        val_6 = 1;
        goto label_9;
        label_6:
        if(丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌 != null)
        {
            goto label_10;
        }
        
        goto label_11;
        label_9:
        if(val_6 < 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Count)
        {
            goto label_13;
        }
    
    }
    private static int 与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_4;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_5;
        val_4 = 0;
        goto label_1;
        label_7:
        val_5 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0];
        if(val_5.丟丌下三七丁与丟丑() == true)
        {
                return 0;
        }
        
        val_4 = 1;
        label_1:
        val_5 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌;
        if(val_4 < val_5.Count)
        {
            goto label_7;
        }
        
        return 0;
    }
    private static int 七丅业与不丟丈东丐(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_6;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_7;
        var val_8;
        if(丞丙下万丗丝丄七丝.与丟丙丛东丒丞万丆 != 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        goto label_3;
        label_8:
        val_7 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0];
        if(val_7.丟丌下三七丁与丟丑() == true)
        {
                return (int)val_8;
        }
        
        val_6 = 1;
        label_3:
        val_7 = 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌;
        if(val_6 < val_7.Count)
        {
            goto label_8;
        }
        
        val_8 = 0;
        return (int)val_8;
        label_2:
        val_8 = (GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  27)) - 1;
        return (int)val_8;
    }
    private static int 且三不丌一三业世丛(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_7;
        var val_8;
        int val_9;
        int val_10;
        var val_11;
        if(丞丙下万丗丝丄七丝.丒丒丏丗丁丛丅七丙 <= 0)
        {
            goto label_2;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 1)
        {
            goto label_6;
        }
        
        MiniGamesController val_2 = MiniGamesController.丑七不且上丗丁一世();
        val_9 = val_2.playersOnStart;
        val_10 = val_9 - 1;
        return UnityEngine.Mathf.Max(a:  val_10 = val_3.playersOnStart - val_9, b:  0);
        label_2:
        val_8 = null;
        goto label_16;
        label_6:
        label_16:
        MiniGamesController val_3 = MiniGamesController.丑七不且上丗丁一世();
        val_11 = null;
        val_11 = null;
        val_9 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
        return UnityEngine.Mathf.Max(a:  val_10, b:  0);
    }
    private static int 专下丞七与丕丘业丌(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_6;
        var val_7;
        val_6 = 0;
        goto label_1;
        label_7:
        if(丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Item[0].丟丌下三七丁与丟丑() == true)
        {
            goto label_4;
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < 丞丙下万丗丝丄七丝.丕世上丙一丈丙一丌.Count)
        {
            goto label_7;
        }
        
        label_4:
        val_7 = null;
        val_7 = null;
        return (int)(DungeonsController.丅丌世丗丅专万七丟 >= ScenarioController.丄丘七三上丕世丞业.丞丆上丟专丅丂一丅()) ? (0 + 4) : 0;
    }
    private static int 丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_7;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_8;
        var val_9;
        if(丞丙下万丗丝丄七丝.丁丞丗业丆丒上丈丞 == 2)
        {
            goto label_2;
        }
        
        if(丞丙下万丗丝丄七丝.丁丞丗业丆丒上丈丞 != 1)
        {
                return 0;
        }
        
        val_7 = 0;
        goto label_4;
        label_9:
        val_8 = 丞丙下万丗丝丄七丝.丝丁上东丞七丐丑万.Item[0];
        if(val_8.丟丌下三七丁与丟丑() == true)
        {
                return 0;
        }
        
        val_7 = 1;
        label_4:
        val_8 = 丞丙下万丗丝丄七丝.丝丁上东丞七丐丑万;
        if(val_7 < val_8.Count)
        {
            goto label_9;
        }
        
        return 0;
        label_2:
        val_9 = 0;
        goto label_11;
        label_16:
        val_8 = 丞丙下万丗丝丄七丝.与丁丅业一丁下丑丕.Item[0];
        if(val_8.丟丌下三七丁与丟丑() == true)
        {
                return 0;
        }
        
        val_9 = 1;
        label_11:
        val_8 = 丞丙下万丗丝丄七丝.与丁丅业一丁下丑丕;
        if(val_9 < val_8.Count)
        {
            goto label_16;
        }
        
        return 0;
    }
    private static int 业不且丏丝不一丟万(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        NetworkStartTable val_24;
        var val_25;
        val_17 = null;
        val_17 = null;
        val_18 = null;
        val_18 = null;
        if(null == 0)
        {
            goto label_7;
        }
        
        if(丑丛丆三丆丄七丐万() == 1)
        {
            goto label_8;
        }
        
        label_12:
        val_19 = 丑丛丆三丆丄七丐万();
        if(null == 0)
        {
            goto label_9;
        }
        
        label_13:
        if(丝丈丅一丆丗丝丝丘() == 1)
        {
            goto label_10;
        }
        
        label_14:
        val_20 = 丝丈丅一丆丗丝丝丘();
        goto label_11;
        label_7:
        if(0.丑丛丆三丆丄七丐万() != 1)
        {
            goto label_12;
        }
        
        label_8:
        if(null != 0)
        {
            goto label_13;
        }
        
        label_9:
        if(0.丝丈丅一丆丗丝丝丘() != 1)
        {
            goto label_14;
        }
        
        label_10:
        val_20 = public System.Int32 UnityEngine.Object::GetHashCode();
        label_11:
        val_21 = null;
        val_21 = null;
        if(DuelController.丄丘七三上丕世丞业.opponentNetworkTable == 0)
        {
            goto label_29;
        }
        
        val_22 = null;
        val_22 = null;
        int val_8 = 丑丛丆三丆丄七丐万();
        if(丝丈丅一丆丗丝丝丘() != val_20)
        {
            goto label_29;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() >= 1)
        {
                return 0;
        }
        
        goto label_34;
        label_29:
        val_23 = null;
        val_23 = null;
        val_24 = mem[DuelController.丄丘七三上丕世丞业 + 128];
        val_24 = DuelController.丄丘七三上丕世丞业.opponentNetworkTable;
        if(val_24 == 0)
        {
                return 0;
        }
        
        val_25 = null;
        val_25 = null;
        val_24 = mem[DuelController.丄丘七三上丕世丞业 + 128];
        val_24 = DuelController.丄丘七三上丕世丞业.opponentNetworkTable;
        label_34:
        val_24 = 丑丛丆三丆丄七丐万();
        if(val_24 <= 丑丛丆三丆丄七丐万())
        {
                int val_15 = 丑丛丆三丆丄七丐万();
            if(丝丈丅一丆丗丝丝丘() <= val_20)
        {
                return 0;
        }
        
        }
        
        return 0;
    }
    private static 与业丁丙丒下丕丄东()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丁丁丒丆不丒下丟三, System.Int32>> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丁丁丒丆不丒下丟三, System.Int32>>();
        val_1.Add(key:  0, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  27, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::七丅业与不丟丈东丐(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  26, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  8, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::业不且丏丝不一丟万(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  22, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::专下丞七与丕丘业丌(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  14, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::且三不丌一三业世丛(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  2, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  28, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  4, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  12, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  20, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  11, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  5, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  33, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  18, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  25, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  9, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  3, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  10, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  21, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  7, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  6, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  24, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  23, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  17, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  19, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  13, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  15, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  16, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::丏业东丆丌丝丞丝且(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  1, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        val_1.Add(key:  37, value:  new System.Func<丁丁丒丆不丒下丟三, System.Int32>(object:  0, method:  static System.Int32 与业丁丙丒下丕丄东::与丘业丘丅一下丛三(丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)));
        与业丁丙丒下丕丄东.丙丟丛丘丅一上丕丕 = val_1;
    }

}
