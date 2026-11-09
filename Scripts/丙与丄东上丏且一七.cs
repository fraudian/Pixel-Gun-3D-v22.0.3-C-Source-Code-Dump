using UnityEngine;
private sealed class 丏下丞上世丘不业万.丙与丄东上丏且一七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    private System.DateTime 一丅丂丐七丏且丁东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丏下丞上世丘不业万.丙与丄东上丏且一七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 val_15;
        ulong val_16;
        var val_17;
        int val_18;
        var val_19;
        val_15 = this;
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
            goto label_52;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.DateTime val_1 = PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.一丕丒东下丙丆丝丆();
        val_16 = val_1.dateData;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不}, d2:  new System.DateTime() {dateData = val_16})) == true)
        {
            goto label_52;
        }
        
        System.DateTime val_3 = val_16.丏业与世丌丑丝丏且();
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不}, d2:  new System.DateTime() {dateData = val_3.dateData});
        val_16 = 1152921504624898048;
        val_17 = null;
        val_17 = null;
        if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_4._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
        {
            goto label_24;
        }
        
        val_18 = 1;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  (float)val_4._ticks.TotalSeconds);
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(0 != 0)
        {
                if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东})) == false)
        {
            goto label_32;
        }
        
        }
        
        val_16 = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东}, t2:  new System.DateTime() {dateData = val_16})) == true)
        {
            goto label_32;
        }
        
        goto label_29;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_24:
        if(0 == 0)
        {
            goto label_52;
        }
        
        if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东})) == false)
        {
            goto label_26;
        }
        
        val_16 = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东}, t2:  new System.DateTime() {dateData = val_16})) == false)
        {
            goto label_29;
        }
        
        label_26:
        val_19 = null;
        if(PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.世丈且业丆丑丏丐一() != false)
        {
                object[] val_13 = new object[5];
            val_13[0] = "PrimaryState.DelayedPostRefreshTimerEventCoroutine";
            val_13[1] = "actualServerTimeUtc";
            val_13[2] = this.一丅丂丐七丏且丁东;
            val_13[3] = "_refreshTimeUtc";
            val_16 = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不;
            val_13[4] = val_16;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "[{0}] {1}: {2:O}, {3}: {4:O}", args:  val_13));
        }
        
        label_32:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_18 = 1;
        return (bool)val_18;
        label_29:
        val_15 = this.与且专丈不万东一万;
        val_15.专丌丅不丑丛丘丑丝(丙不不丒丁丄丄与丛:  8);
        label_52:
        val_18 = 0;
        return (bool)val_18;
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
