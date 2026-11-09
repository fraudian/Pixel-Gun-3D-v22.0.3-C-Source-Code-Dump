using UnityEngine;
internal sealed class TaskUIImposterModeRefuelEngine : TaskUIImposterModeFillAbstract
{
    // Fields
    private UIBasicSprite _unFillBaseSprite;
    private UnityEngine.GameObject _greenLights;
    private UnityEngine.GameObject _redLights;
    public UnityEngine.AudioClip fillingClip;
    public UnityEngine.AudioSource audioSource;
    
    // Methods
    protected override void 丙上东丏丕丐丑丗丛(bool 丆丟专丑丁丒丁上丙)
    {
        丆丟专丑丁丒丁上丙 = 丆丟专丑丁丒丁上丙;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._greenLights, 丏业丟一东丂东丘丛:  丆丟专丑丁丒丁上丙);
        bool val_1 = (~丆丟专丑丁丒丁上丙) & 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._redLights, 丏业丟一东丂东丘丛:  val_1);
        if((val_1 & 1) == 0)
        {
                this.audioSource.clip = this.fillingClip;
            this.audioSource.loop = true;
            this.audioSource.Play();
            return;
        }
        
        this.audioSource.clip = 0;
        this.audioSource.loop = false;
        this.audioSource.Stop();
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this._unFillBaseSprite.fillAmount = 1f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._greenLights, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._redLights, 丏业丟一东丂东丘丛:  true);
        this.丗下丗丕丂丈万七丛();
    }
    protected override void 丟丛三专丗丞丌一丕()
    {
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        float val_2 = S8 + val_1;
        mem[1152921537589640696] = val_2;
        val_1 = val_2 / S9;
        float val_5 = UnityEngine.Mathf.Clamp01(value:  val_1);
        fillAmount = val_5;
        val_5 = val_5 / S1;
        val_5 = 1f - val_5;
        float val_4 = UnityEngine.Mathf.Clamp01(value:  val_5);
        this._unFillBaseSprite.fillAmount = val_4;
        if(val_4 < 1f)
        {
                return;
        }
        
        mem[1152921537589640664] = 1;
        this.万丏丛东下丝下丟丕();
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        if(this.audioSource.isPlaying == false)
        {
                return;
        }
        
        this.audioSource.clip = 0;
        this.audioSource.loop = false;
        this.audioSource.Stop();
    }
    public TaskUIImposterModeRefuelEngine()
    {
        mem[1152921537589901552] = 1092616192;
        val_1 = new PGBehaviour();
    }

}
