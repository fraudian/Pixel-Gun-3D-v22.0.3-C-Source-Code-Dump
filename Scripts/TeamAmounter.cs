using UnityEngine;
internal sealed class TeamAmounter : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject[] playerObjects;
    
    // Methods
    public void SetAmount(int 丌丒丝东丌下丕丁丅)
    {
        var val_3 = 0;
        goto label_1;
        label_11:
        if(this.playerObjects[0] != 0)
        {
                this.playerObjects[0].SetActive(value:  (val_3 < 丌丒丝东丌下丕丁丅) ? 1 : 0);
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < this.playerObjects.Length)
        {
            goto label_11;
        }
    
    }
    public TeamAmounter()
    {
    
    }

}
