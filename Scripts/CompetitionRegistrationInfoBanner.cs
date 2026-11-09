using UnityEngine;
public class CompetitionRegistrationInfoBanner : BannerWindowWithBack
{
    // Fields
    private UILabel _message;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.七专丒丛与丐七丄丐();
    }
    public override void Show()
    {
        this.Show();
        this.七专丒丛与丐七丄丐();
    }
    private void 七专丒丛与丐七丄丐()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.Singleton<TournamentController>.Instance.丞丁下丛丒一丈丌丑();
        System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  1.15292150460685E+18);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._message, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12514"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_3._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    public CompetitionRegistrationInfoBanner()
    {
    
    }

}
