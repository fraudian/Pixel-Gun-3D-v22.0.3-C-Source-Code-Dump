using UnityEngine;
internal sealed class 专丙东上不丟丘东丝
{
    // Fields
    private static bool 丝与丆丞东丘丈东丘;
    private static int 不业丁丁丁丒专一丝;
    private static 专丙东上不丟丘东丝.丌专世丟丂东下东丕[] 且一丏丈丁丄丟丌下;
    
    // Methods
    internal static void 上丛丌丆丑上七世三()
    {
        丌专世丟丂东下东丕[] val_3;
        var val_4;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        if(专丙东上不丟丘东丝.丝与丆丞东丘丈东丘 == true)
        {
                return;
        }
        
        专丙东上不丟丘东丝.丝与丆丞东丘丈东丘 = true;
        专丙东上不丟丘东丝.不业丁丁丁丒专一丝 = 0;
        丌专世丟丂东下东丕[] val_1 = new 丌专世丟丂东下东丕[128];
        val_6 = null;
        val_7 = 0;
        专丙东上不丟丘东丝.且一丏丈丁丄丟丌下 = val_1;
        goto label_6;
        label_21:
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        专丙东上不丟丘东丝.丌专世丟丂东下东丕 val_2 = new 专丙东上不丟丘东丝.丌专世丟丂东下东丕();
        .丙业与丙丗丝不丈东 = 丛丗丑丕与七丈一万.丄丅丂丄丅丞丆丈七;
        if(专丙东上不丟丘东丝.且一丏丈丁丄丟丌下 == null)
        {
            goto label_12;
        }
        
        if(val_2 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_2 == null)
        {
            goto label_16;
        }
        
        label_13:
        丌专世丟丂东下东丕 val_3 = val_1[4];
        label_16:
        mem2[0] = val_2;
        val_6 = null;
        val_7 = 1;
        label_6:
        val_6 = null;
        val_3 = 专丙东上不丟丘东丝.且一丏丈丁丄丟丌下;
        if(val_7 < mem[1152921538890181784])
        {
            goto label_21;
        }
    
    }
    private static int 专一丗一东丛丕丏丒()
    {
        null = null;
        int val_3 = 专丙东上不丟丘东丝.不业丁丁丁丒专一丝;
        int val_1 = val_3 + 1;
        val_3 = (val_1 < 0) ? (val_3 + 128) : (val_3 + 1);
        val_3 = val_3 & 4294967168;
        val_3 = val_1 - val_3;
        专丙东上不丟丘东丝.不业丁丁丁丒专一丝 = val_3;
        return (int)专丙东上不丟丘东丝.不业丁丁丁丒专一丝;
    }
    internal static 专丙东上不丟丘东丝.丌专世丟丂东下东丕 下丛丕与丁专丅且丈()
    {
        var val_3 = null;
        if(专丙东上不丟丘东丝.丝与丆丞东丘丈东丘 != true)
        {
                专丙东上不丟丘东丝.上丛丌丆丑上七世三();
            val_3 = null;
        }
        
        val_3 = null;
        int val_1 = 专丙东上不丟丘东丝.专一丗一东丛丕丏丒();
        丌专世丟丂东下东丕[] val_2 = 专丙东上不丟丘东丝.且一丏丈丁丄丟丌下 + (((long)(int)(val_1)) << 3);
        return (丌专世丟丂东下东丕)(专丙东上不丟丘东丝.且一丏丈丁丄丟丌下 + ((long)(int)(val_1)) << 3) + 32;
    }
    public 专丙东上不丟丘东丝()
    {
    
    }
    private static 专丙东上不丟丘东丝()
    {
    
    }

}
