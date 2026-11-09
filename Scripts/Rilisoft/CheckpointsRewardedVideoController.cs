using UnityEngine;

namespace Rilisoft
{
    internal sealed class CheckpointsRewardedVideoController : AdsRewardWatchController
    {
        // Fields
        private static Rilisoft.CheckpointsRewardedVideoController 世丒丞七专三与万丕;
        
        // Properties
        internal static Rilisoft.CheckpointsRewardedVideoController 丆丕丝丒不丙且丐丗 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        protected override string 且丙丏丟不专丗且丒 { get; }
        
        // Methods
        private CheckpointsRewardedVideoController()
        {
        
        }
        internal static Rilisoft.CheckpointsRewardedVideoController 丑七不且上丗丁一世()
        {
            return (Rilisoft.CheckpointsRewardedVideoController)Rilisoft.CheckpointsRewardedVideoController.世丒丞七专三与万丕;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "checkpoints";
        }
        internal bool 丄丛丅丐世丌丕且丛()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            丕丄丘不专丘七专与 val_5 = 0;
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  34);
            string val_6 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_4;
            }
            
            this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_5);
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_5;
            }
            
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            val_17 = 109;
            goto label_6;
            label_4:
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            goto label_7;
            label_5:
            val_16 = Rilisoft.AdsRewardWatchController.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "TryGetServerUniversalTime", 丄丙下丝丛丒七丂丘: out  val_6);
            val_14 = 0;
            val_15 = 0;
            label_7:
            val_17 = 117;
            label_6:
            if((System.String.IsNullOrWhiteSpace(value:  val_6)) != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[CheckpointsRewardedVideoController.AreAdcAvailable] " + val_6);
            }
            
            }
            
            if(val_14 == 1)
            {
                goto label_16;
            }
            
            if(117 == 117)
            {
                goto label_17;
            }
            
            if(val_15 == 0)
            {
                goto label_21;
            }
            
            if(117 != 109)
            {
                goto label_19;
            }
            
            goto label_21;
            label_16:
            if(val_15 == 0)
            {
                goto label_21;
            }
            
            label_19:
            label_21:
            bool val_13 = this.丄丛丅丐世丌丕且丛(与丒丌丈七不专三一:  false);
            val_16 = val_13;
            label_17:
            val_13 = val_16;
            return (bool)val_13;
        }
        internal bool 丘丏丅丏与丈上丛丞(System.Action 业丏丈世世世丞丒世, out string 丏丞专丏业丗丝七丝)
        {
            string val_34;
            Rilisoft.CheckpointsRewardedVideoController val_35;
            string val_36;
            var val_37;
            var val_38;
            string val_39;
            var val_40;
            string val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            val_34 = 1152921542218897664;
            val_35 = this;
            CheckpointsRewardedVideoController.丌万一一业丝丁丈丝 val_1 = new CheckpointsRewardedVideoController.丌万一一业丝丁丈丝();
            if(val_1 != null)
            {
                    .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            }
            else
            {
                    mem[16] = 业丏丈世世世丞丒世;
            }
            
            .丝且与丝丒丟万丁专 = val_35;
            val_36 = val_35;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  string val_7 = 丏丞专丏业丗丝七丝)) == false)
            {
                goto label_6;
            }
            
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_7;
            }
            
            if(28563616 == 0)
            {
                goto label_9;
            }
            
            var val_36 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_10;
            }
            
            var val_34 = mem[-484215838895566158];
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_12:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (mem[-484215838895566048]))
            {
                goto label_12;
            }
            
            label_10:
            val_37 = 0;
            goto label_13;
            label_6:
            val_39 = 0;
            goto label_17;
            label_7:
            val_39 = "TryGetServerUniversalTime";
            bool val_10 = Rilisoft.AdsRewardWatchController.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_39, 丄丙下丝丛丒七丂丘: out  val_7);
            goto label_17;
            label_9:
            val_40 = 60;
            val_41 = val_35;
            goto label_24;
            label_11:
            val_36 = val_36 + (((mem[-484215838895566158] + 8)) << 4);
            val_38 = val_36 + 296;
            label_13:
            val_42 = public System.Int32 System.Collections.Generic.IReadOnlyCollection<T>::get_Count();
            int val_11 = 28563616.Count;
            if(val_11 < 1)
            {
                goto label_19;
            }
            
            var val_39 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_20;
            }
            
            var val_37 = mem[-484215838895566158];
            var val_38 = 0;
            val_37 = val_37 + 8;
            label_22:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_38 = val_38 + 1;
            val_37 = val_37 + 16;
            if(val_38 < (mem[-484215838895566048]))
            {
                goto label_22;
            }
            
            label_20:
            val_37 = 0;
            goto label_23;
            label_19:
            val_40 = 60;
            val_41 = val_35;
            if(this != null)
            {
                goto label_24;
            }
            
            goto label_43;
            label_21:
            val_39 = val_39 + (((mem[-484215838895566158] + 8)) << 4);
            val_43 = val_39 + 296;
            label_23:
            val_40 = 28563616;
            val_42 = 0;
            if(((val_11 > 0) ? (val_35) : 0) == 0)
            {
                goto label_43;
            }
            
            label_24:
            mem2[0] = val_40.Item[0];
            this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + ToString(provider:  Rilisoft.CheckpointsRewardedVideoController.丙专丝世不业下丂丈())(ToString(provider:  Rilisoft.CheckpointsRewardedVideoController.丙专丝世不业下丂丈())));
            this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  Rilisoft.CheckpointsRewardedVideoController.丙专丝世不业下丂丈(), format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3172"), arg0:  null));
            val_36 = this.RewardedVideo;
            val_36.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  System.String.Format(provider:  Rilisoft.CheckpointsRewardedVideoController.丙专丝世不业下丂丈(), format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3205"), arg0:  null));
            label_48:
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
            this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime(), 不丝丈上一七丅丕丐:  false, 业丏丞一丕丆丂丗东:  false);
            val_35 = this.RewardedVideo;
            System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_31 = null;
            val_34 = val_31;
            val_31 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void CheckpointsRewardedVideoController.丌万一一业丝丁丈丝::且业丒丐丛一世丐万(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
            val_35.add_EnterIdle(丙业与丙丗丝不丈东:  val_31);
            val_39 = 1;
            label_17:
            val_39 = val_39 & 1;
            return (bool)val_39;
            label_43:
            val_44 = 0;
            if(val_42 != 1)
            {
                goto label_51;
            }
            
            if((null & 1) == 0)
            {
                goto label_46;
            }
            
            this.RewardedVideo.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  this);
            goto label_48;
            label_46:
            val_45 = 8;
            mem[8] = 1179403647;
            val_44 = ;
            label_51:
        }
        private void Awake()
        {
            Rilisoft.CheckpointsRewardedVideoController.世丒丞七专三与万丕 = this;
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  34);
            int val_1 = Rilisoft.CheckpointsRewardedVideoController.丈丝丌三丞丝丛与与();
            if(val_1 < 1)
            {
                    return;
            }
            
            Rilisoft.CheckpointsRewardedVideoController.丂上世一丛丞丆丟丏(丗七丟丈三不丕一三:  val_1);
        }
        public void EnterWacthing()
        {
            this.EnterWacthing();
            Rilisoft.CheckpointsRewardedVideoController.下上业丅丙一丏东不(丗七丟丈三不丕一三:  -1042360624);
        }
        private static void 丂上世一丛丞丆丟丏(int 丗七丟丈三不丕一三)
        {
            int val_6 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  36);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_3.set_Item(key:  "checkpoint", value:  丗七丟丈三不丕一三);
            val_6 = val_6 + 丗七丟丈三不丕一三;
            PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "rewarded video", 丟丛丑丒丆丛东下丌:  "checkpoints", 丗七丟丈三不丕一三:  val_3, 丝丟专丒丅丁丝丘丅:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  36, 丙业与丙丗丝不丈东:  val_6);
            Rilisoft.CheckpointsRewardedVideoController.丏丟丘东一丕丄丟下();
            Rilisoft.一丟专且三万丞丁丂.丏丂丁与七且丘丌丘(丆丄丗七丂丐世丂七:  false);
            Rilisoft.一丟专且三万丞丁丂.七三下上专丘丁丁下();
        }
        private static int 丈丝丌三丞丝丛与与()
        {
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  33)) == false)
            {
                    return 0;
            }
            
            Progress.丘东丅丌东丒上七丁 val_3 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            if(val_3 != null)
            {
                    return val_3.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  33);
            }
            
            return val_3.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  33);
        }
        private static void 下上业丅丙一丏东不(int 丗七丟丈三不丕一三)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  33, 丙业与丙丗丝不丈东:  丗七丟丈三不丕一三);
        }
        private static void 丏丟丘东一丕丄丟下()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  33, 丙业与丙丗丝不丈东:  0);
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
            Rilisoft.CheckpointsRewardedVideoController.丂上世一丛丞丆丟丏(丗七丟丈三不丕一三:  -1041714016);
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  33, 丙业与丙丗丝不丈东:  0);
        }
        public override void OnSwonRewardVideo()
        {
            Rilisoft.一丟专且三万丞丁丂.丏丂丁与七且丘丌丘(丆丄丗七丂丐世丂七:  true);
        }
    
    }

}
