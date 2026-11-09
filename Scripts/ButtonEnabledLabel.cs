using UnityEngine;
public class ButtonEnabledLabel : MonoBehaviour
{
    // Fields
    public UIButton myButton;
    public UnityEngine.GameObject enabledLabel;
    public UnityEngine.GameObject disableLabel;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        var val_3;
        if((this.myButton & 1) != 0)
        {
                val_3 = 0;
            if(this.enabledLabel.activeSelf != true)
        {
                this.enabledLabel.SetActive(value:  true);
            val_3 = 0;
            this.disableLabel.SetActive(value:  false);
        }
        
        }
        
        if((this.myButton & 1) != 0)
        {
                return;
        }
        
        if(this.enabledLabel.activeSelf == false)
        {
                return;
        }
        
        this.enabledLabel.SetActive(value:  false);
        this.disableLabel.SetActive(value:  true);
    }
    public ButtonEnabledLabel()
    {
    
    }

}
