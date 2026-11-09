using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHEntityRatingUI : ViewComponentGMHEntityBase
    {
        // Fields
        private System.Collections.Generic.List<SlideDot> indicators;
        
        // Methods
        public override void Setup(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            var val_8;
            int val_10;
            var val_11;
            var val_12;
            mem[1152921560511095656] = 不丕三丌万丈丟丆世;
            val_8 = null;
            val_8 = null;
            if((GMHEntityRatingUI.<>c.<>9__1_0) == null)
            {
                goto label_3;
            }
            
            label_22:
            this.indicators.ForEach(action:  GMHEntityRatingUI.<>c.<>9__1_0);
            val_11 = null;
            val_11 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = GMHEntityRatingUI.<>c.<>9__1_0, hi = GMHEntityRatingUI.<>c.<>9__1_0, lo = this.indicators, mid = this.indicators}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
            {
                    return;
            }
            
            val_12 = 0;
            goto label_9;
            label_18:
            if(val_12 < this.indicators.Count)
            {
                    SlideDot val_3 = this.indicators.Item[0];
                if(val_3 != null)
            {
                    (val_3 == 0) ? 0 : (val_3).世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  true);
            }
            
            }
            
            val_12 = 1;
            label_9:
            decimal val_5 = System.Decimal.op_Implicit(value:  1);
            val_10 = val_5.flags;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_10, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal() {flags = X27 + 104, hi = X27 + 104, lo = X27 + 104 + 8, mid = X27 + 104 + 8})) == true)
            {
                goto label_18;
            }
            
            return;
            label_3:
            GMHEntityRatingUI.<>c.<>9__1_0 = new System.Action<SlideDot>(object:  GMHEntityRatingUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GMHEntityRatingUI.<>c::三丂丐与丌丄丌丆专(SlideDot 三丟东丕丄丄下下丑));
            if(this.indicators != null)
            {
                goto label_22;
            }
            
            goto label_22;
        }
        public GMHEntityRatingUI()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
