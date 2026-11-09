using UnityEngine;
internal sealed class 万业丘业丘丈业丈且 : IComparer<AbstractBankViewItem>
{
    // Fields
    private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丑且丅丒与丄丟一丙;
    
    // Methods
    public 万业丘业丘丈业丈且(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丆丗丗三丏丏丕丁丙)
    {
        this.丑且丅丒与丄丟一丙 = 丆丗丗三丏丏丕丁丙;
    }
    public int Compare(AbstractBankViewItem 三丟东丕丄丄下下丑, AbstractBankViewItem 丒丒丄丁且丄丆丂丌)
    {
        UnityEngine.Object val_130;
        var val_131;
        var val_132;
        var val_133;
        int val_136;
        var val_137;
        var val_138;
        val_130 = 丒丒丄丁且丄丆丂丌;
        if(三丟东丕丄丄下下丑 != 0)
        {
            goto label_3;
        }
        
        label_214:
        val_131 = 0;
        return (int)val_131;
        label_3:
        if(val_130 != 0)
        {
            goto label_7;
        }
        
        label_219:
        val_131 = 1;
        return (int)val_131;
        label_7:
        if(三丟东丕丄丄下下丑 == null)
        {
            goto label_26;
        }
        
        val_132 = null;
        if(val_130 == null)
        {
            goto label_214;
        }
        
        goto label_214;
        label_26:
        val_132 = null;
        if(三丟东丕丄丄下下丑.purchaseInfo == null)
        {
            goto label_214;
        }
        
        if(丒丒丄丁且丄丆丂丌.purchaseInfo == null)
        {
            goto label_219;
        }
        
        if(val_130 != 0)
        {
                val_133 = 丒丒丄丁且丄丆丂丌.purchaseInfo.丂丁丏一丙丛业且丌();
        }
        else
        {
                val_133 = 0;
        }
        
        val_136 = 三丟东丕丄丄下下丑.purchaseInfo.丂丁丏一丙丛业且丌();
        if(StoreKitEventListener.丝丝一丟丈三丂丌丁() != false)
        {
                val_137 = null;
            val_137 = null;
            var val_55 = (BalanceController.上且与丑丑下丒丁与 == true) ? 1 : 0;
        }
        else
        {
                val_138 = 0;
        }
        
        if(三丟东丕丄丄下下丑 != 0)
        {
                if(((((AbstractBankViewItem.__il2cppRuntimeField_typeHierarchy + (BankViewItem.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 三丟东丕丄丄下下丑 : 0.IsX10) != false)
        {
                val_136 = val_136 + ((val_138 != 0) ? 10000000 : -10000000);
        }
        
        }
        
        if(val_130 != 0)
        {
                if(((((AbstractBankViewItem.__il2cppRuntimeField_typeHierarchy + (BankViewItem.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_130) : 0.IsX10) != false)
        {
                val_133 = val_133 + ((val_138 != 0) ? 10000000 : -10000000);
        }
        
        }
        
        if((val_138 & 1) == 0)
        {
                return (int)val_131;
        }
        
        return (int)val_131;
    }

}
