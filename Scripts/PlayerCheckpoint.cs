using UnityEngine;
public class PlayerCheckpoint : MonoBehaviour
{
    // Fields
    public PlayerCheckpoint back;
    public PlayerCheckpoint next;
    public bool isSavingCheckpoint;
    public UnityEngine.GameObject checkPointRespawnPoint;
    public PlayerSpawnPoint spawnPoint;
    public UnityEngine.GameObject canSaveParticle;
    public UnityEngine.GameObject savedParticle;
    public bool savedInCheckpoint;
    public bool startPoint;
    private UnityEngine.Color 三丝丛丆丁丘与丝东;
    private UnityEngine.Color 丟丝丐丗丄丗且上业;
    private UnityEngine.Color 万丝丐且不一丈丆一;
    internal float 丌七丒世丄上丞丞丁;
    
    // Methods
    private void Awake()
    {
        if(this.savedParticle != 0)
        {
                this.savedParticle.SetActive(value:  false);
        }
        
        if(this.isSavingCheckpoint == false)
        {
                return;
        }
        
        if(this.canSaveParticle == 0)
        {
                return;
        }
        
        this.canSaveParticle.SetActive(value:  true);
    }
    private void OnTriggerEnter(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_2 = null;
        if((且丙与丏下丅丐世丑.gameObject & 1) == 0)
        {
                return;
        }
        
        CheckpointController.丄丘七三上丕世丞业.RegisterInCheckpoint(丅专与丒丈丗丒丘丌:  this, 丄东丕一丟下丂上丂:  true);
    }
    private void OnTriggerExit(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_2 = null;
        if((且丙与丏下丅丐世丑.gameObject & 1) == 0)
        {
                return;
        }
        
        CheckpointController.丄丘七三上丕世丞业.RegisterInCheckpoint(丅专与丒丈丗丒丘丌:  this, 丄东丕一丟下丂上丂:  false);
    }
    public void SetCheckpointSaved(bool 不丛丙三丂一丅丂丆, bool 三万丙三丅业丂不下)
    {
        this.savedInCheckpoint = 不丛丙三丂一丅丂丆;
        if(this.canSaveParticle != 0)
        {
                this.canSaveParticle.SetActive(value:  (~不丛丙三丂一丅丂丆) & 1);
        }
        
        if(this.savedParticle == 0)
        {
                return;
        }
        
        this.savedParticle.SetActive(value:  不丛丙三丂一丅丂丆 & 三万丙三丅业丂不下);
    }
    public PlayerCheckpoint()
    {
        this.三丝丛丆丁丘与丝东 = 0;
        mem[1152921535912663368] = 0;
        mem[1152921535912663376] = 0;
        this.丟丝丐丗丄丗且上业 = 0;
        mem[1152921535912663384] = 0;
        mem[1152921535912663392] = 0;
        this.万丝丐且不一丈丆一 = 0;
        mem[1152921535912663400] = 0;
        mem[1152921535912663408] = 0;
    }

}
