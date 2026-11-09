using UnityEngine;
public class SpringPanel : MonoBehaviour
{
    // Fields
    public static SpringPanel current;
    public UnityEngine.Vector3 target;
    public float strength;
    public SpringPanel.上丄丂丛专下丟万下 onFinished;
    protected UIPanel 与业丌丄且丁丛与丁;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected UIScrollView 三丅丞丛丆业且丕丞;
    protected bool 万丝丅丕丕丑业专丆;
    public float lerpFactor;
    private UnityEngine.Vector3 丄且一丄丏丆丐丗与;
    
    // Methods
    private void Start()
    {
        this.与业丌丄且丁丛与丁 = this.GetComponent<UIPanel>();
        this.三丅丞丛丆业且丕丞 = this.GetComponent<UIScrollView>();
        this.丐一丗丛丕世丘东丁 = this.transform;
    }
    private void Update()
    {
        goto typeof(SpringPanel).__il2cppRuntimeField_168;
    }
    private void OnEnable()
    {
        UnityEngine.Transform val_4;
        if(this.万丝丅丕丕丑业专丆 == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丐一丗丛丕世丘东丁)) == false)
        {
            goto label_4;
        }
        
        val_4 = this.丐一丗丛丕世丘东丁;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_4:
        val_4 = this.transform;
        this.丐一丗丛丕世丘东丁 = val_4;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        UnityEngine.Vector3 val_3 = val_4.localPosition;
        this.丄且一丄丏丆丐丗与 = val_3;
        mem[1152921535217919028] = val_3.y;
        mem[1152921535217919032] = val_3.z;
    }
    protected UnityEngine.Vector3 丐上丐上东丐专上不(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丛上丟丌丄丗丁世与)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, b:  new UnityEngine.Vector3() {x = this.丄且一丄丏丆丐丗与, y = V14.16B, z = V13.16B});
        float val_6 = 0.5f;
        float val_3 = 丛上丟丌丄丗丁世与 * 0.25f;
        val_6 = 丛上丟丌丄丗丁世与 * val_6;
        float val_4 = UnityEngine.Mathf.Clamp(value:  val_2.x, min:  val_3, max:  val_6);
        val_4 = UnityEngine.Time.unscaledDeltaTime * val_4;
        丛上丟丌丄丗丁世与 = this.lerpFactor + val_4;
        this.lerpFactor = 丛上丟丌丄丗丁世与;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丄且一丄丏丆丐丗与, y = val_3, z = val_6}, b:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, t:  丛上丟丌丄丗丁世与);
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    protected virtual void 与丑与丙丒下丟丛丆()
    {
        SpringPanel val_15;
        var val_16;
        var val_17;
        float val_21;
        float val_22;
        float val_23;
        float val_27;
        var val_29;
        val_15 = this;
        UnityEngine.Vector3 val_2 = this.丐一丗丛丕世丘东丁.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_4 = this.丐一丗丛丕世丘东丁.localPosition;
        if(this.万丝丅丕丕丑业专丆 != false)
        {
                val_16 = val_15;
            val_17 = val_15;
            UnityEngine.Vector3 val_5 = this.丐上丐上东丐专上不(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = this.target}, 丛上丟丌丄丗丁世与:  this.strength);
        }
        else
        {
                val_16 = 1152921535218200312;
            val_17 = 1152921535218200312;
            UnityEngine.Vector3 val_6 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = this.target}, 丛上丟丌丄丗丁世与:  this.strength, 丑丗丘与丈不七东丛:  RealTime.deltaTime);
        }
        
        val_21 = val_6.x;
        val_22 = val_6.y;
        val_23 = val_6.z;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, b:  new UnityEngine.Vector3() {x = this.target, y = V14.16B, z = V15.16B});
        if(val_7.x < 0)
        {
                if(this.万丝丅丕丕丑业专丆 != false)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_27 = val_9.z;
            this.与业丌丄且丁丛与丁.GetComponent<UIScrollView>().currentMomentum = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_27};
            this.lerpFactor = 0f;
        }
        
            val_21 = this.target;
            this.enabled = false;
            val_29 = 1;
        }
        else
        {
                val_29 = 0;
        }
        
        this.丐一丗丛丕世丘东丁.localPosition = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector2 val_11 = this.与业丌丄且丁丛与丁.clipOffset;
        this.与业丌丄且丁丛与丁.clipOffset = new UnityEngine.Vector2() {x = val_11.x - val_10.x, y = val_11.y - val_10.y};
        bool val_14 = UnityEngine.Object.op_Inequality(x:  this.三丅丞丛丆业且丕丞, y:  0);
        if(val_29 == 0)
        {
                return;
        }
        
        if(this.onFinished == null)
        {
                return;
        }
        
        SpringPanel.current = val_15;
        val_15 = this.onFinished;
        val_15.Invoke();
        SpringPanel.current = 0;
    }
    public static SpringPanel Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector3 下业丕七东丌丝下且, float 丛上丟丌丄丗丁世与)
    {
        SpringPanel val_4 = 丝三丁东丈丒世丅业.GetComponent<SpringPanel>();
        if(val_4 == 0)
        {
                val_4 = 丝三丁东丈丒世丅业.AddComponent<SpringPanel>();
        }
        
        if(val_4 != null)
        {
                val_3.target = 下业丕七东丌丝下且;
            mem2[0] = 下业丕七东丌丝下且.y;
            mem2[0] = 下业丕七东丌丝下且.z;
            val_3.strength = 丛上丟丌丄丗丁世与;
            val_3.onFinished = 0;
            val_4.enabled = true;
        }
        else
        {
                mem[24] = 下业丕七东丌丝下且.x;
            mem2[0] = 下业丕七东丌丝下且.y;
            mem[32] = 下业丕七东丌丝下且.z;
            val_3.strength = 丛上丟丌丄丗丁世与;
            mem[40] = 0;
            0.enabled = true;
        }
        
        val_3.万丝丅丕丕丑业专丆 = false;
        return (SpringPanel)val_4;
    }
    public static SpringPanel BeginExtended(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector3 下业丕七东丌丝下且, float 丛上丟丌丄丗丁世与)
    {
        SpringPanel val_4 = 丝三丁东丈丒世丅业.GetComponent<SpringPanel>();
        if(val_4 == 0)
        {
                val_4 = 丝三丁东丈丒世丅业.AddComponent<SpringPanel>();
        }
        
        if(val_3.lerpFactor != 0f)
        {
                return (SpringPanel)val_4;
        }
        
        val_3.target = 下业丕七东丌丝下且;
        mem2[0] = 下业丕七东丌丝下且.y;
        mem2[0] = 下业丕七东丌丝下且.z;
        val_3.strength = 丛上丟丌丄丗丁世与;
        val_3.万丝丅丕丕丑业专丆 = true;
        val_3.onFinished = 0;
        val_4.enabled = false;
        val_4.enabled = true;
        return (SpringPanel)val_4;
    }
    public SpringPanel()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.target = val_1;
        mem[1152921535218632572] = val_1.y;
        mem[1152921535218632576] = val_1.z;
        this.strength = 10f;
    }

}
