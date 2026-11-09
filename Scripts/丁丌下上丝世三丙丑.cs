using UnityEngine;
private class DevTestGift.丁丌下上丝世三丙丑
{
    // Fields
    public GiftCategoryType 七丌丌丏丗东丕且丅;
    public int 丏丕丝丐丗丄专丒丗;
    public int 丏上丗丑丙丆专丌与;
    public string 丞业丏七丝丒丕三丛;
    public int 丁丅七丞不丙丄丝丛;
    
    // Methods
    public DevTestGift.丁丌下上丝世三丙丑(SlotInfo 与丄不丌一世东丁丙)
    {
        GiftInfo val_4;
        GiftCategory val_1 = 与丄不丌一世东丁丙.category;
        this.七丌丌丏丗东丕且丅 = val_1.Type;
        val_4 = 与丄不丌一世东丁丙.gift;
        if(val_4 == null)
        {
            goto label_3;
        }
        
        if(与丄不丌一世东丁丙.gift.RootInfo != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(与丄不丌一世东丁丙.gift == null)
        {
            goto label_8;
        }
        
        val_4 = 与丄不丌一世东丁丙.gift;
        if(与丄不丌一世东丁丙.gift.RootInfo == null)
        {
            goto label_7;
        }
        
        label_4:
        val_4 = 与丄不丌一世东丁丙.gift.RootInfo;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_7:
        this.丞业丏七丝丒丕三丛 = 与丄不丌一世东丁丙.gift.RootInfo.Id;
        this.丏上丗丑丙丆专丌与 = 与丄不丌一世东丁丙.gift.Count;
        this.丁丅七丞不丙丄丝丛 = 与丄不丌一世东丁丙.PositionInScroll;
        this.丏丕丝丐丗丄专丒丗 = 1;
        return;
        label_8:
    }
    public bool 三丐丞丅丅丘丁三丝(DevTestGift.丁丌下上丝世三丙丑 下丌世丁专三东一丄)
    {
        var val_1;
        if((this & 1) != 0)
        {
                int val_1 = 下丌世丁专三东一丄.丏丕丝丐丗丄专丒丗;
            val_1 = 1;
            val_1 = val_1 + this.丏丕丝丐丗丄专丒丗;
            this.丏丕丝丐丗丄专丒丗 = val_1;
            return (bool)val_1;
        }
        
        val_1 = 0;
        return (bool)val_1;
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        var val_4;
        if(万且万且丑丗且丌丆 != null)
        {
                var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (DevTestGift.丁丌下上丝世三丙丑.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0;
            if((System.String.op_Equality(a:  this.丞业丏七丝丒丕三丛, b:  (System.Object.__il2cppRuntimeField_typeHierarchy + (DevTestGift.丁丌下上丝世三丙丑.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 32)) != false)
        {
                var val_3 = (this.丏上丗丑丙丆专丌与 == ((System.Object.__il2cppRuntimeField_typeHierarchy + (DevTestGift.丁丌下上丝世三丙丑.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 24)) ? 1 : 0;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public override string ToString()
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.丁丅七丞不丙丄丝丛 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.丁丅七丞不丙丄丝丛 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.丁丅七丞不丙丄丝丛;
        val_1[1] = this.七丌丌丏丗东丕且丅;
        val_1[2] = this.丞业丏七丝丒丕三丛;
        val_1[3] = this.丏上丗丑丙丆专丌与;
        val_1[4] = this.丏丕丝丐丗丄专丒丗;
        return (string)System.String.Format(format:  "\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"", args:  val_1);
    }

}
