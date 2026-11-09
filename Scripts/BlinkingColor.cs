using UnityEngine;
internal sealed class BlinkingColor : MonoBehaviour
{
    // Fields
    private int 丒丈专七专丄丌丄丛;
    private UnityEngine.Color 东与丐上且丟丑丒丆;
    public UnityEngine.Color curColor;
    public bool IsActive;
    private UnityEngine.Material 丟丙业世丐丁丂丅丐;
    public string nameColor;
    public UnityEngine.Color normal;
    public UnityEngine.Color blink;
    public float speed;
    private bool 丂丛丝丂世世丗丏丄;
    
    // Methods
    private void Awake()
    {
        this.丒丈专七专丄丌丄丛 = UnityEngine.Shader.PropertyToID(name:  this.nameColor);
    }
    private void Start()
    {
        UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
        {
                return;
        }
        
        UnityEngine.Material val_3 = val_1.sharedMaterial;
        this.丟丙业世丐丁丂丅丐 = val_3;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        UnityEngine.Color val_5 = this.丟丙业世丐丁丂丅丐.GetColor(nameID:  this.丒丈专七专丄丌丄丛);
        this.东与丐上且丟丑丒丆 = val_5;
        mem[1152921538298530624] = val_5.g;
        mem[1152921538298530628] = val_5.b;
        mem[1152921538298530632] = val_5.a;
    }
    private void OnDestroy()
    {
        this.丄丄丘丂不丝丁丆万();
    }
    private void Update()
    {
        if(this.IsActive != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.丟丙业世丐丁丂丅丐)) != false)
        {
                this.丟丙业世丐丁丂丅丐.SetColor(nameID:  this.丒丈专七专丄丌丄丛, value:  new UnityEngine.Color() {r = this.curColor, g = V9.16B, b = V10.16B, a = V11.16B});
        }
        
            if(this.丂丛丝丂世世丗丏丄 == true)
        {
                return;
        }
        
            this.丂下丆三丕一丌丁业();
            return;
        }
        
        if(this.丂丛丝丂世世丗丏丄 == false)
        {
                return;
        }
        
        this.丄丄丘丂不丝丁丆万();
    }
    private void 丄丄丘丂不丝丁丆万()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丟丙业世丐丁丂丅丐)) != false)
        {
                this.丟丙业世丐丁丂丅丐.SetColor(nameID:  this.丒丈专七专丄丌丄丛, value:  new UnityEngine.Color() {r = this.东与丐上且丟丑丒丆, g = V9.16B, b = V10.16B, a = V11.16B});
        }
        
        this.丂丛丝丂世世丗丏丄 = false;
        int val_2 = Holoville.HOTween.HOTween.Kill(p_target:  this);
    }
    private void 丕丑业世丏世丛丂丐()
    {
        this.丂丛丝丂世世丗丏丄 = true;
        Holoville.HOTween.Tweener val_6 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  this.speed, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "curColor", p_endVal:  this.normal).Ease(p_easeType:  0).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void BlinkingColor::丂下丆三丕一丌丁业())));
    }
    private void 丂下丆三丕一丌丁业()
    {
        this.丂丛丝丂世世丗丏丄 = true;
        Holoville.HOTween.Tweener val_6 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  this.speed, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "curColor", p_endVal:  this.blink).Ease(p_easeType:  0).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void BlinkingColor::丕丑业世丏世丛丂丐())));
    }
    public BlinkingColor()
    {
        this.IsActive = true;
        this.speed = 1f;
        this.nameColor = "_MainColor";
    }

}
