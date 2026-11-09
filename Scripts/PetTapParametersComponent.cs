using UnityEngine;
public class PetTapParametersComponent : MonoBehaviour
{
    // Fields
    public UnityEngine.ParticleSystem[] particleSystems;
    
    // Methods
    internal void 与丂丒丞七丄丘丕三(bool 丛丅丘一丏丙且丌上)
    {
        UnityEngine.Object val_5;
        goto label_1;
        label_17:
        UnityEngine.ParticleSystem val_5 = this.particleSystems[0];
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        val_5 = val_5.gameObject;
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        val_5 = val_5.gameObject;
        if(val_5 == null)
        {
            goto label_11;
        }
        
        if(丛丅丘一丏丙且丌上 == false)
        {
            goto label_12;
        }
        
        label_15:
        val_5.SetActive(value:  true);
        val_5.Play();
        goto label_14;
        label_11:
        if(丛丅丘一丏丙且丌上 == true)
        {
            goto label_15;
        }
        
        label_12:
        val_5.SetActive(value:  false);
        label_14:
        0 = 1;
        label_1:
        if(0 < this.particleSystems.Length)
        {
            goto label_17;
        }
    
    }
    public PetTapParametersComponent()
    {
    
    }

}
