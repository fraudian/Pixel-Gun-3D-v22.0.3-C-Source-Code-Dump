using UnityEngine;
internal sealed class ControlsSettingsMainPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform SliderSizeTransform;
    public UnityEngine.Transform SliderOpacityTransform;
    public UnityEngine.Transform topLeftBorder;
    public UnityEngine.Transform bottomRightBorder;
    private UnityEngine.GameObject ZoneBottonRight;
    private UnityEngine.GameObject ZoneTopLeft;
    private UnityEngine.Vector3 丌且丑丅丁丄万丘丅;
    private UnityEngine.Vector3 丙丅三丕丅且丅下且;
    private UnityEngine.Vector3 丆丅丁丏不丞丘一下;
    private UnityEngine.Vector2 丘丘丗一万丙丕且不;
    private UnityEngine.Vector2 丗丁丂丅丂上七一世;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.丌且丑丅丁丄万丘丅 = val_2;
        mem[1152921539944140716] = val_2.y;
        mem[1152921539944140720] = val_2.z;
        if(this.SliderOpacityTransform != 0)
        {
                UnityEngine.Vector3 val_4 = this.SliderOpacityTransform.localPosition;
            this.丆丅丁丏不丞丘一下 = val_4;
            mem[1152921539944140740] = val_4.y;
            mem[1152921539944140744] = val_4.z;
        }
        
        if(this.SliderSizeTransform != 0)
        {
                UnityEngine.Vector3 val_6 = this.SliderSizeTransform.localPosition;
            this.丙丅三丕丅且丅下且 = val_6;
            mem[1152921539944140728] = val_6.y;
            mem[1152921539944140732] = val_6.z;
        }
        
        if(this.topLeftBorder != 0)
        {
                UnityEngine.Vector3 val_8 = this.topLeftBorder.localPosition;
            UnityEngine.Vector3 val_9 = this.topLeftBorder.localPosition;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_8.x, y:  val_9.y);
            this.丘丘丗一万丙丕且不 = val_10.x;
            mem[1152921539944140752] = val_10.y;
        }
        
        if(this.bottomRightBorder == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_12 = this.bottomRightBorder.localPosition;
        UnityEngine.Vector3 val_13 = this.bottomRightBorder.localPosition;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_12.x, y:  val_13.y);
        this.丗丁丂丅丂上七一世 = val_14.x;
        mem[1152921539944140760] = val_14.y;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_5 = this.丌且丑丅丁丄万丘丅;
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_5, y = V9.16B, z = V10.16B};
        if(this.SliderOpacityTransform != 0)
        {
                val_5 = this.丆丅丁丏不丞丘一下;
            this.SliderOpacityTransform.localPosition = new UnityEngine.Vector3() {x = val_5, y = V9.16B, z = V10.16B};
        }
        
        if(this.SliderSizeTransform == 0)
        {
                return;
        }
        
        this.SliderSizeTransform.localPosition = new UnityEngine.Vector3() {x = this.丙丅三丕丅且丅下且, y = V9.16B, z = V10.16B};
    }
    private void Update()
    {
    
    }
    private void 下丏且一三丐一丐不(UnityEngine.Transform 丄三丟丗东丟丝下丝, float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌)
    {
        if(丄三丟丗东丟丝下丝 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = 丄三丟丗东丟丝下丝.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丒丒丄丁且丄丆丂丌 = val_3.x;
        丄三丟丗东丟丝下丝.localPosition = new UnityEngine.Vector3() {x = 丒丒丄丁且丄丆丂丌, y = val_3.y, z = val_3.z};
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, d:  与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector2 val_7 = this.丗丘丒丄丅丗丂丞丟(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector3 val_9 = this.transform.localPosition;
        UnityEngine.Vector3 val_11 = this.transform.localPosition;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_9.x, y:  val_11.y);
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        UnityEngine.Transform val_14 = this.transform;
        val_14.下丏且一三丐一丐不(丄三丟丗东丟丝下丝:  val_14, 三丟东丕丄丄下下丑:  val_13.x, 丒丒丄丁且丄丆丂丌:  val_13.y);
        val_14.下丏且一三丐一丐不(丄三丟丗东丟丝下丝:  this.SliderSizeTransform, 三丟东丕丄丄下下丑:  val_13.x, 丒丒丄丁且丄丆丂丌:  val_13.y);
        val_14.下丏且一三丐一丐不(丄三丟丗东丟丝下丝:  this.SliderOpacityTransform, 三丟东丕丄丄下下丑:  val_13.x, 丒丒丄丁且丄丆丂丌:  val_13.y);
    }
    private UnityEngine.Vector2 丗丘丒丄丅丗丂丞丟(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        UnityEngine.Vector3 val_2 = this.ZoneTopLeft.transform.localPosition;
        UnityEngine.Vector3 val_4 = this.ZoneBottonRight.transform.localPosition;
        UnityEngine.Vector3 val_9 = this.ZoneBottonRight.transform.localPosition;
        UnityEngine.Vector3 val_11 = this.ZoneTopLeft.transform.localPosition;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Clamp(value:  下业丕七东丌丝下且.x, min:  val_2.x + this.丗丁丂丅丂上七一世, max:  val_4.x + this.丘丘丗一万丙丕且不), y:  UnityEngine.Mathf.Clamp(value:  下业丕七东丌丝下且.y, min:  val_9.y - val_4.x, max:  val_11.y - val_11.x));
        return new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
    }
    public ControlsSettingsMainPanel()
    {
    
    }

}
