using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丏上丘业丅丕下丁丙 : 丈万丈丅丌丏丞丂丐
    {
        // Methods
        public 丏上丘业丅丕下丁丙(Rilisoft.业丙丘丆东丈丕丂丄 丈丕丄上丌丐丌不丁)
        {
        
        }
        public override bool 东一三一万且丕世不()
        {
            System.Collections.Generic.List<Rilisoft.PlayerPaymentType> val_11;
            var val_12;
            val_11 = this;
            Rilisoft.七丈业与与不七丈丟 val_2 = this.三丌丘丏丝丘丟下七().丁专丗万三上丟三丆();
            if(val_2.丁丑丅丐丌不世丁下.丂且丝世一丈业一丈 == null)
            {
                goto label_17;
            }
            
            Rilisoft.七丈业与与不七丈丟 val_4 = this.三丌丘丏丝丘丟下七().丁专丗万三上丟三丆();
            if((val_4.丁丑丅丐丌不世丁下.丂且丝世一丈业一丈.Contains(item:  1)) == true)
            {
                goto label_9;
            }
            
            Rilisoft.七丈业与与不七丈丟 val_7 = this.三丌丘丏丝丘丟下七().丁专丗万三上丟三丆();
            val_11 = val_7.丁丑丅丐丌不世丁下.丂且丝世一丈业一丈;
            if((val_11.Contains(item:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丘七丒丕丏东丈与七())) == false)
            {
                goto label_17;
            }
            
            label_9:
            val_12 = 1;
            return (bool)val_12;
            label_17:
            val_12 = 0;
            return (bool)val_12;
        }
    
    }

}
