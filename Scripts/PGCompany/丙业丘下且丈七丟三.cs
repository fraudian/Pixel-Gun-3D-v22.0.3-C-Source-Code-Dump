using UnityEngine;

namespace PGCompany
{
    internal class 丙业丘下且丈七丟三 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丆专且丕专丗与一丏:  95);
            val_1.丒上七丐三业丅丈一(丙业与丙丗丝不丈东:  (long)Rilisoft.Singleton<Rilisoft.VIPController>.Instance.不不丐不丆丆下世丛());
            return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_1);
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            PGCompany.三东丏不丗世丅丌丄 val_2 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  95);
            val_1.Add(item:  this);
            return val_1;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            bool val_1 = PixelTime.丝业丁丌丘东丏世与();
            Rilisoft.VIPController val_2 = Rilisoft.Singleton<Rilisoft.VIPController>.Instance;
            int val_3 = 丈丄不七三万丄丁不.丙丑丁专一专世万丕();
            if(val_2 == null)
            {
                goto label_4;
            }
            
            if(val_1 == false)
            {
                goto label_5;
            }
            
            label_8:
            val_2.与丏丘丞且丝业业世(与丈业丛丝丒丙一丏:  val_3);
            if(丈丄不七三万丄丁不 != null)
            {
                    return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            }
            
            return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            label_4:
            if(val_1 == true)
            {
                goto label_8;
            }
            
            label_5:
            val_2.丏与丑专下不下丗丁(与丈业丛丝丒丙一丏:  val_3);
            if(丈丄不七三万丄丁不 != null)
            {
                    return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            }
            
            return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
        }
        internal override void 下且上丛丞一东不不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丆丈丘东丆丕三丞东 不丁丟专专专丒上丝)
        {
        
        }
        internal override bool 三东不丌世丄丄七丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return false;
        }
        public 丙业丘下且丈七丟三()
        {
        
        }
    
    }

}
