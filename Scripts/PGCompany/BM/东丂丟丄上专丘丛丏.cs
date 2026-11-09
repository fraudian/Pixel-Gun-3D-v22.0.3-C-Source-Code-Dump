using UnityEngine;

namespace PGCompany.BM
{
    internal static class 东丂丟丄上专丘丛丏
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.BM.丄不丙万与丙东世丕> 丆丘七丒丁丐丛东丐;
        private static readonly PGCompany.BM.丄不丙万与丙东世丕 丄丝下与丛丞丁丙一;
        
        // Methods
        internal static PGCompany.BM.丄不丙万与丙东世丕 丞丈丏七丅丏丕丌丞(PGCompany.BM.丒万丗丏一丝丅丌世 丒专丑丒丁丞三丆业)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_8;
            PGCompany.BM.丄不丙万与丙东世丕 val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = 丒专丑丒丁丞三丆业;
            if(val_8 == null)
            {
                goto label_1;
            }
            
            val_8 = 丒专丑丒丁丞三丆业._itemIndex;
            if((PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_8)) == null)
            {
                    return val_9;
            }
            
            val_10 = null;
            val_10 = null;
            val_11 = null;
            if((PGCompany.BM.东丂丟丄上专丘丛丏.丆丘七丒丁丐丛东丐.ContainsKey(key:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_8).不业丙丒丂丞下丆丙())) == false)
            {
                goto label_7;
            }
            
            val_12 = null;
            val_8 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_8).不业丙丒丂丞下丆丙();
            PGCompany.BM.丄不丙万与丙东世丕 val_7 = PGCompany.BM.东丂丟丄上专丘丛丏.丆丘七丒丁丐丛东丐.Item[val_8];
            return val_9;
            label_1:
            val_9 = 0;
            return val_9;
            label_7:
            val_13 = null;
            val_9 = PGCompany.BM.东丂丟丄上专丘丛丏.丄丝下与丛丞丁丙一;
            return val_9;
        }
        private static 东丂丟丄上专丘丛丏()
        {
            System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.BM.丄不丙万与丙东世丕> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.BM.丄不丙万与丙东世丕>();
            val_1.Add(key:  242, value:  new PGCompany.BM.丅万丂丆丟万三三丁());
            val_1.Add(key:  46, value:  new PGCompany.BM.丅丁不一丙丐丘且上());
            val_1.Add(key:  10, value:  new PGCompany.BM.丅下东万丘世丛三丙());
            val_1.Add(key:  80, value:  new PGCompany.BM.与丈且与丂七丅丄万());
            val_1.Add(key:  70, value:  new PGCompany.BM.丁丛与一东东七丄丐());
            val_1.Add(key:  126, value:  new PGCompany.BM.丗丐丈丘丑丈丛专丁());
            PGCompany.BM.东丂丟丄上专丘丛丏.丆丘七丒丁丐丛东丐 = val_1;
            PGCompany.BM.东丂丟丄上专丘丛丏.丄丝下与丛丞丁丙一 = new PGCompany.BM.丅万丂丆丟万三三丁();
        }
    
    }

}
