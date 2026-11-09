using UnityEngine;

namespace Rilisoft
{
    internal sealed class 不不世丒三丐丟丙与
    {
        // Fields
        private bool 丆丞丈丐且丌丙丑不;
        
        // Methods
        public 不不世丒三丐丟丙与(bool 丅丂且丆万且丂丝丙)
        {
            this.丆丞丈丐且丌丙丑不 = 丅丂且丆万且丂丝丙;
        }
        internal void 丄一专与丙与丟三丘(float 丌丟丕不丄业不上业, string 七丒丐世世丘七丘丙, System.Collections.Generic.Dictionary<string, object> 丗丟上上丒丐丗丞丙)
        {
            if(Facebook.Unity.FB.IsInitialized == false)
            {
                goto label_3;
            }
            
            if(this.丆丞丈丐且丌丙丑不 == false)
            {
                goto label_4;
            }
            
            return;
            label_3:
            UnityEngine.Debug.LogWarning(message:  "Facebook is not initialized.");
            return;
            label_4:
            Facebook.Unity.FB.LogPurchase(logPurchase:  丌丟丕不丄业不上业, currency:  七丒丐世世丘七丘丙, parameters:  丗丟上上丒丐丗丞丙);
        }
        internal void 且丞丁三一丁丕万丛()
        {
            this.丆丞丈丐且丌丙丑不 = true;
        }
        internal void 丄万下丗丆丘丁丕专(string 丁业与丙下丅丞丄丅, System.Nullable<float> 七业世丙丈丅丐东东, System.Collections.Generic.Dictionary<string, object> 丗丟上上丒丐丗丞丙)
        {
            if(Facebook.Unity.FB.IsInitialized == false)
            {
                goto label_3;
            }
            
            if(this.丆丞丈丐且丌丙丑不 == false)
            {
                goto label_4;
            }
            
            return;
            label_3:
            UnityEngine.Debug.LogWarning(message:  "Facebook is not initialized.");
            return;
            label_4:
            Facebook.Unity.FB.LogAppEvent(logEvent:  丁业与丙下丅丞丄丅, valueToSum:  new System.Nullable<System.Single>() {HasValue = 七业世丙丈丅丐东东.HasValue}, parameters:  丗丟上上丒丐丗丞丙);
        }
    
    }

}
