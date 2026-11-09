using UnityEngine;
public class TankController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal static TankController 丄丘七三上丕世丞业;
    public TankObject tankObject;
    internal TankDamageable 丆世丙丈一丕丆丞丆;
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    private System.Collections.Generic.List<Player_move_c> 丟丟丝丄丑与专专不;
    public float[] resurrectSpeed;
    internal float 三丛丐且丝丕丝丐万;
    public float timeToMoveBack;
    private float 上东丌万上丝丕不丛;
    private float 万丈丅丝丄丘丝丌丐;
    internal float 丄丁丝丛丒专且丝丛;
    public TrainPathController trainPath;
    internal bool 丐丁丛丗专丛丆丄丞;
    private System.Collections.Generic.List<HitBox> _listAdditionalTankPoint;
    private System.Action 丈丈丄丅不丑丁丄丕;
    
    // Properties
    internal bool 万东丑丟丒三丙丈丞 { get; }
    internal bool 不不丐七丛七丕丐丕 { get; }
    internal bool 丙且不丆丌丞专丘丝 { get; }
    internal System.Collections.Generic.List<HitBox> 且丘业丗丌不丅且丘 { get; }
    
    // Methods
    internal bool 不丝丁丞万丈丆丏万()
    {
        return (bool)(三丏丟不丆丅丞不丛() <= 0f) ? 1 : 0;
    }
    internal bool 丅世七丑且丌七万丁()
    {
        null = null;
        if(this.丟丟丝丄丑与专专不 != null)
        {
                return this.丟丟丝丄丑与专专不.Contains(item:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
        }
        
        return this.丟丟丝丄丑与专专不.Contains(item:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
    }
    internal bool 丕丏丛丗丕下丆且丑()
    {
        return (bool)(this.丟丟丝丄丑与专专不.Count > 0) ? 1 : 0;
    }
    internal System.Collections.Generic.List<HitBox> 下丈丕丗丟丘丆丗丅()
    {
        return (System.Collections.Generic.List<HitBox>)this._listAdditionalTankPoint;
    }
    private void Awake()
    {
        var val_14;
        System.Delegate val_15;
        System.Action<与丅丕丈丘东丝世丟> val_16;
        TankController.丄丘七三上丕世丞业 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        this.丆世丙丈一丕丆丞丆 = this.tankObject.GetComponent<TankDamageable>();
        this.丟丟丝丄丑与专专不 = new System.Collections.Generic.List<Player_move_c>(capacity:  10);
        val_14 = null;
        val_14 = null;
        System.Action<与丅丕丈丘东丝世丟> val_4 = null;
        val_15 = val_4;
        val_4 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TankController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  val_4)) != null) && (null != null))
        {
                val_16 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_16;
        丕丝丕丝丑丐专丁三 val_8 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().一丗与专专丆东丕丈(与丐与不丁丗丂一东:  3);
        if(val_8 == null)
        {
                return;
        }
        
        if(val_8.丟不一下丆丁万丂丈() == null)
        {
                return;
        }
        
        val_15 = val_8.丟不一下丆丁万丂丈();
        if(val_15.Count < 1)
        {
                return;
        }
        
        this.resurrectSpeed = val_8.丟不一下丆丁万丂丈().ToArray();
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TankController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    internal void 三丆下七不上丏丂丞()
    {
        var val_3 = this;
        this.RegisterTankObject(丁丑丄且上业丅丒丗:  this.tankObject);
        this.丈丏丒专不与丅丙丁();
        List.Enumerator<T> val_1 = this._listAdditionalTankPoint.GetEnumerator();
        goto label_2;
        label_4:
        string val_2 = 0.丐丏七丌丕丗业且上();
        mem2[0] = this.丆世丙丈一丕丆丞丆;
        label_2:
        if((1501367400 & 1) != 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Update()
    {
        float val_20;
        float val_21;
        var val_22;
        int val_23;
        var val_24;
        TankDamageable val_25;
        if(this.不丝丁丞万丈丆丏万() == true)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_20 = this.上东丌万上丝丕不丛;
            val_21 = val_20 - UnityEngine.Time.deltaTime;
            this.上东丌万上丝丕不丛 = val_21;
            if(this.tankObject != 0)
        {
                val_21 = this.上东丌万上丝丕不丛;
            if(val_21 <= 0f)
        {
                this.上东丌万上丝丕不丛 = this.三丛丐且丝丕丝丐万;
            object[] val_5 = new object[1];
            val_5[0] = this.三丛丐且丝丕丝丐万;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_5);
            if(this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 != false)
        {
                object[] val_6 = new object[1];
            val_6[0] = this.丄丁丝丛丒专且丝丛;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  177, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_6);
        }
        
        }
        
        }
        
        }
        
        val_22 = 0;
        val_23 = 0;
        val_24 = 0;
        goto label_22;
        label_27:
        bool val_9 = (UnityEngine.Object.op_Equality(x:  this.丟丟丝丄丑与专专不.Item[0], y:  0)) ^ 1;
        val_24 = val_24 | val_9;
        val_23 = val_23 + val_9;
        val_22 = 1;
        label_22:
        if(val_22 < this.丟丟丝丄丑与专专不.Count)
        {
            goto label_27;
        }
        
        if(this.tankObject != 0)
        {
                this.tankObject.SetMoving(三丑丏世丂丆丕丈专:  val_24 & ((this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 == false) ? 1 : 0), 丁业丈丄丐丒丏丅丙:  false, 一丅世丙东三丆专东:  val_23);
        }
        
        val_25 = this.丆世丙丈一丕丆丞丆;
        if(this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 == false)
        {
                return;
        }
        
        if(val_24 != false)
        {
                val_25 = this.resurrectSpeed;
            val_20 = this.丄丁丝丛丒专且丝丛;
            float val_19 = UnityEngine.Mathf.MoveTowards(current:  val_20, target:  1f, maxDelta:  (val_25[(long)(UnityEngine.Mathf.Min(a:  this.resurrectSpeed.Length, b:  val_23)) - 1]) * UnityEngine.Time.deltaTime);
            this.丄丁丝丛丒专且丝丛 = val_19;
            if(val_19 < 1f)
        {
                return;
        }
        
            this.丐三丞丈业丁丑万丙();
            return;
        }
        
        this.丄丁丝丛丒专且丝丛 = 0f;
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
        if(丛丄业丕且丗下一万.wasReached != false)
        {
                return;
        }
        
        丛丄业丕且丗下一万.wasReached = true;
        this.万丟丆丗丕世丐丂下(丛丄业丕且丗下一万:  丛丄业丕且丗下一万);
    }
    private void 万丟丆丗丕世丐丂下(TramPath 丛丄业丕且丗下一万)
    {
        InGameGUI val_9;
        float val_10;
        var val_11;
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 != 0)
        {
                float val_9 = 60f;
            val_9 = 丛丄业丕且丗下一万.checkpointAddTime / val_9;
            val_9 = 且丕万丑下业丙丂丗();
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            val_10 = val_6.r;
            val_9.Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8089"), arg0:  UnityEngine.Mathf.RoundToInt(f:  val_9)), 丂三丟丂丈丐丆丗丟:  4f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10, g = val_6.g, b = val_6.b, a = val_6.a});
        }
        
        if(this.丅世七丑且丌七万丁() != false)
        {
                val_11 = null;
            val_11 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  110, 专上丝且丂世丛丝丒:  1f);
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_10 = 丛丄业丕且丗下一万.checkpointAddTime;
        TimeGameController.丄丞丁丈与业上丞丟.丈丗丁丐丟三丄世下(丆丐七丅丆丗丛上与:  val_10);
    }
    public void add_onEndReached(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丈丄丅不丑丁丄丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丈丄丅不丑丁丄丕 != 1152921540468856944);
    
    }
    public void remove_onEndReached(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丈丄丅不丑丁丄丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丈丄丅不丑丁丄丕 != 1152921540468993520);
    
    }
    public void OnEndReached(TramPath 丛丄业丕且丗下一万)
    {
        if(this.丐丁丛丗专丛丆丄丞 == true)
        {
                return;
        }
        
        if(this.丈丈丄丅不丑丁丄丕 != null)
        {
                this.丈丈丄丅不丑丁丄丕.Invoke();
        }
        
        this.万丟丆丗丕世丐丂下(丛丄业丕且丗下一万:  丛丄业丕且丗下一万);
        this.丐丁丛丗专丛丆丄丞 = true;
    }
    public void OnTankDestroyed()
    {
        if(this.tankObject.explosionObject != 0)
        {
                this.tankObject.explosionObject.SetActive(value:  true);
        }
        
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                GameStageEvent val_2 = 且丕万丑下业丙丂丗();
            if(val_2 != null)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
            val_2.Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8084"), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        }
        
        }
        
        this.丄丁丝丛丒专且丝丛 = 0f;
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
    internal void 丈丏丒专不与丅丙丁()
    {
        this.tankObject.gameObject.SetActive(value:  true);
        this.丟丟丝丄丑与专专不.Clear();
        this.tankObject.Reset();
        this.tankObject.SetProgress(上丕丈丞丌丘丅不与:  0f);
        this.trainPath.Reset();
        if(this.tankObject.explosionObject != 0)
        {
                this.tankObject.explosionObject.SetActive(value:  false);
        }
        
        this.丄丁丝丛丒专且丝丛 = 0f;
        this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 = 0.maxHealth;
        this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 = false;
    }
    internal void 丐三丞丈业丁丑万丙()
    {
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  25, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        this.丝丒丄七七一丟专丆();
    }
    internal void 丝丒丄七七一丟专丆()
    {
        var val_9;
        var val_10;
        if(this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 == false)
        {
                return;
        }
        
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                GameStageEvent val_1 = 且丕万丑下业丙丂丗();
            if(val_1 != null)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.white;
            val_1.Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8085"), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        }
        
        }
        
        if(this.丅世七丑且丌七万丁() != false)
        {
                val_9 = null;
            val_9 = null;
            if(GameController.mode != null)
        {
                val_10 = null;
        }
        
            val_10 = null;
            var val_6 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + FortAttackController.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_10) ? GameController.mode : 0;
            (GameModeController.__il2cppRuntimeField_typeHierarchy + FortAttackController.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_10 ? GameController.mode : 0 + 536.一丗丈丟丝万丛世且();
        }
        
        if(this.tankObject.explosionObject != 0)
        {
                this.tankObject.explosionObject.SetActive(value:  false);
        }
        
        this.丄丁丝丛丒专且丝丛 = 0f;
        this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 = 0.maxHealth;
        this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 = false;
    }
    internal void 三丘丛丐丆丏丒丅丝(float 且丑丐丂与丐丟丒下)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(且丑丐丂与丐丟丒下 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(且丑丐丂与丐丟丒下 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 且丑丐丂与丐丟丒下;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丙丂与世上丌丁丈三(float 且丑丐丂与丐丟丒下)
    {
        this.丆世丙丈一丕丆丞丆.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  且丑丐丂与丐丟丒下);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_5;
        if(this.不丝丁丞万丈丆丏万() == false)
        {
            goto label_1;
        }
        
        label_17:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        byte val_2 = 丞世不丒下上上丝丑 & 255;
        if(val_2 > 119)
        {
            goto label_3;
        }
        
        if(val_2 == 24)
        {
            goto label_4;
        }
        
        if(val_2 == 25)
        {
            goto label_5;
        }
        
        if(val_2 != 119)
        {
            goto label_17;
        }
        
        object val_5 = 专丒丌丆下丐丞丟丞[0];
        this.上东世丘丏上东七丑(世丙丟上丘上七万万:  3.782474E-38f);
        goto label_27;
        label_3:
        if(val_2 > 155)
        {
            goto label_10;
        }
        
        byte val_3 = 丞世不丒下上上丝丑 & 255;
        if(val_3 == 129)
        {
            goto label_11;
        }
        
        if(val_3 != 155)
        {
            goto label_17;
        }
        
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        this.丑下七七丑丝世丅业(上丕丈丞丌丘丅不与:  3.782474E-38f);
        goto label_27;
        label_10:
        byte val_4 = 丞世不丒下上上丝丑 & 255;
        if(val_4 == 156)
        {
            goto label_16;
        }
        
        if(val_4 != 177)
        {
            goto label_17;
        }
        
        object val_7 = 专丒丌丆下丐丞丟丞[0];
        this.丁丝丑专丗丕丄丝丕(上丕丈丞丌丘丅不与:  3.782474E-38f);
        goto label_27;
        label_4:
        if(专丒丌丆下丐丞丟丞.Length != 1)
        {
            goto label_27;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[0];
        this.丙丂与世上丌丁丈三(且丑丐丂与丐丟丒下:  3.782474E-38f);
        goto label_27;
        label_5:
        this.丝丒丄七七一丟专丆();
        goto label_27;
        label_11:
        object val_9 = 专丒丌丆下丐丞丟丞[0];
        this.万丄东七丒专丕丒丛(业上上丏丄不上丅丈:  21884928);
        goto label_27;
        label_16:
        object val_10 = 专丒丌丆下丐丞丟丞[0];
        this.丝三上东一丂丑万丂(业上上丏丄不上丅丈:  21884928);
        label_27:
        val_5 = 1;
        return (bool)val_5;
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
        if((1504152488 & 1) == 0)
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
        if((1504272680 & 1) == 0)
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
        this.万丈丅丝丄丘丝丌丐 = 上丕丈丞丌丘丅不与;
        if(this.tankObject == 0)
        {
                return;
        }
        
        this.tankObject.CorrectProgress(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与);
    }
    private void 上东世丘丏上东七丑(float 世丙丟上丘上七万万)
    {
        if(世丙丟上丘上七万万 > 0f)
        {
                this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 = UnityEngine.Mathf.Min(a:  this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万, b:  世丙丟上丘上七万万);
            return;
        }
        
        this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 = 0f;
        if(this.丆世丙丈一丕丆丞丆 == null)
        {
            
        }
    
    }
    private void 丁丝丑专丗丕丄丝丕(float 上丕丈丞丌丘丅不与)
    {
        this.丄丁丝丛丒专且丝丛 = UnityEngine.Mathf.Max(a:  this.丄丁丝丛丒专且丝丛, b:  上丕丈丞丌丘丅不与);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_8;
        var val_9;
        TankDamageable val_10;
        val_8 = null;
        val_8 = null;
        if((this.丟丟丝丄丑与专专不.Contains(item:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) != false)
        {
                object[] val_2 = new object[1];
            val_9 = null;
            val_9 = null;
            val_2[0] = typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  129, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                if(this.tankObject != 0)
        {
                object[] val_5 = new object[1];
            val_5[0] = 1152921505719563712;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  155, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_5);
        }
        
        }
        
        object[] val_6 = new object[1];
        if(val_6 == null)
        {
            goto label_29;
        }
        
        if(this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 != 0)
        {
            goto label_30;
        }
        
        goto label_33;
        label_29:
        if(this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 == 0)
        {
            goto label_33;
        }
        
        label_30:
        label_33:
        val_6[0] = this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_6);
        val_10 = this.丆世丙丈一丕丆丞丆;
        if(this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 == false)
        {
                return;
        }
        
        val_10 = this.丄丈丑丐丆丞丘与丗;
        object[] val_7 = new object[1];
        val_7[0] = this.丄丁丝丛丒专且丝丛;
        val_10.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  177, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_7);
    }
    public 一上丕丞丙一丈七丛 GetCheckpointsProgress()
    {
        if(this.trainPath != null)
        {
                return this.trainPath.GetCheckpointsProgressFor(丛一与丝丝丟上不丛:  V8.16B);
        }
        
        return this.trainPath.GetCheckpointsProgressFor(丛一与丝丝丟上不丛:  V8.16B);
    }
    public float GetCurrentProgress()
    {
        if(this.tankObject == 0)
        {
                return 0f;
        }
        
        this = this.tankObject;
        return 0f;
    }
    public float GetCurrentDistanceProgress()
    {
        if(this.tankObject == 0)
        {
                return 0f;
        }
        
        if(this.tankObject != null)
        {
                return this.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  null);
        }
        
        return this.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  null);
    }
    public float GetDistanceProgressFor(float 上丕丈丞丌丘丅不与)
    {
        float val_3;
        float val_4;
        val_3 = 上丕丈丞丌丘丅不与;
        TramPath val_1 = this.trainPath.GetPathByIndex(丞世不丒下上上丝丑:  (int)val_3);
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
        var val_4;
        var val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_1;
        label_6:
        var val_4 = ~(UnityEngine.Object.op_Equality(x:  this.丟丟丝丄丑与专专不.Item[0], y:  0));
        val_4 = val_4 & 1;
        val_5 = val_5 + val_4;
        val_4 = 1;
        label_1:
        if(val_4 < this.丟丟丝丄丑与专专不.Count)
        {
            goto label_6;
        }
        
        return (int)val_5;
    }
    public void RegisterTankObject(TankObject 丁丑丄且上业丅丒丗)
    {
        丁丑丄且上业丅丒丗.上丛丌丆丑上七世三(丌丌丞上丛业丝丗丗:  this.trainPath);
        this.tankObject = 丁丑丄且上业丅丒丗;
        丁丑丄且上业丅丒丗.SetProgress(上丕丈丞丌丘丅不与:  this.万丈丅丝丄丘丝丌丐);
        this.丆世丙丈一丕丆丞丆.世丙丟上丘上七万万 = 0.maxHealth;
        this.丆世丙丈一丕丆丞丆.丐下丁与一丑丟丛世 = false;
    }
    public TankController()
    {
        this.resurrectSpeed = new float[3] {-6.352689E-23f, -4.294922E+08f, 8.82818E-44f};
        this.三丛丐且丝丕丝丐万 = 0.4f;
        this.timeToMoveBack = 10f;
        this._listAdditionalTankPoint = new System.Collections.Generic.List<HitBox>();
    }

}
