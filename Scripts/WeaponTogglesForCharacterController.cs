using UnityEngine;
public class WeaponTogglesForCharacterController : PGBehaviour
{
    // Fields
    private UnityEngine.Transform weaponsPanel;
    private WidgetLayout weaponsPanelWidget;
    private UIButton[] weaponButtons;
    private UIBasicSprite[] weaponIcons;
    private UILabel[] ammoLabels;
    private UISprite[] weaponButtonsCheckmarkSprites;
    private bool 丗丂丕丒丙与丗丕丁;
    private bool 丄不专且一不丅三丕;
    private System.Collections.Generic.KeyValuePair<int, string>[] 丂丘丘丌七丌丆与丟;
    private readonly System.Text.StringBuilder 丕东专丙上且丑丙七;
    private System.Collections.Generic.KeyValuePair<Rilisoft.专丈世丗业不世丗丙, string>[] 不丁丟丕丞万丑丞丝;
    
    // Properties
    private UIBasicSprite[] 丄丆丘一丙万丅丁下 { get; }
    private int 上上丁上丁丟丌丝丏 { get; }
    
    // Methods
    private void Awake()
    {
        if(this.weaponButtons[0] != 0)
        {
                this.weaponButtons[0].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesForCharacterController::且丘三丗丟上丆丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.weaponButtons[1] == 0)
        {
                return;
        }
        
        this.weaponButtons[1].gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesForCharacterController::丏丘三与三丆业丏丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnDestroy()
    {
        this.weaponButtons[0].gameObject.GetComponent<Rilisoft.ButtonHandler>().remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesForCharacterController::且丘三丗丟上丆丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.weaponButtons[1].gameObject.GetComponent<Rilisoft.ButtonHandler>().remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponTogglesForCharacterController::丏丘三与三丆业丏丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 且丘三丗丟上丆丙丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  0, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  false);
    }
    private void 丏丘三与三丆业丏丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  1, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  false);
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
    private void Start()
    {
        this.UpdateWeaponIconsForWrap();
    }
    private void Update()
    {
        if(this.weaponsPanel.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.上一东丏丂丞三丏且();
    }
    private void 上一东丏丂丞三丏且()
    {
        var val_14;
        var val_15;
        UnityEngine.Object val_16;
        UILabel val_17;
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_15 = 0;
        goto label_42;
        label_47:
        val_16 = 0;
        if(this.ammoLabels[0] == val_16)
        {
            goto label_28;
        }
        
        if(val_15 >= this.weaponButtons.Length)
        {
                val_16 = 0;
        }
        
        if((this.weaponButtons[0] & 1) == 0)
        {
            goto label_33;
        }
        
        val_17 = mem[(typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32];
        val_17 = (typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32;
        if(((typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32 + 48.丐专丒丟丈丛丈丂业()) != false)
        {
                if(((typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32 + 48.不丅丟丞丏丒丌三丌()) == false)
        {
            goto label_33;
        }
        
        }
        
        int val_9 = (typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32.下世万丆丛专丒丑丙();
        int val_10 = (typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32.东东丄丅丐一丙一业();
        if(((typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32 + 48.不丅丟丞丏丒丌三丌()) == false)
        {
            goto label_37;
        }
        
        string val_11 = this.丂丟丈世且丁专业丑(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_9, 下丌丒丑丆丘七万丌:  val_10);
        goto label_38;
        label_33:
        val_17 = this.ammoLabels[0];
        if(val_17 != null)
        {
            goto label_44;
        }
        
        label_45:
        label_44:
        val_17.text = System.String.alignConst;
        label_28:
        val_15 = 1;
        goto label_42;
        label_37:
        string val_13 = this.不丗丄东丈专丒一且(丞世不丒下上上丝丑:  0, 丕丒丅丈丌丆丝丝丛:  val_9, 下丌丒丑丆丘七万丌:  val_10, 丑世不与丈上丁丅与:  (typeof(Player_move_c).__il2cppRuntimeField_AB8 + 0) + 32 + 48.下世下丂丂丌丑丝世());
        label_38:
        if(this.ammoLabels[0] != null)
        {
            goto label_44;
        }
        
        goto label_45;
        label_42:
        if(val_15 < this.ammoLabels.Length)
        {
            goto label_47;
        }
    
    }
    internal void 丞丞丛丐且丂丄一丏()
    {
        var val_3;
        var val_4;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_3;
        }
        
        val_3 = null;
        val_3 = null;
        var val_2 = (typeof(Player_move_c).__il2cppRuntimeField_AC0 == (typeof(Player_move_c).__il2cppRuntimeField_AB8 + 32)) ? 1 : 0;
        if(this != null)
        {
            goto label_14;
        }
        
        goto label_13;
        label_3:
        val_4 = 0;
        if(this != null)
        {
            goto label_14;
        }
        
        label_13:
        label_14:
        this.七丌丅七丝东丛丒三(东七丛丝丑专世丏三:  0, 丘上丅丝丄三一丕丁:  false, 七万丅丟丘万丆丁与:  false);
    }
    internal void 丒七丌七丘东业丟丅()
    {
        null = null;
        bool val_1 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
        this.丞丏丛万世万丒丄不(下下东且万业丞丅丒:  false);
    }
    private void LateUpdate()
    {
        if(this.丄不专且一不丅三丕 != false)
        {
                this.weaponsPanelWidget.Reposition();
            this.丄不专且一不丅三丕 = false;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  24)) == false)
        {
                return;
        }
        
        this.丄不专且一不丅三丕 = true;
    }
    internal void 丞丏丛万世万丒丄不(bool 下下东且万业丞丅丒)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponsPanel.gameObject, 丏业丟一东丂东丘丛:  下下东且万业丞丅丒);
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        this.UpdateWeaponIconsForWrap();
    }
    private int 上与丌上业丕丏下不()
    {
        var val_8;
        Player_move_c val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_9 != 0)
        {
                val_9 = typeof(Player_move_c).__il2cppRuntimeField_AB0.丛丈丒七丈丑丑丅丏();
            val_10 = ((((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  typeof(Player_move_c).__il2cppRuntimeField_AB0.世丏专不万丏世丌丞())) & true) != 0) ? (1 + 1) : 1) - (丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9));
            return (int)val_10;
        }
        
        val_10 = 0;
        return (int)val_10;
    }
    public void UpdateWeaponIconsForWrap()
    {
        var val_17;
        CategoryNames val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                val_17 = 0;
        }
        
        if(this.上与丌上业丕丏下不() < 1)
        {
            goto label_4;
        }
        
        var val_19 = 0;
        label_26:
        if(val_19 != 0)
        {
                三丅丁丗丗丝丂万且 val_2 = typeof(Player_move_c).__il2cppRuntimeField_AB0.专丌丑万丂丙丂上下();
        }
        else
        {
                三丅丁丗丗丝丂万且 val_3 = typeof(Player_move_c).__il2cppRuntimeField_AB0.与世且不丝丈且专世();
        }
        
        if(val_3 != null)
        {
                val_19 = val_3.丒万丕七专不丏丞丌();
        }
        else
        {
                val_19 = 0.丒万丕七专不丏丞丌();
        }
        
        val_20 = UnityEngine.Object.op_Inequality(x:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_3.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_19, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false), y:  0);
        UIBasicSprite val_17 = this.丗丂丘丆丈丌丕且丌()[0];
        if(val_17 == null)
        {
            goto label_17;
        }
        
        if(val_20 == false)
        {
            goto label_18;
        }
        
        label_24:
        val_21 = 1;
        val_22 = this.丗丂丘丆丈丌丕且丌()[0].gameObject;
        goto label_23;
        label_17:
        if(val_20 == true)
        {
            goto label_24;
        }
        
        label_18:
        val_22 = val_17.gameObject;
        val_21 = 0;
        label_23:
        val_22.SetActive(value:  false);
        val_19 = val_19 + 1;
        if(val_19 < val_22.上与丌上业丕丏下不())
        {
            goto label_26;
        }
        
        label_4:
        val_23 = 0;
        goto label_27;
        label_33:
        UnityEngine.GameObject val_14 = this.weaponButtons[0].gameObject;
        val_20 = val_14.上与丌上业丕丏下不();
        val_14.SetActive(value:  (val_23 < val_20) ? 1 : 0);
        val_23 = 1;
        label_27:
        if(val_23 < this.weaponButtons.Length)
        {
            goto label_33;
        }
        
        this.丄不专且一不丅三丕 = true;
    }
    private string 丂丟丈世且丁专业丑(int 丞世不丒下上上丝丑, int 丕丒丅丈丌丆丝丝丛, int 下丌丒丑丆丘七万丌)
    {
        System.Collections.Generic.KeyValuePair<System.Int32, System.String>[] val_6;
        int val_6 = 丕丒丅丈丌丆丝丝丛;
        if(this.丂丘丘丌七丌丆与丟 != null)
        {
                if(this.丂丘丘丌七丌丆与丟.Length >= this.ammoLabels.Length)
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
                if(this.不丁丟丕丞万丑丞丝.Length >= this.ammoLabels.Length)
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
        if(((-804885560) & 1) != 0)
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
    private void 七丌丅七丝东丛丒三(int 东七丛丝丑专世丏三, bool 丘上丅丝丄三一丕丁 = False, bool 七万丅丟丘万丆丁与 = False)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        goto label_6;
        label_12:
        this.weaponButtons[0].GetComponent<UIToggle>().value = (东七丛丝丑专世丏三 == val_5) ? 1 : 0;
        val_5 = 1;
        label_6:
        if(val_5 < this.weaponButtons.Length)
        {
            goto label_12;
        }
        
        七万丅丟丘万丆丁与 = 七万丅丟丘万丆丁与;
        this.丟一丌丂丗丂丐七东(丞世不丒下上上丝丑:  东七丛丝丑专世丏三, 丘上丅丝丄三一丕丁:  丘上丅丝丄三一丕丁, 七万丅丟丘万丆丁与:  七万丅丟丘万丆丁与);
    }
    private void 丟一丌丂丗丂丐七东(int 丞世不丒下上上丝丑, bool 丘上丅丝丄三一丕丁 = False, bool 七万丅丟丘万丆丁与 = False)
    {
        Player_move_c val_8;
        var val_9;
        var val_10;
        var val_11;
        int val_12;
        var val_13;
        val_8 = 丘上丅丝丄三一丕丁;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万() == 丞世不丒下上上丝丑)
        {
                if(val_8 == false)
        {
                return;
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_8 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                val_12 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        }
        else
        {
                val_12 = 0.丈丄丙丙丈丗业丆万();
        }
        
        WeaponManager.丟丗丄业丘丗业丗七.丘丄万上丐上丞上丆(丞世不丒下上上丝丑:  val_12);
        三丈丟与丏丘丈丐万 val_6 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[丞世不丒下上上丝丑];
        if(null != 0)
        {
                return;
        }
        
        val_13 = 1272;
        val_12 = static_value_000004F8;
    }
    public WeaponTogglesForCharacterController()
    {
        this.丕东专丙上且丑丙七 = new System.Text.StringBuilder();
    }

}
