using UnityEngine;
public sealed class HighAssetsLoader : MonoBehaviour
{
    // Fields
    internal static readonly string 东且丑丕上不丐不丁;
    internal static readonly string 丅丑丒丌与丙世丘万;
    internal static readonly string 东丕丘业专专丝万上;
    
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public static void LoadHighLightmap()
    {
        var val_10;
        var val_12;
        System.Comparison<UnityEngine.Texture2D> val_14;
        val_10 = null;
        val_10 = null;
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<UnityEngine.Texture2D>(source:  new UnityEngine.Texture2D[0]);
        val_12 = null;
        val_12 = null;
        val_14 = HighAssetsLoader.<>c.<>9__4_0;
        if(val_14 == null)
        {
            goto label_8;
        }
        
        if(val_6 == null)
        {
            goto label_9;
        }
        
        label_13:
        val_6.Sort(comparison:  val_14);
        goto label_10;
        label_8:
        System.Comparison<UnityEngine.Texture2D> val_7 = null;
        val_14 = val_7;
        val_7 = new System.Comparison<UnityEngine.Texture2D>(object:  HighAssetsLoader.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 HighAssetsLoader.<>c::丂丗丘下下丑丅丄一(UnityEngine.Texture2D 丁丅丞与三丗与丅三, UnityEngine.Texture2D 一丑业不丂七丁上丞));
        HighAssetsLoader.<>c.<>9__4_0 = val_14;
        if(val_6 != null)
        {
            goto label_13;
        }
        
        label_9:
        val_6.Sort(comparison:  val_7);
        label_10:
        if(val_6.Count < 1)
        {
                return;
        }
        
        HighAssetsLoader.SetCurrentLightmap(三丑与且丁万丙丞丆:  val_6.Item[0]);
    }
    public static void SetCurrentLightmap(UnityEngine.Texture2D 三丑与且丁万丙丞丆)
    {
        UnityEngine.LightmapData[] val_1 = new UnityEngine.LightmapData[1];
        UnityEngine.LightmapData val_2 = new UnityEngine.LightmapData();
        val_2.lightmapColor = 三丑与且丁万丙丞丆;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(val_2 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = val_2;
        UnityEngine.LightmapSettings.lightmaps = val_1;
    }
    public HighAssetsLoader()
    {
    
    }
    private static HighAssetsLoader()
    {
        HighAssetsLoader.东且丑丕上不丐不丁 = "Lightmap";
        HighAssetsLoader.丅丑丒丌与丙世丘万 = "High";
        HighAssetsLoader.东丕丘业专专丝万上 = "Atlas";
    }

}
