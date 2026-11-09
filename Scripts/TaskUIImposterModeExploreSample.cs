using UnityEngine;
internal sealed class TaskUIImposterModeExploreSample : TaskUIImposterModeAbstract
{
    // Fields
    private int exploreTime;
    private int tubesCount;
    private UnityEngine.Color exploreSample;
    private UnityEngine.Color goodSample;
    private UnityEngine.Color badSample;
    private UnityEngine.Transform filler;
    private UnityEngine.Vector3 startFillerPosition;
    private UnityEngine.Transform holder;
    private UnityEngine.Vector3 upPosition;
    private UnityEngine.Vector3 downPosition;
    private float holderSpeed;
    private float fillerSpeed;
    private WidgetLayout testTubeLayout;
    private TaskUIImposterNumButton testTubeExample;
    private UILabel timerLabel;
    private UISprite timerBar;
    private UnityEngine.GameObject inputBlocker;
    private UnityEngine.GameObject completeMessage;
    private UnityEngine.AudioClip moveUpClip;
    private UnityEngine.AudioClip fillerClip;
    private UnityEngine.AudioSource audioSource;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丌丏上东丞丏丙丆丌;
    private int 丟专三一丂三东世丛;
    private long 业丑丆丘三三丈丝丗;
    private bool 丂丗丐且丑丅丂专丈;
    private PlayerTaskImposterMode 世丙世丕丄世丁不万;
    private UnityEngine.Coroutine 专三丗丄业丒丝丑七;
    
    // Methods
    protected override void Awake()
    {
        this.丐不七丛丂世丅丙丙();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.timerLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10174"));
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inputBlocker, 丏业丟一东丂东丘丛:  false);
        this.holder.transform.localPosition = new UnityEngine.Vector3() {x = this.downPosition, y = V9.16B, z = V10.16B};
        this.filler.transform.localPosition = new UnityEngine.Vector3() {x = this.startFillerPosition, y = V9.16B, z = V10.16B};
        if(this.丂丗丐且丑丅丂专丈 != false)
        {
                this.丁丕丆三不东上丟丁();
        }
        else
        {
                if(this.专三丗丄业丒丝丑七 != null)
        {
                this.StopCoroutine(routine:  this.专三丗丄业丒丝丑七);
            this.专三丗丄业丒丝丑七 = 0;
        }
        
        }
        
        List.Enumerator<T> val_4 = this.丌丏上东丞丏丙丆丌.GetEnumerator();
        label_16:
        if(((-1383871496) & 1) == 0)
        {
            goto label_13;
        }
        
        string val_5 = 0.丐丏七丌丕丗业且上();
        System.Action<TaskUIImposterNumButton> val_6 = new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeExploreSample::不丞丘丟丘丝下世三(TaskUIImposterNumButton 丞丘一丐不丏世丅丘));
        val_5.丙与丏丈丘三丅丏丟(丙业与丙丗丝不丈东:  null);
        System.Action<TaskUIImposterNumButton> val_7 = new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeExploreSample::不丞丘丟丘丝下世三(TaskUIImposterNumButton 丞丘一丐不丏世丅丘));
        val_5.万丂丐丛丒万下丝一(丙业与丙丗丝不丈东:  null);
        goto label_16;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.世丕丐丂丕丅一丅七();
    }
    protected override void OnDisable()
    {
        List.Enumerator<T> val_1 = this.丌丏上东丞丏丙丆丌.GetEnumerator();
        label_4:
        if(((-1383693928) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<TaskUIImposterNumButton> val_3 = new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeExploreSample::不丞丘丟丘丝下世三(TaskUIImposterNumButton 丞丘一丐不丏世丅丘));
        0.丐丏七丌丕丗业且上().丙与丏丈丘三丅丏丟(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.世丕丐丂丕丅一丅七();
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        if((137129984 == this.世丙世丕丄世丁不万) && (this.丟专三一丂三东世丛 != 1))
        {
                if(this.丂丗丐且丑丅丂专丈 == true)
        {
            goto label_5;
        }
        
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Initialization");
        this.丟专三一丂三东世丛 = 0;
        this.业丑丆丘三三丈丝丗 = 0;
        this.丂丗丐且丑丅丂专丈 = false;
        this.丟专三一丂三东世丛 = new System.Random(Seed:  丐丕不丅三专万丕丗());
        label_5:
        this.世丙世丕丄世丁不万 = null;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
    
    }
    private void 丁丕丆三不东上丟丁()
    {
        if(this.专三丗丄业丒丝丑七 != null)
        {
                this.StopCoroutine(routine:  this.专三丗丄业丒丝丑七);
            this.专三丗丄业丒丝丑七 = 0;
        }
        
        this.专三丗丄业丒丝丑七 = this.StartCoroutine(routine:  this.一世丂一东上专丆丁());
    }
    private void 世丕丐丂丕丅一丅七()
    {
        this.audioSource.clip = 0;
        this.audioSource.loop = false;
        this.audioSource.Stop();
    }
    private System.Collections.IEnumerator 一世丂一东上专丆丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TaskUIImposterModeExploreSample.七丕丙丌世上一丑丐();
    }
    private void 丐不七丛丂世丅丙丙()
    {
        if(this.丌丏上东丞丏丙丆丌.Count > 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丌丏上东丞丏丙丆丌, 专丑业丁丗丏丌不丛:  this.testTubeExample.gameObject, 丈东丘丏与丌东东下:  this.testTubeLayout.transform, 与业丄丂丂丆下上丞:  this.tubesCount - 1, 丏东下下一丗专下丏:  0);
        this.丌丏上东丞丏丙丆丌.Insert(index:  0, item:  this.testTubeExample);
        List.Enumerator<T> val_5 = this.丌丏上东丞丏丙丆丌.GetEnumerator();
        label_12:
        if(((-1382885656) & 1) == 0)
        {
            goto label_9;
        }
        
        0.丐丏七丌丕丗业且上().color = new UnityEngine.Color() {r = this.exploreSample, g = V9.16B, b = V10.16B, a = V11.16B};
        goto label_12;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.testTubeLayout.CollectWidgets();
        this = this.testTubeLayout;
        this.Reposition();
    }
    public void U_StartExplore()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_StartExplore");
        if(this.丂丗丐且丑丅丂专丈 == true)
        {
                return;
        }
        
        if(this.专三丗丄业丒丝丑七 != null)
        {
                return;
        }
        
        this.丁丕丆三不东上丟丁();
    }
    private void 不丞丘丟丘丝下世三(TaskUIImposterNumButton 丞丘一丐不丏世丅丘)
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "OnSelectTube");
        UnityEngine.Color val_1 = 丞丘一丐不丏世丅丘.widget.color;
        if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, rhs:  new UnityEngine.Color() {r = this.badSample})) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  true);
        this.丂丗丐且丑丅丂专丈 = false;
        this.万丏丛东下丝下丟丕();
    }
    private bool 丏丁丕与丞且丈丈丑(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector3 val_3 = this.holder.transform.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, target:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, maxDistanceDelta:  UnityEngine.Time.deltaTime * this.holderSpeed);
        this.holder.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = this.holder.transform.localPosition;
        return (bool)((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z})) < 0) ? 1 : 0;
    }
    private bool 丁丈丙丂丟世丆丁丞(TaskUIImposterNumButton 丞丘一丐不丏世丅丘)
    {
        if(丞丘一丐不丏世丅丘 != 0)
        {
                UnityEngine.Vector3 val_3 = 丞丘一丐不丏世丅丘.transform.localPosition;
            this.startFillerPosition = val_3.x;
        }
        
        UnityEngine.Vector3 val_6 = this.filler.transform.localPosition;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, target:  new UnityEngine.Vector3() {x = this.startFillerPosition, y = V8.16B, z = V9.16B}, maxDistanceDelta:  UnityEngine.Time.deltaTime * this.fillerSpeed);
        this.filler.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector3 val_11 = this.filler.transform.localPosition;
        return (bool)((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = this.startFillerPosition, y = V8.16B, z = V9.16B})) < 0) ? 1 : 0;
    }
    public TaskUIImposterModeExploreSample()
    {
        this.exploreTime = 30;
        this.tubesCount = 5;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.exploreSample = val_1;
        mem[1152921537584472808] = val_1.g;
        mem[1152921537584472812] = val_1.b;
        mem[1152921537584472816] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.blue;
        this.goodSample = val_2;
        mem[1152921537584472824] = val_2.g;
        mem[1152921537584472828] = val_2.b;
        mem[1152921537584472832] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.red;
        this.badSample = val_3;
        mem[1152921537584472840] = val_3.g;
        mem[1152921537584472844] = val_3.b;
        mem[1152921537584472848] = val_3.a;
        this.holderSpeed = 300f;
        this.fillerSpeed = 400f;
        this.丌丏上东丞丏丙丆丌 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this.丟专三一丂三东世丛 = 0;
        this.业丑丆丘三三丈丝丗 = 0;
        this = new PGBehaviour();
    }

}
