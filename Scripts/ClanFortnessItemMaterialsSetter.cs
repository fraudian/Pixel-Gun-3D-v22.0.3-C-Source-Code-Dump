using UnityEngine;
public class ClanFortnessItemMaterialsSetter : MonoBehaviour
{
    // Fields
    private UnityEngine.Material[] 丙丒丛业不丛丛与丄;
    
    // Methods
    private void Start()
    {
        var val_12;
        var val_21;
        var val_22;
        var val_23;
        System.Func<System.String, UnityEngine.Material> val_25;
        T[] val_7 = this.transform.parent.GetComponentsInChildren<ClanFortnessItemMaterials>();
        if(val_7 == null)
        {
                return;
        }
        
        if(val_7.Length < 1)
        {
                return;
        }
        
        val_21 = 0;
        var val_22 = 0;
        label_39:
        T val_21 = val_7[0];
        if((val_7[0x0][0] + 32) == 0)
        {
            goto label_37;
        }
        
        System.Collections.Generic.KeyValuePair<UnityEngine.Renderer, UnityEngine.Material[]> val_8 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<UnityEngine.Renderer, UnityEngine.Material[]>>(source:  val_7[0x0] + 32 + 32);
        mem[1152921525725402520] = val_8.Value;
        val_22 = mem[val_7[0x0] + 32 + 32];
        val_22 = val_7[0x0] + 32 + 32;
        Dictionary.Enumerator<TKey, TValue> val_9 = val_22.GetEnumerator();
        label_25:
        if(((-356293120) & 1) == 0)
        {
            goto label_16;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_12.GetAwaiter();
        val_23 = null;
        val_23 = null;
        val_25 = ClanFortnessItemMaterialsSetter.<>c.<>9__1_0;
        if(val_25 == null)
        {
                val_25 = null;
            val_25 = new System.Func<System.String, UnityEngine.Material>(object:  ClanFortnessItemMaterialsSetter.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Material ClanFortnessItemMaterialsSetter.<>c::且丞丞一丞丙丛丑丅(string 东丝丄丝丙专丘三丏));
            ClanFortnessItemMaterialsSetter.<>c.<>9__1_0 = val_25;
        }
        
        val_13._value._obj.丐丏七丌丕丗业且上().sharedMaterials = System.Linq.Enumerable.ToArray<UnityEngine.Material>(source:  System.Linq.Enumerable.Select<System.String, UnityEngine.Material>(source:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject)).丙丕丞且丕不丘丙丑().丁丌丘丟丘丌下世丁(), selector:  null));
        goto label_25;
        label_16:
        val_22 = val_22 + 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_22 != 1)
        {
                var val_23 = 0;
            val_23 = val_23 ^ (val_22 >> 31);
            val_22 = val_22 + val_23;
        }
        
        label_37:
        if((0 + 1) < val_7.Length)
        {
            goto label_39;
        }
    
    }
    public ClanFortnessItemMaterialsSetter()
    {
    
    }

}
