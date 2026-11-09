using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal class 丐丞业丅业丝丐世不
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 丐不且且丅丏丅一三;
        private readonly System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 丗专一下世业万丒世;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.三东丏不丗世丅丌丄> 丝与专丆丑三丙一下;
        
        // Properties
        internal System.Collections.Generic.Dictionary<int, PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 与丒与丐丄丙专丘丆 { get; }
        internal System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 丒丄三不业与丒丈与 { get; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<int, PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 上丝丞业丞丑世丄七()
        {
            return (System.Collections.Generic.Dictionary<System.Int32, PGCompany.TrophyRoad.丈专世丅丞万丌东丗>)this.丐不且且丅丏丅一三;
        }
        internal System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 丞丟业世丑丌丄丅七()
        {
            return (System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗>)this.丗专一下世业万丒世;
        }
        internal void 丛丛丅东丅丈丁与丏(PGCompany.TrophyRoad.丘丄丟丑专东丐丑丞 三丁丕丒丕丒丌丆丞)
        {
            int val_7;
            int val_27;
            int val_35;
            int val_36;
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_39;
            System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗> val_73;
            var val_75;
            var val_76;
            PGCompany.TrophyRoad.一丞下下且丐丛丕三 val_78;
            var val_79;
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_80;
            var val_81;
            int val_82;
            var val_83;
            var val_85;
            var val_87;
            var val_88;
            var val_89;
            this.丐不且且丅丏丅一三.Clear();
            val_73 = this.丗专一下世业万丒世;
            val_73.Clear();
            if(三丁丕丒丕丒丌丆丞 == null)
            {
                    return;
            }
            
            if(this.丝与专丆丑三丙一下.Count <= 0)
            {
                goto label_5;
            }
            
            label_61:
            val_73 = 三丁丕丒丕丒丌丆丞.RewardsConfig;
            if(三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards == null)
            {
                    return;
            }
            
            val_73 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards;
            if(val_73.Count == 0)
            {
                    return;
            }
            
            int val_4 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.Count;
            List.Enumerator<T> val_5 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.GetEnumerator();
            val_75 = 1152921559538176240;
            label_23:
            if(((-902952768) & 1) == 0)
            {
                goto label_18;
            }
            
            int val_9 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.Count;
            PGCompany.七丑一上且三世丝三<System.Int32, PGCompany.TrophyRoad.丈专世丅丞万丌东丗>.万世丅七一专丕丞不().set_Item(key:  val_8.m_stringLength - ((val_8.m_stringLength / val_9) * val_9), value:  val_7.丐丏七丌丕丗业且上());
            goto label_23;
            label_5:
            if(三丁丕丒丕丒丌丆丞.RewardsConfig.ReplaceRewardSettings == null)
            {
                goto label_61;
            }
            
            List.Enumerator<T> val_12 = 三丁丕丒丕丒丌丆丞.RewardsConfig.ReplaceRewardSettings.GetEnumerator();
            label_44:
            if(((-902952736) & 1) == 0)
            {
                goto label_28;
            }
            
            if(((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_13.m_stringLength)) == false) || ((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_13.m_stringLength)) == false))
            {
                goto label_44;
            }
            
            if((this.丝与专丆丑三丙一下.ContainsKey(key:  val_13.m_stringLength.业东丅东丌上丗丑不())) == false)
            {
                goto label_38;
            }
            
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "dublicate raplacement item in trophy road, item: \'{0}\'", arg0:  val_13.m_stringLength));
            goto label_44;
            label_38:
            this.丝与专丆丑三丙一下.Add(key:  val_13.m_stringLength.业东丅东丌上丗丑不(), value:  val_7.丐丏七丌丕丗业且上());
            goto label_44;
            label_18:
            val_76 = public System.Void List.Enumerator<PGCompany.TrophyRoad.丈专世丅丞万丌东丗>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_64;
            label_28:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_61;
            label_64:
            val_78 = 三丁丕丒丕丒丌丆丞.RewardsConfig;
            if(三丁丕丒丕丒丌丆丞.RewardsConfig == null)
            {
                    val_78 = 三丁丕丒丕丒丌丆丞.RewardsConfig;
                if(val_78 == null)
            {
                goto label_151;
            }
            
            }
            
            val_79 = public PGCompany.TrophyRoad.丈专世丅丞万丌东丗 System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗>::get_Item(int index);
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_22 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.Item[三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.Count - 1];
            System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗> val_23 = null;
            val_75 = val_23;
            val_23 = new System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗>();
            List.Enumerator<T> val_25 = 三丁丕丒丕丒丌丆丞.RewardsConfig.IncreaseTokensSettings.GetEnumerator();
            goto label_75;
            label_116:
            string val_26 = val_7.丐丏七丌丕丗业且上();
            if((val_26.m_stringLength < 1) || (val_26.m_stringLength < 1))
            {
                goto label_75;
            }
            
            goto label_115;
            label_101:
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_29 = 三丁丕丒丕丒丌丆丞.RewardsConfig.ReplaceRewardSettings.Item[val_27];
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_32 = 三丁丕丒丕丒丌丆丞.RewardsConfig.ReplaceRewardSettings.Item[val_27];
            var val_72 = val_36;
            val_72 = val_35 / val_72;
            val_72 = val_72 + 1;
            val_72 = 三丁丕丒丕丒丌丆丞.RewardsConfig.IncreaseRewardsSettings.Item[val_27] * val_72;
            label_108:
            if((val_39 + 24) == 0)
            {
                    val_27 = val_39 + 24;
            }
            
            val_27.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_32.GeneralRewards.Item[0].业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  val_29.GeneralRewards.Item[0].丂丁丏一丙丛业且丌() + val_72));
            val_80 = val_39;
            mem2[0] = val_26.m_firstChar;
            val_79 = public System.Void System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗>::Add(PGCompany.TrophyRoad.丈专世丅丞万丌东丗 item);
            val_23.Add(item:  val_80);
            int val_73 = val_22.Level + 1;
            val_73 = val_73 + 1;
            goto label_89;
            label_115:
            val_36 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.Count;
            int val_41 = 三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards.Count;
            int val_74 = val_73;
            int val_75 = val_22.Level;
            val_74 = val_74 - val_75;
            val_75 = val_74 / val_41;
            int val_42 = val_74 - (val_75 * val_41);
            val_35 = val_74;
            val_27 = val_42;
            if(((三丁丕丒丕丒丌丆丞.RewardsConfig.ReplaceRewardSettings.ContainsKey(key:  val_42)) == false) || ((三丁丕丒丕丒丌丆丞.RewardsConfig.IncreaseRewardsSettings.ContainsKey(key:  val_27)) == false))
            {
                goto label_98;
            }
            
            new PGCompany.TrophyRoad.丈专世丅丞万丌东丗() = new PGCompany.TrophyRoad.丈专世丅丞万丌东丗();
            val_39 = new PGCompany.TrophyRoad.丈专世丅丞万丌东丗();
            .Level = val_73;
            if((三丁丕丒丕丒丌丆丞.UniqueRewards.ContainsKey(key:  val_73)) == false)
            {
                goto label_101;
            }
            
            val_27 = 三丁丕丒丕丒丌丆丞.UniqueRewards.Item[val_73].Item[0].业东丅东丌上丗丑不();
            PGCompany.三东丏不丗世丅丌丄 val_53 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_27, 丂丕丂丏专丂丄丕且:  三丁丕丒丕丒丌丆丞.UniqueRewards.Item[val_73].Item[0].丂丁丏一丙丛业且丌());
            goto label_108;
            label_98:
            object[] val_54 = new object[1];
            val_80 = val_54;
            val_7 = val_27;
            val_27 = val_7;
            val_80[0] = val_27;
            val_79 = 0;
            UnityEngine.Debug.LogErrorFormat(format:  "!increasePatternRewards.ContainsKey({0}). ERROR CONFIG!!", args:  val_54);
            label_89:
            var val_76 = 0;
            val_76 = val_76 + 1;
            if(val_76 < val_26.m_stringLength)
            {
                goto label_115;
            }
            
            label_75:
            if(((-902952800) & 1) != 0)
            {
                goto label_116;
            }
            
            val_81 = 0;
            val_82 = 0;
            goto label_117;
            label_151:
            val_83 = 0;
            if(val_76 != 1)
            {
                goto label_215;
            }
            
            val_82 = 1179403647;
            val_81 = 0;
            label_117:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_81 != 1) && (835 == 835))
            {
                    val_81 = 0;
            }
            else
            {
                    if(val_82 != 0)
            {
                    val_79 = 0;
                val_82 = 0;
            }
            
            }
            
            PGCompany.七丑一上且三世丝三<K, V> val_55 = PGCompany.七丑一上且三世丝三<System.Int32, PGCompany.TrophyRoad.丈专世丅丞万丌东丗>.万世丅七一专丕丞不();
            this.丗专一下世业万丒世.AddRange(collection:  三丁丕丒丕丒丌丆丞.RewardsConfig.TutorRewards);
            this.丗专一下世业万丒世.AddRange(collection:  三丁丕丒丕丒丌丆丞.RewardsConfig.PatternRewards);
            this.丗专一下世业万丒世.AddRange(collection:  1152921539550912464);
            List.Enumerator<T> val_56 = this.丗专一下世业万丒世.GetEnumerator();
            goto label_179;
            label_186:
            if((val_7.丐丏七丌丕丗业且上() == null) || ((Progress.七七世万专丕丁上业.且丙丈丑下丄丈万不().丑三三丝下丙丌丄下(丈丘丝一丗下丈丐不:  val_57.m_stringLength)) == true))
            {
                goto label_179;
            }
            
            if(val_57.m_stringLength == 0)
            {
                goto label_172;
            }
            
            val_85 = 0;
            goto label_173;
            label_178:
            PGCompany.三东丏不丗世丅丌丄 val_61 = val_57.m_stringLength.Item[0];
            if((this.丘世丏东丌与东丞丏(丗七丟丈三不丕一三: ref  val_61)) != false)
            {
                    set_Item(index:  0, value:  val_61);
            }
            
            val_85 = 1;
            label_173:
            if(val_85 < val_61.Count)
            {
                goto label_178;
            }
            
            label_172:
            if(val_61 == 0)
            {
                goto label_179;
            }
            
            val_87 = 0;
            goto label_180;
            label_185:
            PGCompany.三东丏不丗世丅丌丄 val_65 = val_61.Item[0];
            if((this.丘世丏东丌与东丞丏(丗七丟丈三不丕一三: ref  val_65)) != false)
            {
                    set_Item(index:  0, value:  val_65);
            }
            
            val_87 = 1;
            label_180:
            if(val_87 < val_65.Count)
            {
                goto label_185;
            }
            
            label_179:
            if(((-902952768) & 1) != 0)
            {
                goto label_186;
            }
            
            val_88 = 1;
            val_89 = 1152921559533932240;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_88 != 1) && (1142 == 1142))
            {
                    var val_77 = 0;
                val_77 = val_77 ^ 0;
                val_88 = val_88 + val_77;
            }
            else
            {
                    if( != 0)
            {
                    val_82 = 0;
            }
            
            }
            
            val_73 = this.丗专一下世业万丒世;
            List.Enumerator<T> val_68 = val_73.GetEnumerator();
            label_209:
            if(((-902952768) & 1) == 0)
            {
                goto label_203;
            }
            
            if((三丁丕丒丕丒丌丆丞.SlotRewards.ContainsKey(key:  val_69.m_stringLength)) != false)
            {
                    mem2[0] = 三丁丕丒丕丒丌丆丞.SlotRewards.Item[val_69.m_stringLength];
            }
            
            this.丐不且且丅丏丅一三.set_Item(key:  val_69.m_stringLength, value:  val_7.丐丏七丌丕丗业且上());
            goto label_209;
            label_203:
            val_88 = val_88 + 1;
            mem2[0] = 1256;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_88 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921559538468896 + ((val_88 + 1)) << 2) == 1256)
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
            label_215:
        }
        private bool 丘世丏东丌与东丞丏(ref PGCompany.三东丏不丗世丅丌丄 丗七丟丈三不丕一三)
        {
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.三东丏不丗世丅丌丄> val_7;
            PGCompany.三东丏不丗世丅丌丄 val_8 = 丗七丟丈三不丕一三;
            if(val_8 == null)
            {
                    return (bool)val_8;
            }
            
            val_7 = this.丝与专丆丑三丙一下;
            if((val_7.ContainsKey(key:  val_8.业东丅东丌上丗丑不())) == false)
            {
                goto label_3;
            }
            
            val_7 = 丗七丟丈三不丕一三;
            if((PGCompany.TrophyRoad.下丌丆丙丟丝世上丈.丑七不且上丗丁一世().东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_7)) == false)
            {
                goto label_7;
            }
            
            label_3:
            val_8 = 0;
            return (bool)val_8;
            label_7:
            val_7 = 丗七丟丈三不丕一三.业东丅东丌上丗丑不();
            丗七丟丈三不丕一三 = this.丝与专丆丑三丙一下.Item[val_7];
            val_8 = 1;
            return (bool)val_8;
        }
        public 丐丞业丅业丝丐世不()
        {
            this.丐不且且丅丏丅一三 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.TrophyRoad.丈专世丅丞万丌东丗>();
            this.丗专一下世业万丒世 = new System.Collections.Generic.List<PGCompany.TrophyRoad.丈专世丅丞万丌东丗>();
            this.丝与专丆丑三丙一下 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.三东丏不丗世丅丌丄>();
        }
    
    }

}
