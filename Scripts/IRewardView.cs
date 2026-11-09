using UnityEngine;
public class IRewardView : PGBehaviour
{
    // Fields
    private UIBasicSprite texture;
    private UIBasicSprite icon;
    private UILabel nameLabel;
    private UILabel descriptionLabel;
    private UILabel countOrSecondsLabel;
    private PGCompany.与丏丛丏丏丞丐丌丙 丁三丆上丆丗丒且丏;
    
    // Properties
    public PGCompany.与丏丛丏丏丞丐丌丙 与丑丝与业丐丟丏丁 { get; }
    
    // Methods
    public PGCompany.与丏丛丏丏丞丐丌丙 get_Reward()
    {
        return (PGCompany.与丏丛丏丏丞丐丌丙)this.丁三丆上丆丗丒且丏;
    }
    public void Setup(PGCompany.与丏丛丏丏丞丐丌丙 丗七丟丈三不丕一三)
    {
        this.丁三丆上丆丗丒且丏 = 丗七丟丈三不丕一三;
        this.UpdateView();
    }
    public void UpdateView()
    {
        var val_11 = 0;
        val_11 = val_11 + 1;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  this.丁三丆上丆丗丒且丏.丑东丐下专丞丕丘世());
        var val_12 = 0;
        val_12 = val_12 + 1;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.icon, 与万丆丛丒万丝丙丑:  this.丁三丆上丆丗丒且丏.三丗一丄不丆不丏三());
        var val_13 = 0;
        val_13 = val_13 + 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  this.丁三丆上丆丗丒且丏.七业丑不七丐业丟丂());
        var val_14 = 0;
        val_14 = val_14 + 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  this.丁三丆上丆丗丒且丏.东且丏丆万与东丙万());
        var val_15 = 0;
        val_15 = val_15 + 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countOrSecondsLabel, 丕丗丘丑丛与丑业丒:  this.丁三丆上丆丗丒且丏.不丑不与丟丛丏丘丅());
    }
    public IRewardView()
    {
    
    }

}
