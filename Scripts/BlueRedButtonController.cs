using UnityEngine;
public class BlueRedButtonController : MonoBehaviour
{
    // Fields
    public UIButton blueButton;
    public UIButton redButton;
    public bool isBlueAvalible;
    public bool isRedAvalible;
    public int countBlue;
    public int countRed;
    
    // Methods
    private void Start()
    {
        if(GameConnect.丘丐丅丌上与丒丞万() == true)
        {
                return;
        }
        
        if(GameConnect.丅业东业丞七上丞丑() == true)
        {
                return;
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() != false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Update()
    {
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_37;
        val_28 = this;
        this.countBlue = 0;
        this.countRed = 0;
        val_29 = 1152921525488042576;
        val_30 = 0;
        goto label_1;
        label_18:
        val_31 = null;
        val_31 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() == 1)
        {
                int val_28 = this.countBlue;
            val_28 = val_28 + 1;
            this.countBlue = val_28;
        }
        
        val_32 = null;
        val_32 = null;
        val_33 = public NetworkStartTable System.Collections.Generic.List<NetworkStartTable>::get_Item(int index);
        if(Item[0].丘丑丅三丆丑丌且丝() == 2)
        {
                int val_29 = this.countRed;
            val_29 = val_29 + 1;
            this.countRed = val_29;
        }
        
        val_30 = 1;
        label_1:
        val_34 = null;
        val_34 = null;
        val_35 = public System.Int32 System.Collections.Generic.List<NetworkStartTable>::get_Count();
        if(val_30 < Count)
        {
            goto label_18;
        }
        
        this.isBlueAvalible = true;
        this.isRedAvalible = true;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_26;
        }
        
        val_35 = 0;
        int val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丄丁丗丞丏丞世丕业();
        if(this.countBlue >= (((val_8 < 0) ? (val_8 + 1) : (val_8)) >> 1))
        {
            goto label_25;
        }
        
        int val_30 = this.countBlue;
        val_30 = val_30 - this.countRed;
        if(val_30 < 2)
        {
            goto label_26;
        }
        
        label_25:
        this.isBlueAvalible = false;
        label_26:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_34;
        }
        
        val_35 = 0;
        int val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丄丁丗丞丏丞世丕业();
        if(this.countRed >= (((val_12 < 0) ? (val_12 + 1) : (val_12)) >> 1))
        {
            goto label_33;
        }
        
        int val_31 = this.countBlue;
        val_31 = this.countRed - val_31;
        if(val_31 < 2)
        {
            goto label_34;
        }
        
        label_33:
        this.isRedAvalible = false;
        label_34:
        if(((((this.isBlueAvalible == true) ? 1 : 0) ^ this.blueButton) & 1) != 0)
        {
                var val_16 = (this.isBlueAvalible == true) ? 1 : 0;
        }
        
        if(((((this.isRedAvalible == true) ? 1 : 0) ^ this.redButton) & 1) == 0)
        {
                return;
        }
        
        val_28 = ???;
        val_37 = ???;
        var val_19 = (this.isRedAvalible == true) ? 1 : 0;
        val_29 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public BlueRedButtonController()
    {
        this.isBlueAvalible = true;
        this.isRedAvalible = true;
    }

}
