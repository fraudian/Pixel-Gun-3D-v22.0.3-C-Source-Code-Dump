using UnityEngine;

namespace BestHTTP
{
    public static class HTTPManager
    {
        // Fields
        private static byte maxConnectionPerServer;
        private static bool <KeepAliveDefaultValue>k__BackingField;
        private static bool <IsCachingDisabled>k__BackingField;
        private static System.TimeSpan <MaxConnectionIdleTime>k__BackingField;
        private static bool <IsCookiesEnabled>k__BackingField;
        private static uint <CookieJarSize>k__BackingField;
        private static bool <EnablePrivateBrowsing>k__BackingField;
        private static System.TimeSpan <ConnectTimeout>k__BackingField;
        private static System.TimeSpan <RequestTimeout>k__BackingField;
        private static System.Func<string> <RootCacheFolderProvider>k__BackingField;
        private static BestHTTP.HTTPProxy <Proxy>k__BackingField;
        private static BestHTTP.Extensions.HeartbeatManager heartbeats;
        private static BestHTTP.Logger.ILogger logger;
        private static Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer <DefaultCertificateVerifyer>k__BackingField;
        private static Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider <DefaultClientCredentialsProvider>k__BackingField;
        private static bool <UseAlternateSSLDefaultValue>k__BackingField;
        private static System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> <DefaultCertificationValidator>k__BackingField;
        public static bool TryToMinimizeTCPLatency;
        public static int SendBufferSize;
        public static int ReceiveBufferSize;
        private static int <MaxPathLength>k__BackingField;
        private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BestHTTP.ConnectionBase>> Connections;
        private static System.Collections.Generic.List<BestHTTP.ConnectionBase> ActiveConnections;
        private static System.Collections.Generic.List<BestHTTP.ConnectionBase> FreeConnections;
        private static System.Collections.Generic.List<BestHTTP.ConnectionBase> RecycledConnections;
        private static System.Collections.Generic.List<BestHTTP.HTTPRequest> RequestQueue;
        private static bool IsCallingCallbacks;
        internal static object Locker;
        private static bool <IsQuitting>k__BackingField;
        
        // Properties
        public static byte MaxConnectionPerServer { get; set; }
        public static bool KeepAliveDefaultValue { get; set; }
        public static bool IsCachingDisabled { get; set; }
        public static System.TimeSpan MaxConnectionIdleTime { get; set; }
        public static bool IsCookiesEnabled { get; set; }
        public static uint CookieJarSize { get; set; }
        public static bool EnablePrivateBrowsing { get; set; }
        public static System.TimeSpan ConnectTimeout { get; set; }
        public static System.TimeSpan RequestTimeout { get; set; }
        public static System.Func<string> RootCacheFolderProvider { get; set; }
        public static BestHTTP.HTTPProxy Proxy { get; set; }
        public static BestHTTP.Extensions.HeartbeatManager Heartbeats { get; }
        public static BestHTTP.Logger.ILogger Logger { get; set; }
        public static Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer DefaultCertificateVerifyer { get; set; }
        public static Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider DefaultClientCredentialsProvider { get; set; }
        public static bool UseAlternateSSLDefaultValue { get; set; }
        public static System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> DefaultCertificationValidator { get; set; }
        internal static int MaxPathLength { get; set; }
        internal static bool IsQuitting { get; set; }
        
        // Methods
        private static HTTPManager()
        {
            BestHTTP.HTTPManager.TryToMinimizeTCPLatency = false;
            BestHTTP.HTTPManager.SendBufferSize = 66560;
            BestHTTP.HTTPManager.ReceiveBufferSize = 66560;
            BestHTTP.HTTPManager.Connections = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BestHTTP.ConnectionBase>>();
            BestHTTP.HTTPManager.ActiveConnections = new System.Collections.Generic.List<BestHTTP.ConnectionBase>();
            BestHTTP.HTTPManager.FreeConnections = new System.Collections.Generic.List<BestHTTP.ConnectionBase>();
            BestHTTP.HTTPManager.RecycledConnections = new System.Collections.Generic.List<BestHTTP.ConnectionBase>();
            BestHTTP.HTTPManager.RequestQueue = new System.Collections.Generic.List<BestHTTP.HTTPRequest>();
            BestHTTP.HTTPManager.Locker = new System.Object();
            BestHTTP.HTTPManager.MaxConnectionPerServer = 4;
            BestHTTP.HTTPManager.KeepAliveDefaultValue = true;
            BestHTTP.HTTPManager.MaxPathLength = 255;
            System.TimeSpan val_7 = System.TimeSpan.FromSeconds(value:  20);
            BestHTTP.HTTPManager.MaxConnectionIdleTime = new System.TimeSpan() {_ticks = val_7._ticks};
            BestHTTP.HTTPManager.IsCookiesEnabled = true;
            BestHTTP.HTTPManager.CookieJarSize = 0;
            BestHTTP.HTTPManager.EnablePrivateBrowsing = false;
            System.TimeSpan val_8 = System.TimeSpan.FromSeconds(value:  20);
            BestHTTP.HTTPManager.ConnectTimeout = new System.TimeSpan() {_ticks = val_8._ticks};
            System.TimeSpan val_9 = System.TimeSpan.FromSeconds(value:  60);
            BestHTTP.HTTPManager.RequestTimeout = new System.TimeSpan() {_ticks = val_9._ticks};
            BestHTTP.HTTPManager.logger = new BestHTTP.Logger.DefaultLogger();
            BestHTTP.HTTPManager.DefaultCertificateVerifyer = 0;
            BestHTTP.HTTPManager.UseAlternateSSLDefaultValue = true;
        }
        public static byte get_MaxConnectionPerServer()
        {
            null = null;
            return (byte)BestHTTP.HTTPManager.maxConnectionPerServer;
        }
        public static void set_MaxConnectionPerServer(byte value)
        {
            var val_3;
            if((value & 255) != 0)
            {
                    val_3 = null;
                val_3 = null;
                BestHTTP.HTTPManager.maxConnectionPerServer = value;
                return;
            }
            
            System.ArgumentOutOfRangeException val_2 = new System.ArgumentOutOfRangeException(paramName:  "MaxConnectionPerServer must be greater than 0!");
        }
        public static bool get_KeepAliveDefaultValue()
        {
            null = null;
            return (bool)BestHTTP.HTTPManager.<KeepAliveDefaultValue>k__BackingField;
        }
        public static void set_KeepAliveDefaultValue(bool value)
        {
            null = null;
            BestHTTP.HTTPManager.<KeepAliveDefaultValue>k__BackingField = value;
        }
        public static bool get_IsCachingDisabled()
        {
            null = null;
            return (bool)BestHTTP.HTTPManager.<IsCachingDisabled>k__BackingField;
        }
        public static void set_IsCachingDisabled(bool value)
        {
            null = null;
            BestHTTP.HTTPManager.<IsCachingDisabled>k__BackingField = value;
        }
        public static System.TimeSpan get_MaxConnectionIdleTime()
        {
            null = null;
            return (System.TimeSpan)BestHTTP.HTTPManager.<MaxConnectionIdleTime>k__BackingField;
        }
        public static void set_MaxConnectionIdleTime(System.TimeSpan value)
        {
            null = null;
            BestHTTP.HTTPManager.<MaxConnectionIdleTime>k__BackingField = value._ticks;
        }
        public static bool get_IsCookiesEnabled()
        {
            null = null;
            return (bool)BestHTTP.HTTPManager.<IsCookiesEnabled>k__BackingField;
        }
        public static void set_IsCookiesEnabled(bool value)
        {
            null = null;
            BestHTTP.HTTPManager.<IsCookiesEnabled>k__BackingField = value;
        }
        public static uint get_CookieJarSize()
        {
            null = null;
            return (uint)BestHTTP.HTTPManager.<CookieJarSize>k__BackingField;
        }
        public static void set_CookieJarSize(uint value)
        {
            null = null;
            BestHTTP.HTTPManager.<CookieJarSize>k__BackingField = value;
        }
        public static bool get_EnablePrivateBrowsing()
        {
            null = null;
            return (bool)BestHTTP.HTTPManager.<EnablePrivateBrowsing>k__BackingField;
        }
        public static void set_EnablePrivateBrowsing(bool value)
        {
            null = null;
            BestHTTP.HTTPManager.<EnablePrivateBrowsing>k__BackingField = value;
        }
        public static System.TimeSpan get_ConnectTimeout()
        {
            null = null;
            return (System.TimeSpan)BestHTTP.HTTPManager.<ConnectTimeout>k__BackingField;
        }
        public static void set_ConnectTimeout(System.TimeSpan value)
        {
            null = null;
            BestHTTP.HTTPManager.<ConnectTimeout>k__BackingField = value._ticks;
        }
        public static System.TimeSpan get_RequestTimeout()
        {
            null = null;
            return (System.TimeSpan)BestHTTP.HTTPManager.<RequestTimeout>k__BackingField;
        }
        public static void set_RequestTimeout(System.TimeSpan value)
        {
            null = null;
            BestHTTP.HTTPManager.<RequestTimeout>k__BackingField = value._ticks;
        }
        public static System.Func<string> get_RootCacheFolderProvider()
        {
            null = null;
            return (System.Func<System.String>)BestHTTP.HTTPManager.<RootCacheFolderProvider>k__BackingField;
        }
        public static void set_RootCacheFolderProvider(System.Func<string> value)
        {
            null = null;
            BestHTTP.HTTPManager.<RootCacheFolderProvider>k__BackingField = value;
        }
        public static BestHTTP.HTTPProxy get_Proxy()
        {
            null = null;
            return (BestHTTP.HTTPProxy)BestHTTP.HTTPManager.<Proxy>k__BackingField;
        }
        public static void set_Proxy(BestHTTP.HTTPProxy value)
        {
            null = null;
            BestHTTP.HTTPManager.<Proxy>k__BackingField = value;
        }
        public static BestHTTP.Extensions.HeartbeatManager get_Heartbeats()
        {
            BestHTTP.Extensions.HeartbeatManager val_2;
            var val_3 = null;
            if(BestHTTP.HTTPManager.heartbeats == null)
            {
                    BestHTTP.Extensions.HeartbeatManager val_1 = null;
                val_2 = val_1;
                val_1 = new BestHTTP.Extensions.HeartbeatManager();
                val_3 = null;
                val_3 = null;
                BestHTTP.HTTPManager.heartbeats = val_2;
            }
            
            val_3 = null;
            return (BestHTTP.Extensions.HeartbeatManager)BestHTTP.HTTPManager.heartbeats;
        }
        public static BestHTTP.Logger.ILogger get_Logger()
        {
            BestHTTP.Logger.DefaultLogger val_4;
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(BestHTTP.HTTPManager.logger != null)
            {
                goto label_3;
            }
            
            BestHTTP.Logger.DefaultLogger val_1 = new BestHTTP.Logger.DefaultLogger();
            val_6 = null;
            val_6 = null;
            BestHTTP.HTTPManager.logger = val_1;
            val_4 = BestHTTP.HTTPManager.logger;
            BestHTTP.Logger.DefaultLogger val_5 = val_1;
            if(X9 == 0)
            {
                goto label_10;
            }
            
            var val_3 = 0;
            var val_2 = X11 + 8;
            label_9:
            if(((X11 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < X9)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            var val_4 = val_2;
            val_4 = val_4 + 1;
            val_5 = val_5 + val_4;
            val_7 = val_5 + 296;
            label_10:
            val_1.Level = 5;
            val_5 = null;
            label_3:
            val_5 = null;
            return (BestHTTP.Logger.ILogger)BestHTTP.HTTPManager.logger;
        }
        public static void set_Logger(BestHTTP.Logger.ILogger value)
        {
            null = null;
            BestHTTP.HTTPManager.logger = value;
        }
        public static Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer get_DefaultCertificateVerifyer()
        {
            null = null;
            return (Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer)BestHTTP.HTTPManager.<DefaultCertificateVerifyer>k__BackingField;
        }
        public static void set_DefaultCertificateVerifyer(Org.BouncyCastle.Crypto.Tls.ICertificateVerifyer value)
        {
            null = null;
            BestHTTP.HTTPManager.<DefaultCertificateVerifyer>k__BackingField = value;
        }
        public static Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider get_DefaultClientCredentialsProvider()
        {
            null = null;
            return (Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider)BestHTTP.HTTPManager.<DefaultClientCredentialsProvider>k__BackingField;
        }
        public static void set_DefaultClientCredentialsProvider(Org.BouncyCastle.Crypto.Tls.IClientCredentialsProvider value)
        {
            null = null;
            BestHTTP.HTTPManager.<DefaultClientCredentialsProvider>k__BackingField = value;
        }
        public static bool get_UseAlternateSSLDefaultValue()
        {
            null = null;
            return (bool)BestHTTP.HTTPManager.<UseAlternateSSLDefaultValue>k__BackingField;
        }
        public static void set_UseAlternateSSLDefaultValue(bool value)
        {
            null = null;
            BestHTTP.HTTPManager.<UseAlternateSSLDefaultValue>k__BackingField = value;
        }
        public static System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> get_DefaultCertificationValidator()
        {
            null = null;
            return (System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, System.Boolean>)BestHTTP.HTTPManager.<DefaultCertificationValidator>k__BackingField;
        }
        public static void set_DefaultCertificationValidator(System.Func<BestHTTP.HTTPRequest, System.Security.Cryptography.X509Certificates.X509Certificate, System.Security.Cryptography.X509Certificates.X509Chain, bool> value)
        {
            null = null;
            BestHTTP.HTTPManager.<DefaultCertificationValidator>k__BackingField = value;
        }
        internal static int get_MaxPathLength()
        {
            null = null;
            return (int)BestHTTP.HTTPManager.<MaxPathLength>k__BackingField;
        }
        internal static void set_MaxPathLength(int value)
        {
            null = null;
            BestHTTP.HTTPManager.<MaxPathLength>k__BackingField = value;
        }
        internal static bool get_IsQuitting()
        {
            null = null;
            return (bool)BestHTTP.HTTPManager.<IsQuitting>k__BackingField;
        }
        private static void set_IsQuitting(bool value)
        {
            null = null;
            BestHTTP.HTTPManager.<IsQuitting>k__BackingField = value;
        }
        public static void Setup()
        {
            BestHTTP.HTTPUpdateDelegator.CheckInstance();
            BestHTTP.Caching.HTTPCacheService.CheckSetup();
            BestHTTP.Cookies.CookieJar.SetupFolder();
        }
        public static BestHTTP.HTTPRequest SendRequest(string url, BestHTTP.OnRequestFinishedDelegate callback)
        {
            return BestHTTP.HTTPManager.SendRequest(request:  new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  url), methodType:  0, callback:  callback));
        }
        public static BestHTTP.HTTPRequest SendRequest(string url, BestHTTP.HTTPMethods methodType, BestHTTP.OnRequestFinishedDelegate callback)
        {
            return BestHTTP.HTTPManager.SendRequest(request:  new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  url), methodType:  methodType, callback:  callback));
        }
        public static BestHTTP.HTTPRequest SendRequest(string url, BestHTTP.HTTPMethods methodType, bool isKeepAlive, BestHTTP.OnRequestFinishedDelegate callback)
        {
            return BestHTTP.HTTPManager.SendRequest(request:  new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  url), methodType:  methodType, isKeepAlive:  isKeepAlive, callback:  callback));
        }
        public static BestHTTP.HTTPRequest SendRequest(string url, BestHTTP.HTTPMethods methodType, bool isKeepAlive, bool disableCache, BestHTTP.OnRequestFinishedDelegate callback)
        {
            return BestHTTP.HTTPManager.SendRequest(request:  new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  url), methodType:  methodType, isKeepAlive:  isKeepAlive, disableCache:  disableCache, callback:  callback));
        }
        public static BestHTTP.HTTPRequest SendRequest(BestHTTP.HTTPRequest request)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.HTTPManager.Locker, lockTaken: ref  val_1);
            BestHTTP.HTTPManager.Setup();
            val_3 = null;
            if(BestHTTP.HTTPManager.IsCallingCallbacks != false)
            {
                    if(request == null)
            {
                    val_3 = null;
            }
            
                request.<State>k__BackingField = 1;
                val_3 = null;
                BestHTTP.HTTPManager.RequestQueue.Add(item:  request);
            }
            else
            {
                    BestHTTP.HTTPManager.SendRequestImpl(request:  request);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.Locker);
            }
            
            if(0 != 1)
            {
                    return (BestHTTP.HTTPRequest)request;
            }
            
            if(0 == 0)
            {
                    return (BestHTTP.HTTPRequest)request;
            }
            
            return (BestHTTP.HTTPRequest)request;
        }
        public static BestHTTP.Statistics.GeneralStatistics GetGeneralStatistics(BestHTTP.Statistics.StatisticsQueryFlags queryFlags)
        {
            var val_4;
            BestHTTP.Statistics.StatisticsQueryFlags val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            var val_26;
            var val_27;
            ulong val_28;
            int val_29;
            int val_30;
            var val_31;
            uint val_32;
            var val_33;
            int val_34;
            BestHTTP.Statistics.GeneralStatistics val_0;
            val_20 = queryFlags;
            val_21 = 0;
            val_22 = 0;
            val_23 = 0;
            val_24 = 0;
            val_25 = 0;
            if((val_20 & 1) == 0)
            {
                goto label_1;
            }
            
            val_26 = null;
            val_26 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = BestHTTP.HTTPManager.Connections.GetEnumerator();
            val_25 = 0;
            goto label_6;
            label_8:
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(val_5._value._obj != 0)
            {
                    val_25 = val_5._value._obj.Count + val_25;
            }
            
            label_6:
            if((1768136608 & 1) != 0)
            {
                goto label_8;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_27 = null;
            val_27 = null;
            val_24 = BestHTTP.HTTPManager.ActiveConnections.Count;
            val_22 = BestHTTP.HTTPManager.RecycledConnections.Count;
            val_21 = BestHTTP.HTTPManager.RequestQueue;
            int val_10 = val_21.Count;
            val_23 = BestHTTP.HTTPManager.FreeConnections.Count;
            label_1:
            BestHTTP.Statistics.StatisticsQueryFlags val_11 = val_20 & 255;
            if((val_11 & 2) != 0)
            {
                goto label_21;
            }
            
            val_28 = 0;
            val_29 = 0;
            if((val_11 & 4) == 0)
            {
                goto label_22;
            }
            
            label_34:
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_12 = BestHTTP.Cookies.CookieJar.GetAll();
            val_30 = val_12.Count;
            val_31 = 0;
            val_32 = 0;
            goto label_26;
            label_30:
            val_33 = val_12.Item[0];
            val_32 = val_33.GuessSize() + val_32;
            val_31 = 1;
            label_26:
            if(val_31 < val_12.Count)
            {
                goto label_30;
            }
            
            val_24 = val_24;
            val_20 = val_20;
            val_22 = val_22;
            val_34 = val_23;
            val_21 = val_10;
            goto label_31;
            label_21:
            val_29 = BestHTTP.Caching.HTTPCacheService.GetCacheEntityCount();
            val_28 = BestHTTP.Caching.HTTPCacheService.GetCacheSize();
            val_21 = val_10;
            if((val_11 & 4) != 0)
            {
                goto label_34;
            }
            
            label_22:
            val_30 = 0;
            val_32 = 0;
            label_31:
            val_0.QueryFlags = val_20;
            val_0.ActiveConnections = val_23;
            val_0.FreeConnections = val_22;
            val_0.RecycledConnections = val_21;
            val_0.RequestsInQueue = val_29;
            mem[1152921553619672084] = val_25;
            val_0.Connections = val_24;
            val_0.CacheEntityCount = 0;
            val_0.CacheSize = val_28;
            mem[1152921553619672083] = 0;
            mem[1152921553619672081] = 0;
            val_0.CookieCount = val_30;
            val_0.CookieJarSize = val_32;
            return val_0;
        }
        private static void SendRequestImpl(BestHTTP.HTTPRequest request)
        {
            BestHTTP.ConnectionBase val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            HTTPManager.<>c__DisplayClass93_0 val_1 = new HTTPManager.<>c__DisplayClass93_0();
            val_7 = BestHTTP.HTTPManager.FindOrCreateFreeConnection(request:  request);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_8 = val_1;
            .conn = val_7;
            if(val_7 == null)
            {
                goto label_4;
            }
            
            label_19:
            val_9 = null;
            val_9 = null;
            if((BestHTTP.HTTPManager.ActiveConnections.Find(match:  new System.Predicate<BestHTTP.ConnectionBase>(object:  val_1, method:  System.Boolean HTTPManager.<>c__DisplayClass93_0::<SendRequestImpl>b__0(BestHTTP.ConnectionBase c)))) == null)
            {
                    val_10 = null;
                val_10 = null;
                BestHTTP.HTTPManager.ActiveConnections.Add(item:  .conn);
            }
            
            val_11 = null;
            val_11 = null;
            bool val_5 = BestHTTP.HTTPManager.FreeConnections.Remove(item:  .conn);
            if(request == null)
            {
                goto label_17;
            }
            
            request.<State>k__BackingField = 2;
            goto label_18;
            label_3:
            val_8 = 16;
            mem[16] = val_7;
            val_7 = mem[16];
            if(val_7 != 0)
            {
                goto label_19;
            }
            
            label_4:
            request.<State>k__BackingField = 1;
            val_12 = null;
            val_12 = null;
            BestHTTP.HTTPManager.RequestQueue.Add(item:  request);
            return;
            label_17:
            mem[180] = 2;
            label_18:
            if((request.<FormUsage>k__BackingField) == 4)
            {
                    BestHTTP.Forms.HTTPFormBase val_6 = request.SelectFormImplementation();
            }
            
            .conn.Process(request:  request);
        }
        private static string GetKeyForRequest(BestHTTP.HTTPRequest request)
        {
            var val_26;
            System.Uri val_27;
            System.Uri val_28;
            int val_29;
            val_26 = request;
            val_27 = request.<RedirectUri>k__BackingField;
            val_28 = request.<Uri>k__BackingField;
            if((((request.<IsRedirected>k__BackingField) == false) ? (val_28) : (val_27).IsFile) != false)
            {
                    var val_3 = ((request.<IsRedirected>k__BackingField) == false) ? (val_28) : (val_27);
                val_26 = ???;
                val_27 = ???;
                val_28 = ???;
            }
            else
            {
                    if((val_26 + 152) != 0)
            {
                    val_29 = new System.UriBuilder(scheme:  val_26 + 152 + 16.Scheme, host:  val_26 + 152 + 16.Host, portNumber:  val_26 + 152 + 16.Port).Uri;
            }
            else
            {
                    val_29 = System.String.alignConst;
            }
            
                System.Uri val_16 = new System.UriBuilder(scheme:  ((val_26 + 97) == 0) ? (val_28) : (val_27).Scheme, host:  ((val_26 + 97) == 0) ? (val_28) : (val_27).Host, portNumber:  ((val_26 + 97) == 0) ? (val_28) : (val_27).Port).Uri;
                if(val_16 != null)
            {
                    return val_29 + val_16;
            }
            
                return val_29 + val_16;
            }
        
        }
        private static BestHTTP.ConnectionBase CreateConnection(BestHTTP.HTTPRequest request, string serverUrl)
        {
            var val_5;
            if((((request.<IsRedirected>k__BackingField) == false) ? request.<Uri>k__BackingField : request.<RedirectUri>k__BackingField.IsFile) != false)
            {
                    if(UnityEngine.Application.platform != 17)
            {
                goto label_4;
            }
            
            }
            
            val_5 = 1152921505553223680;
            return (BestHTTP.ConnectionBase)new BestHTTP.FileConnection(serverAddress:  serverUrl);
            label_4:
            val_5 = 1152921505553063936;
            return (BestHTTP.ConnectionBase)new BestHTTP.FileConnection(serverAddress:  serverUrl);
        }
        private static BestHTTP.ConnectionBase FindOrCreateFreeConnection(BestHTTP.HTTPRequest request)
        {
            var val_26;
            var val_27;
            var val_28;
            System.Collections.Generic.List<T> val_29;
            BestHTTP.ConnectionBase val_30;
            var val_31;
            var val_32;
            string val_1 = BestHTTP.HTTPManager.GetKeyForRequest(request:  request);
            if((BestHTTP.HTTPManager.Connections.TryGetValue(key:  val_1, value: out  0)) == false)
            {
                goto label_4;
            }
            
            val_26 = 0;
            val_27 = 0;
            goto label_5;
            label_9:
            val_27 = val_27 + val_2.Item[0].IsActive;
            val_26 = 1;
            label_5:
            if(val_26 < val_2.Count)
            {
                goto label_9;
            }
            
            val_28 = null;
            if(val_27 > BestHTTP.HTTPManager.MaxConnectionPerServer)
            {
                goto label_31;
            }
            
            val_29 = 0;
            val_30 = 0;
            goto label_13;
            label_29:
            BestHTTP.ConnectionBase val_9 = val_2.Item[0];
            if(val_9 == null)
            {
                goto label_15;
            }
            
            val_30 = 0;
            if(val_9.IsFree == false)
            {
                goto label_26;
            }
            
            if((val_9.HasProxy == false) || ((System.Uri.op_Equality(uri1:  val_9.LastProcessedUri, uri2:  0)) == true))
            {
                goto label_20;
            }
            
            val_30 = 0;
            if((val_9.LastProcessedUri.Host.Equals(value:  ((request.<IsRedirected>k__BackingField) == false) ? request.<Uri>k__BackingField : request.<RedirectUri>k__BackingField.Host, comparisonType:  5)) == false)
            {
                goto label_26;
            }
            
            label_20:
            val_30 = val_9;
            goto label_26;
            label_15:
            val_30 = 0;
            label_26:
            val_29 = 1;
            label_13:
            if(val_30 == 0)
            {
                    if(val_29 < val_2.Count)
            {
                goto label_29;
            }
            
            }
            
            if(val_30 != 0)
            {
                    return (BestHTTP.ConnectionBase)val_30;
            }
            
            goto label_31;
            label_4:
            val_31 = null;
            val_31 = null;
            System.Collections.Generic.List<BestHTTP.ConnectionBase> val_22 = new System.Collections.Generic.List<BestHTTP.ConnectionBase>(capacity:  BestHTTP.HTTPManager.MaxConnectionPerServer & 255);
            BestHTTP.HTTPManager.Connections.Add(key:  val_1, value:  val_22);
            label_31:
            val_32 = val_22;
            val_29 = val_22.Count;
            if(val_29 < BestHTTP.HTTPManager.MaxConnectionPerServer)
            {
                    val_29 = val_22;
                val_30 = BestHTTP.HTTPManager.CreateConnection(request:  request, serverUrl:  val_1);
                val_22.Add(item:  val_30);
                return (BestHTTP.ConnectionBase)val_30;
            }
            
            val_30 = 0;
            return (BestHTTP.ConnectionBase)val_30;
        }
        private static bool CanProcessFromQueue()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = 0;
            label_8:
            val_5 = null;
            val_5 = null;
            if(val_4 >= BestHTTP.HTTPManager.RequestQueue.Count)
            {
                goto label_4;
            }
            
            val_6 = null;
            val_6 = null;
            val_4 = val_4 + 1;
            if((BestHTTP.HTTPManager.FindOrCreateFreeConnection(request:  BestHTTP.HTTPManager.RequestQueue.Item[0])) == null)
            {
                goto label_8;
            }
            
            val_7 = 1;
            return (bool)val_7;
            label_4:
            val_7 = 0;
            return (bool)val_7;
        }
        private static void RecycleConnection(BestHTTP.ConnectionBase conn)
        {
            mem[1152921553620646096] = 0;
            mem[1152921553620646104] = static System.Void BestHTTP.HTTPManager::OnConnectionRecylced(BestHTTP.ConnectionBase conn);
            mem[1152921553620646080] = static System.Void BestHTTP.HTTPManager::OnConnectionRecylced(BestHTTP.ConnectionBase conn);
            conn.Recycle(onConnectionRecycled:  new BestHTTP.HTTPConnectionRecycledDelegate());
        }
        private static void OnConnectionRecylced(BestHTTP.ConnectionBase conn)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.HTTPManager.RecycledConnections, lockTaken: ref  val_1);
            val_3 = null;
            val_3 = null;
            BestHTTP.HTTPManager.RecycledConnections.Add(item:  conn);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.RecycledConnections);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        internal static BestHTTP.ConnectionBase GetConnectionWith(BestHTTP.HTTPRequest request)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = null;
            val_5 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.HTTPManager.Locker, lockTaken: ref  val_1);
            var val_5 = 0;
            label_11:
            val_6 = null;
            val_6 = null;
            if(val_5 >= BestHTTP.HTTPManager.ActiveConnections.Count)
            {
                goto label_6;
            }
            
            val_7 = null;
            val_7 = null;
            val_8 = BestHTTP.HTTPManager.ActiveConnections.Item[0];
            val_5 = val_5 + 1;
            if(val_8.CurrentRequest != request)
            {
                goto label_11;
            }
            
            val_9 = 0;
            val_10 = 0;
            goto label_13;
            label_6:
            val_9 = 0;
            val_10 = 0;
            val_8 = 0;
            label_13:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.Locker);
            }
            
            if( != 1)
            {
                    if( == 0)
            {
                    return (BestHTTP.ConnectionBase);
            }
            
                if(78 == 78)
            {
                    return (BestHTTP.ConnectionBase);
            }
            
                return (BestHTTP.ConnectionBase);
            }
            
            if( != 0)
            {
                    return (BestHTTP.ConnectionBase);
            }
            
            return (BestHTTP.ConnectionBase);
        }
        internal static bool RemoveFromQueue(BestHTTP.HTTPRequest request)
        {
            null = null;
            if(BestHTTP.HTTPManager.RequestQueue != null)
            {
                    return BestHTTP.HTTPManager.RequestQueue.Remove(item:  request);
            }
            
            return BestHTTP.HTTPManager.RequestQueue.Remove(item:  request);
        }
        internal static string GetRootCacheFolder()
        {
            string val_13 = 1152921505553330176;
            if(BestHTTP.HTTPManager.RootCacheFolderProvider == null)
            {
                    return UnityEngine.Application.persistentDataPath;
            }
            
            return (string)BestHTTP.HTTPManager.RootCacheFolderProvider.Invoke();
        }
        public static void OnUpdate()
        {
            BestHTTP.HTTPManager val_62;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_76;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            string val_82;
            var val_83;
            var val_84;
            var val_85;
            System.Collections.Generic.List<BestHTTP.ConnectionBase> val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            System.Func<BestHTTP.HTTPRequest, System.Boolean> val_102;
            var val_103;
            var val_104;
            System.Predicate<BestHTTP.HTTPRequest> val_106;
            var val_107;
            var val_108;
            System.Comparison<BestHTTP.HTTPRequest> val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            BestHTTP.Extensions.HeartbeatManager val_115;
            val_64 = null;
            val_64 = null;
            if((System.Threading.Monitor.TryEnter(obj:  BestHTTP.HTTPManager.Locker)) == false)
            {
                goto label_378;
            }
            
            val_65 = null;
            val_65 = null;
            val_66 = 1152921504833470464;
            var val_70 = 0;
            BestHTTP.HTTPManager.IsCallingCallbacks = true;
            label_125:
            val_65 = null;
            if(val_70 >= BestHTTP.HTTPManager.ActiveConnections.Count)
            {
                goto label_9;
            }
            
            val_67 = null;
            val_67 = null;
            BestHTTP.ConnectionBase val_3 = BestHTTP.HTTPManager.ActiveConnections.Item[0];
            if(val_3 == null)
            {
                    UnityEngine.Debug.LogWarning(message:  "conn == null");
            }
            
            if((val_3.State - 1) > 8)
            {
                goto label_168;
            }
            
            var val_64 = 106047392 + ((val_4 - 1)) << 2;
            val_64 = val_64 + 106047392;
            goto (106047392 + ((val_4 - 1)) << 2 + 106047392);
            label_168:
            val_70 = val_70 + 1;
            goto label_125;
            label_9:
            val_76 = 0;
            val_62 = 0;
            val_78 = null;
            val_78 = null;
            BestHTTP.HTTPManager.IsCallingCallbacks = false;
            if(( != 1) && (635 == 635))
            {
                    val_76 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_78 = null;
                val_62 = 0;
            }
            
            }
            
            val_78 = null;
            if((System.Threading.Monitor.TryEnter(obj:  BestHTTP.HTTPManager.RecycledConnections)) == false)
            {
                goto label_272;
            }
            
            val_80 = null;
            val_80 = null;
            val_81 = val_66;
            if(BestHTTP.HTTPManager.RecycledConnections.Count < 1)
            {
                goto label_233;
            }
            
            val_82;
            val_83 = 0;
            goto label_234;
            label_249:
            BestHTTP.ConnectionBase val_45 = BestHTTP.HTTPManager.RecycledConnections.Item[0];
            if(val_45 == null)
            {
                    UnityEngine.Debug.LogWarning(message:  "RecycledConnections connection == null");
            }
            
            if(val_45.IsFree != false)
            {
                    val_84 = null;
                val_84 = null;
                bool val_47 = BestHTTP.HTTPManager.ActiveConnections.Remove(item:  val_45);
                BestHTTP.HTTPManager.FreeConnections.Add(item:  val_45);
            }
            
            val_83 = 1;
            label_234:
            val_85 = null;
            val_85 = null;
            val_86 = BestHTTP.HTTPManager.RecycledConnections;
            val_87 = null;
            if(val_83 < val_86.Count)
            {
                goto label_249;
            }
            
            val_88 = val_82;
            val_87 = null;
            BestHTTP.HTTPManager.RecycledConnections.Clear();
            label_233:
            val_76 = 0 + 1;
            mem2[0] = 770;
            val_66 = val_81;
            val_89 = null;
            val_89 = null;
            System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.RecycledConnections);
            if((val_76 != 1) && ((val_63 + ((0 + 1)) << 2) == 770))
            {
                    var val_73 = 0;
                val_73 = val_73 ^ (val_76 >> 31);
                val_76 = val_76 + val_73;
            }
            else
            {
                    if(null != 0)
            {
                    val_62 = 0;
            }
            
            }
            
            label_272:
            val_90 = null;
            val_90 = null;
            if(BestHTTP.HTTPManager.FreeConnections.Count < 1)
            {
                goto label_276;
            }
            
            val_81 = 1152921553620257520;
            val_91 = 0;
            goto label_277;
            label_296:
            val_92 = null;
            val_92 = null;
            val_93 = val_91;
            BestHTTP.ConnectionBase val_50 = BestHTTP.HTTPManager.FreeConnections.Item[0];
            if(val_50 == null)
            {
                    val_93 = 0;
                UnityEngine.Debug.LogWarning(message:  "FreeConnections connection == null");
            }
            
            if((val_50 & 1) != 0)
            {
                    val_94 = null;
                val_94 = null;
                val_82 = val_50.ServerAddress;
                if((BestHTTP.HTTPManager.Connections.TryGetValue(key:  val_82, value: out  0)) != false)
            {
                    bool val_54 = val_52.Remove(item:  val_50);
            }
            
                val_50.Dispose();
                val_95 = null;
                val_95 = null;
                BestHTTP.HTTPManager.FreeConnections.RemoveAt(index:  0);
            }
            
            val_91 = 0;
            label_277:
            val_96 = null;
            val_96 = null;
            val_86 = BestHTTP.HTTPManager.FreeConnections;
            if(val_91 < val_86.Count)
            {
                goto label_296;
            }
            
            label_276:
            val_97 = null;
            val_98 = ;
            if(BestHTTP.HTTPManager.CanProcessFromQueue() == false)
            {
                goto label_299;
            }
            
            val_99 = null;
            val_99 = null;
            val_82 = 1152921505553436672;
            val_100 = null;
            val_100 = null;
            val_102 = HTTPManager.<>c.<>9__103_0;
            if(val_102 == null)
            {
                    val_102 = null;
                val_102 = new System.Func<BestHTTP.HTTPRequest, System.Boolean>(object:  HTTPManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HTTPManager.<>c::<OnUpdate>b__103_0(BestHTTP.HTTPRequest x));
                HTTPManager.<>c.<>9__103_0 = val_102;
            }
            
            if((System.Linq.Enumerable.Any<BestHTTP.HTTPRequest>(source:  BestHTTP.HTTPManager.RequestQueue, predicate:  null)) != false)
            {
                    UnityEngine.Debug.LogWarning(message:  "RequestQueue contains null");
            }
            
            val_103 = null;
            val_103 = null;
            val_104 = null;
            val_104 = null;
            val_106 = HTTPManager.<>c.<>9__103_1;
            if(val_106 == null)
            {
                    val_106 = null;
                val_106 = new System.Predicate<BestHTTP.HTTPRequest>(object:  HTTPManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HTTPManager.<>c::<OnUpdate>b__103_1(BestHTTP.HTTPRequest req));
                HTTPManager.<>c.<>9__103_1 = val_106;
            }
            
            if((BestHTTP.HTTPManager.RequestQueue.Find(match:  null)) != null)
            {
                    val_107 = null;
                val_107 = null;
                val_108 = null;
                val_108 = null;
                val_110 = HTTPManager.<>c.<>9__103_2;
                if(val_110 == null)
            {
                    val_110 = null;
                val_110 = new System.Comparison<BestHTTP.HTTPRequest>(object:  HTTPManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 HTTPManager.<>c::<OnUpdate>b__103_2(BestHTTP.HTTPRequest req1, BestHTTP.HTTPRequest req2));
                HTTPManager.<>c.<>9__103_2 = val_110;
            }
            
                BestHTTP.HTTPManager.RequestQueue.Sort(comparison:  null);
            }
            
            val_111 = null;
            val_111 = null;
            val_86 = BestHTTP.HTTPManager.RequestQueue;
            val_86.Clear();
            val_112 = 0;
            goto label_331;
            label_336:
            val_86 = BestHTTP.HTTPManager.RequestQueue.ToArray()[0];
            BestHTTP.HTTPRequest val_63 = BestHTTP.HTTPManager.SendRequest(request:  val_86);
            val_112 = 1;
            label_331:
            if(val_112 < val_62.Length)
            {
                goto label_336;
            }
            
            label_299:
            val_79 = val_76 + 1;
            mem2[0] = 1116;
            val_113 = null;
            val_113 = null;
            System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.Locker);
            if(val_79 == 1)
            {
                goto label_368;
            }
            
            if(( == 0) || ((val_98 + (((0 + 1) + 1)) << 2) == 1116))
            {
                goto label_378;
            }
            
            label_377:
            label_378:
            val_114 = null;
            val_114 = null;
            val_115 = BestHTTP.HTTPManager.heartbeats;
            if(val_115 == null)
            {
                    return;
            }
            
            val_115 = BestHTTP.HTTPManager.heartbeats;
            if(val_115 == null)
            {
                    val_115 = 0;
            }
            
            val_115.Update();
            return;
            label_368:
            if( != 0)
            {
                goto label_377;
            }
            
            goto label_378;
        }
        public static void OnQuit()
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.HTTPManager.Locker, lockTaken: ref  val_1);
            BestHTTP.HTTPManager.IsQuitting = true;
            BestHTTP.Caching.HTTPCacheService.SaveLibrary();
            BestHTTP.Cookies.CookieJar.Persist();
            BestHTTP.HTTPManager.AbortAll(allowCallbacks:  true);
            BestHTTP.HTTPManager.OnUpdate();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.Locker);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static void AbortAll(bool allowCallbacks = False)
        {
            var val_6;
            var val_10;
            var val_15;
            var val_18;
            var val_19;
            var val_20;
            var val_23;
            T val_24;
            var val_25;
            var val_28;
            var val_29;
            object val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_18 = null;
            val_18 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.HTTPManager.Locker, lockTaken: ref  val_1);
            val_19 = null;
            val_19 = null;
            T[] val_2 = BestHTTP.HTTPManager.RequestQueue.ToArray();
            BestHTTP.HTTPManager.RequestQueue.Clear();
            var val_17 = 0;
            if(val_2 != null)
            {
                goto label_14;
            }
            
            label_15:
            label_14:
            if(val_17 >= val_2.Length)
            {
                goto label_8;
            }
            
            T val_16 = val_2[0];
            if(allowCallbacks == false)
            {
                goto label_10;
            }
            
            if(val_16 != 0)
            {
                goto label_12;
            }
            
            goto label_12;
            label_10:
            mem2[0] = 0;
            label_12:
            val_16.Abort();
            val_17 = val_17 + 1;
            if(val_2 != null)
            {
                goto label_14;
            }
            
            goto label_15;
            label_8:
            val_23 = null;
            val_23 = null;
            Dictionary.Enumerator<TKey, TValue> val_3 = BestHTTP.HTTPManager.Connections.GetEnumerator();
            val_20 = 1152921553621873024;
            val_24 = 0;
            val_25 = 0;
            var val_18 = 0;
            label_55:
            if((1770419136 & 1) == 0)
            {
                goto label_23;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            List.Enumerator<T> val_8 = val_7._value._obj.GetEnumerator();
            label_43:
            if((1770419088 & 1) == 0)
            {
                goto label_25;
            }
            
            string val_11 = val_10.丐丏七丌丕丗业且上();
            if(val_11.CurrentRequest != null)
            {
                    if(allowCallbacks != true)
            {
                    BestHTTP.HTTPRequest val_13 = val_11.CurrentRequest;
                val_13.<Callback>k__BackingField = 0;
            }
            
                BestHTTP.HTTPRequest val_14 = val_11.CurrentRequest;
                val_14.<State>k__BackingField = 5;
            }
            
            val_11.Dispose();
            goto label_43;
            label_25:
            val_18 = val_18 + 1;
            mem2[0] = 214;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_18 != 1) && (val_15 == 214))
            {
                    var val_19 = 0;
                val_19 = val_19 ^ 0;
                val_18 = val_18 + val_19;
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            val_7._value._obj.Clear();
            goto label_55;
            label_23:
            val_28 = 1770418976;
            val_29 = val_18 + 1;
            mem2[0] = 254;
            val_31 = BestHTTP.HTTPManager.Locker;
            val_32 = 1152921505553330176;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((W28 != 1) && ((val_28 + (W28) << 2) == 254))
            {
                    var val_20 = 0;
                val_20 = val_20 ^ (((int)W28) >> 31);
                val_29 = W28 + val_20;
            }
            else
            {
                    if( != 0)
            {
                    val_24 = 0;
                val_33 = 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            }
            
            val_34 = null;
            BestHTTP.HTTPManager.Connections.Clear();
            val_35 = W28 + 1;
            mem2[0] = 276;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.HTTPManager.Locker);
            }
            
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(val_15 == 276)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
    
    }

}
