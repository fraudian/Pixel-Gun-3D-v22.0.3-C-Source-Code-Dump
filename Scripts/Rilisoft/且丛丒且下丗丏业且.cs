using UnityEngine;

namespace Rilisoft
{
    internal class 且丛丒且下丗丏业且
    {
        // Methods
        internal static void 丒丄上丐丝丘丐丑且()
        {
            var val_21;
            var val_22;
            var val_23;
            System.Object[] val_24;
            System.Type[] val_1 = new System.Type[9];
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            val_1[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[2] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[3] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[4] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[5] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[6] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[7] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[8] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Collections.Generic.HashSet<System.Int32> val_11 = new System.Collections.Generic.HashSet<System.Int32>();
            val_21 = 0;
            goto label_33;
            label_67:
            UnityEngine.Debug.Log(message:  "Checking enum " + val_1[0]);
            val_11.Clear();
            System.Array val_13 = System.Enum.GetValues(enumType:  val_1[0x0] + 32);
            val_22 = 0;
            goto label_42;
            label_65:
            object val_14 = val_13.GetValue(index:  0);
            if((val_11.Contains(item:  21884928)) == false)
            {
                goto label_45;
            }
            
            val_23 = 2;
            object[] val_16 = new object[2];
            val_24 = val_16;
            if(val_21 >= val_1.Length)
            {
                    val_23 = 0;
            }
            
            if(val_24 == null)
            {
                goto label_49;
            }
            
            if((val_1[0x0] + 32) != 0)
            {
                goto label_50;
            }
            
            goto label_56;
            label_45:
            val_24 = val_13.GetValue(index:  0);
            bool val_18 = val_11.Add(item:  21884928);
            goto label_54;
            label_49:
            if((val_1[0x0] + 32) == 0)
            {
                goto label_56;
            }
            
            label_50:
            label_56:
            val_24[0] = val_1[0x0] + 32;
            object val_19 = val_13.GetValue(index:  0);
            val_24[1] = null;
            UnityEngine.Debug.LogErrorFormat(format:  "duplicate in enum {0} value {1}", args:  val_16);
            label_54:
            val_22 = 1;
            label_42:
            if(val_22 < val_13.Length)
            {
                goto label_65;
            }
            
            val_21 = 1;
            label_33:
            if(val_21 < val_1.Length)
            {
                goto label_67;
            }
        
        }
        public 且丛丒且下丗丏业且()
        {
        
        }
    
    }

}
