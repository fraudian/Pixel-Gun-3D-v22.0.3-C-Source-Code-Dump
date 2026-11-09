using UnityEngine;
internal class EventStoreBankPriceView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.业丙丘丆东丈丕丂丄>
{
    // Fields
    private Rilisoft.业丙丘丆东丈丕丂丄 <丅丝丌丝丁丏丙东丞>k__BackingField;
    private System.Collections.Generic.List<UILabel> _priceLabels;
    private System.Collections.Generic.List<UILabel> _oldPriceLabels;
    private System.Collections.Generic.List<UITable> _tables;
    private UnityEngine.GameObject _profitObject;
    private UILabel _profitLabel;
    private UnityEngine.GameObject _realPriceObject;
    private UnityEngine.GameObject _saleRealPrice;
    private UnityEngine.GameObject _withoutSaleRealPrice;
    private UnityEngine.GameObject _gemsPriceContainer;
    private UnityEngine.GameObject _gemsPriceObject;
    private UnityEngine.GameObject _gemsProfitObject;
    private UnityEngine.GameObject _coinsPriceContainer;
    private UnityEngine.GameObject _coinsPriceObject;
    private UnityEngine.GameObject _coinsProfitObject;
    private UnityEngine.GameObject _freeProgressBarGO;
    private UISprite _freeProgressBarSprite;
    private UILabel _freeProgressBarLabel;
    
    // Properties
    public Rilisoft.业丙丘丆东丈丕丂丄 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    public Rilisoft.业丙丘丆东丈丕丂丄 get_Context()
    {
        return (Rilisoft.业丙丘丆东丈丕丂丄)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(Rilisoft.业丙丘丆东丈丕丂丄 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业丞丑七丗下丟丌;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        System.Collections.Generic.List<UITable> val_103;
        UnityEngine.GameObject val_104;
        var val_105;
        var val_106;
        var val_107;
        UnityEngine.GameObject val_108;
        var val_109;
        System.Collections.Generic.List<UILabel> val_111;
        var val_112;
        var val_114;
        string val_116;
        UILabel val_117;
        var val_118;
        var val_119;
        var val_120;
        string val_121;
        int val_122;
        int val_123;
        val_103 = this;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        decimal val_1 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丐丁丒世丟世丘丌丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._realPriceObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsPriceContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsPriceContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeProgressBarGO, 丏业丟一东丂东丘丛:  Rilisoft.丗与丆一世且丏丈且.三丟丏业丂业丛丞七(丙业丞丑七丗下丟丌:  this.<丅丝丌丝丁丏丙东丞>k__BackingField));
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  "Real")) == false)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._realPriceObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleRealPrice, 丏业丟一东丂东丘丛:  false);
        val_104 = this._withoutSaleRealPrice;
        val_105 = 1;
        goto label_9;
        label_6:
        val_106 = null;
        val_106 = null;
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_14;
        }
        
        val_107 = null;
        val_108 = this._gemsPriceContainer;
        goto label_23;
        label_14:
        val_109 = null;
        val_109 = null;
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_21;
        }
        
        val_107 = null;
        val_108 = this._coinsPriceContainer;
        label_23:
        val_105 = 1;
        val_104 = val_108;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_104, 丏业丟一东丂东丘丛:  true);
        label_21:
        bool val_15 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  "Real");
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
            goto label_26;
        }
        
        if(val_15 == false)
        {
            goto label_27;
        }
        
        label_29:
        string val_16 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈世下下丅丕丐丗丁();
        goto label_28;
        label_26:
        if(val_15 == true)
        {
            goto label_29;
        }
        
        label_27:
        label_28:
        val_111 = this._priceLabels;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_111, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世()));
        if((Rilisoft.丗与丆一世且丏丈且.三丟丏业丂业丛丞七(丙业丞丑七丗下丟丌:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)) == false)
        {
            goto label_35;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsProfitObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsProfitObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._profitLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9259"));
        System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> val_24 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.上一丈丏三丒三丙不>(丗与丟上上丑专世丗:  40).丙丈丈东丟丟丒丄三();
        val_112 = null;
        val_112 = null;
        if((EventStoreBankPriceView.<>c.<>9__5_0) == null)
        {
            goto label_46;
        }
        
        label_131:
        System.Collections.Generic.List<T> val_25 = val_24.FindAll(match:  EventStoreBankPriceView.<>c.<>9__5_0);
        val_114 = null;
        val_114 = null;
        if((EventStoreBankPriceView.<>c.<>9__5_1) == null)
        {
            goto label_50;
        }
        
        label_135:
        int val_27 = val_25.FindAll(match:  EventStoreBankPriceView.<>c.<>9__5_1).Count;
        float val_103 = (float)val_27;
        val_103 = val_103 / (float)val_25.Count;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._freeProgressBarSprite, 丙业与丙丗丝不丈东:  val_103);
        val_111 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9261");
        val_116 = System.String.Format(format:  val_111, arg0:  val_27, arg1:  val_25.Count);
        val_117 = this._freeProgressBarLabel;
        goto label_59;
        label_35:
        val_118 = null;
        val_118 = null;
        if(((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == true) || ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.一业丟丁上丑丘丕丄()) == false))
        {
            goto label_64;
        }
        
        if(this._gemsPriceObject != 0)
        {
                UnityEngine.Vector3 val_37 = this._gemsPriceObject.transform.localPosition;
            UnityEngine.Vector3 val_39 = this._gemsPriceObject.transform.localPosition;
            this._gemsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_119 = null;
            val_119 = null;
            string val_104 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            val_104 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  val_104);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsProfitObject, 丏业丟一东丂东丘丛:  val_104);
        }
        
        if(this._coinsPriceObject != 0)
        {
                UnityEngine.Vector3 val_46 = this._coinsPriceObject.transform.localPosition;
            UnityEngine.Vector3 val_48 = this._coinsPriceObject.transform.localPosition;
            this._coinsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_120 = null;
            val_120 = null;
            string val_105 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            val_105 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  val_105);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsProfitObject, 丏业丟一东丂东丘丛:  val_105);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  true);
        if(((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丘丗七丈丆七丞不丌()) == null) || ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丘丗七丈丆七丞不丌().丟丂丞不专丆万丒世()) < 1))
        {
            goto label_101;
        }
        
        label_146:
        val_121 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丘丗七丈丆七丞不丌().丟丂丞不专丆万丒世());
        goto label_141;
        label_64:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsProfitObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsProfitObject, 丏业丟一东丂东丘丛:  false);
        if(this._gemsPriceObject != 0)
        {
                UnityEngine.Vector3 val_61 = this._gemsPriceObject.transform.localPosition;
            UnityEngine.Vector3 val_63 = this._gemsPriceObject.transform.localPosition;
            this._gemsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if(this._coinsPriceObject == 0)
        {
            goto label_127;
        }
        
        UnityEngine.Vector3 val_67 = this._coinsPriceObject.transform.localPosition;
        UnityEngine.Vector3 val_69 = this._coinsPriceObject.transform.localPosition;
        this._coinsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_127;
        label_46:
        EventStoreBankPriceView.<>c.<>9__5_0 = new System.Predicate<Rilisoft.业丙丘丆东丈丕丂丄>(object:  EventStoreBankPriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventStoreBankPriceView.<>c::一丐且丑世丝不丆丒(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
        if(val_24 != null)
        {
            goto label_131;
        }
        
        goto label_131;
        label_50:
        EventStoreBankPriceView.<>c.<>9__5_1 = new System.Predicate<Rilisoft.业丙丘丆东丈丕丂丄>(object:  EventStoreBankPriceView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventStoreBankPriceView.<>c::下丘丕专不丗三丙万(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
        if(val_25 != null)
        {
            goto label_135;
        }
        
        goto label_135;
        label_101:
        val_121 = 0;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丑且一丐东三不丈丝()) != 40)
        {
            goto label_141;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_73 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏与丅专三丙与丘丒();
        val_121 = 0;
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_73)) == false)
        {
            goto label_141;
        }
        
        Rilisoft.OfferItem val_75 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_73);
        System.Nullable<CategoryNames> val_76 = val_75.Category;
        val_121 = 0;
        if(((-962091240) & 1) == 0)
        {
            goto label_141;
        }
        
        System.Nullable<CategoryNames> val_77 = val_75.Category;
        丈丞丕丘丕丗与上一 val_79 = 上丑三丁丄丛丁万丑.丁且丛专丁业丕东业(不三丙万与丗丌七丈:  -962091240, 丞一丁业丄一一业且:  val_75.Id, 丂丆丗丈丏丘一丙世:  true);
        goto label_146;
        label_141:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_121)) != false)
        {
                decimal val_83 = System.Decimal.op_Implicit(value:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世());
            decimal val_84 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_83.flags, hi = val_83.hi, lo = val_83.lo, mid = val_83.mid}, d2:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid});
            val_122 = val_84.flags;
            val_123 = val_84.lo;
            if((System.String.op_Inequality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  "Real")) != false)
        {
                decimal val_88 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_122, hi = val_84.hi, lo = val_123, mid = val_84.mid}, 专丂丕丗丗东世丞下:  5);
            val_122 = val_88.flags;
            val_123 = val_88.lo;
        }
        
            if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), b:  "Real")) != false)
        {
                decimal val_92 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丕丗丁七下且与丝万();
            string val_93 = BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_92.flags, hi = val_92.hi, lo = val_92.lo, mid = val_92.mid}, 七丏丂丈世万丈上丕:  "F0");
        }
        
            val_121 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_122, hi = val_88.hi, lo = val_123, mid = val_88.mid}));
        }
        
        val_111 = this._oldPriceLabels;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_111, 丕丗丘丑丛与丑业丒:  val_121);
        val_116 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5570"), arg0:  Rilisoft.业丙丘丆东丈丕丂丄.丌丕七与与万业丂丁(丐丌一丈丒一丕丐丙:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, 丅丟丏丐丅三不丗东:  true));
        val_117 = this._profitLabel;
        label_59:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_117, 丕丗丘丑丛与丑业丒:  val_116);
        label_127:
        val_103 = this._tables;
        List.Enumerator<T> val_99 = val_103.GetEnumerator();
        label_181:
        if(((-962091272) & 1) == 0)
        {
            goto label_175;
        }
        
        string val_100 = 0.丐丏七丌丕丗业且上();
        if(val_100.gameObject.activeSelf == false)
        {
            goto label_181;
        }
        
        val_100.repositionNow = true;
        if(val_100 != null)
        {
            goto label_181;
        }
        
        goto label_181;
        label_175:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public EventStoreBankPriceView()
    {
    
    }

}
