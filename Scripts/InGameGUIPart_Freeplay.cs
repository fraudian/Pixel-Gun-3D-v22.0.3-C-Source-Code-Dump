using UnityEngine;
public class InGameGUIPart_Freeplay : InGameGUIPartContainer
{
    // Fields
    public MiniMapController miniMap;
    internal SquadNotifications SquadNotifications;
    public UILabel secretsCountLabel;
    public UILabel playerCountLabel;
    public PlayGadgetSFX rewardsContainerSFX;
    public UnityEngine.GameObject rewards;
    public WidgetLayout rewardsLayout;
    public UILabel placeReward;
    public UILabel goldReward;
    public UILabel expReward;
    public UnityEngine.GameObject expRewardObject;
    public UnityEngine.GameObject nonPrivateContainerObject;
    public UILabel keysReward;
    public UILabel messageReward;
    public UILabel doubledRewardMessage;
    public UILabel bestPlayerNameLabel;
    public UILabel headerLabel;
    public UITexture leftStarTexture;
    public UITexture rightStarTexture;
    public UISprite placeBaseColor;
    public UISprite placeGradiColor;
    private UnityEngine.GameObject mapLegend;
    public UIGrid mapLegendLeftGrid;
    public UnityEngine.GameObject mapLegendSecrets;
    private UIGrid mapLegendRightGrid;
    private UnityEngine.GameObject mapLegendMe;
    private UnityEngine.GameObject mapLegendSquadMate;
    private UnityEngine.GameObject mapLegendMyCar;
    private UnityEngine.GameObject mapLegendSquadCar;
    private UnityEngine.GameObject mapLegendPlayer;
    public UnityEngine.AudioClip bestPlayerSound;
    public UnityEngine.AudioClip rewardSound;
    public UnityEngine.AudioClip noRewardSound;
    public PGCompany.FreePlayTasksViewWindow tasksViewWindow;
    public PGCompany.FreePlay.Squad.SquadUi squadUi;
    public UnityEngine.GameObject taskAlertUpdate;
    private UnityEngine.GameObject vehicleTipHolder;
    private UILabel vehicleTipHolderLabel;
    private UnityEngine.GameObject allSecretsHolder;
    private UnityEngine.GameObject allSecretsHolderGems;
    private UnityEngine.GameObject foundSecretHolder;
    private UnityEngine.GameObject disappearHolder;
    public ShoppingBanner shoppingBanner;
    public TransportReplaceConfirmPanel transportReplaceConfirmPanel;
    private const string 业且且东上丑丞丙丗 = "Key_10215";
    private const string 丄丂业丅东上丏且与 = "Key_10211";
    private const string 丟三专万丛丗丑专丑 = "Textures/icon_freeplay_leaf_bronze";
    private const string 丛且下世专且丏丏丛 = "Textures/icon_freeplay_leaf_silver";
    private const string 丅丑不东三一丗与丘 = "Textures/icon_freeplay_leaf_gold";
    private const string 丌丂上丞丆丘丕丒丐 = "FreePlay_placements/bronze_base";
    private const string 丞丑且丕一世丛丈丌 = "FreePlay_placements/bronze_gradi";
    private const string 丈丗丘丑丞丕丟七丄 = "FreePlay_placements/silver_base";
    private const string 丈丅且丙且丏丝且不 = "FreePlay_placements/silver_gradi";
    private const string 丆丌七世丟丆丗丕丟 = "FreePlay_placements/gold_base";
    private const string 丐丘丌丅丏丑丅丁专 = "FreePlay_placements/gold_gradi";
    private const string 东上一丆丕丗业世上 = "bstPlrNm";
    private const string 丈丗丏丌丑丞丟丝丒 = "Key_10216";
    private bool 七且丒业三丐万丂丙;
    private bool 丄世丕业丗丁丅丑丝;
    private bool 万丑丝七丙丘上三丐;
    private bool[] 下三上丑丄上丄丈丅;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 = this;
        this.下三上丑丄上丄丈丅 = new bool[5];
    }
    private void Start()
    {
        var val_5;
        UnityEngine.Object val_6;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapLegendSecrets, 丏业丟一东丂东丘丛:  (~NetworkStartTable.与一专丒东丏丘专丕()) & 1);
        this.七且丒业三丐万丂丙 = true;
        this.丕丕丕三七丆三下不();
        val_5 = null;
        val_5 = null;
        if(GameController.onlineMode != null)
        {
                var val_3 = (null == null) ? GameController.onlineMode : 0;
        }
        else
        {
                val_6 = 0;
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        713.丈丙丙丐下丅丒三一(丙业与丙丗丝不丈东:  this.squadUi);
    }
    private void Update()
    {
        this.下丑东丏世专丗丌三();
        this.丞丐不丅专丙丛世丝();
        this.丏丅丆丏丂下丅一丅();
    }
    internal void 专不上丌丈丗丑不七()
    {
        if(this.disappearHolder == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disappearHolder, 丏业丟一东丂东丘丛:  true);
        this = this.disappearHolder.GetComponent<DisableObjectFromTimer>();
        if(this == 0)
        {
                return;
        }
        
        val_2.timer = 3f;
    }
    internal void 上与丙丄丛七三下丐(string 丕丗丘丑丛与丑业丒)
    {
        UnityEngine.Object val_4;
        UnityEngine.GameObject val_5;
        val_4 = this;
        val_5 = this.vehicleTipHolder;
        if(val_5 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.vehicleTipHolder, 丏业丟一东丂东丘丛:  true);
        val_5 = this.vehicleTipHolderLabel;
        val_5.text = 丕丗丘丑丛与丑业丒;
        val_4 = this.vehicleTipHolder.GetComponent<DisableObjectFromTimer>();
        if(val_4 == 0)
        {
                return;
        }
        
        val_2.timer = 3f;
    }
    private void 丕丕丕三七丆三下不()
    {
        var val_9;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  "bstPlrNm")) != false)
        {
                val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item["bstPlrNm"];
        }
        
        this.bestPlayerNameLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10216");
    }
    internal void 下丑东丏世专丗丌三()
    {
        null = null;
        this.playerCountLabel.text = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count.ToString();
    }
    internal void 丞丐不丅专丙丛世丝()
    {
        UILabel val_5;
        int val_6;
        val_5 = this;
        val_6 = 1152921505292947456;
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_5 = this.secretsCountLabel;
        val_6 = SecretsFreemodeController.丆丕丝丒不丙且丐丗.业上一七丘丏丝下丈();
        val_5.text = System.String.Format(format:  "{0}/{1}", arg0:  SecretsFreemodeController.丆丕丝丒不丙且丐丗.GetCurrentSecretCount(), arg1:  val_6);
    }
    public void ShowReward(int 且丒丛与丞世丙丕丌, int 丕业丘丐且丒专丂不, int 丂丁丏丏万丛丈丐丆, int 与丟且丝丞一丘七丑, bool 下丟与丙丁三丕丏下, bool 丏丙七丑与丐东丈丅, bool 上丌丛不业与世丑丏)
    {
        UILabel val_29;
        UILabel val_30;
        string val_31;
        UILabel val_33;
        bool val_34;
        var val_35;
        int val_1 = 且丒丛与丞世丙丕丌 + 1;
        this.万丑丝七丙丘上三丐 = true;
        this.placeReward.text = val_1.ToString();
        this.goldReward.text = 丕业丘丐且丒专丂不.ToString();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.goldReward, 丏业丟一东丂东丘丛:  (丕业丘丐且丒专丂不 > 0) ? 1 : 0);
        this.expReward.text = 丂丁丏丏万丛丈丐丆.ToString();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.expReward, 丏业丟一东丂东丘丛:  (丂丁丏丏万丛丈丐丆 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.expRewardObject, 丏业丟一东丂东丘丛:  (丂丁丏丏万丛丈丐丆 > 0) ? 1 : 0);
        val_29 = this.keysReward;
        val_29.text = 与丟且丝丞一丘七丑.ToString();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.keysReward, 丏业丟一东丂东丘丛:  (与丟且丝丞一丘七丑 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.doubledRewardMessage, 丏业丟一东丂东丘丛:  下丟与丙丁三丕丏下 | 丏丙七丑与丐东丈丅);
        if((下丟与丙丁三丕丏下 == false) || (丏丙七丑与丐东丈丅 == false))
        {
            goto label_8;
        }
        
        val_30 = this.doubledRewardMessage;
        val_31 = "Key_10416";
        goto label_15;
        label_8:
        if(下丟与丙丁三丕丏下 == false)
        {
            goto label_12;
        }
        
        val_30 = this.doubledRewardMessage;
        val_31 = "Key_10217";
        goto label_15;
        label_12:
        if(丏丙七丑与丐东丈丅 == false)
        {
            goto label_16;
        }
        
        val_30 = this.doubledRewardMessage;
        val_31 = "Key_10415";
        label_15:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_30, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31));
        label_16:
        this.丕丕丕三七丆三下不();
        if(val_1 == 1)
        {
                string val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10215");
        }
        else
        {
                val_29 = this.bestPlayerNameLabel;
        }
        
        this.messageReward.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10211"), arg0:  val_29.text);
        if(上丌丛不业与世丑丏 != false)
        {
                if(NetworkStartTable.与一专丒东丏丘专丕() == false)
        {
            goto label_32;
        }
        
        }
        
        this.丌丘丘一丞万丛万丂(且丒丛与丞世丙丕丌:  val_1);
        val_33 = this.headerLabel;
        if(上丌丛不业与世丑丏 == true)
        {
            goto label_33;
        }
        
        val_34 = 0;
        goto label_34;
        label_32:
        val_33 = this.headerLabel;
        label_33:
        val_34 = (~NetworkStartTable.与一专丒东丏丘专丕()) & 1;
        label_34:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_33, 丏业丟一东丂东丘丛:  val_34);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nonPrivateContainerObject, 丏业丟一东丂东丘丛:  (~NetworkStartTable.与一专丒东丏丘专丕()) & 1);
        if(上丌丛不业与世丑丏 != false)
        {
                val_35 = NetworkStartTable.与一专丒东丏丘专丕();
        }
        else
        {
                val_35 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewards, 丏业丟一东丂东丘丛:  true);
        if(((丕业丘丐且丒专丂不 <= 0) && (丂丁丏丏万丛丈丐丆 <= 0)) && (与丟且丝丞一丘七丑 <= 0))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nonPrivateContainerObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.rewardsContainerSFX.Play();
        var val_22 = (丕业丘丐且丒专丂不 > 0) ? 1 : 0;
        val_22 = val_22 | ((丂丁丏丏万丛丈丐丆 > 0) ? 1 : 0);
        this.丛不上丛一丆丛丅下(丄下丗丞丙丛丂丕不:  val_22 | ((与丟且丝丞一丘七丑 > 0) ? 1 : 0), 丆且丞三专丏丑丆丁:  (val_1 == 1) ? 1 : 0);
    }
    private void 丛不上丛一丆丛丅下(bool 丄下丗丞丙丛丂丕不, bool 丆且丞三专丏丑丆丁)
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if((丄下丗丞丙丛丂丕不 == false) || (丆且丞三专丏丑丆丁 == false))
        {
            goto label_5;
        }
        
        val_4 = 1152921505093320704;
        val_5 = this.bestPlayerSound;
        goto label_9;
        label_5:
        bool val_2 = 丆且丞三专丏丑丆丁 ^ 1;
        if((val_2 == true) || (丄下丗丞丙丛丂丕不 == true))
        {
            goto label_8;
        }
        
        label_14:
        val_4 = 1152921505093320704;
        val_5 = this.noRewardSound;
        goto label_9;
        label_8:
        val_2 = val_2 & 丄下丗丞丙丛丂丕不;
        if(val_2 == false)
        {
            goto label_10;
        }
        
        val_4 = 1152921505093320704;
        val_5 = this.rewardSound;
        label_9:
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_5);
        return;
        label_10:
        if(丄下丗丞丙丛丂丕不 == true)
        {
                return;
        }
        
        if(丆且丞三专丏丑丆丁 == false)
        {
            goto label_14;
        }
    
    }
    private void 丌丘丘一丞万丛万丂(int 且丒丛与丞世丙丕丌)
    {
        string val_1;
        string val_2;
        string val_3;
        if(且丒丛与丞世丙丕丌 <= 3)
        {
                val_1 = "Textures/icon_freeplay_leaf_gold";
            val_2 = "FreePlay_placements/gold_base";
            val_3 = "FreePlay_placements/gold_gradi";
        }
        else
        {
                if(且丒丛与丞世丙丕丌 <= 5)
        {
                val_1 = "Textures/icon_freeplay_leaf_silver";
            val_2 = "FreePlay_placements/silver_base";
            val_3 = "FreePlay_placements/silver_gradi";
        }
        else
        {
                if(且丒丛与丞世丙丕丌 > 9)
        {
                return;
        }
        
            val_1 = "Textures/icon_freeplay_leaf_bronze";
            val_2 = "FreePlay_placements/bronze_base";
            val_3 = "FreePlay_placements/bronze_gradi";
        }
        
        }
        
        this.丆丕业丆丝丏丌与丈(万与丆丄上且丘丘上:  val_1, 丛丁丗上丕丟丆丗丙:  val_2, 上与不丏七丄不丈万:  val_3);
    }
    private void 丆丕业丆丝丏丌与丈(string 万与丆丄上且丘丘上, string 丛丁丗上丕丟丆丗丙, string 上与不丏七丄不丈万)
    {
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.leftStarTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  万与丆丄上且丘丘上));
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.rightStarTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  万与丆丄上且丘丘上));
        UnityEngine.Color val_3 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  丛丁丗上丕丟丆丗丙);
        this.placeBaseColor.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Color val_4 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  上与不丏七丄不丈万);
        this.placeGradiColor.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
    }
    public void ShowMapLegend(bool 丛与丙丒丒下丌丟且)
    {
        丛与丙丒丒下丌丟且 = 丛与丙丒丒下丌丟且;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapLegend, 丏业丟一东丂东丘丛:  丛与丙丒丒下丌丟且);
    }
    private void 丏丅丆丏丂下丅一丅()
    {
        System.Boolean[] val_11;
        var val_12;
        var val_13;
        if(this.mapLegend == 0)
        {
                return;
        }
        
        if(this.mapLegend.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.miniMap == 0)
        {
                return;
        }
        
        val_11 = this.miniMap.丈丁不丘业一世丘丌(一丕丅一丕丘世丑丆:  new int[5] {1, 23, 22, 24, 25});
        val_12 = 0;
        val_13 = 0;
        goto label_10;
        label_24:
        if((((this.下三上丑丄上丄丈丅[0] == true) ? 1 : 0) ^ (UnityEngine.Object.op_Inequality(x:  val_11[0], y:  0))) != false)
        {
                val_13 = 1;
            this.下三上丑丄上丄丈丅[0] = UnityEngine.Object.op_Inequality(x:  val_5[0x0] + 32, y:  0);
        }
        
        val_12 = 1;
        label_10:
        if(val_12 < val_4.Length)
        {
            goto label_24;
        }
        
        if((val_13 & 1) == 0)
        {
                return;
        }
        
        this.丄世丕业丗丁丅丑丝 = true;
        if(this.mapLegendMe != null)
        {
                val_11 = this.下三上丑丄上丄丈丅;
            this.mapLegendMe.SetActive(value:  val_11[0]);
        }
        
        if(this.mapLegendMyCar != null)
        {
                val_11 = this.下三上丑丄上丄丈丅;
            this.mapLegendMyCar.SetActive(value:  val_11[0]);
        }
        
        if(this.mapLegendPlayer != null)
        {
                val_11 = this.下三上丑丄上丄丈丅;
            this.mapLegendPlayer.SetActive(value:  val_11[0]);
        }
        
        if(this.mapLegendSquadMate != null)
        {
                val_11 = this.下三上丑丄上丄丈丅;
            this.mapLegendSquadMate.SetActive(value:  val_11[0]);
        }
        
        if(this.mapLegendSquadCar == null)
        {
                return;
        }
        
        this.mapLegendSquadCar.SetActive(value:  this.下三上丑丄上丄丈丅[0]);
    }
    public void ShowAllSecretsMessage(bool 与一丗丈丙东七上丒)
    {
        UnityEngine.GameObject val_1;
        if(与一丗丈丙东七上丒 == false)
        {
            goto label_0;
        }
        
        val_1 = this.allSecretsHolderGems;
        if(val_1 != null)
        {
            goto label_3;
        }
        
        goto label_2;
        label_0:
        val_1 = this.allSecretsHolder;
        if(val_1 != null)
        {
            goto label_3;
        }
        
        label_2:
        label_3:
        val_1.SetActive(value:  true);
    }
    public void ShowCurrentSecretsMessage()
    {
        this.foundSecretHolder.SetActive(value:  true);
    }
    private void LateUpdate()
    {
        if(this.丄世丕业丗丁丅丑丝 != false)
        {
                this.丄世丕业丗丁丅丑丝 = false;
        }
        
        if(this.七且丒业三丐万丂丙 != false)
        {
                this.七且丒业三丐万丂丙 = false;
        }
        
        if(this.万丑丝七丙丘上三丐 == false)
        {
                return;
        }
        
        this.万丑丝七丙丘上三丐 = false;
        if(this.rewardsLayout == null)
        {
                return;
        }
        
        this.rewardsLayout.Reposition();
    }
    public bool CheckTapOnTaskPanelOrWidgets(UnityEngine.Vector3 丙一与世丈专丅三三)
    {
        if(this.tasksViewWindow.TasksIsActive != false)
        {
                return true;
        }
        
        if(this.tasksViewWindow != null)
        {
                return this.tasksViewWindow.CheckTapOnWidgets(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z});
        }
        
        return this.tasksViewWindow.CheckTapOnWidgets(丙一与世丈专丅三三:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z});
    }
    public InGameGUIPart_Freeplay()
    {
    
    }

}
