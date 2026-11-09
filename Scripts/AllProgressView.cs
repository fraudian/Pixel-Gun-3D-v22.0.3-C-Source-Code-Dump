using UnityEngine;
internal class AllProgressView : ProgressViewBase
{
    // Fields
    private UILabel[] _nickname;
    private UILabel[] _clanName;
    private UILabel[] _friendsCount;
    private UILabel[] _leagueName;
    private UILabel[] _ratingCount;
    private UILabel[] _coinsCount;
    private UILabel[] _gemsCount;
    private UILabel[] _levelLabels;
    private UILabel[] _userIdLabels;
    private UITexture _clanLogo;
    private UISprite _leagueImage;
    private UITexture _skin;
    private UnityEngine.GameObject _clanLogoFrame;
    private UnityEngine.GameObject _currencyContainer;
    private UnityEngine.GameObject _levelContainer;
    
    // Methods
    protected override void 丕万丕丟丛不上丑七(Progress.业丝与丁丞丑不世丙 一丐丗丁丞丆丅丟丄)
    {
        UnityEngine.GameObject val_13;
        UnityEngine.GameObject val_14;
        val_13 = this;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nickname, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丌专万丘丄丙丒丂丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._clanName, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.与丑丁万丈下七下丙);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._friendsCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}: {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0073"), arg1:  一丐丗丁丞丆丅丟丄.丈业丟与丒丄东下丄));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._leagueName, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.一业下丒丄一丘丛丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._ratingCount, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.业丞上丌丁丛丘丒丁.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._coinsCount, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丕丁丙与丙丝丞上丄.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._gemsCount, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丐世丑丈丟丏专专丝.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._levelLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5726"), arg0:  一丐丗丁丞丆丅丟丄.万丄丅丛下丐丒丞上));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._userIdLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "ID-{0}", arg0:  一丐丗丁丞丆丅丟丄.丕丙且丝不下丘丆丌));
        bool val_9 = UnityEngine.Object.op_Inequality(x:  this._clanLogo, y:  0);
        bool val_10 = UnityEngine.Object.op_Inequality(x:  this._skin, y:  0);
        if(this._leagueImage != 0)
        {
                this._leagueImage.spriteName = 一丐丗丁丞丆丅丟丄.丈丗下丕丑丐丆丑上;
        }
        
        val_14 = this._clanLogoFrame;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.七且且且专丈丁丛丕 == true) ? 1 : 0);
        if(一丐丗丁丞丆丅丟丄.七七丌丕下世东且丙 != false)
        {
                val_14 = this._levelContainer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  false);
        }
        
        if(一丐丗丁丞丆丅丟丄.丒东丂丅丁丂丙丛丅 == false)
        {
                return;
        }
        
        val_13 = this._currencyContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
    }
    public AllProgressView()
    {
    
    }

}
