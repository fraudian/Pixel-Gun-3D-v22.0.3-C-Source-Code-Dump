using UnityEngine;
public class UIImageButton : MonoBehaviour
{
    // Fields
    public UISprite target;
    public string normalSprite;
    public string hoverSprite;
    public string pressedSprite;
    public string disabledSprite;
    public bool pixelSnap;
    
    // Properties
    public bool 丆丛丆丞下丅丂且丝 { get; set; }
    
    // Methods
    public bool get_isEnabled()
    {
        UnityEngine.Collider val_2 = this.gameObject.GetComponent<UnityEngine.Collider>();
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
        {
                return false;
        }
        
        if(val_2 != null)
        {
                return val_2.enabled;
        }
        
        return val_2.enabled;
    }
    public void set_isEnabled(bool 丙业与丙丗丝不丈东)
    {
        UnityEngine.Collider val_2 = this.gameObject.GetComponent<UnityEngine.Collider>();
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
        {
                return;
        }
        
        if(val_2.enabled ^ 丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        val_2.enabled = 丙业与丙丗丝不丈东;
        this.丗业七丈丝世专世丂();
    }
    private void OnEnable()
    {
        if(this.target == 0)
        {
                this.target = this.GetComponentInChildren<UISprite>();
        }
        
        this.丗业七丈丝世专世丂();
    }
    private void OnValidate()
    {
        if(this.target == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.normalSprite)) != false)
        {
                this.normalSprite = this.target.spriteName;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.hoverSprite)) != false)
        {
                this.hoverSprite = this.target.spriteName;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.pressedSprite)) != false)
        {
                this.pressedSprite = this.target.spriteName;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.disabledSprite)) == false)
        {
                return;
        }
        
        this.disabledSprite = this.target.spriteName;
    }
    private void 丗业七丈丝世专世丂()
    {
        string val_6;
        if(this.target == 0)
        {
                return;
        }
        
        if(this.isEnabled != false)
        {
                val_6 = mem[val_4 != true ? this.hoverSprite : this.normalSprite];
            val_6 = ((UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject)) != true) ? this.hoverSprite : this.normalSprite;
        }
        else
        {
                val_6 = this.disabledSprite;
        }
        
        this.与专丟业下且丕不丈(与丄丈丘丟丕丏丐丁:  val_6);
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        if(this.isEnabled == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        this.与专丟业下且丕不丈(与丄丈丘丟丕丏丐丁:  (丟丆丕且丆丈丂丌丘 != true) ? this.hoverSprite : this.normalSprite);
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(万东丂丒且丅丛丑丕 != false)
        {
                this.与专丟业下且丕不丈(与丄丈丘丟丕丏丐丁:  this.pressedSprite);
            return;
        }
        
        this.丗业七丈丝世专世丂();
    }
    private void 与专丟业下且丕不丈(string 与丄丈丘丟丕丏丐丁)
    {
        if(this.target.atlas == 0)
        {
                return;
        }
        
        if((this.target.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  与丄丈丘丟丕丏丐丁)) == null)
        {
                return;
        }
        
        this.target.spriteName = 与丄丈丘丟丕丏丐丁;
        if(this.pixelSnap == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(UISprite).__il2cppRuntimeField_358;
    }
    public UIImageButton()
    {
        this.pixelSnap = true;
    }

}
