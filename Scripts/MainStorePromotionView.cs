using UnityEngine;
internal class MainStorePromotionView : PromotionViewAbstract
{
    // Fields
    private System.Action 世东丁与丐丅丕丏丞;
    internal System.Action<PGCompany.东丑丆丗丏丐丟下丄> 万世三丈专七下丒业;
    internal System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丐专专丑丂东一丒丅;
    internal static System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丄三三丄丙丟丟不丐;
    internal static System.Action<PGCompany.东丑丆丗丏丐丟下丄> 且丟世不丝与不丘丐;
    private readonly System.Collections.Generic.List<丁丈丏万且丛丆丁七> 丞丒丄一丞七丒且丛;
    public GuiApplyersGroup guiApplyersGroup;
    public UILabel sectionNameLabel;
    public bool updateViewOnEnable;
    
    // Methods
    internal void 丟东东丅业丂丏丁丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.世东丁与丐丅丕丏丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世东丁与丐丅丕丏丞 != 1152921539253199760);
    
    }
    internal void 丒世丐世丙丄丄且下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.世东丁与丐丅丕丏丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世东丁与丐丅丕丏丞 != 1152921539253336336);
    
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.丘丁东丟丒丙且丄七();
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        goto typeof(MainStorePromotionView).__il2cppRuntimeField_198;
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_36;
        var val_37;
        string val_38;
        var val_39;
        var val_40;
        val_36 = this;
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return (bool)val_37;
        }
        
        PGCompany.东丑丆丗丏丐丟下丄 val_2 = this.与丞丆丑东东丟丆丌();
        if(val_2 == null)
        {
            goto label_38;
        }
        
        PGCompany.东丑丆丗丏丐丟下丄 val_3 = this.与丞丆丑东东丟丆丌();
        int val_4 = val_3.专丕世丁东丅丙不丝(且丘丏丁丑与丙与丁:  val_3);
        if((val_4 & 2147483648) == 0)
        {
                val_38 = System.String.Format(format:  "_P{0}", arg0:  val_4);
        }
        else
        {
                val_38 = "";
        }
        
        val_39 = "Advert";
        if("Advert" == null)
        {
                val_39 = "Advert";
        }
        
        if((Equals(value:  val_2.丝丒丙一丙丄不三丞())) == false)
        {
            goto label_22;
        }
        
        if((PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世().丕不一东下丅丒业丏(丙业与丙丗丝不丈东: out  0, 丏丞专丏业丗丝七丝: out  0)) != false)
        {
                if((val_9.不业丙丒丂丞下丆丙() != 10) || ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_9.业东丅东丌上丗丑不())) == null))
        {
            goto label_17;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.sectionNameLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4835"));
        goto label_22;
        label_17:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.sectionNameLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11849"));
        PGCompany.StorePromotionConfig val_19 = this.与丞丆丑东东丟丆丌().丘丑下丆上业丛一丄();
        PGCompany.StorePromotionSettings val_20 = val_19.Settings;
        val_20.TexturePath = "OfferIcons/"("OfferIcons/") + val_9.业上丙丞丐丄丆丅七() + "_icon1_big";
        this.与丞丆丑东东丟丆丌().丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_19);
        label_22:
        val_40 = 0;
        if(this.guiApplyersGroup != 0)
        {
                val_38 = "MainStorePromotion_" + val_2.丝丒丙一丙丄不三丞() + val_38;
            string val_27 = val_2.丅上万丛一丐上上丕();
            val_40 = (val_27 == null) ? "" : (val_27);
            if((this.guiApplyersGroup & 1) == 0)
        {
                val_38 = this.guiApplyersGroup;
            string val_30 = "MainStorePromotion_" + val_2.丝丒丙一丙丄不三丞();
            val_40 = val_2.丅上万丛一丐上上丕();
            if((val_38 & 1) == 0)
        {
                val_40 = "default";
        }
        
        }
        
        }
        
        label_38:
        List.Enumerator<T> val_32 = this.丞丒丄一丞七丒且丛.GetEnumerator();
        label_47:
        if((287122960 & 1) == 0)
        {
            goto label_41;
        }
        
        var val_36 = 0;
        val_36 = val_36 + 1;
        val_40 = 0;
        0.丐丏七丌丕丗业且上().Setup(且丘丏丁丑与丙与丁:  this.与丞丆丑东东丟丆丌());
        goto label_47;
        label_41:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_37 = 1;
        return (bool)val_37;
    }
    public override void TryPurchase()
    {
        if((this.与丞丆丑东东丟丆丌() != null) && (this.与丞丆丑东东丟丆丌().与不丞丑七丘丁丂丛() != null))
        {
                if((this.与丞丆丑东东丟丆丌().与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "state.purchased")) != false)
        {
                return;
        }
        
        }
        
        this.TryPurchase();
    }
    internal override void 丐丌丘不上且东业丘()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "On Pre Purchase");
    }
    internal override void 丌丆丌且丘丝丝丑丄()
    {
        PGCompany.东丑丒丗一丞下丙丙<T> val_20;
        System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> val_21;
        System.Collections.Generic.List<BankViewTab> val_22;
        val_20 = this;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "On Purchase Fail");
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return;
        }
        
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return;
        }
        
        if(this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不() == 10015)
        {
                return;
        }
        
        if(this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不() == 11015)
        {
                return;
        }
        
        int val_9 = this.与丞丆丑东东丟丆丌().Count;
        PGCompany.东丑丒丗一丞下丙丙<T> val_12 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
        val_21 = this.与丞丆丑东东丟丆丌();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_21, 与专丆丈专丌三一东: ref  val_12, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true)
        {
                val_21 = this.与丞丆丑东东丟丆丌().业上丙丞丐丄丆丅七();
            val_22 = 0;
            PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_21, 万丆丛世丈上丕东丗:  val_22, 世丁丙世丄一万丆三:  System.String.alignConst, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  val_12.Item[0]);
        }
        
        PGCompany.东丑丒丗一丞下丙丙<T> val_18 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
        val_20 = val_12;
    }
    internal override void 世世丑丞丒丟业丁与()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "On Purchase Sucess");
        if(this.世东丁与丐丅丕丏丞 == null)
        {
                return;
        }
        
        this.世东丁与丐丅丕丏丞.Invoke();
    }
    protected virtual void OnEnable()
    {
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘.七七东专世丘一丆丏(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStorePromotionView::丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 丘业丕不丏丂丌丙且)));
        if(this.updateViewOnEnable == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(MainStorePromotionView).__il2cppRuntimeField_198;
    }
    protected virtual void OnDisable()
    {
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丆丆丑丒丛七不丈丆(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStorePromotionView::丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 丘业丕不丏丂丌丙且)));
    }
    private void 丒丄专七且丘丐丝丒(PGCompany.东丑丆丗丏丐丟下丄 丘业丕不丏丂丌丙且)
    {
        var val_12;
        if(丘业丕不丏丂丌丙且 == null)
        {
                return;
        }
        
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return;
        }
        
        val_12 = this.与丞丆丑东东丟丆丌().七丈丒丒下下且万与();
        PGCompany.专丟专世丅丂丁且专 val_4 = 丘业丕不丏丂丌丙且.七丈丒丒下下且万与();
        var val_13 = 0;
        val_13 = val_13 + 1;
        if((val_12.Equals(other:  ???)) == false)
        {
                return;
        }
        
        this.且丞丝丑丛一丝七丞(且丘丏丁丑与丙与丁:  丘业丕不丏丂丌丙且);
        this = ???;
        val_12 = ???;
        goto typeof(MainStorePromotionView).__il2cppRuntimeField_198;
    }
    public void U_Purchase()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.与丞丆丑东东丟丆丌();
        if(val_1 != null)
        {
                0 = "advert";
            if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  0)) != false)
        {
                if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
                return;
        }
        
            if(GameConnect.上丏丈七丘丁与丅丏() == true)
        {
                return;
        }
        
        }
        
        }
        
        if(this.丐专专丑丂东一丒丅 != null)
        {
                this.丐专专丑丂东一丒丅.Invoke(obj:  this.与丞丆丑东东丟丆丌());
        }
        
        if(MainStorePromotionView.且丟世不丝与不丘丐 == null)
        {
                return;
        }
        
        MainStorePromotionView.且丟世不丝与不丘丐.Invoke(obj:  this.与丞丆丑东东丟丆丌());
    }
    public void U_ShowInfo()
    {
        PGCompany.三东丏不丗世丅丌丄 val_23 = 0;
        if(this.万世三丈专七下丒业 != null)
        {
                this.万世三丈专七下丒业.Invoke(obj:  this.与丞丆丑东东丟丆丌());
        }
        
        if(MainStorePromotionView.丄三三丄丙丟丟不丐 == null)
        {
                return;
        }
        
        MainStorePromotionView.丄三三丄丙丟丟不丐.Invoke(obj:  this.与丞丆丑东东丟丆丌());
    }
    private void 丘丁东丟丒丙且丄七()
    {
        var val_3;
        if(this.丞丒丄一丞七丒且丛.Count > 0)
        {
                return;
        }
        
        val_3 = 0;
        goto label_3;
        label_7:
        this.丞丒丄一丞七丒且丛.Add(item:  this.GetComponentsInChildren<SPViewComponentBase>(includeInactive:  true)[0]);
        val_3 = 1;
        label_3:
        if(val_3 < val_2.Length)
        {
            goto label_7;
        }
    
    }
    private int 专丕世丁东丅丙不丝(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_12;
        var val_13;
        System.Int32[] val_14;
        var val_15;
        if(且丘丏丁丑与丙与丁 == null)
        {
                return 0;
        }
        
        var val_1 = (((PGCompany.东丑丆丗丏丐丟下丄.__il2cppRuntimeField_typeHierarchy + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 且丘丏丁丑与丙与丁 : 0;
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "event")) == true)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "coins")) == true)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "gems")) == true)
        {
                return 0;
        }
        
        if((System.String.op_Equality(a:  val_1.丝丒丙一丙丄不三丞(), b:  "silver")) == true)
        {
                return 0;
        }
        
        if(val_1.业东丅东丌上丗丑不() != 10015)
        {
                return 0;
        }
        
        val_12 = 0;
        goto label_15;
        label_25:
        val_13 = null;
        val_13 = null;
        val_14 = 且丘丏丁丑与丙与丁;
        int val_11 = val_14.丂丁丏一丙丛业且丌();
        val_12 = 1;
        label_15:
        val_15 = null;
        val_15 = null;
        val_14 = StoreKitEventListener.丝不东丅丅丂三且丑;
        if(val_12 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
        {
            goto label_25;
        }
        
        return 0;
    }
    public MainStorePromotionView()
    {
        this.丞丒丄一丞七丒且丛 = new System.Collections.Generic.List<丁丈丏万且丛丆丁七>();
    }

}
