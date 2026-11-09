using UnityEngine;
internal class BankViewItem : RealInappBankViewItem
{
    // Fields
    private UnityEngine.Animator 三丂丁丛东业丄丟与;
    private UnityEngine.Animator 三丕丈七上丞丘下且;
    public UISprite bestBuy;
    public System.Collections.Generic.List<UILabel> countLabel;
    public System.Collections.Generic.List<UILabel> countLabelsList;
    public System.Collections.Generic.List<UILabel> countLabelsX3List;
    public System.Collections.Generic.List<UILabel> countX3Label;
    public UILabel discountPercentsLabel;
    public UISprite discountSprite;
    public UnityEngine.GameObject normalAmountContainer;
    public UnityEngine.GameObject noX10Container;
    public UILabel profilxX10;
    public UnityEngine.GameObject x10Indicator;
    public UnityEngine.GameObject x3AmountContainer;
    
    // Properties
    private bool 丕东丒丟丌丙丈一丒 { get; }
    public bool 丛丂丐丘丁丁丌丂三 { get; }
    private int 丒专下与丑丁丆丟业 { set; }
    private int 业与丝丕丒与丙丁不 { set; }
    
    // Methods
    private bool 且丒三丄丟丒不丒上()
    {
        if(11390 == 0)
        {
                return (bool)((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  (val_2.不业丙丒丂丞下丆丙() == 1) ? 2015 : 1015, 世丈三丐丞一丒丛不:  this = val_2[((long)(int)(val_3)) << 2])) == 3) ? 1 : 0;
        }
        
        System.Int32[] val_2 = AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  11390.不业丙丒丂丞下丆丙());
        int val_3 = X21.业东丅东丌上丗丑不();
        return (bool)((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  (val_2.不业丙丒丂丞下丆丙() == 1) ? 2015 : 1015, 世丈三丐丞一丒丛不:  this)) == 3) ? 1 : 0;
    }
    public bool get_IsX10()
    {
        if(11394 == 0)
        {
                return (bool)((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  (val_2.不业丙丒丂丞下丆丙() == 1) ? 2015 : 1015, 世丈三丐丞一丒丛不:  this = val_2[((long)(int)(val_3)) << 2])) == 10) ? 1 : 0;
        }
        
        System.Int32[] val_2 = AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  11394.不业丙丒丂丞下丆丙());
        int val_3 = X21.业东丅东丌上丗丑不();
        return (bool)((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  (val_2.不业丙丒丂丞下丆丙() == 1) ? 2015 : 1015, 世丈三丐丞一丒丛不:  this)) == 10) ? 1 : 0;
    }
    private void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
    {
        var val_4;
        System.Collections.Generic.List<UILabel> val_5 = this.countLabel;
        if(val_5 == null)
        {
                return;
        }
        
        val_4 = 0;
        goto label_2;
        label_8:
        this.countLabel.Item[0].text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东);
        val_5 = this.countLabel;
        val_4 = 1;
        label_2:
        if(val_4 < val_5.Count)
        {
            goto label_8;
        }
    
    }
    private void 丑丄丒不东丟万丝丟(int 丙业与丙丗丝不丈东)
    {
        var val_4;
        System.Collections.Generic.List<UILabel> val_5 = this.countX3Label;
        if(val_5 == null)
        {
                return;
        }
        
        val_4 = 0;
        goto label_2;
        label_8:
        this.countX3Label.Item[0].text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东);
        val_5 = this.countX3Label;
        val_4 = 1;
        label_2:
        if(val_4 < val_5.Count)
        {
            goto label_8;
        }
    
    }
    public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丑业丄不丏丏丒丗丏)
    {
        System.Object[] val_3;
        if(东丈丏东丑丟不不丞 == null)
        {
                val_3 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "AbstractBankViewItem.Setup: product == null", args:  val_3);
        }
        
        this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丑业丄不丏丏丒丗丏:  丑业丄不丏丏丒丗丏);
        this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丄丆丘丏万三丞丐丏.丂丁丏一丙丛业且丌());
        this.丒一丏丄丝且丑万丏();
    }
    private void 丒一丏丄丝且丑万丏()
    {
        if(this.丄丑且丆上丛丁且七() == null)
        {
                return;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        string val_5 = Rilisoft.Offers.丁且丕专万丈丒丏丗.专七丘丝丞丁丞万丑(丄丒丌上丁丂不万东:  this.丄丑且丆上丛丁且七().业上丙丞丐丄丆丅七());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_5, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5));
    }
    public override void UpdateUi()
    {
        var val_37;
        bool val_38;
        var val_39;
        var val_40;
        var val_41;
        val_37 = this;
        bool val_1 = this.且丒三丄丟丒不丒上();
        bool val_2 = this.IsX10;
        if(this.discountSprite == 0)
        {
            goto label_3;
        }
        
        bool val_5 = val_1 | val_2;
        if(val_5 == false)
        {
            goto label_5;
        }
        
        val_38 = 0;
        goto label_6;
        label_3:
        if((val_1 | val_2) == false)
        {
            goto label_7;
        }
        
        label_11:
        val_39 = 1;
        goto label_8;
        label_5:
        val_38 = this.丌丕一丞丞且世专丞();
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.discountSprite.gameObject, 丏业丟一东丂东丘丛:  val_38);
        if(val_5 == true)
        {
            goto label_11;
        }
        
        label_7:
        if(this.discountPercentsLabel != 0)
        {
                if(this.丌丕一丞丞且世专丞() != false)
        {
                this.discountPercentsLabel.text = System.String.Format(format:  "{0}%", arg0:  val_38.丌业业业丞丆与丐丆());
        }
        
        }
        
        val_39 = 0;
        label_8:
        this.一三丌丝不丌丁丗丟();
        bool val_12 = val_2 ^ 1;
        bool val_14 = val_1 ^ 1 & val_12;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.normalAmountContainer, 丏业丟一东丂东丘丛:  val_14);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x3AmountContainer, 丏业丟一东丂东丘丛:  false);
        if(this.x10Indicator != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x10Indicator, 丏业丟一东丂东丘丛:  val_2);
        }
        
        if(this.noX10Container != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noX10Container, 丏业丟一东丂东丘丛:  val_12);
        }
        
        if((this.x10Indicator != 0) && (this.x10Indicator.activeSelf != false))
        {
                if(this.profilxX10 != 0)
        {
                this.profilxX10.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4832")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4832")) + "%"("%"), arg0:  1000);
        }
        
        }
        
        val_40 = 0;
        val_41 = 0;
        goto label_53;
        label_63:
        var val_28 = val_39 + 0;
        if(((val_39 + 0) + 32) != 0)
        {
                var val_30 = ((val_39 + 0) + 32) + 0;
            ((val_39 + 0) + 32 + 0) + 32.SetActive(value:  val_14);
        }
        
        val_41 = 1;
        label_53:
        if(val_41 < (((val_39 + 0) + 32 + 0) + 32 + 24))
        {
            goto label_63;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        if(val_2 != false)
        {
                int val_32 = 0.丂丁丏一丙丛业且丌();
            this.丑丄丒不东丟万丝丟(丙业与丙丗丝不丈东:  (val_32 + (val_32 << 2)) << 1);
            return;
        }
        
        if(val_1 == false)
        {
                return;
        }
        
        int val_35 = 0.丂丁丏一丙丛业且丌();
        this.丑丄丒不东丟万丝丟(丙业与丙丗丝不丈东:  val_35 + (val_35 << 1));
    }
    protected override void Awake()
    {
        var val_6;
        var val_7;
        val_6 = 0;
        this.三丂丁丛东业丄丟与 = this.bestBuy.GetComponent<UnityEngine.Animator>();
        val_7 = 0;
        this.三丕丈七上丞丘下且 = this.discountSprite.GetComponent<UnityEngine.Animator>();
        丅且东丙业丏丛东丛.一世丗丑七东世丒丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(BankViewItem).__il2cppRuntimeField_180));
        this.Awake();
    }
    protected override void OnEnable()
    {
        goto typeof(BankViewItem).__il2cppRuntimeField_178;
    }
    protected override void OnDisable()
    {
        bool val_1 = 东丗上丁下业一丂丂.专七与丏丞丁丅丈丟();
    }
    protected override void OnDestroy()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(BankViewItem).__il2cppRuntimeField_180);
        丅且东丙业丏丛东丛.专上一丞丝且七与万(丙业与丙丗丝不丈东:  new System.Action());
        this.OnDestroy();
    }
    protected virtual string 七与丘丌丙丁丕与丑()
    {
        object val_7;
        int val_2 = 业东丅东丌上丗丑不();
        if(不业丙丒丂丞下丆丙() == 1)
        {
                int val_3 = val_2 + 1;
            val_7 = "Textures/Bank/Coins_Shop_Gem_";
            return (string)val_7 + val_2 + 1(val_2 + 1);
        }
        
        val_7 = "Textures/Bank/Coins_Shop_";
        return (string)val_7 + val_2 + 1(val_2 + 1);
    }
    protected override void 丞业与下丛万丁下丙()
    {
        if(true != 0)
        {
                UnityEngine.Texture val_1 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this);
            if(this != null)
        {
            goto typeof(BankViewItem).__il2cppRuntimeField_2E8;
        }
        
        }
        else
        {
                UnityEngine.Debug.LogErrorFormat(format:  "BankViewItem.SetIcon: purchaseInfo == null", args:  System.Array.Empty<System.Object>());
        }
    
    }
    private void 专业一丈丄与丑世七(bool 万三东丆丂专丒丕丂)
    {
        UnityEngine.Animator val_5;
        UnityEngine.Animator val_6;
        string val_7;
        var val_8;
        val_5 = 万三东丆丂专丒丕丂;
        val_6 = this;
        if(this.且丒三丄丟丒不丒上() == true)
        {
                return;
        }
        
        bool val_2 = this.丌丕一丞丞且世专丞();
        if((val_2 == false) || (this.三丕丈七上丞丘下且 == 0))
        {
            goto label_5;
        }
        
        if(this.三丕丈七上丞丘下且 == null)
        {
            goto label_6;
        }
        
        if(val_5 == false)
        {
            goto label_7;
        }
        
        label_16:
        this.三丕丈七上丞丘下且.Play(stateName:  "DiscountAnimation");
        goto label_8;
        label_5:
        if(val_5 == false)
        {
                return;
        }
        
        label_8:
        val_5 = this.三丂丁丛东业丄丟与;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = this.三丂丁丛东业丄丟与;
        if(val_6 == null)
        {
            goto label_13;
        }
        
        if(val_2 == false)
        {
            goto label_14;
        }
        
        label_18:
        val_7 = "BestBuyAnimation";
        goto label_15;
        label_6:
        if(val_5 == true)
        {
            goto label_16;
        }
        
        label_7:
        val_8 = "Idle";
        goto label_17;
        label_13:
        if(val_2 == true)
        {
            goto label_18;
        }
        
        label_14:
        val_7 = "Idle";
        label_15:
        label_17:
        val_6.Play(stateName:  val_7);
    }
    protected override bool 丌下丟一不丕专丟专()
    {
        return this.IsX10;
    }
    private void 一三丌丝不丌丁丗丟()
    {
        var val_7;
        if(true == 0)
        {
                T[] val_1 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogWarningFormat(format:  "UpdateViewBestBuy: purchaseInfo == null", args:  val_1);
        }
        
        丅且东丙业丏丛东丛 val_2 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
        val_7 = 0;
        if(((this.IsX10 != true) && (val_2 != null)) && (val_1 != null))
        {
                val_7 = val_2.下丂丗丙且万丁且不(一丒丆业丅七丛且丏:  val_1);
        }
        
        bool val_6 = val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bestBuy.gameObject, 丏业丟一东丂东丘丛:  val_6);
        this.专业一丈丄与丑世七(万三东丆丂专丒丕丂:  val_6);
    }
    public BankViewItem()
    {
    
    }

}
