using UnityEngine;

namespace Rilisoft.PushNotifications
{
    public sealed class PushNotificationReceiver : MonoBehaviour
    {
        // Fields
        private static System.Collections.IDictionary <与不丌上下丏丛丏丘>k__BackingField;
        private static string <丅三丆专丞三上丆丗>k__BackingField;
        private static System.Collections.Generic.Dictionary<string, object> <丕三丝丙丝丕且丛丙>k__BackingField;
        
        // Properties
        internal static System.Collections.IDictionary 丟与一东业丙丗丆丕 { get; set; }
        internal static string 丘一与上丒专丝丌下 { get; set; }
        internal static System.Collections.Generic.Dictionary<string, object> 万三东世不丒不丟丂 { get; set; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        internal static System.Collections.IDictionary 丁丒丆丕七丛与丟丞()
        {
            return (System.Collections.IDictionary)Rilisoft.PushNotifications.PushNotificationReceiver.<与不丌上下丏丛丏丘>k__BackingField;
        }
        private static void 下丘丁丛世丘丛三丒(System.Collections.IDictionary 丙业与丙丗丝不丈东)
        {
            Rilisoft.PushNotifications.PushNotificationReceiver.<与不丌上下丏丛丏丘>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static string 丗上丗七不万不丕丁()
        {
            return (string)Rilisoft.PushNotifications.PushNotificationReceiver.<丅三丆专丞三上丆丗>k__BackingField;
        }
        private static void 丘丆一丌丂一专与丕(string 丙业与丙丗丝不丈东)
        {
            Rilisoft.PushNotifications.PushNotificationReceiver.<丅三丆专丞三上丆丗>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丞丐丗七丆东且下丛()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField;
        }
        private static void 丕上三且丕丆丒下丕(System.Collections.Generic.Dictionary<string, object> 丙业与丙丗丝不丈东)
        {
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private void Awake()
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationReceiver.Awake]");
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            Prime31.EtceteraAndroidManager.add_notificationReceivedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.PushNotifications.PushNotificationReceiver::专丂丂丘丐丛专丛丘(string 一丐丗丁丞丆丅丟丄)));
            Unity.Notifications.Android.AndroidNotificationCenter.add_OnNotificationReceived(value:  new AndroidNotificationCenter.NotificationReceivedCallback(object:  this, method:  System.Void Rilisoft.PushNotifications.PushNotificationReceiver::七一专丌三丂专丘丌(Unity.Notifications.Android.AndroidNotificationIntentData 专丄丝丘丆丆下丟世)));
            this.丞世且与丏且下丒丄(专丄丝丘丆丆下丟世:  Unity.Notifications.Android.AndroidNotificationCenter.GetLastNotificationIntent(), 与丗丆丏丙丟与丒业:  "Awake");
        }
        private void Start()
        {
            Prime31.EtceteraAndroid.checkForNotifications();
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            if(东丗七丕丄不丐专丒 == false)
            {
                    return;
            }
            
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 0;
            Rilisoft.PushNotifications.下丝丛三与专丄东丐.不下丌丆东丑丈丕丝(一丐丗丁丞丆丅丟丄:  0);
        }
        private void 丛丘丂专丑一丁丛不(System.Collections.IDictionary 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.PushNotifications.PushNotificationReceiver.<与不丌上下丏丛丏丘>k__BackingField = 一丐丗丁丞丆丅丟丄;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 0;
            Rilisoft.PushNotifications.下丝丛三与专丄东丐.不下丌丆东丑丈丕丝(一丐丗丁丞丆丅丟丄:  0);
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    string val_2 = Prime31.JsonExtensions.toJson(obj:  一丐丗丁丞丆丅丟丄);
                1152921505500082176 = System.String.Format(format:  "[PushNotificationReceiver] [OnReceiveIOSRemoteNotification] {0}", arg0:  ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_2)) != true) ? (val_2) : "Remote notification data is NULL or Empty");
                UnityEngine.Debug.Log(message:  1152921505500082176);
            }
            
            this.丄丟丌东业东丆丒丞(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
            if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.三与专与丐丟丗丏一) == true)
            {
                    return;
            }
            
            Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.<丞丕丈一三丏七丒丈>k__BackingField = true;
        }
        private void 东万东丂万丁丑世丏(System.Collections.IDictionary 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.PushNotifications.PushNotificationReceiver.<与不丌上下丏丛丏丘>k__BackingField = 一丐丗丁丞丆丅丟丄;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 0;
            Rilisoft.PushNotifications.下丝丛三与专丄东丐.不下丌丆东丑丈丕丝(一丐丗丁丞丆丅丟丄:  0);
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    string val_2 = Prime31.JsonExtensions.toJson(obj:  一丐丗丁丞丆丅丟丄);
                1152921505500082176 = System.String.Format(format:  "[PushNotificationReceiver] [OnReceiveIOSLocalNotification] {0}", arg0:  ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_2)) != true) ? (val_2) : "Local notification data is NULL or Empty");
                UnityEngine.Debug.Log(message:  1152921505500082176);
            }
            
            this.丄东世七与丌丙丞丕(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
            if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.三与专与丐丟丗丏一) == true)
            {
                    return;
            }
            
            Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.<丞丕丈一三丏七丒丈>k__BackingField = true;
        }
        private void 七一专丌三丂专丘丌(Unity.Notifications.Android.AndroidNotificationIntentData 专丄丝丘丆丆下丟世)
        {
            this.丞世且与丏且下丒丄(专丄丝丘丆丆下丟世:  专丄丝丘丆丆下丟世, 与丗丆丏丙丟与丒业:  "OnAndroidNotificationReceived");
        }
        private void 丞世且与丏且下丒丄(Unity.Notifications.Android.AndroidNotificationIntentData 专丄丝丘丆丆下丟世, string 与丗丆丏丙丟与丒业)
        {
            var val_26;
            object val_27;
            var val_28;
            val_26 = 专丄丝丘丆丆下丟世;
            val_27 = this;
            if(val_26 == null)
            {
                goto label_1;
            }
            
            Unity.Notifications.Android.AndroidNotification val_1 = val_26.Notification;
            if(Rilisoft.PushNotifications.PushNotificationReceiver.世丈且业丆丑丏丐一() != false)
            {
                    System.Text.StringBuilder val_3 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  24);
                System.Text.StringBuilder val_16 = val_3.Append(value:  "[PushNotificationReceiver.HandleAndroidNotificationIntentData] caller: "("[PushNotificationReceiver.HandleAndroidNotificationIntentData] caller: ") + 与丗丆丏丙丟与丒业).Append(value:  ", Channel: "(", Channel: ") + val_26.Channel + ", Id: "(", Id: ") + val_26.Id.ToString(provider:  Rilisoft.PushNotifications.PushNotificationReceiver.丙专丝世不业下丂丈())(val_26.Id.ToString(provider:  Rilisoft.PushNotifications.PushNotificationReceiver.丙专丝世不业下丂丈()))).Append(value:  ", Text: "(", Text: ") +).Append(value:  ", IntentData: "(", IntentData: ") + Rest);
                UnityEngine.Debug.Log(message:  PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_3));
            }
            
            val_28 = null;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丅三丆专丞三上丆丗>k__BackingField = Rest;
            val_28 = null;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 0;
            Rilisoft.PushNotifications.下丝丛三与专丄东丐.不下丌丆东丑丈丕丝(一丐丗丁丞丆丅丟丄:  0);
            this.丅上专一丅七丕且丛(一丐丗丁丞丆丅丟丄:  Rest);
            if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                goto label_16;
            }
            
            if(Rilisoft.PushNotifications.PushNotificationReceiver.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationReceiver.HandleAndroidNotificationIntentData] Waiting for PushNotificationHandler available...");
            }
            
            UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  东东丛业一丁专万且());
            return;
            label_1:
            if(Rilisoft.PushNotifications.PushNotificationReceiver.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            val_27 = "[PushNotificationReceiver.HandleAndroidNotificationIntentData] caller: "("[PushNotificationReceiver.HandleAndroidNotificationIntentData] caller: ") + 与丗丆丏丙丟与丒业 + ", intentData: null"(", intentData: null");
            UnityEngine.Debug.Log(message:  val_27);
            return;
            label_16:
            val_27 = Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField;
            if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.三与专与丐丟丗丏一) == true)
            {
                    return;
            }
            
            Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.<丞丕丈一三丏七丒丈>k__BackingField = true;
        }
        private System.Collections.IEnumerator 东东丛业一丁专万且()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new PushNotificationReceiver.且与丘丛丅三丗丈丞();
        }
        private void 专丂丂丘丐丛专丛丘(string 一丐丗丁丞丆丅丟丄)
        {
            System.Object[] val_6;
            var val_7;
            val_6 = 1152921505500082176;
            val_7 = null;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丅三丆专丞三上丆丗>k__BackingField = 一丐丗丁丞丆丅丟丄;
            val_7 = null;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 0;
            Rilisoft.PushNotifications.下丝丛三与专丄东丐.不下丌丆东丑丈丕丝(一丐丗丁丞丆丅丟丄:  0);
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_2 = new object[2];
                val_6 = val_2;
                System.DateTime val_3 = System.DateTime.Now;
                val_6[0] = ;
                val_6[1] = ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  一丐丗丁丞丆丅丟丄)) != true) ? 一丐丗丁丞丆丅丟丄 : "Remote or local notification data is NULL or Empty";
                UnityEngine.Debug.LogFormat(format:  "[PushNotificationReceiver] [OnReceiveAndroidRemoteNotification @{0}] {1}", args:  val_2);
            }
            
            this.丅上专一丅七丕且丛(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
            if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.三与专与丐丟丗丏一) == true)
            {
                    return;
            }
            
            Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.<丞丕丈一三丏七丒丈>k__BackingField = true;
        }
        private void 丄东世七与丌丙丞丕(System.Collections.IDictionary 一丐丗丁丞丆丅丟丄)
        {
            var val_4;
            var val_5;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            val_4 = 1152921504689381376;
            var val_1 = (((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0;
            if((val_1.ContainsKey(key:  "userInfo")) == false)
            {
                    return;
            }
            
            object val_3 = val_1.Item["userInfo"];
            val_5 = 0;
            this.丅丄与丛七丑东丒世(丏丂万业丙专丏丒丒:  null);
        }
        private void 丄丟丌东业东丆丒丞(System.Collections.IDictionary 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
        
        }
        private void 丅上专一丅七丕且丛(string 一丐丗丁丞丆丅丟丄)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  一丐丗丁丞丆丅丟丄 = 一丐丗丁丞丆丅丟丄)) == true)
            {
                    return;
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  一丐丗丁丞丆丅丟丄);
            if(val_2 == null)
            {
                    return;
            }
            
            一丐丗丁丞丆丅丟丄 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        }
        private void 下丘三一上丅丝丂世(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒, string 下上丐丆丝丟丝丒不)
        {
            if(丏丂万业丙专丏丒丒 == null)
            {
                    return;
            }
            
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
            {
                    return;
            }
            
            bool val_2 = 丏丂万业丙专丏丒丒.Remove(key:  下上丐丆丝丟丝丒不);
        }
        private void 丅丄与丛七丑东丒世(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
        {
            var val_1;
            if(丏丂万业丙专丏丒丒 == null)
            {
                    return;
            }
            
            this.下丘三一上丅丝丂世(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "aps");
            val_1 = null;
            Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField = 丏丂万业丙专丏丒丒;
            val_1 = null;
            Rilisoft.PushNotifications.下丝丛三与专丄东丐.不下丌丆东丑丈丕丝(一丐丗丁丞丆丅丟丄:  Rilisoft.PushNotifications.PushNotificationReceiver.<丕三丝丙丝丕且丛丙>k__BackingField);
        }
        public PushNotificationReceiver()
        {
        
        }
    
    }

}
