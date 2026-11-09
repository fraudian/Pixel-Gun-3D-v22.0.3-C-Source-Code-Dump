using UnityEngine;
public class DungeonTableItem : MonoBehaviour
{
    // Fields
    public UILabel playerName;
    public LikeButtonHandler likeButton;
    public UILabel scorePlayers;
    public UILabel deathCountPlayers;
    public UILabel countKillsPlayers;
    public UILabel totalPercent;
    public UITexture[] playerPortrait;
    public UnityEngine.GameObject portraitCont;
    public UnityEngine.GameObject emptyPortraitCont;
    public UnityEngine.GameObject maxScoreGlow;
    public UnityEngine.GameObject maxKillsGlow;
    public UnityEngine.GameObject maxPercentGlow;
    public UnityEngine.GameObject maxDeathGlow;
    public UnityEngine.GameObject winnerIcon;
    public UnityEngine.GameObject isMineBorder;
    public UnityEngine.GameObject addFriendBtn;
    private string 丆世丘丒丒丏上且丗;
    private string 世上七丝三丂丒三丛;
    private bool 丌且下丕下下丌万丞;
    
    // Methods
    internal void 与万不丄丄东丁与业(NetworkStartTable 不且上一上丐三万丛, int 且丏上下丘丐一丅丗, bool 丏丆丑丗七丄丙丝与, bool 丞万丌丒一业万丌下, bool 丞丆丛一丟下丏丆丄, bool 且丒丆丗一丁丈业丗, bool 丟丛不丟丐丈丙丁丂)
    {
        var val_30;
        var val_31;
        var val_32;
        UnityEngine.Texture val_33;
        UnityEngine.GameObject val_34;
        UnityEngine.GameObject val_35;
        var val_36;
        string val_37;
        var val_38;
        bool val_39;
        this.gameObject.SetActive(value:  true);
        val_30 = null;
        val_30 = null;
        if(不且上一上丐三万丛 != null)
        {
                val_31 = this;
            this.丆世丘丒丒丏上且丗 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
            mem[1152921525964226064] = 不且上一上丐三万丛.丂丈丐不丏万三七丐;
        }
        else
        {
                val_31 = this;
            this.丆世丘丒丒丏上且丗 = 36;
            mem[1152921525964226064] = 8;
        }
        
        this.丌且下丕下下丌万丞 = 不且上一上丐三万丛.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
        val_32 = 0;
        goto label_9;
        label_18:
        UITexture val_30 = this.playerPortrait[0];
        if(不且上一上丐三万丛.万丛丏万丟丕丒丛与 == 0)
        {
            goto label_13;
        }
        
        val_33 = 不且上一上丐三万丛.万丛丏万丟丕丒丛与;
        if(val_30 != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_13:
        val_33 = 不且上一上丐三万丛.丌丏丞丆丗与东丗业;
        if(val_30 != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        val_32 = 1;
        label_9:
        if(val_32 < this.playerPortrait.Length)
        {
            goto label_18;
        }
        
        this.portraitCont.SetActive(value:  true);
        this.emptyPortraitCont.SetActive(value:  false);
        this.playerName.text = this.世上七丝三丂丒三丛;
        this.playerName.gameObject.SetActive(value:  true);
        this.maxScoreGlow.SetActive(value:  丞万丌丒一业万丌下);
        val_34 = this.maxKillsGlow;
        val_34.SetActive(value:  丞丆丛一丟下丏丆丄);
        this.maxPercentGlow.SetActive(value:  且丒丆丗一丁丈业丗);
        val_35 = this.maxDeathGlow;
        val_35.SetActive(value:  丟丛不丟丐丈丙丁丂);
        if((((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 != false) && (GameConnect.丑丌丛丈丅丅与不业() != 20)) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && ((System.String.op_Inequality(a:  this.丆世丘丒丒丏上且丗, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false))
        {
                if(this.likeButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  true);
            val_35 = this.likeButton;
            val_36 = null;
            val_37 = this.丆世丘丒丒丏上且丗;
            val_34 = PlayerLikeController.丄丘七三上丕世丞业.一且丈丅丏丏丟丌世(丞丅上丏丂且下丅与:  null);
            val_35.丈且东丑丂且万丒丅(丄丒且丙三丆丟与丏:  this.丆世丘丒丒丏上且丗, 丞丞下东且丗丄丒丏:  this.世上七丝三丂丒三丛, 丐丑丘与丘丈丟丒且:  val_34, 一七不三丌专三丆一:  false);
        }
        
        }
        
        if(丏丆丑丗七丄丙丝与 == false)
        {
            goto label_49;
        }
        
        val_38 = null;
        val_38 = null;
        val_39 = mem[DungeonsController.丄丘七三上丕世丞业 + 137];
        val_39 = DungeonsController.丄丘七三上丕世丞业.丕丈业丟丆七上专丟;
        if(this.winnerIcon != null)
        {
            goto label_55;
        }
        
        goto label_54;
        label_49:
        val_39 = 0;
        if(this.winnerIcon != null)
        {
            goto label_55;
        }
        
        label_54:
        label_55:
        this.winnerIcon.SetActive(value:  (val_39 != 0) ? 1 : 0);
        this.isMineBorder.SetActive(value:  (this.丌且下丕下下丌万丞 == true) ? 1 : 0);
        this.addFriendBtn.SetActive(value:  (this.丌且下丕下下丌万丞 == false) ? 1 : 0);
        this.scorePlayers.text = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丝丈丅一丆丗丝丝丘()).ToString();
        this.countKillsPlayers.text = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丑丛丆三丆丄七丐万()).ToString();
        this.deathCountPlayers.text = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丘不丄一丒丆丒丅万()).ToString();
        this.totalPercent.text = System.String.Format(format:  "{0}%", arg0:  且丏上下丘丐一丅丗);
    }
    internal void 丙业不丐且丅业丄丏(丈万且丗丂丝丙一东 不且上一上丐三万丛, int 且丏上下丘丐一丅丗, bool 丏丆丑丗七丄丙丝与, bool 丞万丌丒一业万丌下, bool 丞丆丛一丟下丏丆丄, bool 且丒丆丗一丁丈业丗, bool 丟丛不丟丐丈丙丁丂)
    {
        var val_26;
        var val_27;
        var val_28;
        UnityEngine.GameObject val_29;
        UnityEngine.GameObject val_30;
        var val_31;
        string val_32;
        var val_33;
        bool val_34;
        this.gameObject.SetActive(value:  true);
        val_26 = null;
        val_26 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
            goto label_4;
        }
        
        if(不且上一上丐三万丛 == null)
        {
            goto label_5;
        }
        
        label_7:
        val_27 = this;
        this.丆世丘丒丒丏上且丗 = 不且上一上丐三万丛.丆世丘丒丒丏上且丗;
        mem[1152921525964731280] = 不且上一上丐三万丛.丒丘丏上丙丟丑丕丈;
        goto label_6;
        label_4:
        if(不且上一上丐三万丛 != null)
        {
            goto label_7;
        }
        
        label_5:
        val_27 = this;
        this.丆世丘丒丒丏上且丗 = 0;
        mem[1152921525964731280] = 11993091;
        label_6:
        this.丌且下丕下下丌万丞 = 不且上一上丐三万丛.丟丌下三七丁与丟丑();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
        val_28 = 0;
        goto label_10;
        label_15:
        UITexture val_26 = this.playerPortrait[0];
        val_28 = 1;
        label_10:
        if(val_28 < this.playerPortrait.Length)
        {
            goto label_15;
        }
        
        this.portraitCont.SetActive(value:  true);
        this.emptyPortraitCont.SetActive(value:  false);
        this.playerName.text = this.世上七丝三丂丒三丛;
        this.playerName.gameObject.SetActive(value:  true);
        this.maxScoreGlow.SetActive(value:  丞万丌丒一业万丌下);
        val_29 = this.maxKillsGlow;
        val_29.SetActive(value:  丞丆丛一丟下丏丆丄);
        this.maxPercentGlow.SetActive(value:  且丒丆丗一丁丈业丗);
        val_30 = this.maxDeathGlow;
        val_30.SetActive(value:  丟丛不丟丐丈丙丁丂);
        if((((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 != false) && (GameConnect.丑丌丛丈丅丅与不业() != 20)) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && ((System.String.op_Inequality(a:  this.丆世丘丒丒丏上且丗, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false))
        {
                if(this.likeButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  true);
            val_30 = this.likeButton;
            val_31 = null;
            val_32 = this.丆世丘丒丒丏上且丗;
            val_29 = PlayerLikeController.丄丘七三上丕世丞业.一且丈丅丏丏丟丌世(丞丅上丏丂且下丅与:  null);
            val_30.丈且东丑丂且万丒丅(丄丒且丙三丆丟与丏:  this.丆世丘丒丒丏上且丗, 丞丞下东且丗丄丒丏:  this.世上七丝三丂丒三丛, 丐丑丘与丘丈丟丒且:  val_29, 一七不三丌专三丆一:  false);
        }
        
        }
        
        if(丏丆丑丗七丄丙丝与 == false)
        {
            goto label_47;
        }
        
        val_33 = null;
        val_33 = null;
        val_34 = mem[DungeonsController.丄丘七三上丕世丞业 + 137];
        val_34 = DungeonsController.丄丘七三上丕世丞业.丕丈业丟丆七上专丟;
        if(this.winnerIcon != null)
        {
            goto label_53;
        }
        
        goto label_52;
        label_47:
        val_34 = 0;
        if(this.winnerIcon != null)
        {
            goto label_53;
        }
        
        label_52:
        label_53:
        this.winnerIcon.SetActive(value:  (val_34 != 0) ? 1 : 0);
        this.isMineBorder.SetActive(value:  (this.丌且下丕下下丌万丞 == true) ? 1 : 0);
        this.addFriendBtn.SetActive(value:  (this.丌且下丕下下丌万丞 == false) ? 1 : 0);
        this.scorePlayers.text = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.万且丒下丕丝专丟上).ToString();
        this.countKillsPlayers.text = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丌与三与三丆丙一丟).ToString();
        this.deathCountPlayers.text = UnityEngine.Mathf.Max(a:  0, b:  不且上一上丐三万丛.丈一七上丛丗丄丘丞).ToString();
        this.totalPercent.text = System.String.Format(format:  "{0}%", arg0:  且丏上下丘丐一丅丗);
    }
    internal void 丑丄与万世且丛且上()
    {
        this.丆世丘丒丒丏上且丗 = "-1";
        goto label_1;
        label_5:
        UITexture val_2 = this.playerPortrait[0];
        0 = 1;
        label_1:
        if(0 < this.playerPortrait.Length)
        {
            goto label_5;
        }
        
        this.portraitCont.SetActive(value:  false);
        this.emptyPortraitCont.SetActive(value:  true);
        this.playerName.gameObject.SetActive(value:  false);
        this.maxScoreGlow.SetActive(value:  false);
        this.maxKillsGlow.SetActive(value:  false);
        this.maxPercentGlow.SetActive(value:  false);
        this.maxDeathGlow.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
        this.winnerIcon.SetActive(value:  false);
        this.isMineBorder.SetActive(value:  false);
        this.addFriendBtn.SetActive(value:  false);
        this.scorePlayers.text = "0";
        this.countKillsPlayers.text = "0";
        this.deathCountPlayers.text = "0";
        this.totalPercent.text = "0%";
    }
    private void Update()
    {
    
    }
    private void OnClick()
    {
        var val_12;
        var val_13;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 == true)
        {
                return;
        }
        
        if(this.丌且下丕下下丌万丞 != false)
        {
                return;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if((System.String.op_Equality(a:  this.丆世丘丒丒丏上且丗, b:  "-1")) == true)
        {
                return;
        }
        
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丆丗丌世且丛丐丒丗(丛丄世丐丐丗且丈与:  this.丆世丘丒丒丏上且丗, 丆丆丂业丒丈丙丒丅:  this.世上七丝三丂丒三丛, 下上丐东丛丗丐且丑:  false);
    }
    public DungeonTableItem()
    {
    
    }

}
