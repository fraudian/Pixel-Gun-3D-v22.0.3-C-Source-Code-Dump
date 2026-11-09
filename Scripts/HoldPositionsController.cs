using UnityEngine;
internal sealed class HoldPositionsController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal HoldPositionsPointsController pointsController;
    private bool enableForAllModes;
    private string 丙专丈与专一丙且丕;
    public int spotLimit;
    public double spotLifeTime;
    public bool spotComebackSpawn;
    private int 与丟业不丒丁丞丙丕;
    public float spotSpawnDelay;
    internal bool 世丛丞丗丈丘丘东丅;
    public bool oneTimeCapture;
    internal float 丆不丕三丅丑丑丑丐;
    internal float 下丈下三丛上丌丌丄;
    private float 上与业与且业丒丝丁;
    internal float 万七丞丙丑与一丑丁;
    private float 与丕七东丒一不东七;
    internal bool 丅丁东三丝业且与丙;
    private float 丅丂丗丒下丄丆丞三;
    internal bool 丌上且东丐丁丐专与;
    internal float 下丞丂三万丁丄丄上;
    internal int 丘丒丑丅东丄丐丗丈;
    public int winPointsLimit;
    public int matchTime;
    private static System.Action<float, float> 不丈七三三丙万丛丗;
    internal static HoldPositionsController 丆丕丝丒不丙且丐丗;
    private bool 丙丞丛丕丅世下丅丒;
    private bool 丘丕丄与丈七与下三;
    private bool 丑且不丈丐三丝丏丂;
    private bool 专丙丐丄丂丑上丑丈;
    private bool 丆丁丆丟丄丛丁万丛;
    private float 下丅丑业丗一丌且丛;
    private bool 七丕三上丂丈丅丅三;
    private float 丝一且丞丛下丟丞世;
    public float spotAllowCaptureDelay;
    internal System.Action 丂丈丒丂上业丕丘世;
    public bool configGetted;
    private static string 三与一不丅上丘下与;
    private bool 下丁业丑万丄丟丝下;
    private float <丌丅丟丈丗专丏专下>k__BackingField;
    private float <丆且丂丗丈三且专七>k__BackingField;
    private bool 万与丟且丘一万丗与;
    
    // Properties
    internal bool 丏世丏丐丟丘与与丌 { get; }
    internal bool 专丛不且丗丒丄世与 { get; }
    internal float 丌万上丛丕七丂东丏 { get; set; }
    internal float 丝丟丛专丛丗专丗世 { get; set; }
    public int 万丆丈与丟丄丐丌丂 { get; }
    
    // Methods
    internal static void 丌专丟丁三上丌专三(System.Action<float, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  HoldPositionsController.不丈七三三丙万丛丗, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 三丏万不丒万不一丝(System.Action<float, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  HoldPositionsController.不丈七三三丙万丛丗, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal bool 上丕丁丆丈丈丂丑七()
    {
        if(this.丘丕丄与丈七与下三 == false)
        {
                return false;
        }
        
        return (bool)(this.丆丁丆丟丄丛丁万丛 == true) ? 1 : 0;
    }
    internal bool 丙丗丅七丁丝丗丁上()
    {
        return (bool)this.下丁业丑万丄丟丝下;
    }
    internal float 丈丂丟丕丕丒丗万丞()
    {
        return (float)this.<丌丅丟丈丗专丏专下>k__BackingField;
    }
    private void 世业丂丟丌丟丝丂业(float 丙业与丙丗丝不丈东)
    {
        this.<丌丅丟丈丗专丏专下>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal float 三东七世丐与不下丛()
    {
        return (float)this.<丆且丂丗丈三且专七>k__BackingField;
    }
    private void 与丒丗三丞业业丄万(float 丙业与丙丗丝不丈东)
    {
        this.<丆且丂丗丈三且专七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void FillAllValues()
    {
        var val_37;
        var val_38;
        object val_39;
        var val_40;
        var val_42;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_43;
        var val_44;
        var val_45;
        val_37 = null;
        val_37 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  HoldPositionsController.三与一不丅上丘下与)) != false)
        {
                val_38 = null;
            val_38 = null;
            val_39 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[HoldPositionsController.三与一不丅上丘下与];
        }
        else
        {
                val_39 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  122);
            ExitGames.Client.Photon.Hashtable val_9 = new ExitGames.Client.Photon.Hashtable();
            val_40 = null;
            val_40 = null;
            val_9.set_Item(key:  HoldPositionsController.三与一不丅上丘下与, value:  val_39);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        this.configGetted = true;
        this.丙专丈与专一丙且丕 = true;
        val_42 = null;
        val_42 = null;
        val_43 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_43 != null)
        {
                val_43 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_43 == null)
        {
                val_43 = 0;
        }
        
            string val_13 = val_43.丕丅丌丐丙丈丄丁丅();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_13)) != false)
        {
                val_44 = null;
            val_44 = null;
            if((val_13.ContainsKey(key:  GameConnect.丈丝丂丐丟万丙丑丕.丕丅丌丐丙丈丄丁丅())) != false)
        {
                val_45 = null;
            val_45 = null;
            this.丙专丈与专一丙且丕 = GameConnect.丈丝丂丐丟万丙丑丕.丕丅丌丐丙丈丄丁丅();
        }
        
        }
        
        }
        
        this.spotLimit = val_18.spotLimit;
        this.spotLifeTime = (double)val_19.spotLifetime;
        this.spotComebackSpawn = val_20.spotComebackSpawn;
        this.与丟业不丒丁丞丙丕 = val_21.teamLoseDifference;
        this.spotSpawnDelay = 0f;
        this.spotAllowCaptureDelay = (float)val_22.spotSpawDelay;
        this.世丛丞丗丈丘丘东丅 = val_23.playerOnSpot;
        this.oneTimeCapture = val_24.oneTimeCapture;
        this.丆不丕三丅丑丑丑丐 = (float)val_25.spotAntiCaptureTime;
        this.下丈下三丛上丌丌丄 = (float)val_26.spotAntiCaptureDelay;
        this.上与业与且业丒丝丁 = val_27.spotCaptureSpeed;
        this.万七丞丙丑与一丑丁 = (float)val_28.spotCaptureTime;
        this.与丕七东丒一不东七 = val_29.spotCaptureCoeff;
        this.丅丁东三丝业且与丙 = val_30.enemySpotRollback;
        this.丅丂丗丒下丄丆丞三 = val_31.enemySpotRollbackCoeff;
        this.丌上且东丐丁丐专与 = val_32.spotProgressCancel;
        this.下丞丂三万丁丄丄上 = (float)val_33.spotProgressCancelTime;
        this.丘丒丑丅东丄丐丗丈 = val_34.spotsPoint;
        下丛丄且丕丁丐一不 val_35 = GameConnect.丈丝丂丐丟万丙丑丕.Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕];
        this.winPointsLimit = val_35.winPointLimit;
        下丛丄且丕丁丐一不 val_36 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().Item[this.丙专丈与专一丙且丕];
        this.matchTime = val_36.matchTime;
    }
    internal float 丙丐丘丛七万业业丒(int 丕丌一丌丈丆丅丈上, bool 丘万丅丟丅世丗业丌)
    {
        float val_2;
        float val_2 = this.与丕七东丒一不东七;
        val_2 = val_2 * ((float)丕丌一丌丈丆丅丈上 - 1);
        val_2 = this.上与业与且业丒丝丁 + val_2;
        val_2 = 1f;
        if((丘万丅丟丅世丗业丌 != false) && (this.丅丁东三丝业且与丙 != false))
        {
                val_2 = this.丅丂丗丒下丄丆丞三;
        }
        
        val_2 = val_2 * val_2;
        return (float)val_2;
    }
    private void Awake()
    {
        var val_3;
        if(GameConnect.丒丈丒万七丁东丁不() != true)
        {
                if(this.enableForAllModes == false)
        {
            goto label_4;
        }
        
        }
        
        this.FillAllValues();
        val_3 = null;
        val_3 = null;
        HoldPositionsController.丆丕丝丒不丙且丐丗 = this;
        this.丘丕丄与丈七与下三 = false;
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        this.丈下丒丟丘丝丂东丝();
        return;
        label_4:
        this.gameObject.SetActive(value:  false);
    }
    private void Start()
    {
        object val_5 = this;
        if(this.pointsController == 0)
        {
                return;
        }
        
        val_5 = System.Delegate.Combine(a:  this.pointsController.PointsApplied, b:  new System.Action(object:  this, method:  System.Void HoldPositionsController::丅丞世三万丈丆丌丒()));
        if(this.pointsController == null)
        {
            goto label_5;
        }
        
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_5 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_5 = 0;
        }
        
        label_9:
        this.pointsController.PointsApplied = val_5;
    }
    public int get_LosingTeam()
    {
        var val_2;
        TeamController val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        val_3 = mem[GameController.onlineMode + 360];
        val_3 = GameController.onlineMode.teamController;
        float val_2 = (float)this.与丟业不丒丁丞丙丕;
        val_2 = typeof(TeamController).__il2cppRuntimeField_44 + val_2;
        val_4 = null;
        val_4 = null;
        val_3 = mem[GameController.onlineMode + 360];
        val_3 = GameController.onlineMode.teamController;
        float val_3 = (float)this.与丟业不丒丁丞丙丕;
        val_3 = TeamController.__il2cppRuntimeField_element_class + val_3;
        var val_1 = (typeof(TeamController).__il2cppRuntimeField_44 >= val_3) ? 1 : 0;
        return (int);
    }
    private void 丈下丒丟丘丝丂东丝()
    {
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void HoldPositionsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.下世丁丄且丘一丁下 = new System.Action(object:  this, method:  System.Void HoldPositionsController::OnDisconnectedFromPhoton());
    }
    private void OnDestroy()
    {
        UnityEngine.MonoBehaviour val_11;
        var val_12;
        System.Action<与丅丕丈丘东丝世丟> val_13;
        System.Action val_14;
        val_11 = this;
        val_12 = null;
        val_12 = null;
        HoldPositionsController.丆丕丝丒不丙且丐丗 = 0;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        val_13 = System.Delegate.Remove(source:  val_1.专不丐一丈丌丛丁丕, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void HoldPositionsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
        if(this.与丑丌丌丌丁丌不丕() == null)
        {
            goto label_6;
        }
        
        if(val_13 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_13 == null)
        {
            goto label_10;
        }
        
        label_7:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_10:
        val_1.专不丐一丈丌丛丁丕 = val_13;
        val_14 = System.Delegate.Remove(source:  val_5.下世丁丄且丘一丁下, value:  new System.Action(object:  this, method:  System.Void HoldPositionsController::OnDisconnectedFromPhoton()));
        if(this.与丑丌丌丌丁丌不丕() == null)
        {
            goto label_12;
        }
        
        if(val_14 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_14 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(null != null)
        {
                val_14 = 0;
        }
        
        label_16:
        val_5.下世丁丄且丘一丁下 = val_14;
        if(this.pointsController == 0)
        {
                return;
        }
        
        System.Action val_9 = null;
        val_14 = val_9;
        val_9 = new System.Action(object:  this, method:  System.Void HoldPositionsController::丅丞世三万丈丆丌丒());
        val_11 = System.Delegate.Remove(source:  this.pointsController.PointsApplied, value:  val_9);
        if(this.pointsController == null)
        {
            goto label_21;
        }
        
        if(val_11 != null)
        {
            goto label_22;
        }
        
        goto label_25;
        label_21:
        if(val_11 == null)
        {
            goto label_25;
        }
        
        label_22:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_25:
        this.pointsController.PointsApplied = val_11;
    }
    internal void 丆丞丗上丂丁且丅世(Player_move_c 专丞上七七且丝七丗)
    {
        goto label_1;
        label_5:
        bool val_2 = this.pointsController.七东丞丕丄丅丏丟丕()[0].丛三丐丘丂丈专丏专(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        0 = 1;
        label_1:
        if(0 < val_1.Length)
        {
            goto label_5;
        }
    
    }
    internal void 丘上丐世丆丑且丞丒()
    {
        var val_2;
        this.下丁业丑万丄丟丝下 = false;
        val_2 = null;
        val_2 = null;
        if(GameController.onlineMode != null)
        {
                var val_1 = (null == null) ? GameController.onlineMode : 0;
        }
        
        0.SetLimitForTeamPoints(七丏丄丅丌业与且丙:  (float)this.winPointsLimit);
        this.丂丈丒丂上业丕丘世.Invoke();
        this.丘丕丄与丈七与下三 = true;
        this.丑且不丈丐三丝丏丂 = false;
        this.专丙丐丄丂丑上丑丈 = false;
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_22;
        var val_23;
        var val_24;
        System.Func<HoldPositionsPoint, System.Single> val_26;
        var val_27;
        System.Func<HoldPositionsPoint, System.Int32> val_29;
        var val_30;
        System.Func<HoldPositionsPoint, System.Int32> val_32;
        System.Object[] val_33;
        var val_34;
        val_22 = 1152921505171275776;
        val_23 = null;
        val_23 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
                return;
        }
        
        HoldPositionsPoint[] val_2 = this.pointsController.七东丞丕丄丅丏丟丕();
        val_24 = null;
        val_24 = null;
        val_26 = HoldPositionsController.<>c.<>9__61_0;
        if(val_26 == null)
        {
                System.Func<HoldPositionsPoint, System.Single> val_3 = null;
            val_26 = val_3;
            val_3 = new System.Func<HoldPositionsPoint, System.Single>(object:  HoldPositionsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Single HoldPositionsController.<>c::一丅一丘万丟丂丗上(HoldPositionsPoint 三丟东丕丄丄下下丑));
            HoldPositionsController.<>c.<>9__61_0 = val_26;
        }
        
        val_27 = null;
        val_27 = null;
        val_29 = HoldPositionsController.<>c.<>9__61_1;
        if(val_29 == null)
        {
                System.Func<HoldPositionsPoint, System.Int32> val_6 = null;
            val_29 = val_6;
            val_6 = new System.Func<HoldPositionsPoint, System.Int32>(object:  HoldPositionsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 HoldPositionsController.<>c::丘丝丝丒丑丁且丝专(HoldPositionsPoint 三丟东丕丄丄下下丑));
            HoldPositionsController.<>c.<>9__61_1 = val_29;
        }
        
        val_30 = null;
        val_30 = null;
        val_32 = HoldPositionsController.<>c.<>9__61_2;
        if(val_32 == null)
        {
                System.Func<HoldPositionsPoint, System.Int32> val_9 = null;
            val_32 = val_9;
            val_9 = new System.Func<HoldPositionsPoint, System.Int32>(object:  HoldPositionsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 HoldPositionsController.<>c::万丅世七丞上丒丏不(HoldPositionsPoint 三丟东丕丄丄下下丑));
            HoldPositionsController.<>c.<>9__61_2 = val_32;
        }
        
        val_33 = this.photonView;
        object[] val_13 = new object[5];
        val_13[0] = 专丞上七七且丝七丗.业丐丐三丕一丗丛丁();
        val_13[1] = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        val_13[2] = System.Linq.Enumerable.ToArray<System.Single>(source:  System.Linq.Enumerable.Select<HoldPositionsPoint, System.Single>(source:  val_2, selector:  val_3));
        val_13[3] = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<HoldPositionsPoint, System.Int32>(source:  val_2, selector:  val_6));
        val_13[4] = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<HoldPositionsPoint, System.Int32>(source:  val_2, selector:  val_9));
        val_33.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  106, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_13);
        val_22 = this.pointsController.一万丑万丌丐下丞丆();
        val_34 = 0;
        goto label_44;
        label_62:
        HoldPositionsPoint val_22 = val_22[0];
        if(val_17[0x0][0].丞一业不丟万世三且 == false)
        {
            goto label_47;
        }
        
        object[] val_19 = new object[2];
        val_33 = val_19;
        int val_21 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(val_33 == null)
        {
            goto label_51;
        }
        
        if(val_21 != 0)
        {
            goto label_52;
        }
        
        goto label_55;
        label_51:
        if(val_21 == 0)
        {
            goto label_55;
        }
        
        label_52:
        label_55:
        val_33[0] = val_21;
        val_33[1] = val_17[0x0][0].index;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  129, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_19);
        label_47:
        val_34 = 1;
        label_44:
        if(val_34 < val_17.Length)
        {
            goto label_62;
        }
    
    }
    private void OnDisconnectedFromPhoton()
    {
        var val_2;
        this.丙丞丛丕丅世下丅丒 = false;
        val_2 = 0;
        goto label_1;
        label_7:
        HoldPositionsPoint val_2 = this.pointsController.七东丞丕丄丅丏丟丕()[0];
        val_1[0x0][0].丙丞丛丕丅世下丅丒 = false;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_1[0x0] + 32.丞丛丝丒三世丏丂丐();
        val_2 = 1;
        label_1:
        if(val_2 < val_1.Length)
        {
            goto label_7;
        }
        
        this.丆丁丆丟丄丛丁万丛 = false;
        this.丘丕丄与丈七与下三 = false;
    }
    private bool 丑丑丛且世丁丐丈世(HoldPositionsPoint 丅专与丒丈丗丒丘丌)
    {
        var val_2;
        if(丅专与丒丈丗丒丘丌.丑丄丌丅丆丗东丞丌() != false)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        if(this.世丛丞丗丈丘丘东丅 != false)
        {
                if(丅专与丒丈丗丒丘丌 != null)
        {
                return 丅专与丒丈丗丒丘丌.丘丕丐不与丂业丝丁();
        }
        
            return 丅专与丒丈丗丒丘丌.丘丕丐不与丂业丝丁();
        }
        
        val_2 = 1;
        return (bool)val_2;
    }
    internal bool 专丝丏丁丆不一且丘(Player_move_c 专丞上七七且丝七丗)
    {
        HoldPositionsPointsController val_5;
        var val_6;
        var val_7;
        val_5 = this.pointsController;
        if(val_5 == 0)
        {
                return false;
        }
        
        val_6 = 0;
        goto label_5;
        label_18:
        HoldPositionsPoint val_5 = this.pointsController.一万丑万丌丐下丞丆()[0];
        val_7 = null;
        val_7 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_2[0x0][0].ownerCommand == 丘丑丅三丆丑丌且丝())
        {
                val_5 = mem[val_2[0x0] + 32 + 96];
            val_5 = val_2[0x0] + 32 + 96;
            if((val_5.Contains(item:  专丞上七七且丝七丗)) == true)
        {
                return false;
        }
        
        }
        
        val_6 = 1;
        label_5:
        if(val_6 < val_2.Length)
        {
            goto label_18;
        }
        
        return false;
    }
    private void 丐专不丈丘丘业上专()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(this.pointsController == 0)
        {
                return;
        }
        
        if(this.oneTimeCapture != false)
        {
                return;
        }
        
        val_7 = 0;
        val_8 = 0;
        val_9 = 0;
        goto label_6;
        label_19:
        HoldPositionsPoint val_7 = this.pointsController.一万丑万丌丐下丞丆()[0];
        if((val_2[0x0][0].ownerCommand >= 1) && ((this.丑丑丛且世丁丐丈世(丅专与丒丈丗丒丘丌:  val_2[0x0] + 32)) != false))
        {
                if((val_2[0x0] + 32 + 68) == 1)
        {
                val_9 = 1;
        }
        
        }
        
        val_7 = 1;
        label_6:
        if(val_7 < val_2.Length)
        {
            goto label_19;
        }
        
        val_10 = null;
        val_10 = null;
        if(HoldPositionsController.不丈七三三丙万丛丗 == null)
        {
                return;
        }
        
        float val_8 = (float)this.丘丒丑丅东丄丐丗丈;
        float val_9 = (float)this.丘丒丑丅东丄丐丗丈;
        val_8 = UnityEngine.Time.deltaTime * val_8;
        val_9 = UnityEngine.Time.deltaTime * val_9;
        val_8 = val_8 * 0f;
        val_9 = val_9 * ((float)((val_2[0x0] + 32 + 68) == 2) ? (val_8 + 1) : (val_8));
        HoldPositionsController.不丈七三三丙万丛丗.Invoke(arg1:  val_8, arg2:  val_9);
    }
    internal void 专丈丝丄丑丅丌丙丕(int 专七万不丐丆丟东丈)
    {
        int val_4;
        var val_5;
        val_4 = 专七万不丐丆丟东丈;
        val_5 = this;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_5 = this.photonView;
        object[] val_3 = new object[3];
        val_3[0] = 0;
        val_3[1] = val_4;
        val_4 = null;
        val_3[2] = val_4;
        val_5.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  96, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 丈专专丑丈丌丆丙丐(HoldPositionsPoint 丏丌上与丕业世上丘, int[] 且专丆与丂丐丏丙丏)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = this;
        if(this.oneTimeCapture == false)
        {
            goto label_15;
        }
        
        val_8 = null;
        val_8 = null;
        int val_1 = 丘丑丅三丆丑丌且丝();
        if(val_1 == 2)
        {
            goto label_7;
        }
        
        if(val_1 != 1)
        {
            goto label_15;
        }
        
        val_9 = null;
        val_9 = null;
        if(HoldPositionsController.不丈七三三丙万丛丗 == null)
        {
            goto label_15;
        }
        
        val_10 = 1152921537441076032;
        goto label_12;
        label_7:
        val_11 = null;
        val_11 = null;
        if(HoldPositionsController.不丈七三三丙万丛丗 == null)
        {
            goto label_15;
        }
        
        val_10 = 1152921537441076032;
        label_12:
        HoldPositionsController.不丈七三三丙万丛丗.Invoke(arg1:  (val_1 == 丏丌上与丕业世上丘.ownerCommand) ? 0f : ((float)this.丘丒丑丅东丄丐丗丈), arg2:  (val_1 == 丏丌上与丕业世上丘.ownerCommand) ? ((float)this.丘丒丑丅东丄丐丗丈) : 0f);
        label_15:
        if(((this.世丛丞丗丈丘丘东丅 != false) && (InGameGUI.丙丞专丌丁丞与不丐 != null)) && (null != 0))
        {
                丟不丘丝丆上且丛且();
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_7 = this.photonView;
        object[] val_6 = new object[4];
        val_6[0] = 丏丌上与丕业世上丘.ownerCommand;
        val_6[1] = 丏丌上与丕业世上丘.index;
        val_6[2] = true;
        val_6[3] = 且专丆与丂丐丏丙丏;
        val_7.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  96, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_6);
    }
    private void 丅丞世三万丈丆丌丒()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                丑丅丝三丝丞三丏丄();
        }
        
        this.丆丁丆丟丄丛丁万丛 = true;
    }
    private void Update()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(this.丘丕丄与丈七与下三 != false)
        {
                if(this.丙丞丛丕丅世下丅丒 != false)
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != true)
        {
                this.OnDisconnectedFromPhoton();
        }
        
        }
        
            val_8 = null;
            val_8 = null;
            bool val_3 = 丗丌丆丙丗上丁丌丁() ^ 1;
            if((this.万与丟且丘一万丗与 != false) && (val_3 != true))
        {
                UnityEngine.Debug.LogError(message:  "All points hard resetted now! Because there becomes not enough players for play");
            this.pointsController.LostPlayersActions();
        }
        
            bool val_4 = val_3;
            this.万与丟且丘一万丗与 = val_4;
            this.丁世丁丈丒丗丙丌不(丗上丑丄丑丈丙丂丆:  val_4);
            val_9 = null;
            val_9 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count == 0)
        {
                return;
        }
        
            this.丐专不丈丘丘业上专();
            this.业丒一七与丆丌丁与();
            return;
        }
        
        if(this.专丙丐丄丂丑上丑丈 != false)
        {
                val_10 = null;
            val_10 = null;
            if(丙东业一丅丒一丛一() != 0)
        {
                return;
        }
        
            this.丑且不丈丐三丝丏丂 = true;
            this.专丙丐丄丂丑上丑丈 = false;
            return;
        }
        
        if(this.丑且不丈丐三丝丏丂 == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(丙东业一丅丒一丛一() < 1)
        {
                return;
        }
        
        this.丘上丐世丆丑且丞丒();
    }
    private void 丁世丁丈丒丗丙丌不(bool 丗上丑丄丑丈丙丂丆)
    {
        HoldPositionsPoint val_5;
        InGameGUI val_6;
        val_5 = this;
        val_6 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_6 != 0)
        {
                InGameGUIPart_HoldPositions.__il2cppRuntimeField_element_class.SetActive(value:  (~丗上丑丄丑丈丙丂丆) & 1);
        }
        
        if(this.丘丕丄与丈七与下三 == false)
        {
                return;
        }
        
        val_6 = 0;
        val_5 = 0;
        goto label_9;
        label_15:
        HoldPositionsPoint val_5 = this.pointsController.七东丞丕丄丅丏丟丕()[0];
        if(val_3[0x0][0].丞一业不丟万世三且 != false)
        {
                val_5 = mem[val_3[0x0] + 32];
            val_5 = val_3[0x0] + 32;
        }
        
        val_6 = 1;
        label_9:
        if(val_6 < val_3.Length)
        {
            goto label_15;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_HoldPositions.__il2cppRuntimeField_castClass.世七丂丁丅丟七一丏(丅专与丒丈丗丒丘丌:  val_5);
    }
    private void 业丒一七与丆丌丁与()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丝一且丞丛下丟丞世 - val_2;
        this.丝一且丞丛下丟丞世 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        this.丝一且丞丛下丟丞世 = this.下丅丑业丗一丌且丛;
        if(this.七丕三上丂丈丅丅三 != false)
        {
                this.业丘三上丑丏丟丗不();
        }
        else
        {
                this.丛丅业丙丑丙丑丆丄();
        }
        
        bool val_3 = this.七丕三上丂丈丅丅三;
        val_3 = val_3 ^ 1;
        this.七丕三上丂丈丅丅三 = val_3;
    }
    private void 业丘三上丑丏丟丗不()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        object[] val_3 = new object[3];
        if(val_3 != null)
        {
            
        }
        
        val_3[0] = TeamController.__il2cppRuntimeField_element_class;
        val_3[1] = typeof(TeamController).__il2cppRuntimeField_44;
        val_3[2] = 丘丑丅三丆丑丌且丝();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  114, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void 丛丅业丙丑丙丑丆丄()
    {
        var val_7;
        System.Func<HoldPositionsPoint, System.Single> val_9;
        val_7 = null;
        val_7 = null;
        val_9 = HoldPositionsController.<>c.<>9__74_0;
        if(val_9 == null)
        {
                System.Func<HoldPositionsPoint, System.Single> val_2 = null;
            val_9 = val_2;
            val_2 = new System.Func<HoldPositionsPoint, System.Single>(object:  HoldPositionsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Single HoldPositionsController.<>c::三三七丅业不丘丕丕(HoldPositionsPoint 三丟东丕丄丄下下丑));
            HoldPositionsController.<>c.<>9__74_0 = val_9;
        }
        
        object[] val_6 = new object[1];
        val_6[0] = System.Linq.Enumerable.ToArray<System.Single>(source:  System.Linq.Enumerable.Select<HoldPositionsPoint, System.Single>(source:  this.pointsController.七东丞丕丄丅丏丟丕(), selector:  val_2));
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  105, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_6);
    }
    internal void 且丌丆丝下且七丟丆()
    {
        var val_5;
        var val_6;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        object[] val_4 = new object[4];
        val_4[0] = TeamController.__il2cppRuntimeField_element_class;
        val_4[1] = typeof(TeamController).__il2cppRuntimeField_44;
        val_4[2] = 丘丑丅三丆丑丌且丝();
        val_4[3] = true;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  114, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
        this.下丁业丑万丄丟丝下 = true;
        this.<丌丅丟丈丗专丏专下>k__BackingField = TeamController.__il2cppRuntimeField_element_class;
        this.<丆且丂丗丈三且专七>k__BackingField = typeof(TeamController).__il2cppRuntimeField_44;
    }
    internal void 丘专上丅且下丕七丗(int 专七万不丐丆丟东丈, int 丄丒且丙三丆丟与丏, bool 丂丛与丕丟世与东万)
    {
        object val_3;
        var val_4;
        object[] val_2 = new object[2];
        if(丂丛与丕丟世与东万 != false)
        {
                val_2[0] = 丄丒且丙三丆丟与丏;
            val_3 = 专七万不丐丆丟东丈;
            val_2[1] = val_3;
            val_4 = 129;
        }
        else
        {
                val_2[0] = 丄丒且丙三丆丟与丏;
            val_3 = 专七万不丐丆丟东丈;
            val_2[1] = val_3;
            val_4 = 156;
        }
        
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  156, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_4;
        object val_5;
        var val_6;
        int val_7;
        var val_9;
        System.Single[] val_10;
        int val_11;
        object val_12;
        var val_14;
        var val_15;
        System.Int32[] val_16;
        int val_17;
        var val_18;
        val_4 = 丞世不丒下上上丝丑;
        val_5 = this;
        byte val_1 = val_4 & 255;
        if(val_1 > 106)
        {
            goto label_1;
        }
        
        if(val_1 == 96)
        {
            goto label_2;
        }
        
        if(val_1 == 105)
        {
            goto label_3;
        }
        
        if(val_1 != 106)
        {
            goto label_8;
        }
        
        this.丂东东丅丅东东丄丑(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        goto label_49;
        label_1:
        if(val_1 == 156)
        {
            goto label_6;
        }
        
        if(val_1 == 129)
        {
            goto label_7;
        }
        
        if(val_1 != 114)
        {
            goto label_8;
        }
        
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_9;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞;
        val_7 = 专丒丌丆下丐丞丟丞.Length;
        if(val_7 != 3)
        {
            goto label_10;
        }
        
        label_45:
        val_5 = 专丒丌丆下丐丞丟丞[0];
        val_4 = 专丒丌丆下丐丞丟丞[1];
        专丒丌丆下丐丞丟丞[2].丟一世丂丟三不东丙(丁下丄上与丒上丛业:  3.782474E-38f, 丗上世丛丏丌丂上丅:  3.782474E-38f, 下丄丁丑三丏丗丛七:  15228928);
        goto label_49;
        label_8:
        val_9 = 0;
        return (bool)val_9;
        label_3:
        val_4 = 专丒丌丆下丐丞丟丞[0];
        if(val_4 == null)
        {
            goto label_20;
        }
        
        val_10 = val_4;
        if(val_10 != null)
        {
            goto label_21;
        }
        
        label_20:
        val_10 = 0;
        label_21:
        this.世与丑不丝东丐万丟(专业丞丘东丘丟丞专:  val_10);
        goto label_49;
        label_7:
        val_11 = 专丒丌丆下丐丞丟丞.Length;
        if(val_11 == 0)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_5 = 专丒丌丆下丐丞丟丞[0];
        object val_6 = 专丒丌丆下丐丞丟丞[1];
        this.万丄东七丒专丕丒丛(丄丒且丙三丆丟与丏:  21884928, 专七万不丐丆丟东丈:  21884928);
        goto label_49;
        label_2:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_27;
        }
        
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_43;
        }
        
        label_44:
        label_43:
        object val_7 = 专丒丌丆下丐丞丟丞[0];
        object val_8 = 专丒丌丆下丐丞丟丞[1];
        val_12 = 专丒丌丆下丐丞丟丞[2];
        if(专丒丌丆下丐丞丟丞.Length != 3)
        {
            goto label_33;
        }
        
        val_14 = 1152921504628731904;
        val_15 = 1152921504628731904;
        val_16 = 0;
        goto label_34;
        label_6:
        val_17 = 专丒丌丆下丐丞丟丞.Length;
        if(val_17 == 0)
        {
                val_17 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_9 = 专丒丌丆下丐丞丟丞[0];
        object val_10 = 专丒丌丆下丐丞丟丞[1];
        this.丞下不专丅丘世与丑(丄丒且丙三丆丟与丏:  21884928, 专七万不丐丆丟东丈:  21884928);
        goto label_49;
        label_33:
        object val_11 = 专丒丌丆下丐丞丟丞[3];
        if(val_11 == null)
        {
            goto label_40;
        }
        
        val_16 = val_11;
        if(val_16 != null)
        {
            goto label_41;
        }
        
        label_40:
        val_16 = 0;
        label_41:
        val_14 = 1152921504628731904;
        val_15 = 1152921504628731904;
        label_34:
        this.一且丑七七丙一丗一(下丄丁丑三丏丗丛七:  21884928, 专七万不丐丆丟东丈:  21884928, 丞上丘三丈世专丑上:  (null != 0) ? 1 : 0, 且专丆与丂丐丏丙丏:  val_16);
        goto label_49;
        label_27:
        if(28563616 != 0)
        {
            goto label_43;
        }
        
        goto label_44;
        label_9:
        val_6 = 24;
        val_4 = 28563616;
        val_7 = 28563616;
        if(val_4 == 3)
        {
            goto label_45;
        }
        
        label_10:
        if(val_7 == 4)
        {
                object val_12 = 专丒丌丆下丐丞丟丞[3];
            if(null != null)
        {
                val_18 = 28563616;
            if(val_18 == 0)
        {
                val_18 = 28563616;
        }
        
            val_4 = 专丒丌丆下丐丞丟丞[0];
            if(val_18 <= 1)
        {
                val_18 = 28563616;
        }
        
            object val_13 = 专丒丌丆下丐丞丟丞[1];
            object val_14 = 专丒丌丆下丐丞丟丞[2];
            val_12 = 1152921504624205824;
            this.丏不丄丝丒与丝不不(丁下丄上与丒上丛业:  3.782474E-38f, 丗上世丛丏丌丂上丅:  3.782474E-38f, 下丄丁丑三丏丗丛七:  15228928);
        }
        
        }
        
        label_49:
        val_9 = 1;
        return (bool)val_9;
    }
    private void 一且丑七七丙一丗一(int 下丄丁丑三丏丗丛七, int 专七万不丐丆丟东丈, bool 丞上丘三丈世专丑上, int[] 且专丆与丂丐丏丙丏)
    {
        UnityEngine.Object val_3;
        if(this.pointsController != null)
        {
                val_3 = this.pointsController.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  专七万不丐丆丟东丈);
        }
        else
        {
                val_3 = 0;
        }
        
        if(val_3 == 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
            goto label_6;
        }
        
        if(丞上丘三丈世专丑上 == false)
        {
            goto label_7;
        }
        
        label_8:
        val_3.丙一上丟丁世业丑丄(丈丞与上丒丘丕丞三:  下丄丁丑三丏丗丛七, 且专丆与丂丐丏丙丏:  且专丆与丂丐丏丙丏);
        this.丈专专丑丈丌丆丙丐(丏丌上与丕业世上丘:  val_3, 且专丆与丂丐丏丙丏:  0);
        return;
        label_6:
        if(丞上丘三丈世专丑上 == true)
        {
            goto label_8;
        }
        
        label_7:
        mem[68] = 0;
    }
    private void 世与丑不丝东丐万丟(float[] 专业丞丘东丘丟丞专)
    {
        HoldPositionsPoint val_3;
        var val_4;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == true)
        {
                return;
        }
        
        val_4 = 0;
        goto label_5;
        label_11:
        val_3 = this.pointsController.七东丞丕丄丅丏丟丕()[0];
        val_3.且不丙丟丘不丌丆丌(一丅丌三丁万丑且万:  专业丞丘东丘丟丞专[0]);
        val_4 = 1;
        label_5:
        if(val_4 < val_2.Length)
        {
            goto label_11;
        }
    
    }
    internal void 丟一世丂丟三不东丙(float 丁下丄上与丒上丛业, float 丗上世丛丏丌丂上丅, int 下丄丁丑三丏丗丛七)
    {
        null = null;
        typeof(TeamController).__il2cppRuntimeField_40 = 丁下丄上与丒上丛业;
        typeof(TeamController).__il2cppRuntimeField_44 = 丗上世丛丏丌丂上丅;
        typeof(TeamController).__il2cppRuntimeField_38 = (int)丁下丄上与丒上丛业;
        typeof(TeamController).__il2cppRuntimeField_3C = (int)丗上世丛丏丌丂上丅;
    }
    internal void 丏不丄丝丒与丝不不(float 丁下丄上与丒上丛业, float 丗上世丛丏丌丂上丅, int 下丄丁丑三丏丗丛七)
    {
        var val_1;
        this.<丌丅丟丈丗专丏专下>k__BackingField = 丁下丄上与丒上丛业;
        this.<丆且丂丗丈三且专七>k__BackingField = 丗上世丛丏丌丂上丅;
        this.下丁业丑万丄丟丝下 = true;
        val_1 = null;
        val_1 = null;
        if(GameController.onlineMode == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        GameController.onlineMode.丝丙七与丒丄七丝下();
    }
    private void 丂东东丅丅东东丄丑(object[] 专丒丌丆下丐丞丟丞)
    {
        var val_11;
        HoldPositionsPointsController val_12;
        int val_13;
        object val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.Debug.LogError(message:  "SynchronizeCaptureCounterNewPlayer " + 专丒丌丆下丐丞丟丞);
        object val_12 = 专丒丌丆下丐丞丟丞[0];
        if(this.丙丞丛丕丅世下丅丒 == true)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != null)
        {
                return;
        }
        
        bool val_4 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[1]);
        val_12 = this.pointsController;
        val_13 = val_5.Length;
        val_14 = 专丒丌丆下丐丞丟丞[2];
        if(val_14 == null)
        {
            goto label_16;
        }
        
        val_15 = val_14;
        if(val_15 != null)
        {
            goto label_17;
        }
        
        label_16:
        val_15 = 0;
        label_17:
        object val_14 = 专丒丌丆下丐丞丟丞[3];
        val_11 = 1152921505725111792;
        if(val_14 == null)
        {
            goto label_19;
        }
        
        val_14 = null;
        val_16 = val_14;
        if(val_16 != null)
        {
            goto label_20;
        }
        
        label_19:
        val_16 = 0;
        label_20:
        object val_15 = 专丒丌丆下丐丞丟丞[4];
        if(val_15 == null)
        {
            goto label_22;
        }
        
        val_14 = null;
        val_17 = val_15;
        if(val_17 != null)
        {
            goto label_23;
        }
        
        label_22:
        val_17 = 0;
        label_23:
        if(val_13 >= 1)
        {
                var val_16 = 0;
            var val_8 = val_15 + 32;
            val_12 = val_16 + 32;
            val_11 = val_17 + 32;
            HoldPositionsPoint[] val_9 = val_12.七东丞丕丄丅丏丟丕() + 32;
            do
        {
            val_14 = mem[(val_16 + 32) + 0];
            val_14 = (val_16 + 32) + 0;
            val_13 = mem[(val_5 + 32) + 0];
            val_13 = (val_5 + 32) + 0;
            val_13.七丁丞丌下丏丌丁丟(丝丝丝丛上丈丅丕不:  (val_15 + 32) + 0, 丙一丆丕丑丟丑三丘:  val_14, 与丂一三世丑丕丈丂:  (val_17 + 32) + 0, 专丗丛丝丗丞下丑丄:  val_4);
            val_16 = val_16 + 1;
        }
        while((val_13 & 4294967295) != val_16);
        
        }
        
        this.丙丞丛丕丅世下丅丒 = val_4;
    }
    private void 万丄东七丒专丕丒丛(int 丄丒且丙三丆丟与丏, int 专七万不丐丆丟东丈)
    {
        if(this.pointsController == null)
        {
                return;
        }
        
        HoldPositionsPoint val_1 = this.pointsController.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  专七万不丐丆丟东丈);
        if(val_1 == null)
        {
                return;
        }
        
        val_1.万丄东七丒专丕丒丛(业上上丏丄不上丅丈:  丄丒且丙三丆丟与丏);
    }
    private void 丞下不专丅丘世与丑(int 丄丒且丙三丆丟与丏, int 专七万不丐丆丟东丈)
    {
        if(this.pointsController == null)
        {
                return;
        }
        
        HoldPositionsPoint val_1 = this.pointsController.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  专七万不丐丆丟东丈);
        if(val_1 == null)
        {
                return;
        }
        
        val_1.丝三上东一丂丑万丂(业上上丏丄不上丅丈:  丄丒且丙三丆丟与丏);
    }
    internal void 丛业丑丁七下专丌上()
    {
        var val_3;
        var val_4;
        val_3 = this;
        this.丘丕丄与丈七与下三 = false;
        this.丑且不丈丐三丝丏丂 = false;
        this.专丙丐丄丂丑上丑丈 = true;
        if(this.pointsController == 0)
        {
                return;
        }
        
        val_3 = this.pointsController.七东丞丕丄丅丏丟丕();
        val_4 = 0;
        goto label_5;
        label_9:
        val_2[0x0][0].rawCounter = 0f;
        val_2[0x0][0].丘丌丌万丕不丁丙一 = 0f;
        val_2[0x0][0].ownerCommand = 0;
        val_2[0x0][0].previousCommand = 0;
        val_2[0x0][0].captureCommand = 0;
        val_3[0].丞丛丝丒三世丏丂丐();
        val_4 = 1;
        label_5:
        if(val_4 < val_2.Length)
        {
            goto label_9;
        }
    
    }
    public HoldPositionsController()
    {
        this.spotLimit = 2;
        this.spotLifeTime = 20;
        this.与丟业不丒丁丞丙丕 = 15;
        this.与丕七东丒一不东七 = 2f;
        this.丅丂丗丒下丄丆丞三 = 1f;
        this.下丞丂三万丁丄丄上 = 10f;
        this.丘丒丑丅东丄丐丗丈 = 10;
        this.winPointsLimit = 200;
        this.matchTime = 200;
        this.spotComebackSpawn = true;
        this.下丅丑业丗一丌且丛 = 0.5f;
        this.丆不丕三丅丑丑丑丐 = ;
        this.下丈下三丛上丌丌丄 = ;
        this.上与业与且业丒丝丁 = 2f;
        this.万七丞丙丑与一丑丁 = 13f;
        this.七丕三上丂丈丅丅三 = true;
    }
    private static HoldPositionsController()
    {
        HoldPositionsController.三与一不丅上丘下与 = "holdPositionsRawCfg";
    }

}
