using UnityEngine;
internal class 专上丈丌丒丁丒丆三
{
    // Fields
    internal static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<int, 丈丙一世上万一丑不>> 一丏下丙丛丒丈万与;
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<int, 丈丙一世上万一丑不>> 丌丙世丛下丏丆丕丝;
    internal static int 万且丁丌丆下丄丛丄;
    internal static int 丈丐丟丐丙七东业丒;
    
    // Methods
    internal static 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 丒丐丟丆下七丛丑丕(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_62;
        var val_63;
        var val_64;
        var val_65;
        int val_66;
        var val_67;
        var val_68;
        var val_69;
        int val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        丈丙一世上万一丑不 val_75;
        var val_76;
        var val_77;
        object val_78;
        var val_79;
        var val_80;
        int val_81;
        var val_82;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        int val_89;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_90;
        上丑丝丌七不丙丗丅 val_0;
        val_62 = 上且丗一丏丏万丅丌;
        System.Collections.Generic.Dictionary<System.Int32, 丈丙一世上万一丑不> val_16 = 0;
        val_63 = null;
        val_63 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.ContainsKey(key:  val_62)) == false)
        {
            goto label_4;
        }
        
        val_64 = null;
        val_64 = null;
        val_65 = 1152921505175109632;
        val_66 = 1152921524297421296;
        val_67 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_62].ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) == false)
        {
            goto label_11;
        }
        
        val_68 = null;
        val_69 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_62];
        val_70 = ExpController.万上一丝丆且七丅丅();
        if(val_69 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_4:
        val_71 = 0;
        val_72 = 0;
        goto label_19;
        label_11:
        val_73 = null;
        val_69 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_62];
        val_70 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_62].Count - 1;
        label_18:
        val_74 = 1152921524297435632;
        val_75 = val_69.Item[val_70];
        if(val_62 != 22)
        {
            goto label_50;
        }
        
        val_76 = null;
        val_76 = null;
        if(DungeonsController.丄丘七三上丕世丞业 != 0)
        {
                val_77 = null;
            val_77 = null;
            val_78 = DungeonsController.丄丘七三上丕世丞业.dungeonDifficulty;
        }
        else
        {
                val_78 = 1;
        }
        
        val_79 = null;
        val_79 = null;
        if(GameController.丆丘丂丈世丏丟丑丏 == 0)
        {
            goto label_40;
        }
        
        val_80 = val_65;
        goto label_42;
        label_40:
        val_81 = System.String.alignConst;
        goto label_43;
        label_42:
        val_66 = val_66;
        val_65 = ;
        val_74 = 1152921524297435632;
        val_81 = 丙且上丒不下丑下丞();
        label_43:
        val_82 = null;
        val_82 = null;
        if((专上丈丌丒丁丒丆三.丌丙世丛下丏丆丕丝.TryGetValue(key:  System.String.Format(format:  "{0}{1}{2}", arg0:  22, arg1:  val_78, arg2:  val_81), value: out  val_16)) != false)
        {
                if((val_16.ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) != false)
        {
                丈丙一世上万一丑不 val_21 = val_16.Item[ExpController.万上一丝丆且七丅丅()];
        }
        else
        {
                System.Collections.Generic.KeyValuePair<System.Int32, 丈丙一世上万一丑不> val_22 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, 丈丙一世上万一丑不>>(source:  val_16);
        }
        
            val_75;
        }
        
        label_50:
        val_72 = 0;
        val_84 = 0;
        goto label_59;
        label_65:
        if(val_72 < (0.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  0)))
        {
                val_72 = 0.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  0);
        }
        
        val_84 = 1;
        label_59:
        if(val_84 < 0.丛丄三万丁丙丐丞丂())
        {
            goto label_65;
        }
        
        val_71 = 0;
        val_85 = 0;
        goto label_66;
        label_71:
        if(val_71 < (0.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  0)))
        {
                val_71 = 0.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  0);
        }
        
        val_85 = 1;
        label_66:
        if(val_85 < 0.丛丄三万丁丙丐丞丂())
        {
            goto label_71;
        }
        
        label_19:
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_30 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if((((val_30 == null) || (val_30.专丁丟丏丁丏不丗三() == false)) || (val_30.丗丄上丑丑丅丐丒丌() == true)) || ((val_30.丏不东三专一且丝专(上且丗一丏丏万丅丌:  val_62)) == null))
        {
            goto label_76;
        }
        
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_35 = val_33.RankRewards.Values.GetEnumerator();
        val_86 = 0;
        goto label_79;
        label_80:
        int val_37 = 22.丙东专丂世丈丏丁丂();
        var val_38 = (val_86 < val_37) ? (val_37) : (val_86);
        label_79:
        if(((-1784098672) & 1) != 0)
        {
            goto label_80;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_107;
        label_76:
        val_86 = 0;
        label_107:
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_40 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
        if(((((val_40 == null) || (val_40.丞一丞上丞丞且丐丅() == false)) || (val_40.不丆丑与七下一丛丅() == false)) || (val_40.丞不丅且三丆与丕且() == false)) || ((val_40.丘丗丂丐三丒三世丏(上且丗一丏丏万丅丌:  val_62)) == null))
        {
            goto label_87;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_45 = System.Linq.Enumerable.Max<Rilisoft.丝丑丂丛万丐丈丘且>(source:  val_44.PlaceCounts);
        val_87;
        if(val_40.不丅且丞丑丙与丙丙() != 26015)
        {
            goto label_88;
        }
        
        val_88 = 0;
        goto label_89;
        label_87:
        val_88 = 0;
        label_102:
        val_87 = 0;
        label_89:
        if((((PGCompany.丈丅丝丙上丈丌一丈.丑七不且上丗丁一世().一下丈且丞七东业丗(上且丗一丏丏万丅丌:  val_62, 且丒丛与丞世丙丕丌:  1)) == null) || (val_48.ItemsForDrop == null)) || (val_48.ItemsForDrop.Count < 1))
        {
            goto label_109;
        }
        
        List.Enumerator<T> val_50 = val_48.ItemsForDrop.GetEnumerator();
        label_99:
        if(((-1784098720) & 1) == 0)
        {
            goto label_97;
        }
        
        string val_51 = 22.丐丏七丌丕丗业且上();
        val_89 = val_51.m_stringLength;
        if(val_89 == 0)
        {
            goto label_99;
        }
        
        goto label_100;
        label_97:
        val_89 = 0;
        label_100:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_62 = val_62;
        goto label_101;
        label_88:
        var val_53 = (val_40.不丅且丞丑丙与丙丙() == 25015) ? (val_87) : 0;
        goto label_102;
        label_109:
        val_89 = 0;
        label_101:
        if( != 19)
        {
            goto label_110;
        }
        
        if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().不上丁丏且丙丞三丅() != null)
        {
            goto label_114;
        }
        
        goto label_124;
        label_110:
        Rilisoft.丛且世丐丆上七业丁 val_57 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_57 == null)
        {
            goto label_124;
        }
        
        label_114:
        if((val_57.丏不东三专一且丝专(上且丗一丏丏万丅丌:  null)) != null)
        {
                val_90 = val_58.RankRewards;
            if(val_90 != null)
        {
                if((val_90.ContainsKey(key:  1)) != false)
        {
                val_90 = val_58.RankRewards;
            int val_60 = val_90.Item[1];
        }
        else
        {
                val_90 = 0;
        }
        
        }
        
        }
        
        label_124:
        val_0.下丅丌丌丆不东专丁 = 0;
        val_0.丌丙专丗丏不丐丗丅 = 0;
        val_0.上丛丕丙三丁专下丂 = 1152921505030488064;
        val_0.丕且七丅业丄丝丞东 = val_75;
        val_0.业丒下业丛丆丂丗丕 = val_66;
        val_0.上丁丗丐丝丛丝世丂 = 0;
        val_0.世一丆丟与与专七万 = 0;
        val_0.丄丐不丏丁丘不丒丈 = val_89;
        val_0.<业丟东丟丑与丑丌七>k__BackingField = false;
        val_0.<丝业丄丒丙与与三且>k__BackingField = false;
        val_0.<丌七万丁丁丅丗丁且>k__BackingField = false;
        mem[1152921524297633099] = 0;
        val_0.丅与丑下世丄丄丁上 = val_78;
        mem[1152921524297633068] = 0;
        val_0.业东丆丒丏丒丒专世 = 0;
        val_0.丏且丕丄丁丟丆丏丁 = null;
        val_0.丗丛万丕东丘七丟丙 = GameController.丆丘丂丈世丏丟丑丏;
        val_0.万丏不万丗上丟丙丞 = val_90;
        return val_0;
    }
    internal static 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 丁三丈丏丐业丘丏业(Rilisoft.七丕丟丏三丈一丄世 丒七世丈丌丑丏丄丏, int 且丒丛与丞世丙丕丌, int 万且丒下丕丝专丟上, int 丂丌丙丝且东丗丙万, bool 业东丞丏丒业万丏丘, out bool 丌丁业丅丕丁丈丌丅)
    {
        var val_105;
        int val_106;
        Rilisoft.七丕丟丏三丈一丄世 val_107;
        var val_108;
        int val_109;
        var val_110;
        var val_111;
        var val_112;
        var val_113;
        var val_114;
        var val_115;
        int val_116;
        var val_117;
        var val_118;
        var val_119;
        var val_120;
        var val_121;
        var val_122;
        var val_123;
        var val_124;
        var val_125;
        object val_126;
        var val_127;
        var val_128;
        int val_129;
        var val_130;
        var val_131;
        var val_133;
        var val_134;
        var val_135;
        var val_136;
        var val_137;
        var val_139;
        上丑丝丌七不丙丗丅 val_0;
        bool val_109 = 业东丞丏丒业万丏丘;
        val_106 = 且丒丛与丞世丙丕丌;
        val_107 = 丒七世丈丌丑丏丄丏;
        val_108 = val_0;
        System.Collections.Generic.Dictionary<System.Int32, 丈丙一世上万一丑不> val_71 = 0;
        丌丁业丅丕丁丈丌丅 = false;
        PGCompany.丁东丌世与丕东丆上.丕丞专丘业三世一丘(三下丒三专丑丗丁丕: ref  new 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅() {世一丆丟与与专七万 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>(), <业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
        if(val_107 > 38)
        {
            goto label_4;
        }
        
        var val_104 = val_107;
        val_104 = 1 << val_104;
        val_109 = val_104 & 274890489856;
        if(val_109 == 0)
        {
            goto label_4;
        }
        
        if(val_109 == false)
        {
                return val_0;
        }
        
        val_110 = null;
        goto label_15;
        label_4:
        val_110 = null;
        if(val_107 != 19)
        {
            goto label_8;
        }
        
        if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().不上丁丏且丙丞三丅() != null)
        {
            goto label_12;
        }
        
        goto label_29;
        label_8:
        label_15:
        Rilisoft.丛且世丐丆上七业丁 val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_5 == null)
        {
            goto label_29;
        }
        
        label_12:
        if((val_5.丏不东三专一且丝专(上且丗一丏丏万丅丌:  val_107)) == null)
        {
            goto label_29;
        }
        
        if(val_107 <= 19)
        {
            goto label_19;
        }
        
        if(val_107 == 33)
        {
            goto label_21;
        }
        
        val_111 = val_106;
        if(val_107 == 28)
        {
            goto label_21;
        }
        
        goto label_73;
        label_19:
        if(val_107 > 19)
        {
            goto label_73;
        }
        
        var val_105 = 1;
        val_105 = val_105 << val_107;
        val_105 = val_105 & 655412;
        if(val_105 == 0)
        {
            goto label_24;
        }
        
        label_21:
        label_56:
        label_73:
        if((val_6.MinimumPoints <= 万且丒下丕丝专丟上) && (val_6.RankRewards != null))
        {
                int val_9 = ((val_109 != true) ? (val_106) : (val_106 + 5)) + 1;
            if((val_6.RankRewards.ContainsKey(key:  val_9)) != false)
        {
                int val_11 = val_6.RankRewards.Item[val_9];
        }
        
        }
        
        label_29:
        val_112 = null;
        val_112 = null;
        if((GameController.丆丘丂丈世丏丟丑丏.丁七丗专业世丈丒下 != true) && (PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丝丞丙丂与上且丙丛() != false))
        {
                PGCompany.七下丐丂丙丑东专丂 val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_16 != null)
        {
                if(val_16.丂丁丏一丙丛业且丌() >= 1)
        {
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_18 = val_16.且业上丞丄丁专不丙();
        }
        
        }
        
        }
        
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丟丂且丈且丂世三丕() != false)
        {
                val_113 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世();
            int val_22 = val_113.丄丄世丁丒丑丁东世(上且丗一丏丏万丅丌:  val_107);
        }
        else
        {
                val_113 = 0;
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_24 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if((((val_24 == null) || (val_24.专丁丟丏丁丏不丗三() == false)) || (val_24.丗丄上丑丑丅丐丒丌() == true)) || ((val_24.丏不东三专一且丝专(上且丗一丏丏万丅丌:  val_107)) == null))
        {
            goto label_61;
        }
        
        if(val_107 <= 19)
        {
            goto label_50;
        }
        
        if(val_107 == 33)
        {
            goto label_52;
        }
        
        val_114 = val_106;
        if(val_107 == 28)
        {
            goto label_52;
        }
        
        goto label_88;
        label_24:
        if((val_107 == 3) || (val_107 != 16))
        {
            goto label_73;
        }
        
        int val_28 = val_106 + 3;
        goto label_56;
        label_50:
        if(val_107 > 19)
        {
            goto label_88;
        }
        
        var val_106 = 1;
        val_106 = val_106 << val_107;
        val_106 = val_106 & 655412;
        if(val_106 == 0)
        {
            goto label_58;
        }
        
        label_52:
        label_84:
        label_88:
        if((val_27.MinimumPoints <= 万且丒下丕丝专丟上) && (val_27.RankRewards != null))
        {
                int val_31 = ((val_109 != true) ? (val_106) : (val_106 + 5)) + 1;
            if((val_27.RankRewards.ContainsKey(key:  val_31)) != false)
        {
                int val_33 = val_27.RankRewards.Item[val_31];
        }
        
        }
        
        label_61:
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_35 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
        if(((((val_35 == null) || (val_35.丞一丞上丞丞且丐丅() == false)) || (val_35.不丆丑与七下一丛丅() == false)) || (val_35.丞不丅且三丆与丕且() == false)) || ((val_35.丘丗丂丐三丒三世丏(上且丗一丏丏万丅丌:  val_107)) == null))
        {
            goto label_89;
        }
        
        if(val_107 <= 19)
        {
            goto label_69;
        }
        
        if(val_107 == 33)
        {
            goto label_71;
        }
        
        val_115 = val_106;
        if(val_107 == 28)
        {
            goto label_71;
        }
        
        goto label_215;
        label_69:
        if(val_107 > 19)
        {
            goto label_215;
        }
        
        var val_107 = 1;
        val_107 = val_107 << val_107;
        val_107 = val_107 & 655412;
        if(val_107 == 0)
        {
            goto label_75;
        }
        
        label_71:
        label_87:
        int val_41 = (val_109 != true) ? (val_106) : (val_106 + 5);
        label_215:
        Rilisoft.丝丑丂丛万丐丈丘且 val_42 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  万且丒下丕丝专丟上);
        if((((Rilisoft.丝丑丂丛万丐丈丘且.业下丗不一不丞东丒(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_42.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_42.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_42.上万三丆专丏丒丗业}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_39.MinScore, 丑丒丄下丁丐专丄丞 = val_39.MinScore, 上万三丆专丏丒丗业 = PGCompany.七下丐丂丙丑东专丂 PGCompany.世东三上七丂丌下丑::上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, System.Nullable<PGCompany.丕丅世丂丞丒万丈且> 丙与不丌丌丟丄业丛)})) == false) || (val_39.PlaceCounts == null)) || (val_39.PlaceCounts.Count <= val_41))
        {
            goto label_89;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_45 = val_39.PlaceCounts.Item[val_41];
        if(val_35.不丅且丞丑丙与丙丙() != 26015)
        {
            goto label_80;
        }
        
        goto label_89;
        label_58:
        if((val_107 == 3) || (val_107 != 16))
        {
            goto label_88;
        }
        
        int val_47 = val_106 + 3;
        goto label_84;
        label_75:
        if((val_107 == 3) || (val_107 != 16))
        {
            goto label_215;
        }
        
        int val_48 = val_106 + 3;
        goto label_87;
        label_80:
        int val_49 = val_35.不丅且丞丑丙与丙丙();
        label_89:
        int val_51 = val_106 + 1;
        Rilisoft.OfferItem val_52 = PGCompany.丈丅丝丙上丈丌一丈.丑七不且上丗丁一世().丂丄东丁丒东丛丗东(丒七世丈丌丑丏丄丏:  val_107, 且丒丛与丞世丙丕丌:  val_51);
        val_116 = PGCompany.丈丅丝丙上丈丌一丈.丑七不且上丗丁一世();
        下东丙丑丙丞丛丑上 val_55 = val_116.丄上且丏丅丞丂丙上(丒七世丈丌丑丏丄丏:  val_107, 且丒丛与丞世丙丕丌:  val_51, 业东丞丏丒业万丏丘:  val_109);
        val_105 = 1152921505030488064;
        val_117 = null;
        val_117 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.ContainsKey(key:  val_107)) == false)
        {
            goto label_189;
        }
        
        val_118 = null;
        val_118 = null;
        val_119 = null;
        if((专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_107].ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) == false)
        {
            goto label_108;
        }
        
        val_120 = null;
        val_121 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_107];
        val_116 = ExpController.万上一丝丆且七丅丅();
        if(val_121 != null)
        {
            goto label_115;
        }
        
        goto label_115;
        label_108:
        val_122 = null;
        val_121 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_107];
        val_116 = 专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与.Item[val_107].Count - 1;
        label_115:
        val_123 = val_121.Item[val_116];
        if(val_107 == 3)
        {
            goto label_122;
        }
        
        if(val_107 != 22)
        {
            goto label_149;
        }
        
        val_124 = null;
        val_124 = null;
        if(DungeonsController.丄丘七三上丕世丞业 == 0)
        {
            goto label_128;
        }
        
        val_125 = null;
        val_125 = null;
        val_126 = DungeonsController.丄丘七三上丕世丞业.dungeonDifficulty;
        goto label_132;
        label_122:
        val_109 = 丂丌丙丝且东丗丙万;
        if((val_109 & 2147483648) != 0)
        {
                return val_0;
        }
        
        val_106 = 丂丌丙丝且东丗丙万;
        if(val_109 == true)
        {
            goto label_149;
        }
        
        return val_0;
        label_128:
        val_126 = 1;
        label_132:
        val_127 = null;
        val_127 = null;
        if(GameController.丆丘丂丈世丏丟丑丏 != 0)
        {
                val_128 = null;
            val_128 = null;
            val_129 = 丙且上丒不下丑下丞();
        }
        else
        {
                val_129 = System.String.alignConst;
        }
        
        val_130 = null;
        val_130 = null;
        val_131 = val_108;
        if((专上丈丌丒丁丒丆三.丌丙世丛下丏丆丕丝.TryGetValue(key:  System.String.Format(format:  "{0}{1}{2}", arg0:  22, arg1:  val_126, arg2:  val_129), value: out  val_71)) != false)
        {
                if((val_71.ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) != false)
        {
                丈丙一世上万一丑不 val_76 = val_71.Item[ExpController.万上一丝丆且七丅丅()];
        }
        else
        {
                System.Collections.Generic.KeyValuePair<System.Int32, 丈丙一世上万一丑不> val_77 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, 丈丙一世上万一丑不>>(source:  val_71);
        }
        
            val_123;
        }
        
        label_149:
        val_116 = 1152921505061052416;
        val_133 = 0;
        if(((与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != true) ? (val_133) : 0) <= 万且丒下丕丝专丟上)
        {
            goto label_164;
        }
        
        if(val_107 > 9)
        {
            goto label_165;
        }
        
        if(val_107 == 3)
        {
            goto label_166;
        }
        
        val_134 = val_131;
        if(val_107 != 8)
        {
            goto label_189;
        }
        
        val_105 = 1152921505058017280;
        val_135 = null;
        val_135 = null;
        val_134 = val_131;
        if(DuelController.丄丘七三上丕世丞业 == 0)
        {
            goto label_189;
        }
        
        val_136 = null;
        val_136 = null;
        val_134 = val_131;
        if(DuelController.丄丘七三上丕世丞业.HaveBet() == false)
        {
            goto label_189;
        }
        
        goto label_198;
        label_164:
        if(val_107 > 13)
        {
            goto label_178;
        }
        
        val_134 = val_131;
        if(val_107 == 2)
        {
            goto label_179;
        }
        
        if(val_107 == 10)
        {
            goto label_182;
        }
        
        goto label_198;
        label_165:
        val_134 = val_131;
        if(val_107 == 10)
        {
            goto label_182;
        }
        
        if(val_107 == 14)
        {
            goto label_185;
        }
        
        goto label_189;
        label_178:
        val_134 = val_131;
        if(val_107 == 14)
        {
            goto label_185;
        }
        
        if(val_107 != 28)
        {
            goto label_198;
        }
        
        label_179:
        if(val_109 == false)
        {
            goto label_187;
        }
        
        goto label_188;
        label_182:
        if(丂丌丙丝且东丗丙万 <= 0)
        {
            goto label_189;
        }
        
        val_137 = null;
        val_137 = null;
        if(专上丈丌丒丁丒丆三.万且丁丌丆下丄丛丄 <= 丂丌丙丝且东丗丙万)
        {
            goto label_192;
        }
        
        val_139 = 0;
        goto label_198;
        label_189:
        val_109 = true;
        label_197:
        丌丁业丅丕丁丈丌丅 = val_109;
        return val_0;
        label_185:
        if(万且丒下丕丝专丟上 >= 1)
        {
                if(val_109 == true)
        {
            goto label_198;
        }
        
        }
        
        var val_83 = (万且丒下丕丝专丟上 < 1) ? 1 : 0;
        goto label_197;
        label_166:
        val_134 = val_131;
        goto label_198;
        label_192:
        label_198:
        var val_108 = 0;
        var val_86 = ((val_107 | 1) != 5) ? 1 : 0;
        val_108 = val_108 ^ 1;
        val_86 = val_86 & val_108;
        val_86 = ((val_107 != 33) ? 1 : 0) & val_86;
        val_86 = ((val_107 != 17) ? 1 : 0) & val_86;
        if(((val_86 & 1) != 0) || (val_109 == true))
        {
            goto label_202;
        }
        
        label_187:
        val_139 = ((专上丈丌丒丁丒丆三.丈丐丟丐丙七东业丒 <= 丂丌丙丝且东丗丙万) ? (1 + 1) : 1) + 5;
        label_202:
        var val_89 = (val_107 != 16) ? 1 : 0;
        val_89 = val_89 | val_109;
        val_139 = (val_89 != true) ? (val_139) : (val_139 + 3);
        label_188:
        val_109 = (ExperienceController.丞丞丘业东丙丏七丌() < 2) ? (val_139) : 3;
        int val_95 = val_45.七丄不丐丗三丝丑一.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  UnityEngine.Mathf.Min(a:  val_109, b:  val_45.七丄不丐丗三丝丑一.丛丄三万丁丙丐丞丂() - 1));
        int val_99 = val_45.上万三丆专丏丒丗业.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  UnityEngine.Mathf.Min(a:  val_109, b:  val_45.上万三丆专丏丒丗业.丛丄三万丁丙丐丞丂() - 1));
        val_109 = 0;
        val_107 = 0;
        int val_103 = val_107.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  UnityEngine.Mathf.Min(a:  val_109, b:  val_107.丛丄三万丁丙丐丞丂() - 1));
        return val_0;
    }
    public 专上丈丌丒丁丒丆三()
    {
    
    }
    private static 专上丈丌丒丁丒丆三()
    {
        专上丈丌丒丁丒丆三.一丏下丙丛丒丈万与 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<System.Int32, 丈丙一世上万一丑不>>(comparer:  Rilisoft.专丝世与丈丈丞丙丟.丑七不且上丗丁一世());
        专上丈丌丒丁丒丆三.丌丙世丛下丏丆丕丝 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, 丈丙一世上万一丑不>>();
        专上丈丌丒丁丒丆三.万且丁丌丆下丄丛丄 = 30000;
        专上丈丌丒丁丒丆三.丈丐丟丐丙七东业丒 = 48000;
    }

}
