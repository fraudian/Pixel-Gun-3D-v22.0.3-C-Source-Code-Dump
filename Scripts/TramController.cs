using UnityEngine;
public class TramController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal static TramController 丄丘七三上丕世丞业;
    public TramPath startPath;
    public System.Collections.Generic.List<TramPath> allPath;
    public System.Collections.Generic.List<TramPath> checkpoints;
    public TramObject tramObject;
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    private System.Collections.Generic.List<Player_move_c> 丟丟丝丄丑与专专不;
    public float timeToSyncTram;
    public float timeToMoveBack;
    private double 七丁下丝万丆业丁丗;
    private float 上东丌万上丝丕不丛;
    private float 下且东三丂丈七万万;
    private int 丛业丂丈与丞丁丈丏;
    private float 丐丕丈丑丁丝不业丝;
    
    // Methods
    private void Awake()
    {
        TramPath val_20;
        var val_21;
        System.Action<与丅丕丈丘东丝世丟> val_22;
        TramController.丄丘七三上丕世丞业 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        this.allPath = new System.Collections.Generic.List<TramPath>();
        this.checkpoints = new System.Collections.Generic.List<TramPath>();
        val_20 = this.startPath;
        goto label_29;
        label_32:
        this.startPath.distance = 0f;
        this.startPath.myIndex = this.allPath.Count;
        this.startPath.distancePoint = this.下且东三丂丈七万万;
        if(this.startPath.next != 0)
        {
                UnityEngine.Vector3 val_7 = this.startPath.next.transform.position;
            UnityEngine.Vector3 val_9 = val_20.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.startPath.distance = val_10.x;
            val_10.x = val_10.x + this.下且东三丂丈七万万;
            this.下且东三丂丈七万万 = val_10.x;
        }
        
        if(this.startPath.next != this.startPath)
        {
                this.allPath.Add(item:  val_20);
            val_20 = this.startPath.next;
        }
        else
        {
                val_20 = 0;
        }
        
        if(val_20 != 0)
        {
                if(0 == 0)
        {
                if(64 != 0)
        {
            goto label_29;
        }
        
        }
        
            this.checkpoints.Add(item:  val_20);
            if((64 == 0) && (0 != 0))
        {
                mem[100] = 0;
        }
        
        }
        
        label_29:
        if(val_20 != 0)
        {
            goto label_32;
        }
        
        this.丟丟丝丄丑与专专不 = new System.Collections.Generic.List<Player_move_c>(capacity:  10);
        val_21 = null;
        val_21 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TramController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_22 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_22;
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TramController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    private void Update()
    {
        TramObject val_19;
        float val_20;
        var val_21;
        var val_22;
        int val_23;
        var val_24;
        var val_25;
        bool val_26;
        var val_27;
        bool val_28;
        val_19 = this;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_20 = this.上东丌万上丝丕不丛 - UnityEngine.Time.deltaTime;
            this.上东丌万上丝丕不丛 = val_20;
            if(this.tramObject != 0)
        {
                val_20 = this.上东丌万上丝丕不丛;
            if(val_20 <= 0f)
        {
                this.上东丌万上丝丕不丛 = this.timeToSyncTram;
            object[] val_4 = new object[1];
            val_4[0] = this.tramObject.allPathProgress;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
        }
        
        }
        
        }
        
        val_21 = 1152921505295769600;
        val_22 = 0;
        val_23 = 0;
        val_24 = 0;
        goto label_14;
        label_30:
        if(this.丟丟丝丄丑与专专不.Item[0] == 0)
        {
            goto label_28;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_21;
        }
        
        val_25 = null;
        val_25 = null;
        val_21 = 1152921505295769600;
        if(val_5.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝() != SiegeController.三三万丆下一丗万丛.attackTeam)
        {
            goto label_27;
        }
        
        label_21:
        val_23 = 1;
        val_24 = 1;
        goto label_28;
        label_27:
        label_28:
        val_22 = 1;
        label_14:
        if(val_22 < this.丟丟丝丄丑与专专不.Count)
        {
            goto label_30;
        }
        
        if((val_24 & 1) != 0)
        {
                this.七丁下丝万丆业丁丗 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                double val_18 = (double)this.timeToMoveBack;
            val_18 = this.七丁下丝万丆业丁丗 + val_18;
            var val_14 = (丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > val_18) ? 1 : 0;
        }
        else
        {
                val_26 = false;
        }
        
        var val_19 = 1;
        val_19 = val_24 & (~val_19);
        val_19 = val_19 & 1;
        val_19 = val_26 | val_19;
        if(val_19 == 0)
        {
            goto label_40;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_43;
        }
        
        val_27 = null;
        val_28 = (~SiegeController.三三万丆下一丗万丛.isRoundEnding) & 1;
        goto label_48;
        label_40:
        val_28 = 0;
        goto label_48;
        label_43:
        val_28 = true;
        label_48:
        if(this.tramObject == 0)
        {
                return;
        }
        
        val_19 = this.tramObject;
        this.tramObject.isMoving = val_28;
        this.tramObject.movingBackward = val_26;
        this.tramObject.丅七丌东丛丒丒不丅 = val_23;
    }
    public void RegisterMyPlayerInTram(bool 东丝丁下丁东且丑业)
    {
        PhotonView val_5;
        var val_6;
        var val_7;
        var val_8;
        System.Object[] val_9;
        var val_10;
        var val_11;
        var val_12;
        val_5 = this;
        val_6 = null;
        if(东丝丁下丁东且丑业 != false)
        {
                val_7 = null;
            if((this.丏丄丞不丄且丐丅不(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
                return;
        }
        
            val_5 = this.丄丈丑丐丆丞丘与丗;
            val_8 = null;
            val_9 = new object[1];
            val_8 = null;
            val_9[0] = typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32;
            val_10 = 129;
        }
        else
        {
                val_11 = null;
            if((this.七丏一丞与七丒丈丏(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
                return;
        }
        
            val_5 = this.丄丈丑丐丆丞丘与丗;
            object[] val_4 = new object[1];
            val_12 = null;
            val_9 = val_4;
            val_12 = null;
            val_9[0] = typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32;
            val_10 = 156;
        }
        
        val_5.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  156, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
    }
    public void OnCheckpointReached(TramPath 丛丄业丕且丗下一万)
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        int val_14;
        string val_15;
        var val_16;
        var val_17;
        Player_move_c val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = SiegeController.三三万丆下一丗万丛;
        if(val_9.isRoundEnding == true)
        {
                return;
        }
        
        if(丛丄业丕且丗下一万.wasReached != false)
        {
                return;
        }
        
        丛丄业丕且丗下一万.wasReached = true;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_11 = null;
            val_11 = null;
            val_12 = null;
            if(SiegeController.三三万丆下一丗万丛.inAttackTeam != false)
        {
                val_13 = null;
            val_14 = SiegeController.三三万丆下一丗万丛;
            val_15 = "Key_4638";
        }
        else
        {
                val_16 = null;
            val_14 = SiegeController.三三万丆下一丗万丛;
            val_15 = "Key_4642";
        }
        
            val_14.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15), 专业万丗丐丙丕丕下:  false);
        }
        
        val_17 = null;
        val_17 = null;
        val_18 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_18 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_18 != 0)
        {
                val_19 = null;
            val_19 = null;
            val_18 = SiegeController.三三万丆下一丗万丛;
            if(val_18.inAttackTeam != false)
        {
                val_20 = null;
            val_18 = this.丟丟丝丄丑与专专不;
            val_20 = null;
            if((val_18.Contains(item:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) != false)
        {
                val_21 = null;
            val_21 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  110, 专上丝且丂世丛丝丒:  1f);
            int val_9 = this.丛业丂丈与丞丁丈丏;
            val_9 = val_9 + 1;
            this.丛业丂丈与丞丁丈丏 = val_9;
        }
        
        }
        
        }
        
        val_22 = null;
        val_22 = null;
        SiegeController.三三万丆下一丗万丛.AddRoundTime(丂三丟丂丈丐丆丗丟:  丛丄业丕且丗下一万.checkpointAddTime);
    }
    public void OnEndReached(TramPath 丛丄业丕且丗下一万)
    {
        Player_move_c val_10;
        InGameGUI val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        string val_21;
        var val_22;
        val_11 = this;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        if(丛丄业丕且丗下一万.wasReached == true)
        {
                return;
        }
        
        丛丄业丕且丗下一万.wasReached = true;
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_13 = null;
            val_13 = null;
            if(SiegeController.三三万丆下一丗万丛.inAttackTeam != false)
        {
                val_14 = null;
            val_14 = null;
            val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if((this.丟丟丝丄丑与专专不.Contains(item:  val_10)) != false)
        {
                val_15 = null;
            val_15 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  110, 专上丝且丂世丛丝丒:  1f);
            val_10 = this.丛业丂丈与丞丁丈丏 + 1;
            this.丛业丂丈与丞丁丈丏 = val_10;
            if(val_10 >= this.checkpoints.Count)
        {
                val_16 = null;
            val_16 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  111, 专上丝且丂世丛丝丒:  1f);
        }
        
        }
        
        }
        
        }
        
        val_11 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_11 == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        val_18 = null;
        if(SiegeController.三三万丆下一丗万丛.inAttackTeam != false)
        {
                val_19 = null;
            val_20 = SiegeController.三三万丆下一丗万丛;
            val_21 = "Key_4639";
        }
        else
        {
                val_22 = null;
            val_20 = SiegeController.三三万丆下一丗万丛;
            val_21 = "Key_4643";
        }
        
        val_20.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_21), 专业万丗丐丙丕丕下:  false);
    }
    private bool 丏丄丞不丄且丐丅不(Player_move_c 专丞上七七且丝七丗)
    {
        var val_2;
        if((this.丟丟丝丄丑与专专不.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.丟丟丝丄丑与专专不.Add(item:  专丞上七七且丝七丗);
        val_2 = 1;
        return (bool)val_2;
    }
    private bool 七丏一丞与七丒丈丏(Player_move_c 专丞上七七且丝七丗)
    {
        var val_3;
        if((this.丟丟丝丄丑与专专不.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                bool val_2 = this.丟丟丝丄丑与专专不.Remove(item:  专丞上七七且丝七丗);
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public void ResetForNewMatch()
    {
        var val_3;
        this.丟丟丝丄丑与专专不.Clear();
        this.七丁下丝万丆业丁丗 = 0;
        this.tramObject.丐上丁丛丞丘东三不 = 0f;
        this.tramObject.isMoving = false;
        this.tramObject.movingBackward = false;
        this.tramObject.丐丁丛丗专丛丆丄丞 = false;
        this.tramObject.allPathProgress = 0f;
        this.tramObject.七丒下丂丝且丕丌东();
        val_3 = 0;
        goto label_4;
        label_8:
        TramPath val_1 = this.checkpoints.Item[0];
        val_3 = 1;
        val_1.wasReached = false;
        label_4:
        if(val_3 < this.checkpoints.Count)
        {
            goto label_8;
        }
        
        this.丛业丂丈与丞丁丈丏 = 0;
    }
    public TramPath GetPathByIndex(int 丞世不丒下上上丝丑)
    {
        System.Collections.Generic.List<TramPath> val_4;
        var val_5;
        val_4 = this.allPath;
        if(val_4.Count > 丞世不丒下上上丝丑)
        {
                val_4 = this.allPath;
            if((val_4.Count & 2147483648) == 0)
        {
                TramPath val_3 = this.allPath.Item[丞世不丒下上上丝丑];
            return (TramPath)val_5;
        }
        
        }
        
        val_5 = 0;
        return (TramPath)val_5;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_3;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        val_3 = 0;
        if((val_1 - 155) <= 4)
        {
                var val_3 = 106023892;
            val_3 = (106023892 + (((丞世不丒下上上丝丑 & 255) - 155)) << 2) + val_3;
        }
        else
        {
                if(val_1 != 129)
        {
                return (bool)val_3;
        }
        
            object val_5 = 专丒丌丆下丐丞丟丞[0];
            this.万丄东七丒专丕丒丛(业上上丏丄不上丅丈:  21884928);
            val_3 = 1;
            return (bool)val_3;
        }
    
    }
    private void 万丄东七丒专丕丒丛(int 业上上丏丄不上丅丈)
    {
        int val_6;
        var val_7;
        val_6 = 业上上丏丄不上丅丈;
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_8:
        if((1605807992 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 32.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_6})) == false)
        {
            goto label_8;
        }
        
        bool val_5 = this.丏丄丞不丄且丐丅不(专丞上七七且丝七丗:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丝三上东一丂丑万丂(int 业上上丏丄不上丅丈)
    {
        int val_6;
        var val_7;
        val_6 = 业上上丏丄不上丅丈;
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_8:
        if((1605928184 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 32.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_6})) == false)
        {
            goto label_8;
        }
        
        bool val_5 = this.七丏一丞与七丒丈丏(专丞上七七且丝七丗:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丑下七七丑丝世丅业(float 上丕丈丞丌丘丅不与)
    {
        this.丐丕丈丑丁丝不业丝 = 上丕丈丞丌丘丅不与;
        if(this.tramObject == 0)
        {
                return;
        }
        
        this.tramObject.CorrectProgress(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与);
    }
    private void 丁上丌丈与丟丐且丕(double 丂三丟丂丈丐丆丗丟)
    {
        this.七丁下丝万丆业丁丗 = System.Math.Max(val1:  this.七丁下丝万丆业丁丗, val2:  丂三丟丂丈丐丆丗丟);
    }
    public void SendGateAttack()
    {
        PhotonView val_5;
        var val_6;
        val_5 = this;
        if(this.tramObject == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = this.丄丈丑丐丆丞丘与丗;
        object[] val_4 = new object[1];
        val_4[0] = FortEquipmentController.丝丘丞不丂丆不丘且.CheckGateHealth(丞丈专下丈专业三丞:  this.tramObject.tramDamage);
        val_5.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  159, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
    }
    private void 丟丞一丁丗上丄且且(float 丄东丙丄丞三万世丂)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.tramObject.AttackGate(丄东丙丄丞三万世丂:  丄东丙丄丞三万世丂));
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_7;
        var val_8;
        PhotonView val_9;
        val_7 = null;
        val_7 = null;
        if((this.丟丟丝丄丑与专专不.Contains(item:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) != false)
        {
                object[] val_2 = new object[1];
            val_8 = null;
            val_8 = null;
            val_2[0] = typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  129, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        }
        
        val_9 = this.丄丈丑丐丆丞丘与丗;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_16;
        }
        
        if(this.七丁下丝万丆业丁丗 != 0)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(this.七丁下丝万丆业丁丗 == 0)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_3[0] = this.七丁下丝万丆业丁丗;
        val_9.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  157, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_9 = this.tramObject;
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = this.丄丈丑丐丆丞丘与丗;
        object[] val_6 = new object[1];
        val_6[0] = this.tramObject.allPathProgress;
        val_9.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_6);
    }
    public 一上丕丞丙一丈七丛 GetCheckpointsProgress()
    {
        if(this.tramObject != null)
        {
                return this.GetCheckpointsProgressFor(丛一与丝丝丟上不丛:  this.tramObject.allPathProgress);
        }
        
        return this.GetCheckpointsProgressFor(丛一与丝丝丟上不丛:  this.tramObject.allPathProgress);
    }
    public 一上丕丞丙一丈七丛 GetCheckpointsProgressFor(float 丛一与丝丝丟上不丛)
    {
        float val_10;
        TramObject val_11;
        int val_12;
        int val_13;
        var val_14;
        val_10 = 丛一与丝丝丟上不丛;
        val_11 = this.tramObject;
        if(val_11 == 0)
        {
                return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
        }
        
        val_12 = 1152921537525660048;
        val_13 = (int)val_10;
        val_14 = 0;
        val_10 = val_10 - (float)val_13;
        goto label_5;
        label_10:
        TramPath val_2 = this.checkpoints.Item[0];
        if(val_2.myIndex > val_13)
        {
            goto label_8;
        }
        
        val_14 = 1;
        label_5:
        if(val_14 < this.checkpoints.Count)
        {
            goto label_10;
        }
        
        goto label_12;
        label_8:
        if(val_14 == 1)
        {
            goto label_12;
        }
        
        val_13 = this.GetPathByIndex(丞世不丒下上上丝丑:  val_13);
        TramPath val_5 = this.checkpoints.Item[0];
        val_12 = UnityEngine.Mathf.Max(a:  0, b:  -1);
        TramPath val_7 = this.checkpoints.Item[val_12];
        float val_10 = val_5.distancePoint;
        val_10 = val_10 - val_7.distancePoint;
        float val_12 = val_4.distancePoint;
        if(val_10 != 0f)
        {
            goto label_20;
        }
        
        float val_11 = val_4.distance;
        val_11 = val_10 * val_11;
        val_12 = val_12 + val_11;
        val_12 = val_12 / val_5.distancePoint;
        return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
        label_12:
        val_11 = this.checkpoints;
        int val_9 = val_11.Count - 1;
        return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
        label_20:
        float val_14 = val_7.distancePoint;
        float val_13 = val_4.distance;
        val_12 = val_12 - val_14;
        val_13 = val_10 * val_13;
        val_12 = val_12 + val_13;
        val_14 = val_5.distancePoint - val_14;
        val_12 = val_12 / val_14;
        return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
    }
    public float GetCurrentProgress()
    {
        if(this.tramObject == 0)
        {
                return (float)this.tramObject.allPathProgress;
        }
        
        this = this.tramObject;
        return (float)this.tramObject.allPathProgress;
    }
    public float GetCurrentDistanceProgress()
    {
        if(this.tramObject == 0)
        {
                return 0f;
        }
        
        if(this.tramObject != null)
        {
                return this.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.tramObject.allPathProgress);
        }
        
        return this.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.tramObject.allPathProgress);
    }
    public float GetDistanceProgressFor(float 上丕丈丞丌丘丅不与)
    {
        float val_3;
        float val_4;
        val_3 = 上丕丈丞丌丘丅不与;
        TramPath val_1 = this.GetPathByIndex(丞世不丒下上上丝丑:  (int)val_3);
        if(val_1 == 0)
        {
                return (float)val_3;
        }
        
        val_3 = val_3 - (float)(int)val_3;
        if(val_1 != null)
        {
                val_4 = val_1.distancePoint;
        }
        else
        {
                val_4 = 1.643967E-34f;
        }
        
        float val_3 = val_1.distance;
        val_3 = val_3 * val_3;
        val_3 = val_4 + val_3;
        return (float)val_3;
    }
    public int AttackPlayersOnTram()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = 0;
        val_8 = 0;
        goto label_1;
        label_16:
        if(this.丟丟丝丄丑与专专不.Item[0] != 0)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_9 = null;
            val_9 = null;
            if(val_1.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝() != SiegeController.三三万丆下一丗万丛.attackTeam)
        {
                return (int)val_8;
        }
        
        }
        
            val_8 = 1;
        }
        
        val_7 = 1;
        label_1:
        if(val_7 < this.丟丟丝丄丑与专专不.Count)
        {
            goto label_16;
        }
        
        return (int)val_8;
    }
    public void RegisterTramObject(TramObject 丌一丂专世上丆丁专)
    {
        this.tramObject = 丌一丂专世上丆丁专;
        丌一丂专世上丆丁专.allPathProgress = this.丐丕丈丑丁丝不业丝;
        丌一丂专世上丆丁专.七丒下丂丝且丕丌东();
    }
    public TramController()
    {
        this.timeToSyncTram = 1f;
        this.timeToMoveBack = 0f;
    }

}
