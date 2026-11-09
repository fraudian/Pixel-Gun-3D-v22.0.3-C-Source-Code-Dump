using UnityEngine;
[Serializable]
public class EventGuiSettings.ResoucePalette
{
    // Fields
    public System.Collections.Generic.List<EventGuiSettings.ResouceElement> resouces;
    
    // Methods
    public System.Collections.Generic.Dictionary<string, string> 丒丒专丘丝丂丙世丝()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>(capacity:  this.resouces.Count);
        List.Enumerator<T> val_3 = this.resouces.GetEnumerator();
        label_11:
        if(((-1551820616) & 1) == 0)
        {
            goto label_3;
        }
        
        if((val_2.ContainsKey(key:  val_4.m_stringLength)) == false)
        {
            goto label_6;
        }
        
        UnityEngine.Debug.LogError(message:  "Resouce name duplicates! name: "("Resouce name duplicates! name: ") + val_4.m_stringLength);
        goto label_11;
        label_6:
        val_2.Add(key:  val_4.m_stringLength, value:  0.丐丏七丌丕丗业且上());
        goto label_11;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
    }
    public EventGuiSettings.ResoucePalette()
    {
        this.resouces = new System.Collections.Generic.List<ResouceElement>();
    }

}
