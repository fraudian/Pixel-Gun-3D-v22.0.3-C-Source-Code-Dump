using UnityEngine;

namespace PGCompany.AttributeSystem.Comparators
{
    internal class 丏丗丛不丁丆不丌且<T> : IEqualityComparer<PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T>>
    {
        // Methods
        public bool Equals(PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> 三丟东丕丄丄下下丑, PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> 丒丒丄丁且丄丆丂丌)
        {
            var val_5;
            PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> val_6;
            object val_7;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = 三丟东丕丄丄下下丑;
            if(val_6 == 丒丒丄丁且丄丆丂丌)
            {
                goto label_1;
            }
            
            val_7 = 0;
            if((val_6 == null) || (丒丒丄丁且丄丆丂丌 == null))
            {
                goto label_11;
            }
            
            if(((System.Type.op_Inequality(left:  val_6.GetType(), right:  丒丒丄丁且丄丆丂丌.GetType())) == true) || (val_6 != 丒丒丄丁且丄丆丂丌))
            {
                goto label_7;
            }
            
            val_6;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            val_7 = val_6;
            bool val_4 = System.Object.Equals(objA:  val_6, objB:  丒丒丄丁且丄丆丂丌);
            goto label_11;
            label_1:
            val_7 = 1;
            goto label_11;
            label_7:
            val_7 = 0;
            label_11:
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        public int GetHashCode(PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> 万且万且丑丗且丌丆)
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 24;
        }
        public 丏丗丛不丁丆不丌且<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
