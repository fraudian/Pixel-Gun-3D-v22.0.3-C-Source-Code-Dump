using UnityEngine;
internal class CarSinc : TransportSyncBase, 东丁丆一业丈万丆丐
{
    // Fields
    private UnityEngine.Vector3 丛丞专下丄丐丝丟世;
    private float 丞丑丕七丕一且与丘;
    private UnityEngine.Vector3 deltaVelocity;
    private float fraction;
    private bool 万七丆丝丙丛万丆丄;
    private bool 丟丆丏下一丐丘专业;
    private UnityEngine.Rigidbody m_Body;
    private VehicleEngine m_car;
    private UnityEngine.Transform m_Transorm;
    private UnityEngine.Vector3 丁丘丕丝且丘丅丅丄;
    private UnityEngine.Quaternion 丂丆七丑业一丏丞且;
    private UnityEngine.Vector3 东业七下丟东世丈丆;
    public PhotonView photonViewStream;
    private UnityEngine.Vector3 下业丕七东丌丝下且;
    private UnityEngine.Quaternion 丙丆与丅丈丑一且丏;
    private float 专丑与丏丏丑丘丛万;
    private float 世与一下丆东丘丝七;
    private VehicleController vehicleController;
    private UnityEngine.Vector3 丏丄业丆业丅且丏丗;
    private bool 丏丗丕丂不丑下不丕;
    
    // Properties
    private bool 丆丝业丒丞丙且万丌 { get; }
    internal override PhotonView 丐世丁不上与上丙专 { get; }
    
    // Methods
    internal CarSinc()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丛丞专下丄丐丝丟世 = val_1;
        mem[1152921536145877292] = val_1.y;
        mem[1152921536145877296] = val_1.z;
        this.丞丑丕七丕一且与丘 = 0.1f;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.丂丆七丑业一丏丞且 = val_2;
        mem[1152921536145877368] = val_2.y;
        mem[1152921536145877372] = val_2.z;
        mem[1152921536145877376] = val_2.w;
        this.世与一下丆东丘丝七 = 0.4f;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void CarSinc::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_5 = this.与丑丌丌丌丁丌不丕();
        val_5.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void CarSinc::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private bool 丘三世东不丒一丁丙()
    {
        return true;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        int val_3;
        var val_4;
        val_2 = 丞世不丒下上上丝丑;
        if((val_2 & 255) == 155)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
            if(val_3 == 0)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            if(val_3 <= 1)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            object val_3 = 专丒丌丆下丐丞丟丞[1];
            if(val_3 <= 2)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            object val_4 = 专丒丌丆下丐丞丟丞[2];
            object val_5 = 专丒丌丆下丐丞丟丞[3];
            this.丑下七七丑丝世丅业(丏丞丐丕七且丌丂丙:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V12.16B, z = V13.16B}, 丐丘丗上丂丒丐丟业:  new UnityEngine.Quaternion() {y = 专丒丌丆下丐丞丟丞[0], z = ???, w = ???}, 与丅丛不不丄万丞丄:  false);
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public void Update()
    {
        float val_30;
        float val_31;
        float val_32;
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_16;
        }
        
        if((this.photonViewStream.owner == null) || (this.photonViewStream.isMine == false))
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_30 = val_5.x;
        val_31 = val_5.z;
        this.photonViewStream.UpdateByPosition(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_30, y = val_5.y, z = val_31});
        if((((this.丏丗丕丂不丑下不丕 == true) ? 1 : 0) ^ this.vehicleController.丑丒丙与不丆三丏丌()) == false)
        {
            goto label_16;
        }
        
        this.丏丗丕丂不丑下不丕 = this.vehicleController.丑丒丙与不丆三丏丌();
        if(this.vehicleController.丑丒丙与不丆三丏丌() == true)
        {
            goto label_16;
        }
        
        goto label_16;
        label_8:
        this.photonViewStream.group = 0;
        label_16:
        this.m_Body.freezeRotation = (~this.photonView.isMine) & 1;
        if(this.photonView.isMine == true)
        {
                return;
        }
        
        if(this.vehicleController.丑丒丙与不丆三丏丌() == false)
        {
                return;
        }
        
        if((null != null) && (GameConnect.丝丆世丕丂丄万东且() != false))
        {
                if(this.vehicleController.且丛丄丗丞一丈丕丙() != 0)
        {
                if(val_18.丙丌丅丆丅世世七丛 == false)
        {
            goto label_33;
        }
        
        }
        
        }
        
        this.m_Body.velocity = new UnityEngine.Vector3() {x = this.丏丄业丆业丅且丏丗, y = V9.16B, z = V10.16B};
        val_30 = this.fraction;
        val_32 = this.世与一下丆东丘丝七;
        if(val_30 < 0)
        {
                UnityEngine.Vector3 val_21 = this.m_Transorm.position;
            float val_22 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丛丞专下丄丐丝丟世, y = V12.16B, z = V13.16B}, d:  val_22);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  this.世与一下丆东丘丝七);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            this.m_Transorm.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            UnityEngine.Quaternion val_26 = this.m_Transorm.rotation;
            float val_30 = 3f;
            val_30 = UnityEngine.Time.deltaTime * val_30;
            UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w}, b:  new UnityEngine.Quaternion() {x = this.丙丆与丅丈丑一且丏, y = V12.16B, z = V13.16B, w = val_22}, t:  val_30);
            val_31 = val_28.z;
            val_32 = val_28.x;
            this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = val_32, y = val_28.y, z = val_31, w = val_28.w};
            val_30 = this.fraction;
        }
        
        float val_29 = UnityEngine.Time.deltaTime;
        val_29 = val_30 + val_29;
        this.fraction = val_29;
        return;
        label_33:
        if(val_18.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
                return;
        }
        
        if(val_18.丁三三丒丌与丄丑丁 == false)
        {
                return;
        }
        
        this.m_Transorm.position = new UnityEngine.Vector3() {x = val_18.丄丈丐世丄丁与三不, y = V9.16B, z = V10.16B};
        this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = val_18.业丞丛丌丘丝丗三丙, y = V9.16B, z = V10.16B, w = V11.16B};
    }
    internal void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        object val_20;
        VehicleController val_21;
        VehicleEngine val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        val_20 = this;
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() == false)
        {
            goto label_2;
        }
        
        val_21 = this.vehicleController;
        if(val_21.丑丒丙与不丆三丏丌() == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.m_Body.velocity;
        val_22 = this.m_car;
        if(this.m_car != null)
        {
            goto label_6;
        }
        
        val_22 = this.m_car;
        if(val_22 == null)
        {
            goto label_7;
        }
        
        label_6:
        val_23 = this.m_car.maxSpeed;
        val_24 = this.m_car.maxSpeed * val_23;
        if(val_3.x > val_24)
        {
                val_25 = val_3.z;
            val_24 = val_24;
            val_23 = val_23;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24, y = val_23, z = val_25}, d:  this.m_car.maxSpeed);
        }
        
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
        UnityEngine.Vector3 val_5 = this.m_Transorm.position;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_5);
        UnityEngine.Quaternion val_6 = this.m_Transorm.rotation;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_6);
        val_26 = this.m_car.horizontal;
        float val_20 = 1000f;
        val_20 = val_26 * val_20;
        int val_7 = UnityEngine.Mathf.RoundToInt(f:  val_20);
        val_21 = val_7;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_7);
        int val_9 = System.Convert.ToInt32(value:  (this.m_car.isBrake == true) ? 1 : 0);
        val_20 = val_9;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_9);
        return;
        label_2:
        object val_10 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_21 = 1152921504838316032;
        this.丏丄业丆业丅且丏丗 = new UnityEngine.Vector3();
        mem[1152921536146746272] = ???;
        object val_11 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.下业丕七东丌丝下且 = new UnityEngine.Vector3();
        mem[1152921536146746224] = ???;
        object val_12 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丙丆与丅丈丑一且丏 = new UnityEngine.Quaternion();
        mem[1152921536146746232] = ???;
        mem[1152921536146746240] = ???;
        object val_13 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_27 = 1.152922E+18f;
        val_28 = val_27 / 1000f;
        this.m_car.horizontal = val_28;
        object val_14 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.m_car.isBrake = System.Convert.ToBoolean(value:  0);
        if(this.万七丆丝丙丛万丆丄 != true)
        {
                this.万七丆丝丙丛万丆丄 = true;
            this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = this.丙丆与丅丈丑一且丏, y = V9.16B, z = V10.16B, w = V11.16B};
            this.m_Transorm.position = new UnityEngine.Vector3() {x = this.下业丕七东丌丝下且, y = V9.16B, z = V10.16B};
            val_28 = this.丏丄业丆业丅且丏丗;
            val_27 = V9.16B;
            this.m_Body.velocity = new UnityEngine.Vector3() {x = val_28, y = val_27, z = V10.16B};
        }
        
        val_26 = this.下业丕七东丌丝下且;
        this.fraction = 0f;
        this.丟丆丏下一丐丘专业 = false;
        UnityEngine.Vector3 val_17 = this.m_Transorm.position;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        this.丛丞专下丄丐丝丟世 = val_18;
        mem[1152921536146746108] = val_18.y;
        mem[1152921536146746112] = val_18.z;
        UnityEngine.Quaternion val_19 = this.m_Transorm.rotation;
        this.丂丆七丑业一丏丞且 = val_19;
        mem[1152921536146746184] = val_19.y;
        mem[1152921536146746188] = val_19.z;
        mem[1152921536146746192] = val_19.w;
        return;
        label_7:
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        goto typeof(CarSinc).__il2cppRuntimeField_178;
    }
    internal override PhotonView 东丝丏东东上丌上丂()
    {
        return (PhotonView)this.photonViewStream;
    }
    internal override void 一与丙东世三不丕丟(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_14;
        var val_15;
        object val_16;
        val_14 = this;
        val_15 = this.photonView;
        if(val_15.isMine == false)
        {
                return;
        }
        
        val_15 = this.photonView;
        object[] val_4 = new object[4];
        UnityEngine.Vector3 val_5 = this.m_Body.velocity;
        if(专丞上七七且丝七丗 != null)
        {
                val_4[0] = val_5;
            UnityEngine.Vector3 val_6 = this.m_Transorm.position;
            val_4[1] = val_6;
            UnityEngine.Quaternion val_7 = this.m_Transorm.rotation;
            val_16 = val_7;
            val_4[2] = val_16;
            val_14 = this.vehicleController.丑丒丙与不丆三丏丌();
            val_4[3] = val_14;
            val_15.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_4);
            return;
        }
        
        val_16 = 1152921504838316032;
        val_4[0] = val_5;
        UnityEngine.Vector3 val_10 = this.m_Transorm.position;
        val_4[1] = val_10;
        UnityEngine.Quaternion val_11 = this.m_Transorm.rotation;
        val_4[2] = val_11;
        val_14 = this.vehicleController.丑丒丙与不丆三丏丌();
        val_4[3] = val_14;
        val_15.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
    }
    private void 丑下七七丑丝世丅业(UnityEngine.Vector3 丏丞丐丕七且丌丂丙, UnityEngine.Vector3 丙丆丗业丌丏业丒丝, UnityEngine.Quaternion 丐丘丗上丂丒丐丟业, bool 与丅丛不不丄万丞丄)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        val_4 = 丙丆丗业丌丏业丒丝.z;
        val_5 = 丏丞丐丕七且丌丂丙.z;
        与丅丛不不丄万丞丄 = 与丅丛不不丄万丞丄;
        this.vehicleController.丈不万专世丒丆丗丆(丙业与丙丗丝不丈东:  与丅丛不不丄万丞丄);
        if(this.万七丆丝丙丛万丆丄 != false)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
            if(与丅丛不不丄万丞丄 == true)
        {
                return;
        }
        
        }
        
        this.万七丆丝丙丛万丆丄 = true;
        val_4 = val_2;
        val_5 = val_3;
        this.m_Transorm.position = new UnityEngine.Vector3() {x = 丙丆丗业丌丏业丒丝.x, y = 丙丆丗业丌丏业丒丝.y, z = val_4};
        this.m_Transorm.rotation = new UnityEngine.Quaternion() {x = 丐丘丗上丂丒丐丟业.x, y = val_5, z = 丐丘丗上丂丒丐丟业.y, w = val_4};
        this.m_Body.velocity = new UnityEngine.Vector3() {x = 丏丞丐丕七且丌丂丙.x, y = 丏丞丐丕七且丌丂丙.y, z = val_5};
        this.东业七下丟东世丈丆 = this.丏丄业丆业丅且丏丗;
        mem[1152921536147520876] = System.Void TransportControllerBase::丈不万专世丒丆丗丆(bool 丙业与丙丗丝不丈东);
    }

}
