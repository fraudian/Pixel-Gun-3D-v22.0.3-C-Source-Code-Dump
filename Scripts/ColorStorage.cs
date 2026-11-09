using UnityEngine;
[Serializable]
public class ColorStorage : ScriptableObject
{
    // Fields
    private static ColorStorage _instance;
    public System.Collections.Generic.List<ColorStorage.ColorEntryList> colorLists;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Color> colorDictionary;
    
    // Properties
    public static ColorStorage Instance { get; }
    
    // Methods
    public static ColorStorage get_Instance()
    {
        ColorStorage val_3 = ColorStorage._instance;
        if(val_3 != 0)
        {
                return (ColorStorage)ColorStorage._instance;
        }
        
        ColorStorage._instance = UnityEngine.Resources.Load<ColorStorage>(path:  "ColorStorage");
        val_3 = ColorStorage._instance;
        val_3.丏丄丛三专丈丂丂万();
        return (ColorStorage)ColorStorage._instance;
    }
    public void 丏丄丛三专丈丂丂万()
    {
        var val_4;
        var val_11;
        var val_12;
        var val_13;
        this.colorDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color>();
        List.Enumerator<T> val_2 = GetEnumerator();
        val_11 = 0;
        val_12 = 0;
        var val_11 = 0;
        label_27:
        if(((-320691680) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        List.Enumerator<T> val_6 = X22.GetEnumerator();
        label_14:
        if(((-320691712) & 1) == 0)
        {
            goto label_6;
        }
        
        string val_7 = val_4.丐丏七丌丕丗业且上();
        string val_8 = val_5.m_stringLength + "/"("/") + val_7.m_stringLength;
        if((this.colorDictionary.ContainsKey(key:  val_8)) == false)
        {
            goto label_9;
        }
        
        UnityEngine.Debug.LogError(message:  "ColorStorage contains color with the same key: "("ColorStorage contains color with the same key: ") + val_8);
        goto label_14;
        label_9:
        this.colorDictionary.Add(key:  val_8, value:  new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B});
        goto label_14;
        label_6:
        val_11 = val_11 + 1;
        val_13 = val_12;
        mem2[0] = 164;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if((val_11 == 1) || ((-320691760 + ((0 + 1)) << 2) != 164))
        {
            goto label_24;
        }
        
        var val_12 = 0;
        val_12 = val_12 ^ (val_11 >> 31);
        val_11 = val_11 + val_12;
        goto label_27;
        label_24:
        if( == 0)
        {
            goto label_27;
        }
        
        goto label_27;
        label_3:
        val_11 = val_11 + 1;
        mem2[0] = 192;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_11 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((-320691760 + ((0 + 1)) << 2) == 192)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    public static UnityEngine.Color 丐下下丅与上东丙丑(string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.magenta;
        ColorStorage val_2 = ColorStorage.Instance;
        bool val_3 = val_2.colorDictionary.TryGetValue(key:  丒丘丏上丙丟丑丕丈, value: out  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        return new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    public static bool 丟不下下且业丛丄丏(string 丒丘丏上丙丟丑丕丈)
    {
        ColorStorage val_1 = ColorStorage.Instance;
        if(val_1.colorDictionary != null)
        {
                return val_1.colorDictionary.ContainsKey(key:  丒丘丏上丙丟丑丕丈);
        }
        
        return val_1.colorDictionary.ContainsKey(key:  丒丘丏上丙丟丑丕丈);
    }
    public ColorStorage()
    {
        this.colorDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color>();
    }

}
