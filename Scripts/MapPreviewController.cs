using UnityEngine;
public sealed class MapPreviewController : MonoBehaviour
{
    // Fields
    private readonly string[] 丝东七一丗丐七丙下;
    public SceneInfo curSceneInfo;
    public UILabel NameMapLbl;
    public UILabel GameModeLabel;
    public UILabel DescriptionLabel;
    public UILabel SizeMapLabel;
    public UILabel popularityLabel;
    public UISprite popularitySprite;
    public UnityEngine.GameObject premium;
    public UnityEngine.GameObject milee;
    public UnityEngine.GameObject dater;
    public UnityEngine.GameObject arcade;
    public UnityEngine.GameObject single;
    public UnityEngine.GameObject team;
    public UnityEngine.GameObject newMap;
    public int mapID;
    public string sceneMapName;
    public UITexture mapPreviewTexture;
    public UnityEngine.GameObject bottomPanel;
    public UnityEngine.GameObject eventContainerDefault;
    public UnityEngine.GameObject eventContainerRating;
    public UILabel eventTime;
    public UITable eventTimeTable;
    public UILabel eventTimeForRating;
    public UnityEngine.GameObject eventDarkMask;
    internal UnityEngine.GameObject eventContainerTournament;
    internal UILabel tournamentEventTime;
    internal UnityEngine.GameObject eventTournamentDarkMask;
    public UnityEngine.GameObject topTimerContainer;
    public UILabel topTimer;
    public UnityEngine.GameObject minigamesContainer;
    public UITexture[] minigamesRatingStars;
    public UnityEngine.GameObject flagCaptureIcon;
    public UnityEngine.GameObject capturePointsIcon;
    public UnityEngine.GameObject teamDuelIcon;
    public UnityEngine.GameObject duelIcon;
    public UnityEngine.GameObject deathmatchIcon;
    public UnityEngine.GameObject teamFightIcon;
    public UnityEngine.GameObject siegeIcon;
    public UnityEngine.Transform captureIconEventPosition;
    public UnityEngine.Transform captureIconNormalPosition;
    public UnityEngine.GameObject clanWarIconObject;
    public UnityEngine.Transform hintPointLeft;
    public UnityEngine.Transform hintPointCenter;
    public UnityEngine.Transform hintPointRight;
    internal int 业上与丏上丑丘上下;
    private MyCenterOnChild 丈与丐丗丞不且三丟;
    public bool squadMode;
    internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    public LockerSquadButton Locker;
    internal bool 三一丛丙丙七丆世三;
    private bool 丑丛专丌三丅丟三丛;
    internal Rilisoft.七丕丟丏三丈一丄世 业丒与丐不丘七业丒;
    internal Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑;
    private UnityEngine.GameObject sizeMapContainer;
    private int _ratingVal;
    internal PGCompany.世丐下丕专东丘丏且 一丟丛三丞丁丐且丘;
    internal PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘;
    public SetHeadLabelText timeLeftLabel;
    internal UnityEngine.GameObject rotationGameModeContainer;
    internal UnityEngine.GameObject rotationGameModeNotAvalible;
    internal UITable rotationGameModeNowNotAvalible;
    internal PGCompany.TimerUI rotationGameModeTimer;
    private bool 丞丏丈东不丕不丕丁;
    private bool 丁不丑丄丒丂七丌一;
    
    // Properties
    private int 丂业丌业丂万三丛丄 { get; set; }
    
    // Methods
    private int 丏三世七东丒万丕丅()
    {
        return (int)this._ratingVal;
    }
    private void 一七与丁丏丄不世丄(int 丙业与丙丗丝不丈东)
    {
        var val_8;
        UnityEngine.GameObject val_9;
        this._ratingVal = 丙业与丙丗丝不丈东;
        if((丙业与丙丗丝不丈东 & 2147483648) != 0)
        {
            goto label_1;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_2;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_8 = ((val_1.HasValue.丙东专丂世丈丏丁丂() != 4) ? 1 : 0) | 1152921530910565289;
        goto label_3;
        label_1:
        val_9 = this.popularitySprite.gameObject;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
        return;
        label_2:
        val_8 = 1;
        label_3:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.popularitySprite.gameObject, 丏业丟一东丂东丘丛:  val_8 & 1);
        val_9 = System.String.Format(format:  "Nb_Players_{0}", arg0:  this._ratingVal);
        this.popularitySprite.spriteName = val_9;
    }
    private void Start()
    {
        this.丑上丒世世丑世业万();
    }
    private void 丑上丒世世丑世业万()
    {
        var val_12;
        UnityEngine.Object val_13;
        val_12 = this;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  108)) != true)
        {
                if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  52)) == false)
        {
                return;
        }
        
        }
        
        val_13 = this.gameObject.GetComponent<TagSystem.CompoundTagBehaviour>();
        if(val_13 == 0)
        {
                val_13 = this.gameObject.AddComponent<TagSystem.CompoundTagBehaviour>();
        }
        
        val_12 = val_13.丐丂丒丅上与丂丗且();
        if((val_12.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "ConnectSceneMapPreview")) != false)
        {
                return;
        }
        
        val_13.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  "ConnectSceneMapPreview");
    }
    internal void 与丆丅万与丛东三丈(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, UnityEngine.Texture 丗丗丈一世丞丏丙丟)
    {
        this.业丞丟万不丄丂丘丑 = 业丞丟万不丄丂丘丑;
        this.一丟丛三丞丁丐且丘 = 0;
        this.curSceneInfo = 0;
        this.NameMapLbl.GetComponent<SetHeadLabelText>().SetText(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2463"));
        this.bottomPanel.SetActive(value:  false);
        this.minigamesContainer.SetActive(value:  false);
        this.mapID = 0;
        this.sceneMapName = "Random";
        this.SetLockerObjects();
        this.TurnOffLabels();
        if(this.clanWarIconObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanWarIconObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丐且丘丑与万丞丑丅 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerDefault, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerRating, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerTournament, 丏业丟一东丂东丘丛:  false);
        this.丑丛专丌三丅丟三丛 = false;
        this.flagCaptureIcon.SetActive(value:  false);
        this.capturePointsIcon.SetActive(value:  false);
        this.与下丙丆不上丞丌一(丏丛与丅丛丌万专丌:  false);
        this.newMap.SetActive(value:  false);
    }
    internal void 不丕且丑七丐与丒丐(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, UnityEngine.Texture 丅丘丘三三丒不业且)
    {
        this.业丞丟万不丄丂丘丑 = 业丞丟万不丄丂丘丑;
        this.一丟丛三丞丁丐且丘 = 0;
        this.curSceneInfo = 0;
        this.NameMapLbl.GetComponent<SetHeadLabelText>().SetText(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3377"));
        this.bottomPanel.SetActive(value:  false);
        this.minigamesContainer.SetActive(value:  false);
        this.mapID = -2;
        this.sceneMapName = "Squad";
        this.SetLockerObjects();
        this.TurnOffLabels();
        this.Locker.CanDisableCkicks = false;
        if(this.clanWarIconObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanWarIconObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丐且丘丑与万丞丑丅 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerDefault, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerRating, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerTournament, 丏业丟一东丂东丘丛:  false);
        this.丑丛专丌三丅丟三丛 = false;
        this.flagCaptureIcon.SetActive(value:  false);
        this.capturePointsIcon.SetActive(value:  false);
        this.与下丙丆不上丞丌一(丏丛与丅丛丌万专丌:  false);
        this.newMap.SetActive(value:  false);
    }
    internal void 丐丝万丈丞业丙丐丆(string 七丆丂丂下丈且丟世)
    {
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  "LevelLoadings" + (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : ""((东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "") + "/Loading_"("/Loading_") + 七丆丂丂下丈且丟世);
        if(this.mapPreviewTexture == null)
        {
            goto label_3;
        }
        
        if(val_4 == null)
        {
            goto typeof(UITexture).__il2cppRuntimeField_2E8;
        }
        
        label_6:
        var val_5 = (null == null) ? (val_4) : 0;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
        label_3:
        if(val_4 != null)
        {
            goto label_6;
        }
        
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
    }
    internal void 世丕且丞丙业丕一丅(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, SceneInfo 丄不东丁丂丅万丒丟)
    {
        var val_5;
        this.业丞丟万不丄丂丘丑 = 业丞丟万不丄丂丘丑;
        this.一丟丛三丞丁丐且丘 = 0;
        val_5 = static_value_081DACA8;
        val_5 = static_value_081DACA8;
        UnityEngine.Texture val_2 = static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  丄不东丁丂丅万丒丟.丙且上丒不下丑下丞());
        this.curSceneInfo = 丄不东丁丂丅万丒丟;
        this.SetMapPreviewTitle();
        this.bottomPanel.SetActive(value:  false);
        this.minigamesContainer.SetActive(value:  false);
        this.mapID = (业丞丟万不丄丂丘丑 != 17) ? ((-5) + 1) : -5;
        this.sceneMapName = "Locked by level";
        this.Locker.CanDisableCkicks = false;
        this.SetLockerObjects();
        this.TurnOffLabels();
        if(this.clanWarIconObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanWarIconObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丐且丘丑与万丞丑丅 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerDefault, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerRating, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerTournament, 丏业丟一东丂东丘丛:  false);
        this.丑丛专丌三丅丟三丛 = false;
        this.flagCaptureIcon.SetActive(value:  false);
        this.capturePointsIcon.SetActive(value:  false);
        this.与下丙丆不上丞丌一(丏丛与丅丛丌万专丌:  false);
        this.newMap.SetActive(value:  false);
    }
    private void 与下丙丆不上丞丌一(bool 丏丛与丅丛丌万专丌)
    {
        UnityEngine.GameObject val_9 = this.teamDuelIcon;
        if(val_9 != 0)
        {
                val_9 = this.teamDuelIcon;
            val_9.SetActive(value:  丏丛与丅丛丌万专丌);
        }
        
        if(this.duelIcon != 0)
        {
                this.duelIcon.SetActive(value:  false);
        }
        
        if(this.teamFightIcon != 0)
        {
                this.teamFightIcon.SetActive(value:  false);
        }
        
        if(this.deathmatchIcon != 0)
        {
                this.deathmatchIcon.SetActive(value:  false);
        }
        
        if(this.capturePointsIcon != 0)
        {
                this.capturePointsIcon.SetActive(value:  false);
        }
        
        if(this.flagCaptureIcon != 0)
        {
                this.flagCaptureIcon.SetActive(value:  false);
        }
        
        if(this.siegeIcon == 0)
        {
                return;
        }
        
        this.siegeIcon.SetActive(value:  false);
    }
    internal void 丏丛与业丆丝世丒丗()
    {
        if(this.curSceneInfo == 0)
        {
                return;
        }
        
        if(this.SizeMapLabel == 0)
        {
                return;
        }
        
        this.SizeMapLabel.gameObject.SetActive(value:  true);
        if(this.curSceneInfo.sizeMap > 3)
        {
                return;
        }
        
        var val_9 = 106029772 + (this.curSceneInfo.sizeMap) << 2;
        val_9 = val_9 + 106029772;
        goto (106029772 + (this.curSceneInfo.sizeMap) << 2 + 106029772);
    }
    internal void 上东与丛丞下丈专丈(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, SceneInfo 丄不东丁丂丅万丒丟, bool 丗丂世丗丄不丟丘万, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 专且丆东且丁丂丝上, bool 丈三丆丏丄三丏丛丒 = False)
    {
        object val_130;
        UnityEngine.GameObject val_131;
        float val_135;
        float val_136;
        float val_137;
        var val_138;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_139;
        var val_140;
        var val_141;
        var val_142;
        bool val_132 = 丈三丆丏丄三丏丛丒;
        val_130 = this;
        this.业丞丟万不丄丂丘丑 = 业丞丟万不丄丂丘丑;
        this.与下丙丆不上丞丌一(丏丛与丅丛丌万专丌:  false);
        this.一丟丛三丞丁丐且丘 = 0;
        if(专且丆东且丁丂丝上 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 专且丆东且丁丂丝上.丌不丅不丞东万专专();
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "Fill map tourment status -> {0}", arg0:  val_1.HasValue));
        }
        
        if(this.minigamesContainer != 0)
        {
                this.minigamesContainer.SetActive(value:  false);
        }
        
        this.curSceneInfo = 丄不东丁丂丅万丒丟;
        if((专且丆东且丁丂丝上 != null) && (专且丆东且丁丂丝上.丒与世三丗七丒不且() != 0))
        {
                UnityEngine.Texture val_6 = 专且丆东且丁丂丝上.丒与世三丗七丒不且();
        }
        else
        {
                UnityEngine.Texture val_9 = static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  丄不东丁丂丅万丒丟.丙且上丒不下丑下丞() + "_squad");
        }
        
        this.丏丛与业丆丝世丒丗();
        if(丄不东丁丂丅万丒丟 != null)
        {
                this.mapID = 丄不东丁丂丅万丒丟.indexMap;
        }
        else
        {
                this.mapID = 4194311;
        }
        
        this.sceneMapName = 丄不东丁丂丅万丒丟.丙且上丒不下丑下丞();
        this.丐且丘丑与万丞丑丅 = 专且丆东且丁丂丝上;
        this.eventTime.text = "";
        this.eventTimeForRating.text = "";
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_23;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_11 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_11.HasValue.丙东专丂世丈丏丁丂() != 3) || ((536152184 & 1) == 0))
        {
            goto label_25;
        }
        
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerRating, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerDefault, 丏业丟一东丂东丘丛:  false);
        goto label_28;
        label_25:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_13 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_13.HasValue.丙东专丂世丈丏丁丂() == 1) && ((536152184 & 1) != 0))
        {
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_130 = this.丐且丘丑与万丞丑丅;
            val_130 = (~val_130.且丆不丈丞专下世丐()) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerDefault, 丏业丟一东丂东丘丛:  val_130);
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_16 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_16.HasValue.丙东专丂世丈丏丁丂() == 1) && ((536152184 & 1) != 0))
        {
                PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_131 = this.丐且丘丑与万丞丑丅;
            val_131 = val_131.且丆不丈丞专下世丐();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerRating, 丏业丟一东丂东丘丛:  val_131);
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_19 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        label_28:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerTournament, 丏业丟一东丂东丘丛:  ((val_19.HasValue.丙东专丂世丈丏丁丂() == 2) ? 1 : 0) & 1152921530912802936);
        if(业丞丟万不丄丂丘丑 != 22)
        {
                bool val_23 = UnityEngine.Object.op_Inequality(x:  static_value_081DACA8 + 184 + 16, y:  0);
            if((GameConnect.丛丑世丕丌上丑丂丈 != true) && ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑上一丒东丑业丈丐().ContainsKey(key:  业丞丟万不丄丂丘丑)) != false))
        {
                if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丞丕业丞丆丘下三()) != false)
        {
                PGCompany.世丐下丕专东丘丏且 val_33 = System.Linq.Enumerable.FirstOrDefault<PGCompany.世丐下丕专东丘丏且>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑上一丒东丑业丈丐().Item[业丞丟万不丄丂丘丑], predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Boolean MapPreviewController::上丈丐专丟不且丘丁(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
            val_132 = ((val_33 != 0) ? 1 : 0) | val_132;
            this.一丟丛三丞丁丐且丘 = val_33;
        }
        
        }
        
        }
        
        val_131 = this.clanWarIconObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_131, 丏业丟一东丂东丘丛:  val_132);
        this.squadMode = 丗丂世丗丄不丟丘万;
        this.SetMapPreviewTitle();
        this.SetLockerObjects();
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_83;
        }
        
        if(this.GameModeLabel != 0)
        {
                val_131 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丐且丘丑与万丞丑丅.东丙上东业丆不丟丘());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.GameModeLabel, 丕丗丘丑丛与丑业丒:  val_131);
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_83;
        }
        
        if(this.DescriptionLabel != 0)
        {
                val_131 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丐且丘丑与万丞丑丅.丒丗丝不丕丈世丏丞());
            this.DescriptionLabel.text = val_131;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_83;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_43 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_43.HasValue.丙东专丂世丈丏丁丂() != 3) || ((536152184 & 1) == 0))
        {
            goto label_83;
        }
        
        this.milee.SetActive(value:  true);
        UILabel val_45 = this.milee.GetComponent<UILabel>();
        string val_46 = this.丐且丘丑与万丞丑丅.丝丕世与与丝专万上();
        goto label_89;
        label_83:
        if(丄不东丁丂丅万丒丟.AvaliableWeapon == 2)
        {
            goto label_91;
        }
        
        if(丄不东丁丂丅万丒丟.AvaliableWeapon != 1)
        {
            goto label_92;
        }
        
        this.milee.SetActive(value:  true);
        UILabel val_47 = this.milee.GetComponent<UILabel>();
        goto label_246;
        label_91:
        this.milee.SetActive(value:  true);
        label_246:
        label_89:
        val_131 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0949");
        this.milee.GetComponent<UILabel>().text = val_131;
        label_248:
        if(业丞丟万不丄丂丘丑 != 20)
        {
            goto label_103;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.team, 丏业丟一东丂东丘丛:  丗丂世丗丄不丟丘万);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.single, 丏业丟一东丂东丘丛:  (~丗丂世丗丄不丟丘万) & 1);
        goto label_106;
        label_92:
        if(业丞丟万不丄丂丘丑 != 14)
        {
            goto label_107;
        }
        
        this.milee.SetActive(value:  true);
        this.milee.GetComponent<UILabel>().text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3498");
        label_103:
        this.TurnOffLabels();
        label_106:
        if(this.isActiveAndEnabled != false)
        {
                this.丅丂丙丁业丅丆且世();
        }
        
        this.三一丛丙丙七丆世三 = false;
        this.丑丛专丌三丅丟三丛 = false;
        if((((this.丐且丘丑与万丞丑丅 == null) && ((MapVoteController.丛丆丂丐丛不不丟万.丄丗专万不丌丝丟且(丂丛丑东不丅丈一东:  业丞丟万不丄丂丘丑, 东一丁世丑丞业丄丐:  丄不东丁丂丅万丒丟)) != false)) && (SceneInfoController.丄丘七三上丕世丞业 != 0)) && ((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  业丞丟万不丄丂丘丑)) != null))
        {
                if(val_57.mapsForVote.Count >= 1)
        {
                this.三一丛丙丙七丆世三 = true;
        }
        
        }
        
        this.topTimerContainer.SetActive(value:  (this.三一丛丙丙七丆世三 == true) ? 1 : 0);
        if(this.三一丛丙丙七丆世三 != false)
        {
                this.丅且丁三丒丐丏业业();
        }
        
        if(this.sizeMapContainer != 0)
        {
                this.sizeMapContainer.SetActive(value:  true);
        }
        
        UnityEngine.Vector3 val_61 = this.captureIconNormalPosition.localPosition;
        val_135 = val_61.x;
        val_136 = val_61.y;
        val_137 = val_61.z;
        if(((专且丆东且丁丂丝上 != null) && (专且丆东且丁丂丝上.丐万且七专丒七丛丞() != false)) && (专且丆东且丁丂丝上.七丂丌丈丄专丄三世() != false))
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_64 = 专且丆东且丁丂丝上.丌不丅不丞东万专专();
            if(val_64.HasValue.丙东专丂世丈丏丁丂() == 4)
        {
                if((536152184 & 1) != 0)
        {
            goto label_141;
        }
        
        }
        
            UnityEngine.Vector3 val_66 = this.captureIconEventPosition.localPosition;
            val_135 = val_66.x;
            val_136 = val_66.y;
            val_137 = val_66.z;
        }
        
        label_141:
        this.newMap.SetActive(value:  false);
        this.flagCaptureIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
        this.capturePointsIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
        if(this.siegeIcon != 0)
        {
                this.siegeIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
            this.siegeIcon.SetActive(value:  (业丞丟万不丄丂丘丑 == 17) ? 1 : 0);
        }
        
        if(this.teamDuelIcon != 0)
        {
                this.teamDuelIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
        }
        
        if(this.duelIcon != 0)
        {
                this.duelIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
        }
        
        if(this.teamFightIcon != 0)
        {
                this.teamFightIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
        }
        
        if(this.deathmatchIcon != 0)
        {
                this.deathmatchIcon.transform.localPosition = new UnityEngine.Vector3() {x = val_135, y = val_136, z = val_137};
        }
        
        this.flagCaptureIcon.SetActive(value:  (业丞丟万不丄丂丘丑 == 4) ? 1 : 0);
        this.capturePointsIcon.SetActive(value:  (业丞丟万不丄丂丘丑 == 5) ? 1 : 0);
        if(this.teamDuelIcon != 0)
        {
                this.teamDuelIcon.SetActive(value:  (业丞丟万不丄丂丘丑 == 16) ? 1 : 0);
            this.duelIcon.SetActive(value:  (业丞丟万不丄丂丘丑 == 8) ? 1 : 0);
            if(专且丆东且丁丂丝上 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_85 = 专且丆东且丁丂丝上.丌不丅不丞东万专专();
            if((val_85.HasValue.丙东专丂世丈丏丁丂() == 4) && ((536152184 & 1) != 0))
        {
                if(this.teamDuelIcon != 0)
        {
                System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_88 = 专且丆东且丁丂丝上.业丄丄且丕丕不一万();
            this.teamDuelIcon.SetActive(value:  ((val_88.HasValue.丙东专丂世丈丏丁丂() == 16) ? 1 : 0) &);
        }
        
            if(this.duelIcon != 0)
        {
                System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_93 = 专且丆东且丁丂丝上.业丄丄且丕丕不一万();
            this.duelIcon.SetActive(value:  ((val_93.HasValue.丙东专丂世丈丏丁丂() == 8) ? 1 : 0) &);
        }
        
            if(this.deathmatchIcon != 0)
        {
                System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_98 = 专且丆东且丁丂丝上.业丄丄且丕丕不一万();
            this.deathmatchIcon.SetActive(value:  ((val_98.HasValue.丙东专丂世丈丏丁丂() == 0) ? 1 : 0) &);
        }
        
            if(this.teamFightIcon != 0)
        {
                System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_103 = 专且丆东且丁丂丝上.业丄丄且丕丕不一万();
            this.teamFightIcon.SetActive(value:  ((val_103.HasValue.丙东专丂世丈丏丁丂() == 2) ? 1 : 0) &);
        }
        
            if(this.flagCaptureIcon != 0)
        {
                System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_108 = 专且丆东且丁丂丝上.业丄丄且丕丕不一万();
            this.flagCaptureIcon.SetActive(value:  ((val_108.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) &);
        }
        
            if(this.capturePointsIcon != 0)
        {
                System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_113 = 专且丆东且丁丂丝上.业丄丄且丕丕不一万();
            this.capturePointsIcon.SetActive(value:  ((val_113.HasValue.丙东专丂世丈丏丁丂() == 5) ? 1 : 0) &);
        }
        
        }
        
        }
        
        }
        
        val_138 = static_value_081DACA8;
        val_138 = static_value_081DACA8;
        this.bottomPanel.SetActive(value:  static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this, 下下丁一下丒业丄业:  true));
        val_139 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if((val_139.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  业丞丟万不丄丂丘丑)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bottomPanel, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        val_140 = static_value_081DACA8;
        val_140 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_141 = static_value_081DACA8;
            val_141 = static_value_081DACA8;
            val_142 = static_value_081DACA8;
            val_142 = static_value_081DACA8;
            val_139 = this.丐且丘丑与万丞丑丅;
            if((System.String.op_Equality(a:  static_value_081DACA8 + 184 + 16 + 568.东丙上东业丆不丟丘(), b:  val_139.东丙上东业丆不丟丘())) != false)
        {
                this.丞丏丈东不丕不丕丁 = true;
        }
        
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_125 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(val_125.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if((536152184 & 1) == 0)
        {
                return;
        }
        
        val_130 = this.popularitySprite.gameObject;
        val_130.SetActive(value:  false);
        return;
        label_107:
        bool val_128 = GameConnect.东且三丆丑世世丘丟();
        if(this.milee == null)
        {
            goto label_241;
        }
        
        if(val_128 == false)
        {
            goto label_242;
        }
        
        label_247:
        this.milee.SetActive(value:  true);
        UILabel val_129 = this.milee.GetComponent<UILabel>();
        goto label_246;
        label_241:
        if(val_128 == true)
        {
            goto label_247;
        }
        
        label_242:
        this.milee.SetActive(value:  false);
        goto label_248;
    }
    internal void 世丆丕一丟丂丁丆东(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        string val_9;
        var val_10;
        this.curSceneInfo = 0;
        this.业丒与丐不丘七业丒 = 丂丛丑东不丅丈一东;
        this.业丞丟万不丄丂丘丑 = 丂丛丑东不丅丈一东;
        this.一丟丛三丞丁丐且丘 = 0;
        this.丑丛专丌三丅丟三丛 = true;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        UnityEngine.Texture val_3 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "MiniGames/Preview/{0}_preview", arg0:  this.业丒与丐不丘七业丒.ToString()));
        if(this.SizeMapLabel != null)
        {
                this.SizeMapLabel.gameObject.SetActive(value:  false);
        }
        
        this.mapID = -3;
        val_9 = "";
        this.丐且丘丑与万丞丑丅 = 0;
        this.sceneMapName = val_9;
        if(this.eventTime == null)
        {
                val_9 = "";
        }
        
        this.eventTime.text = val_9;
        this.eventTimeForRating.text = "";
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerDefault, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerRating, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventContainerTournament, 丏业丟一东丂东丘丛:  false);
        if(this.clanWarIconObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanWarIconObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.squadMode = false;
        this.Locker.CanDisableCkicks = false;
        this.SetMapPreviewTitle();
        this.SetLockerObjects();
        this.milee.SetActive(value:  false);
        this.TurnOffLabels();
        this.bottomPanel.SetActive(value:  false);
        this.下丄丛丁丕丕丅丒丟();
        三业丌且丄丐丐一专 val_7 = Rilisoft.七丐丛专丞东一不世.丑七不且上丗丁一世().丒丙万丁丝下丏下与(上且丗一丏丏万丅丌:  this.业丒与丐不丘七业丒);
        val_10 = 0;
        goto label_21;
        label_28:
        float val_10 = 0f;
        val_10 = (float)val_7.丈丐世下丞与丂专丏 - val_10;
        this.minigamesRatingStars[0].fillAmount = UnityEngine.Mathf.Clamp01(value:  val_10);
        val_10 = 1;
        label_21:
        if(val_10 < this.minigamesRatingStars.Length)
        {
            goto label_28;
        }
        
        this.flagCaptureIcon.SetActive(value:  false);
        this.capturePointsIcon.SetActive(value:  false);
        this.与下丙丆不上丞丌一(丏丛与丅丛丌万专丌:  false);
        this.newMap.SetActive(value:  false);
    }
    internal void 下丄丛丁丕丕丅丒丟()
    {
        if(this.mapID != 3)
        {
                return;
        }
        
        LockerSquadButton val_4 = this.Locker;
        val_4 = ((this.业丒与丐不丘七业丒 != 11) ? 1 : 0) & val_4.IsLocked ^ 1;
        this.minigamesContainer.SetActive(value:  val_4);
    }
    internal void 丅且丁三丒丐丏业业()
    {
        null = null;
        long val_1 = MapVoteController.丛丆丂丐丛不不丟万.且丝丞丆专丑下专业();
        this.topTimerContainer.SetActive(value:  (val_1 != 1) ? 1 : 0);
        System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)val_1);
        this.topTimer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_3._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
    }
    public void Update()
    {
        string val_25;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_26;
        UILabel val_27;
        long val_28;
        var val_29;
        var val_30;
        var val_31;
        if(this.三一丛丙丙七丆世三 != false)
        {
                this.丅且丁三丒丐丏业业();
        }
        
        if(this.timeLeftLabel == 0)
        {
            goto label_4;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_6;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_3 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_25 = ((val_3.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) & 1152921530914225960;
        goto label_7;
        label_4:
        val_26 = this.丐且丘丑与万丞丑丅;
        goto label_8;
        label_6:
        val_25 = 0;
        label_7:
        val_26 = this.丐且丘丑与万丞丑丅;
        this.timeLeftLabel.gameObject.SetActive(value:  false);
        label_8:
        if(mem[this.丐且丘丑与万丞丑丅] == 0)
        {
            goto label_32;
        }
        
        System.Nullable<System.TimeSpan> val_6 = mem[this.丐且丘丑与万丞丑丅].丙世丑丅丒丑业与不();
        if(( & 1) == 0)
        {
            goto label_32;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_7 = mem[this.丐且丘丑与万丞丑丅].丌不丅不丞东万专专();
        val_25 = 1152921525549506960;
        if(val_7.HasValue.丙东专丂世丈丏丁丂() == 1)
        {
                if((537575208 & 1) != 0)
        {
            goto label_14;
        }
        
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_9 = mem[this.丐且丘丑与万丞丑丅].丌不丅不丞东万专专();
        if((val_9.HasValue.丙东专丂世丈丏丁丂() != 5) || ((537575208 & 1) == 0))
        {
            goto label_17;
        }
        
        label_14:
        System.Nullable<System.TimeSpan> val_11 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        val_25 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        this.eventTime.text = val_25;
        if(this.eventTimeTable != 0)
        {
                this.eventTimeTable.repositionNow = true;
        }
        
        if(mem[this.丐且丘丑与万丞丑丅].且丆不丈丞专下世丐() == false)
        {
            goto label_32;
        }
        
        val_27 = this.eventTimeForRating;
        System.Nullable<System.TimeSpan> val_15 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        val_28;
        val_29 = null;
        goto label_29;
        label_17:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_16 = mem[this.丐且丘丑与万丞丑丅].丌不丅不丞东万专专();
        if((val_16.HasValue.丙东专丂世丈丏丁丂() != 2) || ((537575208 & 1) == 0))
        {
            goto label_32;
        }
        
        val_27 = this.tournamentEventTime;
        System.Nullable<System.TimeSpan> val_18 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        val_28;
        val_29 = null;
        label_29:
        val_25 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_28}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_27.text = val_25;
        label_32:
        if(((FriendsController.丝丗专上三不丄丑丑() < 1) || (this.mapID > 3)) || (mem[this.丐且丘丑与万丞丑丅] == 0))
        {
            goto label_41;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_21 = mem[this.丐且丘丑与万丞丑丅].丌不丅不丞东万专专();
        if((val_21.HasValue.丙东专丂世丈丏丁丂() != 3) || ((537575208 & 1) == 0))
        {
            goto label_43;
        }
        
        label_41:
        val_30 = static_value_081DACA8;
        val_30 = static_value_081DACA8;
        if(mem[this.丐且丘丑与万丞丑丅] != 0)
        {
            goto label_55;
        }
        
        label_54:
        val_31 = static_value_081DACA8;
        val_31 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.专且丏东业丄下一丟();
        label_55:
        this.下丄丛丁丕丕丅丒丟();
        if(this.丞丏丈东不丕不丕丁 == false)
        {
                return;
        }
        
        this.GetComponent<UIToggle>().value = true;
        this.丞丏丈东不丕不丕丁 = true;
        this.丁不丑丄丒丂七丌一 = true;
        this.OnClick();
        this.丁不丑丄丒丂七丌一 = false;
        return;
        label_43:
        if(mem[this.丐且丘丑与万丞丑丅] == 0)
        {
            goto label_54;
        }
        
        System.Nullable<System.TimeSpan> val_24 = mem[this.丐且丘丑与万丞丑丅].丙世丑丅丒丑业与不();
        if(( & 1) == 0)
        {
            goto label_54;
        }
        
        goto label_55;
    }
    internal void 丅丂丙丁业丅丆且世()
    {
        var val_22;
        System.Func<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>> val_24;
        var val_25;
        int val_26;
        var val_27;
        string val_28;
        val_22 = null;
        val_22 = null;
        val_24 = MapPreviewController.<>c.<>9__80_0;
        if(val_24 == null)
        {
                System.Func<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>> val_1 = null;
            val_24 = val_1;
            val_1 = new System.Func<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>>(object:  MapPreviewController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世> MapPreviewController.<>c::三丁丈丏三七丐三下());
            MapPreviewController.<>c.<>9__80_0 = val_24;
        }
        
        Rilisoft.七丞丞丅东丞专丙丝<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>> val_2 = new Rilisoft.七丞丞丅东丞专丙丝<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>>(丙丂丌且丌世丒丐三:  val_1);
        if(GameConnect.七专丝上丆丆丒丐万() == false)
        {
            goto label_8;
        }
        
        label_44:
        val_25 = 5;
        goto label_49;
        label_8:
        val_24 = this.业丞丟万不丄丂丘丑;
        int val_20 = 0;
        val_26 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丞上上三丞东丁丝世(丂丛丑东不丅丈一东:  val_24, 丞丁丑丏丄丏七丂不:  this.mapID);
        if(val_24 == 20)
        {
                val_26 = (this.squadMode == true) ? (val_26) : (val_26 + 100);
        }
        
        val_27 = null;
        val_27 = null;
        if(((MapPopularityController.下世丄丏不上丁丘丅.TryGetValue(key:  val_24, value: out  0)) == false) || ((val_7.TryGetValue(key:  val_26, value: out  0)) == false))
        {
            goto label_19;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_20;
        }
        
        val_28 = System.String.Format(format:  "_{0}", arg0:  this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        goto label_21;
        label_19:
        if((val_2.世三丞丅丑丌丈丈一().Contains(item:  val_24)) == true)
        {
            goto label_36;
        }
        
        object[] val_16 = new object[2];
        val_16[0] = val_24;
        val_26 = val_24;
        val_16[1] = val_26;
        UnityEngine.Debug.LogWarningFormat(format:  "Cannot find given key in map popularity dictionary: {0} ({1})", args:  val_16);
        bool val_18 = val_2.世三丞丅丑丌丈丈一().Add(item:  val_24);
        goto label_36;
        label_20:
        val_28 = "";
        label_21:
        val_24 = this.mapID.ToString() + val_28;
        bool val_21 = val_9.TryGetValue(key:  val_24, value: out  val_20);
        label_36:
        if((val_20 & 2147483648) != 0)
        {
            goto label_40;
        }
        
        if(val_20 < 3)
        {
            goto label_41;
        }
        
        if(val_20 < 6)
        {
            goto label_42;
        }
        
        if(val_20 < 11)
        {
            goto label_43;
        }
        
        if(val_20 > 15)
        {
            goto label_44;
        }
        
        val_25 = 4;
        goto label_49;
        label_41:
        val_25 = 1;
        goto label_49;
        label_40:
        val_25 = 0;
        goto label_49;
        label_42:
        val_25 = 2;
        goto label_49;
        label_43:
        val_25 = 3;
        label_49:
        this.一七与丁丏丄不世丄(丙业与丙丗丝不丈东:  3);
    }
    public System.Collections.IEnumerator MyWaitForSeconds(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new MapPreviewController.丅丒丐且丄上上丕丕();
    }
    private void OnEnable()
    {
        this.SetMapPreviewTitle();
        this.SetLockerObjects();
        this.下丄丛丁丕丕丅丒丟();
        if(CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        CustomPanelConnectSceneMiniGame val_3 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_3.createPanel == 0)
        {
                return;
        }
        
        CustomPanelConnectSceneMiniGame val_5 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_5.createPanel.activeInHierarchy == false)
        {
                return;
        }
        
        this.popularitySprite.gameObject.SetActive(value:  false);
    }
    public void TurnOffLabels()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.team, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.single, 丏业丟一东丂东丘丛:  false);
    }
    public void SetLockerObjects()
    {
        int val_17;
        SceneInfo val_22;
        var val_23;
        System.Func<UILabel, UnityEngine.GameObject> val_25;
        int val_26;
        LockerSquadButton val_27;
        string val_28;
        var val_29;
        var val_30;
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        Rilisoft.七丕丟丏三丈一丄世 val_35;
        val_22 = 1152921504848912384;
        if(this.Locker == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        val_25 = MapPreviewController.<>c.<>9__84_0;
        if(val_25 == null)
        {
                System.Func<UILabel, UnityEngine.GameObject> val_2 = null;
            val_25 = val_2;
            val_2 = new System.Func<UILabel, UnityEngine.GameObject>(object:  MapPreviewController.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject MapPreviewController.<>c::丆一丐三业丅七丏丈(UILabel 三丟东丕丄丄下下丑));
            MapPreviewController.<>c.<>9__84_0 = val_25;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<UnityEngine.GameObject, UILabel>(丞下万上三丘上与专:  this.Locker.lockerLabel, 丏丅丁丛一业丈专专:  val_2), 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Locker.duelLockerObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Locker.lockerObject, 丏业丟一东丂东丘丛:  false);
        this.Locker.squadButton.enabled = true;
        UIToggle val_4 = this.GetComponent<UIToggle>();
        if(val_4 != 0)
        {
                val_4.enabled = true;
        }
        
        val_26 = this.mapID;
        if(val_26 == 4)
        {
            goto label_20;
        }
        
        if(val_26 == 3)
        {
            goto label_21;
        }
        
        if(val_26 != 2)
        {
            goto label_22;
        }
        
        val_27 = this.Locker;
        val_28 = "feature.squad";
        int val_6 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  val_28);
        goto label_30;
        label_20:
        if(this.curSceneInfo == 0)
        {
            goto label_26;
        }
        
        val_27 = this.Locker;
        val_29 = null;
        val_29 = null;
        val_22 = this.curSceneInfo;
        val_28 = SceneInfoController.丄丘七三上丕世丞业;
        label_70:
        int val_8 = val_28.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  this.业丞丟万不丄丂丘丑, 东下丌丝且七丛丘丒:  val_22, 丁丏丗且上丗下与下:  false);
        goto label_30;
        label_21:
        val_27 = this.Locker;
        val_28 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        val_30 = this.业丒与丐不丘七业丒;
        goto label_34;
        label_26:
        val_26 = val_26;
        label_22:
        if(val_26 != 5)
        {
            goto label_35;
        }
        
        val_27 = this.Locker;
        val_30 = 17;
        label_61:
        val_28 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        label_34:
        label_30:
        val_27.SetUnlockProgress(丗丗丑丑与东丗丅三:  val_28.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  17), 且业一丕且丒丅丁七:  false);
        label_68:
        this.Locker.enabled = true;
        return;
        label_35:
        val_31 = null;
        val_31 = null;
        val_26 = val_26;
        if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  val_26)) != false)
        {
                val_32 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  22, 专万丟三世业丙丈且:  val_26.ToString(), 丁丏丗且上丗下与下:  false));
            if(val_32 == 2147483647)
        {
                val_33 = null;
            val_33 = null;
            万丗且专万丟丌丂丐 val_16 = DungeonWindowUI.dungeonsInfo.Item[val_26];
            val_32 = 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  val_17);
        }
        
            this.Locker.SetUnlockProgress(丗丗丑丑与东丗丅三:  val_32, 且业一丕且丒丅丁七:  false);
            this.Locker.enabled = true;
            return;
        }
        
        if(this.业丞丟万不丄丂丘丑 == 16)
        {
            goto label_52;
        }
        
        if(this.业丞丟万不丄丂丘丑 != 8)
        {
            goto label_53;
        }
        
        if(Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世() != null)
        {
            goto label_61;
        }
        
        goto label_61;
        label_52:
        if(Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世() != null)
        {
            goto label_61;
        }
        
        goto label_61;
        label_53:
        if(this.业丞丟万不丄丂丘丑 != 20)
        {
            goto label_62;
        }
        
        val_34 = null;
        val_35 = 20;
        goto label_65;
        label_62:
        this.Locker.SetUnlockProgress(丗丗丑丑与东丗丅三:  0, 且业一丕且丒丅丁七:  false);
        if(this.Locker != null)
        {
            goto label_68;
        }
        
        goto label_68;
        label_65:
        var val_21 = (this.squadMode == true) ? 1 : 0;
        goto label_70;
    }
    public void SetMapPreviewTitle()
    {
        string val_17;
        var val_18;
        string val_19;
        var val_22;
        string val_23;
        val_17 = this;
        if(this.NameMapLbl == 0)
        {
                return;
        }
        
        val_18 = 0;
        if(this.curSceneInfo != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.curSceneInfo.七丛一丛专七丈丅专())) == false)
        {
            goto label_8;
        }
        
        }
        
        if(this.mapID == 3)
        {
            goto label_9;
        }
        
        if(this.mapID == 2)
        {
            goto label_10;
        }
        
        if(this.mapID != 1)
        {
                return;
        }
        
        val_17 = this.NameMapLbl.GetComponent<SetHeadLabelText>();
        val_19 = "Key_2463";
        goto label_15;
        label_8:
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_16;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_6 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_6.HasValue.丙东专丂世丈丏丁丂() != 3) || ((539069832 & 1) == 0))
        {
            goto label_18;
        }
        
        label_16:
        string val_8 = this.curSceneInfo.七丛一丛专七丈丅专();
        goto label_20;
        label_9:
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_18 = 0;
        goto label_28;
        label_10:
        val_17 = this.NameMapLbl.GetComponent<SetHeadLabelText>();
        val_19 = "Key_3377";
        label_15:
        val_22 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_19);
        if(val_17 != null)
        {
            goto label_36;
        }
        
        goto label_33;
        label_18:
        label_20:
        val_22 = this.丐且丘丑与万丞丑丅.东丙上东业丆不丟丘();
        val_17 = this.NameMapLbl.GetComponent<SetHeadLabelText>();
        if(val_17 != null)
        {
            goto label_36;
        }
        
        label_33:
        label_36:
        val_23 = val_22;
        goto label_37;
        label_28:
        val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]);
        val_23 = val_17;
        label_37:
        this.NameMapLbl.GetComponent<SetHeadLabelText>().SetText(丕丗丘丑丛与丑业丒:  val_23);
    }
    internal void 业丘丙丁丞丟丑丙丆()
    {
        this.OnClick();
    }
    private void 专丞下丗专世丟丛丑()
    {
        var val_12;
        UnityEngine.MonoBehaviour val_34;
        var val_35;
        var val_36;
        UnityEngine.Object val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        System.Collections.Generic.Dictionary<System.Int32, 万丗且专万丟丌丂丐> val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        SceneInfo val_53;
        val_34 = this;
        if(this.mapID == 5)
        {
            goto label_1;
        }
        
        if(this.mapID == 4)
        {
            goto label_2;
        }
        
        if(this.mapID != 3)
        {
            goto label_20;
        }
        
        val_35 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if((val_35.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this.业丒与丐不丘七业丒)) == false)
        {
                return;
        }
        
        val_36 = static_value_081DACA8;
        val_36 = static_value_081DACA8;
        val_37 = mem[static_value_081DACA8 + 184 + 16 + 64 + 264];
        val_37 = static_value_081DACA8 + 184 + 16 + 64 + 264;
        if(val_37 == 0)
        {
                return;
        }
        
        val_37.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  this.业丒与丐不丘七业丒);
        val_37.丏上丒丄丁丏丅丐丄(丙业与丙丗丝不丈东:  0);
        goto label_71;
        label_1:
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  17)) == false)
        {
            goto label_20;
        }
        
        val_35 = 1152921505052479488;
        val_38 = static_value_081DACA8;
        if(this.mapID != 5)
        {
            goto label_21;
        }
        
        val_39 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16 + 64 + 256.GetComponent<MapHint>().丂丄业东丛不七世世(东下丌丝且七丛丘丒:  this.curSceneInfo, 业丞丟万不丄丂丘丑:  17);
        goto label_88;
        label_20:
        val_40 = 1152921505059028992;
        val_41 = null;
        val_41 = null;
        val_42 = DungeonWindowUI.dungeonsInfo;
        if((val_42.ContainsKey(key:  this.mapID)) == false)
        {
            goto label_32;
        }
        
        val_42 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  22, 专万丟三世业丙丈且:  this.mapID.ToString(), 丁丏丗且上丗下与下:  false));
        if(val_42 != 2147483647)
        {
            goto label_33;
        }
        
        val_43 = null;
        val_43 = null;
        val_42 = DungeonWindowUI.dungeonsInfo;
        万丗且专万丟丌丂丐 val_11 = val_42.Item[this.mapID];
        if(ExperienceController.丞丞丘业东丙丏七丌() >= val_12)
        {
                return;
        }
        
        val_42 = 1152921505052479488;
        val_44 = static_value_081DACA8;
        val_44 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16 + 64 + 256.GetComponent<MapHint>().丂丄业东丛不七世世(东下丌丝且七丛丘丒:  this.curSceneInfo);
        val_45 = static_value_081DACA8;
        val_45 = static_value_081DACA8;
        val_34 = mem[static_value_081DACA8 + 184 + 16 + 64];
        val_34 = static_value_081DACA8 + 184 + 16 + 64;
        val_34 = static_value_081DACA8 + 184 + 16 + 64 + 256.gameObject;
        val_34.SetActive(value:  true);
        return;
        label_2:
        val_46 = static_value_081DACA8;
        val_46 = static_value_081DACA8;
        goto label_55;
        label_32:
        if(this.业丞丟万不丄丂丘丑 == 8)
        {
            goto label_56;
        }
        
        if(this.业丞丟万不丄丂丘丑 == 20)
        {
            goto label_57;
        }
        
        if(this.业丞丟万不丄丂丘丑 != 16)
        {
                return;
        }
        
        label_56:
        val_35 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if((val_35.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this.业丞丟万不丄丂丘丑)) == false)
        {
                return;
        }
        
        val_47 = static_value_081DACA8;
        val_47 = static_value_081DACA8;
        val_37 = mem[static_value_081DACA8 + 184 + 16 + 64 + 264];
        val_37 = static_value_081DACA8 + 184 + 16 + 64 + 264;
        if(val_37 == 0)
        {
                return;
        }
        
        val_37.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  this.业丞丟万不丄丂丘丑);
        goto label_71;
        label_33:
        val_48 = static_value_081DACA8;
        val_48 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16 + 64 + 256.GetComponent<MapHint>().丂丄业东丛不七世世(东下丌丝且七丛丘丒:  this.curSceneInfo);
        val_49 = static_value_081DACA8;
        val_49 = static_value_081DACA8;
        val_34 = mem[static_value_081DACA8 + 184 + 16 + 64 + 256];
        val_34 = static_value_081DACA8 + 184 + 16 + 64 + 256;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_34, 丏业丟一东丂东丘丛:  (~(丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  val_42))) & 1);
        return;
        label_21:
        label_55:
        static_value_081DACA8 + 184 + 16 + 64 + 256.GetComponent<MapHint>().丂丄业东丛不七世世(东下丌丝且七丛丘丒:  this.curSceneInfo);
        label_88:
        val_50 = static_value_081DACA8;
        val_50 = static_value_081DACA8;
        val_34 = mem[static_value_081DACA8 + 184 + 16 + 64];
        val_34 = static_value_081DACA8 + 184 + 16 + 64;
        return;
        label_57:
        val_40 = 1152921504848912384;
        if(this.curSceneInfo == 0)
        {
                if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  20)) == true)
        {
            goto label_101;
        }
        
        }
        
        if(this.curSceneInfo == 0)
        {
                return;
        }
        
        val_51 = null;
        val_51 = null;
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  SceneInfoController.丄丘七三上丕世丞业.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  this.业丞丟万不丄丂丘丑, 东下丌丝且七丛丘丒:  this.curSceneInfo, 丁丏丗且上丗下与下:  (this.squadMode == true) ? 1 : 0))) == true)
        {
                return;
        }
        
        label_101:
        val_52 = static_value_081DACA8;
        val_52 = static_value_081DACA8;
        val_37 = mem[static_value_081DACA8 + 184 + 16 + 64 + 264];
        val_37 = static_value_081DACA8 + 184 + 16 + 64 + 264;
        if(val_37 == 0)
        {
                return;
        }
        
        val_37.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  this.业丞丟万不丄丂丘丑);
        val_53 = this.curSceneInfo;
        val_37.丏上丒丄丁丏丅丐丄(丙业与丙丗丝不丈东:  null);
        val_37.三丑业一丂下一且万(丙业与丙丗丝不丈东:  (this.squadMode == true) ? 1 : 0);
        label_71:
        val_37.七东丘东专丗世且三();
        val_37.gameObject.SetActive(value:  true);
    }
    private void OnClick()
    {
        MapPreviewController val_53;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        PGCompany.丁下丒丕丆下丂丆丌 val_61;
        var val_62;
        var val_63;
        var val_64;
        Rilisoft.七丕丟丏三丈一丄世 val_65;
        var val_66;
        Rilisoft.七丕丟丏三丈一丄世 val_67;
        Rilisoft.七丕丟丏三丈一丄世 val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        System.Action<Rilisoft.NeedSquadLevelConnectScene> val_77;
        var val_78;
        var val_79;
        System.Func<HintObject, HintItem> val_81;
        var val_82;
        val_53 = this;
        if(CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世() != 0)
        {
                CustomPanelConnectSceneMiniGame val_3 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_3.createPanel != 0)
        {
                CustomPanelConnectSceneMiniGame val_5 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_5.createPanel.activeInHierarchy != false)
        {
                val_54 = 1152921505231126528;
            if(CustomMiniGameController.丂丞丛丙东丗丈业丑() != 0)
        {
                CustomMiniGameController val_9 = CustomMiniGameController.丂丞丛丙东丗丈业丑();
            val_9.selectMap = val_53;
            return;
        }
        
        }
        
        }
        
        }
        
        val_54 = 1152921505055887360;
        val_55 = 0;
        if(CustomPanelConnectScene.丑七不且上丗丁一世() != 0)
        {
                val_55 = 0;
            CustomPanelConnectScene.丑七不且上丗丁一世().七丝丕丂丑丌丟万不(丞丁丑丏丄丏七丂不:  this);
        }
        
        val_56 = static_value_081DACA8;
        val_56 = static_value_081DACA8;
        val_57 = mem[static_value_081DACA8 + 184 + 16 + 48 + 136 + 296 + 8];
        val_57 = static_value_081DACA8 + 184 + 16 + 48 + 136 + 296 + 8;
        val_58 = static_value_081DACA8;
        val_58 = static_value_081DACA8;
        val_57 = 1;
        if((static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this, 下下丁一下丒业丄业:  true)) == false)
        {
            goto label_43;
        }
        
        val_59 = static_value_081DACA8;
        val_59 = static_value_081DACA8;
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_55;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_14 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(val_14.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if((540089832 & 1) != 0)
        {
            goto label_55;
        }
        
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_16 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(val_16.HasValue.丙东专丂世丈丏丁丂() == 5)
        {
                if((540089832 & 1) != 0)
        {
            goto label_55;
        }
        
        }
        
        val_60 = static_value_081DACA8;
        val_60 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16 + 72.gameObject.activeSelf) == false)
        {
            goto label_61;
        }
        
        label_55:
        CustomPanelConnectScene val_20 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_20.createPanel.activeSelf == true)
        {
            goto label_112;
        }
        
        if(this.一丟丛三丞丁丐且丘 == null)
        {
            goto label_69;
        }
        
        val_54 = 1152921525544440992;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丞丕业丞丆丘下三()) == false)
        {
            goto label_69;
        }
        
        val_61 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(万不且且丛丆东丒业:  this.一丟丛三丞丁丐且丘);
        this.丌丝万上丅丒一丈丘 = val_61;
        val_62 = static_value_081DACA8;
        val_62 = static_value_081DACA8;
        val_61 = this.丌丝万上丅丒一丈丘;
        val_54 = mem[static_value_081DACA8 + 184 + 16];
        val_54 = static_value_081DACA8 + 184 + 16;
        val_54.丙丐丘丂丆丆且万下(下丒丏丙一不七丕丏:  this, 丌丝万上丅丒一丈丘:  val_61);
        goto label_112;
        label_61:
        val_63 = static_value_081DACA8;
        val_63 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this, 下下丁一下丒业丄业:  true)) != false)
        {
                val_64 = static_value_081DACA8;
            val_64 = static_value_081DACA8;
            val_54 = this.丐且丘丑与万丞丑丅;
            val_64 = static_value_081DACA8;
            mem2[0] = val_54;
            mem2[0] = val_53;
        }
        
        val_65 = this.业丞丟万不丄丂丘丑;
        if(val_65 <= 17)
        {
                var val_53 = 1;
            val_53 = val_53 << val_65;
            val_53 = val_53 & 196912;
            if(val_53 != 0)
        {
                val_66 = static_value_081DACA8;
            val_66 = static_value_081DACA8;
            val_67 = this.业丞丟万不丄丂丘丑;
            val_54 = mem[static_value_081DACA8 + 184 + 16];
            val_54 = static_value_081DACA8 + 184 + 16;
            val_54.丁丛丘丅业丙丗丗与(丂丛丑东不丅丈一东:  val_67);
            val_68 = this.业丞丟万不丄丂丘丑;
        }
        
        }
        
        if((val_68 != 22) || (this.mapID < 1))
        {
            goto label_94;
        }
        
        val_69 = static_value_081DACA8;
        val_69 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this, 下下丁一下丒业丄业:  true)) == false)
        {
            goto label_94;
        }
        
        if(this.丁不丑丄丒丂七丌一 == true)
        {
            goto label_112;
        }
        
        val_70 = static_value_081DACA8;
        val_70 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丈丌一丗丞丂丂丟丞(下丒丏丙一不七丕丏:  this);
        goto label_112;
        label_94:
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_112;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_28 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_54 = 1152921525549506960;
        if(val_28.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if((540089832 & 1) != 0)
        {
            goto label_112;
        }
        
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_30 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(val_30.HasValue.丙东专丂世丈丏丁丂() == 5)
        {
                if((540089832 & 1) != 0)
        {
            goto label_112;
        }
        
        }
        
        if(this.丁不丑丄丒丂七丌一 == true)
        {
            goto label_112;
        }
        
        val_71 = static_value_081DACA8;
        val_71 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.且丐丆且丝丑丒东业(下丒丏丙一不七丕丏:  this);
        goto label_112;
        label_43:
        this.专丞下丗专世丟丛丑();
        return;
        label_69:
        if(this.丁不丑丄丒丂七丌一 != true)
        {
                val_72 = static_value_081DACA8;
            val_72 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.HandleGoBtnClicked();
        }
        
        label_112:
        this.专丞下丗专世丟丛丑();
        val_73 = static_value_081DACA8;
        val_73 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this, 下下丁一下丒业丄业:  true)) == false)
        {
                return;
        }
        
        val_74 = static_value_081DACA8;
        val_74 = static_value_081DACA8;
        val_75 = null;
        val_75 = null;
        val_77 = MapPreviewController.<>c.<>9__89_0;
        if(val_77 == null)
        {
                System.Action<Rilisoft.NeedSquadLevelConnectScene> val_34 = null;
            val_77 = val_34;
            val_34 = new System.Action<Rilisoft.NeedSquadLevelConnectScene>(object:  MapPreviewController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MapPreviewController.<>c::丈丄丑丈丈万万丙丌(Rilisoft.NeedSquadLevelConnectScene 三丟东丕丄丄下下丑));
            MapPreviewController.<>c.<>9__89_0 = val_77;
        }
        
        Rilisoft.NeedSquadLevelConnectScene val_35 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.NeedSquadLevelConnectScene>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16.NeedSquadLevelConnectSceneScript, 丌专业且丛丏丞丝且:  val_34);
        val_78 = static_value_081DACA8;
        val_78 = static_value_081DACA8;
        UIButton val_37 = static_value_081DACA8 + 184 + 16 + 64 + 24.GetComponent<UIButton>();
        bool val_38 = static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this, 下下丁一下丒业丄业:  true);
        System.Action<Rilisoft.DoubleRewardConnectScene> val_40 = null;
        val_54 = val_40;
        val_40 = new System.Action<Rilisoft.DoubleRewardConnectScene>(object:  this, method:  System.Void MapPreviewController::上丗丆丛丟东且专丏(Rilisoft.DoubleRewardConnectScene 三丟东丕丄丄下下丑));
        Rilisoft.DoubleRewardConnectScene val_41 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.DoubleRewardConnectScene>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16.DoubleRewardConnectScene, 丌专业且丛丏丞丝且:  val_40);
        HintController val_42 = HintController.与一丅丝不丈业与丙();
        val_79 = null;
        val_53 = val_42.hintObject;
        val_79 = null;
        val_81 = MapPreviewController.<>c.<>9__89_2;
        if(val_81 == null)
        {
                System.Func<HintObject, HintItem> val_43 = null;
            val_81 = val_43;
            val_43 = new System.Func<HintObject, HintItem>(object:  MapPreviewController.<>c.__il2cppRuntimeField_static_fields, method:  HintItem MapPreviewController.<>c::世万万业专万丒丞上(HintObject 三丟东丕丄丄下下丑));
            MapPreviewController.<>c.<>9__89_2 = val_81;
        }
        
        if((丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<HintItem, HintObject>(丞下万上三丘上与专:  val_53, 丏丅丁丛一业丈专专:  val_43)) == null)
        {
                return;
        }
        
        HintController val_45 = HintController.与一丅丝不丈业与丙();
        val_53 = val_45.hintObject.丈丑丑东万丒一丁丐();
        if((System.String.op_Equality(a:  val_46.name, b:  "gobattle")) == false)
        {
                return;
        }
        
        val_82 = static_value_081DACA8;
        val_82 = static_value_081DACA8;
        if(((static_value_081DACA8 + 184 + 16 + 64 + 24.GetComponent<UIButton>()) & 1) != 0)
        {
                HintController val_49 = HintController.与一丅丝不丈业与丙();
            HintItem val_50 = val_49.hintObject.丈丑丑东万丒一丁丐();
            val_50.defaultSpriteName = "green_btn";
            val_53 = HintController.与一丅丝不丈业与丙();
            val_53.丙万丞丄丐丂下丅丘();
            return;
        }
        
        val_53 = HintController.与一丅丝不丈业与丙();
        val_53.东丏一丁下丄丙丙丂();
    }
    public void ToggleValueChange(bool 丙业与丙丗丝不丈东)
    {
        var val_5;
        UnityEngine.GameObject val_6;
        var val_7;
        UnityEngine.GameObject val_8;
        var val_9;
        val_6 = this;
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_1;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_5 = 1152921525549506960;
        if((val_1.HasValue.丙东专丂世丈丏丁丂() != 1) || ((540418952 & 1) == 0))
        {
            goto label_4;
        }
        
        val_7 = 1152921505284374528;
        val_6 = this.eventDarkMask;
        goto label_5;
        label_1:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventDarkMask, 丏业丟一东丂东丘丛:  false);
        val_8 = this.eventTournamentDarkMask;
        val_9 = 0;
        goto label_8;
        label_4:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_3 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(val_3.HasValue.丙东专丂世丈丏丁丂() != 2)
        {
                return;
        }
        
        if((540418952 & 1) == 0)
        {
                return;
        }
        
        val_7 = 1152921505284374528;
        val_6 = this.eventTournamentDarkMask;
        label_5:
        val_9 = 1;
        val_8 = val_6;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
    }
    public MapPreviewController()
    {
        string[] val_1 = new string[6];
        val_1[0] = "Key_0545";
        val_1[1] = "Key_0546";
        val_1[2] = "Key_0547";
        val_1[3] = "Key_0548";
        val_1[4] = "Key_0549";
        val_1[5] = "Key_2183";
        this.丝东七一丗丐七丙下 = val_1;
    }
    private bool 上丈丐专丟不且丘丁(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑.世丈丁业丛上丘丗丐().万丆丄上七丒专且世() != null)
        {
                return System.String.op_Equality(a:  val_2.Map, b:  this.sceneMapName);
        }
        
        return System.String.op_Equality(a:  val_2.Map, b:  this.sceneMapName);
    }
    private void 上丗丆丛丟东且专丏(Rilisoft.DoubleRewardConnectScene 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.丗与丄丑一丈丙不丛(上且丗一丏丏万丅丌:  this.业丞丟万不丄丂丘丑);
    }

}
