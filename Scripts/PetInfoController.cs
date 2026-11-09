using UnityEngine;
public class PetInfoController : MonoBehaviour
{
    // Fields
    private System.Action 丄丑上丕丂丈丘丙七;
    private static PetInfoController <不丁丄七丛不丆丁丕>k__BackingField;
    private UnityEngine.GameObject _infoPanel;
    private UnityEngine.GameObject _touchBlockerPanel;
    public Rilisoft.ButtonHandler renameButton;
    public Rilisoft.ButtonHandler equipButton;
    public Rilisoft.ButtonHandler unequipButton;
    public Rilisoft.ButtonHandler upgradeButton;
    public Rilisoft.ButtonHandler reEqipButton;
    public UnityEngine.GameObject lockedUpgradeButton;
    public UnityEngine.GameObject needLevel;
    public UILabel needLevelLabel;
    private UnityEngine.GameObject upgradeArrows;
    private PriceContainer priceContainer;
    public CharacterViewRotator petRotator;
    public AnimationCoroutineRunner petProfileAnimationRunner;
    private UnityEngine.Transform _modelPoint;
    private UnityEngine.GameObject upgradeParticles;
    public UnityEngine.Camera petCamera;
    private UILabel attackValueLabel;
    private UILabel healthValueLabel;
    private UILabel speedValueLabel;
    private UILabel respawnValueLabel;
    private System.Collections.Generic.List<UILabel> levelValueLabel;
    private UILabel currentUpgradeLabel;
    private UILabel rarityLabel;
    private UILabel nameLabel;
    private UILabel upgradeCountLabel;
    private UILabel notEnoughCards;
    private UITable specialParamsTable;
    private System.Collections.Generic.List<UILabel> specialParams;
    private System.Collections.Generic.List<UISprite> specialParamsSprites;
    private UnityEngine.GameObject upgradeProgressBar;
    private UILabel upgradePointsLabel;
    private System.Collections.Generic.List<UISprite> frames;
    private UnityEngine.GameObject _buyCardsBody;
    private UILabel _cardsLabel;
    private UISprite _gearSprite;
    private UnityEngine.GameObject _renameButtonHolder;
    private UnityEngine.GameObject goToGatchaButton;
    private UnityEngine.GameObject goToChestsEventButton;
    private UIButton freeBattlePassButton;
    private UIButton paidBattlePassButton;
    private UnityEngine.GameObject goToArmory;
    private UnityEngine.GameObject _simpleBGContainer;
    private float _simpleInfoPanelY;
    private float _simplePetModelY;
    private UnityEngine.GameObject _battlePassBGContainer;
    private float _battlePassInfoPanelY;
    private float _battlePassPetModelY;
    private EfficiencyBar _efficiencyBar;
    private static System.Action 丄丆下万丛丅丒丘七;
    private static System.Action 丈丘下丏丆丐业丌丄;
    private UnityEngine.GameObject 丄丈万与丛丆一与丄;
    private bool 丘丒丙丈丒丅与丐丙;
    private PetInfo 丌丌丒上丄丅丕丟丌;
    private UnityEngine.GameObject 丄且丙丏三丁丙丁业;
    private UnityEngine.AudioClip 一不丅业丆丂丒丆丛;
    private bool 专世丁与丙丟万丝丈;
    private const string 世世丟万不三下丈丅 = "Profile";
    private const string 丙与丆不丈与下与不 = "Tap";
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private string 丝不丆丙下丐专丑丘;
    private UnityEngine.AudioSource 七三丁丗专下万丒一;
    
    // Properties
    public static PetInfoController 丆丕丝丒不丙且丐丗 { get; set; }
    public UnityEngine.GameObject 丟丂丄不下一丐业丈 { get; }
    public bool 丈丏上丟丝丄丑丌丏 { get; set; }
    
    // Methods
    internal void 丘万丟丕业不万丂丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != 1152921535475219384);
    
    }
    internal void 丅七丅丐丗丛一丑丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != 1152921535475355960);
    
    }
    public static PetInfoController get_Instance()
    {
        return (PetInfoController)PetInfoController.丙与丆不丈与下与不;
    }
    private static void 丒且丒丗丗丟下丗丝(PetInfoController 丙业与丙丗丝不丈东)
    {
        PetInfoController.丙与丆不丈与下与不 = 丙业与丙丗丝不丈东;
    }
    internal static void 丂丅上丂丞丗丘且丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PetInfoController.丄丆下万丛丅丒丘七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PetInfoController.丄丆下万丛丅丒丘七 != 1152921505103708168);
    
    }
    internal static void 丑七丕七七一丗丁万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PetInfoController.丄丆下万丛丅丒丘七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PetInfoController.丄丆下万丛丅丒丘七 != 1152921505103708168);
    
    }
    internal static void 下三万丘丁三丝一业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PetInfoController.丈丘下丏丆丐业丌丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PetInfoController.丈丘下丏丆丐业丌丄 != 1152921505103708176);
    
    }
    internal static void 丗三丗丌丂丟一丑丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PetInfoController.丈丘下丏丆丐业丌丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PetInfoController.丈丘下丏丆丐业丌丄 != 1152921505103708176);
    
    }
    public UnityEngine.GameObject get_buyCardsBody()
    {
        return (UnityEngine.GameObject)this._buyCardsBody;
    }
    public bool get_WasCreated()
    {
        return (bool)this.丘丒丙丈丒丅与丐丙;
    }
    public void set_WasCreated(bool 丙业与丙丗丝不丈东)
    {
        this.丘丒丙丈丒丅与丐丙 = 丙业与丙丗丝不丈东;
    }
    public void DeleteModel()
    {
        if((this.一不丅业丆丂丒丆丛 != 0) && (this.七三丁丗专下万丒一 != 0))
        {
                if(this.七三丁丗专下万丒一.isPlaying != false)
        {
                this.七三丁丗专下万丒一.Stop();
        }
        
        }
        
        if(this.丄丈万与丛丆一与丄 == 0)
        {
                return;
        }
        
        if(this.petProfileAnimationRunner != 0)
        {
                this.petProfileAnimationRunner.StopAllCoroutines();
        }
        
        UnityEngine.Object.Destroy(obj:  this.丄丈万与丛丆一与丄);
    }
    private void OnEnable()
    {
        PetInfoController.丙与丆不丈与下与不 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._renameButtonHolder, 丏业丟一东丂东丘丛:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
    }
    private void OnDisable()
    {
        PetInfoController.丙与丆不丈与下与不 = 0;
        if(this.丘丒丙丈丒丅与丐丙 != false)
        {
                return;
        }
        
        this.DeleteModel();
    }
    private void Awake()
    {
        System.EventHandler val_11;
        if(this.renameButton != 0)
        {
                System.EventHandler val_2 = null;
            val_11 = val_2;
            val_2 = new System.EventHandler(object:  this, method:  System.Void PetInfoController::七丛三丞丑万丒东世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.renameButton.add_Clicked(丙业与丙丗丝不丈东:  val_2);
        }
        
        if(this.equipButton != 0)
        {
                System.EventHandler val_4 = null;
            val_11 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void PetInfoController::丟丟七丄丒丘丕丈丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.equipButton.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        if(this.unequipButton != 0)
        {
                System.EventHandler val_6 = null;
            val_11 = val_6;
            val_6 = new System.EventHandler(object:  this, method:  System.Void PetInfoController::丌丝上不丟丌丑不丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.unequipButton.add_Clicked(丙业与丙丗丝不丈东:  val_6);
        }
        
        if(this.reEqipButton != 0)
        {
                System.EventHandler val_8 = null;
            val_11 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void PetInfoController::丄上丑七丝三丁丁七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.reEqipButton.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        if(this.upgradeButton == 0)
        {
                return;
        }
        
        this.upgradeButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PetInfoController::万一丕丝丕万丟丁丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丌丂三三丄丟三丑丗()
    {
        if(this.renameButton != 0)
        {
                this.renameButton.ClearEvents();
        }
        
        if(this.equipButton != 0)
        {
                this.equipButton.ClearEvents();
        }
        
        if(this.unequipButton != 0)
        {
                this.unequipButton.ClearEvents();
        }
        
        if(this.upgradeButton != 0)
        {
                this.upgradeButton.ClearEvents();
        }
        
        if(this.reEqipButton == 0)
        {
                return;
        }
        
        this.reEqipButton.ClearEvents();
    }
    private void OnDestroy()
    {
        if((this.一不丅业丆丂丒丆丛 != 0) && (this.七三丁丗专下万丒一 != 0))
        {
                if(this.七三丁丗专下万丒一.isPlaying != false)
        {
                this.七三丁丗专下万丒一.Stop();
        }
        
        }
        
        this.丌丂三三丄丟三丑丗();
        if((this.丘丒丙丈丒丅与丐丙 != false) && (this.且丂七丑丈丞丈三丑 != null))
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
            this.且丂七丑丈丞丈三丑 = 0;
        }
        
        this.丘丒丙丈丒丅与丐丙 = false;
    }
    public void EnablePetCamera()
    {
        if(this.petCamera == 0)
        {
                return;
        }
        
        if(this.petCamera.enabled != false)
        {
                return;
        }
        
        this.petCamera.enabled = true;
    }
    public void Show(string 世丐丗专丅三丝丑丆, Rilisoft.ItemViewer.一丗丟丛丈专丙三丌 下丗丐丙丙丞与与三 = 0, bool 上丑七与丗三丐丈丙 = True, int 上世丗与丗东三丐丛 = -1)
    {
        var val_26;
        bool val_27;
        var val_28;
        UnityEngine.GameObject val_29;
        this.丄且丙丏三丁丙丁业 = 0;
        this.专世丁与丙丟万丝丈 = 上丑七与丗三丐丈丙;
        if((this.一不丅业丆丂丒丆丛 != 0) && (this.七三丁丗专下万丒一 != 0))
        {
                if(this.七三丁丗专下万丒一.isPlaying != false)
        {
                this.七三丁丗专下万丒一.Stop();
        }
        
        }
        
        this.一不丅业丆丂丒丆丛 = 0;
        this.七三丁丗专下万丒一 = 0;
        val_26 = Rilisoft.PetsManager.专丘丞下万丅丒丐丒();
        if((val_26.ContainsKey(key:  世丐丗专丅三丝丑丆)) == false)
        {
            goto label_13;
        }
        
        val_26 = Rilisoft.PetsManager.专丘丞下万丅丒丐丒();
        PetInfo val_8 = val_26.Item[世丐丗专丅三丝丑丆];
        this.丌丌丒上丄丅丕丟丌 = val_8;
        if(val_8 == null)
        {
            goto label_17;
        }
        
        label_37:
        this.丄且丙丏三丁丙丁业 = this.丆丒业世专上下丞下();
        this.专东丁丙丞丂东丝丁(七不丐下丟专业万丅:  "Profile", 丟丘丙丄丅万丏与丗:  0);
        this.世业丄丐三丂丛丈世();
        this.丌下丅万丆丁丈丒且();
        this.世上丒丙与丘丄丕且();
        this.且且专丏下丄丝丌东();
        this.丞丄业丈业东丐专丛();
        this.丛丏丌丗三上丛专世();
        if((this.丘丒丙丈丒丅与丐丙 != false) && (this.且丂七丑丈丞丈三丑 == null))
        {
                this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PetInfoController::Close()), 与且专丈不万东一万:  "ClosePetInfo");
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._simpleBGContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._battlePassBGContainer, 丏业丟一东丂东丘丛:  false);
        val_27 = 0;
        if(下丗丐丙丙丞与与三 == 1)
        {
                val_27 = PGCompany.BattlePass.丈东丁一丁丝且丛丗.丟丒上丌不丏丂丑丄(丕丁下丌不万丅丞丛:  世丐丗专丅三丝丑丆, 业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false});
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToArmory, 丏业丟一东丂东丘丛:  val_27);
        if(下丗丐丙丙丞与与三 != 1)
        {
            goto label_28;
        }
        
        if(this._infoPanel != 0)
        {
                this._infoPanel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._modelPoint.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_28 = null;
        val_29 = this._battlePassBGContainer;
        goto label_47;
        label_13:
        if(this.丌丌丒上丄丅丕丟丌 != null)
        {
            goto label_37;
        }
        
        label_17:
        UnityEngine.Debug.LogError(message:  "pet not setted!");
        return;
        label_28:
        if(this._infoPanel != 0)
        {
                this._infoPanel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._modelPoint.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_28 = null;
        val_29 = this._simpleBGContainer;
        label_47:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_29, 丏业丟一东丂东丘丛:  true);
        if((上世丗与丗东三丐丛 & 2147483648) != 0)
        {
                return;
        }
        
        if(this._infoPanel != 0)
        {
                UIPanel val_19 = this._infoPanel.GetComponent<UIPanel>();
            if(val_19 != 0)
        {
                val_19.depth = 上世丗与丗东三丐丛 + 1;
        }
        
        }
        
        val_29 = this._touchBlockerPanel;
        if(val_29 == 0)
        {
                return;
        }
        
        UIPanel val_23 = this._touchBlockerPanel.GetComponent<UIPanel>();
        if(val_23 == 0)
        {
                return;
        }
        
        val_23.depth = 上世丗与丗东三丐丛;
    }
    public void UI_Move()
    {
        this.Close();
        if(this.丌丌丒上丄丅丕丟丌 == null)
        {
                return;
        }
        
        PGCompany.BattlePass.世下东丌三专上下万.下丏且一三丐一丐不(丕丁下丌不万丅丞丛:  this.丌丌丒上丄丅丕丟丌.Id, 业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false});
    }
    private UnityEngine.GameObject 丆丒业世专上下丞下()
    {
        float val_21;
        UnityEngine.Vector3 val_25;
        this.DeleteModel();
        Rilisoft.PetEngine val_2 = UnityEngine.Resources.Load<Rilisoft.PetEngine>(path:  this.丌丌丒上丄丅丕丟丌.丘丕丂万丝丁丌丞业());
        if(val_2 != null)
        {
                this.一不丅业丆丂丒丆丛 = val_2.ClipTap;
        }
        else
        {
                this.一不丅业丆丂丒丆丛 = 456;
        }
        
        UnityEngine.Transform val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_2.下七丏不丒丗业丛专()).GetComponent<UnityEngine.Transform>();
        this.丄丈万与丛丆一与丄 = val_5.gameObject;
        val_5.parent = this._modelPoint;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_21 = 0.8f;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_21);
        val_5.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        if(this.丌丌丒上丄丅丕丟丌 == null)
        {
            goto label_12;
        }
        
        if(this.丘丒丙丈丒丅与丐丙 == false)
        {
            goto label_13;
        }
        
        label_16:
        val_25 = this.丌丌丒上丄丅丕丟丌.m_positionInBanners;
        val_5.localPosition = new UnityEngine.Vector3() {x = val_25, y = val_8.y, z = val_8.z};
        goto label_15;
        label_12:
        if(this.丘丒丙丈丒丅与丐丙 == true)
        {
            goto label_16;
        }
        
        label_13:
        if(this.丌丌丒上丄丅丕丟丌.Behaviour != 0)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.35f);
        }
        else
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        }
        
        val_5.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Vector3 val_12 = val_5.localScale;
        val_21 = 3f / S11;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_21);
        val_25 = val_13.x;
        val_5.localScale = new UnityEngine.Vector3() {x = val_25, y = val_13.y, z = val_13.z};
        label_15:
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.丌丌丒上丄丅丕丟丌.m_rotationInBanners, y = val_25, z = val_13.y});
        if(val_5 != null)
        {
                val_5.localRotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
        }
        else
        {
                val_5.localRotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_5.gameObject, 不东丛三丂丌丑专丆:  this._modelPoint.gameObject.layer);
        this.petRotator.characterView = val_5;
        this.petRotator.SetDefaultRotationFromCharacterView();
        this.petRotator.SetMode(丐专一上与上三丝丁:  0);
        if(val_5 != null)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_5.gameObject);
            return val_5.gameObject;
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_5.gameObject);
        return val_5.gameObject;
    }
    private void 专东丁丙丞丂东丝丁(string 七不丐下丟专业万丅, System.Action 丟丘丙丄丅万丏与丗)
    {
        System.Action val_10;
        AnimationCoroutineRunner val_11;
        UnityEngine.Object val_12;
        val_10 = 丟丘丙丄丅万丏与丗;
        val_11 = this;
        if(this.丄且丙丏三丁丙丁业 == 0)
        {
                return;
        }
        
        UnityEngine.Animation val_2 = this.丄且丙丏三丁丙丁业.GetComponent<UnityEngine.Animation>();
        this.petProfileAnimationRunner.StopAllCoroutines();
        val_12 = val_2.GetClip(name:  七不丐下丟专业万丅);
        if(val_12 == 0)
        {
            goto label_9;
        }
        
        this.丝不丆丙下丐专丑丘 = 七不丐下丟专业万丅;
        val_12 = this.petProfileAnimationRunner.gameObject;
        if(val_12.activeInHierarchy == false)
        {
            goto label_12;
        }
        
        val_11 = this.petProfileAnimationRunner;
        val_11.StartPlay(丆不丝丝上一丞七业:  val_2, 七不丐下丟专业万丅:  七不丐下丟专业万丅, 丄三丗丛丑下丅丏七:  false, 丟丘丙丄丅万丏与丗:  val_10);
        return;
        label_9:
        object[] val_7 = new object[1];
        val_10 = val_7;
        val_10[0] = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.丄且丙丏三丁丙丁业);
        UnityEngine.Debug.LogErrorFormat(format:  "Error: pet {0} has no Profile animation clip (EggHatchingWindowController)", args:  val_7);
        return;
        label_12:
        val_10 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "Coroutine couldn\'t be started because the the game object \'AnimationCoroutineRunner\' is inactive! (Pet)", args:  val_10);
    }
    private void 世业丄丐三丂丛丈世()
    {
        string val_20;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.speedValueLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  UnityEngine.Mathf.RoundToInt(f:  BalanceController.丑一丌丟万丛丝丕丆(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id)), 东丑丛上专上下丕丌:  UnityEngine.Mathf.RoundToInt(f:  BalanceController.丑一丌丟万丛丝丕丆(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id))));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.respawnValueLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  UnityEngine.Mathf.RoundToInt(f:  BalanceController.丝一丄丙三且丞丞一(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id)), 东丑丛上专上下丕丌:  UnityEngine.Mathf.RoundToInt(f:  BalanceController.丝一丄丙三且丞丞一(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id))));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rarityLabel, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.丌丌丒上丄丅丕丟丌.Rarity));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.levelValueLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3664"), arg0:  this.专丂丝业丞丄丟丐丒().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture)));
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id)) != null)
        {
                val_20 = val_18.专丕与丒丗丁丘专丟;
        }
        else
        {
                val_20 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丌丌丒上丄丅丕丟丌.Lkey);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  val_20);
    }
    private int 专丂丝业丞丄丟丐丒()
    {
        int val_1 = this.丌丌丒上丄丅丕丟丌.CurrentLevel;
        if(val_1 == 0)
        {
                return BalanceController.丟丛丒丞业丂丘东世(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id);
        }
        
        return val_1;
    }
    private void 丌下丅万丆丁丈丒且()
    {
        string val_8;
        string val_13;
        UITable val_17;
        var val_18;
        var val_19;
        var val_20;
        val_17 = this;
        val_18 = 1152921524342359424;
        val_19 = 0;
        goto label_1;
        label_26:
        int val_1 = this.丌丌丒上丄丅丕丟丌.Effects.Count;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialParams.Item[0].gameObject, 丏业丟一东丂东丘丛:  (val_19 < val_1) ? 1 : 0);
        if(val_19 < val_1)
        {
                val_20 = null;
            val_20 = null;
            System.ValueTuple<System.String, System.String, System.String> val_7 = WeaponSounds.三丘丒万丛丞与一不.Item[this.丌丌丒上丄丅丕丟丌.Effects.Item[0]];
            this.specialParams.Item[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8);
            System.ValueTuple<System.String, System.String, System.String> val_12 = WeaponSounds.三丘丒万丛丞与一不.Item[this.丌丌丒上丄丅丕丟丌.Effects.Item[0]];
            this.specialParamsSprites.Item[0].spriteName = val_13;
            val_18 = 1152921524342359424;
            this.specialParamsSprites.Item[0].ResetAndUpdateAnchors();
        }
        
        val_19 = 1;
        label_1:
        if(val_19 < this.specialParams.Count)
        {
            goto label_26;
        }
        
        if(this.specialParamsTable == 0)
        {
                return;
        }
        
        val_17 = this.specialParamsTable;
    }
    private void 世上丒丙与丘丄丕且()
    {
        int val_5 = this.专丂丝业丞丄丟丐丒();
        if(((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id, 丞世不丒下上上丝丑: out  0)) != null) && (val_5 < (BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  0))))
        {
                System.String.alignConst = System.String.Format(format:  "{0}/{1}", arg0:  val_3.专下与丑三丏丂不丆, arg1:  BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  0, 且万丛丒丁丏七丅东:  val_5, 丐丏上业丈丂与万丞:  false));
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._cardsLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.upgradePointsLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
    }
    private void 且且专丏下丄丝丌东()
    {
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        .丁世丕丈丅丗世丂丟 = val_2;
        mem[1152921535479814340] = val_2.g;
        mem[1152921535479814344] = val_2.b;
        mem[1152921535479814348] = val_2.a;
        UnityEngine.Color val_5 = 丐丄七丙丁丆丁专丏.世丝不丄且丅且丏丈(丕丗丘丑丛与丑业丒:  this.rarityLabel.text.Substring(startIndex:  1, length:  6), 丛上丙丄丄七丈且丅:  0);
        .丁世丕丈丅丗世丂丟 = val_5;
        mem[1152921535479814340] = val_5.g;
        mem[1152921535479814344] = val_5.b;
        mem[1152921535479814348] = val_5.a;
        this.frames.ForEach(action:  new System.Action<UISprite>(object:  new PetInfoController.丟万三一丄业七丈与(), method:  System.Void PetInfoController.丟万三一丄业七丈与::专与丘丞丙下与丒且(UISprite 三丟东丕丄丄下下丑)));
    }
    private void 丛丏丌丗三上丛专世()
    {
        var val_63;
        PetInfo val_64;
        var val_65;
        var val_66;
        var val_67;
        UnityEngine.GameObject val_68;
        var val_70;
        float val_71;
        float val_72;
        val_63 = this;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != false)
        {
                val_64 = this.丌丌丒上丄丅丕丟丌;
            bool val_6 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏().Equals(value:  this.丌丌丒上丄丅丕丟丌.Id);
        }
        else
        {
                val_64 = this.丌丌丒上丄丅丕丟丌;
        }
        
        int val_9 = BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  mem[this.丌丌丒上丄丅丕丟丌] + 16, 且万丛丒丁丏七丅东:  mem[this.丌丌丒上丄丅丕丟丌].CurrentLevel, 丐丏上业丈丂与万丞:  false);
        if(val_9 > mem[this.丌丌丒上丄丅丕丟丌].CurrentLevel)
        {
                val_65 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_65 = 0;
        }
        
        int val_12 = ExperienceController.丞丞丘业东丙丏七丌();
        if(val_65 != 0)
        {
                if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丞世丟丙下丆丛丑世(世丐丗专丅三丝丑丆:  mem[this.丌丌丒上丄丅丕丟丌] + 128)) != false)
        {
                var val_15 = (val_9 > val_12) ? 1 : 0;
        }
        else
        {
                val_66 = 1;
        }
        
        }
        
        bool val_19 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丑专上丌专业丁丌三(世丐丗专丅三丝丑丆:  mem[this.丌丌丒上丄丅丕丟丌] + 128);
        if(val_65 != 0)
        {
                val_67 = (~(Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丞世丟丙下丆丛丑世(世丐丗专丅三丝丑丆:  mem[this.丌丌丒上丄丅丕丟丌] + 128))) & 1;
        }
        else
        {
                val_67 = 0;
        }
        
        var val_22 = (val_9 <= val_12) ? 1 : 0;
        val_22 = val_65 & val_22;
        if(val_22 != 0)
        {
                val_68 = (~(Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丞世丟丙下丆丛丑世(世丐丗专丅三丝丑丆:  mem[this.丌丌丒上丄丅丕丟丌] + 128))) & 1;
        }
        else
        {
                val_68 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.notEnoughCards, 丏业丟一东丂东丘丛:  false);
        if(this.equipButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipButton.gameObject, 丏业丟一东丂东丘丛:  (0 == 0) ? 1 : 0);
        }
        
        if(this.unequipButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unequipButton.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        bool val_32 = ((val_65 != 0) ? 1 : 0) & ((val_66 == 0) ? 1 : 0);
        if(this.upgradeButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeButton.gameObject, 丏业丟一东丂东丘丛:  val_32);
        }
        
        if(this.needLevel != 0)
        {
                bool val_36 = ((val_65 != 0) ? 1 : 0) & ((val_9 > val_12) ? 1 : 0);
            val_68 = this.needLevel.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_68, 丏业丟一东丂东丘丛:  val_36);
            if(val_36 != 0)
        {
                val_68 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  val_9.ToString());
            this.needLevelLabel.text = val_68;
        }
        
        }
        
        bool val_41 = val_67 & val_19;
        if(this._buyCardsBody != 0)
        {
                if(val_41 != false)
        {
                val_70 = (~this.needLevel.gameObject.activeInHierarchy) & 1;
        }
        else
        {
                val_70 = 0;
        }
        
            val_68 = this._buyCardsBody;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_68, 丏业丟一东丂东丘丛:  false);
            this.丄上丌丕丑丁东上丌();
            if((this.丌丌丒上丄丅丕丟丌 != null) && (val_70 != 0))
        {
                if(this._gearSprite != 0)
        {
                UnityEngine.Color val_46 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  mem[this.丌丌丒上丄丅丕丟丌] + 216);
            val_71 = val_46.r;
            val_72 = val_46.b;
            this._gearSprite.color = new UnityEngine.Color() {r = val_71, g = val_46.g, b = val_72, a = val_46.a};
        }
        
        }
        
        }
        
        if(this.reEqipButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.reEqipButton.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.priceContainer != 0)
        {
                var val_60 = val_66;
            val_60 = val_60 | val_32;
            var val_52 = (val_60 == 0) ? 1 : 0;
            val_52 = ((val_41 == true) ? 1 : 0) | val_52;
            val_52 = val_19 | val_52;
            bool val_54 = ((val_60 != 0) ? 1 : 0) & ((val_41 == false) ? 1 : 0);
            val_68 = val_32 | val_52;
            val_54 = val_54 & val_68;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceContainer.gameObject, 丏业丟一东丂东丘丛:  val_54);
            if(val_54 != false)
        {
                this.priceContainer.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  168, 丞一丁业丄一一业且:  this.丌丌丒上丄丅丕丟丌.Id, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false));
        }
        
        }
        
        if(this.upgradeArrows == 0)
        {
                return;
        }
        
        if((val_32 & 1) != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeArrows, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeArrows, 丏业丟一东丂东丘丛:  false);
        val_63 = this.upgradeArrows.transform;
        UnityEngine.Vector3 val_59 = UnityEngine.Vector3.zero;
        val_71 = val_59.x;
        val_72 = val_59.z;
        val_63.localPosition = new UnityEngine.Vector3() {x = val_71, y = val_59.y, z = val_72};
    }
    private void 丄上丌丕丑丁东上丌()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this._buyCardsBody == 0)
        {
                return;
        }
        
        if(this._buyCardsBody.activeSelf == false)
        {
                return;
        }
        
        val_8 = this._buyCardsBody.activeSelf;
        丕东上一丏丛丝世丒 val_4 = 业丌丐丈丛丙丐三下.专丆丙丂丞丕丞上丟(下丅丙一丂丗丅丝七:  this.丌丌丒上丄丅丕丟丌.Id);
        bool val_5 = (val_4.<业丌丛丅丁丌万丏丛>k__BackingField) >> 48;
        bool val_6 = (val_4.<业丌丛丅丁丌万丏丛>k__BackingField) >> 32;
        if((val_4.<丌世丅万丛一丟丗丘>k__BackingField.下丕且丝丐丙丏丛上()) == false)
        {
            goto label_9;
        }
        
        if(( & 1) != 0)
        {
            goto label_9;
        }
        
        if(val_8 == false)
        {
            goto label_10;
        }
        
        if(( & 1) == 0)
        {
            goto label_11;
        }
        
        val_9 = 0;
        val_10 = 0;
        val_11 = 0;
        val_12 = 0;
        val_8 = 1;
        goto label_15;
        label_10:
        val_8 = 0;
        label_9:
        val_9 = 0;
        val_10 = 0;
        val_11 = 0;
        val_12 = 0;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyCardsBody, 丏业丟一东丂东丘丛:  val_8 & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToGatchaButton, 丏业丟一东丂东丘丛:  val_10 & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.freeBattlePassButton, 丏业丟一东丂东丘丛:  val_12 & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.paidBattlePassButton, 丏业丟一东丂东丘丛:  val_11 & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToChestsEventButton, 丏业丟一东丂东丘丛:  val_9 & 1);
        this.业丁上万丌丐业不丏();
        return;
        label_11:
        goto label_15;
    }
    public void HandleEquipClicked()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleEquipButton();
        this.丛丏丌丗三上丛专世();
    }
    private void 丄一不丟丙东丄丆丗()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleUnequipButton();
        this.丛丏丌丗三上丛专世();
    }
    public void U_HandleGoToGatcha()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐东丕专一世丆丑且(丏世丑万世一七丟丞:  this.丌丌丒上丄丅丕丟丌.Id);
        this.Close();
    }
    public void U_HandleGoToChestsEvent()
    {
        var val_5;
        var val_6;
        丙且上东下丏丏丟下 val_7;
        val_5 = null;
        val_5 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑();
        }
        else
        {
                val_7 = 0.东丂丈与丄丛万丞丑();
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.业丄丘丗丏丒与三专(丑丝丏丂且不下一东:  val_7);
        this.Close();
    }
    public void U_HandleGoToBattlePass()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        PGCompany.BattlePass.BattlePassGuiHandler.丙丂丂丕专丞世下与(丑丝丏丂且不下一东:  ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑(), 七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 专丆丌丛东一不丑丙:  0);
        this.Close();
    }
    public void Handle_Pet_UpgradeClicked()
    {
        var val_23;
        var val_24;
        System.Action val_26;
        var val_27;
        丙且上东下丏丏丟下 val_28;
        CategoryNames val_29;
        var val_30;
        var val_31;
        PetInfoController.丑三与丒丛业专世与 val_1 = new PetInfoController.丑三与丒丛业专世与();
        .丝且与丝丒丟万丁专 = this;
        if(this.丌丌丒上丄丅丕丟丌 == null)
        {
                return;
        }
        
        if(this.丘丒丙丈丒丅与丐丙 == false)
        {
                return;
        }
        
        丈丞丕丘丕丗与上一 val_2 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  168, 丞一丁业丄一一业且:  this.丌丌丒上丄丅丕丟丌.Id, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        .丒世丘丘上丆丝东丞 = val_2;
        if(val_2 == null)
        {
                return;
        }
        
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  (PetInfoController.丑三与丒丛业专世与)[1152921535481352560].丒世丘丘上丆丝东丞.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false})) == false)
        {
            goto label_11;
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = null;
        val_24 = null;
        val_26 = PetInfoController.<>c.<>9__100_1;
        if(val_26 == null)
        {
                System.Action val_9 = null;
            val_26 = val_9;
            val_9 = new System.Action(object:  PetInfoController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PetInfoController.<>c::丕丅丁世一世丟丒丕());
            PetInfoController.<>c.<>9__100_1 = val_26;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  ShopNGUIController.丏丙丅丕一丑丕丑丑.mainPanel, 丒世丘丘上丆丝东丞:  (PetInfoController.丑三与丒丛业专世与)[1152921535481352560].丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void PetInfoController.丑三与丒丛业专世与::不丕万丌专丘丟世丕()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  val_9, 丞丐下东与丅万丅丁:  new System.Action(object:  val_1, method:  System.Void PetInfoController.丑三与丒丛业专世与::丘世不丁业丟下丄丗()), 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  76);
        return;
        label_11:
        UnityEngine.Debug.LogError(message:  "Arsenal train pet (not enough currency) -> GoToMainStore");
        val_27 = null;
        val_27 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_28 = ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑();
        }
        else
        {
                val_28 = 0.东丂丈与丄丛万丞丑();
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丁七丁丞丞丟丒业丅 = val_28;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_29 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且();
        }
        else
        {
                val_29 = 0.丗丛丐丑丛丅丞七且();
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌不丒万万丟丞上与 = val_29;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丕丏丑丏丏丂与东丏 = ShopNGUIController.丛丐丛专丟丞万三七();
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  (PetInfoController.丑三与丒丛业专世与)[1152921535481352560].丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        val_30 = null;
        val_30 = null;
        if((System.String.op_Equality(a:  (PetInfoController.丑三与丒丛业专世与)[1152921535481352560].丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_36;
        }
        
        if(PetInfoController.丄丆下万丛丅丒丘七 != null)
        {
            goto label_37;
        }
        
        return;
        label_36:
        val_31 = null;
        val_31 = null;
        if((System.String.op_Equality(a:  (PetInfoController.丑三与丒丛业专世与)[1152921535481352560].丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
                return;
        }
        
        if(PetInfoController.丈丘下丏丆丐业丌丄 == null)
        {
                return;
        }
        
        label_37:
        PetInfoController.丈丘下丏丆丐业丌丄.Invoke();
    }
    private void 业且世万丐七不上丁()
    {
        PetInfo val_5;
        var val_6;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeParticles, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeParticles, 丏业丟一东丂东丘丛:  true);
        DisableObjectFromTimer val_1 = this.upgradeParticles.GetComponent<DisableObjectFromTimer>();
        val_1.timer = 2f;
        bool val_3 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丌上七丕专一东丝丏(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id);
        val_5 = this.丌丌丒上丄丅丕丟丌;
        if(val_5 == null)
        {
                return;
        }
        
        val_6 = null;
        val_5 = this.丌丌丒上丄丅丕丟丌;
        if(val_5 != null)
        {
                val_6 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丌丌丒上丄丅丕丟丌.Id, 七丆丒与丗丌丄且丂:  168));
            this.世业丄丐三丂丛丈世();
            this.丌下丅万丆丁丈丒且();
            this.世上丒丙与丘丄丕且();
            this.丛丏丌丗三上丛专世();
            this.丞丄业丈业东丐专丛();
            this.HandleEquipClicked();
            return;
        }
    
    }
    public void Close()
    {
        this.DestroyWindow();
        if(this.丄丑上丕丂丈丘丙七 == null)
        {
                return;
        }
        
        this.丄丑上丕丂丈丘丙七.Invoke();
    }
    public void DestroyWindow()
    {
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void PlayTapAnimation()
    {
        UnityEngine.Object val_14;
        if(this.丄且丙丏三丁丙丁业 == 0)
        {
                return;
        }
        
        UnityEngine.Animation val_2 = this.丄且丙丏三丁丙丁业.GetComponent<UnityEngine.Animation>();
        if(val_2 == 0)
        {
                return;
        }
        
        val_14 = val_2.clip;
        if(val_14 != 0)
        {
                if((System.String.op_Equality(a:  val_2.clip.name, b:  "Tap")) == true)
        {
                return;
        }
        
        }
        
        val_14 = "Tap";
        if((System.String.op_Equality(a:  this.丝不丆丙下丐专丑丘, b:  "Tap")) != false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.一不丅业丆丂丒丆丛 != 0)
        {
                this.七三丁丗专下万丒一 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.一不丅业丆丂丒丆丛);
        }
        
        }
        
        this.专东丁丙丞丂东丝丁(七不丐下丟专业万丅:  "Tap", 丟丘丙丄丅万丏与丗:  new System.Action(object:  this, method:  System.Void PetInfoController::世丟上丙丑丆丏丒丄()));
    }
    public void U_BuyCards()
    {
        var val_5;
        var val_6;
        System.Action<System.Boolean> val_7;
        val_5 = null;
        val_5 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((ShopNGUIController.丏丙丅丕一丑丕丑丑.下丕三丄三丕丘东丒(丆万一不丌且东丐丐:  this.丌丌丒上丄丅丕丟丌.Id)) == false)
        {
                return;
        }
        
        PetInfoController.丑且丐丄业且丅业丅 val_3 = new PetInfoController.丑且丐丄业且丅业丅();
        if(val_3 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .七丙丈丈上丈丁下东 = 0;
        System.Action<System.Boolean> val_4 = null;
        val_7 = val_4;
        val_4 = new System.Action<System.Boolean>(object:  val_3, method:  System.Void PetInfoController.丑且丐丄业且丅业丅::丒丟万丅丟丐丛三丄(bool 丏业丟一东丂东丘丛));
        if(val_3 != null)
        {
                .七丙丈丈上丈丁下东 = val_7;
        }
        else
        {
                .七丙丈丈上丈丁下东 = val_7;
            val_7 = (PetInfoController.丑且丐丄业且丅业丅)[1152921535482251584].七丙丈丈上丈丁下东;
        }
        
        Rilisoft.BuySpecialCurrenciesWindowBase.add_OnVisibleStateChanged(丙业与丙丗丝不丈东:  val_7);
        this.petCamera.enabled = false;
    }
    public void UpdateState()
    {
        this.世业丄丐三丂丛丈世();
        this.丌下丅万丆丁丈丒且();
        this.世上丒丙与丘丄丕且();
        this.丛丏丌丗三上丛专世();
        this.丞丄业丈业东丐专丛();
    }
    private void 丞丄业丈业东丐专丛()
    {
        EfficiencyBar val_16;
        Rilisoft.丝丑丂丛万丐丈丘且 val_17;
        var val_18;
        var val_19;
        var val_20;
        int val_21;
        int val_22;
        int val_23;
        val_16 = this;
        if(this._efficiencyBar == 0)
        {
                return;
        }
        
        PetInfo val_3 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.丌丌丒上丄丅丕丟丌.Id);
        if(val_3 != null)
        {
                val_17 = val_3._indexContainer;
            val_18 = val_17;
        }
        else
        {
                val_17 = 16;
            val_18 = 16;
        }
        
        int val_5 = BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  16, 且万丛丒丁丏七丅东:  val_3.CurrentLevel, 丐丏上业丈丂与万丞:  false);
        if(val_3 != null)
        {
                val_19 = val_17;
        }
        else
        {
                val_19 = val_17;
        }
        
        int val_7 = BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  16, 且万丛丒丁丏七丅东:  val_3.CurrentLevel, 丐丏上业丈丂与万丞:  true);
        val_20 = val_17;
        if(this.专世丁与丙丟万丝丈 == false)
        {
            goto label_15;
        }
        
        val_21 = BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  16, 丘三丟三丁丂丙丑丆:  val_7, 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        if(val_3 == null)
        {
            goto label_18;
        }
        
        val_20 = val_17;
        goto label_19;
        label_15:
        val_21 = BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  16, 丘三丟三丁丂丙丑丆:  val_7, 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        val_22 = BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  16, 丘三丟三丁丂丙丑丆:  this.专丂丝业丞丄丟丐丒(), 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        val_23 = val_22;
        goto label_25;
        label_18:
        val_20 = val_17;
        label_19:
        val_23 = BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  16, 丘三丟三丁丂丙丑丆:  val_3.CurrentLevel, 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        if(val_5 > ExperienceController.丞丞丘业东丙丏七丌())
        {
                val_22 = val_23;
        }
        else
        {
                val_22 = BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  16, 丘三丟三丁丂丙丑丆:  val_5, 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        }
        
        label_25:
        val_16 = this._efficiencyBar;
        val_16.丝丘专专丛且丆丏东(七丝东丛东丝且丆不:  val_21, 上丞丕专丈业丁世专:  val_23, 丞丌东丟且丒丐丑丂:  val_22, 业上丞丐万三丒丘上:  0);
    }
    private void 业丁上万丌丐业不丏()
    {
        var val_11;
        System.Action<GameLoopSpriteOnButton> val_13;
        var val_14;
        System.Action<GameLoopSpriteOnButton> val_16;
        if((this.goToGatchaButton != 0) && (this.goToGatchaButton.activeInHierarchy != false))
        {
                val_11 = null;
            val_11 = null;
            val_13 = PetInfoController.<>c.<>9__109_0;
            if(val_13 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_4 = null;
            val_13 = val_4;
            val_4 = new System.Action<GameLoopSpriteOnButton>(object:  PetInfoController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PetInfoController.<>c::丅一丈丘丌世丕丄丌(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            PetInfoController.<>c.<>9__109_0 = val_13;
        }
        
            GameLoopSpriteOnButton val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  this.goToGatchaButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_4);
        }
        
        if(this.goToChestsEventButton == 0)
        {
                return;
        }
        
        if(this.goToChestsEventButton.activeInHierarchy == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = PetInfoController.<>c.<>9__109_1;
        if(val_16 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_9 = null;
            val_16 = val_9;
            val_9 = new System.Action<GameLoopSpriteOnButton>(object:  PetInfoController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PetInfoController.<>c::丟专一且丑丑丈丐且(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            PetInfoController.<>c.<>9__109_1 = val_16;
        }
        
        GameLoopSpriteOnButton val_10 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  this.goToChestsEventButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_9);
    }
    public PetInfoController()
    {
        this._simpleInfoPanelY = -44f;
        this._simplePetModelY = 2.571383E-41f;
        this._battlePassPetModelY = 0.36f;
    }
    private void 七丛三丞丑万丒东世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_1;
        if(this.丘丒丙丈丒丅与丐丙 != false)
        {
                this.Close();
        }
        
        val_1 = null;
        val_1 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleRenamePetButton();
    }
    private void 丟丟七丄丒丘丕丈丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.HandleEquipClicked();
    }
    private void 丌丝上不丟丌丑不丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丄一不丟丙东丄丆丗();
    }
    private void 丄上丑七丝三丁丁七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.HandleEquipClicked();
    }
    private void 万一丕丝丕万丟丁丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.Handle_Pet_UpgradeClicked();
    }
    private void 世丟上丙丑丆丏丒丄()
    {
        this.专东丁丙丞丂东丝丁(七不丐下丟专业万丅:  "Profile", 丟丘丙丄丅万丏与丗:  0);
    }

}
