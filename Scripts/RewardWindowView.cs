using UnityEngine;
public class RewardWindowView : MonoBehaviour
{
    // Fields
    private UIBasicSprite battlePassReward;
    private UIBasicSprite pixelPassCurrencyReward;
    private UIBasicSprite pixelPassExpReward;
    private UIBasicSprite detailsReward;
    private UIBasicSprite detailsGear;
    private UIBasicSprite moduleChestReward;
    public CountingLabel clanMedalsCounter;
    public CountingLabel bpCurrencyCounter;
    public CountingLabel pixelPassCurrencyCounter;
    public CountingLabel pixelPassExpCounter;
    public CountingLabel detailsCounter;
    public CountingLabel moduleChestCounter;
    private UIBasicSprite clanReward;
    public CountingLabel coinsCounter;
    private UIBasicSprite coinsReward;
    private UIBasicSprite gemsReward;
    private UIBasicSprite itemReward;
    private UnityEngine.GameObject objectEventChestSpinReward;
    private UIBasicSprite spriteEventChestSpinReward;
    private PiggyProgressView _piggyProgressView;
    private bool 丐万丈与丒业世业丞;
    private bool 丆丆且丘丏七与且业;
    private bool 业不万七下丂专丝且;
    private bool 丏丕丏丆丁丌一丌上;
    private bool 下一丄丝专丛一专丌;
    private bool 下丒世东丒丂且丌世;
    private bool 丗丞丟下东七不万东;
    private bool 与专一七丛丅专丒下;
    public float countingDuration;
    private UIBasicSprite eventReward;
    public CountingLabel expCounter;
    public CountingLabel eventCounter;
    private UIBasicSprite expReward;
    public FrameResizer frameReward;
    private UnityEngine.GameObject goToClans;
    private UIBasicSprite trophyReward;
    private UnityEngine.GameObject goToClansToOpenChests;
    private UnityEngine.GameObject goToModulesChests;
    public UnityEngine.AudioClip labelSound;
    private UILabel[] rewardBattleaPassCurrencyLabel;
    private UILabel[] rewardPixelPassCurrencyLabel;
    private UILabel[] rewardPixelPassExpLabel;
    private UILabel[] itemRewardLabel;
    private UILabel[] rewardGemsLabel;
    private UILabel[] rewardClanCurrencyLabel;
    private UILabel bonusForVideoLabel;
    private UILabel[] rewardCoinsLabel;
    private UILabel[] rewardEventCurrencyLabel;
    private UILabel[] rewardExperienceLabel;
    private UILabel[] rewardTrophiesLabel;
    private UILabel[] rewardSniperEventCurrencyLabel;
    private UILabel[] rewardTrophyLabel;
    private UIBasicSprite sniperEventReward;
    private UIBasicSprite spriteGoToClansToOpenChests;
    private UnityEngine.Transform targetCoins;
    private UnityEngine.Transform targetExp;
    private UIBasicSprite[] trophyItems;
    private bool 丂三丅丟七丕东丂与;
    public UnityEngine.GameObject x2Daily;
    public UnityEngine.GameObject x2Advert;
    public UnityEngine.GameObject x2Siege;
    public UnityEngine.GameObject x2Vip;
    public UnityEngine.GameObject xMapEvent;
    public UnityEngine.GameObject Vip20;
    
    // Properties
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    public UIBasicSprite 丁丂丝丗七下万丞丐 { get; }
    public UIBasicSprite 丞丂丙专三丙与业三 { get; }
    public UIBasicSprite 东丒丈下丙丈丘丁专 { get; }
    public UIBasicSprite 丅丐丛与且丈上丙丙 { get; }
    public UIBasicSprite 丄丐丂三丝丞丗丙且 { get; }
    public UIBasicSprite 专丅丛丏丗一丏丑丟 { get; }
    public UIBasicSprite 万世丞丆世丙丝丟丘 { get; }
    public UIBasicSprite 丌丐丝丄丕七丌上下 { get; }
    public UIBasicSprite 丈专七丞三丙丘丛与 { get; }
    public UIBasicSprite 丄与丘丑业专丞七丅 { get; }
    public UIBasicSprite 丌上下不丅万三丘丁 { get; }
    public UIBasicSprite 丂丟东业与一三专丄 { get; }
    public UIBasicSprite 下丌专丈丘上丗丗丝 { get; }
    public UIBasicSprite 丈与不丌丞丕七丗丆 { get; }
    public UnityEngine.GameObject 上丘不丏下丅丕丛世 { get; }
    public UnityEngine.GameObject 丞万丕丅丈丄丅与丝 { get; }
    public UnityEngine.GameObject 业三丝丕丐世丏丆丏 { get; }
    public UnityEngine.GameObject 丈丏丞且不一三世万 { get; }
    public UIBasicSprite 丒丛下下万下一下万 { get; }
    public UIBasicSprite 丐丆丟丛上七丈丆东 { get; }
    public UIBasicSprite[] 丏丙下丐下专丐丌世 { get; }
    public UnityEngine.Transform 东丒七万东丏丘七万 { get; }
    public UnityEngine.Transform 一丄丐万丌上世一三 { get; }
    
    // Methods
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    public UIBasicSprite get_CoinsReward()
    {
        return (UIBasicSprite)this.coinsReward;
    }
    public UIBasicSprite get_ExpReward()
    {
        return (UIBasicSprite)this.expReward;
    }
    public UIBasicSprite get_BattlePassReward()
    {
        return (UIBasicSprite)this.battlePassReward;
    }
    public UIBasicSprite get_PixelPassCurrencyReward()
    {
        return (UIBasicSprite)this.pixelPassCurrencyReward;
    }
    public UIBasicSprite get_PixelPassExpReward()
    {
        return (UIBasicSprite)this.pixelPassExpReward;
    }
    public UIBasicSprite get_DetailsReward()
    {
        return (UIBasicSprite)this.detailsReward;
    }
    public UIBasicSprite get_DetailsGear()
    {
        return (UIBasicSprite)this.detailsGear;
    }
    public UIBasicSprite get_ModuleChestReward()
    {
        return (UIBasicSprite)this.moduleChestReward;
    }
    public UIBasicSprite get_GemsReward()
    {
        return (UIBasicSprite)this.gemsReward;
    }
    public UIBasicSprite get_ItemReward()
    {
        return (UIBasicSprite)this.itemReward;
    }
    public UIBasicSprite get_TrophyReward()
    {
        return (UIBasicSprite)this.trophyReward;
    }
    public UIBasicSprite get_EventReward()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.eventReward);
        this.eventReward = val_1;
        return val_1;
    }
    public UIBasicSprite get_SniperEventReward()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.sniperEventReward);
        this.sniperEventReward = val_1;
        return val_1;
    }
    public UIBasicSprite get_ClanReward()
    {
        return (UIBasicSprite)this.clanReward;
    }
    public UnityEngine.GameObject get_GoToClans()
    {
        return (UnityEngine.GameObject)this.goToClans;
    }
    public UnityEngine.GameObject get_GoToClansToOpenChests()
    {
        return (UnityEngine.GameObject)this.goToClansToOpenChests;
    }
    public UnityEngine.GameObject get_GoToArmoryToModuleChests()
    {
        return (UnityEngine.GameObject)this.goToModulesChests;
    }
    public UnityEngine.GameObject get_EventChestReward()
    {
        return (UnityEngine.GameObject)this.objectEventChestSpinReward;
    }
    public UIBasicSprite get_SpriteGoToClansToOpenChests()
    {
        return (UIBasicSprite)this.spriteGoToClansToOpenChests;
    }
    public UIBasicSprite get_SpriteEventChestReward()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.spriteEventChestSpinReward);
        this.spriteEventChestSpinReward = val_1;
        return val_1;
    }
    public UIBasicSprite[] get_TrophyItems()
    {
        UIBasicSprite[] val_3;
        var val_4;
        if(this.丂三丅丟七丕东丂与 != false)
        {
                val_3 = this.trophyItems;
            return val_3;
        }
        
        this.丂三丅丟七丕东丂与 = true;
        val_3 = new UIBasicSprite[0];
        val_4 = 0;
        goto label_4;
        label_16:
        UIBasicSprite val_2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.trophyItems[0]);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if(val_2 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_2 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_4 = 1;
        val_3[0] = val_2;
        label_4:
        if(val_4 < this.trophyItems.Length)
        {
            goto label_16;
        }
        
        this.trophyItems = val_3;
        return val_3;
    }
    public UnityEngine.Transform get_TargetCoins()
    {
        return (UnityEngine.Transform)this.targetCoins;
    }
    public UnityEngine.Transform get_TargetExp()
    {
        return (UnityEngine.Transform)this.targetExp;
    }
    public void ResetFlags()
    {
        this.丐万丈与丒业世业丞 = false;
        this.丆丆且丘丏七与且业 = false;
        this.业不万七下丂专丝且 = false;
        this.丏丕丏丆丁丌一丌上 = false;
        this.下一丄丝专丛一专丌 = false;
        this.下丒世东丒丂且丌世 = false;
        this.丗丞丟下东七不万东 = false;
        this.与专一七丛丅专丒下 = false;
    }
    public bool IsCounting()
    {
        if(this.coinsCounter != 0)
        {
                if(this.coinsCounter.下丒丑下丟世丆丙丑() == true)
        {
                return true;
        }
        
        }
        
        if(this.expCounter != 0)
        {
                if(this.expCounter.下丒丑下丟世丆丙丑() == true)
        {
                return true;
        }
        
        }
        
        if(this.clanMedalsCounter != 0)
        {
                if(this.clanMedalsCounter.下丒丑下丟世丆丙丑() == true)
        {
                return true;
        }
        
        }
        
        if(this.eventCounter != 0)
        {
                if(this.eventCounter.下丒丑下丟世丆丙丑() == true)
        {
                return true;
        }
        
        }
        
        if(this.bpCurrencyCounter != 0)
        {
                if(this.bpCurrencyCounter.下丒丑下丟世丆丙丑() == true)
        {
                return true;
        }
        
        }
        
        if(this.pixelPassCurrencyCounter != 0)
        {
                if(this.pixelPassCurrencyCounter.下丒丑下丟世丆丙丑() == true)
        {
                return true;
        }
        
        }
        
        if((this.pixelPassExpCounter != 0) && (this.pixelPassExpCounter.下丒丑下丟世丆丙丑() != false))
        {
                return true;
        }
        
        if(this.detailsCounter == 0)
        {
                return true;
        }
        
        if(this.detailsCounter != null)
        {
                return this.detailsCounter.下丒丑下丟世丆丙丑();
        }
        
        return this.detailsCounter.下丒丑下丟世丆丙丑();
    }
    public void StopCounting()
    {
        if(this.coinsCounter != 0)
        {
                this.coinsCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.expCounter != 0)
        {
                this.expCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.clanMedalsCounter != 0)
        {
                this.clanMedalsCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.eventCounter != 0)
        {
                this.eventCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.bpCurrencyCounter != 0)
        {
                this.bpCurrencyCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.pixelPassCurrencyCounter != 0)
        {
                this.pixelPassCurrencyCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.pixelPassExpCounter != 0)
        {
                this.pixelPassExpCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.detailsCounter != 0)
        {
                this.detailsCounter.丌丄丏下七丁专丂世();
        }
        
        if(this.moduleChestCounter == 0)
        {
                return;
        }
        
        this.moduleChestCounter.丌丄丏下七丁专丂世();
    }
    public void RunCounting()
    {
        if(this.coinsCounter != 0)
        {
                this.coinsCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.expCounter != 0)
        {
                this.expCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.clanMedalsCounter != 0)
        {
                this.clanMedalsCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.eventCounter != 0)
        {
                this.eventCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.bpCurrencyCounter != 0)
        {
                this.bpCurrencyCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.pixelPassCurrencyCounter != 0)
        {
                this.pixelPassCurrencyCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.pixelPassExpCounter != 0)
        {
                this.pixelPassExpCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.detailsCounter != 0)
        {
                this.detailsCounter.丄丄丛万丁丐丐与丏();
        }
        
        if(this.moduleChestCounter == 0)
        {
                return;
        }
        
        this.moduleChestCounter.丄丄丛万丁丐丐与丏();
    }
    public void DisableRewards()
    {
        this.coinsReward.gameObject.SetActive(value:  false);
        this.expReward.gameObject.SetActive(value:  false);
        this.EventReward.gameObject.SetActive(value:  false);
        this.SniperEventReward.gameObject.SetActive(value:  false);
        this.clanReward.gameObject.SetActive(value:  false);
        this.battlePassReward.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassCurrencyReward, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassExpReward, 丏业丟一东丂东丘丛:  false);
        if(this.detailsReward != 0)
        {
                this.detailsReward.gameObject.SetActive(value:  false);
        }
        
        if(this.moduleChestReward != 0)
        {
                this.moduleChestReward.gameObject.SetActive(value:  false);
        }
        
        this.gemsReward.gameObject.SetActive(value:  false);
        this.itemReward.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objectEventChestSpinReward, 丏业丟一东丂东丘丛:  false);
        this.trophyReward.gameObject.SetActive(value:  false);
    }
    public UnityEngine.GameObject GetRewardFrameForType(丁丙丆丑不三丌丗丟 丁丅丈丌丟世丗丗丟)
    {
        if((丁丅丈丌丟世丗丗丟 - 1) > 5)
        {
                return 0;
        }
        
        var val_2 = 106030372 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2;
        val_2 = val_2 + 106030372;
        goto (106030372 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2 + 106030372);
    }
    public bool EnableRewardAnimationForType(丁丙丆丑不三丌丗丟 丁丅丈丌丟世丗丗丟)
    {
        UnityEngine.AudioClip val_9;
        var val_11;
        UnityEngine.Object val_12;
        val_9 = this;
        this.DisableRewardAnimations();
        丁丙丆丑不三丌丗丟 val_1 = 丁丅丈丌丟世丗丗丟 - 1;
        if(val_1 <= 5)
        {
                var val_9 = 106030396;
            val_9 = (106030396 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2) + val_9;
        }
        else
        {
                if(val_1 >= 5)
        {
                if(丁丅丈丌丟世丗丗丟 == 6)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[this.Vip20], 丏业丟一东丂东丘丛:  true);
        }
        
            val_11 = 0;
            return (bool)val_11;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[this.Vip20], 丏业丟一东丂东丘丛:  true);
            UnityEngine.Transform val_3 = mem[this.Vip20].transform.GetChild(index:  0);
            if(val_3 != null)
        {
                val_12 = val_3.GetComponent<UnityEngine.Animator>();
        }
        else
        {
                val_12 = 0;
        }
        
            if(val_12 != 0)
        {
                val_12.enabled = true;
        }
        
            if(this.labelSound != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_9 = this.labelSound;
            UnityEngine.AudioSource val_8 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_9);
        }
        
        }
        
            val_11 = 1;
            return (bool)val_11;
        }
    
    }
    private System.Collections.IEnumerator 丗不丁下丝丈不丝丘(UnityEngine.Animator 丐丐七专三且世三七)
    {
        .丐丐七专三且世三七 = 丐丐七专三且世三七;
        return (System.Collections.IEnumerator)new RewardWindowView.丛丏丌丕丞万与丘世(丗丏丅丕丆世丁专丟:  0);
    }
    public void DisableRewardAnimations()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x2Daily, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x2Vip, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x2Advert, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x2Siege, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.xMapEvent, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Vip20, 丏业丟一东丂东丘丛:  false);
    }
    public void SetRewardSpriteColor(UIBasicSprite 与丄丈丘丟丕丏丐丁, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(与丄丈丘丟丕丏丐丁 == 0)
        {
                return;
        }
        
        与丄丈丘丟丕丏丐丁.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    private bool 丘丙专且丒且丘丈丂(int 丄丆七且丟且下丐丑)
    {
        var val_7;
        var val_8;
        PGCompany.七下丐丂丙丑东专丂 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        val_7 = null;
        val_7 = null;
        val_8 = 0;
        if((val_3 != null) && (GameController.丆丘丂丈世丏丟丑丏.丁七丗专业世丈丒下 != true))
        {
                if(val_3.丂丁丏一丙丛业且丌() >= 1)
        {
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = val_3.且业上丞丄丁专不丙();
            bool val_6 = val_5.丑三三丝下丙丌丄下(丈丄不七三万丄丁不:  val_5, 丄丆七且丟且下丐丑:  丄丆七且丟且下丐丑);
        }
        else
        {
                val_8 = 0;
        }
        
        }
        
        val_8 = val_8 & 1;
        return (bool)val_8;
    }
    private bool 丑三三丝下丙丌丄下(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, int 丄丆七且丟且下丐丑)
    {
        var val_4;
        var val_5;
        if(丈丄不七三万丄丁不 == null)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = 丈丄不七三万丄丁不.GetEnumerator();
        val_4 = 1152921525631263872;
        label_4:
        if(((-94722728) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上().业东丅东丌上丗丑不() != 丄丆七且丟且下丐丑)
        {
            goto label_4;
        }
        
        val_5 = 1;
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
    }
    internal void 丘丘丙一与丛丗丅丌(int 丑丁丐丏业丗一丏丈, int 丕丗业下七丕丝七三, int 且丘丞丕丐丗丅丅丂, int 丙与丂丘丁且七丝丅, int 丂世业丏丌丛丛丙丘, bool 不丁丛丈丙世丈万丟, int 万丙丒世七不丌丒丐, int 与上丌丞丙丙丂丈丌, int 且专不下丒万东丟丏, int 世丕丅与丆丄丗丐万, Rilisoft.OfferItem 下丅丙一丂丗丅丝七, Rilisoft.OfferItem 丛丐业丞东七丒下丗, PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 与丑丆丑一丂丑上丙, int 丄下丘丘丗丙丙丕丞, Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
    {
        UnityEngine.GameObject val_91;
        var val_93;
        System.Func<TournamentController, TournamentReward> val_95;
        var val_96;
        var val_97;
        var val_98;
        bool val_99;
        bool val_100;
        bool val_101;
        Rilisoft.OfferItem val_102;
        var val_103;
        UIBasicSprite val_104;
        UnityEngine.GameObject val_105;
        var val_106;
        var val_107;
        UnityEngine.GameObject val_108;
        var val_109;
        var val_110;
        UnityEngine.GameObject val_111;
        var val_112;
        val_91 = this;
        this.coinsReward.gameObject.SetActive(value:  (丑丁丐丏业丗一丏丈 > 0) ? 1 : 0);
        this.expReward.gameObject.SetActive(value:  (丕丗业下七丕丝七三 > 0) ? 1 : 0);
        PGCompany.丁东丌世与丕东丆上.丕丞专丘业三世一丘(三下丒三专丑丗丁丕: ref  new 专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false});
        if(且丘丞丕丐丗丅丅丂 <= 0)
        {
                if((this.丘丙专且丒且丘丈丂(丄丆七且丟且下丐丑:  127)) == false)
        {
            goto label_20;
        }
        
        }
        
        if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  100)) == false)
        {
            goto label_12;
        }
        
        this.EventReward.gameObject.SetActive(value:  true);
        string val_12 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().丁七丐丒丄丏丞七且(世与丂且丘丐万丗丞:  1);
        goto label_19;
        label_12:
        if(((-94168136) & 1) == 0)
        {
            goto label_20;
        }
        
        this.EventReward.gameObject.SetActive(value:  true);
        label_19:
        UnityEngine.Texture2D val_17 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  Rilisoft.丛且世丐丆上七业丁.丒丈一丏丆丅上丕丂(世与丂且丘丐万丗丞:  1));
        if(this.EventReward != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_20:
        this.EventReward.gameObject.SetActive(value:  false);
        label_24:
        UnityEngine.GameObject val_21 = this.SniperEventReward.gameObject;
        if(丙与丂丘丁且七丝丅 >= 1)
        {
                val_21.SetActive(value:  true);
            UnityEngine.Texture2D val_26 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().不上丁丏且丙丞三丅().丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  丙与丂丘丁且七丝丅));
            if(this.SniperEventReward != null)
        {
            goto label_35;
        }
        
        }
        else
        {
                val_21.SetActive(value:  false);
        }
        
        label_35:
        bool val_28 = (丂世业丏丌丛丛丙丘 > 0) ? 1 : 0;
        val_28 = val_28 | 不丁丛丈丙世丈万丟;
        this.clanReward.gameObject.SetActive(value:  val_28);
        val_93 = null;
        val_93 = null;
        val_95 = RewardWindowView.<>c.<>9__124_0;
        if(val_95 == null)
        {
                System.Func<TournamentController, TournamentReward> val_31 = null;
            val_95 = val_31;
            val_31 = new System.Func<TournamentController, TournamentReward>(object:  RewardWindowView.<>c.__il2cppRuntimeField_static_fields, method:  TournamentReward RewardWindowView.<>c::丝丅上东丛丘万丁丑(TournamentController 三丟东丕丄丄下下丑));
            RewardWindowView.<>c.<>9__124_0 = val_95;
        }
        
        TournamentReward val_32 = 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<TournamentReward, TournamentController>(丞下万上三丘上与专:  Rilisoft.Singleton<TournamentController>.Instance, 丏丅丁丛一业丈专专:  val_31);
        val_96 = null;
        val_96 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_33 = GameConnect.丈丝丂丐丟万丙丑丕.丌不丅不丞东万专专();
            val_97 = ((val_33.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) & 1152921538872417320;
        }
        else
        {
                val_97 = 0;
        }
        
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) == false)
        {
            goto label_49;
        }
        
        val_98 = 0;
        if(((val_97 != 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)) || (丐下丝丘丑丟丟丗丌 == null))
        {
            goto label_159;
        }
        
        var val_40 = ((丐下丝丘丑丟丟丗丌.丞上丌丌丕丘专丒丕(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) < 2) ? 1 : 0;
        goto label_159;
        label_49:
        val_98 = 0;
        label_159:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToClans, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToClansToOpenChests, 丏业丟一东丂东丘丛:  false);
        if(万丙丒世七不丌丒丐 > 0)
        {
                val_99 = 1;
        }
        else
        {
                val_99 = this.丘丙专且丒且丘丈丂(丄丆七且丟且下丐丑:  199);
        }
        
        this.battlePassReward.gameObject.SetActive(value:  val_99);
        if(与上丌丞丙丙丂丈丌 > 0)
        {
                val_100 = 1;
        }
        else
        {
                val_100 = this.丘丙专且丒且丘丈丂(丄丆七且丟且下丐丑:  159);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassCurrencyReward, 丏业丟一东丂东丘丛:  val_100);
        if(且专不下丒万东丟丏 > 0)
        {
                val_101 = 1;
        }
        else
        {
                val_101 = this.丘丙专且丒且丘丈丂(丄丆七且丟且下丐丑:  183);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassExpReward, 丏业丟一东丂东丘丛:  val_101);
        val_102 = 丛丐业丞东七丒下丗;
        this.gemsReward.gameObject.SetActive(value:  (世丕丅与丆丄丗丐万 > 0) ? 1 : 0);
        UnityEngine.GameObject val_47 = this.detailsReward.gameObject;
        if(val_102 == null)
        {
            goto label_72;
        }
        
        if(val_47 != null)
        {
            goto label_112;
        }
        
        label_113:
        label_112:
        val_47.SetActive(value:  (val_102.Count > 0) ? 1 : 0);
        this.moduleChestReward.gameObject.SetActive(value:  (与丑丆丑一丂丑上丙 != 0) ? 1 : 0);
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丟丂且丈且丂世三丕() != false)
        {
                val_103 = (~(GameConnect.丞丗东丆下丈丒东业(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业()))) & 1;
        }
        else
        {
                val_103 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._piggyProgressView, 丏业丟一东丂东丘丛:  false);
        bool val_56 = (val_97 != 0) ? 1 : 0;
        val_104 = this.trophyReward.gameObject;
        val_56 = ((丄下丘丘丗丙丙丕丞 != 0) ? 1 : 0) & val_56;
        val_104.SetActive(value:  val_56);
        if(下丅丙一丂丗丅丝七 == null)
        {
            goto label_85;
        }
        
        val_104 = this.itemReward;
        UnityEngine.GameObject val_60 = val_104.gameObject;
        if(下丅丙一丂丗丅丝七.Type != 1130)
        {
            goto label_87;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_60, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objectEventChestSpinReward, 丏业丟一东丂东丘丛:  true);
        val_104 = 1152921505061052416;
        if((ExperienceController.丞丞丘业东丙丏七丌() != 5) || (ExperienceController.丞丞丘业东丙丏七丌() > 64))
        {
            goto label_176;
        }
        
        val_104 = ExperienceController.上业丆丘丟丐且丘丝;
        if(((ExperienceController.万丏丙丈东东万丝丞() + 丕丗业下七丕丝七三) < (val_104.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  ExperienceController.丞丞丘业东丙丏七丌()))) || (业丈不上丟万一丕丏.丑七不且上丗丁一世().丗业丝万业一与三且() != 0))
        {
            goto label_176;
        }
        
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丑东东丒丑丁不丕() != true)
        {
                if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() != 1)
        {
            goto label_176;
        }
        
        }
        
        UIButton val_73 = this.objectEventChestSpinReward.GetComponentInChildren<UIButton>();
        if((val_73 == 0) || (val_73 != null))
        {
            goto label_176;
        }
        
        goto label_176;
        label_72:
        if(val_47 != null)
        {
            goto label_112;
        }
        
        goto label_113;
        label_85:
        val_105 = this.itemReward.gameObject;
        val_106 = 0;
        goto label_117;
        label_87:
        val_106 = 1;
        val_105 = val_60;
        label_117:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_105, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objectEventChestSpinReward, 丏业丟一东丂东丘丛:  false);
        label_176:
        if(val_102 == null)
        {
            goto label_120;
        }
        
        UnityEngine.Texture val_76 = val_102.Texture;
        System.Nullable<ItemRarity> val_77 = val_102.Rarity;
        if(( & 1) == 0)
        {
            goto label_122;
        }
        
        System.Nullable<ItemRarity> val_78 = val_102.Rarity;
        val_107 = ;
        goto label_123;
        label_120:
        val_108 = this.detailsReward.gameObject;
        val_109 = 0;
        goto label_127;
        label_122:
        val_107 = 5;
        label_123:
        UnityEngine.Color val_80 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  5);
        this.detailsGear.color = new UnityEngine.Color() {r = val_80.r, g = val_80.g, b = val_80.b, a = val_80.a};
        if(this.detailsCounter.targets == null)
        {
            goto label_132;
        }
        
        val_102 = this.detailsCounter.targets;
        val_110 = 0;
        goto label_134;
        label_138:
        val_102[0].color = new UnityEngine.Color() {r = val_80.r, g = val_80.g, b = val_80.b, a = val_80.a};
        val_110 = 1;
        label_134:
        if(val_110 < this.detailsCounter.targets.Length)
        {
            goto label_138;
        }
        
        label_132:
        val_109 = 1;
        val_108 = this.detailsReward.gameObject;
        label_127:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_108, 丏业丟一东丂东丘丛:  true);
        if(与丑丆丑一丂丑上丙 == null)
        {
            goto label_142;
        }
        
        if(与丑丆丑一丂丑上丙.丈丄丈丛世丈专与丘 == null)
        {
            goto label_143;
        }
        
        val_102 = 与丑丆丑一丂丑上丙.丈丄丈丛世丈专与丘;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleChestReward.gameObject, 丏业丟一东丂东丘丛:  true);
        val_111 = this.goToModulesChests;
        goto label_148;
        label_142:
        if(this.moduleChestReward != null)
        {
            goto label_150;
        }
        
        goto label_150;
        label_143:
        if(与丑丆丑一丂丑上丙.丒三丝一上丙专丗丒 != 1)
        {
            goto label_151;
        }
        
        val_102 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons\\ModuleChests\\ModuleChest_Warning");
        val_91 = this.goToModulesChests;
        val_112 = 1;
        val_111 = val_91;
        goto label_155;
        label_151:
        label_150:
        val_91 = this.moduleChestReward.gameObject;
        val_111 = val_91;
        label_148:
        val_112 = 0;
        label_155:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_111, 丏业丟一东丂东丘丛:  false);
    }
    public void ShowTrophiesForItems(System.Collections.Generic.List<UnityEngine.Texture> 丑七不与丛丆一丂丞)
    {
        var val_7;
        var val_8;
        val_7 = 0;
        goto label_1;
        label_14:
        val_8 = this.TrophyItems[0].gameObject;
        if(val_7 < 丑七不与丛丆一丂丞.Count)
        {
                val_8.SetActive(value:  true);
            val_8 = 丑七不与丛丆一丂丞.Item[0];
            if(this.TrophyItems[0] != null)
        {
            goto label_12;
        }
        
        }
        else
        {
                val_8.SetActive(value:  false);
        }
        
        label_12:
        val_7 = 1;
        label_1:
        UIBasicSprite[] val_6 = this.TrophyItems;
        if(val_7 < val_6.Length)
        {
            goto label_14;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToClans, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToClansToOpenChests, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objectEventChestSpinReward, 丏业丟一东丂东丘丛:  false);
    }
    public void DisableTrophies()
    {
        goto label_0;
        label_6:
        this.TrophyItems[0].gameObject.SetActive(value:  false);
        0 = 1;
        label_0:
        UIBasicSprite[] val_3 = this.TrophyItems;
        if(0 < val_3.Length)
        {
            goto label_6;
        }
    
    }
    public bool AnyRewardIsActive()
    {
        if(this.coinsReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.expReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.EventReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.SniperEventReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.battlePassReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.pixelPassCurrencyReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.pixelPassExpReward.gameObject.activeSelf == true)
        {
                return true;
        }
        
        if(this.gemsReward.gameObject.activeSelf != false)
        {
                return true;
        }
        
        UnityEngine.GameObject val_19 = this.detailsReward.gameObject;
        if(val_19 != null)
        {
                return val_19.activeSelf;
        }
        
        return val_19.activeSelf;
    }
    public void Resize()
    {
        this.frameReward.ResizeFrame();
    }
    internal void 丝丗丌上丐丑业一业()
    {
        if(this.bonusForVideoLabel == 0)
        {
                UnityEngine.Debug.LogError(message:  "[RewardWindowView.SetBonusForVideoLabel] bonusForVideoLabel: null");
            return;
        }
        
        int val_3 = Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().丕三七丏且下丞丛不();
        this.bonusForVideoLabel.text = System.String.Format(provider:  RewardWindowView.丙专丝世不业下丂丈(), format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8931"), arg0:  val_3.ToString(provider:  RewardWindowView.丙专丝世不业下丂丈()));
        int val_10 = System.Convert.ToInt32(value:  (val_3 != 2) ? 1 : 0);
        PGCompany.SpriteSelector val_11 = this.bonusForVideoLabel.GetComponent<PGCompany.SpriteSelector>();
        if(val_11 != null)
        {
                val_11.丄丄且丞丒丒丘丙丁(丏丙东下丌三丑与丕:  val_10);
        }
        
        this = this.bonusForVideoLabel;
        PGCompany.GameObjectSelector val_12 = this.GetComponentInParent<PGCompany.GameObjectSelector>();
        if(val_12 == null)
        {
                return;
        }
        
        val_12.下丟丛丝专不丗丄丈(丝丑丟丏丒且丗丘丛:  val_10);
    }
    internal void 丏丏丟上丙万一丌东(int 丆三与下丅一不丘世, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_18;
        string val_19;
        var val_20;
        var val_21;
        var val_22;
        val_18 = 丆三与下丅一不丘世;
        if(this.丐万丈与丒业世业丞 == false)
        {
            goto label_1;
        }
        
        label_30:
        if(丒丙业丕万丒丞万丂.丒丆丄上丆丌且丅业() != 1)
        {
            goto label_3;
        }
        
        val_19 = "Key_3151";
        if(丒丙业丕万丒丞万丂.丟丈东丒丆丘一丒丗() != 0)
        {
            goto label_6;
        }
        
        var val_3 = (this.丐万丈与丒业世业丞 == true) ? (val_19) : "Key_3148";
        goto label_6;
        label_3:
        val_19 = "Key_3151";
        label_6:
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_19);
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.coinsCounter != 0)
        {
            goto label_16;
        }
        
        }
        
        val_20 = 0;
        goto label_17;
        label_21:
        val_18 = this.rewardCoinsLabel[0];
        val_18.text = System.String.Format(format:  val_4, arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丒丙业丕万丒丞万丂.丟丈东丒丆丘一丒丗() + (丒丙业丕万丒丞万丂.丒丆丄上丆丌且丅业() * val_18)));
        val_20 = 1;
        label_17:
        if(val_20 < this.rewardCoinsLabel.Length)
        {
            goto label_21;
        }
        
        return;
        label_1:
        if(丒丙业丕万丒丞万丂.丒丆丄上丆丌且丅业() <= 1)
        {
            goto label_23;
        }
        
        val_21 = 1;
        goto label_24;
        label_16:
        this.coinsCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        if(丒丙业丕万丒丞万丂 == null)
        {
            goto label_26;
        }
        
        val_22 = 丒丙业丕万丒丞万丂.丒丆丄上丆丌且丅业();
        goto label_27;
        label_23:
        label_24:
        this.丐万丈与丒业世业丞 = (丒丙业丕万丒丞万丂.丟丈东丒丆丘一丒丗() > 0) ? 1 : 0;
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_30;
        }
        
        goto label_30;
        label_26:
        val_22 = 0.丒丆丄上丆丌且丅业();
        label_27:
        this.coinsCounter.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  val_18, 上丘专万丐丐丗丕丈:  丒丙业丕万丒丞万丂.丟丈东丒丆丘一丒丗() + (val_22 * val_18), 丕丂丐丌丆丝且万丗:  val_4);
    }
    internal void 丘业丏丁万上不丐丙(int 丟且丗丆丁丐丅丏丆, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_20;
        string val_21;
        var val_22;
        var val_23;
        var val_24;
        val_20 = 丟且丗丆丁丐丅丏丆;
        if(this.丆丆且丘丏七与且业 == false)
        {
            goto label_1;
        }
        
        label_35:
        if(丒丙业丕万丒丞万丂.丄丂丞丂丗丌一丂丆() != 1)
        {
            goto label_3;
        }
        
        val_21 = "Key_3152";
        if(丒丙业丕万丒丞万丂.专一且丈丁下与丙丗() != 0)
        {
            goto label_6;
        }
        
        var val_3 = (this.丆丆且丘丏七与且业 == true) ? (val_21) : "Key_3149";
        goto label_6;
        label_3:
        val_21 = "Key_3152";
        label_6:
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_21);
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.expCounter != 0)
        {
            goto label_16;
        }
        
        }
        
        val_22 = 0;
        goto label_17;
        label_21:
        val_20 = this.rewardExperienceLabel[0];
        val_20.text = System.String.Format(format:  val_4, arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丒丙业丕万丒丞万丂.专一且丈丁下与丙丗() + (丒丙业丕万丒丞万丂.丄丂丞丂丗丌一丂丆() * val_20)));
        val_22 = 1;
        label_17:
        if(val_22 < this.rewardExperienceLabel.Length)
        {
            goto label_21;
        }
        
        return;
        label_1:
        if(丒丙业丕万丒丞万丂.丄丂丞丂丗丌一丂丆() <= 1)
        {
            goto label_23;
        }
        
        val_23 = 1;
        goto label_24;
        label_16:
        if(丒丙业丕万丒丞万丂.丄丂丞丂丗丌一丂丆() >= 2)
        {
                if(ExperienceController.丞丞丘业东丙丏七丌() > 64)
        {
                return;
        }
        
        }
        
        this.expCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        if(丒丙业丕万丒丞万丂 == null)
        {
            goto label_31;
        }
        
        val_24 = 丒丙业丕万丒丞万丂.丄丂丞丂丗丌一丂丆();
        goto label_32;
        label_23:
        label_24:
        this.丆丆且丘丏七与且业 = (丒丙业丕万丒丞万丂.专一且丈丁下与丙丗() > 0) ? 1 : 0;
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_31:
        val_24 = 0.丄丂丞丂丗丌一丂丆();
        label_32:
        this.expCounter.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  val_20, 上丘专万丐丐丗丕丈:  丒丙业丕万丒丞万丂.专一且丈丁下与丙丗() + (val_24 * val_20), 丕丂丐丌丆丝且万丗:  val_4);
    }
    internal void 业七业丄业丟丄下一(int 丝世三世不丏上七丞, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_29;
        var val_30;
        string val_31;
        CountingLabel val_32;
        var val_33;
        val_29 = 丝世三世不丏上七丞;
        if(this.丏丕丏丆丁丌一丌上 != true)
        {
                if(丒丙业丕万丒丞万丂.丙丟丘下丏丗丗丟丘() > 1)
        {
                val_30 = 1;
        }
        
            this.丏丕丏丆丁丌一丌上 = (丒丙业丕万丒丞万丂.丏丑下丂不一三且丟() > 0) ? 1 : 0;
        }
        
        if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业() != null)
        {
                val_31 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().丟万丏且上业丐丈一();
        }
        else
        {
                val_31 = "Key_3411";
        }
        
        if(丒丙业丕万丒丞万丂.丙丟丘下丏丗丗丟丘() <= 1)
        {
                if(丒丙业丕万丒丞万丂.丏丑下丂不一三且丟() <= 0)
        {
                if(this.丏丕丏丆丁丌一丌上 == false)
        {
            goto label_21;
        }
        
        }
        
        }
        
        string val_13 = System.String.Format(format:  "[fdff00]{0}[-]", arg0:  "{0} " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_31)));
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_38;
        }
        
        label_39:
        label_38:
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.eventCounter != 0)
        {
            goto label_27;
        }
        
        }
        
        val_32 = 0;
        goto label_28;
        label_32:
        val_29 = this.rewardEventCurrencyLabel[0];
        val_29.text = System.String.Format(format:  val_13, arg0:  丒丙业丕万丒丞万丂.丏丑下丂不一三且丟() + (丒丙业丕万丒丞万丂.丙丟丘下丏丗丗丟丘() * val_29));
        val_32 = 1;
        label_28:
        if(val_32 < this.rewardEventCurrencyLabel.Length)
        {
            goto label_32;
        }
        
        return;
        label_27:
        this.eventCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        val_32 = this.eventCounter;
        if(丒丙业丕万丒丞万丂 != null)
        {
                val_33 = 丒丙业丕万丒丞万丂.丙丟丘下丏丗丗丟丘();
        }
        else
        {
                val_33 = 0.丙丟丘下丏丗丗丟丘();
        }
        
        val_32.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  val_29, 上丘专万丐丐丗丕丈:  丒丙业丕万丒丞万丂.丏丑下丂不一三且丟() + (val_33 * val_29), 丕丂丐丌丆丝且万丗:  val_13);
        return;
        label_21:
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_38;
        }
        
        goto label_39;
    }
    internal void 七丂万且一上专丒丁(int 丝世三世不丏上七丞)
    {
        UILabel val_3;
        var val_4;
        val_3 = this;
        val_4 = 0;
        goto label_3;
        label_7:
        val_3 = this.rewardSniperEventCurrencyLabel[0];
        val_3.text = System.String.Format(format:  "{0} {1}", arg0:  丝世三世不丏上七丞, arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5104"));
        val_4 = 1;
        label_3:
        if(val_4 < this.rewardSniperEventCurrencyLabel.Length)
        {
            goto label_7;
        }
    
    }
    internal void 丈丗丟丛丕上三世丙(int 丄下丘丘丗丙丙丕丞)
    {
        UILabel val_4;
        string val_6;
        var val_7;
        val_4 = this;
        if(丄下丘丘丗丙丙丕丞 >= 1)
        {
                string val_1 = System.String.Format(format:  "+{0}", arg0:  丄下丘丘丗丙丙丕丞);
            val_6 = "[14FF05]{0}[-]";
        }
        else
        {
                val_6 = "[E50404]{0}[-]";
        }
        
        val_7 = 0;
        goto label_3;
        label_7:
        val_4 = this.rewardTrophyLabel[0];
        val_4.text = System.String.Format(format:  val_6, arg0:  System.String.Format(format:  "{0}", arg0:  丄下丘丘丗丙丙丕丞));
        val_7 = 1;
        label_3:
        if(val_7 < this.rewardTrophyLabel.Length)
        {
            goto label_7;
        }
    
    }
    internal void 丞与万丌丏下不与丞(int 丌丁且丕丞一一与七, bool 丛丕不丞与丕万世丆, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        CountingLabel val_22;
        CountingLabel val_23;
        string val_24;
        string val_25;
        var val_26;
        UILabel[] val_27;
        var val_28;
        var val_29;
        var val_30;
        val_22 = 丙万丟上丞丒丞万丗;
        val_23 = this;
        if(this.业不万七下丂专丝且 == false)
        {
            goto label_1;
        }
        
        label_39:
        if(丒丙业丕万丒丞万丂.与七丒丟东业丑专一() != 1)
        {
            goto label_3;
        }
        
        val_24 = "Key_5624";
        if(丒丙业丕万丒丞万丂.且丈万丄丅东不业与() != 0)
        {
            goto label_6;
        }
        
        var val_3 = (this.业不万七下丂专丝且 == true) ? (val_24) : "Key_5623";
        goto label_6;
        label_3:
        val_24 = "Key_5624";
        label_6:
        if(丛丕不丞与丕万世丆 == false)
        {
            goto label_7;
        }
        
        val_25 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4353");
        if(val_22 == true)
        {
            goto label_10;
        }
        
        goto label_16;
        label_7:
        val_25 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_24), arg0:  丒丙业丕万丒丞万丂.且丈万丄丅东不业与() + (丒丙业丕万丒丞万丂.与七丒丟东业丑专一() * 丌丁且丕丞一一与七));
        if(val_22 == false)
        {
            goto label_16;
        }
        
        label_10:
        val_22 = this.clanMedalsCounter;
        val_26 = UnityEngine.Object.op_Equality(x:  val_22, y:  0);
        goto label_19;
        label_16:
        val_26 = 1;
        label_19:
        val_26 = val_26 | 丛丕不丞与丕万世丆;
        if(val_26 == false)
        {
            goto label_20;
        }
        
        val_27 = this.rewardClanCurrencyLabel;
        val_28 = 0;
        goto label_21;
        label_25:
        val_27[0].text = val_25;
        val_28 = 1;
        label_21:
        if(val_28 < this.rewardClanCurrencyLabel.Length)
        {
            goto label_25;
        }
        
        if(this.clanMedalsCounter == 0)
        {
                return;
        }
        
        val_23 = this.clanMedalsCounter;
        val_23.丞上丝丗七丁七丑丘();
        return;
        label_1:
        if(丒丙业丕万丒丞万丂.与七丒丟东业丑专一() <= 1)
        {
            goto label_32;
        }
        
        val_29 = 1;
        goto label_33;
        label_20:
        this.clanMedalsCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        val_23 = this.clanMedalsCounter;
        if(丒丙业丕万丒丞万丂 == null)
        {
            goto label_35;
        }
        
        val_30 = 丒丙业丕万丒丞万丂.与七丒丟东业丑专一();
        goto label_36;
        label_32:
        label_33:
        this.业不万七下丂专丝且 = (丒丙业丕万丒丞万丂.且丈万丄丅东不业与() > 0) ? 1 : 0;
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_39;
        }
        
        goto label_39;
        label_35:
        val_30 = 0.与七丒丟东业丑专一();
        label_36:
        val_27 = 丒丙业丕万丒丞万丂.且丈万丄丅东不业与();
        val_22 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_24);
        val_23.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  丌丁且丕丞一一与七, 上丘专万丐丐丗丕丈:  val_27 + (val_30 * 丌丁且丕丞一一与七), 丕丂丐丌丆丝且万丗:  val_22);
    }
    internal void 丏丘七与上丅丗丆丙(int 与上丌丞丙丙丂丈丌, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_20;
        var val_21;
        object val_22;
        CountingLabel val_23;
        var val_24;
        val_20 = 与上丌丞丙丙丂丈丌;
        if(this.丗丞丟下东七不万东 != true)
        {
                if(丒丙业丕万丒丞万丂.不丐世丄不丏业丐丐() > 1)
        {
                val_21 = 1;
        }
        
            this.丗丞丟下东七不万东 = (丒丙业丕万丒丞万丂.下丛业不上丒一丅丄() > 0) ? 1 : 0;
        }
        
        val_22 = "{0} " + PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  159)(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  159));
        if(丒丙业丕万丒丞万丂.不丐世丄不丏业丐丐() <= 1)
        {
                if(丒丙业丕万丒丞万丂.下丛业不上丒一丅丄() <= 0)
        {
                if(this.丗丞丟下东七不万东 == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        val_22 = System.String.Format(format:  "[fdff00]{0}[-]", arg0:  val_22);
        label_12:
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.pixelPassCurrencyCounter != 0)
        {
            goto label_18;
        }
        
        }
        
        val_23 = 0;
        goto label_19;
        label_23:
        val_20 = this.rewardPixelPassCurrencyLabel[0];
        val_20.text = System.String.Format(format:  val_22, arg0:  丒丙业丕万丒丞万丂.下丛业不上丒一丅丄() + (丒丙业丕万丒丞万丂.不丐世丄不丏业丐丐() * val_20));
        val_23 = 1;
        label_19:
        if(val_23 < this.rewardPixelPassCurrencyLabel.Length)
        {
            goto label_23;
        }
        
        return;
        label_18:
        this.pixelPassCurrencyCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        val_23 = this.pixelPassCurrencyCounter;
        if(丒丙业丕万丒丞万丂 != null)
        {
                val_24 = 丒丙业丕万丒丞万丂.不丐世丄不丏业丐丐();
        }
        else
        {
                val_24 = 0.不丐世丄不丏业丐丐();
        }
        
        val_22 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_22);
        val_23.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  val_20, 上丘专万丐丐丗丕丈:  丒丙业丕万丒丞万丂.下丛业不上丒一丅丄() + (val_24 * val_20), 丕丂丐丌丆丝且万丗:  val_22);
    }
    internal void 丏丏丁且专丛丅丗丂(int 且专不下丒万东丟丏, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_20;
        var val_21;
        object val_22;
        CountingLabel val_23;
        var val_24;
        val_20 = 且专不下丒万东丟丏;
        if(this.与专一七丛丅专丒下 != true)
        {
                if(丒丙业丕万丒丞万丂.丘丁丈一与丟下丙丝() > 1)
        {
                val_21 = 1;
        }
        
            this.与专一七丛丅专丒下 = (丒丙业丕万丒丞万丂.与丗世七三丝业丏丏() > 0) ? 1 : 0;
        }
        
        val_22 = "{0} " + PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  183)(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  183));
        if(丒丙业丕万丒丞万丂.丘丁丈一与丟下丙丝() <= 1)
        {
                if(丒丙业丕万丒丞万丂.与丗世七三丝业丏丏() <= 0)
        {
                if(this.与专一七丛丅专丒下 == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        val_22 = System.String.Format(format:  "[fdff00]{0}[-]", arg0:  val_22);
        label_12:
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.pixelPassExpCounter != 0)
        {
            goto label_18;
        }
        
        }
        
        val_23 = 0;
        goto label_19;
        label_23:
        val_20 = this.rewardPixelPassExpLabel[0];
        val_20.text = System.String.Format(format:  val_22, arg0:  丒丙业丕万丒丞万丂.与丗世七三丝业丏丏() + (丒丙业丕万丒丞万丂.丘丁丈一与丟下丙丝() * val_20));
        val_23 = 1;
        label_19:
        if(val_23 < this.rewardPixelPassExpLabel.Length)
        {
            goto label_23;
        }
        
        return;
        label_18:
        this.pixelPassExpCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        val_23 = this.pixelPassExpCounter;
        if(丒丙业丕万丒丞万丂 != null)
        {
                val_24 = 丒丙业丕万丒丞万丂.丘丁丈一与丟下丙丝();
        }
        else
        {
                val_24 = 0.丘丁丈一与丟下丙丝();
        }
        
        val_22 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_22);
        val_23.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  val_20, 上丘专万丐丐丗丕丈:  丒丙业丕万丒丞万丂.与丗世七三丝业丏丏() + (val_24 * val_20), 丕丂丐丌丆丝且万丗:  val_22);
    }
    internal void 丟东丅与三一不万丝(int 丛丅下世丑丈丐与一, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_25;
        var val_26;
        string val_27;
        CountingLabel val_28;
        var val_29;
        val_25 = 丛丅下世丑丈丐与一;
        if(this.下一丄丝专丛一专丌 != true)
        {
                if(丒丙业丕万丒丞万丂.东世东丆丁丗七丏丒() > 1)
        {
                val_26 = 1;
        }
        
            this.下一丄丝专丛一专丌 = (丒丙业丕万丒丞万丂.七万三东东一丁世丘() > 0) ? 1 : 0;
        }
        
        if(丒丙业丕万丒丞万丂.东世东丆丁丗七丏丒() <= 1)
        {
                if(丒丙业丕万丒丞万丂.七万三东东一丁世丘() <= 0)
        {
                if(this.下一丄丝专丛一专丌 == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        val_27 = System.String.Format(format:  "[fdff00]{0}[-]", arg0:  "{0} " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5947")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5947")));
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_31;
        }
        
        label_32:
        label_31:
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.bpCurrencyCounter != 0)
        {
            goto label_18;
        }
        
        }
        
        val_28 = 0;
        goto label_19;
        label_23:
        val_25 = this.rewardBattleaPassCurrencyLabel[0];
        val_25.text = System.String.Format(format:  val_27, arg0:  丒丙业丕万丒丞万丂.七万三东东一丁世丘() + (丒丙业丕万丒丞万丂.东世东丆丁丗七丏丒() * val_25));
        val_28 = 1;
        label_19:
        if(val_28 < this.rewardBattleaPassCurrencyLabel.Length)
        {
            goto label_23;
        }
        
        return;
        label_18:
        this.bpCurrencyCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        val_28 = this.bpCurrencyCounter;
        if(丒丙业丕万丒丞万丂 != null)
        {
                val_29 = 丒丙业丕万丒丞万丂.东世东丆丁丗七丏丒();
        }
        else
        {
                val_29 = 0.东世东丆丁丗七丏丒();
        }
        
        val_27 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_27);
        val_28.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  val_25, 上丘专万丐丐丗丕丈:  丒丙业丕万丒丞万丂.七万三东东一丁世丘() + (val_29 * val_25), 丕丂丐丌丆丝且万丗:  val_27);
        return;
        label_12:
        if(丒丙业丕万丒丞万丂 != null)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    internal void 业丙丈丞一下万丗丐(Rilisoft.OfferItem 丂且且丟丟东丕一丑, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        UILabel val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = 丒丙业丕万丒丞万丂;
        val_13 = this;
        if(丂且且丟丟东丕一丑 == null)
        {
                return;
        }
        
        if(this.下丒世东丒丂且丌世 != true)
        {
                if(val_12.万七丙专业丌丈丘丂() > 1)
        {
                val_14 = 1;
        }
        
            this.下丒世东丒丂且丌世 = (val_12.丙丁丟上丁专丑丞丐() > 0) ? 1 : 0;
        }
        
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.detailsCounter != 0)
        {
            goto label_10;
        }
        
        }
        
        val_13 = 0;
        goto label_11;
        label_15:
        val_12 = this.rewardBattleaPassCurrencyLabel[0];
        val_12.text = 丂且且丟丟东丕一丑.ReadableCount;
        val_13 = 1;
        label_11:
        if(val_13 < this.rewardBattleaPassCurrencyLabel.Length)
        {
            goto label_15;
        }
        
        return;
        label_10:
        this.detailsCounter.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        if(val_12 != null)
        {
                val_15 = val_12.万七丙专业丌丈丘丂();
        }
        else
        {
                val_15 = 0.万七丙专业丌丈丘丂();
        }
        
        this.detailsCounter.且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  丂且且丟丟东丕一丑.Count, 上丘专万丐丐丗丕丈:  val_12.丙丁丟上丁专丑丞丐() + (val_15 * 丂且且丟丟东丕一丑.Count), 丕丂丐丌丆丝且万丗:  0);
    }
    internal void 丟丁丄世丈丄一万丏(PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 下丅丙一丂丗丅丝七, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_9;
        UILabel val_10;
        var val_11;
        int val_12;
        int val_13;
        string val_14;
        val_10 = this;
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        val_9 = 下丅丙一丂丗丅丝七.丈丄丈丛世丈专与丘;
        if(下丅丙一丂丗丅丝七.丒三丝一上丙专丗丒 != 1)
        {
                return;
        }
        
        string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7360");
        if(丙万丟上丞丒丞万丗 != false)
        {
                if(this.moduleChestCounter != 0)
        {
            goto label_11;
        }
        
        }
        
        val_9 = this.rewardBattleaPassCurrencyLabel;
        val_11 = 0;
        goto label_12;
        label_16:
        val_10 = val_9[0];
        val_10.text = val_2;
        val_11 = 1;
        label_12:
        if(val_11 < this.rewardBattleaPassCurrencyLabel.Length)
        {
            goto label_16;
        }
        
        return;
        label_11:
        val_9 = this.moduleChestCounter;
        val_9.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.countingDuration);
        val_10 = this.moduleChestCounter;
        val_12 = 0;
        val_13 = 0;
        val_14 = val_2;
        且丏丂丐丏业丕七丞(丆一万东丒丗一丝不:  null, 上丘专万丐丐丗丕丈:  null, 丕丂丐丌丆丝且万丗:  null);
    }
    internal void 丒丏丕丘丗丘丕业丂(int 一丘业丄三七世万丞, 丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂, bool 丙万丟上丞丒丞万丗)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.rewardGemsLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3001"), arg0:  一丘业丄三七世万丞));
    }
    internal void 东丌丟三丞世一一丑(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
    {
        string val_9;
        string val_13;
        var val_14;
        UIBasicSprite val_15;
        val_14 = 下丅丙一丂丗丅丝七;
        if(val_14 == null)
        {
                return;
        }
        
        Rilisoft.OfferItemType val_1 = val_14.Type;
        if(val_1 == 1130)
        {
            goto label_2;
        }
        
        if(val_1 != 1070)
        {
            goto label_3;
        }
        
        val_13 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4960"), arg0:  val_14.Count);
        goto label_7;
        label_2:
        val_13 = val_14.Name;
        goto label_7;
        label_3:
        丒与上丅丒丘与丒丘 val_8 = Rilisoft.ItemViewer.东且丏丆万与东丙万(丕丁下丌不万丅丞丛:  val_14.Id, 丅三丟世下丞丝丙万:  val_14.Count);
        val_13 = val_9;
        label_7:
        if(val_14.Type == 1130)
        {
                val_15 = this.SpriteEventChestReward;
        }
        else
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.itemRewardLabel, 丕丗丘丑丛与丑业丒:  val_13);
            val_15 = this.itemReward;
        }
        
        val_14 = val_14.Texture;
    }
    internal void 且丕丅丕丕业丞不东(int 不东丂上且与万丙丕)
    {
        if(this._piggyProgressView == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this._piggyProgressView.gameObject;
        if(不东丂上且与万丙丕 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
            this._piggyProgressView.丈且东丑丂且万丒丅(丘丕丐丁下世丙七丂:  不东丂上且与万丙丕);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
    }
    internal void 与业丈丝三丁丝东丐(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
    
    }
    public RewardWindowView()
    {
        this.countingDuration = 5f;
    }

}
