using UnityEngine;
internal class DroneController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    public PhotonView photonView;
    public UnityEngine.GameObject droneModel;
    public UnityEngine.Animation droneAnimation;
    public UnityEngine.GameObject deactivationEffect;
    internal Player_move_c owner;
    public UnityEngine.Transform target;
    private 丕丈丏丝丗下丟丅丂 丁且丌丁丆丝丙丘丝;
    public float maxSpeed;
    public float acceleration;
    public float rotationSpeed;
    public float maxRadiusScanTarget;
    public float maxTimerScanTargetIdle;
    public float maxTimerShot;
    private float 丕丄丕丑丗东丆与丘;
    private float 丈三丐且丝上丙丐丙;
    public UnityEngine.AudioClip shotClip;
    private bool 七丕一一丅丙丗不且;
    private UnityEngine.GameObject 且丘万丟业丁丕世万;
    private float 丞丈专下丈专业三丞;
    private string 丆丈丅上丙业丌且丅;
    private bool 丄世丅下丒七丈下丘;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private float 上且专下丈下丕七丄;
    private UnityEngine.Vector3 丈丑丑且业下丒丁丞;
    private bool 丆丕丛丞丑丞丄丟三;
    private UnityEngine.Vector3 丐且丅世且丕东万丐;
    private UnityEngine.Quaternion 丒丒业三丗不丘上丌;
    
    // Properties
    public bool 丌且下丕下下丌万丞 { get; }
    
    // Methods
    public bool get_isMine()
    {
        var val_1 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return true;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return true;
        }
        
        if(this.photonView != null)
        {
                return this.photonView.isMine;
        }
        
        return this.photonView.isMine;
    }
    private void Awake()
    {
        this.photonView = this.GetComponent<PhotonView>();
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
    }
    internal DroneController()
    {
        this.maxTimerScanTargetIdle = 1f;
        this.maxTimerShot = 1f;
        this.丞丈专下丈专业三丞 = 2f;
        this.maxSpeed = ;
        this.acceleration = ;
        this.rotationSpeed = 400f;
        this.maxRadiusScanTarget = 20f;
        this.丆丈丅上丙业丌且丅 = "";
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this.丒丒业三丗不丘上丌 = val_1;
        mem[1152921525911126780] = val_1.y;
        mem[1152921525911126784] = val_1.z;
        mem[1152921525911126788] = val_1.w;
        Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
        val_2.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void DroneController::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void Start()
    {
        var val_4;
        var val_6;
        var val_7;
        var val_8;
        System.Collections.Generic.List<Player_move_c> val_9;
        var val_10;
        Player_move_c val_11;
        var val_12;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_6 = 0;
        goto label_7;
        label_19:
        val_7 = null;
        val_7 = null;
        Player_move_c val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(this.photonView.ownerId == val_1.mySkinName.丄丈丑丐丆丞丘与丗.ownerId)
        {
            goto label_15;
        }
        
        val_6 = 1;
        label_7:
        val_8 = null;
        val_8 = null;
        val_9 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        if(val_6 < val_9.Count)
        {
            goto label_19;
        }
        
        return;
        label_3:
        val_10 = null;
        val_10 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        goto label_24;
        label_15:
        val_12 = null;
        val_12 = null;
        val_9 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        Player_move_c val_3 = val_9.Item[0];
        val_11 = val_3.mySkinName.playerMoveC;
        label_24:
        this.owner = val_11;
    }
    public void SetParameters(丕丈丏丝丗下丟丅丂 东一丁世丑丞业丄丐)
    {
        this.丁且丌丁丆丝丙丘丝 = 东一丁世丑丞业丄丐;
        this.丆丈丅上丙业丌且丅 = 东一丁世丑丞业丄丐.业上丙丞丐丄丆丅七();
        this.丞丈专下丈专业三丞 = 东一丁世丑丞业丄丐.丁丒丝丈丈丒丞丘下(丅丏三七丁丑丞丄丏:  this.photonView);
    }
    private void Update()
    {
        var val_5;
        var val_6;
        if(this.isMine == false)
        {
                return;
        }
        
        if(this.丄世丅下丒七丈下丘 != false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_6 = null;
            val_6 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                this.Destroy();
            return;
        }
        
        }
        
        this.丈丞一丈丑丝丈丂丂();
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丈三丐且丝上丙丐丙 - val_3;
        this.丈三丐且丝上丙丐丙 = val_3;
        if(this.target == 0)
        {
                return;
        }
        
        if(this.七丕一一丅丙丗不且 == false)
        {
                return;
        }
        
        if(this.丈三丐且丝上丙丐丙 >= 0)
        {
                return;
        }
        
        this.丟丑丙七丁三丞丕丁();
        this.丈三丐且丝上丙丐丙 = this.maxTimerShot;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 == 32)
        {
            goto label_1;
        }
        
        if(val_1 != 92)
        {
            goto label_2;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        this.世且丂丕丐丝丐丐且(丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = 3.782474E-38f});
        goto label_5;
        label_1:
        this.丐丕与丟七与三丂业();
        label_5:
        val_2 = 1;
        return (bool)val_2;
        label_2:
        val_2 = 0;
        return (bool)val_2;
    }
    private void 世且丂丕丐丝丐丐且(UnityEngine.Vector3 丂且丑三且丌丘下丌)
    {
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (this.丞下上且一上丙不丏 != 0))
        {
                if(this.shotClip != 0)
        {
                this.丞下上且一上丙不丏.PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丂且丑三且丌丘下丌.x, y = 丂且丑三且丌丘下丌.y, z = 丂且丑三且丌丘下丌.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_8 = this.transform.position;
        UnityEngine.GameObject val_9 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丛丄万三丂东丙丑东:  "Weapon133", 不丅丛专丘丅专丘丕:  val_8.x);
        this.且丘万丟业丁丕世万 = val_9;
        val_9.transform.parent = this.transform;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.丒丒业三丗不丘上丌 = val_12;
        mem[1152921525911916252] = val_12.y;
        mem[1152921525911916256] = val_12.z;
        mem[1152921525911916260] = val_12.w;
        this.transform.rotation = new UnityEngine.Quaternion() {x = this.丒丒业三丗不丘上丌, y = val_6.y, z = val_6.z, w = val_8.x};
        if(this.droneAnimation == 0)
        {
                return;
        }
        
        this = this.droneAnimation;
        bool val_15 = this.Play(animation:  "Shoot");
    }
    private void 丟丑丙七丁三丞丕丁()
    {
        PhotonView val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = this;
        UnityEngine.Vector3 val_2 = this.transform.forward;
        UnityEngine.Vector3 val_4 = this.transform.position;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  100f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丒丑丗一东丈万丅下())) == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_13 = null;
            val_13 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        }
        
        bool val_9 = this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0));
        this.世且丂丕丐丝丐丐且(丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = 100f, y = val_4.y, z = val_4.z});
        val_14 = null;
        val_14 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_11 = this.photonView;
        object[] val_10 = new object[1];
        val_10[0] = 100f;
        val_11.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_10);
    }
    private void 丈丞一丈丑丝丈丂丂()
    {
        if(this.target != 0)
        {
                UnityEngine.Vector3 val_2 = this.target.position;
            if(val_2.y < 0)
        {
                this.target = 0;
        }
        
        }
        
        if(((丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  this.target)) != null) && (null != 0))
        {
                this.target = 0;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.丕丄丕丑丗东丆与丘 - val_4;
        this.丕丄丕丑丗东丆与丘 = val_4;
        if(val_4 >= 0)
        {
                if(this.target != 0)
        {
                return;
        }
        
        }
        
        this.丕丄丕丑丗东丆与丘 = this.maxTimerScanTargetIdle;
        if(this.丆丕丛丞丑丞丄丟三 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丗丅世且丛丑业世丑());
    }
    private System.Collections.IEnumerator 丗丅世且丛丑业世丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DroneController.七不三专三上世业丞();
    }
    private bool 三且丆丙丂丘丗丕丙(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        UnityEngine.GameObject val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_13;
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        val_10 = 0;
        if(val_8 == 0)
        {
                return false;
        }
        
        val_11 = null;
        val_11 = null;
        val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_10 = 4;
        if((丂丈丙且丈丗三丆丕.IsEnemyTo(专丞上七七且丝七丗:  val_8)) == false)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_13 = null;
        val_13 = null;
        var val_10 = 0;
        val_10 = val_10 + 1;
        丂丈丙且丈丗三丆丕.ApplyDamage(丞丈专下丈专业三丞:  this.丞丈专下丈专业三丞, 丛世一丟丞丁业丘丒:  this.owner.丂七一业下丈业丕丒, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丐丟丘世丁三丕专专:  0, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  this.丆丈丅上丙业丌且丅, 丒丈丐丐丗丐专丈丏:  GetComponent<PixelView>().viewID);
        return false;
    }
    private void OnDisable()
    {
        if(this.且丘万丟业丁丕世万 == 0)
        {
                return;
        }
        
        if(this.且丘万丟业丁丕世万.transform.parent != this.transform)
        {
                return;
        }
        
        this.且丘万丟业丁丕世万.transform.parent = 0;
    }
    public void Deactivate()
    {
        var val_3;
        if(this.isMine == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  32, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
        this.丐丕与丟七与三丂业();
    }
    internal void 丐丕与丟七与三丂业()
    {
        if(this.丄世丅下丒七丈下丘 == true)
        {
                return;
        }
        
        this.丄世丅下丒七丈下丘 = true;
        if(this.deactivationEffect != 0)
        {
                this.deactivationEffect.SetActive(value:  true);
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丐且丅世且丕东万丐 = val_2;
        mem[1152921525913061904] = val_2.y;
        mem[1152921525913061908] = val_2.z;
        if(this.isMine == false)
        {
                return;
        }
        
        this.Invoke(methodName:  "Destroy", time:  0.5f);
    }
    public void Destroy()
    {
        var val_4;
        this.droneModel.SetActive(value:  false);
        if(this.isMine == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void LateUpdate()
    {
        UnityEngine.Object val_40;
        float val_41;
        float val_42;
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        if(this.owner == 0)
        {
                return;
        }
        
        if((this.isMine == false) || (this.丄世丅下丒七丈下丘 == true))
        {
            goto label_26;
        }
        
        val_40 = this.owner.专丟丏丞丘业业丐专();
        if(val_40 == 0)
        {
            goto label_9;
        }
        
        if(val_40 != null)
        {
            goto label_12;
        }
        
        goto label_11;
        label_9:
        val_40 = this.transform;
        if(val_40 != null)
        {
            goto label_12;
        }
        
        label_11:
        label_12:
        UnityEngine.Vector3 val_6 = val_40.position;
        UnityEngine.Vector3 val_7 = this.owner.myPlayerTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.丐且丅世且丕东万丐 = val_7;
        mem[1152921525913400592] = val_7.y;
        mem[1152921525913400596] = val_7.z;
        if(this.target != 0)
        {
                UnityEngine.Vector3 val_9 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  this.target);
            UnityEngine.Vector3 val_11 = this.transform.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_41 = val_12.x;
            val_42 = val_12.z;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_41, y = val_12.y, z = val_42});
            this.丒丒业三丗不丘上丌 = val_13;
            mem[1152921525913400604] = val_13.y;
            mem[1152921525913400608] = val_13.z;
            mem[1152921525913400612] = val_13.w;
            UnityEngine.Vector3 val_15 = this.transform.forward;
            val_44 = 4f;
            this.七丕一一丅丙丗不且 = ((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) < 0) ? 1 : 0;
        }
        else
        {
                UnityEngine.Vector3 val_18 = this.owner.myPlayerTransform.forward;
            val_41 = val_18.x;
            val_44 = val_18.y;
            val_42 = val_18.z;
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_41, y = val_44, z = val_42});
            this.丒丒业三丗不丘上丌 = val_19;
            mem[1152921525913400604] = val_19.y;
            mem[1152921525913400608] = val_19.z;
            mem[1152921525913400612] = val_19.w;
            this.七丕一一丅丙丗不且 = false;
        }
        
        label_26:
        UnityEngine.Vector3 val_21 = this.transform.position;
        UnityEngine.Vector3 val_22 = this.owner.myPlayerTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        val_45 = val_22.z;
        val_46 = this.丐且丅世且丕东万丐;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_46, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_45});
        val_47 = 0f;
        if(val_23.x > 0.0001f)
        {
                val_45 = this.上且专下丈下丕七丄;
            val_46 = val_45;
            val_47 = UnityEngine.Mathf.MoveTowards(current:  val_46, target:  this.maxSpeed, maxDelta:  this.acceleration);
        }
        
        this.上且专下丈下丕七丄 = val_47;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = this.丈丑丑且业下丒丁丞, y = val_45, z = V11.16B}, target:  new UnityEngine.Vector3() {x = this.丐且丅世且丕东万丐, y = this.丐且丅世且丕东万丐, z = V14.16B}, maxDistanceDelta:  val_47 * UnityEngine.Time.deltaTime);
        this.丈丑丑且业下丒丁丞 = val_27;
        mem[1152921525913400576] = val_27.y;
        mem[1152921525913400580] = val_27.z;
        UnityEngine.Vector3 val_29 = this.owner.myPlayerTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = this.丈丑丑且业下丒丁丞, y = this.丈丑丑且业下丒丁丞, z = val_45});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  0.06f);
        float val_32 = UnityEngine.Time.time;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  val_32);
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        this.transform.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        UnityEngine.Quaternion val_37 = this.transform.rotation;
        float val_38 = UnityEngine.Time.deltaTime;
        val_38 = this.rotationSpeed * val_38;
        UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.RotateTowards(from:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w}, to:  new UnityEngine.Quaternion() {x = this.丒丒业三丗不丘上丌, y = val_31.y, z = val_31.z, w = val_32}, maxDegreesDelta:  val_38);
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_39.x, y = val_39.y, z = val_39.z, w = val_39.w};
    }
    private void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丐且丅世且丕东万丐);
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丒丒业三丗不丘上丌);
            return;
        }
        
        object val_2 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丐且丅世且丕东万丐 = new UnityEngine.Vector3();
        mem[1152921525913627236] = ???;
        object val_3 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丒丒业三丗不丘上丌 = new UnityEngine.Quaternion();
        mem[1152921525913627244] = ???;
        mem[1152921525913627252] = ???;
    }

}
