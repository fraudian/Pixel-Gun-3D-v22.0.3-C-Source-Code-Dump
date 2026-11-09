using UnityEngine;

namespace Rilisoft
{
    internal abstract class AdsRewardWatchController : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<Progress.与丄东丄丘丐丙丅业, Progress.与丄东丄丘丐丙丅业> 丙万丂丕丄丘丘丞丙;
        protected static Progress.与丄东丄丘丐丙丅业 丑一丌世丕万丙丒丕;
        protected int 丁三丆上丆丗丒且丏;
        protected Rilisoft.ReusableRewardedVideo 七业下三七一丕丟与;
        protected UnityEngine.GameObject _rewardedVideoParent;
        protected string 丞丐丟三丌与丞上一;
        protected PGCompany.DataObjects.万丞丘丏丆丆丝与与.丕丄丘不专丘七专与 丈丅丙丛丄世丁丅丌;
        
        // Properties
        protected abstract string 且丙丏丟不专丗且丒 { get; }
        public UnityEngine.GameObject 丙不丄下且且下三丛 { get; }
        public bool 丟丈三丄丗东专业丌 { get; }
        public Rilisoft.ReusableRewardedVideo 且下丄丞且且丁丒七 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        protected virtual bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        protected abstract string 专与丐丝丘东三丞万(); // 0
        public UnityEngine.GameObject get_RewardedVideoParent()
        {
            UnityEngine.GameObject val_3;
            if(this._rewardedVideoParent == 0)
            {
                    this._rewardedVideoParent = this.gameObject;
                return val_3;
            }
            
            val_3 = this._rewardedVideoParent;
            return val_3;
        }
        public bool get_IsRewardVideoShowing()
        {
            if(this.七业下三七一丕丟与 == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = this.七业下三七一丕丟与.gameObject;
            if(val_2 != null)
            {
                    return val_2.activeSelf;
            }
            
            return val_2.activeSelf;
        }
        public Rilisoft.ReusableRewardedVideo get_RewardedVideo()
        {
            object val_21;
            UnityEngine.Transform val_22;
            Rilisoft.ReusableRewardedVideo val_23;
            if(this.七业下三七一丕丟与 != 0)
            {
                goto label_3;
            }
            
            Rilisoft.ReusableRewardedVideo val_2 = UnityEngine.Resources.Load<Rilisoft.ReusableRewardedVideo>(path:  "SpeedUpItemRewardedVideo");
            if(val_2 != 0)
            {
                goto label_6;
            }
            
            val_21 = "_rewardedVideoPrefab is null.";
            goto label_9;
            label_6:
            val_22 = this.RewardedVideoParent.transform;
            Rilisoft.ReusableRewardedVideo val_6 = UnityEngine.Object.Instantiate<Rilisoft.ReusableRewardedVideo>(original:  val_2, parent:  val_22);
            this.七业下三七一丕丟与 = val_6;
            if(val_6 != 0)
            {
                goto label_13;
            }
            
            val_21 = "_rewardedVideo is null.";
            label_9:
            UnityEngine.Debug.LogError(message:  val_21);
            val_23 = 0;
            return val_23;
            label_13:
            bool val_8 = this.七业下三七一丕丟与.丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  this);
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.七业下三七一丕丟与.gameObject, 不东丛三丂丌丑专丆:  this.RewardedVideoParent.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            this.七业下三七一丕丟与.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            this.七业下三七一丕丟与.transform.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            this.七业下三七一丕丟与.add_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_1B0));
            this.七业下三七一丕丟与.add_EnterWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_1A0));
            this.七业下三七一丕丟与.add_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void Rilisoft.AdsRewardWatchController::OnExitWatching(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.七业下三七一丕丟与.add_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_190));
            System.EventHandler val_20 = null;
            val_22 = val_20;
            val_20 = new System.EventHandler(object:  this, method:  public System.Void Rilisoft.AdsRewardWatchController::OnShow(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.七业下三七一丕丟与.add_Show(丙业与丙丗丝不丈东:  val_20);
            label_3:
            val_23 = this.七业下三七一丕丟与;
            return val_23;
        }
        public static Progress.与丄东丄丘丐丙丅业 GetCountKey(Progress.与丄东丄丘丐丙丅业 下上丐丆丝丟丝丒不)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((Rilisoft.AdsRewardWatchController.丙万丂丕丄丘丘丞丙.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            if(Rilisoft.AdsRewardWatchController.丙万丂丕丄丘丘丞丙 != null)
            {
                    return Rilisoft.AdsRewardWatchController.丙万丂丕丄丘丘丞丙.Item[下上丐丆丝丟丝丒不];
            }
            
            return Rilisoft.AdsRewardWatchController.丙万丂丕丄丘丘丞丙.Item[下上丐丆丝丟丝丒不];
        }
        internal bool 丄丛丅丐世丌丕且丛(bool 与丒丌丈七不专三一 = False)
        {
            var val_8;
            string val_5 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.丒丐丆丘丈丟丂下专() != false)
            {
                    if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                goto label_2;
            }
            
            }
            
            System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) == 0)
            {
                goto label_5;
            }
            
            if((this.且世丄丙丄丕丌不下(与丒丌丈七不专三一:  与丒丌丈七不专三一, 丁丂丕与丁丒丕丟丞: out  val_5)) == false)
            {
                goto label_6;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[AdsRewardWatchController.AreAdcAvailable] TryGetReasonToOmitRewardedVideo: "("[AdsRewardWatchController.AreAdcAvailable] TryGetReasonToOmitRewardedVideo: ") + val_5);
            val_8 = 0;
            this.丞丐丟三丌与丞上一 = val_5;
            return (bool)val_8;
            label_5:
            UnityEngine.Debug.Log(message:  "[AdsRewardWatchController.AreAdcAvailable] Dismissing rewarded video: GetServerTime");
            label_2:
            val_8 = 0;
            return (bool)val_8;
            label_6:
            val_8 = 1;
            return (bool)val_8;
        }
        public string GetErrorCode()
        {
            return (string)this.丞丐丟三丌与丞上一;
        }
        public void UpdateDefKey(Progress.与丄东丄丘丐丙丅业 下上丐丆丝丟丝丒不)
        {
            null = null;
            Rilisoft.AdsRewardWatchController.丑一丌世丕万丙丒丕 = 下上丐丆丝丟丝丒不;
        }
        protected void OnDestroy()
        {
            if(this.七业下三七一丕丟与 == 0)
            {
                    return;
            }
            
            this.七业下三七一丕丟与.remove_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_1B0));
            this.七业下三七一丕丟与.remove_EnterWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_1A0));
            this.七业下三七一丕丟与.remove_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void Rilisoft.AdsRewardWatchController::OnExitWatching(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.七业下三七一丕丟与.remove_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_190));
            this.七业下三七一丕丟与.remove_Show(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void Rilisoft.AdsRewardWatchController::OnShow(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        public virtual bool TryShowAdcInterface()
        {
            string val_14;
            丅丒不上七丘万丙一 val_7 = 0;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_1;
            }
            
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
            {
                goto label_3;
            }
            
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丑丛丞三下业丁下三(上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  val_7, 丏丞专丏业丗丝七丝: out  0)) == false)
            {
                goto label_14;
            }
            
            if((PGCompany.DataObjects.业丐丙丞专丈世丛丙.丐丅且丗东丘上与丏(丟丐丗万丅下丗丝万:  val_7)) == false)
            {
                goto label_18;
            }
            
            if((PGCompany.DataObjects.业丐丙丞专丈世丛丙.丑丄丙一丑丅专丅上(丟丐丗万丅下丗丝万:  val_7, 下一丆丏丝丄东三三:  UnityEngine.SystemInfo.deviceModel)) == false)
            {
                goto label_9;
            }
            
            val_14 = "IsDeviceDisabled";
            goto label_18;
            label_1:
            val_14 = "TryGetServerUniversalTime";
            label_18:
            label_14:
            bool val_13 = this.丄丌丅丟业丟一丟三(丄丙下丝丛丒七丂丘:  val_14, 与丗丆丏丙丟与丒业:  "TryShowAdcInterface");
            return false;
            label_3:
            UnityEngine.Debug.LogWarning(message:  "Training not Completed");
            return false;
            label_9:
            if(this.丈丅丙丛丄世丁丅丌 == null)
            {
                goto label_18;
            }
            
            return false;
        }
        internal static System.Collections.Generic.KeyValuePair<System.DateTime, int> 丙丟专七丈不丗丁丅()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((PGCompany.东丑一丄丕丁丕一丟.七丗万下丆世不丗丗(下上丐丆丝丟丝丒不:  Rilisoft.AdsRewardWatchController.丑一丌世丕万丙丒丕, 一世上丟专丗丝丄丁: out  new System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32>())) != false)
            {
                    return 0;
            }
            
            System.DateTimeOffset val_2 = System.DateTimeOffset.FromUnixTimeMilliseconds(milliseconds:  0);
            val_5 = ;
            return 0;
        }
        protected static int 丈丞丌三七丏业下丙(System.DateTime 丒世万丕东丙丛丌七)
        {
            null = null;
            return PGCompany.东丑一丄丕丁丕一丟.丈丞丌三七丏业下丙(下上丐丆丝丟丝丒不:  Rilisoft.AdsRewardWatchController.丑一丌世丕万丙丒丕, 丒世万丕东丙丛丌七:  new System.DateTime() {dateData = 丒世万丕东丙丛丌七.dateData});
        }
        public virtual void OnDiscardWatching(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            goto typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_1C8;
        }
        public virtual void OnEnterWatching(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_8;
            var val_9;
            var val_10;
            BackgroundMusicController val_11;
            var val_12;
            var val_13;
            var val_14;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_3 = new object[2];
                val_3[0] = "AdsRewardWatchController.OnEnterWatching";
                val_3[1] = 丗丛不丁丑专专丂且.GetType();
                UnityEngine.Debug.LogFormat(format:  "[{0}] type: {1}", args:  val_3);
            }
            
            val_8 = null;
            val_8 = null;
            if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
            {
                    val_9 = null;
                val_9 = null;
                MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丄丏下七丁专丂世();
            }
            
            val_10 = null;
            val_10 = null;
            val_11 = BackgroundMusicController.丄丘七三上丕世丞业;
            if(val_11 != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_11 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
                if(val_11 != 0)
            {
                    val_13 = null;
                val_13 = null;
                val_14 = null;
                val_11 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
                val_14 = null;
                val_11.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁());
            }
            
            }
            
            与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  false);
        }
        public void OnExitWatching(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_3 = new object[2];
                val_3[0] = "AdsRewardWatchController.OnExitWatching";
                val_3[1] = 丗丛不丁丑专专丂且.GetType();
                UnityEngine.Debug.LogFormat(format:  "[{0}] type: {1}", args:  val_3);
            }
            
            与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  丛丌丙丂丑丞丂丏丟.丑上万丌丏上丌下三(丒丘丏上丙丟丑丕丈:  丛丌丙丂丑丞丂丏丟.丏丏丌丆丞丂丆不丗(), 专不三上丏专丄且丞:  true));
            val_10 = null;
            val_10 = null;
            if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
            {
                    val_11 = null;
                val_11 = null;
                MenuBackgroundMusic.丌丂一丛下丒丞丛东.三且世三丂七丐一丟();
            }
            
            val_12 = null;
            val_12 = null;
            if(BackgroundMusicController.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            MenuBackgroundMusic.丌丂一丛下丒丞丛东.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁());
        }
        public void OnShow(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            goto typeof(Rilisoft.AdsRewardWatchController).__il2cppRuntimeField_1D8;
        }
        private static void 丒丝丘业一七且丘且(System.DateTime 丅丏丅丂丝一丆丙丅)
        {
            var val_3 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  Rilisoft.AdsRewardWatchController.丑一丌世丕万丙丒丕, 丙业与丙丗丝不丈东:  丅丏丅丂丝一丆丙丅.dateData);
            int val_2 = Rilisoft.AdsRewardWatchController.丈丞丌三七丏业下丙(丒世万丕东丙丛丌七:  new System.DateTime() {dateData = 丅丏丅丂丝一丆丙丅.dateData});
        }
        public void ExitWacthing()
        {
        
        }
        public void EnterWacthing()
        {
        
        }
        public virtual void OnAdWatchedSuccessfully(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if((this & 1) != 0)
            {
                    UnityEngine.Debug.Log(message:  "[AdsRewardWatchController.OnAdWatchedSuccessfully] " + 丗丛不丁丑专专丂且.GetType());
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  37);
            System.DateTime val_5 = this.RewardedVideo.上丟丄与丁三丌丘专();
            Rilisoft.AdsRewardWatchController.丒丝丘业一七且丘且(丅丏丅丂丝一丆丙丅:  new System.DateTime() {dateData = val_5.dateData});
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal static System.Nullable<System.DateTime> 丝丆丙丝且上丆一丐()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            string val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  Rilisoft.AdsRewardWatchController.丑一丌世丕万丙丒丕);
            val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  val_2)) == true)
            {
                    return 0;
            }
            
            if((System.DateTime.TryParse(s:  val_2, result: out  new System.DateTime())) == false)
            {
                    return 0;
            }
            
            val_6 = 0;
            return 0;
        }
        public virtual void AccrueReward(int 丗七丟丈三不丕一三)
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
        }
        public virtual void ResetReward(int 丗七丟丈三不丕一三)
        {
        
        }
        public virtual void OnSwonRewardVideo()
        {
        
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        protected virtual bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        protected static bool 丁丂专丝丑丗丅业丑(string 东丒丝不上丛丒丌丄, out string 丄丙下丝丛丒七丂丘)
        {
            丄丙下丝丛丒七丂丘 = 东丒丝不上丛丒丌丄;
            return false;
        }
        protected bool 不丟丅丙丄三三三丂(string 丄丙下丝丛丒七丂丘, string 与丗丆丏丙丟与丒业 = "")
        {
            string val_4;
            string val_5;
            val_4 = 与丗丆丏丙丟与丒业;
            val_5 = 丄丙下丝丛丒七丂丘;
            if((this & 1) == 0)
            {
                    return false;
            }
            
            string[] val_1 = new string[6];
            val_1[0] = "[";
            val_1[1] = this.GetType();
            val_1[2] = ".";
            val_1[3] = val_4;
            val_4 = "] ";
            val_1[4] = val_4;
            val_1[5] = val_5;
            val_5 = +val_1;
            UnityEngine.Debug.Log(message:  val_5);
            return false;
        }
        protected bool 丄丌丅丟业丟一丟三(string 丄丙下丝丛丒七丂丘, string 与丗丆丏丙丟与丒业 = "")
        {
            string val_4;
            string val_5;
            val_4 = 与丗丆丏丙丟与丒业;
            val_5 = 丄丙下丝丛丒七丂丘;
            if((this & 1) == 0)
            {
                    return false;
            }
            
            string[] val_1 = new string[6];
            val_1[0] = "[";
            val_1[1] = this.GetType();
            val_1[2] = ".";
            val_1[3] = val_4;
            val_4 = "] ";
            val_1[4] = val_4;
            val_1[5] = val_5;
            val_5 = +val_1;
            UnityEngine.Debug.LogWarning(message:  val_5);
            return false;
        }
        protected static bool 丕下业丈下世七丒业(string 东丒丝不上丛丒丌丄, out string 丄丙下丝丛丒七丂丘)
        {
            丄丙下丝丛丒七丂丘 = 东丒丝不上丛丒丌丄;
            return true;
        }
        protected void 丝丌一业丄不七丁世(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丕丄丘不专丘七专与 丌东丙丝丂一丅三丞)
        {
            this.丈丅丙丛丄世丁丅丌 = 丌东丙丝丂一丅三丞;
        }
        protected bool 且世丄丙丄丕丌不下(bool 与丒丌丈七不专三一, out string 丁丂丕与丁丒丕丟丞)
        {
            string val_30;
            var val_31;
            var val_32;
            var val_33;
            string val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            丕丄丘不专丘七专与 val_5 = 0;
            val_30 = this;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  this, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  string val_6 = 丁丂丕与丁丒丕丟丞)) == false)
            {
                    return true;
            }
            
            if(与丒丌丈七不专三一 == false)
            {
                goto label_8;
            }
            
            val_32 = null;
            if(Rilisoft.AdsRewardWatchController.丒丑三丛丌丈专丆下() == false)
            {
                goto label_8;
            }
            
            val_30 = val_5;
            if((val_30 + 18.GetValueOrDefault()) == false)
            {
                goto label_10;
            }
            
            label_8:
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_11;
            }
            
            if(135970152 == 0)
            {
                goto label_13;
            }
            
            var val_35 = 106557164;
            if(0 == 0)
            {
                goto label_14;
            }
            
            var val_33 = 0;
            var val_34 = 107374182407;
            label_16:
            if(mem[107374182399] == null)
            {
                goto label_15;
            }
            
            val_33 = val_33 + 1;
            val_34 = val_34 + 16;
            if(val_33 < 0)
            {
                goto label_16;
            }
            
            label_14:
            val_31 = 0;
            goto label_17;
            label_11:
            val_34 = "TryGetServerUniversalTime";
            goto label_84;
            label_13:
            val_34 = "rewardedVideoDelayMinutes";
            goto label_84;
            label_10:
            val_34 = "IsVipActive";
            goto label_84;
            label_15:
            val_35 = val_35 + ((mem[107374182407]) << 4);
            val_33 = val_35 + 296;
            label_17:
            val_35 = 135970152;
            if(val_35.Count == 0)
            {
                goto label_27;
            }
            
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_13 = Rilisoft.AdsRewardWatchController.丙丟专七丈不丗丁丅();
            var val_38 = 106557164;
            if(0 == 0)
            {
                goto label_30;
            }
            
            var val_36 = 0;
            var val_37 = 107374182407;
            label_32:
            if(mem[107374182399] == null)
            {
                goto label_31;
            }
            
            val_36 = val_36 + 1;
            val_37 = val_37 + 16;
            if(val_36 < 0)
            {
                goto label_32;
            }
            
            label_30:
            val_31 = 0;
            goto label_33;
            label_27:
            val_34 = "Count";
            label_84:
            丁丂丕与丁丒丕丟丞 = val_34;
            return true;
            label_31:
            val_38 = val_38 + ((mem[107374182407]) << 4);
            val_36 = val_38 + 296;
            label_33:
            int val_14 = 135970152.Count;
            var val_41 = 106557164;
            if(0 == 0)
            {
                goto label_36;
            }
            
            var val_39 = 0;
            var val_40 = 107374182407;
            label_38:
            if(mem[107374182399] == null)
            {
                goto label_37;
            }
            
            val_39 = val_39 + 1;
            val_40 = val_40 + 16;
            if(val_39 < 0)
            {
                goto label_38;
            }
            
            label_36:
            val_31 = 0;
            goto label_39;
            label_37:
            val_41 = val_41 + ((mem[107374182407]) << 4);
            val_37 = val_41 + 296;
            label_39:
            T val_17 = 135970152.Item[ - (( / val_14) * val_14)];
            System.TimeSpan val_18 = System.TimeSpan.FromMinutes(value:  (double)V0.16B);
            System.DateTimeOffset val_19 = System.DateTimeOffset.Now;
            if(val_19.m_dateTime.dateData.TotalHours > 15)
            {
                    val_38 = null;
                val_38 = null;
            }
            
            if(System.TimeSpan.Zero.TotalHours < 0)
            {
                    val_39 = null;
                val_39 = null;
            }
            
            string val_22 = val_13.Value.丐丏七丌丕丗业且上();
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {}, t2:  new System.DateTime() {})) != false)
            {
                    丁丂丕与丁丒丕丟丞 = "localDateTime < nextLocalTimeShowMaybeAvailable";
                if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return true;
            }
            
                string[] val_25 = new string[5];
                val_25[0] = 丁丂丕与丁丒丕丟丞;
                val_25[1] = ", ";
                System.Globalization.CultureInfo val_26 = Rilisoft.AdsRewardWatchController.丙专丝世不业下丂丈();
                val_25[2] = ;
                val_25[3] = " < ";
                System.Globalization.CultureInfo val_27 = Rilisoft.AdsRewardWatchController.丙专丝世不业下丂丈();
                val_25[4] = ;
                丁丂丕与丁丒丕丟丞 = +val_25;
                return true;
            }
            
            System.DateTime val_29 = Date;
            System.DateTime val_30 = Date;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_29.dateData}, d2:  new System.DateTime() {dateData = val_30.dateData})) == false)
            {
                    return true;
            }
            
            var val_44 = 106557164;
            if(0 == 0)
            {
                goto label_79;
            }
            
            var val_42 = 0;
            var val_43 = 107374182407;
            label_78:
            if(mem[107374182399] == null)
            {
                goto label_77;
            }
            
            val_42 = val_42 + 1;
            val_43 = val_43 + 16;
            if(val_42 < 0)
            {
                goto label_78;
            }
            
            goto label_79;
            label_77:
            val_44 = val_44 + ((mem[107374182407]) << 4);
            val_40 = val_44 + 296;
            label_79:
            if( >= 135970152.Count)
            {
                goto label_84;
            }
            
            return true;
        }
        private static bool 丒丑三丛丌丈专丆下()
        {
            var val_11;
            var val_12;
            val_11 = PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世();
            if(val_11.丝丞丙丂与上且丙丛() != false)
            {
                    val_11 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
                if(val_11 == null)
            {
                    return (bool)val_12;
            }
            
                if(val_11.丂丁丏一丙丛业且丌() >= 1)
            {
                    System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7 = val_11.且业上丞丄丁专不丙();
                if(val_7 == null)
            {
                    return (bool)val_12;
            }
            
                var val_9 = (val_7.Count > 0) ? 1 : 0;
                return (bool)val_12;
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        protected AdsRewardWatchController()
        {
        
        }
        private static AdsRewardWatchController()
        {
            System.Collections.Generic.Dictionary<Progress.与丄东丄丘丐丙丅业, Progress.与丄东丄丘丐丙丅业> val_1 = new System.Collections.Generic.Dictionary<Progress.与丄东丄丘丐丙丅业, Progress.与丄东丄丘丐丙丅业>();
            if(val_1 != null)
            {
                    val_1.Add(key:  34, value:  35);
                val_1.Add(key:  31, value:  32);
                val_1.Add(key:  38, value:  39);
                val_1.Add(key:  40, value:  41);
                val_1.Add(key:  42, value:  43);
                val_1.Add(key:  44, value:  45);
            }
            else
            {
                    val_1.Add(key:  34, value:  35);
                val_1.Add(key:  31, value:  32);
                val_1.Add(key:  38, value:  39);
                val_1.Add(key:  40, value:  41);
                val_1.Add(key:  42, value:  43);
                val_1.Add(key:  44, value:  45);
            }
            
            val_1.Add(key:  46, value:  47);
            Rilisoft.AdsRewardWatchController.丙万丂丕丄丘丘丞丙 = val_1;
            Rilisoft.AdsRewardWatchController.丑一丌世丕万丙丒丕 = 0;
        }
    
    }

}
