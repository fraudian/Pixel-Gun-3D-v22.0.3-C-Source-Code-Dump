using UnityEngine;

namespace PGCompany
{
    internal class 专七丘丝丌丌丈三丂 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            string val_13;
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
            
            if(val_5.丈一下下丞世三丑丄() < 1)
            {
                    return 0;
            }
            
            if(丈丄不七三万丄丁不 != null)
            {
                    val_13 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
                return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  30, 丞丅上丏丂且下丅与:  val_13 = 0.业上丙丞丐丄丆丅七(), 丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不()).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_5.丈一下下丞世三丑丄()));
            }
            
            return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  30, 丞丅上丏丂且下丅与:  val_13, 丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不()).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_5.丈一下下丞世三丑丄()));
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            return 0;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            var val_17;
            string val_19;
            string val_20;
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
            
            val_17 = null;
            val_17 = null;
            WeaponManager.丟丗丄业丘丗业丗七.下丑丞丈业丘万世丆(丒东业不丐丑丕丄丆:  val_2.与不丞丑七丘丁丂丛(), 世丙与专七丟丒丆世:  268435467, 丁且丟不七下丆丒丟:  false, 丝丗不东丙不三丄专:  false, 丄下丁东丘业丆丝上:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  System.Math.Min(val1:  ExperienceController.丞丞丘业东丙丏七丌(), val2:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌() + val_5.丈一下下丞世三丑丄()), 丏丆丐丑专与丄丘丞:  val_5.七东与丄丕丁丛世三()));
            if(丈丄不七三万丄丁不 != null)
            {
                    return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            }
            
            return 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
            label_4:
            string val_14 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            val_19 = "fail provide weapon level upgrade \'";
            val_20 = "\'. weapon not found";
            goto label_19;
            label_8:
            val_19 = "fail provide weapon level upgrade \'";
            val_20 = "\'. weapon not exists";
            label_19:
            UnityEngine.Debug.LogError(message:  val_19 + 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七() + val_20);
            return 0;
        }
        internal override void 下且上丛丞一东不不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丆丈丘东丆丕三丞东 不丁丟专专专丒上丝)
        {
        
        }
        internal override bool 三东不丌世丄丄七丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return false;
        }
        public 专七丘丝丌丌丈三丂()
        {
        
        }
    
    }

}
