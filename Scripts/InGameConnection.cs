using UnityEngine;
public class InGameConnection : MonoBehaviour
{
    // Fields
    public ReconnectInterface reconnectInterface;
    public OnlineModeController mode;
    public float timerShowNotConnectToRoom;
    internal SceneInfo 专七丗丅业丟丂七上;
    internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丆业丏业丄丆丕不一;
    internal static string 丈丄下丛丅丗丛丐东;
    private static string 丂与且业丛与丆一丄;
    private System.IDisposable 专丘丌丏丈丙丑不丐;
    private GameController 丁丕不丛丆丈世万丙;
    internal bool 万丑丙丄业一丑丏丆;
    internal bool 丐一三丞丝丌不丏丑;
    internal bool 丁七丗专业世丈丒下;
    internal bool 上丙丝万丁丏丄三丈;
    internal bool 丐丒丕三丞世丅丐七;
    private SceneInfo 专丁丞丁且丛七一丙;
    private bool 丒丈丐且丝七专丙七;
    internal bool 丞不丄丐丗不上专丞;
    internal bool 丙丛东丗丁丏丐丁丛;
    private float 三丘专世丑丘丏不且;
    internal bool 丟丕丏一丒丛丐丄丕;
    internal bool 东与七丁丟三丝丈且;
    private float 丗丂丑丗丏世上丝丄;
    private float 业三丏丘丑且丆不丘;
    private int 丝业丐下丏业七丅丘;
    private bool 丟丁丛丛丅世丞上世;
    private int 东不丁丗东丌丟丙丄;
    private bool 丏丙不丁三丆丝三丘;
    internal InGameConnection.DisconnectActionType 东且丅世七一丐丙专;
    private static System.Action<bool> 丕不与上世世万丅一;
    private float 七丕一丞不一三丆丂;
    private bool 三业丒与丟丅丈丄世;
    private bool 丛专丛世丐丏专上丕;
    private string 丗业丟丌专上一丏丘;
    internal static string 业业下丕丈世上且丁;
    
    // Properties
    internal bool 丄业世丒且丟丏下丏 { get; }
    internal bool 一丅丆丂七与丆丈丂 { get; }
    
    // Methods
    internal bool 丐丒专丄万丄丒丙丛()
    {
        return 丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗();
    }
    internal bool 丕上丐丄三上丝专万()
    {
        var val_5;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_6;
        val_5 = this;
        val_6 = this.丆业丏业丄丆丕不一;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_6.丌不丅不丞东万专专();
        val_5 = val_1.HasValue.丙东专丂世丈丏丁丂();
        val_6 = ((val_5 == 4) ? 1 : 0) & 1152921537502694456;
        return (bool)val_6;
    }
    public void Initialize()
    {
        var val_22;
        System.Action<System.String> val_23;
        var val_24;
        System.Action<System.Boolean> val_25;
        var val_26;
        丑丕与三丟且三丈丌 val_27;
        var val_28;
        System.Action val_29;
        var val_30;
        var val_31;
        System.Action val_32;
        var val_33;
        丑丕与三丟且三丈丌 val_34;
        var val_35;
        System.Action val_36;
        var val_37;
        var val_38;
        System.Action val_39;
        var val_40;
        System.Action<System.Object[]> val_41;
        this.丁丕不丛丆丈世万丙 = GameController.丑七不且上丗丁一世();
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  true);
        val_22 = null;
        val_22 = null;
        val_24 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄丐七不丂丑且上丛, b:  new System.Action<System.String>(object:  this, method:  System.Void InGameConnection::丄丐七不丂丑且上丛(string 七丆丂丂下丈且丟世)))) != null) && (null != null))
        {
                val_24 = null;
            val_23 = 0;
        }
        
        GameConnect.丄丐七不丂丑且上丛 = val_23;
        val_26 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void InGameConnection::OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_26 = null;
            val_25 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_25;
        val_28 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InGameConnection::OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_28 = null;
            val_27 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_27;
        val_30 = null;
        val_31 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  System.Void InGameConnection::OnConnectedToMaster()))) != null) && (null != val_31))
        {
                val_30 = null;
            val_31 = null;
            val_29 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_29;
        val_33 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void InGameConnection::OnDisconnectedFromPhoton()))) != null) && (null != null))
        {
                val_33 = null;
            val_32 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_32;
        val_35 = null;
        if(((System.Delegate.Combine(a:  GameConnect.与上一丞且上丄丈丐, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InGameConnection::OnConnectionFail(int 世丁丙世丄一万丆三)))) != null) && (null != null))
        {
                val_35 = null;
            val_34 = 0;
        }
        
        GameConnect.与上一丞且上丄丈丐 = val_34;
        val_37 = null;
        val_38 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void InGameConnection::OnJoinedRoom()))) != null) && (null != val_38))
        {
                val_37 = null;
            val_38 = null;
            val_36 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_36;
        val_40 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄丛丐不丒下三丟丂, b:  new System.Action(object:  this, method:  System.Void InGameConnection::OnLeftRoom()))) != null) && (null != null))
        {
                val_40 = null;
            val_39 = 0;
        }
        
        GameConnect.丄丛丐不丒下三丟丂 = val_39;
        if(((System.Delegate.Combine(a:  GameConnect.与丝丌丌丛下且一丝, b:  new System.Action<System.Object[]>(object:  this, method:  System.Void InGameConnection::OnPhotonPlayerPropertiesChanged(object[] 丙丑丆上不丒上丕丛)))) != null) && (null != null))
        {
                val_41 = 0;
        }
        
        GameConnect.与丝丌丌丛下且一丝 = val_41;
        PGCompany.丑丝万下上丌七不一.丑七不且上丗丁一世().且七丙丄丘一丄上不();
    }
    public void Awake()
    {
        UnityEngine.GameObject val_7;
        var val_8;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "GameModes/UI/ReconnectGui");
        if(val_1 != null)
        {
                var val_3 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_7 = 0;
        }
        
        this.reconnectInterface = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_7, parent:  this.transform).GetComponent<ReconnectInterface>();
        val_8 = null;
        val_8 = null;
        this.reconnectInterface.cancelButtonHandler.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void InGameConnection::OnCancelButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public void AfterInitialization()
    {
        if((this.丞与丂丙丒业丛丗丂(专不丑上与丒与丗丟:  false)) == false)
        {
                return;
        }
        
        this.丏丂专一丛世专丗七(丘丂业丗丁下丂七丛:  false);
    }
    private void 丛与与丈丁丟丄不丕()
    {
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        bool val_34;
        var val_35;
        string val_36;
        var val_37;
        string val_38;
        bool val_39;
        var val_40;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        val_28 = null;
        val_28 = null;
        InGameConnection.丈丄下丛丅丗丛丐东 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
        val_29 = null;
        val_29 = null;
        val_30 = null;
        val_30 = null;
        this.专七丗丅业丟丂七上 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]));
        this.丆业丏业丄丆丕不一 = GameConnect.丈丝丂丐丟万丙丑丕;
        val_31 = null;
        val_31 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_32 = null;
            val_32 = null;
            丒七丙与丙七丅丐东();
        }
        
        val_33 = null;
        val_33 = null;
        this.丐一三丞丝丌不丏丑 = System.String.op_Equality(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘(), b:  SquadController.丕丙三丗丘丁丂丁丌);
        if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
            goto label_34;
        }
        
        val_34 = 0;
        goto label_35;
        label_3:
        UnityEngine.Debug.LogError(message:  "GetRoomInformation: PhotonNetwork.room != null");
        return;
        label_34:
        val_34 = this.丐一三丞丝丌不丏丑;
        label_35:
        this.万丑丙丄业一丑丏丆 = (val_34 == true) ? 1 : 0;
        val_35 = null;
        val_35 = null;
        this.丁七丗专业世丈丒下 = (GameConnect.丈丝丂丐丟万丙丑丕 != 0) ? 1 : 0;
        val_36 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        if((val_36.ContainsKey(key:  GameConnect.丗三丅丞丏七与上七)) != false)
        {
                val_37 = null;
            val_37 = null;
            val_36 = GameConnect.丗三丅丞丏七与上七;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_36] != null) && (null != null))
        {
                val_38 = 0;
        }
        
            val_39 = System.String.op_Inequality(a:  val_38, b:  "");
        }
        else
        {
                val_39 = false;
        }
        
        this.上丙丝万丁丏丄三丈 = val_39;
        this.丐丒丕三丞世丅丐七 = this.丕上丐丄三上丝专万();
        val_40 = null;
        val_40 = null;
        SquadController.丕丙三丗丘丁丂丁丌 = "";
    }
    internal static void 不丘业专下下丅丂丗(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  InGameConnection.丕不与上世世万丅一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(InGameConnection.丕不与上世世万丅一 != 1152921505190395920);
    
    }
    internal static void 丌专世世丑丗丁丙万(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  InGameConnection.丕不与上世世万丅一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(InGameConnection.丕不与上世世万丅一 != 1152921505190395920);
    
    }
    private void 丏丂专一丛世专丗七(bool 丘丂业丗丁下丂七丛)
    {
        var val_10;
        var val_11;
        var val_12;
        this.丟丁丛丛丅世丞上世 = true;
        this.丛与与丈丁丟丄不丕();
        丘丂业丗丁下丂七丛 = 丘丂业丗丁下丂七丛;
        val_10 = null;
        val_10 = null;
        if(InGameConnection.丕不与上世世万丅一 != null)
        {
                InGameConnection.丕不与上世世万丅一.Invoke(obj:  丘丂业丗丁下丂七丛);
        }
        
        if(丘丂业丗丁下丂七丛 != false)
        {
                this.丏丙不丁三丆丝三丘 = true;
            this.七丕一丞不一三丆丂 = (GameConnect.七丂万专且丏丘一丙() != true) ? 0f : 1f;
            return;
        }
        
        this.七丂业丈上世丗丌丄();
        if(GameConnect.丗丛丗下丑不丟丌丛() != false)
        {
                val_11 = null;
            val_11 = null;
            val_12 = System.String.op_Equality(a:  InGameConnection.丂与且业丛与丆一丄, b:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘());
        }
        else
        {
                val_12 = 0;
        }
        
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.mode.下丝七上万丂不专与(丂丘下万丈丘丅一丄:  val_12 & 1));
    }
    internal bool 丞与丂丙丒业丛丗丂(bool 专不丑上与丒与丗丟 = False)
    {
        OnlineModeController val_17;
        var val_18;
        var val_19;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_20;
        var val_21;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_35;
        }
        
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下() <= 1) && (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下() > (GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业()))))
        {
                if(GameConnect.业丗与丈丁东下一丛() != true)
        {
                this.丁丕不丛丆丈世万丙.丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "Max players limit error: PhotonNetwork.room.maxPlayers == "("Max players limit error: PhotonNetwork.room.maxPlayers == ") + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下());
        }
        
        }
        
        val_17 = this.mode;
        if((val_17 & 1) == 0)
        {
            goto label_22;
        }
        
        label_34:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_43;
        }
        
        BattleRoyaleController val_13 = BattleRoyaleController.丑七不且上丗丁一世();
        val_17 = System.String.alignConst;
        val_13.roomConnectedName = val_17;
        goto label_43;
        label_22:
        if(专不丑上与丒与丗丟 == false)
        {
            goto label_30;
        }
        
        val_18 = null;
        val_18 = null;
        if(null == 0)
        {
            goto label_34;
        }
        
        label_30:
        if(this.丐丒丕三丞世丅丐七 == false)
        {
            goto label_35;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_20 == null)
        {
            goto label_43;
        }
        
        val_20 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_20 == null)
        {
                val_20 = 0;
        }
        
        val_17 = this.丆业丏业丄丆丕不一;
        if(val_20.业上丙丞丐丄丆丅七() != val_17.业上丙丞丐丄丆丅七())
        {
            goto label_43;
        }
        
        label_35:
        val_21 = 1;
        return (bool)val_21;
        label_43:
        this.东且丅世七一丐丙专 = 1;
        this.丒丈丐且丝七专丙七 = true;
        this.丞不丄丐丗不上专丞 = true;
        bool val_16 = 丅丒丗丑丒丙丛不丆.丑三丕丂丆一且丂丘(一丝且七丙丆丄丌丅:  true);
        val_21 = 0;
        return (bool)val_21;
    }
    private void OnDestroy()
    {
        var val_20;
        System.Action<System.String> val_21;
        var val_22;
        System.Action<System.Boolean> val_23;
        var val_24;
        丑丕与三丟且三丈丌 val_25;
        var val_26;
        System.Action val_27;
        var val_28;
        var val_29;
        System.Action val_30;
        var val_31;
        丑丕与三丟且三丈丌 val_32;
        var val_33;
        System.Action val_34;
        var val_35;
        var val_36;
        System.Action val_37;
        var val_38;
        System.Action<System.Object[]> val_39;
        var val_40;
        val_20 = null;
        val_20 = null;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄丐七不丂丑且上丛, value:  new System.Action<System.String>(object:  this, method:  System.Void InGameConnection::丄丐七不丂丑且上丛(string 七丆丂丂下丈且丟世)))) != null) && (null != null))
        {
                val_22 = null;
            val_21 = 0;
        }
        
        GameConnect.丄丐七不丂丑且上丛 = val_21;
        val_24 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void InGameConnection::OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_24 = null;
            val_23 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_23;
        val_26 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InGameConnection::OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_26 = null;
            val_25 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_25;
        val_28 = null;
        val_29 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  System.Void InGameConnection::OnConnectedToMaster()))) != null) && (null != val_29))
        {
                val_28 = null;
            val_29 = null;
            val_27 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_27;
        val_31 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void InGameConnection::OnDisconnectedFromPhoton()))) != null) && (null != null))
        {
                val_31 = null;
            val_30 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_30;
        val_33 = null;
        if(((System.Delegate.Remove(source:  GameConnect.与上一丞且上丄丈丐, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InGameConnection::OnConnectionFail(int 世丁丙世丄一万丆三)))) != null) && (null != null))
        {
                val_33 = null;
            val_32 = 0;
        }
        
        GameConnect.与上一丞且上丄丈丐 = val_32;
        val_35 = null;
        val_36 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void InGameConnection::OnJoinedRoom()))) != null) && (null != val_36))
        {
                val_35 = null;
            val_36 = null;
            val_34 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_34;
        val_38 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄丛丐不丒下三丟丂, value:  new System.Action(object:  this, method:  System.Void InGameConnection::OnLeftRoom()))) != null) && (null != null))
        {
                val_38 = null;
            val_37 = 0;
        }
        
        GameConnect.丄丛丐不丒下三丟丂 = val_37;
        if(((System.Delegate.Combine(a:  GameConnect.与丝丌丌丛下且一丝, b:  new System.Action<System.Object[]>(object:  this, method:  System.Void InGameConnection::OnPhotonPlayerPropertiesChanged(object[] 丙丑丆上不丒上丕丛)))) != null) && (null != null))
        {
                val_39 = 0;
        }
        
        GameConnect.与丝丌丌丛下且一丝 = val_39;
        val_40 = null;
        val_40 = null;
        与丂丏丛丞丞丒丟丄.丄七东丏一丂丕丁万 = 0;
    }
    private void Update()
    {
        this.丟世丑上丑世丛丗丄();
        if(this.丞不丄丐丗不上专丞 != false)
        {
                this.丕丄丁丗世业七丗丕();
        }
        
        if(this.丟丕丏一丒丛丐丄丕 != false)
        {
                this.丑七万丄与丄丗丌世();
        }
        
        if(this.丏丙不丁三丆丝三丘 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.七丕一丞不一三丆丂 - val_1;
        this.七丕一丞不一三丆丂 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() == 0f)
        {
                return;
        }
        
        this.丏丙不丁三丆丝三丘 = false;
        this.七丂业丈上世丗丌丄();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.mode.下丝七上万丂不专与(丂丘下万丈丘丅一丄:  true));
    }
    private bool 丂丕且丆丏丑丅丅丝()
    {
        if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == false)
        {
                return MainStoreView.丈丐丞丐上丑且丕万();
        }
        
        return true;
    }
    private bool 丆丑且七不丘丘万丂()
    {
        NetworkStartTableNGUIController val_8;
        bool val_1 = ShopNGUIController.丛世丛与丌不丈丐丐();
        val_8 = val_1;
        if((val_8 == true) || (val_1.丂丕且丆丏丑丅丅丝() == true))
        {
                return false;
        }
        
        val_8 = ExpController.丑七不且上丗丁一世();
        if(val_8.丐丛丁丅丟丆丟业丂() == true)
        {
                return false;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_8 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.上丏丙东丁不丕丁丟 != false)
        {
                return false;
        }
        
        }
        
        bool val_7 = ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且();
        val_7 = (~val_7) & 1;
        return false;
    }
    private void 丕丄丁丗世业七丗丕()
    {
        var val_14;
        NetworkStartTableNGUIController val_15;
        if(this.业三丏丘丑且丆不丘 > 0f)
        {
                bool val_1 = this.丆丑且七不丘丘万丂();
            if(val_1 != false)
        {
                if(this.丟丕丏一丒丛丐丄丕 == false)
        {
            goto label_3;
        }
        
        }
        
            this.业三丏丘丑且丆不丘 = 60f;
        }
        
        label_35:
        if(this.丙丛东丗丁丏丐丁丛 == false)
        {
                return;
        }
        
        if(val_1.丆丑且七不丘丘万丂() != false)
        {
                float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.三丘专世丑丘丏不且 - val_3;
            this.三丘专世丑丘丏不且 = val_3;
        }
        else
        {
                this.丟丕丏一丒丛丐丄丕 = false;
            this.丞不丄丐丗不上专丞 = true;
            this.丙丛东丗丁丏丐丁丛 = true;
            this.三丘专世丑丘丏不且 = 3f;
            this.业三丏丘丑且丆不丘 = 60f;
        }
        
        if(this.reconnectInterface == 0)
        {
            goto label_9;
        }
        
        if(this.reconnectInterface.丒丘丑丝丛丛丁丑世() == false)
        {
            goto label_11;
        }
        
        return;
        label_9:
        if(0 != 0)
        {
                return;
        }
        
        label_11:
        if(this.三丘专世丑丘丏不且 > 0f)
        {
                return;
        }
        
        this.丙丛东丗丁丏丐丁丛 = false;
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丄上丟丈下丂丑丏丛() != false)
        {
                业丈不上丟万一丕丏.丑七不且上丗丁一世().上丄与丂不且丑丞丛();
            return;
        }
        
        UnityEngine.Debug.Log(message:  "InGameConnection: Reconnecting to photon...");
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        val_14 = null;
        val_14 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        val_15 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_15 != 0)
        {
                val_15 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.gameObject;
            UnityEngine.Object.Destroy(obj:  val_15);
        }
        
        丅丒丗丑丒丙丛不丆.丌三七与不丐丅丞上(丙业与丙丗丝不丈东:  false);
        bool val_12 = GameConnect.丆下丅丟下丂一不丙(丛丈丑丏与上丄丝丌:  false);
        return;
        label_3:
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = this.业三丏丘丑且丆不丘 - val_13;
        this.业三丏丘丑且丆不丘 = val_13;
        if(val_13 > 0f)
        {
            goto label_35;
        }
        
        this.丞东丝丛丛丄世丂丄();
    }
    private void 丑七万丄与丄丗丌世()
    {
        SceneInfo val_26;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_27;
        var val_28;
        SceneInfo val_29;
        SceneInfo val_30;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_31;
        if(this.东与七丁丟三丝丈且 == false)
        {
                return;
        }
        
        if(this.丗丂丑丗丏世上丝丄 > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.丗丂丑丗丏世上丝丄 - val_1;
            this.丗丂丑丗丏世上丝丄 = val_1;
        }
        
        if(this.reconnectInterface == 0)
        {
            goto label_5;
        }
        
        if(this.reconnectInterface.丒丘丑丝丛丛丁丑世() == false)
        {
            goto label_7;
        }
        
        return;
        label_5:
        if(0 != 0)
        {
                return;
        }
        
        label_7:
        if(this.丗丂丑丗丏世上丝丄 > 0f)
        {
                return;
        }
        
        this.东与七丁丟三丝丈且 = false;
        if(this.东且丅世七一丐丙专 == 1)
        {
            goto label_11;
        }
        
        if(this.东且丅世七一丐丙专 == 3)
        {
            goto label_12;
        }
        
        if(this.东且丅世七一丐丙专 != 2)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "InGameConnection: Join Random Room");
        if((GameConnect.世丐丄三三上丅七三() != true) && (GameConnect.与丈丘丈上丌丝丝丛() != true))
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                Rilisoft.一丟专且三万丞丁丂.丝丕业与丗三丕七丒(丛丝丗万丐业丒丂丞:  GameConnect.丑丌丛丈丅丅与不业());
        }
        
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        if((((((((GameConnect.世丐丄三三上丅七三() != true) && (GameConnect.万不丒丌丙万丗东不() != true)) && (GameConnect.且丞丁东丝丗上丈业() != true)) && (GameConnect.业丛丛丂一丆丕丗丟() != true)) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.丒丈丒万七丁东丁不() != true)) && (GameConnect.与不丗丏万丙丞丌丑() != true)) && (GameConnect.丒丗丁丙丗丄丙不丐() != true))
        {
                if(GameConnect.丄丏丒丏上东业丒一() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_81;
        }
        
        }
        
        }
        
        if(this.丆业丏业丄丆丕不一 == null)
        {
            goto label_61;
        }
        
        val_26 = this;
        val_27 = 0;
        if((System.String.op_Equality(a:  this.丆业丏业丄丆丕不一.丕丆丞丂业东与上丅(), b:  this.专七丗丅业丟丂七上.丙且上丒不下丑下丞())) == false)
        {
            goto label_64;
        }
        
        val_27 = this.丆业丏业丄丆丕不一;
        goto label_64;
        label_11:
        val_28 = null;
        val_28 = null;
        UnityEngine.Debug.Log(message:  "InGameConnection: Reconnect To Room "("InGameConnection: Reconnect To Room ") + InGameConnection.丈丄下丛丅丗丛丐东);
        bool val_23 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  InGameConnection.丈丄下丛丅丗丛丐东);
        return;
        label_12:
        UnityEngine.Debug.Log(message:  "InGameConnection: Select New Map "("InGameConnection: Select New Map ") + this.专丁丞丁且丛七一丙.丙且上丒不下丑下丞());
        val_29 = this.专丁丞丁且丛七一丙;
        val_30 = val_29;
        label_81:
        val_31 = 0;
        goto label_76;
        label_61:
        val_27 = 0;
        val_26 = this.专七丗丅业丟丂七上;
        label_64:
        val_29 = mem[this.专七丗丅业丟丂七上];
        val_30 = val_29;
        val_31 = val_27;
        label_76:
        GameConnect.上七丗三丗七丈丕丏(丏丈丗世丙万丆丐丅:  val_30, 丐且丘丑与万丞丑丅:  val_31);
    }
    private void 丌丝丈丛东丟丆丏丕(float 丂三丟丂丈丐丆丗丟)
    {
        this.丟丕丏一丒丛丐丄丕 = false;
        this.三丘专世丑丘丏不且 = 丂三丟丂丈丐丆丗丟;
        this.丞不丄丐丗不上专丞 = true;
        this.丙丛东丗丁丏丐丁丛 = true;
        this.业三丏丘丑且丆不丘 = 60f;
    }
    private void 一业丁丁丌万丄七专(float 丂三丟丂丈丐丆丗丟)
    {
        this.丟丕丏一丒丛丐丄丕 = true;
        this.东与七丁丟三丝丈且 = true;
        this.丗丂丑丗丏世上丝丄 = 丂三丟丂丈丐丆丗丟;
    }
    internal void 丟业丌丗丒丅丞丗不(SceneInfo 丄不东丁丂丅万丒丟)
    {
        this.专丁丞丁且丛七一丙 = 丄不东丁丂丅万丒丟;
        this.东且丅世七一丐丙专 = 3;
        bool val_1 = 丅丒丗丑丒丙丛不丆.丑三丕丂丆一且丂丘(一丝且七丙丆丄丌丅:  true);
    }
    internal void 丁三且东上丛丞丘万()
    {
        this.东且丅世七一丐丙专 = 2;
        bool val_1 = 丅丒丗丑丒丙丛不丆.丑三丕丂丆一且丂丘(一丝且七丙丆丄丌丅:  true);
    }
    private void 丟世丑上丑世丛丗丄()
    {
        var val_29;
        System.Action val_30;
        var val_31;
        System.IDisposable val_32;
        var val_34;
        var val_35;
        bool val_36;
        var val_37;
        var val_38;
        bool val_1 = ShopNGUIController.丛世丛与丌不丈丐丐();
        if(val_1 == true)
        {
                return;
        }
        
        if(val_1.丂丕且丆丏丑丅丅丝() == true)
        {
                return;
        }
        
        if(this.丞不丄丐丗不上专丞 == false)
        {
                return;
        }
        
        val_29 = 1152921505086132224;
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.上丏丙东丁不丕丁丟 == true)
        {
                return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.reconnectInterface.backgroundUITexture.gameObject, 丏业丟一东丂东丘丛:  true);
        if(this.timerShowNotConnectToRoom <= 0f)
        {
            goto label_15;
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.timerShowNotConnectToRoom - val_5;
        this.timerShowNotConnectToRoom = val_5;
        if(val_5 <= 0f)
        {
            goto label_16;
        }
        
        if(this.三业丒与丟丅丈丄世 == true)
        {
                return;
        }
        
        this.reconnectInterface.丝丝丝丒丟上与丟丛(丛丆丛三丕丅丝丝丝:  true);
        this.三业丒与丟丅丈丄世 = true;
        val_30 = 1152921505066536960;
        if((GameConnect.丑丌丛丈丅丅与不业() == 17) || (this.万丑丙丄业一丑丏丆 == true))
        {
            goto label_34;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 10)
        {
            goto label_25;
        }
        
        MiniGamesController val_8 = MiniGamesController.丑七不且上丗丁一世();
        if(val_8.isGo == true)
        {
            goto label_34;
        }
        
        label_25:
        if((this.丁七丗专业世丈丒下 != true) && (this.上丙丝万丁丏丄三丈 != true))
        {
                val_31 = null;
            val_31 = null;
            if(GameConnect.丛丑世丕丌上丑丂丈 != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_99;
        }
        
        }
        
        }
        
        label_34:
        label_99:
        this.丄丝不丕下不丅丌万(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3153"));
        this.reconnectInterface.buttonCancel.gameObject.SetActive(value:  false);
        val_32 = this.专丘丌丏丈丙丑不丐;
        if(val_32 == null)
        {
                return;
        }
        
        val_34 = null;
        var val_28 = 0;
        val_35 = 1152921504621740040;
        val_28 = val_28 + 1;
        goto label_96;
        label_15:
        if(this.丛专丛世丐丏专上丕 == true)
        {
                return;
        }
        
        this.丛专丛世丐丏专上丕 = true;
        this.丄丝不丕下不丅丌万(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1004"));
        val_36 = ShopNGUIController.丛世丛与丌不丈丐丐() ^ 1;
        if(GameConnect.丒丈丒万七丁东丁不() != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_36 = ((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 == false) ? 1 : 0) & val_36;
        }
        
        }
        
        this.reconnectInterface.buttonCancel.gameObject.SetActive(value:  val_36);
        val_32 = this.专丘丌丏丈丙丑不丐;
        if(val_36 == false)
        {
            goto label_63;
        }
        
        if(val_32 != null)
        {
                return;
        }
        
        System.Action val_20 = null;
        val_30 = val_20;
        val_20 = new System.Action(object:  this, method:  public System.Void InGameConnection::OnCancelButtonClick());
        this.专丘丌丏丈丙丑不丐 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_20, 与且专丈不万东一万:  "Cancel from reconnect");
        return;
        label_16:
        if(this.专七丗丅业丟丂七上 == 0)
        {
            goto label_87;
        }
        
        val_37 = 1152921505066536960;
        if((GameConnect.丑丌丛丈丅丅与不业() == 17) || (this.万丑丙丄业一丑丏丆 == true))
        {
            goto label_87;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 10)
        {
            goto label_78;
        }
        
        MiniGamesController val_25 = MiniGamesController.丑七不且上丗丁一世();
        if(val_25.isGo == true)
        {
            goto label_87;
        }
        
        label_78:
        if((this.上丙丝万丁丏丄三丈 != true) && (this.丁七丗专业世丈丒下 != true))
        {
                val_38 = null;
            val_38 = null;
            if(GameConnect.丛丑世丕丌上丑丂丈 != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_90;
        }
        
        }
        
        }
        
        label_87:
        this.丁丕不丛丆丈世万丙.丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
        return;
        label_63:
        if(val_32 == null)
        {
                return;
        }
        
        val_34 = null;
        var val_29 = 0;
        val_35 = 1152921504621740040;
        val_29 = val_29 + 1;
        label_96:
        val_32.Dispose();
        this.专丘丌丏丈丙丑不丐 = 0;
        return;
        label_90:
        this.丞不丄丐丗不上专丞 = false;
        GameConnect.上七丗三丗七丈丕丏(丏丈丗世丙万丆丐丅:  this.专七丗丅业丟丂七上, 丐且丘丑与万丞丑丅:  0);
    }
    private void 丄丝不丕下不丅丌万(string 丕丗丘丑丛与丑业丒)
    {
        this.reconnectInterface.ShowDescriptionLabel(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    internal void 丗丒丕丟东丞丈丝东()
    {
        this.reconnectInterface.Hide();
        if(this.专丘丌丏丈丙丑不丐 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.专丘丌丏丈丙丑不丐.Dispose();
        this.专丘丌丏丈丙丑不丐 = 0;
    }
    public void OnCancelButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.OnCancelButtonClick();
    }
    public void OnCancelButtonClick()
    {
        if(this.丕上丐丄三上丝专万() != false)
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
        }
        
            this.reconnectInterface.与丐丛业丟丌丑丈丞(且丞丑丕丑丌丂丁世:  new System.Action(object:  this, method:  System.Void InGameConnection::丞东丝丛丛丄世丂丄()), 丝丈丛丐丕丟不丌丗:  new System.Action(object:  this, method:  System.Void InGameConnection::丞丑业丗七丗世丟丌()));
            this.丞不丄丐丗不上专丞 = false;
            this.丟丕丏一丒丛丐丄丕 = false;
            return;
        }
        
        this.丞东丝丛丛丄世丂丄();
    }
    private void 丞丑业丗七丗世丟丌()
    {
        this.丟丕丏一丒丛丐丄丕 = false;
        this.丞不丄丐丗不上专丞 = true;
        this.丙丛东丗丁丏丐丁丛 = true;
        this.三丘专世丑丘丏不且 = 0f;
    }
    private void 与业丅丞上东下丌万()
    {
        this.丞不丄丐丗不上专丞 = false;
        this.丟丕丏一丒丛丐丄丕 = false;
    }
    private void 丞东丝丛丛丄世丂丄()
    {
        this.丞不丄丐丗不上专丞 = false;
        this.丟丕丏一丒丛丐丄丕 = false;
        this.丁丕不丛丆丈世万丙.丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
    }
    private System.Collections.IEnumerator 丝业丗上上丘丐与丗()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InGameConnection.丙丟丁丅丟下七丝上(丗丏丅丕丆世丁专丟:  0);
    }
    private void 七丂业丈上世丗丌丄()
    {
        this.reconnectInterface.matchFoundPanel.SetActive(value:  false);
        this.reconnectInterface.matchAgainPanel.SetActive(value:  false);
    }
    private void OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万 = False)
    {
        int val_1 = this.丝业丐下丏业七丅丘;
        val_1 = val_1 + 1;
        this.丝业丐下丏业七丅丘 = val_1;
        UnityEngine.Debug.Log(message:  "[Initializer] On_PhotonJoinRoomFailed => init");
        if(this.丝业丐下丏业七丅丘 <= 5)
        {
                this.丟丕丏一丒丛丐丄丕 = true;
            this.东与七丁丟三丝丈且 = true;
            this.丗丂丑丗丏世上丝丄 = 3f;
            return;
        }
        
        this.timerShowNotConnectToRoom = 3f;
    }
    private void OnLeftRoom()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        InGameConnection.丂与且业丛与丆一丄 = System.String.alignConst;
        UnityEngine.Debug.Log(message:  "On Left Room (local) init");
        val_6 = null;
        val_6 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = 0;
        if(this.东且丅世七一丐丙专 != 3)
        {
                return;
        }
        
        bool val_1 = ShopNGUIController.丛世丛与丌不丈丐丐();
        if((val_1 != true) && (val_1.丂丕且丆丏丑丅丅丝() != true))
        {
                ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        }
        
        if(this.专丁丞丁且丛七一丙 == 0)
        {
                return;
        }
        
        this.丁丕不丛丆丈世万丙.ShowLoadingGUI(丛丘七丂且丟丁一丙:  this.专丁丞丁且丛七一丙.丙且上丒不下丑下丞());
    }
    internal void 下与业丒丝丕丙丘丙()
    {
        this.东且丅世七一丐丙专 = 0;
        丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
    }
    private void OnDisconnectedFromPhoton()
    {
        UnityEngine.Debug.Log(message:  "InGameConnection: On Disconnected From Photon");
        this.丛东丅丏丞上丁上七();
    }
    private void OnConnectionFail(int 世丁丙世丄一万丆三)
    {
        UnityEngine.Debug.Log(message:  "InGameConnection: On Connection Fail "("InGameConnection: On Connection Fail ") + 世丁丙世丄一万丆三);
        this.东不丁丗东丌丟丙丄 = 世丁丙世丄一万丆三;
    }
    private void OnPhotonPlayerPropertiesChanged(object[] 丙丑丆上不丒上丕丛)
    {
        int val_8;
        var val_9;
        与丅丕丈丘东丝世丟 val_10;
        var val_11;
        var val_12;
        string val_13;
        val_8 = 丙丑丆上不丒上丕丛.Length;
        if(val_8 == 0)
        {
                val_8 = 丙丑丆上不丒上丕丛.Length;
        }
        
        object val_8 = 丙丑丆上不丒上丕丛[0];
        object val_9 = 丙丑丆上不丒上丕丛[1];
        val_9 = 0;
        val_10 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(val_8 != null)
        {
                val_11 = null;
            val_11 = null;
            var val_3 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (与丅丕丈丘东丝世丟.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_11) ? (val_8) : 0;
        }
        else
        {
                val_12 = 0;
        }
        
        if((val_12.Equals(丘丛丏丘丝七世七丅:  val_10)) == false)
        {
                return;
        }
        
        val_10 = "DISCONNECT";
        if((ContainsKey(key:  "DISCONNECT")) == false)
        {
                return;
        }
        
        object val_6 = Item["DISCONNECT"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_13 = 0;
        }
        
        this.丗业丟丌专上一丏丘 = val_13;
    }
    private void 丛东丅丏丞上丁上七()
    {
        DisconnectActionType val_16;
        var val_17;
        var val_18;
        if(this.reconnectInterface != 0)
        {
                if(this.reconnectInterface.丒丘丑丝丛丛丁丑世() == true)
        {
                return;
        }
        
        }
        
        this.七丂业丈上世丗丌丄();
        if(this.丟丁丛丛丅世丞上世 != false)
        {
                val_16 = this;
            this.mode.东丘丆丂丞丏丛丂一(丝丐不丛丗七七丞一:  (this.东且丅世七一丐丙专 == 0) ? 1 : 0);
        }
        else
        {
                val_16 = this.东且丅世七一丐丙专;
        }
        
        if((val_16 - 2) < 2)
        {
                if(this.丁丕不丛丆丈世万丙.三三丆下东丏丌丅上 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丁丕不丛丆丈世万丙.三三丆下东丏丌丅上.gameObject);
            this.丁丕不丛丆丈世万丙.三三丆下东丏丌丅上 = 0;
        }
        
            mem2[0] = 1;
        }
        else
        {
                if(val_16 == 0)
        {
                this.丁丕不丛丆丈世万丙.上丏丅上世丆丒丟丌();
            return;
        }
        
        }
        
        if(this.东不丁丗东丌丟丙丄 == 1043)
        {
                PGCompany.Analytics.一业丗丆世世上丁且.且丆丐专丆万丒业丐(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "server", 世丁丙世丄一万丆三:  this.丗业丟丌专上一丏丘);
            PGCompany.丑丝万下上丌七不一.丑七不且上丗丁一世().丅专下万丕丑丆丅丝(与丗丆丏丙丟与丒业:  "ProceedDisconnect");
            this.丁丕不丛丆丈世万丙.丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
            return;
        }
        
        val_17 = null;
        val_17 = null;
        this.丟丕丏一丒丛丐丄丕 = false;
        this.丞不丄丐丗不上专丞 = true;
        this.丙丛东丗丁丏丐丁丛 = true;
        this.三丘专世丑丘丏不且 = 0.1f;
        this.业三丏丘丑且丆不丘 = 60f;
        bool val_9 = ShopNGUIController.丛世丛与丌不丈丐丐();
        if((val_9 != true) && (val_9.丂丕且丆丏丑丅丅丝() != true))
        {
                if(ExpController.丑七不且上丗丁一世().丐丛丁丅丟丆丟业丂() != true)
        {
                if((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0) || (NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.上丏丙东丁不丕丁丟 == false))
        {
            goto label_46;
        }
        
        }
        
        }
        
        this.东不丁丗东丌丟丙丄 = 0;
        return;
        label_46:
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        val_18 = null;
        val_18 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.shopAnchor == 0)
        {
                return;
        }
        
        SetActive(value:  false);
    }
    private void OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)
    {
        UnityEngine.GameObject val_6 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "NetworkStartTableNGUI");
        if(val_6 == 0)
        {
            goto label_3;
        }
        
        val_6 = val_6.GetComponent<NetworkStartTableNGUIController>();
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        val_6 = val_3.shopAnchor;
        val_6.SetActive(value:  false);
        goto label_10;
        label_3:
        UnityEngine.Debug.LogError(message:  "nguiC == null");
        label_10:
        UnityEngine.Debug.Log(message:  "On Failed To Connect To Photon. StatusCode: "("On Failed To Connect To Photon. StatusCode: ") + 丗丟上上丒丐丗丞丙);
        if(this.丞不丄丐丗不上专丞 == false)
        {
                return;
        }
        
        this.丟丕丏一丒丛丐丄丕 = false;
        this.丞不丄丐丗不上专丞 = true;
        this.丙丛东丗丁丏丐丁丛 = true;
        this.三丘专世丑丘丏不且 = 3f;
        this.业三丏丘丑且丆不丘 = 60f;
    }
    private void OnConnectedToMaster()
    {
        if(this.丒丈丐且丝七专丙七 != false)
        {
                this.丝业丐下丏业七丅丘 = 6;
            this.OnPhotonJoinRoomFailed(丒七丛丟丅丝丛丟万:  false);
            PGCompany.丑丝万下上丌七不一.丑七不且上丗丁一世().丅专下万丕丑丆丅丝(与丗丆丏丙丟与丒业:  "OnConnectedToMaster");
            return;
        }
        
        this.丝业丐下丏业七丅丘 = 0;
        this.丟丕丏一丒丛丐丄丕 = true;
        this.东与七丁丟三丝丈且 = true;
        this.丗丂丑丗丏世上丝丄 = 0f;
    }
    private void 丄丐七不丂丑且上丛(string 七丆丂丂下丈且丟世)
    {
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
    }
    private void OnJoinedRoom()
    {
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        string val_28;
        WeaponManager val_29;
        var val_30;
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        UnityEngine.Debug.Log(message:  "On Joined Room - init");
        if((this.丞与丂丙丒业丛丗丂(专不丑上与丒与丗丟:  false)) == false)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.丞不丄丐丗不上专丞 == true)
        {
            goto label_27;
        }
        
        }
        
            PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_4 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
            if(val_4 != null)
        {
                val_25 = val_4.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        }
        else
        {
                val_25 = 0;
        }
        
            val_26 = null;
            val_26 = null;
            val_27 = null;
            val_27 = null;
            val_28 = GameConnect.七丟丞不丆万上业丆;
            val_29 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_28]));
            if(GameConnect.东丒七专丂世丝丏丗() != true)
        {
                val_30 = null;
            val_30 = null;
            val_28 = val_29.丙且上丒不下丑下丞();
            if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  val_28)) != false)
        {
                val_31 = null;
            val_31 = null;
            val_25 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[val_29.丙且上丒不下丑下丞()];
        }
        
            val_32 = null;
            val_32 = null;
            val_29 = WeaponManager.丟丗丄业丘丗业丗七;
            val_29.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : (val_25));
        }
        
        }
        
        label_27:
        if(this.东且丅世七一丐丙专 != 4)
        {
                if((this.丞不丄丐丗不上专丞 == false) || (GameConnect.七丘丑三丌专丘丈丂() == false))
        {
            goto label_46;
        }
        
        }
        
        this.丏丂专一丛世专丗七(丘丂业丗丁下丂七丛:  true);
        this.丞不丄丐丗不上专丞 = false;
        this.丟丕丏一丒丛丐丄丕 = false;
        this.三业丒与丟丅丈丄世 = false;
        this.丛专丛世丐丏专上丕 = false;
        return;
        label_46:
        if(GameConnect.丗丛丗下丑不丟丌丛() != false)
        {
                val_33 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
        }
        else
        {
                val_33 = System.String.alignConst;
        }
        
        val_34 = null;
        val_34 = null;
        InGameConnection.丂与且业丛与丆一丄 = val_33;
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.丝业丗上上丘丐与丗());
    }
    public InGameConnection()
    {
        this.东且丅世七一丐丙专 = 1;
        this.丗业丟丌专上一丏丘 = System.String.alignConst;
    }
    private static InGameConnection()
    {
        InGameConnection.业业下丕丈世上且丁 = System.String.alignConst;
    }

}
