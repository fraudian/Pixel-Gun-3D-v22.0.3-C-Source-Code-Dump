using UnityEngine;
public class TurretGunFlash : MonoBehaviour
{
    // Fields
    private float activeTime;
    private float 丞丅丁丅丕丅丒东丗;
    private UnityEngine.ParticleSystem 丅丅丌丕世丙不丑丄;
    
    // Methods
    private void Awake()
    {
        UnityEngine.ParticleSystem val_1 = this.GetComponent<UnityEngine.ParticleSystem>();
        this.丅丅丌丕世丙不丑丄 = val_1;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丅丅丌丕世丙不丑丄.Stop();
    }
    private void 下世下丞世专丂东丟()
    {
        if(this.丅丅丌丕世丙不丑丄 != 0)
        {
                this.丅丅丌丕世丙不丑丄.Play();
        }
        
        this.丞丅丁丅丕丅丒东丗 = this.activeTime;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丞丅丁丅丕丅丒东丗 - val_1;
        this.丞丅丁丅丕丅丒东丗 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
        this.丞丅丁丅丕丅丒东丗 = this.activeTime;
    }
    public TurretGunFlash()
    {
        this.activeTime = 0.2f;
    }

}
