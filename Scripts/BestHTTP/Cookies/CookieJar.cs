using UnityEngine;

namespace BestHTTP.Cookies
{
    public static class CookieJar
    {
        // Fields
        private const int Version = 1;
        public static System.TimeSpan AccessThreshold;
        private static System.Collections.Generic.List<BestHTTP.Cookies.Cookie> Cookies;
        private static string <CookieFolder>k__BackingField;
        private static string <LibraryPath>k__BackingField;
        private static object Locker;
        private static bool _isSavingSupported;
        private static bool IsSupportCheckDone;
        private static bool Loaded;
        
        // Properties
        public static bool IsSavingSupported { get; }
        private static string CookieFolder { get; set; }
        private static string LibraryPath { get; set; }
        
        // Methods
        public static bool get_IsSavingSupported()
        {
            var val_5;
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            if(BestHTTP.Cookies.CookieJar.IsSupportCheckDone == true)
            {
                    return (bool)BestHTTP.Cookies.CookieJar._isSavingSupported;
            }
            
            bool val_2 = System.IO.File.Exists(path:  BestHTTP.HTTPManager.GetRootCacheFolder());
            val_7 = null;
            val_7 = null;
            val_5 = 0;
            BestHTTP.Cookies.CookieJar._isSavingSupported = true;
            val_6 = null;
            val_6 = null;
            BestHTTP.Cookies.CookieJar.IsSupportCheckDone = true;
            if(0 == 1)
            {
                goto label_10;
            }
            
            if((val_5 == 0) || (69 == 69))
            {
                    return (bool)BestHTTP.Cookies.CookieJar._isSavingSupported;
            }
            
            label_15:
            val_6 = null;
            return (bool)BestHTTP.Cookies.CookieJar._isSavingSupported;
            label_10:
            if(val_5 != 0)
            {
                goto label_15;
            }
            
            return (bool)BestHTTP.Cookies.CookieJar._isSavingSupported;
        }
        private static string get_CookieFolder()
        {
            null = null;
            return (string)BestHTTP.Cookies.CookieJar.<CookieFolder>k__BackingField;
        }
        private static void set_CookieFolder(string value)
        {
            null = null;
            BestHTTP.Cookies.CookieJar.<CookieFolder>k__BackingField = value;
        }
        private static string get_LibraryPath()
        {
            null = null;
            return (string)BestHTTP.Cookies.CookieJar.<LibraryPath>k__BackingField;
        }
        private static void set_LibraryPath(string value)
        {
            null = null;
            BestHTTP.Cookies.CookieJar.<LibraryPath>k__BackingField = value;
        }
        internal static void SetupFolder()
        {
            string val_10;
            var val_11 = null;
            if(BestHTTP.Cookies.CookieJar.IsSavingSupported == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  BestHTTP.Cookies.CookieJar.CookieFolder)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  BestHTTP.Cookies.CookieJar.LibraryPath)) == false)
            {
                    return;
            }
            
            }
            
            val_10 = System.IO.Path.Combine(path1:  BestHTTP.HTTPManager.GetRootCacheFolder(), path2:  "Cookies");
            BestHTTP.Cookies.CookieJar.CookieFolder = val_10;
            BestHTTP.Cookies.CookieJar.LibraryPath = System.IO.Path.Combine(path1:  BestHTTP.Cookies.CookieJar.CookieFolder, path2:  "Library");
        }
        internal static void Set(BestHTTP.HTTPResponse response)
        {
            var val_6;
            var val_15;
            var val_16;
            object val_17;
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<T> val_25;
            var val_26;
            int val_10 = 0;
            if(response == null)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            val_17 = BestHTTP.Cookies.CookieJar.Locker;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  val_17, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Maintain();
            val_18 = null;
            val_18 = new System.Collections.Generic.List<BestHTTP.Cookies.Cookie>();
            System.Collections.Generic.List<System.String> val_3 = response.GetHeaderValues(name:  "set-cookie");
            if(val_3 == null)
            {
                goto label_6;
            }
            
            List.Enumerator<T> val_4 = val_3.GetEnumerator();
            val_15 = 1;
            label_43:
            if((1998499312 & 1) == 0)
            {
                goto label_7;
            }
            
            BestHTTP.Cookies.Cookie val_9 = BestHTTP.Cookies.Cookie.Parse(header:  val_6.丐丏七丌丕丗业且上(), defaultDomain:  response.baseRequest.CurrentUri);
            if(val_9 == null)
            {
                goto label_43;
            }
            
            if(((System.String.IsNullOrEmpty(value:  val_9.<Value>k__BackingField)) == true) || (val_9.WillExpireInTheFuture() == false))
            {
                goto label_13;
            }
            
            if((BestHTTP.Cookies.CookieJar.Find(cookie:  val_9, idx: out  val_10)) == null)
            {
                goto label_14;
            }
            
            val_9.<Date>k__BackingField = val_11.<Date>k__BackingField;
            val_19 = null;
            val_19 = null;
            BestHTTP.Cookies.CookieJar.Cookies.set_Item(index:  0, value:  val_9);
            null.Add(item:  val_9);
            goto label_43;
            label_13:
            if(val_10 == 1)
            {
                goto label_43;
            }
            
            val_20 = null;
            val_20 = null;
            BestHTTP.Cookies.CookieJar.Cookies.RemoveAt(index:  0);
            goto label_43;
            label_14:
            val_21 = null;
            val_21 = null;
            BestHTTP.Cookies.CookieJar.Cookies.Add(item:  val_9);
            null.Add(item:  val_9);
            goto label_43;
            label_6:
            val_24 = 0;
            val_25 = 0;
            goto label_60;
            label_7:
            val_17 = val_17;
            val_26 = 0;
            val_25 = 0;
            goto label_45;
            label_46:
            val_22 = 123444064;
            val_23 = 8;
            if( != )
            {
                goto label_52;
            }
            
            val_25 = ;
            val_26 = 0;
            label_45:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_26 != 1) && (251 == 251))
            {
                    val_26 = 0;
            }
            else
            {
                    if(val_25 != 0)
            {
                    val_25 = 0;
            }
            
            }
            
            response.Cookies = ;
            val_24 = 1;
            goto label_60;
            label_52:
            val_25 = 0;
            val_24 = 0;
            label_72:
            val_18 = 1;
            if( != 1)
            {
                goto label_62;
            }
            
            if((null & 1) == 0)
            {
                goto label_59;
            }
            
            val_24 = val_24 + 1;
            mem2[0] = 273;
            goto label_60;
            label_59:
            mem[8] = ;
            goto label_46;
            label_62:
            if( != val_18)
            {
                goto label_72;
            }
            
            val_25 = mem[8];
            label_60:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  null);
            }
            
            if(val_24 != 1)
            {
                    if(val_25 == 0)
            {
                    return;
            }
            
                if(251 == 273)
            {
                    return;
            }
            
                return;
            }
            
            if(val_25 != 0)
            {
                    return;
            }
        
        }
        internal static void Maintain()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_28;
            var val_29;
            val_14 = null;
            val_14 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            val_15 = 0;
            val_16 = 0;
            goto label_18;
            label_23:
            val_17 = null;
            val_17 = null;
            BestHTTP.Cookies.Cookie val_2 = BestHTTP.Cookies.CookieJar.Cookies.Item[0];
            if(val_2.WillExpireInTheFuture() == false)
            {
                goto label_8;
            }
            
            val_18 = null;
            val_18 = null;
            System.DateTime val_4 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_2.<LastAccess>k__BackingField}, t:  new System.TimeSpan() {_ticks = BestHTTP.Cookies.CookieJar.AccessThreshold});
            System.DateTime val_5 = System.DateTime.UtcNow;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_4.dateData}, t2:  new System.DateTime() {dateData = val_5.dateData})) == false)
            {
                goto label_14;
            }
            
            label_8:
            val_19 = null;
            val_19 = null;
            BestHTTP.Cookies.CookieJar.Cookies.RemoveAt(index:  0);
            goto label_18;
            label_14:
            if((val_2.<IsSession>k__BackingField) != true)
            {
                    val_16 = val_2.GuessSize() + val_16;
            }
            
            val_15 = 1;
            label_18:
            val_20 = null;
            val_20 = null;
            val_21 = BestHTTP.Cookies.CookieJar.Cookies;
            if(val_15 < val_21.Count)
            {
                goto label_23;
            }
            
            val_22 = 1998657376;
            if(val_16 <= BestHTTP.HTTPManager.CookieJarSize)
            {
                goto label_43;
            }
            
            val_23 = null;
            val_23 = null;
            BestHTTP.Cookies.CookieJar.Cookies.Sort();
            goto label_30;
            label_42:
            val_24 = null;
            val_24 = null;
            if(BestHTTP.Cookies.CookieJar.Cookies.Count < 1)
            {
                goto label_43;
            }
            
            val_25 = null;
            val_25 = null;
            val_21 = BestHTTP.Cookies.CookieJar.Cookies;
            val_21.RemoveAt(index:  0);
            val_16 = val_16 - BestHTTP.Cookies.CookieJar.Cookies.Item[0].GuessSize();
            label_30:
            if(val_16 > BestHTTP.HTTPManager.CookieJarSize)
            {
                goto label_42;
            }
            
            label_43:
            val_28 = 0;
            val_29 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if( == 212)
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
        internal static void Persist()
        {
            var val_11;
            var val_12;
            var val_15;
            var val_16;
            var val_21;
            var val_22;
            var val_23;
            object val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            BestHTTP.Cookies.CookieJar val_29;
            var val_30;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_22 = null;
            if(BestHTTP.Cookies.CookieJar.IsSavingSupported == false)
            {
                    return;
            }
            
            val_23 = null;
            val_23 = null;
            val_24 = BestHTTP.Cookies.CookieJar.Locker;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  val_24, lockTaken: ref  val_2);
            val_25 = null;
            val_25 = null;
            if(BestHTTP.Cookies.CookieJar.Loaded == false)
            {
                goto label_8;
            }
            
            BestHTTP.Cookies.CookieJar.Maintain();
            if((System.IO.Directory.Exists(path:  BestHTTP.Cookies.CookieJar.CookieFolder)) != true)
            {
                    System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  BestHTTP.Cookies.CookieJar.CookieFolder);
            }
            
            new System.IO.FileStream() = new System.IO.FileStream(path:  BestHTTP.Cookies.CookieJar.LibraryPath, mode:  2);
            new System.IO.BinaryWriter() = new System.IO.BinaryWriter(output:  new System.IO.FileStream());
            val_26 = null;
            val_26 = null;
            val_21 = 1152921553646352912;
            List.Enumerator<T> val_10 = BestHTTP.Cookies.CookieJar.Cookies.GetEnumerator();
            var val_18 = val_11;
            val_27 = 0;
            goto label_20;
            label_22:
            string val_13 = val_12.丐丏七丌丕丗业且上();
            val_18 = val_18 ^ 1;
            val_27 = val_27 + val_18;
            label_20:
            if((1998810384 & 1) != 0)
            {
                goto label_22;
            }
            
            val_28 = 0;
            val_29 = 0;
            goto label_23;
            label_8:
            val_30 = 0;
            val_29 = 0;
            goto label_100;
            label_23:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || (265 != 153))
            {
                goto label_37;
            }
            
            val_28 = 0;
            if(X22 != 0)
            {
                goto label_41;
            }
            
            goto label_39;
            label_37:
            if( != 0)
            {
                    val_29 = 0;
            }
            
            if(X22 != 0)
            {
                goto label_41;
            }
            
            label_39:
            label_41:
            val_32 = null;
            val_32 = null;
            List.Enumerator<T> val_14 = BestHTTP.Cookies.CookieJar.Cookies.GetEnumerator();
            label_48:
            if((1998810384 & 1) == 0)
            {
                goto label_45;
            }
            
            if(val_15 != 0)
            {
                goto label_48;
            }
            
            val_16.丐丏七丌丕丗业且上().SaveTo(stream:  X22);
            goto label_48;
            label_45:
            val_34 = 0 + 1;
            mem2[0] = 226;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_34 != 1) && ((1152921553850297520 + ((0 + 1)) << 2) == 226))
            {
                    val_24 = val_24;
                var val_19 = 0;
                val_19 = val_19 ^ (val_34 >> 31);
                val_34 = val_34 + val_19;
            }
            else
            {
                    val_24 = val_24;
                if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            val_33 = val_34 + 1;
            mem2[0] = 238;
            if(X22 != 0)
            {
                goto label_61;
            }
            
            goto label_65;
            label_61:
            var val_22 = X22;
            if((X22 + 286) == 0)
            {
                goto label_69;
            }
            
            var val_20 = X22 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_68:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_67;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (X22 + 286))
            {
                goto label_68;
            }
            
            goto label_69;
            label_67:
            val_22 = val_22 + (((X22 + 176 + 8)) << 4);
            val_35 = val_22 + 296;
            label_69:
            X22.Dispose();
            label_65:
            if(( != 1) && (265 == 238))
            {
                    var val_23 = 0;
                val_23 = val_23 ^ 0;
                val_33 =  + val_23;
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            val_36 =  + 1;
            mem2[0] = 250;
            if(X20 == 0)
            {
                goto label_74;
            }
            
            var val_26 = X20;
            if((X20 + 286) == 0)
            {
                goto label_78;
            }
            
            var val_24 = X20 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_77:
            if(((X20 + 176 + 8) + -8) == null)
            {
                goto label_76;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < (X20 + 286))
            {
                goto label_77;
            }
            
            goto label_78;
            label_76:
            val_26 = val_26 + (((X20 + 176 + 8)) << 4);
            val_37 = val_26 + 296;
            label_78:
            X20.Dispose();
            label_74:
            if((val_36 != 1) && ((1152921553850297520 + ((val_33 + 1)) << 2) == 250))
            {
                    var val_27 = 0;
                val_27 = val_27 ^ (val_36 >> 31);
                val_36 = val_36 + val_27;
            }
            else
            {
                    if(val_29 != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            val_30 = val_36 + 1;
            mem2[0] = 265;
            label_100:
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  null);
            }
            
            if(val_30 != 1)
            {
                    if(val_29 == 0)
            {
                    return;
            }
            
                if((1152921553850297520 + (((val_33 + 1) + 1)) << 2) == 265)
            {
                    return;
            }
            
                return;
            }
            
            if(val_29 != 0)
            {
                    return;
            }
        
        }
        internal static void Load()
        {
            object val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_17 = null;
            if(BestHTTP.Cookies.CookieJar.IsSavingSupported == false)
            {
                    return;
            }
            
            val_18 = null;
            val_18 = null;
            val_16 = BestHTTP.Cookies.CookieJar.Locker;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  val_16, lockTaken: ref  val_2);
            val_19 = null;
            val_19 = null;
            if(BestHTTP.Cookies.CookieJar.Loaded == false)
            {
                goto label_8;
            }
            
            val_20 = 0;
            val_21 = 0;
            goto label_102;
            label_8:
            BestHTTP.Cookies.CookieJar.SetupFolder();
            val_22 = null;
            val_22 = null;
            BestHTTP.Cookies.CookieJar.Cookies.Clear();
            if((System.IO.Directory.Exists(path:  BestHTTP.Cookies.CookieJar.CookieFolder)) != true)
            {
                    System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  BestHTTP.Cookies.CookieJar.CookieFolder);
            }
            
            if((System.IO.File.Exists(path:  BestHTTP.Cookies.CookieJar.LibraryPath)) == false)
            {
                goto label_20;
            }
            
            new System.IO.FileStream() = new System.IO.FileStream(path:  BestHTTP.Cookies.CookieJar.LibraryPath, mode:  3);
            new System.IO.BinaryReader() = new System.IO.BinaryReader(input:  new System.IO.FileStream());
            if(new System.IO.BinaryReader() >= 1)
            {
                    var val_14 = 0;
                do
            {
                new BestHTTP.Cookies.Cookie() = new BestHTTP.Cookies.Cookie();
                new BestHTTP.Cookies.Cookie().LoadFrom(stream:  new System.IO.BinaryReader());
                if(new BestHTTP.Cookies.Cookie().WillExpireInTheFuture() != false)
            {
                    val_23 = null;
                val_23 = null;
                BestHTTP.Cookies.CookieJar.Cookies.Add(item:  new BestHTTP.Cookies.Cookie());
            }
            
                val_14 = val_14 + 1;
            }
            while(val_14 < new System.IO.BinaryReader());
            
            }
            
            val_24 = 0;
            val_21 = 0;
            if(new System.IO.BinaryReader() != null)
            {
                goto label_32;
            }
            
            goto label_51;
            label_20:
            val_20 = 0;
            val_21 = 0;
            goto label_100;
            label_32:
            var val_17 = X22;
            if((X22 + 286) == 0)
            {
                goto label_55;
            }
            
            var val_15 = X22 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_54:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_53;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (X22 + 286))
            {
                goto label_54;
            }
            
            goto label_55;
            label_53:
            val_17 = val_17 + (((X22 + 176 + 8)) << 4);
            val_25 = val_17 + 296;
            label_55:
            X22.Dispose();
            label_51:
            if(( != 1) && (234 == 190))
            {
                    val_24 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_21 = 0;
            }
            
            }
            
            val_26 = 0 + 1;
            mem2[0] = 202;
            if(X21 == 0)
            {
                goto label_62;
            }
            
            var val_20 = X21;
            if((X21 + 286) == 0)
            {
                goto label_66;
            }
            
            var val_18 = X21 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_65:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_64;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X21 + 286))
            {
                goto label_65;
            }
            
            goto label_66;
            label_64:
            val_20 = val_20 + (((X21 + 176 + 8)) << 4);
            val_27 = val_20 + 296;
            label_66:
            X21.Dispose();
            label_62:
            if((val_26 != 1) && ((1152921553850480320 + ((0 + 1)) << 2) == 202))
            {
                    var val_21 = 0;
                val_21 = val_21 ^ (val_26 >> 31);
                val_26 = val_26 + val_21;
            }
            else
            {
                    if(val_21 != 0)
            {
                    val_21 = 0;
            }
            
            }
            
            val_20 = val_26 + 1;
            mem2[0] = 234;
            label_100:
            val_28 = null;
            val_28 = null;
            BestHTTP.Cookies.CookieJar.Loaded = true;
            if(val_20 == 1)
            {
                goto label_73;
            }
            
            if(val_21 == 0)
            {
                goto label_102;
            }
            
            if((1152921553850480320 + (((0 + 1) + 1)) << 2) != 234)
            {
                goto label_75;
            }
            
            goto label_102;
            label_73:
            if(val_21 == 0)
            {
                goto label_77;
            }
            
            label_75:
            val_21 = 0;
            goto label_102;
            label_77:
            val_20 = 0;
            label_102:
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_16);
            }
            
            if(val_20 != 1)
            {
                    if(val_21 == 0)
            {
                    return;
            }
            
                if(234 == 234)
            {
                    return;
            }
            
                return;
            }
            
            if(val_21 != 0)
            {
                    return;
            }
        
        }
        public static System.Collections.Generic.List<BestHTTP.Cookies.Cookie> Get(System.Uri uri)
        {
            var val_10;
            var val_11;
            System.Collections.Generic.List<BestHTTP.Cookies.Cookie> val_12;
            var val_13;
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = null;
            val_10 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            val_11 = 0;
            val_12 = 0;
            goto label_5;
            label_23:
            val_13 = null;
            val_13 = null;
            BestHTTP.Cookies.Cookie val_2 = BestHTTP.Cookies.CookieJar.Cookies.Item[0];
            if(val_2.WillExpireInTheFuture() != false)
            {
                    val_14 = val_2.<Domain>k__BackingField;
                if((uri.Host.IndexOf(value:  val_14)) != 1)
            {
                    val_14 = val_2.<Path>k__BackingField;
                if((uri.AbsolutePath.StartsWith(value:  val_14)) != false)
            {
                    if(val_12 == 0)
            {
                    val_12 = null;
                val_12 = new System.Collections.Generic.List<BestHTTP.Cookies.Cookie>();
            }
            
                null.Add(item:  val_2);
            }
            
            }
            
            }
            
            val_11 = 1;
            label_5:
            val_15 = null;
            val_15 = null;
            if(val_11 < BestHTTP.Cookies.CookieJar.Cookies.Count)
            {
                goto label_23;
            }
            
            val_16 = 0;
            val_17 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if( != 1)
            {
                    return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>);
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>);
            }
            
            return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>);
        }
        public static void Set(System.Uri uri, BestHTTP.Cookies.Cookie cookie)
        {
            BestHTTP.Cookies.CookieJar.Set(cookie:  cookie);
        }
        public static void Set(BestHTTP.Cookies.Cookie cookie)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            int val_2 = 0;
            val_4 = null;
            val_4 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            BestHTTP.Cookies.Cookie val_3 = BestHTTP.Cookies.CookieJar.Find(cookie:  cookie, idx: out  val_2);
            val_5 = null;
            if((val_2 & 2147483648) == 0)
            {
                    val_6 = null;
                BestHTTP.Cookies.CookieJar.Cookies.set_Item(index:  0, value:  cookie);
            }
            else
            {
                    val_7 = null;
                BestHTTP.Cookies.CookieJar.Cookies.Add(item:  cookie);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(71 == 71)
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
        public static System.Collections.Generic.List<BestHTTP.Cookies.Cookie> GetAll()
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if(0 != 1)
            {
                    return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>)BestHTTP.Cookies.CookieJar.Cookies;
            }
            
            if(0 == 0)
            {
                    return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>)BestHTTP.Cookies.CookieJar.Cookies;
            }
            
            return (System.Collections.Generic.List<BestHTTP.Cookies.Cookie>)BestHTTP.Cookies.CookieJar.Cookies;
        }
        public static void Clear()
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            BestHTTP.Cookies.CookieJar.Cookies.Clear();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
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
        public static void Clear(System.TimeSpan olderThan)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_8 = null;
            val_8 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            val_9 = 0;
            goto label_18;
            label_22:
            val_10 = null;
            val_10 = null;
            if(BestHTTP.Cookies.CookieJar.Cookies.Item[0].WillExpireInTheFuture() == false)
            {
                goto label_10;
            }
            
            System.DateTime val_4 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_2.<Date>k__BackingField}, t:  new System.TimeSpan() {_ticks = olderThan._ticks});
            System.DateTime val_5 = System.DateTime.UtcNow;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_4.dateData}, t2:  new System.DateTime() {dateData = val_5.dateData})) == false)
            {
                goto label_14;
            }
            
            label_10:
            val_11 = null;
            val_11 = null;
            BestHTTP.Cookies.CookieJar.Cookies.RemoveAt(index:  0);
            goto label_18;
            label_14:
            val_9 = 1;
            label_18:
            val_12 = null;
            val_12 = null;
            if(val_9 < BestHTTP.Cookies.CookieJar.Cookies.Count)
            {
                goto label_22;
            }
            
            val_13 = 0;
            val_14 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public static void Clear(string domain)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = null;
            val_6 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            val_7 = 0;
            goto label_17;
            label_21:
            val_8 = null;
            val_8 = null;
            if(BestHTTP.Cookies.CookieJar.Cookies.Item[0].WillExpireInTheFuture() != false)
            {
                    if((val_2.<Domain>k__BackingField.IndexOf(value:  domain)) == 1)
            {
                goto label_13;
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            BestHTTP.Cookies.CookieJar.Cookies.RemoveAt(index:  0);
            goto label_17;
            label_13:
            val_7 = 1;
            label_17:
            val_10 = null;
            val_10 = null;
            if(val_7 < BestHTTP.Cookies.CookieJar.Cookies.Count)
            {
                goto label_21;
            }
            
            val_11 = 0;
            val_12 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public static void Remove(System.Uri uri, string name)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = null;
            val_7 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  BestHTTP.Cookies.CookieJar.Locker, lockTaken: ref  val_1);
            BestHTTP.Cookies.CookieJar.Load();
            val_8 = 0;
            goto label_18;
            label_22:
            val_9 = null;
            val_9 = null;
            BestHTTP.Cookies.Cookie val_2 = BestHTTP.Cookies.CookieJar.Cookies.Item[0];
            if(((val_2.<Name>k__BackingField.Equals(value:  name, comparisonType:  5)) != false) && ((uri.Host.IndexOf(value:  val_2.<Domain>k__BackingField)) != 1))
            {
                    val_10 = null;
                val_10 = null;
                BestHTTP.Cookies.CookieJar.Cookies.RemoveAt(index:  0);
            }
            else
            {
                    val_8 = 1;
            }
            
            label_18:
            val_11 = null;
            val_11 = null;
            if(val_8 < BestHTTP.Cookies.CookieJar.Cookies.Count)
            {
                goto label_22;
            }
            
            val_12 = 0;
            val_13 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  BestHTTP.Cookies.CookieJar.Locker);
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private static BestHTTP.Cookies.Cookie Find(BestHTTP.Cookies.Cookie cookie, out int idx)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = 0;
            goto label_1;
            label_10:
            val_5 = null;
            val_5 = null;
            val_6 = BestHTTP.Cookies.CookieJar.Cookies.Item[0];
            if((val_6.Equals(cookie:  cookie)) == true)
            {
                goto label_6;
            }
            
            val_4 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            if(val_4 < BestHTTP.Cookies.CookieJar.Cookies.Count)
            {
                goto label_10;
            }
            
            val_6 = 0;
            label_6:
            idx = 0;
            return (BestHTTP.Cookies.Cookie)val_6;
        }
        private static CookieJar()
        {
            System.TimeSpan val_1 = System.TimeSpan.FromDays(value:  7);
            BestHTTP.Cookies.CookieJar.AccessThreshold = val_1._ticks;
            BestHTTP.Cookies.CookieJar.Cookies = new System.Collections.Generic.List<BestHTTP.Cookies.Cookie>();
            BestHTTP.Cookies.CookieJar.Locker = new System.Object();
        }
    
    }

}
