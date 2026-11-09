using UnityEngine;
[Serializable]
public class TerrainObjectsPull.PoolObj
{
    // Fields
    public UnityEngine.Transform obj;
    private bool _inUse;
    public int currentChunk;
    private UnityEngine.Collider[] _coliders;
    private UnityEngine.Renderer[] _renderers;
    private UnityEngine.LODGroup _lodGroup;
    private bool _needTurnOnColliders;
    private int _collidersRecalculationFrame;
    
    // Properties
    public bool inUse { get; set; }
    private bool NeedTurnOnColliders { get; }
    
    // Methods
    public void set_inUse(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this._inUse == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        bool val_2 = 丙业与丙丗丝不丈东;
        this._inUse = val_2;
        this.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  val_2);
    }
    public bool get_inUse()
    {
        return (bool)this._inUse;
    }
    public void 丝丕丟丑专丟丁三与()
    {
        this._coliders = this.obj.GetComponentsInChildren<UnityEngine.Collider>();
        this._renderers = this.obj.GetComponentsInChildren<UnityEngine.Renderer>();
        this._lodGroup = this.obj.GetComponentInChildren<UnityEngine.LODGroup>();
    }
    private bool get_NeedTurnOnColliders()
    {
        bool val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = this;
        if(this._collidersRecalculationFrame == UnityEngine.Time.frameCount)
        {
                val_6 = this._needTurnOnColliders;
            return (bool)this._needTurnOnColliders;
        }
        
        val_7 = null;
        val_7 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_7;
        }
        
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
            goto label_13;
        }
        
        label_7:
        val_9 = 1;
        goto label_14;
        label_13:
        val_10 = null;
        val_10 = null;
        label_14:
        this._needTurnOnColliders = (typeof(NetworkStartTable).__il2cppRuntimeField_79 ^ 1);
        this._collidersRecalculationFrame = UnityEngine.Time.frameCount;
        return (bool)this._needTurnOnColliders;
    }
    public void 不上丕不丞业一丗丂(bool 丛丅丘一丏丙且丌上)
    {
        var val_6;
        var val_7;
        if(this.NeedTurnOnColliders == false)
        {
            goto label_1;
        }
        
        val_6 = 0;
        goto label_2;
        label_7:
        this._coliders[0].enabled = 丛丅丘一丏丙且丌上;
        val_6 = 1;
        label_2:
        if(val_6 < this._coliders.Length)
        {
            goto label_7;
        }
        
        label_1:
        val_7 = 0;
        goto label_8;
        label_13:
        this._renderers[0].enabled = 丛丅丘一丏丙且丌上;
        val_7 = 1;
        label_8:
        if(val_7 < this._renderers.Length)
        {
            goto label_13;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this._lodGroup)) == false)
        {
                return;
        }
        
        this._lodGroup.enabled = 丛丅丘一丏丙且丌上;
    }
    public void 丅专下万丕丑丆丅丝(UnityEngine.Transform 丒丈丑丕丟丟三丗且)
    {
        this.obj = 丒丈丑丕丟丟三丗且;
        if(this._inUse != false)
        {
                this._inUse = false;
            this.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        }
        
        this.currentChunk = 0;
    }
    public void 丅专下万丕丑丆丅丝(UnityEngine.Transform 丒丈丑丕丟丟三丗且, bool 丛世丘丙丑世丛世丁)
    {
        this.obj = 丒丈丑丕丟丟三丗且;
        var val_1 = (this._inUse == true) ? 1 : 0;
        val_1 = val_1 ^ 丛世丘丙丑世丛世丁;
        if(val_1 != false)
        {
                bool val_2 = 丛世丘丙丑世丛世丁;
            this._inUse = val_2;
            this.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  val_2);
        }
        
        this.currentChunk = 0;
    }
    public TerrainObjectsPull.PoolObj()
    {
        this._coliders = new UnityEngine.Collider[0];
        this._renderers = new UnityEngine.Renderer[0];
        this._needTurnOnColliders = true;
        this._collidersRecalculationFrame = 0;
    }

}
