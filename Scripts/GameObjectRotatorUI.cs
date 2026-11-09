using UnityEngine;
public class GameObjectRotatorUI : MonoBehaviour
{
    // Fields
    public bool resetOnEnable;
    public bool selfRotate;
    public float selfRotateTimeOut;
    public float selfRotateSpeed;
    public bool resetByTime;
    public float resetTimeOut;
    public float resetSpeed;
    public UnityEngine.Transform objectToRotate;
    public UnityEngine.Vector3 defaultRotation;
    private float 上丁与丒一丆丈三不;
    
    // Methods
    private void OnEnable()
    {
        if(this.resetOnEnable == false)
        {
                return;
        }
        
        this.ResetRotation();
    }
    public void ResetRotation()
    {
        if(this.objectToRotate == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.defaultRotation, y = V8.16B, z = V9.16B});
        this.objectToRotate.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        this.上丁与丒一丆丈三不 = this.selfRotateTimeOut;
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        this.上丁与丒一丆丈三不 = 0f;
    }
    private void 丗丗业丆三丐丈丕万(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_4;
        UnityEngine.Transform val_5;
        val_4 = 丞且丅三三东不丄且.x;
        val_5 = this;
        if(this.objectToRotate == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_2 = this.objectToRotate.localRotation;
        val_5 = this.objectToRotate;
        val_2.y = val_2.y - val_4;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  val_2.x, y:  val_2.y, z:  val_2.z);
        val_4 = val_3.x;
        val_5.localRotation = new UnityEngine.Quaternion() {x = val_4, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    private void Update()
    {
        float val_9;
        if(this.objectToRotate == 0)
        {
                return;
        }
        
        val_9 = this.上丁与丒一丆丈三不;
        float val_2 = UnityEngine.Time.unscaledDeltaTime;
        val_2 = val_9 + val_2;
        this.上丁与丒一丆丈三不 = val_2;
        if(this.selfRotate != false)
        {
                if(val_2 <= this.selfRotateTimeOut)
        {
                return;
        }
        
            val_9 = this.selfRotateSpeed;
            float val_3 = UnityEngine.Time.unscaledDeltaTime;
            val_3 = val_9 * val_3;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3, y:  0f);
            this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            return;
        }
        
        if(this.resetByTime == false)
        {
                return;
        }
        
        if(val_2 <= this.resetTimeOut)
        {
                return;
        }
        
        UnityEngine.Quaternion val_5 = this.objectToRotate.localRotation;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.defaultRotation, y = V13.16B, z = V12.16B});
        float val_7 = UnityEngine.Time.unscaledDeltaTime;
        val_7 = val_7 * this.resetSpeed;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, b:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, t:  val_7);
        this.objectToRotate.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
    }
    public GameObjectRotatorUI()
    {
        this.selfRotate = true;
        this.selfRotateTimeOut = 2f;
        this.selfRotateSpeed = 30f;
        this.resetTimeOut = 2f;
        this.resetSpeed = 5f;
    }

}
