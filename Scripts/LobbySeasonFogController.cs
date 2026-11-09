using UnityEngine;
internal sealed class LobbySeasonFogController : PGBehaviour
{
    // Fields
    private UnityEngine.Color _ambientColor;
    private Rilisoft.FogSettings _fog;
    
    // Methods
    private void OnEnable()
    {
        this.丏世与丅东三丆丛丂();
    }
    internal void 丏世与丅东三丆丛丂()
    {
        PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this._ambientColor});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this._fog.Active);
        PGCompany.丟丝世世且丗丈丈丞.下丐专且三丄下丘下(丙业与丙丗丝不丈东:  this._fog.Mode);
        PGCompany.丟丝世世且丗丈丈丞.丌三上丂不丝一丄丑(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this._fog.Color});
        PGCompany.丟丝世世且丗丈丈丞.丁专丒东丆丏丏丛丗(丙业与丙丗丝不丈东:  this._fog.Start);
        PGCompany.丟丝世世且丗丈丈丞.东不一丛丟东丆不七(丙业与丙丗丝不丈东:  this._fog.End);
    }
    public LobbySeasonFogController()
    {
    
    }

}
