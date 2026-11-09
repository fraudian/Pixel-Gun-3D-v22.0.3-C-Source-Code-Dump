using UnityEngine;
public class DuelUIController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject waitForOpponent;
    public UnityEngine.GameObject versusInterface;
    public UnityEngine.GameObject endInterface;
    public UnityEngine.GameObject changeArea;
    public UnityEngine.GameObject rewardPanel;
    public UnityEngine.GameObject betPanel;
    public UnityEngine.GameObject betContainer;
    public UnityEngine.GameObject betPrizeContainer;
    public UnityEngine.GameObject betNoPrizeContainer;
    public UnityEngine.GameObject emojiPanel;
    public UnityEngine.GameObject btnAddFriendChek;
    public Rilisoft.ButtonHandler btnMakeBet;
    public Rilisoft.ButtonHandler btnAcceptBet;
    public Rilisoft.ButtonHandler backBtnInBet;
    public Rilisoft.ButtonHandler btnAddFriend;
    public Rilisoft.ButtonHandler btnStickers;
    public Rilisoft.ButtonHandler btnChooseBet;
    public CrateInfoButton btnShowBetInfo;
    public UIGrid betGrid;
    public UnityEngine.GameObject opponentLeftLabel;
    public LikeButtonHandler myLikeButton;
    public LikeButtonHandler enemyLikeButton;
    public UILabel myWinLabel;
    public UILabel myLooseLabel;
    public UILabel myDHLabel;
    public UILabel enemyWinLabel;
    public UILabel enemyLooseLabel;
    public UILabel enemyDHLabel;
    public UILabel expReward;
    public UILabel coinReward;
    public UILabel gemsReward;
    public UILabel myPoints;
    public UILabel myKills;
    public UILabel enemyPoints;
    public UILabel enemyKills;
    public UILabel versusTimer;
    public UILabel versusTimerInBet;
    public UILabel winnerPrize;
    public UILabel winnerChest;
    public UILabel opponentBetLabel;
    public Rilisoft.ButtonHandler nextButton;
    public Rilisoft.ButtonHandler nextEnemyButton;
    public Rilisoft.ButtonHandler revengeButton;
    public Rilisoft.ButtonHandler competitionButton;
    public UnityEngine.GameObject endBackButton;
    public UIScrollView betScrollView;
    public CaseAnimationWrapper caseAnimationWrapper;
    public bool showCharacters;
    public UnityEngine.GameObject revengePanel;
    public UILabel revengeLabel;
    public string revengeButtonSpriteBlink;
    public DuelBetItem[] betItems;
    public UnityEngine.GameObject versionConflictLabel;
    public UnityEngine.GameObject defaultBetLabels;
    private string 丑不丄丅上万丐且丆;
    private UIButton 一业三丕丌且丗丙丗;
    private bool 丏丟上丗三三万三丑;
    private bool 下东丈丟业丐丐丑业;
    private float 丕丆一丐丗丆丞丂且;
    private bool 与下丟丞丏丅丂丞丁;
    private bool 专下丐丙业且丗丟万;
    private bool 不丒不上丌世丄七东;
    public UILabel[] searchForOpponentLabels;
    public string competitionSearchOpponentsKey;
    private Rilisoft.GameEventExtendedEventInfoView 丂且七丘丌丝丘丈一;
    private Rilisoft.GameEventRewardView 专且世丂丐下丙万丘;
    private bool 丒世七丑与丂且丙丌;
    private string 丗三七丌丏丌丞丙上;
    private System.Collections.Generic.List<DuelUIController.丗一世丝丛不万丆丞> 丟丛丑丟且丁丐下不;
    public bool makeBetScrollResetOnEnable;
    public bool resetScrollNow;
    private UnityEngine.Color 东上丕丛丁丂专不万;
    
    // Properties
    internal DuelController 下世一世丏丌下丗且 { get; }
    private Rilisoft.GameEventExtendedEventInfoView 与丈丞丛丗丙上丕万 { get; }
    private Rilisoft.GameEventRewardView 丐丆丟东丈丞业东丛 { get; }
    
    // Methods
    internal DuelController 一专丅丝丁不与丞七()
    {
        null = null;
        return (DuelController)DuelController.丄丘七三上丕世丞业;
    }
    private Rilisoft.GameEventExtendedEventInfoView 丈万丝丄业丅丟世万()
    {
        if(this.专下丐丙业且丗丟万 == true)
        {
                return (Rilisoft.GameEventExtendedEventInfoView)this.丂且七丘丌丝丘丈一;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 != null)
        {
                Rilisoft.GameEventExtendedEventInfoView val_4 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventExtendedEventInfoView>(丅东专与不三丂丁丝:  val_2, 丒丘丏上丙丟丑丕丈:  "info", 丈东丘丏与丌东东下:  this.transform, 丛下丅丏丄且丁一业:  false);
            this.丂且七丘丌丝丘丈一 = val_4;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUITable"));
        }
        
        this.专下丐丙业且丗丟万 = true;
        return (Rilisoft.GameEventExtendedEventInfoView)this.丂且七丘丌丝丘丈一;
    }
    private Rilisoft.GameEventRewardView 丗丈丗丞丙丂业东丏()
    {
        if(this.不丒不上丌世丄七东 == true)
        {
                return (Rilisoft.GameEventRewardView)this.专且世丂丐下丙万丘;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 != null)
        {
                Rilisoft.GameEventRewardView val_4 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventRewardView>(丅东专与不三丂丁丝:  val_2, 丒丘丏上丙丟丑丕丈:  "rewardview", 丈东丘丏与丌东东下:  this.transform, 丛下丅丏丄且丁一业:  false);
            this.专且世丂丐下丙万丘 = val_4;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUITable"));
        }
        
        this.不丒不上丌世丄七东 = true;
        return (Rilisoft.GameEventRewardView)this.专且世丂丐下丙万丘;
    }
    private void FixedUpdate()
    {
        var val_2;
        if(this.丒世七丑与丂且丙丌 == false)
        {
                return;
        }
        
        val_2 = 0;
        goto label_2;
        label_8:
        this.searchForOpponentLabels[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.competitionSearchOpponentsKey);
        val_2 = 1;
        label_2:
        if(val_2 < this.searchForOpponentLabels.Length)
        {
            goto label_8;
        }
        
        this.丒世七丑与丂且丙丌 = false;
    }
    private void Awake()
    {
        var val_22;
        var val_23;
        val_22 = null;
        val_22 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != true)
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() == false)
        {
            goto label_7;
        }
        
        }
        
        UnityEngine.Vector3 val_4 = this.nextButton.transform.position;
        this.revengeButton.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nextButton.gameObject, 丏业丟一东丂东丘丛:  false);
        label_7:
        val_23 = null;
        val_23 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nextButton.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.revengeButton.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this.competitionButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.competitionButton.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
            if(this.endBackButton != null)
        {
                this.endBackButton.SetActive(value:  false);
        }
        
            this.丒世七丑与丂且丙丌 = true;
        }
        
        this.nextEnemyButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丙丏三丁丏专下丁且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.nextButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丅七丆丝与丕万上丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.revengeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丂业丁下丙与丆丌丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.btnAcceptBet.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丙专丏且万丐丗丛业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.btnMakeBet.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丙专丏且万丐丗丛业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.btnChooseBet.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丙丈一下专丞丘丞丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.btnAddFriend.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::丂丁七东丕且丙丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        UIButton val_17 = this.revengeButton.GetComponent<UIButton>();
        this.一业三丕丌且丗丙丗 = val_17;
        this.丑不丄丅上万丐且丆 = val_17.normalSprite;
        this.btnShowBetInfo.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DuelUIController::与丈且丒丐丄七丏丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelUIController::万业丄丘丅丒与丟丕()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelUIController::万业丄丘丅丒与丟丕()));
    }
    private void OnDestroy()
    {
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelUIController::万业丄丘丅丒与丟丕()));
        业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelUIController::万业丄丘丅丒与丟丕()));
    }
    private void 七丂一不丝下上世丞()
    {
        if((this.nextButton.GetComponent<UIButton>()) == 0)
        {
                return;
        }
        
        bool val_4 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 丕七万一东丕丁与专()
    {
        if((this.nextEnemyButton.GetComponent<UIButton>()) == 0)
        {
                return;
        }
        
        bool val_4 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 万业丄丘丅丒与丟丕()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        if(this.一业三丕丌且丗丙丗 == 0)
        {
                return;
        }
        
        bool val_2 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        if(val_2 == false)
        {
            goto label_10;
        }
        
        DuelController val_3 = val_2.一专丅丝丁不与丞七();
        val_7 = 0;
        bool val_4 = UnityEngine.Object.op_Inequality(x:  val_3.opponentNetworkTable, y:  0);
        if(val_4 == false)
        {
            goto label_10;
        }
        
        val_8 = val_4.一专丅丝丁不与丞七().丁七丒丕丑一丗一丟() ^ 1;
        goto label_12;
        label_10:
        val_8 = 0;
        label_12:
        var val_7 = val_8 & 1;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    internal void 丂丄与丆丁丅丅且且(bool 七丐上丁世丆业丒七, bool 丘丐丌丈丐丝万丏丆)
    {
        bool val_12;
        UILabel val_13;
        val_12 = 七丐上丁世丆业丒七;
        this.revengePanel.SetActive(value:  true);
        val_13 = this.revengeLabel;
        this.丏丟上丗三三万三丑 = val_12;
        if(丘丐丌丈丐丝万丏丆 != false)
        {
                val_13.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2433");
            UIButton val_3 = this.revengeButton.GetComponent<UIButton>();
            val_13 = ???;
            val_12 = ???;
        }
        else
        {
                val_13.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_12 != 1) ? "Key_2434" : "Key_2435");
        }
    
    }
    private void 丐丕丆丈丌下丄丆丕()
    {
        this.revengePanel.SetActive(value:  false);
        this.丏丟上丗三三万三丑 = false;
        this.revengeButton.GetComponent<UIButton>().normalSprite = this.丑不丄丅上万丐且丆;
        this.下东丈丟业丐丐丑业 = false;
    }
    public void ShowStartInterface()
    {
        null = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_7B = 1;
        typeof(NetworkStartTable).__il2cppRuntimeField_14D = 0;
        this.丄丝七丕丄丐丏业丟();
    }
    internal void 一万世专上丟丄丐丑(bool 丘丐丌丈丐丝万丏丆 = False)
    {
        if(val_1.gameStatus != 7)
        {
                return;
        }
        
        DuelController val_2 = this.一专丅丝丁不与丞七().一专丅丝丁不与丞七();
        val_2.SendGameLeft();
        DuelController val_3 = val_2.一专丅丝丁不与丞七();
        val_3.gameStatus = 9;
        this.showCharacters = true;
        this.endInterface.SetActive(value:  false);
        this.waitForOpponent.SetActive(value:  false);
        this.三丏丈丂东丘一丏丂();
        this.changeArea.SetActive(value:  true);
        this.opponentLeftLabel.SetActive(value:  丘丐丌丈丐丝万丏丆);
        this.emojiPanel.SetActive(value:  false);
    }
    internal void 丄丝七丕丄丐丏业丟()
    {
        this.showCharacters = true;
        this.waitForOpponent.SetActive(value:  true);
        this.三丏丈丂东丘一丏丂();
        this.一专丅丝丁不与丞七().InitializePlayersInfo();
        this.emojiPanel.SetActive(value:  false);
    }
    internal void 丗且丑丁丏丙丘丆丐(bool 上丆丘七丞且丄丘与, bool 丛丒丂一丒一三丒万)
    {
        var val_5;
        this.showCharacters = true;
        this.endInterface.SetActive(value:  false);
        this.waitForOpponent.SetActive(value:  false);
        this.changeArea.SetActive(value:  false);
        this.versusInterface.SetActive(value:  (上丆丘七丞且丄丘与 | 丛丒丂一丒一三丒万) ^ 1);
        if(上丆丘七丞且丄丘与 != false)
        {
                this.丟丙丞丏一丄丆丅丕();
        }
        else
        {
                if(丛丒丂一丒一三丒万 != false)
        {
                this.丞丅丕万三万丗丆业();
        }
        
        }
        
        val_5 = null;
        val_5 = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_7B = 1;
        typeof(NetworkStartTable).__il2cppRuntimeField_14D = 上丆丘七丞且丄丘与;
        this.emojiPanel.SetActive(value:  true);
    }
    private void 三丏丈丂东丘一丏丂()
    {
        this.versusInterface.SetActive(value:  false);
        this.betPanel.SetActive(value:  false);
        this.丏专丄丏丆不丕三丒();
        this.一丈丞与丐丙且世丌();
    }
    internal void 丆东世丝万丆下丞一()
    {
        var val_1;
        this.丐丕丆丈丌下丄丆丕();
        val_1 = null;
        val_1 = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_7B = 0;
        typeof(NetworkStartTable).__il2cppRuntimeField_14D = 1;
        this.showCharacters = false;
        this.三丏丈丂东丘一丏丂();
        this.waitForOpponent.SetActive(value:  false);
        this.changeArea.SetActive(value:  false);
        this.emojiPanel.SetActive(value:  false);
    }
    private void Update()
    {
        this.一专丅丝丁不与丞七().UpdateCharactersInfo();
        if(this.丏丟上丗三三万三丑 != false)
        {
                float val_2 = UnityEngine.Time.time;
            if(this.丕丆一丐丗丆丞丂且 < 0)
        {
                bool val_9 = this.下东丈丟业丐丐丑业;
            val_9 = val_9 ^ 1;
            this.下东丈丟业丐丐丑业 = val_9;
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 + 0.3f;
            this.丕丆一丐丗丆丞丂且 = val_3;
            this.一业三丕丌且丗丙丗.normalSprite = (this.下东丈丟业丐丐丑业 == true) ? this.revengeButtonSpriteBlink : this.丑不丄丅上万丐且丆;
        }
        
        }
        
        this.丆丆东七下丄七丅下();
        if(this.resetScrollNow != false)
        {
                if(this.betScrollView.gameObject.activeInHierarchy != false)
        {
                this.resetScrollNow = false;
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.七丗丅丏丑丕丘业上());
        }
        
        }
        
        this.七丂一不丝下上世丞();
        this.丕七万一东丕丁与专();
    }
    private System.Collections.IEnumerator 七丗丅丏丑丕丘业上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DuelUIController.万丐丌丞东丒七丝七();
    }
    internal void 丒丈丗三专丅丒丌三(bool 丆丐丐丕世丕丌世与, int 业七丅丟东丑专丅万, int 丄丅丟丟丛丟丟丟上, int 丟丒丅丂丛丄丗万丌, bool 丑一丂丙丈丝丑丅丑, bool 专东丘一三丐不丈专)
    {
        NetworkStartTable val_26;
        this.三丏丈丂东丘一丏丂();
        this.gameObject.SetActive(value:  true);
        this.coinReward.text = 业七丅丟东丑专丅万.ToString();
        this.expReward.text = 丟丒丅丂丛丄丗万丌.ToString();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.gemsReward, 丕丗丘丑丛与丑业丒:  丄丅丟丟丛丟丟丟上.ToString());
        bool val_6 = 专东丘一三丐不丈专 ^ 1;
        bool val_7 = val_6 & 丑一丂丙丈丝丑丅丑;
        this.myWinLabel.gameObject.SetActive(value:  val_7);
        val_6 = 丑一丂丙丈丝丑丅丑 ^ 1 & val_6;
        this.myLooseLabel.gameObject.SetActive(value:  val_6);
        this.myDHLabel.gameObject.SetActive(value:  专东丘一三丐不丈专);
        this.enemyWinLabel.gameObject.SetActive(value:  val_6);
        this.enemyLooseLabel.gameObject.SetActive(value:  val_7);
        UnityEngine.GameObject val_18 = this.enemyDHLabel.gameObject;
        val_18.SetActive(value:  专东丘一三丐不丈专);
        DuelController val_20 = val_18.一专丅丝丁不与丞七();
        val_26 = val_20.opponentNetworkTable;
        bool val_21 = UnityEngine.Object.op_Inequality(x:  val_26, y:  0);
        if(val_21 == false)
        {
                return;
        }
        
        DuelController val_22 = val_21.一专丅丝丁不与丞七();
        val_26 = val_22.opponentNetworkTable.丌丑丛业丈丘世丞丕;
        bool val_23 = UnityEngine.Object.op_Inequality(x:  val_26, y:  0);
        if(val_23 == false)
        {
                return;
        }
        
        DuelController val_24 = val_23.一专丅丝丁不与丞七();
        val_26 = val_24.opponentNetworkTable.丌丑丛业丈丘世丞丕.mySkinName.gameObject;
        val_26.SetActive(value:  false);
    }
    internal void 丂世丈丅丟且丆丑丝()
    {
        var val_30;
        string val_31;
        var val_32;
        var val_33;
        PlayerLikeController val_34;
        var val_35;
        string val_36;
        UILabel val_37;
        string val_38;
        var val_39;
        string val_40;
        var val_41;
        var val_42;
        this.emojiPanel.SetActive(value:  true);
        this.showCharacters = true;
        bool val_1 = NetworkStartTable.与一专丒东丏丘专丕();
        val_30 = null;
        val_30 = null;
        this.endInterface.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.myLikeButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enemyLikeButton, 丏业丟一东丂东丘丛:  false);
        val_31 = 0;
        val_32 = 0;
        val_33 = 0;
        if(val_31 < (-1277648896))
        {
                val_34 = 0;
            bool val_3 = (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.丟丌下三七丁与丟丑();
            val_31 = val_31 + 1;
            var val_5 = (val_3 != true) ? (val_32) : ((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32);
            var val_6 = (val_3 != true) ? ((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32) : (val_33);
        }
        
        this.myKills.text = val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 24.ToString();
        this.myPoints.text = val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 36.ToString();
        if(((GameConnect.丑丌丛丈丅丅与不业() != 20) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && ((System.String.op_Inequality(a:  val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 48, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false))
        {
                if(this.myLikeButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.myLikeButton, 丏业丟一东丂东丘丛:  true);
            val_31 = mem[val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 16];
            val_31 = val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 16;
            val_35 = null;
            val_36 = val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 48;
            val_34 = PlayerLikeController.丄丘七三上丕世丞业;
            this.myLikeButton.丈且东丑丂且万丒丅(丄丒且丙三丆丟与丏:  val_3 != true ? (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 : val_33 + 48, 丞丞下东且丗丄丒丏:  val_31, 丐丑丘与丘丈丟丒且:  val_34.一且丈丅丏丏丟丌世(丞丅上丏丂且下丅与:  null), 一七不三丌专三丆一:  false);
        }
        
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 20)
        {
            goto label_48;
        }
        
        label_56:
        val_37 = this.enemyKills;
        val_37.text = "0";
        val_38 = "0";
        goto label_52;
        label_48:
        if((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == true)
        {
            goto label_56;
        }
        
        if((System.String.op_Inequality(a:  val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 48, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                if(this.enemyLikeButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enemyLikeButton, 丏业丟一东丂东丘丛:  true);
            val_31 = mem[val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 16];
            val_31 = val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 16;
            val_39 = null;
            val_40 = val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 48;
            val_34 = PlayerLikeController.丄丘七三上丕世丞业;
            this.enemyLikeButton.丈且东丑丂且万丒丅(丄丒且丙三丆丟与丏:  val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 48, 丞丞下东且丗丄丒丏:  val_31, 丐丑丘与丘丈丟丒且:  val_34.一且丈丅丏丏丟丌世(丞丅上丏丂且下丅与:  null), 一七不三丌专三丆一:  false);
        }
        
        }
        
        val_37 = this.enemyKills;
        val_37.text = val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 24.ToString();
        val_38 = val_3 != true ? val_32 : (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 36.ToString();
        label_52:
        this.enemyPoints.text = val_38;
        val_41 = null;
        val_41 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        DuelController val_25 = ExperienceController.sharedController.一专丅丝丁不与丞七();
        val_25.InitializePlayersInfo();
        DuelController val_26 = val_25.一专丅丝丁不与丞七();
        val_26.SetShopEvents();
        DuelController val_27 = val_26.一专丅丝丁不与丞七();
        if(val_27.opponentNetworkTable == 0)
        {
                this.丂丄与丆丁丅丅且且(七丐上丁世丆业丒七:  false, 丘丐丌丈丐丝万丏丆:  true);
        }
        
        val_42 = null;
        val_42 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
                return;
        }
        
        if(this.competitionButton == 0)
        {
                return;
        }
        
        this.competitionButton.gameObject.SetActive(value:  true);
        this.competitionButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟, method:  System.Void NetworkStartTableNGUIController::与下丘万丌丆万丟丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丅七丆丝与丕万上丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.一万世专上丟丄丐丑(丘丐丌丈丐丝万丏丆:  false);
    }
    private void 丙丏三丁丏专下丁且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        丘丐丞上世丏一且业();
    }
    private void 丂业丁下丙与丆丌丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.一专丅丝丁不与丞七().RevengeRequest();
    }
    private void 丙专丏且万丐丗丛业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        DuelController.丄丘七三上丕世丞业.TryMakeBet();
    }
    private void 丂丁七东丕且丙丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        DuelController.丄丘七三上丕世丞业.AddOpponentToFriends();
    }
    private void 与丈且丒丐丄七丏丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.不世万丑且丗丒一万(丐下丝丘丑丟丟丗丌:  this.一专丅丝丁不与丞七().GetSelectedBetChest());
    }
    internal void 业丛七一丄丝下丅丛(string 丝丏业丅丈东业丝丒)
    {
        this.丗三七丌丏丌丞丙上 = 丝丏业丅丈东业丝丒;
    }
    internal void 丝丈下丝且丛丄世丆(bool 丛丅丘一丏丙且丌上, int 上丆丗专丁且万丐三)
    {
        var val_5;
        bool val_5 = 丛丅丘一丏丙且丌上;
        if(val_5 != false)
        {
                this.btnChooseBet.gameObject.SetActive(value:  false);
            this.betContainer.SetActive(value:  true);
        }
        
        this.betPrizeContainer.SetActive(value:  val_5);
        val_5 = (~val_5) & 1;
        this.betNoPrizeContainer.SetActive(value:  val_5);
        if((val_5 & 1) == 0)
        {
                val_5 = null;
            val_5 = null;
            System.String[] val_3 = DuelController.下丆丗专丂丐丈丐上 + (((long)(int)(上丆丗专丁且万丐三)) << 3);
            this.winnerChest.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (DuelController.下丆丗专丂丐丈丐上 + ((long)(int)(上丆丗专丁且万丐三)) << 3) + 32);
            return;
        }
        
        this.caseAnimationWrapper.ResetState();
    }
    private void 丂且丕世万丅一丕七()
    {
        this.丟丛丑丟且丁丐下不.Clear();
    }
    internal void 三丈丙一丈下万丘丛(int 上丆丗专丁且万丐三, bool 丒万丂专专业一下东, bool 世丟丑丈下世丌丐丝)
    {
        int val_8;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_11 = null;
        val_11 = null;
        System.String[] val_1 = DuelController.下丆丗专丂丐丈丐上 + (((long)(int)(上丆丗专丁且万丐三)) << 3);
        if(世丟丑丈下世丌丐丝 != false)
        {
                val_12 = "Key_3651";
            val_13 = null;
            val_14 = "Key_3652";
        }
        else
        {
                val_12 = "Key_3649";
            val_13 = null;
            val_14 = "Key_3650";
        }
        
        val_15 = null;
        val_15 = null;
        if(null == 0)
        {
            goto label_14;
        }
        
        string val_6 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (丒万丂专专业一下东 != true) ? (val_12) : (val_14)), arg0:  System.String.Format(format:  "[FFC3C3FF]{0}[-]", arg0:  NetworkStartTable.__il2cppRuntimeField_cctor_thread), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (DuelController.下丆丗专丂丐丈丐上 + ((long)(int)(上丆丗专丁且万丐三)) << 3) + 32));
        val_16 = 0;
        goto label_15;
        label_20:
        丗一世丝丛不万丆丞 val_7 = DuelController.丄丘七三上丕世丞业.Item[0];
        if(val_8 <= 上丆丗专丁且万丐三)
        {
                this.丟丛丑丟且丁丐下不.RemoveAt(index:  0);
        }
        
        val_16 = 0;
        label_15:
        if(val_16 < this.丟丛丑丟且丁丐下不.Count)
        {
            goto label_20;
        }
        
        float val_10 = UnityEngine.Time.time;
        val_8 = 上丆丗专丁且万丐三;
        this.丟丛丑丟且丁丐下不.Add(item:  new 丗一世丝丛不万丆丞() {丘东丏丆丑丐与丆丝 = -8.804829E+33f, 丕丗丘丑丛与丑业丒 = public System.Void System.Collections.Generic.List<丗一世丝丛不万丆丞>::Add(丗一世丝丛不万丆丞 item)});
        return;
        label_14:
        mem2[0] = ???;
        mem[8] = 0;
        mem[16] = 0;
    }
    private void 丆丆东七下丄七丅下()
    {
        float val_3;
        string val_13;
        UILabel val_14;
        var val_15;
        var val_16;
        val_14 = this;
        if(this.丟丛丑丟且丁丐下不.Count < 2)
        {
            goto label_2;
        }
        
        val_15 = 1;
        goto label_3;
        label_8:
        丗一世丝丛不万丆丞 val_2 = this.丟丛丑丟且丁丐下不.Item[1];
        float val_4 = UnityEngine.Time.time;
        if((val_3 + 2f) < 0)
        {
                this.丟丛丑丟且丁丐下不.RemoveAt(index:  1);
        }
        
        val_15 = 1;
        label_3:
        if(val_15 < this.丟丛丑丟且丁丐下不.Count)
        {
            goto label_8;
        }
        
        label_2:
        val_16 = this.opponentBetLabel.gameObject;
        if(this.丟丛丑丟且丁丐下不.Count < 1)
        {
            goto label_12;
        }
        
        val_16.SetActive(value:  true);
        val_14 = this.opponentBetLabel;
        if(this.丟丛丑丟且丁丐下不 == null)
        {
            goto label_13;
        }
        
        val_16 = this.丟丛丑丟且丁丐下不.Count;
        goto label_14;
        label_12:
        val_16.SetActive(value:  false);
        return;
        label_13:
        val_16 = 0.Count;
        label_14:
        丗一世丝丛不万丆丞 val_12 = this.丟丛丑丟且丁丐下不.Item[val_16 - 1];
        val_14.text = val_13;
    }
    private void 丟丙丞丏一丄丆丅丕()
    {
        this.与下丟丞丏丅丂丞丁 = false;
        this.betPanel.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.丝丈下丝且丛丄世丆(丛丅丘一丏丙且丌上:  false, 上丆丗专丁且万丐三:  0);
        this.丂且丕世万丅一丕七();
        this.opponentBetLabel.gameObject.SetActive(value:  false);
        this.betContainer.SetActive(value:  false);
        this.btnChooseBet.gameObject.SetActive(value:  true);
        UIButton val_3 = this.btnChooseBet.GetComponent<UIButton>();
        this.caseAnimationWrapper.Initialize(丝丏业丅丈东业丝丒:  this.丗三七丌丏丌丞丙上);
        this.versionConflictLabel.gameObject.SetActive(value:  false);
        this.defaultBetLabels.gameObject.SetActive(value:  true);
    }
    private void 丞丅丕万三万丗丆业()
    {
        this.与下丟丞丏丅丂丞丁 = false;
        this.betPanel.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.丝丈下丝且丛丄世丆(丛丅丘一丏丙且丌上:  false, 上丆丗专丁且万丐三:  0);
        this.丂且丕世万丅一丕七();
        this.opponentBetLabel.gameObject.SetActive(value:  false);
        this.betContainer.SetActive(value:  false);
        this.btnChooseBet.gameObject.SetActive(value:  true);
        UIButton val_3 = this.btnChooseBet.GetComponent<UIButton>();
        this.versionConflictLabel.gameObject.SetActive(value:  true);
        this.defaultBetLabels.gameObject.SetActive(value:  false);
    }
    private void 丙丈一下专丞丘丞丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.与下丟丞丏丅丂丞丁 = true;
        this.betContainer.SetActive(value:  true);
        this.btnChooseBet.gameObject.SetActive(value:  false);
        if(this.makeBetScrollResetOnEnable == false)
        {
                return;
        }
        
        this.makeBetScrollResetOnEnable = false;
        this.betScrollView.ResetPosition();
    }
    private void 不世万丑且丗丒一万(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
    {
        if(this.丈万丝丄业丅丟世万() == 0)
        {
                return;
        }
        
        if(this.丈万丝丄业丅丟世万().gameObject.activeSelf != true)
        {
                UnityEngine.Color val_6 = PGCompany.丟丝世世且丗丈丈丞.丄丐丒丆与丅不丗不();
            this.东上丕丛丁丂专不万 = val_6;
            mem[1152921525945892680] = val_6.g;
            mem[1152921525945892684] = val_6.b;
            mem[1152921525945892688] = val_6.a;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
        this.丈万丝丄业丅丟世万().Show(丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 丁丞丅上丝三丐丅丆:  true);
        this.丈万丝丄业丅丟世万().gameObject.SetActive(value:  true);
        this.丈万丝丄业丅丟世万().Show(丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 丁丞丅上丝三丐丅丆:  true);
        this.丈万丝丄业丅丟世万().add_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelUIController::丏专丄丏丆不丕三丒()));
    }
    private void 丏专丄丏丆不丕三丒()
    {
        if(this.专下丐丙业且丗丟万 == false)
        {
                return;
        }
        
        if(this.丈万丝丄业丅丟世万() == 0)
        {
                return;
        }
        
        this.丈万丝丄业丅丟世万().gameObject.SetActive(value:  false);
        this.丈万丝丄业丅丟世万().remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelUIController::丏专丄丏丆不丕三丒()));
        PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.东上丕丛丁丂专不万});
    }
    private void 一丈丞与丐丙且世丌()
    {
        if(this.不丒不上丌世丄七东 == false)
        {
                return;
        }
        
        if(this.专且世丂丐下丙万丘 == 0)
        {
                return;
        }
        
        this.专且世丂丐下丙万丘.Hide();
    }
    internal void 不一丒丁丗上丗上世(object 丙丈下丕丑专上丕丛)
    {
        var val_11;
        var val_12;
        Rilisoft.GameEventItemData val_13;
        val_11 = 丙丈下丕丑专上丕丛;
        val_12 = null;
        val_12 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        if(val_11 == null)
        {
                return;
        }
        
        if(this.丗丈丗丞丙丂业东丏() == 0)
        {
                return;
        }
        
        val_13 = 0;
        this.丗丈丗丞丙丂业东丏().ShowAsInfo(一丐丗丁丞丆丅丟丄:  val_13);
        this.丗丈丗丞丙丂业东丏().丘丌丙与不丝下万丐();
    }
    public DuelUIController()
    {
        this.competitionSearchOpponentsKey = "Key_2435";
        this.丟丛丑丟且丁丐下不 = new System.Collections.Generic.List<丗一世丝丛不万丆丞>();
        UnityEngine.Color val_2 = UnityEngine.Color.black;
        this.东上丕丛丁丂专不万 = val_2;
        mem[1152921525946485064] = val_2.g;
        mem[1152921525946485068] = val_2.b;
        mem[1152921525946485072] = val_2.a;
    }

}
