using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public abstract class Jsonable
    {
        // Methods
        public static System.Collections.Generic.Dictionary<string, object> unrollObjectIntoMap<T>(System.Collections.Generic.Dictionary<string, T> obj)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            label_5:
            if(((-1851785072) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            val_1.Add(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  val_5._value._obj);
            goto label_5;
            label_2:
            val_9 = 0;
            val_10 = 0;
            val_4 = __RuntimeMethodHiddenParam + 48 + 48;
            val_2 = val_3;
            val_3 = val_4;
            if((__RuntimeMethodHiddenParam + 48 + 48 + 286) == 0)
            {
                goto label_16;
            }
            
            var val_8 = __RuntimeMethodHiddenParam + 48 + 48 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_15:
            if(((__RuntimeMethodHiddenParam + 48 + 48 + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (__RuntimeMethodHiddenParam + 48 + 48 + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            val_11 = ((__RuntimeMethodHiddenParam + 48 + 48) + (((__RuntimeMethodHiddenParam + 48 + 48 + 176 + 8)) << 4)) + 296;
            label_16:
            val_4.Dispose();
            if( != 1)
            {
                    return val_1;
            }
            
            if( == 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        public static System.Collections.Generic.List<object> unrollObjectIntoList<T>(System.Collections.Generic.List<T> obj)
        {
            var val_2;
            var val_3;
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.List<System.Object> val_1 = new System.Collections.Generic.List<System.Object>();
            label_5:
            if(((-1851648448) & 1) == 0)
            {
                goto label_2;
            }
            
            val_1.Add(item:  val_3.丐丏七丌丕丗业且上());
            goto label_5;
            label_2:
            val_7 = 0;
            val_8 = 0;
            val_3 = __RuntimeMethodHiddenParam + 48 + 32;
            val_2 = val_3;
            if((__RuntimeMethodHiddenParam + 48 + 32 + 286) == 0)
            {
                goto label_14;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 48 + 32 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_13:
            if(((__RuntimeMethodHiddenParam + 48 + 32 + 176 + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 48 + 32 + 286))
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            val_9 = ((__RuntimeMethodHiddenParam + 48 + 32) + (((__RuntimeMethodHiddenParam + 48 + 32 + 176 + 8)) << 4)) + 296;
            label_14:
            val_3.Dispose();
            if( != 1)
            {
                    return val_1;
            }
            
            if( == 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        public abstract System.Collections.Generic.Dictionary<string, object> GetObjectDictionary(); // 0
        public static void CheckForErrors(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_5;
            object val_1 = 0;
            if((jsonMap.TryGetValue(key:  "error", value: out  val_1)) != true)
            {
                    return;
            }
            
            if(val_1 == 0)
            {
                    val_5 = 0;
            }
            
            new com.amazon.device.iap.cpt.AmazonException() = new System.ApplicationException(message:  (1179403647 == null) ? (val_1) : 0);
        }
        protected Jsonable()
        {
        
        }
    
    }

}
