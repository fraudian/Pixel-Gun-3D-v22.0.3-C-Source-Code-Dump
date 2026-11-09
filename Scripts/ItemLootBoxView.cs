using UnityEngine;
internal class ItemLootBoxView : PGBehaviour
{
    // Fields
    protected PGCompany.InventoryItemView chestItemView;
    protected LootBoxMeschView chestMeschView;
    private PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 <且且业丘丏丏且丑丅>k__BackingField;
    
    // Properties
    internal PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丆丂丙万丕丑丞丞丙 { get; set; }
    internal PGCompany.三东丏不丗世丅丌丄 丞丅东东丐上丅丅世 { get; }
    internal PGCompany.丗丟丄丈东丝丕丄世 一三丛丅丌丒丙丆一 { get; }
    
    // Methods
    internal PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 与万丐丕丒且丝一丗()
    {
        return (PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三)this.<且且业丘丏丏且丑丅>k__BackingField;
    }
    private void 丑丟且丂专业丞丙丒(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丙业与丙丗丝不丈东)
    {
        this.<且且业丘丏丏且丑丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.三东丏不丗世丅丌丄 丙丝不业丒丅一且丅()
    {
        if((this.<且且业丘丏丏且丑丅>k__BackingField) == null)
        {
                return (PGCompany.三东丏不丗世丅丌丄)this.<且且业丘丏丏且丑丅>k__BackingField;
        }
        
        return this.<且且业丘丏丏且丑丅>k__BackingField.丝上三丌丙七三七丏();
    }
    internal PGCompany.丗丟丄丈东丝丕丄世 三丈丐万丝丘丘丝丏()
    {
        if((this.<且且业丘丏丏且丑丅>k__BackingField) == null)
        {
                return (PGCompany.丗丟丄丈东丝丕丄世)this.<且且业丘丏丏且丑丅>k__BackingField.丟不丛丑一丗丄业丟();
        }
        
        return (PGCompany.丗丟丄丈东丝丕丄世)this.<且且业丘丏丏且丑丅>k__BackingField.丟不丛丑一丗丄业丟();
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_1 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  丈丄不七三万丄丁不, 与不丕丆丈不丙丟丛:  0);
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_188;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 丅丒丐不上丁丛丟丌)
    {
        PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_2 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  丅丒丐不上丁丛丟丌.丑丐丙丄丅世世丑丒(), 与不丕丆丈不丙丟丛:  0);
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_188;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 一与且丐丝丘与丆丑)
    {
        if(一与且丐丝丘与丆丑 == null)
        {
                return;
        }
        
        this.<且且业丘丏丏且丑丅>k__BackingField = 一与且丐丝丘与丆丑;
        this = ???;
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_1B8;
    }
    protected virtual void 丑丏上丈丒丂且丞丛()
    {
    
    }
    protected virtual void 丌丞下万丈丒丑万丅()
    {
    
    }
    internal virtual void 丝一丅丆三东丂丞七()
    {
        PGCompany.三东丏不丗世丅丌丄 val_2;
        if(this.chestItemView != null)
        {
                if((this.<且且业丘丏丏且丑丅>k__BackingField) != null)
        {
                val_2 = this.<且且业丘丏丏且丑丅>k__BackingField.丝上三丌丙七三七丏();
        }
        else
        {
                val_2 = 0;
        }
        
            this.chestItemView.Setup(丈丄不七三万丄丁不:  val_2);
        }
        
        if(this.chestMeschView == null)
        {
                return;
        }
        
        this.chestMeschView.丈且东丑丂且万丒丅(丆丞丝丘丗丘丙丅万:  this.<且且业丘丏丏且丑丅>k__BackingField);
    }
    internal virtual void 丗丟丛世丅丛丘东丐()
    {
    
    }
    internal virtual void 丂丞丌丆专丗丌丏丑(PGCompany.三东丏不丗世丅丌丄 万七丅上丝三业丘丘)
    {
    
    }
    public virtual void U_OpenChestUI()
    {
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_1C8;
    }
    public virtual void U_OpenChestInfoUI()
    {
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_1C8;
    }
    protected virtual void OnEnable()
    {
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_1B8;
    }
    protected virtual void OnDisable()
    {
    
    }
    protected virtual void OnDestroy()
    {
        goto typeof(ItemLootBoxView).__il2cppRuntimeField_1A8;
    }
    public ItemLootBoxView()
    {
    
    }

}
