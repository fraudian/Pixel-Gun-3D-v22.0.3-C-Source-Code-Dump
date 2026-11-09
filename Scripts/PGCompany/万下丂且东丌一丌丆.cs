using UnityEngine;

namespace PGCompany
{
    internal static class 万下丂且东丌一丌丆
    {
        // Fields
        private static readonly ulong 与丘丛丌丟丟上丏三;
        
        // Methods
        internal static System.DateTime 万下专丒丞丒丘与丐(System.DateTime 不丗万丘丆丗上丗丏, System.TimeSpan 丙业与丙丗丝不丈东)
        {
            System.DateTime val_2 = PGCompany.万下丂且东丌一丌丆.丕东七上丅丆且丈专(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = 不丗万丘丆丗上丗丏.dateData}, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东._ticks.System.IConvertible.ToInt64(provider:  0));
            return (System.DateTime)val_2.dateData;
        }
        private static System.DateTime 丕东七上丅丆且丈专(System.DateTime 不丗万丘丆丗上丗丏, long 丙业与丙丗丝不丈东)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            System.DateTime val_8;
            var val_9;
            var val_10;
            val_4 = 不丗万丘丆丗上丗丏.dateData.Ticks + 丙业与丙丗丝不丈东;
            val_5 = null;
            val_5 = null;
            if(val_4 <= PGCompany.万下丂且东丌一丌丆.与丘丛丌丟丟上丏三)
            {
                goto label_3;
            }
            
            val_4 = 1152921504618614784;
            val_6 = null;
            if((丙业与丙丗丝不丈东 & 9223372036854775808) != 0)
            {
                goto label_4;
            }
            
            val_7 = null;
            val_8 = System.DateTime.MaxValue;
            goto label_7;
            label_3:
            val_9 = 0;
            return (System.DateTime)val_2.dateData;
            label_4:
            val_10 = null;
            val_8 = System.DateTime.MinValue;
            label_7:
            System.DateTime val_2 = System.DateTime.SpecifyKind(value:  new System.DateTime() {dateData = val_8}, kind:  不丗万丘丆丗上丗丏.dateData);
            return (System.DateTime)val_2.dateData;
        }
        private static 万下丂且东丌一丌丆()
        {
            null = null;
            PGCompany.万下丂且东丌一丌丆.与丘丛丌丟丟上丏三 = System.DateTime.MaxValue.Ticks;
        }
    
    }

}
