using UnityEngine;
private abstract class AmazonMobileAdsImpl.AmazonMobileAdsBase : AmazonMobileAdsImpl
{
    // Fields
    private static readonly object startLock;
    private static bool startCalled;
    
    // Methods
    protected void Start()
    {
        var val_2;
        bool val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_2 = null;
        val_2 = null;
        val_3 = AmazonMobileAdsImpl.AmazonMobileAdsBase.startCalled;
        if(val_3 == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = AmazonMobileAdsImpl.AmazonMobileAdsBase.startLock;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  val_3, lockTaken: ref  val_1);
        val_5 = null;
        val_5 = null;
        if(AmazonMobileAdsImpl.AmazonMobileAdsBase.startCalled != false)
        {
                val_6 = 0;
            val_7 = 0;
        }
        else
        {
                val_6 = 0;
            val_7 = 0;
            AmazonMobileAdsImpl.AmazonMobileAdsBase.startCalled = true;
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  val_3);
        }
        
        if(val_6 != 1)
        {
                return;
        }
        
        if(val_7 == 0)
        {
                return;
        }
    
    }
    protected abstract void Init(); // 0
    protected abstract void RegisterCallback(); // 0
    protected abstract void RegisterEventListener(); // 0
    protected abstract void RegisterCrossPlatformTool(); // 0
    public AmazonMobileAdsImpl.AmazonMobileAdsBase()
    {
        this = new UnityEngine.MonoBehaviour();
        .tag = this.GetType();
        com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger = new com.amazon.mas.cpt.ads.AmazonLogger();
    }
    public override void UnityFireEvent(string jsonMessage)
    {
        com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.FireEvent(jsonMessage:  jsonMessage);
    }
    public override void SetApplicationKey(com.amazon.mas.cpt.ads.ApplicationKey applicationKey)
    {
        var val_5;
        this.Start();
        string val_2 = this.SetApplicationKeyJson(jsonMessage:  applicationKey.ToJson());
        if(val_2 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_2)) != null)
        {
                val_5 = 0;
        }
        
        }
        
        com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string SetApplicationKeyJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeSetApplicationKeyJson(string jsonMessage); // 0
    public override void RegisterApplication()
    {
        var val_4;
        this.Start();
        string val_1 = this.RegisterApplicationJson(jsonMessage:  "{}");
        if(val_1 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_1)) != null)
        {
                val_4 = 0;
        }
        
        }
        
        com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string RegisterApplicationJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeRegisterApplicationJson(string jsonMessage); // 0
    public override void EnableLogging(com.amazon.mas.cpt.ads.ShouldEnable shouldEnable)
    {
        var val_5;
        this.Start();
        string val_2 = this.EnableLoggingJson(jsonMessage:  shouldEnable.ToJson());
        if(val_2 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_2)) != null)
        {
                val_5 = 0;
        }
        
        }
        
        com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string EnableLoggingJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeEnableLoggingJson(string jsonMessage); // 0
    public override void EnableTesting(com.amazon.mas.cpt.ads.ShouldEnable shouldEnable)
    {
        var val_5;
        this.Start();
        string val_2 = this.EnableTestingJson(jsonMessage:  shouldEnable.ToJson());
        if(val_2 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_2)) != null)
        {
                val_5 = 0;
        }
        
        }
        
        com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string EnableTestingJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeEnableTestingJson(string jsonMessage); // 0
    public override void EnableGeoLocation(com.amazon.mas.cpt.ads.ShouldEnable shouldEnable)
    {
        var val_5;
        this.Start();
        string val_2 = this.EnableGeoLocationJson(jsonMessage:  shouldEnable.ToJson());
        if(val_2 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_2)) != null)
        {
                val_5 = 0;
        }
        
        }
        
        com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string EnableGeoLocationJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeEnableGeoLocationJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.Ad CreateFloatingBannerAd(com.amazon.mas.cpt.ads.Placement placement)
    {
        this.Start();
        return com.amazon.mas.cpt.ads.Ad.CreateFromJson(jsonMessage:  this.CreateFloatingBannerAdJson(jsonMessage:  placement.ToJson()));
    }
    private string CreateFloatingBannerAdJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeCreateFloatingBannerAdJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.Ad CreateInterstitialAd()
    {
        this.Start();
        return com.amazon.mas.cpt.ads.Ad.CreateFromJson(jsonMessage:  this.CreateInterstitialAdJson(jsonMessage:  "{}"));
    }
    private string CreateInterstitialAdJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeCreateInterstitialAdJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.LoadingStarted LoadAndShowFloatingBannerAd(com.amazon.mas.cpt.ads.Ad ad)
    {
        this.Start();
        return com.amazon.mas.cpt.ads.LoadingStarted.CreateFromJson(jsonMessage:  this.LoadAndShowFloatingBannerAdJson(jsonMessage:  ad.ToJson()));
    }
    private string LoadAndShowFloatingBannerAdJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeLoadAndShowFloatingBannerAdJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.LoadingStarted LoadInterstitialAd()
    {
        this.Start();
        return com.amazon.mas.cpt.ads.LoadingStarted.CreateFromJson(jsonMessage:  this.LoadInterstitialAdJson(jsonMessage:  "{}"));
    }
    private string LoadInterstitialAdJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeLoadInterstitialAdJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.AdShown ShowInterstitialAd()
    {
        this.Start();
        return com.amazon.mas.cpt.ads.AdShown.CreateFromJson(jsonMessage:  this.ShowInterstitialAdJson(jsonMessage:  "{}"));
    }
    private string ShowInterstitialAdJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeShowInterstitialAdJson(string jsonMessage); // 0
    public override void CloseFloatingBannerAd(com.amazon.mas.cpt.ads.Ad ad)
    {
        var val_5;
        this.Start();
        string val_2 = this.CloseFloatingBannerAdJson(jsonMessage:  ad.ToJson());
        if(val_2 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_2)) != null)
        {
                val_5 = 0;
        }
        
        }
        
        com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string CloseFloatingBannerAdJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeCloseFloatingBannerAdJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.IsReady IsInterstitialAdReady()
    {
        this.Start();
        return com.amazon.mas.cpt.ads.IsReady.CreateFromJson(jsonMessage:  this.IsInterstitialAdReadyJson(jsonMessage:  "{}"));
    }
    private string IsInterstitialAdReadyJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeIsInterstitialAdReadyJson(string jsonMessage); // 0
    public override com.amazon.mas.cpt.ads.IsEqual AreAdsEqual(com.amazon.mas.cpt.ads.AdPair adPair)
    {
        this.Start();
        return com.amazon.mas.cpt.ads.IsEqual.CreateFromJson(jsonMessage:  this.AreAdsEqualJson(jsonMessage:  adPair.ToJson()));
    }
    private string AreAdsEqualJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeAreAdsEqualJson(string jsonMessage); // 0
    public override void AddAdCollapsedListener(com.amazon.mas.cpt.ads.AdCollapsedDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adCollapsed")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.mas.cpt.ads.AdCollapsedDelegator() = new com.amazon.mas.cpt.ads.AdCollapsedDelegator(responseDelegate:  responseDelegate);
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adCollapsed"].Add(item:  new com.amazon.mas.cpt.ads.AdCollapsedDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>();
            new com.amazon.mas.cpt.ads.AdCollapsedDelegator() = new com.amazon.mas.cpt.ads.AdCollapsedDelegator(responseDelegate:  responseDelegate);
            null.Add(item:  new com.amazon.mas.cpt.ads.AdCollapsedDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Add(key:  "adCollapsed", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(107 == 107)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public override void RemoveAdCollapsedListener(com.amazon.mas.cpt.ads.AdCollapsedDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.mas.cpt.ads.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adCollapsed")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adCollapsed"].GetEnumerator();
        label_14:
        if(((-1878044736) & 1) == 0)
        {
            goto label_11;
        }
        
        val_17 = val_6.丐丏七丌丕丗业且上();
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_17 = 0;
        label_13:
        if((System.Delegate.op_Equality(d1:  11993091, d2:  val_13)) == false)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_18 = null;
        val_13 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners;
        bool val_11 = val_13.Item["adCollapsed"].Remove(item:  val_17);
        label_11:
        val_19 = 0;
        val_20 = 0;
        goto label_19;
        label_6:
        val_19 = 0;
        goto label_37;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (147 != 147))
        {
            goto label_35;
        }
        
        val_22 = 0;
        goto label_38;
        label_35:
        label_37:
        val_22 = 0 + 1;
        val_20 = 0;
        mem2[0] = 147;
        label_38:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(147 == 147)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    public override void AddAdDismissedListener(com.amazon.mas.cpt.ads.AdDismissedDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adDismissed")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.mas.cpt.ads.AdDismissedDelegator() = new com.amazon.mas.cpt.ads.AdDismissedDelegator(responseDelegate:  responseDelegate);
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adDismissed"].Add(item:  new com.amazon.mas.cpt.ads.AdDismissedDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>();
            new com.amazon.mas.cpt.ads.AdDismissedDelegator() = new com.amazon.mas.cpt.ads.AdDismissedDelegator(responseDelegate:  responseDelegate);
            null.Add(item:  new com.amazon.mas.cpt.ads.AdDismissedDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Add(key:  "adDismissed", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(107 == 107)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public override void RemoveAdDismissedListener(com.amazon.mas.cpt.ads.AdDismissedDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.mas.cpt.ads.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adDismissed")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adDismissed"].GetEnumerator();
        label_14:
        if(((-1877738720) & 1) == 0)
        {
            goto label_11;
        }
        
        val_17 = val_6.丐丏七丌丕丗业且上();
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_17 = 0;
        label_13:
        if((System.Delegate.op_Equality(d1:  11993091, d2:  val_13)) == false)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_18 = null;
        val_13 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners;
        bool val_11 = val_13.Item["adDismissed"].Remove(item:  val_17);
        label_11:
        val_19 = 0;
        val_20 = 0;
        goto label_19;
        label_6:
        val_19 = 0;
        goto label_37;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (147 != 147))
        {
            goto label_35;
        }
        
        val_22 = 0;
        goto label_38;
        label_35:
        label_37:
        val_22 = 0 + 1;
        val_20 = 0;
        mem2[0] = 147;
        label_38:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(147 == 147)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    public override void AddAdExpandedListener(com.amazon.mas.cpt.ads.AdExpandedDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adExpanded")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.mas.cpt.ads.AdExpandedDelegator() = new com.amazon.mas.cpt.ads.AdExpandedDelegator(responseDelegate:  responseDelegate);
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adExpanded"].Add(item:  new com.amazon.mas.cpt.ads.AdExpandedDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>();
            new com.amazon.mas.cpt.ads.AdExpandedDelegator() = new com.amazon.mas.cpt.ads.AdExpandedDelegator(responseDelegate:  responseDelegate);
            null.Add(item:  new com.amazon.mas.cpt.ads.AdExpandedDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Add(key:  "adExpanded", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(107 == 107)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public override void RemoveAdExpandedListener(com.amazon.mas.cpt.ads.AdExpandedDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.mas.cpt.ads.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adExpanded")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adExpanded"].GetEnumerator();
        label_14:
        if(((-1877432704) & 1) == 0)
        {
            goto label_11;
        }
        
        val_17 = val_6.丐丏七丌丕丗业且上();
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_17 = 0;
        label_13:
        if((System.Delegate.op_Equality(d1:  11993091, d2:  val_13)) == false)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_18 = null;
        val_13 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners;
        bool val_11 = val_13.Item["adExpanded"].Remove(item:  val_17);
        label_11:
        val_19 = 0;
        val_20 = 0;
        goto label_19;
        label_6:
        val_19 = 0;
        goto label_37;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (147 != 147))
        {
            goto label_35;
        }
        
        val_22 = 0;
        goto label_38;
        label_35:
        label_37:
        val_22 = 0 + 1;
        val_20 = 0;
        mem2[0] = 147;
        label_38:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(147 == 147)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    public override void AddAdFailedToLoadListener(com.amazon.mas.cpt.ads.AdFailedToLoadDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adFailedToLoad")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.mas.cpt.ads.AdFailedToLoadDelegator() = new com.amazon.mas.cpt.ads.AdFailedToLoadDelegator(responseDelegate:  responseDelegate);
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adFailedToLoad"].Add(item:  new com.amazon.mas.cpt.ads.AdFailedToLoadDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>();
            new com.amazon.mas.cpt.ads.AdFailedToLoadDelegator() = new com.amazon.mas.cpt.ads.AdFailedToLoadDelegator(responseDelegate:  responseDelegate);
            null.Add(item:  new com.amazon.mas.cpt.ads.AdFailedToLoadDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Add(key:  "adFailedToLoad", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(107 == 107)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public override void RemoveAdFailedToLoadListener(com.amazon.mas.cpt.ads.AdFailedToLoadDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.mas.cpt.ads.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adFailedToLoad")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adFailedToLoad"].GetEnumerator();
        label_14:
        if(((-1877126688) & 1) == 0)
        {
            goto label_11;
        }
        
        val_17 = val_6.丐丏七丌丕丗业且上();
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_17 = 0;
        label_13:
        if((System.Delegate.op_Equality(d1:  11993091, d2:  val_13)) == false)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_18 = null;
        val_13 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners;
        bool val_11 = val_13.Item["adFailedToLoad"].Remove(item:  val_17);
        label_11:
        val_19 = 0;
        val_20 = 0;
        goto label_19;
        label_6:
        val_19 = 0;
        goto label_37;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (147 != 147))
        {
            goto label_35;
        }
        
        val_22 = 0;
        goto label_38;
        label_35:
        label_37:
        val_22 = 0 + 1;
        val_20 = 0;
        mem2[0] = 147;
        label_38:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(147 == 147)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    public override void AddAdLoadedListener(com.amazon.mas.cpt.ads.AdLoadedDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adLoaded")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.mas.cpt.ads.AdLoadedDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adLoaded"].Add(item:  new com.amazon.mas.cpt.ads.AdLoadedDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>();
            new com.amazon.mas.cpt.ads.AdLoadedDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            null.Add(item:  new com.amazon.mas.cpt.ads.AdLoadedDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Add(key:  "adLoaded", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(107 == 107)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public override void RemoveAdLoadedListener(com.amazon.mas.cpt.ads.AdLoadedDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.mas.cpt.ads.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adLoaded")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adLoaded"].GetEnumerator();
        label_14:
        if(((-1876820672) & 1) == 0)
        {
            goto label_11;
        }
        
        val_17 = val_6.丐丏七丌丕丗业且上();
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_17 = 0;
        label_13:
        if((System.Delegate.op_Equality(d1:  11993091, d2:  val_13)) == false)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_18 = null;
        val_13 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners;
        bool val_11 = val_13.Item["adLoaded"].Remove(item:  val_17);
        label_11:
        val_19 = 0;
        val_20 = 0;
        goto label_19;
        label_6:
        val_19 = 0;
        goto label_37;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (147 != 147))
        {
            goto label_35;
        }
        
        val_22 = 0;
        goto label_38;
        label_35:
        label_37:
        val_22 = 0 + 1;
        val_20 = 0;
        mem2[0] = 147;
        label_38:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(147 == 147)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    public override void AddAdResizedListener(com.amazon.mas.cpt.ads.AdResizedDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adResized")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.mas.cpt.ads.AdResizedDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adResized"].Add(item:  new com.amazon.mas.cpt.ads.AdResizedDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>();
            new com.amazon.mas.cpt.ads.AdResizedDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            null.Add(item:  new com.amazon.mas.cpt.ads.AdResizedDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Add(key:  "adResized", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(107 == 107)
        {
                return;
        }
        
            return;
        }
        
        if(0 != 0)
        {
                return;
        }
    
    }
    public override void RemoveAdResizedListener(com.amazon.mas.cpt.ads.AdResizedDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.mas.cpt.ads.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.ContainsKey(key:  "adResized")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item["adResized"].GetEnumerator();
        label_14:
        if(((-1876514656) & 1) == 0)
        {
            goto label_11;
        }
        
        val_17 = val_6.丐丏七丌丕丗业且上();
        if(val_17 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_17 = 0;
        label_13:
        if((System.Delegate.op_Equality(d1:  11993091, d2:  val_13)) == false)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_18 = null;
        val_13 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners;
        bool val_11 = val_13.Item["adResized"].Remove(item:  val_17);
        label_11:
        val_19 = 0;
        val_20 = 0;
        goto label_19;
        label_6:
        val_19 = 0;
        goto label_37;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (147 != 147))
        {
            goto label_35;
        }
        
        val_22 = 0;
        goto label_38;
        label_35:
        label_37:
        val_22 = 0 + 1;
        val_20 = 0;
        mem2[0] = 147;
        label_38:
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock);
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(147 == 147)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    private static AmazonMobileAdsImpl.AmazonMobileAdsBase()
    {
        AmazonMobileAdsImpl.AmazonMobileAdsBase.startLock = new System.Object();
        AmazonMobileAdsImpl.AmazonMobileAdsBase.startCalled = false;
    }

}
