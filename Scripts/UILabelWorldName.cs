using UnityEngine;
public class UILabelWorldName : MonoBehaviour
{
    // Fields
    private UILabel 七丐丞丑丑丕世丙七;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Object val_8;
        var val_9;
        this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
        val_8 = NJGMap.instance;
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = NJGMap.instance;
        val_9 = System.Delegate.Combine(a:  X21, b:  new System.Action<System.String>(object:  this, method:  System.Void UILabelWorldName::丝丂下丌专不丈东丛(string 且丝下与丒上下丑丏)));
        if(val_8 == null)
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
    }
    private void 丝丂下丌专不丈东丛(string 且丝下与丒上下丑丏)
    {
        NJGMap val_1 = NJGMap.instance;
        this.七丐丞丑丑丕世丙七.color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
        this.七丐丞丑丑丕世丙七.text = 且丝下与丒上下丑丏;
    }
    public UILabelWorldName()
    {
    
    }

}
