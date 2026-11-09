using UnityEngine;
public class PhotonView : MonoBehaviour
{
    // Fields
    public int ownerId;
    public byte group;
    protected internal bool 丌七不丕东丗丞且七;
    public bool OwnerShipWasTransfered;
    public int prefixBackup;
    internal object[] 丞丁丝丕世丏丌丞丁;
    protected internal object[] 丏丌丁丂丏丝七丙丌;
    protected internal object[] 丝且丙丆三三专丟上;
    public ViewSynchronization synchronization;
    public OnSerializeTransform onSerializeTransformOption;
    public OnSerializeRigidBody onSerializeRigidBodyOption;
    public OwnershipOption ownershipTransfer;
    public System.Collections.Generic.List<UnityEngine.Component> ObservedComponents;
    private System.Collections.Generic.Dictionary<UnityEngine.Component, System.Reflection.MethodInfo> 丞丑丆丆丌上世丌业;
    private int viewIdField;
    public int instantiationId;
    public int currentMasterID;
    protected internal bool 丐丏丘丂与下丝丐三;
    protected internal bool isRuntimeInstantiated;
    protected internal bool 丅丘万世丘丝丕丌丁;
    internal Rilisoft.东丁丆一业丈万丆丐[] 丁丞与专丅不丄万万;
    private System.Reflection.MethodInfo 丁丅丙丈丞下不丞丏;
    private bool 丂下一丌业业七且丟;
    
    // Properties
    public int 丂业丕业丂丅丙一丛 { get; set; }
    public object[] 不丝且东且丆丕丏万 { get; set; }
    public int 世上丕丐丈世上不丏 { get; set; }
    public bool 丗丙一专丑丐丑丝丂 { get; }
    public 与丅丕丈丘东丝世丟 世万丘丟丐上世不上 { get; }
    public int 丗世七三上丄丐专与 { get; }
    public bool 一丄丘七丛七丏世丘 { get; }
    public int 丆丂丟丐丏丕丌万丒 { get; }
    public bool 丌且下丕下下丌万丞 { get; }
    
    // Methods
    public int get_prefix()
    {
        int val_1;
        var val_2;
        var val_3;
        val_1 = this.prefixBackup;
        if(val_1 != 1)
        {
                return (int);
        }
        
        val_2 = static_value_081D9CF0;
        val_2 = static_value_081D9CF0;
        val_3 = mem[static_value_081D9CF0 + 184 + 16];
        val_3 = static_value_081D9CF0 + 184 + 16;
        val_3 = mem[static_value_081D9CF0 + 184 + 16];
        val_3 = static_value_081D9CF0 + 184 + 16;
        val_1 = mem[static_value_081D9CF0 + 184 + 16 + 512];
        val_1 = static_value_081D9CF0 + 184 + 16 + 512;
        this.prefixBackup = val_1;
        return (int);
    }
    public void set_prefix(int 丙业与丙丗丝不丈东)
    {
        this.prefixBackup = 丙业与丙丗丝不丈东;
    }
    public object[] get_instantiationData()
    {
        System.Object[] val_2;
        var val_3;
        if(this.丐丏丘丂与下丝丐三 != false)
        {
                val_2 = this.丞丁丝丕世丏丌丞丁;
            return val_1;
        }
        
        val_3 = static_value_081D9CF0;
        val_3 = static_value_081D9CF0;
        System.Object[] val_1 = static_value_081D9CF0 + 184 + 16.丘万丄万丅丂且与七(丆丄丈丌丁丞丂与丘:  this.instantiationId);
        this.丞丁丝丕世丏丌丞丁 = val_1;
        return val_1;
    }
    public void set_instantiationData(object[] 丙业与丙丗丝不丈东)
    {
        this.丞丁丝丕世丏丌丞丁 = 丙业与丙丗丝不丈东;
    }
    public int get_viewID()
    {
        return (int)this.viewIdField;
    }
    public void set_viewID(int 丙业与丙丗丝不丈东)
    {
        var val_2;
        var val_3;
        if(this.丐丏丘丂与下丝丐三 != false)
        {
                var val_1 = (this.viewIdField == 0) ? 1 : 0;
        }
        else
        {
                val_2 = 0;
        }
        
        val_3 = static_value_081D9CF0;
        val_3 = static_value_081D9CF0;
        int val_2 = static_value_081D9CF0 + 184 + 24;
        this.viewIdField = 丙业与丙丗丝不丈东;
        val_2 = 丙业与丙丗丝不丈东 / val_2;
        this.ownerId = val_2;
        if(val_2 == 0)
        {
                return;
        }
        
        val_3 = static_value_081D9CF0;
        static_value_081D9CF0 + 184 + 16.丙丗与丆万丗东丐且(丏丆丕丞下业丗丙丆:  this);
    }
    public bool get_isSceneView()
    {
        return (bool)(this.CreatorActorNr == 0) ? 1 : 0;
    }
    public 与丅丕丈丘东丝世丟 get_owner()
    {
        return 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  this.ownerId);
    }
    public int get_OwnerActorNr()
    {
        return (int)this.ownerId;
    }
    public bool get_isOwnerActive()
    {
        var val_1;
        if(this.ownerId == 0)
        {
                return false;
        }
        
        val_1 = static_value_081D9CF0;
        val_1 = static_value_081D9CF0;
        return static_value_081D9CF0 + 184 + 16 + 424.ContainsKey(key:  this.ownerId);
    }
    public int get_CreatorActorNr()
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        return (int)this.viewIdField / (static_value_081D9CF0 + 184 + 24);
    }
    public bool get_isMine()
    {
        var val_4;
        if(this.ownerId == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())
        {
                val_4 = 1;
            return (bool)val_4;
        }
        
        if(this.isOwnerActive == false)
        {
                return 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    protected internal void Awake()
    {
        var val_5;
        System.Delegate val_6;
        System.Action<与丅丕丈丘东丝世丟> val_7;
        var val_8;
        PhotonObjectCacher.丞万一世丁丛且丙丝(丁世丛业丟下丕三丟:  this);
        val_5 = null;
        val_5 = null;
        System.Action<与丅丕丈丘东丝世丟> val_1 = null;
        val_6 = val_1;
        val_1 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void PhotonView::OnMasterClientSwitched(与丅丕丈丘东丝世丟 丛丑东丝丌丒一丘丒));
        if(((System.Delegate.Combine(a:  GameConnect.不且一万专丟丝专丘, b:  val_1)) != null) && (null != null))
        {
                val_7 = 0;
        }
        
        GameConnect.不且一万专丟丝专丘 = val_7;
        if(this.viewIdField != 0)
        {
                val_8 = static_value_081D9CF0;
            val_8 = static_value_081D9CF0;
            static_value_081D9CF0 + 184 + 16.丙丗与丆万丗东丐且(丏丆丕丞下业丗丙丆:  this);
            val_6 = this.instantiationId;
            this.丞丁丝丕世丏丌丞丁 = static_value_081D9CF0 + 184 + 16.丘万丄万丅丂且与七(丆丄丈丌丁丞丂与丘:  val_6);
        }
        
        this.丐丏丘丂与下丝丐三 = true;
    }
    public void RequestOwnership()
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        static_value_081D9CF0 + 184 + 16.丘丛丏下丘丂丁专上(世上丕丐丈世上不丏:  this.viewIdField, 东丌丒世丅专丑丕不:  this.ownerId);
    }
    public void TransferOwnership(与丅丕丈丘东丝世丟 不丝业丏业丝业且七)
    {
        this.TransferOwnership(丅东丕丐东上丕丟丆:  不丝业丏业丝业且七.业丐丐三丕一丗丛丁());
    }
    public void TransferOwnership(int 丅东丕丐东上丕丟丆)
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        static_value_081D9CF0 + 184 + 16.丛不万不丑丈丙丅上(世上丕丐丈世上不丏:  this.viewIdField, 业上上丏丄不上丅丈:  丅东丕丐东上丕丟丆);
        this.ownerId = 丅东丕丐东上丕丟丆;
    }
    public void OnMasterClientSwitched(与丅丕丈丘东丝世丟 丛丑东丝丌丒一丘丒)
    {
        if((this.CreatorActorNr == 0) && (this.OwnerShipWasTransfered != true))
        {
                if(this.currentMasterID != 1)
        {
                if(this.ownerId != this.currentMasterID)
        {
            goto label_3;
        }
        
        }
        
            this.ownerId = 丛丑东丝丌丒一丘丒.业丐丐三丕一丗丛丁();
        }
        
        label_3:
        this.currentMasterID = 丛丑东丝丌丒一丘丒.业丐丐三丕一丗丛丁();
    }
    protected internal void OnDestroy()
    {
        PhotonView val_8;
        var val_9;
        System.Delegate val_10;
        System.Action<与丅丕丈丘东丝世丟> val_11;
        var val_12;
        var val_13;
        var val_14;
        val_8 = this;
        PhotonObjectCacher.丐丞丌丛七业东丝丟(万且万且丑丗且丌丆:  this);
        val_9 = null;
        val_9 = null;
        System.Action<与丅丕丈丘东丝世丟> val_1 = null;
        val_10 = val_1;
        val_1 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void PhotonView::OnMasterClientSwitched(与丅丕丈丘东丝世丟 丛丑东丝丌丒一丘丒));
        if(((System.Delegate.Remove(source:  GameConnect.不且一万专丟丝专丘, value:  val_1)) != null) && (null != null))
        {
                val_11 = 0;
        }
        
        GameConnect.不且一万专丟丝专丘 = val_11;
        if(this.丅丘万世丘丝丕丌丁 == true)
        {
                return;
        }
        
        val_10 = 1152921505107111936;
        val_12 = static_value_081D9CF0;
        val_12 = static_value_081D9CF0;
        if((static_value_081D9CF0 + 184 + 16.丂丐丙丟业丂下丅丏(丁世丛业丟下丕三丟:  this)) == false)
        {
                return;
        }
        
        if(this.instantiationId < 1)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(PhotonHandler.丟丞专丄丒丐丌丗丆 == true)
        {
                return;
        }
        
        val_14 = static_value_081D9CF0;
        val_14 = static_value_081D9CF0;
        val_8 = "PUN-instantiated \'"("PUN-instantiated \'") + this.gameObject.name + "\' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy()."("\' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
        UnityEngine.Debug.Log(message:  val_8);
    }
    public void SerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        var val_4;
        var val_5;
        val_4 = 1152921535579239296;
        if(this.ObservedComponents == null)
        {
                return;
        }
        
        if(this.ObservedComponents.Count < 1)
        {
                return;
        }
        
        val_5 = 0;
        goto label_3;
        label_6:
        this.上东丁七丒丗丗丌丏(丑丅丈东丐丐丕丞丙:  this.ObservedComponents.Item[0], 东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        val_5 = 1;
        label_3:
        if(val_5 < this.ObservedComponents.Count)
        {
            goto label_6;
        }
    
    }
    public void DeserializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        var val_4;
        var val_5;
        val_4 = 1152921535579416736;
        if(this.ObservedComponents == null)
        {
                return;
        }
        
        if(this.ObservedComponents.Count < 1)
        {
                return;
        }
        
        val_5 = 0;
        goto label_3;
        label_6:
        this.丙丌不丂世丑丏七丅(丑丅丈东丐丐丕丞丙:  this.ObservedComponents.Item[0], 东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        val_5 = 1;
        label_3:
        if(val_5 < this.ObservedComponents.Count)
        {
            goto label_6;
        }
    
    }
    protected internal void 丙丌不丂世丑丏七丅(UnityEngine.Component 丑丅丈东丐丐丕丞丙, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        var val_19;
        if(丑丅丈东丐丐丕丞丙 == 0)
        {
                return;
        }
        
        if(丑丅丈东丐丐丕丞丙 != null)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "Type of observed is unknown when receiving.");
        return;
        label_11:
        if(this.onSerializeRigidBodyOption == 0)
        {
            goto label_14;
        }
        
        if(this.onSerializeRigidBodyOption == 1)
        {
            goto label_15;
        }
        
        if(this.onSerializeRigidBodyOption != 2)
        {
                return;
        }
        
        if(东业丄丅丅且世七丄 == null)
        {
            goto label_17;
        }
        
        val_19 = 0;
        goto label_18;
        label_14:
        object val_8 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        丑丅丈东丐丐丕丞丙.velocity = new UnityEngine.Vector2() {x = 3.782474E-38f};
        return;
        label_15:
        if(东业丄丅丅且世七丄 != null)
        {
            goto label_46;
        }
        
        goto label_32;
        label_17:
        label_18:
        object val_17 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        丑丅丈东丐丐丕丞丙.velocity = new UnityEngine.Vector2() {x = 3.782474E-38f};
        if(((东业丄丅丅且世七丄 == 0) ? 1 : 0) == 0)
        {
            goto label_46;
        }
        
        label_32:
        label_46:
        object val_18 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        丑丅丈东丐丐丕丞丙.angularVelocity = 3.782474E-38f;
    }
    protected internal void 上东丁七丒丗丗丌丏(UnityEngine.Component 丑丅丈东丐丐丕丞丙, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        var val_21;
        var val_23;
        if(丑丅丈东丐丐丕丞丙 == 0)
        {
                return;
        }
        
        if(丑丅丈东丐丐丕丞丙 == null)
        {
            goto label_4;
        }
        
        if(null != null)
        {
            goto label_11;
        }
        
        if(this.onSerializeRigidBodyOption == 0)
        {
            goto label_12;
        }
        
        if(this.onSerializeRigidBodyOption == 1)
        {
            goto label_13;
        }
        
        if(this.onSerializeRigidBodyOption != 2)
        {
                return;
        }
        
        UnityEngine.Vector2 val_4 = 丑丅丈东丐丐丕丞丙.velocity;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
        float val_5 = 丑丅丈东丐丐丕丞丙.angularVelocity;
        val_21 = null;
        goto label_37;
        label_4:
        label_11:
        UnityEngine.Debug.LogError(message:  "Observed type is not serializable: "("Observed type is not serializable: ") + 丑丅丈东丐丐丕丞丙.GetType());
        return;
        label_12:
        UnityEngine.Vector2 val_11 = 丑丅丈东丐丐丕丞丙.velocity;
        val_23 = 1152921504850403328;
        goto label_31;
        label_13:
        float val_12 = 丑丅丈东丐丐丕丞丙.angularVelocity;
        val_23 = 1152921504624205824;
        label_31:
        label_37:
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_17);
    }
    protected internal void 丏下一丆与东与丗丌(UnityEngine.Component 丑丅丈东丐丐丕丞丙, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        var val_12;
        object val_13;
        if(丑丅丈东丐丐丕丞丙 == null)
        {
            goto label_1;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        goto label_5;
        label_1:
        if(丑丅丈东丐丐丕丞丙 == 0)
        {
                return;
        }
        
        val_12 = 0;
        goto label_11;
        label_5:
        丑丅丈东丐丐丕丞丙.OnPhotonSerializeView(东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        return;
        label_11:
        if( != 0)
        {
                Rilisoft.且三与世丁丏丂丌下 val_5 = 与丑丌丌丌丁丌不丕();
            val_5.丁万丂丝丘业丈丛丘.Invoke(arg1:  东业丄丅丅且世七丄, arg2:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
            return;
        }
        
        if(丑丅丈东丐丐丕丞丙 != null)
        {
                val_13 = 丑丅丈东丐丐丕丞丙.name;
        }
        else
        {
                val_13 = 丑丅丈东丐丐丕丞丙.name;
        }
        
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "The observed monobehaviour ({0} of type {1}) of this PhotonView does not implement VTableHolder with OnPhotonSerializeView()!", arg0:  val_13, arg1:  丑丅丈东丐丐丕丞丙.GetType()));
    }
    public void RefreshRpcMonoBehaviourCache()
    {
        this.丁丞与专丅不丄万万 = this.GetComponents<Rilisoft.东丁丆一业丈万丆丐>();
    }
    internal void 七丂东世不丐丗丕丑(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, PhotonTargets 丞下万上三丘上与专, object[] 丗丟上上丒丐丗丞丙)
    {
        丅丒丗丑丒丙丛不丆.七丂东世不丐丗丕丑(丁世丛业丟下丕三丟:  this, 丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 丞下万上三丘上与专:  丞下万上三丘上与专, 东丈不且丁丞丙业业:  false, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    internal void 丂丘丘七一丆丟丈丐(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, PhotonTargets 丞下万上三丘上与专, bool 东丈不且丁丞丙业业, object[] 丗丟上上丒丐丗丞丙)
    {
        东丈不且丁丞丙业业 = 东丈不且丁丞丙业业;
        丅丒丗丑丒丙丛不丆.七丂东世不丐丗丕丑(丁世丛业丟下丕三丟:  this, 丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 丞下万上三丘上与专:  丞下万上三丘上与专, 东丈不且丁丞丙业业:  东丈不且丁丞丙业业, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    internal void 七丂东世不丐丗丕丑(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, 与丅丕丈丘东丝世丟 万丌万丅专丞业丈万, object[] 丗丟上上丒丐丗丞丙)
    {
        丅丒丗丑丒丙丛不丆.七丂东世不丐丗丕丑(丁世丛业丟下丕三丟:  this, 丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 万丌万丅专丞业丈万:  万丌万丅专丞业丈万, 丄丛丟三专与专不丅:  false, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    internal void 丂丘丘七一丆丟丈丐(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, 与丅丕丈丘东丝世丟 万丌万丅专丞业丈万, bool 东丈不且丁丞丙业业, object[] 丗丟上上丒丐丗丞丙)
    {
        东丈不且丁丞丙业业 = 东丈不且丁丞丙业业;
        丅丒丗丑丒丙丛不丆.七丂东世不丐丗丕丑(丁世丛业丟下丕三丟:  this, 丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 万丌万丅专丞业丈万:  万丌万丅专丞业丈万, 丄丛丟三专与专不丅:  东丈不且丁丞丙业业, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    public static PhotonView Get(UnityEngine.Component 丑丅丈东丐丐丕丞丙)
    {
        if(丑丅丈东丐丐丕丞丙 != null)
        {
                return 丑丅丈东丐丐丕丞丙.GetComponent<PhotonView>();
        }
        
        return 丑丅丈东丐丐丕丞丙.GetComponent<PhotonView>();
    }
    public static PhotonView Get(UnityEngine.GameObject 与世丒丐丈与丝万丟)
    {
        if(与世丒丐丈与丝万丟 != null)
        {
                return 与世丒丐丈与丝万丟.GetComponent<PhotonView>();
        }
        
        return 与世丒丐丈与丝万丟.GetComponent<PhotonView>();
    }
    public static PhotonView Find(int 世上丕丐丈世上不丏)
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        return static_value_081D9CF0 + 184 + 16.丄丕业丅三丒丌七丈(世上丕丐丈世上不丏:  世上丕丐丈世上不丏);
    }
    public override string ToString()
    {
        object val_9;
        object val_10;
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.viewIdField != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.viewIdField == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.viewIdField;
        if(this.gameObject == 0)
        {
            goto label_9;
        }
        
        val_9 = this.gameObject.name;
        if(val_9 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_9:
        val_9 = "GO==null";
        label_11:
        label_14:
        val_1[1] = val_9;
        if(this.CreatorActorNr != 0)
        {
            
        }
        else
        {
                val_10 = "(scene)";
        }
        
        val_1[2] = val_10;
        val_1[3] = this.prefix;
        return (string)System.String.Format(format:  "View ({3}){0} on {1} {2}", args:  val_1);
    }
    public PhotonView()
    {
        this.prefixBackup = 0;
        this.onSerializeTransformOption = 3;
        this.onSerializeRigidBodyOption = 2;
        this.丞丑丆丆丌上世丌业 = new System.Collections.Generic.Dictionary<UnityEngine.Component, System.Reflection.MethodInfo>(capacity:  3);
        this.currentMasterID = 0;
    }

}
