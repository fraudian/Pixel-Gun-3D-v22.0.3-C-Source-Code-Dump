using UnityEngine;
internal sealed class AdjustSpriteToLabel : MonoBehaviour
{
    // Fields
    private UISprite 丛东上丂东一丒丈世;
    public UILabel label;
    public float padding;
    
    // Methods
    private void Start()
    {
        this.丛东上丂东一丒丈世 = this.GetComponent<UISprite>();
        if(this.label == 0)
        {
                this.label = this.transform.parent.GetComponent<UILabel>();
        }
        
        if(this.丛东上丂东一丒丈世 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "sprite == null");
        }
        
        if(this.label != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "label == null");
    }
    private void Update()
    {
        if(this.丛东上丂东一丒丈世 == 0)
        {
                return;
        }
        
        if(this.label == 0)
        {
                return;
        }
        
        this = this.丛东上丂东一丒丈世.transform;
        float val_5 = (float)this.label.width;
        val_5 = val_5 * 0.5f;
        val_5 = this.padding + val_5;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public AdjustSpriteToLabel()
    {
        this.padding = 30f;
    }

}
