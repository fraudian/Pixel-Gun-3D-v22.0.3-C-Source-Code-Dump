using UnityEngine;
public class InGameGUIpart_TimeBattle : InGameGUIPartContainer
{
    // Fields
    public UnityEngine.AudioClip avalibleWeaponCategoryClip;
    public UnityEngine.GameObject avalibleWeaponCategoryContainer;
    public UITexture avalibleWeaponCategoryTexture;
    public UnityEngine.Texture2D[] weaponCategoryTextures;
    public UILabel avalibleWeaponCategoryLabel;
    private int 丝万丟与丌东丑丈专;
    private float 丛丑丙三丘丘不丈丝;
    
    // Methods
    private void 丝丛丞万业丂丘下丟()
    {
        UnityEngine.GameObject val_13;
        UnityEngine.GameObject val_14;
        int val_15;
        var val_16;
        val_13 = this;
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        val_14 = 1152921505167814656;
        if(ZombiManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_8;
        }
        
        val_15 = mem[ZombiManager.丟丗丄业丘丗业丗七 + 32];
        val_15 = ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory;
        if(val_15 == 1)
        {
            goto label_8;
        }
        
        if(val_15 == this.丝万丟与丌东丑丈专)
        {
            goto label_33;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.avalibleWeaponCategoryClip);
        }
        
        this.丛丑丙三丘丘不丈丝 = 5f;
        val_16 = null;
        val_16 = null;
        if((上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.TryGetValue(key:  val_15, value: out  0)) != true)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Debug.LogError(message:  "Couldnot find weapon name for " + val_15.ToString());
        }
        
        this.avalibleWeaponCategoryLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15.ToString().Replace(oldValue:  "Category", newValue:  System.String.alignConst));
        UnityEngine.Texture2D val_13 = this.weaponCategoryTextures[(long)val_15];
        val_14 = this.avalibleWeaponCategoryContainer;
        val_14.SetActive(value:  true);
        goto label_33;
        label_8:
        val_15 = 0;
        label_33:
        this.丝万丟与丌东丑丈专 = val_15;
        if(this.丛丑丙三丘丘不丈丝 <= 0f)
        {
                return;
        }
        
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = this.丛丑丙三丘丘不丈丝 - val_12;
        this.丛丑丙三丘丘不丈丝 = val_12;
        if(val_12 >= 0)
        {
                return;
        }
        
        val_13 = this.avalibleWeaponCategoryContainer;
        val_13.SetActive(value:  false);
    }
    private void Update()
    {
        this.丝丛丞万业丂丘下丟();
    }
    public InGameGUIpart_TimeBattle()
    {
        this.丝万丟与丌东丑丈专 = 0;
        this.丛丑丙三丘丘不丈丝 = -1.007812f;
    }

}
