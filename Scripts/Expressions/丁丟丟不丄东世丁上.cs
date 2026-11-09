using UnityEngine;

namespace Expressions
{
    internal class 丁丟丟不丄东世丁上 : 丛专丞与丑业丏丏世
    {
        // Fields
        private const string 专丝丈丛丄一且丄丝 = "Attr";
        private const string 丅七丈且丑丁一七丐 = "Item";
        private const char 丁丄丝丕丌万丈丕丄 = '\x3a';
        
        // Methods
        public PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗> 三一丒丐不丌业三丕(string 不丂专丕丐丞丄丟丄)
        {
            var val_19;
            var val_23;
            var val_27;
            var val_28;
            object val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            string val_38;
            var val_39;
            string val_41;
            var val_42;
            IntPtr val_43;
            var val_45;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  不丂专丕丐丞丄丟丄)) == false)
            {
                goto label_3;
            }
            
            val_33 = "fail to create executor for empty formula";
            val_34 = public static PGCompany.丁丑丘下丒丟丆丝三<T> PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>::世万丂丏丞与与三业(string 丏丞专丏业丗丝七丝, Expressions.丘丁七一丑丟丁专丗 丒专丟丞丌丐丑丕丄);
            goto label_4;
            label_3:
            val_32 = 0;
            val_35 = 1;
            val_36 = 0;
            goto label_5;
            label_9:
            if((不丂专丕丐丞丄丟丄.Chars[0] & 65535) == (':'))
            {
                    val_35 = 2;
                int val_4 = (val_36 > 0) ? (val_36) : (val_32);
            }
            
            val_32 = 1;
            label_5:
            if(val_32 < 不丂专丕丐丞丄丟丄.Length)
            {
                goto label_9;
            }
            
            if(val_35 == 4)
            {
                goto label_10;
            }
            
            if(val_35 != 3)
            {
                goto label_11;
            }
            
            val_37 = null;
            val_32 = 不丂专丕丐丞丄丟丄;
            goto label_22;
            label_10:
            if(不丂专丕丐丞丄丟丄 == null)
            {
                goto label_15;
            }
            
            val_38 = 不丂专丕丐丞丄丟丄.Substring(startIndex:  0, length:  val_4);
            val_39 = 不丂专丕丐丞丄丟丄.Length;
            goto label_16;
            label_11:
            val_41 = "fail to create executor for formula. unsupported formula format by terms count ({0}) \'{1}\'";
            goto label_17;
            label_15:
            val_38 = 0.Substring(startIndex:  0, length:  val_4);
            val_39 = 0.Length;
            label_16:
            val_32 = 不丂专丕丐丞丄丟丄.Substring(startIndex:  val_4 + 1, length:  val_39 + (~val_4));
            if((System.String.op_Equality(a:  val_38, b:  "Attr")) == false)
            {
                goto label_18;
            }
            
            val_42 = null;
            val_43 = 1152921505351360512;
            goto label_19;
            label_18:
            if((System.String.op_Equality(a:  val_38, b:  "Item")) == false)
            {
                goto label_20;
            }
            
            val_42 = null;
            val_43 = 1152921505351520256;
            label_19:
            label_22:
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_43});
            object[] val_16 = new object[1];
            val_16[0] = val_32;
            object val_17 = System.Activator.CreateInstance(type:  val_15, bindingAttr:  36, binder:  0, args:  val_16, culture:  0);
            if(val_17 == null)
            {
                goto label_27;
            }
            
            if(val_17 == null)
            {
                goto label_28;
            }
            
            PGCompany.丁丑丘下丒丟丆丝三<T> val_18 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.丌丆丑三丐丆丈丛万(丒专丟丞丌丐丑丕丄:  val_17, 丏丞专丏业丗丝七丝:  0);
            val_45 = val_19;
            goto label_30;
            label_27:
            PGCompany.丁丑丘下丒丟丆丝三<T> val_22 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  "fail to create executor for formula: \'"("fail to create executor for formula: \'") + 不丂专丕丐丞丄丟丄 + "\'", 丒专丟丞丌丐丑丕丄:  0);
            val_45 = val_23;
            goto label_30;
            label_28:
            string[] val_24 = new string[5];
            val_32 = val_24;
            val_32[0] = "fail to create executor for formula: \'";
            val_32[1] = 不丂专丕丐丞丄丟丄;
            val_32[2] = "\', registered type \'";
            val_32[3] = val_15;
            val_32[4] = "\' not is IExpressionExecutor";
            PGCompany.丁丑丘下丒丟丆丝三<T> val_26 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  +val_24, 丒专丟丞丌丐丑丕丄:  0);
            val_45 = val_27;
            label_30:
            mem2[0] = val_45;
            mem2[0] = val_28;
            return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_30.<万丒丙丛丑七丅丂三>k__BackingField;
            label_20:
            val_41 = "fail to create executor for formula. unsupported formula executor name ({0}) \'{1}\'";
            label_17:
            val_34 = public static PGCompany.丁丑丘下丒丟丆丝三<T> PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>::世万丂丏丞与与三业(string 丏丞专丏业丗丝七丝, Expressions.丘丁七一丑丟丁专丗 丒专丟丞丌丐丑丕丄);
            label_4:
            PGCompany.丁丑丘下丒丟丆丝三<T> val_30 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  System.String.Format(format:  val_41, arg0:  val_4, arg1:  不丂专丕丐丞丄丟丄), 丒专丟丞丌丐丑丕丄:  0);
            return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_30.<万丒丙丛丑七丅丂三>k__BackingField;
        }
        public 丁丟丟不丄东世丁上()
        {
        
        }
    
    }

}
