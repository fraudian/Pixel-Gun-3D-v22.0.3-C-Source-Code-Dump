using UnityEngine;

namespace Progress
{
    internal class 不且丝一丌丈丛丘丌 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private Progress.OffersProgressData 丈丄丂下丒专丌丛丄;
        private static readonly System.Collections.Generic.Dictionary<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule, string> 丆业丛丟丘丂与七一;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal Rilisoft.Offers.丂丆丞一丁丗万上丌 专丟三丈下上三万丘()
        {
            return 0;
        }
        internal void 丑丞不丐下丕不丌丛(Rilisoft.Offers.丂丆丞一丁丗万上丌 上丕丈丞丌丘丅不与)
        {
        
        }
        internal Progress.AdaptiveProgress 丒丁上丟丑丁丄世丁()
        {
            var val_4;
            if(this.丈丄丂下丒专丌丛丄.Adaptive.Clone() == null)
            {
                    return (Progress.AdaptiveProgress)val_4;
            }
            
            val_4 = 0;
            return (Progress.AdaptiveProgress)val_4;
        }
        internal void 丒丙三丙丆世丙东丛(Progress.AdaptiveProgress 上丕丈丞丌丘丅不与)
        {
            var val_5;
            Progress.OffersProgressData val_6;
            Progress.AdaptiveProgress val_7;
            val_5 = 上丕丈丞丌丘丅不与;
            if(val_5 != null)
            {
                    val_6 = this.丈丄丂下丒专丌丛丄;
            }
            else
            {
                    Progress.AdaptiveProgress val_1 = null;
                val_5 = val_1;
                val_1 = new Progress.AdaptiveProgress();
                val_6 = this.丈丄丂下丒专丌丛丄;
            }
            
            val_7 = val_1.Clone();
            if(val_6 == null)
            {
                goto label_4;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_9;
            label_4:
            if(val_7 == null)
            {
                goto label_9;
            }
            
            label_5:
            val_7 = 0;
            label_9:
            this.丈丄丂下丒专丌丛丄.Adaptive = val_7;
        }
        internal Progress.DailyTierProgress 下东丕业丛丝不万丏()
        {
            var val_4;
            if(this.丈丄丂下丒专丌丛丄.DailyTier.Clone() == null)
            {
                    return (Progress.DailyTierProgress)val_4;
            }
            
            val_4 = 0;
            return (Progress.DailyTierProgress)val_4;
        }
        internal void 丗丆丛不丌丐丅丅七(Progress.DailyTierProgress 上丕丈丞丌丘丅不与)
        {
            var val_5;
            Progress.OffersProgressData val_6;
            Progress.DailyTierProgress val_7;
            val_5 = 上丕丈丞丌丘丅不与;
            if(val_5 != null)
            {
                    val_6 = this.丈丄丂下丒专丌丛丄;
            }
            else
            {
                    Progress.DailyTierProgress val_1 = null;
                val_5 = val_1;
                val_1 = new Progress.DailyTierProgress();
                val_6 = this.丈丄丂下丒专丌丛丄;
            }
            
            val_7 = val_1.Clone();
            if(val_6 == null)
            {
                goto label_4;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_9;
            label_4:
            if(val_7 == null)
            {
                goto label_9;
            }
            
            label_5:
            val_7 = 0;
            label_9:
            this.丈丄丂下丒专丌丛丄.DailyTier = val_7;
        }
        internal Progress.StarterPackProgress 下丌丒丄世东丁且丅()
        {
            var val_4;
            if(this.丈丄丂下丒专丌丛丄.StarterPack.Clone() == null)
            {
                    return (Progress.StarterPackProgress)val_4;
            }
            
            val_4 = 0;
            return (Progress.StarterPackProgress)val_4;
        }
        internal void 东丆丛丁丙且下上丞(Progress.StarterPackProgress 上丕丈丞丌丘丅不与)
        {
            Progress.StarterPackProgress val_2 = 上丕丈丞丌丘丅不与;
            if(val_2 == null)
            {
                    Progress.StarterPackProgress val_1 = null;
                val_2 = val_1;
                val_1 = new Progress.StarterPackProgress();
            }
            
            this.丈丄丂下丒专丌丛丄.StarterPack = val_2;
        }
        internal Progress.LobbyProgress 丗丝不专丂丑万丄一()
        {
            var val_4;
            if(this.丈丄丂下丒专丌丛丄.Lobby.Clone() == null)
            {
                    return (Progress.LobbyProgress)val_4;
            }
            
            val_4 = 0;
            return (Progress.LobbyProgress)val_4;
        }
        internal void 丌七万丟丆丛丛丅丛(Progress.LobbyProgress 上丕丈丞丌丘丅不与)
        {
            Progress.LobbyProgress val_2 = 上丕丈丞丌丘丅不与;
            if(val_2 == null)
            {
                    Progress.LobbyProgress val_1 = null;
                val_2 = val_1;
                val_1 = new Progress.LobbyProgress();
            }
            
            this.丈丄丂下丒专丌丛丄.Lobby = val_2;
        }
        internal Progress.CommonProgress 丌丘丂专万三丂下丗()
        {
            var val_4;
            if(this.丈丄丂下丒专丌丛丄.Common.Clone() == null)
            {
                    return (Progress.CommonProgress)val_4;
            }
            
            val_4 = 0;
            return (Progress.CommonProgress)val_4;
        }
        internal void 下丆丗丄丙丕丅丌且(Progress.CommonProgress 上丕丈丞丌丘丅不与)
        {
            var val_5;
            Progress.OffersProgressData val_6;
            Progress.CommonProgress val_7;
            val_5 = 上丕丈丞丌丘丅不与;
            if(val_5 != null)
            {
                    val_6 = this.丈丄丂下丒专丌丛丄;
            }
            else
            {
                    Progress.CommonProgress val_1 = null;
                val_5 = val_1;
                val_1 = new Progress.CommonProgress();
                val_6 = this.丈丄丂下丒专丌丛丄;
            }
            
            val_7 = val_1.Clone();
            if(val_6 == null)
            {
                goto label_4;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_9;
            label_4:
            if(val_7 == null)
            {
                goto label_9;
            }
            
            label_5:
            val_7 = 0;
            label_9:
            this.丈丄丂下丒专丌丛丄.Common = val_7;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.不且丝一丌丈丛丘丌.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.不且丝一丌丈丛丘丌.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 30;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_20;
            var val_27;
            var val_141;
            var val_142;
            var val_143;
            int val_144;
            var val_145;
            var val_146;
            var val_147;
            var val_149;
            int val_150;
            var val_151;
            System.Func<System.Object, Rilisoft.OfferItem> val_153;
            var val_156;
            System.Func<System.Object, Rilisoft.OfferItem> val_158;
            var val_159;
            System.Func<System.Object, Rilisoft.OfferItem> val_161;
            var val_162;
            var val_163;
            var val_164;
            var val_165;
            System.Func<System.Object, System.String> val_167;
            Progress.AdaptiveProgress val_168;
            var val_169;
            var val_170;
            var val_171;
            var val_172;
            var val_173;
            val_141;
            val_142 = 一丐丗丁丞丆丅丟丄;
            this.丈丄丂下丒专丌丛丄 = new Progress.OffersProgressData();
            if(val_142 == null)
            {
                    return;
            }
            
            val_144 = 1152921504689381376;
            val_145 = 1152921516630043280;
            if((val_142.ContainsKey(key:  "o")) != false)
            {
                    object val_3 = val_142.Item["o"];
            }
            
            val_146 = 0;
            label_408:
            if((val_142.ContainsKey(key:  "ad")) == false)
            {
                goto label_381;
            }
            
            object val_5 = val_142.Item["ad"];
            if(val_5 == null)
            {
                goto label_381;
            }
            
            if((val_5.ContainsKey(key:  "s")) != false)
            {
                    bool val_9 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_5.Item["s"], 丙业与丙丗丝不丈东: out  this.丈丄丂下丒专丌丛丄.Adaptive.SeasonId);
                val_146 = val_146;
            }
            
            if((val_5.ContainsKey(key:  "ss")) != false)
            {
                    bool val_13 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_5.Item["ss"], 丙业与丙丗丝不丈东: out  this.丈丄丂下丒专丌丛丄.Adaptive.SeasonStartAt);
                val_146 = val_146;
            }
            
            if((val_5.ContainsKey(key:  "si")) != false)
            {
                    object val_15 = val_5.Item["si"];
            }
            
            val_147 = 1152921516630043280;
            label_399:
            if((val_5.ContainsKey(key:  "wbc")) == false)
            {
                goto label_205;
            }
            
            object val_17 = val_5.Item["wbc"];
            if(val_17 == null)
            {
                goto label_205;
            }
            
            List.Enumerator<T> val_18 = val_17.GetEnumerator();
            label_40:
            if((2109232144 & 1) == 0)
            {
                goto label_32;
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_20.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_40;
            }
            
            this.丈丄丂下丒专丌丛丄.Adaptive.Weapons_BoughtCategoryes.Add(item:  0);
            goto label_40;
            label_130:
            val_149 = 1152921516630043280;
            label_48:
            if((2109232256 & 1) == 0)
            {
                goto label_42;
            }
            
            ConfiguredValueTaskAwaiter val_29 = val_27.GetAwaiter();
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  val_29._value._obj.丐丏七丌丕丗业且上())) == true)
            {
                goto label_48;
            }
            
            if(val_29._value._obj == 0)
            {
                goto label_48;
            }
            
            Progress.OfferProgress val_32 = new Progress.OfferProgress();
            if((val_29._value._obj.ContainsKey(key:  "id")) != false)
            {
                    if(val_29._value._obj.Item["id"] != null)
            {
                    val_150 = val_29._value._obj.Item["id"];
            }
            else
            {
                    val_150 = System.String.alignConst;
            }
            
                val_149 = 1152921516630043280;
                mem[1152921541075947776] = val_150;
            }
            
            if((val_29._value._obj.ContainsKey(key:  "fs")) != false)
            {
                    bool val_39 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_29._value._obj.Item["fs"], 丙业与丙丗丝不丈东: out  val_32 + 24);
            }
            
            if((val_29._value._obj.ContainsKey(key:  "bi")) != false)
            {
                    object val_41 = val_29._value._obj.Item["bi"];
                if(val_41 != null)
            {
                    val_151 = null;
                val_151 = null;
                val_153 = 不且丝一丌丈丛丘丌.<>c.<>9__22_0;
                if(val_153 == null)
            {
                    val_153 = null;
                val_153 = new System.Func<System.Object, Rilisoft.OfferItem>(object:  不且丝一丌丈丛丘丌.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem 不且丝一丌丈丛丘丌.<>c::上且七一丞丁丕七一(object 七丞丙丒三丕且丌丟));
                不且丝一丌丈丛丘丌.<>c.<>9__22_0 = val_153;
            }
            
                mem[1152921541075947800] = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.Object, Rilisoft.OfferItem>(source:  val_41, selector:  null));
            }
            
            }
            
            if((val_29._value._obj.ContainsKey(key:  "cp")) == false)
            {
                goto label_96;
            }
            
            object val_46 = val_29._value._obj.Item["cp"];
            if(val_46 == null)
            {
                goto label_96;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_47 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            mem[1152921541075947792] = null;
            Dictionary.Enumerator<TKey, TValue> val_48 = val_46.GetEnumerator();
            label_83:
            if((2109232192 & 1) == 0)
            {
                goto label_74;
            }
            
            ConfiguredValueTaskAwaiter val_49 = val_27.GetAwaiter();
            if(((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_49._value._obj, 丙业与丙丗丝不丈东: out  0)) == false) || ((null.ContainsKey(key:  val_49._value._obj.丐丏七丌丕丗业且上())) == true))
            {
                goto label_83;
            }
            
            null.Add(key:  val_49._value._obj.丐丏七丌丕丗业且上(), value:  0);
            goto label_83;
            label_74:
            var val_141 = 0;
            val_141 = val_141 + 1;
            mem2[0] = 510;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_141 != 1) && ((1152921541075817280 + ((0 + 1)) << 2) == 510))
            {
                    var val_143 = val_141;
                var val_142 = 0;
                val_142 = val_142 ^ (val_143 >> 31);
                val_143 = val_143 + val_142;
            }
            
            label_96:
            if((val_29._value._obj.ContainsKey(key:  "b")) != false)
            {
                    bool val_58 = 丞东丑专丛丆丄丝世.上丅丏丐丄丙且不七(丞丕丒专一下丙业上:  val_29._value._obj.Item["b"], 丙业与丙丗丝不丈东: out  val_32 + 28);
            }
            
            if((val_29._value._obj.ContainsKey(key:  "pi")) != false)
            {
                    object val_60 = val_29._value._obj.Item["pi"];
                if(val_60 != null)
            {
                    val_156 = null;
                val_156 = null;
                val_158 = 不且丝一丌丈丛丘丌.<>c.<>9__22_1;
                if(val_158 == null)
            {
                    val_158 = null;
                val_158 = new System.Func<System.Object, Rilisoft.OfferItem>(object:  不且丝一丌丈丛丘丌.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem 不且丝一丌丈丛丘丌.<>c::丘丌丆丝丏万丝丐丈(object 七丞丙丒三丕且丌丟));
                不且丝一丌丈丛丘丌.<>c.<>9__22_1 = val_158;
            }
            
                mem[1152921541075947808] = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.Object, Rilisoft.OfferItem>(source:  val_60, selector:  null));
            }
            
            }
            
            if((val_29._value._obj.ContainsKey(key:  "pp")) != false)
            {
                    bool val_67 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_29._value._obj.Item["pp"], 丙业与丙丗丝不丈东: out  val_32 + 56);
            }
            
            if((val_29._value._obj.ContainsKey(key:  "ii")) != false)
            {
                    object val_69 = val_29._value._obj.Item["ii"];
                if(val_69 != null)
            {
                    val_159 = null;
                val_159 = null;
                val_161 = 不且丝一丌丈丛丘丌.<>c.<>9__22_2;
                if(val_161 == null)
            {
                    val_161 = null;
                val_161 = new System.Func<System.Object, Rilisoft.OfferItem>(object:  不且丝一丌丈丛丘丌.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem 不且丝一丌丈丛丘丌.<>c::丈丐丅七丄东丞丆丘(object 七丞丙丒三丕且丌丟));
                不且丝一丌丈丛丘丌.<>c.<>9__22_2 = val_161;
            }
            
                mem[1152921541075947824] = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.Object, Rilisoft.OfferItem>(source:  val_69, selector:  null));
            }
            
            }
            
            this.丈丄丂下丒专丌丛丄.Offers.Add(key:  val_29._value._obj.丐丏七丌丕丗业且上(), value:  val_32);
            goto label_130;
            label_42:
            val_162 = 0 + 1;
            mem2[0] = 823;
            val_163 = 0;
            goto label_131;
            label_139:
            if((2109232144 & 1) == 0)
            {
                goto label_132;
            }
            
            string val_75 = val_20.丐丏七丌丕丗业且上();
            if((val_75 == null) || (null != null))
            {
                goto label_139;
            }
            
            SkippedItem val_76 = AdaptiveProgress.SkippedItem.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_75);
            if(val_76 == null)
            {
                goto label_139;
            }
            
            this.丈丄丂下丒专丌丛丄.Adaptive.SkippedItems.Add(item:  val_76);
            goto label_139;
            label_132:
            val_164 = val_146 + 1;
            mem2[0] = 1087;
            goto label_140;
            label_32:
            val_146 = val_146 + 1;
            mem2[0] = 1204;
            val_147 = 1152921516630043280;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (mem[1152921541621277408] == 1204))
            {
                    var val_144 = 0;
                val_144 = val_144 ^ 0;
                val_146 =  + val_144;
            }
            
            label_205:
            if((val_5.ContainsKey(key:  "wlc")) == false)
            {
                goto label_229;
            }
            
            object val_78 = val_5.Item["wlc"];
            if(val_78 == null)
            {
                goto label_229;
            }
            
            List.Enumerator<T> val_79 = val_78.GetEnumerator();
            label_219:
            if((2109232144 & 1) == 0)
            {
                goto label_211;
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_20.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_219;
            }
            
            this.丈丄丂下丒专丌丛丄.Adaptive.Weapons_LastViewedCategoryes.Add(item:  0);
            goto label_219;
            label_211:
            val_146 = 136365033;
            mem[1152921541621277412] = 1321;
            val_147 = 1152921516630043280;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (mem[1152921541621277408] == 1321))
            {
                    var val_145 = 0;
                val_145 = val_145 ^ 0;
                val_146 =  + val_145;
            }
            
            label_229:
            if((val_5.ContainsKey(key:  "io")) != false)
            {
                    object val_84 = val_5.Item["io"];
                if(val_84 != null)
            {
                    val_165 = null;
                val_165 = null;
                val_167 = 不且丝一丌丈丛丘丌.<>c.<>9__22_3;
                if(val_167 == null)
            {
                    System.Func<System.Object, System.String> val_85 = null;
                val_167 = val_85;
                val_85 = new System.Func<System.Object, System.String>(object:  不且丝一丌丈丛丘丌.<>c.__il2cppRuntimeField_static_fields, method:  System.String 不且丝一丌丈丛丘丌.<>c::三丏丝万万丐丈丗丆(object 丄三丅七丆丛与与上));
                不且丝一丌丈丛丘丌.<>c.<>9__22_3 = val_167;
            }
            
                this.丈丄丂下丒专丌丛丄.Adaptive.IgnoreOffers = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.Object, System.String>(source:  val_84, selector:  val_85));
                val_146 = ;
                val_147 = 1152921516630043280;
            }
            
            }
            
            if((val_5.ContainsKey(key:  "glv")) == false)
            {
                goto label_262;
            }
            
            object val_89 = val_5.Item["glv"];
            if(val_89 == null)
            {
                goto label_262;
            }
            
            val_168 = this.丈丄丂下丒专丌丛丄.Adaptive;
            if(val_168 == null)
            {
                    val_168 = val_168;
            }
            
            mem2[0] = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_91 = val_89.GetEnumerator();
            label_253:
            if((2109232144 & 1) == 0)
            {
                goto label_248;
            }
            
            this.丈丄丂下丒专丌丛丄.Adaptive.GadgetsLastViewed.Add(item:  val_20.丐丏七丌丕丗业且上());
            goto label_253;
            label_248:
            val_146 = 136365033;
            mem[1152921541621277412] = 1542;
            val_147 = 1152921516630043280;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (mem[1152921541621277408] == 1542))
            {
                    var val_146 = 0;
                val_146 = val_146 ^ 0;
                val_146 =  + val_146;
            }
            
            label_262:
            if((val_5.ContainsKey(key:  "pvt")) != false)
            {
                    bool val_96 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_5.Item["pvt"], 丙业与丙丗丝不丈东: out  this.丈丄丂下丒专丌丛丄.Adaptive.PetsLastViewedOfferType);
                val_146 = ;
            }
            
            if((val_5.ContainsKey(key:  "pvp")) != false)
            {
                    this.丈丄丂下丒专丌丛丄.Adaptive.PreviousViewedPet = val_5.Item["pvp"];
                val_146 = ;
            }
            
            if((val_5.ContainsKey(key:  "mr")) != false)
            {
                    bool val_102 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_5.Item["mr"], 丙业与丙丗丝不丈东: out  this.丈丄丂下丒专丌丛丄.Adaptive.MaxBuyReal);
                val_146 = ;
            }
            
            if(((val_5.ContainsKey(key:  "sh")) != false) && (val_5.Item["sh"] != null))
            {
                    val_144 = 1152921504689381376;
                val_145 = 1152921516630043280;
            }
            else
            {
                    val_145 = 1152921516630043280;
                val_144 = 1152921504689381376;
            }
            
            label_381:
            if((val_142.ContainsKey(key:  "dt")) != false)
            {
                    object val_106 = val_142.Item["dt"];
            }
            
            val_143 = val_144;
            label_393:
            if((val_142.ContainsKey(key:  "sp")) != false)
            {
                    object val_108 = val_142.Item["sp"];
                if(val_108 != null)
            {
                    val_144 = "s";
                if((val_108.ContainsKey(key:  "s")) != false)
            {
                    val_144 = this.丈丄丂下丒专丌丛丄.StarterPack.SeasonId;
                bool val_112 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_108.Item["s"], 丙业与丙丗丝不丈东: out  val_144);
            }
            
            }
            
            }
            
            if((val_142.ContainsKey(key:  "c")) == false)
            {
                    return;
            }
            
            object val_114 = val_142.Item["c"];
            if(val_114 == null)
            {
                    return;
            }
            
            val_142 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_114) : 0;
            if((val_142.ContainsKey(key:  "wc")) == false)
            {
                    return;
            }
            
            object val_116 = val_142.Item["wc"];
            if(val_116 == null)
            {
                    return;
            }
            
            val_142 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_116) : 0;
            List.Enumerator<T> val_117 = val_142.GetEnumerator();
            val_144 = 1152921516789141600;
            val_143 = 1152921537060801728;
            label_317:
            if((2109232144 & 1) == 0)
            {
                goto label_309;
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_20.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_317;
            }
            
            this.丈丄丂下丒专丌丛丄.Common.LastBougthWeaponCategories.Add(item:  0);
            goto label_317;
            label_346:
            if((2109232144 & 1) == 0)
            {
                goto label_340;
            }
            
            string val_134 = val_20.丐丏七丌丕丗业且上();
            if((val_134 == null) || (null != null))
            {
                goto label_346;
            }
            
            new DailyTierProgress.DailyTierOffersSettingKey() = new DailyTierProgress.DailyTierOffersSettingKey(丞丕丒专一下丙业上:  val_134);
            this.丈丄丂下丒专丌丛丄.DailyTier.SelectedSettings.Add(item:  new DailyTierProgress.DailyTierOffersSettingKey());
            goto label_346;
            label_355:
            if((2109232256 & 1) == 0)
            {
                goto label_347;
            }
            
            ConfiguredValueTaskAwaiter val_138 = val_20.GetAwaiter();
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_138._value._obj, 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_355;
            }
            
            this.丈丄丂下丒专丌丛丄.Adaptive.OffersShowCounter.Add(key:  val_138._value._obj.丐丏七丌丕丗业且上(), value:  0);
            goto label_355;
            label_340:
            val_169 = 0;
            val_170 = 136365033;
            mem[1152921541621277412] = 2148;
            goto label_356;
            label_309:
            val_171 = 0;
            val_145 = 136365033;
            mem[1152921541621277412] = 2388;
            goto label_357;
            label_347:
            val_172 = 136365033;
            mem[1152921541621277412] = 1819;
            val_173 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (mem[1152921541621277408] != 1819))
            {
                goto label_378;
            }
            
            var val_147 = 0;
            val_147 = val_147 ^ 0;
             =  + val_147;
            goto label_381;
            label_378:
            if( == 0)
            {
                goto label_381;
            }
            
            goto label_381;
            label_357:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(1152921516630043280 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(mem[1152921541621277408] == 2388)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
            
            return;
            label_356:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (mem[1152921541621277408] != 2148))
            {
                goto label_390;
            }
            
            var val_148 = 0;
            val_148 = val_148 ^ 0;
             =  + val_148;
            goto label_393;
            label_390:
            if( == 0)
            {
                goto label_393;
            }
            
            goto label_393;
            label_140:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (mem[1152921541621277408] != 1087))
            {
                goto label_396;
            }
            
            var val_149 = 0;
            val_149 = val_149 ^ 0;
             =  + val_149;
            goto label_399;
            label_396:
            if(val_20 == 0)
            {
                goto label_399;
            }
            
            goto label_399;
            label_131:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || ((1152921541075817280 + (((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31))) << 2) != 823))
            {
                goto label_405;
            }
            
            var val_150 = 0;
            val_150 = val_150 ^ ( >> 31);
             =  + val_150;
            goto label_408;
            label_405:
            if( == 0)
            {
                goto label_408;
            }
            
            goto label_408;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丈丄丂下丒专丌丛丄 = new Progress.OffersProgressData();
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_6;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.丈丄丂下丒专丌丛丄.Offers.GetEnumerator();
            label_5:
            if((2110115072 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            val_2.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  Progress.OfferProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_7._value._obj));
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            val_1.set_Item(key:  "o", value:  val_2);
            val_1.set_Item(key:  "ad", value:  Progress.AdaptiveProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  this.丈丄丂下丒专丌丛丄.Adaptive));
            val_1.set_Item(key:  "dt", value:  Progress.DailyTierProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  this.丈丄丂下丒专丌丛丄.DailyTier));
            val_1.set_Item(key:  "sp", value:  Progress.StarterPackProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  this.丈丄丂下丒专丌丛丄.StarterPack));
            val_1.set_Item(key:  "c", value:  Progress.CommonProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  this.丈丄丂下丒专丌丛丄.Common));
            return (object)val_1;
        }
        internal Progress.OfferProgress 上丑下专丄下丟丏丆(string 丗丟丁丐与下丙丕丛)
        {
            var val_3;
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  丗丟丁丐与下丙丕丛)) != false)
            {
                    Progress.OfferProgress val_2 = this.丈丄丂下丒专丌丛丄.Offers.Item[丗丟丁丐与下丙丕丛];
                return (Progress.OfferProgress)val_3;
            }
            
            val_3 = 0;
            return (Progress.OfferProgress)val_3;
        }
        internal Progress.OfferProgress 下万下丁丂丙下丞丕(string 丗丟丁丐与下丙丕丛)
        {
            string val_6;
            var val_7;
            val_6 = 丗丟丁丐与下丙丕丛;
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  val_6)) != false)
            {
                    val_6 = this.丈丄丂下丒专丌丛丄.Offers.Item[val_6];
                if(val_6.Clone() == null)
            {
                    return (Progress.OfferProgress)val_7;
            }
            
            }
            
            val_7 = 0;
            return (Progress.OfferProgress)val_7;
        }
        internal System.Collections.Generic.List<string> 丕丂东丘丗丘不丏丅()
        {
            return System.Linq.Enumerable.ToList<System.String>(source:  this.丈丄丂下丒专丌丛丄.Offers.Keys);
        }
        internal void 丂丙丌丙丞丑与丑三(Progress.OfferProgress 丐丆丂丒丁万丈丛丅)
        {
            Progress.OfferProgress val_5;
            string val_6;
            val_5 = 丐丆丂丒丁万丈丛丅;
            val_6 = this;
            if(val_5 == null)
            {
                    return;
            }
            
            val_6 = 丐丆丂丒丁万丈丛丅.Id;
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  丐丆丂丒丁万丈丛丅.Id)) == false)
            {
                goto label_5;
            }
            
            val_5 = val_5.Clone();
            if(this.丈丄丂下丒专丌丛丄.Offers == null)
            {
                goto label_6;
            }
            
            if(val_5 != null)
            {
                goto label_7;
            }
            
            goto label_12;
            label_5:
            this.丈丄丂下丒专丌丛丄.Offers.Add(key:  val_6, value:  val_5);
            return;
            label_6:
            if(val_5 == null)
            {
                goto label_12;
            }
            
            label_7:
            val_5 = 0;
            label_12:
            this.丈丄丂下丒专丌丛丄.Offers.set_Item(key:  val_6, value:  val_5);
        }
        internal void 丂丗丞丞且万丛万不(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丕丒丞丈丂丂丒上下)
        {
            var val_4;
            if(丕丒丞丈丂丂丒上下 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = 丕丒丞丈丂丂丒上下.GetEnumerator();
            label_24:
            if((2111031424 & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if((val_5._value._obj == 0) || ((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  val_5._value._obj)) == false))
            {
                goto label_4;
            }
            
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  val_5._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_7;
            }
            
            this.丈丄丂下丒专丌丛丄.Offers.Item[val_5._value._obj.丐丏七丌丕丗业且上()].丂丗丞丞且万丛万不(丏丂万业丙专丏丒丒:  val_5._value._obj);
            goto label_24;
            label_4:
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  val_5._value._obj.丐丏七丌丕丗业且上())) == false)
            {
                goto label_24;
            }
            
            bool val_14 = this.丈丄丂下丒专丌丛丄.Offers.Remove(key:  val_5._value._obj.丐丏七丌丕丗业且上());
            goto label_24;
            label_7:
            new Progress.OfferProgress() = new Progress.OfferProgress(丏丂万业丙专丏丒丒:  val_5._value._obj);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  (Progress.OfferProgress)[1152921541077718256].Id)) != false)
            {
                    .Id = val_5._value._obj.丐丏七丌丕丗业且上();
            }
            
            this.丈丄丂下丒专丌丛丄.Offers.Add(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  new Progress.OfferProgress());
            goto label_24;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 丗与丐丄七东丘专丘(string 丗丟丁丐与下丙丕丛)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丗丟丁丐与下丙丕丛)) == true)
            {
                    return;
            }
            
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  丗丟丁丐与下丙丕丛)) == false)
            {
                    return;
            }
            
            bool val_3 = this.丈丄丂下丒专丌丛丄.Offers.Remove(key:  丗丟丁丐与下丙丕丛);
        }
        internal void 丙且丙丗丂丝业丐丙(System.Collections.Generic.List<string> 世丅丈东丘丐丕丟丐)
        {
            if(世丅丈东丘丐丕丟丐 == null)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.Any<System.String>(source:  世丅丈东丘丐丕丟丐)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = 世丅丈东丘丐丕丟丐.GetEnumerator();
            label_9:
            if((2111402920 & 1) == 0)
            {
                goto label_3;
            }
            
            string val_3 = 0.丐丏七丌丕丗业且上();
            if((this.丈丄丂下丒专丌丛丄.Offers.ContainsKey(key:  val_3)) == false)
            {
                goto label_9;
            }
            
            bool val_5 = this.丈丄丂下丒专丌丛丄.Offers.Remove(key:  val_3);
            goto label_9;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal static string 丆且专下丗上丆世丅(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗与丟上上丑专世丗)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            if((Progress.不且丝一丌丈丛丘丌.丆业丛丟丘丂与七一.ContainsKey(key:  丗与丟上上丑专世丗)) != false)
            {
                    val_4 = null;
                val_4 = null;
                string val_2 = Progress.不且丝一丌丈丛丘丌.丆业丛丟丘丂与七一.Item[丗与丟上上丑专世丗];
                return (string)val_5;
            }
            
            val_5 = 0;
            return (string)val_5;
        }
        public 不且丝一丌丈丛丘丌()
        {
            this.丈丄丂下丒专丌丛丄 = new Progress.OffersProgressData();
        }
        private static 不且丝一丌丈丛丘丌()
        {
            Progress.不且丝一丌丈丛丘丌.丕丟一七丑丙丂丆丙 = "Offers_slot";
            Progress.不且丝一丌丈丛丘丌.丐丌丞上世丛丐丏丛 = "Offers_slot";
            System.Collections.Generic.Dictionary<OfferModule, System.String> val_1 = new System.Collections.Generic.Dictionary<OfferModule, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  60, value:  "ad_");
            }
            else
            {
                    val_1.Add(key:  60, value:  "ad_");
            }
            
            val_1.Add(key:  90, value:  "dt_");
            if(val_1 != null)
            {
                    val_1.Add(key:  100, value:  "sp_");
            }
            else
            {
                    val_1.Add(key:  100, value:  "sp_");
            }
            
            val_1.Add(key:  80, value:  "md_");
            if(val_1 != null)
            {
                    val_1.Add(key:  40, value:  "es_");
            }
            else
            {
                    val_1.Add(key:  40, value:  "es_");
            }
            
            val_1.Add(key:  140, value:  "tb_");
            Progress.不且丝一丌丈丛丘丌.丆业丛丟丘丂与七一 = val_1;
        }
    
    }

}
