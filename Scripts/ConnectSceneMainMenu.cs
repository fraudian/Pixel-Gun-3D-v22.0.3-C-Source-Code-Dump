using UnityEngine;
public class ConnectSceneMainMenu : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject goBtn;
    public UnityEngine.GameObject battleRoyalePlayMethodContainer;
    public UILabel rulesLabel;
    public DisableObjectFromTimer serverIsNotAvalible;
    public DisableObjectFromTimer accountBlockedLabel;
    public CategoryButtonsController categoryButtonsController;
    public BtnCategory deathmatchToggle;
    public BtnCategory teamFightToogle;
    public BtnCategory spleefToogle;
    public BtnCategory flagCaptureToogle;
    public BtnCategory capturePointsToogle;
    public BtnCategory freePlayToggle;
    public BtnCategory duelToggle;
    public BtnCategory deadlyToogle;
    public BtnCategory TeamDuelToggle;
    public BtnCategory competitionToggle;
    public BtnCategory battleRoyaleToggle;
    public BtnCategory armRaceToggle;
    public UnityEngine.Transform battlePassHolder;
    public UnityEngine.Transform pixelPassHolder;
    internal PGCompany.PixelPass.PixelPassTasksInConnectSceneUI 丗丛专七丈一下一丟;
    public BtnCategory[] modeButtonByLevel;
    public UILabel[] modeUnlockLabelByLevel;
    public BtnCategory modeButtonDuel;
    public UILabel modeDuelRatingNeedLabel;
    public UnityEngine.GameObject modeDuelRatingNeed;
    public UnityEngine.GameObject gameEventInfoObject;
    public Rilisoft.DoubleRewardConnectScene doubleRewardConnectScene;
    public Rilisoft.NeedSquadLevelConnectScene needSquadLevelConncectScene;
    internal MapHint mapHint;
    internal CategoryHint miniGameHint;
    
    // Methods
    public ConnectSceneMainMenu()
    {
    
    }

}
