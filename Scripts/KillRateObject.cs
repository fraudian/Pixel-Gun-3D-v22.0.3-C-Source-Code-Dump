using UnityEngine;
[Serializable]
internal class KillRateObject
{
    // Fields
    internal Rilisoft.丂上丐丄丛一一丒七 kills;
    internal Rilisoft.丂上丐丄丛一一丒七 death;
    internal bool isWin;
    internal Rilisoft.七丕丟丏三丈一丄世 mode;
    
    // Properties
    internal decimal CalculateKillRate { get; }
    
    // Methods
    internal decimal get_CalculateKillRate()
    {
        int val_4;
        var val_5;
        int val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_4 = this.kills;
        val_5 = 0;
        val_6 = this.death;
        val_7 = 0;
        val_8 = null;
        val_8 = null;
        val_9 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_4, hi = val_4}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                val_9 = null;
            val_4 = System.Decimal.One;
        }
        
        val_9 = null;
        val_10 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_6, hi = val_6}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                val_10 = null;
            val_6 = System.Decimal.One;
        }
        
        decimal val_3 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_4, hi = val_4, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_6, hi = val_6, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
        return System.Math.Round(d:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, decimals:  2);
    }
    internal KillRateObject()
    {
        var val_2;
        Rilisoft.丂上丐丄丛一一丒七 val_3;
        var val_5;
        Rilisoft.丂上丐丄丛一一丒七 val_6;
        var val_7;
        this.mode = 100;
        val_7 = null;
        val_7 = null;
        Rilisoft.丂上丐丄丛一一丒七 val_1 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        mem[1152921538217046960] = val_2;
        this.kills = val_3;
        Rilisoft.丂上丐丄丛一一丒七 val_4 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0});
        mem[1152921538217046980] = val_5;
        this.mode = 100;
        this.isWin = false;
        this.death = val_6;
    }
    internal KillRateObject(decimal 丞丗丄七专丈丕丕业, decimal 丗丁丈一丌丆一东三, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, bool 业东丞丏丒业万丏丘 = False)
    {
        var val_2;
        Rilisoft.丂上丐丄丛一一丒七 val_3;
        var val_5;
        Rilisoft.丂上丐丄丛一一丒七 val_6;
        this.mode = 100;
        Rilisoft.丂上丐丄丛一一丒七 val_1 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丞丗丄七专丈丕丕业.flags, hi = 丞丗丄七专丈丕丕业.hi, lo = 丞丗丄七专丈丕丕业.lo, mid = 丞丗丄七专丈丕丕业.mid});
        mem[1152921538217179248] = val_2;
        this.kills = val_3;
        Rilisoft.丂上丐丄丛一一丒七 val_4 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = 丗丁丈一丌丆一东三.flags, hi = 丗丁丈一丌丆一东三.hi, lo = 丗丁丈一丌丆一东三.lo, mid = 丗丁丈一丌丆一东三.mid});
        mem[1152921538217179268] = val_5;
        this.mode = 丂丛丑东不丅丈一东;
        this.isWin = 业东丞丏丒业万丏丘;
        this.death = val_6;
    }
    internal void 一丆一专丆丛专丘丌(decimal 丙业与丙丗丝不丈东)
    {
        int val_3;
        var val_4;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = this.kills, hi = this.kills}, d2:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid});
        Rilisoft.丂上丐丄丛一一丒七 val_2 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid});
        丑丒丄下丁丐专丄丞 = val_3;
        mem2[0] = val_4;
    }
    internal void 丗下丞七丐一丐一丛(decimal 丙业与丙丗丝不丈东)
    {
        int val_3;
        var val_4;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = this.death, hi = this.death}, d2:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid});
        Rilisoft.丂上丐丄丛一一丒七 val_2 = Rilisoft.丂上丐丄丛一一丒七.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid});
        丑丒丄下丁丐专丄丞 = val_3;
        mem2[0] = val_4;
    }
    public override string ToString()
    {
        decimal val_1 = this.CalculateKillRate;
        return (string)System.String.Format(format:  "{0}/{1}={2}", arg0:  this.kills, arg1:  this.death, arg2:  val_1.flags.ToString());
    }

}
