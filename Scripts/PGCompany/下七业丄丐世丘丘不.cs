using UnityEngine;

namespace PGCompany
{
    internal class 下七业丄丐世丘丘不
    {
        // Fields
        internal int Version;
        internal int PaymentCalculationPeriod;
        internal int SeasonId;
        internal decimal DetailPriceCommon;
        internal decimal DetailPriceUncommon;
        internal decimal DetailPriceRare;
        internal decimal DetailPriceEpic;
        internal decimal DetailPriceLegendary;
        internal decimal DetailPriceMythic;
        internal decimal DetailModulePrice;
        private System.Collections.Generic.List<PGCompany.下七业丄丐世丘丘不.丈丟丁丆业丝丁丗且> _sales;
        private PGCompany.且丟一七万东丁三上<PGCompany.下七业丄丐世丘丘不.丈丟丁丆业丝丁丗且> 上丁与丞且丆丏业丅;
        internal System.Collections.Generic.List<PGCompany.下七业丄丐世丘丘不.丝丕专世丙丆丛丝丝> SlotsSettings;
        internal System.Collections.Generic.List<PGCompany.下七业丄丐世丘丘不.丕万万丁丕不丞丗丛> PaymentGroupsSetting;
        
        // Properties
        internal PGCompany.且丟一七万东丁三上<PGCompany.下七业丄丐世丘丘不.丈丟丁丆业丝丁丗且> 业与三万丁丗七一丅 { get; }
        
        // Methods
        internal PGCompany.且丟一七万东丁三上<PGCompany.下七业丄丐世丘丘不.丈丟丁丆业丝丁丗且> 世世丟丌丟丟丁丟丛()
        {
            PGCompany.且丟一七万东丁三上<丈丟丁丆业丝丁丗且> val_3 = this.上丁与丞且丆丏业丅;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.且丟一七万东丁三上<丈丟丁丆业丝丁丗且> val_1 = null;
            val_3 = val_1;
            val_1 = new PGCompany.且丟一七万东丁三上<丈丟丁丆业丝丁丗且>();
            this.上丁与丞且丆丏业丅 = val_3;
            if(this._sales == null)
            {
                    return val_3;
            }
            
            this._sales.ForEach(action:  new System.Action<丈丟丁丆业丝丁丗且>(object:  this, method:  System.Void PGCompany.下七业丄丐世丘丘不::丕丏丗不专不丏丝丝(PGCompany.下七业丄丐世丘丘不.丈丟丁丆业丝丁丗且 丏丛与丅丛丌万专丌)));
            val_3 = this.上丁与丞且丆丏业丅;
            return val_3;
        }
        public 下七业丄丐世丘丘不()
        {
            this._sales = new System.Collections.Generic.List<丈丟丁丆业丝丁丗且>();
            this.SlotsSettings = new System.Collections.Generic.List<丝丕专世丙丆丛丝丝>();
            this.PaymentGroupsSetting = new System.Collections.Generic.List<丕万万丁丕不丞丗丛>();
        }
        private void 丕丏丗不专不丏丝丝(PGCompany.下七业丄丐世丘丘不.丈丟丁丆业丝丁丗且 丏丛与丅丛丌万专丌)
        {
            this.上丁与丞且丆丏业丅.Add(下上丐丆丝丟丝丒不:  -2002609216, 丙业与丙丗丝不丈东:  new 丈丟丁丆业丝丁丗且() {_dollarPrice = new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丏丛与丅丛丌万专丌._dollarPrice.七丄不丐丗三丝丑一}, Sale = 丏丛与丅丛丌万专丌.Sale});
        }
    
    }

}
