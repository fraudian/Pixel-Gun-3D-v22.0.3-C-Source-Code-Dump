using UnityEngine;
public class MovingDummy : MonoBehaviour
{
    // Fields
    private DevDummyController 上丗业丗丑丌丛丅丝;
    private UnityEngine.Vector3 丛丁下丒七丞丝下丏;
    public UnityEngine.Vector3[] pathPoints;
    public float speed;
    public float smooth;
    private int 丏丘丆且丗丁东一世;
    private UnityEngine.Vector3 万丛丞丂丘且三丈丈;
    
    // Methods
    private void Awake()
    {
        this.上丗业丗丑丌丛丅丝 = this.GetComponent<DevDummyController>();
    }
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.丛丁下丒七丞丝下丏 = val_2;
        mem[1152921530948047524] = val_2.y;
        mem[1152921530948047528] = val_2.z;
    }
    public void ResetPath()
    {
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.丛丁下丒七丞丝下丏, y = V9.16B, z = V10.16B};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.万丛丞丂丘且三丈丈 = val_2;
        mem[1152921530948167752] = val_2.y;
        mem[1152921530948167756] = val_2.z;
        this.丏丘丆且丗丁东一世 = 0;
    }
    private void Update()
    {
        float val_19;
        UnityEngine.Vector3[] val_20;
        float val_21;
        float val_22;
        float val_23;
        if(this.pathPoints == null)
        {
                return;
        }
        
        if(this.pathPoints.Length == 0)
        {
                return;
        }
        
        if(this.上丗业丗丑丌丛丅丝.IsDead() == true)
        {
                return;
        }
        
        if(this.丏丘丆且丗丁东一世 >= this.pathPoints.Length)
        {
                this.丏丘丆且丗丁东一世 = 0;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        val_20 = this.pathPoints;
        val_21 = val_3.z;
        var val_19 = 12;
        val_19 = val_20 + (this.丏丘丆且丗丁东一世 * val_19);
        val_22 = mem[(this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32];
        val_22 = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32;
        val_23 = mem[(this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32 + 4];
        val_23 = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32 + 4;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丛丁下丒七丞丝下丏, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 40});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_21}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if(val_5.x > 1f)
        {
                val_20 = this.pathPoints;
            var val_20 = 12;
            val_20 = val_20 + (this.丏丘丆且丗丁东一世 * val_20);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丛丁下丒七丞丝下丏, y = val_3.y, z = val_21}, b:  new UnityEngine.Vector3() {x = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32, y = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32 + 4, z = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 40});
            UnityEngine.Vector3 val_8 = this.transform.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_23 = this.smooth;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = this.万丛丞丂丘且三丈丈, y = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 32 + 4, z = (this.丏丘丆且丗丁东一世 * 12) + this.pathPoints + 40}, target:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, maxDistanceDelta:  val_23 * UnityEngine.Time.deltaTime);
            this.万丛丞丂丘且三丈丈 = val_12;
            mem[1152921530948447688] = val_12.y;
            mem[1152921530948447692] = val_12.z;
            UnityEngine.Transform val_13 = this.transform;
            UnityEngine.Vector3 val_14 = val_13.localPosition;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.万丛丞丂丘且三丈丈, y = val_14.y, z = val_9.y}, d:  this.speed);
            val_19 = val_15.y;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_19, z = val_15.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_22 = val_18.x;
            val_21 = val_18.z;
            val_13.localPosition = new UnityEngine.Vector3() {x = val_22, y = val_18.y, z = val_21};
            return;
        }
        
        int val_21 = this.丏丘丆且丗丁东一世;
        val_21 = val_21 + 1;
        this.丏丘丆且丗丁东一世 = val_21;
    }
    public MovingDummy()
    {
        this.speed = Infinityf;
        this.smooth = 1f;
    }

}
