using UnityEngine;
public class SpeedUpWeaponUpWindow : MonoBehaviour
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    private 丙且上东下丏丏丟下 丆业丞东万丄丞丈万;
    private 丙且上东下丏丏丟下 专业东丄丐丂七上与;
    public UIBasicSprite speedUpItemImage;
    public UIBasicSprite instantItemImage;
    public UILabel[] speedupItemName;
    public UILabel[] instantItemName;
    public UILabel[] timeLeft;
    public Rilisoft.PriceView speedupPrice;
    public Rilisoft.PriceView instantPrice;
    private bool <丑丐与丅丅丛专丑丂>k__BackingField;
    
    // Properties
    internal bool 三丂丌万专丆且丆丄 { get; set; }
    private UIBasicSprite 不一七不丗与丟丛一 { get; }
    private UIBasicSprite 丞丈丄丝七丅一丈丈 { get; }
    
    // Methods
    internal bool 下东丑丞丑下下丑丈()
    {
        return (bool)this.<丑丐与丅丅丛专丑丂>k__BackingField;
    }
    private void 三且丁丆与专丈与丁(bool 丙业与丙丗丝不丈东)
    {
        this.<丑丐与丅丅丛专丑丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private UIBasicSprite 丗东丞丞七丟丛丕丑()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.speedUpItemImage);
        this.speedUpItemImage = val_1;
        return val_1;
    }
    private UIBasicSprite 丌丕与丙且丄丙丗东()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.instantItemImage);
        this.instantItemImage = val_1;
        return val_1;
    }
    internal void 下与丞三丅丛丄七丕(丙且上东下丏丏丟下 丐下丅上下东一七丙, 丙且上东下丏丏丟下 下丛丂丄丑丁七丙丅, bool 丆丗一丛丌一与丅且 = False)
    {
        丙且上东下丏丏丟下 val_23;
        this.<丑丐与丅丅丛专丑丂>k__BackingField = 丆丗一丛丌一与丅且;
        this.丆业丞东万丄丞丈万 = 丐下丅上下东一七丙.丕东丞业丗三丅丗万();
        this.专业东丄丐丂七上与 = 下丛丂丄丑丁七丙丅.丕东丞业丗三丅丗万();
        if(this.丆业丞东万丄丞丈万 != null)
        {
                .丟下丟丈万一丙东丄 = 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  this.丆业丞东万丄丞丈万.业上丙丞丐丄丆丅七());
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.speedupItemName, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new SpeedUpWeaponUpWindow.与丟业一丈上丅上不(), method:  System.Void SpeedUpWeaponUpWindow.与丟业一丈上丅上不::丆且丒丗丈丞丈丘且(UILabel 丐三丞七丝丅不万丛)));
            UIBasicSprite val_8 = this.丗东丞丞七丟丛丕丑();
            UnityEngine.Texture val_11 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.丆业丞东万丄丞丈万.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.丆业丞东万丄丞丈万.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            this.丟丏七一丒丟丛丕一();
            val_23 = this.专业东丄丐丂七上与;
        }
        
        if(val_23 != null)
        {
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.instantItemName, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  this, method:  System.Void SpeedUpWeaponUpWindow::丆不七丅业丈一丐丑(UILabel 丐三丞七丝丅不万丛)));
            UnityEngine.Texture val_16 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.专业东丄丐丂七上与.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.专业东丄丐丂七上与.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            this.instantPrice.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this.丌丕与丙且丄丙丗东().丁丛丛丈一丆丆丁上(), 万丐丁三且下丞丈丌:  0);
        }
        
        this.speedupPrice.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpeedUpWeaponUpWindow::丑丙丑且丐专丞东东()));
        this.instantPrice.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpeedUpWeaponUpWindow::丅丛丙七一丟丝丅丑()));
        this.东三业丙丏业且世丁();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void SpeedUpWeaponUpWindow::Hide()), 与且专丈不万东一万:  "SpeedUpWeaponUpWindow");
    }
    private void 丟丏七一丒丟丛丕一()
    {
        this.speedupPrice.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  SpeedUpWeaponUpWindow.丂丘下丈丐丞丝专丙(丒东业不丐丑丕丄丆:  this.丆业丞东万丄丞丈万.业上丙丞丐丄丆丅七(), 丝东丌万丒丁丒世丑:  false, 丆丗一丛丌一与丅且:  this.<丑丐与丅丅丛专丑丂>k__BackingField), 万丐丁三且下丞丈丌:  0);
    }
    private 丈丞丕丘丕丗与上一 丁丛丛丈一丆丆丁上()
    {
        null = null;
        return (丈丞丕丘丕丗与上一)new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  200, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
    }
    internal static 丈丞丕丘丕丗与上一 丂丘下丈丐丞丝专丙(string 丒东业不丐丑丕丄丆, bool 丝东丌万丒丁丒世丑 = False, bool 丆丗一丛丌一与丅且 = False)
    {
        int val_49;
        var val_50;
        string val_51;
        var val_52;
        int val_53;
        string val_54;
        var val_55;
        var val_56;
        float val_57;
        float val_59;
        var val_60;
        var val_61;
        string val_62;
        var val_63;
        var val_64;
        System.Object[] val_66;
        string val_67;
        val_49 = 丆丗一丛丌一与丅且;
        int val_1 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_1 != 7)
        {
            goto label_3;
        }
        
        val_50 = null;
        val_50 = null;
        val_51 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        val_52 = new 丈丞丕丘丕丗与上一();
        val_53 = 100;
        goto label_6;
        label_3:
        if(val_49 == false)
        {
            goto label_7;
        }
        
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        val_54 = 丒东业不丐丑丕丄丆;
        if((丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  丒东业不丐丑丕丄丆)) == true)
        {
            goto label_14;
        }
        
        if(val_3 == null)
        {
            goto label_13;
        }
        
        val_54 = val_3.三与丛丑且丐丈业丌();
        goto label_14;
        label_7:
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  val_1)) == false)
        {
            goto label_17;
        }
        
        int val_47 = 丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  丒东业不丐丑丕丄丆);
        if(val_47 == 1)
        {
            goto label_20;
        }
        
        val_47 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丌丈丐丕万业上丆专().Item[val_47] + 1;
        val_55 = BalanceController.专丝丂上丗丝专万丏(东一丐专丘丄万丏丟:  val_47);
        long val_11 = BalanceController.下丙一丕丁上万丂三(东一丐专丘丄万丏丟:  val_47);
        val_56 = val_11;
        if(丝东丌万丒丁丒世丑 != true)
        {
                val_56 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业().东丂丞业三丗业三丙() - FriendsController.丝丗专上三不丄丑丑();
        }
        
        val_57 = 1f;
        float val_16 = UnityEngine.Mathf.Max(a:  val_57, b:  (float)val_11);
        val_59 = (float)val_56;
        goto label_36;
        label_17:
        val_60 = null;
        val_60 = null;
        if(((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  220)) & (System.String.op_Equality(a:  丒东业不丐丑丕丄丆, b:  与世丁丙且丑下丌不.东下丕丅三与丙一三))) == false)
        {
            goto label_40;
        }
        
        val_61 = null;
        val_61 = null;
        goto label_6;
        label_40:
        三丅丁丗丗丝丂万且 val_21 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        丕丑丙丑丙东丌丘丕 val_24 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_21.业东丅东丌上丗丑不());
        if(val_24 == null)
        {
            goto label_50;
        }
        
        丕丑丙丑丙东丌丘丕 val_25 = BalanceController.丌丛丄丙丘丈与下专(丞丌东丟且丒丐丑丂:  val_24, 丐丏上业丈丂与万丞:  false);
        val_55 = BalanceController.丁丑丄上丗丝与丐上(丞丌东丟且丒丐丑丂:  val_25, 丝三丛且丘不丌丙下:  val_21.三与丛丑且丐丈业丌());
        val_62 = val_21.三与丛丑且丐丈业丌();
        val_63 = (long)BalanceController.丄世丐丅丗丑丆一业(丞丌东丟且丒丐丑丂:  val_25, 丝三丛且丘不丌丙下:  val_62);
        val_64 = val_63;
        if(丝东丌万丒丁丒世丑 == true)
        {
            goto label_66;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_30 = WeaponManager.且且丟丗丏与世万丏();
        goto label_58;
        label_13:
        val_54 = "";
        label_14:
        if((丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  丒东业不丐丑丕丄丆)) != false)
        {
                val_54 = 丛且丗丌丏下七下丈.世一且上丗丐丂世丙(丞一丁业丄一一业且:  丒东业不丐丑丕丄丆);
        }
        
        val_55 = BalanceController.丁丁万不三万七丅丈(丏世丑万世一七丟丞:  val_54);
        val_62 = 0;
        val_63 = (long)BalanceController.与丟业丑世业万世且(丏世丑万世一七丟丞:  val_54);
        val_64 = val_63;
        if(丝东丌万丒丁丒世丑 == true)
        {
            goto label_66;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_35 = WeaponManager.万一丛七丙丑丄丆丑();
        label_58:
        val_64 =  - FriendsController.丝丗专上三不丄丑丑();
        label_66:
        val_57 = 1f;
        val_59 = (float)val_64;
        label_36:
        float val_48 = (float)val_55.丟丂丞不专丆万丒世();
        val_48 = (val_59 / (UnityEngine.Mathf.Max(a:  val_57, b:  (float)val_63))) * val_48;
        val_49 = System.Math.Max(val1:  1, val2:  UnityEngine.Mathf.CeilToInt(f:  val_48));
        val_51 = val_55.东与三丌丅三丒丏业();
        丈丞丕丘丕丗与上一 val_43 = null;
        val_52 = val_43;
        val_53 = val_49;
        label_6:
        val_43 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_53, 丏丂不专上丘丂不丅:  val_51);
        return (丈丞丕丘丕丗与上一)val_52;
        label_20:
        val_66 = new object[1];
        val_66[0] = (丒东业不丐丑丕丄丆 == null) ? "null" : 丒东业不丐丑丕丄丆;
        val_67 = "Speedu_pPrice index == -1 , tg = {0}";
        goto label_83;
        label_50:
        object[] val_46 = new object[1];
        val_66 = val_46;
        val_66[0] = 丒东业不丐丑丕丄丆;
        val_67 = "Speedu_pPrice WeaponM_anager.Upgrade_OfWeapon( speedupTg ) == null , speedupTg = {0}";
        label_83:
        UnityEngine.Debug.LogErrorFormat(format:  val_67, args:  val_46);
        return (丈丞丕丘丕丗与上一)val_52;
    }
    private void 丑丙丑且丐专丞东东()
    {
    
    }
    private void 丅丛丙七一丟丝丅丑()
    {
    
    }
    public void Hide()
    {
        this.speedupPrice.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpeedUpWeaponUpWindow::丑丙丑且丐专丞东东()));
        this.instantPrice.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpeedUpWeaponUpWindow::丅丛丙七一丟丝丅丑()));
        this.东三业丙丏业且世丁();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
    }
    private void 东三业丙丏业且世丁()
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
    private void Update()
    {
        var val_40;
        bool val_41;
        丙且上东下丏丏丟下 val_42;
        var val_43;
        var val_45;
        val_40 = 0;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.丆业丞东万丄丞丈万.丒万丕七专不丏丞丌())) == true)
        {
            goto label_4;
        }
        
        val_40 = 0;
        if(this.丆业丞东万丄丞丈万.丒万丕七专不丏丞丌() != 150000)
        {
            goto label_6;
        }
        
        label_4:
        val_41 = this;
        if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false)
        {
            goto label_7;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_4 = WeaponManager.万一丛七丙丑丄丆丑();
        val_42 = this.丆业丞东万丄丞丈万;
        if((System.String.op_Inequality(a:  val_4.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  val_42.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_40;
        }
        
        val_42 = this.丆业丞东万丄丞丈万.业上丙丞丐丄丆丅七();
        if((WeaponManager.七世丂丁丆丙丐丆丌().Contains(item:  val_42)) == false)
        {
            goto label_21;
        }
        
        goto label_40;
        label_7:
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_11 = WeaponManager.且且丟丗丏与世万丏();
        val_42 = this.丆业丞东万丄丞丈万;
        if((System.String.op_Inequality(a:  val_11.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  val_42.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_21;
        }
        
        goto label_40;
        label_6:
        val_41 = this.<丑丐与丅丅丛专丑丂>k__BackingField;
        label_21:
        if((val_41 == true) || ((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  this.丆业丞东万丄丞丈万.丒万丕七专不丏丞丌())) == false))
        {
            goto label_34;
        }
        
        丞丑七丙业万与七丟 val_18 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业();
        if(val_18 == null)
        {
            goto label_34;
        }
        
        val_42 = 1152921505065418752;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_34;
        }
        
        val_42 = FriendsController.丝丗专上三不丄丑丑();
        if(val_42 >= val_18.东丂丞业三丗业三丙())
        {
            goto label_37;
        }
        
        label_34:
        if(FriendsController.丝丗专上三不丄丑丑() == 1)
        {
            goto label_40;
        }
        
        if(this.speedupPrice != 0)
        {
                this.丟丏七一丒丟丛丕一();
        }
        
        if(this.timeLeft == null)
        {
                return;
        }
        
        SpeedUpWeaponUpWindow.丒丂万丒丂一上丞一 val_24 = null;
        val_43 = 0;
        val_24 = new SpeedUpWeaponUpWindow.丒丂万丒丂一上丞一();
        if(val_41 == false)
        {
            goto label_45;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_25 = WeaponManager.万一丛七丙丑丄丆丑();
        goto label_48;
        label_45:
        val_43 = 0;
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  this.丆业丞东万丄丞丈万.丒万丕七专不丏丞丌())) == false)
        {
            goto label_52;
        }
        
        long val_30 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业().东丂丞业三丗业三丙();
        goto label_57;
        label_52:
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_31 = WeaponManager.且且丟丗丏与世万丏();
        label_48:
        val_45;
        label_57:
        val_42 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_45 - FriendsController.丝丗专上三不丄丑丑(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        if(val_24 != null)
        {
                .下业七不丑丂丏丟东 = val_42;
        }
        else
        {
                mem[16] = val_42;
            val_42 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_42)) == false)
        {
            goto label_68;
        }
        
        label_40:
        this.Hide();
        return;
        label_68:
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.timeLeft, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_24, method:  System.Void SpeedUpWeaponUpWindow.丒丂万丒丂一上丞一::丕丈七下下一丈丈丐(UILabel 丐三丞七丝丅不万丛)));
        return;
        label_37:
        this.Hide();
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
    }
    public SpeedUpWeaponUpWindow()
    {
    
    }
    private void 丆不七丅业丈一丐丑(UILabel 丐三丞七丝丅不万丛)
    {
        丐三丞七丝丅不万丛.text = 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  this.专业东丄丐丂七上与.业上丙丞丐丄丆丅七());
    }

}
