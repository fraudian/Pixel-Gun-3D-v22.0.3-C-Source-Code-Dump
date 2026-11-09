using UnityEngine;
internal sealed class StorePromotionInfoPanel : PGBehaviour
{
    // Fields
    internal static System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丁与下万丄丑丐丗丐;
    private UILabel titleLabel;
    private UILabel additionalDescriptionLabel;
    private UILabel saleLabel;
    private UnityEngine.GameObject saleHolder;
    private MiniPoolMonoBehaviour cellViewPool;
    private WidgetLayout cellsLayout;
    private UIGrid cellsGrid;
    private StoreCharacterHelper _character;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> oldPrice;
    private System.Collections.Generic.List<BuyButtonUI> buyButtonUI;
    private PGCompany.TimerUI timerUI;
    private UnityEngine.GameObject _shootContainer;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> 丙七丂丂丏丘七丝丘;
    private PGCompany.东丑丆丗丏丐丟下丄 丈且丗丐与一万与与;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnShowInfo;
    
    // Methods
    private void OnEnable()
    {
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StorePromotionInfoPanel::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StorePromotionInfoPanel::业且三丙世丅丆丏世()));
    }
    private void OnDisable()
    {
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StorePromotionInfoPanel::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StorePromotionInfoPanel::业且三丙世丅丆丏世()));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        var val_3;
        this.丈且丗丐与一万与与 = 丐丆丝业丙丈下世丁;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shootContainer, 丏业丟一东丂东丘丛:  false);
        this.丝一丅丆三东丂丞七();
        this._character.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        List.Enumerator<T> val_1 = this.丈且丗丐与一万与与.GetEnumerator();
        label_13:
        if((336746832 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == null)
        {
            goto label_13;
        }
        
        if(val_4.不业丙丒丂丞下丆丙() == 10)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shootContainer, 丏业丟一东丂东丘丛:  true);
        }
        
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_4));
        goto label_13;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  true);
        if(StorePromotionInfoPanel.丁与下万丄丑丐丗丐 == null)
        {
                return;
        }
        
        StorePromotionInfoPanel.丁与下万丄丑丐丗丐.Invoke(obj:  this.丈且丗丐与一万与与);
    }
    internal void 丝一丅丆三东丂丞七()
    {
        this.世业丒万丘丆专丘丐();
        this.上东与丛丞下丈专丈();
        this.丝丂丕东专世丅丝丁();
    }
    private void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.cellViewPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丙七丂丂丏丘七丝丘.GetEnumerator();
        label_7:
        if((337056872 & 1) == 0)
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
        var val_9;
        var val_20;
        var val_21;
        UIGrid val_22;
        var val_23;
        if(this.丈且丗丐与一万与与 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  this.丈且丗丐与一万与与);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.additionalDescriptionLabel, 丕丗丘丑丛与丑业丒:  this.丈且丗丐与一万与与);
        decimal val_2 = this.丈且丗丐与一万与与.万丏丛上丌丏业三不();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.saleLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2555"), arg0:  PGCompany.MainStore.丗丝丙丏不丄七丌一.丛丗丈丙上业丟与丞(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}, 丈丞丄世丞丂丌丁丛:  5)));
        decimal val_5 = this.丈且丗丐与一万与与.万丏丛上丌丏业三不();
        val_20 = null;
        val_20 = null;
        int val_19 = val_5.lo;
        val_19 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_19, mid = val_5.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.saleHolder, 丏业丟一东丂东丘丛:  val_19);
        List.Enumerator<T> val_7 = this.丈且丗丐与一万与与.GetEnumerator();
        label_25:
        if((337318336 & 1) == 0)
        {
            goto label_15;
        }
        
        PGCompany.InventoryItemView val_11 = this.cellViewPool.Get<PGCompany.InventoryItemView>();
        val_11.Setup(丈丄不七三万丄丁不:  val_9.丐丏七丌丕丗业且上());
        if(this.cellsLayout != null)
        {
                (this.cellsLayout == 0) ? 0 : this.cellsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_11);
        }
        
        this.丙七丂丂丏丘七丝丘.Add(item:  val_11);
        val_11.transform.SetAsLastSibling();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_11, 丏业丟一东丂东丘丛:  true);
        goto label_25;
        label_15:
        val_21 = public System.Void List.Enumerator<PGCompany.三东丏不丗世丅丌丄>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.cellsLayout != null)
        {
                val_21 = 0;
            this.cellsLayout.Reposition();
        }
        
        if(this.cellsGrid != null)
        {
                val_22 = this.cellsGrid;
        }
        else
        {
                val_22 = 0;
        }
        
        if(val_22 != 0)
        {
                this.cellsGrid.repositionNow = true;
        }
        
        decimal val_15 = this.丈且丗丐与一万与与.丅万七一丌丞丙不业();
        val_23 = null;
        val_23 = null;
        int val_20 = val_15.lo;
        val_20 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_20, mid = val_15.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<PGCompany.InventoryItemView>(不丗上三丛丒上东丑:  this.oldPrice, 丏业丟一东丂东丘丛:  val_20);
        this.oldPrice.ForEach(action:  new System.Action<PGCompany.InventoryItemView>(object:  this, method:  System.Void StorePromotionInfoPanel::一东丗上世丙丆不丄(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)));
        this.buyButtonUI.ForEach(action:  new System.Action<BuyButtonUI>(object:  this, method:  System.Void StorePromotionInfoPanel::不丈万不与世业丟业(BuyButtonUI 三丟东丕丄丄下下丑)));
    }
    private void 丝丂丕东专世丅丝丁()
    {
        object val_4;
        var val_5;
        UnityEngine.MonoBehaviour val_6;
        val_4 = this;
        int val_4 = this.丈且丗丐与一万与与.下丒丗丄丌丘不丑丘();
        val_4 = val_4 - PixelTime.丙丅丅业丟丁世丁丗();
        if(val_4 >= 1)
        {
                this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_4, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void StorePromotionInfoPanel::丝丂丕东专世丅丝丁()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_4 = this.timerUI;
            val_5 = 1;
            val_6 = val_4;
        }
        else
        {
                val_6 = this.timerUI;
            val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  false);
    }
    public void U_Purchase()
    {
        this.丛丁丏丏丄下丈下下();
    }
    private void 丛丁丏丏丄下丈下下()
    {
        bool val_1 = this.丈且丗丐与一万与与.且丏三丞丝丟丘丅丕();
        if(this.丈且丗丐与一万与与 == null)
        {
            goto label_1;
        }
        
        if(val_1 == false)
        {
            goto label_2;
        }
        
        label_3:
        this.丈且丗丐与一万与与.丈丙且一万丟丕万下();
        return;
        label_1:
        if(val_1 == true)
        {
            goto label_3;
        }
        
        label_2:
        if((this.丈且丗丐与一万与与 != null) && (this.丈且丗丐与一万与与.业东丅东丌上丗丑不() != 10015))
        {
                if(this.丈且丗丐与一万与与.业东丅东丌上丗丑不() != 11015)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  this.丈且丗丐与一万与与, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
                return;
        }
        
        }
        
        }
        
        this = this.丈且丗丐与一万与与;
        this.丏丝丘七丕与世丅丆();
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
    public StorePromotionInfoPanel()
    {
        this.丙七丂丂丏丘七丝丘 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
    }
    private void 一东丗上世丙丆不丄(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.Setup(丈丄不七三万丄丁不:  this.丈且丗丐与一万与与.丄丌丛丑万且丞丙丏());
    }
    private void 不丈万不与世业丟业(BuyButtonUI 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.Setup(丒世丘丘上丆丝东丞:  this.丈且丗丐与一万与与);
    }

}
