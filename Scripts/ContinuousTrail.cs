using UnityEngine;
public class ContinuousTrail : MonoBehaviour
{
    // Fields
    private UnityEngine.LineRenderer lineRenderer;
    private float maxDistance;
    private UnityEngine.Transform 丛丁下丒七丞丝下丏;
    private UnityEngine.Transform 丄丞不丏丟与丄丄丝;
    private bool 丈丆三丂丑丘丆丂下;
    private UnityEngine.Vector3 丒丘一丗丟丌上丘下;
    private UnityEngine.Vector3[] 丈丙与丐丗丗丈丞丆;
    
    // Methods
    private void Awake()
    {
        this.enabled = false;
        this.lineRenderer.SetPositions(positions:  new UnityEngine.Vector3[2]);
    }
    internal void 丅丘万不三丏丒与丄(UnityEngine.Transform 丈丗与丞一上且上上, UnityEngine.Transform 专丂丕丗丗东世丞下, float 丛业上丄丏丛丞丆丕)
    {
        this.丛丁下丒七丞丝下丏 = 丈丗与丞一上且上上;
        this.丄丞不丏丟与丄丄丝 = 专丂丕丗丗东世丞下;
        this.maxDistance = 丛业上丄丏丛丞丆丕;
        UnityEngine.Vector3 val_1 = 丈丗与丞一上且上上.position;
        this.丈丙与丐丗丗丈丞丆[0] = val_1;
        this.丈丙与丐丗丗丈丞丆[0] = val_1.y;
        this.丈丙与丐丗丗丈丞丆[0] = val_1.z;
        UnityEngine.Vector3 val_2 = this.丄丞不丏丟与丄丄丝.position;
        this.丈丙与丐丗丗丈丞丆[1] = val_2;
        this.丈丙与丐丗丗丈丞丆[1] = val_2.y;
        this.丈丙与丐丗丗丈丞丆[1] = val_2.z;
        this.丈丆三丂丑丘丆丂下 = false;
        this.enabled = true;
    }
    internal void 丅丘万不三丏丒与丄(UnityEngine.Transform 丈丗与丞一上且上上, UnityEngine.Transform 专丂丕丗丗东世丞下)
    {
        this.丛丁下丒七丞丝下丏 = 丈丗与丞一上且上上;
        this.丄丞不丏丟与丄丄丝 = 专丂丕丗丗东世丞下;
        UnityEngine.Vector3 val_1 = 丈丗与丞一上且上上.position;
        this.丈丙与丐丗丗丈丞丆[0] = val_1;
        this.丈丙与丐丗丗丈丞丆[0] = val_1.y;
        this.丈丙与丐丗丗丈丞丆[0] = val_1.z;
        UnityEngine.Vector3 val_2 = this.丄丞不丏丟与丄丄丝.position;
        this.丈丙与丐丗丗丈丞丆[1] = val_2;
        this.丈丙与丐丗丗丈丞丆[1] = val_2.y;
        this.丈丙与丐丗丗丈丞丆[1] = val_2.z;
        this.丈丆三丂丑丘丆丂下 = false;
        this.enabled = true;
    }
    private void LateUpdate()
    {
        UnityEngine.Vector3[] val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        UnityEngine.Vector3[] val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        val_14 = this;
        if(this.丛丁下丒七丞丝下丏 == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_2 = this.丄丞不丏丟与丄丄丝.position;
        UnityEngine.Vector3 val_3 = this.丛丁下丒七丞丝下丏.position;
        val_15 = val_3.y;
        val_16 = val_3.z;
        val_17 = val_2.x;
        val_18 = val_2.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17, y = val_2.y, z = val_18}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_15, z = val_16});
        val_19 = this.maxDistance * this.maxDistance;
        if(val_4.x >= 0)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_5 = this.丛丁下丒七丞丝下丏.position;
        this.丈丙与丐丗丗丈丞丆[0] = val_5;
        this.丈丙与丐丗丗丈丞丆[0] = val_5.y;
        this.丈丙与丐丗丗丈丞丆[0] = val_5.z;
        goto label_12;
        label_3:
        UnityEngine.Vector3[] val_6 = new UnityEngine.Vector3[2];
        val_20 = val_6;
        this.lineRenderer.SetPositions(positions:  val_6);
        this.丈丆三丂丑丘丆丂下 = false;
        this.enabled = false;
        return;
        label_8:
        if(this.丈丆三丂丑丘丆丂下 != true)
        {
                UnityEngine.Vector3 val_7 = this.丄丞不丏丟与丄丄丝.position;
            UnityEngine.Vector3 val_8 = this.丛丁下丒七丞丝下丏.position;
            val_16 = val_8.z;
            val_21 = val_7.x;
            val_22 = val_7.y;
            val_23 = val_7.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_16});
            this.丒丘一丗丟丌上丘下 = val_9;
            mem[1152921539943542480] = val_9.y;
            mem[1152921539943542484] = val_9.z;
            this.丈丆三丂丑丘丆丂下 = true;
        }
        
        UnityEngine.Vector3 val_10 = this.丄丞不丏丟与丄丄丝.position;
        val_15 = this.maxDistance;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丒丘一丗丟丌上丘下, y = val_16, z = val_8.x}, d:  val_15);
        val_24 = val_10.x;
        val_25 = val_10.y;
        val_26 = val_10.z;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        this.丈丙与丐丗丗丈丞丆[0] = val_12;
        this.丈丙与丐丗丗丈丞丆[0] = val_12.y;
        this.丈丙与丐丗丗丈丞丆[0] = val_12.z;
        label_12:
        val_20 = this.丈丙与丐丗丗丈丞丆;
        UnityEngine.Vector3 val_13 = this.丄丞不丏丟与丄丄丝.position;
        val_20[1] = val_13;
        val_20[1] = val_13.y;
        val_20[1] = val_13.z;
        val_14 = this.丈丙与丐丗丗丈丞丆;
        this.lineRenderer.SetPositions(positions:  val_14);
    }
    private void OnDisable()
    {
        this.lineRenderer.SetPositions(positions:  new UnityEngine.Vector3[2]);
    }
    public ContinuousTrail()
    {
        this.丈丙与丐丗丗丈丞丆 = new UnityEngine.Vector3[2];
    }

}
