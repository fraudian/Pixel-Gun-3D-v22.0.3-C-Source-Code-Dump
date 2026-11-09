using UnityEngine;
private sealed class TransportControllerBase.丏一专丝丝丑丒世丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丄丆丏丙丁与丙世丆;
    public TransportControllerBase 丝且与丝丒丟万丁专;
    private TransportControllerBase.且一上丕丗与与三丝 丄丌丂东丘丗一万且;
    private NetworkStartTable 且丙丝丙丙丂下丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransportControllerBase.丏一专丝丝丑丒世丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TransportControllerBase.且一上丕丗与与三丝 val_12;
        var val_13;
        NetworkStartTable val_14;
        NetworkStartTable val_15;
        int val_16;
        var val_17;
        val_12 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_31;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new TransportControllerBase.且一上丕丗与与三丝();
        .丄丆丏丙丁与丙世丆 = this.丄丆丏丙丁与丙世丆;
        val_13 = null;
        val_13 = null;
        val_14 = Find(match:  new System.Predicate<NetworkStartTable>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean TransportControllerBase.且一上丕丗与与三丝::丒丆丌丏丈万丆丛世(NetworkStartTable 不且上一上丐三万丛)));
        val_15 = val_12;
        this.且丙丝丙丙丂下丕一 = val_14;
        if(val_14 != 0)
        {
            goto label_10;
        }
        
        goto label_31;
        label_1:
        val_15 = this.且丙丝丙丙丂下丕一;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        if((UnityEngine.Object.op_Implicit(exists:  mem[this.且丙丝丙丙丂下丕一])) != false)
        {
                val_14 = mem[this.且丙丝丙丙丂下丕一];
            if((System.String.op_Equality(a:  mem[this.且丙丝丙丙丂下丕一] + 272, b:  "-1")) != false)
        {
                val_16 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_16;
            return (bool)val_16;
        }
        
        }
        
        val_14 = mem[this.且丙丝丙丙丂下丕一];
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) != false)
        {
                val_14 = mem[mem[this.且丙丝丙丙丂下丕一] + 272];
            val_14 = mem[this.且丙丝丙丙丂下丕一] + 272;
            if((System.String.op_Equality(a:  val_14, b:  this.丝且与丝丒丟万丁专.丛丈丁丑丐业上七丙())) != false)
        {
                val_14 = this.丝且与丝丒丟万丁专.photonView;
            if(val_14.isMine != false)
        {
                val_17 = null;
            val_17 = null;
            val_14 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_14 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if((this.丝且与丝丒丟万丁专 & 1) == 0)
        {
                val_12 = this.丄丌丂东丘丗一万且;
        }
        
        }
        
        }
        
        }
        
        label_31:
        val_16 = 0;
        return (bool)val_16;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
