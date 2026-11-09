using UnityEngine;

namespace Rilisoft
{
    internal sealed class BonuseForFirstWinVideoController : AdsRewardWatchController
    {
        // Fields
        private static Rilisoft.BonuseForFirstWinVideoController 世丒丞七专三与万丕;
        private const string 业丒东丒丆丐丙丘万 = "Ads.X3BonusCount";
        private const string 与丈丝丑丑上万丅丅 = "Ads.X3BonusTimestamp";
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        internal static Rilisoft.BonuseForFirstWinVideoController 丆丕丝丒不丙且丐丗 { get; }
        protected override string 且丙丏丟不专丗且丒 { get; }
        internal int 专丟丙丘丝丂且专上 { get; }
        
        // Methods
        private BonuseForFirstWinVideoController()
        {
        
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        internal static Rilisoft.BonuseForFirstWinVideoController 丑七不且上丗丁一世()
        {
            return (Rilisoft.BonuseForFirstWinVideoController)Rilisoft.BonuseForFirstWinVideoController.与丈丝丑丑上万丅丅;
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "afterMatch";
        }
        internal int 丅世丁七世丂丅专丑()
        {
            return this.丏七丌下丐丐丙丞下();
        }
        private int 丏七丌下丐丐丙丞下()
        {
            var val_19;
            object val_20;
            var val_21;
            string val_23;
            string val_24;
            string val_25;
            object val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            string val_7 = 0;
            int val_1 = Rilisoft.BonuseForFirstWinVideoController.丑且一业且丂丝丆丂();
            if((val_1 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_7)) == false)
            {
                goto label_5;
            }
            
            val_20 = 28563616;
            if(val_20 == 0)
            {
                goto label_7;
            }
            
            var val_21 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_8;
            }
            
            var val_19 = mem[-484215838895566158];
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_10:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (mem[-484215838895566048]))
            {
                goto label_10;
            }
            
            label_8:
            val_19 = 0;
            goto label_11;
            label_1:
            string val_10 = val_1.ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈());
            val_23 = "[BonuseForFirstWinVideoController.GetRemainedCount] shownCount: ";
            goto label_12;
            label_5:
            val_24 = val_7;
            val_25 = "[BonuseForFirstWinVideoController.GetRemainedCount] ";
            goto label_13;
            label_7:
            val_26 = "[BonuseForFirstWinVideoController.GetRemainedCount] rewards: null";
            goto label_16;
            label_9:
            val_21 = val_21 + (((mem[-484215838895566158] + 8)) << 4);
            val_21 = val_21 + 296;
            label_11:
            int val_11 = val_20.Count;
            var val_24 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_17;
            }
            
            var val_22 = mem[-484215838895566158];
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_19:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (mem[-484215838895566048]))
            {
                goto label_19;
            }
            
            label_17:
            val_19 = 0;
            goto label_20;
            label_18:
            val_24 = val_24 + (((mem[-484215838895566158] + 8)) << 4);
            val_27 = val_24 + 296;
            label_20:
            if(val_1 >= val_20.Count)
            {
                goto label_21;
            }
            
            var val_27 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_22;
            }
            
            var val_25 = mem[-484215838895566158];
            var val_26 = 0;
            val_25 = val_25 + 8;
            label_24:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25 + 16;
            if(val_26 < (mem[-484215838895566048]))
            {
                goto label_24;
            }
            
            label_22:
            val_19 = 0;
            goto label_25;
            label_21:
            val_23 = "[BonuseForFirstWinVideoController.GetRemainedCount] rewardCount: ";
            label_12:
            val_24 = val_11.ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈());
            val_25 = val_23;
            label_13:
            val_20 = val_25 + val_24;
            val_26 = val_20;
            label_16:
            UnityEngine.Debug.LogWarning(message:  val_26);
            return 0;
            label_23:
            val_27 = val_27 + (((mem[-484215838895566158] + 8)) << 4);
            val_28 = val_27 + 296;
            label_25:
            val_29 = public T System.Collections.Generic.IReadOnlyList<T>::get_Item(int index);
            var val_31 = 1;
            int val_17 = val_1 + 1;
            if(val_17 >= val_11)
            {
                    return 0;
            }
            
            label_34:
            var val_30 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_29;
            }
            
            var val_28 = mem[-484215838895566158];
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_31:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_30;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < (mem[-484215838895566048]))
            {
                goto label_31;
            }
            
            label_29:
            val_29 = 0;
            goto label_32;
            label_30:
            val_30 = val_30 + (((mem[-484215838895566158] + 8)) << 4);
            val_30 = val_30 + 296;
            label_32:
            if(val_20.Item[val_17] != val_20.Item[val_1])
            {
                    return 0;
            }
            
            val_17 = val_17 + 1;
            val_31 = val_31 + 1;
            if(val_17 < val_11)
            {
                goto label_34;
            }
            
            return 0;
        }
        internal bool 丗丒丅丛丒丏丟不丘(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 丏世丈七一丟东丂丅)
        {
            if((丏世丈七一丟东丂丅 & 2147483648) != 0)
            {
                    return false;
            }
            
            int val_1 = 丏世丈七一丟东丂丅 + 1;
            if(上且丗一丏丏万丅丌 <= 16)
            {
                goto label_1;
            }
            
            if(上且丗一丏丏万丅丌 == 20)
            {
                goto label_2;
            }
            
            if(上且丗一丏丏万丅丌 == 22)
            {
                goto label_3;
            }
            
            label_6:
            if(val_1 <= 3)
            {
                    return this.丄丛丅丐世丌丕且丛();
            }
            
            return false;
            label_1:
            if(上且丗一丏丏万丅丌 == 8)
            {
                goto label_5;
            }
            
            if(上且丗一丏丏万丅丌 != 16)
            {
                goto label_6;
            }
            
            label_3:
            if(val_1 >= 3)
            {
                    return false;
            }
            
            return this.丄丛丅丐世丌丕且丛();
            label_2:
            if(val_1 >= 11)
            {
                    return false;
            }
            
            return this.丄丛丅丐世丌丕且丛();
            label_5:
            if(val_1 >= 2)
            {
                    return false;
            }
            
            return this.丄丛丅丐世丌丕且丛();
        }
        internal bool 丄丛丅丐世丌丕且丛()
        {
            string val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_30 = this;
            string val_12 = 0;
            if(GameConnect.不专专丂万丝上东丐() != false)
            {
                    val_30 = "[BonuseForFirstWinVideoController.AreAdcAvailable] isMiniGame: "("[BonuseForFirstWinVideoController.AreAdcAvailable] isMiniGame: ") + GameConnect.不专专丂万丝上东丐().ToString();
                UnityEngine.Debug.LogFormat(format:  val_30, args:  System.Array.Empty<System.Object>());
                val_31 = 0;
                return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  true);
            }
            
            丕丄丘不专丘七专与 val_11 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_11, 丏丞专丏业丗丝七丝: out  val_12)) == false)
            {
                goto label_12;
            }
            
            if((this.且世丄丙丄丕丌不下(与丒丌丈七不专三一:  false, 丁丂丕与丁丒丕丟丞: out  val_12)) == false)
            {
                goto label_13;
            }
            
            val_32 = val_30;
            bool val_15 = this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  val_12, 与丗丆丏丙丟与丒业:  "AreAdcAvailable");
            goto label_48;
            label_12:
            val_32 = val_30;
            label_48:
            val_33 = 0;
            label_56:
            if(val_11 != 0)
            {
                    this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_11);
            }
            
            if(val_33 == 1)
            {
                goto label_16;
            }
            
            if(295 != 295)
            {
                goto label_17;
            }
            
            var val_18 = ((this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  val_12, 与丗丆丏丙丟与丒业:  "AreAdcAvailable")) == true) ? 1 : 0;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  true);
            label_16:
            if(0 != 0)
            {
                goto label_19;
            }
            
            goto label_22;
            label_17:
            if((0 == 0) || (295 == 195))
            {
                goto label_22;
            }
            
            label_19:
            label_22:
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  42);
            val_33 = 1152921505266909184;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Ads.X3BonusTimestamp")) == false)
            {
                goto label_25;
            }
            
            if((System.Int64.TryParse(s:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Ads.X3BonusTimestamp"), result: out  0)) == false)
            {
                goto label_28;
            }
            
            goto label_29;
            label_25:
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Ads.X3BonusTimestamp", 下下丏一丙不丘丌丞:  "0");
            label_28:
            label_29:
            if((Rilisoft.BonuseForFirstWinVideoController.丝丒丘丞丕万丅丙专(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_32;
            }
            
            val_33 = 0;
            if(0 <= (丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime())))
            {
                goto label_35;
            }
            
            label_32:
            UnityEngine.Debug.LogWarning(message:  "[BonuseForFirstWinVideoController.AreAdcAvailable] Ad is not available by timer");
            val_31 = 0;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  true);
            label_13:
            if(28563616 == 0)
            {
                goto label_40;
            }
            
            var val_32 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_44;
            }
            
            var val_30 = mem[-484215838895566158];
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_43:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (mem[-484215838895566048]))
            {
                goto label_43;
            }
            
            goto label_44;
            label_35:
            val_31 = val_30;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  true);
            label_40:
            bool val_27 = this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  "rewards", 与丗丆丏丙丟与丒业:  "AreAdcAvailable");
            goto label_48;
            label_42:
            val_32 = val_32 + (((mem[-484215838895566158] + 8)) << 4);
            val_34 = val_32 + 296;
            label_44:
            if(28563616.Count == 0)
            {
                goto label_46;
            }
            
            goto label_56;
            label_46:
            bool val_29 = this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  "Count", 与丗丆丏丙丟与丒业:  "AreAdcAvailable");
            goto label_48;
        }
        internal bool 三丙丆丕丗专丐丆丗(System.Action 业丏丈世世世丞丒世)
        {
            System.Action val_34;
            Rilisoft.BonuseForFirstWinVideoController val_35;
            var val_36;
            val_34 = 业丏丈世世世丞丒世;
            val_35 = this;
            string val_5 = 0;
            string val_8 = 0;
            丕丄丘不专丘七专与 val_7 = 0;
            BonuseForFirstWinVideoController.丕丛业丁丏下一七丘 val_1 = new BonuseForFirstWinVideoController.丕丛业丁丏下一七丘();
            if(val_1 != null)
            {
                    .业丏丈世世世丞丒世 = val_34;
            }
            else
            {
                    mem[16] = val_34;
            }
            
            .丝且与丝丒丟万丁专 = val_35;
            if(this.TryShowAdcInterface() == false)
            {
                goto label_13;
            }
            
            val_34 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_34.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  val_5, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_7, 丏丞专丏业丗丝七丝: out  val_8)) == false)
            {
                goto label_7;
            }
            
            int val_10 = Rilisoft.BonuseForFirstWinVideoController.丑且一业且丂丝丆丂();
            if((PGCompany.DataObjects.丑丈丂丘专丐丂丘丑.丗丙丑三丒业与丟丛(丌东丙丝丂一丅三丞:  val_7, 丞丁下丈专三丄丅一:  val_10, 丗七丟丈三不丕一三: out  1152921543548779992)) == false)
            {
                goto label_8;
            }
            
            this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈())(ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈())));
            val_34 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4051");
            this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈(), format:  val_34, arg0:  ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈())));
            if((Rilisoft.BonuseForFirstWinVideoController.丝丒丘丞丕万丅丙专(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_13;
            }
            
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
            this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime(), 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
            val_35 = this.RewardedVideo;
            System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_29 = null;
            val_34 = val_29;
            val_29 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void BonuseForFirstWinVideoController.丕丛业丁丏下一七丘::东世丙丝上丑上丈万(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
            val_35.add_EnterIdle(丙业与丙丗丝不丈东:  val_29);
            val_36 = 1;
            return (bool)val_36;
            label_7:
            string val_30 = "[BonuseForFirstWinVideoController.TryShowAdcInterface] " + val_8;
            goto label_18;
            label_8:
            mem[1152921543548779992] = 1;
            label_18:
            val_35 = "[BonuseForFirstWinVideoController.TryShowAdcInterface] TryGetReward: False, showCount: "("[BonuseForFirstWinVideoController.TryShowAdcInterface] TryGetReward: False, showCount: ") + val_10.ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈())(val_10.ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈())) + ", category: "(", category: ") + val_5;
            UnityEngine.Debug.LogWarning(message:  val_35);
            label_13:
            val_36 = 0;
            return (bool)val_36;
        }
        internal int 丕三七丏且下丞丛不()
        {
            return (int)this;
        }
        internal int 世丁上丅且丂丄丁丑()
        {
            var val_14;
            object val_15;
            object val_16;
            var val_17;
            object val_18;
            var val_19;
            var val_20;
            var val_21;
            丕丄丘不专丘七专与 val_5 = 0;
            string val_6 = 0;
            val_15 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_15.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) == true)
            {
                goto label_4;
            }
            
            val_14 = 0;
            val_16 = "[BonuseForFirstWinVideoController.GetNextReward] " + val_6;
            val_15 = val_16;
            UnityEngine.Debug.LogWarning(message:  val_15);
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            label_4:
            int val_20 = Rilisoft.BonuseForFirstWinVideoController.丑且一业且丂丝丆丂();
            val_16 = 28563616;
            if(val_16 == 0)
            {
                goto label_9;
            }
            
            var val_16 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_10;
            }
            
            var val_14 = mem[-484215838895566158];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_12:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[-484215838895566048]))
            {
                goto label_12;
            }
            
            label_10:
            val_14 = 0;
            goto label_13;
            label_9:
            val_18 = "[BonuseForFirstWinVideoController.GetNextReward] rewards";
            goto label_16;
            label_11:
            val_16 = val_16 + (((mem[-484215838895566158] + 8)) << 4);
            val_17 = val_16 + 296;
            label_13:
            if(val_16.Count == 0)
            {
                goto label_17;
            }
            
            var val_19 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_18;
            }
            
            var val_17 = mem[-484215838895566158];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_20:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (mem[-484215838895566048]))
            {
                goto label_20;
            }
            
            label_18:
            val_14 = 0;
            goto label_21;
            label_17:
            val_18 = "[BonuseForFirstWinVideoController.GetNextReward] Count";
            label_16:
            UnityEngine.Debug.LogWarning(message:  val_18);
            label_7:
            val_20 = 1;
            return (int)val_20.Item[val_20];
            label_19:
            val_19 = val_19 + (((mem[-484215838895566158] + 8)) << 4);
            val_19 = val_19 + 296;
            label_21:
            int val_11 = val_16.Count;
            var val_23 = -1878846974;
            val_20 = val_20 - ((val_20 / val_11) * val_11);
            if((mem[-484215838895566048]) == 0)
            {
                goto label_25;
            }
            
            var val_21 = mem[-484215838895566158];
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_27:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_26;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (mem[-484215838895566048]))
            {
                goto label_27;
            }
            
            label_25:
            val_14 = 0;
            goto label_28;
            label_26:
            val_23 = val_23 + (((mem[-484215838895566158] + 8)) << 4);
            val_21 = val_23 + 296;
            label_28:
            val_20 = val_16;
            return (int)val_20.Item[val_20];
        }
        private void Awake()
        {
            Rilisoft.BonuseForFirstWinVideoController.与丈丝丑丑上万丅丅 = this;
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  42);
        }
        public override void OnEnterWatching(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            System.EventArgs val_18;
            var val_19;
            var val_20;
            object val_21;
            val_18 = 丗丛不丁丑专专丂且;
            丕丄丘不专丘七专与 val_7 = 0;
            string val_8 = 0;
            int val_2 = (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Ads.X3BonusCount", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 1;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Ads.X3BonusCount", 下下丏一丙不丘丌丞:  val_2, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_19 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_19.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_7, 丏丞专丏业丗丝七丝: out  val_8)) == false)
            {
                goto label_6;
            }
            
            val_19 = 28563616;
            if(val_19 == 0)
            {
                goto label_8;
            }
            
            var val_21 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_12;
            }
            
            var val_19 = mem[-484215838895566158];
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_11:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (mem[-484215838895566048]))
            {
                goto label_11;
            }
            
            goto label_12;
            label_6:
            val_18 = "[BonuseForFirstWinVideoController.TryShowAdcInterface] " + val_8;
            val_21 = val_18;
            goto label_15;
            label_8:
            val_21 = "[BonuseForFirstWinVideoController.TryShowAdcInterface] rewards";
            label_15:
            UnityEngine.Debug.LogWarning(message:  val_21);
            return;
            label_10:
            val_21 = val_21 + (((mem[-484215838895566158] + 8)) << 4);
            val_20 = val_21 + 296;
            label_12:
            val_19 = val_19.Count;
            if((val_2 >= val_19) && ((Rilisoft.BonuseForFirstWinVideoController.丝丒丘丞丕万丅丙专(东且丁丆丛丁丏丘且: out  new System.DateTime())) != false))
            {
                    System.TimeSpan val_15 = System.TimeSpan.FromMinutes(value:  (double)val_7 + 72.x);
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Ads.X3BonusTimestamp", 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {}).ToString(provider:  Rilisoft.BonuseForFirstWinVideoController.丙专丝世不业下丂丈()));
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Ads.X3BonusCount", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            }
            
            this.OnEnterWatching(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  val_18);
        }
        public override void AccrueReward(int 丗七丟丈三不丕一三)
        {
            与丂丏丛丞丞丒丟丄.上丘丛丈丙丐专丑三(丙业与丙丗丝不丈东:  丗七丟丈三不丕一三);
            与丂丏丛丞丞丒丟丄.丙丝丆丅七丒丙丝丝(丙业与丙丗丝不丈东:  true);
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
            与丂丏丛丞丞丒丟丄.丙丝丆丅七丒丙丝丝(丙业与丙丗丝不丈东:  false);
        }
        private static int 丑且一业且丂丝丆丂()
        {
            return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Ads.X3BonusCount", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        private static bool 丝丒丘丞丕万丅丙专(out System.DateTime 东且丁丆丛丁丏丘且)
        {
            var val_3;
            long val_1 = FriendsController.丝丗专上三不丄丑丑();
            if(val_1 > 0)
            {
                    System.DateTime val_2 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  val_1);
                东且丁丆丛丁丏丘且.dateData = val_2.dateData;
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            东且丁丆丛丁丏丘且.dateData = 0;
            return (bool)val_3;
        }
    
    }

}
