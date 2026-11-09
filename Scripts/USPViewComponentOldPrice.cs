using UnityEngine;
internal sealed class USPViewComponentOldPrice : SPViewComponentBase
{
    // Fields
    private UILabel textLabel;
    private UnityEngine.GameObject holder;
    private bool hideIfCantPurchase;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        string val_17;
        UILabel val_18;
        object val_19;
        UILabel val_21;
        int val_22;
        val_18 = this;
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        if(且丘丏丁丑与丙与丁.丑专不且丒丄丏丝丞() == null)
        {
            goto label_5;
        }
        
        if(this.hideIfCantPurchase != false)
        {
                if((且丘丏丁丑与丙与丁.与丈丟东丆丅丅丝丁(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int64>() {HasValue = false})) == false)
        {
            goto label_5;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  true);
        int val_4 = this.holder.丑专不且丒丄丏丝丞().丂丁丏一丙丛业且丌();
        val_19 = val_4.ToString();
        PGCompany.三东丏不丗世丅丌丄 val_6 = 丑专不且丒丄丏丝丞();
        if((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丈丄不七三万丄丁不:  val_6)) == false)
        {
            goto label_13;
        }
        
        if(coinsShop.七三丗丏丑丗三丆世() == false)
        {
            goto label_16;
        }
        
        decimal val_9 = System.Decimal.op_Implicit(value:  val_4);
        string val_12 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且业业丈丅丝丟丄专(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid}, 丞丂业丅丟丙丏七丗:  X22.丑专不且丒丄丏丝丞().业东丅东丌上丗丑不(), 丆丗丘丕且丈丘丁不:  "F2");
        goto label_23;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        val_21 = this.textLabel;
        val_22 = System.String.alignConst;
        goto label_26;
        label_16:
        label_23:
        val_19 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
        label_13:
        val_18 = this.textLabel;
        val_17 = val_6.丙丐丏丝丈丆业丝丞();
        val_21 = val_18;
        val_22 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_17), arg0:  val_19);
        label_26:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_21, 丕丗丘丑丛与丑业丒:  val_22);
    }
    public USPViewComponentOldPrice()
    {
    
    }

}
