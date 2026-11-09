using UnityEngine;
internal sealed class FriendPreviewItem : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _callFriendButtonHolder;
    private UnityEngine.GameObject friendCallLabel;
    private UnityEngine.GameObject friendCalledLabel;
    private UnityEngine.GameObject callToSquadButton;
    private 丝丟万七上东丅丄丄 丌下丏丐丕丏不丗一;
    public UIButton acceptInviteButton;
    public UIButton addFriendButton;
    public UITexture avatarIcon;
    public string blinkButtonSprite;
    public UIButton cancelInviteButton;
    public UIWidget clanContainer;
    public UITexture clanIcon;
    public UILabel clanName;
    public UIButton connectToRoomButton;
    public UIButton connectToSquadButton;
    private string 丗丅丙丑丁丟东丂丏;
    public UILabel detailInfo;
    public UIWidget detailInfoConatiner;
    public UIWidget findFrinedsButtonContainer;
    private int 丑丟丅丂丞三专丏丒;
    public UIWidget friendAddContainer;
    public UIWidget friendListButtonContainer;
    public UIButton goToChat;
    public string id;
    public UIWidget inboxFriendsButtonContainer;
    public UISprite inFriendsIcon;
    public UIWidget invitationAddSentContainer;
    public UISprite invitedBackground;
    private bool 丐七丏丝丒丗丞丗丁;
    public UnityEngine.GameObject inYourNetworkIcon;
    public UILabel level;
    public UILabel levelAndName;
    public int myWrapIndex;
    private float 东丁丒三丑业丆与丒;
    public UISprite notConnectIcon;
    public UILabel notConnectLabel;
    public UISprite offlineIcon;
    public UIGrid playerDetailInfoGrid;
    public UISprite playingIcon;
    public UIWidget selfAddContainer;
    private int <丁丗万丈丕丈丏专丟>k__BackingField;
    
    // Properties
    public int 丘丛丕丈七丐不丒丂 { get; set; }
    private bool 丂丗丙与万丝世丈丕 { get; }
    private bool 七不专丞丕丅丂丟丂 { get; }
    
    // Methods
    private void 业七一下世丒万丟丗(int 丙业与丙丗丝不丈东)
    {
        this.<丁丗万丈丕丈丏专丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_OnlineCodeStatus()
    {
        return (int)this.<丁丗万丈丕丈丏专丟>k__BackingField;
    }
    private bool 丟丞丟丑丛丝不丗且()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>> val_15 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        if((val_15.ContainsKey(key:  this.id)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_4 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_15 = this.id;
        if((val_4.业丈丞丐万丄不上丄.ContainsKey(key:  val_15)) == false)
        {
                return false;
        }
        
        val_15 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        System.Collections.Generic.Dictionary<System.String, System.String> val_8 = val_15.Item[this.id];
        if(val_8 == null)
        {
                return false;
        }
        
        丆一丒上专万专下丞 val_9 = FriendsController.丞丒东七丝且上不下(丄且丆丘丆丏丄且东:  val_8);
        if(val_9 == null)
        {
                return false;
        }
        
        if(val_9.丝丅丛不丂专一丞与() != 15)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_11 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_15 = val_11.业丈丞丐万丄不上丄;
        if((val_15.ContainsKey(key:  this.id)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_13 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        return System.String.op_Equality(a:  val_9.丟上丅丛一丅丄不丙, b:  val_13.业丈丞丐万丄不上丄.Item[this.id]);
    }
    private bool 与丛丒下丕丁丕丗丛()
    {
        string val_19;
        string val_20;
        string val_21;
        val_19 = this;
        val_20 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        if((val_20.ContainsKey(key:  this.id)) == false)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_4 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_20 = this.id;
        if((val_4.一丒丈丈专上丝丝丞.ContainsKey(key:  val_20)) == false)
        {
                return false;
        }
        
        val_20 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        System.Collections.Generic.Dictionary<System.String, System.String> val_8 = val_20.Item[this.id];
        if(val_8 == null)
        {
                return false;
        }
        
        丆一丒上专万专下丞 val_9 = FriendsController.丞丒东七丝且上不下(丄且丆丘丆丏丄且东:  val_8);
        if(val_9 == null)
        {
                return false;
        }
        
        if(val_9.丝丅丛不丂专一丞与() != 18)
        {
                return false;
        }
        
        丄上三丛丛上一业三 val_11 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_20 = val_11.一丒丈丈专上丝丝丞;
        if((val_20.ContainsKey(key:  this.id)) == false)
        {
                return false;
        }
        
        val_20 = val_9.丟上丅丛一丅丄不丙;
        丄上三丛丛上一业三 val_13 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_19 = this.id;
        if((System.String.op_Equality(a:  val_20, b:  val_13.一丒丈丈专上丝丝丞.Item[val_19])) == false)
        {
                return false;
        }
        
        丞丂丘丒丟丞丑下丄 val_17 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_17 != null)
        {
                val_21 = val_17.业丐丐三丕一丗丛丁();
            if(val_9.丟上丅丛一丅丄不丙 != null)
        {
                return val_9.丟上丅丛一丅丄不丙.Equals(value:  val_21 = 0);
        }
        
            return val_9.丟上丅丛一丅丄不丙.Equals(value:  val_21);
        }
        
        if(val_9.丟上丅丛一丅丄不丙 != null)
        {
                return val_9.丟上丅丛一丅丄不丙.Equals(value:  val_21);
        }
        
        return val_9.丟上丅丛一丅丄不丙.Equals(value:  val_21);
    }
    private void Update()
    {
        if(this.丐七丏丝丒丗丞丗丁 == false)
        {
            goto label_0;
        }
        
        float val_1 = UnityEngine.Time.time;
        if(this.东丁丒三丑业丆与丒 >= 0)
        {
            goto label_1;
        }
        
        this.connectToRoomButton.normalSprite = this.丗丅丙丑丁丟东丂丏;
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + 1f;
        this.东丁丒三丑业丆与丒 = val_2;
        return;
        label_0:
        if(this.connectToRoomButton != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.connectToRoomButton.normalSprite = this.丗丅丙丑丁丟东丂丏;
        return;
        label_1:
        float val_3 = UnityEngine.Time.time;
        val_3 = val_3 + 0.5f;
        if(this.东丁丒三丑业丆与丒 >= 0)
        {
                return;
        }
        
        if(this.connectToRoomButton != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    private void Start()
    {
        System.Action val_5;
        this.丗丅丙丑丁丟东丂丏 = this.connectToRoomButton.normalSprite;
        if(((System.Delegate.Combine(a:  FriendsWindowController.丞世丑丁且丌丙丛专, b:  new System.Action(object:  this, method:  System.Void FriendPreviewItem::不与丒不丆丒东一丌()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        FriendsWindowController.丞世丑丁且丌丙丛专 = val_5;
    }
    private UnityEngine.Color[] 一不一东与丗七下不(UnityEngine.Color[] 丅丏东三丆丙且业专, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一)
    {
        UnityEngine.Color val_2;
        UnityEngine.Color[] val_1 = new UnityEngine.Color[0];
        int val_3 = 业与三万七丝不万东;
        val_3 = val_3 - 1;
        if()
        {
                return val_1;
        }
        
        var val_10 = 0;
        do
        {
            if(丟丌丐丘丆丙丑丑一 >= 1)
        {
                int val_8 = 丟丌丐丘丆丙丑丑一;
            var val_9 = 0;
            do
        {
            int val_4 = val_3;
            val_4 = val_4 + val_9;
            val_2 = 丅丏东三丆丙且业专[(long)val_4];
            val_1[(long)val_10 + val_9] = 丅丏东三丆丙且业专[(long)val_4];
            val_1[(long)val_10 + val_9] = 丅丏东三丆丙且业专[(long)val_4];
            val_1[(long)val_10 + val_9] = val_2;
            val_1[(long)val_10 + val_9] = 丅丏东三丆丙且业专[(long)val_4];
            val_8 = val_8 - 1;
            val_9 = val_9 + 业与三万七丝不万东;
        }
        while(val_8 != 0);
        
        }
        
            val_10 = val_10 + 1;
            int val_11 = val_3;
            val_11 = val_11 - 1;
        }
        while(val_10 != 业与三万七丝不万东);
        
        return val_1;
    }
    internal void 上丈一万东三东世东(string 丘丈下丛丙丝世丗丏)
    {
        if((this.avatarIcon != 0) && ((this.avatarIcon.name.Equals(value:  "dude")) != true))
        {
                if((this.avatarIcon.name.Equals(value:  "multi_skin_1")) != true)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.avatarIcon, allowDestroyingAssets:  true);
        }
        
        }
        
        UnityEngine.Texture2D val_6 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  丘丈下丛丙丝世丗丏, 丁丅丈丌丟世丗丗丟:  1);
        if(this.avatarIcon == null)
        {
            
        }
    
    }
    public void HandleCallToSquad()
    {
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void FriendPreviewItem::且丅丙丑下东丂丅丅()))) != false)
        {
                return;
        }
        
        this.且丅丙丑下东丂丅丅();
    }
    private void 且丅丙丑下东丂丅丅()
    {
        FriendsWindowController.丆丕丝丒不丙且丐丗.且丅丙丑下东丂丅丅(丝丕与丝东与丗丁世:  this.id);
    }
    public void HandleCallFriend()
    {
    
    }
    private System.Collections.IEnumerator 丅业丈丘世丘万丞东(UnityEngine.WWW 东丞丒丙世丏三下丟)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .东丞丒丙世丏三下丟 = 东丞丒丙世丏三下丟;
        return (System.Collections.IEnumerator)new FriendPreviewItem.上世世业丘不丗下丒();
    }
    private string 丗七万七丄丞丛丘丐(string 丈丘丝一丗下丈丐不, string 丒丘丏上丙丟丑丕丈)
    {
        return System.String.Format(format:  "[b]{0} {1}[/b]", arg0:  丈丘丝一丗下丈丐不, arg1:  丒丘丏上丙丟丑丕丈);
    }
    private void 丏万一丗下丂七丒世()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().三丐丁一且一丏三丞(丄丒且丙三丆丟与丏:  this.id);
        if(val_2 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_2, 下上丐丆丝丟丝丒不:  "player", 丙业与丙丗丝不丈东: out  val_3)) == false)
        {
                return;
        }
        
        this.不丁丝业下丟丑丁丆(丒上上丑丏丕丒丘与:  val_3);
    }
    private void 与不东一丂丅丕丟丝(bool 丟东丏七不专下丝丆)
    {
        this.clanContainer.gameObject.SetActive(value:  丟东丏七不专下丝丆);
        if(this.playerDetailInfoGrid == null)
        {
            
        }
    
    }
    private void 不丁丝业下丟丑丁丆(System.Collections.Generic.Dictionary<string, object> 丒上上丑丏丕丒丘与)
    {
        string val_22;
        string val_23;
        string val_24;
        this.levelAndName.text = System.Convert.ToString(value:  丒上上丑丏丕丒丘与.Item["nick"]);
        this.level.text = System.Convert.ToString(value:  丒上上丑丏丕丒丘与.Item["rank"]);
        val_22 = "";
        if(((丒上上丑丏丕丒丘与.ContainsKey(key:  "avatar")) == false) || (丒上上丑丏丕丒丘与.Item["avatar"] == null))
        {
            goto label_10;
        }
        
        val_23 = 丒上上丑丏丕丒丘与.Item["avatar"];
        if(val_23 != null)
        {
                if(null != null)
        {
                val_23 = 0;
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_23)) == false)
        {
            goto label_16;
        }
        
        label_10:
        if((丒上上丑丏丕丒丘与.ContainsKey(key:  "skin")) == false)
        {
            goto label_23;
        }
        
        val_24 = "skin";
        goto label_20;
        label_16:
        val_24 = "avatar";
        label_20:
        object val_11 = 丒上上丑丏丕丒丘与.Item[val_24];
        if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        label_23:
        this.上丈一万东三东世东(丘丈下丛丙丝世丗丏:  val_22);
        Dictionary.Enumerator<TKey, TValue> val_14 = 丒上上丑丏丕丒丘与.GetEnumerator();
        label_29:
        if(((-1637550464) & 1) == 0)
        {
            goto label_25;
        }
        
        ConfiguredValueTaskAwaiter val_15 = 0.GetAwaiter();
        new System.Collections.Generic.Dictionary<System.String, System.String>().Add(key:  val_15._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToString(value:  val_15._value._obj));
        goto label_29;
        label_25:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((ContainsKey(key:  "clan_name")) != false)
        {
                bool val_20 = System.String.IsNullOrEmpty(value:  Item["clan_name"]);
            this.与不东一丂丅丕丟丝(丟东丏七不专下丝丆:  (~val_20) & 1);
            if(val_20 == true)
        {
                return;
        }
        
            this.丈东丂与七东三不一(万丏丅丕丙丈不丂万:  val_22);
            return;
        }
        
        this.与不东一丂丅丕丟丝(丟东丏七不专下丝丆:  false);
    }
    private void 丗三东下上丒业七业()
    {
        bool val_2 = 丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().与丂丑丆上专业丂丑(丄丒且丙三丆丟与丏:  this.id);
        bool val_3 = FriendsController.与丞不且专七丛丁丛(丄丒且丙三丆丟与丏:  this.id);
        string val_14 = this.id;
        bool val_4 = FriendsController.专丁丟丛丆万丟万丆(丄丒且丙三丆丟与丏:  val_14);
        val_14 = val_3 | val_4;
        bool val_5 = val_2 | val_14;
        val_5 = val_5 ^ 1;
        this.addFriendButton.gameObject.SetActive(value:  val_5);
        this.invitationAddSentContainer.gameObject.SetActive(value:  val_2);
        this.friendAddContainer.gameObject.SetActive(value:  val_4);
        this.selfAddContainer.gameObject.SetActive(value:  val_3);
    }
    private void 丟一丁丆丈世业丛丞(丝丟万七上东丅丄丄 丘且丒丅丘世丕丐丗)
    {
        var val_14;
        bool val_1 = this.丟丞丟丑丛丝不丗且();
        bool val_2 = this.与丛丒下丕丁丕丗丛();
        UnityEngine.GameObject val_3 = this.findFrinedsButtonContainer.gameObject;
        if(丘且丒丅丘世丕丐丗 == 2)
        {
                val_3.SetActive(value:  FriendsController.丁丘万不丌丏丗丗且() ^ 1);
            this.丗三东下上丒业七业();
        }
        else
        {
                (丘且丒丅丘世丕丐丗 == 2) ? 0 : (val_3).SetActive(value:  false);
        }
        
        var val_9 = (丘且丒丅丘世丕丐丗 == 1) ? 1 : 0;
        val_9 = val_9 | val_1;
        val_9 = val_9 | val_2;
        this.friendListButtonContainer.gameObject.SetActive(value:  val_9 & ((丘且丒丅丘世丕丐丗 != 2) ? 1 : 0));
        UnityEngine.GameObject val_12 = this.inboxFriendsButtonContainer.gameObject;
        if(丘且丒丅丘世丕丐丗 != 3)
        {
            goto label_11;
        }
        
        val_14 = (~(val_1 | val_2)) & 1;
        if(val_12 != null)
        {
            goto label_14;
        }
        
        goto label_13;
        label_11:
        val_14 = 0;
        if(val_12 != null)
        {
            goto label_14;
        }
        
        label_13:
        label_14:
        val_12.SetActive(value:  false);
    }
    private void 丐一上丟上丐丂丑丄()
    {
        this.detailInfoConatiner.gameObject.SetActive(value:  false);
        if(this.playerDetailInfoGrid == null)
        {
            
        }
    
    }
    public void FillData(string 丄丒且丙三丆丟与丏, 丝丟万七上东丅丄丄 世丟万一丘丐丙丝与)
    {
        this.id = 丄丒且丙三丆丟与丏;
        this.丌下丏丐丕丏不丗一 = 世丟万一丘丐丙丝与;
        this.丟一丁丆丈世业丛丞(丘且丒丅丘世丕丐丗:  世丟万一丘丐丙丝与);
        this.丏万一丗下丂七丒世();
        this.inYourNetworkIcon.SetActive(value:  false);
        if(世丟万一丘丐丙丝与 == 1)
        {
            goto label_7;
        }
        
        if(世丟万一丘丐丙丝与 != 2)
        {
            goto label_6;
        }
        
        三丁丏一丄下三东一 val_1 = FriendsController.东丁丘下丛丑上丝且(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏);
        this.丑丟丅丂丞三专丏丒 = val_1;
        if(val_1 == 0)
        {
            goto label_6;
        }
        
        this.丆丝丛丌世三世丈且(业丙七不丂丟七世七:  val_1);
        goto label_7;
        label_6:
        this.丐一上丟上丐丂丑丄();
        label_7:
        this.不与丒不丆丒东一丌();
    }
    private void 丈东丂与七东三不一(System.Collections.Generic.Dictionary<string, string> 万丏丅丕丙丈不丂万)
    {
        var val_21;
        var val_22;
        var val_23;
        if((万丏丅丕丙丈不丂万.ContainsKey(key:  "clan_logo")) != false)
        {
                val_21 = 1152921523762453280;
            if((System.String.IsNullOrEmpty(value:  万丏丅丕丙丈不丂万.Item["clan_logo"])) != true)
        {
                if((万丏丅丕丙丈不丂万.Item["clan_logo"].Equals(value:  "null")) == false)
        {
            goto label_7;
        }
        
        }
        
        }
        
        val_22 = this.clanIcon.gameObject;
        val_22.SetActive(value:  false);
        label_34:
        if((万丏丅丕丙丈不丂万.ContainsKey(key:  "clan_name")) == false)
        {
            goto label_13;
        }
        
        val_21 = 1152921523762453280;
        if((System.String.IsNullOrEmpty(value:  万丏丅丕丙丈不丂万.Item["clan_name"])) == true)
        {
            goto label_13;
        }
        
        val_22 = 万丏丅丕丙丈不丂万.Item["clan_name"];
        if((val_22.Equals(value:  "null")) == false)
        {
            goto label_16;
        }
        
        label_13:
        this.clanName.gameObject.SetActive(value:  false);
        return;
        label_7:
        this.clanIcon.gameObject.SetActive(value:  true);
        val_23 = null;
        val_23 = null;
        new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不, textureFormat:  5, mipChain:  false);
        bool val_17 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.Convert.FromBase64String(s:  万丏丅丕丙丈不丂万.Item["clan_logo"]), markNonReadable:  true);
        new UnityEngine.Texture2D().filterMode = 0;
        if(this.clanIcon == 0)
        {
            goto label_34;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this.clanIcon, allowDestroyingAssets:  true);
        goto label_34;
        label_16:
        this.clanName.gameObject.SetActive(value:  true);
        string val_20 = 万丏丅丕丙丈不丂万.Item["clan_name"];
        if(val_20 == null)
        {
                return;
        }
        
        this.clanName.text = val_20;
    }
    private void 丟丂七三丁且东丑下()
    {
        if(this.detailInfoConatiner.gameObject.activeSelf != true)
        {
                this.detailInfoConatiner.gameObject.SetActive(value:  true);
        }
        
        this.detailInfo.text = System.String.Format(format:  "[ff0000]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0576"));
    }
    private void 世丌丐丈丟丄七丅专(string 丏丗丞且丙丑丐东专, string 七丆丂丂下丈且丟世)
    {
        if(this.detailInfoConatiner.gameObject.activeSelf != true)
        {
                this.detailInfoConatiner.gameObject.SetActive(value:  true);
        }
        
        if((System.String.IsNullOrEmpty(value:  七丆丂丂下丈且丟世)) != false)
        {
                string val_5 = System.String.Format(format:  "[00aeff]{0}[-]", arg0:  丏丗丞且丙丑丐东专);
        }
        
        this.detailInfo.text = System.String.Format(format:  "[77ef00]{0}: {1}[-]", arg0:  丏丗丞且丙丑丐东专, arg1:  七丆丂丂下丈且丟世);
    }
    private void 丆丝丛丌世三世丈且(三丁丏一丄下三东一 业丙七不丂丟七世七)
    {
        UILabel val_10;
        string val_12;
        this.invitedBackground.gameObject.SetActive(value:  false);
        this.丐七丏丝丒丗丞丗丁 = false;
        if(this.detailInfoConatiner.gameObject.activeSelf != true)
        {
                this.detailInfoConatiner.gameObject.SetActive(value:  true);
        }
        
        if(业丙七不丂丟七世七 == 3)
        {
            goto label_9;
        }
        
        if(业丙七不丂丟七世七 == 2)
        {
            goto label_10;
        }
        
        if(业丙七不丂丟七世七 != 1)
        {
                return;
        }
        
        this.detailInfo.text = System.String.Format(format:  "[ffe400]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1569"));
        this.inYourNetworkIcon.SetActive(value:  true);
        return;
        label_9:
        val_10 = this.detailInfo;
        string val_7 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1571");
        val_12 = "[77ef00]{0}[-]";
        goto label_18;
        label_10:
        val_10 = this.detailInfo;
        val_12 = "[00aeff]{0}[-]";
        label_18:
        val_10.text = System.String.Format(format:  val_12, arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1570"));
    }
    private void 丞丆上丏丈丈业一东(bool 且三丟丌万丕一丑丕, bool 丑不丗万丞丕丛丟专, string 丆丐丅丛专东万丘与)
    {
        bool val_21 = 丑不丗万丞丕丛丟专;
        bool val_22 = 且三丟丌万丕一丑丕;
        this.connectToRoomButton.gameObject.SetActive(value:  val_22);
        this.connectToSquadButton.gameObject.SetActive(value:  val_21);
        bool val_7 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Contains(item:  this.id);
        bool val_9 = val_22 | val_21;
        val_9 = val_9 | val_7;
        this.notConnectLabel.gameObject.SetActive(value:  val_9 ^ 1);
        this.notConnectLabel.text = 丆丐丅丛专东万丘与;
        val_21 = val_21 ^ 1;
        bool val_12 = val_22 ^ 1;
        val_22 = val_12 & val_21;
        val_12 = val_22 & val_7;
        this.callToSquadButton.SetActive(value:  val_12);
        System.Collections.Generic.IEnumerable<System.String> val_15 = Rilisoft.丈丑丟丏丏与丟丙且.丑七不且上丗丁一世().业丆丙丆东上丛三丅();
        this.丐七丏丝丒丗丞丗丁 = (0.Contains(item:  this.id)) & val_21;
        this.invitedBackground.gameObject.SetActive(value:  (this.丐七丏丝丒丗丞丗丁 == true) ? 1 : 0);
    }
    private void 丝丅丄业东业丅东丝()
    {
        this.丟丂七三丁且东丑下();
        this.detailInfo.text = System.String.alignConst;
        bool val_2 = Rilisoft.丈丑丟丏丏与丟丙且.丑七不且上丗丁一世().业一三不七丘与丑一(丑三丅丒丕丗三丏丁:  this.id);
        this.<丁丗万丈丕丈丏专丟>k__BackingField = 4;
        this.丞丆上丏丈丈业一东(且三丟丌万丕一丑丕:  false, 丑不丗万丞丕丛丟专:  false, 丆丐丅丛专东万丘与:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1577"));
    }
    private void 丂丌与且丌万丟下一(bool 丛丅丘一丏丙且丌上)
    {
    
    }
    private void 丂丌与且丌万丟下一(bool 丛丅丘一丏丙且丌上, bool 丝三丄专丗丞丄丄丌)
    {
    
    }
    private void 不与丒不丆丒东一丌()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_30;
        bool val_31;
        if(this.丌下丏丐丕丏不丗一 == 2)
        {
                return;
        }
        
        val_30 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        if((val_30.ContainsKey(key:  this.id)) == false)
        {
            goto label_21;
        }
        
        val_30 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丂丅丘丄下丏上丆丆();
        丆一丒上专万专下丞 val_7 = FriendsController.丞丒东七丝且上不下(丄且丆丘丆丏丄且东:  val_30.Item[this.id]);
        if((val_7 == null) || (val_7.丝丅丛不丂专一丞与() == 17))
        {
            goto label_21;
        }
        
        if(val_7.丝丅丛不丂专一丞与() != 15)
        {
            goto label_11;
        }
        
        丄上三丛丛上一业三 val_10 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_30 = val_10.业丈丞丐万丄不上丄;
        if((val_30.ContainsKey(key:  this.id)) == false)
        {
            goto label_21;
        }
        
        val_30 = val_7.丟上丅丛一丅丄不丙;
        丄上三丛丛上一业三 val_12 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((System.String.op_Inequality(a:  val_30, b:  val_12.业丈丞丐万丄不上丄.Item[this.id])) == true)
        {
            goto label_21;
        }
        
        label_11:
        if(val_7.丝丅丛不丂专一丞与() != 18)
        {
            goto label_24;
        }
        
        丄上三丛丛上一业三 val_16 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_30 = val_16.一丒丈丈专上丝丝丞;
        if((val_30.ContainsKey(key:  this.id)) == false)
        {
            goto label_21;
        }
        
        val_30 = val_7.丟上丅丛一丅丄不丙;
        丄上三丛丛上一业三 val_18 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((System.String.op_Inequality(a:  val_30, b:  val_18.一丒丈丈专上丝丝丞.Item[this.id])) == false)
        {
            goto label_24;
        }
        
        label_21:
        this.丝丅丄业东业丅东丝();
        return;
        label_24:
        this.世丌丐丈丟丄七丅专(丏丗丞且丙丑丐东专:  val_7.丈世丆不丑丟丛丒丕(), 七丆丂丂下丈且丟世:  val_7.丆丆业丂专与丙丐不());
        if(this.丟丞丟丑丛丝不丗且() != false)
        {
                val_31 = 1;
        }
        else
        {
                val_31 = this.与丛丒下丕丁丕丗丛();
        }
        
        this.丞丆上丏丈丈业一东(且三丟丌万丕一丑丕:  val_7.丐丟丑丐丁丁丅丕丘(), 丑不丗万丞丕丛丟专:  val_31, 丆丐丅丛专东万丘与:  val_7.丝且丏七丐万丅丗东());
        this.<丁丗万丈丕丈丏专丟>k__BackingField = val_7.丘丑不万专且丈丌丌();
    }
    private void OnDestroy()
    {
        System.Action val_4;
        if(((System.Delegate.Remove(source:  FriendsWindowController.丞世丑丁且丌丙丛专, value:  new System.Action(object:  this, method:  System.Void FriendPreviewItem::不与丒不丆丒东一丌()))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        FriendsWindowController.丞世丑丁且丌丙丛专 = val_4;
    }
    private void 丞三丝丒七丞业下东(bool 东丏丂丙丑丁丞丞万, bool 丑丒丁丏丝丞丘丁丟)
    {
        this.addFriendButton.enabled = true;
        InfoWindowController.丟不丗丛丘一丕丄丁(东丏丂丙丑丁丞丞万:  东丏丂丙丑丁丞丞万, 丑丒丁丏丝丞丘丁丟:  丑丒丁丏丝丞丘丁丟);
        if(东丏丂丙丑丁丞丞万 == false)
        {
                return;
        }
        
        this.丗三东下上丒业七业();
    }
    public void OnClickAddFriend()
    {
        var val_12;
        System.Func<FriendsWindowController, FriendsWindowStatusBar> val_14;
        var val_15;
        System.Func<FriendsWindowStatusBar, System.Boolean> val_17;
        var val_18;
        object val_19;
        if((System.String.IsNullOrEmpty(value:  this.id)) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        this.addFriendButton.enabled = false;
        val_12 = null;
        val_12 = null;
        val_14 = FriendPreviewItem.<>c.<>9__75_0;
        if(val_14 == null)
        {
                System.Func<FriendsWindowController, FriendsWindowStatusBar> val_4 = null;
            val_14 = val_4;
            val_4 = new System.Func<FriendsWindowController, FriendsWindowStatusBar>(object:  FriendPreviewItem.<>c.__il2cppRuntimeField_static_fields, method:  FriendsWindowStatusBar FriendPreviewItem.<>c::丝七一丂丒不丄丌业(FriendsWindowController 丝下与丂下东丙丟丘));
            FriendPreviewItem.<>c.<>9__75_0 = val_14;
        }
        
        val_15 = null;
        val_15 = null;
        val_17 = FriendPreviewItem.<>c.<>9__75_1;
        if(val_17 == null)
        {
                System.Func<FriendsWindowStatusBar, System.Boolean> val_6 = null;
            val_17 = val_6;
            val_6 = new System.Func<FriendsWindowStatusBar, System.Boolean>(object:  FriendPreviewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FriendPreviewItem.<>c::丙丗丕丏丞丟且且丂(FriendsWindowStatusBar 丏丛与丅丛丌万专丌));
            FriendPreviewItem.<>c.<>9__75_1 = val_17;
        }
        
        if((Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<FriendsWindowStatusBar, System.Boolean>(丄三丅七丆丛与与上:  Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<FriendsWindowController, FriendsWindowStatusBar>(丄三丅七丆丛与与上:  FriendsWindowController.丆丕丝丒不丙且丐丗, 东丑丈丅丌万东丅且:  val_4), 东丑丈丅丌万东丅且:  val_6)) != false)
        {
                val_18 = 1;
            val_19 = "Search";
        }
        else
        {
                val_19 = System.String.Format(format:  "Find Friends: {0}", arg0:  this.丑丟丅丂丞三专丏丒);
            val_18 = 0;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_9 != null)
        {
                val_9.Add(key:  "Added Friends", value:  val_19);
        }
        else
        {
                val_9.Add(key:  "Added Friends", value:  val_19);
        }
        
        val_9.Add(key:  "Deleted Friends", value:  "Add");
        if(val_18 != 0)
        {
                val_9.Add(key:  "Search Friends", value:  "Add");
        }
        
        NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  6);
        丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丙与丗世丏丅丈丞万(丄丒且丙三丆丟与丏:  this.id, 下丏丏世丈丌丕丛与:  val_9, 业丏丈世世世丞丒世:  new 丌丟丄专丂丒丁丛三.丅一丂上丈业世与丅(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendPreviewItem::丞三丝丒七丞业下东(bool 东丏丂丙丑丁丞丞万, bool 丑丒丁丏丝丞丘丁丟)));
    }
    public void OnClickConnectToFriendRoom()
    {
        int val_12;
        var val_13;
        string val_14;
        var val_15;
        val_12 = this;
        ButtonClickSound.丁业上丏不丕三丗不();
        丄上三丛丛上一业三 val_1 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if((val_1.业丈丞丐万丄不上丄.ContainsKey(key:  this.id)) != false)
        {
                val_13 = null;
            val_13 = null;
            if((FriendsController.丄丞丁丈与业上丞丟.HaveSquadInviteFromPlayer(丞丅上丏丂且下丅与:  this.id)) != false)
        {
                丄上三丛丛上一业三 val_4 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
            FriendsWindowController.丆丕丝丒不丙且丐丗.丆丙丄上七与一东丒(丒丘丏上丙丟丑丕丈:  val_4.业丈丞丐万丄不上丄.Item[this.id]);
            丄上三丛丛上一业三 val_6 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
            val_14 = this.id;
            if((val_6.三东三丄丐丗丆且不.ContainsKey(key:  val_14)) == false)
        {
                return;
        }
        
            丄上三丛丛上一业三 val_8 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
            val_12 = val_8.三东三丄丐丗丆且不.Item[this.id];
            val_15 = null;
            val_15 = null;
            SquadController.丘丘丙丗东丟丑业丟 = val_12;
            return;
        }
        
        }
        
        丄上三丛丛上一业三 val_10 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        val_14 = this.id;
        if((val_10.一丒丈丈专上丝丝丞.ContainsKey(key:  val_14)) != false)
        {
                FriendsWindowController.丆丕丝丒不丙且丐丗.EnterClanSiegeMode();
            return;
        }
        
        FriendsController.万与东丅七丁且丂下(丑三丅丒丕丗三丏丁:  this.id);
        if(this.丐七丏丝丒丗丞丗丁 == false)
        {
                return;
        }
        
        Rilisoft.一丟专且三万丞丁丂.丒丒上丁丞丘丑丕丂();
    }
    public void OnClickGoTohatButton()
    {
        FriendsWindowController.丆丕丝丒不丙且丐丗.丌丆丁且丐丄丕丑丞(丞丅上丏丂且下丅与:  this.id);
    }
    private void 与丘丟丈东不丟丑东(bool 东丏丂丙丑丁丞丞万)
    {
        InfoWindowController.丟不丗丛丘一丕丄丁(东丏丂丙丑丁丞丞万:  东丏丂丙丑丁丞丞万, 丑丒丁丏丝丞丘丁丟:  false);
        if(东丏丂丙丑丁丞丞万 == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_2.Add(key:  "Friend Requests", value:  "Accepted");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Social", 丛东不丒丏丈丄且丕:  val_2);
        FriendsWindowController.丆丕丝丒不丙且丐丗.与不丘丌且世上丟业();
    }
    private void 上丏东三丏与一东且(bool 东丏丂丙丑丁丞丞万)
    {
        InfoWindowController.丟不丗丛丘一丕丄丁(东丏丂丙丑丁丞丞万:  东丏丂丙丑丁丞丞万, 丑丒丁丏丝丞丘丁丟:  false);
        if(东丏丂丙丑丁丞丞万 == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_2.Add(key:  "Friend Requests", value:  "Rejected");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Social", 丛东不丒丏丈丄且丕:  val_2);
        FriendsWindowController.丆丕丝丒不丙且丐丗.与不丘丌且世上丟业();
    }
    public void OnClickAcceptButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        if(FriendsController.丁丘万不丌丏丗丗且() != false)
        {
                InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1424"));
            this = ???;
        }
        else
        {
                丑丆且丂丈丏丁丛丏.丑七不且上丗丁一世().万丟丏与丞丈七丂丕(丄丂万与一丒丗不丕:  this.id, 业丏丈世世世丞丒世:  new 丑丆且丂丈丏丁丛丏.丈丅丂世丕不上下丙(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendPreviewItem::与丘丟丈东不丟丑东(bool 东丏丂丙丑丁丞丞万)));
        }
    
    }
    public void OnClickDeclineButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        东丐丁丐与丟下丄丈.丑七不且上丗丁一世().丕丑专丈上丟丟业不(丄丂万与一丒丗不丕:  this.id, 业丏丈世世世丞丒世:  new 东丐丁丐与丟下丄丈.丅丝且丑与丈七万丕(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendPreviewItem::上丏东三丏与一东且(bool 东丏丂丙丑丁丞丞万)));
    }
    public void OnClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        FriendsWindowController.丆丕丝丒不丙且丐丗.世专丌业丘丒丛丅上(丑三丅丒丕丗三丏丁:  this.id, 丁丑丞不丗专丑业万:  this);
    }
    internal void 不下丌丆东丑丈丕丝()
    {
        if((System.String.IsNullOrEmpty(value:  this.id)) != false)
        {
                return;
        }
        
        this.FillData(丄丒且丙三丆丟与丏:  this.id, 世丟万一丘丐丙丝与:  this.丌下丏丐丕丏不丗一);
    }
    public FriendPreviewItem()
    {
        this.blinkButtonSprite = "blue_btn";
    }

}
