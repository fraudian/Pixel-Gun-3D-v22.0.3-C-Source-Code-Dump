using UnityEngine;

namespace BestHTTP
{
    public sealed class HTTPUpdateDelegator : MonoBehaviour
    {
        // Fields
        private static BestHTTP.HTTPUpdateDelegator <Instance>k__BackingField;
        private static bool <IsCreated>k__BackingField;
        private static bool <IsThreaded>k__BackingField;
        private static bool <IsThreadRunning>k__BackingField;
        private static int <ThreadFrequencyInMS>k__BackingField;
        public static System.Func<bool> OnBeforeApplicationQuit;
        public static System.Action<bool> OnApplicationForegroundStateChanged;
        private static bool IsSetupCalled;
        
        // Properties
        public static BestHTTP.HTTPUpdateDelegator Instance { get; set; }
        public static bool IsCreated { get; set; }
        public static bool IsThreaded { get; set; }
        public static bool IsThreadRunning { get; set; }
        public static int ThreadFrequencyInMS { get; set; }
        
        // Methods
        public static BestHTTP.HTTPUpdateDelegator get_Instance()
        {
            null = null;
            return (BestHTTP.HTTPUpdateDelegator)BestHTTP.HTTPUpdateDelegator.<Instance>k__BackingField;
        }
        private static void set_Instance(BestHTTP.HTTPUpdateDelegator value)
        {
            null = null;
            BestHTTP.HTTPUpdateDelegator.<Instance>k__BackingField = value;
        }
        public static bool get_IsCreated()
        {
            null = null;
            return (bool)BestHTTP.HTTPUpdateDelegator.<IsCreated>k__BackingField;
        }
        private static void set_IsCreated(bool value)
        {
            null = null;
            BestHTTP.HTTPUpdateDelegator.<IsCreated>k__BackingField = value;
        }
        public static bool get_IsThreaded()
        {
            null = null;
            return (bool)BestHTTP.HTTPUpdateDelegator.<IsThreaded>k__BackingField;
        }
        public static void set_IsThreaded(bool value)
        {
            null = null;
            BestHTTP.HTTPUpdateDelegator.<IsThreaded>k__BackingField = value;
        }
        public static bool get_IsThreadRunning()
        {
            null = null;
            return (bool)BestHTTP.HTTPUpdateDelegator.<IsThreadRunning>k__BackingField;
        }
        private static void set_IsThreadRunning(bool value)
        {
            null = null;
            BestHTTP.HTTPUpdateDelegator.<IsThreadRunning>k__BackingField = value;
        }
        public static int get_ThreadFrequencyInMS()
        {
            null = null;
            return (int)BestHTTP.HTTPUpdateDelegator.<ThreadFrequencyInMS>k__BackingField;
        }
        public static void set_ThreadFrequencyInMS(int value)
        {
            null = null;
            BestHTTP.HTTPUpdateDelegator.<ThreadFrequencyInMS>k__BackingField = value;
        }
        private static HTTPUpdateDelegator()
        {
            BestHTTP.HTTPUpdateDelegator.ThreadFrequencyInMS = 100;
        }
        public static void CheckInstance()
        {
            var val_11;
            var val_12 = null;
            if(BestHTTP.HTTPUpdateDelegator.IsCreated == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.GameObject.Find(name:  "HTTP Update Delegator");
            if(val_2 != 0)
            {
                    BestHTTP.HTTPUpdateDelegator.Instance = val_2.GetComponent<BestHTTP.HTTPUpdateDelegator>();
            }
            
            if(BestHTTP.HTTPUpdateDelegator.Instance == 0)
            {
                    new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  "HTTP Update Delegator");
                new UnityEngine.GameObject().hideFlags = 52;
                BestHTTP.HTTPUpdateDelegator.Instance = new UnityEngine.GameObject().AddComponent<BestHTTP.HTTPUpdateDelegator>();
            }
            
            BestHTTP.HTTPUpdateDelegator.IsCreated = true;
            val_11 = BestHTTP.HTTPManager.Logger;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11.Information(division:  "HTTPUpdateDelegator", info:  "Instance Created!");
        }
        private void Setup()
        {
            var val_9;
            var val_10;
            BestHTTP.Caching.HTTPCacheService.SetupCacheFolder();
            BestHTTP.Cookies.CookieJar.SetupFolder();
            BestHTTP.Cookies.CookieJar.Load();
            val_9 = null;
            if(BestHTTP.HTTPUpdateDelegator.IsThreaded != false)
            {
                    bool val_3 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  this, method:  System.Void BestHTTP.HTTPUpdateDelegator::ThreadFunc(object obj)));
            }
            
            val_10 = null;
            val_10 = null;
            BestHTTP.HTTPUpdateDelegator.IsSetupCalled = true;
            if(UnityEngine.Application.isEditor != false)
            {
                    if(UnityEngine.Application.isPlaying == false)
            {
                goto label_11;
            }
            
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            label_11:
            var val_9 = 0;
            val_9 = val_9 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "HTTPUpdateDelegator", info:  "Setup done!");
        }
        private void ThreadFunc(object obj)
        {
            var val_16;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            string val_22;
            val_16 = 1152921505553330176;
            var val_16 = 0;
            val_16 = val_16 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "HTTPUpdateDelegator", info:  "Update Thread Started");
            BestHTTP.HTTPUpdateDelegator.IsThreadRunning = true;
            label_17:
            val_18 = null;
            if(BestHTTP.HTTPUpdateDelegator.IsThreadRunning == false)
            {
                goto label_12;
            }
            
            BestHTTP.HTTPManager.OnUpdate();
            val_19 = null;
            System.Threading.Thread.Sleep(millisecondsTimeout:  BestHTTP.HTTPUpdateDelegator.ThreadFrequencyInMS);
            goto label_17;
            label_12:
            val_20 = 0;
            val_21 = 0;
            val_22 = "HTTPUpdateDelegator";
            var val_17 = 0;
            val_17 = val_17 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  val_22, info:  "Update Thread Ended");
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_21 = ???;
            val_22 = ???;
            val_16 = ???;
        }
        private void Update()
        {
            if(BestHTTP.HTTPUpdateDelegator.IsSetupCalled != true)
            {
                    BestHTTP.HTTPUpdateDelegator.IsSetupCalled = true;
                this.Setup();
                null = null;
            }
            
            if(BestHTTP.HTTPUpdateDelegator.IsThreaded != false)
            {
                    return;
            }
            
            BestHTTP.HTTPManager.OnUpdate();
        }
        private void OnDisable()
        {
            BestHTTP.Logger.ILogger val_1 = BestHTTP.HTTPManager.Logger;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.Information(division:  "HTTPUpdateDelegator", info:  "OnDisable Called!");
            val_1.OnApplicationQuit();
        }
        private void OnApplicationPause(bool isPaused)
        {
            var val_1;
            System.Action<System.Boolean> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            isPaused = isPaused;
            val_2.Invoke(obj:  isPaused);
        }
        private void OnApplicationQuit()
        {
            var val_7;
            string val_8;
            var val_10;
            System.Func<System.Boolean> val_11;
            val_7 = BestHTTP.HTTPManager.Logger;
            val_8 = "OnApplicationQuit Called!";
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7.Information(division:  "HTTPUpdateDelegator", info:  val_8);
            val_10 = null;
            val_10 = null;
            val_11 = BestHTTP.HTTPUpdateDelegator.OnBeforeApplicationQuit;
            if(val_11 == null)
            {
                goto label_10;
            }
            
            val_11 = BestHTTP.HTTPUpdateDelegator.OnBeforeApplicationQuit;
            if(val_11 == null)
            {
                    val_11 = 0;
            }
            
            if(val_11.Invoke() == false)
            {
                goto label_14;
            }
            
            label_10:
            BestHTTP.HTTPUpdateDelegator.IsThreadRunning = false;
            if(BestHTTP.HTTPUpdateDelegator.IsCreated == false)
            {
                    return;
            }
            
            BestHTTP.HTTPUpdateDelegator.IsCreated = false;
            BestHTTP.HTTPManager.OnQuit();
            return;
            label_14:
            val_7 = BestHTTP.HTTPManager.Logger;
            val_8 = "OnBeforeApplicationQuit call returned false, postponing plugin shutdown.";
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_7.Information(division:  "HTTPUpdateDelegator", info:  val_8);
        }
        public HTTPUpdateDelegator()
        {
        
        }
    
    }

}
