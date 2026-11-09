using UnityEngine;
public class HeadShotStackController : MonoBehaviour
{
    // Fields
    internal static HeadShotStackController 丄丞丁丈与业上丞丟;
    private UnityEngine.Material mobHeadShotMaterial;
    private UnityEngine.Material mobHeadShotCriticalMaterial;
    private UnityEngine.Material headShotMaterial;
    private UnityEngine.Material headShotCritMaterial;
    private HitParticle[] 与一丐业丝上丕丘东;
    private int 丞丞不丏且与丝丆万;
    
    // Methods
    private void Start()
    {
        var val_9;
        var val_10;
        HitParticle val_11;
        HitParticle[] val_12;
        val_9 = null;
        val_9 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        HeadShotStackController.丄丞丁丈与业上丞丟 = this;
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
        val_12 = new HitParticle[0];
        this.与一丐业丝上丕丘东 = val_12;
        if(val_10 < 1)
        {
                return;
        }
        
        val_10 = 0;
        goto label_11;
        label_20:
        val_12 = this.与一丐业丝上丕丘东;
        val_10 = 1;
        label_11:
        val_11 = val_2.GetChild(index:  1).GetComponent<HitParticle>();
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
    public HitParticle GetCurrentParticle(bool 丁丈丄不且专丘与世, bool 且丄丄丞丒七上丕丙, bool 丅丘丛丒丒丑丟三丛)
    {
        var val_5;
        int val_6;
        UnityEngine.Material val_7;
        HitParticle val_8;
        val_5 = 1;
        label_9:
        int val_1 = this.丞丞不丏且与丝丆万 + 1;
        this.丞丞不丏且与丝丆万 = val_1;
        if(val_1 >= this.与一丐业丝上丕丘东.Length)
        {
            goto label_2;
        }
        
        val_6 = this.丞丞不丏且与丝丆万;
        goto label_3;
        label_2:
        if((val_5 & 1) == 0)
        {
            goto label_4;
        }
        
        val_6 = 0;
        val_5 = 0;
        this.丞丞不丏且与丝丆万 = 0;
        label_3:
        HitParticle val_5 = this.与一丐业丝上丕丘东[0];
        if(this.与一丐业丝上丕丘东[0x0][0].isUseMine != false)
        {
                if(丁丈丄不且专丘与世 == false)
        {
            goto label_9;
        }
        
        }
        
        if(且丄丄丞丒七上丕丙 == false)
        {
            goto label_10;
        }
        
        if(丅丘丛丒丒丑丟三丛 == false)
        {
            goto label_11;
        }
        
        val_7 = this.mobHeadShotCriticalMaterial;
        goto label_16;
        label_4:
        val_8 = 0;
        return val_8;
        label_10:
        if(丅丘丛丒丒丑丟三丛 == false)
        {
            goto label_14;
        }
        
        val_7 = this.headShotCritMaterial;
        goto label_16;
        label_11:
        val_7 = this.mobHeadShotMaterial;
        goto label_16;
        label_14:
        val_7 = this.headShotMaterial;
        label_16:
        HitParticle val_6 = this.与一丐业丝上丕丘东[this.丞丞不丏且与丝丆万];
        UnityEngine.Renderer val_2 = this.与一丐业丝上丕丘东[this.丞丞不丏且与丝丆万][0].myParticleSystem.GetComponent<UnityEngine.Renderer>();
        if(val_2.sharedMaterial != mem[this.headShotMaterial])
        {
                val_2.sharedMaterial = mem[this.headShotMaterial];
        }
        
        val_8 = this.与一丐业丝上丕丘东[this.丞丞不丏且与丝丆万];
        return val_8;
    }
    private void OnDestroy()
    {
        HeadShotStackController.丄丞丁丈与业上丞丟 = 0;
    }
    public HeadShotStackController()
    {
    
    }

}
