using UnityEngine;
internal class 下丟且丅丒万丆丅丙
{
    // Fields
    private static System.Action<bool> 东专丅丑不丄下丛丅;
    internal static string 业丈万专七丏不丌且;
    private static string 丝丁七丑丒丑丐与丕;
    
    // Methods
    internal static void 丙专专丈且专丟丑下(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  下丟且丅丒万丆丅丙.东专丅丑不丄下丛丅, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 世不丂且丑丐丆世丙(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  下丟且丅丒万丆丅丙.东专丅丑不丄下丛丅, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丝丕下丝下不万丌七()
    {
        var val_9;
        IntPtr val_11;
        if(UnityEngine.Application.platform != 8)
        {
                return;
        }
        
        val_9 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_9.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        val_9 = UnityEngine.Social.localUser;
        var val_10 = 0;
        val_10 = val_10 + 1;
        if(val_9.authenticated != false)
        {
                return;
        }
        
        System.Action<System.Boolean> val_8 = null;
        val_11 = static System.Void 下丟且丅丒万丆丅丙::七丛丞丛业丝丛丂专(bool 丐万丗丒下七丟丁三);
        val_8 = new System.Action<System.Boolean>(object:  0, method:  val_11);
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = 0;
        UnityEngine.Social.localUser.Authenticate(callback:  val_8);
    }
    internal static void 七丑三与丄专丙丒世(long 万且丒下丕丝专丟上, string 丐丈丙上丝东丄丌与)
    {
        string val_2;
        var val_3;
        var val_4;
        System.Action<System.Boolean> val_6;
        val_2 = 丐丈丙上丝东丄丌与;
        if(val_2 == null)
        {
                val_3 = null;
            val_3 = null;
            val_2 = 下丟且丅丒万丆丅丙.丝丁七丑丒丑丐与丕;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = 下丟且丅丒万丆丅丙.<>c.<>9__4_0;
        if(val_6 == null)
        {
                System.Action<System.Boolean> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Action<System.Boolean>(object:  下丟且丅丒万丆丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 下丟且丅丒万丆丅丙.<>c::丂万东东丂丐万专一(bool 丐万丗丒下七丟丁三));
            下丟且丅丒万丆丅丙.<>c.<>9__4_0 = val_6;
        }
        
        UnityEngine.Social.ReportScore(score:  万且丒下丕丝专丟上, board:  val_2, callback:  val_1);
    }
    private static void 七丛丞丛业丝丛丂专(bool 丐万丗丒下七丟丁三)
    {
        null = null;
        if(下丟且丅丒万丆丅丙.东专丅丑不丄下丛丅 == null)
        {
                return;
        }
        
        下丟且丅丒万丆丅丙.东专丅丑不丄下丛丅.Invoke(obj:  丐万丗丒下七丟丁三);
    }
    public 下丟且丅丒万丆丅丙()
    {
    
    }
    private static 下丟且丅丒万丆丅丙()
    {
        var val_2;
        var val_3;
        val_2 = null;
        下丟且丅丒万丆丅丙.业丈万专七丏不丌且 = "arena_heroes";
        val_3 = null;
        val_3 = null;
        val_2 = null;
        下丟且丅丒万丆丅丙.丝丁七丑丒丑丐与丕 = (丟丌丁且且世丈丈丟.丁丅不丝业丈丛丁七 == true) ? "zombieslayers" : "zombieslayerslite";
    }

}
