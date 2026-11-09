using UnityEngine;
public class SetFontSize : MonoBehaviour
{
    // Fields
    private UILabel 上丘丞丞丗丈丅丂下;
    
    // Methods
    private void Start()
    {
        this.上丘丞丞丗丈丅丂下 = this.GetComponent<UILabel>();
        this.UpdateFontSize();
    }
    private void UpdateFontSize()
    {
        int val_4;
        if(this.上丘丞丞丗丈丅丂下 == 0)
        {
                return;
        }
        
        if(this.上丘丞丞丗丈丅丂下 != null)
        {
                val_4 = this.上丘丞丞丗丈丅丂下.height;
        }
        else
        {
                val_4 = 0.height;
        }
        
        this.上丘丞丞丗丈丅丂下.fontSize = val_4;
    }
    private void OnEnable()
    {
        this.Invoke(methodName:  "UpdateFontSize", time:  0.05f);
    }
    private void Update()
    {
        int val_5;
        if(this.上丘丞丞丗丈丅丂下.fontSize == this.上丘丞丞丗丈丅丂下.height)
        {
                return;
        }
        
        if(this.上丘丞丞丗丈丅丂下 != null)
        {
                val_5 = this.上丘丞丞丗丈丅丂下.height;
        }
        else
        {
                val_5 = 0.height;
        }
        
        this.上丘丞丞丗丈丅丂下.fontSize = val_5;
    }
    public SetFontSize()
    {
    
    }

}
