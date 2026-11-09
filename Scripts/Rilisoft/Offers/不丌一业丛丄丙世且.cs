using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 不丌一业丛丄丙世且 : 丈万丈丅丌丏丞丂丐
    {
        // Fields
        private readonly System.Collections.Generic.List<string> 下丒上与丒三丕丐丅;
        
        // Methods
        public 不丌一业丛丄丙世且(System.Collections.Generic.List<string> 与丝东万丙丞丝丟七, Rilisoft.业丙丘丆东丈丕丂丄 丙丌丛丗丙东丟专丟)
        {
            this.下丒上与丒三丕丐丅 = 与丝东万丙丞丝丟七;
        }
        public override bool 东一三一万且丕世不()
        {
            var val_9;
            if((this.下丒上与丒三丕丐丅 == null) || ((System.Linq.Enumerable.Any<System.String>(source:  this.下丒上与丒三丕丐丅)) == false))
            {
                goto label_4;
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_3 = this.三丌丘丏丝丘丟下七().丏与丅专三丙与丘丒();
            if(val_3 == null)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_4 = val_3.GetEnumerator();
            label_10:
            if((445423976 & 1) == 0)
            {
                goto label_5;
            }
            
            string val_5 = 0.丐丏七丌丕丗业且上();
            if(((this.下丒上与丒三丕丐丅.Contains(item:  val_5.Id)) == false) || (val_5.IsExists == true))
            {
                goto label_10;
            }
            
            val_9 = 1;
            goto label_11;
            label_5:
            val_9 = 0;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_9;
            label_4:
            val_9 = 0;
            return (bool)val_9;
        }
    
    }

}
