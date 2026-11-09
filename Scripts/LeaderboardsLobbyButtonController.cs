using UnityEngine;
public class LeaderboardsLobbyButtonController : MonoBehaviour
{
    // Fields
    private UIButton button;
    private UISprite gunSprite;
    private UISprite leagueSprite;
    private UILabel placeLabel;
    private UILabel ratingLabel;
    private UnityEngine.GameObject rewardIndicatorObj;
    private UnityEngine.Animator animator;
    private const string 丙与丑丅丐下丏业丌 = "cup{0}_lobby";
    private const string 丅丈与丙丅一不东丙 = "cup{0}_lobby_gun";
    private int 丝丞丄丘丐丞且丝丈;
    private int 丈丑不丏不丝世业丙;
    private int 丌与丗业丝丅世丘一;
    private int 丄三不丒业丘丞丁丞;
    private int 且丝丑七七专下且丑;
    private RatingSystem.RatingLeague 丙丑七万丆万丆且丌;
    private int 丆七下丒上丈丒业世;
    private int 丈丐世下丞与丂专丏;
    private float 丐七不丏丈七丈丂丟;
    
    // Methods
    private void 丌丄丝丑丝丒丁下世(RatingSystem.RatingLeague 上丗业丂丑三丏上丏)
    {
        RatingLeague val_1 = 上丗业丂丑三丏上丏 + 1;
        this.leagueSprite.spriteName = System.String.Format(format:  "cup{0}_lobby", arg0:  val_1);
        this.button.normalSprite = System.String.Format(format:  "cup{0}_lobby", arg0:  val_1);
        this.gunSprite.spriteName = System.String.Format(format:  "cup{0}_lobby_gun", arg0:  val_1);
    }
    private void 丏丕三与丈世且专万(int 与万丏业丞丌三专丌)
    {
        this.placeLabel.text = 与万丏业丞丌三专丌.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.placeLabel, 丏业丟一东丂东丘丛:  (与万丏业丞丌三专丌 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.gunSprite, 丏业丟一东丂东丘丛:  (与万丏业丞丌三专丌 < 1) ? 1 : 0);
    }
    private void OnEnable()
    {
        RatingLeague val_31;
        int val_32;
        int val_33;
        var val_34;
        Progress.七上上丟丗丏一不与.上且丏且七丒专丘丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsLobbyButtonController::专不丁丁上丒三三丙()));
        Progress.七上上丟丗丏一不与.丂丐上丝丞丙万丟且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsLobbyButtonController::丘丘下丈丘丂下且三()));
        this.丐七不丏丈七丈丂丟 = UnityEngine.Time.realtimeSinceStartup;
        if((Rilisoft.Singleton<TournamentController>.Instance) == 0)
        {
                return;
        }
        
        if(TournamentController.不专丟丁下丈丕丑三() != false)
        {
                if(TournamentController.世丆丐且上丁丝丏丛() != RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏())
        {
            goto label_14;
        }
        
        }
        
        RatingLeague val_11 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        this.丙丑七万丆万丆且丌 = val_11;
        TournamentController.丁丟丂七与丏丛丐丄(丙业与丙丗丝不丈东:  val_11);
        val_31 = this.丙丑七万丆万丆且丌;
        goto label_20;
        label_14:
        val_31 = TournamentController.世丆丐且上丁丝丏丛();
        this.丙丑七万丆万丆且丌 = val_31;
        label_20:
        this.丌丄丝丑丝丒丁下世(上丗业丂丑三丏上丏:  val_31);
        if(TournamentController.不专丟丁下丈丕丑三() != false)
        {
                if(TournamentController.丅下丈丙丝丛业丘三() != (Rilisoft.Singleton<TournamentController>.Instance.下丐丕东七丞丅丙丝()))
        {
            goto label_29;
        }
        
        }
        
        bool val_18 = Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙();
        TournamentController val_19 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_19 == null)
        {
            goto label_31;
        }
        
        if(val_18 == false)
        {
            goto label_32;
        }
        
        label_35:
        TournamentReward val_20 = val_19.丄万丐丑丌三丆丝丑();
        val_32 = val_20.resultPlace;
        goto label_34;
        label_31:
        if(val_18 == true)
        {
            goto label_35;
        }
        
        label_32:
        val_32 = val_19.下丐丕东七丞丅丙丝();
        label_34:
        this.丆七下丒上丈丒业世 = val_32;
        TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  val_32);
        val_33 = this.丆七下丒上丈丒业世;
        goto label_38;
        label_29:
        if((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != false)
        {
                TournamentReward val_25 = Rilisoft.Singleton<TournamentController>.Instance.丄万丐丑丌三丆丝丑();
            val_33 = val_25.resultPlace;
        }
        else
        {
                val_33 = TournamentController.丅下丈丙丝丛业丘三();
        }
        
        this.丆七下丒上丈丒业世 = val_33;
        label_38:
        this.丏丕三与丈世且专万(与万丏业丞丌三专丌:  val_33);
        if((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != false)
        {
                val_34 = Progress.七上上丟丗丏一不与.丑丈丌三丘丐上丕丐();
        }
        else
        {
                val_34 = 0;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.rewardIndicatorObj, 丏业丟一东丂东丘丛:  false);
        this.丛丑专丂专丐七上七();
    }
    private void OnDisable()
    {
        Progress.七上上丟丗丏一不与.世上丗世且丆不业一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsLobbyButtonController::专不丁丁上丒三三丙()));
        Progress.七上上丟丗丏一不与.且丘丝丈业且丗丑丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsLobbyButtonController::丘丘下丈丘丂下且三()));
    }
    private void OnDestroy()
    {
        Progress.七上上丟丗丏一不与.世上丗世且丆不业一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsLobbyButtonController::专不丁丁上丒三三丙()));
        Progress.七上上丟丗丏一不与.且丘丝丈业且丗丑丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsLobbyButtonController::丘丘下丈丘丂下且三()));
    }
    private void 丘丘下丈丘丂下且三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardIndicatorObj, 丏业丟一东丂东丘丛:  false);
    }
    private void 专不丁丁上丒三三丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardIndicatorObj, 丏业丟一东丂东丘丛:  Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙());
    }
    private void Update()
    {
        var val_22;
        var val_23;
        var val_24;
        int val_25;
        UnityEngine.Animator val_26;
        int val_27;
        if((Rilisoft.Singleton<TournamentController>.Instance) == 0)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.realtimeSinceStartup;
        val_3 = val_3 - this.丐七不丏丈七丈丂丟;
        if(val_3 < 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.丌世世万不上丝丆三() == false)
        {
                return;
        }
        
        RatingLeague val_6 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        if(this.丙丑七万丆万丆且丌 == val_6)
        {
                val_23 = 0;
        }
        else
        {
                if(this.丙丑七万丆万丆且丌 != 1)
        {
                this.animator.SetTrigger(id:  this.丄三不丒业丘丞丁丞);
            val_23 = 1;
        }
        else
        {
                val_23 = 0;
        }
        
            this.丙丑七万丆万丆且丌 = val_6;
            TournamentController.丁丟丂七与丏丛丐丄(丙业与丙丗丝不丈东:  val_6);
        }
        
        if((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != false)
        {
                val_24 = Progress.七上上丟丗丏一不与.丑丈丌三丘丐上丕丐();
        }
        else
        {
                val_24 = 0;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.rewardIndicatorObj, 丏业丟一东丂东丘丛:  false);
        this.animator.SetBool(id:  this.且丝丑七七专下且丑, value:  false);
        if(((Rilisoft.Singleton<TournamentController>.Instance) != 0) && ((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != false))
        {
                TournamentReward val_15 = Rilisoft.Singleton<TournamentController>.Instance.丄万丐丑丌三丆丝丑();
            val_25 = val_15.resultPlace;
        }
        else
        {
                if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                val_25 = Rilisoft.Singleton<TournamentController>.Instance.下丐丕东七丞丅丙丝();
        }
        else
        {
                val_25 = 1;
        }
        
        }
        
        if(this.丆七下丒上丈丒业世 == val_25)
        {
            goto label_40;
        }
        
        var val_20 = (val_24 != 0) ? 1 : 0;
        val_20 = val_23 | val_20;
        if(((val_20 & 1) != 0) || (val_25 < 1))
        {
            goto label_42;
        }
        
        if(this.丆七下丒上丈丒业世 == 0)
        {
            goto label_43;
        }
        
        if(val_25 >= this.丆七下丒上丈丒业世)
        {
            goto label_44;
        }
        
        val_26 = this.animator;
        val_27 = this.丈丑不丏不丝世业丙;
        if(val_26 != null)
        {
            goto label_52;
        }
        
        goto label_53;
        label_42:
        this.丏丕三与丈世且专万(与万丏业丞丌三专丌:  1);
        goto label_51;
        label_43:
        val_26 = this.animator;
        val_27 = this.丝丞丄丘丐丞且丝丈;
        if(val_26 != null)
        {
            goto label_52;
        }
        
        label_53:
        label_52:
        val_26.SetTrigger(id:  val_27);
        label_51:
        this.丆七下丒上丈丒业世 = val_25;
        TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  1);
        label_40:
        this.丛丑专丂专丐七上七();
        return;
        label_44:
        if(val_25 <= this.丆七下丒上丈丒业世)
        {
            goto label_51;
        }
        
        if(this.animator != null)
        {
            goto label_52;
        }
        
        goto label_53;
    }
    private void 丛丑专丂专丐七上七()
    {
        int val_2 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        if(this.丈丐世下丞与丂专丏 == val_2)
        {
                return;
        }
        
        this.丈丐世下丞与丂专丏 = val_2;
        this.ratingLabel.text = this.丈丐世下丞与丂专丏.ToString();
    }
    public void CanShowNewLeague()
    {
        this.丌丄丝丑丝丒丁下世(上丗业丂丑三丏上丏:  this.丙丑七万丆万丆且丌);
    }
    public void CanShowNewPlace()
    {
        this.丏丕三与丈世且专万(与万丏业丞丌三专丌:  this.丆七下丒上丈丒业世);
    }
    public LeaderboardsLobbyButtonController()
    {
        this.丝丞丄丘丐丞且丝丈 = UnityEngine.Animator.StringToHash(name:  "GetPlace");
        this.丈丑不丏不丝世业丙 = UnityEngine.Animator.StringToHash(name:  "PlaceUp");
        this.丌与丗业丝丅世丘一 = UnityEngine.Animator.StringToHash(name:  "PlaceDown");
        this.丄三不丒业丘丞丁丞 = UnityEngine.Animator.StringToHash(name:  "ChangeLeague");
        this.且丝丑七七专下且丑 = UnityEngine.Animator.StringToHash(name:  "PickReward");
        this.丙丑七万丆万丆且丌 = 0;
        this.丈丐世下丞与丂专丏 = 0;
    }

}
