using UnityEngine;
public class UI2DSpriteAnimation : MonoBehaviour
{
    // Fields
    protected int framerate;
    public bool ignoreTimeScale;
    public bool loop;
    public UnityEngine.Sprite[] frames;
    private UnityEngine.SpriteRenderer 东丞丅一丘与上丗且;
    private UI2DSprite 东丏丁丄丂丐专丝丕;
    private int 丄丒业专业丅丘丐丈;
    private float 七丂丄业下丏丑业丗;
    
    // Properties
    public bool 下丐丈丄丗丞丕业丆 { get; }
    public int 下丗丒丑丐丕丂东丟 { get; set; }
    
    // Methods
    public bool get_isPlaying()
    {
        return this.enabled;
    }
    public int get_framesPerSecond()
    {
        return (int)this.framerate;
    }
    public void set_framesPerSecond(int 丙业与丙丗丝不丈东)
    {
        this.framerate = 丙业与丙丗丝不丈东;
    }
    public void Play()
    {
        int val_4;
        int val_5;
        if(this.frames == null)
        {
                return;
        }
        
        if(this.frames.Length == 0)
        {
                return;
        }
        
        if((this.enabled == true) || (this.loop == true))
        {
            goto label_6;
        }
        
        val_4 = this.framerate;
        int val_3 = ((val_4 <= 0) ? (-1) : 1) + this.丄丒业专业丅丘丐丈;
        if((val_3 & 2147483648) != 0)
        {
            goto label_4;
        }
        
        if(val_3 < this.frames.Length)
        {
            goto label_6;
        }
        
        val_4 = this.framerate;
        label_4:
        if((val_4 & 2147483648) == 0)
        {
                val_5 = 0;
        }
        else
        {
                val_5 = this.frames.Length - 1;
        }
        
        this.丄丒业专业丅丘丐丈 = val_5;
        label_6:
        this.enabled = true;
        this.丅丆丒丁上丅丌丈且();
    }
    public void Pause()
    {
        this.enabled = false;
    }
    public void ResetToBeginning()
    {
        int val_1;
        if((this.framerate & 2147483648) == 0)
        {
                val_1 = 0;
        }
        else
        {
                val_1 = this.frames.Length - 1;
        }
        
        this.丄丒业专业丅丘丐丈 = val_1;
        this.丅丆丒丁上丅丌丈且();
    }
    private void Start()
    {
        this.Play();
    }
    private void Update()
    {
        if((this.frames != null) && (this.frames.Length != 0))
        {
                if(this.framerate == 0)
        {
                return;
        }
        
            if(this.ignoreTimeScale != false)
        {
                float val_1 = RealTime.time;
        }
        
            if(this.七丂丄业下丏丑业丗 >= 0)
        {
                return;
        }
        
            this.七丂丄业下丏丑业丗 = UnityEngine.Time.time;
            int val_4 = ((this.framerate <= 0) ? (-1) : 1) + this.丄丒业专业丅丘丐丈;
            if(this.loop != false)
        {
                label_10:
            this.丄丒业专业丅丘丐丈 = 万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  val_4, 七丝东丛东丝且丆不:  this.frames.Length);
            this.丅丆丒丁上丅丌丈且();
            return;
        }
        
            if((val_4 & 2147483648) == 0)
        {
                if(val_4 < this.frames.Length)
        {
            goto label_10;
        }
        
        }
        
        }
        
        this.enabled = false;
    }
    private void 丅丆丒丁上丅丌丈且()
    {
        if((this.东丞丅一丘与上丗且 == 0) && (this.东丏丁丄丂丐专丝丕 == 0))
        {
                this.东丞丅一丘与上丗且 = this.GetComponent<UnityEngine.SpriteRenderer>();
            this.东丏丁丄丂丐专丝丕 = this.GetComponent<UI2DSprite>();
            if(this.东丞丅一丘与上丗且 == 0)
        {
                if(this.东丏丁丄丂丐专丝丕 == 0)
        {
                this.enabled = false;
            return;
        }
        
        }
        
        }
        
        if(this.ignoreTimeScale != false)
        {
                float val_7 = RealTime.time;
        }
        
        if(this.framerate != 0)
        {
                float val_11 = (float)this.framerate;
            val_11 = 1f / val_11;
            float val_12 = System.Math.Abs(val_11);
            val_12 = UnityEngine.Time.time + val_12;
            this.七丂丄业下丏丑业丗 = val_12;
        }
        
        if(this.东丞丅一丘与上丗且 != 0)
        {
                this.东丞丅一丘与上丗且.sprite = this.frames[this.丄丒业专业丅丘丐丈];
            return;
        }
        
        if(this.东丏丁丄丂丐专丝丕 == 0)
        {
                return;
        }
        
        this = this.frames[this.丄丒业专业丅丘丐丈];
        this.东丏丁丄丂丐专丝丕.nextSprite = this;
    }
    public UI2DSpriteAnimation()
    {
        this.framerate = 20;
        this.ignoreTimeScale = true;
        this.loop = true;
    }

}
