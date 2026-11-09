using UnityEngine;
public class UIButtonMessage : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject target;
    public string functionName;
    public UIButtonMessage.丏三业丕丈丄丂丑东 trigger;
    public bool includeChildren;
    private bool 不世丌丝且三上丏丌;
    
    // Methods
    private void Start()
    {
        this.不世丌丝且三上丏丌 = true;
    }
    private void OnEnable()
    {
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        this.OnHover(丟丆丕且丆丈丂丌丘:  UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject));
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(丟丆丕且丆丈丂丌丘 == false)
        {
            goto label_1;
        }
        
        if(this.trigger == 1)
        {
            goto label_2;
        }
        
        return;
        label_1:
        if(this.trigger != 2)
        {
                return;
        }
        
        label_2:
        this.丈丂丑丒三一下丏七();
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(丆丟专丑丁丒丁上丙 == false)
        {
            goto label_1;
        }
        
        if(this.trigger == 3)
        {
            goto label_2;
        }
        
        return;
        label_1:
        if(this.trigger != 4)
        {
                return;
        }
        
        label_2:
        this.丈丂丑丒三一下丏七();
    }
    private void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(丞丈丌且东丆丅丗万 != false)
        {
                if(UICamera.currentScheme != 2)
        {
                return;
        }
        
        }
        
        this.OnHover(丟丆丕且丆丈丂丌丘:  丞丈丌且东丆丅丗万);
    }
    private void OnClick()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 0)
        {
                return;
        }
        
        this.丈丂丑丒三一下丏七();
    }
    private void OnDoubleClick()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.trigger != 5)
        {
                return;
        }
        
        this.丈丂丑丒三一下丏七();
    }
    private void 丈丂丑丒三一下丏七()
    {
        UnityEngine.GameObject val_9;
        int val_10;
        var val_11;
        if((System.String.IsNullOrEmpty(value:  this.functionName)) == true)
        {
                return;
        }
        
        if(this.target == 0)
        {
                val_9 = this.gameObject;
            this.target = val_9;
        }
        else
        {
                val_9 = this.target;
        }
        
        if(this.includeChildren == false)
        {
            goto label_6;
        }
        
        if(val_4.Length < 1)
        {
                return;
        }
        
        val_10 = val_4.Length & 4294967295;
        val_11 = 0;
        goto label_10;
        label_14:
        val_10 = val_4.Length;
        val_11 = 1;
        label_10:
        X21.gameObject.SendMessage(methodName:  this.functionName, value:  this.gameObject, options:  1);
        if((val_10 - 1) != val_11)
        {
            goto label_14;
        }
        
        return;
        label_6:
        val_9.SendMessage(methodName:  this.functionName, value:  this.gameObject, options:  1);
    }
    public UIButtonMessage()
    {
    
    }

}
