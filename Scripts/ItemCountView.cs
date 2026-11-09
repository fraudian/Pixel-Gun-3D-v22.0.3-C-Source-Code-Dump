using UnityEngine;
internal sealed class ItemCountView : ItemViewComponent
{
    // Fields
    public string CountFormat;
    public UIBasicSprite countIcon;
    public UILabel countLabel;
    public UnityEngine.GameObject countContainer;
    public WidgetLayout widgetLayout;
    public UIWidget widgetForSize;
    public bool FormatLargeNumbers;
    public bool ShowZero;
    
    // Methods
    internal override void 丝一丅丆三东丂丞七()
    {
        if((true == 0) || (true == 0))
        {
            goto label_2;
        }
        
        if(this.丅丄且丐东且与丏丞() == false)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countContainer, 丏业丟一东丂东丘丛:  true);
        this.丈丆万丒七一与丆丌();
        this.七七丛不东丁三丐丝();
        goto label_6;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countContainer, 丏业丟一东丂东丘丛:  false);
        return;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countContainer, 丏业丟一东丂东丘丛:  false);
        label_6:
        this.丁下丏丙一丗下丈七();
    }
    private bool 丅丄且丐东且与丏丞()
    {
        var val_7;
        if(true == 0)
        {
            goto label_10;
        }
        
        if(45892 == 0)
        {
                return (bool)val_7;
        }
        
        if((45892.不业丙丒丂丞下丆丙() == 1310) || (不业丙丒丂丞下丆丙() == 1340))
        {
            goto label_5;
        }
        
        if((137121792 & 1) == 0)
        {
                if((PGCompany.万丞丘与丕丞下万丌.东丝丘丐丁下丝七下(丈丄不七三万丄丁不:  137121792)) == false)
        {
            goto label_10;
        }
        
        }
        
        if(this.ShowZero == false)
        {
            goto label_11;
        }
        
        label_5:
        val_7 = 1;
        return (bool)val_7;
        label_11:
        if(((137121792 & 1) != 0) || ((PGCompany.丁丑上丞业丞丟丛上.不丑不与丟丛丏丘丅(丈丄不七三万丄丁不:  137121792)) >= 2))
        {
            goto label_17;
        }
        
        label_10:
        val_7 = 0;
        return (bool)val_7;
        label_17:
        var val_6 = ((PGCompany.丁丑上丞业丞丟丛上.不丑不与丟丛丏丘丅(丈丄不七三万丄丁不:  this)) != 0) ? 1 : 0;
        return (bool)val_7;
    }
    private void 七七丛不东丁三丐丝()
    {
        UILabel val_30;
        object val_31;
        string val_32;
        UILabel val_33;
        val_30 = this;
        if(this.countLabel == 0)
        {
                return;
        }
        
        int val_2 = X21.丙丑丁专一专世万丕();
        if(val_2 < 1)
        {
            goto label_6;
        }
        
        label_68:
        val_31 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  X21.丙丑丁专一专世万丕(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        label_45:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.CountFormat)) != true)
        {
                val_32 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.CountFormat);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_32)) != false)
        {
                val_32 = this.CountFormat;
        }
        
            val_31 = System.String.Format(format:  val_32, arg0:  val_31);
        }
        
        val_33 = this.countLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_33, 丕丗丘丑丛与丑业丒:  val_31);
        if(val_31.不业丙丒丂丞下丆丙() == 1340)
        {
                int val_10 = 0.三丌上丒丆三一万丁();
            val_33 = val_10;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_10);
        }
        
        if(this.countLabel.不业丙丒丂丞下丆丙() == 1310)
        {
                int val_12 = 0.三丌上丒丆三一万丁();
            val_33 = val_12;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_12);
        }
        
        if(this.countLabel.不业丙丒丂丞下丆丙() == 1450)
        {
                val_33 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2002"), arg0:  val_2.丂丁丏一丙丛业且丌());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_33);
        }
        
        if(this.countLabel.不业丙丒丂丞下丆丙() != 1460)
        {
                return;
        }
        
        val_30 = this.countLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_30, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  this.countLabel.丂丁丏一丙丛业且丌()));
        return;
        label_6:
        if(X21.丂丁丏一丙丛业且丌() == 0)
        {
            goto label_45;
        }
        
        int val_21 = System.String.alignConst.丂丁丏一丙丛业且丌();
        if((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丈丄不七三万丄丁不:  X21)) == false)
        {
            goto label_49;
        }
        
        if(coinsShop.七三丗丏丑丗三丆世() == false)
        {
            goto label_52;
        }
        
        decimal val_24 = System.Decimal.op_Implicit(value:  val_21);
        string val_26 = Rilisoft.Offers.丁且丕专万丈丒丏丗.且业业丈丅丝丟丄专(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid}, 丞丂业丅丟丙丏七丗:  val_2.业东丅东丌上丗丑不(), 丆丗丘丕且丈丘丁不:  "F2");
        goto label_68;
        label_49:
        if(this.FormatLargeNumbers == false)
        {
            goto label_59;
        }
        
        string val_27 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_21);
        goto label_68;
        label_52:
        string val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
        goto label_68;
        label_59:
        string val_29 = val_21.ToString();
        goto label_68;
    }
    private void 丈丆万丒七一与丆丌()
    {
        if(this.countIcon == 0)
        {
                return;
        }
        
        UnityEngine.Object val_3 = (X21.不业丙丒丂丞下丆丙() == 1460) ? 0 : this.countIcon;
        UnityEngine.Object val_5 = 0;
        val_5 = UnityEngine.Object.op_Inequality(x:  val_3, y:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.countIcon, 丏业丟一东丂东丘丛:  val_5);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.countIcon, 与万丆丛丒万丝丙丑:  val_3);
        this.countIcon.color = new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B};
    }
    private void 丁下丏丙一丗下丈七()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.widgetLayout)) == false)
        {
                return;
        }
        
        this.widgetLayout.Reposition();
        if((UnityEngine.Object.op_Implicit(exists:  this.widgetForSize)) == false)
        {
                return;
        }
        
        this.widgetForSize.width = (int)this.widgetLayout.GetSize();
        this.widgetForSize.ResetAndUpdateAnchors();
    }
    internal void 七七丛不东丁三丐丝(string 丕丗丘丑丛与丑业丒)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        this.丁下丏丙一丗下丈七();
    }
    public ItemCountView()
    {
        this.FormatLargeNumbers = true;
        val_1 = new PGBehaviour();
    }

}
