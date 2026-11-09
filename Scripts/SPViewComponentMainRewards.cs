using UnityEngine;
internal sealed class SPViewComponentMainRewards : SPViewComponentBase
{
    // Fields
    private UIBasicSprite mainTexture;
    private ItemListUI allItemListUI;
    private ItemListUI currencyItemListUI;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        ItemListUI val_10;
        string val_11;
        ItemListUI val_12;
        ItemListUI val_13;
        var val_14;
        UIBasicSprite val_15;
        val_10 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.mainTexture, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.allItemListUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.currencyItemListUI, 丏业丟一东丂东丘丛:  false);
        val_11 = 0;
        bool val_2 = System.String.IsNullOrEmpty(value:  且丘丏丁丑与丙与丁.丙三专万丛丟万丝丘());
        if(val_2 == false)
        {
            goto label_4;
        }
        
        val_12 = this.allItemListUI;
        if(val_12 == null)
        {
            goto label_20;
        }
        
        val_12.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_2.丐下万丑丘专七丌世(丆万一不丌且东丐丐:  "reward-main", 且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁));
        val_10 = this.allItemListUI;
        goto label_21;
        label_4:
        if(且丘丏丁丑与丙与丁 == null)
        {
            goto label_7;
        }
        
        val_11 = "Advert";
        if((且丘丏丁丑与丙与丁.丝丒丙一丙丄不三丞().Equals(value:  val_11)) == false)
        {
            goto label_11;
        }
        
        val_12 = this.mainTexture;
        if((PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世().业七丗东丅丞业丆丁(丏丞专丏业丗丝七丝: out  0)) == false)
        {
            goto label_26;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_12, 与万丆丛丒万丝丙丑:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.mainTexture, 丏业丟一东丂东丘丛:  true);
        val_13 = this.currencyItemListUI;
        val_14 = 0;
        goto label_16;
        label_11:
        val_15 = this.mainTexture;
        goto label_17;
        label_7:
        val_15 = this.mainTexture;
        label_17:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_15, 与万丆丛丒万丝丙丑:  且丘丏丁丑与丙与丁);
        label_26:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.mainTexture, 丏业丟一东丂东丘丛:  true);
        val_12 = this.currencyItemListUI;
        if(val_12 == null)
        {
            goto label_20;
        }
        
        val_12.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.mainTexture.丐下万丑丘专七丌世(丆万一不丌且东丐丐:  "reward-currency", 且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁));
        val_10 = this.currencyItemListUI;
        goto label_21;
        label_20:
        val_10 = 0;
        label_21:
        val_14 = 1;
        val_13 = val_10;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_13, 丏业丟一东丂东丘丛:  true);
    }
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丐下万丑丘专七丌世(string 丆万一不丌且东丐丐, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        System.Collections.Generic.List<T> val_4;
        System.Collections.Generic.List<T> val_6;
        val_4 = 且丘丏丁丑与丙与丁;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        if(val_4 != null)
        {
                System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_3 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            val_4.丘丙丁丅七一与且丈(丆万一不丌且东丐丐:  丆万一不丌且东丐丐, 专丂丕丗丗东世丞下: ref  val_3);
            val_4 = val_3;
            专且丝丄丙丗丈不丞.上丁上三东丕丝丛丙(丅丆一丕丛与丁丂丛:  val_3, 丄丄丆不丂丗丛丙专: ref  val_1);
            val_6 = val_1;
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_6;
        }
        
        val_6 = val_4;
        return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_6;
    }
    public SPViewComponentMainRewards()
    {
        val_1 = new PGBehaviour();
    }

}
