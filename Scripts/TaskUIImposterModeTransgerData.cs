using UnityEngine;
internal sealed class TaskUIImposterModeTransgerData : TaskUIImposterModeAbstract
{
    // Fields
    private float barTime;
    private UISprite progressBar;
    private UILabel timerLabel;
    private UILabel percentLabel;
    private UnityEngine.GameObject state_Initial;
    private UnityEngine.GameObject state_Bar;
    private UnityEngine.GameObject completeMessage;
    private float 丄不丅东丑丝三丌丞;
    public UnityEngine.AudioClip fillingClip;
    public UnityEngine.AudioSource audioSource;
    private UnityEngine.Coroutine 七丌丏丒丟丝丛丆不;
    
    // Methods
    protected override void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Initial, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Bar, 丏业丟一东丂东丘丛:  false);
        this.audioSource.loop = false;
        this.audioSource.clip = 0;
        this.audioSource.Stop();
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        if(this.audioSource.isPlaying == false)
        {
                return;
        }
        
        this.audioSource.loop = false;
        this.audioSource.clip = 0;
        this.audioSource.Stop();
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.丄不丅东丑丝三丌丞 = 0f;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.丄不丅东丑丝三丌丞 = 0f;
    }
    public void U_OnStartButtonPressed()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Initial, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Bar, 丏业丟一东丂东丘丛:  true);
        this.东丞丅东不丁与丑丗();
    }
    private void 东丞丅东不丁与丑丗()
    {
        if(this.七丌丏丒丟丝丛丆不 != null)
        {
                this.StopCoroutine(routine:  this.七丌丏丒丟丝丛丆不);
            mem[1152921537600103656] = 0;
        }
        
        mem[1152921537600103656] = 1;
        this.七丌丏丒丟丝丛丆不 = this.StartCoroutine(routine:  this.七与丒丙专丝丟且与());
    }
    private System.Collections.IEnumerator 七与丒丙专丝丟且与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TaskUIImposterModeTransgerData.丁一一丅丟业丂与丘();
    }
    public TaskUIImposterModeTransgerData()
    {
        this.barTime = 10f;
        val_1 = new PGBehaviour();
    }

}
