using UnityEngine;
internal class StorePromotionViewBase : PromotionViewAbstract
{
    // Fields
    private readonly System.Collections.Generic.List<丁丈丏万且丛丆丁七> 丞丒丄一丞七丒且丛;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        goto typeof(StorePromotionViewBase).__il2cppRuntimeField_198;
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_6;
        var val_7;
        val_6 = this;
        this.丘丁东丟丒丙且丄七();
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return (bool)val_7;
        }
        
        List.Enumerator<T> val_2 = this.丞丒丄一丞七丒且丛.GetEnumerator();
        label_9:
        if((342686808 & 1) == 0)
        {
            goto label_3;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        0.丐丏七丌丕丗业且上().Setup(且丘丏丁丑与丙与丁:  this.与丞丆丑东东丟丆丌());
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_7 = 1;
        return (bool)val_7;
    }
    private void 丘丁东丟丒丙且丄七()
    {
        if(this.丞丒丄一丞七丒且丛.Count > 0)
        {
                return;
        }
        
        this.丞丒丄一丞七丒且丛.AddRange(collection:  this.GetComponentsInChildren<SPViewComponentBase>(includeInactive:  true));
    }
    internal override void 丐丌丘不上且东业丘()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    internal override void 丌丆丌且丘丝丝丑丄()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    internal override void 世世丑丞丒丟业丁与()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    public StorePromotionViewBase()
    {
        this.丞丒丄一丞七丒且丛 = new System.Collections.Generic.List<丁丈丏万且丛丆丁七>();
    }

}
