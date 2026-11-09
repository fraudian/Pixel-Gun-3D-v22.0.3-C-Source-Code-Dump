using UnityEngine;
internal class BazeZoneCommand : MonoBehaviour
{
    // Fields
    public bool isFirstBaze;
    
    // Methods
    private void Awake()
    {
        var val_2 = (this.isFirstBaze == true) ? FlagController.__il2cppRuntimeField_static_fields : 1152921505062121480;
        mem2[0] = this.transform;
    }
    private void OnDestroy()
    {
        var val_1 = (this.isFirstBaze == true) ? FlagController.__il2cppRuntimeField_static_fields : 1152921505062121480;
        mem2[0] = 0;
    }
    public BazeZoneCommand()
    {
    
    }

}
