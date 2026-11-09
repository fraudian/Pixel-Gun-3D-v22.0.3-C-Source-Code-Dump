using UnityEngine;
public class UILocalize : MonoBehaviour
{
    // Fields
    public string key;
    private bool 不世丌丝且三上丏丌;
    
    // Properties
    set; }
    
    // Methods
    public void set_value(string 丙业与丙丗丝不丈东)
    {
        var val_17;
        UnityEngine.Object val_18;
        var val_19;
        if((System.String.IsNullOrEmpty(value:  丙业与丙丗丝不丈东)) != false)
        {
                return;
        }
        
        if((this.GetComponent<UIWidget>()) == null)
        {
            goto label_2;
        }
        
        val_17 = 0;
        goto label_4;
        label_2:
        val_18 = 0;
        val_17 = 0;
        val_19 = 0;
        goto label_5;
        label_4:
        val_19 = 0;
        val_18 = ;
        label_5:
        if( == 0)
        {
            goto label_10;
        }
        
        UIInput val_8 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIInput>(丝三丁东丈丒世丅业:  gameObject, 丕丗丆丕丈丑东丆丈:  0);
        if((val_8 == 0) || (val_8.label != ))
        {
            goto label_20;
        }
        
        val_8.defaultText = 丙业与丙丗丝不丈东;
        return;
        label_10:
        if( == 0)
        {
                return;
        }
        
        UIButton val_13 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIButton>(丝三丁东丈丒世丅业:  gameObject, 丕丗丆丕丈丑东丆丈:  0);
        if(val_13 != 0)
        {
                if(val_18 == gameObject)
        {
                val_13.normalSprite = 丙业与丙丗丝不丈东;
        }
        
        }
        
        spriteName = 丙业与丙丗丝不丈东;
        goto (UIWidget.__il2cppRuntimeField_typeHierarchy + (UISprite.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 856;
        label_20:
        val_18.text = 丙业与丙丗丝不丈东;
    }
    private void OnEnable()
    {
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        this.丅万且下丄丗万丐且();
    }
    private void Start()
    {
        this.不世丌丝且三上丏丌 = true;
        this.丅万且下丄丗万丐且();
    }
    private void 丅万且下丄丗万丐且()
    {
        if((System.String.IsNullOrEmpty(value:  this.key)) != false)
        {
                if((this.GetComponent<UILabel>()) != 0)
        {
                this.key = val_2.mText;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.key)) != false)
        {
                return;
        }
        
        this.value = 丛丝丝丈丝丞丒业丝.丐下下丅与上东丙丑(下上丐丆丝丟丝丒不:  this.key);
    }
    public UILocalize()
    {
    
    }

}
