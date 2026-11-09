using UnityEngine;
internal sealed class SPViewComponentDiscount : SPViewComponentBase
{
    // Fields
    internal bool forceShow;
    private UILabel label;
    private string locKey;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_10;
        var val_11;
        int val_12;
        var val_13;
        object val_14;
        string val_15;
        val_10 = this;
        val_11 = this.gameObject;
        val_11.SetActive(value:  false);
        if(this.forceShow != true)
        {
                val_12 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛();
            val_11 = val_12;
            bool val_3 = val_11.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "hide_sale");
            if(val_3 == true)
        {
                return;
        }
        
        }
        
        decimal val_4 = val_3.丐丁丒世丟世丘丌丅(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        val_12 = val_4.flags;
        val_13 = null;
        val_13 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_12, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.locKey)) != false)
        {
                val_14 = val_4;
            val_15 = "{0}%";
        }
        else
        {
                val_14 = val_4;
            val_15 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.locKey);
        }
        
        val_12 = System.String.Format(format:  val_15, arg0:  val_4);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  val_12);
        val_10 = this.gameObject;
        val_10.SetActive(value:  true);
    }
    private decimal 丐丁丒世丟世丘丌丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.专丟专世丅丂丁且专 val_21;
        int val_22;
        var val_23;
        int val_24;
        var val_25;
        val_21 = 且丘丏丁丑与丙与丁;
        if(val_21 == null)
        {
            goto label_1;
        }
        
        if((System.String.op_Equality(a:  val_21.丝丒丙一丙丄不三丞(), b:  "constructable")) != true)
        {
                if((System.String.op_Equality(a:  val_21.丝丒丙一丙丄不三丞(), b:  "silver")) == false)
        {
            goto label_5;
        }
        
        }
        
        label_28:
        val_22 = val_21;
        val_23 = 0;
        decimal val_5 = val_22.万丏丛上丌丏业三不();
        return new System.Decimal() {flags = val_16.flags, hi = val_16.hi, lo = val_16.lo, mid = val_16.mid};
        label_1:
        label_29:
        PGCompany.丝丗丁丞丒且丙丑丙 val_6 = val_21.不业丙丒丂丞下丆丙();
        if((val_6 == 22) || (val_6 == 20))
        {
            goto label_8;
        }
        
        if(val_6 != 13)
        {
            goto label_9;
        }
        
        val_21 = val_21.七丈丒丒下下且万与();
        val_22 = 0;
        val_23 = 0;
        if((PGCompany.七丂专七丆丗不丌专.专业丈且丆专万不丁(一丗与一专丙丙丅丄:  val_21, 丞世不丒下上上丝丑: out  0)) == false)
        {
                return new System.Decimal() {flags = val_16.flags, hi = val_16.hi, lo = val_16.lo, mid = val_16.mid};
        }
        
        val_24 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  0);
        int val_12 = val_24.丆丞上丛丂一业丟丕();
        goto label_18;
        label_8:
        val_24 = val_21;
        int val_13 = val_24.丆丞上丛丂一业丟丕();
        goto label_18;
        label_9:
        decimal val_14 = val_21.万丏丛上丌丏业三不();
        val_24 = val_14.flags;
        label_18:
        val_21 = PGCompany.MainStore.丗丝丙丏不丄七丌一.丛丗丈丙上业丟与丞(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_24, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid}, 丈丞丄世丞丂丌丁丛:  5);
        val_22 = val_21;
        val_23 = 0;
        decimal val_16 = System.Decimal.op_Implicit(value:  val_22);
        return new System.Decimal() {flags = val_16.flags, hi = val_16.hi, lo = val_16.lo, mid = val_16.mid};
        label_5:
        decimal val_17 = val_21.万丏丛上丌丏业三不();
        val_25 = null;
        val_25 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
        {
            goto label_29;
        }
        
        if((val_21.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "source.currency")) == true)
        {
            goto label_28;
        }
        
        goto label_29;
    }
    public SPViewComponentDiscount()
    {
        val_1 = new PGBehaviour();
    }

}
