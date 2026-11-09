using UnityEngine;
private sealed class EmbeddedConfig.七丆丏丄丙丁丄丐三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.EmbeddedConfig 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 七不丆三丏一世下丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EmbeddedConfig.七丆丏丄丙丁丄丐三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.IsDirty == false)
        {
                return false;
        }
        
        label_27:
        if((this.丝且与丝丒丟万丁专.IsDirty == false) || ((this.七不丆三丏一世下丌 & 1) != 0))
        {
                return false;
        }
        
        System.DateTime val_3 = System.DateTime.Now;
        System.TimeSpan val_4 = val_3.dateData.Subtract(value:  new System.DateTime() {dateData = this.丝且与丝丒丟万丁专.东且丅万丌丌三丑丗});
        System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  3);
        if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_4._ticks}, t2:  new System.TimeSpan() {_ticks = val_5._ticks})) == false)
        {
            goto label_13;
        }
        
        object[] val_7 = new object[2];
        val_7[0] = this.丝且与丝丒丟万丁专._configPlatform;
        val_8 = this.丝且与丝丒丟万丁专.东且丅万丌丌三丑丗;
        val_7[1] = val_8;
        UnityEngine.Debug.LogFormat(format:  "[E_mbeddedConfig] WaitThenSaveCoroutine => Requesting save... Platform: {0}, IsDirty: true, LastUpdated: {1:s}", args:  val_7);
        if(this.丝且与丝丒丟万丁专.丒丄丟下丐世丌三丆 == null)
        {
                return false;
        }
        
        val_8 = 1152921504619573248;
        val_9 = null;
        val_9 = null;
        this.丝且与丝丒丟万丁专.丒丄丟下丐世丌三丆.Invoke(sender:  this.丝且与丝丒丟万丁专, e:  System.EventArgs.Empty);
        return false;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_27;
        }
        
        goto label_27;
        label_13:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
