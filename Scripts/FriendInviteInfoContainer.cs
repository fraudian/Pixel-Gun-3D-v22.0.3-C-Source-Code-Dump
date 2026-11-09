using UnityEngine;
public class FriendInviteInfoContainer : MonoBehaviour
{
    // Fields
    public int myWrapIndex;
    public UILabel p_Name;
    public UILabel p_Clan;
    public UILabel p_Level;
    public UILabel p_status;
    public UnityEngine.GameObject p_Invited;
    public UnityEngine.GameObject p_Joined;
    private UISprite spriteOnlineStatus;
    public UITexture p_Avatar;
    public UITexture p_ClanIcon;
    public UISprite p_ClanRank;
    public UnityEngine.GameObject p_WiFiSprite;
    public string p_PixelBookID;
    public UILabel reasonNoInvite;
    public UIButton inviteButton;
    internal static System.Collections.Generic.List<string> 丒丟丂丈丝丕万东一;
    public bool is_Invited;
    public bool is_Joined;
    private const string 专丘与专丑丈且丄丞 = "cw_member_ingame";
    private const string 丕业三丂丂丌世不丕 = "cw_member_offline";
    private const string 一且丕丙丆丟丙七丒 = "cw_member_online";
    
    // Methods
    private void Awake()
    {
        if(this.inviteButton == 0)
        {
                return;
        }
        
        this.inviteButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void FriendInviteInfoContainer::U_HandleInviteButton(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public void SetUpPlayerInfo(SquadInviteGUI.丒世七丈丈丘丄丞丕 东一丁世丑丞业丄丐)
    {
        string val_18;
        string val_19;
        string val_20;
        this.p_PixelBookID = 东一丁世丑丞业丄丐.丄丏丆丝世丙业下丌;
        val_18 = 东一丁世丑丞业丄丐.丞丞下东且丗丄丒丏;
        val_19 = 东一丁世丑丞业丄丐.专下不丘丘丝丅七三;
        val_20 = 东一丁世丑丞业丄丐.且专东下上上丙丌丈;
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if((val_2 != null) && ((val_2.丕一下丒丝世下丘万(丞丅上丏丂且下丅与:  东一丁世丑丞业丄丐.丄丏丆丝世丙业下丌)) != false))
        {
                七丈丗不丞丈丝丙七 val_6 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  东一丁世丑丞业丄丐.丄丏丆丝世丙业下丌);
            if(val_6 != null)
        {
                val_18 = val_6.东丙上东业丆不丟丘();
        }
        else
        {
                val_18 = 0;
        }
        
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_18)) != false)
        {
                val_18 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  东一丁世丑丞业丄丐.丄丏丆丝世丙业下丌);
        }
        
            val_19 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘();
            val_20 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丝丈三专丟丌丄丝();
        }
        
        this.业业丑三丞世丁不丞(丛与丕上世丑丈不丐:  东一丁世丑丞业丄丐.丄丏丆丝世丙业下丌, 丒丘丏上丙丟丑丕丈:  val_18, 丈丘丝一丗下丈丐不:  268435461, 丑丈丌业下丂下丑丘:  5853280, 丂丒丘丅专丗丂世丛:  东一丁世丑丞业丄丐.专世专丟丝丌与丘上, 一丁丘丒三丂丑一东:  (5849184 == 1) ? 1 : 0, 且丟丅丄丒丑丂丁世:  val_19, 一丙业且丌东丁丄丝:  val_20);
    }
    private void 业业丑三丞世丁不丞(string 丛与丕上世丑丈不丐, string 丒丘丏上丙丟丑丕丈, int 丈丘丝一丗下丈丐不, Rilisoft.七下上丝三丛三上一 丑丈丌业下丂下丑丘, string 丂丒丘丅专丗丂世丛, bool 一丁丘丒三丂丑一东, string 且丟丅丄丒丑丂丁世 = "", string 一丙业且丌东丁丄丝 = "")
    {
        var val_38;
        float val_39;
        float val_40;
        UISprite val_41;
        string val_42;
        var val_43;
        var val_44;
        var val_46;
        string val_47;
        var val_48;
        UIButton val_49;
        UITexture val_50;
        var val_52;
        UnityEngine.Texture2D val_1 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  丂丒丘丅专丗丂世丛, 丁丅丈丌丟世丗丗丟:  1);
        this.p_Name.text = 丒丘丏上丙丟丑丕丈;
        this.p_Level.text = 丈丘丝一丗下丈丐不.ToString();
        val_38 = null;
        val_38 = null;
        this.p_status.text = FriendsController.丄丞丁丈与业上丞丟.丄东不七丙且丈丑专(丑丈丌业下丂下丑丘:  丑丈丌业下丂下丑丘);
        this.p_WiFiSprite.SetActive(value:  一丁丘丒三丂丑一东);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.p_status, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.p_ClanRank, 丏业丟一东丂东丘丛:  false);
        if(((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null) && (this.p_ClanRank != 0))
        {
                七丈丗不丞丈丝丙七 val_10 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  丛与丕上世丑丈不丐);
            if(val_10 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.p_ClanRank, 丏业丟一东丂东丘丛:  true);
            this.p_ClanRank.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_10.与丘且丟不丅丏万丆());
        }
        
        }
        
        if(丑丈丌业下丂下丑丘 == 4)
        {
            goto label_24;
        }
        
        if(丑丈丌业下丂下丑丘 == 1)
        {
            goto label_25;
        }
        
        if(丑丈丌业下丂下丑丘 != 0)
        {
            goto label_26;
        }
        
        UnityEngine.Color val_13 = UnityEngine.Color.green;
        val_39 = val_13.r;
        val_40 = val_13.b;
        this.p_status.color = new UnityEngine.Color() {r = val_39, g = val_13.g, b = val_40, a = val_13.a};
        val_41 = this.spriteOnlineStatus;
        val_42 = "cw_member_online";
        goto label_34;
        label_25:
        UnityEngine.Color val_14 = UnityEngine.Color.green;
        val_39 = val_14.r;
        val_40 = val_14.b;
        this.p_status.color = new UnityEngine.Color() {r = val_39, g = val_14.g, b = val_40, a = val_14.a};
        val_41 = this.spriteOnlineStatus;
        val_42 = "cw_member_ingame";
        goto label_34;
        label_24:
        UnityEngine.Color val_15 = UnityEngine.Color.gray;
        val_39 = val_15.r;
        val_40 = val_15.b;
        this.p_status.color = new UnityEngine.Color() {r = val_39, g = val_15.g, b = val_40, a = val_15.a};
        val_41 = this.spriteOnlineStatus;
        val_42 = "cw_member_offline";
        label_34:
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  val_41, 万丑丞一丝丌丐丒丘:  val_42);
        label_26:
        int val_16 = ExpController.东东丒丈丛丈七丘不();
        val_43 = null;
        val_43 = null;
        if(SquadController.丄丘七三上丕世丞业 != 0)
        {
                val_44 = null;
            val_44 = null;
            SquadController.丄丘七三上丕世丞业.squadRoomName
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = FriendInviteInfoContainer.一且丕丙丆丟丙七丒;
        this.is_Invited = val_47.Contains(item:  丛与丕上世丑丈不丐 + System.String.__il2cppRuntimeField_static_fields);
        val_48 = null;
        val_48 = null;
        this.is_Joined = SquadController.丄丘七三上丕世丞业.IsPlayerInSquad(丄丒且丙三丆丟与丏:  丛与丕上世丑丈不丐);
        UnityEngine.GameObject val_23 = this.inviteButton.gameObject;
        if(this.is_Invited == false)
        {
            goto label_56;
        }
        
        if(val_23 != null)
        {
            goto label_83;
        }
        
        label_84:
        label_83:
        val_23.SetActive(value:  (0 != 0) ? 1 : 0);
        if(this.is_Invited == false)
        {
            goto label_58;
        }
        
        bool val_38 = this.is_Joined;
        val_38 = val_38 ^ 1;
        if(this.p_Invited != null)
        {
            goto label_85;
        }
        
        label_86:
        label_85:
        this.p_Invited.SetActive(value:  ((val_38 & 255) == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.p_Joined, 丏业丟一东丂东丘丛:  (this.is_Joined == true) ? 1 : 0);
        this.reasonNoInvite.gameObject.SetActive(value:  false);
        val_49 = this.inviteButton;
        if((System.String.op_Equality(a:  且丟丅丄丒丑丂丁世, b:  System.String.alignConst)) != false)
        {
                this.p_Clan.gameObject.SetActive(value:  false);
            this.p_ClanIcon.gameObject.SetActive(value:  false);
            val_50 = this.p_ClanIcon;
            if(val_50 != null)
        {
                return;
        }
        
            return;
        }
        
        val_52 = null;
        val_52 = null;
        val_47 = 与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不;
        val_49 = new UnityEngine.Texture2D();
        val_49 = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  val_47, textureFormat:  5, mipChain:  false);
        bool val_34 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.Convert.FromBase64String(s:  一丙业且丌东丁丄丝), markNonReadable:  true);
        new UnityEngine.Texture2D().filterMode = 0;
        this.p_Clan.gameObject.SetActive(value:  true);
        this.p_ClanIcon.gameObject.SetActive(value:  true);
        this.p_Clan.text = 且丟丅丄丒丑丂丁世;
        val_50 = this.p_ClanIcon;
        return;
        label_56:
        bool val_39 = this.is_Joined;
        val_39 = val_39 ^ 1;
        bool val_37 = val_39 & 255;
        if(val_23 != null)
        {
            goto label_83;
        }
        
        goto label_84;
        label_58:
        if(this.p_Invited != null)
        {
            goto label_85;
        }
        
        goto label_86;
    }
    private void Update()
    {
        if(this.inviteButton == null)
        {
            
        }
    
    }
    private void 丏东丟丗一丐丄丞丂()
    {
        if(this.inviteButton == null)
        {
            
        }
    
    }
    public void U_HandleInviteButton(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        int val_10;
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        this.丙与丗世丏丅丈丞万();
        this.inviteButton.gameObject.SetActive(value:  false);
        this.p_Invited.gameObject.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.p_Joined, 丏业丟一东丂东丘丛:  false);
        val_9 = null;
        val_9 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙丆丌丝丛丏丝丕业();
        }
        else
        {
                val_10 = System.String.alignConst;
        }
        
        FriendInviteInfoContainer.一且丕丙丆丟丙七丒.Add(item:  this.p_PixelBookID + val_10);
    }
    private void 丙与丗世丏丅丈丞万()
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.SendInviteToPlayer(丆世丘丒丒丏上且丗:  this.p_PixelBookID);
    }
    public FriendInviteInfoContainer()
    {
    
    }
    private static FriendInviteInfoContainer()
    {
        FriendInviteInfoContainer.一且丕丙丆丟丙七丒 = new System.Collections.Generic.List<System.String>();
    }

}
