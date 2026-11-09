using UnityEngine;

namespace Rilisoft
{
    public abstract class 与不一丝丈万东不丗 : 丝且一上一万与丘丈
    {
        // Fields
        private readonly int 不丄丞万丗丑上不丏;
        private int 万丈丞业七丆丑一丑;
        
        // Properties
        public int 下丅丛不丄丙专丆下 { get; }
        public int 专东丐东与丄丗丕与 { get; }
        
        // Methods
        public 与不一丝丈万东不丗(string 丞丅上丏丂且下丅与, long 丟丒业且万上丁三丆, int 与丄不丌一世东丁丙, Rilisoft.丅不世丌丒丅丄丂丄 丒万丟丅丌丝丟下下, Rilisoft.与丑丝与业丐丟丏丁 丗七丟丈三不丕一三, bool 丛丅丘一丏丙且丌上, bool 丑下三与丞下丗专丄, int 丂丞七丞业丆丞丑且, int 与丈不丝丘下丁丂丐)
        {
            丗七丟丈三不丕一三.<且丘丕七三丅丒万不>k__BackingField = (丗七丟丈三不丕一三.<且丘丕七三丅丒万不>k__BackingField) & 4294967295;
            bool val_1 = 丑下三与丞下丗专丄;
            丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
            if(丂丞七丞业丆丞丑且 > 0)
            {
                    this.不丄丞万丗丑上不丏 = 丂丞七丞业丆丞丑且;
                this.万丈丞业七丆丑一丑 = UnityEngine.Mathf.Clamp(value:  与丈不丝丘下丁丂丐, min:  0, max:  丂丞七丞业丆丞丑且);
                return;
            }
            
            System.ArgumentOutOfRangeException val_3 = new System.ArgumentOutOfRangeException(paramName:  "requiredCount", actualValue:  丂丞七丞业丆丞丑且, message:  "Requires at least 1.");
        }
        public int 丈且与丗业上丘丒丄()
        {
            return (int)this.万丈丞业七丆丑一丑;
        }
        public int 丗丐丐丂丆万丄丞丁()
        {
            return (int)this.不丄丞万丗丑上不丏;
        }
        public void 丌丁世丅丁丐下丕丏(bool 丞三丕世业三丒丅三, int 丌丒丝东丌下丕丁丅 = 1)
        {
            int val_4;
            var val_5;
            if(丞三丕世业三丒丅三 == false)
            {
                    return;
            }
            
            val_4 = typeof(Rilisoft.与不一丝丈万东不丗).__il2cppRuntimeField_170;
            this.万丈丞业七丆丑一丑 = UnityEngine.Mathf.Clamp(value:  this.万丈丞业七丆丑一丑 + 丌丒丝东丌下丕丁丅, min:  0, max:  this.不丄丞万丗丑上不丏);
            val_5 = null;
            val_5 = null;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 129162096, hi = 268435465, lo = val_4, mid = val_4}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0})) == false)
            {
                    return;
            }
            
            this.丒不七东丙丒丞业丛();
        }
        public void 丑与七丑丒不丏下专(int 丌丒丝东丌下丕丁丅 = 1)
        {
            this.丌丁世丅丁丐下丕丏(丞三丕世业三丒丅三:  true, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        }
        public override decimal 丘丑万一丝丅东业丟()
        {
            decimal val_1 = System.Decimal.op_Implicit(value:  this.万丈丞业七丆丑一丑);
            decimal val_2 = System.Decimal.op_Implicit(value:  this.不丄丞万丗丑上不丏);
            return System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
        }
        protected override void 丘丛丘丙上丁世世一(System.Collections.Generic.Dictionary<string, object> 丘丟与专上丑一东上)
        {
            丘丟与专上丑一东上.set_Item(key:  "parameter", value:  this.不丄丞万丗丑上不丏);
        }
        protected override void 且丙不丗丄且专不丂(System.Collections.Generic.Dictionary<string, object> 丙丑丆上不丒上丕丛)
        {
            丙丑丆上不丒上丕丛.set_Item(key:  "currentCount", value:  this.万丈丞业七丆丑一丑);
        }
    
    }

}
