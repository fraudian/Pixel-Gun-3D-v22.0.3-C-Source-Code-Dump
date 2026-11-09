using UnityEngine;
public class 丁丞下且丈丝下下丒
{
    // Fields
    private const string 丄七一丈上业七专丟 = "_NoiseColor";
    private const string 专丑丐丆不丘丒一丆 = "_ColorRili";
    private const string 丏三上丑丕丈丏丏丐 = "SrcMode";
    private const string 丛业丞三丒三丛丞丆 = "DstMode";
    
    // Methods
    internal static void 专一丑业丝丐丄丟万(UnityEngine.Material[] 丑丆丙丐不七丙七下, float 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_8:
        UnityEngine.Material val_3 = 丑丆丙丐不七丙七下[0];
        if((val_3.HasProperty(name:  "_NoiseColor")) != false)
        {
                UnityEngine.Color val_2 = val_3.GetColor(name:  "_NoiseColor");
            val_3.SetColor(name:  "_NoiseColor", value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = 丙业与丙丗丝不丈东});
        }
        
        0 = 1;
        label_1:
        if(0 < 丑丆丙丐不七丙七下.Length)
        {
            goto label_8;
        }
    
    }
    internal static void 与上丞丈丗丏一与万(UnityEngine.Material[] 丑丆丙丐不七丙七下, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        string val_2;
        var val_3;
        if(丑丆丙丐不七丙七下 == null)
        {
                return;
        }
        
        if(丑丆丙丐不七丙七下.Length < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Material val_3 = 丑丆丙丐不七丙七下[0];
            if((UnityEngine.Mathf.Approximately(a:  丑丞丈丗丄丙丟万丄.a, b:  1f)) != false)
        {
                val_3.SetInt(name:  "SrcMode", value:  1);
            val_2 = "DstMode";
            val_3 = 0;
        }
        else
        {
                val_3.SetInt(name:  "SrcMode", value:  5);
            val_2 = "DstMode";
            val_3 = 10;
        }
        
            val_3.SetInt(name:  val_2, value:  10);
            val_3.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
        }
        while((0 + 1) < 丑丆丙丐不七丙七下.Length);
    
    }
    public 丁丞下且丈丝下下丒()
    {
    
    }

}
