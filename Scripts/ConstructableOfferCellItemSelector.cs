using UnityEngine;
internal sealed class ConstructableOfferCellItemSelector : SimpleBunner
{
    // Fields
    private ScrollViewHelper scrollHelper;
    private ItemSelectorView itemSelectorView;
    private CategorySelectorView categoriesSelectorView;
    private UnityEngine.GameObject selectButton;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private PGCompany.InventoryItemInfoView itemInfoView;
    private PGCompany.丕丘一丐丕上不万丁 丐丌丞东上万万丈丂;
    private System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丏丟万丅三东丐且丙;
    
    // Properties
    internal PGCompany.丕丘一丐丕上不万丁 丛丄丟专丆丛下丅丒 { get; }
    
    // Methods
    internal PGCompany.丕丘一丐丕上不万丁 三专丞万丙丈丂丟且()
    {
        return (PGCompany.丕丘一丐丕上不万丁)this.丐丌丞东上万万丈丂;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.itemSelectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferCellItemSelector::丘下丟丁上丏丛且且()));
        this.categoriesSelectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferCellItemSelector::丈丗丈丌丁丒东下业()));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.itemSelectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferCellItemSelector::丘下丟丁上丏丛且且()));
        this.categoriesSelectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferCellItemSelector::丈丗丈丌丁丒东下业()));
    }
    public void Setup(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘)
    {
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        this.gameObject.SetActive(value:  true);
        this.世业丒万丘丆专丘丐();
        this.上东与丛丞下丈专丈();
        if(this.itemSelectorView.丝丒三世丘丗丐丆专() == 0)
        {
                return;
        }
        
        this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  this.itemSelectorView.丝丒三世丘丗丐丆专().transform, 丌与丟丁万丝丞丄丏:  false);
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.世业丒万丘丆专丘丐();
        this.上东与丛丞下丈专丈();
    }
    private void 世业丒万丘丆专丘丐()
    {
        this.丏丟万丅三东丐且丙.Clear();
        this.categoriesSelectorView.丞七丐三丑东且丈下();
        this.itemSelectorView.丞七丐三丑东且丈下();
    }
    private void 上东与丛丞下丈专丈()
    {
        CategoryNames val_4;
        CategorySelectorView val_18;
        CategoryNames val_19;
        val_18 = this;
        if(this.丐丌丞东上万万丈丂 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this.丐丌丞东上万万丈丂.丕且丛下丌丁丞丌丑().GetEnumerator();
        goto label_15;
        label_16:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        PGCompany.丗丟丄丈东丝丕丄世 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_5);
        val_19 = val_7;
        if((this.丏丟万丅三东丐且丙.ContainsKey(key:  val_19)) != true)
        {
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_9 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_19 = val_7;
            this.丏丟万丅三东丐且丙.Add(key:  val_19, value:  null);
        }
        
        this.丏丟万丅三东丐且丙.Item[val_7].Add(item:  val_5);
        if(this.丐丌丞东上万万丈丂.丕丟丐丈丐丄丌三丐() != null)
        {
                if((this.丐丌丞东上万万丈丂.丕丟丐丈丐丄丌三丐().Equals(丘丛丏丘丝七世七丅:  val_5)) != false)
        {
                val_4 = 0;
        }
        
        }
        
        label_15:
        if(((-1969123312) & 1) != 0)
        {
            goto label_16;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<TSource> val_15 = System.Linq.Enumerable.ToList<CategoryNames>(source:  this.丏丟万丅三东丐且丙.Keys);
        val_15.Sort();
        if(((-1969123288) & 1) == 0)
        {
                CategoryNames val_16 = System.Linq.Enumerable.FirstOrDefault<CategoryNames>(source:  val_15);
        }
        
        val_18 = this.categoriesSelectorView;
        val_18.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  val_15, 丛丗七丅下丞丗且丐:  val_4);
    }
    private void 丘下丟丁上丏丛且且()
    {
        this.一世世丞丞且丄丄丏();
    }
    private void 丈丗丈丌丁丒东下业()
    {
        this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
        System.Nullable<CategoryNames> val_1 = this.categoriesSelectorView.上丝丞丞丌且丝丛丟();
        if(((-1968784552) & 1) != 0)
        {
                System.Nullable<CategoryNames> val_2 = this.categoriesSelectorView.上丝丞丞丌且丝丛丟();
            this.itemSelectorView.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  this.丏丟万丅三东丐且丙.Item[val_2.HasValue], 丛丗七丅下丞丗且丐:  this.丐丌丞东上万万丈丂.丕丟丐丈丐丄丌三丐());
        }
        
        this.一世世丞丞且丄丄丏();
    }
    private void 一世世丞丞且丄丄丏()
    {
        if(this.丐丌丞东上万万丈丂 != null)
        {
                if(this.itemSelectorView.丕丟丐丈丐丄丌三丐() != null)
        {
                this.selectButton.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemInfoView, 丏业丟一东丂东丘丛:  true);
            this.itemInfoView.一万丛丈丝上丟一世 = true;
            this.itemInfoView.Setup(与且专丈不万东一万:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑(丈丄不七三万丄丁不:  this.itemSelectorView.东丞丕且丁丏东与下(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}));
            return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemInfoView, 丏业丟一东丂东丘丛:  false);
        this.selectButton.SetActive(value:  false);
    }
    public void U_SelectPressed()
    {
        if(this.丐丌丞东上万万丈丂 == null)
        {
                return;
        }
        
        if(this.itemSelectorView.丕丟丐丈丐丄丌三丐() == null)
        {
                return;
        }
        
        this.丐丌丞东上万万丈丂.丆且丟丙丅丞万丄丗(丈丄不七三万丄丁不:  this.itemSelectorView.东丞丕且丁丏东与下());
        this.Hide();
    }
    public ConstructableOfferCellItemSelector()
    {
        this.丏丟万丅三东丐且丙 = new System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>();
    }

}
