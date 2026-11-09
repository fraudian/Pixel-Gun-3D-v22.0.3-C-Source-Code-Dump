using UnityEngine;

namespace Rilisoft
{
    public class GameEventCurrencyView : MonoBehaviour
    {
        // Fields
        private UILabel _count;
        private UILabel _freeCount;
        private UnityEngine.GameObject _freeObject;
        private UILabel _price;
        private UnityEngine.GameObject _priceObject;
        private UIBasicSprite _eventCurrencyTexture;
        private bool _holdEventCurrencyTexture;
        private UIBasicSprite _gemsTexture;
        private UIBasicSprite _coinsTexture;
        private Rilisoft.GameCurrencyData <不丑丂上丘丒丙与丅>k__BackingField;
        private System.Action<Rilisoft.GameEventCurrencyView> 一万东丛且不丌丁丈;
        
        // Properties
        public Rilisoft.GameCurrencyData 丈且丌业上一丌不丞 { get; set; }
        
        // Methods
        public Rilisoft.GameCurrencyData get_CurrencyData()
        {
            return (Rilisoft.GameCurrencyData)this.<不丑丂上丘丒丙与丅>k__BackingField;
        }
        private void 丛且上丅丕丘不丙丄(Rilisoft.GameCurrencyData 丙业与丙丗丝不丈东)
        {
            this.<不丑丂上丘丒丙与丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void add_Click(System.Action<Rilisoft.GameEventCurrencyView> 丙业与丙丗丝不丈东)
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
            while(this.一万东丛且不丌丁丈 != 1152921542830468504);
        
        }
        public void remove_Click(System.Action<Rilisoft.GameEventCurrencyView> 丙业与丙丗丝不丈东)
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
            while(this.一万东丛且不丌丁丈 != 1152921542830605080);
        
        }
        public void Set(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            UILabel val_23;
            var val_25;
            var val_26;
            UIBasicSprite val_27;
            var val_28;
            val_23 = this;
            this.<不丑丂上丘丒丙与丅>k__BackingField = 一下世丆丙万丞东丆;
            if(this._priceObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._priceObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this._freeObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObject, 丏业丟一东丂东丘丛:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._eventCurrencyTexture, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._gemsTexture, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._coinsTexture, 丏业丟一东丂东丘丛:  false);
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  一下世丆丙万丞东丆._price.东与三丌丅三丒丏业())) == false)
            {
                goto label_15;
            }
            
            if(this._eventCurrencyTexture == 0)
            {
                goto label_53;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._eventCurrencyTexture, 丏业丟一东丂东丘丛:  true);
            if(this._holdEventCurrencyTexture == true)
            {
                goto label_53;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
            {
                goto label_24;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_9 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().Context;
            goto label_26;
            label_15:
            val_25 = null;
            val_25 = null;
            if((System.String.op_Equality(a:  一下世丆丙万丞东丆._price.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_30;
            }
            
            val_26 = null;
            val_27 = this._gemsTexture;
            goto label_38;
            label_30:
            val_28 = null;
            val_28 = null;
            if((System.String.op_Equality(a:  一下世丆丙万丞东丆._price.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_53;
            }
            
            val_26 = null;
            val_27 = this._coinsTexture;
            label_38:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_27, 丏业丟一东丂东丘丛:  true);
            label_53:
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  一下世丆丙万丞东丆);
            if(this._count == 0)
            {
                    return;
            }
            
            val_23 = this._count;
            val_23.text = 一下世丆丙万丞东丆._currency.丟丂丞不专丆万丒世().ToString();
            return;
            label_24:
            Rilisoft.丛且世丐丆上七业丁 val_18 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            label_26:
            if(((val_18 == null) || ((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_18.丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  一下世丆丙万丞东丆._price.丟丂丞不专丆万丒世()))) == 0)) || (this._eventCurrencyTexture != null))
            {
                goto label_53;
            }
            
            goto label_53;
        }
        public void SetAsFree(int 丟丂丄丌万丞丝丗丑)
        {
            UnityEngine.GameObject val_7;
            UILabel val_8;
            val_7 = this;
            if(this._priceObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._priceObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._freeObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObject, 丏业丟一东丂东丘丛:  true);
            }
            
            val_8 = this._freeCount;
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8 = this._freeCount;
            if(丟丂丄丌万丞丝丗丑 >= 2)
            {
                    val_8.text = 丟丂丄丌万丞丝丗丑.ToString();
                val_7 = this._freeCount.gameObject;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void SetAsFree(int 丟丂丄丌万丞丝丗丑, string 丆丗丘丕且丈丘丁不)
        {
            if(this._priceObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._priceObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._freeObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this._freeCount == 0)
            {
                    return;
            }
            
            if(丟丂丄丌万丞丝丗丑 >= 2)
            {
                    this._freeCount.text = System.String.Format(format:  丆丗丘丕且丈丘丁不, arg0:  丟丂丄丌万丞丝丗丑);
                this = this._freeCount.gameObject;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  true);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeCount.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void SetAsFreeNoCount()
        {
            if(this._priceObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._priceObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._freeObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this._freeCount == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeCount.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        private void OnClick()
        {
            if(this.一万东丛且不丌丁丈 == null)
            {
                    return;
            }
            
            this.一万东丛且不丌丁丈.Invoke(obj:  this);
        }
        public void U_Click()
        {
            this.OnClick();
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
        private void Awake()
        {
            FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventCurrencyView::专丈且丆丄专丒丁丅()));
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
            FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventCurrencyView::专丈且丆丄专丒丁丅()));
        }
        public GameEventCurrencyView()
        {
        
        }
    
    }

}
