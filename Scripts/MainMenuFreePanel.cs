using UnityEngine;
internal sealed class MainMenuFreePanel : MonoBehaviour
{
    // Fields
    private UIGrid _socialButtonsGrid;
    private UIButton _discordButton;
    private UIButton _vkButton;
    private Rilisoft.ButtonHandler _backButton;
    private float 与三三业且丟且且与;
    private Rilisoft.ButtonHandler _facebookSubcribeButton;
    private UnityEngine.GameObject _facebookLoginButton;
    private Rilisoft.ButtonHandler _emailSubcribeButton;
    private UnityEngine.GameObject _emailSubcribePrice;
    private UILabel _emailSubcribePriceLabel;
    private UnityEngine.GameObject _emailSubcribeLabelOnBtn;
    private UnityEngine.GameObject _emailSubcribeWaitingLabelOnBtn;
    private Rilisoft.ButtonHandler _instagramSubcribeButton;
    private Rilisoft.ButtonHandler _postFacebookButton;
    private UnityEngine.GameObject _postNewsLabel;
    private Rilisoft.ButtonHandler _postTwitterButton;
    private Rilisoft.ButtonHandler _rateUsButton;
    private UnityEngine.Transform _socialButtonsPosition;
    private UILabel _socialGunEventTimerLabel;
    private UnityEngine.GameObject _socialGunPanel;
    private UnityEngine.GameObject _starParticleSocialGunButton;
    private Rilisoft.ButtonHandler _twitterSubcribeButton;
    private Rilisoft.ButtonHandler _youtubeButton;
    public UnityEngine.Transform _settingsPanel;
    public UnityEngine.GameObject _emailSubscribePrefab;
    internal static bool 丄丂丘丑万东七不丘;
    private EmailInputPanel 丅丝万丛丁且上丘下;
    
    // Properties
    internal EmailInputPanel 不丘一七丒丒丅丗上 { get; }
    
    // Methods
    internal EmailInputPanel 丄世丒丗一东丘丒丂()
    {
        if(this.丅丝万丛丁且上丘下 != 0)
        {
                return (EmailInputPanel)this.丅丝万丛丁且上丘下;
        }
        
        if(this._emailSubscribePrefab == 0)
        {
                return (EmailInputPanel)this.丅丝万丛丁且上丘下;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._emailSubscribePrefab);
        val_3.transform.parent = this._settingsPanel;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        val_3.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        1152921504848912384 = val_3.transform;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        1152921504848912384.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        this.丅丝万丛丁且上丘下 = val_3.GetComponent<EmailInputPanel>();
        return (EmailInputPanel)this.丅丝万丛丁且上丘下;
    }
    private void Start()
    {
        var val_24;
        if(this._postNewsLabel != 0)
        {
                this._postNewsLabel.SetActive(value:  false);
        }
        
        if(this._youtubeButton != 0)
        {
                this._youtubeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::丄丝丈下业丒丕丒上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._postFacebookButton != 0)
        {
                this._postFacebookButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::世丛七丛丏三丘万丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._postTwitterButton != 0)
        {
                this._postTwitterButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::丕丆丁且且三上丝一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._rateUsButton != 0)
        {
                this._rateUsButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::丘丛丘不业丁丛丘丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._twitterSubcribeButton != 0)
        {
                this._twitterSubcribeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::丙业丐丑丂丟上万上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._facebookSubcribeButton != 0)
        {
                this._facebookSubcribeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::七丙丂丏丅丛且丄丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._instagramSubcribeButton != 0)
        {
                this._instagramSubcribeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::万丌东丗丏且丑丂丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._emailSubcribeButton != 0)
        {
                this._emailSubcribeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuFreePanel::专丌万且世东下丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this._backButton == 0)
        {
            goto label_39;
        }
        
        val_24 = null;
        val_24 = null;
        if((MainMenuFreePanel.<>c.<>9__29_0) == null)
        {
            goto label_42;
        }
        
        label_49:
        this._backButton.add_Clicked(丙业与丙丗丝不丈东:  MainMenuFreePanel.<>c.<>9__29_0);
        label_39:
        丁且丂丈丕三一丝丐.丑七不且上丗丁一世().与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuFreePanel::三丈七丙丒丟丆丒丏()));
        丁且丂丈丕三一丝丐.丑七不且上丗丁一世().七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuFreePanel::三丈七丙丒丟丆丒丏()));
        this.三丈七丙丒丟丆丒丏();
        return;
        label_42:
        MainMenuFreePanel.<>c.<>9__29_0 = new System.EventHandler(object:  MainMenuFreePanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuFreePanel.<>c::丑东不丐丕一专丙丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        if(this._backButton != null)
        {
            goto label_49;
        }
        
        goto label_49;
    }
    private void OnDestroy()
    {
        丁且丂丈丕三一丝丐.丑七不且上丗丁一世().与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuFreePanel::三丈七丙丒丟丆丒丏()));
    }
    private void 三丈七丙丒丟丆丒丏()
    {
        专一东丂不丌不丛丏 val_16 = 4;
        val_16 = 丁且丂丈丕三一丝丐.丑七不且上丗丁一世().丟一下丏且专上丏丛(丟丒丞丐丐丘丒丄东:  val_16);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._youtubeButton, 丏业丟一东丂东丘丛:  val_16);
        专一东丂不丌不丛丏 val_17 = 1;
        val_17 = 丁且丂丈丕三一丝丐.丑七不且上丗丁一世().丟一下丏且专上丏丛(丟丒丞丐丐丘丒丄东:  val_17);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._facebookSubcribeButton, 丏业丟一东丂东丘丛:  val_17);
        专一东丂不丌不丛丏 val_18 = 6;
        val_18 = 丁且丂丈丕三一丝丐.丑七不且上丗丁一世().丟一下丏且专上丏丛(丟丒丞丐丐丘丒丄东:  val_18);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._vkButton, 丏业丟一东丂东丘丛:  val_18);
        专一东丂不丌不丛丏 val_19 = 2;
        val_19 = 丁且丂丈丕三一丝丐.丑七不且上丗丁一世().丟一下丏且专上丏丛(丟丒丞丐丐丘丒丄东:  val_19);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._instagramSubcribeButton, 丏业丟一东丂东丘丛:  val_19);
        专一东丂不丌不丛丏 val_20 = 3;
        val_20 = 丁且丂丈丕三一丝丐.丑七不且上丗丁一世().丟一下丏且专上丏丛(丟丒丞丐丐丘丒丄东:  val_20);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._twitterSubcribeButton, 丏业丟一东丂东丘丛:  val_20);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._discordButton, 丏业丟一东丂东丘丛:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().丟一下丏且专上丏丛(丟丒丞丐丐丘丒丄东:  5));
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.丟丗东丝世丑丙丛丐());
    }
    private System.Collections.IEnumerator 丟丗东丝世丑丙丛丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuFreePanel.丂丘业丟丝丒不丄一();
    }
    internal void 丈丝丞业丗且丑且万()
    {
        UnityEngine.GameObject val_13;
        UnityEngine.GameObject val_14;
        var val_15;
        int val_16;
        var val_17;
        val_13 = this;
        丙丟与丐三丐万万丆 val_2 = 丆与丞丈下丄丐专丛.丑七不且上丗丁一世().万丘三丘下与与且业();
        if((UnityEngine.Object.op_Implicit(exists:  this._emailSubcribeButton)) == false)
        {
            goto label_34;
        }
        
        val_14 = 1152921505171275776;
        if((val_2 == 2) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
        {
            goto label_31;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = BalanceController.丏丂丙与丝上不专东;
        if(val_16 != 2)
        {
            goto label_13;
        }
        
        label_34:
        val_14 = this._emailSubcribeLabelOnBtn;
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) == false)
        {
                return;
        }
        
        val_14 = this._emailSubcribeWaitingLabelOnBtn;
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) == false)
        {
                return;
        }
        
        val_14 = this._emailSubcribePrice;
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) == false)
        {
                return;
        }
        
        val_14 = this._emailSubcribeLabelOnBtn;
        if(val_2 != 1)
        {
            goto label_24;
        }
        
        val_14.SetActive(value:  false);
        this._emailSubcribeWaitingLabelOnBtn.SetActive(value:  true);
        val_13 = this._emailSubcribePrice;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
        return;
        label_13:
        val_16 = BalanceController.丏丂丙与丝上不专东;
        if(val_16 == 1)
        {
                if(与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专() == true)
        {
            goto label_34;
        }
        
        }
        
        label_31:
        val_13 = this._emailSubcribeButton.gameObject;
        val_13.SetActive(value:  false);
        return;
        label_24:
        val_14.SetActive(value:  true);
        this._emailSubcribeWaitingLabelOnBtn.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._emailSubcribePrice, 丏业丟一东丂东丘丛:  true);
        if((UnityEngine.Object.op_Implicit(exists:  this._emailSubcribePriceLabel)) == false)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        this._emailSubcribePriceLabel.text = BalanceController.丟不丌七丝七东丞业.丟丂丞不专丆万丒世().ToString();
    }
    private void 专丌万且世东下丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        UnityEngine.GameObject val_12 = this;
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if(((-664481716) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丙丟与丐三丐万万丆 val_5 = 丆与丞丈下丄丐专丛.丑七不且上丗丁一世().万丘三丘下与与且业();
        if(val_5 != 1)
        {
                if(val_5 != 0)
        {
                return;
        }
        
            val_12 = this.丄世丒丗一东丘丒丂();
            val_12.丏丈丒丕丂丏业世丄();
            Rilisoft.一丟专且三万丞丁丂.专丕丒万业一丑丗丙(丝丏业丅丈东业丝丒:  "Tap Subscribe");
            return;
        }
        
        EmailInputPanel val_7 = this.丄世丒丗一东丘丒丂();
        val_7.waiting_email.text = System.String.Format(format:  "{0}", arg0:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  丆与丞丈下丄丐专丛.丕丅丌丁丆丙业丁万()));
        EmailInputPanel val_11 = this.丄世丒丗一东丘丒丂();
        val_12 = val_11.waitPanel;
        val_12.SetActive(value:  true);
    }
    private void Update()
    {
        bool val_28;
        var val_29;
        var val_30;
        Rilisoft.ButtonHandler val_31;
        if((BankController.丑七不且上丗丁一世() != 0) && (BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false))
        {
                val_28 = 0;
        }
        else
        {
                val_28 = (~ShopNGUIController.丛世丛与丌不丈丐丐()) & 1;
        }
        
        if(this._starParticleSocialGunButton != 0)
        {
                if(val_28 != this._starParticleSocialGunButton.activeInHierarchy)
        {
                this._starParticleSocialGunButton.SetActive(value:  val_28);
        }
        
        }
        
        if((FacebookController.且丈丄一丁丞丒丑东() != false) && (FacebookController.丘七下丂上一丅三丏() != false))
        {
                val_29 = Facebook.Unity.FB.IsLoggedIn;
        }
        else
        {
                val_29 = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this._postFacebookButton)) != false)
        {
                if(val_29 != this._postFacebookButton.gameObject.activeSelf)
        {
                this._postFacebookButton.gameObject.SetActive(value:  false);
        }
        
        }
        
        if((TwitterController.上业丗丛三丕丒丗丙() != false) && (TwitterController.丂丌与下丛丑丂丐丘() != false))
        {
                val_30 = TwitterController.丒丆世一与丁丛丐下();
        }
        else
        {
                val_30 = 0;
        }
        
        val_31 = this._postTwitterButton;
        if((UnityEngine.Object.op_Implicit(exists:  val_31)) == false)
        {
                return;
        }
        
        val_31 = this._postTwitterButton.gameObject;
        if(val_30 == val_31.activeSelf)
        {
                return;
        }
        
        this._postTwitterButton.gameObject.SetActive(value:  false);
    }
    public void OnEnable()
    {
        bool val_3;
        var val_4;
        var val_5;
        if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != false)
        {
                val_3 = 0;
        }
        else
        {
                val_4 = null;
            val_4 = null;
            val_3 = BalanceController.丄业丑东丞丞丏丏丂;
        }
        
        bool val_2 = (val_3 == true) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._facebookLoginButton, 丏业丟一东丂东丘丛:  val_2);
        this.丈丝丞业丗且丑且万();
        val_5 = null;
        val_5 = null;
        if(MainMenuFreePanel.丄丂丘丑万东七不丘 != false)
        {
                this.专丌万且世东下丌专(不丟丗丏丛丕不丁丌:  val_2, 丗丛不丁丑专专丂且:  0);
            val_5 = null;
        }
        
        val_5 = null;
        MainMenuFreePanel.丄丂丘丑万东七不丘 = false;
    }
    public void SetVisible(bool 下下东且万业丞丅丒)
    {
        if(this.gameObject.activeSelf ^ 下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  下下东且万业丞丅丒);
    }
    public void OnSocialGunButtonClicked()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.OnSocialGunEventButtonClick();
    }
    private void 丄丝丈下业丒丕丒上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_2 = TrainingController.万丑万专丑三专丏丟();
        if(((-663700516) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  4);
        UnityEngine.Application.OpenURL(url:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().一专且丙一丞丅上世(丟丒丞丐丐丘丒丄东:  4));
    }
    public void HandleVKClicked()
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_2 = TrainingController.万丑万专丑三专丏丟();
        if(((-663547556) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  6);
        UnityEngine.Application.OpenURL(url:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().一专且丙一丞丅上世(丟丒丞丐丐丘丒丄东:  6));
    }
    public void HandleDiscordClicked()
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_2 = TrainingController.万丑万专丑三专丏丟();
        if(((-663402788) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  5);
        UnityEngine.Application.OpenURL(url:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().一专且丙一丞丅上世(丟丒丞丐丐丘丒丄东:  5));
    }
    private void 世丛七丛丏三丘万丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if(((-663262116) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        FacebookController.七丒万丒丘东世丌上();
    }
    private void 丕丆丁且且三上丝一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        ButtonClickSound val_7;
        var val_8;
        var val_9;
        val_7 = 1152921505080860672;
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if(((-663125316) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_7 = ButtonClickSound.丆丕丝丒不丙且丐丗;
        val_7.PlayClick();
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        val_8 = null;
        val_8 = null;
        val_7 = TwitterController.丗丘丒丈专丘丕世与;
        if(val_7 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = TwitterController.丗丘丒丈专丘丕世与;
        val_7.丑与东丒七丁丝三丁(丝丝不丝上丂三丌世:  "Come and play with me in epic multiplayer shooter - Pixel Gun 3D! http://goo.gl/dQMf4n", 丟不丌丁一丆业且丝:  0);
    }
    private void 丘丛丘不业丁丛丘丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        MainMenuController.丄丞丁丈与业上丞丟.RateUs();
    }
    private void 丙业丐丑丂丟上万上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_2 = TrainingController.万丑万专丑三专丏丟();
        if(((-662848052) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  3);
        UnityEngine.Application.OpenURL(url:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().一专且丙一丞丅上世(丟丒丞丐丐丘丒丄东:  3));
    }
    private void 七丙丂丏丅丛且丄丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_2 = TrainingController.万丑万专丑三专丏丟();
        if(((-662686900) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  1);
        UnityEngine.Application.OpenURL(url:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().一专且丙一丞丅上世(丟丒丞丐丐丘丒丄东:  1));
    }
    private void 万丌东丗丏且丑丂丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_2 = TrainingController.万丑万专丑三专丏丟();
        if(((-662525748) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.三一丅丂丙丈丈三且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟丒丞丐丐丘丒丄东:  2);
        UnityEngine.Application.OpenURL(url:  丁且丂丈丕三一丝丐.丑七不且上丗丁一世().一专且丙一丞丅上世(丟丒丞丐丐丘丒丄东:  2));
    }
    public MainMenuFreePanel()
    {
    
    }
    private static MainMenuFreePanel()
    {
    
    }

}
