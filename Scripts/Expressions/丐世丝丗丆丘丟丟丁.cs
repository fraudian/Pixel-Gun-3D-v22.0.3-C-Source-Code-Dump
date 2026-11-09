using UnityEngine;

namespace Expressions
{
    internal class 丐世丝丗丆丘丟丟丁 : 业丏丄丙世一丗丕不
    {
        // Fields
        private Expressions.丐世丝丗丆丘丟丟丁.万丂丈丒丛丂丝丕丌 丂丂丆丞丅丆丌丁与;
        
        // Properties
        public override Expressions.丈与业万万一与丗万 丒三丝一上丙专丗丒 { get; }
        
        // Methods
        public override Expressions.丈与业万万一与丗万 不业丙丒丂丞下丆丙()
        {
            return 2;
        }
        internal 丐世丝丗丆丘丟丟丁(string 不丂专丕丐丞丄丟丄)
        {
            this = new System.Object();
            mem[1152921540909967520] = 不丂专丕丐丞丄丟丄;
            bool val_2 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  不丂专丕丐丞丄丟丄);
            if(val_2 == true)
            {
                    return;
            }
            
            this.丂丂丆丞丅丆丌丁与 = val_2.丐丕世丄业丝丑丌一(不丂专丕丐丞丄丟丄:  不丂专丕丐丞丄丟丄);
        }
        private Expressions.丐世丝丗丆丘丟丟丁.万丂丈丒丛丂丝丕丌 丐丕世丄业丝丑丌一(string 不丂专丕丐丞丄丟丄)
        {
            string val_11;
            int val_12;
            val_11 = 不丂专丕丐丞丄丟丄;
            int val_4 = 0;
            if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    char[] val_2 = new char[1];
                val_2[0] = ':';
                val_11 = val_11.Split(separator:  val_2);
                val_12 = val_3.Length;
                if(val_12 != 0)
            {
                    bool val_5 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_11[0], 丙业与丙丗丝不丈东: out  val_4);
                val_12 = val_3.Length;
            }
            
                if(val_12 >= 2)
            {
                    bool val_6 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<PGCompany.Common.丗七业丏东且丟丕一>(下业七不丑丂丏丟东:  val_11[1], 丄三丅七丆丛与与上: out  val_4, 且丛专世丈且一丌下:  true);
                val_12 = val_3.Length;
            }
            
                if(val_12 > 2)
            {
                    val_11 = val_11[2];
                bool val_8 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_11, 丙业与丙丗丝不丈东: out  0);
            }
            
            }
            
            .<一万丂丟不丛丟下世>k__BackingField = 0;
            .<一丌世上丛三丅丐丅>k__BackingField = 0;
            .<丞丞丝上丗丞七一丟>k__BackingField = 0;
            .<一世下专丕丛上丅丈>k__BackingField = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  0);
            return (万丂丈丒丛丂丝丕丌)new 丐世丝丗丆丘丟丟丁.万丂丈丒丛丂丝丕丌();
        }
        public override bool 丞丙东丌一三专丏不()
        {
            var val_5;
            if(((this.丂丂丆丞丅丆丌丁与 == null) || ((this.丂丂丆丞丅丆丌丁与.<一万丂丟不丛丟下世>k__BackingField) < 1)) || ((this.丂丂丆丞丅丆丌丁与.<一丌世上丛三丅丐丅>k__BackingField) == 0))
            {
                goto label_6;
            }
            
            int val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  this.丂丂丆丞丅丆丌丁与.<一世下专丕丛上丅丈>k__BackingField, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            PGCompany.Common.丗七业丏东且丟丕一 val_4 = this.丂丂丆丞丅丆丌丁与.<一丌世上丛三丅丐丅>k__BackingField;
            val_4 = val_4 - 1;
            if(val_4 > 4)
            {
                goto label_6;
            }
            
            var val_5 = 106018624 + ((this.丂丂丆丞丅丆丌丁与.<一丌世上丛三丅丐丅>k__BackingField - 1)) << 2;
            val_5 = val_5 + 106018624;
            goto (106018624 + ((this.丂丂丆丞丅丆丌丁与.<一丌世上丛三丅丐丅>k__BackingField - 1)) << 2 + 106018624);
            label_6:
            val_5 = 0;
            return (bool)val_5;
        }
    
    }

}
