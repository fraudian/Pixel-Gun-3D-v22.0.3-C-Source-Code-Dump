using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class LobbyItemsBundle
    {
        // Fields
        internal const string BANDLE_ID_MY = "bundle_my";
        internal const string BUNDLE_ID_WINTER = "bundle_winter";
        internal const string BUNDLE_INAPP_ACTION_KEY = "lobby-item";
        private System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> _items;
        private 丈丞丕丘丕丗与上一 <CoinsReward>k__BackingField;
        private 丈丞丕丘丕丗与上一 <GemsReward>k__BackingField;
        private 三丅丁丗丗丝丂万且 <WeaponReward>k__BackingField;
        private decimal <ContentRealPrice>k__BackingField;
        private decimal <ContentGemsPrice>k__BackingField;
        private decimal <Profit>k__BackingField;
        private string _id;
        private string _localizationKey;
        private string _locDescriptionKey;
        private int _sortOrder;
        private string _bindedEventName;
        
        // Properties
        public string Id { get; }
        public string LocalizationLey { get; }
        public string LocDescriptionLey { get; }
        public int SortOrder { get; }
        public string BindedEventName { get; }
        internal 丈丞丕丘丕丗与上一 BuyPrice { get; }
        public Rilisoft.与丗丌丑专业丝丛丏 MarketProduct { get; }
        public bool Available { get; }
        public System.Collections.Generic.List<string> ItemsIds { get; }
        private int GemsRewardBase { get; }
        private int CoinsRewardBase { get; }
        private System.Collections.Generic.List<string> WeaponPrefabNames { get; }
        internal System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> Items { get; }
        internal System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> NotExistsItems { get; }
        internal System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> ExistsItems { get; }
        internal bool IsMyBandle { get; }
        internal 丈丞丕丘丕丗与上一 CoinsReward { get; set; }
        internal 丈丞丕丘丕丗与上一 GemsReward { get; set; }
        internal 三丅丁丗丗丝丂万且 WeaponReward { get; set; }
        internal decimal ContentRealPrice { get; set; }
        internal decimal ContentGemsPrice { get; set; }
        internal decimal Profit { get; set; }
        
        // Methods
        public string get_Id()
        {
            return (string)this._id;
        }
        public string get_LocalizationLey()
        {
            return (string)this._localizationKey;
        }
        public string get_LocDescriptionLey()
        {
            return (string)this._locDescriptionKey;
        }
        public int get_SortOrder()
        {
            return (int)this._sortOrder;
        }
        public string get_BindedEventName()
        {
            return (string)this._bindedEventName;
        }
        internal 丈丞丕丘丕丗与上一 get_BuyPrice()
        {
            var val_4;
            var val_5;
            丈丞丕丘丕丗与上一 val_6;
            val_4 = null;
            val_4 = null;
            if((BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  this._id)) != false)
            {
                    val_5 = null;
                val_5 = null;
                Rilisoft.LobbyBundleRewardData val_2 = BalanceController.丞且且丂丐丌丛丕与.Item[this._id];
                val_6 = val_2.Real;
                return (丈丞丕丘丕丗与上一)val_6;
            }
            
            丈丞丕丘丕丗与上一 val_3 = null;
            val_6 = val_3;
            val_3 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  "Real");
            return (丈丞丕丘丕丗与上一)val_6;
        }
        public Rilisoft.与丗丌丑专业丝丛丏 get_MarketProduct()
        {
            var val_8;
            int val_9;
            var val_10;
            System.Int32[] val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = 0;
            val_9 = System.String.alignConst;
            goto label_1;
            label_11:
            val_10 = null;
            val_10 = null;
            val_11 = this.BuyPrice;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == val_11.丟丂丞不专丆万丒世())
            {
                goto label_7;
            }
            
            val_8 = 1;
            label_1:
            val_12 = null;
            val_12 = null;
            val_11 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_8 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_11;
            }
            
            goto label_12;
            label_7:
            val_13 = null;
            val_13 = null;
            val_9 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_9 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_12:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != true)
            {
                    val_14 = null;
                val_14 = null;
                val_15 = StoreKitEventListener.丆丕丝丒不丙且丐丗.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_9);
                if(val_15 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                if(val_15.丄世不丗丁与不下下() != null)
            {
                    if(coinsShop.七三丗丏丑丗三丆世() == true)
            {
                    return (Rilisoft.与丗丌丑专业丝丛丏)val_15;
            }
            
            }
            
            }
            
            }
            
            Rilisoft.与丅丕且丙丁业丁丌 val_8 = null;
            val_15 = val_8;
            val_8 = new Rilisoft.与丅丕且丙丁业丁丌();
            return (Rilisoft.与丗丌丑专业丝丛丏)val_15;
        }
        public bool get_Available()
        {
            null = null;
            if(BalanceController.丞且且丂丐丌丛丕与 != null)
            {
                    return BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  this._id);
            }
            
            return BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  this._id);
        }
        public System.Collections.Generic.List<string> get_ItemsIds()
        {
            var val_4;
            var val_5;
            System.Collections.Generic.List<System.String> val_6;
            val_4 = null;
            val_4 = null;
            if((BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  this._id)) != false)
            {
                    val_5 = null;
                val_5 = null;
                Rilisoft.LobbyBundleRewardData val_2 = BalanceController.丞且且丂丐丌丛丕与.Item[this._id];
                val_6 = val_2.ItemsIds;
                return (System.Collections.Generic.List<System.String>)val_6;
            }
            
            System.Collections.Generic.List<System.String> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            return (System.Collections.Generic.List<System.String>)val_6;
        }
        private int get_GemsRewardBase()
        {
            var val_9;
            var val_10;
            string val_11;
            var val_12;
            val_9 = this;
            val_10 = null;
            val_10 = null;
            val_11 = this._id;
            if((BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  val_11)) == false)
            {
                    return 0;
            }
            
            val_12 = null;
            val_12 = null;
            Rilisoft.LobbyBundleRewardData val_2 = BalanceController.丞且且丂丐丌丛丕与.Item[this._id];
            val_9 = ???;
            val_11 = ???;
            return 0;
        }
        private int get_CoinsRewardBase()
        {
            var val_9;
            var val_10;
            string val_11;
            var val_12;
            val_9 = this;
            val_10 = null;
            val_10 = null;
            val_11 = this._id;
            if((BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  val_11)) == false)
            {
                    return 0;
            }
            
            val_12 = null;
            val_12 = null;
            Rilisoft.LobbyBundleRewardData val_2 = BalanceController.丞且且丂丐丌丛丕与.Item[this._id];
            val_9 = ???;
            val_11 = ???;
            return 0;
        }
        private System.Collections.Generic.List<string> get_WeaponPrefabNames()
        {
            var val_4;
            var val_5;
            System.Collections.Generic.List<System.String> val_6;
            val_4 = null;
            val_4 = null;
            if((BalanceController.丞且且丂丐丌丛丕与.ContainsKey(key:  this._id)) != false)
            {
                    val_5 = null;
                val_5 = null;
                Rilisoft.LobbyBundleRewardData val_2 = BalanceController.丞且且丂丐丌丛丕与.Item[this._id];
                val_6 = val_2.WeaponPrefabNames;
                return (System.Collections.Generic.List<System.String>)val_6;
            }
            
            System.Collections.Generic.List<System.String> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            return (System.Collections.Generic.List<System.String>)val_6;
        }
        internal System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> get_Items()
        {
            bool val_1 = this.IsMyBandle;
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if(val_2 != null)
            {
                    if(val_1 == false)
            {
                    return System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_2.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.LobbyItemsBundle::一万万丂丅一下丌三(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
            }
            
                return val_2.丑七丆丄一三不下丁();
            }
            
            if(val_1 == true)
            {
                    return val_2.丑七丆丄一三不下丁();
            }
            
            return System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_2.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.LobbyItemsBundle::一万万丂丅一下丌三(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
        }
        internal System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> get_NotExistsItems()
        {
            if(this.IsMyBandle != false)
            {
                    return 0;
            }
            
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            return System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_2.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.LobbyItemsBundle::丈丄专丆丂丛业世丅(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
        }
        internal System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> get_ExistsItems()
        {
            if(this.IsMyBandle != false)
            {
                    return 0;
            }
            
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            return System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_2.丛不丞丂七丞世丁丏, predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.LobbyItemsBundle::一东丄丘专丑与丝下(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
        }
        internal bool get_IsMyBandle()
        {
            return System.String.op_Equality(a:  this._id, b:  "bundle_my");
        }
        internal 丈丞丕丘丕丗与上一 get_CoinsReward()
        {
            return (丈丞丕丘丕丗与上一)this.<CoinsReward>k__BackingField;
        }
        private void set_CoinsReward(丈丞丕丘丕丗与上一 丙业与丙丗丝不丈东)
        {
            this.<CoinsReward>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丈丞丕丘丕丗与上一 get_GemsReward()
        {
            return (丈丞丕丘丕丗与上一)this.<GemsReward>k__BackingField;
        }
        private void set_GemsReward(丈丞丕丘丕丗与上一 丙业与丙丗丝不丈东)
        {
            this.<GemsReward>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 三丅丁丗丗丝丂万且 get_WeaponReward()
        {
            return (三丅丁丗丗丝丂万且)this.<WeaponReward>k__BackingField;
        }
        private void set_WeaponReward(三丅丁丗丗丝丂万且 丙业与丙丗丝不丈东)
        {
            this.<WeaponReward>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal decimal get_ContentRealPrice()
        {
            return new System.Decimal() {flags = this.<ContentRealPrice>k__BackingField, hi = this.<ContentRealPrice>k__BackingField};
        }
        private void set_ContentRealPrice(decimal 丙业与丙丗丝不丈东)
        {
            this.<ContentRealPrice>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921543078782552] = 丙业与丙丗丝不丈东.lo;
            mem[1152921543078782556] = 丙业与丙丗丝不丈东.mid;
        }
        internal decimal get_ContentGemsPrice()
        {
            return new System.Decimal() {flags = this.<ContentGemsPrice>k__BackingField, hi = this.<ContentGemsPrice>k__BackingField};
        }
        private void set_ContentGemsPrice(decimal 丙业与丙丗丝不丈东)
        {
            this.<ContentGemsPrice>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921543079006568] = 丙业与丙丗丝不丈东.lo;
            mem[1152921543079006572] = 丙业与丙丗丝不丈东.mid;
        }
        internal decimal get_Profit()
        {
            return new System.Decimal() {flags = this.<Profit>k__BackingField, hi = this.<Profit>k__BackingField};
        }
        internal void set_Profit(decimal 丙业与丙丗丝不丈东)
        {
            this.<Profit>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921543079230584] = 丙业与丙丗丝不丈东.lo;
            mem[1152921543079230588] = 丙业与丙丗丝不丈东.mid;
        }
        internal void 七丄丟不且丐丙万专()
        {
            var val_35;
            var val_63;
            丈丞丕丘丕丗与上一 val_64;
            丈丞丕丘丕丗与上一 val_65;
            int val_66;
            int val_68;
            var val_69;
            var val_71;
            var val_72;
            var val_73;
            int val_75;
            var val_76;
            var val_78;
            var val_79;
            int val_80;
            var val_81;
            三丅丁丗丗丝丂万且 val_82;
            var val_83;
            三丅丁丗丗丝丂万且 val_85;
            var val_88;
            var val_90;
            var val_91;
            if(this.IsMyBandle != false)
            {
                    val_63 = null;
                val_63 = null;
                val_64 = 1152921505317228544;
                this.<CoinsReward>k__BackingField = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
                丈丞丕丘丕丗与上一 val_3 = null;
                val_65 = val_3;
                val_3 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
                this.<GemsReward>k__BackingField = val_65;
                this.<WeaponReward>k__BackingField = 0;
                return;
            }
            
            val_66 = this.GemsRewardBase;
            this.<WeaponReward>k__BackingField = 0;
            var val_69 = 0;
            val_69 = val_69 + 1;
            System.Collections.Generic.IEnumerator<T> val_8 = this.ExistsItems.GetEnumerator();
            val_68 = 1152921504686346240;
            val_69 = 1152921505284374528;
            goto label_35;
            label_44:
            var val_70 = 0;
            val_70 = val_70 + 1;
            T val_10 = val_8.Current;
            if(val_10.丙丕丞且丕不丘丙丑() != null)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10.丙丕丞且丕不丘丙丑().三丏丐丗业丝丞丝丄())) != false)
            {
                    val_71 = val_10.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌();
            }
            else
            {
                    val_71 = val_10.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            }
            
                float val_71 = (float)val_71.丟丂丞不专丆万丒世();
                val_71 = val_71 * 0.1f;
                int val_20 = UnityEngine.Mathf.FloorToInt(f:  val_71);
                val_72 = null;
                val_72 = null;
                val_68 = val_68;
                if((System.String.op_Equality(a:  val_71.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    int val_72 = this.CoinsRewardBase;
                val_72 = val_20 + val_72;
            }
            else
            {
                    val_73 = null;
                val_73 = null;
                val_66 = (((System.String.op_Equality(a:  val_71.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? (val_20) : 0) + val_66;
            }
            
            }
            
            label_35:
            var val_73 = 0;
            val_73 = val_73 + 1;
            if(val_8.MoveNext() == true)
            {
                goto label_44;
            }
            
            val_75 = 0;
            val_76 = 0;
            if(val_8 == null)
            {
                
            }
            else
            {
                    var val_74 = 0;
                val_74 = val_74 + 1;
                val_8.Dispose();
            }
            
            if(( != 1) && (241 == 241))
            {
                    val_75 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_76 = 0;
            }
            
            }
            
            if((this.WeaponPrefabNames == null) || (this.WeaponPrefabNames.Count < 1))
            {
                goto label_76;
            }
            
            List.Enumerator<T> val_33 = this.WeaponPrefabNames.GetEnumerator();
            val_69 = 1152921505369411584;
            label_85:
            if(((-182084944) & 1) == 0)
            {
                goto label_78;
            }
            
            三丅丁丗丗丝丂万且 val_37 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_35.丐丏七丌丕丗业且上());
            if(val_37 == null)
            {
                goto label_85;
            }
            
            val_68 = val_37.业东丅东丌上丗丑不();
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_68)) != null)
            {
                goto label_85;
            }
            
            this.<WeaponReward>k__BackingField = val_37;
            label_78:
            val_78 = 0 + 1;
            mem2[0] = 356;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_78 != 1) && ((1152921543079467632 + ((0 + 1)) << 2) == 356))
            {
                    var val_75 = 0;
                val_75 = val_75 ^ (val_78 >> 31);
                val_78 = val_78 + val_75;
            }
            else
            {
                    if(null != null)
            {
                    val_76 = 0;
            }
            
            }
            
            if((this.<WeaponReward>k__BackingField) == null)
            {
                goto label_95;
            }
            
            label_76:
            label_177:
            val_79 = null;
            val_79 = null;
            丈丞丕丘丕丗与上一 val_41 = null;
            val_64 = val_41;
            val_41 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_72, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
            this.<CoinsReward>k__BackingField = val_64;
            val_65 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            this.<GemsReward>k__BackingField = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  val_65);
            this.万上丅丞且丏丟上世();
            return;
            label_95:
            label_101:
            val_35 = 0;
            System.Collections.Generic.IEnumerable<三丅丁丗丗丝丂万且> val_44 = WeaponManager.三丏丏丄专丅世丞不(丈下丑丆上丏丗丈专:  new System.Nullable<ItemRarity>() {HasValue = false}, 丈专且丄丈丞丙丘三:  0, 且上下丌一下且丑丟:  0, 丒万丂七不丏丙万丝:  false, 丄七丛丛丛下三业丛:  false);
            if((System.Linq.Enumerable.Any<三丅丁丗丗丝丂万且>(source:  val_44)) == true)
            {
                goto label_100;
            }
            
            if((5 - 1) > 3)
            {
                goto label_101;
            }
            
            val_80 = val_72;
            val_81 = 1152921505171275776;
            val_82 = 1152921519126358176;
            val_83 = 1152921519126359200;
            if((this.<WeaponReward>k__BackingField) != null)
            {
                goto label_177;
            }
            
            goto label_139;
            label_100:
            val_82 = 1152921519126358176;
            var val_76 = 0;
            val_76 = val_76 + 1;
            System.Collections.Generic.IEnumerator<T> val_48 = val_44.GetEnumerator();
            label_123:
            val_85 = System.Linq.Enumerable.First<三丅丁丗丗丝丂万且>(source:  val_44);
            label_122:
            val_83 = 1152921519126359200;
            var val_77 = 0;
            val_77 = val_77 + 1;
            if(val_48.MoveNext() == false)
            {
                goto label_114;
            }
            
            var val_78 = 0;
            val_78 = val_78 + 1;
            if(val_48.Current.丙下业七一一下世万() <= val_85.丙下业七一一下世万())
            {
                goto label_122;
            }
            
            goto label_123;
            label_114:
            val_88 = val_78 + 1;
            mem2[0] = 468;
            val_80 = val_72;
            val_81 = 1152921505171275776;
            if(val_48 == null)
            {
                
            }
            else
            {
                    var val_79 = 0;
                val_79 = val_79 + 1;
                val_48.Dispose();
            }
            
            if((val_88 != 1) && ((1152921543079467632 + (((0 + 1) + 1)) << 2) == 468))
            {
                    var val_80 = 0;
                val_80 = val_80 ^ (val_88 >> 31);
                val_88 = val_88 + val_80;
            }
            else
            {
                    if( != false)
            {
                    val_76 = 0;
            }
            
            }
            
            this.<WeaponReward>k__BackingField = ;
            if((public System.Boolean List.Enumerator<System.String>::MoveNext()) == 0)
            {
                goto label_139;
            }
            
            goto label_177;
            label_139:
            List.Enumerator<T> val_57 = this.WeaponPrefabNames.GetEnumerator();
            label_145:
            if(((-182084944) & 1) == 0)
            {
                goto label_157;
            }
            
            三丅丁丗丗丝丂万且 val_59 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_35.丐丏七丌丕丗业且上());
            if(val_59 == null)
            {
                goto label_145;
            }
            
            float val_81 = (float)val_59.且丅万下业下三丛与().丟丂丞不专丆万丒世();
            val_81 = val_81 * 0.1f;
            int val_62 = UnityEngine.Mathf.FloorToInt(f:  val_81);
            val_90 = null;
            if((System.String.op_Equality(a:  val_59.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    val_80 = val_62 + val_80;
            }
            else
            {
                    val_91 = null;
                val_91 = null;
                if((System.String.op_Equality(a:  val_59.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    int val_82 = val_75;
                val_82 = val_62 + val_82;
            }
            
            }
            
            label_157:
            val_78 = val_78 + 1;
            mem2[0] = 646;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_78 == 1)
            {
                goto label_172;
            }
            
            if(( == false) || ((1152921543079467632 + (((0 + 1) + 1)) << 2) != 646))
            {
                goto label_177;
            }
            
            goto label_177;
            label_172:
            if( == false)
            {
                goto label_177;
            }
            
            goto label_177;
        }
        private void 万上丅丞且丏丟上世()
        {
            int val_39;
            int val_40;
            var val_43;
            var val_44;
            var val_46;
            var val_47;
            var val_49;
            var val_50;
            var val_51;
            val_39 = this.<GemsReward>k__BackingField.丟丂丞不专丆万丒世();
            val_40 = this.<CoinsReward>k__BackingField.丟丂丞不专丆万丒世();
            var val_42 = 0;
            val_42 = val_42 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = this.Items.GetEnumerator();
            goto label_27;
            label_34:
            var val_43 = 0;
            val_43 = val_43 + 1;
            T val_7 = val_5.Current;
            if(val_7.丙丕丞且丕不丘丙丑() == null)
            {
                goto label_27;
            }
            
            丈丞丕丘丕丗与上一 val_10 = val_7.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            val_43 = null;
            val_43 = null;
            if((System.String.op_Equality(a:  val_10.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == true)
            {
                goto label_21;
            }
            
            val_44 = null;
            val_44 = null;
            if((System.String.op_Equality(a:  val_10.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_27;
            }
            
            val_40 = val_10.丟丂丞不专丆万丒世() + val_40;
            goto label_27;
            label_21:
            val_39 = val_10.丟丂丞不专丆万丒世() + val_39;
            label_27:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_5.MoveNext() == true)
            {
                goto label_34;
            }
            
            val_46 = 0;
            val_47 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_45 = 0;
                val_45 = val_45 + 1;
                val_5.Dispose();
            }
            
            if((this.<WeaponReward>k__BackingField) == null)
            {
                goto label_68;
            }
            
            val_49 = null;
            val_49 = null;
            bool val_22 = System.String.op_Equality(a:  this.<WeaponReward>k__BackingField.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
            丈丞丕丘丕丗与上一 val_23 = this.<WeaponReward>k__BackingField.且丅万下业下三丛与();
            if(val_23 == null)
            {
                goto label_62;
            }
            
            if(val_22 == false)
            {
                goto label_63;
            }
            
            label_65:
            val_39 = val_23.丟丂丞不专丆万丒世() + val_39;
            goto label_68;
            label_62:
            if(val_22 == true)
            {
                goto label_65;
            }
            
            label_63:
            val_50 = null;
            val_50 = null;
            if((System.String.op_Equality(a:  val_23.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    val_40 = (this.<WeaponReward>k__BackingField.且丅万下业下三丛与().丟丂丞不专丆万丒世()) + val_40;
            }
            
            label_68:
            bool val_31 = Rilisoft.Offers.丁且丕专万丈丒丏丗.丙世丕丆丗丅丝东且(世丈三丐丞一丒丛不:  this.BuyPrice.丟丂丞不专丆万丒世(), 丒丝丌上专万丐上丙: out  new System.Decimal(), 东丕下东丛丘丂丏丈: out  new System.Decimal());
            decimal val_32 = System.Decimal.op_Implicit(value:  val_39);
            decimal val_33 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_32.flags, hi = val_32.hi, lo = val_32.lo, mid = val_32.mid}, d2:  new System.Decimal());
            decimal val_34 = System.Decimal.op_Implicit(value:  val_40);
            decimal val_35 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_34.flags, hi = val_34.hi, lo = val_34.lo, mid = val_34.mid}, d2:  new System.Decimal());
            val_51 = null;
            val_51 = null;
            float val_46 = BalanceController.丒丏丐丁业且七丄万;
            val_46 = val_46 * (float)val_40;
            val_46 = val_46 + (float)val_39;
            decimal val_36 = System.Decimal.op_Explicit(value:  val_46);
            this.<ContentGemsPrice>k__BackingField = val_36;
            mem[1152921543079813288] = val_36.lo;
            mem[1152921543079813292] = val_36.mid;
            decimal val_37 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_33.flags, hi = val_33.hi, lo = val_33.lo, mid = val_33.mid}, d2:  new System.Decimal() {flags = val_35.flags, hi = val_35.hi, lo = val_35.lo, mid = val_35.mid});
            this.<ContentRealPrice>k__BackingField = val_37;
            mem[1152921543079813272] = val_37.lo;
            mem[1152921543079813276] = val_37.mid;
            decimal val_40 = System.Decimal.op_Implicit(value:  this.BuyPrice.丟丂丞不专丆万丒世());
            decimal val_41 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_37.flags, hi = val_37.hi, lo = val_37.lo, mid = val_37.mid}, d2:  new System.Decimal() {flags = val_40.flags, hi = val_40.hi, lo = val_40.lo, mid = val_40.mid});
            this.<Profit>k__BackingField = val_41;
            mem[1152921543079813304] = val_41.lo;
            mem[1152921543079813308] = val_41.mid;
        }
        internal string 丌丕七与与万业丂丁()
        {
            var val_15;
            StoreKitEventListener val_16;
            int val_17;
            var val_18;
            System.Int32[] val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_15 = this;
            val_16 = 0;
            val_17 = System.String.alignConst;
            goto label_1;
            label_10:
            val_18 = null;
            val_18 = null;
            val_19 = 0;
            if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == 1)
            {
                goto label_6;
            }
            
            val_16 = 1;
            label_1:
            val_20 = null;
            val_20 = null;
            val_19 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
            if(val_16 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
            {
                goto label_10;
            }
            
            goto label_11;
            label_6:
            val_21 = null;
            val_21 = null;
            val_17 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_17 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_11:
            val_22 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_17)) == true)
            {
                    return (string)BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, 七丏丂丈世万丈上丕:  "F0");
            }
            
            val_23 = null;
            val_23 = null;
            val_16 = StoreKitEventListener.丆丕丝丒不丙且丐丗;
            val_24 = val_16.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_17);
            if(val_24 == null)
            {
                    Rilisoft.与丅丕且丙丁业丁丌 val_3 = null;
                val_24 = val_3;
                val_3 = new Rilisoft.与丅丕且丙丁业丁丌();
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    decimal val_5 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = this.<Profit>k__BackingField, hi = this.<Profit>k__BackingField, lo = -181524944, mid = 268435464}, d2:  new System.Decimal());
                decimal val_6 = val_5.flags.专丛丆下上丝专上丄(丒世丘丘上丆丝东丞:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
                return (string)BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, 七丏丂丈世万丈上丕:  "F0");
            }
            
            decimal val_10 = System.Decimal.op_Implicit(value:  this.BuyPrice.丟丂丞不专丆万丒世());
            decimal val_11 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = this.<ContentRealPrice>k__BackingField, hi = this.<ContentRealPrice>k__BackingField, lo = 1152921505317388288}, d2:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid});
            var val_16 = 0;
            val_16 = val_16 + 1;
            decimal val_13 = val_3.丈业且丆七三丛丙丙();
            decimal val_14 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid}, d2:  new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid});
            decimal val_15 = val_14.flags.专丛丆下上丝专上丄(丒世丘丘上丆丝东丞:  new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid});
            return BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid}, 七丏丂丈世万丈上丕:  "F0");
        }
        private decimal 专丛丆下上丝专上丄(decimal 丒世丘丘上丆丝东丞)
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) != false)
            {
                    decimal val_2 = System.Math.Round(d:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid});
            }
            
            val_24 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_11;
            }
            
            val_24 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_11;
            }
            
            val_25 = 5;
            goto label_95;
            label_11:
            val_26 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_20;
            }
            
            val_26 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_20;
            }
            
            val_25 = 10;
            goto label_95;
            label_20:
            val_27 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_29;
            }
            
            val_27 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_29;
            }
            
            val_25 = 100;
            goto label_95;
            label_29:
            val_28 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_38;
            }
            
            val_28 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_38;
            }
            
            val_25 = 500;
            goto label_95;
            label_38:
            val_29 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_47;
            }
            
            val_29 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_47;
            }
            
            val_25 = 1000;
            goto label_95;
            label_47:
            val_30 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_56;
            }
            
            val_30 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_56;
            }
            
            val_25 = 5000;
            goto label_95;
            label_56:
            val_31 = 0;
            val_25 = 65536;
            val_25 = 1;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_65;
            }
            
            val_31 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_65;
            }
            
            val_25 = 10000;
            goto label_95;
            label_65:
            val_32 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_74;
            }
            
            val_32 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_74;
            }
            
            val_25 = 50000;
            goto label_95;
            label_74:
            val_33 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_83;
            }
            
            val_33 = 0;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_83;
            }
            
            goto label_95;
            label_83:
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_92;
            }
            
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, d2:  new System.Decimal())) == false)
            {
                goto label_92;
            }
            
            val_25 = 458752;
            val_25 = 7;
            goto label_95;
            label_92:
            val_25 = 983040;
            val_25 = 15;
            label_95:
            decimal val_23 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = 丒世丘丘上丆丝东丞.flags, hi = 丒世丘丘上丆丝东丞.hi, lo = 丒世丘丘上丆丝东丞.lo, mid = 丒世丘丘上丆丝东丞.mid}, 专丂丕丗丗东世丞下:  1000000);
            return new System.Decimal() {flags = val_23.flags, hi = val_23.hi, lo = val_23.lo, mid = val_23.mid};
        }
        public void 东丞丐业丂丞不丕丈()
        {
            coinsShop val_21;
            var val_22;
            int val_23;
            string val_24;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_25;
            var val_26;
            var val_27;
            var val_28;
            丘丝丑丐丆丑七不丙 val_29;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_21 = this;
            val_22 = null;
            val_23 = System.String.alignConst;
            val_22 = null;
            if(coinsShop.专丆专上丗万世丒七 == 0)
            {
                    return;
            }
            
            val_24 = 1152921505272713216;
            val_25 = 0;
            goto label_6;
            label_16:
            val_26 = null;
            val_26 = null;
            if(val_25 >= StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                    val_27 = 0;
            }
            
            if((StoreKitEventListener.丝不东丅丅丂三且丑.Length + 32) == this.BuyPrice.丟丂丞不专丆万丒世())
            {
                goto label_12;
            }
            
            val_25 = 1;
            label_6:
            val_28 = null;
            val_28 = null;
            if(val_25 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
            {
                goto label_16;
            }
            
            val_29 = 0;
            goto label_17;
            label_12:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_27 = 0;
            val_31 = null;
            val_29 = AbstractBankView.丒丁丞丝世三与七东().Item[0];
            val_31 = null;
            val_23 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
            val_23 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
            label_17:
            if(val_29 == 0)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_23)) == true)
            {
                    return;
            }
            
            this.七丄丟不且丐丙万专();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = null;
            val_25 = val_8;
            val_8 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_25 != null)
            {
                    val_8.Add(key:  "ID", value:  val_23);
            }
            else
            {
                    val_8.Add(key:  "ID", value:  val_23);
            }
            
            val_8.Add(key:  "Key", value:  "lobby-item");
            val_8.Add(key:  "action", value:  "lobby-item");
            val_32 = 1152921504691564544;
            System.Collections.Generic.List<System.String> val_9 = new System.Collections.Generic.List<System.String>();
            val_24 = this._id;
            val_33 = 1152921516107659296;
            val_9.Add(item:  val_24);
            val_8.Add(key:  "LobbyItems", value:  val_9);
            if((this.<CoinsReward>k__BackingField) != null)
            {
                    if((this.<CoinsReward>k__BackingField.丟丂丞不专丆万丒世()) >= 1)
            {
                    int val_12 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
                int val_13 = this.<CoinsReward>k__BackingField.丟丂丞不专丆万丒世();
                val_24 = 0;
                val_8.Add(key:  this.<CoinsReward>k__BackingField.东与三丌丅三丒丏业(), value:  0);
                val_33 = 1152921516107659296;
            }
            
            }
            
            if((this.<GemsReward>k__BackingField) != null)
            {
                    if((this.<GemsReward>k__BackingField.丟丂丞不专丆万丒世()) >= 1)
            {
                    int val_16 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
                int val_17 = this.<GemsReward>k__BackingField.丟丂丞不专丆万丒世();
                val_24 = 0;
                val_8.Add(key:  this.<GemsReward>k__BackingField.东与三丌丅三丒丏业(), value:  0);
                val_33 = val_33;
                val_32 = 1152921504691564544;
            }
            
            }
            
            if((this.<WeaponReward>k__BackingField) != null)
            {
                    System.Collections.Generic.List<System.String> val_18 = new System.Collections.Generic.List<System.String>();
                val_18.Add(item:  this.<WeaponReward>k__BackingField.与不丞丑七丘丁丂丛());
                val_8.Add(key:  "Weapons", value:  val_18);
            }
            
            Rilisoft.LobbyItemsController.七七丌丌丁不下万三(丙业与丙丗丝不丈东:  FriendsController.丝丗专上三不丄丑丑());
            val_34 = null;
            val_34 = null;
            val_21 = coinsShop.专丆专上丗万世丒七;
            val_21.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  val_29, 丈上上丟丟丏万丐且:  val_8);
        }
        public LobbyItemsBundle()
        {
            this._sortOrder = 9999;
        }
        private bool 一万万丂丅一下丌三(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
        {
            System.Collections.Generic.List<System.String> val_1 = this.ItemsIds;
            if(val_1 != null)
            {
                    return val_1.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
            }
            
            return val_1.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
        }
        private bool 丈丄专丆丂丛业世丅(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
        {
            if(七丞丙丒三丕且丌丟.且丅一一三七专丑丏() != false)
            {
                    return false;
            }
            
            System.Collections.Generic.List<System.String> val_2 = this.ItemsIds;
            if(val_2 != null)
            {
                    return val_2.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
            }
            
            return val_2.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
        }
        private bool 一东丄丘专丑与丝下(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
        {
            if(七丞丙丒三丕且丌丟.且丅一一三七专丑丏() == false)
            {
                    return false;
            }
            
            System.Collections.Generic.List<System.String> val_2 = this.ItemsIds;
            if(val_2 != null)
            {
                    return val_2.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
            }
            
            return val_2.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
        }
    
    }

}
