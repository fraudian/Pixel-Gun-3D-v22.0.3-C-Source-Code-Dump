using UnityEngine;
internal abstract class TransportControllerBase : VTableHolder, 丅丙上七上一丐不下
{
    // Fields
    public UnityEngine.BoxCollider bodyCollider;
    private float distanceDetectPlayer;
    protected float 世丑丟丕七丗丄丕一;
    public float maxSpeedGetInPlayer;
    public float radiusExplosionSQR;
    public float radiusMaxExplosionSQR;
    public float damageMax;
    public float minVelocityHitPlayer;
    public float maxVelocityHitPlayer;
    public float minDamageHitPlayer;
    public float maxDamageHitPlayer;
    private float <丘且丈丏丟丞一且业>k__BackingField;
    private float <与世丂七且专丙丑业>k__BackingField;
    private float <丛丙丛不丝丙丛丘丒>k__BackingField;
    protected bool 丅丞万丄丑丞丝丘丐;
    private bool 与丅丛不不丄万丞丄;
    private FreeplayVehicleOwner 丐丂世且万丝下丆丅;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    private UnityEngine.Rigidbody 丏世一业业丄丛丗一;
    protected float 三上东丝丅丈上丌一;
    protected bool 万丁丙东东丟丅丝三;
    protected UnityEngine.Coroutine 三世丕丏万一丘丘丈;
    internal string 不丞丒下丕丙东东且;
    private bool <丘丒不业丄丛丄不一>k__BackingField;
    private string <丛丛丆一丑丒丛丞且>k__BackingField;
    private SlowdownZoneTriggerTransport <丒一东丏丁东丁东丏>k__BackingField;
    private float 丗丛丁丕丒丄丒丕一;
    protected UnityEngine.Coroutine 万丄丂丙丅丒丏丁丕;
    protected bool 世丏丅丂丅丗一丗万;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    internal abstract 丏丐丏丘下东丁丐一 丏丐丏丘下东丁丐一 { get; }
    internal abstract TransportViewBase 世丆丝七丆业三不丕 { get; }
    internal abstract string 上丂一丙丗丟丛丅丑 { get; }
    internal abstract TransportEngineBase 一世业与世丅下丗丕 { get; }
    internal abstract UnityEngine.GameObject[] 一丌丒东丘且丛东不 { get; }
    internal abstract PGCompany.业丐与丕丒下丑下丈 七一丄丞丕丆不丘丗 { get; }
    internal abstract PGCompany.业丐与丕丒下丑下丈 丞三东丅丙七业丅上 { get; }
    internal abstract 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 且业且丙上三与东丕 { get; }
    internal abstract UnityEngine.Transform 丙三丞丌下丞七业一 { get; }
    internal virtual float 万丄丅不丈丈丕业丘 { get; set; }
    internal virtual float 不丞丞丆世万且丒一 { get; set; }
    internal virtual float 与丏丅丝丙一业丕三 { get; set; }
    internal virtual float 万三丒与三上业丆三 { get; }
    internal virtual bool 丑丒万丂丙丌世丂丒 { get; set; }
    internal FreeplayVehicleOwner 上丈丑丟丙丕万丑三 { get; }
    internal abstract float 三丝丟丙丂丆丘不丝 { get; }
    internal abstract Player_move_c[] 专专上丒七丙上丅三 { get; }
    protected UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    protected UnityEngine.Rigidbody 下七丛与丅丝丞丟丌 { get; }
    internal bool 丒东一丙万且上丂丌 { get; set; }
    internal string 丗且丙丟一不丌丟丑 { get; set; }
    internal SlowdownZoneTriggerTransport 世一丟丄丗丌丅与上 { get; set; }
    public virtual bool 丁丙世丕丐丕丞丈丂 { get; }
    public virtual float 丟丆丆丝东世一丒丐 { get; }
    public virtual int 丗且丗丞丝丄世上一 { get; set; }
    
    // Methods
    internal abstract 丏丐丏丘下东丁丐一 丙丒丄丈丏万丛丈丛(); // 0
    internal abstract TransportViewBase 丑丕丛七丁丏七东上(); // 0
    internal abstract string 丐丙与七七丁七丛业(); // 0
    internal abstract TransportEngineBase 丕不丆丙世世丄丌丆(); // 0
    internal abstract UnityEngine.GameObject[] 丑业丒丐丒世丗丒丛(); // 0
    internal abstract PGCompany.业丐与丕丒下丑下丈 一丂万世丙上万世丛(); // 0
    internal abstract PGCompany.业丐与丕丒下丑下丈 丑世丙且丅与丌丛丁(); // 0
    internal abstract 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 丙丒丌专丕丒不丅东(); // 0
    internal abstract UnityEngine.Transform 丞丈上且丙上丘丘七(); // 0
    internal virtual float 万丞丆丌世丝丞丆上()
    {
        return (float)this.<丘且丈丏丟丞一且业>k__BackingField;
    }
    internal virtual void 丗丕三下丈丅东丟上(float 丙业与丙丗丝不丈东)
    {
        this.<丘且丈丏丟丞一且业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal virtual float 东东七丄丛丄丌不丅()
    {
        return (float)this.<与世丂七且专丙丑业>k__BackingField;
    }
    internal virtual void 丒不万三业丒不七丟(float 丙业与丙丗丝不丈东)
    {
        this.<与世丂七且专丙丑业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal virtual float 丌丅三三东且丛万一()
    {
        return (float)this.<丛丙丛不丝丙丛丘丒>k__BackingField;
    }
    internal virtual void 丑丂万丐丞丌业万一(float 丙业与丙丗丝不丈东)
    {
        this.<丛丙丛不丝丙丛丘丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal virtual float 专一丟丏且丆丕丝七()
    {
        goto typeof(TransportControllerBase).__il2cppRuntimeField_2A8;
    }
    internal virtual bool 丑丒丙与不丆三丏丌()
    {
        return (bool)this.与丅丛不不丄万丞丄;
    }
    internal virtual void 丈不万专世丒丆丗丆(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.与丅丛不不丄万丞丄 == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.与丅丛不不丄万丞丄 = 丙业与丙丗丝不丈东;
        this.七上不且且丑丂丟东().isKinematic = (this.与丅丛不不丄万丞丄 == false) ? 1 : 0;
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        object[] val_8 = new object[1];
        this = this.与丅丛不不丄万丞丄;
        val_8[0] = this;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  133, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_8);
    }
    internal FreeplayVehicleOwner 万东丂七东丁与业东()
    {
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return (FreeplayVehicleOwner)this.丐丂世且万丝下丆丅;
        }
        
        if(this.丐丂世且万丝下丆丅 != 0)
        {
                return (FreeplayVehicleOwner)this.丐丂世且万丝下丆丅;
        }
        
        this.丐丂世且万丝下丆丅 = this.gameObject.GetComponent<FreeplayVehicleOwner>();
        return (FreeplayVehicleOwner)this.丐丂世且万丝下丆丅;
    }
    internal abstract float 下丗丟丁丝丝三专世(); // 0
    internal abstract Player_move_c[] 丝世东丙下丈丒专世(); // 0
    protected UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.专专丏下丐丂丂丅东)) != false)
        {
                val_3 = this.专专丏下丐丂丂丅东;
            return val_2;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        this.专专丏下丐丂丂丅东 = val_2;
        return val_2;
    }
    protected UnityEngine.Rigidbody 丞上丁丘丅三丕丒丄()
    {
        UnityEngine.Rigidbody val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.丏世一业业丄丛丗一)) != false)
        {
                val_3 = this.丏世一业业丄丛丗一;
            return val_2;
        }
        
        UnityEngine.Rigidbody val_2 = this.GetComponent<UnityEngine.Rigidbody>();
        this.丏世一业业丄丛丗一 = val_2;
        return val_2;
    }
    internal bool 不丐一丙丏丑丑丗一()
    {
        return (bool)this.<丘丒不业丄丛丄不一>k__BackingField;
    }
    private void 丘丆丄且上东与丅丐(bool 丙业与丙丗丝不丈东)
    {
        this.<丘丒不业丄丛丄不一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丛丈丁丑丐业上七丙()
    {
        return (string)this.<丛丛丆一丑丒丛丞且>k__BackingField;
    }
    private void 丁丄业丟下下丙专丞(string 丙业与丙丗丝不丈东)
    {
        this.<丛丛丆一丑丒丛丞且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal SlowdownZoneTriggerTransport 且丏丄丒丟丅丟丗丂()
    {
        return (SlowdownZoneTriggerTransport)this.<丒一东丏丁东丁东丏>k__BackingField;
    }
    private void 丞丛下丏丘业丙一丐(SlowdownZoneTriggerTransport 丙业与丙丗丝不丈东)
    {
        this.<丒一东丏丁东丁东丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal TransportControllerBase()
    {
        this.distanceDetectPlayer = 5f;
        this.maxSpeedGetInPlayer = ;
        this.radiusExplosionSQR = ;
        this.radiusMaxExplosionSQR = 25f;
        this.damageMax = 200f;
        this.<与世丂七且专丙丑业>k__BackingField = 400f;
        this.<丛丙丛不丝丙丛丘丒>k__BackingField = 1f;
        this.minVelocityHitPlayer = ;
        this.maxVelocityHitPlayer = ;
        this.minDamageHitPlayer = 5f;
        this.maxDamageHitPlayer = 50f;
        this.不丞丒下丕丙东东且 = System.String.alignConst;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        System.Action<与丅丕丈丘东丝世丟> val_2 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  typeof(TransportControllerBase).__il2cppRuntimeField_350);
        val_1.专不丐一丈丌丛丁丕 = null;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.丐丕丁丞丑丙丅丐丈 = new System.Action<System.Object[]>(object:  this, method:  typeof(TransportControllerBase).__il2cppRuntimeField_340);
        Rilisoft.且三与世丁丏丂丌下 val_5 = this.与丑丌丌丌丁丌不丕();
        val_5.丈万丄与丈三丏丙丂 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  typeof(TransportControllerBase).__il2cppRuntimeField_360);
    }
    internal virtual void 丐丕丁丞丑丙丅丐丈(object[] 丈三丞丐丅三丟上丝)
    {
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = 丈三丞丐丅三丟上丝.Length;
        if(val_7 == 0)
        {
                val_7 = 丈三丞丐丅三丟上丝.Length;
        }
        
        if(val_7 <= 1)
        {
                val_7 = 丈三丞丐丅三丟上丝.Length;
        }
        
        val_8 = 0;
        if( != this.photonView)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if((this & 1) == 0)
        {
                return;
        }
        
        if((this & 1) == 0)
        {
            goto typeof(TransportControllerBase).__il2cppRuntimeField_308;
        }
    
    }
    internal virtual void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        string val_29;
        object val_30;
        var val_31;
        object val_32;
        val_29 = this.photonView;
        if(val_29.isMine == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.不丞丒下丕丙东东且, b:  this)) != false)
        {
                object[] val_5 = new object[1];
            val_5[0] = this.不丞丒下丕丙东东且;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  121, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_5);
        }
        
        val_30 = 0;
        goto label_9;
        label_33:
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg != 0)
        {
                object[] val_8 = new object[3];
            if(val_8 != null)
        {
            
        }
        
            val_8[0] = TransportControllerBase.__il2cppRuntimeField_byval_arg + 952 + 32;
            val_8[1] = val_30;
            val_8[2] = true;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  19, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_8);
        }
        
        val_30 = 1;
        label_9:
        if(val_30 < null)
        {
            goto label_33;
        }
        
        int val_10 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(this.万东丂七东丁与业东() != 0)
        {
                object[] val_14 = new object[1];
            val_14[0] = this.万东丂七东丁与业东().丂丞东丞万万丒丑丆();
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  235, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_14);
        }
        
        object[] val_18 = new object[3];
        val_18[0] = ???;
        if((this & 1) != 0)
        {
                val_31 = 1;
        }
        
        val_18[1] = (this.万丄丂丙丅丒丏丁丕 != 0) ? 1 : 0;
        val_18[2] = ???;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_18);
        val_29 = this.photonView;
        object[] val_21 = new object[1];
        val_32 = this.<丘丒不业丄丛丄不一>k__BackingField;
        val_21[0] = val_32;
        val_29.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  234, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_21);
        if((this.<丘丒不业丄丛丄不一>k__BackingField) == false)
        {
                return;
        }
        
        object[] val_23 = new object[1];
        val_32 = this.<丛丛丆一丑丒丛丞且>k__BackingField;
        val_23[0] = val_32;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  83, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_23);
        val_29 = this.<丛丛丆一丑丒丛丞且>k__BackingField;
        if((System.String.op_Inequality(a:  val_29, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_28 = this.StartCoroutine(routine:  this.丂东业丆丝不丙世丐(丄丆丏丙丁与丙世丆:  专丞上七七且丝七丗.业丐丐三丕一丗丛丁()));
    }
    internal virtual void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        if(this.万东丂七东丁与业东() == 0)
        {
                return;
        }
        
        if(this.万东丂七东丁与业东().丈丆下丛万业丏丗丝() == true)
        {
                return;
        }
        
        if((this.万东丂七东丁与业东().丏东不世丝丗丅丙丁(丞丅上丏丂且下丅与:  专丞上七七且丝七丗.业丐丐三丕一丗丛丁())) == false)
        {
                return;
        }
        
        if((this.<丘丒不业丄丛丄不一>k__BackingField) != false)
        {
                this.丗丛丁丕丒丄丒丕一 = UnityEngine.Time.realtimeSinceStartup;
        }
    
    }
    protected virtual void Awake()
    {
        this.专专丏下丐丂丂丅东 = this.transform;
        this.丏世一业业丄丛丗一 = this.GetComponent<UnityEngine.Rigidbody>();
        float val_4 = this.distanceDetectPlayer;
        val_4 = val_4 * val_4;
        this.世丑丟丕七丗丄丕一 = val_4;
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.丌丟丄业且三丛丕丄(), 专丐丛丆与专世丆丂:  this);
    }
    protected virtual void Start()
    {
        if((System.String.IsNullOrEmpty(value:  this.不丞丒下丕丙东东且)) == false)
        {
                return;
        }
        
        goto typeof(TransportControllerBase).__il2cppRuntimeField_538;
    }
    protected virtual void Update()
    {
        var val_13;
        var val_14;
        if((this & 1) != 0)
        {
                if(this.photonView.owner == null)
        {
                if(this.丅丞万丄丑丞丝丘丐 == false)
        {
            goto label_4;
        }
        
        }
        
        }
        
        if((GameConnect.且丘丄丛下丆丟万丕() == false) || (this.photonView.owner == null))
        {
            goto label_9;
        }
        
        goto label_10;
        label_4:
        label_10:
        label_9:
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        if((this & 1) == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_14 = null;
            val_14 = null;
            if((this & 1) != 0)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_10 = this.七上不且且丑丂丟东().velocity;
        if(val_10.x < 0)
        {
                float val_11 = UnityEngine.Time.deltaTime;
            val_11 = this.三上东丝丅丈上丌一 + val_11;
            this.三上东丝丅丈上丌一 = val_11;
            if(val_11 <= 3f)
        {
                return;
        }
        
            return;
        }
        
        this.三上东丝丅丈上丌一 = 0f;
    }
    protected void 丆下世丌丌丅七东万()
    {
        int val_16;
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        if(this.万东丂七东丁与业东() == 0)
        {
                return;
        }
        
        if(this.万东丂七东丁与业东().丈丆下丛万业丏丗丝() == true)
        {
                return;
        }
        
        val_16 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if((this.万东丂七东丁与业东().丏东不世丝丗丅丙丁(丞丅上丏丂且下丅与:  val_16)) == true)
        {
                return;
        }
        
        if((this.<丘丒不业丄丛丄不一>k__BackingField) != false)
        {
                if(this.丗丛丁丕丒丄丒丕一 == 0f)
        {
                return;
        }
        
            float val_12 = UnityEngine.Time.realtimeSinceStartup;
            val_12 = val_12 - this.丗丛丁丕丒丄丒丕一;
            if(val_12 > 20f)
        {
            goto typeof(TransportControllerBase).__il2cppRuntimeField_568;
        }
        
            if((this.<丘丒不业丄丛丄不一>k__BackingField) == true)
        {
                return;
        }
        
        }
        
        System.Predicate<与丅丕丈丘东丝世丟> val_14 = null;
        val_16 = val_14;
        val_14 = new System.Predicate<与丅丕丈丘东丝世丟>(object:  this, method:  System.Boolean TransportControllerBase::世三且丞七丌丙与丒(与丅丕丈丘东丝世丟 丕不万丒丅业三且三));
        if((System.Array.FindIndex<与丅丕丈丘东丝世丟>(array:  丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁(), match:  val_14)) == 1)
        {
            goto typeof(TransportControllerBase).__il2cppRuntimeField_568;
        }
    
    }
    protected virtual void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.丌丟丄业且三丛丕丄(), 专丐丛丆与专世丆丂:  this);
        goto typeof(TransportControllerBase).__il2cppRuntimeField_4A8;
    }
    internal virtual bool 丞丟丗丛丘七丄丟丑()
    {
        return UnityEngine.Object.op_Inequality(x:  this, y:  0);
    }
    internal virtual bool 丞丐不且三丞万丒与(Player_move_c 专丞上七七且丝七丗)
    {
        return UnityEngine.Object.op_Equality(x:  this, y:  专丞上七七且丝七丗);
    }
    internal virtual Player_move_c 且丛丄丗丞一丈丕丙()
    {
        if(null != null)
        {
                return (Player_move_c)this;
        }
        
        return (Player_move_c)this;
    }
    internal virtual UnityEngine.Vector3 丂丝丛七丈上丈世一(int 丛丆专丐丁丈丟丏丈)
    {
        UnityEngine.Object val_5 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        float val_2 = this.minVelocityHitPlayer + (((long)(int)(丛丆专丐丁丈丟丏丈)) << 3);
        val_5 = mem[(this.minVelocityHitPlayer + ((long)(int)(丛丆专丐丁丈丟丏丈)) << 3) + 32];
        val_5 = (this.minVelocityHitPlayer + ((long)(int)(丛丆专丐丁丈丟丏丈)) << 3) + 32;
        if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        float val_4 = this.minVelocityHitPlayer + (((long)(int)(丛丆专丐丁丈丟丏丈)) << 3);
        if(((this.minVelocityHitPlayer + ((long)(int)(丛丆专丐丁丈丟丏丈)) << 3) + 32) != 0)
        {
                return (this.minVelocityHitPlayer + ((long)(int)(丛丆专丐丁丈丟丏丈)) << 3) + 32.localPosition;
        }
        
        return (this.minVelocityHitPlayer + ((long)(int)(丛丆专丐丁丈丟丏丈)) << 3) + 32.localPosition;
    }
    internal virtual int 丄丗丄丏丐丐三一上(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        var val_10;
        var val_11;
        if(this == 0)
        {
                val_10 = 0;
            return (int)(val_7 != val_6) ? (val_11) : (val_10);
        }
        
        val_10 = 0;
        val_11 = 1;
        goto label_7;
        label_19:
        float val_2 = this.minVelocityHitPlayer + 8;
        UnityEngine.Vector3 val_3 = (this.minVelocityHitPlayer + 8) + 32.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
        float val_5 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        bool val_6 = UnityEngine.Object.op_Equality(x:  this.bodyCollider, y:  0);
        var val_7 = (val_5 < 0) ? 1 : 0;
        var val_8 = (val_7 != val_6) ? (val_5) : 3.402823E+38f;
        val_11 = 2;
        label_7:
        if(val_11 < null)
        {
            goto label_19;
        }
        
        return (int)(val_7 != val_6) ? (val_11) : (val_10);
    }
    internal virtual void 七东丗丂世三七丞丌(int 丞丅上丏丂且下丅与, int 与丈丂丂一丁业丂上, bool 丅丏丟一不丛丝丟丗, bool 丛丑丘不世七丛且丙)
    {
        Player_move_c val_7;
        var val_8;
        var val_9;
        val_7 = 丛丑丘不世七丛且丙;
        object[] val_4 = new object[3];
        val_4[0] = 丞丅上丏丂且下丅与;
        val_4[1] = 与丈丂丂一丁业丂上;
        val_4[2] = 丅丏丟一不丛丝丟丗;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  19, 丞下万上三丘上与专:  (GameConnect.且丘丄丛下丆丟万丕() != true) ? 0 : 5, 丗丟上上丒丐丗丞丙:  val_4);
        if(val_7 == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_7 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_7 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_7.丏丞丙丒丗与且丗丕(东三丈下丌丑丂世丛:  false);
    }
    internal virtual UnityEngine.Vector3 七丗下丆不丐丑丆丐(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        UnityEngine.Transform val_27;
        var val_28;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint>>();
        val_23 = 0;
        goto label_1;
        label_15:
        float val_2 = this.minDamageHitPlayer + 0;
        UnityEngine.Vector3 val_3 = (this.minDamageHitPlayer + 0) + 32 + 24.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
        float val_5 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_6 = this.minDamageHitPlayer + 0;
        val_1.Add(item:  new System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint>());
        val_23 = 1;
        label_1:
        if(val_23 < (this.minDamageHitPlayer + 24))
        {
            goto label_15;
        }
        
        val_1.Sort(comparison:  new System.Comparison<System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint>>(object:  this, method:  typeof(TransportControllerBase).__il2cppRuntimeField_420));
        val_24 = 0;
        goto label_17;
        label_22:
        System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint> val_8 = val_1.Item[0];
        val_25 = ;
        if((val_8.Value.IsFree(三丒丐丟世丈丆丗丑:  this.bodyCollider)) == true)
        {
            goto label_20;
        }
        
        val_24 = 1;
        label_17:
        if(val_24 < val_1.Count)
        {
            goto label_22;
        }
        
        val_25 = 0;
        goto label_23;
        label_31:
        float val_11 = (this.<丘且丈丏丟丞一且业>k__BackingField) + 0;
        val_26 = mem[(this.<丘且丈丏丟丞一且业>k__BackingField + 0) + 32];
        val_26 = (this.<丘且丈丏丟丞一且业>k__BackingField + 0) + 32;
        if((val_26.IsFree(三丒丐丟世丈丆丗丑:  this.bodyCollider)) == true)
        {
            goto label_28;
        }
        
        val_25 = 1;
        label_23:
        if(val_25 < (this.<丘且丈丏丟丞一且业>k__BackingField + 24))
        {
            goto label_31;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_34;
        }
        
        val_26 = 1152921505191723008;
        System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint> val_14 = val_1.Item[0];
        UnityEngine.Vector3 val_15 = 0.position;
        FreeplayModeSpawnController.丆丕丝丒不丙且丐丗.七三且丒丏丂丌丌丁(丗丕上业丑业丆且丆:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        PlayerSpawnPoint val_16 = FreeplayModeSpawnController.丆丕丝丒不丙且丐丗.万专万三丏万丌丞且(丕丅不业专丑丁上丅:  false);
        val_27 = val_16.万东万丆专丌丕丐丗;
        if(val_27 != null)
        {
            goto label_50;
        }
        
        goto label_42;
        label_20:
        System.Collections.Generic.KeyValuePair<System.Single, VehicleLandingPoint> val_17 = val_1.Item[0];
        val_28 = ;
        if(val_17.Value != 0)
        {
            goto label_49;
        }
        
        goto label_45;
        label_28:
        float val_18 = (this.<丘且丈丏丟丞一且业>k__BackingField) + 0;
        val_28 = mem[(this.<丘且丈丏丟丞一且业>k__BackingField + 0) + 32];
        val_28 = (this.<丘且丈丏丟丞一且业>k__BackingField + 0) + 32;
        if(val_28 != 0)
        {
            goto label_49;
        }
        
        label_45:
        label_49:
        val_27 = mem[(this.<丘且丈丏丟丞一且业>k__BackingField + 0) + 32 + 24];
        val_27 = (this.<丘且丈丏丟丞一且业>k__BackingField + 0) + 32 + 24;
        if(val_27 != 0)
        {
            goto label_50;
        }
        
        label_42:
        label_50:
        UnityEngine.Vector3 val_19 = val_27.position;
        return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        label_34:
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  3f);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
    }
    internal virtual int 丑丈丕丌丟下上丂丐(System.Collections.Generic.KeyValuePair<float, VehicleLandingPoint> 丏丆丑丗七丄丙丝与, System.Collections.Generic.KeyValuePair<float, VehicleLandingPoint> 丒丈丙丐丏丕丆万丗)
    {
        var val_6;
        if(丏丆丑丗七丄丙丝与.Value.x == (???.x))
        {
                val_6 = 0;
            return (int)(丏丆丑丗七丄丙丝与.Value.x < 0) ? 0 : (0 + 1);
        }
        
        float val_4 = ???.x;
        return (int)(丏丆丑丗七丄丙丝与.Value.x < 0) ? 0 : (0 + 1);
    }
    internal virtual void 万丐东三与丆东丏上()
    {
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  26, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    internal virtual int 丂一丏丛东专丄丞丛(int 丟丝丏丄东丁丕丅丙)
    {
        var val_5;
        do
        {
            int val_1 = 丟丝丏丄东丁丕丅丙 + 1;
            if(this == 0)
        {
                return (int)val_5;
        }
        
        }
        while(((val_1 == typeof(TransportControllerBase).__il2cppRuntimeField_328) ? 0 : (val_1)) != 丟丝丏丄东丁丕丅丙);
        
        val_5 = 0;
        return (int)val_5;
    }
    internal abstract void 下丏且一三丐一丐不(三下丕丕七丂丕丈且 丏丂丄丆丂东丝丆丏); // 0
    internal abstract bool 世业丈三丒万丟不七(); // 0
    internal abstract void 丄丈丙丗丅万上东三(bool 丝世丏丑专丄丒业丏); // 0
    protected abstract void 丟丄丌万丙丘丑丆丘(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙, int 丐丟丘世丁三丕专专, int 不万上丕丅丏丆丄丝 = 0); // 0
    internal bool 丟丝且丛业丆丈三丈()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        label_7:
        if(val_2 >= null)
        {
            goto label_2;
        }
        
        val_2 = val_2 + 1;
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg != 0)
        {
            goto label_7;
        }
        
        val_3 = 1;
        return (bool)val_3;
        label_2:
        val_3 = 0;
        return (bool)val_3;
    }
    protected virtual void 下丞丙丂丌丁专丛丙()
    {
        UnityEngine.Object val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        float val_21;
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_16 = this;
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_19 = null;
        UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
        val_20 = null;
        val_21 = val_3.z;
        val_20 = null;
        UnityEngine.Vector3 val_4 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_22 = val_4.y;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_21}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_22, z = val_4.z});
        float val_6 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if((val_6 > 0f) && (((this.丟丝且丛业丆丈三丈() != false) && (val_6 < 0)) && (this.世丑丟丕七丗丄丕一 < 0)))
        {
                val_23 = null;
            val_23 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) == this)
        {
                return;
        }
        
            val_24 = null;
            val_24 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) != 0)
        {
                val_25 = null;
            val_25 = null;
            UnityEngine.Vector3 val_11 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224.transform.position;
            val_21 = val_11.y;
            UnityEngine.Vector3 val_12 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            val_22 = val_12.x;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_21, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_12.y, z = val_12.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) <= val_6)
        {
                return;
        }
        
        }
        
            val_26 = null;
            val_26 = null;
            mem2[0] = val_16;
            return;
        }
        
        val_27 = null;
        val_27 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) != this)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        val_16 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_16 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        mem2[0] = 0;
    }
    protected virtual void 东丈丗不丌丂世万丐()
    {
        var val_3;
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
                return;
        }
        
        val_3 = 0;
        goto label_4;
        label_17:
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg != 0)
        {
                typeof(TransportControllerBase).__il2cppRuntimeField_20 = 0;
        }
        
        val_3 = 1;
        label_4:
        if(val_3 < null)
        {
            goto label_17;
        }
    
    }
    protected virtual void 丛丟丄东东丆七丁丐()
    {
        var val_13;
        InGameGUI val_14;
        val_13 = 0;
        goto label_1;
        label_34:
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg != 0)
        {
                typeof(TransportControllerBase).__il2cppRuntimeField_20 = 0;
            val_14 = mem[TransportControllerBase.__il2cppRuntimeField_byval_arg + 1576 + 456];
            val_14 = TransportControllerBase.__il2cppRuntimeField_byval_arg + 1576 + 456;
            val_14.丏丞丙丒丗与且丗丕(东三丈下丌丑丂世丛:  true);
            if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                val_14 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_14 != 0)
        {
                val_14 = this.万东丂七东丁与业东();
            if(((val_14 != 0) && (TransportControllerBase.__il2cppRuntimeField_byval_arg.丟丌下三七丁与丟丑() != false)) && (this.万东丂七东丁与业东().丈丆下丛万业丏丗丝() != true))
        {
                val_14 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
            if((this.万东丂七东丁与业东().丏东不世丝丗丅丙丁(丞丅上丏丂且下丅与:  val_14)) != true)
        {
                专不上丌丈丗丑不七();
        }
        
        }
        
        }
        
        }
        
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < null)
        {
            goto label_34;
        }
    
    }
    protected virtual void 丄世万丘上七丛三万()
    {
        if(this.万丄丂丙丅丒丏丁丕 != null)
        {
                this.StopCoroutine(routine:  this.万丄丂丙丅丒丏丁丕);
            this.万丄丂丙丅丒丏丁丕 = 0;
        }
        
        this.万丄丂丙丅丒丏丁丕 = 0;
        this.万丁丙东东丟丅丝三 = true;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this, y:  0);
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg.RemoveMiniMapIcon(业丟丏上丛与不一丝:  this.gameObject);
    }
    protected virtual void 丘丘业丁一与丅丛丗(丅丙上七上一丐不下 丆丝专专丟丟丈丏丐)
    {
        丅丙上七上一丐不下 val_12;
        UnityEngine.Object val_13;
        var val_14;
        Player_move_c val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        float val_24;
        float val_25;
        世不丟丂上丟与丌下 val_26;
        丏专丐且丘丌丛不丁 val_27;
        丅丙上七上一丐不下 val_28;
        UnityEngine.Collider val_29;
        var val_30;
        float val_31;
        float val_32;
        float val_33;
        var val_34;
        val_12 = 丆丝专专丟丟丈丏丐;
        val_13 = this;
        val_14 = null;
        val_14 = null;
        val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_15 == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_17 = null;
        val_17 = null;
        val_18 = null;
        val_18 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224) == this)
        {
                if(val_12 == null)
        {
                val_19 = null;
            val_19 = null;
            val_12 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  typeof(Player_move_c).__il2cppRuntimeField_378);
        }
        
            val_20 = null;
            val_20 = null;
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            val_13 = this.不丞丒下丕丙东东且;
            val_24 = val_5.x;
            val_25 = val_5.z;
            val_26 = 3;
            val_27 = 1;
            val_28 = val_12;
            val_29 = 0;
        }
        else
        {
                val_30 = null;
            val_30 = null;
            UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            val_24 = val_6.x;
            val_25 = val_6.z;
            val_15 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_8 = val_15.position;
            val_31 = val_24;
            val_32 = val_25;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31, y = val_6.y, z = val_32}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_33 = this.radiusMaxExplosionSQR;
            if(val_9.x >= 0)
        {
                return;
        }
        
            val_24 = this.damageMax;
            if(val_9.x > val_33)
        {
                val_32 = this.radiusExplosionSQR;
            val_9.x = val_9.x - val_33;
            val_9.x = val_32 - val_9.x;
            val_33 = val_32 - val_33;
            val_31 = val_9.x / val_33;
            val_24 = val_24 * val_31;
        }
        
            val_34 = null;
            val_34 = null;
            UnityEngine.Vector3 val_11 = this.丌丟丄业且三丛丕丄().position;
            val_13 = this.不丞丒下丕丙东东且;
            val_25 = val_11.y;
            val_26 = 3;
            val_27 = 1;
            val_28 = val_12;
            val_29 = 0;
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_600.ApplyDamage(丞丈专下丈专业三丞:  val_24, 丛世一丟丞丁业丘丒:  val_28, 专不丑且不丏东丟丅:  val_29, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_11.x, y = val_25, z = val_11.z}, 丐丟丘世丁三丕专专:  val_26, 东丏业丞丞业下丄世:  val_27, 丝三丛且丘不丌丙下:  val_13, 丒丈丐丐丗丐专丈丏:  0);
    }
    internal virtual bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_12;
        int val_13;
        object val_14;
        var val_15;
        var val_16;
        int val_17;
        val_12 = 丗与一丛丐丞丘丌丞;
        byte val_1 = val_12 & 255;
        if(val_1 > 83)
        {
            goto label_1;
        }
        
        if(val_1 > 19)
        {
            goto label_2;
        }
        
        byte val_2 = val_12 & 255;
        if(val_2 == 18)
        {
            goto label_57;
        }
        
        if(val_2 != 19)
        {
            goto label_24;
        }
        
        val_13 = 专丒丌丆下丐丞丟丞.Length;
        if(val_13 == 0)
        {
                val_13 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_12 = 专丒丌丆下丐丞丟丞[0];
        if(val_13 <= 1)
        {
                val_13 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_13 = 专丒丌丆下丐丞丟丞[1];
        val_14 = 1152921504622075904;
        bool val_4 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[2]);
        goto label_57;
        label_1:
        if(val_1 > 121)
        {
            goto label_12;
        }
        
        byte val_5 = val_12 & 255;
        if(val_5 == 119)
        {
            goto label_13;
        }
        
        if(val_5 != 121)
        {
            goto label_24;
        }
        
        if(专丒丌丆下丐丞丟丞[0] != null)
        {
            goto label_57;
        }
        
        goto label_57;
        label_2:
        byte val_6 = val_12 & 255;
        if(val_6 == 24)
        {
            goto label_19;
        }
        
        if(val_6 != 83)
        {
            goto label_24;
        }
        
        this.世三下丄丒三上丏丟(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        goto label_57;
        label_12:
        byte val_7 = val_12 & 255;
        if(val_7 == 235)
        {
            goto label_22;
        }
        
        if(val_7 == 234)
        {
            goto label_23;
        }
        
        if(val_7 != 133)
        {
            goto label_24;
        }
        
        object val_16 = 专丒丌丆下丐丞丟丞[0];
        goto label_57;
        label_24:
        val_15 = 0;
        return (bool)val_15;
        label_13:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_30;
        }
        
        val_14 = 专丒丌丆下丐丞丟丞;
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_54;
        }
        
        label_55:
        label_54:
        val_12 = 专丒丌丆下丐丞丟丞[0];
        object val_17 = 专丒丌丆下丐丞丟丞[1];
        if(专丒丌丆下丐丞丟丞.Length >= 3)
        {
            goto label_34;
        }
        
        bool val_9 = System.Convert.ToBoolean(value:  val_17);
        goto label_57;
        label_19:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_38;
        }
        
        val_16 = 专丒丌丆下丐丞丟丞;
        val_17 = 专丒丌丆下丐丞丟丞.Length;
        if(val_17 != 4)
        {
            goto label_39;
        }
        
        label_56:
        object val_18 = 专丒丌丆下丐丞丟丞[0];
        object val_19 = 专丒丌丆下丐丞丟丞[1];
        val_14 = 专丒丌丆下丐丞丟丞[2];
        object val_20 = 专丒丌丆下丐丞丟丞[3];
        goto label_47;
        label_22:
        this.东业丂丄东丞丐丒丐(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        goto label_57;
        label_23:
        this.一丕上丆三丙丏丟下(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        goto label_57;
        label_34:
        object val_21 = 专丒丌丆下丐丞丟丞[2];
        val_14 = 1152921504624205824;
        bool val_11 = System.Convert.ToBoolean(value:  val_17);
        goto label_57;
        label_30:
        if(28563616 != 0)
        {
            goto label_54;
        }
        
        goto label_55;
        label_38:
        val_16 = 24;
        val_12 = 28563616;
        val_17 = 28563616;
        if(val_12 == 4)
        {
            goto label_56;
        }
        
        label_39:
        if(val_17 != 3)
        {
            goto label_57;
        }
        
        object val_22 = 专丒丌丆下丐丞丟丞[0];
        object val_23 = 专丒丌丆下丐丞丟丞[1];
        object val_24 = 专丒丌丆下丐丞丟丞[2];
        val_14 = 1152921504622075904;
        label_47:
        label_57:
        val_15 = 1;
        return (bool)val_15;
    }
    protected virtual void 丈世丒丐丛丘东业丐(int 丞丅上丏丂且下丅与, int 丝一东丄丕丁不一丕, bool 丅丏丟一不丛丝丟丗)
    {
        bool val_1 = 丅丏丟一不丛丝丟丗;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this);
    }
    protected virtual System.Collections.IEnumerator 万丘丏世丑专丏专且(int 丞丅上丏丂且下丅与, int 丝一东丄丕丁不一丕, bool 丅丏丟一不丛丝丟丗)
    {
        TransportControllerBase.丈上东丘不丝丙丌不 val_1 = new TransportControllerBase.丈上东丘不丝丙丌不(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
            .丝一东丄丕丁不一丕 = 丝一东丄丕丁不一丕;
        }
        else
        {
                mem[40] = this;
            mem[32] = 丞丅上丏丂且下丅与;
            .丝一东丄丕丁不一丕 = 丝一东丄丕丁不一丕;
        }
        
        .丅丏丟一不丛丝丟丗 = 丅丏丟一不丛丝丟丗;
        return (System.Collections.IEnumerator)val_1;
    }
    protected virtual void 丁丌一不丗丕丘业东()
    {
    
    }
    protected virtual void 丄丘不丌丝一丈世丘(bool 丘下丕下万专七丂上)
    {
        bool val_1 = 丘下丕下万专七丂上;
        goto typeof(TransportControllerBase).__il2cppRuntimeField_308;
    }
    internal virtual void 七下丁且丗上七上三(string 丂东丄丏丕丕丅上一)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丂东丄丏丕丕丅上一 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丂东丄丏丕丕丅上一 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丂东丄丏丕丕丅上一;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  121, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
    }
    protected virtual void 世下下万丏一丂丂丗(string 丂东丄丏丕丕丅上一)
    {
        if((System.String.op_Equality(a:  this.不丞丒下丕丙东东且, b:  丂东丄丏丕丕丅上一)) == true)
        {
                return;
        }
        
        if(this.三世丕丏万一丘丘丈 != null)
        {
                this.StopCoroutine(routine:  this.三世丕丏万一丘丘丈);
        }
        
        this.三世丕丏万一丘丘丈 = this.StartCoroutine(routine:  this);
    }
    protected abstract System.Collections.IEnumerator 丑世东一丏丄与三下(string 丂东丄丏丕丕丅上一); // 0
    protected virtual void 业丆世丒且三丁专上()
    {
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(不丈丘丟上丈丘丝丗:  this.photonView);
    }
    internal virtual void 丁丒丐丙丆七一丏一()
    {
        if(this.世丏丅丂丅丗一丗万 == true)
        {
                return;
        }
        
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  18, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        this.世丏丅丂丅丗一丗万 = true;
    }
    protected virtual void 丙东丟丌丂丝丝七万(float 世丙丟上丘上七万万, bool 万丝一万丐且丌业丛, float 丟丆丆丝东世一丒丐 = -1)
    {
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.业丂丞上丝万丙上丟(世丙丟上丘上七万万:  世丙丟上丘上七万万, 万丝一万丐且丌业丛:  万丝一万丐且丌业丛, 丟丆丆丝东世一丒丐:  丟丆丆丝东世一丒丐));
    }
    private System.Collections.IEnumerator 业丂丞上丝万丙上丟(float 世丙丟上丘上七万万, bool 万丝一万丐且丌业丛, float 丟丆丆丝东世一丒丐 = -1)
    {
        TransportControllerBase.丕丛世丒丘专丗不丈 val_1 = new TransportControllerBase.丕丛世丒丘专丗不丈(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .世丙丟上丘上七万万 = 世丙丟上丘上七万万;
            .万丝一万丐且丌业丛 = 万丝一万丐且丌业丛;
        }
        else
        {
                mem[32] = this;
            mem[40] = 世丙丟上丘上七万万;
            mem[48] = 万丝一万丐且丌业丛;
        }
        
        .丟丆丆丝东世一丒丐 = 丟丆丆丝东世一丒丐;
        return (System.Collections.IEnumerator)val_1;
    }
    protected virtual void 丞丑丅丆丐丛丏丏丌()
    {
        UnityEngine.Object val_8;
        float val_9;
        val_8 = this;
        val_9 = 0f;
        if(S0 >= 0)
        {
                val_9 = V0.16B;
        }
        
        if(this == 0)
        {
                return;
        }
        
        val_9 = val_9 / V0.16B;
        val_8 = ???;
        val_9 = ???;
        goto typeof(TransportControllerBase).__il2cppRuntimeField_1D8;
    }
    internal void 下上东丙丝丂丑东丐(bool 与丛丘上丛丝下丟丏)
    {
        bool val_1 = 与丛丘上丛丝下丟丏;
        this.<丘丒不业丄丛丄不一>k__BackingField = val_1;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  234, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void 一丕上丆三丙丏丟下(object[] 专丒丌丆下丐丞丟丞)
    {
        object val_1 = 专丒丌丆下丐丞丟丞[0];
        this.<丘丒不业丄丛丄不一>k__BackingField = null;
    }
    internal void 丐专且七与世上丞丛(string 丈三世丞丕万丄七丂)
    {
        this.<丛丛丆一丑丒丛丞且>k__BackingField = 丈三世丞丕万丄七丂;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丈三世丞丕万丄七丂 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丈三世丞丕万丄七丂 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丈三世丞丕万丄七丂;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  83, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 世三下丄丒三上丏丟(object[] 专丒丌丆下丐丞丟丞)
    {
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        if((val_6 != null) && (null != null))
        {
                val_6 = 0;
        }
        
        this.<丛丛丆一丑丒丛丞且>k__BackingField = val_6;
        if((System.String.op_Equality(a:  val_6, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
                return;
        }
        
        this.世丌丒丁且丛丈且业(丐丌丌丈下丁丝丅万:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
    }
    internal void 世丌丒丁且丛丈且业(int 丐丌丌丈下丁丝丅万)
    {
        int val_6 = 丐丌丌丈下丁丝丅万;
        if(this.万东丂七东丁与业东() == 0)
        {
                return;
        }
        
        this.万东丂七东丁与业东().丞丞业丌东七下丏丐(丞丅上丏丂且下丅与:  val_6 = 丐丌丌丈下丁丝丅万);
        object[] val_5 = new object[1];
        val_6 = val_6;
        val_5[0] = val_6;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  235, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_5);
    }
    private void 东业丂丄东丞丐丒丐(object[] 专丒丌丆下丐丞丟丞)
    {
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        if(this.万东丂七东丁与业东() == 0)
        {
                return;
        }
        
        this.万东丂七东丁与业东().丞丞业丌东七下丏丐(丞丅上丏丂且下丅与:  21884928);
        this.丗丛丁丕丒丄丒丕一 = 0f;
    }
    private void 丅丙丘三丐万与世业(int 丄丆丏丙丁与丙世丆)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丂东业丆丝不丙世丐(丄丆丏丙丁与丙世丆:  丄丆丏丙丁与丙世丆));
    }
    private System.Collections.IEnumerator 丂东业丆丝不丙世丐(int 丄丆丏丙丁与丙世丆)
    {
        TransportControllerBase.丏一专丝丝丑丒世丕 val_1 = new TransportControllerBase.丏一专丝丝丑丒世丕(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丄丆丏丙丁与丙世丆 = 丄丆丏丙丁与丙世丆;
        return (System.Collections.IEnumerator)val_1;
    }
    internal virtual void 丕且丂且丐丁不丘不(int 丐丌丌丈下丁丝丅万)
    {
        this.photonView.TransferOwnership(丅东丕丐东上丕丟丆:  丐丌丌丈下丁丝丅万);
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        TransportSyncBase val_3 = this.GetComponent<TransportSyncBase>();
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        val_3.TransferOwnership(丅东丕丐东上丕丟丆:  丐丌丌丈下丁丝丅万);
    }
    internal virtual void 丏万三业丈丛三且万(SlowdownZoneTriggerTransport 专上丒上丒丕世丂丄)
    {
        this.<丒一东丏丁东丁东丏>k__BackingField = 专上丒上丒丕世丂丄;
    }
    public virtual bool get_isLivingTarget()
    {
        return false;
    }
    public virtual float get_maxHealth()
    {
        goto typeof(TransportControllerBase).__il2cppRuntimeField_2E8;
    }
    public virtual void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        var val_13;
        object val_14;
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丝三丛且丘不丌丙下)) == true) || ((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丝三丛且丘不丌丙下)) == null))
        {
            goto label_6;
        }
        
        val_13 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丝三丛且丘不丌丙下);
        int val_4 = val_13.业东丅东丌上丗丑不();
        goto label_10;
        label_6:
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丝三丛且丘不丌丙下)) == true) || ((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  丝三丛且丘不丌丙下)) == false))
        {
            goto label_15;
        }
        
        val_13 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  丝三丛且丘不丌丙下);
        label_10:
        val_14 = val_13.业东丅东丌上丗丑不();
        goto label_18;
        label_15:
        val_14 = 0;
        label_18:
        object[] val_12 = new object[4];
        if(val_12 == null)
        {
            goto label_19;
        }
        
        if(丞丈专下丈专业三丞 != 0)
        {
            goto label_20;
        }
        
        goto label_23;
        label_19:
        if(丞丈专下丈专业三丞 == 0)
        {
            goto label_23;
        }
        
        label_20:
        label_23:
        val_12[0] = 丞丈专下丈专业三丞;
        val_12[1] = 丒丈丐丐丗丐专丈丏;
        val_12[2] = 丐丟丘世丁三丕专专;
        val_12[3] = val_14;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
    }
    public virtual bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        NetworkStartTable val_6;
        var val_7;
        var val_8;
        var val_9;
        val_7 = 1152921505066536960;
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
            goto label_27;
        }
        
        val_8 = 0;
        goto label_4;
        label_24:
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg == 0)
        {
            goto label_19;
        }
        
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg == 专丞上七七且丝七丗)
        {
            goto label_29;
        }
        
        val_6 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
            goto label_29;
        }
        
        label_19:
        val_8 = 1;
        label_4:
        val_6 = this;
        if(val_8 < null)
        {
            goto label_24;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_27;
        }
        
        val_6 = 0;
        label_34:
        if(val_6 >= null)
        {
            goto label_29;
        }
        
        val_7 = 0;
        val_6 = val_6 + 1;
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg == 0)
        {
            goto label_34;
        }
        
        label_27:
        val_9 = 1;
        return (bool)val_9;
        label_29:
        val_9 = 0;
        return (bool)val_9;
    }
    public virtual bool IsDead()
    {
        return (bool)this.万丁丙东东丟丅丝三;
    }
    public virtual int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public virtual void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public virtual void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    protected virtual bool 丛丛丟世且上丞丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_8;
        object val_9;
        var val_10;
        val_8 = this;
        val_9 = this.photonView;
        if((val_9.isMine != false) && ((val_8 & 1) == 0))
        {
                if((System.String.op_Equality(a:  丝三丁东丈丒世丅业.gameObject.name, b:  "DeadCollider")) != false)
        {
                val_8 = this.photonView;
            object[] val_7 = new object[3];
            val_7[0] = 100f;
            val_7[1] = 0;
            val_9 = 1;
            val_7[2] = val_9;
            val_8.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_7);
            val_10 = 1;
            return (bool)val_10;
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    protected virtual void OnCollisionEnter(UnityEngine.Collision 丘丛丏丘丝七世七丅)
    {
        丅丙上七上一丐不下 val_27;
        UnityEngine.Object val_28;
        float val_32;
        float val_33;
        val_27 = this;
        UnityEngine.GameObject val_1 = 丘丛丏丘丝七世七丅.gameObject;
        val_28 = this.photonView;
        if(val_28.isMine == false)
        {
            goto label_9;
        }
        
        val_28 = 丘丛丏丘丝七世七丅.collider.gameObject.GetComponent<ChestBatleRoyale>();
        if(val_28 == 0)
        {
            goto label_9;
        }
        
        val_28 = 丘丛丏丘丝七世七丅.collider.gameObject.GetComponent<丅丙上七上一丐不下>();
        UnityEngine.Vector3 val_13 = this.丌丟丄业且三丛丕丄().position;
        var val_27 = 0;
        val_27 = val_27 + 1;
        goto label_19;
        label_9:
        UnityEngine.Vector3 val_14 = 丘丛丏丘丝七世七丅.impulse;
        if(val_14.x <= 5000f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_15 = 丘丛丏丘丝七世七丅.impulse;
        if(丘丛丏丘丝七世七丅 != null)
        {
                UnityEngine.Vector3 val_16 = 丘丛丏丘丝七世七丅.impulse;
            val_32 = val_16.x;
        }
        else
        {
                UnityEngine.Vector3 val_17 = 0.impulse;
            val_32 = val_17.x;
        }
        
        UnityEngine.Vector3 val_18 = 丘丛丏丘丝七世七丅.impulse;
        float val_29 = val_32;
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_29, y:  val_18.z);
        val_29 = val_29 * 0.5f;
        if(System.Math.Abs(val_15.y) >= 0)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        object[] val_23 = new object[3];
        val_28 = val_23;
        val_29 = val_29 / val_29;
        val_33 = (val_29 * 0.5f) * val_29;
        val_28[0] = val_33;
        val_28[1] = 0;
        val_28[2] = 3;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_23);
        goto label_43;
        label_19:
        val_33 = 10f;
        val_28.ApplyDamage(丞丈专下丈专业三丞:  val_33, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  丘丛丏丘丝七世七丅.collider, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, 丐丟丘世丁三丕专专:  0, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        丘丛丏丘丝七世七丅.collider.enabled = false;
        label_43:
        val_32 = val_33;
        val_27 = val_27;
        FirstPersonControlSharp.丌世丂丅专业丛丁丙(丟丙丗业与下丅业丛:  val_32, 丘丞丐丘三丕与丙丁:  val_33);
    }
    protected virtual void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Collider val_26;
        UnityEngine.Object val_27;
        float val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_26 = 丘丛丏丘丝七世七丅;
        UnityEngine.GameObject val_1 = val_26.gameObject;
        val_27 = this.丞上丁丘丅三丕丒丄();
        UnityEngine.Vector3 val_3 = val_27.velocity;
        val_28 = val_3.x;
        if(val_28 <= this.minVelocityHitPlayer)
        {
                return;
        }
        
        val_29 = 1152921504848912384;
        val_27 = val_26.transform.parent;
        if(val_27 == 0)
        {
                return;
        }
        
        val_27 = val_26.transform.parent;
        if((val_27.CompareTag(tag:  "Player")) == false)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        val_27 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_27 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_27 == 0)
        {
                return;
        }
        
        val_27 = this.photonView.isMine;
        UnityEngine.Transform val_14 = val_26.transform.parent;
        if(val_27 != false)
        {
                val_27 = val_14.GetComponent<SkinName>();
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
        
            float val_27 = this.minDamageHitPlayer;
            float val_26 = this.minVelocityHitPlayer;
            val_15.playerMoveC.丌丌七丂丏丌且专丝();
            val_31 = null;
            val_31 = null;
            float val_18 = this.maxDamageHitPlayer - val_27;
            UnityEngine.Vector3 val_20 = this.transform.position;
            val_28 = val_20.x;
            val_18 = val_18 * ((UnityEngine.Mathf.Clamp(value:  val_28, min:  this.minVelocityHitPlayer, max:  this.maxVelocityHitPlayer)) - val_26);
            val_26 = this.maxVelocityHitPlayer - val_26;
            val_26 = val_18 / val_26;
            val_27 = val_27 + val_26;
            val_15.playerMoveC.丂七一业下丈业丕丒.ApplyDamage(丞丈专下丈专业三丞:  val_27, 丛世一丟丞丁业丘丒:  typeof(Player_move_c).__il2cppRuntimeField_600, 专不丑且不丏东丟丅:  val_26, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_28, y = val_20.y, z = val_20.z}, 丐丟丘世丁三丕专专:  23, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  this.不丞丒下丕丙东东且, 丒丈丐丐丗丐专丈丏:  GetComponent<PixelView>().viewID);
            val_26 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 32];
            val_26 = InGameGUI.丙丞专丌丁丞与不丐.aimCrosshair;
            丛丐丒上丒丘丆丕与(万丐七下丂丂丛世丞:  (val_15.playerMoveC.丙上丗丐万丏丑丘丟 == true) ? 1 : 0, 且世与七东丕丈丗丁:  true, 世丕与丙丄丙不丄丝:  false);
            FirstPersonControlSharp.上三丈世丟业一丘丘(丐不丁专业丌七东丕:  0.2f, 丘丞丌丙上万丒上丁:  0.2f);
            return;
        }
        
        val_32 = null;
        val_26 = val_14.gameObject;
        val_32 = null;
        if(val_26 != WeaponManager.丟丗丄业丘丗业丗七.myPlayer)
        {
                return;
        }
        
        val_33 = null;
        val_33 = null;
        val_26 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_26 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_34 = null;
        val_34 = null;
        val_26 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_26 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        七丟丅丗丙丈东丏丐();
    }
    protected void 丏丐丕且丝七世丝丗(Player_move_c 业七丑丁且丐丝上三, int 不万上丕丅丏丆丄丝)
    {
        var val_36;
        var val_37;
        bool val_38;
        var val_39;
        var val_40;
        int val_41;
        var val_42;
        System.Func<Player_move_c, System.Boolean> val_44;
        var val_45;
        CategoryNames val_46;
        CategoryNames val_47;
        int val_48;
        var val_49;
        float val_50;
        int val_51;
        if((业七丑丁且丐丝上三.mySkinName != 0) && (业七丑丁且丐丝上三.mySkinName.firstPersonControl != 0))
        {
                var val_3 = (业七丑丁且丐丝上三.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true) ? 1 : 0;
        }
        
        val_36 = null;
        val_36 = null;
        if(GameController.onlineMode != 0)
        {
                val_37 = null;
            val_37 = null;
            if(GameController.丆丘丂丈世丏丟丑丏 != null)
        {
            goto label_20;
        }
        
        }
        
        label_20:
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_7 = BattleRoyaleController.丑七不且上丗丁一世();
            val_38 = val_7.squadMode;
        }
        else
        {
                val_38 = 0;
        }
        
        val_39 = null;
        val_39 = null;
        if(GameController.onlineMode != 0)
        {
                val_40 = null;
            val_40 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_74;
        }
        
        }
        
        }
        
        label_74:
        if((业七丑丁且丐丝上三.mySkinName != 0) && (业七丑丁且丐丝上三.mySkinName.character != 0))
        {
                UnityEngine.Vector3 val_12 = this.transform.position;
            UnityEngine.Vector3 val_14 = 业七丑丁且丐丝上三.mySkinName.character.transform.position;
            val_41 = (int)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        }
        else
        {
                val_41 = 0;
        }
        
        val_42 = null;
        val_42 = null;
        val_44 = TransportControllerBase.<>c.<>9__147_0;
        if(val_44 == null)
        {
                System.Func<Player_move_c, System.Boolean> val_16 = null;
            val_44 = val_16;
            val_16 = new System.Func<Player_move_c, System.Boolean>(object:  TransportControllerBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TransportControllerBase.<>c::与丅丗东专不丟东丞(Player_move_c 三丟东丕丄丄下下丑));
            TransportControllerBase.<>c.<>9__147_0 = val_44;
        }
        
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null)
        {
                val_45 = this.万东丂七东丁与业东().丏东不世丝丗丅丙丁(丞丅上丏丂且下丅与:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
        }
        else
        {
                val_45 = 0;
        }
        
        val_46 = 9961472;
        val_46 = 152;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  不万上丕丅丏丆丄丝)) == false)
        {
            goto label_67;
        }
        
        val_47 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  不万上丕丅丏丆丄丝);
        if(val_47 == null)
        {
            goto label_69;
        }
        
        if(null == null)
        {
                val_46 = val_47;
        }
        
        if(null == null)
        {
            goto label_71;
        }
        
        val_48 = 0;
        goto label_72;
        label_67:
        val_47 = 0;
        label_69:
        val_48 = 0;
        goto label_76;
        label_71:
        val_48 = val_47.业东丅东丌上丗丑不();
        label_72:
        if(null != null)
        {
                val_47 = 0;
        }
        else
        {
                val_47 = val_47.业东丅东丌上丗丑不();
        }
        
        label_76:
        var val_31 = val_38 | 0;
        val_49 = 0;
        val_50 = 业七丑丁且丐丝上三.丘七业丒丐世丂丅丒();
        float val_33 = 业七丑丁且丐丝上三.专一丟丏且丆丕丝七();
        val_33 = val_50 / val_33;
        val_33 = val_33 * 100f;
        if(业七丑丁且丐丝上三.与丙丕丛一丌丛丆丈 != null)
        {
                val_50 = 业七丑丁且丐丝上三.与丙丕丛一丌丛丆丈.丈下丏丟丑丐丆三不();
            val_49 = 0;
            float val_35 = 业七丑丁且丐丝上三.与丙丕丛一丌丛丆丈.七丁丙丅丂上丒丞丙();
            val_35 = val_50 / val_35;
            val_35 = val_35 * 100f;
            val_51 = (int)val_35;
        }
        else
        {
                val_51 = 0;
        }
        
        val_31 = val_31 | GameController.onlineMode.丄丗三丌世东业上丌();
        Rilisoft.丞丛七上丕专丏丌丈.丏丐丕且丝七世丝丗(不业丘万丝一东丑专:  val_46, 下且与丐上丟七丑丏:  val_48, 丈一丌丂丄七丁丙丄:  val_47, 世丙丟上丘上七万万:  (int)val_33, 与丙丕丛一丌丛丆丈:  0, 三丞且上丐丟丌七丌:  false, 丙专七丘与丒丛丅丆:  (val_31 == true) ? 1 : 0, 丂丒丒丝东上上专丛:  0, 丗丕丗丁丈业丄丄丌:  val_45 & 1, 丒丘上丆丝三丒丁丒:  this, 丞丞东丘专丕七丘业:  System.Linq.Enumerable.Count<Player_move_c>(source:  this, predicate:  val_16));
    }
    private UnityEngine.Transform IDamageable.get_transform()
    {
        return this.transform;
    }
    private bool 世三且丞七丌丙与丒(与丅丕丈丘东丝世丟 丕不万丒丅业三且三)
    {
        FreeplayVehicleOwner val_1 = this.万东丂七东丁与业东();
        if(val_1 != null)
        {
                return val_1.丏东不世丝丗丅丙丁(丞丅上丏丂且下丅与:  丕不万丒丅业三且三.业丐丐三丕一丗丛丁());
        }
        
        return val_1.丏东不世丝丗丅丙丁(丞丅上丏丂且下丅与:  丕不万丒丅业三且三.业丐丐三丕一丗丛丁());
    }

}
