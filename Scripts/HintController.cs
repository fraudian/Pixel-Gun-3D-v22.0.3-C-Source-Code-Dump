using UnityEngine;
internal sealed class HintController : MonoBehaviour
{
    // Fields
    public HintController.丛丏丛丘七丏且专上 typeRegister;
    public HintObject hintObject;
    public HintController.HintItem[] hints;
    private readonly System.Collections.Generic.List<HintController.HintItem> 七上丁丌丈丁专丈丟;
    private EventDelegate 丕专且下丙丌丅丙丞;
    private static readonly System.Collections.Generic.List<HintController> 丒丛专丙丏下丘且丝;
    private HintController.HintItem 下丏七丘万业三丄丌;
    internal static bool 不丆世丛专丐丑上不;
    
    // Properties
    internal static bool 丛丈丑丝东丆丈东丞 { get; }
    internal static HintController 丄丘七三上丕世丞业 { get; }
    
    // Methods
    internal static bool 下一丌专专丐下不丕()
    {
        UnityEngine.Object val_6;
        var val_7;
        val_6 = HintController.与一丅丝不丈业与丙();
        if(val_6 != 0)
        {
                HintController val_3 = HintController.与一丅丝不丈业与丙();
            val_6 = val_3.七上丁丌丈丁专丈丟;
            var val_5 = (val_6.Count > 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    internal static HintController 与一丅丝不丈业与丙()
    {
        var val_6;
        System.Collections.Generic.List<HintController> val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = HintController.丒丛专丙丏下丘且丝;
        if(val_7.Count < 1)
        {
            goto label_4;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = HintController.丒丛专丙丏下丘且丝;
        if(val_7 == null)
        {
            goto label_7;
        }
        
        val_9 = val_7.Count;
        return (HintController)val_7.Item[val_9 - 1];
        label_4:
        val_10 = 0;
        return (HintController)val_7.Item[val_9 - 1];
        label_7:
        val_9 = 0.Count;
        return (HintController)val_7.Item[val_9 - 1];
    }
    private void Awake()
    {
        var val_1;
        if(this.typeRegister != 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        HintController.丒丛专丙丏下丘且丝.Add(item:  this);
    }
    private void OnDestroy()
    {
        var val_2;
        if(this.typeRegister != 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        bool val_1 = HintController.丒丛专丙丏下丘且丝.Remove(item:  this);
    }
    private void Start()
    {
        this.丕专且下丙丌丅丙丞 = new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "ShowNext");
        this.StartShow();
    }
    private void OnEnable()
    {
        var val_1;
        if(this.typeRegister == 1)
        {
                val_1 = null;
            val_1 = null;
            HintController.丒丛专丙丏下丘且丝.Add(item:  this);
        }
        
        this.StartShow();
    }
    private void OnDisable()
    {
        var val_2;
        if(this.typeRegister != 1)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        bool val_1 = HintController.丒丛专丙丏下丘且丝.Remove(item:  this);
    }
    private bool 世丈世丈业丕丟丛丁(HintController.HintItem 丙不丈东丒下三丛丁)
    {
        return (bool)(丙不丈东丒下三丛丁.showReason == 0) ? 1 : 0;
    }
    internal void 丄一丟丕丌业丆上丌(string 丒丘丏上丙丟丑丕丈, float 丂三丟丂丈丐丆丗丟 = 0)
    {
        HintItem[] val_6;
        var val_7;
        val_6 = this.hints;
        if(val_6 == null)
        {
                return;
        }
        
        val_7 = 0;
        goto label_2;
        label_22:
        HintItem val_7 = this.hints[0];
        if((System.String.op_Equality(a:  this.hints[0x0][0].name, b:  丒丘丏上丙丟丑丕丈)) != false)
        {
                if((this.七上丁丌丈丁专丈丟.Contains(item:  this.hints[0])) != true)
        {
                this.七上丁丌丈丁专丈丟.Add(item:  this.hints[0]);
            if(丂三丟丂丈丐丆丗丟 == 0f)
        {
                this.专丅丁万世七丒丑丕();
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丆丐与丗丅丌丛丂丗(丕丕世且下一与丝与:  丂三丟丂丈丐丆丗丟).GetEnumerator());
        }
        
        }
        
        }
        
        val_6 = this.hints;
        val_7 = 1;
        label_2:
        if(val_7 < this.hints.Length)
        {
            goto label_22;
        }
    
    }
    internal void 东丏一丁下丄丙丙丂()
    {
        var val_3;
        if(this.七上丁丌丈丁专丈丟.Count >= 1)
        {
                this.hintObject.gameObject.SetActive(value:  false);
        }
        
        val_3 = null;
        val_3 = null;
        HintController.不丆世丛专丐丑上不 = true;
    }
    internal void 丙万丞丄丐丂下丅丘()
    {
        var val_4;
        if(this.七上丁丌丈丁专丈丟.Count >= 1)
        {
                if(this.hintObject != 0)
        {
                this.hintObject.gameObject.SetActive(value:  true);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        HintController.不丆世丛专丐丑上不 = false;
    }
    internal void 三东丐丕上丑下万与(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if(this.下丏七丘万业三丄丌 != null)
        {
                if((System.String.op_Equality(a:  this.下丏七丘万业三丄丌.name, b:  丒丘丏上丙丟丑丕丈)) != false)
        {
                this.ShowNext();
            return;
        }
        
        }
        
        val_5 = 0;
        goto label_3;
        label_8:
        HintItem val_2 = this.七上丁丌丈丁专丈丟.Item[0];
        if((System.String.op_Equality(a:  val_2.name, b:  丒丘丏上丙丟丑丕丈)) == true)
        {
            goto label_6;
        }
        
        val_5 = 1;
        label_3:
        if(val_5 < this.七上丁丌丈丁专丈丟.Count)
        {
            goto label_8;
        }
        
        return;
        label_6:
        this.七上丁丌丈丁专丈丟.RemoveAt(index:  0);
    }
    public void StartShow()
    {
        var val_2;
        HintItem val_3;
        if((this.hints == null) || (this.七上丁丌丈丁专丈丟.Count != 0))
        {
            goto label_3;
        }
        
        val_2 = 0;
        goto label_4;
        label_13:
        val_3 = 0;
        HintItem val_2 = this.hints[val_3];
        if(this.hints[0x0][0].showReason == 0)
        {
                val_3 = this.hints[val_3];
            this.七上丁丌丈丁专丈丟.Add(item:  val_3);
        }
        
        val_2 = 1;
        label_4:
        if(val_2 < this.hints.Length)
        {
            goto label_13;
        }
        
        label_3:
        this.专丅丁万世七丒丑丕();
    }
    public void ShowNext()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.ShowNextD(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    public System.Collections.IEnumerable ShowNextD(float 丕丕世且下一与丝与)
    {
        HintController.丟七丆丘丈万丕丙丒 val_1 = new HintController.丟七丆丘丈万丕丙丒();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    private void 专丅丁万世七丒丑丕()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丆丐与丗丅丌丛丂丗(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    private System.Collections.IEnumerable 丆丐与丗丅丌丛丂丗(float 丕丕世且下一与丝与)
    {
        HintController.丂丐丅且丆丅一丑三 val_1 = new HintController.丂丐丅且丆丅一丑三();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    public HintController()
    {
        this.七上丁丌丈丁专丈丟 = new System.Collections.Generic.List<HintItem>();
    }
    private static HintController()
    {
        HintController.丒丛专丙丏下丘且丝 = new System.Collections.Generic.List<HintController>();
    }

}
