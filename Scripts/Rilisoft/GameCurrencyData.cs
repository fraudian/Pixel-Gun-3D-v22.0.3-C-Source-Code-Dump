using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameCurrencyData
    {
        // Fields
        internal 丈丞丕丘丕丗与上一 _currency;
        internal 丈丞丕丘丕丗与上一 _price;
        internal int _discount;
        private 丈丞丕丘丕丗与上一 <OldCurrency>k__BackingField;
        
        // Properties
        internal int CurrencyCount { get; }
        internal int OldCurrencyCount { get; }
        internal 丈丞丕丘丕丗与上一 Currency { get; }
        internal 丈丞丕丘丕丗与上一 Price { get; }
        internal int GemsPrice { get; }
        internal int CoinsPrice { get; }
        internal int RealPrice { get; }
        internal int Discount { get; set; }
        internal 丈丞丕丘丕丗与上一 OldCurrency { get; set; }
        internal Rilisoft.与丗丌丑专业丝丛丏 MarketProduct { get; }
        
        // Methods
        internal int get_CurrencyCount()
        {
            if(this._currency == null)
            {
                    return (int)this._currency;
            }
            
            return this._currency.丟丂丞不专丆万丒世();
        }
        internal int get_OldCurrencyCount()
        {
            if((this.<OldCurrency>k__BackingField) == null)
            {
                    return (int)this.<OldCurrency>k__BackingField;
            }
            
            return this.<OldCurrency>k__BackingField.丟丂丞不专丆万丒世();
        }
        internal 丈丞丕丘丕丗与上一 get_Currency()
        {
            return (丈丞丕丘丕丗与上一)this._currency;
        }
        internal 丈丞丕丘丕丗与上一 get_Price()
        {
            return (丈丞丕丘丕丗与上一)this._price;
        }
        internal int get_GemsPrice()
        {
            var val_3;
            if(this._price == null)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            if((System.String.op_Equality(a:  this._price.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                    return 0;
            }
            
            if(this._price != null)
            {
                    return this._price.丟丂丞不专丆万丒世();
            }
            
            return this._price.丟丂丞不专丆万丒世();
        }
        internal int get_CoinsPrice()
        {
            var val_3;
            if(this._price == null)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            if((System.String.op_Equality(a:  this._price.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                    return 0;
            }
            
            if(this._price != null)
            {
                    return this._price.丟丂丞不专丆万丒世();
            }
            
            return this._price.丟丂丞不专丆万丒世();
        }
        internal int get_RealPrice()
        {
            if(this._price == null)
            {
                    return 0;
            }
            
            if((System.String.op_Equality(a:  this._price.东与三丌丅三丒丏业(), b:  "Real")) == false)
            {
                    return 0;
            }
            
            if(this._price != null)
            {
                    return this._price.丟丂丞不专丆万丒世();
            }
            
            return this._price.丟丂丞不专丆万丒世();
        }
        internal int get_Discount()
        {
            return (int)this._discount;
        }
        internal void set_Discount(int 丙业与丙丗丝不丈东)
        {
            this._discount = 丙业与丙丗丝不丈东;
        }
        internal 丈丞丕丘丕丗与上一 get_OldCurrency()
        {
            return (丈丞丕丘丕丗与上一)this.<OldCurrency>k__BackingField;
        }
        internal void set_OldCurrency(丈丞丕丘丕丗与上一 丙业与丙丗丝不丈东)
        {
            this.<OldCurrency>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal GameCurrencyData()
        {
        
        }
        internal GameCurrencyData(丈丞丕丘丕丗与上一 丏丂不专上丘丂不丅, 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞)
        {
            val_1 = new System.Object();
            this._currency = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丏丂不专上丘丂不丅);
            this._price = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丈丞丕丘丕丗与上一 val_1 = 丒世丘丘上丆丝东丞);
        }
        internal GameCurrencyData(int 丑丏万丈丟丝丝丌丗, string 丏丂不专上丘丂不丅, int 丒世丘丘上丆丝东丞, string 丕丐丗世丌三上丌世)
        {
            val_1 = new System.Object();
            this._currency = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丑丏万丈丟丝丝丌丗, 丏丂不专上丘丂不丅:  string val_1 = 丏丂不专上丘丂不丅);
            this._price = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丒世丘丘上丆丝东丞, 丏丂不专上丘丂不丅:  丕丐丗世丌三上丌世);
        }
        internal Rilisoft.与丗丌丑专业丝丛丏 get_MarketProduct()
        {
            var val_3;
            int val_4;
            var val_5;
            System.Int32[] val_6;
            var val_7;
            var val_8;
            var val_9;
            val_3 = 0;
            val_4 = System.String.alignConst;
            goto label_1;
            label_10:
            val_5 = null;
            val_5 = null;
            val_6 = 0;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == this.RealPrice)
            {
                goto label_6;
            }
            
            val_3 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            val_6 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_3 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_10;
            }
            
            goto label_11;
            label_6:
            val_8 = null;
            val_8 = null;
            val_4 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_4 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_11:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != false)
            {
                    return 0;
            }
            
            val_9 = null;
            val_9 = null;
            if(StoreKitEventListener.丆丕丝丒不丙且丐丗 != null)
            {
                    return StoreKitEventListener.丆丕丝丒不丙且丐丗.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_4);
            }
            
            return StoreKitEventListener.丆丕丝丒不丙且丐丗.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_4);
        }
        internal string 丛不专与三丅万丌下()
        {
            丈丞丕丘丕丗与上一 val_10;
            if((System.String.op_Equality(a:  this._price.东与三丌丅三丒丏业(), b:  "Real")) != false)
            {
                    val_10 = this.MarketProduct;
                if(val_10 == null)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            }
            
                if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            }
            
                if(coinsShop.七三丗丏丑丗三丆世() == false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            }
            
                var val_11 = 0;
                val_11 = val_11 + 1;
            }
            else
            {
                    val_10 = this._price;
                string val_7 = val_10.丟丂丞不专丆万丒世().ToString();
                return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            }
            
            string val_10 = val_10.丟丂丞不专丆万丒世();
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
        }
    
    }

}
