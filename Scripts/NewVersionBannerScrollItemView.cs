using UnityEngine;
internal class NewVersionBannerScrollItemView : MonoBehaviour
{
    // Fields
    private string _defaultDescriptionKey;
    private string _defaultHeaderKey;
    private UnityEngine.Texture2D _defaultTexture;
    private UILabel _description;
    private UILabel _header;
    private UIBasicSprite _texture;
    
    // Properties
    private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
    
    // Methods
    private UIBasicSprite 丆下世世丟七专丞丒()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
        this._texture = val_1;
        return val_1;
    }
    public void SetChange(VersionChange 七与万丕丄万丞且三)
    {
        this._header.text = 七与万丕丄万丞且三.HeaderText;
        this._description.text = 七与万丕丄万丞且三.DescriptionText;
        UnityEngine.Texture2D val_4 = 七与万丕丄万丞且三.ImageTexture;
        if(this.丆下世世丟七专丞丒() == null)
        {
            
        }
    
    }
    public void ResetToDafault()
    {
        this._header.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._defaultHeaderKey);
        this._description.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._defaultDescriptionKey);
        if(this.丆下世世丟七专丞丒() == null)
        {
            
        }
    
    }
    public NewVersionBannerScrollItemView()
    {
    
    }

}
