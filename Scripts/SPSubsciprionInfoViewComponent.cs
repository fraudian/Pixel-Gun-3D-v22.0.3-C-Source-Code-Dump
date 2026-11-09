using UnityEngine;
internal class SPSubsciprionInfoViewComponent : SPViewComponentBase
{
    // Fields
    private static System.Action 丁丐丒丐万丐业丌业;
    private static System.Action 东丕丄丂七丑丝丘专;
    private UILabel priceShort;
    private UILabel description;
    private UILabel[] priceOnButton;
    private UnityEngine.GameObject[] subscribeNowOnButton;
    private UnityEngine.GameObject priceContainer;
    private UILabel[] subscriptionName;
    private UILabel[] dailyReward;
    
    // Methods
    internal static void 专丙且丙业丅丕丆专(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  SPSubsciprionInfoViewComponent.丁丐丒丐万丐业丌业, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 专七丗一丞下丙丙丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  SPSubsciprionInfoViewComponent.丁丐丒丐万丐业丌业, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 专丕丐丂下不一丏丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  SPSubsciprionInfoViewComponent.东丕丄丂七丑丝丘专, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(SPSubsciprionInfoViewComponent.东丕丄丂七丑丝丘专 != 1152921505267392520);
    
    }
    internal static void 丄万与一世丘丏丏丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  SPSubsciprionInfoViewComponent.东丕丄丂七丑丝丘专, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(SPSubsciprionInfoViewComponent.东丕丄丂七丑丝丘专 != 1152921505267392520);
    
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UILabel val_23;
        UILabel val_24;
        var val_25;
        string val_26;
        var val_27;
        var val_28;
        val_23 = 且丘丏丁丑与丙与丁;
        val_24 = this;
        if(this.priceShort == 0)
        {
                return;
        }
        
        this.priceShort.text = "4.99$";
        System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_3 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        0.丘丙丁丅七一与且丈(丆万一不丌且东丐丐:  "reward-subscription-repeatable", 专丂丕丗丗东世丞下: ref  val_3);
        PGCompany.丄与丘丑业专丞七丅 val_4 = val_3.Item[0];
        string val_6 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_4.ItemParams.丂丁丏一丙丛业且丌());
        string val_7 = PGCompany.丘丒丑万专一业丒专.丁下专丙上丐丞万且();
        this.priceShort.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8022"), arg0:  val_7);
        this.description.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8024"), arg0:  val_7, arg1:  val_6);
        val_23 = 0.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "subscription-free-trial-used");
        val_25 = 0;
        goto label_19;
        label_29:
        if(val_23 != false)
        {
                val_26 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8028"), arg0:  val_7);
        }
        else
        {
                val_26 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8034");
        }
        
        this.priceOnButton[0].text = val_26;
        val_25 = 1;
        label_19:
        if(val_25 < this.priceOnButton.Length)
        {
            goto label_29;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceContainer, 丏业丟一东丂东丘丛:  (~val_23) & 1);
        val_27 = 0;
        goto label_32;
        label_38:
        val_23 = this.subscriptionName[0];
        val_23.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8018");
        val_27 = 1;
        label_32:
        if(val_27 < this.subscriptionName.Length)
        {
            goto label_38;
        }
        
        val_28 = 0;
        goto label_39;
        label_45:
        val_24 = this.dailyReward[0];
        val_23 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8019"), arg0:  val_6);
        val_24.text = val_23;
        val_28 = 1;
        label_39:
        if(val_28 < this.dailyReward.Length)
        {
            goto label_45;
        }
    
    }
    public void U_PrivacyPolicy()
    {
        SettingsController.丄丈丄丗丈七万丙万();
    }
    public void U_TermsOfUse()
    {
        SettingsController.一丝丈一丂七且丘世();
    }
    public void U_Restore()
    {
        SettingsController.丄丕万丁丗丆丒丅不();
        if(SPSubsciprionInfoViewComponent.丁丐丒丐万丐业丌业 == null)
        {
                return;
        }
        
        SPSubsciprionInfoViewComponent.丁丐丒丐万丐业丌业.Invoke();
    }
    private void OnEnable()
    {
        PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void SPSubsciprionInfoViewComponent::且世业丁一丏丐丅丈(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 且丆丏丛东下上丄丟, object 丏丂丅丟上丁东丞丂)));
    }
    private void OnDisable()
    {
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void SPSubsciprionInfoViewComponent::且世业丁一丏丐丅丈(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 且丆丏丛东下上丄丟, object 丏丂丅丟上丁东丞丂)));
    }
    private void 且世业丁一丏丐丅丈(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 且丆丏丛东下上丄丟, object 丏丂丅丟上丁东丞丂)
    {
        string val_5;
        var val_6;
        val_5 = 且丘丏丁丑与丙与丁;
        if(val_5 == null)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        val_5 = (((PGCompany.东丑丆丗丏丐丟下丄.__il2cppRuntimeField_typeHierarchy + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_5) : 0.丒不丟丒丁丗丒丕丑();
        val_6 = null;
        val_6 = null;
        if((System.String.op_Equality(a:  val_5, b:  StoreKitEventListener.丒丁丐丙丐丈丕专世 + 32)) == false)
        {
                return;
        }
        
        if(SPSubsciprionInfoViewComponent.东丕丄丂七丑丝丘专 == null)
        {
                return;
        }
        
        SPSubsciprionInfoViewComponent.东丕丄丂七丑丝丘专.Invoke();
    }
    public SPSubsciprionInfoViewComponent()
    {
        val_1 = new PGBehaviour();
    }

}
