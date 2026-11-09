using UnityEngine;
internal class PromotionRewards_InfoUI : StorePromotionInfoUIAbstract
{
    // Fields
    private UILabel _titleLabel;
    private ItemListUI _itemListUi;
    private ScrollViewHelper _scrollViewHelper;
    private System.IDisposable 与丅世与丄丑丌丞东;
    
    // Methods
    protected virtual void OnEnable()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(PromotionRewards_InfoUI).__il2cppRuntimeField_1C0);
        this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "PromotionRewards_InfoUI_" + this.gameObject.name);
    }
    protected virtual void OnDisable()
    {
        if(this.与丅世与丄丑丌丞东 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.与丅世与丄丑丌丞东.Dispose();
    }
    internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, object 一丐丗丁丞丆丅丟丄, PGCompany.丞丙上世丑丕与丁丁 且丒丛与丞世丙丕丌 = 0)
    {
        this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 且丒丛与丞世丙丕丌:  3);
        this.丒丛丐丐丑丈世专丑();
    }
    protected override void 丝一丅丆三东丂丞七()
    {
        if(this.与丞丆丑东东丟丆丌() != null)
        {
                if(this._scrollViewHelper != 0)
        {
                this._scrollViewHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        }
        
            this.丒一丝与丏丝万丘且();
            this._itemListUi.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.与丞丆丑东东丟丆丌());
        }
    
    }
    private void 丒一丝与丏丝万丘且()
    {
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return;
        }
        
        PGCompany.东丑丆丗丏丐丟下丄 val_2 = this.与丞丆丑东东丟丆丌();
        if(val_2 != null)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.与丞丆丑东东丟丆丌().丞丁丑丛三不下丄丑()));
        return;
        label_3:
        if((System.String.IsNullOrEmpty(value:  this.与丞丆丑东东丟丆丌().丞丁丑丛三不下丄丑())) != false)
        {
                string val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10286"), arg0:  val_2.三万七与东丄业丐丙());
        }
        
        this = this._titleLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.与丞丆丑东东丟丆丌().丞丁丑丛三不下丄丑()));
    }
    private void 丒丛丐丐丑丈世专丑()
    {
        PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丗下一不丘丑丅业且:  this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌(), 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  "rewards", 一丑丑丝丏且丂丏丘:  "ByUser");
    }
    public PromotionRewards_InfoUI()
    {
    
    }

}
