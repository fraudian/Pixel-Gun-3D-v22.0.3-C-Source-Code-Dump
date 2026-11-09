using UnityEngine;
public class PrivateChatController : MonoBehaviour
{
    // Fields
    internal static PrivateChatController 丄丞丁丈与业上丞丟;
    public string selectedPlayerID;
    public FriendPrevInChatItem selectedPlayerItem;
    public UnityEngine.GameObject friendPreviewPrefab;
    public UnityEngine.GameObject messagePrefab;
    public MyUIInput sendMessageInput;
    public UIButton sendMessageButton;
    public UIWrapContent friendsWrap;
    public UITable messageTable;
    public UIScrollView scrollMessages;
    public UIScrollView scrollFriends;
    public UnityEngine.Transform smilesBtnContainer;
    public UnityEngine.Transform leftInputAnchor;
    public UnityEngine.Transform smilesBtnContainerWhenKeyboardOpen;
    private UIPanel 丁丟世丏丑丆且丁丏;
    private UIPanel 丄丘不丏丅三三万不;
    private UnityEngine.Transform 丕丆丟丂业不丝三丝;
    private UnityEngine.Transform 业下丆丝上丆丙七丙;
    private float 世丏一且下且丆丗丆;
    private float 丛业丑且丘世下七万;
    private float 上丁丌不专一丒丝丌;
    private float 丙丕丒丆丟丄丅世一;
    private float 丄下丆丂丞三不不上;
    public bool isShowSmilePanel;
    public UnityEngine.Transform smilePanelTransform;
    public UnityEngine.GameObject showSmileButton;
    public UnityEngine.GameObject hideSmileButton;
    public UnityEngine.GameObject buySmileButton;
    public UnityEngine.GameObject showSmileButtonSecond;
    public UnityEngine.GameObject hideSmileButtonSecond;
    public UnityEngine.GameObject buySmileButtonSecond;
    public bool isBuySmile;
    public UnityEngine.GameObject buySmileBannerPrefab;
    private bool 丏丕丅丂丑业一世丂;
    private System.Collections.Generic.List<string> 专丒丏丆一不丅丁丗;
    private System.Collections.Generic.List<string> 丟下丞丗丂三东三下;
    private System.Collections.Generic.List<ChatController.业丙丅世丘东丛丄丕> 丞丗丏丆丅不丑丄丒;
    private float 七丏丌万上丏丐世上;
    public UnityEngine.Transform bottomAnchor;
    public UIPanel panelSmiles;
    private System.Collections.Generic.List<PrivateMessageItem> 三丑万上丟下世上丆;
    private bool 且且下丕丕下世与丑;
    
    // Methods
    private void Awake()
    {
        var val_8;
        System.Action val_19;
        System.Action val_20;
        System.Action val_21;
        System.Action val_22;
        UnityEngine.GameObject val_23;
        var val_24;
        this.丛业丑且丘世下七万 = (float)this.friendsWrap.itemSize;
        this.业下丆丝上丆丙七丙 = this.scrollMessages.transform;
        this.丕丆丟丂业不丝三丝 = this.scrollFriends.transform;
        this.丄丘不丏丅三三万不 = this.scrollMessages.GetComponent<UIPanel>();
        this.丁丟世丏丑丆且丁丏 = this.scrollFriends.GetComponent<UIPanel>();
        PrivateChatController.丄丞丁丈与业上丞丟 = this;
        if(this.sendMessageInput == 0)
        {
            goto label_8;
        }
        
        val_19 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardInter, b:  new System.Action(object:  this, method:  public System.Void PrivateChatController::SendMessageFromInput()));
        if(this.sendMessageInput == null)
        {
            goto label_10;
        }
        
        if(val_19 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_19 == null)
        {
            goto label_14;
        }
        
        label_11:
        if(null != null)
        {
                val_19 = 0;
        }
        
        label_14:
        this.sendMessageInput.onKeyboardInter = val_19;
        val_20 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardCancel, b:  new System.Action(object:  this, method:  public System.Void PrivateChatController::CancelSendPrivateMessage()));
        if(this.sendMessageInput == null)
        {
            goto label_16;
        }
        
        if(val_20 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(val_20 == null)
        {
            goto label_20;
        }
        
        label_17:
        if(null != null)
        {
                val_20 = 0;
        }
        
        label_20:
        this.sendMessageInput.onKeyboardCancel = val_20;
        val_21 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardVisible, b:  new System.Action(object:  this, method:  public System.Void PrivateChatController::OnKeyboardVisible()));
        if(this.sendMessageInput == null)
        {
            goto label_22;
        }
        
        if(val_21 != null)
        {
            goto label_23;
        }
        
        goto label_26;
        label_22:
        if(val_21 == null)
        {
            goto label_26;
        }
        
        label_23:
        if(null != null)
        {
                val_21 = 0;
        }
        
        label_26:
        this.sendMessageInput.onKeyboardVisible = val_21;
        val_22 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardHide, b:  new System.Action(object:  this, method:  public System.Void PrivateChatController::OnKeyboardHide()));
        if(this.sendMessageInput == null)
        {
            goto label_28;
        }
        
        if(val_22 != null)
        {
            goto label_29;
        }
        
        goto label_32;
        label_28:
        if(val_22 == null)
        {
            goto label_32;
        }
        
        label_29:
        if(null != null)
        {
                val_22 = 0;
        }
        
        label_32:
        this.sendMessageInput.onKeyboardHide = val_22;
        label_8:
        UnityEngine.Vector3 val_15 = this.smilePanelTransform.localPosition;
        UnityEngine.Vector3 val_16 = this.smilePanelTransform.localPosition;
        val_8 = 0;
        this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.isShowSmilePanel = false;
        bool val_17 = StickersController.不丕丗且丝与七丗丒();
        this.isBuySmile = val_17;
        if(this.showSmileButton == null)
        {
            goto label_38;
        }
        
        if(val_17 == false)
        {
            goto label_39;
        }
        
        label_44:
        this.showSmileButton.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showSmileButtonSecond, 丏业丟一东丂东丘丛:  true);
        this.buySmileButton.SetActive(value:  false);
        val_23 = this.buySmileButtonSecond;
        val_24 = 0;
        goto label_43;
        label_38:
        if(val_17 == true)
        {
            goto label_44;
        }
        
        label_39:
        this.showSmileButton.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showSmileButtonSecond, 丏业丟一东丂东丘丛:  false);
        this.buySmileButton.SetActive(value:  true);
        val_23 = this.buySmileButtonSecond;
        val_24 = 1;
        label_43:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  true);
        this.hideSmileButton.SetActive(value:  false);
        this.hideSmileButtonSecond.SetActive(value:  false);
    }
    private void OnEnable()
    {
        string val_10;
        FriendsController.业丐丙丅丒丝丈丕丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateChatController::丗丟丄丒万七丆丁丑()));
        丌且下丛三丟三业丑.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateChatController::丗丟丄丒万七丆丁丑()));
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.UpdateFriendList(世丁万世一丂且丗七:  false));
        this.sendMessageInput.value = System.String.alignConst;
        val_10 = 0;
        if((System.String.IsNullOrEmpty(value:  this.selectedPlayerID)) != false)
        {
                val_10 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
            if(this.专丒丏丆一不丅丁丗.Count >= 1)
        {
                val_10 = 0;
            this.selectedPlayerID = this.专丒丏丆一不丅丁丗.Item[0];
        }
        
        }
        
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丞丑丏丈专三丞专不(丈丆丆丂且丝东丏丂:  val_10, 丐世丐上丁与丌七丒:  true));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.smilesBtnContainerWhenKeyboardOpen, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.IEnumerator 丞丑丏丈专三丞专不(string 丈丆丆丂且丝东丏丂, bool 丐世丐上丁与丌七丒 = True)
    {
        PrivateChatController.一三丗丑丟丁丝下万 val_1 = new PrivateChatController.一三丗丑丟丁丝下万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丐世丐上丁与丌七丒 = 丐世丐上丁与丌七丒;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnDisable()
    {
        this.OnKeyboardHide();
        this.HideSmilePannelOnClick();
        this.sendMessageInput.DeselectInput();
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateChatController::丗丟丄丒万七丆丁丑()));
        丌且下丛三丟三业丑.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateChatController::丗丟丄丒万七丆丁丑()));
    }
    private void 丏丝三业丝丐丗丛丕(bool 世丁万世一丂且丗七)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.UpdateFriendList(世丁万世一丂且丗七:  false));
    }
    private void 丗丟丄丒万七丆丁丑()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.UpdateFriendList(世丁万世一丂且丗七:  false));
    }
    private void OnDestroy()
    {
        object val_13;
        System.Delegate val_14;
        System.Action val_15;
        System.Action val_16;
        System.Action val_17;
        val_13 = this;
        System.Action val_1 = null;
        val_14 = 1152921535970458160;
        val_1 = new System.Action(object:  this, method:  System.Void PrivateChatController::丗丟丄丒万七丆丁丑());
        FriendsController.不丌丒丐丗丒丈万丛(丙业与丙丗丝不丈东:  val_1);
        丌且下丛三丟三业丑.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PrivateChatController::丗丟丄丒万七丆丁丑()));
        PrivateChatController.丄丞丁丈与业上丞丟 = 0;
        if(this.sendMessageInput == 0)
        {
                return;
        }
        
        val_15 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardInter, value:  new System.Action(object:  this, method:  public System.Void PrivateChatController::SendPrivateMessage()));
        if(this.sendMessageInput == null)
        {
            goto label_9;
        }
        
        if(val_15 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_15 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_15 = 0;
        }
        
        label_13:
        this.sendMessageInput.onKeyboardInter = val_15;
        val_16 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardCancel, value:  new System.Action(object:  this, method:  public System.Void PrivateChatController::CancelSendPrivateMessage()));
        if(this.sendMessageInput == null)
        {
            goto label_15;
        }
        
        if(val_16 != null)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(val_16 == null)
        {
            goto label_19;
        }
        
        label_16:
        if(null != null)
        {
                val_16 = 0;
        }
        
        label_19:
        this.sendMessageInput.onKeyboardCancel = val_16;
        val_17 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardVisible, value:  new System.Action(object:  this, method:  public System.Void PrivateChatController::OnKeyboardVisible()));
        if(this.sendMessageInput == null)
        {
            goto label_21;
        }
        
        if(val_17 != null)
        {
            goto label_22;
        }
        
        goto label_25;
        label_21:
        if(val_17 == null)
        {
            goto label_25;
        }
        
        label_22:
        if(null != null)
        {
                val_17 = 0;
        }
        
        label_25:
        this.sendMessageInput.onKeyboardVisible = val_17;
        System.Action val_11 = null;
        val_14 = val_11;
        val_11 = new System.Action(object:  this, method:  public System.Void PrivateChatController::OnKeyboardHide());
        val_13 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardHide, value:  val_11);
        if(this.sendMessageInput == null)
        {
            goto label_27;
        }
        
        if(val_13 != null)
        {
            goto label_28;
        }
        
        goto label_31;
        label_27:
        if(val_13 == null)
        {
            goto label_31;
        }
        
        label_28:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_31:
        this.sendMessageInput.onKeyboardHide = val_13;
    }
    private void 丝丁丅丈丁丁丂业丝(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        FriendPrevInChatItem val_1 = 丝三丁东丈丒世丅业.GetComponent<FriendPrevInChatItem>();
        val_1.myWrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  丝三丁东丈丒世丅业.GetComponent<FriendPrevInChatItem>());
    }
    private void 丞丙丞丅丘七丅不世(FriendPrevInChatItem 七丘丛下丒丅且丕且)
    {
        var val_18;
        var val_36;
        string val_37;
        System.Collections.Generic.IDictionary<System.String, System.Object> val_38;
        int val_39;
        val_36 = 七丘丛下丒丅且丕且;
        val_37 = this.专丒丏丆一不丅丁丗.Count;
        if(val_36 != null)
        {
                val_38 = val_36;
            val_39 = 七丘丛下丒丅且丕且.myWrapIndex;
        }
        else
        {
                val_38 = 76;
            val_39 = 0;
        }
        
        bool val_3 = val_36.gameObject.activeSelf;
        if(val_37 <= 0)
        {
            goto label_5;
        }
        
        if(val_3 != true)
        {
                val_36.gameObject.SetActive(value:  true);
        }
        
        val_37 = this.专丒丏丆一不丅丁丗.Item[0];
        System.Collections.Generic.Dictionary<System.String, System.String> val_6 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_38 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄();
        if((val_38.ContainsKey(key:  val_37)) == false)
        {
                return;
        }
        
        val_38 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().Item[val_37];
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_38, 下上丐丆丝丟丝丒不:  "player", 丙业与丙丗丝不丈东: out  0)) == false)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_15 = val_13.GetEnumerator();
        label_24:
        if((1300101968 & 1) == 0)
        {
            goto label_20;
        }
        
        ConfiguredValueTaskAwaiter val_19 = val_18.GetAwaiter();
        val_6.Add(key:  val_19._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToString(value:  val_19._value._obj));
        goto label_24;
        label_5:
        if(val_3 == false)
        {
                return;
        }
        
        val_36 = val_36.gameObject;
        val_36.SetActive(value:  false);
        return;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_36 != null)
        {
            goto label_29;
        }
        
        goto label_37;
        label_29:
        七丘丛下丒丅且丕且.playerID = val_37;
        val_36.UpdateCountNewMessage();
        goto label_38;
        label_37:
        mem[48] = val_37;
        0.UpdateCountNewMessage();
        label_38:
        七丘丛下丒丅且丕且.nickLabel.text = val_6.Item["nick"];
        七丘丛下丒丅且丕且.rank.spriteName = "Rank_" + val_6.Item["rank"];
        val_38 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().专丞丙丟丟丆不丌下(丄丒且丙三丆丟与丏:  val_37);
        UnityEngine.Texture2D val_32 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_38)) != true) ? 丂与专万与丐丌丏不.丑七不且上丗丁一世().且丆一下丆丙丙丈丄(丄丒且丙三丆丟与丏:  val_37) : (val_38), 丁丅丈丌丟世丗丗丟:  0);
        val_36 = val_36.GetComponent<UIToggle>();
        string val_35 = val_37;
        val_35 = System.String.op_Equality(a:  this.selectedPlayerID, b:  val_35);
        val_36.Set(丏业丟一东丂东丘丛:  val_35);
    }
    private int 丞东且下三不丐上世(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌)
    {
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        float val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>> val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        val_31 = null;
        val_31 = null;
        val_32 = 1152921525653717520;
        if((ChatController.丝丞不丘丞丐丌丅东.ContainsKey(key:  三丟东丕丄丄下下丑)) == false)
        {
            goto label_4;
        }
        
        val_33 = 1152921525653313184;
        val_34 = 1152921525653314208;
        val_35 = 0;
        val_36 = 0;
        val_37 = 0;
        goto label_5;
        label_20:
        val_38 = null;
        val_38 = null;
        业丙丅世丘东丛丄丕 val_3 = ChatController.丝丞不丘丞丐丌丅东.Item[三丟东丕丄丄下下丑].Item[0];
        val_39 = null;
        var val_4 = (D0 > val_37) ? (D0) : (val_37);
        val_39 = null;
        业丙丅世丘东丛丄丕 val_6 = ChatController.丝丞不丘丞丐丌丅东.Item[三丟东丕丄丄下下丑].Item[0];
        bool val_31 = val_6.丑丈专丙丛专丁与一;
        val_35 = 1;
        val_31 = val_31 ^ 1;
        val_36 = val_36 + val_31;
        label_5:
        val_40 = null;
        val_40 = null;
        if(val_35 < ChatController.丝丞不丘丞丐丌丅东.Item[三丟东丕丄丄下下丑].Count)
        {
            goto label_20;
        }
        
        goto label_21;
        label_4:
        val_36 = 0;
        val_37 = 0;
        label_21:
        val_41 = null;
        val_41 = null;
        if((ChatController.丝丞不丘丞丐丌丅东.ContainsKey(key:  丒丒丄丁且丄丆丂丌)) == false)
        {
            goto label_25;
        }
        
        val_33 = 1152921525653724688;
        val_34 = 1152921525653314208;
        val_42 = 0;
        val_43 = 0;
        val_44 = 0;
        goto label_26;
        label_41:
        val_45 = null;
        val_45 = null;
        业丙丅世丘东丛丄丕 val_11 = ChatController.丝丞不丘丞丐丌丅东.Item[丒丒丄丁且丄丆丂丌].Item[0];
        val_46 = null;
        var val_12 = (D0 > val_44) ? (D0) : (val_44);
        val_46 = null;
        业丙丅世丘东丛丄丕 val_14 = ChatController.丝丞不丘丞丐丌丅东.Item[丒丒丄丁且丄丆丂丌].Item[0];
        bool val_32 = val_14.丑丈专丙丛专丁与一;
        val_42 = 1;
        val_32 = val_32 ^ 1;
        val_43 = val_43 + val_32;
        label_26:
        val_47 = null;
        val_47 = null;
        if(val_42 < ChatController.丝丞不丘丞丐丌丅东.Item[丒丒丄丁且丄丆丂丌].Count)
        {
            goto label_41;
        }
        
        val_32 = 1152921525653717520;
        goto label_42;
        label_25:
        val_43 = 0;
        val_44 = 0;
        label_42:
        val_48 = null;
        val_48 = null;
        val_49 = ChatController.上上丅丏丙且专丙丆;
        if((val_49.ContainsKey(key:  三丟东丕丄丄下下丑)) == false)
        {
            goto label_46;
        }
        
        val_34 = 1152921525653724688;
        val_33 = 1152921525653313184;
        val_49 = 0;
        goto label_47;
        label_57:
        val_50 = null;
        val_50 = null;
        业丙丅世丘东丛丄丕 val_19 = ChatController.上上丅丏丙且专丙丆.Item[三丟东丕丄丄下下丑].Item[0];
        val_49 = 1;
        label_47:
        val_51 = null;
        val_51 = null;
        if(val_49 < ChatController.上上丅丏丙且专丙丆.Item[三丟东丕丄丄下下丑].Count)
        {
            goto label_57;
        }
        
        val_32 = 1152921525653717520;
        label_46:
        val_52 = null;
        val_52 = null;
        if((ChatController.上上丅丏丙且专丙丆.ContainsKey(key:  丒丒丄丁且丄丆丂丌)) == false)
        {
            goto label_61;
        }
        
        val_34 = 1152921525653313184;
        val_33 = 1152921525653314208;
        val_53 = 0;
        goto label_62;
        label_72:
        val_54 = null;
        val_54 = null;
        业丙丅世丘东丛丄丕 val_25 = ChatController.上上丅丏丙且专丙丆.Item[丒丒丄丁且丄丆丂丌].Item[0];
        val_53 = 1;
        label_62:
        val_55 = null;
        val_55 = null;
        val_49 = ChatController.上上丅丏丙且专丙丆.Item[丒丒丄丁且丄丆丂丌];
        if(val_53 < val_49.Count)
        {
            goto label_72;
        }
        
        label_61:
        if(val_36 != val_43)
        {
                return (int)(val_36 >= val_43) ? (-1) : 1;
        }
        
        var val_29 = (((D0 > val_37) ? (D0) : (val_37)) > ((D0 > val_44) ? (D0) : (val_44))) ? 0 : (0 + 1);
        return (int)(val_36 >= val_43) ? (-1) : 1;
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
        var val_4;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>(collection:  this.丟下丞丗丂三东三下);
        this.专丒丏丆一不丅丁丗 = val_1;
        val_1.Sort(comparison:  new System.Comparison<System.String>(object:  this, method:  System.Int32 PrivateChatController::丞东且下三不丐上世(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌)));
        val_4 = 0;
        goto label_3;
        label_6:
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  this.friendsWrap.GetComponentsInChildren<FriendPrevInChatItem>(includeInactive:  true)[0]);
        val_4 = 1;
        label_3:
        if(val_4 < val_3.Length)
        {
            goto label_6;
        }
    
    }
    public System.Collections.IEnumerator UpdateFriendList(bool 世丁万世一丂且丗七 = False)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PrivateChatController.丑丛丒下丗丆专丟丛();
    }
    public void SetSelectedPlayer(string 丈丆丆丂且丝东丏丂, bool 丐世丐上丁与丌七丒 = True)
    {
        UnityEngine.GameObject val_31;
        var val_32;
        var val_33;
        bool val_34;
        var val_35;
        float val_36;
        var val_37;
        this.selectedPlayerItem = 0;
        bool val_1 = System.String.IsNullOrEmpty(value:  丈丆丆丂且丝东丏丂);
        UnityEngine.GameObject val_2 = this.sendMessageInput.gameObject;
        if(val_2 == null)
        {
            goto label_2;
        }
        
        if(val_1 == false)
        {
            goto label_3;
        }
        
        label_10:
        val_2.SetActive(value:  false);
        this.showSmileButton.SetActive(value:  false);
        this.buySmileButton.SetActive(value:  false);
        this.hideSmileButton.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showSmileButtonSecond, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buySmileButtonSecond, 丏业丟一东丂东丘丛:  false);
        val_31 = this.hideSmileButtonSecond;
        val_32 = 0;
        goto label_9;
        label_2:
        if(val_1 == true)
        {
            goto label_10;
        }
        
        label_3:
        if(val_2.activeSelf != true)
        {
                this.sendMessageInput.gameObject.SetActive(value:  true);
        }
        
        if(this.isBuySmile == false)
        {
            goto label_14;
        }
        
        bool val_30 = this.isShowSmilePanel;
        val_30 = val_30 ^ 1;
        if(this.showSmileButton != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        this.showSmileButton.SetActive(value:  ((val_30 & 255) == true) ? 1 : 0);
        this.buySmileButton.SetActive(value:  (this.isBuySmile == false) ? 1 : 0);
        if(this.isBuySmile == false)
        {
            goto label_17;
        }
        
        if(this.hideSmileButton != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        this.hideSmileButton.SetActive(value:  (this.isShowSmilePanel == true) ? 1 : 0);
        if(this.isBuySmile == false)
        {
            goto label_19;
        }
        
        bool val_31 = this.isShowSmilePanel;
        val_31 = val_31 ^ 1;
        val_33 = val_31 & 255;
        goto label_20;
        label_14:
        if(this.showSmileButton != null)
        {
            goto label_21;
        }
        
        goto label_22;
        label_17:
        if(this.hideSmileButton != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_19:
        val_33 = 0;
        label_20:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showSmileButtonSecond, 丏业丟一东丂东丘丛:  (val_33 != 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buySmileButtonSecond, 丏业丟一东丂东丘丛:  (this.isBuySmile == false) ? 1 : 0);
        if(this.isBuySmile != false)
        {
                val_34 = this.isShowSmilePanel;
        }
        else
        {
                val_34 = 0;
        }
        
        val_31 = this.hideSmileButtonSecond;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  (val_34 != 0) ? 1 : 0);
        val_35 = 0;
        goto label_32;
        label_51:
        if((this.专丒丏丆一不丅丁丗.Item[0].Equals(value:  丈丆丆丂且丝东丏丂)) != false)
        {
                UnityEngine.Vector2 val_15 = this.丁丟世丏丑丆且丁丏.clipOffset;
            if((System.Math.Abs(val_15.y + 291f)) > 0f)
        {
                UnityEngine.Vector3 val_18 = this.scrollFriends.transform.localPosition;
            float val_19 = val_18.y + (-291f);
            val_19 = 0f - val_19;
            this.丆丛世七丄丛丅世七(丏丕丌丒丛三专丄丄:  val_19);
        }
        
            UnityEngine.Vector2 val_20 = this.丁丟世丏丑丆且丁丏.clipOffset;
            val_36 = System.Math.Abs(val_20.y + 291f);
            UnityEngine.Vector4 val_22 = this.丁丟世丏丑丆且丁丏.baseClipRegion;
            float val_23 = val_36 + val_22.w;
            val_23 = val_23 + (-42f);
            if(val_23 < 0)
        {
                UnityEngine.Vector3 val_25 = this.scrollFriends.transform.localPosition;
            val_36 = val_25.y;
            UnityEngine.Vector4 val_26 = this.丁丟世丏丑丆且丁丏.baseClipRegion;
            float val_27 = val_36 + (-291f);
            val_27 = val_27 + val_26.w;
            val_27 = val_27 + (-50f);
            val_27 = 0f - val_27;
            this.丆丛世七丄丛丅世七(丏丕丌丒丛三专丄丄:  val_27);
        }
        
        }
        
        val_35 = 1;
        label_32:
        if(val_35 < this.专丒丏丆一不丅丁丗.Count)
        {
            goto label_51;
        }
        
        val_37 = 0;
        goto label_52;
        label_59:
        T val_33 = this.friendsWrap.GetComponentsInChildren<FriendPrevInChatItem>(includeInactive:  true)[0];
        if((val_12[0x0][0] + 48.Equals(value:  丈丆丆丂且丝东丏丂)) != false)
        {
                this.selectedPlayerItem = val_12[0x0] + 32;
        }
        
        val_37 = 1;
        label_52:
        if(val_37 < val_12.Length)
        {
            goto label_59;
        }
        
        this.selectedPlayerID = 丈丆丆丂且丝东丏丂;
        this.专丌丘丁丂三上东丌(丗丆丄世世万丛丆丈:  true);
    }
    private void 丆丛世七丄丛丅世七(float 丏丕丌丒丛三专丄丄)
    {
        UIScrollView val_10;
        float val_11 = 42f;
        float val_10 = System.Math.Abs(丏丕丌丒丛三专丄丄);
        val_10 = this.scrollFriends;
        val_11 = val_10 / val_11;
        float val_2 = val_10 - ((float)W21 * 42);
        if(W21 >= 1)
        {
                var val_3 = (丏丕丌丒丛三专丄丄 < 0) ? 1 : 0;
            do
        {
            val_10 = this.scrollFriends;
        }
        while((W21 - 1) != 0);
        
        }
        
        var val_5 = (丏丕丌丒丛三专丄丄 < 0) ? (-val_2) : (val_2);
        UnityEngine.Vector3 val_8 = this.丁丟世丏丑丆且丁丏.transform.localPosition;
        SpringPanel val_9 = SpringPanel.Begin(丝三丁东丈丒世丅业:  this.丁丟世丏丑丆且丁丏.gameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丛上丟丌丄丗丁世与:  100000f);
    }
    public void UpdateMessageForSelectedUsers(bool 丗丆丄世世万丛丆丈 = False)
    {
        this.专丌丘丁丂三上东丌(丗丆丄世世万丛丆丈:  丗丆丄世世万丛丆丈);
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
        val_44 = this.丞丗丏丆丅不丑丄丒.Count;
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
        UnityEngine.Vector4 val_12 = this.丄丘不丏丅三三万不.baseClipRegion;
        val_49 = val_12.z;
        int val_13 = UnityEngine.Mathf.RoundToInt(f:  val_49);
        val_44 = this.丞丗丏丆丅不丑丄丒.Item[4194311];
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
    private void 专丌丘丁丂三上东丌(bool 丗丆丄世世万丛丆丈)
    {
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_61;
        this.丞丗丏丆丅不丑丄丒.Clear();
        if((System.String.IsNullOrEmpty(value:  this.selectedPlayerID)) != true)
        {
                val_49 = null;
            val_49 = null;
            if((ChatController.丝丞不丘丞丐丌丅东.ContainsKey(key:  this.selectedPlayerID)) != false)
        {
                val_50 = null;
            val_50 = null;
            this.丞丗丏丆丅不丑丄丒.AddRange(collection:  ChatController.丝丞不丘丞丐丌丅东.Item[this.selectedPlayerID]);
        }
        
            val_51 = null;
            val_51 = null;
            if((ChatController.上上丅丏丙且专丙丆.ContainsKey(key:  this.selectedPlayerID)) != false)
        {
                val_52 = null;
            val_52 = null;
            this.丞丗丏丆丅不丑丄丒.AddRange(collection:  ChatController.上上丅丏丙且专丙丆.Item[this.selectedPlayerID]);
        }
        
        }
        
        val_53 = null;
        val_53 = null;
        if((PrivateChatController.<>c.<>9__58_0) == null)
        {
            goto label_21;
        }
        
        label_87:
        this.丞丗丏丆丅不丑丄丒.Sort(comparison:  PrivateChatController.<>c.<>9__58_0);
        if(this.selectedPlayerItem == 0)
        {
            goto label_26;
        }
        
        this.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  this.selectedPlayerItem);
        goto label_26;
        label_46:
        UnityEngine.GameObject val_8 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.messageTable.gameObject, 丑且不丕与专丄业丙:  this.messagePrefab);
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
        
        val_16.SelectTypeChat = 1;
        this.三丑万上丟下世上丆.Add(item:  val_16);
        label_26:
        if(this.三丑万上丟下世上丆.Count < this.丞丗丏丆丅不丑丄丒.Count)
        {
            goto label_46;
        }
        
        goto label_47;
        label_65:
        if(this.三丑万上丟下世上丆 != null)
        {
                val_55 = this.三丑万上丟下世上丆.Count;
        }
        else
        {
                val_55 = 0.Count;
        }
        
        UnityEngine.Object.Destroy(obj:  this.三丑万上丟下世上丆.Item[val_55 - 1].gameObject);
        if(this.三丑万上丟下世上丆 != null)
        {
                val_56 = this.三丑万上丟下世上丆.Count;
        }
        else
        {
                val_56 = 0.Count;
        }
        
        this.三丑万上丟下世上丆.RemoveAt(index:  val_56 - 1);
        val_57 = 0;
        goto label_55;
        label_62:
        this.三丑万上丟下世上丆.Item[0].gameObject.name = 0.ToString();
        val_58 = 0;
        if(this.三丑万上丟下世上丆.Item[0] == null)
        {
                val_58 = 0;
        }
        
        mem2[0] = 0;
        val_57 = val_58 + 1;
        label_55:
        if(val_57 < this.三丑万上丟下世上丆.Count)
        {
            goto label_62;
        }
        
        label_47:
        if(this.三丑万上丟下世上丆.Count > this.丞丗丏丆丅不丑丄丒.Count)
        {
            goto label_65;
        }
        
        val_59 = null;
        val_59 = null;
        if((PrivateChatController.<>c.<>9__58_1) == null)
        {
            goto label_68;
        }
        
        label_91:
        val_61 = 0;
        this.messageTable.onCustomSort = PrivateChatController.<>c.<>9__58_1;
        goto label_70;
        label_73:
        this.丒丏丆世丅丟丆不一(丁丛丞丁上丅丅七业:  this.三丑万上丟下世上丆.Item[0]);
        val_61 = 1;
        label_70:
        if(val_61 < this.三丑万上丟下世上丆.Count)
        {
            goto label_73;
        }
        
        UnityEngine.Vector4 val_38 = this.丄丘不丏丅三三万不.baseClipRegion;
        UnityEngine.Vector3 val_40 = this.messageTable.transform.localPosition;
        UnityEngine.Vector3 val_42 = this.messageTable.transform.localPosition;
        this.messageTable.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.messageTable.repositionNow = true;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_46 = this.StartCoroutine(routine:  this.丑丄上东丛丂与丕世(丗丆丄世世万丛丆丈:  false));
        return;
        label_21:
        PrivateChatController.<>c.<>9__58_0 = new System.Comparison<业丙丅世丘东丛丄丕>(object:  PrivateChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PrivateChatController.<>c::不世丗上丁丌丕丙丛(ChatController.业丙丅世丘东丛丄丕 三丟东丕丄丄下下丑, ChatController.业丙丅世丘东丛丄丕 丒丒丄丁且丄丆丂丌));
        if(this.丞丗丏丆丅不丑丄丒 != null)
        {
            goto label_87;
        }
        
        goto label_87;
        label_68:
        PrivateChatController.<>c.<>9__58_1 = new System.Comparison<UnityEngine.Transform>(object:  PrivateChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PrivateChatController.<>c::丈业三丞丌丆丟丈七(UnityEngine.Transform 三丟东丕丄丄下下丑, UnityEngine.Transform 丒丒丄丁且丄丆丂丌));
        if(this.messageTable != null)
        {
            goto label_91;
        }
        
        goto label_91;
    }
    private System.Collections.IEnumerator 丑丄上东丛丂与丕世(bool 丗丆丄世世万丛丆丈)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PrivateChatController.一丅七不丅三七丙丂();
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
                this.panelSmiles.UpdateAnchors();
            this.smilePanelTransform.GetComponent<UISprite>().UpdateAnchors();
            this.leftInputAnchor.GetComponent<UIWidget>().UpdateAnchors();
        }
        
        if(this.isShowSmilePanel == false)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_3 = this.smilePanelTransform.localPosition;
        if(val_3.y < 0)
        {
                UnityEngine.Vector3 val_4 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_5 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_7 = this.smilePanelTransform.localPosition;
            float val_9 = val_5.y + (UnityEngine.Time.deltaTime * this.丄下丆丂丞三不不上);
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  this.丄下丆丂丞三不不上);
            val_40 = val_13.x;
            val_41 = val_13.z;
            val_42 = val_13.y;
            UnityEngine.Vector3 val_14 = this.smilePanelTransform.localPosition;
            if(val_14.y > this.上丁丌不专一丒丝丌)
        {
                UnityEngine.Vector3 val_15 = this.smilePanelTransform.localPosition;
            val_40 = this.上丁丌不专一丒丝丌;
            UnityEngine.Vector3 val_16 = this.smilePanelTransform.localPosition;
            val_42 = 0f;
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_42, z = 0f};
            this.scrollMessages.ResetPosition();
            this.smilePanelTransform.gameObject.SetActive(value:  false);
            val_43 = 0;
            this.smilePanelTransform.gameObject.SetActive(value:  true);
        }
        
        }
        
        if(this.isShowSmilePanel == true)
        {
            goto label_38;
        }
        
        label_7:
        UnityEngine.Vector3 val_19 = this.smilePanelTransform.localPosition;
        if(val_19.y > this.丙丕丒丆丟丄丅世一)
        {
                UnityEngine.Vector3 val_20 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_21 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_23 = this.smilePanelTransform.localPosition;
            float val_25 = val_21.y - (UnityEngine.Time.deltaTime * this.丄下丆丂丞三不不上);
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  this.丄下丆丂丞三不不上);
            val_40 = val_29.x;
            val_41 = val_29.z;
            UnityEngine.Vector3 val_30 = this.smilePanelTransform.localPosition;
            if(val_30.y < 0)
        {
                UnityEngine.Vector3 val_31 = this.smilePanelTransform.localPosition;
            val_40 = this.丙丕丒丆丟丄丅世一;
            UnityEngine.Vector3 val_32 = this.smilePanelTransform.localPosition;
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.scrollMessages.ResetPosition();
            this.smilePanelTransform.gameObject.SetActive(value:  false);
            val_43 = 0;
            this.smilePanelTransform.gameObject.SetActive(value:  true);
        }
        
        }
        
        label_38:
        bool val_36 = System.String.IsNullOrEmpty(value:  this.sendMessageInput.value);
        if(val_36 ^ this.sendMessageButton == true)
        {
                return;
        }
        
        val_39 = this.sendMessageButton;
        var val_38 = (~val_36) & 1;
    }
    public void CancelSendPrivateMessage()
    {
        this.sendMessageInput.value = System.String.alignConst;
    }
    public void OnKeyboardVisible()
    {
        if(this.且且下丕丕下世与丑 == true)
        {
                return;
        }
        
        this.且且下丕丕下世与丑 = true;
        this.七丏丌万上丏丐世上 = this.sendMessageInput.heightKeyboard;
        if(UnityEngine.Application.isEditor != false)
        {
                this.七丏丌万上丏丐世上 = 200f;
        }
        
        UnityEngine.Vector3 val_2 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_3 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_5 = this.bottomAnchor.localPosition;
        float val_7 = val_3.y + (this.七丏丌万上丏丐世上 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        this.bottomAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.sendMessageButton.gameObject.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.smilesBtnContainerWhenKeyboardOpen, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.smilesBtnContainer, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Vector3 val_9 = this.leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_10 = this.leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_11 = this.leftInputAnchor.localPosition;
        float val_14 = -162f;
        val_14 = val_9.x + val_14;
        this.leftInputAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.且丙与万万世丙丘丘());
    }
    private System.Collections.IEnumerator 且丙与万万世丙丘丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PrivateChatController.与东专一丅万丈丒上();
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
        float val_6 = val_2.y - (this.七丏丌万上丏丐世上 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        this.bottomAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.sendMessageButton.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.smilesBtnContainerWhenKeyboardOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.smilesBtnContainer, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3 val_8 = this.leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_9 = this.leftInputAnchor.localPosition;
        UnityEngine.Vector3 val_10 = this.leftInputAnchor.localPosition;
        float val_15 = 162f;
        val_15 = val_8.x + val_15;
        this.leftInputAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.且丙与万万世丙丘丘());
        this.smilePanelTransform.gameObject.SetActive(value:  false);
        this = this.smilePanelTransform.gameObject;
        this.SetActive(value:  true);
    }
    public void BuySmileOnClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.buySmileBannerPrefab.SetActive(value:  true);
        this.sendMessageInput.DeselectInput();
    }
    public void ShowSmilePannelOnClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.isShowSmilePanel = true;
        this.showSmileButton.SetActive(value:  false);
        this.showSmileButtonSecond.SetActive(value:  false);
        this.hideSmileButton.SetActive(value:  true);
        this.hideSmileButtonSecond.SetActive(value:  true);
        this.scrollMessages.ResetPosition();
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
        UnityEngine.GameObject val_1;
        var val_2;
        this.isShowSmilePanel = false;
        if(this.showSmileButton == null)
        {
            goto label_1;
        }
        
        if(this.isBuySmile == false)
        {
            goto label_2;
        }
        
        label_7:
        this.showSmileButton.SetActive(value:  true);
        this.buySmileButton.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showSmileButtonSecond, 丏业丟一东丂东丘丛:  true);
        val_1 = this.buySmileButtonSecond;
        val_2 = 0;
        goto label_6;
        label_1:
        if(this.isBuySmile == true)
        {
            goto label_7;
        }
        
        label_2:
        this.showSmileButton.SetActive(value:  false);
        this.buySmileButton.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showSmileButtonSecond, 丏业丟一东丂东丘丛:  false);
        val_1 = this.buySmileButtonSecond;
        val_2 = 1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
        this.hideSmileButton.SetActive(value:  false);
        this.hideSmileButtonSecond.SetActive(value:  false);
    }
    public void SendSmile(string 七不丌丆丕一丝不丁)
    {
        null = null;
        this.万丝丟万不不世万丆(丙专世东丑三丌丁七:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄 + 七不丌丆丕一丝不丁);
        this.HideSmilePannel();
    }
    public void SendMessageFromInput()
    {
        this.SendPrivateMessage();
        if(this.isShowSmilePanel == false)
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
        string val_16;
        object val_17;
        MyUIInput val_18;
        var val_19;
        string val_20;
        var val_21;
        val_16 = 丙专世东丑三丌丁七;
        val_17 = this;
        if((System.String.IsNullOrEmpty(value:  val_16)) != false)
        {
                val_18 = this.sendMessageInput;
            if((System.String.IsNullOrEmpty(value:  val_18.value)) == true)
        {
                return;
        }
        
            val_18 = this.sendMessageInput.value;
            val_19 = null;
            val_19 = null;
            if((val_18.Contains(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) == true)
        {
                return;
        }
        
        }
        
        val_18 = System.String.IsNullOrEmpty(value:  val_16);
        if(val_18 != false)
        {
                val_16 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  this.sendMessageInput.value);
        }
        
        ChatController.业丙丅世丘东丛丄丕 val_12 = new ChatController.业丙丅世丘东丛丄丕(专丙上丏世一丛世世:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下丘与业丗丙且业丑:  val_16, 专丐三丒下东丕世丟:  (double)专七专下且专三一且.上且一丈丐三丄一丆() + 10000000, 丄丘下丕丘丁丁三丕:  false, 丗下上丆一丕丂三丑:  true);
        val_12.丆丆东丕丛业丈东丑(丂丛世丄丏下七丄一:  this.selectedPlayerID, 丄丙下丝丛丒七丂丘:  val_12);
        if(val_12 != null)
        {
                val_20 = (ChatController.业丙丅世丘东丛丄丕)[1152921535976890944].丄丙下丝丛丒七丂丘;
        }
        else
        {
                val_20 = 64;
        }
        
        丄三万丑丑东且丁丙.丑七不且上丗丁一世().丆丘丟且一丕丏世丒(专丂丕丗丗东世丞下:  this.selectedPlayerID, 丕丗丘丑丛与丑业丒:  val_20, 丄丆万一丙丂丕不丐:  1.58101006669199E-322, 万丛丛专世丕世丙万:  true);
        if(val_18 != false)
        {
                val_18 = this.sendMessageInput;
            val_18.value = System.String.alignConst;
        }
        
        this.专丌丘丁丂三上东丌(丗丆丄世世万丛丆丈:  true);
        val_21 = null;
        val_21 = null;
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  false);
        if(this.selectedPlayerItem.myWrapIndex == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_14 = new System.Collections.Generic.List<System.String>(collection:  this.丟下丞丗丂三东三下);
        this.专丒丏丆一不丅丁丗 = val_14;
        System.Comparison<System.String> val_15 = null;
        val_18 = val_15;
        val_15 = new System.Comparison<System.String>(object:  this, method:  System.Int32 PrivateChatController::丞东且下三不丐上世(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌));
        val_14.Sort(comparison:  val_15);
        val_17 = this.scrollFriends;
        val_17.ResetPosition();
    }
    private void 丆丆东丕丛业丈东丑(string 丂丛世丄丏下七丄一, ChatController.业丙丅世丘东丛丄丕 丄丙下丝丛丒七丂丘)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        if((ChatController.上上丅丏丙且专丙丆.ContainsKey(key:  丂丛世丄丏下七丄一)) != false)
        {
            
        }
        else
        {
                val_6 = null;
            ChatController.上上丅丏丙且专丙丆.set_Item(key:  丂丛世丄丏下七丄一, value:  new System.Collections.Generic.List<业丙丅世丘东丛丄丕>());
        }
        
        val_7 = null;
        ChatController.上上丅丏丙且专丙丆.Item[丂丛世丄丏下七丄一].Add(item:  丄丙下丝丛丒七丂丘);
        ChatController.七三丒丅业业丄与一();
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
    public PrivateChatController()
    {
        this.世丏一且下且丆丗丆 = ;
        this.丛业丑且丘世下七万 = ;
        this.上丁丌不专一丒丝丌 = -150f;
        this.丙丕丒丆丟丄丅世一 = -314f;
        this.丄下丆丂丞三不不上 = 500f;
        this.selectedPlayerID = System.String.alignConst;
        this.专丒丏丆一不丅丁丗 = new System.Collections.Generic.List<System.String>();
        this.丟下丞丗丂三东三下 = new System.Collections.Generic.List<System.String>();
        this.丞丗丏丆丅不丑丄丒 = new System.Collections.Generic.List<业丙丅世丘东丛丄丕>();
        this.三丑万上丟下世上丆 = new System.Collections.Generic.List<PrivateMessageItem>();
    }

}
