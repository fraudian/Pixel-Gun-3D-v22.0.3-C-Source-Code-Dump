using UnityEngine;
internal static class 丕不三上与丒三丟三
{
    // Fields
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<丕不三上与丒三丟三.世三丐世与一丌丛东, int>> 一七丙丅丑丅丙丙丛;
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<int>> 丕丒东万世丁一丂丞;
    
    // Methods
    internal static int 丐丛丕且东下上丐业(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, 丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        if((丕不三上与丒三丟三.一七丙丅丑丅丙丙丛.ContainsKey(key:  上且丗一丏丏万丅丌)) != false)
        {
                val_9 = null;
            val_9 = null;
            return 丕不三上与丒三丟三.一七丙丅丑丅丙丙丛.Item[上且丗一丏丏万丅丌].Invoke(arg:  new 世三丐世与一丌丛东() {上且丗一丏丏万丅丌 = 下丏丑与丂丛下一丌.上且丗一丏丏万丅丌 & 4294967295});
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.Log(message:  "для этого режима нету определения победы ChooseTeamFactory используется Default имя режима " + 上且丗一丏丏万丅丌.ToString());
        return (int)丕不三上与丒三丟三.丟丙业丞丈丑七三三(下丏丑与丂丛下一丌:  new 世三丐世与一丌丛东() {上且丗一丏丏万丅丌 = 下丏丑与丂丛下一丌.上且丗一丏丏万丅丌 & 4294967295});
    }
    internal static int 丒一不且丂下丅丗丂(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if((丕不三上与丒三丟三.丕丒东万世丁一丂丞.ContainsKey(key:  上且丗一丏丏万丅丌)) == false)
        {
                return 丕不三上与丒三丟三.丒一不且丂下丅丗丂();
        }
        
        val_4 = null;
        System.Func<System.Int32> val_2 = 丕不三上与丒三丟三.丕丒东万世丁一丂丞.Item[上且丗一丏丏万丅丌];
        if(val_2 != null)
        {
                return val_2.Invoke();
        }
        
        return val_2.Invoke();
    }
    private static int 丟丙业丞丈丑七三三(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)
    {
        var val_28;
        var val_29;
        string val_30;
        var val_31;
        var val_32;
        var val_33;
        int val_1 = 丕不三上与丒三丟三.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  1, 丆丘万七一丐上且丅:  true, 丗不下丆丈丌三丛与:  false);
        int val_2 = 丕不三上与丒三丟三.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  2, 丆丘万七一丐上且丅:  true, 丗不下丆丈丌三丛与:  false);
        val_28 = null;
        val_28 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑 == false)
        {
            goto label_34;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = GameConnect.三丌不七丛上丝丂世;
        if((丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_30)) == false)
        {
            goto label_34;
        }
        
        val_31 = null;
        val_31 = null;
        val_30 = GameConnect.三丌不七丛上丝丂世;
        object val_8 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[val_30];
        if(null < 1)
        {
            goto label_34;
        }
        
        val_32 = null;
        val_32 = null;
        object val_11 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[GameConnect.三丌不七丛上丝丂世];
        int val_13 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        val_30 = 丕不三上与丒三丟三.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  1, 丆丘万七一丐上且丅:  false, 丗不下丆丈丌三丛与:  true);
        if(GameConnect.与丂丝丟丟三丑丝万() == true)
        {
                return (int)val_33;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == true)
        {
                return (int)val_33;
        }
        
        var val_19 = ((val_13 < 0) ? (val_13 + 1) : (val_13)) >> 1;
        if(null == 2)
        {
            goto label_33;
        }
        
        if(null == 1)
        {
                if(val_30 < val_19)
        {
            goto label_51;
        }
        
        }
        
        label_34:
        if(val_2 >= val_1)
        {
            goto label_36;
        }
        
        val_33 = 2;
        return (int)val_33;
        label_33:
        if((val_2 < val_1) || ((丕不三上与丒三丟三.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  2, 丆丘万七一丐上且丅:  false, 丗不下丆丈丌三丛与:  true)) < val_19))
        {
                return (int)val_33;
        }
        
        label_36:
        if(val_2 <= val_1)
        {
            goto label_40;
        }
        
        label_51:
        val_33 = 1;
        return (int)val_33;
        label_40:
        int val_20 = 丕不三上与丒三丟三.世业三不丆业丐万丅(与丁丟东丞丙丗丌丈:  1);
        val_33 = 2;
        int val_21 = 丕不三上与丒三丟三.世业三不丆业丐万丅(与丁丟东丞丙丗丌丈:  2);
        if(val_21 < val_20)
        {
                return (int)val_33;
        }
        
        if(((val_21 > val_20) || (GameConnect.一与东丝万上三丆丏() == true)) || (GameConnect.与丂丝丟丟三丑丝万() == true))
        {
            goto label_51;
        }
        
        int val_26 = 丕不三上与丒三丟三.丒一不且丂下丅丗丂(上且丗一丏丏万丅丌:  下丏丑与丂丛下一丌.上且丗一丏丏万丅丌);
        if(val_26 == 0)
        {
                return UnityEngine.Random.Range(min:  1, max:  3);
        }
        
        if(丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙().丒万丂万下七丆丒万() < 0)
        {
                return (int)val_33;
        }
        
        var val_27 = (val_26 == 1) ? (1 + 1) : 1;
        return (int)val_33;
    }
    private static int 上世丟丄丑业丗丝丏(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)
    {
        return 丕不三上与丒三丟三.丟丙业丞丈丑七三三(下丏丑与丂丛下一丌:  new 世三丐世与一丌丛东() {上且丗一丏丏万丅丌 = 下丏丑与丂丛下一丌.上且丗一丏丏万丅丌 & 4294967295});
    }
    private static int 且专一不丁万专丛世(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)
    {
        var val_19;
        var val_20;
        InGameConnection val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_19 = 丕不三上与丒三丟三.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  1, 丆丘万七一丐上且丅:  true, 丗不下丆丈丌三丛与:  true);
        int val_2 = 丕不三上与丒三丟三.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  2, 丆丘万七一丐上且丅:  true, 丗不下丆丈丌三丛与:  true);
        val_20 = null;
        val_20 = null;
        val_21 = GameController.丆丘丂丈世丏丟丑丏;
        if(GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑 == false)
        {
            goto label_28;
        }
        
        val_21 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆();
        val_22 = null;
        val_22 = null;
        if((val_21.ContainsKey(key:  GameConnect.三丌不七丛上丝丂世)) == false)
        {
            goto label_28;
        }
        
        val_23 = null;
        val_21 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆();
        val_23 = null;
        object val_8 = val_21.Item[GameConnect.三丌不七丛上丝丂世];
        if(null < 1)
        {
            goto label_28;
        }
        
        val_24 = null;
        val_24 = null;
        object val_11 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[GameConnect.三丌不七丛上丝丂世];
        int val_13 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        var val_14 = (val_13 < 0) ? (val_13 + 1) : (val_13);
        val_14 = val_14 >> 1;
        if(null == 2)
        {
            goto label_27;
        }
        
        if(null == 1)
        {
                if(val_19 < val_14)
        {
            goto label_29;
        }
        
        }
        
        label_28:
        if(val_2 >= val_19)
        {
            goto label_30;
        }
        
        val_25 = 2;
        return (int)(val_17 == 1) ? (1 + 1) : 1;
        label_27:
        val_25 = 2;
        if(val_2 < val_19)
        {
                return (int)(val_17 == 1) ? (1 + 1) : 1;
        }
        
        if(val_2 < val_14)
        {
                return (int)(val_17 == 1) ? (1 + 1) : 1;
        }
        
        label_30:
        if(val_2 > val_19)
        {
                label_29:
            val_25 = 1;
            return (int)(val_17 == 1) ? (1 + 1) : 1;
        }
        
        val_19 = 丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙();
        val_25 = null;
        int val_17 = 丕不三上与丒三丟三.丒一不且丂下丅丗丂();
        if(val_17 == 0)
        {
                return UnityEngine.Random.Range(min:  1, max:  3);
        }
        
        if(val_19.丒万丂万下七丆丒万() < 0)
        {
                return (int)(val_17 == 1) ? (1 + 1) : 1;
        }
        
        return (int)(val_17 == 1) ? (1 + 1) : 1;
    }
    private static int 不丗上丑丆丏丛丐丅(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)
    {
        if((TeamDuelController.丅丌丛丏丞上万丛丕 == 0) || ((TeamDuelController.丅丌丛丏丞上万丛丕 + 124) < 1))
        {
                return 丕不三上与丒三丟三.丟丙业丞丈丑七三三(下丏丑与丂丛下一丌:  new 世三丐世与一丌丛东() {上且丗一丏丏万丅丌 = 下丏丑与丂丛下一丌.上且丗一丏丏万丅丌 & 4294967295});
        }
        
        if(TeamDuelController.丅丌丛丏丞上万丛丕 != 0)
        {
                return (int)TeamDuelController.丅丌丛丏丞上万丛丕 + 124;
        }
        
        return (int)TeamDuelController.丅丌丛丏丞上万丛丕 + 124;
    }
    private static int 专丐丞丂七下业丘丄(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if(SiegeController.三三万丆下一丗万丛 == 0)
        {
                return 丕不三上与丒三丟三.丟丙业丞丈丑七三三(下丏丑与丂丛下一丌:  new 世三丐世与一丌丛东() {上且丗一丏丏万丅丌 = 下丏丑与丂丛下一丌.上且丗一丏丏万丅丌 & 4294967295});
        }
        
        val_4 = null;
        val_4 = null;
        if((SiegeController.三三万丆下一丗万丛 + 128) < 1)
        {
                return 丕不三上与丒三丟三.丟丙业丞丈丑七三三(下丏丑与丂丛下一丌:  new 世三丐世与一丌丛东() {上且丗一丏丏万丅丌 = 下丏丑与丂丛下一丌.上且丗一丏丏万丅丌 & 4294967295});
        }
        
        val_5 = null;
        val_5 = null;
        if(SiegeController.三三万丆下一丗万丛 != 0)
        {
                return (int)SiegeController.三三万丆下一丗万丛 + 128;
        }
        
        return (int)SiegeController.三三万丆下一丗万丛 + 128;
    }
    internal static int 丛且三丟丟且不丂世(int 与丁丟东丞丙丗丌丈, bool 丆丘万七一丐上且丅, bool 丗不下丆丈丌三丛与 = True)
    {
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        val_25 = 0;
        val_26 = 0;
        goto label_42;
        label_87:
        if(丆丘万七一丐上且丅 == false)
        {
            goto label_71;
        }
        
        val_27 = null;
        val_27 = null;
        NetworkStartTable val_1 = Item[0];
        if(val_1.一七不三丌专三丆一 == true)
        {
            goto label_71;
        }
        
        val_28 = null;
        val_28 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() <= 0)
        {
            goto label_14;
        }
        
        label_71:
        val_29 = null;
        val_29 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() != 与丁丟东丞丙丗丌丈)
        {
            goto label_82;
        }
        
        if(丗不下丆丈丌三丛与 == true)
        {
            goto label_27;
        }
        
        val_30 = null;
        val_30 = null;
        NetworkStartTable val_6 = Item[0];
        if(val_6.一七不三丌专三丆一 == false)
        {
            goto label_27;
        }
        
        val_31 = null;
        val_31 = null;
        NetworkStartTable val_7 = Item[0];
        if(val_7.丗丈东丕不丘三丞业.isScenarioBot == true)
        {
            goto label_82;
        }
        
        val_32 = null;
        val_32 = null;
        NetworkStartTable val_8 = Item[0];
        if(val_8.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 == true)
        {
            goto label_82;
        }
        
        label_27:
        val_26 = 1;
        label_82:
        val_25 = 1;
        goto label_42;
        label_14:
        val_33 = null;
        val_33 = null;
        NetworkStartTable val_9 = Item[0];
        if(val_9.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_71;
        }
        
        val_34 = null;
        val_34 = null;
        NetworkStartTable val_11 = Item[0];
        val_35 = null;
        val_35 = null;
        if((val_11.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.三丌不七丛上丝丂世)) == false)
        {
            goto label_71;
        }
        
        val_36 = null;
        val_36 = null;
        NetworkStartTable val_15 = Item[0];
        val_37 = null;
        val_37 = null;
        object val_18 = val_15.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().Item[GameConnect.三丌不七丛上丝丂世];
        if(null < 1)
        {
            goto label_71;
        }
        
        val_38 = null;
        val_38 = null;
        NetworkStartTable val_19 = Item[0];
        val_39 = null;
        val_39 = null;
        object val_22 = val_19.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().Item[GameConnect.三丌不七丛上丝丂世];
        var val_23 = (null == 与丁丟东丞丙丗丌丈) ? (val_26 + 1) : (val_26);
        goto label_82;
        label_42:
        val_40 = null;
        val_40 = null;
        if(val_25 < Count)
        {
            goto label_87;
        }
        
        return (int)val_26;
    }
    private static int 世业三不丆业丐万丅(int 与丁丟东丞丙丗丌丈)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = 0;
        val_7 = 0;
        goto label_1;
        label_24:
        val_8 = null;
        val_8 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() == 与丁丟东丞丙丗丌丈)
        {
                val_9 = null;
            val_9 = null;
            NetworkStartTable val_3 = Item[0];
            if(val_3.一七不三丌专三丆一 != false)
        {
                val_10 = null;
            val_10 = null;
            NetworkStartTable val_4 = Item[0];
            bool val_6 = val_4.丗丈东丕不丘三丞业.isScenarioBot;
            val_6 = val_6 ^ 1;
            val_7 = val_7 + val_6;
        }
        
        }
        
        val_6 = 1;
        label_1:
        val_11 = null;
        val_11 = null;
        if(val_6 < Count)
        {
            goto label_24;
        }
        
        return (int)val_7;
    }
    private static int 丐丆丆丁丑丈丝丘三()
    {
        null = null;
        if(SiegeController.三三万丆下一丗万丛 != 0)
        {
                return SiegeController.三三万丆下一丗万丛.GetWinningTeam();
        }
        
        return SiegeController.三三万丆下一丗万丛.GetWinningTeam();
    }
    private static int 丒一不且丂下丅丗丂()
    {
        var val_5;
        OnlineModeController val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        val_6 = GameController.onlineMode;
        if(val_6 != 0)
        {
                val_7 = null;
            val_7 = null;
            val_6 = mem[GameController.onlineMode + 360];
            val_6 = GameController.onlineMode.teamController;
            if(val_6 != 0)
        {
                val_8 = null;
            val_8 = null;
            val_9 = 1;
            return (int)val_9;
        }
        
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    private static 丕不三上与丒三丟三()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<世三丐世与一丌丛东, System.Int32>> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<世三丐世与一丌丛东, System.Int32>>();
        val_1.Add(key:  2, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::丟丙业丞丈丑七三三(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  5, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::且专一不丁万专丛世(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  4, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::丟丙业丞丈丑七三三(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  16, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::不丗上丑丆丏丛丐丅(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  17, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::专丐丞丂七下业丘丄(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  28, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::上世丟丄丑业丗丝丏(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  33, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::丟丙业丞丈丑七三三(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        val_1.Add(key:  36, value:  new System.Func<世三丐世与一丌丛东, System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::丟丙业丞丈丑七三三(丕不三上与丒三丟三.世三丐世与一丌丛东 下丏丑与丂丛下一丌)));
        丕不三上与丒三丟三.一七丙丅丑丅丙丙丛 = val_1;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<System.Int32>> val_10 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Func<System.Int32>>();
        val_10.Add(key:  17, value:  new System.Func<System.Int32>(object:  0, method:  static System.Int32 丕不三上与丒三丟三::丐丆丆丁丑丈丝丘三()));
        丕不三上与丒三丟三.丕丒东万世丁一丂丞 = val_10;
    }

}
