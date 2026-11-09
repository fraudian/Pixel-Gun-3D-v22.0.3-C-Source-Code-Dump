using UnityEngine;
internal sealed class coinsShop : MonoBehaviour
{
    // Fields
    private static System.Action 与丒丘丅丙丌七丂丑;
    internal static coinsShop 专丆专上丗万世丒七;
    internal static bool 与丄丒与丆丏世丏丙;
    private bool 业丌丕丂世业下丝丐;
    internal System.Action 下丄丑不丆丕上丌丘;
    private UnityEngine.Coroutine 万一东专丑丅丌丂世;
    private UnityEngine.Coroutine 丙七业上丁业丁业丗;
    private static readonly System.Collections.Generic.HashSet<string> 丈三世丄丟上丏三丑;
    private static int 丛丏丆丗万东丐七丕;
    private static bool 丆丆世丆一丝万丑丟;
    private static bool <丌丘丁丆丘丒丁一丞>k__BackingField;
    private static System.Nullable<System.DateTime> 丑丝丝丒丞丂丈丗丌;
    private bool 三东丗丂丁下丞丒下;
    private UnityEngine.WaitForSeconds 上丏三下专万专东与;
    private System.Action 专下丕丐世万丏丆丙;
    
    // Properties
    internal static bool 且丅丒丕丙丙七丂一 { get; }
    internal static bool 世丝下丌丄一丌丆不 { get; }
    internal static bool 三丅与丈丅三丕丆丞 { get; }
    private static bool 丘丘与丁丁丄下万业 { get; set; }
    internal static bool 丆丆丏丁丗丅不丒丏 { get; }
    internal static bool 丏丈丌丆与丞七且丘 { get; }
    
    // Methods
    internal static void 丌丘丙丂且丅丞丂世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  coinsShop.与丒丘丅丙丌七丂丑, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丅丞丏丐丛不丈东万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  coinsShop.与丒丘丅丙丌七丂丑, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    private void 业丌不上丂丗丂丂东(System.Collections.Generic.List<Prime31.GooglePurchase> 一丛丂丘丝业且丞三, System.Collections.Generic.List<Prime31.GoogleSkuInfo> 与丅东丑不丈丌丒上)
    {
        System.Collections.Generic.IEnumerable<TSource> val_9;
        var val_10;
        System.Func<Prime31.GoogleSkuInfo, System.Boolean> val_12;
        var val_14;
        System.Func<Prime31.GoogleSkuInfo, System.String> val_16;
        val_9 = 与丅东丑不丈丌丒上;
        val_10 = null;
        val_10 = null;
        val_12 = coinsShop.<>c.<>9__7_0;
        if(val_12 == null)
        {
                System.Func<Prime31.GoogleSkuInfo, System.Boolean> val_1 = null;
            val_12 = val_1;
            val_1 = new System.Func<Prime31.GoogleSkuInfo, System.Boolean>(object:  coinsShop.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean coinsShop.<>c::丂丙丒丁不专一业丝(Prime31.GoogleSkuInfo 丏丛与丅丛丌万专丌));
            coinsShop.<>c.<>9__7_0 = val_12;
        }
        
        if((System.Linq.Enumerable.Any<Prime31.GoogleSkuInfo>(source:  val_9, predicate:  val_1)) == true)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = coinsShop.<>c.<>9__7_1;
        if(val_16 == null)
        {
                System.Func<Prime31.GoogleSkuInfo, System.String> val_3 = null;
            val_16 = val_3;
            val_3 = new System.Func<Prime31.GoogleSkuInfo, System.String>(object:  coinsShop.<>c.__il2cppRuntimeField_static_fields, method:  System.String coinsShop.<>c::七丁丆丐丛丑丞丈丞(Prime31.GoogleSkuInfo 丑东丅与丄业一丒丅));
            coinsShop.<>c.<>9__7_1 = val_16;
        }
        
        val_9 = System.String.Join(separator:  ", ", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Prime31.GoogleSkuInfo, System.String>(source:  val_9, selector:  val_3)));
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Google: Query inventory succeeded;\tPurchases count: {0}, Skus: [{1}]", arg0:  一丛丂丘丝业且丞三.Count, arg1:  val_9));
        this.业丌丕丂世业下丝丐 = true;
    }
    private void 丂丛七丐丑丟丙不且(com.amazon.device.iap.cpt.GetProductDataResponse 丑与丂丌世丕丆一丗)
    {
        if("SUCCESSFUL" == null)
        {
                "SUCCESSFUL" = "SUCCESSFUL";
        }
        
        bool val_2 = Equals(value:  丑与丂丌世丕丆一丗.Status, comparisonType:  5);
        if(丑与丂丌世丕丆一丗 == null)
        {
            goto label_3;
        }
        
        if(val_2 == false)
        {
            goto label_4;
        }
        
        label_7:
        UnityEngine.Debug.Log(message:  "Amazon GetProductDa_taResponse (CoinsShop): "("Amazon GetProductDa_taResponse (CoinsShop): ") + 丑与丂丌世丕丆一丗.ToJson());
        this.业丌丕丂世业下丝丐 = true;
        return;
        label_3:
        if(val_2 == true)
        {
            goto label_7;
        }
        
        label_4:
        UnityEngine.Debug.LogWarning(message:  "Amazon GetProductDa_taResponse (CoinsShop): "("Amazon GetProductDa_taResponse (CoinsShop): ") + 丑与丂丌世丕丆一丗.Status);
    }
    private void OnEnable()
    {
        if((System.String.op_Inequality(a:  UnityEngine.Application.loadedLevelName, b:  "Loading")) != false)
        {
                ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丗下与不丑业丝且不());
    }
    private void OnDisable()
    {
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    private void OnDestroy()
    {
        var val_6;
        IntPtr val_7;
        val_6 = null;
        val_6 = null;
        coinsShop.专丆专上丗万世丒七 = 0;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                com.amazon.device.iap.cpt.GetProductDataResponseDelegate val_3 = null;
            val_7 = System.Void coinsShop::丂丛七丐丑丟丙不且(com.amazon.device.iap.cpt.GetProductDataResponse 丑与丂丌世丕丆一丗);
            val_3 = new com.amazon.device.iap.cpt.GetProductDataResponseDelegate(object:  this, method:  val_7);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 11;
        }
        else
        {
                Prime31.GoogleIABManager.remove_queryInventorySucceededEvent(value:  new System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>>(object:  this, method:  System.Void coinsShop::业丌不上丂丗丂丂东(System.Collections.Generic.List<Prime31.GooglePurchase> 一丛丂丘丝业且丞三, System.Collections.Generic.List<Prime31.GoogleSkuInfo> 与丅东丑不丈丌丒上)));
            return;
        }
        
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.RemoveGetProductDataResponseListener(responseDelegate:  val_3);
    }
    private void Awake()
    {
        var val_8;
        IntPtr val_9;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        if(UnityEngine.Application.isEditor != false)
        {
                this.业丌丕丂世业下丝丐 = true;
        }
        
        val_8 = null;
        val_8 = null;
        coinsShop.专丆专上丗万世丒七 = this;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_8;
        }
        
        com.amazon.device.iap.cpt.GetProductDataResponseDelegate val_5 = null;
        val_9 = System.Void coinsShop::丂丛七丐丑丟丙不且(com.amazon.device.iap.cpt.GetProductDataResponse 丑与丂丌世丕丆一丗);
        val_5 = new com.amazon.device.iap.cpt.GetProductDataResponseDelegate(object:  this, method:  val_9);
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = 10;
        goto label_15;
        label_8:
        Prime31.GoogleIABManager.add_queryInventorySucceededEvent(value:  new System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>>(object:  this, method:  System.Void coinsShop::业丌不上丂丗丂丂东(System.Collections.Generic.List<Prime31.GooglePurchase> 一丛丂丘丝业且丞三, System.Collections.Generic.List<Prime31.GoogleSkuInfo> 与丅东丑不丈丌丒上)));
        goto label_18;
        label_15:
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.AddGetProductDataResponseListener(responseDelegate:  val_5);
        label_18:
        this.与不丌丗上不且专丗(丑丞东万丁丂丏万丙:  "coinsShop.Awake()", 七丆丟丗世丟且丒丆:  false);
    }
    private void Start()
    {
        LifetimeEventsRaiser.丑七不且上丗丁一世().丈丒丒东下丆丙丄丌(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void coinsShop::丑且与七丕丑丂丂七(bool 丁与丟万丄丒丗专丌)));
    }
    internal static void 丙丝东下世丟丙丆七(string 丏丂不专上丘丂不丅)
    {
        CoinsMessage.丄丝世丒一下丙丗不(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅, 丌丒丝东丌下丕丁丅:  2);
    }
    internal void 丌丆丙与丛专上东丌(int 世丈三丐丞一丒丛不, System.Collections.Generic.Dictionary<string, object> 丈上上丟丟丏万丐且)
    {
        var val_6;
        int val_7;
        丘丝丑丐丆丑七不丙 val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_14;
        val_6 = null;
        val_7 = System.String.alignConst;
        val_6 = null;
        val_8 = 0;
        if(coinsShop.专丆专上丗万世丒七 == 0)
        {
            goto label_16;
        }
        
        val_9 = 0;
        goto label_6;
        label_15:
        val_10 = null;
        val_10 = null;
        if(val_9 >= StoreKitEventListener.丝不东丅丅丂三且丑.Length)
        {
                val_11 = 0;
        }
        
        if((StoreKitEventListener.丝不东丅丅丂三且丑.Length + 32) == 世丈三丐丞一丒丛不)
        {
            goto label_11;
        }
        
        val_9 = 1;
        label_6:
        val_12 = null;
        val_12 = null;
        if(val_9 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
        {
            goto label_15;
        }
        
        val_8 = 0;
        goto label_16;
        label_11:
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_11 = 0;
        val_14 = null;
        val_8 = AbstractBankView.丒丁丞丝世三与七东().Item[0];
        val_14 = null;
        val_7 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
        val_7 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
        label_16:
        if(val_8 == 0)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == true)
        {
                return;
        }
        
        if((丈上上丟丟丏万丐且.ContainsKey(key:  "ID")) != true)
        {
                丈上上丟丟丏万丐且.Add(key:  "ID", value:  val_7);
        }
        
        this.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  val_8, 丈上上丟丟丏万丐且:  丈上上丟丟丏万丐且);
    }
    internal bool 东业丒丒丈丏丈与丁(string 丅丞丂丟丟且丅丆丅)
    {
        var val_2;
        ButtonClickSound.丁业上丏不丕三丗不();
        if((this.丌丛丒丏万万与丁不(丅丞丂丟丟且丅丆丅:  丅丞丂丟丟且丅丆丅)) != false)
        {
                coinsShop.业丛一丁丌丏三丗万(丘丌丌丙丆下丄东上:  丅丞丂丟丟且丅丆丅);
            丅丞丂丟丟且丅丆丅.丞世丕与丗丙三七三(丅丞丂丟丟且丅丆丅:  丅丞丂丟丟且丅丆丅, 丈上上丟丟丏万丐且:  0);
            val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    internal void 丌丆丙与丛专上东丌(丘丝丑丐丆丑七不丙 一丒丆业丅七丛且丏, System.Collections.Generic.Dictionary<string, object> 丈上上丟丟丏万丐且)
    {
        object val_19;
        var val_20;
        int val_21;
        object val_26;
        coinsShop.三丅丞丒丕丅专一丅 val_1 = null;
        val_19 = val_1;
        val_1 = new coinsShop.三丅丞丒丕丅专一丅();
        if(val_19 != null)
        {
                val_20 = val_19;
            .一丒丆业丅七丛且丏 = 一丒丆业丅七丛且丏;
            mem[1152921536949766800] = this;
        }
        else
        {
                mem[16] = this;
            val_20 = 24;
            mem[24] = 一丒丆业丅七丛且丏;
        }
        
        .丈上上丟丟丏万丐且 = 丈上上丟丟丏万丐且;
        if(丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且() != false)
        {
                bool val_4 = 丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  val_1, method:  System.Void coinsShop.三丅丞丒丕丅专一丅::丝七七丘丝三丘丏七()));
            return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        val_21 = mem[24].业东丅东丌上丗丑不();
        if(mem[24].不业丙丒丂丞下丆丙() <= 4)
        {
                var val_19 = 106022040 + (val_6) << 2;
            val_19 = val_19 + 106022040;
        }
        else
        {
                val_26 = "HandlePu_rchaseButton: Unknown purchase type: ";
            val_19 =  + val_21;
            UnityEngine.Debug.LogError(message:  val_19);
        }
    
    }
    private bool 丌丛丒丏万万与丁不(string 丅丞丂丟丟且丅丆丅)
    {
        string val_3;
        var val_4;
        var val_5;
        val_3 = 丅丞丂丟丟且丅丆丅;
        if(val_3 != null)
        {
                val_4 = null;
            val_4 = null;
            if((StoreKitEventListener.丑不且一且丙丟三丅.Contains(item:  val_3)) != false)
        {
                val_3 = "Valid ating of inapp already in progress: "("Valid ating of inapp already in progress: ") + val_3;
            UnityEngine.Debug.LogWarning(message:  val_3);
            val_5 = 0;
            return (bool)val_5;
        }
        
        }
        
        val_5 = 1;
        return (bool)val_5;
    }
    private static bool 上丝东丟专丘丁与丏(string 丅丞丂丟丟且丅丆丅)
    {
        var val_12;
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丞丂丟丟且丅丆丅)) != true) && (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2))
        {
                System.Collections.Generic.List<Prime31.GooglePurchase> val_3 = Prime31.GoogleIAB.getPurchaseHistory();
            if(val_3 == null)
        {
                return (bool)val_12;
        }
        
            if(val_3.Count >= 1)
        {
                var val_12 = 0;
            do
        {
            if(val_3.Item[0] != null)
        {
                if((System.String.op_Equality(a:  val_3.Item[0].productId, b:  丅丞丂丟丟且丅丆丅)) != false)
        {
                if((Prime31.GooglePurchaesFix.getPurchaseState(purchase:  val_3.Item[0])) == 2)
        {
                return (bool)val_12;
        }
        
        }
        
        }
        
            val_12 = val_12 + 1;
        }
        while(val_12 < val_3.Count);
        
        }
        
        }
        
        val_12 = 0;
        return (bool)val_12;
    }
    private void 丞世丕与丗丙三七三(string 丅丞丂丟丟且丅丆丅, System.Collections.Generic.Dictionary<string, object> 丈上上丟丟丏万丐且)
    {
        var val_13;
        var val_14;
        var val_15;
        val_13 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_13.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  38);
        if((coinsShop.上丝东丟专丘丁与丏(丅丞丂丟丟且丅丆丅:  丅丞丂丟丟且丅丆丅)) != true)
        {
                val_13 = 一下丛与丛丛万万丏.丑七不且上丗丁一世();
            val_13.丆世丑丙万七东丏丝(丘专丈与三专丈丈专:  丅丞丂丟丟且丅丆丅, 下丌丐且三下丆丙且:  丈上上丟丟丏万丐且);
        }
        
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  true);
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_14;
        }
        
        com.amazon.device.iap.cpt.SkuInput val_5 = new com.amazon.device.iap.cpt.SkuInput();
        if(val_5 == null)
        {
            goto label_15;
        }
        
        val_5.Sku = 丅丞丂丟丟且丅丆丅;
        goto label_16;
        label_14:
        val_14 = null;
        System.Nullable<System.DateTime> val_6 = coinsShop.丏世丏丆丄东专丐丒();
        coinsShop.丑丝丝丒丞丂丈丗丌 = val_6.HasValue;
        coinsShop.与丒丘丅丙丌七丂丑.__il2cppRuntimeField_30 = 0;
        Prime31.GoogleIAB.purchaseProduct(sku:  丅丞丂丟丟且丅丆丅);
        goto label_21;
        label_15:
        val_5.Sku = 丅丞丂丟丟且丅丆丅;
        label_16:
        val_15 = 0;
        UnityEngine.Debug.Log(message:  "Amazon Purchase (HandlePurchaseButton): "("Amazon Purchase (HandlePurchaseButton): ") + val_5.ToJson());
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = 1;
        com.amazon.device.iap.cpt.RequestOutput val_11 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.Purchase(skuInput:  val_5);
        label_21:
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private static void 业丛一丁丌丏三丗万(string 丘丌丌丙丆下丄东上)
    {
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_2.Add(key:  "af_content_id", value:  丘丌丌丙丆下丄东上);
        Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "af_initiated_checkout", 丛东不丒丏丈丄且丕:  val_2);
    }
    private System.Collections.IEnumerator 专世丙丈丙丗世丕与(string 丅丞丂丟丟且丅丆丅)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new coinsShop.专一丈丝丒丌丅丈丘();
    }
    private void 一七丗丁丈丐且且丐(string 丅丞丂丟丟且丅丆丅)
    {
    
    }
    internal void 下三下丂丈三丗丈东(string 丅丞丂丟丟且丅丆丅)
    {
    
    }
    private System.Collections.IEnumerator 丝万丈万丒丛丑丄丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new coinsShop.丒丒下丅丛丕世丏丏();
    }
    internal static void 丁丝一一丈丘丟丛不()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        coinsShop.专丆专上丗万世丒七.enabled = true;
        val_2 = null;
        val_2 = null;
        coinsPlashka.三丛丙丈丙下丏丌一 = true;
        coinsPlashka.东丐上下一东丌丐专();
    }
    internal static void 丌业不世上丘丙且业()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(coinsShop.专丆专上丗万世丒七 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        coinsShop.专丆专上丗万世丒七.enabled = false;
        UnityEngine.AsyncOperation val_2 = UnityEngine.Resources.UnloadUnusedAssets();
    }
    internal static void 丛丅丂丄丅丕丁且下(bool 丘且三丁丑丅万丕丈)
    {
        coinsShop val_1;
        var val_2;
        var val_3;
        var val_4;
        val_1 = 丘且三丁丑丅万丕丈;
        coinsShop.丌业不世上丘丙且业();
        if(coinsShop.与丄丒与丆丏世丏丙 != false)
        {
                coinsPlashka.专东丁丕下东上丗丟();
        }
        
        val_2 = null;
        val_2 = null;
        coinsPlashka.三丛丙丈丙下丏丌一 = false;
        if(val_1 == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        val_1 = coinsShop.专丆专上丗万世丒七;
        if(null == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        Invoke();
        coinsShop.专丆专上丗万世丒七.下丄丑不丆丕上丌丘 = 0;
        coinsPlashka.专东丁丕下东上丗丟();
    }
    internal static bool 丌丑丐上丙业丌丑丛()
    {
        System.Collections.Generic.IEnumerable<TSource> val_9;
        var val_10;
        System.Func<System.String, System.Boolean> val_12;
        var val_14;
        System.Func<System.String, System.Boolean> val_16;
        System.Collections.Generic.IEnumerable<TSource> val_17;
        if((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11) || (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2))
        {
            goto label_5;
        }
        
        val_9 = "/etc/hosts";
        if((System.IO.File.Exists(path:  "/etc/hosts")) == false)
        {
            goto label_5;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = coinsShop.<>c.<>9__31_0;
        if(val_12 == null)
        {
                val_12 = null;
            val_12 = new System.Func<System.String, System.Boolean>(object:  coinsShop.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean coinsShop.<>c::丁丆丛丕三世万丌且(string 丐三丞七丝丅不万丛));
            coinsShop.<>c.<>9__31_0 = val_12;
        }
        
        val_9 = System.Linq.Enumerable.Where<System.String>(source:  System.IO.File.ReadAllLines(path:  "/etc/hosts"), predicate:  null);
        val_14 = null;
        val_14 = null;
        val_16 = coinsShop.<>c.<>9__31_1;
        if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<System.String, System.Boolean>(object:  coinsShop.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean coinsShop.<>c::丝丛丛一一丙业丘丛(string 丐三丞七丝丅不万丛));
            coinsShop.<>c.<>9__31_1 = val_16;
        }
        
        val_17 = val_9;
        goto label_16;
        label_5:
        val_17 = 0;
        label_16:
        val_17 = val_17 & 1;
        return (bool)val_17;
    }
    internal static bool 丛世丝丂上一且丘丅()
    {
        var val_10;
        System.Func<System.Byte[], System.Boolean> val_12;
        var val_14;
        System.Func<System.Byte[], System.String> val_16;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
                return false;
        }
        
        string[] val_2 = new string[3];
        val_2[0] = "Y29tLmRpbW9udmlkZW8ubHVja3lwYXRjaGVy";
        val_2[1] = "Y29tLmNoZWxwdXMubGFja3lwYXRjaA==";
        val_2[2] = "Y29tLmZvcnBkYS5scA==";
        val_10 = null;
        val_10 = null;
        val_12 = coinsShop.<>c.<>9__32_0;
        if(val_12 == null)
        {
                System.Func<System.Byte[], System.Boolean> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Func<System.Byte[], System.Boolean>(object:  coinsShop.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean coinsShop.<>c::与上丟专丈专与万丟(byte[] 丝丆丁丞丛三丁丑丙));
            coinsShop.<>c.<>9__32_0 = val_12;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = coinsShop.<>c.<>9__32_1;
        if(val_16 != null)
        {
                return System.Linq.Enumerable.Any<System.String>(source:  System.Linq.Enumerable.Select<System.Byte[], System.String>(source:  System.Linq.Enumerable.Where<System.Byte[]>(source:  System.Linq.Enumerable.Select<System.String, System.Byte[]>(source:  val_2, selector:  new System.Func<System.String, System.Byte[]>(object:  0, method:  public static System.Byte[] System.Convert::FromBase64String(string s))), predicate:  val_5), selector:  System.Func<System.Byte[], System.String> val_7 = null), predicate:  new System.Func<System.String, System.Boolean>(object:  0, method:  static System.Boolean coinsShop::三丛专丏丟东丐丒丈(string 丒东丅专丏丐丗下丙)));
        }
        
        val_16 = val_7;
        val_7 = new System.Func<System.Byte[], System.String>(object:  coinsShop.<>c.__il2cppRuntimeField_static_fields, method:  System.String coinsShop.<>c::丏丅丛丄一丈东丆丒(byte[] 丝丆丁丞丛三丁丑丙));
        coinsShop.<>c.<>9__32_1 = val_16;
        return System.Linq.Enumerable.Any<System.String>(source:  System.Linq.Enumerable.Select<System.Byte[], System.String>(source:  System.Linq.Enumerable.Where<System.Byte[]>(source:  System.Linq.Enumerable.Select<System.String, System.Byte[]>(source:  val_2, selector:  new System.Func<System.String, System.Byte[]>(object:  0, method:  public static System.Byte[] System.Convert::FromBase64String(string s))), predicate:  val_5), selector:  val_7), predicate:  new System.Func<System.String, System.Boolean>(object:  0, method:  static System.Boolean coinsShop::三丛专丏丟东丐丒丈(string 丒东丅专丏丐丗下丙)));
    }
    private static bool 三丛专丏丟东丐丒丈(string 丒东丅专丏丐丗下丙)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if(丒东丅专丏丐丗下丙 == null)
        {
            goto label_1;
        }
        
        if(UnityEngine.Application.isEditor == true)
        {
            goto label_45;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        UnityEngine.AndroidJavaObject val_5 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
        if(val_5 == null)
        {
            goto label_7;
        }
        
        object[] val_6 = new object[2];
        val_6[0] = 丒东丅专丏丐丗下丙;
        val_6[1] = 0;
        if((val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_6)) == null)
        {
            goto label_14;
        }
        
        val_13 = 1;
        return (bool)val_13;
        label_6:
        UnityEngine.Debug.LogWarning(message:  "activity == null");
        goto label_45;
        label_7:
        UnityEngine.Debug.LogWarning(message:  "manager == null");
        goto label_45;
        label_14:
        UnityEngine.Debug.LogWarning(message:  "packageInfo == null");
        label_45:
        val_13 = 0;
        return (bool)val_13;
        label_1:
        System.ArgumentNullException val_8 = new System.ArgumentNullException(paramName:  "packageName");
        val_14 = val_8;
        if(0 != 1)
        {
            goto label_31;
        }
        
        if((null & 1) == 0)
        {
            goto label_32;
        }
        
        val_15 = null;
        val_15 = null;
        if(((coinsShop.丈三世丄丟上丏三丑.Contains(item:  val_8)) == true) || (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false))
        {
            goto label_45;
        }
        
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Error while retrieving Android package info:    {0}", arg0:  1152921504617017344));
        val_16 = null;
        val_16 = null;
        bool val_12 = coinsShop.丈三世丄丟上丏三丑.Add(item:  val_8);
        goto label_45;
        label_32:
        mem[8] = null;
        val_14 = 8;
        label_31:
    }
    internal static bool 不丗下丏丄丘丕七丗()
    {
        var val_2 = null;
        if(coinsShop.世丞三丑一丈三世丗() == false)
        {
                return coinsShop.七三丗丏丑丗三丆世();
        }
        
        return false;
    }
    internal static bool 世丞三丑一丈三世丗()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        if(coinsShop.丌丑丐上丙业丌丑丛() == true)
        {
                return true;
        }
        
        val_5 = null;
        if(coinsShop.丛世丝丂上一且丘丅() == true)
        {
                return true;
        }
        
        val_6 = null;
        if(coinsShop.丁丏与七丌丁丘三下() == false)
        {
                return coinsShop.丂专丗一且丆三上与();
        }
        
        return true;
    }
    internal static bool 世丒丏上丘丁与丟丁()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 111018;
        val_7 = null;
        val_7 = null;
        if((coinsShop.丛丏丆丗万东丐七丕 & 2147483648) != 0)
        {
            goto label_3;
        }
        
        val_6 = 0;
        val_8 = null;
        val_5 = UnityEngine.Time.frameCount;
        val_8 = null;
        int val_5 = coinsShop.丛丏丆丗万东丐七丕;
        val_5 = val_5 - val_5;
        if(val_5 < 30)
        {
            goto label_6;
        }
        
        label_3:
        coinsShop.丆丆世丆一丝万丑丟 = coinsShop.世丞三丑一丈三世丗();
        val_9 = null;
        coinsShop.丛丏丆丗万东丐七丕 = UnityEngine.Time.frameCount;
        label_6:
        val_9 = null;
        return (bool)coinsShop.丆丆世丆一丝万丑丟;
    }
    private static bool 丂专丗一且丆三上与()
    {
        null = null;
        return (bool)coinsShop.<丌丘丁丆丘丒丁一丞>k__BackingField;
    }
    internal static void 业丄丘丘丛丆丒丝丁(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        coinsShop.<丌丘丁丆丘丒丁一丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private static string 上一上丆万丏丘丞万(string 丏丛与丅丛丌万专丌)
    {
        if((System.Convert.FromBase64String(s:  丏丛与丅丛丌万专丌)) == null)
        {
            goto label_3;
        }
        
        label_6:
        System.Text.Encoding.UTF8 = ???;
        goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
        label_3:
        if(System.Text.Encoding.UTF8 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
    }
    private static bool 丁丏与七丌丁丘三下()
    {
        string val_22;
        object val_23;
        var val_24;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
            goto label_40;
        }
        
        val_23 = 1152921505164300288;
        val_22 = coinsShop.上一上丆万丏丘丞万(丏丛与丅丛丌万专丌:  "L0xpYnJhcnkvTW9iaWxlU3Vic3RyYXRlL0R5bmFtaWNMaWJyYXJpZXM=");
        if((System.IO.File.Exists(path:  System.IO.Path.Combine(path1:  val_22, path2:  coinsShop.上一上丆万丏丘丞万(丏丛与丅丛丌万专丌:  "TG9jYWxJQVBTdG9yZS5keWxpYg==")))) != true)
        {
                if((System.IO.File.Exists(path:  System.IO.Path.Combine(path1:  val_22, path2:  coinsShop.上一上丆万丏丘丞万(丏丛与丅丛丌万专丌:  "TG9jYWxsQVBTdG9yZS5keWxpYg==")))) == false)
        {
            goto label_11;
        }
        
        }
        
        object[] val_9 = new object[1];
        val_22 = val_9;
        val_22[0] = "IsBangerrySupported";
        UnityEngine.Debug.LogWarningFormat(format:  "{0}: `cetrer`", args:  val_9);
        label_47:
        val_24 = 1;
        return (bool)val_24;
        label_11:
        if((System.IO.File.Exists(path:  System.IO.Path.Combine(path1:  val_22, path2:  coinsShop.上一上丆万丏丘丞万(丏丛与丅丛丌万专丌:  "aWFwLmR5bGli")))) == false)
        {
            goto label_23;
        }
        
        object[] val_13 = new object[1];
        val_13[0] = "IsBangerrySupported";
        UnityEngine.Debug.LogWarningFormat(format:  "{0}: `panemer`", args:  val_13);
        goto label_47;
        label_23:
        if((System.IO.File.Exists(path:  System.IO.Path.Combine(path1:  val_22, path2:  coinsShop.上一上丆万丏丘丞万(丏丛与丅丛丌万专丌:  "aWFwZnJlZS5jb3JlLmR5bGli")))) != true)
        {
                if((System.IO.File.Exists(path:  System.IO.Path.Combine(path1:  val_22, path2:  coinsShop.上一上丆万丏丘丞万(丏丛与丅丛丌万专丌:  "SUFQRnJlZVNlcnZpY2UuZHlsaWI=")))) == false)
        {
            goto label_40;
        }
        
        }
        
        object[] val_20 = new object[1];
        val_20[0] = "IsBangerrySupported";
        UnityEngine.Debug.LogWarningFormat(format:  "{0}: `rastat`", args:  val_20);
        goto label_47;
        label_40:
        val_24 = 0;
        return (bool)val_24;
    }
    private static System.Nullable<System.DateTime> 丏世丏丆丄东专丐丒()
    {
        UnityEngine.Debug.Log(message:  "Trying to get /ets/hosts timestamp...");
        new System.IO.FileInfo() = new System.IO.FileInfo(fileName:  "/etc/hosts");
        System.DateTime val_2 = new System.IO.FileInfo().LastWriteTimeUtc;
        UnityEngine.Debug.Log(message:  "/ets/hosts timestamp: "("/ets/hosts timestamp: ") + val_2.dateData);
        return 0;
    }
    internal static bool 丘业上丙丘丑丆丝业()
    {
        var val_4;
        ulong val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        val_5 = 1152921516340667232;
        if((1152921505164304424 & 1) != 0)
        {
                val_6 = null;
            System.Nullable<System.DateTime> val_1 = coinsShop.丏世丏丆丄东专丐丒();
            if(((-2013389328) & 1) != 0)
        {
                val_7 = null;
            val_7 = null;
            val_5 = 1152921505164304424;
            if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_5}, d2:  new System.DateTime() {})) != false)
        {
                val_8 = null;
            val_8 = null;
            val_5 = System.String.Format(format:  "Timestamp check failed: {0:s} expcted, but actual value is {1:s}.", arg0:  1152921505164304424, arg1:  val_1.HasValue);
            UnityEngine.Debug.LogError(message:  val_5);
            val_9 = 0;
            return (bool)val_9;
        }
        
        }
        
        }
        
        val_9 = 1;
        return (bool)val_9;
    }
    internal static bool 丏丅世七丞与丛丘业()
    {
        if(UnityEngine.Application.isEditor == true)
        {
                return true;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
                return true;
        }
        
        return StoreKitEventListener.丂丗丆丗丛丞业丌三();
    }
    internal static bool 七三丗丏丑丗三丆世()
    {
        var val_7;
        coinsShop val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        val_8 = coinsShop.专丆专上丗万世丒七;
        if(val_8 == 0)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = coinsShop.专丆专上丗万世丒七;
        if(coinsShop.专丆专上丗万世丒七.业丌丕丂世业下丝丐 == false)
        {
                return false;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
                return coinsShop.丏丅世七丞与丛丘业();
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = StoreKitEventListener.丆丕丝丒不丙且丐丗;
        if(val_8 == 0)
        {
                return false;
        }
        
        val_11 = null;
        val_11 = null;
        var val_6 = ((System.Linq.Enumerable.Count<Rilisoft.与丗丌丑专业丝丛丏>(source:  StoreKitEventListener.丆丕丝丒不丙且丐丗.世丝世业丙丙丄一一())) > 0) ? 1 : 0;
        return false;
    }
    private System.Collections.IEnumerator 丗下与不丑业丝且不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new coinsShop.丘下丕丆丝东丁万七();
    }
    internal void 与不丌丗上不且专丗(string 丑丞东万丁丂丏万丙, bool 七丆丟丗世丟且丒丆 = False)
    {
        string val_6 = 丑丞东万丁丂丏万丙;
        if(val_6 == null)
        {
                val_6 = System.String.alignConst;
        }
        
        string val_3 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0} > RefreshProin_ternalductsIfNeed(), products_interna_Received: {1}, force: {2}", arg0:  val_6, arg1:  this.业丌丕丂世业下丝丐, arg2:  七丆丟丗世丟且丒丆);
        bool val_5 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        if(this.业丌丕丂世业下丝丐 != false)
        {
                if(七丆丟丗世丟且丒丆 == false)
        {
                return;
        }
        
        }
        
        StoreKitEventListener.丞七丂业丒且丁东与();
    }
    private void 丑且与七丕丑丂丂七(bool 丁与丟万丄丒丗专丌)
    {
        System.Object[] val_7;
        var val_8;
        var val_9;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_3 = new object[2];
            val_7 = val_3;
            val_7[0] = 丁与丟万丄丒丗专丌;
            val_8 = null;
            val_7[1] = coinsShop.丏丅世七丞与丛丘业();
            UnityEngine.Debug.LogFormat(format:  "coinsShop.HandleAppli_cationPause(), pause: {0}, IsBillingSupported: {1}", args:  val_3);
        }
        
        if(丁与丟万丄丒丗专丌 == true)
        {
                return;
        }
        
        val_9 = null;
        if(coinsShop.丏丅世七丞与丛丘业() != false)
        {
                this.与不丌丗上不且专丗(丑丞东万丁丂丏万丙:  "coinsShop.HandleAppli_cationPause()", 七丆丟丗世丟且丒丆:  false);
            return;
        }
        
        StoreKitEventListener.丞七丕丏丙丐业与世();
    }
    public coinsShop()
    {
        this.上丏三下专万专东与 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
    }
    private static coinsShop()
    {
        coinsShop.与丄丒与丆丏世丏丙 = false;
        coinsShop.丈三世丄丟上丏三丑 = new System.Collections.Generic.HashSet<System.String>();
        coinsShop.丛丏丆丗万东丐七丕 = 0;
    }

}
