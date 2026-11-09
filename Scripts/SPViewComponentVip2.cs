using UnityEngine;
internal sealed class SPViewComponentVip2 : SPViewComponentBase
{
    // Fields
    private UIBasicSprite mainTexture;
    private UILabel fightsCountLabel;
    private UILabel _discriptionLabel;
    private ItemListUI rewardsPerOneListUI;
    private UnityEngine.GameObject allRewardsHolder;
    private UnityEngine.GameObject allRewardsHolder_Parts;
    private ItemListUI allRewardsListUI;
    private ItemListUI allRewardsListUI_Part1;
    private ItemListUI allRewardsListUI_Part2;
    private SPViewComponentContentPrice oldPrice;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_18;
        System.Collections.Generic.IEnumerable<PGCompany.丗丅三丈丙丝上丞七> val_19;
        var val_20;
        if(且丘丏丁丑与丙与丁 != null)
        {
                var val_1 = (null == null) ? 且丘丏丁丑与丙与丁 : 0;
        }
        else
        {
                val_18 = 0;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_18 == 0)
        {
            goto label_4;
        }
        
        label_18:
        val_2.SetActive(value:  true);
        mem[1152921539235039128] = 且丘丏丁丑与丙与丁;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.mainTexture, 与万丆丛丒万丝丙丑:  且丘丏丁丑与丙与丁);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._discriptionLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10500"), arg0:  val_18.丛丑丆丗丟丁丌三丌()).Replace(oldValue:  "[7FFF00]", newValue:  ""));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.fightsCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10501"), arg0:  val_18.丛丑丆丗丟丁丌三丌()));
        if(this.rewardsPerOneListUI != null)
        {
                this.rewardsPerOneListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  65536);
        }
        
        if(this.allRewardsListUI != null)
        {
                this.allRewardsListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  65536);
        }
        
        float val_18 = (float)65536.Count;
        val_18 = val_18 * 0.5f;
        int val_11 = UnityEngine.Mathf.CeilToInt(f:  val_18);
        if(65536 == 0)
        {
            goto label_16;
        }
        
        val_19 = 65536.GetRange(index:  0, count:  val_11);
        val_20 = 65536.Count;
        goto label_17;
        label_3:
        if(val_18 != 0)
        {
            goto label_18;
        }
        
        label_4:
        val_2.SetActive(value:  false);
        return;
        label_16:
        val_19 = 65536.GetRange(index:  0, count:  val_11);
        val_20 = 65536.Count;
        label_17:
        if(this.allRewardsListUI_Part1 != null)
        {
                this.allRewardsListUI_Part1.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_19);
        }
        
        if(this.allRewardsListUI_Part2 != null)
        {
                this.allRewardsListUI_Part2.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  65536.GetRange(index:  val_11, count:  val_20 - val_11));
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allRewardsHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allRewardsHolder_Parts, 丏业丟一东丂东丘丛:  true);
    }
    public SPViewComponentVip2()
    {
        val_1 = new PGBehaviour();
    }

}
