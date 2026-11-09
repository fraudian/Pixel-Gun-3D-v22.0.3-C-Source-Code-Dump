using UnityEngine;

namespace Expressions.Analyzer
{
    internal class 丑不一万丙丏丞丁七 : 七上丝丞世专丟丗丐
    {
        // Fields
        private static System.Text.RegularExpressions.Regex 丈丝七丙丗世下一丁;
        
        // Methods
        internal 丑不一万丙丏丞丁七()
        {
            Expressions.Analyzer.丑不一万丙丏丞丁七.丈丝七丙丗世下一丁 = new System.Text.RegularExpressions.Regex(pattern:  "((AND|OR)[\\s]*(AND|OR))");
        }
        public PGCompany.丁丑丘下丒丟丆丝三<string> 丁世丛丈丘丅丘丅专(string 不丝世不丈丏专万丅)
        {
            string val_14;
            var val_18;
            var val_19;
            if((System.String.IsNullOrEmpty(value:  不丝世不丈丏专万丅)) == true)
            {
                goto label_4;
            }
            
            val_14 = Expressions.Analyzer.丑不一万丙丏丞丁七.丈丝七丙丗世下一丁.Matches(input:  不丝世不丈丏专万丅);
            if(val_14.Count < 1)
            {
                goto label_4;
            }
            
            System.Collections.IEnumerator val_4 = val_14.GetEnumerator();
            label_20:
            val_14 = "duplicate logic operands! ";
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            object val_8 = val_4.Current;
            string val_12 = val_14 + " " + 0.Value;
            goto label_20;
            label_4:
            PGCompany.丁丑丘下丒丟丆丝三<T> val_13 = PGCompany.丁丑丘下丒丟丆丝三<System.String>.丌丆丑三丐丆丈丛万(丒专丟丞丌丐丑丕丄:  不丝世不丈丏专万丅, 丏丞专丏业丗丝七丝:  0);
            return (PGCompany.丁丑丘下丒丟丆丝三<System.String>)val_15.<万丒丙丛丑七丅丂三>k__BackingField;
            label_11:
            val_18 = 0;
            val_19 = 0;
            if(val_4 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_4.Dispose();
            }
            
            PGCompany.丁丑丘下丒丟丆丝三<T> val_15 = PGCompany.丁丑丘下丒丟丆丝三<System.String>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  val_14, 丒专丟丞丌丐丑丕丄:  不丝世不丈丏专万丅);
            return (PGCompany.丁丑丘下丒丟丆丝三<System.String>)val_15.<万丒丙丛丑七丅丂三>k__BackingField;
        }
    
    }

}
