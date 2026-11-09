using UnityEngine;

namespace PGCompany.AttributeSystem.Providers
{
    internal sealed class 丑不丛丘丞丑丙丟专 : 丒丏丒下上与丑丐一
    {
        // Methods
        public 丑不丛丘丞丑丙丟专(PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 丆下丕丅丕一丝丁丛)
        {
        
        }
        protected override int 丌专丁东丙上七且三()
        {
            double val_11;
            int val_12;
            System.Collections.Generic.IEnumerable<System.Decimal> val_13;
            int val_14;
            if(true <= 28201)
            {
                goto label_1;
            }
            
            if(true == 29201)
            {
                goto label_2;
            }
            
            if(true != 30201)
            {
                goto label_8;
            }
            
            val_11 = 90;
            goto label_15;
            label_1:
            if(true == 27201)
            {
                goto label_7;
            }
            
            if(true != 28201)
            {
                goto label_8;
            }
            
            val_11 = 15;
            goto label_15;
            label_8:
            val_12 = 0;
            goto label_12;
            label_2:
            val_11 = 30;
            goto label_15;
            label_7:
            val_11 = 7;
            label_15:
            System.TimeSpan val_1 = System.TimeSpan.FromDays(value:  val_11);
            val_12 = (int)val_1._ticks.TotalSeconds;
            label_12:
            System.DateTime val_3 = System.DateTime.UtcNow;
            System.DateTime val_5 = val_3.dateData.AddSeconds(value:  (double)-(System.Math.Max(val1:  0, val2:  val_12)));
            val_13 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().专不丂业丅丄万丝丈(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_5.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_3.dateData});
            if(val_13.Count >= 1)
            {
                    decimal val_9 = System.Linq.Enumerable.Max(source:  val_13);
                val_13 = val_9.flags;
                val_14 = val_13;
                int val_10 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_14, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
                return (int)val_14;
            }
            
            val_14 = 0;
            return (int)val_14;
        }
    
    }

}
