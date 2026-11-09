using UnityEngine;
public class InGameGUIPart_BattleRoyale : InGameGUIPartContainer
{
    // Fields
    private UnityEngine.GameObject placePanel;
    private UILabel placeLabel;
    private UnityEngine.GameObject royalKillerInfoPanel;
    private UILabel royalKillerNameLabel;
    private UILabel royalKillerClanLabel;
    private UITexture royalKillerClanLogo;
    private UILabel blinkGetOutLabelLabel;
    private UILabel blinkHitByVehicleLabel;
    internal PopUpWeaponWindow popUpWeaponWindow;
    private UnityEngine.GameObject allSecretsHolder;
    private UnityEngine.GameObject foundSecretHolder;
    public UILabel secretsCountLabel;
    private UnityEngine.GameObject mapLegend;
    private float 一丞七世丆东丟七不;
    
    // Properties
    private bool 丄丗下不丙万专丆一 { get; }
    private bool 丂丏丁丝业七丛专与 { get; }
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丘丏丛丂丅丂世上丒 = this;
    }
    public void ShowPlaceOnDeath(int 且丒丛与丞世丙丕丌, bool 与下与一丁丘与丘丆)
    {
        string val_10;
        string val_11;
        var val_13;
        this.placePanel.SetActive(value:  true);
        if(与下与一丁丘与丘丆 != false)
        {
                val_10 = System.String.Format(format:  "[00DFFFFF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5644"));
            val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5723");
            val_13 = null;
            int val_4 = 且丒丛与丞世丙丕丌 + 1;
        }
        else
        {
                val_10 = System.String.Format(format:  "[00DFFFFF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6136"));
            val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5723");
            val_13 = null;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.placeLabel, 丕丗丘丑丛与丑业丒:  val_10 + " " + System.String.Format(format:  val_11, arg0:  且丒丛与丞世丙丕丌)(System.String.Format(format:  val_11, arg0:  且丒丛与丞世丙丕丌)));
    }
    internal void 且业丆丛且世与丑丑(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        var val_17;
        UITexture val_18;
        val_17 = 丝丞丛七且一丅丐丄;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.royalKillerInfoPanel, 丏业丟一东丂东丘丛:  丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丝丞丛七且一丅丐丄.丛三三与丁丘丄丑下));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.royalKillerNameLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FF9900FF]{0}[-]", arg0:  丝丞丛七且一丅丐丄.丛三三与丁丘丄丑下));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.royalKillerClanLabel, 丏业丟一东丂东丘丛:  丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丝丞丛七且一丅丐丄.专下不丘丘丝丅七三));
        val_18 = this.royalKillerClanLogo;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丝丞丛七且一丅丐丄.专下不丘丘丝丅七三));
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丝丞丛七且一丅丐丄.专下不丘丘丝丅七三)) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.royalKillerClanLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFED00FF]{0}[-]", arg0:  丝丞丛七且一丅丐丄.专下不丘丘丝丅七三));
        val_17 = ???;
        val_18 = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  21)) == false)
        {
                return;
        }
        
        this.ShowAllSecretsMessage();
    }
    private void Start()
    {
        this.丞丐不丅专丙丛世丝();
    }
    private bool 丈东丅丐专丁万丐万()
    {
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗 == 0)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.secretsCountLabel, y:  0);
    }
    private bool 万专丞丝不丆业丈专()
    {
        return this.丈东丅丐专丁万丐万();
    }
    public void ShowMapLegend(bool 丛与丙丒丒下丌丟且)
    {
        bool val_2 = 丛与丙丒丒下丌丟且;
        val_2 = this.丈东丅丐专丁万丐万() & val_2;
        丛与丙丒丒下丌丟且 = val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapLegend, 丏业丟一东丂东丘丛:  丛与丙丒丒下丌丟且);
    }
    internal void 丞丐不丅专丙丛世丝()
    {
        if(this.丈东丅丐专丁万丐万() == false)
        {
                return;
        }
        
        this = this.secretsCountLabel;
        this.text = System.String.Format(format:  "{0}/{1}", arg0:  SecretsFreemodeController.丆丕丝丒不丙且丐丗.GetCurrentSecretCount(), arg1:  SecretsFreemodeController.丆丕丝丒不丙且丐丗.业上一七丘丏丝下丈());
    }
    public void ShowAllSecretsMessage()
    {
        this.allSecretsHolder.SetActive(value:  true);
    }
    public void ShowCurrentSecretsMessage()
    {
        this.foundSecretHolder.SetActive(value:  true);
    }
    private void Update()
    {
        InGameGUI val_19;
        var val_20;
        var val_21;
        var val_22;
        UILabel val_23;
        var val_24;
        var val_25;
        InGameGUI val_26;
        InGameGUI val_27;
        val_19 = this;
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_13;
        }
        
        val_21 = null;
        val_21 = null;
        val_22 = null;
        val_22 = null;
        if(S0 <= 0f)
        {
            goto label_21;
        }
        
        label_13:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.blinkGetOutLabelLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        val_23 = 0;
        label_62:
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_35;
        }
        
        val_25 = null;
        val_25 = null;
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.一丞七世丆东丟七不 + val_4;
        this.一丞七世丆东丟七不 = val_4;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.blinkHitByVehicleLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_26 = InGameGUI.丙丞专丌丁丞与不丐;
        if(InGameGUI.丙丞专丌丁丞与不丐 != null)
        {
            goto label_39;
        }
        
        val_26 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_26 == null)
        {
            goto label_57;
        }
        
        label_39:
        float val_19 = InGameGUI.丙丞专丌丁丞与不丐.丂丕丒丑不三丑丁丒;
        UnityEngine.Color val_6 = this.blinkHitByVehicleLabel.color;
        val_23 = this.blinkHitByVehicleLabel;
        val_19 = this.一丞七世丆东丟七不 / val_19;
        UnityEngine.Color val_7 = val_23.color;
        UnityEngine.Color val_8 = this.blinkHitByVehicleLabel.color;
        float val_20 = 1f;
        val_20 = val_20 - val_19;
        float val_10 = ((val_19 < 0) ? (val_19) : (val_20)) + ((val_19 < 0) ? (val_19) : (val_20));
        this.blinkHitByVehicleLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        goto label_45;
        label_35:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.blinkHitByVehicleLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        if((val_23 & 1) == 0)
        {
            goto label_49;
        }
        
        label_45:
        val_19 = InGameGUI.丙丞专丌丁丞与不丐;
        if(null != 0)
        {
                return;
        }
        
        val_19.PlayLowResourceBeep(丌丒丝东丌下丕丁丅:  1);
        return;
        label_49:
        this.一丞七世丆东丟七不 = 0f;
        return;
        label_21:
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = this.一丞七世丆东丟七不 + val_12;
        this.一丞七世丆东丟七不 = val_12;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.blinkGetOutLabelLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_27 = InGameGUI.丙丞专丌丁丞与不丐;
        if(InGameGUI.丙丞专丌丁丞与不丐 != null)
        {
            goto label_56;
        }
        
        val_27 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_27 == null)
        {
            goto label_57;
        }
        
        label_56:
        float val_21 = InGameGUI.丙丞专丌丁丞与不丐.丂丕丒丑不三丑丁丒;
        UnityEngine.Color val_14 = this.blinkGetOutLabelLabel.color;
        val_21 = this.一丞七世丆东丟七不 / val_21;
        UnityEngine.Color val_15 = this.blinkGetOutLabelLabel.color;
        UnityEngine.Color val_16 = this.blinkGetOutLabelLabel.color;
        float val_22 = 1f;
        val_22 = val_22 - val_21;
        float val_18 = ((val_21 < 0) ? (val_21) : (val_22)) + ((val_21 < 0) ? (val_21) : (val_22));
        this.blinkGetOutLabelLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        goto label_62;
        label_57:
    }
    public InGameGUIPart_BattleRoyale()
    {
    
    }

}
