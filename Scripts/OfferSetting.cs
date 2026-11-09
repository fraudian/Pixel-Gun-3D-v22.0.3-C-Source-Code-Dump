using UnityEngine;
[Serializable]
internal class 七丞丄丘七丌上下丘.OfferSetting
{
    // Fields
    internal int Price;
    internal int Armor;
    internal int Cape;
    internal int Mask;
    internal int Hat;
    internal int Boots;
    internal int Glider;
    internal int Transport;
    internal int Vip;
    internal int Gacha;
    internal int Event;
    internal System.Collections.Generic.List<Rilisoft.Offers.七丞丄丘七丌上下丘.OfferWeaponSetting> Weapons;
    internal System.Collections.Generic.List<Rilisoft.Offers.七丞丄丘七丌上下丘.OfferCommonItemSetting> LobbyItems;
    internal System.Collections.Generic.List<Rilisoft.Offers.七丞丄丘七丌上下丘.OfferCommonItemSetting> Pets;
    internal System.Collections.Generic.List<Rilisoft.Offers.七丞丄丘七丌上下丘.OfferCommonItemSetting> Gadgets;
    internal System.Collections.Generic.List<string> OfferItemIds;
    private System.Collections.Generic.List<Rilisoft.OfferItem> _offerItems;
    
    // Properties
    internal System.Collections.Generic.List<Rilisoft.OfferItem> OfferItems { get; }
    
    // Methods
    internal System.Collections.Generic.List<Rilisoft.OfferItem> get_OfferItems()
    {
        System.Collections.Generic.List<Rilisoft.OfferItem> val_3 = this._offerItems;
        if(val_3 != null)
        {
                return val_3;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = null;
        val_3 = val_1;
        val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        this._offerItems = val_3;
        if(this.OfferItemIds == null)
        {
                return val_3;
        }
        
        this.OfferItemIds.ForEach(action:  new System.Action<System.String>(object:  this, method:  System.Void 七丞丄丘七丌上下丘.OfferSetting::三下丟丈丈丆东丂丁(string 三丟东丕丄丄下下丑)));
        val_3 = this._offerItems;
        return val_3;
    }
    public override string ToString()
    {
        object[] val_1 = new object[5];
        string val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.Weapons);
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.LobbyItems);
        val_1[2] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.Pets);
        val_1[3] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.Gadgets);
        val_1[4] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.OfferItems);
        return System.String.Format(format:  "[Weapons={0} LobbyItems={1} Pets={2} Gadgets={3} OfferItems={4}]", args:  val_1);
    }
    public 七丞丄丘七丌上下丘.OfferSetting()
    {
    
    }
    private void 三下丟丈丈丆东丂丁(string 三丟东丕丄丄下下丑)
    {
        this._offerItems.Add(item:  new Rilisoft.OfferItem(丞丕丒专一下丙业上:  三丟东丕丄丄下下丑));
    }

}
