using UnityEngine;
internal sealed class MainStoreSectionTabSelectButton : SelectableButton
{
    // Fields
    private System.Collections.Generic.List<UIBasicSprite> iconTexture;
    private System.Collections.Generic.List<UILabel> nameLable;
    private TagSpecificObject tagSpecificObject;
    private GuiApplyersGroup guiApplyersGroup;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private CurrencyMultiplierView _currencyMultiplierView;
    private MainStoreSectionTab 且丒专丁一丞丁三下;
    private PGCompany.MainStore.丐丑丂上丑丑东丒丞 三不业丏丛上上与业;
    private TagSystem.三与下丘七丘丌丏丄 七丑丙丕东万丅丟世;
    public UIBasicSprite texture;
    public UILabel labelSelection;
    
    // Properties
    public MainStoreSectionTab 七世与且丕丗丟丂丄 { get; }
    public PGCompany.MainStore.丐丑丂上丑丑东丒丞 丐丑丂上丑丑东丒丞 { get; }
    
    // Methods
    public MainStoreSectionTab get_SectionTab()
    {
        MainStoreSectionTab val_3;
        if(this.且丒专丁一丞丁三下 == 0)
        {
                var val_2 = (0 == null) ? UnityEngine.Object.__il2cppRuntimeField_cctor_finished : 0;
        }
        else
        {
                val_3 = this.且丒专丁一丞丁三下;
            return (MainStoreSectionTab);
        }
        
        this.且丒专丁一丞丁三下 = ;
        return (MainStoreSectionTab);
    }
    public PGCompany.MainStore.丐丑丂上丑丑东丒丞 get_StoreSectionTab()
    {
        return (PGCompany.MainStore.丐丑丂上丑丑东丒丞)this.三不业丏丛上上与业;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.MainStore.丐丑丂上丑丑东丒丞 东东三丂丌世丌丁不)
    {
        UnityEngine.Object val_13;
        TagSystem.三与下丘七丘丌丏丄 val_14;
        this.Reset();
        this.三不业丏丛上上与业 = 东东三丂丌世丌丁不;
        val_13 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  东东三丂丌世丌丁不.万丕丘丑丛丑七丂世());
        if(val_13 == 0)
        {
                val_13 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/chest");
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丁丗不丐丅丆丕与三:  this.iconTexture, 与万丆丛丒万丝丙丑:  val_13);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.nameLable, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.三不业丏丛上上与业.丏丕丄丄东丂丘丅与()));
        val_14 = this.三不业丏丛上上与业.与不丞丑七丘丁丂丛().Clone();
        if(val_14 != null)
        {
                val_14 = 0;
        }
        
        this.七丑丙丕东万丅丟世 = val_14;
        if(this.tagSpecificObject != null)
        {
                this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  val_14);
        }
        
        System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_11 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
        东东三丂丌世丌丁不.丙丁丒丆不七七丆丕(专丂丕丗丗东世丞下: ref  val_11);
        this._currencyMultiplierView.丈且东丑丂且万丒丅(七丆丝不丈丗业丏万:  PGCompany.MainStore.丗丝丙丏不丄七丌一.三丐丏专万上丕不丒(三丟丕世丗丂丙丅专:  val_11));
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
    }
    public override void Select(bool 丛丁三七丅且丝丏丙)
    {
        MainStoreView val_4;
        if((丛丁三七丅且丝丏丙 != false) && (this.SectionTab != null))
        {
                val_4 = val_1.mainStoreView;
            if(val_4 != null)
        {
                val_4.万丗丞丂丒世丁丟丟(丞且丌三三万七丛万:  System.Linq.Enumerable.First<PGCompany.MainStore.世专丟丕丝丝专东一>(source:  this.三不业丏丛上上与业.东不丘万丐丌世七丝), 丌与丟丁万丝丞丄丏:  true, 丛丁三七丅且丝丏丙:  true);
        }
        
        }
        
        this.Select(丛丁三七丅且丝丏丙:  丛丁三七丅且丝丏丙);
    }
    private void OnEnable()
    {
        PGCompany.MainStore.三一丒丞三专丗不丛.丂丙丌七下丛丌丞丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void MainStoreSectionTabSelectButton::丏下丐丑且丂丑丈世(PGCompany.专丟专世丅丂丁且专 万且万且丑丗且丌丆)));
    }
    private void OnDisable()
    {
        PGCompany.MainStore.三一丒丞三专丗不丛.上丅丘丕丆丞丟丅丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void MainStoreSectionTabSelectButton::丏下丐丑且丂丑丈世(PGCompany.专丟专世丅丂丁且专 万且万且丑丗且丌丆)));
    }
    private void 丏下丐丑且丂丑丈世(PGCompany.专丟专世丅丂丁且专 万且万且丑丗且丌丆)
    {
        if(this.三不业丏丛上上与业 == null)
        {
                return;
        }
        
        if(this.七丑丙丕东万丅丟世 == null)
        {
                return;
        }
        
        if((this.七丑丙丕东万丅丟世.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "new")) == false)
        {
                return;
        }
        
        TagSystem.三与下丘七丘丌丏丄 val_2 = this.三不业丏丛上上与业.与不丞丑七丘丁丂丛();
        if((this.七丑丙丕东万丅丟世.Equals(丘丛丏丘丝七世七丅:  val_2)) != false)
        {
                return;
        }
        
        this.七丑丙丕东万丅丟世 = val_2;
        if(this.tagSpecificObject != null)
        {
                this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  val_2);
        }
        
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
    }
    internal void 丁专丛丛七丄丄七一(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
    {
        PGCompany.MainStore.世专丟丕丝丝专东一 val_2 = 丞且丌三三万七丛万;
        val_2 = this.三不业丏丛上上与业.东不丘万丐丌世七丝.Contains(item:  val_2);
        this.丒丙丑丝专丛丞丒丒(丙业与丙丗丝不丈东:  val_2);
    }
    internal void 丒丙丑丝专丛丞丒丒(bool 丙业与丙丗丝不丈东)
    {
        int val_1 = (丙业与丙丗丝不丈东 != true) ? 56 : 48;
        this.texture.width = val_1;
        this.texture.height = val_1;
        this.labelSelection.fontSize = (丙业与丙丗丝不丈东 != true) ? 30 : 24;
        if(丙业与丙丗丝不丈东 != false)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.yellow;
        }
        else
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
        
        this.labelSelection.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
    }
    internal bool 丆一专丌上专丌东丁(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
    {
        if(this.三不业丏丛上上与业.东不丘万丐丌世七丝 != null)
        {
                return this.三不业丏丛上上与业.东不丘万丐丌世七丝.Contains(item:  丞且丌三三万七丛万);
        }
        
        return this.三不业丏丛上上与业.东不丘万丐丌世七丝.Contains(item:  丞且丌三三万七丛万);
    }
    public MainStoreSectionTabSelectButton()
    {
    
    }

}
