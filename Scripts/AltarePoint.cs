using UnityEngine;
internal class AltarePoint : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    public System.Collections.Generic.List<float> pointForPlayer;
    public float timeForGivePoints;
    public float maxCapturePoint;
    private float 丘丅丆业世丂丝丝丐;
    private bool 上丘丅丅丝且丟业丅;
    internal bool 上万丁丛丛万丌丕丅;
    public System.Collections.Generic.List<Player_move_c> capturePlayers;
    private float 丟丛丘丘丟与丝业丑;
    private float captureRadius;
    private float 世万东丕一下丛业丌;
    private DamageableObjectWithoutDeath _damageableObject;
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    private static System.Action<AltarePoint> 丁丁丟丒一下丟与丂;
    private System.Action<float> 丏上丁丆下业丁丁七;
    
    // Properties
    public bool 上丕丂丆丘专丆丘业 { get; set; }
    public float 一丕丞丐丘丈三且丐 { get; }
    
    // Methods
    public bool get_ActivateScenario()
    {
        return (bool)this.上丘丅丅丝且丟业丅;
    }
    public void set_ActivateScenario(bool 丙业与丙丗丝不丈东)
    {
        this.上丘丅丅丝且丟业丅 = 丙业与丙丗丝不丈东;
    }
    public float get_CurrentCapturePoint()
    {
        return (float)this.丟丛丘丘丟与丝业丑;
    }
    internal static void 与一丕丞丈丆七丑丞(System.Action<AltarePoint> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  AltarePoint.丁丁丟丒一下丟与丂, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丒下丏丙万世不世丁(System.Action<AltarePoint> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  AltarePoint.丁丁丟丒一下丟与丂, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal void 丐专三丁丘丈丘丝丅(System.Action<float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏上丁丆下业丁丁七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏上丁丆下业丁丁七 != 1152921540010622648);
    
    }
    internal void 丘业下上且丗丈且丙(System.Action<float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏上丁丆下业丁丁七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏上丁丆下业丁丁七 != 1152921540010759224);
    
    }
    private void Awake()
    {
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        if((UnityEngine.Object.op_Implicit(exists:  this._damageableObject)) == false)
        {
                return;
        }
        
        this._damageableObject.下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void AltarePoint::丞专丂七丛七与且丂(float 丅专与丒丈丗丒丘丌)));
    }
    private void Start()
    {
        if(AltarePoint.丁丁丟丒一下丟与丂 == null)
        {
                return;
        }
        
        AltarePoint.丁丁丟丒一下丟与丂.Invoke(obj:  this);
    }
    private void OnDestroy()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._damageableObject)) != false)
        {
                this._damageableObject.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void AltarePoint::丞专丂七丛七与且丂(float 丅专与丒丈丗丒丘丌)));
        }
        
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    internal void 丞丑丌下丛丙丄丁七(System.Collections.Generic.List<float> 丑七丐丈下世丆丞丟)
    {
        this.pointForPlayer.Clear();
        this.pointForPlayer.AddRange(collection:  丑七丐丈下世丆丞丟);
    }
    private void Update()
    {
        var val_15;
        System.Predicate<Player_move_c> val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        if(this.上丘丅丅丝且丟业丅 == false)
        {
                return;
        }
        
        this.丏世丞丗七三丂专丈();
        val_15 = null;
        val_15 = null;
        val_17 = AltarePoint.<>c.<>9__27_0;
        if(val_17 == null)
        {
            goto label_4;
        }
        
        label_17:
        int val_1 = this.capturePlayers.RemoveAll(match:  val_17);
        if(this.capturePlayers.Count < 1)
        {
            goto label_7;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丘丅丆业世丂丝丝丐 + val_3;
        this.丘丅丆业世丂丝丝丐 = val_3;
        if(val_3 < this.timeForGivePoints)
        {
                return;
        }
        
        if(this.capturePlayers.Count <= this.pointForPlayer.Count)
        {
            goto label_11;
        }
        
        val_18 = this.pointForPlayer;
        int val_6 = val_18.Count;
        goto label_13;
        label_4:
        AltarePoint.<>c.<>9__27_0 = new System.Predicate<Player_move_c>(object:  AltarePoint.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AltarePoint.<>c::丟世丘东专丛丕上与(Player_move_c 三丟东丕丄丄下下丑));
        if(this.capturePlayers != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_11:
        System.Collections.Generic.List<Player_move_c> val_15 = this.capturePlayers;
        val_18 = val_15;
        label_13:
        val_17 = this.pointForPlayer;
        val_15 = val_18.Count - 1;
        if(this.丟丛丘丘丟与丝业丑 < 0)
        {
                val_19 = null;
            val_19 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_20 = null;
            val_20 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_21 = null;
            val_21 = null;
            val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if((this.capturePlayers.Contains(item:  val_17)) != false)
        {
                val_17 = 1152921505058603008;
            val_22 = null;
            val_22 = null;
            if(DungeonsController.丄丘七三上丕世丞业 != 0)
        {
                val_23 = null;
            val_23 = null;
            DungeonsController.丄丘七三上丕世丞业.丌丁丏丅且丗下丕丐(丌丗万且世丞丏与下:  124);
        }
        
            if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                val_24 = null;
            val_24 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  134, 专上丝且丂世丛丝丒:  1f);
        }
        
        }
        
        }
        
        }
        
        }
        
        this.丝丙丁下丁与丝丙丝(丅专与丒丈丗丒丘丌:  val_17.Item[val_15]);
        label_7:
        this.丘丅丆业世丂丝丝丐 = 0f;
    }
    private void 丏世丞丗七三丂专丈()
    {
        object val_5;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Generic.List<Player_move_c> val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_21 = this;
        val_22 = null;
        val_22 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        List.Enumerator<T> val_3 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_25 = 1152921525761785056;
        val_26 = 1152921504838316032;
        goto label_62;
        label_78:
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((X21 == 0) || (((X21 + 352) == 0) || ((X21 + 352 + 349) == 0)))
        {
            goto label_25;
        }
        
        val_27 = mem[X21 + 352 + 352];
        val_27 = X21 + 352 + 352;
        if((X21 + 352 + 352 + 92) != 0)
        {
            goto label_62;
        }
        
        label_25:
        if((X21 + 352 + 352 + 92) == 0)
        {
            goto label_29;
        }
        
        label_56:
        val_27 = this.capturePlayers;
        if((val_27.Contains(item:  val_6)) == false)
        {
            goto label_62;
        }
        
        this.丆专丘丕丝不一丝与(丒一丄丗丞丗丄丐丂:  val_6);
        val_28 = null;
        val_28 = null;
        val_27 = WeaponManager.丟丗丄业丘丗业丗七;
        if((val_6 & 1) == 0)
        {
            goto label_62;
        }
        
        object[] val_10 = new object[2];
        val_27 = val_10;
        val_29 = null;
        val_29 = null;
        val_5 = typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32;
        val_27[0] = val_5;
        val_27[1] = (float)丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  51, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_10);
        val_26 = val_26;
        val_25 = 1152921525761785056;
        goto label_62;
        label_29:
        UnityEngine.Vector3 val_13 = val_6.transform.position;
        UnityEngine.Vector3 val_15 = this.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z})) >= 0)
        {
            goto label_56;
        }
        
        val_27 = this.capturePlayers;
        if((val_27.Contains(item:  val_6)) != true)
        {
                this.丘不丕不世三丒丄丄(丒一丄丗丞丗丄丐丂:  val_6);
            val_30 = null;
            val_30 = null;
            val_27 = WeaponManager.丟丗丄业丘丗业丗七;
            if((val_6 & 1) != 0)
        {
                object[] val_18 = new object[2];
            val_27 = val_18;
            val_31 = null;
            val_31 = null;
            val_5 = typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32;
            val_27[0] = val_5;
            val_27[1] = (float)丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  5, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_18);
        }
        
        }
        
        label_62:
        if((1045058912 & 1) != 0)
        {
            goto label_78;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞专丂七丛七与且丂(float 丅专与丒丈丗丒丘丌)
    {
        float val_2;
        float val_3;
        val_2 = 丅专与丒丈丗丒丘丌;
        if(this.上丘丅丅丝且丟业丅 == false)
        {
                return;
        }
        
        val_2 = val_2 * 0.3f;
        val_3 = this.丟丛丘丘丟与丝业丑;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_3 = val_3 - val_2;
            this.丟丛丘丘丟与丝业丑 = val_3;
        }
        
        float val_2 = this.世万东丕一下丛业丌;
        val_2 = val_2 - val_2;
        this.世万东丕一下丛业丌 = val_2;
        if(val_3 < 0)
        {
                this.丟丛丘丘丟与丝业丑 = 0f;
        }
        
        if(val_2 < 0)
        {
                this.世万东丕一下丛业丌 = 0f;
        }
        
        if(this.丏上丁丆下业丁丁七 == null)
        {
                return;
        }
        
        this.丏上丁丆下业丁丁七.Invoke(obj:  0f);
    }
    private void 丝丙丁下丁与丝丙丝(float 丅专与丒丈丗丒丘丌)
    {
        float val_2;
        if(this.上丘丅丅丝且丟业丅 == false)
        {
                return;
        }
        
        val_2 = this.丟丛丘丘丟与丝业丑;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_2 = val_2 + 丅专与丒丈丗丒丘丌;
            this.丟丛丘丘丟与丝业丑 = val_2;
        }
        
        float val_2 = this.世万东丕一下丛业丌;
        val_2 = val_2 + 丅专与丒丈丗丒丘丌;
        this.世万东丕一下丛业丌 = val_2;
        if(val_2 > this.maxCapturePoint)
        {
                this.丟丛丘丘丟与丝业丑 = this.maxCapturePoint;
        }
        
        if(val_2 > this.maxCapturePoint)
        {
                this.世万东丕一下丛业丌 = this.maxCapturePoint;
        }
        
        if(this.丏上丁丆下业丁丁七 == null)
        {
                return;
        }
        
        this.丏上丁丆下业丁丁七.Invoke(obj:  this.maxCapturePoint);
    }
    internal AltarePoint()
    {
        this.capturePlayers = new System.Collections.Generic.List<Player_move_c>();
        this.captureRadius = 10f;
        Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
        val_2.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void AltarePoint::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void 丘不丕不世三丒丄丄(Player_move_c 丒一丄丗丞丗丄丐丂)
    {
        if((this.capturePlayers.Contains(item:  丒一丄丗丞丗丄丐丂)) != false)
        {
                return;
        }
        
        this.capturePlayers.Add(item:  丒一丄丗丞丗丄丐丂);
    }
    private void 丆专丘丕丝不一丝与(Player_move_c 丒一丄丗丞丗丄丐丂)
    {
        if((this.capturePlayers.Contains(item:  丒一丄丗丞丗丄丐丂)) == false)
        {
                return;
        }
        
        bool val_2 = this.capturePlayers.Remove(item:  丒一丄丗丞丗丄丐丂);
    }
    private void 丕丞丙丈丞丞丂丏丞(int 世一丐丗且丈东东世, float 七三丗丙丏丘丘丅上)
    {
        var val_6;
        var val_7;
        var val_8;
        Player_move_c val_9;
        var val_10;
        var val_11;
        val_6 = 0;
        goto label_1;
        label_20:
        val_7 = null;
        val_7 = null;
        Player_move_c val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(val_1.photonView.ownerId == 世一丐丗且丈东东世)
        {
                val_8 = null;
            val_8 = null;
            val_9 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if((this.capturePlayers.Contains(item:  val_9)) != true)
        {
                val_10 = null;
            val_10 = null;
            val_9 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            this.capturePlayers.Add(item:  val_9);
        }
        
        }
        
        val_6 = 1;
        label_1:
        val_11 = null;
        val_11 = null;
        if(val_6 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_20;
        }
    
    }
    private void 丝三丘丙万三与丙丛(int 世一丐丗且丈东东世, float 七三丗丙丏丘丘丅上)
    {
        System.Collections.Generic.List<Player_move_c> val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = 世一丐丗且丈东东世;
        val_8 = 0;
        goto label_1;
        label_11:
        val_9 = null;
        val_9 = null;
        Player_move_c val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(val_1.photonView.ownerId == val_7)
        {
            goto label_7;
        }
        
        val_8 = 1;
        label_1:
        val_10 = null;
        val_10 = null;
        if(val_8 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_11;
        }
        
        return;
        label_7:
        val_11 = null;
        val_7 = this.capturePlayers;
        val_11 = null;
        if((val_7.Contains(item:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0])) == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        bool val_6 = this.capturePlayers.Remove(item:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0]);
    }
    internal void 三丂丐且丕丆世丁下()
    {
        System.Collections.Generic.List<Player_move_c> val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_7 = null;
        val_4 = this.capturePlayers;
        val_7 = null;
        if((val_4.Contains(item:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        DungeonsController.丄丘七三上丕世丞业.丌丁丏丅且丗下丕丐(丌丗万且世丞丏与下:  125);
    }
    internal void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.世万东丕一下丛业丌);
            return;
        }
        
        object val_2 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        if(null == this.丟丛丘丘丟与丝业丑)
        {
                return;
        }
        
        if(this.丏上丁丆下业丁丁七 == null)
        {
                return;
        }
        
        this.丟丛丘丘丟与丝业丑 = null;
        this.世万东丕一下丛业丌 = null;
        this.丏上丁丆下业丁丁七.Invoke(obj:  3.782474E-38f);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        int val_3;
        int val_4;
        var val_5;
        val_2 = 丞世不丒下上上丝丑;
        byte val_1 = val_2 & 255;
        if(val_1 == 51)
        {
            goto label_1;
        }
        
        if(val_1 != 5)
        {
            goto label_2;
        }
        
        val_3 = 专丒丌丆下丐丞丟丞.Length;
        if(val_3 == 0)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        object val_3 = 专丒丌丆下丐丞丟丞[1];
        this.丕丞丙丈丞丞丂丏丞(世一丐丗且丈东东世:  21884928, 七三丗丙丏丘丘丅上:  null);
        goto label_6;
        label_1:
        val_4 = 专丒丌丆下丐丞丟丞.Length;
        if(val_4 == 0)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        object val_5 = 专丒丌丆下丐丞丟丞[1];
        this.丝三丘丙万三与丙丛(世一丐丗且丈东东世:  21884928, 七三丗丙丏丘丘丅上:  null);
        label_6:
        val_5 = 1;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
    }

}
