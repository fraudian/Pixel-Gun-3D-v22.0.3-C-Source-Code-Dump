using UnityEngine;
internal class VehicleController : TransportControllerBase, 东丁丆一业丈万丆丐
{
    // Fields
    public VehicleEngine engine;
    public UnityEngine.GameObject[] colliderGO;
    internal Player_move_c[] places;
    public UnityEngine.GameObject viewCollider;
    public float maxSpeedGetOutPlayer;
    public float maxDamageGetOutPlayer;
    private int 上丑丈丟上万一丙专;
    public VehicleView currentView;
    private 业丗丕丟三丝丘三丗 专丆丙丟万丙万丘且;
    private 业丗丕丟三丝丘三丗 七一专丕丑丕丛丌业;
    private 业丗丕丟三丝丘三丗 丟丒丟丆东下丕丆七;
    public UnityEngine.GameObject setViewParticle;
    public static float recoverCarAfterDisconnect;
    private int 不丗丘丘一丕丑专一;
    private float 且丛东专丆下专专专;
    private UnityEngine.Vector3 丑丌丙丛三专且丕三;
    private UnityEngine.Quaternion 丛丁丗业一与东丑丑;
    public float correctionTime;
    private float 专丈丒三丕下丈丁丛;
    public UnityEngine.AudioSource engineAudioSource;
    public UnityEngine.AudioSource skidAudioSource;
    public UnityEngine.AudioSource freeAudioSource;
    public UnityEngine.AudioSource gravelSource;
    public UnityEngine.AudioClip engineStart;
    public UnityEngine.AudioClip engineOn;
    public UnityEngine.AudioClip engineStop;
    public UnityEngine.AudioClip bump;
    public UnityEngine.AudioClip gear;
    public UnityEngine.AudioClip fire;
    public UnityEngine.AudioClip horn;
    public UnityEngine.AudioClip[] carHitSound;
    public int gears;
    public float maxSpeed;
    public float pitchStep;
    public UnityEngine.AnimationCurve pitchCurve;
    private int 东丘不世七丝丅丞丌;
    public bool isAccelerates;
    private float 与丂丈丙丈丏丙丑上;
    private float 下丕丌丝丘不丐专丏;
    private float 丙三丈三三专丄一丘;
    private UnityEngine.Coroutine 世七丁与丘下丏丗丘;
    private float 丐丁三专东世且丒丐;
    private bool 丗万丝丁丛丗丈丙丞;
    private float 丂丞丅丄东丛丘万丄;
    private float 丗丟且上丌一丐丙丛;
    private float 丞丌丗专丘丝业下世;
    private float 丙万世上丙丑下世丗;
    private float 丗万丑丆丗三业丘下;
    
    // Properties
    internal override 丏丐丏丘下东丁丐一 丏丐丏丘下东丁丐一 { get; }
    internal override TransportViewBase 世丆丝七丆业三不丕 { get; }
    internal override string 上丂一丙丗丟丛丅丑 { get; }
    internal override TransportEngineBase 一世业与世丅下丗丕 { get; }
    internal override UnityEngine.GameObject[] 一丌丒东丘且丛东不 { get; }
    internal override PGCompany.业丐与丕丒下丑下丈 七一丄丞丕丆不丘丗 { get; }
    internal override PGCompany.业丐与丕丒下丑下丈 丞三东丅丙七业丅上 { get; }
    internal override 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 且业且丙上三与东丕 { get; }
    internal override UnityEngine.Transform 丙三丞丌下丞七业一 { get; }
    internal override float 三丝丟丙丂丆丘不丝 { get; }
    internal override Player_move_c[] 专专上丒七丙上丅三 { get; }
    
    // Methods
    internal void 丗业丕丁丁且与丈丌()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.东丅丏丐丗三三下丆());
    }
    private System.Collections.IEnumerator 东丅丏丐丗三三下丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleController.且丆且一业丐一一丟();
    }
    protected override void Awake()
    {
        this.Awake();
        this.freeAudioSource.volume = 1f;
        this.freeAudioSource.enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
    }
    public void SetVehicleParams(string 丏丆丕丏丘业东万下, int 丌丐丟丟丆丁丌丌丝, bool 下万下丌且丙七丝丆 = False)
    {
        if(this == 1)
        {
                下万下丌且丙七丝丆 = 下万下丌且丙七丝丆;
            this.engine.丅业丝下不三丝三丏(丏丆丕丏丘业东万下:  丏丆丕丏丘业东万下, 丌丐丟丟丆丁丌丌丝:  丌丐丟丟丆丁丌丌丝, 下万下丌且丙七丝丆:  下万下丌且丙七丝丆);
            object[] val_2 = new object[3];
            val_2[0] = this.engine.丁一丌上丆丑丈不丐;
            val_2[1] = this.engine.丅专专丝业不丈专丐;
            val_2[2] = this.engine.业丛东丟丗丘丙东丅;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  193, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
        }
        
        object[] val_4 = new object[3];
        val_4[0] = this.万丞丆丌世丝丞丆上();
        val_4[1] = this.IsDead();
        val_4[2] = this.东东七丄丛丄丌不丅();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
    }
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        byte val_6 = 丗与一丛丐丞丘丌丞;
        byte val_1 = val_6 & 255;
        if(val_1 > 26)
        {
            goto label_1;
        }
        
        if(val_1 == 14)
        {
            goto label_2;
        }
        
        if(val_1 != 26)
        {
                return this.OnEventFired(丗与一丛丐丞丘丌丞:  val_6 = 丗与一丛丐丞丘丌丞, 专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        }
        
        this.丗丑丟丛丛丘三世丙();
        return true;
        label_1:
        if(val_1 == 195)
        {
            goto label_5;
        }
        
        if(val_1 != 193)
        {
                return this.OnEventFired(丗与一丛丐丞丘丌丞:  val_6, 专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[0];
        this.丗且丟丒下丅一上一(三东丏丞丗丙丘丗丅:  System.Convert.ToSingle(value:  val_6), 丒丌且丁丄丛丌丘万:  System.Convert.ToSingle(value:  专丒丌丆下丐丞丟丞[1]), 七与丑丁丝七丒下七:  System.Convert.ToSingle(value:  专丒丌丆下丐丞丟丞[2]));
        return true;
        label_2:
        this.丗万丝丁丛丗丈丙丞 = true;
        this.丗丟且上丌一丐丙丛 = 0f;
        return true;
        label_5:
        val_6 = 专丒丌丆下丐丞丟丞[0];
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_6);
        this.丛世丏万丂东丗丂丑(丘丒丌下丕专且七专:  21884928);
        return true;
    }
    private void 丗且丟丒下丅一上一(float 三东丏丞丗丙丘丗丅, float 丒丌且丁丄丛丌丘万, float 七与丑丁丝七丒下七)
    {
        if(this != 1)
        {
                return;
        }
        
        this.engine.且丄丂丌且七丞专专(三东丏丞丗丙丘丗丅:  三东丏丞丗丙丘丗丅, 丒丌且丁丄丛丌丘万:  丒丌且丁丄丛丌丘万, 七与丑丁丝七丒下七:  七与丑丁丝七丒下七);
    }
    protected override System.Collections.IEnumerator 丑世东一丏丄与三下(string 丏丆丕丏丘业东万下)
    {
        VehicleController.丘丒下丏业东业三且 val_1 = new VehicleController.丘丒下丏业东业三且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丏丆丕丏丘业东万下 = 丏丆丕丏丘业东万下;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 东丟世丞丈世丞下七()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.currentView.GetComponent<VehicleSoundParameters>())) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.engineStart)) != false)
        {
                this.engineStart = val_1.engineStart;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.engineOn)) != false)
        {
                this.engineOn = val_1.engineOn;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.engineStop)) != false)
        {
                this.engineStop = val_1.engineStop;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.bump)) != false)
        {
                this.bump = val_1.bump;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.gear)) != false)
        {
                this.gear = val_1.gear;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.fire)) != false)
        {
                this.fire = val_1.fire;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_1.horn)) != false)
        {
                this.horn = val_1.horn;
        }
        
        if(val_1.carHitSound == null)
        {
                return;
        }
        
        if(val_1.carHitSound.Length == 0)
        {
                return;
        }
        
        this.carHitSound = val_1.carHitSound;
    }
    private void 丛世丏万丂东丗丂丑(int 丘丒丌下丕专且七专)
    {
        this.不丗丘丘一丕丑专一 = 丘丒丌下丕专且七专;
        if(this.currentView == 0)
        {
                return;
        }
        
        this.currentView.东丏三丆丅三且丛丁(丗丂丛丝丝丌且丐丅:  this.不丗丘丘一丕丑专一);
    }
    protected override void 丁丌一不丗丕丘业东()
    {
        if(W8 == 0)
        {
                return;
        }
        
        this.万与丝丄丅丅一丛丅();
    }
    protected override void OnCollisionEnter(UnityEngine.Collision 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Collision val_5;
        var val_6;
        val_5 = 丘丛丏丘丝七世七丅;
        this.OnCollisionEnter(丘丛丏丘丝七世七丅:  val_5);
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        val_5 = val_5.collider;
        if((val_5.CompareTag(tag:  "CarCollider")) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        this.丝丂丗丛丕丁丕丐万(丌丑丛业丈丘世丞丕:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
    }
    protected override bool 丛丛丟世且上丞丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_12;
        if(this.photonView.isMine == false)
        {
                return false;
        }
        
        if(this.IsDead() == true)
        {
                return false;
        }
        
        if((System.String.op_Equality(a:  丝三丁东丈丒世丅业.gameObject.name, b:  "DeadCollider")) == false)
        {
                return false;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_12 = null;
            val_12 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return false;
        }
        
            bool val_9 = this.丄上丐丏丒丝丘丐丈();
            return false;
        }
        
        object[] val_11 = new object[3];
        val_11[0] = 100f;
        val_11[1] = 0;
        val_11[2] = 1;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_11);
        return false;
    }
    private void 丝丂丗丛丕丁丕丐万(Player_move_c 丌丑丛业丈丘世丞丕)
    {
        var val_15;
        var val_16;
        bool val_17;
        bool val_18;
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        float val_23;
        int val_24;
        val_15 = null;
        val_15 = null;
        if(GameController.onlineMode != 0)
        {
                val_16 = null;
            val_16 = null;
            val_17 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_17 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_17 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
            val_18 = val_4.squadMode;
        }
        else
        {
                val_18 = 0;
        }
        
        val_19 = null;
        val_19 = null;
        if(GameController.onlineMode != 0)
        {
                val_20 = null;
            val_20 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        }
        
        val_21 = 0;
        if(丌丑丛业丈丘世丞丕 == null)
        {
            goto label_28;
        }
        
        label_30:
        val_22 = 丌丑丛业丈丘世丞丕.丘七业丒丐世丂丅丒();
        val_23 = 丌丑丛业丈丘世丞丕.专一丟丏且丆丕丝七();
        goto label_29;
        label_27:
        val_21 = GameController.onlineMode.丄丗三丌世东业上丌();
        if(丌丑丛业丈丘世丞丕 != null)
        {
            goto label_30;
        }
        
        label_28:
        val_22 = 0.丘七业丒丐世丂丅丒();
        float val_10 = 0.专一丟丏且丆丕丝七();
        val_23 = val_10;
        label_29:
        val_10 = val_22 / val_23;
        val_17 = val_18 | val_17;
        val_10 = val_10 * 100f;
        if(丌丑丛业丈丘世丞丕.与丙丕丛一丌丛丆丈 != null)
        {
                val_22 = 丌丑丛业丈丘世丞丕.与丙丕丛一丌丛丆丈.丈下丏丟丑丐丆三不();
            float val_12 = 丌丑丛业丈丘世丞丕.与丙丕丛一丌丛丆丈.七丁丙丅丂上丒丞丙();
            val_12 = val_22 / val_12;
            val_12 = val_12 * 100f;
            val_24 = (int)val_12;
        }
        else
        {
                val_24 = 0;
        }
        
        val_17 = val_17 | val_21;
        Rilisoft.丞丛七上丕专丏丌丈.丝丂丗丛丕丁丕丐万(世丙丟上丘上七万万:  (int)val_10, 与丙丕丛一丌丛丆丈:  0, 丙专七丘与丒丛丅丆:  (val_17 == true) ? 1 : 0);
    }
    protected override void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        VehicleEngine val_27;
        var val_28;
        UnityEngine.Object val_29;
        var val_30;
        var val_31;
        Player_move_c val_32;
        var val_33;
        var val_34;
        var val_35;
        val_27 = this;
        this.OnTriggerEnter(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅);
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                if((System.String.op_Equality(a:  丘丛丏丘丝七世七丅.gameObject.name, b:  "DisableGrip")) != false)
        {
                this.engine.丌丆丅丑世丌一不丈();
        }
        
        }
        
        if(this.photonView.isMine != false)
        {
                if((丘丛丏丘丝七世七丅.gameObject.GetComponent<PlayerCheckpointShortcut>()) != 0)
        {
                val_28 = null;
            val_28 = null;
            RacingCheckpointController.丄丘七三上丕世丞业.不丏世世上下丒丁丒(丆丄丘七东世丒丐七:  val_8.checkpointToSet);
        }
        
        }
        
        val_29 = 0;
        if(丘丛丏丘丝七世七丅.transform.parent != 0)
        {
                val_29 = 0;
            if((丘丛丏丘丝七世七丅.transform.parent.CompareTag(tag:  "Player")) != false)
        {
                val_29 = 丘丛丏丘丝七世七丅.transform.parent.GetComponent<SkinName>();
        }
        
        }
        
        val_30 = null;
        val_30 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_34;
        }
        
        }
        
        val_31 = 1;
        goto label_35;
        label_34:
        val_32 = 0;
        if(val_29 != 0)
        {
                val_32 = val_18.playerMoveC;
        }
        
        val_31 = (GameController.onlineMode.与丒与丐丂丘丂丒丕(专丞上七七且丝七丗:  val_32)) ^ 1;
        label_35:
        val_33 = this.photonView;
        if(val_33.isMine == false)
        {
                return;
        }
        
        val_33 = 丘丛丏丘丝七世七丅.gameObject;
        if((val_33.CompareTag(tag:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_34 = null;
        val_34 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_198 == 丘丛丏丘丝七世七丅)
        {
                return;
        }
        
        val_27 = this.engine;
        var val_26 = (S0 > 0f) ? 1 : 0;
        val_26 = val_31 & val_26;
        if(val_26 != true)
        {
                return;
        }
        
        val_35 = null;
        val_35 = null;
        this.丐业丑丁与丒一丁业(丌丑丛业丈丘世丞丕:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
    }
    private void 丐业丑丁与丒一丁业(Player_move_c 丌丑丛业丈丘世丞丕)
    {
        var val_15;
        var val_16;
        bool val_17;
        bool val_18;
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        float val_23;
        int val_24;
        val_15 = null;
        val_15 = null;
        if(GameController.onlineMode != 0)
        {
                val_16 = null;
            val_16 = null;
            val_17 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_17 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_17 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
            val_18 = val_4.squadMode;
        }
        else
        {
                val_18 = 0;
        }
        
        val_19 = null;
        val_19 = null;
        if(GameController.onlineMode != 0)
        {
                val_20 = null;
            val_20 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        }
        
        val_21 = 0;
        if(丌丑丛业丈丘世丞丕 == null)
        {
            goto label_28;
        }
        
        label_30:
        val_22 = 丌丑丛业丈丘世丞丕.丘七业丒丐世丂丅丒();
        val_23 = 丌丑丛业丈丘世丞丕.专一丟丏且丆丕丝七();
        goto label_29;
        label_27:
        val_21 = GameController.onlineMode.丄丗三丌世东业上丌();
        if(丌丑丛业丈丘世丞丕 != null)
        {
            goto label_30;
        }
        
        label_28:
        val_22 = 0.丘七业丒丐世丂丅丒();
        float val_10 = 0.专一丟丏且丆丕丝七();
        val_23 = val_10;
        label_29:
        val_10 = val_22 / val_23;
        val_17 = val_18 | val_17;
        val_10 = val_10 * 100f;
        if(丌丑丛业丈丘世丞丕.与丙丕丛一丌丛丆丈 != null)
        {
                val_22 = 丌丑丛业丈丘世丞丕.与丙丕丛一丌丛丆丈.丈下丏丟丑丐丆三不();
            float val_12 = 丌丑丛业丈丘世丞丕.与丙丕丛一丌丛丆丈.七丁丙丅丂上丒丞丙();
            val_12 = val_22 / val_12;
            val_12 = val_12 * 100f;
            val_24 = (int)val_12;
        }
        else
        {
                val_24 = 0;
        }
        
        val_17 = val_17 | val_21;
        Rilisoft.丞丛七上丕专丏丌丈.丐业丑丁与丒一丁业(世丙丟上丘上七万万:  (int)val_10, 与丙丕丛一丌丛丆丈:  0, 丙专七丘与丒丛丅丆:  (val_17 == true) ? 1 : 0);
    }
    private void 丗专丈三丟丅丘丐丘(ref 业丗丕丟三丝丘三丗 丅东专与不三丂丁丝, bool 丞三丕世业三丒丅三, 业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 且下丕七丙丗丄不七, uint 丑丞丈丗丄丙丟万丄)
    {
        业丗丕丟三丝丘三丗 val_4;
        bool val_5;
        var val_6;
        var val_7;
        val_4 = 丅东专与不三丂丁丝;
        if(val_4 != null)
        {
                val_5 = mem[丅东专与不三丂丁丝 + 60];
            val_5 = 丅东专与不三丂丁丝.下丌丘七专丂七三丆;
        }
        else
        {
                val_5 = 1;
        }
        
        val_5 = val_5 & 丞三丕世业三丒丅三;
        if(val_5 != false)
        {
                val_6 = null;
            val_6 = null;
            UnityEngine.Color val_2 = 丞东丑专丛丆丄丝世.且丁丒丙丞丙丒丈上(一丞万丈丌上丌丛七:  丑丞丈丗丄丙丟万丄);
            丅东专与不三丂丁丝 = ScopeViewGameEventsController.丄丘七三上丕世丞业.AddEvent(且下丕七丙丗丄不七:  且下丕七丙丗丄不七, 业不不丞专丗丟世丈:  this.transform, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, 丑丘丛丆丝上丂丙丗:  -1f, 丐丟丕丌与丞丅下万:  1f);
            return;
        }
        
        if(val_4 == null)
        {
                return;
        }
        
        if(丅东专与不三丂丁丝.下丌丘七专丂七三丆 == true)
        {
                return;
        }
        
        if(丞三丕世业三丒丅三 == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_4 = 丅东专与不三丂丁丝;
        ScopeViewGameEventsController.丄丘七三上丕世丞业.DisableEvent(丅东专与不三丂丁丝:  val_4);
    }
    protected override void Update()
    {
        ScopeViewGameEventsController val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        bool val_47;
        var val_48;
        UnityEngine.Object val_49;
        this.Update();
        if((this.photonView.isMine == false) || (GameConnect.且丘丄丛下丆丟万丕() == false))
        {
            goto label_13;
        }
        
        val_41 = 0;
        label_11:
        if(val_41 >= this.places.Length)
        {
            goto label_7;
        }
        
        val_41 = val_41 + 1;
        if(this.places[0] == 0)
        {
            goto label_11;
        }
        
        this.且丛东专丆下专专专 = 0f;
        goto label_13;
        label_7:
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.且丛东专丆下专专专 + val_5;
        this.且丛东专丆下专专专 = val_5;
        if(val_5 >= 5f)
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
        }
        
        label_13:
        this.丐下丕且丁三丗丈丅();
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_87;
        }
        
        val_42 = null;
        val_42 = null;
        val_43 = null;
        val_43 = null;
        val_41 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        if((val_41 == 0) || (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0))
        {
            goto label_29;
        }
        
        if(((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) || (typeof(Player_move_c).__il2cppRuntimeField_628 == 0)) || ((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) == 0))
        {
            goto label_43;
        }
        
        val_44 = UnityEngine.Object.op_Equality(x:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224, y:  this);
        goto label_48;
        label_29:
        this.七一专丕丑丕丛丌业 = 0;
        this.丟丒丟丆东下丕丆七 = 0;
        this.专丆丙丟万丙万丘且 = 0;
        label_87:
        this.丆下世丌丌丅七东万();
        return;
        label_43:
        val_44 = 0;
        label_48:
        val_45 = null;
        val_45 = null;
        ScopeViewGameEventSettings val_14 = ScopeViewGameEventsController.丄丘七三上丕世丞业.GetEventSettings(且下丕七丙丗丄不七:  4);
        UnityEngine.Vector3 val_16 = this.transform.position;
        UnityEngine.Vector3 val_18 = transform.position;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        if(val_19.x <= (val_14.maxTargetDistance * val_14.maxTargetDistance))
        {
                bool val_21 = this.IsEnemyTo(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
            if(val_44 != 0)
        {
                val_46 = 0;
        }
        else
        {
                val_46 = UnityEngine.Object.op_Inequality(x:  this.places[0], y:  0);
        }
        
            this.丗专丈三丟丅丘丐丘(丅东专与不三丂丁丝: ref  this.七一专丕丑丕丛丌业, 丞三丕世业三丒丅三:  val_46 & val_21, 且下丕七丙丗丄不七:  4, 丑丞丈丗丄丙丟万丄:  -11516929);
            if(val_44 != 0)
        {
                val_47 = 0;
        }
        else
        {
                val_47 = (UnityEngine.Object.op_Inequality(x:  this.places[0], y:  0)) & val_21 ^ 1;
        }
        
            this.丗专丈三丟丅丘丐丘(丅东专与不三丂丁丝: ref  this.丟丒丟丆东下丕丆七, 丞三丕世业三丒丅三:  val_47, 且下丕七丙丗丄不七:  4, 丑丞丈丗丄丙丟万丄:  -112263168);
        }
        
        val_48 = null;
        val_48 = null;
        ScopeViewGameEventSettings val_29 = ScopeViewGameEventsController.丄丘七三上丕世丞业.GetEventSettings(且下丕七丙丗丄不七:  3);
        UnityEngine.Vector3 val_31 = this.transform.position;
        UnityEngine.Vector3 val_33 = transform.position;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        if(val_34.x > (val_29.maxTargetDistance * val_29.maxTargetDistance))
        {
            goto label_87;
        }
        
        val_49 = 0;
        this.丗专丈三丟丅丘丐丘(丅东专与不三丂丁丝: ref  this.专丆丙丟万丙万丘且, 丞三丕世业三丒丅三:  null, 且下丕七丙丗丄不七:  3, 丑丞丈丗丄丙丟万丄:  0);
        goto label_87;
    }
    private void LateUpdate()
    {
        if(W8 == 0)
        {
                return;
        }
        
        this.万与丝丄丅丅一丛丅();
    }
    internal void 丆业三与丆丒丂丅专(UnityEngine.Vector3 七丑丕丘上一万丂丁, UnityEngine.Quaternion 丅与丁下丞丅且丅专)
    {
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        val_9 = 丅与丁下丞丅且丅专.w;
        val_10 = 丅与丁下丞丅且丅专.y;
        val_11 = 七丑丕丘上一万丂丁.z;
        val_12 = 七丑丕丘上一万丂丁.x;
        if(this.currentView == 0)
        {
                return;
        }
        
        this.专丈丒三丕下丈丁丛 = 0f;
        UnityEngine.Vector3 val_3 = this.currentView.transform.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_12, y = 七丑丕丘上一万丂丁.y, z = val_11});
        this.丑丌丙丛三专且丕三 = val_4;
        mem[1152921540666215004] = val_4.y;
        mem[1152921540666215008] = val_4.z;
        val_9 = val_9;
        UnityEngine.Quaternion val_6 = this.currentView.transform.rotation;
        val_10 = val_10;
        val_11 = val_6.x;
        val_12 = val_6.z;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = 丅与丁下丞丅且丅专.x, y = val_10, z = 丅与丁下丞丅且丅专.z, w = val_9});
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_11, y = val_6.y, z = val_12, w = val_6.w}, rhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        this.丛丁丗业一与东丑丑 = val_8;
        mem[1152921540666215016] = val_8.y;
        mem[1152921540666215020] = val_8.z;
        mem[1152921540666215024] = val_8.w;
    }
    private void 万与丝丄丅丅一丛丅()
    {
        var val_31;
        float val_34;
        float val_35;
        float val_36;
        var val_38;
        val_31 = this;
        if(this.currentView == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丑丌丙丛三专且丕三, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, t:  this.专丈丒三丕下丈丁丛);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.currentView.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Quaternion val_10 = this.transform.rotation;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.丛丁丗业一与东丑丑, y = V14.16B, z = V12.16B, w = this.丑丌丙丛三专且丕三}, b:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, t:  this.专丈丒三丕下丈丁丛);
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, rhs:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w});
        val_34 = val_13.w;
        this.currentView.transform.rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_34};
        float val_14 = UnityEngine.Time.deltaTime;
        val_35 = this.correctionTime;
        val_36 = val_14;
        val_14 = val_36 / val_35;
        val_14 = this.专丈丒三丕下丈丁丛 + val_14;
        this.专丈丒三丕下丈丁丛 = UnityEngine.Mathf.Clamp01(value:  val_14);
        val_38 = 0;
        goto label_16;
        label_48:
        if(this.places[0] != 0)
        {
                Player_move_c val_32 = this.places[0];
            UnityEngine.Vector3 val_18 = VehicleView.__il2cppRuntimeField_byval_arg.position;
            this.places[0x0][0].mySkinName.firstPersonControl.丗且丙丄七东丟丝下().position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            Player_move_c val_33 = this.places[0];
            UnityEngine.Quaternion val_20 = VehicleView.__il2cppRuntimeField_byval_arg.rotation;
            val_36 = val_20.x;
            val_35 = val_20.z;
            val_34 = val_20.w;
            this.places[0x0][0].mySkinName.firstPersonControl.丗且丙丄七东丟丝下().rotation = new UnityEngine.Quaternion() {x = val_36, y = val_20.y, z = val_35, w = val_34};
            Player_move_c val_34 = this.places[0];
            this.places[0x0][0].nickLabel.GetComponent<CameraFacingBilloard>().上丛一丗丝万万七丆();
        }
        
        val_38 = 1;
        label_16:
        if(val_38 < this.places.Length)
        {
            goto label_48;
        }
        
        bool val_23 = this.photonView.isMine;
        if(this.viewCollider == null)
        {
            goto label_50;
        }
        
        if(val_23 == false)
        {
            goto label_51;
        }
        
        label_52:
        this.viewCollider.SetActive(value:  false);
        return;
        label_50:
        if(val_23 == true)
        {
            goto label_52;
        }
        
        label_51:
        this.viewCollider.transform.parent = 0;
        UnityEngine.Vector3 val_27 = this.currentView.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.viewCollider.transform.position = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
        val_31 = this.viewCollider.transform;
        UnityEngine.Quaternion val_30 = this.currentView.transform.rotation;
        val_31.rotation = new UnityEngine.Quaternion() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w};
    }
    internal override void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        UnityEngine.Object val_20;
        object val_21;
        this.OnPhotonPlayerConnected(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        val_20 = this.photonView;
        if(val_20.isMine != false)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_20 = this.photonView;
            object[] val_5 = new object[3];
            val_5[0] = this.engine.丁一丌上丆丑丈不丐;
            val_5[1] = this.engine.丅专专丝业不丈专丐;
            val_21 = this.engine.业丛东丟丗丘丙东丅;
            val_5[2] = val_21;
            val_20.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  193, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_5);
        }
        
            if(this.丗万丝丁丛丗丈丙丞 != false)
        {
                val_20 = this.photonView;
            val_20.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  14, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
            if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_20 = this.photonView;
            object[] val_10 = new object[1];
            val_21 = this.currentView.不丗丘丘一丕丑专一;
            val_10[0] = val_21;
            val_20.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  195, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_10);
        }
        
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        val_20 = this.万东丂七东丁与业东();
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.万东丂七东丁与业东();
        if((val_20.丟丝丐且且丁丏丝上(丞丅上丏丂且下丅与:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())) == false)
        {
                return;
        }
        
        val_20 = this.photonView;
        object[] val_19 = new object[3];
        val_19[0] = this.engine.丁一丌上丆丑丈不丐;
        val_21 = this.engine.丅专专丝业不丈专丐;
        val_19[1] = val_21;
        val_19[2] = this.engine.业丛东丟丗丘丙东丅;
        val_20.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  193, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_19);
    }
    private int 丂上丒东丟丘专业丕(float 丕丟一东三丏丝丞丞)
    {
        UnityEngine.AudioClip val_7;
        double val_8;
        val_7 = this;
        val_8 = 0.99;
        if((double)this.丙三丈三三专丄一丘 < 0)
        {
                val_8 = this.丙三丈三三专丄一丘 + UnityEngine.Time.deltaTime;
            this.丙三丈三三专丄一丘 = val_8;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.下丕丌丝丘不丐专丏 - val_2;
        this.下丕丌丝丘不丐专丏 = val_2;
        float val_7 = this.maxSpeed;
        val_7 = 丕丟一东三丏丝丞丞 / (val_7 / (float)this.gears);
        int val_5 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_7), min:  0, max:  this.gears);
        if(this.东丘不世七丝丅丞丌 == val_5)
        {
                return val_5;
        }
        
        this.东丘不世七丝丅丞丌 = val_5;
        if(this.下丕丌丝丘不丐专丏 >= 0)
        {
                return val_5;
        }
        
        mem2[0] = 1084227584;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return val_5;
        }
        
        this.freeAudioSource.enabled = true;
        val_7 = this.gear;
        this.freeAudioSource.PlayOneShot(clip:  val_7, volumeScale:  0.3f);
        return val_5;
    }
    internal override void 丄丈丙丗丅万上东三(bool 丝世丏丑专丄丒业丏)
    {
        var val_11;
        UnityEngine.AudioClip val_12;
        if(this.世七丁与丘下丏丗丘 != null)
        {
                this.StopCoroutine(routine:  this.世七丁与丘下丏丗丘);
        }
        
        this.engineAudioSource.volume = 1f;
        this.skidAudioSource.volume = (丝世丏丑专丄丒业丏 != true) ? 1f : 0f;
        if(丝世丏丑专丄丒业丏 == false)
        {
            goto label_4;
        }
        
        val_11 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        if(this.skidAudioSource != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_4:
        val_11 = 0;
        if(this.skidAudioSource != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        this.skidAudioSource.enabled = false;
        if(丝世丏丑专丄丒业丏 != false)
        {
                this.engineAudioSource.enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            val_12 = this.engineStart;
            this.engineAudioSource.clip = val_12;
            this.engineAudioSource.loop = false;
            this.engineAudioSource.Play();
            System.Collections.IEnumerator val_5 = this.上与丗丄且丏丆东专();
        }
        else
        {
                this.engineAudioSource.enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            this.engineAudioSource.Stop();
            val_12 = this.engineStop;
            this.engineAudioSource.clip = val_12;
            this.engineAudioSource.loop = false;
            this.engineAudioSource.Play();
        }
        
        this.世七丁与丘下丏丗丘 = this.StartCoroutine(routine:  this.丈上丑下丒上丐丐业());
    }
    private System.Collections.IEnumerator 上与丗丄且丏丆东专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleController.丈东七丗丈三丅丐丙();
    }
    private System.Collections.IEnumerator 丈上丑下丒上丐丐业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleController.丞且丄且一丘丂业丟();
    }
    private void 丗丑丟丛丛丘三世丙()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.freeAudioSource.enabled = true;
        this.freeAudioSource.PlayOneShot(clip:  this.horn);
    }
    public void UpdateSoundEffects(float 丕丟一东三丏丝丞丞, bool 丝东七一丛丅丏且三, bool 业丂万丏丒丛丒万且, float 丝专丛丐专上丞丟三 = 0)
    {
        var val_36;
        VehicleEngine val_37;
        int val_38;
        var val_39;
        float val_40;
        float val_42;
        float val_43;
        float val_44;
        UnityEngine.AudioSource val_45;
        float val_47;
        if((GameConnect.且丘丄丛下丆丟万丕() != false) && (this.photonView.isMine != false))
        {
                val_36 = (~Player_move_c.丗丒丕专丛丆丈万一()) & 1;
        }
        else
        {
                val_36 = 0;
        }
        
        val_37 = this.engine;
        if(this.engine != null)
        {
            goto label_9;
        }
        
        val_37 = this.engine;
        if(val_37 == null)
        {
            goto label_10;
        }
        
        label_9:
        if(val_36 != 0)
        {
                val_38 = this.gears;
            val_39 = val_38;
        }
        else
        {
                val_39 = this;
            val_38 = this.gears;
        }
        
        val_40 = (float)this.丂上丒东丟丘专业丕(丕丟一东三丏丝丞丞:  丕丟一东三丏丝丞丞);
        float val_6 = this.maxSpeed / (float)val_38;
        if(this.isAccelerates != false)
        {
                this.isAccelerates = (this.与丂丈丙丈丏丙丑上 <= 丕丟一东三丏丝丞丞) ? 1 : 0;
            this.丐丁三专东世且丒丐 = 0.5f;
        }
        else
        {
                this.isAccelerates = (this.与丂丈丙丈丏丙丑上 < 0) ? 1 : 0;
            float val_9 = UnityEngine.Time.deltaTime;
            val_9 = this.丐丁三专东世且丒丐 - val_9;
            this.丐丁三专东世且丒丐 = val_9;
        }
        
        float val_10 = val_6 * val_40;
        val_10 = 丕丟一东三丏丝丞丞 - val_10;
        val_6 = val_10 / val_6;
        this.与丂丈丙丈丏丙丑上 = 丕丟一东三丏丝丞丞;
        val_42 = UnityEngine.Mathf.Lerp(a:  0f, b:  this.pitchCurve.Evaluate(time:  val_6), t:  this.丐丁三专东世且丒丐);
        float val_13 = this.engine.且业丐丝专与丁丐且 / this.engine.startAssistance;
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                float val_15 = this.pitchStep * val_40;
            val_15 = val_42 + val_15;
            val_42 = UnityEngine.Mathf.Max(a:  val_15, b:  val_13);
            val_43 = 0.5f;
        }
        else
        {
                val_43 = (this.pitchStep * val_40) + 0.5f;
        }
        
        val_43 = val_42 + val_43;
        this.engineAudioSource.pitch = val_43;
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                float val_34 = 30f;
            val_34 = 丕丟一东三丏丝丞丞 / val_34;
            val_44 = UnityEngine.Mathf.Max(a:  val_34, b:  val_13);
        }
        else
        {
                val_44 = 丕丟一东三丏丝丞丞 / 30f;
        }
        
        bool val_21 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        val_45 = this.engineAudioSource;
        if(val_45 == null)
        {
            goto label_34;
        }
        
        if(val_21 == false)
        {
            goto label_35;
        }
        
        label_43:
        val_45.enabled = true;
        val_45 = this.engineAudioSource;
        if(this.engineAudioSource.loop == false)
        {
            goto label_37;
        }
        
        float val_35 = 0.7f;
        float val_36 = 0.3f;
        val_35 = val_44 * val_35;
        val_35 = val_35 + val_36;
        val_40 = UnityEngine.Mathf.Clamp01(value:  val_35);
        val_36 = this.丙三丈三三专丄一丘 * val_40;
        float val_27 = UnityEngine.Mathf.Lerp(a:  val_45.volume, b:  val_36, t:  UnityEngine.Time.deltaTime + UnityEngine.Time.deltaTime);
        if(val_45 != null)
        {
            goto label_42;
        }
        
        goto label_42;
        label_34:
        if(val_21 == true)
        {
            goto label_43;
        }
        
        label_35:
        val_45.enabled = false;
        goto label_44;
        label_37:
        label_42:
        val_45.volume = 1f;
        label_44:
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (业丂万丏丒丛丒万且 != false))
        {
                float val_30 = (丝专丛丐专上丞丟三 > 0f) ? 丝专丛丐专上丞丟三 : (((丝东七一丛丅丏且三 != true) ? 1f : 0f) * val_44);
            this.skidAudioSource.enabled = true;
            this.gravelSource.enabled = true;
            val_30 = val_30 + (-0.1f);
            this.skidAudioSource.volume = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_30);
            this.skidAudioSource.pitch = UnityEngine.Mathf.Lerp(a:  0.5f, b:  1f, t:  val_30);
            val_47 = 0f;
            if(丕丟一东三丏丝丞丞 >= 0)
        {
                val_47 = UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  val_44);
        }
        
            this.gravelSource.volume = val_47;
            float val_37 = 0.3f;
            val_37 = val_44 + val_37;
            this.gravelSource.pitch = val_37;
            return;
        }
        
        this.skidAudioSource.volume = 0f;
        this.gravelSource.volume = 0f;
        this.skidAudioSource.enabled = false;
        this.gravelSource.enabled = false;
        return;
        label_10:
    }
    protected override void 丟丄丌万丙丘丑丆丘(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙, int 丐丟丘世丁三丕专专, int 不万上丕丅丏丆丄丝 = 0)
    {
        UnityEngine.AudioClip[] val_14;
        UnityEngine.AudioClip val_15;
        UnityEngine.AudioClip val_16;
        val_14 = 丐丟丘世丁三丕专专;
        if(val_14 == 1)
        {
                if(this.IsDead() == false)
        {
            goto label_2;
        }
        
        }
        
        if(this.万丞丆丌世丝丞丆上() <= 0f)
        {
                return;
        }
        
        float val_3 = this.万丞丆丌世丝丞丆上();
        val_3 = val_3 - 丛业专丘丂丅丗丝丛;
        this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  val_3);
        this.丞丑丅丆丐丛丏丏丌();
        if((this.万丞丆丌世丝丞丆上() <= 0f) && (null == null))
        {
                if(this.IsDead() != true)
        {
                mem[1152921540668600328] = this.StartCoroutine(routine:  this.丝丞七丏与世丒丟三(丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙, 与丞丗丟七下丐丛且:  5f, 不万上丕丅丏丆丄丝:  不万上丕丅丏丆丄丝));
        }
        
        }
        
        if(val_14 != 3)
        {
            goto label_7;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.engine.carRigidbody.isKinematic == true)
        {
                return;
        }
        
        this.freeAudioSource.enabled = true;
        val_15 = this.bump;
        val_16 = val_15;
        goto label_16;
        label_2:
        if((public System.Boolean TransportControllerBase::IsDead()) != 0)
        {
                this.StopCoroutine(routine:  public System.Boolean TransportControllerBase::IsDead());
        }
        
        this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  -1f);
        this.丞丑丅丆丐丛丏丏丌();
        mem[1152921540668600328] = this.StartCoroutine(routine:  this.丝丞七丏与世丒丟三(丞丗且下世丐业丌丙:  0, 与丞丗丟七下丐丛且:  0f, 不万上丕丅丏丆丄丝:  不万上丕丅丏丆丄丝));
        return;
        label_7:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.freeAudioSource.enabled = true;
        val_14 = this.carHitSound;
        val_15 = this.freeAudioSource;
        val_16 = val_14[(long)UnityEngine.Random.Range(min:  0, max:  this.carHitSound.Length)];
        label_16:
        val_15.PlayOneShot(clip:  val_16);
    }
    private System.Collections.IEnumerator 丝丞七丏与世丒丟三(int 丞丗且下世丐业丌丙, float 与丞丗丟七下丐丛且, int 不万上丕丅丏丆丄丝)
    {
        VehicleController.丛丐世业且丘丙丝丑 val_1 = new VehicleController.丛丐世业且丘丙丝丑();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丞丗且下世丐业丌丙 = 丞丗且下世丐业丌丙;
            .与丞丗丟七下丐丛且 = 与丞丗丟七下丐丛且;
        }
        else
        {
                mem[40] = this;
            mem[32] = 丞丗且下世丐业丌丙;
            mem[48] = 与丞丗丟七下丐丛且;
        }
        
        .不万上丕丅丏丆丄丝 = 不万上丕丅丏丆丄丝;
        return (System.Collections.IEnumerator)val_1;
    }
    protected override void OnDestroy()
    {
        this.OnDestroy();
        if(this.currentView != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.currentView.gameObject);
        }
        
        if(this.viewCollider == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.viewCollider);
    }
    private void 丞三且丘丒丈丙世丘(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
        VehicleEngine val_7;
        var val_8;
        if((this.GetComponent<CarSyncRacing>()) != 0)
        {
                val_1.丕不丛丕丛丘丙丑丂 = true;
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        this.transform.rotation = new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.engine.carRigidbody.velocity = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.engine.carRigidbody.angularVelocity = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.engine.丁上丈丘丁丙丌东丑 = 0;
        this.engine.gearTime = 0f;
        val_7 = this.engine;
        val_8 = 0;
        goto label_16;
        label_21:
        val_7 = this.engine.wheels[0];
        if(val_7 != null)
        {
                val_7.motorTorque = 0f;
        }
        else
        {
                0.motorTorque = 0f;
        }
        
        val_7.brakeTorque = 0f;
        val_8 = 1;
        label_16:
        if(val_8 < this.engine.wheels.Length)
        {
            goto label_21;
        }
    
    }
    internal void 下丗一一丛丗丌世丆(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        var val_8;
        var val_9;
        val_8 = this;
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  14, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        this.丞三且丘丒丈丙世丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w});
        this.丗万丝丁丛丗丈丙丞 = true;
        this.丗丟且上丌一丐丙丛 = 0f;
        val_9 = null;
        val_9 = null;
        val_8 = this.transform;
        UnityEngine.Quaternion val_6 = val_8.rotation;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_6.y, y:  0f);
    }
    internal bool 丄上丐丏丒丝丘丐丈()
    {
        var val_8;
        var val_9;
        var val_10;
        if(this.photonView.isMine == false)
        {
                return false;
        }
        
        val_8 = null;
        val_8 = null;
        if(RacingCheckpointController.丄丘七三上丕世丞业 == 0)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        if(RacingCheckpointController.丄丘七三上丕世丞业.丆且且世丛丗三丁丌 == 0)
        {
                return false;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.Vector3 val_6 = transform.position;
        UnityEngine.Quaternion val_7 = RacingCheckpointController.丄丘七三上丕世丞业.上与上丂上七丞下丆();
        this.下丗一一丛丗丌世丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        return false;
    }
    private void 丐下丕且丁三丗丈丅()
    {
        UnityEngine.Object val_42;
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        UnityEngine.Object val_48;
        var val_49;
        var val_50;
        var val_51;
        float val_52;
        val_42 = this;
        if(this.丗万丝丁丛丗丈丙丞 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丗丟且上丌一丐丙丛 + val_1;
        this.丗丟且上丌一丐丙丛 = val_1;
        UnityEngine.BoxCollider val_2 = this.engine.sideColliders[0].GetComponent<UnityEngine.BoxCollider>();
        if(this.丗丟且上丌一丐丙丛 <= this.丂丞丅丄东丛丘万丄)
        {
            goto label_36;
        }
        
        UnityEngine.Vector3 val_4 = val_2.transform.position;
        UnityEngine.Vector3 val_5 = val_2.center;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_44 = val_6.z;
        if(val_2 != null)
        {
                UnityEngine.Vector3 val_7 = val_2.size;
            val_45 = val_7.x;
        }
        else
        {
                UnityEngine.Vector3 val_8 = val_2.size;
            val_45 = val_8.x;
        }
        
        UnityEngine.Vector3 val_10 = val_2.transform.lossyScale;
        if(val_2 != null)
        {
                UnityEngine.Vector3 val_11 = val_2.size;
            val_46 = val_11.y;
        }
        else
        {
                UnityEngine.Vector3 val_12 = val_2.size;
            val_46 = val_12.y;
        }
        
        UnityEngine.Vector3 val_14 = val_2.transform.lossyScale;
        if(val_2 != null)
        {
                UnityEngine.Vector3 val_15 = val_2.size;
            val_47 = val_15.z;
        }
        else
        {
                UnityEngine.Vector3 val_16 = val_2.size;
            val_47 = val_16.z;
        }
        
        val_48 = val_2.transform;
        UnityEngine.Vector3 val_18 = val_48.lossyScale;
        float val_43 = 0.5f;
        float val_19 = val_45 * val_43;
        float val_20 = val_46 * val_43;
        val_43 = val_47 * val_43;
        val_19 = val_19 * val_10.x;
        val_20 = val_20 * val_14.y;
        val_18.z = val_43 * val_18.z;
        float val_21 = val_19 + 0.25f;
        float val_22 = val_20 + 0.25f;
        val_18.z = val_18.z + 0.25f;
        UnityEngine.Quaternion val_24 = val_2.transform.rotation;
        this.丗万丝丁丛丗丈丙丞 = false;
        val_49 = 1152921540669769360;
        val_50 = 0;
        goto label_23;
        label_35:
        val_48 = UnityEngine.Physics.OverlapBox(center:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_44}, halfExtents:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, orientation:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.z, z = 0f, w = 0f})[0].transform.root.GetComponent<VehicleController>();
        if(val_48 != 0)
        {
                if(val_48 != this)
        {
            goto label_33;
        }
        
        }
        
        val_50 = 1;
        label_23:
        if(val_50 < val_25.Length)
        {
            goto label_35;
        }
        
        goto label_36;
        label_33:
        this.丗万丝丁丛丗丈丙丞 = true;
        label_36:
        if(this.photonView.isMine == false)
        {
            goto label_38;
        }
        
        val_49 = "Gun";
        val_51 = 0;
        goto label_39;
        label_44:
        val_48 = UnityEngine.LayerMask.NameToLayer(layerName:  (this.丗万丝丁丛丗丈丙丞 == true) ? (val_49) : "MyPlayer");
        this.colliderGO[0].layer = val_48;
        val_51 = 1;
        label_39:
        if(val_51 < this.colliderGO.Length)
        {
            goto label_44;
        }
        
        goto label_45;
        label_38:
        val_48 = this.丗万丝丁丛丗丈丙丞;
        this.viewCollider.gameObject.SetActive(value:  (val_48 == false) ? 1 : 0);
        label_45:
        if(this.丗万丝丁丛丗丈丙丞 != false)
        {
                float val_47 = this.丗丟且上丌一丐丙丛;
            float val_46 = (float)(int)val_47 / this.丗万丑丆丗三业丘下;
            val_46 = this.丗万丑丆丗三业丘下 * val_46;
            val_47 = val_47 - val_46;
            float val_38 = val_47 / this.丗万丑丆丗三业丘下;
            float val_48 = 1f;
            val_48 = val_48 - val_38;
            val_52 = UnityEngine.Mathf.Lerp(a:  this.丞丌丗专丘丝业下世, b:  this.丙万世上丙丑下世丗, t:  ((((int)val_47 / this.丗万丑丆丗三业丘下) & (1.401298E-45f)) != 0) ? (val_38) : (val_48));
            UnityEngine.Debug.Log(message:  val_38);
        }
        else
        {
                val_52 = 1f;
        }
        
        if(this.currentView == 0)
        {
                return;
        }
        
        val_42 = this.currentView;
        val_42.SetFloat(name:  "_Alpha", value:  val_52);
    }
    private void 丟业万与与丑丘丄上()
    {
        this.丗万丝丁丛丗丈丙丞 = true;
        this.丗丟且上丌一丐丙丛 = 0f;
    }
    protected override void 丘丘业丁一与丅丛丗(丅丙上七上一丐不下 丆丝专专丟丟丈丏丐)
    {
        var val_19;
        Player_move_c[] val_20;
        var val_21;
        var val_22;
        var val_23;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        var val_31;
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_67;
        }
        
        val_20 = this.places;
        val_21 = 0;
        goto label_4;
        label_13:
        Player_move_c val_21 = val_20[0];
        if(val_21 != 0)
        {
                if(val_21.丟丌下三七丁与丟丑() != false)
        {
                val_21.丏丘丂丝丝丙丕丂不(东丏业丞丞业下丄世:  1);
        }
        
        }
        
        val_21 = 1;
        label_4:
        if(val_21 < this.places.Length)
        {
            goto label_13;
        }
        
        val_19 = this.photonView;
        if(val_19.isMine == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = null;
        val_23 = null;
        val_19 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
        label_47:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_19.MoveNext() == false)
        {
            goto label_27;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        T val_11 = val_19.Current;
        丅丙上七上一丐不下 val_12 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_11);
        if(val_12 == null)
        {
            goto label_47;
        }
        
        UnityEngine.Vector3 val_13 = val_11.position;
        UnityEngine.Vector3 val_15 = this.丌丟丄业且三丛丕丄().position;
        val_26 = val_13.x;
        val_27 = val_13.z;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26, y = val_13.y, z = val_27}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        if(val_16.x >= 0)
        {
            goto label_47;
        }
        
        if(val_16.x > val_16.y)
        {
                val_16.x = val_16.x - val_16.y;
            val_16.x = val_16.z - val_16.x;
            val_28 = val_16.z - val_16.y;
            val_26 = val_16.x / val_28;
            val_29 = val_13.x * val_26;
        }
        
        UnityEngine.Vector3 val_18 = this.transform.position;
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_12.ApplyDamage(丞丈专下丈专业三丞:  val_29, 丛世一丟丞丁业丘丒:  丆丝专专丟丟丈丏丐, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, 丐丟丘世丁三丕专专:  3, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        goto label_47;
        label_27:
        val_20 = 0;
        val_31 = 0;
        if(val_19 == null)
        {
            
        }
        else
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_19.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        label_67:
        this.丘丘业丁一与丅丛丗(丆丝专专丟丟丈丏丐:  丆丝专专丟丟丈丏丐);
    }
    internal override 丏丐丏丘下东丁丐一 丙丒丄丈丏万丛丈丛()
    {
        return 1;
    }
    internal override TransportViewBase 丑丕丛七丁丏七东上()
    {
        return (TransportViewBase)this.currentView;
    }
    internal override string 丐丙与七七丁七丛业()
    {
        return "royale_car_basic";
    }
    internal override TransportEngineBase 丕不丆丙世世丄丌丆()
    {
        return (TransportEngineBase)this.engine;
    }
    internal override UnityEngine.GameObject[] 丑业丒丐丒世丗丒丛()
    {
        return (UnityEngine.GameObject[])this.colliderGO;
    }
    internal override PGCompany.业丐与丕丒下丑下丈 一丂万世丙上万世丛()
    {
        return 3;
    }
    internal override PGCompany.业丐与丕丒下丑下丈 丑世丙且丅与丌丛丁()
    {
        return 4;
    }
    internal override 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 丙丒丌专丕丒不丅东()
    {
        return 4;
    }
    internal override UnityEngine.Transform 丞丈上且丙上丘丘七()
    {
        return this.丌丟丄业且三丛丕丄();
    }
    internal override float 下丗丟丁丝丝三专世()
    {
        return UnityEngine.Mathf.Lerp(a:  0f, b:  this.maxDamageGetOutPlayer, t:  V0.16B / this.engine.maxSpeed);
    }
    internal override Player_move_c[] 丝世东丙下丈丒专世()
    {
        return (Player_move_c[])this.places;
    }
    internal override void 下丏且一三丐一丐不(三下丕丕七丂丕丈且 丏丂丄丆丂东丝丆丏)
    {
        if(丏丂丄丆丂东丝丆丏 == null)
        {
                return;
        }
        
        var val_1 = (((三下丕丕七丂丕丈且.__il2cppRuntimeField_typeHierarchy + (三丅丟三丑七上丂不.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丏丂丄丆丂东丝丆丏 : 0;
        this.engine.vertical = val_1.丞丁下丛且丞丁丆丗();
        this = this.engine;
        this.engine.horizontal = val_1.不与丒与下丏一上丁();
    }
    internal override bool 世业丈三丒万丟不七()
    {
        var val_2;
        if(S0 > this.maxSpeedGetOutPlayer)
        {
                var val_1 = (null == 0) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    public VehicleController()
    {
        this.maxSpeedGetOutPlayer = 10f;
        this.maxDamageGetOutPlayer = 20f;
        this.correctionTime = 0.4f;
        this.不丗丘丘一丕丑专一 = 0;
        this.places = new Player_move_c[4];
        this.gears = 4;
        mem2[0] = 1114636288;
        this.丙三丈三三专丄一丘 = 1f;
        this.丂丞丅丄东丛丘万丄 = 3f;
        this.丞丌丗专丘丝业下世 = 0.2f;
        this.丙万世上丙丑下世丗 = 1.836682E-41f;
        this.丗万丑丆丗三业丘下 = 0.5f;
    }
    private static VehicleController()
    {
    
    }

}
