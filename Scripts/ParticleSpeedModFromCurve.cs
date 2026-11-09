using UnityEngine;
public class ParticleSpeedModFromCurve : MonoBehaviour
{
    // Fields
    public UnityEngine.ParticleSystem ps;
    public UnityEngine.AnimationCurve curve;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if(this.ps == 0)
        {
                return;
        }
        
        VelocityOverLifetimeModule val_2 = this.ps.velocityOverLifetime;
        this = this.curve;
        float val_4 = this.Evaluate(time:  this.ps.time);
    }
    public ParticleSpeedModFromCurve()
    {
        this.ps = new UnityEngine.ParticleSystem();
        this.curve = UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  0f);
    }

}
