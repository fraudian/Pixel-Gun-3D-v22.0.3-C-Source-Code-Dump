using UnityEngine;
internal class ClanWarRatingUI : PGBehaviour
{
    // Fields
    private UILabel clanNameLabel;
    private UITexture clanIcon;
    private UIWidget background;
    private UILabel clanRatingLabel;
    private int 与丛丑东万业上下万;
    private string 丌专万丝三七丅丈一;
    private int 丆丞下七丛上丐世丌;
    
    // Properties
    internal int 丁万且不丁丘上与丕 { get; set; }
    internal string 丄丌且丄东丟世丗丒 { get; set; }
    internal int 丂业丌业丂万三丛丄 { get; set; }
    
    // Methods
    internal int 东丙丕东三丙丝与丁()
    {
        return (int)this.与丛丑东万业上下万;
    }
    internal void 万东世丐丝丙丑下丑(int 丙业与丙丗丝不丈东)
    {
        this.与丛丑东万业上下万 = 丙业与丙丗丝不丈东;
        this.东丒不七丝万丌丄三();
    }
    internal string 丁丏业丄丏丞丟万且()
    {
        return (string)this.丌专万丝三七丅丈一;
    }
    internal void 丙丘下三丆丘下丐丙(string 丙业与丙丗丝不丈东)
    {
        this.丌专万丝三七丅丈一 = 丙业与丙丗丝不丈东;
        this.东丒不七丝万丌丄三();
    }
    internal int 丏三世七东丒万丕丅()
    {
        return (int)this.丆丞下七丛上丐世丌;
    }
    internal void 一七与丁丏丄不世丄(int 丙业与丙丗丝不丈东)
    {
        this.丆丞下七丛上丐世丌 = 丙业与丙丗丝不丈东;
        this.东丒不七丝万丌丄三();
    }
    internal void 丗丘丌世万丅丘丟丌(int 上丐不丂丝业业丑丄, string 丄丒下业一不丈丝丘, int 丈丐世下丞与丂专丏)
    {
        UnityEngine.Texture val_6;
        this.与丛丑东万业上下万 = PGCompany.丂丘丞丂丏七丁丄不.丗丘丕丟且下一东丏(丄丒下业一不丈丝丘:  丄丒下业一不丈丝丘);
        this.丌专万丝三七丅丈一 = 丄丒下业一不丈丝丘;
        this.丆丞下七丛上丐世丌 = 丈丐世下丞与丂专丏;
        丞丂丘丒丟丞丑下丄 val_4 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  丄丒下业一不丈丝丘);
        if(val_4 != null)
        {
                val_6 = val_4.世丐专丂世丄世丂丌();
        }
        else
        {
                val_6 = 0;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.clanIcon, 与万丆丛丒万丝丙丑:  val_6);
        this.东丒不七丝万丌丄三();
    }
    internal void 东丒不七丝万丌丄三()
    {
        this.clanNameLabel.text = this.与丛丑东万业上下万.ToString();
        this.clanRatingLabel.text = this.丆丞下七丛上丐世丌.ToString();
        UnityEngine.Color val_5 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "cw-tile-owned-{0}", arg0:  PGCompany.ClanWarProgressController.丆丕丝丒不丙且丐丗.丗丘丕丟且下一东丏(丄丒下业一不丈丝丘:  this.丌专万丝三七丅丈一)));
        this.background.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
    }
    public ClanWarRatingUI()
    {
    
    }

}
