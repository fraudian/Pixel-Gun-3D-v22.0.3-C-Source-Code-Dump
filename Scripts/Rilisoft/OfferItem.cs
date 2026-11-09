using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class OfferItem : ICloneable, IEquatable<Rilisoft.OfferItem>, ISerializationCallbackReceiver, 丗丅三丈丙丝上丞七
    {
        // Fields
        private string _uniqueId;
        private System.Nullable<Rilisoft.丝丑丂丛万丐丈丘且> _priceInGems;
        private 三丅丁丗丗丝丂万且 _record;
        private System.Nullable<ItemRarity> _rarity;
        private System.Nullable<bool> _stackable;
        internal static System.Collections.Generic.List<Rilisoft.OfferItem> _itemsPool;
        private Rilisoft.OfferItemType <Type>k__BackingField;
        private string <Id>k__BackingField;
        private System.Nullable<bool> _isKnownItem;
        private System.Nullable<CategoryNames> _category;
        private Rilisoft.丝丑丂丛万丐丈丘且 _countContainer;
        private 丈丞丕丘丕丗与上一 _price;
        private PGCompany.三东丏不丗世丅丌丄 _itemParams;
        
        // Properties
        public string UniqueId { get; }
        internal Rilisoft.OfferItemType Type { get; set; }
        internal string Id { get; set; }
        internal bool IsStackable { get; }
        internal bool IsEquipment { get; }
        internal bool IsUniqueTypeItem { get; }
        internal bool IsKnownItem { get; }
        internal bool IsExists { get; }
        internal int TotalPartsCount { get; }
        internal int PartsExists { get; }
        internal int PartsLeft { get; }
        internal 三丅丁丗丗丝丂万且 Record { get; }
        internal System.Nullable<CategoryNames> Category { get; }
        internal System.Nullable<ItemRarity> Rarity { get; }
        internal int Count { get; set; }
        internal 丈丞丕丘丕丗与上一 PriceOfThisItem { get; }
        internal int PriceInGems { get; }
        internal UnityEngine.Texture Texture { get; }
        internal UnityEngine.Texture MiddleTexture { get; }
        internal UnityEngine.Texture SimpleTexture { get; }
        internal UnityEngine.Texture Icon { get; }
        internal string Name { get; }
        internal string NameDefault { get; }
        internal string Description { get; }
        internal string ReadableCount { get; }
        internal PGCompany.三东丏不丗世丅丌丄 ItemParams { get; }
        
        // Methods
        internal static Rilisoft.OfferItem 丂丈世不七丆一丛下(string 丞丕丒专一下丙业上)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_9;
            var val_10;
            var val_11;
            val_6 = 0;
            goto label_1;
            label_10:
            val_7 = null;
            val_7 = null;
            Rilisoft.OfferItem val_1 = Rilisoft.OfferItem._itemsPool.Item[0];
            if((System.String.op_Equality(a:  val_1._uniqueId, b:  丞丕丒专一下丙业上)) == true)
            {
                goto label_6;
            }
            
            val_6 = 1;
            label_1:
            val_8 = null;
            val_8 = null;
            val_9 = Rilisoft.OfferItem._itemsPool;
            if(val_6 < val_9.Count)
            {
                goto label_10;
            }
            
            goto label_11;
            label_6:
            val_10 = null;
            val_10 = null;
            val_9 = Rilisoft.OfferItem._itemsPool;
            val_11 = val_9.Item[0];
            if(val_11 != null)
            {
                    return (Rilisoft.OfferItem)val_11;
            }
            
            label_11:
            Rilisoft.OfferItem val_5 = null;
            val_11 = val_5;
            val_5 = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  丞丕丒专一下丙业上);
            return (Rilisoft.OfferItem)val_11;
        }
        internal static Rilisoft.OfferItem 丂丈世不七丆一丛下(int 丞世不丒下上上丝丑, int 丌丒丝东丌下丕丁丅)
        {
            PGCompany.丙万丙下三下丄丌丄 val_2 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            if(val_2 == null)
            {
                    return (Rilisoft.OfferItem)val_2;
            }
            
            return Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  val_2.不业丙丒丂丞下丆丙(), 丞丅上丏丂且下丅与:  val_2.业上丙丞丐丄丆丅七(), 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        }
        internal static Rilisoft.OfferItem 丂丈世不七丆一丛下(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = 0;
            goto label_1;
            label_20:
            val_10 = null;
            val_10 = null;
            Rilisoft.OfferItem val_1 = Rilisoft.OfferItem._itemsPool.Item[0];
            if((val_1.<Type>k__BackingField) != 丁丅丈丌丟世丗丗丟)
            {
                goto label_11;
            }
            
            val_11 = null;
            val_11 = null;
            Rilisoft.OfferItem val_2 = Rilisoft.OfferItem._itemsPool.Item[0];
            if((System.String.op_Equality(a:  val_2.<Id>k__BackingField, b:  丞丅上丏丂且下丅与)) == false)
            {
                goto label_11;
            }
            
            val_12 = null;
            val_12 = null;
            Rilisoft.OfferItem val_4 = Rilisoft.OfferItem._itemsPool.Item[0];
            if(val_4._countContainer == 丌丒丝东丌下丕丁丅)
            {
                goto label_16;
            }
            
            label_11:
            val_9 = 1;
            label_1:
            val_13 = null;
            val_13 = null;
            if(val_9 < Rilisoft.OfferItem._itemsPool.Count)
            {
                goto label_20;
            }
            
            label_25:
            Rilisoft.OfferItem val_6 = new Rilisoft.OfferItem();
            Rilisoft.OfferItem val_7 = val_6.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丂丕丂丏专丂丄丕且:  丌丒丝东丌下丕丁丅);
            return val_6;
            label_16:
            val_14 = null;
            val_14 = null;
            if(Rilisoft.OfferItem._itemsPool.Item[0] != null)
            {
                    return val_6;
            }
            
            goto label_25;
        }
        internal static void 丁丟丞丗丆七丙丐丌(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((Rilisoft.OfferItem._itemsPool.Contains(item:  下丅丙一丂丗丅丝七)) != false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.OfferItem._itemsPool.Add(item:  下丅丙一丂丗丅丝七);
        }
        internal OfferItem()
        {
        
        }
        public OfferItem(string 丞丕丒专一下丙业上)
        {
            Rilisoft.OfferItem val_3 = this.丅专下万丕丑丆丅丝(且万丕与丆下丛万丐:  Rilisoft.业丏丐丏丄丌丒丕世.丑七不且上丗丁一世().专一上不三丒上七丏(丞丕丒专一下丙业上:  丞丕丒专一下丙业上));
        }
        private OfferItem(Rilisoft.不丗上万丟丏不丄下 且万丕与丆下丛万丐)
        {
            Rilisoft.OfferItem val_1 = this.丅专下万丕丑丆丅丝(且万丕与丆下丛万丐:  且万丕与丆下丛万丐);
        }
        internal OfferItem(int 丞世不丒下上上丝丑)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            if(val_2 == null)
            {
                    return;
            }
            
            Rilisoft.OfferItem val_5 = this.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  val_2.不业丙丒丂丞下丆丙(), 丞丅上丏丂且下丅与:  val_2.业上丙丞丐丄丆丅七(), 丂丕丂丏专丂丄丕且:  1);
        }
        internal OfferItem(Rilisoft.OfferItemType 下丗丁丒丘东丂不丑, string 丞一丁业丄一一业且, int 丂丕丂丏专丂丄丕且 = 1)
        {
            val_1 = new System.Object();
            Rilisoft.OfferItem val_2 = this.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  下丗丁丒丘东丂不丑, 丞丅上丏丂且下丅与:  string val_1 = 丞一丁业丄一一业且, 丂丕丂丏专丂丄丕且:  丂丕丂丏专丂丄丕且);
        }
        internal OfferItem(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
        
        }
        public string get_UniqueId()
        {
            return (string)this._uniqueId;
        }
        internal Rilisoft.OfferItemType get_Type()
        {
            return (Rilisoft.OfferItemType)this.<Type>k__BackingField;
        }
        private void set_Type(Rilisoft.OfferItemType 丙业与丙丗丝不丈东)
        {
            this.<Type>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        private void set_Id(string 丙业与丙丗丝不丈东)
        {
            this.<Id>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool get_IsStackable()
        {
            Rilisoft.OfferItemType val_7;
            var val_8;
            if((this._stackable & 1) == 0)
            {
                    if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  this.<Type>k__BackingField, 丞丅上丏丂且下丅与:  this.<Id>k__BackingField)) != false)
            {
                    val_7 = this.<Type>k__BackingField;
                PGCompany.丗丟丄丈东丝丕丄世 val_5 = (PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_7, 丞丅上丏丂且下丅与:  this.<Id>k__BackingField)) & 1;
                mem2[0] = 0;
            }
            else
            {
                    val_7 = 1152921505476067328;
                val_8 = null;
                val_8 = null;
                Rilisoft.OfferItemType val_7 = this.<Type>k__BackingField;
                val_7 = System.Linq.Enumerable.Contains<Rilisoft.OfferItemType>(source:  Rilisoft.下丐丒一丝丈丝三丞.不三业丁一丄业丁丅, value:  val_7);
                this._stackable = 0;
            }
            
            }
            
            System.Nullable<System.Boolean> val_8 = this._stackable;
            val_8 = val_8 & 1;
            return (bool)val_8;
        }
        internal bool get_IsEquipment()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.专丁七丙丌万丝丈丈(下丅丙一丂丗丅丝七:  this);
        }
        internal bool get_IsUniqueTypeItem()
        {
            null = null;
            return System.Linq.Enumerable.Contains<Rilisoft.OfferItemType>(source:  Rilisoft.下丐丒一丝丈丝三丞.丑下丟且丐丌丟丌万, value:  this.<Type>k__BackingField);
        }
        internal bool get_IsKnownItem()
        {
            if((this._isKnownItem & 1) == 0)
            {
                    bool val_2 = Rilisoft.下丐丒一丝丈丝三丞.东上万与丟丙丅丆不(下丅丙一丂丗丅丝七:  this);
                this._isKnownItem = 0;
            }
            
            System.Nullable<System.Boolean> val_3 = this._isKnownItem;
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        internal bool get_IsExists()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  this);
        }
        internal int get_TotalPartsCount()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.丌丙丐万丅丙丟下业(下丅丙一丂丗丅丝七:  this);
        }
        internal int get_PartsExists()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.业一一丗丛且丌丏丏(下丅丙一丂丗丅丝七:  this);
        }
        internal int get_PartsLeft()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.专与万丞不丄丕且七(下丅丙一丂丗丅丝七:  this);
        }
        internal 三丅丁丗丗丝丂万且 get_Record()
        {
            if(this._record != null)
            {
                    return val_1;
            }
            
            三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<Id>k__BackingField);
            this._record = val_1;
            return val_1;
        }
        internal System.Nullable<CategoryNames> get_Category()
        {
            if((this._category & 1) != 0)
            {
                    return (System.Nullable<CategoryNames>)this._category.HasValue;
            }
            
            if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.<Id>k__BackingField)) & 2147483648) == 0)
            {
                
            }
            else
            {
                    if((this.<Type>k__BackingField) != 1170)
            {
                    return (System.Nullable<CategoryNames>)this._category.HasValue;
            }
            
            }
            
            mem2[0] = 0;
            return (System.Nullable<CategoryNames>)this._category.HasValue;
        }
        internal System.Nullable<ItemRarity> get_Rarity()
        {
            string val_8;
            if((this._rarity & 1) != 0)
            {
                    return (System.Nullable<ItemRarity>)this._rarity.HasValue;
            }
            
            if(this.Record != null)
            {
                    val_8 = this.Record;
                mem2[0] = 0;
            }
            
            if((this._rarity & 1) != 0)
            {
                    return (System.Nullable<ItemRarity>)this._rarity.HasValue;
            }
            
            val_8 = this.<Id>k__BackingField;
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_8)) == false)
            {
                    return (System.Nullable<ItemRarity>)this._rarity.HasValue;
            }
            
            val_8 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
            丟丄七万东与上丒丟 val_6 = val_8.Item[this.<Id>k__BackingField];
            if(val_6 == null)
            {
                    return (System.Nullable<ItemRarity>)this._rarity.HasValue;
            }
            
            ItemRarity val_7 = val_6.七东与丄丕丁丛世三();
            mem2[0] = 0;
            return (System.Nullable<ItemRarity>)this._rarity.HasValue;
        }
        internal int get_Count()
        {
        
        }
        internal void set_Count(int 丙业与丙丗丝不丈东)
        {
            this._price = 0;
            if(this._countContainer == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._countContainer = 0;
            mem[1152921543234852072] = 0;
            this._uniqueId = Rilisoft.OfferItem.下丝丟丞七东丝丑东(下丅丙一丂丗丅丝七:  this);
        }
        internal 丈丞丕丘丕丗与上一 get_PriceOfThisItem()
        {
            丈丞丕丘丕丗与上一 val_3;
            string val_4;
            var val_5;
            val_3 = this._price;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            val_4 = this.<Id>k__BackingField;
            val_3 = Rilisoft.下丐丒一丝丈丝三丞.下丐丙七丑万且丕不(丁丅丈丌丟世丗丗丟:  this.<Type>k__BackingField, 丞丅上丏丂且下丅与:  val_4, 丌丒丝东丌下丕丁丅:  this._countContainer);
            this._price = val_3;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            丈丞丕丘丕丗与上一 val_2 = null;
            val_3 = val_2;
            val_2 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  val_4);
            this._price = val_3;
            return val_3;
        }
        internal int get_PriceInGems()
        {
            var val_9;
            var val_10;
            int val_11;
            var val_12;
            if(this._priceInGems.HasValue == true)
            {
                    return -26435488;
            }
            
            丈丞丕丘丕丗与上一 val_2 = this.PriceOfThisItem;
            if(val_2 == null)
            {
                    return -26435488;
            }
            
            if(val_2.丟丂丞不专丆万丒世() < 1)
            {
                goto label_3;
            }
            
            val_10 = null;
            val_10 = null;
            int val_6 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_7 = val_2.丟丂丞不专丆万丒世();
            if((System.String.op_Equality(a:  val_2.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_6;
            }
            
            val_11 = val_7;
            goto label_7;
            label_3:
            val_9 = 0;
            return -26435488;
            label_6:
            val_12 = null;
            val_12 = null;
            float val_8 = BalanceController.丒丏丐丁业且七丄万;
            val_8 = val_8 * (float)val_7;
            val_11 = (int)val_8;
            label_7:
            mem2[0] = 0;
            mem2[0] = 0;
            return -26435488;
        }
        internal decimal 丌丁丆丑丛世丛丄丞()
        {
            return Rilisoft.Offers.丁且丕专万丈丒丏丗.东丙上丛丗丆丈业丕(万丐丏丐丒万不丟三:  this.PriceOfThisItem, 世丈三丐丞一丒丛不:  1);
        }
        internal UnityEngine.Texture get_Texture()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.不上下丙下丞丗且下(下丅丙一丂丗丅丝七:  this, 丄丄丁专丂三三丁且:  false);
        }
        internal UnityEngine.Texture get_MiddleTexture()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.丟丝丕上东丙丗丂与(下丅丙一丂丗丅丝七:  this);
        }
        internal UnityEngine.Texture get_SimpleTexture()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.不上下丙下丞丗且下(下丅丙一丂丗丅丝七:  this, 丄丄丁专丂三三丁且:  true);
        }
        internal UnityEngine.Texture get_Icon()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.上与且丌上一丂丕丕(下丅丙一丂丗丅丝七:  this);
        }
        internal string get_Name()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.与丆业丅上丗七丆一(下丅丙一丂丗丅丝七:  this);
        }
        internal string get_NameDefault()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.丛丐丏上丗不丘丕丕(下丅丙一丂丗丅丝七:  this);
        }
        internal string get_Description()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.丟世三不一下丕丒万(下丅丙一丂丗丅丝七:  this);
        }
        internal string get_ReadableCount()
        {
            return Rilisoft.下丐丒一丝丈丝三丞.三不丄不上丙且丅丄(下丅丙一丂丗丅丝七:  this);
        }
        public object Clone()
        {
            Rilisoft.OfferItem val_1 = new Rilisoft.OfferItem();
            if(val_1 != null)
            {
                    return val_1.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  this.<Type>k__BackingField, 丞丅上丏丂且下丅与:  this.<Id>k__BackingField, 丂丕丂丏专丂丄丕且:  this._countContainer);
            }
            
            return val_1.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  this.<Type>k__BackingField, 丞丅上丏丂且下丅与:  this.<Id>k__BackingField, 丂丕丂丏专丂丄丕且:  this._countContainer);
        }
        private Rilisoft.OfferItem 丅专下万丕丑丆丅丝(Rilisoft.不丗上万丟丏不丄下 且万丕与丆下丛万丐)
        {
            Rilisoft.OfferItemType val_6;
            string val_7;
            if(且万丕与丆下丛万丐 != null)
            {
                    val_6 = 且万丕与丆下丛万丐.丐丞丕丗下丟且丘丌();
                val_7 = 且万丕与丆下丛万丐.丐丙世七丅丅丐下丙();
                return this.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  val_6 = 0.丐丞丕丗下丟且丘丌(), 丞丅上丏丂且下丅与:  val_7 = 0.丐丙世七丅丅丐下丙(), 丂丕丂丏专丂丄丕且:  且万丕与丆下丛万丐.丂丁丏一丙丛业且丌());
            }
            
            return this.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  val_6, 丞丅上丏丂且下丅与:  val_7, 丂丕丂丏专丂丄丕且:  且万丕与丆下丛万丐.丂丁丏一丙丛业且丌());
        }
        internal PGCompany.三东丏不丗世丅丌丄 get_ItemParams()
        {
            int val_7;
            var val_8;
            if(this._itemParams != null)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)this._itemParams;
            }
            
            this._itemParams = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  this.<Type>k__BackingField, 丞丅上丏丂且下丅与:  this.<Id>k__BackingField);
            val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_7.丙丂不东丅丒丄一丐(丈丄不七三万丄丁不:  this._itemParams)) == false)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)this._itemParams;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this._itemParams);
            val_8 = 0;
            val_7 = this._countContainer;
            if(this._itemParams != null)
            {
                    this._itemParams.丅丁业不且上业丘且(丙业与丙丗丝不丈东:  val_7);
                return (PGCompany.三东丏不丗世丅丌丄)this._itemParams;
            }
            
            this._itemParams.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_7);
            return (PGCompany.三东丏不丗世丅丌丄)this._itemParams;
        }
        internal Rilisoft.OfferItem 丅专下万丕丑丆丅丝(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丂丕丂丏专丂丄丕且 = 1)
        {
            string val_4;
            var val_5;
            var val_6;
            val_4 = 丞丅上丏丂且下丅与;
            this.<Type>k__BackingField = 丁丅丈丌丟世丗丗丟;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == false)
            {
                goto label_23;
            }
            
            if(丁丅丈丌丟世丗丗丟 <= 1089)
            {
                goto label_4;
            }
            
            if(丁丅丈丌丟世丗丗丟 > 1109)
            {
                goto label_5;
            }
            
            if(丁丅丈丌丟世丗丗丟 == 1090)
            {
                goto label_6;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 1100)
            {
                goto label_14;
            }
            
            val_4 = "BattlePassExp";
            goto label_23;
            label_4:
            if(丁丅丈丌丟世丗丗丟 == 1000)
            {
                goto label_9;
            }
            
            if(丁丅丈丌丟世丗丗丟 == 1010)
            {
                goto label_10;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 1060)
            {
                goto label_14;
            }
            
            val_4 = "vipInSeconds";
            goto label_23;
            label_5:
            if(丁丅丈丌丟世丗丗丟 == 1110)
            {
                goto label_13;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 1140)
            {
                goto label_14;
            }
            
            val_4 = "CraftCurrency";
            goto label_23;
            label_6:
            val_4 = "BattlePassLevel";
            goto label_23;
            label_9:
            val_5 = null;
            val_5 = null;
            val_4 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            goto label_23;
            label_10:
            val_6 = null;
            val_6 = null;
            val_4 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            goto label_23;
            label_13:
            val_4 = "BattlePassCurrency";
            goto label_23;
            label_14:
            label_23:
            this.<Id>k__BackingField = (丁丅丈丌丟世丗丗丟 == 1220) ? "ClanShields" : (val_4);
            this.Count = 丂丕丂丏专丂丄丕且;
            this._uniqueId = Rilisoft.OfferItem.下丝丟丞七东丝丑东(下丅丙一丂丗丅丝七:  this);
            this._priceInGems = 0;
            this._stackable = 0;
            mem[1152921543236769872] = 0;
            mem[1152921543236769880] = 0;
            this._record = 0;
            this._rarity = 0;
            return (Rilisoft.OfferItem)this;
        }
        private static string 下丝丟丞七东丝丑东(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            var val_2;
            if(下丅丙一丂丗丅丝七 != null)
            {
                    string val_1 = System.String.Format(format:  "{0}:{1}:{2}", arg0:  下丅丙一丂丗丅丝七.<Type>k__BackingField, arg1:  下丅丙一丂丗丅丝七.<Id>k__BackingField, arg2:  下丅丙一丂丗丅丝七._countContainer);
                return (string)val_2;
            }
            
            val_2 = 0;
            return (string)val_2;
        }
        internal void 丁东丐丄丞丌丘业上()
        {
            this._price = 0;
        }
        internal static System.Collections.Generic.List<Rilisoft.OfferItem> 丂丂且丝丆丄丘丙丝(string 丞丕丒专一下丙业上, char 丝七丄丛丂丒丘不丛 = '\x2c')
        {
            System.Char[] val_7;
            string val_8;
            var val_9;
            var val_10;
            val_8 = 丞丕丒专一下丙业上;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
            {
                    UnityEngine.Debug.LogError(message:  "fail to create Offer_Items, nullable descri_ption");
                val_9 = 0;
                return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_9;
            }
            
            char[] val_2 = new char[1];
            val_7 = val_2;
            val_7[0] = 丝七丄丛丂丒丘不丛;
            val_8 = val_8.Split(separator:  val_2);
            System.Collections.Generic.List<Rilisoft.OfferItem> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_10 = 0;
            goto label_10;
            label_18:
            val_7 = 0;
            string val_7 = val_8[val_7];
            if(val_7 != null)
            {
                    val_7 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_7.Trim());
                if(val_7 != null)
            {
                    val_4.Add(item:  val_7);
            }
            
            }
            
            val_10 = 1;
            label_10:
            if(val_10 < val_3.Length)
            {
                goto label_18;
            }
            
            return (System.Collections.Generic.List<Rilisoft.OfferItem>)val_9;
        }
        internal static Rilisoft.OfferItem 东丝丄丈丆三丘与丈(string 丞丕丒专一下丙业上)
        {
            var val_6;
            Rilisoft.不丗上万丟丏不丄下 val_2 = Rilisoft.业丏丐丏丄丌丒丕世.丑七不且上丗丁一世().专一上不三丒上七丏(丞丕丒专一下丙业上:  丞丕丒专一下丙业上);
            val_6 = 0;
            if(val_2.丕丐一丙专丛丒丑万() == false)
            {
                    return (Rilisoft.OfferItem)val_6;
            }
            
            Rilisoft.OfferItem val_4 = null;
            val_6 = val_4;
            val_4 = new Rilisoft.OfferItem();
            Rilisoft.OfferItem val_5 = val_4.丅专下万丕丑丆丅丝(且万丕与丆下丛万丐:  val_2);
            return (Rilisoft.OfferItem)val_6;
        }
        public override string ToString()
        {
            return (string)this._uniqueId;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            return false;
        }
        public bool Equals(Rilisoft.OfferItem 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 != null)
            {
                    return System.String.op_Equality(a:  this._uniqueId, b:  丘丛丏丘丝七世七丅._uniqueId);
            }
            
            return System.String.op_Equality(a:  this._uniqueId, b:  丘丛丏丘丝七世七丅._uniqueId);
        }
        public override int GetHashCode()
        {
            var val_2 = System.Collections.Generic.EqualityComparer<System.String>.Default;
            val_2 = val_2 + 2303782716;
            return (int)val_2;
        }
        public void OnBeforeSerialize()
        {
        
        }
        public void OnAfterDeserialize()
        {
            Rilisoft.OfferItemType val_1 = 0;
            string val_2 = 0;
            if((Rilisoft.不丗上万丟丏不丄下.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  this._uniqueId, 丁丅丈丌丟世丗丗丟: out  val_1, 丞丅上丏丂且下丅与: out  val_2, 丌丒丝东丌下丕丁丅: out  val_1)) != false)
            {
                    Rilisoft.OfferItem val_4 = this.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  0, 丞丅上丏丂且下丅与:  val_2, 丂丕丂丏专丂丄丕且:  0);
                return;
            }
            
            this._uniqueId = 0;
        }
        internal PGCompany.三东丏不丗世丅丌丄 与丒上与丄丒丝三七()
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  this.<Type>k__BackingField, 丞丅上丏丂且下丅与:  this.<Id>k__BackingField);
            val_1.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this._countContainer);
            return val_1;
        }
        internal T 世丙丕下丘丌且丕丝<T>()
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = this.与丒上与丄丒丝三七();
            goto __RuntimeMethodHiddenParam + 48;
        }
        private static OfferItem()
        {
            Rilisoft.OfferItem._itemsPool = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        }
    
    }

}
