using UnityEngine;
public class SpringPosition : MonoBehaviour
{
    // Fields
    public static SpringPosition current;
    public UnityEngine.Vector3 target;
    public float strength;
    public bool worldSpace;
    public bool ignoreTimeScale;
    public bool updateScrollView;
    public SpringPosition.上丄丂丛专下丟万下 onFinished;
    private UnityEngine.GameObject eventReceiver;
    public string callWhenFinished;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private float 丈丐丗且与丐丅业东;
    private UIScrollView 丁丏丁丟丄丗丕上丄;
    
    // Methods
    private void Start()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
        if(this.updateScrollView == false)
        {
                return;
        }
        
        this.丁丏丁丟丄丗丕上丄 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIScrollView>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
    }
    private void Update()
    {
        UIScrollView val_16;
        float val_17;
        UnityEngine.Transform val_18;
        UnityEngine.Transform val_19;
        UnityEngine.Vector3 val_20;
        float val_22;
        val_16 = this;
        if(this.ignoreTimeScale != false)
        {
                float val_1 = RealTime.deltaTime;
        }
        else
        {
                float val_2 = UnityEngine.Time.deltaTime;
        }
        
        val_17 = this.丈丐丗且与丐丅业东;
        if(this.worldSpace == false)
        {
            goto label_3;
        }
        
        if(val_17 != 0f)
        {
            goto label_4;
        }
        
        val_18 = val_16;
        UnityEngine.Vector3 val_3 = this.丐一丗丛丕世丘东丁.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.target, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_17 = val_4.x * 0.001f;
        this.丈丐丗且与丐丅业东 = val_17;
        goto label_8;
        label_3:
        if(val_17 != 0f)
        {
            goto label_9;
        }
        
        val_19 = val_16;
        UnityEngine.Vector3 val_5 = this.丐一丗丛丕世丘东丁.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.target, y = V10.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_6.x = val_6.x * (1E-05f);
        this.丈丐丗且与丐丅业东 = val_6.x;
        goto label_13;
        label_4:
        val_18 = this.丐一丗丛丕世丘东丁;
        label_8:
        UnityEngine.Vector3 val_7 = mem[this.丐一丗丛丕世丘东丁].position;
        UnityEngine.Vector3 val_8 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = this.target}, 丛上丟丌丄丗丁世与:  this.strength, 丑丗丘与丈不七东丛:  val_2);
        mem[this.丐一丗丛丕世丘东丁].position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_20 = this.target;
        UnityEngine.Vector3 val_9 = this.丐一丗丛丕世丘东丁.position;
        val_22 = val_9.y;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_22, z = val_9.z});
        if(this.丈丐丗且与丐丅业东 < val_10.x)
        {
            goto label_27;
        }
        
        val_20 = this.target;
        this.丐一丗丛丕世丘东丁.position = new UnityEngine.Vector3() {x = val_20, y = val_8.y, z = val_8.z};
        goto label_21;
        label_9:
        val_19 = this.丐一丗丛丕世丘东丁;
        label_13:
        UnityEngine.Vector3 val_11 = mem[this.丐一丗丛丕世丘东丁].localPosition;
        UnityEngine.Vector3 val_12 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = this.target}, 丛上丟丌丄丗丁世与:  this.strength, 丑丗丘与丈不七东丛:  val_2);
        mem[this.丐一丗丛丕世丘东丁].localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        val_20 = this.target;
        UnityEngine.Vector3 val_13 = this.丐一丗丛丕世丘东丁.localPosition;
        val_22 = val_13.y;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_22, z = val_13.z});
        if(this.丈丐丗且与丐丅业东 < val_14.x)
        {
            goto label_27;
        }
        
        val_20 = this.target;
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_12.y, z = val_12.z};
        label_21:
        this.丗丙丗不丙丝丑万专();
        this.enabled = false;
        label_27:
        if(this.丁丏丁丟丄丗丕上丄 == 0)
        {
                return;
        }
        
        val_16 = this.丁丏丁丟丄丗丕上丄;
    }
    private void 丗丙丗不丙丝丑万专()
    {
        SpringPosition.current = this;
        if(this.onFinished != null)
        {
                this.onFinished.Invoke();
        }
        
        if(this.eventReceiver != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.callWhenFinished)) != true)
        {
                this.eventReceiver.SendMessage(methodName:  this.callWhenFinished, value:  this, options:  1);
        }
        
        }
        
        SpringPosition.current = 0;
    }
    public static SpringPosition Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector3 下业丕七东丌丝下且, float 丛上丟丌丄丗丁世与)
    {
        SpringPosition val_5 = 丝三丁东丈丒世丅业.GetComponent<SpringPosition>();
        if(val_5 == 0)
        {
                val_5 = 丝三丁东丈丒世丅业.AddComponent<SpringPosition>();
        }
        
        if(val_5 != null)
        {
                val_3.target = 下业丕七东丌丝下且;
            mem2[0] = 下业丕七东丌丝下且.y;
            mem2[0] = 下业丕七东丌丝下且.z;
            val_3.strength = 丛上丟丌丄丗丁世与;
            val_3.onFinished = 0;
        }
        else
        {
                mem[24] = 下业丕七东丌丝下且.x;
            mem2[0] = 下业丕七东丌丝下且.y;
            mem[32] = 下业丕七东丌丝下且.z;
            val_3.strength = 丛上丟丌丄丗丁世与;
            mem[48] = 0;
        }
        
        if(val_5.enabled == true)
        {
                return (SpringPosition)val_5;
        }
        
        if(val_5 != null)
        {
                val_3.丈丐丗且与丐丅业东 = 0f;
        }
        else
        {
                mem[80] = 0;
        }
        
        val_5.enabled = true;
        return (SpringPosition)val_5;
    }
    public SpringPosition()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.target = val_1;
        mem[1152921535260029148] = val_1.y;
        mem[1152921535260029152] = val_1.z;
        this.strength = 10f;
    }

}
