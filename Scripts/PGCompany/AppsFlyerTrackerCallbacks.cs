using UnityEngine;

namespace PGCompany
{
    internal sealed class AppsFlyerTrackerCallbacks : MonoBehaviour, 下三丒丆丌下丘且丟
    {
        // Fields
        private static PGCompany.AppsFlyerTrackerCallbacks 世丒丞七专三与万丕;
        private System.EventHandler<string> 与丟丗上丕丕东上丞;
        private System.EventHandler<string> 丞七七丘七丂丁丄丑;
        
        // Properties
        internal static PGCompany.AppsFlyerTrackerCallbacks 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private AppsFlyerTrackerCallbacks()
        {
        
        }
        internal void 三丞万丟下专上丁上(System.EventHandler<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.与丟丗上丕丕东上丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丟丗上丕丕东上丞 != 1152921553948565640);
        
        }
        internal void 丆丙丝丄丐丕丆丆丛(System.EventHandler<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.与丟丗上丕丕东上丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丟丗上丕丕东上丞 != 1152921553948702216);
        
        }
        internal void 上丆丆丂上丗丙丆丙(System.EventHandler<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丞七七丘七丂丁丄丑, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丞七七丘七丂丁丄丑 != 1152921553948838800);
        
        }
        internal void 万丅丝丒丅万丒丂丘(System.EventHandler<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丞七七丘七丂丁丄丑, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丞七七丘七丂丁丄丑 != 1152921553948975376);
        
        }
        internal static PGCompany.AppsFlyerTrackerCallbacks 丑七不且上丗丁一世()
        {
            PGCompany.AppsFlyerTrackerCallbacks val_3;
            if(PGCompany.AppsFlyerTrackerCallbacks.世丒丞七专三与万丕 != 0)
            {
                    val_3 = PGCompany.AppsFlyerTrackerCallbacks.世丒丞七专三与万丕;
                return val_2;
            }
            
            PGCompany.AppsFlyerTrackerCallbacks val_2 = PGCompany.AppsFlyerTrackerCallbacks.东丝七业丄丑丒世七();
            PGCompany.AppsFlyerTrackerCallbacks.世丒丞七专三与万丕 = val_2;
            return val_2;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        public void onConversionDataSuccess(string 丒丟世丕三三丅一丗)
        {
            if(PGCompany.AppsFlyerTrackerCallbacks.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AppsFlyerTrackerCallbacks.onConversionDataSuccess] conversionData: "("[AppsFlyerTrackerCallbacks.onConversionDataSuccess] conversionData: ") + 丒丟世丕三三丅一丗);
            }
            
            if(this.与丟丗上丕丕东上丞 == null)
            {
                    return;
            }
            
            this.与丟丗上丕丕东上丞.Invoke(sender:  this, e:  丒丟世丕三三丅一丗);
        }
        public void onConversionDataFail(string 丂七东不不丈一丐不)
        {
            if(PGCompany.AppsFlyerTrackerCallbacks.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AppsFlyerTrackerCallbacks.onConversionDataFail] error: "("[AppsFlyerTrackerCallbacks.onConversionDataFail] error: ") + 丂七东不不丈一丐不);
            }
            
            if(this.丞七七丘七丂丁丄丑 == null)
            {
                    return;
            }
            
            this.丞七七丘七丂丁丄丑.Invoke(sender:  this, e:  丂七东不不丈一丐不);
        }
        public void onAppOpenAttribution(string 且丆丆丒丆七丁不丌)
        {
            if(PGCompany.AppsFlyerTrackerCallbacks.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[AppsFlyerTrackerCallbacks.onAppOpenAttribution] attributionData: "("[AppsFlyerTrackerCallbacks.onAppOpenAttribution] attributionData: ") + 且丆丆丒丆七丁不丌);
        }
        public void onAppOpenAttributionFailure(string 丂七东不不丈一丐不)
        {
            if(PGCompany.AppsFlyerTrackerCallbacks.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[AppsFlyerTrackerCallbacks.onAppOpenAttributionFailure] error: "("[AppsFlyerTrackerCallbacks.onAppOpenAttributionFailure] error: ") + 丂七东不不丈一丐不);
        }
        public void onOpenStoreLinkGenerated(string 上丗一三丙世丗丕丂)
        {
            if(PGCompany.AppsFlyerTrackerCallbacks.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AppsFlyerTrackerCallbacks.onOpenStoreLinkGenerated] link: "("[AppsFlyerTrackerCallbacks.onOpenStoreLinkGenerated] link: ") + 上丗一三丙世丗丕丂);
            }
            
            UnityEngine.Application.OpenURL(url:  上丗一三丙世丗丕丂);
        }
        private static PGCompany.AppsFlyerTrackerCallbacks 东丝七业丄丑丒世七()
        {
            if(PGCompany.AppsFlyerTrackerCallbacks.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AppsFlyerTrackerCallbacks.Create]");
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "AppsFlyerTrackerCallbacks");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            if(val_2 != null)
            {
                    return val_2.AddComponent<PGCompany.AppsFlyerTrackerCallbacks>();
            }
            
            return val_2.AddComponent<PGCompany.AppsFlyerTrackerCallbacks>();
        }
    
    }

}
