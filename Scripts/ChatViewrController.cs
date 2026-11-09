using UnityEngine;
internal sealed class ChatViewrController : MonoBehaviour
{
    // Fields
    internal static ChatViewrController 丄丞丁丈与业上丞丟;
    public MyUIInput sendMessageInput;
    public MyUIInput sendMessageInputDater;
    public UnityEngine.GameObject fastCommands;
    public UnityEngine.Transform chatLabelsHolder;
    private System.Collections.Generic.List<ChatLabel> 丏丑专丑世丄丛丒专;
    public UnityEngine.GameObject buySmileBannerPrefab;
    public UnityEngine.Transform smilePanelTransform;
    public UnityEngine.GameObject smilesPanel;
    public UnityEngine.GameObject showSmileButton;
    public UnityEngine.GameObject hideSmileButton;
    public UnityEngine.GameObject buySmileButton;
    public UnityEngine.GameObject chatLabelPrefab;
    public UnityEngine.AudioClip sendChatClip;
    public bool isClanMode;
    public UIButton sendMessageButton;
    public UnityEngine.Transform bottomAnchor;
    public UITable labelTable;
    public UIScrollView scrollLabels;
    public bool isBuySmile;
    private float 七丏丌万上丏丐世上;
    public bool isShowSmilePanel;
    private bool 万与丄丌世丈七上一;
    
    // Methods
    private void Awake()
    {
        ChatViewrController val_14;
        var val_15;
        bool val_16;
        var val_17;
        System.Action val_18;
        System.Action val_19;
        System.Action val_20;
        val_14 = this;
        val_15 = null;
        val_15 = null;
        ChatViewrController.丄丞丁丈与业上丞丟 = val_14;
        this.isBuySmile = StickersController.不丕丗且丝与七丗丒();
        this.buySmileBannerPrefab.SetActive(value:  false);
        this.hideSmileButton.SetActive(value:  false);
        this.sendMessageInput.gameObject.SetActive(value:  false);
        this.sendMessageInput = this.sendMessageInputDater;
        this.fastCommands.SetActive(value:  false);
        val_16 = this.isBuySmile;
        if(this.showSmileButton == null)
        {
            goto label_10;
        }
        
        if(val_16 == false)
        {
            goto label_11;
        }
        
        label_14:
        this.showSmileButton.SetActive(value:  true);
        val_17 = 0;
        goto label_13;
        label_10:
        if(val_16 == true)
        {
            goto label_14;
        }
        
        label_11:
        this.showSmileButton.SetActive(value:  false);
        val_17 = 1;
        label_13:
        this.buySmileButton.SetActive(value:  true);
        if(this.sendMessageInput == 0)
        {
                return;
        }
        
        val_18 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardInter, b:  new System.Action(object:  this, method:  public System.Void ChatViewrController::SendMessageFromInput()));
        if(this.sendMessageInput == null)
        {
            goto label_20;
        }
        
        if(val_18 != null)
        {
            goto label_21;
        }
        
        goto label_24;
        label_20:
        if(val_18 == null)
        {
            goto label_24;
        }
        
        label_21:
        if(null != null)
        {
                val_18 = 0;
        }
        
        label_24:
        this.sendMessageInput.onKeyboardInter = val_18;
        val_19 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardCancel, b:  new System.Action(object:  this, method:  public System.Void ChatViewrController::CancelSendPrivateMessage()));
        if(this.sendMessageInput == null)
        {
            goto label_26;
        }
        
        if(val_19 != null)
        {
            goto label_27;
        }
        
        goto label_30;
        label_26:
        if(val_19 == null)
        {
            goto label_30;
        }
        
        label_27:
        if(null != null)
        {
                val_19 = 0;
        }
        
        label_30:
        this.sendMessageInput.onKeyboardCancel = val_19;
        val_20 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardVisible, b:  new System.Action(object:  this, method:  public System.Void ChatViewrController::OnKeyboardVisible()));
        if(this.sendMessageInput == null)
        {
            goto label_32;
        }
        
        if(val_20 != null)
        {
            goto label_33;
        }
        
        goto label_36;
        label_32:
        if(val_20 == null)
        {
            goto label_36;
        }
        
        label_33:
        if(null != null)
        {
                val_20 = 0;
        }
        
        label_36:
        this.sendMessageInput.onKeyboardVisible = val_20;
        System.Action val_12 = null;
        val_16 = val_12;
        val_12 = new System.Action(object:  this, method:  public System.Void ChatViewrController::OnKeyboardHide());
        val_14 = System.Delegate.Combine(a:  this.sendMessageInput.onKeyboardHide, b:  val_12);
        if(this.sendMessageInput == null)
        {
            goto label_38;
        }
        
        if(val_14 != null)
        {
            goto label_39;
        }
        
        goto label_42;
        label_38:
        if(val_14 == null)
        {
            goto label_42;
        }
        
        label_39:
        if(null != null)
        {
                val_14 = 0;
        }
        
        label_42:
        this.sendMessageInput.onKeyboardHide = val_14;
    }
    private void Start()
    {
        if(this.sendMessageInput == 0)
        {
                return;
        }
        
        this.sendMessageInput.isSelected = true;
    }
    private void OnEnable()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_4 = null;
            val_4 = null;
            丌与世丄业丙万丆丏(丙业与丙丗丝不丈东:  new Player_move_c.丂丄丕丒且东专丙丝(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ChatViewrController::与丌世东丑丆一丝丒()));
        }
        
        this.与丌世东丑丆一丝丒();
    }
    private void OnDisable()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        丅一丆丅且丑丄专且(丙业与丙丗丝不丈东:  new Player_move_c.丂丄丕丒且东专丙丝(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ChatViewrController::与丌世东丑丆一丝丒()));
    }
    private void 与丌世东丑丆一丝丒()
    {
        var val_8;
        var val_12;
        string val_23;
        string val_26;
        string val_30;
        UITable val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        val_42 = this;
        val_43 = null;
        val_43 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        val_44 = null;
        val_44 = null;
        val_45 = 1152921525660509248;
        val_46 = 1152921505093320704;
        goto label_10;
        label_19:
        this.丏丑专丑世丄丛丒专.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.labelTable.gameObject, 丑且不丕与专丄业丙:  this.chatLabelPrefab).GetComponent<ChatLabel>());
        label_10:
        if(this.丏丑专丑世丄丛丒专.Count < typeof(Player_move_c).__il2cppRuntimeField_5C0.Count)
        {
            goto label_19;
        }
        
        val_47 = 0;
        goto label_20;
        label_61:
        val_48 = null;
        val_48 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_30;
        }
        
        丝丄丌丏一专一丘丗 val_7 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        val_49 = null;
        val_49 = null;
        if(val_8 != (GetComponent<PhotonView>().viewID))
        {
            goto label_30;
        }
        
        val_50 = "[00FF26]";
        goto label_31;
        label_30:
        丝丄丌丏一专一丘丗 val_11 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        丝丄丌丏一专一丘丗 val_14 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        丝丄丌丏一专一丘丗 val_16 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        label_31:
        if(this.丏丑专丑世丄丛丒专 != null)
        {
                val_51 = this.丏丑专丑世丄丛丒专.Count;
        }
        else
        {
                val_51 = 0.Count;
        }
        
        ChatLabel val_21 = this.丏丑专丑世丄丛丒专.Item[val_51 + 0];
        丝丄丌丏一专一丘丗 val_22 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        val_21.nickLabel.text = (val_12 == 2) ? "[FF0000]" : ((val_12 == 1) ? "[0000FF]" : ((val_12 == 0) ? "[FFFF26]" : "[00FF26]"))((val_12 == 2) ? "[FF0000]" : ((val_12 == 1) ? "[0000FF]" : ((val_12 == 0) ? "[FFFF26]" : "[00FF26]"))) + val_23;
        丝丄丌丏一专一丘丗 val_25 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        val_45 = 1152921525660509248;
        bool val_28 = val_21.stickerObject.activeInHierarchy;
        if((System.String.IsNullOrEmpty(value:  val_26)) == false)
        {
            goto label_42;
        }
        
        if(val_28 == false)
        {
            goto label_45;
        }
        
        val_21.stickerObject.SetActive(value:  false);
        goto label_45;
        label_42:
        if(val_28 != true)
        {
                val_21.stickerObject.SetActive(value:  true);
        }
        
        丝丄丌丏一专一丘丗 val_29 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        val_21.iconSprite.spriteName = val_30;
        label_45:
        UnityEngine.Transform val_31 = val_21.iconSprite.transform;
        val_46 = val_21.nickLabel.width;
        if(val_31 != null)
        {
                UnityEngine.Vector3 val_33 = val_31.localPosition;
            val_52 = val_33.y;
        }
        else
        {
                UnityEngine.Vector3 val_34 = 0.localPosition;
            val_52 = val_34.y;
        }
        
        UnityEngine.Vector3 val_35 = val_31.localPosition;
        int val_36 = val_46 + 20;
        val_31.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        丝丄丌丏一专一丘丗 val_37 = typeof(Player_move_c).__il2cppRuntimeField_5C0.Item[0];
        this.丏丑专丑世丄丛丒专.Item[0].gameObject.SetActive(value:  true);
        val_47 = 1;
        label_20:
        if(val_47 < this.丏丑专丑世丄丛丒专.Count)
        {
            goto label_61;
        }
        
        val_42 = this.labelTable;
    }
    private void Update()
    {
        UIButton val_38;
        var val_39;
        float val_40;
        var val_41;
        var val_42;
        float val_43;
        float val_44;
        val_38 = this;
        if(this.isShowSmilePanel == false)
        {
            goto label_1;
        }
        
        val_39 = 0;
        UnityEngine.Vector3 val_1 = this.smilePanelTransform.localPosition;
        val_40 = -150f;
        if(val_1.y < 0)
        {
                this.smilesPanel.SetActive(value:  false);
            val_41 = 0;
            this.smilesPanel.SetActive(value:  true);
            UnityEngine.Vector3 val_2 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_3 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_5 = this.smilePanelTransform.localPosition;
            float val_7 = val_3.y + (UnityEngine.Time.deltaTime * 500f);
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  500f);
            val_42 = val_11.y;
            val_43 = val_11.x;
            val_44 = val_42;
            val_39 = 0;
            UnityEngine.Vector3 val_12 = this.smilePanelTransform.localPosition;
            if(val_12.y > val_40)
        {
                UnityEngine.Vector3 val_13 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_14 = this.smilePanelTransform.localPosition;
            val_43 = 0f;
            val_44 = 0f;
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = val_43, y = val_44, z = 0f};
            this.scrollLabels.ResetPosition();
            this.smilePanelTransform.gameObject.SetActive(value:  false);
            val_39 = 1;
            val_41 = 0;
            this.smilePanelTransform.gameObject.SetActive(value:  true);
        }
        
        }
        
        if(this.isShowSmilePanel == true)
        {
            goto label_34;
        }
        
        label_1:
        val_39 = 0;
        UnityEngine.Vector3 val_17 = this.smilePanelTransform.localPosition;
        val_40 = -314f;
        if(val_17.y > val_40)
        {
                UnityEngine.Vector3 val_18 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_19 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_21 = this.smilePanelTransform.localPosition;
            float val_38 = -500f;
            val_38 = UnityEngine.Time.deltaTime * val_38;
            float val_22 = val_19.y + val_38;
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  500f);
            val_42 = val_26.y;
            val_39 = 0;
            UnityEngine.Vector3 val_27 = this.smilePanelTransform.localPosition;
            if(val_27.y < 0)
        {
                UnityEngine.Vector3 val_28 = this.smilePanelTransform.localPosition;
            UnityEngine.Vector3 val_29 = this.smilePanelTransform.localPosition;
            this.smilePanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.scrollLabels.ResetPosition();
            this.smilePanelTransform.gameObject.SetActive(value:  false);
            val_39 = 1;
            val_41 = 0;
            this.smilePanelTransform.gameObject.SetActive(value:  true);
        }
        
        }
        
        label_34:
        if(((this.sendMessageButton ^ (System.String.IsNullOrEmpty(value:  this.sendMessageInput.value))) & 1) != 0)
        {
                return;
        }
        
        val_38 = this.sendMessageButton;
        var val_37 = (~(System.String.IsNullOrEmpty(value:  this.sendMessageInput.value))) & 1;
    }
    private void LateUpdate()
    {
        if(this.万与丄丌世丈七上一 == false)
        {
                return;
        }
        
        this.万与丄丌世丈七上一 = false;
        this.scrollLabels.ResetPosition();
    }
    public void ShowSmilePannelOnClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.isShowSmilePanel = true;
        this.showSmileButton.SetActive(value:  false);
        this.hideSmileButton.SetActive(value:  true);
        this.scrollLabels.ResetPosition();
    }
    public void HideSmilePannelOnClick()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.丘丆丝下专世业专三();
    }
    public void OnClickSendMessageFromButton()
    {
        if((System.String.IsNullOrEmpty(value:  this.sendMessageInput.value)) != true)
        {
                this.PostChat(三丈丌专丁七丟且下:  this.sendMessageInput.value);
            this.sendMessageInput.value = System.String.alignConst;
        }
        
        if(this.isShowSmilePanel != false)
        {
                this.丘丆丝下专世业专三();
        }
        
        this.万与丄丌世丈七上一 = true;
    }
    public void SendMessageFromInput()
    {
        if((System.String.IsNullOrEmpty(value:  this.sendMessageInput.value)) != true)
        {
                this.PostChat(三丈丌专丁七丟且下:  this.sendMessageInput.value);
            this.sendMessageInput.value = System.String.alignConst;
        }
        
        if(this.isShowSmilePanel == false)
        {
                return;
        }
        
        this.丘丆丝下专世业专三();
    }
    private void 丘丆丝下专世业专三()
    {
        this.isShowSmilePanel = false;
        this.showSmileButton.SetActive(value:  true);
        this.hideSmileButton.SetActive(value:  false);
    }
    public void CancelSendPrivateMessage()
    {
        this.sendMessageInput.value = System.String.alignConst;
    }
    public void OnKeyboardVisible()
    {
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
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.且丙与万万世丙丘丘());
    }
    public void OnKeyboardHide()
    {
        UnityEngine.Vector3 val_1 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_2 = this.bottomAnchor.localPosition;
        UnityEngine.Vector3 val_4 = this.bottomAnchor.localPosition;
        float val_6 = val_2.y - (this.七丏丌万上丏丐世上 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        this.bottomAnchor.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.且丙与万万世丙丘丘());
        this.smilePanelTransform.gameObject.SetActive(value:  false);
        this.smilePanelTransform.gameObject.SetActive(value:  true);
    }
    private System.Collections.IEnumerator 且丙与万万世丙丘丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ChatViewrController.丞丞丗丒七丑丗万丅();
    }
    public void PostChat(string 三丈丌专丁七丟且下)
    {
        var val_5;
        var val_6;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.sendChatClip);
        }
        
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        SendChat(丕丗丘丑丛与丑业丒:  三丈丌专丁七丟且下, 业上丏丏丑丂专丒世:  (this.isClanMode == true) ? 1 : 0, 丛丐丌丙丈七丛丛东:  System.String.alignConst);
    }
    public void HandleCloseChat()
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[Close Chat] pressed.");
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  PGCompany.GamepadCoreController.Instance.三丝丂丏一世丛丌东());
        this.CloseChat(丈丕丂丄下丘丗专丁:  false);
    }
    public void CloseChat(bool 丈丕丂丄下丘丗专丁 = False)
    {
        UnityEngine.GameObject val_18;
        object val_19;
        var val_20;
        var val_21;
        WeaponManager val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_27;
        var val_28;
        var val_29;
        if(丈丕丂丄下丘丗专丁 != true)
        {
                val_18 = this.buySmileBannerPrefab;
            if(val_18.activeSelf != false)
        {
                object[] val_3 = new object[2];
            val_18 = 丈丕丂丄下丘丗专丁;
            val_3[0] = val_18;
            val_19 = this.buySmileBannerPrefab.activeSelf;
            val_3[1] = val_19;
            UnityEngine.Debug.LogFormat(format:  "Ignoring CloseChat({0}), buySmiley: {1}", args:  val_3);
            return;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_69;
        }
        
        val_21 = null;
        val_21 = null;
        val_22 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_23;
        }
        
        val_22 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_22 == null)
        {
            goto label_24;
        }
        
        label_23:
        万丙丘丗丆业丐万世(丆与丈丏丟七丁东丛:  丙不丅丕三丂业东丕().丆丛专丑丘专丌不且(), 丛丝丗不丞丛丕七丏:  true, 与丁万东丌丑下丏丕:  1f, 七丗专上丄丙丝上丁:  true);
        typeof(Player_move_c).__il2cppRuntimeField_67C = 0;
        丟丞不丟丛丈且且丟();
        typeof(Player_move_c).__il2cppRuntimeField_550.gameObject.SetActive(value:  true);
        val_18 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_18 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_23 = null;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_41;
        }
        
        val_24 = null;
        if(null != 0)
        {
            goto label_47;
        }
        
        goto label_47;
        label_41:
        val_27 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_D48 == 0)
        {
            goto label_69;
        }
        
        val_28 = null;
        val_28 = null;
        val_25 = mem[typeof(Player_move_c).__il2cppRuntimeField_D48 + 184];
        val_25 = typeof(Player_move_c).__il2cppRuntimeField_D48 + 184;
        label_47:
        val_25.SetActive(value:  true);
        label_69:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        val_19 = 1152921505047580672;
        val_29 = null;
        val_29 = null;
        ChatViewrController.丄丞丁丈与业上丞丟 = 0;
        return;
        label_24:
    }
    private void OnDestroy()
    {
        System.Action val_10;
        System.Action val_11;
        System.Action val_12;
        System.Action val_13;
        var val_14;
        val_10 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardInter, value:  new System.Action(object:  this, method:  public System.Void ChatViewrController::SendMessageFromInput()));
        if(this.sendMessageInput == null)
        {
            goto label_2;
        }
        
        if(val_10 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_10 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_10 = 0;
        }
        
        label_6:
        this.sendMessageInput.onKeyboardInter = val_10;
        val_11 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardCancel, value:  new System.Action(object:  this, method:  public System.Void ChatViewrController::CancelSendPrivateMessage()));
        if(this.sendMessageInput == null)
        {
            goto label_8;
        }
        
        if(val_11 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_11 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_12:
        this.sendMessageInput.onKeyboardCancel = val_11;
        val_12 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardVisible, value:  new System.Action(object:  this, method:  public System.Void ChatViewrController::OnKeyboardVisible()));
        if(this.sendMessageInput == null)
        {
            goto label_14;
        }
        
        if(val_12 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_12 == null)
        {
            goto label_18;
        }
        
        label_15:
        if(null != null)
        {
                val_12 = 0;
        }
        
        label_18:
        this.sendMessageInput.onKeyboardVisible = val_12;
        val_13 = System.Delegate.Remove(source:  this.sendMessageInput.onKeyboardHide, value:  new System.Action(object:  this, method:  public System.Void ChatViewrController::OnKeyboardHide()));
        if(this.sendMessageInput == null)
        {
            goto label_20;
        }
        
        if(val_13 != null)
        {
            goto label_21;
        }
        
        goto label_24;
        label_20:
        if(val_13 == null)
        {
            goto label_24;
        }
        
        label_21:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_24:
        this.sendMessageInput.onKeyboardHide = val_13;
        val_14 = null;
        val_14 = null;
        ChatViewrController.丄丞丁丈与业上丞丟 = 0;
    }
    public void BuySmileOnClick()
    {
        this.buySmileBannerPrefab.SetActive(value:  true);
        this.sendMessageInput.isSelected = false;
        this.sendMessageInput.DeselectInput();
    }
    public ChatViewrController()
    {
        this.丏丑专丑世丄丛丒专 = new System.Collections.Generic.List<ChatLabel>();
    }
    private static ChatViewrController()
    {
    
    }

}
