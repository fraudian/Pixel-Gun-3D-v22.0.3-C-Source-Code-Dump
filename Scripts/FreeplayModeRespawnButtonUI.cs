using UnityEngine;
internal sealed class FreeplayModeRespawnButtonUI : PGBehaviour
{
    // Fields
    private UIButton _uiButton;
    private UILabel _locationLabel;
    
    // Methods
    internal void 丘上丐世丆丑且丞丒(EventDelegate 三丛丟东丑丌丄东丂)
    {
        this._uiButton.onClick.Clear();
        this._uiButton.onClick.Add(item:  三丛丟东丑丌丄东丂);
    }
    internal void 万一且丐丝丙一丑万(string 业业万丆七丗不丁万)
    {
        this._locationLabel.text = 业业万丆七丗不丁万;
    }
    public FreeplayModeRespawnButtonUI()
    {
    
    }

}
