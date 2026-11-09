using UnityEngine;
internal abstract class TransportSyncBase : VTableHolder
{
    // Fields
    internal static bool 丆丆丞丗业三上下丈;
    protected bool 丐丑丘丗一专七丘七;
    protected NetworkChunkAgent 七丟七丅丞丌丟丅东;
    
    // Properties
    internal abstract PhotonView 丐世丁不上与上丙专 { get; }
    
    // Methods
    internal abstract PhotonView 东丝丏东东上丌上丂(); // 0
    internal abstract void 一与丙东世三不丕丟(与丅丕丈丘东丝世丟 专丞上七七且丝七丗); // 0
    protected virtual void Awake()
    {
        var val_8;
        bool val_9;
        var val_10;
        var val_11;
        System.Action<System.Int32> val_12;
        val_8 = null;
        val_8 = null;
        val_9 = TransportSyncBase.丆丆丞丗业三上下丈;
        if(val_9 == false)
        {
            goto label_3;
        }
        
        if(this == null)
        {
            goto label_4;
        }
        
        val_10 = 0;
        val_9 = 1;
        goto label_9;
        label_3:
        val_11 = 0;
        val_10 = 0;
        if(this != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_4:
        val_11 = 1;
        label_8:
        val_10 = 1;
        val_9 = val_11;
        label_9:
        this.丐丑丘丗一专七丘七 = ;
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        if(this.丐丑丘丗一专七丘七 == false)
        {
                return;
        }
        
        NetworkChunkAgent val_4 = this.gameObject.AddComponent<NetworkChunkAgent>();
        this.七丟七丅丞丌丟丅东 = val_4;
        val_4.丐丞丛东一丏三丏丘(丙业与丙丗丝不丈东:  true);
        System.Action<System.Int32> val_5 = new System.Action<System.Int32>(object:  this, method:  typeof(TransportSyncBase).__il2cppRuntimeField_1A0);
        if(((System.Delegate.Combine(a:  this.七丟七丅丞丌丟丅东.OnChunkChange, b:  null)) != null) && (null != null))
        {
                val_12 = 0;
        }
        
        this.七丟七丅丞丌丟丅东.OnChunkChange = val_12;
    }
    protected virtual void 万丒业丌丝丏丅且且(int 世世不东丗不业丆业)
    {
        mem[1152921539414245268] = 世世不东丗不业丆业 + 1;
    }
    protected virtual void OnDestroy()
    {
        System.Action<System.Int32> val_5;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        if(this.七丟七丅丞丌丟丅东 == 0)
        {
                return;
        }
        
        if(((System.Delegate.Remove(source:  this.七丟七丅丞丌丟丅东.OnChunkChange, value:  new System.Action<System.Int32>(object:  this, method:  typeof(TransportSyncBase).__il2cppRuntimeField_1A0))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        this.七丟七丅丞丌丟丅东.OnChunkChange = val_5;
    }
    protected TransportSyncBase()
    {
    
    }
    private static TransportSyncBase()
    {
        TransportSyncBase.丆丆丞丗业三上下丈 = true;
    }

}
