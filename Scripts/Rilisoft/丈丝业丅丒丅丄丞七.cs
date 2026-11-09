using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丈丝业丅丒丅丄丞七 : 与丗丌丑专业丝丛丏
    {
        // Fields
        private readonly Prime31.GoogleSkuInfo 丘下东丑万丘一七上;
        
        // Properties
        public string 下丄丈不与世丐业专 { get; }
        public string 丝丈上且丂丄业且不 { get; }
        public string 丛东下丌一丕丌一丁 { get; }
        public string 丒丆丕丁丟业上七丅 { get; }
        public object 且东丆丕丟与万丐丛 { get; }
        public decimal 丄丟七丄丙丙丒上丈 { get; }
        public string 丛丟东世万丒丐且世 { get; }
        
        // Methods
        public 丈丝业丅丒丅丄丞七(Prime31.GoogleSkuInfo 丙丕下不丅世丈丆丄)
        {
            this.丘下东丑万丘一七上 = 丙丕下不丅世丈丆丄;
        }
        public string 业上丙丞丐丄丆丅七()
        {
            if(this.丘下东丑万丘一七上 != null)
            {
                    return this.丘下东丑万丘一七上.productId;
            }
            
            return this.丘下东丑万丘一七上.productId;
        }
        public string 三万丘丅丆不丘上上()
        {
            if(this.丘下东丑万丘一七上 != null)
            {
                    return this.丘下东丑万丘一七上.title;
            }
            
            return this.丘下东丑万丘一七上.title;
        }
        public string 丒丗丝不丕丈世丏丞()
        {
            if(this.丘下东丑万丘一七上 != null)
            {
                    return this.丘下东丑万丘一七上.description;
            }
            
            return this.丘下东丑万丘一七上.description;
        }
        public string 丟丂丞不专丆万丒世()
        {
            if(this.丘下东丑万丘一七上 != null)
            {
                    return this.丘下东丑万丘一七上.price;
            }
            
            return this.丘下东丑万丘一七上.price;
        }
        public object 丄世不丗丁与不下下()
        {
            return (object)this.丘下东丑万丘一七上;
        }
        public decimal 丈业且丆七三丛丙丙()
        {
            long val_4;
            long val_5;
            var val_6;
            var val_7;
            if(this.丘下东丑万丘一七上 != null)
            {
                    val_4 = this.丘下东丑万丘一七上.priceAmountMicros;
                val_5 = val_4;
                val_6 = 0;
                decimal val_2 = StoreKitEventListener.世丌丝丝丕专且下丟(丆丂上丅丗丞丏丆丁:  val_5);
                return new System.Decimal() {flags = val_5, hi = val_5, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0};
            }
            
            UnityEngine.Debug.LogErrorFormat(format:  "GoogleMarketProduct.PriceValue: _marketProduct == null", args:  System.Array.Empty<System.Object>());
            val_4 = 1152921504618881024;
            val_7 = null;
            val_7 = null;
            val_5 = System.Decimal.Zero;
            return new System.Decimal() {flags = val_5, hi = val_5, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0};
        }
        public string 东与三丌丅三丒丏业()
        {
            int val_3;
            var val_4;
            if(this.丘下东丑万丘一七上 != null)
            {
                    string val_1 = this.丘下东丑万丘一七上.priceCurrencyCode;
                val_3 = val_1;
                if(val_1 != null)
            {
                    return (string)val_3;
            }
            
                val_4 = null;
            }
            else
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "GoogleMarketProduct.Currency: _marketProduct == null", args:  System.Array.Empty<System.Object>());
                val_4 = null;
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            var val_1 = (null == null) ? 万且万且丑丗且丌丆 : 0;
            if(null != null)
            {
                    return false;
            }
            
            if(this.丘下东丑万丘一七上 != null)
            {
                    return this.丘下东丑万丘一七上.Equals(obj:  typeof(System.Object) == null ? 万且万且丑丗且丌丆 : 0 + 16);
            }
            
            return this.丘下东丑万丘一七上.Equals(obj:  typeof(System.Object) == null ? 万且万且丑丗且丌丆 : 0 + 16);
        }
        public override int GetHashCode()
        {
            if(this.丘下东丑万丘一七上 != null)
            {
                    return this.丘下东丑万丘一七上.GetHashCode();
            }
            
            return this.丘下东丑万丘一七上.GetHashCode();
        }
        public override string ToString()
        {
            if(this.丘下东丑万丘一七上 == null)
            {
                
            }
        
        }
    
    }

}
