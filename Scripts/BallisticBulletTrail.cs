using UnityEngine;
public class BallisticBulletTrail : MonoBehaviour
{
    // Fields
    private UnityEngine.LineRenderer 丑丞丏丞丄丗专丂丄;
    private UnityEngine.Vector3 专与不丑丟丈与丌丝;
    private float showTime;
    private float 丛丟一世一丐丄丅丟;
    private float 丞丈丂丐万万业丕下;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    
    // Properties
    private UnityEngine.LineRenderer 丙丆丗七专丞万丁专 { get; }
    private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    
    // Methods
    private UnityEngine.LineRenderer 丐丕丞专万世丐丙与()
    {
        UnityEngine.LineRenderer val_3;
        if(this.丑丞丏丞丄丗专丂丄 == 0)
        {
                this.丑丞丏丞丄丗专丂丄 = this.GetComponent<UnityEngine.LineRenderer>();
            return val_3;
        }
        
        val_3 = this.丑丞丏丞丄丗专丂丄;
        return val_3;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        this.专与不丑丟丈与丌丝 = val_2;
        mem[1152921536295959124] = val_2.y;
        mem[1152921536295959128] = val_2.z;
        this.丛丟一世一丐丄丅丟 = 0f;
        this.丞丈丂丐万万业丕下 = 0f;
        this.丛上世专丛上一不三(丏上万丅丏一不不丕:  0f);
    }
    private void Update()
    {
        float val_16;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.专与不丑丟丈与丌丝, y = V11.16B, z = V10.16B});
        val_16 = val_3.x;
        if(val_16 > 0f)
        {
                float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_16 / val_4;
            this.丞丈丂丐万万业丕下 = val_4;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_18 = val_6.w;
            this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_18};
            val_19 = this.丛丟一世一丐丄丅丟;
            val_20 = val_16 + val_19;
            val_21 = this.丞丈丂丐万万业丕下 * this.showTime;
        }
        else
        {
                val_19 = this.丞丈丂丐万万业丕下;
            float val_7 = UnityEngine.Time.deltaTime;
            val_18 = this.showTime;
            val_16 = val_7;
            val_7 = val_19 * val_16;
            val_20 = this.丛丟一世一丐丄丅丟 - val_7;
            val_21 = this.丞丈丂丐万万业丕下 * val_18;
        }
        
        float val_8 = UnityEngine.Mathf.Clamp(value:  val_20, min:  0f, max:  val_21);
        this.丛丟一世一丐丄丅丟 = val_8;
        this.丛上世专丛上一不三(丏上万丅丏一不不丕:  val_8);
        UnityEngine.Vector3 val_10 = this.丌丟丄业且三丛丕丄().position;
        this.专与不丑丟丈与丌丝 = val_10;
        mem[1152921536296087508] = val_10.y;
        mem[1152921536296087512] = val_10.z;
    }
    private void 丛上世专丛上一不三(float 丏上万丅丏一不不丕)
    {
        this.丐丕丞专万世丐丙与().SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    private UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.专专丏下丐丂丂丅东 == 0)
        {
                this.专专丏下丐丂丂丅东 = this.transform;
            return val_3;
        }
        
        val_3 = this.专专丏下丐丂丂丅东;
        return val_3;
    }
    public BallisticBulletTrail()
    {
        this.showTime = 0.1f;
    }

}
