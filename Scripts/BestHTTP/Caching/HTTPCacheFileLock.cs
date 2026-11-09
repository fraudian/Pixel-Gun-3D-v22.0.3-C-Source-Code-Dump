using UnityEngine;

namespace BestHTTP.Caching
{
    internal sealed class HTTPCacheFileLock
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Uri, object> FileLocks;
        private static object SyncRoot;
        
        // Methods
        internal static object Acquire(System.Uri uri)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Caching.HTTPCacheFileLock.SyncRoot, lockTaken: ref  val_1);
            val_6 = null;
            val_6 = null;
            if((BestHTTP.Caching.HTTPCacheFileLock.FileLocks.TryGetValue(key:  uri, value: out  0)) != true)
            {
                    val_7 = null;
                val_7 = null;
                new System.Object() = new System.Object();
                BestHTTP.Caching.HTTPCacheFileLock.FileLocks.Add(key:  uri, value:  new System.Object());
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Caching.HTTPCacheFileLock.SyncRoot);
            }
            
            if(0 != 1)
            {
                    return (object)new System.Object();
            }
            
            if(0 == 0)
            {
                    return (object)new System.Object();
            }
            
            return (object)new System.Object();
        }
        internal static void Remove(System.Uri uri)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Caching.HTTPCacheFileLock.SyncRoot, lockTaken: ref  val_1);
            val_5 = null;
            val_5 = null;
            if((BestHTTP.Caching.HTTPCacheFileLock.FileLocks.ContainsKey(key:  uri)) != false)
            {
                    val_6 = null;
                val_6 = null;
                bool val_3 = BestHTTP.Caching.HTTPCacheFileLock.FileLocks.Remove(key:  uri);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Caching.HTTPCacheFileLock.SyncRoot);
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
        internal static void Clear()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Caching.HTTPCacheFileLock.SyncRoot, lockTaken: ref  val_1);
            val_3 = null;
            val_3 = null;
            BestHTTP.Caching.HTTPCacheFileLock.FileLocks.Clear();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Caching.HTTPCacheFileLock.SyncRoot);
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
        public HTTPCacheFileLock()
        {
        
        }
        private static HTTPCacheFileLock()
        {
            BestHTTP.Caching.HTTPCacheFileLock.FileLocks = new System.Collections.Generic.Dictionary<System.Uri, System.Object>();
            BestHTTP.Caching.HTTPCacheFileLock.SyncRoot = new System.Object();
        }
    
    }

}
