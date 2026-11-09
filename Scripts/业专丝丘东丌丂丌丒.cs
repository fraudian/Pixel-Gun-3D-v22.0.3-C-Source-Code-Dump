using UnityEngine;
internal static class 业专丝丘东丌丂丌丒
{
    // Fields
    internal static string 一丏七与与丕丙且丑;
    internal static bool 丁丅三业与专丂东丛;
    internal static byte[] 三丄丙与丒丂一丂丁;
    
    // Methods
    internal static void 万东丗丌不世丌丁三()
    {
        System.Collections.Generic.IEnumerable<TSource> val_22;
        var val_23;
        System.Func<System.Char, System.Boolean> val_25;
        int val_26;
        var val_27;
        System.Action<System.Threading.Tasks.Task<System.String>> val_29;
        if(UnityEngine.Application.platform != 8)
        {
                return;
        }
        
        .丛丄业丕且丗下一万 = System.IO.Path.Combine(path1:  UnityEngine.Application.dataPath, path2:  "..");
        val_22 = Rilisoft.与丄丁丄丙丞下下丙.专一三丐丑业丆丌丏();
        val_23 = null;
        val_23 = null;
        val_25 = 业专丝丘东丌丂丌丒.<>c.<>9__0_0;
        if(val_25 == null)
        {
                System.Func<System.Char, System.Boolean> val_6 = null;
            val_25 = val_6;
            val_6 = new System.Func<System.Char, System.Boolean>(object:  业专丝丘东丌丂丌丒.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 业专丝丘东丌丂丌丒.<>c::丘丂上与丙丟丌丐专(char 丁丂专业丁丅丅丈丙));
            业专丝丘东丌丂丌丒.<>c.<>9__0_0 = val_25;
        }
        
        if(((System.Linq.Enumerable.Count<System.Char>(source:  val_22, predicate:  val_6)) | 2) == 3)
        {
                if(val_22 != null)
        {
                val_26 = val_22.LastIndexOf(value:  '.');
        }
        else
        {
                val_26 = 0.LastIndexOf(value:  '.');
        }
        
            val_22 = val_22.Substring(startIndex:  0, length:  val_26);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "gfts", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) | 64, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        string[] val_14 = new string[7];
        val_14[0] = System.Convert.ToBase64String(inArray:  System.Text.Encoding.UTF8);
        val_14[1] = "cGczZC5keWxpYg==";
        val_14[2] = "KnN1YnN0aXQq";
        val_14[3] = "KnVic3RyYXQq";
        val_14[4] = "KnlkaWEq";
        val_14[5] = "Q3JhY2tlcio=";
        val_14[6] = "SW5mby5wbGlzdA==";
        .专世丘丂丁丘丈丝丝 = val_14;
        val_27 = null;
        val_27 = null;
        val_29 = 业专丝丘东丌丂丌丒.<>c.<>9__0_2;
        if(val_29 == null)
        {
                System.Action<System.Threading.Tasks.Task<System.String>> val_19 = null;
            val_29 = val_19;
            val_19 = new System.Action<System.Threading.Tasks.Task<System.String>>(object:  业专丝丘东丌丂丌丒.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 业专丝丘东丌丂丌丒.<>c::丘丞丏丙且业丁世丗(System.Threading.Tasks.Task<string> 丙丒七丄上与丏丙丙));
            业专丝丘东丌丂丌丒.<>c.<>9__0_2 = val_29;
        }
        
        System.Threading.Tasks.Task val_21 = System.Threading.Tasks.Task.Run<System.String>(function:  new System.Func<System.String>(object:  new 业专丝丘东丌丂丌丒.丞上丕丈丒丘丆三丈(), method:  System.String 业专丝丘东丌丂丌丒.丞上丕丈丒丘丆三丈::东丌丞不一七丕万丐())).ContinueWith(continuationAction:  val_19, scheduler:  System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
    }
    internal static void 万丘丈东与世丅丒世()
    {
        if(业专丝丘东丌丂丌丒.丁丅三业与专丂东丛 == true)
        {
                return;
        }
        
        null = null;
        业专丝丘东丌丂丌丒.一丏七与与丕丙且丑 = "dGltZW91dA==";
    }
    private static 业专丝丘东丌丂丌丒()
    {
        业专丝丘东丌丂丌丒.一丏七与与丕丙且丑 = "ZGVmYXVsdA==";
        业专丝丘东丌丂丌丒.三丄丙与丒丂一丂丁 = new byte[64] {62, 59, 146, 50, 196, 43, 151, 12, 34, 157, 74, 34, 25, 226, 239, 167, 46, 226, 151, 253, 149, 85, 40, 56, 107, 254, 198, 111, 152, 34, 73, 206, 184, 145, 51, 23, 161, 197, 53, 9, 59, 16, 106, 151, 54, 115, 158, 48, 176, 147, 174, 119, 233, 88, 253, 94, 20, 2, 164, 67, 205, 142, 150, 2};
    }

}
