using UnityEngine;

namespace Rilisoft
{
    internal sealed class ArmorSpeedUpController : AdsRewardWatchController
    {
        // Fields
        private const string 丘丏丕丝与丝丘上与 = "Ads.ArmorSpeedUpLastTimeShown";
        private static Rilisoft.ArmorSpeedUpController 世丒丞七专三与万丕;
        
        // Properties
        internal static Rilisoft.ArmorSpeedUpController 丆丕丝丒不丙且丐丗 { get; }
        protected override string 且丙丏丟不专丗且丒 { get; }
        
        // Methods
        private ArmorSpeedUpController()
        {
            this = new UnityEngine.MonoBehaviour();
        }
        internal static Rilisoft.ArmorSpeedUpController 丑七不且上丗丁一世()
        {
            return (Rilisoft.ArmorSpeedUpController)Rilisoft.ArmorSpeedUpController.世丒丞七专三与万丕;
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "armorSpeedUp";
        }
        public bool AreAdcAvailable()
        {
            PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_14;
            var val_15;
            var val_16;
            var val_17;
            string val_3 = 0;
            PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_2 = 0;
            丕丄丘不专丘七专与 val_7 = 0;
            bool val_6 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丑丛丞三下业丁下三(上世丏丁世丟世丆业: out  val_2, 七丆丒与丗丌丄且丂: out  val_3, 丟丐丗万丅下丗丝万: out  0, 丏丞专丏业丗丝七丝: out  0);
            if(val_6 == false)
            {
                goto label_4;
            }
            
            val_6.UpdateDefKey(下上丐丆丝丟丝丒不:  38);
            val_14 = val_2;
            if((PGCompany.DataObjects.三丛丂丟与不专丛丏.丑丏丆万一丛丁专丄(上世丏丁世丟世丆业:  val_14, 七丆丒与丗丌丄且丂:  val_3, 丅专与丒丈丗丒丘丌:  this, 丌东丙丝丂一丅三丞: out  val_7)) == false)
            {
                goto label_5;
            }
            
            val_15 = 0;
            val_16 = 0;
            mem[1152921543546697224] = val_7;
            goto label_24;
            label_4:
            val_15 = 0;
            val_16 = 0;
            goto label_24;
            label_5:
            val_15 = 0;
            val_16 = 0;
            label_24:
            if((System.String.IsNullOrWhiteSpace(value:  "TryGetEffectiveVideoPointConfig")) != true)
            {
                    val_14 = "[" + this.tag + "] " + "TryGetEffectiveVideoPointConfig";
                UnityEngine.Debug.Log(message:  val_14);
            }
            
            if(val_15 == 1)
            {
                goto label_13;
            }
            
            if(121 != 121)
            {
                goto label_14;
            }
            
            val_17 = 0;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
            label_13:
            if(val_16 != 0)
            {
                goto label_16;
            }
            
            goto label_19;
            label_14:
            if((val_16 == 0) || (121 == 113))
            {
                goto label_19;
            }
            
            label_16:
            label_19:
            val_17 = this;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
        }
        internal bool 丐丟丑丄丛丟万丝万()
        {
            var val_32;
            var val_33;
            var val_34;
            string val_35;
            string val_36;
            var val_37;
            string val_6 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_4;
            }
            
            if(28563616 == 0)
            {
                goto label_6;
            }
            
            var val_34 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_7;
            }
            
            var val_32 = mem[-484215838895566158];
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_9:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < (mem[-484215838895566048]))
            {
                goto label_9;
            }
            
            label_7:
            val_32 = 0;
            goto label_10;
            label_4:
            val_34 = val_6;
            val_35 = "TryShowArmorSpeedUpInterface";
            goto label_11;
            label_6:
            val_36 = "rewards";
            goto label_12;
            label_8:
            val_34 = val_34 + (((mem[-484215838895566158] + 8)) << 4);
            val_33 = val_34 + 296;
            label_10:
            if(28563616.Count == 0)
            {
                goto label_13;
            }
            
            var val_37 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_14;
            }
            
            var val_35 = mem[-484215838895566158];
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_16:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (mem[-484215838895566048]))
            {
                goto label_16;
            }
            
            label_14:
            val_32 = 0;
            goto label_17;
            label_13:
            val_36 = "Count";
            label_12:
            val_35 = "TryShowArmorSpeedUpInterface";
            label_11:
            bool val_9 = this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_36, 与丗丆丏丙丟与丒业:  val_35);
            return false;
            label_15:
            val_37 = val_37 + (((mem[-484215838895566158] + 8)) << 4);
            val_37 = val_37 + 296;
            label_17:
            mem[1152921543546919160] = 28563616.Item[0];
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) != false)
            {
                    this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + mem[1152921543546919160].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)(mem[1152921543546919160].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)));
                this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3172"), arg0:  mem[1152921543546919160]));
                this.RewardedVideo.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3205"), arg0:  mem[1152921543546919160]));
                ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
                this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime(), 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
                this.RewardedVideo.add_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.ArmorSpeedUpController::丐与不丐丏丑业东丄(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
                return false;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[ArmorSpeedUpController.TryShowArmorSpeedUpInterface] TryGetServerUniversalTime");
            return false;
        }
        private void Awake()
        {
            Rilisoft.ArmorSpeedUpController.世丒丞七专三与万丕 = this;
            2554.UpdateDefKey(下上丐丆丝丟丝丒不:  38);
        }
        public override void AccrueReward(int 丗七丟丈三不丕一三)
        {
        
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
        
        }
        private void 丐与不丐丏丑业东丄(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
        {
            this.RewardedVideo.remove_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.ArmorSpeedUpController::丐与不丐丏丑业东丄(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  false);
        }
    
    }

}
