using UnityEngine;
internal sealed class ProgressRoadView : PGBehaviour
{
    // Fields
    private System.Action 丙与丙业丙三丛丁业;
    private static ProgressRoadView <不丁丄七丛不丆丁丕>k__BackingField;
    private static bool 丘丄丆不丛丗上三上;
    private static System.Action 丄与丁七丒丗丕丈丟;
    public UIPanel mainPanel;
    public UIPanel sizePanel;
    private EndlessScrollDynamic _roadScroll;
    private ScrollViewHelper _scrollHelper;
    private ProgressRoadPointInfoView pointInfoView;
    private ProgressRoadLevelUpView levelUpView;
    private ProgressRoadXpView xpView;
    private ProgressRoad.ProgressRoadFloatingView _floatingView;
    internal SimpleBunner veteranHintPanel;
    private float barFillSpeed;
    private float startAnimationsDelay;
    private UnityEngine.GameObject _leftNavigateContainer;
    private UnityEngine.GameObject _rightNavigateContainer;
    private UnityEngine.GameObject _buttonToVeteranChestContainer;
    public int _targetedProgress_DEBUG;
    private int 万七丏业丟丗丙东不;
    private int 丑上上丗丌专业丈与;
    private int 丟专丝丝丗下世丑不;
    private bool 万丝专丌丌三丟丆丄;
    private ProgressRoadPointView 丛丝丆丌丆东与丄万;
    private PGPlaySound showRewardsSound;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnAnimation;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnAnimation;
    private UnityEngine.GameObject backButton;
    private UnityEngine.GameObject continueButton;
    public System.Collections.Generic.List<UIRect> rectsToUpdate;
    private UnityEngine.GameObject tpGo;
    private bool 三丙丏上丕丑一上丟;
    private int 三丅不专且丅不丝丈;
    private int 丑丕丝丙丌丞丒丙万;
    private System.IDisposable 万且下世业丑专七业;
    private UnityEngine.Coroutine 丄丏丗丘三且丟丗与;
    private System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 丗丐丆东丟丒丙丆丘;
    private UIScrollView scrollView;
    private UIPanel scrollPanel;
    private float 丟丛世丅丐且丕丆七;
    private float 万下丌丂丄万下丟丐;
    private float 丏三丐专下丕丈丞专;
    private UnityEngine.AudioListener audioListener;
    
    // Properties
    internal static ProgressRoadView 丆丕丝丒不丙且丐丗 { get; set; }
    public static bool 丅业东万丌丕上丌丄 { get; }
    public int 丆丆丘丏下丑七丑下 { get; }
    public int 丟丂不丅丄丞丙丗丆 { get; }
    public int 不上万七万丑丈世丐 { get; }
    public int 万世丅七丌专专丂三 { get; }
    public bool 不丑业一丐丝丈丞丕 { get; }
    private ProgressRoadPointView 丌丌丂东丅丟丏丛丗 { get; }
    public int 丆专丙下丑不丛下丈 { get; }
    
    // Methods
    internal void 丅下丙丐下丝丈丑不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙与丙业丙三丛丁业, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙与丙业丙三丛丁业 != 1152921538784449496);
    
    }
    internal void 丏丐上丗丏丛丝丈专(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙与丙业丙三丛丁业, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙与丙业丙三丛丁业 != 1152921538784586072);
    
    }
    internal static ProgressRoadView 丑七不且上丗丁一世()
    {
        return (ProgressRoadView)ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(ProgressRoadView 丙业与丙丗丝不丈东)
    {
        ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public static bool get_IsActive()
    {
        return (bool)ProgressRoadView.丘丄丆不丛丗上三上;
    }
    internal static void 万专与丗丕丈一丒世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  ProgressRoadView.丄与丁七丒丗丕丈丟, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(ProgressRoadView.丄与丁七丒丗丕丈丟 != 1152921505250459664);
    
    }
    internal static void 丟丈丆丁丄七且丏丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  ProgressRoadView.丄与丁七丒丗丕丈丟, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(ProgressRoadView.丄与丁七丒丗丕丈丟 != 1152921505250459664);
    
    }
    public int get_InitialViewProgress()
    {
        return (int)this.万七丏业丟丗丙东不;
    }
    public int get_CurrentViewProgress()
    {
        return (int)this.丑上上丗丌专业丈与;
    }
    public int get_TargetedViewProgress()
    {
        return (int)this.丟专丝丝丗下世丑不;
    }
    public int get_AddedProgress()
    {
        return (int)this.丟专丝丝丗下世丑不 - this.万七丏业丟丗丙东不;
    }
    public bool get_AnimationInProgress()
    {
        return (bool)this.万丝专丌丌三丟丆丄;
    }
    private ProgressRoadPointView 丘丑丟丌丕丑且一三()
    {
        return (ProgressRoadPointView)this.丛丝丆丌丆东与丄万;
    }
    public int get_AnimatedProgress()
    {
        if(this.万丝专丌丌三丟丆丄 == false)
        {
                return (int)this.丑上上丗丌专业丈与;
        }
        
        if(this.丛丝丆丌丆东与丄万 == 0)
        {
                return (int)this.丑上上丗丌专业丈与;
        }
        
        if(this.丛丝丆丌丆东与丄万 != null)
        {
                return this.丛丝丆丌丆东与丄万.AnimatedProgress;
        }
        
        return this.丛丝丆丌丆东与丄万.AnimatedProgress;
    }
    public void UpdateRects()
    {
        List.Enumerator<T> val_1 = this.rectsToUpdate.GetEnumerator();
        label_7:
        if(((-180469400) & 1) == 0)
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
    private void OnEnable()
    {
        this.不丟丗七不丆丗丙一(丑丒业丘丑东丕世丅:  true);
        ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField = this;
        ProgressRoadView.丘丄丆不丛丗上三上 = true;
        if(this.三丙丏上丕丑一上丟 != false)
        {
                this.丝一丅丆三东丂丞七();
        }
        
        this.三丙丏上丕丑一上丟 = false;
        ProgressRoadPointView.丂丗丗丙专丑且丙丁(丙业与丙丗丝不丈东:  new System.Action<ProgressRoadPointView>(object:  this, method:  System.Void ProgressRoadView::与丐丝丏丑专丁丙丙(ProgressRoadPointView 丈三丈丄丑且不丁七)));
        ProgressRoadLevelUpView.丘丌世专丌专丕丂丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丕丟丅丑丆丝上上丒()));
        ProgressRoadPointInfoView.丘丌世专丌专丕丂丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丏丝上丄丐东丆丁丒()));
        this._roadScroll.add_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丒下丁业不丟丂丝一()));
        ExpController.上专丟丙业丒且丕丘(世丞丑上丅与世丁世:  this.tpGo);
    }
    private void OnDisable()
    {
        this.不丟丗七不丆丗丙一(丑丒业丘丑东丕世丅:  false);
        ProgressRoadView.丘丄丆不丛丗上三上 = false;
        ProgressRoadPointView.万丑专一丟世丑业丛(丙业与丙丗丝不丈东:  new System.Action<ProgressRoadPointView>(object:  this, method:  System.Void ProgressRoadView::与丐丝丏丑专丁丙丙(ProgressRoadPointView 丈三丈丄丑且不丁七)));
        ProgressRoadLevelUpView.不丛丛丌上丕丏专三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丕丟丅丑丆丝上上丒()));
        ProgressRoadPointInfoView.不丛丛丌上丕丏专三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丏丝上丄丐东丆丁丒()));
        this._roadScroll.remove_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丒下丁业不丟丂丝一()));
        ExpController.丏丂丛一与丄世上丒(世丞丑上丅与世丁世:  this.tpGo);
        if(this.万且下世业丑专七业 == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.万且下世业丑专七业.Dispose();
    }
    internal void 丈且东丑丂且万丒丅(int 丂世且丙丅丘不七丑, int 丏丆丅且上丅上丌丘)
    {
        if(this.gameObject.activeInHierarchy != true)
        {
                this.三丙丏上丕丑一上丟 = true;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.pointInfoView.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.levelUpView.gameObject, 丏业丟一东丂东丘丛:  false);
        this.丗丐丆东丟丒丙丆丘.Clear();
        this.万丝专丌丌三丟丆丄 = false;
        if((丂世且丙丅丘不七丑 & 2147483648) != 0)
        {
            goto label_9;
        }
        
        label_20:
        this.万七丏业丟丗丙东不 = 丂世且丙丅丘不七丑;
        this.丑上上丗丌专业丈与 = 丂世且丙丅丘不七丑;
        this.丟专丝丝丗下世丑不 = 丏丆丅且上丅上丌丘;
        this.丝一丅丆三东丂丞七();
        if(this.万七丏业丟丗丙东不 >= this.丟专丝丝丗下世丑不)
        {
            goto label_11;
        }
        
        this.万丝专丌丌三丟丆丄 = true;
        if(this.万且下世业丑专七业 == null)
        {
            goto label_12;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        goto label_16;
        label_9:
        int val_5 = ExperienceController.丂丂下丑且下丌丝东();
        if((丏丆丅且上丅上丌丘 & 2147483648) == 0)
        {
            goto label_20;
        }
        
        goto label_20;
        label_16:
        this.万且下世业丑专七业.Dispose();
        label_12:
        this.万且下世业丑专七业 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "ProgressRoadAnimation_BackBlocker");
        一丛丟世丗丈丘丏万 val_10 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "ProgressRoadView_AnimateProgress", 丘丁三丅丆与丆业业:  this.startAnimationsDelay, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void ProgressRoadView::丕丛七上丒丒七与丞()));
        label_11:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnAnimation, 丏业丟一东丂东丘丛:  (this.万丝专丌丌三丟丆丄 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnAnimation, 丏业丟一东丂东丘丛:  (this.万丝专丌丌三丟丆丄 == false) ? 1 : 0);
        this.丁丄丘丙不丆丌丆丛(丑丒业丘丑东丕世丅:  (this.万丝专丌丌三丟丆丄 == false) ? 1 : 0);
    }
    private void Awake()
    {
        this.丛且丐下世与丘丆丗();
    }
    private void OnDestroy()
    {
        this.万与七三丄丁丏世丘();
    }
    private void 丛且丐下世与丘丆丗()
    {
        this._roadScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void ProgressRoadView::丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
    }
    private void 万与七三丄丁丏世丘()
    {
        this._roadScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void ProgressRoadView::丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
    }
    private void 丂上下丟丕东丁丛不(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        var val_8;
        ProgressRoad.丅丂丅丕下丑丘万一 val_9;
        val_8 = 丌丝万上丅丒一丈丘;
        if(val_8 != null)
        {
                UnityEngine.Object val_1 = (null == null) ? (val_8) : 0;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        if(Count > val_1.Index)
        {
                val_9 = Item[val_1.Index];
        }
        else
        {
                val_9 = 0;
        }
        
        val_1.丈且东丑丂且万丒丅(东东丗丅与一下丄丈:  val_9);
        this._floatingView.上丒三丅世丁丒丒丙(丁丑下且丛丙丏丂下:  this.mainPanel, 丆丏七丟不丒与七专:  this.三且丟丞丝丘丈丆丒(业丌丆业丘丟丆丁丛:  this.丑丕丝丙丌丞丒丙万));
    }
    private void 丒下丁业不丟丂丝一()
    {
        this.丌世下专丙丝丗专丙();
    }
    private void 丌世下专丙丝丗专丙()
    {
        if(this._floatingView == 0)
        {
                return;
        }
        
        int val_2 = this.丝丕丝一与丁上丕丄();
        if(((val_2 & 2147483648) != 0) || (val_2 == this.三丅不专且丅不丝丈))
        {
            goto label_9;
        }
        
        int val_5 = val_2;
        label_10:
        if(val_5 >= Count)
        {
            goto label_9;
        }
        
        val_5 = val_5 + 1;
        if((this.丕七丙七丁上丟七丄(丞世不丒下上上丝丑:  val_5)) == false)
        {
            goto label_10;
        }
        
        label_9:
        this.三丅不专且丅不丝丈 = val_2;
    }
    private bool 丕七丙七丁上丟七丄(int 丞世不丒下上上丝丑)
    {
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_5;
        int val_6;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7;
        val_6 = 丞世不丒下上上丝丑;
        if((val_6 & 2147483648) == 0)
        {
                val_5 = mem[ProgressRoad.丁丒丛丆与七丟丗丙.<不丁丄七丛不丆丁丕>k__BackingField + 16];
            val_5 = ProgressRoad.丁丒丛丆与七丟丗丙.<不丁丄七丛不丆丁丕>k__BackingField.一业专七且与丝丑丙;
            if(Count > val_6)
        {
                val_5 = Item[val_6];
            if(val_5 == null)
        {
                return (bool)val_7;
        }
        
            val_7 = val_2.丁丝丒七一一下不丆;
            if(val_7 == null)
        {
                return (bool)val_7;
        }
        
            if(val_7.Count >= 1)
        {
                this.丑丕丝丙丌丞丒丙万 = val_6;
            val_6 = this.三且丟丞丝丘丈丆丒(业丌丆业丘丟丆丁丛:  val_6);
            this._floatingView.丈且东丑丂且万丒丅(丁丑下且丛丙丏丂下:  this.mainPanel, 丆丏七丟不丒与七专:  val_6, 东东丗丅与一下丄丈:  val_5);
            val_7 = 1;
            return (bool)val_7;
        }
        
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private int 丝丕丝一与丁上丕丄()
    {
        var val_9 = 0;
        goto label_9;
        label_25:
        if(this._roadScroll.cellsList.Item[0] != null)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        label_22:
        val_9 = 1;
        goto label_9;
        label_8:
        if((null == 0) || (1152921505250349088 < 2))
        {
            goto label_22;
        }
        
        EndlessScrollCellDynamic val_2 = this._roadScroll.cellsList.Item[0];
        UnityEngine.Vector3 val_4 = val_2.widget.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) >= 0)
        {
            goto label_22;
        }
        
        EndlessScrollCellDynamic val_6 = this._roadScroll.cellsList.Item[0];
        goto label_22;
        label_9:
        if(val_9 < this._roadScroll.cellsList.Count)
        {
            goto label_25;
        }
        
        if(0 == 0)
        {
                return 0;
        }
        
        if(0 != 0)
        {
                return 0.Index;
        }
        
        return 0.Index;
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.UpdateRects();
        this.ScrollToCurrentPoint();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonToVeteranChestContainer, 丏业丟一东丂东丘丛:  PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().三不专丗七丄且丝业());
        ProgressRoadPointView val_4 = this.一与丝三丁专一丏丂();
        this.丛丝丆丌丆东与丄万 = val_4;
        if(val_4 == 0)
        {
                return;
        }
        
        this.丛丝丆丌丆东与丄万.Select(丛丁三七丅且丝丏丙:  true);
    }
    public void ScrollToCurrentPoint()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.scrollView.currentMomentum = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.scrollView.DisableSpring();
        this._roadScroll.Init(上专丅业三丏丈丈丗:  Count, 丏丑丝万下与丁丞业:  IndexOf(item:  ProgressRoad.丁丒丛丆与七丟丗丙.<不丁丄七丛不丆丁丕>k__BackingField.丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  this.丑上上丗丌专业丈与)));
        ProgressRoadPointView val_5 = this.丝东丝丙丂上丄丂与();
        if(val_5 != 0)
        {
                if(val_5.GetDistanceToEndge() > 0f)
        {
                this._scrollHelper.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  false);
        }
        
        }
        
        this._roadScroll.丗丁丞丒丗丁七且丐();
        this.丌世下专丙丝丗专丙();
    }
    public void ShowPointInfo(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
    {
        this.pointInfoView.Show(东东丗丅与一下丄丈:  东东丗丅与一下丄丈, 且丁丐丑丞丐七丙与:  true);
    }
    public void ShowPointInfo(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业)
    {
        this.pointInfoView.Show(三丒不不一七东丕业:  三丒不不一七东丕业, 且丁丐丑丞丐七丙与:  false);
    }
    public void ShowLevelUpInfo(ProgressRoad.丅丂丅丕下丑丘万一 三丒不不一七东丕业)
    {
        this.levelUpView.Show(东东丗丅与一下丄丈:  三丒不不一七东丕业);
    }
    private ProgressRoadPointView 一与丝三丁专一丏丂()
    {
        var val_8;
        .丟丅世万三丘丅专丐 = IndexOf(item:  ProgressRoad.丁丒丛丆与七丟丗丙.<不丁丄七丛不丆丁丕>k__BackingField.丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  this.丑上上丗丌专业丈与));
        EndlessScrollCellDynamic val_5 = System.Linq.Enumerable.FirstOrDefault<EndlessScrollCellDynamic>(source:  this._roadScroll.cellsList, predicate:  new System.Func<EndlessScrollCellDynamic, System.Boolean>(object:  new ProgressRoadView.丘丈万一丅东一上万(), method:  System.Boolean ProgressRoadView.丘丈万一丅东一上万::与丑业东世一丟丕业(EndlessScrollCellDynamic 三丟东丕丄丄下下丑)));
        val_8 = 0;
        if(val_5 == null)
        {
                return (ProgressRoadPointView)(null == null) ? (val_5) : 0;
        }
        
        if(val_5 == 0)
        {
                return (ProgressRoadPointView)(null == null) ? (val_5) : 0;
        }
        
        return (ProgressRoadPointView)(null == null) ? (val_5) : 0;
    }
    private void 与丐丝丏丑专丁丙丙(ProgressRoadPointView 丈三丈丄丑且不丁七)
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Complete ProgressCell Animation");
        if(丈三丈丄丑且不丁七.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七 > this.丟专丝丝丗下世丑不)
        {
                this.一丁丒丂业丄且丞丂();
            return;
        }
        
        this.丑上上丗丌专业丈与 = 丈三丈丄丑且不丁七.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七;
        this.业丝不丅业不下丑丐();
    }
    private void 一丁丒丂业丄且丞丂()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Complete All Animations");
        this.万丝专丌丌三丟丆丄 = false;
        this.丑上上丗丌专业丈与 = this.丟专丝丝丗下世丑不;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnAnimation, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnAnimation, 丏业丟一东丂东丘丛:  (this.万丝专丌丌三丟丆丄 == false) ? 1 : 0);
        this.丁丄丘丙不丆丌丆丛(丑丒业丘丑东丕世丅:  (this.万丝专丌丌三丟丆丄 == false) ? 1 : 0);
        if(this.万且下世业丑专七业 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.万且下世业丑专七业.Dispose();
        }
        
        if(ProgressRoadView.丄与丁七丒丗丕丈丟 == null)
        {
                return;
        }
        
        ProgressRoadView.丄与丁七丒丗丕丈丟.Invoke();
    }
    private void 丕丛七上丒丒七与丞()
    {
        if(this.丄丏丗丘三且丟丗与 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丄丏丗丘三且丟丗与);
        }
        
        this.丄丏丗丘三且丟丗与 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.业丝丑不丟丙丅丞丆());
    }
    private System.Collections.IEnumerator 业丝丑不丟丙丅丞丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ProgressRoadView.丝丒丂丂丅丄专丟丗();
    }
    private void 一东上丂丟丙与七一()
    {
        ProgressRoadPointView val_1 = this.一与丝三丁专一丏丂();
        this.丛丝丆丌丆东与丄万 = val_1;
        if(val_1 != 0)
        {
                this.丛丝丆丌丆东与丄万.Select(丛丁三七丅且丝丏丙:  true);
            this.万丝专丌丌三丟丆丄 = true;
            this.丛丝丆丌丆东与丄万.AnimateProgressTo(丑业丕丒专丆丟专丞:  this.丟专丝丝丗下世丑不, 丟丆七丌丄丒且世丂:  this.barFillSpeed);
            return;
        }
        
        this.一丁丒丂业丄且丞丂();
    }
    private void 业丝不丅业不下丑丐()
    {
        var val_5;
        System.Func<ProgressRoad.丅丂丅丕下丑丘万一, System.Boolean> val_7;
        ProgressRoadPointView val_1 = this.一与丝三丁专一丏丂();
        this.丛丝丆丌丆东与丄万 = val_1;
        if(val_1 == 0)
        {
            goto label_3;
        }
        
        this.丛丝丆丌丆东与丄万.Select(丛丁三七丅且丝丏丙:  true);
        this.丛丝丆丌丆东与丄万.OnReachPoint();
        this.丗丐丆东丟丒丙丆丘.Add(item:  this.丛丝丆丌丆东与丄万.丘三丌丐丒丒七丑东);
        this.丛丝丆丌丆东与丄万.PlayReachedAnimation();
        if((this.丟专丝丝丗下世丑不 < this.丛丝丆丌丆东与丄万.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七) || (this.丛丝丆丌丆东与丄万.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七 == 0))
        {
            goto label_14;
        }
        
        label_3:
        this.一东上丂丟丙与七一();
        return;
        label_14:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Last point reached. Show windows");
        val_5 = null;
        val_5 = null;
        val_7 = ProgressRoadView.<>c.<>9__84_0;
        if(val_7 == null)
        {
                System.Func<ProgressRoad.丅丂丅丕下丑丘万一, System.Boolean> val_3 = null;
            val_7 = val_3;
            val_3 = new System.Func<ProgressRoad.丅丂丅丕下丑丘万一, System.Boolean>(object:  ProgressRoadView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ProgressRoadView.<>c::不丝业专丐丁丂丘丁(ProgressRoad.丅丂丅丕下丑丘万一 三丟东丕丄丄下下丑));
            ProgressRoadView.<>c.<>9__84_0 = val_7;
        }
        
        ProgressRoad.丅丂丅丕下丑丘万一 val_4 = System.Linq.Enumerable.LastOrDefault<ProgressRoad.丅丂丅丕下丑丘万一>(source:  this.丗丐丆东丟丒丙丆丘, predicate:  val_3);
        if(val_4 != null)
        {
                this.ShowLevelUpInfo(三丒不不一七东丕业:  val_4);
            return;
        }
        
        this.ShowPointInfo(三丒不不一七东丕业:  this.丗丐丆东丟丒丙丆丘);
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  8, 丌世丕丗不丘世丞专:  2, 一七丁不丝丈丕丑丒:  0);
    }
    private void 丕丟丅丑丆丝上上丒()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "OnCloseLevelUp");
        ProgressRoadPointView val_1 = this.一与丝三丁专一丏丂();
        if(val_1 != 0)
        {
                val_1.PlayReachedAnimation();
        }
        
        this.ShowPointInfo(三丒不不一七东丕业:  this.丗丐丆东丟丒丙丆丘);
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  8, 丌世丕丗不丘世丞专:  2, 一七丁不丝丈丕丑丒:  0);
    }
    private void 丏丝上丄丐东丆丁丒()
    {
        if(this.万丝专丌丌三丟丆丄 == false)
        {
                return;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "OnClosePointInfo. Continue Animation...");
        this.一东上丂丟丙与七一();
    }
    private UnityEngine.Transform 一丞丗丘业丌丌丈丙()
    {
        ProgressRoadPointView val_2;
        UnityEngine.Transform val_3;
        val_2 = this;
        val_3 = 0;
        if(this.丛丝丆丌丆东与丄万 == 0)
        {
                return val_3;
        }
        
        val_2 = this.丛丝丆丌丆东与丄万;
        val_3 = this.丛丝丆丌丆东与丄万.progressBarPointer;
        return val_3;
    }
    private ProgressRoadPointView 丝东丝丙丂上丄丂与()
    {
        var val_3;
        UnityEngine.Object val_6;
        List.Enumerator<T> val_1 = this._roadScroll.cellsList.GetEnumerator();
        label_11:
        if(((-176380048) & 1) == 0)
        {
            goto label_3;
        }
        
        val_6 = val_3.丐丏七丌丕丗业且上();
        if((val_6 != null) && (null != null))
        {
                val_6 = 0;
        }
        
        if(((val_6 == 0) || (123372728 == 0)) || ((123372728 + 32) != 65))
        {
            goto label_11;
        }
        
        goto label_12;
        label_3:
        val_6 = 0;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (ProgressRoadPointView)val_6;
    }
    public void U_Back()
    {
        if(this.万丝专丌丌三丟丆丄 != false)
        {
                return;
        }
        
        this.丙与丙业丙三丛丁业.Invoke();
    }
    public void U_OpenVeteranChest()
    {
        if(this.万丝专丌丌三丟丆丄 != false)
        {
                return;
        }
        
        this.U_Back();
        bool val_1 = ProgressRoad.丁丒丛丆与七丟丗丙.丕三丂丄三丁丛丘世();
    }
    private void 丁丄丘丙不丆丌丆丛(bool 丑丒业丘丑东丕世丅)
    {
        var val_2;
        var val_3;
        UnityEngine.GameObject val_4;
        UnityEngine.GameObject val_5;
        var val_6;
        if(丑丒业丘丑东丕世丅 == false)
        {
            goto label_1;
        }
        
        val_2 = null;
        val_2 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_6;
        }
        
        val_3 = 1;
        val_4 = this.backButton;
        goto label_9;
        label_1:
        val_4 = this.backButton;
        val_3 = 0;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
        val_5 = this.continueButton;
        val_6 = 0;
        goto label_12;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backButton, 丏业丟一东丂东丘丛:  false);
        val_5 = this.continueButton;
        val_6 = 1;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  true);
    }
    private void LateUpdate()
    {
        UIPanel val_23;
        int val_24;
        float val_25;
        float val_26;
        val_23 = this;
        this.世丑丈世专丟丒一丅();
        val_24 = this.AnimatedProgress;
        this.xpView.丈且东丑丂且万丒丅(丒东专一不与丐丐丁:  val_24);
        UnityEngine.Transform val_2 = this.一丞丗丘业丌丌丈丙();
        if(val_2 != 0)
        {
                val_24 = this.scrollPanel.transform;
            UnityEngine.Vector3 val_5 = val_2.position;
            val_25 = val_5.x;
            val_26 = val_5.z;
            UnityEngine.Vector3 val_6 = val_24.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_25, y = val_5.y, z = val_26});
            if(val_6.x < 0)
        {
                return;
        }
        
            val_24 = this.丝东丝丙丂上丄丂与();
            if(val_24 != 0)
        {
                if(val_24.GetDistanceToEndge() > 0f)
        {
                return;
        }
        
        }
        
        }
        
        if(this.万丝专丌丌三丟丆丄 == false)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        val_24 = this.scrollPanel.transform;
        UnityEngine.Vector3 val_12 = val_2.position;
        UnityEngine.Vector3 val_13 = val_24.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_15 = this.scrollView.transform.localPosition;
        UnityEngine.Vector3 val_17 = this.scrollView.transform.localPosition;
        UnityEngine.Vector2 val_18 = this.scrollPanel.clipOffset;
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_13.x, y:  val_18.y);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        val_26 = val_20.z;
        this.scrollView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_23 = this.scrollPanel;
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_26});
        val_25 = val_22.x;
        val_23.clipOffset = new UnityEngine.Vector2() {x = val_25, y = val_22.y};
    }
    private void 世丑丈世专丟丒一丅()
    {
        UnityEngine.Object val_19;
        var val_20;
        UnityEngine.GameObject val_21;
        float val_22;
        var val_23;
        UnityEngine.GameObject val_24;
        .丝一丞丘丟丑丂丘丐 = IndexOf(item:  ProgressRoad.丁丒丛丆与七丟丗丙.<不丁丄七丛不丆丁丕>k__BackingField.丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  this.丑上上丗丌专业丈与));
        val_19 = System.Linq.Enumerable.FirstOrDefault<EndlessScrollCellDynamic>(source:  this._roadScroll.cellsList, predicate:  new System.Func<EndlessScrollCellDynamic, System.Boolean>(object:  new ProgressRoadView.丗且丈丂丁丄专丞专(), method:  System.Boolean ProgressRoadView.丗且丈丂丁丄专丞专::丕丙丒丁丄丘丘丄下(EndlessScrollCellDynamic 三丟东丕丄丄下下丑)));
        if(val_19 != 0)
        {
            goto label_10;
        }
        
        int val_19 = (ProgressRoadView.丗且丈丂丁丄专丞专)[1152921538791060272].丝一丞丘丟丑丂丘丐;
        val_19 = this.丐且东丌丕丙丑下上(丞世不丒下上上丝丑:  val_19);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftNavigateContainer, 丏业丟一东丂东丘丛:  val_19);
        val_19 = this._rightNavigateContainer;
        val_20 = (~(this.丐且东丌丕丙丑下上(丞世不丒下上上丝丑:  (ProgressRoadView.丗且丈丂丁丄专丞专)[1152921538791060272].丝一丞丘丟丑丂丘丐))) & 1;
        val_21 = val_19;
        goto label_29;
        label_10:
        UnityEngine.Vector3 val_10 = val_19.transform.position;
        val_22 = val_10.x;
        UnityEngine.Vector3 val_12 = this._leftNavigateContainer.transform.position;
        float val_13 = val_22 + this.丟丛世丅丐且丕丆七;
        val_13 = val_13 + this.丏三丐专下丕丈丞专;
        if(val_13 >= 0)
        {
            goto label_18;
        }
        
        val_23 = 1;
        val_24 = this._leftNavigateContainer;
        goto label_21;
        label_18:
        UnityEngine.Vector3 val_15 = val_19.transform.position;
        val_22 = val_15.x;
        UnityEngine.Vector3 val_17 = this._rightNavigateContainer.transform.position;
        float val_18 = val_22 - this.万下丌丂丄万下丟丐;
        val_18 = val_18 - this.丏三丐专下丕丈丞专;
        if(val_18 <= val_17.x)
        {
            goto label_26;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftNavigateContainer, 丏业丟一东丂东丘丛:  false);
        val_21 = this._rightNavigateContainer;
        val_20 = 1;
        goto label_29;
        label_26:
        val_24 = this._leftNavigateContainer;
        val_23 = 0;
        label_21:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  false);
        val_21 = this._rightNavigateContainer;
        val_20 = 0;
        label_29:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  false);
    }
    private bool 丐且东丌丕丙丑下上(int 丞世不丒下上上丝丑)
    {
        var val_4;
        List.Enumerator<T> val_1 = this._roadScroll.cellsList.GetEnumerator();
        label_5:
        if(((-175371128) & 1) == 0)
        {
            goto label_3;
        }
        
        if(0.丐丏七丌丕丗业且上().Index >= 丞世不丒下上上丝丑)
        {
            goto label_5;
        }
        
        val_4 = 0;
        goto label_6;
        label_3:
        val_4 = 1;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    private UnityEngine.Transform 三且丟丞丝丘丈丆丒(int 业丌丆业丘丟丆丁丛)
    {
        var val_5;
        var val_6;
        UnityEngine.Transform val_7;
        EndlessScrollCellDynamic val_1 = this._roadScroll.GetCellByIndex(丞世不丒下上上丝丑:  业丌丆业丘丟丆丁丛);
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        if(val_1 == null)
        {
            goto label_5;
        }
        
        val_5 = null;
        if(null == val_5)
        {
            goto label_6;
        }
        
        label_5:
        val_6 = null;
        goto label_7;
        label_4:
        if(this._roadScroll.CurrentMaxIndex > 业丌丆业丘丟丆丁丛)
        {
                val_7 = this._roadScroll.bottomBoundGO;
            return (UnityEngine.Transform)val_7;
        }
        
        val_7 = this._roadScroll.topBoundGO;
        return (UnityEngine.Transform)val_7;
        label_6:
        val_6 = val_5;
        label_7:
        val_7 = ((val_5 == val_6) ? (val_1) : 0) + 248;
        return (UnityEngine.Transform)val_7;
    }
    private void 不丟丗七不丆丗丙一(bool 丑丒业丘丑东丕世丅)
    {
        CameraSceneController val_6;
        this.audioListener.enabled = false;
        val_6 = CameraSceneController.丄丞丁丈与业上丞丟;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = mem[CameraSceneController.丄丞丁丈与业上丞丟 + 72];
        val_6 = CameraSceneController.丄丞丁丈与业上丞丟.objListener;
        if(val_6 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  (~丑丒业丘丑东丕世丅) & 1);
        this.audioListener.enabled = 丑丒业丘丑东丕世丅;
    }
    private void 丐丛三一丙下丕丐丏()
    {
    
    }
    public ProgressRoadView()
    {
        this.barFillSpeed = 1f;
        this.startAnimationsDelay = 1f;
        mem2[0] = 0;
        this.丗丐丆东丟丒丙丆丘 = new System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一>();
        this.丟丛世丅丐且丕丆七 = 0.05f;
        this.万下丌丂丄万下丟丐 = 5.510186E-41f;
        this.丏三丐专下丕丈丞专 = 0.5f;
    }

}
