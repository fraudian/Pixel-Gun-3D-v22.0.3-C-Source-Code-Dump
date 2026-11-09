using UnityEngine;

namespace BestHTTP.Authentication
{
    public static class DigestStore
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, BestHTTP.Authentication.Digest> Digests;
        private static object Locker;
        private static string[] SupportedAlgorithms;
        
        // Methods
        public static BestHTTP.Authentication.Digest Get(System.Uri uri)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = null;
            val_6 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Authentication.DigestStore.Locker, lockTaken: ref  val_1);
            val_7 = null;
            BestHTTP.Authentication.Digest val_3 = 0;
            val_7 = null;
            if((BestHTTP.Authentication.DigestStore.Digests.TryGetValue(key:  uri.Host, value: out  val_3)) != false)
            {
                    if((val_3.IsUriProtected(uri:  uri)) == false)
            {
                goto label_9;
            }
            
            }
            
            val_8 = val_3;
            val_9 = 0;
            val_10 = 0;
            goto label_10;
            label_9:
            val_9 = 0;
            val_10 = 0;
            val_8 = 0;
            label_10:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Authentication.DigestStore.Locker);
            }
            
            if(val_9 != 1)
            {
                    if(val_10 == 0)
            {
                    return (BestHTTP.Authentication.Digest)val_8;
            }
            
                if(65 == 65)
            {
                    return (BestHTTP.Authentication.Digest)val_8;
            }
            
                return (BestHTTP.Authentication.Digest)val_8;
            }
            
            if(val_10 != 0)
            {
                    return (BestHTTP.Authentication.Digest)val_8;
            }
            
            return (BestHTTP.Authentication.Digest)val_8;
        }
        public static BestHTTP.Authentication.Digest GetOrCreate(System.Uri uri)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = null;
            val_7 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Authentication.DigestStore.Locker, lockTaken: ref  val_1);
            val_8 = null;
            val_8 = null;
            if((BestHTTP.Authentication.DigestStore.Digests.TryGetValue(key:  uri.Host, value: out  0)) != true)
            {
                    val_9 = null;
                val_9 = null;
                new BestHTTP.Authentication.Digest() = new BestHTTP.Authentication.Digest(uri:  uri);
                BestHTTP.Authentication.DigestStore.Digests.Add(key:  uri.Host, value:  new BestHTTP.Authentication.Digest());
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Authentication.DigestStore.Locker);
            }
            
            if(0 != 1)
            {
                    return (BestHTTP.Authentication.Digest)new BestHTTP.Authentication.Digest();
            }
            
            if(0 == 0)
            {
                    return (BestHTTP.Authentication.Digest)new BestHTTP.Authentication.Digest();
            }
            
            return (BestHTTP.Authentication.Digest)new BestHTTP.Authentication.Digest();
        }
        public static void Remove(System.Uri uri)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Authentication.DigestStore.Locker, lockTaken: ref  val_1);
            val_5 = null;
            val_5 = null;
            bool val_3 = BestHTTP.Authentication.DigestStore.Digests.Remove(key:  uri.Host);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Authentication.DigestStore.Locker);
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
        public static string FindBest(System.Collections.Generic.List<string> authHeaders)
        {
            var val_13;
            int val_14;
            var val_15;
            int val_16;
            if(authHeaders == null)
            {
                goto label_12;
            }
            
            val_13 = 1152921516934571616;
            if(authHeaders.Count == 0)
            {
                goto label_12;
            }
            
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>(capacity:  authHeaders.Count);
            if(authHeaders.Count >= 1)
            {
                    var val_12 = 0;
                do
            {
                val_3.Add(item:  authHeaders.Item[0].ToLower());
                val_12 = val_12 + 1;
            }
            while(val_12 < authHeaders.Count);
            
            }
            
            val_13 = 1152921505561690112;
            val_14 = 0;
            goto label_8;
            label_14:
            val_14 = ((DigestStore.<>c__DisplayClass6_0)[1152921553869938864].i) + 1;
            label_8:
            .i = val_14;
            val_15 = null;
            val_15 = null;
            if(val_14 >= BestHTTP.Authentication.DigestStore.SupportedAlgorithms.Length)
            {
                goto label_12;
            }
            
            int val_10 = val_3.FindIndex(match:  new System.Predicate<System.String>(object:  new DigestStore.<>c__DisplayClass6_0(), method:  System.Boolean DigestStore.<>c__DisplayClass6_0::<FindBest>b__0(string header)));
            if(val_10 == 1)
            {
                goto label_14;
            }
            
            string val_11 = authHeaders.Item[val_10];
            return (string)val_16;
            label_12:
            val_16 = System.String.alignConst;
            return (string)val_16;
        }
        private static DigestStore()
        {
            BestHTTP.Authentication.DigestStore.Digests = new System.Collections.Generic.Dictionary<System.String, BestHTTP.Authentication.Digest>();
            BestHTTP.Authentication.DigestStore.Locker = new System.Object();
            string[] val_3 = new string[2];
            val_3[0] = "digest";
            val_3[1] = "basic";
            BestHTTP.Authentication.DigestStore.SupportedAlgorithms = val_3;
        }
    
    }

}
