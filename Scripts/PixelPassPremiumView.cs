using UnityEngine;
internal sealed class PixelPassPremiumView : PGBehaviour
{
    // Fields
    private UILabel headerLabel;
    private UILabel saleLabel;
    private PGCompany.InventoryItemView oldPriceView;
    private PGCompany.InventoryItemView priceView;
    private ItemListUI itemListUI;
    private UIScrollView scrollView;
    private StoreCharacterHelper character;
    private UILabel offerLabel_1;
    private UILabel offerLabel_2;
    private UILabel offerLabel_3;
    private UILabel offerLabel_4;
    private PGCompany.PixelPass.专一丙丂丑上上丛东 与丛专一丘丅丟丑万;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.专一丙丂丑上上丛东 不东万下丆丝东丞丏)
    {
        this.与丛专一丘丅丟丑万 = 不东万下丆丝东丞丏;
        this.character.万与七丕七丁丞下丆 = false;
        this.character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_5;
        bool val_6;
        var val_7;
        if(this.scrollView != null)
        {
                this.scrollView.ResetPosition();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.headerLabel, 丕丗丘丑丛与丑业丒:  this.与丛专一丘丅丟丑万);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.saleLabel, 丏业丟一东丂东丘丛:  this.与丛专一丘丅丟丑万 & 1);
        val_5 = this.与丛专一丘丅丟丑万;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.saleLabel, 丕丗丘丑丛与丑业丒:  val_5);
        if(this.itemListUI != null)
        {
                val_5 = this.与丛专一丘丅丟丑万;
            this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_5);
        }
        
        val_6 = PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  this.与丛专一丘丅丟丑万);
        val_7 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.oldPriceView, 丏业丟一东丂东丘丛:  val_6);
        if(this.oldPriceView != null)
        {
                val_6 = this.与丛专一丘丅丟丑万;
            val_7 = 0;
            this.oldPriceView.Setup(丈丄不七三万丄丁不:  val_6);
        }
        
        if(this.priceView != null)
        {
                val_7 = 0;
            this.priceView.Setup(丈丄不七三万丄丁不:  this.与丛专一丘丅丟丑万);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.offerLabel_1, 丕丗丘丑丛与丑业丒:  this.与丛专一丘丅丟丑万);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.offerLabel_2, 丕丗丘丑丛与丑业丒:  this.与丛专一丘丅丟丑万);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.offerLabel_3, 丕丗丘丑丛与丑业丒:  this.与丛专一丘丅丟丑万);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.offerLabel_4, 丕丗丘丑丛与丑业丒:  this.与丛专一丘丅丟丑万);
        this.character.与丕丆上丛丐下丕丂().专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  false);
        this.character.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        this.character.丞上丄丄上丞丘下丁();
        this.character.丂丄丗丝丌丌丝世丘(丈丄不七三万丄丁不:  this.与丛专一丘丅丟丑万, 万下万丘丌丄丝丐丆:  true, 丙万丘丗丅万丐一世:  true);
    }
    public void U_Buy()
    {
        bool val_1 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.且丕丑上丕丞专丝且(丙业丞丑七丗下丟丌:  this.与丛专一丘丅丟丑万);
    }
    public PixelPassPremiumView()
    {
    
    }

}
