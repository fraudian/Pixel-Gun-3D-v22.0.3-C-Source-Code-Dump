using UnityEngine;
public class InGameGUIPart_TeamDuel : InGameGUIPartContainer
{
    // Fields
    public TeamDuelPlayerIcons teamDuelPlayerIcons;
    public TeamDuelPlayerIcon[] teamDuelRedPlayerIcons;
    public TeamDuelPlayerIcon[] teamDuelBluePlayerIcons;
    public UnityEngine.GameObject roundUI;
    public UISprite[] roundShields;
    public UILabel labelRoundScore;
    public UILabel labelRoundTime;
    public UILabel[] labelRound;
    public UnityEngine.GameObject stickers;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丂三丐一丂丄丄三丛 = this;
    }
    public InGameGUIPart_TeamDuel()
    {
    
    }

}
