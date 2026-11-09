using UnityEngine;
public class ParticleStackController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject prefab;
    public int capacity;
    private int 丌丒丝东丌下丕丁丅;
    private UnityEngine.GameObject[] 三丘丗东丟且万丂世;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject[] val_6;
        var val_7;
        UnityEngine.GameObject[] val_8;
        val_6 = new UnityEngine.GameObject[0];
        this.三丘丗东丟且万丂世 = val_6;
        val_7 = 0;
        goto label_1;
        label_15:
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.prefab);
        if(X21 == 0)
        {
            goto label_4;
        }
        
        if(val_2 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_2 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        var val_3 = X21 + 0;
        mem2[0] = val_2;
        this.三丘丗东丟且万丂世[0].transform.parent = this.transform;
        val_6 = this.三丘丗东丟且万丂世;
        val_7 = 1;
        label_1:
        val_8 = val_6;
        if(val_6 == null)
        {
                val_8 = this.三丘丗东丟且万丂世;
        }
        
        if(val_7 < this.三丘丗东丟且万丂世.Length)
        {
            goto label_15;
        }
        
        this.丌丒丝东丌下丕丁丅 = this.三丘丗东丟且万丂世.Length;
    }
    public void ReturnParticle(UnityEngine.GameObject 丅丅丌丕世丙不丑丄)
    {
        int val_6 = this.丌丒丝东丌下丕丁丅;
        if(val_6 >= this.三丘丗东丟且万丂世.Length)
        {
                return;
        }
        
        丅丅丌丕世丙不丑丄.transform.parent = this.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        丅丅丌丕世丙不丑丄.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        丅丅丌丕世丙不丑丄.SetActive(value:  false);
        val_6 = this.丌丒丝东丌下丕丁丅;
        this.丌丒丝东丌下丕丁丅 = val_6 + 1;
        this.三丘丗东丟且万丂世[val_6] = 丅丅丌丕世丙不丑丄;
    }
    public UnityEngine.GameObject GetParticle()
    {
        UnityEngine.GameObject val_2;
        int val_1 = this.丌丒丝东丌下丕丁丅 - 1;
        if()
        {
                this.丌丒丝东丌下丕丁丅 = val_1;
            val_2 = this.三丘丗东丟且万丂世[(long)val_1];
            val_2.SetActive(value:  true);
            return (UnityEngine.GameObject)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.GameObject)val_2;
    }
    public ParticleStackController()
    {
        this.capacity = 20;
    }

}
