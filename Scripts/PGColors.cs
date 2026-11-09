using UnityEngine;
[Serializable]
public class PGColors : ScriptableObject
{
    // Fields
    private static PGColors _instance;
    public System.Collections.Generic.List<ColorPreset> colorsList;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Color> colorsDictionary;
    
    // Properties
    public static PGColors instance { get; }
    
    // Methods
    public static PGColors get_instance()
    {
        if(PGColors._instance != 0)
        {
                return (PGColors)PGColors._instance;
        }
        
        PGColors._instance = UnityEngine.Resources.Load<PGColors>(path:  "PGColors");
        PGColors.且丝丂不且丏七三丝();
        return (PGColors)PGColors._instance;
    }
    private static void 且丝丂不且丏七三丝()
    {
        System.Collections.Generic.List<ColorPreset> val_3;
        int val_4;
        val_3 = mem[PGColors._instance + 24];
        val_3 = PGColors._instance.colorsList;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_8:
        if(((-785157976) & 1) == 0)
        {
            goto label_3;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
                val_4 = val_2.m_stringLength;
        }
        else
        {
                val_4 = 11993091;
        }
        
        Add(key:  val_4, value:  new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B});
        goto label_8;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public static UnityEngine.Color 丐下下丅与上东丙丑(string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.magenta;
        PGColors val_2 = PGColors.instance;
        bool val_3 = val_2.colorsDictionary.TryGetValue(key:  丒丘丏上丙丟丑丕丈, value: out  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        return new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    public static bool 丟不下下且业丛丄丏(string 丒丘丏上丙丟丑丕丈)
    {
        PGColors val_1 = PGColors.instance;
        if(val_1.colorsDictionary != null)
        {
                return val_1.colorsDictionary.ContainsKey(key:  丒丘丏上丙丟丑丕丈);
        }
        
        return val_1.colorsDictionary.ContainsKey(key:  丒丘丏上丙丟丑丕丈);
    }
    public PGColors()
    {
        this.colorsDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color>();
    }

}
