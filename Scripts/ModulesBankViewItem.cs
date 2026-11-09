using UnityEngine;
internal class ModulesBankViewItem : AbstractBankViewItem
{
    // Fields
    private System.Collections.Generic.List<UILabel> _nameLabels;
    private ProductPriceView _priceView;
    private BankMultyOfferView _multyOfferView;
    private UnityEngine.GameObject _countContainer;
    private System.Collections.Generic.List<UILabel> _countLabels;
    private UnityEngine.GameObject _infoButton;
    
    // Methods
    protected override void OnDisable()
    {
    
    }
    protected override void OnEnable()
    {
    
    }
    protected override void 丞业与下丛万丁下丙()
    {
    
    }
    public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丛与世且丑丅丟下丛)
    {
        this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丛与世且丑丅丟下丛:  丛与世且丑丅丟下丛);
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_19;
        string val_20;
        string val_21;
        var val_22;
        var val_23;
        UnityEngine.GameObject val_24;
        PGCompany.丘丒下东丗丏丁丅业 val_1 = this.Product;
        Rilisoft.OfferItem val_2 = val_1.Items.Item[0];
        if(val_2.Type != 1140)
        {
            goto label_4;
        }
        
        PGCompany.丘丒下东丗丏丁丅业 val_4 = this.Product;
        int val_5 = val_4.Price.丟丂丞不专丆万丒世();
        if(val_5 > 19)
        {
            goto label_7;
        }
        
        if((val_5 - 1) > 9)
        {
            goto label_16;
        }
        
        var val_19 = 106017140 + ((val_5 - 1)) << 2;
        val_19 = val_19 + 106017140;
        goto (106017140 + ((val_5 - 1)) << 2 + 106017140);
        label_4:
        if(val_2 == null)
        {
            goto label_12;
        }
        
        val_21 = val_2.Name;
        goto label_13;
        label_7:
        if(val_5 == 20)
        {
            goto label_14;
        }
        
        if(val_5 == 50)
        {
            goto label_15;
        }
        
        if(val_5 != 100)
        {
            goto label_16;
        }
        
        val_19 = "Textures\\Bank\\CraftCurrency_7";
        val_20 = "Key_7214";
        goto label_34;
        label_12:
        val_21 = val_2.Name;
        label_13:
        val_22 = val_2.Texture;
        val_23 = 1;
        val_24 = this._infoButton;
        goto label_22;
        label_16:
        val_19 = "Textures\\Bank\\CraftCurrency_1";
        val_20 = "Key_7199";
        goto label_34;
        label_14:
        val_19 = "Textures\\Bank\\CraftCurrency_5";
        val_20 = "Key_7203";
        goto label_34;
        label_15:
        val_19 = "Textures\\Bank\\CraftCurrency_6";
        val_20 = "Key_7213";
        label_34:
        val_21 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_20);
        val_22 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_19);
        val_24 = this._infoButton;
        val_23 = 0;
        label_22:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nameLabels, 丕丗丘丑丛与丑业丒:  val_21);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._nameLabels, 丏业丟一东丂东丘丛:  true);
        if(this._priceView != 0)
        {
                this._priceView.Setup(东丈丏东丑丟不不丞:  this.Product);
        }
        
        if(val_2.Type == 1140)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._countLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2.Count));
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
        }
        
        PGCompany.丘丒下东丗丏丁丅业 val_17 = this.Product;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_17, 丕丗丘丑丛与丑业丒:  val_17.丈世下下丅丕丐丗丁());
    }
    public ModulesBankViewItem()
    {
    
    }

}
