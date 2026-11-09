using UnityEngine;
internal sealed class SPViewComponentItemSelector : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject shootButtonUI;
    private StoreCharacterHelper _character;
    private ItemSelectorView itemSelectorView;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnShowInfo;
    
    // Methods
    protected void OnEnable()
    {
        this.itemSelectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::业且三丙世丅丆丏世()));
    }
    protected void OnDisable()
    {
        this.itemSelectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::业且三丙世丅丆丏世()));
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539226411352] = 且丘丏丁丑与丙与丁;
        this.itemSelectorView.丞七丐三丑东且丈下();
        this.itemSelectorView.ClearAllButtons();
        this.itemSelectorView.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  this.itemSelectorView, 丛丗七丅下丞丗且丐:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  X22));
        this._character.万与七丕七丁丞下丆 = false;
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.丕丙丝一丁丏且丘丛();
    }
    internal void 丘下丟丁上丏丛且且()
    {
        this.丕丙丝一丁丏且丘丛();
        this.七丑丁丝丑三上不与();
    }
    private void 下丁下丛丙专丁丕上()
    {
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  false);
    }
    private void 业且三丙世丅丆丏世()
    {
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  true);
    }
    private void 丕丙丝一丁丏且丘丛()
    {
        var val_16;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_18;
        var val_19;
        PGCompany.三东丏不丗世丅丌丄 val_20;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_22;
        var val_23;
        PGCompany.三东丏不丗世丅丌丄 val_24;
        var val_25;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_27;
        this._character.与丕丆上丛丐下丕丂().专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  false);
        this._character.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        this._character.丞上丄丄上丞丘下丁();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
        if((this.shootButtonUI == null) || ((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  this.shootButtonUI)) == false))
        {
            goto label_31;
        }
        
        System.Collections.Generic.List<T> val_3 = PGCompany.丟一丘丄三丘丄丒丄.丕丗丏丘丛丌与丟丒<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  this.shootButtonUI);
        val_16 = null;
        val_16 = null;
        val_18 = SPViewComponentItemSelector.<>c.<>9__10_0;
        if(val_18 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_4 = null;
            val_18 = val_4;
            val_4 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentItemSelector.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentItemSelector.<>c::与丐业丄丞业专丄丒(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            SPViewComponentItemSelector.<>c.<>9__10_0 = val_18;
        }
        
        val_19 = null;
        val_20 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_3, predicate:  val_4);
        val_19 = null;
        val_22 = SPViewComponentItemSelector.<>c.<>9__10_1;
        if(val_22 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_6 = null;
            val_22 = val_6;
            val_6 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentItemSelector.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentItemSelector.<>c::七与万丞丂丙一丐丌(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            SPViewComponentItemSelector.<>c.<>9__10_1 = val_22;
        }
        
        val_24 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_3, predicate:  val_6);
        if(val_20 != null)
        {
            goto label_22;
        }
        
        val_25 = null;
        val_25 = null;
        val_27 = SPViewComponentItemSelector.<>c.<>9__10_2;
        if(val_27 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_8 = null;
            val_27 = val_8;
            val_8 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentItemSelector.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentItemSelector.<>c::丞丈丅一丘丅一丏丗(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            SPViewComponentItemSelector.<>c.<>9__10_2 = val_27;
        }
        
        val_20 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_3, predicate:  val_8);
        if(val_20 == null)
        {
            goto label_28;
        }
        
        label_22:
        val_23 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_23.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_20));
        label_28:
        if(val_24 != null)
        {
                val_24 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_24);
            this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_24);
        }
        
        label_31:
        this.下专丙丛丐与丁专丘();
        UnityEngine.Coroutine val_15 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void SPViewComponentItemSelector::下专丙丛丐与丁专丘()), 业丗七丕万万不丈丗:  1);
    }
    private void 下专丙丛丐与丁专丘()
    {
        if(this.itemSelectorView != 0)
        {
                if(this.itemSelectorView.丕丟丐丈丐丄丌三丐() != null)
        {
                this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.itemSelectorView.丕丟丐丈丐丄丌三丐());
        }
        
        }
        
        this.七丑丁丝丑三上不与();
    }
    private void 七丑丁丝丑三上不与()
    {
        var val_5;
        if(this.itemSelectorView.丕丟丐丈丐丄丌三丐() != null)
        {
                var val_4 = (this.itemSelectorView.丕丟丐丈丐丄丌三丐().不业丙丒丂丞下丆丙() == 10) ? 1 : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
    }
    public SPViewComponentItemSelector()
    {
        val_1 = new PGBehaviour();
    }

}
