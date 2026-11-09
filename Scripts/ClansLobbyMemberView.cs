using UnityEngine;
public class ClansLobbyMemberView : ClansMemberView
{
    // Fields
    private UnityEngine.Transform _menuPoint;
    private UISprite clanRankSprite;
    private UISprite isMyPlayer;
    private UISprite gameModeSprite;
    private UILabel nickname;
    private UILabel warScores;
    private UISprite selectionSprite;
    private UISprite clanNewRankSprite;
    private 七丈丗不丞丈丝丙七 七丁丐丙不丛丏与东;
    public ContextMenuBase ContextMenu;
    public int wrapIndex;
    private const string 专丘与专丑丈且丄丞 = "cw_member_ingame";
    private const string 丅世丞丌丂上且七丌 = "cw_member_lobby";
    private const string 丕业三丂丂丌世不丕 = "cw_member_offline";
    private const string 一且丕丙丆丟丙七丒 = "cw_member_online";
    private const string 上丄丕丄丈业业专业 = "cw_member_party";
    
    // Methods
    public void UpdateView(与丛丕丝丑丁与丐丝 丕丝丄三丂三与丑世)
    {
        与丛丕丝丑丁与丐丝 val_26;
        与丛丕丝丑丁与丐丝 val_27;
        var val_28;
        与丛丕丝丑丁与丐丝 val_33;
        val_26 = 丕丝丄三丂三与丑世;
        ClansLobbyMemberView.丞丆丌万丛不且七丐 val_1 = new ClansLobbyMemberView.丞丆丌万丛不且七丐();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .丕丝丄三丂三与丑世 = val_26;
        if(val_26 == null)
        {
            goto label_2;
        }
        
        label_34:
        if(val_1 != null)
        {
            goto label_3;
        }
        
        val_27 = .丕丝丄三丂三与丑世;
        if(val_27 == null)
        {
            goto label_4;
        }
        
        label_3:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nickname, 丕丗丘丑丛与丑业丒:  丕丝丄三丂三与丑世.丒丘丏上丙丟丑丕丈);
        mem[1152921536675489960] = 丕丝丄三丂三与丑世.丞丅上丏丂且下丅与;
        if(((System.String.op_Inequality(a:  丕丝丄三丂三与丑世.丞丅上丏丂且下丅与, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false) || ((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().万丄丘与丒丅丒下世().ContainsKey(key:  丕丝丄三丂三与丑世.丞丅上丏丂且下丅与)) == false))
        {
            goto label_16;
        }
        
        int val_11 = System.Int32.Parse(s:  丐丌不丏东丟丕七丟.丑七不且上丗丁一世().万丄丘与丒丅丒下世().Item[丕丝丄三丂三与丑世.丞丅上丏丂且下丅与].Item["game_mode"]);
        val_28 = 0;
        if(val_1 != null)
        {
            goto label_22;
        }
        
        label_24:
        this.丁丅丁丆七三一专丈(丕丝丄三丂三与丑世:  .丕丝丄三丂三与丑世);
        this.三三七上且业丏不专(丕丝丄三丂三与丑世:  .丕丝丄三丂三与丑世, 下世丂丙世丈与下丝:  0);
        goto label_23;
        label_16:
        val_28 = 0;
        if(val_1 == null)
        {
            goto label_24;
        }
        
        label_22:
        this.丁丅丁丆七三一专丈(丕丝丄三丂三与丑世:  .丕丝丄三丂三与丑世);
        this.三三七上且业丏不专(丕丝丄三丂三与丑世:  .丕丝丄三丂三与丑世, 下世丂丙世丈与下丝:  0);
        label_23:
        this.丏东丌三且丗丆丕业(丕丝丄三丂三与丑世:  .丕丝丄三丂三与丑世);
        string val_26 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_26 = System.String.op_Equality(a:  丕丝丄三丂三与丑世.丞丅上丏丂且下丅与, b:  val_26);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.isMyPlayer, 丏业丟一东丂东丘丛:  val_26);
        if((丕丝丄三丂三与丑世.丞丅上丏丂且下丅与.Equals(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_32;
        }
        
        UnityEngine.Color val_16 = UnityEngine.Color.yellow;
        goto label_33;
        label_1:
        mem[16] = val_26;
        val_33 = mem[16];
        if(val_33 != 0)
        {
            goto label_34;
        }
        
        label_2:
        this.gameObject.SetActive(value:  false);
        this.七丁丐丙不丛丏与东 = 0;
        return;
        label_32:
        UnityEngine.Color val_18 = UnityEngine.Color.white;
        label_33:
        this.nickname.color = new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a};
        this.gameObject.SetActive(value:  true);
        this.七丁丐丙不丛丏与东 = System.Linq.Enumerable.FirstOrDefault<七丈丗不丞丈丝丙七>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不(), predicate:  new System.Func<七丈丗不丞丈丝丙七, System.Boolean>(object:  val_1, method:  System.Boolean ClansLobbyMemberView.丞丆丌万丛不且七丐::七丅丐丏丝七丄丏丛(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑)));
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.clanNewRankSprite, 万丑丞一丝丌丐丒丘:  丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  丕丝丄三丂三与丑世.丅丄与专下丅丄丝东));
        return;
        label_4:
    }
    private void 丏东丌三且丗丆丕业(与丛丕丝丑丁与丐丝 丕丝丄三丂三与丑世)
    {
        int val_1;
        if(丕丝丄三丂三与丑世.丕丛丂万丂专丈一不 == 2)
        {
            goto label_2;
        }
        
        if(丕丝丄三丂三与丑世.丕丛丂万丂专丈一不 == 1)
        {
            goto label_3;
        }
        
        if(丕丝丄三丂三与丑世.丕丛丂万丂专丈一不 != 0)
        {
            goto label_4;
        }
        
        val_1 = 丕丝丄三丂三与丑世.下丆丄与下七专业丒;
        goto label_7;
        label_2:
        val_1 = 丕丝丄三丂三与丑世.丅丘不丌且一且七丛;
        goto label_7;
        label_3:
        val_1 = 丕丝丄三丂三与丑世.丄丐不丏丁丘不丒丈;
        goto label_7;
        label_4:
        val_1 = 0;
        label_7:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.warScores, 丕丗丘丑丛与丑业丒:  val_1);
    }
    public void SetSelectionSprite(bool 丗一不上东业专不业)
    {
        丗一不上东业专不业 = 丗一不上东业专不业;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.selectionSprite, 丏业丟一东丂东丘丛:  丗一不上东业专不业);
    }
    private void 丁丅丁丆七三一专丈(与丛丕丝丑丁与丐丝 丕丝丄三丂三与丑世)
    {
        UISprite val_1;
        string val_2;
        if(丕丝丄三丂三与丑世.丕万丐东与一丈万与 == 0)
        {
            goto label_2;
        }
        
        if(丕丝丄三丂三与丑世.丕万丐东与一丈万与 == 2)
        {
            goto label_3;
        }
        
        if(丕丝丄三丂三与丑世.丕万丐东与一丈万与 != 1)
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRankSprite, 丏业丟一东丂东丘丛:  true);
        val_1 = this.clanRankSprite;
        val_2 = "clan_leader_icon1";
        goto label_12;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRankSprite, 丏业丟一东丂东丘丛:  true);
        val_1 = this.clanRankSprite;
        val_2 = "clan_fighter_icon";
        goto label_12;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRankSprite, 丏业丟一东丂东丘丛:  true);
        val_1 = this.clanRankSprite;
        val_2 = "clan_officer_icon";
        label_12:
        val_1.spriteName = val_2;
        return;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRankSprite, 丏业丟一东丂东丘丛:  false);
    }
    private void 三三七上且业丏不专(与丛丕丝丑丁与丐丝 丕丝丄三丂三与丑世, int 下世丂丙世丈与下丝)
    {
        var val_3;
        UISprite val_4;
        string val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.gameModeSprite, 丏业丟一东丂东丘丛:  true);
        if(丕丝丄三丂三与丑世.丘三三东且丈丅丈丛 == false)
        {
            goto label_4;
        }
        
        if(下世丂丙世丈与下丝 <= 7)
        {
            goto label_5;
        }
        
        val_3 = "cw_member_party";
        if((下世丂丙世丈与下丝 == 15) || (下世丂丙世丈与下丝 == 18))
        {
            goto label_8;
        }
        
        val_3 = "cw_member_ingame";
        goto label_8;
        label_4:
        val_4 = this.gameModeSprite;
        val_5 = "cw_member_offline";
        goto label_10;
        label_5:
        label_8:
        val_4 = mem[下世丂丙世丈与下丝 == 6 ? "cw_member_online" : 下世丂丙世丈与下丝 == 7 ? "cw_member_lobby" : "cw_member_ingame"];
        val_4 = (下世丂丙世丈与下丝 == 6) ? "cw_member_online" : ((下世丂丙世丈与下丝 == 7) ? "cw_member_lobby" : "cw_member_ingame");
        val_5 = val_4;
        label_10:
        this.gameModeSprite.spriteName = val_5;
    }
    public 七丈丗不丞丈丝丙七 GetClanMember()
    {
        return (七丈丗不丞丈丝丙七)this.七丁丐丙不丛丏与东;
    }
    public override void OnClick()
    {
        if(this.七丁丐丙不丛丏与东 != null)
        {
                if((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  this.七丁丐丙不丛丏与东.业丐丐三丕一丗丛丁())) != false)
        {
                this.OnClick();
            return;
        }
        
        }
        
        UnityEngine.Transform val_5 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_6 = this._menuPoint.position;
        if(丈东丛丗上业不丒三.丁丌丒三三丛丞丂万() == null)
        {
            
        }
    
    }
    public ClansLobbyMemberView()
    {
        val_1 = new PGBehaviour();
    }

}
