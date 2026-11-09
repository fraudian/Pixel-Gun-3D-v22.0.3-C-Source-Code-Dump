using UnityEngine;
internal sealed class MainStorePromotionViewWithCharacter : MainStorePromotionView
{
    // Fields
    private PGCompany.TimerUI timerToStart;
    private PGCompany.InventoryItemView priceView;
    private UnityEngine.GameObject shootButtonUI;
    private StoreCharacterHelper _character;
    private ItemSelectorView itemSelectorView;
    private System.Collections.Generic.List<WidgetLayout> layouts;
    private UnityEngine.GameObject characterUI;
    private UnityEngine.GameObject noCharacterUI;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnShowInfo;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfActive;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfInactive;
    
    // Methods
    protected void OnEnable()
    {
        this.itemSelectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::业且三丙世丅丆丏世()));
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::丐且丌丟丛万丗丙丑(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)));
        UnityEngine.Coroutine val_6 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::丆与业业丆东丗丈业()), 业丗七丕万万不丈丗:  1);
    }
    private void 丆与业业丆东丗丈业()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.layouts.GetEnumerator();
        val_3 = 1152921539256047216;
        label_4:
        if((289480984 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        val_2.Reposition();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    protected void OnDisable()
    {
        this.itemSelectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::业且三丙世丅丆丏世()));
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::丐且丌丟丛万丗丙丑(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)));
    }
    internal void 丘下丟丁上丏丛且且()
    {
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.itemSelectorView.丕丟丐丈丐丄丌三丐());
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
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this._character.万与七丕七丁丞下丆 = false;
        this.itemSelectorView.丞七丐三丑东且丈下();
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.丘丁东丟丒丙且丄七();
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        goto typeof(MainStorePromotionViewWithCharacter).__il2cppRuntimeField_198;
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_31;
        UnityEngine.GameObject val_32;
        val_31 = 1152921505284374528;
        val_32 = this.characterUI;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noCharacterUI, 丏业丟一东丂东丘丛:  false);
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return (bool)this.丝一丅丆三东丂丞七();
        }
        
        PGCompany.东丑丆丗丏丐丟下丄 val_3 = this.与丞丆丑东东丟丆丌();
        if(val_3 != null)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfActive, 丏业丟一东丂东丘丛:  (~val_3.丞丞丈丌且业丘丑三()) & 1);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfInactive, 丏业丟一东丂东丘丛:  val_3.丞丞丈丌且业丘丑三());
        }
        
        int val_31 = this.与丞丆丑东东丟丆丌().上丟丄与丁三丌丘专();
        val_31 = val_31 - PixelTime.丙丅丅业丟丁世丁丗();
        if(((val_31 >= 1) && (this.与丞丆丑东东丟丆丌().上丟丄与丁三丌丘专() >= 1)) && (this.timerToStart != null))
        {
                this.timerToStart.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_31, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void MainStorePromotionViewWithCharacter::丆丁世七丙丝丕丙世()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        if(this.priceView != null)
        {
                this.priceView.Setup(丈丄不七三万丄丁不:  this.与丞丆丑东东丟丆丌());
        }
        
        this.itemSelectorView.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  this.与丞丆丑东东丟丆丌(), 丛丗七丅下丞丗且丐:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌()));
        if(this.与丞丆丑东东丟丆丌().Count > 1)
        {
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  1.3f);
        }
        
        this.itemSelectorView.transform.localScale = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        this.丕丙丝一丁丏且丘丛();
        val_32 = this.与丞丆丑东东丟丆丌();
        List.Enumerator<T> val_25 = val_32.GetEnumerator();
        val_31 = 0;
        goto label_33;
        label_35:
        val_32 = 0.丐丏七丌丕丗业且上();
        val_31 = val_31 + (丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丝丛丐丈丅丑业丙丟(丈丄不七三万丄丁不:  val_32));
        label_33:
        if((290383320 & 1) != 0)
        {
            goto label_35;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_31 >= true)
        {
                this.丕丙丝一丁丏且丘丛();
            return (bool)this.丝一丅丆三东丂丞七();
        }
        
        this.丘丝丗业丞丄丙丞专();
        return (bool)this.丝一丅丆三东丂丞七();
    }
    private void 丆丁世七丙丝丕丙世()
    {
        goto typeof(MainStorePromotionViewWithCharacter).__il2cppRuntimeField_198;
    }
    private void 丕丙丝一丁丏且丘丛()
    {
        var val_22;
        var val_29;
        var val_30;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_32;
        var val_33;
        PGCompany.丗丟丄丈东丝丕丄世 val_34;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_36;
        var val_37;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_39;
        var val_40;
        var val_41;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_43;
        StoreCharacterHelper val_44;
        val_29 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterUI, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noCharacterUI, 丏业丟一东丂东丘丛:  false);
        this._character.与丕丆上丛丐下丕丂().专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  true);
        if((this.与丞丆丑东东丟丆丌() == null) || ((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌())) == false))
        {
            goto label_8;
        }
        
        System.Collections.Generic.List<T> val_6 = PGCompany.丟一丘丄三丘丄丒丄.丕丗丏丘丛丌与丟丒<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  this.与丞丆丑东东丟丆丌());
        val_30 = null;
        val_30 = null;
        val_32 = MainStorePromotionViewWithCharacter.<>c.<>9__20_0;
        if(val_32 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_7 = null;
            val_32 = val_7;
            val_7 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  MainStorePromotionViewWithCharacter.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionViewWithCharacter.<>c::丕丝丕丗万三丁丑三(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            MainStorePromotionViewWithCharacter.<>c.<>9__20_0 = val_32;
        }
        
        val_33 = null;
        val_34 = System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_6, predicate:  val_7);
        val_33 = null;
        val_36 = MainStorePromotionViewWithCharacter.<>c.<>9__20_1;
        if(val_36 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_9 = null;
            val_36 = val_9;
            val_9 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  MainStorePromotionViewWithCharacter.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionViewWithCharacter.<>c::丂上业世丅专下与三(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            MainStorePromotionViewWithCharacter.<>c.<>9__20_1 = val_36;
        }
        
        val_37 = null;
        val_37 = null;
        val_39 = MainStorePromotionViewWithCharacter.<>c.<>9__20_2;
        if(val_39 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_11 = null;
            val_39 = val_11;
            val_11 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  MainStorePromotionViewWithCharacter.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionViewWithCharacter.<>c::丟万丁丑丈丙丌丞专(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            MainStorePromotionViewWithCharacter.<>c.<>9__20_2 = val_39;
        }
        
        if(val_34 != true)
        {
                this._character.丞上丄丄上丞丘下丁();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
        }
        
        val_40 = public PGCompany.三东丏不丗世丅丌丄 System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::get_Item(int index);
        var val_15 = (val_6.Item[0].不业丙丒丂丞下丆丙() == 1080) ? 1 : 0;
        val_15 = val_34 & val_15;
        if(val_15 == true)
        {
                val_41 = null;
            val_41 = null;
            val_43 = MainStorePromotionViewWithCharacter.<>c.<>9__20_3;
            if(val_43 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_16 = null;
            val_43 = val_16;
            val_16 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  MainStorePromotionViewWithCharacter.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainStorePromotionViewWithCharacter.<>c::丟丅丁丏丆丝丟丅与(PGCompany.三东丏不丗世丅丌丄 七丏丄丅丌业与且丙));
            MainStorePromotionViewWithCharacter.<>c.<>9__20_3 = val_43;
        }
        
            val_40 = 0;
            val_34 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  System.Linq.Enumerable.First<PGCompany.三东丏不丗世丅丌丄>(source:  val_6, predicate:  val_16));
            if(val_34 != null)
        {
                val_40 = 0;
            this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_34);
        }
        
        }
        
        List.Enumerator<T> val_20 = val_6.GetEnumerator();
        val_29 = 1152921525631263872;
        label_46:
        if((290818256 & 1) == 0)
        {
            goto label_41;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_25 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_22.丐丏七丌丕丗业且上());
        if((val_25 == null) || (null == null))
        {
            goto label_46;
        }
        
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_25);
        goto label_46;
        label_8:
        val_44 = this._character;
        val_44.丞上丄丄上丞丘下丁();
        return;
        label_41:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_6, predicate:  val_9)) | (~(System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_6, predicate:  val_11)))) != true)
        {
                val_40 = 9961472;
            val_40 = 152;
            this._character.世与且丅下万丄丑且(下丗丁丒丘东丂不丑:  20, 七丆丒与丗丌丄且丂:  112);
        }
        
        val_44 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
    }
    private void 丘丝丗业丞丄丙丞专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noCharacterUI, 丏业丟一东丂东丘丛:  true);
    }
    private void 丐且丌丟丛万丗丙丑(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        if(this.与丞丆丑东东丟丆丌() == 丐丆丝业丙丈下世丁)
        {
            goto typeof(MainStorePromotionViewWithCharacter).__il2cppRuntimeField_198;
        }
    
    }
    public MainStorePromotionViewWithCharacter()
    {
    
    }

}
