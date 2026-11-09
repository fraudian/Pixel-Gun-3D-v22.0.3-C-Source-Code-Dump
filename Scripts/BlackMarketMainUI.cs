using UnityEngine;
public class BlackMarketMainUI : BannerWindowWithBack, 丑且丆万丏丝丘丙丟
{
    // Fields
    private UIRect mainPanel;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private ScrollViewHelper scrollViewHelper;
    private WidgetLayout topWidgetLayout;
    private WidgetLayout bottomWidgetLayout;
    private BlackMarketPromotionView defaultCellExample;
    private BlackMarketPromotionView finalCellExample;
    private BlackMarketEmptyCell emptyCellExample;
    private BlackMarketPromotionView stikedFinalCell;
    private SimpleBunner refreshBunner;
    private PGCompany.TimerUI totalRefreshTimer;
    private ClanBuildingProgress buildingProgress;
    private System.Collections.Generic.List<BlackMarketRefreshButton> refreshButtons;
    private System.Collections.Generic.List<BlackMarketPromotionView> 下丁丏东三丂丘丙三;
    private System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> 丑与丗丄丐丕丈丅万;
    private BlackMarketPromotionView 与业世丂丛且丘七世;
    private Rilisoft.ItemViewer 丆丁一丅丗上业丅东;
    internal static readonly System.Collections.Generic.List<BankView.BankViewTab> 丑丝专丐与与业丏丗;
    
    // Methods
    public override void Show()
    {
        this.Show();
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        this.scrollViewHelper.scrollView.ResetPosition();
        this.ShowBlackMarketUI();
    }
    public override void Back()
    {
        this.Back();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    protected override void OnEnable()
    {
        this.不与丞下业丑丒丙万();
        this.下丌业业丐丘丐丘三();
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.不与丞下业丑丒丙万();
        this.OnDisable();
    }
    protected override void OnDestroy()
    {
        this.不与丞下业丑丒丙万();
        this.OnDestroy();
    }
    private void 下丌业业丐丘丐丘三()
    {
        PGCompany.BM.丁丕下世丁丌万三丆.不上丄与上丄丄丏七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::丕丒丗与丁丞一丝丟()));
        BlackMarketPromotionView.与且丑一丈丘且丙丄(丙业与丙丗丝不丈东:  new System.Action<BlackMarketPromotionView>(object:  this, method:  System.Void BlackMarketMainUI::丕丁三万丆丕东丂且(BlackMarketPromotionView 丁世丛业丟下丕三丟)));
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BlackMarketMainUI::下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)));
        this.refreshBunner.add_onEnable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::丈丈上世丙万且且上()));
        this.refreshBunner.add_onDisable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::丈丈上世丙万且且上()));
        PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void BlackMarketMainUI::丈丝下丛专三丐丛且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 一丐丗丁丞丆丅丟丄)));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::业丕丐丝与丄丏丆丂()));
    }
    private void 不与丞下业丑丒丙万()
    {
        PGCompany.BM.丁丕下世丁丌万三丆.丈下丑三下丑丝下专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::丕丒丗与丁丞一丝丟()));
        BlackMarketPromotionView.七丏丙世丝丒丈七丄(丙业与丙丗丝不丈东:  new System.Action<BlackMarketPromotionView>(object:  this, method:  System.Void BlackMarketMainUI::丕丁三万丆丕东丂且(BlackMarketPromotionView 丁世丛业丟下丕三丟)));
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BlackMarketMainUI::下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)));
        this.refreshBunner.remove_onEnable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::丈丈上世丙万且且上()));
        this.refreshBunner.remove_onDisable(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::丈丈上世丙万且且上()));
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void BlackMarketMainUI::丈丝下丛专三丐丛且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 一丐丗丁丞丆丅丟丄)));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::业丕丐丝与丄丏丆丂()));
    }
    private void 下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)
    {
        if(丛丑丅丞丝丈丘丆三 != 102015)
        {
                return;
        }
        
        this.ShowBlackMarketUI();
    }
    private void 业丕丐丝与丄丏丆丂()
    {
        null = null;
        MainMenuController.丞丟丂三丝丆丌丌丗 = true;
        丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
    }
    private void 丕丁三万丆丕东丂且(BlackMarketPromotionView 丁世丛业丟下丕三丟)
    {
        PGCompany.BM.世丘丈丑丘万丆丞丈 val_13;
        if(丁世丛业丟下丕三丟 == null)
        {
                return;
        }
        
        if((丁世丛业丟下丕三丟.<丆丏业丙丒且万丈丂>k__BackingField) == null)
        {
                return;
        }
        
        if((丁世丛业丟下丕三丟.<丆丏业丙丒且万丈丂>k__BackingField.丄丏丒丞世东丗上专()) == null)
        {
                return;
        }
        
        if((丁世丛业丟下丕三丟.<丆丏业丙丒且万丈丂>k__BackingField.与专丂丒丐丑不世一()) != false)
        {
                this.万丞丌七丈丄丙东万(丄专万万丝丐三丆丄:  "EventStore");
            return;
        }
        
        if((丁世丛业丟下丕三丟.<丆丏业丙丒且万丈丂>k__BackingField.专丒丟丝与丏业专一()) != true)
        {
                val_13 = 丁世丛业丟下丕三丟.<丆丏业丙丒且万丈丂>k__BackingField;
            if(val_13.丗丙丐下丏丝丁丘三() == false)
        {
                return;
        }
        
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_6 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  丁世丛业丟下丕三丟.<丆丏业丙丒且万丈丂>k__BackingField.丄丏丒丞世东丗上专());
        ItemViewer.丕丈丏丑丌丂且万不 val_7 = null;
        val_13 = val_7;
        val_7 = new ItemViewer.丕丈丏丑丌丂且万不();
        .丅万丗上三不丙丆丒 = WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  val_6);
        Rilisoft.ItemViewer val_10 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 下丅丙一丂丗丅丝七:  val_6, 丗丟上上丒丐丗丞丙:  val_7, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 丒不业且丄丅世世下:  false);
        this.丆丁一丅丗上业丅东 = val_10;
        if(val_10 == 0)
        {
                return;
        }
        
        this.丆丁一丅丗上业丅东.add_OnHide(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BlackMarketMainUI::东东丙一丁丈丈三丛()));
    }
    public void ShowBlackMarketUI()
    {
        this.buildingProgress.丈且东丑丂且万丒丅(丕万丌世丆下丈丟与:  PGCompany.七丄三丝丐业丄丅丝.世丟丈丌丝东丂丆丁());
        this.丄上七丂丄丗不丝七();
        this.业丌丘一丐丕专丆丞();
        this.丝一丅丆三东丂丞七();
    }
    private void 丄上七丂丄丗不丝七()
    {
        List.Enumerator<T> val_1 = this.rectsToUpdate.GetEnumerator();
        label_7:
        if((1749863816 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.ResetAndUpdateAnchors();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> 丒丞丒丑七丝丘七丑()
    {
        System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> val_2 = PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().丗不丞一且丟丈丈丗();
        System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> val_3 = new System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈>();
        if(val_2 == null)
        {
                return val_3;
        }
        
        if(val_2.Count == 0)
        {
                return val_3;
        }
        
        PGCompany.BM.世丘丈丑丘万丆丞丈 val_5 = val_2.Item[0];
        if(val_5 == null)
        {
                return val_3;
        }
        
        do
        {
            val_3.Add(item:  val_5);
            val_3.Add(item:  val_5.丅丅专丞丆丞且丂专());
        }
        while(val_5.丐丅丕丈丐与丂专丟() != null);
        
        return val_3;
    }
    internal System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> 丁专丅丘丕丏丟万丝()
    {
        BlackMarketMainUI.三丕业丁丗东丂七丝 val_14;
        var val_15;
        var val_17;
        System.Func<PGCompany.BM.世丘丈丑丘万丆丞丈, System.Boolean> val_19;
        var val_20;
        var val_21;
        BlackMarketMainUI.三丕业丁丗东丂七丝 val_1 = null;
        val_14 = val_1;
        val_1 = new BlackMarketMainUI.三丕业丁丗东丂七丝();
        System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> val_2 = val_1.丒丞丒丑七丝丘七丑();
        val_15 = null;
        val_15 = null;
        if((BlackMarketMainUI.<>c.<>9__30_0) == null)
        {
            goto label_3;
        }
        
        label_18:
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<PGCompany.BM.世丘丈丑丘万丆丞丈>(source:  val_2.FindAll(match:  BlackMarketMainUI.<>c.<>9__30_0));
        val_17 = null;
        val_17 = null;
        val_19 = BlackMarketMainUI.<>c.<>9__30_1;
        if(val_19 == null)
        {
                System.Func<PGCompany.BM.世丘丈丑丘万丆丞丈, System.Boolean> val_5 = null;
            val_19 = val_5;
            val_5 = new System.Func<PGCompany.BM.世丘丈丑丘万丆丞丈, System.Boolean>(object:  BlackMarketMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BlackMarketMainUI.<>c::丙丛丗且专上专丑一(PGCompany.BM.世丘丈丑丘万丆丞丈 七丏丄丅丌业与且丙));
            BlackMarketMainUI.<>c.<>9__30_1 = val_19;
        }
        
        .丑丞丅丑丘丝东专丟 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BM.世丘丈丑丘万丆丞丈>(source:  val_4, predicate:  val_5);
        System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> val_7 = null;
        val_20 = val_7;
        val_7 = new System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈>();
        if((BlackMarketMainUI.三丕业丁丗东丂七丝)[1152921536421873840].丑丞丅丑丘丝东专丟 == null)
        {
            goto label_12;
        }
        
        BlackMarketMainUI.丄丗不丝不丄丅丄专 val_8 = new BlackMarketMainUI.丄丗不丝不丄丅丄专();
        if(val_8 == null)
        {
            goto label_13;
        }
        
        val_21 = val_8;
        .东丟且丗且三专丙丁 = val_14;
        goto label_14;
        label_3:
        BlackMarketMainUI.<>c.<>9__30_0 = new System.Predicate<PGCompany.BM.世丘丈丑丘万丆丞丈>(object:  BlackMarketMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BlackMarketMainUI.<>c::丘丛七业丗丑丟专丏(PGCompany.BM.世丘丈丑丘万丆丞丈 三丟东丕丄丄下下丑));
        if(val_2 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_12:
        val_20 = val_4;
        return (System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈>)val_20;
        label_13:
        val_21 = 24;
        mem[24] = val_14;
        label_14:
        .丈丘丝一丗下丈丐不 = .丑丞丅丑丘丝东专丟.丅丝丕不丛丟丕丐丆();
        val_14 = System.Linq.Enumerable.ToList<PGCompany.BM.世丘丈丑丘万丆丞丈>(source:  val_4).FindAll(match:  new System.Predicate<PGCompany.BM.世丘丈丑丘万丆丞丈>(object:  val_8, method:  System.Boolean BlackMarketMainUI.丄丗不丝不丄丅丄专::三丄丅丅丏丌丝丘丏(PGCompany.BM.世丘丈丑丘万丆丞丈 三丟东丕丄丄下下丑)));
        val_7.AddRange(collection:  val_14);
        return (System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈>)val_20;
    }
    private void 业丌丘一丐丕专丆丞()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.defaultCellExample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.finalCellExample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.emptyCellExample, 丏业丟一东丂东丘丛:  false);
        this.丝丛丙不丅下上上丆();
        System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈> val_1 = this.丁专丅丘丕丏丟万丝();
        this.丑与丗丄丐丕丈丅万 = val_1;
        if(val_1 == null)
        {
                return;
        }
        
        if(val_1.Count == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = this.丑与丗丄丐丕丈丅万.GetEnumerator();
        label_8:
        if((1750423032 & 1) == 0)
        {
            goto label_6;
        }
        
        this.下丁丏东三丂丘丙三.Add(item:  this.七丂丅丗与东丌一且(且丘丏丁丑与丙与丁:  0.丐丏七丌丕丗业且上()));
        goto label_8;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.topWidgetLayout.Reposition();
        this = this.bottomWidgetLayout;
        this.Reposition();
    }
    private BlackMarketPromotionView 七丂丅丗与东丌一且(PGCompany.BM.世丘丈丑丘万丆丞丈 且丘丏丁丑与丙与丁)
    {
        WidgetLayout val_6;
        UnityEngine.MonoBehaviour val_7;
        var val_9;
        UnityEngine.MonoBehaviour val_10;
        val_6 = this;
        PGCompany.BM.世业丈丑七丁东上东 val_1 = 且丘丏丁丑与丙与丁.下专万丌丞与与一丈();
        if(val_1 == 3)
        {
            goto label_2;
        }
        
        if(val_1 == 2)
        {
            goto label_3;
        }
        
        val_7 = 0;
        if(val_1 != 1)
        {
                return (BlackMarketPromotionView)val_7;
        }
        
        BlackMarketPromotionView val_2 = UnityEngine.Object.Instantiate<BlackMarketPromotionView>(original:  this.defaultCellExample);
        val_6 = this.topWidgetLayout;
        goto label_7;
        label_2:
        val_7 = UnityEngine.Object.Instantiate<BlackMarketPromotionView>(original:  this.finalCellExample);
        this.topWidgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_7);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  true);
        BlackMarketEmptyCell val_4 = UnityEngine.Object.Instantiate<BlackMarketEmptyCell>(original:  this.emptyCellExample);
        val_6 = this.bottomWidgetLayout;
        val_6.AddElement(丅丆东丏丙丝丅丆丟:  val_4);
        val_9 = 1;
        val_10 = val_4;
        goto label_15;
        label_3:
        val_6 = this.bottomWidgetLayout;
        label_7:
        val_7 = UnityEngine.Object.Instantiate<BlackMarketPromotionView>(original:  this.defaultCellExample);
        val_6.AddElement(丅丆东丏丙丝丅丆丟:  val_7);
        val_9 = 1;
        val_10 = val_7;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
        return (BlackMarketPromotionView)val_7;
    }
    private void 丝丛丙不丅下上上丆()
    {
        this.下丁丏东三丂丘丙三.Clear();
        this.丑与丗丄丐丕丈丅万.Clear();
        this.topWidgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
        this.bottomWidgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
    }
    private void 丝一丅丆三东丂丞七()
    {
        List.Enumerator<T> val_1 = this.下丁丏东三丂丘丙三.GetEnumerator();
        label_4:
        if((1750963848 & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.东丄下万丛丘丆丙丞();
        this.丅世丟且一丆下丁丟();
        this.丁丏东东业东丙上万();
    }
    private void 丁丏东东业东丙上万()
    {
        int val_2 = PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().下业且丐专丕上东一();
        if(val_2 >= 1)
        {
                this.totalRefreshTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_2, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  public System.Void BlackMarketMainUI::ShowBlackMarketUI()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            return;
        }
        
        this.totalRefreshTimer.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9181"));
    }
    public void ToggleRefreshGlow(bool 丛丅丘一丏丙且丌上)
    {
        bool val_4;
        List.Enumerator<T> val_1 = this.下丁丏东三丂丘丙三.GetEnumerator();
        val_4 = 丛丅丘一丏丙且丌上;
        label_4:
        if((1751238120 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().ToggleRefreshGlow(丛丅丘一丏丙且丌上:  val_4);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丕丒丗与丁丞一丝丟()
    {
        this.ShowBlackMarketUI();
    }
    private void 丈丝下丛专三丐丛且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 一丐丗丁丞丆丅丟丄)
    {
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
    
    }
    public void U_GoToBank()
    {
        null = null;
        this.万丞丌七丈丄丙东万(丄专万万丝丐三丆丄:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
    }
    private void 万丞丌七丈丄丙东万(string 丄专万万丝丐三丆丄)
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  BlackMarketMainUI.丑丝专丐与与业丏丗);
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BlackMarketMainUI::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_6 = null;
        val_6 = null;
        val_7 = null;
        val_7 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丑丝世丒下丄丛与丕;
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丄专万万丝丐三丆丄, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丑丝世丒下丄丛与丕);
    }
    private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_6;
        var val_7;
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BlackMarketMainUI::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_6 = null;
        val_6 = null;
        val_7 = null;
        val_7 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丑丝世丒下丄丛与丕;
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丑丝世丒下丄丛与丕);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto typeof(BlackMarketMainUI).__il2cppRuntimeField_218;
        }
    
    }
    public void U_RefreshButtonPressed()
    {
        if(this.refreshBunner == null)
        {
            
        }
    
    }
    public void U_Refresh()
    {
        PGCompany.三东丏不丗世丅丌丄 val_2 = PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().不下上三专丟丅一与();
        if(((val_2 == null) || (val_2.业东丅东丌上丗丑不() == 10015)) || (val_2.业东丅东丌上丗丑不() == 11015))
        {
            goto label_3;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_2, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_5;
        }
        
        label_3:
        PGCompany.BM.丁丕下世丁丌万三丆.丑七不且上丗丁一世().万丌三下丆万丑丌东();
        return;
        label_5:
        this.万丞丌七丈丄丙东万(丄专万万丝丐三丆丄:  val_2.业上丙丞丐丄丆丅七());
    }
    private void 东丄下万丛丘丆丙丞()
    {
        var val_4;
        System.Func<BlackMarketPromotionView, System.Boolean> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = BlackMarketMainUI.<>c.<>9__45_0;
        if(val_6 == null)
        {
                System.Func<BlackMarketPromotionView, System.Boolean> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<BlackMarketPromotionView, System.Boolean>(object:  BlackMarketMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BlackMarketMainUI.<>c::丂丄丕丝七丟丐丂丌(BlackMarketPromotionView 三丟东丕丄丄下下丑));
            BlackMarketMainUI.<>c.<>9__45_0 = val_6;
        }
        
        BlackMarketPromotionView val_2 = System.Linq.Enumerable.LastOrDefault<BlackMarketPromotionView>(source:  this.下丁丏东三丂丘丙三, predicate:  val_1);
        this.与业世丂丛且丘七世 = val_2;
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) != false)
        {
                val_6 = this.与业世丂丛且丘七世.<丆丏业丙丒且万丈丂>k__BackingField;
        }
        
        this.丈业丘万丞丄丁专丆();
    }
    private void 丈业丘万丞丄丁专丆()
    {
        BlackMarketPromotionView val_6;
        var val_7;
        UnityEngine.MonoBehaviour val_8;
        var val_9;
        if(this.与业世丂丛且丘七世 == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_3 = this.与业世丂丛且丘七世.transform.position;
        UnityEngine.Vector3 val_5 = this.stikedFinalCell.transform.position;
        val_6 = this.stikedFinalCell;
        val_7 = null;
        if(val_3.x > val_5.x)
        {
            goto label_8;
        }
        
        goto label_12;
        label_3:
        val_6 = this.stikedFinalCell;
        val_7 = null;
        label_12:
        val_8 = val_6;
        val_9 = 0;
        goto label_13;
        label_8:
        val_9 = 1;
        val_8 = val_6;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
    }
    private void 丅世丟且一丆下丁丟()
    {
        List.Enumerator<T> val_1 = this.refreshButtons.GetEnumerator();
        label_7:
        if((1752677608 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.丝一丅丆三东丂丞七();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void U_ShowUpgradeBanner()
    {
        this.buildingProgress.U_ShowInfo();
    }
    private void Update()
    {
        this.丈业丘万丞丄丁专丆();
    }
    private void 丈丈上世丙万且且上()
    {
        this.ToggleRefreshGlow(丛丅丘一丏丙且丌上:  this.refreshBunner.IsActive);
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public override void HideSelf()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.丆丁一丅丗上业丅东, y:  0);
        this.HideSelf();
    }
    public BlackMarketMainUI()
    {
        this.下丁丏东三丂丘丙三 = new System.Collections.Generic.List<BlackMarketPromotionView>();
        this.丑与丗丄丐丕丈丅万 = new System.Collections.Generic.List<PGCompany.BM.世丘丈丑丘万丆丞丈>();
    }
    private static BlackMarketMainUI()
    {
        System.Collections.Generic.List<BankViewTab> val_1 = new System.Collections.Generic.List<BankViewTab>();
        if(val_1 != null)
        {
                val_1.Add(item:  1);
            val_1.Add(item:  5);
            val_1.Add(item:  2);
        }
        else
        {
                val_1.Add(item:  1);
            val_1.Add(item:  5);
            val_1.Add(item:  2);
        }
        
        val_1.Add(item:  8);
        BlackMarketMainUI.丑丝专丐与与业丏丗 = val_1;
    }
    private void 东东丙一丁丈丈三丛()
    {
        this.丆丁一丅丗上业丅东 = 0;
    }

}
