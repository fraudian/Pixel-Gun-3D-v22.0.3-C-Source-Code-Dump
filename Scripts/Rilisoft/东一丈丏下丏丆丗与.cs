using UnityEngine;

namespace Rilisoft
{
    internal sealed class 东一丈丏下丏丆丗与
    {
        // Fields
        private bool 丆丞丈丐且丌丙丑不;
        
        // Methods
        public 东一丈丏下丏丆丗与(string 丙丏三世丕丙丟世丘, bool 上丅上丒丗丏丌丛丝, bool 丅丂且丆万且丂丝丙)
        {
            if(丙丏三世丕丙丟世丘 != null)
            {
                    bool val_1 = 丅丂且丆万且丂丝丙;
                this.丆丞丈丐且丌丙丑不 = val_1;
                if(val_1 != false)
            {
                    return;
            }
            
                new Flurry.Builder().WithCrashReporting(crashReporting:  true).WithLogEnabled(enableLog:  true).WithLogLevel(logLevel:  (上丅上丒丗丏丌丛丝 != true) ? 3 : 5).Build(apiKey:  丙丏三世丕丙丟世丘);
                return;
            }
            
            System.ArgumentNullException val_7 = new System.ArgumentNullException(paramName:  "apiKey");
        }
        internal void 且丞丁三一丁丕万丛()
        {
            this.丆丞丈丐且丌丙丑不 = true;
        }
        public void 丟丕且丏不丛东丛东(string 丝丏业丅丈东业丝丒)
        {
            if(丝丏业丅丈东业丝丒 != null)
            {
                    if(this.丆丞丈丐且丌丙丑不 != false)
            {
                    return;
            }
            
                EventRecordStatus val_1 = FlurrySDK.Flurry.LogEvent(eventId:  丝丏业丅丈东业丝丒);
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "eventName");
        }
        public void 丒丏丘丛丙东丂下丄(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙)
        {
            string val_4;
            if(丝丏业丅丈东业丝丒 == null)
            {
                goto label_1;
            }
            
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_2;
            }
            
            if(this.丆丞丈丐且丌丙丑不 != false)
            {
                    return;
            }
            
            EventRecordStatus val_1 = FlurrySDK.Flurry.LogEvent(eventId:  丝丏业丅丈东业丝丒, parameters:  丗丟上上丒丐丗丞丙);
            return;
            label_1:
            val_4 = "eventName";
            goto label_6;
            label_2:
            val_4 = "parameters";
            label_6:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        public void 丌东丂丙上丅丐丂丈(string 万丄丅丝三丈丆世丟)
        {
            if(万丄丅丝三丈丆世丟 != null)
            {
                    if(this.丆丞丈丐且丌丙丑不 != false)
            {
                    return;
            }
            
                FlurrySDK.Flurry.SetUserId(userId:  万丄丅丝三丈丆世丟);
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "userId");
        }
    
    }

}
