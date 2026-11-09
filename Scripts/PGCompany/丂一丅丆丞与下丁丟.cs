using UnityEngine;

namespace PGCompany
{
    internal class 丂一丅丆丞与下丁丟 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            string val_12;
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            if(val_2 == null)
            {
                    return 0;
            }
            
            丕丑丙丑丙东丌丘丕 val_5 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_2.业东丅东丌上丗丑不());
            if(val_5 == null)
            {
                    return 0;
            }
            
            if(丈丄不七三万丄丁不 != null)
            {
                    val_12 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
                return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  60, 丞丅上丏丂且下丅与:  val_12 = 0.业上丙丞丐丄丆丅七(), 丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不()).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_5.七东与丄丕丁丛世三()));
            }
            
            return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  60, 丞丅上丏丂且下丅与:  val_12, 丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不()).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_5.七东与丄丕丁丛世三()));
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            return 0;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            var val_18;
            string val_20;
            string val_21;
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            if(val_2 == null)
            {
                goto label_4;
            }
            
            丕丑丙丑丙东丌丘丕 val_5 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_2.业东丅东丌上丗丑不());
            if(val_5 == null)
            {
                goto label_8;
            }
            
            if(val_5.七东与丄丕丁丛世三() >= 5)
            {
                goto label_9;
            }
            
            val_18 = null;
            val_18 = null;
            WeaponManager.丟丗丄业丘丗业丗七.下丑丞丈业丘万世丆(丒东业不丐丑丕丄丆:  val_2.与不丞丑七丘丁丂丛(), 世丙与专七丟丒丆世:  268435467, 丁且丟不七下丆丒丟:  false, 丝丗不东丙不三丄专:  false, 丄下丁东丘业丆丝上:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_5.丈一下下丞世三丑丄(), 丏丆丐丑专与丄丘丞:  System.Math.Min(val1:  5, val2:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌() + val_5.七东与丄丕丁丛世三())));
            if(丈丄不七三万丄丁不 != null)
            {
                    return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            }
            
            return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            label_4:
            string val_14 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            val_20 = "fail provide weapon upgrade, weapon with tag \'";
            val_21 = "\'. weapon not found";
            goto label_20;
            label_8:
            string val_15 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            val_20 = "fail provide weapon quality upgrade for \'";
            val_21 = "\'. weapon not exists";
            goto label_20;
            label_9:
            val_20 = "fail provide weapon quality upgrade for \'";
            val_21 = "\'. max quality arrived";
            label_20:
            UnityEngine.Debug.LogError(message:  val_20 + 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七() + val_21);
            return 0;
        }
        internal override void 下且上丛丞一东不不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丆丈丘东丆丕三丞东 不丁丟专专专丒上丝)
        {
        
        }
        internal override bool 三东不丌世丄丄七丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return false;
        }
        public 丂一丅丆丞与下丁丟()
        {
        
        }
    
    }

}
