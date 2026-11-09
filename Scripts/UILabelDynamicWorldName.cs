using UnityEngine;
public class UILabelDynamicWorldName : MonoBehaviour
{
    // Fields
    public UITweener.丞丝不丐丘不丕丞不 method;
    public bool showOnStart;
    public float fadeInDuration;
    public float fadeOutDuration;
    public float hideDelay;
    private UILabel 七丐丞丑丑丕世丙七;
    private TweenColor 三丙丘丕与不上东丆;
    private UnityEngine.Color 东上丙一七三丞七丟;
    
    // Methods
    private void Awake()
    {
        UILabel val_1 = this.GetComponent<UILabel>();
        this.七丐丞丑丑丕世丙七 = val_1;
        UnityEngine.Color val_2 = val_1.color;
        this.东上丙一七三丞七丟 = val_2;
        mem[1152921535444297540] = val_2.g;
        mem[1152921535444297544] = val_2.b;
        mem[1152921535444297548] = val_2.a;
    }
    private void Start()
    {
        var val_9;
        if(NJGMap.instance == 0)
        {
            goto label_3;
        }
        
        val_9 = System.Delegate.Combine(a:  X21, b:  new System.Action<System.String>(object:  this, method:  System.Void UILabelDynamicWorldName::丝丂下丌专不丈东丛(string 且丝下与丒上下丑丏)));
        if(NJGMap.instance == null)
        {
            goto label_5;
        }
        
        if(val_9 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_9 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_9 = 0;
        }
        
        label_9:
        mem2[0] = val_9;
        label_3:
        if(this.showOnStart == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.三专丝万一三丁丙三());
    }
    private System.Collections.IEnumerator 三专丝万一三丁丙三()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UILabelDynamicWorldName.丘七丐业世万丌不与();
    }
    private void 丕丕东丌丅丌业上丁()
    {
        this.三丙丘丕与不上东丆 = TweenColor.Begin(丝三丁东丈丒世丅业:  this.gameObject, 与丈业丛丝丒丙一丏:  this.fadeOutDuration, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.东上丙一七三丞七丟, g = V9.16B, b = V10.16B, a = 0f});
        val_2.from = this.东上丙一七三丞七丟;
        mem2[0] = ???;
        mem2[0] = ???;
        mem2[0] = 1065353216;
        mem2[0] = this.method;
    }
    private void 丝丂下丌专不丈东丛(string 且丝下与丒上下丑丏)
    {
        NJGMap val_1 = NJGMap.instance;
        this.东上丙一七三丞七丟 = new UnityEngine.Color();
        mem[1152921535444861252] = ???;
        mem[1152921535444861260] = ???;
        this.StopAllCoroutines();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.三专丝万一三丁丙三());
        this.七丐丞丑丑丕世丙七.text = 且丝下与丒上下丑丏;
    }
    public UILabelDynamicWorldName()
    {
        this.showOnStart = true;
        this.fadeInDuration = 1f;
        this.fadeOutDuration = 1f;
        this.hideDelay = 3f;
    }

}
