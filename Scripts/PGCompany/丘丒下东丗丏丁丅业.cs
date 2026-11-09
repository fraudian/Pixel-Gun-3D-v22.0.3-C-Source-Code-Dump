using UnityEngine;

namespace PGCompany
{
    internal class 丘丒下东丗丏丁丅业
    {
        // Fields
        internal 丈丞丕丘丕丗与上一 Price;
        internal System.Collections.Generic.List<Rilisoft.OfferItem> Items;
        private Rilisoft.丝丑丂丛万丐丈丘且 _saleContainer;
        
        // Properties
        internal int 丂世丙丗丁丝丝丛业 { get; set; }
        internal Rilisoft.与丗丌丑专业丝丛丏 丛丁三丝上丈丏丅东 { get; }
        
        // Methods
        internal int 丆丞上丛丂一业丟丕()
        {
        
        }
        internal void 丒丒丕丟不丂丁东三(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._saleContainer = val_1;
            mem[1152921555520544616] = val_1.上万三丆专丏丒丗业;
        }
        internal Rilisoft.与丗丌丑专业丝丛丏 丄丑且丆上丛丁且七()
        {
            var val_3;
            int val_4;
            var val_5;
            丈丞丕丘丕丗与上一 val_6;
            var val_7;
            var val_8;
            var val_9;
            val_3 = 0;
            val_4 = System.String.alignConst;
            goto label_1;
            label_11:
            val_5 = null;
            val_5 = null;
            val_6 = this.Price;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == val_6.丟丂丞不专丆万丒世())
            {
                goto label_7;
            }
            
            val_3 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            val_6 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_3 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_11;
            }
            
            goto label_12;
            label_7:
            val_8 = null;
            val_8 = null;
            val_4 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_4 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_12:
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
        internal string 丈世下下丅丕丐丗丁()
        {
            var val_6;
            Rilisoft.与丗丌丑专业丝丛丏 val_1 = this.丄丑且丆上丛丁且七();
            if(val_1 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    if(this.Price == null)
            {
                    return (string)val_6.丟丂丞不专丆万丒世();
            }
            
                string val_3 = this.Price.丟丂丞不专丆万丒世().ToString();
                return (string)val_6.丟丂丞不专丆万丒世();
            }
            
            val_6 = val_1;
            return (string)val_6.丟丂丞不专丆万丒世();
        }
        internal decimal 丕丗丁七下且与丝万()
        {
            string val_13;
            var val_14;
            var val_15;
            if(this.Items == null)
            {
                goto label_3;
            }
            
            val_13 = public System.Int32 System.Collections.Generic.List<Rilisoft.OfferItem>::get_Count();
            if((this.Items.Count == 0) || (this.丄丑且丆上丛丁且七() == null))
            {
                goto label_3;
            }
            
            val_13 = "Real";
            if((System.String.op_Inequality(a:  this.Price.东与三丌丅三丒丏业(), b:  val_13)) == false)
            {
                goto label_5;
            }
            
            label_3:
            val_14 = null;
            val_14 = null;
            return new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.MinusOne, lo = System.Decimal.Powers10.__il2cppRuntimeField_30>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_30>>32&0x0};
            label_5:
            decimal val_6 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且丄丗东丌业下东丐(丑七不与丛丆一丂丞:  this.Items, 世丈三丐丞一丒丛不:  this.Price.丟丂丞不专丆万丒世());
            val_15 = null;
            val_15 = null;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
            {
                    return new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.MinusOne, lo = System.Decimal.Powers10.__il2cppRuntimeField_30>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_30>>32&0x0};
            }
            
            decimal val_9 = System.Decimal.op_Implicit(value:  this.Price.丟丂丞不专丆万丒世());
            decimal val_10 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, d2:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
            var val_14 = 0;
            val_14 = val_14 + 1;
            decimal val_13 = this.丄丑且丆上丛丁且七().丈业且丆七三丛丙丙();
            return System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid}, d2:  new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid});
        }
        internal int 与丞丄丛东丕丈上且()
        {
            var val_4;
            var val_5;
            丈丞丕丘丕丗与上一 val_6;
            var val_7;
            if((System.String.op_Equality(a:  this.Price.东与三丌丅三丒丏业(), b:  "Real")) == false)
            {
                    return 0;
            }
            
            val_4 = 0;
            goto label_5;
            label_15:
            val_5 = null;
            val_5 = null;
            val_6 = this.Price;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == val_6.丟丂丞不专丆万丒世())
            {
                    return 0;
            }
            
            val_4 = 1;
            label_5:
            val_7 = null;
            val_7 = null;
            val_6 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_4 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_15;
            }
            
            return 0;
        }
        internal string 丑丈丏业业丄丙丏且()
        {
            丈丞丕丘丕丗与上一 val_4;
            int val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = this.Price;
            val_5 = System.String.alignConst;
            if((System.String.op_Equality(a:  val_4.东与三丌丅三丒丏业(), b:  "Real")) == false)
            {
                    return (string)val_5;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            goto label_5;
            label_15:
            val_8 = null;
            val_8 = null;
            val_4 = this.Price;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == val_4.丟丂丞不专丆万丒世())
            {
                goto label_11;
            }
            
            val_7 = 1;
            label_5:
            val_9 = null;
            val_9 = null;
            val_4 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_7 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_15;
            }
            
            return (string)val_5;
            label_11:
            val_5 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_5 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            return (string)val_5;
        }
        public 丘丒下东丗丏丁丅业()
        {
        
        }
    
    }

}
