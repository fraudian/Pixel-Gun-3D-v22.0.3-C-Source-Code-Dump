using UnityEngine;
private sealed class ShopNGUIController.丁丂与丈东丑丟万上
{
    // Fields
    public PropertiesArmoryItemContainer 丘丐丝丟业丘丏东专;
    public bool 丙丆丞丞丒且丑丟丟;
    public bool 上东不丑丅东丟东丆;
    public bool 丂与一东丟丁一七丆;
    public bool 东丈丒三丞与业世一;
    public bool 丅丈下丏世丌且丂万;
    public 丙且上东下丏丏丟下 万丞丁不丏丌七专万;
    public string 丆三丝丝一丕与丝丆;
    public ShopNGUIController 丝且与丝丒丟万丁专;
    
    // Methods
    public ShopNGUIController.丁丂与丈东丑丟万上()
    {
    
    }
    internal void 丁万丂一丛上一丑丕()
    {
        var val_15;
        var val_16;
        val_15 = this;
        val_16 = 1152921504848912384;
        if(this.丘丐丝丟业丘丏东专.price != 0)
        {
                this.丘丐丝丟业丘丏东专.price.SetSpeedUpFlag(丂世丞专丌丐丄丗三:  (this.丙丆丞丞丒且丑丟丟 == true) ? 1 : 0);
        }
        
        if(this.丘丐丝丟业丘丏东专.price == 0)
        {
                return;
        }
        
        if(this.丘丐丝丟业丘丏东专.price.priceLabel != 0)
        {
                if(this.上东不丑丅东丟东丆 != false)
        {
                val_16 = 0;
        }
        else
        {
                bool val_14 = this.丂与一东丟丁一七丆;
            val_14 = val_14 ^ 1;
            val_16 = val_14 & 255;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丘丐丝丟业丘丏东专.price.priceLabel.gameObject, 丏业丟一东丂东丘丛:  (val_16 == true) ? 1 : 0);
        }
        
        if(this.东丈丒三丞与业世一 == false)
        {
            goto label_23;
        }
        
        label_32:
        val_16 = ((this.东丈丒三丞与业世一 == true) ? 1 : 0) & ((this.丙丆丞丞丒且丑丟丟 == true) ? 1 : 0);
        UnityEngine.GameObject val_9 = this.丘丐丝丟业丘丏东专.price.gameObject;
        if(val_16 == 0)
        {
            goto label_26;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        goto label_29;
        label_26:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
        return;
        label_23:
        bool val_15 = this.丂与一东丟丁一七丆;
        val_15 = this.丅丈下丏世丌且丂万 | val_15;
        val_15 = val_15 | this.丙丆丞丞丒且丑丟丟;
        val_15 = val_15 & 255;
        if(val_15 == false)
        {
            goto label_32;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丘丐丝丟业丘丏东专.price.gameObject, 丏业丟一东丂东丘丛:  true);
        if(this.丙丆丞丞丒且丑丟丟 == false)
        {
            goto label_37;
        }
        
        label_29:
        val_15 = this.丘丐丝丟业丘丏东专.speedUpButton.GetComponent<SpeedUpButtonControl>();
        val_11.shopItem = this.万丞丁不丏丌七专万;
        return;
        label_37:
        this.丘丐丝丟业丘丏东专.price.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  this.万丞丁不丏丌七专万.丒万丕七专不丏丞丌(), 丞一丁业丄一一业且:  this.丆三丝丝一丕与丝丆, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false));
    }
    internal bool 丏丕一丆丘下且三东(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)
    {
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝 == null)
        {
                return false;
        }
        
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
        {
                return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.丆三丝丝一丕与丝丆);
        }
        
        return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 丑丐七丏上丟七丘且(Rilisoft.OfferItem 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑.Type != 1340)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 丑七丝与丅丞上七东(Rilisoft.OfferItem 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑.Type != 1310)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 丅丄且丆下丆丒不丆(Rilisoft.OfferItem 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑.Type != 10)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 丙丒丄丅七七丂七丆(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)
    {
        if(与丘东下丈东丛丂万 == null)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  this.丆三丝丝一丕与丝丆, b:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛());
    }
    internal bool 丄丕一东且且丗丕丒(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌)
    {
        if((System.String.op_Equality(a:  丏丛与丅丛丌万专丌.下丄丈不与世丐业专, b:  this.丆三丝丝一丕与丝丆)) != false)
        {
                return true;
        }
        
        if(丏丛与丅丛丌万专丌.丝丈不丗丐不丙丟丁 != null)
        {
                return 丏丛与丅丛丌万专丌.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.丆三丝丝一丕与丝丆);
        }
        
        return 丏丛与丅丛丌万专丌.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 不世丌七上丅丟且万(Rilisoft.OfferItem 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑.Type != 1310)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 丞世与下丞万一丑丑(Rilisoft.OfferItem 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑.Type != 1340)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  this.丆三丝丝一丕与丝丆);
    }
    internal bool 丘世丁万世丒丒丑与(System.Collections.Generic.KeyValuePair<string, 丛且专丞丗丆丙丒万> 丈丏万丄丒业丅丒一)
    {
        return (bool)System.String.op_Equality(a:  丈丏万丄丒业丅丒一.Value.丐丏七丌丕丗业且上(), b:  this.万丞丁不丏丌七专万.业上丙丞丐丄丆丅七());
    }
    internal void 七不专丐丂且丐丙不()
    {
        this.丝且与丝丒丟万丁专.丙丑丘业丕丗丗不丘();
        ArmoryInfoScreenController val_1 = this.丘丐丝丟业丘丏东专.GetComponent<ArmoryInfoScreenController>();
        if(val_1 == null)
        {
                return;
        }
        
        val_1.Close();
    }

}
