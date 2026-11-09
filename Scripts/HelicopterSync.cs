using UnityEngine;
internal class HelicopterSync : TransportSyncBase, 东丁丆一业丈万丆丐
{
    // Fields
    private bool 万七丆丝丙丛万丆丄;
    private float 丂上丌丂七世丘丘丈;
    private PhotonView photonViewStream;
    private HelicopterController controller;
    private HelicopterEngine engine;
    private UnityEngine.Transform body;
    private UnityEngine.Rigidbody 丕丗丏丏丒丈丐丝丈;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    private readonly float 业世丅三东丞丁丒一;
    private UnityEngine.Vector3 丙丆丗业丌丏业丒丝;
    private UnityEngine.Vector3 丝丕丅世上与万不且;
    private UnityEngine.Quaternion 丐丘丗上丂丒丐丟业;
    private UnityEngine.Quaternion 丂丟东下与丈专不丞;
    private float 丐下丕丝丙丑东丁上;
    private UnityEngine.Vector3 丏丞丐丕七且丌丂丙;
    private bool 丏丗丕丂不丑下不丕;
    
    // Properties
    internal override PhotonView 丐世丁不上与上丙专 { get; }
    
    // Methods
    internal HelicopterSync()
    {
        this.业世丅三东丞丁丒一 = 0.4f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丝丕丅世上与万不且 = val_1;
        mem[1152921539393642212] = val_1.y;
        mem[1152921539393642216] = val_1.z;
        Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
        val_2.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void HelicopterSync::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_4 = this.与丑丌丌丌丁丌不丕();
        val_4.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void HelicopterSync::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    protected override void Awake()
    {
        this.Awake();
        this.专专丏下丐丂丂丅东 = this.transform;
        this.丕丗丏丏丒丈丐丝丈 = this.GetComponent<UnityEngine.Rigidbody>();
    }
    private void Update()
    {
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_16;
        }
        
        if((this.photonViewStream.owner == null) || (this.photonViewStream.isMine == false))
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_4 = this.专专丏下丐丂丂丅东.position;
        val_27 = val_4.x;
        val_28 = val_4.z;
        this.photonViewStream.UpdateByPosition(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_27, y = val_4.y, z = val_28});
        if(((((this.丏丗丕丂不丑下不丕 == true) ? 1 : 0) ^ this.controller) & 1) == 0)
        {
            goto label_16;
        }
        
        this.丏丗丕丂不丑下不丕 = this.controller & 1;
        if((this.controller & 1) != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_8:
        this.photonViewStream.group = 0;
        label_16:
        val_29 = this.photonView.isMine;
        this.丕丗丏丏丒丈丐丝丈.freezeRotation = (~val_29) & 1;
        if(this.photonView.isMine == true)
        {
                return;
        }
        
        if((this.controller & 1) == 0)
        {
                if((this.controller.engine.<东丂丗丞丗丑丂丂业>k__BackingField) == true)
        {
                return;
        }
        
        }
        
        if(null != null)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                bool val_14 = UnityEngine.Object.op_Inequality(x:  this.controller, y:  0);
        }
        
        }
        
        this.丕丗丏丏丒丈丐丝丈.velocity = new UnityEngine.Vector3() {x = this.丏丞丐丕七且丌丂丙, y = V9.16B, z = V10.16B};
        val_27 = this.丂上丌丂七世丘丘丈;
        val_30 = this.业世丅三东丞丁丒一;
        if(val_27 < 0)
        {
                UnityEngine.Vector3 val_15 = this.专专丏下丐丂丂丅东.position;
            float val_16 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丝丕丅世上与万不且, y = V12.16B, z = V13.16B}, d:  val_16);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  this.业世丅三东丞丁丒一);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            this.专专丏下丐丂丂丅东.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.Quaternion val_20 = this.专专丏下丐丂丂丅东.rotation;
            float val_27 = 3f;
            val_27 = UnityEngine.Time.deltaTime * val_27;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, b:  new UnityEngine.Quaternion() {x = this.丐丘丗上丂丒丐丟业, y = V12.16B, z = V13.16B, w = val_16}, t:  val_27);
            this.专专丏下丐丂丂丅东.rotation = new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w};
            UnityEngine.Quaternion val_23 = this.body.rotation;
            float val_24 = UnityEngine.Time.deltaTime;
            val_24 = val_24 * 5f;
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w}, b:  new UnityEngine.Quaternion() {x = this.丂丟东下与丈专不丞, y = V12.16B, z = V13.16B, w = val_16}, t:  val_24);
            val_28 = val_25.z;
            val_30 = val_25.x;
            this.body.rotation = new UnityEngine.Quaternion() {x = val_30, y = val_25.y, z = val_28, w = val_25.w};
            val_29 = this.丐下丕丝丙丑东丁上;
            this.engine.且专三丞丞丂且不丝 = val_29;
            val_27 = this.丂上丌丂七世丘丘丈;
        }
        
        float val_26 = UnityEngine.Time.deltaTime;
        val_26 = val_27 + val_26;
        this.丂上丌丂七世丘丘丈 = val_26;
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
            this.丑下七七丑丝世丅业(丏丄业丆业丅且丏丗:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V12.16B, z = V13.16B}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {y = 专丒丌丆下丐丞丟丞[0], z = ???, w = ???}, 丘下丕下万专七丂上:  false);
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        object val_13;
        HelicopterEngine val_14;
        val_13 = this;
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                if((this.controller & 1) == 0)
        {
                val_14 = this.controller.engine;
            if((this.controller.engine.<东丂丗丞丗丑丂丂业>k__BackingField) == true)
        {
                return;
        }
        
        }
        
            UnityEngine.Vector3 val_2 = this.丕丗丏丏丒丈丐丝丈.velocity;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_2);
            UnityEngine.Vector3 val_3 = this.专专丏下丐丂丂丅东.position;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
            UnityEngine.Quaternion val_4 = this.专专丏下丐丂丂丅东.rotation;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
            UnityEngine.Quaternion val_5 = this.body.rotation;
            val_14 = val_5;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_5);
            val_13 = this.engine.且专三丞丞丂且不丝;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.engine.且专三丞丞丂且不丝);
            return;
        }
        
        object val_6 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_14 = 1152921504838316032;
        this.丏丞丐丕七且丌丂丙 = new UnityEngine.Vector3();
        mem[1152921539394520296] = ???;
        object val_7 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丙丆丗业丌丏业丒丝 = new UnityEngine.Vector3();
        mem[1152921539394520236] = ???;
        object val_8 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丐丘丗上丂丒丐丟业 = new UnityEngine.Quaternion();
        mem[1152921539394520256] = ???;
        mem[1152921539394520264] = ???;
        object val_9 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丂丟东下与丈专不丞 = new UnityEngine.Quaternion();
        mem[1152921539394520272] = ???;
        mem[1152921539394520280] = ???;
        object val_10 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丐下丕丝丙丑东丁上 = null;
        if(this.万七丆丝丙丛万丆丄 != true)
        {
                this.万七丆丝丙丛万丆丄 = true;
            this.专专丏下丐丂丂丅东.rotation = new UnityEngine.Quaternion() {x = this.丐丘丗上丂丒丐丟业, y = V9.16B, z = V10.16B, w = V11.16B};
            this.专专丏下丐丂丂丅东.position = new UnityEngine.Vector3() {x = this.丙丆丗业丌丏业丒丝, y = V9.16B, z = V10.16B};
            this.丕丗丏丏丒丈丐丝丈.velocity = new UnityEngine.Vector3() {x = this.丏丞丐丕七且丌丂丙, y = V9.16B, z = V10.16B};
        }
        
        this.丂上丌丂七世丘丘丈 = 0f;
        UnityEngine.Vector3 val_11 = this.专专丏下丐丂丂丅东.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丙丆丗业丌丏业丒丝, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        this.丝丕丅世上与万不且 = val_12;
        mem[1152921539394520244] = val_12.y;
        mem[1152921539394520248] = val_12.z;
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        goto typeof(HelicopterSync).__il2cppRuntimeField_178;
    }
    internal override PhotonView 东丝丏东东上丌上丂()
    {
        return (PhotonView)this.photonViewStream;
    }
    internal override void 一与丙东世三不丕丟(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_12;
        var val_13;
        object val_14;
        val_12 = this;
        val_13 = this.photonView;
        if(val_13.isMine == false)
        {
                return;
        }
        
        val_13 = this.photonView;
        object[] val_4 = new object[4];
        UnityEngine.Vector3 val_5 = this.丕丗丏丏丒丈丐丝丈.velocity;
        if(专丞上七七且丝七丗 != null)
        {
                val_4[0] = val_5;
            UnityEngine.Vector3 val_6 = this.专专丏下丐丂丂丅东.position;
            val_4[1] = val_6;
            UnityEngine.Quaternion val_7 = this.专专丏下丐丂丂丅东.rotation;
            val_14 = val_7;
            val_4[2] = val_14;
            val_12 = this.controller & 1;
            val_4[3] = val_12;
            val_13.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_4);
            return;
        }
        
        val_14 = 1152921504838316032;
        val_4[0] = val_5;
        UnityEngine.Vector3 val_9 = this.专专丏下丐丂丂丅东.position;
        val_4[1] = val_9;
        UnityEngine.Quaternion val_10 = this.专专丏下丐丂丂丅东.rotation;
        val_4[2] = val_10;
        val_12 = this.controller & 1;
        val_4[3] = val_12;
        val_13.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
    }
    private void 丑下七七丑丝世丅业(UnityEngine.Vector3 丏丄业丆业丅且丏丗, UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, bool 丘下丕下万专七丂上)
    {
        float val_1;
        float val_2;
        丘下丕下万专七丂上 = 丘下丕下万专七丂上;
        if(this.万七丆丝丙丛万丆丄 != false)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
            if(丘下丕下万专七丂上 == true)
        {
                return;
        }
        
        }
        
        this.万七丆丝丙丛万丆丄 = true;
        this.专专丏下丐丂丂丅东.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.专专丏下丐丂丂丅东.rotation = new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = val_2, z = 丙丆与丅丈丑一且丏.y, w = val_1};
        this.丕丗丏丏丒丈丐丝丈.velocity = new UnityEngine.Vector3() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y, z = 丏丄业丆业丅且丏丗.z};
    }

}
