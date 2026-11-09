using UnityEngine;
public class InGameGUIPart_ArmRace : InGameGUIPartContainer
{
    // Fields
    private UILabel playerLevelLabel;
    private UILabel bestEnemyPlaceLabel;
    private UILabel bestEnemyLevelLabel;
    private UnityEngine.GameObject crownPlayer;
    private UnityEngine.GameObject crownEnemy;
    private UnityEngine.GameObject leaderObj;
    private UnityEngine.GameObject secondPlaceObj;
    private UITextureMasked prevWeaponIcon;
    private UnityEngine.GameObject prevWeaponSlot;
    private UILabel prevWeaponLevelLabel;
    private UITextureMasked curWeaponIcon;
    private UnityEngine.GameObject curWeaponSlot;
    private UILabel curWeaponLevelLabel;
    private UITextureMasked nextWeaponIcon;
    private UnityEngine.GameObject nextWeaponSlot;
    private UILabel nextWeaponLevelLabel;
    private UILabel curWeaponAmmo;
    private UnityEngine.GameObject eventGunPlash;
    private UILabel curWeaponNameLabel;
    public System.Collections.Generic.List<ArmRaceGunCell> cells;
    private UnityEngine.GameObject gunsScroll;
    private UnityEngine.GameObject gunCellStock;
    private WidgetLayout nameWidgetLayout;
    public UnityEngine.Vector3 startLocalMainGunPos;
    public float gunCellXstep;
    public float gunCellDistToDelete;
    private UnityEngine.GameObject gunsPanel;
    private UnityEngine.Vector3 丛丞丗七丌丌上业丐;
    private SimpleTweenePlayer myPlayerFinal;
    private bool 不万不丅丑下丛丆丞;
    private SimpleTweenePlayer enemyPlayerFinal;
    private bool 丙丄丌不丌丁上与专;
    private UnityEngine.AudioSource 不丁丙丑丂丘专丈丆;
    private UnityEngine.AudioClip soundKill;
    private UnityEngine.AudioClip soundChangeWeapon;
    private UnityEngine.GameObject sampleTween;
    private System.Collections.Generic.List<ArmRaceKillTweener> tweens;
    private UIGrid tweensGrid;
    
    // Properties
    private bool 丁七万丟丆丟不万丗 { get; }
    
    // Methods
    private void Awake()
    {
        var val_6;
        var val_7;
        var val_8;
        InGameGUI.丙丞专丌丁丞与不丐.丝三专丏与丗丌业上 = this;
        UnityEngine.Vector3 val_2 = this.curWeaponSlot.transform.localPosition;
        this.startLocalMainGunPos = val_2;
        mem[1152921538079087500] = val_2.y;
        mem[1152921538079087504] = val_2.z;
        this.丁丝不丙丆专丘丌丙();
        val_6 = null;
        val_6 = null;
        if(GameController.onlineMode == null)
        {
            goto label_6;
        }
        
        val_7 = null;
        if(null == val_7)
        {
            goto label_7;
        }
        
        label_6:
        val_8 = null;
        goto label_8;
        label_7:
        val_8 = val_7;
        label_8:
        var val_3 = (val_7 == val_8) ? GameController.onlineMode : 0;
        val_7 == val_8 ? GameController.onlineMode : 0 + 504.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void InGameGUIPart_ArmRace::丁丝不丙丆专丘丌丙()));
        this.不丁丙丑丂丘专丈丆 = this.GetComponent<UnityEngine.AudioSource>();
    }
    private void OnDestroy()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        label_4:
        var val_1 = (null == null) ? GameController.onlineMode : 0;
        onlineMode == null ? GameController.onlineMode : 0 + 504.丏丘丗丝丂丛丟丐丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void InGameGUIPart_ArmRace::丁丝不丙丆专丘丌丙()));
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        label_7:
        var val_3 = (null == null) ? GameController.onlineMode : 0;
        val_11 = System.Delegate.Remove(source:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 112, value:  new System.Action(object:  this, method:  System.Void InGameGUIPart_ArmRace::业丁且丅东丂东丕丏()));
        if((onlineMode == null ? GameController.onlineMode : 0 + 536) == 0)
        {
            goto label_9;
        }
        
        if(val_11 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_11 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_13:
        mem2[0] = val_11;
        if(GameController.onlineMode == null)
        {
            goto label_14;
        }
        
        val_12 = null;
        if(null == val_12)
        {
            goto label_15;
        }
        
        label_14:
        val_13 = null;
        goto label_16;
        label_15:
        val_13 = val_12;
        label_16:
        var val_7 = (val_12 == val_13) ? GameController.onlineMode : 0;
        val_14 = System.Delegate.Remove(source:  val_12 == val_13 ? GameController.onlineMode : 0 + 536 + 120, value:  new System.Action(object:  this, method:  System.Void InGameGUIPart_ArmRace::丝一丛丗丅七不丐丈()));
        if((val_12 == val_13 ? GameController.onlineMode : 0 + 536) == 0)
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
        mem2[0] = val_14;
    }
    private void 丁丝不丙丆专丘丌丙()
    {
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        七专丟丒七丆下丂丛 val_51;
        var val_52;
        System.Collections.Generic.List<ArmRaceGunCell> val_53;
        val_47 = null;
        val_47 = null;
        int val_1 = 丁丄一且丐丑丝丕丄();
        int val_2 = val_1 - 1;
        UnityEngine.Debug.LogError(message:  "myArmRaceLevel = "("myArmRaceLevel = ") + val_2);
        val_48 = null;
        val_48 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        label_10:
        var val_4 = (null == null) ? GameController.onlineMode : 0;
        if(val_2 == 0)
        {
            goto label_11;
        }
        
        if(val_1 != (onlineMode == null ? GameController.onlineMode : 0 + 536.MaxLevel))
        {
            goto label_13;
        }
        
        val_49 = 1152921538079359072;
        val_50 = 1152921524433534496;
        this.cells.Item[0].GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_1 - 2]);
        val_51 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_2];
        this.cells.Item[1].GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  val_51);
        this.cells.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_52 = this.cells.Item[1].transform;
        if(val_52 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_11:
        val_49 = 1152921538079364192;
        this.cells.Item[0].GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[0]);
        val_51 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[1];
        this.cells.Item[1].GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  val_51);
        goto label_43;
        label_13:
        float val_47 = this.gunCellXstep;
        val_47 = val_47 + val_47;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.startLocalMainGunPos, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_26 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.gunCellStock, position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, rotation:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w}, parent:  this.gunsScroll.transform);
        val_26.transform.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        if(val_26 != null)
        {
                val_26.SetActive(value:  true);
            val_49 = this;
            val_53 = this.cells;
        }
        else
        {
                val_26.SetActive(value:  true);
            val_49 = this;
            val_53 = this.cells;
        }
        
        val_53.Add(item:  val_26.gameObject.GetComponent<ArmRaceGunCell>());
        val_50 = 1152921538079364192;
        this.cells.Item[0].GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_1 - 2]);
        this.cells.Item[1].GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_2]);
        val_51 = this.cells.Item[2].GetComponent<ArmRaceGunCell>();
        val_51.东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_1]);
        this.cells.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.cells.Item[1].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_52 = this.cells.Item[2].transform;
        label_31:
        val_52.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_43:
        七专丟丒七丆下丂丛 val_46 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_2];
        this.一且丄万丂一丌上七(丏丟万且丝丒丝丅东:  val_46.killsToUpgrade);
        this.东上丅七丏与且丙专(丄专万专三丕丁世丈:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 76);
    }
    private void Start()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        label_4:
        var val_1 = (null == null) ? GameController.onlineMode : 0;
        val_11 = System.Delegate.Combine(a:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 112, b:  new System.Action(object:  this, method:  System.Void InGameGUIPart_ArmRace::业丁且丅东丂东丕丏()));
        if((onlineMode == null ? GameController.onlineMode : 0 + 536) == 0)
        {
            goto label_6;
        }
        
        if(val_11 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_11 == null)
        {
            goto label_10;
        }
        
        label_7:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_10:
        mem2[0] = val_11;
        if(GameController.onlineMode == null)
        {
            goto label_11;
        }
        
        val_12 = null;
        if(null == val_12)
        {
            goto label_12;
        }
        
        label_11:
        val_13 = null;
        goto label_13;
        label_12:
        val_13 = val_12;
        label_13:
        var val_5 = (val_12 == val_13) ? GameController.onlineMode : 0;
        val_14 = System.Delegate.Combine(a:  val_12 == val_13 ? GameController.onlineMode : 0 + 536 + 120, b:  new System.Action(object:  this, method:  System.Void InGameGUIPart_ArmRace::丝一丛丗丅七不丐丈()));
        if((val_12 == val_13 ? GameController.onlineMode : 0 + 536) == 0)
        {
            goto label_15;
        }
        
        if(val_14 != null)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(val_14 == null)
        {
            goto label_19;
        }
        
        label_16:
        if(null != null)
        {
                val_14 = 0;
        }
        
        label_19:
        mem2[0] = val_14;
        this.tweensGrid.enabled = false;
        this.tweensGrid.enabled = true;
        UnityEngine.Vector3 val_9 = this.gunsPanel.transform.localPosition;
        this.丛丞丗七丌丌上业丐 = val_9;
        mem[1152921538079921308] = val_9.y;
        mem[1152921538079921312] = val_9.z;
    }
    private void 丝一丛丗丅七不丐丈()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        if(GameController.onlineMode == null)
        {
            goto label_3;
        }
        
        val_6 = null;
        if(null == val_6)
        {
            goto label_4;
        }
        
        label_3:
        val_7 = null;
        goto label_5;
        label_4:
        val_7 = val_6;
        label_5:
        var val_1 = (val_6 == val_7) ? GameController.onlineMode : 0;
        this.tweens.Item[(val_6 == val_7 ? GameController.onlineMode : 0 + 536 + 76) - 1].PlayKillAnimation();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.不丁丙丑丂丘专丈丆.PlayOneShot(clip:  this.soundKill);
    }
    private void 东上丅七丏与且丙专(int 丄专万专三丕丁世丈)
    {
        var val_2;
        if(丄专万专三丕丁世丈 < 1)
        {
                return;
        }
        
        do
        {
            this.tweens.Item[0].PlayKillAnimation();
            val_2 = 0 + 1;
        }
        while(丄专万专三丕丁世丈 != val_2);
    
    }
    private void Update()
    {
        int val_61;
        object val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        UILabel val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        val_61 = this;
        val_62 = 1152921504848912384;
        if((RespawnWindow.丑七不且上丗丁一世() != 0) && (RespawnWindow.丑七不且上丗丁一世().isShown != false))
        {
                val_63 = 0;
        }
        else
        {
                if(PauseGUIController.丑七不且上丗丁一世() != 0)
        {
                val_63 = (~PauseGUIController.丑七不且上丗丁一世().IsPaused) & 1;
        }
        else
        {
                val_63 = 1;
        }
        
        }
        
        UnityEngine.Transform val_9 = this.gunsPanel.transform;
        if(val_63 == 0)
        {
            goto label_17;
        }
        
        label_64:
        val_9.localPosition = new UnityEngine.Vector3() {x = this.丛丞丗七丌丌上业丐, y = V9.16B, z = V10.16B};
        val_64 = null;
        val_64 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_65 = null;
        val_65 = null;
        UnityEngine.Object val_59 = 0;
        bool val_11 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  val_59);
        if(val_11 == true)
        {
                return;
        }
        
        val_59 = (~val_11.业专丗且丏丘丘三丐()) & 1;
        this.leaderObj.SetActive(value:  val_59);
        this.secondPlaceObj.SetActive(value:  this.leaderObj.业专丗且丏丘丘三丐());
        this.crownPlayer.SetActive(value:  this.secondPlaceObj.业专丗且丏丘丘三丐());
        this.crownEnemy.SetActive(value:  (~this.crownPlayer.业专丗且丏丘丘三丐()) & 1);
        val_66 = null;
        val_66 = null;
        int val_19 = typeof(Player_move_c).__il2cppRuntimeField_618.丁丄一且丐丑丝丕丄();
        val_67 = null;
        val_67 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_42;
        }
        
        }
        
        label_42:
        var val_20 = (null == null) ? GameController.onlineMode : 0;
        val_68 = this.playerLevelLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_68, 丕丗丘丑丛与丑业丒:  val_19 + "/"("/") + onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Count(onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Count));
        if(this.不万不丅丑下丛丆丞 == true)
        {
            goto label_54;
        }
        
        val_69 = null;
        val_69 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_52;
        }
        
        }
        
        label_52:
        var val_23 = (null == null) ? GameController.onlineMode : 0;
        val_68 = onlineMode == null ? GameController.onlineMode : 0 + 536;
        if(val_68.isFinalLoadout != false)
        {
                this.不万不丅丑下丛丆丞 = true;
            val_68 = this.myPlayerFinal;
            val_68.Play();
        }
        
        label_54:
        bool val_25 = val_68.业专丗且丏丘丘三丐();
        if(val_25 == false)
        {
            goto label_56;
        }
        
        val_68 = NetworkStartTable.下上丞丞丏丅丕丏世();
        var val_28 = (val_68.Count > 1) ? 1 : 0;
        goto label_60;
        label_17:
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丛丞丗七丌丌上业丐, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(val_9 != null)
        {
            goto label_64;
        }
        
        goto label_64;
        label_56:
        val_70 = 0;
        label_60:
        if(((this.丙丄丌不丌丁上与专 == true) || (val_25.业专丗且丏丘丘三丐() == true)) || (NetworkStartTable.下上丞丞丏丅丕丏世().Count < 2))
        {
            goto label_82;
        }
        
        val_71 = null;
        val_71 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_78;
        }
        
        }
        
        label_78:
        var val_36 = (null == null) ? GameController.onlineMode : 0;
        if(NetworkStartTable.下上丞丞丏丅丕丏世().Item[0].丁丄一且丐丑丝丕丄() == (onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Count))
        {
                this.丙丄丌不丌丁上与专 = true;
            this.enemyPlayerFinal.Play();
        }
        
        label_82:
        int val_40 = NetworkStartTable.下上丞丞丏丅丕丏世().Item[0].丁丄一且丐丑丝丕丄();
        val_62 = val_40;
        val_72 = null;
        val_72 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_91;
        }
        
        }
        
        label_91:
        var val_41 = (null == null) ? GameController.onlineMode : 0;
        val_61 = val_19 - 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.bestEnemyLevelLabel, 丕丗丘丑丛与丑业丒:  val_40 + "/"("/") + onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Count(onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Count));
        if((val_61 & 2147483648) != 0)
        {
                return;
        }
        
        val_73 = null;
        val_73 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_101;
        }
        
        }
        
        label_101:
        var val_44 = (null == null) ? GameController.onlineMode : 0;
        if(val_61 >= (onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Count))
        {
                return;
        }
        
        val_74 = null;
        val_74 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_109;
        }
        
        }
        
        label_109:
        var val_46 = (null == null) ? GameController.onlineMode : 0;
        if(val_61 < 1)
        {
            goto label_113;
        }
        
        val_75 = null;
        val_75 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_117;
        }
        
        }
        
        label_117:
        var val_48 = (null == null) ? GameController.onlineMode : 0;
        七专丟丒七丆下丂丛 val_49 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_61];
        label_113:
        val_76 = null;
        val_76 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_124;
        }
        
        }
        
        label_124:
        var val_50 = (null == null) ? GameController.onlineMode : 0;
        val_62 = mem[onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40];
        val_62 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40;
        if(val_61 >= (val_62.Count - 1))
        {
            goto label_128;
        }
        
        val_77 = null;
        val_77 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_132;
        }
        
        }
        
        label_132:
        var val_53 = (null == null) ? GameController.onlineMode : 0;
        val_62 = mem[onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40];
        val_62 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40;
        七专丟丒七丆下丂丛 val_54 = val_62.Item[val_61];
        label_128:
        val_78 = null;
        val_78 = null;
        int val_56 = 丙不丅丕三丂业东丕().AmmoInClip;
        val_79 = null;
        val_79 = null;
        if(GameController.onlineMode == null)
        {
            goto label_144;
        }
        
        val_80 = null;
        if(null == val_80)
        {
            goto label_145;
        }
        
        label_144:
        val_81 = null;
        goto label_146;
        label_145:
        val_81 = val_80;
        label_146:
        var val_57 = (val_80 == val_81) ? GameController.onlineMode : 0;
        int val_58 = typeof(Player_move_c).__il2cppRuntimeField_618.丁丄一且丐丑丝丕丄();
        if((onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_61]) != null)
        {
                return;
        }
    
    }
    private void 业丁且丅东丂东丕丏()
    {
        var val_24;
        var val_25;
        七专丟丒七丆下丂丛 val_26;
        System.Collections.Generic.List<ArmRaceGunCell> val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_24 = null;
        val_24 = null;
        val_25 = null;
        val_25 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        label_9:
        var val_2 = (null == null) ? GameController.onlineMode : 0;
        val_26 = mem[onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40];
        val_26 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40;
        if((typeof(Player_move_c).__il2cppRuntimeField_618.丁丄一且丐丑丝丕丄() - 1) >= (val_26.Count - 1))
        {
            goto label_13;
        }
        
        float val_24 = this.gunCellXstep;
        val_24 = val_24 + val_24;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.startLocalMainGunPos, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(this.gunCellStock == 0)
        {
                UnityEngine.Debug.LogError(message:  "GUN CELL STOCK IS NULL in InGameGUIPart_ArmRace");
        }
        
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.gunCellStock, position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, parent:  this.gunsScroll.transform);
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        if(val_10 != null)
        {
                val_10.SetActive(value:  true);
            val_27 = this.cells;
        }
        else
        {
                val_10.SetActive(value:  true);
            val_27 = this.cells;
        }
        
        val_27.Add(item:  val_10.gameObject.GetComponent<ArmRaceGunCell>());
        val_28 = null;
        val_28 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_35;
        }
        
        }
        
        label_35:
        var val_14 = (null == null) ? GameController.onlineMode : 0;
        val_29 = null;
        val_29 = null;
        七专丟丒七丆下丂丛 val_16 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[丁丄一且丐丑丝丕丄()];
        三丅丁丗丗丝丂万且 val_17 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_16.weaponId);
        if(GameController.onlineMode == null)
        {
            goto label_47;
        }
        
        val_30 = null;
        if(null == val_30)
        {
            goto label_48;
        }
        
        label_47:
        val_31 = null;
        goto label_49;
        label_48:
        val_31 = val_30;
        label_49:
        var val_19 = (val_30 == val_31) ? GameController.onlineMode : 0;
        val_26 = val_30 == val_31 ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[丁丄一且丐丑丝丕丄()];
        val_10.GetComponent<ArmRaceGunCell>().东业丌丁三丞丗丛万(专丈丈丅不丅与三世:  val_26);
        label_13:
        UnityEngine.Coroutine val_23 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丏业丕丐下丕东丘不());
    }
    private System.Collections.IEnumerator 丏业丕丐下丕东丘不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InGameGUIPart_ArmRace.丌上业一丏不丏丆东();
    }
    private void 一且丄万丂一丌上七(int 丏丟万且丝丒丝丅东)
    {
        var val_3;
        System.Collections.Generic.List<ArmRaceKillTweener> val_12;
        int val_12 = 丏丟万且丝丒丝丅东;
        List.Enumerator<T> val_1 = this.tweens.GetEnumerator();
        label_9:
        if(((-885471744) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Object.Destroy(obj:  val_4.gameObject);
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        System.Collections.Generic.List<ArmRaceKillTweener> val_7 = null;
        val_12 = val_7;
        val_7 = new System.Collections.Generic.List<ArmRaceKillTweener>();
        this.tweens = val_12;
        if(val_12 > 0)
        {
                do
        {
            val_12 = this.tweens;
            val_12.Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.sampleTween, parent:  this.tweensGrid.transform).gameObject.GetComponent<ArmRaceKillTweener>());
            val_12 = val_12 - 1;
        }
        while(val_12 != 0);
        
        }
        
        this.tweensGrid.enabled = true;
    }
    private bool 业专丗且丏丘丘三丐()
    {
        var val_6;
        WeaponManager val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 != 0)
        {
                val_8 = null;
            val_8 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_7 != 0)
        {
                NetworkStartTable val_4 = NetworkStartTable.下上丞丞丏丅丕丏世().Item[0];
            val_9 = null;
            val_7 = val_4.丌丑丛业丈丘世丞丕;
            val_9 = null;
            if(val_7 == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
                val_10 = 1;
            return (bool)val_10;
        }
        
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    public InGameGUIPart_ArmRace()
    {
        this.cells = new System.Collections.Generic.List<ArmRaceGunCell>();
        this.gunCellXstep = 133f;
        this.gunCellDistToDelete = -266f;
        this.tweens = new System.Collections.Generic.List<ArmRaceKillTweener>();
    }

}
