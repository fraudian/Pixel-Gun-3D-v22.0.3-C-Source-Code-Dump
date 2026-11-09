using UnityEngine;
public sealed class LeagueIconWithBackground : PGBehaviour
{
    // Fields
    private UISprite _leagueIcon;
    private UISprite _background;
    private RatingSystem.RatingLeague <七丁丌且世丈丛丝丂>k__BackingField;
    
    // Properties
    internal RatingSystem.RatingLeague 专丂丗东丞七丐丙丑 { get; set; }
    
    // Methods
    internal RatingSystem.RatingLeague 丈三与世丟下丅丄专()
    {
        return (RatingLeague)this.<七丁丌且世丈丛丝丂>k__BackingField;
    }
    private void 与丈东下丟不丄丙世(RatingSystem.RatingLeague 丙业与丙丗丝不丈东)
    {
        this.<七丁丌且世丈丛丝丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        this.<七丁丌且世丈丛丝丂>k__BackingField = 丙丑七万丆万丆且丌;
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._leagueIcon, 万丑丞一丝丌丐丒丘:  System.String.Format(format:  "cup{0}_1", arg0:  丙丑七万丆万丆且丌 + 1));
    }
    public LeagueIconWithBackground()
    {
    
    }

}
