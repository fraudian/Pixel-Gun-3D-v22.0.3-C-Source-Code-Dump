using UnityEngine;

namespace PGCompany.BM
{
    internal abstract class 丏丈丁与丑一丝下丒
    {
        // Methods
        internal abstract bool 丏丑业丛丂万上专丘(PGCompany.BM.丝七丙下丈丌丈丞丘 上世丏丁世丟世丆业, System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丁丕丁丞下丗丏三丞, PGCompany.BM.丁七上一三丁上丑丑 丌丝万上丅丒一丈丘, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄丗丂丟丛丂丆丏丗, out System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑七不与丛丆一丂丞, out PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞); // 0
        protected PGCompany.三东丏不丗世丅丌丄 专丂丘世三世不丞下(PGCompany.BM.丝七丙下丈丌丈丞丘 上世丏丁世丟世丆业, ItemRarity 丈下丑丆上丏丗丈专, int 世丈三丐丞一丒丛不)
        {
            System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>> val_9;
            if(上世丏丁世丟世丆业 == null)
            {
                goto label_6;
            }
            
            val_9 = 上世丏丁世丟世丆业._buyRewards;
            if(val_9 == null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_9;
            }
            
            if(((val_9.ContainsKey(key:  丈下丑丆上丏丗丈专)) == false) || ((上世丏丁世丟世丆业._buyRewards.Item[丈下丑丆上丏丗丈专].ContainsKey(key:  世丈三丐丞一丒丛不)) == false))
            {
                goto label_6;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_5 = 上世丏丁世丟世丆业._buyRewards.Item[丈下丑丆上丏丗丈专].Item[世丈三丐丞一丒丛不];
            PGCompany.三东丏不丗世丅丌丄 val_6 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  103015);
            if(val_6 == null)
            {
                goto label_9;
            }
            
            val_6.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  96579088);
            goto label_10;
            label_6:
            val_9 = 0;
            return (PGCompany.三东丏不丗世丅丌丄)val_9;
            label_9:
            val_6.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  96579088);
            label_10:
            var val_8 = (val_6.丕丐一丙专丛丒丑万() != true) ? (val_6) : 0;
            return (PGCompany.三东丏不丗世丅丌丄)val_9;
        }
        protected 丏丈丁与丑一丝下丒()
        {
        
        }
    
    }

}
