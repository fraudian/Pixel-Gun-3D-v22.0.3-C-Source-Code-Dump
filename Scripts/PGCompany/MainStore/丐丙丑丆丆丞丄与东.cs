using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丐丙丑丆丆丞丄与东 : 丅三丑丂丝丈专不一
    {
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 三万丐专丆丆丕丝一 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.offers.lobby";
        }
        protected override Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丑且一丐东三不丈丝()
        {
            return 120;
        }
        protected override PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
        {
            string val_12;
            var val_13;
            var val_14;
            var val_15;
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_1 = this.丝与丘丘丅业一业丘(丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌);
            PGCompany.StorePromotionConfig val_2 = val_1.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_3 = val_2.Settings;
            Rilisoft.七丈业与与不七丈丟 val_4 = 丙业丞丑七丗下丟丌.丁专丗万三上丟三丆();
            val_3.TexturePath = "OfferIcons/Lobby/"("OfferIcons/Lobby/") + val_4.丒上一丁丆丛东专丙.下丄丈不与世丐业专;
            Rilisoft.七丈业与与不七丈丟 val_6 = 丙业丞丑七丗下丟丌.丁专丗万三上丟三丆();
            val_12 = val_6.丒上一丁丆丛东专丙.下丄丈不与世丐业专;
            val_13 = null;
            val_13 = null;
            if((val_12.Equals(value:  且丙丙丈丙丄丌丌不.丁世丟丄丑不且一下)) != false)
            {
                    PGCompany.StorePromotionSettings val_8 = val_2.Settings;
                val_14 = null;
                val_12 = val_8.Tag;
                val_14 = null;
                if((val_12.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  且丙丙丈丙丄丌丌不.丁世丟丄丑不且一下)) != false)
            {
                    PGCompany.StorePromotionSettings val_10 = val_2.Settings;
                val_15 = null;
                val_12 = val_10.Tag;
                val_15 = null;
                bool val_11 = val_12.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  且丙丙丈丙丄丌丌不.丁世丟丄丑不且一下);
            }
            
            }
            
            val_1.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_2);
            return val_1;
        }
        public 丐丙丑丆丆丞丄与东()
        {
        
        }
    
    }

}
