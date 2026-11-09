using UnityEngine;
internal class GameProgressView : ProgressViewBase
{
    // Fields
    private UILabel[] _leagueName;
    private UILabel[] _ratingCount;
    private UILabel[] _coinsCount;
    private UILabel[] _gemsCount;
    private UILabel[] _levelLabels;
    private UILabel[] _nickLabels;
    private UILabel[] _userIdLabels;
    private UISprite _leagueImage;
    private UITexture _skin;
    
    // Methods
    protected override void 丕万丕丟丛不上丑七(Progress.业丝与丁丞丑不世丙 一丐丗丁丞丆丅丟丄)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._leagueName, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.一业下丒丄一丘丛丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._ratingCount, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.业丞上丌丁丛丘丒丁.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._coinsCount, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丕丁丙与丙丝丞上丄.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._gemsCount, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丐世丑丈丟丏专专丝.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._levelLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5726"), arg0:  一丐丗丁丞丆丅丟丄.万丄丅丛下丐丒丞上));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nickLabels, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丌专万丘丄丙丒丂丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._userIdLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "ID-{0}", arg0:  一丐丗丁丞丆丅丟丄.丕丙且丝不下丘丆丌));
        if(this._leagueImage != 0)
        {
                this._leagueImage.spriteName = 一丐丗丁丞丆丅丟丄.丈丗下丕丑丐丆丑上;
        }
        
        if(this._skin == 0)
        {
                return;
        }
        
        一丐丗丁丞丆丅丟丄 = 一丐丗丁丞丆丅丟丄.丞丑且丆三丙与世不;
    }
    public GameProgressView()
    {
    
    }

}
