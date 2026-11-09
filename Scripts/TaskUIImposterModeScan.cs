using UnityEngine;
internal sealed class TaskUIImposterModeScan : TaskUIImposterModeAbstract
{
    // Fields
    private float barTime;
    private System.Collections.Generic.List<UILabel> scanLabels;
    private System.Collections.Generic.List<TaskUIImposterModeScan.ScanData> labelsValues;
    private UISprite progressBar;
    private UILabel timerLabel;
    private UILabel percentLabel;
    private UnityEngine.GameObject completeMessage;
    private UnityEngine.AudioClip fillingClip;
    private UnityEngine.AudioSource audioSource;
    private float 丄不丅东丑丝三丌丞;
    private UnityEngine.Coroutine 七丌丏丒丟丝丛丆不;
    
    // Methods
    protected override void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  false);
        this.OnEnable();
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void TaskUIImposterModeScan::丈丆丄三与丁丟丟丞()), 业丗七丕万万不丈丗:  1);
        this.世丕丐丂丕丅一丅七();
    }
    private void 丐丅丁东丏且丑不丌()
    {
        if(this.audioSource.isPlaying != false)
        {
                return;
        }
        
        this.audioSource.clip = this.fillingClip;
        this.audioSource.loop = true;
        this.audioSource.Play();
    }
    private void 世丕丐丂丕丅一丅七()
    {
        this.audioSource.clip = 0;
        this.audioSource.loop = false;
        this.audioSource.Stop();
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.丄不丅东丑丝三丌丞 = 0f;
        this.世丕丐丂丕丅一丅七();
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.丄不丅东丑丝三丌丞 = 0f;
        this.世丕丐丂丕丅一丅七();
    }
    private void 东丞丅东不丁与丑丗()
    {
        if(this.七丌丏丒丟丝丛丆不 != null)
        {
                this.StopCoroutine(routine:  this.七丌丏丒丟丝丛丆不);
            mem[1152921537594938056] = 0;
        }
        
        mem[1152921537594938056] = 1;
        this.七丌丏丒丟丝丛丆不 = this.StartCoroutine(routine:  this.七与丒丙专丝丟且与());
    }
    private System.Collections.IEnumerator 七与丒丙专丝丟且与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TaskUIImposterModeScan.丈丌丁丗下丅丗丐丑();
    }
    public TaskUIImposterModeScan()
    {
        this.barTime = 10f;
        val_1 = new PGBehaviour();
    }
    private void 丈丆丄三与丁丟丟丞()
    {
        if(this == 0)
        {
                return;
        }
        
        this.东丞丅东不丁与丑丗();
    }

}
