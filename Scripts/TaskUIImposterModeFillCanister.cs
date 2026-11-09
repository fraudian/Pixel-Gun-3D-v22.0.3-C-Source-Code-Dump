using UnityEngine;
internal sealed class TaskUIImposterModeFillCanister : TaskUIImposterModeFillAbstract
{
    // Fields
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
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._greenLights, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._redLights, 丏业丟一东丂东丘丛:  true);
        this.丗下丗丕丂丈万七丛();
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
    public TaskUIImposterModeFillCanister()
    {
        mem[1152921537587098992] = 1092616192;
        val_1 = new PGBehaviour();
    }

}
