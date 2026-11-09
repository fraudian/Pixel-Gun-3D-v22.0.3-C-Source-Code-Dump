using UnityEngine;

namespace PGCompany
{
    internal abstract class 丂丏丑丈丕三丙丛丑 : 丕业丛世丒且丞丞丘
    {
        // Fields
        private int <丈一与丂丁业丌丛丑>k__BackingField;
        
        // Properties
        protected override bool 丙丅丛不丄七丟业丌 { get; }
        internal override PGCompany.丗不上业丙丆世丁丘 丅万丂世不丘丕下一 { get; set; }
        protected int 丒专下与丑丁丆丟业 { get; set; }
        
        // Methods
        protected abstract void 丅丘丙丒丆丄三丝丌(); // 0
        protected override bool 丆丏丗业丝丘上不东()
        {
            return (bool)((this.<丈一与丂丁业丌丛丑>k__BackingField) > 0) ? 1 : 0;
        }
        internal override string 万丌丂上丈三丗丟丑()
        {
            int val_3;
            var val_4;
            var val_5;
            val_3 = this.<丈一与丂丁业丌丛丑>k__BackingField;
            if(val_3 == 1)
            {
                    val_4 = "!";
                return (string)99.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            if(val_3 < 100)
            {
                    val_5 = null;
                return (string)99.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            val_5 = null;
            val_3 = 99;
            return (string)99.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        internal override PGCompany.丗不上业丙丆世丁丘 丏丘下丞丘不丑万丏()
        {
            return this.丏丘下丞丘不丑万丏();
        }
        internal override void 上丗丆丈丒下丘丏丛(PGCompany.丗不上业丙丆世丁丘 丙业与丙丗丝不丈东)
        {
            this.上丗丆丈丒下丘丏丛(丙业与丙丗丝不丈东:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 丙业与丙丗丝不丈东.丒三丝一上丙专丗丒, 丏丟丑丙七东专丌丏 = true, 三丘丄丝丐丘业丟丘 = 268435467, 丒丂丌丑丟东东丒专 = 丙业与丙丗丝不丈东.丒丂丌丑丟东东丒专});
        }
        protected int 丂丁丏一丙丛业且丌()
        {
            return (int)this.<丈一与丂丁业丌丛丑>k__BackingField;
        }
        protected void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
        {
            this.<丈一与丂丁业丌丛丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 一且丞七丟丌三且且()
        {
            return (int)this.<丈一与丂丁业丌丛丑>k__BackingField;
        }
        protected override void 与且丙丑且且丂丂丂()
        {
            this.与且丙丑且且丂丂丂();
        }
        protected 丂丏丑丈丕三丙丛丑()
        {
        
        }
    
    }

}
