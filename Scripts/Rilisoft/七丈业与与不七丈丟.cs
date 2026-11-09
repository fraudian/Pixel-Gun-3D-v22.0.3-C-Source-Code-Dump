using UnityEngine;

namespace Rilisoft
{
    internal class 七丈业与与不七丈丟 : ICloneable
    {
        // Fields
        internal Rilisoft.七丈业与与不七丈丟.丏一丄丐专丟丂丟丏 丁丑丅丐丌不世丁下;
        internal System.Type 万丈丘丏丅世万丝丄;
        internal int 丘世丐丞与丌世丄丏;
        internal string 下丄丈不与世丐业专;
        internal int 且与丙丑丕专七丈专;
        internal Rilisoft.七丈业与与不七丈丟.世丕三丙七丆丁丂丒 丒上一丁丆丛东专丙;
        internal int 世不丑丙丞丘丘丙丈;
        internal System.Collections.Generic.List<Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟> 丆东丂丄丁丛丑与七;
        internal int 丕丏专业丑丘下丝一;
        internal bool 丒丌丑丟丄上世丅专;
        
        // Methods
        public object Clone()
        {
            int val_11;
            丏一丄丐专丟丂丟丏 val_12;
            var val_13;
            System.Func<丂七丄不专下丘丂丟, System.Object> val_15;
            System.Collections.Generic.List<丂七丄不专下丘丂丟> val_16;
            Rilisoft.七丈业与与不七丈丟 val_1 = new Rilisoft.七丈业与与不七丈丟();
            if(val_1 != null)
            {
                    .下丄丈不与世丐业专 = this.下丄丈不与世丐业专;
                .万丈丘丏丅世万丝丄 = this.万丈丘丏丅世万丝丄;
                .丕丏专业丑丘下丝一 = this.丕丏专业丑丘下丝一;
                .且与丙丑丕专七丈专 = this.且与丙丑丕专七丈专;
                val_11 = this.世不丑丙丞丘丘丙丈;
            }
            else
            {
                    mem[40] = this.下丄丈不与世丐业专;
                mem[24] = this.万丈丘丏丅世万丝丄;
                mem[80] = this.丕丏专业丑丘下丝一;
                mem[48] = this.且与丙丑丕专七丈专;
                val_11 = this.世不丑丙丞丘丘丙丈;
            }
            
            .世不丑丙丞丘丘丙丈 = val_11;
            val_12 = this.丁丑丅丐丌不世丁下;
            if(val_12 != null)
            {
                    if(val_12.Clone() != null)
            {
                    val_12 = 0;
            }
            
            }
            
            .丁丑丅丐丌不世丁下 = val_12;
            if(this.丆东丂丄丁丛丑与七 != null)
            {
                    val_13 = null;
                val_13 = null;
                val_15 = 七丈业与与不七丈丟.<>c.<>9__10_0;
                if(val_15 == null)
            {
                    System.Func<丂七丄不专下丘丂丟, System.Object> val_5 = null;
                val_15 = val_5;
                val_5 = new System.Func<丂七丄不专下丘丂丟, System.Object>(object:  七丈业与与不七丈丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Object 七丈业与与不七丈丟.<>c::东与丛丌丞丕上下丘(Rilisoft.Offers.东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 丙丒七丄上与丏丙丙));
                七丈业与与不七丈丟.<>c.<>9__10_0 = val_15;
            }
            
                System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<丂七丄不专下丘丂丟>(source:  System.Linq.Enumerable.Cast<丂七丄不专下丘丂丟>(source:  System.Linq.Enumerable.Select<丂七丄不专下丘丂丟, System.Object>(source:  this.丆东丂丄丁丛丑与七, selector:  val_5)));
            }
            else
            {
                    val_16 = 0;
            }
            
            .丆东丂丄丁丛丑与七 = val_16;
            if(this.丒上一丁丆丛东专丙 != null)
            {
                    object val_9 = this.丒上一丁丆丛东专丙.Clone();
            }
            
            .丒上一丁丆丛东专丙 = 0;
            return (object)val_1;
        }
        public 七丈业与与不七丈丟()
        {
            this.万丈丘丏丅世万丝丄 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            this.丒丌丑丟丄上世丅专 = true;
        }
    
    }

}
