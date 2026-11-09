using UnityEngine;
public class 丁丁丒丆不丒下丟三
{
    // Fields
    internal Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东;
    internal bool 一丙不万丁三专东丕;
    internal bool 一丅丆丂七与丆丈丂;
    internal 丐七不丝丆丐丂丐下 丐丞与丐世丗与下丗;
    internal string 丞丁丑丏丄丏七丂不;
    internal int 丂丌丙丝且东丗丙万;
    internal int 丒丒丏丗丁丛丅七丙;
    internal bool 丄上丐丞上一专丑丛;
    internal bool 丂丝丞丆丗与东且丞;
    internal int 万且丒下丕丝专丟上;
    internal int 丞丆丞丘与三万丈丛;
    internal int 丙东世丟下丑丙丈丞;
    internal int 且七丙丁与丌丗与上;
    internal int 上丏万东不三一与下;
    internal double 丏丏业东上七丐万东;
    internal double 丌丑丁上丂丙与丈丞;
    internal bool 丟不世三丘与丆丘丂;
    internal bool 丘三三东且丈丅丈丛;
    internal float 东丙丂丌丒丏丅丄丕;
    internal float 丘丁七丁不丙不丟上;
    internal RatingSystem.丁上且上一丆丘与业 丕丈一丐丛世丆上万;
    internal bool 与丛下丐丆丞万万下;
    internal 丌丈不下下丘丏丌一 与丟丙丛东丒丞万丆;
    internal int 丑丂丒万三丏一丛丞;
    internal bool 不丁丛丈丙世丈万丟;
    internal bool 上三丈丅东一丛丑丑;
    internal bool 业丐丈丒丑丗丅丛丏;
    internal float 丂丅万丅不丗丌丒不;
    internal float 丆丘丛万与丏丁丐丏;
    internal int 丁丞丗业丆丒上丈丞;
    internal NetworkStartTable 丞七一丛丟下丝丏丙;
    internal bool 丌一东且丞丑且丕丝;
    internal System.Collections.Generic.List<丈万且丗丂丝丙一东> 丕世上丙一丈丙一丌;
    internal System.Collections.Generic.List<丈万且丗丂丝丙一东> 与丁丅业一丁下丑丕;
    internal System.Collections.Generic.List<丈万且丗丂丝丙一东> 丝丁上东丞七丐丑万;
    internal bool 丅且丅且丙丘丗万丞;
    internal bool 七与上丝上与丏丞丂;
    internal bool 丗与丒丒且万丄万万;
    internal bool 万丏且七丟丕丄丈上;
    
    // Methods
    internal void 与丂丞丂丝丑丗丌丐()
    {
        if(this.与丟丙丛东丒丞万丆 != 0)
        {
                return;
        }
        
        this.与丟丙丛东丒丞万丆 = 业丘丝上丈万下丕丗.丁丅丂七丝丗与丆一(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丟业丁且丏万不丗七:  this);
    }
    internal void 丑丒丂丗不丞丞不丄()
    {
        bool val_2 = this.丘丗丁丄七丄业丑一();
        this.丄上丐丞上一专丑丛 = val_2;
        this.丂丝丞丆丗与东且丞 = val_2;
        if(GameConnect.丆丁上丟丛业丄丅丝() != true)
        {
                if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return;
        }
        
        }
        
        if(this.与丟丙丛东丒丞万丆 == 3)
        {
                this.丞丆丞丘与三万丈丛 = 0;
            this.丙东世丟下丑丙丈丞 = 0;
            return;
        }
        
        int val_7 = this.丁丞丗业丆丒上丈丞;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = (this.丂丝丞丆丗与东且丞 == false) ? ((val_7 == 1) ? (1 + 1) : 1) : (val_7);
        this.丞丆丞丘与三万丈丛 = val_7;
        this.丙东世丟下丑丙丈丞 = (this.丂丝丞丆丗与东且丞 == false) ? (1 + 1) : 1;
    }
    internal void 丛一上丈世一丙丗世()
    {
        var val_5;
        RatingSystem.丁上且上一丆丘与业 val_6;
        null = null;
        if(this.丄上丐丞上一专丑丛 == false)
        {
            goto label_4;
        }
        
        if(null != 0)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        丁上且上一丆丘与业 val_4 = 丐丐丗七且丐丗丗丙(丞丙下万丗丝丄七丝:  this, 专且丙世丅专丕业丈:  false, 丞业一专不七三丁丘:  (~GameConnect.丙丘不世专且万丄丐()) & 1, 丛七丂丕一世不不丄:  (this.丄上丐丞上一专丑丛 == true) ? 1 : 0);
        mem[1152921537472893540] = val_5;
        this.丕丈一丐丛世丆上万 = val_6;
        return;
        label_4:
        if(null != 0)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    internal bool 丘丗丁丄七丄业丑一()
    {
        DungeonsController val_5;
        var val_6;
        val_5 = this;
        val_6 = 0;
        if(GameConnect.丑丌丛丈丅丅与不业() > 38)
        {
                return (bool);
        }
        
        var val_5 = 106020852 + (val_1) << 2;
        val_5 = val_5 + 106020852;
        goto (106020852 + (val_1) << 2 + 106020852);
    }
    internal bool 一且丕丏丏丈丒专丁()
    {
        return (bool)(this.与丟丙丛东丒丞万丆 == 3) ? 1 : 0;
    }
    public 丁丁丒丆不丒下丟三()
    {
    
    }

}
