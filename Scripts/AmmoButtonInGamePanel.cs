using UnityEngine;
public sealed class AmmoButtonInGamePanel : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject fullLabel;
    public UIButton myButton;
    public UILabel priceLabel;
    public InGameGUI inGameGui;
    
    // Methods
    private void Start()
    {
        null = null;
        this.priceLabel.text = ToString();
    }
    private void Update()
    {
        this.丕丕业七丙七丅丈丄(丐丈丂世丕丏且丙丐:  true);
    }
    private void 丕丕业七丙七丅丈丄(bool 丐丈丂世丕丏且丙丐 = True)
    {
        var val_12;
        var val_13;
        val_12 = null;
        val_12 = null;
        三丈丟与丏丘丈丐万 val_3 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if(val_3 != null)
        {
                val_13 = val_3.东东丄丅丐一丙一业();
        }
        else
        {
                val_13 = val_3.东东丄丅丐一丙一业();
        }
        
        int val_6 = val_3.三丐三丞丘丕不丒专.世与不万丆丒丂丁丒();
        if((((((val_13 == val_6) ? 1 : 0) ^ this.myButton) & 1) != 0) && (丐丈丂世丕丏且丙丐 != false))
        {
                return;
        }
        
        this.fullLabel.SetActive(value:  (val_13 == val_6) ? 1 : 0);
        this.priceLabel.gameObject.SetActive(value:  (val_13 != val_6) ? 1 : 0);
    }
    private void OnEnable()
    {
        this.丕丕业七丙七丅丈丄(丐丈丂世丕丏且丙丐:  false);
    }
    private void OnClick()
    {
        var val_12;
        var val_13;
        System.Action val_15;
        var val_16;
        var val_17;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                val_12 = null;
            val_12 = null;
            val_13 = null;
            val_13 = null;
            val_15 = AmmoButtonInGamePanel.<>c.<>9__8_0;
            if(val_15 == null)
        {
                System.Action val_6 = null;
            val_15 = val_6;
            val_6 = new System.Action(object:  AmmoButtonInGamePanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AmmoButtonInGamePanel.<>c::丛丒专丛世丞丝上丟());
            AmmoButtonInGamePanel.<>c.<>9__8_0 = val_15;
        }
        
            val_16 = null;
            val_16 = null;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.inGameGui.gameObject, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  与丂丏丛丞丞丒丟丄.丆上丁万丆不丈业丈, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄), 七丒上且丝业业下七:  val_6, 丝丏丗丄丗与丐丌三:  new System.Action(object:  JoystickController.丗三丄与丂丟丌专东, method:  public System.Void UIJoystick::Reset()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  96);
            return;
        }
        
        val_17 = null;
        val_17 = null;
        WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()].上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_10.三丐三丞丘丕不丒专.世与不万丆丒丂丁丒());
    }
    public AmmoButtonInGamePanel()
    {
    
    }

}
