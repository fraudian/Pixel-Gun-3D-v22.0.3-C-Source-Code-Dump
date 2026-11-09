using UnityEngine;
internal class ItemRewardView : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView itemView;
    private System.Collections.Generic.List<ItemRewardView.TagObjectEntry> tagObjects;
    private PGCompany.丄与丘丑业专丞七丅 <丕丟专丅丟丑下丈七>k__BackingField;
    
    // Properties
    internal PGCompany.丄与丘丑业专丞七丅 丄与丘丑业专丞七丅 { get; set; }
    
    // Methods
    internal PGCompany.丄与丘丑业专丞七丅 且丗丐东丘一丛东丒()
    {
        return (PGCompany.丄与丘丑业专丞七丅)this.<丕丟专丅丟丑下丈七>k__BackingField;
    }
    private void 丑与丂七三丈丛丅丒(PGCompany.丄与丘丑业专丞七丅 丙业与丙丗丝不丈东)
    {
        this.<丕丟专丅丟丑下丈七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.丄与丘丑业专丞七丅 丘丂丅且丄丑丞万丟)
    {
        this.<丕丟专丅丟丑下丈七>k__BackingField = 丘丂丅且丄丑丞万丟;
        this.itemView.Setup(丈丄不七三万丄丁不:  丘丂丅且丄丑丞万丟.ItemParams);
        goto typeof(ItemRewardView).__il2cppRuntimeField_178;
    }
    internal virtual void 丝一丅丆三东丂丞七()
    {
        var val_3;
        if((this.<丕丟专丅丟丑下丈七>k__BackingField) == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tagObjects.GetEnumerator();
        label_7:
        if((280990048 & 1) == 0)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_7;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_5 = this.tagObjects.GetEnumerator();
        label_20:
        if((280990048 & 1) == 0)
        {
            goto label_14;
        }
        
        string val_6 = val_3.丐丏七丌丕丗业且上();
        int val_8 = val_6.m_stringLength;
        val_8 = this.<丕丟专丅丟丑下丈七>k__BackingField.Tag.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tagObjects, 丏业丟一东丂东丘丛:  val_8);
        goto label_20;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ItemRewardView()
    {
    
    }

}
