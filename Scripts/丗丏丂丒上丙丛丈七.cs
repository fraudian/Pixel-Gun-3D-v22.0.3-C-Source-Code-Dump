using UnityEngine;
private sealed class FreePlayTaskController.丗丏丂丒上丙丛丈七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreePlayTaskController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreePlayTaskController.丗丏丂丒上丙丛丈七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_22;
        int val_23;
        ulong val_24;
        var val_25;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((PixelTime.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
                if(AuthSceneController.一不丆丏与丐丏丈丄() == true)
        {
            goto label_5;
        }
        
        }
        
        val_22 = 0;
        val_23 = 1;
        goto label_6;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.TimeSpan val_3 = this.丝且与丝丒丟万丁专.丑上万专丈且丟丅丁();
        if(val_3._ticks.TotalSeconds <= 0f)
        {
            goto label_9;
        }
        
        System.DateTimeOffset val_6 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  PixelTime.丝丗专上三不丄丑丑());
        System.DateTimeOffset val_8 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  this.丝且与丝丒丟万丁专.不丗上下且东丑万丐());
        int val_9 = val_8.m_dateTime.dateData.Year;
        int val_10 = val_8.m_dateTime.dateData.Month;
        int val_11 = val_8.m_dateTime.dateData.Day;
        int val_12 = val_8.m_dateTime.dateData.Hour;
        System.DateTime val_13 = val_8.m_dateTime.dateData.AddSeconds(value:  (double)this.丝且与丝丒丟万丁专.与七丂丅丕丝丟丙丌);
        System.DateTime val_14 = val_6.m_dateTime.dateData.Date;
        val_24 = val_14.dateData;
        System.DateTime val_15 = val_13.dateData.AddDays(value:  1);
        System.DateTime val_16 = val_15.dateData.Date;
        if(((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_24}, t2:  new System.DateTime() {dateData = val_16.dateData})) == false) || (val_6.m_dateTime.dateData.Hour < this.丝且与丝丒丟万丁专.且且丟丆一三丄一万))
        {
            goto label_24;
        }
        
        val_24 = val_6.m_dateTime.dateData.Minute;
        if(val_24 < val_13.dateData.Minute)
        {
            goto label_24;
        }
        
        this.丝且与丝丒丟万丁专.丒丛丏丟丕丞丄东丄();
        goto label_24;
        label_7:
        val_25 = 0;
        return (bool)val_25;
        label_9:
        this.丝且与丝丒丟万丁专.丒丛丏丟丕丞丄东丄();
        label_5:
        label_24:
        UnityEngine.WaitForSeconds val_21 = null;
        val_22 = val_21;
        val_21 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.丁丁丛万专东丂丅丟);
        val_23 = 2;
        label_6:
        val_25 = 1;
        this.丒上七丌业七丟与丐 = val_22;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_25;
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
