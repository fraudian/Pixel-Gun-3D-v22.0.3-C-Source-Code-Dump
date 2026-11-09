using UnityEngine;
internal sealed class USPViewComponentSale : SPViewComponentBase
{
    // Fields
    private UILabel textLabel;
    private UILabel discountLabel;
    private UILabel textAndDiscountLabel;
    private System.Collections.Generic.List<WidgetLayout> widgetLayouts;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        bool val_2 = System.String.IsNullOrEmpty(value:  且丘丏丁丑与丙与丁.丗丏丑与丕丘丏一丅());
        UnityEngine.GameObject val_3 = this.gameObject;
        if(val_3 == null)
        {
            goto label_2;
        }
        
        if(val_2 == false)
        {
            goto label_3;
        }
        
        label_4:
        val_3.SetActive(value:  false);
        return;
        label_2:
        if(val_2 == true)
        {
            goto label_4;
        }
        
        label_3:
        val_3.SetActive(value:  true);
        string val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3.丗丐丕丑丅不丑丘不());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.textLabel, 丕丗丘丑丛与丑业丒:  val_5);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.discountLabel, 丕丗丘丑丛与丑业丒:  X22.丗丏丑与丕丘丏一丅());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.textAndDiscountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_5, arg0:  X22.丗丏丑与丕丘丏一丅()));
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.widgetLayouts);
    }
    public USPViewComponentSale()
    {
        this.widgetLayouts = new System.Collections.Generic.List<WidgetLayout>();
    }

}
