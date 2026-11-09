using UnityEngine;
public class UIShowControlScheme : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject target;
    public bool mouse;
    public bool touch;
    public bool controller;
    
    // Methods
    private void OnEnable()
    {
        var val_4;
        丏丄丈丗丌丘不不一 val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Combine(a:  UICamera.onSchemeChange, b:  new UICamera.丏丄丈丗丌丘不不一(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIShowControlScheme::丞丂丘丄上丗三丞且()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        UICamera.onSchemeChange = val_5;
        this.丞丂丘丄上丗三丞且();
    }
    private void OnDisable()
    {
        var val_4;
        丏丄丈丗丌丘不不一 val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  UICamera.onSchemeChange, value:  new UICamera.丏丄丈丗丌丘不不一(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIShowControlScheme::丞丂丘丄上丗三丞且()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        UICamera.onSchemeChange = val_5;
    }
    private void 丞丂丘丄上丗三丞且()
    {
        if(this.target == 0)
        {
                return;
        }
        
        三下七东不东丈丈丞 val_2 = UICamera.currentScheme;
        if(val_2 == 2)
        {
            goto label_6;
        }
        
        if(val_2 == 1)
        {
            goto label_7;
        }
        
        if(val_2 != 0)
        {
                return;
        }
        
        if(this.target != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        this.target.SetActive(value:  (this.mouse == true) ? 1 : 0);
        return;
        label_6:
        if(this.target != null)
        {
            goto label_12;
        }
        
        goto label_13;
        label_7:
        if(this.target != null)
        {
            goto label_12;
        }
        
        goto label_13;
    }
    public UIShowControlScheme()
    {
        this.controller = true;
    }

}
