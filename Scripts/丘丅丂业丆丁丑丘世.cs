using UnityEngine;
private sealed class 丟丑业丟世丄丒与丅.丘丅丂业丆丁丑丘世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅 丝且与丝丒丟万丁专;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丟丑业丟世丄丒与丅.丘丅丂业丆丁丑丘世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Exception val_10;
        ulong val_11;
        var val_12;
        var val_13;
        int val_14;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(0 != 0)
        {
                System.DateTime val_1 = X21.丏业与世丌丑丝丏且();
            val_11 = val_1.dateData;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = this.丝且与丝丒丟万丁专.丅下东丂丞丑下丞丁}, d2:  new System.DateTime() {dateData = val_11});
            long val_4 = System.Math.Max(val1:  0, val2:  (long)val_2._ticks.TotalSeconds);
            val_12 = null;
            val_12 = null;
            if(val_4 != PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅.丕丞丟万丁丘丕丅丝)
        {
                string val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10365");
            val_11 = val_6;
            string val_7 = System.String.Format(format:  val_6, arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_4, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            this.与且专丈不万东一万.<丝丟丆丐业丘丏丝上>k__BackingField.cooldownLabel.text = val_7;
            val_13 = null;
            val_13 = null;
            PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅.丕丞丟万丁丘丕丅丝 = val_4;
        }
        
            this.丒上七丌业七丟与丐 = PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.丁东丁上丝不丕且上();
            val_14 = 1;
            this.丗丏丅丕丆世丁专丟 = val_14;
            return (bool)val_14;
        }
        
        }
        
        val_14 = 0;
        return (bool)val_14;
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
