using UnityEngine;
internal sealed class PiggyPromotionView : MainStorePromotionView
{
    // Fields
    private System.Action 丟万丗丅丌三专上丈;
    private UILabel currentLavel;
    private UILabel descriptionTop;
    private UILabel descriptionBottom;
    private UILabel timeIsOverDesc;
    private MiniPoolMonoBehaviour levelSectionViewPool;
    private WidgetLayout levelSectionslayout;
    private ScrollViewHelper scrollHelper;
    private PGCompany.Piggy.PiggyLevelSectionView stikedLevelSection;
    private UnityEngine.Transform lastLevelSectionPoint;
    private UnityEngine.GameObject enableOnPurchase;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnMaxLevel;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnMaxLevel;
    private UnityEngine.GameObject purchsaceButton;
    private UnityEngine.GameObject connectSceneButton;
    private UnityEngine.GameObject connectSceneButton2;
    private PiggyEndBanner piggyEndBanner;
    private UnityEngine.GameObject _lastChanceBanner;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private UnityEngine.GameObject _backContainer;
    private PGCompany.Piggy.PiggyLevelSectionView 丒东丏丕丏不业丑丞;
    private System.Collections.Generic.List<PGCompany.Piggy.PiggyLevelSectionView> 丛丑丘上不丝丏丝专;
    private PGCompany.MainStore.东丆丒丄丂丆上丈业 丑丘丙上丁丌一丗万;
    private bool 丄七丟七丄世三丂丐;
    
    // Properties
    public bool 且丁专丄上上丟丆丆 { get; }
    
    // Methods
    public void add_hideRequst(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丟万丗丅丌三专上丈, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟万丗丅丌三专上丈 != 1152921538544045816);
    
    }
    public void remove_hideRequst(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丟万丗丅丌三专上丈, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟万丗丅丌三专上丈 != 1152921538544182392);
    
    }
    internal bool 七与丘丘丈不丂丛丐()
    {
        if(this.piggyEndBanner == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = this.piggyEndBanner.gameObject;
        if(val_2 != null)
        {
                return val_2.activeSelf;
        }
        
        return val_2.activeSelf;
    }
    private void OnEnable()
    {
        PGCompany.Piggy.业世且丐丕专丛专丐.丕东上三且一丙专与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PiggyPromotionView::丕丒下丛专三东专丁(int 下丝丘丁专丐丅丛丝)));
        PGCompany.Piggy.业世且丐丕专丛专丐.丂与下三丌一丙丏一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.下不不上丒与一丁专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.万丞下世东且专丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.MainStore.东丆丒丄丂丆上丈业.丕丝万丂丆丁万下丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.丁万丘丑世丝世丂专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.丛万丌丂下丅丛丏万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::下丞东且丕与丕丗丘()));
    }
    private void OnDisable()
    {
        PGCompany.Piggy.业世且丐丕专丛专丐.丑丐丅丕七一丞丗且(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PiggyPromotionView::丕丒下丛专三东专丁(int 下丝丘丁专丐丅丛丝)));
        PGCompany.Piggy.业世且丐丕专丛专丐.丐不丈丟丛丌万世丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.丂且丆丙一丈丙丛万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.三丗丆丕丟上丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.MainStore.东丆丒丄丂丆上丈业.丞丆丐丝一丞一世东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.万丗丟丏丌丄丄一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.丁不丈东下东丘丈且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::下丞东且丕与丕丗丘()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableOnPurchase, 丏业丟一东丂东丘丛:  false);
    }
    private void 丕丒下丛专三东专丁(int 下丝丘丁专丐丅丛丝)
    {
        goto typeof(PiggyPromotionView).__il2cppRuntimeField_198;
    }
    private void 丑丈丆万丅上丞丗丐()
    {
        if(this.丑丘丙上丁丌一丗万 == null)
        {
                return;
        }
        
        goto typeof(PiggyPromotionView).__il2cppRuntimeField_198;
    }
    private void 下丞东且丕与丕丗丘()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableOnPurchase, 丏业丟一东丂东丘丛:  true);
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().与丁丂三下丛丘丁丅() != true)
        {
                if(this.丑丘丙上丁丌一丗万.丂丕且七丆下丄不丘() == false)
        {
                return;
        }
        
        }
        
        if(this.丟万丗丅丌三专上丈 == null)
        {
                return;
        }
        
        this.丟万丗丅丌三专上丈.Invoke();
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.MainStore.东丆丒丄丂丆上丈业 val_8;
        if(且丘丏丁丑与丙与丁 != null)
        {
                var val_1 = (null == null) ? 且丘丏丁丑与丙与丁 : 0;
        }
        else
        {
                val_8 = 0;
        }
        
        this.丑丘丙上丁丌一丗万 = val_8;
        this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        List.Enumerator<T> val_2 = this.rectsToUpdate.GetEnumerator();
        label_10:
        if(((-421390536) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if(val_3 == 0)
        {
            goto label_10;
        }
        
        val_3.ResetAndUpdateAnchors();
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backContainer, 丏业丟一东丂东丘丛:  (~PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().专丑三专万丘丂丟丝()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableOnPurchase, 丏业丟一东丂东丘丛:  false);
        this.一专业丟丙丁与丕丏();
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        UILabel val_37;
        string val_38;
        var val_39;
        PGCompany.MainStore.东丆丒丄丂丆上丈业 val_40;
        var val_41;
        var val_42;
        UnityEngine.GameObject val_43;
        var val_44;
        var val_45;
        if(this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐() != false)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionTop, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10425"));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionBottom, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10984"));
            val_37 = this.timeIsOverDesc;
            val_38 = "Key_10989";
        }
        else
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionTop, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10985"));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionBottom, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10986"));
            val_37 = this.timeIsOverDesc;
            val_38 = "Key_10990";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_37, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_38));
        this.与丅丄丅丂丁丌且丐();
        int val_7 = this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄();
        int val_9 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丄且东且丕丛与丆丒();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnMaxLevel, 丏业丟一东丂东丘丛:  (val_7 >= val_9) ? 1 : 0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnMaxLevel, 丏业丟一东丂东丘丛:  (val_7 < val_9) ? 1 : 0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentLavel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431"), arg0:  this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄()));
        if(this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐() == false)
        {
            goto label_20;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.purchsaceButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneButton2, 丏业丟一东丂东丘丛:  false);
        val_39 = null;
        val_39 = null;
        val_40 = 1152921504848912384;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_52;
        }
        
        val_41 = static_value_081DACA8;
        val_41 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
            goto label_52;
        }
        
        val_40 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世();
        if(this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄() >= val_40.丄且东且丕丛与丆丒())
        {
            goto label_52;
        }
        
        val_42 = null;
        val_43 = this.connectSceneButton;
        goto label_54;
        label_20:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.purchsaceButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneButton2, 丏业丟一东丂东丘丛:  false);
        val_44 = null;
        val_44 = null;
        val_40 = 1152921504848912384;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_52;
        }
        
        val_45 = static_value_081DACA8;
        val_45 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
            goto label_52;
        }
        
        val_40 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世();
        if(this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄() >= val_40.丄且东且丕丛与丆丒())
        {
            goto label_52;
        }
        
        val_42 = null;
        val_43 = this.connectSceneButton2;
        label_54:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43, 丏业丟一东丂东丘丛:  true);
        label_52:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.piggyEndBanner.gameObject, 丏业丟一东丂东丘丛:  false);
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().与丁丂三下丛丘丁丅() != true)
        {
                if(this.丑丘丙上丁丌一丗万.丂丕且七丆下丄不丘() == false)
        {
            goto label_72;
        }
        
        }
        
        if(this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐() == true)
        {
            goto label_63;
        }
        
        val_40 = this.丑丘丙上丁丌一丗万;
        if(this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄() < val_40.丌业万不丟东一丂丄())
        {
            goto label_69;
        }
        
        label_63:
        System.Predicate<PGCompany.MainStore.七丄不下丘丏一丂丌> val_33 = null;
        val_40 = val_33;
        val_33 = new System.Predicate<PGCompany.MainStore.七丄不下丘丏一丂丌>(object:  this, method:  System.Boolean PiggyPromotionView::丑丏丛丏丝丈丙一世(PGCompany.MainStore.七丄不下丘丏一丂丌 三丟东丕丄丄下下丑));
        if((this.丑丘丙上丁丌一丗万.不丌东东丌丞丙专丝.Exists(match:  val_33)) == false)
        {
            goto label_69;
        }
        
        val_40 = this.丑丘丙上丁丌一丗万;
        this.piggyEndBanner.下与丞三丅丛丄七丕(与不丁且丆万丂丞世:  val_40);
        goto label_72;
        label_69:
        if(this.丟万丗丅丌三专上丈 != null)
        {
                this.丟万丗丅丌三专上丈.Invoke();
        }
        
        label_72:
        this.丄七丟七丄世三丂丐 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lastChanceBanner, 丏业丟一东丂东丘丛:  false);
        return (bool)this.丝一丅丆三东丂丞七();
    }
    private void 与丅丄丅丂丁丌且丐()
    {
        var val_4;
        if(this.levelSectionViewPool == 0)
        {
                return;
        }
        
        this.丐丆下丒丁丌丛丆世();
        List.Enumerator<T> val_2 = this.丑丘丙上丁丌一丗万.不丌东东丌丞丙专丝.GetEnumerator();
        goto label_6;
        label_15:
        PGCompany.Piggy.PiggyLevelSectionView val_6 = this.levelSectionViewPool.Get<PGCompany.Piggy.PiggyLevelSectionView>();
        val_6.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  this.丑丘丙上丁丌一丗万, 丈上丁丕世七丝丁丘:  val_4.丐丏七丌丕丗业且上());
        val_6.transform.SetParent(p:  this.levelSectionslayout.transform);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  true);
        this.丛丑丘上不丝丏丝专.Add(item:  val_6);
        this.丒东丏丕丏不业丑丞 = val_6;
        label_6:
        if(((-420678768) & 1) != 0)
        {
            goto label_15;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.stikedLevelSection.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  this.丑丘丙上丁丌一丗万, 丈上丁丕世七丝丁丘:  this.丒东丏丕丏不业丑丞.东丕七世专丑且丆世());
        this.levelSectionslayout.CollectWidgets();
        this.levelSectionslayout.Reposition();
        UnityEngine.Coroutine val_11 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PiggyPromotionView::丌东丘丅下丛三下丐()), 业丗七丕万万不丈丗:  1);
    }
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>> 丟丛丁丅丐与东东且(System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 上业丟世三与七七三)
    {
        var val_4;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>>();
        if(上业丟世三与七七三 == null)
        {
                return val_1;
        }
        
        List.Enumerator<T> val_2 = 上业丟世三与七七三.GetEnumerator();
        label_9:
        if(((-420468464) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == null)
        {
            goto label_9;
        }
        
        string val_6 = val_5 + 32;
        if((val_1.ContainsKey(key:  val_6)) != true)
        {
                System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_8 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            val_1.set_Item(key:  val_6, value:  null);
        }
        
        val_1.Item[val_6].Add(item:  val_5);
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private void 丐丆下丒丁丌丛丆世()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.levelSectionViewPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丛丑丘上不丝丏丝专.GetEnumerator();
        label_10:
        if(((-420299080) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_2.transform.SetParent(p:  this.levelSectionViewPool.transform);
        this.levelSectionViewPool.Return(万且万且丑丗且丌丆:  val_2);
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛丑丘上不丝丏丝专.Clear();
    }
    private void 一专业丟丙丁与丕丏()
    {
        var val_9;
        int val_10;
        ScrollViewHelper val_11;
        val_9 = 0;
        goto label_1;
        label_11:
        PGCompany.MainStore.七丄不下丘丏一丂丌 val_2 = this.丛丑丘上不丝丏丝专.Item[W21].东丕七世专丑且丆世();
        if(val_2.丐与下丁丁丞三丒与 != true)
        {
                if(val_2.万丄丅丛下丐丒丞上 <= this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄())
        {
            goto label_9;
        }
        
        }
        
        if(val_2.万丄丅丛下丐丒丞上 > this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄())
        {
            goto label_9;
        }
        
        val_9 = 1;
        label_1:
        val_10 = val_9 + 1;
        if(val_10 < this.丛丑丘上不丝丏丝专.Count)
        {
            goto label_11;
        }
        
        val_11 = this.scrollHelper;
        goto label_15;
        label_9:
        val_11 = this.scrollHelper;
        val_10 = UnityEngine.Mathf.Max(a:  0, b:  0);
        if((val_10 & 2147483648) == 0)
        {
                val_11.ScrollTo(不七丘丘丒万七丄丒:  this.丛丑丘上不丝丏丝专.Item[val_10].transform, 丌与丟丁万丝丞丄丏:  false);
            return;
        }
        
        label_15:
        val_11.ScrollToEnd(丌与丟丁万丝丞丄丏:  false);
    }
    public void U_GoToConnectScene()
    {
        PGCompany.丌不丞丐世丞三丘丌 val_8;
        if(this.丟万丗丅丌三专上丈 != null)
        {
                this.丟万丗丅丌三专上丈.Invoke();
        }
        
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丄丘丆丐丗不丌专丐();
        PGCompany.丌不丞丐世丞三丘丌 val_2 = null;
        val_8 = val_2;
        val_2 = new PGCompany.丌不丞丐世丞三丘丌();
        .Type = 11;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_2)) == null)
        {
                return;
        }
        
        val_8 = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public void U_Hide()
    {
        if(this.丟万丗丅丌三专上丈 == null)
        {
                return;
        }
        
        this.丟万丗丅丌三专上丈.Invoke();
    }
    public bool get_ActiveLastChanceBanner()
    {
        if(this._lastChanceBanner == 0)
        {
                return false;
        }
        
        if(this._lastChanceBanner != null)
        {
                return this._lastChanceBanner.activeSelf;
        }
        
        return this._lastChanceBanner.activeSelf;
    }
    public bool ShowLastChanceBanner()
    {
        if(this.丄七丟七丄世三丂丐 == true)
        {
                return false;
        }
        
        if((PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().与丁丂三下丛丘丁丅() == false) || (this.丑丘丙上丁丌一丗万 == null))
        {
                return false;
        }
        
        if(this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐() != false)
        {
                return false;
        }
        
        this.丄七丟七丄世三丂丐 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lastChanceBanner, 丏业丟一东丂东丘丛:  true);
        return false;
    }
    public void U_HideLastChanceBanner()
    {
        this.丄七丟七丄世三丂丐 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lastChanceBanner, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        var val_4;
        UnityEngine.MonoBehaviour val_5;
        UnityEngine.Vector3 val_2 = this.丒东丏丕丏不业丑丞.transform.position;
        UnityEngine.Vector3 val_3 = this.lastLevelSectionPoint.position;
        if(val_2.x > val_3.x)
        {
                val_4 = 1;
            val_5 = this.stikedLevelSection;
        }
        else
        {
                val_5 = this.stikedLevelSection;
            val_4 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
    }
    public PiggyPromotionView()
    {
        this.丛丑丘上不丝丏丝专 = new System.Collections.Generic.List<PGCompany.Piggy.PiggyLevelSectionView>();
    }
    private bool 丑丏丛丏丝丈丙一世(PGCompany.MainStore.七丄不下丘丏一丂丌 三丟东丕丄丄下下丑)
    {
        int val_3;
        var val_4;
        val_3 = 三丟东丕丄丄下下丑;
        if(三丟东丕丄丄下下丑.丐与下丁丁丞三丒与 != false)
        {
                val_4 = 0;
            return (bool)(val_3 <= this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄()) ? 1 : 0;
        }
        
        val_3 = 三丟东丕丄丄下下丑.万丄丅丛下丐丒丞上;
        return (bool)(val_3 <= this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄()) ? 1 : 0;
    }
    private void 丌东丘丅下丛三下丐()
    {
        if(this == 0)
        {
                return;
        }
        
        if(this.levelSectionslayout == 0)
        {
                return;
        }
        
        this.levelSectionslayout.Reposition();
    }

}
