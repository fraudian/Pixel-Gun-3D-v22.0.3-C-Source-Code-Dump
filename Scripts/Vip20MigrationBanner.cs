using UnityEngine;
internal sealed class Vip20MigrationBanner : BannerWindowWithBack
{
    // Fields
    private UILabel _oldCountLabel;
    private UILabel _newCountLabel;
    
    // Methods
    public override void Show()
    {
        this.Show();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._oldCountLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._newCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2002"), arg0:  PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丛业世不丗丕丒丐七().丂丁丏一丙丛业且丌()));
        PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丄丕丐丆丘丄丆丌七();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    public Vip20MigrationBanner()
    {
    
    }

}
