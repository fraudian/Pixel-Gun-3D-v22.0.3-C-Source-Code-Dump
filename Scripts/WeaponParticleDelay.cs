using UnityEngine;
public class WeaponParticleDelay : MonoBehaviour
{
    // Fields
    private UnityEngine.Animation 丂一丒丅丂丅专丙万;
    public string animationName;
    public float delay;
    public UnityEngine.ParticleSystem partSystem;
    private bool 丝丑丙三丘丏专上丑;
    private UnityEngine.Coroutine 丁丈丏世三一不上丐;
    
    // Methods
    private void Awake()
    {
        this.丂一丒丅丂丅专丙万 = this.GetComponent<UnityEngine.Animation>();
    }
    private void Update()
    {
        if((this.丂一丒丅丂丅专丙万.IsPlaying(name:  this.animationName)) != false)
        {
                this.丝丑丙三丘丏专上丑 = true;
            if(this.partSystem != 0)
        {
                if(this.partSystem.gameObject != 0)
        {
                this.partSystem.gameObject.SetActive(value:  false);
        }
        
        }
        
            if(this.丁丈丏世三一不上丐 != null)
        {
                this.StopCoroutine(routine:  this.丁丈丏世三一不上丐);
        }
        
            this.丁丈丏世三一不上丐 = this.StartCoroutine(routine:  this.丝丌丝丈丂丌与丈丛(丕丕世且下一与丝与:  this.delay));
            return;
        }
        
        this.丝丑丙三丘丏专上丑 = false;
    }
    private void OnDestroy()
    {
        if(this.丁丈丏世三一不上丐 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丁丈丏世三一不上丐);
        this.丁丈丏世三一不上丐 = 0;
    }
    private System.Collections.IEnumerator 丝丌丝丈丂丌与丈丛(float 丕丕世且下一与丝与)
    {
        WeaponParticleDelay.一七丟七丅丗三七不 val_1 = new WeaponParticleDelay.一七丟七丅丗三七不();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    public WeaponParticleDelay()
    {
    
    }

}
