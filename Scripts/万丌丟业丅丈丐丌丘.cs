using UnityEngine;
private sealed class InfoWindowController.万丌丟业丅丈丐丌丘 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    public string 丏东丙丙丈丘丐丝丄;
    public string 七世且丞丗丙与丝丅;
    public string 不三世丏丙丁与丑丒;
    public UnityEngine.Texture 三丒丒丝丘一世丈东;
    
    // Methods
    public InfoWindowController.万丌丟业丅丈丐丌丘(AchieveBox 不丌丗丂丆业丂丏世)
    {
        val_1 = new System.Object();
        mem[1152921538056322424] = 不丌丗丂丆业丂丏世;
    }
    public override void 一丌一丞世不下丄专()
    {
        Rilisoft.TextGroup val_28;
        string val_29;
        UISprite val_30;
        string val_31;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.七世且丞丗丙与丝丅)) == false)
        {
            goto label_3;
        }
        
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        val_2.vipTextLarge.gameObject.SetActive(value:  true);
        InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
        val_4.vipTextHeaderSmall.gameObject.SetActive(value:  false);
        InfoWindowController val_6 = InfoWindowController.丑七不且上丗丁一世();
        val_6.vipTextFoolterSmall.gameObject.SetActive(value:  false);
        InfoWindowController val_8 = InfoWindowController.丑七不且上丗丁一世();
        val_28 = val_8.vipTextLarge;
        val_29 = this.不三世丏丙丁与丑丒;
        if(val_28 != null)
        {
            goto label_32;
        }
        
        goto label_17;
        label_3:
        InfoWindowController val_9 = InfoWindowController.丑七不且上丗丁一世();
        val_9.vipTextLarge.gameObject.SetActive(value:  false);
        InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
        val_11.vipTextHeaderSmall.gameObject.SetActive(value:  true);
        InfoWindowController val_13 = InfoWindowController.丑七不且上丗丁一世();
        val_13.vipTextFoolterSmall.gameObject.SetActive(value:  true);
        InfoWindowController val_15 = InfoWindowController.丑七不且上丗丁一世();
        val_15.vipTextHeaderSmall.Text = this.不三世丏丙丁与丑丒;
        InfoWindowController val_16 = InfoWindowController.丑七不且上丗丁一世();
        val_28 = val_16.vipTextFoolterSmall;
        val_29 = this.七世且丞丗丙与丝丅;
        if(val_28 != null)
        {
            goto label_32;
        }
        
        label_17:
        label_32:
        val_28.Text = val_29;
        if(this.三丒丒丝丘一世丈东 != 0)
        {
                InfoWindowController val_18 = InfoWindowController.丑七不且上丗丁一世();
            val_18.vipTextureIcon.gameObject.SetActive(value:  true);
            InfoWindowController val_20 = InfoWindowController.丑七不且上丗丁一世();
            UnityEngine.GameObject val_21 = val_20.vipSpriteIcon.gameObject;
            val_21.SetActive(value:  false);
            val_21.丟不丏世丝丕与世丘(与万丆丛丒万丝丙丑:  this.三丒丒丝丘一世丈东);
            InfoWindowController val_22 = InfoWindowController.丑七不且上丗丁一世();
            val_30 = val_22.vipSpriteIcon;
            val_31 = System.String.alignConst;
        }
        else
        {
                InfoWindowController val_23 = InfoWindowController.丑七不且上丗丁一世();
            val_23.vipTextureIcon.gameObject.SetActive(value:  false);
            InfoWindowController val_25 = InfoWindowController.丑七不且上丗丁一世();
            UnityEngine.GameObject val_26 = val_25.vipSpriteIcon.gameObject;
            val_26.SetActive(value:  true);
            val_26.丟不丏世丝丕与世丘(与万丆丛丒万丝丙丑:  0);
            InfoWindowController val_27 = InfoWindowController.丑七不且上丗丁一世();
            val_30 = this.丏东丙丙丈丘丐丝丄;
            val_31 = val_30;
        }
        
        val_27.vipSpriteIcon.spriteName = val_31;
        this.一丌一丞世不下丄专();
    }
    private void 丟不丏世丝丕与世丘(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        var val_9;
        UIBasicSprite val_10;
        var val_11;
        UIBasicSprite val_12;
        if((与万丆丛丒万丝丙丑.name.Contains(value:  "icon1_big")) != false)
        {
                val_9 = InfoWindowController.丑七不且上丗丁一世();
            InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
            val_10 = val_4.vipTextureIcon;
            val_11 = 1;
            val_12 = val_10;
        }
        else
        {
                val_9 = InfoWindowController.丑七不且上丗丁一世();
            InfoWindowController val_6 = InfoWindowController.丑七不且上丗丁一世();
            val_10 = val_6.vipTextureIcon;
            val_12 = val_10;
            val_11 = 0;
        }
        
        if(val_9 != null)
        {
                val_5.vipTextureIcon = 丞东丑专丛丆丄丝世.上且丂一丌丛丝丕丝(与丄丈丘丟丕丏丐丁:  val_12, 丁丒丘丈上上丙丗三:  false);
            InfoWindowController val_8 = InfoWindowController.丑七不且上丗丁一世();
            if(val_8.vipTextureIcon != null)
        {
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        
        }
    
    }

}
