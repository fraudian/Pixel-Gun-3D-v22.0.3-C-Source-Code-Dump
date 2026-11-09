using UnityEngine;
public class SorryWeaponAndArmorBanner : BannerWindow
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 丙丒丅丑丏丒丗丅丑;
    private Rilisoft.丝丑丂丛万丐丈丘且 丄七且业丑丗丁与七;
    public UIWidget gemsContainer;
    public UIWidget goldContainer;
    public UILabel[] labelGemsCompensations;
    public UILabel[] labelGoldCompensations;
    public bool sorryArmorHatRemoved;
    public bool sorryGearRemoved;
    
    // Methods
    public override void Show()
    {
        var val_3;
        var val_4;
        if(this.sorryArmorHatRemoved == false)
        {
            goto label_0;
        }
        
        goto label_1;
        label_0:
        if(this.sorryGearRemoved == false)
        {
            goto label_2;
        }
        
        label_1:
        label_2:
        val_3 = 0;
        goto label_3;
        label_8:
        this.labelGoldCompensations[0].text = this.丄七且业丑丗丁与七.ToString();
        val_3 = 1;
        label_3:
        if(val_3 < this.labelGoldCompensations.Length)
        {
            goto label_8;
        }
        
        val_4 = 0;
        goto label_9;
        label_14:
        this.labelGemsCompensations[0].text = this.丙丒丅丑丏丒丗丅丑.ToString();
        val_4 = 1;
        label_9:
        if(val_4 < this.labelGemsCompensations.Length)
        {
            goto label_14;
        }
        
        this.丈且业丙丆丁业业三();
        this.Show();
    }
    private void 丈且业丙丆丁业业三()
    {
        var val_15;
        var val_16;
        var val_17;
        val_15 = this;
        if(this.丄七且业丑丗丁与七 >= 1)
        {
                if(this.丙丒丅丑丏丒丗丅丑 == 0)
        {
            goto label_1;
        }
        
        }
        
        if(this.丄七且业丑丗丁与七 == 0)
        {
            goto label_2;
        }
        
        label_15:
        if(this.丄七且业丑丗丁与七 < 1)
        {
                return;
        }
        
        if(this.丙丒丅丑丏丒丗丅丑 < 1)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.goldContainer.transform.localPosition;
        int val_4 = this.goldContainer.height;
        var val_5 = (val_4 < 0) ? (val_4 + 1) : (val_4);
        val_5 = val_5 >> 1;
        val_2.y = val_2.y - (float)val_5;
        this.goldContainer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_7 = this.gemsContainer.transform.localPosition;
        val_15 = this.gemsContainer.transform;
        int val_9 = this.gemsContainer.height;
        var val_10 = (val_9 < 0) ? (val_9 + 1) : (val_9);
        val_10 = val_10 >> 1;
        val_7.y = val_7.y + (float)val_10;
        val_15.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_2:
        if(this.丙丒丅丑丏丒丗丅丑 < 1)
        {
            goto label_15;
        }
        
        this.goldContainer.gameObject.SetActive(value:  false);
        val_16 = this.gemsContainer.gameObject;
        val_17 = 1;
        goto label_20;
        label_1:
        this.goldContainer.gameObject.SetActive(value:  true);
        val_16 = this.gemsContainer.gameObject;
        val_17 = 0;
        label_20:
        val_16.SetActive(value:  false);
    }
    public void SorryWeaponAndArmorExitClick()
    {
        UnityEngine.Object val_10;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丟且丟上且七丞下不(), 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "coin_get");
        if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(val_10 != 0)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_10);
        }
        
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
    }
    public SorryWeaponAndArmorBanner()
    {
    
    }

}
