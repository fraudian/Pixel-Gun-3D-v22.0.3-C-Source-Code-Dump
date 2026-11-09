using UnityEngine;
[Serializable]
public class PlaceableItemSettings
{
    // Fields
    public string supercategory;
    public string category;
    public string subcategory;
    public string iconName;
    public string nameLocalizationKey;
    public string descriptionLocalizationKey;
    public PlaceableItemSettings.丑业专丄七与与丕上 itemType;
    public SquareFieldCellSize cellSize;
    public System.Collections.Generic.List<丑丙上丛万丙丌且丙> infoProreties;
    public System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> inShopEffects;
    public string name;
    public PlaceableItemSettingsSO so;
    public bool showDirection;
    public bool moveableInFortField;
    public PlaceableItemSettings.丆一三专丏三与与七 uploadItemType;
    public System.Collections.Generic.List<string> uploadItemNames;
    
    // Properties
    public string Id { get; set; }
    public string SupercategoryName { get; }
    public string CategoryName { get; }
    public string SubcategoryName { get; }
    public string CategoryLocalizeName { get; }
    public string SubategoryLocalizeName { get; }
    internal bool IsUnknown { get; }
    internal bool IsKnownResources { get; }
    public UnityEngine.Texture ItemTexure { get; }
    internal bool IsUpgradable { get; }
    internal bool IsDecoration { get; }
    internal bool IsGuard { get; }
    internal 丈丞丕丘丕丗与上一 PurchasePrice { get; }
    internal bool IsPurchased { get; }
    internal int Upgrade { get; }
    internal int MaxUpgrade { get; }
    internal int Index { get; }
    private PlaceableItemProperties.Upgrade _upgradeProperties { get; }
    private PlaceableItemProperties _properties { get; }
    private 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅 _buildingSettings { get; }
    internal float SortingWeight { get; }
    internal 一一万丒与专丙丁丛 ClanDivision { get; }
    internal ItemRarity ItemRarity { get; }
    internal int Energy { get; }
    internal Rilisoft.丝丑丂丛万丐丈丘且 RewardPoints { get; }
    internal int NextUpRewardPoints { get; }
    internal int NextNextUpRewardPoints { get; }
    internal Rilisoft.丝丑丂丛万丐丈丘且 UpgradeCards { get; }
    internal int UpgradeTime { get; }
    internal float HealthMonster { get; }
    internal float Damage { get; }
    internal float NextUpDamage { get; }
    internal float DamagePerSecond { get; }
    internal float NextUpDamagePerSecond { get; }
    internal float Radius { get; }
    internal float Speed { get; }
    internal float Cooldown { get; }
    internal float Durability { get; }
    internal float NextUpDurability { get; }
    public bool Removable { get; }
    public bool Unique { get; }
    public bool Placeable { get; }
    public int Power { get; }
    public int NextUpPower { get; }
    
    // Methods
    public string get_Id()
    {
        if(this.so == 0)
        {
                return (string)this.name;
        }
        
        if(this.so != null)
        {
                return this.so.name;
        }
        
        return this.so.name;
    }
    public void set_Id(string 丙业与丙丗丝不丈东)
    {
        this.name = 丙业与丙丗丝不丈东;
        if(this.so == 0)
        {
                return;
        }
        
        this.so.name = 丙业与丙丗丝不丈东;
    }
    public string get_SupercategoryName()
    {
        return (string)this.supercategory;
    }
    public string get_CategoryName()
    {
        return 丄丈业一下万且丂丕.丂丟丘下与且丐丗丛(丆下不丌丄丂与与丄:  this.category);
    }
    public string get_SubcategoryName()
    {
        return 丄丈业一下万且丂丕.丂丟丘下与且丐丗丛(丆下不丌丄丂与与丄:  this.subcategory);
    }
    public string get_CategoryLocalizeName()
    {
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + this.CategoryName + "_Title");
    }
    public string get_SubategoryLocalizeName()
    {
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "PlaceableItems_" + this.SubcategoryName + "_Title");
    }
    internal bool get_IsUnknown()
    {
        var val_19;
        var val_20;
        val_19 = this;
        if(this.一丌世丑丄东丞丘三() != null)
        {
                if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  this.一丌世丑丄东丞丘三().丑丐丙丄丅世世丑丒())) != false)
        {
                val_20 = 0;
            return (bool)val_20;
        }
        
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Unknown Item: "("Unknown Item: ") + this.name);
        if(this.一丌世丑丄东丞丘三() != null)
        {
                丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "\tId: "("\tId: ") + this.一丌世丑丄东丞丘三().丑丐丙丄丅世世丑丒().业上丙丞丐丄丆丅七());
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "\tIndex: "("\tIndex: ") + this.一丌世丑丄东丞丘三().丑丐丙丄丅世世丑丒().业东丅东丌上丗丑不());
            val_19 = this.一丌世丑丄东丞丘三().丑丐丙丄丅世世丑丒();
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "\tType: "("\tType: ") + val_19.不业丙丒丂丞下丆丙());
        }
        
        val_20 = 1;
        return (bool)val_20;
    }
    internal bool get_IsKnownResources()
    {
        return 丄丈业一下万且丂丕.丞丟丑丆丁丟丁丒万(丆专且丕专丗与一丏:  this.Index);
    }
    public UnityEngine.Texture get_ItemTexure()
    {
        return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.iconName);
    }
    public UnityEngine.Texture 丑东丐下专丞丕丘世()
    {
        UnityEngine.Object val_4 = this.ItemTexure;
        if(val_4 != 0)
        {
                return (UnityEngine.Texture)val_4;
        }
        
        val_4 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/unknown_item");
        return (UnityEngine.Texture)val_4;
    }
    public string 丘丄业丞丏与与丅丐()
    {
        string val_1 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.nameLocalizationKey);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8778");
        }
        
        if((val_1.StartsWith(value:  "Key_")) == false)
        {
                return val_1;
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8778");
    }
    public string 东且丏丆万与东丙万()
    {
        string val_1 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.descriptionLocalizationKey);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8779");
        }
        
        if((val_1.StartsWith(value:  "Key_")) == false)
        {
                return val_1;
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8779");
    }
    internal bool get_IsUpgradable()
    {
        var val_5;
        var val_6;
        val_5 = this;
        if(this.IsUnknown != false)
        {
                val_6 = 0;
        }
        else
        {
                val_5 = this.CategoryName;
            bool val_3 = val_5.Contains(value:  "Decoration");
            val_6 = val_3 ^ 1;
        }
        
        val_3 = val_6;
        return (bool)val_3;
    }
    internal bool get_IsDecoration()
    {
        if(this.IsUnknown != false)
        {
                return false;
        }
        
        string val_2 = this.CategoryName;
        if(val_2 != null)
        {
                return val_2.Contains(value:  "Decoration");
        }
        
        return val_2.Contains(value:  "Decoration");
    }
    internal bool get_IsGuard()
    {
        string val_1 = this.SubcategoryName;
        if(val_1 != null)
        {
                return val_1.Contains(value:  "FortGuard");
        }
        
        return val_1.Contains(value:  "FortGuard");
    }
    internal 丈丞丕丘丕丗与上一 get_PurchasePrice()
    {
        var val_9;
        var val_10;
        string val_11;
        var val_12;
        if(this._properties == null)
        {
            goto label_3;
        }
        
        PlaceableItemProperties val_2 = this._properties;
        if(val_2.price == null)
        {
            goto label_3;
        }
        
        PlaceableItemProperties val_3 = this._properties;
        PlaceableItemProperties val_5 = this._properties;
        val_9 = new 丈丞丕丘丕丗与上一();
        val_10 = val_3.price.丂丁丏一丙丛业且丌();
        val_11 = val_5.price.业上丙丞丐丄丆丅七();
        goto label_8;
        label_3:
        UnityEngine.Debug.LogError(message:  "!!!ERROR!!! Set price for PlaceableItem: "("!!!ERROR!!! Set price for PlaceableItem: ") + this.name);
        val_12 = null;
        val_12 = null;
        丈丞丕丘丕丗与上一 val_8 = null;
        val_9 = val_8;
        val_10 = 9999;
        val_11 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        label_8:
        val_8 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  15, 丏丂不专上丘丂不丅:  val_11);
        return (丈丞丕丘丕丗与上一)val_9;
    }
    internal bool get_IsPurchased()
    {
        var val_7;
        PGCompany.万丛下丐与丅与丅专 val_1 = this.一丌世丑丄东丞丘三();
        if(val_1 == null)
        {
                return (bool)val_7.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_1.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        
        val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        return (bool)val_7.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_1.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
    }
    internal PGCompany.万丛下丐与丅与丅专 丈业丂不三丌不丂丁()
    {
        PGCompany.万丛下丐与丅与丅专 val_1 = this.一丌世丑丄东丞丘三();
        if(val_1 == null)
        {
                return (PGCompany.万丛下丐与丅与丅专)this.上丟丘下世七与丁世<PGCompany.万丛下丐与丅与丅专>(丈丄不七三万丄丁不:  val_1.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        
        this = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        return (PGCompany.万丛下丐与丅与丅专)this.上丟丘下世七与丁世<PGCompany.万丛下丐与丅与丅专>(丈丄不七三万丄丁不:  val_1.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
    }
    internal PGCompany.万丛下丐与丅与丅专 一丌世丑丄东丞丘三()
    {
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  this.name))) == false)
        {
                return (PGCompany.万丛下丐与丅与丅专)val_7.一丌世丑丄东丞丘三<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  this.name));
        }
        
        val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        return (PGCompany.万丛下丐与丅与丅专)val_7.一丌世丑丄东丞丘三<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  this.name));
    }
    internal PGCompany.万丛下丐与丅与丅专 丐万且丏丙万下专丑()
    {
        PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丐万且丏丙万下专丑<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  this.name));
        }
        
        return val_1.丐万且丏丙万下专丑<PGCompany.万丛下丐与丅与丅专>(丁丅丈丌丟世丗丗丟:  216, 丞丅上丏丂且下丅与:  PGCompany.丌丂丐丕丑丐丅世丄.世专丌七且丝丅世丙(不丌万且丈且不七丛:  this.name));
    }
    internal PGCompany.三丙业丆上丏三丈丌 丝丆丂丆不丟丌丕丝()
    {
        string val_5;
        var val_6;
        val_5 = this;
        val_6 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  226, 丞丅上丏丂且下丅与:  this.name)) == false)
        {
                return (PGCompany.三丙业丆上丏三丈丌)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.三丙业丆上丏三丈丌>(丁丅丈丌丟世丗丗丟:  226, 丞丅上丏丂且下丅与:  val_5 = this.name);
        }
        
        return (PGCompany.三丙业丆上丏三丈丌)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.三丙业丆上丏三丈丌>(丁丅丈丌丟世丗丗丟:  226, 丞丅上丏丂且下丅与:  val_5);
    }
    internal int get_Upgrade()
    {
        PGCompany.万丛下丐与丅与丅专 val_1 = this.丈业丂不三丌不丂丁();
        if(val_1 == null)
        {
                return (int)val_1;
        }
        
        return val_1.丁丕丁三丁丗不三丟();
    }
    internal int get_MaxUpgrade()
    {
        PlaceableItemProperties val_1 = this._properties;
        int val_2 = System.Linq.Enumerable.Count<Upgrade>(source:  val_1.Upgrades);
        val_2 = val_2 - 1;
        return (int)val_2;
    }
    internal int get_Index()
    {
        PGCompany.万丛下丐与丅与丅专 val_1 = this.一丌世丑丄东丞丘三();
        if(val_1 == null)
        {
                return (int)val_1;
        }
        
        return val_1.业东丅东丌上丗丑不();
    }
    private PlaceableItemProperties.Upgrade get__upgradeProperties()
    {
        int val_11 = this;
        if((this.Upgrade & 2147483648) == 0)
        {
                PlaceableItemProperties val_3 = this._properties;
            PlaceableItemProperties val_5 = this._properties;
            if(this.Upgrade >= val_3.Upgrades.Count)
        {
                return (Upgrade)System.Linq.Enumerable.Last<Upgrade>(source:  val_5.Upgrades);
        }
        
            val_11 = this.Upgrade;
            Upgrade val_7 = val_5.Upgrades.Item[val_11];
            return (Upgrade)System.Linq.Enumerable.Last<Upgrade>(source:  val_5.Upgrades);
        }
        
        val_11 = this._properties;
        Upgrade val_9 = System.Linq.Enumerable.First<Upgrade>(source:  val_8.Upgrades);
        return (Upgrade)System.Linq.Enumerable.Last<Upgrade>(source:  val_5.Upgrades);
    }
    private PlaceableItemProperties get__properties()
    {
        PGCompany.丘丞丞丟丗丐世丅丈 val_1 = PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.东丐丒一且丄下一丒(丞一丁业丄一一业且:  this.name);
        }
        
        return val_1.东丐丒一且丄下一丒(丞一丁业丄一一业且:  this.name);
    }
    private 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅 get__buildingSettings()
    {
        丄与东丕丑丗丌七上 val_1 = 丄与东丕丑丗丌七上.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丐下下丅与上东丙丑(丈丟且丐上不世专丁:  this.name);
        }
        
        return val_1.丐下下丅与上东丙丑(丈丟且丐上不世专丁:  this.name);
    }
    internal float get_SortingWeight()
    {
        if(this._properties != null)
        {
                return (float)val_1.sortingWeight;
        }
        
        return (float)val_1.sortingWeight;
    }
    internal 一一万丒与专丙丁丛 get_ClanDivision()
    {
        if(this._properties != null)
        {
                return (一一万丒与专丙丁丛)val_1.clanDivision;
        }
        
        return (一一万丒与专丙丁丛)val_1.clanDivision;
    }
    internal ItemRarity get_ItemRarity()
    {
        if(this._properties != null)
        {
                return (ItemRarity)val_1.ItemRarity;
        }
        
        return (ItemRarity)val_1.ItemRarity;
    }
    internal int get_Energy()
    {
        PlaceableItemProperties val_1 = this._properties;
    }
    internal Rilisoft.丝丑丂丛万丐丈丘且 get_RewardPoints()
    {
        if(this._upgradeProperties != null)
        {
                return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.rewardPoints, 丑丒丄下丁丐专丄丞 = val_1.rewardPoints};
        }
        
        return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.rewardPoints, 丑丒丄下丁丐专丄丞 = val_1.rewardPoints};
    }
    internal int get_NextUpRewardPoints()
    {
        System.Collections.Generic.List<Upgrade> val_11 = this;
        int val_11 = this.Upgrade;
        PlaceableItemProperties val_2 = this._properties;
        val_11 = val_11 + 1;
        if(val_2.Upgrades.Count <= val_11)
        {
                return 0;
        }
        
        PlaceableItemProperties val_4 = this._properties;
        val_11 = val_4.Upgrades;
        if(val_11.Item[val_11] == null)
        {
                return 0;
        }
        
        val_11 = ???;
        return 0;
    }
    internal int get_NextNextUpRewardPoints()
    {
        System.Collections.Generic.List<Upgrade> val_11 = this;
        int val_11 = this.Upgrade;
        PlaceableItemProperties val_2 = this._properties;
        val_11 = val_11 + 2;
        if(val_2.Upgrades.Count <= val_11)
        {
                return 0;
        }
        
        PlaceableItemProperties val_4 = this._properties;
        val_11 = val_4.Upgrades;
        if(val_11.Item[val_11] == null)
        {
                return 0;
        }
        
        val_11 = ???;
        return 0;
    }
    internal Rilisoft.丝丑丂丛万丐丈丘且 get_UpgradeCards()
    {
        if(this._upgradeProperties != null)
        {
                return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.upgradeCards, 丑丒丄下丁丐专丄丞 = val_1.upgradeCards};
        }
        
        return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.upgradeCards, 丑丒丄下丁丐专丄丞 = val_1.upgradeCards};
    }
    internal int get_UpgradeTime()
    {
        var val_13;
        int val_14;
        val_13 = this;
        PlaceableItemProperties val_2 = this._properties;
        if((this.Upgrade + 1) < val_2.Upgrades.Count)
        {
                if(((this.Upgrade + 1) & 2147483648) == 0)
        {
                PlaceableItemProperties val_7 = this._properties;
            Upgrade val_10 = val_7.Upgrades.Item[this.Upgrade + 1];
            val_13 = val_10.upgradeTime;
            System.TimeSpan val_11 = System.TimeSpan.FromMinutes(value:  (double)val_13);
            val_14 = (int)val_11._ticks.TotalSeconds;
            return (int)val_14;
        }
        
        }
        
        val_14 = 0;
        return (int)val_14;
    }
    internal int 东上丆丄丘丙七丞丙(int 丞丌东丟且丒丐丑丂)
    {
        int val_10 = 丞丌东丟且丒丐丑丂;
        PlaceableItemProperties val_1 = this._properties;
        if(val_1.Upgrades.Count <= val_10)
        {
                return 0;
        }
        
        PlaceableItemProperties val_3 = this._properties;
        Upgrade val_4 = val_3.Upgrades.Item[val_10];
        val_10 = ???;
        return 0;
    }
    internal float get_HealthMonster()
    {
        var val_31;
        var val_32;
        UnityEngine.Object val_33;
        float val_34;
        float val_35;
        val_31 = 1152921524404748272;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_32 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丑与丏丈丕七丙丂();
        }
        else
        {
                val_32 = 0;
        }
        
        if((this.uploadItemNames != null) && (this.uploadItemNames.Count >= 1))
        {
                val_33 = UnityEngine.Resources.Load<FortSpawnMob>(path:  "FortField/FortItemsContent/InGame/"("FortField/FortItemsContent/InGame/") + this.uploadItemNames.Item[0]);
        }
        else
        {
                val_33 = 0;
        }
        
        val_34 = -1f;
        if(val_33 == 0)
        {
                return (float)val_34;
        }
        
        if(2 == 0)
        {
                return (float)val_34;
        }
        
        if(2.Count < 1)
        {
                return (float)val_34;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Getting HealthMonster");
        val_31 = 世丐丟三丑一万丌一.丑七不且上丗丁一世();
        val_35 = 1f;
        if(val_31.一不丆丅万一丞丙丟() != null)
        {
                val_31 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().一不丆丅万一丞丙丟();
            if(val_31.Count >= 1)
        {
                val_31 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().一不丆丅万一丞丙丟();
            val_35 = val_31.Item[UnityEngine.Mathf.Min(a:  0, b:  世丐丟三丑一万丌一.丑七不且上丗丁一世().一不丆丅万一丞丙丟().Count - 1)];
        }
        
        }
        
        val_32 = 万七万丂三与丏丘丅.丑七不且上丗丁一世().丐下下丅与上东丙丑(三丒丈七东下丌丝丗:  2.Item[0]);
        val_34 = (val_35 * val_32.三丏丟不丆丅丞不丛()) * DungeonsController.且丗与丈丆丘丙丑丞();
        return (float)val_34;
    }
    internal float get_Damage()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        if(val_1.丁丙丅不丝丐丛丆丁() == null)
        {
                return -1f;
        }
        
        if(val_1.丁丙丅不丝丐丛丆丁().Count < 1)
        {
                return -1f;
        }
        
        System.Collections.Generic.List<System.Single> val_8 = val_1.丁丙丅不丝丐丛丆丁();
        if(val_1.丁丙丅不丝丐丛丆丁().Count <= this.Upgrade)
        {
                return System.Linq.Enumerable.Last<System.Single>(source:  val_8);
        }
        
        if(val_8 != null)
        {
                return val_8.Item[this.Upgrade];
        }
        
        return val_8.Item[this.Upgrade];
    }
    internal float get_NextUpDamage()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        if(val_1.丁丙丅不丝丐丛丆丁() == null)
        {
                return -1f;
        }
        
        if(val_1.丁丙丅不丝丐丛丆丁().Count < 1)
        {
                return -1f;
        }
        
        System.Collections.Generic.List<System.Single> val_9 = val_1.丁丙丅不丝丐丛丆丁();
        if(val_1.丁丙丅不丝丐丛丆丁().Count <= (this.Upgrade + 1))
        {
                return System.Linq.Enumerable.Last<System.Single>(source:  val_9);
        }
        
        return val_9.Item[this.Upgrade + 1];
    }
    internal float get_DamagePerSecond()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        if(val_1.三丝业丅且且丂丅上() == null)
        {
                return -1f;
        }
        
        if(val_1.三丝业丅且且丂丅上().Count < 1)
        {
                return -1f;
        }
        
        System.Collections.Generic.List<System.Single> val_8 = val_1.三丝业丅且且丂丅上();
        if(val_1.三丝业丅且且丂丅上().Count <= this.Upgrade)
        {
                return System.Linq.Enumerable.Last<System.Single>(source:  val_8);
        }
        
        if(val_8 != null)
        {
                return val_8.Item[this.Upgrade];
        }
        
        return val_8.Item[this.Upgrade];
    }
    internal float get_NextUpDamagePerSecond()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        if(val_1.三丝业丅且且丂丅上() == null)
        {
                return -1f;
        }
        
        if(val_1.三丝业丅且且丂丅上().Count < 1)
        {
                return -1f;
        }
        
        System.Collections.Generic.List<System.Single> val_9 = val_1.三丝业丅且且丂丅上();
        if(val_1.三丝业丅且且丂丅上().Count <= (this.Upgrade + 1))
        {
                return System.Linq.Enumerable.Last<System.Single>(source:  val_9);
        }
        
        return val_9.Item[this.Upgrade + 1];
    }
    internal float get_Radius()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        return val_1.不七不丈丐万丂丌下();
    }
    internal float get_Speed()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        return val_1.丂且专丕丄丗丒丝业();
    }
    internal float get_Cooldown()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        return val_1.丙丈丗丌丘三丄业且();
    }
    internal float get_Durability()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        if(val_1.丆丑丛东丄丕丑专丗() == null)
        {
                return -1f;
        }
        
        if(val_1.丆丑丛东丄丕丑专丗().Count < 1)
        {
                return -1f;
        }
        
        System.Collections.Generic.List<System.Single> val_8 = val_1.丆丑丛东丄丕丑专丗();
        if(val_1.丆丑丛东丄丕丑专丗().Count <= this.Upgrade)
        {
                return System.Linq.Enumerable.Last<System.Single>(source:  val_8);
        }
        
        if(val_8 != null)
        {
                return val_8.Item[this.Upgrade];
        }
        
        return val_8.Item[this.Upgrade];
    }
    internal float get_NextUpDurability()
    {
        丗一丂丈丅三丌东丅 val_1 = this._buildingSettings;
        if(val_1 == null)
        {
                return -1f;
        }
        
        if(val_1.丆丑丛东丄丕丑专丗() == null)
        {
                return -1f;
        }
        
        if(val_1.丆丑丛东丄丕丑专丗().Count < 1)
        {
                return -1f;
        }
        
        System.Collections.Generic.List<System.Single> val_9 = val_1.丆丑丛东丄丕丑专丗();
        if(val_1.丆丑丛东丄丕丑专丗().Count <= (this.Upgrade + 1))
        {
                return System.Linq.Enumerable.Last<System.Single>(source:  val_9);
        }
        
        return val_9.Item[this.Upgrade + 1];
    }
    public bool get_Removable()
    {
        丑业专丄七与与丕上 val_2 = this.itemType;
        val_2 = val_2 - 2;
        if(val_2 > 3)
        {
                return true;
        }
        
        val_2 = val_2 & 15;
        return (bool)(val_2 == 1) ? 1 : 0;
    }
    public bool get_Unique()
    {
        return System.String.op_Equality(a:  this.SubcategoryName, b:  "TankMainGun");
    }
    public bool get_Placeable()
    {
        string val_3;
        var val_4;
        val_3 = this;
        if(this.Unique != false)
        {
                val_3 = this.name;
            val_4 = Base_BuildingUI_Controller.instance ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 1;
        return (bool)val_4 & 1;
    }
    public int get_Power()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_4;
        if(this._upgradeProperties == null)
        {
                return (int)val_4;
        }
        
        val_4 = val_1.Power;
        return (int)val_4;
    }
    public int get_NextUpPower()
    {
        System.Collections.Generic.List<Upgrade> val_11 = this;
        int val_11 = this.Upgrade;
        PlaceableItemProperties val_2 = this._properties;
        val_11 = val_11 + 1;
        if(val_2.Upgrades.Count <= val_11)
        {
                return 0;
        }
        
        PlaceableItemProperties val_4 = this._properties;
        val_11 = val_4.Upgrades;
        if(val_11.Item[val_11] == null)
        {
                return 0;
        }
        
        val_11 = ???;
        return 0;
    }
    public int 丏丌下丅丁东且丒专(int 丒丈丕丗一丅丗世世)
    {
        PlaceableItemProperties val_1 = this._properties;
        if((丒丈丕丗一丅丗世世 & 2147483648) != 0)
        {
            goto label_2;
        }
        
        PlaceableItemProperties val_3 = this._properties;
        if(val_1.Upgrades.Count <= 丒丈丕丗一丅丗世世)
        {
            goto label_5;
        }
        
        if(val_3.Upgrades.Item[丒丈丕丗一丅丗世世] != null)
        {
            goto label_9;
        }
        
        return (int)val_5;
        label_2:
        Upgrade val_5 = System.Linq.Enumerable.First<Upgrade>(source:  val_1.Upgrades);
        if(val_5 != null)
        {
            goto label_9;
        }
        
        return (int)val_5;
        label_5:
        if((System.Linq.Enumerable.Last<Upgrade>(source:  val_3.Upgrades)) == null)
        {
                return (int)val_5;
        }
        
        label_9:
    }
    public PlaceableItemSettings()
    {
        this.moveableInFortField = true;
        this.supercategory = "";
        this.category = "";
        this.subcategory = "";
        this.iconName = "";
    }

}
