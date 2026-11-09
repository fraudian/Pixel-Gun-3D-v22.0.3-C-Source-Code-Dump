using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public class NearbyHelperObject : MonoBehaviour
    {
        // Fields
        private static GooglePlayGames.OurUtils.NearbyHelperObject instance;
        private static double mAdvertisingRemaining;
        private static double mDiscoveryRemaining;
        private static GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient mClient;
        
        // Methods
        public static void CreateObject(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client)
        {
            GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = client;
            val_7 = null;
            val_7 = null;
            if(GooglePlayGames.OurUtils.NearbyHelperObject.instance != 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            GooglePlayGames.OurUtils.NearbyHelperObject.mClient = val_6;
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "PlayGames_NearbyHelper");
                UnityEngine.Object.DontDestroyOnLoad(target:  val_3);
                val_6 = val_3.AddComponent<GooglePlayGames.OurUtils.NearbyHelperObject>();
                val_9 = null;
            }
            else
            {
                    GooglePlayGames.OurUtils.NearbyHelperObject val_5 = null;
                val_6 = val_5;
                val_5 = new GooglePlayGames.OurUtils.NearbyHelperObject();
                val_9 = null;
            }
            
            GooglePlayGames.OurUtils.NearbyHelperObject.instance = val_6;
        }
        private static double ToSeconds(System.Nullable<System.TimeSpan> span)
        {
            if(((-1406801040) & 1) == 0)
            {
                    return (double)0;
            }
            
            if(span.HasValue.TotalSeconds < 0)
            {
                    return (double)0;
            }
            
            0 = span.HasValue.TotalSeconds;
            return (double)0;
        }
        public static void StartAdvertisingTimer(System.Nullable<System.TimeSpan> span)
        {
            GooglePlayGames.OurUtils.NearbyHelperObject.mAdvertisingRemaining = GooglePlayGames.OurUtils.NearbyHelperObject.ToSeconds(span:  new System.Nullable<System.TimeSpan>() {HasValue = span.HasValue});
        }
        public static void StartDiscoveryTimer(System.Nullable<System.TimeSpan> span)
        {
            GooglePlayGames.OurUtils.NearbyHelperObject.mDiscoveryRemaining = GooglePlayGames.OurUtils.NearbyHelperObject.ToSeconds(span:  new System.Nullable<System.TimeSpan>() {HasValue = span.HasValue});
        }
        public void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public void OnDisable()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(GooglePlayGames.OurUtils.NearbyHelperObject.instance != this)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            GooglePlayGames.OurUtils.NearbyHelperObject.instance = 0;
        }
        public void Update()
        {
            GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient val_6;
            var val_7;
            double val_8;
            var val_10;
            double val_12;
            val_7 = null;
            val_7 = null;
            val_8 = GooglePlayGames.OurUtils.NearbyHelperObject.mAdvertisingRemaining;
            if(val_8 > 0f)
            {
                    val_8 = GooglePlayGames.OurUtils.NearbyHelperObject.mAdvertisingRemaining;
                val_7 = null;
                double val_7 = (double)UnityEngine.Time.deltaTime;
                val_7 = val_8 - val_7;
                GooglePlayGames.OurUtils.NearbyHelperObject.mAdvertisingRemaining = val_7;
                if(GooglePlayGames.OurUtils.NearbyHelperObject.mAdvertisingRemaining < 0)
            {
                    val_6 = GooglePlayGames.OurUtils.NearbyHelperObject.mClient;
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_10 = 5;
                val_6.StopAdvertising();
                val_7 = null;
            }
            
            }
            
            val_7 = null;
            val_12 = GooglePlayGames.OurUtils.NearbyHelperObject.mDiscoveryRemaining;
            if(val_12 <= 0f)
            {
                    return;
            }
            
            val_12 = GooglePlayGames.OurUtils.NearbyHelperObject.mDiscoveryRemaining;
            double val_9 = (double)UnityEngine.Time.deltaTime;
            val_9 = val_12 - val_9;
            GooglePlayGames.OurUtils.NearbyHelperObject.mDiscoveryRemaining = val_9;
            if(GooglePlayGames.OurUtils.NearbyHelperObject.mDiscoveryRemaining >= 0)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 14;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = 9;
            GooglePlayGames.OurUtils.NearbyHelperObject.mClient.StopDiscovery(serviceId:  GooglePlayGames.OurUtils.NearbyHelperObject.mClient.GetServiceId());
        }
        public NearbyHelperObject()
        {
        
        }
        private static NearbyHelperObject()
        {
        
        }
    
    }

}
