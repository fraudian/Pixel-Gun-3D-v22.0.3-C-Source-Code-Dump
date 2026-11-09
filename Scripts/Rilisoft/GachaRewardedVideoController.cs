using UnityEngine;

namespace Rilisoft
{
    internal sealed class GachaRewardedVideoController : AdsRewardWatchController
    {
        // Fields
        private const string 丘丏丕丝与丝丘上与 = "Ads.FreeSpinLastTimeShown";
        private static Rilisoft.GachaRewardedVideoController 世丒丞七专三与万丕;
        private UnityEngine.GameObject gachaRewardedVideoButton;
        private UnityEngine.GameObject skinCamera;
        
        // Properties
        internal int 与丑丝与业丐丟丏丁 { get; }
        internal static Rilisoft.GachaRewardedVideoController 丆丕丝丒不丙且丐丗 { get; }
        protected override string 且丙丏丟不专丗且丒 { get; }
        
        // Methods
        private GachaRewardedVideoController()
        {
        
        }
        internal int 业丒丂丗丘三三不丈()
        {
            return (int)this;
        }
        internal static Rilisoft.GachaRewardedVideoController 丑七不且上丗丁一世()
        {
            return (Rilisoft.GachaRewardedVideoController)Rilisoft.GachaRewardedVideoController.世丒丞七专三与万丕;
        }
        protected override string 专与丐丝丘东三丞万()
        {
            return "freeSpin";
        }
        public void OnGachaRewardedVideoButton()
        {
            string val_30;
            string val_31;
            var val_32;
            var val_33;
            var val_34;
            object val_35;
            var val_36;
            val_30 = this;
            string val_6 = 0;
            val_31 = val_30;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_4;
            }
            
            if(28563616 == 0)
            {
                goto label_6;
            }
            
            var val_32 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_7;
            }
            
            var val_30 = mem[-484215838895566158];
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_9:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (mem[-484215838895566048]))
            {
                goto label_9;
            }
            
            label_7:
            val_32 = 0;
            goto label_10;
            label_4:
            val_30 = "[GachaRewardedVideoController.OnGachaRewardedVideoButton] " + val_6;
            val_34 = val_30;
            goto label_13;
            label_6:
            val_35 = "[GachaRewardedVideoController.OnGachaRewardedVideoButton] rewards";
            goto label_24;
            label_8:
            val_32 = val_32 + (((mem[-484215838895566158] + 8)) << 4);
            val_33 = val_32 + 296;
            label_10:
            if(28563616.Count == 0)
            {
                goto label_17;
            }
            
            var val_35 = -1878846974;
            if((mem[-484215838895566048]) == 0)
            {
                goto label_18;
            }
            
            var val_33 = mem[-484215838895566158];
            var val_34 = 0;
            val_33 = val_33 + 8;
            label_20:
            if(((mem[-484215838895566158] + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_34 = val_34 + 1;
            val_33 = val_33 + 16;
            if(val_34 < (mem[-484215838895566048]))
            {
                goto label_20;
            }
            
            label_18:
            val_32 = 0;
            goto label_21;
            label_17:
            val_35 = "[GachaRewardedVideoController.OnGachaRewardedVideoButton] Count: 0";
            goto label_24;
            label_19:
            val_35 = val_35 + (((mem[-484215838895566158] + 8)) << 4);
            val_36 = val_35 + 296;
            label_21:
            mem[1152921542695728056] = 28563616.Item[0];
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) != false)
            {
                    this.RewardedVideo.下专丙丝丐丘丝丌丈(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  I2.Loc.丞丛丝万丅丛三上丛.一七丑一丁丈丛丏三())) + " " + mem[1152921542695728056].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)(mem[1152921542695728056].ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)));
                this.RewardedVideo.丈七丅丐丑丛丑与一(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3172"), arg0:  mem[1152921542695728056]));
                this.RewardedVideo.丌七丒丟丒丟丑丐丟(丙业与丙丗丝不丈东:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3205"), arg0:  mem[1152921542695728056]));
                ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
                this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime(), 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
                System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_29 = null;
                val_31 = val_29;
                val_29 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.GachaRewardedVideoController::丛业三东丙业丈丟丕(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
                this.RewardedVideo.add_EnterIdle(丙业与丙丗丝不丈东:  val_29);
                return;
            }
            
            val_35 = "[GachaRewardedVideoController.OnGachaRewardedVideoButton] TryGetServerUniversalTime";
            label_24:
            label_13:
            UnityEngine.Debug.LogWarning(message:  val_35);
        }
        public void RefreshGui(bool 一东丁七丗丐丒丁丏)
        {
            一东丁七丗丐丒丁丏 = 一东丁七丗丐丒丁丏;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gachaRewardedVideoButton, 丏业丟一东丂东丘丛:  一东丁七丗丐丒丁丏);
        }
        public void RefreshGui()
        {
            this.RefreshGui(一东丁七丗丐丒丁丏:  this.业三丗丆丁丕丏丛丌());
        }
        private void Awake()
        {
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  31);
            Rilisoft.GachaRewardedVideoController.世丒丞七专三与万丕 = this;
            int val_1 = Rilisoft.GachaRewardedVideoController.丙丘丝专万丌丑丙丘();
            if(val_1 < 1)
            {
                    return;
            }
            
            Rilisoft.GachaRewardedVideoController.丈专丕与丟一丏三上(丗七丟丈三不丕一三:  val_1);
        }
        private void Start()
        {
            this.RefreshGui(一东丁七丗丐丒丁丏:  this.业三丗丆丁丕丏丛丌());
            this.UpdateDefKey(下上丐丆丝丟丝丒不:  31);
            if(FreeAwardController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            FreeAwardController.丞丑与丂丒丌丒上丐(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.GachaRewardedVideoController::与业丝世丕一不丗一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void OnDestroy()
        {
            this.OnDestroy();
            if(FreeAwardController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            FreeAwardController.万丄丝丞丛丆下丂丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.GachaRewardedVideoController::与业丝世丕一不丗一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void OnEnable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if((this & 1) != 0)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.OnEnable] Subscribing on FreeSpinCountChanged");
            }
            
                val_4 = null;
                val_4 = null;
                GiftController.丆丕丝丒不丙且丐丗.丌与业丒丅三不丌世(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.GachaRewardedVideoController::与业丝世丕一不丗一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[GachaRewardedVideoController.OnEnable] GiftController: null");
        }
        private void OnDisable()
        {
            System.EventHandler val_5;
            var val_6;
            var val_7;
            val_5 = 1152921505205194752;
            val_6 = null;
            val_6 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if((this & 1) != 0)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.OnDisable] Unsubscribing from FreeSpinCountChanged");
            }
            
                val_7 = null;
                val_7 = null;
                System.EventHandler val_2 = null;
                val_5 = val_2;
                val_2 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.GachaRewardedVideoController::与业丝世丕一不丗一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                GiftController.丆丕丝丒不丙且丐丗.世东一一丕丂丐且世(丙业与丙丗丝不丈东:  val_2);
            }
            
            if(GiftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            this.RewardedVideo.丕七三且丏丗下丅丅();
        }
        private void 与业丝世丕一不丗一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if((this & 1) != 0)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.OnFreeSpinAvailabilityChanged]");
            }
            
            this.RefreshGui(一东丁七丗丐丒丁丏:  this.业三丗丆丁丕丏丛丌());
        }
        private bool 业三丗丆丁丕丏丛丌()
        {
            string val_16;
            var val_17;
            string val_18;
            var val_19;
            var val_20;
            var val_21;
            val_16 = this;
            string val_13 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.丒丐丆丘丈丟丂下专() != false)
            {
                    if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return false;
            }
            
            }
            
            val_17 = null;
            val_17 = null;
            if(GiftController.丆丕丝丒不丙且丐丗.丐丘丕丆丞丑丝丆丟() == false)
            {
                    return false;
            }
            
            string val_9 = 0;
            丕丄丘不专丘七专与 val_8 = 0;
            val_18 = val_16;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_8, 丏丞专丏业丗丝七丝: out  val_9)) != false)
            {
                    val_19 = 0;
                val_20 = 0;
                val_21 = 104;
            }
            else
            {
                    val_19 = 0;
                val_20 = 0;
                val_21 = 135;
            }
            
            if(val_8 != 0)
            {
                    this.丝丌一业丄不七丁世(丌东丙丝丂一丅三丞:  val_8);
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  val_9)) != true)
            {
                    val_18 = "[GachaRewardedVideoController.GachaRewardedVideoButtonIsEnabled] " + val_9;
                UnityEngine.Debug.Log(message:  val_18);
            }
            
            if(val_19 == 1)
            {
                goto label_16;
            }
            
            if(135 == 135)
            {
                    return false;
            }
            
            if(val_20 == 0)
            {
                goto label_21;
            }
            
            if(135 != 104)
            {
                goto label_19;
            }
            
            goto label_21;
            label_16:
            if(val_20 == 0)
            {
                goto label_21;
            }
            
            label_19:
            label_21:
            if((this.且世丄丙丄丕丌不下(与丒丌丈七不专三一:  false, 丁丂丕与丁丒丕丟丞: out  val_13)) == false)
            {
                    return false;
            }
            
            val_16 = "[GachaRewardedVideoController.GachaRewardedVideoButtonIsEnabled] " + val_13;
            UnityEngine.Debug.Log(message:  val_16);
            return false;
        }
        public override void AccrueReward(int 丗七丟丈三不丕一三)
        {
            if((this & 1) != 0)
            {
                    string val_2 = "[GachaRewardedVideoController.AccrueReward] reward: "("[GachaRewardedVideoController.AccrueReward] reward: ") + 丗七丟丈三不丕一三.ToString();
                UnityEngine.Debug.Log(message:  val_2);
            }
            
            Rilisoft.GachaRewardedVideoController.丈专丕与丟一丏三上(丗七丟丈三不丕一三:  val_2);
        }
        public override void ResetReward(int 丗七丟丈三不丕一三)
        {
        
        }
        public void ExitWacthing()
        {
            this.ExitWacthing();
            if(this.skinCamera != 0)
            {
                    this.skinCamera.SetActive(value:  true);
            }
            
            this.gachaRewardedVideoButton.SetActive(value:  this.业三丗丆丁丕丏丛丌());
        }
        public void EnterWacthing()
        {
            this.EnterWacthing();
            if(this.skinCamera != 0)
            {
                    this.skinCamera.SetActive(value:  false);
            }
            
            this.gachaRewardedVideoButton.SetActive(value:  this.业三丗丆丁丕丏丛丌());
        }
        private static void 丈专丕与丟一丏三上(int 丗七丟丈三不丕一三)
        {
            var val_6;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.IncrementSpinCountAndResetPending] reward: "("[GachaRewardedVideoController.IncrementSpinCountAndResetPending] reward: ") + 丗七丟丈三不丕一三.ToString());
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "rewarded video", 丟丛丑丒丆丛东下丌:  "free spin gacha", 丗七丟丈三不丕一三:  0, 丝丟专丒丅丁丝丘丅:  0);
            val_6 = null;
            val_6 = null;
            int val_5 = GiftController.丆丕丝丒不丙且丐丗.IncrementFreeSpins(丏业下一丑丄丐丘三:  丗七丟丈三不丕一三);
            GiftController.丆丕丝丒不丙且丐丗.ReCreateSlotsIfPossible();
            Rilisoft.GachaRewardedVideoController.丈上丐三三丒丐丂丌();
            Rilisoft.一丟专且三万丞丁丂.一且业丗丏丝丗丌七();
        }
        private static int 丙丘丝专万丌丑丙丘()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.LoadPendingFreeSpins]");
            }
            
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  29)) == false)
            {
                    return 0;
            }
            
            Progress.丘东丅丌东丒上七丁 val_4 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            if(val_4 != null)
            {
                    return val_4.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  29);
            }
            
            return val_4.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  29);
        }
        internal static void 且上丞且丄丕下丆丆(int 丗七丟丈三不丕一三)
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.SavePendingFreeSpins] reward: "("[GachaRewardedVideoController.SavePendingFreeSpins] reward: ") + 丗七丟丈三不丕一三.ToString());
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  29, 丙业与丙丗丝不丈东:  丗七丟丈三不丕一三);
        }
        internal static void 丈上丐三三丒丐丂丌()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[GachaRewardedVideoController.ResetPendingFreeSpins]");
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  29, 丙业与丙丗丝不丈东:  0);
        }
        private void 丛业三东丙业丈丟丕(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
        {
            this.RewardedVideo.remove_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void Rilisoft.GachaRewardedVideoController::丛业三东丙业丈丟丕(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  false);
            if(丗丛不丁丑专专丂且.丅丄不上丌三丘东丄() == false)
            {
                    return;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丐丞一丆丕丈七丄丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 与丂丒丄丟丌丆丁丕:  2);
        }
    
    }

}
