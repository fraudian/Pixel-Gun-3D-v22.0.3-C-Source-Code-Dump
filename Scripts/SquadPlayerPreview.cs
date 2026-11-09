using UnityEngine;
public class SquadPlayerPreview : MonoBehaviour
{
    // Fields
    internal SquadController.万丅世丈丕丕丌丅丗 东一丁世丑丞业丄丐;
    private bool 丝丞下七三与业一丞;
    private bool 丛丆丏丛业丞丄丄东;
    public UnityEngine.GameObject playerContainer;
    public UnityEngine.GameObject emptyContainer;
    public UnityEngine.GameObject isMineFrame;
    public UnityEngine.GameObject readySprite;
    public UnityEngine.GameObject reconnecting;
    public UnityEngine.GameObject noTickets;
    public UnityEngine.GameObject restrictedSlot;
    public UnityEngine.GameObject playerInBattle;
    public UILabel playerName;
    public UILabel playerRank;
    public UITexture playerAvatar;
    public UISprite playerClanRankSprite;
    public Rilisoft.ButtonHandler btnAddPlayer;
    public Rilisoft.ButtonHandler btnKickPlayer;
    
    // Methods
    private void Awake()
    {
        if(this.btnKickPlayer == 0)
        {
                return;
        }
        
        this.btnKickPlayer.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SquadPlayerPreview::丙丟丁下三丒与丞丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public void SetAvaliable(bool 世丆丞一业三一丅与)
    {
        this.restrictedSlot.gameObject.SetActive(value:  (~世丆丞一业三一丅与) & 1);
        this.丛丆丏丛业丞丄丄东 = 世丆丞一业三一丅与;
        if(this.btnAddPlayer == 0)
        {
                return;
        }
        
        this.btnAddPlayer.gameObject.SetActive(value:  (this.丛丆丏丛业丞丄丄东 == true) ? 1 : 0);
    }
    public void SetNoTickets(bool 丅丒七业业丁一丝丛)
    {
        if(this.noTickets == 0)
        {
                return;
        }
        
        this.noTickets.gameObject.SetActive(value:  丅丒七业业丁一丝丛);
    }
    public void Fill(SquadController.万丅世丈丕丕丌丅丗 东一丁世丑丞业丄丐, bool 不丏且丑丆丌三世丈)
    {
        SquadController.万丅世丈丕丕丌丅丗 val_22;
        var val_23;
        val_22 = 东一丁世丑丞业丄丐;
        if(val_22 == null)
        {
            goto label_1;
        }
        
        this.东一丁世丑丞业丄丐 = val_22;
        this.playerContainer.SetActive(value:  true);
        if(this.emptyContainer != 0)
        {
                this.emptyContainer.SetActive(value:  false);
        }
        
        if(this.reconnecting != 0)
        {
                this.reconnecting.SetActive(value:  (东一丁世丑丞业丄丐.丆不丐一丙丐丏丗上 == true) ? 1 : 0);
        }
        
        if(this.playerInBattle != 0)
        {
                this.playerInBattle.SetActive(value:  (东一丁世丑丞业丄丐.专丞上七七且丝七丗 == 0) ? 1 : 0);
        }
        
        if(this.isMineFrame != 0)
        {
                this.isMineFrame.SetActive(value:  val_22.丟丌下三七丁与丟丑());
        }
        
        if(this.readySprite != 0)
        {
                this.readySprite.SetActive(value:  (东一丁世丑丞业丄丐.丂丛丄丆丐东且一世 == true) ? 1 : 0);
        }
        
        this.playerName.text = 东一丁世丑丞业丄丐.丛三三与丁丘丄丑下;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerClanRankSprite, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_23 = null;
            val_23 = null;
            if(SquadController.丄丘七三上丕世丞业.IsClanSquad != false)
        {
                丞丂丘丒丟丞丑下丄 val_15 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_15 != null)
        {
                七丈丗不丞丈丝丙七 val_16 = val_15.丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  东一丁世丑丞业丄丐.丆世丘丒丒丏上且丗);
            if(val_16 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerClanRankSprite, 丏业丟一东丂东丘丛:  true);
            this.playerClanRankSprite.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_16.与丘且丟不丅丏万丆());
        }
        
        }
        
        }
        
        }
        
        UnityEngine.GameObject val_19 = this.playerRank.gameObject;
        if(val_19 == null)
        {
            goto label_42;
        }
        
        if(东一丁世丑丞业丄丐.专丞上七七且丝七丗 == null)
        {
            goto label_43;
        }
        
        label_47:
        val_19.SetActive(value:  true);
        val_22 = 东一丁世丑丞业丄丐.专世专丟丝丌与丘上.ToString();
        this.playerRank.text = val_22;
        if(不丏且丑丆丌三世丈 == false)
        {
            goto label_45;
        }
        
        return;
        label_1:
        this.Clear(世丒丝东上丕七世且:  false);
        return;
        label_42:
        if(东一丁世丑丞业丄丐.专丞上七七且丝七丗 != null)
        {
            goto label_47;
        }
        
        label_43:
        val_19.SetActive(value:  false);
        if(不丏且丑丆丌三世丈 == true)
        {
                return;
        }
        
        label_45:
        if(this.丝丞下七三与业一丞 == false)
        {
                return;
        }
        
        this.丝丞下七三与业一丞 = false;
        this.btnKickPlayer.gameObject.SetActive(value:  false);
    }
    public void Clear(bool 世丒丝东上丕七世且)
    {
        Rilisoft.ButtonHandler val_11;
        bool val_12;
        this.playerContainer.SetActive(value:  false);
        this.丝丞下七三与业一丞 = false;
        if(this.btnKickPlayer != 0)
        {
                this.btnKickPlayer.gameObject.SetActive(value:  false);
        }
        
        if(this.emptyContainer != 0)
        {
                this.emptyContainer.SetActive(value:  true);
        }
        
        if(this.isMineFrame != 0)
        {
                this.isMineFrame.SetActive(value:  false);
        }
        
        if(this.readySprite != 0)
        {
                this.readySprite.SetActive(value:  false);
        }
        
        if(this.noTickets != 0)
        {
                this.noTickets.SetActive(value:  false);
        }
        
        val_11 = this.btnAddPlayer;
        if(val_11 == 0)
        {
            goto label_25;
        }
        
        val_11 = this.btnAddPlayer.gameObject;
        if(世丒丝东上丕七世且 == false)
        {
            goto label_27;
        }
        
        val_12 = this.丛丆丏丛业丞丄丄东;
        if(val_11 != null)
        {
            goto label_30;
        }
        
        goto label_29;
        label_27:
        val_12 = 0;
        if(val_11 != null)
        {
            goto label_30;
        }
        
        label_29:
        label_30:
        val_11.SetActive(value:  (val_12 != 0) ? 1 : 0);
        label_25:
        if(this.playerInBattle != 0)
        {
                this.playerInBattle.SetActive(value:  false);
        }
        
        this.东一丁世丑丞业丄丐 = 0;
    }
    public void OnClick()
    {
        var val_6;
        if(this.playerContainer.activeSelf == false)
        {
                return;
        }
        
        if(this.btnKickPlayer == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(SquadController.丄丘七三上丕世丞业.CanKickPlayer == false)
        {
                return;
        }
        
        bool val_6 = this.丝丞下七三与业一丞;
        val_6 = val_6 ^ 1;
        this.丝丞下七三与业一丞 = val_6;
        this.btnKickPlayer.gameObject.SetActive(value:  (this.丝丞下七三与业一丞 == true) ? 1 : 0);
    }
    private void 丙丟丁下三丒与丞丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        this.丝丞下七三与业一丞 = false;
        this.btnKickPlayer.gameObject.SetActive(value:  false);
        val_2 = null;
        val_2 = null;
        SquadController.丄丘七三上丕世丞业.KickPlayer(专丞上七七且丝七丗:  this.东一丁世丑丞业丄丐, 三不与丐下丕丅世丙:  true);
    }
    public SquadPlayerPreview()
    {
    
    }

}
