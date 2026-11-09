using UnityEngine;
internal sealed class RemoveExplosion : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.ParticleSystem val_1 = this.GetComponent<UnityEngine.ParticleSystem>();
        if(val_1 != 0)
        {
                float val_3 = val_1.duration;
        }
        
        UnityEngine.AudioSource val_4 = this.GetComponent<UnityEngine.AudioSource>();
        if(((UnityEngine.Object.op_Implicit(exists:  val_4)) != false) && (val_4.enabled != false))
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_4.Play();
        }
        
        }
        
        this.Invoke(methodName:  "Remove", time:  7f);
    }
    private void Remove()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public RemoveExplosion()
    {
    
    }

}
