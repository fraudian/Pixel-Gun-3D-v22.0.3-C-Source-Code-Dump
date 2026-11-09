using UnityEngine;
internal sealed class ChooseLevel : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject BonusGun3Box;
    public UnityEngine.GameObject BonusHead4Box;
    public UnityEngine.GameObject panel;
    public UnityEngine.GameObject[] starEnabledPrototypes;
    public UnityEngine.GameObject[] starDisabledPrototypes;
    public UnityEngine.GameObject gainedStarCountLabel;
    public UnityEngine.GameObject backButton;
    public Rilisoft.BankShopViewGuiElement shopView;
    public Rilisoft.ButtonHandler nextButton;
    public UnityEngine.GameObject[] boxOneLevelButtons;
    public UnityEngine.GameObject[] boxTwoLevelButtons;
    public UnityEngine.GameObject[] boxThreeLevelButtons;
    public UnityEngine.GameObject[] boxFourLevelButtons;
    public UnityEngine.AudioClip shopButtonSound;
    public UnityEngine.GameObject backgroundHolder;
    public UnityEngine.GameObject backgroundHolder_2;
    public UnityEngine.GameObject backgroundHolder_3;
    public UnityEngine.GameObject backgroundHolder_4;
    public UnityEngine.GameObject[] boxContents;
    internal static ChooseLevel 丙业三丄世业一丝且;
    private float 上丙丐丗业丆七世丐;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private int 丄与东丒丈一丑丝不;
    private UnityEngine.GameObject[] 丒丏丐三丅专丘专丏;
    private string 丈丂丑上且丁七七丈;
    private System.Collections.Generic.IList<ChooseLevel.与丗丁丈丆不丗丕丙> 丂丒与丕丝丂与万万;
    public ShopNGUIController _shopInstance;
    private float 丒专丟丝丝丏与丗丌;
    
    // Methods
    private void Awake()
    {
        ShopNGUIController.万丟丂与业丟丘一一();
    }
    private void Start()
    {
        var val_27;
        var val_28;
        var val_29;
        var val_31;
        UnityEngine.GameObject[] val_32;
        UnityEngine.GameObject val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        ExperienceController.丞与丛一上丏丏东三();
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "In Map");
        var val_26 = 0;
        val_26 = val_26 + 1;
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Clear();
        val_27 = null;
        val_27 = null;
        ChooseLevel.丙业三丄世业一丝且 = this;
        this.上丙丐丗业丆七世丐 = UnityEngine.Time.realtimeSinceStartup;
        val_28 = null;
        val_28 = null;
        val_29 = null;
        val_29 = null;
        if((ChooseLevel.<>c.<>9__23_0) == null)
        {
            goto label_20;
        }
        
        label_44:
        int val_6 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.FindIndex(match:  ChooseLevel.<>c.<>9__23_0);
        this.丄与东丒丈一丑丝不 = val_6;
        if(val_6 == 1)
        {
            goto label_22;
        }
        
        System.Collections.Generic.IList<与丗丁丈丆不丗丕丙> val_7 = ChooseLevel.丂上上丐下丄丄丐丄(丄三丄丈丈丕丂丑专:  false);
        this.丂丒与丕丝丂与万万 = val_7;
        this.丈丂丑上且丁七七丈 = ChooseLevel.丒上七上丒丄丝丏丞(不丕专丘且丐与三丂:  val_7);
        val_31 = null;
        val_31 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  "Real")) == false)
        {
            goto label_29;
        }
        
        val_32 = this.boxOneLevelButtons;
        val_33 = this.backgroundHolder;
        goto label_30;
        label_29:
        val_34 = null;
        val_34 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  "minecraft")) == false)
        {
            goto label_33;
        }
        
        val_32 = this.boxTwoLevelButtons;
        val_33 = this.backgroundHolder_2;
        label_30:
        this.丒丏丐三丅专丘专丏 = val_32;
        label_75:
        label_66:
        val_33.SetActive(value:  true);
        label_80:
        this.丁丝专丟专丈丂万与();
        this.丄七万不丕丙丝丐丐();
        this.丘丗不丂不三丐业万(下上不丏专丄丆业世:  this.丂丒与丕丝丂与万万, 世三万丂丟丄世万上:  this.nextButton);
        丕七丌下与丙丅丆丅.丗丛丅丕丘且丅丈丟();
        if(UnityEngine.Application.platform != 8)
        {
                UnityEngine.PlayerPrefs.Save();
        }
        
        val_35 = null;
        val_35 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
        return;
        label_20:
        ChooseLevel.<>c.<>9__23_0 = new System.Predicate<下与业丆下三丅丅丝>(object:  ChooseLevel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ChooseLevel.<>c::丌与丝丘丛下丙不丑(下与业丆下三丅丅丝 丌丗丏丏丛东专丁且));
        if(下与业丆下三丅丅丝.丏专东丕丘丈不丞三 != null)
        {
            goto label_44;
        }
        
        goto label_44;
        label_33:
        val_36 = null;
        val_36 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  "Crossed")) == false)
        {
            goto label_47;
        }
        
        this.丒丏丐三丅专丘专丏 = this.boxThreeLevelButtons;
        this.backgroundHolder_3.SetActive(value:  true);
        char[] val_16 = new char[1];
        val_16[0] = '#';
        System.String[] val_28 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_16);
        val_37 = 0;
        goto label_55;
        label_62:
        if(val_28[0] == null)
        {
                mem2[0] = System.String.alignConst;
        }
        
        val_37 = 1;
        label_55:
        if(val_37 < val_17.Length)
        {
            goto label_62;
        }
        
        string val_29 = WeaponManager.业丆丝丅丘丙专丐丗();
        val_28 = (System.Linq.Enumerable.Contains<System.String>(source:  val_28, value:  val_29)) ^ 1;
        val_29 = val_28;
        goto label_66;
        label_47:
        val_38 = null;
        val_38 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  "box4")) == false)
        {
            goto label_69;
        }
        
        this.丒丏丐三丅专丘专丏 = this.boxFourLevelButtons;
        this.backgroundHolder_4.SetActive(value:  true);
        var val_23 = (~(Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  "royale_cubic_hat", 丌丒丝东丌下丕丁丅:  1).IsExists)) & 1;
        goto label_75;
        label_69:
        val_39 = null;
        val_39 = null;
        UnityEngine.Debug.LogWarning(message:  "Unknown box: "("Unknown box: ") + 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与);
        goto label_80;
        label_22:
        UnityEngine.Debug.LogWarning(message:  "Box not found in list!");
        System.InvalidOperationException val_25 = new System.InvalidOperationException(message:  "Box not found in list!");
    }
    private void Update()
    {
        bool val_1 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        var val_2 = (this.shopView.InteractionEnabled == true) ? 1 : 0;
        val_2 = val_1 ^ val_2;
        if(val_2 == false)
        {
                return;
        }
        
        this.shopView.InteractionEnabled = val_1;
        this.shopView.丝一丅丆三东丂丞七();
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ChooseLevel::业丂下丐不一业丈丅()), 与且专丈不万东一万:  "Choose Level");
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
    private void 丘丗不丂不三丐业万(System.Collections.Generic.IList<ChooseLevel.与丗丁丈丆不丗丕丙> 下上不丏专丄丆业世, Rilisoft.ButtonHandler 世三万丂丟丄世万上)
    {
        var val_9;
        System.Func<与丗丁丈丆不丗丕丙, System.Boolean> val_11;
        string val_13;
        .丝且与丝丒丟万丁专 = this;
        if(下上不丏专丄丆业世 == null)
        {
            goto label_2;
        }
        
        if(世三万丂丟丄世万上 == 0)
        {
            goto label_5;
        }
        
        val_9 = null;
        val_9 = null;
        val_11 = ChooseLevel.<>c.<>9__28_0;
        if(val_11 == null)
        {
                System.Func<与丗丁丈丆不丗丕丙, System.Boolean> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Func<与丗丁丈丆不丗丕丙, System.Boolean>(object:  ChooseLevel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ChooseLevel.<>c::丟丘丆下丛丅丛丈丛(ChooseLevel.与丗丁丈丆不丗丕丙 丐三丞七丝丅不万丛));
            ChooseLevel.<>c.<>9__28_0 = val_11;
        }
        
        .丈丘丝一丗下丈丐不 = System.Linq.Enumerable.LastOrDefault<与丗丁丈丆不丗丕丙>(source:  下上不丏专丄丆业世, predicate:  val_3);
        世三万丂丟丄世万上.gameObject.SetActive(value:  ((ChooseLevel.丐丐七丈丅丐三且丆)[1152921525703445568].丈丘丝一丗下丈丐不 != 0) ? 1 : 0);
        if((ChooseLevel.丐丐七丈丅丐三且丆)[1152921525703445568].丈丘丝一丗下丈丐不 == null)
        {
                return;
        }
        
        世三万丂丟丄世万上.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  new ChooseLevel.丐丐七丈丅丐三且丆(), method:  System.Void ChooseLevel.丐丐七丈丅丐三且丆::万丕丞上丈丄丛世一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        return;
        label_2:
        val_13 = "levels";
        goto label_15;
        label_5:
        val_13 = "nextButton";
        label_15:
        null = new System.ArgumentNullException(paramName:  val_13);
    }
    private void 丄七万不丕丙丝丐丐()
    {
        System.EventHandler val_10;
        if(this.backButton != 0)
        {
                System.EventHandler val_3 = null;
            val_10 = val_3;
            val_3 = new System.EventHandler(object:  this, method:  System.Void ChooseLevel::专丗丄七丏丕丂丗丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            this.backButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  val_3);
        }
        
        if(this.shopView != 0)
        {
                if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shopView.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                System.EventHandler val_7 = null;
            val_10 = val_7;
            val_7 = new System.EventHandler(object:  this, method:  System.Void ChooseLevel::丆一丛丕丏一丞丟丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞));
            this.shopView.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  val_7);
        }
        
        }
        
        if(this.gainedStarCountLabel == 0)
        {
                return;
        }
        
        this.gainedStarCountLabel.GetComponent<UILabel>().text = this.丈丂丑上且丁七七丈;
    }
    internal static void 万丟丞丗丑一万丅且()
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = null;
        val_1 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        val_2 = null;
        val_2 = null;
        LoadConnectScene.上三丕下一丅丘上丝 = 0;
        LoadConnectScene.丞丗专丝丙专丂上丗 = "CampaignChooseBox";
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        val_3 = null;
        val_3 = null;
        UnityEngine.Application.LoadLevel(name:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟);
    }
    private void 专丗丄七丏丕丂丗丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
    {
        if(this._shopInstance != 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 - this.丒专丟丝丝丏与丗丌;
        if(val_2 < 0)
        {
                return;
        }
        
        ChooseLevel.万丟丞丗丑一万丅且();
    }
    private void 丆一丛丕丏一丞丟丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 专丒丌丆下丐丞丟丞)
    {
        ShopNGUIController val_9;
        var val_10;
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
                return;
        }
        
        val_9 = 1152921504848912384;
        if(this._shopInstance != 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        this._shopInstance = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        this._shopInstance.丝丞与丄丆业丛丏专(丗丛不丁丑专专丂且:  false);
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        if(this.shopButtonSound != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.shopButtonSound);
        }
        
        }
        
        this.panel.gameObject.SetActive(value:  false);
        val_9 = this._shopInstance;
        this._shopInstance.丏丐世且丑丅丘丅丟 = new System.Action(object:  this, method:  System.Void ChooseLevel::丞丈丏丈世丛丒丛丞());
    }
    private void 丞丈丏丈世丛丒丛丞()
    {
        var val_9;
        var val_10;
        var val_11;
        this.panel.gameObject.SetActive(value:  true);
        if(this._shopInstance == 0)
        {
                return;
        }
        
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_9 = null;
        val_9 = null;
        if(ExperienceController.sharedController != 0)
        {
                if(ExpController.丑七不且上丗丁一世() != 0)
        {
                val_10 = null;
            val_10 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
            ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        if((ChooseLevel.<>c.<>9__33_0) == null)
        {
            goto label_26;
        }
        
        label_31:
        this._shopInstance.丏丐世且丑丅丘丅丟 = ChooseLevel.<>c.<>9__33_0;
        this._shopInstance = 0;
        this.丒专丟丝丝丏与丗丌 = UnityEngine.Time.time;
        return;
        label_26:
        ChooseLevel.<>c.<>9__33_0 = new System.Action(object:  ChooseLevel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ChooseLevel.<>c::丆与丘丂上东丘丈万());
        if(this._shopInstance != null)
        {
            goto label_31;
        }
        
        goto label_31;
    }
    private void 丁丝专丟专丈丂万与()
    {
        ChooseLevel val_40;
        UnityEngine.GameObject[] val_41;
        var val_42;
        var val_44;
        var val_46;
        object val_47;
        UnityEngine.GameObject val_48;
        var val_49;
        var val_50;
        var val_51;
        string val_53;
        val_40 = this;
        if((this.starEnabledPrototypes != null) && (this.starEnabledPrototypes.Length >= 1))
        {
                do
        {
            UnityEngine.GameObject val_45 = this.starEnabledPrototypes[0];
            if(val_45 != 0)
        {
                val_45.SetActive(value:  false);
        }
        
        }
        while((0 + 1) < this.starEnabledPrototypes.Length);
        
        }
        
        if((this.starDisabledPrototypes != null) && (this.starDisabledPrototypes.Length >= 1))
        {
                do
        {
            UnityEngine.GameObject val_46 = this.starDisabledPrototypes[0];
            if(val_46 != 0)
        {
                val_46.SetActive(value:  false);
        }
        
        }
        while((0 + 1) < this.starDisabledPrototypes.Length);
        
        }
        
        val_41 = this.boxContents;
        if(val_41 == null)
        {
            goto label_17;
        }
        
        val_42 = 0;
        goto label_18;
        label_23:
        this.boxContents[0].SetActive(value:  (val_42 == this.丄与东丒丈一丑丝不) ? 1 : 0);
        val_41 = this.boxContents;
        val_42 = 1;
        label_18:
        if(val_42 != this.boxContents.Length)
        {
            goto label_23;
        }
        
        if(this.丒丏丐三丅专丘专丏 == null)
        {
            goto label_24;
        }
        
        if(this.丒丏丐三丅专丘专丏.Length >= 1)
        {
                do
        {
            UnityEngine.GameObject val_48 = this.丒丏丐三丅专丘专丏[0];
            if(val_48 != 0)
        {
                bool val_8 = UnityEngine.Object.op_Inequality(x:  val_48.GetComponent<UIButton>(), y:  0);
        }
        
        }
        while((0 + 1) < this.丒丏丐三丅专丘专丏.Length);
        
        }
        
        var val_49 = 0;
        val_49 = val_49 + 1;
        val_44 = 0;
        int val_12 = System.Math.Min(val1:  this.丂丒与丕丝丂与万万.Count, val2:  this.丒丏丐三丅专丘专丏.Length);
        if(val_12 == 0)
        {
            goto label_44;
        }
        
        var val_52 = 0;
        goto label_107;
        label_74:
        X25.applyGradient = (null != 0) ? 1 : 0;
        if((public UIButton UnityEngine.GameObject::GetComponent<UIButton>()) != 0)
        {
            goto label_77;
        }
        
        goto label_48;
        label_107:
        .丝且与丝丒丟万丁专 = val_40;
        var val_50 = 0;
        val_50 = val_50 + 1;
        val_44 = 0;
        T val_16 = this.丂丒与丕丝丂与万万.Item[0];
        UnityEngine.GameObject val_51 = this.丒丏丐三丅专丘专丏[0];
        if(val_51 != null)
        {
                val_46 = val_51.transform;
        }
        else
        {
                val_46 = 0.transform;
        }
        
        val_46.parent = val_51.transform.parent;
        UIButton val_21 = val_51.GetComponent<UIButton>();
        var val_22 = ((val_16 + 16) != 0) ? 1 : 0;
        UISprite val_23 = val_51.GetComponentInChildren<UISprite>();
        if(val_23 != 0)
        {
            goto label_67;
        }
        
        val_47 = "Could not find background of level button.";
        goto label_70;
        label_67:
        if((val_23.GetComponentInChildren<UILabel>()) != 0)
        {
            goto label_74;
        }
        
        val_47 = "Could not find caption of level button.";
        label_70:
        UnityEngine.Debug.LogWarning(message:  val_47);
        if(val_51 != null)
        {
            goto label_77;
        }
        
        label_48:
        label_77:
        Rilisoft.ButtonHandler val_27 = val_51.AddComponent<Rilisoft.ButtonHandler>();
        .丂一丏丙下丝丘丆丗 = val_16 + 24;
        val_48 = val_51.GetComponent<Rilisoft.ButtonHandler>();
        val_48.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  new ChooseLevel.下丏丌丑七丗丕丅世(), method:  System.Void ChooseLevel.下丏丌丑七丗丕丅世::丁丈专丂且丄三丌丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_51.SetActive(value:  true);
        val_49 = 0;
        goto label_82;
        label_106:
        if((val_16 + 16) != 0)
        {
                val_48 = this.starEnabledPrototypes[0];
            if(val_48 != 0)
        {
                UnityEngine.GameObject val_31 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_48);
            val_31.transform.parent = val_51.transform;
            val_31.GetComponent<UIToggle>().value = (val_49 < (val_16 + 32)) ? 1 : 0;
            UnityEngine.Vector3 val_38 = val_48.transform.localPosition;
            val_31.transform.localPosition = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z};
            val_48 = val_48.transform;
            UnityEngine.Vector3 val_41 = val_48.localScale;
            val_31.transform.localScale = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z};
            val_31.SetActive(value:  true);
        }
        
        }
        
        val_49 = 1;
        label_82:
        if(val_49 != this.starEnabledPrototypes.Length)
        {
            goto label_106;
        }
        
        val_52 = val_52 + 1;
        if(val_52 != val_12)
        {
            goto label_107;
        }
        
        label_44:
        val_50 = 0;
        goto label_108;
        label_116:
        UnityEngine.GameObject val_53 = this.starEnabledPrototypes[0];
        if(val_53 != 0)
        {
                UnityEngine.Object.Destroy(obj:  val_53);
        }
        
        val_50 = 1;
        label_108:
        if(val_50 < this.starEnabledPrototypes.Length)
        {
            goto label_116;
        }
        
        val_51 = 0;
        goto label_117;
        label_125:
        val_40 = this.starDisabledPrototypes[0];
        if(val_40 != 0)
        {
                UnityEngine.Object.Destroy(obj:  val_40);
        }
        
        val_51 = 1;
        label_117:
        if(val_51 < this.starDisabledPrototypes.Length)
        {
            goto label_125;
        }
        
        return;
        label_17:
        val_53 = "boxContents == 0";
        goto label_126;
        label_24:
        val_53 = "Box level buttons are null.";
        label_126:
        null = new System.InvalidOperationException(message:  val_53);
    }
    private void 且东且丑丛丂三三丏(string 丂一丏丙下丝丘丆丗)
    {
        var val_4;
        var val_5;
        var val_6;
        if(this._shopInstance != 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_2 = val_2 - this.上丙丐丗业丆七世丐;
        if(val_2 < 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 = 丂一丏丙下丝丘丆丗;
        val_5 = null;
        val_5 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
        val_6 = null;
        val_6 = null;
        LevelArt.丗业丞丐丙三丆丘丟 = false;
        if(LevelArt.三丂丂丘下丕丌下三 != false)
        {
                Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "LevelArt");
            return;
        }
        
        MainMenuController.丅与丁丌丝丒七不与();
    }
    private static System.Collections.Generic.IList<ChooseLevel.与丗丁丈丆不丗丕丙> 业丑丘丐丆下丟三丗(bool 丄三丄丈丈丕丂丑专 = False)
    {
        System.Collections.Generic.List<与丗丁丈丆不丗丕丙> val_1 = new System.Collections.Generic.List<与丗丁丈丆不丗丕丙>();
        ChooseLevel.与丗丁丈丆不丗丕丙 val_2 = new ChooseLevel.与丗丁丈丆不丗丕丙();
        if(val_2 != null)
        {
                .<丛丌且业丆丑丗丘丄>k__BackingField = true;
            .<七世专丙丝丒丒丟丁>k__BackingField = "Cementery";
        }
        else
        {
                mem[16] = 1;
            mem[24] = "Cementery";
        }
        
        .<丂丙丂丐丅丆丂不丈>k__BackingField = 1;
        val_1.Add(item:  val_2);
        ChooseLevel.与丗丁丈丆不丗丕丙 val_3 = new ChooseLevel.与丗丁丈丆不丗丕丙();
        if(val_3 != null)
        {
                .<丛丌且业丆丑丗丘丄>k__BackingField = true;
            .<七世专丙丝丒丒丟丁>k__BackingField = "City";
        }
        else
        {
                mem[16] = 1;
            mem[24] = "City";
        }
        
        .<丂丙丂丐丅丆丂不丈>k__BackingField = 3;
        val_1.Add(item:  val_3);
        ChooseLevel.与丗丁丈丆不丗丕丙 val_4 = new ChooseLevel.与丗丁丈丆不丗丕丙();
        if(val_4 != null)
        {
                .<丛丌且业丆丑丗丘丄>k__BackingField = false;
        }
        else
        {
                mem[16] = 0;
        }
        
        .<七世专丙丝丒丒丟丁>k__BackingField = "Hospital";
        val_1.Add(item:  val_4);
        return (System.Collections.Generic.IList<与丗丁丈丆不丗丕丙>)val_1;
    }
    private static System.Collections.Generic.IList<ChooseLevel.与丗丁丈丆不丗丕丙> 丂上上丐下丄丄丐丄(bool 丄三丄丈丈丕丂丑专 = False)
    {
        var val_17;
        var val_25;
        var val_26;
        var val_27;
        System.Predicate<T> val_28;
        var val_29;
        var val_30;
        string val_31;
        var val_32;
        var val_33;
        System.Collections.Generic.List<与丗丁丈丆不丗丕丙> val_2 = new System.Collections.Generic.List<与丗丁丈丆不丗丕丙>();
        val_25 = null;
        val_25 = null;
        .丛一丝丛丏专一业且 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        val_26 = 1152921505226227712;
        val_27 = null;
        val_27 = null;
        System.Predicate<下与业丆下三丅丅丝> val_3 = null;
        val_28 = val_3;
        val_3 = new System.Predicate<下与业丆下三丅丅丝>(object:  new ChooseLevel.丟丑不七不丆业丐丛(), method:  System.Boolean ChooseLevel.丟丑不七不丆业丐丛::丟专丑三丙七业专丘(下与业丆下三丅丅丝 丌丗丏丏丛东专丁且));
        int val_4 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.FindIndex(match:  val_3);
        if(val_4 == 1)
        {
            goto label_7;
        }
        
        val_29 = null;
        val_29 = null;
        下与业丆下三丅丅丝 val_5 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[val_4];
        val_30 = null;
        val_30 = null;
        val_31 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        val_28 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_31);
        if(val_28 == null)
        {
                UnityEngine.Debug.LogWarning(message:  "Box not found in dictionary: "("Box not found in dictionary: ") + (ChooseLevel.丟丑不七不丆业丐丛)[1152921525706057360].丛一丝丛丏专一业且);
            丅丕东丑下世丏丑与.不丛专丁世三专三丒 val_9 = null;
            val_28 = val_9;
            val_9 = new 丅丕东丑下世丏丑与.不丛专丁世三专三丒();
        }
        
        val_32 = 0;
        val_26 = 0;
        goto label_20;
        label_49:
        string val_11 = val_5.下上不丏专丄丆业世.Item[0].一七与丅上丁丙丂不();
        val_33 = null;
        val_33 = null;
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  val_11)) == null)
        {
            goto label_28;
        }
        
        if(val_28 != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        if((丅丕东丑下世丏丑与.不丛专丁世三专三丒)[1152921525706094224].上三丆丞丝丛丟丐不 == null)
        {
            goto label_30;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_14 = (丅丕东丑下世丏丑与.不丛专丁世三专三丒)[1152921525706094224].上三丆丞丝丛丟丐不.GetEnumerator();
        val_31 = 0;
        goto label_31;
        label_33:
        ConfiguredValueTaskAwaiter val_18 = val_17.GetAwaiter();
        var val_19 = ((-375670240) > 0) ? (val_31 + 1) : (val_31);
        label_31:
        if(((-375670240) & 1) != 0)
        {
            goto label_33;
        }
        
        goto label_34;
        label_28:
        if(val_28 != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_30:
        val_31 = 0;
        goto label_43;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_26 != 1)
        {
                var val_24 = 0;
            val_24 = val_24 ^ 0;
            val_26 = val_26 + val_24;
        }
        else
        {
                val_26 = 0;
        }
        
        label_43:
        ChooseLevel.与丗丁丈丆不丗丕丙 val_20 = new ChooseLevel.与丗丁丈丆不丗丕丙();
        if(val_20 != null)
        {
                .<丛丌且业丆丑丗丘丄>k__BackingField = (val_32 <= val_31) ? 1 : 0;
            .<七世专丙丝丒丒丟丁>k__BackingField = val_11;
        }
        else
        {
                mem[16] = (val_32 <= val_31) ? 1 : 0;
            mem[24] = val_11;
        }
        
        .<丂丙丂丐丅丆丂不丈>k__BackingField = val_13.丌丐丛丝丒上丟丏下;
        val_2.Add(item:  val_20);
        val_32 = 1;
        label_20:
        if(val_32 != val_5.下上不丏专丄丆业世.Count)
        {
            goto label_49;
        }
        
        return (System.Collections.Generic.IList<与丗丁丈丆不丗丕丙>)val_2;
        label_7:
        UnityEngine.Debug.LogWarning(message:  "Box not found in list!");
        return (System.Collections.Generic.IList<与丗丁丈丆不丗丕丙>)val_2;
    }
    private static string 丒上七上丒丄丝丏丞(System.Collections.Generic.IList<ChooseLevel.与丗丁丈丆不丗丕丙> 不丕专丘且丐与三丂)
    {
        object val_10;
        var val_13;
        var val_14;
        var val_12 = 0;
        val_12 = val_12 + 1;
        int val_2 = 不丕专丘且丐与三丂.Count;
        var val_13 = 0;
        val_13 = val_13 + 1;
        System.Collections.Generic.IEnumerator<T> val_5 = 不丕专丘且丐与三丂.GetEnumerator();
        val_10 = 0;
        goto label_11;
        label_23:
        var val_14 = 0;
        val_14 = val_14 + 1;
        T val_7 = val_5.Current;
        val_10 = (val_7 + 32) + val_10;
        label_11:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_5.MoveNext() == true)
        {
            goto label_23;
        }
        
        val_13 = 0;
        val_14 = 0;
        if(val_5 == null)
        {
                return (string)System.String.Format(format:  "{0}/{1}", arg0:  val_10, arg1:  val_2 + (val_2 << 1));
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_5.Dispose();
        return (string)System.String.Format(format:  "{0}/{1}", arg0:  val_10, arg1:  val_2 + (val_2 << 1));
    }
    internal static string 万丛丄丑丄丅丒丝丒()
    {
        return ChooseLevel.丒上七上丒丄丝丏丞(不丕专丘且丐与三丂:  ChooseLevel.丂上上丐下丄丄丐丄(丄三丄丈丈丕丂丑专:  false));
    }
    private void OnDestroy()
    {
        null = null;
        ChooseLevel.丙业三丄世业一丝且 = 0;
    }
    public ChooseLevel()
    {
        this.丈丂丑上且丁七七丈 = System.String.alignConst;
        this.丂丒与丕丝丂与万万 = new System.Collections.Generic.List<与丗丁丈丆不丗丕丙>();
    }
    private static ChooseLevel()
    {
    
    }
    private void 业丂下丐不一业丈丅()
    {
        if(this._shopInstance != 0)
        {
                return;
        }
        
        this.专丗丄七丏丕丂丗丄(不丟丗丏丛丕不丁丌:  0, 专丒丌丆下丐丞丟丞:  0);
    }

}
