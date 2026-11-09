using UnityEngine;
private sealed class ReusableRewardedVideo.丑丝七丈丌丆不三丏 : ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁
{
    // Fields
    private const string 丌与丌丝丛丂万不丞 = "ReusableRewardedVideo.Watching.";
    private readonly System.Threading.Tasks.TaskCompletionSource<string> 丈丐丘丐丘丘丂不与;
    
    // Properties
    internal System.Threading.Tasks.Task<string> 丁专丛七丙丘一丞丟 { get; }
    
    // Methods
    public ReusableRewardedVideo.丑丝七丈丌丆不三丏(Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专)
    {
        this.丈丐丘丐丘丘丂不与 = new System.Threading.Tasks.TaskCompletionSource<System.String>();
    }
    internal System.Threading.Tasks.Task<string> 丂丌丈丗东专丒丒丐()
    {
        if(this.丈丐丘丐丘丘丂不与 != null)
        {
                return this.丈丐丘丐丘丘丂不与.Task;
        }
        
        return this.丈丐丘丐丘丘丂不与.Task;
    }
    public override void 丗世业丞丝且丙七下(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 且东丁丄业世丞丁不, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        var val_19;
        var val_20;
        var val_21;
        System.Collections.IEnumerator val_22;
        int val_23;
        var val_24;
        ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗 val_1 = new ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗();
        if(val_1 == null)
        {
                val_19 = 0;
        }
        
        .丝且与丝丒丟万丁专 = this;
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_3 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Watching.Enter", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_3);
        }
        
        val_20 = null;
        val_20 = null;
        if(0 != 0)
        {
                0.Invoke(sender:  val_3, e:  System.EventArgs.Empty);
        }
        
        val_3.SetActive(value:  true);
        val_3.SetActive(value:  true);
        .业丘与业与上丂丝下 = 0;
        .万丕三丗下丗世丒丒 = 0;
        .丘东丐世丝丁丄丈东 = 0;
        System.Threading.Tasks.TaskCompletionSource<System.Boolean> val_4 = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
        .丞丕七七上丌不上丒 = val_4;
        .丈一丝丁不丂不七三 = val_4.Task;
        .业丘与业与上丂丝下 = new System.Action<丒丁丐丆丁丐丙且上>(object:  val_1, method:  System.Void ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗::丘一丑丅专丘丞且丟(丒丁丐丆丁丐丙且上 丂七东不不丈一丐不));
        .万丕三丗下丗世丒丒 = new System.Action(object:  val_1, method:  System.Void ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗::一东丑丞丈丐丞万丈());
        .丘东丐世丝丁丄丈东 = new System.Action<业世丒下丁东丂丏七>(object:  val_1, method:  System.Void ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗::丗东世专且丕丑与七(业世丒下丁东丂丏七 且丕丏丗三专七丟丑));
        val_21 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_11 = val_21.StartCoroutine(routine:  this.专丌丕丒丟且万丄一());
        if(UnityEngine.Application.isEditor != false)
        {
                val_22 = this.上业三丑上东一丝万();
            UnityEngine.Coroutine val_15 = CoroutineRunner.Instance.StartCoroutine(routine:  val_22);
            return;
        }
        
        IronSourceEvents.add_onRewardedVideoAdShowFailedEvent(丙业与丙丗丝不丈东:  (ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗)[1152921542249018336].业丘与业与上丂丝下);
        IronSourceEvents.add_onRewardedVideoAdRewardedEvent(丙业与丙丗丝不丈东:  (ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗)[1152921542249018336].丘东丐世丝丁丄丈东);
        IronSourceEvents.add_onRewardedVideoAdClosedEvent(丙业与丙丗丝不丈东:  (ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗)[1152921542249018336].万丕三丗下丗世丒丒);
        if(64733 == 0)
        {
                val_23 = System.String.alignConst;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_23)) == false)
        {
            goto label_25;
        }
        
        val_24 = "DefaultRewardedVideo";
        goto label_26;
        label_25:
        if(this != null)
        {
            goto label_29;
        }
        
        label_26:
        label_29:
        UnityEngine.Debug.Log(message:  "[ReusableRewardedVideo.Watching.Enter] ShowRewardedVideoWithAnalytics. placementName: "("[ReusableRewardedVideo.Watching.Enter] ShowRewardedVideoWithAnalytics. placementName: ") + System.String.__il2cppRuntimeField_static_fields);
        PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丕下丏丘丗丒丘丑丒(三七一丁上且丐丝丌:  System.String.__il2cppRuntimeField_static_fields);
    }
    public override Rilisoft.万丐丂专丏丛丑丌丑<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 丞一丙东丐且丝丞丑(Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        object val_19;
        Rilisoft.丝丌万丗三丈与丁丂<TInput> val_20;
        var val_21;
        if((丗丄下丈丑七丗丞专 != 3) && (Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false))
        {
                val_19 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Watching.React", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_19);
        }
        
        if(丗丄下丈丑七丗丞专 == 3)
        {
            goto label_5;
        }
        
        if(丗丄下丈丑七丗丞专 != 5)
        {
            goto label_10;
        }
        
        System.InvalidOperationException val_3 = null;
        val_19 = val_3;
        val_3 = new System.InvalidOperationException(message:  "Watching panel was closed manually.");
        bool val_4 = this.丈丐丘丐丘丘丂不与.TrySetException(exception:  val_3);
        label_20:
        label_22:
        Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丈丒丟上七丝且业丅, 丒且万不丌丁丂丒丟> val_6 = null;
        label_23:
        val_20 = val_6;
        label_16:
        val_6 = new Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丈丒丟上七丝且业丅, 丒且万不丌丁丂丒丟>(与丆丌丂丟丛丘丑且:  new ReusableRewardedVideo.丈丒丟上七丝且业丅(下丒丗丛丙丆丄丈专:  this));
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_20;
        label_5:
        if(this.丂丌丈丗东专丒丒丐().IsCompleted == false)
        {
            goto label_10;
        }
        
        if(this.丂丌丈丗东专丒丒丐().IsFaulted == false)
        {
            goto label_12;
        }
        
        ReusableRewardedVideo.丁丂专丝丑丗丅业丑 val_14 = new ReusableRewardedVideo.丁丂专丝丑丗丅业丑(下丒丗丛丙丆丄丈专:  this, 丁丂丕与丁丒丕丟丞:  this.丂丌丈丗东专丒丒丐().Exception.InnerException);
        goto label_16;
        label_10:
        val_21 = null;
        val_21 = null;
        val_20 = Rilisoft.丝丌万丗三丈与丁丂<TInput>.万丝上三丈下丌业与;
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_20;
        label_12:
        if(null != 0)
        {
            goto label_20;
        }
        
        if((System.String.op_Equality(a:  this.丂丌丈丗东专丒丒丐().Result, b:  "CLOSE_FINISHED")) == false)
        {
            goto label_22;
        }
        
        ReusableRewardedVideo.与丑丝与业丐丟丏丁 val_18 = new ReusableRewardedVideo.与丑丝与业丐丟丏丁(下丒丗丛丙丆丄丈专:  this);
        goto label_23;
    }
    public override void 丕丗丏东丘丑丗与丅(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 与丆丌丂丟丛丘丑且, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        object val_12;
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Watching.Exit", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        val_2.世丂丒丗丘丄丕万世(丗丛不丁丑专专丂且:  this.丂丌丈丗东专丒丒丐());
        if(this.丂丌丈丗东专丒丒丐().IsFaulted == false)
        {
            goto label_6;
        }
        
        System.AggregateException val_7 = this.丂丌丈丗东专丒丒丐().Exception;
        if(val_7 == null)
        {
            goto label_9;
        }
        
        System.Exception val_9 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  val_7.InnerExceptions);
        if(val_9 == null)
        {
            goto label_9;
        }
        
        val_12 = val_9;
        if(val_12 != null)
        {
            goto label_13;
        }
        
        label_9:
        System.AggregateException val_11 = this.丂丌丈丗东专丒丒丐().Exception;
        if(val_11 != null)
        {
                val_12 = val_11;
        }
        else
        {
                val_12 = 0;
        }
        
        label_13:
        UnityEngine.Debug.LogWarning(message:  val_12);
        label_6:
        123438416.SetActive(value:  false);
        this.SetActive(value:  false);
    }
    private System.Collections.IEnumerator 专丌丕丒丟且万丄一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ReusableRewardedVideo.丑丝七丈丌丆不三丏.万丞下丛七丞丟丘专();
    }
    private System.Collections.IEnumerator 上业三丑上东一丝万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ReusableRewardedVideo.丑丝七丈丌丆不三丏.不不丝三丝丐丌丂丁();
    }

}
