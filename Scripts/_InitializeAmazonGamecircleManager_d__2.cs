using UnityEngine;
private sealed class InAppInstancer.<InitializeAmazonGamecircleManager>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InAppInstancer <>4__this;
    private string <thisMethod>5__2;
    private Rilisoft.丅丞丈丅东丆与世丈 <>7__wrap2;
    private Rilisoft.丅丞丈丅东丆与世丈 <>7__wrap3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InAppInstancer.<InitializeAmazonGamecircleManager>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        int val_4 = this.<>1__state;
        val_4 = val_4 + 4;
        if(val_4 > 6)
        {
                return;
        }
        
        var val_5 = 106020424 + ((this.<>1__state + 4)) << 2;
        val_5 = val_5 + 106020424;
        goto (106020424 + ((this.<>1__state + 4)) << 2 + 106020424);
    }
    private bool MoveNext()
    {
        int val_32;
        var val_34;
        UnityEngine.GameObject val_36;
        int val_37;
        var val_38;
        var val_41;
        var val_42;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 2)
        {
            goto label_123;
        }
        
        val_32 = -4;
        goto label_4;
        label_2:
        this.<>1__state = -3;
        this.<>4__this._leaderboardId = (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2) ? "CgkIr8rGkPIJEAIQCg" : "best_survival_scores";
        com.amazon.mas.cpt.ads.IAmazonMobileAds val_3 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.Instance;
        new com.amazon.mas.cpt.ads.ShouldEnable() = new com.amazon.mas.cpt.ads.ShouldEnable();
        val_34 = 0;
        new com.amazon.mas.cpt.ads.ShouldEnable().BooleanValue = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        var val_31 = 0;
        val_31 = val_31 + 1;
        val_34 = 2;
        goto label_17;
        label_1:
        this.<>1__state = 0;
        this.<thisMethod>5__2 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}.InitializeAmazonGamecircleManager()", arg0:  this.<>4__this.GetType());
        mem[1152921526285611616] = 0;
        this.<>1__state = -3;
        this.<>7__wrap2 = 0;
        System.Type[] val_10 = new System.Type[1];
        val_10[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_36 = new UnityEngine.GameObject();
        val_36 = new UnityEngine.GameObject(name:  "Rilisoft.AmazonGameCircleManager", components:  val_10);
        UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        val_37 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_37;
        return (bool)val_37;
        label_17:
        val_3.EnableLogging(shouldEnable:  new com.amazon.mas.cpt.ads.ShouldEnable());
        new com.amazon.mas.cpt.ads.ApplicationKey() = new com.amazon.mas.cpt.ads.ApplicationKey();
        val_38 = 0;
        new com.amazon.mas.cpt.ads.ApplicationKey().StringValue = "1bb979bc6c9e4059a318370a68dcaeea";
        var val_32 = 0;
        val_32 = val_32 + 1;
        val_38 = 0;
        val_3.SetApplicationKey(applicationKey:  new com.amazon.mas.cpt.ads.ApplicationKey());
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_3.RegisterApplication();
        val_41 = 0;
        val_36 = 0;
        if((val_41 != 1) && (298 == 298))
        {
                val_41 = 0;
        }
        else
        {
                if(val_36 != 0)
        {
                val_42 = val_36;
            val_36 = 0;
        }
        
        }
        
        if(AGSClient.IsServiceReady() != true)
        {
                new System.Action() = new System.Action(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleAmazonGamecircleServiceReady());
            AGSClient.add_ServiceReadyEvent(value:  new System.Action());
            System.Action<System.String> val_19 = new System.Action<System.String>(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleAmazonGamecircleServiceNotReady(string message));
            AGSClient.add_ServiceNotReadyEvent(value:  null);
            AGSClient.Init(supportsLeaderboards:  true, supportsAchievements:  true, supportsWhispersync:  true);
            new System.Action() = new System.Action(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleAmazonPotentialProgressConflicts());
            AGSWhispersyncClient.add_OnNewCloudDataEvent(value:  new System.Action());
            new System.Action() = new System.Action(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleAmazonPotentialProgressConflicts());
            AGSWhispersyncClient.add_OnDataUploadedToCloudEvent(value:  new System.Action());
            new System.Action() = new System.Action(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleAmazonSyncFailed());
            AGSWhispersyncClient.add_OnSyncFailedEvent(value:  new System.Action());
            new System.Action() = new System.Action(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleAmazonThrottled());
            AGSWhispersyncClient.add_OnThrottledEvent(value:  new System.Action());
            val_41 = 1;
            if(val_41 != 1)
        {
                if(520 == 520)
        {
            goto label_54;
        }
        
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "Amazon GameCircle was already initialized.");
        System.Action<System.String> val_24 = new System.Action<System.String>(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleSubmitScoreSucceeded(string leaderbordId));
        AGSLeaderboardsClient.add_SubmitScoreSucceededEvent(value:  null);
        val_36 = null;
        val_36 = new System.Action<System.String, System.String>(object:  this.<>4__this, method:  System.Void InAppInstancer::HandleSubmitScoreFailed(string leaderbordId, string error));
        AGSLeaderboardsClient.add_SubmitScoreFailedEvent(value:  null);
        AGSLeaderboardsClient.SubmitScore(leaderboardId:  this.<>4__this._leaderboardId, score:  (long)UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.七丘丗万丞与丄丒丏(), defaultValue:  0), userData:  0);
        label_54:
        bool val_29 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        val_32 = -4;
        mem[1152921526285611648] = 0;
        this.<>7__wrap3 = 0;
        label_4:
        this.<>1__state = val_32;
        if(AGSClient.IsServiceReady() != false)
        {
                this.<>1__state = -3;
            mem2[0] = false;
            与丒丕丁下世东丅丌 = false;
            mem[1] = 0;
            this.<>1__state = 0;
            val_37 = 0;
            mem2[0] = false;
            与丒丕丁下世东丅丌 = false;
            mem[1] = 0;
            return (bool)val_37;
        }
        
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_37 = 1;
        return (bool)val_37;
        label_123:
        val_37 = 0;
        return (bool)val_37;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
    }
    private void <>m__Finally2()
    {
        this.<>1__state = -3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
