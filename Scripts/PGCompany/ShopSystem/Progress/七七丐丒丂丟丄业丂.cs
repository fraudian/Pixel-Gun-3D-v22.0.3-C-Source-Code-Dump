using UnityEngine;

namespace PGCompany.ShopSystem.Progress
{
    internal class 七七丐丒丂丟丄业丂 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private PGCompany.ShopSystem.Progress.丁且丞丏一丑万专且 丈丄丂下丒专丌丛丄;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)PGCompany.ShopSystem.Progress.七七丐丒丂丟丄业丂.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)PGCompany.ShopSystem.Progress.七七丐丒丂丟丄业丂.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 76;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            var val_3;
            string val_1 = Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
            val_3 = null;
            val_3 = null;
            string val_2 = ">>> hash "(">>> hash ") + val_1;
            if(LogsSystem.丆丏丌丆丆丑丞不丈.丕万丂丕丞丙东丅丄 != null)
            {
                    return val_1;
            }
            
            return val_1;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            string val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.丈丄丂下丒专丌丛丄 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            object val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(this.丈丄丂下丒专丌丛丄 == null)
            {
                    return (object)val_1;
            }
            
            if(this.丈丄丂下丒专丌丛丄.PurchasedPositions == null)
            {
                    return (object)val_1;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "b", value:  val_2);
            this = this.丈丄丂下丒专丌丛丄.PurchasedPositions;
            Dictionary.Enumerator<TKey, TValue> val_3 = this.GetEnumerator();
            label_8:
            if(((-92440128) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_6 = val_4.丐丏七丌丕丗业且上();
            val_4 = val_6;
            val_2.Add(key:  val_6.丙东专丂世丈丏丁丂().ToString(), value:  val_4);
            goto label_8;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_1;
        }
        internal int 东丆专丛不丏业丏丗(int 万丏丗丗丅丄丌业一)
        {
            if(this.丈丄丂下丒专丌丛丄.PurchasedPositions == null)
            {
                    return 0;
            }
            
            if((this.丈丄丂下丒专丌丛丄.PurchasedPositions.ContainsKey(key:  万丏丗丗丅丄丌业一)) == false)
            {
                    return 0;
            }
            
            if(this.丈丄丂下丒专丌丛丄.PurchasedPositions != null)
            {
                    return this.丈丄丂下丒专丌丛丄.PurchasedPositions.Item[万丏丗丗丅丄丌业一];
            }
            
            return this.丈丄丂下丒专丌丛丄.PurchasedPositions.Item[万丏丗丗丅丄丌业一];
        }
        internal bool 与与丈丈丁丂丞丐丏(int 万丏丗丗丅丄丌业一)
        {
            if(this.丈丄丂下丒专丌丛丄.PurchasedPositions == null)
            {
                    return false;
            }
            
            if(this.丈丄丂下丒专丌丛丄.PurchasedPositions != null)
            {
                    return this.丈丄丂下丒专丌丛丄.PurchasedPositions.ContainsKey(key:  万丏丗丗丅丄丌业一);
            }
            
            return this.丈丄丂下丒专丌丛丄.PurchasedPositions.ContainsKey(key:  万丏丗丗丅丄丌业一);
        }
        internal void 丒东丑丘丝万业且三(System.Collections.Generic.Dictionary<int, int> 丌与丘丕丙与丑丛上)
        {
            var val_3;
            if(丌与丘丕丙与丑丛上 == null)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = 丌与丘丕丙与丑丛上.GetEnumerator();
            label_11:
            if(((-91952576) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((this.丈丄丂下丒专丌丛丄.PurchasedPositions.ContainsKey(key:  val_4.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_5;
            }
            
            this.丈丄丂下丒专丌丛丄.PurchasedPositions.set_Item(key:  val_4.丙东专丂世丈丏丁丂(), value:  -91952584);
            goto label_11;
            label_5:
            this.丈丄丂下丒专丌丛丄.PurchasedPositions.Add(key:  val_4.丙东专丂世丈丏丁丂(), value:  -91952584);
            goto label_11;
            label_1:
            this = this.丈丄丂下丒专丌丛丄;
            this.丈丄丂下丒专丌丛丄.PurchasedPositions = 0;
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丈丄丂下丒专丌丛丄 = new PGCompany.ShopSystem.Progress.丁且丞丏一丑万专且();
        }
        public 七七丐丒丂丟丄业丂()
        {
        
        }
        private static 七七丐丒丂丟丄业丂()
        {
            PGCompany.ShopSystem.Progress.七七丐丒丂丟丄业丂.丕丟一七丑丙丂丆丙 = "shop_slot";
            PGCompany.ShopSystem.Progress.七七丐丒丂丟丄业丂.丐丌丞上世丛丐丏丛 = "shop_slot";
        }
    
    }

}
