using UnityEngine;
public class ProfileCup : MonoBehaviour
{
    // Fields
    private UISprite 丑万丒丒一东丗丈丗;
    public RatingSystem.RatingLeague League;
    public UnityEngine.GameObject Outline;
    public UnityEngine.GameObject LockedObject;
    private LeaguesGUIController 业专万丏丘丙丝一丕;
    private Rilisoft.UICenterOnPanelComponent 丄且七三且丄丄丂丒;
    
    // Properties
    public UISprite 一世丘丒丏专丂丄丆 { get; }
    
    // Methods
    public UISprite get_Cup()
    {
        if(this.丑万丒丒一东丗丈丗 != null)
        {
                return val_1;
        }
        
        UISprite val_1 = this.GetComponent<UISprite>();
        this.丑万丒丒一东丗丈丗 = val_1;
        return val_1;
    }
    private void Start()
    {
        this.业专万丏丘丙丝一丕 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<LeaguesGUIController>(丝三丁东丈丒世丅业:  this.gameObject);
        this.丄且七三且丄丄丂丒 = this.GetComponent<Rilisoft.UICenterOnPanelComponent>();
        val_3.OnCentered.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ProfileCup::不丐丐丐丝丆丈一丟()));
        this.丄且七三且丄丄丂丒.OnCentered.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ProfileCup::不丐丐丐丝丆丈一丟()));
    }
    private void 不丐丐丐丝丆丈一丟()
    {
        this.业专万丏丘丙丝一丕.CupCentered(丆上上三不丅丄丛丞:  this);
    }
    private void OnEnable()
    {
        this.Outline.SetActive(value:  (this.League == RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()) ? 1 : 0);
        this.LockedObject.SetActive(value:  (this.League > RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()) ? 1 : 0);
        RatingLeague val_9 = this.League;
        val_9 = val_9 + 1;
        this.Cup.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  val_9);
    }
    public ProfileCup()
    {
    
    }

}
