using UnityEngine;
public class ReviewController : MonoBehaviour
{
    // Fields
    internal const string 丞丆下丝与丆丈丟丟 = "keyNeedActiveReview";
    internal const string 丁丕世万丂丌丒丈丗 = "keyAlreadySendReview";
    internal const string 不丒一丗丏丒万丙丑 = "keyOldVersionForReview";
    internal const string 丙丛万丙不丆下丝与 = "keyNeedSendMsgReview";
    internal const string 丙不丑丌丈丂且丈不 = "keyReviewSaveRating";
    internal const string 业丗丙丑丞丛丗一丛 = "keyReviewSaveMsg";
    internal static ReviewController 丄丘七三上丕世丞业;
    internal static int 丝一丆丅世专东丌丞;
    internal static int 丁七且东东丙丙丙七;
    internal static bool 丂丄七专三世丙丌业;
    
    // Properties
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    internal static bool 一上丆丏丂专丟丌丒 { get; set; }
    internal static int 三丅丞下丝与上专丗 { get; set; }
    internal static string 且丒丞丛丂丅丑丄丒 { get; set; }
    internal static bool 丞丐丟丗丗丛丗丄丒 { get; set; }
    internal static bool 丅丝不丛丟下丙一不 { get; set; }
    
    // Methods
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    internal static bool 一丌丄一不丏与丙丗()
    {
        var val_4 = null;
        if((ReviewController.丁七且东东丙丙丙七 & 2147483648) != 0)
        {
                val_4 = null;
            val_4 = null;
            ReviewController.丁七且东东丙丙丙七 = Load.丗七与业丄万丗不丌(丒丘丏上丙丟丑丕丈:  "keyNeedSendMsgReview");
        }
        
        val_4 = null;
        return (bool)(ReviewController.丁七且东东丙丙丙七 == true) ? 1 : 0;
    }
    internal static void 丗丆丟丑丟三丁丘上(bool 丙业与丙丗丝不丈东)
    {
        var val_2;
        bool val_1 = 丙业与丙丗丝不丈东;
        Save.丌丂一丗丌世丞世下(丒丘丏上丙丟丑丕丈:  "keyNeedSendMsgReview", 三丂丏不三上上丏丝:  val_1);
        val_2 = null;
        val_2 = null;
        ReviewController.丁七且东东丙丙丙七 = val_1;
    }
    internal static int 不丕丏丝丝与上七上()
    {
        return Load.丙丄七且丄与丆万世(丒丘丏上丙丟丑丕丈:  "keyReviewSaveRating");
    }
    internal static void 丘丌上丂丐下三三丒(int 丙业与丙丗丝不丈东)
    {
        Save.丐丏丑丟丐丁上上丑(丒丘丏上丙丟丑丕丈:  "keyReviewSaveRating", 三丂丏不三上上丏丝:  丙业与丙丗丝不丈东);
    }
    internal static string 世丗上万三业与一丄()
    {
        return Load.丑丏丌丟丂丙不丄丞(丒丘丏上丙丟丑丕丈:  "keyReviewSaveMsg");
    }
    internal static void 丛丐一世丟丗丝业丕(string 丙业与丙丗丝不丈东)
    {
        Save.不丏丒丐世三万不丙(丒丘丏上丙丟丑丕丈:  "keyReviewSaveMsg", 三丂丏不三上上丏丝:  丙业与丙丗丝不丈东);
    }
    internal static bool 不丒丅丄下丄丌丒三()
    {
        return Load.丗七与业丄万丗不丌(丒丘丏上丙丟丑丕丈:  "keyAlreadySendReview");
    }
    internal static void 专丙不与丗丕丈业丂(bool 丙业与丙丗丝不丈东)
    {
        Save.丌丂一丗丌世丞世下(丒丘丏上丙丟丑丕丈:  "keyAlreadySendReview", 三丂丏不三上上丏丝:  丙业与丙丗丝不丈东);
    }
    internal static bool 丘丐丒丒三一丒丗丁()
    {
        var val_4 = null;
        if((ReviewController.丝一丆丅世专东丌丞 & 2147483648) != 0)
        {
                val_4 = null;
            val_4 = null;
            ReviewController.丝一丆丅世专东丌丞 = Load.丗七与业丄万丗不丌(丒丘丏上丙丟丑丕丈:  "keyNeedActiveReview");
        }
        
        val_4 = null;
        return (bool)(ReviewController.丝一丆丅世专东丌丞 == true) ? 1 : 0;
    }
    internal static void 丝丑与丑丈丌七丂七(bool 丙业与丙丗丝不丈东)
    {
        bool val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丙业与丙丗丝不丈东;
        val_7 = null;
        if(ReviewController.一丌丄一不丏与丙丗() != false)
        {
                if(val_6 == true)
        {
                return;
        }
        
        }
        
        val_8 = null;
        if(ReviewController.丘丐丒丒三一丒丗丁() ^ val_6 != false)
        {
                Save.丌丂一丗丌世丞世下(丒丘丏上丙丟丑丕丈:  "keyNeedActiveReview", 三丂丏不三上上丏丝:  val_6);
        }
        
        val_9 = null;
        val_6 = val_6;
        val_9 = null;
        ReviewController.丝一丆丅世专东丌丞 = val_6;
    }
    private void Awake()
    {
        null = null;
        ReviewController.丄丘七三上丕世丞业 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnDestroy()
    {
        null = null;
        ReviewController.丄丘七三上丕世丞业 = 0;
    }
    internal static void 七世丝东万不丂丈且()
    {
        var val_5;
        ExperienceController val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        val_6 = ExperienceController.sharedController;
        if(val_6 == 0)
        {
                return;
        }
        
        if(丟丌丁且且世丈丈丟.丟与丌丏丞丕丒丌丗() < 3)
        {
                return;
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() < 4)
        {
                return;
        }
        
        val_6 = 1152921505252638720;
        val_7 = null;
        if(ReviewController.不丒丅丄下丄丌丒三() != false)
        {
                return;
        }
        
        ReviewController.丝丑与丑丈丌七丂七(丙业与丙丗丝不丈东:  true);
    }
    internal static bool 一一上不东万世丂丘(int 丈丐世下丞与丂专丏, string 丄丝丁专丄丑丟三丆)
    {
        var val_2;
        FriendsController val_3;
        var val_4;
        ReviewController.丘丌上丂丐下三三丒(丙业与丙丗丝不丈东:  丈丐世下丞与丂专丏);
        ReviewController.丛丐一世丟丗丝业丕(丙业与丙丗丝不丈东:  丄丝丁专丄丑丟三丆);
        ReviewController.丗丆丟丑丟三丁丘上(丙业与丙丗丝不丈东:  true);
        if(丈丐世下丞与丂专丏 == 5)
        {
                return ReviewController.丞下丞丗专丟丟丙丒();
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = FriendsController.丄丞丁丈与业上丞丟;
        val_3.丌丛下丂丂丒丁三丘();
        return false;
    }
    private static bool 丞下丞丗专丟丟丙丒()
    {
        UnityEngine.RuntimePlatform val_1 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
        if(val_1 == 8)
        {
                return ReviewController.专下一且丘三且丘一();
        }
        
        if(val_1 == 11)
        {
                bool val_2 = ReviewController.丕丆丄丄丌丑丒丟丁();
            return false;
        }
        
        bool val_3 = ReviewController.万世丆丐丕丒丞丅丏();
        return false;
    }
    private static bool 专下一且丘三且丘一()
    {
        if((PGCompany.SKStoreReviewControllerManaged.IsRequestReviewSupported(iosVersion:  PGCompany.SKStoreReviewControllerManaged.IosVersion())) != false)
        {
                return ReviewController.丅丞业世丒丐丒丈丐();
        }
        
        bool val_3 = ReviewController.万世丆丐丕丒丞丅丏();
        return false;
    }
    private static bool 丕丆丄丄丌丑丒丟丁()
    {
        object val_16;
        var val_17;
        var val_18;
        string val_19;
        string val_20;
        var val_21;
        var val_22;
        int val_1 = 0;
        string val_2 = 0;
        if((PGCompany.丗丑三与专且丘丏世.丘丈丂丞丄丑一且丒(东且丁丆丛丁丏丘且: out  val_1, 丏丞专丏业丗丝七丝: out  val_2)) == false)
        {
            goto label_1;
        }
        
        if(val_1 <= 20)
        {
            goto label_2;
        }
        
        if(Infrastructure.丑不丅丘七与不丑三.下上上业一且丑东丟() == false)
        {
            goto label_3;
        }
        
        val_16 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_8 = val_16.StartCoroutine(routine:  Infrastructure.丑不丅丘七与不丑三.丑七不且上丗丁一世().世丑丆丗业丑万丗业());
        return false;
        label_1:
        val_17 = 1152921505252638720;
        val_18 = null;
        if(ReviewController.世丈且业丆丑丏丐一() == false)
        {
            goto label_15;
        }
        
        val_19 = val_2;
        val_20 = "[ReviewController.AskForNativeRatingAndroid] TryGetSdkVersion: ";
        goto label_12;
        label_2:
        val_17 = 1152921505252638720;
        val_21 = null;
        if(ReviewController.世丈且业丆丑丏丐一() == false)
        {
            goto label_15;
        }
        
        val_19 = val_1.ToString(provider:  ReviewController.丙专丝世不业下丂丈());
        val_20 = "[ReviewController.AskForNativeRatingAndroid] sdkVersion: ";
        label_12:
        val_16 = val_20 + val_19;
        UnityEngine.Debug.Log(message:  val_16);
        label_15:
        label_27:
        bool val_14 = ReviewController.万世丆丐丕丒丞丅丏();
        return false;
        label_3:
        val_22 = null;
        if(ReviewController.世丈且业丆丑丏丐一() == false)
        {
            goto label_27;
        }
        
        UnityEngine.Debug.Log(message:  "[ReviewController.AskForNativeRatingAndroid] NeedToRequest: false");
        goto label_27;
    }
    private static bool 万世丆丐丕丒丞丅丏()
    {
        UnityEngine.Application.OpenURL(url:  丄丛丏丄不一丆丐丑.丅丙业上丄不丘丝三());
        return false;
    }
    private static bool 丅丞业世丒丐丒丈丐()
    {
        PGCompany.SKStoreReviewControllerManaged.RequestReview();
        return true;
    }
    public ReviewController()
    {
    
    }
    private static ReviewController()
    {
        ReviewController.丄丘七三上丕世丞业 = 0;
        ReviewController.丝一丆丅世专东丌丞 = 0;
        ReviewController.丁七且东东丙丙丙七 = 0;
        ReviewController.丂丄七专三世丙丌业 = false;
    }

}
