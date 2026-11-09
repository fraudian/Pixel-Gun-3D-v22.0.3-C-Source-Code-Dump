using UnityEngine;
public class AccountsMenuItem : MonoBehaviour
{
    // Fields
    private const string 丒七丅丄丙丅丈三业 = "MigrationToNewProgress/AccountProgressInfo";
    private const string 丐且丆丙丆丌三丈丑 = "MigrationToNewProgress/AccountProgressAlreadyBindedMessage";
    private const string 丆上丛丅丆下不丑丈 = "MigrationToNewProgress/AccountAttention";
    private const string 丆下东丕丑万丅世丌 = "MigrationToNewProgress/AccountProgressWarning";
    private const string 东丗丟丒丒丘丑丙丈 = "MigrationToNewProgress/StartNewGame";
    private ProgressInfoWindow 丟丕丞东丟丄丘世与;
    private UpdateIdBindingWindow 丒丞丘上丞丗丕丛丆;
    private StartNewGameWindow 专且不丂东丙三七七;
    private UnityEngine.GameObject 万不业丞业丝丐不与;
    private UnityEngine.GameObject 丑丗专丅丙丅丈丆丘;
    private UnityEngine.GameObject _notLoggedNoIdBinding;
    private UnityEngine.GameObject _loggedIdCorrectlyBinded;
    private UnityEngine.GameObject _loggedIdMisbinded;
    private UnityEngine.GameObject _loggedInNotBinded;
    private UIButton[] _notSignedInButtons;
    private UIButton[] _buttonsWithHandlerUpdateBindingClick;
    private UILabel[] _socialNameLabels;
    
    // Methods
    private void OnEnable()
    {
        丅丛丟上丁丆上丛专.一丆丟丟丈下丌丕丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.与丟且与丛东业丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.丞万东下业世与丁丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.丞万东下业世与丁丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丙丁丏丝丝且且丗丟()));
        上丞丑上丙丈丄丗丐.且丕丅丕丝丛丂与丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丐丛七丝丑东丒一一()));
        LifetimeEventsRaiser.丑七不且上丗丁一世().丈丒丒东下丆丙丄丌(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AccountsMenuItem::丕丁三丛丘且丙丞七(bool 丁与丟万丄丒丗专丌)));
        this.丝一丅丆三东丂丞七();
    }
    private void 丐丛七丝丑东丒一一()
    {
        丅丛丟上丁丆上丛专.上且万万丆专万一上(丙业与丙丗丝不丈东:  false);
        this.丝一丅丆三东丂丞七();
    }
    private void 丕丁三丛丘且丙丞七(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                return;
        }
        
        丅丛丟上丁丆上丛专.上且万万丆专万一上(丙业与丙丗丝不丈东:  false);
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        丅丛丟上丁丆上丛专.丂丞三一三丐丄丗世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.丐丞丅万专丌且世业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.业丛世丒世专丅丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.业丛世丒世专丅丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丙丁丏丝丝且且丗丟()));
        丅丛丟上丁丆上丛专.世上丗丐丆丙丝丒三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丙丁丏丝丝且且丗丟()));
        LifetimeEventsRaiser.丑七不且上丗丁一世().丏万万丄丐上丙且下(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AccountsMenuItem::丕丁三丛丘且丙丞七(bool 丁与丟万丄丒丗专丌)));
        上丞丑上丙丈丄丗丐.不丄一丌丝丞丘不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丐丛七丝丑东丒一一()));
        上丞丑上丙丈丄丗丐.不丄一丌丝丞丘不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丛丝丘专业丁丑下丘()));
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                return;
        }
        
        丅丛丟上丁丆上丛专.上且万万丆专万一上(丙业与丙丗丝不丈东:  false);
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_5;
        this.丙丞丝丁丄上上丏丁();
        this.丙丑丘业丕丗丗不丘();
        val_5 = AccountsMenuItem.与与丆丞世丒丐丁上();
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != true)
        {
                val_5 = 丛丟丘专丅丑丗丌七.丑七不且上丗丁一世().丘丙三万东丗七丁丅();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._socialNameLabels, 丕丗丘丑丛与丑业丒:  val_5);
    }
    private void 丙丑丘业丕丗丗不丘()
    {
        var val_3;
        System.Action<UIButton> val_5;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = AccountsMenuItem.<>c.<>9__23_0;
        if(val_5 == null)
        {
                System.Action<UIButton> val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action<UIButton>(object:  AccountsMenuItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AccountsMenuItem.<>c::丌丅丁丝丑丂丁丘丕(UIButton 三丟东丕丄丄下下丑));
            AccountsMenuItem.<>c.<>9__23_0 = val_5;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UIButton>(丌丛丏业世丄丞三丌:  this._notSignedInButtons, 七丐丅专且专七三丆:  val_2);
    }
    private void 丙丞丝丁丄上上丏丁()
    {
        UnityEngine.GameObject val_29;
        var val_30;
        string val_31;
        UnityEngine.GameObject val_32;
        var val_33;
        val_29 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notLoggedNoIdBinding, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loggedIdCorrectlyBinded, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loggedIdMisbinded, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loggedInNotBinded, 丏业丟一东丂东丘丛:  false);
        if((上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == true) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下())) == false))
        {
            goto label_10;
        }
        
        val_30 = null;
        val_29 = this._notLoggedNoIdBinding;
        goto label_69;
        label_10:
        if((上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == false) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下())) == false))
        {
            goto label_20;
        }
        
        val_30 = null;
        val_29 = this._loggedInNotBinded;
        goto label_69;
        label_20:
        string val_7 = 上丞丑上丙丈丄丗丐.下丄丈不与世丐业专();
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != false)
        {
                if((System.String.op_Equality(a:  丅丛丟上丁丆上丛专.业丟不七丄且不东下(), b:  val_7)) == true)
        {
            goto label_28;
        }
        
        }
        
        if((上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != false) && ((System.String.op_Inequality(a:  丅丛丟上丁丆上丛专.业丟不七丄且不东下(), b:  val_7)) != false))
        {
                val_31 = 丅丛丟上丁丆上丛专.业丟不七丄且不东下();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_31)) != false)
        {
                if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() == null)
        {
            goto label_62;
        }
        
        }
        
        }
        
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == true)
        {
            goto label_54;
        }
        
        val_31 = 丅丛丟上丁丆上丛专.业丟不七丄且不东下();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_31)) == false)
        {
            goto label_54;
        }
        
        val_31 = 丅丛丟上丁丆上丛专.业丟不七丄且不东下();
        if((System.String.op_Equality(a:  val_31, b:  丛丟丘专丅丑丗丌七.丑七不且上丗丁一世().丈与上丕丆东丆丏丈())) == false)
        {
            goto label_54;
        }
        
        label_28:
        val_30 = null;
        val_29 = this._loggedIdCorrectlyBinded;
        goto label_69;
        label_54:
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == true)
        {
            goto label_62;
        }
        
        val_31 = 1152921505132351488;
        if((System.String.op_Inequality(a:  丅丛丟上丁丆上丛专.业丟不七丄且不东下(), b:  val_7)) == false)
        {
            goto label_62;
        }
        
        bool val_28 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下());
        val_32 = this._loggedIdMisbinded;
        val_33 = 1;
        goto label_67;
        label_62:
        val_30 = null;
        val_29 = this._loggedIdMisbinded;
        label_69:
        val_33 = 1;
        val_32 = val_29;
        label_67:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  true);
    }
    public void U_InfoClick()
    {
        var val_6;
        if(this.丟丕丞东丟丄丘世与 == 0)
        {
                val_6 = null;
            val_6 = null;
            this.丟丕丞东丟丄丘世与 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MigrationToNewProgress/AccountProgressInfo"), 丈东丘丏与丌东东下:  transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<ProgressInfoWindow>();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丟丕丞东丟丄丘世与, 丏业丟一东丂东丘丛:  true);
    }
    public void U_AlreadyBindedClick()
    {
        var val_5;
        if(this.万不业丞业丝丐不与 == 0)
        {
                val_5 = null;
            val_5 = null;
            this.万不业丞业丝丐不与 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MigrationToNewProgress/AccountProgressAlreadyBindedMessage"), 丈东丘丏与丌东东下:  transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.万不业丞业丝丐不与, 丏业丟一东丂东丘丛:  true);
    }
    public void U_UpdateBindingClick()
    {
        string val_29;
        var val_30;
        var val_31;
        var val_32;
        if(丅丛丟上丁丆上丛专.且一东三万丄且业丘() == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专(), b:  丅丛丟上丁丆上丛专.丂丕丟丆下丟三丑万())) != false)
        {
                return;
        }
        
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == false)
        {
            goto label_11;
        }
        
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != false)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下())) != false)
        {
                if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() != null)
        {
            goto label_22;
        }
        
        }
        
        }
        
        val_29 = 丅丛丟上丁丆上丛专.业丟不七丄且不东下();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_29)) == false)
        {
            goto label_29;
        }
        
        val_29 = 丅丛丟上丁丆上丛专.业丟不七丄且不东下();
        val_30 = System.String.op_Inequality(a:  val_29, b:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专());
        goto label_34;
        label_11:
        this.丛丗上丝业下不丈丟();
        上丞丑上丙丈丄丗丐.不丄一丌丝丞丘不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丛丝丘专业丁丑下丘()));
        丅丛丟上丁丆上丛专.世上丗丐丆丙丝丒三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丙丁丏丝丝且且丗丟()));
        上丞丑上丙丈丄丗丐.且丕丅丕丝丛丂与丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丛丝丘专业丁丑下丘()));
        丅丛丟上丁丆上丛专.上上丏丄业丗一丘丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丙丁丏丝丝且且丗丟()));
        return;
        label_29:
        val_30 = 0;
        label_34:
        if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() != null)
        {
                val_29 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万();
            val_31 = (~(val_29.丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()))) & 1;
        }
        else
        {
                val_31 = 0;
        }
        
        val_31 = (val_30 & 上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅()) & val_31;
        if(val_31 != false)
        {
                label_22:
            七专万下丄世丞丂且.且万万一丘世业且与(丙业与丙丗丝不丈东:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专());
            val_32 = null;
            val_32 = null;
            七专万下丄世丞丂且.丑七不且上丗丁一世().丛业丏且万专丛世丙(丈东丘丏与丌东东下:  MainMenuController.丄丞丁丈与业上丞丟 + 24.transform, 丘下丌丁丁丌丄丕丙:  true);
            return;
        }
        
        this.丛丛丆丐专丁丅丌与();
    }
    public void U_Authenticate()
    {
        this.丛丗上丝业下不丈丟();
    }
    private void 丛丗上丝业下不丈丟()
    {
        var val_4;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
            goto label_1;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_4;
        }
        
        val_4 = null;
        goto label_7;
        label_1:
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
            goto label_8;
        }
        
        val_4 = null;
        label_7:
        上丞丑上丙丈丄丗丐.丛丗上丝业下不丈丟();
        return;
        label_4:
        上丞丑上丙丈丄丗丐.丘丙丛东丁与丒七上();
        return;
        label_8:
        this.东丏世上丘业丛丏一();
    }
    private void 丛丛丆丐专丁丅丌与()
    {
        var val_6;
        if(this.专且不丂东丙三七七 == 0)
        {
                val_6 = null;
            val_6 = null;
            this.专且不丂东丙三七七 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MigrationToNewProgress/StartNewGame"), 丈东丘丏与丌东东下:  transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<StartNewGameWindow>();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.专且不丂东丙三七七, 丏业丟一东丂东丘丛:  true);
    }
    private void 丁丄一丕专丄丆专丝()
    {
        var val_6;
        if(this.丒丞丘上丞丗丕丛丆 == 0)
        {
                val_6 = null;
            val_6 = null;
            this.丒丞丘上丞丗丕丛丆 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MigrationToNewProgress/AccountAttention"), 丈东丘丏与丌东东下:  transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<UpdateIdBindingWindow>();
            val_5._accountsMenuItem = this;
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丒丞丘上丞丗丕丛丆, 丏业丟一东丂东丘丛:  true);
    }
    private void 东丏世上丘业丛丏一()
    {
        var val_5;
        if(this.丑丗专丅丙丅丈丆丘 == 0)
        {
                val_5 = null;
            val_5 = null;
            this.丑丗专丅丙丅丈丆丘 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "MigrationToNewProgress/AccountProgressWarning"), 丈东丘丏与丌东东下:  transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丑丗专丅丙丅丈丆丘, 丏业丟一东丂东丘丛:  true);
    }
    internal static string 与与丆丞世丒丐丁上()
    {
        var val_23;
        var val_27;
        var val_29;
        var val_30;
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                val_23 = 世丘业丐东与万不与.丑七不且上丗丁一世();
            if(val_23.世丘丙东不上不丘下() == false)
        {
                return (string)System.String.alignConst;
        }
        
            世丘业丐东与万不与 val_4 = 世丘业丐东与万不与.丑七不且上丗丁一世();
            if(val_4 != null)
        {
                return val_4.丂丑丂丝专上丘东丑();
        }
        
            return val_4.丂丑丂丝专上丘东丑();
        }
        
        if(UnityEngine.Social.localUser == null)
        {
            goto label_11;
        }
        
        val_23 = UnityEngine.Social.localUser;
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_23.authenticated == false)
        {
            goto label_11;
        }
        
        val_23 = UnityEngine.Social.localUser;
        var val_28 = 0;
        val_28 = val_28 + 1;
        if((System.String.IsNullOrEmpty(value:  val_23.userName)) == false)
        {
            goto label_17;
        }
        
        label_11:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
                return (string)System.String.alignConst;
        }
        
        val_23 = GameCircleSocial.Instance.localUser;
        var val_29 = 0;
        val_29 = val_29 + 1;
        goto label_28;
        label_17:
        val_27 = UnityEngine.Social.localUser;
        val_29 = null;
        var val_30 = 0;
        val_30 = 1152921504882016264;
        val_30 = val_30 + 1;
        return val_27.userName;
        label_28:
        if(val_23.authenticated == false)
        {
                return (string)System.String.alignConst;
        }
        
        val_23 = GameCircleSocial.Instance.localUser;
        var val_31 = 0;
        val_31 = val_31 + 1;
        if((System.String.IsNullOrEmpty(value:  val_23.userName)) != false)
        {
                return (string)System.String.alignConst;
        }
        
        val_27 = GameCircleSocial.Instance.localUser;
        val_29 = null;
        var val_32 = 0;
        val_30 = 1152921504882016264;
        val_32 = val_32 + 1;
        return val_27.userName;
    }
    private void 丛丝丘专业丁丑下丘()
    {
        上丞丑上丙丈丄丗丐.不丄一丌丝丞丘不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AccountsMenuItem::丛丝丘专业丁丑下丘()));
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丞丄丅丘且丑丕专七());
    }
    private System.Collections.IEnumerator 丞丄丅丘且丑丕专七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AccountsMenuItem.东丑七万三与丗丑丘();
    }
    private void 丙丁丏丝丝且且丗丟()
    {
        InfoWindowController.丟丂不丘丂下上与世(丏不丄丑丝丁丘万不:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7527"), arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  PlatformDependentLocalize.丄丗丅丙丗丑丘三丏())));
    }
    private void Update()
    {
        this.且世上丅丕丗三丘丆();
    }
    private void 且世上丅丕丗三丘丆()
    {
        var val_7;
        var val_8;
        if(丅丛丟上丁丆上丛专.且一东三万丄且业丘() != false)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_6;
        }
        
        }
        
        val_7 = 1;
        goto label_7;
        label_6:
        val_7 = System.String.op_Inequality(a:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专(), b:  丅丛丟上丁丆上丛专.丂丕丟丆下丟三丑万());
        label_7:
        val_8 = 0;
        goto label_12;
        label_22:
        long val_7 = 0;
        UIButton val_6 = this._buttonsWithHandlerUpdateBindingClick[val_7];
        val_7 = val_7 & val_6;
        if(val_7 == false)
        {
            goto label_17;
        }
        
        goto label_18;
        label_17:
        if((val_7 == true) || ((val_6 & 1) != 0))
        {
            goto label_20;
        }
        
        label_18:
        label_20:
        val_8 = 1;
        label_12:
        if(val_8 < this._buttonsWithHandlerUpdateBindingClick.Length)
        {
            goto label_22;
        }
    
    }
    public AccountsMenuItem()
    {
    
    }

}
