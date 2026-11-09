using UnityEngine;

namespace Rilisoft
{
    internal sealed class FreeChestController : AdsRewardWatchController
    {
        // Fields
        private const string 丅丘与下三上丏丝不 = "Ads.FreeChestLastTimeShown";
        private static Rilisoft.FreeChestController 世丒丞七专三与万丕;
        private int 丑丌丁不上一三丏丛;
        private int 丆业丗丁丕且上下丙;
        
        // Properties
        protected override string 且丙丏丟不专丗且丒 { get; }
        public double 丑丄三丌丛七丆业不 { get; }
        internal static Rilisoft.FreeChestController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        private FreeChestController()
        {
        
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "freeChest";
        }
        public double get_DelayTimeinMinutes()
        {
            string val_13;
            var val_14;
            double val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = this;
            val_15 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  0)) == false)
            {
                    return val_15;
            }
            
            val_13 = 135970152;
            if(val_13 == 0)
            {
                    return val_15;
            }
            
            var val_16 = 106557164;
            if(0 == 0)
            {
                goto label_7;
            }
            
            var val_14 = 0;
            var val_15 = 107374182407;
            label_9:
            if(mem[107374182399] == null)
            {
                goto label_8;
            }
            
            val_14 = val_14 + 1;
            val_15 = val_15 + 16;
            if(val_14 < 0)
            {
                goto label_9;
            }
            
            label_7:
            val_14 = 0;
            goto label_10;
            label_8:
            val_16 = val_16 + ((mem[107374182407]) << 4);
            val_16 = val_16 + 296;
            label_10:
            if(val_13.Count == 0)
            {
                    return val_15;
            }
            
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_9 = Rilisoft.AdsRewardWatchController.丙丟专七丈不丗丁丅();
            var val_19 = 106557164;
            int val_23;
            if(0 == 0)
            {
                goto label_14;
            }
            
            var val_17 = 0;
            var val_18 = 107374182407;
            label_16:
            if(mem[107374182399] == null)
            {
                goto label_15;
            }
            
            val_17 = val_17 + 1;
            val_18 = val_18 + 16;
            if(val_17 < 0)
            {
                goto label_16;
            }
            
            label_14:
            val_14 = 0;
            goto label_17;
            label_15:
            val_19 = val_19 + ((mem[107374182407]) << 4);
            val_17 = val_19 + 296;
            label_17:
            if(val_13.Count <= val_23)
            {
                    return val_15;
            }
            
            var val_22 = 106557164;
            if(0 == 0)
            {
                goto label_19;
            }
            
            var val_20 = 0;
            var val_21 = 107374182407;
            label_21:
            if(mem[107374182399] == null)
            {
                goto label_20;
            }
            
            val_20 = val_20 + 1;
            val_21 = val_21 + 16;
            if(val_20 < 0)
            {
                goto label_21;
            }
            
            label_19:
            val_14 = 0;
            goto label_22;
            label_20:
            val_22 = val_22 + ((mem[107374182407]) << 4);
            val_18 = val_22 + 296;
            label_22:
            int val_11 = val_13.Count;
            var val_26 = 106557164;
            val_23 = val_23 - ((val_23 / val_11) * val_11);
            if(0 == 0)
            {
                goto label_23;
            }
            
            var val_24 = 0;
            var val_25 = 107374182407;
            label_25:
            if(mem[107374182399] == null)
            {
                goto label_24;
            }
            
            val_24 = val_24 + 1;
            val_25 = val_25 + 16;
            if(val_24 < 0)
            {
                goto label_25;
            }
            
            label_23:
            val_14 = 0;
            goto label_26;
            label_24:
            val_26 = val_26 + ((mem[107374182407]) << 4);
            val_19 = val_26 + 296;
            label_26:
            T val_13 = val_13.Item[val_23];
            val_15 = (double)S0;
            return val_15;
        }
        internal static Rilisoft.FreeChestController 丑七不且上丗丁一世()
        {
            return (Rilisoft.FreeChestController)Rilisoft.FreeChestController.世丒丞七专三与万丕;
        }
        internal bool 丄丛丅丐世丌丕且丛()
        {
            string val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            string val_6 = 0;
            丕丄丘不专丘七专与 val_5 = 0;
            val_12 = this;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) != false)
            {
                    this.UpdateDefKey(下上丐丆丝丟丝丒不:  44);
                val_13 = 0;
                val_14 = 0;
                val_15 = 82;
            }
            else
            {
                    val_13 = 0;
                val_14 = 0;
                val_15 = 90;
            }
            
            if(val_5 != 0)
            {
                    this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_5);
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  val_6)) != true)
            {
                    val_12 = "[FreeChestController.AreAdcAvailable] " + val_6;
                UnityEngine.Debug.Log(message:  val_12);
            }
            
            if(val_13 == 1)
            {
                goto label_10;
            }
            
            if(90 != 90)
            {
                goto label_11;
            }
            
            val_16 = 0;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
            label_10:
            if(val_14 != 0)
            {
                goto label_13;
            }
            
            goto label_16;
            label_11:
            if((val_14 == 0) || (90 == 82))
            {
                goto label_16;
            }
            
            label_13:
            label_16:
            val_16 = this;
            return (bool)this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
        }
        internal bool 三丙丆丕丗专丐丆丗(int 丐东业丕丕丂丗丅丙)
        {
            int val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            string val_39;
            string val_40;
            var val_41;
            var val_42;
            val_34 = 丐东业丕丕丂丗丅丙;
            string val_8 = 0;
            丕丄丘不专丘七专与 val_7 = 0;
            FreeChestController.丒丛丁与丅东丒不七 val_1 = new FreeChestController.丒丛丁与丅东丒不七();
            .丝且与丝丒丟万丁专 = this;
            this.丑丌丁不上一三丏丛 = val_34;
            System.Nullable<System.DateTime> val_2 = FriendsController.业丈丏丏丞丘丛丈丛();
            if((289363776 & 1) == 0)
            {
                goto label_4;
            }
            
            val_34 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_34.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_7, 丏丞专丏业丗丝七丝: out  val_8)) == false)
            {
                goto label_8;
            }
            
            val_35 = 0;
            this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_7);
            val_34 = 28563616;
            if(val_34 == 0)
            {
                goto label_10;
            }
            
            var val_36 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_11;
            }
            
            var val_34 = mem[-484215838895566158];
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_13:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (mem[-484215838895566048]))
            {
                goto label_13;
            }
            
            label_11:
            val_35 = 0;
            goto label_14;
            label_4:
            UnityEngine.Debug.LogWarning(message:  "Server time not received.");
            val_37 = 0;
            return (bool)this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  val_40 = "Count", 与丗丆丏丙丟与丒业:  val_39 = "TryShowAdcInterface");
            label_8:
            val_38 = val_8;
            val_39 = "TryShowAdcInterface";
            goto label_18;
            label_10:
            val_40 = "rewards";
            goto label_19;
            label_12:
            val_36 = val_36 + (((mem[-484215838895566158] + 8)) << 4);
            val_36 = val_36 + 296;
            label_14:
            if(val_34.Count == 0)
            {
                goto label_20;
            }
            
            var val_39 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_21;
            }
            
            var val_37 = mem[-484215838895566158];
            var val_38 = 0;
            val_37 = val_37 + 8;
            label_23:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_38 = val_38 + 1;
            val_37 = val_37 + 16;
            if(val_38 < (mem[-484215838895566048]))
            {
                goto label_23;
            }
            
            label_21:
            val_35 = 0;
            goto label_24;
            label_20:
            label_19:
            label_18:
            val_37 = this;
            return (bool)this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  val_40, 与丗丆丏丙丟与丒业:  val_39);
            label_22:
            val_39 = val_39 + (((mem[-484215838895566158] + 8)) << 4);
            val_41 = val_39 + 296;
            label_24:
            mem[1152921543550928536] = val_34.Item[0];
            this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + mem[1152921543550928536].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)(mem[1152921543550928536].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)));
            this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3172"), arg0:  mem[1152921543550928536]));
            this.RewardedVideo.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3205"), arg0:  mem[1152921543550928536]));
            this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime() {}, 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
            .丛丁丅丂不丂丐丝丏 = 0;
            System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_29 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void FreeChestController.丒丛丁与丅东丒不七::七丟丛丏不丛万丌专(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
            if(val_1 != null)
            {
                    .丛丁丅丂不丂丐丝丏 = val_29;
                val_42 = this.RewardedVideo;
            }
            else
            {
                    .丛丁丅丂不丂丐丝丏 = val_29;
                val_42 = this.RewardedVideo;
            }
            
            val_42.add_EnterIdle(丙业与丙丗丝不丈东:  (FreeChestController.丒丛丁与丅东丒不七)[1152921543550960512].丛丁丅丂不丂丐丝丏);
            return (bool)this.不丟丅丙丄三三三丂(丄丙下丝丛丒七丂丘:  val_40, 与丗丆丏丙丟与丒业:  val_39);
        }
        private void Awake()
        {
            Rilisoft.FreeChestController.世丒丞七专三与万丕 = this;
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  44);
        }
        public override void AccrueReward(int 丗七丟丈三不丕一三)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.GetType();
            val_1[1] = 丗七丟丈三不丕一三;
            UnityEngine.Debug.LogFormat(format:  "[{0}] AccrueReward({1})", args:  val_1);
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世() != null)
            {
                    PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "rewarded video", 丟丛丑丒丆丛东下丌:  "free spin event chest", 丗七丟丈三不丕一三:  0, 丝丟专丒丅丁丝丘丅:  0);
                Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().且下下丆丝丛丑丅丏(丐东业丕丕丂丗丅丙:  Rilisoft.FreeChestController.世丒丞七专三与万丕.丑丌丁不上一三丏丛, 丁丅丈丌丟世丗丗丟:  10, 下丅三丈世丐丕丌丑:  丗七丟丈三不丕一三, 三丙世丒丙丘一丗上:  true);
            }
            
            Rilisoft.一丟专且三万丞丁丂.丞不丄丅且上业丕一();
            int val_6 = 与丂丏丛丞丞丒丟丄.丆丛万丑丅上世且万();
            val_6 = val_6 + 1;
            与丂丏丛丞丞丒丟丄.且专丏丂丆一三丆七(丙业与丙丗丝不丈东:  val_6);
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
            int val_1 = 与丂丏丛丞丞丒丟丄.丆丛万丑丅上世且万();
            val_1 = val_1 - 1;
            与丂丏丛丞丞丒丟丄.且专丏丂丆一三丆七(丙业与丙丗丝不丈东:  val_1);
        }
    
    }

}
