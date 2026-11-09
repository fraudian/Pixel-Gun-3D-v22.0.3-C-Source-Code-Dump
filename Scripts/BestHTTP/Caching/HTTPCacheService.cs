using UnityEngine;

namespace BestHTTP.Caching
{
    public static class HTTPCacheService
    {
        // Fields
        private const int LibraryVersion = 2;
        private static bool isSupported;
        private static bool IsSupportCheckDone;
        private static System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> library;
        private static System.Collections.Generic.Dictionary<ulong, BestHTTP.Caching.HTTPCacheFileInfo> UsedIndexes;
        private static string <CacheFolder>k__BackingField;
        private static string <LibraryPath>k__BackingField;
        private static bool InClearThread;
        private static bool InMaintainenceThread;
        private static ulong NextNameIDX;
        
        // Properties
        public static bool IsSupported { get; }
        private static System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> Library { get; }
        internal static string CacheFolder { get; set; }
        private static string LibraryPath { get; set; }
        
        // Methods
        public static bool get_IsSupported()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupportCheckDone == true)
            {
                    return (bool)BestHTTP.Caching.HTTPCacheService.isSupported;
            }
            
            bool val_2 = System.IO.File.Exists(path:  BestHTTP.HTTPManager.GetRootCacheFolder());
            val_7 = null;
            val_7 = null;
            val_5 = 0;
            BestHTTP.Caching.HTTPCacheService.isSupported = true;
            val_8 = null;
            val_8 = null;
            BestHTTP.Caching.HTTPCacheService.IsSupportCheckDone = true;
            if(0 == 1)
            {
                goto label_10;
            }
            
            if((val_5 == 0) || (69 == 69))
            {
                goto label_16;
            }
            
            label_15:
            label_16:
            val_6 = null;
            return (bool)BestHTTP.Caching.HTTPCacheService.isSupported;
            label_10:
            if(val_5 != 0)
            {
                goto label_15;
            }
            
            goto label_16;
        }
        private static System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> get_Library()
        {
            BestHTTP.Caching.HTTPCacheService.LoadLibrary();
            return (System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo>)BestHTTP.Caching.HTTPCacheService.library;
        }
        internal static string get_CacheFolder()
        {
            null = null;
            return (string)BestHTTP.Caching.HTTPCacheService.<CacheFolder>k__BackingField;
        }
        private static void set_CacheFolder(string value)
        {
            null = null;
            BestHTTP.Caching.HTTPCacheService.<CacheFolder>k__BackingField = value;
        }
        private static string get_LibraryPath()
        {
            null = null;
            return (string)BestHTTP.Caching.HTTPCacheService.<LibraryPath>k__BackingField;
        }
        private static void set_LibraryPath(string value)
        {
            null = null;
            BestHTTP.Caching.HTTPCacheService.<LibraryPath>k__BackingField = value;
        }
        private static HTTPCacheService()
        {
            BestHTTP.Caching.HTTPCacheService.UsedIndexes = new System.Collections.Generic.Dictionary<System.UInt64, BestHTTP.Caching.HTTPCacheFileInfo>();
            BestHTTP.Caching.HTTPCacheService.NextNameIDX = 1;
        }
        internal static void CheckSetup()
        {
            var val_2 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            BestHTTP.Caching.HTTPCacheService.SetupCacheFolder();
            BestHTTP.Caching.HTTPCacheService.LoadLibrary();
        }
        internal static void SetupCacheFolder()
        {
            string val_14;
            var val_15 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  BestHTTP.Caching.HTTPCacheService.CacheFolder)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  BestHTTP.Caching.HTTPCacheService.LibraryPath)) == false)
            {
                    return;
            }
            
            }
            
            BestHTTP.Caching.HTTPCacheService.CacheFolder = System.IO.Path.Combine(path1:  BestHTTP.HTTPManager.GetRootCacheFolder(), path2:  "HTTPCache");
            if((System.IO.Directory.Exists(path:  BestHTTP.Caching.HTTPCacheService.CacheFolder)) != true)
            {
                    System.IO.DirectoryInfo val_11 = System.IO.Directory.CreateDirectory(path:  BestHTTP.Caching.HTTPCacheService.CacheFolder);
            }
            
            val_14 = System.IO.Path.Combine(path1:  BestHTTP.HTTPManager.GetRootCacheFolder(), path2:  "Library");
            BestHTTP.Caching.HTTPCacheService.LibraryPath = val_14;
        }
        internal static ulong GetNameIdx()
        {
            var val_6;
            ulong val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_1 = BestHTTP.Caching.HTTPCacheService.Library;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  val_1, lockTaken: ref  val_2);
            val_6 = null;
            val_6 = null;
            val_7 = BestHTTP.Caching.HTTPCacheService.NextNameIDX;
            goto label_5;
            label_9:
            val_6 = null;
            label_5:
            val_6 = null;
            ulong val_6 = BestHTTP.Caching.HTTPCacheService.NextNameIDX;
            ulong val_3 = val_6 + 1;
            BestHTTP.Caching.HTTPCacheService.NextNameIDX = val_3;
            val_6 = (val_3 == 1) ? (val_6 + 2) : (val_6 + 1);
            BestHTTP.Caching.HTTPCacheService.NextNameIDX = val_6;
            if((BestHTTP.Caching.HTTPCacheService.UsedIndexes.ContainsKey(key:  BestHTTP.Caching.HTTPCacheService.NextNameIDX)) == true)
            {
                goto label_9;
            }
            
            val_8 = 0;
            val_9 = 0;
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_1);
            }
            
            if( != 1)
            {
                    return (ulong);
            }
            
            if( == false)
            {
                    return (ulong);
            }
            
            return (ulong);
        }
        internal static bool HasEntity(System.Uri uri)
        {
            object val_6;
            var val_7;
            var val_8;
            var val_9;
            val_7 = 1152921505561370624;
            val_8 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported != false)
            {
                    System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
                val_6 = val_2;
                bool val_3 = false;
                System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
                val_9 = BestHTTP.Caching.HTTPCacheService.Library.ContainsKey(key:  uri);
                val_7 = 0;
                if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_6);
            }
            
                if((0 != 1) || (val_7 == 0))
            {
                    return (bool)val_9 & 1;
            }
            
                return (bool)val_9 & 1;
            }
            
            val_9 = 0;
            return (bool)val_9 & 1;
        }
        internal static bool DeleteEntity(System.Uri uri, bool removeFromLibrary = True)
        {
            object val_16;
            System.Uri val_17;
            var val_18;
            var val_19;
            var val_20;
            val_17 = uri;
            val_18 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                goto label_3;
            }
            
            object val_2 = BestHTTP.Caching.HTTPCacheFileLock.Acquire(uri:  val_17);
            val_16 = val_2;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_4 = BestHTTP.Caching.HTTPCacheService.Library;
            bool val_5 = false;
            System.Threading.Monitor.Enter(obj:  val_4, lockTaken: ref  val_5);
            if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  val_17, value: out  0)) != false)
            {
                    val_7.Delete();
                if(removeFromLibrary != false)
            {
                    bool val_10 = BestHTTP.Caching.HTTPCacheService.Library.Remove(key:  val_17);
                bool val_12 = BestHTTP.Caching.HTTPCacheService.UsedIndexes.Remove(key:  val_7.MappedNameIDX);
            }
            
            }
            
            val_17 = 0;
            if(val_5 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_4);
            }
            
            if(0 == 1)
            {
                goto label_20;
            }
            
            val_19 = 0;
            var val_13 = (1 != 0) ? 1 : 0;
            goto label_21;
            label_3:
            val_20 = 0;
            return (bool)(1 != 0) ? 1 : 0;
            label_20:
            var val_14 = (1 != 0) ? 1 : 0;
            if(val_17 != 0)
            {
                    val_17 = 0;
            }
            
            val_19 = 0;
            label_21:
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_16);
            }
            
            if(val_19 != 1)
            {
                    return (bool)(1 != 0) ? 1 : 0;
            }
            
            if(val_17 == 0)
            {
                    return (bool)(1 != 0) ? 1 : 0;
            }
            
            return (bool)(1 != 0) ? 1 : 0;
        }
        internal static bool IsCachedEntityExpiresInTheFuture(BestHTTP.HTTPRequest request)
        {
            object val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = 1152921505561370624;
            val_11 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                goto label_19;
            }
            
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
            val_9 = val_2;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
            if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  request.CurrentUri, value: out  0)) != false)
            {
                    val_12 = val_6.WillExpireInTheFuture();
                val_13 = 68;
                val_14 = 0;
                val_10 = 0;
            }
            else
            {
                    val_13 = 66;
                val_14 = 0;
                val_10 = 0;
                val_12 = 0;
            }
            
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_9);
            }
            
            if(val_14 == 1)
            {
                goto label_14;
            }
            
            if(66 == 68)
            {
                    return (bool)val_12 & 1;
            }
            
            val_12 = 0;
            if(val_10 == 0)
            {
                    return (bool)val_12 & 1;
            }
            
            if(66 != 66)
            {
                goto label_17;
            }
            
            return (bool)val_12 & 1;
            label_14:
            if(val_10 == 0)
            {
                goto label_19;
            }
            
            label_17:
            label_19:
            val_12 = 0;
            return (bool)val_12 & 1;
        }
        internal static void SetHeaders(BestHTTP.HTTPRequest request)
        {
            object val_8;
            var val_9;
            var val_10;
            val_9 = 1152921505561370624;
            val_10 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
            val_8 = val_2;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
            if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  request.CurrentUri, value: out  0)) != false)
            {
                    val_6.SetUpRevalidationHeaders(request:  request);
            }
            
            val_9 = 0;
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_8);
            }
            
            if(val_9 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        internal static BestHTTP.Caching.HTTPCacheFileInfo GetEntity(System.Uri uri)
        {
            object val_7;
            var val_8;
            var val_9;
            val_8 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported != false)
            {
                    BestHTTP.Caching.HTTPCacheFileInfo val_5 = 0;
                System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
                val_7 = val_2;
                bool val_3 = false;
                System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
                bool val_6 = BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  uri, value: out  val_5);
                if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_7);
            }
            
                val_9 = val_5;
                return (BestHTTP.Caching.HTTPCacheFileInfo)val_9;
            }
            
            val_9 = 0;
            return (BestHTTP.Caching.HTTPCacheFileInfo)val_9;
        }
        internal static BestHTTP.HTTPResponse GetFullResponse(BestHTTP.HTTPRequest request)
        {
            object val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = 1152921505561370624;
            val_11 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                goto label_19;
            }
            
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
            val_9 = val_2;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
            if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  request.CurrentUri, value: out  0)) != false)
            {
                    val_12 = val_6.ReadResponseTo(request:  request);
                val_13 = 69;
                val_14 = 0;
                val_10 = 0;
            }
            else
            {
                    val_13 = 67;
                val_14 = 0;
                val_10 = 0;
                val_12 = 0;
            }
            
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_9);
            }
            
            if(val_14 == 1)
            {
                goto label_14;
            }
            
            if(67 == 69)
            {
                    return (BestHTTP.HTTPResponse)val_12;
            }
            
            val_12 = 0;
            if(val_10 == 0)
            {
                    return (BestHTTP.HTTPResponse)val_12;
            }
            
            if(67 != 67)
            {
                goto label_17;
            }
            
            return (BestHTTP.HTTPResponse)val_12;
            label_14:
            if(val_10 == 0)
            {
                goto label_19;
            }
            
            label_17:
            label_19:
            val_12 = 0;
            return (BestHTTP.HTTPResponse)val_12;
        }
        internal static bool IsCacheble(System.Uri uri, BestHTTP.HTTPMethods method, BestHTTP.HTTPResponse response)
        {
            System.Predicate<System.String> val_13;
            var val_14;
            var val_15;
            var val_17;
            val_14 = null;
            if(response == null)
            {
                    return false;
            }
            
            if(((method & 255) != 0) || (BestHTTP.Caching.HTTPCacheService.IsSupported == false))
            {
                    return false;
            }
            
            if(response.StatusCode < 200)
            {
                    return false;
            }
            
            if(response.StatusCode > 399)
            {
                    return false;
            }
            
            System.Collections.Generic.List<System.String> val_5 = response.GetHeaderValues(name:  "cache-control");
            if(val_5 != null)
            {
                    val_15 = null;
                val_15 = null;
                val_13 = HTTPCacheService.<>c.<>9__30_0;
                if(val_13 == null)
            {
                    System.Predicate<System.String> val_6 = null;
                val_13 = val_6;
                val_6 = new System.Predicate<System.String>(object:  HTTPCacheService.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HTTPCacheService.<>c::<IsCacheble>b__30_0(string headerValue));
                HTTPCacheService.<>c.<>9__30_0 = val_13;
            }
            
                if((val_5.Exists(match:  val_6)) == true)
            {
                    return false;
            }
            
            }
            
            System.Collections.Generic.List<System.String> val_8 = response.GetHeaderValues(name:  "pragma");
            if(val_8 != null)
            {
                    val_17 = null;
                val_17 = null;
                val_13 = HTTPCacheService.<>c.<>9__30_1;
                if(val_13 == null)
            {
                    System.Predicate<System.String> val_9 = null;
                val_13 = val_9;
                val_9 = new System.Predicate<System.String>(object:  HTTPCacheService.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HTTPCacheService.<>c::<IsCacheble>b__30_1(string headerValue));
                HTTPCacheService.<>c.<>9__30_1 = val_13;
            }
            
                if((val_8.Exists(match:  val_9)) != false)
            {
                    return false;
            }
            
            }
            
            var val_12 = ((response.GetHeaderValues(name:  "content-range")) == 0) ? 1 : 0;
            return false;
        }
        internal static BestHTTP.Caching.HTTPCacheFileInfo Store(System.Uri uri, BestHTTP.HTTPMethods method, BestHTTP.HTTPResponse response)
        {
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            if(response == null)
            {
                goto label_7;
            }
            
            if(response.Data == null)
            {
                    return (BestHTTP.Caching.HTTPCacheFileInfo)val_22;
            }
            
            val_21 = response.Data;
            if(val_2.Length == 0)
            {
                goto label_7;
            }
            
            val_23 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                goto label_7;
            }
            
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_4 = BestHTTP.Caching.HTTPCacheService.Library;
            bool val_5 = false;
            System.Threading.Monitor.Enter(obj:  val_4, lockTaken: ref  val_5);
            val_24 = public System.Boolean System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo>::TryGetValue(System.Uri key, out BestHTTP.Caching.HTTPCacheFileInfo value);
            if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  uri, value: out  0)) != true)
            {
                    BestHTTP.Caching.HTTPCacheFileInfo val_11 = new BestHTTP.Caching.HTTPCacheFileInfo();
                val_11 = new BestHTTP.Caching.HTTPCacheFileInfo(uri:  uri);
                bool val_12 = BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  uri, value: out  val_11);
                val_24 = public System.Void System.Collections.Generic.Dictionary<System.UInt64, BestHTTP.Caching.HTTPCacheFileInfo>::Add(System.UInt64 key, BestHTTP.Caching.HTTPCacheFileInfo value);
                BestHTTP.Caching.HTTPCacheService.UsedIndexes.Add(key:  val_11.MappedNameIDX, value:  val_11);
            }
            
            val_11.Store(response:  response);
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_26;
            label_7:
            val_22 = 0;
            return (BestHTTP.Caching.HTTPCacheFileInfo)val_22;
            label_26:
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  "HTTPCacheService", verb:  System.String.Format(format:  "{0} - Saved to cache", arg0:  uri));
            }
            
            if(val_5 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_4);
            }
            
            if(0 != 1)
            {
                    return (BestHTTP.Caching.HTTPCacheFileInfo)val_22;
            }
            
            if(0 == 0)
            {
                    return (BestHTTP.Caching.HTTPCacheFileInfo)val_22;
            }
            
            return (BestHTTP.Caching.HTTPCacheFileInfo)val_22;
        }
        internal static System.IO.Stream PrepareStreamed(System.Uri uri, BestHTTP.HTTPResponse response)
        {
            object val_11;
            var val_12;
            var val_13;
            val_12 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported != false)
            {
                    System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
                val_11 = val_2;
                bool val_3 = false;
                System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
                if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  uri, value: out  0)) != true)
            {
                    new BestHTTP.Caching.HTTPCacheFileInfo() = new BestHTTP.Caching.HTTPCacheFileInfo(uri:  uri);
                BestHTTP.Caching.HTTPCacheService.Library.Add(key:  uri, value:  new BestHTTP.Caching.HTTPCacheFileInfo());
                BestHTTP.Caching.HTTPCacheService.UsedIndexes.Add(key:  new BestHTTP.Caching.HTTPCacheFileInfo().MappedNameIDX, value:  new BestHTTP.Caching.HTTPCacheFileInfo());
            }
            
                val_13 = new BestHTTP.Caching.HTTPCacheFileInfo().GetSaveStream(response:  response);
                if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_11);
            }
            
                if(0 != 1)
            {
                    return (System.IO.Stream)val_13;
            }
            
                if(0 == 0)
            {
                    return (System.IO.Stream)val_13;
            }
            
                return (System.IO.Stream)val_13;
            }
            
            val_13 = 0;
            return (System.IO.Stream)val_13;
        }
        public static void BeginClear()
        {
            var val_4;
            var val_5;
            var val_7;
            System.Threading.WaitCallback val_9;
            val_4 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            bool val_4 = BestHTTP.Caching.HTTPCacheService.InClearThread;
            val_4 = val_4 + 7;
            var val_5 = ~val_4;
            val_5 = val_5 & 7;
            if(val_5 != 0)
            {
                    return;
            }
            
            BestHTTP.Caching.HTTPCacheService.InClearThread = true;
            BestHTTP.Caching.HTTPCacheService.SetupCacheFolder();
            val_7 = null;
            val_7 = null;
            val_9 = HTTPCacheService.<>c.<>9__33_0;
            if(val_9 == null)
            {
                    System.Threading.WaitCallback val_2 = null;
                val_9 = val_2;
                val_2 = new System.Threading.WaitCallback(object:  HTTPCacheService.<>c.__il2cppRuntimeField_static_fields, method:  System.Void HTTPCacheService.<>c::<BeginClear>b__33_0(object param));
                HTTPCacheService.<>c.<>9__33_0 = val_9;
            }
            
            bool val_3 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  val_2);
        }
        private static void ClearImpl(object param)
        {
            var val_5;
            string val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_8 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                goto label_28;
            }
            
            System.String[] val_3 = System.IO.Directory.GetFiles(path:  BestHTTP.Caching.HTTPCacheService.CacheFolder);
            var val_6 = 0;
            if(val_3 != null)
            {
                goto label_9;
            }
            
            label_10:
            label_9:
            if(val_6 >= val_3.Length)
            {
                goto label_7;
            }
            
            System.IO.File.Delete(path:  val_3[0]);
            val_6 = val_6 + 1;
            if(val_3 != null)
            {
                goto label_9;
            }
            
            goto label_10;
            label_7:
            val_9 = 0;
            val_6 = 0;
            val_10 = null;
            val_10 = null;
            BestHTTP.Caching.HTTPCacheService.UsedIndexes.Clear();
            BestHTTP.Caching.HTTPCacheService.library.Clear();
            BestHTTP.Caching.HTTPCacheService.NextNameIDX = 1;
            BestHTTP.Caching.HTTPCacheService.SaveLibrary();
            BestHTTP.Caching.HTTPCacheService.InClearThread = false;
            if( == 1)
            {
                goto label_26;
            }
            
            if(( == 0) || (89 == 89))
            {
                goto label_28;
            }
            
            label_29:
            val_5 = ???;
            val_6 = ???;
            val_7 = ???;
            label_26:
            if(val_6 != 0)
            {
                goto label_29;
            }
            
            label_28:
            var val_4 = val_5 - 48;
        }
        public static void BeginMaintainence(BestHTTP.Caching.HTTPCacheMaintananceParams maintananceParam)
        {
            BestHTTP.Caching.HTTPCacheMaintananceParams val_6;
            object val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = maintananceParam;
            HTTPCacheService.<>c__DisplayClass35_0 val_1 = null;
            val_7 = val_1;
            val_1 = new HTTPCacheService.<>c__DisplayClass35_0();
            if(val_7 == null)
            {
                goto label_1;
            }
            
            .maintananceParam = val_6;
            if(val_6 == null)
            {
                goto label_2;
            }
            
            label_9:
            val_6 = 1152921505561370624;
            val_8 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if(BestHTTP.Caching.HTTPCacheService.InMaintainenceThread == false)
            {
                goto label_8;
            }
            
            return;
            label_1:
            mem[16] = val_6;
            val_6 = mem[16];
            if(val_6 != 0)
            {
                goto label_9;
            }
            
            label_2:
            System.ArgumentNullException val_3 = null;
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "maintananceParams == null");
            val_10 = 1152921553862286608;
            label_8:
            if(((W9 & 2) != 0) && (W9 == 0))
            {
                    val_10 = mem[maintananceParam + 184];
                val_10 = maintananceParam + 184;
            }
            
            mem2[0] = 1;
            BestHTTP.Caching.HTTPCacheService.SetupCacheFolder();
            bool val_5 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  val_3, method:  System.Void HTTPCacheService.<>c__DisplayClass35_0::<BeginMaintainence>b__0(object param)));
        }
        public static int GetCacheEntityCount()
        {
            object val_6;
            var val_7;
            var val_8;
            val_7 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported != false)
            {
                    BestHTTP.Caching.HTTPCacheService.CheckSetup();
                System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
                val_6 = val_2;
                bool val_3 = false;
                System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
                val_8 = BestHTTP.Caching.HTTPCacheService.Library.Count;
                if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_6);
            }
            
                if(0 != 1)
            {
                    return (int)val_8;
            }
            
                if(0 == 0)
            {
                    return (int)val_8;
            }
            
                return (int)val_8;
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        public static ulong GetCacheSize()
        {
            var val_8;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_14 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                goto label_3;
            }
            
            BestHTTP.Caching.HTTPCacheService.CheckSetup();
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
            val_13 = val_2;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
            Dictionary.Enumerator<TKey, TValue> val_5 = BestHTTP.Caching.HTTPCacheService.Library.GetEnumerator();
            val_15 = 0;
            goto label_11;
            label_13:
            ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
            if(val_9._value._obj.BodyLength >= 1)
            {
                    val_15 = val_15 + (val_9._value._obj.BodyLength << );
            }
            
            label_11:
            if((2011092608 & 1) != 0)
            {
                goto label_13;
            }
            
            val_16 = 0;
            val_17 = 0;
            goto label_14;
            label_3:
            val_15 = 0;
            return (ulong);
            label_14:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    val_18 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_17 = 0;
            }
            
                val_18 = 0;
            }
            
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  137154560);
            }
            
            if( != 1)
            {
                    return (ulong);
            }
            
            if( == false)
            {
                    return (ulong);
            }
            
            return (ulong);
        }
        private static void LoadLibrary()
        {
            System.Collections.Generic.Dictionary<TKey, TValue> val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Uri val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_17 = null;
            val_17 = null;
            if(BestHTTP.Caching.HTTPCacheService.library != null)
            {
                    return;
            }
            
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            BestHTTP.Caching.UriComparer val_2 = new BestHTTP.Caching.UriComparer();
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_3 = null;
            val_16 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo>(comparer:  val_2);
            val_18 = null;
            val_18 = null;
            BestHTTP.Caching.HTTPCacheService.library = val_16;
            val_19 = null;
            if((System.IO.File.Exists(path:  BestHTTP.Caching.HTTPCacheService.LibraryPath)) == false)
            {
                goto label_9;
            }
            
            val_19 = null;
            val_16 = BestHTTP.Caching.HTTPCacheService.library;
            bool val_6 = false;
            System.Threading.Monitor.Enter(obj:  val_3, lockTaken: ref  val_6);
            new System.IO.FileStream() = new System.IO.FileStream(path:  BestHTTP.Caching.HTTPCacheService.LibraryPath, mode:  3);
            new System.IO.BinaryReader() = new System.IO.BinaryReader(input:  new System.IO.FileStream());
            val_20 = new System.IO.BinaryReader();
            if(val_20 >= 2)
            {
                    val_21 = null;
                val_21 = null;
                BestHTTP.Caching.HTTPCacheService.NextNameIDX = new System.IO.BinaryReader();
            }
            
            if(new System.IO.BinaryReader() >= 1)
            {
                    do
            {
                val_22 = new System.Uri();
                val_22 = new System.Uri(uriString:  new System.IO.BinaryReader());
                new BestHTTP.Caching.HTTPCacheFileInfo() = new BestHTTP.Caching.HTTPCacheFileInfo(uri:  new System.Uri(), reader:  new System.IO.BinaryReader(), version:  2011315312);
                if(new BestHTTP.Caching.HTTPCacheFileInfo().IsExists() != false)
            {
                    val_23 = null;
                val_23 = null;
                val_3.Add(key:  new System.Uri(), value:  new BestHTTP.Caching.HTTPCacheFileInfo());
                if(val_20 >= 2)
            {
                    val_24 = null;
                val_24 = null;
                val_22 = BestHTTP.Caching.HTTPCacheService.UsedIndexes;
                val_22.Add(key:  new BestHTTP.Caching.HTTPCacheFileInfo().MappedNameIDX, value:  new BestHTTP.Caching.HTTPCacheFileInfo());
            }
            
            }
            
                val_16 = 0 + 1;
            }
            while(val_16 < new System.IO.BinaryReader());
            
            }
            
            val_25 = 0;
            val_26 = 0;
            if(new System.IO.BinaryReader() != null)
            {
                goto label_30;
            }
            
            goto label_54;
            label_9:
            BestHTTP.Caching.HTTPCacheService.DeleteUnusedFiles();
            return;
            label_30:
            var val_16 = X22;
            if((X22 + 286) == 0)
            {
                goto label_58;
            }
            
            var val_14 = X22 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_57:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_56;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (X22 + 286))
            {
                goto label_57;
            }
            
            goto label_58;
            label_56:
            val_16 = val_16 + (((X22 + 176 + 8)) << 4);
            val_29 = val_16 + 296;
            label_58:
            X22.Dispose();
            label_54:
            if(( != 1) && (222 == 222))
            {
                    val_25 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_26 = 0;
            }
            
            }
            
            val_30 = 0 + 1;
            mem2[0] = 234;
            val_31 = val_26;
            if(X21 == 0)
            {
                goto label_63;
            }
            
            var val_19 = X21;
            if((X21 + 286) == 0)
            {
                goto label_67;
            }
            
            var val_17 = X21 + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_66:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_65;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (X21 + 286))
            {
                goto label_66;
            }
            
            goto label_67;
            label_65:
            val_19 = val_19 + (((X21 + 176 + 8)) << 4);
            val_32 = val_19 + 296;
            label_67:
            X21.Dispose();
            label_63:
            if((val_30 != 1) && ((1152921553862737920 + ((0 + 1)) << 2) == 234))
            {
                    var val_20 = 0;
                val_20 = val_20 ^ (val_30 >> 31);
                val_30 = val_30 + val_20;
            }
            else
            {
                    if(val_31 != 0)
            {
                    val_26 = 0;
                val_31 = 0;
            }
            else
            {
                    val_26 = 0;
            }
            
            }
            
            val_30 = val_30 + 1;
            mem2[0] = 246;
            if(val_6 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_3);
            }
            
            if(val_30 == 1)
            {
                goto label_74;
            }
            
            if(val_31 == 0)
            {
                goto label_78;
            }
            
            if((1152921553862737920 + (((0 + 1) + 1)) << 2) != 246)
            {
                goto label_76;
            }
            
            goto label_78;
            label_74:
            if(val_31 == 0)
            {
                goto label_78;
            }
            
            label_76:
            label_78:
            if(val_2 == 1)
            {
                    BestHTTP.Caching.HTTPCacheService.BeginClear();
                return;
            }
            
            BestHTTP.Caching.HTTPCacheService.DeleteUnusedFiles();
        }
        internal static void SaveLibrary()
        {
            var val_13;
            object val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_26;
            var val_27;
            var val_29;
            val_20 = null;
            val_20 = null;
            if(BestHTTP.Caching.HTTPCacheService.library == null)
            {
                    return;
            }
            
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            val_19 = BestHTTP.Caching.HTTPCacheService.Library;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_19, lockTaken: ref  val_3);
            new System.IO.FileStream() = new System.IO.FileStream(path:  BestHTTP.Caching.HTTPCacheService.LibraryPath, mode:  2);
            new System.IO.BinaryWriter() = new System.IO.BinaryWriter(output:  new System.IO.FileStream());
            val_21 = null;
            val_21 = null;
            int val_8 = BestHTTP.Caching.HTTPCacheService.Library.Count;
            Dictionary.Enumerator<TKey, TValue> val_10 = BestHTTP.Caching.HTTPCacheService.Library.GetEnumerator();
            label_19:
            if((2011425216 & 1) == 0)
            {
                goto label_16;
            }
            
            ConfiguredValueTaskAwaiter val_14 = val_13.GetAwaiter();
            string val_15 = val_14._value._obj.丐丏七丌丕丗业且上();
            val_14._value._obj.SaveTo(writer:  new System.IO.BinaryWriter());
            goto label_19;
            label_16:
            val_22 = 0;
            val_23 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (165 == 165))
            {
                    val_22 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_23 = 0;
            }
            
            }
            
            val_26 = 0 + 1;
            mem2[0] = 177;
            val_27 = val_23;
            if(new System.IO.BinaryWriter() != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                new System.IO.BinaryWriter().Dispose();
            }
            
            if((val_26 != 1) && ((1152921553862912352 + ((0 + 1)) << 2) == 177))
            {
                    var val_19 = 0;
                val_19 = val_19 ^ (val_26 >> 31);
                val_26 = val_26 + val_19;
            }
            else
            {
                    if(val_27 != 0)
            {
                    val_23 = 0;
                val_27 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            }
            
            val_29 = val_26 + 1;
            mem2[0] = 189;
            if(new System.IO.FileStream() != null)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                new System.IO.FileStream().Dispose();
            }
            
            if((val_29 != 1) && ((1152921553862912352 + (((0 + 1) + 1)) << 2) == 189))
            {
                    var val_21 = 0;
                val_21 = val_21 ^ (val_29 >> 31);
                val_29 = val_29 + val_21;
            }
            else
            {
                    if(val_27 != 0)
            {
                    val_23 = 0;
                val_27 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            }
            
            val_29 = val_29 + 1;
            mem2[0] = 201;
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_19);
            }
            
            if(val_29 != 1)
            {
                    if(val_27 == 0)
            {
                    return;
            }
            
                if((1152921553862912352 + ((((0 + 1) + 1) + 1)) << 2) != 201)
            {
                    return;
            }
            
                return;
            }
            
            if(val_27 == 0)
            {
                    return;
            }
        
        }
        internal static void SetBodyLength(System.Uri uri, int bodyLength)
        {
            object val_11;
            int val_12;
            var val_13;
            val_12 = bodyLength;
            val_13 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_2 = BestHTTP.Caching.HTTPCacheService.Library;
            val_11 = val_2;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_2, lockTaken: ref  val_3);
            if((BestHTTP.Caching.HTTPCacheService.Library.TryGetValue(key:  uri, value: out  0)) != false)
            {
                    val_5.BodyLength = val_12;
            }
            else
            {
                    System.DateTime val_8 = System.DateTime.UtcNow;
                new BestHTTP.Caching.HTTPCacheFileInfo() = new BestHTTP.Caching.HTTPCacheFileInfo(uri:  uri, lastAcces:  new System.DateTime() {dateData = val_8.dateData}, bodyLength:  val_12);
                BestHTTP.Caching.HTTPCacheService.Library.Add(key:  uri, value:  new BestHTTP.Caching.HTTPCacheFileInfo());
                BestHTTP.Caching.HTTPCacheService.UsedIndexes.Add(key:  new BestHTTP.Caching.HTTPCacheFileInfo().MappedNameIDX, value:  new BestHTTP.Caching.HTTPCacheFileInfo());
            }
            
            val_12 = 0;
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_11);
            }
            
            if(val_12 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(102 == 102)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        private static void DeleteUnusedFiles()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            string val_15;
            var val_16;
            val_11 = null;
            if(BestHTTP.Caching.HTTPCacheService.IsSupported == false)
            {
                    return;
            }
            
            BestHTTP.Caching.HTTPCacheService.CheckSetup();
            val_12 = 1152921504644653056;
            val_10 = System.IO.Directory.GetFiles(path:  BestHTTP.Caching.HTTPCacheService.CacheFolder);
            val_13 = 0;
            val_14 = 0;
            goto label_24;
            label_39:
            val_15 = val_10[0];
            if((System.UInt64.TryParse(s:  System.IO.Path.GetFileName(path:  val_15), style:  512, provider:  0, result: out  0)) == false)
            {
                goto label_22;
            }
            
            val_15 = BestHTTP.Caching.HTTPCacheService.Library;
            bool val_8 = false;
            System.Threading.Monitor.Enter(obj:  val_15, lockTaken: ref  val_8);
            val_16 = null;
            val_16 = null;
            System.Collections.Generic.Dictionary<System.UInt64, BestHTTP.Caching.HTTPCacheFileInfo> val_10 = BestHTTP.Caching.HTTPCacheService.UsedIndexes;
            val_14 = 1;
            val_12 = 1152921504644653056;
            val_10 = (val_10.ContainsKey(key:  0)) ^ 1;
            if(val_8 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_15);
            }
            
            if((val_14 == 1) || (107 != 107))
            {
                goto label_18;
            }
            
            if((val_14 & 2147483648) == 0)
            {
                    val_14 = val_14 - 1;
            }
            
            if(val_10 == true)
            {
                goto label_22;
            }
            
            goto label_37;
            label_18:
            label_22:
            System.IO.File.Delete(path:  val_3[0x0] + 32);
            label_37:
            val_13 = 1;
            label_24:
            if(val_13 < val_3.Length)
            {
                goto label_39;
            }
        
        }
    
    }

}
