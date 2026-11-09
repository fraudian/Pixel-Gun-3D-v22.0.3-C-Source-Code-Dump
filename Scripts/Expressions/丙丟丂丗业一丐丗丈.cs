using UnityEngine;

namespace Expressions
{
    internal class 丙丟丂丗业一丐丗丈 : 丛专丞与丑业丏丏世
    {
        // Methods
        private System.Type 丙丙上东东东东七丐(string 不丂专丕丐丞丄丟丄)
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        public PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗> 三一丒丐不丌业三丕(string 不丂专丕丐丞丄丟丄)
        {
            var val_8;
            var val_12;
            var val_17;
            var val_18;
            System.Type val_20;
            var val_22;
            val_20 = this.丙丙上东东东东七丐(不丂专丕丐丞丄丟丄:  不丂专丕丐丞丄丟丄);
            if((System.Type.op_Equality(left:  val_20, right:  0)) != false)
            {
                    PGCompany.丁丑丘下丒丟丆丝三<T> val_4 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  "executor for formula " + 不丂专丕丐丞丄丟丄 + " not registered", 丒专丟丞丌丐丑丕丄:  0);
                return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_16.<万丒丙丛丑七丅丂三>k__BackingField;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = 不丂专丕丐丞丄丟丄;
            object val_6 = System.Activator.CreateInstance(type:  val_20, bindingAttr:  36, binder:  0, args:  val_5, culture:  0);
            if(val_6 == null)
            {
                goto label_9;
            }
            
            if(val_6 == null)
            {
                goto label_10;
            }
            
            PGCompany.丁丑丘下丒丟丆丝三<T> val_7 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.丌丆丑三丐丆丈丛万(丒专丟丞丌丐丑丕丄:  val_6, 丏丞专丏业丗丝七丝:  0);
            val_22 = val_8;
            goto label_12;
            label_9:
            PGCompany.丁丑丘下丒丟丆丝三<T> val_11 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  "fail to create executor for formula: \'"("fail to create executor for formula: \'") + 不丂专丕丐丞丄丟丄 + "\'", 丒专丟丞丌丐丑丕丄:  0);
            val_22 = val_12;
            goto label_12;
            label_10:
            string[] val_14 = new string[5];
            val_14[0] = "fail to create executor for formula: \'";
            val_14[1] = 不丂专丕丐丞丄丟丄;
            val_14[2] = "\', registered type \'";
            val_14[3] = val_20;
            val_20 = "\' not is IExpressionExecutor";
            val_14[4] = val_20;
            PGCompany.丁丑丘下丒丟丆丝三<T> val_16 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  +val_14, 丒专丟丞丌丐丑丕丄:  0);
            val_22 = val_17;
            label_12:
            mem2[0] = val_22;
            mem2[0] = val_18;
            return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_16.<万丒丙丛丑七丅丂三>k__BackingField;
        }
        public 丙丟丂丗业一丐丗丈()
        {
        
        }
    
    }

}
