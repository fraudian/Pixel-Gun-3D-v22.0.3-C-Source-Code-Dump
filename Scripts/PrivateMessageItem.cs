using UnityEngine;
public class PrivateMessageItem : AbstractMessageItem
{
    // Fields
    public bool isSquadChat;
    public UnityEngine.GameObject yourFonSprite;
    public UILabel yourMessageLabel;
    public UILabel yourTimeLabel;
    public UISprite yourSmileSprite;
    public UIWidget yourWidget;
    public UnityEngine.GameObject otherFonSprite;
    public UILabel otherMessageLabel;
    public UILabel otherTimeLabel;
    public UISprite otherSmileSprite;
    public UIWidget otherWidget;
    public PrivateMessageItem.丘丛丌丐业丏丗业丛 SelectTypeChat;
    
    // Methods
    private void Awake()
    {
        mem[1152921535982806912] = this.transform;
    }
    private void Start()
    {
        if(parent == 0)
        {
                return;
        }
        
        mem[1152921535982943480] = this.transform.parent.parent.GetComponent<UIPanel>();
    }
    public override void SetFon(bool 丌且下丕下下丌万丞)
    {
        this.yourWidget.transform.parent.gameObject.SetActive(value:  丌且下丕下下丌万丞);
        this.otherWidget.transform.parent.gameObject.SetActive(value:  (~丌且下丕下下丌万丞) & 1);
    }
    public override void SetBackground(东业专世丟不专不丕.丏丙丘丕丙且上不东 七丐丅专且专七三丆)
    {
    
    }
    public override void SetWidth(int 业与三万七丝不万东)
    {
        this.otherWidget.width = 业与三万七丝不万东;
        this.yourWidget.width = 业与三万七丝不万东;
    }
    private void Update()
    {
        if(this.isSquadChat != false)
        {
                return;
        }
        
        this.专丑丂丞专丛丅世丁();
    }
    private void 专丑丂丞专丛丅世丁()
    {
        object val_10;
        float val_11;
        val_10 = this;
        if(true != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = localPosition;
        val_11 = val_1.y;
        UnityEngine.Vector2 val_2 = clipOffset;
        UnityEngine.Vector4 val_3 = baseClipRegion;
        UnityEngine.Vector4 val_4 = baseClipRegion;
        float val_10 = -0.5f;
        val_10 = val_3.w * val_10;
        val_10 = val_2.y + val_10;
        val_10 = val_10 + val_4.y;
        if(val_11 < 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = localPosition;
        val_11 = val_5.y;
        UnityEngine.Vector2 val_6 = clipOffset;
        UnityEngine.Vector4 val_7 = baseClipRegion;
        UnityEngine.Vector4 val_8 = baseClipRegion;
        float val_11 = 0.5f;
        val_11 = val_7.w * val_11;
        val_11 = val_6.y + val_11;
        val_11 = val_11 + val_8.y;
        if(val_11 > val_11)
        {
                return;
        }
        
        if(this.SelectTypeChat == 3)
        {
            goto label_12;
        }
        
        if(this.SelectTypeChat == 2)
        {
            goto label_13;
        }
        
        if(this.SelectTypeChat != 1)
        {
            goto label_14;
        }
        
        this.一丈丛丛万下丞专上();
        return;
        label_12:
        this.东丗丕下丘丁三三三();
        return;
        label_13:
        this.丐丅丏丝丗业丞丘丏();
        return;
        label_14:
        object[] val_9 = new object[1];
        val_10 = this.SelectTypeChat;
        val_9[0] = val_10;
        UnityEngine.Debug.LogErrorFormat(format:  "Нет обработчика для этого типа чата: {0}", args:  val_9);
    }
    private void 东丗丕下丘丁三三三()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = 0;
        goto label_1;
        label_18:
        val_10 = null;
        val_10 = null;
        string val_9 = ChatController.丑丈万一下丗丘丄丘.Item[0];
        val_9 = val_9 + 16;
        if((val_9.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture).Equals(value:  val_9)) == false)
        {
            goto label_9;
        }
        
        val_11 = null;
        val_11 = null;
        业丙丅世丘东丛丄丕 val_5 = ChatController.丑丈万一下丗丘丄丘.Item[0];
        if(val_5.丑丈专丙丛专丁与一 == false)
        {
            goto label_14;
        }
        
        label_9:
        val_9 = 1;
        label_1:
        val_12 = null;
        val_12 = null;
        if(val_9 < ChatController.丑丈万一下丗丘丄丘.Count)
        {
            goto label_18;
        }
        
        return;
        label_14:
        mem[1152921535983779496] = 1;
        val_13 = null;
        val_13 = null;
        业丙丅世丘东丛丄丕 val_7 = ChatController.丑丈万一下丗丘丄丘.Item[0];
        val_7.丑丈专丙丛专丁与一 = true;
        int val_8 = ChatController.丗丟三丙丆丝三万丂();
        val_8 = val_8 - 1;
        ChatController.不与丒东丐丄丞下丁(丙业与丙丗丝不丈东:  val_8);
        ChatController.下七丆丈且丝丝丈一();
    }
    private void 一丈丛丛万下丞专上()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        string val_19;
        var val_20;
        System.Action<FriendPrevInChatItem> val_22;
        val_14 = 0;
        goto label_1;
        label_24:
        val_15 = null;
        val_15 = null;
        string val_14 = ChatController.丝丞不丘丞丐丌丅东.Item[PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerID].Item[0];
        val_14 = val_14 + 16;
        if((val_14.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture).Equals(value:  val_14)) == false)
        {
            goto label_11;
        }
        
        val_16 = null;
        val_16 = null;
        业丙丅世丘东丛丄丕 val_7 = ChatController.丝丞不丘丞丐丌丅东.Item[PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerID].Item[0];
        if(val_7.丑丈专丙丛专丁与一 == false)
        {
            goto label_18;
        }
        
        label_11:
        val_14 = 1;
        label_1:
        val_17 = null;
        val_17 = null;
        if(val_14 < ChatController.丝丞不丘丞丐丌丅东.Item[PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerID].Count)
        {
            goto label_24;
        }
        
        return;
        label_18:
        mem[1152921535983960104] = 1;
        val_18 = null;
        val_18 = null;
        val_19 = mem[PrivateChatController.丄丞丁丈与业上丞丟 + 24];
        val_19 = PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerID;
        业丙丅世丘东丛丄丕 val_11 = ChatController.丝丞不丘丞丐丌丅东.Item[val_19].Item[0];
        val_11.丑丈专丙丛专丁与一 = true;
        int val_15 = ChatController.丑万丂世丛丙万丝丛;
        val_15 = val_15 - 1;
        ChatController.丑万丂世丛丙万丝丛 = val_15;
        val_20 = null;
        val_20 = null;
        val_22 = PrivateMessageItem.<>c.<>9__21_0;
        if(val_22 == null)
        {
                System.Action<FriendPrevInChatItem> val_12 = null;
            val_22 = val_12;
            val_12 = new System.Action<FriendPrevInChatItem>(object:  PrivateMessageItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PrivateMessageItem.<>c::丕丝丛与丗不东专一(FriendPrevInChatItem 三丟东丕丄丄下下丑));
            PrivateMessageItem.<>c.<>9__21_0 = val_22;
        }
        
        FriendPrevInChatItem val_13 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<FriendPrevInChatItem>(丞下万上三丘上与专:  PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerItem, 丌专业且丛丏丞丝且:  val_12);
        ChatController.七三丒丅业业丄与一();
    }
    private void 丐丅丏丝丗业丞丘丏()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        string val_20;
        var val_21;
        System.Action<FriendPrevInChatItem> val_23;
        val_15 = 0;
        goto label_1;
        label_24:
        val_16 = null;
        val_16 = null;
        string val_15 = ChatController.丝三下丙七丈七丏丙.Item[PrivateClanChatController.丆丕丝丒不丙且丐丗.SelectedPlayerID].Item[0];
        val_15 = val_15 + 16;
        if((val_15.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture).Equals(value:  val_15)) == false)
        {
            goto label_11;
        }
        
        val_17 = null;
        val_17 = null;
        业丙丅世丘东丛丄丕 val_7 = ChatController.丝三下丙七丈七丏丙.Item[PrivateClanChatController.丆丕丝丒不丙且丐丗.SelectedPlayerID].Item[0];
        if(val_7.丑丈专丙丛专丁与一 == false)
        {
            goto label_18;
        }
        
        label_11:
        val_15 = 1;
        label_1:
        val_18 = null;
        val_18 = null;
        if(val_15 < ChatController.丝三下丙七丈七丏丙.Item[PrivateClanChatController.丆丕丝丒不丙且丐丗.SelectedPlayerID].Count)
        {
            goto label_24;
        }
        
        return;
        label_18:
        mem[1152921535984163240] = 1;
        val_19 = null;
        val_19 = null;
        val_20 = mem[PrivateClanChatController.丆丕丝丒不丙且丐丗 + 136];
        val_20 = PrivateClanChatController.丆丕丝丒不丙且丐丗.SelectedPlayerID;
        业丙丅世丘东丛丄丕 val_11 = ChatController.丝三下丙七丈七丏丙.Item[val_20].Item[0];
        val_11.丑丈专丙丛专丁与一 = true;
        int val_12 = ChatController.丗丟三丙丆丝三万丂();
        val_12 = val_12 - 1;
        ChatController.不与丒东丐丄丞下丁(丙业与丙丗丝不丈东:  val_12);
        val_21 = null;
        val_21 = null;
        val_23 = PrivateMessageItem.<>c.<>9__22_0;
        if(val_23 == null)
        {
                System.Action<FriendPrevInChatItem> val_13 = null;
            val_23 = val_13;
            val_13 = new System.Action<FriendPrevInChatItem>(object:  PrivateMessageItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PrivateMessageItem.<>c::丐丗且丄世与丒丙丗(FriendPrevInChatItem 三丟东丕丄丄下下丑));
            PrivateMessageItem.<>c.<>9__22_0 = val_23;
        }
        
        FriendPrevInChatItem val_14 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<FriendPrevInChatItem>(丞下万上三丘上与专:  PrivateClanChatController.丆丕丝丒不丙且丐丗.丗丄丞上丂丂丌丌丁, 丌专业且丛丏丞丝且:  val_13);
        ChatController.丁一三丙丁丝丕丄丗();
    }
    public PrivateMessageItem()
    {
    
    }

}
