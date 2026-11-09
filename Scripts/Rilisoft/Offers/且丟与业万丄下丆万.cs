using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 且丟与业万丄下丆万 : 丈万丈丅丌丏丞丂丐
    {
        // Fields
        private long <丆专世丅万丑七不丏>k__BackingField;
        private long <下世三丑业丟丌丑丆>k__BackingField;
        private long <丑世丁丐丟丏七丘丕>k__BackingField;
        
        // Properties
        internal long 三丑丛丄万丟丄丞丁 { get; set; }
        internal long 丄与丒丂丂丘专丝万 { get; set; }
        internal long 丝不丑丂业且丛丒一 { get; set; }
        public System.Nullable<System.TimeSpan> 丌与丁不下丅丆丘丞 { get; }
        public bool 丅一下丞丆不业丏丆 { get; }
        public bool 丞丕一下万业丅上七 { get; }
        public bool 丐丄专丙与丕万丆丅 { get; }
        
        // Methods
        public 且丟与业万丄下丆万(System.Nullable<long> 与丛丌世丁万丒丟业, System.Nullable<long> 丄且一丄丏丆丐丗与, System.Nullable<long> 丈丝世且万世丈丌万, Rilisoft.业丙丘丆东丈丕丂丄 丈丕丄上丌丐丌不丁)
        {
            if((446523536 & 1) != 0)
            {
                    this.<丑世丁丐丟丏七丘丕>k__BackingField = 与丛丌世丁万丒丟业.HasValue;
            }
            
            if((446523520 & 1) != 0)
            {
                    this.<丆专世丅万丑七不丏>k__BackingField = 丈丝世且万世丈丌万.HasValue;
            }
            
            if(( & 1) == 0)
            {
                    return;
            }
            
            this.<下世三丑业丟丌丑丆>k__BackingField = ;
        }
        internal long 东丗丝丙丈丒丛丐丛()
        {
            return (long)this.<丆专世丅万丑七不丏>k__BackingField;
        }
        private void 下东丗不丕丒与与专(long 丙业与丙丗丝不丈东)
        {
            this.<丆专世丅万丑七不丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal long 丐丈丅丅世三七七丝()
        {
            return (long)this.<下世三丑业丟丌丑丆>k__BackingField;
        }
        private void 专丛上丁丒世一不丗(long 丙业与丙丗丝不丈东)
        {
            this.<下世三丑业丟丌丑丆>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal long 与丗且丑丈世丛丞万()
        {
            return (long)this.<丑世丁丐丟丏七丘丕>k__BackingField;
        }
        private void 丘一丝东丂丗不丘三(long 丙业与丙丗丝不丈东)
        {
            this.<丑世丁丐丟丏七丘丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Nullable<System.TimeSpan> 丙世丑丅丒丑业与不()
        {
            if((this.<丆专世丅万丑七不丏>k__BackingField) <= 0)
            {
                    if((this.<下世三丑业丟丌丑丆>k__BackingField) <= 0)
            {
                    return 0;
            }
            
            }
            
            long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if((val_2 <= 0) || ((this.<丆专世丅万丑七不丏>k__BackingField) > val_2))
            {
                    return 0;
            }
            
            this = (this.<下世三丑业丟丌丑丆>k__BackingField) - val_2;
            if((this.<丆专世丅万丑七不丏>k__BackingField) < val_2)
            {
                    return 0;
            }
            
            System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)this);
            return 0;
        }
        public bool 丒丌丌丏丂不下丄丛()
        {
            var val_5;
            if((this.<丆专世丅万丑七不丏>k__BackingField) <= 0)
            {
                    if((this.<下世三丑业丟丌丑丆>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            }
            
            long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if(val_2 >= 1)
            {
                    val_5 = (((this.<丆专世丅万丑七不丏>k__BackingField) <= val_2) ? 1 : 0) | (((this.<丆专世丅万丑七不丏>k__BackingField) < 1) ? 1 : 0);
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
            label_2:
            val_5 = 1;
            return (bool)val_5;
        }
        public bool 丕丈专丞专丞丞下一()
        {
            var val_4;
            if((this.<丆专世丅万丑七不丏>k__BackingField) <= 0)
            {
                    if((this.<下世三丑业丟丌丑丆>k__BackingField) < 1)
            {
                goto label_6;
            }
            
            }
            
            long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if(val_2 >= 1)
            {
                    var val_3 = ((this.<下世三丑业丟丌丑丆>k__BackingField) < val_2) ? 1 : 0;
                return (bool)val_4;
            }
            
            label_6:
            val_4 = 0;
            return (bool)val_4;
        }
        public bool 七丂丌丈丄专丄三世()
        {
            var val_4;
            if((this.<丆专世丅万丑七不丏>k__BackingField) <= 0)
            {
                    if((this.<下世三丑业丟丌丑丆>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            }
            
            long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if(val_2 >= 1)
            {
                    if(val_2 >= (this.<丆专世丅万丑七不丏>k__BackingField))
            {
                goto label_7;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_7:
            var val_3 = (val_2 <= (this.<下世三丑业丟丌丑丆>k__BackingField)) ? 1 : 0;
            return (bool)val_4;
            label_2:
            val_4 = 1;
            return (bool)val_4;
        }
        public override bool 东一三一万且丕世不()
        {
            long val_5;
            var val_6;
            if((this.<丆专世丅万丑七不丏>k__BackingField) <= 0)
            {
                    if((this.<下世三丑业丟丌丑丆>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            }
            
            long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().业丈丏丏丞丘丛丈丛();
            if(val_2 < 1)
            {
                goto label_6;
            }
            
            val_5 = this.<丑世丁丐丟丏七丘丕>k__BackingField;
            if(val_5 >= 1)
            {
                goto label_7;
            }
            
            val_5 = this.<丆专世丅万丑七不丏>k__BackingField;
            if(val_5 < 1)
            {
                goto label_9;
            }
            
            label_7:
            if(val_5 <= val_2)
            {
                goto label_9;
            }
            
            label_6:
            val_6 = 0;
            return (bool)val_6;
            label_9:
            val_6 = (((this.<下世三丑业丟丌丑丆>k__BackingField) >= val_2) ? 1 : 0) | (((this.<下世三丑业丟丌丑丆>k__BackingField) < 1) ? 1 : 0);
            return (bool)val_6;
            label_2:
            val_6 = 1;
            return (bool)val_6;
        }
    
    }

}
