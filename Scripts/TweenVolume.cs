using UnityEngine;
public class TweenVolume : UITweener
{
    // Fields
    public float from;
    public float to;
    private UnityEngine.AudioSource 丌丈世丄丙丑丝下丑;
    
    // Properties
    public UnityEngine.AudioSource 丞下上且一上丙不丏 { get; }
    public float 与丁万东丌丑下丏丕 { get; set; }
    public float 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    public UnityEngine.AudioSource get_audioSource()
    {
        if(this.丌丈世丄丙丑丝下丑 != 0)
        {
                return (UnityEngine.AudioSource)this.丌丈世丄丙丑丝下丑;
        }
        
        UnityEngine.AudioSource val_2 = this.GetComponent<UnityEngine.AudioSource>();
        this.丌丈世丄丙丑丝下丑 = val_2;
        if(val_2 != 0)
        {
                return (UnityEngine.AudioSource)this.丌丈世丄丙丑丝下丑;
        }
        
        UnityEngine.AudioSource val_4 = this.GetComponent<UnityEngine.AudioSource>();
        this.丌丈世丄丙丑丝下丑 = val_4;
        if(val_4 != 0)
        {
                return (UnityEngine.AudioSource)this.丌丈世丄丙丑丝下丑;
        }
        
        UnityEngine.Debug.LogError(message:  "TweenVolume needs an AudioSource to work with", context:  this);
        this.enabled = false;
        return (UnityEngine.AudioSource)this.丌丈世丄丙丑丝下丑;
    }
    public float get_volume()
    {
        return this.value;
    }
    public void set_volume(float 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public float get_value()
    {
        if(this.audioSource == 0)
        {
                return 0f;
        }
        
        if(this.丌丈世丄丙丑丝下丑 != null)
        {
                return this.丌丈世丄丙丑丝下丑.volume;
        }
        
        return this.丌丈世丄丙丑丝下丑.volume;
    }
    public void set_value(float 丙业与丙丗丝不丈东)
    {
        if(this.audioSource == 0)
        {
                return;
        }
        
        this.丌丈世丄丙丑丝下丑.volume = 丙业与丙丗丝不丈东;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_4;
        float val_5 = this.from;
        float val_4 = 1f;
        val_4 = val_4 - 丞上与七且与七三丐;
        val_5 = val_4 * val_5;
        丞上与七且与七三丐 = this.to * 丞上与七且与七三丐;
        丞上与七且与七三丐 = val_5 + 丞上与七且与七三丐;
        this.value = 丞上与七且与七三丐;
        if(this.丌丈世丄丙丑丝下丑 != null)
        {
                val_4 = this.丌丈世丄丙丑丝下丑.volume;
        }
        else
        {
                val_4 = 0.volume;
        }
        
        this.丌丈世丄丙丑丝下丑.enabled = (val_4 > 0.01f) ? 1 : 0;
    }
    public static TweenVolume Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, float 丙东丛丟下上丈丁丏)
    {
        TweenVolume val_1 = UITweener.Begin<TweenVolume>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        if(val_1 != null)
        {
                val_1.from = val_1.value;
        }
        else
        {
                mem[120] = val_1.value;
        }
        
        val_1.to = 丙东丛丟下上丈丁丏;
        if(丙东丛丟下上丈丁丏 <= 0f)
        {
                return val_1;
        }
        
        val_1.audioSource.enabled = true;
        val_1.audioSource.Play();
        return val_1;
    }
    public override void SetStartToCurrentValue()
    {
        this.from = this.value;
    }
    public override void SetEndToCurrentValue()
    {
        this.to = this.value;
    }
    public TweenVolume()
    {
        this.from = 1f;
        this.to = 1f;
    }

}
