using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanStoreBuffsOrPromotionsUI : PGBehaviour
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        private UILabel _itemTimerLabel;
        private UILabel _promotionBuyLabel;
        private PGCompany.东丑丆丗丏丐丟下丄 丂丅七与丘丞丟万丕;
        private PGCompany.丗丟丄丈东丝丕丄世 丒专下业一丅丏且丌;
        
        // Methods
        internal void 下与丞三丅丛丄七丕(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            this.Reset();
            this.丂丅七与丘丞丟万丕 = 且丘丏丁丑与丙与丁;
            this._itemView.Setup(与且专丈不万东一万:  且丘丏丁丑与丙与丁.三丘丆丅丝丙一丑与());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._promotionBuyLabel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        internal void 下与丞三丅丛丄七丕(PGCompany.丗丟丄丈东丝丕丄世 丟丑丂丆丅三丈上世)
        {
            this.Reset();
            this.丒专下业一丅丏且丌 = 丟丑丂丆丅三丈上世;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemTimerLabel, 丏业丟一东丂东丘丛:  true);
            this._itemView.Setup(与且专丈不万东一万:  丟丑丂丆丅三丈上世);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        public void U_GoToClanStore()
        {
            this.丆丐丌业丗丌上丙丒();
        }
        private void 丆丐丌业丗丌上丙丒()
        {
            if(this.丂丅七与丘丞丟万丕 == null)
            {
                    return;
            }
            
            PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丞丘丞丏业且丛丏丘:  this.丂丅七与丘丞丟万丕.三丘丆丅丝丙一丑与());
        }
        private void Reset()
        {
            this.丂丅七与丘丞丟万丕 = 0;
            this.丒专下业一丅丏且丌 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemTimerLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._promotionBuyLabel, 丏业丟一东丂东丘丛:  false);
        }
        public ClanStoreBuffsOrPromotionsUI()
        {
        
        }
    
    }

}
