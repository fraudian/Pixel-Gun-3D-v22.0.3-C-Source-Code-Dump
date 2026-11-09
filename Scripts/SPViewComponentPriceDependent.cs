using UnityEngine;
internal sealed class SPViewComponentPriceDependent : SPViewComponentBase
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> priceDependent;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_4;
        mem[1152921539231490136] = 且丘丏丁丑与丙与丁;
        val_4 = this.priceDependent;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
        int val_1 = val_4.专丕世丁东丅丙不丝(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        if((val_1 & 2147483648) != 0)
        {
                return;
        }
        
        val_4 = this.priceDependent;
        if(val_1 >= val_4.Count)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceDependent.Item[val_1], 丏业丟一东丂东丘丛:  true);
    }
    private int 专丕世丁东丅丙不丝(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_12;
        var val_13;
        System.Int32[] val_14;
        var val_15;
        if(且丘丏丁丑与丙与丁 == null)
        {
                return 0;
        }
        
        var val_1 = (((PGCompany.东丑丆丗丏丐丟下丄.__il2cppRuntimeField_typeHierarchy + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 且丘丏丁丑与丙与丁 : 0;
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "event")) == true)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "coins")) == true)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "gems")) == true)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "silver")) == true)
        {
                return 0;
        }
        
        if(val_1.业东丅东丌上丗丑不() != 10015)
        {
                return 0;
        }
        
        val_12 = 0;
        goto label_15;
        label_25:
        val_13 = null;
        val_13 = null;
        val_14 = 且丘丏丁丑与丙与丁;
        int val_11 = val_14.丂丁丏一丙丛业且丌();
        val_12 = 1;
        label_15:
        val_15 = null;
        val_15 = null;
        val_14 = StoreKitEventListener.丝不东丅丅丂三且丑;
        if(val_12 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
        {
            goto label_25;
        }
        
        return 0;
    }
    public SPViewComponentPriceDependent()
    {
        val_1 = new PGBehaviour();
    }

}
