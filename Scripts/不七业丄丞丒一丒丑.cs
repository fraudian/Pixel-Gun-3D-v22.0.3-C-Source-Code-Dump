using UnityEngine;
private sealed class FreeAwardShowHandler.不七业丄丞丒一丒丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreeAwardShowHandler 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    private System.DateTime 丘万丈专丙业丂与丗;
    private UnityEngine.WaitForSecondsRealtime 世且丝丟丈专丆丑上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreeAwardShowHandler.不七业丄丞丒一丒丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_13;
        ulong val_14;
        var val_15;
        UnityEngine.WaitForSecondsRealtime val_16;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专._headerTextTimer == 0)
        {
                return false;
        }
        
            System.Nullable<System.DateTime> val_2 = PGCompany.MainStore.丐不三丆丝丅丞丞与.丏丒丏丟丑且丁上下();
            string val_3 = val_2.HasValue.丐丏七丌丕丗业且上();
            System.DateTime val_4 = PGCompany.且世万丐七丆丛丄丌.丒丌丟业丂丌丈丕丒();
            val_14 = val_4.dateData;
            this.丘万丈专丙业丂与丗 = ((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_14}, t2:  new System.DateTime() {dateData = val_3})) != true) ? (val_3) : (val_14);
            this.世且丝丟丈专丆丑上 = 0;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        if((this.业丘丝业丛丆丄一上 & 1) != 0)
        {
                return false;
        }
        
        System.DateTime val_7 = PGCompany.且世万丐七丆丛丄丌.丒丌丟业丂丌丈丕丒();
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.丘万丈专丙业丂与丗}, d2:  new System.DateTime() {dateData = val_7.dateData});
        val_14 = 1152921504624898048;
        val_15 = null;
        val_15 = null;
        if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_8._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_13 = System.String.alignConst;
            this.丝且与丝丒丟万丁专._headerTextTimer.Text = val_13;
            return false;
        }
        
        this.丝且与丝丒丟万丁专._headerTextTimer.Text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)val_8._ticks.TotalSeconds, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_16 = this.世且丝丟丈专丆丑上;
        if(val_16 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_12 = null;
            val_16 = val_12;
            val_12 = new UnityEngine.WaitForSecondsRealtime(time:  0.5f);
            this.世且丝丟丈专丆丑上 = val_16;
        }
        
        this.丒上七丌业七丟与丐 = val_16;
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
