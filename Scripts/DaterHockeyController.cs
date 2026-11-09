using UnityEngine;
internal class DaterHockeyController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    public float coefForce;
    public int score1;
    public int score2;
    private bool 万且丐丁丑丕丑万丛;
    private float 上丁丕丟丞丘丁东丙;
    private float 丁丂三丄与不丆丟丙;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private UnityEngine.Rigidbody 丐不丝丝业一丘丝一;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    private UnityEngine.Vector3 东丝丆丕专丙业丑世;
    private bool 丐下丈丗丟专世丞东;
    private bool 丟丌丈世丏丙丗丐丅;
    private UnityEngine.Vector3 丏丆业丐丈世丟不下;
    private UnityEngine.Quaternion 丅丗丒专丑丘万丟丌;
    private bool 丌且下丕下下丌万丞;
    
    // Methods
    private void Awake()
    {
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        this.丐不丝丝业一丘丝一 = this.GetComponent<UnityEngine.Rigidbody>();
        UnityEngine.Transform val_3 = this.transform;
        this.万一丂丐丄丁上与丟 = val_3;
        UnityEngine.Vector3 val_4 = val_3.position;
        this.东丝丆丕专丙业丑世 = val_4;
        mem[1152921525887706332] = val_4.y;
        mem[1152921525887706336] = val_4.z;
    }
    internal DaterHockeyController()
    {
        this.coefForce = 200f;
        this.上丁丕丟丞丘丁东丙 = 0.3f;
        this.丁丂三丄与不丆丟丙 = -1f;
        this.丐下丈丗丟专世丞东 = true;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void DaterHockeyController::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void Start()
    {
        var val_2;
        bool val_4;
        val_2 = null;
        val_2 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_6;
        }
        
        val_4 = this.丄丈丑丐丆丞丘与丗.isMine;
        goto label_10;
        label_3:
        val_4 = true;
        if(this != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        this.丌且下丕下下丌万丞 = val_4;
        return;
        label_6:
        if(this != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    private void Update()
    {
        var val_15;
        float val_16;
        float val_17;
        var val_18;
        if(this.万且丐丁丑丕丑万丛 != false)
        {
                val_15 = null;
            val_15 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                this.万且丐丁丑丕丑万丛 = false;
        }
        else
        {
                if(this.万且丐丁丑丕丑万丛 != false)
        {
                val_16 = this.丁丂三丄与不丆丟丙;
            val_17 = val_16 - UnityEngine.Time.deltaTime;
            this.丁丂三丄与不丆丟丙 = val_17;
            if(val_17 < 0)
        {
                this.丁丂三丄与不丆丟丙 = this.上丁丕丟丞丘丁东丙;
            UnityEngine.Vector3 val_3 = this.万一丂丐丄丁上与丟.position;
            val_18 = null;
            val_16 = val_3.x;
            val_18 = null;
            UnityEngine.Vector3 val_4 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            val_17 = val_16;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.coefForce);
            this.丅丙且丁一丆世丘丞(丒丕一丕东丕丑丆丅:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        }
        
        }
        
        }
        
        }
        
        if(this.丌且下丕下下丌万丞 != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = this.万一丂丐丄丁上与丟.position;
        float val_9 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.丏丆业丐丈世丟不下, y = val_4.x, z = val_4.y}, t:  val_9 * 5f);
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Quaternion val_12 = this.万一丂丐丄丁上与丟.rotation;
        float val_15 = 5f;
        val_15 = UnityEngine.Time.deltaTime * val_15;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, b:  new UnityEngine.Quaternion() {x = this.丅丗丒专丑丘万丟丌, y = val_4.y, z = val_8.z, w = val_9}, t:  val_15);
        this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
    }
    private void OnTriggerEnter(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_16;
        Player_move_c val_17;
        var val_18;
        val_16 = null;
        val_16 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_17 != 0)
        {
                val_17 = 且丙与丏下丅丐世丑.gameObject.transform.parent;
            if(val_17 != 0)
        {
                val_18 = null;
            val_17 = 且丙与丏下丅丐世丑.gameObject.transform.parent;
            val_18 = null;
            if((val_17.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_378)) != false)
        {
                this.万且丐丁丑丕丑万丛 = true;
            return;
        }
        
        }
        
        }
        
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        val_17 = 且丙与丏下丅丐世丑.gameObject.name;
        if((val_17.Equals(value:  "Gates1")) != false)
        {
                this.上丌丈丂业专丑丕丈();
        }
        
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if((且丙与丏下丅丐世丑.gameObject.name.Equals(value:  "Gates2")) == false)
        {
                return;
        }
        
        this.上丌丈丂业专丑丕丈();
    }
    private void OnTriggerExit(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_13;
        Player_move_c val_14;
        var val_15;
        val_13 = null;
        val_13 = null;
        val_14 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_14 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_14 != 0)
        {
                val_14 = 且丙与丏下丅丐世丑.gameObject.transform.parent;
            if(val_14 != 0)
        {
                val_15 = null;
            val_14 = 且丙与丏下丅丐世丑.gameObject.transform.parent;
            val_15 = null;
            if((val_14.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_378)) != false)
        {
                this.万且丐丁丑丕丑万丛 = false;
        }
        
        }
        
        }
        
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if((且丙与丏下丅丐世丑.gameObject.name.Equals(value:  "Stadium")) == false)
        {
                return;
        }
        
        this.上丌丈丂业专丑丕丈();
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        if((丞世不丒下上上丝丑 & 255) == 2)
        {
                object val_2 = 专丒丌丆下丐丞丟丞[0];
            this.丛丟三丒丛世专丆丞(丒丕一丕东丕丑丆丅:  new UnityEngine.Vector3() {x = 3.782474E-38f});
            val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    private void 丛丟三丒丛世专丆丞(UnityEngine.Vector3 丒丕一丕东丕丑丆丅)
    {
        this.GetComponent<UnityEngine.Rigidbody>().AddForce(force:  new UnityEngine.Vector3() {x = 丒丕一丕东丕丑丆丅.x, y = 丒丕一丕东丕丑丆丅.y, z = 丒丕一丕东丕丑丆丅.z});
    }
    private void 丅丙且丁一丆世丘丞(UnityEngine.Vector3 丒丕一丕东丕丑丆丅)
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                object[] val_1 = new object[1];
            val_1[0] = 丒丕一丕东丕丑丆丅;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  2, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        this.丛丟三丒丛世专丆丞(丒丕一丕东丕丑丆丅:  new UnityEngine.Vector3() {x = 丒丕一丕东丕丑丆丅.x, y = 丒丕一丕东丕丑丆丅.y, z = 丒丕一丕东丕丑丆丅.z});
    }
    private void 上丌丈丂业专丑丕丈()
    {
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = this.东丝丆丕专丙业丑世, y = V9.16B, z = V10.16B};
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丐不丝丝业一丘丝一.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丐不丝丝业一丘丝一.angularVelocity = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.丟丌丈世丏丙丗丐丅 = true;
    }
    private void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        object val_11;
        object val_12;
        val_11 = this;
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                UnityEngine.Vector3 val_2 = this.万一丂丐丄丁上与丟.position;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_2);
            UnityEngine.Quaternion val_3 = this.万一丂丐丄丁上与丟.rotation;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
            UnityEngine.Vector3 val_4 = this.丐不丝丝业一丘丝一.velocity;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
            UnityEngine.Vector3 val_5 = this.丐不丝丝业一丘丝一.angularVelocity;
            val_12 = val_5;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_5);
            val_11 = this.丟丌丈世丏丙丗丐丅;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丟丌丈世丏丙丗丐丅);
            return;
        }
        
        object val_6 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丏丆业丐丈世丟不下 = new UnityEngine.Vector3();
        mem[1152921525889288416] = ???;
        object val_7 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丅丗丒专丑丘万丟丌 = new UnityEngine.Quaternion();
        mem[1152921525889288424] = ???;
        mem[1152921525889288432] = ???;
        object val_8 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丐不丝丝业一丘丝一.velocity = new UnityEngine.Vector3() {x = 3.782474E-38f};
        val_12 = this.丐不丝丝业一丘丝一;
        object val_9 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_12.angularVelocity = new UnityEngine.Vector3() {x = 3.782474E-38f};
        object val_10 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丟丌丈世丏丙丗丐丅 = null;
        if(this.丐下丈丗丟专世丞东 == false)
        {
                return;
        }
        
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = this.丏丆业丐丈世丟不下, y = V9.16B, z = V10.16B};
        this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = this.丅丗丒专丑丘万丟丌, y = V9.16B, z = V10.16B, w = V11.16B};
        this.丐下丈丗丟专世丞东 = false;
        this.丟丌丈世丏丙丗丐丅 = false;
    }

}
