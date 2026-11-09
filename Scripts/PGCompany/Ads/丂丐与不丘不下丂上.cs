using UnityEngine;

namespace PGCompany.Ads
{
    internal sealed class 丂丐与不丘不下丂上 : IDisposable
    {
        // Fields
        private readonly UnityEngine.GameObject 且三丏丒三不且丏丗;
        private bool 上丐丒业丟丛丅七与;
        private Rilisoft.ReusableRewardedVideo 七业下三七一丕丟与;
        
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        internal bool 丙七丟丙丆丏丕不专 { get; }
        
        // Methods
        internal 丂丐与不丘不下丂上(UnityEngine.GameObject 丙丁丘丙丝且丄上丌)
        {
            var val_4;
            if(丙丁丘丙丝且丄上丌 == null)
            {
                goto label_1;
            }
            
            if(丙丁丘丙丝且丄上丌 == 0)
            {
                goto label_4;
            }
            
            this.且三丏丒三不且丏丗 = 丙丁丘丙丝且丄上丌;
            return;
            label_1:
            System.ArgumentNullException val_2 = null;
            val_4 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "rewardedVideoParent");
            goto label_5;
            label_4:
            System.ArgumentException val_3 = null;
            val_4 = val_3;
            val_3 = new System.ArgumentException(message:  "rewardedVideoParent");
            label_5:
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal bool 丆丞且专丈世丞丞业()
        {
            return (bool)this.上丐丒业丟丛丅七与;
        }
        public void Dispose()
        {
            if(this.上丐丒业丟丛丅七与 == true)
            {
                    return;
            }
            
            if(this.七业下三七一丕丟与 != 0)
            {
                    this.七业下三七一丕丟与.remove_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::丙丙不丏七丙丕上丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                this.七业下三七一丕丟与.remove_EnterWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::世丕丆万丂丅业东东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                this.七业下三七一丕丟与.remove_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::世专不丝丒丐万丌丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                this.七业下三七一丕丟与.remove_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::丈业丑业丁丄丏下丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                this.七业下三七一丕丟与.remove_Show(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::业丙丘丈七不下下丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            }
            
            this.上丐丒业丟丛丅七与 = true;
        }
        internal bool 丆下丟三丅丞业丝丘(out Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专, out string 丅丏七一且且世丘世)
        {
            UnityEngine.Object val_19;
            Rilisoft.ReusableRewardedVideo val_20;
            string val_22;
            if(this.七业下三七一丕丟与 == null)
            {
                goto label_1;
            }
            
            val_19 = this.七业下三七一丕丟与;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  val_19, y:  0);
            val_20 = 0;
            if(val_1 != false)
            {
                    val_20 = this.七业下三七一丕丟与;
            }
            
            下丒丗丛丙丆丄丈专 = val_20;
            var val_2 = (val_1 != true) ? 0 : "ReusableRewardedVideo is disposed";
            goto label_5;
            label_1:
            下丒丗丛丙丆丄丈专 = 0;
            if(this.且三丏丒三不且丏丗 != 0)
            {
                goto label_8;
            }
            
            val_22 = "Parent is null or disposed";
            goto label_13;
            label_8:
            Rilisoft.ReusableRewardedVideo val_4 = UnityEngine.Resources.Load<Rilisoft.ReusableRewardedVideo>(path:  "SpeedUpItemRewardedVideo");
            if(val_4 != 0)
            {
                goto label_12;
            }
            
            val_22 = "Failed to load prefab";
            goto label_13;
            label_12:
            Rilisoft.ReusableRewardedVideo val_7 = UnityEngine.Object.Instantiate<Rilisoft.ReusableRewardedVideo>(original:  val_4, parent:  this.且三丏丒三不且丏丗.transform);
            this.七业下三七一丕丟与 = val_7;
            if(val_7 != 0)
            {
                goto label_17;
            }
            
            val_22 = "Failed to instantiate prefab";
            label_13:
            val_19 = 0;
            label_5:
            丅丏七一且且世丘世 = val_22;
            label_32:
            val_19 = val_19 & 1;
            return (bool)val_19;
            label_17:
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.七业下三七一丕丟与.gameObject, 不东丛三丂丌丑专丆:  this.且三丏丒三不且丏丗.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UnityEngine.Transform val_11 = this.七业下三七一丕丟与.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_11.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            val_11.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            this.七业下三七一丕丟与.add_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::丙丙不丏七丙丕上丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.七业下三七一丕丟与.add_EnterWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::世丕丆万丂丅业东东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.七业下三七一丕丟与.add_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::世专不丝丒丐万丌丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.七业下三七一丕丟与.add_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::丈业丑业丁丄丏下丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.七业下三七一丕丟与.add_Show(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Ads.丂丐与不丘不下丂上::业丙丘丈七不下下丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            下丒丗丛丙丆丄丈专 = this.七业下三七一丕丟与;
            丅丏七一且且世丘世 = 0;
            goto label_32;
        }
        private void 丙丙不丏七丙丕上丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(PGCompany.Ads.丂丐与不丘不下丂上.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[RewardedVideoHolder.OnAdWatchedSuccessfully]");
        }
        private void 世丕丆万丂丅业东东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(PGCompany.Ads.丂丐与不丘不下丂上.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[RewardedVideoHolder.OnEnterWatching]");
        }
        private void 世专不丝丒丐万丌丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(PGCompany.Ads.丂丐与不丘不下丂上.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[RewardedVideoHolder.OnExitWatching]");
        }
        private void 丈业丑业丁丄丏下丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(PGCompany.Ads.丂丐与不丘不下丂上.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[RewardedVideoHolder.OnDiscardWatching]");
        }
        private void 业丙丘丈七不下下丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(PGCompany.Ads.丂丐与不丘不下丂上.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[RewardedVideoHolder.OnShow]");
        }
    
    }

}
