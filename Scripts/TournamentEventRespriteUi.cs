using UnityEngine;
internal sealed class TournamentEventRespriteUi : PGBehaviour
{
    // Fields
    internal UnityEngine.GameObject windowBody;
    internal UnityEngine.GameObject darken;
    private UILabel progressLeaderboardLabel;
    private UnityEngine.GameObject _goldCont;
    private UILabel _goldLabel;
    private UnityEngine.GameObject _greenCont;
    private UILabel _greenLabel;
    private UnityEngine.GameObject _redCont;
    private UILabel _redLabel;
    private UILabel attempsLabel;
    private System.Collections.Generic.List<UILabel> restProgressLabel;
    private UILabel restProgressCountLabel;
    private UITexture itemIcon;
    private UnityEngine.Coroutine 丏丄丏且丞与世丘下;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    
    // Methods
    public void GoToLobby()
    {
        ExperienceController val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                val_14 = BankController.丑七不且上丗丁一世();
            if(val_14.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                val_14 = ExpController.丑七不且上丗丁一世();
            if(val_14.下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_14 = 1152921505079742464;
        val_15 = null;
        val_15 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_14 = ExperienceController.sharedController;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_18 = null;
            val_18 = null;
            GetComponent<NetworkStartTable>().丗一丄七世不专丞丟();
            return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        bool val_13 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丞丁丛丐不丞丗丒三();
    }
    public void BuyRefreshProgress()
    {
        var val_1;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2;
        val_1 = null;
        val_1 = null;
        val_2 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.丟丄丝丁丆且业丛丄(丆丑丙丌七丗丝丛丅:  this);
    }
    internal void 丆丙丗三东专丐不上()
    {
        var val_9 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 == null)
        {
                return;
        }
        
        this.丐且丘丑与万丞丑丅 = GameConnect.丈丝丂丐丟万丙丑丕;
        this.丝上丗不丒且世丌丑();
        丈丞丕丘丕丗与上一 val_1 = 丈丞丕丘丕丗与上一.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  GameConnect.丈丝丂丐丟万丙丑丕.丙专且丂七与三丘丙);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.restProgressCountLabel, 丕丗丘丑丛与丑业丒:  val_1.丟丂丞不专丆万丒世());
        UnityEngine.Texture val_8 = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  System.String.Format(format:  "{0}::{1}", arg0:  val_1.东与三丌丅三丒丏业().Replace(oldValue:  "Currency", newValue:  System.String.alignConst), arg1:  val_1.丟丂丞不专丆万丒世())).Icon;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.darken, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.windowBody, 丏业丟一东丂东丘丛:  true);
        this.丏丈丞丐业专不世丝();
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = CoroutineRunner.不七丏丝丒一下丄万(丂三丟丂丈丐丆丗丟:  0.1f, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void TournamentEventRespriteUi::丝上丗不丒且世丌丑()));
    }
    private void OnDestroy()
    {
        this.丏东丄丞丛七世业丟();
    }
    internal void 丏丆下丘丅丙丐丌丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.windowBody, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.darken, 丏业丟一东丂东丘丛:  false);
        this.丏东丄丞丛七世业丟();
    }
    private string 丕不丞丏上与下一丟(string 下上丐丆丝丟丝丒不)
    {
        return I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  下上丐丆丝丟丝丒不);
    }
    private void 丏丈丞丐业专不世丝()
    {
        if(this.丏丄丏且丞与世丘下 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丏丄丏且丞与世丘下);
        }
        
        this.丏丄丏且丞与世丘下 = CoroutineRunner.Instance.StartCoroutine(routine:  this.且一丏丏专不丙东丁());
    }
    private void 丏东丄丞丛七世业丟()
    {
        if(this.丏丄丏且丞与世丘下 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丏丄丏且丞与世丘下);
        this.丏丄丏且丞与世丘下 = 0;
    }
    private System.Collections.IEnumerator 且一丏丏专不丙东丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TournamentEventRespriteUi.丒三丈且丌丏丗丄业();
    }
    internal void 丝上丗不丒且世丌丑()
    {
        UILabel val_15;
        var val_16;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_17;
        UILabel val_18;
        var val_19;
        var val_20;
        val_15 = this;
        val_16 = null;
        val_16 = null;
        val_17 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_17 == null)
        {
                return;
        }
        
        val_17 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_17 == null)
        {
                val_17 = 0;
        }
        
        System.TimeSpan val_2 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.业一上且丒且且丞丂(丆业丗丁丕且上下丙:  val_17.业上丙丞丐丄丆丅七());
        if((val_2._ticks.Hours & 2147483648) != 0)
        {
            goto label_10;
        }
        
        int val_4 = val_2._ticks.Minutes;
        if((val_4 & 2147483648) != 0)
        {
            goto label_10;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.attempsLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_4.丕不丞丏上与下一丟(下上丐丆丝丟丝丒不:  "Key_7943"), arg0:  val_2._ticks.Hours, arg1:  val_2._ticks.Minutes));
        val_18 = this.attempsLabel;
        val_19 = 1;
        goto label_13;
        label_10:
        val_18 = this.attempsLabel;
        val_19 = 0;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  false);
        int val_10 = 0;
        val_20 = null;
        val_20 = null;
        LeaderboardEventController.丑丐丄丆丛丁丟丗丅.丂业丂业万业万丏丆(丟丟丄专上丟丁丐丝:  GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七(), 且丒丛与丞世丙丕丌: ref  val_10, 万且丒下丕丝专丟上: ref  val_10);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.progressLeaderboardLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  LeaderboardEventController.丑丐丄丆丛丁丟丗丅.丕不丞丏上与下一丟(下上丐丆丝丟丝丒不:  "Key_7949"), arg0:  0));
        int val_13 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丑世丄丒丌东下丑丙(与不下三丈专丘丂世:  GameConnect.丈丝丂丐丟万丙丑丕, 且丒丛与丞世丙丕丌:  0);
        if(val_13 == 1)
        {
            goto label_24;
        }
        
        if(val_13 != 0)
        {
            goto label_25;
        }
        
        this._goldCont.SetActive(value:  true);
        this._greenCont.SetActive(value:  false);
        this._redCont.SetActive(value:  false);
        val_15 = this._goldLabel;
        goto label_33;
        label_24:
        this._goldCont.SetActive(value:  false);
        this._greenCont.SetActive(value:  true);
        this._redCont.SetActive(value:  false);
        val_15 = this._greenLabel;
        goto label_33;
        label_25:
        this._goldCont.SetActive(value:  false);
        this._greenCont.SetActive(value:  false);
        this._redCont.SetActive(value:  true);
        val_15 = this._redLabel;
        label_33:
        val_15.text = 0.ToString();
    }
    public TournamentEventRespriteUi()
    {
    
    }

}
