using UnityEngine;
internal class SocialProgressView : ProgressViewBase
{
    // Fields
    private UILabel[] _nickname;
    private UILabel[] _clanName;
    private UILabel[] _friendsCount;
    private UILabel[] _userIdLabels;
    private UITexture _clanLogo;
    private UITexture _skin;
    private UnityEngine.GameObject _clanLogoFrame;
    
    // Methods
    protected override void 丕万丕丟丛不上丑七(Progress.业丝与丁丞丑不世丙 一丐丗丁丞丆丅丟丄)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nickname, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.丌专万丘丄丙丒丂丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._clanName, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.与丑丁万丈下七下丙);
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this._clanLogo, y:  0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._friendsCount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}: {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0073"), arg1:  一丐丗丁丞丆丅丟丄.丈业丟与丒丄东下丄));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._userIdLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "ID-{0}", arg0:  一丐丗丁丞丆丅丟丄.丕丙且丝不下丘丆丌));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanLogoFrame, 丏业丟一东丂东丘丛:  一丐丗丁丞丆丅丟丄.七且且且专丈丁丛丕);
        if(this._skin == 0)
        {
                return;
        }
        
        一丐丗丁丞丆丅丟丄 = 一丐丗丁丞丆丅丟丄.丞丑且丆三丙与世不;
    }
    public SocialProgressView()
    {
    
    }

}
