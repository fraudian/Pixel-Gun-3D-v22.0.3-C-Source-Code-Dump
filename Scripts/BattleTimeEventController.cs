using UnityEngine;
internal sealed class BattleTimeEventController : PGBehaviour
{
    // Fields
    public System.Collections.Generic.List<TimeAction> timeActions;
    public TimeAction currentAction;
    private UnityEngine.Animator 丌上世不丗丁丐业丕;
    
    // Methods
    private void Awake()
    {
        this.丌上世不丗丁丐业丕 = this.GetComponent<UnityEngine.Animator>();
    }
    private void Start()
    {
        this.万丗三丄丌丒专不丛();
    }
    private void 万丗三丄丌丒专不丛()
    {
        goto label_1;
        label_7:
        TimeAction val_1 = this.timeActions.Item[0];
        val_1.isPlayed = false;
        TimeAction val_2 = this.timeActions.Item[0];
        0 = 1;
        val_2.isTransitionEnd = false;
        label_1:
        if(0 < this.timeActions.Count)
        {
            goto label_7;
        }
        
        this.currentAction = 0;
    }
    internal void 丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        this.万丗三丄丌丒专不丛();
    }
    private void OnEnable()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丕丙万丛丂东丒丆万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void BattleTimeEventController::丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    private void OnDisable()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().下下丑丕且且业下丆(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void BattleTimeEventController::丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    public void ActiveEffect()
    {
        if(this.currentAction.onActive == null)
        {
                return;
        }
        
        this.currentAction.onActive.Invoke();
    }
    public void DisableEffect()
    {
        if(this.currentAction.onDisable == null)
        {
                return;
        }
        
        this.currentAction.onDisable.Invoke();
    }
    private void Update()
    {
        var val_15;
        if(TimeGameController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(this.currentAction != null)
        {
                if(this.currentAction.SmoothTransition != false)
        {
                if(this.currentAction.isTransitionEnd == false)
        {
                return;
        }
        
        }
        
            UnityEngine.AnimatorStateInfo val_2 = this.丌上世不丗丁丐业丕.GetCurrentAnimatorStateInfo(layerIndex:  0);
            if(((-582787008) & 1) != 0)
        {
                return;
        }
        
            this.currentAction = 0;
        }
        
        val_15 = 0;
        goto label_10;
        label_23:
        TimeAction val_6 = this.timeActions.Item[0];
        if(val_6.isPlayed == true)
        {
            goto label_17;
        }
        
        TimeAction val_7 = this.timeActions.Item[0];
        double val_14 = val_7.time;
        val_14 = val_14 + (-0.300000011920929);
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 < val_14)
        {
            goto label_17;
        }
        
        TimeAction val_8 = this.timeActions.Item[0];
        double val_15 = val_8.time;
        val_15 = val_15 + 0.300000011920929;
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= val_15)
        {
            goto label_21;
        }
        
        label_17:
        val_15 = 1;
        label_10:
        if(val_15 < this.timeActions.Count)
        {
            goto label_23;
        }
        
        return;
        label_21:
        this.currentAction = this.timeActions.Item[0];
        if(val_10.onTimeRemaning != null)
        {
                val_10.onTimeRemaning.Invoke();
        }
        
        this.currentAction.isPlayed = true;
        if(this.currentAction.SmoothTransition != false)
        {
                this.currentAction.isTransitionEnd = false;
            UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丘丕丛丙三与三丈丐(一丟上专丛丘且一丐:  this.currentAction));
        }
        
        UnityEngine.Debug.Log(message:  "Set state to:"("Set state to:") + this.currentAction.stateName);
    }
    private System.Collections.IEnumerator 丘丕丛丙三与三丈丐(TimeAction 一丟上专丛丘且一丐)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .一丟上专丛丘且一丐 = 一丟上专丛丘且一丐;
        return (System.Collections.IEnumerator)new BattleTimeEventController.业丐且丄丂世丑丁丌();
    }
    public BattleTimeEventController()
    {
        this.timeActions = new System.Collections.Generic.List<丞丘丒一上与丕丒且>();
    }

}
