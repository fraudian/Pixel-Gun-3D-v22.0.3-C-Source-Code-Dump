using UnityEngine;
internal sealed class DoublePromotionView : MainStorePromotionView
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
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UnityEngine.GameObject val_26;
        PGCompany.东丑丆丗丏丐丟下丄 val_27;
        var val_28;
        var val_30;
        var val_32;
        var val_33;
        val_26 = this;
        this.Setup(且丘丏丁丑与丙与丁:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._confirmWindow, 丏业丟一东丂东丘丛:  false);
        PGCompany.不万丑丗丕与丐丒丏 val_2 = PGCompany.专三不不三三一丗丅.丑七不且上丗丁一世().丙与丞上丅上且且业();
        if(val_2 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_3 = val_2.与丐七上丝丛上下丁();
        PGCompany.东丑丆丗丏丐丟下丄 val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_3);
        val_27 = System.Linq.Enumerable.LastOrDefault<PGCompany.东丑丆丗丏丐丟下丄>(source:  val_3);
        if(val_4 == null)
        {
                return;
        }
        
        if(val_27 == null)
        {
                return;
        }
        
        this._timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_2.世丘下上丐丅丒丂丏(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        MainStorePromotionView val_7 = this.promoViews.Item[0];
        MainStorePromotionView val_8 = this.promoViews.Item[1];
        StoreCharacterHelper val_9 = this._characters.Item[0];
        val_9.丗丟丞丈与丗三丙世(丞丛丈丝不丛丒丌丐:  val_9, 且丘丏丁丑与丙与丁:  val_4);
        StoreCharacterHelper val_10 = this._characters.Item[1];
        val_10.丗丟丞丈与丗三丙世(丞丛丈丝不丛丒丌丐:  val_10, 且丘丏丁丑与丙与丁:  val_27);
        val_28 = null;
        val_28 = null;
        if((DoublePromotionView.<>c.<>9__8_0) == null)
        {
            goto label_17;
        }
        
        label_36:
        System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_26 = DoublePromotionView.<>c.<>9__8_0;
        val_26 = val_4.Exists(match:  val_26);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shootButtons.Item[0], 丏业丟一东丂东丘丛:  val_26);
        val_30 = null;
        val_30 = null;
        if((DoublePromotionView.<>c.<>9__8_1) == null)
        {
            goto label_24;
        }
        
        label_39:
        System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_27 = DoublePromotionView.<>c.<>9__8_1;
        val_27 = val_27.Exists(match:  val_27);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shootButtons.Item[1], 丏业丟一东丂东丘丛:  val_27);
        int val_17 = val_27.丆丞上丛丂一业丟丕() - val_4.丆丞上丛丂一业丟丕();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._diffSalesLabel, 丏业丟一东丂东丘丛:  (val_17 > 0) ? 1 : 0);
        val_27 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10541");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._diffSalesLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_27, arg0:  val_17));
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_26 = this._3dCameraGO;
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_26, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        return;
        label_17:
        val_32 = 1152921505284374528;
        goto label_34;
        label_24:
        val_33 = 1152921505284374528;
        goto label_37;
        label_34:
        DoublePromotionView.<>c.<>9__8_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  DoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DoublePromotionView.<>c::丟丛七丄东世万丞丒(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
        if(val_4 != null)
        {
            goto label_36;
        }
        
        goto label_36;
        label_37:
        DoublePromotionView.<>c.<>9__8_1 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  DoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DoublePromotionView.<>c::丆丘丐丂业丑世上丈(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
        if(val_27 != null)
        {
            goto label_39;
        }
        
        goto label_39;
    }
    private void 丗丟丞丈与丗三丙世(StoreCharacterHelper 丞丛丈丝不丛丒丌丐, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        if(丞丛丈丝不丛丒丌丐 != null)
        {
                丞丛丈丝不丛丒丌丐.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                0.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        }
        
        丞丛丈丝不丛丒丌丐.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        丞丛丈丝不丛丒丌丐.丂丄丗丝丌丌丝世丘(丈丄不七三万丄丁不:  且丘丏丁丑与丙与丁, 万下万丘丌丄丝丐丆:  true, 丙万丘丗丅万丐一世:  true);
    }
    public void U_CheckConfirmByPurchaseFirstPromotion()
    {
        PGCompany.不万丑丗丕与丐丒丏 val_2 = PGCompany.专三不不三三一丗丅.丑七不且上丗丁一世().丙与丞上丅上且且业();
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.专丙丑丈丝专一与不() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._confirmWindow, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        this._firstMainStorePromotionView.U_Purchase();
    }
    public void U_HideConfirmWindow()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._confirmWindow, 丏业丟一东丂东丘丛:  false);
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_2 = null;
        if((DoublePromotionView.<>c.<>9__12_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.promoViews.ForEach(action:  DoublePromotionView.<>c.<>9__12_0);
        return this.丝一丅丆三东丂丞七();
        label_3:
        DoublePromotionView.<>c.<>9__12_0 = new System.Action<MainStorePromotionView>(object:  DoublePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DoublePromotionView.<>c::丞专且七专丈丁丄丛(MainStorePromotionView 丁世丛业丟下丕三丟));
        if(this.promoViews != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    public DoublePromotionView()
    {
        this.promoViews = new System.Collections.Generic.List<MainStorePromotionView>();
        this._characters = new System.Collections.Generic.List<StoreCharacterHelper>();
        this._shootButtons = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
