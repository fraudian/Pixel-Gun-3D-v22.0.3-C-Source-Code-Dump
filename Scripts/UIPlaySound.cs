using UnityEngine;
public class UIPlaySound : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip audioClip;
    public UIPlaySound.丏三业丕丈丄丂丑东 trigger;
    public float volume;
    public float pitch;
    private bool 七七丁七丁世丝不丆;
    
    // Properties
    protected bool 丑一下丅业丏丑丞丏 { get; }
    
    // Methods
    protected bool 丑下丛与丏丗丕一丒()
    {
        UnityEngine.Object val_4;
        var val_5;
        val_4 = this;
        if(this.enabled == false)
        {
            goto label_1;
        }
        
        val_4 = this.GetComponent<UIButton>();
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
        label_4:
        if(val_4 == null)
        {
            
        }
    
    }
    private void OnEnable()
    {
        float val_2 = (与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != true) ? 1f : 0f;
        this.volume = val_2;
        if(this.trigger != 6)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.audioClip, 与丁万东丌丑下丏丕:  val_2, 丟与不丄丕丞专下丛:  this.pitch);
    }
    private void OnDisable()
    {
        if(this.trigger != 7)
        {
                return;
        }
        
        UnityEngine.AudioSource val_1 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.audioClip, 与丁万东丌丑下丏丕:  this.volume, 丟与不丄丕丞专下丛:  this.pitch);
    }
    private void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        if(this.trigger == 1)
        {
                var val_1 = (this.七七丁七丁世丝不丆 == true) ? 1 : 0;
            val_1 = val_1 ^ 丟丆丕且丆丈丂丌丘;
            if(val_1 == false)
        {
                return;
        }
        
            this.七七丁七丁世丝不丆 = 丟丆丕且丆丈丂丌丘;
        }
        
        if(this.丑下丛与丏丗丕一丒() == false)
        {
                return;
        }
        
        if(丟丆丕且丆丈丂丌丘 == false)
        {
            goto label_4;
        }
        
        if(this.trigger == 1)
        {
            goto label_5;
        }
        
        return;
        label_4:
        if(this.trigger != 2)
        {
                return;
        }
        
        label_5:
        UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.audioClip, 与丁万东丌丑下丏丕:  this.volume, 丟与不丄丕丞专下丛:  this.pitch);
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        if(this.trigger == 3)
        {
                var val_1 = (this.七七丁七丁世丝不丆 == true) ? 1 : 0;
            val_1 = val_1 ^ 丆丟专丑丁丒丁上丙;
            if(val_1 == false)
        {
                return;
        }
        
            this.七七丁七丁世丝不丆 = 丆丟专丑丁丒丁上丙;
        }
        
        if(this.丑下丛与丏丗丕一丒() == false)
        {
                return;
        }
        
        if(丆丟专丑丁丒丁上丙 == false)
        {
            goto label_4;
        }
        
        if(this.trigger == 3)
        {
            goto label_5;
        }
        
        return;
        label_4:
        if(this.trigger != 4)
        {
                return;
        }
        
        label_5:
        UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.audioClip, 与丁万东丌丑下丏丕:  this.volume, 丟与不丄丕丞专下丛:  this.pitch);
    }
    private void OnClick()
    {
        if(this.丑下丛与丏丗丕一丒() == false)
        {
                return;
        }
        
        if(this.trigger != 0)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.audioClip, 与丁万东丌丑下丏丕:  this.volume, 丟与不丄丕丞专下丛:  this.pitch);
    }
    private void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(this.丑下丛与丏丗丕一丒() == false)
        {
                return;
        }
        
        if(丞丈丌且东丆丅丗万 != false)
        {
                if(UICamera.currentScheme != 2)
        {
                return;
        }
        
        }
        
        丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
        this.OnHover(丟丆丕且丆丈丂丌丘:  丞丈丌且东丆丅丗万);
    }
    public void Play()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.audioClip, 与丁万东丌丑下丏丕:  this.volume, 丟与不丄丕丞专下丛:  this.pitch);
    }
    public UIPlaySound()
    {
        this.volume = 1f;
        this.pitch = 1f;
    }

}
