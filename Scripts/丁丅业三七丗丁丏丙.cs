using UnityEngine;
internal static class 丁丅业三七丗丁丏丙
{
    // Fields
    internal const string 丌丕丈丁丝丑丞专世 = "TUTORIAL_BLINK";
    
    // Methods
    internal static bool 丈丛万世丂丘一丕丏()
    {
        var val_6;
        var val_14;
        Dictionary.Enumerator<TKey, TValue> val_3 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().业东丙丗世万丈丘东().GetEnumerator();
        label_13:
        if((178791376 & 1) == 0)
        {
            goto label_5;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if(val_7._value._obj.丙东专丂世丈丏丁丂() == 19001)
        {
            goto label_13;
        }
        
        三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_7._value._obj.丙东专丂世丈丏丁丂());
        if((val_10 == null) || ((WeaponManager.丁下一丆丙不世七三().Contains(item:  val_10.与不丞丑七丘丁丂丛())) == true))
        {
            goto label_13;
        }
        
        val_14 = 1;
        goto label_14;
        label_5:
        val_14 = 0;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_14;
    }
    public static System.Collections.IEnumerator 丌业不不丕世上专且(System.Collections.Generic.List<System.Threading.CancellationTokenSource> 丞丌丌丌丑三丛丒业, UIWidget 世丌丌丙丞丟下东丞, float 丌东丌专丗与与丞丄, float 丏丏不上世一丛丏丏, float 丄万丒三丛一且丟丑 = 0.004, float 一丟丞丆丟丑丕东不 = 0.5)
    {
        丁丅业三七丗丁丏丙.丝丛世业七丙丐丝丘 val_1 = new 丁丅业三七丗丁丏丙.丝丛世业七丙丐丝丘();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丞丌丌丌丑三丛丒业 = 丞丌丌丌丑三丛丒业;
            .世丌丌丙丞丟下东丞 = 世丌丌丙丞丟下东丞;
            .丌东丌专丗与与丞丄 = 丌东丌专丗与与丞丄;
            .丏丏不上世一丛丏丏 = 丏丏不上世一丛丏丏;
            .丄万丒三丛一且丟丑 = 丄万丒三丛一且丟丑;
        }
        else
        {
                mem[32] = 丞丌丌丌丑三丛丒业;
            mem[40] = 世丌丌丙丞丟下东丞;
            mem[56] = 丌东丌专丗与与丞丄;
            .丏丏不上世一丛丏丏 = 丏丏不上世一丛丏丏;
            mem[48] = 丄万丒三丛一且丟丑;
        }
        
        .一丟丞丆丟丑丕东不 = 一丟丞丆丟丑丕东不;
        return (System.Collections.IEnumerator)val_1;
    }

}
