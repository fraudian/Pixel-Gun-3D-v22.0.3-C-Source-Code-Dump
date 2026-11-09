using UnityEngine;
public class RanksTable : MonoBehaviour
{
    // Fields
    private NetworkStartTableNGUIController _networkStartTableNGUIController;
    private const int 丑业丕丅不丛世丛专 = 6;
    private const int 下丛且丗专丒丌丗丙 = 5;
    private const int 与不一丄丞丑丅丄业 = 3;
    public UnityEngine.GameObject panelRanks;
    public UnityEngine.GameObject panelRanksTeam;
    public UnityEngine.GameObject panelRanksTeamDuel;
    public UnityEngine.GameObject tekPanel;
    public UnityEngine.GameObject panelRanksBattleRoyale;
    public UnityEngine.GameObject panelRanksBattleRoyaleList;
    public UnityEngine.GameObject panelRanksDungeons;
    public UnityEngine.GameObject panelRanksScroll;
    public UnityEngine.GameObject panelRanksArmRace;
    public UnityEngine.GameObject panelRanksPlantTheBomb;
    internal MutationTable panelRanksMutation;
    public UnityEngine.GameObject modePC1;
    public UnityEngine.GameObject modeFC1;
    public UnityEngine.GameObject modeTDM1;
    public UnityEngine.GameObject modeSiege;
    public ImposterRoomSettings imposterRoomSettingsPanel;
    public ActionInTableButton[] playersButtonsDeathmatch;
    public ActionInTableButton[] playersButtonsTeamFight;
    public ActionInTableButton[] playersButtonsTeamDuel;
    public ActionInTableButton[] playersButtonsBattleRoyale;
    public ActionInTableButton[] playersButtonsArmRace;
    public ActionInTableButton[] playersButtonsPlantTheBomb;
    public ActionInTableButton[] playersButtonsMutation;
    public DungeonTableItem[] playersButtonsDungeons;
    public UILabel[] totalBlueTeam;
    public UILabel[] totalRedTeam;
    public UILabel[] totalBlueTeamDuel;
    public UILabel[] totalRedTeamDuel;
    public UILabel[] totalBlueTeamPlantTheBomb;
    public UILabel[] totalRedTeamPlantTheBomb;
    public UILabel teamOneLabel;
    public UILabel teamTwoLabel;
    public UILabel teamDuelOneLabel;
    public UILabel teamDuelTwoLabel;
    public UILabel plantTheBombTeamOneLabel;
    public UILabel plantTheBombTeamTwoLabel;
    public UnityEngine.GameObject teamOneWinner;
    public UnityEngine.GameObject teamTwoWinner;
    public UnityEngine.GameObject teamDuelOneWinner;
    public UnityEngine.GameObject teamDuelTwoWinner;
    public UnityEngine.GameObject plantTheBombTeamOneWinner;
    public UnityEngine.GameObject plantTheBombTeamTwoWinner;
    public UnityEngine.GameObject plantTheBombChangeSidesLabelObject;
    public UILabel revBlueScore;
    public UILabel revBlueKills;
    public UILabel revRedLvl;
    public UILabel revRedNick;
    private UnityEngine.Vector3 丙丟业上丛丘丕不丕;
    private UnityEngine.Vector3 东三丂业丟丆丝一丕;
    private UnityEngine.Vector3 一丝东丗丄丒三丐丁;
    private UnityEngine.Vector3 丙丒丟七三七丟东丞;
    private System.Collections.Generic.List<NetworkStartTable> 丐万丂丞万丌丐丞世;
    private System.Collections.Generic.List<NetworkStartTable> 三下东丞丟丘丕且丟;
    private System.Collections.Generic.List<NetworkStartTable> 丏业丅下且与丏丁丁;
    private System.Collections.Generic.List<NetworkStartTable> 丑上丞丌丅丁东且丐;
    public bool isShowRanks;
    public bool isShowTableWin;
    public UnityEngine.GameObject revengeContainer;
    public bool isShowOldRanks;
    public ActionInTableButton playerButtonItemInScroll;
    public System.Collections.Generic.List<ActionInTableButton> playerButtonsInScroll;
    public UIScrollView playersScroll;
    public UIGrid playersGrid;
    public ActionInTableButton playerButtonItemInScrollTableScroll;
    public System.Collections.Generic.List<ActionInTableButton> playerButtonsInScrollTableScroll;
    public UIScrollView playersScrollTableScroll;
    public UIGrid playersGridTableScroll;
    private bool 丗丁丟丑三丟万丕丌;
    private string 丆丕丒丁世一专业七;
    private bool 七丂丝丅丞一丄丒与;
    public int totalBlue;
    public int totalRed;
    public int sumBlue;
    public int sumRed;
    private UnityEngine.Vector3 丏丁下丗丈丕丟丆且;
    private UnityEngine.Vector3 丐丟丞丘丌丐丞丙且;
    private bool 上丗与不丑丄丞丆业;
    
    // Methods
    private void Awake()
    {
        UILabel[] val_13;
        TValue val_8 = 0;
        this.丆丕丒丁世一专业七 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1224");
        this.丗丁丟丑三丟万丕丌 = GameConnect.丆丁上丟丛业丄丅丝();
        Rilisoft.七丕丟丏三丈一丄世 val_5 = GameConnect.丑丌丛丈丅丅与不业();
        int val_6 = System.Convert.ToInt32(value:  val_5);
        var val_14 = 0;
        val_14 = val_14 + 1;
        if((GameConnect.丛丛丏专丏下三与七().TryGetValue(key:  val_5, value: out  val_8)) != false)
        {
                val_13 = this._networkStartTableNGUIController.gameModeLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_13, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8));
            return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_13 = "There\'s no localize key for " + GameConnect.丑丌丛丈丅丅与不业().ToString() + " game mode";
        UnityEngine.Debug.Log(message:  val_13);
    }
    private void Start()
    {
        UnityEngine.GameObject val_27;
        if(this.panelRanksBattleRoyaleList == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => panelRanksBattleRoyaleList: null");
        }
        
        if(this.panelRanksTeamDuel == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => panelRanksTeamDuel: null");
        }
        
        if(this.panelRanksTeam == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => panelRanksTeam: null");
        }
        
        if(this.panelRanks == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => panelRanks: null");
        }
        
        if(this.panelRanksScroll == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => panelRanksFreeplayList: null");
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.panelRanksScroll, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.panelRanksBattleRoyaleList, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.panelRanksTeamDuel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.panelRanksTeam, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.panelRanks, 丏业丟一东丂东丘丛:  false);
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_33;
        }
        
        }
        
        val_27 = this.panelRanksScroll;
        goto label_93;
        label_33:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_39;
        }
        
        val_27 = this.panelRanksBattleRoyaleList;
        goto label_93;
        label_39:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_44;
        }
        
        val_27 = this.panelRanksTeamDuel;
        goto label_93;
        label_44:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_49;
        }
        
        if(this.panelRanksDungeons != null)
        {
            goto label_64;
        }
        
        label_65:
        label_64:
        this.panelRanksDungeons.SetActive(value:  true);
        return;
        label_49:
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_53;
        }
        
        val_27 = this.panelRanksArmRace;
        goto label_93;
        label_53:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_58;
        }
        
        val_27 = this.panelRanksPlantTheBomb;
        label_93:
        label_91:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  true);
        return;
        label_58:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_62;
        }
        
        if(this.panelRanksMutation.gameObject != null)
        {
            goto label_64;
        }
        
        goto label_65;
        label_62:
        if(this.丗丁丟丑三丟万丕丌 == false)
        {
            goto label_93;
        }
        
        if(this.modePC1 == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => modePC1: null");
        }
        
        if(this.modeFC1 == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => modeFC1: null");
        }
        
        if(this.modeTDM1 == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => modeTDM1: null");
        }
        
        if(this.modeSiege == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RanksTable] Start() => modeSiege: null");
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.panelRanksTeam, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.modePC1, 丏业丟一东丂东丘丛:  (GameConnect.丑丌丛丈丅丅与不业() == 5) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.modeFC1, 丏业丟一东丂东丘丛:  (GameConnect.丑丌丛丈丅丅与不业() == 4) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.modeTDM1, 丏业丟一东丂东丘丛:  (GameConnect.丑丌丛丈丅丅与不业() == 2) ? 1 : 0);
        var val_26 = (GameConnect.丑丌丛丈丅丅与不业() == 17) ? 1 : 0;
        goto label_91;
    }
    private void Update()
    {
        var val_14;
        if(this.isShowRanks == false)
        {
            goto label_1;
        }
        
        if(GameConnect.不专专丂万丝上东丐() == false)
        {
            goto label_4;
        }
        
        MiniGamesController val_2 = MiniGamesController.丑七不且上丗丁一世();
        if(val_2.isGo == true)
        {
            goto label_8;
        }
        
        label_4:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_11;
        }
        
        label_8:
        this.一丙丄丑丆业丞且万();
        goto label_28;
        label_1:
        if(this.isShowOldRanks == false)
        {
            goto label_28;
        }
        
        this.丟丛万丗丙丁且不不();
        goto label_28;
        label_11:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_21;
        }
        
        BattleRoyaleController val_5 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_5.isRunPlayer == false)
        {
            goto label_21;
        }
        
        this.丝丌丟丟丏且东丑丗();
        goto label_28;
        label_21:
        if(GameConnect.一业上七丟业且业丙() != false)
        {
                if((RedLightController.Instance.世东上与东丂万业丑() & 255) != 1)
        {
            goto label_27;
        }
        
        }
        
        this.丂丈丕丌七一丝丙与();
        this.三业丛丛丐万一丑丑();
        goto label_28;
        label_27:
        this.丑丄不世丝丞与丆一();
        label_28:
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
                val_14 = null;
            val_14 = null;
            if(GameController.onlineMode != null)
        {
                var val_10 = (null == null) ? GameController.onlineMode : 0;
        }
        
            一且丐丗丅丈丏丄丅 val_11 = 0.三丘三丈上丕丆丂一();
            if(val_11 == 1)
        {
                if(val_11.丆丞丅业世丐丞丗七() == false)
        {
            goto label_38;
        }
        
        }
        
        }
        
        label_49:
        label_46:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.imposterRoomSettingsPanel, 丏业丟一东丂东丘丛:  false);
        return;
        label_38:
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_49;
        }
        
        goto label_46;
    }
    private bool 丆丞丅业世丐丞丗七()
    {
        var val_12;
        var val_13;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (bool)val_13;
        }
        
        val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
        if(val_12.Length == 36)
        {
                val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
            if((val_12.IndexOf(value:  "-")) == 8)
        {
                val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
            var val_11 = ((val_12.LastIndexOf(value:  "-")) == 23) ? 1 : 0;
            return (bool)val_13;
        }
        
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    private void LateUpdate()
    {
        if(this.上丗与不丑丄丞丆业 == false)
        {
                return;
        }
        
        this.playersScroll.ResetPosition();
        this.playersScrollTableScroll.ResetPosition();
        this.上丗与不丑丄丞丆业 = false;
    }
    private void OnEnable()
    {
        this.上丗与不丑丄丞丆业 = true;
    }
    internal void 三上丗业丑三丗一丌(bool 丛丅丘一丏丙且丌上, int 丗三上丞丆七不且七 = 0)
    {
        var val_58;
        float val_62;
        float val_63;
        UnityEngine.GameObject val_64;
        UnityEngine.GameObject val_65;
        var val_66;
        MutationTable val_67;
        MutationTable val_68;
        var val_69;
        val_58 = 丛丅丘一丏丙且丌上;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
        {
            goto label_3;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_6;
        }
        
        if(this.teamDuelOneLabel != null)
        {
            goto label_47;
        }
        
        label_48:
        label_47:
        UnityEngine.Transform val_4 = this.teamDuelOneLabel.transform;
        UnityEngine.Vector3 val_5 = 0.localPosition;
        this.丏丁下丗丈丕丟丆且 = val_5;
        mem[1152921536038968616] = val_5.y;
        mem[1152921536038968620] = val_5.z;
        label_3:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丐丟丞丘丌丐丞丙且, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) == false)
        {
            goto label_11;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_14;
        }
        
        if(this.teamDuelTwoLabel != null)
        {
            goto label_49;
        }
        
        label_50:
        label_49:
        UnityEngine.Transform val_9 = this.teamDuelTwoLabel.transform;
        UnityEngine.Vector3 val_10 = 0.localPosition;
        this.丐丟丞丘丌丐丞丙且 = val_10;
        mem[1152921536038968628] = val_10.y;
        mem[1152921536038968632] = val_10.z;
        label_11:
        if(GameConnect.丒丗丁丙丗丄丙不丐() != false)
        {
                UnityEngine.Vector3 val_13 = this.plantTheBombTeamOneLabel.transform.localPosition;
            this.丏丁下丗丈丕丟丆且 = val_13;
            mem[1152921536038968616] = val_13.y;
            mem[1152921536038968620] = val_13.z;
            UnityEngine.Vector3 val_15 = this.plantTheBombTeamTwoLabel.transform.localPosition;
            this.丐丟丞丘丌丐丞丙且 = val_15;
            mem[1152921536038968628] = val_15.y;
            mem[1152921536038968632] = val_15.z;
        }
        
        if((丗三上丞丆七不且七 == 0) || (val_58 == false))
        {
            goto label_25;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_28;
        }
        
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  55f);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = this.丐丟丞丘丌丐丞丙且, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        this.teamDuelOneLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  55f);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丐丟丞丘丌丐丞丙且, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        val_62 = val_24.x;
        val_63 = val_24.z;
        this.teamDuelTwoLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_62, y = val_24.y, z = val_63};
        val_64 = this.teamDuelOneWinner;
        val_64.SetActive(value:  (丗三上丞丆七不且七 == 1) ? 1 : 0);
        val_65 = this.teamDuelTwoWinner;
        if(val_65 != null)
        {
            goto label_95;
        }
        
        label_96:
        label_95:
        var val_26 = (丗三上丞丆七不且七 == 2) ? 1 : 0;
        goto label_37;
        label_25:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_40;
        }
        
        this.teamDuelOneLabel.transform.localPosition = new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = V9.16B, z = this.丐丟丞丘丌丐丞丙且};
        val_62 = this.丐丟丞丘丌丐丞丙且;
        this.teamDuelTwoLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_62, y = V9.16B, z = this.丐丟丞丘丌丐丞丙且};
        this.teamDuelOneWinner.SetActive(value:  false);
        val_65 = this.teamDuelTwoWinner;
        if(val_65 != null)
        {
            goto label_102;
        }
        
        label_103:
        label_102:
        val_66 = 0;
        label_37:
        val_65.SetActive(value:  false);
        return;
        label_6:
        if(this.teamOneLabel != null)
        {
            goto label_47;
        }
        
        goto label_48;
        label_14:
        if(this.teamTwoLabel != null)
        {
            goto label_49;
        }
        
        goto label_50;
        label_28:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_53;
        }
        
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  55f);
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = this.丐丟丞丘丌丐丞丙且, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        this.plantTheBombTeamOneLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  55f);
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丐丟丞丘丌丐丞丙且, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        this.plantTheBombTeamTwoLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z};
        this.plantTheBombTeamOneWinner.SetActive(value:  (丗三上丞丆七不且七 == 1) ? 1 : 0);
        if(this.plantTheBombTeamTwoWinner != null)
        {
            goto label_95;
        }
        
        goto label_96;
        label_40:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_65;
        }
        
        this.plantTheBombTeamOneLabel.transform.localPosition = new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = V9.16B, z = this.丐丟丞丘丌丐丞丙且};
        this.plantTheBombTeamTwoLabel.transform.localPosition = new UnityEngine.Vector3() {x = this.丐丟丞丘丌丐丞丙且, y = V9.16B, z = this.丐丟丞丘丌丐丞丙且};
        this.plantTheBombTeamOneWinner.SetActive(value:  false);
        if(this.plantTheBombTeamTwoWinner != null)
        {
            goto label_102;
        }
        
        goto label_103;
        label_53:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_75;
        }
        
        val_67 = this.panelRanksMutation;
        if(val_67 == 0)
        {
                return;
        }
        
        val_68 = this.panelRanksMutation;
        val_69 = 丗三上丞丆七不且七;
        goto label_80;
        label_65:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_83;
        }
        
        if(this.panelRanksMutation == 0)
        {
                return;
        }
        
        val_68 = this.panelRanksMutation;
        val_69 = 0;
        label_80:
        val_68.世丌丛万且丗业丄东(丗三上丞丆七不且七:  0);
        return;
        label_75:
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, d:  55f);
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = this.丐丟丞丘丌丐丞丙且, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
        this.teamOneLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z};
        UnityEngine.Vector3 val_52 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, d:  55f);
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丐丟丞丘丌丐丞丙且, y = val_50.y, z = val_50.z}, b:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z});
        this.teamTwoLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z};
        this.teamOneWinner.SetActive(value:  (丗三上丞丆七不且七 == 1) ? 1 : 0);
        if(this.teamTwoWinner != null)
        {
            goto label_95;
        }
        
        goto label_96;
        label_83:
        this.teamOneLabel.transform.localPosition = new UnityEngine.Vector3() {x = this.丏丁下丗丈丕丟丆且, y = V9.16B, z = this.丐丟丞丘丌丐丞丙且};
        this.teamTwoLabel.transform.localPosition = new UnityEngine.Vector3() {x = this.丐丟丞丘丌丐丞丙且, y = V9.16B, z = this.丐丟丞丘丌丐丞丙且};
        this.teamOneWinner.SetActive(value:  false);
        if(this.teamTwoWinner != null)
        {
            goto label_102;
        }
        
        goto label_103;
    }
    private void 丂丈丕丌七一丝丙与()
    {
        System.Collections.Generic.List<NetworkStartTable> val_11;
        var val_12;
        this.三下东丞丟丘丕且丟.Clear();
        this.丏业丅下且与丏丁丁.Clear();
        this.丑上丞丌丅丁东且丐.Clear();
        this.丐万丂丞万丌丐丞世.Clear();
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                System.Collections.Generic.List<NetworkStartTable> val_2 = NetworkStartTable.丑丁丂上丌丑丄丏丑();
        }
        
        val_11 = NetworkStartTable.下上丞丞丏丅丕丏世();
        this.丐万丂丞万丌丐丞世 = val_11;
        if(this.丗丁丟丑三丟万丕丌 == false)
        {
                return;
        }
        
        val_12 = 0;
        goto label_20;
        label_29:
        if(this.丐万丂丞万丌丐丞世.Item[0].丘丑丅三丆丑丌且丝() != 1)
        {
            goto label_17;
        }
        
        if(this.丐万丂丞万丌丐丞世 != null)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        this.三下东丞丟丘丕且丟.Add(item:  this.丐万丂丞万丌丐丞世.Item[0]);
        val_11 = this.丐万丂丞万丌丐丞世;
        val_12 = 1;
        goto label_20;
        label_17:
        if(this.丐万丂丞万丌丐丞世.Item[0].丘丑丅三丆丑丌且丝() != 2)
        {
            goto label_23;
        }
        
        if(this.丐万丂丞万丌丐丞世 != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_23:
        if(this.丐万丂丞万丌丐丞世 != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_20:
        if(val_12 < val_11.Count)
        {
            goto label_29;
        }
    
    }
    private void 上且丒丒丅丙与丙丂(ActionInTableButton 丟丒丞丐丐丘丒丄东, NetworkStartTable 不且上一上丐三万丛, int 丙丄丕一丒丛丂丞下, int 七一丞丈万丛下丘上 = 0)
    {
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        UnityEngine.Texture val_34;
        val_30 = null;
        val_30 = null;
        if(不且上一上丐三万丛 != null)
        {
            
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_12;
        }
        
        val_31 = null;
        val_31 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        label_16:
        var val_7 = (null == null) ? GameController.onlineMode : 0;
        val_32 = UnityEngine.Mathf.Clamp(value:  不且上一上丐三万丛.丁丄一且丐丑丝丕丄(), min:  1, max:  onlineMode == null ? GameController.onlineMode : 0 + 536.MaxLevel).ToString();
        goto label_30;
        label_12:
        int val_13 = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丑丛丆三丆丄七丐万());
        val_32 = val_13.ToString();
        label_30:
        if(不且上一上丐三万丛 != 0)
        {
                var val_22 = (不且上一上丐三万丛.丞丗丅东业丑不丙丞 == true) ? 1 : 0;
        }
        
        if(不且上一上丐三万丛 != 0)
        {
                val_33 = 不且上一上丐三万丛.丄专丘三丘丘不丄丕();
        }
        else
        {
                val_33 = 0;
        }
        
        val_34 = 不且上一上丐三万丛.丌丏丞丆丗与东丗业;
        if(不且上一上丐三万丛.万丛丏万丟丕丒丛与 != 0)
        {
                val_34 = 不且上一上丐三万丛.万丛丏万丟丕丒丛与;
        }
        
        丟丒丞丐丐丘丒丄东.UpdateState(东丅丞丁丗万且丁丗:  true, 东三丄丒丌丏下下丗:  不且上一上丐三万丛.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable), 丐丛丂丈七且世业业:  (0 != 0) ? 1 : 0, 下丄丁丑三丏丗丛七:  七一丞丈万丛下丘上, 不丆业丏上丐与丌业:  不且上一上丐三万丛.丂丈丐不丏万三七丐, 万且丒下丕丝专丟上:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丝丈丅一丆丗丝丝丘())), 丂丌丙丝且东丗丙万:  (val_13 > 0) ? ((val_13 > 0) ? (val_32) : "-") : "-:--:--", 丈一七上丛丗丄丘丞:  UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丘不丄一丒丆丒丅万()).ToString(), 专世专丟丝丌与丘上:  不且上一上丐三万丛.下东且丐丆丅丁世丟, 丅丈丛丅丝东七丂且:  不且上一上丐三万丛.丏丅业丞丁丌丈与丆, 丛丄世丐丐丗且丈与:  不且上一上丐三万丛.丈三世丞丕万丄七丂, 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  val_34, 丏七丟丛与丞丐丄上:  (不且上一上丐三万丛.上丟丘丙丅丛丝世不 == true) ? 1 : 0, 不丄丐上业丕且丝丝:  (mem[1152921536039594096] == true) ? 1 : 0, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  val_33 & 1);
    }
    private void 丟丘不丅且丛丂一丅(ActionInTableButton 丟丒丞丐丐丘丒丄东, 丈万且丗丂丝丙一东 丕丛上丏丗丗丗且专, int 七一丞丈万丛下丘上 = 0)
    {
        bool val_39;
        var val_40;
        UnityEngine.Texture val_41;
        int val_42;
        bool val_43;
        bool val_44;
        bool val_45;
        if(丕丛上丏丗丗丗且专 != null)
        {
                bool val_1 = 丕丛上丏丗丗丗且专.丟丌下三七丁与丟丑();
            val_39 = 丕丛上丏丗丗丗且专.一七不三丌专三丆一;
        }
        else
        {
                val_39 = 7;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_7;
        }
        
        val_40 = 丕丛上丏丗丗丗且专.丅丘丈丒万世三世丕.ToString();
        goto label_27;
        label_7:
        int val_7 = UnityEngine.Mathf.Max(a:  0, b:  丕丛上丏丗丗丗且专.丌与三与三丆丙一丟);
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_19;
        }
        
        }
        
        }
        
        label_75:
        val_40 = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  val_7);
        label_27:
        if(丕丛上丏丗丗丗且专.不且上一上丐三万丛 != 0)
        {
                var val_19 = (丕丛上丏丗丗丗且专.不且上一上丐三万丛.丞丗丅东业丑不丙丞 == true) ? 1 : 0;
        }
        
        if(丕丛上丏丗丗丗且专.不且上一上丐三万丛 != 0)
        {
                bool val_22 = 丕丛上丏丗丗丗且专.不且上一上丐三万丛.丄专丘三丘丘不丄丕();
        }
        
        val_41 = 丕丛上丏丗丗丗且专.丂丒丘丅专丗丂世丛;
        if(丕丛上丏丗丗丗且专.不且上一上丐三万丛.万丛丏万丟丕丒丛与 != 0)
        {
                val_41 = 丕丛上丏丗丗丗且专.不且上一上丐三万丛.万丛丏万丟丕丒丛与;
        }
        
        if((GameConnect.不专专丂万丝上东丐() != true) && (GameConnect.一与东丝万上三丆丏() != true))
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_58;
        }
        
        }
        
        }
        
        if(丕丛上丏丗丗丗且专.万丌丏丘丂丈丗丅丂() != false)
        {
                val_42 = 七一丞丈万丛下丘上;
            val_43 = 1;
        }
        else
        {
                label_58:
            val_42 = 七一丞丈万丛下丘上;
            if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                val_43 = 丕丛上丏丗丗丗且专.万丗不丑七丟丒丆丙;
        }
        else
        {
                val_43 = 0;
        }
        
        }
        
        if(丕丛上丏丗丗丗且专.不且上一上丐三万丛 != 0)
        {
                val_44 = 丕丛上丏丗丗丗且专.不且上一上丐三万丛.上丟丘丙丅丛丝世不;
        }
        else
        {
                val_44 = 0;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_71;
        }
        
        val_45 = 丕丛上丏丗丗丗且专.专丛下不丄且丌丛丕;
        if(丟丒丞丐丐丘丒丄东 != null)
        {
            goto label_74;
        }
        
        goto label_73;
        label_71:
        val_45 = 0;
        if(丟丒丞丐丐丘丒丄东 != null)
        {
            goto label_74;
        }
        
        label_73:
        label_74:
        丟丒丞丐丐丘丒丄东.UpdateState(东丅丞丁丗万且丁丗:  true, 东三丄丒丌丏下下丗:  0.丟丌下三七丁与丟丑(), 丐丛丂丈七且世业业:  (val_39 != 0) ? 1 : 0, 下丄丁丑三丏丗丛七:  val_42, 不丆业丏上丐与丌业:  丕丛上丏丗丗丗且专.丒丘丏上丙丟丑丕丈, 万且丒下丕丝专丟上:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  UnityEngine.Mathf.Max(a:  0, b:  丕丛上丏丗丗丗且专.万且丒下丕丝专丟上)), 丂丌丙丝且东丗丙万:  (val_7 > 0) ? ((val_7 > 0) ? (val_40) : "-") : "-:--:--", 丈一七上丛丗丄丘丞:  UnityEngine.Mathf.Max(a:  0, b:  丕丛上丏丗丗丗且专.丈一七上丛丗丄丘丞).ToString(), 专世专丟丝丌与丘上:  丕丛上丏丗丗丗且专.专世专丟丝丌与丘上, 丅丈丛丅丝东七丂且:  丕丛上丏丗丗丗且专.丅丈丛丅丝东七丂且, 丛丄世丐丐丗且丈与:  丕丛上丏丗丗丗且专.丆世丘丒丒丏上且丗, 丒东三丌专丗三丂丟:  (val_43 != 0) ? 1 : 0, 丒丁丑丂丄丛丌上专:  val_41, 丏七丟丛与丞丐丄上:  (val_44 != 0) ? 1 : 0, 不丄丐上业丕且丝丝:  (this.七丂丝丅丞一丄丒与 == true) ? 1 : 0, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  (val_45 != 0) ? 1 : 0, 丏丝丁七丂且丕丑丕:  false);
        return;
        label_19:
        string val_38 = val_7.ToString();
        goto label_75;
    }
    private void 丄丁丆世下丌丆东业(bool 且东丁丄业世丞丁不 = False)
    {
        var val_58;
        NetworkStartTable val_59;
        var val_61;
        var val_62;
        var val_63;
        System.Collections.Generic.List<NetworkStartTable> val_64;
        var val_65;
        var val_66;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        val_58 = null;
        val_58 = null;
        val_59 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_59 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_4;
        }
        
        val_61 = 1152921504838422528;
        val_62 = 0;
        val_63 = 0;
        goto label_7;
        label_23:
        int val_5 = UnityEngine.Mathf.Max(a:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.一丒业三万七业丌七(), b:  0);
        int val_7 = UnityEngine.Mathf.Max(a:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 24, b:  0);
        val_64 = mem[(NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32];
        val_64 = (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32;
        val_63 = ((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.一丒业三万七业丌七()) + val_63;
        int val_9 = UnityEngine.Mathf.Min(a:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 28, b:  2147483647);
        val_62 = 1;
        label_7:
        if(val_62 < (-1277648896))
        {
            goto label_23;
        }
        
        goto label_24;
        label_4:
        val_61 = 1152921525488043600;
        val_65 = 0;
        val_63 = 0;
        goto label_25;
        label_37:
        int val_14 = UnityEngine.Mathf.Max(a:  this.丐万丂丞万丌丐丞世.Item[0].一丒业三万七业丌七(), b:  0);
        int val_17 = UnityEngine.Mathf.Max(a:  this.丐万丂丞万丌丐丞世.Item[0].丑丛丆三丆丄七丐万(), b:  0);
        val_64 = this.丐万丂丞万丌丐丞世;
        val_63 = this.丐万丂丞万丌丐丞世.Item[0].一丒业三万七业丌七() + val_63;
        int val_20 = UnityEngine.Mathf.Min(a:  val_64.Item[0].丘不丄一丒丆丒丅万(), b:  2147483647);
        val_65 = 1;
        label_25:
        if(val_65 < this.丐万丂丞万丌丐丞世.Count)
        {
            goto label_37;
        }
        
        label_24:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_38;
        }
        
        if(null != 0)
        {
            goto label_40;
        }
        
        goto label_40;
        label_38:
        val_61 = 1152921525488043600;
        val_66 = 0;
        goto label_41;
        label_47:
        float val_69 = (float)this.丐万丂丞万丌丐丞世.Item[0].一丒业三万七业丌七();
        val_69 = val_69 / (float)val_63;
        val_69 = val_69 * 100f;
        int val_25 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_69), b:  0);
        val_66 = 1;
        label_41:
        val_64 = this.丐万丂丞万丌丐丞世;
        if(val_66 < val_64.Count)
        {
            goto label_47;
        }
        
        goto label_58;
        label_40:
        val_64 = 0;
        goto label_50;
        label_57:
        val_61 = 0;
        float val_70 = (float)(NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.一丒业三万七业丌七();
        val_70 = val_70 / 0f;
        val_70 = val_70 * 100f;
        int val_30 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_70), b:  0);
        val_64 = 1;
        label_50:
        if(val_64 < (-1277648896))
        {
            goto label_57;
        }
        
        label_58:
        val_68 = 0;
        goto label_59;
        label_126:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_60;
        }
        
        if(val_68 >= (-1277648896))
        {
            goto label_71;
        }
        
        if( < 1)
        {
            goto label_64;
        }
        
        float val_71 = (float)(NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.一丒业三万七业丌七();
        val_71 = val_71 / 0f;
        val_71 = val_71 * 100f;
        val_69 = UnityEngine.Mathf.FloorToInt(f:  val_71);
        goto label_69;
        label_60:
        if(val_68 >= this.丐万丂丞万丌丐丞世.Count)
        {
            goto label_71;
        }
        
        if( < 1)
        {
            goto label_72;
        }
        
        val_70 = 1152921525488043600;
        float val_72 = (float)this.丐万丂丞万丌丐丞世.Item[0].一丒业三万七业丌七();
        val_72 = val_72 / 0f;
        val_72 = val_72 * 100f;
        val_71 = UnityEngine.Mathf.FloorToInt(f:  val_72);
        goto label_77;
        label_71:
        val_64 = 0;
        this.playersButtonsDungeons[val_64].丑丄与万世且丛且上();
        goto label_100;
        label_72:
        val_70 = 1152921525488043600;
        val_71 = 0;
        label_77:
        if(this.丐万丂丞万丌丐丞世.Item[0].一丒业三万七业丌七() >= 1)
        {
                var val_43 = (this.丐万丂丞万丌丐丞世.Item[0].一丒业三万七业丌七() >= 0) ? 1 : 0;
        }
        else
        {
                val_72 = 0;
        }
        
        if(this.丐万丂丞万丌丐丞世.Item[0].丑丛丆三丆丄七丐万() >= 1)
        {
                var val_48 = (this.丐万丂丞万丌丐丞世.Item[0].丑丛丆三丆丄七丐万() >= 0) ? 1 : 0;
        }
        else
        {
                val_64 = 0;
        }
        
        bool val_49 = (val_71 > 0) ? 1 : 0;
        val_49 = ((val_71 >= 0) ? 1 : 0) & val_49;
        val_61 = this.丐万丂丞万丌丐丞世.Item[0].丘不丄一丒丆丒丅万();
        this.playersButtonsDungeons[0].与万不丄丄东丁与业(不且上一上丐三万丛:  this.丐万丂丞万丌丐丞世.Item[0], 且丏上下丘丐一丅丗:  0, 丏丆丑丗七丄丙丝与:  (val_68 == 0) ? 1 : 0, 丞万丌丒一业万丌下:  false, 丞丆丛一丟下丏丆丄:  false, 且丒丆丗一丁丈业丗:  val_49, 丟丛不丟丐丈丙丁丂:  (val_61 <= 2147483647) ? 1 : 0);
        val_59 = val_59;
        goto label_100;
        label_64:
        val_69 = 0;
        label_69:
        if(((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.一丒业三万七业丌七()) >= 1)
        {
                var val_60 = (((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32.一丒业三万七业丌七()) >= 0) ? 1 : 0;
        }
        
        val_73 = this.playersButtonsDungeons[0];
        var val_63 = (((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 24) >= 0) ? 1 : 0;
        val_61 = mem[(NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32];
        val_61 = (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32;
        val_64 = ((val_69 >= 0) ? 1 : 0) & ((val_69 > 0) ? 1 : 0);
        val_59 = val_59;
        丙业不丐且丅业丄丏(不且上一上丐三万丛:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32, 且丏上下丘丐一丅丗:  0, 丏丆丑丗七丄丙丝与:  (val_68 == 0) ? 1 : 0, 丞万丌丒一业万丌下:  false, 丞丆丛一丟下丏丆丄:  false, 且丒丆丗一丁丈业丗:  val_64, 丟丛不丟丐丈丙丁丂:  (((NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32 + 28) <= 2147483647) ? 1 : 0);
        label_100:
        val_68 = 1;
        label_59:
        if(val_68 < this.playersButtonsDungeons.Length)
        {
            goto label_126;
        }
    
    }
    private void 丄东一万上业丙丈与(bool 且东丁丄业世丞丁不 = False)
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<NetworkStartTable> val_5;
        val_3 = null;
        val_3 = null;
        val_4 = 0;
        goto label_4;
        label_24:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_5;
        }
        
        if(val_4 >= (-1277648896))
        {
            goto label_15;
        }
        
        val_5 = 0;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsDeathmatch[val_5], 丕丛上丏丗丗丗且专:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32, 七一丞丈万丛下丘上:  0);
        goto label_19;
        label_5:
        if(val_4 >= this.丐万丂丞万丌丐丞世.Count)
        {
            goto label_15;
        }
        
        val_5 = this.丐万丂丞万丌丐丞世;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsDeathmatch[0], 不且上一上丐三万丛:  val_5.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
        goto label_19;
        label_15:
        val_5 = 0;
        this.playersButtonsDeathmatch[val_5].UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        label_19:
        val_4 = 1;
        label_4:
        if(val_4 < this.playersButtonsDeathmatch.Length)
        {
            goto label_24;
        }
    
    }
    private void 丅丂七一丐丙丏下万(bool 且东丁丄业世丞丁不 = False)
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<NetworkStartTable> val_5;
        val_3 = null;
        val_3 = null;
        val_4 = 0;
        goto label_4;
        label_24:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_5;
        }
        
        if(val_4 >= (-1277648896))
        {
            goto label_15;
        }
        
        val_5 = 0;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsArmRace[val_5], 丕丛上丏丗丗丗且专:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32, 七一丞丈万丛下丘上:  0);
        goto label_19;
        label_5:
        if(val_4 >= this.丐万丂丞万丌丐丞世.Count)
        {
            goto label_15;
        }
        
        val_5 = this.丐万丂丞万丌丐丞世;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsArmRace[0], 不且上一上丐三万丛:  val_5.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
        goto label_19;
        label_15:
        val_5 = 0;
        this.playersButtonsArmRace[val_5].UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        label_19:
        val_4 = 1;
        label_4:
        if(val_4 < this.playersButtonsArmRace.Length)
        {
            goto label_24;
        }
    
    }
    private void 丙业下丙七一丏丝七(bool 且东丁丄业世丞丁不 = False)
    {
        var val_40;
        NetworkStartTable val_41;
        NetworkStartTable val_42;
        bool val_43;
        NetworkStartTable[] val_44;
        丈万且丗丂丝丙一东[] val_45;
        ActionInTableButton val_46;
        var val_47;
        int val_48;
        var val_49;
        NetworkStartTable val_50;
        var val_51;
        var val_52;
        val_40 = null;
        val_40 = null;
        if(this.panelRanksMutation == 0)
        {
                return;
        }
        
        val_41 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(null == 0)
        {
                val_41 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        
        if(且东丁丄业世丞丁不 != false)
        {
                val_42 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            if(null == 0)
        {
                val_42 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        
            val_43 = (~丟世一丛万一与丂丏()) & 1;
            val_44 = 0;
            val_45 = NetworkStartTable.__il2cppRuntimeField_native_size;
        }
        else
        {
                T[] val_4 = this.丐万丂丞万丌丐丞世.ToArray();
            val_43 = 且世专不丄丏七下万();
            val_44 = val_4;
            val_45 = 0;
        }
        
        this.panelRanksMutation.下上丞丌七丝万丘专(丛上丐七丛丘丒下一:  val_43, 专上世丝丈专一丂丅:  val_44, 丌丐丂七丌三万丑丅:  val_45);
        System.Collections.Generic.List<System.Int32> val_5 = this.panelRanksMutation.丙丏丒丕丁丘丈专丄();
        val_46 = this.panelRanksMutation.丒丞七丌丛丄丈上丑();
        val_47 = 10;
        goto label_16;
        label_60:
        val_48 = (long)val_4;
        ActionInTableButton val_39 = this.playersButtonsMutation[val_48];
        if(W25 <= val_4)
        {
            goto label_20;
        }
        
        val_39.ShowPlaceAndPlus(丙业与丙丗丝不丈东:  true);
        if(val_46 != null)
        {
            goto label_23;
        }
        
        goto label_22;
        label_20:
        val_49 = 0;
        val_39.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        if(val_46 != null)
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        ActionInTableButton val_40 = this.playersButtonsMutation[10];
        if(val_46.Count > val_4)
        {
                val_40.ShowPlaceAndPlus(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_49 = 0;
            val_40.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        }
        
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_29;
        }
        
        val_50 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(null == 0)
        {
                val_50 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        
        if(val_5.Count > val_4)
        {
                int val_9 = val_5.Item[val_4];
            this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsMutation[val_48], 丕丛上丏丗丗丗且专:  (NetworkStartTable.__il2cppRuntimeField_native_size + ((long)(int)(val_9)) << 3) + 32, 七一丞丈万丛下丘上:  val_4);
        }
        
        if(val_46.Count <= val_4)
        {
            goto label_54;
        }
        
        int val_12 = val_46.Item[val_4];
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsMutation[10], 丕丛上丏丗丗丗且专:  (NetworkStartTable.__il2cppRuntimeField_native_size + ((long)(int)(val_12)) << 3) + 32, 七一丞丈万丛下丘上:  val_4);
        goto label_54;
        label_29:
        if(val_5.Count > val_4)
        {
                val_48 = val_5.Item[val_4];
            this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsMutation[val_48], 不且上一上丐三万丛:  this.丐万丂丞万丌丐丞世.Item[val_48], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
        }
        
        if(val_46.Count > val_4)
        {
                this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsMutation[10], 不且上一上丐三万丛:  this.丐万丂丞万丌丐丞世.Item[val_46.Item[val_4]], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
        }
        
        label_54:
        val_47 = 11;
        label_16:
        var val_20 = val_47 - 10;
        val_51 = val_5.Count;
        if(val_20 < 10)
        {
            goto label_60;
        }
        
        var val_45 = val_46.Count;
        val_45 = val_45 + val_51;
        世丁与丕丗丟丒丆上 val_23 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_23 != null)
        {
                int val_24 = val_23.丕丏业且丒丂上七下();
        }
        else
        {
                val_52 = 10;
        }
        
        int val_25 = 10 - val_45;
        if(val_20 <= 10)
        {
                return;
        }
        
        if(val_46.Count >= 1)
        {
                if(val_25 < 1)
        {
                return;
        }
        
            val_51 = 1152921504624312320;
            var val_48 = 0;
            do
        {
            if((val_46.Count + val_48) > 9)
        {
                return;
        }
        
            int val_30 = val_46.Count + val_48;
            val_30 = val_30 + 10;
            this.playersButtonsMutation[(long)val_30].UpdateState(东丅丞丁丗万且丁丗:  true, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  System.String.alignConst, 万且丒下丕丝专丟上:  System.String.alignConst, 丂丌丙丝且东丗丙万:  System.String.alignConst, 丈一七上丛丗丄丘丞:  System.String.alignConst, 专世专丟丝丌与丘上:  0, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
            int val_32 = val_46.Count + val_48;
            val_32 = val_32 + 10;
            this.playersButtonsMutation[(long)val_32].ShowPlaceAndPlus(丙业与丙丗丝不丈东:  false);
            val_48 = val_48 + 1;
        }
        while(val_48 < val_25);
        
            return;
        }
        
        if(val_25 < 1)
        {
                return;
        }
        
        val_51 = 1152921504624312320;
        var val_50 = 0;
        do
        {
            if((val_5.Count + val_50) >= 10)
        {
                return;
        }
        
            this.playersButtonsMutation[(long)val_5.Count + val_50].UpdateState(东丅丞丁丗万且丁丗:  true, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  System.String.alignConst, 万且丒下丕丝专丟上:  System.String.alignConst, 丂丌丙丝且东丗丙万:  System.String.alignConst, 丈一七上丛丗丄丘丞:  System.String.alignConst, 专世专丟丝丌与丘上:  0, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
            val_46 = this.playersButtonsMutation[(long)val_5.Count + val_50];
            val_46.ShowPlaceAndPlus(丙业与丙丗丝不丈东:  false);
            val_50 = val_50 + 1;
        }
        while(val_50 < val_25);
    
    }
    private void 专丟丑三丗专丕丌丅(bool 且东丁丄业世丞丁不 = False)
    {
        var val_5;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_2 = 一且下与丂丌丝三三.万三下下丅丘丐与丄(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 且专丏丏丈三丒与丙:  false);
        val_5 = 0;
        goto label_5;
        label_14:
        ActionInTableButton val_5 = this.playersButtonsBattleRoyale[0];
        if(val_5 < val_2.Count)
        {
                this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  val_5, 丕丛上丏丗丗丗且专:  val_2.Item[0], 七一丞丈万丛下丘上:  0);
        }
        else
        {
                val_5.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        }
        
        val_5 = 1;
        label_5:
        if(val_5 < this.playersButtonsBattleRoyale.Length)
        {
            goto label_14;
        }
    
    }
    private void 丌一丏丒丟七一一丒(bool 且东丁丄业世丞丁不 = False)
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<NetworkStartTable> val_5;
        val_3 = null;
        val_3 = null;
        val_4 = 0;
        goto label_4;
        label_24:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_5;
        }
        
        if(val_4 >= (-1277648896))
        {
            goto label_15;
        }
        
        val_5 = 0;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsBattleRoyale[val_5], 丕丛上丏丗丗丗且专:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32, 七一丞丈万丛下丘上:  0);
        goto label_19;
        label_5:
        if(val_4 >= this.丐万丂丞万丌丐丞世.Count)
        {
            goto label_15;
        }
        
        val_5 = this.丐万丂丞万丌丐丞世;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsBattleRoyale[0], 不且上一上丐三万丛:  val_5.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
        goto label_19;
        label_15:
        val_5 = 0;
        this.playersButtonsBattleRoyale[val_5].UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        label_19:
        val_4 = 1;
        label_4:
        if(val_4 < this.playersButtonsBattleRoyale.Length)
        {
            goto label_24;
        }
    
    }
    private void 丝丌丟丟丏且东丑丗()
    {
        System.Collections.Generic.List<ActionInTableButton> val_20;
        var val_21;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_2 = 一且下与丂丌丝三三.万三下下丅丘丐与丄(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 且专丏丏丈三丒与丙:  false);
        int val_20 = UnityEngine.Mathf.Max(a:  0, b:  val_2.Count - this.playerButtonsInScroll.Count);
        if(val_20 >= 1)
        {
                if(this.playerButtonsInScroll.Count == 0)
        {
                this.上丗与不丑丄丞丆业 = true;
        }
        
            do
        {
            val_20 = this.playerButtonsInScroll;
            val_20.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.playerButtonItemInScroll.gameObject.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.playerButtonItemInScroll.gameObject).GetComponent<ActionInTableButton>());
            val_20 = val_20 - 1;
        }
        while(val_20 != 0);
        
        }
        
        val_21 = 0;
        goto label_30;
        label_33:
        val_20 = this.playerButtonsInScroll;
        ActionInTableButton val_16 = val_20.Item[0];
        if(val_21 < val_2.Count)
        {
                this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  val_16, 丕丛上丏丗丗丗且专:  val_2.Item[0], 七一丞丈万丛下丘上:  0);
            val_21 = 1;
            this.playerButtonsInScroll.Item[0].SetPlace(且丒丛与丞世丙丕丌:  1);
        }
        else
        {
                val_16.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
            val_21 = 1;
        }
        
        label_30:
        if(val_21 < this.playerButtonsInScroll.Count)
        {
            goto label_33;
        }
    
    }
    private void 丘丟一上丞一世丞丙(bool 且东丁丄业世丞丁不 = False)
    {
        var val_24;
        var val_25;
        var val_26;
        string val_27;
        var val_28;
        var val_29;
        val_24 = null;
        val_24 = null;
        if(且东丁丄业世丞丁不 != false)
        {
                val_25 = -1277648896;
        }
        else
        {
                val_25 = this.丐万丂丞万丌丐丞世.Count;
        }
        
        val_26 = 1152921536043444320;
        int val_25 = UnityEngine.Mathf.Max(a:  0, b:  val_25 - this.playerButtonsInScroll.Count);
        val_27 = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6040"), arg1:  this.playerButtonsInScroll.Count);
        this._networkStartTableNGUIController.countPlayersLabel.text = val_27;
        if(val_25 >= 1)
        {
                if(this.playerButtonsInScroll.Count == 0)
        {
                this.上丗与不丑丄丞丆业 = true;
        }
        
            do
        {
            val_27 = this.playerButtonsInScroll;
            val_27.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.playerButtonItemInScroll.gameObject.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.playerButtonItemInScroll.gameObject).GetComponent<ActionInTableButton>());
            val_25 = val_25 - 1;
        }
        while(val_25 != 0);
        
        }
        
        val_28 = "";
        val_29 = 0;
        goto label_48;
        label_52:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_32;
        }
        
        if(val_29 >= (-1277648896))
        {
            goto label_43;
        }
        
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playerButtonsInScroll.Item[0], 丕丛上丏丗丗丗且专:  (NetworkStartTable.__il2cppRuntimeField_native_size + 0) + 32, 七一丞丈万丛下丘上:  0);
        val_26 = val_26;
        val_29 = 1;
        this.playerButtonsInScroll.Item[0].SetPlace(且丒丛与丞世丙丕丌:  1);
        val_28 = val_28;
        goto label_48;
        label_32:
        if(val_29 >= this.丐万丂丞万丌丐丞世.Count)
        {
            goto label_43;
        }
        
        val_27 = this.丐万丂丞万丌丐丞世;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playerButtonsInScroll.Item[0], 不且上一上丐三万丛:  val_27.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
        val_29 = 1;
        this.playerButtonsInScroll.Item[0].SetPlace(且丒丛与丞世丙丕丌:  1);
        goto label_48;
        label_43:
        this.playerButtonsInScroll.Item[0].UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        val_29 = 1;
        label_48:
        if(val_29 < this.playerButtonsInScroll.Count)
        {
            goto label_52;
        }
    
    }
    private void 丑丄不世丝丞与丆一()
    {
        System.Collections.Generic.List<ActionInTableButton> val_20;
        var val_21;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_2 = 一且下与丂丌丝三三.万三下下丅丘丐与丄(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 且专丏丏丈三丒与丙:  false);
        int val_20 = UnityEngine.Mathf.Max(a:  0, b:  val_2.Count - this.playerButtonsInScrollTableScroll.Count);
        if(val_20 >= 1)
        {
                if(this.playerButtonsInScrollTableScroll.Count == 0)
        {
                this.上丗与不丑丄丞丆业 = true;
        }
        
            do
        {
            val_20 = this.playerButtonsInScrollTableScroll;
            val_20.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.playerButtonItemInScrollTableScroll.gameObject.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.playerButtonItemInScrollTableScroll.gameObject).GetComponent<ActionInTableButton>());
            val_20 = val_20 - 1;
        }
        while(val_20 != 0);
        
        }
        
        val_21 = 0;
        goto label_30;
        label_33:
        val_20 = this.playerButtonsInScrollTableScroll;
        ActionInTableButton val_16 = val_20.Item[0];
        if(val_21 < val_2.Count)
        {
                this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  val_16, 丕丛上丏丗丗丗且专:  val_2.Item[0], 七一丞丈万丛下丘上:  0);
            val_21 = 1;
            this.playerButtonsInScrollTableScroll.Item[0].SetPlace(且丒丛与丞世丙丕丌:  1);
        }
        else
        {
                val_16.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
            val_21 = 1;
        }
        
        label_30:
        if(val_21 < this.playerButtonsInScrollTableScroll.Count)
        {
            goto label_33;
        }
    
    }
    private void 且丑丕丒且丕丞丈丑()
    {
        var val_21;
        int val_21 = UnityEngine.Mathf.Max(a:  0, b:  this.丐万丂丞万丌丐丞世.Count - this.playerButtonsInScrollTableScroll.Count);
        this._networkStartTableNGUIController.countPlayersLabel.text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6040"), arg1:  this.playerButtonsInScrollTableScroll.Count);
        if(val_21 >= 1)
        {
                if(this.playerButtonsInScrollTableScroll.Count == 0)
        {
                this.上丗与不丑丄丞丆业 = true;
        }
        
            do
        {
            this.playerButtonsInScrollTableScroll.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.playerButtonItemInScrollTableScroll.gameObject.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.playerButtonItemInScrollTableScroll.gameObject).GetComponent<ActionInTableButton>());
            val_21 = val_21 - 1;
        }
        while(val_21 != 0);
        
        }
        
        val_21 = 0;
        goto label_31;
        label_34:
        ActionInTableButton val_17 = this.playerButtonsInScrollTableScroll.Item[0];
        if(val_21 < this.丐万丂丞万丌丐丞世.Count)
        {
                this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  val_17, 不且上一上丐三万丛:  this.丐万丂丞万丌丐丞世.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  0);
            val_21 = 1;
            this.playerButtonsInScrollTableScroll.Item[0].SetPlace(且丒丛与丞世丙丕丌:  1);
        }
        else
        {
                val_17.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
            val_21 = 1;
        }
        
        label_31:
        if(val_21 < this.playerButtonsInScrollTableScroll.Count)
        {
            goto label_34;
        }
    
    }
    private void 一丙丄丑丆业丞且万()
    {
        var val_5;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_2 = 一且下与丂丌丝三三.万三下下丅丘丐与丄(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 且专丏丏丈三丒与丙:  false);
        val_5 = 0;
        goto label_5;
        label_14:
        ActionInTableButton val_5 = this.playersButtonsDeathmatch[0];
        if(val_5 < val_2.Count)
        {
                this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  val_5, 丕丛上丏丗丗丗且专:  val_2.Item[0], 七一丞丈万丛下丘上:  0);
        }
        else
        {
                val_5.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        }
        
        val_5 = 1;
        label_5:
        if(val_5 < this.playersButtonsDeathmatch.Length)
        {
            goto label_14;
        }
    
    }
    private void 丙东丌丆世上丄丂丅(bool 且东丁丄业世丞丁不 = False)
    {
        var val_45;
        int val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        int val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        int val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        val_45 = null;
        val_45 = null;
        if(null == 0)
        {
            goto label_4;
        }
        
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_4:
        if(且东丁丄业世丞丁不 == true)
        {
            goto label_6;
        }
        
        label_5:
        val_46 = 丘丑丅三丆丑丌且丝();
        label_6:
        int val_2 = UnityEngine.Mathf.Max(a:  0, b:  val_46);
        mem2[0] = 0;
        var val_3 = (val_2 == 2) ? 3 : 0;
        var val_4 = (val_2 == 2) ? 0 : 3;
        int val_6 = (val_2 == 0) ? 0 : ((val_2 != 2) ? (1 + 1) : 1);
        val_47 = 0;
        goto label_10;
        label_107:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_11;
        }
        
        val_48 = null;
        val_48 = null;
        if(val_47 >= (UnityEngine.Mathf.Min(a:  Count, b:  3)))
        {
            goto label_37;
        }
        
        val_49 = null;
        val_49 = null;
        丈万且丗丂丝丙一东 val_9 = Item[0];
        if(val_9.丌与三与三丆丙一丟 == 1)
        {
            goto label_26;
        }
        
        val_50 = null;
        val_50 = null;
        丈万且丗丂丝丙一东 val_10 = Item[0];
        val_51 = val_10.丌与三与三丆丙一丟;
        goto label_33;
        label_11:
        if(val_47 >= (UnityEngine.Mathf.Min(a:  this.三下东丞丟丘丕且丟.Count, b:  3)))
        {
            goto label_37;
        }
        
        if(this.三下东丞丟丘丕且丟.Item[0].丑丛丆三丆丄七丐万() == 1)
        {
            goto label_40;
        }
        
        val_52 = this.三下东丞丟丘丕且丟.Item[0];
        int val_16 = val_52.丑丛丆三丆丄七丐万();
        goto label_43;
        label_37:
        this.playersButtonsTeamDuel[(long)val_3 + val_47].UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        if(且东丁丄业世丞丁不 == true)
        {
            goto label_47;
        }
        
        goto label_48;
        label_26:
        val_51 = 0;
        label_33:
        val_51 = val_51 + this.sumBlue;
        this.sumBlue = val_51;
        val_53 = null;
        val_53 = null;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsTeamDuel[(long)val_3 + val_47], 丕丛上丏丗丗丗且专:  Item[0], 七一丞丈万丛下丘上:  val_2);
        label_47:
        val_54 = null;
        val_54 = null;
        if(val_47 >= (UnityEngine.Mathf.Min(a:  Count, b:  3)))
        {
            goto label_84;
        }
        
        val_55 = null;
        val_55 = null;
        丈万且丗丂丝丙一东 val_22 = Item[0];
        if(val_22.丌与三与三丆丙一丟 == 1)
        {
            goto label_70;
        }
        
        val_56 = null;
        val_56 = null;
        丈万且丗丂丝丙一东 val_23 = Item[0];
        val_57 = val_23.丌与三与三丆丙一丟;
        goto label_77;
        label_40:
        val_52 = 0;
        label_43:
        this.sumBlue = val_52 + this.sumBlue;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsTeamDuel[(long)val_3 + val_47], 不且上一上丐三万丛:  this.三下东丞丟丘丕且丟.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  val_2);
        label_48:
        if(val_47 >= (UnityEngine.Mathf.Min(a:  this.丏业丅下且与丏丁丁.Count, b:  3)))
        {
            goto label_84;
        }
        
        if(this.丏业丅下且与丏丁丁.Item[0].丑丛丆三丆丄七丐万() == 1)
        {
            goto label_87;
        }
        
        val_58 = this.丏业丅下且与丏丁丁.Item[0];
        int val_32 = val_58.丑丛丆三丆丄七丐万();
        goto label_90;
        label_84:
        this.playersButtonsTeamDuel[(long)val_4 + val_47].UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        goto label_102;
        label_70:
        val_57 = 0;
        label_77:
        val_57 = val_57 + this.sumRed;
        this.sumRed = val_57;
        val_59 = null;
        val_59 = null;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  this.playersButtonsTeamDuel[(long)val_4 + val_47], 丕丛上丏丗丗丗且专:  Item[0], 七一丞丈万丛下丘上:  val_6);
        goto label_102;
        label_87:
        val_58 = 0;
        label_90:
        this.sumRed = val_58 + this.sumRed;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  this.playersButtonsTeamDuel[(long)val_4 + val_47], 不且上一上丐三万丛:  this.丏业丅下且与丏丁丁.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  val_6);
        label_102:
        val_47 = 1;
        label_10:
        if(val_47 < (((this.playersButtonsTeamDuel.Length < 0) ? (this.playersButtonsTeamDuel.Length + 1) : this.playersButtonsTeamDuel.Length) >> 1))
        {
            goto label_107;
        }
        
        if((且东丁丄业世丞丁不 != false) && (GameConnect.丑丌丛丈丅丅与不业() != 16))
        {
                if(this.totalBlue < this.sumBlue)
        {
                this.totalBlue = this.sumBlue;
        }
        
            if(this.totalRed < this.sumRed)
        {
                this.totalRed = this.sumRed;
        }
        
        }
        
        val_60 = 0;
        goto label_114;
        label_119:
        this.totalBlueTeamDuel[0].text = (val_2 == 2) ? this.totalRed : this.totalBlue.ToString();
        val_60 = 1;
        label_114:
        if(val_60 < this.totalBlueTeamDuel.Length)
        {
            goto label_119;
        }
        
        val_61 = 0;
        goto label_120;
        label_125:
        this.totalRedTeamDuel[0].text = (val_2 == 2) ? this.totalBlue : this.totalRed.ToString();
        val_61 = 1;
        label_120:
        if(val_61 < this.totalRedTeamDuel.Length)
        {
            goto label_125;
        }
    
    }
    private void 丕丕丂丒三丄上丝丌(bool 且东丁丄业世丞丁不 = False)
    {
        var val_69;
        int val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        int val_75;
        var val_76;
        var val_77;
        System.Collections.Generic.List<NetworkStartTable> val_78;
        var val_79;
        var val_80;
        var val_81;
        int val_82;
        var val_83;
        var val_84;
        val_69 = null;
        val_69 = null;
        if(null == 0)
        {
            goto label_4;
        }
        
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_4:
        if(且东丁丄业世丞丁不 == true)
        {
            goto label_6;
        }
        
        label_5:
        val_70 = 丘丑丅三丆丑丌且丝();
        label_6:
        int val_2 = UnityEngine.Mathf.Max(a:  0, b:  val_70);
        mem2[0] = 0;
        int val_5 = ((((val_2 == 0) ? 1 : 0) & GameConnect.丆丁上丟丛业丄丅丝()) != 0) ? (val_2) : (0 + 1);
        var val_7 = (GameConnect.丒丗丁丙丗丄丙不丐() != true) ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight;
        var val_69 = val_5;
        var val_70 = 6;
        var val_8 = (val_69 == 2) ? (val_70) : 0;
        var val_9 = (val_69 == 2) ? 0 : (val_70);
        val_69 = val_9 + 5;
        int val_11 = (val_69 == 0) ? 0 : ((val_69 != 2) ? (1 + 1) : 1);
        val_70 = val_8 + 5;
        var val_12 = val_7 + 32;
        val_69 = val_12 + val_69;
        val_12 = val_12 + val_70;
        val_71 = 0;
        goto label_134;
        label_147:
        if(且东丁丄业世丞丁不 == false)
        {
            goto label_15;
        }
        
        val_72 = null;
        val_72 = null;
        if(val_71 >= (UnityEngine.Mathf.Min(a:  Count, b:  5)))
        {
            goto label_41;
        }
        
        val_73 = null;
        val_73 = null;
        丈万且丗丂丝丙一东 val_15 = Item[0];
        if(val_15.丌与三与三丆丙一丟 == 1)
        {
            goto label_30;
        }
        
        val_74 = null;
        val_74 = null;
        丈万且丗丂丝丙一东 val_16 = Item[0];
        val_75 = val_16.丌与三与三丆丙一丟;
        goto label_37;
        label_15:
        if(val_71 >= (UnityEngine.Mathf.Min(a:  this.三下东丞丟丘丕且丟.Count, b:  5)))
        {
            goto label_41;
        }
        
        if(this.三下东丞丟丘丕且丟.Item[0].丑丛丆三丆丄七丐万() == 1)
        {
            goto label_44;
        }
        
        val_76 = this.三下东丞丟丘丕且丟.Item[0];
        int val_22 = val_76.丑丛丆三丆丄七丐万();
        goto label_47;
        label_41:
        if(val_71 == 5)
        {
                int val_71 = this.totalBlue;
            val_71 = val_71 - this.sumBlue;
            if(((val_71 >= 1) && (GameConnect.丑丌丛丈丅丅与不业() != 5)) && (GameConnect.丑丌丛丈丅丅与不业() != 17))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 36)
        {
            goto label_61;
        }
        
        }
        
        }
        
        }
        
        var val_27 = val_8 + val_71;
        var val_28 = val_7 + (((long)(int)((val_5 == 0x2 ? 6 : 0 + val_71))) << 3);
        label_140:
        (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + ((long)(int)((val_5 == 0x2 ? 6 : 0 + val_71))) << 3) + 32.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        if(且东丁丄业世丞丁不 == true)
        {
            goto label_65;
        }
        
        goto label_66;
        label_30:
        val_75 = 0;
        label_37:
        val_75 = val_75 + this.sumBlue;
        this.sumBlue = val_75;
        var val_29 = val_8 + val_71;
        val_77 = null;
        var val_30 = val_7 + (((long)(int)((val_5 == 0x2 ? 6 : 0 + val_71))) << 3);
        val_77 = null;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + ((long)(int)((val_5 == 0x2 ? 6 : 0 + val_71))) << 3) + 32, 丕丛上丏丗丗丗且专:  Item[0], 七一丞丈万丛下丘上:  val_5);
        label_65:
        val_79 = null;
        val_79 = null;
        if(val_71 >= (UnityEngine.Mathf.Min(a:  Count, b:  5)))
        {
            goto label_101;
        }
        
        val_80 = null;
        val_80 = null;
        丈万且丗丂丝丙一东 val_34 = Item[0];
        if(val_34.丌与三与三丆丙一丟 == 1)
        {
            goto label_88;
        }
        
        val_81 = null;
        val_81 = null;
        丈万且丗丂丝丙一东 val_35 = Item[0];
        val_82 = val_35.丌与三与三丆丙一丟;
        goto label_95;
        label_44:
        val_76 = 0;
        label_47:
        this.sumBlue = val_76 + this.sumBlue;
        var val_37 = val_8 + val_71;
        var val_38 = val_7 + (((long)(int)((val_5 == 0x2 ? 6 : 0 + val_71))) << 3);
        val_78 = this.三下东丞丟丘丕且丟;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + ((long)(int)((val_5 == 0x2 ? 6 : 0 + val_71))) << 3) + 32, 不且上一上丐三万丛:  val_78.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  val_5);
        label_66:
        if(val_71 >= (UnityEngine.Mathf.Min(a:  this.丏业丅下且与丏丁丁.Count, b:  5)))
        {
            goto label_101;
        }
        
        if(this.丏业丅下且与丏丁丁.Item[0].丑丛丆三丆丄七丐万() == 1)
        {
            goto label_104;
        }
        
        val_83 = this.丏业丅下且与丏丁丁.Item[0];
        int val_45 = val_83.丑丛丆三丆丄七丐万();
        goto label_107;
        label_101:
        if(val_71 == 5)
        {
                int val_72 = this.totalRed;
            val_72 = val_72 - this.sumRed;
            if(((val_72 >= 1) && (GameConnect.丑丌丛丈丅丅与不业() != 5)) && (GameConnect.丑丌丛丈丅丅与不业() != 17))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 36)
        {
            goto label_121;
        }
        
        }
        
        }
        
        }
        
        var val_50 = val_9 + val_71;
        var val_51 = val_7 + (((long)(int)((val_5 == 0x2 ? 0 : 6 + val_71))) << 3);
        label_145:
        (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + ((long)(int)((val_5 == 0x2 ? 0 : 6 + val_71))) << 3) + 32.UpdateState(东丅丞丁丗万且丁丗:  false, 东三丄丒丌丏下下丗:  false, 丐丛丂丈七且世业业:  false, 下丄丁丑三丏丗丛七:  0, 不丆业丏上丐与丌业:  "", 万且丒下丕丝专丟上:  "", 丂丌丙丝且东丗丙万:  "", 丈一七上丛丗丄丘丞:  "", 专世专丟丝丌与丘上:  1, 丅丈丛丅丝东七丂且:  0, 丛丄世丐丐丗且丈与:  "", 丒东三丌专丗三丂丟:  false, 丒丁丑丂丄丛丌上专:  0, 丏七丟丛与丞丐丄上:  false, 不丄丐上业丕且丝丝:  false, 丗丞丕不丌丑三三业:  false, 丐丑丘与丘丈丟丒且:  0, 专丛下不丄且丌丛丕:  false, 丏丝丁七丂且丕丑丕:  false);
        goto label_131;
        label_88:
        val_82 = 0;
        label_95:
        val_82 = val_82 + this.sumRed;
        this.sumRed = val_82;
        var val_52 = val_9 + val_71;
        val_84 = null;
        var val_53 = val_7 + (((long)(int)((val_5 == 0x2 ? 0 : 6 + val_71))) << 3);
        val_84 = null;
        this.丟丘不丅且丛丂一丅(丟丒丞丐丐丘丒丄东:  (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + ((long)(int)((val_5 == 0x2 ? 0 : 6 + val_71))) << 3) + 32, 丕丛上丏丗丗丗且专:  Item[0], 七一丞丈万丛下丘上:  val_11);
        goto label_131;
        label_104:
        val_83 = 0;
        label_107:
        this.sumRed = val_83 + this.sumRed;
        var val_56 = val_9 + val_71;
        var val_57 = val_7 + (((long)(int)((val_5 == 0x2 ? 0 : 6 + val_71))) << 3);
        val_78 = this.丏业丅下且与丏丁丁;
        this.上且丒丒丅丙与丙丂(丟丒丞丐丐丘丒丄东:  (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + ((long)(int)((val_5 == 0x2 ? 0 : 6 + val_71))) << 3) + 32, 不且上一上丐三万丛:  val_78.Item[0], 丙丄丕一丒丛丂丞下:  0, 七一丞丈万丛下丘上:  val_11);
        label_131:
        val_71 = 1;
        goto label_134;
        label_61:
        string val_60 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.totalBlue - this.sumBlue);
        if(val_12 != 0)
        {
            goto label_140;
        }
        
        goto label_140;
        label_121:
        string val_62 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.totalRed - this.sumRed);
        if(val_69 != 0)
        {
            goto label_145;
        }
        
        goto label_145;
        label_134:
        if(val_71 < ((((val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + 24) < 0) ? ((val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + 24) + 1) : (val_6 != true ? this.playersButtonsPlantTheBomb : this.playersButtonsTeamFight + 24)) >> 1))
        {
            goto label_147;
        }
        
        if((((((且东丁丄业世丞丁不 != false) && (GameConnect.丑丌丛丈丅丅与不业() != 33)) && (GameConnect.丑丌丛丈丅丅与不业() != 5)) && (GameConnect.丑丌丛丈丅丅与不业() != 16)) && (GameConnect.丑丌丛丈丅丅与不业() != 17)) && (GameConnect.丑丌丛丈丅丅与不业() != 36))
        {
                if(this.totalBlue < this.sumBlue)
        {
                this.totalBlue = this.sumBlue;
        }
        
            if(this.totalRed < this.sumRed)
        {
                this.totalRed = this.sumRed;
        }
        
        }
        
        this.且丂不丗丛丟丗丑丞(丂丆专不丙丘丞丕且:  val_5);
    }
    internal void 且丂不丗丛丟丗丑丞(int 丂丆专不丙丘丞丕且)
    {
        int val_12;
        var val_13;
        var val_14;
        UILabel[] val_15;
        var val_16;
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_3;
        }
        
        val_12 = this.totalRed;
        val_13 = 0;
        goto label_4;
        label_9:
        this.totalBlueTeamPlantTheBomb[0].text = System.String.Format(format:  "{0}", arg0:  (丂丆专不丙丘丞丕且 == 2) ? (val_12) : this.totalBlue.ToString());
        val_13 = 1;
        label_4:
        if(val_13 < this.totalBlueTeamPlantTheBomb.Length)
        {
            goto label_9;
        }
        
        val_14 = 0;
        goto label_10;
        label_15:
        this.totalRedTeamPlantTheBomb[0].text = System.String.Format(format:  "{0}", arg0:  (丂丆专不丙丘丞丕且 == 2) ? this.totalBlue : (val_12).ToString());
        val_14 = 1;
        label_10:
        val_15 = this.totalRedTeamPlantTheBomb;
        if(val_14 < this.totalRedTeamPlantTheBomb.Length)
        {
            goto label_15;
        }
        
        return;
        label_3:
        val_12 = this.totalBlue;
        val_16 = 0;
        goto label_17;
        label_22:
        this.totalBlueTeam[0].text = (丂丆专不丙丘丞丕且 == 2) ? this.totalRed : (val_12).ToString();
        val_16 = 1;
        label_17:
        if(val_16 < this.totalBlueTeam.Length)
        {
            goto label_22;
        }
        
        val_14 = 0;
        goto label_23;
        label_28:
        this.totalRedTeam[0].text = (丂丆专不丙丘丞丕且 == 2) ? (val_12) : this.totalRed.ToString();
        val_14 = 1;
        label_23:
        val_15 = this.totalRedTeam;
        if(val_14 < this.totalRedTeam.Length)
        {
            goto label_28;
        }
    
    }
    private void 三业丛丛丐万一丑丑()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        if(GameConnect.丞丂丑一丕丑丙三丐() != true)
        {
                if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
            goto label_6;
        }
        
        }
        
        val_16 = null;
        val_16 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_38;
        }
        
        val_17 = null;
        val_17 = null;
        this.totalBlue = typeof(TeamController).__il2cppRuntimeField_38;
        label_43:
        this.totalRed = typeof(TeamController).__il2cppRuntimeField_3C;
        goto label_38;
        label_6:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_22;
        }
        
        val_18 = null;
        val_18 = null;
        this.totalBlue = SiegeController.三三万丆下一丗万丛.GetTeam1Distance();
        this.totalRed = SiegeController.三三万丆下一丗万丛.GetTeam2Distance();
        goto label_38;
        label_22:
        val_19 = null;
        val_19 = null;
        if(GameController.onlineMode == 0)
        {
            goto label_38;
        }
        
        val_20 = null;
        val_20 = null;
        if(GameController.onlineMode.teamController == 0)
        {
            goto label_38;
        }
        
        val_21 = null;
        val_21 = null;
        this.totalBlue = typeof(TeamController).__il2cppRuntimeField_38;
        goto label_43;
        label_38:
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                this.丙东丌丆世上丄丂丅(且东丁丄业世丞丁不:  false);
            return;
        }
        
        if(this.丗丁丟丑三丟万丕丌 != false)
        {
                this.丕丕丂丒三丄上丝丌(且东丁丄业世丞丁不:  false);
            return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                this.丘丟一上丞一世丞丙(且东丁丄业世丞丁不:  false);
            return;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_56;
        }
        
        }
        
        this.且丑丕丒且丕丞丈丑();
        return;
        label_56:
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                this.丄丁丆世下丌丆东业(且东丁丄业世丞丁不:  false);
            return;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                this.丅丂七一丐丙丏下万(且东丁丄业世丞丁不:  false);
            return;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                this.丙业下丙七一丏丝七(且东丁丄业世丞丁不:  false);
            return;
        }
        
        this.丄东一万上业丙丈与(且东丁丄业世丞丁不:  false);
    }
    internal void 丟丛万丗丙丁且不不()
    {
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                this.丙东丌丆世上丄丂丅(且东丁丄业世丞丁不:  true);
            return;
        }
        
        if(this.丗丁丟丑三丟万丕丌 != false)
        {
                this.丕丕丂丒三丄上丝丌(且东丁丄业世丞丁不:  true);
            return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                this.丘丟一上丞一世丞丙(且东丁丄业世丞丁不:  false);
            return;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                this.丄丁丆世下丌丆东业(且东丁丄业世丞丁不:  true);
            return;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                this.丅丂七一丐丙丏下万(且东丁丄业世丞丁不:  true);
            return;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                this.丙业下丙七一丏丝七(且东丁丄业世丞丁不:  true);
            return;
        }
        
        this.丄东一万上业丙丈与(且东丁丄业世丞丁不:  true);
    }
    private void 丐丒丞丘丅下业丆不()
    {
        this.丝丌丟丟丏且东丑丗();
    }
    private void 一丐丕丈东丟丁丈且()
    {
        this.一丙丄丑丆业丞且万();
    }
    internal void 丆丈丟东丏一丞丐丆(bool 丛丅丘一丏丙且丌上)
    {
        bool val_1 = 丛丅丘一丏丙且丌上;
        this.七丂丝丅丞一丄丒与 = val_1;
        this.revengeContainer.SetActive(value:  val_1);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丙丟业上丛丘丕不丕, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != false)
        {
                UnityEngine.Vector3 val_5 = this.revBlueScore.transform.localPosition;
            this.丙丟业上丛丘丕不丕 = val_5;
            mem[1152921536047946268] = val_5.y;
            mem[1152921536047946272] = val_5.z;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.东三丂业丟丆丝一丕, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) != false)
        {
                UnityEngine.Vector3 val_9 = this.revBlueKills.transform.localPosition;
            this.东三丂业丟丆丝一丕 = val_9;
            mem[1152921536047946280] = val_9.y;
            mem[1152921536047946284] = val_9.z;
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.一丝东丗丄丒三丐丁, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) != false)
        {
                UnityEngine.Vector3 val_13 = this.revRedLvl.transform.localPosition;
            this.一丝东丗丄丒三丐丁 = val_13;
            mem[1152921536047946292] = val_13.y;
            mem[1152921536047946296] = val_13.z;
        }
        
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丙丒丟七三七丟东丞, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z})) != false)
        {
                UnityEngine.Vector3 val_17 = this.revRedNick.transform.localPosition;
            this.丙丒丟七三七丟东丞 = val_17;
            mem[1152921536047946304] = val_17.y;
            mem[1152921536047946308] = val_17.z;
        }
        
        if(丛丅丘一丏丙且丌上 != false)
        {
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        }
        else
        {
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  50f);
        }
        
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丙丟业上丛丘丕不丕, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        this.revBlueScore.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        if(丛丅丘一丏丙且丌上 != false)
        {
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
        }
        else
        {
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  50f);
        }
        
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.东三丂业丟丆丝一丕, y = val_22.y, z = val_22.x}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        this.revBlueKills.transform.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
        if(丛丅丘一丏丙且丌上 != false)
        {
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.zero;
        }
        else
        {
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  50f);
        }
        
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.一丝东丗丄丒三丐丁, y = val_27.y, z = val_27.x}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        this.revRedLvl.transform.localPosition = new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z};
        if(丛丅丘一丏丙且丌上 != false)
        {
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
        }
        else
        {
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  50f);
        }
        
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丙丒丟七三七丟东丞, y = val_32.y, z = val_32.x}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
        this.revRedNick.transform.localPosition = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
    }
    public RanksTable()
    {
        this.丐万丂丞万丌丐丞世 = new System.Collections.Generic.List<NetworkStartTable>();
        this.三下东丞丟丘丕且丟 = new System.Collections.Generic.List<NetworkStartTable>();
        this.丏业丅下且与丏丁丁 = new System.Collections.Generic.List<NetworkStartTable>();
        this.丑上丞丌丅丁东且丐 = new System.Collections.Generic.List<NetworkStartTable>();
        this.丆丕丒丁世一专业七 = "Others";
    }

}
