using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidTaskUtils
    {
        // Methods
        private AndroidTaskUtils()
        {
        
        }
        public static void AddOnSuccessListener<T>(UnityEngine.AndroidJavaObject task, System.Action<T> callback)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = __RuntimeMethodHiddenParam + 48;
            UnityEngine.AndroidJavaObject val_2 = task.Call<UnityEngine.AndroidJavaObject>(methodName:  "addOnSuccessListener", args:  val_1);
            if(val_2 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.Dispose();
        }
        public static void AddOnSuccessListener<T>(UnityEngine.AndroidJavaObject task, bool disposeResult, System.Action<T> callback)
        {
            object[] val_1 = new object[1];
            bool val_2 = disposeResult;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = __RuntimeMethodHiddenParam + 48;
            UnityEngine.AndroidJavaObject val_3 = task.Call<UnityEngine.AndroidJavaObject>(methodName:  "addOnSuccessListener", args:  val_1);
            if(val_3 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3.Dispose();
        }
        public static void AddOnFailureListener(UnityEngine.AndroidJavaObject task, System.Action<UnityEngine.AndroidJavaObject> callback)
        {
            object[] val_1 = new object[1];
            AndroidTaskUtils.TaskOnFailedProxy val_2 = new AndroidTaskUtils.TaskOnFailedProxy(callback:  callback);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            UnityEngine.AndroidJavaObject val_3 = task.Call<UnityEngine.AndroidJavaObject>(methodName:  "addOnFailureListener", args:  val_1);
            if(val_3 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3.Dispose();
        }
        public static void AddOnCompleteListener<T>(UnityEngine.AndroidJavaObject task, System.Action<T> callback)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = __RuntimeMethodHiddenParam + 48;
            UnityEngine.AndroidJavaObject val_2 = task.Call<UnityEngine.AndroidJavaObject>(methodName:  "addOnCompleteListener", args:  val_1);
            if(val_2 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.Dispose();
        }
    
    }

}
