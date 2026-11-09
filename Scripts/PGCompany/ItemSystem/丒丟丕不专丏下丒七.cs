using UnityEngine;

namespace PGCompany.ItemSystem
{
    internal class 丒丟丕不专丏下丒七 : 丒三丟丝丗与不丈丞, 业且丗丐丛丆丈丙丈
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈> 丁丈万且丟丁业七丆;
        
        // Methods
        public bool 东一三一万且丕世不(PGCompany.三东丏不丗世丅丌丄 丗丟上上丒丐丗丞丙)
        {
            System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈> val_6;
            var val_7;
            Rilisoft.OfferItemType val_8;
            var val_9;
            if(丗丟上上丒丐丗丞丙 == null)
            {
                    return false;
            }
            
            val_6 = this.丁丈万且丟丁业七丆;
            if((val_6.ContainsKey(key:  丗丟上上丒丐丗丞丙.不业丙丒丂丞下丆丙())) != false)
            {
                    val_6 = 丗丟上上丒丐丗丞丙.不业丙丒丂丞下丆丙();
                val_7 = 1152921559636324000;
                val_8 = val_6;
            }
            else
            {
                    val_7 = 1152921559636324000;
                val_8 = 0;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_9 = 0;
            return this.丁丈万且丟丁业七丆.Item[val_8].东一三一万且丕世不(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
        }
        public 丒丟丕不专丏下丒七()
        {
            System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.OfferItemType, PGCompany.ItemSystem.业且丗丐丛丆丈丙丈>();
            丒丟丕不专丏下丒七.丐丙丑丄且丟丆丛丏 val_2 = new 丒丟丕不专丏下丒七.丐丙丑丄且丟丆丛丏();
            val_1.Add(key:  0, value:  val_2);
            this.丁丈万且丟丁业七丆 = val_1;
            val_2 = new System.Object();
        }
    
    }

}
