using UnityEngine;
public sealed class StoreKitEventListener : MonoBehaviour
{
    // Fields
    private const string 七专丕上东丝丈丌丏 = "Amazon.FulfilledReceipts";
    private readonly System.Threading.Tasks.TaskCompletionSource<com.amazon.device.iap.cpt.AmazonUserData> 丗一丕丘丅丛万万且;
    private System.Collections.Generic.HashSet<System.ValueTuple<com.amazon.device.iap.cpt.PurchaseReceipt, string>> 东万丏丕且丕下丕丁;
    private static bool <上丅上万不丞东丗不>k__BackingField;
    internal static string[] 丒丁丐丙丐丈丕专世;
    internal readonly System.Collections.Generic.ICollection<Rilisoft.与丗丌丑专业丝丛丏> 下丌丂丘丕丕专下丁;
    internal readonly System.Collections.Generic.ICollection<Prime31.GoogleSkuInfo> 丞万七且一与丁丑与;
    internal const string 丂世下一丒下万丌丘 = "coin1";
    internal const string 不与三上丐世东丘丕 = "coin2";
    internal const string 丒三下三丐上东一丆 = "coin3.";
    internal const string 丅七丅丈七丄丞丐丛 = "coin4";
    internal const string 丙丁丂丝丟下万丙丞 = "coin5";
    internal const string 丑丗丙东丗丁不七丏 = "coin7";
    internal const string 专丞三东丕且丌丗丝 = "coin8";
    internal static readonly string[] 业丝丐三上丈丛丂专;
    private static string[] 丘世与丄一丐丝下丛;
    private readonly System.Collections.Generic.HashSet<Prime31.GooglePurchase> 丁丗丙三丆丄万上丛;
    private readonly System.Collections.Generic.HashSet<Prime31.GooglePurchase> 与专丒丑丞丐丄上丄;
    private System.IDisposable 丙七专七丆丌丄丏丘;
    internal static System.Collections.Generic.List<string> 丑不且一且丙丟三丅;
    private bool 丙丒丁七下上专丅丈;
    private System.Collections.Generic.HashSet<Prime31.GooglePurchase> 丆东丆业丄东三丕下;
    private static readonly System.Collections.Generic.List<string> 丙丑上丗丝东业业丏;
    private const string 上丏丌上下丙丘东丁 = "Android.GooglePlayOrderIdsKey";
    private readonly Rilisoft.七丞丞丅东丞专丙丝<System.Security.Cryptography.SHA1Managed> 丏丛丌丈专东丞丘丁;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<System.Security.Cryptography.RSACryptoServiceProvider> 业一丟丏丞丏丑三丐;
    private static float 丅丏世世丘且不丗丟;
    private static string 且丒专且丈一下丗上;
    private static System.Action 不丑丙万丂丙丕丆丆;
    private static System.Action<string> 专东丌下与丏丛丁丌;
    internal static StoreKitEventListener 丆丕丝丒不丙且丐丗;
    private static string 丆丈三丂东丘三丁丝;
    private static string 不丙丄丅丄业丝丞丂;
    private static string 丟丟不丗丅万专丐丁;
    private static string 丑丄丑丑丐与丙且且;
    private static string 与丝丕丐东丂丗东不;
    private static string 丆丕丞丛丑世世丈万;
    private static string 丐业万丙丑丝丏丁丟;
    private static string 丑丛丞丙丗丂丘丒上;
    private static string 丙丄丟丘丞丄专丝丕;
    private static string 丑丞丞丅丁丈业丝丄;
    private static string 丑七丈丂丗丅丄三丂;
    private static string 丐丌丙丁丈丅业丒丝;
    private static string 东丄丑专万下丘丗与;
    private static string 上丕世世丙东万且不;
    internal static readonly int[] 丝不东丅丅丂三且丑;
    internal static readonly string[] 丒丕丗丑丕且丌丁丂;
    internal static readonly string[] 业万专三一丟且丘业;
    internal static readonly string[] 下丕丄东与丙三丂丒;
    internal static readonly string[] 丗丛丟丘下丙丞业丑;
    internal static readonly System.Collections.Generic.Dictionary<string, string> 丌丕丕丝不与丒丛丈;
    internal static string 丐丌丒丂丁世与与丕;
    private static System.Action<bool> 专与专丁与丅丂万丏;
    internal static bool 丕丕万世七丕专与丑;
    internal static bool 丌丗丆丟丈丆丝丝丄;
    internal const string 丂上丛不丕业丕东不 = "bigammopack";
    internal const string 丂丆丌东丄世三三丐 = "crystalsword";
    internal const string 丌丈世丄丘七丗丄丐 = "Fullhealth";
    internal const string 丙丁与万丌丕丘下丌 = "MinerWeapon";
    internal static readonly string[] 万一万专丛专丏丂丌;
    internal static readonly string[] 丒丝丝丒丗丙一且七;
    public UnityEngine.GameObject messagePrefab;
    internal static string[] 丈丁丐丌三丟与一丕;
    public UnityEngine.AudioClip onEarnCoinsSound;
    public UnityEngine.AudioClip onEarnGemsSound;
    private static readonly StoreKitEventListener.专丑丟专与三丕丗丁 丝丙丌且专丅东丞业;
    internal const float 丞下丈丁丛丏上丛丂 = 12;
    
    // Properties
    internal System.Threading.Tasks.Task<com.amazon.device.iap.cpt.AmazonUserData> 丕丗丌不下丘下丘丐 { get; }
    internal static bool 丄丄专丑业丅丄丂丛 { get; set; }
    internal System.Collections.Generic.ICollection<Rilisoft.与丗丌丑专业丝丛丏> 万丕三丂丈丏万丌丐 { get; }
    internal static bool 下且丌丏丑丁丗专丈 { get; }
    internal static string 丒丞丁专丑丝丂一与 { get; set; }
    private static bool 丈丘不丏丅丒东丕世 { get; }
    private static string 丅上丕丆三丛三万世 { get; }
    internal static bool 丕不世丄丞一三丒丕 { get; set; }
    internal static string 下丞丒万世丟丞丕丏 { get; }
    internal static StoreKitEventListener.专丑丟专与三丕丗丁 丙丟与丐三丐万万丆 { get; }
    
    // Methods
    internal System.Threading.Tasks.Task<com.amazon.device.iap.cpt.AmazonUserData> 与丟丂丗丐三丗丛丞()
    {
        if(this.丗一丕丘丅丛万万且 != null)
        {
                return this.丗一丕丘丅丛万万且.Task;
        }
        
        return this.丗一丕丘丅丛万万且.Task;
    }
    private void 丙丄丂丄丌与上丄三(bool 丏丈且一不丈丗业三)
    {
        UnityEngine.Debug.Log(message:  "Amazon SDK available in sandbox mode: "("Amazon SDK available in sandbox mode: ") + 丏丈且一不丈丗业三.ToString());
        StoreKitEventListener.世世丅一丈丒一丅丟(丙业与丙丗丝不丈东:  true);
        StoreKitEventListener.丞七丂业丒且丁东与();
    }
    private void 下丂丌不东丝三丟丝(com.amazon.device.iap.cpt.GetUserDataResponse 丑与丂丌世丕丆一丗)
    {
        var val_9;
        string val_2 = "Amazon GetUserD_ataResponse: "("Amazon GetUserD_ataResponse: ") + 丑与丂丌世丕丆一丗.Status;
        val_9 = "SUCCESSFUL";
        if("SUCCESSFUL" == null)
        {
                val_9 = "SUCCESSFUL";
        }
        
        if((Equals(value:  丑与丂丌世丕丆一丗.Status, comparisonType:  5)) != false)
        {
                UnityEngine.Debug.Log(message:  val_2);
            bool val_6 = this.丗一丕丘丅丛万万且.TrySetResult(result:  丑与丂丌世丕丆一丗.AmazonUserData);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  val_2);
        bool val_8 = this.丗一丕丘丅丛万万且.TrySetException(exception:  new System.InvalidOperationException(message:  val_2));
    }
    private void 丂丛七丐丑丟丙不且(com.amazon.device.iap.cpt.GetProductDataResponse 丑与丂丌世丕丆一丗)
    {
        var val_37;
        var val_38;
        var val_40;
        var val_42;
        var val_46;
        var val_48;
        var val_49;
        var val_51;
        com.amazon.device.iap.cpt.ResetInput val_52;
        var val_53;
        string val_2 = "Amazon: GetProduct_DataResponse: "("Amazon: GetProduct_DataResponse: ") + 丑与丂丌世丕丆一丗.Status;
        val_37 = "SUCCESSFUL";
        if("SUCCESSFUL" == null)
        {
                val_37 = "SUCCESSFUL";
        }
        
        val_38 = 1152921504833470464;
        if((Equals(value:  丑与丂丌世丕丆一丗.Status, comparisonType:  5)) != false)
        {
                UnityEngine.Debug.Log(message:  val_2);
            var val_42 = 0;
            val_42 = val_42 + 1;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  val_2);
            return;
        }
        
        this.下丌丂丘丕丕专下丁.Clear();
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Item data request finished;    Unavailable skus: {0}, Available skus: {1}", arg0:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丑与丂丌世丕丆一丗.UnavailableSkus), arg1:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  丑与丂丌世丕丆一丗.ProductDataMap.Keys))));
        System.Func<com.amazon.device.iap.cpt.ProductData, Rilisoft.一且世丞上丝东丆丆> val_15 = new System.Func<com.amazon.device.iap.cpt.ProductData, Rilisoft.一且世丞上丝东丆丆>(object:  0, method:  static Rilisoft.一且世丞上丝东丆丆 Rilisoft.世东业下万不丕上丙::丛丝丐丐上丑丏万丅(com.amazon.device.iap.cpt.ProductData 东下丄丄上丞专丐不));
        val_40 = public static System.Collections.Generic.IEnumerable<TResult> System.Linq.Enumerable::Select<com.amazon.device.iap.cpt.ProductData, Rilisoft.一且世丞上丝东丆丆>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector);
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_40 = 0;
        System.Collections.Generic.IEnumerator<T> val_18 = System.Linq.Enumerable.Select<com.amazon.device.iap.cpt.ProductData, Rilisoft.一且世丞上丝东丆丆>(source:  丑与丂丌世丕丆一丗.ProductDataMap.Values, selector:  null).GetEnumerator();
        val_42 = 1152921504686346240;
        label_48:
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_40 = 0;
        if(val_18.MoveNext() == false)
        {
            goto label_31;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        val_40 = 0;
        T val_22 = val_18.Current;
        var val_46 = 0;
        val_46 = val_46 + 1;
        val_40 = 4;
        val_46 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
        if((this.下丌丂丘丕丕专下丁.Contains(item:  ???)) == true)
        {
            goto label_48;
        }
        
        var val_47 = 0;
        val_47 = val_47 + 1;
        val_46 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        goto label_48;
        label_31:
        val_48 = 0;
        val_49 = 0;
        if(val_18 == null)
        {
            
        }
        else
        {
                var val_48 = 0;
            val_48 = val_48 + 1;
            val_18.Dispose();
        }
        
        if( == 1)
        {
                if( != false)
        {
                val_49 = 0;
        }
        
            val_51 = 0;
            val_48 = 0;
        }
        else
        {
                val_51 = ;
        }
        
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[Rilisoft] Amazon: calling GetPurcha_seUpdates()");
        }
        
        com.amazon.device.iap.cpt.ResetInput val_29 = null;
        val_52 = val_29;
        val_29 = new com.amazon.device.iap.cpt.ResetInput();
        val_53 = 0;
        val_29.Reset = true;
        var val_49 = 0;
        val_49 = val_49 + 1;
        val_53 = 3;
        com.amazon.device.iap.cpt.RequestOutput val_31 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.GetPurchaseUpdates(resetInput:  val_29);
        if( != 1)
        {
                return;
        }
        
        if(val_51 == false)
        {
                return;
        }
        
        val_49 = ???;
        val_52 = ???;
        val_38 = ???;
        val_42 = ???;
    }
    private void 且七丅上丝世七丘上()
    {
        UnityEngine.Debug.LogWarning(message:  "Amamzon: Item data request failed.");
    }
    private void 丐丗业丑丝丛与丏丝(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与)
    {
        string val_33;
        var val_34;
        string val_35;
        var val_36;
        int val_37;
        var val_38;
        var val_39;
        var val_40;
        val_33 = "";
        val_34 = 65536;
        val_34 = 1;
        InappRememberedBonus val_2 = 一下丛与丛丛万万丏.专丟丙下丌丆七丄专(丅丞丂丟丟且丅丆丅:  丛丌丗丄三丞业与与.Sku);
        if(val_2 != null)
        {
                bool val_3 = PGCompany.丌与丛丕业丈不丐世.丒丛丐丐丑丈世专丑(丄上专丄七丘丕万东:  val_2);
            丛丑丙丗下专东丝三 val_4 = 一下丛与丛丛万万丏.丘一丛丑丈丁丑丅三(丂丈丗丄不丅丅丙丒:  val_2);
            string val_5 = StoreKitEventListener.且业丒丂下业丐丝世(不丌一丄东丝丏且丗:  val_4.丗业丛业丂丆丕丈一, 丂丈丗丄不丅丅丙丒:  val_2);
            val_34 = val_4.丗业丛业丂丆丕丈一;
            val_33 = StoreKitEventListener.丟东不丁万万丒丂丌(丂丈丗丄不丅丅丙丒:  val_2);
        }
        
        val_35 = "";
        val_36 = null;
        val_36 = null;
        int val_8 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丛丌丗丄三丞业与与.Sku);
        if(val_8 < (StoreKitEventListener.业丝丐三上丈丛丂专.GetLowerBound(dimension:  0)))
        {
                val_37 = 0;
        }
        else
        {
                val_35 = "coins";
            val_37 = UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.业万业下世丙丕上丏(丈一三丂七丆丛且且:  val_8, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_33)) != false)
        {
                int val_16 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  247, 世丈三丐丞一丒丛不:  AbstractBankView.丁且丘丅丌丛下一丆(丞丂业丅丟丙丏七丗:  71, 丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku));
            if(val_16 >= 1)
        {
                val_33 = System.String.Format(format:  "x{0}", arg0:  val_16);
        }
        
        }
        
            val_38 = null;
            val_38 = null;
            Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  val_37, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丅丅丞丙丁丕丌世东:  1);
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            StoreKitEventListener.丘万万丅丘丟丛丈业(丅丞丂丟丟且丅丆丅:  丛丌丗丄三丞业与与.Sku, 世丕丅与丆丄丗丐万:  0, 丑丁丐丏业丗一丏丈:  val_37);
        }
        
        val_39 = null;
        val_39 = null;
        int val_20 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丛丌丗丄三丞业与与.Sku);
        if(val_20 >= (StoreKitEventListener.丒丕丗丑丕且丌丁丂.GetLowerBound(dimension:  0)))
        {
                val_35 = "gems";
            val_37 = UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.丆一丟丘丒丐丙一丘(丈一三丂七丆丛且且:  val_20, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_33)) != false)
        {
                int val_28 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  223, 世丈三丐丞一丒丛不:  AbstractBankView.丁且丘丅丌丛下一丆(丞丂业丅丟丙丏七丗:  47, 丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku));
            if(val_28 >= 1)
        {
                val_33 = System.String.Format(format:  "x{0}", arg0:  val_28);
        }
        
        }
        
            val_40 = null;
            val_40 = null;
            Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  val_37, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丅丅丞丙丁丕丌世东:  1);
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
            StoreKitEventListener.丘万万丅丘丟丛丈业(丅丞丂丟丟且丅丆丅:  丛丌丗丄三丞业与与.Sku, 世丕丅与丆丄丗丐万:  val_37, 丑丁丐丏业丗一丏丈:  0);
        }
        
        StoreKitEventListener.一丕丌丗丝丗且且下(丅丞丂丟丟且丅丆丅:  丛丌丗丄三丞业与与.Sku);
        业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
        StoreKitEventListener.丑世丄丄下三丏丑七(丛丌丗丄三丞业与与:  丛丌丗丄三丞业与与, 丐丌三一且丒且丘东:  new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = 159}, 丗专丂上下上丙专业:  val_35, 丂业丛丕专丏丁丆东:  val_37, 丆万一不丌且东丐丐:  val_33, 丂业丕业丂丅丙一丛:  val_33, 丂丈丗丄不丅丅丙丒:  val_2);
    }
    private static void 丑世丄丄下三丏丑七(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与, 一下丛与丛丛万万丏.丛丑丙丗下专东丝三 丐丌三一且丒且丘东, string 丗专丂上下上丙专业, int 丂业丛丕专丏丁丆东, string 丆万一不丌且东丐丐 = "", string 丂业丕业丂丅丙一丛 = "", InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        int val_25;
        string val_26;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  38);
        Rilisoft.丝丄三业丙专丛与不.丘丄丁丄下丕东丏丈(丘丛丛丘丂丙且与丛:  System.String.alignConst, 丕丆且丏业一三世丅:  0f, 丛丅丗世丗不丈下万:  Rilisoft.一丟专且三万丞丁丂.世丞丄下丌业丐丝三(万七上丁丄丘业丁丂:  丛丌丗丄三丞业与与.Sku), 七丒丐世世丘七丘丙:  System.String.alignConst);
        val_25 = System.String.alignConst;
        if((丐丌三一且丒且丘东.丗业丛业丂丆丕丈一 != 1) && (丐丌三一且丒且丘东.丗业丛业丂丆丕丈一 != 99999))
        {
                val_25 = 丂业丕业丂丅丙一丛 + 一下丛与丛丛万万丏.三万丑不上丏上丁上(丐丌三一且丒且丘东:  new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = 丐丌三一且丒且丘东.丗业丛业丂丆丕丈一, 丙丁丑丙丆丐丂业丈 = 丐丌三一且丒且丘东.丙丁丑丙丆丐丂业丈})(一下丛与丛丛万万丏.三万丑不上丏上丁上(丐丌三一且丒且丘东:  new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = 丐丌三一且丒且丘东.丗业丛业丂丆丕丈一, 丙丁丑丙丆丐丂业丈 = 丐丌三一且丒且丘东.丙丁丑丙丆丐丂业丈}));
        }
        
        if((丂丈丗丄不丅丅丙丒 != null) && (丂丈丗丄不丅丅丙丒.Multiplier >= 1))
        {
                val_25 = System.String.Format(format:  "x{0}_", arg0:  丂丈丗丄不丅丅丙丒.Multiplier);
        }
        
        val_26 = val_25 + 丛丌丗丄三丞业与与.Sku + 丆万一不丌且东丐丐;
        if((System.String.op_Equality(a:  丂业丕业丂丅丙一丛, b:  "x3_")) != false)
        {
                if((val_26.IndexOf(value:  "x3_", comparisonType:  4)) != 0)
        {
                val_26 = 丂业丕业丂丅丙一丛 + val_26;
        }
        
        }
        
        if(val_26.Length >= 50)
        {
                val_26 = val_26.Substring(startIndex:  0, length:  49);
        }
        
        bool val_25 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  38);
        val_25 = val_25 ^ 1;
        PGCompany.Analytics.一业丗丆世世上丁且.下万丌丐世丘下丑且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku, 万丂且丕三丛一专与:  val_26, 万世丛丄丘丙丂万丟:  0f, 专丄丒丘丅七丂丟丙:  System.String.alignConst, 万丅丏丈七丂丛一上:  val_25, 丂丈丗丄不丅丅丙丒:  丂丈丗丄不丅丅丙丒, 专丝东丕丝丈三丗丂:  丗专丂上下上丙专业, 丂业丛丕专丏丁丆东:  丂业丛丕专丏丁丆东, 业丘丛专丗丛万专业:  丛丌丗丄三丞业与与.ReceiptId);
        System.DateTime val_21 = System.DateTime.UtcNow;
        decimal val_24 = System.Decimal.op_Implicit(value:  StoreKitEventListener.丁且丘丅丌丛下一丆(丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku));
        PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_21.dateData}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid});
    }
    private void 丛丕七专东丟专丟丄(com.amazon.device.iap.cpt.PurchaseResponse 丑与丂丌世丕丆一丗)
    {
        var val_21;
        string val_22;
        string val_23;
        var val_24;
        var val_25;
        val_21 = this;
        string val_2 = "Amazon PurchaseResponse (StoreKitEventListener): "("Amazon PurchaseResponse (StoreKitEventListener): ") + 丑与丂丌世丕丆一丗.Status;
        val_22 = "SUCCESSFUL";
        val_23 = 丑与丂丌世丕丆一丗.Status;
        val_24 = "SUCCESSFUL";
        if("SUCCESSFUL" == null)
        {
                val_24 = "SUCCESSFUL";
        }
        
        if((Equals(value:  val_23, comparisonType:  5)) == false)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  val_2);
        com.amazon.device.iap.cpt.PurchaseReceipt val_5 = 丑与丂丌世丕丆一丗.PurchaseReceipt;
        UnityEngine.Debug.Log(message:  "Amazon PurchaseResponse.Purchase_Receipt: "("Amazon PurchaseResponse.Purchase_Receipt: ") + val_5.ToJson());
        val_23 = "";
        if(丑与丂丌世丕丆一丗.AmazonUserData != null)
        {
                if((System.String.IsNullOrEmpty(value:  丑与丂丌世丕丆一丗.AmazonUserData.UserId)) != true)
        {
                val_23 = 丑与丂丌世丕丆一丗.AmazonUserData.UserId;
        }
        
        }
        
        val_25 = null;
        val_25 = null;
        val_22 = val_5.ReceiptId;
        if((StoreKitEventListener.丙丑上丗丝东业业丏.Contains(item:  val_22)) == true)
        {
                return;
        }
        
        if(CoroutineRunner.Instance == 0)
        {
            goto label_25;
        }
        
        UnityEngine.Coroutine val_20 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丈上丒下一上丄东丕(丛上丌丂业七不三世:  0, 丛丌丗丄三丞业与与:  val_5, 万一下七丈丈丗世丐:  val_23));
        return;
        label_4:
        UnityEngine.Debug.LogWarning(message:  val_2);
        val_21 = 1152921505272713216;
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        return;
        label_25:
        UnityEngine.Debug.LogError(message:  "Amazon NotifyFulfillment2 CoroutineRunner.Instance == null ");
        this.丗丂丝丏丙三与丑丅(丛丌丗丄三丞业与与:  val_5, 万丄丅丝三丈丆世丟:  val_23);
    }
    private static com.amazon.device.iap.cpt.NotifyFulfillmentInput 丌丒丝丄丂丄不丛上(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与)
    {
        com.amazon.device.iap.cpt.NotifyFulfillmentInput val_1 = new com.amazon.device.iap.cpt.NotifyFulfillmentInput();
        string val_2 = 丛丌丗丄三丞业与与.ReceiptId;
        if(val_1 != null)
        {
                val_1.ReceiptId = val_2;
        }
        else
        {
                val_1.ReceiptId = val_2;
        }
        
        val_1.FulfillmentResult = "FULFILLED";
        return val_1;
    }
    private void 丗丂丝丏丙三与丑丅(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与, string 万丄丅丝三丈丆世丟)
    {
        MoonSharp.Interpreter.DynValue val_18;
        var val_19;
        int val_20;
        var val_21;
        val_18 = 万丄丅丝三丈丆世丟;
        MoonSharp.Interpreter.TablePair val_1 = new MoonSharp.Interpreter.TablePair(key:  丛丌丗丄三丞业与与, val:  val_18);
        bool val_2 = this.东万丏丕且丕下丕丁.Add(item:  new System.ValueTuple<com.amazon.device.iap.cpt.PurchaseReceipt, System.String>() {Item2 = val_1.key});
        if(this.丙丒丁七下上专丅丈 == true)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.三丑丁丂丏丝不业东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void StoreKitEventListener::丝不丆丝丌丒万丄丗(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        string val_4 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_20 = System.String.alignConst;
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七()) != null)
        {
                if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七().Handshake) != null)
        {
                val_20 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七().Handshake.Sid;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_14 = null;
        val_18 = val_14;
        val_14 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if(val_18 != null)
        {
                val_14.Add(key:  "uid", value:  val_4);
        }
        else
        {
                val_14.Add(key:  "uid", value:  val_4);
        }
        
        val_14.Add(key:  "sid", value:  val_20);
        if((System.String.IsNullOrEmpty(value:  val_20)) != false)
        {
                val_14.Add(key:  "response_fail", value:  1);
        }
        
        UnityEngine.Debug.Log(message:  "[InAppSocket] CheckSocketAuthAndProvideAmazonInapp");
        val_21 = null;
        val_21 = null;
        int val_17 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.三丑丁丂丏丝不业东, 一丐丗丁丞丆丅丟丄:  val_14);
        this.丙丒丁七下上专丅丈 = true;
    }
    private void 业丈丈不上丗一专世(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与, string 万丄丅丝三丈丆世丟)
    {
        StoreKitEventListener.丌丟丘丏丕丅七万丕 val_1 = new StoreKitEventListener.丌丟丘丏丕丅七万丕();
        .丛丌丗丄三丞业与与 = 丛丌丗丄三丞业与与;
        string[] val_2 = new string[2];
        string val_3 = (StoreKitEventListener.丌丟丘丏丕丅七万丕)[1152921539315489632].丛丌丗丄三丞业与与.ReceiptId;
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_3;
        val_2[1] = 万丄丅丝三丈丆世丟;
        .丂业丄世世丂不丞丅 = Progress.上七丆与丐三丐丝万.且丝三万七且下世且(丁丆丆丛丟丕丐专丘:  val_2);
        if((Progress.七七世万专丕丁上业.丙七且丕丟丐丙世丈().丟不下下且业丛丄丏(下七丈下丕七丘丑丄:  (StoreKitEventListener.丌丟丘丏丕丅七万丕)[1152921539315489632].丂业丄世世丂不丞丅)) != false)
        {
                StoreKitEventListener.丄丄丅丅丅丟丁丑且(丛丌丗丄三丞业与与:  (StoreKitEventListener.丌丟丘丏丕丅七万丕)[1152921539315489632].丛丌丗丄三丞业与与, 丝丏丛世丞一丞丐丒:  true);
            return;
        }
        
        .业丘丛专丗丛万专业 = (StoreKitEventListener.丌丟丘丏丕丅七万丕)[1152921539315489632].丂业丄世世丂不丞丅;
        .下三丐丙下丛东专丞 = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  val_1, method:  System.Void StoreKitEventListener.丌丟丘丏丕丅七万丕::丂丅三丒东世且丐业(System.Collections.Generic.Dictionary<string, object> 上丌丛不业与世丑丏));
        .丐丒丙业丕丞一一丄 = new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丌丟丘丏丕丅七万丕::上世三丌丑丞丆丝丗());
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丛丌专丐丛丆丑上(东丞丒丙世丏三下丟:  new Progress.丙丆丞丆一丏一丁业());
    }
    private static void 丒丅丑一丄一丝丆丒(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与, string 下七丈下丕七丘丑丄)
    {
        StoreKitEventListener.丕丛业丁丏下一七丘 val_1 = new StoreKitEventListener.丕丛业丁丏下一七丘();
        .丛丌丗丄三丞业与与 = 丛丌丗丄三丞业与与;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  176);
        uint val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丕丞与丒丒丝世不(业丏丈世世世丞丒世:  new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丕丛业丁丏下一七丘::丑丅不丏丝一万不专()), 丁丒丗与丝世丁与且:  2, 丞丐丟三丌与丞上一:  9);
        uint val_8 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丕丞与丒丒丝世不(业丏丈世世世丞丒世:  new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丕丛业丁丏下一七丘::一丗万专世专丕丞一()), 丁丒丗与丝世丁与且:  1, 丞丐丟三丌与丞上一:  0);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞七三世丙世万丑丐(丂业丄世世丂不丞丅:  下七丈下丕七丘丑丄, 丆丟与东业三业丅丏:  (StoreKitEventListener.丕丛业丁丏下一七丘)[1152921539315718384].丛丌丗丄三丞业与与.Sku, 一丐丗丁丞丆丅丟丄:  "");
        StoreKitEventListener.丙一丑丗且世丕丁下(丛丌丗丄三丞业与与:  (StoreKitEventListener.丕丛业丁丏下一七丘)[1152921539315718384].丛丌丗丄三丞业与与);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private static void 丄丄丅丅丅丟丁丑且(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与, bool 丝丏丛世丞一丞丐丒 = True)
    {
        var val_2;
        StoreKitEventListener.丛丅业丗丏上丟万丗(丅丗丟专东三不世东:  StoreKitEventListener.丌丒丝丄丂丄不丛上(丛丌丗丄三丞业与与:  丛丌丗丄三丞业与与));
        if(丝丏丛世丞一丞丐丒 == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        this.丐丗业丑丝丛与丏丝(丛丌丗丄三丞业与与:  丛丌丗丄三丞业与与);
    }
    private static void 丙一丑丗且世丕丁下(com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与)
    {
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        UnityEngine.Debug.Log(message:  "[Rilisoft] Amazon: restoring purchase: "("[Rilisoft] Amazon: restoring purchase: ") + 丛丌丗丄三丞业与与.Sku);
        InappRememberedBonus val_4 = PGCompany.丌与丛丕业丈不丐世.丟丐丘且东丂丅业丆(丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku);
        一下丛与丛丛万万丏.万上丝丕不丟丑丑专(丅丞丂丟丟且丅丆丅:  丛丌丗丄三丞业与与.Sku, 丂丈丗丄不丅丅丙丒:  val_4);
        if(val_4 != null)
        {
                丛丑丙丗下专东丝三 val_6 = 一下丛与丛丛万万丏.丘一丛丑丈丁丑丅三(丂丈丗丄不丅丅丙丒:  val_4);
            string val_7 = StoreKitEventListener.且业丒丂下业丐丝世(不丌一丄东丝丏且丗:  val_6.丗业丛业丂丆丕丈一, 丂丈丗丄不丅丅丙丒:  val_4);
            string val_8 = StoreKitEventListener.丟东不丁万万丒丂丌(丂丈丗丄不丅丅丙丒:  val_4);
        }
        else
        {
                val_30 = null;
            val_30 = null;
            int val_10 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丛丌丗丄三丞业与与.Sku);
            if(val_10 >= (StoreKitEventListener.业丝丐三上丈丛丂专.GetLowerBound(dimension:  0)))
        {
                val_31 = null;
            val_31 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丗世丈丂丒丞专上丟:  UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.业万业下世丙丕上丏(丈一三丂七丆丛且且:  val_10, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0)), 世丁丙世丄一万丆三:  13, 丛丞万三下丘七丌丅:  true);
            coinsShop.丙丝东下世丟丙丆七(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        }
        
            val_32 = null;
            val_32 = null;
            int val_16 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丛丌丗丄三丞业与与.Sku);
            if(val_16 >= (StoreKitEventListener.丒丕丗丑丕且丌丁丂.GetLowerBound(dimension:  0)))
        {
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "Process purchase {0}, Virtual_CurrencyHelper.Get_Gems_Inapps_Quantity({1})", arg0:  丛丌丗丄三丞业与与.Sku, arg1:  val_16));
            val_33 = null;
            val_33 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.丆一丟丘丒丐丙一丘(丈一三丂七丆丛且且:  val_16, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0)), 世丁丙世丄一万丆三:  13, 丛丞万三下丘七丌丅:  true);
            coinsShop.丙丝东下世丟丙丆七(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
        
            StoreKitEventListener.且上丗三丄丂丏丅上(丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku);
        }
        
        StoreKitEventListener.丈万且丄且丗丙丏与();
        StoreKitEventListener.丛丝丙丌三丑丗万万(丘专丈与三专丈丈专:  丛丌丗丄三丞业与与.Sku);
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        UnityEngine.Debug.Log(message:  "Amazon NotifyFul_fillment (GiveCoinsOr_GemsOnAmazon): "("Amazon NotifyFul_fillment (GiveCoinsOr_GemsOnAmazon): ") + StoreKitEventListener.丌丒丝丄丂丄不丛上(丛丌丗丄三丞业与与:  丛丌丗丄三丞业与与).ToJson()(StoreKitEventListener.丌丒丝丄丂丄不丛上(丛丌丗丄三丞业与与:  丛丌丗丄三丞业与与).ToJson()));
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(386 == 386)
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
    private void 丒丑丏丟万东一且丐(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse 丑与丂丌世丕丆一丗)
    {
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        int val_46;
        System.Collections.Generic.List<System.Object> val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_55;
        StoreKitEventListener val_56;
        var val_57;
        val_43 = 丑与丂丌世丕丆一丗;
        string val_2 = "[Rilisoft] Amazon GetPurchaseU_pdatesResponse: "("[Rilisoft] Amazon GetPurchaseU_pdatesResponse: ") + val_43.ToJson();
        val_45 = "SUCCESSFUL";
        if("SUCCESSFUL" == null)
        {
                val_45 = "SUCCESSFUL";
        }
        
        if((Equals(value:  val_43.Status, comparisonType:  5)) == false)
        {
            goto label_4;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  val_2);
        }
        
        val_46 = System.String.alignConst;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Amazon.FulfilledReceipts")) != false)
        {
                val_46 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Amazon.FulfilledReceipts");
        }
        
        val_47 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  ((System.String.IsNullOrEmpty(value:  val_46)) != true) ? "[]" : (val_46));
        val_47 = null;
        val_47 = new System.Collections.Generic.List<System.Object>();
        System.Collections.Generic.HashSet<System.String> val_13 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> val_14 = val_43.Receipts;
        if(val_43.AmazonUserData != null)
        {
                if((System.String.IsNullOrEmpty(value:  val_43.AmazonUserData.UserId)) != true)
        {
                string val_20 = val_43.AmazonUserData.UserId;
        }
        
        }
        
        var val_42 = 0;
        if(val_14 != null)
        {
            goto label_67;
        }
        
        label_68:
        label_67:
        if(val_42 == val_14.Count)
        {
            goto label_90;
        }
        
        com.amazon.device.iap.cpt.PurchaseReceipt val_22 = val_14.Item[0];
        string val_23 = val_22.Sku;
        val_48 = null;
        val_48 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丗丛丟丘下丙丞业丑, value:  val_23)) == true)
        {
            goto label_86;
        }
        
        val_49 = null;
        val_49 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.业万专三一丟且丘业, value:  val_23)) == true)
        {
            goto label_38;
        }
        
        val_50 = null;
        val_50 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  val_23)) == true)
        {
            goto label_38;
        }
        
        val_51 = null;
        val_51 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  val_23)) == false)
        {
            goto label_86;
        }
        
        label_38:
        val_52 = null;
        if((null.Contains(item:  val_22.ReceiptId)) != false)
        {
                com.amazon.device.iap.cpt.NotifyFulfillmentInput val_30 = StoreKitEventListener.丌丒丝丄丂丄不丛上(丛丌丗丄三丞业与与:  val_22);
            UnityEngine.Debug.Log(message:  "Amazon NotifyFu_lfillment (HandlePurchaseU_pdatesRequestSucc_essfulEvent): "("Amazon NotifyFu_lfillment (HandlePurchaseU_pdatesRequestSucc_essfulEvent): ") + val_30.ToJson());
            StoreKitEventListener.丛丅业丗丏上丟万丗(丅丗丟专东三不世东:  val_30);
        }
        else
        {
                val_52 = null;
            if((StoreKitEventListener.丙丑上丗丝东业业丏.Contains(item:  val_22.ReceiptId)) != true)
        {
                if(CoroutineRunner.Instance != 0)
        {
                UnityEngine.Coroutine val_39 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丈上丒下一上丄东丕(丛上丌丂业七不三世:  0, 丛丌丗丄三丞业与与:  val_22, 万一下七丈丈丗世丐:  val_20));
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "Amazon NotifyFulfillment CoroutineRunner.Instance == null ");
            this.丗丂丝丏丙三与丑丅(丛丌丗丄三丞业与与:  val_22, 万丄丅丝三丈丆世丟:  val_20);
        }
        
        }
        
        }
        
        label_86:
        val_42 = val_42 + 1;
        if(val_14 != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_4:
        UnityEngine.Debug.LogWarning(message:  val_2);
        label_90:
        val_55 = 0;
        val_56 = 0;
        val_57 = 1152921505272713216;
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        if( == 1)
        {
            goto label_126;
        }
        
        if(( == 0) || ( == 465))
        {
            goto label_128;
        }
        
        label_129:
        val_42 = ???;
        val_56 = ???;
        val_57 = ???;
        val_43 = ???;
        val_44 = ???;
        val_53 = ???;
        label_126:
        if(val_56 != 0)
        {
            goto label_129;
        }
        
        label_128:
        var val_41 = val_42 - 80;
    }
    private static void 丛丅业丗丏上丟万丗(com.amazon.device.iap.cpt.NotifyFulfillmentInput 丅丗丟专东三不世东)
    {
        int val_24;
        var val_25;
        int val_26;
        System.Collections.Generic.List<System.Object> val_27;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_24 = System.String.Format(format:  "AmazonNotifyFu_lfillmentAndSave(\'{0}\')", arg0:  丅丗丟专东三不世东.ToJson());
        }
        else
        {
                val_24 = System.String.alignConst;
        }
        
        val_25 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        if(丅丗丟专东三不世东 != null)
        {
                val_26 = System.String.alignConst;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Amazon.FulfilledReceipts")) != false)
        {
                val_26 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Amazon.FulfilledReceipts");
            object[] val_7 = new object[2];
            val_7[0] = "Amazon.FulfilledReceipts";
            val_7[1] = val_26;
            val_25 = 0;
            UnityEngine.Debug.LogFormat(format:  "Storager has {0}: {1}", args:  val_7);
        }
        
            if((System.String.IsNullOrEmpty(value:  val_26)) != false)
        {
                val_26 = "[]";
            object[] val_9 = new object[2];
            val_9[0] = "Amazon.FulfilledReceipts";
            val_9[1] = val_26;
            val_25 = 0;
            UnityEngine.Debug.LogFormat(format:  "Storager doesn\'t have {0}: {1}", args:  val_9);
        }
        
            val_27 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_26);
            val_27 = null;
            val_27 = new System.Collections.Generic.List<System.Object>();
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = 4;
            com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.NotifyFulfillment(notifyFulfillmentInput:  丅丗丟专东三不世东);
            System.Collections.Generic.HashSet<System.String> val_15 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.OfType<System.String>(source:  null));
            bool val_17 = null.Add(item:  丅丗丟专东三不世东.ReceiptId);
            string val_19 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  null));
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[Rilisoft] Saving fulfillments: "("[Rilisoft] Saving fulfillments: ") + val_19);
        }
        
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Amazon.FulfilledReceipts", 下下丏一丙不丘丌丞:  val_19);
            UnityEngine.PlayerPrefs.Save();
            return;
        }
        
        new System.ArgumentNullException() = new System.ArgumentNullException(paramName:  "notifyFulf_illmentInput");
        if(0 == 1)
        {
                if(null == null)
        {
                return;
        }
        
            return;
        }
    
    }
    private void 丟丞丏丄丘丏一七七()
    {
        var val_94;
        var val_96;
        var val_97;
        var val_99;
        var val_101;
        var val_103;
        var val_105;
        var val_107;
        var val_109;
        var val_111;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_1 != null)
        {
                val_1.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_1.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_1.Add(key:  "productType", value:  "Not defined");
        if(val_1 != null)
        {
                val_1.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_1.Add(key:  "price", value:  "33 руб.");
        }
        
        val_1.Add(key:  "sku", value:  "coin1");
        if(val_1 != null)
        {
                val_1.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_1.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_1.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_3 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_1));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_5 != null)
        {
                val_5.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_5.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_5.Add(key:  "productType", value:  "Not defined");
        if(val_5 != null)
        {
                val_5.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_5.Add(key:  "price", value:  "33 руб.");
        }
        
        val_5.Add(key:  "sku", value:  "coin2");
        if(val_5 != null)
        {
                val_5.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_5.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_5.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_7 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_5));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_9 != null)
        {
                val_9.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_9.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_9.Add(key:  "productType", value:  "Not defined");
        if(val_9 != null)
        {
                val_9.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_9.Add(key:  "price", value:  "33 руб.");
        }
        
        val_9.Add(key:  "sku", value:  "coin3.");
        if(val_9 != null)
        {
                val_9.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_9.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_9.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_11 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_9));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_13 != null)
        {
                val_13.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_13.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_13.Add(key:  "productType", value:  "Not defined");
        if(val_13 != null)
        {
                val_13.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_13.Add(key:  "price", value:  "33 руб.");
        }
        
        val_13.Add(key:  "sku", value:  "coin4");
        if(val_13 != null)
        {
                val_13.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_13.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_13.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_15 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_13));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_17 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_17 != null)
        {
                val_17.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_17.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_17.Add(key:  "productType", value:  "Not defined");
        if(val_17 != null)
        {
                val_17.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_17.Add(key:  "price", value:  "33 руб.");
        }
        
        val_17.Add(key:  "sku", value:  "coin5");
        if(val_17 != null)
        {
                val_17.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_17.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_17.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_19 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_17));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_21 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_21 != null)
        {
                val_21.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_21.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_21.Add(key:  "productType", value:  "Not defined");
        if(val_21 != null)
        {
                val_21.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_21.Add(key:  "price", value:  "33 руб.");
        }
        
        val_21.Add(key:  "sku", value:  "coin17");
        if(val_21 != null)
        {
                val_21.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_21.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_21.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_23 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_21));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_25 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_25 != null)
        {
                val_25.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_25.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_25.Add(key:  "productType", value:  "Not defined");
        if(val_25 != null)
        {
                val_25.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_25.Add(key:  "price", value:  "33 руб.");
        }
        
        val_25.Add(key:  "sku", value:  "coin8");
        if(val_25 != null)
        {
                val_25.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_25.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_25.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_27 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_25));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_29 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_29 != null)
        {
                val_29.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        else
        {
                val_29.Add(key:  "description", value:  "Test coin product for editor in Amazon edition");
        }
        
        val_29.Add(key:  "productType", value:  "Not defined");
        if(val_29 != null)
        {
                val_29.Add(key:  "price", value:  "33 руб.");
        }
        else
        {
                val_29.Add(key:  "price", value:  "33 руб.");
        }
        
        val_29.Add(key:  "sku", value:  "coin9");
        if(val_29 != null)
        {
                val_29.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_29.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_29.Add(key:  "title", value:  "Small pack of coins");
        Rilisoft.一且世丞上丝东丆丆 val_31 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_29));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_33 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_33 != null)
        {
                val_33.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_33.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_33.Add(key:  "productType", value:  "Not defined");
        if(val_33 != null)
        {
                val_33.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_33.Add(key:  "price", value:  "99 руб.");
        }
        
        val_33.Add(key:  "sku", value:  "gem1");
        if(val_33 != null)
        {
                val_33.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_33.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_33.Add(key:  "title", value:  "Small pack of gems");
        Rilisoft.一且世丞上丝东丆丆 val_35 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_33));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_37 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_37 != null)
        {
                val_37.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_37.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_37.Add(key:  "productType", value:  "Not defined");
        if(val_37 != null)
        {
                val_37.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_37.Add(key:  "price", value:  "99 руб.");
        }
        
        val_37.Add(key:  "sku", value:  "gem2");
        if(val_37 != null)
        {
                val_37.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_37.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_37.Add(key:  "title", value:  "Small pack of gems");
        Rilisoft.一且世丞上丝东丆丆 val_39 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_37));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_41 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_41 != null)
        {
                val_41.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_41.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_41.Add(key:  "productType", value:  "Not defined");
        if(val_41 != null)
        {
                val_41.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_41.Add(key:  "price", value:  "99 руб.");
        }
        
        val_41.Add(key:  "sku", value:  "gem3");
        if(val_41 != null)
        {
                val_41.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_41.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_41.Add(key:  "title", value:  "Small pack of gems");
        Rilisoft.一且世丞上丝东丆丆 val_43 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_41));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_45 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_45 != null)
        {
                val_45.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_45.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_45.Add(key:  "productType", value:  "Not defined");
        if(val_45 != null)
        {
                val_45.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_45.Add(key:  "price", value:  "99 руб.");
        }
        
        val_45.Add(key:  "sku", value:  "gem4");
        if(val_45 != null)
        {
                val_45.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_45.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_45.Add(key:  "title", value:  "Small pack of gems");
        Rilisoft.一且世丞上丝东丆丆 val_47 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_45));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_49 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_49 != null)
        {
                val_49.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_49.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_49.Add(key:  "productType", value:  "Not defined");
        if(val_49 != null)
        {
                val_49.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_49.Add(key:  "price", value:  "99 руб.");
        }
        
        val_49.Add(key:  "sku", value:  "gem5");
        if(val_49 != null)
        {
                val_49.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_49.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_49.Add(key:  "title", value:  "Small pack of gems");
        Rilisoft.一且世丞上丝东丆丆 val_51 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_49));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_53 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_53 != null)
        {
                val_53.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_53.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_53.Add(key:  "productType", value:  "Not defined");
        if(val_53 != null)
        {
                val_53.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_53.Add(key:  "price", value:  "99 руб.");
        }
        
        val_53.Add(key:  "sku", value:  "gem6");
        if(val_53 != null)
        {
                val_53.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_53.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_53.Add(key:  "title", value:  "Small pack of gems");
        Rilisoft.一且世丞上丝东丆丆 val_55 = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_53));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_57 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_57 != null)
        {
                val_57.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_57.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_57.Add(key:  "productType", value:  "Not defined");
        if(val_57 != null)
        {
                val_57.Add(key:  "price", value:  "99 руб.");
        }
        else
        {
                val_57.Add(key:  "price", value:  "99 руб.");
        }
        
        val_57.Add(key:  "sku", value:  "gem7");
        if(val_57 != null)
        {
                val_57.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        else
        {
                val_57.Add(key:  "smallIconUrl", value:  "http://example.com");
        }
        
        val_57.Add(key:  "title", value:  "Small pack of gems");
        val_94 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_57));
        var val_94 = 0;
        val_94 = val_94 + 1;
        val_94 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_61 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_61 != null)
        {
                val_61.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_61.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_61.Add(key:  "productType", value:  "Not defined");
        val_61.Add(key:  "price", value:  "99 руб.");
        val_96 = null;
        val_96 = null;
        if(val_61 != null)
        {
                val_61.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 32);
        }
        else
        {
                val_61.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 32);
        }
        
        val_61.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_61.Add(key:  "title", value:  "Small pack of gems");
        val_97 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_61));
        var val_95 = 0;
        val_95 = val_95 + 1;
        val_97 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_65 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_65 != null)
        {
                val_65.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_65.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_65.Add(key:  "productType", value:  "Not defined");
        val_65.Add(key:  "price", value:  "99 руб.");
        if(val_65 != null)
        {
                val_65.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 40);
        }
        else
        {
                val_65.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 40);
        }
        
        val_65.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_65.Add(key:  "title", value:  "Small pack of gems");
        val_99 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_65));
        var val_96 = 0;
        val_96 = val_96 + 1;
        val_99 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_69 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_69 != null)
        {
                val_69.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_69.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_69.Add(key:  "productType", value:  "Not defined");
        val_69.Add(key:  "price", value:  "99 руб.");
        if(val_69 != null)
        {
                val_69.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 48);
        }
        else
        {
                val_69.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 48);
        }
        
        val_69.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_69.Add(key:  "title", value:  "Small pack of gems");
        val_101 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_69));
        var val_97 = 0;
        val_97 = val_97 + 1;
        val_101 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_73 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_73 != null)
        {
                val_73.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_73.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_73.Add(key:  "productType", value:  "Not defined");
        val_73.Add(key:  "price", value:  "99 руб.");
        if(val_73 != null)
        {
                val_73.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 56);
        }
        else
        {
                val_73.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 56);
        }
        
        val_73.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_73.Add(key:  "title", value:  "Small pack of gems");
        val_103 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_73));
        var val_98 = 0;
        val_98 = val_98 + 1;
        val_103 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_77 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_77 != null)
        {
                val_77.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_77.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_77.Add(key:  "productType", value:  "Not defined");
        val_77.Add(key:  "price", value:  "99 руб.");
        if(val_77 != null)
        {
                val_77.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 64);
        }
        else
        {
                val_77.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 64);
        }
        
        val_77.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_77.Add(key:  "title", value:  "Small pack of gems");
        val_105 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_77));
        var val_99 = 0;
        val_99 = val_99 + 1;
        val_105 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_81 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_81 != null)
        {
                val_81.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_81.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_81.Add(key:  "productType", value:  "Not defined");
        val_81.Add(key:  "price", value:  "99 руб.");
        if(val_81 != null)
        {
                val_81.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 72);
        }
        else
        {
                val_81.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 72);
        }
        
        val_81.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_81.Add(key:  "title", value:  "Small pack of gems");
        val_107 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_81));
        var val_100 = 0;
        val_100 = val_100 + 1;
        val_107 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_85 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_85 != null)
        {
                val_85.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        else
        {
                val_85.Add(key:  "description", value:  "Test gem product for editor in Amazon edition");
        }
        
        val_85.Add(key:  "productType", value:  "Not defined");
        val_85.Add(key:  "price", value:  "99 руб.");
        if(val_85 != null)
        {
                val_85.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 80);
        }
        else
        {
                val_85.Add(key:  "sku", value:  StoreKitEventListener.业万专三一丟且丘业 + 80);
        }
        
        val_85.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_85.Add(key:  "title", value:  "Small pack of gems");
        val_109 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_85));
        var val_101 = 0;
        val_101 = val_101 + 1;
        val_109 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  ???);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_89 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_89 != null)
        {
                val_89.Add(key:  "description", value:  "Test starter pack product for editor in Amazon edition");
        }
        else
        {
                val_89.Add(key:  "description", value:  "Test starter pack product for editor in Amazon edition");
        }
        
        val_89.Add(key:  "productType", value:  "Not defined");
        val_89.Add(key:  "price", value:  "33 руб.");
        string val_90 = StoreKitEventListener.丌业万丄丛丙不丑不();
        if(val_89 != null)
        {
                val_89.Add(key:  "sku", value:  val_90);
        }
        else
        {
                val_89.Add(key:  "sku", value:  val_90);
        }
        
        val_89.Add(key:  "smallIconUrl", value:  "http://example.com");
        val_89.Add(key:  "title", value:  "First starter pack(amazon)");
        val_111 = 0;
        null = new Rilisoft.一且世丞上丝东丆丆(东下丄丄上丞专丐不:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  val_89));
        var val_102 = 0;
        val_102 = val_102 + 1;
        val_111 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
    }
    internal static bool 丂丗丆丗丛丞业丌三()
    {
        null = null;
        return (bool)StoreKitEventListener.丞下丈丁丛丏上丛丂;
    }
    private static void 世世丅一丈丒一丅丟(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        StoreKitEventListener.丞下丈丁丛丏上丛丂 = 丙业与丙丗丝不丈东;
    }
    internal static decimal 世丌丝丝丕专且下丟(long 丆丂上丅丗丞丏丆丁)
    {
        decimal val_1 = System.Decimal.op_Implicit(value:  丆丂上丅丗丞丏丆丁);
        decimal val_2 = System.Decimal.Divide(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal());
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    internal static void 丞七丕丏丙丐业与世()
    {
        var val_3;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2)
        {
                val_3 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAoTzMTaqsFhaywvCFKawFwL5KM+djLJfOCT/rbGQRfHmHYmOY2sBMgDWsA/67Szx6EVTZPVlFzHMgkAq1TwdL/A5aYGpGzaCX7o96cyp8R6wSF+xCuj++LAkTaDnLW0veI2bke3EVHu3At9xgM46e+VDucRUqQLvf6SQRb15nuflY5i08xKnewgX7I4U2H0RvAZDyoip+qZPmI4ZvaufAfc0jwZbw7XGiV41zibY3LU0N57mYKk51Wx+tOaJ7Tkc9Rl1qVCTjb+bwXshTqhVXVP6r4kabLWw/8OJUh0Sm69lbps6amP7vPy571XjscCTMLfXQan1959rHbNgkb2mLLQIDAQAB";
        }
        
        Prime31.GoogleIAB.init(publicKey:  System.String.__il2cppRuntimeField_static_fields);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        Prime31.GoogleIAB.enableLogging(shouldEnable:  true);
    }
    internal System.Collections.Generic.ICollection<Rilisoft.与丗丌丑专业丝丛丏> 世丝世业丙丙丄一一()
    {
        return (System.Collections.Generic.ICollection<Rilisoft.与丗丌丑专业丝丛丏>)this.下丌丂丘丕丕专下丁;
    }
    private void Start()
    {
        var val_16;
        var val_18;
        var val_19;
        val_16 = this;
        bool val_2 = UnityEngine.Application.isEditor;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_3;
        }
        
        if(val_2 == false)
        {
            goto label_4;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        goto label_9;
        label_3:
        if(val_2 != false)
        {
                this.下不丁丆丝丝丝丙丐();
            return;
        }
        
        StoreKitEventListener.丞七丕丏丙丐业与世();
        return;
        label_9:
        if(this.下丌丂丘丕丕专下丁.Count == 0)
        {
            goto label_13;
        }
        
        label_4:
        val_18 = null;
        val_18 = null;
        System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  StoreKitEventListener.业丝丐三上丈丛丂专, second:  StoreKitEventListener.业万专三一丟且丘业), second:  StoreKitEventListener.丒丕丗丑丕且丌丁丂));
        com.amazon.device.iap.cpt.SkusInput val_8 = new com.amazon.device.iap.cpt.SkusInput();
        if(val_8 != null)
        {
                val_8.Skus = val_7;
        }
        else
        {
                val_8.Skus = val_7;
        }
        
        val_19 = 0;
        UnityEngine.Debug.Log(message:  "Amazon GetProd_uctData (StoreKitE_ventListener.Start): "("Amazon GetProd_uctData (StoreKitE_ventListener.Start): ") + val_8.ToJson());
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_19 = 2;
        val_16 = ???;
        com.amazon.device.iap.cpt.RequestOutput val_13 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.GetProductData(skusInput:  val_8);
        return;
        label_13:
        this.丟丞丏丄丘丏一七七();
    }
    private void OnEnable()
    {
        var val_29;
        IntPtr val_31;
        IntPtr val_33;
        IntPtr val_35;
        IntPtr val_37;
        StoreKitEventListener.丈丞丕丘丄丐且丈丂 val_1 = new StoreKitEventListener.丈丞丕丘丄丐且丈丂();
        var val_29 = 0;
        val_29 = val_29 + 1;
        this.丙七专七丆丌丄丏丘.Dispose();
        val_29 = null;
        val_29 = null;
        if((StoreKitEventListener.<>c.<>9__45_0) == null)
        {
            goto label_8;
        }
        
        label_25:
        .丐丑世丄世丐三与专 = StoreKitEventListener.<>c.<>9__45_0;
        this.丙七专七丆丌丄丏丘 = new Rilisoft.丝丄丄不丏丘丝世丗(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丈丞丕丘丄丐且丈丂::丕且丈丈专丐丞丟下()));
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_12;
        }
        
        com.amazon.device.iap.cpt.GetUserDataResponseDelegate val_7 = null;
        val_31 = System.Void StoreKitEventListener::下丂丌不东丝三丟丝(com.amazon.device.iap.cpt.GetUserDataResponse 丑与丂丌世丕丆一丗);
        val_7 = new com.amazon.device.iap.cpt.GetUserDataResponseDelegate(object:  this, method:  val_31);
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_31 = 6;
        goto label_19;
        label_12:
        Prime31.GoogleIABManager.add_billingSupportedEvent(value:  new System.Action(object:  this, method:  System.Void StoreKitEventListener::不专丌丆丆东丑丒丟()));
        Prime31.GoogleIABManager.add_billingNotSupportedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void StoreKitEventListener::丅丟丂丝业东丙丞丂(string 丂七东不不丈一丐不)));
        Prime31.GoogleIABManager.add_queryInventorySucceededEvent(value:  new System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>>(object:  this, method:  System.Void StoreKitEventListener::丅万丑七丈业一丗丗(System.Collections.Generic.List<Prime31.GooglePurchase> 一丛丂丘丝业且丞三, System.Collections.Generic.List<Prime31.GoogleSkuInfo> 与丅东丑不丈丌丒上)));
        Prime31.GoogleIABManager.add_queryInventoryFailedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void StoreKitEventListener::丂丆上丛且世业丝世(string 丂七东不不丈一丐不)));
        Prime31.GoogleIABManager.add_purchaseSucceededEvent(value:  new System.Action<Prime31.GooglePurchase>(object:  this, method:  System.Void StoreKitEventListener::丅三与丟专丘东且丝(Prime31.GooglePurchase 丛上丌丂业七不三世)));
        Prime31.GoogleIABManager.add_purchaseFailedEvent(value:  (StoreKitEventListener.丈丞丕丘丄丐且丈丂)[1152921539318629312].丐丑世丄世丐三与专);
        Prime31.GoogleIABManager.add_consumePurchaseSucceededEvent(value:  new System.Action<Prime31.GooglePurchase>(object:  this, method:  System.Void StoreKitEventListener::一丐丄丁万丞与丟丐(Prime31.GooglePurchase 丛上丌丂业七不三世)));
        Prime31.GoogleIABManager.add_consumePurchaseFailedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void StoreKitEventListener::丁丆丌丌丌专上丕丛(string 丂七东不不丈一丐不)));
        return;
        label_8:
        StoreKitEventListener.<>c.<>9__45_0 = new System.Action<System.String, System.Int32>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.Void StoreKitEventListener.<>c::一丐丟丅下丑七丁不(string 丂七东不不丈一丐不, int 丑与丂丌世丕丆一丗));
        if(val_1 != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_19:
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.AddGetUserDataResponseListener(responseDelegate:  val_7);
        com.amazon.device.iap.cpt.GetProductDataResponseDelegate val_18 = null;
        val_33 = System.Void StoreKitEventListener::丂丛七丐丑丟丙不且(com.amazon.device.iap.cpt.GetProductDataResponse 丑与丂丌世丕丆一丗);
        val_18 = new com.amazon.device.iap.cpt.GetProductDataResponseDelegate(object:  this, method:  val_33);
        var val_31 = 0;
        val_31 = val_31 + 1;
        val_33 = 10;
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.AddGetProductDataResponseListener(responseDelegate:  val_18);
        com.amazon.device.iap.cpt.PurchaseResponseDelegate val_21 = null;
        val_35 = System.Void StoreKitEventListener::丛丕七专东丟专丟丄(com.amazon.device.iap.cpt.PurchaseResponse 丑与丂丌世丕丆一丗);
        val_21 = new com.amazon.device.iap.cpt.PurchaseResponseDelegate(object:  this, method:  val_35);
        var val_32 = 0;
        val_32 = val_32 + 1;
        val_35 = 8;
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.AddPurchaseResponseListener(responseDelegate:  val_21);
        com.amazon.device.iap.cpt.IAmazonIapV2 val_23 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance;
        com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate val_24 = null;
        val_37 = System.Void StoreKitEventListener::丒丑丏丟万东一且丐(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse 丑与丂丌世丕丆一丗);
        val_24 = new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate(object:  this, method:  val_37);
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_37 = 12;
        val_23.AddGetPurchaseUpdatesResponseListener(responseDelegate:  val_24);
        val_23.丙丄丂丄丌与上丄三(丏丈且一不丈丗业三:  false);
        UnityEngine.Debug.Log(message:  "Amazon GetUser_Data (StoreKitEventL_istener.OnEnable)");
        var val_34 = 0;
        val_34 = val_34 + 1;
        com.amazon.device.iap.cpt.RequestOutput val_28 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.GetUserData();
    }
    private void OnDisable()
    {
        IntPtr val_23;
        IntPtr val_25;
        IntPtr val_27;
        IntPtr val_29;
        var val_22 = 0;
        val_22 = val_22 + 1;
        this.丙七专七丆丌丄丏丘.Dispose();
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                com.amazon.device.iap.cpt.GetUserDataResponseDelegate val_4 = null;
            val_23 = System.Void StoreKitEventListener::下丂丌不东丝三丟丝(com.amazon.device.iap.cpt.GetUserDataResponse 丑与丂丌世丕丆一丗);
            val_4 = new com.amazon.device.iap.cpt.GetUserDataResponseDelegate(object:  this, method:  val_23);
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_23 = 7;
        }
        else
        {
                Prime31.GoogleIABManager.remove_billingSupportedEvent(value:  new System.Action(object:  this, method:  System.Void StoreKitEventListener::不专丌丆丆东丑丒丟()));
            Prime31.GoogleIABManager.remove_billingNotSupportedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void StoreKitEventListener::丅丟丂丝业东丙丞丂(string 丂七东不不丈一丐不)));
            Prime31.GoogleIABManager.remove_queryInventorySucceededEvent(value:  new System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>>(object:  this, method:  System.Void StoreKitEventListener::丅万丑七丈业一丗丗(System.Collections.Generic.List<Prime31.GooglePurchase> 一丛丂丘丝业且丞三, System.Collections.Generic.List<Prime31.GoogleSkuInfo> 与丅东丑不丈丌丒上)));
            Prime31.GoogleIABManager.remove_queryInventoryFailedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void StoreKitEventListener::丂丆上丛且世业丝世(string 丂七东不不丈一丐不)));
            Prime31.GoogleIABManager.remove_purchaseSucceededEvent(value:  new System.Action<Prime31.GooglePurchase>(object:  this, method:  System.Void StoreKitEventListener::丅三与丟专丘东且丝(Prime31.GooglePurchase 丛上丌丂业七不三世)));
            Prime31.GoogleIABManager.remove_consumePurchaseSucceededEvent(value:  new System.Action<Prime31.GooglePurchase>(object:  this, method:  System.Void StoreKitEventListener::一丐丄丁万丞与丟丐(Prime31.GooglePurchase 丛上丌丂业七不三世)));
            Prime31.GoogleIABManager.remove_consumePurchaseFailedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void StoreKitEventListener::丁丆丌丌丌专上丕丛(string 丂七东不不丈一丐不)));
            return;
        }
        
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.RemoveGetUserDataResponseListener(responseDelegate:  val_4);
        com.amazon.device.iap.cpt.GetProductDataResponseDelegate val_14 = null;
        val_25 = System.Void StoreKitEventListener::丂丛七丐丑丟丙不且(com.amazon.device.iap.cpt.GetProductDataResponse 丑与丂丌世丕丆一丗);
        val_14 = new com.amazon.device.iap.cpt.GetProductDataResponseDelegate(object:  this, method:  val_25);
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_25 = 11;
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.RemoveGetProductDataResponseListener(responseDelegate:  val_14);
        com.amazon.device.iap.cpt.PurchaseResponseDelegate val_17 = null;
        val_27 = System.Void StoreKitEventListener::丛丕七专东丟专丟丄(com.amazon.device.iap.cpt.PurchaseResponse 丑与丂丌世丕丆一丗);
        val_17 = new com.amazon.device.iap.cpt.PurchaseResponseDelegate(object:  this, method:  val_27);
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_27 = 9;
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.RemovePurchaseResponseListener(responseDelegate:  val_17);
        com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate val_20 = null;
        val_29 = System.Void StoreKitEventListener::丒丑丏丟万东一且丐(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse 丑与丂丌世丕丆一丗);
        val_20 = new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate(object:  this, method:  val_29);
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_29 = 13;
        com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.RemoveGetPurchaseUpdatesResponseListener(responseDelegate:  val_20);
    }
    private void 不专丌丆丆东丑丒丟()
    {
        StoreKitEventListener.世世丅一丈丒一丅丟(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.Log(message:  "billingSup_ortedEvent");
        StoreKitEventListener.丞七丂业丒且丁东与();
    }
    internal static void 丞七丂业丒且丁东与()
    {
        var val_18;
        var val_19;
        var val_21;
        val_18 = null;
        if(StoreKitEventListener.丂丗丆丗丛丞业丌三() != true)
        {
                if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_6;
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Concat<System.String>(first:  StoreKitEventListener.丘世与丄一丐丝下丛, second:  StoreKitEventListener.业万专三一丟且丘业), second:  StoreKitEventListener.业丝丐三上丈丛丂专), second:  StoreKitEventListener.丒丕丗丑丕且丌丁丂), second:  StoreKitEventListener.丗丛丟丘下丙丞业丑);
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_11;
        }
        
        com.amazon.device.iap.cpt.SkusInput val_8 = new com.amazon.device.iap.cpt.SkusInput();
        System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<System.String>(source:  val_6);
        if(val_8 == null)
        {
            goto label_12;
        }
        
        val_8.Skus = val_9;
        goto label_13;
        label_11:
        Prime31.GoogleIAB.queryInventory(skus:  System.Linq.Enumerable.ToArray<System.String>(source:  val_6));
        return;
        label_6:
        object[] val_11 = new object[1];
        val_11[0] = StoreKitEventListener.丂丗丆丗丛丞业丌三();
        UnityEngine.Debug.LogFormat(format:  "Quitting RefreshP_roducts(), billin_gSupported: {0}", args:  val_11);
        return;
        label_12:
        val_8.Skus = val_9;
        label_13:
        val_21 = 0;
        UnityEngine.Debug.Log(message:  "Amazon GetProdu_ctData(Refresh_Products): "("Amazon GetProdu_ctData(Refresh_Products): ") + val_8.ToJson());
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_21 = 2;
        com.amazon.device.iap.cpt.RequestOutput val_18 = com.amazon.device.iap.cpt.AmazonIapV2Impl.Instance.GetProductData(skusInput:  val_8);
    }
    private void 丅丟丂丝业东丙丞丂(string 丂七东不不丈一丐不)
    {
        StoreKitEventListener.世世丅一丈丒一丅丟(丙业与丙丗丝不丈东:  false);
        UnityEngine.Debug.LogWarning(message:  "billingNo_tSupportedEvent: "("billingNo_tSupportedEvent: ") + 丂七东不不丈一丐不);
    }
    private static void 且丑东丗一丛世丗丂()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Android.GooglePlayOrderIdsKey")) != false)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Android.GooglePlayOrderIdsKey", 下下丏一丙不丘丌丞:  "[]");
    }
    private static bool 万丈不丑丙丘万丈丘(string 下丟丙丒丝丆丏与业)
    {
        var val_9;
        var val_10;
        StoreKitEventListener.且丑东丗一丛世丗丂();
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Android.GooglePlayOrderIdsKey");
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_9 = 0;
            return (bool)val_6.Contains(item:  下丟丙丒丝丆丏与业);
        }
        
        if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_1)) != null)
        {
                val_10 = 0;
        }
        
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null));
        if(val_6 == null)
        {
                return (bool)val_6.Contains(item:  下丟丙丒丝丆丏与业);
        }
        
        return (bool)val_6.Contains(item:  下丟丙丒丝丆丏与业);
    }
    private static bool 七与下上丗东东专丅(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        System.Func<System.String, System.Boolean> val_10;
        var val_11;
        val_10 = 丛上丌丂业七不三世;
        StoreKitEventListener.且丑东丗一丛世丗丂();
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Android.GooglePlayOrderIdsKey");
        string val_10 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_10);
            if(val_3 != null)
        {
                val_10 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            if(val_10.Count == 1)
        {
                val_10 = null;
            val_10 = new System.Func<System.String, System.Boolean>(object:  val_10.orderId, method:  typeof(System.String).__il2cppRuntimeField_2D0);
            var val_9 = ((System.Linq.Enumerable.FirstOrDefault<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  val_10), predicate:  null)) != null) ? 1 : 0;
            return (bool)val_11;
        }
        
        }
        
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    private void 与下且丑上丕下丒上()
    {
        var val_7;
        System.Func<Prime31.GooglePurchase, System.Boolean> val_9;
        string val_11;
        var val_12;
        System.Func<Prime31.GooglePurchase, System.Boolean> val_14;
        if(this.与专丒丑丞丐丄上丄.Count >= 1)
        {
                val_7 = null;
            val_7 = null;
            val_9 = StoreKitEventListener.<>c.<>9__53_0;
            if(val_9 == null)
        {
                val_9 = null;
            val_9 = new System.Func<Prime31.GooglePurchase, System.Boolean>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreKitEventListener.<>c::丙世丅丁丌一丏丆丘(Prime31.GooglePurchase 七丏丄丅丌业与且丙));
            StoreKitEventListener.<>c.<>9__53_0 = val_9;
        }
        
            val_11 = System.Linq.Enumerable.FirstOrDefault<Prime31.GooglePurchase>(source:  this.与专丒丑丞丐丄上丄, predicate:  null);
            if(val_11 == null)
        {
                return;
        }
        
            UnityEngine.Debug.Log(message:  "StoreKitEve_ntListener.AddCurren_cyAndConsume_NextGooglePlayPurchase(): Consuming Goole purchase "("StoreKitEve_ntListener.AddCurren_cyAndConsume_NextGooglePlayPurchase(): Consuming Goole purchase ") + val_11);
            StoreKitEventListener.一世东且丟一丙丌丂(丛上丌丂业七不三世:  val_11, 丝丏丛世丞一丞丐丒:  true);
            return;
        }
        
        val_12 = null;
        val_12 = null;
        val_14 = StoreKitEventListener.<>c.<>9__53_1;
        if(val_14 == null)
        {
                val_14 = null;
            val_14 = new System.Func<Prime31.GooglePurchase, System.Boolean>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreKitEventListener.<>c::东丆丘丗丕丆丈与不(Prime31.GooglePurchase 七丏丄丅丌业与且丙));
            StoreKitEventListener.<>c.<>9__53_1 = val_14;
        }
        
        val_11 = System.Linq.Enumerable.FirstOrDefault<Prime31.GooglePurchase>(source:  this.丁丗丙三丆丄万上丛, predicate:  null);
        if(val_11 == null)
        {
                return;
        }
        
        StoreKitEventListener.一世东且丟一丙丌丂(丛上丌丂业七不三世:  val_11, 丝丏丛世丞一丞丐丒:  true);
    }
    private void 丅万丑七丈业一丗丗(System.Collections.Generic.List<Prime31.GooglePurchase> 一丛丂丘丝业且丞三, System.Collections.Generic.List<Prime31.GoogleSkuInfo> 与丅东丑不丈丌丒上)
    {
        object val_44;
        var val_61;
        var val_62;
        System.Func<Prime31.GoogleSkuInfo, System.Boolean> val_64;
        var val_65;
        var val_66;
        var val_67;
        System.Func<Prime31.GoogleSkuInfo, System.String> val_69;
        System.String[] val_70;
        var val_71;
        System.Func<Prime31.GooglePurchase, System.String> val_73;
        var val_77;
        var val_79;
        var val_81;
        var val_85;
        var val_86;
        if(一丛丂丘丝业且丞三 == null)
        {
            goto label_1;
        }
        
        if(与丅东丑不丈丌丒上 == null)
        {
            goto label_2;
        }
        
        label_9:
        var val_65 = 0;
        val_65 = val_65 + 1;
        goto label_7;
        label_1:
        System.Collections.Generic.List<Prime31.GooglePurchase> val_1 = new System.Collections.Generic.List<Prime31.GooglePurchase>();
        if(与丅东丑不丈丌丒上 != null)
        {
            goto label_9;
        }
        
        label_2:
        System.Collections.Generic.List<Prime31.GoogleSkuInfo> val_2 = new System.Collections.Generic.List<Prime31.GoogleSkuInfo>();
        goto label_9;
        label_7:
        this.下丌丂丘丕丕专下丁.Clear();
        this.丁丗丙三丆丄万上丛.Clear();
        this.与专丒丑丞丐丄上丄.Clear();
        new StoreKitEventListener.丙丟与业不万丈丄丈() = new StoreKitEventListener.丙丟与业不万丈丄丈();
        val_61 = 1152921505272979456;
        val_62 = null;
        val_62 = null;
        val_64 = StoreKitEventListener.<>c.<>9__55_0;
        if(val_64 == null)
        {
                val_64 = null;
            val_64 = new System.Func<Prime31.GoogleSkuInfo, System.Boolean>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreKitEventListener.<>c::丕丑丄丝七上业丞不(Prime31.GoogleSkuInfo 丏丛与丅丛丌万专丌));
            StoreKitEventListener.<>c.<>9__55_0 = val_64;
        }
        
        if((System.Linq.Enumerable.Any<Prime31.GoogleSkuInfo>(source:  与丅东丑不丈丌丒上, predicate:  null)) == false)
        {
            goto label_17;
        }
        
        val_65 = 0;
        val_66 = 0;
        goto label_212;
        label_17:
        val_67 = null;
        val_67 = null;
        val_69 = StoreKitEventListener.<>c.<>9__55_1;
        if(val_69 == null)
        {
                val_69 = null;
            val_69 = new System.Func<Prime31.GoogleSkuInfo, System.String>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.String StoreKitEventListener.<>c::专三世丄丄丕一且不(Prime31.GoogleSkuInfo 丑东丅与丄业一丒丅));
            StoreKitEventListener.<>c.<>9__55_1 = val_69;
        }
        
        val_70 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Prime31.GoogleSkuInfo, System.String>(source:  与丅东丑不丈丌丒上, selector:  null));
        if(new StoreKitEventListener.丙丟与业不万丈丄丈() != null)
        {
                .丝七下丈丆丅上丁上 = val_70;
        }
        else
        {
                .丝七下丈丆丅上丁上 = val_70;
            val_70 = (StoreKitEventListener.丙丟与业不万丈丄丈)[1152921539320582752].丝七下丈丆丅上丁上;
        }
        
        val_71 = null;
        val_71 = null;
        val_73 = StoreKitEventListener.<>c.<>9__55_3;
        if(val_73 == null)
        {
                val_73 = null;
            val_73 = new System.Func<Prime31.GooglePurchase, System.String>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.String StoreKitEventListener.<>c::专丏且业丕丒丞丁一(Prime31.GooglePurchase 七丏丄丅丌业与且丙));
            StoreKitEventListener.<>c.<>9__55_3 = val_73;
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Google billing. Query inventory succeeded, purchases: [{0}], skus: [{1}]", arg0:  System.String.Join(separator:  ", ", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Prime31.GooglePurchase, System.String>(source:  一丛丂丘丝业且丞三, selector:  null))), arg1:  System.String.Join(separator:  ", ", value:  val_70)));
        System.Func<Prime31.GoogleSkuInfo, System.Boolean> val_16 = new System.Func<Prime31.GoogleSkuInfo, System.Boolean>(object:  new StoreKitEventListener.丙丟与业不万丈丄丈(), method:  System.Boolean StoreKitEventListener.丙丟与业不万丈丄丈::一丘丌且不丞丆丑三(Prime31.GoogleSkuInfo 丏丛与丅丛丌万专丌));
        System.Func<Prime31.GoogleSkuInfo, Rilisoft.丈丝业丅丒丅丄丞七> val_18 = new System.Func<Prime31.GoogleSkuInfo, Rilisoft.丈丝业丅丒丅丄丞七>(object:  0, method:  static Rilisoft.丈丝业丅丒丅丄丞七 Rilisoft.世东业下万不丕上丙::三一丏业丆东东丑丑(Prime31.GoogleSkuInfo 丙丕下不丅世丈丆丄));
        var val_66 = 0;
        val_66 = val_66 + 1;
        System.Collections.Generic.IEnumerator<T> val_21 = System.Linq.Enumerable.Select<Prime31.GoogleSkuInfo, Rilisoft.丈丝业丅丒丅丄丞七>(source:  System.Linq.Enumerable.Where<Prime31.GoogleSkuInfo>(source:  与丅东丑不丈丌丒上, predicate:  null), selector:  null).GetEnumerator();
        label_80:
        var val_67 = 0;
        val_67 = val_67 + 1;
        if(val_21.MoveNext() == false)
        {
            goto label_43;
        }
        
        var val_68 = 0;
        val_68 = val_68 + 1;
        T val_25 = val_21.Current;
        val_77 = 0;
        if((val_25.丟丂丞不专丆万丒世().Contains(value:  "$0.0")) != false)
        {
                object[] val_28 = new object[3];
            val_28[0] = val_25.丟丂丞不专丆万丒世();
            val_28[1] = val_25.业上丙丞丐丄丆丅七();
            val_28[2] = val_25.三万丘丅丆不丘上上();
            val_77 = 0;
            UnityEngine.Debug.LogWarningFormat(format:  "Unexpected price \'{0}\': \'{1}\' (\'{2}\')", args:  val_28);
            coinsShop.业丄丘丘丛丆丒丝丁(丙业与丙丗丝不丈东:  true);
        }
        
        var val_69 = 0;
        val_69 = val_69 + 1;
        val_77 = 4;
        val_79 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
        if((this.下丌丂丘丕丕专下丁.Contains(item:  747)) == true)
        {
            goto label_80;
        }
        
        var val_70 = 0;
        val_70 = val_70 + 1;
        val_79 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  747);
        goto label_80;
        label_43:
        val_81 = 0;
        val_66 = 0;
        if(val_21 == null)
        {
            
        }
        else
        {
                var val_71 = 0;
            val_71 = val_71 + 1;
            val_21.Dispose();
        }
        
        if(( != 1) && (415 == 415))
        {
                val_81 = 0;
        }
        else
        {
                if( != false)
        {
                val_66 = 0;
        }
        
        }
        
        Rilisoft.与丗丌丑专业丝丛丏 val_36 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.与丗丌丑专业丝丛丏>(source:  this.下丌丂丘丕丕专下丁);
        if(val_36 != null)
        {
                var val_72 = 0;
            val_72 = val_72 + 1;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_36.东与三丌丅三丒丏业())) != true)
        {
                var val_73 = 0;
            val_73 = val_73 + 1;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "CurrentProductCurrency_12_5", 下下丏一丙不丘丌丞:  val_36.东与三丌丅三丒丏业());
        }
        
        }
        
        List.Enumerator<T> val_42 = 一丛丂丘丝业且丞三.GetEnumerator();
        val_64 = 1152921539320434192;
        val_61 = "MinerWeapon";
        label_168:
        if((353924592 & 1) == 0)
        {
            goto label_144;
        }
        
        string val_45 = val_44.丐丏七丌丕丗业且上();
        if(((((Prime31.GooglePurchaesFix.getPurchaseState(purchase:  val_45)) == 2) || ((System.String.op_Equality(a:  val_45.productId, b:  "MinerWeapon")) == true)) || ((System.String.op_Equality(a:  val_45.productId, b:  ToLower())) == true)) || ((System.String.op_Equality(a:  val_45.productId, b:  "crystalsword")) == true))
        {
            goto label_168;
        }
        
        val_85 = null;
        val_85 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丗丛丟丘下丙丞业丑, value:  val_45.productId)) == true)
        {
            goto label_168;
        }
        
        if((this.丅丌世上丅丁丏上丝(丏东丒丄丟一东丈丟:  val_45.originalJson, 丗丈丈丞丟丟丈丙业:  val_45.signature)) == false)
        {
            goto label_159;
        }
        
        if((StoreKitEventListener.万丈不丑丙丘万丈丘(下丟丙丒丝丆丏与业:  val_45.orderId)) == false)
        {
            goto label_163;
        }
        
        bool val_61 = this.丁丗丙三丆丄万上丛.Add(item:  val_45);
        goto label_168;
        label_159:
        bool val_62 = this.与专丒丑丞丐丄上丄.Add(item:  val_45);
        goto label_168;
        label_163:
        new System.Action<Prime31.GooglePurchase, 一丒丟世下丌一丏丌>(object:  this, method:  System.Void StoreKitEventListener::且丑三七业丟万丅世(Prime31.GooglePurchase 丛上丌丂业七不三世, 一丒丟世下丌一丏丌 三七丑三丝丏丙丘丁)).且丑丟三丗东不丘丙(丛上丌丂业七不三世:  val_45, 业丏丈世世世丞丒世:  null);
        goto label_168;
        label_144:
        val_86 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_86 != 1) && (726 == 726))
        {
                var val_74 = 0;
            val_74 = val_74 ^ 0;
            val_86 = val_86 + val_74;
        }
        else
        {
                if( != 0)
        {
                val_66 = 0;
        }
        
        }
        
        与下且丑上丕下丒上();
        val_65 = val_86 + 1;
        mem2[0] = 747;
        label_212:
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(415 == 747)
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
    private void 丂丆上丛且世业丝世(string 丂七东不不丈一丐不)
    {
        string val_1 = "Google: queryInvent_oryFailedEvent: "("Google: queryInvent_oryFailedEvent: ") + 丂七东不不丈一丐不;
        UnityEngine.Debug.LogWarning(message:  val_1);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.上丈世且专丁专丙丛());
    }
    private System.Collections.IEnumerator 上丈世且专丁专丙丛()
    {
        return (System.Collections.IEnumerator)new StoreKitEventListener.丞丁丞丒丙丟且丑丆(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丛丁丄丗世丗丞丁上(string 一丁丟丟丟丗丘丗专, string 丈丘丟上三专三丅丄)
    {
        UnityEngine.Debug.Log(message:  "purchaseCompl_eteAwaitingVerific_ationEvent. purchaseData: "("purchaseCompl_eteAwaitingVerific_ationEvent. purchaseData: ") + 一丁丟丟丟丗丘丗专 + ", signature: "(", signature: ") + 丈丘丟上三专三丅丄);
    }
    private static bool 丕与丒丂万丟丐丝丄(string 丅丞丂丟丟且丅丆丅)
    {
        var val_8;
        var val_9;
        System.String[] val_10;
        var val_11;
        var val_12;
        var val_13;
        if(丅丞丂丟丟且丅丆丅 != null)
        {
                val_9 = null;
            val_9 = null;
            val_8 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业万专三一丟且丘业, value:  丅丞丂丟丟且丅丆丅);
            val_10 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丅丞丂丟丟且丅丆丅);
            if(val_10 < (StoreKitEventListener.业丝丐三上丈丛丂专.GetLowerBound(dimension:  0)))
        {
                val_11 = null;
            val_11 = null;
            val_10 = StoreKitEventListener.丒丕丗丑丕且丌丁丂;
            if((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丅丞丂丟丟且丅丆丅)) < (val_10.GetLowerBound(dimension:  0)))
        {
                val_12 = null;
            val_12 = null;
            var val_7 = (val_8 >= (StoreKitEventListener.业万专三一丟且丘业.GetLowerBound(dimension:  0))) ? 1 : 0;
            return (bool)val_13;
        }
        
        }
        
            val_13 = 1;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    private System.ValueTuple<bool, int> 丗专东丙上下丙丝丐(string 丅丞丂丟丟且丅丆丅)
    {
        string val_12;
        var val_13;
        var val_14;
        System.String[] val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        val_12 = 丅丞丂丟丟且丅丆丅;
        if((System.String.IsNullOrEmpty(value:  val_12)) != false)
        {
                UnityEngine.Debug.LogError(message:  "TryAddVir_tualCrrency string.IsNullOrEmpty(productId)");
            return 0;
        }
        
        val_13 = null;
        val_13 = null;
        int val_2 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  val_12);
        int val_3 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  val_12);
        if(val_2 >= (StoreKitEventListener.业丝丐三上丈丛丂专.GetLowerBound(dimension:  0)))
        {
            goto label_8;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = StoreKitEventListener.丒丕丗丑丕且丌丁丂;
        if(val_3 < (val_15.GetLowerBound(dimension:  0)))
        {
            goto label_12;
        }
        
        int val_7 = UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.丆一丟丘丒丐丙一丘(丈一三丂七丆丛且且:  val_3, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0));
        val_16 = null;
        val_16 = null;
        val_15 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_15, 丗世丈丂丒丞专上丟:  354875584, 世丁丙世丄一万丆三:  16, 丛丞万三下丘七丌丅:  true);
        val_17 = null;
        val_18 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        goto label_34;
        label_8:
        int val_10 = UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.业万业下世丙丕上丏(丈一三丂七丆丛且且:  val_2, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0));
        val_19 = null;
        val_19 = null;
        val_15 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_15, 丗世丈丂丒丞专上丟:  354875584, 世丁丙世丄一万丆三:  16, 丛丞万三下丘七丌丅:  true);
        val_17 = null;
        val_18 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        label_34:
        coinsShop.丙丝东下世丟丙丆七(丏丂不专上丘丂不丅:  val_18);
        label_12:
        StoreKitEventListener.丈万且丄且丗丙丏与();
        StoreKitEventListener.丛丝丙丌三丑丗万万(丘专丈与三专丈丈专:  val_12);
        val_12 = 1152921516284043440;
        if(( & 1) == 0)
        {
                return 0;
        }
        
        val_12 = ;
        return 0;
    }
    private void 丌上丑丌丘丛丏三丏(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.LogError(message:  "Consuming cheated purchase: "("Consuming cheated purchase: ") + 丛上丌丂业七不三世);
        }
        
        StoreKitEventListener.一世东且丟一丙丌丂(丛上丌丂业七不三世:  丛上丌丂业七不三世, 丝丏丛世丞一丞丐丒:  false);
        bool val_4 = StoreKitEventListener.丑不且一且丙丟三丅.Remove(item:  丛上丌丂业七不三世.productId);
    }
    private void 丐丗业丑丝丛与丏丝(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        string val_46;
        上万丆丙丂丕万丒丑 val_47;
        PGCompany.专丟专世丅丂丁且专 val_48;
        string val_49;
        string val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        string val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        val_46 = "";
        InappRememberedBonus val_2 = 一下丛与丛丛万万丏.专丟丙下丌丆七丄专(丅丞丂丟丟且丅丆丅:  丛上丌丂业七不三世.productId);
        UnityEngine.Debug.Log(message:  "[TEST] is bonus: "("[TEST] is bonus: ") + (val_2 != 0) ? "true" : "false"((val_2 != 0) ? "true" : "false"));
        if(val_2 == null)
        {
            goto label_6;
        }
        
        bool val_5 = PGCompany.丌与丛丕业丈不丐世.丒丛丐丐丑丈世专丑(丄上专丄七丘丕万东:  val_2);
        丛丑丙丗下专东丝三 val_6 = 一下丛与丛丛万万丏.丘一丛丑丈丁丑丅三(丂丈丗丄不丅丅丙丒:  val_2);
        val_47 = val_6.丗业丛业丂丆丕丈一;
        val_48 = val_6.丙丁丑丙丆丐丂业丈;
        val_49 = StoreKitEventListener.丟东不丁万万丒丂丌(丂丈丗丄不丅丅丙丒:  val_2);
        val_50 = val_46;
        val_46 = StoreKitEventListener.且业丒丂下业丐丝世(不丌一丄东丝丏且丗:  val_47, 丂丈丗丄不丅丅丙丒:  val_2);
        goto label_13;
        label_6:
        val_51 = 1152921505272713216;
        val_52 = null;
        val_52 = null;
        int val_10 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丛上丌丂业七不三世.productId);
        int val_12 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丛上丌丂业七不三世.productId);
        val_47 = 65536;
        val_47 = 1;
        if(val_10 >= (StoreKitEventListener.业丝丐三上丈丛丂专.GetLowerBound(dimension:  0)))
        {
            goto label_19;
        }
        
        val_53 = null;
        val_53 = null;
        val_50 = val_46;
        val_49 = val_46;
        if(val_12 < (StoreKitEventListener.丒丕丗丑丕且丌丁丂.GetLowerBound(dimension:  0)))
        {
            goto label_23;
        }
        
        val_50 = "gems";
        int val_16 = UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.丆一丟丘丒丐丙一丘(丈一三丂七丆丛且且:  val_12, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0));
        string[] val_17 = new string[6];
        val_17[0] = "[TEST] currencyType: ";
        val_17[1] = val_50;
        val_17[2] = " prefix: ";
        val_17[3] = val_46;
        val_17[4] = " purchase.productId ";
        val_17[5] = 丛上丌丂业七不三世.productId;
        UnityEngine.Debug.Log(message:  +val_17);
        val_49 = val_46;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) != false)
        {
                int val_22 = AbstractBankView.丁且丘丅丌丛下一丆(丞丂业丅丟丙丏七丗:  47, 丘专丈与三专丈丈专:  丛上丌丂业七不三世.productId);
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TEST] real: {0}", arg0:  val_22));
            int val_25 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  223, 世丈三丐丞一丒丛不:  val_22);
            val_49 = val_46;
            if(val_25 >= 1)
        {
                val_49 = System.String.Format(format:  "x{0}", arg0:  val_25);
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "[TEST] prefix: "("[TEST] prefix: ") + val_49);
        val_54;
        val_55 = null;
        val_55 = null;
        val_56 = null;
        val_57 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        goto label_66;
        label_19:
        val_50 = "coins";
        int val_29 = UnityEngine.Mathf.RoundToInt(f:  (float)丏丄丑上丛不丈且万.业万业下世丙丕上丏(丈一三丂七丆丛且且:  val_10, 丝东丟丞丛业丆专丙:  0, 丌不丞丞三东丝万丄:  0, 丐业丛丏丙丝丑专与:  0, 丙丟丙七丈丗万不一:  0, 丙丑万丆丈且丑专丌:  0));
        string[] val_30 = new string[6];
        val_30[0] = "[TEST] currencyType: ";
        val_30[1] = val_50;
        val_30[2] = " prefix: ";
        val_30[3] = val_46;
        val_30[4] = " purchase.productId ";
        val_30[5] = 丛上丌丂业七不三世.productId;
        UnityEngine.Debug.Log(message:  +val_30);
        val_49 = val_46;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) != false)
        {
                int val_35 = AbstractBankView.丁且丘丅丌丛下一丆(丞丂业丅丟丙丏七丗:  71, 丘专丈与三专丈丈专:  丛上丌丂业七不三世.productId);
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TEST] real: {0}", arg0:  val_35));
            int val_38 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  247, 世丈三丐丞一丒丛不:  val_35);
            val_49 = val_46;
            if(val_38 >= 1)
        {
                val_49 = System.String.Format(format:  "x{0}", arg0:  val_38);
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "[TEST] prefix: "("[TEST] prefix: ") + val_49);
        val_54;
        val_58 = null;
        val_58 = null;
        val_56 = null;
        val_57 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        label_66:
        val_51 = 1152921505272713216;
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  355260184, 丅不一丞丘丕丄丈丏:  val_57, 丅丅丞丙丁丕丌世东:  1);
        label_23:
        if((355260184 & 1) != 0)
        {
                val_59 = null;
            if(val_12 < (StoreKitEventListener.丒丕丗丑丕且丌丁丂.GetLowerBound(dimension:  0)))
        {
                val_60 = 0;
        }
        else
        {
                val_60;
            val_51 = 1152921505272713216;
        }
        
            val_61 = null;
            if(val_12 < (StoreKitEventListener.丒丕丗丑丕且丌丁丂.GetLowerBound(dimension:  0)))
        {
                val_62;
        }
        else
        {
                val_62 = 0;
        }
        
            StoreKitEventListener.丘万万丅丘丟丛丈业(丅丞丂丟丟且丅丆丅:  丛上丌丂业七不三世.productId, 世丕丅与丆丄丗丐万:  355260184, 丑丁丐丏业丗一丏丈:  0);
            StoreKitEventListener.丏丐丛上三东丛丑丟();
            StoreKitEventListener.丛三一丞与专东丘一();
        }
        
        val_48 = 0;
        label_13:
        if((StoreKitEventListener.七与下上丗东东专丅(丛上丌丂业七不三世:  丛上丌丂业七不三世)) != false)
        {
                this.丐丆万丛丁丐东世丘(丛上丌丂业七不三世:  丛上丌丂业七不三世);
        }
        
        this.丑世丄丄下三丏丑七(丛上丌丂业七不三世:  丛上丌丂业七不三世, 丐丌三一且丒且丘东:  new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = 159, 丙丁丑丙丆丐丂业丈 = val_48}, 丗专丂上下上丙专业:  val_50, 丂业丛丕专丏丁丆东:  System.Convert.ToInt32(value:  0), 丆万一不丌且东丐丐:  val_46, 丂业丕业丂丅丙一丛:  val_49, 丂丈丗丄不丅丅丙丒:  val_2);
    }
    private void 丑世丄丄下三丏丑七(Prime31.GooglePurchase 丛上丌丂业七不三世, 一下丛与丛丛万万丏.丛丑丙丗下专东丝三 丐丌三一且丒且丘东, string 丗专丂上下上丙专业, int 丂业丛丕专丏丁丆东, string 丆万一不丌且东丐丐 = "", string 丂业丕业丂丅丙一丛 = "", InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        string val_40;
        string val_41;
        PGCompany.专丟专世丅丂丁且专 val_42;
        Prime31.GooglePurchase val_43;
        object val_44;
        var val_45;
        int val_47;
        int val_48;
        int val_49;
        string val_50;
        val_40 = 丆万一不丌且东丐丐;
        val_41 = 丗专丂上下上丙专业;
        val_42 = 丐丌三一且丒且丘东.丙丁丑丙丆丐丂业丈;
        val_43 = 丛上丌丂业七不三世;
        StoreKitEventListener.丝丝下不丗专丅丒下 val_1 = null;
        val_44 = val_1;
        val_1 = new StoreKitEventListener.丝丝下不丗专丅丒下();
        if(val_44 != null)
        {
                val_45 = val_44;
            .丛上丌丂业七不三世 = val_43;
        }
        else
        {
                val_45 = 16;
            mem[16] = val_43;
            val_43 = mem[16];
        }
        
        if((Prime31.GooglePurchaesFix.getPurchaseState(purchase:  val_43)) != 1)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  38);
        System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Boolean> val_6 = new System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Boolean>(object:  val_1, method:  System.Boolean StoreKitEventListener.丝丝下不丗专丅丒下::下世丄丒世丞丞丈东(Rilisoft.与丗丌丑专业丝丛丏 七丏丄丅丌业与且丙));
        var val_41 = 0;
        val_41 = val_41 + 1;
        decimal val_11 = StoreKitEventListener.世丌丝丝丕专且下丟(丆丂上丅丗丞丏丆丁:  0.priceAmountMicros);
        val_47 = mem[16].orderId;
        if(val_47 == null)
        {
                val_47 = System.String.alignConst;
        }
        
        Rilisoft.丝丄三业丙专丛与不.丘丄丁丄下丕东丏丈(丘丛丛丘丂丙且与丛:  val_47, 丕丆且丏业一三世丅:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid}), 丛丅丗世丗不丈下万:  Rilisoft.一丟专且三万丞丁丂.世丞丄下丌业丐丝三(万七上丁丄丘业丁丂:  0.productId), 七丒丐世世丘七丘丙:  0.priceCurrencyCode);
        val_48 = System.String.alignConst;
        if(丐丌三一且丒且丘东.丗业丛业丂丆丕丈一 == 1)
        {
            goto label_31;
        }
        
        val_49 = val_11.flags;
        val_50 = val_40;
        if(丐丌三一且丒且丘东.丗业丛业丂丆丕丈一 == 99999)
        {
            goto label_35;
        }
        
        val_48 = 丂业丕业丂丅丙一丛 + 一下丛与丛丛万万丏.三万丑不上丏上丁上(丐丌三一且丒且丘东:  new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = 丐丌三一且丒且丘东.丗业丛业丂丆丕丈一, 丙丁丑丙丆丐丂业丈 = val_42})(一下丛与丛丛万万丏.三万丑不上丏上丁上(丐丌三一且丒且丘东:  new 丛丑丙丗下专东丝三() {丗业丛业丂丆丕丈一 = 丐丌三一且丒且丘东.丗业丛业丂丆丕丈一, 丙丁丑丙丆丐丂业丈 = val_42}));
        goto label_35;
        label_31:
        val_49 = val_11.flags;
        val_50 = val_40;
        label_35:
        if((丂丈丗丄不丅丅丙丒 != null) && (丂丈丗丄不丅丅丙丒.Multiplier >= 1))
        {
                val_48 = System.String.Format(format:  "x{0}_", arg0:  丂丈丗丄不丅丅丙丒.Multiplier);
        }
        
        val_40 = val_48 + 0.productId + val_50;
        if((System.String.op_Equality(a:  丂业丕业丂丅丙一丛, b:  "x3_")) != false)
        {
                if((val_40.IndexOf(value:  "x3_", comparisonType:  4)) != 0)
        {
                val_40 = 丂业丕业丂丅丙一丛 + val_40;
        }
        
        }
        
        if(val_40.Length >= 50)
        {
                val_40 = val_40.Substring(startIndex:  0, length:  49);
        }
        
        UnityEngine.Debug.Log(message:  "[TEST] fullPurchaseIdField: "("[TEST] fullPurchaseIdField: ") + val_40);
        bool val_42 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  38);
        val_42 = val_42 ^ 1;
        PGCompany.Analytics.一业丗丆世世上丁且.下万丌丐世丘下丑且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丘专丈与三专丈丈专:  0.productId, 万丂且丕三丛一专与:  val_40, 万世丛丄丘丙丂万丟:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_49, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid}), 专丄丒丘丅七丂丟丙:  0.priceCurrencyCode, 万丅丏丈七丂丛一上:  val_42, 丂丈丗丄不丅丅丙丒:  丂丈丗丄不丅丅丙丒, 专丝东丕丝丈三丗丂:  val_41, 丂业丛丕专丏丁丆东:  丂业丛丕专丏丁丆东, 业丘丛专丗丛万专业:  mem[16].orderId);
        System.DateTime val_35 = System.DateTime.UtcNow;
        val_42 = val_35.dateData;
        decimal val_38 = System.Decimal.op_Implicit(value:  StoreKitEventListener.丁且丘丅丌丛下一丆(丘专丈与三专丈丈专:  0.productId));
        val_41 = val_38.lo;
        PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().业丏丗丐丂业东丂丗(下上丐丆丝丟丝丒不:  new System.DateTime() {dateData = val_42}, 丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_38.flags, hi = val_38.hi, lo = val_41, mid = val_38.mid});
        val_44 = mem[16].productId;
        StoreKitEventListener.一丕丌丗丝丗且且下(丅丞丂丟丟且丅丆丅:  val_44);
    }
    private void 丐丆万丛丁丐东世丘(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        Prime31.GooglePurchase val_22;
        object val_23;
        var val_24;
        var val_25;
        System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Object> val_27;
        val_22 = 丛上丌丂业七不三世;
        StoreKitEventListener.丂丒丝上丐丟丄下世 val_1 = null;
        val_23 = val_1;
        val_1 = new StoreKitEventListener.丂丒丝上丐丟丄下世();
        if(val_23 != null)
        {
                val_24 = val_23;
            .丛上丌丂业七不三世 = val_22;
        }
        else
        {
                val_24 = 16;
            mem[16] = val_22;
            val_22 = mem[16];
        }
        
        if((Prime31.GooglePurchaesFix.getPurchaseState(purchase:  val_22)) != 1)
        {
                return;
        }
        
        val_22 = new System.Version();
        val_22 = new System.Version(version:  Switcher.丑一丙丛七万丑丞丗());
        new System.Version() = new System.Version(major:  10, minor:  3, build:  2, revision:  123);
        if((System.Version.op_LessThanOrEqual(v1:  new System.Version(), v2:  new System.Version())) == true)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_27 = StoreKitEventListener.<>c.<>9__64_0;
        if(val_27 == null)
        {
                System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Object> val_7 = null;
            val_27 = val_7;
            val_7 = new System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Object>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StoreKitEventListener.<>c::丞且丒丗丆丛世丏七(Rilisoft.与丗丌丑专业丝丛丏 七丏丄丅丌业与且丙));
            StoreKitEventListener.<>c.<>9__64_0 = val_27;
        }
        
        Prime31.GoogleSkuInfo val_11 = System.Linq.Enumerable.FirstOrDefault<Prime31.GoogleSkuInfo>(source:  System.Linq.Enumerable.OfType<Prime31.GoogleSkuInfo>(source:  System.Linq.Enumerable.Select<Rilisoft.与丗丌丑专业丝丛丏, System.Object>(source:  this.下丌丂丘丕丕专下丁, selector:  val_7)), predicate:  new System.Func<Prime31.GoogleSkuInfo, System.Boolean>(object:  val_1, method:  System.Boolean StoreKitEventListener.丂丒丝上丐丟丄下世::丞与丛丁丐与不丞世(Prime31.GoogleSkuInfo 丏丛与丅丛丌万专丌)));
        if(val_11 != null)
        {
                decimal val_13 = System.Decimal.op_Implicit(value:  val_11.priceAmountMicros);
            decimal val_14 = System.Decimal.Divide(d1:  new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid}, d2:  new System.Decimal());
            val_23 = val_24.orderId;
            val_22 = Rilisoft.一丟专且三万丞丁丂.世丞丄下丌业丐丝三(万七上丁丄丘业丁丂:  val_11.productId);
            Rilisoft.丝丄三业丙专丛与不.丒丆丄丝丐专丞且丟(丘丛丛丘丂丙且与丛:  val_23, 丕丆且丏业一三世丅:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid}), 丛丅丗世丗不丈下万:  val_22, 七丒丐世世丘七丘丙:  val_11.priceCurrencyCode);
            return;
        }
        
        object[] val_20 = new object[1];
        val_20[0] = mem[16].productId;
        UnityEngine.Debug.LogErrorFormat(format:  "SendFirs_tTimePayment: sku == null, productId = {0}", args:  val_20);
    }
    private void 不丘下且丒不且丆丒(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        System.Collections.Generic.HashSet<Prime31.GooglePurchase> val_17;
        var val_18;
        int val_19;
        var val_20;
        val_17 = this.丆东丆业丄东三丕下;
        bool val_1 = val_17.Add(item:  丛上丌丂业七不三世);
        if(this.丙丒丁七下上专丅丈 == true)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.三丑丁丂丏丝不业东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void StoreKitEventListener::丝不丆丝丌丒万丄丗(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        string val_3 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_19 = System.String.alignConst;
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七()) != null)
        {
                if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七().Handshake) != null)
        {
                val_19 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丛且丈世下下丂丏七().Handshake.Sid;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_13 = null;
        val_17 = val_13;
        val_13 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if(val_17 != null)
        {
                val_13.Add(key:  "uid", value:  val_3);
        }
        else
        {
                val_13.Add(key:  "uid", value:  val_3);
        }
        
        val_13.Add(key:  "sid", value:  val_19);
        if((System.String.IsNullOrEmpty(value:  val_19)) != false)
        {
                val_13.Add(key:  "response_fail", value:  1);
        }
        
        UnityEngine.Debug.Log(message:  "[InAppSocket] CheckSocketAuthAndProvideGoogleInapp");
        val_20 = null;
        val_20 = null;
        int val_16 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.三丑丁丂丏丝不业东, 一丐丗丁丞丆丅丟丄:  val_13);
        this.丙丒丁七下上专丅丈 = true;
    }
    private void 丝不丆丝丌丒万丄丗(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_9;
        var val_16;
        if(不丅丕丏下丏万丁丅 != null)
        {
                if((不丅丕丏下丏万丁丅.ContainsKey(key:  "status")) != false)
        {
                if((不丅丕丏下丏万丁丅.Item["status"] & 1) != 0)
        {
            goto label_4;
        }
        
        }
        
        }
        
        label_4:
        UnityEngine.Debug.Log(message:  "[InAppSocket] HandleAuthCheckResponse isAuthorized: "("[InAppSocket] HandleAuthCheckResponse isAuthorized: ") + 0.ToString());
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
        {
            goto label_19;
        }
        
        if((0 == 0) || (this.丆东丆业丄东三丕下.Count < 1))
        {
            goto label_29;
        }
        
        HashSet.Enumerator<T> val_7 = this.丆东丆业丄东三丕下.GetEnumerator();
        label_15:
        if((356463840 & 1) == 0)
        {
            goto label_14;
        }
        
        this.丄东丛下丝丗万下三(丛上丌丂业七不三世:  val_9.丐丏七丌丕丗业且上());
        goto label_15;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_29;
        label_19:
        if((0 == 0) || (this.东万丏丕且丕下丕丁.Count < 1))
        {
            goto label_29;
        }
        
        HashSet.Enumerator<T> val_12 = this.东万丏丕且丕下丕丁.GetEnumerator();
        label_25:
        if((356463808 & 1) == 0)
        {
            goto label_24;
        }
        
        ConfiguredValueTaskAwaiter val_13 = 0.GetAwaiter();
        val_13._value._obj.业丈丈不上丗一专世(丛丌丗丄三丞业与与:  val_13._value._obj, 万丄丅丝三丈丆世丟:  val_13._value._token);
        goto label_25;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_29:
        val_16 = null;
        val_16 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.三丑丁丂丏丝不业东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void StoreKitEventListener::丝不丆丝丌丒万丄丗(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        this.丆东丆业丄东三丕下.Clear();
        this.东万丏丕且丕下丕丁.Clear();
        this.丙丒丁七下上专丅丈 = false;
    }
    private void 丄东丛下丝丗万下三(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        StoreKitEventListener.丞丙丛丂上一丆丛万 val_1 = new StoreKitEventListener.丞丙丛丂上一丆丛万();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丛上丌丂业七不三世 = 丛上丌丂业七不三世;
        string[] val_2 = new string[2];
        string val_3 = (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丛上丌丂业七不三世.orderId;
        if(val_2 == null)
        {
            goto label_5;
        }
        
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_3 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_2[0] = val_3;
        val_2[1] = (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丛上丌丂业七不三世.productId;
        .丂业丄世世丂不丞丅 = Progress.上七丆与丐三丐丝万.且丝三万七且下世且(丁丆丆丛丟丕丐专丘:  val_2);
        if((Progress.七七世万专丕丁上业.丙七且丕丟丐丙世丈().丟不下下且业丛丄丏(下七丈下丕七丘丑丄:  (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丂业丄世世丂不丞丅)) != false)
        {
                UnityEngine.Debug.Log(message:  "[InAppSocket] ValidateAndroidPurchaseSocket Contains: "("[InAppSocket] ValidateAndroidPurchaseSocket Contains: ") + (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丂业丄世世丂不丞丅);
            StoreKitEventListener.一世东且丟一丙丌丂(丛上丌丂业七不三世:  (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丛上丌丂业七不三世, 丝丏丛世丞一丞丐丒:  true);
            bool val_10 = StoreKitEventListener.丑不且一且丙丟三丅.Remove(item:  (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丛上丌丂业七不三世.productId);
            return;
        }
        
        .业丘丛专丗丛万专业 = (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丂业丄世世丂不丞丅;
        .三东与丄上世丒丞丝 = (StoreKitEventListener.丞丙丛丂上一丆丛万)[1152921539323363152].丛上丌丂业七不三世.purchaseToken;
        .下三丐丙下丛东专丞 = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  val_1, method:  System.Void StoreKitEventListener.丞丙丛丂上一丆丛万::一七丆丆与东丌丑东(System.Collections.Generic.Dictionary<string, object> 上丌丛不业与世丑丏));
        .丐丒丙业丕丞一一丄 = new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丞丙丛丂上一丆丛万::丟专七三丕不七丅丄());
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丛丌专丐丛丆丑上(东丞丒丙世丏三下丟:  new Progress.丙丆丞丆一丏一丁业());
    }
    private void 丒丛丐丐丛世且丘业(Prime31.GooglePurchase 丛上丌丂业七不三世, string 下七丈下丕七丘丑丄)
    {
        StoreKitEventListener.丆丟专丕东丗业丌丕 val_1 = new StoreKitEventListener.丆丟专丕东丗业丌丕();
        .丛上丌丂业七不三世 = 丛上丌丂业七不三世;
        UnityEngine.Debug.Log(message:  "[InAppSocket] ProvideAndroidPurchaseSocket: "("[InAppSocket] ProvideAndroidPurchaseSocket: ") + 下七丈下丕七丘丑丄);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  146);
        uint val_6 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丕丞与丒丒丝世不(业丏丈世世世丞丒世:  new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丆丟专丕东丗业丌丕::丑丗丂丛丅丂业与万()), 丁丒丗与丝世丁与且:  2, 丞丐丟三丌与丞上一:  9);
        uint val_9 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丕丞与丒丒丝世不(业丏丈世世世丞丒世:  new System.Action(object:  val_1, method:  System.Void StoreKitEventListener.丆丟专丕东丗业丌丕::上丒专三丙丛七丑丙()), 丁丒丗与丝世丁与且:  1, 丞丐丟三丌与丞上一:  0);
        Progress.下丁下丂七丆丙七一 val_10 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_10.丞七三世丙世万丑丐(丂业丄世世丂不丞丅:  下七丈下丕七丘丑丄, 丆丟与东业三业丅丏:  (StoreKitEventListener.丆丟专丕东丗业丌丕)[1152921539323637120].丛上丌丂业七不三世.productId, 一丐丗丁丞丆丅丟丄:  (StoreKitEventListener.丆丟专丕东丗业丌丕)[1152921539323637120].丛上丌丂业七不三世.purchaseToken);
        val_10.丙丐万丅丁丗且上且(丛上丌丂业七不三世:  (StoreKitEventListener.丆丟专丕东丗业丌丕)[1152921539323637120].丛上丌丂业七不三世);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void 丙丐万丅丁丗且上且(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_24 = 1152921504833470464;
        UnityEngine.Debug.Log(message:  "[TEST] productId:"("[TEST] productId:") + 丛上丌丂业七不三世.productId);
        InappRememberedBonus val_4 = PGCompany.丌与丛丕业丈不丐世.丟丐丘且东丂丅业丆(丘专丈与三专丈丈专:  丛上丌丂业七不三世.productId);
        一下丛与丛丛万万丏.万上丝丕不丟丑丑专(丅丞丂丟丟且丅丆丅:  丛上丌丂业七不三世.productId, 丂丈丗丄不丅丅丙丒:  val_4);
        if(val_4 != null)
        {
                丛丑丙丗下专东丝三 val_6 = 一下丛与丛丛万万丏.丘一丛丑丈丁丑丅三(丂丈丗丄不丅丅丙丒:  val_4);
            string val_7 = StoreKitEventListener.且业丒丂下业丐丝世(不丌一丄东丝丏且丗:  val_6.丗业丛业丂丆丕丈一, 丂丈丗丄不丅丅丙丒:  val_4);
            string val_8 = StoreKitEventListener.丟东不丁万万丒丂丌(丂丈丗丄不丅丅丙丒:  val_4);
            StoreKitEventListener.丈万且丄且丗丙丏与();
            StoreKitEventListener.丛丝丙丌三丑丗万万(丘专丈与三专丈丈专:  丛上丌丂业七不三世.productId);
            业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
        }
        else
        {
                string val_11 = 丛上丌丂业七不三世.productId;
            System.ValueTuple<System.Boolean, System.Int32> val_12 = val_11.丗专东丙上下丙丝丐(丅丞丂丟丟且丅丆丅:  val_11);
            if((val_12.Item2 & 255) != 0)
        {
                val_25 = null;
            val_25 = null;
            if(((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丛上丌丂业七不三世.productId)) & 2147483648) != 0)
        {
                val_26 = null;
            val_26 = null;
            int val_17 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丛上丌丂业七不三世.productId);
        }
        
            UnityEngine.Debug.Log(message:  "StoreKitEve_ntListener.HandleGooglePurch_aseSucceeded(): Consuming Goole product "("StoreKitEve_ntListener.HandleGooglePurch_aseSucceeded(): Consuming Goole product ") + 丛上丌丂业七不三世.productId);
        }
        
            业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
            StoreKitEventListener.且上丗三丄丂丏丅上(丘专丈与三专丈丈专:  丛上丌丂业七不三世.productId);
        }
        
        val_27 = 0;
        val_28 = 1152921505272713216;
        StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        if(0 == 1)
        {
            goto label_40;
        }
        
        if((val_27 == 0) || (268 == 268))
        {
            goto label_42;
        }
        
        label_43:
        val_23 = ???;
        val_27 = ???;
        val_28 = ???;
        val_24 = ???;
        label_40:
        if(val_27 != 0)
        {
            goto label_43;
        }
        
        label_42:
        var val_22 = val_23 - 48;
    }
    private void 且丑三七业丟万丅世(Prime31.GooglePurchase 丛上丌丂业七不三世, 一丒丟世下丌一丏丌 三七丑三丝丏丙丘丁)
    {
        null = null;
        if((StoreKitEventListener.丙丑上丗丝东业业丏.Contains(item:  丛上丌丂业七不三世.orderId)) != false)
        {
                return;
        }
        
        if(CoroutineRunner.Instance != 0)
        {
                UnityEngine.Coroutine val_7 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丈上丒下一上丄东丕(丛上丌丂业七不三世:  丛上丌丂业七不三世, 丛丌丗丄三丞业与与:  0, 万一下七丈丈丗世丐:  ""));
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "AddCurrency_AndConsumeNextGoogleP_layPurchase CoroutineRunner.Instance == null ");
        this.不丘下且丒不且丆丒(丛上丌丂业七不三世:  丛上丌丂业七不三世);
    }
    private void 丅三与丟专丘东且丝(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        string val_16;
        object val_17;
        if((Prime31.GooglePurchaesFix.getPurchaseState(purchase:  丛上丌丂业七不三世)) == 2)
        {
                StoreKitEventListener.丙丁丞丄丂丟丙业东(丙业与丙丗丝不丈东:  false);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "HandleGoogl_ePurchaseSucceeded: "("HandleGoogl_ePurchaseSucceeded: ") + 丛上丌丂业七不三世);
        val_16 = 1152921505164300288;
        if(coinsShop.世丞三丑一丈三世丗() == false)
        {
            goto label_8;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_36;
        }
        
        val_17 = "Cheating attempt.";
        goto label_25;
        label_8:
        if(coinsShop.丘业上丙丘丑丆丝业() == false)
        {
            goto label_17;
        }
        
        if(丛上丌丂业七不三世 == null)
        {
            goto label_18;
        }
        
        val_16 = 丛上丌丂业七不三世.originalJson;
        goto label_19;
        label_17:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_36;
        }
        
        val_17 = "Hosts tampering attempt.";
        goto label_25;
        label_18:
        val_16 = 0.originalJson;
        label_19:
        if((this.丅丌世上丅丁丏上丝(丏东丒丄丟一东丈丟:  val_16, 丗丈丈丞丟丟丈丙业:  丛上丌丂业七不三世.signature)) == false)
        {
            goto label_26;
        }
        
        if((StoreKitEventListener.万丈不丑丙丘万丈丘(下丟丙丒丝丆丏与业:  丛上丌丂业七不三世.orderId)) == false)
        {
            goto label_30;
        }
        
        Prime31.GoogleIAB.consumeProduct(sku:  丛上丌丂业七不三世.productId);
        return;
        label_26:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_36;
        }
        
        val_17 = "Purchase verification failed.";
        label_25:
        UnityEngine.Debug.LogError(message:  val_17);
        label_36:
        丌上丑丌丘丛丏三丏(丛上丌丂业七不三世:  丛上丌丂业七不三世);
        return;
        label_30:
        System.Action<Prime31.GooglePurchase, 一丒丟世下丌一丏丌> val_15 = new System.Action<Prime31.GooglePurchase, 一丒丟世下丌一丏丌>(object:  this, method:  System.Void StoreKitEventListener::且丑三七业丟万丅世(Prime31.GooglePurchase 丛上丌丂业七不三世, 一丒丟世下丌一丏丌 三七丑三丝丏丙丘丁));
        val_15.且丑丟三丗东不丘丙(丛上丌丂业七不三世:  丛上丌丂业七不三世, 业丏丈世世世丞丒世:  val_15);
    }
    private bool 丅丌世上丅丁丏上丝(string 丏东丒丄丟一东丈丟, string 丗丈丈丞丟丟丈丙业)
    {
        return (bool)this.业一丟丏丞丏丑三丐.世三丞丅丑丌丈丈一().VerifyData(buffer:  System.Text.Encoding.UTF8, halg:  this.丏丛丌丈专东丞丘丁.世三丞丅丑丌丈丈一(), signature:  System.Convert.FromBase64String(s:  丗丈丈丞丟丟丈丙业));
    }
    private void 一丐丄丁万丞与丟丐(Prime31.GooglePurchase 丛上丌丂业七不三世)
    {
        Prime31.GooglePurchase val_7;
        System.Collections.Generic.HashSet<Prime31.GooglePurchase> val_8;
        val_7 = 丛上丌丂业七不三世;
        StoreKitEventListener.丘丈万一丅东一上万 val_1 = new StoreKitEventListener.丘丈万一丅东一上万();
        if(val_1 != null)
        {
                .丛上丌丂业七不三世 = val_7;
        }
        else
        {
                mem[16] = val_7;
            val_7 = mem[16];
        }
        
        UnityEngine.Debug.Log(message:  "consumePurcha_seSucceededEvent: "("consumePurcha_seSucceededEvent: ") + val_7);
        val_8 = this.与专丒丑丞丐丄上丄;
        if((val_8.RemoveWhere(match:  new System.Predicate<Prime31.GooglePurchase>(object:  val_1, method:  System.Boolean StoreKitEventListener.丘丈万一丅东一上万::丄丒丆丒不丅丌丆一(Prime31.GooglePurchase 七丏丄丅丌业与且丙)))) == 0)
        {
                val_8 = this.丁丗丙三丆丄万上丛;
            int val_6 = val_8.RemoveWhere(match:  new System.Predicate<Prime31.GooglePurchase>(object:  val_1, method:  System.Boolean StoreKitEventListener.丘丈万一丅东一上万::三专上丌丆丙丏世丕(Prime31.GooglePurchase 七丏丄丅丌业与且丙)));
        }
        
        this.与下且丑上丕下丒上();
    }
    private void 丁丆丌丌丌专上丕丛(string 丂七东不不丈一丐不)
    {
        UnityEngine.Debug.LogWarning(message:  "consumePurc_haseFailedEvent: "("consumePurc_haseFailedEvent: ") + 丂七东不不丈一丐不);
    }
    private System.Collections.IEnumerator 丏三三丆丈上丟三不(float 七且丆丞丌丘下世丑)
    {
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new StoreKitEventListener.专七七丞丈专与丆丒(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 丈上丒下一上丄东丕(Prime31.GooglePurchase 丛上丌丂业七不三世, com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与, string 万一下七丈丈丗世丐 = "")
    {
        StoreKitEventListener.丕一丏丑专七万丞不 val_1 = new StoreKitEventListener.丕一丏丑专七万丞不(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丛丌丗丄三丞业与与 = 丛丌丗丄三丞业与与;
            .丝且与丝丒丟万丁专 = this;
            .丛上丌丂业七不三世 = 丛上丌丂业七不三世;
        }
        else
        {
                mem[48] = this;
            mem[32] = 丛上丌丂业七不三世;
            mem[40] = 丛丌丗丄三丞业与与;
        }
        
        .万一下七丈丈丗世丐 = 万一下七丈丈丗世丐;
        return (System.Collections.IEnumerator)val_1;
    }
    private static void 一世东且丟一丙丌丂(Prime31.GooglePurchase 丛上丌丂业七不三世, bool 丝丏丛世丞一丞丐丒 = True)
    {
        string val_13;
        System.Collections.Generic.List<System.Object> val_14;
        var val_15;
        if(丛上丌丂业七不三世 != null)
        {
                StoreKitEventListener.且丑东丗一丛世丗丂();
            val_14 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Android.GooglePlayOrderIdsKey"));
            val_14 = null;
            val_14 = new System.Collections.Generic.List<System.Object>();
            Prime31.GoogleIAB.consumeProduct(sku:  丛上丌丂业七不三世.productId);
            System.Collections.Generic.HashSet<System.String> val_6 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.OfType<System.String>(source:  null));
            bool val_8 = null.Add(item:  丛上丌丂业七不三世.orderId);
            val_13 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  null));
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[Rilisoft] Saving consumed order ids: "("[Rilisoft] Saving consumed order ids: ") + val_13);
        }
        
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Android.GooglePlayOrderIdsKey", 下下丏一丙不丘丌丞:  val_13);
            if(丝丏丛世丞一丞丐丒 == false)
        {
                return;
        }
        
            val_15 = null;
            val_15 = null;
            StoreKitEventListener.丆丕丝丒不丙且丐丗.丐丗业丑丝丛与丏丝(丛上丌丂业七不三世:  丛上丌丂业七不三世);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "GooglePlayCon_sumeAndSave: purchase == null");
    }
    private static System.Security.Cryptography.RSACryptoServiceProvider 丛七丏丝七丄丌一业()
    {
        System.Security.Cryptography.RSACryptoServiceProvider val_1 = new System.Security.Cryptography.RSACryptoServiceProvider();
        val_1.FromXmlString(xmlString:  "<RSAKeyValue><Modulus>oTzMTaqsFhaywvCFKawFwL5KM+djLJfOCT/rbGQRfHmHYmOY2sBMgDWsA/67Szx6EVTZPVlFzHMgkAq1TwdL/A5aYGpGzaCX7o96cyp8R6wSF+xCuj++LAkTaDnLW0veI2bke3EVHu3At9xgM46e+VDucRUqQLvf6SQRb15nuflY5i08xKnewgX7I4U2H0RvAZDyoip+qZPmI4ZvaufAfc0jwZbw7XGiV41zibY3LU0N57mYKk51Wx+tOaJ7Tkc9Rl1qVCTjb+bwXshTqhVXVP6r4kabLWw/8OJUh0Sm69lbps6amP7vPy571XjscCTMLfXQan1959rHbNgkb2mLLQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
        return val_1;
    }
    private void 下不丁丆丝丝丝丙丐()
    {
        var val_122;
        var val_124;
        var val_126;
        var val_128;
        var val_130;
        var val_132;
        var val_134;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_1 != null)
        {
                val_1.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_1.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_1.Add(key:  "type", value:  "Not defined");
        val_1.Add(key:  "price", value:  "$ 0.99");
        if(val_1 != null)
        {
                val_1.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_1.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_1.Add(key:  "price_currency_code", value:  "руб.");
        if(val_1 != null)
        {
                val_1.Add(key:  "productId", value:  "coin1");
        }
        else
        {
                val_1.Add(key:  "productId", value:  "coin1");
        }
        
        val_1.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_3 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_1));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_5 != null)
        {
                val_5.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_5.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_5.Add(key:  "type", value:  "Not defined");
        val_5.Add(key:  "price", value:  "$ 4.99");
        if(val_5 != null)
        {
                val_5.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_5.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_5.Add(key:  "price_currency_code", value:  "руб.");
        if(val_5 != null)
        {
                val_5.Add(key:  "productId", value:  "coin2");
        }
        else
        {
                val_5.Add(key:  "productId", value:  "coin2");
        }
        
        val_5.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_7 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_5));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_9 != null)
        {
                val_9.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_9.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_9.Add(key:  "type", value:  "Not defined");
        val_9.Add(key:  "price", value:  "$ 9.99");
        if(val_9 != null)
        {
                val_9.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_9.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_9.Add(key:  "price_currency_code", value:  "руб.");
        if(val_9 != null)
        {
                val_9.Add(key:  "productId", value:  "coin3.");
        }
        else
        {
                val_9.Add(key:  "productId", value:  "coin3.");
        }
        
        val_9.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_11 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_9));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_13 != null)
        {
                val_13.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_13.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_13.Add(key:  "type", value:  "Not defined");
        val_13.Add(key:  "price", value:  "$ 19.99");
        if(val_13 != null)
        {
                val_13.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_13.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_13.Add(key:  "price_currency_code", value:  "руб.");
        if(val_13 != null)
        {
                val_13.Add(key:  "productId", value:  "coin4");
        }
        else
        {
                val_13.Add(key:  "productId", value:  "coin4");
        }
        
        val_13.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_15 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_13));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_17 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_17 != null)
        {
                val_17.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_17.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_17.Add(key:  "type", value:  "Not defined");
        val_17.Add(key:  "price", value:  "$ 49.99");
        if(val_17 != null)
        {
                val_17.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_17.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_17.Add(key:  "price_currency_code", value:  "руб.");
        if(val_17 != null)
        {
                val_17.Add(key:  "productId", value:  "coin5");
        }
        else
        {
                val_17.Add(key:  "productId", value:  "coin5");
        }
        
        val_17.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_19 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_17));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_21 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_21 != null)
        {
                val_21.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_21.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_21.Add(key:  "type", value:  "Not defined");
        val_21.Add(key:  "price", value:  "$ 2.99");
        if(val_21 != null)
        {
                val_21.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_21.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_21.Add(key:  "price_currency_code", value:  "руб.");
        if(val_21 != null)
        {
                val_21.Add(key:  "productId", value:  "coin7");
        }
        else
        {
                val_21.Add(key:  "productId", value:  "coin7");
        }
        
        val_21.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_23 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_21));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_25 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_25 != null)
        {
                val_25.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_25.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_25.Add(key:  "type", value:  "Not defined");
        val_25.Add(key:  "price", value:  "$ 99.99");
        if(val_25 != null)
        {
                val_25.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_25.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_25.Add(key:  "price_currency_code", value:  "руб.");
        if(val_25 != null)
        {
                val_25.Add(key:  "productId", value:  "coin8");
        }
        else
        {
                val_25.Add(key:  "productId", value:  "coin8");
        }
        
        val_25.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_27 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_25));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_29 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_29 != null)
        {
                val_29.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        else
        {
                val_29.Add(key:  "description", value:  "Test coin product for editor in Google edition");
        }
        
        val_29.Add(key:  "type", value:  "Not defined");
        val_29.Add(key:  "price", value:  "99 руб.");
        if(val_29 != null)
        {
                val_29.Add(key:  "price_amount_micros", value:  99000000);
        }
        else
        {
                val_29.Add(key:  "price_amount_micros", value:  99000000);
        }
        
        val_29.Add(key:  "price_currency_code", value:  "руб.");
        if(val_29 != null)
        {
                val_29.Add(key:  "productId", value:  "coin9");
        }
        else
        {
                val_29.Add(key:  "productId", value:  "coin9");
        }
        
        val_29.Add(key:  "title", value:  "Average pack of coins");
        Rilisoft.丈丝业丅丒丅丄丞七 val_31 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_29));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_33 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_33 != null)
        {
                val_33.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_33.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_33.Add(key:  "type", value:  "Not defined");
        val_33.Add(key:  "price", value:  "$ 0.99");
        if(val_33 != null)
        {
                val_33.Add(key:  "price_amount_micros", value:  990000);
        }
        else
        {
                val_33.Add(key:  "price_amount_micros", value:  990000);
        }
        
        val_33.Add(key:  "price_currency_code", value:  "$");
        if(val_33 != null)
        {
                val_33.Add(key:  "productId", value:  "gem1");
        }
        else
        {
                val_33.Add(key:  "productId", value:  "gem1");
        }
        
        val_33.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_35 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_33));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_37 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_37 != null)
        {
                val_37.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_37.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_37.Add(key:  "type", value:  "Not defined");
        val_37.Add(key:  "price", value:  "$ 2.99");
        if(val_37 != null)
        {
                val_37.Add(key:  "price_amount_micros", value:  2990000);
        }
        else
        {
                val_37.Add(key:  "price_amount_micros", value:  2990000);
        }
        
        val_37.Add(key:  "price_currency_code", value:  "$");
        if(val_37 != null)
        {
                val_37.Add(key:  "productId", value:  "gem2");
        }
        else
        {
                val_37.Add(key:  "productId", value:  "gem2");
        }
        
        val_37.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_39 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_37));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_41 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_41 != null)
        {
                val_41.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_41.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_41.Add(key:  "type", value:  "Not defined");
        val_41.Add(key:  "price", value:  "$ 4.99");
        if(val_41 != null)
        {
                val_41.Add(key:  "price_amount_micros", value:  4990000);
        }
        else
        {
                val_41.Add(key:  "price_amount_micros", value:  4990000);
        }
        
        val_41.Add(key:  "price_currency_code", value:  "$");
        if(val_41 != null)
        {
                val_41.Add(key:  "productId", value:  "gem3");
        }
        else
        {
                val_41.Add(key:  "productId", value:  "gem3");
        }
        
        val_41.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_43 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_41));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_45 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_45 != null)
        {
                val_45.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_45.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_45.Add(key:  "type", value:  "Not defined");
        val_45.Add(key:  "price", value:  "$ 9.99");
        if(val_45 != null)
        {
                val_45.Add(key:  "price_amount_micros", value:  9990000);
        }
        else
        {
                val_45.Add(key:  "price_amount_micros", value:  9990000);
        }
        
        val_45.Add(key:  "price_currency_code", value:  "$");
        if(val_45 != null)
        {
                val_45.Add(key:  "productId", value:  "gem4");
        }
        else
        {
                val_45.Add(key:  "productId", value:  "gem4");
        }
        
        val_45.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_47 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_45));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_49 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_49 != null)
        {
                val_49.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_49.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_49.Add(key:  "type", value:  "Not defined");
        val_49.Add(key:  "price", value:  "$ 19.99");
        if(val_49 != null)
        {
                val_49.Add(key:  "price_amount_micros", value:  19990000);
        }
        else
        {
                val_49.Add(key:  "price_amount_micros", value:  19990000);
        }
        
        val_49.Add(key:  "price_currency_code", value:  "$");
        if(val_49 != null)
        {
                val_49.Add(key:  "productId", value:  "gem5");
        }
        else
        {
                val_49.Add(key:  "productId", value:  "gem5");
        }
        
        val_49.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_51 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_49));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_53 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_53 != null)
        {
                val_53.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_53.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_53.Add(key:  "type", value:  "Not defined");
        val_53.Add(key:  "price", value:  "$ 49.99");
        if(val_53 != null)
        {
                val_53.Add(key:  "price_amount_micros", value:  49990000);
        }
        else
        {
                val_53.Add(key:  "price_amount_micros", value:  49990000);
        }
        
        val_53.Add(key:  "price_currency_code", value:  "$");
        if(val_53 != null)
        {
                val_53.Add(key:  "productId", value:  "gem6");
        }
        else
        {
                val_53.Add(key:  "productId", value:  "gem6");
        }
        
        val_53.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_55 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_53));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_57 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_57 != null)
        {
                val_57.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_57.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_57.Add(key:  "type", value:  "Not defined");
        val_57.Add(key:  "price", value:  "$ 99.99");
        if(val_57 != null)
        {
                val_57.Add(key:  "price_amount_micros", value:  99990000);
        }
        else
        {
                val_57.Add(key:  "price_amount_micros", value:  99990000);
        }
        
        val_57.Add(key:  "price_currency_code", value:  "$");
        if(val_57 != null)
        {
                val_57.Add(key:  "productId", value:  "gem7");
        }
        else
        {
                val_57.Add(key:  "productId", value:  "gem7");
        }
        
        val_57.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_59 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_57));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_61 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_61 != null)
        {
                val_61.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_61.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_61.Add(key:  "type", value:  "Not defined");
        val_61.Add(key:  "price", value:  "$ 0.99");
        if(val_61 != null)
        {
                val_61.Add(key:  "price_amount_micros", value:  990000);
        }
        else
        {
                val_61.Add(key:  "price_amount_micros", value:  990000);
        }
        
        val_61.Add(key:  "price_currency_code", value:  "$");
        if(val_61 != null)
        {
                val_61.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 32);
        }
        else
        {
                val_61.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 32);
        }
        
        val_61.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_63 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_61));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_65 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_65 != null)
        {
                val_65.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_65.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_65.Add(key:  "type", value:  "Not defined");
        val_65.Add(key:  "price", value:  "$ 2.99");
        if(val_65 != null)
        {
                val_65.Add(key:  "price_amount_micros", value:  2990000);
        }
        else
        {
                val_65.Add(key:  "price_amount_micros", value:  2990000);
        }
        
        val_65.Add(key:  "price_currency_code", value:  "$");
        if(val_65 != null)
        {
                val_65.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 40);
        }
        else
        {
                val_65.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 40);
        }
        
        val_65.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_67 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_65));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_69 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_69 != null)
        {
                val_69.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_69.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_69.Add(key:  "type", value:  "Not defined");
        val_69.Add(key:  "price", value:  "$ 4.99");
        if(val_69 != null)
        {
                val_69.Add(key:  "price_amount_micros", value:  4990000);
        }
        else
        {
                val_69.Add(key:  "price_amount_micros", value:  4990000);
        }
        
        val_69.Add(key:  "price_currency_code", value:  "$");
        if(val_69 != null)
        {
                val_69.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 48);
        }
        else
        {
                val_69.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 48);
        }
        
        val_69.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_71 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_69));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_73 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_73 != null)
        {
                val_73.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_73.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_73.Add(key:  "type", value:  "Not defined");
        val_73.Add(key:  "price", value:  "$ 9.99");
        if(val_73 != null)
        {
                val_73.Add(key:  "price_amount_micros", value:  9990000);
        }
        else
        {
                val_73.Add(key:  "price_amount_micros", value:  9990000);
        }
        
        val_73.Add(key:  "price_currency_code", value:  "$");
        if(val_73 != null)
        {
                val_73.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 56);
        }
        else
        {
                val_73.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 56);
        }
        
        val_73.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_75 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_73));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_77 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_77 != null)
        {
                val_77.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_77.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_77.Add(key:  "type", value:  "Not defined");
        val_77.Add(key:  "price", value:  "$ 19.99");
        if(val_77 != null)
        {
                val_77.Add(key:  "price_amount_micros", value:  19990000);
        }
        else
        {
                val_77.Add(key:  "price_amount_micros", value:  19990000);
        }
        
        val_77.Add(key:  "price_currency_code", value:  "$");
        if(val_77 != null)
        {
                val_77.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 64);
        }
        else
        {
                val_77.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 64);
        }
        
        val_77.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_79 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_77));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_81 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_81 != null)
        {
                val_81.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_81.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_81.Add(key:  "type", value:  "Not defined");
        val_81.Add(key:  "price", value:  "$ 49.99");
        if(val_81 != null)
        {
                val_81.Add(key:  "price_amount_micros", value:  49990000);
        }
        else
        {
                val_81.Add(key:  "price_amount_micros", value:  49990000);
        }
        
        val_81.Add(key:  "price_currency_code", value:  "$");
        if(val_81 != null)
        {
                val_81.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 72);
        }
        else
        {
                val_81.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 72);
        }
        
        val_81.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_83 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_81));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_85 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_85 != null)
        {
                val_85.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_85.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_85.Add(key:  "type", value:  "Not defined");
        val_85.Add(key:  "price", value:  "$ 99.99");
        if(val_85 != null)
        {
                val_85.Add(key:  "price_amount_micros", value:  99990000);
        }
        else
        {
                val_85.Add(key:  "price_amount_micros", value:  99990000);
        }
        
        val_85.Add(key:  "price_currency_code", value:  "$");
        if(val_85 != null)
        {
                val_85.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 80);
        }
        else
        {
                val_85.Add(key:  "productId", value:  StoreKitEventListener.业万专三一丟且丘业 + 80);
        }
        
        val_85.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_87 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_85));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_89 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_89 != null)
        {
                val_89.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_89.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_89.Add(key:  "type", value:  "Not defined");
        val_89.Add(key:  "price", value:  "$ 0.99");
        if(val_89 != null)
        {
                val_89.Add(key:  "price_amount_micros", value:  990000);
        }
        else
        {
                val_89.Add(key:  "price_amount_micros", value:  990000);
        }
        
        val_89.Add(key:  "price_currency_code", value:  "$");
        if(val_89 != null)
        {
                val_89.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 32);
        }
        else
        {
                val_89.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 32);
        }
        
        val_89.Add(key:  "title", value:  "Average pack of gems");
        Rilisoft.丈丝业丅丒丅丄丞七 val_91 = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_89));
        System.Collections.Generic.Dictionary<System.String, System.Object> val_93 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_93 != null)
        {
                val_93.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_93.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_93.Add(key:  "type", value:  "Not defined");
        val_93.Add(key:  "price", value:  "$ 2.99");
        if(val_93 != null)
        {
                val_93.Add(key:  "price_amount_micros", value:  2990000);
        }
        else
        {
                val_93.Add(key:  "price_amount_micros", value:  2990000);
        }
        
        val_93.Add(key:  "price_currency_code", value:  "$");
        if(val_93 != null)
        {
                val_93.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 40);
        }
        else
        {
                val_93.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 40);
        }
        
        val_93.Add(key:  "title", value:  "Average pack of gems");
        val_122 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_93));
        var val_122 = 0;
        val_122 = val_122 + 1;
        val_122 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_97 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_97 != null)
        {
                val_97.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_97.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_97.Add(key:  "type", value:  "Not defined");
        val_97.Add(key:  "price", value:  "$ 4.99");
        if(val_97 != null)
        {
                val_97.Add(key:  "price_amount_micros", value:  4990000);
        }
        else
        {
                val_97.Add(key:  "price_amount_micros", value:  4990000);
        }
        
        val_97.Add(key:  "price_currency_code", value:  "$");
        if(val_97 != null)
        {
                val_97.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 48);
        }
        else
        {
                val_97.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 48);
        }
        
        val_97.Add(key:  "title", value:  "Average pack of gems");
        val_124 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_97));
        var val_123 = 0;
        val_123 = val_123 + 1;
        val_124 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_101 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_101 != null)
        {
                val_101.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_101.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_101.Add(key:  "type", value:  "Not defined");
        val_101.Add(key:  "price", value:  "$ 9.99");
        if(val_101 != null)
        {
                val_101.Add(key:  "price_amount_micros", value:  9990000);
        }
        else
        {
                val_101.Add(key:  "price_amount_micros", value:  9990000);
        }
        
        val_101.Add(key:  "price_currency_code", value:  "$");
        if(val_101 != null)
        {
                val_101.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 56);
        }
        else
        {
                val_101.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 56);
        }
        
        val_101.Add(key:  "title", value:  "Average pack of gems");
        val_126 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_101));
        var val_124 = 0;
        val_124 = val_124 + 1;
        val_126 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_105 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_105 != null)
        {
                val_105.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_105.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_105.Add(key:  "type", value:  "Not defined");
        val_105.Add(key:  "price", value:  "$ 19.99");
        if(val_105 != null)
        {
                val_105.Add(key:  "price_amount_micros", value:  19990000);
        }
        else
        {
                val_105.Add(key:  "price_amount_micros", value:  19990000);
        }
        
        val_105.Add(key:  "price_currency_code", value:  "$");
        if(val_105 != null)
        {
                val_105.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 64);
        }
        else
        {
                val_105.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 64);
        }
        
        val_105.Add(key:  "title", value:  "Average pack of gems");
        val_128 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_105));
        var val_125 = 0;
        val_125 = val_125 + 1;
        val_128 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_109 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_109 != null)
        {
                val_109.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_109.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_109.Add(key:  "type", value:  "Not defined");
        val_109.Add(key:  "price", value:  "$ 49.99");
        if(val_109 != null)
        {
                val_109.Add(key:  "price_amount_micros", value:  49990000);
        }
        else
        {
                val_109.Add(key:  "price_amount_micros", value:  49990000);
        }
        
        val_109.Add(key:  "price_currency_code", value:  "$");
        if(val_109 != null)
        {
                val_109.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 72);
        }
        else
        {
                val_109.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 72);
        }
        
        val_109.Add(key:  "title", value:  "Average pack of gems");
        val_130 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_109));
        var val_126 = 0;
        val_126 = val_126 + 1;
        val_130 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_113 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_113 != null)
        {
                val_113.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        else
        {
                val_113.Add(key:  "description", value:  "Test gem product for editor in Google edition");
        }
        
        val_113.Add(key:  "type", value:  "Not defined");
        val_113.Add(key:  "price", value:  "$ 99.99");
        if(val_113 != null)
        {
                val_113.Add(key:  "price_amount_micros", value:  99990000);
        }
        else
        {
                val_113.Add(key:  "price_amount_micros", value:  99990000);
        }
        
        val_113.Add(key:  "price_currency_code", value:  "$");
        if(val_113 != null)
        {
                val_113.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 80);
        }
        else
        {
                val_113.Add(key:  "productId", value:  StoreKitEventListener.下丕丄东与丙三丂丒 + 80);
        }
        
        val_113.Add(key:  "title", value:  "Average pack of gems");
        val_132 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_113));
        var val_127 = 0;
        val_127 = val_127 + 1;
        val_132 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_117 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_117 != null)
        {
                val_117.Add(key:  "description", value:  "Test starter pack product for editor in Google edition");
        }
        else
        {
                val_117.Add(key:  "description", value:  "Test starter pack product for editor in Google edition");
        }
        
        val_117.Add(key:  "type", value:  "Not defined");
        val_117.Add(key:  "price", value:  "33 руб.");
        if(val_117 != null)
        {
                val_117.Add(key:  "price_amount_micros", value:  33000000);
        }
        else
        {
                val_117.Add(key:  "price_amount_micros", value:  33000000);
        }
        
        val_117.Add(key:  "price_currency_code", value:  "руб.");
        string val_118 = StoreKitEventListener.丌业万丄丛丙不丑不();
        if(val_117 != null)
        {
                val_117.Add(key:  "productId", value:  val_118);
        }
        else
        {
                val_117.Add(key:  "productId", value:  val_118);
        }
        
        val_117.Add(key:  "title", value:  "First starter pack(android)");
        val_134 = 0;
        null = new Rilisoft.丈丝业丅丒丅丄丞七(丙丕下不丅世丈丆丄:  new Prime31.GoogleSkuInfo(dict:  val_117));
        var val_128 = 0;
        val_128 = val_128 + 1;
        val_134 = 2;
        this.下丌丂丘丕丕专下丁.Add(item:  null);
    }
    private void 且丑丟三丗东不丘丙(Prime31.GooglePurchase 丛上丌丂业七不三世, System.Action<Prime31.GooglePurchase, 一丒丟世下丌一丏丌> 业丏丈世世世丞丒世)
    {
        System.Collections.Generic.List<System.String> val_10;
        object val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 丛上丌丂业七不三世;
        if(((val_11 == null) || (val_11.purchaseToken == null)) || (val_11.productId == null))
        {
            goto label_3;
        }
        
        val_12 = null;
        val_12 = null;
        if((StoreKitEventListener.丙丑上丗丝东业业丏 == null) || (val_11.orderId == null))
        {
            goto label_11;
        }
        
        val_13 = null;
        val_13 = null;
        val_10 = StoreKitEventListener.丙丑上丗丝东业业丏;
        if((val_10.Contains(item:  val_11.orderId)) == false)
        {
            goto label_11;
        }
        
        object[] val_6 = new object[1];
        val_11 = val_11.orderId;
        val_6[0] = val_11;
        UnityEngine.Debug.LogFormat(format:  "listOfIdsForWhichX3WaitingCoroutinesRun contains orderId on validation start: {0}", args:  val_6);
        return;
        label_3:
        val_11 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "Validate_Android purchase == null || purchase.purchaseToken == null", args:  val_11);
        return;
        label_11:
        val_14 = null;
        val_14 = null;
        val_10 = StoreKitEventListener.丑不且一且丙丟三丅;
        val_10.Add(item:  val_11.productId);
        业丏丈世世世丞丒世.Invoke(arg1:  val_11, arg2:  1);
    }
    internal static bool 丙丞丂丛东丞丟七不()
    {
        var val_3 = null;
        float val_3 = StoreKitEventListener.丅丏世世丘且不丗丟;
        val_3 = UnityEngine.Time.realtimeSinceStartup - val_3;
        return (bool)(val_3 <= 1.25f) ? 1 : 0;
    }
    internal static string 丕上丆七丞七丐丘丞()
    {
        null = null;
        return (string)StoreKitEventListener.且丒专且丈一下丗上;
    }
    private static void 东丙丐丁丙丂丝丑丙(string 丙业与丙丗丝不丈东)
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        StoreKitEventListener.且丒专且丈一下丗上 = 丙业与丙丗丝不丈东;
        val_2 = StoreKitEventListener.不丑丙万丂丙丕丆丆;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = StoreKitEventListener.不丑丙万丂丙丕丆丆;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal static void 丈万且丄且丗丙丏与()
    {
        var val_2 = null;
        StoreKitEventListener.丅丏世世丘且不丗丟 = UnityEngine.Time.realtimeSinceStartup;
    }
    internal static void 丛丝丙丌三丑丗万万(string 丘专丈与三专丈丈专)
    {
        StoreKitEventListener.东丙丐丁丙丂丝丑丙(丙业与丙丗丝不丈东:  丘专丈与三专丈丈专);
    }
    private static bool 丆丐不上三专丝丌不()
    {
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return false;
        }
        
        return 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
    }
    internal static bool 东与丆东七丏丘丂与()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_9 = null;
            if(StoreKitEventListener.丆丐不上三专丝丌不() != false)
        {
                float val_4 = 丅且东丙业丏丛东丛.世丑下上丙丙世丅专();
            val_4 = UnityEngine.Time.realtimeSinceStartup - val_4;
            if(val_4 >= 0)
        {
                return (bool)val_10 & 1;
        }
        
            val_10 = coinsShop.不丗下丏丄丘丕七丗() ^ 1;
            return (bool)val_10 & 1;
        }
        
        }
        
        val_10 = 1;
        return (bool)val_10 & 1;
    }
    internal static void 一丕丌丗丝丗且且下(string 丅丞丂丟丟且丅丆丅)
    {
        string val_8;
        string val_9;
        val_8 = 丅丞丂丟丟且丅丆丅;
        if((丏丄丑上丛不丈且万.上三丏丌上丕丑丑丆().TryGetValue(key:  val_8, value: out  new System.Decimal())) == false)
        {
            goto label_4;
        }
        
        decimal val_3 = StoreKitEventListener.丞世丈一丛世不丒丂(一丁丟丅丈丌专丛万:  new System.Decimal());
        val_8 = val_3.flags;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_8, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal())) == false)
        {
            goto label_9;
        }
        
        val_9 = "paid_100";
        goto label_25;
        label_4:
        object[] val_5 = new object[1];
        val_5[0] = val_8;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find price for product {0}", args:  val_5);
        return;
        label_9:
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_8, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal())) != false)
        {
                val_9 = "paid_50";
        }
        else
        {
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_8, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal())) == false)
        {
                return;
        }
        
            val_9 = "paid_25";
        }
        
        label_25:
        Rilisoft.一丟专且三万丞丁丂.丅万丛丝丛丌与丕丟(丝丏业丅丈东业丝丒:  val_9, 丛东不丒丏丈丄且丕:  0, 丐七专丆丅七丆丘且:  0);
    }
    internal static string 且业丒丂下业丐丝世(一下丛与丛丛万万丏.上万丆丙丂丕万丒丑 不丌一丄东丝丏且丗, InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        if((不丌一丄东丝丏且丗 - 6) <= 5)
        {
                var val_10 = 106028864 + ((不丌一丄东丝丏且丗 - 6)) << 2;
            val_10 = val_10 + 106028864;
        }
        else
        {
                if(不丌一丄东丝丏且丗 == 21)
        {
                string val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丂丈丗丄不丅丅丙丒.WeaponId).三与丛丑且丐丈业丌();
        }
        else
        {
                if(丂丈丗丄不丅丅丙丒.IsPetCardsDirect == false)
        {
                return (string);
        }
        
            return System.String.Format(format:  "_{0}", arg0:  丂丈丗丄不丅丅丙丒.PetId);
        }
        
            "" = ;
            return (string);
        }
    
    }
    internal static string 丟东不丁万万丒丂丌(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        var val_7;
        var val_8;
        val_7 = 丂丈丗丄不丅丅丙丒;
        if(((丂丈丗丄不丅丅丙丒.EventCurrencies == null) || (丂丈丗丄不丅丅丙丒.EventCurrencies.Count < 1)) || (丂丈丗丄不丅丅丙丒.EventCurrencies.Item[0] == null))
        {
            goto label_11;
        }
        
        EventCurrency val_3 = 丂丈丗丄不丅丅丙丒.EventCurrencies.Item[0];
        if((System.String.op_Equality(a:  val_3.EventId, b:  "sniper_tournament")) == true)
        {
            goto label_8;
        }
        
        val_7 = 丂丈丗丄不丅丅丙丒.EventCurrencies.Item[0];
        if((System.String.op_Equality(a:  val_5.EventId, b:  "sniper2_roulette")) == false)
        {
            goto label_11;
        }
        
        label_8:
        val_8 = "Sniper_";
        return (string)val_8;
        label_11:
        val_8 = "";
        return (string)val_8;
    }
    internal static void 下与上三业丝且丂丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  StoreKitEventListener.不丑丙万丂丙丕丆丆, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(StoreKitEventListener.不丑丙万丂丙丕丆丆 != 1152921505272717376);
    
    }
    internal static void 丘东丒七业七专专业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  StoreKitEventListener.不丑丙万丂丙丕丆丆, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(StoreKitEventListener.不丑丙万丂丙丕丆丆 != 1152921505272717376);
    
    }
    internal static void 万万丞丟东丞丂丏三(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  StoreKitEventListener.专东丌下与丏丛丁丌, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(StoreKitEventListener.专东丌下与丏丛丁丌 != 1152921505272717384);
    
    }
    internal static void 丁东丝丄丄丑三与一(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  StoreKitEventListener.专东丌下与丏丛丁丌, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(StoreKitEventListener.专东丌下与丏丛丁丌 != 1152921505272717384);
    
    }
    internal static void 且上丗三丄丂丏丅上(string 丘专丈与三专丈丈专)
    {
        null = null;
        if(StoreKitEventListener.专东丌下与丏丛丁丌 == null)
        {
                return;
        }
        
        StoreKitEventListener.专东丌下与丏丛丁丌.Invoke(obj:  丘专丈与三专丈丈专);
    }
    internal static void 丆丂一丄丐丅丄东一(System.Action 七丒上且丝业业下七)
    {
        .七丒上且丝业业下七 = 七丒上且丝业业下七;
        if(coinsShop.七三丗丏丑丗三丆世() == false)
        {
            goto label_4;
        }
        
        label_18:
        (StoreKitEventListener.丕专不东丛不业丟与)[1152921539329215600].七丒上且丝业业下七.Invoke();
        return;
        label_4:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2)
        {
                if(Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅() == true)
        {
                return;
        }
        
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丟丕丕丌丈业丝丅丅(业丏丈世世世丞丒世:  new System.Action<System.Boolean>(object:  new StoreKitEventListener.丕专不东丛不业丟与(), method:  System.Void StoreKitEventListener.丕专不东丛不业丟与::丟下丗专一丆丕不丝(bool 丞且万不与业下丂丆)), 与且专丏丅世丐丐丑:  false);
            return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
            goto label_18;
        }
    
    }
    private void Awake()
    {
        null = null;
        StoreKitEventListener.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnDestroy()
    {
        null = null;
        StoreKitEventListener.丆丕丝丒不丙且丐丗 = 0;
    }
    private static string 丌业万丄丛丙不丑不()
    {
        return (string)(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2) ? "starterpack1andr" : "starterpack1";
    }
    internal static void 一万丟丌东丈丄三一(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  StoreKitEventListener.专与专丁与丅丂万丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(StoreKitEventListener.专与专丁与丅丂万丏 != 1152921505272717568);
    
    }
    internal static void 丛丈专丑上丙丕丗丝(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  StoreKitEventListener.专与专丁与丅丂万丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(StoreKitEventListener.专与专丁与丅丂万丏 != 1152921505272717568);
    
    }
    internal static bool 三丘丈不丝丕丞东丌()
    {
        null = null;
        return (bool)StoreKitEventListener.丕丕万世七丕专与丑;
    }
    internal static void 丙丁丞丄丂丟丙业东(bool 丙业与丙丗丝不丈东)
    {
        bool val_4;
        var val_5;
        val_4 = 丙业与丙丗丝不丈东;
        val_5 = null;
        val_5 = null;
        StoreKitEventListener.丕丕万世七丕专与丑 = val_4;
        if(((StoreKitEventListener.丕丕万世七丕专与丑 == true) ? 1 : 0) == ((StoreKitEventListener.丕丕万世七丕专与丑 == true) ? 1 : 0))
        {
                return;
        }
        
        val_5 = null;
        val_4 = StoreKitEventListener.专与专丁与丅丂万丏;
        if(val_4 == null)
        {
                return;
        }
        
        val_4.Invoke(obj:  StoreKitEventListener.丕丕万世七丕专与丑);
    }
    internal static string 业丟丄与专丄万丑上()
    {
        null = null;
        return (string)(丟丌丁且且世丈丈丟.丁丅不丝业丈丛丁七 == false) ? "elixirlite" : "elixir";
    }
    private static StoreKitEventListener()
    {
        string val_21;
        StoreKitEventListener.丒丁丐丙丐丈丕专世 = new string[0];
        string[] val_2 = new string[8];
        val_2[0] = "coin1";
        val_2[1] = "coin7";
        val_2[2] = "coin2";
        val_2[3] = "coin3.";
        val_2[4] = "coin4";
        val_2[5] = "coin5";
        val_2[6] = "coin8";
        val_2[7] = "coin9";
        StoreKitEventListener.业丝丐三上丈丛丂专 = val_2;
        string[] val_3 = new string[5];
        val_3[0] = "bigammopack";
        val_3[1] = "Fullhealth";
        val_3[2] = "crystalsword";
        val_3[3] = "MinerWeapon";
        val_3[4] = StoreKitEventListener.业丟丄与专丄万丑上();
        StoreKitEventListener.丘世与丄一丐丝下丛 = val_3;
        StoreKitEventListener.丑不且一且丙丟三丅 = new System.Collections.Generic.List<System.String>();
        StoreKitEventListener.丙丑上丗丝东业业丏 = new System.Collections.Generic.List<System.String>();
        StoreKitEventListener.丅丏世世丘且不丗丟 = -3.402823E+38f;
        StoreKitEventListener.丆丕丝丒不丙且丐丗 = 0;
        StoreKitEventListener.丆丈三丂东丘三丁丝 = "gem1";
        StoreKitEventListener.不丙丄丅丄业丝丞丂 = "gem2";
        StoreKitEventListener.丟丟不丗丅万专丐丁 = "gem3";
        StoreKitEventListener.丑丄丑丑丐与丙且且 = "gem4";
        StoreKitEventListener.与丝丕丐东丂丗东不 = "gem5";
        StoreKitEventListener.丆丕丞丛丑世世丈万 = "gem6";
        StoreKitEventListener.丐业万丙丑丝丏丁丟 = "gem7";
        StoreKitEventListener.丑丛丞丙丗丂丘丒上 = "starterpack2";
        StoreKitEventListener.丙丄丟丘丞丄专丝丕 = "starterpack4";
        StoreKitEventListener.丑丞丞丅丁丈业丝丄 = "starterpack6";
        StoreKitEventListener.丑七丈丂丗丅丄三丂 = "starterpack3";
        StoreKitEventListener.丐丌丙丁丈丅业丒丝 = "starterpack5";
        StoreKitEventListener.东丄丑专万下丘丗与 = "starterpack7";
        StoreKitEventListener.上丕世世丙东万且不 = "starterpack8";
        StoreKitEventListener.丝不东丅丅丂三且丑 = new int[7] {1, 3, 5, 10, 20, 50, 100};
        string[] val_8 = new string[7];
        if(val_8 == null)
        {
            goto label_42;
        }
        
        if("gem1" != null)
        {
            goto label_43;
        }
        
        goto label_46;
        label_42:
        label_43:
        label_46:
        val_8[0] = StoreKitEventListener.丆丈三丂东丘三丁丝;
        val_8[1] = StoreKitEventListener.不丙丄丅丄业丝丞丂;
        val_8[2] = StoreKitEventListener.丟丟不丗丅万专丐丁;
        val_8[3] = StoreKitEventListener.丑丄丑丑丐与丙且且;
        val_8[4] = StoreKitEventListener.与丝丕丐东丂丗东不;
        val_8[5] = StoreKitEventListener.丆丕丞丛丑世世丈万;
        val_8[6] = StoreKitEventListener.丐业万丙丑丝丏丁丟;
        StoreKitEventListener.丒丕丗丑丕且丌丁丂 = val_8;
        string[] val_9 = new string[7];
        val_9[0] = "cool_offer";
        val_9[1] = "good_offer";
        val_9[2] = "awesome_offer";
        val_9[3] = "super_offer";
        val_9[4] = "mega_offer";
        val_9[5] = "best_offer";
        val_9[6] = "ultimate_offer";
        StoreKitEventListener.业万专三一丟且丘业 = val_9;
        string[] val_10 = new string[7];
        val_10[0] = "cool_offer";
        val_10[1] = "good_offer";
        val_10[2] = "awesome_offer";
        val_10[3] = "super_offer";
        val_10[4] = "mega_offer";
        val_10[5] = "best_offer";
        val_10[6] = "ultimate_offer";
        StoreKitEventListener.下丕丄东与丙三丂丒 = val_10;
        string[] val_11 = new string[8];
        string val_12 = StoreKitEventListener.丌业万丄丛丙不丑不();
        if(val_11 == null)
        {
            goto label_110;
        }
        
        if(val_12 != null)
        {
            goto label_111;
        }
        
        goto label_114;
        label_110:
        if(val_12 == null)
        {
            goto label_114;
        }
        
        label_111:
        label_114:
        val_11[0] = val_12;
        val_11[1] = StoreKitEventListener.丑丛丞丙丗丂丘丒上;
        val_11[2] = StoreKitEventListener.丑七丈丂丗丅丄三丂;
        val_11[3] = StoreKitEventListener.丙丄丟丘丞丄专丝丕;
        val_11[4] = StoreKitEventListener.丐丌丙丁丈丅业丒丝;
        val_11[5] = StoreKitEventListener.丑丞丞丅丁丈业丝丄;
        val_11[6] = StoreKitEventListener.东丄丑专万下丘丗与;
        val_11[7] = StoreKitEventListener.上丕世世丙东万且不;
        StoreKitEventListener.丗丛丟丘下丙丞业丑 = val_11;
        StoreKitEventListener.丐丌丒丂丁世与与丕 = 与丂丏丛丞丞丒丟丄.万丑丐丙丏丘专丗业();
        StoreKitEventListener.丕丕万世七丕专与丑 = false;
        StoreKitEventListener.丌丗丆丟丈丆丝丝丄 = false;
        string[] val_14 = new string[5];
        val_14[0] = "Armory";
        val_14[1] = "Guns";
        val_14[2] = "Melee";
        val_14[3] = "Special";
        val_14[4] = "Gear";
        StoreKitEventListener.丈丁丐丌三丟与一丕 = val_14;
        StoreKitEventListener.丝丙丌且专丅东丞业 = new StoreKitEventListener.专丑丟专与三丕丗丁();
        System.Collections.Generic.Dictionary<System.String, System.String> val_16 = new System.Collections.Generic.Dictionary<System.String, System.String>(capacity:  23);
        if(val_16 != null)
        {
                val_16.Add(key:  "coin1", value:  "Small Stack of Coins");
        }
        else
        {
                val_16.Add(key:  "coin1", value:  "Small Stack of Coins");
        }
        
        val_16.Add(key:  "coin7", value:  "Medium Stack of Coins");
        if(val_16 != null)
        {
                val_16.Add(key:  "coin2", value:  "Big Stack of Coins");
        }
        else
        {
                val_16.Add(key:  "coin2", value:  "Big Stack of Coins");
        }
        
        val_16.Add(key:  "coin3.", value:  "Huge Stack of Coins");
        if(val_16 != null)
        {
                val_16.Add(key:  "coin4", value:  "Chest with Coins");
        }
        else
        {
                val_16.Add(key:  "coin4", value:  "Chest with Coins");
        }
        
        val_16.Add(key:  "coin5", value:  "Golden Chest with Coins");
        val_16.Add(key:  "coin8", value:  "Holy Grail");
        val_16.Add(key:  StoreKitEventListener.丆丈三丂东丘三丁丝, value:  "Few Gems");
        val_16.Add(key:  StoreKitEventListener.不丙丄丅丄业丝丞丂, value:  "Handful of Gems");
        val_16.Add(key:  StoreKitEventListener.丟丟不丗丅万专丐丁, value:  "Pile of Gems");
        val_16.Add(key:  StoreKitEventListener.丑丄丑丑丐与丙且且, value:  "Chest with Gems");
        val_16.Add(key:  StoreKitEventListener.与丝丕丐东丂丗东不, value:  "Treasure with Gems");
        val_16.Add(key:  StoreKitEventListener.丆丕丞丛丑世世丈万, value:  "Expensive Relic");
        val_16.Add(key:  StoreKitEventListener.丐业万丙丑丝丏丁丟, value:  "Safe with Gems");
        string val_17 = StoreKitEventListener.丌业万丄丛丙不丑不();
        if(val_16 != null)
        {
                val_16.Add(key:  val_17, value:  "Newbie Set");
        }
        else
        {
                val_16.Add(key:  val_17, value:  "Newbie Set");
        }
        
        val_16.Add(key:  "starterpack2", value:  "Golden Coins Extra Pack");
        if(val_16 != null)
        {
                val_16.Add(key:  StoreKitEventListener.丑七丈丂丗丅丄三丂, value:  "Trooper Set");
        }
        else
        {
                val_16.Add(key:  StoreKitEventListener.丑七丈丂丗丅丄三丂, value:  "Trooper Set");
        }
        
        val_16.Add(key:  "starterpack4", value:  "Gems Extra Pack");
        if(val_16 != null)
        {
                val_21 = StoreKitEventListener.丐丌丙丁丈丅业丒丝;
            val_16.Add(key:  val_21, value:  "Veteran Set");
        }
        else
        {
                val_21 = StoreKitEventListener.丐丌丙丁丈丅业丒丝;
            val_16.Add(key:  val_21, value:  "Veteran Set");
        }
        
        val_16.Add(key:  val_21, value:  "Mega Gems Pack");
        val_16.Add(key:  StoreKitEventListener.东丄丑专万下丘丗与, value:  "Hero Set");
        val_16.Add(key:  StoreKitEventListener.上丕世世丙东万且不, value:  "Winner Set");
        StoreKitEventListener.丌丕丕丝不与丒丛丈 = val_16;
        string[] val_18 = new string[11];
        val_18[0] = "bigammopack";
        val_18[1] = "Fullhealth";
        val_18[2] = "ironSword";
        val_18[3] = "MinerWeapon";
        val_18[4] = "steelAxe";
        val_18[5] = "spas";
        val_18[6] = StoreKitEventListener.业丟丄与专丄万丑上();
        val_18[7] = "glock";
        val_18[8] = "chainsaw";
        val_18[9] = "scythe";
        val_18[10] = "shovel";
        StoreKitEventListener.万一万专丛专丏丂丌 = val_18;
        string[] val_20 = new string[10];
        if(val_20 == null)
        {
            goto label_213;
        }
        
        if("ironSword" != null)
        {
            goto label_214;
        }
        
        goto label_217;
        label_213:
        label_214:
        label_217:
        val_20[0] = val_18[2];
        val_20[1] = val_18[3];
        val_20[2] = "steelAxe";
        val_20[3] = "woodenBow";
        val_20[4] = "combatrifle";
        val_20[5] = "spas";
        val_20[6] = "goldeneagle";
        val_20[7] = val_18[7];
        val_20[8] = val_18[8];
        val_20[9] = "famas";
        StoreKitEventListener.丒丝丝丒丗丙一且七 = val_20;
    }
    internal static bool 丝丝一丟丈三丂丌丁()
    {
        return 与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专();
    }
    public void ProvideContent()
    {
    
    }
    internal static decimal 丞世丈一丛世不丒丂(decimal 一丁丟丅丈丌专丛万)
    {
        var val_7;
        var val_8;
        if(((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Analytics.AccumulatedPayments")) != false) && ((丞东丑专丛丆丄丝世.丛丐东丟丛丘丁世丁(丞丕丒专一下丙业上:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Analytics.AccumulatedPayments"), 丙业与丙丗丝不丈东: out  new System.Decimal())) != false))
        {
                val_7 = 0;
            val_8 = 0;
        }
        else
        {
                val_8 = 0;
            val_7 = 0;
        }
        
        decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 一丁丟丅丈丌专丛万.flags, hi = 一丁丟丅丈丌专丛万.hi, lo = 一丁丟丅丈丌专丛万.lo, mid = 一丁丟丅丈丌专丛万.mid});
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Analytics.AccumulatedPayments", 下下丏一丙不丘丌丞:  val_4.flags.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
        return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
    }
    internal static void 丏丐丛上三东丛丑丟()
    {
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TEST] CheckIfFirstTimePayment(), Defs.IsPayingUser: {0}", arg0:  与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专()));
        if(与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专() == true)
        {
                return;
        }
        
        与丂丏丛丞丞丒丟丄.下专七丞一专丒丞一(丙业与丙丗丝不丈东:  true);
    }
    internal static int 且丗丑万丞三丟东丅()
    {
        int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  "ALLGems", defaultValue:  0);
        val_2 = val_2 + (UnityEngine.PlayerPrefs.GetInt(key:  "ALLCoins", defaultValue:  0));
        return (int)val_2;
    }
    internal static void 丛三一丞与专东丘一()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        UnityEngine.PlayerPrefs.SetString(key:  "Last Payment Time", value:  val_1.dateData);
        与丂丏丛丞丞丒丟丄.下专七丞一专丒丞一(丙业与丙丗丝不丈东:  true);
        UnityEngine.PlayerPrefs.SetString(key:  "Last Payment Time (Advertisement)", value:  val_1.dateData);
    }
    internal static void 丘万万丅丘丟丛丈业(string 丅丞丂丟丟且丅丆丅, int 世丕丅与丆丄丗丐万, int 丑丁丐丏业丗一丏丈)
    {
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        string val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        Rilisoft.TechnicalCloudInfo val_80;
        var val_81;
        int val_82;
        int val_83;
        var val_84;
        var val_85;
        if(Rilisoft.TryGuns_2_0_Controller.丁丈丐丏七业下丈一() != true)
        {
                val_65 = null;
            val_65 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_66 = null;
            val_66 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.丑丂丌丂丞下丘七丁() != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丐丞三丑丌丗下丞丐(丆三不业上东丟丛丑:  丅丞丂丟丟且丅丆丅);
        }
        
        }
        
        }
        
        val_67 = null;
        val_67 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 != 0)
        {
                val_68 = null;
            val_68 = null;
            if(GiftBannerWindow.丄丘七三上丕世丞业.IsShow != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丄丂丄丒丌与不丛丅(丆三不业上东丟丛丑:  丅丞丂丟丟且丅丆丅);
        }
        
        }
        
        if(世丕丅与丆丄丗丐万 >= 1)
        {
                val_69 = null;
            val_69 = null;
            上丑三丁丄丛丁万丑.丛且专丑丞丆丁丟业(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  世丕丅与丆丄丗丐万);
        }
        
        if(丑丁丐丏业丗一丏丈 >= 1)
        {
                val_70 = null;
            val_70 = null;
            上丑三丁丄丛丁万丑.丛且专丑丞丆丁丟业(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  丑丁丐丏业丗一丏丈);
        }
        
        val_71 = null;
        val_71 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_72 = ExperienceController.丞丞丘业东丙丏七丌().ToString();
        }
        else
        {
                val_72 = "Unknown";
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_15 = new System.Collections.Generic.Dictionary<System.String, System.String>(dictionary:  StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世());
        null.Add(key:  StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七不专丄东专业丙专(), value:  丅丞丂丟丟且丅丆丅);
        null.Add(key:  "Rank", value:  val_72);
        null.Add(key:  "Session number", value:  UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丐丂丅一丕丘丑丅丄(), defaultValue:  1).ToString());
        null.Add(key:  "Device model", value:  UnityEngine.SystemInfo.deviceModel);
        if(世丕丅与丆丄丗丐万 >= 1)
        {
                null.set_Item(key:  "SKU", value:  System.String.Format(format:  "{0} ({1})", arg0:  丅丞丂丟丟且丅丆丅, arg1:  世丕丅与丆丄丗丐万));
            Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "Gems Purchased " + StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘丛丆丕且丂业世丌(), 丛东不丒丏丈丄且丕:  null);
        }
        
        if(丑丁丐丏业丗一丏丈 >= 1)
        {
                null.set_Item(key:  "SKU", value:  System.String.Format(format:  "{0} ({1})", arg0:  丅丞丂丟丟且丅丆丅, arg1:  丑丁丐丏业丗一丏丈));
            Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "Coins Purchased " + StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘丛丆丕且丂业世丌(), 丛东不丒丏丈丄且丕:  null);
        }
        
        val_73 = null;
        val_73 = null;
        val_74 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丅丞丂丟丟且丅丆丅);
        if(val_74 != 1)
        {
            goto label_73;
        }
        
        val_75 = null;
        val_75 = null;
        val_74 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丅丞丂丟丟且丅丆丅);
        if(val_74 != 1)
        {
            goto label_73;
        }
        
        val_76 = null;
        val_76 = null;
        val_74 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业万专三一丟且丘业, value:  丅丞丂丟丟且丅丆丅);
        if(val_74 == 1)
        {
            goto label_76;
        }
        
        label_73:
        val_77 = null;
        val_77 = null;
        if(val_74 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
        {
                val_78 = null;
            val_78 = null;
            val_79 = null;
            System.Int32[] val_29 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_28)) << 2);
            val_79 = null;
            string val_65 = 与丂丏丛丞丞丒丟丄.丅不一业丐丞业丝丗;
            val_65 = (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_65, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + ((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + ((long)(int)(val_28)) << 2) + 32);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丅不一业丐丞业丝丗, 下下丏一丙不丘丌丞:  val_65, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_80 = UnityEngine.JsonUtility.FromJson<Rilisoft.TechnicalCloudInfo>(json:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY"));
            if(val_80 == null)
        {
                val_80 = new Rilisoft.TechnicalCloudInfo();
            val_80 = new Rilisoft.TechnicalCloudInfo();
        }
        
            int val_35 = System.Math.Max(val1:  new Rilisoft.TechnicalCloudInfo().TotalInapps, val2:  val_65);
            if(new Rilisoft.TechnicalCloudInfo().TotalInapps != val_35)
        {
                new Rilisoft.TechnicalCloudInfo().TotalInapps = val_35;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  new Rilisoft.TechnicalCloudInfo()));
        }
        
        }
        
        val_81 = null;
        val_81 = null;
        System.Int32[] val_38 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏 + (((long)(int)(val_28)) << 2);
        label_158:
        val_82 = UnityEngine.PlayerPrefs.GetInt(key:  "ALLGems", defaultValue:  0);
        val_83 = UnityEngine.PlayerPrefs.GetInt(key:  "ALLCoins", defaultValue:  0);
        if(世丕丅与丆丄丗丐万 >= 1)
        {
                val_82 = val_82 + 丅丂上丞上专一丗丏;
            UnityEngine.PlayerPrefs.SetInt(key:  "ALLGems", value:  val_82);
        }
        else
        {
                val_83 = val_83 + 丅丂上丞上专一丗丏;
            UnityEngine.PlayerPrefs.SetInt(key:  "ALLCoins", value:  val_83);
        }
        
        val_83 = val_82 + val_83;
        if((0 & 1) == 0)
        {
                if(世丕丅与丆丄丗丐万 >= 1)
        {
                val_82 = 与丂丏丛丞丞丒丟丄.丒下丛万不且丄丄丈() + 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_82, 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_82, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 世丕丅与丆丄丗丐万, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
            if(丑丁丐丏业丗一丏丈 >= 1)
        {
                string val_46 = 与丂丏丛丞丞丒丟丄.丒下丛万不且丄丄丈() + 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_46, 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_46, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 丑丁丐丏业丗一丏丈, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        }
        
        int val_50 = (UnityEngine.PlayerPrefs.GetInt(key:  "CountPaying", defaultValue:  0)) + 1;
        UnityEngine.PlayerPrefs.SetInt(key:  "CountPaying", value:  val_50);
        if(val_50 >= 1)
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "Paying_User", defaultValue:  0)) == 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "Paying_User", value:  1);
            FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Paying_User", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.Debug.Log(message:  "Paying_User detected.");
        }
        
            if(val_50 >= 2)
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "Paying_User_Dolphin", defaultValue:  0)) == 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "Paying_User_Dolphin", value:  1);
            FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Paying_User_Dolphin", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.Debug.Log(message:  "Paying_User_Dolphin detected.");
        }
        
            if(val_50 >= 4)
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "Paying_User_Whale", defaultValue:  0)) == 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "Paying_User_Whale", value:  1);
            FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Paying_User_Whale", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.Debug.Log(message:  "Paying_User_Whale detected.");
        }
        
        }
        
        }
        
        }
        
        if(val_83 >= 100)
        {
                if((UnityEngine.PlayerPrefs.GetInt(key:  "SendKit", defaultValue:  0)) == 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "SendKit", value:  1);
            FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Whale_detected", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.Debug.Log(message:  "Whale detected.");
        }
        
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  "confirmed_1st_time", defaultValue:  0)) == 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "confirmed_1st_time", value:  1);
            FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Purchase_confirmed_1st_time", 丗丟上上丒丐丗丞丙:  0);
            UnityEngine.Debug.Log(message:  "Purchase confirmed first time.");
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  "Active_loyal_users_payed_send", defaultValue:  0)) != 0)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  "PostFacebookCount", defaultValue:  0)) < 3)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  "PostVideo", defaultValue:  0)) < 1)
        {
                return;
        }
        
        FacebookController.丟丕且丏不丛东丛东(丝丏业丅丈东业丝丒:  "Active_loyal_users_payed", 丗丟上上丒丐丗丞丙:  0);
        UnityEngine.PlayerPrefs.SetInt(key:  "Active_loyal_users_payed_send", value:  1);
        return;
        label_76:
        val_84 = null;
        val_84 = null;
        if((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丗丛丟丘下丙丞业丑, value:  丅丞丂丟丟且丅丆丅)) == 1)
        {
                return;
        }
        
        val_85 = null;
        val_85 = null;
        System.Int32[] val_60 = 丏丄丑上丛不丈且万.丁万万丞万丆丗下七 + (((long)(int)(val_59)) << 2);
        goto label_158;
    }
    internal static StoreKitEventListener.专丑丟专与三丕丗丁 丄丙丂丝丄丌丗丂丅()
    {
        null = null;
        return (专丑丟专与三丕丗丁)StoreKitEventListener.丝丙丌且专丅东丞业;
    }
    internal Rilisoft.与丗丌丑专业丝丛丏 且下丕专丏丕丐丛丛(string 丘专丈与三专丈丈专)
    {
        .丘专丈与三专丈丈专 = 丘专丈与三专丈丈专;
        return System.Linq.Enumerable.FirstOrDefault<Rilisoft.与丗丌丑专业丝丛丏>(source:  this.下丌丂丘丕丕专下丁, predicate:  new System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Boolean>(object:  new StoreKitEventListener.三丘丙丐万丟一七一(), method:  System.Boolean StoreKitEventListener.三丘丙丐万丟一七一::丗丅丏丕业丕东丐上(Rilisoft.与丗丌丑专业丝丛丏 七丏丄丅丌业与且丙)));
    }
    internal static int 丁且丘丅丌丛下一丆(string 丘专丈与三专丈丈专)
    {
        var val_8;
        var val_9;
        var val_10;
        System.Int32[] val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_8 = null;
        val_8 = null;
        val_9 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丘专丈与三专丈丈专);
        if(val_9 == 1)
        {
            goto label_3;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = 丏丄丑上丛不丈且万.丟世下上不下丘丄丒;
        if(val_9 < 丏丄丑上丛不丈且万.丟世下上不下丘丄丒.Length)
        {
            goto label_23;
        }
        
        goto label_23;
        label_3:
        val_12 = null;
        val_12 = null;
        val_9 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丘专丈与三专丈丈专);
        if(val_9 == 1)
        {
            goto label_11;
        }
        
        val_13 = null;
        val_13 = null;
        val_11 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
        if(val_9 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
        {
            goto label_23;
        }
        
        goto label_23;
        label_11:
        val_14 = null;
        val_14 = null;
        val_9 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业万专三一丟且丘业, value:  丘专丈与三专丈丈专);
        if(val_9 == 1)
        {
            goto label_19;
        }
        
        val_15 = null;
        val_15 = null;
        val_11 = 丏丄丑上丛不丈且万.丄丞丆丟且丑万丕一;
        label_23:
        System.Int32[] val_4 = val_11 + (((long)(int)(val_3)) << 2);
        return (int)(丏丄丑上丛不丈且万.丄丞丆丟且丑万丕一 + ((long)(int)(val_3)) << 2) + 32;
        label_19:
        val_16 = null;
        val_16 = null;
        if((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丘专丈与三专丈丈专)) == 1)
        {
                return (int)(丏丄丑上丛不丈且万.丄丞丆丟且丑万丕一 + ((long)(int)(val_3)) << 2) + 32;
        }
        
        val_17 = null;
        val_17 = null;
        System.Int32[] val_6 = 丏丄丑上丛不丈且万.世丄不丁丈三丁且丑 + (((long)(int)(val_5)) << 2);
        return (int)(丏丄丑上丛不丈且万.丄丞丆丟且丑万丕一 + ((long)(int)(val_3)) << 2) + 32;
    }
    internal static bool 丞丈丞不不丕丗丗业(string 丘专丈与三专丈丈专)
    {
        var val_3;
        var val_4;
        if(丘专丈与三专丈丈专 != null)
        {
                val_3 = null;
            val_3 = null;
            var val_2 = ((System.Array.IndexOf<System.String>(array:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丘专丈与三专丈丈专)) != 1) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public StoreKitEventListener()
    {
        var val_13;
        System.Func<System.Security.Cryptography.SHA1Managed> val_15;
        this.丗一丕丘丅丛万万且 = new System.Threading.Tasks.TaskCompletionSource<com.amazon.device.iap.cpt.AmazonUserData>();
        this.东万丏丕且丕下丕丁 = new System.Collections.Generic.HashSet<System.ValueTuple<com.amazon.device.iap.cpt.PurchaseReceipt, System.String>>();
        this.下丌丂丘丕丕专下丁 = new System.Collections.Generic.List<Rilisoft.与丗丌丑专业丝丛丏>();
        this.丞万七且一与丁丑与 = new Prime31.GoogleSkuInfo[0];
        this.丁丗丙三丆丄万上丛 = new System.Collections.Generic.HashSet<Prime31.GooglePurchase>();
        this.与专丒丑丞丐丄上丄 = new System.Collections.Generic.HashSet<Prime31.GooglePurchase>();
        this.丙七专七丆丌丄丏丘 = new Rilisoft.丝丄丄不丏丘丝世丗(七丐丅专且专七三丆:  0);
        this.丆东丆业丄东三丕下 = new System.Collections.Generic.HashSet<Prime31.GooglePurchase>();
        val_13 = null;
        val_13 = null;
        val_15 = StoreKitEventListener.<>c.<>9__172_0;
        if(val_15 == null)
        {
                System.Func<System.Security.Cryptography.SHA1Managed> val_9 = null;
            val_15 = val_9;
            val_9 = new System.Func<System.Security.Cryptography.SHA1Managed>(object:  StoreKitEventListener.<>c.__il2cppRuntimeField_static_fields, method:  System.Security.Cryptography.SHA1Managed StoreKitEventListener.<>c::专丙丘丐丄丆丅世丕());
            StoreKitEventListener.<>c.<>9__172_0 = val_15;
        }
        
        this.丏丛丌丈专东丞丘丁 = new Rilisoft.七丞丞丅东丞专丙丝<System.Security.Cryptography.SHA1Managed>(丙丂丌且丌世丒丐三:  val_9);
        this.业一丟丏丞丏丑三丐 = new Rilisoft.七丞丞丅东丞专丙丝<System.Security.Cryptography.RSACryptoServiceProvider>(丙丂丌且丌世丒丐三:  new System.Func<System.Security.Cryptography.RSACryptoServiceProvider>(object:  0, method:  static System.Security.Cryptography.RSACryptoServiceProvider StoreKitEventListener::丛七丏丝七丄丌一业()));
    }

}
