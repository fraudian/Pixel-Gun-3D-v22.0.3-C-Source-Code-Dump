using UnityEngine;
internal sealed class DeveloperConsoleView : MonoBehaviour
{
    // Fields
    internal static DeveloperConsoleView 丄丘七三上丕世丞业;
    public UILabel graphicsDeviceType;
    public UIInput socialIdInput;
    private UILabel _batteryLevelNotificationThresholdLabel;
    private UISlider _batteryLevelNotificationThresholdSlider;
    public UIToggle adIdCheckbox;
    public UIInput appVersionInput;
    public UIToggle areLogsEnabledCheckbox;
    public UILabel balanceFlagSyncedMarch2018Label;
    public UIInput cohortsInput;
    public UIInput coinsInput;
    public UIInput daysInput;
    public UILabel deviceInfo;
    public UIInput devicePushTokenInput;
    public UILabel diagonalInfo;
    public UIToggle downgradeResolutionCheckbox;
    public UIInput enemiesInCampaignInput;
    public UIInput enemyCountInSurvivalWave;
    public UILabel experienceLabel;
    public UISlider experienceSlider;
    public UILabel clanExperienceLabel;
    public UISlider clanExperienceSlider;
    public UIToggle fbRewardCheckbox;
    public UIToggle gameGUIOffMode;
    public UIToggle clanTimeRestrictionsToggle;
    public UIToggle showUpdateBannerToggle;
    public UIInput gemsInput;
    public UIToggle isBalanceMarch2018;
    public UIToggle isFpsVisibleCheckbox;
    public UIToggle isDebugGuiVisibleCheckbox;
    public UIToggle isEditorCloudCheckbox;
    public UIToggle isEventX3ForcedCheckbox;
    public UIToggle isNoDetectCheckbox;
    public UIToggle isolatedProtocol;
    public UIToggle localPhoton;
    public UIInput isolatedProtocolInput;
    public UIToggle isPayingCheckbox;
    public UIToggle isPixelGunLowCheckbox;
    public UILabel leagueLabel;
    public UISlider leagueSlider;
    public UILabel levelLabel;
    public UISlider levelSlider;
    public UILabel sumExpLabel;
    public UILabel clanLevelLabel;
    public UISlider clanLevelSlider;
    public UIInput marathonCurrentDay;
    public UIToggle marathonTestMode;
    public UIButton markCloudAsBadButton;
    public UIToggle memoryCheckbox;
    public UIInput monthDayPreminAccount;
    public UIToggle mouseCOntrollCheckbox;
    public UIInput oneDayPreminAccount;
    public UIInput playerIdInput;
    public UILabel playerPaymentTypeLabel;
    public UILabel ratingLabel;
    public UISlider ratingSlider;
    public UIToggle reviewCheckbox;
    public UIToggle serverTimeCheckbox;
    public UIToggle set60FpsCheckbox;
    public UIInput sevenDayPreminAccount;
    public UILabel socialUsername;
    public UIToggle spectatorModeCheckbox;
    public UILabel starterPackCooldown;
    public UILabel starterPackLive;
    public UIToggle strongDeivceCheckbox;
    public UIInput systemNotificationInput;
    public UIToggle tempGunCheckbox;
    public UIInput threeDayPreminAccount;
    public UIInput ticketsInput;
    public UIInput eventsInput;
    public UIInput bpExpInput;
    public UIInput bpChallengeInput;
    public UIInput itemsInput;
    public UIInput silverInput;
    public UIToggle trainingCheckbox;
    public UIToggle webSocketGui;
    public UIToggle consoleGui;
    public UIToggle dontShowLogGui;
    public UIToggle webSocketLogsInConsole;
    public UIToggle automaticallyShownBanners;
    public UIToggle testAuthorizationUrl;
    public UILabel YourSocialId;
    public UILabel YourPlayerId;
    public UILabel BindedSocialId;
    public UILabel BindedPlayerId;
    public UILabel HavePlayServiceLogin;
    public UIInput adaptiveAutoAimKillRateInput;
    public UIInput adaptiveAutoAimTimeLeftInput;
    public UILabel GuiStyleLabel;
    public UIToggle giftFlag1;
    public UIToggle giftFlag2;
    public UIToggle giftFlag4;
    public UIToggle giftFlag8;
    public UIToggle giftFlag16;
    public UIToggle giftFlag32;
    public UIToggle giftFlag64;
    public UIToggle giftFlag128;
    public UIToggle giftFlag256;
    public UIToggle giftFlag512;
    public UILabel giftsValue;
    public UIInput competitionAddPlayersCount;
    public UIInput competitionMinCups;
    public UIInput competitionMaxCups;
    
    // Properties
    set; }
    public string 丛丄丌一丄丝丏丙万 { set; }
    public string 七丘丕且丙一丏丛丈 { set; }
    public string 丘丞一东丄丂丛丌丝 { set; }
    public string 东万丄三一下丆丑丟 { set; }
    public float 丄丘丂丝三丙丁业与 { get; set; }
    public string 丅下专且丁丗丂丒万 { set; }
    public float 业丄世七万与丑丄丌 { get; set; }
    public float 丘丙丑万丘丟丁丑七 { get; set; }
    public float 丅丆业东丞万世丆万 { get; set; }
    internal float 不丛丐丁丒专世丕丁 { get; set; }
    public string 东一不丙丙七丛三丏 { set; }
    public string 丏上丂丛下丆丄丏七 { set; }
    public string 丑业与世东丁上丙万 { set; }
    public float 丐与七丅一丟且丌丛 { get; set; }
    public string 与丕丐丙丗丈丏世业 { set; }
    public float 丟三丐且丌世上七专 { get; set; }
    public int 业上万丟丙丟三丛丈 { set; }
    public int 三丆丞七一三丌且东 { set; }
    public int 丂东丟丂与世丐丟丑 { set; }
    public int 丑业业七三东丙丄下 { set; }
    public int 丘上三丒丒丟丂不不 { set; }
    public string 丂丑与七丑丒世与东 { set; }
    public int 且丁不丕东丂丅丏丟 { set; }
    public int 丆且丐丗丘丁丕丕世 { set; }
    public int 丅丆丞丈丑丁丆丕丈 { set; }
    public bool 专东丛丆业丛七世万 { set; }
    public bool 丗丕万丈东丐下且丑 { set; }
    public bool 丄世三丏丙不与东丆 { set; }
    public bool 丁丗丗三丄丙七丆一 { set; }
    public bool 丕丛丏丄三一丗丕丐 { set; }
    public bool 丑丟丅丁丂丈丁丈一 { set; }
    public bool 三丅万丏丅上一丛世 { set; }
    public bool 丝丝一丟丈三丂丌丁 { set; }
    public int 万万三且上丘丈丅丛 { set; }
    public bool 丘上丗三丆上丆丂且 { set; }
    public bool 丗丞丌丒且一下且丗 { set; }
    public string 丛丒东与丑丞丛七且 { set; }
    public string 世三与与丝丗七不万 { set; }
    public string 丁丝丆且世丈丌丛丛 { set; }
    public string 世丐一丁丘一丐专且 { set; }
    public bool 丛万东与丘七三世丌 { get; set; }
    public bool 世世丑七丏丞不三丙 { get; set; }
    
    // Methods
    public void set_PlayerPaymentTypeLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.playerPaymentTypeLabel == 0)
        {
                return;
        }
        
        this.playerPaymentTypeLabel.text = 丙业与丙丗丝不丈东;
    }
    public void set_LevelLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.levelLabel == 0)
        {
                return;
        }
        
        this.levelLabel.text = 丙业与丙丗丝不丈东;
    }
    public void set_SumExpLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.sumExpLabel == 0)
        {
                return;
        }
        
        this.sumExpLabel.text = "XP: "("XP: ") + 丙业与丙丗丝不丈东;
    }
    public void set_ClanLevelLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.clanLevelLabel == 0)
        {
                return;
        }
        
        this.clanLevelLabel.text = 丙业与丙丗丝不丈东;
    }
    public void set_ExperienceLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.experienceLabel == 0)
        {
                return;
        }
        
        this.experienceLabel.text = 丙业与丙丗丝不丈东;
    }
    public float get_ExperiencePercentage()
    {
        if(this.experienceSlider == 0)
        {
                return 0f;
        }
        
        if(this.experienceSlider != null)
        {
                return this.experienceSlider.value;
        }
        
        return this.experienceSlider.value;
    }
    public void set_ExperiencePercentage(float 丙业与丙丗丝不丈东)
    {
        if(this.experienceSlider == 0)
        {
                return;
        }
        
        this.experienceSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public void set_ClanExperienceLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.clanExperienceLabel == 0)
        {
                return;
        }
        
        this.clanExperienceLabel.text = 丙业与丙丗丝不丈东;
    }
    public float get_ClanExperiencePercentage()
    {
        if(this.clanExperienceSlider == 0)
        {
                return 0f;
        }
        
        if(this.clanExperienceSlider != null)
        {
                return this.clanExperienceSlider.value;
        }
        
        return this.clanExperienceSlider.value;
    }
    public void set_ClanExperiencePercentage(float 丙业与丙丗丝不丈东)
    {
        if(this.clanExperienceSlider == 0)
        {
                return;
        }
        
        this.clanExperienceSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public float get_LevelPercentage()
    {
        if(this.levelSlider == 0)
        {
                return 0f;
        }
        
        if(this.levelSlider != null)
        {
                return this.levelSlider.value;
        }
        
        return this.levelSlider.value;
    }
    public void set_LevelPercentage(float 丙业与丙丗丝不丈东)
    {
        if(this.levelSlider == 0)
        {
                return;
        }
        
        this.levelSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public float get_ClanLevelPercentage()
    {
        if(this.clanLevelSlider == 0)
        {
                return 0f;
        }
        
        if(this.clanLevelSlider != null)
        {
                return this.clanLevelSlider.value;
        }
        
        return this.clanLevelSlider.value;
    }
    public void set_ClanLevelPercentage(float 丙业与丙丗丝不丈东)
    {
        if(this.clanLevelSlider == 0)
        {
                return;
        }
        
        this.clanLevelSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    internal float 丒丄七七丛丄七东世()
    {
        if(this._batteryLevelNotificationThresholdSlider == 0)
        {
                return 0f;
        }
        
        if(this._batteryLevelNotificationThresholdSlider != null)
        {
                return this._batteryLevelNotificationThresholdSlider.value;
        }
        
        return this._batteryLevelNotificationThresholdSlider.value;
    }
    internal void 丘业丏三丘七丐丂丑(float 丙业与丙丗丝不丈东)
    {
        if(this._batteryLevelNotificationThresholdSlider == 0)
        {
                return;
        }
        
        this._batteryLevelNotificationThresholdSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public void set_BatteryLevelNotificationString(string 丙业与丙丗丝不丈东)
    {
        if(this._batteryLevelNotificationThresholdLabel == 0)
        {
                return;
        }
        
        this._batteryLevelNotificationThresholdLabel.text = 丙业与丙丗丝不丈东;
    }
    public void set_GraphicsDeviceType(string 丙业与丙丗丝不丈东)
    {
        if(this.graphicsDeviceType == 0)
        {
                return;
        }
        
        this.graphicsDeviceType.text = 丙业与丙丗丝不丈东;
    }
    public void set_LeagueLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.leagueLabel == 0)
        {
                return;
        }
        
        this.leagueLabel.text = 丙业与丙丗丝不丈东;
    }
    public float get_LeaguePercentage()
    {
        if(this.leagueSlider == 0)
        {
                return 0f;
        }
        
        if(this.leagueSlider != null)
        {
                return this.leagueSlider.value;
        }
        
        return this.leagueSlider.value;
    }
    public void set_LeaguePercentage(float 丙业与丙丗丝不丈东)
    {
        if(this.leagueSlider == 0)
        {
                return;
        }
        
        this.leagueSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public void set_RatingLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.ratingLabel == 0)
        {
                return;
        }
        
        this.ratingLabel.text = 丙业与丙丗丝不丈东;
    }
    public float get_RatingPercentage()
    {
        if(this.ratingSlider == 0)
        {
                return 0f;
        }
        
        if(this.ratingSlider != null)
        {
                return this.ratingSlider.value;
        }
        
        return this.ratingSlider.value;
    }
    public void set_RatingPercentage(float 丙业与丙丗丝不丈东)
    {
        if(this.ratingSlider == 0)
        {
                return;
        }
        
        this.ratingSlider.value = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    public void set_CoinsInput(int 丙业与丙丗丝不丈东)
    {
        if(this.coinsInput == 0)
        {
                return;
        }
        
        this = this.coinsInput;
        this.value = 丙业与丙丗丝不丈东.ToString();
    }
    public void set_GemsInput(int 丙业与丙丗丝不丈东)
    {
        if(this.gemsInput == 0)
        {
                return;
        }
        
        this = this.gemsInput;
        this.value = 丙业与丙丗丝不丈东.ToString();
    }
    public void set_TicketsInput(int 丙业与丙丗丝不丈东)
    {
        if(this.ticketsInput == 0)
        {
                return;
        }
        
        this = this.ticketsInput;
        this.value = 丙业与丙丗丝不丈东.ToString();
    }
    public void set_EventInput(int 丙业与丙丗丝不丈东)
    {
        if(this.eventsInput == 0)
        {
                return;
        }
        
        this = this.eventsInput;
        this.value = 丙业与丙丗丝不丈东.ToString();
    }
    public void set_SilverInput(int 丙业与丙丗丝不丈东)
    {
        if(this.silverInput == 0)
        {
                return;
        }
        
        this = this.silverInput;
        this.value = 丙业与丙丗丝不丈东.ToString();
    }
    public void set_SocialIdInput(string 丙业与丙丗丝不丈东)
    {
        if(this.socialIdInput == 0)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_4;
        }
        
        label_7:
        this.socialIdInput.value = 丙业与丙丗丝不丈东;
        return;
        label_4:
        if(this.socialIdInput != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    public void set_EnemiesInSurvivalWaveInput(int 丙业与丙丗丝不丈东)
    {
        if(this.enemyCountInSurvivalWave == 0)
        {
                return;
        }
        
        this = this.enemyCountInSurvivalWave;
        this.value = 丙业与丙丗丝不丈东.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
    }
    public void set_EnemiesInCampaignInput(int 丙业与丙丗丝不丈东)
    {
        if(this.enemiesInCampaignInput == 0)
        {
                return;
        }
        
        this = this.enemiesInCampaignInput;
        this.value = 丙业与丙丗丝不丈东.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
    }
    public void set_Days(int 丙业与丙丗丝不丈东)
    {
        if(this.daysInput == 0)
        {
                return;
        }
        
        this = this.daysInput;
        this.value = 丙业与丙丗丝不丈东.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
    }
    public void set_StrongDevice(bool 丙业与丙丗丝不丈东)
    {
        if(this.strongDeivceCheckbox == 0)
        {
                return;
        }
        
        this.strongDeivceCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_TrainingCompleted(bool 丙业与丙丗丝不丈东)
    {
        if(this.trainingCheckbox == 0)
        {
                return;
        }
        
        this.trainingCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_TempGunActive(bool 丙业与丙丗丝不丈东)
    {
        if(this.tempGunCheckbox == 0)
        {
                return;
        }
        
        this.tempGunCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_Set60FPSActive(bool 丙业与丙丗丝不丈东)
    {
        if(this.set60FpsCheckbox == 0)
        {
                return;
        }
        
        this.set60FpsCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_SetMouseControll(bool 丙业与丙丗丝不丈东)
    {
        if(this.mouseCOntrollCheckbox == 0)
        {
                return;
        }
        
        this.mouseCOntrollCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_SetSpectatorMode(bool 丙业与丙丗丝不丈东)
    {
        if(this.spectatorModeCheckbox == 0)
        {
                return;
        }
        
        this.spectatorModeCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_SetFBReward(bool 丙业与丙丗丝不丈东)
    {
        if(this.fbRewardCheckbox == 0)
        {
                return;
        }
        
        this.fbRewardCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_IsPayingUser(bool 丙业与丙丗丝不丈东)
    {
        if(this.isPayingCheckbox == 0)
        {
                return;
        }
        
        this.isPayingCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public void set_MarathonDayInput(int 丙业与丙丗丝不丈东)
    {
        if(this.marathonCurrentDay == 0)
        {
                return;
        }
        
        this = this.marathonCurrentDay;
        this.value = 丙业与丙丗丝不丈东.ToString();
    }
    public void set_MarathonTestMode(bool 丙业与丙丗丝不丈东)
    {
        if(this.marathonTestMode == 0)
        {
                return;
        }
        
        this.marathonTestMode.value = 丙业与丙丗丝不丈东;
    }
    public void set_GameGUIOffMode(bool 丙业与丙丗丝不丈东)
    {
        if(this.gameGUIOffMode == 0)
        {
                return;
        }
        
        this.gameGUIOffMode.value = 丙业与丙丗丝不丈东;
    }
    public void set_DevicePushTokenInput(string 丙业与丙丗丝不丈东)
    {
        if(this.devicePushTokenInput == 0)
        {
                return;
        }
        
        this.devicePushTokenInput.value = 丙业与丙丗丝不丈东;
    }
    public void set_PlayerIdInput(string 丙业与丙丗丝不丈东)
    {
        if(this.playerIdInput == 0)
        {
                return;
        }
        
        this.playerIdInput.value = 丙业与丙丗丝不丈东;
    }
    public void set_AppVersionInput(string 丙业与丙丗丝不丈东)
    {
        if(this.appVersionInput == 0)
        {
                return;
        }
        
        this.appVersionInput.value = 丙业与丙丗丝不丈东;
    }
    public void set_SocialUserName(string 丙业与丙丗丝不丈东)
    {
        if(this.socialUsername == 0)
        {
                return;
        }
        
        this.socialUsername.text = 丙业与丙丗丝不丈东;
    }
    public bool get_MemoryInfoActive()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.memoryCheckbox)) == false)
        {
                return false;
        }
        
        if(this.memoryCheckbox != null)
        {
                return this.memoryCheckbox.value;
        }
        
        return this.memoryCheckbox.value;
    }
    public void set_MemoryInfoActive(bool 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.memoryCheckbox)) == false)
        {
                return;
        }
        
        this.memoryCheckbox.value = 丙业与丙丗丝不丈东;
    }
    public bool get_ReviewActive()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.reviewCheckbox)) == false)
        {
                return false;
        }
        
        if(this.reviewCheckbox != null)
        {
                return this.reviewCheckbox.value;
        }
        
        return this.reviewCheckbox.value;
    }
    public void set_ReviewActive(bool 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.reviewCheckbox)) == false)
        {
                return;
        }
        
        this.reviewCheckbox.value = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        DeveloperConsoleView.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        DeveloperConsoleView.丄丘七三上丕世丞业 = 0;
    }
    public DeveloperConsoleView()
    {
    
    }

}
