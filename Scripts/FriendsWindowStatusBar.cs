using UnityEngine;
public sealed class FriendsWindowStatusBar : MonoBehaviour
{
    // Fields
    public UIButton clearAllInviteButton;
    public UILabel[] facebookButtonLabels;
    public UIWidget facebookContainer;
    public UILabel[] facebookInviteLabels;
    public UIWidget facebookRewardLabelContainer;
    public UILabel[] facebookRewardLabels;
    public UIWidget findContainer;
    public MyUIInput findFriendInput;
    public UIWidget inboxContainer;
    public UILabel messageFacebookLabel;
    public UIButton refreshButton;
    public UIButton sendMyIdButton;
    public UILabel warningMessageAboutLimit;
    private bool <丙丑与三专专丁丂丂>k__BackingField;
    
    // Properties
    internal bool 丛丄丘东丌丈丛丌丏 { get; set; }
    
    // Methods
    internal void 丑东上丞丒丟丟下三(bool 丙业与丙丗丝不丈东)
    {
        this.<丙丑与三专专丁丂丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丆世丁东丏丞不世三()
    {
        return (bool)this.<丙丑与三专专丁丂丂>k__BackingField;
    }
    private void Start()
    {
        object val_7;
        System.Action val_8;
        val_7 = this;
        if(this.findFriendInput == 0)
        {
                return;
        }
        
        val_8 = System.Delegate.Combine(a:  this.findFriendInput.onKeyboardInter, b:  new System.Action(object:  this, method:  public System.Void FriendsWindowStatusBar::OnClickFindFriendButton()));
        if(this.findFriendInput == null)
        {
            goto label_5;
        }
        
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_8 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_9:
        this.findFriendInput.onKeyboardInter = val_8;
        val_7 = System.Delegate.Combine(a:  this.findFriendInput.onKeyboardCancel, b:  new System.Action(object:  this, method:  public System.Void FriendsWindowStatusBar::OnClickCancelFindFriendButton()));
        if(this.findFriendInput == null)
        {
            goto label_11;
        }
        
        if(val_7 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_7 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_15:
        this.findFriendInput.onKeyboardCancel = val_7;
    }
    private void OnEnable()
    {
        var val_4 = null;
        this.warningMessageAboutLimit.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1416"), arg0:  与丂丏丛丞丞丒丟丄.下丑丑万丛丆丏业世, arg1:  与丂丏丛丞丞丒丟丄.下丑丑万丛丆丏业世);
        this.findFriendInput.defaultText = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1422");
        this.丘丙丘与丗丐不丞丈();
    }
    private void OnDestroy()
    {
        object val_7;
        System.Action val_8;
        val_7 = this;
        if(this.findFriendInput == 0)
        {
                return;
        }
        
        val_8 = System.Delegate.Remove(source:  this.findFriendInput.onKeyboardInter, value:  new System.Action(object:  this, method:  public System.Void FriendsWindowStatusBar::OnClickFindFriendButton()));
        if(this.findFriendInput == null)
        {
            goto label_5;
        }
        
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_8 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_9:
        this.findFriendInput.onKeyboardInter = val_8;
        val_7 = System.Delegate.Remove(source:  this.findFriendInput.onKeyboardCancel, value:  new System.Action(object:  this, method:  public System.Void FriendsWindowStatusBar::OnClickCancelFindFriendButton()));
        if(this.findFriendInput == null)
        {
            goto label_11;
        }
        
        if(val_7 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_7 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_15:
        this.findFriendInput.onKeyboardCancel = val_7;
    }
    private void 丘丙丘与丗丐不丞丈()
    {
        UILabel[] val_2;
        var val_3;
        val_2 = this.facebookButtonLabels;
        if(val_2 == null)
        {
                return;
        }
        
        if(this.facebookButtonLabels.Length == 0)
        {
                return;
        }
        
        val_3 = 0;
        goto label_3;
        label_10:
        this.facebookButtonLabels[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1582");
        val_2 = this.facebookButtonLabels;
        val_3 = 1;
        label_3:
        if(val_3 < this.facebookButtonLabels.Length)
        {
            goto label_10;
        }
    
    }
    private void 丅一上不丈丆丝丟下(string 丕丗丘丑丛与丑业丒)
    {
        UILabel[] val_1;
        var val_2;
        val_1 = this.facebookInviteLabels;
        if(val_1 == null)
        {
                return;
        }
        
        if(this.facebookInviteLabels.Length == 0)
        {
                return;
        }
        
        val_2 = 0;
        goto label_2;
        label_7:
        this.facebookInviteLabels[0].text = 丕丗丘丑丛与丑业丒;
        val_1 = this.facebookInviteLabels;
        val_2 = 1;
        label_2:
        if(val_2 < this.facebookInviteLabels.Length)
        {
            goto label_7;
        }
    
    }
    private void 丌世丟东丕业东丑丂(bool 专丄丕专东世世丈丑)
    {
        if(this.facebookButtonLabels.Length == 0)
        {
                return;
        }
        
        if(this.facebookInviteLabels.Length == 0)
        {
                return;
        }
        
        this.facebookButtonLabels[0].gameObject.SetActive(value:  (~专丄丕专东世世丈丑) & 1);
        this.facebookInviteLabels[0].gameObject.SetActive(value:  专丄丕专东世世丈丑);
    }
    private void 丘丟丄七丘业丒三丝(bool 与丈上不丛丆丝下丘, bool 丞一丗丌丏下丟与丈)
    {
        string val_6;
        string val_7;
        var val_8;
        val_6 = 丞一丗丌丏下丟与丈;
        与丈上不丛丆丝下丘 = 与丈上不丛丆丝下丘 | val_6;
        this.丌世丟东丕业东丑丂(专丄丕专东世世丈丑:  与丈上不丛丆丝下丘);
        UnityEngine.GameObject val_2 = this.facebookRewardLabelContainer.gameObject;
        if(val_2 == null)
        {
            goto label_2;
        }
        
        if(val_6 == false)
        {
            goto label_3;
        }
        
        label_8:
        val_2.SetActive(value:  false);
        if(与丈上不丛丆丝下丘 == false)
        {
            goto label_4;
        }
        
        val_7 = "Key_1437";
        goto label_7;
        label_2:
        if(val_6 == true)
        {
            goto label_8;
        }
        
        label_3:
        val_2.SetActive(value:  (~与丈上不丛丆丝下丘) & 1);
        val_8 = 0;
        goto label_9;
        label_14:
        val_6 = System.String.Format(format:  "+{0}", arg0:  10);
        this.facebookRewardLabels[0].text = val_6;
        val_8 = 1;
        label_9:
        if(val_8 < this.facebookRewardLabels.Length)
        {
            goto label_14;
        }
        
        return;
        label_4:
        val_7 = "Key_1582";
        label_7:
        this.丅一上不丈丆丝丟下(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7));
    }
    private void 丙世丝丁丄下丈丘丌(bool 丆丙东丘丒丌丌业丐)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.facebookContainer.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public void OnClickBackButton()
    {
        var val_1;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_1 = null;
        val_1 = null;
        FriendsWindowGUI.丆丕丝丒不丙且丐丗.丝东丐丝东三丈世丝();
    }
    private void 一业丞上丂丄世丘丆()
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        下丐丒丂丏一丝东丏.丑七不且上丗丁一世().丁万丑丛丘丙丏丌丙();
        FriendsWindowController.丆丕丝丒不丙且丐丗.丏丌一丌丅丄丏业丐(丙业与丙丗丝不丈东:  true);
    }
    private void 丒丕丕且专下丘与不()
    {
        var val_3;
        this.丙世丝丁丄下丈丘丌(丆丙东丘丒丌丌业丐:  false);
        val_3 = null;
        val_3 = null;
        if(FacebookController.业万专东上丝丛与丁 == 0)
        {
                return;
        }
        
        FacebookController.业万专东上丝丛与丁.不丑丘东与不丒万不(七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void FriendsWindowStatusBar::一业丞上丂丄世丘丆()), 丑下丐世丆且丝上丈:  false);
    }
    private void 丞丑上七丙东上丙丁()
    {
    
    }
    private void 丛丄与三万丄丞下不(bool 丑丒业丘丑东丕世丅)
    {
    
    }
    public void OnClickFacebookButton()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(FacebookController.且丈丄一丁丞丒丑东() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(FacebookController.业万专东上丝丛与丁 == 0)
        {
                return;
        }
        
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = FriendsWindowStatusBar.<>c.<>9__30_1;
        if(val_9 == null)
        {
                System.Action val_5 = null;
            val_9 = val_5;
            val_5 = new System.Action(object:  FriendsWindowStatusBar.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FriendsWindowStatusBar.<>c::丆丝丙万丘上丞丘丒());
            FriendsWindowStatusBar.<>c.<>9__30_1 = val_9;
        }
        
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void FriendsWindowStatusBar::丐业丕丑丄丟丏专丘()), 丆丒丅丁不且丛一业:  val_5);
    }
    public void OnClickFindFriendButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(FriendsWindowController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.findFriendInput.value)) != false)
        {
                return;
        }
        
        this.<丙丑与三专专丁丂丂>k__BackingField = true;
        FriendsWindowController.丆丕丝丒不丙且丐丗.下丕丗丕丁丟丁丛一(丂丐丄丁丆与丈丂上:  this.findFriendInput.value);
        this.findFriendInput.value = System.String.alignConst;
    }
    public void OnClickCancelFindFriendButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.findFriendInput.value = System.String.alignConst;
    }
    public void OnClickClearAllButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(FriendsWindowController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        FriendsWindowController.丆丕丝丒不丙且丐丗.OnClickClearAllInboxButton();
    }
    public void OnClickSendMyIdButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        FriendsController.三丙丏不丐丗一丕丌();
    }
    public void OnClickRefreshButton()
    {
        var val_3;
        var val_4;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_3 = null;
        val_3 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(FriendsWindowController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        FriendsWindowController.丆丕丝丒不丙且丐丗.三丝不丞且丗与上丞();
        val_4 = null;
        val_4 = null;
        this.Invoke(methodName:  "SetEnableRefreshButton", time:  与丂丏丛丞丞丒丟丄.上丅且丂丈丂万丘世);
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  false);
    }
    private void SetEnableRefreshButton()
    {
        if(this.refreshButton == null)
        {
            
        }
    
    }
    internal void 与下丛丐世丕丁丝不(bool 丛万不丞丝丌上万不)
    {
        this.丙世丝丁丄下丈丘丌(丆丙东丘丒丌丌业丐:  false);
        this.warningMessageAboutLimit.gameObject.SetActive(value:  丛万不丞丝丌上万不);
        this.findContainer.gameObject.SetActive(value:  false);
        this.inboxContainer.gameObject.SetActive(value:  false);
        this.refreshButton.gameObject.SetActive(value:  true);
    }
    internal void 丂丅万丑下东丏丈东(bool 丛万不丞丝丌上万不)
    {
        this.<丙丑与三专专丁丂丂>k__BackingField = false;
        this.丙世丝丁丄下丈丘丌(丆丙东丘丒丌丌业丐:  false);
        this.warningMessageAboutLimit.gameObject.SetActive(value:  丛万不丞丝丌上万不);
        this.findContainer.gameObject.SetActive(value:  (~丛万不丞丝丌上万不) & 1);
        this.inboxContainer.gameObject.SetActive(value:  false);
        this.refreshButton.gameObject.SetActive(value:  false);
    }
    public void OnClickInboxFriendsTab(bool 丘丘丁丐上且上丞业, bool 丛万不丞丝丌上万不)
    {
        bool val_11;
        this.丙世丝丁丄下丈丘丌(丆丙东丘丒丌丌业丐:  false);
        this.findContainer.gameObject.SetActive(value:  false);
        val_11 = 丛万不丞丝丌上万不 ^ 1 & 丘丘丁丐上且上丞业;
        this.inboxContainer.gameObject.SetActive(value:  val_11);
        if(val_11 != false)
        {
                if(UnityEngine.Application.platform != 8)
        {
                this.sendMyIdButton.gameObject.SetActive(value:  false);
            val_11 = this.sendMyIdButton.transform;
            UnityEngine.Vector3 val_9 = val_11.position;
            this.clearAllInviteButton.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        
        }
        
        this.refreshButton.gameObject.SetActive(value:  false);
    }
    public void OnClickChatTab()
    {
        this.丙世丝丁丄下丈丘丌(丆丙东丘丒丌丌业丐:  false);
        this.findContainer.gameObject.SetActive(value:  false);
        this.inboxContainer.gameObject.SetActive(value:  false);
        this.warningMessageAboutLimit.gameObject.SetActive(value:  false);
        this.refreshButton.gameObject.SetActive(value:  false);
    }
    public FriendsWindowStatusBar()
    {
    
    }
    private void 丐业丕丑丄丟丏专丘()
    {
        FacebookController.丟不丆丂且三丅世专(七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void FriendsWindowStatusBar::丒丕丕且专下丘与不()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  this, method:  System.Void FriendsWindowStatusBar::丞丑上七丙东上丙丁()), 与且专丈不万东一万:  "Friends");
    }

}
