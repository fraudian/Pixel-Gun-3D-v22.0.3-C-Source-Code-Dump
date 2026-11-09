using UnityEngine;
internal sealed class KillrateController : Singleton<KillrateController>
{
    // Fields
    internal KillRateObject 丂一丌万丐丌丟丘万;
    internal int 丏丐一七丑下丘丌且;
    
    // Properties
    internal KillRateObject 丕世丒丝专丒丟丁丂 { get; }
    internal KillRateObject 下丈丕三三丄三上丗 { get; }
    
    // Methods
    internal KillRateObject 万上丗丂丅丕丙且丆()
    {
        Progress.丏丄三东不世丞业一 val_1 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        if(val_1.且丈丘七丐下专东丁 != null)
        {
                return (KillRateObject)val_1.且丈丘七丐下专东丁.丕上东七丘丙丆丟丒;
        }
        
        return (KillRateObject)val_1.且丈丘七丐下专东丁.丕上东七丘丙丆丟丒;
    }
    internal KillRateObject 世丏丒世不丏上丐丑()
    {
        Progress.丏丄三东不世丞业一 val_1 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        if(val_1.且丈丘七丐下专东丁 != null)
        {
                return (KillRateObject)val_1.且丈丘七丐下专东丁.下丌世丝丁上丗七丗;
        }
        
        return (KillRateObject)val_1.且丈丘七丐下专东丁.下丌世丝丁上丗七丗;
    }
    private void OnEnable()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void KillrateController::丟丏专东丞丄丐丏丑(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().上丆万丗丄丌丘丞且(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void KillrateController::丑业一丂丙一丝上丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌上与丙一业丑东丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void KillrateController::三丆下七不上丏丂丞(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void KillrateController::万丟丝丕丆丛丑丂七(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    private void 万丟丝丕丆丛丑丂七(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        var val_8;
        if(this.丂一丌万丐丌丟丘万 == null)
        {
                return;
        }
        
        Rilisoft.七丕丟丏三丈一丄世 val_1 = 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌();
        if((val_1.丐丕丈丐东下丌专丛(丂丛丑东不丅丈一东:  val_1, 东丞丘丈不丝丘丙丁:  false)) != false)
        {
                return;
        }
        
        this.丂一丌万丐丌丟丘万.isWin = 丗丛不丁丑专专丂且.东丐三一业与丘丂丕();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().与丏丞丅丌丟一三三(下丛丌丂丝专不业丐:  this.丂一丌万丐丌丟丘万);
        丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙().世不不丝万世且上丒();
        val_8 = null;
        val_8 = null;
        FriendsController.丄丞丁丈与业上丞丟.SyncRatingAndRoundWon(丞业一专不七三丁丘:  (this.丂一丌万丐丌丟丘万.isWin == true) ? 1 : 0);
    }
    private void OnDisable()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void KillrateController::丟丏专东丞丄丐丏丑(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌且丈丐丐且丄丙七(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void KillrateController::丑业一丂丙一丝上丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void KillrateController::三丆下七不上丏丂丞(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void KillrateController::万丟丝丕丆丛丑丂七(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    internal void 上丛丌丆丑上七世三()
    {
    
    }
    private bool 丐丕丈丐东下丌专丛(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, bool 东丞丘丈不丝丘丙丁 = False)
    {
        if(丂丛丑东不丅丈一东 > 29)
        {
                return NetworkStartTable.与一专丒东丏丘专丕();
        }
        
        var val_1 = 1;
        val_1 = val_1 << 丂丛丑东不丅丈一东;
        val_1 = val_1 & 715290114;
        if(val_1 == 0)
        {
                return NetworkStartTable.与一专丒东丏丘专丕();
        }
        
        return true;
    }
    private void 三丆下七不上丏丂丞(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        decimal val_5;
        var val_6;
        Rilisoft.七丕丟丏三丈一丄世 val_1 = 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌();
        if((val_1.丐丕丈丐东下丌专丛(丂丛丑东不丅丈一东:  val_1, 东丞丘丈不丝丘丙丁:  false)) == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = System.Decimal.Zero;
        this.丂一丌万丐丌丟丘万 = new KillRateObject(丞丗丄七专丈丕丕业:  new System.Decimal() {flags = val_5, hi = val_5, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丗丁丈一丌丆一东三:  new System.Decimal() {flags = val_5, hi = val_5, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丂丛丑东不丅丈一东:  丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌(), 业东丞丏丒业万丏丘:  false);
    }
    private void 丟丏专东丞丄丐丏丑(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
    {
        var val_4;
        var val_5;
        var val_6;
        if(this.丂一丌万丐丌丟丘万 == null)
        {
                return;
        }
        
        if((this.丐丕丈丐东下丌专丛(丂丛丑东不丅丈一东:  this.丂一丌万丐丌丟丘万.mode, 东丞丘丈不丝丘丙丁:  false)) == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        this.丂一丌万丐丌丟丘万.一丆一专丆丛专丘丌(丙业与丙丗丝不丈东:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
    }
    private void 丑业一丂丙一丝上丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_11;
        decimal val_12;
        int val_13;
        int val_14;
        var val_15;
        var val_16;
        var val_17;
        if(this.丂一丌万丐丌丟丘万 == null)
        {
                return;
        }
        
        if((this.丐丕丈丐东下丌专丛(丂丛丑东不丅丈一东:  this.丂一丌万丐丌丟丘万.mode, 东丞丘丈不丝丘丙丁:  false)) != false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_12 = System.Decimal.One;
        if(((this.丂一丌万丐丌丟丘万.mode != 2) && (this.丂一丌万丐丌丟丘万.mode != 4)) && (this.丂一丌万丐丌丟丘万.mode != 5))
        {
                if(this.丂一丌万丐丌丟丘万.mode != 16)
        {
            goto label_31;
        }
        
        }
        
        val_14 = 1152921505286238208;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_16 = null;
            val_16 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_17 = null;
            val_17 = null;
            int val_4 = 丘丑丅三丆丑丌且丝();
            if(val_4 >= 1)
        {
                int val_6 = NetworkStartTable.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  val_4, 丆丘万七一丐上且丅:  false, 丗不下丆丈丌三丛与:  true);
            val_14 = NetworkStartTable.丛且三丟丟且不丂世(与丁丟东丞丙丗丌丈:  (val_4 == 1) ? (1 + 1) : 1, 丆丘万七一丐上且丅:  false, 丗不下丆丈丌三丛与:  true);
            if(val_6 < val_14)
        {
                decimal val_8 = System.Decimal.op_Implicit(value:  val_6);
            decimal val_9 = System.Decimal.op_Implicit(value:  val_14);
            decimal val_10 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid}, d2:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
            val_12 = val_10.flags;
            val_13 = val_10.lo;
        }
        
        }
        
        }
        
        }
        
        label_31:
        this.丂一丌万丐丌丟丘万.丗下丞七丐一丐一丛(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_12, hi = val_10.hi, lo = val_13, mid = val_10.mid});
    }
    internal decimal 丙丝与丝万丞七丌与(int 一丑丗三一丛一丄业)
    {
        var val_19;
        var val_20;
        int val_21;
        int val_22;
        int val_23;
        int val_24;
        int val_25;
        var val_26;
        var val_27;
        var val_28;
        val_19 = 1152921505369411584;
        Progress.丏丄三东不世丞业一 val_1 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        if(val_1.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count < 一丑丗三一丛一丄业)
        {
                Progress.丏丄三东不世丞业一 val_3 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        }
        
        Progress.丏丄三东不世丞业一 val_5 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        val_20 = 1152921504618881024;
        val_21 = 0;
        val_22 = 0;
        val_23 = 0;
        val_24 = 0;
        val_25 = val_5.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count - 1;
        goto label_17;
        label_35:
        Progress.丏丄三东不世丞业一 val_7 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        KillRateObject val_8 = val_7.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Item[val_25];
        decimal val_9 = System.Decimal.op_Addition(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_8.kills, hi = val_8.kills});
        val_22 = val_9.flags;
        val_21 = val_9.lo;
        Progress.丏丄三东不世丞业一 val_10 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        val_20 = val_20;
        val_19 = val_19;
        KillRateObject val_11 = val_10.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Item[val_25];
        decimal val_12 = System.Decimal.op_Addition(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_11.death, hi = val_11.death});
        val_24 = val_12.flags;
        val_23 = val_12.lo;
        val_25 = val_25 - 1;
        label_17:
        Progress.丏丄三东不世丞业一 val_13 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        int val_18 = val_3.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count;
        val_18 = val_13.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count - val_18;
        if(val_25 >= val_18)
        {
            goto label_35;
        }
        
        val_26 = null;
        val_27 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_22, hi = val_9.hi, lo = val_21, mid = val_9.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                val_27 = null;
            val_22 = System.Decimal.One;
        }
        
        val_27 = null;
        val_28 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_24, hi = val_12.hi, lo = val_23, mid = val_12.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                val_28 = null;
            val_24 = System.Decimal.One;
        }
        
        decimal val_17 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_22, hi = val_22, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_24, hi = val_24, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
        return System.Math.Round(d:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, decimals:  2);
    }
    internal int 丛且业与丒丘丐丞丅(int 一丑丗三一丛一丄业)
    {
        var val_13;
        var val_14;
        int val_15;
        val_13 = 一丑丗三一丛一丄业;
        Progress.丏丄三东不世丞业一 val_1 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        if(val_1.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count < val_13)
        {
                Progress.丏丄三东不世丞业一 val_3 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
            val_13 = val_3.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count;
        }
        
        Progress.丏丄三东不世丞业一 val_5 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        val_14 = 0;
        val_15 = val_5.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count - 1;
        goto label_17;
        label_29:
        Progress.丏丄三东不世丞业一 val_7 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        KillRateObject val_8 = val_7.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Item[val_15];
        bool val_12 = val_8.isWin;
        val_15 = val_15 - 1;
        val_12 = val_12 ^ 1;
        val_14 = val_14 + val_12;
        label_17:
        Progress.丏丄三东不世丞业一 val_9 = Progress.七七世万专丕丁上业.世七丆万丆丆世一业();
        if(val_15 >= (val_9.且丈丘七丐下专东丁.丗丑丁丗丘丏与下且.Count - val_13))
        {
            goto label_29;
        }
        
        return (int)val_14;
    }
    public KillrateController()
    {
        this.丏丐一七丑下丘丌且 = 30;
    }

}
