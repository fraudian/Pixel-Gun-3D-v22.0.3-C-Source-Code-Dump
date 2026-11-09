using UnityEngine;
public class SpeedUpButtonControl : MonoBehaviour
{
    // Fields
    public 丙且上东下丏丏丟下 shopItem;
    public PriceContainer price;
    public UILabel timeToUpl;
    public UIButton speedUpButton;
    public UnityEngine.GameObject watchAdvertButton;
    public bool isWeapon;
    private float 丙一丑丏丁一且丒业;
    private bool 且丂丙世一上业三业;
    
    // Methods
    private void OnEnable()
    {
        this.且丂丙世一上业三业 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  220);
        if(this.speedUpButton == null)
        {
            
        }
    
    }
    private void Update()
    {
        if(this.timeToUpl != 0)
        {
                if(this.timeToUpl.gameObject.activeSelf != true)
        {
                this.timeToUpl.gameObject.SetActive(value:  true);
        }
        
        }
        
        float val_5 = UnityEngine.Time.unscaledDeltaTime;
        val_5 = this.丙一丑丏丁一且丒业 - val_5;
        this.丙一丑丏丁一且丒业 = (val_5 < 0) ? 0.5f : (val_5);
    }
    private void 丕丕业七丙七丅丈丄()
    {
    
    }
    private void OnDisable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.watchAdvertButton, 丏业丟一东丂东丘丛:  false);
    }
    public SpeedUpButtonControl()
    {
    
    }

}
