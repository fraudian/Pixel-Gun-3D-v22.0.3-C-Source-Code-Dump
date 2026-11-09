using UnityEngine;
internal abstract class TaskUIImposterModeAbstract : PGBehaviour
{
    // Fields
    private UIButton leaveButton;
    protected PlayerTaskImposterMode 与世七丑丂专专丌丙;
    protected bool 丆丂三丘丄三丝丕丏;
    
    // Methods
    protected abstract void 丗下丗丕丂丈万七丛(); // 0
    protected abstract void 丛丕丌丐上东丂丟丑(); // 0
    protected virtual void Awake()
    {
    
    }
    protected virtual void OnEnable()
    {
        null = null;
        this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.taskStartClip);
    }
    protected virtual void OnDisable()
    {
    
    }
    internal void 东上业与丐丝丁万丛(PlayerTaskImposterMode 万不且且丛丆东丒业)
    {
        this.与世七丑丂专专丌丙 = 万不且且丛丆东丒业;
        this.丆丂三丘丄三丝丕丏 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.leaveButton.onClick.Clear();
        this.leaveButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void TaskUIImposterModeAbstract::CloseTask())));
    }
    protected void 丁丂专丝丑丗丅业丑(float 世与丞丄丐丑丗丐三 = 0, System.Action 业丏丈世世世丞丒世)
    {
        var val_4;
        var val_5;
        TaskUIImposterModeAbstract.丌万一一业丝丁丈丝 val_1 = null;
        val_4 = 0;
        val_1 = new TaskUIImposterModeAbstract.丌万一一业丝丁丈丝();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
        if(世与丞丄丐丑丗丐三 > 0f)
        {
                this.丆丂三丘丄三丝丕丏 = true;
            val_4 = 0;
            UnityEngine.Coroutine val_3 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  世与丞丄丐丑丗丐三, 丌专业且丛丏丞丝且:  new System.Action(object:  val_1, method:  System.Void TaskUIImposterModeAbstract.丌万一一业丝丁丈丝::不丗丒丞丗丈丟一丛()));
        }
        
        val_5 = null;
        val_5 = null;
        this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.taskFailureClip);
    }
    protected void 万丏丛东下丝下丟丕()
    {
        var val_3;
        if(this.与世七丑丂专专丌丙.丕丞丌万丞丄丘且丘 != false)
        {
                this.CloseTask();
        }
        
        this.丆丂三丘丄三丝丕丏 = true;
        val_3 = null;
        val_3 = null;
        this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.taskCompleteClip);
        this.与世七丑丂专专丌丙.丄三丙丄丞东丕丒丝();
        UnityEngine.Coroutine val_2 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  0.5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  public System.Void TaskUIImposterModeAbstract::CloseTask()));
    }
    protected void 丛不上丛一丆丛丅下(UnityEngine.AudioClip 丏世一不与丗丏三不)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  丏世一不与丗丏三不);
    }
    public void CloseTask()
    {
        var val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        val_2 = null;
        val_2 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.三东三丐下丅丐一万();
    }
    protected TaskUIImposterModeAbstract()
    {
    
    }

}
