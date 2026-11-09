using UnityEngine;
internal class ChooseProgressWindow : MonoBehaviour
{
    // Fields
    internal static ChooseProgressWindow 丆丕丝丒不丙且丐丗;
    private static bool <且丆丅丑丁万丁且丌>k__BackingField;
    private System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> <不且丗丁不丄丝丒丂>k__BackingField;
    private bool <丙丙与丅丛三丂与丂>k__BackingField;
    public ProgressViewBase LocalProgressView;
    public ProgressViewBase ServerProgressView;
    public ProgressViewBase ChoosenProgressView;
    private UnityEngine.GameObject _chooseContainer;
    private UnityEngine.GameObject _confirmContainer;
    private 三七丄丆丁丏丕一丈 丐一丆丞不丞丗丕丈;
    private ProgressChoise 业丆丒万东七丞上丈;
    private UnityEngine.Transform 丌上世丛三丟丄丗丄;
    private System.IDisposable 丄丘业与丈丛丛丝世;
    private bool 专一丂专丞业丈丛丗;
    
    // Properties
    internal static bool 世丑丗上丘丟丐丂丕 { get; set; }
    private System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> 业丒丐丑专一万世丌 { get; set; }
    internal System.Threading.Tasks.Task<上丌一东丈丟与丘丒> 丌不丈万上世丞丈丈 { get; }
    internal bool 下丟丈业丛丙丐丁丈 { get; set; }
    
    // Methods
    internal static bool 七三丂丕丕世丙上不()
    {
        return (bool)ChooseProgressWindow.<且丆丅丑丁万丁且丌>k__BackingField;
    }
    private static void 丅丄丅万丂丗丘丕丘(bool 丙业与丙丗丝不丈东)
    {
        ChooseProgressWindow.<且丆丅丑丁万丁且丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> 万丄丈丛丒丑丌丗丌()
    {
        return (System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒>)this.<不且丗丁不丄丝丒丂>k__BackingField;
    }
    private void 丅丏丅丒丁丁丗东丗(System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> 丙业与丙丗丝不丈东)
    {
        this.<不且丗丁不丄丝丒丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Threading.Tasks.Task<上丌一东丈丟与丘丒> 丛三一与丙万七丝不()
    {
        System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> val_2 = this.<不且丗丁不丄丝丒丂>k__BackingField;
        if(val_2 != null)
        {
                return val_1.Task;
        }
        
        System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒>();
        this.<不且丗丁不丄丝丒丂>k__BackingField = val_2;
        if(val_2 != null)
        {
                return val_1.Task;
        }
        
        return val_1.Task;
    }
    internal bool 业丏世三丗丑丑丙七()
    {
        return (bool)this.<丙丙与丅丛三丂与丂>k__BackingField;
    }
    internal void 丄丟丕丐丟丅丐丂丕(bool 丙业与丙丗丝不丈东)
    {
        this.<丙丙与丅丛三丂与丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static ChooseProgressWindow 下与丞三丅丛丄七丕(UnityEngine.Transform 一丟丄丞不丕丟丌丟, ProgressChoise 丆且丄丁一丆丗且丅)
    {
        string val_16;
        var val_17;
        if((丆且丄丁一丆丗且丅 - 1) <= 3)
        {
                val_16 = mem[130688672 + ((丆且丄丁一丆丗且丅 - 1)) << 3];
            val_16 = 130688672 + ((丆且丄丁一丆丗且丅 - 1)) << 3;
        }
        else
        {
                val_16 = "";
        }
        
        if(ChooseProgressWindow.丆丕丝丒不丙且丐丗 == 0)
        {
                ChooseProgressWindow.丆丕丝丒不丙且丐丗 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕<ChooseProgressWindow>(丑与丞三且丛与丟业:  val_16, 七万上丐一丈丏丏专:  一丟丄丞不丕丟丌丟.gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        else
        {
                ChooseProgressWindow.丆丕丝丒不丙且丐丗.transform.SetParent(p:  一丟丄丞不丕丟丌丟);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            ChooseProgressWindow.丆丕丝丒不丙且丐丗.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            ChooseProgressWindow.丆丕丝丒不丙且丐丗.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            ChooseProgressWindow.丆丕丝丒不丙且丐丗.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  ChooseProgressWindow.丆丕丝丒不丙且丐丗.gameObject, 不东丛三丂丌丑专丆:  一丟丄丞不丕丟丌丟.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
        ChooseProgressWindow.<且丆丅丑丁万丁且丌>k__BackingField = true;
        丐一丆丞不丞丗丕丈 = new 业丆丄万丞且三世丁();
        val_17 = null;
        if(ChooseProgressWindow.丆丕丝丒不丙且丐丗 == null)
        {
                val_17 = null;
        }
        
        业丆丒万东七丞上丈 = 丆且丄丁一丆丗且丅;
        if(ChooseProgressWindow.丆丕丝丒不丙且丐丗 == null)
        {
                val_17 = null;
        }
        
        丌上世丛三丟丄丗丄 = 一丟丄丞不丕丟丌丟;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4._chooseContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4._confirmContainer, 丏业丟一东丂东丘丛:  false);
        return (ChooseProgressWindow)ChooseProgressWindow.丆丕丝丒不丙且丐丗;
    }
    private void OnEnable()
    {
        if(this.丄丘业与丈丛丛丝世 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        
        this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ChooseProgressWindow::U_Close()), 与且专丈不万东一万:  "Choose progress window");
    }
    private void OnDisable()
    {
        if(this.丄丘业与丈丛丛丝世 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丄丘业与丈丛丛丝世.Dispose();
    }
    internal static void 丆世与丑丆丅丐万且()
    {
        ChooseProgressWindow val_4;
        ChooseProgressWindow.<且丆丅丑丁万丁且丌>k__BackingField = false;
        val_4 = ChooseProgressWindow.丆丕丝丒不丙且丐丗;
        if(val_4 == 0)
        {
                return;
        }
        
        ChooseProgressWindow.丆丕丝丒不丙且丐丗.gameObject.SetActive(value:  false);
        val_4 = ChooseProgressWindow.丆丕丝丒不丙且丐丗.gameObject;
        UnityEngine.Object.Destroy(obj:  val_4);
        ChooseProgressWindow.丆丕丝丒不丙且丐丗 = 0;
    }
    public void U_ChooseLocalClick()
    {
        this.专一丂专丞业丈丛丗 = true;
        this.丗世专世丈丒世与万();
    }
    public void U_ConfirmClick()
    {
        this.丗世专世丈丒世与万();
    }
    public void U_CancelClick()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ChooseProgressWindow.丆丕丝丒不丙且丐丗._chooseContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ChooseProgressWindow.丆丕丝丒不丙且丐丗._confirmContainer, 丏业丟一东丂东丘丛:  false);
    }
    public void U_ChooseServerClick()
    {
        this.专一丂专丞业丈丛丗 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ChooseProgressWindow.丆丕丝丒不丙且丐丗._chooseContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ChooseProgressWindow.丆丕丝丒不丙且丐丗._confirmContainer, 丏业丟一东丂东丘丛:  true);
        this.ChoosenProgressView.一丞一丝丘丕且丒丆(一丐丗丁丞丆丅丟丄:  this.ServerProgressView.丙丘丝七业丟丁与丛());
    }
    public void U_Close()
    {
        if((this.<丙丙与丅丛三丂与丂>k__BackingField) == false)
        {
                return;
        }
        
        bool val_1 = this.<不且丗丁不丄丝丒丂>k__BackingField.TrySetCanceled();
        ChooseProgressWindow.丆世与丑丆丅丐万且();
    }
    private void 丗世专世丈丒世与万()
    {
        bool val_1 = this.专一丂专丞业丈丛丗 ^ 1;
        var val_5 = 0;
        val_5 = val_5 + 1;
        bool val_4 = this.<不且丗丁不丄丝丒丂>k__BackingField.TrySetResult(result:  this.丐一丆丞不丞丗丕丈.上丁且丐丌丁丝丟丟());
        ChooseProgressWindow.丆世与丑丆丅丐万且();
    }
    private static string 丕不三丝丗且下丆丘(ProgressChoise 丁丅丈丌丟世丗丗丟)
    {
        var val_2;
        if((丁丅丈丌丟世丗丗丟 - 1) <= 3)
        {
                val_2 = mem[130688672 + ((丁丅丈丌丟世丗丗丟 - 1)) << 3];
            val_2 = 130688672 + ((丁丅丈丌丟世丗丗丟 - 1)) << 3;
            return (string)val_2;
        }
        
        val_2 = "";
        return (string)val_2;
    }
    public ChooseProgressWindow()
    {
    
    }

}
