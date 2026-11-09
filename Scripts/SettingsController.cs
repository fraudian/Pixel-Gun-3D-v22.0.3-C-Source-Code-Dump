using UnityEngine;
internal sealed class SettingsController : MonoBehaviour
{
    // Fields
    private const int 丄丟丞一丙七上世丐 = 5;
    private const string 丛丑下专万丒丟上与 = "Key_5709";
    private const string 七丏丄丑丗丄丏丏丙 = "Key_5710";
    internal const string 与丏丟丗丒丕下丆丗 = "SettingsPanelGamepadPS4";
    internal const string 丐丆丈丅丄丐丘万丂 = "SettingsPanelGamepadXBox";
    private const string 丈丒七丗丑一丈丘业 = "[c][ffffff]{0}[-][/c]";
    private const string 丞三丙丄丙三丌丝与 = "[c][60ff00]{0}[-][/c]";
    internal const int 丙丁丁丕丙丆东与丑 = 6;
    internal const int 丐丕业东丞丏丙不丆 = 19;
    internal const float 丌丂世下世丐丕丟丈 = 0.3;
    internal const float 且丄丅上不与丟丗丒 = 0.98;
    private bool 丅丝丁丑且丁下丆丄;
    private CategoryButtonsController _tabButtonsController;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private float 丛与丝丐三丝丟一东;
    private float 丁东七丆丛丑丘丙东;
    private float 下业丘万不专业丈丟;
    private float 专专丟万不万丞丁七;
    public UIButton backButton;
    public SettingsToggleButtons chatToggleButtons;
    public UIButton controlsButtonBR;
    public UIButton controlsButtonFPS;
    public UIButton controlsButtonFP;
    public UnityEngine.GameObject controlsSettings;
    public UITable controlsTable;
    public int currentAudioIndex;
    public SettingsToggleButtons fps60ToggleButtons;
    public SettingsToggleButtons battleEmojiButtons;
    public UnityEngine.Texture googlePlayServicesTexture;
    public SettingsToggleButtons hideJumpAndShootButtons;
    public SettingsToggleButtons invertCameraToggleButtons;
    public SettingsToggleButtons inviteLocalToggleButton;
    public SettingsToggleButtons inviteRemoteToogleButton;
    public SettingsToggleButtons jump3dTouchToggleButtons;
    public SettingsToggleButtons leftHandedToggleButtons;
    public UnityEngine.GameObject mainPanel;
    private System.Collections.Generic.List<SettingsController.MusicItem> musicList;
    public UILabel musicName;
    public SettingsToggleButtons musicToggleButtons;
    public UISlider musicVolumeSlider;
    public UIButton gamepadSettingsBtn;
    public UIButton nextAudio;
    public UISlider pressureSensitivitySlider;
    public UIButton prevAudio;
    public MainMenuHeroCamera rotateCamera;
    public UnityEngine.GameObject secondsFireButtons;
    public UISlider sensitivitySliderBR;
    public UILabel sensitivitySliderBRLabel;
    public UISlider sensitivitySliderFPS;
    public UILabel sensitivitySliderFPSLabel;
    public SettingsToggleButtons tapticFeedbackToggleButtons;
    public SettingsToggleButtons shoot3dTouchToggleButtons;
    public UIButton signOutButton;
    public SettingsToggleButtons soundToggleButtons;
    public SettingsToggleButtons switchingWeaponsToggleButtons;
    public UIButton syncButton;
    public UnityEngine.GameObject tapPanel;
    public UnityEngine.GameObject swipePanel;
    public SettingsToggleButtons autoTargettingButton;
    public SettingsToggleButtons autoFireButton;
    public SettingsToggleButtons autoPickUpToggleButtons;
    public Rilisoft.ButtonHandler socialButton;
    private UnityEngine.Vector3 丕丝一三且丗丑丂下;
    private UnityEngine.Vector3 jumpAndShootButtonsWithoutAutofirePosOffset;
    public UnityEngine.GameObject useAutoShootButtons;
    public SettingsToggleButtons vehiclePedalsToggleButtons;
    public UnityEngine.GameObject facebookConnectedSettings;
    public UnityEngine.GameObject facebookDisconnectedSettings;
    public UnityEngine.GameObject facebookConnectSettings;
    public UnityEngine.GameObject facebookConnectSettingsLabel;
    public UnityEngine.GameObject twitterConnectedSettings;
    public UnityEngine.GameObject twitterDisconnectedSettings;
    public UnityEngine.GameObject twitterConnectSettings;
    public UnityEngine.GameObject twitterConnectSettingsLabel;
    public MainMenuFreePanel freePanel;
    private UIButton 三丑丕丁丗东万丗丌;
    private static System.Action 下三丟不丞丏世丗丑;
    internal static bool 丙万丞丄与丂丑七专;
    
    // Properties
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    public bool 丅上丂丈丒与且丆丗 { get; }
    private UIButton 上丄丙丟丛丝丅丆丒 { get; }
    
    // Methods
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    public bool get_BoomBoxExistFlag()
    {
        Rilisoft.LobbyItemsController val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_3 != null)
        {
                return val_3.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "device_1_6"));
        }
        
        return val_3.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "device_1_6"));
    }
    internal static void 丏不丗一丝丅丛丟丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  SettingsController.下三丟不丞丏世丗丑, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丛丛且与专丙丕丘丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  SettingsController.下三丟不丞丏世丗丑, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    private UIButton 东丌且一丆丁一三业()
    {
        UIButton val_3 = this.三丑丕丁丗东万丗丌;
        if(val_3 != null)
        {
                return val_3;
        }
        
        if(this.twitterConnectSettings != 0)
        {
                this.三丑丕丁丗东万丗丌 = this.twitterConnectSettings.GetComponentInParent<UIButton>();
            return val_3;
        }
        
        val_3 = this.三丑丕丁丗东万丗丌;
        return val_3;
    }
    public void NextAudio()
    {
        bool val_1 = 丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<MusicItem>(丑东与丅丐丅丂丞业:  this.musicList);
        if(val_1 != false)
        {
                return;
        }
        
        if(this.currentAudioIndex >= 4)
        {
                if(val_1.BoomBoxExistFlag == false)
        {
            goto label_8;
        }
        
        }
        
        int val_3 = this.currentAudioIndex + 1;
        if(((val_3 & 2147483648) == 0) && (val_3 < this.musicList.Count))
        {
                int val_5 = this.currentAudioIndex;
            val_5 = val_5 + 1;
            this.currentAudioIndex = val_5;
        }
        else
        {
                label_8:
            this.currentAudioIndex = 0;
        }
        
        this.丞丒丆不万丘丑一丞();
    }
    public void PrevAudio()
    {
        System.Collections.Generic.IEnumerable<T> val_7;
        int val_8;
        val_7 = this.musicList;
        bool val_1 = 丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<MusicItem>(丑东与丅丐丅丂丞业:  val_7);
        if(val_1 != false)
        {
                return;
        }
        
        int val_2 = this.currentAudioIndex - 1;
        if((val_2 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        val_7 = this.musicList;
        if(val_2 >= val_7.Count)
        {
            goto label_6;
        }
        
        val_8 = this.currentAudioIndex - 1;
        goto label_10;
        label_6:
        if(val_1.BoomBoxExistFlag != false)
        {
                val_8 = this.musicList.Count - 1;
        }
        else
        {
                val_8 = 4;
        }
        
        label_10:
        this.currentAudioIndex = val_8;
        this.丞丒丆不万丘丑一丞();
    }
    internal void 丞丒丆不万丘丑一丞()
    {
        MusicItem val_1 = this.musicList.Item[this.currentAudioIndex];
        this.musicName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1.localizationKey);
        MusicItem val_3 = this.musicList.Item[this.currentAudioIndex];
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  val_3.musicName, 七丆丟丗世丟且丒丆:  false, 丝下丘下丈一丞丄丄:  true, 丆与丈丏丟七丁东丛:  0);
    }
    internal static void 丞丝丝世丕下丌专丁(bool 丂丛不丐丏丂丕丙丞, System.Action 丟丟丟三东丛丌丘且)
    {
        bool val_1 = 丂丛不丐丏丂丕丙丞;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Chat] button clicked: "("[Chat] button clicked: ") + val_1.ToString());
        }
        
        if((丒七丞丞世一丒丈且<System.Boolean>.万丌专丅丘丘丟万东(一不丝丟世业丑丙一:  与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万(), 丘丑丛丕下丈世下丂:  val_1)) == false)
        {
                return;
        }
        
        与丂丏丛丞丞丒丟丄.丅世三东且东丘丘丁(丙业与丙丗丝不丈东:  丒七丞丞世一丒丈且<System.Boolean>.万丒丌丕万丏不丈世(丙业与丙丗丝不丈东:  val_1));
        if(丟丟丟三东丛丌丘且 == null)
        {
                return;
        }
        
        丟丟丟三东丛丌丘且.Invoke();
    }
    internal static void 业丌东上七下一丆丝(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        丟丌丁且且世丈丈丟.丄丝一下丅业世万丄(丙业与丙丗丝不丈东:  (~与专一业丏三丒万下) & 1);
    }
    internal static void 万丁丌丛与与不丗丁(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        bool val_4 = 与专一业丏三丒万下;
        丟丌丁且且世丈丈丟.丌三丑丛上万丄丗丝(丙业与丙丗丝不丈东:  val_4 = 与专一业丏三丒万下);
        if(val_4 == false)
        {
                return;
        }
        
        val_4 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 744];
        val_4 = InGameGUI.丙丞专丌丁丞与不丐.丘丏丛丂丅丂世上丒;
        if(val_4 == 0)
        {
                return;
        }
        
        InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.东丐丟丂丝上丞丁丅();
    }
    internal static void 下专下丑东丒一下丝(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        丟丌丁且且世丈丈丟.丏专丟丟丈与丄专且(丙业与丙丗丝不丈东:  与专一业丏三丒万下);
    }
    internal static void 丟且丈丒世丐丁丄下(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        var val_4;
        var val_5;
        System.Action val_6;
        val_4 = 丕丒上丄丒业丕丕丐;
        if(丟丌丁且且世丈丈丟.丙丘下丝一下丝丆不() ^ 与专一业丏三丒万下 == false)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丗丝七专丅丒丁丈丆(丙业与丙丗丝不丈东:  与专一业丏三丒万下);
        if(val_4 != null)
        {
                val_4.Invoke();
        }
        
        val_4 = 1152921505257537536;
        val_5 = null;
        val_5 = null;
        val_6 = SettingsController.下三丟不丞丏世丗丑;
        if(val_6 == null)
        {
                return;
        }
        
        val_6 = SettingsController.下三丟不丞丏世丗丑;
        if(val_6 == null)
        {
                val_6 = 0;
        }
        
        val_6.Invoke();
    }
    internal static void 东丆业丒丁丞丗丈丏(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        var val_9;
        var val_10;
        System.Action val_11;
        val_9 = 丕丒上丄丒业丕丕丐;
        bool val_1 = 与专一业丏三丒万下;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Left Handed] button clicked: "("[Left Handed] button clicked: ") + val_1.ToString());
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == val_1)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丙丗专东丂丁一一丛(丙业与丙丗丝不丈东:  (val_1 == true) ? 1 : 0);
        if(val_9 != null)
        {
                val_9.Invoke();
        }
        
        val_9 = 1152921505257537536;
        val_10 = null;
        val_10 = null;
        val_11 = SettingsController.下三丟不丞丏世丗丑;
        if(val_11 != null)
        {
                val_11 = SettingsController.下三丟不丞丏世丗丑;
            if(val_11 == null)
        {
                val_11 = 0;
        }
        
            val_11.Invoke();
        }
        
        if(val_1 == true)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Left-handed Layout Enabled");
    }
    internal static void 一东三世丅世且丁东(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        bool val_1 = 与专一业丏三丒万下;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Switching Weapon button clicked: "("[Switching Weapon button clicked: ") + val_1.ToString());
        }
        
        if(丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上() != val_1)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丝与丛丒丌丈丘三丒(丙业与丙丗丝不丈东:  (val_1 == false) ? 1 : 0);
        UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.不东丞专三丄丏丕丕(), value:  丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上());
        UnityEngine.PlayerPrefs.Save();
        if(丕丒上丄丒业丕丕丐 == null)
        {
                return;
        }
        
        丕丒上丄丒业丕丕丐.Invoke();
    }
    private void 不丁丅丒丗丁专丌三()
    {
        UnityEngine.Object val_29;
        string val_30;
        UILabel val_31;
        UISlider val_32;
        UnityEngine.Transform val_2 = this.syncButton.transform.Find(n:  "Label");
        val_29 = 0;
        if(val_2 != 0)
        {
                val_29 = val_2.gameObject.GetComponent<UILabel>();
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
            goto label_8;
        }
        
        if(val_29 == 0)
        {
            goto label_18;
        }
        
        val_30 = "Key_0080";
        goto label_14;
        label_8:
        if((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11) || (val_29 == 0))
        {
            goto label_18;
        }
        
        val_30 = "Key_0935";
        label_14:
        val_29.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_30);
        label_18:
        if(this.sensitivitySliderFPS != 0)
        {
                if(this.sensitivitySliderFPSLabel == 0)
        {
                val_31 = this.sensitivitySliderFPS.GetComponentInChildren<UILabel>();
            this.sensitivitySliderFPSLabel = val_31;
        }
        else
        {
                val_31 = this.sensitivitySliderFPSLabel;
        }
        
            float val_15 = this.sensitivitySliderFPS.value;
            val_15 = val_15 * 100f;
            val_31.text = System.String.Format(format:  "[c][ffffff]{0}[-][/c]", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5709"), arg0:  System.String.Format(format:  "[c][60ff00]{0}[-][/c]", arg0:  (int)val_15)));
        }
        
        val_32 = this.sensitivitySliderBR;
        if(val_32 != 0)
        {
                if(this.sensitivitySliderBRLabel == 0)
        {
                val_32 = this.sensitivitySliderBR.GetComponentInChildren<UILabel>();
            this.sensitivitySliderBRLabel = val_32;
        }
        else
        {
                val_32 = this.sensitivitySliderBRLabel;
        }
        
            float val_23 = this.sensitivitySliderBR.value;
            val_23 = val_23 * 100f;
            val_32.text = System.String.Format(format:  "[c][ffffff]{0}[-][/c]", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5710"), arg0:  System.String.Format(format:  "[c][60ff00]{0}[-][/c]", arg0:  (int)val_23)));
        }
        
        MusicItem val_27 = this.musicList.Item[this.currentAudioIndex];
        this.musicName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_27.localizationKey);
    }
    private void OnEnable()
    {
        var val_13;
        string val_35;
        bool val_36;
        UnityEngine.Vector3 val_37;
        float val_38;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_33 = 0;
            val_33 = val_33 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SettingsController::丒丏丁一一上三丂上()), 与且专丈不万东一万:  "Settings");
        this.丑丁丞且丙丅丆三丟();
        if(this.switchingWeaponsToggleButtons != 0)
        {
                this.switchingWeaponsToggleButtons.gameObject.SetActive(value:  丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上());
        }
        
        val_35 = MenuBackgroundMusic.丄一丙三丄专丛一丆();
        if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<MusicItem>(丑东与丅丐丅丂丞业:  this.musicList)) == true)
        {
            goto label_20;
        }
        
        List.Enumerator<T> val_11 = this.musicList.GetEnumerator();
        label_24:
        if(((-23941088) & 1) == 0)
        {
            goto label_22;
        }
        
        if((System.String.op_Equality(a:  0, b:  val_35)) == false)
        {
            goto label_24;
        }
        
        val_35 = this.musicList;
        this.currentAudioIndex = val_35.IndexOf(item:  val_13.丐丏七丌丕丗业且上());
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        MusicItem val_17 = this.musicList.Item[this.currentAudioIndex];
        this.musicName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_17.localizationKey);
        label_20:
        val_36 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.世丒丗丘专七不丗丂() != false)
        {
                this.autoFireButton.gameObject.SetActive(value:  true);
            this.autoFireButton.IsChecked = 与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁();
            this.autoTargettingButton.gameObject.SetActive(value:  true);
            val_36 = 与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且();
            this.autoTargettingButton.IsChecked = val_36;
            val_37 = this.丕丝一三且丗丑丂下;
            this.hideJumpAndShootButtons.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_37, y = V9.16B, z = V10.16B};
        }
        else
        {
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丕丝一三且丗丑丂下, y = V9.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.jumpAndShootButtonsWithoutAutofirePosOffset, y = V10.16B, z = V11.16B});
            val_37 = val_30.x;
            val_38 = val_30.z;
            this.hideJumpAndShootButtons.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_37, y = val_30.y, z = val_38};
            this.autoTargettingButton.gameObject.SetActive(value:  false);
            this.autoFireButton.gameObject.SetActive(value:  false);
        }
        
        this.一丈丛下丙丂丁丛丞();
    }
    internal void 丑丁丞且丙丅丆三丟()
    {
        if(this.signOutButton == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_4;
        }
        
        label_16:
        this.signOutButton.gameObject.SetActive(value:  true);
        return;
        label_4:
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
        {
                return;
        }
        
        UnityEngine.GameObject val_6 = this.signOutButton.gameObject;
        bool val_9 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅();
        goto label_16;
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.hideJumpAndShootButtons.transform.localPosition;
        this.丕丝一三且丗丑丂下 = val_2;
        mem[1152921538943209956] = val_2.y;
        mem[1152921538943209960] = val_2.z;
    }
    private void 与东丕东且丑与丁丐(string 丌丁不丙丑丑丝丆丌, string 丙业与丙丗丝不丈东)
    {
        PGCompany.Analytics.一业丗丆世世上丁且.丑下丗专丐丑丅专丑(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 下上丐丆丝丟丝丒不:  丌丁不丙丑丑丝丆丌, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void Start()
    {
        var val_185;
        UnityEngine.Vector3 val_187;
        float val_188;
        bool val_189;
        System.Action val_190;
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SettingsController::丞丛一丙丂世丈丅丗()));
        if(this.backButton != 0)
        {
                this.backButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsController::不丕且不七丞七丅三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.controlsButtonFPS != 0)
        {
                this.controlsButtonFPS.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsController::不丐三且上专丄丏丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.controlsButtonBR != 0)
        {
                this.controlsButtonBR.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsController::丂丟丘东下与丏丅丑(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.controlsButtonFP != 0)
        {
                this.controlsButtonFP.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsController::三业且七丗丂丙丗丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.socialButton != 0)
        {
                this.socialButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsController::丁丙专七丈丝丁七丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.gamepadSettingsBtn != 0)
        {
                this.gamepadSettingsBtn.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsController::业与不且与世丛丘丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gamepadSettingsBtn.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  GamepadManager.丝三丂不丈丛专丙丈.业七不丞丝丝丂丆丂()))) & 1);
        }
        
        if(this.syncButton == 0)
        {
            goto label_334;
        }
        
        this.syncButton.gameObject.SetActive(value:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        this.不丁丅丒丗丁专丌三();
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_44;
        }
        
        label_333:
        this.syncButton.gameObject.SetActive(value:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        goto label_49;
        label_44:
        if(UnityEngine.Application.platform != 8)
        {
            goto label_50;
        }
        
        this.syncButton.gameObject.SetActive(value:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        System.EventHandler val_36 = null;
        label_49:
        val_36 = new System.EventHandler(object:  this, method:  System.Void SettingsController::东且丅东丞丕丗东丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        this.syncButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  val_36);
        label_334:
        if(this.sensitivitySliderFPS == 0)
        {
            goto label_58;
        }
        
        float val_39 = UnityEngine.Mathf.Clamp(value:  与丂丏丛丞丞丒丟丄.一一上与丗专丗丏丌(), min:  6f, max:  19f);
        float val_183 = 13f;
        val_183 = (val_39 + (-6f)) / val_183;
        this.sensitivitySliderFPS.value = val_183;
        this.丛与丝丐三丝丟一东 = val_39;
        if(this.sensitivitySliderFPSLabel != 0)
        {
            goto label_66;
        }
        
        this.sensitivitySliderFPSLabel = this.sensitivitySliderFPS.GetComponentInChildren<UILabel>();
        goto label_68;
        label_58:
        UnityEngine.Debug.LogWarning(message:  "sensitivitySliderFPS == null");
        goto label_71;
        label_66:
        label_68:
        float val_44 = this.sensitivitySliderFPS.value;
        val_44 = val_44 * 100f;
        this.sensitivitySliderFPSLabel.text = System.String.Format(format:  "[c][ffffff]{0}[-][/c]", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5709"), arg0:  System.String.Format(format:  "[c][60ff00]{0}[-][/c]", arg0:  (int)val_44)));
        label_71:
        if(this.sensitivitySliderBR == 0)
        {
            goto label_78;
        }
        
        float val_50 = UnityEngine.Mathf.Clamp(value:  与丂丏丛丞丞丒丟丄.丒丞丈丗丟丑丘丅与(), min:  6f, max:  19f);
        float val_51 = val_50 + (-6f);
        float val_184 = 13f;
        val_184 = val_51 / val_184;
        this.sensitivitySliderBR.value = val_184;
        this.丛与丝丐三丝丟一东 = val_50;
        if(this.sensitivitySliderBRLabel != 0)
        {
            goto label_86;
        }
        
        this.sensitivitySliderBRLabel = this.sensitivitySliderBR.GetComponentInChildren<UILabel>();
        goto label_88;
        label_78:
        UnityEngine.Debug.LogWarning(message:  "sensitivitySliderBR == null");
        goto label_91;
        label_86:
        label_88:
        float val_55 = this.sensitivitySliderBR.value;
        val_55 = val_55 * 100f;
        this.sensitivitySliderBRLabel.text = System.String.Format(format:  "[c][ffffff]{0}[-][/c]", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5710"), arg0:  System.String.Format(format:  "[c][60ff00]{0}[-][/c]", arg0:  (int)val_55)));
        label_91:
        if(this.pressureSensitivitySlider != 0)
        {
                if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_102;
        }
        
        }
        
            float val_63 = UnityEngine.Mathf.Clamp(value:  与丂丏丛丞丞丒丟丄.丛丗丅丐丌且与丁与(), min:  0.3f, max:  0.98f);
            float val_185 = 0.68f;
            val_185 = (val_63 + (-0.3f)) / val_185;
            this.pressureSensitivitySlider.value = val_185;
            this.下业丘万不专业丈丟 = val_63;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "sensitivitySlider == null");
        }
        
        label_337:
        if(this.inviteLocalToggleButton != 0)
        {
                this.inviteLocalToggleButton.IsChecked = 与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏();
            this.inviteLocalToggleButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::专上七上丅丐丏世丟(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        
        if(this.inviteRemoteToogleButton != 0)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                label_132:
            this.inviteRemoteToogleButton.gameObject.SetActive(value:  true);
            this.inviteRemoteToogleButton.IsChecked = 与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝();
            this.inviteRemoteToogleButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::下丏专丙丛丈丞专业(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        else
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
                if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2)
        {
            goto label_132;
        }
        
        }
        
            this.inviteRemoteToogleButton.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.musicToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == true) ? 1 : 0;
        if(this.musicVolumeSlider == 0)
        {
            goto label_140;
        }
        
        float val_80 = 与丂丏丛丞丞丒丟丄.业且丞丂一与不七丑();
        this.musicVolumeSlider.value = val_80;
        this.专专丟万不万丞丁七 = val_80;
        goto label_146;
        label_153:
        T val_186 = this.musicVolumeSlider.gameObject.GetComponentsInChildren<UnityEngine.BoxCollider>(includeInactive:  true)[0];
        if((System.String.op_Equality(a:  val_186.name, b:  "Thumb")) != false)
        {
                val_186.enabled = this.musicToggleButtons.IsChecked;
        }
        
        label_146:
        if(1 < val_82.Length)
        {
            goto label_153;
        }
        
        if((this.nextAudio == 0) || (this.prevAudio == 0))
        {
            goto label_164;
        }
        
        this.prevAudio.enabled = this.musicToggleButtons.IsChecked;
        this.nextAudio.enabled = this.musicToggleButtons.IsChecked;
        goto label_164;
        label_140:
        UnityEngine.Debug.LogWarning(message:  "musicVolumeSlider == null");
        label_164:
        this.musicToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丛丞丅丆与丝丘万不(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        this.soundToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        this.soundToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丞丞丑七丒丙丏丅丛(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        this.chatToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万().世三丞丅丑丌丈丈一();
        this.chatToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丏丈万丆丝不业丗下(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        this.invertCameraToggleButtons.IsChecked = ((UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.且丄一丐丝世东丟专, defaultValue:  0)) == 1) ? 1 : 0;
        this.invertCameraToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丙一丑丁丗东三专丏(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        if(this.leftHandedToggleButtons != 0)
        {
                this.leftHandedToggleButtons.IsChecked = (~丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三()) & 1;
        }
        
        if(this.vehiclePedalsToggleButtons != 0)
        {
                this.vehiclePedalsToggleButtons.IsChecked = 丟丌丁且且世丈丈丟.丙丘下丝一下丝丆不();
            this.vehiclePedalsToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丏丘上万丅且丄丕丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        
        if(this.fps60ToggleButtons != 0)
        {
                this.fps60ToggleButtons.IsChecked = (~丟丌丁且且世丈丈丟.丆丛丏丛丟丁丁万三()) & 1;
            this.fps60ToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::一丟丝业且丗丕与丂(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        
        if(this.autoPickUpToggleButtons == 0)
        {
            goto label_199;
        }
        
        this.autoPickUpToggleButtons.IsChecked = 丟丌丁且且世丈丈丟.东七丟丕且一丗丅一();
        val_185 = null;
        val_185 = null;
        if((SettingsController.<>c.<>9__101_8) == null)
        {
            goto label_205;
        }
        
        label_332:
        this.autoPickUpToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  SettingsController.<>c.<>9__101_8);
        label_199:
        if(this.battleEmojiButtons != 0)
        {
                this.battleEmojiButtons.IsChecked = 丟丌丁且且世丈丈丟.且三丏上七业丙丅丆();
            this.battleEmojiButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::三业东一丈下上三丙(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        
        if(this.switchingWeaponsToggleButtons != 0)
        {
                this.switchingWeaponsToggleButtons.IsChecked = (~丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上()) & 1;
            this.switchingWeaponsToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丛丑业丈丞三丒丅世(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        
        if(this.tapticFeedbackToggleButtons != 0)
        {
                if(FirstPersonControlSharp.IsTapticSupports != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_227;
        }
        
        }
        
            this.tapticFeedbackToggleButtons.gameObject.SetActive(value:  true);
            this.tapticFeedbackToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.业丙三不且业丗丐丂();
            this.tapticFeedbackToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::不三丑丗丈丐丄丒七(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        else
        {
                label_227:
            if(this.tapticFeedbackToggleButtons != 0)
        {
                this.tapticFeedbackToggleButtons.gameObject.SetActive(value:  false);
        }
        
        }
        
        if(this.shoot3dTouchToggleButtons != 0)
        {
                if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_246;
        }
        
        }
        
            this.shoot3dTouchToggleButtons.gameObject.SetActive(value:  true);
            this.shoot3dTouchToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌();
            this.shoot3dTouchToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丂丞丗丞丆三丐三丒(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        }
        else
        {
                label_246:
            if(this.shoot3dTouchToggleButtons != 0)
        {
                this.shoot3dTouchToggleButtons.gameObject.SetActive(value:  false);
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.世丒丗丘专七不丗丂() != false)
        {
                this.autoFireButton.gameObject.SetActive(value:  true);
            this.autoFireButton.IsChecked = 与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁();
            this.autoFireButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::东且世丐不上业一丑(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
            this.autoTargettingButton.gameObject.SetActive(value:  true);
            this.autoTargettingButton.IsChecked = 与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且();
            this.autoTargettingButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丒丙丆一万万一丂七(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
            val_187 = this.丕丝一三且丗丑丂下;
            this.hideJumpAndShootButtons.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_187, y = val_51, z = V10.16B};
        }
        else
        {
                UnityEngine.Vector3 val_157 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丕丝一三且丗丑丂下, y = val_51, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.jumpAndShootButtonsWithoutAutofirePosOffset, y = V10.16B, z = V11.16B});
            val_187 = val_157.x;
            val_188 = val_157.z;
            this.hideJumpAndShootButtons.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_187, y = val_157.y, z = val_188};
            this.autoTargettingButton.gameObject.SetActive(value:  false);
            this.autoFireButton.gameObject.SetActive(value:  false);
        }
        
        if(this.secondsFireButtons != 0)
        {
                this.secondsFireButtons.SetActive(value:  true);
        }
        
        this.useAutoShootButtons.SetActive(value:  false);
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_293;
        }
        
        }
        
        this.jump3dTouchToggleButtons.gameObject.SetActive(value:  true);
        this.jump3dTouchToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆();
        this.jump3dTouchToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丄丏丏七一丘丘业丌(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        goto label_300;
        label_293:
        this.jump3dTouchToggleButtons.gameObject.SetActive(value:  false);
        label_300:
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_306;
        }
        
        }
        
        UnityEngine.GameObject val_170 = this.hideJumpAndShootButtons.gameObject;
        if(与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() == false)
        {
            goto label_310;
        }
        
        val_189 = 1;
        if(val_170 != null)
        {
            goto label_315;
        }
        
        goto label_312;
        label_310:
        val_189 = 与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌();
        if(val_170 != null)
        {
            goto label_315;
        }
        
        label_312:
        label_315:
        val_170.SetActive(value:  val_189);
        this.hideJumpAndShootButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丗丒丆丗丛丗上丌丂();
        this.hideJumpAndShootButtons.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsController::丑世一丈丏丒下丞与(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        goto label_320;
        label_306:
        this.hideJumpAndShootButtons.gameObject.SetActive(value:  false);
        label_320:
        bool val_177 = UnityEngine.Object.op_Inequality(x:  this.controlsTable, y:  0);
        if(((System.Delegate.Combine(a:  SelectAutoShootMode.丏业业不丂丆下丘丙, b:  new System.Action(object:  this, method:  public System.Void SettingsController::OnClickAutoShoot()))) != null) && (null != null))
        {
                val_190 = 0;
        }
        
        SelectAutoShootMode.丏业业不丂丆下丘丙 = val_190;
        return;
        label_205:
        SettingsController.<>c.<>9__101_8 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  SettingsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SettingsController.<>c::上丅不上丟丝丘丁不(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且));
        if(this.autoPickUpToggleButtons != null)
        {
            goto label_332;
        }
        
        goto label_332;
        label_50:
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
            goto label_333;
        }
        
        goto label_334;
        label_102:
        this.pressureSensitivitySlider.gameObject.SetActive(value:  false);
        goto label_337;
    }
    private void 丁丙专七丈丝丁七丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(丆与丞丈下丄丐专丛.丑七不且上丗丁一世().万丘三丘下与与且业() != 0)
        {
                return;
        }
        
        Rilisoft.一丟专且三万丞丁丂.专丕丒万业一丑丗丙(丝丏业丅丈东业丝丒:  "Social");
    }
    public void OnClickAutoShoot()
    {
        if(this.shoot3dTouchToggleButtons != 0)
        {
                if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_7;
        }
        
        }
        
            this.shoot3dTouchToggleButtons.gameObject.SetActive(value:  true);
        }
        
        label_7:
        if(this.secondsFireButtons != 0)
        {
                this.secondsFireButtons.SetActive(value:  true);
        }
        
        if(this.controlsTable == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(UITable).__il2cppRuntimeField_1A8;
    }
    private void Update()
    {
        UIButton val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        MainMenuHeroCamera val_104;
        float val_105;
        float val_106;
        float val_107;
        val_94 = this;
        if(FacebookController.且丈丄一丁丞丒丑东() != false)
        {
                val_95 = Facebook.Unity.FB.IsLoggedIn;
        }
        else
        {
                val_95 = 0;
        }
        
        if(val_95 == this.facebookConnectedSettings.activeSelf)
        {
            goto label_8;
        }
        
        if(FacebookController.且丈丄一丁丞丒丑东() == false)
        {
            goto label_11;
        }
        
        val_96 = Facebook.Unity.FB.IsLoggedIn;
        if(this.facebookConnectedSettings != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_11:
        val_96 = 0;
        if(this.facebookConnectedSettings != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        this.facebookConnectedSettings.SetActive(value:  false);
        label_8:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.facebookDisconnectedSettings, 丏业丟一东丂东丘丛:  false);
        if(FacebookController.且丈丄一丁丞丒丑东() != false)
        {
                val_97 = (~Facebook.Unity.FB.IsLoggedIn) & 1;
        }
        else
        {
                val_97 = 0;
        }
        
        if(val_97 == this.facebookConnectSettingsLabel.activeSelf)
        {
            goto label_26;
        }
        
        if(FacebookController.且丈丄一丁丞丒丑东() == false)
        {
            goto label_29;
        }
        
        val_98 = (~Facebook.Unity.FB.IsLoggedIn) & 1;
        if(this.facebookConnectSettingsLabel != null)
        {
            goto label_34;
        }
        
        goto label_33;
        label_29:
        val_98 = 0;
        if(this.facebookConnectSettingsLabel != null)
        {
            goto label_34;
        }
        
        label_33:
        label_34:
        this.facebookConnectSettingsLabel.SetActive(value:  false);
        label_26:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.facebookConnectSettings, 丏业丟一东丂东丘丛:  false);
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                val_99 = TwitterController.丒丆世一与丁丛丐下();
        }
        else
        {
                val_99 = 0;
        }
        
        if(val_99 == this.twitterConnectedSettings.activeSelf)
        {
            goto label_44;
        }
        
        if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
            goto label_47;
        }
        
        val_100 = TwitterController.丒丆世一与丁丛丐下();
        if(this.twitterConnectedSettings != null)
        {
            goto label_52;
        }
        
        goto label_51;
        label_47:
        val_100 = 0;
        if(this.twitterConnectedSettings != null)
        {
            goto label_52;
        }
        
        label_51:
        label_52:
        this.twitterConnectedSettings.SetActive(value:  false);
        label_44:
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
            goto label_59;
        }
        
        }
        
        val_101 = 0;
        goto label_60;
        label_59:
        val_101 = (~TwitterController.丌丛且丑丈丈丅丗七()) & 1;
        label_60:
        if(val_101 == this.twitterDisconnectedSettings.activeSelf)
        {
            goto label_63;
        }
        
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
            goto label_69;
        }
        
        }
        
        if(this.twitterDisconnectedSettings != null)
        {
            goto label_189;
        }
        
        label_190:
        label_189:
        this.twitterDisconnectedSettings.SetActive(value:  false);
        label_63:
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
            goto label_77;
        }
        
        }
        
        val_102 = 0;
        goto label_78;
        label_77:
        val_102 = TwitterController.丌丛且丑丈丈丅丗七();
        label_78:
        if(val_102 == this.twitterConnectSettingsLabel.activeSelf)
        {
            goto label_81;
        }
        
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
            goto label_87;
        }
        
        }
        
        if(this.twitterConnectSettingsLabel != null)
        {
            goto label_193;
        }
        
        label_194:
        label_193:
        this.twitterConnectSettingsLabel.SetActive(value:  false);
        label_81:
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
            goto label_95;
        }
        
        }
        
        val_103 = 0;
        goto label_96;
        label_95:
        val_103 = (~TwitterController.丌丛且丑丈丈丅丗七()) & 1;
        label_96:
        if(val_103 == this.twitterConnectSettings.activeSelf)
        {
            goto label_99;
        }
        
        if(TwitterController.上业丗丛三丕丒丗丙() != false)
        {
                if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
            goto label_105;
        }
        
        }
        
        if(this.twitterConnectSettings != null)
        {
            goto label_197;
        }
        
        label_198:
        label_197:
        this.twitterConnectSettings.SetActive(value:  false);
        label_99:
        if(TwitterController.上业丗丛三丕丒丗丙() != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.东丌且一丆丁一三业(), 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丅丝丁丑且丁下丆丄 == false)
        {
            goto label_112;
        }
        
        this.丅丝丁丑且丁下丆丄 = false;
        this.mainPanel.SetActive(value:  true);
        this.gameObject.SetActive(value:  false);
        PGCompany.Piggy.PiggyOffersLobby.丑七不且上丗丁一世().丝一丅丆三东丂丞七();
        AmongUsButtonLobby.Instance.丕丕业七丙七丅丈丄();
        RedLightButtonInLobby.丑上丞不与丄丗丌一();
        if(this.rotateCamera != 0)
        {
            goto label_119;
        }
        
        val_104 = MainMenuHeroCamera.丑七不且上丗丁一世();
        this.rotateCamera = val_104;
        goto label_120;
        label_112:
        float val_47 = this.sensitivitySliderFPS.value;
        val_47 = val_47 * 13f;
        val_105 = val_47 + 6f;
        float val_48 = UnityEngine.Mathf.Clamp(value:  val_105, min:  6f, max:  19f);
        if(this.丛与丝丐三丝丟一东 != val_48)
        {
                if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New sensitivity FPS: "("New sensitivity FPS: ") + val_48);
        }
        
            与丂丏丛丞丞丒丟丄.且丟不业丘东丄丘世(丙业与丙丗丝不丈东:  val_48);
            this.丛与丝丐三丝丟一东 = val_48;
            val_105 = this.sensitivitySliderFPS.value * 100f;
            this.sensitivitySliderFPSLabel.text = System.String.Format(format:  "[c][ffffff]{0}[-][/c]", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5709"), arg0:  System.String.Format(format:  "[c][60ff00]{0}[-][/c]", arg0:  (int)val_105)));
        }
        
        float val_56 = this.sensitivitySliderBR.value;
        val_56 = val_56 * 13f;
        val_106 = val_56 + 6f;
        float val_57 = UnityEngine.Mathf.Clamp(value:  val_106, min:  6f, max:  19f);
        if(this.丁东七丆丛丑丘丙东 != val_57)
        {
                if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New sensitivity BR: "("New sensitivity BR: ") + val_57);
        }
        
            与丂丏丛丞丞丒丟丄.丒三丁万丘丘丗东丕(丙业与丙丗丝不丈东:  val_57);
            this.丁东七丆丛丑丘丙东 = val_57;
            val_106 = this.sensitivitySliderBR.value * 100f;
            this.sensitivitySliderBRLabel.text = System.String.Format(format:  "[c][ffffff]{0}[-][/c]", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5710"), arg0:  System.String.Format(format:  "[c][60ff00]{0}[-][/c]", arg0:  (int)val_106)));
        }
        
        val_107 = this.musicVolumeSlider.value;
        if(this.专专丟万不万丞丁七 != val_107)
        {
                if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New volume: "("New volume: ") + val_107);
        }
        
            与丂丏丛丞丞丒丟丄.业丏东丌丐丑丗丑业(丙业与丙丗丝不丈东:  val_107);
            val_106 = val_107;
            MenuBackgroundMusic.专下丆丞一丆丏丂东(与丁万东丌丑下丏丕:  val_106);
            this.专专丟万不万丞丁七 = val_107;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_163;
        }
        
        }
        
        float val_88 = 0.68f;
        val_88 = this.pressureSensitivitySlider.value * val_88;
        val_88 = val_88 + 0.3f;
        val_107 = UnityEngine.Mathf.Clamp(value:  val_88, min:  0.3f, max:  0.98f);
        if(this.下业丘万不专业丈丟 != val_107)
        {
                if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New pressure: "("New pressure: ") + val_107);
        }
        
            与丂丏丛丞丞丒丟丄.三丈丐专丄下业丞丅(丙业与丙丗丝不丈东:  val_107);
            this.下业丘万不专业丈丟 = val_107;
        }
        
        label_163:
        if(this.syncButton == 0)
        {
                return;
        }
        
        if(this.syncButton.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_94 = this.syncButton;
        var val_78 = (~Rilisoft.丐丌丝七下丈丒丅丗.丁丟丗与万丆丝丈丞()) & 1;
        return;
        label_119:
        val_104 = this.rotateCamera;
        label_120:
        if(val_104 != 0)
        {
                this.rotateCamera.PlayCloseOptions();
        }
        
        if(AnimationGift.丄丘七三上丕世丞业 != 0)
        {
                AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
        }
        
        PGCompany.Piggy.PiggyOffersLobby.丑七不且上丗丁一世().丝一丅丆三东丂丞七();
        return;
        label_69:
        var val_83 = (~TwitterController.丌丛且丑丈丈丅丗七()) & 1;
        if(this.twitterDisconnectedSettings != null)
        {
            goto label_189;
        }
        
        goto label_190;
        label_87:
        bool val_85 = TwitterController.丌丛且丑丈丈丅丗七();
        if(this.twitterConnectSettingsLabel != null)
        {
            goto label_193;
        }
        
        goto label_194;
        label_105:
        var val_87 = (~TwitterController.丌丛且丑丈丈丅丗七()) & 1;
        if(this.twitterConnectSettings != null)
        {
            goto label_197;
        }
        
        goto label_198;
    }
    private void 不丕且不七丞七丅三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丅丝丁丑且丁下丆丄 = true;
        float val_1 = this.musicVolumeSlider.value;
        val_1 = val_1 * 100f;
        string val_3 = UnityEngine.Mathf.RoundToInt(f:  val_1).ToString();
        val_3.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "musicVolume", 丙业与丙丗丝不丈东:  val_3);
        float val_4 = this.sensitivitySliderFPS.value;
        val_4 = val_4 * 100f;
        string val_6 = UnityEngine.Mathf.RoundToInt(f:  val_4).ToString();
        val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sensativity", 丙业与丙丗丝不丈东:  val_6);
        float val_7 = this.sensitivitySliderBR.value;
        val_7 = val_7 * 100f;
        string val_9 = UnityEngine.Mathf.RoundToInt(f:  val_7).ToString();
        val_9.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sensativityBR", 丙业与丙丗丝不丈东:  val_9);
        float val_10 = this.pressureSensitivitySlider.value;
        val_10 = val_10 * 100f;
        string val_12 = UnityEngine.Mathf.RoundToInt(f:  val_10).ToString();
        val_12.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "pressure3d", 丙业与丙丗丝不丈东:  val_12);
        PGCompany.Analytics.一业丗丆世世上丁且.且丙且丛丅业丐丝一(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世());
    }
    private void 不丐三且上专丄丏丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Controls] button clicked.");
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.东东一世专业下丒丌(丙业与丙丗丝不丈东:  0);
        this.丄丘丑万丙世三世丙();
    }
    private void 丂丟丘东下与丏丅丑(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Controls Battle Royale] button clicked.");
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.东东一世专业下丒丌(丙业与丙丗丝不丈东:  1);
        this.丄丘丑万丙世三世丙();
    }
    private void 三业且七丗丂丙丗丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Controls Free Play] button clicked.");
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.东东一世专业下丒丌(丙业与丙丗丝不丈东:  2);
        this.丄丘丑万丙世三世丙();
    }
    private void 业与不且与世丛丘丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_13;
        var val_14;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_3;
        }
        
        val_13 = 0;
        goto label_4;
        label_9:
        UnityEngine.Debug.Log(message:  "[Connected gamepads] " + UnityEngine.Input.GetJoystickNames()[0]);
        val_13 = 1;
        label_4:
        if(val_13 < val_2.Length)
        {
            goto label_9;
        }
        
        label_3:
        if((GamepadManager.丝三丂不丈丛专丙丈.业七不丞丝丝丂丆丂().Equals(value:  "Sony Interactive Entertainment Wireless Controller")) != false)
        {
                val_14 = "SettingsPanelGamepadPS4";
        }
        
        UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  ((GamepadManager.丝三丂不丈丛专丙丈.业七不丞丝丝丂丆丂().Equals(value:  "Unknown Xbox Wireless Controller")) != true) ? "SettingsPanelGamepadXBox" : System.String.alignConst), parent:  this.transform.parent);
    }
    private void 丄丘丑万丙世三世丙()
    {
        var val_9;
        System.Action val_10;
        this.controlsSettings.SetActive(value:  true);
        this.tapPanel.SetActive(value:  (~丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上()) & 1);
        this.swipePanel.SetActive(value:  false);
        this.swipePanel.transform.parent.gameObject.SetActive(value:  (~丟丌丁且且世丈丈丟.下丘万丟丑下丁丒上()) & 1);
        this.gameObject.SetActive(value:  false);
        val_9 = null;
        val_9 = null;
        val_10 = SettingsController.下三丟不丞丏世丗丑;
        if(val_10 == null)
        {
                return;
        }
        
        val_10 = SettingsController.下三丟不丞丏世丗丑;
        if(val_10 == null)
        {
                val_10 = 0;
        }
        
        val_10.Invoke();
    }
    private void 东且丅东丞丕丗东丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Restore] button clicked.");
        }
        
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  SettingsController.丝下且丁丅丛丌丞七());
    }
    private static System.Collections.IEnumerator 丝下且丁丅丛丌丞七()
    {
        return (System.Collections.IEnumerator)new SettingsController.丑丟丐不丂东丏丙丙(丗丏丅丕丆世丁专丟:  0);
    }
    internal static void 丄丕万丁丗丆丒丅不()
    {
    
    }
    private void 东一丄丐与丅东上丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        PGCompany.Analytics.一业丗丆世世上丁且.三丙专业丌丏丛丌与(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世());
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  this.万丝下丏丗一丂七下());
    }
    private System.Collections.IEnumerator 万丝下丏丗一丂七下()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SettingsController.与丌世丒丞丙丆丅丈(丗丏丅丕丆世丁专丟:  0);
    }
    private void OnDestroy()
    {
        System.Action val_5;
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SettingsController::丞丛一丙丂世丈丅丗()));
        if(((System.Delegate.Remove(source:  SelectAutoShootMode.丏业业不丂丆下丘丙, value:  new System.Action(object:  this, method:  public System.Void SettingsController::OnClickAutoShoot()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        SelectAutoShootMode.丏业业不丂丆下丘丙 = val_5;
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.不丁丅丒丗丁专丌三();
    }
    private void 一丈丛下丙丂丁丛丞()
    {
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        var val_14;
        System.Action<BtnCategory> val_16;
        var val_17;
        val_10 = this;
        if(this._tabButtonsController == 0)
        {
                return;
        }
        
        bool val_2 = 上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅();
        val_11 = val_2;
        val_11 = ~val_2;
        if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() != null)
        {
                val_11 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            val_12 = (~(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  val_11))) & 1;
        }
        else
        {
                val_12 = 1;
        }
        
        val_12 = val_12 | (val_11 & 1);
        if(val_12 == 0)
        {
                if(Rilisoft.七不丑丑下与丛丝丝.不丆丕丁万专东东且() != true)
        {
                val_13 = null;
            val_13 = null;
            if(SettingsController.丙万丞丄与丂丑七专 == false)
        {
                return;
        }
        
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = SettingsController.<>c.<>9__119_0;
        if(val_16 == null)
        {
                System.Action<BtnCategory> val_9 = null;
            val_16 = val_9;
            val_9 = new System.Action<BtnCategory>(object:  SettingsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SettingsController.<>c::丘不丛丄丏丒丛丌上(BtnCategory 三丟东丕丄丄下下丑));
            SettingsController.<>c.<>9__119_0 = val_16;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<BtnCategory>(丌丛丏业世丄丞三丌:  this._tabButtonsController.buttons, 七丐丅专且专七三丆:  val_9);
        val_10 = 1152921505257537536;
        val_17 = null;
        val_17 = null;
        SettingsController.丙万丞丄与丂丑七专 = false;
    }
    public void U_OpenUserCharacters()
    {
        var val_3;
        this.gameObject.SetActive(value:  false);
        val_3 = null;
        val_3 = null;
        MainMenuController.丄丞丁丈与业上丞丟.EnableUserCharactersWindow(丑丒业丘丑东丕世丅:  true, 丛丝与丂世丌丌丝丂:  new System.Action(object:  MainMenuController.丄丞丁丈与业上丞丟, method:  public System.Void MainMenuController::GoBackFromUserCharactersToOptions()));
    }
    public void U_ShowPrivatePolicy()
    {
        SettingsController.丄丈丄丗丈七万丙万();
    }
    internal static void 丄丈丄丗丈七万丙万()
    {
        null = null;
        UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.不丝东丑丐与丂丙丆);
    }
    public void U_ShowTermsOfUse()
    {
        SettingsController.一丝丈一丂七且丘世();
    }
    internal static void 一丝丈一丂七且丘世()
    {
        null = null;
        UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.丙且丛丄丈丗上丙丄);
    }
    public SettingsController()
    {
        mem2[0] = 0;
        mem[1152921538948860036] = 0;
    }
    private static SettingsController()
    {
    
    }
    private void 丒丏丁一一上三丂上()
    {
        this.不丕且不七丞七丅三(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 专上七上丅丐丏世丟(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        bool val_17;
        var val_18;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_8 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "ingameNotif", 丙业与丙丗丝不丈东:  val_8);
        }
        
        val_17 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟();
        与丂丏丛丞丞丒丟丄.丟专丈上丒丝万下丟(丙业与丙丗丝不丈东:  val_17);
        val_18 = null;
        if(SettingsController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_17 = "[SettingsController.inviteLocalToggleButton] isEnableLocalInviteFromFriends: "("[SettingsController.inviteLocalToggleButton] isEnableLocalInviteFromFriends: ") + 与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏().ToString() + " -> "(" -> ") + 与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏().ToString();
        UnityEngine.Debug.Log(message:  val_17);
    }
    private void 下丏专丙丛丈丞专业(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        UnityEngine.Object val_23;
        var val_24;
        val_23 = 丗丛不丁丑专专丂且;
        if(与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝() ^ val_23.且丂丅丁与丟丒丛丟() != false)
        {
                if(val_23 != null)
        {
                string val_8 = val_23.且丂丅丁与丟丒丛丟().ToString();
            val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "localNotif", 丙业与丙丗丝不丈东:  val_8);
        }
        else
        {
                string val_11 = 0.且丂丅丁与丟丒丛丟().ToString();
            val_11.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "localNotif", 丙业与丙丗丝不丈东:  val_11);
        }
        
            与丂丏丛丞丞丒丟丄.世东七丌上一下七东(丙业与丙丗丝不丈东:  val_23.且丂丅丁与丟丒丛丟());
            val_23 = RemotePushNotificationController.丑七不且上丗丁一世();
            if(val_23 != 0)
        {
                val_23 = RemotePushNotificationController.丑七不且上丗丁一世();
            val_23.丂丟世三丞丒丈丆丅(丑丞东万丁丂丏万丙:  "SettingsController");
        }
        
        }
        
        val_24 = null;
        if(SettingsController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_23 = "[SettingsController.inviteRemoteToogleButton] isEnableRemoteInviteFromFriends: "("[SettingsController.inviteRemoteToogleButton] isEnableRemoteInviteFromFriends: ") + 与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝().ToString() + " -> "(" -> ") + 与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝().ToString();
        UnityEngine.Debug.Log(message:  val_23);
    }
    private void 丛丞丅丆与丝丘万不(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        T val_29;
        UIButton val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        val_29 = 丗丛不丁丑专专丂且;
        val_30 = this;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Music] button clicked: "("[Music] button clicked: ") + val_29.且丂丅丁与丟丒丛丟().ToString());
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = 1152921505171275776;
        val_33 = null;
        val_33 = null;
        if((((与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == true) ? 1 : 0) ^ val_29.且丂丅丁与丟丒丛丟()) == false)
        {
                return;
        }
        
        val_34 = null;
        val_34 = null;
        与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 = val_29.且丂丅丁与丟丒丛丟();
        string val_13 = val_29.且丂丅丁与丟丒丛丟().ToString();
        val_13.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "music", 丙业与丙丗丝不丈东:  val_13);
        丛丌丙丂丑丞丂丏丟.万丞上丘丗丆丙一丑(丒丘丏上丙丟丑丕丈:  丛丌丙丂丑丞丂丏丟.丏丏丌下丑三丐与东(), 丂且与下丘丅丟丈丕:  与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下);
        UnityEngine.PlayerPrefs.Save();
        val_32 = 1152921504848912384;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 == 0)
        {
            goto label_17;
        }
        
        if(val_29.且丂丅丁与丟丒丛丟() == false)
        {
            goto label_19;
        }
        
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.三且世三丂七丐一丟();
        val_35 = 0;
        goto label_23;
        label_29:
        val_29 = this.musicVolumeSlider.gameObject.GetComponentsInChildren<UnityEngine.BoxCollider>(includeInactive:  true)[0];
        if((System.String.op_Equality(a:  val_29.name, b:  "Thumb")) != false)
        {
                val_29.enabled = true;
        }
        
        val_35 = 1;
        label_23:
        if(val_35 < val_18.Length)
        {
            goto label_29;
        }
        
        if(this.nextAudio == 0)
        {
                return;
        }
        
        if(this.prevAudio == 0)
        {
                return;
        }
        
        this.prevAudio.enabled = true;
        val_30 = this.nextAudio;
        val_30.enabled = true;
        return;
        label_17:
        UnityEngine.Debug.LogWarning(message:  "menuBackgroundMusic == null");
        return;
        label_19:
        val_36 = 0;
        goto label_44;
        label_50:
        T val_29 = this.musicVolumeSlider.gameObject.GetComponentsInChildren<UnityEngine.BoxCollider>(includeInactive:  true)[0];
        if((System.String.op_Equality(a:  val_29.name, b:  "Thumb")) != false)
        {
                val_29.enabled = false;
        }
        
        val_36 = 1;
        label_44:
        if(val_36 < val_24.Length)
        {
            goto label_50;
        }
        
        val_29 = this.nextAudio;
        if(val_29 != 0)
        {
                val_29 = this.prevAudio;
            if(val_29 != 0)
        {
                val_29 = this.prevAudio;
            val_29.enabled = false;
            val_30 = this.nextAudio;
            val_30.enabled = false;
        }
        
        }
        
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丄丏下七丁专丂世();
    }
    private void 丞丞丑七丒丙丏丅丛(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        Rilisoft.丛丘不丄丗丝丗七上 val_17 = 丗丛不丁丑专专丂且;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Sound] button clicked: "("[Sound] button clicked: ") + val_17.且丂丅丁与丟丒丛丟().ToString());
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() ^ val_17.且丂丅丁与丟丒丛丟() == false)
        {
                return;
        }
        
        与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  val_17.且丂丅丁与丟丒丛丟());
        string val_13 = val_17.且丂丅丁与丟丒丛丟().ToString();
        val_13.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sound", 丙业与丙丗丝不丈东:  val_13);
        val_17 = 丛丌丙丂丑丞丂丏丟.丏丏丌丆丞丂丆不丗();
        丛丌丙丂丑丞丂丏丟.万丞上丘丗丆丙一丑(丒丘丏上丙丟丑丕丈:  val_17, 丂且与下丘丅丟丈丕:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗());
        UnityEngine.PlayerPrefs.Save();
    }
    private void 丏丈万丆丝不业丗下(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if((丒七丞丞世一丒丈且<System.Boolean>.万丌专丅丘丘丟万东(一不丝丟世业丑丙一:  与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万(), 丘丑丛丕下丈世下丂:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟())) != false)
        {
                string val_7 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_7.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "chat", 丙业与丙丗丝不丈东:  val_7);
        }
        
        SettingsController.丞丝丝世丕下丌专丁(丂丛不丐丏丂丕丙丞:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丟丟丟三东丛丌丘且:  0);
    }
    private void 丙一丑丁丗东三专丏(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        bool val_15;
        var val_16;
        var val_17;
        val_15 = 丗丛不丁丑专专丂且;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Invert Camera] button clicked: "("[Invert Camera] button clicked: ") + val_15.且丂丅丁与丟丒丛丟().ToString());
        }
        
        val_16 = null;
        val_16 = null;
        var val_8 = ((UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.且丄一丐丝世东丟专, defaultValue:  0)) == 1) ? 1 : 0;
        val_8 = val_8 ^ val_15.且丂丅丁与丟丒丛丟();
        if(val_8 == false)
        {
                return;
        }
        
        string val_11 = val_15.且丂丅丁与丟丒丛丟().ToString();
        val_11.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "invertCamera", 丙业与丙丗丝不丈东:  val_11);
        val_17 = null;
        val_17 = null;
        val_15 = val_15.且丂丅丁与丟丒丛丟();
        UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.且丄一丐丝世东丟专, value:  System.Convert.ToInt32(value:  val_15));
        UnityEngine.PlayerPrefs.Save();
    }
    private void 丏丘上万丅且丄丕丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且 != null)
        {
                string val_3 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_3.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "vehPedals", 丙业与丙丗丝不丈东:  val_3);
        }
        else
        {
                string val_6 = 0.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "vehPedals", 丙业与丙丗丝不丈东:  val_6);
        }
        
        SettingsController.丟且丈丒世丐丁丄下(与专一业丏三丒万下:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丕丒上丄丒业丕丕丐:  0);
    }
    private void 一丟丝业且丗丕与丂(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且 != null)
        {
                var val_7 = ~丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟();
            val_7 = val_7 & 1;
            string val_2 = val_7.ToString();
            val_2.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "fps60", 丙业与丙丗丝不丈东:  val_2);
        }
        else
        {
                var val_8 = ~0.且丂丅丁与丟丒丛丟();
            val_8 = val_8 & 1;
            string val_4 = val_8.ToString();
            val_4.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "fps60", 丙业与丙丗丝不丈东:  val_4);
        }
        
        SettingsController.业丌东上七下一丆丝(与专一业丏三丒万下:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丕丒上丄丒业丕丕丐:  0);
    }
    private void 三业东一丈下上三丙(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(丟丌丁且且世丈丈丟.且三丏上七业丙丅丆() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_6 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "battleEmoji", 丙业与丙丗丝不丈东:  val_6);
        }
        
        SettingsController.下专下丑东丒一下丝(与专一业丏三丒万下:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丕丒上丄丒业丕丕丐:  0);
    }
    private void 丛丑业丈丞三丒丅世(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且 != null)
        {
                string val_3 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_3.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "weaponsSwitching", 丙业与丙丗丝不丈东:  val_3);
        }
        else
        {
                string val_6 = 0.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "weaponsSwitching", 丙业与丙丗丝不丈东:  val_6);
        }
        
        SettingsController.一东三世丅世且丁东(与专一业丏三丒万下:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丕丒上丄丒业丕丕丐:  0);
    }
    private void 不三丑丗丈丐丄丒七(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(与丂丏丛丞丞丒丟丄.业丙三不且业丗丐丂() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_6 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "vibro", 丙业与丙丗丝不丈东:  val_6);
        }
        
        与丂丏丛丞丞丒丟丄.丘丒丘专丏东丆业丛(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
    }
    private void 丂丞丗丞丆三丐三丒(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        bool val_18;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "3D touche button clicked: "("3D touche button clicked: ") + 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString());
        }
        
        if(与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_11 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_11.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "shoot3DTouch", 丙业与丙丗丝不丈东:  val_11);
        }
        
        与丂丏丛丞丞丒丟丄.下一上世专不丙三三(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
        UnityEngine.GameObject val_14 = this.hideJumpAndShootButtons.gameObject;
        if(与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() == false)
        {
            goto label_14;
        }
        
        val_18 = 1;
        if(val_14 != null)
        {
            goto label_19;
        }
        
        goto label_16;
        label_14:
        val_18 = 与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌();
        if(val_14 != null)
        {
            goto label_19;
        }
        
        label_16:
        label_19:
        val_14.SetActive(value:  val_18);
    }
    private void 东且世丐不上业一丑(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_6 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "autoFire", 丙业与丙丗丝不丈东:  val_6);
            PGCompany.Analytics.一业丗丆世世上丁且.丒专丕东万业丆专东(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丝三丄专丗丞丄丄丌:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丁丅丈丌丟世丗丗丟:  "Autofire", 丑东与丅丐丅丂丞业:  "Settings");
        }
        
        与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
    }
    private void 丒丙丆一万万一丂七(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_6 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "tragetting", 丙业与丙丗丝不丈东:  val_6);
            PGCompany.Analytics.一业丗丆世世上丁且.丒专丕东万业丆专东(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丝三丄专丗丞丄丄丌:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟(), 丁丅丈丌丟世丗丗丟:  "Autoaim", 丑东与丅丐丅丂丞业:  "Settings");
        }
        
        与丂丏丛丞丞丒丟丄.且丒丅丘丝上丏丒丏(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
    }
    private void 丄丏丏七一丘丘业丌(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        bool val_18;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "3D touche button clicked: "("3D touche button clicked: ") + 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString());
        }
        
        if(与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_11 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_11.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "jump3DTouch", 丙业与丙丗丝不丈东:  val_11);
        }
        
        与丂丏丛丞丞丒丟丄.丁万不丝丂丁与丌丑(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
        UnityEngine.GameObject val_14 = this.hideJumpAndShootButtons.gameObject;
        if(与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() == false)
        {
            goto label_14;
        }
        
        val_18 = 1;
        if(val_14 != null)
        {
            goto label_19;
        }
        
        goto label_16;
        label_14:
        val_18 = 与丂丏丛丞丞丒丟丄.与丙丟丈不七与丄丌();
        if(val_14 != null)
        {
            goto label_19;
        }
        
        label_16:
        label_19:
        val_14.SetActive(value:  val_18);
    }
    private void 丑世一丈丏丒下丞与(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "3D touche button clicked: "("3D touche button clicked: ") + 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString());
        }
        
        if(与丂丏丛丞丞丒丟丄.丗丒丆丗丛丗上丌丂() ^ 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() != false)
        {
                string val_11 = 丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟().ToString();
            val_11.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "hideJpSht", 丙业与丙丗丝不丈东:  val_11);
        }
        
        与丂丏丛丞丞丒丟丄.万丁丘丄万丆三且三(丙业与丙丗丝不丈东:  丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟());
    }

}
