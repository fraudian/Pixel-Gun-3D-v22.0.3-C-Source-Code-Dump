using UnityEngine;
public class SquadPanelGUI : MonoBehaviour
{
    // Fields
    internal static SquadPanelGUI 丄丘七三上丕世丞业;
    public UIButton chatSendButton;
    public UITable chatTable;
    public UIScrollView chatScrollView;
    public PrivateMessageItem chatMessagePrefab;
    public UnityEngine.GameObject stickersShopBanner;
    public MyUIInput chatInput;
    public ChatAnimator chatAnimator;
    public UnityEngine.AudioClip playerJoinedSound;
    public UnityEngine.AudioClip playerQuitSound;
    public Rilisoft.ButtonHandler backBtn;
    public Rilisoft.ButtonHandler invitePlayersBtn;
    public Rilisoft.ButtonHandler goBtn;
    public Rilisoft.ButtonHandler readyBtn;
    public Rilisoft.ButtonHandler messageButtonOk;
    public Rilisoft.ButtonHandler messageButtonCancel;
    public Rilisoft.ButtonHandler buyTicketsBtn;
    public Rilisoft.ButtonHandler blockButtonOk;
    public UnityEngine.GameObject selectStandart;
    public UnityEngine.GameObject selectMiniGames;
    public UnityEngine.GameObject viewMode;
    public UnityEngine.GameObject selectGameMode;
    public UnityEngine.GameObject selectFull;
    public UnityEngine.GameObject viewFull;
    public UnityEngine.GameObject selectClanWarTaskUnavailableView;
    public PGCompany.ClanWarSquadTaskView selectClanWarTaskView;
    public PGCompany.ClanWarSquadTaskView silverMineSiegeClanWarTaskView;
    public PGCompany.ClanWarSquadTaskView silverMineRaidClanWarTaskView;
    public PGCompany.ClanWarSquadEventSiegeView selectClanWarEventSiegeView;
    public PGCompany.ClanWarSquadEventRaidView selectClanWarEventRaidView;
    public ModulesTableUI dungeonModulesPanel;
    public UnityEngine.GameObject cwMineModules;
    public UnityEngine.GameObject selectClanWarTestEventSiegeView;
    public UnityEngine.GameObject selectClanWarTestEventRaidView;
    public UILabel[] headerLabels;
    public UnityEngine.GameObject miniGamePrice;
    public UnityEngine.GameObject doubleRewardObject;
    public UILabel miniGamePriceLabel;
    public UILabel viewGamemodeName;
    public UILabel viewGamemodeRules;
    public UILabel viewFullGamemodeName;
    public UILabel viewFullGamemodeRules;
    public UILabel viewMapName;
    public UILabel labelTimer;
    public UILabel selectGamemodeName;
    public UILabel selectMiniGamemodeName;
    public UILabel selectMiniGamemodeRules;
    public UITexture viewMapTexture;
    public UnityEngine.GameObject viewDescriptionContainer;
    public UnityEngine.GameObject viewDungeonsContainer;
    public UILabel viewDungeonsModeName;
    public UILabel viewDungeonsDescription;
    public UnityEngine.GameObject dungeonsEasyDif;
    public UnityEngine.GameObject dungeonMediumDif;
    public UnityEngine.GameObject dungeonsHardDif;
    public DungeonWindowUI dungeonsUI;
    public MapEventWindowUI viewMapEvent;
    public UnityEngine.GameObject selectGameModeBlocker;
    public UnityEngine.GameObject messagePanel;
    public UnityEngine.GameObject clanWarBlockingPanel;
    public UILabel messageText;
    public UILabel labelNotEngougthTickets;
    public UILabel labelNotEngougthTicketsHost;
    public UILabel blockPanelText;
    public System.Collections.Generic.List<MapPreviewGUI> mapPreviewItems;
    public UnityEngine.GameObject mapPreviewItem;
    public UIScrollView mapsScroll;
    public UIScrollView modesScroll;
    public UnityEngine.GameObject mapsGrid;
    public UnityEngine.GameObject modesWrap;
    public UnityEngine.GameObject miniModesWrap;
    public UITable buttonsTable;
    public bool isActive;
    private bool 丅丛丝下丙且上七万;
    private bool 丁七万丟丆丟不万丗;
    private bool 丟丏丏丂下丐丛丌丘;
    private bool 七三丂业丄丅与丈丄;
    private bool 丘丂下不丕不且丛丏;
    private bool 东专专东丟丈丁丝丟;
    public SquadPlayerPreview[] playerPreviews;
    private System.IDisposable 与丈丘下一七丒东丁;
    private System.IDisposable 丏丑丝丆七丗专专丗;
    private System.IDisposable 丛一东丁上与七不上;
    private UnityEngine.Texture 丗丗丈一世丞丏丙丟;
    private AllScenesForMode 东丅且不丕丝东丘三;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 下丒丏丙一不七丕丏;
    public SquadPlayerPreview siegeLeaderPreview;
    public SquadPlayerPreview playerPreviewItem;
    private System.Collections.Generic.List<SquadPlayerPreview> 一丝丂丝下三与丌业;
    public UIScrollView siegePreviewsScroll;
    public UIGrid siegePreviewsGrid;
    public UnityEngine.GameObject startGameBlock;
    public UILabel startGameBlockLabel;
    public SquadDungeonPopup dungeonPopup;
    private UnityEngine.GameObject 上丂与东丕丛丟业丝;
    private UnityEngine.Vector3 不上丏丘丐丂丘丘丅;
    private int 丟丅丒万丈丆七东且;
    private System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> 下不丘丆丆丕世丌东;
    private System.Collections.Generic.List<SceneInfo> 业不专丛世丄与上丒;
    private string 丂丝丕三东丏三且下;
    private System.Comparison<UnityEngine.Transform> 丝丝世上与丙丗下丏;
    private float 专丆丝东一丑下东丄;
    public bool updatePlayersGrid;
    
    // Methods
    public void HandleChatInputChange()
    {
        var val_3 = (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.chatInput.value))) & 1;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void AddChatMessage(string 不丆业丏上丐与丌业, string 丕丗丘丑丛与丑业丒, string 丛丐丌丙丈七丛丛东, bool 七业丘丁丄且丂七专)
    {
        object val_48;
        var val_49;
        UnityEngine.GameObject val_50;
        string val_51;
        UILabel val_52;
        val_48 = 丕丗丘丑丛与丑业丒;
        if(七业丘丁丄且丂七专 != true)
        {
                val_48 = System.String.Format(format:  "{0}: {1}", arg0:  不丆业丏上丐与丌业, arg1:  val_48);
        }
        
        System.Func<UnityEngine.Transform, System.Collections.Generic.List<UnityEngine.Transform>> val_2 = new System.Func<UnityEngine.Transform, System.Collections.Generic.List<UnityEngine.Transform>>(object:  this, method:  System.Collections.Generic.List<UnityEngine.Transform> SquadPanelGUI::丝丛丕上丞丏丗丅丛(UnityEngine.Transform 丙丒七丄上与丏丙丙));
        val_49 = null.Invoke(arg:  this.chatTable.transform);
        if(val_49.Count == 50)
        {
                UnityEngine.Transform val_6 = val_49.Item[0];
            val_6.parent = 0;
            UnityEngine.Object.Destroy(obj:  val_6.gameObject);
            val_49 = null.Invoke(arg:  this.chatTable.transform);
        }
        
        val_50 = this.chatMessagePrefab.gameObject;
        PrivateMessageItem val_13 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.chatTable.gameObject, 丑且不丕与专丄业丙:  val_50).GetComponent<PrivateMessageItem>();
        val_13.isSquadChat = true;
        if(val_49.Count > 0)
        {
                val_50 = val_49.Count;
            val_51 = (System.Int32.Parse(s:  val_49.Item[val_50 - 1].name)) + 1.ToString();
        }
        else
        {
                val_51 = "0";
        }
        
        val_13.name = val_51;
        bool val_22 = 七业丘丁丄且丂七专;
        float val_24 = this.chatScrollView.GetComponent<UIPanel>().width;
        if(七业丘丁丄且丂七专 == false)
        {
            goto label_27;
        }
        
        val_52 = val_13.otherMessageLabel;
        val_52.text = "";
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丛丐丌丙丈七丛丛东)) == false)
        {
            goto label_31;
        }
        
        val_13.yourMessageLabel.text = val_48;
        val_13.yourMessageLabel.overflowMethod = 3;
        float val_48 = 0.8f;
        val_48 = (float)val_13.yourWidget.width * val_48;
        val_13.yourMessageLabel.width = UnityEngine.Mathf.CeilToInt(f:  val_48);
        val_13.yourSmileSprite.gameObject.SetActive(value:  false);
        goto label_40;
        label_27:
        val_52 = val_13.yourMessageLabel;
        val_52.text = "";
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丛丐丌丙丈七丛丛东)) == false)
        {
            goto label_44;
        }
        
        val_13.otherMessageLabel.text = val_48;
        val_13.otherMessageLabel.overflowMethod = 3;
        float val_49 = 0.8f;
        val_49 = (float)val_13.otherWidget.width * val_49;
        val_13.otherMessageLabel.width = UnityEngine.Mathf.CeilToInt(f:  val_49);
        val_13.otherSmileSprite.gameObject.SetActive(value:  false);
        goto label_53;
        label_31:
        val_52 = val_13.yourSmileSprite;
        val_52.spriteName = 丛丐丌丙丈七丛丛东;
        val_13.yourMessageLabel.text = "";
        val_13.yourMessageLabel.overflowMethod = 0;
        val_13.yourMessageLabel.height = 48;
        val_13.yourMessageLabel.width = 48 + (val_48.Length * 24);
        val_13.yourSmileSprite.gameObject.SetActive(value:  true);
        label_40:
        val_13.yourTimeLabel.text = "";
        goto label_63;
        label_44:
        if(val_48.Length >= 16)
        {
                val_48 = val_48.Substring(startIndex:  0, length:  13)(val_48.Substring(startIndex:  0, length:  13)) + "...";
        }
        
        val_52 = val_13.otherSmileSprite;
        val_52.spriteName = 丛丐丌丙丈七丛丛东;
        val_13.otherMessageLabel.text = val_48;
        val_13.otherMessageLabel.overflowMethod = 0;
        val_13.otherMessageLabel.height = 48;
        val_13.otherMessageLabel.width = (val_48.Length * 22) + 44;
        val_13.otherSmileSprite.gameObject.SetActive(value:  true);
        label_53:
        val_13.otherTimeLabel.text = "";
        label_63:
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_13.gameObject, 不东丛三丂丌丑专丆:  this.chatTable.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        this.丘丏丌丗三丈丒丗丞();
        UnityEngine.Coroutine val_47 = this.StartCoroutine(routine:  this.上丘丕丈下丏且丂丝());
    }
    public void HandleArmoryClicked()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丝丞与丄丆业丛丏专(丗丛不丁丑专专丂且:  false);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = new System.Action(object:  this, method:  public System.Void SquadPanelGUI::HandleResumeFromArmory());
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
    }
    public void HandleResumeFromArmory()
    {
        var val_2;
        var val_4;
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_2 = null;
        val_2 = null;
        if((SquadPanelGUI.<>c.<>9__99_0) == null)
        {
            goto label_5;
        }
        
        label_13:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = SquadPanelGUI.<>c.<>9__99_0;
        val_4 = null;
        val_4 = null;
        SquadController.丄丘七三上丕世丞业.丄丘丘丞万且丅一丈();
        return;
        label_5:
        SquadPanelGUI.<>c.<>9__99_0 = new System.Action(object:  SquadPanelGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SquadPanelGUI.<>c::丁不业万丒丄丑丑丕());
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    public void SendSmile(string 丗丕万丕丌丈丈丒丕)
    {
        var val_4;
        SquadController val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = SquadController.丄丘七三上丕世丞业;
        if(val_5 == 0)
        {
            goto label_5;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = SquadController.丄丘七三上丕世丞业;
        if(val_5.inSquad == false)
        {
            goto label_13;
        }
        
        val_7 = null;
        val_7 = null;
        val_5 = System.String.alignConst;
        SquadController.丄丘七三上丕世丞业.SendChatMessage(丕丗丘丑丛与丑业丒:  val_5, 丛丐丌丙丈七丛丛东:  丗丕万丕丌丈丈丒丕);
        goto label_13;
        label_5:
        UnityEngine.Debug.LogErrorFormat(format:  "Something wrong with SquadController.instance, its null", args:  System.Array.Empty<System.Object>());
        label_13:
        if(this.chatAnimator.isStickersShow == false)
        {
                return;
        }
        
        this.chatAnimator.HideStickers();
    }
    public void ActivatePanel(bool 丅丛丝下丙且上七万, bool 丁七万丟丆丟不万丗, 丛丗丐世下丛丄丞丟 丏东丕与丂丞七业丗)
    {
        var val_45;
        System.Collections.Generic.List<System.String> val_46;
        var val_47;
        System.Func<System.String, System.Boolean> val_49;
        var val_50;
        var val_51;
        var val_52;
        val_45 = null;
        val_45 = null;
        MainMenuController.丂世丗丌丌一丐丝丛 = false;
        if(SquadInviteGUI.丄丘七三上丕世丞业.isActive != true)
        {
                this.gameObject.SetActive(value:  true);
        }
        
        this.七丟万丌且丘世三一();
        this.isActive = true;
        this.专丆丝东一丑下东丄 = 15f;
        this.丅丛丝下丙且上七万 = 丅丛丝下丙且上七万;
        this.丁七万丟丆丟不万丗 = 丁七万丟丆丟不万丗;
        this.丟丏丏丂下丐丛丌丘 = ((丏东丕与丂丞七业丗 - 1) < 3) ? 1 : 0;
        this.七三丂业丄丅与丈丄 = (丏东丕与丂丞七业丗 == 2) ? 1 : 0;
        this.丘丂下不丕不且丛丏 = (丏东丕与丂丞七业丗 == 3) ? 1 : 0;
        this.SetFullStatus(丄丒丆丘丘丂丈世丅:  false);
        val_46 = 1152921524404748272;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_47 = null;
            val_47 = null;
            val_49 = SquadPanelGUI.<>c.<>9__101_0;
            if(val_49 == null)
        {
                System.Func<System.String, System.Boolean> val_14 = null;
            val_49 = val_14;
            val_14 = new System.Func<System.String, System.Boolean>(object:  SquadPanelGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SquadPanelGUI.<>c::丛丕专丈丒专专丁下(string 三丟东丕丄丄下下丑));
            SquadPanelGUI.<>c.<>9__101_0 = val_49;
        }
        
            val_46 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丌丂丑上七丄一且(), predicate:  val_14));
            丂与专万与丐丌丏不.丑七不且上丗丁一世().上丂不东丝且丆丝丝(世丅丈东丘丐丕丟丐:  val_46);
        }
        
        this.invitePlayersBtn.gameObject.SetActive(value:  丁七万丟丆丟不万丗);
        this.buttonsTable.repositionNow = true;
        this.goBtn.gameObject.SetActive(value:  丁七万丟丆丟不万丗);
        this.readyBtn.gameObject.SetActive(value:  (~丁七万丟丆丟不万丗) & 1);
        if(this.startGameBlock != 0)
        {
                this.startGameBlock.SetActive(value:  false);
        }
        
        if(this.miniGamePrice != 0)
        {
                this.miniGamePrice.gameObject.SetActive(value:  false);
        }
        
        if(this.buyTicketsBtn != 0)
        {
                this.buyTicketsBtn.gameObject.SetActive(value:  false);
        }
        
        if(this.labelNotEngougthTickets != 0)
        {
                this.labelNotEngougthTickets.gameObject.SetActive(value:  false);
            this.labelNotEngougthTicketsHost.gameObject.SetActive(value:  false);
        }
        
        if(this.与丈丘下一七丒东丁 == null)
        {
            goto label_45;
        }
        
        if(丁七万丟丆丟不万丗 == false)
        {
            goto label_46;
        }
        
        label_56:
        if(丅丛丝下丙且上七万 == false)
        {
            goto label_47;
        }
        
        UICenterOnChild val_31 = this.miniModesWrap.GetComponent<UICenterOnChild>();
        val_50 = val_31;
        UICenterOnChild.且丐丁世专丝丕丆丁 val_32 = null;
        val_46 = val_32;
        val_32 = new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadPanelGUI::且丞丛与不与丅不丈(UnityEngine.GameObject 东丗丗丕丝世丘业丝));
        val_51 = System.Delegate.Combine(a:  val_31.onCenter, b:  val_32);
        if(val_31 == null)
        {
            goto label_50;
        }
        
        if(val_51 != null)
        {
            goto label_51;
        }
        
        goto label_74;
        label_45:
        System.Action val_35 = null;
        val_46 = val_35;
        val_35 = new System.Action(object:  this, method:  System.Void SquadPanelGUI::丂丏丁与丑丌丞专上());
        this.与丈丘下一七丒东丁 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_35, 与且专丈不万东一万:  "Squad panel");
        if(丁七万丟丆丟不万丗 == true)
        {
            goto label_56;
        }
        
        label_46:
        this.SetEmptyGameMode();
        this.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {与丝丒万且丘丂丟三 = 1});
        val_51 = 0;
        goto label_57;
        label_63:
        this.headerLabels[0].gameObject.SetActive(value:  false);
        val_51 = 1;
        label_57:
        if(val_51 < this.headerLabels.Length)
        {
            goto label_63;
        }
        
        goto label_64;
        label_47:
        UICenterOnChild val_38 = this.modesWrap.GetComponent<UICenterOnChild>();
        val_50 = val_38;
        UICenterOnChild.且丐丁世专丝丕丆丁 val_39 = null;
        val_46 = val_39;
        val_39 = new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadPanelGUI::且丞丛与不与丅不丈(UnityEngine.GameObject 东丗丗丕丝世丘业丝));
        val_51 = System.Delegate.Combine(a:  val_38.onCenter, b:  val_39);
        if(val_38 == null)
        {
            goto label_67;
        }
        
        if(val_51 != null)
        {
            goto label_68;
        }
        
        goto label_74;
        label_50:
        if(val_51 == null)
        {
            goto label_74;
        }
        
        label_51:
        if(null == null)
        {
            goto label_74;
        }
        
        val_52 = 0;
        goto label_72;
        label_67:
        if(val_51 == null)
        {
            goto label_74;
        }
        
        label_68:
        if(null == null)
        {
            goto label_74;
        }
        
        val_52 = 0;
        label_72:
        val_51 = 0;
        label_74:
        mem2[0] = val_51;
        this.SetViewMiniGameGUI(丅丛丝下丙且上七万:  丅丛丝下丙且上七万);
        label_64:
        if(this.丟丏丏丂下丐丛丌丘 != false)
        {
                this.siegePreviewsScroll.disableDragIfFits = true;
        }
        
        if(this.七三丂业丄丅与丈丄 != true)
        {
                this.不七丆丆万下丈业丗();
        }
        
        if(this.丘丂下不丕不且丛丏 != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectClanWarTestEventRaidView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectClanWarTestEventSiegeView, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.dungeonModulesPanel != 0)
        {
                this.dungeonModulesPanel.gameObject.SetActive(value:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cwMineModules, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        null = null;
        SquadPanelGUI.丄丘七三上丕世丞业 = this;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.chatTable, y:  0);
        this.丘丏丌丗三丈丒丗丞();
        if(this.丟丏丏丂下丐丛丌丘 != false)
        {
                this.updatePlayersGrid = true;
        }
        
        MapPopularityController.丅丄不丌丑世且丒七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::不丁不东丄三丏世上()));
    }
    private void OnDisable()
    {
        null = null;
        SquadPanelGUI.丄丘七三上丕世丞业 = 0;
        MapPopularityController.东丝丑专七丑丆丒上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::不丁不东丄三丏世上()));
    }
    private void 不丁不东丄三丏世上()
    {
        List.Enumerator<T> val_1 = this.mapPreviewItems.GetEnumerator();
        label_10:
        if((1416525448 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((val_2 == 0) || (val_2.丅与丌专丟一丝业三().activeInHierarchy == false))
        {
            goto label_10;
        }
        
        val_2.UpdatePopularity();
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void SetFullStatus(bool 丄丒丆丘丘丂丈世丅)
    {
        var val_13;
        bool val_14;
        var val_15;
        var val_16;
        var val_17;
        if((this.丁七万丟丆丟不万丗 != false) && (this.丅丛丝下丙且上七万 != true))
        {
                if(this.七三丂业丄丅与丈丄 == false)
        {
            goto label_3;
        }
        
        }
        
        label_37:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectGameMode, 丏业丟一东丂东丘丛:  (0 != 0) ? 1 : 0);
        if(this.丁七万丟丆丟不万丗 == false)
        {
            goto label_6;
        }
        
        val_13 = 0;
        if((this.丅丛丝下丙且上七万 == true) || (丄丒丆丘丘丂丈世丅 == true))
        {
            goto label_36;
        }
        
        if(this.七三丂业丄丅与丈丄 == false)
        {
            goto label_9;
        }
        
        label_6:
        val_13 = 0;
        label_36:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectStandart, 丏业丟一东丂东丘丛:  (val_13 != 0) ? 1 : 0);
        val_14 = this.丁七万丟丆丟不万丗;
        if(val_14 != false)
        {
                bool val_10 = this.丅丛丝下丙且上七万;
            val_10 = val_10 ^ 1;
            val_14 = val_10 & 255;
        }
        
        val_14 = val_14 & 丄丒丆丘丘丂丈世丅;
        if(val_14 != false)
        {
                if(this.七三丂业丄丅与丈丄 == false)
        {
            goto label_14;
        }
        
        }
        
        val_15 = 0;
        goto label_15;
        label_14:
        bool val_11 = this.丘丂下不丕不且丛丏;
        val_11 = val_11 ^ 1;
        val_15 = val_11 & 255;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectFull, 丏业丟一东丂东丘丛:  (val_15 == true) ? 1 : 0);
        if((this.丁七万丟丆丟不万丗 != false) && (this.丅丛丝下丙且上七万 != false))
        {
                if(this.七三丂业丄丅与丈丄 == false)
        {
            goto label_20;
        }
        
        }
        
        label_35:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectMiniGames, 丏业丟一东丂东丘丛:  (0 != 0) ? 1 : 0);
        val_16 = 0;
        if((this.丁七万丟丆丟不万丗 != true) && (丄丒丆丘丘丂丈世丅 != true))
        {
                if(this.七三丂业丄丅与丈丄 != false)
        {
                val_16 = 0;
        }
        else
        {
                bool val_12 = this.丘丂下不丕不且丛丏;
            val_12 = val_12 ^ 1;
            val_16 = val_12 & 255;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.viewMode, 丏业丟一东丂东丘丛:  (val_16 == true) ? 1 : 0);
        val_17 = 0;
        if((this.丁七万丟丆丟不万丗 != true) && (丄丒丆丘丘丂丈世丅 != false))
        {
                if(this.七三丂业丄丅与丈丄 != false)
        {
                val_17 = 0;
        }
        else
        {
                bool val_13 = this.丘丂下不丕不且丛丏;
            val_13 = val_13 ^ 1;
            val_17 = val_13 & 255;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.viewFull, 丏业丟一东丂东丘丛:  (val_17 == true) ? 1 : 0);
        return;
        label_20:
        bool val_14 = this.丘丂下不丕不且丛丏;
        val_14 = val_14 ^ 1;
        bool val_7 = val_14 & 255;
        goto label_35;
        label_9:
        bool val_15 = this.丘丂下不丕不且丛丏;
        val_15 = val_15 ^ 1;
        bool val_8 = val_15 & 255;
        goto label_36;
        label_3:
        bool val_16 = this.丘丂下不丕不且丛丏;
        val_16 = val_16 ^ 1;
        bool val_9 = val_16 & 255;
        goto label_37;
    }
    public void SetMiniGamesPriceActive(bool 丅丛丝下丙且上七万, int 下专世下且丂东东丁, bool 丅丙丗下丑不丞与丄)
    {
        this.miniGamePrice.SetActive(value:  ((下专世下且丂东东丁 > 0) ? 1 : 0) & 丅丛丝下丙且上七万);
        this.miniGamePriceLabel.text = 下专世下且丂东东丁.ToString();
        bool val_5 = 丅丙丗下丑不丞与丄 ^ 1;
        this.readyBtn.gameObject.SetActive(value:  ((this.丁七万丟丆丟不万丗 == false) ? 1 : 0) & val_5);
        this.goBtn.gameObject.SetActive(value:  ((this.丁七万丟丆丟不万丗 == true) ? 1 : 0) & val_5);
        this.buyTicketsBtn.gameObject.SetActive(value:  丅丙丗下丑不丞与丄);
        this.labelNotEngougthTickets.gameObject.SetActive(value:  丅丙丗下丑不丞与丄);
    }
    public void SetViewMiniGameGUI(bool 丅丛丝下丙且上七万)
    {
        string val_6;
        var val_7;
        this.丅丛丝下丙且上七万 = 丅丛丝下丙且上七万;
        val_7 = 0;
        goto label_1;
        label_12:
        this.headerLabels[0].gameObject.SetActive(value:  true);
        val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.丟丏丏丂下丐丛丌丘 == true) ? "Key_5722" : ((丅丛丝下丙且上七万 != true) ? "Key_3447" : "Key_3445"));
        this.headerLabels[0].text = val_6;
        val_7 = 1;
        label_1:
        if(val_7 < this.headerLabels.Length)
        {
            goto label_12;
        }
    
    }
    public void ClearChat()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        Clear();
        val_3 = null;
        val_3 = null;
        ChatController.丙万专丗丈丅业丘丅.Clear();
        不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this.chatTable.transform);
    }
    public void UpdateStartTimer(bool 丛与丙丒丒下丌丟且, float 丙业与丙丗丝不丈东 = 0)
    {
        UILabel val_7;
        bool val_7 = 丛与丙丒丒下丌丟且;
        val_7 = this;
        val_7 = ((丙业与丙丗丝不丈东 > 0f) ? 1 : 0) & val_7;
        this.labelTimer.gameObject.SetActive(value:  val_7);
        if(val_7 == false)
        {
                return;
        }
        
        val_7 = this.labelTimer;
        val_7.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3476"), arg0:  UnityEngine.Mathf.FloorToInt(f:  丙业与丙丗丝不丈东).ToString());
    }
    public void UpdateSquadInfo(SquadController.万丅世丈丕丕丌丅丗 丁三上丂丅丏丏丁丕, System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 丛一丆专世丝丄丒与)
    {
        bool val_34;
        var val_35;
        bool val_36;
        var val_37;
        int val_38;
        if(this.丟丏丏丂下丐丛丌丘 == false)
        {
            goto label_1;
        }
        
        if(this.siegeLeaderPreview == null)
        {
            goto label_2;
        }
        
        if(丁三上丂丅丏丏丁丕 == null)
        {
            goto label_3;
        }
        
        label_57:
        this.siegeLeaderPreview.gameObject.SetActive(value:  true);
        val_34 = this.丁七万丟丆丟不万丗;
        this.siegeLeaderPreview.Fill(东一丁世丑丞业丄丐:  丁三上丂丅丏丏丁丕, 不丏且丑丆丌三世丈:  (val_34 == true) ? 1 : 0);
        if(丛一丆专世丝丄丒与 != null)
        {
            goto label_60;
        }
        
        label_61:
        label_60:
        val_35 = 1152921540384267808;
        int val_5 = 丛一丆专世丝丄丒与.Count - this.一丝丂丝下三与丌业.Count;
        if(val_5 >= 1)
        {
                val_36 = "D2";
            do
        {
            UnityEngine.GameObject val_10 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.playerPreviewItem.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.playerPreviewItem.gameObject);
            val_10.SetActive(value:  true);
            int val_11 = this.一丝丂丝下三与丌业.Count;
            val_34 = val_10.GetComponent<SquadPlayerPreview>();
            this.一丝丂丝下三与丌业.Add(item:  val_34);
            val_10.name = this.一丝丂丝下三与丌业.Count + 1.ToString(format:  "D2")(this.一丝丂丝下三与丌业.Count + 1.ToString(format:  "D2")) + "_playerPreview";
            val_5 = val_5 - 1;
        }
        while(val_5 != 0);
        
        }
        
        val_37 = 0;
        goto label_22;
        label_36:
        val_34 = this.一丝丂丝下三与丌业.Item[0];
        if(val_37 < 丛一丆专世丝丄丒与.Count)
        {
                val_34.gameObject.SetActive(value:  true);
            val_36 = this.丁七万丟丆丟不万丗;
            val_34 = 丛一丆专世丝丄丒与.Item[0];
            this.一丝丂丝下三与丌业.Item[0].Fill(东一丁世丑丞业丄丐:  val_34, 不丏且丑丆丌三世丈:  (val_36 == true) ? 1 : 0);
        }
        else
        {
                val_34.Clear(世丒丝东上丕七世且:  false);
            this.一丝丂丝下三与丌业.Item[0].gameObject.SetActive(value:  false);
        }
        
        val_37 = 1;
        label_22:
        if(val_37 < this.一丝丂丝下三与丌业.Count)
        {
            goto label_36;
        }
        
        val_38 = this.丟丅丒万丈丆七东且;
        if(val_38 == 丛一丆专世丝丄丒与.Count)
        {
                return;
        }
        
        this.丟丅丒万丈丆七东且 = 丛一丆专世丝丄丒与.Count;
        this.siegePreviewsScroll.ResetPosition();
        return;
        label_1:
        val_34 = this.丁七万丟丆丟不万丗;
        this.playerPreviews[0].Fill(东一丁世丑丞业丄丐:  丁三上丂丅丏丏丁丕, 不丏且丑丆丌三世丈:  (val_34 == true) ? 1 : 0);
        val_35 = 1152921540349734000;
        val_38 = 0;
        goto label_46;
        label_56:
        val_36 = (long)(long)(int)(W26);
        SquadPlayerPreview val_36 = this.playerPreviews[val_36];
        if(丛一丆专世丝丄丒与.Count < W26)
        {
                val_34 = this.丁七万丟丆丟不万丗;
            val_36.Clear(世丒丝东上丕七世且:  (val_34 == true) ? 1 : 0);
        }
        else
        {
                val_34 = 丛一丆专世丝丄丒与.Item[0];
            val_36.Fill(东一丁世丑丞业丄丐:  val_34, 不丏且丑丆丌三世丈:  (this.丁七万丟丆丟不万丗 == true) ? 1 : 0);
        }
        
        val_38 = 1;
        label_46:
        if((val_38 + 1) < this.playerPreviews.Length)
        {
            goto label_56;
        }
        
        return;
        label_2:
        if(丁三上丂丅丏丏丁丕 != null)
        {
            goto label_57;
        }
        
        label_3:
        this.siegeLeaderPreview.Clear(世丒丝东上丕七世且:  false);
        this.siegeLeaderPreview.gameObject.SetActive(value:  false);
        if(丛一丆专世丝丄丒与 != null)
        {
            goto label_60;
        }
        
        goto label_61;
    }
    internal void 丐丂上丑丛不丞丞丄()
    {
        this.不七丆丆万下丈业丗();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectClanWarTestEventRaidView, 丏业丟一东丂东丘丛:  true);
    }
    internal void 且东丂东丗且不七下()
    {
        this.不七丆丆万下丈业丗();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectClanWarTestEventSiegeView, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丒下丒丏丂丌丞东丝(PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘)
    {
        object val_14;
        PGCompany.ClanWarSquadTaskView val_15;
        var val_16;
        UnityEngine.GameObject val_17;
        if(丌丝万上丅丒一丈丘 == null)
        {
            goto label_1;
        }
        
        if(this.selectClanWarTaskView != 0)
        {
            goto label_4;
        }
        
        val_14 = "Clan War Squad View is Null";
        goto label_7;
        label_1:
        val_14 = "Cell is Null";
        label_7:
        UnityEngine.Debug.LogError(message:  val_14);
        return;
        label_4:
        this.不七丆丆万下丈业丗();
        if((丌丝万上丅丒一丈丘.下下丟丛万丟下上丟() == false) || (丌丝万上丅丒一丈丘.下三下东业丘且丟业().七一丈丁专丞丛丟丌() == false))
        {
            goto label_12;
        }
        
        PGCompany.GameTaskActionSettings val_7 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_7.Type != 52)
        {
            goto label_16;
        }
        
        PGCompany.GameTaskActionSettings val_10 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_10.GameMode == 26)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.silverMineSiegeClanWarTaskView, 丏业丟一东丂东丘丛:  true);
            this.silverMineSiegeClanWarTaskView.丞丝丈丅丅丅丆丕丝(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘);
        }
        
        PGCompany.GameTaskActionSettings val_13 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_13.GameMode != 27)
        {
            goto label_27;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.silverMineRaidClanWarTaskView, 丏业丟一东丂东丘丛:  true);
        val_15 = this.silverMineRaidClanWarTaskView;
        if(val_15 != null)
        {
            goto label_37;
        }
        
        goto label_31;
        label_12:
        this.不七丆丆万下丈业丗();
        val_16 = 1;
        val_17 = this.selectClanWarTaskUnavailableView;
        goto label_34;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarTaskView, 丏业丟一东丂东丘丛:  true);
        val_15 = this.selectClanWarTaskView;
        if(val_15 != null)
        {
            goto label_37;
        }
        
        label_31:
        label_37:
        val_15.丞丝丈丅丅丅丆丕丝(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘);
        label_27:
        val_17 = this.selectClanWarTaskUnavailableView;
        val_16 = 0;
        label_34:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarEventRaidView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarEventSiegeView, 丏业丟一东丂东丘丛:  false);
    }
    private void 不七丆丆万下丈业丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarTaskView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectClanWarTaskUnavailableView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarEventRaidView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarEventSiegeView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.silverMineSiegeClanWarTaskView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.silverMineRaidClanWarTaskView, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丄专丂丙丑一世丞不(PGCompany.丟与丞丗丌丂万丕丝 且世上丙与丐一丛业)
    {
        object val_5;
        if(且世上丙与丐一丛业 == null)
        {
            goto label_1;
        }
        
        if(this.selectClanWarTaskView != 0)
        {
            goto label_4;
        }
        
        val_5 = "Clan War Squad View is Null";
        goto label_7;
        label_1:
        val_5 = "Event is Null";
        label_7:
        UnityEngine.Debug.LogError(message:  val_5);
        return;
        label_4:
        this.不七丆丆万下丈业丗();
        PGCompany.丂不上丗与丌与丐丌 val_2 = 且世上丙与丐一丛业.不业丙丒丂丞下丆丙();
        if(val_2 != 1)
        {
                if(val_2 != 2)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarEventRaidView, 丏业丟一东丂东丘丛:  true);
            this.selectClanWarEventRaidView.世丈丕丌万丌丗丐丈(丐丘丌三丏与丙且东:  (null == null) ? 且世上丙与丐一丛业 : 0);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectClanWarEventSiegeView, 丏业丟一东丂东丘丛:  true);
        this.selectClanWarEventSiegeView.世丈丕丌万丌丗丐丈(丐丘丌三丏与丙且东:  (null == null) ? 且世上丙与丐一丛业 : 0);
    }
    public void UpdateSquadTicketsInfo(System.Collections.Generic.List<SquadController.万丅世丈丕丕丌丅丗> 丛一丆专世丝丄丒与, int 丒丈上丄不丁与与一)
    {
        if(this.丟丏丏丂下丐丛丌丘 != false)
        {
                return;
        }
        
        this.labelNotEngougthTicketsHost.gameObject.SetActive(value:  false);
    }
    public void SetAvaliableSlots(int 丒丆丛上东丝三丟世)
    {
        var val_10;
        SquadPlayerPreview[] val_11;
        var val_12;
        SquadController.万丅世丈丕丕丌丅丗 val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.丟丏丏丂下丐丛丌丘 == false)
        {
            goto label_1;
        }
        
        val_10 = 1152921540384267808;
        val_11 = 0;
        goto label_16;
        label_20:
        SquadPlayerPreview val_2 = this.一丝丂丝下三与丌业.Item[0];
        if(val_11 >= (丒丆丛上东丝三丟世 - 1))
        {
            goto label_4;
        }
        
        SquadPlayerPreview val_3 = this.一丝丂丝下三与丌业.Item[0];
        if(val_3.东一丁世丑丞业丄丐 == null)
        {
            goto label_7;
        }
        
        val_12 = null;
        val_12 = null;
        SquadPlayerPreview val_4 = this.一丝丂丝下三与丌业.Item[0];
        val_13 = val_4.东一丁世丑丞业丄丐;
        val_14 = SquadController.丄丘七三上丕世丞业.世专三丒丙丗丘丆万(专丞上七七且丝七丗:  val_13);
        if(val_2 != null)
        {
            goto label_17;
        }
        
        goto label_18;
        label_4:
        val_14 = 0;
        if(val_2 != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        val_2.SetAvaliable(世丆丞一业三一丅与:  false);
        val_11 = 1;
        goto label_16;
        label_7:
        if(val_2 != null)
        {
            goto label_17;
        }
        
        goto label_18;
        label_16:
        if(val_11 < this.一丝丂丝下三与丌业.Count)
        {
            goto label_20;
        }
        
        return;
        label_1:
        val_13 = 1;
        goto label_44;
        label_52:
        if(val_13 >= 丒丆丛上东丝三丟世)
        {
            goto label_23;
        }
        
        SquadPlayerPreview val_10 = this.playerPreviews[1];
        if(this.playerPreviews[0x1][0].东一丁世丑丞业丄丐 == null)
        {
            goto label_27;
        }
        
        val_15 = null;
        val_15 = null;
        SquadPlayerPreview val_11 = this.playerPreviews[1];
        val_16 = SquadController.丄丘七三上丕世丞业.世专三丒丙丗丘丆万(专丞上七七且丝七丗:  this.playerPreviews[0x1][0].东一丁世丑丞业丄丐);
        goto label_35;
        label_23:
        val_16 = 0;
        goto label_35;
        label_27:
        val_16 = 1;
        label_35:
        val_10 = 1;
        this.playerPreviews[val_10].SetAvaliable(世丆丞一业三一丅与:  true);
        UnityEngine.GameObject val_8 = this.playerPreviews[val_10].gameObject;
        if(val_16 == 0)
        {
            goto label_42;
        }
        
        if(val_8 != null)
        {
            goto label_49;
        }
        
        label_50:
        label_49:
        val_8.SetActive(value:  true);
        val_13 = 2;
        goto label_44;
        label_42:
        SquadPlayerPreview val_14 = this.playerPreviews[val_10];
        UnityEngine.GameObject val_15 = this.playerPreviews[0x1][0].playerContainer;
        val_15 = val_15.activeSelf;
        if(val_8 != null)
        {
            goto label_49;
        }
        
        goto label_50;
        label_44:
        val_11 = this.playerPreviews;
        if(val_13 < this.playerPreviews.Length)
        {
            goto label_52;
        }
    
    }
    public void SetDungeonAvaliableByProgress(bool 世丆丞一业三一丅与, int 上丕丈丞丌丘丅不与)
    {
        int val_5;
        string val_6;
        val_5 = 上丕丈丞丌丘丅不与;
        val_6 = 世丆丞一业三一丅与;
        if(this.startGameBlock != 0)
        {
                this.startGameBlock.SetActive(value:  (~val_6) & 1);
        }
        
        if(val_6 == true)
        {
                return;
        }
        
        val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081");
        val_5 = System.String.Format(format:  val_6, arg0:  val_5);
        this.startGameBlockLabel.text = val_5;
    }
    public void SetDungeonAvaliableByModules(bool 世丆丞一业三一丅与)
    {
        if(this.startGameBlock != 0)
        {
                this.startGameBlock.SetActive(value:  (~世丆丞一业三一丅与) & 1);
        }
        
        if(世丆丞一业三一丅与 != false)
        {
                return;
        }
        
        this.startGameBlockLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7327");
    }
    public void DeactivatePanel()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = 1152921505324683264;
        if((SquadInviteGUI.丄丘七三上丕世丞业 != 0) && (SquadInviteGUI.丄丘七三上丕世丞业.isActive != false))
        {
                SquadInviteGUI.丄丘七三上丕世丞业.DectivatePanel();
        }
        
        val_11 = null;
        val_11 = null;
        FriendInviteInfoContainer.一且丕丙丆丟丙七丒.Clear();
        if(this.丁七万丟丆丟不万丗 == false)
        {
            goto label_10;
        }
        
        if(this.丅丛丝下丙且上七万 == false)
        {
            goto label_11;
        }
        
        val_10 = this.miniModesWrap.GetComponent<UICenterOnChild>();
        val_12 = val_10;
        val_13 = System.Delegate.Remove(source:  val_2.onCenter, value:  new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadPanelGUI::且丞丛与不与丅不丈(UnityEngine.GameObject 东丗丗丕丝世丘业丝)));
        if(val_10 == null)
        {
            goto label_14;
        }
        
        if(val_13 != null)
        {
            goto label_15;
        }
        
        goto label_26;
        label_11:
        val_10 = this.modesWrap.GetComponent<UICenterOnChild>();
        val_12 = val_10;
        val_13 = System.Delegate.Remove(source:  val_5.onCenter, value:  new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SquadPanelGUI::且丞丛与不与丅不丈(UnityEngine.GameObject 东丗丗丕丝世丘业丝)));
        if(val_10 == null)
        {
            goto label_19;
        }
        
        if(val_13 != null)
        {
            goto label_20;
        }
        
        goto label_26;
        label_14:
        if(val_13 == null)
        {
            goto label_26;
        }
        
        label_15:
        if(null == null)
        {
            goto label_26;
        }
        
        val_14 = 0;
        goto label_24;
        label_19:
        if(val_13 == null)
        {
            goto label_26;
        }
        
        label_20:
        if(null == null)
        {
            goto label_26;
        }
        
        val_14 = 0;
        label_24:
        val_13 = 0;
        label_26:
        mem2[0] = val_13;
        label_10:
        this.丑丂丒上东丙丟丕三();
        this.gameObject.SetActive(value:  false);
        this.isActive = false;
    }
    private void 丂丏丁与丑丌丞专上()
    {
        this.丂丏丁与丑丌丞专上(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 丂丏丁与丑丌丞专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_6;
        UnityEngine.Object val_7;
        val_6 = null;
        val_6 = null;
        SquadController.丄丘七三上丕世丞业.ExitFromSquadPanel();
        val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_7.丝且丗丌丟丈世上万() == null)
        {
                return;
        }
        
        Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  0);
    }
    private void 丏丛世丄世丟丆丄丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.OpenInvitePanel();
    }
    private void 丞一丝不万丞下丐丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.StartGame();
    }
    private void 与业一七七丘世丗丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.SendReady();
    }
    private void 丒丑万专专上与专万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丁七万丟丆丟不万丗 != false)
        {
                this.丞一丝不万丞下丐丁(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
            return;
        }
        
        this.与业一七七丘世丗丕(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
    }
    private System.Collections.IEnumerator 上丘丕丈下丏且丂丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SquadPanelGUI.丘丅丙丆一丑下丂丈();
    }
    private void 丘丏丌丗三丈丒丗丞()
    {
        if(this.chatScrollView == 0)
        {
                return;
        }
        
        this.chatScrollView.ResetPosition();
        this = ???;
        goto typeof(UIScrollView).__il2cppRuntimeField_1E8;
    }
    private void 丕上丕丙万丅一丈一()
    {
        this.丕上丕丙万丅一丈一(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 丆丏丐专丑专丁专与()
    {
        this.丆丏丐专丑专丁专与(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 丆丏丐专丑专丁专与(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_1;
        this.丞丅专丌业丗专丛不();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanWarBlockingPanel, 丏业丟一东丂东丘丛:  false);
        val_1 = null;
        val_1 = null;
        SquadController.丄丘七三上丕世丞业.ExitFromSquadPanel();
    }
    private void 丕上丕丙万丅一丈一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.MessagePanelButtonClick();
    }
    private void 且丞丛与不与丅不丈(UnityEngine.GameObject 东丗丗丕丝世丘业丝)
    {
        var val_15;
        var val_16;
        val_15 = 0;
        goto label_1;
        label_15:
        UnityEngine.GameObject val_3 = this.modesWrap.transform.GetChild(index:  0).gameObject;
        val_3.transform.GetChild(index:  0).GetComponent<UISprite>().spriteName = (val_3 != 1) ? "green_btn" : "yell_btn";
        val_3.transform.GetChild(index:  0).GetComponent<UIButton>().normalSprite = (val_3 != 1) ? "green_btn" : "yell_btn";
        val_15 = 1;
        label_1:
        if(val_15 < this.modesWrap.transform.childCount)
        {
            goto label_15;
        }
        
        val_16 = null;
        val_16 = null;
        SquadGamemodeSelect val_14 = 东丗丗丕丝世丘业丝.GetComponent<SquadGamemodeSelect>();
        SquadController.丄丘七三上丕世丞业.丗丆丄专上七丛丕上(丂丛丑东不丅丈一东:  val_14.gameMode, 丁丅丟丒丙丐丅与丂:  false);
    }
    private UnityEngine.Texture 丂丐业丘丑丒三万丒(string 七丆丂丂下丈且丟世)
    {
        var val_9;
        var val_10;
        if((this.下丒丏丙一不七丕丏.ContainsKey(key:  七丆丂丂下丈且丟世)) != false)
        {
                val_9 = this.下丒丏丙一不七丕丏.Item[七丆丂丂下丈且丟世];
            return (UnityEngine.Texture);
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Loading_{1}"("LevelLoadingsPreview{0}/Loading_{1}") + (SquadController.丄丘七三上丕世丞业.东丏丒且丁丆丄上丐() == 20) ? "_squad" : ""((SquadController.丄丘七三上丕世丞业.东丏丒且丁丆丄上丐() == 20) ? "_squad" : ""), arg0:  this.丂丝丕三东丏三且下, arg1:  七丆丂丂下丈且丟世));
        val_9 = 0;
        if( == 0)
        {
                return (UnityEngine.Texture);
        }
        
        this.下丒丏丙一不七丕丏.Add(key:  七丆丂丂下丈且丟世, value:  null);
        return (UnityEngine.Texture);
    }
    public void SetEmptyGameMode()
    {
        this.viewGamemodeName.text = "";
        this.viewGamemodeRules.text = "";
        this.viewFullGamemodeName.text = "";
        this.viewFullGamemodeRules.text = "";
    }
    internal void 世上万不丐丄丂且万(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_8;
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_8 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]);
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_8 = 0;
        string val_7 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丕丒上东丞丕丞一三.Item[???]);
        this.viewGamemodeName.text = val_4;
        this.viewDungeonsModeName.text = val_4;
        this.viewGamemodeRules.text = val_7;
        this.viewFullGamemodeName.text = val_4;
        this.viewFullGamemodeRules.text = val_7;
        if(this.doubleRewardObject == 0)
        {
                return;
        }
        
        this.doubleRewardObject.SetActive(value:  false);
    }
    internal void 七丘业丟丝三丝专丟(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_8;
        var val_9;
        var val_9 = 0;
        val_9 = val_9 + 1;
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]);
        if(this.丅丛丝下丙且上七万 != false)
        {
                val_8 = 0;
            this.selectMiniGamemodeName.text = val_4;
            val_9 = null;
            val_9 = null;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_8 = 0;
        }
        else
        {
                this.selectGamemodeName.text = val_4;
            if(this.doubleRewardObject == 0)
        {
                return;
        }
        
            this.doubleRewardObject.SetActive(value:  false);
            return;
        }
        
        this.selectMiniGamemodeRules.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丕丒上东丞丕丞一三.Item[???]);
    }
    internal void 万专丂东与万丈与丘(SquadController.丛且丏丑丕丘丒丞且 丞丁丑丏丄丏七丂不)
    {
        string val_17;
        var val_34;
        UnityEngine.Texture val_35;
        var val_36;
        var val_37;
        val_34 = this;
        if(丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅 != 0)
        {
            goto label_3;
        }
        
        this.viewMapName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2463");
        val_35 = this.丗丗丈一世丞丏丙丟;
        label_84:
        if(this.viewDescriptionContainer != 0)
        {
                this.viewDescriptionContainer.SetActive(value:  true);
        }
        
        if(this.viewMapEvent == 0)
        {
            goto label_72;
        }
        
        this.viewMapEvent.gameObject.SetActive(value:  false);
        goto label_72;
        label_3:
        val_36 = null;
        val_36 = null;
        if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.indexMap)) != false)
        {
                if(this.viewDescriptionContainer != 0)
        {
                this.viewDescriptionContainer.SetActive(value:  false);
        }
        
            if(this.viewMapEvent != 0)
        {
                this.viewMapEvent.gameObject.SetActive(value:  false);
        }
        
            if(this.viewDungeonsContainer != 0)
        {
                this.viewDungeonsContainer.SetActive(value:  true);
        }
        
            UnityEngine.Texture val_12 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.丙且上丒不下丑下丞());
            this.viewMapName.text = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.七丛一丛专七丈丅专();
            PGCompany.丗丟丄丈东丝丕丄世 val_14 = DungeonWindowUI.丄上且丏丅丞丂丙上(丒万丟丅丌丝丟下下:  1423386976);
            this.dungeonsUI.上东与丛丞下丈专丈(下丞七丒业丂丈丘下:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.indexMap, 丏丒与一上丂三丂丑:  0);
            this.dungeonsUI.SetDifficulty(丒万丟丅丌丝丟下下:  1423386976);
            if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.indexMap)) != false)
        {
                val_37 = null;
            val_37 = null;
            万丗且专万丟丌丂丐 val_16 = DungeonWindowUI.dungeonsInfo.Item[丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.indexMap];
            this.viewDungeonsDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_17);
        }
        
            this.dungeonsEasyDif.gameObject.SetActive(value:  (1423386976 == 1) ? 1 : 0);
            val_35 = this.dungeonMediumDif.gameObject;
            val_35.SetActive(value:  (1423386976 == 2) ? 1 : 0);
            val_34 = this.dungeonsHardDif.gameObject;
            val_34.SetActive(value:  (1423386976 == 3) ? 1 : 0);
            return;
        }
        
        if(丞丁丑丏丄丏七丂不.丐且丘丑与万丞丑丅 == null)
        {
            goto label_62;
        }
        
        UnityEngine.Texture val_25 = 丞丁丑丏丄丏七丂不.丐且丘丑与万丞丑丅.丒与世三丗七丒不且();
        this.viewMapName.text = 丞丁丑丏丄丏七丂不.丐且丘丑与万丞丑丅.东丙上东业丆不丟丘();
        if(this.viewDescriptionContainer != 0)
        {
                this.viewDescriptionContainer.SetActive(value:  false);
        }
        
        val_35 = this.viewMapEvent;
        if(val_35 != 0)
        {
                this.viewMapEvent.gameObject.SetActive(value:  true);
            val_35 = this.viewMapEvent;
            val_35.上东与丛丞下丈专丈(丐且丘丑与万丞丑丅:  丞丁丑丏丄丏七丂不.丐且丘丑与万丞丑丅, 丛一丆专世丝丄丒与:  false);
        }
        
        label_72:
        if(this.viewDungeonsContainer == 0)
        {
                return;
        }
        
        this.viewDungeonsContainer.SetActive(value:  false);
        return;
        label_62:
        UnityEngine.Texture val_32 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.丙且上丒不下丑下丞());
        this.viewMapName.text = 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅.七丛一丛专七丈丅专();
        goto label_84;
    }
    internal void 丏丛不丘丆丙丄三丛(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_10;
        var val_11;
        var val_12;
        UnityEngine.Object val_13;
        val_10 = 丂丛丑东不丅丈一东;
        val_11 = this;
        val_12 = 0;
        goto label_1;
        label_9:
        SquadGamemodeSelect val_3 = this.modesWrap.transform.GetChild(index:  0).GetComponent<SquadGamemodeSelect>();
        if(val_3.gameMode == val_10)
        {
            goto label_6;
        }
        
        val_12 = 1;
        label_1:
        if(val_12 < this.modesWrap.transform.childCount)
        {
            goto label_9;
        }
        
        val_13 = 0;
        goto label_10;
        label_6:
        val_10 = this.modesWrap.transform;
        val_13 = val_10.GetChild(index:  0);
        label_10:
        if(val_13 == 0)
        {
                return;
        }
        
        val_11 = this.modesWrap.GetComponent<UICenterOnChild>();
        if(val_11 != null)
        {
                val_10 = val_11;
            val_9.springStrength = -1.175494E-38f;
            val_11.CenterOn(丞下万上三丘上与专:  val_13);
        }
        else
        {
                val_10 = 24;
            mem[24] = 2155872256;
            val_11.CenterOn(丞下万上三丘上与专:  val_13);
        }
        
        mem[24] = 1090519040;
    }
    public void CenterOnMode(UnityEngine.GameObject 丘丕丘丘东丗丑七丂)
    {
        if(this.丅丛丝下丙且上七万 == false)
        {
            goto label_1;
        }
        
        if(this.miniModesWrap != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.miniModesWrap.GetComponent<UICenterOnChild>().CenterOn(丞下万上三丘上与专:  丘丕丘丘东丗丑七丂.transform);
        return;
        label_1:
        if(this.modesWrap != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    internal void 三东七丄丆丞丌上丗(SquadController.丛且丏丑丕丘丒丞且 丞丁丑丏丄丏七丂不)
    {
        goto label_1;
        label_22:
        MapPreviewGUI val_1 = this.mapPreviewItems.Item[0];
        if(val_1.上丂东丗丝丈业万丅 == 丞丁丑丏丄丏七丂不.丏丈丗世丙万丆丐丅)
        {
                MapPreviewGUI val_3 = this.mapPreviewItems.Item[0];
            MapPreviewGUI val_4 = this.mapPreviewItems.Item[0];
            this.mapPreviewItems.Item[0].GetComponent<UIToggle>().Set(丏业丟一东丂东丘丛:  true);
            this.丗三丁丑丞丝东丛且(丞丁丑丏丄丏七丂不:  this.mapPreviewItems.Item[0]);
        }
        else
        {
                this.mapPreviewItems.Item[0].GetComponent<UIToggle>().Set(丏业丟一东丂东丘丛:  false);
        }
        
        0 = 1;
        label_1:
        if(0 < this.mapPreviewItems.Count)
        {
            goto label_22;
        }
        
        this.mapsScroll.ResetPosition();
    }
    public void ResetSelectedMapList()
    {
        null = null;
        MapPreviewGUI val_1 = this.mapPreviewItems.Item[0];
        SquadController.丄丘七三上丕世丞业.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = val_1.上丂东丗丝丈业万丅, 丐且丘丑与万丞丑丅 = val_1.上丂东丗丝丈业万丅, 与丝丒万且丘丂丟三 = SquadController.__il2cppRuntimeField_static_fields});
        MapPreviewGUI val_2 = this.mapPreviewItems.Item[0];
        this.三东七丄丆丞丌上丗(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = val_2.上丂东丗丝丈业万丅, 丐且丘丑与万丞丑丅 = val_2.上丂东丗丝丈业万丅, 与丝丒万且丘丂丟三 = SquadController.__il2cppRuntimeField_static_fields});
    }
    internal void 丗丒下丛丏丛丆丅东(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_62;
        var val_63;
        AllScenesForMode val_64;
        var val_65;
        Rilisoft.七丕丟丏三丈一丄世 val_66;
        var val_70;
        var val_71;
        var val_72;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        System.Collections.Generic.List<MapPreviewGUI> val_78;
        System.Collections.Generic.List<SceneInfo> val_79;
        var val_80;
        var val_81;
        var val_82;
        int val_83;
        var val_84;
        val_62 = 丂丛丑东不丅丈一东;
        val_63 = null;
        val_63 = null;
        val_64 = 0;
        if(SceneInfoController.丄丘七三上丕世丞业 != 0)
        {
                val_65 = null;
            val_65 = null;
            val_64 = SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_62);
        }
        
        this.东丅且不丕丝东丘三 = val_64;
        if(val_64 == null)
        {
            goto label_10;
        }
        
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_4 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  val_62, 丞丁丑丏丄丏七丂不:  0);
        this.下不丘丆丆丕世丌东.Clear();
        if(val_4 == null)
        {
            goto label_58;
        }
        
        var val_66 = 0;
        val_66 = val_66 + 1;
        val_66 = val_62;
        goto label_17;
        label_10:
        UnityEngine.Debug.LogError(message:  "modeInfo == null");
        return;
        label_17:
        System.Collections.Generic.IEnumerator<T> val_6 = val_4.GetEnumerator();
        label_40:
        var val_67 = 0;
        val_67 = val_67 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_25;
        }
        
        var val_68 = 0;
        val_68 = val_68 + 1;
        T val_10 = val_6.Current;
        if((val_10 == 0) || ((System.String.IsNullOrEmpty(value:  val_10.丕丆丞丂业东与上丅())) == true))
        {
            goto label_40;
        }
        
        val_70 = null;
        val_70 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_10.丕丆丞丂业东与上丅())) == 0)
        {
            goto label_40;
        }
        
        this.下不丘丆丆丕世丌东.Add(item:  val_10);
        goto label_40;
        label_25:
        val_71 = 0;
        val_72 = 0;
        val_62 = ;
        if(val_6 == null)
        {
            
        }
        else
        {
                var val_69 = 0;
            val_69 = val_69 + 1;
            val_6.Dispose();
        }
        
        label_58:
        this.业不专丛世丄与上丒.Clear();
        val_74 = 0;
        goto label_61;
        label_89:
        if(X24 == 0)
        {
            goto label_65;
        }
        
        val_75 = 0;
        goto label_63;
        label_79:
        val_75 = 1;
        label_63:
        if(val_75 >= this.下不丘丆丆丕世丌东.Count)
        {
            goto label_65;
        }
        
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_18 = this.下不丘丆丆丕世丌东.Item[1];
        if(val_18.丁东丒七与丄业丟丕() == false)
        {
            goto label_79;
        }
        
        val_76 = null;
        val_76 = null;
        SceneInfo val_21 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_18.丕丆丞丂业东与上丅());
        if((val_21 == 0) || (val_21 != this.东丅且不丕丝东丘三.avaliableScenes.Item[0]))
        {
            goto label_79;
        }
        
        goto label_85;
        label_65:
        val_77 = null;
        val_77 = null;
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  SceneInfoController.丄丘七三上丕世丞业.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  null, 东下丌丝且七丛丘丒:  this.东丅且不丕丝东丘三.avaliableScenes.Item[0], 丁丏丗且上丗下与下:  true))) != false)
        {
                this.业不专丛世丄与上丒.Add(item:  this.东丅且不丕丝东丘三.avaliableScenes.Item[0]);
        }
        
        label_85:
        val_74 = 1;
        label_61:
        if(val_74 < this.东丅且不丕丝东丘三.avaliableScenes.Count)
        {
            goto label_89;
        }
        
        this.下不丘丆丆丕世丌东.Clear();
        int val_30 = this.业不专丛世丄与上丒.Count;
        var val_32 = ( == 22) ? (val_30 + (val_30 << 1)) : (val_30);
        int val_35 = val_32 + this.下不丘丆丆丕世丌东.Count;
        val_35 = val_35 + 1;
        val_32 = val_35 - this.mapPreviewItems.Count;
        if(val_32 >= 1)
        {
                do
        {
            UnityEngine.GameObject val_36 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.mapsGrid, 丑且不丕与专丄业丙:  this.mapPreviewItem);
            if(val_36 != null)
        {
                val_36.SetActive(value:  true);
            val_78 = this.mapPreviewItems;
        }
        else
        {
                0.SetActive(value:  true);
            val_78 = this.mapPreviewItems;
        }
        
            val_78.Add(item:  val_36.GetComponent<MapPreviewGUI>());
            val_32 = val_32 - 1;
        }
        while(val_32 != 0);
        
            UIGrid val_38 = this.mapsGrid.GetComponent<UIGrid>();
        }
        
        Rilisoft.七丕丟丏三丈一丄世 val_70 = ;
        val_79 = 0;
        val_70 = val_70 | 2;
        if(val_70 != 22)
        {
                if((this.下不丘丆丆丕世丌东.Count + this.业不专丛世丄与上丒.Count) >= 2)
        {
                this.mapPreviewItems.Item[0].gameObject.SetActive(value:  true);
            this.丑下丁丏上丏世丁与(丑与丅东万丟世丄丌:  this.mapPreviewItems.Item[0]);
            val_79 = 1;
        }
        
        }
        
        val_80 = 0;
        goto label_111;
        label_123:
        val_81 = null;
        val_81 = null;
        this.mapPreviewItems.Item[1].gameObject.SetActive(value:  true);
        this.万七上且丏丆丂七与(丑与丅东万丟世丄丌:  this.mapPreviewItems.Item[1], 丄不东丁丂丅万丒丟:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  this.下不丘丆丆丕世丌东.Item[0].丕丆丞丂业东与上丅()), 丐且丘丑与万丞丑丅:  this.下不丘丆丆丕世丌东.Item[0], 与丝丒万且丘丂丟三:  0);
        val_80 = 1;
        label_111:
        if(val_80 < this.下不丘丆丆丕世丌东.Count)
        {
            goto label_123;
        }
        
        val_82 = 0;
        val_83 = val_79 + val_80;
        goto label_124;
        label_139:
        if( == 22)
        {
                丐七不丝丆丐丂丐下 val_71 = 0;
            do
        {
            int val_53 = val_83 + val_71;
            this.mapPreviewItems.Item[val_53].gameObject.SetActive(value:  true);
            val_79 = this.业不专丛世丄与上丒;
            val_71 = val_71 + 1;
            this.万七上且丏丆丂七与(丑与丅东万丟世丄丌:  this.mapPreviewItems.Item[val_53], 丄不东丁丂丅万丒丟:  val_79.Item[0], 丐且丘丑与万丞丑丅:  0, 与丝丒万且丘丂丟三:  val_71);
        }
        while(val_71 != 3);
        
            val_84 = 3;
        }
        else
        {
                this.mapPreviewItems.Item[val_83].gameObject.SetActive(value:  true);
            this.万七上且丏丆丂七与(丑与丅东万丟世丄丌:  this.mapPreviewItems.Item[val_83], 丄不东丁丂丅万丒丟:  this.业不专丛世丄与上丒.Item[0], 丐且丘丑与万丞丑丅:  0, 与丝丒万且丘丂丟三:  0);
            val_84 = 1;
        }
        
        val_83 = val_83 + val_84;
        val_82 = 1;
        label_124:
        if(val_82 < this.业不专丛世丄与上丒.Count)
        {
            goto label_139;
        }
        
        goto label_140;
        label_145:
        this.mapPreviewItems.Item[val_83].gameObject.SetActive(value:  false);
        val_83 = val_83 + 1;
        label_140:
        if(val_83 < this.mapPreviewItems.Count)
        {
            goto label_145;
        }
        
        this.ResetSelectedMapList();
    }
    public void ShowMessagePanel(string 丕丗丘丑丛与丑业丒, bool 丄丂丑丆丞丗业专丗, bool 丝丕且世下一东与业)
    {
        this.messagePanel.SetActive(value:  true);
        this.messageText.text = 丕丗丘丑丛与丑业丒;
        this.messageButtonOk.gameObject.SetActive(value:  丝丕且世下一东与业 ^ 1 & 丄丂丑丆丞丗业专丗);
        this.messageButtonCancel.gameObject.SetActive(value:  丄丂丑丆丞丗业专丗 & 丝丕且世下一东与业);
        if(丄丂丑丆丞丗业专丗 != false)
        {
                this.丏丑丝丆七丗专专丗 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::丕上丕丙万丅一丈一()), 与且专丈不万东一万:  "Squad message panel");
            return;
        }
        
        this.丆丕七万丞丁专专且();
    }
    public void HideMessagePanel()
    {
        this.丆丕七万丞丁专专且();
        this.messagePanel.SetActive(value:  false);
    }
    internal void 丞丆丕丞丝丝丌丆丗(string 丕丗丘丑丛与丑业丒)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanWarBlockingPanel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.blockPanelText, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        this.丛一东丁上与七不上 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::丆丏丐专丑专丁专与()), 与且专丈不万东一万:  "Clan War Squad blocked action panel");
    }
    private void 万七上且丏丆丂七与(MapPreviewGUI 丑与丅东万丟世丄丌, SceneInfo 丄不东丁丂丅万丒丟, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅, 丐七不丝丆丐丂丐下 与丝丒万且丘丂丟三 = 0)
    {
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        丐七不丝丆丐丂丐下 val_27 = 与丝丒万且丘丂丟三;
        if(丐且丘丑与万丞丑丅 == null)
        {
            goto label_2;
        }
        
        if((System.String.IsNullOrEmpty(value:  丐且丘丑与万丞丑丅.东丙上东业丆不丟丘())) == false)
        {
            goto label_3;
        }
        
        string val_5 = "#e " + 丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七().ToString();
        goto label_6;
        label_2:
        string val_6 = 丄不东丁丂丅万丒丟.七丛一丛专七丈丅专();
        goto label_6;
        label_3:
        label_6:
        丑与丅东万丟世丄丌.mapName.text = 丐且丘丑与万丞丑丅.东丙上东业丆不丟丘();
        if((丐且丘丑与万丞丑丅 == null) || (丐且丘丑与万丞丑丅.丒与世三丗七丒不且() == 0))
        {
            goto label_11;
        }
        
        UnityEngine.Texture val_10 = 丐且丘丑与万丞丑丅.丒与世三丗七丒不且();
        if(丑与丅东万丟世丄丌.mapTexture != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_11:
        UnityEngine.Texture val_12 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  丄不东丁丂丅万丒丟.丙且上丒不下丑下丞());
        label_13:
        val_27 = null;
        val_27 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.team, 丏业丟一东丂东丘丛:  (SquadController.丄丘七三上丕世丞业.东丏丒且丁丆丄上丐() == 20) ? 1 : 0);
        if(丐且丘丑与万丞丑丅 != null)
        {
                val_28 = 丐且丘丑与万丞丑丅;
            int val_15 = val_28.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_28 = 0;
        }
        
        丑与丅东万丟世丄丌.上丂东丗丝丈业万丅 = 丄不东丁丂丅万丒丟;
        mem2[0] = 丐且丘丑与万丞丑丅;
        mem2[0] = val_27;
        mem2[0] = val_28;
        SquadController val_25 = SquadController.丄丘七三上丕世丞业;
        val_25 = ((val_27 == 1) ? 1 : 0) & ((val_25.东丏丒且丁丆丄上丐() == 22) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.easyDifficulty, 丏业丟一东丂东丘丛:  val_25);
        val_29 = null;
        val_29 = null;
        SquadController val_26 = SquadController.丄丘七三上丕世丞业;
        val_26 = ((val_27 == 2) ? 1 : 0) & ((val_26.东丏丒且丁丆丄上丐() == 22) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.mediumDifficulty, 丏业丟一东丂东丘丛:  val_26);
        val_30 = null;
        val_30 = null;
        val_27 = ((val_27 == 3) ? 1 : 0) & ((SquadController.丄丘七三上丕世丞业.东丏丒且丁丆丄上丐() == 22) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.hardDifficulty, 丏业丟一东丂东丘丛:  val_27);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.bottomPanel, 丏业丟一东丂东丘丛:  true);
        丑与丅东万丟世丄丌.UpdateMapSize();
        丑与丅东万丟世丄丌.UpdatePopularity();
    }
    private void 丑下丁丏上丏世丁与(MapPreviewGUI 丑与丅东万丟世丄丌)
    {
        丑与丅东万丟世丄丌.mapName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2463");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.team, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.easyDifficulty, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.mediumDifficulty, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.hardDifficulty, 丏业丟一东丂东丘丛:  false);
        丑与丅东万丟世丄丌.上丂东丗丝丈业万丅 = 0;
        mem2[0] = 0;
        mem2[0] = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑与丅东万丟世丄丌.bottomPanel, 丏业丟一东丂东丘丛:  false);
        丑与丅东万丟世丄丌.UpdatePopularity();
        丑与丅东万丟世丄丌.UpdateMapSize();
    }
    private void Awake()
    {
        var val_12;
        System.Action val_13;
        System.Action val_14;
        var val_15;
        if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != false)
        {
                val_12 = "/Hi";
        }
        
        this.丂丝丕三东丏三且下 = System.String.__il2cppRuntimeField_static_fields;
        if(this.mapPreviewItem != 0)
        {
                this.mapPreviewItems.Add(item:  this.mapPreviewItem.GetComponent<MapPreviewGUI>());
        }
        
        val_13 = System.Delegate.Combine(a:  this.chatInput.onKeyboardVisible, b:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::丌丂丛丐东丞万专七()));
        if(this.chatInput == null)
        {
            goto label_12;
        }
        
        if(val_13 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_13 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_16:
        this.chatInput.onKeyboardVisible = val_13;
        val_14 = System.Delegate.Combine(a:  this.chatInput.onKeyboardHide, b:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::丟丐丂三丐丐不三丐()));
        if(this.chatInput == null)
        {
            goto label_18;
        }
        
        if(val_14 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_14 == null)
        {
            goto label_22;
        }
        
        label_19:
        if(null != null)
        {
                val_14 = 0;
        }
        
        label_22:
        this.chatInput.onKeyboardHide = val_14;
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Random_Map", arg0:  this.丂丝丕三东丏三且下));
        val_15 = 0;
        this.丗丗丈一世丞丏丙丟 = ;
        this.chatTable.onCustomSort = this.丝丝世上与丙丗下丏;
    }
    public void HandleSmileButton()
    {
        bool val_2;
        ChatAnimator val_3;
        val_2 = this;
        if(StickersController.不丕丗且丝与七丗丒() == false)
        {
            goto label_3;
        }
        
        val_3 = this.chatAnimator;
        if(val_3 == null)
        {
            goto label_4;
        }
        
        if(this.chatAnimator.isStickersShow == false)
        {
            goto label_10;
        }
        
        label_9:
        val_3.HideStickers();
        return;
        label_3:
        this.stickersShopBanner.SetActive(value:  true);
        return;
        label_4:
        val_2 = this.chatAnimator.isStickersShow;
        if(this.chatAnimator == null)
        {
            goto label_7;
        }
        
        val_3 = this.chatAnimator;
        if(val_2 == true)
        {
            goto label_9;
        }
        
        label_10:
        val_3.ShowStickers();
        return;
        label_7:
        if(val_2 == true)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    public void HandleStickersShopButton()
    {
        this.stickersShopBanner.SetActive(value:  true);
    }
    public void HandleSendMesssage()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        if(SquadController.丄丘七三上丕世丞业 != 0)
        {
                val_6 = null;
            val_6 = null;
            if(SquadController.丄丘七三上丕世丞业.inSquad == false)
        {
                return;
        }
        
            val_7 = null;
            val_7 = null;
            SquadController.丄丘七三上丕世丞业.SendChatMessage(丕丗丘丑丛与丑业丒:  this.chatInput.value, 丛丐丌丙丈七丛丛东:  System.String.alignConst);
            this.chatInput.value = System.String.alignConst;
            return;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "Something wrong with SquadController.instance, its null", args:  System.Array.Empty<System.Object>());
    }
    internal void 丗三丁丑丞丝东丛且(MapPreviewGUI 丞丁丑丏丄丏七丂不)
    {
        int val_4;
        string val_5;
        int val_6;
        丒丗专丝三与丑丏三[] val_7;
        丐七不丝丆丐丂丐下 val_22;
        丛且丏丑丕丘丒丞且 val_23;
        var val_24;
        var val_25;
        UnityEngine.GameObject val_26;
        val_22 = 丞丁丑丏丄丏七丂不;
        this.七丟万丌且丘世三一();
        val_23 = 丞丁丑丏丄丏七丂不.上丂东丗丝丈业万丅;
        if(val_23 == 0)
        {
                return;
        }
        
        if(this.丁七万丟丆丟不万丗 == false)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        val_23 = DungeonWindowUI.dungeonsInfo;
        if((val_23.ContainsKey(key:  mem[丞丁丑丏丄丏七丂不.上丂东丗丝丈业万丅 + 56])) == false)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        万丗且专万丟丌丂丐 val_3 = DungeonWindowUI.dungeonsInfo.Item[mem[丞丁丑丏丄丏七丂不.上丂东丗丝丈业万丅 + 56]];
        if(this.dungeonPopup == 0)
        {
                UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  "Raids/DungeonModuleTipPopup");
            if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_26 = 0;
        }
        
            this.dungeonPopup = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  val_26).GetComponent<SquadDungeonPopup>();
            val_13.hideBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::下丑丐丟丙丘丞丝一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        this.dungeonPopup.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_18 = 丞丁丑丏丄丏七丂不.tipPoint.transform.position;
        this.dungeonPopup.transform.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        this.上丂与东丕丛丟业丝 = 丞丁丑丏丄丏七丂不.tipPoint;
        val_23 = 丞丁丑丏丄丏七丂不.tipPoint.transform;
        UnityEngine.Vector3 val_20 = val_23.position;
        this.不上丏丘丐丂丘丘丅 = val_20;
        mem[1152921540393706412] = val_20.y;
        mem[1152921540393706416] = val_20.z;
        val_4 = val_4;
        val_5 = val_5;
        val_6 = val_6;
        val_7 = val_7;
        this.dungeonPopup.上东与丛丞下丈专丈(东一丁世丑丞业丄丐:  new 万丗且专万丟丌丂丐() {下丞七丒业丂丈丘下 = val_6, 不丙且丄上且万丙丞 = val_6, 专丆丌丞丙丅丌丄丕 = val_7, 丙丌七三与丟世与且 = val_7, 丁丝丗丛丆丛且丈上 = val_7, 下丝丒丕丅丆丐丑丁 = val_4, 丆丁东七专与丞与上 = val_4, 丄上七业丅丅丕业三 = val_4, 万世且上上东三万专 = val_4, 丈丐丆丛上丕丌上世 = val_5, 下一不一丁丟丄丑丒 = val_5}, 丒万丟丅丌丝丟下下:  val_22);
    }
    private void 下丑丐丟丙丘丞丝一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.七丟万丌且丘世三一();
    }
    private void 七丟万丌且丘世三一()
    {
        if(this.dungeonPopup != 0)
        {
                this.dungeonPopup.gameObject.SetActive(value:  false);
        }
        
        this.上丂与东丕丛丟业丝 = 0;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.不上丏丘丐丂丘丘丅 = val_3;
        mem[1152921540394114732] = val_3.y;
        mem[1152921540394114736] = val_3.z;
    }
    private void 丌丂丛丐东丞万专七()
    {
        float val_4;
        if(UnityEngine.Application.isEditor != false)
        {
                val_4 = 200f;
        }
        else
        {
                val_4 = this.chatInput.GetKeyboardHeight();
        }
        
        float val_3 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_3 = val_4 / val_3;
        this.chatAnimator.KeyBoardHeight = (int)val_3;
        this.chatAnimator.ShowKeyboard();
        this.HandleChatInputChange();
    }
    private void 丟丐丂三丐丐不三丐()
    {
        this.chatAnimator.HideKeyboard();
    }
    private void Start()
    {
        System.EventHandler val_21;
        var val_22;
        if(this.backBtn != 0)
        {
                System.EventHandler val_2 = null;
            val_21 = val_2;
            val_2 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丂丏丁与丑丌丞专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.backBtn.add_Clicked(丙业与丙丗丝不丈东:  val_2);
        }
        
        if(this.invitePlayersBtn != 0)
        {
                System.EventHandler val_4 = null;
            val_21 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丏丛世丄世丟丆丄丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.invitePlayersBtn.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        if(this.goBtn != 0)
        {
                System.EventHandler val_6 = null;
            val_21 = val_6;
            val_6 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丞一丝不万丞下丐丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.goBtn.add_Clicked(丙业与丙丗丝不丈东:  val_6);
        }
        
        if(this.readyBtn != 0)
        {
                System.EventHandler val_8 = null;
            val_21 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::与业一七七丘世丗丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.readyBtn.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        if(this.buyTicketsBtn != 0)
        {
                System.EventHandler val_10 = null;
            val_21 = val_10;
            val_10 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丒丑万专专上与专万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.buyTicketsBtn.add_Clicked(丙业与丙丗丝不丈东:  val_10);
        }
        
        if(this.messageButtonOk != 0)
        {
                System.EventHandler val_12 = null;
            val_21 = val_12;
            val_12 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丕上丕丙万丅一丈一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.messageButtonOk.add_Clicked(丙业与丙丗丝不丈东:  val_12);
        }
        
        if(this.messageButtonCancel != 0)
        {
                System.EventHandler val_14 = null;
            val_21 = val_14;
            val_14 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丕上丕丙万丅一丈一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.messageButtonCancel.add_Clicked(丙业与丙丗丝不丈东:  val_14);
        }
        
        if(this.blockButtonOk != 0)
        {
                System.EventHandler val_16 = null;
            val_21 = val_16;
            val_16 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丆丏丐专丑专丁专与(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.blockButtonOk.add_Clicked(丙业与丙丗丝不丈东:  val_16);
        }
        
        if(this.丟丏丏丂下丐丛丌丘 != false)
        {
                if(this.playerPreviewItem == 0)
        {
                return;
        }
        
            this.playerPreviewItem.btnAddPlayer.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丏丛世丄世丟丆丄丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            return;
        }
        
        val_22 = 0;
        goto label_39;
        label_47:
        val_21 = this.playerPreviews[0];
        if(this.playerPreviews[0x0][0].btnAddPlayer != 0)
        {
                System.EventHandler val_20 = null;
            val_21 = val_20;
            val_20 = new System.EventHandler(object:  this, method:  System.Void SquadPanelGUI::丏丛世丄世丟丆丄丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.playerPreviews[0x0][0].btnAddPlayer.add_Clicked(丙业与丙丗丝不丈东:  val_20);
        }
        
        val_22 = 1;
        label_39:
        if(val_22 < this.playerPreviews.Length)
        {
            goto label_47;
        }
    
    }
    private void Update()
    {
        var val_17;
        var val_18;
        bool val_19;
        var val_20;
        var val_21;
        var val_22;
        val_17 = null;
        val_17 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(this.readyBtn != 0)
        {
                UIButton val_3 = this.readyBtn.GetComponent<UIButton>();
            val_18 = null;
            val_18 = null;
            val_19 = SquadController.丄丘七三上丕世丞业.丅丝丗丙丝业业丟业();
            bool val_5 = val_19;
        }
        
        if(this.goBtn != 0)
        {
                UIButton val_7 = this.goBtn.GetComponent<UIButton>();
            val_20 = null;
            val_20 = null;
            val_19 = SquadController.丄丘七三上丕世丞业.丘丌丄丝丆丑丌丞丏();
            bool val_9 = val_19;
        }
        
        if(this.selectGameModeBlocker != 0)
        {
                val_21 = null;
            val_21 = null;
            if((((this.东专专东丟丈丁丝丟 == true) ? 1 : 0) ^ SquadController.丄丘七三上丕世丞业.BlockGameModeSelect) != false)
        {
                val_22 = null;
            val_22 = null;
            val_19 = SquadController.丄丘七三上丕世丞业.BlockGameModeSelect;
            this.东专专东丟丈丁丝丟 = val_19;
            this.selectGameModeBlocker.SetActive(value:  val_19);
        }
        
        }
        
        float val_15 = UnityEngine.Time.unscaledDeltaTime;
        val_15 = this.专丆丝东一丑下东丄 + val_15;
        this.专丆丝东一丑下东丄 = val_15;
        this.七丈三万且丟丈与丄();
    }
    private void 七丈三万且丟丈与丄()
    {
        SquadController val_5;
        var val_6;
        var val_7;
        var val_8;
        string val_9;
        object val_10;
        var val_11;
        var val_12;
        if(this.专丆丝东一丑下东丄 < 0)
        {
                return;
        }
        
        this.专丆丝东一丑下东丄 = 0f;
        val_6 = null;
        val_6 = null;
        val_5 = SquadController.丄丘七三上丕世丞业;
        if(val_5 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_7 = null;
        if(this.丟丏丏丂下丐丛丌丘 != false)
        {
                val_8 = null;
            val_9 = mem[SquadController.丄丘七三上丕世丞业 + 232];
            val_9 = SquadController.丄丘七三上丕世丞业.squadRoomName;
            val_10 = "clan_id";
        }
        else
        {
                val_11 = null;
            val_9 = mem[SquadController.丄丘七三上丕世丞业 + 232];
            val_9 = SquadController.丄丘七三上丕世丞业.squadRoomName;
            val_10 = "squad_id";
        }
        
        val_2.set_Item(key:  val_10, value:  val_9);
        val_12 = null;
        val_12 = null;
        int val_4 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.不丝丂一与丘三业丂, 一丐丗丁丞丆丅丟丄:  val_2);
    }
    private void LateUpdate()
    {
        if((this.丟丏丏丂下丐丛丌丘 != false) && (this.updatePlayersGrid != false))
        {
                this.updatePlayersGrid = false;
        }
        
        if(this.上丂与东丕丛丟业丝 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.上丂与东丕丛丟业丝.transform.position;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.不上丏丘丐丂丘丘丅, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == false)
        {
                return;
        }
        
        this.七丟万丌且丘世三一();
    }
    private void OnDestroy()
    {
        System.Action val_6;
        System.Action val_7;
        val_6 = System.Delegate.Remove(source:  this.chatInput.onKeyboardVisible, value:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::丌丂丛丐东丞万专七()));
        if(this.chatInput == null)
        {
            goto label_2;
        }
        
        if(val_6 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_6 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_6:
        this.chatInput.onKeyboardVisible = val_6;
        val_7 = System.Delegate.Remove(source:  this.chatInput.onKeyboardHide, value:  new System.Action(object:  this, method:  System.Void SquadPanelGUI::丟丐丂三丐丐不三丐()));
        if(this.chatInput == null)
        {
            goto label_8;
        }
        
        if(val_7 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_7 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_12:
        this.chatInput.onKeyboardHide = val_7;
        this.丑丂丒上东丙丟丕三();
        this.丆丕七万丞丁专专且();
        this.丞丅专丌业丗专丛不();
    }
    private void 丑丂丒上东丙丟丕三()
    {
        if(this.与丈丘下一七丒东丁 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.与丈丘下一七丒东丁.Dispose();
        this.与丈丘下一七丒东丁 = 0;
    }
    private void 丆丕七万丞丁专专且()
    {
        if(this.丏丑丝丆七丗专专丗 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丏丑丝丆七丗专专丗.Dispose();
        this.丏丑丝丆七丗专专丗 = 0;
    }
    private void 丞丅专丌业丗专丛不()
    {
        if(this.丛一东丁上与七不上 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丛一东丁上与七不上.Dispose();
        this.丛一东丁上与七不上 = 0;
    }
    public SquadPanelGUI()
    {
        var val_6;
        System.Comparison<UnityEngine.Transform> val_8;
        this.下丒丏丙一不七丕丏 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        this.一丝丂丝下三与丌业 = new System.Collections.Generic.List<SquadPlayerPreview>();
        this.下不丘丆丆丕世丌东 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
        this.业不专丛世丄与上丒 = new System.Collections.Generic.List<SceneInfo>();
        val_6 = null;
        val_6 = null;
        val_8 = SquadPanelGUI.<>c.<>9__173_0;
        if(val_8 == null)
        {
                System.Comparison<UnityEngine.Transform> val_5 = null;
            val_8 = val_5;
            val_5 = new System.Comparison<UnityEngine.Transform>(object:  SquadPanelGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 SquadPanelGUI.<>c::丗丄下丈丒丑丌丞丐(UnityEngine.Transform 三丟东丕丄丄下下丑, UnityEngine.Transform 丒丒丄丁且丄丆丂丌));
            SquadPanelGUI.<>c.<>9__173_0 = val_8;
        }
        
        this.丝丝世上与丙丗下丏 = val_8;
    }
    private static SquadPanelGUI()
    {
    
    }
    private System.Collections.Generic.List<UnityEngine.Transform> 丝丛丕上丞丏丗丅丛(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        UnityEngine.Object val_6;
        var val_7;
        val_6 = 丙丒七丄上与丏丙丙;
        System.Collections.Generic.List<UnityEngine.Transform> val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
        if(val_6 == 0)
        {
                return val_1;
        }
        
        val_7 = 0;
        goto label_4;
        label_11:
        UnityEngine.Transform val_3 = val_6.GetChild(index:  0);
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                val_1.Add(item:  val_3);
        }
        
        val_7 = 1;
        label_4:
        if(val_7 < val_6.childCount)
        {
            goto label_11;
        }
        
        val_6 = this.丝丝世上与丙丗下丏;
        val_1.Sort(comparison:  val_6);
        return val_1;
    }

}
