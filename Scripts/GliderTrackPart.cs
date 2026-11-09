using UnityEngine;
public class GliderTrackPart : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform endPoint;
    public GliderTrackCheckpoint[] checkpoints;
    internal int 丈丒丕与下丛丌东丄;
    
    // Methods
    internal void Reset()
    {
        goto label_0;
        label_5:
        this.checkpoints[0].Reset();
        0 = 1;
        label_0:
        if(0 < this.checkpoints.Length)
        {
            goto label_5;
        }
    
    }
    public GliderTrackPart()
    {
        this.丈丒丕与下丛丌东丄 = 0;
    }

}
