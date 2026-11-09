using UnityEngine;

namespace Rilisoft
{
    public class BPCurrencyView : MonoBehaviour
    {
        // Fields
        private UILabel _count;
        private UILabel _newCount;
        private UILabel _oldCount;
        private UILabel _discount;
        private UILabel _price;
        private PGCompany.InventoryItemView _itemView;
        private UnityEngine.GameObject _bestPriceGO;
        private UnityEngine.GameObject _countGO;
        private UnityEngine.GameObject _discountCountGO;
        private UnityEngine.GameObject _discountGO;
        private UnityEngine.GameObject _enoughForBP;
        private UnityEngine.GameObject _enoughForBK;
        private Rilisoft.GameCurrencyData <不丑丂上丘丒丙与丅>k__BackingField;
        private System.Action<Rilisoft.BPCurrencyView> 一万东丛且不丌丁丈;
        private System.Action<Rilisoft.BPCurrencyView> 丛下丟与丟不丙丝且;
        
        // Properties
        public Rilisoft.GameCurrencyData 丈且丌业上一丌不丞 { get; set; }
        internal bool 丞丐与上与东丆一丞 { get; }
        internal bool 不丆上丗不且丞丂业 { get; }
        
        // Methods
        public Rilisoft.GameCurrencyData get_CurrencyData()
        {
            return (Rilisoft.GameCurrencyData)this.<不丑丂上丘丒丙与丅>k__BackingField;
        }
        private void 丛且上丅丕丘不丙丄(Rilisoft.GameCurrencyData 丙业与丙丗丝不丈东)
        {
            this.<不丑丂上丘丒丙与丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void add_Click(System.Action<Rilisoft.BPCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.一万东丛且不丌丁丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一万东丛且不丌丁丈 != 1152921542344950960);
        
        }
        public void remove_Click(System.Action<Rilisoft.BPCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.一万东丛且不丌丁丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一万东丛且不丌丁丈 != 1152921542345087536);
        
        }
        public void add_GiftClick(System.Action<Rilisoft.BPCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛下丟与丟不丙丝且, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛下丟与丟不丙丝且 != 1152921542345224120);
        
        }
        public void remove_GiftClick(System.Action<Rilisoft.BPCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛下丟与丟不丙丝且, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛下丟与丟不丙丝且 != 1152921542345360696);
        
        }
        internal bool 与丟丂丙丙丝丁下业()
        {
            if(this._enoughForBP != null)
            {
                    return this._enoughForBP.activeSelf;
            }
            
            return this._enoughForBP.activeSelf;
        }
        internal bool 下业丝丞丟上丙丝七()
        {
            if(this._enoughForBK != null)
            {
                    return this._enoughForBK.activeSelf;
            }
            
            return this._enoughForBK.activeSelf;
        }
        public void Set(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆, bool 且丆东丌丅三丂丂七, bool 丘与丐丕丟丕丒丄丁)
        {
            var val_32;
            var val_33;
            UnityEngine.GameObject val_34;
            var val_35;
            UnityEngine.GameObject val_36;
            UILabel val_37;
            var val_39;
            val_32 = 丘与丐丕丟丕丒丄丁;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            PGCompany.三东丏不丗世丅丌丄 val_4 = 一下世丆丙万丞东丆.Currency.与丒上与丄丒丝三七();
            int val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  val_4, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            this.<不丑丂上丘丒丙与丅>k__BackingField = 一下世丆丙万丞东丆;
            this._itemView.Setup(丈丄不七三万丄丁不:  val_4);
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  一下世丆丙万丞东丆);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._discountCountGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._discountGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughForBP, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughForBK, 丏业丟一东丂东丘丛:  false);
            if((val_2 == null) || (val_2.专丟专一丒且丘与丌() != 0))
            {
                goto label_17;
            }
            
            if((val_32 == true) || (val_6 >= val_2.三丒丅世业三丈丙丕()))
            {
                goto label_11;
            }
            
            val_32 = val_4.丂丁丏一丙丛业且丌();
            if((val_32 + val_6) >= val_2.三丒丅世业三丈丙丕())
            {
                goto label_13;
            }
            
            label_11:
            if(((且丆东丌丅三丂丂七 == true) || (val_6 >= val_2.不世丆丒丛七丘与丅())) || ((val_4.丂丁丏一丙丛业且丌() + val_6) < val_2.不世丆丒丛七丘与丅()))
            {
                goto label_17;
            }
            
            val_33 = null;
            val_34 = this._enoughForBP;
            goto label_21;
            label_13:
            val_33 = null;
            val_34 = this._enoughForBK;
            label_21:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_34, 丏业丟一东丂东丘丛:  true);
            label_17:
            if(一下世丆丙万丞东丆.Price.丟丂丞不专丆万丒世() == 10)
            {
                    val_35 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bestPriceGO, 丏业丟一东丂东丘丛:  (一下世丆丙万丞东丆.Price.丟丂丞不专丆万丒世() == 20) ? 1 : 0);
            if(一下世丆丙万丞东丆.OldCurrency != null)
            {
                    if(一下世丆丙万丞东丆.Currency.丟丂丞不专丆万丒世() != 一下世丆丙万丞东丆.OldCurrency.丟丂丞不专丆万丒世())
            {
                goto label_36;
            }
            
            }
            
            val_36 = this._countGO;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  true);
            val_37 = this._count;
            int val_26 = 一下世丆丙万丞东丆.CurrencyCount;
            val_39 = null;
            goto label_40;
            label_36:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._discountCountGO, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._discountGO, 丏业丟一东丂东丘丛:  (一下世丆丙万丞东丆.Discount > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._newCount, 丕丗丘丑丛与丑业丒:  一下世丆丙万丞东丆.CurrencyCount);
            val_36 = this._oldCount;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_36, 丕丗丘丑丛与丑业丒:  一下世丆丙万丞东丆.OldCurrencyCount);
            val_37 = this._discount;
            val_39 = null;
            label_40:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_37, 丕丗丘丑丛与丑业丒:  一下世丆丙万丞东丆.Discount);
        }
        private void OnClick()
        {
            if(this.一万东丛且不丌丁丈 == null)
            {
                    return;
            }
            
            this.一万东丛且不丌丁丈.Invoke(obj:  this);
        }
        public void U_GiftClick()
        {
            if(this.丛下丟与丟不丙丝且 == null)
            {
                    return;
            }
            
            this.丛下丟与丟不丙丝且.Invoke(obj:  this);
        }
        public void U_Click()
        {
            this.OnClick();
        }
        private void Awake()
        {
            FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.BPCurrencyView::专丈且丆丄专丒丁丅()));
        }
        private void 专丈且丆丄专丒丁丅()
        {
            if((this.<不丑丂上丘丒丙与丅>k__BackingField) == null)
            {
                    return;
            }
            
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  this.<不丑丂上丘丒丙与丅>k__BackingField);
        }
        private void OnDestroy()
        {
            FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.BPCurrencyView::专丈且丆丄专丒丁丅()));
        }
        private void 丘丈丅丝丙丌不一丆(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            UnityEngine.Object val_5 = this.gameObject;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = this._price;
            if(val_5 == 0)
            {
                    return;
            }
            
            this._price.text = 一下世丆丙万丞东丆.丛不专与三丅万丌下();
        }
        public BPCurrencyView()
        {
        
        }
    
    }

}
