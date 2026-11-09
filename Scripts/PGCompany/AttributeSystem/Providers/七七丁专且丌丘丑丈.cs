using UnityEngine;

namespace PGCompany.AttributeSystem.Providers
{
    internal sealed class 七七丁专且丌丘丑丈 : 丒丏丒下上与丑丐一
    {
        // Methods
        public 七七丁专且丌丘丑丈(PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 丆下丕丅丕一丝丁丛)
        {
        
        }
        protected override int 丌专丁东丙上七且三()
        {
            double val_9;
            int val_10;
            if(true <= 20201)
            {
                goto label_1;
            }
            
            if(true == 21201)
            {
                goto label_2;
            }
            
            if(true != 22201)
            {
                goto label_8;
            }
            
            val_9 = 90;
            goto label_15;
            label_1:
            if(true == 19201)
            {
                goto label_7;
            }
            
            if(true != 20201)
            {
                goto label_8;
            }
            
            val_9 = 15;
            goto label_15;
            label_8:
            val_10 = 0;
            goto label_12;
            label_2:
            val_9 = 30;
            goto label_15;
            label_7:
            val_9 = 7;
            label_15:
            System.TimeSpan val_1 = System.TimeSpan.FromDays(value:  val_9);
            val_10 = (int)val_1._ticks.TotalSeconds;
            label_12:
            System.DateTime val_3 = System.DateTime.UtcNow;
            System.DateTime val_5 = val_3.dateData.AddSeconds(value:  (double)-(System.Math.Max(val1:  0, val2:  val_10)));
            decimal val_7 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().一丆专丅世丅丈丙丗(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_5.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_3.dateData});
            return (int)System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid});
        }
    
    }

}
