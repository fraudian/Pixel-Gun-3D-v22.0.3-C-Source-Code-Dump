using UnityEngine;
internal sealed class SettingsTabMultimedia : PGBehaviour
{
    // Fields
    private const int 丄丟丞一丙七上世丐 = 5;
    public UISliderCont musicVolumeSlider;
    public UISliderCont soundFXVolumeSlider;
    public UIButton nextAudio;
    public UIButton prevAudio;
    public SettingsToggleButtons fps60ToggleButtons;
    public SettingsToggleButtons chatToggleButtons;
    public SettingsToggleButtons battleEmojiButtons;
    public SettingsToggleButtons inviteLocalToggleButton;
    public SettingsToggleButtons inviteRemoteToggleButton;
    private System.Collections.Generic.List<SettingsTabMultimedia.MusicItem> musicList;
    private int 丌丛业丛三世丗丘且;
    public UILabel musicName;
    private UIButton defSettingsBtn;
    private Rilisoft.ButtonHandler 丗丏下一丙上七丙丙;
    
    // Properties
    private bool 丅上丂丈丒与且丆丗 { get; }
    
    // Methods
    private bool 一丏丕且且业专三丑()
    {
        Rilisoft.LobbyItemsController val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_3 != null)
        {
                return val_3.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "device_1_6"));
        }
        
        return val_3.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "device_1_6"));
    }
    private void OnEnable()
    {
        if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<MusicItem>(丑东与丅丐丅丂丞业:  this.musicList)) != true)
        {
                .丈丛丛丆丆与丒世丑 = MenuBackgroundMusic.丄一丙三丄专丛一丆();
            MusicItem val_5 = System.Linq.Enumerable.FirstOrDefault<MusicItem>(source:  this.musicList, predicate:  new System.Func<MusicItem, System.Boolean>(object:  new SettingsTabMultimedia.与丟业一丈上丅上不(), method:  System.Boolean SettingsTabMultimedia.与丟业一丈上丅上不::丈丆丙丕丆丝三丌与(SettingsTabMultimedia.MusicItem 三丟东丕丄丄下下丑)));
            if(val_5 != null)
        {
                this.丌丛业丛三世丗丘且 = this.musicList.IndexOf(item:  val_5);
            this.musicName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5.localizationKey);
        }
        
        }
        
        this.defSettingsBtn.onClick.Clear();
        this.defSettingsBtn.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void SettingsTabMultimedia::SetDefaultSettings())));
    }
    private void Start()
    {
        this.业丘丒丒丑业下丐丑();
        this.丘上丐世丆丑且丞丒();
        this.丗丏下一丙上七丙丙 = this.fps60ToggleButtons.offButton.GetComponent<Rilisoft.ButtonHandler>();
    }
    private void 业丘丒丒丑业下丐丑()
    {
        var val_10;
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.musicVolumeSlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "musicVolumeSlider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.nextAudio, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "nextAudio"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.prevAudio, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "prevAudio"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.soundFXVolumeSlider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "soundFXVolumeSlider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.chatToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "chatToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.fps60ToggleButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "fps60ToggleButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.battleEmojiButtons, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "battleEmojiButtons"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.inviteLocalToggleButton, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "inviteLocalToggleButton"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.inviteRemoteToggleButton, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabMultimedia.{0} is null", arg0:  "inviteRemoteToggleButton"));
        val_10 = null;
        val_10 = null;
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  MenuBackgroundMusic.丌丂一丛下丒丞丛东, 丄丙下丝丛丒七丂丘:  "MenuBackgroundMusic is null");
    }
    public void SetDefaultSettings()
    {
        var val_10;
        var val_11;
        val_10 = null;
        val_10 = null;
        this.musicVolumeSlider.toggle.Set(丏业丟一东丂东丘丛:  (与丂丏丛丞丞丒丟丄.万七丐丈丗上丗丁业 == true) ? 1 : 0);
        this.soundFXVolumeSlider.toggle.Set(丏业丟一东丂东丘丛:  (与丂丏丛丞丞丒丟丄.丂世三东丄丆七一不 == true) ? 1 : 0);
        this.musicVolumeSlider.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  (与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == true) ? 1 : 0, 丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.业丆东业丆业专万世);
        this.soundFXVolumeSlider.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗(), 丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.丌上丏且万下下专一);
        this.丗丏下一丙上七丙丙.DoClick();
        this.chatToggleButtons.IsChecked = (与丂丏丛丞丞丒丟丄.专七丆丕丟世七一丛 == true) ? 1 : 0;
        val_11 = null;
        val_11 = null;
        this.battleEmojiButtons.IsChecked = (丟丌丁且且世丈丈丟.丗丟丈不丅丌丐下下 == true) ? 1 : 0;
        this.inviteLocalToggleButton.IsChecked = (与丂丏丛丞丞丒丟丄.万丒丕丆丄丛东丈世 == true) ? 1 : 0;
        this.inviteRemoteToggleButton.IsChecked = (与丂丏丛丞丞丒丟丄.且专丁业丛七丝丄东 == true) ? 1 : 0;
        this.丌丛业丛三世丗丘且 = 3;
        this.丞丒丆不万丘丑一丞();
        SettingsWindowManager.丆丕丝丒不丙且丐丗.CloseDefConfirmWindow();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        object val_50;
        IntPtr val_51;
        UnityEngine.Events.UnityAction<System.Boolean> val_52;
        UISliderCont val_53;
        UnityEngine.Events.UnityAction<System.Single> val_54;
        var val_55;
        bool val_56;
        UnityEngine.Events.UnityAction<System.Boolean> val_57;
        UnityEngine.Events.UnityAction<System.Single> val_58;
        var val_59;
        var val_60;
        val_50 = this;
        丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏 val_1 = null;
        val_51 = System.Void SettingsTabMultimedia::丞丛一丙丂世丈丅丗();
        val_1 = new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  val_51);
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  val_1);
        if((UnityEngine.Object.op_Implicit(exists:  this.musicVolumeSlider)) == false)
        {
            goto label_5;
        }
        
        val_52 = System.Delegate.Combine(a:  this.musicVolumeSlider.丑三丘丑丘业丘丌上, b:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SettingsTabMultimedia::丆七七丙下丛下丂丅(bool 与专一业丏三丒万下)));
        if(this.musicVolumeSlider == null)
        {
            goto label_7;
        }
        
        if(val_52 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_52 == null)
        {
            goto label_11;
        }
        
        label_8:
        if(null != null)
        {
                val_52 = 0;
        }
        
        label_11:
        this.musicVolumeSlider.丑三丘丑丘业丘丌上 = val_52;
        val_53 = this.musicVolumeSlider;
        val_54 = System.Delegate.Combine(a:  this.musicVolumeSlider.丝丞丁三丐丌不丄丟, b:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabMultimedia::丂丞丑丐丗丛下与丅(float 丙业与丙丗丝不丈东)));
        if(val_53 == null)
        {
            goto label_13;
        }
        
        if(val_54 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_54 == null)
        {
            goto label_17;
        }
        
        label_14:
        if(null != null)
        {
                val_54 = 0;
        }
        
        label_17:
        this.musicVolumeSlider.丝丞丁三丐丌不丄丟 = val_54;
        val_55 = null;
        val_55 = null;
        val_56 = 与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下;
        val_51 = 0;
        this.musicVolumeSlider.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  (val_56 == true) ? 1 : 0, 丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.业且丞丂一与不七丑());
        label_5:
        if((UnityEngine.Object.op_Implicit(exists:  this.soundFXVolumeSlider)) == false)
        {
            goto label_23;
        }
        
        val_57 = System.Delegate.Combine(a:  this.soundFXVolumeSlider.丑三丘丑丘业丘丌上, b:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SettingsTabMultimedia::丝万丕丟丗业专丂世(bool 与专一业丏三丒万下)));
        if(this.soundFXVolumeSlider == null)
        {
            goto label_25;
        }
        
        if(val_57 != null)
        {
            goto label_26;
        }
        
        goto label_29;
        label_25:
        if(val_57 == null)
        {
            goto label_29;
        }
        
        label_26:
        if(null != null)
        {
                val_57 = 0;
        }
        
        label_29:
        this.soundFXVolumeSlider.丑三丘丑丘业丘丌上 = val_57;
        val_53 = this.soundFXVolumeSlider;
        val_58 = System.Delegate.Combine(a:  this.soundFXVolumeSlider.丝丞丁三丐丌不丄丟, b:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void SettingsTabMultimedia::丕不丕业丆丄丂业丆(float 丙业与丙丗丝不丈东)));
        if(val_53 == null)
        {
            goto label_31;
        }
        
        if(val_58 != null)
        {
            goto label_32;
        }
        
        goto label_35;
        label_31:
        if(val_58 == null)
        {
            goto label_35;
        }
        
        label_32:
        if(null != null)
        {
                val_58 = 0;
        }
        
        label_35:
        this.soundFXVolumeSlider.丝丞丁三丐丌不丄丟 = val_58;
        val_56 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        val_51 = 0;
        this.soundFXVolumeSlider.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  val_56, 丛丁三世世丆七不业:  与丂丏丛丞丞丒丟丄.丁下丐丏丕丐丏丟丈());
        label_23:
        if(((UnityEngine.Object.op_Implicit(exists:  this.nextAudio)) == false) || ((UnityEngine.Object.op_Implicit(exists:  this.prevAudio)) == false))
        {
            goto label_44;
        }
        
        val_53 = 1152921505171275776;
        val_59 = null;
        val_59 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == false)
        {
            goto label_47;
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_59 = 0;
        }
        
        var val_21 = (~val_59.丏丐丑专丘丂世丁一()) & 1;
        if(this.prevAudio != null)
        {
            goto label_101;
        }
        
        label_102:
        label_101:
        val_60 = null;
        val_60 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == false)
        {
            goto label_52;
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_60 = 0;
        }
        
        val_56 = (~val_60.丏丐丑专丘丂世丁一()) & 1;
        if(this.nextAudio != null)
        {
            goto label_103;
        }
        
        label_104:
        label_103:
        label_44:
        if((UnityEngine.Object.op_Implicit(exists:  this.chatToggleButtons)) != false)
        {
                this.chatToggleButtons.IsChecked = 与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万().世三丞丅丑丌丈丈一();
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_27 = null;
            val_56 = val_27;
            val_27 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabMultimedia::丟业上丗丝丛丟专丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世));
            this.chatToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  val_27);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.fps60ToggleButtons)) != false)
        {
                this.fps60ToggleButtons.IsChecked = (~丟丌丁且且世丈丈丟.丆丛丏丛丟丁丁万三()) & 1;
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_31 = null;
            val_56 = val_31;
            val_31 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabMultimedia::丛丟世丁下丒丂丞一(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世));
            this.fps60ToggleButtons.add_Clicked(丙业与丙丗丝不丈东:  val_31);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.battleEmojiButtons)) != false)
        {
                this.battleEmojiButtons.IsChecked = 丟丌丁且且世丈丈丟.且三丏上七业丙丅丆();
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_35 = null;
            val_56 = val_35;
            val_35 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabMultimedia::丐丆与丒东丝丙东下(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世));
            this.battleEmojiButtons.add_Clicked(丙业与丙丗丝不丈东:  val_35);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.inviteLocalToggleButton)) != false)
        {
                this.inviteLocalToggleButton.IsChecked = 与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏();
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_39 = null;
            val_56 = val_39;
            val_39 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabMultimedia::丅世丌上丁专东丐丐(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世));
            this.inviteLocalToggleButton.add_Clicked(丙业与丙丗丝不丈东:  val_39);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.inviteRemoteToggleButton)) == false)
        {
                return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                label_98:
            this.inviteRemoteToggleButton.gameObject.SetActive(value:  true);
            this.inviteRemoteToggleButton.IsChecked = 与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝();
            System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> val_45 = null;
            val_56 = val_45;
            val_45 = new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void SettingsTabMultimedia::业丌丝业丘丅世七七(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世));
            this.inviteRemoteToggleButton.add_Clicked(丙业与丙丗丝不丈东:  val_45);
            return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
                if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2)
        {
            goto label_98;
        }
        
        }
        
        val_50 = this.inviteRemoteToggleButton.gameObject;
        val_50.SetActive(value:  false);
        return;
        label_47:
        if(this.prevAudio != null)
        {
            goto label_101;
        }
        
        goto label_102;
        label_52:
        if(this.nextAudio != null)
        {
            goto label_103;
        }
        
        goto label_104;
    }
    private void 丆七七丙下丛下丂丅(bool 与专一业丏三丒万下)
    {
        bool val_23;
        var val_24;
        UnityEngine.Object val_26;
        var val_27;
        var val_28;
        MenuBackgroundMusic val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_23 = 与专一业丏三丒万下;
        val_24 = null;
        val_24 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 != val_23)
        {
                与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 = val_23;
            string val_1 = val_23.ToString();
            val_1.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "music", 丙业与丙丗丝不丈东:  val_1);
            丛丌丙丂丑丞丂丏丟.万丞上丘丗丆丙一丑(丒丘丏上丙丟丑丕丈:  丛丌丙丂丑丞丂丏丟.丏丏丌下丑三丐与东(), 丂且与下丘丅丟丈丕:  与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下);
            UnityEngine.PlayerPrefs.Save();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nextAudio)) == false)
        {
            goto label_11;
        }
        
        val_26 = this.prevAudio;
        if((UnityEngine.Object.op_Implicit(exists:  val_26)) == false)
        {
            goto label_11;
        }
        
        if(val_23 == false)
        {
            goto label_12;
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_26 = 0;
        }
        
        val_23 = (~val_26.丏丐丑专丘丂世丁一()) & 1;
        if(this.prevAudio != null)
        {
            goto label_53;
        }
        
        label_54:
        label_53:
        val_27 = this.prevAudio;
        if(val_23 == false)
        {
            goto label_15;
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_27 = 0;
        }
        
        var val_7 = (~val_27.丏丐丑专丘丂世丁一()) & 1;
        if(this.nextAudio != null)
        {
            goto label_55;
        }
        
        label_56:
        label_55:
        label_11:
        val_28 = null;
        val_28 = null;
        val_29 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
        if((UnityEngine.Object.op_Implicit(exists:  val_29)) == false)
        {
                return;
        }
        
        if(val_29 == null)
        {
            goto label_23;
        }
        
        if(val_23 == false)
        {
            goto label_24;
        }
        
        label_42:
        val_29.三且世三丂七丐一丟();
        if(FreePlayThematicSoundsController.丑七不且上丗丁一世() != 0)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  FreePlayThematicSoundsController.丑七不且上丗丁一世().与丄下丗且丙东丆丒())) == false)
        {
            goto label_31;
        }
        
        }
        
        val_23 = 1152921505037090816;
        val_30 = null;
        val_30 = null;
        if(BackgroundMusicController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        val_29.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁());
        return;
        label_23:
        if(val_23 == true)
        {
            goto label_42;
        }
        
        label_24:
        val_29.丌丄丏下七丁专丂世();
        val_23 = 1152921505037090816;
        val_32 = null;
        val_32 = null;
        if(BackgroundMusicController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_33 = null;
        val_33 = null;
        val_29.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁());
        return;
        label_12:
        if(this.prevAudio != null)
        {
            goto label_53;
        }
        
        goto label_54;
        label_15:
        if(this.nextAudio != null)
        {
            goto label_55;
        }
        
        goto label_56;
        label_31:
        val_29 = FreePlayThematicSoundsController.丑七不且上丗丁一世();
        val_29.且丕上丙东专万丝业(七不丐下丟专业万丅:  FreePlayThematicSoundsController.丑七不且上丗丁一世().与丄下丗且丙东丆丒());
    }
    private void 丝万丕丟丗业专丂世(bool 与专一业丏三丒万下)
    {
        bool val_9 = 与专一业丏三丒万下;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() ^ val_9 == false)
        {
                return;
        }
        
        与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  val_9 = 与专一业丏三丒万下);
        string val_5 = val_9.ToString();
        val_5.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sound", 丙业与丙丗丝不丈东:  val_5);
        val_9 = 丛丌丙丂丑丞丂丏丟.丏丏丌丆丞丂丆不丗();
        丛丌丙丂丑丞丂丏丟.万丞上丘丗丆丙一丑(丒丘丏上丙丟丑丕丈:  val_9, 丂且与下丘丅丟丈丕:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗());
        UnityEngine.PlayerPrefs.Save();
    }
    private void 丂丞丑丐丗丛下与丅(float 丙业与丙丗丝不丈东)
    {
        与丂丏丛丞丞丒丟丄.业丏东丌丐丑丗丑业(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        MenuBackgroundMusic.专下丆丞一丆丏丂东(与丁万东丌丑下丏丕:  丙业与丙丗丝不丈东);
    }
    private void 丕不丕业丆丄丂业丆(float 丙业与丙丗丝不丈东)
    {
        与丂丏丛丞丞丒丟丄.业业丞丂丕上世丅丕(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 与东丕东且丑与丁丐(string 丌丁不丙丑丑丝丆丌, string 丙业与丙丗丝不丈东)
    {
        0.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  丌丁不丙丑丑丝丆丌, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void NextAudio()
    {
        bool val_1 = 丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<MusicItem>(丑东与丅丐丅丂丞业:  this.musicList);
        if(val_1 != false)
        {
                return;
        }
        
        if(this.丌丛业丛三世丗丘且 >= 4)
        {
                if(val_1.一丏丕且且业专三丑() == false)
        {
            goto label_8;
        }
        
        }
        
        int val_3 = this.丌丛业丛三世丗丘且 + 1;
        if(((val_3 & 2147483648) == 0) && (val_3 < this.musicList.Count))
        {
                int val_5 = this.丌丛业丛三世丗丘且;
            val_5 = val_5 + 1;
            this.丌丛业丛三世丗丘且 = val_5;
        }
        else
        {
                label_8:
            this.丌丛业丛三世丗丘且 = 0;
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
        
        int val_2 = this.丌丛业丛三世丗丘且 - 1;
        if((val_2 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        val_7 = this.musicList;
        if(val_2 >= val_7.Count)
        {
            goto label_6;
        }
        
        val_8 = this.丌丛业丛三世丗丘且 - 1;
        goto label_10;
        label_6:
        if(val_1.一丏丕且且业专三丑() != false)
        {
                val_8 = this.musicList.Count - 1;
        }
        else
        {
                val_8 = 4;
        }
        
        label_10:
        this.丌丛业丛三世丗丘且 = val_8;
        this.丞丒丆不万丘丑一丞();
    }
    private void 丞丒丆不万丘丑一丞()
    {
        MusicItem val_1 = this.一专丞与丙丟丁业世();
        this.musicName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1.localizationKey);
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  val_1.musicName, 七丆丟丗世丟且丒丆:  false, 丝下丘下丈一丞丄丄:  true, 丆与丈丏丟七丁东丛:  0);
    }
    private void 丟业上丗丝丛丟专丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世)
    {
        if((丒七丞丞世一丒丈且<System.Boolean>.万丌专丅丘丘丟万东(一不丝丟世业丑丙一:  与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万(), 丘丑丛丕下丈世下丂:  丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟())) != false)
        {
                string val_7 = 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟().ToString();
            val_7.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "chat", 丙业与丙丗丝不丈东:  val_7);
        }
        
        bool val_8 = 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟();
        val_8.丞丝丝世丕下丌专丁(丂丛不丐丏丂丕丙丞:  val_8, 丟丟丟三东丛丌丘且:  0);
    }
    private void 丞丝丝世丕下丌专丁(bool 丂丛不丐丏丂丕丙丞, System.Action 丟丟丟三东丛丌丘且)
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
    private void 丐丆与丒东丝丙东下(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世)
    {
        if(丟丌丁且且世丈丈丟.且三丏上七业丙丅丆() ^ 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟() != false)
        {
                string val_6 = 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟().ToString();
            val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "battleEmoji", 丙业与丙丗丝不丈东:  val_6);
        }
        
        丟丌丁且且世丈丈丟.丏专丟丟丈与丄专且(丙业与丙丗丝不丈东:  丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟());
    }
    private void 丅世丌上丁专东丐丐(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世)
    {
        bool val_17;
        bool val_18;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() ^ 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟() != false)
        {
                string val_8 = 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟().ToString();
            val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "ingameNotif", 丙业与丙丗丝不丈东:  val_8);
        }
        
        val_17 = 丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟();
        val_18 = val_17;
        与丂丏丛丞丞丒丟丄.丟专丈上丒丝万下丟(丙业与丙丗丝不丈东:  val_18);
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_18 = 0;
        }
        
        if(val_18.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_17 = "[SettingsTabMultimedia.inviteLocalToggleButton] isEnableLocalInviteFromFriends: "("[SettingsTabMultimedia.inviteLocalToggleButton] isEnableLocalInviteFromFriends: ") + 与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏().ToString() + " -> "(" -> ") + 与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏().ToString();
        UnityEngine.Debug.Log(message:  val_17);
    }
    private void 业丌丝业丘丅世七七(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世)
    {
        UnityEngine.Object val_23;
        UnityEngine.Object val_24;
        val_23 = 丁且丁丝丅丒丘不世;
        val_24 = val_23;
        if(与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝() ^ val_24.且丂丅丁与丟丒丛丟() != false)
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
            val_24 = val_23;
            if(val_24 != 0)
        {
                val_23 = RemotePushNotificationController.丑七不且上丗丁一世();
            val_24 = val_23;
            val_24.丂丟世三丞丒丈丆丅(丑丞东万丁丂丏万丙:  "SettingsTabMultimedia");
        }
        
        }
        
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == null)
        {
                val_24 = 0;
        }
        
        if(val_24.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_23 = "[SettingsTabMultimedia.inviteRemoteToggleButton] isEnableRemoteInviteFromFriends: "("[SettingsTabMultimedia.inviteRemoteToggleButton] isEnableRemoteInviteFromFriends: ") + 与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝().ToString() + " -> "(" -> ") + 与丂丏丛丞丞丒丟丄.丛世丁三丈丟丟万丝().ToString();
        UnityEngine.Debug.Log(message:  val_23);
    }
    private void 丛丟世丁下丒丂丞一(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丁且丁丝丅丒丘不世)
    {
        if(丁且丁丝丅丒丘不世 != null)
        {
                var val_7 = ~丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟();
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
        
        丟丌丁且且世丈丈丟.丄丝一下丅业世万丄(丙业与丙丗丝不丈东:  (~丁且丁丝丅丒丘不世.且丂丅丁与丟丒丛丟()) & 1);
    }
    private void 不丁丅丒丗丁专丌三()
    {
        string val_3;
        if(this.一专丞与丙丟丁业世() != null)
        {
                val_3 = val_1.localizationKey;
        }
        else
        {
                val_3 = 0;
        }
        
        this.musicName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3);
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.不丁丅丒丗丁专丌三();
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SettingsTabMultimedia::丞丛一丙丂世丈丅丗()));
    }
    private SettingsTabMultimedia.MusicItem 一专丞与丙丟丁业世()
    {
        int val_3;
        var val_4;
        val_3 = this;
        if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<MusicItem>(丑东与丅丐丅丂丞业:  this.musicList)) != false)
        {
                val_4 = 0;
            return (MusicItem)this.musicList.Item[val_3];
        }
        
        val_3 = this.丌丛业丛三世丗丘且;
        return (MusicItem)this.musicList.Item[val_3];
    }
    public SettingsTabMultimedia()
    {
    
    }

}
