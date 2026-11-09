using UnityEngine;

namespace PGCompany
{
    internal sealed class 丅东丆东一丒三丕业 : 不丄上丘丆业丟丕七
    {
        // Fields
        private const float 丙丙业丑上丌丛丛世 = 120;
        
        // Methods
        public PGCompany.七丙上丛七万且丁丟 丘丑丗丛下丒丁丙上()
        {
            return (PGCompany.七丙上丛七万且丁丟)(UnityEngine.Time.realtimeSinceStartup >= 120f) ? 4 : 3;
        }
        public PGCompany.丌丛万丅丕丞业丌丄 丁丐丘丟丈丌丞世丒()
        {
            PGCompany.丌丛万丅丕丞业丌丄 val_0;
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            if(UnityEngine.Application.isEditor != false)
            {
                    decimal val_5 = PGCompany.BatteryWatcher.丈丏丈丆不丂丕一一();
                decimal val_6 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal());
                float val_14 = 10000f;
                val_14 = (UnityEngine.Mathf.Lerp(a:  1f, b:  UnityEngine.Mathf.Clamp01(value:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid})), t:  UnityEngine.Mathf.Clamp01(value:  UnityEngine.Mathf.InverseLerp(a:  0f, b:  120f, value:  val_2)))) * val_14;
                int val_10 = System.Convert.ToInt32(value:  val_14);
                var val_12 = (UnityEngine.Time.realtimeSinceStartup >= 120f) ? 4 : 3;
                val_0.<世丘上丑丛丅一丞七>k__BackingField = 0;
                val_0.<丟不丆上与三不不丞>k__BackingField = 0;
                val_0.<丗丈世七七丗丙万丒>k__BackingField = 0;
                val_0.<丐下丘丟丂丁丘丄下>k__BackingField = 0;
                return val_0;
            }
            
            val_0.<世丘上丑丛丅一丞七>k__BackingField = 0;
            val_0.<丟不丆上与三不不丞>k__BackingField = 0;
            val_0.<丗丈世七七丗丙万丒>k__BackingField = 0;
            val_0.<丐下丘丟丂丁丘丄下>k__BackingField = 0;
            var val_13 = (val_2 >= 120f) ? 4 : 3;
        }
        public 丅东丆东一丒三丕业()
        {
        
        }
    
    }

}
