using UnityEngine;
internal class CarSyncRacing : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    private UnityEngine.Vector3 丛丞专下丄丐丝丟世;
    private float 丞丑丕七丕一且与丘;
    private UnityEngine.Vector3 deltaVelocity;
    private float fraction;
    private bool 万七丆丝丙丛万丆丄;
    private VehicleEngine m_car;
    private UnityEngine.Transform m_Transorm;
    private UnityEngine.Vector3 丁丘丕丝且丘丅丅丄;
    private UnityEngine.Quaternion 丂丆七丑业一丏丞且;
    private UnityEngine.Vector3 东业七下丟东世丈丆;
    public PhotonView photonView;
    private UnityEngine.Vector3 下业丕七东丌丝下且;
    private UnityEngine.Quaternion 丙丆与丅丈丑一且丏;
    private float 专丑与丏丏丑丘丛万;
    private float 世与一下丆东丘丝七;
    private float 丆丛丐丞丘丛与丑丈;
    public float syncTime;
    internal bool 丕不丛丕丛丘丙丑丂;
    private VehicleController vehicleController;
    public float correctionCoef;
    public float correctionCoefVelocity;
    public float carSpeedCorrection;
    public float correctionTime;
    
    // Methods
    internal CarSyncRacing()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丛丞专下丄丐丝丟世 = val_1;
        mem[1152921525580861052] = val_1.y;
        mem[1152921525580861056] = val_1.z;
        this.丞丑丕七丕一且与丘 = 0.1f;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.丂丆七丑业一丏丞且 = val_2;
        mem[1152921525580861120] = val_2.y;
        this.世与一下丆东丘丝七 = 0.5f;
        mem[1152921525580861124] = val_2.z;
        mem[1152921525580861128] = val_2.w;
        this.syncTime = 0.4f;
        this.correctionCoef = ;
        this.correctionCoefVelocity = ;
        this.carSpeedCorrection = 20f;
        this.correctionTime = 0.4f;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void CarSyncRacing::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_5 = this.与丑丌丌丌丁丌不丕();
        val_5.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void CarSyncRacing::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_3;
        int val_4;
        var val_5;
        val_3 = 丞世不丒下上上丝丑;
        if((val_3 & 255) == 155)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_4 = 专丒丌丆下丐丞丟丞.Length;
            if(val_4 == 0)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            if(val_4 <= 1)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            object val_4 = 专丒丌丆下丐丞丟丞[1];
            object val_5 = 专丒丌丆下丐丞丟丞[2];
            this.丑下七七丑丝世丅业(丏丞丐丕七且丌丂丙:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 丐丘丗上丂丒丐丟业:  new UnityEngine.Quaternion() {y = 专丒丌丆下丐丞丟丞[0], z = ???, w = ???}, 与丅丛不不丄万丞丄:  false);
            val_5 = 1;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private void Awake()
    {
        this.photonView = this.GetComponent<PhotonView>();
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    public void Update()
    {
        if(this.photonView.isMine == true)
        {
                return;
        }
        
        if(this.vehicleController.丑丒丙与不丆三丏丌() == false)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.fraction + val_3;
        this.fraction = val_3;
    }
    internal void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        VehicleEngine val_44;
        VehicleController val_45;
        var val_46;
        float val_47;
        float val_48;
        var val_49;
        float val_50;
        float val_51;
        float val_52;
        float val_53;
        float val_54;
        val_44 = this;
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                val_45 = this.vehicleController;
            if(val_45.丑丒丙与不丆三丏丌() == false)
        {
                return;
        }
        
            UnityEngine.Vector3 val_3 = this.m_car.carRigidbody.velocity;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
            UnityEngine.Vector3 val_4 = this.m_car.carRigidbody.angularVelocity;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
            UnityEngine.Vector3 val_5 = this.m_Transorm.position;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_5);
            UnityEngine.Quaternion val_6 = this.m_Transorm.rotation;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_6);
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.m_car.horizontal);
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.m_car.vertical);
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.m_car.isGrounded);
            val_45 = this.丕不丛丕丛丘丙丑丂;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丕不丛丕丛丘丙丑丂);
            if(this.丕不丛丕丛丘丙丑丂 == false)
        {
                return;
        }
        
            this.丕不丛丕丛丘丙丑丂 = false;
            return;
        }
        
        if(东业丄丅丅且世七丄 != null)
        {
                object val_8 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        }
        else
        {
                object val_9 = 0.与万三丘与专丛丄七();
        }
        
        object val_10 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_11 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.下业丕七东丌丝下且 = new UnityEngine.Vector3();
        mem[1152921525581789752] = ???;
        object val_12 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丙丆与丅丈丑一且丏 = new UnityEngine.Quaternion();
        mem[1152921525581789760] = ???;
        mem[1152921525581789768] = ???;
        object val_13 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_14 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_15 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        if(东业丄丅丅且世七丄 != null)
        {
                val_46 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        }
        else
        {
                val_46 = 0.与万三丘与专丛丄七();
        }
        
        object val_18 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        UnityEngine.Vector3 val_19 = this.m_Transorm.position;
        val_48 = this.下业丕七东丌丝下且;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_48, y = V9.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        if(this.万七丆丝丙丛万丆丄 != false)
        {
                var val_21 = (val_20.x > 2500f) ? 1 : 0;
        }
        else
        {
                val_49 = 1;
        }
        
        val_49 = val_49 | 1152921504628731904;
        if(val_49 != null)
        {
                this.万七丆丝丙丛万丆丄 = true;
            this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = this.丙丆与丅丈丑一且丏, y = V9.16B, z = V11.16B, w = val_19.x};
            this.m_Transorm.position = new UnityEngine.Vector3() {x = this.下业丕七东丌丝下且, y = V9.16B, z = V11.16B};
            val_47 = 1152921504838316032;
            this.m_car.carRigidbody.velocity = new UnityEngine.Vector3() {x = 3.782474E-38f, y = 2.524355E-29f, z = val_47};
            val_48 = 3.782474E-38f;
            this.m_car.carRigidbody.angularVelocity = new UnityEngine.Vector3() {x = val_48, y = ???, z = ???};
        }
        
        double val_22 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_22 = val_22 - null;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = 2.524355E-29f, z = 1152921504838316032}, d:  (float)val_22);
        UnityEngine.Vector3 val_25 = this.transform.InverseTransformVector(vector:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        UnityEngine.Vector3 val_28 = this.transform.InverseTransformVector(vector:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        float val_31 = (UnityEngine.Mathf.Min(a:  this.carSpeedCorrection, b:  val_28.x * 2.236936f)) / this.carSpeedCorrection;
        UnityEngine.Vector3 val_32 = this.m_Transorm.position;
        float val_44 = 1f;
        val_44 = val_44 - val_31;
        float val_34 = val_25.z * val_44;
        UnityEngine.Vector3 val_35 = this.transform.TransformVector(vector:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
        val_50 = val_36.y;
        float val_45 = this.correctionCoefVelocity;
        val_45 = val_28.z * val_45;
        float val_38 = val_31 * val_45;
        UnityEngine.Vector3 val_39 = this.transform.TransformVector(vector:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = 2.524355E-29f, z = 1152921504838316032}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        val_51 = val_40.x;
        val_52 = val_40.y;
        val_53 = val_40.z;
        if(null == null)
        {
                val_51 = 3.782474E-38f;
            val_52 = 2.524355E-29f;
            val_53 = 1152921504838316032;
        }
        
        this.m_car.carRigidbody.velocity = new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_53};
        val_54 = this.丆丛丐丞丘丛与丑丈;
        float val_41 = UnityEngine.Time.time;
        if((val_54 + this.correctionTime) < 0)
        {
                this.丆丛丐丞丘丛与丑丈 = UnityEngine.Time.time;
            this.vehicleController.丆业三与丆丒丂丅专(七丑丕丘上一万丂丁:  new UnityEngine.Vector3() {x = val_36.x, y = val_50, z = val_36.z}, 丅与丁下丞丅且丅专:  new UnityEngine.Quaternion() {x = this.丙丆与丅丈丑一且丏, y = this.correctionTime, z = val_53, w = 1152921504838316032});
            this.m_Transorm.position = new UnityEngine.Vector3() {x = val_36.x, y = val_50, z = val_36.z};
            val_54 = this.丙丆与丅丈丑一且丏;
            this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = val_54, y = this.correctionTime, z = val_36.x, w = val_50};
            this.m_car.carRigidbody.angularVelocity = new UnityEngine.Vector3() {x = 3.782474E-38f, y = ???, z = ???};
        }
        
        this.m_car.horizontal = null;
        val_44 = this.m_car;
        this.m_car.vertical = null;
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        object[] val_2 = new object[3];
        UnityEngine.Vector3 val_3 = this.m_Transorm.position;
        val_2[0] = val_3;
        UnityEngine.Quaternion val_4 = this.m_Transorm.rotation;
        val_2[1] = val_4;
        val_2[2] = this.vehicleController.丑丒丙与不丆三丏丌();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 丑下七七丑丝世丅业(UnityEngine.Vector3 丏丞丐丕七且丌丂丙, UnityEngine.Vector3 丙丆丗业丌丏业丒丝, UnityEngine.Quaternion 丐丘丗上丂丒丐丟业, bool 与丅丛不不丄万丞丄)
    {
        float val_1;
        float val_2;
        与丅丛不不丄万丞丄 = 与丅丛不不丄万丞丄;
        this.vehicleController.丈不万专世丒丆丗丆(丙业与丙丗丝不丈东:  与丅丛不不丄万丞丄);
        if(this.万七丆丝丙丛万丆丄 != false)
        {
                return;
        }
        
        this.万七丆丝丙丛万丆丄 = true;
        this.m_Transorm.position = new UnityEngine.Vector3() {x = 丙丆丗业丌丏业丒丝.x, y = 丙丆丗业丌丏业丒丝.y, z = 丙丆丗业丌丏业丒丝.z};
        this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = 丐丘丗上丂丒丐丟业.x, y = val_2, z = 丐丘丗上丂丒丐丟业.y, w = val_1};
    }

}
