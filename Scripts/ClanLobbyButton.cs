using UnityEngine;
public class ClanLobbyButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject chestAvailableIndicator;
    private UnityEngine.GameObject disabledButton;
    private UnityEngine.GameObject enabledButton;
    private UnityEngine.GameObject collectTributeButton;
    private UILabel levelRequiredLabel;
    private UILabel betaLabel;
    private UnityEngine.GameObject mailAvailableIndicator;
    private UITexture myClanLogo;
    private UnityEngine.GameObject newClanIndicator;
    private UnityEngine.GameObject tutorial;
    private UnityEngine.GameObject _newClanCraftItemsContainer;
    private UnityEngine.Coroutine 丙丗东丅丂丂丏丗丞;
    private readonly Rilisoft.丆专丐丂丆丐丕丝丒 下丗丈东丕丞丙丗丄;
    private UnityEngine.GameObject unlockAnimationObject;
    
    // Methods
    private void Awake()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newClanCraftItemsContainer, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        System.Action val_9;
        if(this.丙丗东丅丂丂丏丗丞 != null)
        {
                this.StopCoroutine(routine:  this.丙丗东丅丂丂丏丗丞);
            this.丙丗东丅丂丂丏丗丞 = 0;
        }
        
        if(与丂丅三丂且不不与.丑七不且上丗丁一世() != null)
        {
                与丂丅三丂且不不与.丑七不且上丗丁一世().丗七七丞世丆上丌丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::七专丌一丕丆世丟不()));
            val_9 = 与丂丅三丂且不不与.丑七不且上丗丁一世();
            val_9.丞丝三丑丘专丝丙丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::丟且丂丕三万丆三专()));
        }
        
        val_9 = new System.Action(object:  this, method:  System.Void ClanLobbyButton::丐丅专丗且丟丆丑七());
        ClansController.丒世丒业丙丟丌世上(丙业与丙丗丝不丈东:  val_9);
        this.丙丗东丅丂丂丏丗丞 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
    }
    private void 七专丌一丕丆世丟不()
    {
        this.丟专丂三丆丁丌丞丒();
    }
    private void 丟且丂丕三万丆三专()
    {
        var val_3;
        var val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tutorial, 丏业丟一东丂东丘丛:  false);
        val_3 = null;
        val_3 = null;
        ClansController.丑丏丛不丂丄上且丈 = false;
        val_4 = null;
        val_4 = null;
        if(ExperienceController.sharedController != 0)
        {
                if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) != false)
        {
                this.丄丏上七丐丅东丌丄();
            return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disabledButton, 丏业丟一东丂东丘丛:  true);
    }
    private void OnDisable()
    {
        if(this.丙丗东丅丂丂丏丗丞 != null)
        {
                this.StopCoroutine(routine:  this.丙丗东丅丂丂丏丗丞);
            this.丙丗东丅丂丂丏丗丞 = 0;
        }
        
        if(与丂丅三丂且不不与.丑七不且上丗丁一世() == null)
        {
                return;
        }
        
        与丂丅三丂且不不与.丑七不且上丗丁一世().丅丑丄丌丘业丌丛丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::七专丌一丕丆世丟不()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::丟且丂丕三万丆三专()));
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::丐丅专丗且丟丆丑七()));
    }
    private void 丐丅专丗且丟丆丑七()
    {
        this.丟专丂三丆丁丌丞丒();
    }
    private void 丟专丂三丆丁丌丞丒()
    {
        bool val_6;
        var val_7;
        var val_8;
        val_6 = this;
        val_7 = null;
        val_7 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) == false)
        {
                return;
        }
        
        bool val_3 = ClansTutorialController.上且世丘丝三丄丈丗();
        if(val_3 != false)
        {
                this.丄丏上七丐丅东丌丄();
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chestAvailableIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mailAvailableIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newClanIndicator, 丏业丟一东丂东丘丛:  false);
        }
        
        val_6 = val_3 ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tutorial, 丏业丟一东丂东丘丛:  val_6);
        val_8 = null;
        val_8 = null;
        ClansController.丑丏丛不丂丄上且丈 = val_6;
    }
    private void OnDestroy()
    {
        if(与丂丅三丂且不不与.丑七不且上丗丁一世() == null)
        {
                return;
        }
        
        与丂丅三丂且不不与.丑七不且上丗丁一世().丅丑丄丌丘业丌丛丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::七专丌一丕丆世丟不()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::丟且丂丕三万丆三专()));
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanLobbyButton::丐丅专丗且丟丆丑七()));
    }
    private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanLobbyButton.丕丕丒东丟丛丅且丂();
    }
    private void 丄丏上七丐丅东丌丄()
    {
        bool val_2 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专世东丌丑丐与与业();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enabledButton, 丏业丟一东丂东丘丛:  (~val_2) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.collectTributeButton, 丏业丟一东丂东丘丛:  val_2);
    }
    private void 丆丅丟丑丞丅丑上丁()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enabledButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.collectTributeButton, 丏业丟一东丂东丘丛:  false);
    }
    public ClanLobbyButton()
    {
        this.下丗丈东丕丞丙丗丄 = new Rilisoft.丆专丐丂丆丐丕丝丒(丟东丟丑丕丄丂丟丙:  "clan_button_show_animation_viewed");
    }

}
