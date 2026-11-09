using UnityEngine;
[Serializable]
public class SlotInfo : 丙专丒丄丅一丘上丌
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 _countGift;
    public System.Collections.Generic.List<GiftCategory> gifts;
    public GiftInfo gift;
    public int index;
    public bool IsSlotAvailable;
    internal bool IsEmpty;
    public int numInScroll;
    private GiftCategoryType _originalType;
    private int <PositionInScroll>k__BackingField;
    
    // Properties
    public int PositionInScroll { get; set; }
    public GiftCategoryType GiftCategoryType { get; }
    public GiftCategory category { get; }
    public bool HasParts { get; }
    public int CountGift { get; set; }
    
    // Methods
    public int get_PositionInScroll()
    {
        return (int)this.<PositionInScroll>k__BackingField;
    }
    public void set_PositionInScroll(int 丙业与丙丗丝不丈东)
    {
        this.<PositionInScroll>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public SlotInfo()
    {
        this._countGift = 0;
        mem[1152921537840874840] = 0;
        this.gifts = new System.Collections.Generic.List<GiftCategory>();
        this.IsSlotAvailable = true;
        this.gift = 0;
        this.<PositionInScroll>k__BackingField = 0;
    }
    public SlotInfo(SlotInfo 与丄不丌一世东丁丙)
    {
        System.Collections.Generic.List<GiftCategory> val_3;
        this._countGift = 0;
        mem[1152921537841015512] = 0;
        System.Collections.Generic.List<GiftCategory> val_1 = null;
        val_3 = val_1;
        val_1 = new System.Collections.Generic.List<GiftCategory>();
        this.gifts = val_3;
        this.IsSlotAvailable = true;
        if(与丄不丌一世东丁丙 != null)
        {
                this.gift = 与丄不丌一世东丁丙.gift;
            this.<PositionInScroll>k__BackingField = 与丄不丌一世东丁丙.<PositionInScroll>k__BackingField;
            this.IsSlotAvailable = 与丄不丌一世东丁丙.IsSlotAvailable;
            val_3 = 与丄不丌一世东丁丙.gifts;
            this.gifts = new System.Collections.Generic.List<GiftCategory>(collection:  val_3);
            this.index = 与丄不丌一世东丁丙.index;
            this._originalType = 与丄不丌一世东丁丙._originalType;
            return;
        }
        
        this.IsSlotAvailable = true;
        this.IsEmpty = true;
    }
    public GiftCategoryType get_GiftCategoryType()
    {
        return (GiftCategoryType)this._originalType;
    }
    internal void 业丐丘世丅丅三丁丅(GiftCategoryType 丁丅丈丌丟世丗丗丟)
    {
        this._originalType = 丁丅丈丌丟世丗丗丟;
    }
    public GiftCategory get_category()
    {
        int val_5 = this.index;
        if(this.gifts.Count > val_5)
        {
                return (GiftCategory)this.gifts.Item[val_5];
        }
        
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "{0}   {1}", arg0:  val_5 = this.index, arg1:  this.gifts.Count));
        val_5 = this.index;
        return (GiftCategory)this.gifts.Item[val_5];
    }
    public bool get_HasParts()
    {
        if(this.gift != null)
        {
                return (bool)this.gift.HasParts;
        }
        
        return (bool)this.gift.HasParts;
    }
    public int get_CountGift()
    {
        if(this.gift != null)
        {
                return this.gift.Count;
        }
        
        return this.gift.Count;
    }
    public void set_CountGift(int 丙业与丙丗丝不丈东)
    {
    
    }
    public bool 丛丑丏丐丒丅丂丄丄()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(this.gift == null)
        {
            goto label_10;
        }
        
        }
        
        if(this.category != null)
        {
                GiftCategory val_4 = this.category;
            if((this.category.丝专丝丞与丟丝丗丞(且丌丒丝不丛上三丆:  this.gift, 丒丕七丄丏三丕丗丑:  val_4.Type)) != false)
        {
                val_7 = 0;
            return (bool)val_7;
        }
        
        }
        
        label_10:
        val_8 = null;
        val_8 = null;
        GiftController.丆丕丝丒不丙且丐丗.UpdateSlot(专不丟丕丞丗三世丂:  this);
        val_7 = 1;
        return (bool)val_7;
    }
    public void 且丂丈东三上丂业丆()
    {
        var val_10;
        var val_11;
        GiftCategory val_1 = new GiftCategory();
        .Type = 1;
        GiftCategory val_2 = this.category;
        .Parity = val_2.Parity;
        mem[1152921537842148456] = ???;
        GiftCategory val_3 = this.category;
        .ListPosition = val_3.ListPosition;
        val_10 = null;
        val_10 = null;
        .Id = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        val_11 = null;
        val_11 = null;
        .Counts = GiftController.丆丕丝丒不丙且丐丗.丂且世七丏专专与上;
        .KeyTranslateInfo = GiftController.丁不丐丕专一丞业与(丁丅丈丌丟世丗丗丟:  1);
        val_1.不丕丕专不丅一三丁(东一丁世丑丞业丄丐:  new GiftInfo());
        this.index = 0;
        GiftCategory[] val_6 = new GiftCategory[1];
        val_6[0] = val_1;
        this.gifts = new System.Collections.Generic.List<GiftCategory>(collection:  val_6);
        this.gift = this.category.丄丗三业东丕丙丈丄(专东丅一三丏三丐丟:  false);
        val_9.Counts = GiftController.丆丕丝丒不丙且丐丗.丂且世七丏专专与上;
    }
    internal void 且丂丈东三上丂业丆(SlotInfo 万丏不下丕下丈丗丞)
    {
        var val_10;
        var val_11;
        if(万丏不下丕下丈丗丞._originalType == 1)
        {
                GiftCategory val_1 = new GiftCategory();
            .Type = 1;
            GiftCategory val_2 = 万丏不下丕下丈丗丞.category;
            .Parity = val_2.Parity;
            mem[1152921537842350600] = ???;
            GiftCategory val_3 = 万丏不下丕下丈丗丞.category;
            .ListPosition = val_3.ListPosition;
            val_10 = null;
            val_10 = null;
            .Id = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            val_11 = null;
            val_11 = null;
            .Counts = GiftController.丆丕丝丒不丙且丐丗.丂且世七丏专专与上;
            .KeyTranslateInfo = GiftController.丁不丐丕专一丞业与(丁丅丈丌丟世丗丗丟:  1);
            val_1.不丕丕专不丅一三丁(东一丁世丑丞业丄丐:  new GiftInfo());
            this.index = 0;
            GiftCategory[] val_6 = new GiftCategory[1];
            val_6[0] = val_1;
            this.gifts = new System.Collections.Generic.List<GiftCategory>(collection:  val_6);
            this.gift = this.category.丄丗三业东丕丙丈丄(专东丅一三丏三丐丟:  false);
            val_9.Counts = GiftController.丆丕丝丒不丙且丐丗.丂且世七丏专专与上;
            return;
        }
        
        this.且丂丈东三上丂业丆();
    }

}
