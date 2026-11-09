using UnityEngine;

namespace Expressions
{
    internal class 且丈业东三丛丂丝丐 : 丛专丞与丑业丏丏世
    {
        // Methods
        public PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗> 三一丒丐不丌业三丕(string 不丂专丕丐丞丄丟丄)
        {
            var val_5;
            var val_9;
            var val_14;
            var val_15;
            System.Object[] val_16;
            System.Reflection.Binder val_17;
            var val_19;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object[] val_2 = new object[1];
            val_16 = val_2;
            val_16[0] = 不丂专丕丐丞丄丟丄;
            val_17 = 0;
            object val_3 = System.Activator.CreateInstance(type:  val_1, bindingAttr:  36, binder:  val_17, args:  val_2, culture:  0);
            if(val_3 == null)
            {
                goto label_7;
            }
            
            if(val_3 == null)
            {
                goto label_8;
            }
            
            PGCompany.丁丑丘下丒丟丆丝三<T> val_4 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.丌丆丑三丐丆丈丛万(丒专丟丞丌丐丑丕丄:  val_3, 丏丞专丏业丗丝七丝:  0);
            val_19 = val_5;
            goto label_10;
            label_7:
            PGCompany.丁丑丘下丒丟丆丝三<T> val_8 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  "fail to create executor for formula: \'"("fail to create executor for formula: \'") + 不丂专丕丐丞丄丟丄 + "\'", 丒专丟丞丌丐丑丕丄:  0);
            val_19 = val_9;
            goto label_10;
            label_8:
            string[] val_11 = new string[5];
            val_16 = val_11;
            if(("fail to create executor for formula: \'") == null)
            {
                    val_17 = 0;
            }
            
            if(val_11.Length == 0)
            {
                    val_17 = 0;
            }
            
            val_16[0] = "fail to create executor for formula: \'";
            if((不丂专丕丐丞丄丟丄 != null) && (不丂专丕丐丞丄丟丄 == null))
            {
                    val_17 = 0;
            }
            
            if(val_11.Length <= 1)
            {
                    val_17 = 0;
            }
            
            val_16[1] = 不丂专丕丐丞丄丟丄;
            if("\', registered type \'" == null)
            {
                    val_17 = 0;
            }
            
            if(val_11.Length <= 2)
            {
                    val_17 = 0;
            }
            
            val_16[2] = "\', registered type \'";
            if((val_1 != null) && (val_1 == null))
            {
                    val_17 = 0;
            }
            
            if(val_11.Length <= 3)
            {
                    val_17 = 0;
            }
            
            val_16[3] = val_1;
            if("\' not is IExpressionExecutor" == null)
            {
                    val_17 = 0;
            }
            
            if(val_11.Length <= 4)
            {
                    val_17 = 0;
            }
            
            val_16[4] = "\' not is IExpressionExecutor";
            PGCompany.丁丑丘下丒丟丆丝三<T> val_13 = PGCompany.丁丑丘下丒丟丆丝三<System.String>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  +val_11, 丒专丟丞丌丐丑丕丄:  0);
            val_19 = val_14;
            label_10:
            mem2[0] = val_19;
            mem2[0] = val_15;
            return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_13.<万丒丙丛丑七丅丂三>k__BackingField;
        }
        public 且丈业东三丛丂丝丐()
        {
        
        }
    
    }

}
