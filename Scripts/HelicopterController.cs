using UnityEngine;
internal class HelicopterController : TransportControllerBase, 东丁丆一业丈万丆丐
{
    // Fields
    public HelicopterEngine engine;
    public HelicopterView view;
    public UnityEngine.GameObject[] colliders;
    public HelicopterDeadView deadView;
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
    public UnityEngine.AudioClip[] hitSound;
    public int gears;
    public float maxSpeed;
    public float pitchStep;
    public UnityEngine.AnimationCurve pitchCurve;
    private int 东丘不世七丝丅丞丌;
    public bool isAccelerates;
    private float 与丂丈丙丈丏丙丑上;
    private float 下丕丌丝丘不丐专丏;
    private float 丙三丈三三专丄一丘;
    private Player_move_c[] 丂丈丞东丐丁丘丒上;
    private UnityEngine.Vector3 世丑丐丐世丗下世丙;
    private FreeplayVehicleSpawnPoint <与丕丘丌丑东丆丙丙>k__BackingField;
    private bool 丒丘一业丙丅丕业丂;
    private float 东丒丁丁丒业丑上丅;
    private float 丕丌丈一七丗专丙与;
    private float 丙丂且不丌且万七东;
    private bool 七丑且丅丛下专丕业;
    private bool 丛三丟丘丈丏三丈下;
    private float 丐丁三专东世且丒丐;
    private readonly float <丙丙万丞丟一上三丗>k__BackingField;
    private UnityEngine.Coroutine 世七丁与丘下丏丗丘;
    private System.Collections.Generic.Dictionary<UnityEngine.Collider, HelicopterController.丁不丘七丞丆丝丁下> 丒丗东与丙下万世下;
    
    // Properties
    internal FreeplayVehicleSpawnPoint 丞上专东丞丙丅不世 { get; set; }
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
    internal FreeplayVehicleSpawnPoint 与三丌下丗丘专下丒()
    {
        return (FreeplayVehicleSpawnPoint)this.<与丕丘丌丑东丆丙丙>k__BackingField;
    }
    internal void 与与丕丏专东丘下丝(FreeplayVehicleSpawnPoint 丙业与丙丗丝不丈东)
    {
        this.<与丕丘丌丑东丆丙丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected override void Awake()
    {
        this.Awake();
        this.freeAudioSource.volume = 1f;
        this.freeAudioSource.enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void HelicopterController::丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    protected void LateUpdate()
    {
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        if((this & 1) != 0)
        {
                return;
        }
        
        this.丗丘与丗一丑丘下世();
    }
    protected override void Update()
    {
        var val_11;
        var val_12;
        if((this & 1) == 0)
        {
                this.Update();
            this.丝七丂世丐丏丆且丁();
        }
        
        if(this.photonView.isMine != false)
        {
                this.三丈世丘东丏不上丆();
        }
        
        if(this.photonView.isMine == false)
        {
            goto label_5;
        }
        
        label_21:
        this.丏业丐丒丄丕丅丙丗();
        goto label_12;
        label_5:
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_12;
        }
        
        val_12 = null;
        val_12 = null;
        UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_8 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) < 0)
        {
            goto label_21;
        }
        
        label_12:
        this.丝丘丒丛三业且丄世();
        this.丆下世丌丌丅七东万();
    }
    private void 三丈世丘东丏不上丆()
    {
        if(this.丒丘一业丙丅丕业丂 != false)
        {
                if((this & 1) == 0)
        {
            goto label_1;
        }
        
        }
        
        if((this & 1) != 0)
        {
                label_1:
            this.七丑且丅丛下专丕业 = false;
            return;
        }
        
        if(this.七丑且丅丛下专丕业 != true)
        {
                if((this & 1) == 0)
        {
                if((this & 1) != 0)
        {
            goto label_6;
        }
        
        }
        
            this.七丑且丅丛下专丕业 = true;
            this.丙丂且不丌且万七东 = (this != 1) ? this.东丒丁丁丒业丑上丅 : this.丕丌丈一七丗专丙与;
        }
        
        label_6:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丙丂且不丌且万七东 - val_2;
        this.丙丂且不丌且万七东 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        if(this.七丑且丅丛下专丕业 == false)
        {
                return;
        }
        
        goto typeof(HelicopterController).__il2cppRuntimeField_568;
    }
    private void 丝七丂世丐丏丆且丁()
    {
        var val_19;
        float val_21;
        UnityEngine.Vector3 val_22;
        float val_23;
        var val_24;
        var val_25;
        float val_27;
        var val_28;
        float val_31;
        if((this.photonView.isMine == false) || ((this & 1) == 0))
        {
            goto label_3;
        }
        
        val_19 = null;
        val_19 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled == false)
        {
            goto label_9;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_21 = this.世丑丐丐世丗下世丙;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_21, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == false)
        {
            goto label_9;
        }
        
        val_22 = this.世丑丐丐世丗下世丙;
        val_23 = W10;
        val_24 = typeof(HelicopterController).__il2cppRuntimeField_3A8;
        goto label_10;
        label_3:
        if(this.engine != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        this.engine.下丏且一三丐一丐不(丏丂丄丆丂东丝丆丏:  new 丑与且丂下不万三业());
        return;
        label_9:
        val_25 = null;
        val_25 = null;
        if(isPressed != false)
        {
                val_27 = -1f;
        }
        else
        {
                val_28 = null;
            val_28 = null;
            val_21 = 0f;
            var val_8 = (isPressed != true) ? 1f : (val_21);
        }
        
        float val_9 = JoystickController.丗三丄与丂丟丌专东.value.sqrMagnitude;
        val_9 = S10 * val_9;
        if(val_9 > val_9)
        {
                float val_10 = UnityEngine.Mathf.Sign(f:  JoystickController.丗三丄与丂丟丌专东.value);
            float val_11 = UnityEngine.Mathf.Sign(f:  JoystickController.丗三丄与丂丟丌专东 + 192 + 4);
            float val_18 = System.Math.Abs(JoystickController.丗三丄与丂丟丌专东.value);
            val_31 = 0f;
            if(val_18 > JoystickController.丗三丄与丂丟丌专东.value)
        {
                val_31 = val_10 * val_18;
            float val_13 = UnityEngine.Mathf.Lerp(a:  val_31, b:  val_10, t:  val_10 * JoystickController.丗三丄与丂丟丌专东.value);
        }
        
            float val_16 = UnityEngine.Mathf.Lerp(a:  val_11 * val_10, b:  val_11, t:  val_11 * (JoystickController.丗三丄与丂丟丌专东 + 192 + 4));
        }
        
        val_22 = this.世丑丐丐世丗下世丙;
        val_23 = ???;
        label_10:
        丑与且丂下不万三业 val_17 = new 丑与且丂下不万三业(丁东丂丅业上丁丙丕:  val_22, 丝丞世且下丁三世三:  val_23, 丗业丗丌不丌丏丏三:  typeof(HelicopterController).__il2cppRuntimeField_3A8);
        if(this.engine != null)
        {
            goto label_37;
        }
        
        goto label_38;
    }
    private void 丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(七丐丅专且专七三丆 != 22)
        {
                return;
        }
        
        this.世丑丐丐世丗下世丙 = new UnityEngine.Vector3();
        mem[1152921539380274936] = null;
    }
    private void 丝丘丒丛三业且丄世()
    {
        UnityEngine.GameObject val_6;
        if(this.丛三丟丘丈丏三丈下 == true)
        {
                return;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        val_6 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
                return;
        }
        
        if(InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg == 0)
        {
                return;
        }
        
        val_6 = this.gameObject;
        InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg.丛丘丗丆丌丏不丑专(万不且且丛丆东丒业:  val_6, 丁丅丈丌丟世丗丗丟:  26);
        this.丛三丟丘丈丏三丈下 = true;
    }
    protected override void OnDestroy()
    {
        this.OnDestroy();
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void HelicopterController::丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private System.Collections.IEnumerator 丝丞七丏与世丒丟三(int 丞丗且下世丐业丌丙, float 与丞丗丟七下丐丛且, int 不万上丕丅丏丆丄丝)
    {
        HelicopterController.丏丆一丘万不丅专且 val_1 = new HelicopterController.丏丆一丘万不丅专且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丞丗且下世丐业丌丙 = 丞丗且下世丐业丌丙;
            .与丞丗丟七下丐丛且 = 与丞丗丟七下丐丛且;
        }
        else
        {
                mem[32] = this;
            .丞丗且下世丐业丌丙 = 丞丗且下世丐业丌丙;
            mem[40] = 与丞丗丟七下丐丛且;
        }
        
        .不万上丕丅丏丆丄丝 = 不万上丕丅丏丆丄丝;
        return (System.Collections.IEnumerator)val_1;
    }
    protected override void 丄世万丘上七丛三万()
    {
        this.丄世万丘上七丛三万();
        if(this.丙丂且不丌且万七东 <= this.东丒丁丁丒业丑上丅)
        {
                return;
        }
        
        this.丙丂且不丌且万七东 = this.东丒丁丁丒业丑上丅;
    }
    private System.Collections.IEnumerator 上与丗丄且丏丆东专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new HelicopterController.万丏上世丝丅丁业丆();
    }
    private System.Collections.IEnumerator 丈上丑下丒上丐丐业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new HelicopterController.与丙一丄下与下业丆();
    }
    private int 丂上丒东丟丘专业丕(float 上且专下丈下丕七丄)
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
        val_7 = 上且专下丈下丕七丄 / (val_7 / (float)this.gears);
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
    internal void 丏业丐丒丄丕丅丙丗()
    {
        float val_21;
        float val_19 = this.maxSpeed;
        if(this.isAccelerates != false)
        {
                this.isAccelerates = (this.与丂丈丙丈丏丙丑上 <= S0) ? 1 : 0;
            this.丐丁三专东世且丒丐 = 0.5f;
        }
        else
        {
                this.isAccelerates = (this.与丂丈丙丈丏丙丑上 < 0) ? 1 : 0;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.丐丁三专东世且丒丐 - val_4;
            this.丐丁三专东世且丒丐 = val_4;
        }
        
        val_19 = val_19 / (float)this.gears;
        this.与丂丈丙丈丏丙丑上 = val_4;
        val_4 = val_4 - (val_19 * ((float)this.丂上丒东丟丘专业丕(上且专下丈下丕七丄:  null)));
        val_19 = val_4 / val_19;
        float val_22 = this.pitchCurve.Evaluate(time:  val_19);
        float val_8 = this.pitchStep * ((float)this.丂上丒东丟丘专业丕(上且专下丈下丕七丄:  null));
        val_8 = val_8 + 0.5f;
        val_8 = (UnityEngine.Mathf.Lerp(a:  0f, b:  val_22, t:  this.丐丁三专东世且丒丐)) + val_8;
        this.engineAudioSource.pitch = val_8;
        float val_20 = val_8;
        bool val_9 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        if(this.engineAudioSource == null)
        {
            goto label_14;
        }
        
        if(val_9 == false)
        {
            goto label_15;
        }
        
        label_23:
        float val_23 = 10f;
        this.engineAudioSource.enabled = true;
        val_20 = val_20 / val_23;
        if(this.engineAudioSource.loop == false)
        {
            goto label_17;
        }
        
        float val_21 = 0.7f;
        val_21 = val_20 * val_21;
        val_21 = val_21 + 0.5f;
        val_22 = this.丙三丈三三专丄一丘 * (UnityEngine.Mathf.Clamp01(value:  val_21));
        float val_15 = UnityEngine.Mathf.Lerp(a:  this.engineAudioSource.volume, b:  val_22, t:  UnityEngine.Time.deltaTime + UnityEngine.Time.deltaTime);
        if(this.engineAudioSource != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_14:
        if(val_9 == true)
        {
            goto label_23;
        }
        
        label_15:
        this.engineAudioSource.enabled = false;
        this.skidAudioSource.volume = 0f;
        this.gravelSource.volume = 0f;
        this.skidAudioSource.enabled = false;
        this.gravelSource.enabled = false;
        return;
        label_17:
        label_22:
        this.engineAudioSource.volume = 1f;
        this.skidAudioSource.enabled = true;
        this.gravelSource.enabled = true;
        val_23 = val_20 + (-0.1f);
        this.skidAudioSource.volume = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_23);
        float val_17 = UnityEngine.Mathf.Lerp(a:  0.5f, b:  1f, t:  val_23);
        this.skidAudioSource.pitch = val_17;
        val_21 = 0f;
        if(val_17 >= 0)
        {
                val_21 = UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  val_20);
        }
        
        this.gravelSource.volume = val_21;
        float val_24 = 0.3f;
        val_24 = val_20 + val_24;
        this.gravelSource.pitch = val_24;
    }
    private void 丗丘与丗一丑丘下世()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.<与丕丘丌丑东丆丙丙>k__BackingField)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.<与丕丘丌丑东丆丙丙>k__BackingField.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) <= 150f)
        {
                return;
        }
        
        this.丒丘一业丙丅丕业丂 = false;
    }
    private void 世丆丅丗丗不丙世下()
    {
        HelicopterEngine val_5 = this;
        if((val_5 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.view.GetComponent<HelicopterEngineParameters>())) == false)
        {
                return;
        }
        
        float val_5 = val_1.healtInit;
        val_5 = (val_1.healtInit - V0.16B) + val_5;
        float val_4 = UnityEngine.Mathf.Min(a:  val_5, b:  val_5);
        this.engine.maxUpSpeed = val_1.maxUpSpeed;
        this.engine.maxDownSpeed = val_1.maxDownSpeed;
        this.engine.maxVerticalSpeedTime = val_1.maxVerticalSpeedTime;
        this.engine.verticalSpeedLossTime = val_1.verticalSpeedLossTime;
        this.engine.maxRotationSpeed = val_1.maxRotationSpeed;
        this.engine.maxRotationSpeedTime = val_1.maxRotationSpeedTime;
        this.engine.rotationSpeedLossTime = val_1.rotationSpeedLossTime;
        this.engine.maxForwardSpeed = val_1.maxForwardSpeed;
        this.engine.maxBackwardSpeed = val_1.maxBackwardSpeed;
        this.engine.maxHorizontalSpeedTime = val_1.maxHorizontalSpeedTime;
        val_5 = this.engine;
        this.engine.horizontalSpeedLossTime = val_1.horizontalSpeedLossTime;
    }
    internal override 丏丐丏丘下东丁丐一 丙丒丄丈丏万丛丈丛()
    {
        return 2;
    }
    internal override TransportViewBase 丑丕丛七丁丏七东上()
    {
        return (TransportViewBase)this.view;
    }
    internal override string 丐丙与七七丁七丛业()
    {
        return "helicopter_military";
    }
    internal override TransportEngineBase 丕不丆丙世世丄丌丆()
    {
        return (TransportEngineBase)this.engine;
    }
    internal override UnityEngine.GameObject[] 丑业丒丐丒世丗丒丛()
    {
        return (UnityEngine.GameObject[])this.colliders;
    }
    internal override PGCompany.业丐与丕丒下丑下丈 一丂万世丙上万世丛()
    {
        return 25;
    }
    internal override PGCompany.业丐与丕丒下丑下丈 丑世丙且丅与丌丛丁()
    {
        return 4;
    }
    internal override 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 丙丒丌专丕丒不丅东()
    {
        return 6;
    }
    internal override UnityEngine.Transform 丞丈上且丙上丘丘七()
    {
        if(this.engine != null)
        {
                return (UnityEngine.Transform)this.engine.body;
        }
        
        return (UnityEngine.Transform)this.engine.body;
    }
    internal override float 下丗丟丁丝丝三专世()
    {
        return (float)this.<丙丙万丞丟一上三丗>k__BackingField;
    }
    internal override Player_move_c[] 丝世东丙下丈丒专世()
    {
        return (Player_move_c[])this.丂丈丞东丐丁丘丒上;
    }
    internal override void 下丏且一三丐一丐不(三下丕丕七丂丕丈且 丏丂丄丆丂东丝丆丏)
    {
        if(丏丂丄丆丂东丝丆丏 == null)
        {
                return;
        }
        
        丑与且丂下不万三业 val_1 = (((三下丕丕七丂丕丈且.__il2cppRuntimeField_typeHierarchy + (丑与且丂下不万三业.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丏丂丄丆丂东丝丆丏 : 0;
    }
    internal override bool 世业丈三丒万丟不七()
    {
        return false;
    }
    internal override void 丄丈丙丗丅万上东三(bool 丝世丏丑专丄丒业丏)
    {
        var val_10;
        UnityEngine.AudioClip val_11;
        if(this.世七丁与丘下丏丗丘 != null)
        {
                this.StopCoroutine(routine:  this.世七丁与丘下丏丗丘);
        }
        
        this.engineAudioSource.volume = 1f;
        this.skidAudioSource.volume = 1f;
        if(丝世丏丑专丄丒业丏 == false)
        {
            goto label_4;
        }
        
        val_10 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        if(this.skidAudioSource != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_4:
        val_10 = 0;
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
            val_11 = this.engineStart;
            this.engineAudioSource.clip = val_11;
            this.engineAudioSource.loop = false;
            this.engineAudioSource.Play();
            System.Collections.IEnumerator val_4 = this.上与丗丄且丏丆东专();
        }
        else
        {
                this.engineAudioSource.enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            this.engineAudioSource.Stop();
            val_11 = this.engineStop;
            this.engineAudioSource.clip = val_11;
            this.engineAudioSource.loop = false;
            this.engineAudioSource.Play();
        }
        
        this.世七丁与丘下丏丗丘 = this.StartCoroutine(routine:  this.丈上丑下丒上丐丐业());
    }
    protected override void 丟丄丌万丙丘丑丆丘(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙, int 丐丟丘世丁三丕专专, int 不万上丕丅丏丆丄丝 = 0)
    {
        UnityEngine.AudioClip[] val_7;
        UnityEngine.AudioClip val_8;
        val_7 = 丐丟丘世丁三丕专专;
        if(val_7 == 1)
        {
                if((this & 1) == 0)
        {
            goto label_2;
        }
        
        }
        
        if(丛业专丘丂丅丗丝丛 <= 0f)
        {
                return;
        }
        
        丛业专丘丂丅丗丝丛 = 丛业专丘丂丅丗丝丛 - 丛业专丘丂丅丗丝丛;
        if(((丛业专丘丂丅丗丝丛 <= 0f) && (null == null)) && ((this & 1) == 0))
        {
                mem[1152921539383866392] = this.StartCoroutine(routine:  this.丝丞七丏与世丒丟三(丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙, 与丞丗丟七下丐丛且:  5f, 不万上丕丅丏丆丄丝:  不万上丕丅丏丆丄丝));
        }
        
        if(val_7 != 3)
        {
            goto label_7;
        }
        
        val_8 = this.bump;
        goto label_8;
        label_2:
        this.StopCoroutine(routine:  typeof(HelicopterController).__il2cppRuntimeField_600);
        mem[1152921539383866392] = this.StartCoroutine(routine:  this.丝丞七丏与世丒丟三(丞丗且下世丐业丌丙:  0, 与丞丗丟七下丐丛且:  0f, 不万上丕丅丏丆丄丝:  不万上丕丅丏丆丄丝));
        return;
        label_7:
        val_7 = this.hitSound;
        label_8:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.freeAudioSource.enabled = true;
        this.freeAudioSource.PlayOneShot(clip:  1152921508635189680);
    }
    protected override System.Collections.IEnumerator 丑世东一丏丄与三下(string 丂东丄丏丕丕丅上一)
    {
        HelicopterController.丕世下丛丟丙丗丅丆 val_1 = new HelicopterController.丕世下丛丟丙丗丅丆();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丂东丄丏丕丕丅上一 = 丂东丄丏丕丕丅上一;
        return (System.Collections.IEnumerator)val_1;
    }
    protected override void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_34;
        float val_35;
        Player_move_c val_36;
        var val_37;
        var val_38;
        PlayerDamageable val_39;
        float val_45;
        float val_46;
        float val_47;
        var val_48;
        int val_49;
        世不丟丂上丟与丌下 val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        UnityEngine.GameObject val_1 = 丘丛丏丘丝七世七丅.gameObject;
        val_34 = this.丞上丁丘丅三丕丒丄();
        UnityEngine.Vector3 val_3 = val_34.velocity;
        val_35 = val_3.x;
        if(val_35 <= val_3.y)
        {
                return;
        }
        
        val_36 = 1152921504848912384;
        val_34 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_34 == 0)
        {
                return;
        }
        
        val_34 = 丘丛丏丘丝七世七丅.transform.parent;
        if((val_34.CompareTag(tag:  "Player")) == false)
        {
                return;
        }
        
        val_37 = null;
        val_37 = null;
        val_34 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_34 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_34 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_14 = 丘丛丏丘丝七世七丅.transform.parent;
        if(this.photonView.isMine == false)
        {
            goto label_23;
        }
        
        val_34 = val_14.GetComponent<SkinName>();
        if(val_15.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
                return;
        }
        
        if(val_15.playerMoveC.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
                return;
        }
        
        if(val_15.playerMoveC.丅丕丁丒丗东业且丁 == true)
        {
                return;
        }
        
        if(val_15.playerMoveC.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        float val_34 = V10.16B;
        float val_16 = UnityEngine.Mathf.Clamp(value:  val_35, min:  val_34, max:  V9.16B);
        val_34 = val_34 - val_35;
        val_16 = val_16 - V9.16B;
        float val_17 = val_34 * val_16;
        val_17 = val_17 / (S3 - V9.16B);
        val_35 = val_35 + val_17;
        if(val_15.character.isGrounded == false)
        {
            goto label_38;
        }
        
        val_15.playerMoveC.丌丌七丂丏丌且专丝();
        val_38 = null;
        val_39 = val_15.playerMoveC.丂七一业下丈业丕丒;
        val_38 = null;
        UnityEngine.Vector3 val_21 = this.丌丟丄业且三丛丕丄().position;
        val_45 = val_21.x;
        val_46 = val_21.y;
        val_47 = val_21.z;
        PixelView val_22 = GetComponent<PixelView>();
        if(val_22 == null)
        {
                val_48 = val_22;
        }
        
        val_49 = val_48.viewID;
        if(val_39 == null)
        {
                val_49 = val_49;
        }
        
        val_50 = 23;
        goto label_49;
        label_23:
        val_51 = null;
        val_34 = val_14.gameObject;
        val_51 = null;
        if(val_34 != WeaponManager.丟丗丄业丘丗业丗七.myPlayer)
        {
                return;
        }
        
        val_52 = null;
        val_52 = null;
        val_34 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_34 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_53 = null;
        val_53 = null;
        val_34 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_34 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_54 = null;
        val_54 = null;
        七丟丅丗丙丈东丏丐();
        goto label_72;
        label_38:
        val_55 = null;
        val_39 = val_15.playerMoveC.丂七一业下丈业丕丒;
        val_55 = null;
        UnityEngine.Transform val_26 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_27 = val_26.position;
        val_45 = val_27.x;
        val_46 = val_27.y;
        val_47 = val_27.z;
        PixelView val_28 = GetComponent<PixelView>();
        if(val_28 == null)
        {
                val_56 = val_28;
        }
        
        val_49 = val_56.viewID;
        if(val_39 == null)
        {
                val_49 = val_49;
        }
        
        val_50 = 24;
        label_49:
        val_39.ApplyDamage(丞丈专下丈专业三丞:  val_35, 丛世一丟丞丁业丘丒:  typeof(Player_move_c).__il2cppRuntimeField_600, 专不丑且不丏东丟丅:  丘丛丏丘丝七世七丅, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_47}, 丐丟丘世丁三丕专专:  val_50, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  val_26, 丒丈丐丐丗丐专丈丏:  val_49);
        val_36 = val_15.playerMoveC;
        丛丐丒上丒丘丆丕与(万丐七下丂丂丛世丞:  (val_15.playerMoveC.丙上丗丐万丏丑丘丟 == true) ? 1 : 0, 且世与七东丕丈丗丁:  true, 世丕与丙丄丙不丄丝:  false);
        FirstPersonControlSharp.上三丈世丟业一丘丘(丐不丁专业丌七东丕:  0.2f, 丘丞丌丙上万丒上丁:  0.2f);
        label_72:
        HelicopterController.丁不丘七丞丆丝丁下 val_31 = null;
        val_34 = val_31;
        val_31 = new HelicopterController.丁不丘七丞丆丝丁下();
        if(val_34 != null)
        {
                .<丒世丐世丗丛丕丕丒>k__BackingField = 丘丛丏丘丝七世七丅;
            val_35 = UnityEngine.Time.realtimeSinceStartup;
        }
        else
        {
                mem[16] = 丘丛丏丘丝七世七丅;
            val_35 = UnityEngine.Time.realtimeSinceStartup;
        }
        
        .<丘丝丐丐专丗丛丑丗>k__BackingField = val_35;
        this.丒丗东与丙下万世下.set_Item(key:  丘丛丏丘丝七世七丅, value:  val_31);
    }
    private void OnTriggerStay(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Collider val_23;
        System.Collections.Generic.Dictionary<UnityEngine.Collider, 丁不丘七丞丆丝丁下> val_24;
        int val_25;
        float val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_32;
        float val_38;
        float val_39;
        float val_40;
        世不丟丂上丟与丌下 val_41;
        var val_42;
        val_23 = 丘丛丏丘丝七世七丅;
        丁不丘七丞丆丝丁下 val_1 = 0;
        val_24 = this.丒丗东与丙下万世下;
        if((val_24.TryGetValue(key:  val_23, value: out  val_1)) == false)
        {
                return;
        }
        
        val_25 = 1152921504848912384;
        val_24 = 11993091;
        if((UnityEngine.Object.op_Implicit(exists:  val_24)) == false)
        {
                return;
        }
        
        val_24 = val_1;
        val_26 = 6.606506E-38f;
        float val_4 = UnityEngine.Time.realtimeSinceStartup;
        float val_23 = 0.5f;
        val_23 = val_26 + val_23;
        if(val_23 >= 0)
        {
                return;
        }
        
        bool val_6 = this.photonView.isMine;
        UnityEngine.Transform val_8 = val_23.transform.parent;
        if(val_8 == null)
        {
            goto label_12;
        }
        
        if(val_6 == false)
        {
            goto label_13;
        }
        
        label_21:
        val_24 = val_8.GetComponent<SkinName>();
        if(val_9.firstPersonControl.下丅丂丘丏丟世且丐 != true)
        {
                if(val_9.playerMoveC.万丝一万丐且丌业丛 == false)
        {
            goto label_18;
        }
        
        }
        
        bool val_10 = this.丒丗东与丙下万世下.Remove(key:  val_23);
        return;
        label_12:
        if(val_6 == true)
        {
            goto label_21;
        }
        
        label_13:
        val_24 = 1152921505286238208;
        val_27 = null;
        val_27 = null;
        if(val_8.gameObject != WeaponManager.丟丗丄业丘丗业丗七.myPlayer)
        {
            goto label_44;
        }
        
        val_28 = null;
        val_28 = null;
        val_29 = null;
        val_29 = null;
        val_30 = null;
        val_30 = null;
        七丟丅丗丙丈东丏丐();
        goto label_44;
        label_18:
        if(val_9.character.isGrounded != false)
        {
                val_9.playerMoveC.丌丌七丂丏丌且专丝();
            val_24 = val_9.playerMoveC.丂七一业下丈业丕丒;
            val_32 = null;
            val_32 = null;
            UnityEngine.Vector3 val_15 = this.丌丟丄业且三丛丕丄().position;
            val_38 = val_15.x;
            val_39 = val_15.y;
            val_40 = val_15.z;
            val_25 = GetComponent<PixelView>().viewID;
            val_41 = 23;
        }
        else
        {
                val_24 = val_9.playerMoveC.丂七一业下丈业丕丒;
            val_42 = null;
            val_42 = null;
            UnityEngine.Vector3 val_19 = this.丌丟丄业且三丛丕丄().position;
            val_38 = val_19.x;
            val_39 = val_19.y;
            val_40 = val_19.z;
            val_25 = GetComponent<PixelView>().viewID;
            val_41 = 24;
        }
        
        val_24.ApplyDamage(丞丈专下丈专业三丞:  val_26, 丛世一丟丞丁业丘丒:  typeof(Player_move_c).__il2cppRuntimeField_600, 专不丑且不丏东丟丅:  val_23, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_38, y = val_39, z = val_40}, 丐丟丘世丁三丕专专:  val_41, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  this, 丒丈丐丐丗丐专丈丏:  val_25);
        label_44:
        val_23 = val_1;
        val_26 = UnityEngine.Time.realtimeSinceStartup;
        mem[24] = val_26;
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.丒丗东与丙下万世下.ContainsKey(key:  丘丛丏丘丝七世七丅)) == false)
        {
                return;
        }
        
        bool val_2 = this.丒丗东与丙下万世下.Remove(key:  丘丛丏丘丝七世七丅);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        if((丞世不丒下上上丝丑 & 255) != 26)
        {
                return this.OnEventFired(丗与一丛丐丞丘丌丞:  丞世不丒下上上丝丑, 专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        }
        
        this.丗丑丟丛丛丘三世丙();
        return true;
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
    public HelicopterController()
    {
        this.gears = 4;
        mem2[0] = 1114636288;
        this.丙三丈三三专丄一丘 = 1f;
        this.丂丈丞东丐丁丘丒上 = new Player_move_c[4];
        this.丒丘一业丙丅丕业丂 = true;
        mem2[0] = 1101004800;
        this.丒丗东与丙下万世下 = new System.Collections.Generic.Dictionary<UnityEngine.Collider, 丁不丘七丞丆丝丁下>();
    }

}
