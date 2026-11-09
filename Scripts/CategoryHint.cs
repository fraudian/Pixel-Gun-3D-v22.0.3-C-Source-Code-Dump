using UnityEngine;
internal sealed class CategoryHint : HintPopup
{
    // Fields
    private Rilisoft.七丕丟丏三丈一丄世 下丁上丟业一三丒东;
    private SceneInfo 丞丑丗丏丌七一丌丐;
    private bool 丅丝七丆丝丞丅丘丅;
    public UILabel NameLabel;
    public UILabel DescriptionLabel;
    public UILabel LevelRequiredLabel;
    public UILabel trophiesRequiredLabel;
    public UIBasicSprite iconSprite;
    public UnityEngine.GameObject rewardsContainer;
    public WidgetLayout layout;
    public UnityEngine.GameObject minigameContainer;
    public UnityEngine.GameObject duelContainer;
    public UnityEngine.GameObject teamDuelContainer;
    public UnityEngine.GameObject lockedContainer;
    public UnityEngine.GameObject minigameIcon;
    public UnityEngine.GameObject duelIcon;
    public UnityEngine.GameObject teamDuelIcon;
    public UnityEngine.GameObject royaleIcon;
    public UnityEngine.GameObject deathmatchIcon;
    public UnityEngine.GameObject capturePointIcon;
    public UnityEngine.GameObject captureFlagIcon;
    public UnityEngine.GameObject dungeonsIcon;
    public UnityEngine.GameObject freeplayIcon;
    public UnityEngine.GameObject siegeIcon;
    public UnityEngine.GameObject teamFightIcon;
    private UnityEngine.GameObject rewardExperience;
    private UnityEngine.GameObject rewardCoins;
    private UnityEngine.GameObject rewardBattlePass;
    private UnityEngine.GameObject rewardKeys;
    private UnityEngine.GameObject rewardParts;
    private UnityEngine.GameObject rewardPixelPassCurrency;
    private UnityEngine.GameObject rewardPixelPassExp;
    private bool 东一下丐丟下专一丏;
    
    // Properties
    set; }
    internal SceneInfo 上丁万丛三丂丞三一 { set; }
    internal bool 丆丐丘丞丘丐丁丞丑 { set; }
    
    // Methods
    internal void 丑丈丙丟丑丆丌且丛(Rilisoft.七丕丟丏三丈一丄世 丙业与丙丗丝不丈东)
    {
        this.下丁上丟业一三丒东 = 丙业与丙丗丝不丈东;
    }
    internal void 丏上丒丄丁丏丅丐丄(SceneInfo 丙业与丙丗丝不丈东)
    {
        this.丞丑丗丏丌七一丌丐 = 丙业与丙丗丝不丈东;
    }
    internal void 三丑业一丂下一且万(bool 丙业与丙丗丝不丈东)
    {
        this.丅丝七丆丝丞丅丘丅 = 丙业与丙丗丝不丈东;
    }
    private void 丈丛丕丅一七丕东东(int 丗丗丑丑与东丗丅三)
    {
        if(this.LevelRequiredLabel == 0)
        {
                return;
        }
        
        this = this.LevelRequiredLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  丗丗丑丑与东丗丅三));
    }
    internal void 丞万东一丒丆丟丞丂()
    {
        SceneInfo val_6;
        var val_7;
        var val_8;
        if(this.丞丑丗丏丌七一丌丐 == 0)
        {
                val_6 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
            val_7 = val_6;
            int val_3 = val_7.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  this.下丁上丟业一三丒东);
        }
        else
        {
                val_8 = null;
            val_8 = null;
            val_6 = this.丞丑丗丏丌七一丌丐;
            val_7 = SceneInfoController.丄丘七三上丕世丞业;
        }
        
        this.丈丛丕丅一七丕东东(丗丗丑丑与东丗丅三:  val_7.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  this.下丁上丟业一三丒东, 东下丌丝且七丛丘丒:  val_6, 丁丏丗且上丗下与下:  (this.丅丝七丆丝丞丅丘丅 == true) ? 1 : 0));
    }
    internal void 丞七世丈丐丆丑丒丐()
    {
        if(this.lockedContainer == 0)
        {
                return;
        }
        
        Rilisoft.七丕丟丏三丈一丄世 val_4 = this.下丁上丟业一三丒东;
        val_4 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  val_4);
        this.lockedContainer.SetActive(value:  val_4);
    }
    internal void 世丙丅不丂丅丄丘且()
    {
        var val_12;
        var val_14;
        var val_15;
        Rilisoft.七丕丟丏三丈一丄世 val_16;
        UILabel val_18;
        var val_20;
        var val_21;
        var val_23;
        int val_24;
        val_12 = 0;
        if(this.NameLabel != 0)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_12 = 0;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.NameLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]));
        }
        
        val_14 = 0;
        if(this.DescriptionLabel == 0)
        {
                return;
        }
        
        if(this.下丁上丟业一三丒东 != 20)
        {
            goto label_18;
        }
        
        val_14 = 0;
        if(this.丞丑丗丏丌七一丌丐 != 0)
        {
            goto label_21;
        }
        
        label_18:
        val_15 = null;
        val_15 = null;
        val_16 = this.下丁上丟业一三丒东;
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_14 = 4;
        goto label_28;
        label_21:
        val_18 = this.DescriptionLabel;
        val_16 = this.丞丑丗丏丌七一丌丐;
        if(val_16 == null)
        {
            goto label_29;
        }
        
        if(this.丅丝七丆丝丞丅丘丅 == false)
        {
            goto label_30;
        }
        
        label_47:
        string val_8 = val_16.丁一上且丑丑业上不();
        goto label_31;
        label_28:
        val_20 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
        val_18 = this.DescriptionLabel;
        if((GameConnect.丕丒上东丞丕丞一三.ContainsKey(key:  ???)) == false)
        {
            goto label_32;
        }
        
        val_21 = null;
        val_21 = null;
        val_16 = GameConnect.丕丒上东丞丕丞一三;
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_20 = 0;
        goto label_39;
        label_32:
        val_23 = null;
        val_24 = System.String.alignConst;
        goto label_49;
        label_39:
        val_24 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_16.Item[???]);
        val_23 = null;
        goto label_46;
        label_29:
        if(this.丅丝七丆丝丞丅丘丅 == true)
        {
            goto label_47;
        }
        
        label_30:
        label_31:
        val_24 = val_16.丝丌七上丘丑且丞与();
        val_23 = null;
        label_46:
        label_49:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  val_24);
    }
    internal void 七东丘东专丗世且三()
    {
        this.世丙丅不丂丅丄丘且();
        this.minigameContainer.SetActive(value:  true);
        this.丒丌丘丙丒丝丛丅丆();
        if(this.iconSprite != 0)
        {
                this.iconSprite.gameObject.SetActive(value:  false);
        }
        
        this.minigameIcon.SetActive(value:  ((this.下丁上丟业一三丒东 != 16) ? 1 : 0) & ((this.下丁上丟业一三丒东 != 8) ? 1 : 0));
        this.丞万东一丒丆丟丞丂();
    }
    private void 丒丌丘丙丒丝丛丅丆()
    {
        if(this.duelIcon != 0)
        {
                this.duelIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 8) ? 1 : 0);
        }
        
        if(this.teamDuelIcon != 0)
        {
                this.teamDuelIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 16) ? 1 : 0);
        }
        
        if(this.deathmatchIcon != 0)
        {
                this.deathmatchIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 0) ? 1 : 0);
        }
        
        if(this.royaleIcon != 0)
        {
                this.royaleIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 20) ? 1 : 0);
        }
        
        if(this.captureFlagIcon != 0)
        {
                this.captureFlagIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 4) ? 1 : 0);
        }
        
        if(this.capturePointIcon != 0)
        {
                this.capturePointIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 5) ? 1 : 0);
        }
        
        if(this.dungeonsIcon != 0)
        {
                this.dungeonsIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 22) ? 1 : 0);
        }
        
        if(this.freeplayIcon != 0)
        {
                this.freeplayIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 31) ? 1 : 0);
        }
        
        if(this.siegeIcon != 0)
        {
                this.siegeIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 17) ? 1 : 0);
        }
        
        if(this.teamFightIcon != 0)
        {
                this.teamFightIcon.SetActive(value:  (this.下丁上丟业一三丒东 == 2) ? 1 : 0);
        }
        
        if(this.minigameIcon == 0)
        {
                return;
        }
        
        this.minigameIcon.SetActive(value:  false);
    }
    internal void 丘专七专丂丅上丙与()
    {
        this.世丙丅不丂丅丄丘且();
        this.丒丌丘丙丒丝丛丅丆();
        if(this.iconSprite != 0)
        {
                this.iconSprite.gameObject.SetActive(value:  false);
        }
        
        this.丞万东一丒丆丟丞丂();
    }
    internal void 丝丐七世三丏丛丒丞(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂, bool 万丏丅万丅下丟丘丘 = False)
    {
        UnityEngine.Texture val_9;
        UnityEngine.GameObject val_10;
        if(this.iconSprite != 0)
        {
                val_9 = 七丆丒与丗丌丄且丂.三丗一丄不丆不丏三();
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.iconSprite, 与万丆丛丒万丝丙丑:  val_9);
            this.iconSprite.gameObject.SetActive(value:  true);
        }
        
        if(this.NameLabel != 0)
        {
                val_9 = 七丆丒与丗丌丄且丂;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.NameLabel, 丕丗丘丑丛与丑业丒:  val_9);
        }
        
        if(this.DescriptionLabel != 0)
        {
                val_9 = 七丆丒与丗丌丄且丂.东且丏丆万与东丙万();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DescriptionLabel, 丕丗丘丑丛与丑业丒:  val_9);
        }
        
        this.丈丛丕丅一七丕东东(丗丗丑丑与东丗丅三:  val_9);
        val_10 = this.lockedContainer;
        if(val_10 != 0)
        {
                val_10 = this.lockedContainer;
            val_10.SetActive(value:  (~万丏丅万丅下丟丘丘) & 1);
        }
        
        this.下丁上丟业一三丒东 = 100;
        this.丒丌丘丙丒丝丛丅丆();
    }
    protected override void OnEnable()
    {
        var val_3;
        var val_7;
        var val_9;
        var val_11;
        this.OnEnable();
        if(this.rewardsContainer == 0)
        {
            goto label_3;
        }
        
        上丑丝丌七不丙丗丅 val_2 = 专上丈丌丒丁丒丆三.丒丐丟丆下七丛丑丕(上且丗一丏丏万丅丌:  this.下丁上丟业一三丒东);
        if(((-1981705224) & 1) == 0)
        {
                if(val_3 == 0)
        {
            goto label_7;
        }
        
        }
        
        this.rewardsContainer.SetActive(value:  true);
        this.rewardExperience.SetActive(value:  (丆丒丘丐下丞丛上丈() > 0) ? 1 : 0);
        this.rewardCoins.SetActive(value:  ( > 0) ? 1 : 0);
        this.rewardBattlePass.SetActive(value:  (val_7 > 0) ? 1 : 0);
        this.rewardPixelPassCurrency.SetActive(value:  (val_9 > 0) ? 1 : 0);
        this.rewardPixelPassExp.SetActive(value:  (val_11 > 0) ? 1 : 0);
        this.rewardKeys.SetActive(value:  ( > 0) ? 1 : 0);
        label_17:
        this.rewardParts.SetActive(value:  (val_3 != 0) ? 1 : 0);
        label_3:
        this.东一下丐丟下专一丏 = true;
        return;
        label_7:
        if(this.rewardsContainer != null)
        {
            goto label_17;
        }
        
        goto label_17;
    }
    private void Update()
    {
        if(this.东一下丐丟下专一丏 == false)
        {
                return;
        }
        
        this.东一下丐丟下专一丏 = false;
        if(this.layout == 0)
        {
                return;
        }
        
        this.layout.Reposition();
    }
    public CategoryHint()
    {
    
    }

}
