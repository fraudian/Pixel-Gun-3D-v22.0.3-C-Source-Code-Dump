using UnityEngine;
private sealed class TransportControllerBase.丈上东丘不丝丙丌不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丞丅上丏丂且下丅与;
    public TransportControllerBase 丝且与丝丒丟万丁专;
    public bool 丅丏丟一不丛丝丟丗;
    public int 丝一东丄丕丁不一丕;
    private NetworkStartTable 且丙丝丙丙丂下丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransportControllerBase.丈上东丘不丝丙丌不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TransportControllerBase val_16;
        var val_17;
        System.Predicate<T> val_18;
        NetworkStartTable val_19;
        NetworkStartTable val_20;
        int val_21;
        var val_22;
        var val_23;
        var val_24;
        val_16 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_80;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        .丞丅上丏丂且下丅与 = this.丞丅上丏丂且下丅与;
        val_17 = null;
        val_17 = null;
        System.Predicate<NetworkStartTable> val_2 = null;
        val_18 = val_2;
        val_2 = new System.Predicate<NetworkStartTable>(object:  new TransportControllerBase.丕专不东丛不业丟与(), method:  System.Boolean TransportControllerBase.丕专不东丛不业丟与::世丂三丟丏丛丒丅丆(NetworkStartTable 不且上一上丐三万丛));
        val_19 = Find(match:  val_2);
        val_20 = this;
        this.且丙丝丙丙丂下丕一 = val_19;
        if(val_19 != 0)
        {
            goto label_11;
        }
        
        goto label_80;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_16 != null)
        {
            goto label_29;
        }
        
        goto label_14;
        label_2:
        val_20 = this.且丙丝丙丙丂下丕一;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_11:
        val_18 = 1152921504848912384;
        if(mem[this.且丙丝丙丙丂下丕一] == 0)
        {
            goto label_21;
        }
        
        val_19 = mem[mem[this.且丙丝丙丙丂下丕一] + 168];
        val_19 = mem[this.且丙丝丙丙丂下丕一] + 168;
        if(val_19 != 0)
        {
            goto label_21;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
            goto label_80;
        }
        
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_21:
        val_19 = mem[this.且丙丝丙丙丂下丕一];
        if(val_19 == 0)
        {
            goto label_80;
        }
        
        if(val_16 != null)
        {
            goto label_29;
        }
        
        label_14:
        label_29:
        if(this.丝且与丝丒丟万丁专.三世丕丏万一丘丘丈 != null)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_21 = 1;
            return (bool)val_21;
        }
        
        val_18 = 1152921504848912384;
        val_19 = this.且丙丝丙丙丂下丕一.丌丑丛业丈丘世丞丕;
        if(val_19 == 0)
        {
            goto label_80;
        }
        
        val_22 = null;
        val_22 = null;
        if(val_19 == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
                val_23 = null;
            val_23 = null;
            mem2[0] = 0;
        }
        
        this.丝且与丝丒丟万丁专.三上东丝丅丈上丌一 = 0f;
        if(this.丅丏丟一不丛丝丟丗 == false)
        {
            goto label_48;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(this.且丙丝丙丙丂下丕一.丌丑丛业丈丘世丞丕.万丝一万丐且丌业丛 == true)
        {
            goto label_81;
        }
        
        }
        
        TransportControllerBase val_12 = val_16 + ((this.丝一东丄丕丁不一丕) << 3);
        if(val_16 != 0)
        {
            goto label_58;
        }
        
        val_18 = this.丝一东丄丕丁不一丕;
        TransportControllerBase val_14 = val_16 + ((this.丝一东丄丕丁不一丕) << 3);
        mem2[0] = val_19;
        val_19 = this.且丙丝丙丙丂下丕一.丌丑丛业丈丘世丞丕.mySkinName.firstPersonControl;
        val_19.丅丏丒三上东丏一专(不下业丞丌世专且丈:  val_16, 丝一东丄丕丁不一丕:  this.丝一东丄丕丁不一丕);
        goto label_80;
        label_48:
        val_24 = 0;
        goto label_67;
        label_76:
        if(TransportControllerBase.__il2cppRuntimeField_byval_arg == val_19)
        {
                typeof(TransportControllerBase).__il2cppRuntimeField_20 = 0;
        }
        
        val_24 = 1;
        label_67:
        if(val_24 < null)
        {
            goto label_76;
        }
        
        val_16 = this.且丙丝丙丙丂下丕一.丌丑丛业丈丘世丞丕.mySkinName.firstPersonControl;
        val_16.丏丞丙丒丗与且丗丕(东三丈下丌丑丂世丛:  true);
        goto label_80;
        label_58:
        label_81:
        val_16 = this.且丙丝丙丙丂下丕一.丌丑丛业丈丘世丞丕.mySkinName.firstPersonControl;
        val_16.专业上七丏三丟且丆();
        label_80:
        val_21 = 0;
        return (bool)val_21;
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
