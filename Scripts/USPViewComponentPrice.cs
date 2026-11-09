using UnityEngine;
internal sealed class USPViewComponentPrice : SPViewComponentBase
{
    // Fields
    private UILabel textLabel;
    private ItemListUI priceList;
    private UnityEngine.GameObject holder;
    private bool hideIfCantPurchase;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UILabel val_13;
        UnityEngine.GameObject val_14;
        var val_15;
        object val_16;
        PGCompany.三东丏不丗世丅丌丄 val_17;
        val_14 = this;
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        if(且丘丏丁丑与丙与丁 == null)
        {
            goto label_5;
        }
        
        if(this.hideIfCantPurchase == false)
        {
            goto label_3;
        }
        
        val_15 = 0;
        if((且丘丏丁丑与丙与丁.与丈丟东丆丅丅丝丁(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int64>() {HasValue = false})) == false)
        {
            goto label_5;
        }
        
        label_3:
        int val_2 = 且丘丏丁丑与丙与丁.丂丁丏一丙丛业且丌();
        val_16 = val_2.ToString();
        val_17 = 137154560;
        if((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丈丄不七三万丄丁不:  val_17)) == false)
        {
            goto label_11;
        }
        
        if(coinsShop.七三丗丏丑丗三丆世() == false)
        {
            goto label_14;
        }
        
        decimal val_6 = System.Decimal.op_Implicit(value:  val_2);
        val_17 = val_6.lo;
        string val_8 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且业业丈丅丝丟丄专(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_17, mid = val_6.mid}, 丞丂业丅丟丙丏七丗:  X22.业东丅东丌上丗丑不(), 丆丗丘丕且丈丘丁不:  "F2");
        goto label_21;
        label_5:
        val_14 = this.holder;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  false);
        return;
        label_14:
        label_21:
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
        label_11:
        val_13 = this.textLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_13, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  X22.丗三丘丑丝丛丞丅与()), arg0:  val_16));
        if(this.priceList == null)
        {
                return;
        }
        
        this.priceList.丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  this);
    }
    public USPViewComponentPrice()
    {
    
    }

}
