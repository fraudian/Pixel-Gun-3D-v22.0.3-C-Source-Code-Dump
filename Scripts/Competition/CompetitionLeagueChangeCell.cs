using UnityEngine;

namespace Competition
{
    internal sealed class CompetitionLeagueChangeCell : PGBehaviour
    {
        // Fields
        private UILabel _changeLeagueTextLabel;
        private UILabel _scoreLabel;
        private UnityEngine.GameObject _arrowDownObject;
        private UnityEngine.GameObject _arrowUpObject;
        private UISprite _leagueSprite;
        private System.Collections.Generic.List<UISprite> _gradientSprite;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(RatingSystem.RatingLeague 丞丄丕专三丁丙一上, RatingSystem.RatingLeague 丘下下万丙丙丐万丁, int 丝不一丘与丞东丏丛)
        {
            System.Collections.Generic.List<UISprite> val_8;
            string val_9;
            if(丞丄丕专三丁丙一上 > 丘下下万丙丙丐万丁)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._changeLeagueTextLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11603"));
                val_8 = this._gradientSprite;
                val_9 = "CompetitionLeaderboards/league_down";
            }
            else
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._changeLeagueTextLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11602"));
                val_8 = this._gradientSprite;
                val_9 = "CompetitionLeaderboards/league_up";
            }
            
            UnityEngine.Color val_3 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_9);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丄丁一丐丕与丝一丈:  val_8, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._arrowDownObject, 丏业丟一东丂东丘丛:  (丞丄丕专三丁丙一上 > 丘下下万丙丙丐万丁) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._arrowUpObject, 丏业丟一东丂东丘丛:  (丞丄丕专三丁丙一上 <= 丘下下万丙丙丐万丁) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._scoreLabel, 丕丗丘丑丛与丑业丒:  丝不一丘与丞东丏丛);
            this._leagueSprite.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  丘下下万丙丙丐万丁 + 1);
        }
        public CompetitionLeagueChangeCell()
        {
        
        }
    
    }

}
