using UnityEngine;
public class 丈丌丁下世世不下世
{
    // Fields
    private static uint[] 一万专万与丆丌与一;
    private System.Collections.BitArray 一丐丗丁丞丆丅丟丄;
    private int 三丟丈不丛专且丝丌;
    private int 东七丛丝丑专世丏三;
    
    // Properties
    private int 丞世不丒下上上丝丑 { get; set; }
    
    // Methods
    private int 丑丘专丌丄丕东与丝()
    {
        return (int)this.东七丛丝丑专世丏三;
    }
    private void 不上丐丁上且丞且丗(int 丙业与丙丗丝不丈东)
    {
        if(this.三丟丈不丛专且丝丌 <= 丙业与丙丗丝不丈东)
        {
                UnityEngine.Debug.LogError(message:  "Переполнение!");
        }
        
        this.东七丛丝丑专世丏三 = 丙业与丙丗丝不丈东;
    }
    public 丈丌丁下世世不下世(int 丟丒且一专丟丙下一)
    {
        int val_2 = 丟丒且一专丟丙下一;
        System.Collections.BitArray val_1 = null;
        val_2 = val_2 << 5;
        val_1 = new System.Collections.BitArray(length:  val_2);
        this.一丐丗丁丞丆丅丟丄 = val_1;
        this.三丟丈不丛专且丝丌 = val_2;
        this.不上丐丁上且丞且丗(丙业与丙丗丝不丈东:  0);
    }
    public 丈丌丁下世世不下世(int[] 丐丆丂丒丁万丈丛丅)
    {
        System.Collections.BitArray val_1 = new System.Collections.BitArray(values:  丐丆丂丒丁万丈丛丅);
        this.一丐丗丁丞丆丅丟丄 = val_1;
        this.三丟丈不丛专且丝丌 = val_1.Length;
        this.不上丐丁上且丞且丗(丙业与丙丗丝不丈东:  0);
    }
    public void 三丝丁丕世丑丟丈丕(bool 丙业与丙丗丝不丈东)
    {
        this.不上丐丁上且丞且丗(丙业与丙丗丝不丈东:  this.东七丛丝丑专世丏三 + 1);
        this.一丐丗丁丞丆丅丟丄.Set(index:  this.东七丛丝丑专世丏三, value:  丙业与丙丗丝不丈东);
    }
    public bool 丏丄三丙丌专丆丏上()
    {
        this.不上丐丁上且丞且丗(丙业与丙丗丝不丈东:  this.东七丛丝丑专世丏三 + 1);
        if(this.一丐丗丁丞丆丅丟丄 != null)
        {
                return this.一丐丗丁丞丆丅丟丄.Get(index:  this.东七丛丝丑专世丏三);
        }
        
        return this.一丐丗丁丞丆丅丟丄.Get(index:  this.东七丛丝丑专世丏三);
    }
    public void 三丛丛丆世丏三丅且(int 丙业与丙丗丝不丈东, int 七丝东丛东丝且丆不)
    {
        if((丙业与丙丗丝不丈东 & 2147483648) != 0)
        {
                UnityEngine.Debug.LogError(message:  "Только положительные значения");
        }
        
        int val_1 = 丈丌丁下世世不下世.丝业东丙丒一丅万万(丙业与丙丗丝不丈东:  七丝东丛东丝且丆不);
        if((七丝东丛东丝且丆不 & 2147483648) == 0)
        {
                if(val_1 > 0)
        {
            goto label_7;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "Неверно задано максимальное значение");
        label_7:
        七丝东丛东丝且丆不 = this.东七丛丝丑专世丏三 + val_1;
        丈丌丁下世世不下世.与丄丏丞业三与东丗(丌丗丏丏丛东专丁且:  this.一丐丗丁丞丆丅丟丄, 丄且一丄丏丆丐丗与:  this.东七丛丝丑专世丏三, 丈丝世且万世丈丌万:  七丝东丛东丝且丆不, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this.不上丐丁上且丞且丗(丙业与丙丗丝不丈东:  this.东七丛丝丑专世丏三 + val_1);
    }
    public int 丏丒丐丂丐丌丑且上(int 七丝东丛东丝且丆不)
    {
        int val_1 = 丈丌丁下世世不下世.丝业东丙丒一丅万万(丙业与丙丗丝不丈东:  七丝东丛东丝且丆不);
        if((七丝东丛东丝且丆不 & 2147483648) == 0)
        {
                if(val_1 > 0)
        {
            goto label_4;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "Неверно задано максимальное значение");
        label_4:
        this.不上丐丁上且丞且丗(丙业与丙丗丝不丈东:  this.东七丛丝丑专世丏三 + val_1);
        return (int)丈丌丁下世世不下世.一丆丌专丏丘丌丄三(丌丗丏丏丛东专丁且:  this.一丐丗丁丞丆丅丟丄, 丄且一丄丏丆丐丗与:  this.东七丛丝丑专世丏三, 丈丝世且万世丈丌万:  this.东七丛丝丑专世丏三 + val_1);
    }
    public int 与上万业专丘三丅万(int 丑丅世丐丒丏丐三丅)
    {
        int val_6 = this.三丟丈不丛专且丝丌;
        var val_2 = (val_6 < 0) ? (val_6 + 31) : (val_6);
        val_2 = val_2 >> 5;
        if(val_2 <= 丑丅世丐丒丏丐三丅)
        {
                UnityEngine.Debug.LogError(message:  "Слишком большой индекс");
            val_6 = this.三丟丈不丛专且丝丌;
        }
        
        val_6 = (val_6 < 0) ? (val_6 + 31) : (val_6);
        var val_4 = val_6 >> 5;
        int[] val_5 = new int[0];
        this.一丐丗丁丞丆丅丟丄.CopyTo(array:  val_5, index:  0);
        return (int)val_5[((long)(int)(丑丅世丐丒丏丐三丅)) << 2];
    }
    private static void 与丄丏丞业三与东丗(System.Collections.BitArray 丌丗丏丏丛东专丁且, int 丄且一丄丏丆丐丗与, int 丈丝世且万世丈丌万, uint 丙业与丙丗丝不丈东)
    {
        var val_4;
        var val_5;
        var val_6;
        val_5 = 丄且一丄丏丆丐丗与;
        int val_1 = 丈丝世且万世丈丌万 - val_5;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_4 = 0;
        val_4 = val_1;
        val_5 = val_5;
        do
        {
            val_6 = null;
            val_6 = null;
            丌丗丏丏丛东专丁且.Set(index:  val_5 + val_4, value:  ((丈丌丁下世世不下世.一万专万与丆丌与一.Length + 32) != 丙业与丙丗丝不丈东) ? 1 : 0);
            val_4 = val_4 + 1;
        }
        while(val_4 != val_4);
    
    }
    private static uint 一丆丌专丏丘丌丄三(System.Collections.BitArray 丌丗丏丏丛东专丁且, int 丄且一丄丏丆丐丗与, int 丈丝世且万世丈丌万)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 丄且一丄丏丆丐丗与;
        int val_1 = 丈丝世且万世丈丌万 - val_3;
        if(val_1 >= 1)
        {
                var val_3 = 0;
            val_4 = 0;
            val_3 = val_3;
            do
        {
            丄且一丄丏丆丐丗与 = val_3 + val_3;
            if((丌丗丏丏丛东专丁且.Get(index:  丄且一丄丏丆丐丗与)) != false)
        {
                val_5 = null;
            val_5 = null;
            val_4 = (丈丌丁下世世不下世.一万专万与丆丌与一.Length + 32) + val_4;
        }
        
            val_3 = val_3 + 1;
        }
        while(val_1 != val_3);
        
            return (uint)val_4;
        }
        
        val_4 = 0;
        return (uint)val_4;
    }
    private static int 丝业东丙丒一丅万万(int 丙业与丙丗丝不丈东)
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = 0;
        goto label_1;
        label_10:
        val_2 = null;
        val_2 = null;
        if((long)丙业与丙丗丝不丈东 < (丈丌丁下世世不下世.一万专万与丆丌与一.Length + 32))
        {
                return 0;
        }
        
        val_1 = 1;
        label_1:
        val_3 = null;
        val_3 = null;
        if(val_1 < 丈丌丁下世世不下世.一万专万与丆丌与一.Length)
        {
            goto label_10;
        }
        
        UnityEngine.Debug.LogError(message:  "Слишком много!");
        return 0;
    }
    public void 丁世三丁业三丙三专()
    {
        UnityEngine.Debug.LogError(message:  "index = "("index = ") + this.东七丛丝丑专世丏三.ToString());
    }
    private static 丈丌丁下世世不下世()
    {
        丈丌丁下世世不下世.一万专万与丆丌与一 = new uint[32] {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, -2147483648};
    }

}
