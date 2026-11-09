using UnityEngine;

namespace Expressions.Analyzer
{
    internal class 丆丕丘一丈丗丗丕丌 : 七上丝丞世专丟丗丐
    {
        // Methods
        public PGCompany.丁丑丘下丒丟丆丝三<string> 丁世丛丈丘丅丘丅专(string 不丝世不丈丏专万丅)
        {
            object val_8;
            object val_9;
            object val_10;
            if((System.String.IsNullOrEmpty(value:  不丝世不丈丏专万丅)) == true)
            {
                goto label_1;
            }
            
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            goto label_2;
            label_8:
            char val_3 = 不丝世不丈丏专万丅.Chars[0] & 65535;
            if(val_3 == ')')
            {
                goto label_4;
            }
            
            if(val_3 != '(')
            {
                goto label_6;
            }
            
            val_10 = 1;
            goto label_6;
            label_4:
            val_9 = 1;
            label_6:
            val_8 = 1;
            label_2:
            if(val_8 < 不丝世不丈丏专万丅.Length)
            {
                goto label_8;
            }
            
            if(val_10 != val_9)
            {
                goto label_9;
            }
            
            label_1:
            PGCompany.丁丑丘下丒丟丆丝三<T> val_5 = PGCompany.丁丑丘下丒丟丆丝三<System.String>.丌丆丑三丐丆丈丛万(丒专丟丞丌丐丑丕丄:  不丝世不丈丏专万丅, 丏丞专丏业丗丝七丝:  0);
            return (PGCompany.丁丑丘下丒丟丆丝三<System.String>)val_7.<万丒丙丛丑七丅丂三>k__BackingField;
            label_9:
            val_8 = val_10;
            PGCompany.丁丑丘下丒丟丆丝三<T> val_7 = PGCompany.丁丑丘下丒丟丆丝三<System.String>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  System.String.Format(format:  "brackets error! opened: {0}, closed: {1}", arg0:  val_10, arg1:  val_9), 丒专丟丞丌丐丑丕丄:  不丝世不丈丏专万丅);
            return (PGCompany.丁丑丘下丒丟丆丝三<System.String>)val_7.<万丒丙丛丑七丅丂三>k__BackingField;
        }
        public 丆丕丘一丈丗丗丕丌()
        {
        
        }
    
    }

}
