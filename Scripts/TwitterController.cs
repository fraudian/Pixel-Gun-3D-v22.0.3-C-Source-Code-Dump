using UnityEngine;
internal sealed class TwitterController : MonoBehaviour
{
    // Fields
    internal static TwitterController 丆丕丝丒不丙且丐丗;
    internal static readonly System.Collections.Generic.Dictionary<FacebookController.上丘丟丂万东丟下丂, int> 丗丄丐丆丆业丏上丌;
    internal const int 专丄丈丝丄丌丝丗丏 = 7;
    internal const int 业万专东上丝丛与丁 = 3;
    internal const int 世丞丌丅丘丗专丙万 = 1;
    internal const int 丑一丆专上七丏丆丏 = 1;
    private const string 与丈丏不下丘业世上 = "Unknown";
    private string 丝丝万丛下三丘专丏;
    private static readonly Rilisoft.七丞丞丅东丞专丙丝<TwitterController.万丛丈丒丕丒东丆丂> 丛且丟丁丒丛专丅丝;
    private bool 专下东丅业丛不丐专;
    private float 丆不丄丆下不丕丈下;
    private const string 丘下丟上丗丐丅七丑 = "TwitterControllerStoryPostHistoryKey";
    private const string 上下专专一不专万丄 = "priority";
    private const string 丗丘丒丈专丘丕世与 = "time";
    private readonly System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丟丏丛专丌上丐七与;
    
    // Properties
    internal static bool 丛七上三丘丙丙上业 { get; }
    internal static bool 专东世丟丝丏上世丛 { get; set; }
    internal static bool 世一丌丝丟丈世下丑 { get; }
    internal static bool 丌丏业万丝丆下丑七 { get; }
    private static TwitterController.万丛丈丒丕丒东丆丂 丁与专丕上丅丝上丄 { get; }
    
    // Methods
    private void Awake()
    {
        null = null;
        TwitterController.丗丘丒丈专丘丕世与 = this;
    }
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  val_1);
        val_1.丕丛下丛丒丄丑丗丑();
        this.丑丟丁一丑丆丗丟丂();
    }
    internal static bool 丒丆世一与丁丛丐下()
    {
        if(TwitterController.下下丌万丞丅丌丏丕() == null)
        {
            
        }
    
    }
    internal static bool 丌丛且丑丈丈丅丗七()
    {
        Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if(val_1 != null)
        {
                return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  6);
        }
        
        return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  6);
    }
    internal static void 丌一丘丌万丂丅东业(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  6);
            return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  6);
    }
    internal void 丟不丆丂且三丅世专(System.Action 七丒上且丝业业下七, System.Action 丝丏丗丄丗与丐丌三, string 与且专丈不万东一万 = "Unknown")
    {
        if(new TwitterController.丕丛业丁丏下一七丘() != null)
        {
                .七丒上且丝业业下七 = 七丒上且丝业业下七;
        }
        else
        {
                mem[16] = 七丒上且丝业业下七;
        }
        
        .丝丏丗丄丗与丐丌三 = 丝丏丗丄丗与丐丌三;
    }
    public void Logout()
    {
    
    }
    internal void 丑与东丒七丁丝三丁(string 丝丝不丝上丂三丌世, FacebookController.上丘丟丂万东丟下丂 与丈丂一丌三丈丟丅)
    {
        if(new TwitterController.三丅丞丒丕丅专一丅() != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .与丈丂一丌三丈丟丅 = 与丈丂一丌三丈丟丅;
    }
    internal void 丑与东丒七丁丝三丁(string 丝丝不丝上丂三丌世, System.Action 丟不丌丁一丆业且丝)
    {
        if(new TwitterController.与丟业一丈上丅上不() != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丟不丌丁一丆业且丝 = 丟不丌丁一丆业且丝;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丟不丌丁一丆业且丝;
        }
        
        .丝丝不丝上丂三丌世 = 丝丝不丝上丂三丌世;
    }
    internal bool 不专下丒丌丒三丂丄(FacebookController.上丘丟丂万东丟下丂 与丈丂一丌三丈丟丅)
    {
        var val_12;
        上丘丟丂万东丟下丂 val_13;
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        val_13 = 与丈丂一丌三丈丟丅;
        if(val_13 == 0)
        {
            goto label_1;
        }
        
        val_12 = 0;
        val_14 = 0;
        goto label_2;
        label_8:
        if((this.丟丏丛专丌上丐七与.Item[0].Item["priority"] != null) && (null != null))
        {
                val_15 = 0;
        }
        
        var val_5 = ((System.Int32.Parse(s:  val_15)) == val_13) ? (val_14 + 1) : (val_14);
        val_12 = 1;
        label_2:
        if(val_12 < this.丟丏丛专丌上丐七与.Count)
        {
            goto label_8;
        }
        
        val_16 = null;
        val_16 = null;
        int val_7 = TwitterController.丗丄丐丆丆业丏上丌.Item[val_13];
        return (bool)val_18;
        label_1:
        val_13 = this.丟丏丛专丌上丐七与.Count;
        val_17 = null;
        val_17 = null;
        return (bool)val_18;
    }
    internal static void 业东丘丟世丁上丂三(string 与且专丈不万东一万)
    {
    
    }
    internal static bool 上业丗丛三丕丒丗丙()
    {
        return false;
    }
    internal static bool 丂丌与下丛丑丂丐丘()
    {
        return false;
    }
    private void 丏上丁专三丒丟丈丟(string 东且丁丆丛丁丏丘且)
    {
        var val_2 = null;
        TwitterController.业东丘丟世丁上丂三(与且专丈不万东一万:  null);
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "TwitterController.OnTwitterLogin(“{0}”)    {1}", arg0:  东且丁丆丛丁丏丘且, arg1:  this.丝丝万丛下三丘专丏));
        this.丝丝万丛下三丘专丏 = "Unknown";
    }
    private void 丙丒三丗不丑万丂东(string 丂七东不不丈一丐不)
    {
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "TwitterController.OnTwitterLoginFailed(“{0}”)    {1}", arg0:  丂七东不不丈一丐不, arg1:  this.丝丝万丛下三丘专丏));
        this.丝丝万丛下三丘专丏 = "Unknown";
    }
    private void 丂丄三丄丞丂丏且丒(object 东且丁丆丛丁丏丘且)
    {
        this.专下东丅业丛不丐专 = false;
        UnityEngine.Debug.Log(message:  "TwitterController: OnTwitterPost: "("TwitterController: OnTwitterPost: ") + 东且丁丆丛丁丏丘且);
    }
    private void 丟下丝丑丅丌三丙丞(string 且丛丏三且丞丛丒专)
    {
        this.专下东丅业丛不丐专 = false;
        UnityEngine.Debug.Log(message:  "TwitterController: OnTwitterPostFailed: "("TwitterController: OnTwitterPostFailed: ") + 且丛丏三且丞丛丒专);
    }
    private void 丞丗上丏且上丈丈丗(int 丒丘丕丂不三专丁世, int 丏上三上丙万丞上下, int 且与且丏丁丙丂三丞, int 不丟丂万万丞丈丄丒)
    {
        null = null;
        TwitterController.丗丄丐丆丆业丏上丌.set_Item(key:  0, value:  丒丘丕丂不三专丁世);
        TwitterController.丗丄丐丆丆业丏上丌.set_Item(key:  1, value:  丏上三上丙万丞上下);
        TwitterController.丗丄丐丆丆业丏上丌.set_Item(key:  2, value:  且与且丏丁丙丂三丞);
        TwitterController.丗丄丐丆丆业丏上丌.set_Item(key:  3, value:  不丟丂万万丞丈丄丒);
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                this.一上专丂丒丅专丄七();
            return;
        }
        
        this.丑丟丁一丑丆丗丟丂();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丆不丄丆下不丕丈下;
        if(val_1 <= 10f)
        {
                return;
        }
        
        this.丁丈丂专三三丞三丒();
    }
    private void OnDestroy()
    {
        this.一上专丂丒丅专丄七();
    }
    private void 一上专丂丒丅专丄七()
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "TwitterControllerStoryPostHistoryKey", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丟丏丛专丌上丐七与));
    }
    private void 丑丟丁一丑丆丗丟丂()
    {
        var val_6;
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = this;
        this.丟丏丛专丌上丐七与.Clear();
        List.Enumerator<T> val_4 = GetEnumerator();
        label_15:
        if((1675636288 & 1) == 0)
        {
            goto label_10;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        val_10 = 0;
        this.丟丏丛专丌上丐七与.Add(item:  null);
        goto label_15;
        label_10:
        val_11 = 0;
        val_12 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_22;
        }
        
        if(null == null)
        {
            goto label_26;
        }
        
        if(89 != 89)
        {
            goto label_24;
        }
        
        goto label_26;
        label_22:
        if(null == null)
        {
            goto label_26;
        }
        
        label_24:
        label_26:
        this.丁丈丂专三三丞三丒();
    }
    private void 丁丈丂专三三丞三丒()
    {
        this.丆不丄丆下不丕丈下 = UnityEngine.Time.realtimeSinceStartup;
        new TwitterController.丑丗东丞三且丂丄丒() = new System.Object();
        .丆与丁丄丈专专丁专 = 专七专下且专三一且.上且一丈丐三丄一丆() + 4294857087;
        System.Predicate<System.Collections.Generic.Dictionary<System.String, System.Object>> val_5 = new System.Predicate<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  new TwitterController.丑丗东丞三且丂丄丒(), method:  System.Boolean TwitterController.丑丗东丞三且丂丄丒::丄与一丛丒丞专丏丄(System.Collections.Generic.Dictionary<string, object> 三且丑东与丝丛丐丏));
        int val_6 = this.丟丏丛专丌上丐七与.RemoveAll(match:  null);
    }
    private void 丈七丞丂丏三世丆且(FacebookController.上丘丟丂万东丟下丂 与丈丂一丌三丈丟丅)
    {
    
    }
    private void 丕丛下丛丒丄丑丗丑()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "TwitterControllerStoryPostHistoryKey")) != false)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "TwitterControllerStoryPostHistoryKey", 下下丏一丙不丘丌丞:  "[]");
    }
    private static TwitterController()
    {
        System.Collections.Generic.Dictionary<上丘丟丂万东丟下丂, System.Int32> val_2 = new System.Collections.Generic.Dictionary<上丘丟丂万东丟下丂, System.Int32>(capacity:  4, comparer:  new FacebookController.业丁丂丏一丝上丞丕());
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  7);
            val_2.Add(key:  1, value:  3);
            val_2.Add(key:  2, value:  1);
        }
        else
        {
                val_2.Add(key:  0, value:  7);
            val_2.Add(key:  1, value:  3);
            val_2.Add(key:  2, value:  1);
        }
        
        val_2.Add(key:  3, value:  1);
        TwitterController.丗丄丐丆丆业丏上丌 = val_2;
        TwitterController.丛且丟丁丒丛专丅丝 = new Rilisoft.七丞丞丅东丞专丙丝<万丛丈丒丕丒东丆丂>(丙丂丌且丌世丒丐三:  new System.Func<万丛丈丒丕丒东丆丂>(object:  0, method:  static 万丛丈丒丕丒东丆丂 TwitterController::丕下下丂一下丅丑丅()));
    }
    private static TwitterController.万丛丈丒丕丒东丆丂 丕下下丂一下丅丑丅()
    {
        return (万丛丈丒丕丒东丆丂)new TwitterController.七丏丛下丞丅丏丝丝();
    }
    private static TwitterController.万丛丈丒丕丒东丆丂 下下丌万丞丅丌丏丕()
    {
        null = null;
        if(TwitterController.丛且丟丁丒丛专丅丝 != null)
        {
                return TwitterController.丛且丟丁丒丛专丅丝.世三丞丅丑丌丈丈一();
        }
        
        return TwitterController.丛且丟丁丒丛专丅丝.世三丞丅丑丌丈丈一();
    }
    public TwitterController()
    {
        this.丝丝万丛下三丘专丏 = "Unknown";
        this.丟丏丛专丌上丐七与 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
    }

}
