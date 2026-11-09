using UnityEngine;

namespace PGCompany
{
    internal static class 丂丑业与上丄丂且下
    {
        // Fields
        private const string 丛下且丐丒丂丗丗一 = "::";
        
        // Methods
        internal static string 丙业不丝丗丌丗世下(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            int val_5;
            if(一丗与一专丙丙丅丄 == null)
            {
                goto label_1;
            }
            
            string val_1 = PGCompany.丂丑业与上丄丂且下.丂丄丐一丟不丅丁丕(一丗与一专丙丙丅丄:  一丗与一专丙丙丅丄);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == false)
            {
                goto label_4;
            }
            
            val_5 = System.String.alignConst;
            return (string)val_5;
            label_1:
            val_5 = 0;
            return (string)val_5;
            label_4:
            var val_6 = 0;
            val_6 = val_6 + 1;
            return val_1 + "::"("::") + DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丗与一专丙丙丅丄)(DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丗与一专丙丙丅丄));
        }
        internal static bool 丂东专丙丒丏且丛丁(string 丞丕丒专一下丙业上, out string 丗不丁丐下世上丙专, out PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            object val_16;
            System.Type val_17;
            var val_18;
            var val_19;
            val_16 = 1152921555935409920;
            val_17 = 1152921555935405888;
            一丗与一专丙丙丅丄 = 0;
            丗不丁丐下世上丙专 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) == true)
            {
                    return false;
            }
            
            int val_2 = 丞丕丒专一下丙业上.IndexOf(value:  "::", comparisonType:  4);
            if(val_2 < 1)
            {
                    return false;
            }
            
            string val_3 = 丞丕丒专一下丙业上.Substring(startIndex:  0, length:  val_2);
            丗不丁丐下世上丙专 = val_3;
            val_17 = PGCompany.丂丑业与上丄丂且下.丄丂丏丁丘丕丕东业(丒丘丏上丙丟丑丕丈:  val_3);
            if((System.Type.op_Equality(left:  val_17, right:  0)) != false)
            {
                    val_16 = "unsuported identificator type \'" + 丞丕丒专一下丙业上 + "\'";
                UnityEngine.Debug.LogError(message:  val_16);
                return false;
            }
            
            val_18 = "::";
            if(("::") == null)
            {
                    val_18 = "::";
            }
            
            val_19 = "::";
            if(("::") == null)
            {
                    val_19 = "::";
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            一丗与一专丙丙丅丄 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  丞丕丒专一下丙业上.Substring(startIndex:  Length + val_2, length:  (丞丕丒专一下丙业上.Length - val_2) - Length), 丁丅丈丌丟世丗丗丟:  val_17);
            return false;
        }
        private static string 丂丄丐一丟不丅丁丕(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            System.Type val_9;
            var val_10;
            val_9 = 一丗与一专丙丙丅丄;
            if(val_9 == null)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_9 = val_9.GetType();
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_10 = "dt";
                return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_10 = "st";
                return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            if((System.Type.op_Equality(left:  val_9, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_10 = "it";
                return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_9 = "unsupported identificator type: \'"("unsupported identificator type: \'") + val_9 + "\'";
            UnityEngine.Debug.LogError(message:  val_9);
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private static System.Type 丄丂丏丁丘丕丕东业(string 丒丘丏上丙丟丑丕丈)
        {
            var val_4;
            IntPtr val_5;
            if((System.String.op_Equality(a:  丒丘丏上丙丟丑丕丈, b:  "dt")) != false)
            {
                    val_4 = null;
                val_5 = 1152921505633255424;
                return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5});
            }
            
            if((System.String.op_Equality(a:  丒丘丏上丙丟丑丕丈, b:  "st")) != false)
            {
                    val_4 = null;
                val_5 = 1152921505633521664;
                return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5});
            }
            
            if((System.String.op_Equality(a:  丒丘丏上丙丟丑丕丈, b:  "it")) == false)
            {
                    return 0;
            }
            
            val_4 = null;
            val_5 = 1152921505633308672;
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_5});
        }
    
    }

}
