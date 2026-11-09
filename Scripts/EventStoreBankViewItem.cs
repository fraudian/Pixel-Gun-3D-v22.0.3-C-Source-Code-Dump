using UnityEngine;
internal class EventStoreBankViewItem : AbstractBankViewItem
{
    // Fields
    private long 丛丗丑世业业丐丙丘;
    private float 丆上三与万丈丙一丁;
    private long 三丌世世下丐丈一丅;
    private bool 丈丛丘丈与世三丏丒;
    private Rilisoft.OfferItem 丏丂丞世业且不上丏;
    private System.Collections.Generic.List<UILabel> _nameLabels;
    private UnityEngine.Transform _specificElementsContainer;
    private EventStoreBankViewActionSpecificElement _defaultSpecificElement;
    private EventStoreBankPriceView _priceView;
    private UnityEngine.GameObject _isBoughtObject;
    private UnityEngine.GameObject _timeEndObject;
    private UnityEngine.GameObject _timeLeftObject;
    private UILabel _timeLeftLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> _disableIfBought;
    private UnityEngine.GameObject _enoughtForCraft;
    private BankMultyOfferView _multyOfferView;
    private UnityEngine.GameObject _buttonBuy;
    private UnityEngine.GameObject _buttonView;
    private UnityEngine.GameObject _upgradesContainer;
    private System.Collections.Generic.List<UIWidget> _upgrades;
    private UnityEngine.Color _baseColor;
    private UnityEngine.Color _upgradeColor;
    private UITable _upgradesTable;
    
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
        System.Collections.Generic.ICollection<Rilisoft.OfferItem> val_18;
        UIBasicSprite val_19;
        UnityEngine.Texture val_20;
        val_18 = this;
        if(this.Offer == null)
        {
                return;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_2 = this.Offer;
        System.Nullable<AdaptiveModuleType> val_3 = val_2.下丐丝万丞丙丁丂丑();
        if(((-960091064) & 1) != 0)
        {
                Rilisoft.业丙丘丆东丈丕丂丄 val_4 = this.Offer;
            System.Nullable<AdaptiveModuleType> val_5 = val_4.下丐丝万丞丙丁丂丑();
            if((-960091064) == 70)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._multyOfferView, 丏业丟一东丂东丘丛:  true);
            val_18 = this.Offer.丏与丅专三丙与丘丒();
            this._multyOfferView.Setup(与且专丈不万东一万:  val_18);
            return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._multyOfferView, 丏业丟一东丂东丘丛:  false);
        System.Nullable<AdaptiveModuleType> val_9 = this.Offer.下丐丝万丞丙丁丂丑();
        if(((-960091064) & 1) == 0)
        {
            goto label_16;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_10 = this.Offer;
        System.Nullable<AdaptiveModuleType> val_11 = val_10.下丐丝万丞丙丁丂丑();
        if((-960091064) != 90)
        {
            goto label_16;
        }
        
        val_18 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/adaptive-gadgets");
        val_19 = val_10;
        val_20 = val_18;
        goto label_19;
        label_16:
        if(this.丏丂丞世业且不上丏 == null)
        {
            goto label_20;
        }
        
        label_26:
        val_19 = val_18;
        val_20 = this.丏丂丞世业且不上丏.Texture;
        label_19:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this, 与万丆丛丒万丝丙丑:  val_20);
        return;
        label_20:
        System.Collections.Generic.List<Rilisoft.OfferItem> val_15 = this.Offer.丏与丅专三丙与丘丒();
        if(val_15 == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_15)) == false)
        {
                return;
        }
        
        if((System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_15)) != null)
        {
            goto label_26;
        }
    
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_48;
        bool val_127;
        UnityEngine.GameObject val_128;
        var val_129;
        bool val_130;
        UnityEngine.GameObject val_131;
        int val_132;
        string val_133;
        var val_134;
        string val_136;
        UnityEngine.Transform val_137;
        var val_138;
        var val_139;
        string val_140;
        var val_141;
        var val_142;
        System.Action<UILabel> val_144;
        var val_145;
        System.Action<UILabel> val_148;
        System.Collections.Generic.List<UILabel> val_149;
        var val_150;
        System.Action<UILabel> val_152;
        var val_153;
        bool val_155;
        var val_156;
        var val_157;
        bool val_158;
        UnityEngine.GameObject val_159;
        System.Collections.Generic.List<UnityEngine.GameObject> val_160;
        var val_161;
        var val_162;
        if(this.Offer == null)
        {
                return;
        }
        
        if(this.丛丗丑世业业丐丙丘 == 0)
        {
                if(FriendsController.丝丗专上三不丄丑丑() >= 1)
        {
                this.丛丗丑世业业丐丙丘 = FriendsController.丝丗专上三不丄丑丑();
        }
        
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_5 = this.Offer.丏与丅专三丙与丘丒();
        if(val_5 == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_5)) == false)
        {
                return;
        }
        
        Rilisoft.OfferItem val_7 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_5);
        this.丏丂丞世业且不上丏 = val_7;
        if(val_7 == null)
        {
                return;
        }
        
        if(this.Offer.丑且一丐东三不丈丝() != 40)
        {
            goto label_13;
        }
        
        if((Rilisoft.丗与丆一世且丏丈且.三丟丏业丂业丛丞七(丙业丞丑七丗下丟丌:  this.Offer)) == false)
        {
            goto label_14;
        }
        
        val_127 = 0;
        goto label_15;
        label_13:
        System.Nullable<AdaptiveModuleType> val_13 = this.Offer.下丐丝万丞丙丁丂丑();
        if(((-959362184) & 1) == 0)
        {
            goto label_19;
        }
        
        System.Nullable<AdaptiveModuleType> val_15 = this.Offer.下丐丝万丞丙丁丂丑();
        if((-959362184) != 90)
        {
            goto label_19;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonBuy, 丏业丟一东丂东丘丛:  false);
        val_128 = this._buttonView;
        val_129 = 1;
        goto label_22;
        label_19:
        val_130 = 1;
        val_131 = this._buttonBuy;
        goto label_25;
        label_14:
        val_127 = (~this.Offer.世一丒专丛丏世丁丙()) & 1;
        label_15:
        val_131 = this._buttonBuy;
        val_130 = val_127;
        label_25:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_131, 丏业丟一东丂东丘丛:  val_130);
        val_128 = this._buttonView;
        val_129 = 0;
        label_22:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_128, 丏业丟一东丂东丘丛:  false);
        val_132 = System.String.alignConst;
        if((this.Offer == null) || (this.Offer.丑且一丐东三不丈丝() != 60))
        {
            goto label_40;
        }
        
        System.Nullable<AdaptiveModuleType> val_22 = this.Offer.下丐丝万丞丙丁丂丑();
        if(((-959362184) & 1) == 0)
        {
            goto label_40;
        }
        
        System.Nullable<AdaptiveModuleType> val_24 = this.Offer.下丐丝万丞丙丁丂丑();
        if((-959362184) != 70)
        {
            goto label_35;
        }
        
        val_133 = "Key_5575";
        goto label_38;
        label_35:
        System.Nullable<AdaptiveModuleType> val_26 = this.Offer.下丐丝万丞丙丁丂丑();
        if((-959362184) != 90)
        {
            goto label_40;
        }
        
        val_133 = "Key_5586";
        label_38:
        val_132 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_133);
        label_40:
        val_134 = 1152921505284374528;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_132)) != false)
        {
                val_132 = this.丏丂丞世业且不上丏.Name;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nameLabels, 丕丗丘丑丛与丑业丒:  val_132);
        this.世世丈丒丒下一丐丅();
        System.Nullable<AdaptiveModuleType> val_31 = this.Offer.下丐丝万丞丙丁丂丑();
        if(((-959362184) & 1) == 0)
        {
            goto label_52;
        }
        
        System.Nullable<AdaptiveModuleType> val_33 = this.Offer.下丐丝万丞丙丁丂丑();
        if((-959362184) != 70)
        {
            goto label_52;
        }
        
        T[] val_34 = System.Array.Empty<System.Object>();
        val_136 = "adaptive_currency";
        goto label_53;
        label_52:
        System.Nullable<AdaptiveModuleType> val_36 = this.Offer.下丐丝万丞丙丁丂丑();
        if(((-959362184) & 1) == 0)
        {
            goto label_57;
        }
        
        System.Nullable<AdaptiveModuleType> val_38 = this.Offer.下丐丝万丞丙丁丂丑();
        if((-959362184) != 90)
        {
            goto label_57;
        }
        
        val_136 = "adaptive_gadgets";
        label_53:
        string val_40 = System.String.Format(format:  val_136, args:  System.Array.Empty<System.Object>());
        goto label_102;
        label_57:
        if(this.丏丂丞世业且不上丏.Type != 1070)
        {
            goto label_90;
        }
        
        if(this.Offer.丑且一丐东三不丈丝() != 70)
        {
            goto label_62;
        }
        
        goto label_102;
        label_62:
        Dictionary.Enumerator<TKey, TValue> val_45 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().GetEnumerator();
        val_137 = 1152921524478589440;
        label_76:
        if(((-959362224) & 1) == 0)
        {
            goto label_67;
        }
        
        ConfiguredValueTaskAwaiter val_49 = val_48.GetAwaiter();
        if((System.String.op_Equality(a:  val_49._value._obj.丐丏七丌丕丗业且上(), b:  this.丏丂丞世业且不上丏.Id)) == true)
        {
            goto label_77;
        }
        
        if((System.String.op_Equality(a:  ???, b:  this.丏丂丞世业且不上丏.Id)) == true)
        {
            goto label_77;
        }
        
        if((System.Linq.Enumerable.Contains<System.String>(source:  ???.Values, value:  this.丏丂丞世业且不上丏.Id)) == false)
        {
            goto label_76;
        }
        
        goto label_77;
        label_67:
        label_77:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_134 = 1152921505284374528;
        goto label_102;
        label_90:
        if(this.Offer.丑且一丐东三不丈丝() == 40)
        {
                if(this.丏丂丞世业且不上丏.Type != 10)
        {
                if(this.丏丂丞世业且不上丏.Type != 1080)
        {
            goto label_96;
        }
        
        }
        
            string val_64 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  40).ToLower();
        }
        else
        {
                label_96:
            string val_67 = (this.Offer.丑且一丐东三不丈丝() == 70) ? "try_gun" : 0;
        }
        
        label_102:
        val_138 = 0;
        if(this._specificElementsContainer == 0)
        {
            goto label_106;
        }
        
        val_139 = 0;
        val_138 = 0;
        goto label_107;
        label_122:
        EventStoreBankViewActionSpecificElement val_70 = this._specificElementsContainer.GetChild(index:  0).GetComponent<EventStoreBankViewActionSpecificElement>();
        if(val_70 == 0)
        {
            goto label_112;
        }
        
        if(val_70 == null)
        {
            goto label_113;
        }
        
        if(val_67 == 0)
        {
            goto label_114;
        }
        
        label_116:
        val_140 = val_70.CustomType;
        bool val_72 = System.String.op_Equality(a:  val_140, b:  val_67);
        goto label_115;
        label_113:
        if(val_67 != 0)
        {
            goto label_116;
        }
        
        label_114:
        val_140 = val_70.ForTypes;
        Rilisoft.OfferItemType val_126 = this.丏丂丞世业且不上丏.Type;
        bool val_74 = val_140.Contains(item:  val_126);
        val_134 = 1152921505284374528;
        label_115:
        val_126 = val_74;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_70, 丏业丟一东丂东丘丛:  val_126);
        UnityEngine.Object val_75 = (val_74 != true) ? (val_70) : (val_138);
        label_112:
        val_139 = 1;
        label_107:
        val_137 = this._specificElementsContainer;
        if(val_139 < val_137.childCount)
        {
            goto label_122;
        }
        
        label_106:
        if((val_75 != 0) && ((val_74 != true ? val_70 : val_138 + 64) != 0))
        {
                if((EventStoreBankViewItem.丆丝业丟丌丄丌丕丐(下丅丙一丂丗丅丝七:  this.丏丂丞世业且不上丏)) != null)
        {
                val_74 != true ? val_70 : val_138 + 64.spriteName = 丙丞丟丑丗丅专丈一.丝世丝丌丝丝万丌七(丐世下不一丁丟丅专:  val_79.下丄丈不与世丐业专);
        }
        
        }
        
        UnityEngine.Object val_127 = 0;
        val_127 = UnityEngine.Object.op_Equality(x:  val_75, y:  val_127);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._defaultSpecificElement, 丏业丟一东丂东丘丛:  val_127);
        if(val_75 == 0)
        {
            goto label_141;
        }
        
        val_141 = val_75;
        if(((val_74 != true ? val_70 : val_138 + 40) == 0) || ((val_74 != true ? val_70 : val_138 + 40.Count) < 1))
        {
            goto label_141;
        }
        
        val_142 = null;
        val_142 = null;
        val_144 = EventStoreBankViewItem.<>c.<>9__11_0;
        if(val_144 == null)
        {
                System.Action<UILabel> val_84 = null;
            val_144 = val_84;
            val_84 = new System.Action<UILabel>(object:  EventStoreBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EventStoreBankViewItem.<>c::万丄专且一丈丌上丌(UILabel 丐三丞七丝丅不万丛));
            EventStoreBankViewItem.<>c.<>9__11_0 = val_144;
        }
        
        val_74 != true ? val_70 : val_138 + 40.ForEach(action:  val_84);
        val_145 = null;
        val_145 = null;
        val_148 = EventStoreBankViewItem.<>c.<>9__11_1;
        if(val_148 == null)
        {
                System.Action<UILabel> val_85 = null;
            val_148 = val_85;
            val_85 = new System.Action<UILabel>(object:  EventStoreBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EventStoreBankViewItem.<>c::世三丈三下业丁业东(UILabel 丐三丞七丝丅不万丛));
            EventStoreBankViewItem.<>c.<>9__11_1 = val_148;
        }
        
        val_149 = public System.Void System.Collections.Generic.List<UILabel>::ForEach(System.Action<T> action);
        goto label_154;
        label_141:
        if(val_75 != 0)
        {
                val_150 = null;
            val_150 = null;
            val_152 = EventStoreBankViewItem.<>c.<>9__11_2;
            if(val_152 == null)
        {
                System.Action<UILabel> val_87 = null;
            val_152 = val_87;
            val_87 = new System.Action<UILabel>(object:  EventStoreBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EventStoreBankViewItem.<>c::三丒且丈一三业专丝(UILabel 丐三丞七丝丅不万丛));
            EventStoreBankViewItem.<>c.<>9__11_2 = val_152;
        }
        
            val_74 != true ? val_70 : val_138 + 40.ForEach(action:  val_87);
        }
        
        val_141 = this;
        val_153 = null;
        val_153 = null;
        val_148 = EventStoreBankViewItem.<>c.<>9__11_3;
        if(val_148 == null)
        {
                System.Action<UILabel> val_88 = null;
            val_148 = val_88;
            val_88 = new System.Action<UILabel>(object:  EventStoreBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EventStoreBankViewItem.<>c::东且专丝丗丁世专丒(UILabel 丐三丞七丝丅不万丛));
            EventStoreBankViewItem.<>c.<>9__11_3 = val_148;
        }
        
        val_149 = public System.Void System.Collections.Generic.List<UILabel>::ForEach(System.Action<T> action);
        label_154:
        val_74 != true ? val_70 : val_138 + 40.ForEach(action:  val_88);
        if((public System.Void System.Collections.Generic.List<一丒丒丘丈万丟丞不>::ForEach(System.Action<T> action)) != 0)
        {
                this.丗丟七专丗世下不世(下丅丙一丂丗丅丝七:  this.丏丂丞世业且不上丏, 丁丐世不七丅且东丒:  val_149);
        }
        
        if(this.丏丂丞世业且不上丏.Type != 1070)
        {
            goto label_205;
        }
        
        if(val_75 == 0)
        {
            goto label_202;
        }
        
        if((val_74 != true ? val_70 : val_138 + 48) != 0)
        {
                val_74 != true ? val_70 : val_138 + 48.text = System.String.Format(format:  "x{0}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丏丂丞世业且不上丏.Count));
        }
        
        if((val_74 != true ? val_70 : val_138 + 56) == 0)
        {
            goto label_202;
        }
        
        System.Nullable<ItemRarity> val_95 = this.丏丂丞世业且不上丏.Rarity;
        if(((-959362248) & 1) == 0)
        {
            goto label_202;
        }
        
        System.Nullable<ItemRarity> val_96 = this.丏丂丞世业且不上丏.Rarity;
        UnityEngine.Color val_97 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_96.HasValue);
        List.Enumerator<T> val_98 = val_74 != true ? val_70 : val_138 + 56.GetEnumerator();
        label_197:
        if(((-959362272) & 1) == 0)
        {
            goto label_192;
        }
        
        string val_99 = val_48.丐丏七丌丕丗业且上();
        if(val_99 == 0)
        {
            goto label_197;
        }
        
        val_99.color = new UnityEngine.Color() {r = val_97.r, g = val_97.g, b = val_97.b, a = val_97.a};
        goto label_197;
        label_192:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_202:
        if(this._enoughtForCraft == 0)
        {
            goto label_205;
        }
        
        if(this.丏丂丞世业且不上丏.Count >= this.丏丂丞世业且不上丏.PartsLeft)
        {
                if(this.Offer.世一丒专丛丏世丁丙() == false)
        {
            goto label_210;
        }
        
        }
        
        val_155 = 0;
        goto label_211;
        label_210:
        val_155 = (~this._timeEndObject.activeSelf) & 1;
        label_211:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._enoughtForCraft, 丏业丟一东丂东丘丛:  val_155);
        label_205:
        if(this._priceView != 0)
        {
                this._priceView.<丅丝丌丝丁丏丙东丞>k__BackingField = this.Offer;
            this._priceView.丝一丅丆三东丂丞七();
        }
        
        if((this.丏丂丞世业且不上丏.Type != 10) || (this.丏丂丞世业且不上丏.Record == null))
        {
            goto label_232;
        }
        
        val_156 = null;
        val_156 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_227;
        }
        
        val_157 = null;
        val_157 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  this.丏丂丞世业且不上丏.Id)) == true)
        {
            goto label_232;
        }
        
        label_227:
        if(this.丏丂丞世业且不上丏.Record.东七与与不丅丙上上() == false)
        {
            goto label_235;
        }
        
        label_232:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._upgradesContainer, 丏业丟一东丂东丘丛:  false);
        label_268:
        val_158 = this.Offer.世一丒专丛丏世丁丙();
        if(val_158 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._isBoughtObject, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeEndObject, 丏业丟一东丂东丘丛:  false);
            val_159 = this._timeLeftObject;
        }
        else
        {
                val_159 = this._isBoughtObject;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_159, 丏业丟一东丂东丘丛:  false);
        val_160 = this._disableIfBought;
        if(val_160 == null)
        {
                return;
        }
        
        val_137 = 1152921519068977584;
        val_161 = 0;
        val_158 = val_158 ^ 1;
        goto label_246;
        label_253:
        UnityEngine.GameObject val_119 = this._disableIfBought.Item[0];
        if(val_119 != 0)
        {
                val_119.SetActive(value:  val_158);
        }
        
        val_160 = this._disableIfBought;
        val_161 = 1;
        label_246:
        if(val_161 < val_160.Count)
        {
            goto label_253;
        }
        
        return;
        label_235:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._upgradesContainer, 丏业丟一东丂东丘丛:  true);
        val_162 = 0;
        goto label_256;
        label_262:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._upgrades.Item[0].gameObject, 丏业丟一东丂东丘丛:  false);
        val_162 = 1;
        label_256:
        if(val_162 < this._upgrades.Count)
        {
            goto label_262;
        }
        
        if(this._upgradesTable == 0)
        {
            goto label_268;
        }
        
        this._upgradesTable.repositionNow = true;
        if(this._upgradesTable != null)
        {
            goto label_268;
        }
        
        goto label_268;
    }
    private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new EventStoreBankViewItem.一上丛万丆丙丛万丁();
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
    private void 丗丟七专丗世下不世(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Collections.Generic.List<UILabel> 丁丐世不七丅且东丒)
    {
        var val_8;
        var val_9;
        if(this.Offer != null)
        {
                OfferModule val_3 = this.Offer.丑且一丐东三不丈丝();
            System.Nullable<AdaptiveModuleType> val_5 = this.Offer.下丐丝万丞丙丁丂丑();
            val_8 = 0;
            val_9 = val_5.HasValue;
        }
        else
        {
                val_8 = 0;
            val_9 = 0;
        }
        
        string val_6 = Rilisoft.Offers.丁且丕专万丈丒丏丗.丁一丙丐丑与丒丘丌(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false});
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丁丐世不七丅且东丒, 丕丗丘丑丛与丑业丒:  val_6);
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
        if(((-957958384) & 1) == 0)
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
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (丛且专丞丗丆丙丒万)val_19;
    }
    public EventStoreBankViewItem()
    {
        this.丈丛丘丈与世三丏丒 = true;
    }

}
