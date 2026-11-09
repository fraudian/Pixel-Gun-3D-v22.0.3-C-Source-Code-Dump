using UnityEngine;
internal class ClanBankViewItem : AbstractBankViewItem
{
    // Fields
    private System.Collections.Generic.List<UILabel> _nameLabels;
    private ProductPriceView _priceView;
    private BankMultyOfferView _multyOfferView;
    private UnityEngine.GameObject _countContainer;
    private System.Collections.Generic.List<UILabel> _countLabels;
    private UnityEngine.GameObject _infoButton;
    private UnityEngine.GameObject _saleContainer;
    private UILabel _saleLabel;
    
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
        string val_29;
        string val_30;
        string val_31;
        string val_32;
        var val_33;
        var val_34;
        UnityEngine.GameObject val_35;
        string val_36;
        val_29 = this;
        PGCompany.丘丒下东丗丏丁丅业 val_1 = this.Product;
        Rilisoft.OfferItem val_2 = val_1.Items.Item[0];
        if((val_2.Type != 1200) || ((System.String.op_Equality(a:  val_2.Id, b:  "ClanSilver")) == false))
        {
            goto label_6;
        }
        
        PGCompany.丘丒下东丗丏丁丅业 val_6 = this.Product;
        int val_7 = val_6.Price.丟丂丞不专丆万丒世();
        if(val_7 > 19)
        {
            goto label_9;
        }
        
        if((val_7 - 1) > 9)
        {
            goto label_21;
        }
        
        var val_29 = 106021192 + ((val_7 - 1)) << 2;
        val_29 = val_29 + 106021192;
        goto (106021192 + ((val_7 - 1)) << 2 + 106021192);
        label_6:
        if(val_2 != null)
        {
                val_32 = val_2.Name;
        }
        else
        {
                val_32 = val_2.Name;
        }
        
        val_33 = val_2.Texture;
        val_34 = 1;
        val_35 = this._infoButton;
        goto label_18;
        label_9:
        if(val_7 == 20)
        {
            goto label_19;
        }
        
        if(val_7 == 50)
        {
            goto label_20;
        }
        
        if(val_7 != 100)
        {
            goto label_21;
        }
        
        val_30 = "OfferIcons\\silver_7";
        val_31 = "Key_7996";
        goto label_36;
        label_21:
        val_30 = "OfferIcons\\silver_1";
        val_31 = "Key_7990";
        goto label_36;
        label_19:
        val_30 = "OfferIcons\\silver_5";
        val_31 = "Key_7994";
        goto label_36;
        label_20:
        val_30 = "OfferIcons\\silver_6";
        val_31 = "Key_7995";
        label_36:
        val_32 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31);
        val_33 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_30);
        val_35 = this._infoButton;
        val_34 = 0;
        label_18:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nameLabels, 丕丗丘丑丛与丑业丒:  val_32);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._nameLabels, 丏业丟一东丂东丘丛:  true);
        if(this._priceView != 0)
        {
                this._priceView.Setup(东丈丏东丑丟不不丞:  this.Product);
        }
        
        if(val_2.Count < 2)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._countLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2.Count));
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._countContainer, 丕丗丘丑丛与丑业丒:  this.Product.丈世下下丅丕丐丗丁());
        if(this._saleContainer == 0)
        {
                return;
        }
        
        if(this.Product.丆丞上丛丂一业丟丕() >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleContainer, 丏业丟一东丂东丘丛:  true);
            if(this._saleLabel == 0)
        {
                return;
        }
        
            val_36 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2555");
            val_29 = System.String.Format(format:  val_36, arg0:  this.Product.丆丞上丛丂一业丟丕());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._saleLabel, 丕丗丘丑丛与丑业丒:  val_29);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._saleContainer, 丏业丟一东丂东丘丛:  false);
    }
    public ClanBankViewItem()
    {
    
    }

}
