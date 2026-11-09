using UnityEngine;
public class ParticleBonuse : MonoBehaviour
{
    // Fields
    public float maxTimer;
    public float timer;
    
    // Methods
    private void Update()
    {
        if(this.timer <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.timer - val_1;
        this.timer = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public void ShowParticle()
    {
        this.gameObject.SetActive(value:  true);
        this.timer = this.maxTimer;
    }
    public ParticleBonuse()
    {
        this.maxTimer = 2f;
        this.timer = -Infinityf;
    }

}
