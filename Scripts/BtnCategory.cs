using UnityEngine;
public class BtnCategory : MonoBehaviour
{
    // Fields
    private bool 丌丕丘丒业丂丝丒丐;
    public UnityEngine.Transform[] holdScale;
    public UnityEngine.GameObject lockSprite;
    public UISprite normalState;
    public bool UsePressedStateColorFromGui;
    public UISprite pressedState;
    public UITweener btnAnimation;
    public UnityEngine.GameObject mapEvent;
    public UnityEngine.GameObject mapTournamentEvent;
    public CategoryButtonsController btnController;
    public bool isPressed;
    public bool isDefault;
    private UnityEngine.Color 三丝丛丆丁丘与丝东;
    private UnityEngine.Color 上丝丂丄丛丒丌丁三;
    private UnityEngine.Color 丏丌不丙专丗丙丛丙;
    public float animTime;
    public string btnName;
    public bool wasPressed;
    private bool 东七丝万丗丐一丐丒;
    private System.EventHandler 丅丕丌丛万丂丈七与;
    public System.Collections.Generic.List<BtnCategoryDependent> _dependents;
    public UnityEngine.GameObject _silverShield;
    public UnityEngine.GameObject _goldenShield;
    private UILabel[] _doubleRewardLabels;
    private Rilisoft.七丕丟丏三丈一丄世 _gameMode;
    private UnityEngine.GameObject clanWarTaskTexture;
    internal UIGrid gridIndicators;
    internal GameModeUnlocks unlocksController;
    private CategoryHint hint;
    private Rilisoft.NewDayWatcher 丅与七丟上丏丑丅丒;
    
    // Properties
    public bool 丞七丛与丝下一一丆 { get; set; }
    public bool 丘丈世丘七且丑丗丘 { get; }
    private Rilisoft.NewDayWatcher 丈七业且丝丗丏丏丆 { get; }
    internal Rilisoft.七丕丟丏三丈一丄世 七丕丟丏三丈一丄世 { get; }
    
    // Methods
    public bool get_isEnable()
    {
        return (bool)this.丌丕丘丒业丂丝丒丐;
    }
    public void set_isEnable(bool 丙业与丙丗丝不丈东)
    {
        this.丌丕丘丒业丂丝丒丐 = 丙业与丙丗丝不丈东;
        if(this.lockSprite != 0)
        {
                this.lockSprite.SetActive(value:  (this.丌丕丘丒业丂丝丒丐 == false) ? 1 : 0);
        }
        
        this.万下丆丆丘丘三丐且();
    }
    public void add_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921525542880800);
    
    }
    public void remove_Clicked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921525543017376);
    
    }
    public bool get_IsAnimationPlayed()
    {
        return (bool)this.东七丝万丗丐一丐丒;
    }
    private Rilisoft.NewDayWatcher 万不业不丂丏三丕一()
    {
        var val_10;
        Rilisoft.NewDayWatcher val_11;
        if(this.丅与七丟上丏丑丅丒 == 0)
        {
                val_10 = this;
            if(this.transform.parent != 0)
        {
                val_10 = this.transform.parent;
        }
        
            this.丅与七丟上丏丑丅丒 = val_10.gameObject.AddComponent<Rilisoft.NewDayWatcher>();
            return val_11;
        }
        
        val_11 = this.丅与七丟上丏丑丅丒;
        return val_11;
    }
    internal Rilisoft.七丕丟丏三丈一丄世 业丄丄且丕丕不一万()
    {
        return (Rilisoft.七丕丟丏三丈一丄世)this._gameMode;
    }
    private void Start()
    {
        GameConnect.丞且丛东不丈下且东(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BtnCategory::丒丌丗丗丕世丄丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this.hint != 0)
        {
                this.hint.丑丈丙丟丑丆丌且丛(丙业与丙丗丝不丈东:  this._gameMode);
        }
        
        this.丑上丒世世丑世业万();
    }
    private void 丑上丒世世丑世业万()
    {
        UnityEngine.Object val_18;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  108)) != true)
        {
                val_18 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_18.丂世三丅一万东三三(不七丆万丁一丞七下:  52)) == false)
        {
                return;
        }
        
        }
        
        val_18 = this.gameObject.GetComponent<TagSystem.CompoundTagBehaviour>();
        if(val_18 == 0)
        {
                val_18 = this.gameObject.AddComponent<TagSystem.CompoundTagBehaviour>();
        }
        
        if((val_18.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "ConnectSceneModeTab")) != true)
        {
                val_18.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  "ConnectSceneModeTab");
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        if((val_18.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "ConnectSceneModeTab" + this._gameMode.ToString())) != false)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        val_18.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  "ConnectSceneModeTab" + this._gameMode.ToString());
    }
    private void OnDestroy()
    {
        GameConnect.万上与丑丁与丕丟一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BtnCategory::丒丌丗丗丕世丄丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnEnable()
    {
        this.一丟专一下丗丂丒丁();
        this.万丘丞与丘万业丆丟();
        this.万下丆丆丘丘三丐且();
        this.丟丟丞丛丟七丐丈丝();
        if(this.万不业不丂丏三丕一() == 0)
        {
                return;
        }
        
        this.万不业不丂丏三丕一().下世丁东七丗万上丁(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BtnCategory::万丂丁与丗丐丄七丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal bool 丆丕业丐丄丌一不专()
    {
        Rilisoft.七丕丟丏三丈一丄世 val_2;
        var val_3;
        val_2 = this;
        if(this.unlocksController != 0)
        {
                val_2 = this._gameMode;
            this.unlocksController.上丛丌丆丑上七世三(上且丗一丏丏万丅丌:  val_2);
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    private void OnDisable()
    {
        if(this.万不业不丂丏三丕一() != 0)
        {
                this.万不业不丂丏三丕一().丈丂丏下丈专丛丝丞(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BtnCategory::万丂丁与丗丐丄七丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        this.一丟专一下丗丂丒丁();
    }
    private void 丟丟丞丛丟七丐丈丝()
    {
        var val_16;
        var val_17;
        int val_18;
        var val_19;
        UnityEngine.GameObject val_20;
        UnityEngine.GameObject val_21;
        var val_22;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丞丕业丞丆丘下三()) == false)
        {
            goto label_2;
        }
        
        val_16 = new Rilisoft.七丕丟丏三丈一丄世[1];
        val_16[0] = this._gameMode;
        if(this.clanWarTaskTexture == 0)
        {
            goto label_12;
        }
        
        val_17 = 0;
        if((this._gameMode == 22) || (this._gameMode == 100))
        {
            goto label_33;
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0)
        {
            goto label_12;
        }
        
        if(this._gameMode == 4)
        {
                val_16 = new Rilisoft.七丕丟丏三丈一丄世[2];
            val_18 = val_7.Length;
            if(val_18 == 0)
        {
                val_18 = val_7.Length;
        }
        
            val_16[0] = this._gameMode;
            val_16[0] = 5;
        }
        
        if(val_7.Length < 1)
        {
            goto label_17;
        }
        
        val_19 = 0;
        var val_18 = 0;
        do
        {
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑上一丒东丑业丈丐().ContainsKey(key:  val_16[0])) != false)
        {
                var val_15 = ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑上一丒东丑业丈丐().Item[val_7[0x0] + 32].Count) < 1) ? (val_19) : (0 + 1);
        }
        
            val_18 = val_18 + 1;
        }
        while(val_18 < val_7.Length);
        
        goto label_27;
        label_2:
        val_20 = this.clanWarTaskTexture;
        val_21 = val_20;
        val_22 = 0;
        goto label_30;
        label_12:
        val_17 = 0;
        label_33:
        val_20 = this.clanWarTaskTexture;
        val_21 = val_20;
        val_22 = val_17;
        label_30:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  false);
        return;
        label_17:
        val_19 = 0;
        label_27:
        var val_16 = val_19 & 1;
        goto label_33;
    }
    private void 万丂丁与丗丐丄七丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.万丘丞与丘万业丆丟();
    }
    private void 丒丌丗丗丕世丄丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.万丘丞与丘万业丆丟();
        this.万下丆丆丘丘三丐且();
    }
    private void 万下丆丆丘丘三丐且()
    {
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_1 = PGCompany.BattlePass.BattlePassConnectScene.与业下丏丂上三丗丗(丂丛丑东不丅丈一东:  this._gameMode, 不丌丒丆丞下丙专万:  true);
        if((val_1 != null) && (val_1.Count != 0))
        {
                if((val_1.Item[0].业上丙丞丐丄丆丅七() != 9999) && (this.丌丕丘丒业丂丝丒丐 != false))
        {
                if(this._gameMode != 35)
        {
            goto label_6;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._silverShield, 丏业丟一东丂东丘丛:  false);
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goldenShield, 丏业丟一东丂东丘丛:  false);
        return;
        label_6:
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_5 = val_1.Item[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._silverShield, 丏业丟一东丂东丘丛:  (val_5.丏丐七上业丆与丘专() == 0) ? 1 : 0);
        var val_9 = (val_5.丏丐七上业丆与丘专() == 1) ? 1 : 0;
        goto label_13;
    }
    private void 万丘丞与丘万业丆丟()
    {
        UILabel val_11;
        var val_12;
        if(this._doubleRewardLabels == null)
        {
                return;
        }
        
        if(this._doubleRewardLabels.Length == 0)
        {
                return;
        }
        
        val_11 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世();
        bool val_2 = val_11.东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  this._gameMode);
        val_12 = 0;
        goto label_20;
        label_34:
        val_11 = this._doubleRewardLabels[0];
        if(val_11 != 0)
        {
                val_11.gameObject.SetActive(value:  val_2);
            if(val_2 != false)
        {
                string val_9 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "x{0}", arg0:  Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丑丆丗丞丈不丘丞丝(丅丈专上丄丅丛丈业:  this._gameMode));
            val_11.text = val_9;
        }
        
        }
        
        val_12 = 1;
        label_20:
        if(val_12 < this._doubleRewardLabels.Length)
        {
            goto label_34;
        }
    
    }
    internal void 一丟专一下丗丂丒丁()
    {
        var val_10;
        float val_14;
        var val_15;
        CategoryButtonsController val_16;
        UnityEngine.Color val_17;
        var val_19;
        UISprite val_20;
        float val_23;
        float val_24;
        this.东七丝万丗丐一丐丒 = false;
        if(this.isDefault != false)
        {
                this.btnController.currentBtnName = this.btnName;
            this.isPressed = true;
            this.wasPressed = true;
        }
        else
        {
                this.isPressed = false;
        }
        
        this.三丝丛丆丁丘与丝东 = 0;
        mem[1152921525545764576] = 0;
        mem[1152921525545764584] = 0;
        this.上丝丂丄丛丒丌丁三 = 0;
        mem[1152921525545764592] = 0;
        mem[1152921525545764600] = 0;
        this.丏丌不丙专丗丙丛丙 = 0;
        mem[1152921525545764608] = 0;
        mem[1152921525545764616] = 0;
        if(this.isPressed == false)
        {
            goto label_4;
        }
        
        UnityEngine.Transform val_1 = this.transform;
        if(this.btnController.isConnectScene == false)
        {
            goto label_6;
        }
        
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_4:
        val_10 = 1152921504838316032;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        val_14 = val_3.y;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_14, z = val_3.z};
        val_15 = 0;
        goto label_13;
        label_20:
        val_16 = 0;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        val_14 = val_4.y;
        this.holdScale[val_16].localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_14, z = val_4.z};
        val_15 = 1;
        label_13:
        if(val_15 < this.holdScale.Length)
        {
            goto label_20;
        }
        
        val_17 = this.上丝丂丄丛丒丌丁三;
        val_19 = 0;
        this.normalState.color = new UnityEngine.Color() {r = val_17, g = val_14, b = val_4.z, a = V11.16B};
        if(this.UsePressedStateColorFromGui == true)
        {
            goto label_44;
        }
        
        val_20 = this.pressedState;
        val_17 = this.三丝丛丆丁丘与丝东;
        if(val_20 != null)
        {
            goto label_45;
        }
        
        goto label_24;
        label_6:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.btnController.scaleMultypler);
        val_23 = val_6.x;
        val_24 = val_6.z;
        label_9:
        val_1.localScale = new UnityEngine.Vector3() {x = val_23, y = val_6.y, z = val_24};
        val_10 = 0;
        goto label_29;
        label_42:
        UnityEngine.Transform val_11 = this.holdScale[0];
        if(this.btnController.isConnectScene != false)
        {
                val_16 = this.btnController;
            float val_12 = this.btnController.scaleMultypler;
            val_12 = 1f / val_12;
            if(val_11 != null)
        {
            goto label_36;
        }
        
        }
        else
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_16 = this.btnController;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.btnController.scaleMultypler);
            val_23 = val_8.x;
            val_24 = val_8.z;
        }
        
        label_36:
        val_11.localScale = new UnityEngine.Vector3() {x = val_23, y = val_8.y, z = val_24};
        val_10 = 1;
        label_29:
        if(val_10 < this.holdScale.Length)
        {
            goto label_42;
        }
        
        val_17 = this.三丝丛丆丁丘与丝东;
        val_19 = 0;
        this.normalState.color = new UnityEngine.Color() {r = val_17, g = val_23, b = val_8.y, a = val_24};
        if(this.UsePressedStateColorFromGui == true)
        {
            goto label_44;
        }
        
        val_20 = this.pressedState;
        val_17 = this.上丝丂丄丛丒丌丁三;
        if(val_20 != null)
        {
            goto label_45;
        }
        
        label_24:
        label_45:
        val_19 = 0;
        val_20.color = new UnityEngine.Color() {r = val_17, g = val_23, b = val_8.y, a = val_24};
        label_44:
        if(this.btnController.isConnectScene != true)
        {
                bool val_9 = UnityEngine.Object.op_Inequality(x:  this.btnController.buttonsTableSecond, y:  0);
        }
        
        this.丝下丈丒专丒丌丌丞(丑世丁丙三丑丒丗丆:  this.isPressed);
    }
    public System.Collections.IEnumerator SetButtonPressed(bool 丆东丈丕上丏三丈上, bool 丌丝丌丁下丐丞丆一 = False)
    {
        BtnCategory.丘世丌丂七丈不不不 val_1 = new BtnCategory.丘世丌丂七丈不不不();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丆东丈丕上丏三丈上 = 丆东丈丕上丏三丈上;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丆东丈丕上丏三丈上;
        }
        
        .丌丝丌丁下丐丞丆一 = 丌丝丌丁下丐丞丆一;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丈世丅丂丌三丅业丆(float 丄丐丘丛丒丛丑丟丑)
    {
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        var val_19;
        CategoryButtonsController val_20;
        float val_24;
        float val_25;
        float val_26;
        if(this.btnController.isConnectScene != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_15 = 0f;
            val_16 = 0f;
            val_17 = 0;
        }
        else
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.btnController.scaleMultypler);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            val_15 = val_4.x;
            val_16 = val_4.y;
            val_17 = val_4.z;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, t:  丄丐丘丛丒丛丑丟丑);
        val_18 = val_6.y;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_18, z = val_6.z};
        val_19 = 0;
        goto label_11;
        label_25:
        if(this.btnController.isConnectScene != false)
        {
                val_20 = this.btnController;
            float val_13 = this.btnController.scaleMultypler;
            val_13 = 1f / val_13;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_24 = 0f;
            val_25 = 0f;
            val_26 = 0;
        }
        else
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            val_20 = this.btnController;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.btnController.scaleMultypler);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_24 = val_9.x;
            val_25 = val_9.y;
            val_26 = val_9.z;
        }
        
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, t:  丄丐丘丛丒丛丑丟丑);
        val_18 = val_11.x;
        this.holdScale[0].localScale = new UnityEngine.Vector3() {x = val_18, y = val_11.y, z = val_11.z};
        val_19 = 1;
        label_11:
        if(val_19 < this.holdScale.Length)
        {
            goto label_25;
        }
    
    }
    private bool 丞丙业丌丑专下丁丄()
    {
        if((System.String.op_Equality(a:  this.btnName, b:  "Weapons")) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  this.btnName, b:  "Gadgets")) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  this.btnName, b:  "BattleRoyale")) == false)
        {
                return System.String.op_Equality(a:  this.btnName, b:  "Wear");
        }
        
        return true;
    }
    public void OnClick()
    {
        var val_5;
        if(this.丌丕丘丒业丂丝丒丐 == false)
        {
            goto label_1;
        }
        
        if(this.丅丕丌丛万丂丈七与 != null)
        {
                val_5 = null;
            val_5 = null;
            this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        
        if(this.isPressed == true)
        {
                return;
        }
        
        if(this.东七丝万丗丐一丐丒 == false)
        {
            goto label_6;
        }
        
        return;
        label_1:
        this.专丅丁万世七丒丑丕();
        return;
        label_6:
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(this.丞丙业丌丑专下丁丄() != true)
        {
                if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void BtnCategory::世不三丈丄上丘丝丞()))) == true)
        {
                return;
        }
        
        }
        
        this.世不三丈丄上丘丝丞();
    }
    internal void 专丅丁万世七丒丑丕()
    {
        if(this.hint == 0)
        {
                return;
        }
        
        this.hint.丞万东一丒丆丟丞丂();
        this.hint.gameObject.SetActive(value:  true);
        if(this._gameMode != 35)
        {
                return;
        }
        
        this.hint.世丙丅不丂丅丄丘且();
    }
    private void 世不三丈丄上丘丝丞()
    {
        string val_11 = this.btnName;
        this.btnController.BtnClicked(丟专丛丏丝万丘丄丗:  val_11 = this.btnName, 丌丝丌丁下丐丞丆一:  false);
        if(this.btnAnimation != 0)
        {
                this.btnAnimation.ResetToBeginning();
            this.btnAnimation.PlayForward();
        }
        
        if(this.btnController.actions == null)
        {
                return;
        }
        
        if(this.btnController.buttons == null)
        {
                return;
        }
        
        int val_4 = System.Linq.Enumerable.ToList<BtnCategory>(source:  this.btnController.buttons).IndexOf(item:  this);
        if(val_4 == 1)
        {
                return;
        }
        
        val_11 = this.btnController.actions;
        if(val_11.Count <= val_4)
        {
                return;
        }
        
        val_11 = this.btnController.actions;
        if(val_11.Item[val_4] == null)
        {
                return;
        }
        
        val_11 = this.btnController.actions;
        val_11.Item[val_4].Invoke(obj:  this);
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(this.丌丕丘丒业丂丝丒丐 == false)
        {
                return;
        }
        
        if(this.isPressed != false)
        {
                return;
        }
        
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_2;
        }
        
        if(this.normalState != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.normalState.color = new UnityEngine.Color() {r = this.丏丌不丙专丗丙丛丙, g = V9.16B, b = V10.16B, a = V11.16B};
        return;
        label_2:
        if(this.normalState != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    private void 丝下丈丒专丒丌丌丞(bool 丑世丁丙三丑丒丗丆)
    {
        var val_3;
        List.Enumerator<T> val_1 = this._dependents.GetEnumerator();
        label_16:
        if(((-534143968) & 1) == 0)
        {
            goto label_2;
        }
        
        if((val_3.丐丏七丌丕丗业且上() == null) || (val_4.m_stringLength == 0))
        {
            goto label_16;
        }
        
        bool val_8 = ((UnityEngine.Object.__il2cppRuntimeField_cctor_finished != 0) ? 1 : 0) ^ 丑世丁丙三丑丒丗丆;
        UnityEngine.Object.__il2cppRuntimeField_cctor_finished = val_8 ^ val_4.m_stringLength.activeSelf;
        val_4.m_stringLength.SetActive(value:  val_8);
        if((System.String.op_Equality(a:  this.btnName, b:  "LastGames")) == false)
        {
            goto label_16;
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.七丄且丐丅世丂丘丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世());
        goto label_16;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 且丞丆丅丞丒丝与业(Rilisoft.七丕丟丏三丈一丄世[] 业丐世丆不上丏丏业)
    {
        var val_5;
        var val_6;
        System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_8;
        UnityEngine.GameObject val_9;
        UnityEngine.GameObject val_10;
        var val_11;
        val_5 = 0;
        goto label_1;
        label_12:
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  业丐世丆不上丏丏业[0], 丞丁丑丏丄丏七丂不:  0);
        if(val_2 == null)
        {
            goto label_4;
        }
        
        val_6 = null;
        val_6 = null;
        val_8 = BtnCategory.<>c.<>9__61_0;
        if(val_8 == null)
        {
                System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  BtnCategory.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BtnCategory.<>c::专丗丂丘丄与万万丗(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑));
            BtnCategory.<>c.<>9__61_0 = val_8;
        }
        
        if((System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_2, predicate:  val_3)) == true)
        {
            goto label_10;
        }
        
        label_4:
        val_5 = 1;
        label_1:
        if(val_5 < 业丐世丆不上丏丏业.Length)
        {
            goto label_12;
        }
        
        val_9 = mem[1152921525547736400];
        val_10 = val_9;
        val_11 = 0;
        goto label_15;
        label_10:
        val_9 = mem[1152921525547736400];
        val_11 = 1;
        val_10 = val_9;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
    }
    private void 丞丘上七一丒丘丁丑(Rilisoft.七丕丟丏三丈一丄世[] 业丐世丆不上丏丏业)
    {
        var val_8;
        var val_9;
        System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_11;
        var val_12;
        Rilisoft.七丕丟丏三丈一丄世 val_13;
        var val_14;
        val_8 = 0;
        goto label_1;
        label_12:
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_2 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  业丐世丆不上丏丏业[0], 丞丁丑丏丄丏七丂不:  0);
        if(val_2 == null)
        {
            goto label_4;
        }
        
        val_9 = null;
        val_9 = null;
        val_11 = BtnCategory.<>c.<>9__62_0;
        if(val_11 == null)
        {
                System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  BtnCategory.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BtnCategory.<>c::三丛丒丞不丛业丑下(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑));
            BtnCategory.<>c.<>9__62_0 = val_11;
        }
        
        if((System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_2, predicate:  val_3)) == true)
        {
            goto label_10;
        }
        
        label_4:
        val_8 = 1;
        label_1:
        if(val_8 < 业丐世丆不上丏丏业.Length)
        {
            goto label_12;
        }
        
        val_13 = 0;
        goto label_13;
        label_10:
        val_13 = 1;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921525547969232], 丏业丟一东丂东丘丛:  true);
        if(业丐世丆不上丏丏业.Length >= 1)
        {
                val_12 = 1152921525547931840;
            do
        {
            val_13 = 业丐世丆不上丏丏业[0];
            System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_6 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丑不七不万丙丆七东(丂丛丑东不丅丈一东:  val_13, 丞丁丑丏丄丏七丂不:  0);
            if(val_6 != null)
        {
                if((System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_6)) == true)
        {
            goto label_20;
        }
        
        }
        
        }
        while((0 + 1) < 业丐世丆不上丏丏业.Length);
        
        }
        
        val_14 = 0;
        goto label_22;
        label_20:
        val_14 = 1;
        label_22:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921525547969240], 丏业丟一东丂东丘丛:  true);
    }
    internal void 业丘丒世业丈下万业()
    {
        var val_25;
        System.Collections.Generic.IEnumerable<TSource> val_26;
        bool val_27;
        UnityEngine.GameObject val_28;
        UnityEngine.GameObject val_29;
        bool val_30;
        bool val_31;
        var val_32;
        System.Func<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_34;
        var val_35;
        val_25 = this;
        if(this._gameMode == 32)
        {
                val_26 = 0;
        }
        else
        {
                val_26 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  this._gameMode, 丞丁丑丏丄丏七丂不:  0);
        }
        
        val_27 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this._gameMode);
        val_28 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_6 = val_28.丑不七不万丙丆七东(丂丛丑东不丅丈一东:  this._gameMode, 丞丁丑丏丄丏七丂不:  0);
        if(this._gameMode != 4)
        {
            goto label_8;
        }
        
        if(val_27 == false)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapEvent, 丏业丟一东丂东丘丛:  false);
        val_29 = this.mapTournamentEvent;
        val_30 = 0;
        goto label_12;
        label_8:
        val_28 = this.mapEvent;
        var val_7 = (val_26 == 0) ? 1 : 0;
        val_7 = val_7 | val_27;
        if(val_7 == false)
        {
            goto label_13;
        }
        
        val_31 = 0;
        goto label_14;
        label_9:
        this.且丞丆丅丞丒丝与业(业丐世丆不上丏丏业:  new Rilisoft.七丕丟丏三丈一丄世[3]);
        goto label_15;
        label_13:
        val_32 = null;
        val_32 = null;
        val_34 = BtnCategory.<>c.<>9__63_0;
        if(val_34 == null)
        {
                BtnCategory.<>c val_9 = null;
            val_34 = val_9;
            val_9 = new BtnCategory.<>c(object:  BtnCategory.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BtnCategory.<>c::丄丅丙丑一丌下业丏(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 三丟东丕丄丄下下丑));
            BtnCategory.<>c.<>9__63_0 = val_34;
        }
        
        val_31 = System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_26, predicate:  val_9);
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_28, 丏业丟一东丂东丘丛:  val_31);
        var val_11 = (val_6 == 0) ? 1 : 0;
        val_11 = val_27 | val_11;
        if(val_11 != false)
        {
                val_27 = 0;
        }
        else
        {
                val_27 = System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  val_6);
        }
        
        val_29 = this.mapTournamentEvent;
        val_30 = val_27;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29, 丏业丟一东丂东丘丛:  val_30);
        label_15:
        if(this.gridIndicators == 0)
        {
                return;
        }
        
        val_25 = ???;
        val_27 = ???;
        val_28 = ???;
        val_35 = ???;
        goto typeof(UIGrid).__il2cppRuntimeField_1A8;
    }
    public BtnCategory()
    {
        this.丌丕丘丒业丂丝丒丐 = true;
        this.animTime = 0.7f;
    }

}
