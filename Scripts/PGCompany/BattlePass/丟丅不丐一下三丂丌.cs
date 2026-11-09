using UnityEngine;

namespace PGCompany.BattlePass
{
    internal static class 丟丅不丐一下三丂丌
    {
        // Methods
        internal static bool 丐丕世丄业丝丑丌一(string 丛七丅东丒丅丘不业, out PGCompany.BattlePass.BPData 丏丞丝业且专万丙丌, out System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> 丅一丂专丌万丐三世, out int 丗丙上业下丆业下丝)
        {
            var val_24;
            System.Object[] val_25;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> val_26;
            var val_27;
            var val_28;
            PGCompany.BattlePass.BPData val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_25 = 1152921559952896656;
            val_26 = 1152921559952892624;
            string val_24 = 丛七丅东丒丅丘不业;
            丏丞丝业且专万丙丌 = 0;
            丅一丂专丌万丐三世 = 0;
            丗丙上业下丆业下丝 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_24)) == true)
            {
                goto label_36;
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_24);
            if(val_2 == null)
            {
                goto label_36;
            }
            
            val_24 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            val_24 = "bp";
            if((val_24.ContainsKey(key:  "bp")) == false)
            {
                goto label_8;
            }
            
            if(val_24.Item["bp"] == null)
            {
                goto label_12;
            }
            
            val_27 = 0;
            goto label_12;
            label_8:
            val_25 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BattlePassController ParseData \"bp\" key not exists", args:  val_25);
            goto label_36;
            label_12:
            if((PGCompany.BattlePass.丟丅不丐一下三丂丌.丞且丈丅丏下丄丟不(丞丕丒专一下丙业上:  null, 丏丞丝业且专万丙丌: out  PGCompany.BattlePass.BPData val_7 = 丏丞丝业且专万丙丌)) == false)
            {
                goto label_36;
            }
            
            if((val_24.ContainsKey(key:  "gameRewards")) != false)
            {
                    if(val_24.Item["gameRewards"] != null)
            {
                    val_28 = 0;
            }
            
                PGCompany.BattlePass.丟丅不丐一下三丂丌.丕丁专丁丙丆不七一(丞丕丒专一下丙业上:  null, 丏丞丝业且专万丙丌:  丏丞丝业且专万丙丌);
            }
            
            val_24 = "chs";
            if((val_24.ContainsKey(key:  "chs")) == false)
            {
                goto label_24;
            }
            
            val_24 = val_24.Item["chs"];
            val_29 = 丏丞丝业且专万丙丌;
            if(val_29 == null)
            {
                goto label_26;
            }
            
            val_30 = 11993091;
            goto label_32;
            label_24:
            val_25 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BattlePassController ParseData \"chs\" key not exists", args:  val_25);
            goto label_36;
            label_26:
            val_30 = 11993091;
            if(丏丞丝业且专万丙丌 != null)
            {
                    val_29 = 丏丞丝业且专万丙丌;
            }
            else
            {
                    val_29 = 0;
            }
            
            label_32:
            val_31 = 0;
            if((PGCompany.BattlePass.丟丅不丐一下三丂丌.丄丅不丘丏丈丏丆丘(丞丕丒专一下丙业上:  null, 丅一丂专丌万丐三世: out  System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> val_16 = 丅一丂专丌万丐三世, 丒业一丄丕丅丆专丈:  11993091, 丕且不丛且丞专上不:  new System.DateTime() {dateData = 8})) != false)
            {
                    if((val_24.ContainsKey(key:  "chs_loc")) != false)
            {
                    val_26 = 不丝丕万丏丘丘与丅.丑七不且上丗丁一世();
                object val_20 = val_24.Item["chs_loc"];
                val_32 = 0;
                val_26.丅专下万丕丑丆丅丝(不丒丗且丝一不业一:  null);
            }
            
                val_33 = 1;
                return (bool)val_33;
            }
            
            label_36:
            val_33 = 0;
            return (bool)val_33;
        }
        private static void 丕丁专丁丙丆不七一(System.Collections.Generic.List<object> 丞丕丒专一下丙业上, PGCompany.BattlePass.BPData 丏丞丝业且专万丙丌)
        {
            var val_3;
            var val_24;
            var val_25;
            System.Collections.Generic.List<Rilisoft.GameEventRewardData> val_26;
            val_24 = 丏丞丝业且专万丙丌;
            if(丞丕丒专一下丙业上 == null)
            {
                    return;
            }
            
            if(val_24 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = 丞丕丒专一下丙业上.GetEnumerator();
            label_34:
            if(((-488303664) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((val_4 == null) || ((val_4.ContainsKey(key:  "Mode")) == false))
            {
                goto label_34;
            }
            
            object val_6 = val_4.Item["Mode"];
            if((val_6 == null) || (null != null))
            {
                goto label_34;
            }
            
            System.Nullable<T> val_7 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_6, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-488303672) & 1) == 0)
            {
                goto label_34;
            }
            
            val_25 = null;
            val_25 = null;
            int val_12 = 0;
            if((val_4.ContainsKey(key:  "Sc")) != false)
            {
                    object val_10 = val_4.Item["Sc"];
                if(val_10 != null)
            {
                    if(val_10.Length >= 1)
            {
                    bool val_13 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_10, 丙业与丙丗丝不丈东: out  val_12);
            }
            
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_14 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            do
            {
                string val_15 = 1.ToString();
                if((val_4.ContainsKey(key:  val_15)) != false)
            {
                    object val_17 = val_4.Item[val_15];
                if(val_17 != null)
            {
                    bool val_19 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_17, 丙业与丙丗丝不丈东: out  0);
                null.Add(key:  1, value:  0);
            }
            
            }
            
                var val_23 = 1;
                val_23 = val_23 + 1;
            }
            while(val_23 <= 10);
            
            new Rilisoft.GameEventRewardData() = new Rilisoft.GameEventRewardData();
            if(new Rilisoft.GameEventRewardData() != null)
            {
                    .GameMode = ;
            }
            else
            {
                    mem[16] = ;
            }
            
            new Rilisoft.GameEventRewardData().IsMiniGame = System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  GameConnect.丘丗世专不丅与丗丒, value:  val_7.HasValue);
            if(new Rilisoft.GameEventRewardData() != null)
            {
                    .MinimumPoints = 0;
            }
            else
            {
                    mem[24] = val_12;
            }
            
            .RankRewards = null;
            val_26 = 丏丞丝业且专万丙丌.GameRewards;
            if(val_26 == null)
            {
                    val_26 = null;
                val_26 = new System.Collections.Generic.List<Rilisoft.GameEventRewardData>();
                丏丞丝业且专万丙丌.GameRewards = val_26;
            }
            
            null.Add(item:  new Rilisoft.GameEventRewardData());
            goto label_34;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private static bool 丞且丈丅丏下丄丟不(System.Collections.Generic.Dictionary<string, object> 丞丕丒专一下丙业上, out PGCompany.BattlePass.BPData 丏丞丝业且专万丙丌)
        {
            var val_48;
            PGCompany.BattlePass.BPData val_105;
            PGCompany.BattlePass.BPData val_106;
            var val_107;
            BPData.Content val_108;
            var val_109;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_104 = 丞丕丒专一下丙业上;
            PGCompany.BattlePass.BPData val_1 = null;
            val_105 = val_1;
            val_1 = new PGCompany.BattlePass.BPData();
            System.Collections.Generic.List<Content> val_2 = new System.Collections.Generic.List<Content>();
            .Leveling = val_2;
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_3 = new System.Collections.Generic.List<Rilisoft.GameCurrencyData>();
            .CurrencyPrices = val_3;
            丏丞丝业且专万丙丌 = val_105;
            if(val_104 == null)
            {
                goto label_121;
            }
            
            val_105 = "id";
            if((val_104.ContainsKey(key:  "id")) == false)
            {
                goto label_121;
            }
            
            val_105 = val_104.Item["id"];
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_105, 丙业与丙丗丝不丈东: out  0x1000000CE2EAE1A0.Id)) == false)
            {
                goto label_121;
            }
            
            if((val_104.ContainsKey(key:  "start")) != false)
            {
                    val_106 = 丏丞丝业且专万丙丌;
                System.DateTime val_11 = System.DateTime.Parse(s:  val_104.Item["start"], provider:  System.Globalization.CultureInfo.InvariantCulture);
                mem[1152921559953498752] = val_11.dateData;
            }
            
            if((val_104.ContainsKey(key:  "end")) != false)
            {
                    val_106 = 丏丞丝业且专万丙丌;
                System.DateTime val_15 = System.DateTime.Parse(s:  val_104.Item["end"], provider:  System.Globalization.CultureInfo.InvariantCulture);
                mem[1152921559953498696] = val_15.dateData;
            }
            
            if((val_104.ContainsKey(key:  "premium_price")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["premium_price"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.PremiumPrice = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "level_price")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["level_price"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.LevelPrice = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "premium_price_lvl")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["premium_price_lvl"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.PremiumPriceWithLevels = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "premium_price_lvl_count")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["premium_price_lvl_count"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.PremiumLevelsCount = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "premium_price_lvl_old")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["premium_price_lvl_old"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.PremiumPriceWithLevelsOld = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "video_daily_count")) != false)
            {
                    bool val_39 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["video_daily_count"], 丙业与丙丗丝不丈东: out  0x1000000CE2EAE1A0.MaxVideoDailyCount);
            }
            
            if((val_104.ContainsKey(key:  "start_level")) != false)
            {
                    bool val_43 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["start_level"], 丙业与丙丗丝不丈东: out  0x1000000CE2EAE1A0.MinPlayerLevel);
            }
            
            if((val_104.ContainsKey(key:  "prices")) == false)
            {
                goto label_89;
            }
            
            object val_45 = val_104.Item["prices"];
            if(val_45 == null)
            {
                goto label_89;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_46 = val_45.GetEnumerator();
            label_77:
            if(((-487975568) & 1) == 0)
            {
                goto label_68;
            }
            
            ConfiguredValueTaskAwaiter val_50 = val_48.GetAwaiter();
            int val_52 = 0;
            bool val_53 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_50._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  val_52);
            bool val_54 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_50._value._obj, 丙业与丙丗丝不丈东: out  val_52);
            if((0 < 1) || (0 < 1))
            {
                goto label_77;
            }
            
            new Rilisoft.GameCurrencyData() = new Rilisoft.GameCurrencyData(丑丏万丈丟丝丝丌丗:  0, 丏丂不专上丘丂不丅:  "BattlePassCurrency", 丒世丘丘上丆丝东丞:  0, 丕丐丗世丌三上丌世:  "Real");
            val_3.Add(item:  new Rilisoft.GameCurrencyData());
            goto label_77;
            label_68:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_89:
            if((val_104.ContainsKey(key:  "pci")) != false)
            {
                    mem[1152921559953498736] = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_104.Item["pci"], 丝七丄丛丂丒丘不丛:  ',');
            }
            
            if((val_104.ContainsKey(key:  "pca")) != false)
            {
                    mem[1152921559953498744] = val_104.Item["pca"];
            }
            
            if((val_104.ContainsKey(key:  "st")) != false)
            {
                    mem[1152921559953498704] = val_104.Item["st"];
            }
            
            if((val_104.ContainsKey(key:  "de")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["de"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.DailyExp = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "dbc")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["dbc"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.BlockPointForViewNewDailyChallenges = 0;
            }
            
            }
            
            if((val_104.ContainsKey(key:  "cbc")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_104.Item["cbc"], 丙业与丙丗丝不丈东: out  0)) != false)
            {
                    val_1.BlockPointForViewNewCommonChallenges = 0;
            }
            
            }
            
            val_105 = "leveling";
            if((val_104.ContainsKey(key:  "leveling")) != false)
            {
                    object val_76 = val_104.Item["leveling"];
                if(val_76 == null)
            {
                    return (bool)val_107;
            }
            
                val_106 = 1152921504691564544;
                val_104 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_76) : 0;
            }
            
            label_121:
            val_107 = 0;
            return (bool)val_107;
            label_156:
            if(((-487975632) & 1) == 0)
            {
                goto label_124;
            }
            
            string val_78 = val_48.丐丏七丌丕丗业且上();
            if(val_78 == null)
            {
                goto label_156;
            }
            
            int val_81 = 0;
            if(((val_78.ContainsKey(key:  "l")) == false) || ((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_78.Item["l"], 丙业与丙丗丝不丈东: out  val_81)) == false))
            {
                goto label_156;
            }
            
            int val_85 = 0;
            if(((val_78.ContainsKey(key:  "exp")) == false) || ((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_78.Item["exp"], 丙业与丙丗丝不丈东: out  val_85)) == false))
            {
                goto label_156;
            }
            
            BPData.Content val_87 = new BPData.Content();
            val_108 = val_87;
            if(val_108 != null)
            {
                    .Level = 0;
                val_109 = val_85;
            }
            else
            {
                    mem[1152921559953617332] = val_81;
                val_109 = val_85;
                val_108 = val_108;
            }
            
            mem[1152921559953617328] = val_109;
            System.Collections.Generic.List<System.String> val_88 = new System.Collections.Generic.List<System.String>();
            val_87.RewardsFree = null;
            System.Collections.Generic.List<System.String> val_89 = new System.Collections.Generic.List<System.String>();
            val_87.RewardsPaid = null;
            val_2.Add(item:  val_87);
            if((val_78.ContainsKey(key:  "rewards")) == false)
            {
                goto label_156;
            }
            
            object val_91 = val_78.Item["rewards"];
            if(val_91 == null)
            {
                goto label_156;
            }
            
            if((val_91.ContainsKey(key:  "free")) != false)
            {
                    object val_93 = val_91.Item["free"];
            }
            
            string val_105 = "fc";
            val_105 = val_91.ContainsKey(key:  val_105);
            val_87.FreeIsCool = val_105;
            if((val_91.ContainsKey(key:  "paid")) != false)
            {
                    object val_96 = val_91.Item["paid"];
            }
            
            string val_106 = "pc";
            val_106 = val_91.ContainsKey(key:  val_106);
            val_87.PaidIsCool = val_106;
            goto label_156;
            label_124:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_107;
        }
        private static bool 丄丅不丘丏丈丏丆丘(System.Collections.Generic.List<object> 丞丕丒专一下丙业上, out System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> 丅一丂专丌万丐三世, int 丒业一丄丕丅丆专丈, System.DateTime 丕且不丛且丞专上不)
        {
            System.Object[] val_14;
            object val_15;
            var val_16;
            System.Func<PGCompany.BattlePass.BPChallangeDO, System.Boolean> val_18;
            var val_19;
            System.Func<PGCompany.BattlePass.BPChallangeDO, System.Int32> val_21;
            var val_22;
            var val_24;
            val_14 = 1152921559953849296;
            丟丅不丐一下三丂丌.上丌专丄丘丂东且丒 val_1 = null;
            val_15 = val_1;
            val_1 = new 丟丅不丐一下三丂丌.上丌专丄丘丂东且丒();
            if(val_15 != null)
            {
                    .丒业一丄丕丅丆专丈 = 丒业一丄丕丅丆专丈;
            }
            else
            {
                    mem[16] = 丒业一丄丕丅丆专丈;
            }
            
            .丕且不丛且丞专上不 = 丕且不丛且丞专上不;
            丅一丂专丌万丐三世 = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO>();
            if(丞丕丒专一下丙业上 != null)
            {
                    val_16 = null;
                val_16 = null;
                val_18 = 丟丅不丐一下三丂丌.<>c.<>9__3_1;
                if(val_18 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallangeDO, System.Boolean> val_6 = null;
                val_18 = val_6;
                val_6 = new System.Func<PGCompany.BattlePass.BPChallangeDO, System.Boolean>(object:  丟丅不丐一下三丂丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丟丅不丐一下三丂丌.<>c::丕与一丝丄专丂业丑(PGCompany.BattlePass.BPChallangeDO 三丟东丕丄丄下下丑));
                丟丅不丐一下三丂丌.<>c.<>9__3_1 = val_18;
            }
            
                val_19 = null;
                val_19 = null;
                val_21 = 丟丅不丐一下三丂丌.<>c.<>9__3_2;
                if(val_21 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallangeDO, System.Int32> val_8 = null;
                val_21 = val_8;
                val_8 = new System.Func<PGCompany.BattlePass.BPChallangeDO, System.Int32>(object:  丟丅不丐一下三丂丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丟丅不丐一下三丂丌.<>c::上七丘丘下丗七业丈(PGCompany.BattlePass.BPChallangeDO 三丟东丕丄丄下下丑));
                丟丅不丐一下三丂丌.<>c.<>9__3_2 = val_21;
            }
            
                val_22 = null;
                val_22 = null;
                val_15 = 丟丅不丐一下三丂丌.<>c.<>9__3_3;
                if(val_15 == null)
            {
                    System.Func<System.Linq.IGrouping<System.Int32, PGCompany.BattlePass.BPChallangeDO>, PGCompany.BattlePass.BPChallangeDO> val_10 = null;
                val_15 = val_10;
                val_10 = new System.Func<System.Linq.IGrouping<System.Int32, PGCompany.BattlePass.BPChallangeDO>, PGCompany.BattlePass.BPChallangeDO>(object:  丟丅不丐一下三丂丌.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.BPChallangeDO 丟丅不丐一下三丂丌.<>c::丈东丂丈丁丄丘丂丆(System.Linq.IGrouping<int, PGCompany.BattlePass.BPChallangeDO> 丌一东丆丕丈丁丞世));
                丟丅不丐一下三丂丌.<>c.<>9__3_3 = val_15;
            }
            
                丅一丂专丌万丐三世 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPChallangeDO>(source:  System.Linq.Enumerable.Select<System.Linq.IGrouping<System.Int32, PGCompany.BattlePass.BPChallangeDO>, PGCompany.BattlePass.BPChallangeDO>(source:  System.Linq.Enumerable.GroupBy<PGCompany.BattlePass.BPChallangeDO, System.Int32>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPChallangeDO>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.Dictionary<System.String, System.Object>, PGCompany.BattlePass.BPChallangeDO>(source:  System.Linq.Enumerable.OfType<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  丞丕丒专一下丙业上), selector:  new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, PGCompany.BattlePass.BPChallangeDO>(object:  val_1, method:  PGCompany.BattlePass.BPChallangeDO 丟丅不丐一下三丂丌.上丌专丄丘丂东且丒::七丑三丅三万丒七丁(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏))), predicate:  val_6), keySelector:  val_8), selector:  val_10));
                val_24 = 1;
                return (bool)val_24;
            }
            
            object[] val_13 = new object[1];
            val_14 = val_13;
            val_14[0] = 0;
            UnityEngine.Debug.LogErrorFormat(format:  "BattlePassController ParseData bpChallengesConfigList == null, rawData = {0}", args:  val_13);
            val_24 = 0;
            return (bool)val_24;
        }
    
    }

}
