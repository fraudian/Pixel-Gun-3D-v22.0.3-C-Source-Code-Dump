using UnityEngine;
internal class EventStoreSkinBankViewItem : AbstractBankViewItem
{
    // Fields
    private System.Collections.Generic.List<UILabel> _nameLabels;
    private EventStoreBankViewActionSpecificElement _defaultSpecificElement;
    private EventStoreBankPriceView _priceView;
    private UnityEngine.GameObject _isBoughtObject;
    private UnityEngine.GameObject _timeEndObject;
    private UnityEngine.GameObject _timeLeftObject;
    private UILabel _timeLeftLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> _disableIfBought;
    private UnityEngine.GameObject _enoughtForCraft;
    private UILabel _descriptionLabel;
    private UnityEngine.GameObject _upgradeContainer;
    private UILabel _upgradeLabel;
    private UnityEngine.GameObject _weaponContainer;
    private UnityEngine.GameObject _skinContainer;
    private UIBasicSprite _weaponTexture;
    private UnityEngine.Transform _backgroundHolder;
    private UnityEngine.Transform _decorationHolder;
    private UnityEngine.GameObject _soldedMark;
    private long 丛丗丑世业业丐丙丘;
    private float 丆上三与万丈丙一丁;
    private long 三丌世世下丐丈一丅;
    private bool 丈丛丘丈与世三丏丒;
    private Rilisoft.OfferItem 下丁三一业万丐丘东;
    private Rilisoft.OfferItem 业上丑且三丕三丁下;
    private Rilisoft.OfferItem 丗上丕与丂丙万世东;
    private Rilisoft.OfferItem 丕丗世丈七东丛下丗;
    private Rilisoft.OfferItem 丛下不丌七东丂丐上;
    private Rilisoft.OfferItem 业丁丘丂丙丝丛丏世;
    private Rilisoft.OfferItem 不丐且丐丐不丛丞丑;
    private static readonly Rilisoft.OfferItemType[] 与丈丂一丌三丈丟丅;
    
    // Properties
    private System.Nullable<System.TimeSpan> 丌与丁不下丅丆丘丞 { get; }
    
    // Methods
    private System.Nullable<System.TimeSpan> 丙世丑丅丒丑业与不()
    {
        var val_10;
        var val_11;
        val_10 = this;
        val_11 = 0;
        if(this.Offer == null)
        {
            goto label_5;
        }
        
        if(this.Offer.丑且一丐东三不丈丝() == 60)
        {
            goto label_3;
        }
        
        val_11 = 0;
        if(this.Offer.丑且一丐东三不丈丝() != 80)
        {
            goto label_5;
        }
        
        label_3:
        val_10 = this.Offer;
        val_11 = 0;
        System.Nullable<System.TimeSpan> val_7 = val_10.丙世丑丅丒丑业与不();
        return 0;
        label_5:
        long val_9 = this.三丌世世下丐丈一丅;
        if((val_9 < 1) || (this.丛丗丑世业业丐丙丘 <= 0))
        {
                return 0;
        }
        
        val_9 = val_9 - this.丛丗丑世业业丐丙丘;
        val_9 = val_9 - (long)this.丆上三与万丈丙一丁;
        val_10 = val_9 & (~(val_9 >> 63));
        System.TimeSpan val_8 = System.TimeSpan.FromSeconds(value:  (double)val_10);
        val_11 = val_8._ticks;
        return 0;
    }
    protected override void OnDisable()
    {
    
    }
    protected override void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
    }
    public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丛与世且丑丅丟下丛)
    {
        System.EventHandler val_9 = 丄丆丘丏万三丞丐丏;
        this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  val_9 = 丄丆丘丏万三丞丐丏, 丛与世且丑丅丟下丛:  丛与世且丑丅丟下丛);
        if(丙业丞丑七丗下丟丌 == null)
        {
            goto label_9;
        }
        
        if(丙业丞丑七丗下丟丌.丑且一丐东三不丈丝() != 60)
        {
            goto label_2;
        }
        
        Progress.OfferProgress val_2 = 丙业丞丑七丗下丟丌.业丑丁丆丕丆丂丅万();
        val_9 = val_2.FirstShowDate;
        Rilisoft.七丈业与与不七丈丟 val_3 = 丙业丞丑七丗下丟丌.丁专丗万三上丟三丆();
        int val_9 = val_3.且与丙丑丕专七丈专;
        val_9 = val_9 + val_9;
        this.三丌世世下丐丈一丅 = (long)val_9;
        goto label_9;
        label_2:
        if(丙业丞丑七丗下丟丌.丑且一丐东三不丈丝() != 80)
        {
            goto label_6;
        }
        
        long val_5 = 丙业丞丑七丗下丟丌.丘三丙丑一东世丛东();
        goto label_7;
        label_6:
        Rilisoft.Offers.且丟与业万丄下丆万 val_7 = this.Offer.丞丂业丄丞与专丛丒<Rilisoft.Offers.且丟与业万丄下丆万>();
        if(val_7 == null)
        {
            goto label_9;
        }
        
        label_7:
        this.三丌世世下丐丈一丅 = val_7.丐丈丅丅世三七七丝();
        label_9:
        this.丝一丅丆三东丂丞七();
    }
    protected override void 丞业与下丛万丁下丙()
    {
    
    }
    private void 丝一丅丆三东丂丞七()
    {
        bool val_67;
        var val_68;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_70;
        var val_71;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_73;
        var val_74;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_76;
        var val_77;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_79;
        Rilisoft.OfferItem val_80;
        Rilisoft.OfferItem val_81;
        var val_82;
        var val_83;
        var val_84;
        Rilisoft.OfferItem val_86;
        var val_87;
        UILabel val_89;
        Rilisoft.OfferItem val_91;
        Rilisoft.OfferItem val_92;
        bool val_93;
        UnityEngine.GameObject val_94;
        System.Collections.Generic.List<UnityEngine.GameObject> val_95;
        if(this.Offer == null)
        {
                return;
        }
        
        val_67 = this.Offer.世一丒专丛丏世丁丙();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._soldedMark, 丏业丟一东丂东丘丛:  val_67);
        if(this.丛丗丑世业业丐丙丘 == 0)
        {
                if(FriendsController.丝丗专上三不丄丑丑() >= 1)
        {
                this.丛丗丑世业业丐丙丘 = FriendsController.丝丗专上三不丄丑丑();
        }
        
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_8 = this.Offer.丏与丅专三丙与丘丒();
        if(val_8 == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_8)) == false)
        {
                return;
        }
        
        val_68 = null;
        val_68 = null;
        val_70 = EventStoreSkinBankViewItem.<>c.<>9__36_0;
        if(val_70 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_10 = null;
            val_70 = val_10;
            val_10 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  EventStoreSkinBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventStoreSkinBankViewItem.<>c::上丂与丐业丘上与丕(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            EventStoreSkinBankViewItem.<>c.<>9__36_0 = val_70;
        }
        
        this.业丁丘丂丙丝丛丏世 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_8, predicate:  val_10);
        val_71 = null;
        val_71 = null;
        val_73 = EventStoreSkinBankViewItem.<>c.<>9__36_1;
        if(val_73 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_12 = null;
            val_73 = val_12;
            val_12 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  EventStoreSkinBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventStoreSkinBankViewItem.<>c::丙七丄世且丛万东丆(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            EventStoreSkinBankViewItem.<>c.<>9__36_1 = val_73;
        }
        
        this.丗上丕与丂丙万世东 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_8, predicate:  val_12);
        val_74 = null;
        val_74 = null;
        val_76 = EventStoreSkinBankViewItem.<>c.<>9__36_2;
        if(val_76 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_14 = null;
            val_76 = val_14;
            val_14 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  EventStoreSkinBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventStoreSkinBankViewItem.<>c::下业丈丂上与且丈丐(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            EventStoreSkinBankViewItem.<>c.<>9__36_2 = val_76;
        }
        
        this.丕丗世丈七东丛下丗 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_8, predicate:  val_14);
        val_77 = null;
        val_77 = null;
        val_79 = EventStoreSkinBankViewItem.<>c.<>9__36_3;
        if(val_79 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_16 = null;
            val_79 = val_16;
            val_16 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  EventStoreSkinBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventStoreSkinBankViewItem.<>c::三丒丄丛丅丆业七丗(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            EventStoreSkinBankViewItem.<>c.<>9__36_3 = val_79;
        }
        
        Rilisoft.OfferItem val_17 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_8, predicate:  val_16);
        val_80 = this.业丁丘丂丙丝丛丏世;
        this.丛下不丌七东丂丐上 = val_17;
        if(val_80 != null)
        {
            goto label_35;
        }
        
        val_80 = this.丗上丕与丂丙万世东;
        if(val_80 != null)
        {
            goto label_35;
        }
        
        val_80 = this.丕丗世丈七东丛下丗;
        if(val_80 == null)
        {
            goto label_36;
        }
        
        label_35:
        val_81 = this.下丁三一业万丐丘东;
        this.下丁三一业万丐丘东 = val_80;
        label_139:
        if(val_8.Count < 2)
        {
            goto label_48;
        }
        
        val_82 = null;
        val_82 = null;
        val_83 = 0;
        goto label_40;
        label_47:
        .丁丅丈丌丟世丗丗丟 = EventStoreSkinBankViewItem.与丈丂一丌三丈丟丅.Length + 32;
        if(mem[this.下丁三一业万丐丘东].Type == (EventStoreSkinBankViewItem.且且丛丌丝三丏丙丛)[1152921538011736608].丁丅丈丌丟世丗丗丟)
        {
            goto label_44;
        }
        
        Rilisoft.OfferItem val_22 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_8, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new EventStoreSkinBankViewItem.且且丛丌丝三丏丙丛(), method:  System.Boolean EventStoreSkinBankViewItem.且且丛丌丝三丏丙丛::丄且丆七七丄不丝万(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)));
        if(val_22 != null)
        {
            goto label_45;
        }
        
        label_44:
        val_83 = 1;
        label_40:
        if(val_83 < EventStoreSkinBankViewItem.与丈丂一丌三丈丟丅.Length)
        {
            goto label_47;
        }
        
        goto label_48;
        label_45:
        this.业上丑且三丕三丁下 = val_22;
        label_48:
        this.不丐且丐丐不丛丞丑 = Rilisoft.Offers.上一丈丏三丒三丙不.专与一丌专丁丝丗东(丟专丑丈七与上七丞:  val_8);
        UnityEngine.Texture val_24 = this.下丁三一业万丐丘东.Texture;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_8, 与万丆丛丒万丝丙丑:  val_24);
        if(this.丕丗世丈七东丛下丗 != null)
        {
                System.Nullable<ItemRarity> val_25 = this.不丐且丐丐不丛丞丑.Rarity;
            string val_29 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  UnityEngine.Mathf.Min(a:  5, b:  this.丕丗世丈七东丛下丗.Count +));
        }
        else
        {
                if(this.不丐且丐丐不丛丞丑 == null)
        {
            goto label_91;
        }
        
            System.Nullable<CategoryNames> val_30 = this.不丐且丐丐不丛丞丑.Category;
            val_84 = "[-]";
        }
        
        label_91:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_24, 丕丗丘丑丛与丑业丒:  "[FFE600]" + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.与丅丙专且世丂丝丈(七丆丒与丗丌丄且丂:  val_30.HasValue))(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.与丅丙专且世丂丝丈(七丆丒与丗丌丄且丂:  val_30.HasValue))) + "[-]"("[-]"));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._upgradeContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._skinContainer, 丏业丟一东丂东丘丛:  false);
        if(this.丗上丕与丂丙万世东 == null)
        {
            goto label_69;
        }
        
        val_86 = this.丕丗世丈七东丛下丗;
        if((val_86 == null) || (this.业丁丘丂丙丝丛丏世 == null))
        {
            goto label_69;
        }
        
        val_87 = 1;
        var val_34 = (this.丛下不丌七东丂丐上 != 0) ? 1 : 0;
        goto label_70;
        label_69:
        if(this.业上丑且三丕三丁下 != null)
        {
                if(mem[this.下丁三一业万丐丘东].Type != 1340)
        {
            goto label_73;
        }
        
        }
        
        if(mem[this.下丁三一业万丐丘东].Type != 1170)
        {
            goto label_75;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._skinContainer, 丏业丟一东丂东丘丛:  true);
        val_89 = this._descriptionLabel;
        string val_37 = this.下丁三一业万丐丘东.Name;
        goto label_79;
        label_75:
        if(mem[this.下丁三一业万丐丘东].Type != 1340)
        {
            goto label_136;
        }
        
        val_91 = this.丛下不丌七东丂丐上;
        val_92 = this.业丁丘丂丙丝丛丏世;
        val_86 = this.下丁三一业万丐丘东;
        goto label_82;
        label_73:
        if(this.业上丑且三丕三丁下.Type != 10)
        {
            goto label_84;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._weaponTexture, 与万丆丛丒万丝丙丑:  this.不丐且丐丐不丛丞丑.Texture);
        val_89 = this._descriptionLabel;
        label_79:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_89, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8556"));
        goto label_136;
        label_84:
        if(this.业上丑且三丕三丁下.Type != 1340)
        {
            goto label_93;
        }
        
        val_91 = this.丛下不丌七东丂丐上;
        val_92 = this.业丁丘丂丙丝丛丏世;
        val_86 = this.丕丗世丈七东丛下丗;
        label_82:
        label_137:
        label_70:
        this.七三丅丛业东万丒东(下丅丙一丂丗丅丝七:  val_86, 丝丄专丄丆世丟丏丆:  (val_91 != 0) ? 1 : 0, 丛丄一丂丈丆七丆丝:  (val_92 != 0) ? 1 : 0);
        label_136:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nameLabels, 丕丗丘丑丛与丑业丒:  this.不丐且丐丐不丛丞丑.Name);
        string val_49 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  this.Offer.丑且一丐东三不丈丝());
        this.世世丈丒丒下一丐丅();
        if((this.下丁三一业万丐丘东.Type != 1070) || (this._enoughtForCraft == 0))
        {
            goto label_105;
        }
        
        if(mem[this.下丁三一业万丐丘东].Count >= mem[this.下丁三一业万丐丘东].PartsLeft)
        {
                if(this.Offer.世一丒专丛丏世丁丙() == false)
        {
            goto label_110;
        }
        
        }
        
        val_93 = 0;
        goto label_111;
        label_110:
        val_93 = (~this._timeEndObject.activeSelf) & 1;
        label_111:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughtForCraft, 丏业丟一东丂东丘丛:  val_93);
        label_105:
        if(this._priceView != 0)
        {
                this._priceView.<丅丝丌丝丁丏丙东丞>k__BackingField = this.Offer;
            this._priceView.丝一丅丆三东丂丞七();
        }
        
        val_67 = this._isBoughtObject;
        bool val_67 = this.Offer.世一丒专丛丏世丁丙();
        if(val_67 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_67, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeEndObject, 丏业丟一东丂东丘丛:  false);
            val_94 = this._timeLeftObject;
        }
        else
        {
                val_94 = val_67;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_94, 丏业丟一东丂东丘丛:  false);
        val_95 = this._disableIfBought;
        if(val_95 == null)
        {
            goto label_126;
        }
        
        val_81 = 1152921519068977584;
        val_67 = 0;
        val_67 = val_67 ^ 1;
        goto label_127;
        label_134:
        UnityEngine.GameObject val_62 = this._disableIfBought.Item[0];
        if(val_62 != 0)
        {
                val_62.SetActive(value:  val_67);
        }
        
        val_95 = this._disableIfBought;
        val_67 = 1;
        label_127:
        int val_64 = val_95.Count;
        if(val_67 < val_64)
        {
            goto label_134;
        }
        
        label_126:
        val_64.七丂丁丒丒丟丁一丒(专丂丕丗丗东世丞下:  this._backgroundHolder, 业万丝不丝下丏且不:  val_49, 丁丅丈丌丟世丗丗丟:  "BG");
        val_64.七丂丁丒丒丟丁一丒(专丂丕丗丗东世丞下:  this._decorationHolder, 业万丝不丝下丏且不:  val_49, 丁丅丈丌丟世丗丗丟:  "DC");
        return;
        label_93:
        if(this.业上丑且三丕三丁下.Type != 1310)
        {
            goto label_136;
        }
        
        var val_66 = (this.丛下不丌七东丂丐上 != 0) ? 1 : 0;
        goto label_137;
        label_36:
        this.下丁三一业万丐丘东 = val_17;
        if(val_17 == null)
        {
                return;
        }
        
        goto label_139;
    }
    private void 七三丅丛业东万丒东(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, bool 丝丄专丄丆世丟丏丆, bool 丛丄一丂丈丆七丆丝)
    {
        ItemRarity val_40;
        UILabel val_41;
        UnityEngine.GameObject val_42;
        丕丑丙丑丙东丌丘丕 val_43;
        var val_44;
        丕丑丙丑丙东丌丘丕 val_45;
        string val_46;
        UILabel val_47;
        val_40 = 丛丄一丂丈丆七丆丝;
        val_41 = this;
        val_42 = this._upgradeContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_42, 丏业丟一东丂东丘丛:  true);
        if(下丅丙一丂丗丅丝七.Type != 1340)
        {
            goto label_4;
        }
        
        System.Nullable<ItemRarity> val_2 = this.不丐且丐丐不丛丞丑.Rarity;
        val_40 = UnityEngine.Mathf.Min(a:  5, b:  下丅丙一丂丗丅丝七.Count +);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._descriptionLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_40 != true) ? "Key_8649" : ((丝丄专丄丆世丟丏丆 != true) ? "Key_8648" : "Key_8650")), arg0:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_40)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_40)) + "[-]"("[-]")));
        val_43 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.不丐且丐丐不丛丞丑.Id);
        if(val_43 == null)
        {
            goto label_19;
        }
        
        if(丝丄专丄丆世丟丏丆 == false)
        {
            goto label_20;
        }
        
        label_48:
        val_44 = 0;
        int val_15 = ExperienceController.丞丞丘业东丙丏七丌();
        goto label_23;
        label_4:
        if(下丅丙一丂丗丅丝七.Type != 1310)
        {
                return;
        }
        
        val_45 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.不丐且丐丐不丛丞丑.Id);
        if(val_45 == null)
        {
                System.Nullable<ItemRarity> val_21 = this.不丐且丐丐不丛丞丑.Rarity;
            丕丑丙丑丙东丌丘丕 val_22 = null;
            val_45 = val_22;
            val_22 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  this.不丐且丐丐不丛丞丑.Record, 丏丆丐丑专与丄丘丞:  val_21.HasValue);
        }
        
        System.Nullable<ItemRarity> val_24 = this.不丐且丐丐不丛丞丑.Rarity;
        val_42;
        val_40 = System.String.Format(format:  "+{0}", arg0:  (BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  val_24.HasValue))) - (BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  val_22)));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._upgradeLabel, 丕丗丘丑丛与丑业丒:  val_40);
        val_41 = this._descriptionLabel;
        val_46 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10051");
        val_47 = val_41;
        goto label_43;
        label_19:
        丕丑丙丑丙东丌丘丕 val_33 = null;
        val_43 = val_33;
        val_33 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  this.不丐且丐丐不丛丞丑.Record, 丏丆丐丑专与丄丘丞:  this.不丐且丐丐不丛丞丑.Record);
        if(丝丄专丄丆世丟丏丆 == true)
        {
            goto label_48;
        }
        
        label_20:
        val_44 = val_43;
        label_23:
        val_42 = val_33.丈一下下丞世三丑丄();
        val_41 = this._upgradeLabel;
        val_47 = val_41;
        val_46 = System.String.Format(format:  "+{0}", arg0:  (BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_42, 丏丆丐丑专与丄丘丞:  val_40))) - (BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  val_33)));
        label_43:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_47, 丕丗丘丑丛与丑业丒:  val_46);
    }
    private void 七丂丁丒丒丟丁一丒(UnityEngine.Transform 专丂丕丗丗东世丞下, string 业万丝不丝下丏且不, string 丁丅丈丌丟世丗丗丟)
    {
        string val_16;
        var val_17;
        val_16 = 业万丝不丝下丏且不;
        if(专丂丕丗丗东世丞下.childCount >= 1)
        {
                UnityEngine.Transform val_2 = 专丂丕丗丗东世丞下.GetChild(index:  0);
            val_17 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_2.gameObject);
            if((val_17.Contains(value:  "SkinOffer_" + val_16 + "_" + 丁丅丈丌丟世丗丗丟)) != true)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_2.gameObject);
        }
        
        }
        
        if(专丂丕丗丗东世丞下.childCount != 0)
        {
                return;
        }
        
        val_17 = 1152921524279436720;
        val_16 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Bank/SkinOfferContent/SkinOffer_"("NguiWindows/Bank/SkinOfferContent/SkinOffer_") + val_16 + "_" + 丁丅丈丌丟世丗丗丟);
        if(val_16 == 0)
        {
                val_16 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Bank/SkinOfferContent/SkinOffer_basic_"("NguiWindows/Bank/SkinOfferContent/SkinOffer_basic_") + 丁丅丈丌丟世丗丗丟);
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_15 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_16, 丈东丘丏与丌东东下:  专丂丕丗丗东世丞下, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new EventStoreSkinBankViewItem.一丐丑万业丑丄下丂();
    }
    private void 世世丈丒丒下一丐丅()
    {
        var val_18;
        UILabel val_19;
        var val_20;
        var val_21;
        var val_22;
        if(this.Offer == null)
        {
                return;
        }
        
        val_18 = 0;
        if(this.Offer.世一丒专丛丏世丁丙() == true)
        {
                return;
        }
        
        if(this.丛丗丑世业业丐丙丘 != 0)
        {
                if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
            goto label_7;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeEndObject, 丏业丟一东丂东丘丛:  false);
        val_18 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  false);
        label_7:
        System.Nullable<System.TimeSpan> val_5 = this.丙世丑丅丒丑业与不();
        val_19 = 1152921516341017568;
        if(( & 1) == 0)
        {
            goto label_10;
        }
        
        if(TotalSeconds > 0f)
        {
            goto label_13;
        }
        
        label_10:
        if(this.Offer.丑且一丐东三不丈丝() != 60)
        {
                if(this.Offer.丑且一丐东三不丈丝() != 80)
        {
            goto label_15;
        }
        
        }
        
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeEndObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  true);
        if(( & 1) != 0)
        {
                val_19 = this._timeLeftLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_19, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        
        if(this.丈丛丘丈与世三丏丒 == true)
        {
                return;
        }
        
        val_19 = this._disableIfBought;
        this.丈丛丘丈与世三丏丒 = true;
        if(val_19 == null)
        {
                return;
        }
        
        val_20 = 1152921519068977584;
        val_21 = 0;
        goto label_25;
        label_33:
        UnityEngine.GameObject val_12 = this._disableIfBought.Item[0];
        if(val_12 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  true);
        }
        
        val_19 = this._disableIfBought;
        val_21 = 1;
        label_25:
        if(val_21 < val_19.Count)
        {
            goto label_33;
        }
        
        return;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeEndObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  false);
        if(this.丈丛丘丈与世三丏丒 == false)
        {
                return;
        }
        
        val_19 = this._disableIfBought;
        this.丈丛丘丈与世三丏丒 = false;
        if(val_19 == null)
        {
                return;
        }
        
        val_20 = 1152921519068977584;
        val_22 = 0;
        goto label_39;
        label_47:
        UnityEngine.GameObject val_15 = this._disableIfBought.Item[0];
        if(val_15 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  false);
        }
        
        val_19 = this._disableIfBought;
        val_22 = 1;
        label_39:
        if(val_22 < val_19.Count)
        {
            goto label_47;
        }
    
    }
    protected override void Update()
    {
        this.Update();
        if(this.Offer == null)
        {
                return;
        }
        
        if(this.丛丗丑世业业丐丙丘 == 0)
        {
            goto label_2;
        }
        
        label_6:
        float val_2 = UnityEngine.Time.unscaledDeltaTime;
        val_2 = this.丆上三与万丈丙一丁 + val_2;
        this.丆上三与万丈丙一丁 = val_2;
        return;
        label_2:
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_6;
        }
        
        this.丛丗丑世业业丐丙丘 = FriendsController.丝丗专上三不丄丑丑();
    }
    private static 丛且专丞丗丆丙丒万 丆丝业丟丌丄丌丕丐(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
    {
        var val_5;
        var val_18;
        var val_19;
        System.Collections.Generic.IEnumerable<TSource> val_20;
        val_18 = 下丅丙一丂丗丅丝七;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values.GetEnumerator();
        label_21:
        if(((-953253376) & 1) == 0)
        {
            goto label_5;
        }
        
        val_19 = val_5.丐丏七丌丕丗业且上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X21)) == true)
        {
            goto label_9;
        }
        
        bool val_9 = System.String.op_Equality(a:  X21, b:  val_18.Id);
        if(val_9 == true)
        {
            goto label_22;
        }
        
        label_9:
        if(val_9 == false)
        {
            goto label_12;
        }
        
        val_20 = val_9.Values;
        if((System.Linq.Enumerable.Contains<System.String>(source:  val_20, value:  val_18.Id)) == true)
        {
            goto label_22;
        }
        
        label_12:
        val_20 = mem[丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished + 64];
        val_20 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished + 64;
        if((System.String.op_Equality(a:  val_20, b:  val_18.Id)) == true)
        {
            goto label_22;
        }
        
        val_20 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished + 64 + 72.Values;
        if((System.Linq.Enumerable.Contains<System.String>(source:  val_20, value:  val_18.Id)) == false)
        {
            goto label_21;
        }
        
        goto label_22;
        label_5:
        val_19 = 0;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        return (丛且专丞丗丆丙丒万)val_19;
    }
    public EventStoreSkinBankViewItem()
    {
        this.丈丛丘丈与世三丏丒 = true;
    }
    private static EventStoreSkinBankViewItem()
    {
        EventStoreSkinBankViewItem.与丈丂一丌三丈丟丅 = new Rilisoft.OfferItemType[4];
    }

}
