using UnityEngine;

namespace PGCompany
{
    internal sealed class 专丂丐三一丁丘丁丗 : 东丞丄丌丙丙丕下丛
    {
        // Methods
        internal override PGCompany.丗丟丄丈东丝丕丄世 丒丅丙丄丞丟下丏业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            PGCompany.不丁下丈专丈东世下 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.不丁下丈专丈东世下>(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_2 == null)
            {
                    return 0;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_3 = val_2.东上专丑丏丞上丞丐();
            if(val_3 == null)
            {
                    return 0;
            }
            
            if(val_3.丑丆丑三且丛上且丟() == true)
            {
                    return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  1));
            }
            
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  val_3)) == false)
            {
                    return 0;
            }
            
            return PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  1));
        }
        internal override System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 万丞万丘丈下东上丘(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, PGCompany.丕丅世丂丞丒万丈且 丙与不丌丌丟丄业丛)
        {
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            List.Enumerator<T> val_4 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕().GetEnumerator();
            label_7:
            if(((-438427864) & 1) == 0)
            {
                goto label_3;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  85, 丞丅上丏丂且下丅与:  0.丐丏七丌丕丗业且上().业上丙丞丐丄丆丅七());
            if(this == null)
            {
                goto label_7;
            }
            
            val_1.Add(item:  this);
            goto label_7;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal override PGCompany.三东丏不丗世丅丌丄 丕丌丟三丝丕一三丌(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            PGCompany.不丁下丈专丈东世下 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.不丁下丈专丈东世下>(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_2 == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_2;
            }
            
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  85, 丞一丁业丄一一业且:  val_2.业上丙丞丐丄丆丅七(), 丂丕丂丏专丂丄丕且:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌()), 丁且丟不七下丆丒丟:  true, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  false, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  0, 不丐丅丁丂七丐丘丛:  0, 丁七丐丁丙丄丙不东:  false);
            return val_2.丑丐丙丄丅世世丑丒();
        }
        internal override void 下且上丛丞一东不不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, PGCompany.丆丈丘东丆丕三丞东 不丁丟专专专丒上丝)
        {
        
        }
        internal override bool 三东不丌世丄丄七丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            return false;
        }
        public 专丂丐三一丁丘丁丗()
        {
        
        }
    
    }

}
