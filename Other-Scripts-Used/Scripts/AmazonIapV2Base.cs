using UnityEngine;
private abstract class AmazonIapV2Impl.AmazonIapV2Base : AmazonIapV2Impl
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
        val_3 = AmazonIapV2Impl.AmazonIapV2Base.startCalled;
        if(val_3 == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = AmazonIapV2Impl.AmazonIapV2Base.startLock;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  val_3, lockTaken: ref  val_1);
        val_5 = null;
        val_5 = null;
        if(AmazonIapV2Impl.AmazonIapV2Base.startCalled != false)
        {
                val_6 = 0;
            val_7 = 0;
        }
        else
        {
                val_6 = 0;
            val_7 = 0;
            AmazonIapV2Impl.AmazonIapV2Base.startCalled = true;
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
    public AmazonIapV2Impl.AmazonIapV2Base()
    {
        this = new UnityEngine.MonoBehaviour();
        .tag = this.GetType();
        com.amazon.device.iap.cpt.AmazonIapV2Impl.logger = new com.amazon.device.iap.cpt.AmazonLogger();
    }
    public override void UnityFireEvent(string jsonMessage)
    {
        com.amazon.device.iap.cpt.AmazonIapV2Impl.FireEvent(jsonMessage:  jsonMessage);
    }
    public override com.amazon.device.iap.cpt.RequestOutput GetUserData()
    {
        this.Start();
        return com.amazon.device.iap.cpt.RequestOutput.CreateFromJson(jsonMessage:  this.GetUserDataJson(jsonMessage:  "{}"));
    }
    private string GetUserDataJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.device.iap.cpt.AmazonIapV2Impl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeGetUserDataJson(string jsonMessage); // 0
    public override com.amazon.device.iap.cpt.RequestOutput Purchase(com.amazon.device.iap.cpt.SkuInput skuInput)
    {
        this.Start();
        return com.amazon.device.iap.cpt.RequestOutput.CreateFromJson(jsonMessage:  this.PurchaseJson(jsonMessage:  skuInput.ToJson()));
    }
    private string PurchaseJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.device.iap.cpt.AmazonIapV2Impl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativePurchaseJson(string jsonMessage); // 0
    public override com.amazon.device.iap.cpt.RequestOutput GetProductData(com.amazon.device.iap.cpt.SkusInput skusInput)
    {
        this.Start();
        return com.amazon.device.iap.cpt.RequestOutput.CreateFromJson(jsonMessage:  this.GetProductDataJson(jsonMessage:  skusInput.ToJson()));
    }
    private string GetProductDataJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.device.iap.cpt.AmazonIapV2Impl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeGetProductDataJson(string jsonMessage); // 0
    public override com.amazon.device.iap.cpt.RequestOutput GetPurchaseUpdates(com.amazon.device.iap.cpt.ResetInput resetInput)
    {
        this.Start();
        return com.amazon.device.iap.cpt.RequestOutput.CreateFromJson(jsonMessage:  this.GetPurchaseUpdatesJson(jsonMessage:  resetInput.ToJson()));
    }
    private string GetPurchaseUpdatesJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.device.iap.cpt.AmazonIapV2Impl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeGetPurchaseUpdatesJson(string jsonMessage); // 0
    public override void NotifyFulfillment(com.amazon.device.iap.cpt.NotifyFulfillmentInput notifyFulfillmentInput)
    {
        var val_5;
        this.Start();
        string val_2 = this.NotifyFulfillmentJson(jsonMessage:  notifyFulfillmentInput.ToJson());
        if(val_2 != null)
        {
                if((Json.Parser.Parse(jsonString:  val_2)) != null)
        {
                val_5 = 0;
        }
        
        }
        
        com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
    }
    private string NotifyFulfillmentJson(string jsonMessage)
    {
        var val_4;
        System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
        val_1.Start();
        val_1.Stop();
        val_4 = null;
        val_4 = null;
        AmazonLogging.Log(reportLevel:  5, service:  com.amazon.device.iap.cpt.AmazonIapV2Impl.logger.tag, message:  System.String.Format(format:  "Successfully called native code in {0} ms", arg0:  val_1.ElapsedMilliseconds));
        return (string)this;
    }
    protected abstract string NativeNotifyFulfillmentJson(string jsonMessage); // 0
    public override void AddGetUserDataResponseListener(com.amazon.device.iap.cpt.GetUserDataResponseDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "getUserDataResponse")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.device.iap.cpt.GetUserDataResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["getUserDataResponse"].Add(item:  new com.amazon.device.iap.cpt.GetUserDataResponseDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator>();
            new com.amazon.device.iap.cpt.GetUserDataResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            null.Add(item:  new com.amazon.device.iap.cpt.GetUserDataResponseDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Add(key:  "getUserDataResponse", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void RemoveGetUserDataResponseListener(com.amazon.device.iap.cpt.GetUserDataResponseDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.device.iap.cpt.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "getUserDataResponse")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["getUserDataResponse"].GetEnumerator();
        label_14:
        if(((-1848018064) & 1) == 0)
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
        val_13 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners;
        bool val_11 = val_13.Item["getUserDataResponse"].Remove(item:  val_17);
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
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void AddPurchaseResponseListener(com.amazon.device.iap.cpt.PurchaseResponseDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "purchaseResponse")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.device.iap.cpt.PurchaseResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["purchaseResponse"].Add(item:  new com.amazon.device.iap.cpt.PurchaseResponseDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator>();
            new com.amazon.device.iap.cpt.PurchaseResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            null.Add(item:  new com.amazon.device.iap.cpt.PurchaseResponseDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Add(key:  "purchaseResponse", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void RemovePurchaseResponseListener(com.amazon.device.iap.cpt.PurchaseResponseDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.device.iap.cpt.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "purchaseResponse")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["purchaseResponse"].GetEnumerator();
        label_14:
        if(((-1847712032) & 1) == 0)
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
        val_13 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners;
        bool val_11 = val_13.Item["purchaseResponse"].Remove(item:  val_17);
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
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void AddGetProductDataResponseListener(com.amazon.device.iap.cpt.GetProductDataResponseDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "getProductDataResponse")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.device.iap.cpt.GetProductDataResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["getProductDataResponse"].Add(item:  new com.amazon.device.iap.cpt.GetProductDataResponseDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator>();
            new com.amazon.device.iap.cpt.GetProductDataResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            null.Add(item:  new com.amazon.device.iap.cpt.GetProductDataResponseDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Add(key:  "getProductDataResponse", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void RemoveGetProductDataResponseListener(com.amazon.device.iap.cpt.GetProductDataResponseDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.device.iap.cpt.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "getProductDataResponse")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["getProductDataResponse"].GetEnumerator();
        label_14:
        if(((-1847406000) & 1) == 0)
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
        val_13 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners;
        bool val_11 = val_13.Item["getProductDataResponse"].Remove(item:  val_17);
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
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void AddGetPurchaseUpdatesResponseListener(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate responseDelegate)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        this.Start();
        val_7 = null;
        val_7 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_8 = null;
        val_8 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "getPurchaseUpdatesResponse")) != false)
        {
                val_9 = null;
            val_9 = null;
            new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["getPurchaseUpdatesResponse"].Add(item:  new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegator());
        }
        else
        {
                System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator> val_5 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.IDelegator>();
            new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegator() = new System.Object();
            .responseDelegate = responseDelegate;
            null.Add(item:  new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegator());
            val_10 = null;
            val_10 = null;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Add(key:  "getPurchaseUpdatesResponse", value:  null);
        }
        
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    public override void RemoveGetPurchaseUpdatesResponseListener(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate responseDelegate)
    {
        var val_6;
        System.Delegate val_13;
        var val_14;
        var val_15;
        var val_16;
        com.amazon.device.iap.cpt.IDelegator val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_13 = responseDelegate;
        this.Start();
        val_14 = null;
        val_14 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock, lockTaken: ref  val_1);
        val_15 = null;
        val_15 = null;
        if((com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.ContainsKey(key:  "getPurchaseUpdatesResponse")) == false)
        {
            goto label_6;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_4 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners.Item["getPurchaseUpdatesResponse"].GetEnumerator();
        label_14:
        if(((-1847099952) & 1) == 0)
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
        val_13 = com.amazon.device.iap.cpt.AmazonIapV2Impl.eventListeners;
        bool val_11 = val_13.Item["getPurchaseUpdatesResponse"].Remove(item:  val_17);
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
                System.Threading.Monitor.Exit(obj:  com.amazon.device.iap.cpt.AmazonIapV2Impl.eventLock);
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
    private static AmazonIapV2Impl.AmazonIapV2Base()
    {
        AmazonIapV2Impl.AmazonIapV2Base.startLock = new System.Object();
        AmazonIapV2Impl.AmazonIapV2Base.startCalled = false;
    }

}
