using UnityEngine;
public sealed class LevelUpFeatureItem : MonoBehaviour
{
    // Fields
    public UISprite iconSprite;
    public UILabel headerLabel;
    public UILabel descriptionLabel;
    public UILabel descriptionTierLabel;
    
    // Methods
    internal void 上东与丛丞下丈专丈(LevelUpBanner.丝不丕丁且丅丟丘丛 丑专丙三丌一丗丕丙, bool 业万上丆丐丞且丒七)
    {
        var val_6;
        UILabel val_7;
        bool val_6 = 业万上丆丐丞且丒七;
        this.iconSprite.spriteName = 丑专丙三丌一丗丕丙.万丑丞一丝丌丐丒丘;
        this.headerLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丑专丙三丌一丗丕丙.丈丐丆丛上丕丌上世);
        this.descriptionTierLabel.gameObject.SetActive(value:  val_6);
        val_6 = (~val_6) & 1;
        this.descriptionLabel.gameObject.SetActive(value:  val_6);
        if((val_6 & 1) == 0)
        {
                val_6 = null;
            val_7 = this.descriptionTierLabel;
        }
        else
        {
                val_6 = null;
            val_7 = this.descriptionLabel;
        }
        
        val_7.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丑专丙三丌一丗丕丙.下一不一丁丟丄丑丒);
    }
    public LevelUpFeatureItem()
    {
    
    }

}
