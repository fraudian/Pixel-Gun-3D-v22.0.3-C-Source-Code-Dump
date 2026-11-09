using UnityEngine;
internal sealed class NovicePromotionView : StorePromotionView
{
    // Fields
    private PGCompany.丒丌业一丕丘丐世专 丁丏丁丅丒不三世丞;
    private PGCompany.TimerUI timerUI;
    private UILabel salePercent;
    private BuyButtonUI oldPriceView;
    private BuyButtonUI buyButtonUI;
    private UnityEngine.GameObject noSetverTime;
    private UnityEngine.GameObject shootButtonUI;
    private StoreCharacterHelper _character;
    private UnityEngine.GameObject light;
    private ItemSelectorView itemSelectorView;
    private UnityEngine.GameObject[] backgrounds;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnShowInfo;
    private Rilisoft.ItemViewer 丆丁一丅丗上业丅东;
    
    // Methods
    private void OnEnable()
    {
        this.itemSelectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::业且三丙世丅丆丏世()));
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::丝三业万东不七丝且()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::丝三业万东不七丝且()));
        this.丝三业万东不七丝且();
    }
    private void OnDisable()
    {
        this.itemSelectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::业且三丙世丅丆丏世()));
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::丝三业万东不七丝且()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionView::丝三业万东不七丝且()));
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.丁丏丁丅丒不三世丞 = 0;
        if(且丘丏丁丑与丙与丁 != null)
        {
                this.丁丏丁丅丒不三世丞 = 且丘丏丁丑与丙与丁;
            this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  且丘丏丁丑与丙与丁.下丒丗丄丌丘不丑丘() - PixelTime.丝丗专上三不丄丑丑(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.salePercent, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2555"), arg0:  且丘丏丁丑与丙与丁.丆丞上丛丂一业丟丕()));
            this.oldPriceView.Setup(丒世丘丘上丆丝东丞:  且丘丏丁丑与丙与丁.丄丌丛丑万且丞丙丏());
        }
        
        this._character.万与七丕七丁丞下丆 = false;
        this.itemSelectorView.丞七丐三丑东且丈下();
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
    }
    internal void 丝三业万东不七丝且()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buyButtonUI, 丏业丟一东丂东丘丛:  PixelTime.丝业丁丌丘东丏世与());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noSetverTime, 丏业丟一东丂东丘丛:  (~PixelTime.丝业丁丌丘东丏世与()) & 1);
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        bool val_37;
        var val_38;
        var val_39;
        StoreCharacterHelper val_40;
        var val_41;
        PGCompany.三东丏不丗世丅丌丄 val_42;
        PGCompany.丒丌业一丕丘丐世专 val_46;
        var val_47;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_49;
        var val_50;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_52;
        var val_53;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_55;
        var val_56;
        var val_57;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_59;
        val_37 = 0;
        bool val_1 = this.丝一丅丆三东丂丞七();
        if((val_1 == false) || (this.丁丏丁丅丒不三世丞 == null))
        {
                return val_1;
        }
        
        if((this.backgrounds == null) || (this.backgrounds.Length == 0))
        {
            goto label_16;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_2 = this.丁丏丁丅丒不三世丞.丞丂上世丌丒世下七();
        if(val_2 != null)
        {
                int val_3 = val_2.丏不丁丛丕丒丏丆丂();
            val_38 = 0;
        }
        else
        {
                val_38 = 0;
        }
        
        val_37 = public System.Boolean System.Nullable<System.Int32>::get_HasValue();
        if((330607512 & 1) != 0)
        {
                val_37 = public System.Int32 System.Nullable<System.Int32>::GetValueOrDefault();
            int val_4 = val_38.丙东专丂世丈丏丁丂();
        }
        else
        {
                val_39 = 0;
        }
        
        val_40 = 0;
        val_41 = 0;
        goto label_9;
        label_15:
        bool val_6 = ((val_39 - 1) == val_40) ? 1 : 0;
        val_37 = val_6;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backgrounds[0], 丏业丟一东丂东丘丛:  val_37);
        val_41 = val_41 | val_6;
        val_40 = 1;
        label_9:
        if(val_40 < this.backgrounds.Length)
        {
            goto label_15;
        }
        
        if((val_41 & 1) == 0)
        {
                val_37 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backgrounds[0], 丏业丟一东丂东丘丛:  true);
        }
        
        label_16:
        this.buyButtonUI.Setup(丒世丘丘上丆丝东丞:  this.丁丏丁丅丒不三世丞);
        val_42 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丁丏丁丅丒不三世丞);
        this.itemSelectorView.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  this.丁丏丁丅丒不三世丞, 丛丗七丅下丞丗且丐:  val_42);
        if(this.丁丏丁丅丒不三世丞.Count > 1)
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  1.3f);
        }
        
        this.itemSelectorView.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        this._character.与丕丆上丛丐下丕丂().专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  false);
        this._character.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  true);
        val_46 = this.丁丏丁丅丒不三世丞;
        if(val_46 == null)
        {
            goto label_44;
        }
        
        val_46 = this.丁丏丁丅丒不三世丞;
        if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_46)) == false)
        {
            goto label_44;
        }
        
        val_46 = PGCompany.丟一丘丄三丘丄丒丄.丕丗丏丘丛丌与丟丒<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  this.丁丏丁丅丒不三世丞);
        val_47 = null;
        val_47 = null;
        val_49 = NovicePromotionView.<>c.<>9__15_0;
        if(val_49 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_16 = null;
            val_49 = val_16;
            val_16 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  NovicePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NovicePromotionView.<>c::丛三丕丛世下丆丙丁(PGCompany.三东丏不丗世丅丌丄 七丏丄丅丌业与且丙));
            NovicePromotionView.<>c.<>9__15_0 = val_49;
        }
        
        bool val_17 = System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_46, predicate:  val_16);
        val_50 = null;
        val_50 = null;
        val_52 = NovicePromotionView.<>c.<>9__15_1;
        if(val_52 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_18 = null;
            val_52 = val_18;
            val_18 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  NovicePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NovicePromotionView.<>c::业且丒三丞丕丌万一(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            NovicePromotionView.<>c.<>9__15_1 = val_52;
        }
        
        val_53 = null;
        val_53 = null;
        val_55 = NovicePromotionView.<>c.<>9__15_2;
        if(val_55 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_20 = null;
            val_55 = val_20;
            val_20 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  NovicePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NovicePromotionView.<>c::丒丒七业丘世且丌七(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            NovicePromotionView.<>c.<>9__15_2 = val_55;
        }
        
        val_42 = System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_46, predicate:  val_20);
        if(val_17 != true)
        {
                this._character.丞上丄丄上丞丘下丁();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
        }
        
        val_56 = public PGCompany.三东丏不丗世丅丌丄 System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::get_Item(int index);
        val_40 = val_46.Item[0];
        var val_24 = (val_40.不业丙丒丂丞下丆丙() == 1080) ? 1 : 0;
        val_24 = val_17 & val_24;
        if(val_24 == true)
        {
                val_57 = null;
            val_57 = null;
            val_59 = NovicePromotionView.<>c.<>9__15_3;
            if(val_59 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_25 = null;
            val_59 = val_25;
            val_25 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  NovicePromotionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NovicePromotionView.<>c::丑世万与丁丑丐丅丏(PGCompany.三东丏不丗世丅丌丄 七丏丄丅丌业与且丙));
            NovicePromotionView.<>c.<>9__15_3 = val_59;
        }
        
            val_40 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_56 = 0;
            PGCompany.丗丟丄丈东丝丕丄世 val_28 = val_40.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  System.Linq.Enumerable.First<PGCompany.三东丏不丗世丅丌丄>(source:  val_46, predicate:  val_25));
            if(val_28 != null)
        {
                val_40 = this._character;
            val_40.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_28);
            val_56 = 0;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        List.Enumerator<T> val_29 = val_46.GetEnumerator();
        label_84:
        if((330607472 & 1) == 0)
        {
            goto label_79;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_33 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  0.丐丏七丌丕丗业且上());
        if((val_33 == null) || (null == null))
        {
            goto label_84;
        }
        
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_33);
        goto label_84;
        label_44:
        this._character.丞上丄丄上丞丘下丁();
        return val_1;
        label_79:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_46, predicate:  val_18)) | (~val_42)) != true)
        {
                val_56 = 9961472;
            val_56 = 152;
            this._character.世与且丅下万丄丑且(下丗丁丒丘东丂不丑:  20, 七丆丒与丗丌丄且丂:  112);
        }
        
        PGCompany.东丑丒丗一丞下丙丙<T> val_35 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
        return val_1;
    }
    internal void 丘下丟丁上丏丛且且()
    {
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.itemSelectorView.丕丟丐丈丐丄丌三丐());
    }
    public void ShowItemViewer()
    {
        var val_13;
        if(this.itemSelectorView.丕丟丐丈丐丄丌三丐() == null)
        {
                return;
        }
        
        .万丄丅丛下丐丒丞上 = ExperienceController.丞丞丘业东丙丏七丌();
        if(this.itemSelectorView.丕丟丐丈丐丄丌三丐().不业丙丒丂丞下丆丙() != 10)
        {
            goto label_8;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_7 = this.itemSelectorView.丕丟丐丈丐丄丌三丐();
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        label_13:
        if(null != null)
        {
            goto label_18;
        }
        
        .丅万丗上三不丙丆丒 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  val_7);
        label_8:
        this.丆丁一丅丗上业丅东 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丈丄不七三万丄丁不:  this.itemSelectorView.东丞丕且丁丏东与下(), 丗丟上上丒丐丗丞丙:  new ItemViewer.丕丈丏丑丌丂且万不(), 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        return;
        label_18:
        val_13 = X0;
    }
    private void 下丁下丛丙专丁丕上()
    {
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  false);
    }
    private void 业且三丙世丅丆丏世()
    {
        this.丆丁一丅丗上业丅东 = 0;
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  true);
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 == false)
        {
                return;
        }
        
        if(this.丆丁一丅丗上业丅东 == 0)
        {
                return;
        }
        
        this.丆丁一丅丗上业丅东 = 0;
    }
    public NovicePromotionView()
    {
    
    }

}
