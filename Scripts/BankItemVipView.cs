using UnityEngine;
internal class BankItemVipView : RealInappBankViewItem
{
    // Fields
    private UILabel[] daysLabel;
    public UnityEngine.GameObject profitGO;
    public UILabel profitLabel;
    public UnityEngine.GameObject[] vipSprites;
    private int <丈一与丂丁业丌丛丑>k__BackingField;
    
    // Properties
    private int 丒专下与丑丁丆丟业 { get; set; }
    
    // Methods
    private int 丂丁丏一丙丛业且丌()
    {
        return (int)this.<丈一与丂丁业丌丛丑>k__BackingField;
    }
    private void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
    {
        this.<丈一与丂丁业丌丛丑>k__BackingField = 丙业与丙丗丝不丈东;
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
        this.<丈一与丂丁业丌丛丑>k__BackingField = 上业一丄三与丂丄丏.丂丁丏一丙丛业且丌();
        this.丞丈丛丆业丄丗丒丑();
        this.丏与下且上丞丗丕下();
    }
    protected override void OnEnable()
    {
    
    }
    protected override void OnDisable()
    {
    
    }
    protected override void 丞业与下丛万丁下丙()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = 0;
        goto label_1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.vipSprites[0], 丏业丟一东丂东丘丛:  false);
        val_7 = 1;
        label_1:
        if(val_7 < this.vipSprites.Length)
        {
            goto label_6;
        }
        
        val_8 = 0;
        val_9 = 0;
        label_15:
        int val_1 = val_8 + 1;
        val_10 = 丏丄丑上丛不丈且万.丐三万专丌丌世丘上();
        if(val_1 >= val_10.丛丄三万丁丙丐丞丂())
        {
            goto label_10;
        }
        
        val_10 = 丏丄丑上丛不丈且万.丐三万专丌丌世丘上();
        var val_6 = ((val_10.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_1)) > 0) ? (val_9 + 1) : (val_9);
        val_8 = val_8 + 1;
        if(val_8 != val_1.业东丅东丌上丗丑不())
        {
            goto label_15;
        }
        
        label_10:
        if((val_6 & 2147483648) != 0)
        {
                return;
        }
        
        this.vipSprites[(long)val_6].SetActive(value:  true);
    }
    private void 丞丈丛丆业丄丗丒丑()
    {
        UILabel val_6;
        int val_7;
        string val_8;
        var val_9;
        val_6 = this;
        val_7 = this.<丈一与丂丁业丌丛丑>k__BackingField;
        val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4104");
        if(val_7 == 1)
        {
                val_7 = this.<丈一与丂丁业丌丛丑>k__BackingField;
            val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4102");
        }
        
        val_9 = 0;
        goto label_6;
        label_10:
        val_6 = this.daysLabel[0];
        val_6.text = System.String.Format(format:  val_8, arg0:  val_7 + System.Environment.NewLine);
        val_9 = 1;
        label_6:
        if(val_9 < this.daysLabel.Length)
        {
            goto label_10;
        }
    
    }
    private void 丏与下且上丞丗丕下()
    {
        decimal val_1 = System.Decimal.op_Implicit(value:  this.<丈一与丂丁业丌丛丑>k__BackingField);
        decimal val_2 = X22.丕七丗丘业丆一丘一();
        decimal val_3 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
        decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal());
        decimal val_5 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid}, 专丂丕丗丗东世丞下:  10);
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal())) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.profitGO, 丏业丟一东丂东丘丛:  true);
            this = this.profitLabel;
            this.text = System.String.Format(format:  "{0} {1}%", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3710"), arg1:  val_5);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.profitGO, 丏业丟一东丂东丘丛:  false);
    }
    public BankItemVipView()
    {
    
    }

}
