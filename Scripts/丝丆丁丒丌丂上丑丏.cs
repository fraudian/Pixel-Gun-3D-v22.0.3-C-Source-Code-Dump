using UnityEngine;
internal class 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏 : ICloneable
{
    // Fields
    internal decimal _chance;
    internal int _count;
    
    // Properties
    public decimal 一丌丐一与丂一丌丞 { get; set; }
    public int 丒专下与丑丁丆丟业 { get; set; }
    
    // Methods
    public decimal 丅与且上丈三丞七丂()
    {
        return new System.Decimal() {flags = this._chance, hi = this._chance};
    }
    public void 丝丈丙丟三不丞丝丂(decimal 丙业与丙丗丝不丈东)
    {
        this._chance = 丙业与丙丗丝不丈东;
        mem[1152921560519511864] = 丙业与丙丗丝不丈东.lo;
        mem[1152921560519511868] = 丙业与丙丗丝不丈东.mid;
    }
    public int 丂丁丏一丙丛业且丌()
    {
        return (int)this._count;
    }
    public void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
    {
        this._count = 丙业与丙丗丝不丈东;
    }
    public object Clone()
    {
        int val_2;
        丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏 val_1 = new 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏();
        if(val_1 != null)
        {
                ._chance = this._chance;
            mem[1152921560519883960] = ???;
            val_2 = this._count;
        }
        else
        {
                mem[16] = this._chance;
            mem[24] = ???;
            val_2 = this._count;
        }
        
        ._count = val_2;
        return (object)val_1;
    }
    public 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏()
    {
    
    }

}
