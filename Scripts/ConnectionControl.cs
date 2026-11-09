using UnityEngine;
public class ConnectionControl : MonoBehaviour
{
    // Fields
    public ConnectPanel connectionPanel;
    public bool cantCancel;
    public bool dontResetGameMode;
    private bool 丑专且丗七业丑上丟;
    private bool 下丟丈业丂丘丌与万;
    public bool canShowStubLoading;
    private bool 丗丛七丈丆丘丗丘丕;
    private System.IDisposable 与丈丘下一七丒东丁;
    private System.Action 丟万丂丝七丑丞丌一;
    private System.Action 业丁丄专丕专丙丙东;
    private System.Action 七丗丕上世丄丗丕一;
    internal System.Action 丂一丑丛不专万丁上;
    private SceneInfo 下丒不与丟丏与专丁;
    private bool 丈丑丈丒上丑东万丟;
    private bool 世丁丒丞丁丕一丟万;
    private bool 丅万丁丌一世下丐丑;
    private bool 丐丝丛丂与专下丝丙;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丝丞丌丌不业丕七七;
    private int 丛且丞与丕业下丏丞;
    
    // Properties
    public bool 不专丛丂丈丌丁丕丟 { get; }
    
    // Methods
    public bool get_panelVisible()
    {
        if(this.connectionPanel == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = this.connectionPanel.gameObject;
        if(val_2 != null)
        {
                return val_2.activeSelf;
        }
        
        return val_2.activeSelf;
    }
    public void SetConnectPanel(ConnectPanel 丛丘下丗业丂一且业)
    {
        this.connectionPanel = 丛丘下丗业丂一且业;
    }
    private void OnDisable()
    {
        this.与丆丈丗丄丒东丈丘();
        this.丑丂丒上东丙丟丕三();
    }
    private void 丝丅七丑上丟业不东()
    {
        var val_16;
        System.Action<System.Boolean> val_17;
        var val_18;
        丑丕与三丟且三丈丌 val_19;
        var val_20;
        System.Action<System.String> val_21;
        var val_22;
        System.Action val_23;
        var val_24;
        var val_25;
        System.Action val_26;
        var val_27;
        var val_28;
        System.Action val_29;
        var val_30;
        var val_31;
        System.Action val_32;
        if(this.丗丛七丈丆丘丗丘丕 == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void ConnectionControl::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_18 = null;
            val_17 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_17;
        val_20 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectionControl::OnFailedToConnect(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_20 = null;
            val_19 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_19;
        val_22 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丒丁七万丌一与丞丂, b:  new System.Action<System.String>(object:  this, method:  System.Void ConnectionControl::丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)))) != null) && (null != null))
        {
                val_22 = null;
            val_21 = 0;
        }
        
        GameConnect.丒丁七万丌一与丞丂 = val_21;
        val_24 = null;
        val_25 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  public System.Void ConnectionControl::OnConnectedToMaster()))) != null) && (null != val_25))
        {
                val_24 = null;
            val_25 = null;
            val_23 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_23;
        val_27 = null;
        val_28 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void ConnectionControl::丂丐与丞丗丒丘丑上()))) != null) && (null != val_28))
        {
                val_27 = null;
            val_28 = null;
            val_26 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_26;
        val_30 = null;
        val_31 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void ConnectionControl::OnJoinedRoom()))) != null) && (null != val_31))
        {
                val_30 = null;
            val_31 = null;
            val_29 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_29;
        if(((System.Delegate.Combine(a:  GameConnect.一与丁丂丒丗丌世丞, b:  new System.Action(object:  this, method:  System.Void ConnectionControl::OnCreatedRoom()))) != null) && (null != null))
        {
                val_32 = 0;
        }
        
        GameConnect.一与丁丂丒丗丌世丞 = val_32;
        this.丗丛七丈丆丘丗丘丕 = true;
    }
    private void 与丆丈丗丄丒东丈丘()
    {
        var val_16;
        System.Action<System.Boolean> val_17;
        var val_18;
        丑丕与三丟且三丈丌 val_19;
        var val_20;
        System.Action<System.String> val_21;
        var val_22;
        System.Action val_23;
        var val_24;
        var val_25;
        System.Action val_26;
        var val_27;
        var val_28;
        System.Action val_29;
        var val_30;
        var val_31;
        System.Action val_32;
        val_16 = null;
        val_16 = null;
        val_18 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void ConnectionControl::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_18 = null;
            val_17 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_17;
        val_20 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectionControl::OnFailedToConnect(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_20 = null;
            val_19 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_19;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丒丁七万丌一与丞丂, value:  new System.Action<System.String>(object:  this, method:  System.Void ConnectionControl::丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)))) != null) && (null != null))
        {
                val_22 = null;
            val_21 = 0;
        }
        
        GameConnect.丒丁七万丌一与丞丂 = val_21;
        val_24 = null;
        val_25 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  public System.Void ConnectionControl::OnConnectedToMaster()))) != null) && (null != val_25))
        {
                val_24 = null;
            val_25 = null;
            val_23 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_23;
        val_27 = null;
        val_28 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void ConnectionControl::丂丐与丞丗丒丘丑上()))) != null) && (null != val_28))
        {
                val_27 = null;
            val_28 = null;
            val_26 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_26;
        val_30 = null;
        val_31 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void ConnectionControl::OnJoinedRoom()))) != null) && (null != val_31))
        {
                val_30 = null;
            val_31 = null;
            val_29 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_29;
        if(((System.Delegate.Remove(source:  GameConnect.一与丁丂丒丗丌世丞, value:  new System.Action(object:  this, method:  System.Void ConnectionControl::OnCreatedRoom()))) != null) && (null != null))
        {
                val_32 = 0;
        }
        
        GameConnect.一与丁丂丒丗丌世丞 = val_32;
        this.丗丛七丈丆丘丗丘丕 = false;
    }
    public void CancelBtn(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.CancelBtn();
    }
    private void 丑丂丒上东丙丟丕三()
    {
        if(this.与丈丘下一七丒东丁 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.与丈丘下一七丒东丁.Dispose();
        this.与丈丘下一七丒东丁 = 0;
    }
    private void 丘不丁丘万丑丈丞世()
    {
        this.丑丂丒上东丙丟丕三();
        this.与丆丈丗丄丒东丈丘();
        if(this.connectionPanel != 0)
        {
                if(this.connectionPanel.failInternetLabel != 0)
        {
                this.connectionPanel.failInternetLabel.SetActive(value:  false);
        }
        
        }
        
        if(this.connectionPanel == 0)
        {
                return;
        }
        
        if(this.connectionPanel.gameObject == 0)
        {
                return;
        }
        
        this.connectionPanel.gameObject.SetActive(value:  false);
    }
    private void 丌丈丝丞东丅丁东业()
    {
        this.业丁丄专丕专丙丙东 = 0;
        this.七丗丕上世丄丗丕一 = 0;
        this.丟万丂丝七丑丞丌一 = 0;
    }
    private void 世一丛丞世丁专丘丐()
    {
        this.丝丅七丑上丟业不东();
        if(this.connectionPanel == 0)
        {
                return;
        }
        
        this.connectionPanel.cancelButton.ClearEvents();
        this.connectionPanel.cancelButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ConnectionControl::CancelBtn(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this.connectionPanel.connectWindow != 0)
        {
                this.connectionPanel.connectWindow.SetActive(value:  true);
        }
        
        if(this.connectionPanel.banWindow != 0)
        {
                this.connectionPanel.banWindow.SetActive(value:  false);
        }
        
        this.与丈丘下一七丒东丁 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ConnectionControl::CancelBtn()), 与且专丈不万东一万:  "Connect to Photon panel");
        this.connectionPanel.gameObject.SetActive(value:  true);
    }
    private void 丏丅丅世丗三业东专()
    {
        if(this.connectionPanel == 0)
        {
                return;
        }
        
        this.connectionPanel.cancelButton.ClearEvents();
        this.connectionPanel.cancelButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ConnectionControl::CancelBtn(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.connectionPanel.timeoutOkButton.ClearEvents();
        this.connectionPanel.timeoutOkButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ConnectionControl::CancelBtn(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this.connectionPanel.connectWindow != 0)
        {
                this.connectionPanel.connectWindow.SetActive(value:  false);
        }
        
        if(this.connectionPanel.banWindow != 0)
        {
                this.connectionPanel.banWindow.SetActive(value:  true);
        }
        
        this.connectionPanel.timeoutLabel.gameObject.SetActive(value:  false);
        this.connectionPanel.timeoutEndLabel.gameObject.SetActive(value:  false);
    }
    public void CancelBtn()
    {
        var val_6;
        if(this.cantCancel == true)
        {
                return;
        }
        
        this.丑专且丗七业丑上丟 = true;
        this.下丟丈业丂丘丌与万 = false;
        val_6 = null;
        val_6 = null;
        GameConnect.丛丑世丕丌上丑丂丈 = false;
        if(丅丒丗丑丒丙丛不丆.丛丗一不丈丂丒丒丂() != true)
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != true)
        {
                if(this.丟万丂丝七丑丞丌一 != null)
        {
            goto label_10;
        }
        
        }
        
        }
        
        GameConnect.下与业丒丝丕丙丘丙();
        label_10:
        if(MatchmakingConnect.instance.InRequest != false)
        {
                MatchmakingConnect.instance.且丞七丕丕丕丄丆丅();
        }
        
        this.丘不丁丘万丑丈丞世();
        if(this.dontResetGameMode != true)
        {
                GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
        }
        
        if(this.丂一丑丛不专万丁上 != null)
        {
                this.丂一丑丛不专万丁上.Invoke();
        }
        
        this.丈丑丈丒上丑东万丟 = false;
        this.业丁丄专丕专丙丙东 = 0;
        this.七丗丕上世丄丗丕一 = 0;
        this.丟万丂丝七丑丞丌一 = 0;
    }
    public void JoinRoom(string 丅一丞万丑专丅丅与, System.Action 上业丈东万下世丝丁)
    {
        this.世一丛丞世丁专丘丐();
        this.业丁丄专丕专丙丙东 = 上业丈东万下世丝丁;
        bool val_1 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
    }
    internal void 一丙丅丛丁东丅丅世(System.Action 上业丈东万下世丝丁, SceneInfo 丏丈丗世丙万丆丐丅, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        this.世一丛丞世丁专丘丐();
        if(this.丝丞丌丌不业丕七七 != 丐且丘丑与万丞丑丅)
        {
                this.丝丛丅专上业与丞七(丟丄下上丈丗丙丞世:  false);
            return;
        }
        
        this.下丒不与丟丏与专丁 = 丏丈丗世丙万丆丐丅;
        this.业丁丄专丕专丙丙东 = 上业丈东万下世丝丁;
        this.丈丑丈丒上丑东万丟 = true;
        GameConnect.上七丗三丗七丈丕丏(丏丈丗世丙万丆丐丅:  丏丈丗世丙万丆丐丅, 丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅);
    }
    private void 上丁丅丏丄上丑丟丘()
    {
        GameConnect.上七丗三丗七丈丕丏(丏丈丗世丙万丆丐丅:  this.下丒不与丟丏与专丁, 丐且丘丑与万丞丑丅:  this.丝丞丌丌不业丕七七);
    }
    internal void 丆下丅丟下丂一不丙(System.Action 万七一丗三丂东丅丒, bool 丟丌丘世丟丛下万东 = False, bool 世丁丒丞丁丕一丟万 = False, bool 丐丝丛丂与专下丝丙 = False, bool 丅万丁丌一世下丐丑 = False, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丝丞丌丌不业丕七七, int 丛且丞与丕业下丏丞 = -1, bool 丆丅丙丞丈丘丌万丙 = False)
    {
        丅丒丗丑丒丙丛不丆.丌三七与不丐丅丞上(丙业与丙丗丝不丈东:  丟丌丘世丟丛下万东);
        this.cantCancel = false;
        this.canShowStubLoading = true;
        this.丑专且丗七业丑上丟 = false;
        this.世一丛丞世丁专丘丐();
        this.丝丞丌丌不业丕七七 = 丝丞丌丌不业丕七七;
        this.丛且丞与丕业下丏丞 = 丛且丞与丕业下丏丞;
        this.世丁丒丞丁丕一丟万 = 世丁丒丞丁丕一丟万;
        this.丅万丁丌一世下丐丑 = 丅万丁丌一世下丐丑;
        this.丐丝丛丂与专下丝丙 = 丐丝丛丂与专下丝丙;
        this.丟万丂丝七丑丞丌一 = 万七一丗三丂东丅丒;
        this.丆下丅丟下丂一不丙();
    }
    private void Update()
    {
        var val_1;
        if(this.下丟丈业丂丘丌与万 == false)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        if(RatingSystem.丝七丘丝丒丞丝丆世 == false)
        {
            goto label_4;
        }
        
        if(this.下丟丈业丂丘丌与万 == false)
        {
            goto label_5;
        }
        
        return;
        label_4:
        this.下丟丈业丂丘丌与万 = false;
        label_5:
        this.世一丛丞世丁专丘丐();
        this.丆下丅丟下丂一不丙();
    }
    private void 丆下丅丟下丂一不丙()
    {
        var val_6 = 0;
        val_6 = val_6 + 1;
        UnityEngine.Coroutine val_5 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丆下丅丟下丂一不丙(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    private System.Collections.IEnumerable 丆下丅丟下丂一不丙(float 丕丕世且下一与丝与)
    {
        ConnectionControl.专丒丙丂上丌丙与专 val_1 = new ConnectionControl.专丒丙丂上丌丙与专();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    private void 丂丐与丞丗丒丘丑上()
    {
        var val_8;
        UnityEngine.Debug.Log(message:  "On Disconnected From Photon");
        val_8 = null;
        val_8 = null;
        GameConnect.七七丈东丅上丝丒万 = false;
        this.canShowStubLoading = false;
        if(this.丟万丂丝七丑丞丌一 != null)
        {
                if(this.丑专且丗七业丑上丟 == false)
        {
            goto label_6;
        }
        
        }
        
        this.CancelBtn();
        goto label_7;
        label_6:
        var val_9 = 0;
        val_9 = val_9 + 1;
        UnityEngine.Coroutine val_5 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丆下丅丟下丂一不丙(丕丕世且下一与丝与:  0.5f).GetEnumerator());
        label_7:
        if(this.connectionPanel == 0)
        {
                return;
        }
        
        if(this.connectionPanel.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.connectionPanel.failInternetLabel.SetActive(value:  true);
    }
    private void OnFailedToConnect(int 丗丟上上丒丐丗丞丙)
    {
        UnityEngine.Debug.Log(message:  "On Failed To Connect To Photon. StatusCode: "("On Failed To Connect To Photon. StatusCode: ") + 丗丟上上丒丐丗丞丙);
        this.canShowStubLoading = false;
        if(this.connectionPanel != 0)
        {
                if(this.connectionPanel.gameObject.activeSelf != false)
        {
                this.connectionPanel.failInternetLabel.SetActive(value:  true);
        }
        
        }
        
        if(this.丑专且丗七业丑上丟 != false)
        {
                this.与丆丈丗丄丒东丈丘();
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            UnityEngine.Coroutine val_9 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丆下丅丟下丂一不丙(丕丕世且下一与丝与:  1f).GetEnumerator());
        }
        
        this.丑专且丗七业丑上丟 = false;
    }
    private void 丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)
    {
        UnityEngine.Debug.Log(message:  "On Failed To Connect To Photon. " + 丂七东不不丈一丐不);
        this.canShowStubLoading = false;
        if(this.connectionPanel != 0)
        {
                if(this.connectionPanel.gameObject.activeSelf != false)
        {
                this.connectionPanel.failInternetLabel.SetActive(value:  true);
        }
        
        }
        
        this.丑专且丗七业丑上丟 = true;
        this.与丆丈丗丄丒东丈丘();
    }
    public void OnConnectedToMaster()
    {
        UnityEngine.Debug.Log(message:  "On Connected To Master");
        丅丒丗丑丒丙丛不丆.丅丗业与万且不丐丈(丙业与丙丗丝不丈东:  ProfileController.丆三丂丂丆上丆丕专());
        this.丘不丁丘万丑丈丞世();
        if(this.丟万丂丝七丑丞丌一 != null)
        {
                this.丟万丂丝七丑丞丌一.Invoke();
            this.丟万丂丝七丑丞丌一 = 0;
        }
        else
        {
                GameConnect.下与业丒丝丕丙丘丙();
        }
        
        this.丑专且丗七业丑上丟 = false;
    }
    private void OnCreatedRoom()
    {
        this.cantCancel = true;
        if(this.丈丑丈丒上丑东万丟 != true)
        {
                this.丘不丁丘万丑丈丞世();
        }
        
        if(this.七丗丕上世丄丗丕一 == null)
        {
                return;
        }
        
        this.七丗丕上世丄丗丕一.Invoke();
        this.七丗丕上世丄丗丕一 = 0;
    }
    private void OnJoinedRoom()
    {
        this.cantCancel = true;
        this.与丆丈丗丄丒东丈丘();
        this.丈丑丈丒上丑东万丟 = false;
        if(this.业丁丄专丕专丙丙东 == null)
        {
                return;
        }
        
        this.业丁丄专丕专丙丙东.Invoke();
        this.业丁丄专丕专丙丙东 = 0;
    }
    private void 丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)
    {
        UnityEngine.Debug.LogError(message:  "Failed room connection!");
        if((this.connectionPanel != 0) && (this.connectionPanel.gameObject.activeSelf != false))
        {
                if(this.connectionPanel.failInternetLabel != 0)
        {
                this.connectionPanel.failInternetLabel.SetActive(value:  true);
        }
        
        }
        
        if(this.丈丑丈丒上丑东万丟 != false)
        {
                UnityEngine.Debug.LogError(message:  "Rejioning random room");
            this.上丁丅丏丄上丑丟丘();
            return;
        }
        
        this.与丆丈丗丄丒东丈丘();
    }
    public ConnectionControl()
    {
        this.丛且丞与丕业下丏丞 = 0;
    }

}
