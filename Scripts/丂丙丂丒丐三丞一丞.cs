using UnityEngine;
private sealed class NewDayWatcher.丂丙丂丒丐三丞一丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    public Rilisoft.NewDayWatcher 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丞丝七丝七上丛丝东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NewDayWatcher.丂丙丂丒丐三丞一丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSecondsRealtime val_9;
        var val_10;
        var val_11;
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
            goto label_21;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSecondsRealtime val_3 = null;
        val_9 = val_3;
        val_3 = new UnityEngine.WaitForSecondsRealtime(time:  (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true) ? 1f : 60f);
        this.丞丝七丝七上丛丝东 = val_9;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Nullable<System.DateTime> val_4 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(( & 1) == 0)
        {
            goto label_28;
        }
        
        System.DateTime val_5 = Date;
        val_9 = val_5.dateData;
        System.DateTime val_6 = this.丝且与丝丒丟万丁专.丞丙丆一丒丞专业丟.Date;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = val_6.dateData})) == false)
        {
            goto label_28;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_15;
        }
        
        this.丝且与丝丒丟万丁专.丞丙丆一丒丞专业丟 = val_4;
        mem2[0] = ???;
        goto label_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Nullable<System.DateTime> val_8 = FriendsController.业丈丏丏丞丘丛丈丛();
        val_9 = val_8.HasValue;
        this.丝且与丝丒丟万丁专.丞丙丆一丒丞专业丟 = val_8;
        mem2[0] = X1;
        label_7:
        if((this.丝且与丝丒丟万丁专.丞丙丆一丒丞专业丟 & 1) == 0)
        {
            goto label_20;
        }
        
        label_28:
        if((this.业丘丝业丛丆丄一上 & 1) != 0)
        {
            goto label_21;
        }
        
        this.丗丏丅丕丆世丁专丟 = 2;
        val_10 = 1;
        this.丒上七丌业七丟与丐 = this.丞丝七丝七上丛丝东;
        return (bool)val_10;
        label_20:
        if((this.业丘丝业丛丆丄一上 & 1) == 0)
        {
            goto label_23;
        }
        
        label_21:
        val_10 = 0;
        return (bool)val_10;
        label_23:
        this.丗丏丅丕丆世丁专丟 = 1;
        this.丒上七丌业七丟与丐 = this.丞丝七丝七上丛丝东;
        return (bool)val_10;
        label_15:
        mem[32] = val_4.HasValue;
        mem[40] = ???;
        label_16:
        if(this.丝且与丝丒丟万丁专.东丕世丏丑丅丙一丈 == null)
        {
            goto label_28;
        }
        
        val_11 = null;
        val_11 = null;
        this.丝且与丝丒丟万丁专.东丕世丏丑丅丙一丈.Invoke(sender:  this.丝且与丝丒丟万丁专, e:  System.EventArgs.Empty);
        goto label_28;
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
