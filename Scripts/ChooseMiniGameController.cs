using UnityEngine;
public class ChooseMiniGameController : MonoBehaviour
{
    // Fields
    internal static ChooseMiniGameController 丄丞丁丈与业上丞丟;
    public UnityEngine.Transform ticketsIndicatorPoint;
    public System.Collections.Generic.List<UILabel> welcomeFreeTicketsLabels;
    public System.Collections.Generic.List<UILabel> welcomeAboutPeriodicalTicketsLabels;
    public System.Collections.Generic.List<UILabel> periodicalFreeTicketsCountLabels;
    public UnityEngine.GameObject periodicalFreeTicketsBanner;
    public UnityEngine.Transform startMiniGameScreenParent;
    public MiniGameCell campaignCell;
    public MiniGameCell sandboxCell;
    public MiniGameCell arenaCell;
    public MiniGameCell coopSurvivalCell;
    public MiniGameCell deadlyGamesCell;
    public MiniGameCell deathEscapeCell;
    public MiniGameCell spleefCell;
    public MiniGameCell speedRunCell;
    public System.Action onBackPressed;
    public UnityEngine.GameObject welcomeTicketsBanner;
    private System.IDisposable 丁丟丏丁上专业丆万;
    private System.IDisposable 丑丙七专世七丁业丙;
    private System.IDisposable 丙世丈且丆丒下下丌;
    
    // Methods
    private void Awake()
    {
        ChooseMiniGameController.丄丞丁丈与业上丞丟 = this;
    }
    public void HandleCoinsShop()
    {
        ChooseMiniGameController.与丟业一丈上丅上不 val_1 = new ChooseMiniGameController.与丟业一丈上丅上不();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_1, method:  System.Void ChooseMiniGameController.与丟业一丈上丅上不::一丏丗丆丈丐万与丕(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ChooseMiniGameController.与丟业一丈上丅上不)[1152921525709273648].丑丘丐丂不丐丒丟且);
        this.gameObject.SetActive(value:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "TicketsCurrency", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    public void HandlePeriodicalFreeTicketsGet()
    {
    
    }
    public void HandleMiniGamePressed(MiniGameCell 丛世东一丘万世与七)
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(丛世东一丘万世与七.type == 11)
        {
                this.HandleCampaignPressed();
            return;
        }
        
        this.专丆丏且丟丆世丏三(与丛丛丟丅世丏丐丌:  丛世东一丘万世与七.type, 丗丅七业丝不三丄三:  丛世东一丘万世与七.Parameters);
    }
    public void HandleSquadButtonPressed()
    {
        null = null;
        丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void ChooseMiniGameController::丏世丙东下专业丟丆()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 丏世丙东下专业丟丆()
    {
        var val_4;
        var val_5;
        var val_6;
        this.gameObject.SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_5 = null;
            val_5 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        val_6 = null;
        val_6 = null;
        SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ChooseMiniGameController::不丒丕丟丙丅丁世一()), 上且丗一丏丏万丅丌:  9, 丌与一丌且一不七丆:  true, 三丛业业专丄丟丄丅:  0, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
    }
    public void JoinToSquadPoint(string 丅一丞万丑专丅丅与)
    {
        var val_3;
        ChooseMiniGameController.上三且上丁业与与丑 val_1 = new ChooseMiniGameController.上三且上丁业与与丑();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丅一丞万丑专丅丅与 = 丅一丞万丑专丅丅与;
        val_3 = null;
        val_3 = null;
        丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ChooseMiniGameController.上三且上丁业与与丑::丆且丂丗丐三丟且丛()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 不丒丕丟丙丅丁世一()
    {
        this.gameObject.SetActive(value:  true);
    }
    public void HandleCampaignPressed()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.丁七丆丏三丆丞丛且(丂丛丑东不丅丈一东:  11);
        MainMenuController.丄丞丁丈与业上丞丟.StartCampaingButton();
        MainMenuController.丂不三丈丕丑丌业下 = 0;
    }
    internal void 丅丁丝丁丈丛丐且丑(Rilisoft.七丕丟丏三丈一丄世 丛丝丗万丐业丒丂丞, bool 丝三丄专丗丞丄丄丌)
    {
        var val_11;
        Rilisoft.七丕丟丏三丈一丄世 val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = 丛丝丗万丐业丒丂丞;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌);
        this.丒业上丆丘丄丅专丘();
        if(丝三丄专丗丞丄丄丌 != false)
        {
                val_15 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            this.丙世丈且丆丒下下丌 = val_15.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ChooseMiniGameController::HandleBackPressed()), 与且专丈不万东一万:  "ChooseMiniGameController SetEnabled");
            this.东丅丙丞上上丕丞业();
            if(val_14 == 11)
        {
                return;
        }
        
            this.专丆丏且丟丆世丏三(与丛丛丟丅世丏丐丌:  val_14, 丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  val_14));
            return;
        }
        
        val_15 = 1152921505080860672;
        val_16 = null;
        val_16 = null;
        val_14 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_14 == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        val_14 = MainMenuController.丄丞丁丈与业上丞丟;
        System.Collections.Generic.List<System.Int32> val_8 = val_14.丞丅东丄丁丝丕丘三();
        if(val_8 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_9 = val_8.GetEnumerator();
        label_24:
        if(((-371414400) & 1) == 0)
        {
            goto label_20;
        }
        
        val_18 = null;
        val_18 = null;
        MainMenuController.丄丞丁丈与业上丞丟.丁七丆丏三丆丞丛且(丂丛丑东不丅丈一东:  val_11.丙东专丂世丈丏丁丂());
        goto label_24;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void HandleCloseWelcomeBanner()
    {
    
    }
    public void HandleBackPressed()
    {
        this.丅丁丝丁丈丛丐且丑(丛丝丗万丐业丒丂丞:  11, 丝三丄专丗丞丄丄丌:  false);
        if(this.onBackPressed == null)
        {
                return;
        }
        
        this.onBackPressed.Invoke();
    }
    private void 专丆丏且丟丆世丏三(Rilisoft.七丕丟丏三丈一丄世 与丛丛丟丅世丏丐丌, 丌丑丕丏丝丆上东丄 丗丅七业丝不三丄三)
    {
        if(this.startMiniGameScreenParent.childCount == 0)
        {
                UnityEngine.Transform val_3 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "PanelMiniGame"));
            val_3.parent = this.startMiniGameScreenParent;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            val_3.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        
        this.startMiniGameScreenParent.GetChild(index:  0).GetComponent<StartMiniGameGuiController>().Setup(丟丘万不丏丕丌丑丟:  与丛丛丟丅世丏丐丌, 丗丅七业丝不三丄三:  丗丅七业丝不三丄三);
    }
    private void 东丅丙丞上上丕丞业()
    {
        this.campaignCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  11));
        this.sandboxCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  9));
        this.arenaCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  12));
        this.coopSurvivalCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  1));
        this.deadlyGamesCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  3));
        this.deathEscapeCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  10));
        this.spleefCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  14));
        this.speedRunCell.Setup(丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  13));
    }
    private void 丘丞丝丝不世专七丑()
    {
        if(this.丁丟丏丁上专业丆万 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丁丟丏丁上专业丆万.Dispose();
        this.丁丟丏丁上专业丆万 = 0;
    }
    private void 丐丘丏不丏三丄七丐()
    {
        if(this.丑丙七专世七丁业丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丑丙七专世七丁业丙.Dispose();
        this.丑丙七专世七丁业丙 = 0;
    }
    private void 丒业上丆丘丄丅专丘()
    {
        if(this.丙世丈且丆丒下下丌 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丙世丈且丆丒下下丌.Dispose();
        this.丙世丈且丆丒下下丌 = 0;
    }
    private void Update()
    {
        if(this.welcomeTicketsBanner.activeSelf == true)
        {
                return;
        }
        
        if(this.startMiniGameScreenParent.childCount < 1)
        {
                return;
        }
        
        bool val_5 = this.startMiniGameScreenParent.GetChild(index:  0).gameObject.activeSelf;
    }
    private void OnDestroy()
    {
        ChooseMiniGameController.丄丞丁丈与业上丞丟 = 0;
        this.丒业上丆丘丄丅专丘();
    }
    public ChooseMiniGameController()
    {
    
    }

}
