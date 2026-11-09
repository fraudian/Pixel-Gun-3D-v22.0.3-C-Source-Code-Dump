using UnityEngine;
internal sealed class NoviceDoublePromotionView : MainStorePromotionView
{
    // Fields
    private System.Collections.Generic.List<MainStorePromotionView> promoViews;
    private PGCompany.TimerUI _timerUI;
    private UILabel _diffSalesLabel;
    private UnityEngine.GameObject _confirmWindow;
    private MainStorePromotionView _firstMainStorePromotionView;
    private System.Collections.Generic.List<StoreCharacterHelper> _characters;
    private UnityEngine.GameObject _3dCameraGO;
    private System.Collections.Generic.List<UnityEngine.GameObject> _shootButtons;
    private GuiApplyersGroup _guiApplyersGroup;
    private System.Collections.Generic.List<ItemSelectorView> _selectors;
    private PGCompany.东丑丆丗丏丐丟下丄 丟丙一东不丄不丝丂;
    private readonly System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 上丞且世丒上丘世业;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        ItemSelectorView val_35;
        PGCompany.丙一丟与且丞丏丈一 val_36;
        int val_37;
        var val_38;
        var val_40;
        var val_42;
        var val_43;
        val_35 = this;
        this.Setup(且丘丏丁丑与丙与丁:  0);
        this.丟丙一东不丄不丝丂 = 且丘丏丁丑与丙与丁;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._confirmWindow, 丏业丟一东丂东丘丛:  false);
        if(且丘丏丁丑与丙与丁.七丈丒丒下下且万与() != null)
        {
                val_36 = 0;
        }
        
        val_37 = PGCompany.且丝丑上丛丁丕东丕.上丑丕丅与丟上丘业(一丗与一专丙丙丅丄:  val_36);
        PGCompany.上业七丕丒丂七丐丄 val_6 = PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丟丌业丝丝丈一一下(丗丟丁丐与下丙丕丛:  val_37);
        if(val_6 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_7 = val_6.与丐七上丝丛上下丁();
        PGCompany.东丑丆丗丏丐丟下丄 val_8 = System.Linq.Enumerable.FirstOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_7);
        val_37 = System.Linq.Enumerable.LastOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_7);
        if(val_8 == null)
        {
                return;
        }
        
        if(val_37 == null)
        {
                return;
        }
        
        string val_10 = val_6.丒上丒丅丌丄上丟专();
        this._timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_6.世丘下上丐丅丒丂丏(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        MainStorePromotionView val_12 = this.promoViews.Item[0];
        MainStorePromotionView val_13 = this.promoViews.Item[1];
        StoreCharacterHelper val_14 = this._characters.Item[0];
        val_14.丗丟丞丈与丗三丙世(丞丛丈丝不丛丒丌丐:  val_14, 且丘丏丁丑与丙与丁:  val_8);
        StoreCharacterHelper val_15 = this._characters.Item[1];
        val_15.丗丟丞丈与丗三丙世(丞丛丈丝不丛丒丌丐:  val_15, 且丘丏丁丑与丙与丁:  val_37);
        val_38 = null;
        val_38 = null;
        if((NoviceDoublePromotionView.<>c.<>9__11_0) == null)
        {
            goto label_22;
        }
        
        label_45:
        System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_35 = NoviceDoublePromotionView.<>c.<>9__11_0;
        val_35 = val_8.Exists(match:  val_35);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shootButtons.Item[0], 丏业丟一东丂东丘丛:  val_35);
        val_40 = null;
        val_40 = null;
        if((NoviceDoublePromotionView.<>c.<>9__11_1) == null)
        {
            goto label_29;
        }
        
        label_48:
        System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_36 = NoviceDoublePromotionView.<>c.<>9__11_1;
        val_36 = val_37.Exists(match:  val_36);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shootButtons.Item[1], 丏业丟一东丂东丘丛:  val_36);
        int val_22 = val_37.丆丞上丛丂一业丟丕() - val_8.丆丞上丛丂一业丟丕();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._diffSalesLabel, 丏业丟一东丂东丘丛:  (val_22 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._diffSalesLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10541"), arg0:  val_22));
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this._3dCameraGO, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_37 = this.promoViews;
        MainStorePromotionView val_30 = val_37.Item[0];
        val_30.丕丈下丑下万丆世丙(东丑丈丅丌万东丅且:  this._selectors.Item[0], 丟七下丝世七世丈丄:  val_30);
        val_35 = this._selectors.Item[1];
        MainStorePromotionView val_32 = this.promoViews.Item[1];
        val_32.丕丈下丑下万丆世丙(东丑丈丅丌万东丅且:  val_35, 丟七下丝世七世丈丄:  val_32);
        return;
        label_22:
        val_42 = 1152921505284374528;
        goto label_43;
        label_29:
        val_43 = 1152921505284374528;
        goto label_46;
        label_43:
        NoviceDoublePromotionView.<>c.<>9__11_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  NoviceDoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NoviceDoublePromotionView.<>c::丈丌七丒专丄上丌丏(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
        if(val_8 != null)
        {
            goto label_45;
        }
        
        goto label_45;
        label_46:
        NoviceDoublePromotionView.<>c.<>9__11_1 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  NoviceDoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NoviceDoublePromotionView.<>c::不七丛丘与世一与丆(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
        if(val_37 != null)
        {
            goto label_48;
        }
        
        goto label_48;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this._selectors.Item[0].add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NoviceDoublePromotionView::丂东丗下丟世丁丅丐()));
        this._selectors.Item[1].add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NoviceDoublePromotionView::丑东丐业且丛业三丗()));
    }
    protected override void OnDisable()
    {
        this._selectors.Item[0].remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NoviceDoublePromotionView::丂东丗下丟世丁丅丐()));
        this._selectors.Item[1].remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NoviceDoublePromotionView::丑东丐业且丛业三丗()));
        this.OnDisable();
    }
    private void 丗丟丞丈与丗三丙世(StoreCharacterHelper 丞丛丈丝不丛丒丌丐, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_18;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_20;
        var val_22;
        var val_25;
        var val_26;
        if(丞丛丈丝不丛丒丌丐 != null)
        {
                丞丛丈丝不丛丒丌丐.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                0.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        }
        
        丞丛丈丝不丛丒丌丐.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        val_18 = null;
        val_18 = null;
        val_20 = NoviceDoublePromotionView.<>c.<>9__14_0;
        if(val_20 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_1 = null;
            val_20 = val_1;
            val_1 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  NoviceDoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NoviceDoublePromotionView.<>c::世丄东且世丈且丝上(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
            NoviceDoublePromotionView.<>c.<>9__14_0 = val_20;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = System.Linq.Enumerable.OrderByDescending<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(source:  且丘丏丁丑与丙与丁, keySelector:  val_1).GetEnumerator();
        val_22 = 1152921504686346240;
        label_29:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_19;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        T val_8 = val_4.Current;
        if(val_8.不业丙丒丂丞下丆丙() == 10)
        {
            goto label_29;
        }
        
        丞丛丈丝不丛丒丌丐.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_8));
        goto label_29;
        label_19:
        val_25 = 0;
        val_26 = 0;
        if(val_4 == null)
        {
            
        }
        else
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_4.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_26 = ???;
        val_25 = ???;
        val_22 = ???;
    }
    public void U_CheckConfirmByPurchaseFirstPromotion()
    {
        UnityEngine.GameObject val_8;
        PGCompany.丙一丟与且丞丏丈一 val_9;
        val_8 = this;
        if(this.丟丙一东不丄不丝丂.七丈丒丒下下且万与() != null)
        {
                val_9 = 0;
        }
        
        PGCompany.上业七丕丒丂七丐丄 val_6 = PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丟丌业丝丝丈一一下(丗丟丁丐与下丙丕丛:  PGCompany.且丝丑上丛丁丕东丕.上丑丕丅与丟上丘业(一丗与一专丙丙丅丄:  val_9));
        if(val_6 == null)
        {
                return;
        }
        
        if(val_6.专丙丑丈丝专一与不() != false)
        {
                val_8 = this._confirmWindow;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        val_8 = this._firstMainStorePromotionView;
        val_8.U_Purchase();
    }
    public void U_HideConfirmWindow()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._confirmWindow, 丏业丟一东丂东丘丛:  false);
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_2 = null;
        if((NoviceDoublePromotionView.<>c.<>9__17_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.promoViews.ForEach(action:  NoviceDoublePromotionView.<>c.<>9__17_0);
        return this.丝一丅丆三东丂丞七();
        label_3:
        NoviceDoublePromotionView.<>c.<>9__17_0 = new System.Action<MainStorePromotionView>(object:  NoviceDoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NoviceDoublePromotionView.<>c::七七丂世丑丁与丑且(MainStorePromotionView 丁世丛业丟下丕三丟));
        if(this.promoViews != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 丕丈下丑下万丆世丙(ItemSelectorView 东丑丈丅丌万东丅且, MainStorePromotionView 丟七下丝世七世丈丄)
    {
        T val_6;
        var val_7;
        T[] val_2 = 丟七下丝世七世丈丄.transform.GetComponentsInChildren<SelectableButton>();
        val_7 = 0;
        goto label_3;
        label_7:
        val_6 = val_2[0];
        东丑丈丅丌万东丅且.AddNewButton(丟丂丄丕下业丗丛丂:  val_6);
        val_7 = 1;
        label_3:
        if(val_7 < val_2.Length)
        {
            goto label_7;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<SelectableButton>(丑东与丅丐丅丂丞业:  val_2)) != false)
        {
                return;
        }
        
        bool val_5 = 东丑丈丅丌万东丅且.SelectButton(丕丐不丑三上万丝东:  val_2.Item[0]);
    }
    private void 丂东丗下丟世丁丅丐()
    {
        this.丁三丁一丄丑丁丂与(丂丘与丌丗东与业下:  0);
    }
    private void 丑东丐业且丛业三丗()
    {
        this.丁三丁一丄丑丁丂与(丂丘与丌丗东与业下:  1);
    }
    private void 丁三丁一丄丑丁丂与(int 丂丘与丌丗东与业下)
    {
        var val_10;
        if(丂丘与丌丗东与业下 > 1)
        {
                return;
        }
        
        val_10 = this._selectors.Item[丂丘与丌丗东与业下];
        if(val_10.丝丒三世丘丗丐丆专() == 0)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_4 = val_10.丕丟丐丈丐丄丌三丐();
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_15:
        if(val_4.不业丙丒丂丞下丆丙() != 10)
        {
                return;
        }
        
        this._characters.Item[丂丘与丌丗东与业下].东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_4);
        return;
        label_8:
        ItemSelectableButton val_7 = val_10.丝丒三世丘丗丐丆专();
        if(val_7 == null)
        {
                return;
        }
        
        val_10 = val_7.业丗丗丒一丆东上东();
        if(val_10.Context != null)
        {
            goto label_15;
        }
    
    }
    internal void 丒与不丕三七一丘东(PGCompany.InventoryItemView 专万一万丌丞丛丟丛, int 东丑丞丛丆丝丅不三)
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_11;
        if(东丑丞丛丆丝丅不三 > 1)
        {
                return;
        }
        
        if(专万一万丌丞丛丟丛 == 0)
        {
                return;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_2 = 专万一万丌丞丛丟丛.ItemParams;
        if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_2)) == false)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_4 = this.上丞且世丒上丘世业.Item[东丑丞丛丆丝丅不三];
        if(val_4 == null)
        {
            goto label_10;
        }
        
        if(val_2 != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        if((val_2.Equals(丘丛丏丘丝七世七丅:  val_4.丑丐丙丄丅世世丑丒())) == false)
        {
            goto label_12;
        }
        
        if(专万一万丌丞丛丟丛 == null)
        {
            goto label_13;
        }
        
        val_11 = 专万一万丌丞丛丟丛.Context;
        goto label_14;
        label_10:
        if(val_2 != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_13:
        val_11 = 0.Context;
        label_14:
        this.丏丆丂丒丆丈七业丁(下丅丙一丂丗丅丝七:  val_11, 不丟东一丞丌丂丗七:  专万一万丌丞丛丟丛.丙丕丄万业与下七丁());
        label_12:
        this.上丞且世丒上丘世业.set_Item(index:  东丑丞丛丆丝丅不三, value:  专万一万丌丞丛丟丛.Context);
    }
    private void 丏丆丂丒丆丈七业丁(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七, int 不丟东一丞丌丂丗七)
    {
        PGCompany.万丞丘与丕丞下万丌.万与东世与丒丌东丕(丆丏七丟不丒与七专:  this.transform, 下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 东业丒一丟丝下丌丄:  不丟东一丞丌丂丗七, 业万丒丌丗丄东丁丕:  false, 丟丏七下业丄丟丐丗:  false, 丒不业且丄丅世世下:  false);
    }
    public NoviceDoublePromotionView()
    {
        System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
        if(val_1 != null)
        {
                val_1.Add(item:  0);
        }
        else
        {
                val_1.Add(item:  0);
        }
        
        val_1.Add(item:  0);
        this.上丞且世丒上丘世业 = val_1;
    }

}
