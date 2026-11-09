using UnityEngine;
internal sealed class SPViewComponentHeader : SPViewComponentBase
{
    // Fields
    private UILabel titleLabel;
    private UILabel rarityLabel;
    private UILabel descriptionLabel;
    private ItemListUI itemListUI;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        ItemListUI val_12;
        UILabel val_13;
        var val_14;
        ItemListUI val_15;
        val_12 = this;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rarityLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  且丘丏丁丑与丙与丁)));
        UnityEngine.Color val_3 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.rarityLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  且丘丏丁丑与丙与丁);
        if(this.itemListUI != null)
        {
                this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  且丘丏丁丑与丙与丁);
        }
        
        val_13 = this.titleLabel;
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "view.header")) == false)
        {
            goto label_10;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_13, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rarityLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.descriptionLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemListUI, 丏业丟一东丂东丘丛:  false);
        val_13 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛();
        if((val_13.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view.header.count")) == false)
        {
            goto label_14;
        }
        
        val_12 = this.itemListUI;
        val_14 = 1;
        val_15 = val_12;
        goto label_17;
        label_10:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_13, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rarityLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.descriptionLabel, 丏业丟一东丂东丘丛:  true);
        val_15 = this.itemListUI;
        label_29:
        val_14 = 1;
        label_17:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_15, 丏业丟一东丂东丘丛:  true);
        return;
        label_14:
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view.header.title_description")) == false)
        {
            goto label_21;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.titleLabel, 丏业丟一东丂东丘丛:  true);
        goto label_29;
        label_21:
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view.header.title_rarity")) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.titleLabel, 丏业丟一东丂东丘丛:  true);
        goto label_29;
    }
    public SPViewComponentHeader()
    {
        val_1 = new PGBehaviour();
    }

}
