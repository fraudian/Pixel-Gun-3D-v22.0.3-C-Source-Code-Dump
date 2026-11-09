using UnityEngine;
internal sealed class ShareButtonMailbox : PGBehaviour
{
    // Fields
    private string 七丙不丅丛丘丗万与;
    private 专一东丂不丌不丛丏 _typeButton;
    
    // Methods
    internal void 丅丐丈丗丂丘丁丂丁(string 七丙不丅丛丘丗万与)
    {
        this.七丙不丅丛丘丗万与 = 七丙不丅丛丘丗万与;
    }
    public void OpenUrl()
    {
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  this._typeButton);
        UnityEngine.Application.OpenURL(url:  this.七丙不丅丛丘丗万与);
    }
    internal 专一东丂不丌不丛丏 丙丗丕丒下专专上丑()
    {
        return (专一东丂不丌不丛丏)this._typeButton;
    }
    public ShareButtonMailbox()
    {
        this._typeButton = 4;
        this.七丙不丅丛丘丗万与 = "https://youtube.com/";
    }

}
