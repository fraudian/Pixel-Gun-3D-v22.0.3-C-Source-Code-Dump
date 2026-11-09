using UnityEngine;
internal class MainStoreSectionView : PGBehaviour
{
    // Fields
    public System.Action<PGCompany.东丑丆丗丏丐丟下丄> showInfoRequired;
    private int minCountForTitle_WithTimerOrTags;
    private UILabel nameLabel;
    private PGCompany.TimerUI timerUi;
    private UIWidget mainWidget;
    private System.Collections.Generic.List<UIRect> acnchoredToMainPanel;
    private WidgetLayout widgetLayout_1;
    private GridLayout gridLayout;
    private WidgetLayout widgetLayout_2;
    private TagSpecificObject tagSpecificObject;
    private GuiApplyersGroup guiApplyersGroup;
    private int gridOffset;
    private MiniPoolGroup 丏丗丄丐业丂上且丁;
    private System.Collections.Generic.List<MainStorePromotionView> 丆丈三丅丌上丂与万;
    private PGCompany.MainStore.世专丟丕丝丝专东一 丕丘一上丞丂丆丑丏;
    
    // Properties
    public MiniPoolGroup 丅丆专上丌丅上丆下 { get; }
    internal System.Collections.Generic.List<MainStorePromotionView> 三丅丅丂丙不万丅下 { get; }
    internal PGCompany.MainStore.世专丟丕丝丝专东一 不专与丂丂下丅丞丞 { get; }
    
    // Methods
    public MiniPoolGroup get_MiniPoolGroup()
    {
        if(this.丏丗丄丐业丂上且丁 != 0)
        {
                return (MiniPoolGroup)this.丏丗丄丐业丂上且丁;
        }
        
        MiniPoolGroup val_3 = new UnityEngine.GameObject(name:  "MiniPoolGroup").AddComponent<MiniPoolGroup>();
        this.丏丗丄丐业丂上且丁 = val_3;
        val_3.transform.SetParent(p:  this.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丏丗丄丐业丂上且丁.transform);
        return (MiniPoolGroup)this.丏丗丄丐业丂上且丁;
    }
    internal System.Collections.Generic.List<MainStorePromotionView> 丁七丙世丛丂七丑丒()
    {
        return (System.Collections.Generic.List<MainStorePromotionView>)this.丆丈三丅丌上丂与万;
    }
    internal PGCompany.MainStore.世专丟丕丝丝专东一 丙业丆丘万丙专万丟()
    {
        return (PGCompany.MainStore.世专丟丕丝丝专东一)this.丕丘一上丞丂丆丑丏;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万, MiniPoolGroup 丁上丂丈丒下且丏业)
    {
        this.丕丘一上丞丂丆丑丏 = 丞且丌三三万七丛万;
        this.丏丗丄丐业丂上且丁 = 丁上丂丈丒下且丏业;
        this.下不丅丕东丏丝丝丆();
    }
    private void 下不丅丕东丏丝丝丆()
    {
        var val_5;
        if(this.guiApplyersGroup != 0)
        {
                val_5 = this.丕丘一上丞丂丆丑丏.丅上万丛一丐上上丕();
            if((this.guiApplyersGroup & 1) == 0)
        {
                val_5 = "MainStoreSection_" + this.丕丘一上丞丂丆丑丏.丙业丆丘万丙专万丟();
        }
        
        }
        
        this.上东与丛丞下丈专丈();
    }
    private void 上东与丛丞下丈专丈()
    {
        var val_6;
        var val_37;
        var val_38;
        TagSystem.三与下丘七丘丌丏丄 val_39;
        var val_40;
        var val_41;
        var val_42;
        UnityEngine.Object val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_52;
        this.世业丒万丘丆专丘丐();
        val_37 = 1152921505630273536;
        val_38 = 1152921537159741584;
        PGCompany.东丑丒丗一丞下丙丙<T> val_2 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        val_39 = 0;
        if((this.丕丘一上丞丂丆丑丏.丗不丞一且丟丈丈丗(专丂丕丗丗东世丞下: ref  val_2, 三不丟丈丐丟丏专丁:  val_39, 丁丏且丝丞丙万丗与:  3)) == false)
        {
            goto label_86;
        }
        
        List.Enumerator<T> val_4 = val_2.GetEnumerator();
        val_40 = 1152921537159756944;
        val_41 = 1152921537159757968;
        goto label_7;
        label_48:
        string val_7 = val_6.丐丏七丌丕丗业且上();
        val_42 = val_7.丄下丕丗一丙丑丝一();
        val_43 = this.MiniPoolGroup.Get<MainStorePromotionView>(丛丄业丕且丗下一万:  ((val_42.Contains(value:  "_Grid")) != true) ? (val_42) : "MainStorePromotion/MainStorePromo_Grid");
        if(val_43 == 0)
        {
                val_43 = this.MiniPoolGroup.Get<MainStorePromotionView>(丛丄业丕且丗下一万:  "MainStorePromotion/MainStorePromo_Layout");
        }
        
        this.丆丈三丅丌上丂与万.Add(item:  val_43);
        if((val_7.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view.type.grid")) == false)
        {
            goto label_21;
        }
        
        val_44 = val_37;
        val_45 = "view.type.grid";
        val_46 = "_Grid";
        val_47 = val_41;
        val_48 = val_40;
        val_49 = 0;
        val_43.transform.SetParent(p:  this.gridLayout.transform);
        goto label_38;
        label_21:
        val_44 = val_37;
        if((val_7.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view.type.layout2")) == false)
        {
            goto label_28;
        }
        
        val_45 = "view.type.grid";
        val_46 = "_Grid";
        val_47 = val_41;
        val_48 = val_40;
        val_49 = 0;
        val_43.transform.SetParent(p:  this.widgetLayout_2.transform);
        if(this.widgetLayout_2 == null)
        {
            goto label_38;
        }
        
        val_49 = 0;
        (this.widgetLayout_2 == 0) ? 0 : this.widgetLayout_2.AddElement(丅丆东丏丙丝丅丆丟:  val_43);
        goto label_38;
        label_28:
        val_45 = "view.type.grid";
        val_46 = "_Grid";
        val_47 = val_41;
        val_48 = val_40;
        val_49 = 0;
        val_43.transform.SetParent(p:  this.widgetLayout_1.transform);
        if(this.widgetLayout_1 != null)
        {
                val_49 = 0;
            (this.widgetLayout_1 == 0) ? 0 : this.widgetLayout_1.AddElement(丅丆东丏丙丝丅丆丟:  val_43);
        }
        
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_43, 丏业丟一东丂东丘丛:  true);
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_30 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStoreSectionView::丏丁丕丘一东丝丕丙(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁));
        System.Delegate val_31 = System.Delegate.Combine(a:  val_17.万世三丈专七下丒业, b:  null);
        val_51 = null;
        if(val_31 == null)
        {
            goto label_43;
        }
        
        val_40 = val_48;
        if(null == val_51)
        {
            goto label_44;
        }
        
        val_41 = val_47;
        val_50 = 0;
        val_51 = null;
        goto label_45;
        label_43:
        val_40 = val_48;
        label_44:
        val_41 = val_47;
        label_45:
        val_17.万世三丈专七下丒业 = val_31;
        val_37 = val_44;
        val_38 = 1152921537159741584;
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_33 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStoreSectionView::七一丄丑七七一丑东(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁));
        val_39 = 0;
        if(((System.Delegate.Combine(a:  val_17.丐专专丑丂东一丒丅, b:  null)) != null) && (null != null))
        {
                val_39 = 0;
            val_52 = 0;
        }
        
        val_17.丐专专丑丂东一丒丅 = val_52;
        label_7:
        if((295936704 & 1) != 0)
        {
            goto label_48;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_86:
        PGCompany.东丑丒丗一丞下丙丙<T> val_35 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        if(this.widgetLayout_1 != null)
        {
                this.widgetLayout_1.Reposition();
        }
        
        if(this.gridLayout != null)
        {
                this.gridLayout.Reposition();
        }
        
        if(this.widgetLayout_2 != null)
        {
                this.widgetLayout_2.Reposition();
        }
        
        this.丙丕上世丈丈七丒丙();
        this.万丝业与上丅丕丟上();
    }
    internal void 世业丒万丘丆专丘丐()
    {
        var val_3;
        var val_12;
        var val_13;
        var val_14;
        List.Enumerator<T> val_1 = this.丆丈三丅丌上丂与万.GetEnumerator();
        label_9:
        if((296238160 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_5 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStoreSectionView::丏丁丕丘一东丝丕丙(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁));
        val_13 = null;
        if(((System.Delegate.Remove(source:  X21, value:  null)) != null) && (null != val_13))
        {
                val_13 = null;
            val_12 = 0;
        }
        
        mem2[0] = val_12;
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_8 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStoreSectionView::七一丄丑七七一丑东(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁));
        if(((System.Delegate.Remove(source:  X21, value:  null)) != null) && (null != null))
        {
                val_14 = 0;
        }
        
        mem2[0] = val_14;
        this.MiniPoolGroup.Return(丛丄业丕且丗下一万:  val_4.name, 万且万且丑丗且丌丆:  val_4);
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丆丈三丅丌上丂与万.Clear();
        if(this.widgetLayout_1 != null)
        {
                this.widgetLayout_1.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        if(this.gridLayout != null)
        {
                this.gridLayout.Reposition();
        }
        
        if(this.widgetLayout_2 == null)
        {
                return;
        }
        
        this.widgetLayout_2.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    private void 丙丕上世丈丈七丒丙()
    {
        float val_19;
        float val_20;
        float val_21;
        val_19 = this.widgetLayout_1.GetSize();
        if(val_19 > 0f)
        {
                val_19 = val_19 + (float)this.gridOffset;
        }
        
        UnityEngine.Vector3 val_3 = this.widgetLayout_1.transform.localPosition;
        UnityEngine.Vector3 val_5 = this.gridLayout.transform.localPosition;
        float val_19 = 0f;
        val_19 = val_19 + val_19;
        this.gridLayout.transform.localPosition = new UnityEngine.Vector3() {x = val_19, y = 0f, z = 0f};
        UnityEngine.Vector3 val_8 = this.gridLayout.transform.localPosition;
        UnityEngine.Vector3 val_10 = this.widgetLayout_1.transform.localPosition;
        UnityEngine.Vector2 val_11 = this.gridLayout.Size;
        val_11.x = 0f + val_11.x;
        val_20 = val_11.x;
        this.widgetLayout_2.transform.localPosition = new UnityEngine.Vector3() {x = val_20, y = 0f, z = 0f};
        val_21 = this.widgetLayout_2.GetSize();
        if(val_21 > 0f)
        {
                val_20 = (float)this.gridOffset;
            val_21 = val_21 + val_20;
        }
        
        UnityEngine.Vector2 val_14 = this.gridLayout.Size;
        val_14.x = val_19 + val_14.x;
        val_14.x = val_21 + val_14.x;
        this.mainWidget.width = (int)val_14.x;
        this.mainWidget.ResetAndUpdateAnchors();
        List.Enumerator<T> val_15 = this.acnchoredToMainPanel.GetEnumerator();
        label_24:
        if((296502728 & 1) == 0)
        {
            goto label_22;
        }
        
        string val_16 = 0.丐丏七丌丕丗业且上();
        if(val_16 == null)
        {
            goto label_24;
        }
        
        val_16.ResetAndUpdateAnchors();
        goto label_24;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Coroutine val_18 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void MainStoreSectionView::丌丘丐丏万丕丆下丌()), 业丗七丕万万不丈丗:  1);
        if(this.widgetLayout_1 != null)
        {
                this.widgetLayout_1.Reposition();
        }
        
        if(this.gridLayout != null)
        {
                this.gridLayout.Reposition();
        }
        
        if(this.widgetLayout_2 == null)
        {
                return;
        }
        
        this.widgetLayout_2.Reposition();
    }
    internal void 业不不且丐且与不与()
    {
        List.Enumerator<T> val_1 = this.丆丈三丅丌上丂与万.GetEnumerator();
        label_4:
        if((296725384 & 1) == 0)
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
    }
    private void 丏丁丕丘一东丝丕丙(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        var val_5;
        if(丐丆丝业丙丈下世丁 == null)
        {
                return;
        }
        
        val_5 = PGCompany.MainStore.三一丒丞三专丗不丛.丑七不且上丗丁一世();
        bool val_4 = val_5.东七丙三丌丘一不丙(丙丐万丗丁丏丞专丄:  this.丕丘一上丞丂丆丑丏.丙业丆丘万丙专万丟(), 一丗与一专丙丙丅丄:  丐丆丝业丙丈下世丁.七丈丒丒下下且万与(), 丅丁三世丝三丞专世:  true);
        if(this.showInfoRequired == null)
        {
                return;
        }
        
        this.showInfoRequired.Invoke(obj:  丐丆丝业丙丈下世丁);
    }
    private void 七一丄丑七七一丑东(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        if((System.String.op_Equality(a:  this.丕丘一上丞丂丆丑丏.丙业丆丘万丙专万丟(), b:  "gems")) != true)
        {
                if((System.String.op_Equality(a:  this.丕丘一上丞丂丆丑丏.丙业丆丘万丙专万丟(), b:  "coins")) == false)
        {
                return;
        }
        
        }
        
        this.万丝业与上丅丕丟上();
    }
    private void 万丝业与上丅丕丟上()
    {
        PGCompany.TimerUI val_18;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  this.丕丘一上丞丂丆丑丏.东丙上东业丆不丟丘());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUi, 丏业丟一东丂东丘丛:  false);
        if(this.丕丘一上丞丂丆丑丏.丟丈丅丙一万三丅丒() >= 1)
        {
                System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_3 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
            bool val_4 = this.丕丘一上丞丂丆丑丏.丗不丞一且丟丈丈丗(专丂丕丗丗东世丞下: ref  val_3, 三不丟丈丐丟丏专丁:  0, 丁丏且丝丞丙万丗与:  3);
            this.timerUi.prefixString = PGCompany.MainStore.丗丝丙丏不丄七丌一.丕丈丂丟万东且丕一(丛丝丑丆万不丄丗丏:  this.丕丘一上丞丂丆丑丏.与不丞丑七丘丁丂丛(), 七丆丝不丈丗业丏万:  PGCompany.MainStore.丗丝丙丏不丄七丌一.三丐丏专万上丕不丒(三丟丕世丗丂丙丅专:  val_3));
            val_18 = this.timerUi;
            if(val_18 != null)
        {
                val_18.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.丕丘一上丞丂丆丑丏.丟丈丅丙一万三丅丒(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void MainStoreSectionView::下不丅丕东丏丝丝丆()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_18 = this.timerUi;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.tagSpecificObject != null)
        {
                this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  this.丕丘一上丞丂丆丑丏.与不丞丑七丘丁丂丛());
        }
        
        if(this.timerUi.gameObject.activeSelf != true)
        {
                if(this.tagSpecificObject.丆丞丈丏三丌不丈丟() < 1)
        {
            goto label_21;
        }
        
        }
        
        label_32:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.nameLabel, 丏业丟一东丂东丘丛:  (this.丆丈三丅丌上丂与万.Count >= this.minCountForTitle_WithTimerOrTags) ? 1 : 0);
        return;
        label_21:
        if((this.丕丘一上丞丂丆丑丏.丙业丆丘万丙专万丟().Equals(value:  "Advert")) == false)
        {
            goto label_32;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  "");
        goto label_32;
    }
    public MainStoreSectionView()
    {
        this.minCountForTitle_WithTimerOrTags = 2;
        this.gridOffset = 10;
        this.丆丈三丅丌上丂与万 = new System.Collections.Generic.List<MainStorePromotionView>();
    }
    private void 丌丘丐丏万丕丆下丌()
    {
        List.Enumerator<T> val_1 = this.丆丈三丅丌上丂与万.GetEnumerator();
        label_5:
        if((297623304 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  true);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }

}
