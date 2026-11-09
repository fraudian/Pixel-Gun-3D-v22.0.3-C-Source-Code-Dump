using UnityEngine;
internal class TournamentController.七丗三上丗下丄三丛
{
    // Fields
    public int 丛下丅丘丞丙万丟与;
    public int 业专丟丒丆丐一丁丏;
    public int 丛且丕丛丂世下一丂;
    public System.Collections.Generic.List<Rilisoft.OfferItem> 且丆七下且丐丁与丌;
    public System.Collections.Generic.List<Rilisoft.OfferItem> 丘丙丌丂丕丞丏丁丒;
    public int 一七东丑丘世丑丙不;
    public string 三万万丒丏丒不丐丙;
    public int 下丅丌丌丆不东专丁;
    public int 丂丐下丕丄专丞世丘;
    public int 且丒丛与丞世丙丕丌;
    public int 七七丛丅一专丒东不;
    
    // Methods
    internal Rilisoft.OfferItem 丈丅一万专下七丏与()
    {
        return this.一丕丛上丟业丄业丟(上业丟世三与七七三:  this.且丆七下且丐丁与丌);
    }
    internal Rilisoft.OfferItem 丅丟丞丌三下丌丝丁()
    {
        return this.一丕丛上丟业丄业丟(上业丟世三与七七三:  this.丘丙丌丂丕丞丏丁丒);
    }
    private Rilisoft.OfferItem 一丕丛上丟业丄业丟(System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)
    {
        var val_8;
        if(上业丟世三与七七三 == null)
        {
                return 0;
        }
        
        if(上业丟世三与七七三.Count < 1)
        {
                return 0;
        }
        
        var val_8 = 0;
        label_7:
        val_8 = 上业丟世三与七七三.Item[0];
        if(val_8.IsKnownItem == false)
        {
            goto label_4;
        }
        
        val_8 = 上业丟世三与七七三.Item[0];
        if(val_8.IsExists == false)
        {
            goto label_6;
        }
        
        label_4:
        val_8 = val_8 + 1;
        if(val_8 < 上业丟世三与七七三.Count)
        {
            goto label_7;
        }
        
        return 0;
        label_6:
        Rilisoft.OfferItem val_7 = 上业丟世三与七七三.Item[0];
        return 0;
    }
    internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 且业上丞丄丁专不丙()
    {
        string val_14;
        int val_15;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        if(this.一七东丑丘世丑丙不 >= 1)
        {
                PGCompany.三东丏不丗世丅丌丄 val_2 = new PGCompany.三东丏不丗世丅丌丄(丆专且丕专丗与一丏:  247);
            val_2.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.一七东丑丘世丑丙不);
            val_1.Add(item:  val_2);
        }
        
        if(this.下丅丌丌丆不东专丁 >= 1)
        {
                PGCompany.三东丏不丗世丅丌丄 val_3 = new PGCompany.三东丏不丗世丅丌丄(丆专且丕专丗与一丏:  223);
            val_3.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.下丅丌丌丆不东专丁);
            val_1.Add(item:  val_3);
        }
        
        val_14 = this.三万万丒丏丒不丐丙;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_14)) != false)
        {
                PGCompany.三东丏不丗世丅丌丄 val_5 = null;
            val_14 = val_5;
            val_5 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  83, 丞丅上丏丂且下丅与:  this.三万万丒丏丒不丐丙);
            val_5.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
            val_1.Add(item:  val_5);
        }
        
        Rilisoft.OfferItem val_6 = val_1.一丕丛上丟业丄业丟(上业丟世三与七七三:  this.且丆七下且丐丁与丌);
        if(val_6 != null)
        {
                val_14 = val_6.ItemParams;
            val_1.Add(item:  val_14);
        }
        
        Rilisoft.OfferItem val_8 = val_1.一丕丛上丟业丄业丟(上业丟世三与七七三:  this.丘丙丌丂丕丞丏丁丒);
        if(val_8 != null)
        {
                val_14 = val_8.ItemParams;
            val_1.Add(item:  val_14);
        }
        
        if(this.且丒丛与丞世丙丕丌 == 3)
        {
            goto label_16;
        }
        
        if(this.且丒丛与丞世丙丕丌 == 2)
        {
            goto label_17;
        }
        
        if(this.且丒丛与丞世丙丕丌 != 1)
        {
                return val_1;
        }
        
        val_15 = this.丛下丅丘丞丙万丟与;
        goto label_20;
        label_16:
        val_15 = this.丛且丕丛丂世下一丂;
        goto label_20;
        label_17:
        val_15 = this.业专丟丒丆丐一丁丏;
        label_20:
        if(val_15 == 1)
        {
                return val_1;
        }
        
        val_14 = Rilisoft.上专业三丟丁丞专下.丛丕七丞丟世丒丈七(丞丅上丏丂且下丅与:  ((val_15 + 1) == 4) ? 1000 : (val_15 + 1));
        PGCompany.三东丏不丗世丅丌丄 val_13 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  106, 丞丅上丏丂且下丅与:  val_14);
        val_13.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
        val_1.Add(item:  val_13);
        return val_1;
    }
    public TournamentController.七丗三上丗下丄三丛()
    {
        this.丛下丅丘丞丙万丟与 = 0;
        this.业专丟丒丆丐一丁丏 = 0;
        this.丛且丕丛丂世下一丂 = 0;
    }

}
