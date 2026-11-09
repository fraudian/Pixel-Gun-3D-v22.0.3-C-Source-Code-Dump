using UnityEngine;
internal class 业世且丐丕专丛专丐.丏丒丙丒丝一且丅丁
{
    // Fields
    internal long 丗丒丂丕丂业业丟丟;
    internal long 丏不万且丑丗丄一丕;
    private PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏 世丂上丌丞且丁七丏;
    
    // Properties
    internal int 下丄丈不与世丐业专 { get; }
    internal int 丅丁丂下下丌丂丌与 { get; }
    internal long 丕上丌万七丕丗与三 { get; }
    internal long 专丏丟丝世丂三丂丐 { get; }
    internal int 且与丙丑丕专七丈专 { get; }
    internal int 丙丘丕丒丝万丐与业 { get; }
    internal int 东三上丑不丟上丝丗 { get; }
    internal int 且丑世专丐丑不下丏 { get; }
    internal int 丆丁丂三丏上世专丘 { get; }
    internal System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三> 下丄世下业丑丏丕丕 { get; }
    internal System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏> 丘下丕世丈丄业世不 { get; }
    
    // Methods
    internal int 业上丙丞丐丄丆丅七()
    {
    
    }
    internal int 上丞一三七丏丒与不()
    {
    
    }
    internal long 丟丝上且世东丂丒丞()
    {
        return 丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = this.世丂上丌丞且丁七丏.StartTime});
    }
    internal long 一丆丘万丝专丑丕丟()
    {
        return 丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = this.世丂上丌丞且丁七丏.EndTime});
    }
    internal int 东丏丕丝七丒丂丄三()
    {
    
    }
    internal int 丈三丗丟不丆丐东丄()
    {
    
    }
    internal int 丟丒七丕丞丈业万丂()
    {
    
    }
    internal int 丙丈丗丌丘三丄业且()
    {
    
    }
    internal int 世丞丏丁丝丏丙丙丑()
    {
    
    }
    internal System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三> 万七丏丂丞三东丁丗()
    {
        if(this.世丂上丌丞且丁七丏 != null)
        {
                return (System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>)this.世丂上丌丞且丁七丏.LevelSettings;
        }
        
        return (System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丝丄丘丝七丄下万三>)this.世丂上丌丞且丁七丏.LevelSettings;
    }
    internal System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏> 丕万丙丏不丈七七东()
    {
        if(this.世丂上丌丞且丁七丏 != null)
        {
                return (System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏>)this.世丂上丌丞且丁七丏.InappSettings;
        }
        
        return (System.Collections.Generic.List<PGCompany.DataObjects.Piggy.丅七丑丛丄丕丅东丏>)this.世丂上丌丞且丁七丏.InappSettings;
    }
    internal 业世且丐丕专丛专丐.丏丒丙丒丝一且丅丁(PGCompany.DataObjects.Piggy.丘且丐丟一万丝丞丏 上世丏丁世丟世丆业)
    {
        this.丗丒丂丕丂业业丟丟 = 0;
        this.丏不万且丑丗丄一丕 = 0;
        this.世丂上丌丞且丁七丏 = 上世丏丁世丟世丆业;
        this.丁下丗一丛丅丟丈丗();
    }
    private void 丁下丗一丛丅丟丈丗()
    {
        long val_1 = PixelTime.丝丗专上三不丄丑丑();
        if(val_1 < 1)
        {
                return;
        }
        
        if(this.丟丝上且世东丂丒丞() < 1)
        {
                return;
        }
        
        if(this.一丆丘万丝专丑丕丟() < 1)
        {
                return;
        }
        
        if(this.业上丙丞丐丄丆丅七() == Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().丐丂丏丑丄丑丛丂丝())
        {
                int val_8 = Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().专不丐丏丐东三丑丄();
            this.丗丒丂丕丂业业丟丟 = (long)val_8;
            long val_29 = (long)this.东丏丕丝七丒丂丄三();
            val_29 = val_29 + (val_8 << );
            this.丏不万且丑丗丄一丕 = val_29;
            return;
        }
        
        if(this.业上丙丞丐丄丆丅七() == Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().上丙丐丞丐丞丒七不())
        {
                int val_17 = this.东丏丕丝七丒丂丄三() + Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().专不丐丏丐东三丑丄();
            val_17 = val_17 + this.丟丒七丕丞丈业万丂();
            this.丗丒丂丕丂业业丟丟 = (long)val_17;
            long val_18 = System.Math.Max(val1:  (long)val_17, val2:  val_1);
            this.丗丒丂丕丂业业丟丟 = val_18;
            long val_20 = System.Math.Max(val1:  val_18, val2:  this.丟丝上且世东丂丒丞());
            this.丗丒丂丕丂业业丟丟 = val_20;
            this.丏不万且丑丗丄一丕 = val_20 + (this.东丏丕丝七丒丂丄三() << );
            if(this.丗丒丂丕丂业业丟丟 < this.一丆丘万丝专丑丕丟())
        {
                return;
        }
        
            mem2[0] = 0;
            mem2[0] = 0;
            return;
        }
        
        this.丗丒丂丕丂业业丟丟 = val_1;
        long val_25 = System.Math.Max(val1:  val_1, val2:  this.丟丝上且世东丂丒丞());
        this.丗丒丂丕丂业业丟丟 = val_25;
        this.丏不万且丑丗丄一丕 = val_25 + (this.东丏丕丝七丒丂丄三() << );
        if(this.丗丒丂丕丂业业丟丟 < this.一丆丘万丝专丑丕丟())
        {
                return;
        }
        
        this.丗丒丂丕丂业业丟丟 = 0;
        mem[1152921559579045528] = 0;
    }
    private void 一一丟三三三丙一丞()
    {
        if(this.丗丒丂丕丂业业丟丟 < this.一丆丘万丝专丑丕丟())
        {
                return;
        }
        
        this.丗丒丂丕丂业业丟丟 = 0;
        mem[1152921559579173912] = 0;
    }

}
