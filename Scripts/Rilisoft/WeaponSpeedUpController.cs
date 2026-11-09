using UnityEngine;

namespace Rilisoft
{
    internal sealed class WeaponSpeedUpController : AdsRewardWatchController
    {
        // Fields
        private const string 丘丏丕丝与丝丘上与 = "Ads.WeaponSpeedUpLastTimeShown";
        private static Rilisoft.WeaponSpeedUpController 世丒丞七专三与万丕;
        
        // Properties
        internal static Rilisoft.WeaponSpeedUpController 丆丕丝丒不丙且丐丗 { get; }
        protected override string 且丙丏丟不专丗且丒 { get; }
        
        // Methods
        private WeaponSpeedUpController()
        {
        
        }
        internal static Rilisoft.WeaponSpeedUpController 丑七不且上丗丁一世()
        {
            return (Rilisoft.WeaponSpeedUpController)Rilisoft.WeaponSpeedUpController.世丒丞七专三与万丕;
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "weaponSpeedUp";
        }
        public void SetRewardParent(UnityEngine.GameObject 丈东丘丏与丌东东下)
        {
            mem[1152921543553782840] = 丈东丘丏与丌东东下;
        }
        public bool AreAdcAvailable()
        {
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            string val_6 = 0;
            丕丄丘不专丘七专与 val_5 = 0;
            val_13 = this;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) != false)
            {
                    this.UpdateDefKey(下上丐丆丝丟丝丒不:  46);
                val_14 = 0;
                val_15 = 0;
                val_16 = 93;
            }
            else
            {
                    val_14 = 0;
                val_15 = 0;
                val_16 = 101;
            }
            
            if(val_5 != 0)
            {
                    this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_5);
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  val_6)) != true)
            {
                    val_13 = "[" + this.tag + "] " + val_6;
                UnityEngine.Debug.Log(message:  val_13);
            }
            
            if(val_14 == 1)
            {
                goto label_10;
            }
            
            if(101 != 101)
            {
                goto label_11;
            }
            
            val_17 = 0;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
            label_10:
            if(val_15 != 0)
            {
                goto label_13;
            }
            
            goto label_16;
            label_11:
            if((val_15 == 0) || (101 == 93))
            {
                goto label_16;
            }
            
            label_13:
            label_16:
            val_17 = this;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
        }
        public override bool TryShowAdcInterface()
        {
            var val_35;
            var val_36;
            var val_37;
            string val_38;
            string val_39;
            var val_40;
            string val_6 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_4;
            }
            
            if(28563616 == 0)
            {
                goto label_6;
            }
            
            var val_37 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_7;
            }
            
            var val_35 = mem[-484215838895566158];
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_9:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (mem[-484215838895566048]))
            {
                goto label_9;
            }
            
            label_7:
            val_35 = 0;
            goto label_10;
            label_4:
            val_37 = val_6;
            val_38 = "TryShowAdcInterface";
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_39 = "Count", 与丗丆丏丙丟与丒业:  val_38 = "TryShowAdcInterface");
            label_6:
            val_39 = "rewards";
            goto label_12;
            label_8:
            val_37 = val_37 + (((mem[-484215838895566158] + 8)) << 4);
            val_36 = val_37 + 296;
            label_10:
            if(28563616.Count == 0)
            {
                goto label_13;
            }
            
            var val_40 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_14;
            }
            
            var val_38 = mem[-484215838895566158];
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_16:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (mem[-484215838895566048]))
            {
                goto label_16;
            }
            
            label_14:
            val_35 = 0;
            goto label_17;
            label_13:
            label_12:
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_39, 与丗丆丏丙丟与丒业:  val_38);
            label_15:
            val_40 = val_40 + (((mem[-484215838895566158] + 8)) << 4);
            val_40 = val_40 + 296;
            label_17:
            mem[1152921543554141128] = 28563616.Item[0];
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) != false)
            {
                    this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + mem[1152921543554141128].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)(mem[1152921543554141128].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)));
                this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3172"), arg0:  mem[1152921543554141128]));
                this.RewardedVideo.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3205"), arg0:  mem[1152921543554141128]));
                ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
                this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime(), 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
                this.RewardedVideo.add_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.WeaponSpeedUpController::业丗丄丛上丘丏丛丑(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
                return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_39, 与丗丆丏丙丟与丒业:  val_38);
            }
            
            UnityEngine.Debug.LogWarning(message:  "[" + this.tag + "] TryGetServerUniversalTime");
            return (bool)this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_39, 与丗丆丏丙丟与丒业:  val_38);
        }
        private void Awake()
        {
            Rilisoft.WeaponSpeedUpController.世丒丞七专三与万丕 = this;
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  46);
        }
        internal static System.Collections.Generic.KeyValuePair<System.DateTime, int> 丙丟专七丈不丗丁丅()
        {
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_5;
            var val_6;
            val_5;
            if((PGCompany.东丑一丄丕丁丕一丟.七丗万下丆世不丗丗(下上丐丆丝丟丝丒不:  46, 一世上丟专丗丝丄丁: out  new System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32>())) != false)
            {
                    return 0;
            }
            
            val_6 = null;
            val_6 = null;
            System.TimeSpan val_2 = System.TimeSpan.FromHours(value:  72);
            System.DateTime val_3 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = System.DateTime.MinValue}, t:  new System.TimeSpan() {_ticks = val_2._ticks});
            val_5 = val_3.dateData;
            return 0;
        }
        public override void AccrueReward(int 丗七丟丈三不丕一三)
        {
            object[] val_1 = new object[2];
            System.Type val_2 = this.GetType();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = 丗七丟丈三不丕一三;
            UnityEngine.Debug.LogFormat(format:  "[{0}] AccrueReward({1})", args:  val_1);
            Rilisoft.一丟专且三万丞丁丂.专与丘下丌不丕不丂();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            int val_4 = 丗七丟丈三不丕一三 * 60;
            val_3.set_Item(key:  "seconds", value:  val_4);
            PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "rewarded video", 丟丛丑丒丆丛东下丌:  "speed up weapon", 丗七丟丈三不丕一三:  val_3, 丝丟专丒丅丁丝丘丅:  0);
            WeaponManager.七丟不丌丒三三丟丙(丆丐七丅丆丗丛上与:  (long)val_4);
            int val_6 = 与丂丏丛丞丞丒丟丄.丙东丟下丝世丐与三();
            val_6 = val_6 + 1;
            与丂丏丛丞丞丒丟丄.一丆丘不下丙与丂不(丙业与丙丗丝不丈东:  val_6);
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
            var val_2 = 59;
            val_2 = 丗七丟丈三不丕一三 * val_2;
            WeaponManager.七丟不丌丒三三丟丙(丆丐七丅丆丗丛上与:  (long)val_2);
            int val_1 = 与丂丏丛丞丞丒丟丄.丙东丟下丝世丐与三();
            val_1 = val_1 - 1;
            与丂丏丛丞丞丒丟丄.一丆丘不下丙与丂不(丙业与丙丗丝不丈东:  val_1);
        }
        private void 业丗丄丛上丘丏丛丑(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
        {
            this.RewardedVideo.remove_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.WeaponSpeedUpController::业丗丄丛上丘丏丛丑(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  false);
        }
    
    }

}
