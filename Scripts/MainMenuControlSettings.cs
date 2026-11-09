using UnityEngine;
public class MainMenuControlSettings : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject savePosJoystikButton;
    public UnityEngine.GameObject defaultPosJoystikButton;
    public UnityEngine.GameObject cancelPosJoystikButton;
    public UnityEngine.GameObject zoomButton;
    public UnityEngine.GameObject reloadButton;
    public UnityEngine.GameObject jumpButton;
    public UnityEngine.GameObject fireButton;
    public UnityEngine.GameObject joystick;
    public UnityEngine.GameObject grenadeButton;
    public UnityEngine.GameObject fireButtonInJoystick;
    public UnityEngine.GameObject gadget2Button;
    public UnityEngine.GameObject gadget3Button;
    public UnityEngine.GameObject carButton;
    public UnityEngine.GameObject vehicleSpawnButton;
    public UnityEngine.GameObject crouchButton;
    public UnityEngine.GameObject autorunButton;
    public UnityEngine.GameObject lootButton;
    public UnityEngine.GameObject weaponsList;
    public UIAnchor BottomLeftControlsAnchor;
    public UIAnchor BottomRightControlsAnchor;
    public UnityEngine.Transform BottomLeft;
    public UnityEngine.Transform TopLeft;
    public UnityEngine.Transform BottomRight;
    public UnityEngine.Transform TopRight;
    public UIAnchor HandSwapAnchor;
    public UnityEngine.Transform HandSwapTransform;
    public UnityEngine.Transform CarControlSwapTransform;
    public UITexture Gadget0ButtonImageContainer;
    public UnityEngine.GameObject MapObject;
    public UnityEngine.Texture GrenadeButtonTexture;
    public UnityEngine.Texture CrouchButtonImageTexture;
    public UnityEngine.Texture moduleAbilityTexture;
    public SettingsToggleButtons vehiclePedalsToggleButtons;
    public SettingsToggleButtons leftHandedToggleButtons;
    public UnityEngine.GameObject tapPanelInSettings;
    public UnityEngine.GameObject swipePanelInSettings;
    private static bool 丅丛东专丅丂丞且丛;
    
    // Methods
    private void Start()
    {
        object val_13;
        System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_14;
        val_13 = this;
        if(this.vehiclePedalsToggleButtons != 0)
        {
                this.vehiclePedalsToggleButtons.IsChecked = 丟丌丁且且世丈丈丟.丙丘下丝一下丝丆不();
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_4 = null;
            val_14 = val_4;
            val_4 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void MainMenuControlSettings::丒丑万三丐丕丈东与(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且));
            this.vehiclePedalsToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        if(this.leftHandedToggleButtons != 0)
        {
                this.leftHandedToggleButtons.IsChecked = (~丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三()) & 1;
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_8 = null;
            val_14 = val_8;
            val_8 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void MainMenuControlSettings::东丆业丒丁丞丗丈丏(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑));
            this.leftHandedToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        if(this.cancelPosJoystikButton == 0)
        {
                return;
        }
        
        val_13 = this.cancelPosJoystikButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  0, method:  static System.Void MainMenuControlSettings::七丒七丙一七丈丆丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丒丑万三丐丕丈东与(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        丟丌丁且且世丈丈丟.丗丝七专丅丒丁丈丆(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
    }
    private void 业丑世丏丆丆下丁万()
    {
        MainMenuControlSettings.丅丛东专丅丂丞且丛 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        this.leftHandedToggleButtons.IsChecked = (~丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三()) & 1;
    }
    internal static void 七丒七丙一七丈丆丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        if(PauseNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丙丗专东丂丁一一丛(丙业与丙丗丝不丈东:  (MainMenuControlSettings.丅丛东专丅丂丞且丛 == true) ? 1 : 0);
    }
    private void 东丆业丒丁丞丗丈丏(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 七世业丌丛丞世丕丑)
    {
        PauseNGUIController val_13;
        var val_14;
        var val_15;
        var val_13 = ~七世业丌丛丞世丕丑.且丂丅丁与丟丒丛丟();
        val_13 = val_13 & 1;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Left Handed] button clicked: "("[Left Handed] button clicked: ") + val_13.ToString());
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.丑下丗专丐丑丅专丑(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 下上丐丆丝丟丝丒不:  "leftHanded", 丙业与丙丗丝不丈东:  val_13.ToString());
        val_13 = 1152921505207164928;
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == val_13)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丙丗专东丂丁一一丛(丙业与丙丗丝不丈东:  (val_13 != 0) ? 1 : 0);
        val_14 = null;
        val_14 = null;
        val_13 = PauseNGUIController.丄丞丁丈与业上丞丟;
        if(val_13 == null)
        {
                val_15 = null;
            val_15 = null;
            val_13 = MainMenuController.丄丞丁丈与业上丞丟;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) != false)
        {
                val_13.不丐三且上专丄丏丟();
        }
        
        ControlSizeController val_11 = ControlSizeController.丑七不且上丗丁一世();
        if(val_11 != null)
        {
                val_11.CheckAllButtonsForCollision();
        }
        
        if(val_13 != 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Left-handed Layout Enabled");
    }
    private void OnEnable()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.GameObject val_3 = this.swipePanelInSettings.transform.parent.gameObject;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_6;
        }
        
        val_20 = (~丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上()) & 1;
        if(val_3 != null)
        {
            goto label_11;
        }
        
        goto label_10;
        label_6:
        val_20 = 1;
        if(val_3 != null)
        {
            goto label_11;
        }
        
        label_10:
        label_11:
        val_3.SetActive(value:  true);
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_14;
        }
        
        val_21 = 丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上();
        if(this.swipePanelInSettings != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_14:
        val_21 = 0;
        if(this.swipePanelInSettings != null)
        {
            goto label_19;
        }
        
        label_18:
        label_19:
        this.swipePanelInSettings.SetActive(value:  false);
        this.tapPanelInSettings.SetActive(value:  (~丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上()) & 1);
        val_22 = null;
        val_22 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
        if((UnityEngine.Object.op_Implicit(exists:  ControlSizeController.丑七不且上丗丁一世())) != false)
        {
                ControlSizeController.丑七不且上丗丁一世().CheckAllButtonsForCollision();
        }
        
        val_23 = null;
        val_23 = null;
        if(PauseNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(this.leftHandedToggleButtons != 0)
        {
                bool val_17 = UnityEngine.Object.op_Inequality(x:  this.leftHandedToggleButtons.GetComponent<UIButton>(), y:  0);
        }
        
        }
        
        this.业丑世丏丆丆下丁万();
    }
    public MainMenuControlSettings()
    {
    
    }

}
