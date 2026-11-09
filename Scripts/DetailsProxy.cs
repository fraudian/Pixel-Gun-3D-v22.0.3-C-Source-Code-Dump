using UnityEngine;
public sealed class DetailsProxy : PGBehaviour
{
    // Methods
    public static System.Collections.Generic.List<string> GetCraftGadgets(string 丕丗丘丑丛与丑业丒)
    {
        var val_9;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_9 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_9 = 0;
        val_9 = val_9 + 1;
        if(val_9 == null)
        {
                return val_1;
        }
        
        if(val_9 == null)
        {
                return val_1;
        }
        
        if((val_9.ContainsKey(key:  4)) == false)
        {
                return val_1;
        }
        
        List.Enumerator<T> val_6 = val_9.Item[4].GetEnumerator();
        val_9 = 1152921536731966976;
        label_17:
        if((2060372104 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_7 = 0.丐丏七丌丕丗业且上();
        val_1.Add(item:  val_7.m_stringLength.业上丙丞丐丄丆丅七());
        goto label_17;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public static System.Collections.Generic.List<string> GetGraffiti()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        if(val_1 != null)
        {
                val_1.Add(item:  "graffiti_1028");
        }
        else
        {
                val_1.Add(item:  "graffiti_1028");
        }
        
        val_1.Add(item:  "graffiti_2028");
        return val_1;
    }
    public DetailsProxy()
    {
    
    }

}
