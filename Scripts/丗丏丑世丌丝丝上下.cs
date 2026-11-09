using UnityEngine;
public class 丗丏丑世丌丝丝上下
{
    // Fields
    private static UnityEngine.AndroidJavaClass 丂上东丒下丞丈丈丝;
    
    // Properties
    private static UnityEngine.AndroidJavaClass 一上丕丝丒丆丙下世 { get; }
    
    // Methods
    public static string 丏业丅三丘丛三业丐()
    {
        return 丗丏丑世丌丝丝上下.丑丝上丅与与不上世();
    }
    public static void 丒下一丟丝丕丈不一(string 丕丗丘丑丛与丑业丒)
    {
        丗丏丑世丌丝丝上下.东丟东东上丒丑丛丗(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    private static UnityEngine.AndroidJavaClass 三丆丂世丂与与丟丌()
    {
        UnityEngine.AndroidJavaClass val_2;
        if(丗丏丑世丌丝丝上下.丂上东丒下丞丈丈丝 != null)
        {
                return (UnityEngine.AndroidJavaClass)丗丏丑世丌丝丝上下.丂上东丒下丞丈丈丝;
        }
        
        val_2 = new UnityEngine.AndroidJavaClass();
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.onevcat.UniPasteBoard.PasteBoard");
        丗丏丑世丌丝丝上下.丂上东丒下丞丈丈丝 = val_2;
        return (UnityEngine.AndroidJavaClass)丗丏丑世丌丝丝上下.丂上东丒下丞丈丈丝;
    }
    private static string 丑丝上丅与与不上世()
    {
        var val_5;
        if(丗丏丑世丌丝丝上下.三丆丂世丂与与丟丌() == null)
        {
                return (string)val_5.CallStatic<System.String>(methodName:  "getClipBoardString", args:  System.Array.Empty<System.Object>());
        }
        
        val_5 = 丗丏丑世丌丝丝上下.三丆丂世丂与与丟丌();
        return (string)val_5.CallStatic<System.String>(methodName:  "getClipBoardString", args:  System.Array.Empty<System.Object>());
    }
    private static void 东丟东东上丒丑丛丗(string 丕丗丘丑丛与丑业丒)
    {
        if(丗丏丑世丌丝丝上下.三丆丂世丂与与丟丌() == null)
        {
                return;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = 丕丗丘丑丛与丑业丒;
        丗丏丑世丌丝丝上下.三丆丂世丂与与丟丌().CallStatic(methodName:  "setClipBoardString", args:  val_3);
    }
    public 丗丏丑世丌丝丝上下()
    {
    
    }

}
