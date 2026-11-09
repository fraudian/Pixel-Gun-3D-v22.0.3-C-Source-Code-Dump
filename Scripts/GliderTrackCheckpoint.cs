using UnityEngine;
public class GliderTrackCheckpoint : MonoBehaviour
{
    // Fields
    public float checkpointRadius;
    public UnityEngine.GameObject effect;
    public bool hardCheckpoint;
    public UnityEngine.GameObject passedEffect;
    public PlayerSpawnPoint spawnPoint;
    public UnityEngine.AudioSource effectSound;
    internal bool 丒丛七丈不丌丕世丏;
    internal bool 一丌东一丝丄且丙丈;
    internal bool 下下东且万业丞丅丒;
    
    // Methods
    internal void Reset()
    {
        this.passedEffect.SetActive(value:  false);
        this.丒丛七丈不丌丕世丏 = false;
        this.一丌东一丝丄且丙丈 = false;
        this.丞七一丘万丄世丏丘(下下东且万业丞丅丒:  true);
    }
    internal void 与三一不业丕丝七丗(bool 丆七业丌东一万上丂)
    {
        if(this.丒丛七丈不丌丕世丏 == true)
        {
                return;
        }
        
        this.丒丛七丈不丌丕世丏 = true;
        this.一丌东一丝丄且丙丈 = 丆七业丌东一万上丂;
        if(丆七业丌东一万上丂 == false)
        {
                return;
        }
        
        this.passedEffect.SetActive(value:  true);
        this.丞七一丘万丄世丏丘(下下东且万业丞丅丒:  false);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.effectSound.Play();
    }
    internal void 丈丞不丏丑丑世丞三()
    {
        this.丒丛七丈不丌丕世丏 = false;
    }
    internal void 丞七一丘万丄世丏丘(bool 下下东且万业丞丅丒)
    {
        bool val_1 = 下下东且万业丞丅丒;
        this.effect.SetActive(value:  val_1);
        this.下下东且万业丞丅丒 = val_1;
    }
    public GliderTrackCheckpoint()
    {
    
    }

}
