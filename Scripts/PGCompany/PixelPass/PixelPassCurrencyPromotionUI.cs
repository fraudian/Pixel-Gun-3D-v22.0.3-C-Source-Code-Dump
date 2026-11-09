using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class PixelPassCurrencyPromotionUI : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _holder;
        private MainStorePromotionView _storePromotionView;
        private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丂丅七与丘丞丟万丕;
        
        // Methods
        private void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            PGCompany.MainStore.万丝丞东丘丒丌七专.丙上不丆丘丂丒三丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassCurrencyPromotionUI::丝一丅丆三东丂丞七()));
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassCurrencyPromotionUI::丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)));
        }
        private void OnDisable()
        {
            PGCompany.MainStore.万丝丞东丘丒丌七专.丈一七与丈丘丞丗上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassCurrencyPromotionUI::丝一丅丆三东丂丞七()));
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassCurrencyPromotionUI::丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)));
        }
        private void 丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return;
            }
            
            if(this.丂丅七与丘丞丟万丕 == null)
            {
                    return;
            }
            
            if((且丘丏丁丑与丙与丁.Equals(丘丛丏丘丝七世七丅:  this.丂丅七与丘丞丟万丕)) == false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            PGCompany.PixelPass.PixelPassCurrencyPromotionUI val_25;
            System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> val_26;
            PGCompany.三东丏不丗世丅丌丄 val_27;
            var val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            val_25 = this;
            PGCompany.东丑丒丗一丞下丙丙<T> val_5 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  159));
            val_26 = val_3;
            PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丗不丞一且丟丈丈丗(七丄丆丘丒与丐丘丅: ref  val_5, 业世东丛专丑世丂不:  val_3, 丟且丒专下丈七丗丕:  2);
            val_27 = 1152921539565495376;
            val_28 = 1152921560410619792;
            val_29 = "pixeloffers";
            val_30 = "gift";
            val_31 = 0;
            goto label_6;
            label_14:
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_6 = val_5.Item[0];
            if(((val_6 == null) || ((System.String.op_Equality(a:  val_6.丝丒丙一丙丄不三丞(), b:  "pixeloffers")) == true)) || ((System.String.op_Equality(a:  val_6.丝丒丙一丙丄不三丞(), b:  "pixelcurrency")) == true))
            {
                goto label_10;
            }
            
            val_26 = 0;
            if((System.String.op_Equality(a:  val_6.丝丒丙一丙丄不三丞(), b:  "gift")) == false)
            {
                goto label_11;
            }
            
            label_10:
            val_26 = public System.Boolean System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>::Remove(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 item);
            bool val_13 = val_5.Remove(item:  val_6);
            label_11:
            val_31 = 0;
            label_6:
            if(val_31 < val_5.Count)
            {
                goto label_14;
            }
            
            this.丂丅七与丘丞丟万丕 = 0;
            if((System.Linq.Enumerable.Any<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_5)) == false)
            {
                goto label_15;
            }
            
            val_26 = public PGCompany.MainStore.下丐丒丙丂丁丗丘丘 System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>::get_Item(int index);
            val_32 = val_5.Item[0];
            List.Enumerator<T> val_17 = val_5.GetEnumerator();
            val_30 = 1152921505508388864;
            val_28 = 1152921504618881024;
            goto label_18;
            label_24:
            val_27 = 0.丐丏七丌丕丗业且上();
            decimal val_19 = Rilisoft.Offers.丁且丕专万丈丒丏丗.业丟丘丆七丌丕丌丅(丈丄不七三万丄丁不:  val_27, 世丈三丐丞一丒丛不:  1);
            val_29 = val_19.flags;
            val_26 = 0;
            bool val_20 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_29, hi = val_19.hi, lo = val_19.lo, mid = val_19.mid}, d2:  new System.Decimal());
            var val_21 = (val_20 != true) ? (val_29) : 0;
            var val_22 = (val_20 != true) ? val_19.lo : 0;
            label_18:
            if(((-30760368) & 1) != 0)
            {
                goto label_24;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_25 = val_25;
            mem[1152921560410673672] = (val_20 != true) ? (val_27) : (val_32);
            label_15:
            PGCompany.东丑丒丗一丞下丙丙<T> val_24 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            this.一一丟且丝丅丛丄丙();
        }
        private void 一一丟且丝丅丛丄丙()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  (this.丂丅七与丘丞丟万丕 != 0) ? 1 : 0);
            if(this.丂丅七与丘丞丟万丕 == null)
            {
                    return;
            }
            
            this = ???;
            goto typeof(MainStorePromotionView).__il2cppRuntimeField_178;
        }
        public void U_GoToMainStore()
        {
            var val_4;
            if(this.丂丅七与丘丞丟万丕 == null)
            {
                    return;
            }
            
            val_4 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            val_4.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  this.丂丅七与丘丞丟万丕.丝丒丙一丙丄不三丞(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  this.丂丅七与丘丞丟万丕.七丈丒丒下下且万与(), 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        }
        public PixelPassCurrencyPromotionUI()
        {
        
        }
    
    }

}
