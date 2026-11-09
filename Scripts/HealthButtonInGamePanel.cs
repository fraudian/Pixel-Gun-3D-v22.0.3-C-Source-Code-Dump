using UnityEngine;
public sealed class HealthButtonInGamePanel : MonoBehaviour
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
        this.丕丕业七丙七丅丈丄(丐丈丂世丕丏且丙丐:  false);
    }
    private void 丕丕业七丙七丅丈丄(bool 丐丈丂世丕丏且丙丐 = True)
    {
        if(this.inGameGui.playerMoveC == 0)
        {
                return;
        }
        
        float val_2 = this.inGameGui.playerMoveC.丘七业丒丐世丂丅丒();
        float val_3 = this.inGameGui.playerMoveC.专一丟丏且丆丕丝七();
        if((((val_2 == val_3) ? 1 : 0) ^ this.fullLabel.activeSelf) != false)
        {
                0 = 0;
            this.fullLabel.SetActive(value:  (val_2 == val_3) ? 1 : 0);
        }
        
        if((((val_2 == val_3) ? 1 : 0) ^ this.priceLabel.gameObject.activeSelf) != false)
        {
                return;
        }
        
        this.priceLabel.gameObject.SetActive(value:  (val_2 != val_3) ? 1 : 0);
    }
    private void OnEnable()
    {
        this.丕丕业七丙七丅丈丄(丐丈丂世丕丏且丙丐:  false);
    }
    private void OnClick()
    {
        UnityEngine.GameObject val_11;
        System.Action val_12;
        var val_13;
        var val_14;
        var val_16;
        InGameGUI val_17;
        val_11 = this;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        val_12 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        if(val_12 != false)
        {
                if(this.inGameGui.playerMoveC.丘七业丒丐世丂丅丒() <= 0f)
        {
                return;
        }
        
            val_11 = this.inGameGui.gameObject;
            val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            val_12 = HealthButtonInGamePanel.<>c.<>9__8_0;
            if(val_12 == null)
        {
                System.Action val_7 = null;
            val_12 = val_7;
            val_7 = new System.Action(object:  HealthButtonInGamePanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void HealthButtonInGamePanel.<>c::丛丒专丛世丞丝上丟());
            HealthButtonInGamePanel.<>c.<>9__8_0 = val_12;
        }
        
            val_16 = null;
            val_16 = null;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_11, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  与丂丏丛丞丞丒丟丄.一上业丛丛丁世丝丞, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄), 七丒上且丝业业下七:  val_7, 丝丏丗丄丗与丐丌三:  new System.Action(object:  JoystickController.丗三丄与丂丟丌专东, method:  public System.Void UIJoystick::Reset()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  0);
            return;
        }
        
        if(this.inGameGui.playerMoveC == 0)
        {
                return;
        }
        
        val_17 = this.inGameGui;
        if(this.inGameGui != null)
        {
            goto label_26;
        }
        
        val_17 = this.inGameGui;
        if(val_17 == null)
        {
            goto label_27;
        }
        
        label_26:
        this.inGameGui.playerMoveC.上上丘一丁下丕上与(丙业与丙丗丝不丈东:  this.inGameGui.playerMoveC.专一丟丏且丆丕丝七());
        return;
        label_27:
    }
    public HealthButtonInGamePanel()
    {
    
    }

}
