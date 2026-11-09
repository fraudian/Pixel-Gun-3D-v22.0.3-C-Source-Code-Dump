using UnityEngine;
public class UnscaledTimeParticle : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem 丅丅丌丕世丙不丑丄;
    
    // Properties
    private UnityEngine.ParticleSystem 世丙世丄丗下丒丆丂 { get; }
    
    // Methods
    private void Update()
    {
        if(UnityEngine.Time.timeScale >= 0)
        {
                return;
        }
        
        if(this.丝丅且一且丁丑一丅() == 0)
        {
                return;
        }
        
        this.丝丅且一且丁丑一丅().Simulate(t:  UnityEngine.Time.unscaledDeltaTime, withChildren:  true, restart:  false);
    }
    private UnityEngine.ParticleSystem 丝丅且一且丁丑一丅()
    {
        UnityEngine.ParticleSystem val_3;
        if(this.丅丅丌丕世丙不丑丄 == 0)
        {
                this.丅丅丌丕世丙不丑丄 = this.GetComponent<UnityEngine.ParticleSystem>();
            return val_3;
        }
        
        val_3 = this.丅丅丌丕世丙不丑丄;
        return val_3;
    }
    public UnscaledTimeParticle()
    {
    
    }

}
