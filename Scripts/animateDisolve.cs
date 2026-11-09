using UnityEngine;
public class animateDisolve : MonoBehaviour
{
    // Fields
    public float dissolve;
    public bool useSharedMaterial;
    private UnityEngine.Material 下丘丈丌丁与丅七东;
    
    // Properties
    private UnityEngine.Material 世丑丘丘丂专丅丆与 { get; }
    
    // Methods
    private UnityEngine.Material 丌世七丟丌丁世与丞()
    {
        var val_7;
        if(this.下丘丈丌丁与丅七东 != 0)
        {
                return (UnityEngine.Material)this.下丘丈丌丁与丅七东;
        }
        
        T[] val_2 = this.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true);
        val_7 = 0;
        goto label_4;
        label_15:
        if(this.useSharedMaterial == true)
        {
            goto label_5;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_6;
        }
        
        UnityEngine.Material val_4 = val_2[0].material;
        goto label_9;
        label_6:
        label_5:
        UnityEngine.Material val_5 = val_2[0].sharedMaterial;
        label_9:
        if((val_5.HasProperty(name:  "_Disolve")) != false)
        {
                this.下丘丈丌丁与丅七东 = val_5;
        }
        
        val_7 = 1;
        label_4:
        if(val_7 < val_2.Length)
        {
            goto label_15;
        }
        
        return (UnityEngine.Material)this.下丘丈丌丁与丅七东;
    }
    private void OnEnable()
    {
        this.下丘丈丌丁与丅七东 = 0;
    }
    private void Update()
    {
        if(this.丌世七丟丌丁世与丞() == 0)
        {
                return;
        }
        
        this.丌世七丟丌丁世与丞().SetFloat(name:  "_Disolve", value:  this.dissolve);
    }
    public void ResetMaterial()
    {
        this.下丘丈丌丁与丅七东 = 0;
    }
    public animateDisolve()
    {
        this.useSharedMaterial = true;
    }

}
