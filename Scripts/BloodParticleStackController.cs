using UnityEngine;
public class BloodParticleStackController : MonoBehaviour
{
    // Fields
    internal static BloodParticleStackController 丄丞丁丈与业上丞丟;
    public WallBloodParticle[] particles;
    private int 丞丞不丏且与丝丆万;
    
    // Methods
    private void Start()
    {
        var val_9;
        var val_10;
        WallBloodParticle val_11;
        WallBloodParticle[] val_12;
        val_9 = null;
        val_9 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        BloodParticleStackController.丄丞丁丈与业上丞丟 = this;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        if(val_2 != null)
        {
                val_2.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        else
        {
                0.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        
        val_10 = val_2.childCount;
        val_11 = val_10;
        val_12 = new WallBloodParticle[0];
        this.particles = val_12;
        if(val_10 < 1)
        {
                return;
        }
        
        val_10 = 0;
        goto label_11;
        label_20:
        val_12 = this.particles;
        val_10 = 1;
        label_11:
        val_11 = val_2.GetChild(index:  1).GetComponent<WallBloodParticle>();
        if(val_12 == null)
        {
            goto label_14;
        }
        
        if(val_11 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_11 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_12[val_10] = val_11;
        if((val_11 - 1) != val_10)
        {
            goto label_20;
        }
    
    }
    public WallBloodParticle GetCurrentParticle(bool 丁丈丄不且专丘与世)
    {
        var val_2;
        int val_3;
        WallBloodParticle val_4;
        val_2 = 1;
        label_8:
        int val_1 = this.丞丞不丏且与丝丆万 + 1;
        this.丞丞不丏且与丝丆万 = val_1;
        if(val_1 >= this.particles.Length)
        {
            goto label_1;
        }
        
        val_3 = this.丞丞不丏且与丝丆万;
        goto label_2;
        label_1:
        if((val_2 & 1) == 0)
        {
            goto label_3;
        }
        
        val_3 = 0;
        val_2 = 0;
        this.丞丞不丏且与丝丆万 = 0;
        label_2:
        WallBloodParticle val_2 = this.particles[0];
        if(this.particles[0x0][0].isUseMine != false)
        {
                if(丁丈丄不且专丘与世 == false)
        {
            goto label_8;
        }
        
        }
        
        val_4 = this.particles[this.丞丞不丏且与丝丆万];
        return (WallBloodParticle)val_4;
        label_3:
        val_4 = 0;
        return (WallBloodParticle)val_4;
    }
    private void OnDestroy()
    {
        BloodParticleStackController.丄丞丁丈与业上丞丟 = 0;
    }
    public BloodParticleStackController()
    {
    
    }

}
