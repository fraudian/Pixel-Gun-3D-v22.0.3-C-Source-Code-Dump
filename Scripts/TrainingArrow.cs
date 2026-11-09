using UnityEngine;
internal sealed class TrainingArrow : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector2 arrowDelta;
    private UnityEngine.Vector2 丗丕丐丄世七丙三业;
    private UnityEngine.RectTransform 下丂东丌丅万不丄丑;
    private Holoville.HOTween.Tweener 丆万丕丅丗且东丌丏;
    
    // Methods
    private void 丘上丐世丆丑且丞丒()
    {
        if(this.下丂东丌丅万不丄丑 != 0)
        {
                return;
        }
        
        UnityEngine.RectTransform val_2 = this.GetComponent<UnityEngine.RectTransform>();
        this.下丂东丌丅万不丄丑 = val_2;
        UnityEngine.Vector2 val_3 = val_2.anchoredPosition;
        this.丗丕丐丄世七丙三业 = val_3;
        mem[1152921539376625284] = val_3.y;
    }
    public void SetAnchoredPosition(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_8 = 业丒丝丗与丐丛丟丏.z;
        this.丘上丐世丆丑且丞丒();
        if(this.下丂东丌丅万不丄丑 == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = val_8});
        val_8 = val_2.x;
        this.下丂东丌丅万不丄丑.anchoredPosition = new UnityEngine.Vector2() {x = val_8, y = val_2.y};
        UnityEngine.Vector2 val_3 = this.下丂东丌丅万不丄丑.anchoredPosition;
        this.丗丕丐丄世七丙三业 = val_3;
        mem[1152921539376786548] = val_3.y;
        if(this.丆万丕丅丗且东丌丏 != null)
        {
                this.丆万丕丅丗且东丌丏.Kill();
        }
        
        this.丆万丕丅丗且东丌丏 = Holoville.HOTween.HOTween.To(p_target:  this.下丂东丌丅万不丄丑, p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "anchoredPosition", p_endVal:  this.arrowDelta, p_isRelative:  true).Loops(p_loops:  0, p_loopType:  2));
    }
    private void Awake()
    {
        this.丘上丐世丆丑且丞丒();
    }
    private void OnEnable()
    {
        this.下丂东丌丅万不丄丑.anchoredPosition = new UnityEngine.Vector2() {x = this.丗丕丐丄世七丙三业, y = V9.16B};
        if(this.丆万丕丅丗且东丌丏 != null)
        {
                this.丆万丕丅丗且东丌丏.Kill();
        }
        
        this.丆万丕丅丗且东丌丏 = Holoville.HOTween.HOTween.To(p_target:  this.下丂东丌丅万不丄丑, p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "anchoredPosition", p_endVal:  this.arrowDelta, p_isRelative:  true).Loops(p_loops:  0, p_loopType:  2));
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
    public TrainingArrow()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.arrowDelta = val_1;
        mem[1152921539377349228] = val_1.y;
    }

}
