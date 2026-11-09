using UnityEngine;
public class ClanChatController : MonoBehaviour
{
    // Fields
    internal static ClanChatController 丄丞丁丈与业上丞丟;
    private UnityEngine.Transform _chatsContainer;
    private UnityEngine.GameObject _generalChatGo;
    private UnityEngine.GameObject _clanChatButtonSelectedGo;
    private UnityEngine.GameObject _clanChatButtonNotSelectedGo;
    private UnityEngine.GameObject _clanPrivateChatButtonSelectedGo;
    private UnityEngine.GameObject _clanPrivateChatButtonNotSelectedGo;
    public UIButton chatSendButton;
    public UITable chatTable;
    public UIScrollView chatScrollView;
    private UIPanel 丄与丌丒与且丞上业;
    public UnityEngine.GameObject serviceMessagePrefab;
    public UnityEngine.GameObject stickersShopBanner;
    public UIInput chatInput;
    public UnityEngine.AudioClip sendMessageSound;
    private UIPanel _panelSmiles;
    private System.Collections.Generic.List<ChatController.丌丝丆三丟专万业丝> 丞丗丏丆丅不丑丄丒;
    private System.Collections.Generic.List<ClanServiceMessageItem> 三丑万上丟下世上丆;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private PrivateClanChatController 丛专丗与丗丟丄上七;
    private bool 丈不丕丑丘下丛丐下;
    private static System.Collections.Generic.List<string> 丏专丕丂丗上丕丝与;
    private static UnityEngine.Color[] 丄丄丗丄一下七丌七;
    private static System.Collections.Generic.Dictionary<string, int> 且三丅与不丑丐上三;
    private System.Comparison<UnityEngine.Transform> 丝丝世上与丙丗下丏;
    
    // Properties
    private static System.Collections.Generic.List<string> 丕丒丌丅丂丒丟丏丝 { get; }
    
    // Methods
    private static System.Collections.Generic.List<string> 丟丛与三丆丅丝丘丆()
    {
        System.Collections.Generic.List<TSource> val_5;
        var val_6;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        if(ClanChatController.丏专丕丂丗上丕丝与 == null)
        {
                ClanChatController.丏专丕丂丗上丕丝与 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<UnityEngine.Color, System.String>(source:  ClanChatController.丄丄丗丄一下七丌七, selector:  new System.Func<UnityEngine.Color, System.String>(object:  0, method:  static System.String ClanChatController::业丐丁丝丙且七丏丗(UnityEngine.Color 丁丂专业丁丅丅丈丙))));
            val_5 = ClanChatController.丏专丕丂丗上丕丝与;
            if(val_5.Count == 0)
        {
                val_8 = null;
            val_8 = null;
            val_5 = ClanChatController.丏专丕丂丗上丕丝与;
            val_5.Add(item:  "[FFDD03]");
        }
        
        }
        
        val_9 = null;
        val_9 = null;
        return (System.Collections.Generic.List<System.String>)ClanChatController.丏专丕丂丗上丕丝与;
    }
    private static string 业丐丁丝丙且七丏丗(UnityEngine.Color 丁丂专业丁丅丅丈丙)
    {
        UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 丁丂专业丁丅丅丈丙.r, g = 丁丂专业丁丅丅丈丙.g, b = 丁丂专业丁丅丅丈丙.b, a = 丁丂专业丁丅丅丈丙.a});
        return (string)System.String.Format(format:  "[{0}{1}{2}]", arg0:  val_1.r.ToString(format:  "X2"), arg1:  val_1.g.ToString(format:  "X2"), arg2:  val_1.b.ToString(format:  "X2"));
    }
    private void Awake()
    {
        this.丄与丌丒与且丞上业 = this.chatScrollView.gameObject.GetComponent<UIPanel>();
    }
    private void 丙丁丛上丅丅万世丐()
    {
        PrivateClanChatController val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Clan/PrivateClanChat")).GetComponent<PrivateClanChatController>();
        this.丛专丗与丗丟丄上七 = val_3;
        val_3.transform.SetParent(p:  this._chatsContainer);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.丛专丗与丗丟丄上七.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        this.丛专丗与丗丟丄上七.transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        this.丛专丗与丗丟丄上七.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丛专丗与丗丟丄上七, 丏业丟一东丂东丘丛:  false);
        this.丛专丗与丗丟丄上七.丞丌七丞丒丆丘丛丄 = this.stickersShopBanner;
        this.丙丈丆丒世专专不丛(丗不丛业丛丞世万专:  true, 丛丆丌不万丅业上丄:  false);
        this.丈不丕丑丘下丛丐下 = false;
    }
    private void Start()
    {
        null = null;
        ClanChatController.丄丞丁丈与业上丞丟 = this;
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void ClanChatController::且专丙丏丌万丙丟丏()));
        this.丙丁丛上丅丅万世丐();
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanChatController::U_Hide()), 与且专丈不万东一万:  "Clan Chat");
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丅丛与东七丙丟七丆());
    }
    private System.Collections.IEnumerator 丅丛与东七丙丟七丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanChatController.下丐一丕丟丄万丞丂();
    }
    public void U_Hide()
    {
        this.丆世与丑丆丅丐万且();
    }
    internal void 丆世与丑丆丅丐万且()
    {
        var val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<NotificationMessageController>.Instance) == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        ChatController.丐且且丈七不上丁丙 = 0;
        ChatController.丅丐丙丂丆东万丕下(丙业与丙丗丝不丈东:  0);
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnDestroy()
    {
        null = null;
        ClanChatController.丄丞丁丈与业上丞丟 = 0;
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void ClanChatController::且专丙丏丌万丙丟丏()));
    }
    public void OpenPrivateChat()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丛专丗与丗丟丄上七, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._generalChatGo, 丏业丟一东丂东丘丛:  false);
        this.丙丈丆丒世专专不丛(丗不丛业丛丞世万专:  false, 丛丆丌不万丅业上丄:  true);
    }
    public void OpenGeneralChat()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丛专丗与丗丟丄上七, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._generalChatGo, 丏业丟一东丂东丘丛:  true);
        this.丙丈丆丒世专专不丛(丗不丛业丛丞世万专:  true, 丛丆丌不万丅业上丄:  false);
    }
    private int 丑丟丝丌世丝丝丛丝(string 丄丒且丙三丆丟与丏)
    {
        var val_1;
        this.且且丛丛丏丙丈一丄(丞丅上丏丂且下丅与:  丄丒且丙三丆丟与丏);
        val_1 = null;
        val_1 = null;
        if(ClanChatController.且三丅与不丑丐上三 != null)
        {
                return ClanChatController.且三丅与不丑丐上三.Item[丄丒且丙三丆丟与丏];
        }
        
        return ClanChatController.且三丅与不丑丐上三.Item[丄丒且丙三丆丟与丏];
    }
    private void 且且丛丛丏丙丈一丄(string 丞丅上丏丂且下丅与)
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if((ClanChatController.且三丅与不丑丐上三.ContainsKey(key:  丞丅上丏丂且下丅与)) != false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        int val_2 = UnityEngine.Mathf.Abs(value:  丞丅上丏丂且下丅与);
        int val_4 = ClanChatController.丟丛与三丆丅丝丘丆().Count;
        ClanChatController.且三丅与不丑丐上三.Add(key:  丞丅上丏丂且下丅与, value:  val_2 - ((val_2 / val_4) * val_4));
    }
    internal bool 丏一丅丄丂丌且且丁()
    {
        if(this._generalChatGo.activeInHierarchy == false)
        {
                return false;
        }
        
        if(this._generalChatGo != null)
        {
                return this._generalChatGo.activeSelf;
        }
        
        return this._generalChatGo.activeSelf;
    }
    public void UpdateChatMessages(bool 丗丆丄世世万丛丆丈)
    {
        var val_72;
        var val_73;
        System.Func<业丙丅世丘东丛丄丕, System.String> val_75;
        var val_76;
        var val_77;
        System.Func<东业专世丟不专不丕, System.String> val_79;
        var val_80;
        System.Func<业丙丅世丘东丛丄丕, System.Boolean> val_81;
        var val_85;
        var val_86;
        var val_88;
        var val_89;
        System.Func<丌丝丆三丟专万业丝, System.Double> val_91;
        var val_92;
        var val_93;
        var val_94;
        var val_95;
        var val_96;
        var val_98;
        ClanChatController.专丏丌丏丑东万丝专 val_1 = new ClanChatController.专丏丌丏丑东万丝专();
        this.丞丗丏丆丅不丑丄丒.Clear();
        val_72 = null;
        val_72 = null;
        val_73 = null;
        val_73 = null;
        val_75 = ClanChatController.<>c.<>9__42_0;
        if(val_75 == null)
        {
                System.Func<业丙丅世丘东丛丄丕, System.String> val_2 = null;
            val_75 = val_2;
            val_2 = new System.Func<业丙丅世丘东丛丄丕, System.String>(object:  ClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ClanChatController.<>c::丘丘丞三七上丕上丟(ChatController.业丙丅世丘东丛丄丕 三丟东丕丄丄下下丑));
            ClanChatController.<>c.<>9__42_0 = val_75;
        }
        
        val_76 = null;
        val_76 = null;
        val_77 = null;
        val_77 = null;
        val_79 = ClanChatController.<>c.<>9__42_1;
        if(val_79 == null)
        {
                System.Func<东业专世丟不专不丕, System.String> val_4 = null;
            val_79 = val_4;
            val_4 = new System.Func<东业专世丟不专不丕, System.String>(object:  ClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ClanChatController.<>c::不专三三丙业丝且丅(东业专世丟不专不丕 三丟东丕丄丄下下丑));
            ClanChatController.<>c.<>9__42_1 = val_79;
        }
        
        .丗丟丞丅一丌七丙丄 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Except<System.String>(first:  System.Linq.Enumerable.Union<System.String>(first:  System.Linq.Enumerable.Select<业丙丅世丘东丛丄丕, System.String>(source:  ChatController.丑丈万一下丗丘丄丘, selector:  val_2), second:  System.Linq.Enumerable.Select<东业专世丟不专不丕, System.String>(source:  ChatController.下丗不丒世丑丁丒专, selector:  val_4)), second:  丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三().Keys));
        val_80 = null;
        val_80 = null;
        val_81 = (ClanChatController.专丏丌丏丑东万丝专)[1152921525715968224].丂丒丞专业世万丕丞;
        if(val_81 == null)
        {
                System.Func<业丙丅世丘东丛丄丕, System.Boolean> val_12 = null;
            val_81 = val_12;
            val_12 = new System.Func<业丙丅世丘东丛丄丕, System.Boolean>(object:  val_1, method:  System.Boolean ClanChatController.专丏丌丏丑东万丝专::丕丈丒丞万专丈七且(ChatController.业丙丅世丘东丛丄丕 三丟东丕丄丄下下丑));
            .丂丒丞专业世万丕丞 = val_81;
        }
        
        var val_75 = 0;
        val_75 = val_75 + 1;
        System.Collections.Generic.IEnumerator<T> val_15 = System.Linq.Enumerable.Where<业丙丅世丘东丛丄丕>(source:  ChatController.丙万专丗丈丅业丘丅, predicate:  val_12).GetEnumerator();
        label_40:
        var val_76 = 0;
        val_76 = val_76 + 1;
        if(val_15.MoveNext() == false)
        {
            goto label_32;
        }
        
        var val_77 = 0;
        val_77 = val_77 + 1;
        bool val_21 = System.String.op_Equality(a:  val_19 + 24, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        if(val_21 == true)
        {
            goto label_40;
        }
        
        val_21.丕七三丅丞丞与丒七(丄丙下丝丛丒七丂丘:  val_15.Current);
        goto label_40;
        label_32:
        val_85 = 0;
        val_86 = 0;
        if(val_15 == null)
        {
            
        }
        else
        {
                var val_78 = 0;
            val_78 = val_78 + 1;
            val_15.Dispose();
        }
        
        val_88 = null;
        val_88 = null;
        ChatController.丙万专丗丈丅业丘丅.Clear();
        this.丞丗丏丆丅不丑丄丒.AddRange(collection:  System.Linq.Enumerable.OfType<丌丝丆三丟专万业丝>(source:  System.Linq.Enumerable.Where<业丙丅世丘东丛丄丕>(source:  ChatController.丑丈万一下丗丘丄丘, predicate:  new System.Func<业丙丅世丘东丛丄丕, System.Boolean>(object:  val_1, method:  System.Boolean ClanChatController.专丏丌丏丑东万丝专::丝丏丑丆下丛丅丙丟(ChatController.业丙丅世丘东丛丄丕 三丟东丕丄丄下下丑)))));
        this.丞丗丏丆丅不丑丄丒.AddRange(collection:  System.Linq.Enumerable.OfType<丌丝丆三丟专万业丝>(source:  ChatController.上丕万丂丕丏丟丞丙));
        this.丞丗丏丆丅不丑丄丒.AddRange(collection:  System.Linq.Enumerable.OfType<丌丝丆三丟专万业丝>(source:  System.Linq.Enumerable.Where<东业专世丟不专不丕>(source:  ChatController.下丗不丒世丑丁丒专, predicate:  new System.Func<东业专世丟不专不丕, System.Boolean>(object:  val_1, method:  System.Boolean ClanChatController.专丏丌丏丑东万丝专::且与丅丈丞丘丈专丅(东业专世丟不专不丕 三丟东丕丄丄下下丑)))));
        val_89 = null;
        val_89 = null;
        val_91 = ClanChatController.<>c.<>9__42_4;
        if(val_91 == null)
        {
                System.Func<丌丝丆三丟专万业丝, System.Double> val_30 = null;
            val_91 = val_30;
            val_30 = new System.Func<丌丝丆三丟专万业丝, System.Double>(object:  ClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Double ClanChatController.<>c::且丒丙丏不丘丅丙丑(ChatController.丌丝丆三丟专万业丝 三丟东丕丄丄下下丑));
            ClanChatController.<>c.<>9__42_4 = val_91;
        }
        
        this.丞丗丏丆丅不丑丄丒 = System.Linq.Enumerable.ToList<丌丝丆三丟专万业丝>(source:  System.Linq.Enumerable.OrderBy<丌丝丆三丟专万业丝, System.Double>(source:  this.丞丗丏丆丅不丑丄丒, keySelector:  val_30));
        goto label_67;
        label_89:
        if(this.serviceMessagePrefab == 0)
        {
                return;
        }
        
        ClanServiceMessageItem val_36 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.chatTable.gameObject, 丑且不丕与专丄业丙:  this.serviceMessagePrefab).GetComponent<ClanServiceMessageItem>();
        if(this.三丑万上丟下世上丆.Count >= 1)
        {
                UnityEngine.Vector3 val_41 = this.三丑万上丟下世上丆.Item[0].transform.position;
            val_36.transform.position = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z};
        }
        
        val_36.name = this.三丑万上丟下世上丆.Count.ToString();
        mem2[0] = this.三丑万上丟下世上丆.Count;
        this.三丑万上丟下世上丆.Add(item:  val_36);
        label_67:
        if(this.三丑万上丟下世上丆.Count < this.丞丗丏丆丅不丑丄丒.Count)
        {
            goto label_89;
        }
        
        goto label_90;
        label_108:
        if(this.三丑万上丟下世上丆 != null)
        {
                val_92 = this.三丑万上丟下世上丆.Count;
        }
        else
        {
                val_92 = 0.Count;
        }
        
        UnityEngine.Object.Destroy(obj:  this.三丑万上丟下世上丆.Item[val_92 - 1].gameObject);
        if(this.三丑万上丟下世上丆 != null)
        {
                val_93 = this.三丑万上丟下世上丆.Count;
        }
        else
        {
                val_93 = 0.Count;
        }
        
        this.三丑万上丟下世上丆.RemoveAt(index:  val_93 - 1);
        val_94 = 0;
        goto label_98;
        label_105:
        this.三丑万上丟下世上丆.Item[0].gameObject.name = 0.ToString();
        val_95 = 0;
        if(this.三丑万上丟下世上丆.Item[0] == null)
        {
                val_95 = 0;
        }
        
        mem2[0] = 0;
        val_94 = val_95 + 1;
        label_98:
        if(val_94 < this.三丑万上丟下世上丆.Count)
        {
            goto label_105;
        }
        
        label_90:
        if(this.三丑万上丟下世上丆.Count > this.丞丗丏丆丅不丑丄丒.Count)
        {
            goto label_108;
        }
        
        val_96 = null;
        val_96 = null;
        if((ClanChatController.<>c.<>9__42_5) == null)
        {
            goto label_111;
        }
        
        label_130:
        val_98 = 0;
        this.chatTable.onCustomSort = ClanChatController.<>c.<>9__42_5;
        goto label_113;
        label_116:
        this.丒丏丆世丅丟丆不一(丁丛丞丁上丅丅七业:  this.三丑万上丟下世上丆.Item[0]);
        val_98 = 1;
        label_113:
        if(val_98 < this.三丑万上丟下世上丆.Count)
        {
            goto label_116;
        }
        
        UnityEngine.Vector4 val_65 = this.丄与丌丒与且丞上业.finalClipRegion;
        UnityEngine.Vector3 val_67 = this.chatTable.transform.localPosition;
        UnityEngine.Vector3 val_69 = this.chatTable.transform.localPosition;
        this.chatTable.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.chatTable.repositionNow = true;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_73 = this.StartCoroutine(routine:  this.丑丄上东丛丂与丕世(丗丆丄世世万丛丆丈:  false));
        return;
        label_111:
        ClanChatController.<>c.<>9__42_5 = new System.Comparison<UnityEngine.Transform>(object:  ClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanChatController.<>c::丟丈世丕业专丑上丅(UnityEngine.Transform 三丟东丕丄丄下下丑, UnityEngine.Transform 丒丒丄丁且丄丆丂丌));
        if(this.chatTable != null)
        {
            goto label_130;
        }
        
        goto label_130;
    }
    private void 丒丏丆世丅丟丆不一(ClanServiceMessageItem 丁丛丞丁上丅丅七业)
    {
        var val_10;
        var val_11;
        if(丁丛丞丁上丅丅七业 != null)
        {
                val_10 = 丁丛丞丁上丅丅七业;
        }
        else
        {
                val_10 = 56;
            val_11 = 4194311;
        }
        
        bool val_3 = 丁丛丞丁上丅丅七业.gameObject.activeSelf;
        if(this.丞丗丏丆丅不丑丄丒.Count > 4194311)
        {
                if(val_3 != true)
        {
                丁丛丞丁上丅丅七业.gameObject.SetActive(value:  true);
        }
        
            int val_6 = UnityEngine.Mathf.RoundToInt(f:  this.丄与丌丒与且丞上业.width);
            丌丝丆三丟专万业丝 val_7 = this.丞丗丏丆丅不丑丄丒.Item[4194311];
            if(val_7 == null)
        {
                return;
        }
        
            this.专丂丘上丛与丁丅丌(下丅丙一丂丗丅丝七:  丁丛丞丁上丅丅七业, 丄丙下丝丛丒七丂丘:  val_7);
            return;
        }
        
        if(val_3 == false)
        {
                return;
        }
        
        丁丛丞丁上丅丅七业.gameObject.SetActive(value:  false);
    }
    private void 丕七三丅丞丞与丒七(ChatController.业丙丅世丘东丛丄丕 丄丙下丝丛丒七丂丘)
    {
        bool val_22;
        var val_23;
        var val_24;
        string val_25;
        var val_26;
        var val_27;
        SquadPanelGUI val_28;
        var val_29;
        var val_30;
        var val_31;
        string val_32;
        var val_33;
        var val_34;
        var val_35;
        val_22 = 丄丙下丝丛丒七丂丘;
        val_23 = null;
        val_23 = null;
        if((ContainsKey(key:  丄丙下丝丛丒七丂丘.三丏丙丗三专上上与)) != false)
        {
                val_24 = null;
            val_24 = null;
            val_25 = Item[丄丙下丝丛丒七丂丘.三丏丙丗三专上上与];
            if((val_25.Contains(item:  丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘)) == true)
        {
                return;
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        val_25 = 1152921504848912384;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        if(SquadController.丄丘七三上丕世丞业.IsClanSquad == false)
        {
                return;
        }
        
        val_28 = 1152921505324949504;
        val_29 = null;
        val_29 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业.isActive == false)
        {
                return;
        }
        
        string val_14 = "";
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三().TryGetValue(key:  丄丙下丝丛丒七丂丘.三丏丙丗三专上上与, value: out  0)) != false)
        {
                if((val_9.TryGetValue(key:  "player", value: out  0)) != false)
        {
                val_31 = 0;
            bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "nick", 丙业与丙丗丝不丈东: out  val_14);
        }
        
        }
        
        val_32 = "";
        val_25 = 丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘;
        val_33 = null;
        val_33 = null;
        if((val_25.Contains(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) != false)
        {
                val_34 = null;
            val_34 = null;
            val_25 = "";
            val_32 = 丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘.Substring(startIndex:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄.Length);
        }
        
        val_35 = null;
        val_35 = null;
        val_28 = SquadPanelGUI.丄丘七三上丕世丞业;
        val_22 = System.String.op_Equality(a:  丄丙下丝丛丒七丂丘.三丏丙丗三专上上与, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        val_28.AddChatMessage(不丆业丏上丐与丌业:  val_14, 丕丗丘丑丛与丑业丒:  val_25, 丛丐丌丙丈七丛丛东:  val_32, 七业丘丁丄且丂七专:  val_22);
    }
    private void 专丂丘上丛与丁丅丌(ClanServiceMessageItem 下丅丙一丂丗丅丝七, 东业专世丟不专不丕 丄丙下丝丛丒七丂丘)
    {
        string val_11 = 丄丙下丝丛丒七丂丘.丝丂丁七专一丅丛上;
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11 = 丄丙下丝丛丒七丂丘.丝丂丁七专一丅丛上)) == true) || (丄丙下丝丛丒七丂丘.丌世三丄丑丗专丙一() == 0))
        {
            goto label_5;
        }
        
        mem2[0] = 丄丙下丝丛丒七丂丘.丞丛业丆三七且丄下;
        mem2[0] = 丄丙下丝丛丒七丂丘 + 16.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture);
        下丅丙一丂丗丅丝七.SetServiceMessage();
        丏丙丘丕丙且上不东 val_6 = 丄丙下丝丛丒七丂丘.丌世三丄丑丗专丙一();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  下丅丙一丂丗丅丝七.messageLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        val_11 = 丄丙下丝丛丒七丂丘.世万丝丒丘丘且与三();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == false)
        {
            goto label_13;
        }
        
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  下丅丙一丂丗丅丝七, 丏业丟一东丂东丘丛:  false);
        return;
        label_13:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  下丅丙一丂丗丅丝七.messageLabel, 丕丗丘丑丛与丑业丒:  val_11);
        下丅丙一丂丗丅丝七.messageLabel.overflowMethod = 3;
        float val_11 = -60f;
        val_11 = (float)下丅丙一丂丗丅丝七.widget.width + val_11;
        下丅丙一丂丗丅丝七.messageLabel.width = UnityEngine.Mathf.CeilToInt(f:  val_11);
    }
    private void 专丂丘上丛与丁丅丌(ClanServiceMessageItem 下丅丙一丂丗丅丝七, ChatController.业丙丅世丘东丛丄丕 丄丙下丝丛丒七丂丘)
    {
        var val_51;
        var val_52;
        var val_53;
        string val_54;
        var val_55;
        object val_56;
        var val_57;
        var val_58;
        UILabel val_60;
        var val_61;
        var val_62;
        string val_63;
        var val_64;
        var val_65;
        val_51 = 丄丙下丝丛丒七丂丘;
        mem2[0] = 丄丙下丝丛丒七丂丘.丑丈专丙丛专丁与一;
        mem2[0] = val_51 + 16.ToString(format:  "F8", provider:  System.Globalization.CultureInfo.InvariantCulture);
        if((丄丙下丝丛丒七丂丘.三丏丙丗三专上上与.Equals(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_6;
        }
        
        下丅丙一丂丗丅丝七.SetMyMessage();
        下丅丙一丂丗丅丝七.otherMessageLabel.text = "";
        val_52 = null;
        val_52 = null;
        if((丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘.Contains(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) == false)
        {
            goto label_11;
        }
        
        val_53 = null;
        val_53 = null;
        val_54 = 丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘.Substring(startIndex:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄.Length);
        下丅丙一丂丗丅丝七.yourSmileSprite.spriteName = val_54;
        下丅丙一丂丗丅丝七.yourMessageLabel.text = "";
        下丅丙一丂丗丅丝七.yourMessageLabel.overflowMethod = 0;
        下丅丙一丂丗丅丝七.yourMessageLabel.height = 48;
        下丅丙一丂丗丅丝七.yourMessageLabel.width = 48;
        UnityEngine.GameObject val_9 = 下丅丙一丂丗丅丝七.yourSmileSprite.gameObject;
        val_55 = 1;
        goto label_23;
        label_6:
        下丅丙一丂丗丅丝七.SetOtherMessage();
        string val_25 = "";
        if(((丂与专万与丐丌丏不.丑七不且上丗丁一世().万一丈不丅丄丒不三().TryGetValue(key:  丄丙下丝丛丒七丂丘.三丏丙丗三专上上与, value: out  0)) == false) || ((val_12.TryGetValue(key:  "player", value: out  0)) == false))
        {
            goto label_52;
        }
        
        val_57 = 0;
        goto label_33;
        label_11:
        下丅丙一丂丗丅丝七.yourMessageLabel.text = 丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘;
        下丅丙一丂丗丅丝七.yourMessageLabel.overflowMethod = 3;
        float val_51 = 0.8f;
        val_51 = (float)下丅丙一丂丗丅丝七.yourWidget.width * val_51;
        val_54 = UnityEngine.Mathf.CeilToInt(f:  val_51);
        下丅丙一丂丗丅丝七.yourMessageLabel.width = val_54;
        val_55 = 0;
        label_23:
        下丅丙一丂丗丅丝七.yourSmileSprite.gameObject.SetActive(value:  false);
        if(丄丙下丝丛丒七丂丘.丏丟一专丙丏丄不丗 == false)
        {
            goto label_42;
        }
        
        System.DateTimeOffset val_19 = System.DateTimeOffset.Now;
        val_58 = val_19.m_dateTime.dateData.TotalSeconds;
        System.DateTime val_22 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (int)val_58 + 1152921505047314432);
        val_60 = 下丅丙一丂丗丅丝七.yourTimeLabel;
        goto label_47;
        label_42:
        val_60 = 下丅丙一丂丗丅丝七.yourTimeLabel;
        val_60.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1556");
        return;
        label_33:
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "nick", 丙业与丙丗丝不丈东: out  val_25)) != false)
        {
                val_56 = val_25;
            string val_30 = System.String.Format(format:  "{0}{1}: [-]", arg0:  ClanChatController.丟丛与三丆丅丝丘丆().Item[this.丑丟丝丌世丝丝丛丝(丄丒且丙三丆丟与丏:  丄丙下丝丛丒七丂丘.三丏丙丗三专上上与)], arg1:  val_56);
        }
        
        label_52:
        下丅丙一丂丗丅丝七.yourMessageLabel.text = System.String.alignConst;
        val_61 = null;
        val_61 = null;
        int val_32 = val_30.Length;
        if((丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘.Contains(value:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄)) == false)
        {
            goto label_61;
        }
        
        if(val_32 >= 28)
        {
            goto label_62;
        }
        
        val_62 = 0;
        goto label_63;
        label_61:
        val_63 = val_30;
        if(val_32 >= 28)
        {
                val_63 = val_63.Substring(startIndex:  0, length:  22)(val_63.Substring(startIndex:  0, length:  22)) + "... : [-]"("... : [-]");
        }
        
        val_54 = 下丅丙一丂丗丅丝七.otherMessageLabel;
        val_54.text = val_63 + 丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘;
        下丅丙一丂丗丅丝七.otherMessageLabel.overflowMethod = 3;
        float val_52 = 0.8f;
        val_52 = (float)下丅丙一丂丗丅丝七.otherWidget.width * val_52;
        下丅丙一丂丗丅丝七.otherMessageLabel.width = UnityEngine.Mathf.CeilToInt(f:  val_52);
        val_51 = 下丅丙一丂丗丅丝七.otherSmileSprite.gameObject;
        val_64 = 0;
        goto label_74;
        label_62:
        string val_40 = val_63.Substring(startIndex:  0, length:  22)(val_63.Substring(startIndex:  0, length:  22)) + "... : [-]"("... : [-]");
        val_62 = 3;
        label_63:
        val_65 = null;
        val_65 = null;
        val_54 = 与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄.Length;
        下丅丙一丂丗丅丝七.otherSmileSprite.spriteName = 丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘.Substring(startIndex:  val_54);
        下丅丙一丂丗丅丝七.otherMessageLabel.text = val_40;
        下丅丙一丂丗丅丝七.otherMessageLabel.overflowMethod = 0;
        下丅丙一丂丗丅丝七.otherMessageLabel.height = 48;
        var val_53 = -9;
        val_53 = val_53 - val_62;
        val_53 = val_53 + val_40.Length;
        下丅丙一丂丗丅丝七.otherMessageLabel.width = val_53 * 22;
        val_51 = 下丅丙一丂丗丅丝七.otherSmileSprite.gameObject;
        val_64 = 1;
        label_74:
        val_51.SetActive(value:  true);
        System.DateTimeOffset val_46 = System.DateTimeOffset.Now;
        val_58 = val_46.m_dateTime.dateData.TotalSeconds;
        System.DateTime val_49 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (int)val_58 + 1152921505047314432);
        val_60 = 下丅丙一丂丗丅丝七.otherTimeLabel;
        label_47:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_60, 丕丗丘丑丛与丑业丒:  val_49.dateData.丅丞万丒丙丈丙丝丗(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_49.dateData}));
    }
    private System.Collections.IEnumerator 丑丄上东丛丂与丕世(bool 丗丆丄世世万丛丆丈)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanChatController.一丘上丂不丂三丐上();
    }
    internal static void 且专丙丏丌万丙丟丏()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        ClanChatController.且三丅与不丑丐上三.Clear();
        val_2 = null;
        val_2 = null;
        ChatController.上丕万丂丕丏丟丞丙.Clear();
        ChatController.丑丈万一下丗丘丄丘.Clear();
        ChatController.丙万专丗丈丅业丘丅.Clear();
        ChatController.下丗不丒世丑丁丒专.Clear();
        ChatController.七世丙三丆与丞丑一 = 0;
        ChatController.丄丒上业丛丒丟丗丆 = 0;
        ChatController.丁与丗万丁丐丙丅丘 = 0;
        ChatController.不与丒东丐丄丞下丁(丙业与丙丗丝不丈东:  0);
        ChatController.下七丆丈且丝丝丈一();
    }
    private System.Collections.IEnumerator 上丘丕丈下丏且丂丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanChatController.丞丑与丗丏专丞丈三();
    }
    private void 丘丏丌丗三丈丒丗丞()
    {
        if(this.chatScrollView == 0)
        {
                return;
        }
        
        this.chatScrollView.ResetPosition();
        this = ???;
        goto typeof(UIScrollView).__il2cppRuntimeField_1E8;
    }
    public void SendSmile(string 丗丕万丕丌丈丈丒丕)
    {
        UnityEngine.GameObject val_4;
        var val_5;
        val_4 = this._generalChatGo;
        if(val_4.activeSelf == false)
        {
                return;
        }
        
        val_4 = this._generalChatGo;
        if(val_4.activeInHierarchy == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        this.SendChatMessage(丕丗丘丑丛与丑业丒:  System.String.alignConst, 丛丐丌丙丈七丛丛东:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄 + 丗丕万丕丌丈丈丒丕);
        this.东丗上丄且丁专万丗();
    }
    public void HandleSmileButton()
    {
        if(StickersController.不丕丗且丝与七丗丒() != false)
        {
                this.业丈丛下上丏丛丁万();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.stickersShopBanner, 丏业丟一东丂东丘丛:  true);
    }
    private void 业丈丛下上丏丛丁万()
    {
        if(this.丈不丕丑丘下丛丐下 != false)
        {
                this.东丗上丄且丁专万丗();
            return;
        }
        
        this.丘丏丗丘上丌丆业万();
    }
    internal void 东丗上丄且丁专万丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._panelSmiles, 丏业丟一东丂东丘丛:  false);
        this.丈不丕丑丘下丛丐下 = false;
    }
    private void 丘丏丗丘上丌丆业万()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._panelSmiles, 丏业丟一东丂东丘丛:  true);
        this._panelSmiles.SetDirty();
        this._panelSmiles.Refresh();
        this.丈不丕丑丘下丛丐下 = true;
    }
    public void HandleStickersShopButton()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.stickersShopBanner, 丏业丟一东丂东丘丛:  true);
    }
    public void HandleSendMesssage()
    {
        this.SendChatMessage(丕丗丘丑丛与丑业丒:  this.chatInput.value, 丛丐丌丙丈七丛丛东:  System.String.alignConst);
        this.chatInput.value = System.String.alignConst;
    }
    private void 丌丂丛丐东丞万专七()
    {
    
    }
    public void HandleChatInputChange()
    {
        var val_3 = (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.chatInput.value))) & 1;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void SendChatMessage(string 丕丗丘丑丛与丑业丒, string 丛丐丌丙丈七丛丛东)
    {
        string val_15;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        val_15 = 丛丐丌丙丈七丛丛东;
        string val_1 = 丕丗丘丑丛与丑业丒.Trim();
        val_16 = val_1;
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                if(val_16.Length < 51)
        {
            goto label_4;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  val_15)) == true)
        {
                return;
        }
        
        label_4:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.sendMessageSound);
        }
        
        if((System.String.IsNullOrEmpty(value:  val_16)) != false)
        {
                val_17 = 1;
        }
        else
        {
                val_15 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_16);
            val_17 = 0;
        }
        
        long val_10 = 专七专下且专三一且.上且一丈丐三丄一丆() + 10000000;
        val_18 = null;
        val_18 = null;
        ChatController.上丕万丂丕丏丟丞丙.Add(item:  new ChatController.业丙丅世丘东丛丄丕(专丙上丏世一丛世世:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下丘与业丗丙且业丑:  val_15, 专丐三丒下东丕世丟:  (double)val_10, 丄丘下丕丘丁丁三丕:  false, 丗下上丆一丕丂三丑:  true));
        ChatController.下七丆丈且丝丝丈一();
        val_16 = 下一丐东一丗且丒丐.丑七不且上丗丁一世();
        val_16.丆丘丟且一丕丏世丒(丈丗与丞一上且上上:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丕丗丘丑丛与丑业丒:  val_15, 丄丆万一丙丂丕不丐:  val_10);
        if((val_17 & 1) == 0)
        {
                val_16 = this.chatInput;
            val_16.value = System.String.alignConst;
        }
        
        val_19 = null;
        val_19 = null;
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  false);
        this.UpdateChatMessages(丗丆丄世世万丛丆丈:  true);
        if(this.丈不丕丑丘下丛丐下 == false)
        {
                return;
        }
        
        this.业丈丛下上丏丛丁万();
    }
    private string 丅丞万丒丙丈丙丝丗(System.DateTime 不丗万丘丆丗上丗丏)
    {
        object[] val_1 = new object[5];
        int val_2 = 不丗万丘丆丗上丗丏.dateData.Day;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = 不丗万丘丆丗上丗丏.dateData.Month;
        val_1[2] = 不丗万丘丆丗上丗丏.dateData.Year;
        val_1[3] = 不丗万丘丆丗上丗丏.dateData.Hour;
        val_1[4] = 不丗万丘丆丗上丗丏.dateData.Minute;
        return (string)System.String.Format(format:  "{0:D2}.{1:D2}.{2} {3}:{4:D2}", args:  val_1);
    }
    private void 丙丈丆丒世专专不丛(bool 丗不丛业丛丞世万专, bool 丛丆丌不万丅业上丄)
    {
        丗不丛业丛丞世万专 = 丗不丛业丛丞世万专;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanChatButtonSelectedGo, 丏业丟一东丂东丘丛:  丗不丛业丛丞世万专);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanChatButtonNotSelectedGo, 丏业丟一东丂东丘丛:  (~丗不丛业丛丞世万专) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanPrivateChatButtonSelectedGo, 丏业丟一东丂东丘丛:  丛丆丌不万丅业上丄);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanPrivateChatButtonNotSelectedGo, 丏业丟一东丂东丘丛:  (~丛丆丌不万丅业上丄) & 1);
    }
    public ClanChatController()
    {
        var val_4;
        System.Comparison<UnityEngine.Transform> val_6;
        this.丞丗丏丆丅不丑丄丒 = new System.Collections.Generic.List<丌丝丆三丟专万业丝>();
        this.三丑万上丟下世上丆 = new System.Collections.Generic.List<ClanServiceMessageItem>();
        val_4 = null;
        val_4 = null;
        val_6 = ClanChatController.<>c.<>9__63_0;
        if(val_6 == null)
        {
                System.Comparison<UnityEngine.Transform> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Comparison<UnityEngine.Transform>(object:  ClanChatController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanChatController.<>c::业七丆丌丌东丙七东(UnityEngine.Transform 三丟东丕丄丄下下丑, UnityEngine.Transform 丒丒丄丁且丄丆丂丌));
            ClanChatController.<>c.<>9__63_0 = val_6;
        }
        
        this.丝丝世上与丙丗下丏 = val_6;
    }
    private static ClanChatController()
    {
        ClanChatController.丄丞丁丈与业上丞丟 = 0;
        ClanChatController.丏专丕丂丗上丕丝与 = 0;
        ClanChatController.丄丄丗丄一下七丌七 = new UnityEngine.Color[0];
        ClanChatController.且三丅与不丑丐上三 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
    }

}
