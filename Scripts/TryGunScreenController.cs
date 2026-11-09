using UnityEngine;
public class TryGunScreenController : MonoBehaviour
{
    // Fields
    private UIButton softBuy;
    private UnityEngine.GameObject inappButtonContainer;
    private UnityEngine.GameObject softCurrencyButtonContainer;
    private UILabel inappPrice;
    public UnityEngine.GameObject buyPanel;
    public UnityEngine.GameObject equipPanel;
    public UnityEngine.GameObject backButton;
    public UnityEngine.GameObject gemsPrice;
    public UnityEngine.GameObject gemsPriceOld;
    public UnityEngine.GameObject coinsPrice;
    public UnityEngine.GameObject coinsPriceOld;
    private UIBasicSprite itemImage;
    public System.Collections.Generic.List<UILabel> itemNameLabels;
    public UnityEngine.GameObject headSpecialOffer;
    public UnityEngine.GameObject headExpired;
    public System.Collections.Generic.List<UILabel> numberOfMatchesLabels;
    public System.Collections.Generic.List<UILabel> discountLabels;
    internal System.Action 一丝东下不丛丟世三;
    internal System.Action 丝与丑三三不丄三丏;
    private string 丝三业丌丟丁丗丕丞;
    private CategoryNames 七丆丒与丗丌丄且丂;
    private 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞;
    private 丈丞丕丘丕丗与上一 丁丆丌东丈丗专七丆;
    private bool 丘丄丌与丙不丗且丅;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    
    // Properties
    internal UIBasicSprite 丐丆业丒丐不丘丆丗 { get; }
    internal string 丐丒丟丏丒七丁丈丟 { get; }
    
    // Methods
    private void Awake()
    {
        WeaponManager.丐万丑丙七丒且丂上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TryGunScreenController::与七丘丅与丛丅丂丝()));
    }
    internal UIBasicSprite 丑丅丞丕三丌丁世丐()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemImage);
        this.itemImage = val_1;
        return val_1;
    }
    internal void 业三丌世丕丆三丈丙(string 丒东业不丐丑丕丄丆, bool 丗三专万丌且丂世七)
    {
        object val_73;
        var val_74;
        int val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_87;
        int val_88;
        bool val_89;
        int val_90;
        var val_91;
        int val_92;
        var val_95;
        this.丝三业丌丟丁丗丕丞 = 丒东业不丐丑丕丄丆;
        this.丘丄丌与丙不丗且丅 = 丗三专万丌且丂世七;
        int val_2 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        this.七丆丒与丗丌丄且丂 = val_2;
        this.丒世丘丘上丆丝东丞 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  val_2, 丞一丁业丄一一业且:  this.丝三业丌丟丁丗丕丞, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        this.丁丆丌东丈丗专七丆 = 上丑三丁丄丛丁万丑.丁且丛专丁业丕东业(不三丙万与丗丌七丈:  this.七丆丒与丗丌丄且丂, 丞一丁业丄一一业且:  this.丝三业丌丟丁丗丕丞, 丂丆丗丈丏丘一丙世:  false);
        if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.丝三业丌丟丁丗丕丞, 七丆丒与丗丌丄且丂:  this.七丆丒与丗丌丄且丂, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) != 0)
        {
                if(this.丑丅丞丕三丌丁世丐() != 0)
        {
                UIBasicSprite val_9 = this.丑丅丞丕三丌丁世丐();
        }
        
        }
        
        val_73 = 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  this.丝三业丌丟丁丗丕丞);
        if(this.丘丄丌与丙不丗且丅 != false)
        {
                int val_13 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丝三业丌丟丁丗丕丞).七丙丛与万且专三三();
            val_73 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7941"), arg0:  val_73, arg1:  val_13);
        }
        
        List.Enumerator<T> val_15 = this.itemNameLabels.GetEnumerator();
        label_23:
        if((1616614624 & 1) == 0)
        {
            goto label_21;
        }
        
        val_13.丐丏七丌丕丗业且上().text = val_73;
        goto label_23;
        label_21:
        val_74 = 0;
        val_75 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (270 == 270))
        {
                val_74 = 0;
        }
        else
        {
                if( != 0)
        {
                val_75 = 0;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backButton, 丏业丟一东丂东丘丛:  (this.丘丄丌与丙不丗且丅 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buyPanel, 丏业丟一东丂东丘丛:  this.丘丄丌与丙不丗且丅);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipPanel, 丏业丟一东丂东丘丛:  (this.丘丄丌与丙不丗且丅 == false) ? 1 : 0);
        bool val_22 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().丘丅丘丝专丑丝丙东();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inappButtonContainer, 丏业丟一东丂东丘丛:  val_22 & ((this.丘丄丌与丙不丗且丅 == true) ? 1 : 0));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.softCurrencyButtonContainer, 丏业丟一东丂东丘丛:  this.丘丄丌与丙不丗且丅);
        if(val_22 != true)
        {
                UnityEngine.Transform val_25 = this.softCurrencyButtonContainer.transform;
            UnityEngine.Vector3 val_26 = val_25.localPosition;
            UnityEngine.Vector3 val_27 = val_25.localPosition;
            val_25.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if(this.丘丄丌与丙不丗且丅 != false)
        {
                val_76 = null;
            val_76 = null;
            val_77 = System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
        else
        {
                val_77 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemsPrice, 丏业丟一东丂东丘丛:  false);
        if(this.丘丄丌与丙不丗且丅 != false)
        {
                val_78 = null;
            val_78 = null;
            val_79 = System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
        else
        {
                val_79 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemsPriceOld, 丏业丟一东丂东丘丛:  false);
        if(this.丘丄丌与丙不丗且丅 != false)
        {
                val_80 = null;
            val_80 = null;
            val_81 = System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        }
        else
        {
                val_81 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.coinsPrice, 丏业丟一东丂东丘丛:  false);
        if(this.丘丄丌与丙不丗且丅 != false)
        {
                val_82 = null;
            val_82 = null;
            val_83 = System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        }
        else
        {
                val_83 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.coinsPriceOld, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.headSpecialOffer, 丏业丟一东丂东丘丛:  (this.丘丄丌与丙不丗且丅 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.headExpired, 丏业丟一东丂东丘丛:  this.丘丄丌与丙不丗且丅);
        if(this.丘丄丌与丙不丗且丅 == false)
        {
            goto label_86;
        }
        
        val_84 = null;
        val_84 = null;
        if((System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                this.gemsPrice.GetComponent<UILabel>().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世());
            this.gemsPriceOld.GetComponent<UILabel>().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丁丆丌东丈丗专七丆.丟丂丞不专丆万丒世());
        }
        
        val_85 = null;
        val_85 = null;
        if((System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
        {
                this.coinsPrice.GetComponent<UILabel>().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世());
            this.coinsPriceOld.GetComponent<UILabel>().text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丁丆丌东丈丗专七丆.丟丂丞不专丆万丒世());
        }
        
        List.Enumerator<T> val_53 = this.discountLabels.GetEnumerator();
        val_87 = 1152921505072021504;
        label_120:
        if((1616614624 & 1) == 0)
        {
            goto label_112;
        }
        
        int val_73 = 0;
        val_73 = val_73 + WeaponManager.业丗丌下丙丗丛丝万();
        val_73 = (val_73 >> 5) + (val_73 >> 31);
        int val_60 = 上丑三丁丄丛丁万丑.丅专万丅丟丈丏专丅(丕丁下丌不万丅丞丛:  this.丝三业丌丟丁丗丕丞, 与业与丗专丂丆与业: out  false);
        0.丐丏七丌丕丗业且上().text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7889"), arg0:  val_73, arg1:  val_60);
        goto label_120;
        label_86:
        val_88 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().与丈丙丞专上七丏丅();
        List.Enumerator<T> val_64 = this.numberOfMatchesLabels.GetEnumerator();
        val_89 = 1152921526277221440;
        val_75 = "Key_1995";
        label_127:
        if((1616614624 & 1) == 0)
        {
            goto label_123;
        }
        
        val_60.丐丏七丌丕丗业且上().text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1995"), arg0:  val_88);
        goto label_127;
        label_112:
        val_88 = 270;
        val_90 = ;
        val_89 = val_22;
        val_91 =  + 1;
        mem2[0] = 948;
        goto label_128;
        label_123:
        val_92 = ;
        val_87 =  + 1;
        mem2[0] = 1092;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_195;
        }
        
        if(( == 0) || (270 != 1092))
        {
            goto label_220;
        }
        
        goto label_220;
        label_195:
        if( == 0)
        {
            goto label_220;
        }
        
        goto label_220;
        label_128:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_203;
        }
        
        if(( == 0) || ( != 948))
        {
            goto label_208;
        }
        
        goto label_208;
        label_203:
        label_208:
        if( != false)
        {
                val_92 = 不丑世不专上专专丝.七三下丝与世世下上(丆万一不丌且东丐丐:  130653168);
            4194311.text = val_92;
        }
        
        Rilisoft.一丟专且三万丞丁丂.上丕与丆丑丌丄丑丒(丛与丙丒丒下丌丟且:  true, 丈丁丄丘丛世七丙丝:  0);
        label_220:
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  false);
        return;
        label_241:
        val_95 = ;
        do
        {
        
        }
        while( != 1);
        
        if((null & 1) != 0)
        {
                object[] val_72 = new object[1];
            val_72[0] = ;
            UnityEngine.Debug.LogErrorFormat(format:  "Exception in updating armory info screen after exiting details bank: {0}", args:  val_72);
            return;
        }
        
        mem[8] = ;
        goto label_241;
    }
    internal string 与且丕丒专且三且丅()
    {
        return (string)this.丝三业丌丟丁丗丕丞;
    }
    public void HandleEquip()
    {
        var val_5;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  135);
        val_5 = null;
        val_5 = null;
        WeaponManager.丟丗丄业丘丗业丗七.且丟下丝丄万丞丞与(丞世不丒下上上丝丑:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丝三业丌丟丁丗丕丞).业东丅东丌上丗丑不());
        WeaponManager.丌丟上丕一丙丟丌丄();
        WeaponManager.万下丟丁丘丂一与丛(上丑丕上丕丁丂丏专:  false);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void HandleClose()
    {
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
        this.丑下丞丁丒丗丂世丗();
    }
    private void 丑下丞丁丒丗丂世丗()
    {
        if(this == 0)
        {
                return;
        }
        
        if(this.gameObject == 0)
        {
                return;
        }
        
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void HandleBuy()
    {
        int val_1 = this.丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世();
        string val_2 = this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业();
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  this.丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void TryGunScreenController::世丟丌丄不一丌专丙()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  this.丝与丑三三不丄三丏, 丞丐下东与丅万丅丁:  this.一丝东下不丛丟世三, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  136, 丐丈上丂与上丂丒丏:  108);
    }
    public void HandleForward()
    {
        StoreKitEventListener.丆丂一丄丐丅丄东一(七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void TryGunScreenController::三七且丈与七三七丈()));
    }
    private void OnEnable()
    {
        if(HintController.与一丅丝不丈业与丙() == 0)
        {
                return;
        }
        
        HintController.与一丅丝不丈业与丙().东丏一丁下丄丙丙丂();
    }
    private void OnDisable()
    {
        if(HintController.与一丅丝不丈业与丙() == 0)
        {
                return;
        }
        
        HintController.与一丅丝不丈业与丙().丙万丞丄丐丂下丅丘();
    }
    private void Start()
    {
        this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void TryGunScreenController::专丗七专丐万一丐万()), 与且专丈不万东一万:  "Try Gun Screen");
    }
    private void OnDestroy()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        WeaponManager.七丕丕丒丗丄丒丌上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TryGunScreenController::与七丘丅与丛丅丂丝()));
    }
    private void Update()
    {
        if(this.丘丄丌与丙不丗且丅 == false)
        {
                return;
        }
        
        bool val_4 = StoreKitEventListener.三丘丈不丝丕丞东丌();
        if(val_4 ^ this.softBuy != false)
        {
                return;
        }
        
        val_4 = val_4 ^ 1;
        bool val_3 = val_4;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 与七丘丅与丛丅丂丝()
    {
        var val_2;
        if(this.丘丄丌与丙不丗且丅 == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  this.丝三业丌丟丁丗丕丞)) == true)
        {
                return;
        }
        
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
        this.丑下丞丁丒丗丂世丗();
    }
    public TryGunScreenController()
    {
    
    }
    private void 世丟丌丄不一丌专丙()
    {
        丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  this.七丆丒与丗丌丄且丂, 丞一丁业丄一一业且:  this.丝三业丌丟丁丗丕丞, 七丝下七下丗三且丟:  new System.Action<System.String>(object:  this, method:  System.Void TryGunScreenController::下上万丝与丑丕上丄(string 下丅丙一丂丗丅丝七)), 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  this.丒世丘丘上丆丝东丞, 丄下丁东丘业丆丝上:  0, 不丐丅丁丂七丐丘丛:  0);
        PersConfigurator.与与丑丂丛上七上丗();
        ShopNGUIController.丕上万丑七丗丕一丈();
        PGCompany.Analytics.一业丗丆世世上丁且.一丁七丂且丁丗万丏(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丆丒与丗丌丄且丂:  this.七丆丒与丗丌丄且丂, 丞一丁业丄一一业且:  this.丝三业丌丟丁丗丕丞, 七丐丅专且专七三丆:  "buy", 万丐丏丐丒万不丟三:  this.丒世丘丘上丆丝东丞, 与上世丗丞丐万东丌:  "try gun bunner", 与丙丆世丘丑丒丌丄:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false}, 丞业丛世丛丘丝不丌:  false, 丈丄不七三万丄丁不:  0);
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
        this.丑下丞丁丒丗丂世丗();
    }
    private void 下上万丝与丑丕上丄(string 下丅丙一丂丗丅丝七)
    {
        ShopNGUIController.三丟不东丆万七三与(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        Rilisoft.一丟专且三万丞丁丂.丆世丟业世丛丛丆丘(丞一丁业丄一一业且:  this.丝三业丌丟丁丗丕丞, 七丆丒与丗丌丄且丂:  this.七丆丒与丗丌丄且丂, 丒世丘丘上丆丝东丞:  this.丒世丘丘上丆丝东丞);
    }
    private void 三七且丈与七三七丈()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        丘丝丑丐丆丑七不丙 val_11;
        var val_13;
        var val_14;
        string val_1 = 不丑世不专上专专丝.丒丕东丐丅丙与丗且(丆万一不丌且东丐丐:  this.丝三业丌丟丁丗丕丞);
        val_7 = 0;
        goto label_3;
        label_12:
        val_8 = null;
        val_8 = null;
        val_9 = 0;
        if((System.String.op_Equality(a:  val_1, b:  64)) == true)
        {
            goto label_8;
        }
        
        val_7 = 1;
        label_3:
        val_10 = null;
        val_10 = null;
        if(val_7 < StoreKitEventListener.业万专三一丟且丘业.Length)
        {
            goto label_12;
        }
        
        val_11 = 0;
        goto label_13;
        label_8:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = 0;
        val_11 = AbstractBankView.丒丁丞丝世三与七东().Item[0];
        label_13:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        null.Add(key:  "ID", value:  val_1);
        val_13 = null;
        val_13 = null;
        null.Add(key:  "Key", value:  与丂丏丛丞丞丒丟丄.丐上丆三丛不业丌丆);
        null.Add(key:  "action", value:  与丂丏丛丞丞丒丟丄.丐上丆三丛不业丌丆);
        null.Add(key:  "Weapon", value:  this.丝三业丌丟丁丗丕丞);
        val_14 = null;
        val_14 = null;
        coinsShop.专丆专上丗万世丒七.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  val_11, 丈上上丟丟丏万丐且:  null);
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
        this.丑下丞丁丒丗丂世丗();
    }
    private void 专丗七专丐万一丐万()
    {
        if(this.丘丄丌与丙不丗且丅 != true)
        {
                this.HandleEquip();
        }
        
        ArmoryInfoScreenController.丅丐万丏丑丈七丟业(丛与丙丒丒下丌丟且:  true);
        this.丑下丞丁丒丗丂世丗();
    }

}
