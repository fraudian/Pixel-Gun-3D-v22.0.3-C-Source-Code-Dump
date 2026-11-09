using UnityEngine;
public class PetWheelRotator : MonoBehaviour
{
    // Fields
    public float coef;
    private UnityEngine.Vector3 下丏业丏三一且万丝;
    private UnityEngine.Transform 上丛丂三上与丂丕丑;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.上丛丂三上与丂丕丑 = val_1;
        UnityEngine.Vector3 val_2 = val_1.position;
        this.下丏业丏三一且万丝 = val_2;
        mem[1152921535488001152] = val_2.y;
        mem[1152921535488001156] = val_2.z;
    }
    private void Update()
    {
        UnityEngine.Vector3 val_7;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        val_7 = this.下丏业丏三一且万丝;
        UnityEngine.Vector3 val_1 = this.上丛丂三上与丂丕丑.position;
        val_9 = val_1.y;
        val_10 = val_7;
        val_11 = V10.16B;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10, y = V9.16B, z = val_11}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_9, z = val_1.z});
        val_12 = 3f;
        if(val_2.x < 0)
        {
                val_7 = this.下丏业丏三一且万丝;
            UnityEngine.Vector3 val_4 = this.上丛丂三上与丂丕丑.position;
            val_9 = val_4.y;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7, y = V10.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_9, z = val_4.z});
            val_5.x = this.coef * val_5.x;
            val_10 = 0f;
            val_12 = 0f;
            val_11 = 0f;
            this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_10, y = val_12, z = val_11});
        }
        
        UnityEngine.Vector3 val_6 = this.上丛丂三上与丂丕丑.position;
        this.下丏业丏三一且万丝 = val_6;
        mem[1152921535488133632] = val_6.y;
        mem[1152921535488133636] = val_6.z;
    }
    public PetWheelRotator()
    {
        this.coef = 30f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.下丏业丏三一且万丝 = val_1;
        mem[1152921535488262016] = val_1.y;
        mem[1152921535488262020] = val_1.z;
    }

}
