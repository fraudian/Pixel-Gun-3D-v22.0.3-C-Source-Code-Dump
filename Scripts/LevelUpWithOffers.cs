using UnityEngine;
public class LevelUpWithOffers : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject giveArmorAnimation;
    public System.Collections.Generic.List<UILabel> giveArmorLabels;
    private UIBasicSprite giveArmorTexture;
    public RewardWindowBase shareScript;
    public UILabel[] rewardGemsPriceLabel;
    public UILabel[] currentRankLabel;
    public UILabel[] rewardPriceLabel;
    public UILabel[] healthLabel;
    public UILabel[] gemsStarterBank;
    public UILabel[] coinsStarterBank;
    public System.Collections.Generic.List<UILabel> youReachedLabels;
    public Rilisoft.NewAvailableItemInShop[] items;
    public bool isTierLevelUp;
    private float 丝下丞丑东丑业世丅;
    private float 不丈丕专丘七丄丒丕;
    
    // Properties
    private UIBasicSprite 丛丕丑丐一丙丘东丟 { get; }
    
    // Methods
    private UIBasicSprite 丟万上丆丕上丝丅七()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.giveArmorTexture);
        this.giveArmorTexture = val_1;
        return val_1;
    }
    private System.Collections.IEnumerator 丌丟丁丁丞丑丕专丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LevelUpWithOffers.世丑丗上丘丗东丐丏();
    }
    private void Awake()
    {
        var val_5;
        var val_7;
        System.Func<System.String> val_9;
        RewardWindowBase val_10;
        string val_11;
        var val_12;
        var val_14;
        if(this.shareScript == null)
        {
            goto label_1;
        }
        
        if(this.isTierLevelUp == false)
        {
            goto label_2;
        }
        
        label_14:
        this.shareScript.丟丁丑丆丅一丙丂丂(丙业与丙丗丝不丈东:  0);
        val_5 = null;
        val_5 = null;
        if((LevelUpWithOffers.<>c.<>9__18_2) == null)
        {
            goto label_5;
        }
        
        label_28:
        this.shareScript.shareAction = LevelUpWithOffers.<>c.<>9__18_2;
        this.shareScript.HasReward = true;
        val_7 = null;
        val_7 = null;
        val_9 = LevelUpWithOffers.<>c.<>9__18_3;
        if(val_9 == null)
        {
            goto label_10;
        }
        
        label_32:
        this.shareScript.twitterStatus = val_9;
        val_10 = this.shareScript;
        val_11 = "Tier-up";
        goto label_13;
        label_1:
        if(this.isTierLevelUp == true)
        {
            goto label_14;
        }
        
        label_2:
        this.shareScript.丟丁丑丆丅一丙丂丂(丙业与丙丗丝不丈东:  1);
        val_12 = null;
        val_12 = null;
        if((LevelUpWithOffers.<>c.<>9__18_0) == null)
        {
            goto label_17;
        }
        
        label_36:
        this.shareScript.shareAction = LevelUpWithOffers.<>c.<>9__18_0;
        this.shareScript.HasReward = true;
        val_14 = null;
        val_14 = null;
        val_9 = LevelUpWithOffers.<>c.<>9__18_1;
        if(val_9 == null)
        {
            goto label_22;
        }
        
        label_40:
        this.shareScript.twitterStatus = val_9;
        val_10 = this.shareScript;
        val_11 = "Level-up";
        label_13:
        val_10.EventTitle = val_11;
        return;
        label_5:
        LevelUpWithOffers.<>c.<>9__18_2 = new System.Action(object:  LevelUpWithOffers.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelUpWithOffers.<>c::丂丕丗丒七且丕丌不());
        if(this.shareScript != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_10:
        LevelUpWithOffers.<>c.<>9__18_3 = new System.Func<System.String>(object:  LevelUpWithOffers.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelUpWithOffers.<>c::万丛业丛丁业丗下丙());
        if(this.shareScript != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_17:
        LevelUpWithOffers.<>c.<>9__18_0 = new System.Action(object:  LevelUpWithOffers.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelUpWithOffers.<>c::东七七上上三丟与专());
        if(this.shareScript != null)
        {
            goto label_36;
        }
        
        goto label_36;
        label_22:
        LevelUpWithOffers.<>c.<>9__18_1 = new System.Func<System.String>(object:  LevelUpWithOffers.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelUpWithOffers.<>c::上且业丙丅丞专丛丄());
        if(this.shareScript != null)
        {
            goto label_40;
        }
        
        goto label_40;
    }
    public void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丌丟丁丁丞丑丕专丆());
    }
    public void RunArmorAnimation(string 丏下丏丌丈丈专丛丞)
    {
        bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丏下丏丌丈丈专丛丞);
        if(this.shareScript != 0)
        {
            goto label_5;
        }
        
        label_29:
        UnityEngine.Debug.LogErrorFormat(format:  "RunArmorAnimation: shareScript == null", args:  System.Array.Empty<System.Object>());
        return;
        label_5:
        if(this.giveArmorAnimation == 0)
        {
                return;
        }
        
        bool val_5 = val_1 ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giveArmorAnimation, 丏业丟一东丂东丘丛:  val_5);
        UnityEngine.Animator val_7 = this.shareScript.GetComponent<UnityEngine.Animator>();
        if(val_7 != 0)
        {
            goto label_16;
        }
        
        T[] val_9 = System.Array.Empty<System.Object>();
        goto label_29;
        label_16:
        val_7.SetBool(name:  "Armor", value:  val_5);
        if(val_1 == true)
        {
                return;
        }
        
        if(this.giveArmorLabels != null)
        {
                if(this.giveArmorLabels.Count != 0)
        {
                if(this.丟万上丆丕上丝丅七() != 0)
        {
            goto label_26;
        }
        
        }
        
        }
        
        T[] val_14 = System.Array.Empty<System.Object>();
        goto label_29;
        label_26:
        new LevelUpWithOffers.丒业丛丟专丛丒与东() = new System.Object();
        .丟下丟丈万一丙东丄 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  丏下丏丌丈丈专丛丞, 七丆丒与丗丌丄且丂:  7);
        System.Action<UILabel> val_17 = new System.Action<UILabel>(object:  new LevelUpWithOffers.丒业丛丟专丛丒与东(), method:  System.Void LevelUpWithOffers.丒业丛丟专丛丒与东::丘且丏上丝丗且下三(UILabel 七丐丞丑丑丕世丙七));
        this.giveArmorLabels.ForEach(action:  null);
        if(this.丟万上丆丕上丝丅七() != null)
        {
                return;
        }
    
    }
    private void OnDisable()
    {
        this.专下丛不丅丌丈丗丞();
    }
    private void OnDestroy()
    {
        this.专下丛不丅丌丈丗丞();
    }
    private void 专下丛不丅丌丈丗丞()
    {
        null = null;
        BankController.丂七上业下丆丄东丄 = true;
        BankController.且丗丛丏丂丒世丒业();
    }
    public void SetCurrentRank(string 专且丅丄且丘丟丅业)
    {
        var val_8;
        string val_9;
        System.Collections.Generic.List<UILabel> val_10;
        val_8 = 0;
        goto label_1;
        label_9:
        this.currentRankLabel[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0226").ToUpper()(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0226").ToUpper()) + " " + 专且丅丄且丘丟丅业 + "!"("!");
        val_8 = 1;
        label_1:
        if(val_8 < this.currentRankLabel.Length)
        {
            goto label_9;
        }
        
        val_9 = "";
        if(ProfileController.丕东世上丄万丘丅业() <= 5)
        {
                val_9 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  130688208 + (val_4) << 3);
        }
        
        val_10 = this.youReachedLabels;
        List.Enumerator<T> val_6 = val_10.GetEnumerator();
        label_16:
        if((431479736 & 1) == 0)
        {
            goto label_14;
        }
        
        0.丐丏七丌丕丗业且上().text = val_9;
        goto label_16;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void SetRewardPrice(string 丄丗下上丐丐丁东丘)
    {
        goto label_0;
        label_5:
        this.rewardPriceLabel[0].text = 丄丗下上丐丐丁东丘;
        0 = 1;
        label_0:
        if(0 < this.rewardPriceLabel.Length)
        {
            goto label_5;
        }
    
    }
    public void SetGemsRewardPrice(string 丂上丈丏世丂丂丅与)
    {
        goto label_0;
        label_5:
        this.rewardGemsPriceLabel[0].text = 丂上丈丏世丂丂丅与;
        0 = 1;
        label_0:
        if(0 < this.rewardGemsPriceLabel.Length)
        {
            goto label_5;
        }
    
    }
    public void SetAddHealthCount(string 丌丒丝东丌下丕丁丅)
    {
        UILabel[] val_1;
        var val_2;
        val_1 = this.healthLabel;
        if(val_1 == null)
        {
                return;
        }
        
        val_2 = 0;
        goto label_1;
        label_6:
        this.healthLabel[0].text = 丌丒丝东丌下丕丁丅;
        val_1 = this.healthLabel;
        val_2 = 1;
        label_1:
        if(val_2 < this.healthLabel.Length)
        {
            goto label_6;
        }
    
    }
    private void 丙丅丟丟与三三丁业(int 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_8:
        this.gemsStarterBank[0].text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1531"), arg0:  丙业与丙丗丝不丈东);
        0 = 1;
        label_1:
        if(0 < this.gemsStarterBank.Length)
        {
            goto label_8;
        }
    
    }
    private void 丄且丈丌丝一上丑上(int 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_8:
        this.coinsStarterBank[0].text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1530"), arg0:  丙业与丙丗丝不丈东);
        0 = 1;
        label_1:
        if(0 < this.coinsStarterBank.Length)
        {
            goto label_8;
        }
    
    }
    public System.Collections.IEnumerator GemsStarterAnimation()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LevelUpWithOffers.丆丞丝丐丆丈丙丑下();
    }
    public System.Collections.IEnumerator CoinsStarterAnimation()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LevelUpWithOffers.丁丝丆丛七业上且七();
    }
    public void SetStarterBankValues(int 丂上丈丏世丂丂丅与, int 丆丁丘丗三万且专东)
    {
        this.丝下丞丑东丑业世丅 = (float)丂上丈丏世丂丂丅与;
        this.不丈丕专丘七丄丒丕 = (float)丆丁丘丗三万且专东;
        this.丙丅丟丟与三三丁业(丙业与丙丗丝不丈东:  0);
        this.丄且丈丌丝一上丑上(丙业与丙丗丝不丈东:  0);
    }
    public void SetItems(System.Collections.Generic.List<string> 丑丑丛丟丈世且丕上)
    {
        var val_8;
        System.Collections.Generic.List<System.String> val_22;
        Rilisoft.NewAvailableItemInShop[] val_23;
        var val_24;
        string val_25;
        Rilisoft.NewAvailableItemInShop[] val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        val_22 = 丑丑丛丟丈世且丕上;
        val_23 = this.items;
        if(val_23 == null)
        {
                return;
        }
        
        if(this.items.Length == 0)
        {
                return;
        }
        
        val_24 = 0;
        goto label_3;
        label_9:
        val_25 = 0;
        this.items[val_25].gameObject.SetActive(value:  false);
        val_26 = this.items;
        val_24 = 1;
        label_3:
        if(val_24 < this.items.Length)
        {
            goto label_9;
        }
        
        val_27 = 0;
        goto label_67;
        label_74:
        this.items[0].gameObject.SetActive(value:  true);
        val_25 = val_22.Item[0];
        int val_4 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_25);
        Rilisoft.NewAvailableItemInShop val_23 = this.items[0];
        this.items[0x0][0]._tag = val_25;
        Rilisoft.NewAvailableItemInShop val_24 = this.items[0];
        this.items[0x0][0].category = val_4;
        val_28 = 0;
        this.items[0].SetTexture(与万丆丛丒万丝丙丑:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_25, 七丆丒与丗丌丄且丂:  val_4, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false));
        if(val_27 >= this.items.Length)
        {
                val_28 = 0;
        }
        
        Rilisoft.NewAvailableItemInShop val_26 = this.items[0];
        List.Enumerator<T> val_6 = this.items[0x0][0].itemName.GetEnumerator();
        label_35:
        if((433937904 & 1) == 0)
        {
            goto label_31;
        }
        
        val_8.丐丏七丌丕丗业且上().text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_25, 七丆丒与丗丌丄且丂:  val_4);
        goto label_35;
        label_31:
        var val_28 = 1;
        val_29 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_28 != 1)
        {
                var val_27 = 0;
            val_27 = val_27 ^ 0;
            val_28 = val_28 + val_27;
        }
        else
        {
                if( != 0)
        {
                val_28 = 0;
        }
        
        }
        
        if(val_27 >= this.items.Length)
        {
                val_28 = 0;
        }
        
        UIButton val_11 = this.items[0].GetComponent<UIButton>();
        if(((GameConnect.世丐丄三三上丅七三() != true) && (GameConnect.丌专丌万一下丕专上() != true)) && (GameConnect.万七丄丛丈丟专一丑() != true))
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_60;
        }
        
        }
        
        }
        
        if(val_25 == null)
        {
            goto label_61;
        }
        
        label_71:
        var val_18 = ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_25)) == 0) ? 1 : 0;
        if(val_11 != null)
        {
            goto label_66;
        }
        
        goto label_65;
        label_61:
        val_30 = 1;
        label_72:
        if(val_11 != null)
        {
            goto label_66;
        }
        
        label_65:
        label_66:
        val_22 = val_22;
        val_27 = 1;
        goto label_67;
        label_60:
        if(val_25 == null)
        {
            goto label_72;
        }
        
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
            goto label_71;
        }
        
        goto label_72;
        label_67:
        if(val_27 < val_22.Count)
        {
            goto label_74;
        }
    
    }
    public void Close()
    {
        ExpController.丑七不且上丗丁一世().HandleContinueButton(世丞丑上丅与世丁世:  this.gameObject);
    }
    public LevelUpWithOffers()
    {
    
    }

}
