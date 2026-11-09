using UnityEngine;

namespace Expressions
{
    internal class 七上丈丂与丝丛丑七
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<string, Expressions.丘丁七一丑丟丁专丗> 丆丘七丒丁丐丛东丐;
        private readonly System.Collections.Generic.Dictionary<System.Type, Expressions.丝丟丌丙丘丕不丕丐> 丐专丂丁与且丁且丂;
        private static Expressions.七上丈丂与丝丛丑七 丝业丆丁业三丈丟东;
        
        // Properties
        internal static Expressions.七上丈丂与丝丛丑七 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static Expressions.七上丈丂与丝丛丑七 丑七不且上丗丁一世()
        {
            Expressions.七上丈丂与丝丛丑七 val_2 = Expressions.七上丈丂与丝丛丑七.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Expressions.七上丈丂与丝丛丑七 val_1 = null;
            val_2 = val_1;
            val_1 = new Expressions.七上丈丂与丝丛丑七();
            Expressions.七上丈丂与丝丛丑七.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        private 七上丈丂与丝丛丑七()
        {
            this.丆丘七丒丁丐丛东丐 = new System.Collections.Generic.Dictionary<System.String, Expressions.丘丁七一丑丟丁专丗>();
            this.丐专丂丁与且丁且丂 = new System.Collections.Generic.Dictionary<System.Type, Expressions.丝丟丌丙丘丕不丕丐>();
        }
        internal PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗> 丝丅三且丄世丄与丂<T>(string 不丝世不丈丏专万丅)
        {
            string val_8;
            var val_12;
            System.Collections.Generic.Dictionary<System.String, Expressions.丘丁七一丑丟丁专丗> val_18;
            System.Collections.Generic.Dictionary<System.String, Expressions.丘丁七一丑丟丁专丗> val_19;
            var val_20;
            Expressions.丝丟丌丙丘丕不丕丐 val_21;
            Expressions.丛专丞与丑业丏丏世 val_22;
            val_18 = this;
            val_19 = this.丆丘七丒丁丐丛东丐;
            if((val_19.ContainsKey(key:  不丝世不丈丏专万丅)) != false)
            {
                    val_18 = this.丆丘七丒丁丐丛东丐;
                PGCompany.丁丑丘下丒丟丆丝三<T> val_3 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.丌丆丑三丐丆丈丛万(丒专丟丞丌丐丑丕丄:  val_18.Item[不丝世不丈丏专万丅], 丏丞专丏业丗丝七丝:  0);
                return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_16.<万丒丙丛丑七丅丂三>k__BackingField;
            }
            
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            if((this.丐专丂丁与且丁且丂.ContainsKey(key:  val_4)) == false)
            {
                goto label_8;
            }
            
            val_21 = this.丐专丂丁与且丁且丂.Item[val_4];
            goto label_10;
            label_8:
            object val_7 = System.Activator.CreateInstance(type:  val_4, nonPublic:  true);
            val_21 = new Expressions.丝丟丌丙丘丕不丕丐();
            if(val_7 == null)
            {
                goto label_12;
            }
            
            val_22 = val_7;
            if(val_22 != null)
            {
                goto label_13;
            }
            
            label_12:
            val_22 = 0;
            label_13:
            val_21 = new Expressions.丝丟丌丙丘丕不丕丐(丆专丈丛丞丌万丐丝:  val_22);
            this.丐专丂丁与且丁且丂.Add(key:  val_4, value:  new Expressions.丝丟丌丙丘丕不丕丐());
            label_10:
            val_19 = Expressions.Analyzer.丞七丒丛丒世且丄丒.丑七不且上丗丁一世();
            PGCompany.丁丑丘下丒丟丆丝三<System.String> val_11 = val_19.丁世丛丈丘丅丘丅专(不丝世不丈丏专万丅:  不丝世不丈丏专万丅);
            if(val_8.下丕且丝丐丙丏丛上() != false)
            {
                    PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗> val_14 = new Expressions.丝丟丌丙丘丕不丕丐().专业丐下丒丒丙丕丆(丞丕丒专一下丙业上:  不丝世不丈丏专万丅);
                val_18 = this.丆丘七丒丁丐丛东丐;
                val_20 = val_18;
                val_20.Add(key:  不丝世不丈丏专万丅, value:  val_8.丐丏七丌丕丗业且上());
                mem2[0] = val_12;
                mem2[0] = val_8;
                return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_16.<万丒丙丛丑七丅丂三>k__BackingField;
            }
            
            PGCompany.丁丑丘下丒丟丆丝三<T> val_16 = PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>.世万丂丏丞与与三业(丏丞专丏业丗丝七丝:  val_8, 丒专丟丞丌丐丑丕丄:  0);
            return (PGCompany.丁丑丘下丒丟丆丝三<Expressions.丘丁七一丑丟丁专丗>)val_16.<万丒丙丛丑七丅丂三>k__BackingField;
        }
    
    }

}
