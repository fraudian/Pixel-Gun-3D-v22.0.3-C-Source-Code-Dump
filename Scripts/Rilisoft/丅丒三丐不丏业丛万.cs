using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丅丒三丐不丏业丛万
    {
        // Fields
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丅丒三丐不丏业丛万> 世丒丞七专三与万丕;
        private readonly Rilisoft.七丞丞丅东丞专丙丝<long> 上丞丞不一丑东上丆;
        private readonly Rilisoft.七丞丞丅东丞专丙丝<string> 丌丌万与业且世七丙;
        private System.WeakReference 丁三上丟万万丈丝七;
        private static int 下丁与丐且与世丟丕;
        
        // Properties
        internal static Rilisoft.丅丒三丐不丏业丛万 丆丕丝丒不丙且丐丗 { get; }
        public UnityEngine.AndroidJavaObject 丅丑上丌与丏丆三万 { get; }
        public long 七丞丌丘三丑丁万丆 { get; }
        public string 丌丏万业丟丛丂三东 { get; }
        
        // Methods
        private 丅丒三丐不丏业丛万()
        {
            this.上丞丞不一丑东上丆 = new Rilisoft.七丞丞丅东丞专丙丝<System.Int64>(丙丂丌且丌世丒丐三:  new System.Func<System.Int64>(object:  0, method:  static System.Int64 Rilisoft.丅丒三丐不丏业丛万::丙丙丛丕丑一世专丑()));
            this.丌丌万与业且世七丙 = new Rilisoft.七丞丞丅东丞专丙丝<System.String>(丙丂丌且丌世丒丐三:  new System.Func<System.String>(object:  0, method:  static System.String Rilisoft.丅丒三丐不丏业丛万::专丛丄丛丅世丒丒丛()));
        }
        internal static Rilisoft.丅丒三丐不丏业丛万 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.丅丒三丐不丏业丛万.世丒丞七专三与万丕 != null)
            {
                    return Rilisoft.丅丒三丐不丏业丛万.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.丅丒三丐不丏业丛万.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
        }
        internal static int 丙丄丄上上丆丐丘丄()
        {
            var val_10;
            var val_11 = null;
            if(Rilisoft.丅丒三丐不丏业丛万.下丁与丐且与世丟丕 == 0)
            {
                    object[] val_7 = new object[2];
                val_7[0] = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().丈丌丐专丘下丘世丂();
                val_7[1] = 0;
                val_10 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下().Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_7);
                val_11 = null;
                Rilisoft.丅丒三丐不丏业丛万.下丁与丐且与世丟丕 = val_10.Get<System.Int32>(fieldName:  "versionCode");
            }
            
            val_11 = null;
            return (int)Rilisoft.丅丒三丐不丏业丛万.下丁与丐且与世丟丕;
        }
        public UnityEngine.AndroidJavaObject 且丄业丈丞丘丛业下()
        {
            System.WeakReference val_5;
            object val_6;
            val_5 = this;
            if((this.丁三上丟万万丈丝七 != null) && ((this.丁三上丟万万丈丝七 & 1) != 0))
            {
                    val_5 = this.丁三上丟万万丈丝七;
                val_6 = 0;
                return (UnityEngine.AndroidJavaObject);
            }
            
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            val_6 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_6 != null)
            {
                    new System.WeakReference() = new System.WeakReference(target:  val_6, trackResurrection:  false);
                this.丁三上丟万万丈丝七 = new System.WeakReference();
                return (UnityEngine.AndroidJavaObject);
            }
            
            this.丁三上丟万万丈丝七 = 0;
            return (UnityEngine.AndroidJavaObject);
        }
        public long 世不丂与丝一万世丌()
        {
            if(this.上丞丞不一丑东上丆 != null)
            {
                    return this.上丞丞不一丑东上丆.世三丞丅丑丌丈丈一();
            }
            
            return this.上丞丞不一丑东上丆.世三丞丅丑丌丈丈一();
        }
        public string 丈丌丐专丘下丘世丂()
        {
            if(this.丌丌万与业且世七丙 != null)
            {
                    return this.丌丌万与业且世七丙.世三丞丅丑丌丈丈一();
            }
            
            return this.丌丌万与业且世七丙.世三丞丅丑丌丈丈一();
        }
        public byte[] 丒丆专上下东丟丆丛()
        {
            object val_23;
            var val_24;
            System.Func<System.Byte[]> val_26;
            var val_27;
            var val_28;
            var val_29;
            System.Func<UnityEngine.AndroidJavaObject, System.Byte[]> val_31;
            var val_32;
            System.Func<System.Byte[], System.Boolean> val_34;
            var val_35;
            string val_38;
            val_23 = this;
            val_24 = null;
            val_24 = null;
            val_26 = 丅丒三丐不丏业丛万.<>c.<>9__15_0;
            if(val_26 == null)
            {
                    System.Func<System.Byte[]> val_1 = null;
                val_26 = val_1;
                val_1 = new System.Func<System.Byte[]>(object:  丅丒三丐不丏业丛万.<>c.__il2cppRuntimeField_static_fields, method:  System.Byte[] 丅丒三丐不丏业丛万.<>c::丞世丝丌丌东丐丑且());
                丅丒三丐不丏业丛万.<>c.<>9__15_0 = val_26;
            }
            
            Rilisoft.七丞丞丅东丞专丙丝<System.Byte[]> val_2 = null;
            val_27 = val_2;
            val_2 = new Rilisoft.七丞丞丅东丞专丙丝<System.Byte[]>(丙丂丌且丌世丒丐三:  val_1);
            if(UnityEngine.Application.platform != 11)
            {
                goto label_6;
            }
            
            val_28 = 1152921516267089008;
            UnityEngine.AndroidJavaObject val_6 = this.且丄业丈丞丘丛业下().Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
            if(val_6 == null)
            {
                goto label_8;
            }
            
            object[] val_7 = new object[2];
            val_7[0] = this.丈丌丐专丘下丘世丂();
            val_23 = 64;
            val_7[1] = val_23;
            UnityEngine.AndroidJavaObject val_9 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_7);
            if(val_9 == null)
            {
                goto label_16;
            }
            
            UnityEngine.AndroidJavaObject[] val_10 = val_9.Get<UnityEngine.AndroidJavaObject[]>(fieldName:  "signatures");
            if(val_10 == null)
            {
                goto label_17;
            }
            
            System.Security.Cryptography.SHA1Managed val_11 = new System.Security.Cryptography.SHA1Managed();
            val_29 = null;
            val_29 = null;
            val_31 = 丅丒三丐不丏业丛万.<>c.<>9__15_1;
            if(val_31 == null)
            {
                    val_31 = null;
                val_31 = new System.Func<UnityEngine.AndroidJavaObject, System.Byte[]>(object:  丅丒三丐不丏业丛万.<>c.__il2cppRuntimeField_static_fields, method:  System.Byte[] 丅丒三丐不丏业丛万.<>c::丂丕丈丒丒丏丕丙下(UnityEngine.AndroidJavaObject 丏丛与丅丛丌万专丌));
                丅丒三丐不丏业丛万.<>c.<>9__15_1 = val_31;
            }
            
            val_32 = null;
            val_32 = null;
            val_34 = 丅丒三丐不丏业丛万.<>c.<>9__15_2;
            if(val_34 == null)
            {
                    val_34 = null;
                val_34 = new System.Func<System.Byte[], System.Boolean>(object:  丅丒三丐不丏业丛万.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅丒三丐不丏业丛万.<>c::丒丌丑丙东一丘丂丙(byte[] 丏丛与丅丛丌万专丌));
                丅丒三丐不丏业丛万.<>c.<>9__15_2 = val_34;
            }
            
            System.Func<System.Byte[], System.Byte[]> val_16 = new System.Func<System.Byte[], System.Byte[]>(object:  val_11, method:  public System.Byte[] System.Security.Cryptography.HashAlgorithm::ComputeHash(byte[] buffer));
            val_35 = System.Linq.Enumerable.FirstOrDefault<System.Byte[]>(source:  System.Linq.Enumerable.Select<System.Byte[], System.Byte[]>(source:  System.Linq.Enumerable.Where<System.Byte[]>(source:  System.Linq.Enumerable.Select<UnityEngine.AndroidJavaObject, System.Byte[]>(source:  val_10, selector:  null), predicate:  null), selector:  null));
            if(val_35 == null)
            {
                    val_35 = val_2.世三丞丅丑丌丈丈一();
            }
            
            val_27 = 0;
            if(val_11 == null)
            {
                goto label_53;
            }
            
            label_52:
            var val_23 = 0;
            val_23 = val_23 + 1;
            goto label_34;
            label_6:
            val_35 = val_2.世三丞丅丑丌丈丈一();
            return (System.Byte[])val_35;
            label_34:
            val_11.Dispose();
            label_53:
            if(0 != 1)
            {
                    return (System.Byte[])val_35;
            }
            
            if(val_27 == 0)
            {
                    return (System.Byte[])val_35;
            }
            
            return (System.Byte[])val_35;
            label_8:
            val_38 = "getPackageManager() == null";
            goto label_40;
            label_16:
            val_38 = "getPackageInfo() == null";
            goto label_40;
            label_17:
            val_38 = "signatures() == null";
            label_40:
            null = new System.InvalidOperationException(message:  val_38);
            if(0 != 1)
            {
                goto label_51;
            }
            
            if(64 != 0)
            {
                goto label_52;
            }
            
            goto label_53;
            label_51:
        }
        public string 丙上丈丛丏东丈丒专()
        {
            object val_10;
            int val_11;
            if(UnityEngine.Application.platform != 11)
            {
                goto label_12;
            }
            
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.ads.identifier.AdvertisingIdClient");
            UnityEngine.AndroidJavaObject val_3 = this.且丄业丈丞丘丛业下();
            if(val_3 == null)
            {
                goto label_2;
            }
            
            object[] val_4 = new object[1];
            val_4[0] = val_3;
            val_10 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getAdvertisingIdInfo", args:  val_4);
            if(val_10 == null)
            {
                goto label_7;
            }
            
            if((val_10.Call<System.String>(methodName:  "getId", args:  System.Array.Empty<System.Object>())) != null)
            {
                    return (string)val_11;
            }
            
            goto label_12;
            label_2:
            val_10 = System.String.Format(format:  "Failed to get Android advertising id: {0} == null", arg0:  "currentActivity");
            UnityEngine.Debug.LogWarning(message:  val_10);
            goto label_12;
            label_7:
            val_10 = System.String.Format(format:  "Failed to get Android advertising id: {0} == null", arg0:  "adInfo");
            UnityEngine.Debug.LogWarning(message:  val_10);
            label_12:
            val_11 = System.String.alignConst;
            return (string)val_11;
        }
        private static long 丙丙丛丕丑一世专丑()
        {
            var val_12;
            var val_13;
            string val_15;
            val_13 = 0;
            if(UnityEngine.Application.isEditor == true)
            {
                    return (long)val_9.Get<System.Int64>(fieldName:  "firstInstallTime");
            }
            
            val_12 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下().Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
            if(val_12 == null)
            {
                goto label_6;
            }
            
            object[] val_6 = new object[2];
            val_6[0] = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().丈丌丐专丘下丘世丂();
            val_6[1] = 0;
            UnityEngine.AndroidJavaObject val_9 = val_12.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_6);
            if(val_9 == null)
            {
                goto label_17;
            }
            
            return (long)val_9.Get<System.Int64>(fieldName:  "firstInstallTime");
            label_6:
            val_15 = "getPackageManager() == null";
            goto label_18;
            label_17:
            val_15 = "getPackageInfo() == null";
            label_18:
            null = new System.InvalidOperationException(message:  val_15);
        }
        internal static int 丞三丅丈上丘丕且丈()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    return 0;
            }
            
            IntPtr val_2 = UnityEngine.AndroidJNI.FindClass(name:  "android/os/Build$VERSION");
            return UnityEngine.AndroidJNI.GetStaticIntField(clazz:  val_2, fieldID:  UnityEngine.AndroidJNI.GetStaticFieldID(clazz:  val_2, name:  "SDK_INT", sig:  "I"));
        }
        private static string 专丛丄丛丅世丒丒丛()
        {
            var val_6;
            int val_7;
            if(UnityEngine.Application.isEditor != true)
            {
                    val_6 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下();
                if((val_6.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>())) != null)
            {
                    return (string)val_7;
            }
            
            }
            
            val_7 = System.String.alignConst;
            return (string)val_7;
        }
        private static 丅丒三丐不丏业丛万()
        {
            null = null;
            Rilisoft.丅丒三丐不丏业丛万.世丒丞七专三与万丕 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丅丒三丐不丏业丛万>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丅丒三丐不丏业丛万>(object:  丅丒三丐不丏业丛万.<>c.<>9, method:  Rilisoft.丅丒三丐不丏业丛万 丅丒三丐不丏业丛万.<>c::丛下不丕丏丑一丌丄()));
            Rilisoft.丅丒三丐不丏业丛万.下丁与丐且与世丟丕 = 0;
        }
    
    }

}
