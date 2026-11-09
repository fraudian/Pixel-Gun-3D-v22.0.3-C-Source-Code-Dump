using UnityEngine;
private sealed class BattlePassController.业万丌丏丙丘丗七丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BattlePassController 丝且与丝丒丟万丁专;
    public PGCompany.BattlePass.上丕丁专三丗丝万丆 丅丑丈丂三业丆三万;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassController.业万丌丏丙丘丗七丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_12;
        string val_13;
        var val_14;
        int val_15;
        val_12 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_13 = this.丅丑丈丂三业丆三万.丕世丝七世与三丞一();
        if((this.丝且与丝丒丟万丁专.下丁不丐丈丌丟丂丝.ContainsKey(key:  val_13)) == true)
        {
            goto label_16;
        }
        
        val_13 = this.丅丑丈丂三业丆三万.丕世丝七世与三丞一();
        if((this.丝且与丝丒丟万丁专.丁丛专七丈丝七下丌.ContainsKey(key:  val_13)) == true)
        {
            goto label_16;
        }
        
        val_13 = this.丅丑丈丂三业丆三万.丕世丝七世与三丞一();
        this.丝且与丝丒丟万丁专.丁丛专七丈丝七下丌.set_Item(key:  val_13, value:  true);
        val_14 = null;
        val_14 = null;
        string val_6 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  BattlePassController.丏丈东上丛东丝丐七);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
        {
            goto label_16;
        }
        
        UnityEngine.ResourceRequest val_8 = UnityEngine.Resources.LoadAsync(path:  val_6);
        this.丅丒丑丄丞丑下丈丕 = val_8;
        this.丒上七丌业七丟与丐 = val_8;
        val_15 = 1;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = this.丅丑丈丂三业丆三万.丕世丝七世与三丞一();
        val_13 = this.丅丒丑丄丞丑下丈丕.asset;
        if(this.丝且与丝丒丟万丁专.下丁不丐丈丌丟丂丝 == null)
        {
            goto label_21;
        }
        
        if(val_13 != null)
        {
            goto label_22;
        }
        
        goto label_25;
        label_21:
        if(val_13 == null)
        {
            goto label_25;
        }
        
        label_22:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_25:
        this.丝且与丝丒丟万丁专.下丁不丐丈丌丟丂丝.set_Item(key:  val_12, value:  val_13);
        label_16:
        val_15 = 0;
        return (bool)val_15;
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
