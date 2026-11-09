using UnityEngine;
internal sealed class TrainingFingerSwipe : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector2 arrowDdelta;
    private UnityEngine.Vector3 丄东丅丂丄丙一万业;
    private UnityEngine.RectTransform 下丂东丌丅万不丄丑;
    private Holoville.HOTween.Tweener 丆万丕丅丗且东丌丏;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
        this.下丂东丌丅万不丄丑 = val_1;
        UnityEngine.Vector2 val_2 = val_1.anchoredPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.丄东丅丂丄丙一万业 = val_3;
        mem[1152921539378040468] = val_3.y;
        mem[1152921539378040472] = val_3.z;
    }
    private void OnEnable()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.丄东丅丂丄丙一万业, y = V8.16B, z = V9.16B});
        this.下丂东丌丅万不丄丑.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        if(this.丆万丕丅丗且东丌丏 != null)
        {
                this.丆万丕丅丗且东丌丏.Kill();
        }
        
        this.丆万丕丅丗且东丌丏 = Holoville.HOTween.HOTween.To(p_target:  this.下丂东丌丅万不丄丑, p_duration:  1f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "anchoredPosition", p_endVal:  this.arrowDdelta, p_isRelative:  true).Ease(p_easeType:  4).Loops(p_loops:  0, p_loopType:  0));
    }
    private void Update()
    {
        int val_1 = this.丆万丕丅丗且东丌丏.completedLoops;
    }
    private void OnDisable()
    {
        if(this.丆万丕丅丗且东丌丏 == null)
        {
                return;
        }
        
        this.丆万丕丅丗且东丌丏.Kill();
        this.丆万丕丅丗且东丌丏 = 0;
    }
    public TrainingFingerSwipe()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.arrowDdelta = val_1;
        mem[1152921539378582668] = val_1.y;
    }

}
