using UnityEngine;
internal sealed class InternetChecker : MonoBehaviour
{
    // Fields
    internal static bool 丐三丝丙丐三东专丌;
    
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    internal static void 丝东丘丟丏专三丆丗()
    {
        var val_4;
        bool val_5;
        string val_1 = InternetChecker.丑丗不一专丄丅七丙(丆丞东丘丒东丒七专:  "http://google.com");
        if((System.String.op_Equality(a:  val_1, b:  "")) == false)
        {
            goto label_3;
        }
        
        val_4 = null;
        goto label_6;
        label_3:
        if((val_1.Contains(value:  "schema.org/WebPage")) == false)
        {
            goto label_8;
        }
        
        val_5 = 1;
        goto label_11;
        label_8:
        val_4 = null;
        label_6:
        val_5 = false;
        label_11:
        InternetChecker.丐三丝丙丐三东专丌 = val_5;
    }
    internal static string 丑丗不一专丄丅七丙(string 丆丞东丘丒东丒七专)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        bool val_16;
        System.Net.WebRequest val_1 = System.Net.WebRequest.Create(requestUriString:  丆丞东丘丒东丒七专);
        val_10 = 0;
        if((0 > 298) || (0 < 200))
        {
            goto label_10;
        }
        
        UnityEngine.Debug.Log(message:  "Trying to check internet");
        new System.IO.StreamReader() = new System.IO.StreamReader(stream:  0);
        char[] val_6 = new char[80];
        if(val_6.Length < 1)
        {
            goto label_15;
        }
        
        do
        {
            long val_10 = 0;
            string val_7 = System.String.alignConst + val_6[0];
            val_10 = val_10 + 1;
        }
        while(val_10 < val_6.Length);
        
        goto label_18;
        label_10:
        label_57:
        var val_11 = 0;
        label_59:
        val_11 = val_11 + 1;
        mem2[0] = 177;
        if((1 & 1) != 0)
        {
            goto label_19;
        }
        
        var val_14 = 1179403647;
        if(mem[282584257676957] == 0)
        {
            goto label_23;
        }
        
        var val_12 = mem[282584257676847];
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_22:
        if(((mem[282584257676847] + 8) + -8) == null)
        {
            goto label_21;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < mem[282584257676957])
        {
            goto label_22;
        }
        
        goto label_23;
        label_21:
        val_14 = val_14 + (((mem[282584257676847] + 8)) << 4);
        val_12 = val_14 + 296;
        label_23:
        0.Dispose();
        label_19:
        if(val_11 != 1)
        {
                if(0 == 0)
        {
                return (string)System.String.alignConst;
        }
        
            if((1152921526287394224 + ((0 + 1)) << 2) != 177)
        {
                return (string)System.String.alignConst;
        }
        
            return (string)System.String.alignConst;
        }
        
        if(0 == 0)
        {
                return (string)System.String.alignConst;
        }
        
        return (string)System.String.alignConst;
        label_15:
        val_11 = System.String.alignConst;
        label_18:
        val_13 = 0;
        val_14 = 0;
        if(new System.IO.StreamReader() != null)
        {
            goto label_30;
        }
        
        goto label_49;
        label_63:
        val_16 = X0;
        goto label_54;
        label_30:
        var val_15 = 0;
        val_15 = val_15 + 1;
        new System.IO.StreamReader().Dispose();
        label_49:
        if( != 1)
        {
                if(165 == 165)
        {
            goto label_57;
        }
        
        }
        
        if( == 0)
        {
            goto label_59;
        }
        
        goto label_59;
        label_54:
        if(val_6 != 2)
        {
            goto label_63;
        }
        
        if((null & 1) != 0)
        {
                return (string)System.String.alignConst;
        }
        
        mem[8] = val_16;
        goto label_63;
    }
    public InternetChecker()
    {
    
    }
    private static InternetChecker()
    {
    
    }

}
