using UnityEngine;

namespace AppsFlyerSDK
{
    public class 丑七丛丕东世丙不业 : EventArgs
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, object> 丛丌三丘丅丝一丗一;
        private readonly AppsFlyerSDK.丅丈丈丑东不丑下东 <万丏与不丒不丝丌丌>k__BackingField;
        private readonly AppsFlyerSDK.丄丟万上丒万一丙丒 <丑丟且丌丁一丂不一>k__BackingField;
        
        // Properties
        public AppsFlyerSDK.丅丈丈丑东不丑下东 丝丝不丝上丂三丌世 { get; }
        public AppsFlyerSDK.丄丟万上丒万一丙丒 丂七东不不丈一丐不 { get; }
        
        // Methods
        public AppsFlyerSDK.丅丈丈丑东不丑下东 丂丒丕丛万一专丅一()
        {
            return (AppsFlyerSDK.丅丈丈丑东不丑下东)this.<万丏与不丒不丝丌丌>k__BackingField;
        }
        public AppsFlyerSDK.丄丟万上丒万一丙丒 丞丄丕上丕七丘丌丛()
        {
            return (AppsFlyerSDK.丄丟万上丒万一丙丒)this.<丑丟且丌丁一丂不一>k__BackingField;
        }
        public string 世丕丝丘丂丂上丏丟()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "match_type");
        }
        public string 丂丒且七世不丗丄丄()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "deep_link_value");
        }
        public string 丛丗丁丏丌丟丄三与()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "click_http_referrer");
        }
        public string 丘上一三不且丏丝七()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "media_source");
        }
        public string 丂上丛丛丕丁丆丘丝()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "campaign");
        }
        public string 专丞上不丂三丅丝丑()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "campaign_id");
        }
        public string 且与丆丘丌业丄世丛()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "af_sub1");
        }
        public string 丗丄丝且丆丐丐丘丐()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "af_sub2");
        }
        public string 丁丗丂丁业丈业专不()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "af_sub3");
        }
        public string 上丗丐万上丅丝丛丕()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "af_sub4");
        }
        public string 丝丅丑世丆丂丟丆丟()
        {
            return this.七丙上丟丕丂丁丒一(丒丘丏上丙丟丑丕丈:  "af_sub5");
        }
        public bool 且不万一丙下丑丒丂()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
            val_5 = this;
            val_6 = this.丛丌三丘丅丝一丗一;
            if(val_6 == null)
            {
                    return (bool)val_6;
            }
            
            if((val_6.ContainsKey(key:  "is_deferred")) != false)
            {
                    val_5 = this.丛丌三丘丅丝一丗一;
                object val_2 = val_5.Item["is_deferred"];
                object val_3 = (null != 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public System.Collections.Generic.Dictionary<string, object> 丑丞世下丌丐丘丝丟()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.丛丌三丘丅丝一丗一;
        }
        public 丑七丛丕东世丙不业(string 下业七不丑丂丏丟东)
        {
            string val_17;
            string val_18;
            string val_19;
            AppsFlyerSDK.丅丈丈丑东不丑下东 val_20;
            AppsFlyerSDK.丄丟万上丒万一丙丒 val_21;
            val_17 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(下业七不丑丂丏丟东:  下业七不丑丂丏丟东);
            val_18 = "";
            val_19 = val_18;
            if((val_17.ContainsKey(key:  "status")) != false)
            {
                    val_19 = val_18;
                if(val_17.Item["status"] != null)
            {
                    val_19 = val_17.Item["status"];
            }
            
            }
            
            if((val_17.ContainsKey(key:  "error")) != false)
            {
                    if(val_17.Item["error"] != null)
            {
                    val_18 = val_17.Item["error"];
            }
            
            }
            
            if((val_17.ContainsKey(key:  "deepLink")) != false)
            {
                    if(val_17.Item["deepLink"] != null)
            {
                    val_17 = val_17.Item["deepLink"];
                this.丛丌三丘丅丝一丗一 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(下业七不丑丂丏丟东:  val_17);
            }
            
            }
            
            if((System.String.op_Equality(a:  val_19, b:  "FOUND")) != false)
            {
                    this.<万丏与不丒不丝丌丌>k__BackingField = 0;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_19, b:  "NOT_FOUND")) != false)
            {
                    val_20 = 1;
            }
            else
            {
                    val_20 = 2;
            }
            
                this.<万丏与不丒不丝丌丌>k__BackingField = val_20;
            }
            
            if((System.String.op_Equality(a:  val_18, b:  "TIMEOUT")) != false)
            {
                    this.<丑丟且丌丁一丂不一>k__BackingField = 0;
                return;
            }
            
            if((System.String.op_Equality(a:  val_18, b:  "NETWORK")) != false)
            {
                    val_21 = 1;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_18, b:  "HTTP_STATUS_CODE")) != false)
            {
                    val_21 = 2;
            }
            else
            {
                    val_21 = 3;
            }
            
            }
            
            this.<丑丟且丌丁一丂不一>k__BackingField = val_21;
        }
        private string 七丙上丟丕丂丁丒一(string 丒丘丏上丙丟丑丕丈)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10;
            string val_11 = 丒丘丏上丙丟丑丕丈;
            if(this.丛丌三丘丅丝一丗一 == null)
            {
                    return 0;
            }
            
            if((this.丛丌三丘丅丝一丗一.ContainsKey(key:  val_11 = 丒丘丏上丙丟丑丕丈)) == false)
            {
                    return 0;
            }
            
            val_10 = this.丛丌三丘丅丝一丗一;
            if(val_10.Item[val_11] == null)
            {
                    return 0;
            }
            
            object val_3 = this.丛丌三丘丅丝一丗一.Item[val_11];
            val_11 = ???;
            val_10 = ???;
            goto typeof(System.Object).__il2cppRuntimeField_158;
        }
    
    }

}
