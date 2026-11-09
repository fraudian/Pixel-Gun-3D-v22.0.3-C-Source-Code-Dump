using UnityEngine;
public class ClanFortnessItemMaterials : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Renderer> <且丁丄丌三不丕丒丐>k__BackingField;
    public System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]> viewMaterials;
    
    // Properties
    public System.Collections.Generic.List<UnityEngine.Renderer> 上世丗丏丗丒丝与下 { get; set; }
    
    // Methods
    public System.Collections.Generic.List<UnityEngine.Renderer> get_renderers()
    {
        return (System.Collections.Generic.List<UnityEngine.Renderer>)this.<且丁丄丌三不丕丒丐>k__BackingField;
    }
    private void 丙丑上世丁且丏丗丁(System.Collections.Generic.List<UnityEngine.Renderer> 丙业与丙丗丝不丈东)
    {
        this.<且丁丄丌三不丕丒丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
        var val_9;
        var val_10;
        System.Func<UnityEngine.Renderer, System.Boolean> val_12;
        val_9 = this;
        val_10 = null;
        val_10 = null;
        val_12 = ClanFortnessItemMaterials.<>c.<>9__5_0;
        if(val_12 == null)
        {
                System.Func<UnityEngine.Renderer, System.Boolean> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Func<UnityEngine.Renderer, System.Boolean>(object:  ClanFortnessItemMaterials.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanFortnessItemMaterials.<>c::丄且与专且一丕丞且(UnityEngine.Renderer 东七上世万下丗丄丛));
            ClanFortnessItemMaterials.<>c.<>9__5_0 = val_12;
        }
        
        this.<且丁丄丌三不丕丒丐>k__BackingField = System.Linq.Enumerable.ToList<UnityEngine.Renderer>(source:  System.Linq.Enumerable.Where<UnityEngine.Renderer>(source:  this.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true), predicate:  val_2));
        this.viewMaterials.Clear();
        List.Enumerator<T> val_5 = this.<且丁丄丌三不丕丒丐>k__BackingField.GetEnumerator();
        label_12:
        if(((-357197128) & 1) == 0)
        {
            goto label_9;
        }
        
        string val_6 = 0.丐丏七丌丕丗业且上();
        this.viewMaterials.Add(key:  val_6, value:  System.Linq.Enumerable.ToArray<UnityEngine.Material>(source:  val_6.sharedMaterials));
        goto label_12;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ClanFortnessItemMaterials()
    {
        this.viewMaterials = new System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]>();
    }

}
