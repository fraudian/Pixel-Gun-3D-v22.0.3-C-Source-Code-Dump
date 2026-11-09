using UnityEngine;
public class SettingsTabSetting : MonoBehaviour
{
    // Fields
    public UISliderCont view1SensitivitySlider;
    public UISliderCont view3SensitivitySlider;
    public UISliderCont speedUpCameraRotationSlider;
    public UISliderCont speedUpThirdCameraRotationSlider;
    public SettingsToggleButtons invertCameraToggleButtons;
    public SettingsToggleButtons tapticFeedbackToggleButtons;
    public SettingsToggleButtons autoRunToogleButtons;
    public SettingsToggleButtons doubleTapJumpToggleButtons;
    public SettingsToggleButtons disableEnemyGlowToggleButtons;
    public SettingsToggleButtons aimCrosshairTransparencyToggleButtons;
    public SettingsToggleButtons automaticallyPickWeaponToogleButtons;
    public UISliderCont pressure3dTouchSensitivitySlider;
    public SettingsToggleButtons shoot3dTouchToggleButtons;
    public SettingsToggleButtons jump3dTouchToggleButtons;
    public UnityEngine.GameObject trainingButton;
    private UIButton defSettingsBtn;
    
    // Methods
    private void Start()
    {
        this.业丘丒丒丑业下丐丑();
        this.丘上丐世丆丑且丞丒();
    }
    private void OnEnable()
    {
        this.defSettingsBtn.onClick.Clear();
        this.defSettingsBtn.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void SettingsTabSetting::SetDefaultSettings())));
    }
    public void SetDefaultSettings()
    {
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        this.view1SensitivitySlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.不丆丙专业丆丗丗专, 丒丛七丄世业东丝丁:  3f, 七丝东丛东丝且丆不:  19f);
        this.view3SensitivitySlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.丅丗丛万一丛不丌专, 丒丛七丄世业东丝丁:  3f, 七丝东丛东丝且丆不:  19f);
        this.speedUpCameraRotationSlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  1f, 丒丛七丄世业东丝丁:  与丂丏丛丞丞丒丟丄.七丗业丒与不丐丁万, 七丝东丛东丝且丆不:  与丂丏丛丞丞丒丟丄.丅七业七丗七丛丆世);
        this.speedUpThirdCameraRotationSlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  1f, 丒丛七丄世业东丝丁:  与丂丏丛丞丞丒丟丄.七丗业丒与不丐丁万, 七丝东丛东丝且丆不:  与丂丏丛丞丞丒丟丄.丅七业七丗七丛丆世);
        this.invertCameraToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.丅七丐丂万丅七与丝 == true) ? 1 : 0;
        this.tapticFeedbackToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.丙专不业丈与丏东不 == true) ? 1 : 0;
        this.doubleTapJumpToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.下三下丒专东业丈丘 == true) ? 1 : 0;
        this.disableEnemyGlowToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.丗丟丞三丄丞丁下丟 == true) ? 1 : 0;
        this.aimCrosshairTransparencyToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.丛丆世三七丑丅丛丛 == true) ? 1 : 0;
        val_10 = null;
        val_10 = null;
        this.automaticallyPickWeaponToogleButtons.IsChecked = (丟丌丁且且世丈丈丟.丛丅丕丙万丌丙下丄 == true) ? 1 : 0;
        this.pressure3dTouchSensitivitySlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.丝丘丞下丆万丟东东, 丒丛七丄世业东丝丁:  0.3f, 七丝东丛东丝且丆不:  0.98f);
        this.shoot3dTouchToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.丙专不业丈与丏东不 == true) ? 1 : 0;
        this.jump3dTouchToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.丙专不业丈与丏东不 == true) ? 1 : 0;
        SettingsWindowManager.丆丕丝丒不丙且丐丗.CloseDefConfirmWindow();
    }
    private void 业丘丒丒丑业下丐丑()
    {
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.view1SensitivitySlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "view1SensitivitySlider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.view3SensitivitySlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "view3SensitivitySlider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.speedUpCameraRotationSlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "speedUpCameraRotationSlider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.speedUpThirdCameraRotationSlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "speedUpThirdCameraRotationSlider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.invertCameraToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "invertCameraToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.tapticFeedbackToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "tapticFeedbackToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.autoRunToogleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "autoRunToogleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.doubleTapJumpToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "doubleTapJumpToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.disableEnemyGlowToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "disableEnemyGlowToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.aimCrosshairTransparencyToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "aimCrosshairTransparencyToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.automaticallyPickWeaponToogleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "automaticallyPickWeaponToogleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.shoot3dTouchToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "shoot3dTouchToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.jump3dTouchToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "jump3dTouchToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.pressure3dTouchSensitivitySlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabSetting.{0} is null", arg0:  "pressure3dTouchSensitivitySlider"));
    }
    private void 丘上丐世丆丑且丞丒()
    {
        object val_73;
        var val_74;
        UnityEngine.Events.UnityAction<System.Single> val_75;
        float val_76;
        float val_77;
        UnityEngine.Events.UnityAction<System.Single> val_78;
        UnityEngine.Events.UnityAction<System.Single> val_79;
        UnityEngine.Events.UnityAction<System.Single> val_80;
        UnityEngine.Object val_81;
        var val_82;
        var val_83;
        bool val_84;
        UISliderCont val_85;
        UnityEngine.Events.UnityAction<System.Single> val_86;
        val_73 = this;
        val_74 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  this.view1SensitivitySlider)) == false)
        {
            goto label_3;
        }
        
        val_75 = System.Delegate.Combine(a:  this.view1SensitivitySlider.丝丞丁三丐丌不丄丟, b:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabSetting::专丏世丗三丒一丄世(float 丙业与丙丗丝不丈东)));
        if(this.view1SensitivitySlider == null)
        {
            goto label_5;
        }
        
        if(val_75 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_75 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_75 = 0;
        }
        
        label_9:
        this.view1SensitivitySlider.丝丞丁三丐丌不丄丟 = val_75;
        val_76 = 与丂丏丛丞丞丒丟丄.一一上与丗专丗丏丌();
        val_77 = val_76;
        this.view1SensitivitySlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  val_77, 丒丛七丄世业东丝丁:  3f, 七丝东丛东丝且丆不:  19f);
        label_3:
        if((UnityEngine.Object.op_Implicit(exists:  this.view3SensitivitySlider)) == false)
        {
            goto label_15;
        }
        
        val_78 = System.Delegate.Combine(a:  this.view3SensitivitySlider.丝丞丁三丐丌不丄丟, b:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabSetting::世丏世专丒且上专上(float 丙业与丙丗丝不丈东)));
        if(this.view3SensitivitySlider == null)
        {
            goto label_17;
        }
        
        if(val_78 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_78 == null)
        {
            goto label_21;
        }
        
        label_18:
        if(null != null)
        {
                val_78 = 0;
        }
        
        label_21:
        this.view3SensitivitySlider.丝丞丁三丐丌不丄丟 = val_78;
        val_76 = 与丂丏丛丞丞丒丟丄.丒丞丈丗丟丑丘丅与();
        val_77 = val_76;
        this.view3SensitivitySlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  val_77, 丒丛七丄世业东丝丁:  3f, 七丝东丛东丝且丆不:  19f);
        label_15:
        if((UnityEngine.Object.op_Implicit(exists:  this.speedUpCameraRotationSlider)) == false)
        {
            goto label_27;
        }
        
        val_79 = System.Delegate.Combine(a:  this.speedUpCameraRotationSlider.丝丞丁三丐丌不丄丟, b:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabSetting::丙丞丐丕三且不丂丈(float 丙业与丙丗丝不丈东)));
        if(this.speedUpCameraRotationSlider == null)
        {
            goto label_29;
        }
        
        if(val_79 != null)
        {
            goto label_30;
        }
        
        goto label_33;
        label_29:
        if(val_79 == null)
        {
            goto label_33;
        }
        
        label_30:
        if(null != null)
        {
                val_79 = 0;
        }
        
        label_33:
        this.speedUpCameraRotationSlider.丝丞丁三丐丌不丄丟 = val_79;
        val_76 = 与丂丏丛丞丞丒丟丄.七丗业丒与不丐丁万;
        val_77 = 与丂丏丛丞丞丒丟丄.上丌丑丂丕丗上丞丅();
        this.speedUpCameraRotationSlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  val_77, 丒丛七丄世业东丝丁:  val_76, 七丝东丛东丝且丆不:  与丂丏丛丞丞丒丟丄.丅七业七丗七丛丆世);
        label_27:
        if((UnityEngine.Object.op_Implicit(exists:  this.speedUpThirdCameraRotationSlider)) == false)
        {
            goto label_39;
        }
        
        val_80 = System.Delegate.Combine(a:  this.speedUpThirdCameraRotationSlider.丝丞丁三丐丌不丄丟, b:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabSetting::丘一丑丅不业丆东不(float 丙业与丙丗丝不丈东)));
        if(this.speedUpThirdCameraRotationSlider == null)
        {
            goto label_41;
        }
        
        if(val_80 != null)
        {
            goto label_42;
        }
        
        goto label_45;
        label_41:
        if(val_80 == null)
        {
            goto label_45;
        }
        
        label_42:
        if(null != null)
        {
                val_80 = 0;
        }
        
        label_45:
        this.speedUpThirdCameraRotationSlider.丝丞丁三丐丌不丄丟 = val_80;
        val_76 = 与丂丏丛丞丞丒丟丄.七丗业丒与不丐丁万;
        val_77 = 与丂丏丛丞丞丒丟丄.丒丙丕丘七丆三丐丝();
        this.speedUpThirdCameraRotationSlider.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  val_77, 丒丛七丄世业东丝丁:  val_76, 七丝东丛东丝且丆不:  与丂丏丛丞丞丒丟丄.丅七业七丗七丛丆世);
        label_39:
        val_81 = this.invertCameraToggleButtons;
        if((UnityEngine.Object.op_Implicit(exists:  val_81)) != false)
        {
                this.invertCameraToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.世丘与下丂不与丞下().世三丞丅丑丌丈丈一();
            val_81 = this.invertCameraToggleButtons;
            val_81.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::丌丏丈丆东丞丂丐上(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_81 = 0;
        }
        
        if(val_81.丏丐丑专丘丂世丁一() != false)
        {
                if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_67;
        }
        
        }
        
        }
        
            val_82 = 0;
        }
        else
        {
                val_82 = 1;
        }
        
        label_155:
        if((UnityEngine.Object.op_Implicit(exists:  this.tapticFeedbackToggleButtons)) == false)
        {
            goto label_83;
        }
        
        if(FirstPersonControlSharp.IsTapticSupports != false)
        {
                val_83 = 1;
        }
        else
        {
                val_83 = UnityEngine.Application.isEditor;
        }
        
        bool val_30 = val_83;
        UnityEngine.GameObject val_31 = this.tapticFeedbackToggleButtons.gameObject;
        if(val_31 == null)
        {
            goto label_77;
        }
        
        if(val_30 == false)
        {
            goto label_78;
        }
        
        label_84:
        val_31.SetActive(value:  true);
        this.tapticFeedbackToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.业丙三不且业丗丐丂();
        this.tapticFeedbackToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::丝丒丌下丞丙与东丈(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        goto label_83;
        label_77:
        if(val_30 == true)
        {
            goto label_84;
        }
        
        label_78:
        val_31.SetActive(value:  false);
        label_83:
        if((UnityEngine.Object.op_Implicit(exists:  this.doubleTapJumpToggleButtons)) != false)
        {
                this.doubleTapJumpToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.业七丑一丁丅不丌丟();
            this.doubleTapJumpToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::一丂丅专一丛且丐世(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.disableEnemyGlowToggleButtons)) != false)
        {
                this.disableEnemyGlowToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丑不丛丏三丛丁上丈().世三丞丅丑丌丈丈一();
            this.disableEnemyGlowToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::丙丒一丞丑专世业业(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.aimCrosshairTransparencyToggleButtons)) != false)
        {
                this.aimCrosshairTransparencyToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丑与业不丘与丑万丟();
            this.aimCrosshairTransparencyToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::丈一七丆丅东丛东丏(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.automaticallyPickWeaponToogleButtons)) != false)
        {
                this.automaticallyPickWeaponToogleButtons.IsChecked = 丟丌丁且且世丈丈丟.东七丟丕且一丗丅一();
            this.automaticallyPickWeaponToogleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::万丁丌丛与与不丗丁(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != false)
        {
                val_84 = 1;
        }
        else
        {
                val_84 = UnityEngine.Application.isEditor;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.shoot3dTouchToggleButtons)) != false)
        {
                this.shoot3dTouchToggleButtons.gameObject.SetActive(value:  val_84);
            if(val_84 != false)
        {
                this.shoot3dTouchToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌();
            this.shoot3dTouchToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::不丆三三专与三丐丐(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.jump3dTouchToggleButtons)) != false)
        {
                this.jump3dTouchToggleButtons.gameObject.SetActive(value:  val_84);
            if(val_84 != false)
        {
                this.jump3dTouchToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆();
            this.jump3dTouchToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabSetting::丌三上万万上万与丅(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)));
        }
        
        }
        
        val_85 = this.pressure3dTouchSensitivitySlider;
        if((UnityEngine.Object.op_Implicit(exists:  val_85)) == false)
        {
                return;
        }
        
        val_85 = this.pressure3dTouchSensitivitySlider.gameObject;
        val_85.SetActive(value:  val_84);
        if(val_84 == false)
        {
                return;
        }
        
        val_74 = 1152921504849817600;
        UnityEngine.Events.UnityAction<System.Single> val_66 = null;
        val_85 = val_66;
        val_66 = new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabSetting::业且丗丞丟丛丒丏丌(float 丙业与丙丗丝不丈东));
        val_86 = System.Delegate.Combine(a:  this.pressure3dTouchSensitivitySlider.丝丞丁三丐丌不丄丟, b:  val_66);
        if(this.pressure3dTouchSensitivitySlider == null)
        {
            goto label_145;
        }
        
        if(val_86 != null)
        {
            goto label_146;
        }
        
        goto label_149;
        label_145:
        if(val_86 == null)
        {
            goto label_149;
        }
        
        label_146:
        if(null != null)
        {
                val_86 = 0;
        }
        
        label_149:
        this.pressure3dTouchSensitivitySlider.丝丞丁三丐丌不丄丟 = val_86;
        val_73 = this.pressure3dTouchSensitivitySlider;
        val_76 = 与丂丏丛丞丞丒丟丄.丛丗丅丐丌且与丁与();
        val_73.丘上丐世丆丑且丞丒(丛丁三世世丆七不业:  val_76, 丒丛七丄世业东丝丁:  0.3f, 七丝东丛东丝且丆不:  0.98f);
        return;
        label_67:
        var val_70 = (~GameConnect.且丘丄丛下丆丟万丕()) & 1;
        goto label_155;
    }
    private void 专丏世丗三丒一丄世(float 丙业与丙丗丝不丈东)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New sensitivity FPS: "("New sensitivity FPS: ") + 丙业与丙丗丝不丈东);
        }
        
        与丂丏丛丞丞丒丟丄.且丟不业丘东丄丘世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 世丏世专丒且上专上(float 丙业与丙丗丝不丈东)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New sensitivity BR: "("New sensitivity BR: ") + 丙业与丙丗丝不丈东);
        }
        
        与丂丏丛丞丞丒丟丄.丒三丁万丘丘丗东丕(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 丙丞丐丕三且不丂丈(float 丙业与丙丗丝不丈东)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New speed up cam: "("New speed up cam: ") + 丙业与丙丗丝不丈东);
        }
        
        与丂丏丛丞丞丒丟丄.东丏专三万业万与专(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 丘一丑丅不业丆东不(float 丙业与丙丗丝不丈东)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New 3rd speed up cam: "("New 3rd speed up cam: ") + 丙业与丙丗丝不丈东);
        }
        
        与丂丏丛丞丞丒丟丄.丁不与丗丌世丈七丌(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 丌丏丈丆东丞丂丐上(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        丒七丞丞世一丒丈且<System.Boolean> val_10;
        bool val_2 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Invert Camera] button clicked: "("[Invert Camera] button clicked: ") + val_2.ToString());
        }
        
        val_10 = 1152921505171275776;
        if((丒七丞丞世一丒丈且<System.Boolean>.万丌专丅丘丘丟万东(一不丝丟世业丑丙一:  与丂丏丛丞丞丒丟丄.世丘与下丂不与丞下(), 丘丑丛丕下丈世下丂:  val_2)) == false)
        {
                return;
        }
        
        string val_8 = val_2.ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "invertCamera", 丙业与丙丗丝不丈东:  val_8);
        val_10 = 丒七丞丞世一丒丈且<System.Boolean>.万丒丌丕万丏不丈世(丙业与丙丗丝不丈东:  val_2);
        与丂丏丛丞丞丒丟丄.丒丁丌丗下东丂丐七(丙业与丙丗丝不丈东:  val_10);
    }
    private void 丝丒丌下丞丙与东丈(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        bool val_7 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        bool val_2 = val_7;
        if(与丂丏丛丞丞丒丟丄.业丙三不且业丗丐丂() ^ val_7 == false)
        {
                return;
        }
        
        string val_5 = val_2.ToString();
        val_5.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "vibro", 丙业与丙丗丝不丈东:  val_5);
        val_7 = val_2;
        与丂丏丛丞丞丒丟丄.丘丒丘专丏东丆业丛(丙业与丙丗丝不丈东:  (val_7 == true) ? 1 : 0);
    }
    private void 一丂丅专一丛且丐世(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        bool val_10;
        bool val_2 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Double tap jump toggle button clicked: "("Double tap jump toggle button clicked: ") + val_2.ToString());
        }
        
        val_10 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.业七丑一丁丅不丌丟() == val_2)
        {
                return;
        }
        
        string val_8 = val_2.ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "doubleTouchJump", 丙业与丙丗丝不丈东:  val_8);
        val_10 = val_2;
        与丂丏丛丞丞丒丟丄.丞丑丏丙丑不丁丗一(丙业与丙丗丝不丈东:  (val_10 == true) ? 1 : 0);
    }
    private void 丙丒一丞丑专世业业(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        丒七丞丞世一丒丈且<System.Boolean> val_10;
        bool val_2 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Disable enemy glow toggle button clicked: "("Disable enemy glow toggle button clicked: ") + val_2.ToString());
        }
        
        val_10 = 1152921505171275776;
        if((丒七丞丞世一丒丈且<System.Boolean>.万丌专丅丘丘丟万东(一不丝丟世业丑丙一:  与丂丏丛丞丞丒丟丄.丑不丛丏三丛丁上丈(), 丘丑丛丕下丈世下丂:  val_2)) == false)
        {
                return;
        }
        
        string val_8 = val_2.ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "disableEnemyGlow", 丙业与丙丗丝不丈东:  val_8);
        val_10 = 丒七丞丞世一丒丈且<System.Boolean>.万丒丌丕万丏不丈世(丙业与丙丗丝不丈东:  val_2);
        与丂丏丛丞丞丒丟丄.丌万专丐丒万东丄丞(丙业与丙丗丝不丈东:  val_10);
    }
    private void 丈一七丆丅东丛东丏(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        bool val_10;
        bool val_2 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Sight transparency toggle button clicked: "("Sight transparency toggle button clicked: ") + val_2.ToString());
        }
        
        val_10 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丑与业不丘与丑万丟() == val_2)
        {
                return;
        }
        
        string val_8 = val_2.ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sightTransparency", 丙业与丙丗丝不丈东:  val_8);
        val_10 = val_2;
        与丂丏丛丞丞丒丟丄.丄与丞与丕不丕丗丗(丙业与丙丗丝不丈东:  (val_10 == true) ? 1 : 0);
    }
    private void 万丁丌丛与与不丗丁(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        bool val_5 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        丟丌丁且且世丈丈丟.丌三丑丛上万丄丗丝(丙业与丙丗丝不丈东:  val_5 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟());
        if(val_5 == false)
        {
                return;
        }
        
        val_5 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 744];
        val_5 = InGameGUI.丙丞专丌丁丞与不丐.丘丏丛丂丅丂世上丒;
        if(val_5 == 0)
        {
                return;
        }
        
        InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.东丐丟丂丝上丞丁丅();
    }
    private void 不丆三三专与三丐丐(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        bool val_10;
        bool val_2 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "3D touche button clicked: "("3D touche button clicked: ") + val_2.ToString());
        }
        
        val_10 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌() == val_2)
        {
                return;
        }
        
        string val_8 = val_2.ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "shoot3DTouch", 丙业与丙丗丝不丈东:  val_8);
        val_10 = val_2;
        与丂丏丛丞丞丒丟丄.下一上世专不丙三三(丙业与丙丗丝不丈东:  (val_10 == true) ? 1 : 0);
    }
    private void 丌三上万万上万与丅(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        bool val_10;
        bool val_2 = 七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "3D touche button clicked: "("3D touche button clicked: ") + val_2.ToString());
        }
        
        val_10 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() == val_2)
        {
                return;
        }
        
        string val_8 = val_2.ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "jump3DTouch", 丙业与丙丗丝不丈东:  val_8);
        val_10 = val_2;
        与丂丏丛丞丞丒丟丄.丁万不丝丂丁与丌丑(丙业与丙丗丝不丈东:  (val_10 == true) ? 1 : 0);
    }
    private void 业且丗丞丟丛丒丏丌(float 丙业与丙丗丝不丈东)
    {
        object val_5;
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                val_5 = "New pressure: "("New pressure: ") + 丙业与丙丗丝不丈东;
            UnityEngine.Debug.Log(message:  val_5);
        }
        
        与丂丏丛丞丞丒丟丄.三丈丐专丄下业丞丅(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 与东丕东且丑与丁丐(string 丌丁不丙丑丑丝丆丌, string 丙业与丙丗丝不丈东)
    {
        0.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  丌丁不丙丑丑丝丆丌, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public SettingsTabSetting()
    {
    
    }

}
