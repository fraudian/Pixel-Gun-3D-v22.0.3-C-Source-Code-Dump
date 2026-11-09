using UnityEngine;
private sealed class 丟丑业丟世丄丒与丅.丈丌上丟丐下下丝丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    private System.DateTime 一丅丂丐七丏且丁东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丟丑业丟世丄丒与丅.丈丌上丟丐下下丝丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 val_13;
        System.DateTime val_14;
        System.DateTime val_15;
        var val_16;
        int val_17;
        var val_18;
        val_13 = this;
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
            goto label_49;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_14 = this.丝且与丝丒丟万丁专.丅下东丂丞丑下丞丁;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(0 != 0)
        {
                if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东})) == false)
        {
            goto label_29;
        }
        
        }
        
        val_15 = this.丝且与丝丒丟万丁专.丅下东丂丞丑下丞丁;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东}, t2:  new System.DateTime() {dateData = val_15})) == true)
        {
            goto label_29;
        }
        
        goto label_26;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_4:
        val_14 = 135970152;
        label_5:
        System.DateTime val_3 = X21.丏业与世丌丑丝丏且();
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 135970152}, d2:  new System.DateTime() {dateData = val_3.dateData});
        val_15 = 1152921504624898048;
        val_16 = null;
        val_16 = null;
        if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_4._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_17 = 1;
            this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  (float)val_4._ticks.TotalSeconds);
            this.丗丏丅丕丆世丁专丟 = val_17;
            return (bool)val_17;
        }
        
        label_20:
        if(0 == 0)
        {
            goto label_49;
        }
        
        if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东})) == false)
        {
            goto label_23;
        }
        
        val_15 = this.丝且与丝丒丟万丁专.丅下东丂丞丑下丞丁;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.一丅丂丐七丏且丁东}, t2:  new System.DateTime() {dateData = val_15})) == false)
        {
            goto label_26;
        }
        
        label_23:
        val_18 = null;
        if(PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅.世丈且业丆丑丏丐一() != false)
        {
                object[] val_11 = new object[5];
            val_11[0] = "CooldownState.DelayedPostAvailableTimerEventCoroutine";
            val_11[1] = "actualServerTimeUtc";
            val_11[2] = this.一丅丂丐七丏且丁东;
            val_11[3] = "_rewardAvailableTimeUtc";
            val_15 = this.丝且与丝丒丟万丁专.丅下东丂丞丑下丞丁;
            val_11[4] = val_15;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "[{0}] {1}: {2:O}, {3}: {4:O}", args:  val_11));
        }
        
        label_29:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_17 = 1;
        return (bool)val_17;
        label_26:
        val_13 = this.与且专丈不万东一万;
        val_13.专丌丅不丑丛丘丑丝(丙不不丒丁丄丄与丛:  9);
        label_49:
        val_17 = 0;
        return (bool)val_17;
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
