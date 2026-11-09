using UnityEngine;
internal class AuthSceneController : MonoBehaviour
{
    // Fields
    private static bool <丒与丟丒丈丝丛丟丄>k__BackingField;
    private static bool <丟丂丐丐丂丝专业丐>k__BackingField;
    private static AuthSceneController <不丁丄七丛不丆丁丕>k__BackingField;
    private static AuthSceneState <丒一七丙万业上且三>k__BackingField;
    private static bool <不东丒三丅下万丑丅>k__BackingField;
    private static bool <丁丝丅丟三丏丙丕业>k__BackingField;
    private static bool <丟丕丗丅丄丟上丂丈>k__BackingField;
    private static bool <专不下且专丛东且下>k__BackingField;
    private PGCompany.AuthorizationScene.AuthSceneLoginGui <丐丆上丄丌丕与丛业>k__BackingField;
    private static System.Action 丆丏专丘丈丗万万上;
    private static System.Action 丙与东丏丕丞丕丐东;
    private PGCompany.AuthorizationScene.AuthInterfaceController _authInterface;
    private System.Collections.Generic.Dictionary<string, object> 丛丘丞丅丝下三丗丟;
    private System.Collections.Generic.Dictionary<string, object> 丁丌且东丆七丄且丏;
    private System.Collections.Generic.HashSet<string> 丒丌丕丟业与一丏业;
    private System.Collections.Generic.HashSet<string> 丙丅丛一专丘东上丄;
    private float 丝丏东丟专业专丛丄;
    private const float 下下丁丁丑丝丐丒丒 = 3;
    private UnityEngine.Coroutine 丌东与丗丌七丙不丌;
    private Rilisoft.丛业丗不丅丑业丈丛 丄世世丂丘丌世丆丑;
    public Rilisoft.BankBannersHolder bannersHolder;
    private static System.Action 丏下丂丑丒上业丕丂;
    
    // Properties
    internal static bool 丝丁业与专与不丑丐 { get; set; }
    internal static bool 三下丛丕丙且丅丛三 { get; set; }
    internal static AuthSceneController 丆丕丝丒不丙且丐丗 { get; set; }
    internal static AuthSceneState 丙丟与丐三丐万万丆 { get; set; }
    internal PGCompany.AuthorizationScene.AuthInterfaceController 丑专一丝丘下上与上 { get; }
    internal static bool 丝丟不丏丑且丛丌一 { get; set; }
    internal static bool 丂丐丁与丈丅丟丄丑 { get; set; }
    internal static bool 丛丌丄丗东丞世丐且 { get; }
    private static bool 丂丙不丗丕丂且丕丟 { get; set; }
    private static bool 且丐上世且上丘丝一 { get; set; }
    internal PGCompany.AuthorizationScene.AuthSceneLoginGui 丕一丘丟丂且一丁业 { get; set; }
    
    // Methods
    internal static bool 丟丞与丅丒上世丙业()
    {
        return (bool)AuthSceneController.下下丁丁丑丝丐丒丒;
    }
    internal static void 万七丗与业丒且万不(bool 丙业与丙丗丝不丈东)
    {
        AuthSceneController.下下丁丁丑丝丐丒丒 = 丙业与丙丗丝不丈东;
    }
    internal static bool 业丕上丗丝与下东丕()
    {
        return (bool)AuthSceneController.<丟丂丐丐丂丝专业丐>k__BackingField;
    }
    internal static void 与丈下一丐丝丄世丐(bool 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<丟丂丐丐丂丝专业丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static AuthSceneController 丑七不且上丗丁一世()
    {
        return (AuthSceneController)AuthSceneController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(AuthSceneController 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static AuthSceneState 丄丙丂丝丄丌丗丂丅()
    {
        return (AuthSceneState)AuthSceneController.<丒一七丙万业上且三>k__BackingField;
    }
    internal static void 丌七丗东三丏东丅丕(AuthSceneState 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<丒一七丙万业上且三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.AuthorizationScene.AuthInterfaceController 丏丑丐丌丗三丆且专()
    {
        return (PGCompany.AuthorizationScene.AuthInterfaceController)this._authInterface;
    }
    internal static bool 一不丆丏与丐丏丈丄()
    {
        return (bool)AuthSceneController.<不东丒三丅下万丑丅>k__BackingField;
    }
    private static void 丏万丄不下丈丏三丘(bool 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<不东丒三丅下万丑丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丏丌丏丞丄与上丌丂()
    {
        return (bool)AuthSceneController.<丁丝丅丟三丏丙丕业>k__BackingField;
    }
    private static void 丕东丟丝下业业七上(bool 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<丁丝丅丟三丏丙丕业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 万丛七万万万世丈丏()
    {
        return (bool)((AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField) == false) ? 1 : 0;
    }
    private static bool 专东丝东业丒万且丌()
    {
        return (bool)AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField;
    }
    private static void 丁丒丘且下丟世丅七(bool 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private static bool 丌与丛下丐丑一东世()
    {
        return (bool)AuthSceneController.<专不下且专丛东且下>k__BackingField;
    }
    private static void 一丁丐丏丕万与丁七(bool 丙业与丙丗丝不丈东)
    {
        AuthSceneController.<专不下且专丛东且下>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.AuthorizationScene.AuthSceneLoginGui 上下一丁与丝丌丕与()
    {
        return (PGCompany.AuthorizationScene.AuthSceneLoginGui)this.<丐丆上丄丌丕与丛业>k__BackingField;
    }
    private void 不东上丈丑与且下丞(PGCompany.AuthorizationScene.AuthSceneLoginGui 丙业与丙丗丝不丈东)
    {
        this.<丐丆上丄丌丕与丛业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 下不丞丒丘丄丈世丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  AuthSceneController.丆丏专丘丈丗万万上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AuthSceneController.丆丏专丘丈丗万万上 != 1152921505130651672);
    
    }
    internal static void 万丅东丝七三丕丞丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  AuthSceneController.丆丏专丘丈丗万万上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AuthSceneController.丆丏专丘丈丗万万上 != 1152921505130651672);
    
    }
    internal static void 七东七不不丅下丞东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  AuthSceneController.丙与东丏丕丞丕丐东, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AuthSceneController.丙与东丏丕丞丕丐东 != 1152921505130651680);
    
    }
    internal static void 丛丌上丐丘不且丙七(System.Action 丙业与丙丗丝不丈东)
    {
        bool val_3;
        var val_4;
        val_3 = static_value_082C62E2;
        val_3 = true;
        do
        {
            val_4 = System.Delegate.Remove(source:  mem[-1152921504606336581], value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        }
        while((mem[-1152921504606336581]) != 1152921505130651680);
    
    }
    private void Awake()
    {
        AuthSceneController.<不丁丄七丛不丆丁丕>k__BackingField = this;
        Rilisoft.丛业丗不丅丑业丈丛 val_1 = new Rilisoft.丛业丗不丅丑业丈丛();
        this.丄世世丂丘丌世丆丑 = val_1;
        val_1.丅东万丄丑且丞丏七(丗丛丆丐下丈与万业:  0.76f, 丟丈与丟丞三上丛丕:  0.9f);
        if(AuthSceneController.丙与东丏丕丞丕丐东 != null)
        {
                AuthSceneController.丙与东丏丕丞丕丐东.Invoke();
        }
        
        if((AuthSceneController.<丟丂丐丐丂丝专业丐>k__BackingField) != false)
        {
                this.丞丞万三丌丙丗丄且();
        }
        
        this.丘丐业丘世丗专丙丐();
        AuthSceneController.<不东丒三丅下万丑丅>k__BackingField = false;
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::下丅东丏与丛与三丌()));
        业丞丝东丅丞丐丌专.专丁丂与丘丈丅不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::下业不专下丛万丘七()));
        if(OfflineModController.丂丁丌丘丗丅专专丛() != false)
        {
                this._authInterface.且东丈与与东业丗丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丕不丁丄丌丑丕七专()));
        }
        
        this._authInterface.丁七丈丂丌丕世万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::且与丆丗且丙丈业丛()));
        this._authInterface.丏丘东专世丛丝不不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丝世丞丞专与世丒下()));
        this._authInterface.丒且丒丏专业三丂七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::下且东丐丒三不丝丝()));
        ServerMessageBox.上东丙丌丒丏丒三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丕不丁丄丌丑丕七专()));
        丅丛丟上丁丆上丛专.与丟且与丛东业丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::七丘丗丄丆丆丐三丄()));
        丅丛丟上丁丆上丛专.与丟且与丛东业丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丒丏三三丏不业且上()));
        丅丛丟上丁丆上丛专.一丆丟丟丈下丌丕丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丙丁丝丒三丗丘不丘()));
        Progress.下丁下丂七丆丙七一.丞丂丏丕丝不丝不丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丑丐丟七丘与丑丛丞()));
        Progress.丑丗丄业丒三上上丁.丏丌世与丄丑东丗丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丈下丅丝丈世丑下丗()));
        Progress.丑丗丄业丒三上上丁.丄丘丛上万丁丕丆丒(丙业与丙丗丝不丈东:  new System.Action<Progress.丟丄丁业丞东丘丑丄, System.Int32>(object:  this, method:  System.Void AuthSceneController::丆七不丐不丗丛丒丟(Progress.丟丄丁业丞东丘丑丄 丁丂丕与丁丒丕丟丞, int 不丗三与丆丅丙且丞)));
        FriendsController.丁不业与东万丘丕三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丄丞丕七丏丛丆丐业()));
        Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丂东上且丂下丛不丐(丙业与丙丗丝不丈东:  new System.Action<丙丏丈上丞上专丅与>(object:  this, method:  System.Void AuthSceneController::丛丁世丒丙三七下丂(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 不下与丕与丛万下丞)));
        AuthSceneController.<丁丝丅丟三丏丙丕业>k__BackingField = true;
    }
    private void Start()
    {
        null = null;
        if(FpsManager.丈丙丈丌丒丕丞丁七 != false)
        {
                FpsManager.丆丛丗上丄下丁丟下();
        }
        
        ConnectionLostChecker.下丗万丆世丄丝不丕(丙业与丙丗丝不丈东:  下丟世丏三东万丘丏.丆丐不上三专丝丌不());
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.76f));
        this.丆丙丄丗且下业专丑();
        this.一世丂一七丅业丆七();
        this.丕丟三丛丛丏丂丗不(丏业丟一东丂东丘丛:  AuthSceneController.<丒一七丙万业上且三>k__BackingField);
    }
    private void 丕丟三丛丛丏丂丗不(AuthSceneState 丏业丟一东丂东丘丛)
    {
        bool val_1 = 与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏();
        if(val_1 != false)
        {
                val_1.丞丞万三丌丙丗丄且();
            this.七丅丑与丒业丛下丂();
            return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().HideServerMessageBox();
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丂下丆丌丗丕万万丑() != false)
        {
                this.下业不专下丛万丘七();
            return;
        }
        
        if(丏业丟一东丂东丘丛 == 2)
        {
            goto label_11;
        }
        
        if(丏业丟一东丂东丘丛 == 1)
        {
            goto label_12;
        }
        
        if(丏业丟一东丂东丘丛 != 0)
        {
                return;
        }
        
        if(AuthSceneController.下下丁丁丑丝丐丒丒 == 0)
        {
            goto label_15;
        }
        
        this.丅丌丆三丈丕丆丅丂();
        return;
        label_11:
        this.下丅东丏与丛与三丌();
        return;
        label_12:
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丘丑丗一丁丛丗丑丟());
        return;
        label_15:
        this.丝丟丕丏一不丛丄丟();
    }
    private void 一世丂一七丅业丆七()
    {
        AuthSceneState val_11;
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() == 1)
        {
                val_11 = 2;
        }
        else
        {
                if((业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 3) && (业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 4))
        {
                if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 6)
        {
                if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 2)
        {
            goto label_22;
        }
        
        }
        
        }
        
            val_11 = 1;
        }
        
        label_22:
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  val_11);
    }
    private void 丝丟丕丏一不丛丄丟()
    {
        if((AuthSceneController.<专不下且专丛东且下>k__BackingField) != false)
        {
                this._authInterface.丄丘丗丞丟丘丒丗业(世丁丙世丄一万丆三:  2);
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
            ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  false);
            ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  false);
            AuthSceneController.<专不下且专丛东且下>k__BackingField = false;
            return;
        }
        
        if(ConnectionLostChecker.且三世专下丂丏与下() != 1)
        {
                this.丅丌丆三丈丕丆丅丂();
            return;
        }
        
        this._authInterface.业万万丕丒且下一丑();
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  false);
        ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        AuthSceneController.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        null = null;
        AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField = true;
        this.丆丙丄丗且下业专丑();
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::下丅东丏与丛与三丌()));
        业丞丝东丅丞丐丌专.七丙三业且与七专不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::下业不专下丛万丘七()));
        this._authInterface.丘下东下万与丞丁丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丕不丁丄丌丑丕七专()));
        this._authInterface.丄丗丌丞丂且丒丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::且与丆丗且丙丈业丛()));
        this._authInterface.三上世丁丌丈丑一万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丝世丞丞专与世丒下()));
        this._authInterface.丑丙丟丁丂丙丁丛下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::下且东丐丒三不丝丝()));
        ServerMessageBox.且丝三丙东与与与丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丕不丁丄丌丑丕七专()));
        丅丛丟上丁丆上丛专.丐丞丅万专丌且世业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::七丘丗丄丆丆丐三丄()));
        丅丛丟上丁丆上丛专.丐丞丅万专丌且世业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丒丏三三丏不业且上()));
        丅丛丟上丁丆上丛专.丂丞三一三丐丄丗世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丙丁丝丒三丗丘不丘()));
        Progress.下丁下丂七丆丙七一.丈且丙丕丟专七丒丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丑丐丟七丘与丑丛丞()));
        Progress.丑丗丄业丒三上上丁.丟不七丏丅丌丈下上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丈下丅丝丈世丑下丗()));
        Progress.丑丗丄业丒三上上丁.丈专丙丄丐丟丛东丄(丙业与丙丗丝不丈东:  new System.Action<Progress.丟丄丁业丞东丘丑丄, System.Int32>(object:  this, method:  System.Void AuthSceneController::丆七不丐不丗丛丒丟(Progress.丟丄丁业丞东丘丑丄 丁丂丕与丁丒丕丟丞, int 不丗三与丆丅丙且丞)));
        FriendsController.丒业丟丛与丝丁丅丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AuthSceneController::丄丞丕七丏丛丆丐业()));
        Rilisoft.WebSocket.丛丗丟万丛一丝丅下.三丈丈世丌东世万专(丙业与丙丗丝不丈东:  new System.Action<丙丏丈上丞上专丅与>(object:  this, method:  System.Void AuthSceneController::丛丁世丒丙三七下丂(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 不下与丕与丛万下丞)));
    }
    private void 七丘丟丒丑与东丑一()
    {
        var val_15;
        var val_16;
        var val_18;
        var val_19;
        var val_20;
        val_15 = null;
        val_15 = null;
        if(FpsManager.丈丙丈丌丒丕丞丁七 != false)
        {
                FpsManager.丞丝下丄丆且丌丈丐();
        }
        
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  4);
        new 丒下丄与丏三世丘丝().丐丏丆丂七丞七丌七();
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_8;
        }
        
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ActivityIndicator.不丌世万丌丘丘丒上 + 80, 丏业丟一东丂东丘丛:  ((AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField) == false) ? 1 : 0);
        MainMenuController.丅上丏丈万丒丈丑东(丙业与丙丗丝不丈东:  true);
        val_16 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
        string val_6 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        goto label_19;
        label_8:
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ActivityIndicator.不丌世万丌丘丘丒上 + 80, 丏业丟一东丂东丘丛:  ((AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField) == false) ? 1 : 0);
        ActivityIndicator.丞丂一丝三丄专丆一(丝丘专世丏三丝下丐:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Switcher.丌三丟丈东丑七丑上(丑丅世丐丒丏丐三丅:  3)));
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
        val_18 = null;
        val_18 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = false;
        val_19 = null;
        val_19 = null;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_10 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        val_20 = null;
        val_20 = null;
        if((AuthSceneController.<>c.<>9__61_0) == null)
        {
            goto label_37;
        }
        
        label_48:
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  val_10.FindIndex(match:  AuthSceneController.<>c.<>9__61_0));
        TrainingController.丂世万业丌七丂万丁();
        val_16 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
        label_19:
        val_16.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丗丄丛丆七丁丗丗专());
        return;
        label_37:
        AuthSceneController.<>c.<>9__61_0 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  AuthSceneController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AuthSceneController.<>c::丝丆丕丂丕丌丐丞丛(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        if(val_10 != null)
        {
            goto label_48;
        }
        
        goto label_48;
    }
    private void 丕不丁丄丌丑丕七专()
    {
        var val_5;
        if(VersionBlocker.丟不丌三丙万业丘七() != false)
        {
                NewVersionBanner.下与丞三丅丛丄七丕(丅专与丒丈丗丒丘丌:  this._authInterface.UpdateBannerPoint, 丆丑丞丅不丕丐丙丂:  0);
            return;
        }
        
        与丂丏丛丞丞丒丟丄.丈丛业业丅丒丁丗世(丙业与丙丗丝不丈东:  true);
        val_5 = null;
        val_5 = null;
        SkinsController.丄丞丁丈与业上丞丟.丞丗丂东上且一丅丑();
        SkinsController.丙丘与万业丒丁丆丛();
        this._authInterface.且丙丗丙丅丑丕丞丞(丏业丟一东丂东丘丛:  4);
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ActivityIndicator.不丌世万丌丘丘丒上 + 80, 丏业丟一东丂东丘丛:  ((AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField) == false) ? 1 : 0);
        MainMenuController.丅上丏丈万丒丈丑东(丙业与丙丗丝不丈东:  true);
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
    }
    private void 且与丆丗且丙丈业丛()
    {
        if(VersionBlocker.丟不丌三丙万业丘七() != false)
        {
                NewVersionBanner.下与丞三丅丛丄七丕(丅专与丒丈丗丒丘丌:  this._authInterface.UpdateBannerPoint, 丆丑丞丅不丕丐丙丂:  0);
            return;
        }
        
        this.丅丌丆三丈丕丆丅丂();
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  true);
        ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  ((AuthSceneController.<丟丕丗丅丄丟上丂丈>k__BackingField) == false) ? 1 : 0);
    }
    private void 丝世丞丞专与世丒下()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "AfterBanScene", mode:  0);
    }
    private void 下且东丐丒三不丝丝()
    {
        FeedbackMenuController.上丌丂且世不丁丈丛(丕丒上丄丒业丕丕丐:  new System.Action(object:  this, method:  System.Void AuthSceneController::东丁一丈丄丅丕丏丄()));
    }
    private void 东丁一丈丄丅丕丏丄()
    {
        string val_54;
        System.Version val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).Version;
        System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_5 = val_3.AppendFormat(format:  "mailto:{0}", arg0:  FriendsController.丈丈且丗丑与丕丈丅());
        string val_6 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(val_3 != null)
        {
                System.Text.StringBuilder val_7 = val_3.AppendFormat(format:  "?subject=Feedback {0}", arg0:  val_6);
            System.Text.StringBuilder val_8 = val_3.AppendLine(value:  "&body=");
            System.Text.StringBuilder val_9 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_10 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_11 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_12 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_13 = val_3.Append(value:  "------------ DO NOT DELETE ------------");
        }
        else
        {
                System.Text.StringBuilder val_14 = val_3.AppendFormat(format:  "?subject=Feedback {0}", arg0:  val_6);
            System.Text.StringBuilder val_15 = val_3.AppendLine(value:  "&body=");
            System.Text.StringBuilder val_16 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_17 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_18 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_19 = val_3.AppendLine(value:  "");
            System.Text.StringBuilder val_20 = val_3.Append(value:  "------------ DO NOT DELETE ------------");
        }
        
        System.Text.StringBuilder val_21 = val_3.AppendLine(value:  "");
        System.DateTime val_22 = System.DateTime.UtcNow;
        System.Globalization.CultureInfo val_23 = System.Globalization.CultureInfo.InvariantCulture;
        if(val_3 != null)
        {
                System.Text.StringBuilder val_24 = val_3.AppendFormat(format:  "UTC Time: {0}", arg0:  val_22.dateData);
            System.Text.StringBuilder val_25 = val_3.AppendLine();
            System.Text.StringBuilder val_26 = val_3.AppendLine(value:  "Game: PixelGun3D");
            System.Text.StringBuilder val_27 = val_3.AppendFormat(format:  "Version: {0}", arg0:  val_2);
        }
        else
        {
                System.Text.StringBuilder val_28 = val_3.AppendFormat(format:  "UTC Time: {0}", arg0:  val_22.dateData);
            System.Text.StringBuilder val_29 = val_3.AppendLine();
            System.Text.StringBuilder val_30 = val_3.AppendLine(value:  "Game: PixelGun3D");
            System.Text.StringBuilder val_31 = val_3.AppendFormat(format:  "Version: {0}", arg0:  val_2);
        }
        
        System.Text.StringBuilder val_32 = val_3.AppendLine(value:  "");
        string val_33 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(val_3 != null)
        {
                System.Text.StringBuilder val_34 = val_3.AppendFormat(format:  "PlayerID: {0}", arg0:  val_33);
            System.Text.StringBuilder val_35 = val_3.AppendLine(value:  "");
        }
        else
        {
                System.Text.StringBuilder val_36 = val_3.AppendFormat(format:  "PlayerID: {0}", arg0:  val_33);
            System.Text.StringBuilder val_37 = val_3.AppendLine(value:  "");
        }
        
        System.Text.StringBuilder val_38 = val_3.AppendLine(value:  "Category: Feedback");
        UnityEngine.DeviceType val_39 = UnityEngine.SystemInfo.deviceType;
        string val_40 = UnityEngine.SystemInfo.deviceModel;
        if(val_3 != null)
        {
                System.Text.StringBuilder val_41 = val_3.AppendFormat(format:  "Device Type: {0} {1}", arg0:  val_39, arg1:  val_40);
        }
        else
        {
                System.Text.StringBuilder val_42 = val_3.AppendFormat(format:  "Device Type: {0} {1}", arg0:  val_39, arg1:  val_40);
        }
        
        System.Text.StringBuilder val_43 = val_3.AppendLine(value:  "");
        string val_44 = UnityEngine.SystemInfo.operatingSystem;
        if(val_3 != null)
        {
                System.Text.StringBuilder val_45 = val_3.AppendFormat(format:  "OS Version: {0}", arg0:  val_44);
            System.Text.StringBuilder val_46 = val_3.AppendLine(value:  "");
            val_54 = "------------------------";
            System.Text.StringBuilder val_47 = val_3.Append(value:  val_54);
        }
        else
        {
                System.Text.StringBuilder val_48 = val_3.AppendFormat(format:  "OS Version: {0}", arg0:  val_44);
            System.Text.StringBuilder val_49 = val_3.AppendLine(value:  "");
            val_54 = "------------------------";
            System.Text.StringBuilder val_50 = val_3.Append(value:  val_54);
        }
        
        UnityEngine.Application.OpenURL(url:  val_3.Replace(oldValue:  " ", newValue:  "%20").Replace(oldValue:  System.Environment.NewLine, newValue:  "%0D%0A"));
    }
    private void 三下丝丛丗世丐丅丟()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 6)
        {
                return;
        }
        
        丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        if(new 丒下丄与丏三世丘丝().丝三世且七丆不丈下() != false)
        {
                UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丏丁万丒丂丄丘丏上(不丁一丁丁丛丘丌丅:  丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丏丘丂不一与上丆且().丞丈业东专丅丆与七()));
            return;
        }
        
        this.下丈丂丑业丞丝丕丗();
    }
    private void 丟丙丛丄上丂丘丆业()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 6)
        {
                return;
        }
        
        丙与不与七丌丟上东 val_2 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丏丘丂不一与上丆且();
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  val_2.丞丈业东专丅丆与七());
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  val_2.丂丛专三丏专丗丅世());
        if(val_2 != null)
        {
                丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  val_2.丞丈业东专丅丆与七());
            System.Threading.Tasks.Task val_9 = 丅丛丟上丁丆上丛专.业丐万丅一丘丕丂且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        else
        {
                丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  0.丞丈业东专丅丆与七());
            System.Threading.Tasks.Task val_12 = 丅丛丟上丁丆上丛专.业丐万丅一丘丕丂且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "send-1026-inhouse-"("send-1026-inhouse-") + val_2.丞丈业东专丅丆与七(), 下下丏一丙不丘丌丞:  专丈专业丆且且业下.丈不丄丛丛丘东丁丙(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 三丛丆丐丌丕丒与丟()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 6)
        {
                return;
        }
        
        丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        this.七丅丑与丒业丛下丂();
    }
    private void 与丞丒不丞丘丛丝世()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 6)
        {
                return;
        }
        
        丙与不与七丌丟上东 val_2 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丏丘丂不一与上丆且();
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  val_2.丞丈业东专丅丆与七());
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  val_2.丂丛专三丏专丗丅世());
        if(val_2 != null)
        {
                丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  val_2.丞丈业东专丅丆与七());
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        else
        {
                丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  0.丞丈业东专丅丆与七());
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "send-1026-inhouse-"("send-1026-inhouse-") + val_2.丞丈业东专丅丆与七(), 下下丏一丙不丘丌丞:  专丈专业丆且且业下.丈不丄丛丛丘东丁丙(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丕丌丈丂丝丝七业下(System.Collections.Generic.Dictionary<string, object> 上丕丈丞丌丘丅不与, bool 丗丙且世且丞丆丙下, string 三专一丝丝三丆丑上, System.Collections.Generic.HashSet<string> 一万东三丏丘丄丗丈)
    {
        var val_8;
        var val_27;
        var val_28;
        string val_30;
        AuthSceneController val_31;
        bool val_32;
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  13);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.87f));
        Dictionary.Enumerator<TKey, TValue> val_5 = Progress.七七世万专丕丁上业.专丛丁业世上丙世世(丛丙与一与且万一三:  new System.Collections.Generic.HashSet<System.Int32>(collection:  System.Linq.Enumerable.Range(start:  1, count:  24))).GetEnumerator();
        label_16:
        if((1561892112 & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        if(一万东三丏丘丄丗丈 != null)
        {
                if((一万东三丏丘丄丗丈.Contains(item:  val_9._value._obj.丐丏七丌丕丗业且上())) == true)
        {
            goto label_16;
        }
        
        }
        
        if((上丕丈丞丌丘丅不与.ContainsKey(key:  val_9._value._obj.丐丏七丌丕丗业且上().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture))) == true)
        {
            goto label_16;
        }
        
        上丕丈丞丌丘丅不与.set_Item(key:  val_9._value._obj.丐丏七丌丕丗业且上(), value:  val_9._value._obj);
        goto label_16;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_27 = 1152921505369411584;
        val_28 = 0;
        goto label_31;
        label_42:
        int val_27 = 丞东丑专丛丆丄丝世.丞丏丞丗不丐与一丌<Progress.专丘七丑一世不专丕>()[0];
        if(val_27 >= 25)
        {
                if((上丕丈丞丌丘丅不与.ContainsKey(key:  val_27.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture))) != false)
        {
                bool val_23 = 上丕丈丞丌丘丅不与.Remove(key:  val_27.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
        }
        
        }
        
        val_28 = 1;
        label_31:
        if(val_28 < val_17.Length)
        {
            goto label_42;
        }
        
        val_30 = 三专一丝丝三丆丑上;
        val_31 = this;
        val_32 = 丗丙且世且丞丆丙下;
        上丕丈丞丌丘丅不与.set_Item(key:  Progress.七七世万专丕丁上业.世丙丛丙丐丕丙东三, value:  Progress.七七世万专丕丁上业.丟丞丌专丏七下丘丘());
        this.丌七丄丛东不丞业丕<Progress.丘丟丆丝丁丏丄专一>(万不且且丛丆东丒业:  new Progress.三丕丕业丗七东专丗(丑七丏专丗丛丟专世:  null, 丅丞东丄万一七一丛:  null));
    }
    private void 丑专丐丕专丄丐业东()
    {
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  13);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.89f));
        this.丁丟丒丞丝丌丛丙丐<System.Boolean>(万不且且丛丆东丒业:  Progress.万丄丑丆上丁丂且东.丑七不且上丗丁一世().下一丆上丆丂丞丑上());
    }
    private void 下丅东丏与丛与三丌()
    {
        this.丌东与丗丌七丙不丌 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.东七世丏丈丅丑丁丈());
    }
    private System.Collections.IEnumerator 东七世丏丈丅丑丁丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.丁下丘万七且业丟丂();
    }
    private System.Collections.IEnumerator 丏丂丂七丆丒丅专丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.业且丘丆东下丅丄不();
    }
    private void 上不业丝丙七上丈丘()
    {
        if(new 丒下丄与丏三世丘丝().丝三世且七丆不丈下() != true)
        {
                if((PGCompany.三丙丅丅七丘丒丗丂.丟不下下且业丛丄丏(丞丅上丏丂且下丅与:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_5;
        }
        
        }
        
        this.丗丗与丙丛丛七丅丅();
        return;
        label_5:
        this.七丅丑与丒业丛下丂();
    }
    private void 丈世丌且丌丅丄一且()
    {
        if(new 丒下丄与丏三世丘丝().丝三世且七丆不丈下() == false)
        {
            goto label_2;
        }
        
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == true)
        {
            goto label_5;
        }
        
        this.七与丆丄丗三且不专();
        return;
        label_2:
        if(上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() == false)
        {
            goto label_8;
        }
        
        if(丅丛丟上丁丆上丛专.丙七与丞丈丑下业丙() == true)
        {
            goto label_11;
        }
        
        label_5:
        this.丈丑业万不一丒丘专(业丕丄专与与上丌业:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专());
        return;
        label_8:
        丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  System.String.alignConst);
        label_11:
        this.下丈丂丑业丞丝丕丗();
    }
    private void 丈丑业万不一丒丘专(string 业丕丄专与与上丌业)
    {
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  5);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.82f));
        int val_3 = 丅丛丟上丁丆上丛专.世专丑七丈丕与上世(业丕丄专与与上丌业:  业丕丄专与与上丌业, 丑与丙丒且一业万丈:  AccountsMenuItem.与与丆丞世丒丐丁上(), 丞世丌丗世丑业业与:  true);
        七专万下丄世丞丂且.且万万一丘世业且与(丙业与丙丗丝不丈东:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专());
    }
    private void 七与丆丄丗三且不专()
    {
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  5);
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.81f));
        丅丛丟上丁丆上丛专.丟丝丞丁万三丘丄丒();
    }
    private void 丙丁丝丒三丗丘不丘()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 5)
        {
                return;
        }
        
        if(new 丒下丄与丏三世丘丝().丝三世且七丆不丈下() == false)
        {
            goto label_4;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下())) == false)
        {
            goto label_9;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = Progress.七七世万专丕丁上业.七丑丂丛丛丏丒丄丁();
        this.丛丘丞丅丝下三丗丟 = val_5;
        this.丕丌丈丂丝丝七业下(上丕丈丞丌丘丅不与:  val_5, 丗丙且世且丞丆丙下:  false, 三专一丝丝三丆丑上:  专丈专业丆且且业下.丆七丙丛上丑丒不丅(), 一万东三丏丘丄丗丈:  0);
        return;
        label_4:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "Invalid state. Should not be there.");
        return;
        label_9:
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.丏丁万丒丂丄丘丏上(不丁一丁丁丛丘丌丅:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()));
    }
    private void 七丘丗丄丆丆丐三丄()
    {
        string val_44;
        System.Action val_46;
        ProgressChoise val_47;
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 5)
        {
                return;
        }
        
        丒下丄与丏三世丘丝 val_1 = new 丒下丄与丏三世丘丝();
        if(val_1.丝三世且七丆不丈下() == false)
        {
            goto label_4;
        }
        
        if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() == null)
        {
            goto label_7;
        }
        
        if(val_1.一且丅丏上丕丞丁丂() == false)
        {
            goto label_9;
        }
        
        val_44 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  val_44)) == false)
        {
            goto label_13;
        }
        
        System.Collections.IEnumerator val_9 = this.丏丁万丒丂丄丘丏上(不丁一丁丁丛丘丌丅:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        goto label_32;
        label_4:
        if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() != null)
        {
                if((丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_21;
        }
        
        }
        
        this.下丈丂丑业丞丝丕丗();
        丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        return;
        label_7:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = Progress.七七世万专丕丁上业.七丑丂丛丛丏丒丄丁();
        this.丛丘丞丅丝下三丗丟 = val_15;
        this.丕丌丈丂丝丝七业下(上丕丈丞丌丘丅不与:  val_15, 丗丙且世且丞丆丙下:  false, 三专一丝丝三丆丑上:  专丈专业丆且且业下.丆七丙丛上丑丒不丅(), 一万东三丏丘丄丗丈:  0);
        return;
        label_9:
        if(val_1.且丙丞丘丌下丐丟丈() == false)
        {
            goto label_27;
        }
        
        val_44 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  val_44)) == false)
        {
            goto label_31;
        }
        
        System.Collections.IEnumerator val_21 = this.与丗丙上丅三且不丈();
        goto label_32;
        label_21:
        System.Action val_22 = null;
        val_46 = val_22;
        val_22 = new System.Action(object:  this, method:  System.Void AuthSceneController::三下丝丛丗世丐丅丟());
        System.Action val_23 = null;
        val_44 = val_23;
        val_23 = new System.Action(object:  this, method:  System.Void AuthSceneController::丟丙丛丄上丂丘丆业());
        val_47 = 3;
        goto label_33;
        label_13:
        System.Action val_24 = null;
        val_46 = val_24;
        val_24 = new System.Action(object:  this, method:  System.Void AuthSceneController::三下丝丛丗世丐丅丟());
        System.Action val_25 = null;
        val_44 = val_25;
        val_25 = new System.Action(object:  this, method:  System.Void AuthSceneController::丟丙丛丄上丂丘丆业());
        val_47 = 1;
        label_33:
        label_32:
        UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  this.丟万丄丐丗丝丄上世(丆且丄丁一丆丗且丅:  val_47, 丁万丂专丞世丈三丅:  val_24, 丑丈丈丝丘万七一上:  val_25));
        return;
        label_27:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "Invalid state. Should not be there.");
        return;
        label_31:
        丙与不与七丌丟上东 val_30 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丏丘丂不一与上丆且();
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  val_30.丞丈业东专丅丆与七());
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  val_30.丂丛专三丏专丗丅世());
        if(val_30 != null)
        {
                丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  val_30.丞丈业东专丅丆与七());
            System.Threading.Tasks.Task val_37 = 丅丛丟上丁丆上丛专.业丐万丅一丘丕丂且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        else
        {
                丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  0.丞丈业东专丅丆与七());
            System.Threading.Tasks.Task val_40 = 丅丛丟上丁丆上丛专.业丐万丅一丘丕丂且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "send-1026-inhouse-"("send-1026-inhouse-") + val_30.丞丈业东专丅丆与七(), 下下丏一丙不丘丌丞:  专丈专业丆且且业下.丈不丄丛丛丘东丁丙(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丒丏三三丏不业且上()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 16)
        {
                return;
        }
        
        if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() != null)
        {
                if((丅丛丟上丁丆上丛专.下丂且丕与世丄丝万().丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_9;
        }
        
        }
        
        this.七丅丑与丒业丛下丂();
        return;
        label_9:
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丟万丄丐丗丝丄上世(丆且丄丁一丆丗且丅:  3, 丁万丂专丞世丈三丅:  new System.Action(object:  this, method:  System.Void AuthSceneController::三丛丆丐丌丕丒与丟()), 丑丈丈丝丘万七一上:  new System.Action(object:  this, method:  System.Void AuthSceneController::与丞丒不丞丘丛丝世())));
    }
    private void 丑丐丟七丘与丑丛丞()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 8)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.与丗丙上丅三且不丈());
    }
    private void 丈下丅丝丈世丑下丗()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丒业专丒丒丘丌丏且());
    }
    private System.Collections.IEnumerator 丒业专丒丒丘丌丏且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.七丈丅丗丕丈丄丛世();
    }
    private void 丆七不丐不丗丛丒丟(Progress.丟丄丁业丞东丘丑丄 丁丂丕与丁丒丕丟丞, int 不丗三与丆丅丙且丞)
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 9)
        {
                return;
        }
        
        this.丒丌丕丟业与一丏业 = 0;
        if(丁丂丕与丁丒丕丟丞 == 2)
        {
            goto label_3;
        }
        
        if(丁丂丕与丁丒丕丟丞 != 1)
        {
            goto label_4;
        }
        
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  10);
        NewVersionBanner.专丘丕一丏一三丆东(丙业与丙丗丝不丈东:  true);
        NewVersionBanner.下与丞三丅丛丄七丕(丅专与丒丈丗丒丘丌:  this._authInterface.UpdateBannerPoint, 丆丑丞丅不丕丐丙丂:  0);
        return;
        label_3:
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  4);
        return;
        label_4:
        this.丗丗与丙丛丛七丅丅();
    }
    private System.Collections.IEnumerator 专专丞丁丁下丈专专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.丅丌丝丅丑不上丘不();
    }
    private bool 丟七丏不七丘丅三业()
    {
        PGCompany.AuthorizationScene.AuthInterfaceController val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = this;
        val_6 = null;
        if(VersionBlocker.丟不丌三丙万业丘七() == false)
        {
            goto label_3;
        }
        
        NewVersionBanner.专丘丕一丏一三丆东(丙业与丙丗丝不丈东:  true);
        val_5 = this._authInterface;
        label_22:
        NewVersionBanner.下与丞三丅丛丄七丕(丅专与丒丈丗丒丘丌:  this._authInterface.UpdateBannerPoint, 丆丑丞丅不丕丐丙丂:  0);
        val_7 = 1;
        return (bool)val_7;
        label_3:
        val_6 = null;
        if(((NewVersionBanner.丘丌丌丙万世丌与丆 == false) || (UpdatesChecker.且丕丑万丂丘且丄丂() == false)) || (NewVersionBanner.世东丙三丗丐丌专丛() == false))
        {
            goto label_16;
        }
        
        VersionBlocker.丞丙丙丟不丈东丅专();
        val_8 = null;
        val_8 = null;
        NewVersionBanner.丑丏丆一丅七业世丙 = true;
        System.Action val_4 = new System.Action(object:  this, method:  System.Void AuthSceneController::七丅丑与丒业丛下丂());
        goto label_22;
        label_16:
        val_7 = 0;
        return (bool)val_7;
    }
    private System.Collections.IEnumerator 与丗丙上丅三且不丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.丙丟与七丁三丞丈丈();
    }
    private void 丐东丆不一丂一丐东()
    {
        if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 13)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.专专丞丁丁下丈专专());
    }
    private System.Collections.IEnumerator 丏丆丆世丌丐丘丈丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.万丙一丝丌丑且一丅();
    }
    private void 七丅丑与丒业丛下丂()
    {
        var val_19;
        Progress.世上丌丈下业上丗丐.丁业丘丕丂且丑且万();
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  10);
        if(this.丟七丏不七丘丅三业() == true)
        {
                return;
        }
        
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  3);
        与丂丏丛丞丞丒丟丄.丈丛业业丅丒丁丗世(丙业与丙丗丝不丈东:  false);
        AuthSceneController.<不东丒三丅下万丑丅>k__BackingField = true;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  18);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丙丕业丒丆丈一丛与();
        if(AuthSceneController.丆丏专丘丈丗万万上 != null)
        {
                AuthSceneController.丆丏专丘丈丗万万上.Invoke();
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世().东上丙丙丌丑丆丘丗();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三丅丂三专七万专万();
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  this.丄世世丂丘丌世丆丑.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  0.9f));
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  2, 丙业与丙丗丝不丈东:  1);
        上丆与下丌丅丅丈丙 val_12 = 丅丛丟上丁丆上丛专.不七不丙丏上与三一();
        if(val_12 != null)
        {
                var val_16 = (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count > 1) ? 1 : 0;
        }
        else
        {
                val_19 = 0;
        }
        
        val_19 = val_19 & ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) ^ 1);
        if(val_19 != false)
        {
                val_12.丟一业丙下不丙三丑();
        }
        
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.丏丆丆世丌丐丘丈丑());
    }
    private void 丟一业丙下不丙三丑()
    {
        AuthSceneController.丑丒世丛世丗与东丆();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  2, 丙业与丙丗丝不丈东:  1);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  17);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  18);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  19);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  20);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  21);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  22);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  23);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  24);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  25);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  49, 丙业与丙丗丝不丈东:  true);
        AuthSceneController.丂丟丕世丁万丗七丈();
    }
    private static void 丑丒世丛世丗与东丆()
    {
        PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().东丏丗世专丅丂丐丁();
    }
    private static void 丂丟丕世丁万丗七丈()
    {
        七丌丞万七万丁丐丙.丈丌万万丌一丛与业();
        丆丟七丌丞东丆丕丌.丄东世丌专下丈丑丙(丒东业不丐丑丕丄丆:  "Armor_Army_1", 丙丑丕丂下丏一丁专:  7, 丆万丐丗丅丘丆丁丌:  false);
    }
    public static void add_OnStartAuthorization(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  AuthSceneController.丏下丂丑丒上业丕丂, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AuthSceneController.丏下丂丑丒上业丕丂 != 1152921505130651688);
    
    }
    public static void remove_OnStartAuthorization(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  AuthSceneController.丏下丂丑丒上业丕丂, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AuthSceneController.丏下丂丑丒上业丕丂 != 1152921505130651688);
    
    }
    private void 丅丌丆三丈丕丆丅丂()
    {
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  1);
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().专丂丙丘世万下三且();
        if(AuthSceneController.丏下丂丑丒上业丕丂 != null)
        {
                AuthSceneController.丏下丂丑丒上业丕丂.Invoke();
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丘丑丗一丁丛丗丑丟());
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        var val_1;
        var val_2;
        val_1 = 丁与丟万丄丒丗专丌;
        if(val_1 == true)
        {
                return;
        }
        
        val_1 = 1152921505087569920;
        val_2 = null;
        val_2 = null;
        NewVersionBanner.丘丌丌丙万世丌与丆 = true;
    }
    private void Update()
    {
        Rilisoft.丛业丗不丅丑业丈丛 val_13;
        float val_14;
        if(三丅丙三丟与丗丞一.丑七不且上丗丁一世().丘丛丏丕丕丏东世万() != false)
        {
                if((AuthSceneController.<丒一七丙万业上且三>k__BackingField) != 15)
        {
            goto label_4;
        }
        
        }
        
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() == 3)
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  8);
            val_13 = this.丄世世丂丘丌世丆丑;
            val_14 = 0.76f;
        }
        else
        {
                BestHTTP.SocketIO.SocketManager val_6 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七();
            if((val_6 != null) && (val_6.State == 2))
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  9);
            val_13 = this.丄世世丂丘丌世丆丑;
            val_14 = 0.77f;
        }
        else
        {
                if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 4)
        {
                if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 6)
        {
                return;
        }
        
        }
        
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  10);
            val_13 = this.丄世世丂丘丌世丆丑;
            val_14 = 0.78f;
        }
        
        }
        
        ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  val_13.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  val_14));
        return;
        label_4:
        this.丗丗与丙丛丛七丅丅();
    }
    private void 丗丗与丙丛丛七丅丅()
    {
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  13);
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  15);
        ConnectionLostChecker.下丗万丆世丄丝不丕(丙业与丙丗丝不丈东:  false);
        this.丞丞万三丌丙丗丄且();
        InfoWindowController.丁丂丑下世丗丄上上(丁丅丈丌丟世丗丗丟:  4);
    }
    private void 丛业丏且万专丛世丙(ProgressChoise 丆且丄丁一丆丗且丅, System.Action 丁万丂专丞世丈三丅, System.Action 丑丈丈丝丘万七一上)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丟万丄丐丗丝丄上世(丆且丄丁一丆丗且丅:  丆且丄丁一丆丗且丅, 丁万丂专丞世丈三丅:  丁万丂专丞世丈三丅, 丑丈丈丝丘万七一上:  丑丈丈丝丘万七一上));
    }
    private System.Collections.IEnumerator 丟万丄丐丗丝丄上世(ProgressChoise 丆且丄丁一丆丗且丅, System.Action 丁万丂专丞世丈三丅, System.Action 丑丈丈丝丘万七一上)
    {
        AuthSceneController.七丝丙丅丂丏丗丁专 val_1 = new AuthSceneController.七丝丙丅丂丏丗丁专();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丆且丄丁一丆丗且丅 = 丆且丄丁一丆丗且丅;
            .丝且与丝丒丟万丁专 = this;
            .丁万丂专丞世丈三丅 = 丁万丂专丞世丈三丅;
        }
        else
        {
                mem[40] = this;
            mem[32] = 丆且丄丁一丆丗且丅;
            mem[48] = 丁万丂专丞世丈三丅;
        }
        
        .丑丈丈丝丘万七一上 = 丑丈丈丝丘万七一上;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 业三世丄一世丛丆业(string 不丁一丁丁丛丘丌丅)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丏丁万丒丂丄丘丏上(不丁一丁丁丛丘丌丅:  不丁一丁丁丛丘丌丅));
    }
    private System.Collections.IEnumerator 丏丁万丒丂丄丘丏上(string 不丁一丁丁丛丘丌丅)
    {
        AuthSceneController.一丗不丅七丏丝丘且 val_1 = new AuthSceneController.一丗不丅七丏丝丘且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .不丁一丁丁丛丘丌丅 = 不丁一丁丁丛丘丌丅;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丛丝万不丟丗丏丌丛(string 不丁一丁丁丛丘丌丅)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘不丏丘丛丝东丘丁(不丁一丁丁丛丘丌丅:  不丁一丁丁丛丘丌丅));
    }
    private System.Collections.IEnumerator 丘不丏丘丛丝东丘丁(string 不丁一丁丁丛丘丌丅)
    {
        AuthSceneController.丟丁丈丈丑万专丅业 val_1 = new AuthSceneController.丟丁丈丈丑万专丅业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .不丁一丁丁丛丘丌丅 = 不丁一丁丁丛丘丌丅;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 下丈丂丑业丞丝丕丗()
    {
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  8);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈东丑丈丒三万三丆());
    }
    private System.Collections.IEnumerator 丈东丑丈丒三万三丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.一丟丘丈丒丁一丛丘();
    }
    private void 丙且三丂丟丙七且东<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业)
    {
        if(this != null)
        {
                this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  7);
        }
        else
        {
                this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  7);
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
    }
    private System.Collections.IEnumerator 丗且丁丝丘专丙上与<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业)
    {
        if((__RuntimeMethodHiddenParam + 48) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[40] = this;
        }
        
        mem2[0] = 万不且且丛丆东丒业;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    private void 丞丂七业不丏丅丑业<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业)
    {
        if(this != null)
        {
                this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  7);
        }
        else
        {
                this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  7);
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
    }
    private System.Collections.IEnumerator 丙丗不丟丐丘丁上丕<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业)
    {
        if((__RuntimeMethodHiddenParam + 48) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[40] = this;
        }
        
        mem2[0] = 万不且且丛丆东丒业;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    private void 一不丅丂与三下丟丅<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业, System.Action 丁万丂专丞世丈三丅, System.Action 丑丈丈丝丘万七一上)
    {
        if(this != null)
        {
                this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  6);
        }
        else
        {
                this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  6);
        }
        
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
    }
    private System.Collections.IEnumerator 丄丗丗丑世三专丅一<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业, System.Action 丁万丂专丞世丈三丅, System.Action 丑丈丈丝丘万七一上)
    {
        if((__RuntimeMethodHiddenParam + 48) != 0)
        {
                mem2[0] = 万不且且丛丆东丒业;
            mem2[0] = 丁万丂专丞世丈三丅;
        }
        else
        {
                mem[32] = 万不且且丛丆东丒业;
            mem[40] = 丁万丂专丞世丈三丅;
        }
        
        mem2[0] = 丑丈丈丝丘万七一上;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    private void 丌七丄丛东不丞业丕<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
    }
    private System.Collections.IEnumerator 世丁东七三丘丌不丈<T>(System.Threading.Tasks.Task<T> 东且丘且丟万丘丛丅)
    {
        if((__RuntimeMethodHiddenParam + 48) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[40] = this;
        }
        
        mem2[0] = 东且丘且丟万丘丛丅;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    private void 丁丟丒丞丝丌丛丙丐<T>(System.Threading.Tasks.Task<T> 万不且且丛丆东丒业)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
    }
    private System.Collections.IEnumerator 三丑下丕且丙丗丕七<T>(System.Threading.Tasks.Task<T> 东且丘且丟万丘丛丅)
    {
        if((__RuntimeMethodHiddenParam + 48) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[40] = this;
        }
        
        mem2[0] = 东且丘且丟万丘丛丅;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    private System.Collections.IEnumerator 丁上丆丏丝丌不七丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new AuthSceneController.万不丟丄丈丞丈世七();
    }
    private System.Collections.IEnumerator 万丏专一且三丅不丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new AuthSceneController.万丕丗丈丞丆业下丘();
    }
    private void 丘丐业丘世丗专丙丐()
    {
        Progress.下丁下丂七丆丙七一 val_1 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        Progress.万丄丑丆上丁丂且东 val_2 = Progress.万丄丑丆上丁丂且东.丑七不且上丗丁一世();
        丅丂丌丗丈七业七丕 val_3 = 丅丂丌丗丈七业七丕.丑七不且上丗丁一世();
        System.Nullable<System.Boolean> val_4 = Progress.七上上丟丗丏一不与.丛丑丅上且业世不丆();
        bool val_6 = UnityEngine.Object.op_Equality(x:  Rilisoft.Singleton<QuietAuthorization>.Instance, y:  0);
        PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.东丝七业丄丑丒世七();
    }
    private void 丆丙丄丗且下业专丑()
    {
        this.丛丘丞丅丝下三丗丟 = 0;
        this.丁丌且东丆七丄且丏 = 0;
        if(this.丌东与丗丌七丙不丌 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丌东与丗丌七丙不丌);
            this.丌东与丗丌七丙不丌 = 0;
        }
        
        this.StopAllCoroutines();
    }
    private void 丐专丂世丌丙丙专一(AuthSceneState 丏业丟一东丂东丘丛)
    {
        AuthSceneController.<丒一七丙万业上且三>k__BackingField = 丏业丟一东丂东丘丛;
        null = null;
        this._authInterface.且丙丗丙丅丑丕丞丞(丏业丟一东丂东丘丛:  AuthSceneController.<丒一七丙万业上且三>k__BackingField);
    }
    private void 丄丞丕七丏丛丆丐业()
    {
        丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
    }
    private void 一丄不丌丌丛丐与下()
    {
        this.丞丞万三丌丙丗丄且();
        this.七丅丑与丒业丛下丂();
    }
    private void 下业不专下丛万丘七()
    {
        this.丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  11);
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丘丛丈上丄一七一丄();
        this._authInterface.世专丙世三上业丏丑(丘丐且丅与丑丛丒丄:  1569775120);
    }
    internal void 丁三业丆丗丂丘丌丒()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘丑丗一丁丛丗丑丟());
    }
    private System.Collections.IEnumerator 丘丑丗一丁丛丗丑丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AuthSceneController.丆上七业专业丛下丝();
    }
    private void 丞丞万三丌丙丗丄且()
    {
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().不一丁丙丘不与丟丛();
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下丝丛丆丝且丁丞丁(丙业与丙丗丝不丈东:  System.String.alignConst);
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丗丟万丂丘丈专丄丂();
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) < 2)
        {
                return;
        }
        
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  System.String.alignConst);
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  System.String.alignConst);
    }
    private void 丛丁世丒丙三七下丂(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与 不下与丕与丛万下丞)
    {
        this.丞丞万三丌丙丗丄且();
        AuthSceneController.<专不下且专丛东且下>k__BackingField = true;
    }
    public AuthSceneController()
    {
    
    }
    private void 丑与七丞丕业丏万三()
    {
        var val_5;
        System.DateTime val_1 = System.DateTime.UtcNow;
        val_5 = null;
        val_5 = null;
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)BalanceController.丏丄一丐东丝丁丟丑);
        System.DateTime val_3 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_1.dateData}, t:  new System.TimeSpan() {_ticks = val_2._ticks});
        System.Globalization.CultureInfo val_4 = System.Globalization.CultureInfo.InvariantCulture;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "loginGuiCooldown", 下下丏一丙不丘丌丞:  val_3.dateData);
        this.七丘丟丒丑与东丑一();
    }

}
