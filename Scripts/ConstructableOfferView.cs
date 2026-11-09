using UnityEngine;
internal sealed class ConstructableOfferView : PGBehaviour
{
    // Fields
    internal static System.Action<PGCompany.世丞上丏丗不丛上东> 丁与下万丄丑丐丗丐;
    private System.Action 丛丄业丘不丆丄三丞;
    private SPViewComponentBase pusrchaseViewComponent;
    private UILabel titleLabel;
    private UILabel saleLabel;
    private UnityEngine.GameObject saleHolder;
    private MiniPoolMonoBehaviour cellViewPool;
    private WidgetLayout cellsLayout;
    private UIGrid cellsGrid;
    private StoreCharacterHelper _character;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> oldPrice;
    private System.Collections.Generic.List<BuyButtonUI> buyButtonUI;
    private PGCompany.TimerUI timerUI;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfCanBuy;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfCantBuy;
    private ConstructableOfferCellItemSelector cellItemSelector;
    private SimpleBunner infoBanner;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableInInfoBanner;
    private System.Collections.Generic.List<WidgetLayout> layoutToUpdate;
    private System.Collections.Generic.List<ConstructableOfferCellView> 丙七丂丂丏丘七丝丘;
    private PGCompany.世丞上丏丗不丛上东 丄丌上丞一丈且丌丕;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    internal void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丄业丘不丆丄三丞 != 1152921537000422840);
    
    }
    internal void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丄业丘不丆丄三丞 != 1152921537000559416);
    
    }
    private void OnEnable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_8;
        if(((System.Delegate.Combine(a:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, b:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void ConstructableOfferView::丘下丟丁上丏丛且且(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_8 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_8;
        this.cellItemSelector.add_onShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.cellItemSelector.add_onHide(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.infoBanner.add_onEnable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.infoBanner.add_onDisable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.东丑丕与丙丏丕万专();
    }
    private void OnDisable()
    {
        bool val_9;
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_10;
        val_9 = static_value_082C6C71;
        val_9 = true;
        if(((System.Delegate.Remove(source:  mem[-1152921504606336605], value:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void ConstructableOfferView::丘下丟丁上丏丛且且(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_10 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_10;
        this.cellItemSelector.remove_onShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.cellItemSelector.remove_onHide(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.infoBanner.remove_onEnable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        this.infoBanner.remove_onDisable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::东丑丕与丙丏丕万专()));
        if(this.东三世丝丒三一丈丛 == null)
        {
                return;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.世丞上丏丗不丛上东 丏不万丆丟丏七丄丕, bool 七丁丕三丄七东三三, System.Action 下丐丟下业丑万万丒)
    {
        System.IDisposable val_7;
        this.丄丌上丞一丈且丌丕 = 丏不万丆丟丏七丄丕;
        this.丛丄业丘不丆丄三丞 = 下丐丟下业丑万万丒;
        if(七丁丕三丄七东三三 != false)
        {
                System.IDisposable val_6 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ConstructableOfferView::U_Hide()), 与且专丈不万东一万:  "ConstructableOfferView_" + this.gameObject.name);
        }
        else
        {
                val_7 = 0;
        }
        
        this.东三世丝丒三一丈丛 = val_7;
        this.cellItemSelector.Hide();
        this.丝一丅丆三东丂丞七();
        this.丝丑丏下三丂丌丛下();
        if(ConstructableOfferView.丁与下万丄丑丐丗丐 == null)
        {
                return;
        }
        
        ConstructableOfferView.丁与下万丄丑丐丗丐.Invoke(obj:  丏不万丆丟丏七丄丕);
    }
    private void 丝丑丏下三丂丌丛下()
    {
        var val_10;
        System.Collections.Generic.List<PGCompany.丕丘一丐丕上不万丁> val_1 = this.丄丌上丞一丈且丌丕.丂丘业丐丕三上七且();
        val_10 = null;
        val_10 = null;
        if((ConstructableOfferView.<>c.<>9__27_0) == null)
        {
            goto label_4;
        }
        
        label_20:
        if((val_1.Exists(match:  ConstructableOfferView.<>c.<>9__27_0)) != true)
        {
                this._character.丞上丄丄上丞丘下丁();
        }
        
        this._character.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_5 = this.丄丌上丞一丈且丌丕.丂丘业丐丕三上七且().GetEnumerator();
        label_16:
        if(((-1965271464) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_6 = 0.丐丏七丌丕丗业且上();
        if(val_6.专丘丈丗丕与丙丕丆() == false)
        {
            goto label_16;
        }
        
        val_3.Add(item:  val_6.丕丟丐丈丐丄丌三丐());
        goto label_16;
        label_4:
        ConstructableOfferView.<>c.<>9__27_0 = new System.Predicate<PGCompany.丕丘一丐丕上不万丁>(object:  ConstructableOfferView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConstructableOfferView.<>c::与丐丏上丄丒丛三丆(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘));
        if(val_1 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this._character.丂丄丗丝丌丌丝世丘(丈丄不七三万丄丁不:  val_3, 万下万丘丌丄丝丐丆:  true, 丙万丘丗丅万丐一世:  true);
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
    }
    internal void 丝一丅丆三东丂丞七()
    {
        this.世业丒万丘丆专丘丐();
        this.上东与丛丞下丈专丈();
        this.丝丂丕东专世丅丝丁();
        PGCompany.丞丞丒下三三丘丈丗 val_1 = PGCompany.七丂专七丆丗不丌专.丞专丛丏丘丁丕丕丘(丙业丞丑七丗下丟丌:  this.丄丌上丞一丈且丌丕);
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.layoutToUpdate);
        UnityEngine.Coroutine val_3 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::上三且丗丅不三丌丌()), 业丗七丕万万不丈丗:  1);
    }
    private void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.cellViewPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丙七丂丂丏丘七丝丘.GetEnumerator();
        label_7:
        if(((-1964910248) & 1) == 0)
        {
            goto label_5;
        }
        
        this.cellViewPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丙七丂丂丏丘七丝丘.Clear();
        if(this.cellsLayout == null)
        {
                return;
        }
        
        this.cellsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        if(this.cellsLayout == null)
        {
                return;
        }
        
        this.cellsLayout.Reposition();
    }
    private void 上东与丛丞下丈专丈()
    {
        var val_10;
        PGCompany.世丞上丏丗不丛上东 val_22;
        var val_23;
        UIGrid val_24;
        System.Collections.Generic.List<UnityEngine.GameObject> val_25;
        var val_26;
        val_22 = this.丄丌上丞一丈且丌丕;
        if(val_22 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  PGCompany.七丂专七丆丗不丌专.丞专丛丏丘丁丕丕丘(丙业丞丑七丗下丟丌:  val_22));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.saleLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2555"), arg0:  this.丄丌上丞一丈且丌丕.丆丞上丛丂一业丟丕()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.saleHolder, 丏业丟一东丂东丘丛:  (this.丄丌上丞一丈且丌丕.丆丞上丛丂一业丟丕() > 0) ? 1 : 0);
        List.Enumerator<T> val_8 = this.丄丌上丞一丈且丌丕.丂丘业丐丕三上七且().GetEnumerator();
        label_22:
        if(((-1964622064) & 1) == 0)
        {
            goto label_13;
        }
        
        ConstructableOfferCellView val_12 = this.cellViewPool.Get<ConstructableOfferCellView>();
        val_12.丗丗专与业万上丛丆 = this;
        val_12.丐丌丞东上万万丈丂 = val_10.丐丏七丌丕丗业且上();
        val_12.丝一丅丆三东丂丞七();
        if(this.cellsLayout != null)
        {
                (this.cellsLayout == 0) ? 0 : this.cellsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_12);
        }
        
        this.丙七丂丂丏丘七丝丘.Add(item:  val_12);
        val_12.transform.SetAsLastSibling();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_12, 丏业丟一东丂东丘丛:  true);
        goto label_22;
        label_13:
        val_23 = public System.Void List.Enumerator<PGCompany.丕丘一丐丕上不万丁>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.cellsLayout != null)
        {
                val_23 = 0;
            this.cellsLayout.Reposition();
        }
        
        if(this.cellsGrid != null)
        {
                val_24 = this.cellsGrid;
        }
        else
        {
                val_24 = 0;
        }
        
        if(val_24 != 0)
        {
                this.cellsGrid.repositionNow = true;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<PGCompany.InventoryItemView>(不丗上三丛丒上东丑:  this.oldPrice, 丏业丟一东丂东丘丛:  (this.丄丌上丞一丈且丌丕.丑专不且丒丄丏丝丞() != 0) ? 1 : 0);
        this.oldPrice.ForEach(action:  new System.Action<PGCompany.InventoryItemView>(object:  this, method:  System.Void ConstructableOfferView::三丛丘一万丛丅丞一(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)));
        System.Action<BuyButtonUI> val_19 = null;
        val_22 = val_19;
        val_19 = new System.Action<BuyButtonUI>(object:  this, method:  System.Void ConstructableOfferView::丈丂丈丙上下丒丅丁(BuyButtonUI 三丟东丕丄丄下下丑));
        this.buyButtonUI.ForEach(action:  val_19);
        if(this.丄丌上丞一丈且丌丕.与丈丟东丆丅丅丝丁() != false)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfCanBuy, 丏业丟一东丂东丘丛:  true);
            val_25 = this.enableIfCantBuy;
            val_26 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfCanBuy, 丏业丟一东丂东丘丛:  false);
            val_25 = this.enableIfCantBuy;
            val_26 = 1;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丁丆专丕万丈丐丛上(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘)
    {
        if(丌丝万上丅丒一丈丘 == null)
        {
                return;
        }
        
        this.cellItemSelector.Setup(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘);
        this.cellItemSelector.Show();
    }
    private void 丘下丟丁上丏丛且且(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        if((this.丄丌上丞一丈且丌丕.丂丘业丐丕三上七且().Contains(item:  丌丝万上丅丒一丈丘)) == false)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
        if(丌丝万上丅丒一丈丘.丕丟丐丈丐丄丌三丐().不业丙丒丂丞下丆丙() == 10)
        {
                this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丌丝万上丅丒一丈丘.丕丟丐丈丐丄丌三丐()));
            return;
        }
        
        this.丝丑丏下三丂丌丛下();
    }
    private void 丝丂丕东专世丅丝丁()
    {
        object val_8;
        PGCompany.世丞上丏丗不丛上东 val_9;
        val_8 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUI, 丏业丟一东丂东丘丛:  false);
        int val_8 = this.丄丌上丞一丈且丌丕.上丟丄与丁三丌丘专();
        val_9 = this.丄丌上丞一丈且丌丕;
        val_8 = val_8 - PixelTime.丙三丝下丛丈丌丟下();
        if((val_8 >= 1) && (val_9.上丟丄与丁三丌丘专() >= 1))
        {
                this.timerUI.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_10624");
            this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_8, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUI, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        long val_5 = PixelTime.丙三丝下丛丈丌丟下();
        int val_6 = this.丄丌上丞一丈且丌丕.专丞丅东且三丆世与(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int32>() {HasValue = false});
        if(val_6 < 1)
        {
                return;
        }
        
        this.timerUI.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_9797");
        val_9 = this.timerUI;
        val_9.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_6, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ConstructableOfferView::丝丂丕东专世丅丝丁()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        val_8 = this.timerUI;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
    }
    public void U_Purchase()
    {
        this.丛丁丏丏丄下丈下下();
    }
    private void 丛丁丏丏丄下丈下下()
    {
        PGCompany.世丞上丏丗不丛上东 val_12;
        var val_13;
        if(this.丄丌上丞一丈且丌丕 == null)
        {
                return;
        }
        
        PGCompany.丞丞丒下三三丘丈丗 val_1 = PGCompany.七丂专七丆丗不丌专.丞专丛丏丘丁丕丕丘(丙业丞丑七丗下丟丌:  this.丄丌上丞一丈且丌丕);
        if(val_1 == null)
        {
                return;
        }
        
        if(val_1.且丏三丞丝丟丘丅丕() != false)
        {
                val_1.丈丙且一万丟丕万下();
            return;
        }
        
        if((val_1 != null) && (val_1.业东丅东丌上丗丑不() != 10015))
        {
                if(val_1.业东丅东丌上丗丑不() != 11015)
        {
                val_12 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_12.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_1, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
                return;
        }
        
        }
        
        }
        
        val_12 = this.丄丌上丞一丈且丌丕;
        if(val_12.世世丏丝丞不世丕丑() != false)
        {
                val_1.丏丝丘七丕与世丅丆();
            return;
        }
        
        val_13 = null;
        val_13 = null;
        val_12 = ConstructableOfferView.<>c.<>9__35_0;
        if(val_12 == null)
        {
                System.Func<PGCompany.丕丘一丐丕上不万丁, System.Boolean> val_9 = null;
            val_12 = val_9;
            val_9 = new System.Func<PGCompany.丕丘一丐丕上不万丁, System.Boolean>(object:  ConstructableOfferView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConstructableOfferView.<>c::且业丌不丛丕与丝丑(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘));
            ConstructableOfferView.<>c.<>9__35_0 = val_12;
        }
        
        this.丁丆专丕万丈丐丛上(丌丝万上丅丒一丈丘:  System.Linq.Enumerable.FirstOrDefault<PGCompany.丕丘一丐丕上不万丁>(source:  this.丄丌上丞一丈且丌丕.丂丘业丐丕三上七且(), predicate:  val_9));
    }
    public void U_Hide()
    {
        if(this.丛丄业丘不丆丄三丞 == null)
        {
                return;
        }
        
        this.丛丄业丘不丆丄三丞.Invoke();
    }
    private void 东丑丕与丙丏丕万专()
    {
        bool val_5;
        if(this.infoBanner.IsActive != false)
        {
                val_5 = 0;
        }
        else
        {
                val_5 = this.cellItemSelector.gameObject.activeSelf ^ 1;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableInInfoBanner, 丏业丟一东丂东丘丛:  val_5);
    }
    public ConstructableOfferView()
    {
        this.丙七丂丂丏丘七丝丘 = new System.Collections.Generic.List<ConstructableOfferCellView>();
    }
    private void 上三且丗丅不三丌丌()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.layoutToUpdate);
    }
    private void 三丛丘一万丛丅丞一(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.Setup(丈丄不七三万丄丁不:  this.丄丌上丞一丈且丌丕.丑专不且丒丄丏丝丞());
    }
    private void 丈丂丈丙上下丒丅丁(BuyButtonUI 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.Setup(丒世丘丘上丆丝东丞:  this.丄丌上丞一丈且丌丕.一万丐丕丁丘丏丗丒());
    }

}
