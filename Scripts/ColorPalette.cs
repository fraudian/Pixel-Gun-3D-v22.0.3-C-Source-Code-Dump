using UnityEngine;
[Serializable]
public class EventGuiSettings.ColorPalette
{
    // Fields
    public System.Collections.Generic.List<EventGuiSettings.ColorElement> colors;
    
    // Methods
    public System.Collections.Generic.Dictionary<string, UnityEngine.Color> 丘且且丙丐丙丏丝与()
    {
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Color> val_2 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color>(capacity:  this.colors.Count);
        List.Enumerator<T> val_3 = this.colors.GetEnumerator();
        label_11:
        if(((-1552095992) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        if((val_2.ContainsKey(key:  val_4.m_stringLength)) == false)
        {
            goto label_6;
        }
        
        UnityEngine.Debug.LogError(message:  "Color name duplicates! name: "("Color name duplicates! name: ") + val_4.m_stringLength);
        goto label_11;
        label_6:
        val_2.Add(key:  val_4.m_stringLength, value:  new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B});
        goto label_11;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
    }
    public EventGuiSettings.ColorPalette()
    {
        this.colors = new System.Collections.Generic.List<ColorElement>();
    }

}
