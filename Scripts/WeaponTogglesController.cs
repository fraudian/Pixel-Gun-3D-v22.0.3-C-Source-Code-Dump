using UnityEngine;
public class WeaponTogglesController : MonoBehaviour
{
    // Fields
    internal bool 丝丞丝与丒丄丙丒丙;
    public UnityEngine.GameObject[] weaponCategoriesButtonsGO;
    private UIButton[] weaponCategoriesButtons;
    private UIButton[] weaponCategoriesButtonsDater;
    private UILabel[] ammoCategoriesLabels;
    private UILabel[] ammoCategoriesLabelsDater;
    private UISprite[] weaponCategoriesCheckmarkSprites;
    private UISprite[] weaponGadgetCooldownSprites;
    private UISprite[] weaponGadgetDurationSprites;
    private WeaponToggleModulesUI[] weaponTogglesModulesUI;
    public UnityEngine.GameObject[] upButtonsInShopPanel;
    private int 不丛三三专丛一万丝;
    private UIBasicSprite[] weaponIcons;
    private bool 丗丂丕丒丙与丗丕丁;
    private UIBasicSprite[] weaponIconsDater;
    private UnityEngine.Transform shopPanelForTap;
    private UnityEngine.Transform shopPanelForTapDater;
    internal static UnityEngine.Vector3 上与丞业三丆丌丘七;
    internal static UnityEngine.Vector3 一世丝丒丂下七丆上;
    internal static UnityEngine.Vector3 不一下下丗丑丒丘下;
    public UIButton gearToogle;
    private bool 世且万丒不丐三丕丌;
    internal System.Collections.Generic.Dictionary<int, int> 七丈丂丌丝世丞丄丛;
    private float 丑丕丄丝丅下丂丏上;
    private float 丌世丕东世丅丘丂丘;
    public UnityEngine.GameObject fonBig;
    private System.Collections.Generic.List<UIBasicSprite> 丅丟业一东专万七业;
    private const string 丘丕丛与不万下世一 = "WeaponCat_";
    public UnityEngine.Texture2D[] emptyWeaponIcons;
    private readonly System.Text.StringBuilder 丕东专丙上且丑丙七;
    private System.Collections.Generic.KeyValuePair<int, string>[] 丂丘丘丌七丌丆与丟;
    private System.Collections.Generic.KeyValuePair<Rilisoft.专丈世丗业不世丗丙, string>[] 不丁丟丕丞万丑丞丝;
    
    // Properties
    private Player_move_c 丕丁丘丆万丄世专丛 { get; }
    private UIBasicSprite[] 丄丆丘一丙万丅丁下 { get; }
    private UIBasicSprite[] 不一丒丏下丞一世三 { get; }
    
    // Methods
    private Player_move_c 丝三丁七丟丅丝丒上()
    {
        null = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                return (Player_move_c)WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        return (Player_move_c)WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
    }
    private UIBasicSprite[] 丗丂丘丆丈丌丕且丌()
    {
        UIBasicSprite[] val_3;
        var val_4;
        if(this.丗丂丕丒丙与丗丕丁 != false)
        {
                val_3 = this.weaponIcons;
            return val_3;
        }
        
        this.丗丂丕丒丙与丗丕丁 = true;
        val_3 = new UIBasicSprite[0];
        val_4 = 0;
        goto label_4;
        label_16:
        UIBasicSprite val_2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.weaponIcons[0]);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if(val_2 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_2 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_4 = 1;
        val_3[0] = val_2;
        label_4:
        if(val_4 < this.weaponIcons.Length)
        {
            goto label_16;
        }
        
        this.weaponIcons = val_3;
        return val_3;
    }
    private UIBasicSprite[] 上丐一丄且三丒丐世()
    {
        UIBasicSprite[] val_3;
        var val_4;
        if(this.世且万丒不丐三丕丌 != false)
        {
                val_3 = this.weaponIconsDater;
            return val_3;
        }
        
        this.世且万丒不丐三丕丌 = true;
        val_3 = new UIBasicSprite[0];
        val_4 = 0;
        goto label_4;
        label_16:
        UIBasicSprite val_2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.weaponIconsDater[0]);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if(val_2 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_2 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_4 = 1;
        val_3[0] = val_2;
        label_4:
        if(val_4 < this.weaponIconsDater.Length)
        {
            goto label_16;
        }
        
        this.weaponIconsDater = val_3;
        return val_3;
    }
    private void Awake()
    {
        var val_71;
        UnityEngine.Transform val_72;
        var val_73;
        var val_74;
        var val_75;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_3;
        }
        
        val_71 = 0;
        val_72 = this.shopPanelForTap;
        this.shopPanelForTap = this.shopPanelForTapDater;
        goto label_4;
        label_14:
        UIButton val_71 = this.weaponCategoriesButtonsDater[0];
        if(this.weaponCategoriesButtons == null)
        {
            goto label_7;
        }
        
        if(val_71 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_71 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_71 = 1;
        this.weaponCategoriesButtons[0] = val_71;
        label_4:
        if(val_71 < this.weaponCategoriesButtons.Length)
        {
            goto label_14;
        }
        
        val_73 = 0;
        goto label_15;
        label_25:
        UILabel val_72 = this.ammoCategoriesLabelsDater[0];
        if(this.ammoCategoriesLabels == null)
        {
            goto label_18;
        }
        
        if(val_72 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_72 == null)
        {
            goto label_22;
        }
        
        label_19:
        label_22:
        val_73 = 1;
        this.ammoCategoriesLabels[0] = val_72;
        label_15:
        if(val_73 < this.ammoCategoriesLabels.Length)
        {
            goto label_25;
        }
        
        val_74 = 0;
        goto label_26;
        label_36:
        UIBasicSprite[] val_2 = this.丗丂丘丆丈丌丕且丌();
        UIBasicSprite val_73 = this.上丐一丄且三丒丐世()[0];
        if(val_2 == null)
        {
            goto label_29;
        }
        
        if(val_73 != null)
        {
            goto label_30;
        }
        
        goto label_33;
        label_29:
        if(val_73 == null)
        {
            goto label_33;
        }
        
        label_30:
        label_33:
        val_74 = 1;
        val_2[0] = val_73;
        label_26:
        UIBasicSprite[] val_4 = this.丗丂丘丆丈丌丕且丌();
        if(val_74 < val_4.Length)
        {
            goto label_36;
        }
        
        goto label_37;
        label_3:
        val_72 = this.shopPanelForTap;
        label_37:
        mem[this.shopPanelForTap].gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_6 = mem[this.shopPanelForTap].localPosition;
        WeaponTogglesController.一世丝丒丂下七丆上 = val_6.x;
        WeaponTogglesController.丘丕丛与不万下世一.__il2cppRuntimeField_10 = val_6.y;
        WeaponTogglesController.丘丕丛与不万下世一.__il2cppRuntimeField_14 = val_6.z;
        if(this.gearToogle != 0)
        {
                this.gearToogle.gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::丏丌丞上丘且丞丑丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponCategoriesButtons[0] != 0)
        {
                this.weaponCategoriesButtons[0].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::丘丟丟世丘与上丆丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponCategoriesButtons[1] != 0)
        {
                this.weaponCategoriesButtons[1].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::丐丟丙专丝丝丘一万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponCategoriesButtons[2] != 0)
        {
                this.weaponCategoriesButtons[2].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::且丞丐丙不东世三且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponCategoriesButtons[3] != 0)
        {
                this.weaponCategoriesButtons[3].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::专丟一丝丏丙丞丒丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponCategoriesButtons[4] != 0)
        {
                this.weaponCategoriesButtons[4].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::丐丘丕丝丐一丌丝丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponCategoriesButtons[5] != 0)
        {
                this.weaponCategoriesButtons[5].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::专丙上丂丗丂丆丁丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.weaponCategoriesButtons[0] != 0)
        {
                this.weaponCategoriesButtons[0].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_OutUnPress(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::丏丟上丑世丁七专三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
            if(this.weaponCategoriesButtons[1] != 0)
        {
                this.weaponCategoriesButtons[1].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_OutUnPress(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::七与三丐丆七丗丆东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
            if(this.weaponCategoriesButtons[2] != 0)
        {
                this.weaponCategoriesButtons[2].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_OutUnPress(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::与且专三丝三丌丗丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
            if(this.weaponCategoriesButtons[3] != 0)
        {
                this.weaponCategoriesButtons[3].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_OutUnPress(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::下丈丗下丅与丄丗七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
            if(this.weaponCategoriesButtons[4] != 0)
        {
                this.weaponCategoriesButtons[4].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_OutUnPress(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::丛丆业万丁与丑东丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
            if(this.weaponCategoriesButtons[5] != 0)
        {
                this.weaponCategoriesButtons[5].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_OutUnPress(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::与丐丅丝丆世丛丗丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                this.gearToogle.GetComponent<UIToggle>().value = false;
            this.丏丌丞上丘且丞丑丅(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
        }
        
        bool val_64 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                this.丝丞丝与丒丄丙丒丙 = GameConnect.丁业丐与丕且三不且();
        }
        
        WeaponManager.不万且专丕且丘丛世(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且>(object:  this, method:  System.Void WeaponTogglesController::丁专丏业丒丑丄上东(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上)));
        丆丟七丌丞东丆丕丌.丐丅万万丕专丒丑丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this, method:  System.Void WeaponTogglesController::下专丂丗与丈业丙丈(PGCompany.丗丟丅七东丄丙丟上 丛丆东与丑丞丅丝专, PGCompany.丏丂一丗丙世丏丐三 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)));
        丆丟七丌丞东丆丕丌.丕丏丐七东且丒上丐(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this, method:  System.Void WeaponTogglesController::不丝业七万丁东一东(PGCompany.丗丟丅七东丄丙丟上 丛丆东与丑丞丅丝专, PGCompany.丏丂一丗丙世丏丐三 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)));
        val_75 = 0;
        goto label_186;
        label_190:
        this.丛丕丂万世丂下丏上(丟丕三一丙上七专丌:  this.upButtonsInShopPanel[0]);
        val_75 = 1;
        label_186:
        if(val_75 < this.upButtonsInShopPanel.Length)
        {
            goto label_190;
        }
    
    }
    private void 丐万丏东丝丝丛丄七()
    {
        var val_5;
        var val_13;
        var val_14;
        val_13 = this;
        if(万世专丘且万世七丒.丅丌丏下丏丞下丆丂() == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_2 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        label_17:
        if(((-821925328) & 1) == 0)
        {
            goto label_8;
        }
        
        int val_12 = val_2.万上丄下业丛丌不丈();
        val_12 = val_12 - 1;
        this.weaponTogglesModulesUI[(long)val_12].不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  val_5.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛()).丟且丘丗七且下三专());
        goto label_17;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 不丝业七万丁东一东(PGCompany.丗丟丅七东丄丙丟上 丛丆东与丑丞丅丝专, PGCompany.丏丂一丗丙世丏丐三 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)
    {
        this.丐万丏东丝丝丛丄七();
    }
    private void 下专丂丗与丈业丙丈(PGCompany.丗丟丅七东丄丙丟上 丛丆东与丑丞丅丝专, PGCompany.丏丂一丗丙世丏丐三 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)
    {
        this.丐万丏东丝丝丛丄七();
    }
    private void Start()
    {
        var val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_11 = null;
        val_11 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_6;
        }
        
        val_12 = 0;
        this.不丛三三专丛一万丝 = 0;
        goto label_11;
        label_3:
        val_13 = null;
        val_13 = null;
        val_12 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        goto label_11;
        label_6:
        val_14 = null;
        val_14 = null;
        val_12 = WeaponManager.丟丗丄业丘丗业丗七.七丅丒万万丅一丄专();
        this.不丛三三专丛一万丝 = val_12;
        label_11:
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_15;
        }
        
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count >= 2)
        {
            goto label_20;
        }
        
        label_15:
        val_16 = null;
        val_16 = null;
        三丈丟与丏丘丈丐万 val_7 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[val_12];
        this.丁专丏业丒丑丄上东(三与世丈丂丕丏三上:  val_7.三丐三丞丘丕不丒专);
        return;
        label_20:
        val_17 = 0;
        goto label_26;
        label_32:
        this.七丈丂丌丝世丞丄丛.set_Item(key:  0, value:  0);
        val_17 = 1;
        label_26:
        val_18 = null;
        val_18 = null;
        if(val_17 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_32;
        }
        
        this.UpdateWeaponIconsForWrap();
        this.丐上一丁业业丙且丗();
        bool val_10 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  val_12, 丒丏丗三三万丝丛丕:  true);
    }
    internal void 丕丏丂世下丛丑下丏(int 丙业与丙丗丝不丈东)
    {
        var val_8;
        var val_9;
        int val_10;
        val_8 = 丙业与丙丗丝不丈东;
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count < 2)
        {
                return;
        }
        
        goto label_9;
        label_12:
        val_8 = val_8 << 1;
        this.不丛三三专丛一万丝 = this.不丛三三专丛一万丝;
        label_9:
        int val_4 = this.不丛三三专丛一万丝 + val_8;
        if(val_4 <= 5)
        {
                var val_6 = (val_4 >= 0) ? (val_4) : (val_8 + 6);
        }
        else
        {
                val_10 = 0;
        }
        
        this.不丛三三专丛一万丝 = val_10;
        if(this.万丐丞东与丅丞丈七() == false)
        {
            goto label_12;
        }
    
    }
    private void 且丙丁丁丁东丟丘世(int 丙业与丙丗丝不丈东)
    {
        int val_3;
        int val_3 = this.不丛三三专丛一万丝;
        val_3 = val_3 + 丙业与丙丗丝不丈东;
        if(val_3 <= 5)
        {
                var val_2 = (val_3 >= 0) ? (val_3) : (丙业与丙丗丝不丈东 + 6);
        }
        else
        {
                val_3 = 0;
        }
        
        this.不丛三三专丛一万丝 = val_3;
    }
    private bool 万丐丞东与丅丞丈七()
    {
        var val_3;
        if(this.不丛三三专丛一万丝 <= 5)
        {
                var val_1 = 106038232 + (this.不丛三三专丛一万丝) << 2;
            val_1 = val_1 + 106038232;
        }
        else
        {
                val_3 = 0;
            return (bool);
        }
    
    }
    private void Update()
    {
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        UnityEngine.Object val_50;
        var val_51;
        var val_54;
        var val_55;
        var val_56;
        int val_57;
        var val_59;
        var val_60;
        var val_61;
        val_45 = null;
        val_45 = null;
        val_46 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_47 = null;
            val_47 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_48 = null;
            val_48 = null;
        }
        
        }
        
        val_49 = 0;
        goto label_17;
        label_120:
        val_50 = 0;
        if(this.ammoCategoriesLabels[0] == val_50)
        {
            goto label_107;
        }
        
        if(val_49 >= this.weaponCategoriesButtons.Length)
        {
                val_50 = 0;
        }
        
        if((this.weaponCategoriesButtons[0] & 1) == 0)
        {
            goto label_52;
        }
        
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_27;
        }
        
        val_51 = null;
        val_51 = null;
        if(this.七丈丂丌丝世丞丄丛.Item[0] >= WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_52;
        }
        
        三丈丟与丏丘丈丐万 val_7 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[this.七丈丂丌丝世丞丄丛.Item[0]];
        if(val_7.三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_7.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_41;
        }
        
        }
        
        int val_11 = val_7.下世万丆丛专丒丑丙();
        int val_12 = val_7.东东丄丅丐一丙一业();
        if(val_7.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_45;
        }
        
        string val_13 = this.丂丟丈世且丁专业丑(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_11, 下丌丒丑丆丘七万丌:  val_12);
        goto label_46;
        label_27:
        val_54 = 0;
        goto label_47;
        label_63:
        val_54 = 1;
        label_47:
        val_55 = null;
        val_55 = null;
        if(val_54 >= WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_52;
        }
        
        val_56 = null;
        val_56 = null;
        三丈丟与丏丘丈丐万 val_17 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[1];
        if(val_17.三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_17.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_63;
        }
        
        }
        
        if(val_17.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() != 1)
        {
            goto label_63;
        }
        
        val_57 = val_17.下世万丆丛专丒丑丙();
        int val_23 = val_17.东东丄丅丐一丙一业();
        if(val_17.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_67;
        }
        
        string val_24 = this.丂丟丈世且丁专业丑(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_57, 下丌丒丑丆丘七万丌:  val_23);
        goto label_68;
        label_45:
        label_46:
        val_46 = 1152921504848912384;
        val_57 = this.不丗丄东丈专丒一且(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_11, 下丌丒丑丆丘七万丌:  val_12, 丑世不与丈上丁丅与:  val_7.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世());
        this.ammoCategoriesLabels[0].text = val_57;
        val_59 = 1;
        goto label_71;
        label_67:
        label_68:
        val_46 = 1152921504848912384;
        this.ammoCategoriesLabels[0].text = this.不丗丄东丈专丒一且(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_57, 下丌丒丑丆丘七万丌:  val_23, 丑世不与丈上丁丅与:  val_17.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世());
        goto label_107;
        label_41:
        val_59 = 0;
        label_71:
        if(val_7.七丝丈东丈丕丐与丗() == false)
        {
            goto label_75;
        }
        
        val_57 = this.丂丟丈世且丁专业丑(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_7.下世万丆丛专丒丑丙(), 下丌丒丑丆丘七万丌:  0);
        this.ammoCategoriesLabels[0].text = val_57;
        不丘丄丝丗丒丙一丌 val_33 = 东丟丟万下丛丆丛丟.专丆丝丆东世丄世丞(丙丑丕丂下丏一丁专:  val_7.丙丗丕丟七丟上丈丌.丒万丕七专不丏丞丌());
        if(val_33 == null)
        {
            goto label_107;
        }
        
        this.weaponGadgetCooldownSprites[0].gameObject.SetActive(value:  true);
        val_57 = this.weaponGadgetDurationSprites[0].gameObject;
        val_57.SetActive(value:  true);
        val_60 = val_33.世丙丈丁丘七七丌丝();
        val_61 = val_33.且丑丂丐不七丌丌丂();
        this.weaponGadgetCooldownSprites[0].fillAmount = (val_33 == val_7.丙丗丕丟七丟上丈丌) ? (val_60) : 1f;
        this.weaponGadgetDurationSprites[0].fillAmount = (val_33 == val_7.丙丗丕丟七丟上丈丌) ? (val_61) : 0f;
        goto label_107;
        label_75:
        this.weaponGadgetCooldownSprites[0].gameObject.SetActive(value:  false);
        this.weaponGadgetDurationSprites[0].gameObject.SetActive(value:  false);
        if((val_59 & 1) != 0)
        {
            goto label_107;
        }
        
        label_52:
        this.ammoCategoriesLabels[0].text = System.String.alignConst;
        this.weaponGadgetCooldownSprites[0].gameObject.SetActive(value:  false);
        this.weaponGadgetDurationSprites[0].gameObject.SetActive(value:  false);
        label_107:
        val_49 = 1;
        label_17:
        if(val_49 < this.ammoCategoriesLabels.Length)
        {
            goto label_120;
        }
    
    }
    private void OnDestroy()
    {
        WeaponManager.丒世丛丄且七丐东丆(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且>(object:  this, method:  System.Void WeaponTogglesController::丁专丏业丒丑丄上东(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上)));
        丆丟七丌丞东丆丕丌.且一专世丑专丌丂业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this, method:  System.Void WeaponTogglesController::下专丂丗与丈业丙丈(PGCompany.丗丟丅七东丄丙丟上 丛丆东与丑丞丅丝专, PGCompany.丏丂一丗丙世丏丐三 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)));
        丆丟七丌丞东丆丕丌.丑丕且丞丘丏丗专万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this, method:  System.Void WeaponTogglesController::不丝业七万丁东一东(PGCompany.丗丟丅七东丄丙丟上 丛丆东与丑丞丅丝专, PGCompany.丏丂一丗丙世丏丐三 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)));
    }
    private void 丏丌丞上丘且丞丑丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        float val_5;
        var val_6;
        bool val_2 = this.gearToogle.GetComponent<UIToggle>().value;
        this.fonBig.SetActive(value:  val_2);
        if(val_2 != false)
        {
                val_5 = this.丌世丕东世丅丘丂丘;
        }
        else
        {
                val_5 = 3212836864;
        }
        
        this.丑丕丄丝丅下丂丏上 = -1f;
        val_6 = 0;
        goto label_6;
        label_11:
        this.upButtonsInShopPanel[0].SetActive(value:  val_2);
        val_6 = 1;
        label_6:
        if(val_6 < this.upButtonsInShopPanel.Length)
        {
            goto label_11;
        }
    
    }
    private void 丘丟丟世丘与上丆丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_4 = null;
            val_4 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  9);
        }
        
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                bool val_2 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  0, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  1, 丒丏丗三三万丝丛丕:  true);
    }
    private void 丐丟丙专丝丝丘一万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_4 = null;
            val_4 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  10);
        }
        
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                bool val_2 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  1, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  2, 丒丏丗三三万丝丛丕:  true);
    }
    private void 且丞丐丙不东世三且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_4 = null;
            val_4 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  11);
        }
        
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                bool val_2 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  2, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  3, 丒丏丗三三万丝丛丕:  true);
    }
    private void 专丟一丝丏丙丞丒丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_4 = null;
            val_4 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  12);
        }
        
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                bool val_2 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  3, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  4, 丒丏丗三三万丝丛丕:  true);
    }
    private void 丐丘丕丝丐一丌丝丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_4 = null;
            val_4 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  13);
        }
        
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                bool val_2 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  4, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  5, 丒丏丗三三万丝丛丕:  true);
    }
    private void 专丙上丂丗丂丆丁丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 != 0)
        {
                val_4 = null;
            val_4 = null;
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  14);
        }
        
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                bool val_2 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  5, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  6, 丒丏丗三三万丝丛丕:  true);
    }
    private void 丏丟上丑世丁七专三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                return;
        }
        
        this.丙专丏丐丝与东丅东(七丆丒与丗丌丄且丂:  1, 丒丏丗三三万丝丛丕:  true);
    }
    private void 七与三丐丆七丗丆东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                this.丆与丛丂七丟世丆专(丞世不丒下上上丝丑:  1, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.丙专丏丐丝与东丅东(七丆丒与丗丌丄且丂:  2, 丒丏丗三三万丝丛丕:  true);
    }
    private void 与且专三丝三丌丗丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                this.丆与丛丂七丟世丆专(丞世不丒下上上丝丑:  2, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.丙专丏丐丝与东丅东(七丆丒与丗丌丄且丂:  3, 丒丏丗三三万丝丛丕:  true);
    }
    private void 下丈丗下丅与丄丗七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                this.丆与丛丂七丟世丆专(丞世不丒下上上丝丑:  3, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.丙专丏丐丝与东丅东(七丆丒与丗丌丄且丂:  4, 丒丏丗三三万丝丛丕:  true);
    }
    private void 丛丆业万丁与丑东丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                this.丆与丛丂七丟世丆专(丞世不丒下上上丝丑:  4, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.丙专丏丐丝与东丅东(七丆丒与丗丌丄且丂:  5, 丒丏丗三三万丝丛丕:  true);
    }
    private void 与丐丅丝丆世丛丗丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                this.丆与丛丂七丟世丆专(丞世不丒下上上丝丑:  5, 丒丏丗三三万丝丛丕:  true);
            return;
        }
        
        this.丙专丏丐丝与东丅东(七丆丒与丗丌丄且丂:  6, 丒丏丗三三万丝丛丕:  true);
    }
    internal void 三一业三世丛业三东(int 七丆丒与丗丌丄且丂, bool 丒丏丗三三万丝丛丕 = True)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = 0;
        goto label_1;
        label_13:
        val_12 = null;
        val_12 = null;
        三丈丟与丏丘丈丐万 val_2 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if(val_2.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() == 七丆丒与丗丌丄且丂)
        {
            goto label_8;
        }
        
        val_11 = 1;
        label_1:
        val_13 = null;
        val_13 = null;
        if(val_11 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_13;
        }
        
        return;
        label_8:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_16;
        }
        
        val_14 = null;
        val_14 = null;
        var val_9 = (WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().丌上丗丕不七世丅丁() == val_2.三丐三丞丘丕不丒专) ? 1 : 0;
        if(this != null)
        {
            goto label_23;
        }
        
        goto label_22;
        label_16:
        val_15 = 0;
        if(this != null)
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  0, 世丏丛上丈丏丟丐丝:  丒丏丗三三万丝丛丕, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  false);
    }
    private void 三一业三世丛业三东(string 丆万一不丌且东丐丐, bool 丒丏丗三三万丝丛丕 = True)
    {
        var val_20;
        var val_21;
        var val_22;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_20 = 0;
        goto label_1;
        label_29:
        val_21 = null;
        val_21 = null;
        三丈丟与丏丘丈丐万 val_2 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if((System.String.op_Equality(a:  val_2.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛(), b:  丆万一不丌且东丐丐)) == false)
        {
            goto label_12;
        }
        
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_9;
        }
        
        val_22 = 0;
        goto label_10;
        label_14:
        val_22 = 1;
        label_10:
        val_23 = this.七丈丂丌丝世丞丄丛;
        if(val_22 >= val_23.Count)
        {
            goto label_12;
        }
        
        if(this.七丈丂丌丝世丞丄丛.Item[1] != val_20)
        {
            goto label_14;
        }
        
        val_23 = this.七丈丂丌丝世丞丄丛;
        this.不丛三三专丛一万丝 = val_23.Item[1];
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_24 = null;
            val_24 = null;
            val_23 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().丌上丗丕不七世丅丁();
            var val_11 = (val_23 == val_2.三丐三丞丘丕不丒专) ? 1 : 0;
        }
        else
        {
                val_25 = 0;
        }
        
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  1, 世丏丛上丈丏丟丐丝:  丒丏丗三三万丝丛丕, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  false);
        label_12:
        val_20 = 1;
        label_1:
        val_26 = null;
        val_26 = null;
        if(val_20 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_29;
        }
        
        return;
        label_9:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_27 = null;
            val_27 = null;
            var val_18 = (WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().丌上丗丕不七世丅丁() == val_2.三丐三丞丘丕不丒专) ? 1 : 0;
        }
        else
        {
                val_28 = 0;
        }
        
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  0, 世丏丛上丈丏丟丐丝:  丒丏丗三三万丝丛丕, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  false);
    }
    private bool 七丌丅七丝东丛丒三(int 丞世不丒下上上丝丑, bool 丒丏丗三三万丝丛丕 = True)
    {
        var val_13;
        int val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = null;
        val_13 = null;
        val_14 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        if(this.七丈丂丌丝世丞丄丛.Item[丞世不丒下上上丝丑] >= val_14.Count)
        {
            goto label_6;
        }
        
        val_15 = null;
        val_15 = null;
        val_14 = this.七丈丂丌丝世丞丄丛.Item[丞世不丒下上上丝丑];
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_14;
        }
        
        val_16 = null;
        val_16 = null;
        val_14 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().丌上丗丕不七世丅丁();
        if(val_14 == val_6.三丐三丞丘丕不丒专)
        {
            goto label_20;
        }
        
        label_14:
        label_22:
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  丞世不丒下上上丝丑, 世丏丛上丈丏丟丐丝:  丒丏丗三三万丝丛丕, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  0 & 1);
        val_17 = 1;
        return (bool)val_17;
        label_6:
        val_17 = 0;
        return (bool)val_17;
        label_20:
        bool val_13 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[val_14].七丝丈东丈丕丐与丗() ^ 1;
        goto label_22;
    }
    private void 丙专丏丐丝与东丅东(int 七丆丒与丗丌丄且丂, bool 丒丏丗三三万丝丛丕 = True)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_20 = null;
        val_20 = null;
        val_21 = null;
        val_21 = null;
        专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        val_22 = 0;
        goto label_10;
        label_22:
        val_23 = null;
        val_23 = null;
        三丈丟与丏丘丈丐万 val_2 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if(val_2.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() == 七丆丒与丗丌丄且丂)
        {
            goto label_17;
        }
        
        val_22 = 1;
        label_10:
        val_24 = null;
        val_24 = null;
        if(val_22 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_22;
        }
        
        return;
        label_17:
        val_25 = null;
        val_25 = null;
        int val_6 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        if(val_6 != val_22)
        {
            goto label_26;
        }
        
        val_26 = null;
        val_26 = null;
        if((val_22 - WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count) == 1)
        {
            goto label_31;
        }
        
        label_26:
        val_27 = null;
        val_27 = null;
        val_28 = null;
        if(val_22 >= WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万())
        {
            goto label_35;
        }
        
        val_29 = null;
        val_30 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万() - 1;
        goto label_43;
        label_35:
        val_31 = null;
        val_30 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        goto label_43;
        label_31:
        val_30 = 0;
        label_43:
        val_32 = null;
        val_32 = null;
        bool val_14 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Remove(item:  val_2);
        val_33 = null;
        val_33 = null;
        BonusController.丄丞丁丈与业上丞丟.丌丐丐丒丏且丏丁不(丆与丕丕丂下丟一丈:  val_2.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), 丟丒丙丁丑丐世三丈:  val_2.下世万丆丛专丒丑丙(), 上丂丝上丘专丟丁丈:  val_2.东东丄丅丐一丙一业(), 丞丙丟丈丌七丐丝上:  -40f, 万丁丕七丞丞丂与丟:  1);
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  0, 世丏丛上丈丏丟丐丝:  丒丏丗三三万丝丛丕, 丘上丅丝丄三一丕丁:  (val_6 == val_22) ? 1 : 0, 七万丅丟丘万丆丁与:  false);
        this.UpdateWeaponIconsForWrap();
    }
    internal void 丗丘一一丑业丐丘丙()
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = 0;
        goto label_1;
        label_22:
        val_12 = null;
        val_12 = null;
        三丈丟与丏丘丈丐万 val_2 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if((val_2.七丝丈东丈丕丐与丗() != false) && (val_2.下世万丆丛专丒丑丙() <= 0))
        {
                不丘丄丝丗丒丙一丌 val_6 = 东丟丟万下丛丆丛丟.专丆丝丆东世丄世丞(丙丑丕丂下丏一丁专:  val_2.丙丗丕丟七丟上丈丌.丒万丕七专不丏丞丌());
            if((val_6 != null) && (val_6 == val_2.丙丗丕丟七丟上丈丌))
        {
                if(val_6.丄不与丁丗东专且丈() == true)
        {
            goto label_17;
        }
        
        }
        
            int val_8 = this.专丒下业三上丒七丞(丌丝下丄业一丄不三:  0);
            if(val_8 != 1)
        {
                this.丆与丛丂七丟世丆专(丞世不丒下上上丝丑:  val_8, 丒丏丗三三万丝丛丕:  true);
        }
        
        }
        
        label_17:
        val_11 = 1;
        label_1:
        val_13 = null;
        val_13 = null;
        if(val_11 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_22;
        }
    
    }
    private int 专丒下业三上丒七丞(int 丌丝下丄业一丄不三)
    {
        goto label_1;
        label_5:
        if(this.七丈丂丌丝世丞丄丛.Item[0] == 丌丝下丄业一丄不三)
        {
                return 0;
        }
        
        0 = 1;
        label_1:
        if(0 < this.七丈丂丌丝世丞丄丛.Count)
        {
            goto label_5;
        }
        
        return 0;
    }
    private void 丆与丛丂七丟世丆专(int 丞世不丒下上上丝丑, bool 丒丏丗三三万丝丛丕 = True)
    {
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        BonusController val_45;
        string val_46;
        int val_47;
        int val_48;
        丞上七丈丗丝与丏丄 val_49;
        var val_50;
        var val_51;
        var val_52;
        val_36 = null;
        val_36 = null;
        val_37 = null;
        val_37 = null;
        专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        val_38 = null;
        val_38 = null;
        if(this.七丈丂丌丝世丞丄丛.Item[丞世不丒下上上丝丑] >= WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
                return;
        }
        
        val_39 = null;
        val_39 = null;
        三丈丟与丏丘丈丐万 val_6 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[this.七丈丂丌丝世丞丄丛.Item[丞世不丒下上上丝丑]];
        int val_7 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        int val_8 = this.七丈丂丌丝世丞丄丛.Item[丞世不丒下上上丝丑];
        val_40 = 0;
        goto label_23;
        label_30:
        val_41 = null;
        val_41 = null;
        if(this.七丈丂丌丝世丞丄丛.Item[0] == WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万())
        {
            goto label_28;
        }
        
        val_40 = 1;
        label_23:
        if(val_40 < this.七丈丂丌丝世丞丄丛.Count)
        {
            goto label_30;
        }
        
        val_42 = 1;
        label_28:
        if(val_7 != val_8)
        {
            goto label_33;
        }
        
        var val_36 = 0;
        label_36:
        val_36 = val_36 + 1;
        if(val_36 >= this.七丈丂丌丝世丞丄丛.Count)
        {
            goto label_33;
        }
        
        val_42 = val_42 + 1;
        int val_14 = (val_42 < this.七丈丂丌丝世丞丄丛.Count) ? (val_42) : 0;
        if(this.七丈丂丌丝世丞丄丛.Item[val_14] == 99)
        {
            goto label_36;
        }
        
        label_33:
        val_43 = null;
        val_43 = null;
        bool val_17 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Remove(item:  val_6);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.东丐丟丂丝上丞丁丅();
        }
        
        if(val_6.七丝丈东丈丕丐与丗() == false)
        {
            goto label_48;
        }
        
        if(val_6.下世万丆丛专丒丑丙() < 1)
        {
            goto label_50;
        }
        
        val_44 = null;
        val_44 = null;
        val_45 = BonusController.丄丞丁丈与业上丞丟;
        val_46 = val_6.丙丗丕丟七丟上丈丌.业上丙丞丐丄丆丅七();
        val_47 = val_6.下世万丆丛专丒丑丙();
        val_48 = val_6.东东丄丅丐一丙一业();
        val_49 = 2;
        goto label_56;
        label_48:
        val_50 = null;
        val_50 = null;
        val_45 = BonusController.丄丞丁丈与业上丞丟;
        val_46 = val_6.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        val_47 = val_6.下世万丆丛专丒丑丙();
        val_48 = val_6.东东丄丅丐一丙一业();
        val_49 = 1;
        label_56:
        val_45.丌丐丐丒丏且丏丁不(丆与丕丕丂下丟一丈:  val_46, 丟丒丙丁丑丐世三丈:  val_47, 上丂丝上丘专丟丁丈:  val_48, 丞丙丟丈丌七丐丝上:  -40f, 万丁丕七丞丞丂与丟:  val_49);
        label_50:
        val_51 = 0;
        goto label_62;
        label_71:
        if((val_45.Item[0] != 99) && (this.七丈丂丌丝世丞丄丛.Item[丞世不丒下上上丝丑] < this.七丈丂丌丝世丞丄丛.Item[0]))
        {
                if(this.七丈丂丌丝世丞丄丛 != null)
        {
                val_52 = this.七丈丂丌丝世丞丄丛.Item[0];
        }
        else
        {
                val_52 = 0.Item[0];
        }
        
            this.七丈丂丌丝世丞丄丛.set_Item(key:  0, value:  val_52 - 1);
        }
        
        val_51 = 1;
        label_62:
        if(val_51 < this.七丈丂丌丝世丞丄丛.Count)
        {
            goto label_71;
        }
        
        this.七丈丂丌丝世丞丄丛.set_Item(key:  丞世不丒下上上丝丑, value:  99);
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  val_14, 世丏丛上丈丏丟丐丝:  丒丏丗三三万丝丛丕, 丘上丅丝丄三一丕丁:  (val_7 == val_8) ? 1 : 0, 七万丅丟丘万丆丁与:  false);
        this.UpdateWeaponIconsForWrap();
    }
    internal void 丁专丏业丒丑丄上东(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上)
    {
        var val_22;
        WeaponManager val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        val_48 = 三与世丈丂丕丏三上;
        int val_10 = 0;
        if(val_48 != null)
        {
                if(val_48.东七与与不丅丙上上() != false)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        }
        
            val_49 = null;
            val_49 = null;
            val_47 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_47 != 0)
        {
                val_50 = null;
            val_50 = null;
            val_47 = WeaponManager.丟丗丄业丘丗业丗七;
            if((val_48.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  val_47.丟三上丁丗一丅丝丐())) == false)
        {
                return;
        }
        
        }
        
        }
        
        if((val_48 != null) && (GameConnect.世丐丄三三上丅七三() != false))
        {
                val_51 = "Weapon";
            if("Weapon" == null)
        {
                val_51 = "Weapon";
        }
        
            val_47 = val_10;
            if((val_47 != 9) && ((System.Int32.TryParse(s:  val_48.三与丛丑且丐丈业丌().Substring(startIndex:  Length), result: out  val_10)) != false))
        {
                val_52 = null;
            val_52 = null;
            val_47 = val_10;
            if((万上丈专丐专丞丛丛.丟不下下且业丛丄丏(丞下万上三丘上与专:  ChestController.weaponForHungerGames, 丏东丁丂七丟不丒丅:  0)) == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_36;
        }
        
        val_53 = 1152921525753940704;
        val_54 = 1152921505286238208;
        val_47 = 0;
        goto label_29;
        label_35:
        val_55 = null;
        val_55 = null;
        if(this.七丈丂丌丝世丞丄丛.Item[0] > WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_33;
        }
        
        val_47 = 1;
        label_29:
        if(val_47 < this.七丈丂丌丝世丞丄丛.Count)
        {
            goto label_35;
        }
        
        goto label_36;
        label_33:
        val_54 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count;
        this.七丈丂丌丝世丞丄丛.set_Item(key:  0, value:  val_54 - 1);
        label_36:
        this.UpdateWeaponIconsForWrap();
        this.丐上一丁业业丙且丗();
        if(万世专丘且万世七丒.丅丌丏下丏丞下丆丂() == false)
        {
            goto label_70;
        }
        
        val_57 = null;
        val_57 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        List.Enumerator<T> val_20 = val_47.GetEnumerator();
        val_53 = 1152921525778334208;
        label_58:
        if(((-815919712) & 1) == 0)
        {
            goto label_49;
        }
        
        int val_46 = val_47.万上丄下业丛丌不丈();
        val_46 = val_46 - 1;
        this.weaponTogglesModulesUI[(long)val_46].不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  val_22.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛()).丟且丘丗七且下三专());
        goto label_58;
        label_49:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_70:
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_71;
        }
        
        val_58 = null;
        val_58 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_29.categoryNabor != 3)
        {
            goto label_76;
        }
        
        val_47 = val_48.三与丛丑且丐丈业丌();
        val_59 = null;
        val_59 = null;
        if((val_47.Equals(value:  Player_move_c.丆万一专丑丏丆丘上)) == false)
        {
            goto label_94;
        }
        
        label_76:
        label_117:
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_82;
        }
        
        val_54 = 1152921525753940704;
        val_53 = 1152921505286238208;
        val_60 = 0;
        goto label_83;
        label_90:
        val_61 = null;
        val_47 = this.七丈丂丌丝世丞丄丛.Item[0];
        val_61 = null;
        if(val_47 == WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万())
        {
            goto label_88;
        }
        
        val_60 = 1;
        label_83:
        val_47 = this.七丈丂丌丝世丞丄丛;
        if(val_60 < val_47.Count)
        {
            goto label_90;
        }
        
        return;
        label_71:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_94;
        }
        
        val_62 = null;
        val_62 = null;
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_36.categoryNabor != 3)
        {
            goto label_99;
        }
        
        label_94:
        var val_37 = (this.丝丞丝与丒丄丙丒丙 == true) ? 1 : 0;
        label_118:
        if(val_48 == null)
        {
            goto label_100;
        }
        
        if(val_37 != 0)
        {
            goto label_108;
        }
        
        goto label_109;
        label_82:
        val_63 = null;
        val_63 = null;
        val_48 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().丌上丗丕不七世丅丁();
        if(val_48 != null)
        {
            goto label_108;
        }
        
        goto label_108;
        label_100:
        if(val_37 == 0)
        {
            goto label_109;
        }
        
        label_108:
        this.三一业三世丛业三东(丆万一不丌且东丐丐:  val_48.与不丞丑七丘丁丂丛(), 丒丏丗三三万丝丛丕:  true);
        return;
        label_109:
        this.三一业三世丛业三东(七丆丒与丗丌丄且丂:  val_48.万上丄下业丛丌不丈(), 丒丏丗三三万丝丛丕:  true);
        return;
        label_88:
        bool val_42 = this.七丌丅七丝东丛丒三(丞世不丒下上上丝丑:  0, 丒丏丗三三万丝丛丕:  true);
        return;
        label_99:
        val_64 = null;
        val_64 = null;
        WeaponSounds val_43 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        var val_45 = (this.丝丞丝与丒丄丙丒丙 == true) ? 1 : 0;
        if(val_43.categoryNabor != val_48.万上丄下业丛丌不丈())
        {
            goto label_117;
        }
        
        goto label_118;
    }
    private void 丐上一丁业业丙且丗()
    {
        var val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_51;
        int val_52;
        var val_53;
        UnityEngine.Color val_54;
        UnityEngine.Color val_55;
        UnityEngine.Color val_56;
        UnityEngine.Color val_57;
        var val_58;
        var val_59;
        val_41 = this;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_4;
        }
        
        val_42 = 1152921524297567824;
        val_43 = 0;
        val_44 = 1f;
        goto label_5;
        label_64:
        val_45 = null;
        val_45 = null;
        if(this.七丈丂丌丝世丞丄丛.Item[0] < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
                val_46 = null;
            val_46 = null;
            三丈丟与丏丘丈丐万 val_7 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[this.七丈丂丌丝世丞丄丛.Item[0]];
            if(val_7.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() == 3)
        {
                UnityEngine.Color[] val_9 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
        }
        else
        {
                val_51 = null;
            val_51 = null;
            val_52 = this.七丈丂丌丝世丞丄丛.Item[0];
            三丈丟与丏丘丈丐万 val_13 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[val_52];
        }
        
            val_53 = null;
            val_53 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[this.七丈丂丌丝世丞丄丛.Item[0]].七丝丈东丈丕丐与丗() != false)
        {
                val_58 = null;
            val_58 = null;
            val_52 = this.七丈丂丌丝世丞丄丛.Item[0];
            三丈丟与丏丘丈丐万 val_21 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[val_52];
            val_56 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)val_21.丙丗丕丟七丟上丈丌.七东与丄丕丁丛世三()];
            val_55 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)val_21.丙丗丕丟七丟上丈丌.七东与丄丕丁丛世三()];
            val_54 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)val_21.丙丗丕丟七丟上丈丌.七东与丄丕丁丛世三()];
            val_57 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)val_21.丙丗丕丟七丟上丈丌.七东与丄丕丁丛世三()];
        }
        
            this.weaponCategoriesButtons[0].defaultColor = new UnityEngine.Color() {r = val_56, g = val_55, b = val_54, a = val_57};
            UIButton val_41 = this.weaponCategoriesButtons[0];
            float val_23 = val_56 * 0.5f;
            float val_24 = val_55 * 0.5f;
            float val_25 = val_54 * 0.5f;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            this.weaponCategoriesCheckmarkSprites[0].color = new UnityEngine.Color() {r = val_56, g = val_55, b = val_54, a = val_57};
        }
        
        val_43 = 1;
        label_5:
        if(val_43 < this.七丈丂丌丝世丞丄丛.Count)
        {
            goto label_64;
        }
        
        return;
        label_4:
        val_59 = null;
        val_59 = null;
        List.Enumerator<T> val_28 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().GetEnumerator();
        val_52 = 1152921525778334208;
        val_42 = 1152921505317388288;
        val_44 = 1f;
        label_96:
        if(((-815156496) & 1) == 0)
        {
            goto label_70;
        }
        
        if(X21.万上丄下业丛丌不丈() == 3)
        {
                UnityEngine.Color[] val_32 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
        }
        else
        {
                UnityEngine.Color[] val_33 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
        }
        
        int val_43 = val_33.万上丄下业丛丌不丈();
        val_43 = val_43 - 1;
        UIButton val_44 = this.weaponCategoriesButtons[(long)val_43];
        val_44.defaultColor = new UnityEngine.Color() {r = -8.193231E-16f, g = -8.193231E-16f, b = -8.193231E-16f, a = -8.193231E-16f};
        int val_45 = val_44.万上丄下业丛丌不丈();
        val_45 = val_45 - 1;
        UIButton val_46 = this.weaponCategoriesButtons[(long)val_45];
        float val_36 = null * 0.5f;
        float val_37 = null * 0.5f;
        float val_38 = null * 0.5f;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        int val_47 = 0.丐丏七丌丕丗业且上().万上丄下业丛丌不丈();
        val_47 = val_47 - 1;
        this.weaponCategoriesCheckmarkSprites[(long)val_47].color = new UnityEngine.Color() {r = -8.193231E-16f, g = -8.193231E-16f, b = -8.193231E-16f, a = -8.193231E-16f};
        goto label_96;
        label_70:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 七丌丅七丝东丛丒三(int 东七丛丝丑专世丏三, bool 世丏丛上丈丏丟丐丝, bool 丘上丅丝丄三一丕丁 = False, bool 七万丅丟丘万丆丁与 = False)
    {
        var val_5;
        bool val_27;
        UIButton[] val_28;
        var val_29;
        UIButton val_31;
        bool val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        int val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        bool val_44;
        bool val_45;
        int val_46;
        val_27 = 七万丅丟丘万丆丁与;
        val_28 = new bool[6];
        val_29 = 0;
        goto label_1;
        label_4:
        val_29 = 1;
        val_28[0] = false;
        label_1:
        if(val_29 < val_1.Length)
        {
            goto label_4;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_2 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  7);
        if(val_2 != null)
        {
                System.Collections.Generic.List<CategoryNames> val_3 = val_2.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom");
        }
        
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_20;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_4 = this.七丈丂丌丝世丞丄丛.GetEnumerator();
        val_31 = 1152921525508387872;
        val_32 = true;
        goto label_11;
        label_15:
        string val_7 = val_5.丐丏七丌丕丗业且上();
        if((-814229304) != 99)
        {
                val_28[0] = val_32;
        }
        
        label_11:
        if(((-814229296) & 1) != 0)
        {
            goto label_15;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_41;
        label_20:
        val_33 = null;
        val_33 = null;
        val_31 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        List.Enumerator<T> val_9 = val_31.GetEnumerator();
        val_32 = 1152921525778335232;
        goto label_29;
        label_33:
        int val_12 = val_5.丐丏七丌丕丗业且上().万上丄下业丛丌不丈() - 1;
        if(0 == 0)
        {
            goto label_28;
        }
        
        val_31 = 0;
        label_30:
        if(val_31 >= 0.Count)
        {
            goto label_29;
        }
        
        val_31 = val_31 + 1;
        if(0.Item[0] != val_12)
        {
            goto label_30;
        }
        
        label_28:
        val_28[(long)val_12] = true;
        label_29:
        if(((-814229328) & 1) != 0)
        {
            goto label_33;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_27 = val_27;
        label_41:
        val_34 = 0;
        goto label_42;
        label_49:
        if(val_34 >= this.weaponCategoriesButtons.Length)
        {
                val_35 = 0;
        }
        
        UIButton val_27 = this.weaponCategoriesButtons[0];
        if(val_34 >= val_1.Length)
        {
                val_35 = 0;
        }
        
        var val_15 = (val_28[0] == true) ? 1 : 0;
        val_34 = 1;
        label_42:
        if(val_34 < this.weaponCategoriesButtons.Length)
        {
            goto label_49;
        }
        
        val_36 = null;
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                val_37 = null;
            System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_16 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
            val_31 = this.七丈丂丌丝世丞丄丛.Item[东七丛丝丑专世丏三];
            val_38 = 1152921524366252464;
            val_39 = val_31;
        }
        else
        {
                val_40 = null;
            val_38 = 1152921524366252464;
            val_39 = 东七丛丝丑专世丏三;
        }
        
        三丈丟与丏丘丈丐万 val_19 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[val_39];
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_62;
        }
        
        val_41 = 0;
        goto label_63;
        label_71:
        if(东七丛丝丑专世丏三 == val_41)
        {
                val_42 = 1;
        }
        else
        {
                val_42 = 0;
        }
        
        this.weaponCategoriesButtons[0].GetComponent<UIToggle>().value = false;
        val_41 = 1;
        label_63:
        val_28 = this.weaponCategoriesButtons;
        if(val_41 < this.weaponCategoriesButtons.Length)
        {
            goto label_71;
        }
        
        goto label_72;
        label_62:
        val_41 = (long)val_19.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1;
        if(val_28[val_41] == false)
        {
                return;
        }
        
        val_41 = 0;
        goto label_77;
        label_86:
        val_31 = this.weaponCategoriesButtons[0];
        if(val_41 == (val_19.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1))
        {
                val_43 = 1;
        }
        else
        {
                val_43 = 0;
        }
        
        val_31.GetComponent<UIToggle>().value = false;
        val_41 = 1;
        label_77:
        val_28 = this.weaponCategoriesButtons;
        if(val_41 < this.weaponCategoriesButtons.Length)
        {
            goto label_86;
        }
        
        label_72:
        if(this.丝丞丝与丒丄丙丒丙 != false)
        {
                val_44 = 丘上丅丝丄三一丕丁;
            val_45 = ;
            val_46 = this.七丈丂丌丝世丞丄丛.Item[东七丛丝丑专世丏三];
        }
        else
        {
                val_44 = 丘上丅丝丄三一丕丁;
            val_45 = ;
            val_46 = 东七丛丝丑专世丏三;
        }
        
        丘上丅丝丄三一丕丁 = val_44;
        this.丟一丌丂丗丂丐七东(丞世不丒下上上丝丑:  val_46, 丒丏丗三三万丝丛丕:  false, 丘上丅丝丄三一丕丁:  丘上丅丝丄三一丕丁, 七万丅丟丘万丆丁与:  val_45);
    }
    private void 丟一丌丂丗丂丐七东(int 丞世不丒下上上丝丑, bool 丒丏丗三三万丝丛丕, bool 丘上丅丝丄三一丕丁 = False, bool 七万丅丟丘万丆丁与 = False)
    {
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        int val_17;
        val_14 = 丘上丅丝丄三一丕丁;
        val_15 = null;
        val_15 = null;
        int val_1 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        if(val_1 == 丞世不丒下上上丝丑)
        {
                if(val_14 == false)
        {
                return;
        }
        
        }
        
        val_14 = val_1.丝三丁七丟丅丝丒上();
        if(val_14 == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                val_17 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        }
        else
        {
                val_17 = 0.丈丄丙丙丈丗业丆万();
        }
        
        WeaponManager.丟丗丄业丘丗业丗七.丘丄万上丐上丞上丆(丞世不丒下上上丝丑:  val_17);
        val_14 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[丞世不丒下上上丝丑].丝三丁七丟丅丝丒上().丝三丁七丟丅丝丒上();
        if(val_14 == null)
        {
            goto label_17;
        }
        
        if((val_8.丆丞丆丝万业丗丛丟 & 2147483648) != 0)
        {
            goto label_18;
        }
        
        label_19:
        val_9.丆丞丆丝万业丗丛丟 = 丞世不丒下上上丝丑;
        return;
        label_17:
        if((val_8.丆丞丆丝万业丗丛丟 & 2147483648) == 0)
        {
            goto label_19;
        }
        
        label_18:
        int val_10 = val_14.丈丆专上业丐丏业一();
        if((val_10 & 2147483648) == 0)
        {
                val_10.丝三丁七丟丅丝丒上().丅丐万丛不七丌三丗(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
            return;
        }
        
        if(七万丅丟丘万丆丁与 == true)
        {
                return;
        }
        
        Player_move_c val_12 = val_10.丝三丁七丟丅丝丒上();
        val_12.专丐丏丒丘丟丁与丟(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丟业下东与东专专业:  false);
        val_12.丝三丁七丟丅丝丒上().东丐丛丅丒丑丝下下();
    }
    private string 丂丟丈世且丁专业丑(int 丞世不丒下上上丝丑, int 丕丒丅丈丌丆丝丝丛, int 下丌丒丑丆丘七万丌)
    {
        System.Collections.Generic.KeyValuePair<System.Int32, System.String>[] val_6;
        int val_6 = 丕丒丅丈丌丆丝丝丛;
        if(this.丂丘丘丌七丌丆与丟 != null)
        {
                if(this.丂丘丘丌七丌丆与丟.Length >= this.ammoCategoriesLabels.Length)
        {
            goto label_3;
        }
        
        }
        
        val_6 = new System.Collections.Generic.KeyValuePair<System.Int32, System.String>[0];
        this.丂丘丘丌七丌丆与丟 = val_6;
        goto label_5;
        label_3:
        val_6 = this.丂丘丘丌七丌丆与丟;
        label_5:
        val_6 = 下丌丒丑丆丘七万丌 + val_6;
        if(val_6 != (val_6[((long)(int)(丞世不丒下上上丝丑)) << 4][32].丙东专丂世丈丏丁丂()))
        {
                string val_4 = val_6.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            val_6 = 0;
            this.丂丘丘丌七丌丆与丟[((long)(int)(丞世不丒下上上丝丑)) << 4] = 0;
            this.丂丘丘丌七丌丆与丟[((long)(int)(丞世不丒下上上丝丑)) << 4] = val_6;
        }
        
        return (string)((this.丂丘丘丌七丌丆与丟[((long)(int)(丞世不丒下上上丝丑)) << 4][32]) == null) ? "0" : (this.丂丘丘丌七丌丆与丟[((long)(int)(丞世不丒下上上丝丑)) << 4][32]);
    }
    private string 不丗丄东丈专丒一且(int 丞世不丒下上上丝丑, int 丕丒丅丈丌丆丝丝丛, int 下丌丒丑丆丘七万丌, int 丑世不与丈上丁丅与)
    {
        var val_13;
        int val_14;
        int val_15;
        int val_16;
        MoonSharp.Interpreter.DynValue val_17;
        val_13 = 下丌丒丑丆丘七万丌;
        val_14 = 丕丒丅丈丌丆丝丝丛;
        if(this.不丁丟丕丞万丑丞丝 != null)
        {
                if(this.不丁丟丕丞万丑丞丝.Length >= this.ammoCategoriesLabels.Length)
        {
            goto label_3;
        }
        
        }
        
        this.不丁丟丕丞万丑丞丝 = new System.Collections.Generic.KeyValuePair<Rilisoft.专丈世丗业不世丗丙, System.String>[0];
        label_3:
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
            goto label_7;
        }
        
        val_15 = val_13;
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_10;
        }
        
        label_7:
        val_15 = 丑世不与丈上丁丅与;
        label_10:
        Rilisoft.专丈世丗业不世丗丙 val_4 = new Rilisoft.专丈世丗业不世丗丙(丏世一不与丗丏三不:  val_14, 世不业丌丒七不丄丗:  val_15);
        string val_5 = this.不丁丟丕丞万丑丞丝[((long)(int)(丞世不丒下上上丝丑)) << 4][32].丐丏七丌丕丗业且上();
        if(((-812795480) & 1) != 0)
        {
            goto label_13;
        }
        
        this.丕东专丙上且丑丙七.Length = 0;
        if(GameConnect.与丈丘丈上丌丝丝丛() != true)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_22;
        }
        
        }
        
        val_16 = 丑世不与丈上丁丅与;
        label_22:
        System.Text.StringBuilder val_10 = this.丕东专丙上且丑丙七.Append(value:  val_14).Append(value:  "/").Append(value:  val_16);
        this.丕东专丙上且丑丙七.Length = 0;
        MoonSharp.Interpreter.TablePair val_11 = new MoonSharp.Interpreter.TablePair(key:  val_4.丂丅丂丂万丝丐七东, val:  this.丕东专丙上且丑丙七);
        val_14 = val_11.key;
        val_17 = val_11.value;
        this.不丁丟丕丞万丑丞丝[((long)(int)(丞世不丒下上上丝丑)) << 4] = val_14;
        this.不丁丟丕丞万丑丞丝[((long)(int)(丞世不丒下上上丝丑)) << 4] = val_17;
        label_13:
        return (string)((this.不丁丟丕丞万丑丞丝[((long)(int)(丞世不丒下上上丝丑)) << 4][32]) == null) ? "0/0" : (this.不丁丟丕丞万丑丞丝[((long)(int)(丞世不丒下上上丝丑)) << 4][32]);
    }
    public void UpdateWeaponIconsForWrap()
    {
        var val_29;
        var val_39;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        string val_45;
        var val_47;
        UnityEngine.Object val_49;
        var val_50;
        int val_51;
        var val_52;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  7);
        if(val_1 != null)
        {
                val_41 = val_1.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom");
        }
        else
        {
                val_41 = 0;
        }
        
        int val_48 = 0;
        val_42 = 0;
        label_94:
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_5;
        }
        
        val_43 = null;
        val_43 = null;
        if(this.七丈丂丌丝世丞丄丛.Item[0] >= WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_11;
        }
        
        val_44 = null;
        val_44 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[this.七丈丂丌丝世丞丄丛.Item[0]].七丝丈东丈丕丐与丗() == false)
        {
            goto label_18;
        }
        
        val_45 = val_8.丙丗丕丟七丟上丈丌.业上丙丞丐丄丆丅七();
        GadgetCategory val_11 = val_8.丙丗丕丟七丟上丈丌.丒万丕七专不丏丞丌();
        goto label_22;
        label_5:
        val_47 = null;
        val_47 = null;
        UnityEngine.Texture val_13 = 上丑三丁丄丛丁万丑.丆丌万万不下丌专丕(丂丌丌不丟东丙丝丌:  0, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
        goto label_28;
        label_11:
        val_49 = 0;
        if(val_41 != 0)
        {
            goto label_29;
        }
        
        goto label_49;
        label_18:
        val_50 = null;
        val_50 = null;
        三丈丟与丏丘丈丐万 val_16 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[this.七丈丂丌丝世丞丄丛.Item[0]];
        val_45 = val_16.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        val_51 = this.七丈丂丌丝世丞丄丛.Item[0];
        三丈丟与丏丘丈丐万 val_20 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[val_51];
        label_22:
        label_28:
        val_49 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_45, 七丆丒与丗丌丄且丂:  val_20.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(val_41 == 0)
        {
            goto label_49;
        }
        
        label_29:
        if(this.丝丞丝与丒丄丙丒丙 == true)
        {
            goto label_49;
        }
        
        var val_40 = 0;
        label_48:
        if(val_40 >= val_41.Count)
        {
            goto label_47;
        }
        
        val_40 = val_40 + 1;
        if(val_48 != val_41.Item[0])
        {
            goto label_48;
        }
        
        goto label_49;
        label_47:
        val_49 = 0;
        label_49:
        if(val_49 == 0)
        {
            goto label_52;
        }
        
        UIBasicSprite val_41 = this.丗丂丘丆丈丌丕且丌()[val_48];
        List.Enumerator<T> val_27 = this.丅丟业一东专万七业.GetEnumerator();
        label_60:
        if(((-812087456) & 1) == 0)
        {
            goto label_57;
        }
        
        string val_30 = val_29.丐丏七丌丕丗业且上();
        val_51 = val_30.name;
        val_29 = 0;
        if((val_51.Equals(value:  "WeaponCat_" + 0)) == false)
        {
            goto label_60;
        }
        
        CheckAvalibleCategory val_35 = val_30.gameObject.GetComponent<CheckAvalibleCategory>();
        val_35.currentCategory = val_48;
        label_57:
        val_52 = 0 + 1;
        mem2[0] = 471;
        goto label_64;
        label_52:
        if(this.丝丞丝与丒丄丙丒丙 == false)
        {
            goto label_65;
        }
        
        if(this.丗丂丘丆丈丌丕且丌()[val_48] != null)
        {
            goto label_69;
        }
        
        goto label_69;
        label_65:
        if(this.emptyWeaponIcons[val_48] == 0)
        {
            goto label_74;
        }
        
        UIBasicSprite val_44 = this.丗丂丘丆丈丌丕且丌()[val_48];
        label_69:
        label_74:
        val_52 = 0;
        goto label_80;
        label_64:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (val_39 == 471))
        {
                var val_46 = 0;
            val_46 = val_46 ^ 0;
            val_52 =  + val_46;
        }
        
        var val_47 = 0;
        val_47 = val_47 + 1;
        label_80:
        val_48 = val_48 + 1;
        if(val_48 < 5)
        {
            goto label_94;
        }
    
    }
    private void 丞三丄业三不上丘与(int 丞世不丒下上上丝丑)
    {
        object val_26;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_27;
        string val_28;
        string val_29;
        var val_30;
        var val_31;
        var val_32;
        WeaponTogglesController.丘丈万一丅东一上万 val_1 = null;
        val_26 = val_1;
        val_1 = new WeaponTogglesController.丘丈万一丅东一上万();
        this.丑丕丄丝丅下丂丏上 = this.丌世丕东世丅丘丂丘;
        .三一丆且丂丙丈丌丐 = this.upButtonsInShopPanel[(long)丞世不丒下上上丝丑].GetComponent<ElexirInGameButtonController>();
        .丁上一丕七丒且丕丐 = this.upButtonsInShopPanel[(long)丞世不丒下上上丝丑].GetComponent<UIButton>();
        val_27 = 1152921505066536960;
        val_28 = (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.myPotion.name;
        val_29 = val_28;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_29 = 下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.idForPriceInDaterRegim);
        }
        
        .丑业丆丛不且丛丝丕 = val_29;
        if((下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  val_29)) < 1)
        {
            goto label_18;
        }
        
        val_30 = null;
        val_30 = null;
        if((val_28.Equals(value:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐)) == false)
        {
            goto label_22;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.ShowTurretInterface(丕专万丗一丛三丙丝:  "MusicBox");
        goto label_24;
        label_18:
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        val_28 = 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  11, 丛丐且下丂丏丁专丌:  下专世丏丈丞三丗不.丕三七丈丈丆七万丆(丞丅上丏丂且下丅与:  (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].丑业丆丛不且丛丝丕, 七丞丙丒三丕且丌丟:  下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].丑业丆丛不且丛丝丕)), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        if(val_28 == null)
        {
            goto label_32;
        }
        
        int val_13 = val_28.丟丂丞不专丆万丒世();
        goto label_33;
        label_22:
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                下专世丏丈丞三丗不.丒专丕七丈上业与业(丞丅上丏丂且下丅与:  (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].丑业丆丛不且丛丝丕, 丑上丏丙不丆丐丗丌:  1);
        }
        
        val_31 = null;
        val_31 = null;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_16 = null;
        val_27 = val_16;
        val_16 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        PotionsController.丄丞丁丈与业上丞丟.丙丞丁三专丏不专一(丄万丗专专丐丁丘丄:  val_28, 丘丒且与丁丑丐上与:  丝三丁七丟丅丝丒上(), 丗丅七业丝不三丄三:  val_16, 丕丕且一丕业丕丂七:  false);
        label_24:
        (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.myLabelCount.gameObject.SetActive(value:  true);
        (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.plusSprite.SetActive(value:  false);
        val_28 = (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.myLabelCount;
        val_28.text = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].丑业丆丛不且丛丝丕).ToString();
        (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.isActivePotion = true;
        (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.myLabelTime.enabled = true;
        val_26 = (WeaponTogglesController.丘丈万一丅东一上万)[1152921538155218240].三一丆且丂丙丈丌丐.myLabelTime.gameObject;
        val_26.SetActive(value:  true);
        return;
        label_32:
        int val_21 = 0.丟丂丞不专丆万丒世();
        label_33:
        string val_22 = val_28.东与三丌丅三丒丏业();
        val_32 = null;
        val_32 = null;
        val_27 = JoystickController.丗三丄与丂丟丌专东;
        System.Action val_25 = null;
        val_26 = val_25;
        val_25 = new System.Action(object:  val_27, method:  public System.Void UIJoystick::Reset());
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_28, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void WeaponTogglesController.丘丈万一丅东一上万::业丈丝下丏下丞业丄()), 丝丏丗丄丗与丐丌三:  val_25, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  88);
    }
    private void 下专丄不上世一丕东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        goto label_1;
        label_13:
        if(不丟丗丏丛丕不丁丌 == null)
        {
            goto label_5;
        }
        
        if(null == null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_5:
        label_8:
        label_7:
        if((this.upButtonsInShopPanel[0].name.Equals(value:  0.gameObject.name)) == true)
        {
            goto label_11;
        }
        
        0 = 1;
        label_1:
        if(0 < this.upButtonsInShopPanel.Length)
        {
            goto label_13;
        }
        
        label_11:
        this.丞三丄业三不上丘与(丞世不丒下上上丝丑:  0);
    }
    private void 丛丕丂万世丂下丏上(UnityEngine.GameObject 丟丕三一丙上七专丌)
    {
        string val_15;
        object val_16;
        var val_17;
        val_16 = this;
        if(丟丕三一丙上七专丌 == 0)
        {
                return;
        }
        
        丟丕三一丙上七专丌.gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesController::下专丄不上世一丕东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_16 = 丟丕三一丙上七专丌.GetComponent<ElexirInGameButtonController>();
        string val_6 = val_5.myPotion.name;
        val_15 = val_6;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_15 = 下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  val_5.idForPriceInDaterRegim);
        }
        
        val_17 = null;
        val_17 = null;
        if((PotionsController.丄丞丁丈与业上丞丟.PotionIsActive(丛丄万三丂东丙丑东:  val_6)) == false)
        {
                return;
        }
        
        UIButton val_10 = 丟丕三一丙上七专丌.GetComponent<UIButton>();
        val_5.isActivePotion = true;
        val_5.myLabelTime.gameObject.SetActive(value:  true);
        val_5.myLabelTime.enabled = true;
        val_5.priceLabel.SetActive(value:  false);
        val_5.myLabelCount.gameObject.SetActive(value:  true);
        val_5.plusSprite.SetActive(value:  false);
        val_16 = val_5.myLabelCount;
        val_15 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_15, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false).ToString();
        val_16.text = val_15;
    }
    public void HandleBuyGrenadeClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丗世丐不丕丂下丁丟();
    }
    private void 丗世丐不丕丂下丁丟()
    {
        丈丞丕丘丕丗与上一 val_15;
        int val_16;
        var val_17;
        System.Action val_19;
        var val_20;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        丈丞丕丘丕丗与上一 val_4 = 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  11, 丛丐且下丂丏丁专丌:  下专世丏丈丞三丗不.丕三七丈丈丆七万丆(丞丅上丏丂且下丅与:  "LikeID", 七丞丙丒三丕且丌丟:  下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  "LikeID")), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        if(val_4 != null)
        {
                val_16 = val_4.丟丂丞不专丆万丒世();
        }
        else
        {
                val_16 = 0.丟丂丞不专丆万丒世();
        }
        
        丈丞丕丘丕丗与上一 val_8 = null;
        val_15 = val_8;
        val_8 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_16, 丏丂不专上丘丂不丅:  val_4.东与三丌丅三丒丏业());
        if(val_15 != null)
        {
                int val_9 = val_8.丟丂丞不专丆万丒世();
        }
        else
        {
                int val_10 = val_8.丟丂丞不专丆万丒世();
        }
        
        string val_11 = val_8.东与三丌丅三丒丏业();
        val_17 = null;
        val_17 = null;
        val_19 = WeaponTogglesController.<>c.<>9__79_0;
        if(val_19 == null)
        {
                System.Action val_13 = null;
            val_19 = val_13;
            val_13 = new System.Action(object:  WeaponTogglesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponTogglesController.<>c::且丗丂丝丘丄世丆万());
            WeaponTogglesController.<>c.<>9__79_0 = val_19;
        }
        
        val_20 = null;
        val_20 = null;
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_8, 七丒上且丝业业下七:  val_13, 丝丏丗丄丗与丐丌三:  new System.Action(object:  JoystickController.丗三丄与丂丟丌专东, method:  public System.Void UIJoystick::Reset()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  88);
    }
    internal void 丒七丌七丘东业丟丅()
    {
        var val_19;
        UnityEngine.Object val_20;
        val_19 = null;
        val_19 = null;
        val_20 = 1152921505066536960;
        if(((((((((GameConnect.且丘丄丛下丆丟万丕() == true) || (GameConnect.万七丄丛丈丟专一丑() == true)) || (GameConnect.丁丁丗丐东丄丞一丛() == true)) || (GameConnect.丟丆丏上丌一丝丟业() == true)) || (GameConnect.丛专丌且丕不专丈下() == true)) || (GameConnect.丆丕丒与丂七与下上() == true)) || (GameConnect.丙丌丒丈东七丒上丌() == true)) || (GameConnect.与不丗丏万丙丞丌丑() == true)) || (GameConnect.一业上七丟业且业丙() == true))
        {
            goto label_67;
        }
        
        val_20 = PauseGUIController.丑七不且上丗丁一世();
        if(val_20 == 0)
        {
            goto label_33;
        }
        
        val_20 = PauseGUIController.丑七不且上丗丁一世();
        if(val_20.IsPaused == true)
        {
            goto label_67;
        }
        
        label_33:
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_20 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224];
            val_20 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
            val_20 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_20 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_20 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_20 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        }
        
        label_67:
        this.丟丘且丝丟且专丌东(下下东且万业丞丅丒:  false);
    }
    internal void 丟丘且丝丟且专丌东(bool 下下东且万业丞丅丒)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shopPanelForTap.gameObject, 丏业丟一东丂东丘丛:  下下东且万业丞丅丒);
    }
    public WeaponTogglesController()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>(capacity:  6);
        if(val_1 != null)
        {
                val_1.Add(key:  0, value:  99);
            val_1.Add(key:  1, value:  99);
            val_1.Add(key:  2, value:  99);
            val_1.Add(key:  3, value:  99);
            val_1.Add(key:  4, value:  99);
        }
        else
        {
                val_1.Add(key:  0, value:  99);
            val_1.Add(key:  1, value:  99);
            val_1.Add(key:  2, value:  99);
            val_1.Add(key:  3, value:  99);
            val_1.Add(key:  4, value:  99);
        }
        
        val_1.Add(key:  5, value:  99);
        this.七丈丂丌丝世丞丄丛 = val_1;
        this.丑丕丄丝丅下丂丏上 = -1f;
        this.丌世丕东世丅丘丂丘 = 10f;
        this.丅丟业一东专万七业 = new System.Collections.Generic.List<UIBasicSprite>();
        this.丕东专丙上且丑丙七 = new System.Text.StringBuilder();
    }

}
