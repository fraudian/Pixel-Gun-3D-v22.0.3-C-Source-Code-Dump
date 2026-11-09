using UnityEngine;
internal static class 业丞下丞丆下丑万上
{
    // Fields
    private static System.Collections.Generic.List<PGCompany.ItemCurrencyLayout> 丅业丗丅丄丒上丛丝;
    private static bool 丌且丐丅丐且下上丕;
    private static UnityEngine.Coroutine 丞与丂且丆世丕世专;
    
    // Properties
    internal static bool 丁丏丑丗丞丛万三丂 { get; }
    
    // Methods
    internal static bool 丈丗丂丟不七东丄丌()
    {
        null = null;
        return (bool)业丞下丞丆下丑万上.丌且丐丅丐且下上丕;
    }
    internal static bool 丂丆东丐七东不丏上(PGCompany.ItemCurrencyLayout 丏专丌万与上丆丈三)
    {
        var val_3;
        var val_4;
        var val_5;
        if(丏专丌万与上丆丈三 == 0)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_3 = null;
        if((业丞下丞丆下丑万上.丅业丗丅丄丒上丛丝.Contains(item:  丏专丌万与上丆丈三)) == false)
        {
            goto label_7;
        }
        
        label_3:
        val_4 = 0;
        return (bool)val_4;
        label_7:
        val_5 = null;
        val_5 = null;
        业丞下丞丆下丑万上.丅业丗丅丄丒上丛丝.Add(item:  丏专丌万与上丆丈三);
        val_4 = 1;
        return (bool)val_4;
    }
    internal static bool 业丝丑丗且丘丙且丗(PGCompany.ItemCurrencyLayout 丏专丌万与上丆丈三)
    {
        var val_4;
        var val_5;
        var val_6;
        if(丏专丌万与上丆丈三 != 0)
        {
                val_4 = null;
            val_4 = null;
            if((业丞下丞丆下丑万上.丅业丗丅丄丒上丛丝.Contains(item:  丏专丌万与上丆丈三)) != false)
        {
                val_5 = null;
            val_5 = null;
            bool val_3 = 业丞下丞丆下丑万上.丅业丗丅丄丒上丛丝.Remove(item:  丏专丌万与上丆丈三);
            val_6 = 1;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal static void 丒丂丝世丂世与丁下(bool 丙业与丙丗丝不丈东)
    {
        var val_4;
        var val_9;
        UnityEngine.Object val_10;
        var val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        业丞下丞丆下丑万上.丌且丐丅丐且下上丕 = 丙业与丙丗丝不丈东;
        List.Enumerator<T> val_2 = 业丞下丞丆下丑万上.丅业丗丅丄丒上丛丝.GetEnumerator();
        label_15:
        if(((-797549248) & 1) == 0)
        {
            goto label_4;
        }
        
        val_10 = val_4.丐丏七丌丕丗业且上();
        if(val_10 == 0)
        {
            goto label_7;
        }
        
        val_11 = null;
        val_11 = null;
        if(业丞下丞丆下丑万上.丌且丐丅丐且下上丕 == false)
        {
            goto label_10;
        }
        
        val_10.丝一丅丆三东丂丞七(丗丂丞丛丒丒丟万丗:  false);
        val_10.下丌业业丐丘丐丘三();
        goto label_15;
        label_10:
        val_10.不与丞下业丑丒丙万();
        goto label_15;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_23;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_23:
        val_12 = null;
        val_12 = null;
        val_10 = 业丞下丞丆下丑万上.丞与丂且丆世丕世专;
        if(val_10 != null)
        {
                val_10 = 业丞下丞丆下丑万上.丞与丂且丆世丕世专;
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  val_10);
            val_12 = null;
            业丞下丞丆下丑万上.丞与丂且丆世丕世专 = 0;
        }
        
        val_12 = null;
        if(业丞下丞丆下丑万上.丌且丐丅丐且下上丕 == true)
        {
                return;
        }
        
        val_10 = 业丞下丞丆下丑万上.丂上业业业丑七丕万();
        业丞下丞丆下丑万上.丞与丂且丆世丕世专 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_10);
    }
    private static System.Collections.IEnumerator 丂上业业业丑七丕万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new 业丞下丞丆下丑万上.与丙丕丑丏且东丈专();
    }
    private static 业丞下丞丆下丑万上()
    {
        业丞下丞丆下丑万上.丅业丗丅丄丒上丛丝 = new System.Collections.Generic.List<PGCompany.ItemCurrencyLayout>();
        业丞下丞丆下丑万上.丌且丐丅丐且下上丕 = true;
    }

}
