using UnityEngine;
public class ToggleFix : MonoBehaviour
{
    // Fields
    public UIToggle toggle;
    public UIButton button;
    public UISprite background;
    public UISprite checkmark;
    public bool oldState;
    public bool firstUpdate;
    
    // Methods
    private void Start()
    {
        this.button = this.GetComponent<UIButton>();
    }
    private void Update()
    {
        if(this.button.state == 2)
        {
                return;
        }
        
        UnityEngine.Color val_2 = this.checkmark.color;
        UnityEngine.Color val_3 = this.checkmark.color;
        UnityEngine.Color val_4 = this.checkmark.color;
        var val_6 = (this.toggle.value != true) ? 1f : 0f;
        this.checkmark.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Color val_7 = this.background.color;
        UnityEngine.Color val_8 = this.background.color;
        UnityEngine.Color val_9 = this.background.color;
        this = this.toggle;
        var val_11 = (this.value != true) ? 0f : 1f;
        this.background.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void OnPress()
    {
        UnityEngine.Color val_1 = this.checkmark.color;
        UnityEngine.Color val_2 = this.checkmark.color;
        UnityEngine.Color val_3 = this.checkmark.color;
        this.checkmark.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Color val_4 = this.background.color;
        UnityEngine.Color val_5 = this.background.color;
        UnityEngine.Color val_6 = this.background.color;
        this.background.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public ToggleFix()
    {
        this.firstUpdate = true;
    }

}
