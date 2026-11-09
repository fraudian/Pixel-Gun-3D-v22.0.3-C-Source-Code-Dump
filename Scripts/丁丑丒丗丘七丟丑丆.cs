using UnityEngine;
private sealed class ShopNGUIController.丁丑丒丗丘七丟丑丆
{
    // Fields
    public ShopNGUIController 丝且与丝丒丟万丁专;
    public 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞;
    public CategoryNames 专丄丌且一丕万与丛;
    public bool 不丟丞丑丛丆丁东与;
    public string 丞一丁业丄一一业且;
    public string 丌业专专丞专专丆丌;
    public 丕丑丙丑丙东丌丘丕 丄下丁东丘业丆丝上;
    public bool 丗业丕七且丝丆丝丘;
    public bool 丐丏上业丈丂与万丞;
    public System.Action 丟丟丟三东丛丌丘且;
    
    // Methods
    public ShopNGUIController.丁丑丒丗丘七丟丑丆()
    {
    
    }
    internal void 丙丙丕上丂丗丑丕东()
    {
        丙且上东下丏丏丟下 val_8;
        CategoryNames val_9;
        var val_10;
        var val_11;
        UnityEngine.Debug.LogError(message:  "Arsenal (not enough currency) -> GoToMainStore");
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_8 = this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑();
        }
        else
        {
                val_8 = 0.东丂丈与丄丛万丞丑();
        }
        
        this.丝且与丝丒丟万丁专.丁七丁丞丞丟丒业丅 = val_8;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_9 = this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且();
        }
        else
        {
                val_9 = 0.丗丛丐丑丛丅丞七且();
        }
        
        this.丝且与丝丒丟万丁专.丌不丒万万丟丞上与 = val_9;
        this.丝且与丝丒丟万丁专.丕丏丑丏丏丂与东丏 = ShopNGUIController.丛丐丛专丟丞万三七();
        val_10 = null;
        val_10 = null;
        val_11 = null;
        val_11 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丟七丁不丞东丛不丅;
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丟七丁不丞东丛不丅, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    internal void 丟丐一丌与丐七丏丂()
    {
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.专丄丌且一丕万与丛)) == false)
        {
            goto label_17;
        }
        
        if(this.不丟丞丑丛丆丁东与 == false)
        {
            goto label_4;
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丞一丁业丄一一业且);
        if(((val_2 == null) || (val_2.东七与与不丅丙上上() == true)) || (ShopNGUIController.丛丐丛专丟丞万三七() < 100))
        {
            goto label_17;
        }
        
        Rilisoft.一丟专且三万丞丁丂.业丅上丏丛且东业三(丒世丘丘上丆丝东丞:  this.丒世丘丘上丆丝东丞);
        goto label_17;
        label_4:
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                Rilisoft.一丟专且三万丞丁丂.七三丈丐业丈一且丒(丝丁不丝丌三丅且丗:  this.丞一丁业丄一一业且);
        }
        
        label_17:
        this.丗专不丞三丑不下上(丞业丛世丛丘丝不丌:  false, 世丙与专七丟丒丆世:  1);
    }
    internal void 与业丘丅丙三丅且不()
    {
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        if((this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() == 25000) && (this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() != null))
        {
                if(this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌() == 25000)
        {
                this.丝且与丝丒丟万丁专.丈丕上不且世专且七(上东丞世三世且丈丌:  this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七());
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() != null)
        {
                if(this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌() == 210000)
        {
                this.丝且与丝丒丟万丁专.不丅七不丄丝丄丝丑(丄丄丄丕丂东丈丞丐:  this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七());
        }
        
        }
        
        this.丝且与丝丒丟万丁专.gridScrollView.Restrict();
        this.丝且与丝丒丟万丁专.专丞丑丑丂丟下丌丁();
    }
    internal void 丗专不丞三丑不下上(bool 丞业丛世丛丘丝不丌, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 世丙与专七丟丒丆世)
    {
        var val_66;
        var val_67;
        var val_68;
        string val_70;
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_71;
        CategoryNames val_72;
        string val_73;
        string val_74;
        丈丞丕丘丕丗与上一 val_75;
        ArmoryInfoScreenController val_76;
        丙且上东下丏丏丟下 val_77;
        var val_78;
        val_66 = null;
        val_66 = null;
        if((PGCompany.GameplayLoop.丕与七丐丞丕丑业世.万下丝东七丙万丒业(丞一丁业丄一一业且:  this.丞一丁业丄一一业且)) != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  40);
            val_67 = 1;
        }
        else
        {
                val_67 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丏丘丞不丌一丁丗丑(丌业专专丞专专丆丌:  this.丌业专专丞专专丆丌, 丞一丁业丄一一业且:  this.丞一丁业丄一一业且, 万丐丏丐丒万不丟三:  this.丒世丘丘上丆丝东丞, 不丟丞丑丛丆丁东与:  (this.不丟丞丑丛丆丁东与 == true) ? 1 : 0, 丄下丁东丘业丆丝上:  this.丄下丁东丘业丆丝上, 丗业丕七且丝丆丝丘:  (this.丗业丕七且丝丆丝丘 == true) ? 1 : 0, 丐丏上业丈丂与万丞:  (this.丐丏上业丈丂与万丞 == true) ? 1 : 0, 不丐丅丁丂七丐丘丛:  世丙与专七丟丒丆世);
        if(val_67 != 0)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        
        丙且上东下丏丏丟下 val_12 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  mem[1152921539134300192]);
        if(this.不丟丞丑丛丆丁东与 == false)
        {
            goto label_17;
        }
        
        if(this.丗业丕七且丝丆丝丘 == false)
        {
            goto label_18;
        }
        
        val_68 = null;
        goto label_70;
        label_17:
        if((this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() != null) && (this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌() == 190000))
        {
                CategoryNames val_17 = this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌();
        }
        
        if((((this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 0) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 1)) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 4)) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 5))
        {
                if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 2)
        {
                if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 3)
        {
            goto label_41;
        }
        
        }
        
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.三丛丅不不丛丑丆三();
        label_41:
        val_70 = (((WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  this.丞一丁业丄一一业且)) | (WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  this.丞一丁业丄一一业且))) != ((this.不丟丞丑丛丆丁东与 == false) ? 1 : 0)) ? "try gun" : "armory";
        val_71 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        val_72 = this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且();
        val_73 = "buy";
        val_74 = this.丞一丁业丄一一业且;
        val_75 = this.丒世丘丘上丆丝东丞;
        goto label_48;
        label_18:
        if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() == 7)
        {
                Rilisoft.丞丛七上丕专丏丌丈.丗丒一且丛不丂三丆();
        }
        else
        {
                if((((this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 0) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 1)) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 4)) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 5))
        {
                if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 2)
        {
                if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 3)
        {
            goto label_65;
        }
        
        }
        
        }
        
            Rilisoft.丞丛七上丕专丏丌丈.丛与七三上万万丂不();
        }
        
        label_145:
        val_68 = null;
        if(this.丗业丕七且丝丆丝丘 == false)
        {
            goto label_68;
        }
        
        label_70:
        val_71 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        val_72 = this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且();
        val_73 = "upgrade";
        val_70 = "rarity";
        val_74 = this.丞一丁业丄一一业且;
        val_75 = this.丒世丘丘上丆丝东丞;
        label_48:
        label_138:
        PGCompany.Analytics.一业丗丆世世上丁且.一丁七丂且丁丗万丏(丆丛丑世下一丐且丕:  val_71, 七丆丒与丗丌丄且丂:  val_72, 丞一丁业丄一一业且:  val_74, 七丐丅专且专七三丆:  val_73, 万丐丏丐丒万不丟三:  val_75, 与上世丗丞丐万东丌:  val_70, 与丙丆世丘丑丒丌丄:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false}, 丞业丛世丛丘丝不丌:  false, 丈丄不七三万丄丁不:  0);
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且())) != true)
        {
                if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 8)
        {
            goto label_89;
        }
        
        }
        
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丝且与丝丒丟万丁专.buyUpgradeWear != 0)
        {
                UnityEngine.AudioSource val_41 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专.buyUpgradeWear);
        }
        
        }
        
        }
        
        label_89:
        if(((ShopNGUIController.丛世丛与丌不丈丐丐() != false) && (this.不丟丞丑丛丆丁东与 != true)) && ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且())) != false))
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丝且与丝丒丟万丁专.buyButton.GetComponent<UIPlaySound>().Play();
        }
        
        }
        
        val_76 = 1152921504848912384;
        if((ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0) || (ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false))
        {
            goto label_112;
        }
        
        丙且上东下丏丏丟下 val_50 = null;
        val_77 = val_50;
        val_50 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  mem[1152921539134300192]);
        val_78 = null;
        val_76 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        goto label_130;
        label_112:
        if(((this.丝且与丝丒丟万丁专.上三不丑业七不万上 == 0) || (this.丝且与丝丒丟万丁专.上三不丑业七不万上.gameObject == 0)) || (this.丝且与丝丒丟万丁专.上三不丑业七不万上.gameObject.activeInHierarchy == false))
        {
            goto label_127;
        }
        
        丙且上东下丏丏丟下 val_56 = null;
        val_77 = val_56;
        val_56 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  mem[1152921539134300192]);
        val_78 = null;
        val_76 = this.丝且与丝丒丟万丁专.上三不丑业七不万上;
        label_130:
        val_76.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_56, 丁业丗丈丂七丟东与:  (~ShopNGUIController.丛世丛与丌不丈丐丐()) & 1, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
        label_127:
        if(mem[1152921539134300232] == 0)
        {
                return;
        }
        
        mem[1152921539134300232].Invoke();
        return;
        label_68:
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_59 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        CategoryNames val_60 = this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且();
        bool val_61 = 丞业丛世丛丘丝不丌;
        goto label_138;
        label_65:
        if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 12500)
        {
                if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 13000)
        {
            goto label_145;
        }
        
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.丈丂丛与东业丂丑万();
        goto label_145;
    }

}
