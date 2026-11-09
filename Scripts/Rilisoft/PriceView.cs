using UnityEngine;

namespace Rilisoft
{
    public class PriceView : MonoBehaviour
    {
        // Fields
        private UISprite _currencySprite;
        private UnityEngine.GameObject[] _disableIfFree;
        private UILabel _labelFree;
        private UILabel _labelPrice;
        private UILabel[] _labelsPrice;
        private UILabel[] _labelsRealPrice;
        private UnityEngine.GameObject _objCoins;
        private UnityEngine.GameObject _objGems;
        private System.Action 丌不丂丌丁丛丆丟与;
        
        // Methods
        public void add_OnClicked(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌不丂丌丁丛丆丟与 != 1152921543595411944);
        
        }
        public void remove_OnClicked(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌不丂丌丁丛丆丟与 != 1152921543595548520);
        
        }
        internal void 丗丘丗丈丑丒丗七丘(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, string 万丐丁三且下丞丈丌)
        {
            int val_6;
            var val_7;
            if(丒世丘丘上丆丝东丞 != null)
            {
                    val_6 = 丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世();
            }
            else
            {
                    val_6 = 0.丟丂丞不专丆万丒世();
            }
            
            val_7 = null;
            val_7 = null;
            this.SetPrice(丒世丘丘上丆丝东丞:  val_6, 与一丗丈丙东七上丒:  System.String.op_Equality(a:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝), 万丐丁三且下丞丈丌:  null);
        }
        public void SetPrice(int 丒世丘丘上丆丝东丞, bool 与一丗丈丙东七上丒, string 万丐丁三且下丞丈丌)
        {
            int val_26;
            var val_27;
            System.Action<UILabel> val_29;
            var val_30;
            System.Action<UnityEngine.GameObject> val_32;
            string val_33;
            var val_34;
            var val_36;
            val_26 = 丒世丘丘上丆丝东丞;
            val_27 = null;
            val_27 = null;
            val_29 = PriceView.<>c.<>9__12_0;
            if(val_29 == null)
            {
                    System.Action<UILabel> val_1 = null;
                val_29 = val_1;
                val_1 = new System.Action<UILabel>(object:  PriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PriceView.<>c::丅下与丌世丗世丕丑(UILabel 丐三丞七丝丅不万丛));
                PriceView.<>c.<>9__12_0 = val_29;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._labelsRealPrice, 七丐丅专且专七三丆:  val_1);
            if(val_26 < 1)
            {
                goto label_8;
            }
            
            .丒丄东业上丘丐丈世 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_26);
            if(this._labelPrice != 0)
            {
                    this._labelPrice.gameObject.SetActive(value:  true);
                val_29 = (PriceView.丒丛丁与丅东丒不七)[1152921543596227344].丒丄东业上丘丐丈世;
                this._labelPrice.text = val_29;
            }
            
            if(this._labelsPrice != null)
            {
                    System.Action<UILabel> val_6 = null;
                val_29 = val_6;
                val_6 = new System.Action<UILabel>(object:  new PriceView.丒丛丁与丅东丒不七(), method:  System.Void PriceView.丒丛丁与丅东丒不七::丟丑丁丂东丐下世业(UILabel 丐三丞七丝丅不万丛));
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._labelsPrice, 七丐丅专且专七三丆:  val_6);
            }
            
            if(this._objGems != 0)
            {
                    this._objGems.SetActive(value:  与一丗丈丙东七上丒);
            }
            
            if(this._objCoins != 0)
            {
                    this._objCoins.SetActive(value:  (~与一丗丈丙东七上丒) & 1);
            }
            
            if(this._labelFree != 0)
            {
                    this._labelFree.gameObject.SetActive(value:  false);
            }
            
            if(this._disableIfFree != null)
            {
                    val_30 = null;
                val_30 = null;
                val_32 = PriceView.<>c.<>9__12_4;
                if(val_32 == null)
            {
                    System.Action<UnityEngine.GameObject> val_13 = null;
                val_32 = val_13;
                val_13 = new System.Action<UnityEngine.GameObject>(object:  PriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PriceView.<>c::丙东丐丞丏丟丌丟丅(UnityEngine.GameObject 丄三丅七丆丛与与上));
                PriceView.<>c.<>9__12_4 = val_32;
            }
            
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  this._disableIfFree, 七丐丅专且专七三丆:  val_13);
            }
            
            val_26 = this._currencySprite;
            if(val_26 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currencySprite.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this._currencySprite == null)
            {
                goto label_48;
            }
            
            if(与一丗丈丙东七上丒 == false)
            {
                goto label_49;
            }
            
            label_91:
            val_33 = "item_levelup_gems";
            goto label_50;
            label_8:
            val_29 = 1152921504848912384;
            if(this._labelFree != 0)
            {
                    this._labelFree.gameObject.SetActive(value:  true);
            }
            
            if(this._disableIfFree != null)
            {
                    val_34 = null;
                val_34 = null;
                val_26 = PriceView.<>c.<>9__12_1;
                if(val_26 == null)
            {
                    System.Action<UnityEngine.GameObject> val_18 = null;
                val_26 = val_18;
                val_18 = new System.Action<UnityEngine.GameObject>(object:  PriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PriceView.<>c::丅丏且丂丝丗丁丛丈(UnityEngine.GameObject 丄三丅七丆丛与与上));
                PriceView.<>c.<>9__12_1 = val_26;
            }
            
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  this._disableIfFree, 七丐丅专且专七三丆:  val_18);
            }
            
            if(this._labelsPrice != null)
            {
                    val_36 = null;
                val_36 = null;
                val_26 = PriceView.<>c.<>9__12_2;
                if(val_26 == null)
            {
                    System.Action<UILabel> val_19 = null;
                val_26 = val_19;
                val_19 = new System.Action<UILabel>(object:  PriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PriceView.<>c::世东世丄丅丛丁丆且(UILabel 丐三丞七丝丅不万丛));
                PriceView.<>c.<>9__12_2 = val_26;
            }
            
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._labelsPrice, 七丐丅专且专七三丆:  val_19);
            }
            
            if(this._labelPrice != 0)
            {
                    this._labelPrice.gameObject.SetActive(value:  false);
            }
            
            if(this._objGems != 0)
            {
                    this._objGems.SetActive(value:  false);
            }
            
            if(this._objCoins != 0)
            {
                    this._objCoins.SetActive(value:  false);
            }
            
            if(this._currencySprite == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currencySprite.gameObject, 丏业丟一东丂东丘丛:  false);
            return;
            label_48:
            if(与一丗丈丙东七上丒 == true)
            {
                goto label_91;
            }
            
            label_49:
            val_33 = "item_levelup_coin";
            label_50:
            this._currencySprite.spriteName = val_33;
        }
        public void SetRealPrice(string 丕丗丘丑丛与丑业丒)
        {
            var val_15;
            System.Action<UnityEngine.GameObject> val_17;
            var val_18;
            System.Action<UILabel> val_20;
            .丕丗丘丑丛与丑业丒 = 丕丗丘丑丛与丑业丒;
            if(this._labelPrice != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._labelPrice.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._objGems != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._objGems.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._objCoins != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._objCoins.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._currencySprite != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currencySprite.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._labelFree != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._labelFree.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = PriceView.<>c.<>9__13_0;
            if(val_17 == null)
            {
                    System.Action<UnityEngine.GameObject> val_12 = null;
                val_17 = val_12;
                val_12 = new System.Action<UnityEngine.GameObject>(object:  PriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PriceView.<>c::三东丅三丞丙丞丘丆(UnityEngine.GameObject 丄三丅七丆丛与与上));
                PriceView.<>c.<>9__13_0 = val_17;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  this._disableIfFree, 七丐丅专且专七三丆:  val_12);
            val_18 = null;
            val_18 = null;
            val_20 = PriceView.<>c.<>9__13_1;
            if(val_20 == null)
            {
                    System.Action<UILabel> val_13 = null;
                val_20 = val_13;
                val_13 = new System.Action<UILabel>(object:  PriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PriceView.<>c::丘与丟且一丆世三丝(UILabel 丐三丞七丝丅不万丛));
                PriceView.<>c.<>9__13_1 = val_20;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._labelsPrice, 七丐丅专且专七三丆:  val_13);
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._labelsRealPrice, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new PriceView.世东丒与丞七不不东(), method:  System.Void PriceView.世东丒与丞七不不东::丗丛丈且丘三丌不丒(UILabel 丐三丞七丝丅不万丛)));
        }
        private void OnClick()
        {
            if(this.丌不丂丌丁丛丆丟与 == null)
            {
                    return;
            }
            
            this.丌不丂丌丁丛丆丟与.Invoke();
        }
        private void 丞丙东丌一三专丏不()
        {
        
        }
        public PriceView()
        {
        
        }
    
    }

}
