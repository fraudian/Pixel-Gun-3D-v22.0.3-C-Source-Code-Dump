using UnityEngine;
public class WeaponSkinChanger : MonoBehaviour
{
    // Fields
    public UnityEngine.Renderer weaponMeshRenderer;
    private PGCompany.丟丝世万东万丆丟上 <丏丈且丑业丏丏丟丞>k__BackingField;
    private UnityEngine.Material[] 下下丝丒丗专下丄且;
    
    // Properties
    internal PGCompany.丟丝世万东万丆丟上 丞丐丒丏下且丈丆丏 { get; set; }
    
    // Methods
    internal PGCompany.丟丝世万东万丆丟上 万丁七丞丂丆丑丕丒()
    {
        return (PGCompany.丟丝世万东万丆丟上)this.<丏丈且丑业丏丏丟丞>k__BackingField;
    }
    private void 丁丗丞丑七不业一丁(PGCompany.丟丝世万东万丆丟上 丙业与丙丗丝不丈东)
    {
        this.<丏丈且丑业丏丏丟丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private WeaponSkinChanger()
    {
        this.<丏丈且丑业丏丏丟丞>k__BackingField = 0;
    }
    internal void 上丈一万东三东世东(PGCompany.丟丝世万东万丆丟上 三丕上下丗丘丌专丒, string 丄丕且丆与业下业下)
    {
        string val_19;
        PGCompany.丟丝世万东万丆丟上 val_20;
        UnityEngine.Material[] val_21;
        var val_22;
        UnityEngine.Object val_23;
        var val_24;
        val_19 = 丄丕且丆与业下业下;
        val_20 = 三丕上下丗丘丌专丒;
        if((this.<丏丈且丑业丏丏丟丞>k__BackingField) == val_20)
        {
                return;
        }
        
        if((val_20 != null) && (val_19 != null))
        {
                if((System.String.op_Inequality(a:  val_20.上专丗丏丛丁专丑丄().WeaponPrefabName, b:  val_19)) == true)
        {
                return;
        }
        
        }
        
        this.<丏丈且丑业丏丏丟丞>k__BackingField = val_20;
        if(val_20 == null)
        {
            goto label_6;
        }
        
        if(this.下下丝丒丗专下丄且 != null)
        {
            goto label_22;
        }
        
        UnityEngine.Material[] val_4 = this.weaponMeshRenderer.materials;
        val_21 = new UnityEngine.Material[0];
        val_22 = 0;
        this.下下丝丒丗专下丄且 = val_21;
        goto label_10;
        label_21:
        val_23 = 0;
        UnityEngine.Material val_19 = this.weaponMeshRenderer.materials[val_23];
        if(this.下下丝丒丗专下丄且 == null)
        {
            goto label_14;
        }
        
        if(val_19 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_19 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        this.下下丝丒丗专下丄且[val_23] = val_19;
        val_21 = this.下下丝丒丗专下丄且;
        val_22 = 1;
        label_10:
        if(val_22 < this.下下丝丒丗专下丄且.Length)
        {
            goto label_21;
        }
        
        val_20 = this.<丏丈且丑业丏丏丟丞>k__BackingField;
        label_22:
        System.Collections.Generic.List<UnityEngine.Material> val_8 = val_20.上专丗丏丛丁专丑丄().丗丈上丕丌丕且丆丏();
        System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<UnityEngine.Material>(source:  this.下下丝丒丗专下丄且);
        val_24 = 0;
        goto label_24;
        label_35:
        val_23 = val_8.Item[0];
        if(val_23 != 0)
        {
                val_23 = val_9.Count;
            UnityEngine.Material val_13 = val_8.Item[0];
            if(val_23 > val_24)
        {
                val_9.set_Item(index:  0, value:  val_13);
        }
        else
        {
                val_9.Add(item:  val_13);
        }
        
        }
        
        val_24 = 1;
        label_24:
        if(val_24 < val_8.Count)
        {
            goto label_35;
        }
        
        val_19 = this.weaponMeshRenderer;
        val_19.materials = val_9.ToArray();
        UnityEngine.Material[] val_16 = this.weaponMeshRenderer.materials;
        if(val_16.Length != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "No material in WeaponSkin id: "("No material in WeaponSkin id: ") + this.<丏丈且丑业丏丏丟丞>k__BackingField.业上丙丞丐丄丆丅七()(this.<丏丈且丑业丏丏丟丞>k__BackingField.业上丙丞丐丄丆丅七()));
        label_6:
        this.weaponMeshRenderer.materials = this.下下丝丒丗专下丄且;
    }

}
