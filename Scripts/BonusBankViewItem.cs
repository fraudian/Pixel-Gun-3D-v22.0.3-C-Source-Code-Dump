using UnityEngine;
internal class BonusBankViewItem : RealInappBankViewItem
{
    // Fields
    private static System.Text.RegularExpressions.Regex 丁上三三且丐万与世;
    private UnityEngine.GameObject _moreLabel;
    private UILabel _contentLabel;
    private bool 东专丙七与丕丑丆丕;
    private UnityEngine.GameObject _saleBlue;
    private UnityEngine.GameObject _saleRed;
    private UnityEngine.GameObject _saleYellow;
    public UnityEngine.GameObject battlePassCurrency;
    private UIBasicSprite battlePassCurrencyIcon;
    public UILabel[] bonusViewHeader;
    private UIBasicSprite centerGadget;
    public System.Collections.Generic.List<UILabel> coinsQuantityLabels;
    public UnityEngine.GameObject currence;
    private UnityEngine.GameObject currencyObjectsBig;
    private UnityEngine.GameObject currencyObjectsSmall;
    public System.Collections.Generic.List<UILabel> descriptionLabels;
    public UnityEngine.GameObject details;
    public System.Collections.Generic.List<UILabel> detailsCountLabels;
    private UIBasicSprite detailsIcon;
    public System.Collections.Generic.List<UILabel> detailsItemName;
    public UnityEngine.GameObject eventCurrency;
    private UIBasicSprite eventCurrencyIcon;
    public UnityEngine.GameObject gadget;
    public System.Collections.Generic.List<UILabel> gemsQuantityLabels;
    public TweenColor itemsLeftColorTweener;
    public System.Collections.Generic.List<UILabel> itemsLeftLabels;
    public TweenScale itemsLeftTweener;
    private UIBasicSprite leftGadget;
    public UnityEngine.GameObject leprechaun;
    public UITexture leprechaunIcon;
    private BonusBankViewItem.丈丝丟丝丈上万万丝 丅七丐丆七丛七丏丏;
    public UnityEngine.GameObject offerPack;
    private PGCompany.BankCellColorsSetter _offerColorizer;
    private UnityEngine.GameObject _mainBody;
    private UnityEngine.GameObject _starterPackBody;
    private UnityEngine.GameObject _noviceBody1;
    private UnityEngine.GameObject _noviceBody2;
    private UnityEngine.GameObject _noviceBody3;
    private UnityEngine.GameObject _noviceBody4;
    private UnityEngine.GameObject _noviceBody5;
    private UIBasicSprite _offerTexture;
    public UILabel oldPriceLabel;
    private UIBasicSprite petIcon;
    public UnityEngine.GameObject pets;
    public UnityEngine.GameObject[] plus;
    public System.Collections.Generic.List<UILabel> profitLabels;
    public System.Collections.Generic.List<UnityEngine.GameObject> profitObjects;
    public UITable quantitiesTable;
    private UIBasicSprite redWeaponIcon;
    private UIBasicSprite rightGadget;
    public UnityEngine.GameObject vip;
    public System.Collections.Generic.List<UILabel> VipDaysLabels;
    public UnityEngine.GameObject weapon;
    private UnityEngine.GameObject _onlyBuyOnceBadge;
    private UnityEngine.GameObject _tierBundleObj;
    private UnityEngine.GameObject _tierBundlesTwoItems;
    private UnityEngine.GameObject _tierBundlesThreeItems;
    private UnityEngine.GameObject _tierBundlesFourItems;
    private int <丑丏一丆丐专丑丙丞>k__BackingField;
    private long <丄丐世丄丛且丆丝丏>k__BackingField;
    private bool <丅三三丅丞下专上丗>k__BackingField;
    private bool <下丂丝丙丘丟下丒与>k__BackingField;
    
    // Properties
    private UIBasicSprite 东丕丈世丝丗丟丛丝 { get; }
    private UIBasicSprite 丂不专丐三下丁专世 { get; }
    private UIBasicSprite 下不丛下七世且三丏 { get; }
    private UIBasicSprite 丙丛丆丕业万丁丂丟 { get; }
    private UIBasicSprite 不丌业丅与丂丑一丝 { get; }
    private UIBasicSprite 丆且丑世万万丄丘丆 { get; }
    private UIBasicSprite 专下丄丞丏丙下丁丄 { get; }
    private UIBasicSprite 丞下丙丟东业丏七丂 { get; }
    private int 丅丑下七丈东丁丞不 { get; set; }
    private long 丌与丁不下丅丆丘丞 { get; set; }
    private bool 丟丆且丈与丛丞且丑 { get; set; }
    private bool 丄不丗东与下丞丐丑 { get; set; }
    private BonusBankViewItem.丈丝丟丝丈上万万丝 丗丈上丂丟丙丆上丈 { get; }
    
    // Methods
    private UIBasicSprite 世丗且丈丁丝丑一三()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.petIcon);
        this.petIcon = val_1;
        return val_1;
    }
    private UIBasicSprite 丌一丕丏丟丑丟东且()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.leftGadget);
        this.leftGadget = val_1;
        return val_1;
    }
    private UIBasicSprite 下下下丛与上丘丗世()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.centerGadget);
        this.centerGadget = val_1;
        return val_1;
    }
    private UIBasicSprite 下与丏丆丝丁丙丟专()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.rightGadget);
        this.rightGadget = val_1;
        return val_1;
    }
    private UIBasicSprite 丕丐下七丂丆下七丐()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.redWeaponIcon);
        this.redWeaponIcon = val_1;
        return val_1;
    }
    private UIBasicSprite 不丅丈丙丏业丘世丅()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.detailsIcon);
        this.detailsIcon = val_1;
        return val_1;
    }
    private UIBasicSprite 丕丁丑丐丌丐丆下丌()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.eventCurrencyIcon);
        this.eventCurrencyIcon = val_1;
        return val_1;
    }
    private UIBasicSprite 业且专丑丘丕上东丝()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.battlePassCurrencyIcon);
        this.battlePassCurrencyIcon = val_1;
        return val_1;
    }
    private int 下丅丙丕业丁专丏丘()
    {
        return (int)this.<丑丏一丆丐专丑丙丞>k__BackingField;
    }
    private void 丈丘一专丕一丞丅丈(int 丙业与丙丗丝不丈东)
    {
        this.<丑丏一丆丐专丑丙丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private long 丙世丑丅丒丑业与不()
    {
        return (long)this.<丄丐世丄丛且丆丝丏>k__BackingField;
    }
    private void 七丐丁丗丕丒丐丒且(long 丙业与丙丗丝不丈东)
    {
        this.<丄丐世丄丛且丆丝丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private bool 丐丗世丄不业丐丆上()
    {
        return (bool)this.<丅三三丅丞下专上丗>k__BackingField;
    }
    private void 丟万丆丐丌丟丘世丘(bool 丙业与丙丗丝不丈东)
    {
        this.<丅三三丅丞下专上丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private bool 丂丗世丝三丏丄丄三()
    {
        return (bool)this.<下丂丝丙丘丟下丒与>k__BackingField;
    }
    private void 专丆万丝丌丆一丅丅(bool 丙业与丙丗丝不丈东)
    {
        this.<下丂丝丙丘丟下丒与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private BonusBankViewItem.丈丝丟丝丈上万万丝 下丏不丌丐丂丙丙丛()
    {
        丈丝丟丝丈上万万丝 val_40;
        string val_41;
        System.Object[] val_42;
        string val_43;
        var val_44;
        string val_45;
        val_40 = this.丅七丐丆七丛七丏丏;
        if(val_40 != null)
        {
                return val_40;
        }
        
        var val_40 = this.InappBonusParameters;
        object val_2 = val_40.Item["action"];
        if(val_2 != null)
        {
                val_40 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_41 = 0;
        }
        
        val_42 = 0;
        if((System.String.op_Equality(a:  val_41, b:  "offer")) != false)
        {
                if((this.InappBonusParameters != null) && ((this.InappBonusParameters.ContainsKey(key:  "offer-module")) != false))
        {
                val_43 = this.InappBonusParameters.Item["offer-id"];
            if((val_43 != null) && (null != null))
        {
                val_43 = 0;
        }
        
            val_42 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_43);
        }
        else
        {
                val_42 = 0;
        }
        
        }
        
        uint val_12 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_41);
        if(val_12 > 1865621569)
        {
            goto label_16;
        }
        
        if(val_12 > 1480434725)
        {
            goto label_17;
        }
        
        if(val_12 == 172652105)
        {
            goto label_18;
        }
        
        if(val_12 == 901750319)
        {
            goto label_19;
        }
        
        if((val_12 != 1480434725) || ((System.String.op_Equality(a:  val_41, b:  "parts")) == false))
        {
            goto label_66;
        }
        
        BonusBankViewItem.丗丞世丒丏三世一丟 val_14 = null;
        val_40 = val_14;
        val_14 = new BonusBankViewItem.丗丞世丒丏三世一丟();
        goto label_74;
        label_16:
        if(val_12 > (-844536739))
        {
            goto label_23;
        }
        
        if(val_12 > 2053176545)
        {
            goto label_24;
        }
        
        if(val_12 == 1930522572)
        {
            goto label_25;
        }
        
        if((val_12 != 2053176545) || ((System.String.op_Equality(a:  val_41, b:  "craft_lobby_items")) == false))
        {
            goto label_66;
        }
        
        val_44 = 1152921505212542976;
        goto label_63;
        label_17:
        if(val_12 > 1701332399)
        {
            goto label_29;
        }
        
        if(val_12 == 1525347427)
        {
            goto label_30;
        }
        
        if((val_12 != 1701332399) || ((System.String.op_Equality(a:  val_41, b:  "event_currence")) == false))
        {
            goto label_66;
        }
        
        val_44 = 1152921505212276736;
        goto label_63;
        label_23:
        if(val_12 > (-638418966))
        {
            goto label_34;
        }
        
        if(val_12 == (-678470815))
        {
            goto label_35;
        }
        
        if((val_12 != (-638418966)) || ((System.String.op_Equality(a:  val_41, b:  "currence")) == false))
        {
            goto label_66;
        }
        
        goto label_38;
        label_24:
        if(val_12 == (-1042691619))
        {
            goto label_39;
        }
        
        if((val_12 != (-844536739)) || ((System.String.op_Equality(a:  val_41, b:  "gadget")) == false))
        {
            goto label_66;
        }
        
        val_44 = 1152921505212649472;
        goto label_63;
        label_29:
        if(val_12 == 1766558334)
        {
            goto label_43;
        }
        
        if((val_12 != 1865621569) || ((System.String.op_Equality(a:  val_41, b:  "weapon")) == false))
        {
            goto label_66;
        }
        
        BonusBankViewItem.三丗丂丛丕上一上东 val_20 = null;
        val_40 = val_20;
        val_20 = new BonusBankViewItem.三丗丂丛丕上一上东();
        goto label_74;
        label_34:
        if(val_12 == (-457432930))
        {
            goto label_47;
        }
        
        if(val_12 != (-349333172))
        {
            goto label_66;
        }
        
        val_45 = "leprechaun";
        goto label_49;
        label_19:
        if((System.String.op_Equality(a:  val_41, b:  "royale")) == false)
        {
            goto label_66;
        }
        
        val_44 = 1152921505212702720;
        label_63:
        BonusBankViewItem.丄丐七且专下丙东业 val_22 = null;
        val_40 = val_22;
        val_22 = new BonusBankViewItem.丄丐七且专下丙东业();
        goto label_74;
        label_18:
        if((System.String.op_Equality(a:  val_41, b:  "battlePassCurrency")) == false)
        {
            goto label_66;
        }
        
        BonusBankViewItem.丒丂丑东丛丝丕与业 val_24 = null;
        val_40 = val_24;
        val_24 = new BonusBankViewItem.丒丂丑东丛丝丕与业();
        goto label_74;
        label_25:
        if((System.String.op_Equality(a:  val_41, b:  "vipInSeconds")) == false)
        {
            goto label_66;
        }
        
        BonusBankViewItem.且业丈丟世一丗丒上 val_26 = null;
        val_40 = val_26;
        val_26 = new BonusBankViewItem.且业丈丟世一丗丒上();
        goto label_74;
        label_30:
        val_45 = "leprechaun_one";
        label_49:
        if((System.String.op_Equality(a:  val_41, b:  val_45)) == false)
        {
            goto label_66;
        }
        
        BonusBankViewItem.东丄丛丏丛专万丆业 val_28 = null;
        val_40 = val_28;
        val_28 = new BonusBankViewItem.东丄丛丏丛专万丆业();
        goto label_74;
        label_35:
        if((System.String.op_Equality(a:  val_41, b:  "mix")) == false)
        {
            goto label_66;
        }
        
        BonusBankViewItem.业丏且丂丆东丌世丂 val_30 = null;
        val_40 = val_30;
        val_30 = new BonusBankViewItem.业丏且丂丆东丌世丂();
        goto label_74;
        label_39:
        if((System.String.op_Equality(a:  val_41, b:  "offer")) == false)
        {
            goto label_66;
        }
        
        if((val_42 == 0) || (val_42.丑且一丐东三不丈丝() != 140))
        {
            goto label_62;
        }
        
        goto label_63;
        label_43:
        if((System.String.op_Equality(a:  val_41, b:  "pet")) == false)
        {
            goto label_66;
        }
        
        BonusBankViewItem.丏丛与丐业丑世与丙 val_34 = null;
        val_40 = val_34;
        val_34 = new BonusBankViewItem.丏丛与丐业丑世与丙();
        goto label_74;
        label_47:
        if((System.String.op_Equality(a:  val_41, b:  "wear")) == false)
        {
            goto label_66;
        }
        
        BonusBankViewItem.丗下丝丞丁丒丙丄业 val_36 = null;
        val_40 = val_36;
        val_36 = new BonusBankViewItem.丗下丝丞丁丒丙丄业();
        goto label_74;
        label_66:
        object[] val_37 = new object[1];
        val_42 = val_37;
        val_42[0] = val_41;
        UnityEngine.Debug.LogErrorFormat(format:  "Unknown action type:  {0}", args:  val_37);
        label_38:
        BonusBankViewItem.丏丄万丄丏丐丁丆丘 val_38 = null;
        val_40 = val_38;
        val_38 = new BonusBankViewItem.丏丄万丄丏丐丁丆丘();
        label_74:
        this.丅七丐丆七丛七丏丏 = val_40;
        return val_40;
        label_62:
        BonusBankViewItem.且丁丗七丟丒七丄丌 val_39 = new BonusBankViewItem.且丁丗七丟丒七丄丌();
        goto label_74;
    }
    public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丑业丄不丏丏丒丗丏)
    {
        BonusBankViewItem val_18;
        string val_20;
        val_18 = this;
        object val_7 = 0;
        if(东丈丏东丑丟不不丞 == null)
        {
            goto label_1;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        goto label_5;
        label_1:
        val_18 = System.Array.Empty<System.Object>();
        val_20 = "BonusBankViewItem.Setup: product == null";
        goto label_20;
        label_5:
        if(东丈丏东丑丟不不丞.业上丙丞丐丄丆丅七() == null)
        {
            goto label_9;
        }
        
        this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  0, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丑业丄不丏丏丒丗丏:  丑业丄不丏丏丒丗丏);
        if(this.InappBonusParameters == null)
        {
            goto label_10;
        }
        
        this.丅七丐丆七丛七丏丏 = 0;
        this.下丏不丌丐丂丙丙丛().上东与丛丞下丈专丈(丑一丞且专世丆丈丛:  this);
        bool val_20 = this.InappBonusParameters.TryGetValue(key:  "Type", value: out  val_7);
        if(val_7 != 0)
        {
                val_20 = val_20 ^ 1;
            if(val_20 != true)
        {
                if(1179403647 == null)
        {
            goto label_15;
        }
        
        }
        
        }
        
        this.<丅三三丅丞下专上丗>k__BackingField = false;
        label_23:
        this.<丄丐世丄丛且丆丝丏>k__BackingField = BonusBankViewItem.丒世一丗三且世专七(丏业一丒三丐丌一丄:  this.InappBonusParameters.Item["EndTime"]);
        this.丅丏丅丘丗世丘万丆();
        return;
        label_9:
        val_18 = System.Array.Empty<System.Object>();
        val_20 = "BonusBankViewItem.Setup: product.Id == null";
        goto label_20;
        label_10:
        val_18 = System.Array.Empty<System.Object>();
        val_20 = "BonusBankViewItem.Setup: offerParameters == null";
        label_20:
        UnityEngine.Debug.LogErrorFormat(format:  val_20, args:  val_18);
        return;
        label_15:
        bool val_14 = System.String.op_Equality(a:  val_7, b:  "packs");
        this.<丅三三丅丞下专上丗>k__BackingField = val_14;
        if(val_14 == false)
        {
            goto label_23;
        }
        
        this.<丑丏一丆丐专丑丙丞>k__BackingField = BonusBankViewItem.丄丗一一与不东万丅(七丐丅专且专七三丆:  this.InappBonusParameters);
        this.世丛业七专万业不丕();
    }
    private static int 丄丗一一与不东万丅(System.Collections.Generic.Dictionary<string, object> 七丐丅专且专七三丆)
    {
        string val_7;
        object val_1 = 七丐丅专且专七三丆.Item["Key"];
        object val_2 = 七丐丅专且专七三丆.Item["StartTime"];
        object val_4 = 七丐丅专且专七三丆.Item["EndTime"];
        object val_5 = 七丐丅专且专七三丆.Item["FullPack"];
        if(val_1 != null)
        {
                var val_6 = (null == null) ? (val_1) : 0;
            return BalanceController.丌丄丂不丄七业丟三(丆丟丁丆万丂世丑丞:  val_7 = 0, 丄且一丄丏丆丐丗与:  1152921504628731904, 丅丏丅丂丝一丆丙丅:  FriendsController.丝丗专上三不丄丑丑(), 丈丝世且万世丈丌万:  1152921504628731904, 丞丐丗丌丂上与丞丌:  21884928);
        }
        
        return BalanceController.丌丄丂不丄七业丟三(丆丟丁丆万丂世丑丞:  val_7, 丄且一丄丏丆丐丗与:  1152921504628731904, 丅丏丅丂丝一丆丙丅:  FriendsController.丝丗专上三不丄丑丑(), 丈丝世且万世丈丌万:  1152921504628731904, 丞丐丗丌丂上与丞丌:  21884928);
    }
    private System.Collections.IEnumerator 丌万丞丒丁丅上三丁()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BonusBankViewItem.专与与丄丕丈丙丞丅(丗丏丅丕丆世丁专丟:  0);
    }
    private void 上丗不丕丅丏上丂丕()
    {
        System.Object[] val_24;
        var val_25;
        string val_26;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_27;
        object val_28;
        val_24 = this;
        if((X21 != 0) && (this.东专丙七与丕丑丆丕 != true))
        {
                UIPanel val_3 = this.不丘丁专丙丈万丌丑();
            if(val_3 != 0)
        {
                val_25 = mem[X22 + 24];
            val_25 = X22 + 24;
            if(val_25 == 0)
        {
                val_25 = mem[X22 + 24];
            val_25 = X22 + 24;
        }
        
            if(val_25 <= 1)
        {
                val_25 = mem[X22 + 24];
            val_25 = X22 + 24;
        }
        
            if(val_25 <= 2)
        {
                val_25 = mem[X22 + 24];
            val_25 = X22 + 24;
        }
        
            if((val_3.IsVisible(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = X22 + 32, y = X22 + 32 + 4, z = X22 + 40}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = X22 + 44, y = X22 + 44 + 4, z = X22 + 52}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = X22 + 56, y = X22 + 64, z = X22 + 68}, 丐丆丂丒丁万丈丛丅:  new UnityEngine.Vector3() {x = X22 + 76, y = X22 + 44 + 4, z = X22 + 40})) != false)
        {
                this.东专丙七与丕丑丆丕 = val_3.isVisible;
            if((this.InappBonusParameters.ContainsKey(key:  "Key")) != false)
        {
                object val_11 = this.InappBonusParameters.Item["Key"];
            if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_26 = 0;
        }
        
            BalanceController.丑丂丏三东业丅丆丙(丝丄丟丅丑下丐丄丁:  val_26);
        }
        
        }
        
        }
        
        }
        
        val_27 = this.InappBonusParameters;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = 一下丛与丛丛万万丏.万专东丘丅丗不且丒(丒且丑业丑丈不丌丗:  val_27, 丟丁丈丌上丟东丘丆:  BalanceController.下丂万丐丄丅七一东());
        if(val_14 == null)
        {
            goto label_28;
        }
        
        if((this.<丅三三丅丞下专上丗>k__BackingField) == false)
        {
            goto label_29;
        }
        
        val_28 = BonusBankViewItem.丄丗一一与不东万丅(七丐丅专且专七三丆:  val_14);
        goto label_30;
        label_28:
        val_24 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogWarningFormat(format:  "BonusBankViewItem.Update: currentInappBonusAction == null", args:  val_24);
        return;
        label_29:
        val_28 = val_14.Item["EndTime"];
        label_30:
        if((this.<丅三三丅丞下专上丗>k__BackingField) != false)
        {
                val_27 = this.<丑丏一丆丐专丑丙丞>k__BackingField;
        }
        
        if((((BonusBankViewItem.丒世一丗三且世专七(丏业一丒三丐丌一丄:  val_28)) != (this.<丄丐世丄丛且丆丝丏>k__BackingField)) ? 1 : 0) == 0)
        {
                return;
        }
        
        if((this.<下丂丝丙丘丟下丒与>k__BackingField) == true)
        {
                return;
        }
        
        if((this.<丅三三丅丞下专上丗>k__BackingField) != false)
        {
                this.<丑丏一丆丐专丑丙丞>k__BackingField = null;
        }
        else
        {
                this.<丄丐世丄丛且丆丝丏>k__BackingField = BonusBankViewItem.丒世一丗三且世专七(丏业一丒三丐丌一丄:  val_28);
        }
        
        this.itemsLeftTweener.ResetToBeginning();
        this.itemsLeftTweener.PlayForward();
        if(this.itemsLeftColorTweener != 0)
        {
                this.itemsLeftColorTweener.ResetToBeginning();
            this.itemsLeftColorTweener.PlayForward();
        }
        
        this.<下丂丝丙丘丟下丒与>k__BackingField = true;
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.丞下丗丒丆七丂丐上());
    }
    private static long 丒世一丗三且世专七(object 丏业一丒三丐丌一丄)
    {
        return System.Math.Max(val1:  0, val2:  (System.Convert.ToInt64(value:  丏业一丒三丐丌一丄)) - FriendsController.丝丗专上三不丄丑丑());
    }
    private void 世丛业七专万业不丕()
    {
        string val_9;
        string val_10;
        string val_11;
        BonusBankViewItem.丗且丈丂丁丄专丞专 val_1 = new BonusBankViewItem.丗且丈丂丁丄专丞专();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .不丗丆专业丈丞东七 = "Key_2864";
        var val_9 = this.InappBonusParameters;
        object val_3 = val_9.Item["action"];
        if(val_3 != null)
        {
                val_9 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        uint val_4 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_9);
        if(val_4 > 1865621569)
        {
            goto label_6;
        }
        
        if(val_4 > 1480434725)
        {
            goto label_7;
        }
        
        if(val_4 == 172652105)
        {
            goto label_8;
        }
        
        if(val_4 != 1480434725)
        {
            goto label_28;
        }
        
        val_10 = "parts";
        goto label_26;
        label_6:
        if(val_4 > (-844536739))
        {
            goto label_11;
        }
        
        if(val_4 == (-844536739))
        {
            goto label_12;
        }
        
        if(val_4 == 1930522572)
        {
            goto label_13;
        }
        
        if(val_4 != 2053176545)
        {
            goto label_28;
        }
        
        val_11 = "craft_lobby_items";
        goto label_30;
        label_7:
        if(val_4 == 1701332399)
        {
            goto label_16;
        }
        
        if(val_4 == 1766558334)
        {
            goto label_17;
        }
        
        if(val_4 != 1865621569)
        {
            goto label_28;
        }
        
        val_10 = "weapon";
        goto label_26;
        label_11:
        if(val_4 == (-638418966))
        {
            goto label_20;
        }
        
        if(val_4 == (-457432930))
        {
            goto label_21;
        }
        
        if(val_4 != (-349333172))
        {
            goto label_28;
        }
        
        val_10 = "leprechaun";
        goto label_26;
        label_8:
        val_11 = "battlePassCurrency";
        goto label_30;
        label_12:
        val_11 = "gadget";
        goto label_30;
        label_13:
        val_10 = "vipInSeconds";
        goto label_26;
        label_16:
        val_11 = "event_currence";
        goto label_30;
        label_17:
        val_10 = "pet";
        label_26:
        if((System.String.op_Equality(a:  val_9, b:  val_10)) == false)
        {
            goto label_28;
        }
        
        .不丗丆专业丈丞东七 = "Key_2896";
        goto label_31;
        label_20:
        val_11 = "currence";
        goto label_30;
        label_21:
        val_11 = "wear";
        label_30:
        if((System.String.op_Equality(a:  val_9, b:  val_11)) == true)
        {
            goto label_31;
        }
        
        label_28:
        object[] val_7 = new object[1];
        val_7[0] = val_9;
        UnityEngine.Debug.LogErrorFormat(format:  "UpdateItemsLeft Unknown action type:  {0}", args:  val_7);
        label_31:
        this.itemsLeftLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丗且丈丂丁丄专丞专::丌且下丅丆丈万丝上(UILabel 七丐丞丑丑丕世丙七)));
    }
    private void 丅丏丅丘丗世丘万丆()
    {
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)this.<丄丐世丄丛且丆丝丏>k__BackingField);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.itemsLeftLabels, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_1._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
    }
    private System.Collections.IEnumerator 丞下丗丒丆七丂丐上()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BonusBankViewItem.且丛丏丗三丒丝上三(丗丏丅丕丆世丁专丟:  0);
    }
    protected override void Awake()
    {
        this.Awake();
    }
    protected override void OnEnable()
    {
        this.<下丂丝丙丘丟下丒与>k__BackingField = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丌万丞丒丁丅上三丁());
    }
    protected override void OnDisable()
    {
    
    }
    protected override void 丞业与下丛万丁下丙()
    {
        this.下丏不丌丐丂丙丙丛().丞业与下丛万丁下丙(丑一丞且专世丆丈丛:  this);
    }
    private static string 丐与丕丘丈丙丏丏专(string 丏丂不专上丘丂不丅)
    {
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
        {
            goto label_4;
        }
        
        }
        
        return "%";
        label_4:
        if(丏丂不专上丘丂不丅 != null)
        {
                return "%";
        }
        
        return "%";
    }
    internal static string 丏丈丞丁不丐丆丌丏(Rilisoft.与丗丌丑专业丝丛丏 丂三丟世世万丘丕丗, decimal 丒丈与丏丙且丑一丝)
    {
        decimal val_1 = BonusBankViewItem.丒丑七世丕丞七丁丑(东丈丏东丑丟不不丞:  丂三丟世世万丘丕丗, 丒丈与丏丙且丑一丝:  new System.Decimal() {flags = 丒丈与丏丙且丑一丝.flags, hi = 丒丈与丏丙且丑一丝.hi, lo = 丒丈与丏丙且丑一丝.lo, mid = 丒丈与丏丙且丑一丝.mid});
        decimal val_2 = System.Math.Round(d:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, decimals:  0, mode:  1);
        var val_8 = 0;
        val_8 = val_8 + 1;
        return (string)BonusBankViewItem.丗丒且丁三三丗丁丝(丏丂不专上丘丂不丅:  丂三丟世世万丘丕丗.东与三丌丅三丒丏业(), 丑不业丏丏与丌丘上:  val_2.flags.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
    }
    internal static string 丗丒且丁三三丗丁丝(string 丏丂不专上丘丂不丅, string 丑不业丏丏与丌丘上)
    {
        object val_4;
        string val_5;
        object val_6;
        object val_7;
        val_4 = BonusBankViewItem.丐与丕丘丈丙丏丏专(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅);
        if((val_4.Contains(value:  "$")) == false)
        {
            goto label_2;
        }
        
        val_5 = "{0}{1}{2}";
        goto label_3;
        label_2:
        val_5 = "{0}{1}{2}";
        if((val_4.IndexOf(value:  "usd", comparisonType:  5)) == 1)
        {
            goto label_5;
        }
        
        label_3:
        val_6 = 丑不业丏丏与丌丘上;
        return System.String.Format(format:  val_5, arg0:  val_4 = 丑不业丏丏与丌丘上, arg1:  val_7 = " ", arg2:  val_6 = val_4);
        label_5:
        return System.String.Format(format:  val_5, arg0:  val_4, arg1:  val_7, arg2:  val_6);
    }
    internal static string 丑丈丒丅丝丕世丞丗(decimal 丙业与丙丗丝不丈东, string 七丏丂丈世万丈上丕 = "F2")
    {
        string val_7;
        StoreKitEventListener val_8;
        int val_9;
        var val_10;
        System.Int32[] val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_7 = 七丏丂丈世万丈上丕;
        val_8 = 0;
        val_9 = System.String.alignConst;
        goto label_1;
        label_10:
        val_10 = null;
        val_10 = null;
        val_11 = 0;
        if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == 1)
        {
            goto label_6;
        }
        
        val_8 = 1;
        label_1:
        val_12 = null;
        val_12 = null;
        val_11 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
        if(val_8 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
        {
            goto label_10;
        }
        
        goto label_11;
        label_6:
        val_13 = null;
        val_13 = null;
        val_9 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
        val_9 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
        label_11:
        val_14 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true)
        {
                return (string)val_3.Replace(input:  val_2.丟丂丞不专丆万丒世(), replacement:  val_7 = 丙业与丙丗丝不丈东.flags.ToString(format:  val_7), count:  1);
        }
        
        val_15 = null;
        val_15 = null;
        val_8 = StoreKitEventListener.丆丕丝丒不丙且丐丗;
        Rilisoft.与丗丌丑专业丝丛丏 val_2 = val_8.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_9);
        if(val_2 == null)
        {
                return (string)val_3.Replace(input:  val_2.丟丂丞不专丆万丒世(), replacement:  val_7, count:  1);
        }
        
        if(BonusBankViewItem.丁上三三且丐万与世 == null)
        {
                System.Text.RegularExpressions.Regex val_3 = new System.Text.RegularExpressions.Regex(pattern:  "[\\d.,]+");
            BonusBankViewItem.丁上三三且丐万与世 = val_3;
        }
        
        val_8 = BonusBankViewItem.丁上三三且丐万与世;
        var val_8 = 0;
        val_8 = val_8 + 1;
        return (string)val_3.Replace(input:  val_2.丟丂丞不专丆万丒世(), replacement:  val_7, count:  1);
    }
    private static decimal 丒丑七世丕丞七丁丑(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, decimal 丒丈与丏丙且丑一丝)
    {
        var val_7;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
        {
            goto label_4;
        }
        
        }
        
        label_19:
        decimal val_3 = System.Decimal.Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 丒丈与丏丙且丑一丝.flags, hi = 丒丈与丏丙且丑一丝.hi, lo = 丒丈与丏丙且丑一丝.lo, mid = 丒丈与丏丙且丑一丝.mid});
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
        label_4:
        if(东丈丏东丑丟不不丞 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
        }
        else
        {
                UnityEngine.Debug.LogErrorFormat(format:  "CalculateProfit: product == null", args:  System.Array.Empty<System.Object>());
            val_7 = null;
            val_7 = null;
            return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
        }
        
        decimal val_6 = 东丈丏东丑丟不不丞.丈业且丆七三丛丙丙();
        goto label_19;
    }
    public void SetSaleBackground(BonusBankViewItem.七世丌专丙三万七丘 丁丅丈丌丟世丗丗丟)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleRed, 丏业丟一东丂东丘丛:  (丁丅丈丌丟世丗丗丟 == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleBlue, 丏业丟一东丂东丘丛:  (丁丅丈丌丟世丗丗丟 == 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleYellow, 丏业丟一东丂东丘丛:  (丁丅丈丌丟世丗丗丟 == 2) ? 1 : 0);
    }
    public BonusBankViewItem()
    {
    
    }

}
