using UnityEngine;

namespace PGCompany.BM
{
    internal class 业丏丗丒丄丐三丁东 : 丏丈丁与丑一丝下丒
    {
        // Methods
        internal override bool 丏丑业丛丂万上专丘(PGCompany.BM.丝七丙下丈丌丈丞丘 上世丏丁世丟世丆业, System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丁丕丁丞下丗丏三丞, PGCompany.BM.丁七上一三丁上丑丑 丌丝万上丅丒一丈丘, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄丗丂丟丛丂丆丏丗, out System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑七不与丛丆一丂丞, out PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
        {
            System.Collections.Generic.List<T> val_12;
            PGCompany.BM.丟与业丄世七丏下丌 val_13;
            val_12 = 上世丏丁世丟世丆业;
            丑七不与丛丆一丂丞 = 0;
            丒世丘丘上丆丝东丞 = 0;
            if(丌丝万上丅丒一丈丘 != null)
            {
                    val_13 = 0;
                if(val_12 == null)
            {
                    return (bool)val_13;
            }
            
                if(丌丝万上丅丒一丈丘._slotType != 3)
            {
                    return (bool)val_13;
            }
            
                val_13 = 上世丏丁世丟世丆业._upgradeRules;
                if(val_13 == null)
            {
                    return (bool)val_13;
            }
            
                if(val_13.东业三不专丈丈东丞() == null)
            {
                    return (bool)val_13;
            }
            
                Rilisoft.丝丑丂丛万丐丈丘且 val_2 = 丌丝万上丅丒一丈丘._level - 1;
                if((val_2 >> 31) == 0)
            {
                    if(val_2 < 上世丏丁世丟世丆业._upgradeRules.东业三不专丈丈东丞().Count)
            {
                    System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_8 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
                丑七不与丛丆一丂丞 = val_8;
                val_12 = 丑七不与丛丆一丂丞;
                val_8.Add(item:  上世丏丁世丟世丆业._upgradeRules.东业三不专丈丈东丞().Item[val_2].丂丑丞丝且万丐万丟().与下不与丐丈丁丈万());
                丒世丘丘上丆丝东丞 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  7);
                val_13 = 1;
                return (bool)val_13;
            }
            
            }
            
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        public 业丏丗丒丄丐三丁东()
        {
            val_1 = new System.Object();
        }
    
    }

}
