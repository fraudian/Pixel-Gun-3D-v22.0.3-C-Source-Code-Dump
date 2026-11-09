using UnityEngine;
internal class TaskUIClearSection : TaskUIImposterModeAbstract
{
    // Fields
    public UnityEngine.Transform startPos;
    public UnityEngine.Transform endPos;
    public IMDragAndDrop handlerObject;
    public float timeInSeconds;
    public UnityEngine.Animation animator;
    public UnityEngine.AnimationClip shakeAnim;
    public UnityEngine.AnimationClip trashDrop;
    public UnityEngine.AnimationClip idleAnim;
    private UnityEngine.Coroutine 万丌丑万丆丐业且丂;
    
    // Methods
    protected override void 丗下丗丕丂丈万七丛()
    {
        goto typeof(TaskUIClearSection).__il2cppRuntimeField_178;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        UnityEngine.Vector3 val_2 = this.startPos.localPosition;
        this.handlerObject.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.animator.clip = this.idleAnim;
        bool val_3 = this.animator.Play();
        if(this.万丌丑万丆丐业且丂 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.万丌丑万丆丐业且丂);
        this.万丌丑万丆丐业且丂 = 0;
    }
    private void Update()
    {
        var val_16;
        UnityEngine.Coroutine val_17;
        val_16 = this;
        if(true == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_2 = this.handlerObject.transform.localPosition;
        UnityEngine.Vector3 val_3 = this.endPos.localPosition;
        val_17 = this.万丌丑万丆丐业且丂;
        val_3.y = val_2.y - val_3.y;
        if(val_3.y <= 0.1f)
        {
            goto label_6;
        }
        
        if(val_17 != null)
        {
                this.StopCoroutine(routine:  val_17);
            this.万丌丑万丆丐业且丂 = 0;
        }
        
        if(this.animator.clip != this.shakeAnim)
        {
                return;
        }
        
        if(this.animator.isPlaying == false)
        {
                return;
        }
        
        this.animator.clip = this.idleAnim;
        bool val_7 = this.animator.Play();
        return;
        label_2:
        val_16 = ???;
        goto typeof(TaskUIClearSection).__il2cppRuntimeField_178;
        label_6:
        mem2[0] = val_16.StartCoroutine(routine:  val_16.丈丏丘丆丛世丟丅一());
    }
    private System.Collections.IEnumerator 丈丏丘丆丛世丟丅一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TaskUIClearSection.丗且丑一丗丟丌七丝();
    }
    public TaskUIClearSection()
    {
        this.timeInSeconds = 5f;
        val_1 = new PGBehaviour();
    }

}
