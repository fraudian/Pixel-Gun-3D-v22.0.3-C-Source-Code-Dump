using UnityEngine;
internal sealed class FriendsWindowGUI : MonoBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    internal static FriendsWindowGUI 丆丕丝丒不丙且丐丗;
    public UnityEngine.GameObject cameraObject;
    internal System.Action 丅丒丕丟丘世丘丐丐;
    public FriendsWindowController friendsWindow;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    
    // Properties
    internal bool 不丁丄丌丒上丅丂丟 { get; set; }
    
    // Methods
    private void Awake()
    {
        null = null;
        FriendsWindowGUI.丆丕丝丒不丙且丐丗 = this;
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
    }
    private void OnDestroy()
    {
        null = null;
        FriendsWindowGUI.丆丕丝丒不丙且丐丗 = 0;
    }
    internal void 不业丕丕丌一不丄丐(System.Action 丄丐丙丏业丐世丐丛)
    {
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        this.丅丒丕丟丘世丘丐丐 = 丄丐丙丏业丐世丐丛;
        if(this.friendsWindow.isActiveAndEnabled == false)
        {
                return;
        }
        
        this.friendsWindow.三丐丂不丐丄丑不七();
    }
    internal bool 上丙丆不丂丂丄一丂()
    {
        if(this.cameraObject != null)
        {
                return this.cameraObject.activeSelf;
        }
        
        return this.cameraObject.activeSelf;
    }
    private void 丟丁专丁丈丕丁一丙(bool 丙业与丙丗丝不丈东)
    {
        System.IDisposable val_6;
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.cameraObject.SetActive(value:  丙业与丙丗丝不丈东);
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
        }
        
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_7;
        }
        
        val_6 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void FriendsWindowGUI::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Friends");
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_12;
        label_7:
        val_6 = 0;
        if(this != null)
        {
            goto label_13;
        }
        
        label_12:
        label_13:
        this.且丂七丑丈丞丈三丑 = val_6;
    }
    internal void 丒丐一下丐丝丁丟世()
    {
        this.丆世与丑丆丅丐万且();
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丁丏一专丁七丝丞();
    }
    internal void 丝东丐丝东三丈世丝()
    {
        this.丆世与丑丆丅丐万且();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 丆世与丑丆丅丐万且()
    {
        if(this.丅丒丕丟丘世丘丐丐 != null)
        {
                this.丅丒丕丟丘世丘丐丐.Invoke();
        }
        
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丝丑丛万丟丝三上世();
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.friendsWindow.专丒丆丌丝丙上丙丐();
        this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        null = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.fortOpen != false)
        {
                return;
        }
        
        this.丝东丐丝东三丈世丝();
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return true;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public FriendsWindowGUI()
    {
    
    }
    private static FriendsWindowGUI()
    {
    
    }

}
