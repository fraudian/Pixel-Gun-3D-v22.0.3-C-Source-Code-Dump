using UnityEngine;
internal sealed class TrainingFinger : MonoBehaviour
{
    // Fields
    public float AngleX;
    public float AngleY;
    public UnityEngine.Vector3 initialPosition;
    private UnityEngine.RectTransform 下丂东丌丅万不丄丑;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        this.下丂东丌丅万不丄丑 = val_1;
        UnityEngine.Vector3 val_2 = val_1.localPosition;
        this.initialPosition = val_2;
        mem[1152921539377465332] = val_2.y;
        mem[1152921539377465336] = val_2.z;
    }
    private void OnEnable()
    {
        this.下丂东丌丅万不丄丑.localPosition = new UnityEngine.Vector3() {x = this.initialPosition, y = V9.16B, z = V10.16B};
        this.AngleX = 0f;
        Holoville.HOTween.Tweener val_5 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  4f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "AngleX", p_endVal:  6.283185f, p_isRelative:  true).Ease(p_easeType:  0).Loops(p_loops:  0, p_loopType:  0));
        this.AngleY = 0f;
        Holoville.HOTween.Tweener val_10 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  2f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "AngleY", p_endVal:  6.283185f, p_isRelative:  true).Ease(p_easeType:  0).Loops(p_loops:  0, p_loopType:  0));
    }
    private void Update()
    {
        float val_1 = this.AngleX * 60f;
        float val_2 = this.AngleY * 30f;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.initialPosition, y = V9.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public TrainingFinger()
    {
    
    }

}
