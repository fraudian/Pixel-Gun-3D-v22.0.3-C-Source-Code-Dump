using UnityEngine;

namespace PGCompany
{
    internal class InventoryItemView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.丗丟丄丈东丝丕丄世>
    {
        // Fields
        private static System.Action<PGCompany.InventoryItemView> 世丙丄一丂世不万丁;
        private System.Action<PGCompany.InventoryItemView> 丄世丗丝丁丂丈丅一;
        public UIWidget Widget;
        private UnityEngine.GameObject commonContainer;
        private BaseArmoryCell _armoryCell;
        private UIBasicSprite _texture;
        private UIBasicSprite _icon;
        private System.Collections.Generic.List<UILabel> _nameLabels;
        private System.Collections.Generic.List<UILabel> _descriptionLabels;
        private UnityEngine.GameObject _countContainer;
        private System.Collections.Generic.List<UILabel> _itemCountLabels;
        private UILabel _itemTypeAndRarityLabel;
        private UnityEngine.GameObject _countSingleContainer;
        private System.Collections.Generic.List<UILabel> _itemCountSingleLabels;
        private UILabel _itemSecondsLabel;
        private PGCompany.TimerUI _itemTimeUI;
        private System.Collections.Generic.List<UnityEngine.GameObject> _purchasedGO;
        private System.Collections.Generic.List<UnityEngine.GameObject> _notPurchasedGO;
        private PGCompany.InventoryItemInfoView _itemInfoView;
        private WidgetLayout _upStarsContainer;
        private UISprite _upStar;
        private System.Collections.Generic.List<UIWidget> rarityColor;
        private System.Collections.Generic.List<RarityColorEntry> newRarityColorEntries;
        private UnityEngine.GameObject _unCommonRarityContainer;
        private UnityEngine.GameObject _commonRarityContainer;
        private UnityEngine.GameObject _rareRarityContainer;
        private UnityEngine.GameObject _epicRarityContainer;
        private UnityEngine.GameObject _legendaryRarityContainer;
        private UnityEngine.GameObject _mythicRarityContainer;
        private UnityEngine.GameObject moduleContainer;
        private UILabel countLabel;
        private UnityEngine.GameObject canUpgrade;
        private UILabel levelLabel;
        private UISprite typeSprite;
        private UISprite propertySprite;
        private UISprite categorySprite;
        private UIBasicSprite categorySpriteBG;
        private UnityEngine.GameObject newLabel;
        private UnityEngine.GameObject moduleChestContainer;
        private UILabel timerLabel;
        private UILabel maxTimeLabel;
        private UILabel modulesCountLabel;
        private UnityEngine.GameObject dafaultState;
        private UnityEngine.GameObject openingState;
        private UnityEngine.GameObject opendState;
        private UnityEngine.GameObject noTimeState;
        private UnityEngine.GameObject _weaponContainer;
        private UILabel _weaponLevel;
        private UIWidget _weaponLevelBG;
        private UnityEngine.GameObject _gadgetContainer;
        private UnityEngine.GameObject _divisionContainer;
        private UISprite _divisionSprite;
        private bool _useMiniIcon;
        private UnityEngine.GameObject enableIfParts;
        private UnityEngine.GameObject bisableIfParts;
        private WidgetLayout widgetLayout;
        private ItemCountView itemCountView;
        private ItemCraftBarView itemCraftBarView;
        private ItemMeshView itemMeshView;
        private PGCompany.ItemCoolnessView itemCoolnessView;
        internal RewardParticlesSource rewardParticlesSource;
        private System.Collections.Generic.List<ItemViewComponent> 丞丒丄一丞七丒且丛;
        internal SimpleTweenePlayer simpleTweenePlayer;
        private UIBasicSprite _petBackgorund;
        private UIBasicSprite _petIcon;
        private UnityEngine.GameObject _weaponForSkinContainer;
        private UILabel _weaponForSkinNameLabel;
        private UILabel _oneLabelPrice;
        private string _oneLabelPriceText;
        private PGCompany.丗丟丄丈东丝丕丄世 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private PGCompany.三东丏不丗世丅丌丄 <一世下专丕丛上丅丈>k__BackingField;
        private int <一丙万七专丅丁丙丛>k__BackingField;
        private System.Collections.Generic.List<UISprite> 且丏且丅东下业丑丅;
        
        // Properties
        internal bool 万世世丆丂不丗万丐 { get; }
        internal WidgetLayout 万丆丑丐丛丒万东丝 { get; }
        public System.Collections.Generic.List<UILabel> 业丕丁丌丄与丟丑不 { get; }
        internal UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        internal UIBasicSprite 丛丙丂丝不丏上东不 { get; }
        public PGCompany.丗丟丄丈东丝丕丄世 丄丄一丐东丐丝丗七 { get; set; }
        public PGCompany.三东丏不丗世丅丌丄 三东丏不丗世丅丌丄 { get; set; }
        internal int 下下丈一丆东东丄丒 { get; set; }
        
        // Methods
        internal static void 与且丑一丈丘且丙丄(System.Action<PGCompany.InventoryItemView> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.InventoryItemView.世丙丄一丂世不万丁, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 七丏丙世丝丒丈七丄(System.Action<PGCompany.InventoryItemView> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.InventoryItemView.世丙丄一丂世不万丁, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal void 丁七丛东丐丈上丟丌(System.Action<PGCompany.InventoryItemView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄世丗丝丁丂丈丅一, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄世丗丝丁丂丈丅一 != 1152921555534535272);
        
        }
        internal void 不业丗丌下丐丝丞丘(System.Action<PGCompany.InventoryItemView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄世丗丝丁丂丈丅一, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄世丗丝丁丂丈丅一 != 1152921555534671848);
        
        }
        internal bool 丘七丕丁丗与丙东丅()
        {
            return (bool)this._useMiniIcon;
        }
        internal WidgetLayout 丗与丅且丁丞不丝且()
        {
            return (WidgetLayout)this.widgetLayout;
        }
        public System.Collections.Generic.List<UILabel> get_NameLabels()
        {
            return (System.Collections.Generic.List<UILabel>)this._nameLabels;
        }
        internal UIBasicSprite 丆下世世丟七专丞丒()
        {
            return (UIBasicSprite)this._texture;
        }
        internal UIBasicSprite 丑一丆丑且丟上业丛()
        {
            return (UIBasicSprite)this._icon;
        }
        public PGCompany.丗丟丄丈东丝丕丄世 get_Context()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.丗丟丄丈东丝丕丄世 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public PGCompany.三东丏不丗世丅丌丄 get_ItemParams()
        {
            return (PGCompany.三东丏不丗世丅丌丄)this.<一世下专丕丛上丅丈>k__BackingField;
        }
        private void 且三一丙丟东专丒丑(PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东)
        {
            this.<一世下专丕丛上丅丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丙丕丄万业与下七丁()
        {
            return (int)this.<一丙万七专丅丁丙丛>k__BackingField;
        }
        private void 上丒丒丁丆丌下丝丂(int 丙业与丙丗丝不丈东)
        {
            this.<一丙万七专丅丁丙丛>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static UnityEngine.Texture 丏丘丑丗专丒丝丘丆(ItemRarity 东东世丝业丝一丂丄)
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/craft_{0}_cell_empty", arg0:  东东世丝业丝一丂丄.ToString().ToLowerInvariant()));
        }
        private void OnEnable()
        {
            System.Action val_1 = 45427;
            val_1 = new System.Action(object:  this, method:  System.Void PGCompany.InventoryItemView::东上不丗三丘丁丌上());
            coinsShop.丌丘丙丂且丅丞丂世(丙业与丙丗丝不丈东:  val_1);
        }
        private void OnDisable()
        {
            coinsShop.丅丞丏丐丛不丈东万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.InventoryItemView::东上不丗三丘丁丌上()));
        }
        private void OnDestroy()
        {
            coinsShop.丅丞丏丐丛不丈东万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.InventoryItemView::东上不丗三丘丁丌上()));
        }
        public void Setup(PGCompany.丗丅三丈丙丝上丞七 与且专丈不万东一万)
        {
            if(与且专丈不万东一万 == null)
            {
                    return;
            }
        
        }
        public void Setup(PGCompany.丗丟丄丈东丝丕丄世 与且专丈不万东一万)
        {
            PGCompany.丟丝世万东万丆丟上 val_16;
            一一万丒与专丙丁丛 val_17;
            var val_18;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gadgetContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleChestContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._upStarsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._divisionContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemTimeUI, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponForSkinContainer, 丏业丟一东丂东丘丛:  false);
            if(this._itemInfoView != null)
            {
                    this._itemInfoView.Setup(与且专丈不万东一万:  与且专丈不万东一万);
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonContainer, 丏业丟一东丂东丘丛:  true);
            if(与且专丈不万东一万 != null)
            {
                    this.<一世下专丕丛上丅丈>k__BackingField = 与且专丈不万东一万.丑丐丙丄丅世世丑丒();
                this.丟丏七七丅三世丏七();
            }
            else
            {
                    this.<一世下专丕丛上丅丈>k__BackingField = 0.丑丐丙丄丅世世丑丒();
                this.丟丏七七丅三世丏七();
            }
            
            Rilisoft.OfferItemType val_3 = 与且专丈不万东一万.不业丙丒丂丞下丆丙();
            if(val_3 <= 1150)
            {
                goto label_9;
            }
            
            if(val_3 <= 1170)
            {
                goto label_10;
            }
            
            if(val_3 == 1240)
            {
                goto label_11;
            }
            
            if(val_3 != 1250)
            {
                goto label_36;
            }
            
            if((与且专丈不万东一万 == null) || (null != null))
            {
                goto label_27;
            }
            
            PlaceableItemSettings val_4 = 与且专丈不万东一万.丈丏专三世七丒丘丑();
            goto label_15;
            label_9:
            if(val_3 <= 70)
            {
                goto label_16;
            }
            
            if(val_3 == 80)
            {
                goto label_17;
            }
            
            if(val_3 != 1150)
            {
                goto label_36;
            }
            
            this.专丈与丄三丞丌丂丅();
            goto label_36;
            label_10:
            if(val_3 == 1160)
            {
                goto label_20;
            }
            
            if(val_3 != 1170)
            {
                goto label_36;
            }
            
            if(与且专丈不万东一万 == null)
            {
                goto label_22;
            }
            
            var val_5 = (null == null) ? 与且专丈不万东一万 : 0;
            goto label_23;
            label_16:
            if(val_3 == 10)
            {
                goto label_24;
            }
            
            if(val_3 != 70)
            {
                goto label_36;
            }
            
            this.业一三丟丟丂丝丂丟();
            goto label_36;
            label_11:
            if(与且专丈不万东一万 != null)
            {
                    if(null == null)
            {
                goto label_28;
            }
            
            }
            
            label_27:
            val_17 = 0;
            goto label_29;
            label_17:
            val_18 = 0;
            goto label_32;
            label_20:
            this.丝丈丛丞丈丞且下丞();
            goto label_36;
            label_24:
            this.丞丆不丆丕万丁丙丈();
            goto label_36;
            label_22:
            val_16 = 0;
            label_23:
            this.丙丕丌丌东万丅丒丂(丅专丕三且丑丘专下:  val_16);
            goto label_36;
            label_32:
            this.东与且不上不东且上(上东丞世三世且丈丌:  null);
            goto label_36;
            label_28:
            label_15:
            val_17 = 与且专丈不万东一万.丈丏专三世七丒丘丑().ClanDivision;
            label_29:
            this.丒丄丏丏下且万与丟(丅丅下丟丑专下与一:  val_17);
            label_36:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
            this.丞丁丐丆丟一丘丌不(丈丄不七三万丄丁不:  与且专丈不万东一万.丑丐丙丄丅世世丑丒());
            if(this.itemCountView != null)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_10 = 与且专丈不万东一万.丑丐丙丄丅世世丑丒();
            }
            
            if(this.itemCraftBarView != null)
            {
                    this.itemCraftBarView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  与且专丈不万东一万.丑丐丙丄丅世世丑丒(), 丅万下三丅上丙专与:  0);
            }
            
            if(this.itemMeshView != null)
            {
                    this.itemMeshView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  与且专丈不万东一万.丑丐丙丄丅世世丑丒());
            }
            
            if(this.itemCoolnessView != null)
            {
                    this.itemCoolnessView.丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  与且专丈不万东一万);
            }
            
            this.下三丕专丟丌丂丗丒(丈丄不七三万丄丁不:  与且专丈不万东一万.丑丐丙丄丅世世丑丒());
            if(this.widgetLayout != null)
            {
                    this.widgetLayout.Reposition();
            }
            
            this.万且专与下业专业丘(丈丄不七三万丄丁不:  与且专丈不万东一万.丑丐丙丄丅世世丑丒());
        }
        public void Setup(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁)
        {
            Rilisoft.OfferItem val_24;
            string val_25;
            string val_26;
            string val_27;
            val_24 = 丏且丕丄丁丟丆丏丁;
            InventoryItemView.不下丛专万丟丕东万 val_1 = new InventoryItemView.不下丛专万丟丕东万();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丏且丕丄丁丟丆丏丁 = val_24;
            if(val_24 == null)
            {
                    return;
            }
            
            label_13:
            val_25 = .丏且丕丄丁丟丆丏丁.Id;
            val_26 = val_25;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  .丏且丕丄丁丟丆丏丁.Type, 丞丅上丏丂且下丅与:  val_26)) == false)
            {
                goto label_8;
            }
            
            this.Setup(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams);
            if(val_1 != null)
            {
                goto label_45;
            }
            
            goto label_12;
            label_1:
            mem[16] = val_24;
            val_24 = mem[16];
            if(val_24 != 0)
            {
                goto label_13;
            }
            
            return;
            label_8:
            .丒丘丏上丙丟丑丕丈 = System.String.alignConst;
            Rilisoft.OfferItemType val_8 = .丏且丕丄丁丟丆丏丁.Type;
            if(val_8 == 1000)
            {
                goto label_17;
            }
            
            if(val_8 != 1010)
            {
                goto label_18;
            }
            
            val_27 = "Key_0275";
            goto label_21;
            label_17:
            val_27 = "Key_0951";
            label_21:
            string val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_27);
            goto label_24;
            label_18:
            label_24:
            .丒丘丏上丙丟丑丕丈 = .丏且丕丄丁丟丆丏丁.Name;
            if(this._texture != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  .丏且丕丄丁丟丆丏丁.Texture);
            }
            
            if(this._icon != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._icon, 与万丆丛丒万丝丙丑:  .丏且丕丄丁丟丆丏丁.Icon);
            }
            
            System.Action<UILabel> val_15 = null;
            val_25 = val_15;
            val_15 = new System.Action<UILabel>(object:  new InventoryItemView.丒丙丘丌专一专丅丕(), method:  System.Void InventoryItemView.丒丙丘丌专一专丅丕::丆一且世上丗上一丗(UILabel 三丟东丕丄丄下下丑));
            this._nameLabels.ForEach(action:  val_15);
            this._descriptionLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void InventoryItemView.不下丛专万丟丕东万::一丄业丐丄丒下丏丞(UILabel 三丟东丕丄丄下下丑)));
            val_26 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  true);
            if(val_1 != null)
            {
                goto label_45;
            }
            
            label_12:
            label_45:
            this.丞丁丐丆丟一丘丌不(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams);
            if(this.itemCountView != null)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_18 = .丏且丕丄丁丟丆丏丁.ItemParams;
            }
            
            if(this.itemCraftBarView != null)
            {
                    this.itemCraftBarView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams, 丅万下三丅上丙专与:  0);
            }
            
            if(this.itemMeshView != null)
            {
                    this.itemMeshView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams);
            }
            
            if(this.itemCoolnessView != null)
            {
                    this.itemCoolnessView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams);
            }
            
            this.下三丕专丟丌丂丗丒(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams);
            if(this.widgetLayout != null)
            {
                    this.widgetLayout.Reposition();
            }
            
            this.万且专与下业专业丘(丈丄不七三万丄丁不:  .丏且丕丄丁丟丆丏丁.ItemParams);
        }
        public void Setup(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_5;
            if(丈丄不七三万丄丁不 == null)
            {
                    return;
            }
            
            this.<一世下专丕丛上丅丈>k__BackingField = 丈丄不七三万丄丁不;
            val_5 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_5 == null)
            {
                    return;
            }
            
            this.Setup(与且专丈不万东一万:  val_5);
            this.丙丕丑丟丛丅业丝丙(丌丒丝东丌下丕丁丅:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 丆专且丕专丗与一丏:  val_5.业东丅东丌上丗丑不());
            this.丒丞一丅七丙丕一一(丆丐七丅丆丗丛上与:  丈丄不七三万丄丁不.丙丑丁专一专世万丕());
            this.丞丁丐丆丟一丘丌不(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(this.itemCraftBarView != null)
            {
                    this.itemCraftBarView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  丈丄不七三万丄丁不, 丅万下三丅上丙专与:  0);
            }
            
            if(this.itemMeshView != null)
            {
                    this.itemMeshView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            }
            
            if(this.itemCoolnessView != null)
            {
                    this.itemCoolnessView.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            }
            
            this.下三丕专丟丌丂丗丒(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(this.widgetLayout != null)
            {
                    this.widgetLayout.Reposition();
            }
            
            this.万且专与下业专业丘(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
        }
        private void 东上不丗三丘丁丌上()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            this.丙丕丑丟丛丅业丝丙(丌丒丝东丌下丕丁丅:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丆专且丕专丗与一丏:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业东丅东丌上丗丑不());
        }
        private void 丙丕丑丟丛丅业丝丙(int 丌丒丝东丌下丕丁丅, int 丆专且丕专丗与一丏)
        {
            object val_16;
            System.Collections.Generic.List<UILabel> val_17;
            IntPtr val_19;
            this.<一丙万七专丅丁丙丛>k__BackingField = 丌丒丝东丌下丕丁丅;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countSingleContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            if(丆专且丕专丗与一丏 != 11015)
            {
                goto label_3;
            }
            
            InventoryItemView.丆不丝丝与丑丟丆与 val_1 = null;
            val_16 = val_1;
            val_1 = new InventoryItemView.丆不丝丝与丑丟丆与();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countSingleContainer, 丏业丟一东丂东丘丛:  true);
            .丕丗丘丑丛与丑业丒 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0276");
            val_17 = this._itemCountSingleLabels;
            val_19 = 1152921555537773088;
            goto label_35;
            label_3:
            if((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丞世不丒下上上丝丑:  丆专且丕专丗与一丏)) == false)
            {
                goto label_12;
            }
            
            InventoryItemView.丟丗东丛丘丂丌七丑 val_4 = null;
            val_16 = val_4;
            val_4 = new InventoryItemView.丟丗东丛丘丂丌七丑();
            if(coinsShop.七三丗丏丑丗三丆世() == false)
            {
                goto label_15;
            }
            
            decimal val_6 = System.Decimal.op_Implicit(value:  丌丒丝东丌下丕丁丅);
            string val_7 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且业业丈丅丝丟丄专(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, 丞丂业丅丟丙丏七丗:  丆专且丕专丗与一丏, 丆丗丘丕且丈丘丁不:  "F2");
            goto label_20;
            label_12:
            .丑不丝上丆下丅丌丞 = 丌丒丝东丌下丕丁丅.ToString();
            this._itemCountLabels.ForEach(action:  new System.Action<UILabel>(object:  new InventoryItemView.三丑丗丟上丏丂丄丗(), method:  System.Void InventoryItemView.三丑丗丟上丏丂丄丗::丗丌丌丘世丗专丂三(UILabel 三丟东丕丄丄下下丑)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  (丌丒丝东丌下丕丁丅 > 1) ? 1 : 0);
            return;
            label_15:
            label_20:
            .丑不丝上丆下丅丌丞 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            if(((this._countSingleContainer != 0) && (this._itemCountSingleLabels != null)) && ((System.Linq.Enumerable.Any<UILabel>(source:  this._itemCountSingleLabels)) != false))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countSingleContainer, 丏业丟一东丂东丘丛:  true);
                val_17 = this._itemCountSingleLabels;
                val_19 = 1152921555537829408;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  true);
                val_17 = this._itemCountLabels;
                System.Action<UILabel> val_15 = null;
                val_19 = 1152921555537842720;
            }
            
            label_35:
            val_15 = new System.Action<UILabel>(object:  val_4, method:  val_19);
            val_17.ForEach(action:  val_15);
        }
        private void 丒丞一丅七丙丕一一(int 丆丐七丅丆丗丛上与)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemSecondsLabel, 丏业丟一东丂东丘丛:  (丆丐七丅丆丗丛上与 > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemSecondsLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丆丐七丅丆丗丛上与, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        private void 丟丏七七丅三世丏七()
        {
            object val_19;
            UnityEngine.Object val_20;
            System.Collections.Generic.List<UnityEngine.GameObject> val_21;
            val_19 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(this._armoryCell != 0)
            {
                    if(this._texture == 0)
            {
                    this._texture = this._armoryCell.Icon;
            }
            
                this._armoryCell.丄丈下丈上万世专丙();
            }
            
            if(this._texture != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            }
            
            if(this._icon != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._icon, 与万丆丛丒万丝丙丑:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            }
            
            this._nameLabels.ForEach(action:  new System.Action<UILabel>(object:  this, method:  System.Void PGCompany.InventoryItemView::丒七世丘丘丛丕三七(UILabel 三丟东丕丄丄下下丑)));
            this._descriptionLabels.ForEach(action:  new System.Action<UILabel>(object:  this, method:  System.Void PGCompany.InventoryItemView::丘业东丌丁下丏丆丁(UILabel 三丟东丕丄丄下下丑)));
            val_20 = 0;
            if(this._itemTypeAndRarityLabel != val_20)
            {
                    val_20 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                this._itemTypeAndRarityLabel.text = val_20;
            }
            
            this.丙丕丑丟丛丅业丝丙(丌丒丝东丌下丕丁丅:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丆专且丕专丗与一丏:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业东丅东丌上丗丑不());
            PGCompany.三东丏不丗世丅丌丄 val_18 = this.<一世下专丕丛上丅丈>k__BackingField;
            bool val_11 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_18, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            val_21 = this._purchasedGO;
            val_18 = val_11;
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  val_18);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._notPurchasedGO, 丏业丟一东丂东丘丛:  (~val_11) & 1);
            this.丗丈丌丛业丘丆不丑();
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            var val_13 = (((PGCompany.丗丟丄丈东丝丕丄世.__il2cppRuntimeField_typeHierarchy + (PGCompany.丌丐下丌丘下丝丞业.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? this.<丅丝丌丝丁丏丙东丞>k__BackingField : 0;
            val_21 = this._itemTimeUI;
            if(val_21 == 0)
            {
                    return;
            }
            
            val_21 = this._itemTimeUI;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_21, 丏业丟一东丂东丘丛:  (val_13.丙世丑丅丒丑业与不() > 0) ? 1 : 0);
            val_19 = this._itemTimeUI;
            val_19.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_13.丙世丑丅丒丑业与不(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        private void 丗丈丌丛业丘丆不丑()
        {
            var val_3;
            UnityEngine.GameObject val_12;
            var val_13;
            val_12 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.rarityColor, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B});
            List.Enumerator<T> val_1 = this.newRarityColorEntries.GetEnumerator();
            label_8:
            if(((-607830784) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4 == null)
            {
                goto label_8;
            }
            
            val_4.丌万丌丙丌丆丐丁丐(丈下丑丆上丏丗丈专:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            goto label_8;
            label_5:
            val_13 = public System.Void List.Enumerator<RarityColorEntry>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unCommonRarityContainer, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == 1) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._commonRarityContainer, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rareRarityContainer, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == 2) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._epicRarityContainer, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == 3) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._legendaryRarityContainer, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == 4) ? 1 : 0);
            val_12 = this._mythicRarityContainer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == 5) ? 1 : 0);
        }
        private void 专丈与丄三丞丌丂丅()
        {
            int val_2;
            UnityEngine.GameObject val_27;
            PGCompany.丗丟丄丈东丝丕丄世 val_28;
            System.Predicate<T> val_29;
            var val_30;
            var val_31;
            var val_32;
            UnityEngine.GameObject val_33;
            string val_34;
            UILabel val_35;
            val_27 = this;
            InventoryItemView.丅丝丒且丄万丛丅丐 val_1 = new InventoryItemView.丅丝丒且丄万丛丅丐();
            val_28 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_28 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_28 == null)
            {
                goto label_5;
            }
            
            label_2:
            if(null != null)
            {
                    val_28 = 0;
            }
            
            label_5:
            .丕上业丕丘上丘七一 = val_28;
            if(val_1 == null)
            {
                    val_28 = (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一;
            }
            
            if(val_28 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  val_28.丑业世丞上丂丄丟丞()));
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.categorySprite, 万丑丞一丝丌丐丒丘:  (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.丕业丆丑丝丗丞且上());
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Color val_8 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.万丕丅下上丄丗万丞().ToString());
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.categorySpriteBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            val_29 = 1152921505261211648;
            val_30 = null;
            val_30 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
            {
                    val_31 = null;
                val_31 = null;
                System.Predicate<PGCompany.丗丟丄丈东丝丕丄世> val_10 = null;
                val_29 = val_10;
                val_10 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  val_1, method:  System.Boolean InventoryItemView.丅丝丒且丄万丛丅丐::丝丆丝不丘丟丌丁东(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑));
                val_32 = Exists(match:  val_10);
            }
            else
            {
                    val_32 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newLabel, 丏业丟一东丂东丘丛:  false);
            if(this.typeSprite != 0)
            {
                    丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.typeSprite, 万丑丞一丝丌丐丒丘:  PGCompany.七丆丆丕丂丙丕丐丂.丙丟丁丒七下丝七一(丕上业丕丘上丘七一:  (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一, 不丗丐丘业专丂丝上:  this.typeSprite.atlas));
            }
            
            if(this.propertySprite != 0)
            {
                    丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.propertySprite, 万丑丞一丝丌丐丒丘:  PGCompany.七丆丆丕丂丙丕丐丂.世丗丘丙丘丛丛一丟(丕上业丕丘上丘七一:  (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一, 不丗丐丘业专丂丝上:  this.propertySprite.atlas));
            }
            
            val_33 = this.canUpgrade;
            if((InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.丙丅丗丏丆丆世世丙() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_33, 丏业丟一东丂东丘丛:  ((InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.且丆丟业丞丕丑上且() >= (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.丏丈丁专专丘丒丂丂()) ? 1 : 0);
                val_33 = this.countLabel;
                val_29 = 1152921504622075904;
                val_2 = (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.且丆丟业丞丕丑上且();
                val_34 = System.String.Format(format:  "{0}/{1}", arg0:  val_2, arg1:  (InventoryItemView.丅丝丒且丄万丛丅丐)[1152921555539007200].丕上业丕丘上丘七一.丏丈丁专专丘丒丂丂());
                val_35 = val_33;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_33, 丏业丟一东丂东丘丛:  false);
                val_34 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3701");
                val_35 = this.countLabel;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_35, 丕丗丘丑丛与丑业丒:  val_34);
            val_27 = this.moduleContainer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  true);
        }
        private void 丝丈丛丞丈丞且下丞()
        {
            UnityEngine.GameObject val_13;
            string val_14;
            UnityEngine.GameObject val_15;
            var val_16;
            var val_17;
            UnityEngine.GameObject val_18;
            var val_19;
            val_13 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.maxTimeLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丑丞一丘万丘丗业丘(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            ModuleChestData val_4 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁且七专七丗上与丑();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.modulesCountLabel, 丕丗丘丑丛与丑业丒:  val_4.modulesCount.ToString());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dafaultState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openingState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.opendState, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noTimeState, 丏业丟一东丂东丘丛:  false);
            val_14 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁且七专七丗上与丑();
            if(val_6.Type != 6)
            {
                    if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
            {
                goto label_13;
            }
            
            }
            
            val_14 = 1152921505231339520;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅丙丛丑丌丆丌丕丒()) != 丐东不丅丂丂丅丙不.丑业丝丛丅丐丙丙上())
            {
                goto label_16;
            }
            
            if(丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘() < 1)
            {
                goto label_19;
            }
            
            val_14 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.timerLabel, 丕丗丘丑丛与丑业丒:  val_14);
            val_15 = this.openingState;
            val_16 = 1;
            goto label_26;
            label_16:
            val_17 = null;
            val_18 = this.dafaultState;
            goto label_32;
            label_13:
            val_19 = null;
            val_13 = this.noTimeState;
            goto label_34;
            label_19:
            val_17 = null;
            val_18 = this.opendState;
            label_32:
            val_16 = 1;
            val_15 = val_18;
            label_26:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  true);
            val_19 = null;
            val_13 = this.moduleChestContainer;
            label_34:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        }
        private void 丞丆不丆丕万丁丙丈()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.三三三东丑丁且与万()));
            UnityEngine.Color val_5 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._weaponLevelBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  true);
        }
        private void 业一三丟丟丂丝丂丟()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  this.<一世下专丕丛上丅丈>k__BackingField)) != false)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.三三三东丑丁且与万()));
                UnityEngine.Color val_7 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._weaponLevelBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  true);
                return;
            }
            
            this.丒丂不丆丐丗业专丕(丘世专丆丐且丏丏丛:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁丕丁三丁丗不三丟(), 业上丞丐万三丒丘上:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.万丙东丙丐丕专丈丕());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gadgetContainer, 丏业丟一东丂东丘丛:  true);
        }
        private void 丒丂不丆丐丗业专丕(int 丘世专丆丐且丏丏丛, int 业上丞丐万三丒丘上)
        {
            var val_9;
            System.Action<UISprite> val_11;
            if(this._upStarsContainer == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._upStarsContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._upStar, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<UISprite>(专下丐丒丈万丗丟丝:  this.且丏且丅东下业丑丅, 专丑业丁丗丏丌不丛:  this._upStar.gameObject, 丈东丘丏与丌东东下:  this._upStarsContainer.transform, 与业丄丂丂丆下上丞:  业上丞丐万三丒丘上, 丏东下下一丗专下丏:  0);
            val_9 = null;
            val_9 = null;
            val_11 = InventoryItemView.<>c.<>9__113_0;
            if(val_11 == null)
            {
                goto label_10;
            }
            
            label_27:
            this.且丏且丅东下业丑丅.ForEach(action:  val_11);
            this._upStarsContainer.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
            if(业上丞丐万三丒丘上 >= 1)
            {
                    val_11 = 45436;
                var val_9 = 0;
                do
            {
                this.且丏且丅东下业丑丅.Item[0].spriteName = (val_9 < 丘世专丆丐且丏丏丛) ? "Lev_comp_gold_star" : "Lev_comp_gray_star";
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.且丏且丅东下业丑丅.Item[0], 丏业丟一东丂东丘丛:  true);
                this._upStarsContainer.AddElement(世丌丌丙丞丟下东丞:  this.且丏且丅东下业丑丅.Item[0]);
                val_9 = val_9 + 1;
            }
            while(业上丞丐万三丒丘上 != val_9);
            
            }
            
            this._upStarsContainer.Reposition();
            return;
            label_10:
            InventoryItemView.<>c.<>9__113_0 = new System.Action<UISprite>(object:  InventoryItemView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void InventoryItemView.<>c::丒丂丟丘丛丞丒丌丞(UISprite 三丟东丕丄丄下下丑));
            if(this.且丏且丅东下业丑丅 != null)
            {
                goto label_27;
            }
            
            goto label_27;
        }
        private void 东与且不上不东且上(PGCompany.世丒丗丅丛丕不万丂 上东丞世三世且丈丌)
        {
            if(this._petBackgorund != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._petBackgorund, 与万丆丛丒万丝丙丑:  PGCompany.InventoryItemView.丏丘丑丗专丒丝丘丆(东东世丝业丝一丂丄:  上东丞世三世且丈丌));
            }
            
            if(this._petIcon == 0)
            {
                    return;
            }
            
            UnityEngine.Color val_4 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  上东丞世三世且丈丌);
            this._petIcon.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        }
        private void 丙丕丌丌东万丅丒丂(PGCompany.丟丝世万东万丆丟上 丅专丕三且丑丘专下)
        {
            UnityEngine.Object val_7;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponForSkinContainer, 丏业丟一东丂东丘丛:  false);
            if(丅专丕三且丑丘专下 != null)
            {
                    val_7 = 丅专丕三且丑丘专下.上专丗丏丛丁专丑丄();
            }
            else
            {
                    val_7 = 0;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丟丝东丈丐丙三下丛 val_6 = val_7.一丌世丑丄东丞丘三<PGCompany.丟丝东丈丐丙三下丛>(丞世不丒下上上丝丑:  丅专丕三且丑丘专下.上专丗丏丛丁专丑丄().WeaponIndex);
            if(val_6 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponForSkinContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._weaponForSkinNameLabel, 丕丗丘丑丛与丑业丒:  val_6);
        }
        private void 丒丄丏丏下且万与丟(一一万丒与专丙丁丛 丅丅下丟丑专下与一)
        {
            string val_6;
            UnityEngine.GameObject val_7;
            val_6 = 丅丅下丟丑专下与一;
            val_7 = this._divisionContainer;
            if(val_6 == 1)
            {
                    return;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._divisionContainer, 丏业丟一东丂东丘丛:  true);
            val_7 = mem[this._useMiniIcon == true ? "cup{0}_mini_thin" : "cup{0}_small"];
            val_7 = (this._useMiniIcon == true) ? "cup{0}_mini_thin" : "cup{0}_small";
            val_6 = System.String.Format(format:  val_7, arg0:  val_6 + 1.ToString());
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._divisionSprite, 万丑丞一丝丌丐丒丘:  val_6);
        }
        private string 不丄丁下丞万丛丞丕(bool 丌丌东东丙丘丕丈丌)
        {
            return (string)(丌丌东东丙丘丕丈丌 != true) ? "Lev_comp_gold_star" : "Lev_comp_gray_star";
        }
        private void 丞丁丐丆丟一丘丌不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = val_2;
            val_5 = val_2.与丗且业下万东丟丂(丞丘丞丏业且丛丏丘:  val_5);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfParts, 丏业丟一东丂东丘丛:  val_5);
            PGCompany.丗丟丄丈东丝丕丄世 val_6 = val_2;
            val_6 = (~(this.enableIfParts.与丗且业下万东丟丂(丞丘丞丏业且丛丏丘:  val_6))) & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bisableIfParts, 丏业丟一东丂东丘丛:  val_6);
        }
        private bool 与丗且业下万东丟丂(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
        {
            if(丞丘丞丏业且丛丏丘 == null)
            {
                    return false;
            }
            
            PGCompany.丄丂丌丞丁丙七丆三 val_1 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  丞丘丞丏业且丛丏丘.业东丅东丌上丗丑不());
            }
            
            return val_1.丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  丞丘丞丏业且丛丏丘.业东丅东丌上丗丑不());
        }
        public void U_ShowItemInfo()
        {
            if(this.丄世丗丝丁丂丈丅一 != null)
            {
                    this.丄世丗丝丁丂丈丅一.Invoke(obj:  this);
            }
            
            if(PGCompany.InventoryItemView.世丙丄一丂世不万丁 == null)
            {
                    return;
            }
            
            PGCompany.InventoryItemView.世丙丄一丂世不万丁.Invoke(obj:  this);
        }
        private void 下三丕专丟丌丂丗丒(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_6;
            System.Collections.Generic.List<ItemViewComponent> val_7;
            val_6 = 丈丄不七三万丄丁不;
            if((this.丞丒丄一丞七丒且丛 == null) || (this.丞丒丄一丞七丒且丛.Count == 0))
            {
                goto label_2;
            }
            
            val_7 = this.丞丒丄一丞七丒且丛;
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            val_7 = System.Linq.Enumerable.ToList<ItemViewComponent>(source:  this.GetComponentsInChildren<ItemViewComponent>(includeInactive:  true));
            this.丞丒丄一丞七丒且丛 = val_7;
            if(val_7 != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            List.Enumerator<T> val_4 = val_7.GetEnumerator();
            label_8:
            if(((-605251400) & 1) == 0)
            {
                goto label_6;
            }
            
            if(0.丐丏七丌丕丗业且上() == null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 万且专与下业专业丘(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            if(coinsShop.七三丗丏丑丗三丆世() != false)
            {
                    decimal val_3 = System.Decimal.op_Implicit(value:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌());
                string val_5 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且业业丈丅丝丟丄专(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, 丞丂业丅丟丙丏七丗:  丈丄不七三万丄丁不.业东丅东丌上丗丑不(), 丆丗丘丕且丈丘丁不:  "F2");
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._oneLabelPrice, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._oneLabelPriceText), arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278")));
        }
        public InventoryItemView()
        {
            this._useMiniIcon = true;
            this.丞丒丄一丞七丒且丛 = new System.Collections.Generic.List<ItemViewComponent>();
            this.且丏且丅东下业丑丅 = new System.Collections.Generic.List<UISprite>();
        }
        private void 丒七世丘丘丛丕三七(UILabel 三丟东丕丄丄下下丑)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  三丟东丕丄丄下下丑, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        private void 丘业东丌丁下丏丆丁(UILabel 三丟东丕丄丄下下丑)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  三丟东丕丄丄下下丑, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
    
    }

}
