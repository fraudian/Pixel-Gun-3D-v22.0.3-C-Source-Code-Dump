using UnityEngine;
public class FixedSlider : MonoBehaviour
{
    // Fields
    public UIProgressBar Slider;
    private UnityEngine.Vector3 <专丕下丐丆丈且七七>k__BackingField;
    private UnityEngine.Vector3 <七专丄丂丆丕丅业业>k__BackingField;
    private UnityEngine.Vector3 <丟不丌万万且丌不万>k__BackingField;
    private UIScrollView 业丘丘丕专丞丅丈丙;
    private UIWidget 一丆东专不万且七丂;
    private float 丘专且丁丐东一丐丏;
    
    // Properties
    public UIScrollView 上丛不专丂丐丝丛一 { get; set; }
    public UnityEngine.Vector3 丘丝丒丐丒与丛下丈 { get; set; }
    public UnityEngine.Vector3 丞三不丒丈七七丏丄 { get; set; }
    public UnityEngine.Vector3 丒专上专七专丒丟丅 { get; set; }
    
    // Methods
    public UIScrollView get_ScrollView()
    {
        return (UIScrollView)this.业丘丘丕专丞丅丈丙;
    }
    public void set_ScrollView(UIScrollView 丙业与丙丗丝不丈东)
    {
        this.业丘丘丕专丞丅丈丙 = 丙业与丙丗丝不丈东;
        this.七丒下丂丝且丕丌东();
    }
    public UnityEngine.Vector3 get_ContentSize()
    {
        return new UnityEngine.Vector3() {x = this.<专丕下丐丆丈且七七>k__BackingField};
    }
    public void set_ContentSize(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.<专丕下丐丆丈且七七>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921526021965300] = 丙业与丙丗丝不丈东.y;
        mem[1152921526021965304] = 丙业与丙丗丝不丈东.z;
    }
    public UnityEngine.Vector3 get_ViewSize()
    {
        return new UnityEngine.Vector3() {x = this.<七专丄丂丆丕丅业业>k__BackingField};
    }
    public void set_ViewSize(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.<七专丄丂丆丕丅业业>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921526022189312] = 丙业与丙丗丝不丈东.y;
        mem[1152921526022189316] = 丙业与丙丗丝不丈东.z;
    }
    public UnityEngine.Vector3 get_StartContentPosition()
    {
        return new UnityEngine.Vector3() {x = this.<丟不丌万万且丌不万>k__BackingField};
    }
    public void set_StartContentPosition(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.<丟不丌万万且丌不万>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921526022413324] = 丙业与丙丗丝不丈东.y;
        mem[1152921526022413328] = 丙业与丙丗丝不丈东.z;
    }
    public void UpdateSlider(UnityEngine.Vector3 丒不三丁丒丏丂丒丈)
    {
        float val_5;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丒不三丁丒丏丂丒丈.x, y = 丒不三丁丒丏丂丒丈.y, z = 丒不三丁丒丏丂丒丈.z}, b:  new UnityEngine.Vector3() {x = this.<丟不丌万万且丌不万>k__BackingField, y = V11.16B, z = V12.16B});
        float val_5 = 0.0001f;
        float val_4 = System.Math.Abs(val_1.y);
        val_5 = 0f;
        if(val_4 > val_5)
        {
                val_5 = val_5 - val_4;
            val_5 = val_1.y / val_5;
        }
        
        if(this.Slider == 0)
        {
                return;
        }
        
        this.Slider.value = UnityEngine.Mathf.Clamp01(value:  val_5);
    }
    private void Awake()
    {
        this.一丆东专不万且七丂 = this.Slider.thumb.GetComponent<UIWidget>();
    }
    private void OnEnable()
    {
        this.丈七丐业丅丅丗丙丄();
        this.七丒下丂丝且丕丌东();
    }
    private void Update()
    {
        this.七丒下丂丝且丕丌东();
    }
    private void 七丒下丂丝且丕丌东()
    {
        float val_4;
        if(this.业丘丘丕专丞丅丈丙 == 0)
        {
                return;
        }
        
        if(this.一丆东专不万且七丂 == 0)
        {
                return;
        }
        
        float val_6 = this.业丘丘丕专丞丅丈丙.panel.width;
        val_6 = val_6 * 0.5f;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_9 = this.业丘丘丕专丞丅丈丙.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_12 = this.transform.position;
        this = this.transform;
        UnityEngine.Vector3 val_14 = this.position;
        float val_15 = val_9.x + this.丘专且丁丐东一丐丏;
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丈七丐业丅丅丗丙丄()
    {
        UnityEngine.Vector3 val_1 = this.一丆东专不万且七丂.localCenter;
        float val_9 = (float)this.一丆东专不万且七丂.width;
        val_9 = val_9 * 0.5f;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_5 = this.一丆东专不万且七丂.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_7 = this.一丆东专不万且七丂.localCenter;
        UnityEngine.Vector3 val_8 = this.一丆东专不万且七丂.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
    }
    public FixedSlider()
    {
    
    }

}
