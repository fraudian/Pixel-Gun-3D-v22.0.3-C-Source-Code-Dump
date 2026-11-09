using UnityEngine;

namespace Rilisoft.Offers
{
    [Serializable]
    internal class AdaptiveOfferItem : IDisposable, 丈一万丗业丄东下与
    {
        // Fields
        private Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType <Module>k__BackingField;
        private int <Real>k__BackingField;
        private Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 <Size>k__BackingField;
        private int <Sale>k__BackingField;
        private System.Collections.Generic.List<Rilisoft.OfferItem> <Items>k__BackingField;
        private string _uniqueId;
        private int <Parameter>k__BackingField;
        private static int <RentedCount>k__BackingField;
        private static System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem> _pool;
        
        // Properties
        internal Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType Module { get; set; }
        internal int Real { get; set; }
        internal Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 Size { get; set; }
        internal int Sale { get; set; }
        internal System.Collections.Generic.List<Rilisoft.OfferItem> Items { get; set; }
        internal string UniqueId { get; }
        internal int Parameter { get; set; }
        internal static int RentedCount { get; set; }
        
        // Methods
        internal Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType get_Module()
        {
            return (AdaptiveModuleType)this.<Module>k__BackingField;
        }
        private void set_Module(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丙业与丙丗丝不丈东)
        {
            this.<Module>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int get_Real()
        {
            return (int)this.<Real>k__BackingField;
        }
        private void set_Real(int 丙业与丙丗丝不丈东)
        {
            this.<Real>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 get_Size()
        {
            return (丂丘丛下丆一丕丂丅)this.<Size>k__BackingField;
        }
        private void set_Size(Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丙业与丙丗丝不丈东)
        {
            this.<Size>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int get_Sale()
        {
            return (int)this.<Sale>k__BackingField;
        }
        private void set_Sale(int 丙业与丙丗丝不丈东)
        {
            this.<Sale>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<Rilisoft.OfferItem> get_Items()
        {
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)this.<Items>k__BackingField;
        }
        private void set_Items(System.Collections.Generic.List<Rilisoft.OfferItem> 丙业与丙丗丝不丈东)
        {
            this.<Items>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string get_UniqueId()
        {
            string val_3;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._uniqueId)) != false)
            {
                    this._uniqueId = Rilisoft.Offers.AdaptiveOfferItem.丘丐丕世下丟丁丛三(丛丅丐丒丈不丅丐丄:  this);
                return val_3;
            }
            
            val_3 = this._uniqueId;
            return val_3;
        }
        internal int get_Parameter()
        {
            return (int)this.<Parameter>k__BackingField;
        }
        private void set_Parameter(int 丙业与丙丗丝不丈东)
        {
            this.<Parameter>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static int get_RentedCount()
        {
            null = null;
            return (int)Rilisoft.Offers.AdaptiveOfferItem.<RentedCount>k__BackingField;
        }
        private static void set_RentedCount(int 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.Offers.AdaptiveOfferItem.<RentedCount>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static Rilisoft.Offers.AdaptiveOfferItem 丂丈世不七丆一丛下(Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType 丕上业丕丘上丘七一, int 世丈三丐丞一丒丛不, int 与丝丙丝万丑丞丄一, Rilisoft.Offers.AdaptiveOfferItem.丂丘丛下丆一丕丂丅 丟丒且一专丟丙下一, int 丆且丁丒丒丆丁三丆 = 0)
        {
            var val_7;
            var val_8;
            Rilisoft.Offers.AdaptiveOfferItem val_9;
            var val_10;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            if(Rilisoft.Offers.AdaptiveOfferItem._pool.Count < 1)
            {
                goto label_4;
            }
            
            val_8 = null;
            val_9 = Rilisoft.Offers.AdaptiveOfferItem._pool.Item[0];
            bool val_3 = Rilisoft.Offers.AdaptiveOfferItem._pool.Remove(item:  val_9);
            if(val_9 == null)
            {
                goto label_9;
            }
            
            label_11:
            val_2.<Sale>k__BackingField = 与丝丙丝万丑丞丄一;
            val_2.<Module>k__BackingField = 丕上业丕丘上丘七一;
            val_2.<Real>k__BackingField = 世丈三丐丞一丒丛不;
            goto label_10;
            label_4:
            Rilisoft.Offers.AdaptiveOfferItem val_4 = null;
            val_9 = val_4;
            val_4 = new Rilisoft.Offers.AdaptiveOfferItem();
            if(val_9 != null)
            {
                goto label_11;
            }
            
            label_9:
            mem[16] = 丕上业丕丘上丘七一;
            .<Sale>k__BackingField = 与丝丙丝万丑丞丄一;
            .<Real>k__BackingField = 世丈三丐丞一丒丛不;
            label_10:
            .<Size>k__BackingField = 丟丒且一专丟丙下一;
            .<Items>k__BackingField = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.OfferItem>.万世丅七一专丕丞不();
            val_10 = null;
            int val_6 = Rilisoft.Offers.AdaptiveOfferItem.RentedCount;
            val_6 = val_6 + 1;
            Rilisoft.Offers.AdaptiveOfferItem.RentedCount = val_6;
            return (Rilisoft.Offers.AdaptiveOfferItem)val_9;
        }
        internal void 丑与东丙丑丘丁丂丒(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            if((this.<Items>k__BackingField.Contains(item:  下丅丙一丂丗丅丝七)) == true)
            {
                    return;
            }
            
            this.<Items>k__BackingField.Add(item:  下丅丙一丂丗丅丝七);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._uniqueId)) == true)
            {
                    return;
            }
            
            this._uniqueId = 0;
        }
        internal void 丑与东丙丑丘丁丂丒(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅)
        {
            string val_3 = 丞丅上丏丂且下丅与;
            Rilisoft.OfferItem val_1 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞丅上丏丂且下丅与:  val_3 = 丞丅上丏丂且下丅与, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
            if(val_1 == null)
            {
                    return;
            }
            
            val_3 = this.<Items>k__BackingField;
            val_3.Add(item:  val_1);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._uniqueId)) == true)
            {
                    return;
            }
            
            this._uniqueId = 0;
        }
        internal void 丑与东丙丑丘丁丂丒(string 丞丕丒专一下丙业上)
        {
            Rilisoft.OfferItem val_1 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丞丕丒专一下丙业上:  丞丕丒专一下丙业上);
            if(val_1 == null)
            {
                    return;
            }
            
            this.<Items>k__BackingField.Add(item:  val_1);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._uniqueId)) == true)
            {
                    return;
            }
            
            this._uniqueId = 0;
        }
        internal void 丐丒丒丏丈丄丘丑丘(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            if((this.<Items>k__BackingField.Contains(item:  下丅丙一丂丗丅丝七)) == false)
            {
                    return;
            }
            
            bool val_2 = this.<Items>k__BackingField.Remove(item:  下丅丙一丂丗丅丝七);
        }
        private AdaptiveOfferItem()
        {
        
        }
        public void Dispose()
        {
            var val_3;
            var val_8;
            var val_9;
            if((this.<Items>k__BackingField) == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = this.<Items>k__BackingField.GetEnumerator();
            label_7:
            if((568739488 & 1) == 0)
            {
                goto label_2;
            }
            
            Rilisoft.OfferItem.丁丟丞丗丆七丙丐丌(下丅丙一丂丗丅丝七:  val_3.丐丏七丌丕丗业且上());
            val_8 = null;
            int val_5 = Rilisoft.Offers.AdaptiveOfferItem.RentedCount;
            val_5 = val_5 - 1;
            Rilisoft.Offers.AdaptiveOfferItem.RentedCount = val_5;
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.东丑丒丗一丞下丙丙<T> val_6 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.OfferItem>.万世丅七一专丕丞不();
            this.<Items>k__BackingField = 0;
            label_1:
            this.<Module>k__BackingField = 0;
            this.<Sale>k__BackingField = 0;
            this.<Size>k__BackingField = 0;
            this.<Parameter>k__BackingField = 0;
            this._uniqueId = System.String.alignConst;
            val_9 = null;
            val_9 = null;
            Rilisoft.Offers.AdaptiveOfferItem._pool.Add(item:  this);
        }
        public override string ToString()
        {
            return Rilisoft.Offers.AdaptiveOfferItem.丘丐丕世下丟丁丛三(丛丅丐丒丈不丅丐丄:  this);
        }
        public string 丙业不丝丗丌丗世下()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (string)DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        private static string 丘丐丕世下丟丁丛三(Rilisoft.Offers.AdaptiveOfferItem 丛丅丐丒丈不丅丐丄)
        {
            int val_7;
            var val_8;
            System.Func<Rilisoft.OfferItem, System.String> val_10;
            var val_11;
            System.Func<System.String, System.String, System.String> val_13;
            val_7 = System.String.alignConst;
            if((丛丅丐丒丈不丅丐丄.<Items>k__BackingField) != null)
            {
                    val_8 = null;
                val_8 = null;
                val_10 = AdaptiveOfferItem.<>c.<>9__41_0;
                if(val_10 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.String> val_1 = null;
                val_10 = val_1;
                val_1 = new System.Func<Rilisoft.OfferItem, System.String>(object:  AdaptiveOfferItem.<>c.__il2cppRuntimeField_static_fields, method:  System.String AdaptiveOfferItem.<>c::三丑与万丛丝丝一三(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                AdaptiveOfferItem.<>c.<>9__41_0 = val_10;
            }
            
                val_11 = null;
                val_11 = null;
                val_13 = AdaptiveOfferItem.<>c.<>9__41_1;
                if(val_13 == null)
            {
                    System.Func<System.String, System.String, System.String> val_3 = null;
                val_13 = val_3;
                val_3 = new System.Func<System.String, System.String, System.String>(object:  AdaptiveOfferItem.<>c.__il2cppRuntimeField_static_fields, method:  System.String AdaptiveOfferItem.<>c::下业业七丐丕专丑丁(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
                AdaptiveOfferItem.<>c.<>9__41_1 = val_13;
            }
            
                val_7 = System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  丛丅丐丒丈不丅丐丄.<Items>k__BackingField, selector:  val_1), func:  val_3);
            }
            
            object[] val_5 = new object[5];
            val_5[0] = 丛丅丐丒丈不丅丐丄.<Module>k__BackingField;
            val_5[1] = 丛丅丐丒丈不丅丐丄.<Real>k__BackingField;
            val_5[2] = 丛丅丐丒丈不丅丐丄.<Size>k__BackingField;
            val_5[3] = 丛丅丐丒丈不丅丐丄.<Sale>k__BackingField;
            val_5[4] = val_7;
            return (string)System.String.Format(format:  "{0}:{1}:{2}:{3}:[{4}]", args:  val_5);
        }
        private static AdaptiveOfferItem()
        {
            Rilisoft.Offers.AdaptiveOfferItem._pool = new System.Collections.Generic.List<Rilisoft.Offers.AdaptiveOfferItem>();
        }
    
    }

}
