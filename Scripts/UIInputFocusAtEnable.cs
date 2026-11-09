using UnityEngine;
public class UIInputFocusAtEnable : MonoBehaviour
{
    // Fields
    private const float 与丏丁一东丅丅丑与 = 0.3;
    private bool 丗丌丗丈万上上东不;
    private UIInput _input;
    private bool _onlyOnce;
    
    // Methods
    private void Awake()
    {
        UIInput val_1 = this.GetComponent<UIInput>();
        this._input = val_1;
        if(val_1 != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "input not found");
    }
    private void OnEnable()
    {
        if(this._onlyOnce != false)
        {
                if(this.丗丌丗丈万上上东不 == true)
        {
                return;
        }
        
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丐丌与丘丂丆丆丑丕());
        this.丗丌丗丈万上上东不 = true;
    }
    private System.Collections.IEnumerator 丐丌与丘丂丆丆丑丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UIInputFocusAtEnable.丌不丝丞丞世丛世丏();
    }
    public UIInputFocusAtEnable()
    {
    
    }

}
