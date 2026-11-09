using UnityEngine;
public class FlashFireForTurret : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform shootPoint;
    public UnityEngine.GameObject gunFlashObj;
    public float timeFireAction;
    private float 且丏东下丁丄丞万丆;
    
    // Methods
    private void Start()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_27;
        var val_30;
        var val_34;
        if(this.gunFlashObj != 0)
        {
            goto label_89;
        }
        
        System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
        val_22 = 0;
        val_23 = 0;
        val_24 = 0;
        label_65:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_63;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        object val_7 = val_3.Current;
        val_27 = 1;
        if((0.gameObject.name.Equals(value:  "BulletSpawnPoint")) == false)
        {
            goto label_65;
        }
        
        System.Collections.IEnumerator val_13 = 0.GetEnumerator();
        label_42:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_13.MoveNext() == false)
        {
            goto label_31;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        object val_17 = val_13.Current;
        val_27 = 0.gameObject.name;
        if((val_27.Equals(value:  "_GunFlash")) == false)
        {
            goto label_42;
        }
        
        val_24 = val_24 + 1;
        this.gunFlashObj = 0.gameObject;
        mem2[0] = 164;
        val_30 = 1;
        goto label_45;
        label_31:
        val_24 = val_24 + 1;
        val_30 = 0;
        mem2[0] = 164;
        label_45:
        if(val_13 != null)
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_13.Dispose();
        }
        
        if((val_24 == 1) || ((1152921526029632144 + ((val_24 + 1)) << 2) != 164))
        {
            goto label_61;
        }
        
        var val_31 = 0;
        val_31 = val_31 ^ (val_24 >> 31);
        val_24 = val_24 + val_31;
        if( == 0)
        {
            goto label_65;
        }
        
        goto label_63;
        label_61:
        val_22 = 0;
        val_23 = 0;
        if( == 0)
        {
            goto label_65;
        }
        
        label_63:
        val_24 = val_24 + 1;
        mem2[0] = 202;
        val_34 = 1152921504621703168;
        if(val_3 != null)
        {
                var val_32 = 0;
            val_32 = val_32 + 1;
            val_3.Dispose();
        }
        
        if(val_24 == 1)
        {
            goto label_85;
        }
        
        if(( == false) || ((1152921526029632144 + (((val_24 + 1) + 1)) << 2) == 202))
        {
            goto label_89;
        }
        
        label_88:
        label_89:
        this.丆一与丂专丟业丈丆(丛丅丘一丏丙且丌上:  false, 丏上万丅丏一不不丕:  0f, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        return;
        label_85:
        if( == true)
        {
            goto label_88;
        }
        
        goto label_89;
    }
    private void Update()
    {
        if(this.且丏东下丁丄丞万丆 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.且丏东下丁丄丞万丆 - val_1;
        this.且丏东下丁丄丞万丆 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.丆一与丂专丟业丈丆(丛丅丘一丏丙且丌上:  false, 丏上万丅丏一不不丕:  0f, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    public void StartGunFlash(float 丏上万丅丏一不不丕, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丆一与丂专丟业丈丆(丛丅丘一丏丙且丌上:  true, 丏上万丅丏一不不丕:  丏上万丅丏一不不丕, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        this.且丏东下丁丄丞万丆 = this.timeFireAction;
    }
    private void 丆一与丂专丟业丈丆(bool 丛丅丘一丏丙且丌上, float 丏上万丅丏一不不丕 = 0, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        bool val_15;
        UnityEngine.Object val_16;
        float val_15 = 丏上万丅丏一不不丕;
        val_15 = 丛丅丘一丏丙且丌上;
        if(this.gunFlashObj == 0)
        {
                return;
        }
        
        if(this.gunFlashObj.transform.childCount >= 1)
        {
                val_16 = this.gunFlashObj.transform.GetChild(index:  0);
        }
        else
        {
                val_16 = 0;
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        if(val_16.gameObject.activeSelf ^ val_15 == false)
        {
                return;
        }
        
        val_16.gameObject.SetActive(value:  val_15);
        if((val_15 > 0f) && (val_15 != false))
        {
                val_15 = val_15 + (-1f);
            float val_16 = 100f;
            val_15 = val_16.GetComponent<UnityEngine.ParticleSystemRenderer>();
            val_16 = val_15 * val_16;
            val_15 = (val_15 > 1f) ? (val_16) : 1f;
            val_15.velocityScale = val_15;
        }
        
        val_16.position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        UnityEngine.Vector3 val_13 = this.shootPoint.position;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_16.forward = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }
    public FlashFireForTurret()
    {
        this.timeFireAction = 0.2f;
    }

}
