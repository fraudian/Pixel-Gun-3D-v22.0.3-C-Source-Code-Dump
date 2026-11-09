using UnityEngine;
private sealed class ShopNGUIController.丅丁丐丟下丌三丏世
{
    // Fields
    public System.Action<string> 丞丒业万东专上丒丛;
    public ShopNGUIController 丝且与丝丒丟万丁专;
    
    // Methods
    public ShopNGUIController.丅丁丐丟下丌三丏世()
    {
    
    }
    internal void 专丏一丙丙专丞下丟(string 世万丗不丘丙丆世万)
    {
        ShopNGUIController val_25;
        var val_26;
        string val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_25 = this;
        SkinEditorController.丄七丌丄专东东七丑(丙业与丙丗丝不丈东:  this.丞丒业万东专上丒丛);
        val_26 = null;
        val_26 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丐丞丛丗丈丐丆丂丛(丞下上且一上丙不丏:  SkinEditorController.丄丞丁丈与业上丞丟.gameObject.GetComponent<UnityEngine.AudioSource>());
        this.丝且与丝丒丟万丁专.mainPanel.SetActive(value:  true);
        this.丝且与丝丒丟万丁专.丘丈东丝丆丁丞丑与();
        if((世万丗不丘丙丆世万 == null) && (this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 9))
        {
                val_27 = 0;
        }
        else
        {
                if((System.String.op_Equality(a:  this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七(), b:  "CustomSkinID")) != false)
        {
                this.丝且与丝丒丟万丁专.丅东东万丘丝丅三世(丞丅上丏丂且下丅与:  世万丗不丘丙丆世万);
        }
        
            if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() == 8)
        {
                val_28 = null;
            val_28 = null;
            if((System.String.op_Equality(a:  this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七(), b:  SkinsController.丂下丅丑丗一不东丘)) != false)
        {
                this.丝且与丝丒丟万丁专.丟七丈丅丛丝丝丑丈(丞丅上丏丂且下丅与:  世万丗不丘丙丆世万);
        }
        
        }
        
            if((System.String.op_Equality(a:  this.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七(), b:  "cape_Custom")) != false)
        {
                this.丝且与丝丒丟万丁专.丌上丏丁下丞丐丏万().丗丂不丟七丐丈七业(丙业与丙丗丝不丈东:  true);
            if(PersConfigurator.下一丁七丅丕七万丑() != 0)
        {
                PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐().丗丂不丟七丐丈七业(丙业与丙丗丝不丈东:  true);
        }
        
            this.丝且与丝丒丟万丁专.三上丅丕上丈丐且丁(丒东业不丐丑丕丄丆:  "cape_Custom");
        }
        
            val_27 = 世万丗不丘丙丆世万;
        }
        
        this.丝且与丝丒丟万丁专.上丐世业丏丕丄丗丟(丏丟万且丝丒丝丅东:  val_27);
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                return;
        }
        
        if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 9)
        {
                val_31 = null;
            val_31 = null;
            if((UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.与丄丅丂丗下丄丑与, defaultValue:  0)) == 0)
        {
                this.丝且与丝丒丟万丁专.业且丌下七万丑丑丈 = true;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且() != 9)
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        if((UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丘万丒丌丒丞世丂东, defaultValue:  0)) != 0)
        {
                return;
        }
        
        val_25 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.万专丁丒丛与东七丁 = true;
    }

}
