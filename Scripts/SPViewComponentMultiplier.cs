using UnityEngine;
internal sealed class SPViewComponentMultiplier : SPViewComponentBase
{
    // Fields
    private UILabel _miltiplierLabel;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.gameObject.SetActive(value:  false);
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "multiplier")) == false)
        {
                return;
        }
        
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
        
        var val_4 = (((PGCompany.东丑丆丗丏丐丟下丄.__il2cppRuntimeField_typeHierarchy + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 且丘丏丁丑与丙与丁 : 0;
    }
    public SPViewComponentMultiplier()
    {
        val_1 = new PGBehaviour();
    }

}
