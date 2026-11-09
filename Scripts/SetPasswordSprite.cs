using UnityEngine;
public class SetPasswordSprite : MonoBehaviour
{
    // Fields
    public UIInput input;
    public UnityEngine.GameObject openSprite;
    public UnityEngine.GameObject closeSprite;
    
    // Methods
    private void Update()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        bool val_3 = this.openSprite.activeSelf;
        if((System.String.IsNullOrEmpty(value:  this.input.value)) != false)
        {
                if(val_3 == true)
        {
                return;
        }
        
            this.openSprite.SetActive(value:  true);
            val_4 = this.closeSprite;
            val_5 = 0;
        }
        else
        {
                if(val_3 == false)
        {
                return;
        }
        
            this.openSprite.SetActive(value:  false);
            val_4 = this.closeSprite;
            val_5 = 1;
        }
        
        val_4.SetActive(value:  true);
    }
    public SetPasswordSprite()
    {
    
    }

}
