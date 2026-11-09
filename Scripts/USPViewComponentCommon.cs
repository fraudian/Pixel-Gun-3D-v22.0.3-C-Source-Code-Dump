using UnityEngine;
internal sealed class USPViewComponentCommon : SPViewComponentBase
{
    // Fields
    private UILabel titleLabel;
    private UILabel descriptionLabel;
    private UILabel firstItemNameLabel;
    private TagSpecificObject tagSpecificObject;
    private UIBasicSprite iconBannerLobby;
    private UIBasicSprite iconFullBanner;
    private UIBasicSprite iconBankCell;
    private UIBasicSprite backgroundTexture;
    private GuiApplyersGroup guiApplyer;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_17;
        var val_18;
        val_17 = this;
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  137154560);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  137154560);
        float val_1 = this.descriptionLabel.alpha;
        if(this.descriptionLabel.Count >= 1)
        {
                string val_4 = PGCompany.丁丑上丞业丞丟丛上.七业丑不七丐业丟丂(丈丄不七三万丄丁不:  System.Linq.Enumerable.First<PGCompany.三东丏不丗世丅丌丄>(source:  137154560));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.firstItemNameLabel, 丕丗丘丑丛与丑业丒:  val_4);
        }
        
        if(this.tagSpecificObject != null)
        {
                this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  val_4.与不丞丑七丘丁丂丛());
        }
        
        UnityEngine.Texture val_6 = val_4.专丅丐丌且丙业丄东();
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.iconBannerLobby, 与万丆丛丒万丝丙丑:  val_6);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.iconFullBanner, 与万丆丛丒万丝丙丑:  val_6.丑下丆丝丗三丐丏丄());
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.iconBankCell, 与万丆丛丒万丝丙丑:  val_6.丐与一与丄丈丂不万());
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.backgroundTexture, 与万丆丛丒万丝丙丑:  val_6.与丙丘丟七丘丄专丟());
        if(this.guiApplyer == null)
        {
                return;
        }
        
        string val_10 = this.丑丕丘不丑万业丁丌();
        val_17 = ???;
        val_18 = ???;
        goto typeof(GuiApplyersGroup).__il2cppRuntimeField_168;
    }
    public USPViewComponentCommon()
    {
    
    }

}
