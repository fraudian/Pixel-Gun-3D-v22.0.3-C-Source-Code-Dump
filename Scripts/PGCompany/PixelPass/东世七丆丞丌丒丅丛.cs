using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class 东世七丆丞丌丒丅丛 : 专一丙丂丑上上丛东
    {
        // Methods
        internal 东世七丆丞丌丒丅丛(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            Add(item:  "PremiumOfferSimple_1_" + 丈丂七世丟丞丂丗丒.世丝丟业丅丛丕且丛());
            Add(item:  "PremiumOfferSimple_2_" + 丈丂七世丟丞丂丗丒.世丝丟业丅丛丕且丛());
            this.Add(item:  "PremiumOfferSimple_3_" + 丈丂七世丟丞丂丗丒.世丝丟业丅丛丕且丛());
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PremiumOfferSimple_title");
        }
        internal override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 万丞万丘丈下东上丘()
        {
            东世七丆丞丌丒丅丛.丛与丒丞丁丛上丄丆 val_1 = new 东世七丆丞丌丒丅丛.丛与丒丞丁丛上丄丆();
            .丝且与丝丒丟万丁专 = this;
            .东且丁丆丛丁丏丘且 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            this.丒东丒上世丘一丗丈().FindAll(match:  new System.Predicate<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  val_1, method:  System.Boolean 东世七丆丞丌丒丅丛.丛与丒丞丁丛上丄丆::丁世业丂丞一丏一丅(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘))).ForEach(action:  new System.Action<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  val_1, method:  System.Void 东世七丆丞丌丒丅丛.丛与丒丞丁丛上丄丆::丄丌与与七三下丄丗(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)));
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)(东世七丆丞丌丒丅丛.丛与丒丞丁丛上丄丆)[1152921560411961856].东且丁丆丛丁丏丘且;
        }
        internal override bool 丌丝丕丕丒专专丏专()
        {
            return (bool)(X19.一丁丁丂上不万三专() > 0) ? 1 : 0;
        }
        internal override string 丛丗丈丙上业丟与丞()
        {
            return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Premium_discount"), arg0:  一丁丁丂上不万三专());
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丂一丆丂且三丟丗一()
        {
            if(X19 != 0)
            {
                    return X19.不世丆丒丛七丘与丅();
            }
            
            return X19.不世丆丒丛七丘与丅();
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丘一丒业下丈丐丝丈()
        {
            if(X19 != 0)
            {
                    return X19.丘万丑丗丕东丘丑丞();
            }
            
            return X19.丘万丑丗丕东丘丑丞();
        }
        internal override string 丄与与丕万丆丄上丟(int 丑丅世丐丒丏丐三丅)
        {
            if(Count <= 丑丅世丐丒丏丐三丅)
            {
                    return (string)System.String.alignConst;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.Item[丑丅世丐丒丏丐三丅]);
        }
        internal override bool 不专丞丐一丁上下丁()
        {
            return (bool)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  X20.不世丆丒丛七丘与丅(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        protected override bool 丄世丆丄丛世丐与不()
        {
            var val_10;
            var val_11;
            val_10 = this;
            if((val_10 & 1) != 0)
            {
                    if(三丐丌丏专世丆丞丗() == false)
            {
                goto label_3;
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
            label_3:
            int val_3 = X21.丞丞丘业东丙丏七丌();
            .丂丄与丁上专丘丆丈 = val_3;
            .丒丆丕丁丟业上七丅 = val_3.不世丆丒丛七丘与丅();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  177);
            PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  X22.不世丆丒丛七丘与丅(), 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丑不丅丂万丁丑丁丏();
            this.七七丞与业七七不丆(不丕一下丒不世与且:  new PGCompany.PixelPass.七丒七与丆下丕丏丅(丈丂七世丟丞丂丗丒:  X21));
            val_10 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_10.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_11 = 1;
            return (bool)val_11;
        }
    
    }

}
