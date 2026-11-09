using UnityEngine;

namespace PGCompany
{
    internal static class 丌专一业万丂下丆丝
    {
        // Methods
        internal static System.Collections.Generic.List<PGCompany.丞东万丈七世丛七丂> 丕上丅不丌丁专东东(int 丆专且丕专丗与一丏)
        {
            var val_10;
            var val_13;
            var val_14;
            System.Collections.Generic.List<PGCompany.丞东万丈七世丛七丂> val_1 = new System.Collections.Generic.List<PGCompany.丞东万丈七世丛七丂>();
            System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
            label_24:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_10 = 0;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_10 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_4.Current);
            PGCompany.丑与一丄丒东丝丏丏 val_9 = PGCompany.丟丛丁丑一丗上万丙.七上七万丂丐世丗一(七丕上丐且丗且世丌:  1152921504628731904);
            if((val_9 == null) || ((val_9 & 1) == 0))
            {
                goto label_24;
            }
            
            val_1.Add(item:  1152921504628731904);
            goto label_24;
            label_11:
            val_13 = 0;
            val_14 = 0;
            if(val_4 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_4.Dispose();
            }
            
            if( != 1)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
    
    }

}
