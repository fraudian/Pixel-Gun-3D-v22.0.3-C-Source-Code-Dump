using UnityEngine;
public class ParticleFromStack : MonoBehaviour
{
    // Fields
    public ParticleStackController fromStack;
    public float lifeTime;
    private float 丕丝丂丌世不丛且丘;
    
    // Methods
    private void OnEnable()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = this.lifeTime + val_1;
        this.丕丝丂丌世不丛且丘 = val_1;
    }
    private void Update()
    {
        if(this.fromStack == 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        if(this.丕丝丂丌世不丛且丘 >= 0)
        {
                return;
        }
        
        this.fromStack.ReturnParticle(丅丅丌丕世丙不丑丄:  this.gameObject);
    }
    public ParticleFromStack()
    {
    
    }

}
