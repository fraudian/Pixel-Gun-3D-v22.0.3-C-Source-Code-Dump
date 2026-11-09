using UnityEngine;

namespace PGCompany.WebSocket.Analytics
{
    internal sealed class ConnectionAnalyticsSender : Singleton<PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender>
    {
        // Fields
        private const string 三丒丙丝丟不丗不专 = "ConnectionAnalytics_Sender.LogsToUsKey";
        private const string 丗丐且丁丑世丘丙不 = "ConnectionAnalytics_Sender.LogsToEuKey";
        private const int 且下上丌丄丂丏三且 = 10;
        private const int 世丕丈丄丆三专下万 = 180;
        private const int 东业一丒万丟丑丏丕 = 20;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丆丌丛丈东专上丁丛;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丈与丐丗三丆世丑丅;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丏三世且丟丌丆丆丅;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丘专丝丘丗且且三不;
        
        // Methods
        internal static void 丙丌专东丌丏东丗丕()
        {
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender val_1 = Rilisoft.Singleton<PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender>.Instance;
        }
        internal static void 七丏丙丝丏万与丅上(PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂 丙丁丌丛业不丄丝丈, bool 丞业丙三且丑丂七上)
        {
            var val_6;
            if((丙丁丌丛业不丄丝丈.<三丕丂东丙专上丕丆>k__BackingField) >= 1)
            {
                
            }
            
            val_6 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.不丑丄东丗丏丒丂丑(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  (~丞业丙三且丑丂七上) & 1, 东丏上东丆丕丂丗不:  (int)PGCompany.Analytics.上丒丞上丌丌丘丛一.__il2cppRuntimeField_cctor_finished.TotalSeconds, 丞丐丟三丌与丞上一:  new System.Nullable<System.Int32>() {HasValue = false}, 丝丏业丅丈东业丝丒:  丙丁丌丛业不丄丝丈.<丟万且丞丏丈丛下丙>k__BackingField, 丄丒且丙三丆丟与丏:  丙丁丌丛业不丄丝丈.<丟万且丞丏丈丛下丙>k__BackingField, 丅东下万丐丐丌丂丞:  W24, 丒丆丘丅丁丘丐丞丈:  丙丁丌丛业不丄丝丈.丝丞万下丞丗丘丒丆(), 东丞丒丙世丏三下丟:  丙丁丌丛业不丄丝丈.<三丄上丄专丝丟丄业>k__BackingField, 丑与丂丌世丕丆一丗:  丙丁丌丛业不丄丝丈.<丆丌丞丒丘丞上且丄>k__BackingField, 丘丞与万丕丞丌且丝:  丞业丙三且丑丂七上, 东丙丒丂丈不三一丞:  (true == 0) ? "server UTC" : "local UTC", 丐丅丐丐丌丅丒丛一:  ???, 与业丒东丛世三丞世:  丙丁丌丛业不丄丝丈);
        }
        internal static void 七丏丙丝丏万与丅上(PGCompany.WebSocket.Analytics.三东专丂丁不七丛不 丙丁丌丛业不丄丝丈)
        {
            bool val_2 = ((丙丁丌丛业不丄丝丈.<不丘丄丈与丌丅丁丝>k__BackingField) ^ 1) & 255;
            PGCompany.Analytics.一业丗丆世世上丁且.丏丗丗丈丄丞丑东丛(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  val_2, 东丏上东丆丕丂丗不:  (int)val_2.TotalSeconds, 丄丒且丙三丆丟与丏:  X22, 丅东下万丐丐丌丂丞:  W23, 丒丆丘丅丁丘丐丞丈:  丙丁丌丛业不丄丝丈.丝丞万下丞丗丘丒丆(), 东丞丒丙世丏三下丟:  丙丁丌丛业不丄丝丈.<且丈丄与丐且一丞丅>k__BackingField, 丈上丆世丘丙一三上:  丙丁丌丛业不丄丝丈.<七万不且下丈丟丗丆>k__BackingField, 丘丞与万丕丞丌且丝:  ???, 东丙丒丂丈不三一丞:  (true == 0) ? "server UTC" : "local UTC", 丐丅丐丐丌丅丒丛一:  137138176, 与业丒东丛世三丞世:  丙丁丌丛业不丄丝丈);
        }
        internal static void 七丏丙丝丏万与丅上(PGCompany.WebSocket.Analytics.与丈三丘丝丙丞丐丝 丙丁丌丛业不丄丝丈)
        {
            int val_6;
            string val_7;
            var val_8;
            string val_9;
            string val_10;
            string val_11;
            if(丙丁丌丛业不丄丝丈 != null)
            {
                    val_6 = 丙丁丌丛业不丄丝丈.<丌丅丝丝丁丑东丁丗>k__BackingField;
            }
            else
            {
                    val_6 = 0;
            }
            
            if(丙丁丌丛业不丄丝丈 != null)
            {
                    val_10 = 丙丁丌丛业不丄丝丈.丝丞万下丞丗丘丒丆();
            }
            else
            {
                    val_7 = 11993091;
                val_8 = 4194311;
                val_10 = 丙丁丌丛业不丄丝丈.丝丞万下丞丗丘丒丆();
                val_9 = 64;
            }
            
            if(丙丁丌丛业不丄丝丈 != null)
            {
                
            }
            else
            {
                    val_11 = 135970152;
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.三丑七七丅丘上丐且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丏丌七且丆丛丁丌丑:  0, 东丏上东丆丕丂丗不:  (int)72.TotalSeconds, 丄丒且丙三丆丟与丏:  val_7, 丅东下万丐丐丌丂丞:  4194311, 丒丆丘丅丁丘丐丞丈:  val_10, 丘丞与万丕丞丌且丝:  val_9, 东丙丒丂丈不三一丞:  (true == 0) ? "server UTC" : "local UTC", 丐丅丐丐丌丅丒丛一:  val_11, 与业丒东丛世三丞世:  丙丁丌丛业不丄丝丈);
        }
        internal static void 丂东丙世一丕丗东下(PGCompany.WebSocket.Analytics.丅丏丏下丈丟世专丂 丙丁丌丛业不丄丝丈, bool 丞业丙三且丑丂七上)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_2.set_Item(key:  "event_type", value:  "socket event");
            val_2.set_Item(key:  "not_responding", value:  丞业丙三且丑丂七上);
            val_2.set_Item(key:  "has_error", value:  ((丙丁丌丛业不丄丝丈.<三丕丂东丙专上丕丆>k__BackingField) > 0) ? 1 : 0);
            if((丙丁丌丛业不丄丝丈.<三丕丂东丙专上丕丆>k__BackingField) >= 1)
            {
                    val_2.set_Item(key:  "error_code", value:  丙丁丌丛业不丄丝丈.<三丕丂东丙专上丕丆>k__BackingField);
            }
            
            val_2.set_Item(key:  "event_name", value:  丙丁丌丛业不丄丝丈.<丟万且丞丏丈丛下丙>k__BackingField);
            val_2.set_Item(key:  "request", value:  丙丁丌丛业不丄丝丈.<三丄上丄专丝丟丄业>k__BackingField);
            if((丙丁丌丛业不丄丝丈.<丆丌丞丒丘丞上且丄>k__BackingField) != null)
            {
                    val_2.set_Item(key:  "response", value:  丙丁丌丛业不丄丝丈.<丆丌丞丒丘丞上且丄>k__BackingField);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.专一丙丕丆三丝丅丐(丙丁丌丛业不丄丝丈:  丙丁丌丛业不丄丝丈).GetEnumerator();
            label_14:
            if(((-949221016) & 1) == 0)
            {
                goto label_12;
            }
            
            ConfiguredValueTaskAwaiter val_6 = 0.GetAwaiter();
            val_2.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  val_6._value._obj);
            goto label_14;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丏丒丞业丛世丝丄丙(一丐丗丁丞丆丅丟丄:  val_2);
        }
        internal static void 丂东丙世一丕丗东下(PGCompany.WebSocket.Analytics.三东专丂丁不七丛不 丙丁丌丛业不丄丝丈)
        {
            string val_8;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "event_type", value:  "http auth");
            val_1.set_Item(key:  "not_responding", value:  丙丁丌丛业不丄丝丈.<不丘丄丈与丌丅丁丝>k__BackingField);
            bool val_8 = 丙丁丌丛业不丄丝丈.<不丘丄丈与丌丅丁丝>k__BackingField;
            val_8 = val_8 ^ 1;
            val_1.set_Item(key:  "with_error", value:  val_8);
            val_1.set_Item(key:  "request", value:  丙丁丌丛业不丄丝丈.<且丈丄与丐且一丞丅>k__BackingField);
            val_8 = 丙丁丌丛业不丄丝丈.<七万不且下丈丟丗丆>k__BackingField;
            val_1.set_Item(key:  "result", value:  val_8);
            if((丙丁丌丛业不丄丝丈.<三丕一丈三且丅业丈>k__BackingField) != null)
            {
                    val_8 = System.String.Format(format:  "{0} s", arg0:  丙丁丌丛业不丄丝丈.<三丕一丈三且丅业丈>k__BackingField.丄东丌丐丏专丒丛丘());
                val_1.set_Item(key:  "google_ping", value:  val_8);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.专一丙丕丆三丝丅丐(丙丁丌丛业不丄丝丈:  丙丁丌丛业不丄丝丈).GetEnumerator();
            label_12:
            if(((-949022632) & 1) == 0)
            {
                goto label_10;
            }
            
            ConfiguredValueTaskAwaiter val_6 = 0.GetAwaiter();
            val_1.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  val_6._value._obj);
            goto label_12;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丏丒丞业丛世丝丄丙(一丐丗丁丞丆丅丟丄:  val_1);
        }
        internal static void 丂东丙世一丕丗东下(PGCompany.WebSocket.Analytics.与丈三丘丝丙丞丐丝 丙丁丌丛业不丄丝丈)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "event_type", value:  "open socket");
            val_1.set_Item(key:  "tries", value:  丙丁丌丛业不丄丝丈.<丌丅丝丝丁丑东丁丗>k__BackingField);
            Dictionary.Enumerator<TKey, TValue> val_3 = PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.专一丙丕丆三丝丅丐(丙丁丌丛业不丄丝丈:  丙丁丌丛业不丄丝丈).GetEnumerator();
            label_7:
            if(((-948844920) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            val_1.set_Item(key:  val_4._value._obj.丐丏七丌丕丗业且上(), value:  val_4._value._obj);
            goto label_7;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender.丏丒丞业丛世丝丄丙(一丐丗丁丞丆丅丟丄:  val_1);
        }
        private static System.Collections.Generic.Dictionary<string, object> 专一丙丕丆三丝丅丐(PGCompany.WebSocket.Analytics.丅丒丛上世不丁丑专 丙丁丌丛业不丄丝丈)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "wait_time", value:  (int)丙丁丌丛业不丄丝丈.<下丂丌丒丌世丕业不>k__BackingField.TotalSeconds);
            val_1.set_Item(key:  "player_id", value:  丙丁丌丛业不丄丝丈.<丙丘一专丆丟丌世业>k__BackingField);
            val_1.set_Item(key:  "send_time", value:  丙丁丌丛业不丄丝丈.<丏且丒丞上丐业丁业>k__BackingField);
            val_1.set_Item(key:  "send_date", value:  丙丁丌丛业不丄丝丈.丝丞万下丞丗丘丒丆());
            val_1.set_Item(key:  "device_id", value:  丙丁丌丛业不丄丝丈.<上丅丂专丆丕丂丏丈>k__BackingField);
            val_1.set_Item(key:  "country", value:  丙丁丌丛业不丄丝丈.<丙不丁业下丂与业丅>k__BackingField);
            val_1.set_Item(key:  "time_desc", value:  ((丙丁丌丛业不丄丝丈.<丈三丈丈丄丑三丞业>k__BackingField) == false) ? "server UTC" : "local UTC");
            val_1.set_Item(key:  "ip", value:  丙丁丌丛业不丄丝丈.<丏且丅丏且丏丒丞七>k__BackingField);
            return val_1;
        }
        private static void 丏丒丞业丛世丝丄丙(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender val_1 = Rilisoft.Singleton<PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender>.Instance;
            val_1.丆丌丛丈东专上丁丛.set_Item(key:  PGCompany.丏丘专丂丙世丘丂世.三丄丅丄丌丈丈丑下(), value:  一丐丗丁丞丆丅丟丄);
            PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender val_3 = Rilisoft.Singleton<PGCompany.WebSocket.Analytics.ConnectionAnalyticsSender>.Instance;
            val_3.丏三世且丟丌丆丆丅.set_Item(key:  PGCompany.丏丘专丂丙世丘丂世.三丄丅丄丌丈丈丑下(), value:  一丐丗丁丞丆丅丟丄);
        }
        protected override void Awake()
        {
            var val_21;
            var val_22;
            var val_24;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String> val_26;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>> val_28;
            var val_29;
            var val_30;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String> val_31;
            var val_33;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>> val_36;
            this.Awake();
            val_21 = 1152921505405513728;
            DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            val_22 = 1152921505266909184;
            string val_2 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "ConnectionAnalytics_Sender.LogsToUsKey", 丞丌丑丛上丕丙丕下:  "{}");
            var val_21 = 0;
            val_21 = val_21 + 1;
            this.丆丌丛丈东专上丁丛 = val_1;
            if(val_1.Count >= 11)
            {
                    val_24 = null;
                val_24 = null;
                val_26 = ConnectionAnalyticsSender.<>c.<>9__18_0;
                if(val_26 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String> val_6 = null;
                val_26 = val_6;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String>(object:  ConnectionAnalyticsSender.<>c.__il2cppRuntimeField_static_fields, method:  System.String ConnectionAnalyticsSender.<>c::东七七上上三丟与专(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 三丟东丕丄丄下下丑));
                val_24 = null;
                ConnectionAnalyticsSender.<>c.<>9__18_0 = val_26;
            }
            
                val_24 = null;
                val_28 = ConnectionAnalyticsSender.<>c.<>9__18_1;
                if(val_28 == null)
            {
                    val_29 = val_21;
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>> val_7 = null;
                val_28 = val_7;
                val_7 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  ConnectionAnalyticsSender.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> ConnectionAnalyticsSender.<>c::上且业丙丅丞专丛丄(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 丒丒丄丁且丄丆丂丌));
                val_21 = ;
                ConnectionAnalyticsSender.<>c.<>9__18_1 = val_28;
                val_22 = 1152921505266909184;
            }
            
                val_30 = public static System.Collections.Generic.Dictionary<TKey, TElement> System.Linq.Enumerable::ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector);
                this.丆丌丛丈东专上丁丛 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Take<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>(source:  this.丆丌丛丈东专上丁丛, count:  10), keySelector:  val_6, elementSelector:  val_7);
            }
            
            DataSystem.丈且丈上不下且丝丒 val_9 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            val_31 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "ConnectionAnalytics_Sender.LogsToEuKey", 丞丌丑丛上丕丙丕下:  "{}");
            var val_22 = 0;
            val_22 = val_22 + 1;
            this.丏三世且丟丌丆丆丅 = val_9;
            if(val_9.Count >= 11)
            {
                    val_33 = null;
                val_33 = null;
                val_31 = ConnectionAnalyticsSender.<>c.<>9__18_2;
                if(val_31 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String> val_14 = null;
                val_31 = val_14;
                val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String>(object:  ConnectionAnalyticsSender.<>c.__il2cppRuntimeField_static_fields, method:  System.String ConnectionAnalyticsSender.<>c::丂丕丗丒七且丕丌不(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 三丟东丕丄丄下下丑));
                val_33 = null;
                ConnectionAnalyticsSender.<>c.<>9__18_2 = val_31;
            }
            
                val_33 = null;
                val_36 = ConnectionAnalyticsSender.<>c.<>9__18_3;
                if(val_36 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>> val_15 = null;
                val_36 = val_15;
                val_15 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  ConnectionAnalyticsSender.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> ConnectionAnalyticsSender.<>c::万丛业丛丁业丗下丙(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 丒丒丄丁且丄丆丂丌));
                ConnectionAnalyticsSender.<>c.<>9__18_3 = val_36;
            }
            
                val_30 = public static System.Collections.Generic.Dictionary<TKey, TElement> System.Linq.Enumerable::ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector);
                System.Collections.Generic.Dictionary<TKey, TElement> val_16 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Take<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>(source:  this.丏三世且丟丌丆丆丅, count:  10), keySelector:  val_14, elementSelector:  val_15);
                this.丏三世且丟丌丆丆丅 = val_16;
            }
            
            UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  this.StartCoroutine(routine:  val_16.丅专上下丝丕与丝丟(七丙不丅丛丘丗万与:  "https://pixelgun-clientlogs-us.lightmap.ru/problem", 丙丙业丆七丏一万丏:  this.丆丌丛丈东专上丁丛, 专丘丐丞与丗业七丐:  this.丈与丐丗三丆世丑丅)).丅专上下丝丕与丝丟(七丙不丅丛丘丗万与:  "https://pixelgun-clientlogs-eu.lightmap.ru/problem", 丙丙业丆七丏一万丏:  this.丏三世且丟丌丆丆丅, 专丘丐丞与丗业七丐:  this.丘专丝丘丗且且三不));
        }
        private void OnDestroy()
        {
            var val_6;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_6 = 0;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ConnectionAnalytics_Sender.LogsToUsKey", 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丆丌丛丈东专上丁丛));
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_6 = 0;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ConnectionAnalytics_Sender.LogsToEuKey", 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丏三世且丟丌丆丆丅));
        }
        private System.Collections.IEnumerator 丅专上下丝丕与丝丟(string 七丙不丅丛丘丗万与, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丙丙业丆七丏一万丏, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 专丘丐丞与丗业七丐)
        {
            ConnectionAnalyticsSender.且丟三丞丕业下丑世 val_1 = new ConnectionAnalyticsSender.且丟三丞丕业下丑世();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .七丙不丅丛丘丗万与 = 七丙不丅丛丘丗万与;
                .丙丙业丆七丏一万丏 = 丙丙业丆七丏一万丏;
            }
            else
            {
                    mem[48] = 七丙不丅丛丘丗万与;
                mem[32] = 丙丙业丆七丏一万丏;
            }
            
            .专丘丐丞与丗业七丐 = 专丘丐丞与丗业七丐;
            return (System.Collections.IEnumerator)val_1;
        }
        public ConnectionAnalyticsSender()
        {
            this.丆丌丛丈东专上丁丛 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.丈与丐丗三丆世丑丅 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.丏三世且丟丌丆丆丅 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.丘专丝丘丗且且三不 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
        }
    
    }

}
