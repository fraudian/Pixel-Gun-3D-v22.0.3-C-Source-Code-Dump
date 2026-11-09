using UnityEngine;
internal sealed class SPViewComponentBonusRewards : SPViewComponentBase
{
    // Fields
    private ItemListUI itemListUI;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.东丑丒丗一丞下丙丙<T> val_10;
        PGCompany.东丑丒丗一丞下丙丙<T> val_11;
        var val_12;
        val_10 = this;
        val_11 = this.gameObject;
        val_11.SetActive(value:  false);
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
        
        val_11 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.丄与丘丑业专丞七丅>.万世丅七一专丕丞不();
        PGCompany.东丑丒丗一丞下丙丙<T> val_4 = val_11;
        PGCompany.丈丝上丐且丕万世丒.丅丌上丅不丈丈上丛(丗丈丒丐丌丙丏丆世:  (((PGCompany.东丑丆丗丏丐丟下丄.__il2cppRuntimeField_typeHierarchy + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 且丘丏丁丑与丙与丁 : 0, 东且丁丆丛丁丏丘且: ref  val_4);
        if((val_4 != 0) && (val_4.Count >= 1))
        {
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_6 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            专且丝丄丙丗丈不丞.上丁上三东丕丝丛丙(丅丆一丕丛与丁丂丛:  val_4, 丄丄丆不丂丗丛丙专: ref  val_6);
            val_11 = val_6;
            this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_6);
            UnityEngine.GameObject val_7 = this.gameObject;
            val_12 = 1;
        }
        else
        {
                val_12 = 0;
        }
        
        this.gameObject.SetActive(value:  false);
        PGCompany.东丑丒丗一丞下丙丙<T> val_9 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.丄与丘丑业专丞七丅>.万世丅七一专丕丞不();
        val_10 = val_4;
    }
    public SPViewComponentBonusRewards()
    {
        val_1 = new PGBehaviour();
    }

}
