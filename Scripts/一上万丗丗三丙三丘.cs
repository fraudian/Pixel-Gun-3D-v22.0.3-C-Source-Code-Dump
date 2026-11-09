using UnityEngine;
private sealed class 丏下丞上世丘不业万.一上万丗丗三丙三丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丏下丞上世丘不业万.一上万丗丗三丙三丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万 val_13;
        ulong val_14;
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        val_12 = this;
        val_13 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.DateTime val_1 = PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.一丕丒东下丙丆丝丆();
        val_14 = val_1.dateData;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不}, d2:  new System.DateTime() {dateData = val_14})) == false)
        {
            goto label_15;
        }
        
        val_12 = System.String.alignConst;
        this.与且专丈不万东一万.<丝丟丆丐业丘丏丝上>k__BackingField.subtitleLabel.text = val_12;
        val_15 = null;
        val_15 = null;
        val_16 = 0;
        PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.丟丏丈丑丅不丞丝上 = 0;
        return (bool)val_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_15:
        if(0 == 0)
        {
                return (bool)val_16;
        }
        
        System.DateTime val_3 = 丏业与世丌丑丝丏且();
        val_14 = this.丝且与丝丒丟万丁专.丝丈丞丈业世丂与不;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_14}, d2:  new System.DateTime() {dateData = val_3.dateData});
        long val_6 = System.Math.Max(val1:  0, val2:  (long)val_4._ticks.TotalSeconds);
        val_17 = null;
        val_17 = null;
        if(val_6 != PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.丟丏丈丑丅不丞丝上)
        {
                string val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10366");
            val_14 = val_8;
            string val_9 = System.String.Format(format:  val_8, arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_6, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            val_13 = this.与且专丈不万东一万.<丝丟丆丐业丘丏丝上>k__BackingField.subtitleLabel;
            val_13.text = val_9;
            val_18 = null;
            val_18 = null;
            PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.丟丏丈丑丅不丞丝上 = val_6;
            val_17 = null;
        }
        
        val_16 = 1;
        this.丒上七丌业七丟与丐 = PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.丁东丁上丝不丕且上();
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
        label_2:
        val_16 = 0;
        return (bool)val_16;
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
