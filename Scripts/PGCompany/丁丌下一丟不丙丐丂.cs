using UnityEngine;

namespace PGCompany
{
    internal sealed class 丁丌下一丟不丙丐丂 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            var val_7;
            var val_8;
            BattlePassController val_1 = Rilisoft.Singleton<BattlePassController>.Instance;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = val_1.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                goto label_2;
            }
            
            int val_3 = val_2.丆丕东东一丑丄与丅();
            val_7 = 0;
            goto label_3;
            label_2:
            val_7 = 0;
            label_3:
            if(((-453932328) & 1) != 0)
            {
                    val_8 = val_7.丙东专丂世丈丏丁丂();
                return (PGCompany.丗丟丄丈东丝丕丄世)PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  2016, 丂丕丂丏专丂丄丕且:  0));
            }
            
            val_8 = 0;
            return (PGCompany.丗丟丄丈东丝丕丄世)PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  2016, 丂丕丂丏专丂丄丕且:  0));
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            PGCompany.三东丏不丗世丅丌丄 val_2 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  2016);
            val_1.Add(item:  this);
            return val_1;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_2;
            }
            
            Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().专下与丒东一上东东(丏业下一丑丄丐丘三:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 一万丏丘业丘丆丏丈:  false);
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
        public 丁丌下一丟不丙丐丂()
        {
        
        }
    
    }

}
