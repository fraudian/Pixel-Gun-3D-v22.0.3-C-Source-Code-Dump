using UnityEngine;
internal sealed class PrivateClanChatController : PGBehaviour
{
    // Fields
    internal static PrivateClanChatController 丆丕丝丒不丙且丐丗;
    private UnityEngine.GameObject _playerUiPrefab;
    private UnityEngine.GameObject _messageUiPrefab;
    internal UnityEngine.GameObject 丞丌七丞丒丆丘丛丄;
    private UnityEngine.Transform _leftInputAnchor;
    private UnityEngine.Transform bottomAnchor;
    private UIPanel _playersScrollPanel;
    private UIWrapContent _playersWrapContent;
    private UIScrollView _playersScrollView;
    public string SelectedPlayerID;
    private UIPanel _messagesScrollPanel;
    private UITable _messagesTable;
    private UIScrollView _messegesScrollView;
    private MyUIInput _sendMessageInput;
    private UIButton _sendMessageButton;
    private UIPanel _smilesPanel;
    private UnityEngine.Transform _smilesButtonsContainer;
    private UnityEngine.Transform _smilePanelTransform;
    private UnityEngine.GameObject _showSmileButton;
    private UnityEngine.GameObject _hideSmileButton;
    private UnityEngine.GameObject _buySmileButton;
    private bool 丙七七丒下专七丌丐;
    public bool _isBoughtSmile;
    private float 不丐七丌丐下专业丐;
    private float 不丅丑上丑且世丕上;
    private float 丁不丘不东丄世丌不;
    private float 世三丐东丕丅丏三丅;
    private System.Collections.Generic.List<string> 上丟不万丌丗专丞丟;
    private FriendPrevInChatItem 丗丄丞上丂丂丌丌丁;
    private System.Collections.Generic.List<ChatController.业丙丅世丘东丛丄丕> 丕丏三丆丈东丕丟丙;
    private System.Collections.Generic.List<PrivateMessageItem> 三丑万上丟下世上丆;
    private bool 且且下丕丕下世与丑;
    
    // Properties
    internal FriendPrevInChatItem 专不丌下丗丅丗丝丏 { get; }
    
    // Methods
    internal FriendPrevInChatItem 丘丕丛专一丏丁丆丟()
    {
        return (FriendPrevInChatItem)this.丗丄丞上丂丂丌丌丁;
    }
    private void Awake()
    {
        PrivateClanChatController.丆丕丝丒不丙且丐丗 = this;
        this.上丈丞万丒上三业丗();
        this.三丛丘与与丑丅丗专();
        this.丂丐丆不上丑丕丆丁();
        this.丐丏丂一丂上七丂丆();
    }
    private void OnEnable()
    {
        var val_13;
        System.Func<System.String, System.Boolean> val_15;
        this.丛且丐下世与丘丆丗();
        this.丒万丙丕且丆丞丗丝();
        this._sendMessageInput.value = System.String.alignConst;
        if((System.String.IsNullOrEmpty(value:  this.SelectedPlayerID)) != false)
        {
                if(this.上丟不万丌丗专丞丟.Count >= 1)
        {
                this.SelectedPlayerID = this.上丟不万丌丗专丞丟.Item[0];
        }
        
        }
        
        this.SetSelectedPlayer(丈丆丆丂且丝东丏丂:  this.SelectedPlayerID, 丐世丐上丁与丌七丒:  false);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_15 = PrivateClanChatController.<>c.<>9__33_0;
        if(val_15 == null)
        {
                System.Func<System.String, System.Boolean> val_10 = null;
            val_15 = val_10;
            val_10 = new System.Func<System.String, System.Boolean>(object:  PrivateClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PrivateClanChatController.<>c::丏三不丐丛丏丘丑丑(string 三丟东丕丄丄下下丑));
            PrivateClanChatController.<>c.<>9__33_0 = val_15;
        }
        
        丂与专万与丐丌丏不.丑七不且上丗丁一世().上丂不东丝且丆丝丝(世丅丈东丘丐丕丟丐:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丌丂丑上七丄一且(), predicate:  val_10)));
    }
    private void OnDisable()
    {
        this.丞且东丒专丁万且七();
        this.OnKeyboardHide();
        this.HideSmilePannel();
        this._sendMessageInput.DeselectInput();
    }
    private void OnDestroy()
    {
        this.丞且东丒专丁万且七();
        this.三下丄下三三东丘与();
        PrivateClanChatController.丆丕丝丒不丙且丐丗 = 0;
    }
    private void 三丛丘与与丑丅丗专()
    {
        this._playersWrapContent.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PrivateClanChatController::丝丁丅丈丁丁丂业丝(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        UIDragScrollView val_3 = this._playerUiPrefab.transform.GetComponent<UIDragScrollView>();
        val_3.scrollView = this._playersWrapContent.GetComponent<UIScrollView>();
        object val_10 = 0;
        do
        {
            UnityEngine.GameObject val_6 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this._playersWrapContent.gameObject, 丑且不丕与专丄业丙:  this._playerUiPrefab);
            string val_7 = "playerUiItem_" + val_10;
            if(val_6 != null)
        {
                val_6.name = val_7;
        }
        else
        {
                0.name = val_7;
        }
        
            UIToggle val_8 = val_6.GetComponent<UIToggle>();
            val_8.group = 3;
            FriendPrevInChatItem val_9 = val_6.GetComponent<FriendPrevInChatItem>();
            val_10 = val_10 + 1;
            val_9.丌丅丘丏万丟上丕万 = true;
        }
        while(val_10 != 16);
        
        this._playersScrollView.ResetPosition();
        if(this._playersWrapContent != null)
        {
                return;
        }
    
    }
    private void 丂丐丆不上丑丕丆丁()
    {
        this.丙七七丒下专七丌丐 = false;
        this._isBoughtSmile = StickersController.不丕丗且丝与七丗丒();
        UnityEngine.Vector3 val_3 = this._smilePanelTransform.localPosition;
        UnityEngine.Vector3 val_4 = this._smilePanelTransform.localPosition;
        this._smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this._showSmileButton.SetActive(value:  (this._isBoughtSmile == true) ? 1 : 0);
        this._buySmileButton.SetActive(value:  (this._isBoughtSmile == false) ? 1 : 0);
        this._hideSmileButton.SetActive(value:  false);
    }
    private void 上丈丞万丒上三业丗()
    {
        if(this._messagesScrollPanel == 0)
        {
                this._messagesScrollPanel = this._messegesScrollView.GetComponent<UIPanel>();
        }
        
        if(this._playersScrollPanel != 0)
        {
                return;
        }
        
        this._playersScrollPanel = this._playersScrollView.GetComponent<UIPanel>();
    }
    private void 丐丏丂一丂上七丂丆()
    {
        object val_11;
        System.Action val_12;
        System.Action val_13;
        System.Action val_14;
        val_11 = this;
        if(this._sendMessageInput == 0)
        {
                return;
        }
        
        val_12 = System.Delegate.Combine(a:  this._sendMessageInput.onKeyboardInter, b:  new System.Action(object:  this, method:  public System.Void PrivateClanChatController::SendMessageFromInput()));
        if(this._sendMessageInput == null)
        {
            goto label_5;
        }
        
        if(val_12 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_12 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_12 = 0;
        }
        
        label_9:
        this._sendMessageInput.onKeyboardInter = val_12;
        val_13 = System.Delegate.Combine(a:  this._sendMessageInput.onKeyboardCancel, b:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::世七东丛与丈丙万丂()));
        if(this._sendMessageInput == null)
        {
            goto label_11;
        }
        
        if(val_13 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_13 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_15:
        this._sendMessageInput.onKeyboardCancel = val_13;
        val_14 = System.Delegate.Combine(a:  this._sendMessageInput.onKeyboardVisible, b:  new System.Action(object:  this, method:  public System.Void PrivateClanChatController::OnKeyboardVisible()));
        if(this._sendMessageInput == null)
        {
            goto label_17;
        }
        
        if(val_14 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_14 == null)
        {
            goto label_21;
        }
        
        label_18:
        if(null != null)
        {
                val_14 = 0;
        }
        
        label_21:
        this._sendMessageInput.onKeyboardVisible = val_14;
        val_11 = System.Delegate.Combine(a:  this._sendMessageInput.onKeyboardHide, b:  new System.Action(object:  this, method:  public System.Void PrivateClanChatController::OnKeyboardHide()));
        if(this._sendMessageInput == null)
        {
            goto label_23;
        }
        
        if(val_11 != null)
        {
            goto label_24;
        }
        
        goto label_27;
        label_23:
        if(val_11 == null)
        {
            goto label_27;
        }
        
        label_24:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_27:
        this._sendMessageInput.onKeyboardHide = val_11;
    }
    private void 三下丄下三三东丘与()
    {
        object val_11;
        System.Action val_12;
        System.Action val_13;
        System.Action val_14;
        val_11 = this;
        if(this._sendMessageInput == 0)
        {
                return;
        }
        
        val_12 = System.Delegate.Remove(source:  this._sendMessageInput.onKeyboardInter, value:  new System.Action(object:  this, method:  public System.Void PrivateClanChatController::SendPrivateMessage()));
        if(this._sendMessageInput == null)
        {
            goto label_5;
        }
        
        if(val_12 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_12 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_12 = 0;
        }
        
        label_9:
        this._sendMessageInput.onKeyboardInter = val_12;
        val_13 = System.Delegate.Remove(source:  this._sendMessageInput.onKeyboardCancel, value:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::世七东丛与丈丙万丂()));
        if(this._sendMessageInput == null)
        {
            goto label_11;
        }
        
        if(val_13 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_13 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_15:
        this._sendMessageInput.onKeyboardCancel = val_13;
        val_14 = System.Delegate.Remove(source:  this._sendMessageInput.onKeyboardVisible, value:  new System.Action(object:  this, method:  public System.Void PrivateClanChatController::OnKeyboardVisible()));
        if(this._sendMessageInput == null)
        {
            goto label_17;
        }
        
        if(val_14 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_14 == null)
        {
            goto label_21;
        }
        
        label_18:
        if(null != null)
        {
                val_14 = 0;
        }
        
        label_21:
        this._sendMessageInput.onKeyboardVisible = val_14;
        val_11 = System.Delegate.Remove(source:  this._sendMessageInput.onKeyboardHide, value:  new System.Action(object:  this, method:  public System.Void PrivateClanChatController::OnKeyboardHide()));
        if(this._sendMessageInput == null)
        {
            goto label_23;
        }
        
        if(val_11 != null)
        {
            goto label_24;
        }
        
        goto label_27;
        label_23:
        if(val_11 == null)
        {
            goto label_27;
        }
        
        label_24:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_27:
        this._sendMessageInput.onKeyboardHide = val_11;
    }
    private void 丛且丐下世与丘丆丗()
    {
        丄三万丑丑东且丁丙.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::丌丆上丌世下丑丝丆()));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::丒万丙丕且丆丞丗丝()));
        FriendsController.业丐丙丅丒丝丈丕丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::丒万丙丕且丆丞丗丝()));
    }
    private void 丞且东丒专丁万且七()
    {
        丄三万丑丑东且丁丙.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::丌丆上丌世下丑丝丆()));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::丒万丙丕且丆丞丗丝()));
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateClanChatController::丒万丙丕且丆丞丗丝()));
    }
    internal void 下丌丅七丒丛且丏七()
    {
        this._isBoughtSmile = true;
        this._buySmileButton.SetActive(value:  false);
        if(this.丙七七丒下专七丌丐 != false)
        {
                return;
        }
        
        this._showSmileButton.SetActive(value:  true);
    }
    private void 丒万丙丕且丆丞丗丝()
    {
        var val_24;
        var val_25;
        string val_26;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_2;
        }
        
        this.上丟不万丌丗专丞丟.Clear();
        val_24 = 0;
        goto label_4;
        label_20:
        string val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丂丄丏下七与一丌().Item[0].业丐丐三丕一丗丛丁();
        if((FriendsController.不丝丕丒丂丆丘丙丙().Equals(value:  val_7)) != true)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  val_7)) != null)
        {
                this.上丟不万丌丗专丞丟.Add(item:  val_7);
        }
        
        }
        
        val_24 = 1;
        label_4:
        if(val_24 < (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丂丄丏下七与一丌().Count))
        {
            goto label_20;
        }
        
        this.上丟不万丌丗专丞丟.Sort(comparison:  new System.Comparison<System.String>(object:  this, method:  System.Int32 PrivateClanChatController::丛丂且丆不不万丛丐(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌)));
        this._playersWrapContent.minIndex = -this.上丟不万丌丗专丞丟.Count;
        val_25 = 0;
        goto label_25;
        label_28:
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  this._playersWrapContent.GetComponentsInChildren<FriendPrevInChatItem>(includeInactive:  true)[0]);
        val_25 = 1;
        label_25:
        if(val_25 < val_19.Length)
        {
            goto label_28;
        }
        
        val_26 = 0;
        if((System.String.IsNullOrEmpty(value:  this.SelectedPlayerID)) != true)
        {
                val_25 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            val_26 = this.SelectedPlayerID;
            if((val_25.丕一下丒丝世下丘万(丞丅上丏丂且下丅与:  val_26)) != true)
        {
                this.SelectedPlayerID = System.String.alignConst;
            this.SetSelectedPlayer(丈丆丆丂且丝东丏丂:  System.String.alignConst, 丐世丐上丁与丌七丒:  false);
            this.OnKeyboardHide();
            val_26 = 0;
            this._sendMessageInput.DeselectInput();
        }
        
        }
        
        this._playersScrollView.ResetPosition();
        return;
        label_2:
        UnityEngine.Debug.LogError(message:  "ClansController.Instance.UserClan == null!! Такое возможно?!");
    }
    private void 丝丁丅丈丁丁丂业丝(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        FriendPrevInChatItem val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendPrevInChatItem>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<FriendPrevInChatItem>());
    }
    private void 丞丙丞丅丘七丅不世(FriendPrevInChatItem 七丘丛下丒丅且丕且)
    {
        var val_25;
        string val_26;
        int val_27;
        val_25 = 七丘丛下丒丅且丕且;
        val_25.上专丟丟丘上且丙丐(东丅丞丁丗万且丁丗:  false);
        if(val_25 != null)
        {
                val_26 = val_25;
            val_27 = 七丘丛下丒丅且丕且.myWrapIndex;
        }
        else
        {
                val_26 = 76;
            val_27 = 0;
        }
        
        bool val_3 = val_25.gameObject.activeSelf;
        if(this.上丟不万丌丗专丞丟.Count <= 0)
        {
            goto label_6;
        }
        
        if(val_3 != true)
        {
                val_25.gameObject.SetActive(value:  true);
        }
        
        string val_5 = this.上丟不万丌丗专丞丟.Item[0];
        七丈丗不丞丈丝丙七 val_8 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  val_5);
        if(val_8 == null)
        {
                return;
        }
        
        丌丌丄丂丕丑专万丆 val_9 = val_8.丙丐丅丕丗丁丅丁丐();
        if(val_25 == null)
        {
            goto label_15;
        }
        
        val_25.上专丟丟丘上且丙丐(东丅丞丁丗万且丁丗:  (val_9 == 1) ? 1 : 0);
        七丘丛下丒丅且丕且.playerID = val_5;
        val_25.UpdateCountNewMessage();
        goto label_16;
        label_6:
        if(val_3 == false)
        {
                return;
        }
        
        val_25.gameObject.SetActive(value:  false);
        return;
        label_15:
        0.上专丟丟丘上且丙丐(东丅丞丁丗万且丁丗:  (val_9 == 1) ? 1 : 0);
        mem[48] = val_5;
        0.UpdateCountNewMessage();
        label_16:
        七丘丛下丒丅且丕且.nickLabel.text = val_8.东丙上东业丆不丟丘();
        七丘丛下丒丅且丕且.rank.spriteName = "Rank_" + val_8.丙东专丂世丈丏丁丂();
        val_26 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().专丞丙丟丟丆不丌下(丄丒且丙三丆丟与丏:  val_5);
        UnityEngine.Texture2D val_22 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_26)) != true) ? 丂与专万与丐丌丏不.丑七不且上丗丁一世().且丆一下丆丙丙丈丄(丄丒且丙三丆丟与丏:  val_5) : (val_26), 丁丅丈丌丟世丗丗丟:  0);
        val_25 = val_25.GetComponent<UIToggle>();
        string val_25 = val_5;
        val_25 = System.String.op_Equality(a:  this.SelectedPlayerID, b:  val_25);
        val_25.Set(丏业丟一东丂东丘丛:  val_25);
    }
    private int 丛丂且丆不不万丛丐(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>> val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        float val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        float val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        val_39 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  三丟东丕丄丄下下丑);
        if(val_39.丙丐丅丕丗丁丅丁丐() == 1)
        {
                val_40 = 0;
            return (int)(val_46 >= val_53) ? (-1) : 1;
        }
        
        val_39 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  丒丒丄丁且丄丆丂丌);
        if(val_39.丙丐丅丕丗丁丅丁丐() == 1)
        {
                return (int)(val_46 >= val_53) ? (-1) : 1;
        }
        
        val_41 = null;
        val_41 = null;
        val_42 = 1152921525653717520;
        if((ChatController.丝三下丙七丈七丏丙.ContainsKey(key:  三丟东丕丄丄下下丑)) == false)
        {
            goto label_13;
        }
        
        val_43 = 1152921525653313184;
        val_44 = 1152921525653314208;
        val_45 = 0;
        val_46 = 0;
        val_47 = 0;
        goto label_14;
        label_29:
        val_48 = null;
        val_48 = null;
        业丙丅世丘东丛丄丕 val_11 = ChatController.丝三下丙七丈七丏丙.Item[三丟东丕丄丄下下丑].Item[0];
        val_49 = null;
        var val_12 = (D0 > val_47) ? (D0) : (val_47);
        val_49 = null;
        业丙丅世丘东丛丄丕 val_14 = ChatController.丝三下丙七丈七丏丙.Item[三丟东丕丄丄下下丑].Item[0];
        bool val_39 = val_14.丑丈专丙丛专丁与一;
        val_45 = 1;
        val_39 = val_39 ^ 1;
        val_46 = val_46 + val_39;
        label_14:
        val_50 = null;
        val_50 = null;
        if(val_45 < ChatController.丝三下丙七丈七丏丙.Item[三丟东丕丄丄下下丑].Count)
        {
            goto label_29;
        }
        
        goto label_30;
        label_13:
        val_46 = 0;
        val_47 = 0;
        label_30:
        val_51 = null;
        val_51 = null;
        if((ChatController.丝三下丙七丈七丏丙.ContainsKey(key:  丒丒丄丁且丄丆丂丌)) == false)
        {
            goto label_34;
        }
        
        val_43 = 1152921525653724688;
        val_44 = 1152921525653314208;
        val_52 = 0;
        val_53 = 0;
        val_54 = 0;
        goto label_35;
        label_50:
        val_55 = null;
        val_55 = null;
        业丙丅世丘东丛丄丕 val_19 = ChatController.丝三下丙七丈七丏丙.Item[丒丒丄丁且丄丆丂丌].Item[0];
        val_56 = null;
        var val_20 = (D0 > val_54) ? (D0) : (val_54);
        val_56 = null;
        业丙丅世丘东丛丄丕 val_22 = ChatController.丝三下丙七丈七丏丙.Item[丒丒丄丁且丄丆丂丌].Item[0];
        bool val_40 = val_22.丑丈专丙丛专丁与一;
        val_52 = 1;
        val_40 = val_40 ^ 1;
        val_53 = val_53 + val_40;
        label_35:
        val_57 = null;
        val_57 = null;
        if(val_52 < ChatController.丝三下丙七丈七丏丙.Item[丒丒丄丁且丄丆丂丌].Count)
        {
            goto label_50;
        }
        
        val_42 = 1152921525653717520;
        goto label_51;
        label_34:
        val_53 = 0;
        val_54 = 0;
        label_51:
        val_58 = null;
        val_58 = null;
        val_39 = ChatController.丕东丝丘丗丏不业七;
        if((val_39.ContainsKey(key:  三丟东丕丄丄下下丑)) == false)
        {
            goto label_55;
        }
        
        val_44 = 1152921525653724688;
        val_43 = 1152921525653313184;
        val_39 = 0;
        goto label_56;
        label_66:
        val_59 = null;
        val_59 = null;
        业丙丅世丘东丛丄丕 val_27 = ChatController.丕东丝丘丗丏不业七.Item[三丟东丕丄丄下下丑].Item[0];
        val_39 = 1;
        label_56:
        val_60 = null;
        val_60 = null;
        if(val_39 < ChatController.丕东丝丘丗丏不业七.Item[三丟东丕丄丄下下丑].Count)
        {
            goto label_66;
        }
        
        val_42 = 1152921525653717520;
        label_55:
        val_61 = null;
        val_61 = null;
        if((ChatController.丕东丝丘丗丏不业七.ContainsKey(key:  丒丒丄丁且丄丆丂丌)) == false)
        {
            goto label_70;
        }
        
        val_44 = 1152921525653313184;
        val_43 = 1152921525653314208;
        val_62 = 0;
        goto label_71;
        label_81:
        val_63 = null;
        val_63 = null;
        业丙丅世丘东丛丄丕 val_33 = ChatController.丕东丝丘丗丏不业七.Item[丒丒丄丁且丄丆丂丌].Item[0];
        val_62 = 1;
        label_71:
        val_64 = null;
        val_64 = null;
        val_39 = ChatController.丕东丝丘丗丏不业七.Item[丒丒丄丁且丄丆丂丌];
        if(val_62 < val_39.Count)
        {
            goto label_81;
        }
        
        label_70:
        if(val_46 != val_53)
        {
                return (int)(val_46 >= val_53) ? (-1) : 1;
        }
        
        var val_37 = (((D0 > val_47) ? (D0) : (val_47)) > ((D0 > val_54) ? (D0) : (val_54))) ? 0 : (0 + 1);
        return (int)(val_46 >= val_53) ? (-1) : 1;
    }
    internal bool 东丒丝丘万一丆世专()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        if(val_3 != null)
        {
                return val_3.activeSelf;
        }
        
        return val_3.activeSelf;
    }
    public void UpdateFriendItemsInfoAndSort()
    {
        var val_3;
        this.上丟不万丌丗专丞丟.Sort(comparison:  new System.Comparison<System.String>(object:  this, method:  System.Int32 PrivateClanChatController::丛丂且丆不不万丛丐(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌)));
        val_3 = 0;
        goto label_3;
        label_6:
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  this._playersWrapContent.GetComponentsInChildren<FriendPrevInChatItem>(includeInactive:  true)[0]);
        val_3 = 1;
        label_3:
        if(val_3 < val_2.Length)
        {
            goto label_6;
        }
    
    }
    public void SetSelectedPlayer(string 丈丆丆丂且丝东丏丂, bool 丐世丐上丁与丌七丒 = True)
    {
        var val_27;
        var val_28;
        float val_29;
        var val_30;
        this.丗丄丞上丂丂丌丌丁 = 0;
        bool val_1 = System.String.IsNullOrEmpty(value:  丈丆丆丂且丝东丏丂);
        UnityEngine.GameObject val_2 = this._sendMessageInput.gameObject;
        if(val_2 == null)
        {
            goto label_2;
        }
        
        if(val_1 == false)
        {
            goto label_3;
        }
        
        label_8:
        val_2.SetActive(value:  false);
        this._showSmileButton.SetActive(value:  false);
        this._buySmileButton.SetActive(value:  false);
        val_27 = 0;
        goto label_7;
        label_2:
        if(val_1 == true)
        {
            goto label_8;
        }
        
        label_3:
        if(val_2.activeSelf != true)
        {
                this._sendMessageInput.gameObject.SetActive(value:  true);
        }
        
        if(this._isBoughtSmile == false)
        {
            goto label_12;
        }
        
        bool val_27 = this.丙七七丒下专七丌丐;
        val_27 = val_27 ^ 1;
        if(this._showSmileButton != null)
        {
            goto label_46;
        }
        
        label_47:
        label_46:
        this._showSmileButton.SetActive(value:  ((val_27 & 255) == true) ? 1 : 0);
        this._buySmileButton.SetActive(value:  (this._isBoughtSmile == false) ? 1 : 0);
        if(this._isBoughtSmile == false)
        {
            goto label_15;
        }
        
        if(this._hideSmileButton != null)
        {
            goto label_48;
        }
        
        label_49:
        label_48:
        label_7:
        this._hideSmileButton.SetActive(value:  (this.丙七七丒下专七丌丐 == true) ? 1 : 0);
        val_28 = 0;
        goto label_17;
        label_36:
        if((this.上丟不万丌丗专丞丟.Item[0].Equals(value:  丈丆丆丂且丝东丏丂)) != false)
        {
                UnityEngine.Vector2 val_11 = this._playersScrollPanel.clipOffset;
            if((System.Math.Abs(val_11.y + 291f)) > 0f)
        {
                UnityEngine.Vector3 val_14 = this._playersScrollView.transform.localPosition;
            float val_15 = val_14.y + (-291f);
            val_15 = 0f - val_15;
            this.丆丛世七丄丛丅世七(丏丕丌丒丛三专丄丄:  val_15);
        }
        
            UnityEngine.Vector2 val_16 = this._playersScrollPanel.clipOffset;
            val_29 = System.Math.Abs(val_16.y + 291f);
            UnityEngine.Vector4 val_18 = this._playersScrollPanel.baseClipRegion;
            float val_19 = val_29 + val_18.w;
            val_19 = val_19 + (-42f);
            if(val_19 < 0)
        {
                UnityEngine.Vector3 val_21 = this._playersScrollView.transform.localPosition;
            val_29 = val_21.y;
            UnityEngine.Vector4 val_22 = this._playersScrollPanel.baseClipRegion;
            float val_23 = val_29 + (-291f);
            val_23 = val_23 + val_22.w;
            val_23 = val_23 + (-50f);
            val_23 = 0f - val_23;
            this.丆丛世七丄丛丅世七(丏丕丌丒丛三专丄丄:  val_23);
        }
        
        }
        
        val_28 = 1;
        label_17:
        if(val_28 < this.上丟不万丌丗专丞丟.Count)
        {
            goto label_36;
        }
        
        val_30 = 0;
        goto label_38;
        label_45:
        T val_29 = this._playersWrapContent.GetComponentsInChildren<FriendPrevInChatItem>(includeInactive:  true)[0];
        if((val_25[0x0][0] + 48.Equals(value:  丈丆丆丂且丝东丏丂)) != false)
        {
                this.丗丄丞上丂丂丌丌丁 = val_25[0x0] + 32;
        }
        
        val_30 = 1;
        label_38:
        if(val_30 < val_25.Length)
        {
            goto label_45;
        }
        
        this.SelectedPlayerID = 丈丆丆丂且丝东丏丂;
        this.丌丆上丌世下丑丝丆();
        return;
        label_12:
        if(this._showSmileButton != null)
        {
            goto label_46;
        }
        
        goto label_47;
        label_15:
        if(this._hideSmileButton != null)
        {
            goto label_48;
        }
        
        goto label_49;
    }
    private void 丆丛世七丄丛丅世七(float 丏丕丌丒丛三专丄丄)
    {
        UIScrollView val_10;
        float val_11 = 42f;
        float val_10 = System.Math.Abs(丏丕丌丒丛三专丄丄);
        val_10 = this._playersScrollView;
        val_11 = val_10 / val_11;
        float val_2 = val_10 - ((float)W21 * 42);
        if(W21 >= 1)
        {
                var val_3 = (丏丕丌丒丛三专丄丄 < 0) ? 1 : 0;
            do
        {
            val_10 = this._playersScrollView;
        }
        while((W21 - 1) != 0);
        
        }
        
        var val_5 = (丏丕丌丒丛三专丄丄 < 0) ? (-val_2) : (val_2);
        UnityEngine.Vector3 val_8 = this._playersScrollPanel.transform.localPosition;
        SpringPanel val_9 = SpringPanel.Begin(丝三丁东丈丒世丅业:  this._playersScrollPanel.gameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丛上丟丌丄丗丁世与:  100000f);
    }
    private void 丌丆上丌世下丑丝丆()
    {
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        int val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_54;
        this.丕丏三丆丈东丕丟丙.Clear();
        if((System.String.IsNullOrEmpty(value:  this.SelectedPlayerID)) != true)
        {
                val_43 = null;
            val_43 = null;
            if((ChatController.丝三下丙七丈七丏丙.ContainsKey(key:  this.SelectedPlayerID)) != false)
        {
                val_44 = null;
            val_44 = null;
            this.丕丏三丆丈东丕丟丙.AddRange(collection:  ChatController.丝三下丙七丈七丏丙.Item[this.SelectedPlayerID]);
        }
        
            val_45 = null;
            val_45 = null;
            if((ChatController.丕东丝丘丗丏不业七.ContainsKey(key:  this.SelectedPlayerID)) != false)
        {
                val_46 = null;
            val_46 = null;
            this.丕丏三丆丈东丕丟丙.AddRange(collection:  ChatController.丕东丝丘丗丏不业七.Item[this.SelectedPlayerID]);
        }
        
        }
        
        val_47 = null;
        val_47 = null;
        if((PrivateClanChatController.<>c.<>9__52_0) == null)
        {
            goto label_21;
        }
        
        label_83:
        this.丕丏三丆丈东丕丟丙.Sort(comparison:  PrivateClanChatController.<>c.<>9__52_0);
        if(this.丗丄丞上丂丂丌丌丁 == 0)
        {
            goto label_26;
        }
        
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  this.丗丄丞上丂丂丌丌丁);
        goto label_26;
        label_46:
        UnityEngine.GameObject val_8 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this._messagesTable.gameObject, 丑且不丕与专丄业丙:  this._messageUiPrefab);
        if((this.三丑万上丟下世上丆.ContainsKey(key:  public System.Boolean System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>>::ContainsKey(System.String key))) >= true)
        {
                UnityEngine.Vector3 val_13 = this.三丑万上丟下世上丆.Item[0].transform.position;
            val_8.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        
        string val_15 = this.三丑万上丟下世上丆.ContainsKey(key:  public System.Boolean System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>>::ContainsKey(System.String key)).ToString();
        if(val_8 != null)
        {
                val_8.name = val_15;
        }
        else
        {
                0.name = val_15;
        }
        
        PrivateMessageItem val_16 = val_8.GetComponent<PrivateMessageItem>();
        bool val_17 = this.三丑万上丟下世上丆.ContainsKey(key:  public System.Boolean System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>>::ContainsKey(System.String key));
        if(val_16 != null)
        {
                mem2[0] = val_17;
        }
        else
        {
                mem[56] = val_17;
        }
        
        val_16.SelectTypeChat = 2;
        this.三丑万上丟下世上丆.Add(item:  val_16);
        label_26:
        if(this.三丑万上丟下世上丆.Count < this.丕丏三丆丈东丕丟丙.Count)
        {
            goto label_46;
        }
        
        val_49 = this.丕丏三丆丈东丕丟丙.Count;
        goto label_48;
        label_53:
        this.三丑万上丟下世上丆.Item[val_49].gameObject.SetActive(value:  false);
        val_49 = val_49 + 1;
        label_48:
        if(val_49 < this.三丑万上丟下世上丆.Count)
        {
            goto label_53;
        }
        
        val_50 = 0;
        goto label_54;
        label_61:
        this.三丑万上丟下世上丆.Item[0].gameObject.name = 0.ToString();
        val_51 = 0;
        if(this.三丑万上丟下世上丆.Item[0] == null)
        {
                val_51 = 0;
        }
        
        mem2[0] = 0;
        val_50 = val_51 + 1;
        label_54:
        if(val_50 < this.三丑万上丟下世上丆.Count)
        {
            goto label_61;
        }
        
        val_52 = null;
        val_52 = null;
        if((PrivateClanChatController.<>c.<>9__52_1) == null)
        {
            goto label_64;
        }
        
        label_87:
        val_54 = 0;
        this._messagesTable.onCustomSort = PrivateClanChatController.<>c.<>9__52_1;
        goto label_66;
        label_69:
        this.丒丏丆世丅丟丆不一(丁丛丞丁上丅丅七业:  this.三丑万上丟下世上丆.Item[0]);
        val_54 = 1;
        label_66:
        if(val_54 < this.三丑万上丟下世上丆.Count)
        {
            goto label_69;
        }
        
        UnityEngine.Vector4 val_32 = this._messagesScrollPanel.baseClipRegion;
        UnityEngine.Vector3 val_34 = this._messagesTable.transform.localPosition;
        UnityEngine.Vector3 val_36 = this._messagesTable.transform.localPosition;
        this._messagesTable.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this._messagesTable.repositionNow = true;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_40 = this.StartCoroutine(routine:  this.丑丄上东丛丂与丕世());
        return;
        label_21:
        PrivateClanChatController.<>c.<>9__52_0 = new System.Comparison<业丙丅世丘东丛丄丕>(object:  PrivateClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PrivateClanChatController.<>c::丐丝丅三万丝丑丂世(ChatController.业丙丅世丘东丛丄丕 三丟东丕丄丄下下丑, ChatController.业丙丅世丘东丛丄丕 丒丒丄丁且丄丆丂丌));
        if(this.丕丏三丆丈东丕丟丙 != null)
        {
            goto label_83;
        }
        
        goto label_83;
        label_64:
        PrivateClanChatController.<>c.<>9__52_1 = new System.Comparison<UnityEngine.Transform>(object:  PrivateClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PrivateClanChatController.<>c::丅丏丈丅丒业丐丏且(UnityEngine.Transform 三丟东丕丄丄下下丑, UnityEngine.Transform 丒丒丄丁且丄丆丂丌));
        if(this._messagesTable != null)
        {
            goto label_87;
        }
        
        goto label_87;
    }
    private void 丒丏丆世丅丟丆不一(PrivateMessageItem 丁丛丞丁上丅丅七业)
    {
        var val_44;
        string val_45;
        var val_46;
        var val_47;
        UILabel val_48;
        float val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        float val_57;
        var val_58;
        float val_60;
        val_44 = this.丕丏三丆丈东丕丟丙.Count;
        if(丁丛丞丁上丅丅七业 != null)
        {
                val_45 = 丁丛丞丁上丅丅七业;
        }
        else
        {
                val_45 = 56;
            val_46 = 4194311;
        }
        
        bool val_3 = 丁丛丞丁上丅丅七业.gameObject.activeSelf;
        if(val_44 <= 4194311)
        {
            goto label_5;
        }
        
        if(val_3 != true)
        {
                丁丛丞丁上丅丅七业.gameObject.SetActive(value:  true);
        }
        
        if(丁丛丞丁上丅丅七业 == null)
        {
            goto label_9;
        }
        
        val_47 = 丁丛丞丁上丅丅七业.transform;
        goto label_10;
        label_5:
        if(val_3 == false)
        {
                return;
        }
        
        val_48 = 丁丛丞丁上丅丅七业.gameObject;
        val_48.SetActive(value:  false);
        return;
        label_9:
        val_47 = 丁丛丞丁上丅丅七业.transform;
        label_10:
        UnityEngine.Vector3 val_9 = 丁丛丞丁上丅丅七业.transform.localPosition;
        UnityEngine.Vector3 val_11 = 丁丛丞丁上丅丅七业.transform.localPosition;
        val_47.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector4 val_12 = this._messagesScrollPanel.baseClipRegion;
        val_49 = val_12.z;
        int val_13 = UnityEngine.Mathf.RoundToInt(f:  val_49);
        val_44 = this.丕丏三丆丈东丕丟丙.Item[4194311];
        mem2[0] = val_14.丑丈专丙丛专丁与一;
        mem2[0] = val_44 + 16.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture);
        if((val_14.三丏丙丗三专上上与.Equals(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_30;
        }
        
        val_50 = "";
        丁丛丞丁上丅丅七业.otherMessageLabel.text = "";
        val_51 = null;
        val_51 = null;
        if((val_14.丄丙下丝丛丒七丂丘.Contains(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) == false)
        {
            goto label_35;
        }
        
        val_52 = null;
        val_52 = null;
        val_45 = val_14.丄丙下丝丛丒七丂丘.Substring(startIndex:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄.Length);
        丁丛丞丁上丅丅七业.yourSmileSprite.spriteName = val_45;
        丁丛丞丁上丅丅七业.yourMessageLabel.text = "";
        丁丛丞丁上丅丅七业.yourMessageLabel.overflowMethod = 0;
        丁丛丞丁上丅丅七业.yourMessageLabel.height = 80;
        丁丛丞丁上丅丅七业.yourMessageLabel.width = 80;
        UnityEngine.GameObject val_23 = 丁丛丞丁上丅丅七业.yourSmileSprite.gameObject;
        val_53 = 1;
        goto label_47;
        label_30:
        val_50 = "";
        丁丛丞丁上丅丅七业.yourMessageLabel.text = "";
        val_54 = null;
        val_54 = null;
        val_45 = 与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄;
        if((val_14.丄丙下丝丛丒七丂丘.Contains(value:  val_45)) == false)
        {
            goto label_52;
        }
        
        val_55 = null;
        val_55 = null;
        val_45 = 与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄.Length;
        丁丛丞丁上丅丅七业.otherSmileSprite.spriteName = val_14.丄丙下丝丛丒七丂丘.Substring(startIndex:  val_45);
        丁丛丞丁上丅丅七业.otherMessageLabel.text = "";
        丁丛丞丁上丅丅七业.otherMessageLabel.overflowMethod = 0;
        丁丛丞丁上丅丅七业.otherMessageLabel.height = 80;
        丁丛丞丁上丅丅七业.otherMessageLabel.width = 80;
        val_44 = 丁丛丞丁上丅丅七业.otherSmileSprite.gameObject;
        val_56 = 1;
        goto label_64;
        label_35:
        丁丛丞丁上丅丅七业.yourMessageLabel.text = val_14.丄丙下丝丛丒七丂丘;
        丁丛丞丁上丅丅七业.yourMessageLabel.overflowMethod = 3;
        val_57 = (float)丁丛丞丁上丅丅七业.yourWidget.width * 0.8f;
        val_45 = UnityEngine.Mathf.CeilToInt(f:  val_57);
        丁丛丞丁上丅丅七业.yourMessageLabel.width = val_45;
        val_53 = 0;
        label_47:
        丁丛丞丁上丅丅七业.yourSmileSprite.gameObject.SetActive(value:  false);
        if(val_14.丏丟一专丙丏丄不丗 == false)
        {
            goto label_73;
        }
        
        System.DateTimeOffset val_31 = System.DateTimeOffset.Now;
        val_58 = val_31.m_dateTime.dateData.TotalSeconds;
        System.DateTime val_34 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (int)val_58 + 1152921505047314432);
        val_48 = 丁丛丞丁上丅丅七业.yourTimeLabel;
        goto label_78;
        label_52:
        丁丛丞丁上丅丅七业.otherMessageLabel.text = val_14.丄丙下丝丛丒七丂丘;
        丁丛丞丁上丅丅七业.otherMessageLabel.overflowMethod = 3;
        val_60 = (float)丁丛丞丁上丅丅七业.otherWidget.width * 0.8f;
        丁丛丞丁上丅丅七业.otherMessageLabel.width = UnityEngine.Mathf.CeilToInt(f:  val_60);
        val_44 = 丁丛丞丁上丅丅七业.otherSmileSprite.gameObject;
        val_56 = 0;
        label_64:
        val_44.SetActive(value:  false);
        System.DateTimeOffset val_38 = System.DateTimeOffset.Now;
        val_58 = val_38.m_dateTime.dateData.TotalSeconds;
        System.DateTime val_41 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (int)val_58 + 1152921505047314432);
        val_48 = 丁丛丞丁上丅丅七业.otherTimeLabel;
        label_78:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_48, 丕丗丘丑丛与丑业丒:  val_41.dateData.丅丞万丒丙丈丙丝丗(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_41.dateData}));
        return;
        label_73:
        丁丛丞丁上丅丅七业.yourTimeLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1556");
    }
    private System.Collections.IEnumerator 丑丄上东丛丂与丕世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PrivateClanChatController.丌七丝丈丝丂世丌丟();
    }
    private void Update()
    {
        UIButton val_39;
        float val_40;
        var val_41;
        float val_42;
        var val_43;
        val_39 = this;
        if(this.且且下丕丕下世与丑 != true)
        {
                this._smilesPanel.UpdateAnchors();
            this._smilePanelTransform.GetComponent<UISprite>().UpdateAnchors();
            this._leftInputAnchor.GetComponent<UIWidget>().UpdateAnchors();
        }
        
        if(this.丙七七丒下专七丌丐 == false)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_3 = this._smilePanelTransform.localPosition;
        if(val_3.y < 0)
        {
                UnityEngine.Vector3 val_4 = this._smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_5 = this._smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_7 = this._smilePanelTransform.localPosition;
            float val_9 = val_5.y + (UnityEngine.Time.deltaTime * this.丁不丘不东丄世丌不);
            this._smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  this.丁不丘不东丄世丌不);
            val_40 = val_13.x;
            val_41 = val_13.z;
            val_42 = val_13.y;
            UnityEngine.Vector3 val_14 = this._smilePanelTransform.localPosition;
            if(val_14.y > this.不丐七丌丐下专业丐)
        {
                UnityEngine.Vector3 val_15 = this._smilePanelTransform.localPosition;
            val_40 = this.不丐七丌丐下专业丐;
            UnityEngine.Vector3 val_16 = this._smilePanelTransform.localPosition;
            val_42 = 0f;
            this._smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_42, z = 0f};
            this._messegesScrollView.ResetPosition();
            this._smilePanelTransform.gameObject.SetActive(value:  false);
            val_43 = 0;
            this._smilePanelTransform.gameObject.SetActive(value:  true);
        }
        
        }
        
        if(this.丙七七丒下专七丌丐 == true)
        {
            goto label_38;
        }
        
        label_7:
        UnityEngine.Vector3 val_19 = this._smilePanelTransform.localPosition;
        if(val_19.y > this.不丅丑上丑且世丕上)
        {
                UnityEngine.Vector3 val_20 = this._smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_21 = this._smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_23 = this._smilePanelTransform.localPosition;
            float val_25 = val_21.y - (UnityEngine.Time.deltaTime * this.丁不丘不东丄世丌不);
            this._smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  this.丁不丘不东丄世丌不);
            val_40 = val_29.x;
            val_41 = val_29.z;
            UnityEngine.Vector3 val_30 = this._smilePanelTransform.localPosition;
            if(val_30.y < 0)
        {
                UnityEngine.Vector3 val_31 = this._smilePanelTransform.localPosition;
            val_40 = this.不丅丑上丑且世丕上;
            UnityEngine.Vector3 val_32 = this._smilePanelTransform.localPosition;
            this._smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._messegesScrollView.ResetPosition();
            this._smilePanelTransform.gameObject.SetActive(value:  false);
            val_43 = 0;
            this._smilePanelTransform.gameObject.SetActive(value:  true);
        }
        
        }
        
        label_38:
        bool val_36 = System.String.IsNullOrEmpty(value:  this._sendMessageInput.value);
        if(val_36 ^ this._sendMessageButton == true)
        {
                return;
        }
        
        val_39 = this._sendMessageButton;
        var val_38 = (~val_36) & 1;
    }
    private void 世七东丛与丈丙万丂()
    {
        this._sendMessageInput.value = System.String.alignConst;
    }
    public void OnKeyboardVisible()
    {
        if(this.且且下丕丕下世与丑 == true)
        {
                return;
        }
        
        this.且且下丕丕下世与丑 = true;
        this.世三丐东丕丅丏三丅 = this._sendMessageInput.heightKeyboard;
        if(UnityEngine.Application.isEditor != false)
        {
                this.世三丐东丕丅丏三丅 = 200f;
        }
        
        UnityEngine.Vector3 val_2 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_3 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_5 = this.bottomAnchor.localPosition;
        float val_7 = val_3.y + (this.世三丐东丕丅丏三丅 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        this.bottomAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this._sendMessageButton.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_9 = this._smilesButtonsContainer.localPosition;
        UnityEngine.Vector3 val_10 = this._smilesButtonsContainer.localPosition;
        UnityEngine.Vector3 val_11 = this._smilesButtonsContainer.localPosition;
        this._smilesButtonsContainer.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_12 = this._leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_13 = this._leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_14 = this._leftInputAnchor.localPosition;
        float val_17 = -162f;
        val_17 = val_12.x + val_17;
        this._leftInputAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.且丙与万万世丙丘丘());
    }
    private System.Collections.IEnumerator 且丙与万万世丙丘丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PrivateClanChatController.三且丅万丄丁丑万下();
    }
    public void OnKeyboardHide()
    {
        if(this.且且下丕丕下世与丑 == false)
        {
                return;
        }
        
        this.且且下丕丕下世与丑 = false;
        UnityEngine.Vector3 val_1 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_2 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_4 = this.bottomAnchor.localPosition;
        float val_6 = val_2.y - (this.世三丐东丕丅丏三丅 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        this.bottomAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this._sendMessageButton.gameObject.SetActive(value:  false);
        UnityEngine.Vector3 val_8 = this._smilesButtonsContainer.localPosition;
        UnityEngine.Vector3 val_9 = this._smilesButtonsContainer.localPosition;
        UnityEngine.Vector3 val_10 = this._smilesButtonsContainer.localPosition;
        this._smilesButtonsContainer.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_11 = this._leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_12 = this._leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_13 = this._leftInputAnchor.localPosition;
        float val_18 = 162f;
        val_18 = val_11.x + val_18;
        this._leftInputAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.且丙与万万世丙丘丘());
        this._smilePanelTransform.gameObject.SetActive(value:  false);
        this = this._smilePanelTransform.gameObject;
        this.SetActive(value:  true);
    }
    public void BuySmileOnClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丁业上丏不丕三丗不();
        }
        
        this.丞丌七丞丒丆丘丛丄.SetActive(value:  true);
        this._sendMessageInput.DeselectInput();
    }
    public void ShowSmilePannelOnClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.丙七七丒下专七丌丐 = true;
        this._showSmileButton.SetActive(value:  false);
        this._hideSmileButton.SetActive(value:  true);
        this._messegesScrollView.ResetPosition();
    }
    public void HideSmilePannelOnClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.HideSmilePannel();
    }
    public void HideSmilePannel()
    {
        var val_1;
        this.丙七七丒下专七丌丐 = false;
        if(this._showSmileButton == null)
        {
            goto label_0;
        }
        
        if(this._isBoughtSmile == false)
        {
            goto label_1;
        }
        
        label_4:
        this._showSmileButton.SetActive(value:  true);
        val_1 = 0;
        goto label_3;
        label_0:
        if(this._isBoughtSmile == true)
        {
            goto label_4;
        }
        
        label_1:
        this._showSmileButton.SetActive(value:  false);
        val_1 = 1;
        label_3:
        this._buySmileButton.SetActive(value:  true);
        this._hideSmileButton.SetActive(value:  false);
    }
    public void SendSmile(string 七不丌丆丕一丝不丁)
    {
        var val_6;
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        this.万丝丟万不不世万丆(丙专世东丑三丌丁七:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄 + 七不丌丆丕一丝不丁);
        this.HideSmilePannel();
    }
    public void SendMessageFromInput()
    {
        this.SendPrivateMessage();
        if(this.丙七七丒下专七丌丐 == false)
        {
                return;
        }
        
        this.HideSmilePannel();
    }
    public void SendPrivateMessage()
    {
        this.万丝丟万不不世万丆(丙专世东丑三丌丁七:  System.String.alignConst);
    }
    private void 万丝丟万不不世万丆(string 丙专世东丑三丌丁七)
    {
        string val_15;
        object val_16;
        MyUIInput val_17;
        var val_18;
        string val_19;
        var val_20;
        val_15 = 丙专世东丑三丌丁七;
        val_16 = this;
        if((System.String.IsNullOrEmpty(value:  val_15)) != false)
        {
                val_17 = this._sendMessageInput;
            if((System.String.IsNullOrEmpty(value:  val_17.value)) == true)
        {
                return;
        }
        
            val_17 = this._sendMessageInput.value;
            val_18 = null;
            val_18 = null;
            if((val_17.Contains(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) == true)
        {
                return;
        }
        
        }
        
        val_17 = System.String.IsNullOrEmpty(value:  val_15);
        if(val_17 != false)
        {
                val_15 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  this._sendMessageInput.value);
        }
        
        ChatController.业丙丅世丘东丛丄丕 val_12 = new ChatController.业丙丅世丘东丛丄丕(专丙上丏世一丛世世:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下丘与业丗丙且业丑:  val_15, 专丐三丒下东丕世丟:  (double)专七专下且专三一且.上且一丈丐三丄一丆() + 10000000, 丄丘下丕丘丁丁三丕:  false, 丗下上丆一丕丂三丑:  true);
        val_12.丆丆东丕丛业丈东丑(下丛丄丅丝丄丏丛丑:  this.SelectedPlayerID, 丄丙下丝丛丒七丂丘:  val_12);
        if(val_12 != null)
        {
                val_19 = (ChatController.业丙丅世丘东丛丄丕)[1152921536528810384].丄丙下丝丛丒七丂丘;
        }
        else
        {
                val_19 = 64;
        }
        
        丄三万丑丑东且丁丙.丑七不且上丗丁一世().丆丘丟且一丕丏世丒(专丂丕丗丗东世丞下:  this.SelectedPlayerID, 丕丗丘丑丛与丑业丒:  val_19, 丄丆万一丙丂丕不丐:  1.58101006669199E-322, 万丛丛专世丕世丙万:  false);
        if(val_17 != false)
        {
                val_17 = this._sendMessageInput;
            val_17.value = System.String.alignConst;
        }
        
        this.丌丆上丌世下丑丝丆();
        val_20 = null;
        val_20 = null;
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  false);
        if(this.丗丄丞上丂丂丌丌丁.myWrapIndex == 0)
        {
                return;
        }
        
        System.Comparison<System.String> val_14 = null;
        val_17 = val_14;
        val_14 = new System.Comparison<System.String>(object:  this, method:  System.Int32 PrivateClanChatController::丛丂且丆不不万丛丐(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌));
        this.上丟不万丌丗专丞丟.Sort(comparison:  val_14);
        val_16 = this._playersScrollView;
        val_16.ResetPosition();
    }
    private void 丆丆东丕丛业丈东丑(string 下丛丄丅丝丄丏丛丑, ChatController.业丙丅世丘东丛丄丕 丄丙下丝丛丒七丂丘)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        if((ChatController.丕东丝丘丗丏不业七.ContainsKey(key:  下丛丄丅丝丄丏丛丑)) != false)
        {
            
        }
        else
        {
                val_6 = null;
            ChatController.丕东丝丘丗丏不业七.set_Item(key:  下丛丄丅丝丄丏丛丑, value:  new System.Collections.Generic.List<业丙丅世丘东丛丄丕>());
        }
        
        val_7 = null;
        ChatController.丕东丝丘丗丏不业七.Item[下丛丄丅丝丄丏丛丑].Add(item:  丄丙下丝丛丒七丂丘);
        ChatController.丁一三丙丁丝丕丄丗();
    }
    private string 丅丞万丒丙丈丙丝丗(System.DateTime 不丗万丘丆丗上丗丏)
    {
        object[] val_1 = new object[5];
        string val_3 = 不丗万丘丆丗上丗丏.dateData.Day.ToString(format:  "D2");
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_3 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_3;
        val_1[1] = 不丗万丘丆丗上丗丏.dateData.Month.ToString(format:  "D2");
        val_1[2] = 不丗万丘丆丗上丗丏.dateData.Year;
        val_1[3] = 不丗万丘丆丗上丗丏.dateData.Hour;
        val_1[4] = 不丗万丘丆丗上丗丏.dateData.Minute.ToString(format:  "D2");
        return (string)System.String.Format(format:  "{0}.{1}.{2} {3}:{4}", args:  val_1);
    }
    public PrivateClanChatController()
    {
        this.不丐七丌丐下专业丐 = -150f;
        this.不丅丑上丑且世丕上 = -314f;
        this.丁不丘不东丄世丌不 = 500f;
        this.SelectedPlayerID = System.String.alignConst;
        this.上丟不万丌丗专丞丟 = new System.Collections.Generic.List<System.String>();
        this.丕丏三丆丈东丕丟丙 = new System.Collections.Generic.List<业丙丅世丘东丛丄丕>();
        this.三丑万上丟下世上丆 = new System.Collections.Generic.List<PrivateMessageItem>();
    }

}
