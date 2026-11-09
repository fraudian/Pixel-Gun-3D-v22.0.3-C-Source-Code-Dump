using UnityEngine;
public static class 业丘丝上丈万下丕丗
{
    // Fields
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>> 丒丛丗丐丁丄丘丒丕;
    
    // Methods
    internal static 丌丈不下下丘丏丌一 丁丅丂七丝丗与丆一(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, 丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if((业丘丝上丈万下丕丗.丒丛丗丐丁丄丘丒丕.ContainsKey(key:  上且丗一丏丏万丅丌)) != false)
        {
                val_6 = null;
            val_6 = null;
            System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一> val_2 = 业丘丝上丈万下丕丗.丒丛丗丐丁丄丘丒丕.Item[上且丗一丏丏万丅丌];
            if(val_2 != null)
        {
                return val_2.Invoke(arg:  丟业丁且丏万不丗七);
        }
        
            return val_2.Invoke(arg:  丟业丁且丏万不丗七);
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.Log(message:  "для этого режима нету определения победы DeterminationOfTheWinner используется Default имя режима " + 上且丗一丏丏万丅丌.ToString());
        return 0;
    }
    internal static 丌丈不下下丘丏丌一 丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        return 0;
    }
    private static 丌丈不下下丘丏丌一 不丝丙与丒东上上丏(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_15 = null;
        val_15 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.ContainsKey(key:  1)) == false)
        {
            goto label_19;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[1].ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) == false)
        {
            goto label_11;
        }
        
        val_18 = null;
        val_19 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[1];
        val_20 = ExpController.万上一丝丆且七丅丅();
        if(val_19 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_11:
        val_21 = null;
        val_19 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[1];
        val_20 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[1].Count - 1;
        label_18:
        丈丙一世上万一丑不 val_10 = val_19.Item[val_20];
        label_19:
        val_22 = 0;
        val_23 = 1;
        goto label_27;
        label_32:
        丈万且丗丂丝丙一东 val_11 = 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Item[0];
        val_22 = 1;
        val_23 = val_23 & ((val_11.万且丒下丕丝专丟上 < val_10.丆下丈丈不万业丙丘) ? 1 : 0);
        label_27:
        if(val_22 < 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Count)
        {
            goto label_32;
        }
        
        if((val_23 & 1) == 0)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0) ? (1 + 1) : 1;
        }
        
        val_24 = 3;
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 丆万丘丘丕丌世七丅(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_9;
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        val_10 = GameConnect.丕丅丙专丄丙东丘三;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_10)) == false)
        {
            goto label_7;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = GameConnect.丕丅丙专丄丙东丘三;
        val_12 = System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_10]);
        if(丟业丁且丏万不丗七 != null)
        {
            goto label_18;
        }
        
        goto label_17;
        label_7:
        val_12 = 0;
        if(丟业丁且丏万不丗七 != null)
        {
            goto label_18;
        }
        
        label_17:
        label_18:
        if(val_12 != 丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞)
        {
                return (丌丈不下下丘丏丌一)(val_12 < 1) ? (2 + 1) : 2;
        }
        
        val_13 = 1;
        return (丌丈不下下丘丏丌一)(val_12 < 1) ? (2 + 1) : 2;
    }
    private static 丌丈不下下丘丏丌一 丁上丒丝丈丁丐下丞(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        return (丌丈不下下丘丏丌一)((RedLightController.Instance.丙上七丗丁万丙丘不() & true) != 0) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 业东丑丏丒丐丗丞不(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_9;
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        val_10 = GameConnect.丟东丐丐丛丒丕丆七;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_10)) == false)
        {
            goto label_7;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = GameConnect.丟东丐丐丛丒丕丆七;
        val_12 = System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_10]);
        if(丟业丁且丏万不丗七 != null)
        {
            goto label_18;
        }
        
        goto label_17;
        label_7:
        val_12 = 0;
        if(丟业丁且丏万不丗七 != null)
        {
            goto label_18;
        }
        
        label_17:
        label_18:
        if(val_12 != 丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞)
        {
                return (丌丈不下下丘丏丌一)(val_12 < 1) ? (2 + 1) : 2;
        }
        
        val_13 = 1;
        return (丌丈不下下丘丏丌一)(val_12 < 1) ? (2 + 1) : 2;
    }
    private static 丌丈不下下丘丏丌一 丏专丞丆不丌与业不(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_15 = null;
        val_15 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.ContainsKey(key:  0)) == false)
        {
            goto label_19;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[0].ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) == false)
        {
            goto label_11;
        }
        
        val_18 = null;
        val_19 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[0];
        val_20 = ExpController.万上一丝丆且七丅丅();
        if(val_19 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_11:
        val_21 = null;
        val_19 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[0];
        val_20 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[0].Count - 1;
        label_18:
        丈丙一世上万一丑不 val_10 = val_19.Item[val_20];
        label_19:
        val_22 = 0;
        val_23 = 1;
        goto label_27;
        label_32:
        丈万且丗丂丝丙一东 val_11 = 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Item[0];
        val_22 = 1;
        val_23 = val_23 & ((val_11.万且丒下丕丝专丟上 < val_10.丆下丈丈不万业丙丘) ? 1 : 0);
        label_27:
        if(val_22 < 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Count)
        {
            goto label_32;
        }
        
        if((val_23 & 1) == 0)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0) ? (1 + 1) : 1;
        }
        
        val_24 = 3;
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 丄丄丙丞丝丕丒丄丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_7;
        var val_8;
        NetworkStartTable val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_7 = null;
        val_7 = null;
        val_8 = null;
        val_8 = null;
        val_9 = mem[GameController.onlineMode + 352];
        val_9 = GameController.onlineMode.丟三丏丅世一丟丟上;
        if(丑丛丆三丆丄七丐万() == 丑丛丆三丆丄七丐万())
        {
                val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            val_9 = mem[GameController.onlineMode + 352];
            val_9 = GameController.onlineMode.丟三丏丅世一丟丟上;
            if(丝丈丅一丆丗丝丝丘() == 丝丈丅一丆丗丝丝丘())
        {
                val_12 = 3;
            return (丌丈不下下丘丏丌一)val_12;
        }
        
        }
        
        if(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0)
        {
                val_13 = null;
            var val_6 = ((业丘丝上丈万下丕丗.世不业东丏丒七丄丕() & true) != 0) ? (1 + 1) : 1;
            return (丌丈不下下丘丏丌一)val_12;
        }
        
        val_12 = 1;
        return (丌丈不下下丘丏丌一)val_12;
    }
    private static 丌丈不下下丘丏丌一 丁丌一不七丆丌一丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 丘且丂丒丞丛万丕丟(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_2;
        if(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0)
        {
                var val_1 = (丟业丁且丏万不丗七.上丏万东不三一与下 != 1) ? (1 + 1) : 1;
            return (丌丈不下下丘丏丌一)val_2;
        }
        
        val_2 = 1;
        return (丌丈不下下丘丏丌一)val_2;
    }
    private static bool 世不业东丏丒七丄丕()
    {
        var val_3;
        NetworkStartTable val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = mem[DuelController.丄丘七三上丕世丞业 + 128];
        val_4 = DuelController.丄丘七三上丕世丞业.opponentNetworkTable;
        if(val_4 == 0)
        {
                val_5 = 1;
            return (bool)(NetworkStartTable.__il2cppRuntimeField_interopData != 0) ? 1 : 0;
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = mem[DuelController.丄丘七三上丕世丞业 + 128];
        val_4 = DuelController.丄丘七三上丕世丞业.opponentNetworkTable;
        return (bool)(NetworkStartTable.__il2cppRuntimeField_interopData != 0) ? 1 : 0;
    }
    private static 丌丈不下下丘丏丌一 丕丅丅且丗丆七丝丌(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = 0;
        val_9 = 0;
        val_10 = 0;
        goto label_1;
        label_15:
        丈万且丗丂丝丙一东 val_1 = 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Item[0];
        if(val_1.丌与三与三丆丙一丟 > 0)
        {
                丈万且丗丂丝丙一东 val_3 = 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Item[0];
            val_10 = 2;
            val_9 = 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Item[0];
        }
        else
        {
                if(val_2.丌与三与三丆丙一丟 >= 1)
        {
                丈万且丗丂丝丙一东 val_4 = 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Item[0];
            var val_5 = (val_4.丌与三与三丆丙一丟 == 0) ? 3 : (val_10);
        }
        
        }
        
        val_8 = 1;
        label_1:
        if(val_8 < 丟业丁且丏万不丗七.丕世上丙一丈丙一丌.Count)
        {
            goto label_15;
        }
        
        if(val_9 == 0)
        {
                return (丌丈不下下丘丏丌一)val_10;
        }
        
        if(val_9.丟丌下三七丁与丟丑() == false)
        {
                return (丌丈不下下丘丏丌一)val_10;
        }
        
        val_10 = 1;
        return (丌丈不下下丘丏丌一)val_10;
    }
    private static 丌丈不下下丘丏丌一 世丄丝丌七下丆丒丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_3;
        DungeonsController val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = DungeonsController.丄丘七三上丕世丞业;
        if(val_4 != 0)
        {
                val_5 = null;
            val_5 = null;
            val_4 = DungeonsController.丄丘七三上丕世丞业;
            var val_2 = (DungeonsController.丄丘七三上丕世丞业.丕丈业丟丆七上专丟 == false) ? (1 + 1) : 1;
            return (丌丈不下下丘丏丌一)val_6;
        }
        
        val_6 = 2;
        return (丌丈不下下丘丏丌一)val_6;
    }
    private static 丌丈不下下丘丏丌一 丒丌丛不七且丐不一(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        float val_2;
        float val_3;
        var val_4;
        if(丟业丁且丏万不丗七 == null)
        {
            goto label_0;
        }
        
        val_3 = 丟业丁且丏万不丗七.东丙丂丌丒丏丅丄丕;
        val_2 = 丟业丁且丏万不丗七.丘丁七丁不丙不丟上;
        if((int)val_3 > (int)val_2)
        {
            goto label_4;
        }
        
        goto label_2;
        label_0:
        if(0 <= 123372880)
        {
            goto label_3;
        }
        
        goto label_4;
        label_3:
        val_2 = 1.643967E-34f;
        val_3 = 0f;
        label_2:
        if(123372880 <= 0)
        {
            goto label_5;
        }
        
        label_4:
        var val_1 = (丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != 2) ? (1 + 1) : 1;
        return (丌丈不下下丘丏丌一)val_4;
        label_5:
        val_4 = 3;
        return (丌丈不下下丘丏丌一)val_4;
    }
    private static 丌丈不下下丘丏丌一 丘且世丄世东且丘丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        null = null;
        if(丟业丁且丏万不丗七.且七丙丁与丌丗与上 == 0)
        {
                return 2;
        }
        
        return 2;
    }
    private static 丌丈不下下丘丏丌一 专一丄三丅丈丘东且(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.且七丙丁与丌丗与上 != 0) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 丌丏丗丂丈万丁专丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_5;
        float val_6;
        var val_7;
        var val_9;
        if(丟业丁且丏万不丗七 != null)
        {
                val_5 = 丟业丁且丏万不丗七;
            val_6 = 丟业丁且丏万不丗七.东丙丂丌丒丏丅丄丕;
        }
        else
        {
                val_5 = 92;
            val_6 = 0f;
        }
        
        if(val_6 > 丟业丁且丏万不丗七.丘丁七丁不丙不丟上)
        {
                val_7 = 1;
        }
        else
        {
                if(0f < 0)
        {
                val_7 = 2;
        }
        else
        {
                val_7 = 3;
        }
        
        }
        
        if(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != 1)
        {
            goto label_6;
        }
        
        if(val_7 == 1)
        {
            goto label_7;
        }
        
        return (丌丈不下下丘丏丌一)((((val_7 == 2) ? 1 : 0) & ((丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
        label_6:
        var val_2 = (val_7 == 2) ? 1 : 0;
        if((val_7 != 2) || (丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != 2))
        {
            goto label_10;
        }
        
        label_7:
        val_9 = 1;
        return (丌丈不下下丘丏丌一)((((val_7 == 2) ? 1 : 0) & ((丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
        label_10:
        if((丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != 2) || (val_7 != 1))
        {
                return (丌丈不下下丘丏丌一)((((val_7 == 2) ? 1 : 0) & ((丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
        }
        
        val_9 = 2;
        return (丌丈不下下丘丏丌一)((((val_7 == 2) ? 1 : 0) & ((丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
    }
    private static 丌丈不下下丘丏丌一 丂丗东丕丝丐丕丕丁(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_8;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_9;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_10;
        var val_11;
        var val_12;
        var val_14;
        if(丟业丁且丏万不丗七 == null)
        {
            goto label_1;
        }
        
        val_8 = 丟业丁且丏万不丗七;
        if(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != 1)
        {
            goto label_2;
        }
        
        label_4:
        val_9 = 丟业丁且丏万不丗七.丝丁上东丞七丐丑万;
        val_10 = 丟业丁且丏万不丗七.与丁丅业一丁下丑丕;
        val_11 = val_9;
        goto label_3;
        label_1:
        val_8 = 148;
        if(0 == 1)
        {
            goto label_4;
        }
        
        label_2:
        val_10 = 丟业丁且丏万不丗七.与丁丅业一丁下丑丕;
        val_9 = 丟业丁且丏万不丗七.丝丁上东丞七丐丑万;
        val_11 = val_10;
        label_3:
        if(丟业丁且丏万不丗七.与丁丅业一丁下丑丕.SyncRoot.Count >= 1)
        {
                if(((0 == 1) ? (val_10) : (val_9).Count) == 0)
        {
            goto label_14;
        }
        
        }
        
        if(丟业丁且丏万不丗七.东丙丂丌丒丏丅丄丕 > 丟业丁且丏万不丗七.丘丁七丁不丙不丟上)
        {
                val_12 = 1;
        }
        else
        {
                if(丟业丁且丏万不丗七.东丙丂丌丒丏丅丄丕 < 0)
        {
                val_12 = 2;
        }
        else
        {
                val_12 = 3;
        }
        
        }
        
        if(0 != 1)
        {
            goto label_13;
        }
        
        if(val_12 == 1)
        {
            goto label_14;
        }
        
        return (丌丈不下下丘丏丌一)((((val_12 == 2) ? 1 : 0) & ((0 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
        label_13:
        var val_5 = (val_12 == 2) ? 1 : 0;
        if((val_12 != 2) || (0 != 2))
        {
            goto label_17;
        }
        
        label_14:
        val_14 = 1;
        return (丌丈不下下丘丏丌一)((((val_12 == 2) ? 1 : 0) & ((0 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
        label_17:
        if((0 != 2) || (val_12 != 1))
        {
                return (丌丈不下下丘丏丌一)((((val_12 == 2) ? 1 : 0) & ((0 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
        }
        
        val_14 = 2;
        return (丌丈不下下丘丏丌一)((((val_12 == 2) ? 1 : 0) & ((0 == 1) ? 1 : 0)) != 0) ? (2 + 1) : 2;
    }
    private static 丌丈不下下丘丏丌一 丙丌丝丝丙丅且丌东(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        var val_10;
        var val_13;
        float val_14;
        float val_15;
        float val_16;
        if(丟业丁且丏万不丗七 == null)
        {
            goto label_0;
        }
        
        val_10 = 丟业丁且丏万不丗七;
        var val_1 = ((丟业丁且丏万不丗七 + 138 + -1) != 0) ? 1 : 0;
        var val_2 = (丟业丁且丏万不丗七.业丐丈丒丑丗丅丛丏 == true) ? 1 : 0;
        val_2 = val_1 ^ val_2;
        if((val_2 & 1) == 0)
        {
            goto label_1;
        }
        
        label_4:
        var val_3 = (val_1 == 0) ? (1 + 1) : 1;
        if(丟业丁且丏万不丗七 != null)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        label_0:
        val_13 = 137;
        var val_4 = (133 != 0) ? 1 : 0;
        val_10 = 138;
        val_4 = val_4 ^ ((91 != 0) ? 1 : 0);
        if((val_4 & 1) != 0)
        {
            goto label_4;
        }
        
        label_1:
        if((((133 != 0) ? 1 : 0) & 1) == 0)
        {
                if(91 == 0)
        {
            goto label_7;
        }
        
        }
        
        if(丟业丁且丏万不丗七 != null)
        {
                val_14 = 丟业丁且丏万不丗七.丂丅万丅不丗丌丒不;
            val_15 = 丟业丁且丏万不丗七.丆丘丛万与丏丁丐丏;
            var val_7 = (val_14 <= val_15) ? 2 : (0 + 1);
        }
        else
        {
                val_13 = 140;
            val_14 = 0f;
            val_15 = 1.651491E-34f;
        }
        
        if(val_14 == val_15)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
        if(丟业丁且丏万不丗七 != null)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        label_7:
        if(丟业丁且丏万不丗七 != null)
        {
                val_16 = 丟业丁且丏万不丗七.东丙丂丌丒丏丅丄丕;
        }
        else
        {
                val_16 = 0f;
        }
        
        if(val_16 == 丟业丁且丏万不丗七.丘丁七丁不丙不丟上)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
        if(val_16 > 丟业丁且丏万不丗七.丘丁七丁不丙不丟上)
        {
                if(丟业丁且丏万不丗七 != null)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
            return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
        if(丟业丁且丏万不丗七 != null)
        {
                return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
        }
        
        return (丌丈不下下丘丏丌一)(丟业丁且丏万不丗七.丁丞丗业丆丒上丈丞 != ((0f <= (1.651491E-34f)) ? 2 : (0 + 1))) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 业丙三丝东与专上丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        null = null;
        return (丌丈不下下丘丏丌一)(typeof(NetworkStartTable).__il2cppRuntimeField_76 != 0) ? (1 + 1) : 1;
    }
    private static 丌丈不下下丘丏丌一 丕丂丆丁专丛三丑丑(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)
    {
        null = null;
        return (丌丈不下下丘丏丌一)((MonsterHunterModeController.丆丕丝丒不丙且丐丗.丅三丘丞丈丑丄丌丘() & true) != 0) ? (1 + 1) : 1;
    }
    private static 业丘丝上丈万下丕丗()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>>();
        val_1.Add(key:  0, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏专丞丆不丌与业不(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  27, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  26, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  9, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丕丅丅且丗丆七丝丌(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  5, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丒丌丛不七且丐不一(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  33, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丒丌丛不七且丐不一(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  8, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丄丄丙丞丝丕丒丄丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  22, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::世丄丝丌七下丆丒丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  23, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丘且世丄世东且丘丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  21, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::专一丄三丅丈丘东且(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  14, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::业丙三丝东与专上丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  24, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丁丌一不七丆丌一丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  1, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::不丝丙与丒东上上丏(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  10, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丁丌一不七丆丌一丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  4, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丌丏丗丂丈万丁专丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  2, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丌丏丗丂丈万丁专丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  28, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丌丏丗丂丈万丁专丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  16, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丂丗东丕丝丐丕丕丁(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  17, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丙丌丝丝丙丅且丌东(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  19, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丌丏丗丂丈万丁专丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  3, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::业丙三丝东与专上丘(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  20, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丘且丂丒丞丛万丕丟(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  18, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  7, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  6, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  15, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  12, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  11, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  13, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  25, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏业丐下三丒丁丕丄(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  29, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丕丂丆丁专丛三丑丑(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  32, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丏专丞丆不丌与业不(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  36, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丆万丘丘丕丌世七丅(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  37, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::业东丑丏丒丐丗丞不(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        val_1.Add(key:  38, value:  new System.Func<丁丁丒丆不丒下丟三, 丌丈不下下丘丏丌一>(object:  0, method:  static 丌丈不下下丘丏丌一 业丘丝上丈万下丕丗::丁上丒丝丈丁丐下丞(丁丁丒丆不丒下丟三 丟业丁且丏万不丗七)));
        业丘丝上丈万下丕丗.丒丛丗丐丁丄丘丒丕 = val_1;
    }

}
