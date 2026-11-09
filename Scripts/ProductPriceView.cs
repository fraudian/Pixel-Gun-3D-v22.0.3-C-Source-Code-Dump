using UnityEngine;
internal class ProductPriceView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.丘丒下东丗丏丁丅业>
{
    // Fields
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
    private PGCompany.丘丒下东丗丏丁丅业 <丅丝丌丝丁丏丙东丞>k__BackingField;
    
    // Properties
    public PGCompany.丘丒下东丗丏丁丅业 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    public PGCompany.丘丒下东丗丏丁丅业 get_Context()
    {
        return (PGCompany.丘丒下东丗丏丁丅业)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(PGCompany.丘丒下东丗丏丁丅业 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(PGCompany.丘丒下东丗丏丁丅业 东丈丏东丑丟不不丞)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 东丈丏东丑丟不不丞;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        System.Collections.Generic.List<UITable> val_60;
        UnityEngine.GameObject val_61;
        var val_62;
        var val_63;
        var val_64;
        UnityEngine.GameObject val_65;
        var val_66;
        var val_68;
        var val_69;
        int val_70;
        int val_71;
        val_60 = this;
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._realPriceObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsPriceContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsPriceContainer, 丏业丟一东丂东丘丛:  false);
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  "Real")) == false)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._realPriceObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleRealPrice, 丏业丟一东丂东丘丛:  false);
        val_61 = this._withoutSaleRealPrice;
        val_62 = 1;
        goto label_9;
        label_6:
        val_63 = null;
        val_63 = null;
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_14;
        }
        
        val_64 = null;
        val_65 = this._gemsPriceContainer;
        goto label_23;
        label_14:
        val_66 = null;
        val_66 = null;
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_21;
        }
        
        val_64 = null;
        val_65 = this._coinsPriceContainer;
        label_23:
        val_62 = 1;
        val_61 = val_65;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_61, 丏业丟一东丂东丘丛:  true);
        label_21:
        bool val_8 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  "Real");
        if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
            goto label_26;
        }
        
        if(val_8 == false)
        {
            goto label_27;
        }
        
        label_29:
        string val_9 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丈世下下丅丕丐丗丁();
        goto label_28;
        label_26:
        if(val_8 == true)
        {
            goto label_29;
        }
        
        label_27:
        label_28:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._priceLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.丟丂丞不专丆万丒世()));
        val_68 = null;
        val_68 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
        {
            goto label_37;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsProfitObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsProfitObject, 丏业丟一东丂东丘丛:  false);
        if(this._gemsPriceObject != 0)
        {
                UnityEngine.Vector3 val_16 = this._gemsPriceObject.transform.localPosition;
            UnityEngine.Vector3 val_18 = this._gemsPriceObject.transform.localPosition;
            this._gemsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if(this._coinsPriceObject == 0)
        {
            goto label_58;
        }
        
        UnityEngine.Vector3 val_22 = this._coinsPriceObject.transform.localPosition;
        UnityEngine.Vector3 val_24 = this._coinsPriceObject.transform.localPosition;
        this._coinsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_58;
        label_37:
        if(this._gemsPriceObject != 0)
        {
                UnityEngine.Vector3 val_28 = this._gemsPriceObject.transform.localPosition;
            UnityEngine.Vector3 val_30 = this._gemsPriceObject.transform.localPosition;
            this._gemsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if(this._coinsPriceObject != 0)
        {
                UnityEngine.Vector3 val_34 = this._coinsPriceObject.transform.localPosition;
            UnityEngine.Vector3 val_36 = this._coinsPriceObject.transform.localPosition;
            this._coinsPriceObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  true);
        val_69 = null;
        val_69 = null;
        string val_60 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        val_60 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  val_60);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsProfitObject, 丏业丟一东丂东丘丛:  val_60);
        string val_61 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        val_61 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  val_61);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsProfitObject, 丏业丟一东丂东丘丛:  val_61);
        decimal val_42 = System.Decimal.op_Implicit(value:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.丟丂丞不专丆万丒世());
        decimal val_43 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_42.flags, hi = val_42.hi, lo = val_42.lo, mid = val_42.mid}, d2:  new System.Decimal());
        val_70 = val_43.flags;
        val_71 = val_43.lo;
        if((System.String.op_Inequality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  "Real")) != false)
        {
                decimal val_46 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_70, hi = val_43.hi, lo = val_71, mid = val_43.mid}, 专丂丕丗丗东世丞下:  5);
            val_70 = val_46.flags;
            val_71 = val_46.lo;
        }
        
        if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Price.东与三丌丅三丒丏业(), b:  "Real")) != false)
        {
                decimal val_49 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丕丗丁七下且与丝万();
            string val_50 = BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_49.flags, hi = val_49.hi, lo = val_49.lo, mid = val_49.mid}, 七丏丂丈世万丈上丕:  "F0");
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._oldPriceLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_70, hi = val_46.hi, lo = val_71, mid = val_46.mid})));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._profitLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5570"), arg0:  Rilisoft.业丙丘丆东丈丕丂丄.丌丕七与与万业丂丁(丐丌一丈丒一丕丐丙:  new System.Decimal(), 丅丟丏丐丅三不丗东:  true)));
        label_58:
        val_60 = this._tables;
        List.Enumerator<T> val_56 = val_60.GetEnumerator();
        label_116:
        if(((-933814280) & 1) == 0)
        {
            goto label_110;
        }
        
        string val_57 = 0.丐丏七丌丕丗业且上();
        if(val_57.gameObject.activeSelf == false)
        {
            goto label_116;
        }
        
        val_57.repositionNow = true;
        if(val_57 != null)
        {
            goto label_116;
        }
        
        goto label_116;
        label_110:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ProductPriceView()
    {
    
    }

}
