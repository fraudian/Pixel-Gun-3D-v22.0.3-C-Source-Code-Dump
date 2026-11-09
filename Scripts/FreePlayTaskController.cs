using UnityEngine;
internal class FreePlayTaskController : Singleton<FreePlayTaskController>
{
    // Fields
    private static System.Action 且丒丏万三丟且丞丝;
    private static System.Action 与下与七丕一七丟丁;
    private static System.Action 丑七专丑丑丘业且丑;
    private static System.Action<PGCompany.世丐下丕专东丘丏且> 丏丝丗且上丂丄丕世;
    private System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 丕丛丅专万丁万东一;
    private System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 丂一一三丅与丛下丝;
    private System.Collections.Generic.Dictionary<string, PGCompany.FreePlayTaskConfig.TaskConfig> 与一丞丘三丁丗东丂;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.丞丛上丛丟东世丝丞>> 专不丞丑与丑与一丄;
    private System.Collections.Generic.Dictionary<string, 丐丆丑丝世丕世不世> 丅与东丛万与下且丈;
    internal bool 三不专丗七丄且丝业;
    private int <丑业丂丘下丐专世不>k__BackingField;
    private int <丂业丙丘丑丌丂不业>k__BackingField;
    private int <丆万丈业丈丕东专丞>k__BackingField;
    private int 丄丕一丈丘丑丄业下;
    private long 丕丒七丗且且丈业三;
    private float 丁丁丛万专东丂丅丟;
    private int 且且丟丆一三丄一万;
    private float 与七丂丅丕丝丟丙丌;
    internal int 丙上丆丛丄万下一丕;
    internal int 丗七东一丁丁不上丈;
    internal int 丈丛丁丛专丞专丄丝;
    
    // Properties
    internal int 丌丏丝丗丙丏丞专丐 { get; set; }
    internal int 不万一丙丐丆三万丐 { get; set; }
    internal int 丙万丌三丙专丌丕专 { get; set; }
    internal int 且丟丌万丗丒三丛上 { get; set; }
    internal long 七丄丟丗丞专专万东 { get; set; }
    internal System.TimeSpan 丌上业下丁丁丝七丏 { get; }
    internal System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 专丂三丒一丂丛丄丞 { get; }
    internal int 丆与丛丈丟丒丐且上 { get; }
    internal System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 一丑丑丈且丛丒与七 { get; }
    internal int 丆丂丕丞上丄一丁且 { get; }
    
    // Methods
    private void OnInstanceCreated()
    {
        PGCompany.世丐下丕专东丘丏且.丁七丙丈丑万丕丆与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void FreePlayTaskController::三丟丒业丄上下万三(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 三七与丐世丐三丕丙)));
        PGCompany.世丐下丕专东丘丏且.一丞世专与丙与丟上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void FreePlayTaskController::万三与上一丕万业丛(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void FreePlayTaskController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丌上与丙一业丑东丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void FreePlayTaskController::丗三丏下专丂专丅不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        this.丗专丟丂东丝七丈丝();
        this.与七丂丅丕丝丟丙丌 = UnityEngine.Random.Range(min:  -60f, max:  60f);
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丈丅丏业七三且丗丛());
    }
    private void OnDestroy()
    {
        PGCompany.世丐下丕专东丘丏且.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void FreePlayTaskController::三丟丒业丄上下万三(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 三七与丐世丐三丕丙)));
        PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void FreePlayTaskController::万三与上一丕万业丛(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void FreePlayTaskController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().三丙不丘丟丅丌丝专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void FreePlayTaskController::丗三丏下专丂专丅不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    internal static void 七万不丑丞与丄下丂(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  FreePlayTaskController.且丒丏万三丟且丞丝, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丘下丝不丏丘丁丐一(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  FreePlayTaskController.且丒丏万三丟且丞丝, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 万丘三丌丞丕丏专丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  FreePlayTaskController.与下与七丕一七丟丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreePlayTaskController.与下与七丕一七丟丁 != 1152921505179000840);
    
    }
    internal static void 下丗专七万丈三丆不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  FreePlayTaskController.与下与七丕一七丟丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreePlayTaskController.与下与七丕一七丟丁 != 1152921505179000840);
    
    }
    internal static void 万丞丛丟丙上丁下丒(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  FreePlayTaskController.丑七专丑丑丘业且丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreePlayTaskController.丑七专丑丑丘业且丑 != 1152921505179000848);
    
    }
    internal static void 且丘丝丅丑丅万丄七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  FreePlayTaskController.丑七专丑丑丘业且丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreePlayTaskController.丑七专丑丑丘业且丑 != 1152921505179000848);
    
    }
    internal static void 丈丘与丝丐一丁丁与(System.Action<PGCompany.世丐下丕专东丘丏且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  FreePlayTaskController.丏丝丗且上丂丄丕世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreePlayTaskController.丏丝丗且上丂丄丕世 != 1152921505179000856);
    
    }
    internal static void 丏丛与丌且一世丄丛(System.Action<PGCompany.世丐下丕专东丘丏且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  FreePlayTaskController.丏丝丗且上丂丄丕世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(FreePlayTaskController.丏丝丗且上丂丄丕世 != 1152921505179000856);
    
    }
    internal int 丅一丟东且丅丐丒丝()
    {
        return (int)this.<丑业丂丘下丐专世不>k__BackingField;
    }
    private void 丆上丄丅丏丗东且万(int 丙业与丙丗丝不丈东)
    {
        this.<丑业丂丘下丐专世不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丟丕丒丈丐丅专上下()
    {
        return (int)this.<丂业丙丘丑丌丂不业>k__BackingField;
    }
    private void 丛东东东东丟丁一丌(int 丙业与丙丗丝不丈东)
    {
        this.<丂业丙丘丑丌丂不业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丑七丛与丟世丗下丙()
    {
        return (int)this.<丆万丈业丈丕东专丞>k__BackingField;
    }
    private void 丈丌丂丂业专丁丄世(int 丙业与丙丗丝不丈东)
    {
        this.<丆万丈业丈丕东专丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 与一丝丈丐丗三一丆()
    {
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  139)) != true)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  139, 丙业与丙丗丝不丈东:  ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) != true) ? this.<丆万丈业丈丕东专丞>k__BackingField : this.<丂业丙丘丑丌丂不业>k__BackingField);
        }
        
        int val_8 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  139);
        this.丄丕一丈丘丑丄业下 = val_8;
        return val_8;
    }
    internal void 丒丁丟丅丛丛丏丈万(int 丙业与丙丗丝不丈东)
    {
        this.丄丕一丈丘丑丄业下 = 丙业与丙丗丝不丈东;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  139, 丙业与丙丗丝不丈东:  this.丄丕一丈丘丑丄业下);
    }
    internal long 不丗上下且东丑万丐()
    {
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  140)) != true)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  140, 丙业与丙丗丝不丈东:  0);
        }
        
        long val_5 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().一丒世丂一丛万下七(下上丐丆丝丟丝丒不:  140);
        this.丕丒七丗且且丈业三 = val_5;
        return val_5;
    }
    internal void 丘丘且世丘丙世丈丕(long 丙业与丙丗丝不丈东)
    {
        this.丕丒七丗且且丈业三 = 丙业与丙丗丝不丈东;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  140, 丙业与丙丗丝不丈东:  this.丕丒七丗且且丈业三);
    }
    internal System.TimeSpan 丑上万专丈且丟丅丁()
    {
        ulong val_15;
        ulong val_16;
        ulong val_17;
        System.DateTime val_2 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  PixelTime.丝丗专上三不丄丑丑());
        int val_3 = val_2.dateData.Year;
        int val_4 = val_2.dateData.Month;
        int val_5 = val_2.dateData.Day;
        if(this.不丗上下且东丑万丐() > 0)
        {
                System.DateTime val_8 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  this.不丗上下且东丑万丐());
            val_16 = val_2.dateData;
        }
        else
        {
                val_16 = val_2.dateData;
            val_15 = val_16;
        }
        
        val_17 = 0;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_16}, t2:  new System.DateTime())) != false)
        {
                System.DateTime val_10 = val_15.Date;
            System.DateTime val_11 = val_2.dateData.Date;
            val_17 = val_11.dateData;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_10.dateData}, d2:  new System.DateTime() {dateData = val_17})) != false)
        {
                System.DateTime val_13 = 0.AddDays(value:  1);
        }
        
        }
        
        System.TimeSpan val_14 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_13.dateData}, d2:  new System.DateTime() {dateData = val_2.dateData});
        return (System.TimeSpan)val_14._ticks;
    }
    internal System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 与丑丛下且专七万丄()
    {
        return (System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>)this.丕丛丅专万丁万东一;
    }
    internal int 丘丞与且世丙上且万()
    {
        var val_5;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if((this.丕丛丅专万丁万东一 == null) || (this.丕丛丅专万丁万东一.Count < 1))
        {
            goto label_2;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = this.丕丛丅专万丁万东一.GetEnumerator();
        val_10 = 0;
        val_11 = 0;
        val_12 = 0;
        var val_9 = 0;
        label_14:
        if(((-1694289600) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        List.Enumerator<T> val_7 = val_6._value._obj.GetEnumerator();
        goto label_6;
        label_7:
        string val_8 = val_5.丐丏七丌丕丗业且上();
        label_6:
        if(((-1694289648) & 1) != 0)
        {
            goto label_7;
        }
        
        val_9 = val_9 + 1;
        mem2[0] = 100;
        val_13 = val_11;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_9 == 1) || ((1152921537272295632 + ((0 + 1)) << 2) != 100))
        {
            goto label_11;
        }
        
        var val_10 = 0;
        val_10 = val_10 ^ (val_9 >> 31);
        val_9 = val_9 + val_10;
        goto label_14;
        label_11:
        if( == 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_2:
        val_12 = 0;
        return (int)val_12;
        label_4:
        val_9 = val_9 + 1;
        mem2[0] = 125;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_9 != 1)
        {
                if( == 0)
        {
                return (int)val_12;
        }
        
            if((1152921537272295632 + ((0 + 1)) << 2) == 125)
        {
                return (int)val_12;
        }
        
            return (int)val_12;
        }
        
        if( != 0)
        {
                return (int)val_12;
        }
        
        return (int)val_12;
    }
    internal System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 不丆丘不丑业下丗与()
    {
        return (System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>)this.丂一一三丅与丛下丝;
    }
    internal int 业丘世丌丒七丏丗丕()
    {
        if(this.丂一一三丅与丛下丝 == null)
        {
                return (int)this.丂一一三丅与丛下丝;
        }
        
        return this.丂一一三丅与丛下丝.Count;
    }
    private System.Collections.IEnumerator 丈丅丏业七三且丗丛()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FreePlayTaskController.丗丏丂丒上丙丛丈七(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丒丛丏丟丕丞丄东丄()
    {
        if(PixelTime.丝丗专上三不丄丑丑() < this.不丗上下且东丑万丐())
        {
                return;
        }
        
        this.丒丁丟丅丛丛丏丈万(丙业与丙丗丝不丈东:  ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) != true) ? this.<丆万丈业丈丕东专丞>k__BackingField : this.<丂业丙丘丑丌丂不业>k__BackingField);
        this.丘丘且世丘丙世丈丕(丙业与丙丗丝不丈东:  PixelTime.丝丗专上三不丄丑丑());
        if(FreePlayTaskController.丑七专丑丑丘业且丑 == null)
        {
                return;
        }
        
        FreePlayTaskController.丑七专丑丑丘业且丑.Invoke();
    }
    internal void 丑丌丙丝万七七丏七()
    {
        var val_8;
        var val_14;
        var val_23;
        var val_25;
        var val_26;
        var val_27;
        if(this.三不专丗七丄且丝业 == false)
        {
                return;
        }
        
        if(((this.与一丝丈丐丗三一丆() - 1) & 2147483648) != 0)
        {
                return;
        }
        
        this.丒丁丟丅丛丛丏丈万(丙业与丙丗丝不丈东:  this.与一丝丈丐丗三一丆() - 1);
        Dictionary.Enumerator<TKey, TValue> val_5 = this.丕丛丅专万丁万东一.GetEnumerator();
        val_25 = 0;
        val_23 = 0;
        var val_22 = 0;
        label_19:
        if(((-1693647696) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        List.Enumerator<T> val_10 = val_9._value._obj.GetEnumerator();
        label_10:
        if(((-1693647744) & 1) == 0)
        {
            goto label_6;
        }
        
        string val_11 = val_8.丐丏七丌丕丗业且上();
        val_11.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        val_11.三七万不七下不丏万(丙业与丙丗丝不丈东:  false);
        val_11.丆且丗下万丌丝丈丘(丙业与丙丗丝不丈东:  0);
        goto label_10;
        label_6:
        val_22 = val_22 + 1;
        val_26 = val_23;
        mem2[0] = 126;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_22 == 1) || ((-1693647840 + ((0 + 1)) << 2) != 126))
        {
            goto label_16;
        }
        
        var val_23 = 0;
        val_23 = val_23 ^ (val_22 >> 31);
        val_22 = val_22 + val_23;
        goto label_19;
        label_16:
        if( == 0)
        {
            goto label_19;
        }
        
        goto label_19;
        label_4:
        val_27 = val_22 + 1;
        mem2[0] = 151;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_22 != 1) && ((-1693647840 + ((0 + 1)) << 2) == 151))
        {
                var val_24 = 0;
            val_24 = val_24 ^ (val_22 >> 31);
            val_27 = val_22 + val_24;
        }
        else
        {
                if( != 0)
        {
                val_23 = 0;
        }
        
        }
        
        this.丄三丁专丕丞丆丝不();
        this.丑东丑丈且丟丈丁不();
        this.万丂三三一丆专丙丕(与业丄丂丂丆下上丞:  this.<丑业丂丘下丐专世不>k__BackingField);
        List.Enumerator<T> val_12 = this.丂一一三丅与丛下丝.GetEnumerator();
        label_40:
        if(((-1693647744) & 1) == 0)
        {
            goto label_30;
        }
        
        string val_15 = val_14.丐丏七丌丕丗业且上();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丅世丑不丛东丙东丐(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丏丏与丗一专上丆丆:  2, 上丕丈丞丌丘丅不与:  val_15.且丆丟业丞丕丑上且(), 不丝三丗东丞万下丞:  val_15.丁丝丞与丟与丟丌三(), 丙下不丏丅丅专丂丗:  val_15.丅丙丛丑丌丆丌丕丒(), 丁丅丈丌丟世丗丗丟:  val_15.不业丙丒丂丞下丆丙().ToString(), 上业丟世三与七七三:  0);
        goto label_40;
        label_30:
        val_22 = val_22 + 1;
        mem2[0] = 278;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_22 == 1)
        {
            goto label_51;
        }
        
        if(( == 0) || ((-1693647840 + (((0 + 1) + 1)) << 2) == 278))
        {
            goto label_56;
        }
        
        label_55:
        label_56:
        if(FreePlayTaskController.与下与七丕一七丟丁 == null)
        {
                return;
        }
        
        FreePlayTaskController.与下与七丕一七丟丁.Invoke();
        return;
        label_51:
        if( != 0)
        {
            goto label_55;
        }
        
        goto label_56;
    }
    private void 丗三丏下专丂专丅不(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        if(this.三不专丗七丄且丝业 == false)
        {
                return;
        }
        
        this.万丂三三一丆专丙丕(与业丄丂丂丆下上丞:  this.<丑业丂丘下丐专世不>k__BackingField);
    }
    private void 三丟丒业丄上下万三(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 三七与丐世丐三丕丙)
    {
        var val_6;
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_20;
        int val_21;
        int val_22;
        string val_23;
        if(万不且且丛丆东丒业.不业丙丒丂丞下丆丙() != 6)
        {
                return;
        }
        
        if(三七与丐世丐三丕丙 == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        List.Enumerator<T> val_4 = 万不且且丛丆东丒业.丈丏丁东上与东丙丕().GetEnumerator();
        label_10:
        if(((-1693320224) & 1) == 0)
        {
            goto label_6;
        }
        
        val_2.set_Item(key:  val_6.丐丏七丌丕丗业且上().业上丙丞丐丄丆丅七(), value:  val_2.Count);
        goto label_10;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_20 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        if(万不且且丛丆东丒业 != null)
        {
                val_21 = 万不且且丛丆东丒业.且丆丟业丞丕丑上且();
            val_22 = 万不且且丛丆东丒业.丁丝丞与丟与丟丌三();
            val_23 = 万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒();
        }
        else
        {
                val_21 = 0.且丆丟业丞丕丑上且();
            val_22 = 0.丁丝丞与丟与丟丌三();
            val_23 = 0.丅丙丛丑丌丆丌丕丒();
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丅世丑不丛东丙东丐(丆丛丑世下一丐且丕:  val_20, 丏丏与丗一专上丆丆:  1, 上丕丈丞丌丘丅不与:  val_21, 不丝三丗东丞万下丞:  val_22, 丙下不丏丅丅专丂丗:  val_23, 丁丅丈丌丟世丗丗丟:  万不且且丛丆东丒业.不业丙丒丂丞下丆丙().ToString(), 上业丟世三与七七三:  val_2);
        if(FreePlayTaskController.丏丝丗且上丂丄丕世 == null)
        {
                return;
        }
        
        FreePlayTaskController.丏丝丗且上丂丄丕世.Invoke(obj:  万不且且丛丆东丒业);
    }
    private void 万三与上一丕万业丛(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        PGCompany.丆一一丂世七丏且丝 val_1 = 万不且且丛丆东丒业.不业丙丒丂丞下丆丙();
        if(val_1 != 6)
        {
                return;
        }
        
        val_1.万丁与与丝丐业一丏(万不且且丛丆东丒业:  万不且且丛丆东丒业);
    }
    private void 万丁与与丝丐业一丏(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        string val_13;
        int val_14;
        int val_15;
        string val_16;
        val_13 = 万不且且丛丆东丒业;
        PGCompany.GameTaskActionSettings val_2 = val_13.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        PGCompany.丒丘且上丟专东不丐 val_13 = val_2.Type;
        val_13 = val_13 - 87;
        if(val_13 <= 24)
        {
                val_13 = 1 << val_13;
            val_13 = val_13 & 29360129;
            if(val_13 != 0)
        {
                int val_3 = val_13.且丆丟业丞丕丑上且();
            if(0 != 0)
        {
                return;
        }
        
        }
        
        }
        
        if(val_13 != null)
        {
                val_14 = val_13.且丆丟业丞丕丑上且();
            val_15 = val_13.丁丝丞与丟与丟丌三();
            val_16 = val_13.丅丙丛丑丌丆丌丕丒();
        }
        else
        {
                val_14 = 0.且丆丟业丞丕丑上且();
            val_15 = 0.丁丝丞与丟与丟丌三();
            val_16 = 0.丅丙丛丑丌丆丌丕丒();
        }
        
        val_13 = val_13.不业丙丒丂丞下丆丙().ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丅世丑不丛东丙东丐(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丏丏与丗一专上丆丆:  0, 上丕丈丞丌丘丅不与:  val_14, 不丝三丗东丞万下丞:  val_15, 丙下不丏丅丅专丂丗:  val_16, 丁丅丈丌丟世丗丗丟:  val_13, 上业丟世三与七七三:  0);
    }
    private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 112)
        {
                return;
        }
        
        this.丗专丟丂东丝七丈丝();
    }
    private void 世丝丐七丕世丈丒丌()
    {
        this.丑东丑丈且丟丈丁不();
        this.丕丛丅专万丁万东一.Clear();
        this.与一丞丘三丁丗东丂.Clear();
        this.丅与东丛万与下且丈.Clear();
        this.专不丞丑与丑与一丄.Clear();
    }
    private void 丑东丑丈且丟丈丁不()
    {
        this.丏下万丑上丌丏丅不(丈丆专丂丂东上丛丞:  this.丂一一三丅与丛下丝);
        this.丂一一三丅与丛下丝.Clear();
        this.专不丞丑与丑与一丄.Clear();
    }
    private void 丄三丁专丕丞丆丝不()
    {
        var val_2 = null;
        if((FreePlayTaskController.<>c.<>9__66_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.丂一一三丅与丛下丝.ForEach(action:  FreePlayTaskController.<>c.<>9__66_0);
        return;
        label_3:
        FreePlayTaskController.<>c.<>9__66_0 = new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FreePlayTaskController.<>c::不丏丟丘业下丁丅不(PGCompany.世丐下丕专东丘丏且 业下丌下三丕丙丌下));
        if(this.丂一一三丅与丛下丝 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 丗专丟丂东丝七丈丝()
    {
        this.丛不丄与丅丘丙丁与(丛七丅东丒丅丘不业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  112));
    }
    private void 丛不丄与丅丘丙丁与(string 丛七丅东丒丅丘不业)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.丛不丄与丅丘丙丁与(上世丏丁世丟世丆业:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝());
    }
    private void 丛不丄与丅丘丙丁与(PGCompany.FreePlayTaskConfig 上世丏丁世丟世丆业)
    {
        var val_5;
        var val_25;
        System.Collections.Generic.List<TSource> val_26;
        var val_27;
        PGCompany.GameTaskActionSettings val_28;
        var val_30;
        var val_31;
        var val_36;
        val_25 = 上世丏丁世丟世丆业;
        if(val_25 == null)
        {
                return;
        }
        
        val_26 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  this.丂一一三丅与丛下丝);
        this.世丝丐七丕世丈丒丌();
        if(上世丏丁世丟世丆业.Tasks == null)
        {
                return;
        }
        
        this.三不专丗七丄且丝业 = 上世丏丁世丟世丆业.enabled;
        this.<丑业丂丘下丐专世不>k__BackingField = 上世丏丁世丟世丆业.maxActiveTask;
        this.<丂业丙丘丑丌丂不业>k__BackingField = 上世丏丁世丟世丆业.maxActiveTaskReset;
        this.<丆万丈业丈丕东专丞>k__BackingField = 上世丏丁世丟世丆业.maxActiveTaskResetVip;
        this.丙上丆丛丄万下一丕 = 上世丏丁世丟世丆业.startWeightForCategory;
        this.丗七东一丁丁不上丈 = 上世丏丁世丟世丆业.decreaseValueForCategory;
        this.丈丛丁丛专丞专丄丝 = 上世丏丁世丟世丆业.increeaseValueForCategory;
        this.丁丁丛万专东丂丅丟 = (float)上世丏丁世丟世丆业.intervalToReset;
        this.且且丟丆一三丄一万 = 上世丏丁世丟世丆业.serverHourReset;
        Dictionary.Enumerator<TKey, TValue> val_2 = 上世丏丁世丟世丆业.Tasks.GetEnumerator();
        val_25 = 0;
        val_27 = 0;
        val_28 = 0;
        label_59:
        if(((-1691908800) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        object val_9 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_6._value._obj.丐丏七丌丕丗业且上());
        if(null == null)
        {
            goto label_59;
        }
        
        if((this.丕丛丅专万丁万东一.ContainsKey(key:  1152921504628731904)) != true)
        {
                System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_11 = new System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>();
            this.丕丛丅专万丁万东一.set_Item(key:  1152921504628731904, value:  null);
        }
        
        List.Enumerator<T> val_12 = val_6._value._obj.GetEnumerator();
        label_29:
        if(((-1691908848) & 1) == 0)
        {
            goto label_14;
        }
        
        string val_13 = val_5.丐丏七丌丕丗业且上();
        int val_14 = val_13.Id;
        new PGCompany.丟丒丅丐万丈七且万() = new PGCompany.丟丒丅丐万丈七且万(丁丅丈丌丟世丗丗丟:  6, 丞丅上丏丂且下丅与:  val_14, 丗七丗丒丌三世丌丁:  val_28);
        if(new PGCompany.丟丒丅丐万丈七且万() != null)
        {
                .丛东下丌一丕丌一丁 = val_14;
            .丈丝丄不丈万丁丁下 = 1;
            .丅丁丙世且丛丕丅且 = 1152921505603223552;
        }
        else
        {
                mem[64] = val_14;
            mem[56] = val_14;
            mem[32] = 1;
        }
        
        .世丛东一专七丁万丌 = val_14;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_16 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        new PGCompany.丟丒丅丐万丈七且万().万万丐东上丙丁万东(丙业与丙丗丝不丈东:  null);
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丆专且丕专丗与一丏:  135);
        new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_26);
        new PGCompany.丟丒丅丐万丈七且万().丈丏丁东上与东丙丕().Add(item:  PGCompany.丁丑上丞业丞丟丛上.丝丑丑丐一东世丛丟(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄()));
        new PGCompany.世丐下丕专东丘丏且() = new PGCompany.世丐下丕专东丘丏且(上世丏丁世丟世丆业:  new PGCompany.丟丒丅丐万丈七且万());
        this.与一丞丘三丁丗东丂.set_Item(key:  new PGCompany.世丐下丕专东丘丏且().丅丙丛丑丌丆丌丕丒(), value:  val_13);
        this.丅与东丛万与下且丈.set_Item(key:  new PGCompany.世丐下丕专东丘丏且().丅丙丛丑丌丆丌丕丒(), value:  1152921504628731904);
        this.丕丛丅专万丁万东一.Item[1152921504628731904].Add(item:  new PGCompany.世丐下丕专东丘丏且());
        goto label_29;
        label_14:
        val_30 = 1;
        val_31 = val_27;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_30 == 1) || (484 != 484))
        {
            goto label_56;
        }
        
        val_30 = val_30 + val_28 ^ 0;
        goto label_59;
        label_56:
        if( == 0)
        {
            goto label_59;
        }
        
        goto label_59;
        label_4:
        val_36 = 0 + 1;
        mem2[0] = 512;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_36 == 1)
        {
            goto label_72;
        }
        
        if(( == 0) || ((1152921537274676416 + ((0 + 1)) << 2) == 512))
        {
            goto label_76;
        }
        
        label_75:
        label_76:
        this.丅丞丕丈东下丝丌下();
        this.万丂三三一丆专丙丕(与业丄丂丂丆下上丞:  this.<丑业丂丘下丐专世不>k__BackingField);
        this.丏下万丑上丌丏丅不(丈丆专丂丂东上丛丞:  val_26);
        return;
        label_72:
        if( != 0)
        {
            goto label_75;
        }
        
        goto label_76;
    }
    private void 丅丞丕丈东下丝丌下()
    {
        var val_4;
        var val_10;
        var val_11;
        var val_12;
        if(this.三不专丗七丄且丝业 == false)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丕丛丅专万丁万东一.GetEnumerator();
        val_10 = 0;
        val_11 = 0;
        var val_9 = 0;
        label_20:
        if(((-1691686208) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        List.Enumerator<T> val_6 = val_5._value._obj.GetEnumerator();
        label_10:
        if(((-1691686256) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_7 = val_4.丐丏七丌丕丗业且上();
        if(val_7.丏上世丞丘丐丏丌不() == false)
        {
            goto label_10;
        }
        
        val_7.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
        this.丂一一三丅与丛下丝.Add(item:  val_7);
        goto label_10;
        label_5:
        val_9 = val_9 + 1;
        mem2[0] = 106;
        val_12 = val_11;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_9 == 1) || ((1152921537274899024 + ((0 + 1)) << 2) != 106))
        {
            goto label_17;
        }
        
        var val_10 = 0;
        val_10 = val_10 ^ (val_9 >> 31);
        val_9 = val_9 + val_10;
        goto label_20;
        label_17:
        if( == 0)
        {
            goto label_20;
        }
        
        goto label_20;
        label_3:
        val_9 = val_9 + 1;
        mem2[0] = 131;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_9 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921537274899024 + ((0 + 1)) << 2) == 131)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal 丐丆丑丝世丕世不世 丂丝丌丒丁东丘丄丈(string 上万丒丐万世业不丌)
    {
        if((this.丅与东丛万与下且丈.ContainsKey(key:  上万丒丐万世业不丌)) == false)
        {
                return 0;
        }
        
        if(this.丅与东丛万与下且丈 != null)
        {
                return this.丅与东丛万与下且丈.Item[上万丒丐万世业不丌];
        }
        
        return this.丅与东丛万与下且丈.Item[上万丒丐万世业不丌];
    }
    internal void 万丂三三一丆专丙丕(int 与业丄丂丂丆下上丞)
    {
        int val_64;
        int val_65;
        var val_66;
        var val_67;
        object val_68;
        var val_69;
        var val_70;
        FreePlayTaskController.<>c val_71;
        int val_72;
        System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_73;
        var val_74;
        System.Predicate<T> val_75;
        System.Predicate<T> val_76;
        var val_77;
        var val_79;
        int val_80;
        var val_81;
        var val_82;
        val_64 = 与业丄丂丂丆下上丞;
        if(this.三不专丗七丄且丝业 == false)
        {
                return;
        }
        
        if(this.业丘世丌丒七丏丗丕() >= val_64)
        {
                return;
        }
        
        if(this.丕丛丅专万丁万东一.Count <= 0)
        {
            goto label_4;
        }
        
        if(this.业丘世丌丒七丏丗丕() >= this.丘丞与且世丙上且万())
        {
            goto label_5;
        }
        
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Repeat<System.Int32>(element:  0, count:  val_64));
        if(val_64 == 3)
        {
            goto label_6;
        }
        
        if(val_64 == 2)
        {
            goto label_7;
        }
        
        if(val_64 != 1)
        {
            goto label_8;
        }
        
        val_65 = 0;
        val_66 = 0;
        val_67 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        goto label_10;
        label_4:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        val_68 = "FreePlayTaskController in config tasks count 0";
        goto label_16;
        label_5:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        val_68 = "FreePlayTaskController CountActiveTask more than count tasks in config";
        label_16:
        UnityEngine.Debug.LogError(message:  val_68);
        return;
        label_6:
        if(val_6 == null)
        {
            goto label_23;
        }
        
        val_6.set_Item(index:  0, value:  0);
        val_6.set_Item(index:  1, value:  1);
        goto label_24;
        label_7:
        if(val_6 == null)
        {
            goto label_25;
        }
        
        val_6.set_Item(index:  0, value:  0);
        goto label_26;
        label_8:
        if(val_64 < 4)
        {
                return;
        }
        
        val_69 = 0;
        goto label_28;
        label_31:
        val_6.set_Item(index:  0, value:  0);
        val_69 = 1;
        label_28:
        if(val_69 < (val_6.Count - 3))
        {
            goto label_31;
        }
        
        int val_11 = val_6.Count;
        if(val_6 == null)
        {
            goto label_32;
        }
        
        val_6.set_Item(index:  val_11 - 3, value:  0);
        val_6.set_Item(index:  val_6.Count - 2, value:  1);
        val_70 = val_6.Count;
        goto label_33;
        label_23:
        0.set_Item(index:  0, value:  0);
        0.set_Item(index:  1, value:  1);
        label_24:
        val_65 = 2;
        val_67 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        goto label_34;
        label_25:
        0.set_Item(index:  0, value:  0);
        label_26:
        val_65 = 1;
        val_66 = 1;
        val_67 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        goto label_35;
        label_32:
        0.set_Item(index:  val_11 - 3, value:  0);
        0.set_Item(index:  0.Count - 2, value:  1);
        val_70 = 0.Count;
        label_33:
        val_67 = public System.Void System.Collections.Generic.List<System.Int32>::set_Item(int index, System.Int32 value);
        val_65 = val_70 - 1;
        label_34:
        val_66 = 2;
        label_35:
        label_10:
        val_6.set_Item(index:  val_65, value:  2);
        FreePlayTaskController.丅丆丛丄丘不丒丂丈 val_20 = new FreePlayTaskController.丅丆丛丄丘不丒丂丈();
        if(val_20 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        val_71 = 1152921537275168992;
        val_72 = 0;
        goto label_38;
        label_43:
        int val_22 = val_6.FindIndex(match:  new System.Predicate<System.Int32>(object:  val_20, method:  System.Boolean FreePlayTaskController.丅丆丛丄丘不丒丂丈::与不七丛丏丁下丛七(int 三丟东丕丄丄下下丑)));
        if((val_22 & 2147483648) == 0)
        {
                val_6.set_Item(index:  val_22, value:  0);
        }
        
        val_72 = (FreePlayTaskController.丅丆丛丄丘不丒丂丈)[1152921537275375120].七丞丙丒三丕且丌丟 + 1;
        label_38:
        .七丞丙丒三丕且丌丟 = val_72;
        val_73 = this.丂一一三丅与丛下丝;
        if(val_72 < val_73.Count)
        {
            goto label_43;
        }
        
        val_74 = val_64 - this.业丘世丌丒七丏丗丕();
        if(val_74 < 1)
        {
            goto label_44;
        }
        
        goto label_99;
        label_92:
        val_71 = FreePlayTaskController.<>c.<>9;
        System.Predicate<PGCompany.丞丛上丛丟东世丝丞> val_25 = null;
        val_75 = val_25;
        val_25 = new System.Predicate<PGCompany.丞丛上丛丟东世丝丞>(object:  val_71, method:  System.Boolean FreePlayTaskController.<>c::丈业下万万丑下万下(PGCompany.丞丛上丛丟东世丝丞 三丟东丕丄丄下下丑));
        FreePlayTaskController.<>c.<>9__72_6 = val_75;
        if(val_20 != null)
        {
            goto label_49;
        }
        
        goto label_49;
        label_62:
        System.Predicate<System.Int32> val_26 = null;
        val_76 = val_26;
        val_26 = new System.Predicate<System.Int32>(object:  FreePlayTaskController.<>c.<>9, method:  System.Boolean FreePlayTaskController.<>c::不七丘丕万丁丙丟丙(int 三丟东丕丄丄下下丑));
        FreePlayTaskController.<>c.<>9__72_2 = val_76;
        if(val_6 != null)
        {
            goto label_53;
        }
        
        goto label_53;
        label_99:
        FreePlayTaskController.与丞丂业不下丒世丐 val_27 = new FreePlayTaskController.与丞丂业不下丒世丐();
        .丝且与丝丒丟万丁专 = this;
        val_77 = null;
        val_77 = null;
        if((FreePlayTaskController.<>c.<>9__72_1) == null)
        {
            goto label_57;
        }
        
        label_76:
        if((val_6.Exists(match:  FreePlayTaskController.<>c.<>9__72_1)) == false)
        {
            goto label_59;
        }
        
        val_79 = null;
        val_79 = null;
        val_76 = FreePlayTaskController.<>c.<>9__72_2;
        if(val_76 == null)
        {
            goto label_62;
        }
        
        label_53:
        val_80 = val_6;
        val_81 = 0;
        int val_29 = val_80.Find(match:  val_26);
        goto label_64;
        label_59:
        val_81 = 0;
        val_80 = 0;
        label_64:
        .丛丝东东专丕业丑丂 = val_80;
        System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Int32> val_30 = this.上丘万丟业丛丗上东();
        .世七丘万专丐专丙万 = this.丟丌专丟专丟丘丑丌(丘七与丅丝丞丒丑下:  (FreePlayTaskController.与丞丂业不下丒世丐)[1152921537275395600].丛丝东东专丕业丑丂);
        int val_33 = System.Linq.Enumerable.Sum<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Int32>>(source:  val_30, selector:  new System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Int32>, System.Int32>(object:  val_27, method:  System.Int32 FreePlayTaskController.与丞丂业不下丒世丐::丕丈万丟丙丙七丟丂(System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, int> 三丟东丕丄丄下下丑)));
        val_71 = UnityEngine.Time.frameCount;
        int val_37 = (val_33 & (~(val_33 >> 31))) + 1;
        丐丆丑丝世丕世不世 val_38 = new System.Random(Seed:  val_71).下丕丗丛丄上丈丌不(丏丌一丁与下丆世一:  val_30, 世七丘万专丐专丙万:  (FreePlayTaskController.与丞丂业不下丒世丐)[1152921537275395600].世七丘万专丐专丙万, 丟上东丕与丗专业丞:  -1691173360);
        System.Collections.Generic.List<TSource> val_42 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.Where<PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一.Item[val_38], predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_27, method:  System.Boolean FreePlayTaskController.与丞丂业不下丒世丐::丝世世下丌东丞上丆(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑))));
        val_64 = val_81;
        if(val_42.Count == 0)
        {
            goto label_68;
        }
        
        null = new System.Random(Seed:  UnityEngine.Time.frameCount << 1);
        val_71 = val_42.Count;
        val_73 = val_42.Item[-1691140592];
        goto label_83;
        label_57:
        FreePlayTaskController.<>c.<>9__72_1 = new System.Predicate<System.Int32>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreePlayTaskController.<>c::丐丟上下丞业专丆丅(int 三丟东丕丄丄下下丑));
        if(val_6 != null)
        {
            goto label_76;
        }
        
        goto label_76;
        label_68:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "{0} Can not select random unique task of category={1} of hardness={2}. Will select random unique task", arg0:  "FreePlayTaskController", arg1:  val_38.ToString(), arg2:  (FreePlayTaskController.与丞丂业不下丒世丐)[1152921537275395600].丛丝东东专丕业丑丂));
        System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> val_52 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>>(source:  this.丕丛丅专万丁万东一);
        if(val_52.Value == 0)
        {
            goto label_82;
        }
        
        val_73 = System.Linq.Enumerable.First<PGCompany.世丐下丕专东丘丏且>(source:  ( == 0) ? (val_64) : (), predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Boolean FreePlayTaskController::丒丛丐丌丘丕丟三上(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
        if(val_73 == null)
        {
            goto label_82;
        }
        
        val_64 = ;
        goto label_83;
        label_82:
        UnityEngine.Debug.LogError(message:  "FreePlayTaskController Can not select random unique task. Are there too little tasks");
        val_73 = 0;
        label_83:
        int val_56 = val_6.IndexOf(item:  (FreePlayTaskController.与丞丂业不下丒世丐)[1152921537275395600].丛丝东东专丕业丑丂);
        if(val_56 != 1)
        {
                val_6.set_Item(index:  val_56, value:  0);
        }
        
        val_82 = null;
        val_82 = null;
        val_75 = FreePlayTaskController.<>c.<>9__72_6;
        if(val_75 == null)
        {
            goto label_92;
        }
        
        label_49:
        if((this.上下业丗且丈丄丆丞(上万丒丐万世业不丌:  val_73.丅丙丛丑丌丆丌丕丒()).Exists(match:  val_25)) != false)
        {
                if(val_73.不一丅丂上丁丈三下() == false)
        {
            goto label_96;
        }
        
        }
        
        val_73.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
        this.丂一一三丅与丛下丝.Add(item:  val_73);
        label_96:
        val_74 = val_74 - 1;
        if(val_74 != 0)
        {
            goto label_99;
        }
        
        label_44:
        if(FreePlayTaskController.且丒丏万三丟且丞丝 == null)
        {
                return;
        }
        
        FreePlayTaskController.且丒丏万三丟且丞丝.Invoke();
    }
    private 丐丆丑丝世丕世不世 下丕丗丛丄上丈丌不(System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, int> 丏丌一丁与下丆世一, System.Collections.Generic.List<丐丆丑丝世丕世不世> 世七丘万专丐专丙万, int 丟上东丕与丗专业丞)
    {
        var val_9;
        var val_9 = 0;
        val_9 = 0;
        goto label_1;
        label_8:
        if((((W23 < 1) ? 1 : 0) | ((val_9 < 丟上东丕与丗专业丞) ? 1 : 0)) == 0)
        {
                return 世七丘万专丐专丙万.Item[1];
        }
        
        if(W23 == (世七丘万专丐专丙万.Count - 1))
        {
            goto label_6;
        }
        
        val_9 = 丏丌一丁与下丆世一.Item[世七丘万专丐专丙万.Item[W23]] + val_9;
        val_9 = 1;
        label_1:
        if(2 < 世七丘万专丐专丙万.Count)
        {
            goto label_8;
        }
        
        return 5;
        label_6:
        if(世七丘万专丐专丙万 != null)
        {
                return 世七丘万专丐专丙万.Item[1];
        }
        
        return 世七丘万专丐专丙万.Item[1];
    }
    private System.Collections.Generic.List<丐丆丑丝世丕世不世> 丟丌专丟专丟丘丑丌(int 丘七与丅丝丞丒丑下)
    {
        var val_6;
        System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> val_14;
        System.Collections.Generic.HashSet<丐丆丑丝世丕世不世> val_2 = new System.Collections.Generic.HashSet<丐丆丑丝世丕世不世>(comparer:  new Rilisoft.一一丑丘丈丑丟丟三<丐丆丑丝世丕世不世>());
        val_14 = this.丕丛丅专万丁万东一;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_14.GetEnumerator();
        goto label_2;
        label_11:
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        val_14 = 0;
        goto label_3;
        label_10:
        PGCompany.丟丒丅丐万丈七且万 val_9 = val_7._value._obj.Item[0].世丈丁业丛上丘丗丐();
        if(val_9.丅丁丙世且丛丕丅且 == 丘七与丅丝丞丒丑下)
        {
                bool val_11 = val_2.Add(item:  val_7._value._obj.丙东专丂世丈丏丁丂());
        }
        
        val_14 = 1;
        label_3:
        if(val_14 < val_7._value._obj.Count)
        {
            goto label_10;
        }
        
        label_2:
        if(((-1690850144) & 1) != 0)
        {
            goto label_11;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<丐丆丑丝世丕世不世>)System.Linq.Enumerable.ToList<丐丆丑丝世丕世不世>(source:  val_2);
    }
    private System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, int> 上丘万丟业丛丗上东()
    {
        var val_13;
        var val_21;
        var val_22;
        FreePlayTaskController.丘丈万一丅东一上万 val_1 = new FreePlayTaskController.丘丈万一丅东一上万();
        .丝且与丝丒丟万丁专 = this;
        .丒丛三丈丞丆丌丞丞 = new System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Int32>(comparer:  new Rilisoft.一一丑丘丈丑丟丟三<丐丆丑丝世丕世不世>());
        丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<丐丆丑丝世丕世不世>(七丐丅专且专七三丆:  new System.Action<丐丆丑丝世丕世不世>(object:  val_1, method:  System.Void FreePlayTaskController.丘丈万一丅东一上万::一丘丗七不上丁一东(丐丆丑丝世丕世不世 三丟东丕丄丄下下丑)));
        val_21 = 0;
        goto label_5;
        label_35:
        丐丆丑丝世丕世不世 val_7 = this.丂丝丌丒丁东丘丄丈(上万丒丐万世业不丌:  this.丂一一三丅与丛下丝.Item[0].丅丙丛丑丌丆丌丕丒());
        if(((FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞.ContainsKey(key:  val_7)) == false)
        {
            goto label_32;
        }
        
        List.Enumerator<T> val_11 = System.Linq.Enumerable.ToList<丐丆丑丝世丕世不世>(source:  (FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞.Keys).GetEnumerator();
        label_22:
        if(((-1690636752) & 1) == 0)
        {
            goto label_13;
        }
        
        int val_14 = val_13.丙东专丂世丈丏丁丂();
        if(val_14 != val_7)
        {
            goto label_14;
        }
        
        (FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞.set_Item(key:  val_7, value:  (FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞.Item[val_7] - this.丗七东一丁丁不上丈);
        goto label_22;
        label_14:
        (FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞.set_Item(key:  val_14, value:  this.丈丛丁丛专丞专丄丝 + (FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞.Item[val_14]);
        goto label_22;
        label_13:
        val_22 = 0;
        var val_21 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_21 != 1)
        {
                var val_20 = 0;
            val_20 = val_20 ^ 0;
            val_21 = val_21 + val_20;
        }
        
        label_32:
        val_21 = 1;
        label_5:
        if(val_21 < this.丂一一三丅与丛下丝.Count)
        {
            goto label_35;
        }
        
        if(val_1 != null)
        {
                return (System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Int32>)(FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞;
        }
        
        return (System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Int32>)(FreePlayTaskController.丘丈万一丅东一上万)[1152921537275992720].丒丛三丈丞丆丌丞丞;
    }
    internal System.Collections.Generic.List<PGCompany.丞丛上丛丟东世丝丞> 上下业丗且丈丄丆丞(string 上万丒丐万世业不丌)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.丞丛上丛丟东世丝丞>> val_7 = this.专不丞丑与丑与一丄;
        if((val_7.ContainsKey(key:  上万丒丐万世业不丌)) != true)
        {
                this.专不丞丑与丑与一丄.set_Item(key:  上万丒丐万世业不丌, value:  new System.Collections.Generic.List<PGCompany.丞丛上丛丟东世丝丞>());
            val_7 = this.与一丞丘三丁丗东丂;
            if((val_7.ContainsKey(key:  上万丒丐万世业不丌)) != false)
        {
                val_7 = this.与一丞丘三丁丗东丂;
            if(val_7.Item[上万丒丐万世业不丌] != null)
        {
                val_7 = val_4.ConditionSettings;
            if(val_7 != null)
        {
                val_7 = PGCompany.业丕上万丑世下世上.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_7);
            if(val_7 != null)
        {
                this.专不丞丑与丑与一丄.Item[上万丒丐万世业不丌].Add(item:  val_7);
        }
        
        }
        
        }
        
        }
        
        }
        
        if(this.专不丞丑与丑与一丄 != null)
        {
                return this.专不丞丑与丑与一丄.Item[上万丒丐万世业不丌];
        }
        
        return this.专不丞丑与丑与一丄.Item[上万丒丐万世业不丌];
    }
    internal void 丞业丒丙丕不丟丕丝(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  万不且且丛丆东丒业.丈丏丁东上与东丙丕(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        this.丄丐且丘丙下丝不万(万不且且丛丆东丒业:  万不且且丛丆东丒业);
    }
    private void 丄丐且丘丙下丝不万(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
    {
        .万不且且丛丆东丒业 = 万不且且丛丆东丒业;
        this.丏下万丑上丌丏丅不(丈丆专丂丂东上丛丞:  this.丂一一三丅与丛下丝);
        PGCompany.世丐下丕专东丘丏且 val_6 = System.Linq.Enumerable.FirstOrDefault<PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一.Item[this.丂丝丌丒丁东丘丄丈(上万丒丐万世业不丌:  (FreePlayTaskController.丛三上上七丒万丑丅)[1152921537276583696].万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒())], predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  new FreePlayTaskController.丛三上上七丒万丑丅(), method:  System.Boolean FreePlayTaskController.丛三上上七丒万丑丅::七与七丈东七丒丏丐(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
        if(val_6 == null)
        {
                return;
        }
        
        val_6.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        val_6.三七万不七下不丏万(丙业与丙丗丝不丈东:  false);
        val_6.丆且丗下万丌丝丈丘(丙业与丙丗丝不丈东:  0);
        bool val_7 = this.丂一一三丅与丛下丝.Remove(item:  val_6);
        this.万丂三三一丆专丙丕(与业丄丂丂丆下上丞:  this.<丑业丂丘下丐专世不>k__BackingField);
    }
    internal void 不丝一丛丁丛七与丈()
    {
        var val_5;
        var val_11;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  181);
        System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_2 = new System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>();
        List.Enumerator<T> val_3 = this.丂一一三丅与丛下丝.GetEnumerator();
        label_9:
        if(((-1689868224) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(val_6.丞专丅丁丁三丄上专() == false)
        {
            goto label_9;
        }
        
        val_2.Add(item:  val_6);
        goto label_9;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_11 = 0;
        goto label_15;
        label_18:
        this.丞业丒丙丕不丟丕丝(万不且且丛丆东丒业:  val_2.Item[0]);
        val_11 = 1;
        label_15:
        if(val_11 < val_2.Count)
        {
            goto label_18;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    internal bool 上丛丈丕且下且不专()
    {
        var val_2;
        System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = FreePlayTaskController.<>c.<>9__80_0;
        if(val_4 != null)
        {
                return System.Linq.Enumerable.Any<PGCompany.世丐下丕专东丘丏且>(source:  this.丂一一三丅与丛下丝, predicate:  System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_1 = null);
        }
        
        val_4 = val_1;
        val_1 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreePlayTaskController.<>c::丕与与业丙丂丈东丄(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
        FreePlayTaskController.<>c.<>9__80_0 = val_4;
        return System.Linq.Enumerable.Any<PGCompany.世丐下丕专东丘丏且>(source:  this.丂一一三丅与丛下丝, predicate:  val_1);
    }
    internal void 丕丑丆专丙与丑下东(PGCompany.世丐下丕专东丘丏且 专丒专丛七丄专丂下)
    {
        FreePlayTaskController val_19;
        var val_20;
        PGCompany.世丐下丕专东丘丏且 val_21;
        var val_22;
        System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_24;
        var val_25;
        System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_27;
        PGCompany.世丐下丕专东丘丏且 val_28;
        var val_29;
        System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_31;
        var val_32;
        System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_34;
        val_19 = this;
        FreePlayTaskController.业丞丑丅丄与丑七丕 val_1 = new FreePlayTaskController.业丞丑丅丄与丑七丕();
        if(val_1 != null)
        {
                val_20 = val_1;
            .专丒专丛七丄专丂下 = 专丒专丛七丄专丂下;
        }
        else
        {
                val_20 = 16;
            mem[16] = 专丒专丛七丄专丂下;
        }
        
        .丝且与丝丒丟万丁专 = val_19;
        this.丏下万丑上丌丏丅不(丈丆专丂丂东上丛丞:  this.丂一一三丅与丛下丝);
        val_21 = System.Linq.Enumerable.FirstOrDefault<PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一.Item[this.丂丝丌丒丁东丘丄丈(上万丒丐万世业不丌:  val_20.丅丙丛丑丌丆丌丕丒())], predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_1, method:  System.Boolean FreePlayTaskController.业丞丑丅丄与丑七丕::万丘丆不丕上丅且丝(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
        if(val_21 == null)
        {
                return;
        }
        
        val_21.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        val_21.三七万不七下不丏万(丙业与丙丗丝不丈东:  false);
        val_21.丆且丗下万丌丝丈丘(丙业与丙丗丝不丈东:  0);
        bool val_7 = this.丂一一三丅与丛下丝.Remove(item:  val_21);
        val_22 = null;
        val_22 = null;
        val_24 = FreePlayTaskController.<>c.<>9__81_1;
        if(val_24 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_8 = null;
            val_24 = val_8;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且> FreePlayTaskController.<>c::上丈三丘丌丘丗七不(System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__81_1 = val_24;
        }
        
        val_25 = null;
        val_25 = null;
        val_27 = FreePlayTaskController.<>c.<>9__81_2;
        if(val_27 == null)
        {
                System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_10 = null;
            val_27 = val_10;
            val_10 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreePlayTaskController.<>c::下丅丝下万丐丝且丘(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__81_2 = val_27;
        }
        
        val_28 = System.Linq.Enumerable.FirstOrDefault<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.OrderBy<PGCompany.世丐下丕专东丘丏且, System.Int32>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一, selector:  val_8), keySelector:  val_10), predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_1, method:  System.Boolean FreePlayTaskController.业丞丑丅丄与丑七丕::丐丙丏丕丝丆丆丈丄(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
        if(val_28 != null)
        {
            goto label_18;
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = FreePlayTaskController.<>c.<>9__81_4;
        if(val_31 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_14 = null;
            val_31 = val_14;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且> FreePlayTaskController.<>c::万七丂丏且丞不丏丈(System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__81_4 = val_31;
        }
        
        val_32 = null;
        val_32 = null;
        val_34 = FreePlayTaskController.<>c.<>9__81_5;
        if(val_34 == null)
        {
                System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_16 = null;
            val_34 = val_16;
            val_16 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreePlayTaskController.<>c::丁且丟世丛丟丞丝丁(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__81_5 = val_34;
        }
        
        val_28 = System.Linq.Enumerable.First<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.OrderBy<PGCompany.世丐下丕专东丘丏且, System.Int32>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一, selector:  val_14), keySelector:  val_16));
        if(val_28 == null)
        {
            goto label_32;
        }
        
        label_18:
        val_21 = val_28;
        label_32:
        val_28.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
        val_19 = this.丂一一三丅与丛下丝;
        val_19.Add(item:  val_21);
        if(FreePlayTaskController.且丒丏万三丟且丞丝 == null)
        {
                return;
        }
        
        FreePlayTaskController.且丒丏万三丟且丞丝.Invoke();
    }
    internal void 丁丅丛丘上丕业丏丘(PGCompany.世丐下丕专东丘丏且 专丒专丛七丄专丂下)
    {
        FreePlayTaskController val_19;
        var val_20;
        PGCompany.世丐下丕专东丘丏且 val_21;
        var val_22;
        System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_24;
        var val_25;
        System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_27;
        PGCompany.世丐下丕专东丘丏且 val_28;
        var val_29;
        System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_31;
        var val_32;
        System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_34;
        val_19 = this;
        FreePlayTaskController.丆下丙不丌丂丈不一 val_1 = new FreePlayTaskController.丆下丙不丌丂丈不一();
        if(val_1 != null)
        {
                val_20 = val_1;
            .专丒专丛七丄专丂下 = 专丒专丛七丄专丂下;
        }
        else
        {
                val_20 = 16;
            mem[16] = 专丒专丛七丄专丂下;
        }
        
        .丝且与丝丒丟万丁专 = val_19;
        this.丏下万丑上丌丏丅不(丈丆专丂丂东上丛丞:  this.丂一一三丅与丛下丝);
        val_21 = System.Linq.Enumerable.FirstOrDefault<PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一.Item[this.丂丝丌丒丁东丘丄丈(上万丒丐万世业不丌:  val_20.丅丙丛丑丌丆丌丕丒())], predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_1, method:  System.Boolean FreePlayTaskController.丆下丙不丌丂丈不一::三丒万丕丐不东且丒(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
        if(val_21 == null)
        {
                return;
        }
        
        val_21.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
        val_21.三七万不七下不丏万(丙业与丙丗丝不丈东:  false);
        val_21.丆且丗下万丌丝丈丘(丙业与丙丗丝不丈东:  0);
        bool val_7 = this.丂一一三丅与丛下丝.Remove(item:  val_21);
        val_22 = null;
        val_22 = null;
        val_24 = FreePlayTaskController.<>c.<>9__82_1;
        if(val_24 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_8 = null;
            val_24 = val_8;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且> FreePlayTaskController.<>c::专丂业不且丘丂丒专(System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__82_1 = val_24;
        }
        
        val_25 = null;
        val_25 = null;
        val_27 = FreePlayTaskController.<>c.<>9__82_2;
        if(val_27 == null)
        {
                System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_10 = null;
            val_27 = val_10;
            val_10 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreePlayTaskController.<>c::且丄丄东丈七业丅丑(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__82_2 = val_27;
        }
        
        val_28 = System.Linq.Enumerable.FirstOrDefault<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.世丐下丕专东丘丏且, System.Int32>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一, selector:  val_8), keySelector:  val_10), predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_1, method:  System.Boolean FreePlayTaskController.丆下丙不丌丂丈不一::丅丌万丐丝丈万七丞(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
        if(val_28 != null)
        {
            goto label_18;
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = FreePlayTaskController.<>c.<>9__82_4;
        if(val_31 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>> val_14 = null;
            val_31 = val_14;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且>>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<PGCompany.世丐下丕专东丘丏且> FreePlayTaskController.<>c::与丞丞丘下丒丌丗丘(System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>> 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__82_4 = val_31;
        }
        
        val_32 = null;
        val_32 = null;
        val_34 = FreePlayTaskController.<>c.<>9__82_5;
        if(val_34 == null)
        {
                System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_16 = null;
            val_34 = val_16;
            val_16 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32>(object:  FreePlayTaskController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreePlayTaskController.<>c::丕丛不万丙专丄丞丅(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
            FreePlayTaskController.<>c.<>9__82_5 = val_34;
        }
        
        val_28 = System.Linq.Enumerable.First<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.世丐下丕专东丘丏且, System.Int32>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>, PGCompany.世丐下丕专东丘丏且>(source:  this.丕丛丅专万丁万东一, selector:  val_14), keySelector:  val_16));
        if(val_28 == null)
        {
            goto label_32;
        }
        
        label_18:
        val_21 = val_28;
        label_32:
        val_28.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
        val_19 = this.丂一一三丅与丛下丝;
        val_19.Add(item:  val_21);
        if(FreePlayTaskController.且丒丏万三丟且丞丝 == null)
        {
                return;
        }
        
        FreePlayTaskController.且丒丏万三丟且丞丝.Invoke();
    }
    private void 丏下万丑上丌丏丅不(System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 丈丆专丂丂东上丛丞)
    {
        System.Func<TSource, System.Boolean> val_6;
        var val_7;
        System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_1 = null;
        val_6 = val_1;
        val_1 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Boolean FreePlayTaskController::丗丅与丈专丆丛世七(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.Where<PGCompany.世丐下丕专东丘丏且>(source:  丈丆专丂丂东上丛丞, predicate:  val_1));
        val_7 = 0;
        goto label_1;
        label_6:
        val_6 = val_3.Item[0];
        if(val_6 != null)
        {
                val_6.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
            val_6.三七万不七下不丏万(丙业与丙丗丝不丈东:  false);
        }
        else
        {
                val_6.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
            val_6.三七万不七下不丏万(丙业与丙丗丝不丈东:  false);
        }
        
        val_6.丆且丗下万丌丝丈丘(丙业与丙丗丝不丈东:  0);
        val_7 = 1;
        label_1:
        if(val_7 < val_3.Count)
        {
            goto label_6;
        }
    
    }
    public FreePlayTaskController()
    {
        this.丕丛丅专万丁万东一 = new System.Collections.Generic.Dictionary<丐丆丑丝世丕世不世, System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>(comparer:  new Rilisoft.一一丑丘丈丑丟丟三<丐丆丑丝世丕世不世>());
        this.丂一一三丅与丛下丝 = new System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>();
        this.与一丞丘三丁丗东丂 = new System.Collections.Generic.Dictionary<System.String, TaskConfig>();
        this.专不丞丑与丑与一丄 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.丞丛上丛丟东世丝丞>>();
        this.三不专丗七丄且丝业 = true;
        this.<丑业丂丘下丐专世不>k__BackingField = 12884901891;
        this.<丂业丙丘丑丌丂不业>k__BackingField = 3;
        this.<丆万丈业丈丕东专丞>k__BackingField = 5;
        this.丁丁丛万专东丂丅丟 = 10f;
        this.丙上丆丛丄万下一丕 = 10;
        this.丗七东一丁丁不上丈 = -4;
        this.丅与东丛万与下且丈 = new System.Collections.Generic.Dictionary<System.String, 丐丆丑丝世丕世不世>();
        this.丈丛丁丛专丞专丄丝 = 4;
    }
    private bool 丒丛丐丌丘丕丟三上(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)
    {
        .三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        return System.Linq.Enumerable.All<PGCompany.世丐下丕专东丘丏且>(source:  this.丂一一三丅与丛下丝, predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  new FreePlayTaskController.丏丙不七丑不丌与丘(), method:  System.Boolean FreePlayTaskController.丏丙不七丑不丌与丘::丞与丑丑万丐七丏东(PGCompany.世丐下丕专东丘丏且 丒丒丄丁且丄丆丂丌)));
    }
    private bool 丗丅与丈专丆丛世七(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)
    {
        .三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        return System.Linq.Enumerable.All<System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>>(source:  this.丕丛丅专万丁万东一.Values, predicate:  new System.Func<System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>, System.Boolean>(object:  new FreePlayTaskController.丂丁丏丞丅与丗一与(), method:  System.Boolean FreePlayTaskController.丂丁丏丞丅与丗一与::丙七一丆丆丁丂丅丁(System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 丒丒丄丁且丄丆丂丌)));
    }

}
