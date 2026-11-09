using UnityEngine;
private sealed class 且一丘三专下丕丗丗.七专丙丐丝丄专丞业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丛丄业丕且丗下一万;
    public string 丞丅上丏丂且下丅与;
    public int 丗丛丁世丒且丞丒丕;
    public UnityEngine.GameObject 且丟丞丁一七丑丅丌;
    private UnityEngine.ResourceRequest 丙丘丗东丏丟丗且丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且一丘三专下丕丗丗.七专丙丐丝丄专丞业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_26;
        UnityEngine.ResourceRequest val_27;
        UnityEngine.ResourceRequest val_28;
        UnityEngine.GameObject val_29;
        int val_30;
        var val_31;
        var val_32;
        float val_33;
        var val_34;
        val_26 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_55;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = UnityEngine.Resources.LoadAsync(path:  this.丛丄业丕且丗下一万 + this.丞丅上丏丂且下丅与);
        val_28 = this.丙丘丗东丏丟丗且丗;
        this.丙丘丗东丏丟丗且丗 = val_27;
        if(val_27 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        val_28 = val_26;
        val_27 = this.丙丘丗东丏丟丗且丗;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_27 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(val_27.isDone == false)
        {
            goto label_6;
        }
        
        UnityEngine.Object val_4 = this.丙丘丗东丏丟丗且丗.asset;
        if(val_4 == null)
        {
            goto label_10;
        }
        
        val_4 = (null == null) ? (val_4) : 0;
        goto label_11;
        label_6:
        val_30 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_30;
        return (bool)val_30;
        label_10:
        val_29 = 0;
        label_11:
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_29);
        if(this.丗丛丁世丒且丞丒丕 != 1)
        {
                val_31 = null;
            val_31 = null;
            if(BonusController.丄丞丁丈与业上丞丟 != 0)
        {
                val_32 = null;
            val_32 = null;
            BonusController.丄丞丁丈与业上丞丟.且与丟丞三不丙业不(东七丛丝丑专世丏三:  this.丗丛丁世丒且丞丒丕, 业丟下丐不丆丆丄七:  0);
        }
        
        }
        
        val_5.transform.SetParent(p:  this.且丟丞丁一七丑丅丌.transform);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        val_33 = val_10.x;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_33, y = val_10.y, z = val_10.z};
        val_28 = 丁下万丟且丟丛下业.一三专丞丒丅上业上();
        if((val_28.ContainsKey(key:  this.丞丅上丏丂且下丅与)) != false)
        {
                val_28 = 1152921505171808256;
            val_34 = null;
            val_34 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != true)
        {
                string val_16 = System.String.Format(format:  "LoadGameObjectFX/Bonus_Guns_Rays/Guns_Ray_{0}", arg0:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.丞丅上丏丂且下丅与].七东与丄丕丁丛世三());
            UnityEngine.Object val_17 = UnityEngine.Resources.Load(path:  val_16);
            if(val_17 != null)
        {
                var val_18 = (null == null) ? (val_17) : 0;
        }
        else
        {
                val_28 = 0;
        }
        
            if(val_28 != 0)
        {
                UnityEngine.GameObject val_20 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_28);
            val_28 = this.且丟丞丁一七丑丅丌.transform;
            val_20.transform.SetParent(p:  val_28);
            val_26 = val_20.transform;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
            val_33 = val_24.x;
            val_26.localPosition = new UnityEngine.Vector3() {x = val_33, y = val_24.y, z = val_24.z};
        }
        else
        {
                val_26 = "Not found ray:"("Not found ray:") + val_16;
            UnityEngine.Debug.LogError(message:  val_26);
        }
        
        }
        
        }
        
        label_55:
        val_30 = 0;
        return (bool)val_30;
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
