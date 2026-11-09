using UnityEngine;
internal sealed class SPViewComonentAdvertPromotion : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject disableIfCooldown;
    private PGCompany.InventoryItemView itemView;
    private UnityEngine.GameObject rewardName;
    private UITextureMasked textureItemNovice;
    private UnityEngine.GameObject bgNovice;
    private UnityEngine.GameObject borderOutNovice;
    private UnityEngine.GameObject glowNovice;
    private UnityEngine.GameObject rewardLabel;
    private UnityEngine.GameObject textureItem;
    private UnityEngine.GameObject bg;
    private UnityEngine.GameObject borderOut;
    private UnityEngine.GameObject glow;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UnityEngine.GameObject val_16;
        string val_17;
        PGCompany.三东丏不丗世丅丌丄 val_4 = 0;
        if(且丘丏丁丑与丙与丁 == null)
        {
            goto label_1;
        }
        
        val_16 = 且丘丏丁丑与丙与丁.丝丒丙一丙丄不三丞();
        val_17 = "Advert";
        if((val_16.Equals(value:  val_17)) == false)
        {
            goto label_27;
        }
        
        val_16 = PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世();
        if((val_16.丕不一东下丅丒业丏(丙业与丙丗丝不丈东: out  val_4, 丏丞专丏业丗丝七丝: out  0)) == false)
        {
            goto label_7;
        }
        
        if(val_4.不业丙丒丂丞下丆丙() != 10)
        {
            goto label_14;
        }
        
        val_16 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
        val_17 = val_4.业东丅东丌上丗丑不();
        if((val_16.专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_17)) == null)
        {
            goto label_14;
        }
        
        label_7:
        this.丕专与万丌丝丒不丏();
        goto label_27;
        label_1:
        label_27:
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
        
        val_16 = 且丘丏丁丑与丙与丁;
        if(val_16.业东丅东丌上丗丑不() != 17015)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableIfCooldown, 丏业丟一东丂东丘丛:  true);
        val_16 = 且丘丏丁丑与丙与丁.上丟丄与丁三丌丘专();
        if(且丘丏丁丑与丙与丁.上丟丄与丁三丌丘专() >= 1)
        {
                if((val_16 - PixelTime.丝丗专上三不丄丑丑()) >= 1)
        {
                val_16 = this.disableIfCooldown;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_16, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        mem[1152921539219295832] = 且丘丏丁丑与丙与丁;
        return;
        label_14:
        this.七东丙丝丙一万丒万(丈丄不七三万丄丁不:  val_4);
        goto label_27;
    }
    private void 七东丙丝丙一万丒万(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        if(丈丄不七三万丄丁不.丂丁丏一丙丛业且丌() < 1)
        {
                return;
        }
        
        if(this.itemView == 0)
        {
                return;
        }
        
        this.rewardName.SetActive(value:  true);
        this.bgNovice.SetActive(value:  true);
        this.borderOutNovice.SetActive(value:  true);
        this.glowNovice.SetActive(value:  true);
        this.textureItemNovice.enabled = true;
        this.rewardLabel.SetActive(value:  false);
        this.bg.SetActive(value:  false);
        this.borderOut.SetActive(value:  false);
        this.glow.SetActive(value:  false);
        this.textureItem.SetActive(value:  false);
        this.itemView.enabled = true;
        this.itemView.Setup(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
    }
    private void 丕专与万丌丝丒不丏()
    {
        this.itemView.enabled = false;
        this.rewardName.SetActive(value:  false);
        this.bgNovice.SetActive(value:  false);
        this.borderOutNovice.SetActive(value:  false);
        this.glowNovice.SetActive(value:  false);
        this.textureItemNovice.enabled = false;
        this.rewardLabel.SetActive(value:  true);
        this.bg.SetActive(value:  true);
        this.borderOut.SetActive(value:  true);
        this.glow.SetActive(value:  true);
        this.textureItem.SetActive(value:  true);
    }
    public SPViewComonentAdvertPromotion()
    {
        val_1 = new PGBehaviour();
    }

}
