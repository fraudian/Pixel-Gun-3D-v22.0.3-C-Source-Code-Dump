using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 下丞丁且不丄丙东丛 : 丈万丈丅丌丏丞丂丐
    {
        // Fields
        private readonly System.Collections.Generic.List<string> 下丒上与丒三丕丐丅;
        
        // Methods
        public 下丞丁且不丄丙东丛(System.Collections.Generic.List<string> 与丝东万丙丞丝丟七, Rilisoft.业丙丘丆东丈丕丂丄 丙丌丛丗丙东丟专丟)
        {
            val_1 = new System.Object();
            mem[1152921543706296640] = val_1;
            this.下丒上与丒三丕丐丅 = 与丝东万丙丞丝丟七;
        }
        public override bool 东一三一万且丕世不()
        {
            System.Collections.Generic.IEnumerable<TSource> val_9;
            if((this.下丒上与丒三丕丐丅 == null) || ((System.Linq.Enumerable.Any<System.String>(source:  this.下丒上与丒三丕丐丅)) == false))
            {
                goto label_2;
            }
            
            val_9 = 丏与丅专三丙与丘丒();
            if(val_9 == null)
            {
                    return (bool)val_9;
            }
            
            List.Enumerator<T> val_3 = this.下丒上与丒三丕丐丅.GetEnumerator();
            label_9:
            if((444881752 & 1) == 0)
            {
                goto label_6;
            }
            
            new 下丞丁且不丄丙东丛.丛与丒丞丁丛上丄丆() = new System.Object();
            .丞丅上丏丂且下丅与 = 0.丐丏七丌丕丗业且上();
            System.Func<Rilisoft.OfferItem, System.Boolean> val_6 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new 下丞丁且不丄丙东丛.丛与丒丞丁丛上丄丆(), method:  System.Boolean 下丞丁且不丄丙东丛.丛与丒丞丁丛上丄丆::东丕丞专丒丑上万丂(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            Rilisoft.OfferItem val_7 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_9, predicate:  null);
            if(val_7 == null)
            {
                goto label_10;
            }
            
            if(val_7.IsExists == false)
            {
                goto label_9;
            }
            
            goto label_10;
            label_2:
            val_9 = 0;
            return (bool)val_9;
            label_6:
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_9;
        }
    
    }

}
