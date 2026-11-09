using UnityEngine;
internal sealed class BackgroundMusicController : MonoBehaviour
{
    // Fields
    internal static BackgroundMusicController 丄丘七三上丕世丞业;
    private UnityEngine.AudioClip[] MusicClips;
    private int 丙丏专下丙与万丘世;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    
    // Properties
    internal UnityEngine.AudioSource 上丕东丕不三一丌一 { get; }
    private bool 丌丒丕丌且丂丙业丁 { get; }
    
    // Methods
    internal UnityEngine.AudioSource 丘上丌世丑丌万丏丁()
    {
        return (UnityEngine.AudioSource)this.丞下上且一上丙不丏;
    }
    private bool 上丁不专一且七丕业()
    {
        if(this.MusicClips == null)
        {
                return false;
        }
        
        return (bool)(this.MusicClips.Length != 0) ? 1 : 0;
    }
    private void Awake()
    {
        null = null;
        BackgroundMusicController.丄丘七三上丕世丞业 = this;
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
    }
    private void Start()
    {
        var val_1;
        if((this.MusicClips != null) && (this.MusicClips.Length != 0))
        {
                this.丞下上且一上丙不丏.Stop();
            this.丞下上且一上丙不丏.loop = false;
            return;
        }
        
        val_1 = null;
        val_1 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  this.丞下上且一上丙不丏);
    }
    private void Update()
    {
        var val_4;
        if(this.MusicClips == null)
        {
                return;
        }
        
        if(this.MusicClips.Length == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == false)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏.isPlaying != false)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.clip = this.不丌丘丟业丝丆丄上(丙专上丟丏丙丟丆丑:  this.MusicClips, 丝丐七不丈丝不且七: ref  int val_2 = 0);
        this.丞下上且一上丙不丏.Play();
    }
    private void OnDestroy()
    {
        null = null;
        BackgroundMusicController.丄丘七三上丕世丞业 = 0;
    }
    private UnityEngine.AudioClip 不丌丘丟业丝丆丄上(UnityEngine.AudioClip[] 丙专上丟丏丙丟丆丑, ref int 丝丐七不丈丝不且七)
    {
        int val_5;
        var val_6;
        if((this.丙丏专下丙与万丘世 & 2147483648) != 0)
        {
            goto label_0;
        }
        
        if(this.丙丏专下丙与万丘世 == 0)
        {
            goto label_1;
        }
        
        val_5 = 丙专上丟丏丙丟丆丑.Length - 1;
        if(this.丙丏专下丙与万丘世 >= val_5)
        {
            goto label_4;
        }
        
        val_5 = this.丙丏专下丙与万丘世;
        if((UnityEngine.Random.Range(min:  0, max:  2)) == 1)
        {
            goto label_4;
        }
        
        val_6 = val_5 + 1;
        val_5 = 丙专上丟丏丙丟丆丑.Length;
        goto label_7;
        label_0:
        val_5 = 丙专上丟丏丙丟丆丑.Length;
        label_4:
        val_6 = 0;
        goto label_7;
        label_1:
        val_5 = 丙专上丟丏丙丟丆丑.Length;
        val_6 = 1;
        label_7:
        int val_2 = UnityEngine.Random.Range(min:  1, max:  val_5);
        this.丙丏专下丙与万丘世 = val_2;
        return (UnityEngine.AudioClip)丙专上丟丏丙丟丆丑[(long)val_2];
    }
    public BackgroundMusicController()
    {
        this.丙丏专下丙与万丘世 = 0;
    }
    private static BackgroundMusicController()
    {
    
    }

}
