using UnityEngine;
public class SmartRotator : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 eulersPerSecond;
    private UnityEngine.Transform 上丛丂三上与丂丕丑;
    public int framesSkip;
    private bool 丌七丏丁丂丁三上丕;
    private int 与丆东三丞丞丈下丒;
    
    // Methods
    private void Start()
    {
        this.上丛丂三上与丂丕丑 = this.transform;
        if((this.GetComponent<UnityEngine.MeshRenderer>()) == 0)
        {
                UnityEngine.MeshRenderer val_5 = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
        }
        
        this.与丆东三丞丞丈下丒 = UnityEngine.Random.Range(min:  0, max:  10);
    }
    private void OnBecameVisible()
    {
        this.丌七丏丁丂丁三上丕 = true;
    }
    private void OnBecameInvisible()
    {
        this.丌七丏丁丂丁三上丕 = false;
    }
    private void Update()
    {
        if(this.丌七丏丁丂丁三上丕 == false)
        {
                return;
        }
        
        int val_6 = this.与丆东三丞丞丈下丒;
        val_6 = val_6 + UnityEngine.Time.frameCount;
        val_6 = val_6 - ((val_6 / this.framesSkip) * this.framesSkip);
        if(val_6 != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.eulersPerSecond, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.deltaTime * (float)this.framesSkip);
        this.上丛丂三上与丂丕丑.Rotate(eulers:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    public SmartRotator()
    {
        this.eulersPerSecond = 0;
        mem[1152921539346305760] = 0;
        this.framesSkip = 1;
    }

}
