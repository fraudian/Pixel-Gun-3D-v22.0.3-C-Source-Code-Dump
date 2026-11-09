using UnityEngine;
public class TeamDuelUI : MonoBehaviour
{
    // Fields
    public TeamDuelPlayerInfo[] blueTeamInfo;
    public TeamDuelPlayerInfo[] redTeamInfo;
    public UILabel gameStatusLabel;
    public UILabel gameStatusLabelEnd;
    public UnityEngine.GameObject startInterface;
    public UnityEngine.GameObject endInterface;
    public UnityEngine.GameObject stickersInterface;
    public UnityEngine.GameObject titleVictory;
    public UnityEngine.GameObject titleDefeat;
    public UnityEngine.GameObject battleBeginLabel;
    public Rilisoft.ButtonHandler nextTeamButton;
    public Rilisoft.ButtonHandler revengeButton;
    public Rilisoft.ButtonHandler competitionButton;
    public UnityEngine.GameObject revengePanel;
    public UILabel revengeLabel;
    private System.Collections.Generic.Dictionary<string, int> 丛丗丁丛丆丟丌丙下;
    private System.Collections.Generic.Dictionary<string, int> 万丐一东丟丈专与丅;
    public int blueIconsCount;
    public int redIconsCount;
    public UnityEngine.GameObject endBackButtons;
    
    // Methods
    public void ShowStartInterface()
    {
        var val_1;
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丞三专丈业丈丙丆丘();
        typeof(RanksTable).__il2cppRuntimeField_1F8 = 0;
        this.startInterface.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.endInterface.SetActive(value:  false);
        this.stickersInterface.SetActive(value:  true);
        val_1 = null;
        val_1 = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_7B = 1;
        typeof(NetworkStartTable).__il2cppRuntimeField_14D = 1;
    }
    internal void 丒丈丗三专丅丒丌三(bool 丑一丂丙丈丝丑丅丑, bool 专东丘一三丐不丈专)
    {
        bool val_5 = 丑一丂丙丈丝丑丅丑;
        bool val_1 = 专东丘一三丐不丈专 ^ 1;
        丑一丂丙丈丝丑丅丑 = val_1 & val_5;
        this.titleVictory.SetActive(value:  丑一丂丙丈丝丑丅丑);
        val_5 = val_5 ^ 1 & val_1;
        this.titleDefeat.SetActive(value:  val_5);
    }
    internal void 丂世丈丅丟且丆丑丝()
    {
        var val_8;
        var val_9;
        this.startInterface.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  true);
        this.endInterface.SetActive(value:  ((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) != 0) ? 1 : 0);
        this.stickersInterface.SetActive(value:  ((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) != 0) ? 1 : 0);
        val_8 = null;
        val_8 = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_7B = 0;
        typeof(NetworkStartTable).__il2cppRuntimeField_14D = 1;
        typeof(RanksTable).__il2cppRuntimeField_1F8 = 1;
        丆丈丟东丏一丞丐丆(丛丅丘一丏丙且丌上:  ((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) != 0) ? 1 : 0);
        val_9 = null;
        val_9 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
                return;
        }
        
        if(this.competitionButton == 0)
        {
                return;
        }
        
        this.competitionButton.gameObject.SetActive(value:  ((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) != 0) ? 1 : 0);
        this.competitionButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟, method:  System.Void NetworkStartTableNGUIController::与下丘万丌丆万丟丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal void 丏丛丈东丘丏丏下丁()
    {
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  0);
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丆丄上丛丝东丅专东();
    }
    internal void 一丞丄丗世丟业丌万()
    {
        SetActive(value:  false);
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.业七万七专丄丑万丘();
    }
    internal void 丆东世丝万丆下丞一()
    {
        var val_1;
        typeof(RanksTable).__il2cppRuntimeField_1F8 = 0;
        丆丈丟东丏一丞丐丆(丛丅丘一丏丙且丌上:  false);
        val_1 = null;
        val_1 = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_7B = 0;
        typeof(NetworkStartTable).__il2cppRuntimeField_14D = 1;
        this.startInterface.SetActive(value:  false);
        this.endInterface.SetActive(value:  false);
        this.stickersInterface.SetActive(value:  false);
    }
    private void Awake()
    {
        System.EventHandler val_9;
        var val_10;
        if(this.nextTeamButton != 0)
        {
                System.EventHandler val_2 = null;
            val_9 = val_2;
            val_2 = new System.EventHandler(object:  this, method:  System.Void TeamDuelUI::丙丏三丁丏专下丁且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.nextTeamButton.add_Clicked(丙业与丙丗丝不丈东:  val_2);
        }
        
        if(this.revengeButton != 0)
        {
                System.EventHandler val_4 = null;
            val_9 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void TeamDuelUI::丂业丁下丙与丆丌丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.revengeButton.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        val_10 = null;
        val_10 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
                return;
        }
        
        this.nextTeamButton.gameObject.SetActive(value:  false);
        this.revengeButton.gameObject.SetActive(value:  false);
        if(this.competitionButton != 0)
        {
                this.competitionButton.gameObject.SetActive(value:  false);
        }
        
        if(this.endBackButtons == null)
        {
                return;
        }
        
        this.endBackButtons.SetActive(value:  false);
    }
    private void Update()
    {
        this.上丝业丝丕专丐丗丄();
    }
    private void 上丝业丝丕专丐丗丄()
    {
        if((this.nextTeamButton.GetComponent<UIButton>()) == 0)
        {
                return;
        }
        
        bool val_4 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    internal void 丂万与丙上丐一且一()
    {
        this.万丐一东丟丈专与丅.Clear();
        this.丛丗丁丛丆丟丌丙下.Clear();
        this.blueIconsCount = 0;
        this.redIconsCount = 0;
    }
    internal void 丕上丕丗丆丛东丏专(TeamDuelPlayerIcon[] 丌丏丅丕丗世专丝丛, TeamDuelPlayerIcon[] 上丆丐丘丘丗东丘丒)
    {
        TeamDuelPlayerIcon val_26;
        var val_27;
        NetworkStartTable val_28;
        var val_29;
        int val_30;
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        var val_35;
        val_26 = 1152921505286238208;
        val_27 = null;
        val_27 = null;
        val_28 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_28 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_28 == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        val_28 = 丘丑丅三丆丑丌且丝();
        if(val_28 < 1)
        {
                return;
        }
        
        if(TeamDuelController.丅丌丛丏丞上万丛丕 != 0)
        {
                val_26 = mem[val_28 == 1 ? (TeamDuelController.丅丌丛丏丞上万丛丕 + 72) : (TeamDuelController.丅丌丛丏丞上万丛丕 + 80)];
            val_26 = (val_28 == 1) ? (TeamDuelController.丅丌丛丏丞上万丛丕 + 72) : (TeamDuelController.丅丌丛丏丞上万丛丕 + 80);
            val_30 = TeamDuelController.丅丌丛丏丞上万丛丕;
        }
        else
        {
                val_26 = mem[val_28 == 1 ? (TeamDuelController.丅丌丛丏丞上万丛丕 + 72) : (TeamDuelController.丅丌丛丏丞上万丛丕 + 80)];
            val_26 = (val_28 == 1) ? (TeamDuelController.丅丌丛丏丞上万丛丕 + 72) : (TeamDuelController.丅丌丛丏丞上万丛丕 + 80);
            val_30 = TeamDuelController.丅丌丛丏丞上万丛丕;
            if(val_30 == 0)
        {
                val_30 = 0;
        }
        
        }
        
        val_30 = val_30 + 80;
        var val_9 = (val_28 == 1) ? (val_30) : 72;
        val_31 = 1152921525488042576;
        val_32 = 0;
        goto label_15;
        label_33:
        NetworkStartTable val_10 = val_26.Item[0];
        if((this.丛丗丁丛丆丟丌丙下.ContainsKey(key:  val_10.丈三世丞丕万丄七丂)) == true)
        {
            goto label_19;
        }
        
        val_33 = this.blueIconsCount;
        if(val_33 >= 丌丏丅丕丗世专丝丛.Length)
        {
            goto label_21;
        }
        
        NetworkStartTable val_12 = val_26.Item[0];
        this.blueIconsCount = this.blueIconsCount + 1;
        this.丛丗丁丛丆丟丌丙下.Add(key:  val_12.丈三世丞丕万丄七丂, value:  this.blueIconsCount);
        val_31 = 1152921525488042576;
        label_19:
        NetworkStartTable val_14 = val_26.Item[0];
        val_33 = 丌丏丅丕丗世专丝丛[(long)this.丛丗丁丛丆丟丌丙下.Item[val_14.丈三世丞丕万丄七丂]];
        val_33.丑七下业与丕丛丅丕(不且上一上丐三万丛:  val_26.Item[0]);
        label_21:
        val_32 = 1;
        label_15:
        if(val_32 < val_26.Count)
        {
            goto label_33;
        }
        
        val_34 = 0;
        goto label_34;
        label_38:
        val_26 = 丌丏丅丕丗世专丝丛[0];
        val_26.UpdateState();
        val_34 = 1;
        label_34:
        if(val_34 < 丌丏丅丕丗世专丝丛.Length)
        {
            goto label_38;
        }
        
        val_35 = 0;
        goto label_39;
        label_57:
        NetworkStartTable val_18 = val_9.Item[0];
        if((this.万丐一东丟丈专与丅.ContainsKey(key:  val_18.丈三世丞丕万丄七丂)) == true)
        {
            goto label_43;
        }
        
        val_26 = this.redIconsCount;
        if(val_26 >= 上丆丐丘丘丗东丘丒.Length)
        {
            goto label_45;
        }
        
        NetworkStartTable val_20 = val_9.Item[0];
        val_33 = val_20.丈三世丞丕万丄七丂;
        this.redIconsCount = this.redIconsCount + 1;
        this.万丐一东丟丈专与丅.Add(key:  val_33, value:  this.redIconsCount);
        label_43:
        NetworkStartTable val_22 = val_9.Item[0];
        val_26 = 上丆丐丘丘丗东丘丒[(long)this.万丐一东丟丈专与丅.Item[val_22.丈三世丞丕万丄七丂]];
        val_26.丑七下业与丕丛丅丕(不且上一上丐三万丛:  val_9.Item[0]);
        label_45:
        val_35 = 1;
        label_39:
        if(val_35 < val_9.Count)
        {
            goto label_57;
        }
        
        val_28 = 0;
        goto label_58;
        label_62:
        上丆丐丘丘丗东丘丒[0].UpdateState();
        val_28 = 1;
        label_58:
        if(val_28 < 上丆丐丘丘丗东丘丒.Length)
        {
            goto label_62;
        }
    
    }
    internal void 东丅丛丈丙上世丑丘(System.Collections.Generic.List<NetworkStartTable> 丒七丈丏丏与丛丌丘, System.Collections.Generic.List<NetworkStartTable> 丐且丈丝丕丕一丒与, System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丆丄丈丝不且丟与丒, System.Collections.Generic.List<与丅丕丈丘东丝世丟> 与业万业丈丟业不丐)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        TeamDuelPlayerInfo[] val_22;
        var val_23;
        val_17 = 与业万业丈丟业不丐;
        val_18 = 0;
        goto label_6;
        label_13:
        this.blueTeamInfo[0].与万不丄丄东丁与业(不且上一上丐三万丛:  丒七丈丏丏与丛丌丘.Item[0]);
        val_18 = 1;
        goto label_6;
        label_9:
        if(丒七丈丏丏与丛丌丘 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        if(this.blueTeamInfo == null)
        {
            goto label_9;
        }
        
        label_8:
        if(val_18 < (UnityEngine.Mathf.Min(a:  this.blueTeamInfo.Length, b:  丒七丈丏丏与丛丌丘.Count)))
        {
            goto label_13;
        }
        
        val_19 = 0;
        goto label_19;
        label_26:
        this.redTeamInfo[0].与万不丄丄东丁与业(不且上一上丐三万丛:  丐且丈丝丕丕一丒与.Item[0]);
        val_19 = 1;
        goto label_19;
        label_22:
        if(丐且丈丝丕丕一丒与 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_19:
        if(this.redTeamInfo == null)
        {
            goto label_22;
        }
        
        label_21:
        if(val_19 < (UnityEngine.Mathf.Min(a:  this.redTeamInfo.Length, b:  丐且丈丝丕丕一丒与.Count)))
        {
            goto label_26;
        }
        
        val_20 = 1152921525961884688;
        val_21 = 丒七丈丏丏与丛丌丘.Count;
        goto label_28;
        label_39:
        int val_10 = val_21 - 丒七丈丏丏与丛丌丘.Count;
        TeamDuelPlayerInfo val_19 = this.blueTeamInfo[(long)val_21];
        if(val_10 < 丆丄丈丝不且丟与丒.Count)
        {
                val_20 = val_20;
            val_19.FillFromPlayerSettings(专丞上七七且丝七丗:  丆丄丈丝不且丟与丒.Item[val_10]);
        }
        else
        {
                val_19.Clear();
            val_20 = val_20;
        }
        
        val_17 = val_17;
        val_21 = val_21 + 1;
        label_28:
        val_22 = this.blueTeamInfo;
        if(val_21 < this.blueTeamInfo.Length)
        {
            goto label_39;
        }
        
        val_23 = 丐且丈丝丕丕一丒与.Count;
        goto label_41;
        label_52:
        val_22 = val_17.Count;
        int val_15 = val_23 - 丐且丈丝丕丕一丒与.Count;
        TeamDuelPlayerInfo val_20 = this.redTeamInfo[(long)val_23];
        if(val_15 < val_22)
        {
                val_20.FillFromPlayerSettings(专丞上七七且丝七丗:  val_17.Item[val_15]);
        }
        else
        {
                val_20.Clear();
        }
        
        val_23 = val_23 + 1;
        label_41:
        if(val_23 < this.redTeamInfo.Length)
        {
            goto label_52;
        }
    
    }
    private void 丙丏三丁丏专下丁且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        丘丐丞上世丏一且业();
    }
    internal void 专丆丅丘七丟丅丈丌(bool 丛丅丘一丏丙且丌上)
    {
        UIButton val_1 = this.revengeButton.GetComponent<UIButton>();
        bool val_2 = 丛丅丘一丏丙且丌上;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    internal void 丝上与且丞且丑丒专(string 东丟丐业丏一下丕与)
    {
        this.revengePanel.SetActive(value:  true);
        this.revengeLabel.text = 东丟丐业丏一下丕与;
    }
    private void 丂业丁下丙与丆丌丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        TeamDuelController.丅丌丛丏丞上万丛丕.专丘丙丞专世丐丛丑();
    }
    public TeamDuelUI()
    {
        this.丛丗丁丛丆丟丌丙下 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        this.万丐一东丟丈专与丅 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
    }

}
