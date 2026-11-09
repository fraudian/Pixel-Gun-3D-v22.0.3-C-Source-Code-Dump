using UnityEngine;
[Serializable]
public class FortCameraAnimator.LookPoint
{
    // Fields
    public bool getCameraPos;
    public string overrideItemName;
    public Rilisoft.FortItemGroupType parentSlot;
    public UnityEngine.Vector3 pos;
    public bool Preview;
    public UnityEngine.Quaternion rot;
    public bool setCameraPos;
    public Rilisoft.FortItemGroupType slot;
    public string slotName;
    
    // Methods
    public FortCameraAnimator.LookPoint()
    {
        this.slotName = "Start";
    }

}
