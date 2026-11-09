using UnityEngine;

namespace PGCompany.MainStore
{
    internal class ConstructableOfferMainStorePromotionView : MainStorePromotionView
    {
        // Fields
        private UnityEngine.GameObject state_CanBuy;
        private UnityEngine.GameObject state_CantBuy;
        private ItemListUI itemListUI;
        private PGCompany.世丞上丏丗不丛上东 丄丌上丞一丈且丌丕;
        
        // Methods
        private void OnEnable()
        {
            System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_4;
            if(((System.Delegate.Combine(a:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, b:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.MainStore.ConstructableOfferMainStorePromotionView::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_4;
        }
        private void OnDisable()
        {
            System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_4;
            if(((System.Delegate.Remove(source:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, value:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.MainStore.ConstructableOfferMainStorePromotionView::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_4;
        }
        public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            PGCompany.专丟专世丅丂丁且专 val_6;
            int val_2 = 0;
            val_6 = 且丘丏丁丑与丙与丁.七丈丒丒下下且万与();
            if((PGCompany.七丂专七丆丗不丌专.专业丈且丆专万不丁(一丗与一专丙丙丅丄:  val_6, 丞世不丒下上上丝丑: out  val_2)) != false)
            {
                    val_6 = val_2;
                this.丄丌上丞一丈且丌丕 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  0);
            }
            
            this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        }
        internal override bool 丝一丅丆三东丂丞七()
        {
            bool val_5 = this.丝一丅丆三东丂丞七();
            if(this.丄丌上丞一丈且丌丕 == null)
            {
                goto label_1;
            }
            
            if(this.丄丌上丞一丈且丌丕.与丈丟东丆丅丅丝丁() == false)
            {
                goto label_2;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanBuy, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CantBuy, 丏业丟一东丂东丘丛:  false);
            this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.丄丌上丞一丈且丌丕.三丕丂丝丙丆丅三丞());
            return (bool)val_5;
            label_1:
            val_5 = 0;
            return (bool)val_5;
            label_2:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanBuy, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CantBuy, 丏业丟一东丂东丘丛:  true);
            return (bool)val_5;
        }
        private void 丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            goto typeof(PGCompany.MainStore.ConstructableOfferMainStorePromotionView).__il2cppRuntimeField_198;
        }
        public ConstructableOfferMainStorePromotionView()
        {
        
        }
    
    }

}
