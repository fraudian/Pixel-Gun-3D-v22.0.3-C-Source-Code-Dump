using UnityEngine;

namespace PGCompany
{
    internal static class 丗丑三与专且丘丏世
    {
        // Fields
        private const string 专丑丄世业丙丝丟七 = "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.";
        private static System.Nullable<int> 丒七业上丛丕且不不;
        
        // Methods
        internal static bool 丘丈丂丞丄丑一且丒(out int 东且丁丆丛丁丏丘且, out string 丏丞专丏业丗丝七丝)
        {
            string val_11;
            东且丁丆丛丁丏丘且 = 0;
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  "android/os/Build$VERSION");
            if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) != false)
            {
                    val_11 = "android/os/Build$VERSION";
                bool val_4 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_11, 丄丙下丝丛丒七丂丘: out  string val_3 = 丏丞专丏业丗丝七丝);
                return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_11 = "TryGetSdkVersion", 丄丙下丝丛丒七丂丘: out  val_3);
            }
            
            IntPtr val_5 = UnityEngine.AndroidJNI.GetStaticFieldID(clazz:  val_1, name:  "SDK_INT", sig:  "I");
            if((System.IntPtr.op_Equality(value1:  val_5, value2:  0)) != false)
            {
                    val_11 = "SDK_INT";
                bool val_7 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_11, 丄丙下丝丛丒七丂丘: out  val_3);
                return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_11, 丄丙下丝丛丒七丂丘: out  val_3);
            }
            
            东且丁丆丛丁丏丘且 = UnityEngine.AndroidJNI.GetStaticIntField(clazz:  val_1, fieldID:  val_5);
            return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_11, 丄丙下丝丛丒七丂丘: out  val_3);
        }
        internal static bool 丒一丁丆丕丕万且三(out int 东且丁丆丛丁丏丘且, out string 丏丞专丏业丗丝七丝)
        {
            string val_6;
            int val_4 = 0;
            东且丁丆丛丁丏丘且 = 丙东专丂世丈丏丁丂();
            val_6 = "s_cachedSdkVersion";
            bool val_3 = PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_6, 丄丙下丝丛丒七丂丘: out  string val_2 = 丏丞专丏业丗丝七丝);
             =  & 1;
            return (bool);
        }
        internal static bool 丟丅丏七下世且七业(out PGCompany.丕丑丒丐下丒丏丙世 东且丁丆丛丁丏丘且, out string 丏丞专丏业丗丝七丝)
        {
            UnityEngine.AndroidJavaClass val_16;
            string val_17;
            PGCompany.丕丑丒丐下丒丏丙世 val_18;
            var val_19;
            var val_21;
            System.Exception val_23;
            string val_24;
            val_17 = 1152921553955387312;
            val_18 = 1152921553955383296;
            int val_1 = 0;
            东且丁丆丛丁丏丘且 = 0;
            val_19 = 0;
            if((PGCompany.丗丑三与专且丘丏世.丒一丁丆丕丕万且三(东且丁丆丛丁丏丘且: out  val_1, 丏丞专丏业丗丝七丝: out  string val_2 = 丏丞专丏业丗丝七丝)) == false)
            {
                    return (bool)val_19;
            }
            
            if(val_1 <= 18)
            {
                goto label_2;
            }
            
            val_16 = new UnityEngine.AndroidJavaClass();
            val_16 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_5 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_5 == null)
            {
                goto label_4;
            }
            
            if(val_1 >= 26)
            {
                goto label_5;
            }
            
            val_19 = PGCompany.丗丑三与专且丘丏世.丑三丆丒丆丌与上丙(世丗丆丛丆且一世七:  val_5, 东且丁丆丛丁丏丘且: out  PGCompany.丕丑丒丐下丒丏丙世 val_6 = 东且丁丆丛丁丏丘且, 丏丞专丏业丗丝七丝: out  val_2);
            goto label_6;
            label_2:
            val_19 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "sdkVersion", 丄丙下丝丛丒七丂丘: out  val_2);
            return (bool)val_19;
            label_4:
            val_19 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "currentActivity", 丄丙下丝丛丒七丂丘: out  val_2);
            val_18 = 0;
            val_17 = 0;
            if(val_16 != null)
            {
                goto label_8;
            }
            
            goto label_24;
            label_5:
            val_19 = PGCompany.丗丑三与专且丘丏世.丙下专下不丗丐丅丒(世丗丆丛丆且一世七:  val_5, 东且丁丆丛丁丏丘且: out  val_6, 丏丞专丏业丗丝七丝: out  val_2);
            label_6:
            val_17 = 0;
            val_18 = 0;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_5.Dispose();
            if(val_18 == 1)
            {
                goto label_21;
            }
            
            if(val_17 == 0)
            {
                goto label_41;
            }
            
            if(144 != 144)
            {
                goto label_16;
            }
            
            goto label_41;
            label_21:
            val_18 = 0;
            if(val_17 == 0)
            {
                goto label_41;
            }
            
            label_16:
            val_17 = 0;
            label_41:
            if(val_16 == null)
            {
                goto label_24;
            }
            
            label_8:
            var val_17 = 0;
            val_17 = val_17 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
            label_24:
            if((val_18 != 1) && (144 == 144))
            {
                    return (bool)val_19;
            }
            
            if(val_17 == 0)
            {
                    val_23 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            val_24 = System.String.Format(format:  "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.", arg0:  "TryGetNotificationsEnabledStatus");
            System.AggregateException val_15 = new System.AggregateException(message:  val_24, innerException:  null);
            mem[8] = null;
            val_21 = 8;
        }
        internal static bool 且丐万丑万且丟丑丝(out string 丏丞专丏业丗丝七丝)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            System.Exception val_17;
            string val_18;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_2 == null)
            {
                goto label_2;
            }
            
            val_11 = PGCompany.丗丑三与专且丘丏世.丄丅丌不业上丙丈丘(世丗丆丛丆且一世七:  val_2, 丏丞专丏业丗丝七丝: out  string val_3 = 丏丞专丏业丗丝七丝);
            val_12 = 0;
            val_13 = 0;
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_6;
            label_2:
            val_11 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "currentActivity", 丄丙下丝丛丒七丂丘: out  val_3);
            val_13 = 0;
            val_12 = 0;
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                goto label_7;
            }
            
            goto label_18;
            label_6:
            val_2.Dispose();
            if(val_13 == 1)
            {
                goto label_15;
            }
            
            if(val_12 == 0)
            {
                goto label_35;
            }
            
            if(93 != 93)
            {
                goto label_11;
            }
            
            goto label_35;
            label_15:
            val_13 = 0;
            if(val_12 == 0)
            {
                goto label_35;
            }
            
            label_11:
            val_12 = 0;
            label_35:
            if(new UnityEngine.AndroidJavaClass() == null)
            {
                goto label_18;
            }
            
            label_7:
            var val_12 = 0;
            val_12 = val_12 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
            label_18:
            if((val_13 != 1) && (93 == 93))
            {
                    return (bool)val_11;
            }
            
            if(val_12 == 0)
            {
                    val_17 = 0;
            }
            else
            {
                    val_17 = 0;
            }
            
            val_18 = System.String.Format(format:  "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.", arg0:  "TryOpenNotificationSettings");
            System.AggregateException val_10 = new System.AggregateException(message:  val_18, innerException:  null);
            mem[8] = null;
            val_15 = 8;
        }
        internal static bool 丒丐丞丂丑东丌三丞(out string 世万丘丛万丕丘世丒, out string 丏丞专丏业丗丝七丝)
        {
            string val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_27;
            System.Exception val_32;
            string val_33;
            世万丘丛万丕丘世丒 = 0;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_2 == null)
            {
                goto label_3;
            }
            
            UnityEngine.AndroidJavaObject val_4 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getFilesDir", args:  System.Array.Empty<System.Object>());
            if(val_4 == null)
            {
                goto label_3;
            }
            
            string val_6 = val_4.Call<System.String>(methodName:  "getAbsolutePath", args:  System.Array.Empty<System.Object>());
            世万丘丛万丕丘世丒 = val_6;
            if((System.String.IsNullOrWhiteSpace(value:  val_6)) == false)
            {
                goto label_4;
            }
            
            val_22 = "IsNullOrWhiteSpace";
            bool val_9 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_22, 丄丙下丝丛丒七丂丘: out  string val_8 = 丏丞专丏业丗丝七丝);
            goto label_5;
            label_3:
            val_23 = 0;
            val_24 = 0;
            val_25 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "filesDir: null", 丄丙下丝丛丒七丂丘: out  val_8);
            if(val_2 != null)
            {
                goto label_6;
            }
            
            goto label_26;
            label_4:
            val_22 = 1;
            丏丞专丏业丗丝七丝 = 0;
            label_5:
            val_24 = 0;
            val_23 = 0;
            val_25 = val_22 & 1;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_4.Dispose();
            if(val_23 == 1)
            {
                goto label_22;
            }
            
            if(val_24 == 0)
            {
                goto label_55;
            }
            
            if(169 != 169)
            {
                goto label_15;
            }
            
            goto label_55;
            label_22:
            val_23 = 0;
            if(val_24 == 0)
            {
                goto label_55;
            }
            
            label_15:
            val_24 = 0;
            label_55:
            if(val_2 == null)
            {
                goto label_26;
            }
            
            label_6:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_2.Dispose();
            label_26:
            if(val_23 == 1)
            {
                goto label_31;
            }
            
            var val_13 = (val_25 != 0) ? 1 : 0;
            if(val_24 == 0)
            {
                goto label_61;
            }
            
            if(169 != 169)
            {
                goto label_33;
            }
            
            goto label_61;
            label_31:
            if(val_24 == 0)
            {
                goto label_35;
            }
            
            label_33:
            val_24 = 0;
            var val_15 = (val_25 != 0) ? 1 : 0;
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                goto label_36;
            }
            
            goto label_38;
            label_35:
            val_23 = 0;
            label_61:
            if(new UnityEngine.AndroidJavaClass() == null)
            {
                goto label_38;
            }
            
            label_36:
            var val_23 = 0;
            val_23 = val_23 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
            label_38:
            if((val_23 != 1) && (169 == 169))
            {
                    return (bool)(val_25 != 0) ? 1 : 0;
            }
            
            if(val_24 == 0)
            {
                    val_32 = 0;
            }
            else
            {
                    val_32 = 0;
            }
            
            val_33 = System.String.Format(format:  "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.", arg0:  "TryGetFilesDirName");
            System.InvalidOperationException val_20 = new System.InvalidOperationException(message:  val_33, innerException:  null);
            mem[8] = null;
            val_27 = 8;
        }
        internal static bool 丟丅丏七下世且七业(UnityEngine.AndroidJavaObject 世丗丆丛丆且一世七, int 世不东万专丛丈丅下, out PGCompany.丕丑丒丐下丒丏丙世 东且丁丆丛丁丏丘且, out string 丏丞专丏业丗丝七丝)
        {
            东且丁丆丛丁丏丘且 = 0;
            if(世不东万专丛丈丅下 <= 18)
            {
                    return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "sdkVersion < 19", 丄丙下丝丛丒七丂丘: out  string val_1 = 丏丞专丏业丗丝七丝);
            }
            
            if(世丗丆丛丆且一世七 != null)
            {
                    if(世不东万专丛丈丅下 < 26)
            {
                    return PGCompany.丗丑三与专且丘丏世.丑三丆丒丆丌与上丙(世丗丆丛丆且一世七:  世丗丆丛丆且一世七, 东且丁丆丛丁丏丘且: out  PGCompany.丕丑丒丐下丒丏丙世 val_2 = 东且丁丆丛丁丏丘且, 丏丞专丏业丗丝七丝: out  val_1);
            }
            
                return PGCompany.丗丑三与专且丘丏世.丙下专下不丗丐丅丒(世丗丆丛丆且一世七:  世丗丆丛丆且一世七, 东且丁丆丛丁丏丘且: out  val_2, 丏丞专丏业丗丝七丝: out  val_1);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "currentActivity");
        }
        internal static bool 且丐万丑万且丟丑丝(UnityEngine.AndroidJavaObject 世丗丆丛丆且一世七, out string 丏丞专丏业丗丝七丝)
        {
            if(世丗丆丛丆且一世七 != null)
            {
                    return PGCompany.丗丑三与专且丘丏世.丄丅丌不业上丙丈丘(世丗丆丛丆且一世七:  世丗丆丛丆且一世七, 丏丞专丏业丗丝七丝: out  string val_1 = 丏丞专丏业丗丝七丝);
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "currentActivity");
        }
        private static bool 丑三丆丒丆丌与上丙(UnityEngine.AndroidJavaObject 世丗丆丛丆且一世七, out PGCompany.丕丑丒丐下丒丏丙世 东且丁丆丛丁丏丘且, out string 丏丞专丏业丗丝七丝)
        {
            System.Exception val_12;
            var val_13;
            string val_14;
            东且丁丆丛丁丏丘且 = 0;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.workaround.NotificationHelpers");
            object[] val_2 = new object[1];
            val_2[0] = 世丗丆丛丆且一世七;
            东且丁丆丛丁丏丘且 = (((new UnityEngine.AndroidJavaClass().CallStatic<System.Boolean>(methodName:  "areNotificationsEnabled", args:  val_2)) & true) != 0) ? (1 + 1) : 1;
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            if(0 != 1)
            {
                    return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  "TryGetNotificationsEnabledStatus19_26", 丄丙下丝丛丒七丂丘: out  string val_5 = 丏丞专丏业丗丝七丝);
            }
            
            if(0 == 0)
            {
                    val_12 = 0;
            }
            else
            {
                    val_12 = 0;
            }
            
            val_14 = System.String.Format(format:  "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.", arg0:  "TryGetNotificationsEnabledStatus19_26");
            System.AggregateException val_10 = new System.AggregateException(message:  val_14, innerException:  null);
            mem[8] = null;
            val_13 = 8;
        }
        private static bool 丙下专下不丗丐丅丒(UnityEngine.AndroidJavaObject 世丗丆丛丆且一世七, out PGCompany.丕丑丒丐下丒丏丙世 东且丁丆丛丁丏丘且, out string 丏丞专丏业丗丝七丝)
        {
            var val_13;
            var val_14;
            var val_16;
            System.Exception val_17;
            string val_18;
            东且丁丆丛丁丏丘且 = 0;
            object[] val_1 = new object[1];
            val_1[0] = "notification";
            UnityEngine.AndroidJavaObject val_2 = 世丗丆丛丆且一世七.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_1);
            if(val_2 != null)
            {
                    东且丁丆丛丁丏丘且 = (((val_2.Call<System.Boolean>(methodName:  "areNotificationsEnabled", args:  System.Array.Empty<System.Object>())) & true) != 0) ? (1 + 1) : 1;
                val_13 = PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  "TryGetNotificationsEnabledStatus26", 丄丙下丝丛丒七丂丘: out  string val_6 = 丏丞专丏业丗丝七丝);
                val_14 = 0;
                var val_13 = 0;
                val_13 = val_13 + 1;
            }
            else
            {
                    val_13 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "notificationManager: null", 丄丙下丝丛丒七丂丘: out  val_6);
                return (bool)val_13;
            }
            
            val_2.Dispose();
            if((0 != 1) && (119 == 119))
            {
                    return (bool)val_13;
            }
            
            if(val_14 == 0)
            {
                    val_17 = 0;
            }
            else
            {
                    val_17 = 0;
            }
            
            val_18 = System.String.Format(format:  "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.", arg0:  "TryGetNotificationsEnabledStatus26");
            System.AggregateException val_12 = new System.AggregateException(message:  val_18, innerException:  null);
            mem[8] = null;
            val_16 = 8;
        }
        private static bool 丄丅丌不业上丙丈丘(UnityEngine.AndroidJavaObject 世丗丆丛丆且一世七, out string 丏丞专丏业丗丝七丝)
        {
            System.Object[] val_24;
            string val_25;
            var val_26;
            System.Object[] val_27;
            var val_28;
            var val_29;
            var val_31;
            System.Exception val_34;
            var val_36;
            string val_37;
            val_24 = System.Array.Empty<System.Object>();
            val_25 = 世丗丆丛丆且一世七.Call<System.String>(methodName:  "getPackageName", args:  val_24);
            if((System.String.IsNullOrWhiteSpace(value:  val_25)) != false)
            {
                    val_26 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "packageName", 丄丙下丝丛丒七丂丘: out  string val_4 = 丏丞专丏业丗丝七丝);
                return (bool)val_26;
            }
            
            val_24 = new UnityEngine.AndroidJavaClass();
            val_24 = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri");
            object[] val_7 = new object[3];
            val_27 = val_7;
            val_27[0] = "package";
            val_27[1] = val_25;
            UnityEngine.AndroidJavaObject val_8 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fromParts", args:  val_7);
            if(val_8 == null)
            {
                goto label_12;
            }
            
            object[] val_9 = new object[2];
            val_9[0] = "android.settings.APPLICATION_DETAILS_SETTINGS";
            val_9[1] = val_8;
            val_27 = new UnityEngine.AndroidJavaObject();
            val_27 = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  val_9);
            object[] val_11 = new object[1];
            val_11[0] = "android.intent.category.DEFAULT";
            UnityEngine.AndroidJavaObject val_12 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "addCategory", args:  val_11);
            object[] val_13 = new object[1];
            val_13[0] = 268435456;
            UnityEngine.AndroidJavaObject val_14 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "setFlags", args:  val_13);
            object[] val_15 = new object[1];
            val_15[0] = val_27;
            世丗丆丛丆且一世七.Call(methodName:  "startActivity", args:  val_15);
            val_28 = 0;
            val_29 = 0;
            if(val_27 == null)
            {
                goto label_90;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            goto label_38;
            label_12:
            val_26 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "uri", 丄丙下丝丛丒七丂丘: out  val_4);
            val_31 = 0;
            val_25 = 0;
            if(val_24 != null)
            {
                goto label_53;
            }
            
            goto label_56;
            label_38:
            new UnityEngine.AndroidJavaObject().Dispose();
            label_90:
            if((val_28 != 1) && (287 == 228))
            {
                    val_28 = 0;
            }
            else
            {
                    if(val_29 != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            val_26 = PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  "TryOpenNotificationSettingsCore", 丄丙下丝丛丒七丂丘: out  val_4);
            val_31 = 1;
            if(val_8 != null)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_8.Dispose();
            }
            
            if(val_31 == 1)
            {
                goto label_50;
            }
            
            if(val_29 != 0)
            {
                    if(287 != 287)
            {
                goto label_52;
            }
            
            }
            
            val_25 = val_29;
            if(val_24 != null)
            {
                goto label_53;
            }
            
            goto label_56;
            label_50:
            val_31 = 0;
            if(val_29 != 0)
            {
                    label_52:
            }
            
            val_25 = 0;
            if(val_24 == null)
            {
                goto label_56;
            }
            
            label_53:
            var val_26 = 0;
            val_26 = val_26 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
            label_56:
            if((val_31 != 1) && (287 == 287))
            {
                    return (bool)val_26;
            }
            
            if(val_25 == 0)
            {
                    val_34 = 0;
            }
            else
            {
                    val_34 = 0;
            }
            
            val_37 = System.String.Format(format:  "An AndroidJavaException occurred during a call to \'{0}\'. See InnerException for a complete description of the error.", arg0:  "TryOpenNotificationSettingsCore");
            System.AggregateException val_23 = new System.AggregateException(message:  val_37, innerException:  null);
            mem[8] = null;
            val_36 = 8;
        }
    
    }

}
