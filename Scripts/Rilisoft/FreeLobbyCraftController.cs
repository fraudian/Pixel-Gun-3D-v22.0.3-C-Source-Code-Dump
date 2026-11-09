using UnityEngine;

namespace Rilisoft
{
    internal sealed class FreeLobbyCraftController : AdsRewardWatchController
    {
        // Fields
        private static Rilisoft.丏丘七丞丄丙丌丞丁 丐业丈丛业下丅丝丕;
        private static Rilisoft.FreeLobbyCraftController 世丒丞七专三与万丕;
        
        // Properties
        internal static Rilisoft.FreeLobbyCraftController 丆丕丝丒不丙且丐丗 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        protected override string 且丙丏丟不专丗且丒 { get; }
        
        // Methods
        private FreeLobbyCraftController()
        {
        
        }
        internal static Rilisoft.FreeLobbyCraftController 丑七不且上丗丁一世()
        {
            return (Rilisoft.FreeLobbyCraftController)Rilisoft.FreeLobbyCraftController.世丒丞七专三与万丕;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "craftLobbyItemSpeedUp";
        }
        public int GetReward()
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            object val_14;
            var val_15;
            val_10 = this;
            string val_5 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丑丏丆万一丛丁专丄(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_5)) == false)
            {
                goto label_4;
            }
            
            if(28563616 == 0)
            {
                goto label_6;
            }
            
            var val_12 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_7;
            }
            
            var val_10 = mem[-484215838895566158];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_9:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (mem[-484215838895566048]))
            {
                goto label_9;
            }
            
            label_7:
            val_11 = 0;
            goto label_10;
            label_4:
            val_10 = "[FreeLobbyCraftController.GetReward] " + val_5;
            val_13 = val_10;
            goto label_13;
            label_6:
            val_14 = "[FreeLobbyCraftController.GetReward] rewards: null";
            goto label_16;
            label_8:
            val_12 = val_12 + (((mem[-484215838895566158] + 8)) << 4);
            val_12 = val_12 + 296;
            label_10:
            if(28563616.Count == 0)
            {
                goto label_17;
            }
            
            var val_15 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_18;
            }
            
            var val_13 = mem[-484215838895566158];
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_20:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (mem[-484215838895566048]))
            {
                goto label_20;
            }
            
            label_18:
            val_11 = 0;
            goto label_21;
            label_17:
            val_14 = "[FreeLobbyCraftController.GetReward] rewards.Count: 0";
            label_16:
            label_13:
            UnityEngine.Debug.LogWarning(message:  val_14);
            return 0;
            label_19:
            val_15 = val_15 + (((mem[-484215838895566158] + 8)) << 4);
            val_15 = val_15 + 296;
            label_21:
            mem[1152921543552370248] = 28563616.Item[0];
            return 0;
        }
        internal bool 丄丛丅丐世丌丕且丛()
        {
            var val_11;
            丕丄丘不专丘七专与 val_5 = 0;
            string val_6 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) != false)
            {
                    this.UpdateDefKey(下上丐丆丝丟丝丒不:  40);
                this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_5);
                val_11 = this;
                bool val_8 = this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
                return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_6, 与丗丆丏丙丟与丒业:  "AreAdcAvailable");
            }
            
            val_11 = this;
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_6, 与丗丆丏丙丟与丒业:  "AreAdcAvailable");
        }
        internal bool 三丙丆丕丗专丐丆丗(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            var val_36;
            var val_37;
            string val_38;
            string val_39;
            string val_40;
            var val_41;
            var val_42;
            T val_43;
            string val_8 = 0;
            if(this.TryShowAdcInterface() == false)
            {
                goto label_1;
            }
            
            Rilisoft.FreeLobbyCraftController.丐业丈丛业下丅丝丕 = 下丅丙一丂丗丅丝七;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_2;
            }
            
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_8)) == false)
            {
                goto label_6;
            }
            
            if(28563616 == 0)
            {
                goto label_8;
            }
            
            var val_38 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_9;
            }
            
            var val_36 = mem[-484215838895566158];
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_11:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (mem[-484215838895566048]))
            {
                goto label_11;
            }
            
            label_9:
            val_36 = 0;
            goto label_12;
            label_1:
            val_38 = "base.TryShowAdcInterface";
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_38 = "TryGetServerUniversalTime: false", 与丗丆丏丙丟与丒业:  "TryShowAdcInterface");
            label_2:
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_38, 与丗丆丏丙丟与丒业:  "TryShowAdcInterface");
            label_6:
            val_39 = val_8;
            val_40 = "TryShowAdcInterface";
            goto label_14;
            label_8:
            val_39 = "rewards: null";
            val_40 = "TryShowAdcInterface";
            label_14:
            bool val_12 = this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  val_39, 与丗丆丏丙丟与丒业:  val_40);
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_38, 与丗丆丏丙丟与丒业:  "TryShowAdcInterface");
            label_10:
            val_38 = val_38 + (((mem[-484215838895566158] + 8)) << 4);
            val_37 = val_38 + 296;
            label_12:
            int val_13 = 28563616.Count;
            if(val_13 < 1)
            {
                goto label_16;
            }
            
            var val_41 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_17;
            }
            
            var val_39 = mem[-484215838895566158];
            var val_40 = 0;
            val_39 = val_39 + 8;
            label_19:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_40 = val_40 + 1;
            val_39 = val_39 + 16;
            if(val_40 < (mem[-484215838895566048]))
            {
                goto label_19;
            }
            
            label_17:
            val_36 = 0;
            goto label_20;
            label_16:
            val_43 = 0;
            val_41 = this;
            if(this != null)
            {
                goto label_23;
            }
            
            goto label_22;
            label_18:
            val_41 = val_41 + (((mem[-484215838895566158] + 8)) << 4);
            val_42 = val_41 + 296;
            label_20:
            val_43 = 28563616.Item[0];
            if(((val_13 > 0) ? (this) : 0) != 0)
            {
                goto label_23;
            }
            
            label_22:
            label_23:
            mem2[0] = val_43;
            this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)(ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)));
            this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3172"), arg0:  null));
            this.RewardedVideo.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3205"), arg0:  null));
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
            this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime(), 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
            this.RewardedVideo.add_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.FreeLobbyCraftController::丏丁丟三专七专七丌(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_38, 与丗丆丏丙丟与丒业:  "TryShowAdcInterface");
        }
        private void Awake()
        {
            Rilisoft.FreeLobbyCraftController.世丒丞七专三与万丕 = this;
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  40);
        }
        public override void AccrueReward(int 丗七丟丈三不丕一三)
        {
            var val_7;
            if(Rilisoft.FreeLobbyCraftController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FreeLobbyCraftController.AccrueReward] reward: "("[FreeLobbyCraftController.AccrueReward] reward: ") + 丗七丟丈三不丕一三.ToString(provider:  Rilisoft.FreeLobbyCraftController.丙专丝世不业下丂丈())(丗七丟丈三不丕一三.ToString(provider:  Rilisoft.FreeLobbyCraftController.丙专丝世不业下丂丈())));
            }
            
            Rilisoft.一丟专且三万丞丁丂.丑丄丅东业且丗上上();
            var val_7 = 60;
            val_7 = 丗七丟丈三不丕一三 * val_7;
            Rilisoft.FreeLobbyCraftController.丐业丈丛业下丅丝丕.东丈专万丆世东丂丄(丆丐七丅丆丗丛上与:  (long)val_7);
            int val_5 = 与丂丏丛丞丞丒丟丄.下三丈七世丂业七七();
            val_5 = val_5 + 1;
            与丂丏丛丞丞丒丟丄.下万丁丂丟丄一下丑(丙业与丙丗丝不丈东:  val_5);
            val_7 = null;
            val_7 = null;
            System.Collections.IEnumerator val_6 = Rilisoft.LobbyCraftSpeedUpButton.丆丕丝丒不丙且丐丗.丑丈世与丙东丆丌七();
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
            var val_2 = 59;
            val_2 = 丗七丟丈三不丕一三 * val_2;
            Rilisoft.FreeLobbyCraftController.丐业丈丛业下丅丝丕.东丈专万丆世东丂丄(丆丐七丅丆丗丛上与:  (long)val_2);
            int val_1 = 与丂丏丛丞丞丒丟丄.下三丈七世丂业七七();
            val_1 = val_1 - 1;
            与丂丏丛丞丞丒丟丄.下万丁丂丟丄一下丑(丙业与丙丗丝不丈东:  val_1);
        }
        private void 丏丁丟三专七专七丌(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
        {
            this.RewardedVideo.remove_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.FreeLobbyCraftController::丏丁丟三专七专七丌(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  false);
        }
    
    }

}
