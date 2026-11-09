using UnityEngine;
internal sealed class PixelPassRewardsLineView : PGBehaviour
{
    // Fields
    private EndlessScrollDynamic _pageScroll;
    private PixelPassPageDotsList dotsList;
    internal NewCenterOnChild centerOnPage;
    private UnityEngine.Transform pagesScrollHolder;
    private UnityEngine.GameObject nextPageButton;
    private UnityEngine.GameObject nextPageButtonColor;
    private UnityEngine.GameObject prevPageButton;
    private UnityEngine.GameObject prevPageButtonColor;
    private PixelPassBuyLevelView buyLevelPanel;
    private StoreCharacterHelper character;
    private System.Collections.Generic.List<ViewSettings> scaleSettings;
    private UIWidget mainViewWidget;
    private System.Collections.Generic.List<UIRect> widgetsToUpdate;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNOtPremium;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    private PGCompany.丂丙丆不一丙上丘上 丙丛下业丗专丝与丞;
    private int 丏且丝专上一丏世万;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    private PGCompany.丂丙丆不一丙上丘上 丗丄丁与专专一丝万 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private PGCompany.丂丙丆不一丙上丘上 丞丐专丐且一丝丑三()
    {
        PGCompany.丂丙丆不一丙上丘上 val_5 = this.丙丛下业丗专丝与丞;
        if(val_5 != null)
        {
                return val_5;
        }
        
        if(((PGCompany.世专三丑丘丗丂丅丞.丑七不且上丗丁一世().丝丒专丙世与三丌丞(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 26, 丏丟丑丙七东专丌丏 = false, 丒丂丌丑丟东东丒专 = false})) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        this.丙丛下业丗专丝与丞 = val_5;
        return val_5;
    }
    private void OnEnable()
    {
        PGCompany.万下丛丁丟不下丄业.东业丅万丌丌丑丗丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassRewardsLineView::一专丛丆上丝丁丞丗(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PixelPassBuyPremium.世丁万丛上丈丆丈不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丝丑丏下三丂丌丛下()));
        PixelPassBuyPremium.丙七不丗东丞丘专不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丒丁丕丄丝七丟丗丗()));
        if(this.丞丐专丐且一丝丑三() == null)
        {
                return;
        }
        
        this = ???;
        goto typeof(PGCompany.丂丙丆不一丙上丘上).__il2cppRuntimeField_198;
    }
    private void OnDisable()
    {
        PGCompany.万下丛丁丟不下丄业.丗世且上七丐丗丈东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassRewardsLineView::一专丛丆上丝丁丞丗(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PixelPassBuyPremium.丐东丄专业丁丅一丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丝丑丏下三丂丌丛下()));
        PixelPassBuyPremium.丞丕丂丏丌丈专业丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丒丁丕丄丝七丟丗丗()));
        PGCompany.丂丙丆不一丙上丘上 val_4 = this.丞丐专丐且一丝丑三();
        this.丏且丝专上一丏世万 = 99;
    }
    private void Awake()
    {
        this._pageScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void PixelPassRewardsLineView::丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this._pageScroll.add_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丒下丁业不丟丂丝一()));
        this._pageScroll.add_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PixelPassRewardsLineView::下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)));
        this.centerOnPage.丞东丘丐丈丗丄丕世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丅上丛丁丆丛丝丏丐()));
    }
    private void OnDestroy()
    {
        this._pageScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void PixelPassRewardsLineView::丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this._pageScroll.remove_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丒下丁业不丟丂丝一()));
        this._pageScroll.remove_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PixelPassRewardsLineView::下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)));
        this.centerOnPage.专丆丈业丒世不丞三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassRewardsLineView::丅上丛丁丆丛丝丏丐()));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丝业丈专业万上与丝)
    {
        var val_5;
        var val_24;
        int val_25;
        var val_26;
        var val_27;
        System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean> val_29;
        PixelPassRewardsLineView.丄丆丌丌丕丈丆丆业 val_1 = new PixelPassRewardsLineView.丄丆丌丌丕丈丆丆业();
        if(val_1 != null)
        {
                val_24 = val_1;
            .丝业丈专业万上与丝 = 丝业丈专业万上与丝;
        }
        else
        {
                val_24 = 16;
            mem[16] = 丝业丈专业万上与丝;
        }
        
        .丝且与丝丒丟万丁专 = this;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this._pageScroll.scroll.currentMomentum = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buyLevelPanel, 丏业丟一东丂东丘丛:  false);
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        List.Enumerator<T> val_3 = this.scaleSettings.GetEnumerator();
        label_13:
        if(((-395847648) & 1) == 0)
        {
            goto label_10;
        }
        
        if(val_6.m_stringLength != 丒丁三上丂丅丌丈丁.丕丌丙丘下丘与丕丟())
        {
            goto label_13;
        }
        
        this.丌丂丘丆丘下丛丞七(与不丕丆丈不丙丟丛:  val_5.丐丏七丌丕丗业且上());
        goto label_13;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_1 != null)
        {
            goto label_14;
        }
        
        goto label_21;
        label_14:
        val_26 = val_24;
        if((val_24 & 2147483648) != 0)
        {
            goto label_26;
        }
        
        label_28:
        if(val_1 == null)
        {
                val_25 = mem[16];
        }
        
        if(val_25 >= this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().Count)
        {
            goto label_26;
        }
        
        goto label_43;
        label_21:
        val_25 = mem[16];
        if((val_25 & 2147483648) == 0)
        {
            goto label_28;
        }
        
        label_26:
        mem[16] = 丈丂七世丟丞丂丗丒.丞丞丘业东丙丏七丌();
        val_27 = null;
        val_27 = null;
        val_29 = PixelPassRewardsLineView.<>c.<>9__25_1;
        if(val_29 == null)
        {
                System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean> val_12 = null;
            val_29 = val_12;
            val_12 = new System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean>(object:  PixelPassRewardsLineView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassRewardsLineView.<>c::丕丏丁丕丝丅丑丝丁(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 三丟东丕丄丄下下丑));
            PixelPassRewardsLineView.<>c.<>9__25_1 = val_29;
        }
        
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_13 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  this.丑与万三丐丒丏一专.丒东丒上世丘一丗丈(), predicate:  val_12);
        if(val_13 != null)
        {
                PGCompany.PixelPass.不万丄丛丁下业丟上 val_14 = val_13.丁三丙丟世不丟丆丛();
        }
        else
        {
                PGCompany.PixelPass.不万丄丛丁下业丟上 val_17 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.不万丄丛丁下业丟上>(source:  this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝(), predicate:  new System.Func<PGCompany.PixelPass.不万丄丛丁下业丟上, System.Boolean>(object:  val_1, method:  System.Boolean PixelPassRewardsLineView.丄丆丌丌丕丈丆丆业::丙丛上丏上丘丟丛丘(PGCompany.PixelPass.不万丄丛丁下业丟上 三丟东丕丄丄下下丑)));
        }
        
        if(val_17 != null)
        {
                val_26 = this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().IndexOf(item:  val_17);
        }
        else
        {
                val_26 = 0;
        }
        
        label_43:
        this._pageScroll.Init(上专丅业三丏丈丈丗:  this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().Count, 丏丑丝万下与丁丞业:  0);
        this.centerOnPage.Recenter();
        UnityEngine.Coroutine val_23 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void PixelPassRewardsLineView.丄丆丌丌丕丈丆丆业::丆一且世上丗上一丗()), 业丗七丕万万不丈丗:  1);
        this.dotsList.丒不丐丏且丐上丌万 = this._pageScroll;
        this.dotsList.丝一丅丆三东丂丞七();
        this.丝一丅丆三东丂丞七();
        UIPanel.RefreshAllPanels();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNOtPremium, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗()) & 1);
    }
    private void 丒下丁业不丟丂丝一()
    {
    
    }
    private void 丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        if(丌丝万上丅丒一丈丘 != null)
        {
                UnityEngine.Object val_1 = (null == null) ? (丌丝万上丅丒一丈丘) : 0;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        if(this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().Count > val_1.Index)
        {
                mem2[0] = this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().Item[val_1.Index];
        }
        else
        {
                mem2[0] = 0;
        }
        
        val_1.丝一丅丆三东丂丞七();
    }
    private void 丅上丛丁丆丛丝丏丐()
    {
        if(this.centerOnPage != null)
        {
                UnityEngine.GameObject val_1 = this.centerOnPage.一丑丕丄丐专丛丗丘();
            if(val_1 != null)
        {
                PixelPassPageView val_2 = val_1.GetComponent<PixelPassPageView>();
            if(val_2 != null)
        {
                val_2.Select(丛丁三七丅且丝丏丙:  true);
        }
        
        }
        
        }
        
        this.丝丑丏下三丂丌丛下();
    }
    private void 丒丁丕丄丝七丟丗丗()
    {
        this.丏且丝专上一丏世万 = 99;
    }
    private void 丝丑丏下三丂丌丛下()
    {
        UnityEngine.Object val_11;
        StoreCharacterHelper val_12;
        var val_13;
        System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_15;
        if(this.centerOnPage == null)
        {
            goto label_2;
        }
        
        UnityEngine.GameObject val_1 = this.centerOnPage.一丑丕丄丐专丛丗丘();
        if(val_1 == null)
        {
            goto label_2;
        }
        
        val_11 = val_1.GetComponent<PixelPassPageView>();
        goto label_3;
        label_2:
        val_11 = 0;
        label_3:
        if(val_11 == 0)
        {
                return;
        }
        
        if(123372880 == 0)
        {
                return;
        }
        
        if(123372880.丑万丆丟丈业丌一丑() == null)
        {
                return;
        }
        
        val_12 = 123372880;
        if(this.丏且丝专上一丏世万 == val_12.丂与不丕东丞与丐三())
        {
                return;
        }
        
        val_12 = 123372880.丑万丆丟丈业丌一丑();
        val_13 = null;
        val_13 = null;
        val_15 = PixelPassRewardsLineView.<>c.<>9__32_0;
        if(val_15 == null)
        {
                System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_7 = null;
            val_15 = val_7;
            val_7 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  PixelPassRewardsLineView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassRewardsLineView.<>c::与丛一丆丈世丒丑丙(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            PixelPassRewardsLineView.<>c.<>9__32_0 = val_15;
        }
        
        if((val_12.Exists(match:  val_7)) == true)
        {
                return;
        }
        
        val_12 = this.character;
        if(val_12 != null)
        {
                val_12.丌丄丘丅万丑丆丈丅(丈丄不七三万丄丁不:  123372880.丑万丆丟丈业丌一丑());
        }
        
        this.丏且丝专上一丏世万 = 123372880.丂与不丕东丞与丐三();
    }
    private void 下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)
    {
        var val_4;
        UnityEngine.GameObject val_5;
        var val_6;
        UnityEngine.GameObject val_7;
        this.dotsList.丝一丅丆三东丂丞七();
        if(丞世不丒下上上丝丑 > 0)
        {
                val_4 = 1;
            val_5 = this.prevPageButtonColor;
        }
        else
        {
                val_5 = this.prevPageButtonColor;
            val_4 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
        if((丞世不丒下上上丝丑 + 1) < this.丑与万三丐丒丏一专.世一丏万丅丕丂丟丝().Count)
        {
                val_6 = 1;
            val_7 = this.nextPageButtonColor;
        }
        else
        {
                val_7 = this.nextPageButtonColor;
            val_6 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  false);
    }
    private void 丌丂丘丆丘下丛丞七(ViewSettings 与不丕丆丈不丙丟丛)
    {
        float val_7;
        float val_8;
        if(与不丕丆丈不丙丟丛 != null)
        {
                val_7 = 与不丕丆丈不丙丟丛.pagesScrollScale;
            val_8 = 与不丕丆丈不丙丟丛.pagesScrollScale;
        }
        else
        {
                val_8 = 1.401298E-45f;
            val_7 = 1.401298E-45f;
        }
        
        this.pagesScrollHolder.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.mainViewWidget.height = 与不丕丆丈不丙丟丛.mainViewHeight;
        UnityEngine.Vector3 val_2 = this.nextPageButton.transform.localPosition;
        this.nextPageButton.transform.localPosition = new UnityEngine.Vector3() {x = (float)与不丕丆丈不丙丟丛.buttonsPosition, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_5 = this.prevPageButton.transform.localPosition;
        this.prevPageButton.transform.localPosition = new UnityEngine.Vector3() {x = (float)-与不丕丆丈不丙丟丛.buttonsPosition, y = val_5.y, z = val_5.z};
        this.mainViewWidget.ResetAndUpdateAnchors();
        专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.widgetsToUpdate);
    }
    private void 一专丛丆上丝丁丞丗(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this._pageScroll.UpdateCells();
    }
    internal void 上业与丈丞丈专丑丄(int 丐丑世东丈丑三业丘)
    {
        if(丐丑世东丈丑三业丘 < 1)
        {
                return;
        }
        
        this.buyLevelPanel.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丐丑世东丈丑三业丘:  丐丑世东丈丑三业丘);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buyLevelPanel, 丏业丟一东丂东丘丛:  true);
    }
    public void U_NextPagePressed()
    {
        this.centerOnPage.Next();
    }
    public void U_PrevPagePressed()
    {
        this.centerOnPage.Prev();
    }
    public PixelPassRewardsLineView()
    {
        this.widgetsToUpdate = new System.Collections.Generic.List<UIRect>();
        this.丏且丝专上一丏世万 = 99;
    }

}
