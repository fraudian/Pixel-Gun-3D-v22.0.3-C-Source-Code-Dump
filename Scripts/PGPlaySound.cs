using UnityEngine;
internal sealed class PGPlaySound : PGBehaviour
{
    // Fields
    public UnityEngine.AudioClip clip;
    public PGPlaySound.丏三业丕丈丄丂丑东 trigger;
    
    // Methods
    private void OnEnable()
    {
        if(this.trigger != 1)
        {
                return;
        }
        
        this.三且世三丂七丐一丟(丌丏丂与丂三丐一下:  0);
    }
    private void OnDisable()
    {
        if(this.trigger != 2)
        {
                return;
        }
        
        this.三且世三丂七丐一丟(丌丏丂与丂三丐一下:  0);
    }
    private void OnClick()
    {
        if(this.trigger != 3)
        {
                return;
        }
        
        this.三且世三丂七丐一丟(丌丏丂与丂三丐一下:  0);
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_0;
        }
        
        if(this.trigger != 4)
        {
                return;
        }
        
        label_2:
        this.三且世三丂七丐一丟(丌丏丂与丂三丐一下:  0);
        return;
        label_0:
        if(this.trigger == 5)
        {
            goto label_2;
        }
    
    }
    internal void 三且世三丂七丐一丟(UnityEngine.AudioClip 丌丏丂与丂三丐一下)
    {
        UnityEngine.AudioClip val_4 = 丌丏丂与丂三丐一下;
        if(val_4 == 0)
        {
                val_4 = this.clip;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_4);
    }
    public PGPlaySound()
    {
        this.trigger = 1;
    }

}
