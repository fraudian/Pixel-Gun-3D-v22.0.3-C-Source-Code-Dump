using UnityEngine;
public class DragonDamageEffect : MonoBehaviour
{
    // Fields
    public float lifeTime;
    private float 丕丝丂丌世不丛且丘;
    
    // Methods
    private void Awake()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + this.lifeTime;
        this.丕丝丂丌世不丛且丘 = val_1;
    }
    private void Update()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = val_1.position;
        UnityEngine.Vector3 val_4 = this.transform.forward;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  23f);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_1.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        float val_9 = UnityEngine.Time.time;
        if(this.丕丝丂丌世不丛且丘 >= 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public DragonDamageEffect()
    {
        this.lifeTime = 2f;
    }

}
