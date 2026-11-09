using UnityEngine;
internal class MultiCountingLabel.业丐世一且丂丙丄丗
{
    // Fields
    private readonly int <专下丝丒丌且一丏丌>k__BackingField;
    private readonly int <丐七丘丞丒下丗专丟>k__BackingField;
    private bool <丒丁丆丟丞与丏不且>k__BackingField;
    private int <七丄丆丌三业一丕丐>k__BackingField;
    private float 不世丘丘不万七丕丐;
    private readonly bool 丑世与丛七丙万上三;
    private readonly float 七东丙丘丑丛丒丄丑;
    
    // Properties
    internal int 丞专丟且东三丞丁丈 { get; }
    internal int 丆三丌一丂丞丙丁丝 { get; }
    internal bool 万丛与丄东丈万专丌 { get; set; }
    internal int 丌丆不七且丄下丞丒 { get; set; }
    
    // Methods
    internal int 丙与丑业万专三丌丒()
    {
        return (int)this.<专下丝丒丌且一丏丌>k__BackingField;
    }
    internal int 丟下丑丑一不丞丂丑()
    {
        return (int)this.<丐七丘丞丒下丗专丟>k__BackingField;
    }
    internal bool 丏且丂丒丗丂且与丐()
    {
        return (bool)this.<丒丁丆丟丞与丏不且>k__BackingField;
    }
    private void 丟三丏丒丗丒丐七且(bool 丙业与丙丗丝不丈东)
    {
        this.<丒丁丆丟丞与丏不且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 专业丁丞丝丌丆丗丘()
    {
        return (int)this.<七丄丆丌三业一丕丐>k__BackingField;
    }
    private void 业一丌丝与丄丟一专(int 丙业与丙丗丝不丈东)
    {
        this.<七丄丆丌三业一丕丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal MultiCountingLabel.业丐世一且丂丙丄丗(int 丈丗与丞一上且上上, int 专丂丕丗丗东世丞下, float 与丈业丛丝丒丙一丏)
    {
        this.<专下丝丒丌且一丏丌>k__BackingField = 丈丗与丞一上且上上;
        this.<丐七丘丞丒下丗专丟>k__BackingField = 专丂丕丗丗东世丞下;
        if()
        {
                0f = 与丈业丛丝丒丙一丏 / ((float)专丂丕丗丗东世丞下 - 丈丗与丞一上且上上);
        }
        
        this.七东丙丘丑丛丒丄丑 = 0f;
        this.丑世与丛七丙万上三 = (专丂丕丗丗东世丞下 < 丈丗与丞一上且上上) ? 1 : 0;
        float val_5 = System.Math.Abs(0f);
        this.<丒丁丆丟丞与丏不且>k__BackingField = (val_5 <= (1E-07f)) ? 1 : 0;
        this.<七丄丆丌三业一丕丐>k__BackingField = (val_5 <= (1E-07f)) ? 专丂丕丗丗东世丞下 : 丈丗与丞一上且上上;
    }
    internal void 丙下丏三三丗万业丐(float 丑丗丘与丈不七东丛)
    {
        float val_4 = 丑丗丘与丈不七东丛;
        val_4 = this.不世丘丘不万七丕丐 + val_4;
        this.不世丘丘不万七丕丐 = val_4;
        if(val_4 < System.Math.Abs(this.七东丙丘丑丛丒丄丑))
        {
                return;
        }
        
        if((this.<丒丁丆丟丞与丏不且>k__BackingField) == true)
        {
                return;
        }
        
        float val_6 = this.不世丘丘不万七丕丐;
        int val_7 = this.<七丄丆丌三业一丕丐>k__BackingField;
        val_6 = val_6 / this.七东丙丘丑丛丒丄丑;
        val_7 = val_7 + (int)val_6;
        this.<七丄丆丌三业一丕丐>k__BackingField = val_7;
        this.不世丘丘不万七丕丐 = 0f;
        this.<丒丁丆丟丞与丏不且>k__BackingField = (this.丑世与丛七丙万上三 == true) ? ((val_7 < (this.<丐七丘丞丒下丗专丟>k__BackingField)) ? 1 : 0) : ((val_7 > (this.<丐七丘丞丒下丗专丟>k__BackingField)) ? 1 : 0);
    }

}
