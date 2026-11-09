using UnityEngine;
public class AchieveBox : MonoBehaviour
{
    // Fields
    private bool 丌上丈丌丐丆丁丂三;
    public float deltaY;
    private UnityEngine.Vector3 丏上下丌丕丞丛丙世;
    public bool isOpened;
    private UISprite 下与不七丆丕丞丘丈;
    private UnityEngine.Vector3 丕下丕业丆丞七七丏;
    private UnityEngine.Vector3 一丒三上丛与丑丝丐;
    public float speed;
    public bool startFromShowPosition;
    private bool 与丝丐不丕一丆与丁;
    public bool useSpriteHeight;
    
    // Methods
    private void Awake()
    {
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_26;
        this.下与不七丆丕丞丘丈 = this.GetComponent<UISprite>();
        if(this.startFromShowPosition != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
            val_18 = val_2.y;
            if((this.useSpriteHeight != false) && (this.下与不七丆丕丞丘丈 != 0))
        {
                val_19 = (float)this.下与不七丆丕丞丘丈.height;
        }
        else
        {
                val_19 = this.deltaY;
        }
        
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_18, z = val_2.z}, d:  val_19);
            val_20 = this.丏上下丌丕丞丛丙世;
            val_21 = V8.16B;
            val_22 = V9.16B;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.丏上下丌丕丞丛丙世 = val_6;
            mem[1152921538033677668] = val_6.y;
            mem[1152921538033677672] = val_6.z;
            UnityEngine.Vector3 val_8 = this.transform.localPosition;
        }
        else
        {
                UnityEngine.Vector3 val_10 = this.transform.localPosition;
            val_17 = val_10.y;
            this.丏上下丌丕丞丛丙世 = val_10;
            mem[1152921538033677668] = val_17;
            mem[1152921538033677672] = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
            val_18 = val_11.y;
            if((this.useSpriteHeight != false) && (this.下与不七丆丕丞丘丈 != 0))
        {
                val_26 = (float)this.下与不七丆丕丞丘丈.height;
        }
        else
        {
                val_26 = this.deltaY;
        }
        
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_18, z = val_11.z}, d:  val_26);
            val_20 = val_10.x;
            val_21 = val_17;
            val_22 = val_10.z;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        }
        
        this.一丒三上丛与丑丝丐 = val_15;
        mem[1152921538033677704] = val_15.y;
        mem[1152921538033677708] = val_15.z;
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.丏上下丌丕丞丛丙世, y = val_17, z = val_10.z};
    }
    private void OnEnable()
    {
        if(this.丌上丈丌丐丆丁丂三 != false)
        {
                this.丌上丈丌丐丆丁丂三 = false;
            return;
        }
        
        this.gameObject.SetActive(value:  false);
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.丏上下丌丕丞丛丙世, y = V9.16B, z = V10.16B};
    }
    private void OnDisable()
    {
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.丏上下丌丕丞丛丙世, y = V9.16B, z = V10.16B};
        this.isOpened = false;
        this.丌上丈丌丐丆丁丂三 = false;
    }
    internal void 丁丛丝丆丘丞丕丈三()
    {
        this.与丝丐不丕一丆与丁 = false;
        this.gameObject.SetActive(value:  false);
    }
    public void ShowBox()
    {
        this.丌上丈丌丐丆丁丂三 = true;
        this.gameObject.SetActive(value:  true);
        this.与丝丐不丕一丆与丁 = true;
        this.丕下丕业丆丞七七丏 = this.一丒三上丛与丑丝丐;
        mem[1152921538034195328] = ???;
    }
    public void HideBox()
    {
        this.与丝丐不丕一丆与丁 = true;
        this.丕下丕业丆丞七七丏 = this.丏上下丌丕丞丛丙世;
        mem[1152921538034311424] = ???;
    }
    private void Update()
    {
        if(this.与丝丐不丕一丆与丁 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = this.丕下丕业丆丞七七丏, y = V11.16B, z = V10.16B})) != false)
        {
                this.与丝丐不丕一丆与丁 = false;
            this.isOpened = this.isOpened ^ 1;
            if(this.isOpened == false)
        {
                return;
        }
        
            this.gameObject.SetActive(value:  false);
            return;
        }
        
        UnityEngine.Vector3 val_8 = this.transform.localPosition;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, target:  new UnityEngine.Vector3() {x = this.丕下丕业丆丞七七丏, y = V11.16B, z = this.丕下丕业丆丞七七丏}, maxDistanceDelta:  this.speed * RealTime.deltaTime);
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    public AchieveBox()
    {
        this.deltaY = 128f;
        this.speed = 300f;
        this.useSpriteHeight = true;
    }

}
