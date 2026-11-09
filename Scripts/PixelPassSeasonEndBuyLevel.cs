using UnityEngine;
internal sealed class PixelPassSeasonEndBuyLevel : SimpleBunner
{
    // Fields
    private PixelPassSeasonEnd seasonEnd;
    private UILabel wantedLevelLabel;
    private UILabel buyLevelsLabel;
    private UnityEngine.GameObject addLevelButton;
    private UnityEngine.GameObject removeLevelButton;
    private UnityEngine.GameObject buyButton;
    private UIScrollView scroll;
    private ItemSelectorView itemSelector;
    private PGCompany.InventoryItemView priceView;
    private UnityEngine.GameObject characterHolder;
    private StoreCharacterHelper character;
    private int 丞丟丅丏与七丅三丆;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private void OnEnable()
    {
        this.itemSelector.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassSeasonEndBuyLevel::七与丌丄下丅丁丗下()));
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassSeasonEndBuyLevel::业丄上丅丐丒下丈丞()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassSeasonEndBuyLevel::下一丏丌一丌上丝世()));
    }
    private void OnDisable()
    {
        this.itemSelector.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassSeasonEndBuyLevel::七与丌丄下丅丁丗下()));
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassSeasonEndBuyLevel::业丄上丅丐丒下丈丞()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassSeasonEndBuyLevel::下一丏丌一丌上丝世()));
    }
    public override void Hide()
    {
        this.Hide();
        this.seasonEnd.HideBuyLevelUI();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.丞丟丅丏与七丅三丆 = 0;
        if(丈丂七世丟丞丂丗丒.丞丞丘业东丙丏七丌() < this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
                this.丞丟丅丏与七丅三丆 = 1;
        }
        
        this.character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        int val_10 = this.丞丟丅丏与七丅三丆;
        val_10 = val_10 + this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.wantedLevelLabel, 丕丗丘丑丛与丑业丒:  val_10);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.buyLevelsLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12261"), arg0:  this.丞丟丅丏与七丅三丆));
        if(this.丞丟丅丏与七丅三丆 < 1)
        {
            goto label_6;
        }
        
        if(this.buyButton != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        this.buyButton.SetActive(value:  (this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() < this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒()) ? 1 : 0);
        this.scroll.ResetPosition();
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7 = PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.与丒丕与下下丛丑丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丗万丒丗丏丒三且丌:  this.丞丟丅丏与七丅三丆);
        val_7.Reverse();
        专且丝丄丙丗丈不丞.丂丝三丏丞七万七东(丈丄不七三万丄丁不:  val_7);
        this.itemSelector.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  val_7, 丛丗七丅下丞丗且丐:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_7));
        this.priceView.Setup(丈丄不七三万丄丁不:  PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.与七丞万东丘丗下丒(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丌与丅丌丒丅丄丆丁:  this.丞丟丅丏与七丅三丆));
        return;
        label_6:
        if(this.buyButton != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    private void 七与丌丄下丅丁丗下()
    {
        this.character.丌丄丘丅万丑丆丈丅(丈丄不七三万丄丁不:  this.itemSelector.东丞丕且丁丏东与下());
    }
    private void 业丄上丅丐丒下丈丞()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.characterHolder, 丏业丟一东丂东丘丛:  false);
    }
    private void 下一丏丌一丌上丝世()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.characterHolder, 丏业丟一东丂东丘丛:  true);
    }
    public void U_AddLevel()
    {
        if((this.丞丟丅丏与七丅三丆 + this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌()) >= this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
                return;
        }
        
        int val_4 = this.丞丟丅丏与七丅三丆;
        val_4 = val_4 + 1;
        this.丞丟丅丏与七丅三丆 = val_4;
        this.丝一丅丆三东丂丞七();
    }
    public void U_RemoveLevel()
    {
        if((this.丞丟丅丏与七丅三丆 + this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌()) <= this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌())
        {
                return;
        }
        
        int val_4 = this.丞丟丅丏与七丅三丆;
        val_4 = val_4 - 1;
        this.丞丟丅丏与七丅三丆 = val_4;
        this.丝一丅丆三东丂丞七();
    }
    public void U_BuyLevel()
    {
        if((PGCompany.PixelPass.丘丏丅丆丑下业丙七.不丒万丅丝业万业丏(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丐丑世东丈丑三业丘:  this.丞丟丅丏与七丅三丆)) == false)
        {
                return;
        }
        
        this.丞丟丅丏与七丅三丆 = UnityEngine.Mathf.Min(a:  this.丞丟丅丏与七丅三丆, b:  this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒() - this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌());
        this.丝一丅丆三东丂丞七();
    }
    public PixelPassSeasonEndBuyLevel()
    {
    
    }

}
