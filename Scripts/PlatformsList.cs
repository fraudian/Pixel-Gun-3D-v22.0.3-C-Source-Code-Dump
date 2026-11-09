using UnityEngine;
public class PlatformsList : MonoBehaviour
{
    // Fields
    internal static PlatformsList 丄丘七三上丕世丞业;
    public PlatformController[] platforms;
    public bool predicted;
    public PlatformController[] predictedPlatforms;
    
    // Methods
    private void Start()
    {
        PlatformsList.丄丘七三上丕世丞业 = this;
        if(this.predicted == false)
        {
                return;
        }
        
        this.丌东与万丅丙万万下();
    }
    private void OnDestroy()
    {
        PlatformsList.丄丘七三上丕世丞业 = this;
    }
    private void Update()
    {
        PlatformController[] val_6;
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                return;
        }
        
        if(this.predicted != false)
        {
                val_6 = this.predictedPlatforms;
        }
        
        this.platforms = this.gameObject.transform.GetComponentsInChildren<PlatformController>();
        this.丌东与万丅丙万万下();
    }
    private void 丌东与万丅丙万万下()
    {
        byte val_3;
        if(this.predicted == false)
        {
                return;
        }
        
        val_3 = 0;
        goto label_1;
        label_6:
        PlatformController val_2 = this.platforms[0];
        this.platforms[0x0][0].index = val_3;
        val_3 = W21 + 1;
        label_1:
        if((val_3 & 255) < this.platforms.Length)
        {
            goto label_6;
        }
    
    }
    public PlatformsList()
    {
    
    }

}
