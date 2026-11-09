using UnityEngine;
private sealed class 一丟专且三万丞丁丂.丐一丄与业七丅丟业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private System.DateTime 丄一丘丑丗丏东业一;
    private bool 且丙东丟丐丌专丑丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 一丟专且三万丞丁丂.丐一丄与业七丅丟业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_16;
        ulong val_17;
        bool val_18;
        int val_19;
        var val_20;
        System.Func<System.Boolean> val_22;
        val_16 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.丄一丘丑丗丏东业一 = val_1;
        if((System.DateTime.TryParse(s:  UnityEngine.PlayerPrefs.GetString(key:  "Analytics.LastSentUserStatsReturning", defaultValue:  System.String.alignConst), result: out  new System.DateTime())) == false)
        {
            goto label_5;
        }
        
        System.DateTime val_4 = 0.Date;
        System.DateTime val_5 = this.丄一丘丑丗丏东业一.Date;
        val_17 = val_5.dateData;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4.dateData}, t2:  new System.DateTime() {dateData = val_17})) == true)
        {
            goto label_8;
        }
        
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.丄一丘丑丗丏东业一}, d2:  new System.DateTime());
        var val_9 = (val_7._ticks.TotalDays > 14) ? 1 : 0;
        goto label_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_17 = this.且丙东丟丐丌专丑丝.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
        PGCompany.七丑一上且三世丝三<K, V> val_12 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
        val_12.set_Item(key:  "Returning", value:  val_17);
        Rilisoft.丝丄三业丙专丛与不.东东丄丞丑丅东世丏(丝丏业丅丈东业丝丒:  "User Stats", 丗丟上上丒丐丗丞丙:  val_12);
        UnityEngine.PlayerPrefs.SetString(key:  "Analytics.LastSentUserStatsReturning", value:  this.丄一丘丑丗丏东业一);
        val_16 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
        label_8:
        val_19 = 0;
        return (bool)val_19;
        label_5:
        val_18 = false;
        label_11:
        this.且丙东丟丐丌专丑丝 = val_18;
        val_20 = null;
        val_20 = null;
        val_22 = 一丟专且三万丞丁丂.<>c.<>9__183_0;
        if(val_22 == null)
        {
                System.Func<System.Boolean> val_14 = null;
            val_22 = val_14;
            val_14 = new System.Func<System.Boolean>(object:  一丟专且三万丞丁丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 一丟专且三万丞丁丂.<>c::万丈丏与东且与丞七());
            一丟专且三万丞丁丂.<>c.<>9__183_0 = val_22;
        }
        
        UnityEngine.WaitUntil val_15 = null;
        val_17 = val_15;
        val_15 = new UnityEngine.WaitUntil(predicate:  val_14);
        val_19 = 1;
        this.丒上七丌业七丟与丐 = val_17;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
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
