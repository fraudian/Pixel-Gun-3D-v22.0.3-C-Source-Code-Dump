using UnityEngine;
internal class ItemViewComponent : PGBehaviour
{
    // Fields
    protected PGCompany.丗丟丄丈东丝丕丄世 不丏丞丆专不丌万丑;
    protected PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七;
    
    // Properties
    internal PGCompany.丗丟丄丈东丝丕丄世 丟丈专丙上万丟丄东 { get; }
    internal PGCompany.三东丏不丗世丅丌丄 三丞三不且丙丛上丂 { get; }
    
    // Methods
    internal PGCompany.丗丟丄丈东丝丕丄世 丂丕业丆丈丄丛且三()
    {
        return (PGCompany.丗丟丄丈东丝丕丄世)this.不丏丞丆专不丌万丑;
    }
    internal PGCompany.三东丏不丗世丅丌丄 上丁丞丁与丆丗万专()
    {
        return (PGCompany.三东丏不丗世丅丌丄)this.丕丟丈丙丟丅丟丑七;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
    {
        this.不丏丞丆专不丌万丑 = 丞丘丞丏业且丛丏丘;
        this.丕丟丈丙丟丅丟丑七 = 丞丘丞丏业且丛丏丘.丑丐丙丄丅世世丑丒();
        goto typeof(ItemViewComponent).__il2cppRuntimeField_188;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        this.不丏丞丆专不丌万丑 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
        this.丕丟丈丙丟丅丟丑七 = 丈丄不七三万丄丁不;
        goto typeof(ItemViewComponent).__il2cppRuntimeField_188;
    }
    internal virtual void 丝一丅丆三东丂丞七()
    {
    
    }
    public ItemViewComponent()
    {
    
    }

}
